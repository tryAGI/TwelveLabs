
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The delivery status of a webhook endpoint.
    /// </summary>
    public sealed partial class AnalyzeTaskWebhookInfo
    {
        /// <summary>
        /// The URL of the webhook endpoint that received the delivery.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Indicates whether the platform successfully delivered the webhook.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delivered")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Delivered { get; set; }

        /// <summary>
        /// The total number of delivery attempts for this URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attempts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Attempts { get; set; }

        /// <summary>
        /// The error message from the last failed delivery attempt. This field appears only when `delivered` is `false`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_error")]
        public string? LastError { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyzeTaskWebhookInfo" /> class.
        /// </summary>
        /// <param name="url">
        /// The URL of the webhook endpoint that received the delivery.
        /// </param>
        /// <param name="delivered">
        /// Indicates whether the platform successfully delivered the webhook.
        /// </param>
        /// <param name="attempts">
        /// The total number of delivery attempts for this URL.
        /// </param>
        /// <param name="lastError">
        /// The error message from the last failed delivery attempt. This field appears only when `delivered` is `false`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnalyzeTaskWebhookInfo(
            string url,
            bool delivered,
            int attempts,
            string? lastError)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Delivered = delivered;
            this.Attempts = attempts;
            this.LastError = lastError;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyzeTaskWebhookInfo" /> class.
        /// </summary>
        public AnalyzeTaskWebhookInfo()
        {
        }
    }
}