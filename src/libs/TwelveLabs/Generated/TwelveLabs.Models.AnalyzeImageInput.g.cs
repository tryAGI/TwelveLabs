
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// An image to analyze. Provide exactly one of `url`, `asset_id`, or `base64_string`.<br/>
    /// Each image can be up to 20 MB and 16,777,216 pixels (width × height). Supported formats: JPEG, PNG, WebP, GIF, and BMP. An image over either limit, or in another format, returns a `400` error.
    /// </summary>
    public sealed partial class AnalyzeImageInput
    {
        /// <summary>
        /// The name of this image. Must be unique within the `image` array. Can contain only letters, digits, and underscores.<br/>
        /// To refer to a specific image in your prompt, use its name as the `&lt;@name&gt;` placeholder. Reference every image or none of them:<br/>
        /// - If the prompt references every image, the platform analyzes each one (Example: `Compare &lt;@before&gt; with &lt;@after&gt; and describe what changed.`).<br/>
        /// - If the prompt references none of them, the platform analyzes every image you provided (Example: `List every visible feature in these images.`).<br/>
        /// - If the prompt references only some of the images, the platform returns a `400` error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// A publicly accessible HTTPS URL of the image. The platform rejects HTTP URLs.<br/>
        /// When you send the request, the platform verifies that the URL is reachable and that the image is within the [size, pixel count, and format limits](/v1.3/docs/concepts/models/pegasus/pegasus-1-6#image-file-requirements). If either check fails, the platform returns a `400` error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// The unique identifier of an uploaded asset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("asset_id")]
        public string? AssetId { get; set; }

        /// <summary>
        /// Base64-encoded image data. The maximum decoded size is 20 MB. Supported image types: `image/jpeg`, `image/png`, `image/webp`, `image/gif`, and `image/bmp`. Standard and unpadded base64 encodings are both accepted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base64_string")]
        public string? Base64String { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyzeImageInput" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of this image. Must be unique within the `image` array. Can contain only letters, digits, and underscores.<br/>
        /// To refer to a specific image in your prompt, use its name as the `&lt;@name&gt;` placeholder. Reference every image or none of them:<br/>
        /// - If the prompt references every image, the platform analyzes each one (Example: `Compare &lt;@before&gt; with &lt;@after&gt; and describe what changed.`).<br/>
        /// - If the prompt references none of them, the platform analyzes every image you provided (Example: `List every visible feature in these images.`).<br/>
        /// - If the prompt references only some of the images, the platform returns a `400` error.
        /// </param>
        /// <param name="url">
        /// A publicly accessible HTTPS URL of the image. The platform rejects HTTP URLs.<br/>
        /// When you send the request, the platform verifies that the URL is reachable and that the image is within the [size, pixel count, and format limits](/v1.3/docs/concepts/models/pegasus/pegasus-1-6#image-file-requirements). If either check fails, the platform returns a `400` error.
        /// </param>
        /// <param name="assetId">
        /// The unique identifier of an uploaded asset.
        /// </param>
        /// <param name="base64String">
        /// Base64-encoded image data. The maximum decoded size is 20 MB. Supported image types: `image/jpeg`, `image/png`, `image/webp`, `image/gif`, and `image/bmp`. Standard and unpadded base64 encodings are both accepted.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnalyzeImageInput(
            string name,
            string? url,
            string? assetId,
            string? base64String)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Url = url;
            this.AssetId = assetId;
            this.Base64String = base64String;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyzeImageInput" /> class.
        /// </summary>
        public AnalyzeImageInput()
        {
        }

    }
}