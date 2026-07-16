
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Controls how the platform groups matches in the response.<br/>
    /// - `none`: Returns individual matches ordered by relevance.<br/>
    /// - `item`: Groups matches under their parent item.<br/>
    /// **Default**: `none`.<br/>
    /// Default Value: none
    /// </summary>
    public enum SearchKnowledgeStoreRequestGroupBy
    {
        /// <summary>
        /// Groups matches under their parent item.
        /// </summary>
        Item,
        /// <summary>
        /// Returns individual matches ordered by relevance.
        /// </summary>
        None,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchKnowledgeStoreRequestGroupByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchKnowledgeStoreRequestGroupBy value)
        {
            return value switch
            {
                SearchKnowledgeStoreRequestGroupBy.Item => "item",
                SearchKnowledgeStoreRequestGroupBy.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchKnowledgeStoreRequestGroupBy? ToEnum(string value)
        {
            return value switch
            {
                "item" => SearchKnowledgeStoreRequestGroupBy.Item,
                "none" => SearchKnowledgeStoreRequestGroupBy.None,
                _ => null,
            };
        }
    }
}