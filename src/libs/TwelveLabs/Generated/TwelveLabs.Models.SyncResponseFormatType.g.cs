
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Set this parameter to "json_schema" to receive structured JSON responses.
    /// </summary>
    public enum SyncResponseFormatType
    {
        /// <summary>
        /// 
        /// </summary>
        JsonSchema,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SyncResponseFormatTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SyncResponseFormatType value)
        {
            return value switch
            {
                SyncResponseFormatType.JsonSchema => "json_schema",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SyncResponseFormatType? ToEnum(string value)
        {
            return value switch
            {
                "json_schema" => SyncResponseFormatType.JsonSchema,
                _ => null,
            };
        }
    }
}