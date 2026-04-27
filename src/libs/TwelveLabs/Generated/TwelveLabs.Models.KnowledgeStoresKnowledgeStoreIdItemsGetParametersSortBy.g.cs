
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Default Value: created_at
    /// </summary>
    public enum KnowledgeStoresKnowledgeStoreIdItemsGetParametersSortBy
    {
        /// <summary>
        /// 
        /// </summary>
        CreatedAt,
        /// <summary>
        /// 
        /// </summary>
        UpdatedAt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class KnowledgeStoresKnowledgeStoreIdItemsGetParametersSortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this KnowledgeStoresKnowledgeStoreIdItemsGetParametersSortBy value)
        {
            return value switch
            {
                KnowledgeStoresKnowledgeStoreIdItemsGetParametersSortBy.CreatedAt => "created_at",
                KnowledgeStoresKnowledgeStoreIdItemsGetParametersSortBy.UpdatedAt => "updated_at",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static KnowledgeStoresKnowledgeStoreIdItemsGetParametersSortBy? ToEnum(string value)
        {
            return value switch
            {
                "created_at" => KnowledgeStoresKnowledgeStoreIdItemsGetParametersSortBy.CreatedAt,
                "updated_at" => KnowledgeStoresKnowledgeStoreIdItemsGetParametersSortBy.UpdatedAt,
                _ => null,
            };
        }
    }
}