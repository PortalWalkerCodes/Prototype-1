using Unity.Services.Core;

namespace Unity.Services.Authentication
{
    /// <summary>
    /// AuthenticationErrorCodes lists the error codes to expect from <c>AuthenticationException</c> and failed events.
    /// The error code range is: 10000 to 10999.
    /// </summary>
    public static class AuthenticationErrorCodes
    {
        /// <summary>
        /// The minimal value of an Authentication error code. Any error code thrown from Authentication SDK less than
        /// it is from <see cref="CommonErrorCodes"/>.
        /// </summary>
        /// <value>Error code 10000</value>
        public static readonly int MinValue = 10000;

        /// <summary>
        /// A client error that is returned when the user is not in the right state.
        /// For example, calling SignOut when the user is already signed out will result in this error.
        /// </summary>
        /// <value>Error code 10000</value>
        public static readonly int ClientInvalidUserState = 10000;

        /// <summary>
        /// A client error that is returned when trying to sign-in with the session token while there is no cached
        /// session token.
        /// </summary>
        /// <value>Error code 10001</value>
        public static readonly int ClientNoActiveSession = 10001;

        /// <summary>
        /// The error returned when the parameter is missing or not in the right format.
        /// </summary>
        /// <value>Error code 10002</value>
        public static readonly int InvalidParameters = 10002;

        /// <summary>
        /// The error returned when a player tries to link a social account that is already linked with another player.
        /// </summary>
        /// <value>Error code 10003</value>
        public static readonly int AccountAlreadyLinked = 10003;

        /// <summary>
        /// The error returned when a player tries to link a social account but this player has already reached the limit of links for that account type.
        /// Social accounts linking are typically limited to one link per type per player.
        /// </summary>
        /// <value>Error code 10004</value>
        public static readonly int AccountLinkLimitExceeded = 10004;

        /// <summary>
        /// The error returned when a player tries to unlink a social account but no external id for that provider is found for the account.
        /// This could be because the player info has not been loaded.
        /// </summary>
        /// <value>Error code 10005</value>
        public static readonly int ClientUnlinkExternalIdNotFound = 10005;

        /// <summary>
        /// The error returned when a player tries to switch profile but the profile name is invalid.
        /// </summary>
        /// <value>Error code 10006</value>
        public static readonly int ClientInvalidProfile = 10006;

        /// <summary>
        /// The error returned when a session token is invalid
        /// </summary>
        /// <value>Error code 10007</value>
        public static readonly int InvalidSessionToken = 10007;

        /// <summary>
        /// The request was understood but the API refused to process it because the provider was invalid for the request.
        /// </summary>
        /// <value>Error code 10008</value>
        public static readonly int InvalidProvider = 10008;

        /// <summary>
        /// The request was understood but the user has been banned from logging in.
        /// </summary>
        /// <value>Error code 10009</value>
        public static readonly int BannedUser = 10009;

        /// <summary>
        /// There is a mismatch between the requested environment and the one configured.
        /// </summary>
        /// <value>Error code 10010</value>
        public static readonly int EnvironmentMismatch = 10010;
    }
}
