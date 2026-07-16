
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The event type.
    /// </summary>
    public enum ResponseStreamResponseEventType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseCompleted,
        /// <summary>
        /// 
        /// </summary>
        ResponseCreated,
        /// <summary>
        /// 
        /// </summary>
        ResponseFailed,
        /// <summary>
        /// 
        /// </summary>
        ResponseInProgress,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseStreamResponseEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseStreamResponseEventType value)
        {
            return value switch
            {
                ResponseStreamResponseEventType.ResponseCompleted => "response.completed",
                ResponseStreamResponseEventType.ResponseCreated => "response.created",
                ResponseStreamResponseEventType.ResponseFailed => "response.failed",
                ResponseStreamResponseEventType.ResponseInProgress => "response.in_progress",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseStreamResponseEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.completed" => ResponseStreamResponseEventType.ResponseCompleted,
                "response.created" => ResponseStreamResponseEventType.ResponseCreated,
                "response.failed" => ResponseStreamResponseEventType.ResponseFailed,
                "response.in_progress" => ResponseStreamResponseEventType.ResponseInProgress,
                _ => null,
            };
        }
    }
}