
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The type of input item.
    /// </summary>
    public enum ResponseInputItemType
    {
        /// <summary>
        /// 
        /// </summary>
        Message,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseInputItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseInputItemType value)
        {
            return value switch
            {
                ResponseInputItemType.Message => "message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseInputItemType? ToEnum(string value)
        {
            return value switch
            {
                "message" => ResponseInputItemType.Message,
                _ => null,
            };
        }
    }
}