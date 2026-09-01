
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The current status of the analysis task.<br/>
    /// `ready`, `failed`, and `canceled` are terminal.
    /// </summary>
    public enum AnalyzeTaskStatus
    {
        /// <summary>
        ///
        /// </summary>
        Canceled,
        /// <summary>
        ///
        /// </summary>
        Failed,
        /// <summary>
        ///
        /// </summary>
        Pending,
        /// <summary>
        ///
        /// </summary>
        Processing,
        /// <summary>
        ///
        /// </summary>
        Queued,
        /// <summary>
        ///
        /// </summary>
        Ready,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnalyzeTaskStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnalyzeTaskStatus value)
        {
            return value switch
            {
                AnalyzeTaskStatus.Canceled => "canceled",
                AnalyzeTaskStatus.Failed => "failed",
                AnalyzeTaskStatus.Pending => "pending",
                AnalyzeTaskStatus.Processing => "processing",
                AnalyzeTaskStatus.Queued => "queued",
                AnalyzeTaskStatus.Ready => "ready",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnalyzeTaskStatus? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => AnalyzeTaskStatus.Canceled,
                "failed" => AnalyzeTaskStatus.Failed,
                "pending" => AnalyzeTaskStatus.Pending,
                "processing" => AnalyzeTaskStatus.Processing,
                "queued" => AnalyzeTaskStatus.Queued,
                "ready" => AnalyzeTaskStatus.Ready,
                _ => null,
            };
        }
    }
}