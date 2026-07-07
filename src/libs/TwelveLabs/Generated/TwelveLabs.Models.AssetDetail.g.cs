
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
        /// Indicates the current processing status of the asset.<br/>
        /// A newly uploaded asset starts in the `processing` status and transitions asynchronously to `ready` on success or to `failed` on error, typically within a few seconds to a few minutes. Poll the [Retrieve an asset](/v1.3/api-reference/upload-content/direct-uploads/retrieve) endpoint until the status is `ready` before you use the asset in downstream workflows.<br/>
        /// **Values**:<br/>
        /// - `processing`: The asset is not yet usable. This can mean the upload is still in progress (for example, the platform is still fetching the file from a URL, or a multipart upload has not completed), or the upload has finished and the platform is validating the file. The `technical_metadata` field is omitted from the response.<br/>
        /// - `ready`: The platform validated the asset successfully, and the asset is ready to use.<br/>
        /// - `failed`: The platform could not process the file. The `error` field describes the reason, and the `technical_metadata` field may be partially populated.
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
        /// The date and time, in RFC 3339 format ("YYYY-MM-DDTHH:mm:ssZ"), when the asset was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// User-defined metadata for this asset. This field is absent when no metadata has been set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_metadata")]
        public global::TwelveLabs.UserMetadata? UserMetadata { get; set; }

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
        /// Technical metadata read from the media file of the asset, covering the container, the individual video and audio streams, image properties, and derived attributes.<br/>
        /// The platform populates this object asynchronously after the upload completes. It is omitted from the response while the status of the asset is `processing`, and it may be partially populated when the status is `failed`. A field is absent when it does not apply to the media type of the asset, or when the source file did not carry the corresponding information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("technical_metadata")]
        public global::TwelveLabs.TechnicalMetadata? TechnicalMetadata { get; set; }

        /// <summary>
        /// The file size of the asset in bytes. The platform finalizes this value when the asset reaches the `ready` status.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        public long? Size { get; set; }

        /// <summary>
        /// The duration of the asset in seconds. Only present for video and audio assets; absent for images. The platform finalizes this value when the asset reaches the `ready` status.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public double? Duration { get; set; }

        /// <summary>
        /// The reason the asset failed. The platform returns this field only when `status` is `failed`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public global::TwelveLabs.AssetError? Error { get; set; }

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
        /// Indicates the current processing status of the asset.<br/>
        /// A newly uploaded asset starts in the `processing` status and transitions asynchronously to `ready` on success or to `failed` on error, typically within a few seconds to a few minutes. Poll the [Retrieve an asset](/v1.3/api-reference/upload-content/direct-uploads/retrieve) endpoint until the status is `ready` before you use the asset in downstream workflows.<br/>
        /// **Values**:<br/>
        /// - `processing`: The asset is not yet usable. This can mean the upload is still in progress (for example, the platform is still fetching the file from a URL, or a multipart upload has not completed), or the upload has finished and the platform is validating the file. The `technical_metadata` field is omitted from the response.<br/>
        /// - `ready`: The platform validated the asset successfully, and the asset is ready to use.<br/>
        /// - `failed`: The platform could not process the file. The `error` field describes the reason, and the `technical_metadata` field may be partially populated.
        /// </param>
        /// <param name="filename">
        /// The name of the file used to create the asset.
        /// </param>
        /// <param name="fileType">
        /// The MIME type of the asset file.
        /// </param>
        /// <param name="createdAt">
        /// The date and time, in RFC 3339 format ("YYYY-MM-DDTHH:mm:ssZ"), when the asset was created.
        /// </param>
        /// <param name="userMetadata">
        /// User-defined metadata for this asset. This field is absent when no metadata has been set.
        /// </param>
        /// <param name="hls">
        /// HLS streaming details for the asset. Present only when HLS generation has been requested. Omitted otherwise.
        /// </param>
        /// <param name="thumbnail">
        /// Thumbnail details for the asset. Present only when thumbnail generation has been requested. Omitted otherwise.
        /// </param>
        /// <param name="technicalMetadata">
        /// Technical metadata read from the media file of the asset, covering the container, the individual video and audio streams, image properties, and derived attributes.<br/>
        /// The platform populates this object asynchronously after the upload completes. It is omitted from the response while the status of the asset is `processing`, and it may be partially populated when the status is `failed`. A field is absent when it does not apply to the media type of the asset, or when the source file did not carry the corresponding information.
        /// </param>
        /// <param name="size">
        /// The file size of the asset in bytes. The platform finalizes this value when the asset reaches the `ready` status.
        /// </param>
        /// <param name="duration">
        /// The duration of the asset in seconds. Only present for video and audio assets; absent for images. The platform finalizes this value when the asset reaches the `ready` status.
        /// </param>
        /// <param name="error">
        /// The reason the asset failed. The platform returns this field only when `status` is `failed`.
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
            global::System.DateTime? createdAt,
            global::TwelveLabs.UserMetadata? userMetadata,
            global::TwelveLabs.AssetHLS? hls,
            global::TwelveLabs.AssetThumbnail? thumbnail,
            global::TwelveLabs.TechnicalMetadata? technicalMetadata,
            long? size,
            double? duration,
            global::TwelveLabs.AssetError? error)
        {
            this.Id = id;
            this.Method = method;
            this.Status = status;
            this.Filename = filename;
            this.FileType = fileType;
            this.CreatedAt = createdAt;
            this.UserMetadata = userMetadata;
            this.Hls = hls;
            this.Thumbnail = thumbnail;
            this.TechnicalMetadata = technicalMetadata;
            this.Size = size;
            this.Duration = duration;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssetDetail" /> class.
        /// </summary>
        public AssetDetail()
        {
        }

    }
}