#if UNITY_EDITOR || ENABLE_RUNTIME_ADMIN_APIS
//-----------------------------------------------------------------------------
// <auto-generated>
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//-----------------------------------------------------------------------------
using System.Runtime.Serialization;
using UnityEngine.Scripting;

namespace Unity.Services.Multiplayer.Editor.Matchmaker.Authoring.AdminApi.Matchmaker.Model
{
    /// <summary>
    /// RuleExternalData
    /// </summary>
    [DataContract(Name = "Rule_externalData")]
    [Preserve]
    partial class RuleExternalData
    {
        /// <summary>
        /// Gets or Sets Leaderboard
        /// </summary>
        [DataMember(Name = "leaderboard", EmitDefaultValue = false)]
        [Preserve]
        public RuleExternalDataLeaderboard Leaderboard { get; set; }

        /// <summary>
        /// Gets or Sets CloudSave
        /// </summary>
        [DataMember(Name = "cloudSave", EmitDefaultValue = false)]
        [Preserve]
        public RuleExternalDataCloudSave CloudSave { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="RuleExternalData" /> class.
        /// </summary>
        /// <param name="leaderboard">leaderboard.</param>
        /// <param name="cloudSave">cloudSave.</param>
        [Preserve]
        public RuleExternalData(RuleExternalDataLeaderboard leaderboard = default(RuleExternalDataLeaderboard), RuleExternalDataCloudSave cloudSave = default(RuleExternalDataCloudSave))
        {
            this.Leaderboard = leaderboard;
            this.CloudSave = cloudSave;
        }
    }

}
#endif
