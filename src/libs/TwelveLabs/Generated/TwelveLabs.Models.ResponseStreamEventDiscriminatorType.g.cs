
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum ResponseStreamEventDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseContentPartAdded,
        /// <summary>
        ///
        /// </summary>
        ResponseContentPartDone,
        /// <summary>
        ///
        /// </summary>
        ResponseFunctionCallArgumentsDone,
        /// <summary>
        ///
        /// </summary>
        ResponseOutputItemAdded,
        /// <summary>
        ///
        /// </summary>
        ResponseOutputItemDone,
        /// <summary>
        ///
        /// </summary>
        ResponseOutputTextDelta,
        /// <summary>
        ///
        /// </summary>
        ResponseOutputTextDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseStreamEventDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseStreamEventDiscriminatorType value)
        {
            return value switch
            {
                ResponseStreamEventDiscriminatorType.ResponseContentPartAdded => "response.content_part.added",
                ResponseStreamEventDiscriminatorType.ResponseContentPartDone => "response.content_part.done",
                ResponseStreamEventDiscriminatorType.ResponseFunctionCallArgumentsDone => "response.function_call_arguments.done",
                ResponseStreamEventDiscriminatorType.ResponseOutputItemAdded => "response.output_item.added",
                ResponseStreamEventDiscriminatorType.ResponseOutputItemDone => "response.output_item.done",
                ResponseStreamEventDiscriminatorType.ResponseOutputTextDelta => "response.output_text.delta",
                ResponseStreamEventDiscriminatorType.ResponseOutputTextDone => "response.output_text.done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseStreamEventDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "response.content_part.added" => ResponseStreamEventDiscriminatorType.ResponseContentPartAdded,
                "response.content_part.done" => ResponseStreamEventDiscriminatorType.ResponseContentPartDone,
                "response.function_call_arguments.done" => ResponseStreamEventDiscriminatorType.ResponseFunctionCallArgumentsDone,
                "response.output_item.added" => ResponseStreamEventDiscriminatorType.ResponseOutputItemAdded,
                "response.output_item.done" => ResponseStreamEventDiscriminatorType.ResponseOutputItemDone,
                "response.output_text.delta" => ResponseStreamEventDiscriminatorType.ResponseOutputTextDelta,
                "response.output_text.done" => ResponseStreamEventDiscriminatorType.ResponseOutputTextDone,
                _ => null,
            };
        }
    }
}