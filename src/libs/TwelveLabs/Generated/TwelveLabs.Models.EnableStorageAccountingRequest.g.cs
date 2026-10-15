
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class EnableStorageAccountingRequest
    {
        /// <summary>
        /// Enables storage accounting for the asset. The only accepted value is `true`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnableStorageAccountingRequest" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Enables storage accounting for the asset. The only accepted value is `true`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EnableStorageAccountingRequest(
            bool enabled)
        {
            this.Enabled = enabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnableStorageAccountingRequest" /> class.
        /// </summary>
        public EnableStorageAccountingRequest()
        {
        }

    }
}