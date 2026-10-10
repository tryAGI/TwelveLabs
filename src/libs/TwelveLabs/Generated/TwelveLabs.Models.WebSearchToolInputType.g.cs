
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The type of tool.
    /// </summary>
    public enum WebSearchToolInputType
    {
        /// <summary>
        ///
        /// </summary>
        Jockey_webSearch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebSearchToolInputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebSearchToolInputType value)
        {
            return value switch
            {
                WebSearchToolInputType.Jockey_webSearch => "jockey:web_search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebSearchToolInputType? ToEnum(string value)
        {
            return value switch
            {
                "jockey:web_search" => WebSearchToolInputType.Jockey_webSearch,
                _ => null,
            };
        }
    }
}