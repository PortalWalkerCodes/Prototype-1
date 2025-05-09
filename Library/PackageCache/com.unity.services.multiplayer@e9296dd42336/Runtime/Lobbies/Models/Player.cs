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
using Unity.Services.Lobbies.Http;



namespace Unity.Services.Lobbies.Models
{
    /// <summary>
    /// Information about a specific player creating, joining, or already in a lobby.
    /// </summary>
    [Preserve]
    [DataContract(Name = "Player")]
    public class Player
    {
        /// <summary>
        /// Information about a specific player creating, joining, or already in a lobby.
        /// </summary>
        /// <param name="id">The unique identifier for the player.  If not provided for a create or join request, it will be set to the ID of the caller.</param>
        /// <param name="profile">profile param</param>
        /// <param name="connectionInfo">Connection information for connecting to a relay with this player.</param>
        /// <param name="data">Custom game-specific properties that apply to an individual player (e.g. &#x60;role&#x60; or &#x60;skill&#x60;).</param>
        /// <param name="allocationId">The &#x60;allocationId&#x60; from the Relay service which associates this player in this lobby with a persistent connection.  When a disconnect notification is received, this value is used to identify the associated player in a lobby to mark them as disconnected.</param>
        /// <param name="joined">The time at which the player joined the lobby.</param>
        /// <param name="lastUpdated">The last time the metadata for this player was updated.</param>
        [Preserve]
        public Player(string id = default, string connectionInfo = default, Dictionary<string, PlayerDataObject> data = default, string allocationId = default, DateTime joined = default, DateTime lastUpdated = default, PlayerProfile profile = default)
        {
            Id = id;
            Profile = profile;
            ConnectionInfo = connectionInfo;
            Data = data;
            AllocationId = allocationId;
            Joined = joined;
            LastUpdated = lastUpdated;
        }

        /// <summary>
        /// The unique identifier for the player.  If not provided for a create or join request, it will be set to the ID of the caller.
        /// </summary>
        [Preserve]
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id{ get; internal set; }
        
        /// <summary>
        /// Parameter profile of Player
        /// </summary>
        [Preserve]
        [DataMember(Name = "profile", EmitDefaultValue = false)]
        public PlayerProfile Profile{ get; set; }
        
        /// <summary>
        /// Connection information for connecting to a relay with this player.
        /// </summary>
        [Preserve]
        [DataMember(Name = "connectionInfo", EmitDefaultValue = false)]
        public string ConnectionInfo{ get; internal set; }
        
        /// <summary>
        /// Custom game-specific properties that apply to an individual player (e.g. &#x60;role&#x60; or &#x60;skill&#x60;).
        /// </summary>
        [Preserve]
        [DataMember(Name = "data", EmitDefaultValue = false)]
        public Dictionary<string, PlayerDataObject> Data{ get; set; }
        
        /// <summary>
        /// The &#x60;allocationId&#x60; from the Relay service which associates this player in this lobby with a persistent connection.  When a disconnect notification is received, this value is used to identify the associated player in a lobby to mark them as disconnected.
        /// </summary>
        [Preserve]
        [DataMember(Name = "allocationId", EmitDefaultValue = false)]
        public string AllocationId{ get; internal set; }
        
        /// <summary>
        /// The time at which the player joined the lobby.
        /// </summary>
        [Preserve]
        [DataMember(Name = "joined", EmitDefaultValue = false)]
        public DateTime Joined{ get; set; }
        
        /// <summary>
        /// The last time the metadata for this player was updated.
        /// </summary>
        [Preserve]
        [DataMember(Name = "lastUpdated", EmitDefaultValue = false)]
        public DateTime LastUpdated{ get; set; }
    
        /// <summary>
        /// Formats a Player into a string of key-value pairs for use as a path parameter.
        /// </summary>
        /// <returns>Returns a string representation of the key-value pairs.</returns>
        internal string SerializeAsPathParam()
        {
            var serializedModel = "";

            if (Id != null)
            {
                serializedModel += "id," + Id + ",";
            }
            if (Profile != null)
            {
                serializedModel += "profile," + Profile.ToString() + ",";
            }
            if (ConnectionInfo != null)
            {
                serializedModel += "connectionInfo," + ConnectionInfo + ",";
            }
            if (Data != null)
            {
                serializedModel += "data," + Data.ToString() + ",";
            }
            if (AllocationId != null)
            {
                serializedModel += "allocationId," + AllocationId + ",";
            }
            if (Joined != null)
            {
                serializedModel += "joined," + Joined.ToString() + ",";
            }
            if (LastUpdated != null)
            {
                serializedModel += "lastUpdated," + LastUpdated.ToString();
            }
            return serializedModel;
        }

        /// <summary>
        /// Returns a Player as a dictionary of key-value pairs for use as a query parameter.
        /// </summary>
        /// <returns>Returns a dictionary of string key-value pairs.</returns>
        internal Dictionary<string, string> GetAsQueryParam()
        {
            var dictionary = new Dictionary<string, string>();

            if (Id != null)
            {
                var idStringValue = Id.ToString();
                dictionary.Add("id", idStringValue);
            }
            
            if (ConnectionInfo != null)
            {
                var connectionInfoStringValue = ConnectionInfo.ToString();
                dictionary.Add("connectionInfo", connectionInfoStringValue);
            }
            
            if (AllocationId != null)
            {
                var allocationIdStringValue = AllocationId.ToString();
                dictionary.Add("allocationId", allocationIdStringValue);
            }
            
            if (Joined != null)
            {
                var joinedStringValue = Joined.ToString();
                dictionary.Add("joined", joinedStringValue);
            }
            
            if (LastUpdated != null)
            {
                var lastUpdatedStringValue = LastUpdated.ToString();
                dictionary.Add("lastUpdated", lastUpdatedStringValue);
            }
            
            return dictionary;
        }
    }
}
