using UnityEditor;
using UnityEditor.Build;
using UnityEditor.Build.Profile;

namespace Unity.DedicatedServer.Editor.Internal
{
    internal static class InternalUtility
    {
        // This is the only internal API we should access from the BuildProfile module
        public static void GetBuildProfileInternalData(BuildProfile buildProfile, out StandaloneBuildSubtarget buildSubtarget, out BuildTarget buildTarget, out string platformId)
        {
            buildSubtarget = buildProfile.subtarget;
            buildTarget = buildProfile.buildTarget;
            platformId = buildProfile.platformId;
        }

        public static bool IsStandalonePlatform(BuildTarget buildTarget)
            => BuildPipeline.GetBuildTargetGroup(buildTarget) == BuildTargetGroup.Standalone;

        public static bool IsServerProfile(BuildProfile buildProfile)
        {
            GetBuildProfileInternalData(buildProfile, out var buildSubtarget, out var buildTarget, out _);
            return buildSubtarget == StandaloneBuildSubtarget.Server && IsStandalonePlatform(buildTarget);
        }

        public static bool IsClassicProfile(BuildProfile buildProfile)
        {
            return (buildProfile.hideFlags & UnityEngine.HideFlags.DontSave) != 0;
        }

        public static NamedBuildTarget GetNamedBuildTarget(BuildTarget buildTarget, StandaloneBuildSubtarget subtarget)
        {
            if (subtarget == StandaloneBuildSubtarget.Server && IsStandalonePlatform(buildTarget))
                return NamedBuildTarget.Server;

            return NamedBuildTarget.FromBuildTargetGroup(BuildPipeline.GetBuildTargetGroup(buildTarget));
        }
    }
}
