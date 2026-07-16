
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The event type.
    /// </summary>
    public enum ResponseStreamFuncCallArgsDoneEventType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseFunctionCallArgumentsDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseStreamFuncCallArgsDoneEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseStreamFuncCallArgsDoneEventType value)
        {
            return value switch
            {
                ResponseStreamFuncCallArgsDoneEventType.ResponseFunctionCallArgumentsDone => "response.function_call_arguments.done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseStreamFuncCallArgsDoneEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.function_call_arguments.done" => ResponseStreamFuncCallArgsDoneEventType.ResponseFunctionCallArgumentsDone,
                _ => null,
            };
        }
    }
}