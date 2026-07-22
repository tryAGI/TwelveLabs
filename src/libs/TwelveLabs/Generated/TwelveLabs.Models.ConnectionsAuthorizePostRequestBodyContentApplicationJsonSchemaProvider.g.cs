
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The data connector provider to authorize.
    /// </summary>
    public enum ConnectionsAuthorizePostRequestBodyContentApplicationJsonSchemaProvider
    {
        /// <summary>
        /// 
        /// </summary>
        GoogleDrive,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConnectionsAuthorizePostRequestBodyContentApplicationJsonSchemaProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConnectionsAuthorizePostRequestBodyContentApplicationJsonSchemaProvider value)
        {
            return value switch
            {
                ConnectionsAuthorizePostRequestBodyContentApplicationJsonSchemaProvider.GoogleDrive => "google_drive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConnectionsAuthorizePostRequestBodyContentApplicationJsonSchemaProvider? ToEnum(string value)
        {
            return value switch
            {
                "google_drive" => ConnectionsAuthorizePostRequestBodyContentApplicationJsonSchemaProvider.GoogleDrive,
                _ => null,
            };
        }
    }
}