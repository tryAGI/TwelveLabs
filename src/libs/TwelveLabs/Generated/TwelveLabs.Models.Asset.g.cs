
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// A reference file (image, audio, or video) that you upload to the platform for use in downstream workflows such as indexing, analyzing video content, and creating entities.
    /// </summary>
    public sealed partial class Asset
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Asset" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Asset(
            string? id,
            global::TwelveLabs.AssetMethod? method,
            global::TwelveLabs.AssetStatus? status,
            string? filename,
            string? fileType,
            global::System.DateTime? createdAt,
            global::TwelveLabs.UserMetadata? userMetadata)
        {
            this.Id = id;
            this.Method = method;
            this.Status = status;
            this.Filename = filename;
            this.FileType = fileType;
            this.CreatedAt = createdAt;
            this.UserMetadata = userMetadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Asset" /> class.
        /// </summary>
        public Asset()
        {
        }

    }
}