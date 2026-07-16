
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Discriminator value: image
    /// </summary>
    public enum SearchKnowledgeStoreHitVariant2AssetType
    {
        /// <summary>
        /// image
        /// </summary>
        Image,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchKnowledgeStoreHitVariant2AssetTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchKnowledgeStoreHitVariant2AssetType value)
        {
            return value switch
            {
                SearchKnowledgeStoreHitVariant2AssetType.Image => "image",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchKnowledgeStoreHitVariant2AssetType? ToEnum(string value)
        {
            return value switch
            {
                "image" => SearchKnowledgeStoreHitVariant2AssetType.Image,
                _ => null,
            };
        }
    }
}