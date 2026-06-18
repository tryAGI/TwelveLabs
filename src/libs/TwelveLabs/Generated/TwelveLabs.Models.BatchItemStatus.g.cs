
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The status of a result entry. This field is different from the batch status. For the meaning of each value, see the [Item statuses](/v1.3/api-reference/analyze-videos/batch-analysis/the-batch-object#item-statuses) section on the **The batch object** page.
    /// </summary>
    public enum BatchItemStatus
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
    public static class BatchItemStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BatchItemStatus value)
        {
            return value switch
            {
                BatchItemStatus.Canceled => "canceled",
                BatchItemStatus.Failed => "failed",
                BatchItemStatus.Processing => "processing",
                BatchItemStatus.Queued => "queued",
                BatchItemStatus.Ready => "ready",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BatchItemStatus? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => BatchItemStatus.Canceled,
                "failed" => BatchItemStatus.Failed,
                "processing" => BatchItemStatus.Processing,
                "queued" => BatchItemStatus.Queued,
                "ready" => BatchItemStatus.Ready,
                _ => null,
            };
        }
    }
}