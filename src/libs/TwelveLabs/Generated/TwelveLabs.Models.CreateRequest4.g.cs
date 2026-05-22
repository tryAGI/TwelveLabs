
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateRequest4
    {
        /// <summary>
        /// The unique identifier of the asset to index. The asset status must be `ready`. Use the [Retrieve an asset](/v1.3/api-reference/upload-content/direct-uploads/retrieve) method to check the status.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("asset_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AssetId { get; set; }

        /// <summary>
        /// This parameter indicates if the platform stores the video for streaming. When set to `true`, the platform stores the video, and you can retrieve its URL by calling the [`GET`](/v1.3/api-reference/videos/retrieve) method of the `/indexes/{index-id}/indexed-assets/{indexed-asset-id}` endpoint. You can then use this URL to access the stream over the &lt;a href="https://en.wikipedia.org/wiki/HTTP_Live_Streaming" target="_blank"&gt;HLS&lt;/a&gt; protocol.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_video_stream")]
        public bool? EnableVideoStream { get; set; }

        /// <summary>
        /// Metadata that helps you categorize your assets. You can specify a list of keys and values. Keys must be of type `string`, and values can be of the following types: `string`, `integer`, `float`, or `boolean`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_metadata")]
        public global::TwelveLabs.UserMetadata? UserMetadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRequest4" /> class.
        /// </summary>
        /// <param name="assetId">
        /// The unique identifier of the asset to index. The asset status must be `ready`. Use the [Retrieve an asset](/v1.3/api-reference/upload-content/direct-uploads/retrieve) method to check the status.
        /// </param>
        /// <param name="enableVideoStream">
        /// This parameter indicates if the platform stores the video for streaming. When set to `true`, the platform stores the video, and you can retrieve its URL by calling the [`GET`](/v1.3/api-reference/videos/retrieve) method of the `/indexes/{index-id}/indexed-assets/{indexed-asset-id}` endpoint. You can then use this URL to access the stream over the &lt;a href="https://en.wikipedia.org/wiki/HTTP_Live_Streaming" target="_blank"&gt;HLS&lt;/a&gt; protocol.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="userMetadata">
        /// Metadata that helps you categorize your assets. You can specify a list of keys and values. Keys must be of type `string`, and values can be of the following types: `string`, `integer`, `float`, or `boolean`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateRequest4(
            string assetId,
            bool? enableVideoStream,
            global::TwelveLabs.UserMetadata? userMetadata)
        {
            this.AssetId = assetId ?? throw new global::System.ArgumentNullException(nameof(assetId));
            this.EnableVideoStream = enableVideoStream;
            this.UserMetadata = userMetadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRequest4" /> class.
        /// </summary>
        public CreateRequest4()
        {
        }

    }
}