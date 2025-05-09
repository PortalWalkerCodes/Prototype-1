
//-----------------------------------------------------------------------------
// <auto-generated>
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//-----------------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace Unity.Services.Authentication.Shared
{
    /// <summary>
    /// A URI builder
    /// </summary>
    internal class ApiRequestPathBuilder
    {
        private string _baseUrl;
        private string _path;
        private string _query = "?";

        /// <summary>
        /// The URI builder constructor
        /// </summary>
        /// <param name="baseUrl">The base url.</param>
        /// <param name="path">The path.</param>
        public ApiRequestPathBuilder(string baseUrl, string path)
        {
            _baseUrl = baseUrl;
            _path = path;
        }

        /// <summary>
        /// Add path parameters
        /// </summary>
        /// <param name="parameters">The dictionary of parameters to add</param>
        public void AddPathParameters(Dictionary<string, string> parameters)
        {
            foreach (var parameter in parameters)
            {
                _path = _path.Replace("{" + parameter.Key + "}", Uri.EscapeDataString(parameter.Value));
            }
        }

        /// <summary>
        /// Add query parameters
        /// </summary>
        /// <param name="parameters">The map of parameters to add</param>
        public void AddQueryParameters(Multimap<string, string> parameters)
        {
            foreach (var parameter in parameters)
            {
                foreach (var value in parameter.Value)
                {
                    _query = _query + parameter.Key + "=" + Uri.EscapeDataString(value) + "&";
                }
            }
        }

        /// <summary>
        /// Get the full url
        /// </summary>
        /// <returns>Returns the full url</returns>
        public string GetFullUri()
        {
            return _baseUrl + _path + _query.Substring(0, _query.Length - 1);
        }
    }
}
