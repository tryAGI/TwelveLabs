
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum ResponseToolInputDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Jockey_webSearch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseToolInputDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseToolInputDiscriminatorType value)
        {
            return value switch
            {
                ResponseToolInputDiscriminatorType.Jockey_webSearch => "jockey:web_search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseToolInputDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "jockey:web_search" => ResponseToolInputDiscriminatorType.Jockey_webSearch,
                _ => null,
            };
        }
    }
}