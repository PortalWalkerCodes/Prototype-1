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
using Unity.Services.Relay.Http;



namespace Unity.Services.Relay.Models
{
    /// <summary>
    /// JoinData model
    /// </summary>
    [Preserve]
    [DataContract(Name = "JoinData")]
    public class JoinData
    {
        /// <summary>
        /// Creates an instance of JoinData.
        /// </summary>
        /// <param name="allocation">allocation param</param>
        [Preserve]
        public JoinData(JoinAllocation allocation)
        {
            Allocation = allocation;
        }

        /// <summary>
        /// Parameter allocation of JoinData
        /// </summary>
        [Preserve]
        [DataMember(Name = "allocation", IsRequired = true, EmitDefaultValue = true)]
        public JoinAllocation Allocation{ get; }

        /// <summary>
        /// Formats a JoinData into a string of key-value pairs for use as a path parameter.
        /// </summary>
        /// <returns>Returns a string representation of the key-value pairs.</returns>
        internal string SerializeAsPathParam()
        {
            var serializedModel = "";

            if (Allocation != null)
            {
                serializedModel += "allocation," + Allocation.ToString();
            }
            return serializedModel;
        }

        /// <summary>
        /// Returns a JoinData as a dictionary of key-value pairs for use as a query parameter.
        /// </summary>
        /// <returns>Returns a dictionary of string key-value pairs.</returns>
        internal Dictionary<string, string> GetAsQueryParam()
        {
            var dictionary = new Dictionary<string, string>();

            return dictionary;
        }
    }
}
