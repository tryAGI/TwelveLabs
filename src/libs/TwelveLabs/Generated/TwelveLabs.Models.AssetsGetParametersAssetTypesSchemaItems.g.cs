
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum AssetsGetParametersAssetTypesSchemaItems
    {
        /// <summary>
        ///
        /// </summary>
        Audio,
        /// <summary>
        ///
        /// </summary>
        Document,
        /// <summary>
        ///
        /// </summary>
        Image,
        /// <summary>
        ///
        /// </summary>
        Video,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AssetsGetParametersAssetTypesSchemaItemsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssetsGetParametersAssetTypesSchemaItems value)
        {
            return value switch
            {
                AssetsGetParametersAssetTypesSchemaItems.Audio => "audio",
                AssetsGetParametersAssetTypesSchemaItems.Document => "document",
                AssetsGetParametersAssetTypesSchemaItems.Image => "image",
                AssetsGetParametersAssetTypesSchemaItems.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssetsGetParametersAssetTypesSchemaItems? ToEnum(string value)
        {
            return value switch
            {
                "audio" => AssetsGetParametersAssetTypesSchemaItems.Audio,
                "document" => AssetsGetParametersAssetTypesSchemaItems.Document,
                "image" => AssetsGetParametersAssetTypesSchemaItems.Image,
                "video" => AssetsGetParametersAssetTypesSchemaItems.Video,
                _ => null,
            };
        }
    }
}