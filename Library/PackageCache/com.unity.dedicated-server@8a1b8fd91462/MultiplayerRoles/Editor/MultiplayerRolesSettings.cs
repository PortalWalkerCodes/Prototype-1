using UnityEngine;
using UnityEditor;
using UnityEditor.Build;
using System.Collections.Generic;
using UnityEditor.Build.Profile;
using Unity.DedicatedServer.Editor.Internal;
using UnityEditor.Multiplayer.Internal;
using UnityEngine.Assertions;

namespace Unity.Multiplayer.Editor
{
    [FilePath("ProjectSettings/Packages/com.unity.dedicated-server/MultiplayerRolesSettings.asset", FilePathAttribute.Location.ProjectFolder)]
    internal class MultiplayerRolesSettings : ScriptableSingleton<MultiplayerRolesSettings>
    {
        private class SaveAssetsProcessor : AssetModificationProcessor
        {
            static string[] OnWillSaveAssets(string[] paths)
            {
                MultiplayerRolesSettings.instance.SaveIfDirty();
                return paths;
            }
        }

        static private MultiplayerRoleFlags GetDefaultMultiplayerRoleForBuildProfile(BuildProfile profile)
            => InternalUtility.IsServerProfile(profile) ? MultiplayerRoleFlags.Server : MultiplayerRoleFlags.Client;

        static private MultiplayerRoleFlags GetDefaultMultiplayerRoleForBuildTarget(NamedBuildTarget namedBuildTarget)
            => namedBuildTarget == NamedBuildTarget.Server ? MultiplayerRoleFlags.Server : MultiplayerRoleFlags.Client;

        // The key used for classic profiles is the platform id.
        [SerializeField] private SerializedDictionary<string, MultiplayerRoleFlags> m_MultiplayerRoleForClassicProfile = new();

        // This is a SerializedDictionary even as a private field so it persists domain reloads.
        private SerializedDictionary<BuildProfile, MultiplayerRoleData> m_MultiplayerRoleForBuildProfile = new(new InstanceIdComparer<BuildProfile>());
        private class InstanceIdComparer<T> : Comparer<T> where T : UnityEngine.Object
        {
            public override int Compare(T x, T y) => x.GetInstanceID().CompareTo(y.GetInstanceID());
        }

        internal void SaveIfDirty()
        {
            if (EditorUtility.IsDirty(this))
                Save(true);
        }

        private static MultiplayerRoleData GetMultiplayerRoleDataInAsset(string assetPath)
        {
            var assets = AssetDatabase.LoadAllAssetsAtPath(assetPath);
            var data = (MultiplayerRoleData)null;
            foreach (var asset in assets)
            {
                if (asset is MultiplayerRoleData dataInAsset)
                {
                    if (data == null)
                        data = dataInAsset;
                    else
                    {
                        // If for any reason we end up with multiple role data in the same asset, we remove the extra ones.
                        AssetDatabase.RemoveObjectFromAsset(dataInAsset);
                        EditorUtility.SetDirty(data);
                    }
                }
            }
            return data;
        }

        private static MultiplayerRoleData GetOrCreateRoleDataForBuildProfile(BuildProfile profile)
        {
            if (instance.m_MultiplayerRoleForBuildProfile.TryGetValue(profile, out var data) && data != null)
                return data;

            var assetPath = AssetDatabase.GetAssetPath(profile);
            data = assetPath != null ? GetMultiplayerRoleDataInAsset(assetPath) : null;

            if (data == null)
            {
                data = ScriptableObject.CreateInstance<MultiplayerRoleData>();
                data.name = "Multiplayer Role Data";
                data.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector;
                data.multiplayerRole = GetDefaultMultiplayerRoleForBuildProfile(profile);
            }

            instance.m_MultiplayerRoleForBuildProfile[profile] = data;
            return data;
        }

        private static void AssertValidBuildProfile(BuildProfile buildProfile)
        {
            Assert.IsNotNull(buildProfile);
            Assert.IsTrue((buildProfile.hideFlags & HideFlags.DontSave) == 0, "build profile is not valid due to hide flags");
            Assert.IsTrue(!string.IsNullOrWhiteSpace(AssetDatabase.GetAssetPath(buildProfile)), "build profile is not valid as it has not been saved to disk");
        }

        public MultiplayerRoleFlags GetMultiplayerRoleForClassicTarget(BuildTarget buildTarget, StandaloneBuildSubtarget subtarget = StandaloneBuildSubtarget.Default)
        {
            var key = EditorMultiplayerManager.GetUniqueKeyForClassicTarget(buildTarget, subtarget);
            if (m_MultiplayerRoleForClassicProfile.TryGetValue(key, out var mask))
                return mask;

            return GetDefaultMultiplayerRoleForBuildTarget(InternalUtility.GetNamedBuildTarget(buildTarget, subtarget));
        }

        public MultiplayerRoleFlags GetMultiplayerRoleForBuildProfile(BuildProfile profile)
        {
            AssertValidBuildProfile(profile);
            return GetOrCreateRoleDataForBuildProfile(profile).multiplayerRole;
        }

        public void SetMultiplayerRoleForBuildProfile(BuildProfile profile, MultiplayerRoleFlags mask)
        {
            AssertValidBuildProfile(profile);

            if (GetMultiplayerRoleForBuildProfile(profile) == mask)
                return;

            var data = GetOrCreateRoleDataForBuildProfile(profile);
            data.multiplayerRole = mask;

            if (GetDefaultMultiplayerRoleForBuildProfile(profile) == mask)
                AssetDatabase.RemoveObjectFromAsset(data);
            else if (string.IsNullOrWhiteSpace(AssetDatabase.GetAssetPath(data)))
                AssetDatabase.AddObjectToAsset(data, profile);

            EditorUtility.SetDirty(data);
        }

        public void SetMultiplayerRoleForClassicTarget(BuildTarget buildTarget, StandaloneBuildSubtarget subtarget, MultiplayerRoleFlags mask)
        {
            var key = EditorMultiplayerManager.GetUniqueKeyForClassicTarget(buildTarget, subtarget);

            if (GetDefaultMultiplayerRoleForBuildTarget(InternalUtility.GetNamedBuildTarget(buildTarget, subtarget)) == mask)
                m_MultiplayerRoleForClassicProfile.Remove(key);
            else
                m_MultiplayerRoleForClassicProfile[key] = mask;

            EditorUtility.SetDirty(this);
        }
    }
}
