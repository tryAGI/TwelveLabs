
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// An object that describes why an asset failed processing.
    /// </summary>
    public sealed partial class AssetError
    {
        /// <summary>
        /// A human-readable message describing the failure, such as a corrupted or unsupported file, a file the platform could not access, or a video that failed a playability check. The exact text is not part of the contract. Do not parse it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssetError" /> class.
        /// </summary>
        /// <param name="message">
        /// A human-readable message describing the failure, such as a corrupted or unsupported file, a file the platform could not access, or a video that failed a playability check. The exact text is not part of the contract. Do not parse it.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AssetError(
            string message)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssetError" /> class.
        /// </summary>
        public AssetError()
        {
        }

    }
}