
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum ResponseOutputItemDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Jockey_webSearch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseOutputItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseOutputItemDiscriminatorType value)
        {
            return value switch
            {
                ResponseOutputItemDiscriminatorType.Jockey_webSearch => "jockey:web_search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseOutputItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "jockey:web_search" => ResponseOutputItemDiscriminatorType.Jockey_webSearch,
                _ => null,
            };
        }
    }
}