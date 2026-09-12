
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AssetsCreateRequest
    {
        /// <summary>
        /// Specifies the upload method for the asset. Use `direct` to upload a local file or `url` for a publicly accessible URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.AssetsPostRequestBodyContentMultipartFormDataSchemaMethodJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::TwelveLabs.AssetsPostRequestBodyContentMultipartFormDataSchemaMethod Method { get; set; }

        /// <summary>
        /// Specify this parameter to upload a file from your local file system. This parameter is required when `method` is set to `direct`.<br/>
        /// Local video, audio, and documents support up to 200 MB. Images support up to 32 MB.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        public byte[]? File { get; set; }

        /// <summary>
        /// Specify this parameter to upload a file from a publicly accessible URL. This parameter is required when `method` is set to `url`.<br/>
        /// Public video and audio URLs support up to 4 GB. Image URLs support up to 32 MB. Document URLs support up to 512 MB.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// The filename of the asset. If you provide a filename, the platform preserves it. If you omit it, the platform determines one from the file or URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// The platform generates an HLS playlist and segments for streaming. Set to `false` to disable HLS generation. Applicable to video and audio assets only. The platform ignores this flag for other asset types.<br/>
        /// **Default**: `true`.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_hls")]
        public bool? EnableHls { get; set; }

        /// <summary>
        /// The platform generates thumbnail images from the uploaded content. Set to `false` to disable thumbnail generation.<br/>
        /// For PDF files, the platform generates a representative thumbnail from the first page. Text and Markdown files do not produce thumbnails; the platform ignores this flag for them.<br/>
        /// **Default**: `true`.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_thumbnail")]
        public bool? EnableThumbnail { get; set; }

        /// <summary>
        /// Metadata that helps you categorize your assets. You can specify a list of keys and values. Keys are strings, and values can be a string, a number, a boolean, or an array of strings. Send an integer wider than 53 bits (-9007199254740991 to 9007199254740991), and any identifier you want preserved verbatim, as a string. Send this value as a JSON-encoded string.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_metadata")]
        public string? UserMetadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssetsCreateRequest" /> class.
        /// </summary>
        /// <param name="method">
        /// Specifies the upload method for the asset. Use `direct` to upload a local file or `url` for a publicly accessible URL.
        /// </param>
        /// <param name="file">
        /// Specify this parameter to upload a file from your local file system. This parameter is required when `method` is set to `direct`.<br/>
        /// Local video, audio, and documents support up to 200 MB. Images support up to 32 MB.
        /// </param>
        /// <param name="url">
        /// Specify this parameter to upload a file from a publicly accessible URL. This parameter is required when `method` is set to `url`.<br/>
        /// Public video and audio URLs support up to 4 GB. Image URLs support up to 32 MB. Document URLs support up to 512 MB.
        /// </param>
        /// <param name="filename">
        /// The filename of the asset. If you provide a filename, the platform preserves it. If you omit it, the platform determines one from the file or URL.
        /// </param>
        /// <param name="enableHls">
        /// The platform generates an HLS playlist and segments for streaming. Set to `false` to disable HLS generation. Applicable to video and audio assets only. The platform ignores this flag for other asset types.<br/>
        /// **Default**: `true`.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="enableThumbnail">
        /// The platform generates thumbnail images from the uploaded content. Set to `false` to disable thumbnail generation.<br/>
        /// For PDF files, the platform generates a representative thumbnail from the first page. Text and Markdown files do not produce thumbnails; the platform ignores this flag for them.<br/>
        /// **Default**: `true`.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="userMetadata">
        /// Metadata that helps you categorize your assets. You can specify a list of keys and values. Keys are strings, and values can be a string, a number, a boolean, or an array of strings. Send an integer wider than 53 bits (-9007199254740991 to 9007199254740991), and any identifier you want preserved verbatim, as a string. Send this value as a JSON-encoded string.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AssetsCreateRequest(
            global::TwelveLabs.AssetsPostRequestBodyContentMultipartFormDataSchemaMethod method,
            byte[]? file,
            string? url,
            string? filename,
            bool? enableHls,
            bool? enableThumbnail,
            string? userMetadata)
        {
            this.Method = method;
            this.File = file;
            this.Url = url;
            this.Filename = filename;
            this.EnableHls = enableHls;
            this.EnableThumbnail = enableThumbnail;
            this.UserMetadata = userMetadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssetsCreateRequest" /> class.
        /// </summary>
        public AssetsCreateRequest()
        {
        }

    }
}