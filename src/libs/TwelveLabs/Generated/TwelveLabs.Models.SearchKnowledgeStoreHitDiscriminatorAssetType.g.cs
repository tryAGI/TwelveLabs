
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum SearchKnowledgeStoreHitDiscriminatorAssetType
    {
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
    public static class SearchKnowledgeStoreHitDiscriminatorAssetTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchKnowledgeStoreHitDiscriminatorAssetType value)
        {
            return value switch
            {
                SearchKnowledgeStoreHitDiscriminatorAssetType.Image => "image",
                SearchKnowledgeStoreHitDiscriminatorAssetType.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchKnowledgeStoreHitDiscriminatorAssetType? ToEnum(string value)
        {
            return value switch
            {
                "image" => SearchKnowledgeStoreHitDiscriminatorAssetType.Image,
                "video" => SearchKnowledgeStoreHitDiscriminatorAssetType.Video,
                _ => null,
            };
        }
    }
}