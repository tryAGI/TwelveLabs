
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The data connector provider.
    /// </summary>
    public enum ConnectionProvider
    {
        /// <summary>
        ///
        /// </summary>
        GoogleDrive,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConnectionProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConnectionProvider value)
        {
            return value switch
            {
                ConnectionProvider.GoogleDrive => "google_drive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConnectionProvider? ToEnum(string value)
        {
            return value switch
            {
                "google_drive" => ConnectionProvider.GoogleDrive,
                _ => null,
            };
        }
    }
}