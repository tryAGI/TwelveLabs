
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// An asset with additional processing details such as HLS streaming and thumbnail information.
    /// </summary>
    public sealed partial class AssetDetail
    {
        /// <summary>
        /// The unique identifier of the asset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_id")]
        public string? Id { get; set; }

        /// <summary>
        /// Indicates how you uploaded the asset.<br/>
        /// **Values**:<br/>
        /// - `direct`: Uploaded from your local file system<br/>
        /// - `url`: Uploaded from a publicly accessible URL<br/>
        /// - `multipart`: Uploaded using the multipart upload flow
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.AssetMethodJsonConverter))]
        public global::TwelveLabs.AssetMethod? Method { get; set; }

        /// <summary>
        /// Indicates the current status of the asset.<br/>
        /// **Values**:<br/>
        /// - `failed`: The platform failed to process the upload<br/>
        /// - `processing`: The platform is processing the uploaded file<br/>
        /// - `ready`: The asset is ready to use
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.AssetStatusJsonConverter))]
        public global::TwelveLabs.AssetStatus? Status { get; set; }

        /// <summary>
        /// The name of the file used to create the asset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// The MIME type of the asset file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_type")]
        public string? FileType { get; set; }

        /// <summary>
        /// The file size of the asset in bytes. This field is absent while the asset is still being processed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        public long? Size { get; set; }

        /// <summary>
        /// The duration of the asset in seconds. Only present for video and audio assets. This field is absent for image assets or while the asset is still being processed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public double? Duration { get; set; }

        /// <summary>
        /// The date and time, in RFC 3339 format ("YYYY-MM-DDTHH:mm:ssZ"), when the asset was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// HLS streaming details for the asset. Present only when HLS generation has been requested. Omitted otherwise.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hls")]
        public global::TwelveLabs.AssetHLS? Hls { get; set; }

        /// <summary>
        /// Thumbnail details for the asset. Present only when thumbnail generation has been requested. Omitted otherwise.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thumbnail")]
        public global::TwelveLabs.AssetThumbnail? Thumbnail { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssetDetail" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the asset.
        /// </param>
        /// <param name="method">
        /// Indicates how you uploaded the asset.<br/>
        /// **Values**:<br/>
        /// - `direct`: Uploaded from your local file system<br/>
        /// - `url`: Uploaded from a publicly accessible URL<br/>
        /// - `multipart`: Uploaded using the multipart upload flow
        /// </param>
        /// <param name="status">
        /// Indicates the current status of the asset.<br/>
        /// **Values**:<br/>
        /// - `failed`: The platform failed to process the upload<br/>
        /// - `processing`: The platform is processing the uploaded file<br/>
        /// - `ready`: The asset is ready to use
        /// </param>
        /// <param name="filename">
        /// The name of the file used to create the asset.
        /// </param>
        /// <param name="fileType">
        /// The MIME type of the asset file.
        /// </param>
        /// <param name="size">
        /// The file size of the asset in bytes. This field is absent while the asset is still being processed.
        /// </param>
        /// <param name="duration">
        /// The duration of the asset in seconds. Only present for video and audio assets. This field is absent for image assets or while the asset is still being processed.
        /// </param>
        /// <param name="createdAt">
        /// The date and time, in RFC 3339 format ("YYYY-MM-DDTHH:mm:ssZ"), when the asset was created.
        /// </param>
        /// <param name="hls">
        /// HLS streaming details for the asset. Present only when HLS generation has been requested. Omitted otherwise.
        /// </param>
        /// <param name="thumbnail">
        /// Thumbnail details for the asset. Present only when thumbnail generation has been requested. Omitted otherwise.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AssetDetail(
            string? id,
            global::TwelveLabs.AssetMethod? method,
            global::TwelveLabs.AssetStatus? status,
            string? filename,
            string? fileType,
            long? size,
            double? duration,
            global::System.DateTime? createdAt,
            global::TwelveLabs.AssetHLS? hls,
            global::TwelveLabs.AssetThumbnail? thumbnail)
        {
            this.Id = id;
            this.Method = method;
            this.Status = status;
            this.Filename = filename;
            this.FileType = fileType;
            this.Size = size;
            this.Duration = duration;
            this.CreatedAt = createdAt;
            this.Hls = hls;
            this.Thumbnail = thumbnail;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssetDetail" /> class.
        /// </summary>
        public AssetDetail()
        {
        }
    }
}