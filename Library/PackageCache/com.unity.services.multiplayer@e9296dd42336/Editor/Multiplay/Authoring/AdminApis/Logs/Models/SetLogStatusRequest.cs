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
using Unity.Services.Multiplay.Authoring.Editor.AdminApis.Logs.Http;



namespace Unity.Services.Multiplay.Authoring.Editor.AdminApis.Logs.Models
{
    /// <summary>
    /// Request to set the logging status to either true or false
    /// </summary>
    [Preserve]
    [DataContract(Name = "Set_Log_Status_Request")]
    internal class SetLogStatusRequest
    {
        /// <summary>
        /// Request to set the logging status to either true or false
        /// </summary>
        /// <param name="enabled">Flag denoting whether or not logging should be enabled or disabled - true/false is expected</param>
        [Preserve]
        public SetLogStatusRequest(bool enabled)
        {
            Enabled = enabled;
        }

        /// <summary>
        /// Flag denoting whether or not logging should be enabled or disabled - true/false is expected
        /// </summary>
        [Preserve]
        [DataMember(Name = "enabled", IsRequired = true, EmitDefaultValue = true)]
        public bool Enabled{ get; }

        /// <summary>
        /// Formats a SetLogStatusRequest into a string of key-value pairs for use as a path parameter.
        /// </summary>
        /// <returns>Returns a string representation of the key-value pairs.</returns>
        internal string SerializeAsPathParam()
        {
            var serializedModel = "";

            serializedModel += "enabled," + Enabled.ToString();
            return serializedModel;
        }

        /// <summary>
        /// Returns a SetLogStatusRequest as a dictionary of key-value pairs for use as a query parameter.
        /// </summary>
        /// <returns>Returns a dictionary of string key-value pairs.</returns>
        internal Dictionary<string, string> GetAsQueryParam()
        {
            var dictionary = new Dictionary<string, string>();

            var enabledStringValue = Enabled.ToString();
            dictionary.Add("enabled", enabledStringValue);

            return dictionary;
        }
    }
}
