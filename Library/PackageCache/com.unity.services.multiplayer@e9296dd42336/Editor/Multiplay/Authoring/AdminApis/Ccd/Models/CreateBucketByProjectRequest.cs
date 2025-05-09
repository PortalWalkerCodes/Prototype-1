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
    /// CreateBucketByProjectRequest model
    /// </summary>
    [Preserve]
    [DataContract(Name = "CreateBucketByProject_request")]
    internal class CreateBucketByProjectRequest
    {
        /// <summary>
        /// Creates an instance of CreateBucketByProjectRequest.
        /// </summary>
        /// <param name="name">name param</param>
        /// <param name="projectguid">projectguid param</param>
        /// <param name="description">description param</param>
        /// <param name="@private">@private param</param>
        [Preserve]
        public CreateBucketByProjectRequest(string name, System.Guid projectguid, string description = default, bool @private = false)
        {
            Description = description;
            Name = name;
            Private = @private;
            Projectguid = projectguid;
        }

        /// <summary>
        /// Parameter description of CreateBucketByProjectRequest
        /// </summary>
        [Preserve]
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description{ get; }
        
        /// <summary>
        /// Parameter name of CreateBucketByProjectRequest
        /// </summary>
        [Preserve]
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name{ get; }
        
        /// <summary>
        /// Parameter private of CreateBucketByProjectRequest
        /// </summary>
        [Preserve]
        [DataMember(Name = "private", EmitDefaultValue = true)]
        public bool Private{ get; }
        
        /// <summary>
        /// Parameter projectguid of CreateBucketByProjectRequest
        /// </summary>
        [Preserve]
        [DataMember(Name = "projectguid", IsRequired = true, EmitDefaultValue = true)]
        public System.Guid Projectguid{ get; }
    
        /// <summary>
        /// Formats a CreateBucketByProjectRequest into a string of key-value pairs for use as a path parameter.
        /// </summary>
        /// <returns>Returns a string representation of the key-value pairs.</returns>
        internal string SerializeAsPathParam()
        {
            var serializedModel = "";

            if (Description != null)
            {
                serializedModel += "description," + Description + ",";
            }
            if (Name != null)
            {
                serializedModel += "name," + Name + ",";
            }
            serializedModel += "private," + Private.ToString() + ",";
            if (Projectguid != null)
            {
                serializedModel += "projectguid," + Projectguid;
            }
            return serializedModel;
        }

        /// <summary>
        /// Returns a CreateBucketByProjectRequest as a dictionary of key-value pairs for use as a query parameter.
        /// </summary>
        /// <returns>Returns a dictionary of string key-value pairs.</returns>
        internal Dictionary<string, string> GetAsQueryParam()
        {
            var dictionary = new Dictionary<string, string>();

            if (Description != null)
            {
                var descriptionStringValue = Description.ToString();
                dictionary.Add("description", descriptionStringValue);
            }
            
            if (Name != null)
            {
                var nameStringValue = Name.ToString();
                dictionary.Add("name", nameStringValue);
            }
            
            var privateStringValue = Private.ToString();
            dictionary.Add("private", privateStringValue);
            
            if (Projectguid != null)
            {
                var projectguidStringValue = Projectguid.ToString();
                dictionary.Add("projectguid", projectguidStringValue);
            }
            
            return dictionary;
        }
    }
}
