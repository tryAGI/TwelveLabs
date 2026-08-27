
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum AssetsAssetIdTranscriptionGetParametersIncludeSchemaItems
    {
        /// <summary>
        ///
        /// </summary>
        Sentences,
        /// <summary>
        ///
        /// </summary>
        Utterances,
        /// <summary>
        ///
        /// </summary>
        Words,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AssetsAssetIdTranscriptionGetParametersIncludeSchemaItemsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssetsAssetIdTranscriptionGetParametersIncludeSchemaItems value)
        {
            return value switch
            {
                AssetsAssetIdTranscriptionGetParametersIncludeSchemaItems.Sentences => "sentences",
                AssetsAssetIdTranscriptionGetParametersIncludeSchemaItems.Utterances => "utterances",
                AssetsAssetIdTranscriptionGetParametersIncludeSchemaItems.Words => "words",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssetsAssetIdTranscriptionGetParametersIncludeSchemaItems? ToEnum(string value)
        {
            return value switch
            {
                "sentences" => AssetsAssetIdTranscriptionGetParametersIncludeSchemaItems.Sentences,
                "utterances" => AssetsAssetIdTranscriptionGetParametersIncludeSchemaItems.Utterances,
                "words" => AssetsAssetIdTranscriptionGetParametersIncludeSchemaItems.Words,
                _ => null,
            };
        }
    }
}