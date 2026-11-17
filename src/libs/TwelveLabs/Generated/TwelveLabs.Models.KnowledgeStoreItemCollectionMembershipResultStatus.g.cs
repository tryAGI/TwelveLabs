
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Whether the platform added, removed, or skipped the item. When a request adds items, the value is `added` or `skipped`. When a request removes items, the value is `removed` or `skipped`.
    /// </summary>
    public enum KnowledgeStoreItemCollectionMembershipResultStatus
    {
        /// <summary>
        ///
        /// </summary>
        Added,
        /// <summary>
        ///
        /// </summary>
        Removed,
        /// <summary>
        ///
        /// </summary>
        Skipped,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class KnowledgeStoreItemCollectionMembershipResultStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this KnowledgeStoreItemCollectionMembershipResultStatus value)
        {
            return value switch
            {
                KnowledgeStoreItemCollectionMembershipResultStatus.Added => "added",
                KnowledgeStoreItemCollectionMembershipResultStatus.Removed => "removed",
                KnowledgeStoreItemCollectionMembershipResultStatus.Skipped => "skipped",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static KnowledgeStoreItemCollectionMembershipResultStatus? ToEnum(string value)
        {
            return value switch
            {
                "added" => KnowledgeStoreItemCollectionMembershipResultStatus.Added,
                "removed" => KnowledgeStoreItemCollectionMembershipResultStatus.Removed,
                "skipped" => KnowledgeStoreItemCollectionMembershipResultStatus.Skipped,
                _ => null,
            };
        }
    }
}