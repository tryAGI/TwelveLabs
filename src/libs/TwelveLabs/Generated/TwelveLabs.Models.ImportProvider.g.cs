
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The data connector provider.
    /// </summary>
    public enum ImportProvider
    {
        /// <summary>
        /// 
        /// </summary>
        GoogleDrive,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImportProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImportProvider value)
        {
            return value switch
            {
                ImportProvider.GoogleDrive => "google_drive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImportProvider? ToEnum(string value)
        {
            return value switch
            {
                "google_drive" => ImportProvider.GoogleDrive,
                _ => null,
            };
        }
    }
}