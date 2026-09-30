
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// An object specifying the source of the media file. You must provide exactly one of `url`, `base64_string`, or `asset_id`.
    /// </summary>
    public sealed partial class MediaSource
    {
        /// <summary>
        /// The base64-encoded media data. Encoding grows the payload by about a third, so the string you send is larger than the original file.<br/>
        /// The maximum size depends on the input type and the model. The description of the field that contains this media source states the limit where it differs; for the formats and sizes each model accepts, see the input requirements for [Marengo 3.5](/v1.3/docs/concepts/models/marengo/marengo-3-5#input-requirements) or [Marengo 3.0](/v1.3/docs/concepts/models/marengo/marengo-3-0#input-requirements).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base64_string")]
        public string? Base64String { get; set; }

        /// <summary>
        /// The publicly accessible URL of the media file.<br/>
        /// Use direct links to raw media files. Video hosting platforms and cloud storage sharing links are not supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// The unique identifier of an asset from a [direct](/v1.3/api-reference/upload-content/direct-uploads) or [multipart](/v1.3/api-reference/upload-content/multipart-uploads) upload. The asset status must be `ready`. Use the [Retrieve an asset](/v1.3/api-reference/upload-content/direct-uploads/retrieve) method to check the status.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("asset_id")]
        public string? AssetId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MediaSource" /> class.
        /// </summary>
        /// <param name="base64String">
        /// The base64-encoded media data. Encoding grows the payload by about a third, so the string you send is larger than the original file.<br/>
        /// The maximum size depends on the input type and the model. The description of the field that contains this media source states the limit where it differs; for the formats and sizes each model accepts, see the input requirements for [Marengo 3.5](/v1.3/docs/concepts/models/marengo/marengo-3-5#input-requirements) or [Marengo 3.0](/v1.3/docs/concepts/models/marengo/marengo-3-0#input-requirements).
        /// </param>
        /// <param name="url">
        /// The publicly accessible URL of the media file.<br/>
        /// Use direct links to raw media files. Video hosting platforms and cloud storage sharing links are not supported.
        /// </param>
        /// <param name="assetId">
        /// The unique identifier of an asset from a [direct](/v1.3/api-reference/upload-content/direct-uploads) or [multipart](/v1.3/api-reference/upload-content/multipart-uploads) upload. The asset status must be `ready`. Use the [Retrieve an asset](/v1.3/api-reference/upload-content/direct-uploads/retrieve) method to check the status.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MediaSource(
            string? base64String,
            string? url,
            string? assetId)
        {
            this.Base64String = base64String;
            this.Url = url;
            this.AssetId = assetId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MediaSource" /> class.
        /// </summary>
        public MediaSource()
        {
        }

    }
}