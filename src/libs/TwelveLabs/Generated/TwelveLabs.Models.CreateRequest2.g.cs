
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateRequest2
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
        /// Local video and audio files support up to 200 MB. Image files support up to 5 MB.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        public byte[]? File { get; set; }

        /// <summary>
        /// Specify this parameter to upload a file from a publicly accessible URL. This parameter is required when `method` is set to `url`.<br/>
        /// Public video and audio URLs support up to 4 GB. Image URLs support up to 5 MB.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// The optional filename of the asset. If not provided, the platform will determine the filename from the file or URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        public string? Filename { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRequest2" /> class.
        /// </summary>
        /// <param name="method">
        /// Specifies the upload method for the asset. Use `direct` to upload a local file or `url` for a publicly accessible URL.
        /// </param>
        /// <param name="file">
        /// Specify this parameter to upload a file from your local file system. This parameter is required when `method` is set to `direct`.<br/>
        /// Local video and audio files support up to 200 MB. Image files support up to 5 MB.
        /// </param>
        /// <param name="url">
        /// Specify this parameter to upload a file from a publicly accessible URL. This parameter is required when `method` is set to `url`.<br/>
        /// Public video and audio URLs support up to 4 GB. Image URLs support up to 5 MB.
        /// </param>
        /// <param name="filename">
        /// The optional filename of the asset. If not provided, the platform will determine the filename from the file or URL.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateRequest2(
            global::TwelveLabs.AssetsPostRequestBodyContentMultipartFormDataSchemaMethod method,
            byte[]? file,
            string? url,
            string? filename,
            bool? enableHls,
            bool? enableThumbnail)
        {
            this.Method = method;
            this.File = file;
            this.Url = url;
            this.Filename = filename;
            this.EnableHls = enableHls;
            this.EnableThumbnail = enableThumbnail;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRequest2" /> class.
        /// </summary>
        public CreateRequest2()
        {
        }
    }
}