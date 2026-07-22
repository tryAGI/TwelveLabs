
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The status of the asset. See [The import object](/v1.3/api-reference/data-connectors/imports/the-import-object#item-statuses) for the possible values. Absent when the item was rejected before an asset was created, in which case an `error` object is present.
    /// </summary>
    public enum ImportItemStatus
    {
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
        Ready,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImportItemStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImportItemStatus value)
        {
            return value switch
            {
                ImportItemStatus.Failed => "failed",
                ImportItemStatus.Processing => "processing",
                ImportItemStatus.Ready => "ready",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImportItemStatus? ToEnum(string value)
        {
            return value switch
            {
                "failed" => ImportItemStatus.Failed,
                "processing" => ImportItemStatus.Processing,
                "ready" => ImportItemStatus.Ready,
                _ => null,
            };
        }
    }
}