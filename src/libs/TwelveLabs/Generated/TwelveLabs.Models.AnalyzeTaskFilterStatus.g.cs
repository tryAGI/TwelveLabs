
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The status values accepted by the async analysis task list filter.
    /// </summary>
    public enum AnalyzeTaskFilterStatus
    {
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
    public static class AnalyzeTaskFilterStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnalyzeTaskFilterStatus value)
        {
            return value switch
            {
                AnalyzeTaskFilterStatus.Failed => "failed",
                AnalyzeTaskFilterStatus.Pending => "pending",
                AnalyzeTaskFilterStatus.Processing => "processing",
                AnalyzeTaskFilterStatus.Queued => "queued",
                AnalyzeTaskFilterStatus.Ready => "ready",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnalyzeTaskFilterStatus? ToEnum(string value)
        {
            return value switch
            {
                "failed" => AnalyzeTaskFilterStatus.Failed,
                "pending" => AnalyzeTaskFilterStatus.Pending,
                "processing" => AnalyzeTaskFilterStatus.Processing,
                "queued" => AnalyzeTaskFilterStatus.Queued,
                "ready" => AnalyzeTaskFilterStatus.Ready,
                _ => null,
            };
        }
    }
}