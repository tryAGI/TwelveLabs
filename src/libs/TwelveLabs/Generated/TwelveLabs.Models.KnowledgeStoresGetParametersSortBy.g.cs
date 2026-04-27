
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Default Value: created_at
    /// </summary>
    public enum KnowledgeStoresGetParametersSortBy
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
    public static class KnowledgeStoresGetParametersSortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this KnowledgeStoresGetParametersSortBy value)
        {
            return value switch
            {
                KnowledgeStoresGetParametersSortBy.CreatedAt => "created_at",
                KnowledgeStoresGetParametersSortBy.Name => "name",
                KnowledgeStoresGetParametersSortBy.UpdatedAt => "updated_at",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static KnowledgeStoresGetParametersSortBy? ToEnum(string value)
        {
            return value switch
            {
                "created_at" => KnowledgeStoresGetParametersSortBy.CreatedAt,
                "name" => KnowledgeStoresGetParametersSortBy.Name,
                "updated_at" => KnowledgeStoresGetParametersSortBy.UpdatedAt,
                _ => null,
            };
        }
    }
}