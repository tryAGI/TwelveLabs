
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Provide the video via a unique identifier of an asset.
    /// </summary>
    public sealed partial class VideoContext1
    {
        /// <summary>
        /// Set this field to `asset_id` to indicate that you're providing the video via a unique identifier of an asset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.VideoContextOneOf1TypeJsonConverter))]
        public global::TwelveLabs.VideoContextOneOf1Type Type { get; set; }

        /// <summary>
        /// The unique identifier of an asset from a [direct](/v1.3/api-reference/upload-content/direct-uploads) or [multipart](/v1.3/api-reference/upload-content/multipart-uploads) upload. The asset status must be `ready`. Use the [Retrieve an asset](/v1.3/api-reference/upload-content/direct-uploads/retrieve) method to check the status.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("asset_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AssetId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoContext1" /> class.
        /// </summary>
        /// <param name="assetId">
        /// The unique identifier of an asset from a [direct](/v1.3/api-reference/upload-content/direct-uploads) or [multipart](/v1.3/api-reference/upload-content/multipart-uploads) upload. The asset status must be `ready`. Use the [Retrieve an asset](/v1.3/api-reference/upload-content/direct-uploads/retrieve) method to check the status.
        /// </param>
        /// <param name="type">
        /// Set this field to `asset_id` to indicate that you're providing the video via a unique identifier of an asset.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoContext1(
            string assetId,
            global::TwelveLabs.VideoContextOneOf1Type type)
        {
            this.Type = type;
            this.AssetId = assetId ?? throw new global::System.ArgumentNullException(nameof(assetId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoContext1" /> class.
        /// </summary>
        public VideoContext1()
        {
        }
    }
}