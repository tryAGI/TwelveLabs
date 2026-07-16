
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The type of item in the knowledge store.
    /// </summary>
    public enum KnowledgeStoreItemAssetType
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
    public static class KnowledgeStoreItemAssetTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this KnowledgeStoreItemAssetType value)
        {
            return value switch
            {
                KnowledgeStoreItemAssetType.Image => "image",
                KnowledgeStoreItemAssetType.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static KnowledgeStoreItemAssetType? ToEnum(string value)
        {
            return value switch
            {
                "image" => KnowledgeStoreItemAssetType.Image,
                "video" => KnowledgeStoreItemAssetType.Video,
                _ => null,
            };
        }
    }
}