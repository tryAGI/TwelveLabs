
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The billing information for a finished response. Ignore any field in this object that your<br/>
    /// client does not recognize.
    /// </summary>
    public sealed partial class ResponseBilling
    {
        /// <summary>
        /// The cost of this response, as a decimal string with six decimal places, in the currency<br/>
        /// given by `currency`. The amount is the list price, before any discount on your account.<br/>
        /// One response runs many model calls, searches, and tools, and this one amount counts all of them.<br/>
        /// - `completed` or `incomplete`: the cost of the response. An incomplete response<br/>
        ///   counts the work done before it stopped.<br/>
        /// - `null`: the cost could not be determined when the response finished. Your invoice shows the charge.<br/>
        /// A request that fails is not charged.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount")]
        public string? Amount { get; set; }

        /// <summary>
        /// The ISO 4217 code of the currency of `amount`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("currency")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Currency { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseBilling" /> class.
        /// </summary>
        /// <param name="currency">
        /// The ISO 4217 code of the currency of `amount`.
        /// </param>
        /// <param name="amount">
        /// The cost of this response, as a decimal string with six decimal places, in the currency<br/>
        /// given by `currency`. The amount is the list price, before any discount on your account.<br/>
        /// One response runs many model calls, searches, and tools, and this one amount counts all of them.<br/>
        /// - `completed` or `incomplete`: the cost of the response. An incomplete response<br/>
        ///   counts the work done before it stopped.<br/>
        /// - `null`: the cost could not be determined when the response finished. Your invoice shows the charge.<br/>
        /// A request that fails is not charged.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseBilling(
            string currency,
            string? amount)
        {
            this.Amount = amount;
            this.Currency = currency ?? throw new global::System.ArgumentNullException(nameof(currency));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseBilling" /> class.
        /// </summary>
        public ResponseBilling()
        {
        }

    }
}