
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The type of output item.
    /// </summary>
    public enum ResponseOutputItemType
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
    public static class ResponseOutputItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseOutputItemType value)
        {
            return value switch
            {
                ResponseOutputItemType.FunctionCall => "function_call",
                ResponseOutputItemType.FunctionCallOutput => "function_call_output",
                ResponseOutputItemType.Message => "message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseOutputItemType? ToEnum(string value)
        {
            return value switch
            {
                "function_call" => ResponseOutputItemType.FunctionCall,
                "function_call_output" => ResponseOutputItemType.FunctionCallOutput,
                "message" => ResponseOutputItemType.Message,
                _ => null,
            };
        }
    }
}