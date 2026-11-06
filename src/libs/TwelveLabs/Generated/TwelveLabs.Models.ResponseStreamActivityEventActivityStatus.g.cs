
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The latest observed lifecycle state of this activity.<br/>
    /// **Values**:<br/>
    /// - `in_progress`: The activity is running.<br/>
    /// - `completed`: The activity finished.<br/>
    /// - `incomplete`: The activity stopped before finishing.<br/>
    /// - `failed`: The activity failed. A failed activity does not necessarily cause the response to fail.
    /// </summary>
    public enum ResponseStreamActivityEventActivityStatus
    {
        /// <summary>
        /// The activity finished.
        /// </summary>
        Completed,
        /// <summary>
        /// The activity failed. A failed activity does not necessarily cause the response to fail.
        /// </summary>
        Failed,
        /// <summary>
        /// The activity is running.
        /// </summary>
        InProgress,
        /// <summary>
        /// The activity stopped before finishing.
        /// </summary>
        Incomplete,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseStreamActivityEventActivityStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseStreamActivityEventActivityStatus value)
        {
            return value switch
            {
                ResponseStreamActivityEventActivityStatus.Completed => "completed",
                ResponseStreamActivityEventActivityStatus.Failed => "failed",
                ResponseStreamActivityEventActivityStatus.InProgress => "in_progress",
                ResponseStreamActivityEventActivityStatus.Incomplete => "incomplete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseStreamActivityEventActivityStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => ResponseStreamActivityEventActivityStatus.Completed,
                "failed" => ResponseStreamActivityEventActivityStatus.Failed,
                "in_progress" => ResponseStreamActivityEventActivityStatus.InProgress,
                "incomplete" => ResponseStreamActivityEventActivityStatus.Incomplete,
                _ => null,
            };
        }
    }
}