
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The processing status of the item. For the meaning of each value, see the<br/>
    /// [Item statuses](/v1.3/api-reference/knowledge-store-items/the-knowledge-store-item-object#item-statuses)<br/>
    /// section on **The knowledge store item object** page.
    /// </summary>
    public enum KnowledgeStoreItemStatus
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