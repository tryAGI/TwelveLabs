
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The final status of the task.
    /// </summary>
    public enum CancelAnalyzeTaskResponseStatus
    {
        /// <summary>
        ///
        /// </summary>
        Canceled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CancelAnalyzeTaskResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CancelAnalyzeTaskResponseStatus value)
        {
            return value switch
            {
                CancelAnalyzeTaskResponseStatus.Canceled => "canceled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CancelAnalyzeTaskResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => CancelAnalyzeTaskResponseStatus.Canceled,
                _ => null,
            };
        }
    }
}