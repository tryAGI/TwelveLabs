
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Default Value: created_at
    /// </summary>
    public enum KnowledgeStoresKnowledgeStoreIdItemCollectionsGetParametersSortBy
    {
        /// <summary>
        ///
        /// </summary>
        CreatedAt,
        /// <summary>
        ///
        /// </summary>
        Name,
        /// <summary>
        ///
        /// </summary>
        UpdatedAt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class KnowledgeStoresKnowledgeStoreIdItemCollectionsGetParametersSortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this KnowledgeStoresKnowledgeStoreIdItemCollectionsGetParametersSortBy value)
        {
            return value switch
            {
                KnowledgeStoresKnowledgeStoreIdItemCollectionsGetParametersSortBy.CreatedAt => "created_at",
                KnowledgeStoresKnowledgeStoreIdItemCollectionsGetParametersSortBy.Name => "name",
                KnowledgeStoresKnowledgeStoreIdItemCollectionsGetParametersSortBy.UpdatedAt => "updated_at",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static KnowledgeStoresKnowledgeStoreIdItemCollectionsGetParametersSortBy? ToEnum(string value)
        {
            return value switch
            {
                "created_at" => KnowledgeStoresKnowledgeStoreIdItemCollectionsGetParametersSortBy.CreatedAt,
                "name" => KnowledgeStoresKnowledgeStoreIdItemCollectionsGetParametersSortBy.Name,
                "updated_at" => KnowledgeStoresKnowledgeStoreIdItemCollectionsGetParametersSortBy.UpdatedAt,
                _ => null,
            };
        }
    }
}