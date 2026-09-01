
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum AsyncDocumentMetadataInputType
    {
        /// <summary>
        ///
        /// </summary>
        Document,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AsyncDocumentMetadataInputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AsyncDocumentMetadataInputType value)
        {
            return value switch
            {
                AsyncDocumentMetadataInputType.Document => "document",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AsyncDocumentMetadataInputType? ToEnum(string value)
        {
            return value switch
            {
                "document" => AsyncDocumentMetadataInputType.Document,
                _ => null,
            };
        }
    }
}