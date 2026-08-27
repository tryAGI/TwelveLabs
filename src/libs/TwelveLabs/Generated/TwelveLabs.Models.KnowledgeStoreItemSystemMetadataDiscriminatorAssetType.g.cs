
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum KnowledgeStoreItemSystemMetadataDiscriminatorAssetType
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
    public static class KnowledgeStoreItemSystemMetadataDiscriminatorAssetTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this KnowledgeStoreItemSystemMetadataDiscriminatorAssetType value)
        {
            return value switch
            {
                KnowledgeStoreItemSystemMetadataDiscriminatorAssetType.Image => "image",
                KnowledgeStoreItemSystemMetadataDiscriminatorAssetType.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static KnowledgeStoreItemSystemMetadataDiscriminatorAssetType? ToEnum(string value)
        {
            return value switch
            {
                "image" => KnowledgeStoreItemSystemMetadataDiscriminatorAssetType.Image,
                "video" => KnowledgeStoreItemSystemMetadataDiscriminatorAssetType.Video,
                _ => null,
            };
        }
    }
}