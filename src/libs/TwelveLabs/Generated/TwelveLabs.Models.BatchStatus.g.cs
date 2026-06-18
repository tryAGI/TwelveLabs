
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The status of a batch. For the meaning of each value, see the [Batch statuses](/v1.3/api-reference/analyze-videos/batch-analysis/the-batch-object#batch-statuses) section on the **The batch object** page.
    /// </summary>
    public enum BatchStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Canceled,
        /// <summary>
        /// 
        /// </summary>
        Canceling,
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Expired,
        /// <summary>
        /// 
        /// </summary>
        Pending,
        /// <summary>
        /// 
        /// </summary>
        Processing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BatchStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BatchStatus value)
        {
            return value switch
            {
                BatchStatus.Canceled => "canceled",
                BatchStatus.Canceling => "canceling",
                BatchStatus.Completed => "completed",
                BatchStatus.Expired => "expired",
                BatchStatus.Pending => "pending",
                BatchStatus.Processing => "processing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BatchStatus? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => BatchStatus.Canceled,
                "canceling" => BatchStatus.Canceling,
                "completed" => BatchStatus.Completed,
                "expired" => BatchStatus.Expired,
                "pending" => BatchStatus.Pending,
                "processing" => BatchStatus.Processing,
                _ => null,
            };
        }
    }
}