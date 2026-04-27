
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The processing status of the item. The following options are available:<br/>
    /// - `queued`: The item has been submitted and is waiting to be processed.<br/>
    /// - `pending`: The item has been dispatched and is waiting for available processing capacity.<br/>
    /// - `processing`: The item is currently being processed.<br/>
    /// - `ready`: The item has been successfully processed.<br/>
    /// - `failed`: The item processing has failed.
    /// </summary>
    public enum KnowledgeStoreItemStatus
    {
        /// <summary>
        /// The item processing has failed.
        /// </summary>
        Failed,
        /// <summary>
        /// The item has been dispatched and is waiting for available processing capacity.
        /// </summary>
        Pending,
        /// <summary>
        /// 
        /// </summary>
        Processing,
        /// <summary>
        /// The item has been submitted and is waiting to be processed.
        /// </summary>
        Queued,
        /// <summary>
        /// The item has been successfully processed.
        /// </summary>
        Ready,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class KnowledgeStoreItemStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this KnowledgeStoreItemStatus value)
        {
            return value switch
            {
                KnowledgeStoreItemStatus.Failed => "failed",
                KnowledgeStoreItemStatus.Pending => "pending",
                KnowledgeStoreItemStatus.Processing => "processing",
                KnowledgeStoreItemStatus.Queued => "queued",
                KnowledgeStoreItemStatus.Ready => "ready",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static KnowledgeStoreItemStatus? ToEnum(string value)
        {
            return value switch
            {
                "failed" => KnowledgeStoreItemStatus.Failed,
                "pending" => KnowledgeStoreItemStatus.Pending,
                "processing" => KnowledgeStoreItemStatus.Processing,
                "queued" => KnowledgeStoreItemStatus.Queued,
                "ready" => KnowledgeStoreItemStatus.Ready,
                _ => null,
            };
        }
    }
}