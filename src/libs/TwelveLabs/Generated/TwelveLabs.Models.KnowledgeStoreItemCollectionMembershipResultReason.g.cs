
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The reason the platform skipped this identifier. Present only when `status` is `skipped`.<br/>
    /// - `already_member`: The item is already in the collection.<br/>
    /// - `not_member`: The item is not in the collection.<br/>
    /// - `duplicate`: The identifier appears earlier in the same request.
    /// </summary>
    public enum KnowledgeStoreItemCollectionMembershipResultReason
    {
        /// <summary>
        /// The item is already in the collection.
        /// </summary>
        AlreadyMember,
        /// <summary>
        /// The identifier appears earlier in the same request.
        /// </summary>
        Duplicate,
        /// <summary>
        /// The item is not in the collection.
        /// </summary>
        NotMember,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class KnowledgeStoreItemCollectionMembershipResultReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this KnowledgeStoreItemCollectionMembershipResultReason value)
        {
            return value switch
            {
                KnowledgeStoreItemCollectionMembershipResultReason.AlreadyMember => "already_member",
                KnowledgeStoreItemCollectionMembershipResultReason.Duplicate => "duplicate",
                KnowledgeStoreItemCollectionMembershipResultReason.NotMember => "not_member",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static KnowledgeStoreItemCollectionMembershipResultReason? ToEnum(string value)
        {
            return value switch
            {
                "already_member" => KnowledgeStoreItemCollectionMembershipResultReason.AlreadyMember,
                "duplicate" => KnowledgeStoreItemCollectionMembershipResultReason.Duplicate,
                "not_member" => KnowledgeStoreItemCollectionMembershipResultReason.NotMember,
                _ => null,
            };
        }
    }
}