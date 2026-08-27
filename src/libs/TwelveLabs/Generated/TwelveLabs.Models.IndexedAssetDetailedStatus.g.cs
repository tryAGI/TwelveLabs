
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The status of the indexing task.
    /// </summary>
    public enum IndexedAssetDetailedStatus
    {
        /// <summary>
        ///
        /// </summary>
        Failed,
        /// <summary>
        ///
        /// </summary>
        Indexing,
        /// <summary>
        ///
        /// </summary>
        Pending,
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
    public static class IndexedAssetDetailedStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IndexedAssetDetailedStatus value)
        {
            return value switch
            {
                IndexedAssetDetailedStatus.Failed => "failed",
                IndexedAssetDetailedStatus.Indexing => "indexing",
                IndexedAssetDetailedStatus.Pending => "pending",
                IndexedAssetDetailedStatus.Queued => "queued",
                IndexedAssetDetailedStatus.Ready => "ready",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IndexedAssetDetailedStatus? ToEnum(string value)
        {
            return value switch
            {
                "failed" => IndexedAssetDetailedStatus.Failed,
                "indexing" => IndexedAssetDetailedStatus.Indexing,
                "pending" => IndexedAssetDetailedStatus.Pending,
                "queued" => IndexedAssetDetailedStatus.Queued,
                "ready" => IndexedAssetDetailedStatus.Ready,
                _ => null,
            };
        }
    }
}