
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The type of output item.
    /// </summary>
    public enum ResponseStandardOutputItemType
    {
        /// <summary>
        ///
        /// </summary>
        FunctionCall,
        /// <summary>
        ///
        /// </summary>
        FunctionCallOutput,
        /// <summary>
        ///
        /// </summary>
        Message,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseStandardOutputItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseStandardOutputItemType value)
        {
            return value switch
            {
                ResponseStandardOutputItemType.FunctionCall => "function_call",
                ResponseStandardOutputItemType.FunctionCallOutput => "function_call_output",
                ResponseStandardOutputItemType.Message => "message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseStandardOutputItemType? ToEnum(string value)
        {
            return value switch
            {
                "function_call" => ResponseStandardOutputItemType.FunctionCall,
                "function_call_output" => ResponseStandardOutputItemType.FunctionCallOutput,
                "message" => ResponseStandardOutputItemType.Message,
                _ => null,
            };
        }
    }
}