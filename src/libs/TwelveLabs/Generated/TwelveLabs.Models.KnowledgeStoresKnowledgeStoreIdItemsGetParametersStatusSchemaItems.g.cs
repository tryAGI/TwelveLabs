
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum KnowledgeStoresKnowledgeStoreIdItemsGetParametersStatusSchemaItems
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
    public static class KnowledgeStoresKnowledgeStoreIdItemsGetParametersStatusSchemaItemsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this KnowledgeStoresKnowledgeStoreIdItemsGetParametersStatusSchemaItems value)
        {
            return value switch
            {
                KnowledgeStoresKnowledgeStoreIdItemsGetParametersStatusSchemaItems.Failed => "failed",
                KnowledgeStoresKnowledgeStoreIdItemsGetParametersStatusSchemaItems.Pending => "pending",
                KnowledgeStoresKnowledgeStoreIdItemsGetParametersStatusSchemaItems.Processing => "processing",
                KnowledgeStoresKnowledgeStoreIdItemsGetParametersStatusSchemaItems.Queued => "queued",
                KnowledgeStoresKnowledgeStoreIdItemsGetParametersStatusSchemaItems.Ready => "ready",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static KnowledgeStoresKnowledgeStoreIdItemsGetParametersStatusSchemaItems? ToEnum(string value)
        {
            return value switch
            {
                "failed" => KnowledgeStoresKnowledgeStoreIdItemsGetParametersStatusSchemaItems.Failed,
                "pending" => KnowledgeStoresKnowledgeStoreIdItemsGetParametersStatusSchemaItems.Pending,
                "processing" => KnowledgeStoresKnowledgeStoreIdItemsGetParametersStatusSchemaItems.Processing,
                "queued" => KnowledgeStoresKnowledgeStoreIdItemsGetParametersStatusSchemaItems.Queued,
                "ready" => KnowledgeStoresKnowledgeStoreIdItemsGetParametersStatusSchemaItems.Ready,
                _ => null,
            };
        }
    }
}