
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The data connector provider.
    /// </summary>
    public enum AssetSourceDetailsProvider
    {
        /// <summary>
        ///
        /// </summary>
        GoogleDrive,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AssetSourceDetailsProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssetSourceDetailsProvider value)
        {
            return value switch
            {
                AssetSourceDetailsProvider.GoogleDrive => "google_drive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssetSourceDetailsProvider? ToEnum(string value)
        {
            return value switch
            {
                "google_drive" => AssetSourceDetailsProvider.GoogleDrive,
                _ => null,
            };
        }
    }
}