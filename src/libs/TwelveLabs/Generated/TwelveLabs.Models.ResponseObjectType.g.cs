
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The object type. Always `response`.
    /// </summary>
    public enum ResponseObjectType
    {
        /// <summary>
        /// 
        /// </summary>
        Response,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseObjectTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseObjectType value)
        {
            return value switch
            {
                ResponseObjectType.Response => "response",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseObjectType? ToEnum(string value)
        {
            return value switch
            {
                "response" => ResponseObjectType.Response,
                _ => null,
            };
        }
    }
}