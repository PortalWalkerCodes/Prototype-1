//-----------------------------------------------------------------------------
// <auto-generated>
//     This file was generated by the C# SDK Code Generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//-----------------------------------------------------------------------------


using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.Scripting;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Unity.Services.Multiplay.Authoring.Editor.AdminApis.Ccd.Http;



namespace Unity.Services.Multiplay.Authoring.Editor.AdminApis.Ccd.Models
{
    /// <summary>
    /// CcdBadgeAssign model
    /// </summary>
    [Preserve]
    [DataContract(Name = "ccd.badgeAssign")]
    internal class CcdBadgeAssign
    {
        /// <summary>
        /// Creates an instance of CcdBadgeAssign.
        /// </summary>
        /// <param name="name">name param</param>
        /// <param name="releaseid">releaseid param</param>
        /// <param name="releasenum">releasenum param</param>
        [Preserve]
        public CcdBadgeAssign(string name, System.Guid releaseid = default, long releasenum = default)
        {
            Name = name;
            Releaseid = releaseid;
            Releasenum = releasenum;
        }

        /// <summary>
        /// Parameter name of CcdBadgeAssign
        /// </summary>
        [Preserve]
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name{ get; }
        
        /// <summary>
        /// Parameter releaseid of CcdBadgeAssign
        /// </summary>
        [Preserve]
        [DataMember(Name = "releaseid", EmitDefaultValue = false)]
        public System.Guid Releaseid{ get; }
        
        /// <summary>
        /// Parameter releasenum of CcdBadgeAssign
        /// </summary>
        [Preserve]
        [DataMember(Name = "releasenum", EmitDefaultValue = false)]
        public long Releasenum{ get; }
    
        /// <summary>
        /// Formats a CcdBadgeAssign into a string of key-value pairs for use as a path parameter.
        /// </summary>
        /// <returns>Returns a string representation of the key-value pairs.</returns>
        internal string SerializeAsPathParam()
        {
            var serializedModel = "";

            if (Name != null)
            {
                serializedModel += "name," + Name + ",";
            }
            if (Releaseid != null)
            {
                serializedModel += "releaseid," + Releaseid + ",";
            }
            serializedModel += "releasenum," + Releasenum.ToString();
            return serializedModel;
        }

        /// <summary>
        /// Returns a CcdBadgeAssign as a dictionary of key-value pairs for use as a query parameter.
        /// </summary>
        /// <returns>Returns a dictionary of string key-value pairs.</returns>
        internal Dictionary<string, string> GetAsQueryParam()
        {
            var dictionary = new Dictionary<string, string>();

            if (Name != null)
            {
                var nameStringValue = Name.ToString();
                dictionary.Add("name", nameStringValue);
            }
            
            if (Releaseid != null)
            {
                var releaseidStringValue = Releaseid.ToString();
                dictionary.Add("releaseid", releaseidStringValue);
            }
            
            var releasenumStringValue = Releasenum.ToString();
            dictionary.Add("releasenum", releasenumStringValue);
            
            return dictionary;
        }
    }
}
