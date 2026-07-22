
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Details of the rejection. Present when the item was rejected before an asset was created, in which case the `status` field is absent.
    /// </summary>
    public sealed partial class ImportItemError
    {
        /// <summary>
        /// A string representing the code associated with the error. See the [Error codes](/v1.3/api-reference/error-codes) page for details. Possible values include `source_unavailable`, `source_not_authorized`, `unsupported_media_type`, `video_filesize_too_large`, `audio_filesize_too_large`, and `media_filesize_too_large`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// A human-readable string describing the error, intended to be suitable for display in a user interface.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportItemError" /> class.
        /// </summary>
        /// <param name="code">
        /// A string representing the code associated with the error. See the [Error codes](/v1.3/api-reference/error-codes) page for details. Possible values include `source_unavailable`, `source_not_authorized`, `unsupported_media_type`, `video_filesize_too_large`, `audio_filesize_too_large`, and `media_filesize_too_large`.
        /// </param>
        /// <param name="message">
        /// A human-readable string describing the error, intended to be suitable for display in a user interface.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImportItemError(
            string? code,
            string? message)
        {
            this.Code = code;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportItemError" /> class.
        /// </summary>
        public ImportItemError()
        {
        }

    }
}