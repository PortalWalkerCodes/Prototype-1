
//-----------------------------------------------------------------------------
// <auto-generated>
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace Unity.Services.Multiplayer.Editor.Matchmaker.Authoring.AdminApi.Shared
{
    /// <summary>
    /// Represents a configuration contract.
    /// </summary>
    interface IApiConfiguration
    {
        /// <summary>
        /// Gets the access token.
        /// </summary>
        /// <value>Access token.</value>
        string AccessToken { get; set; }

        /// <summary>
        /// Gets the API key.
        /// </summary>
        /// <value>API key.</value>
        IDictionary<string, string> ApiKey { get; set; }

        /// <summary>
        /// Gets the API key prefix.
        /// </summary>
        /// <value>API key prefix.</value>
        IDictionary<string, string> ApiKeyPrefix { get; set; }

        /// <summary>
        /// Gets the default headers.
        /// </summary>
        /// <value>Default headers.</value>
        IDictionary<string, string> DefaultHeaders { get; set; }

        /// <summary>
        /// Gets the base path.
        /// </summary>
        /// <value>Base path.</value>
        string BasePath { get; set; }

        /// <summary>
        /// Gets the date time format.
        /// </summary>
        /// <value>Date time format.</value>
        string DateTimeFormat { get; set; }

        /// <summary>
        /// Gets the HTTP connection timeout in seconds
        /// </summary>
        /// <value>HTTP connection timeout.</value>
        int Timeout { get; set; }

        /// <summary>
        /// Gets the user agent.
        /// </summary>
        /// <value>User agent.</value>
        string UserAgent { get; set; }

        /// <summary>
        /// Gets the username.
        /// </summary>
        /// <value>Username.</value>
        string Username { get; set; }

        /// <summary>
        /// Gets the password.
        /// </summary>
        /// <value>Password.</value>
        string Password { get; set; }

        /// <summary>
        /// Gets the API key with prefix.
        /// </summary>
        /// <param name="apiKeyIdentifier">API key identifier (authentication scheme).</param>
        /// <returns>API key with prefix.</returns>
        string GetApiKeyWithPrefix(string apiKeyIdentifier);
    }
}
