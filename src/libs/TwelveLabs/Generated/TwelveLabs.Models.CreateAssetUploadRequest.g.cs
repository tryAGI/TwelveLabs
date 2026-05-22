
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAssetUploadRequest
    {
        /// <summary>
        /// The original file name of the asset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Filename { get; set; }

        /// <summary>
        /// The type of asset you want to upload.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.CreateAssetUploadRequestTypeJsonConverter))]
        public global::TwelveLabs.CreateAssetUploadRequestType Type { get; set; }

        /// <summary>
        /// The total size of the file in bytes. The platform uses this value to:<br/>
        /// - Calculate the optimal chunk size.<br/>
        /// - Determine the total number of chunks required<br/>
        /// - Generate the initial set of presigned URLs
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_size")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long TotalSize { get; set; }

        /// <summary>
        /// When set to `true`, the platform generates an HLS playlist and segments for streaming. Applicable to video and audio assets only.<br/>
        /// **Default**: `false`.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_hls")]
        public bool? EnableHls { get; set; }

        /// <summary>
        /// When set to `true`, the platform generates thumbnail images from the uploaded content.<br/>
        /// **Default**: `false`.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_thumbnail")]
        public bool? EnableThumbnail { get; set; }

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
        /// Initializes a new instance of the <see cref="CreateAssetUploadRequest" /> class.
        /// </summary>
        /// <param name="filename">
        /// The original file name of the asset.
        /// </param>
        /// <param name="totalSize">
        /// The total size of the file in bytes. The platform uses this value to:<br/>
        /// - Calculate the optimal chunk size.<br/>
        /// - Determine the total number of chunks required<br/>
        /// - Generate the initial set of presigned URLs
        /// </param>
        /// <param name="type">
        /// The type of asset you want to upload.
        /// </param>
        /// <param name="enableHls">
        /// When set to `true`, the platform generates an HLS playlist and segments for streaming. Applicable to video and audio assets only.<br/>
        /// **Default**: `false`.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="enableThumbnail">
        /// When set to `true`, the platform generates thumbnail images from the uploaded content.<br/>
        /// **Default**: `false`.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="userMetadata">
        /// Metadata that helps you categorize your assets. You can specify a list of keys and values. Keys must be of type `string`, and values can be of the following types: `string`, `integer`, `float`, or `boolean`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAssetUploadRequest(
            string filename,
            long totalSize,
            global::TwelveLabs.CreateAssetUploadRequestType type,
            bool? enableHls,
            bool? enableThumbnail,
            global::TwelveLabs.UserMetadata? userMetadata)
        {
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.Type = type;
            this.TotalSize = totalSize;
            this.EnableHls = enableHls;
            this.EnableThumbnail = enableThumbnail;
            this.UserMetadata = userMetadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAssetUploadRequest" /> class.
        /// </summary>
        public CreateAssetUploadRequest()
        {
        }

    }
}