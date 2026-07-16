
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Discriminator value: video
    /// </summary>
    public enum SearchKnowledgeStoreHitVariant1AssetType
    {
        /// <summary>
        /// video
        /// </summary>
        Video,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchKnowledgeStoreHitVariant1AssetTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchKnowledgeStoreHitVariant1AssetType value)
        {
            return value switch
            {
                SearchKnowledgeStoreHitVariant1AssetType.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchKnowledgeStoreHitVariant1AssetType? ToEnum(string value)
        {
            return value switch
            {
                "video" => SearchKnowledgeStoreHitVariant1AssetType.Video,
                _ => null,
            };
        }
    }
}