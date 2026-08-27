
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The data connector provider.
    /// </summary>
    public enum ImportDetailProvider
    {
        /// <summary>
        ///
        /// </summary>
        GoogleDrive,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImportDetailProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImportDetailProvider value)
        {
            return value switch
            {
                ImportDetailProvider.GoogleDrive => "google_drive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImportDetailProvider? ToEnum(string value)
        {
            return value switch
            {
                "google_drive" => ImportDetailProvider.GoogleDrive,
                _ => null,
            };
        }
    }
}