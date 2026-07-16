
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The status. For the meaning of each value, see the<br/>
    /// [Response statuses](/v1.3/api-reference/responses/the-response-object#response-statuses)<br/>
    /// section on **The response object** page.
    /// </summary>
    public enum ResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        Incomplete,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseStatus value)
        {
            return value switch
            {
                ResponseStatus.Completed => "completed",
                ResponseStatus.Failed => "failed",
                ResponseStatus.InProgress => "in_progress",
                ResponseStatus.Incomplete => "incomplete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => ResponseStatus.Completed,
                "failed" => ResponseStatus.Failed,
                "in_progress" => ResponseStatus.InProgress,
                "incomplete" => ResponseStatus.Incomplete,
                _ => null,
            };
        }
    }
}