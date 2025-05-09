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
    /// CcdReleaseentry model
    /// </summary>
    [Preserve]
    [DataContract(Name = "ccd.releaseentry")]
    internal class CcdReleaseentry
    {
        /// <summary>
        /// Creates an instance of CcdReleaseentry.
        /// </summary>
        /// <param name="changeState">changeState param</param>
        /// <param name="complete">complete param</param>
        /// <param name="contentHash">contentHash param</param>
        /// <param name="contentLink">contentLink param</param>
        /// <param name="contentSize">contentSize param</param>
        /// <param name="contentType">contentType param</param>
        /// <param name="entryid">entryid param</param>
        /// <param name="labels">labels param</param>
        /// <param name="lastModified">lastModified param</param>
        /// <param name="lastModifiedBy">lastModifiedBy param</param>
        /// <param name="lastModifiedByName">lastModifiedByName param</param>
        /// <param name="link">link param</param>
        /// <param name="metadata">metadata param</param>
        /// <param name="path">path param</param>
        /// <param name="updatedAt">updatedAt param</param>
        /// <param name="versionid">versionid param</param>
        [Preserve]
        public CcdReleaseentry(ChangeStateOptions changeState = default, bool complete = default, string contentHash = default, string contentLink = default, long contentSize = default, string contentType = default, System.Guid entryid = default, List<string> labels = default, DateTime lastModified = default, string lastModifiedBy = default, string lastModifiedByName = default, string link = default, object metadata = default, string path = default, DateTime updatedAt = default, System.Guid versionid = default)
        {
            ChangeState = changeState;
            Complete = complete;
            ContentHash = contentHash;
            ContentLink = contentLink;
            ContentSize = contentSize;
            ContentType = contentType;
            Entryid = entryid;
            Labels = labels;
            LastModified = lastModified;
            LastModifiedBy = lastModifiedBy;
            LastModifiedByName = lastModifiedByName;
            Link = link;
            Metadata = (IDeserializable) JsonObject.GetNewJsonObjectResponse(metadata);
            Path = path;
            UpdatedAt = updatedAt;
            Versionid = versionid;
        }

        /// <summary>
        /// Parameter change_state of CcdReleaseentry
        /// </summary>
        [Preserve]
        [JsonConverter(typeof(StringEnumConverter))]
        [DataMember(Name = "change_state", EmitDefaultValue = false)]
        public ChangeStateOptions ChangeState{ get; }
        
        /// <summary>
        /// Parameter complete of CcdReleaseentry
        /// </summary>
        [Preserve]
        [DataMember(Name = "complete", EmitDefaultValue = true)]
        public bool Complete{ get; }
        
        /// <summary>
        /// Parameter content_hash of CcdReleaseentry
        /// </summary>
        [Preserve]
        [DataMember(Name = "content_hash", EmitDefaultValue = false)]
        public string ContentHash{ get; }
        
        /// <summary>
        /// Parameter content_link of CcdReleaseentry
        /// </summary>
        [Preserve]
        [DataMember(Name = "content_link", EmitDefaultValue = false)]
        public string ContentLink{ get; }
        
        /// <summary>
        /// Parameter content_size of CcdReleaseentry
        /// </summary>
        [Preserve]
        [DataMember(Name = "content_size", EmitDefaultValue = false)]
        public long ContentSize{ get; }
        
        /// <summary>
        /// Parameter content_type of CcdReleaseentry
        /// </summary>
        [Preserve]
        [DataMember(Name = "content_type", EmitDefaultValue = false)]
        public string ContentType{ get; }
        
        /// <summary>
        /// Parameter entryid of CcdReleaseentry
        /// </summary>
        [Preserve]
        [DataMember(Name = "entryid", EmitDefaultValue = false)]
        public System.Guid Entryid{ get; }
        
        /// <summary>
        /// Parameter labels of CcdReleaseentry
        /// </summary>
        [Preserve]
        [DataMember(Name = "labels", EmitDefaultValue = false)]
        public List<string> Labels{ get; }
        
        /// <summary>
        /// Parameter last_modified of CcdReleaseentry
        /// </summary>
        [Preserve]
        [DataMember(Name = "last_modified", EmitDefaultValue = false)]
        public DateTime LastModified{ get; }
        
        /// <summary>
        /// Parameter last_modified_by of CcdReleaseentry
        /// </summary>
        [Preserve]
        [DataMember(Name = "last_modified_by", EmitDefaultValue = false)]
        public string LastModifiedBy{ get; }
        
        /// <summary>
        /// Parameter last_modified_by_name of CcdReleaseentry
        /// </summary>
        [Preserve]
        [DataMember(Name = "last_modified_by_name", EmitDefaultValue = false)]
        public string LastModifiedByName{ get; }
        
        /// <summary>
        /// Parameter link of CcdReleaseentry
        /// </summary>
        [Preserve]
        [DataMember(Name = "link", EmitDefaultValue = false)]
        public string Link{ get; }
        
        /// <summary>
        /// Parameter metadata of CcdReleaseentry
        /// </summary>
        [Preserve][JsonConverter(typeof(JsonObjectConverter))]
        [DataMember(Name = "metadata", EmitDefaultValue = false)]
        public IDeserializable Metadata{ get; }
        
        /// <summary>
        /// Parameter path of CcdReleaseentry
        /// </summary>
        [Preserve]
        [DataMember(Name = "path", EmitDefaultValue = false)]
        public string Path{ get; }
        
        /// <summary>
        /// Parameter updated_at of CcdReleaseentry
        /// </summary>
        [Preserve]
        [DataMember(Name = "updated_at", EmitDefaultValue = false)]
        public DateTime UpdatedAt{ get; }
        
        /// <summary>
        /// Parameter versionid of CcdReleaseentry
        /// </summary>
        [Preserve]
        [DataMember(Name = "versionid", EmitDefaultValue = false)]
        public System.Guid Versionid{ get; }
    
        /// <summary>
        /// Defines ChangeState
        /// </summary>
        [Preserve]
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ChangeStateOptions
        {
            /// <summary>
            /// Enum Unchanged for value: Unchanged
            /// </summary>
            [EnumMember(Value = "Unchanged")]
            Unchanged = 1,
            /// <summary>
            /// Enum Add for value: Add
            /// </summary>
            [EnumMember(Value = "Add")]
            Add = 2,
            /// <summary>
            /// Enum Delete for value: Delete
            /// </summary>
            [EnumMember(Value = "Delete")]
            Delete = 3,
            /// <summary>
            /// Enum Update for value: Update
            /// </summary>
            [EnumMember(Value = "Update")]
            Update = 4
        }

        /// <summary>
        /// Formats a CcdReleaseentry into a string of key-value pairs for use as a path parameter.
        /// </summary>
        /// <returns>Returns a string representation of the key-value pairs.</returns>
        internal string SerializeAsPathParam()
        {
            var serializedModel = "";

            serializedModel += "change_state," + ChangeState + ",";
            serializedModel += "complete," + Complete.ToString() + ",";
            if (ContentHash != null)
            {
                serializedModel += "content_hash," + ContentHash + ",";
            }
            if (ContentLink != null)
            {
                serializedModel += "content_link," + ContentLink + ",";
            }
            serializedModel += "content_size," + ContentSize.ToString() + ",";
            if (ContentType != null)
            {
                serializedModel += "content_type," + ContentType + ",";
            }
            if (Entryid != null)
            {
                serializedModel += "entryid," + Entryid + ",";
            }
            if (Labels != null)
            {
                serializedModel += "labels," + Labels.ToString() + ",";
            }
            if (LastModified != null)
            {
                serializedModel += "last_modified," + LastModified.ToString() + ",";
            }
            if (LastModifiedBy != null)
            {
                serializedModel += "last_modified_by," + LastModifiedBy + ",";
            }
            if (LastModifiedByName != null)
            {
                serializedModel += "last_modified_by_name," + LastModifiedByName + ",";
            }
            if (Link != null)
            {
                serializedModel += "link," + Link + ",";
            }
            if (Metadata != null)
            {
                serializedModel += "metadata," + Metadata.ToString() + ",";
            }
            if (Path != null)
            {
                serializedModel += "path," + Path + ",";
            }
            if (UpdatedAt != null)
            {
                serializedModel += "updated_at," + UpdatedAt.ToString() + ",";
            }
            if (Versionid != null)
            {
                serializedModel += "versionid," + Versionid;
            }
            return serializedModel;
        }

        /// <summary>
        /// Returns a CcdReleaseentry as a dictionary of key-value pairs for use as a query parameter.
        /// </summary>
        /// <returns>Returns a dictionary of string key-value pairs.</returns>
        internal Dictionary<string, string> GetAsQueryParam()
        {
            var dictionary = new Dictionary<string, string>();

            var change_stateStringValue = ChangeState.ToString();
            dictionary.Add("change_state", change_stateStringValue);
            
            var completeStringValue = Complete.ToString();
            dictionary.Add("complete", completeStringValue);
            
            if (ContentHash != null)
            {
                var content_hashStringValue = ContentHash.ToString();
                dictionary.Add("content_hash", content_hashStringValue);
            }
            
            if (ContentLink != null)
            {
                var content_linkStringValue = ContentLink.ToString();
                dictionary.Add("content_link", content_linkStringValue);
            }
            
            var content_sizeStringValue = ContentSize.ToString();
            dictionary.Add("content_size", content_sizeStringValue);
            
            if (ContentType != null)
            {
                var content_typeStringValue = ContentType.ToString();
                dictionary.Add("content_type", content_typeStringValue);
            }
            
            if (Entryid != null)
            {
                var entryidStringValue = Entryid.ToString();
                dictionary.Add("entryid", entryidStringValue);
            }
            
            if (Labels != null)
            {
                var labelsStringValue = Labels.ToString();
                dictionary.Add("labels", labelsStringValue);
            }
            
            if (LastModified != null)
            {
                var last_modifiedStringValue = LastModified.ToString();
                dictionary.Add("last_modified", last_modifiedStringValue);
            }
            
            if (LastModifiedBy != null)
            {
                var last_modified_byStringValue = LastModifiedBy.ToString();
                dictionary.Add("last_modified_by", last_modified_byStringValue);
            }
            
            if (LastModifiedByName != null)
            {
                var last_modified_by_nameStringValue = LastModifiedByName.ToString();
                dictionary.Add("last_modified_by_name", last_modified_by_nameStringValue);
            }
            
            if (Link != null)
            {
                var linkStringValue = Link.ToString();
                dictionary.Add("link", linkStringValue);
            }
            
            if (Path != null)
            {
                var pathStringValue = Path.ToString();
                dictionary.Add("path", pathStringValue);
            }
            
            if (UpdatedAt != null)
            {
                var updated_atStringValue = UpdatedAt.ToString();
                dictionary.Add("updated_at", updated_atStringValue);
            }
            
            if (Versionid != null)
            {
                var versionidStringValue = Versionid.ToString();
                dictionary.Add("versionid", versionidStringValue);
            }
            
            return dictionary;
        }
    }
}
