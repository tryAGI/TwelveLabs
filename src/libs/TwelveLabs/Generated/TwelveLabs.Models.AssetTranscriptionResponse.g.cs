
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The transcription status and the transcriptions you requested.
    /// </summary>
    public sealed partial class AssetTranscriptionResponse
    {
        /// <summary>
        /// Indicates the current status of the transcription.<br/>
        /// **Values**:<br/>
        /// - `pending`: The platform has not started transcribing the asset.<br/>
        /// - `processing`: The platform is transcribing the asset.<br/>
        /// - `ready`: The transcription is available.<br/>
        /// - `failed`: The platform could not transcribe the asset. The `error` field describes the reason.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.AssetTranscriptionStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::TwelveLabs.AssetTranscriptionStatus Status { get; set; }

        /// <summary>
        /// One entry for each word. Present when the status is `ready`, the `include` parameter lists `words`, and the transcription supports word-level segmentation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("words")]
        public global::System.Collections.Generic.IList<global::TwelveLabs.AssetTranscriptionEntry>? Words { get; set; }

        /// <summary>
        /// One entry for each chunk the speech recognition model detects as a sentence. Present when the status is `ready`, the `include` parameter lists `sentences`, and the transcription supports sentence-level segmentation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sentences")]
        public global::System.Collections.Generic.IList<global::TwelveLabs.AssetTranscriptionEntry>? Sentences { get; set; }

        /// <summary>
        /// One entry for each speaker turn. Present when the status is `ready`, the `include` parameter lists `utterances`, and the transcription supports speaker-turn segmentation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("utterances")]
        public global::System.Collections.Generic.IList<global::TwelveLabs.AssetTranscriptionUtterance>? Utterances { get; set; }

        /// <summary>
        /// Details about the failure. Present when the status is `failed`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public global::TwelveLabs.AssetTranscriptionError? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssetTranscriptionResponse" /> class.
        /// </summary>
        /// <param name="status">
        /// Indicates the current status of the transcription.<br/>
        /// **Values**:<br/>
        /// - `pending`: The platform has not started transcribing the asset.<br/>
        /// - `processing`: The platform is transcribing the asset.<br/>
        /// - `ready`: The transcription is available.<br/>
        /// - `failed`: The platform could not transcribe the asset. The `error` field describes the reason.
        /// </param>
        /// <param name="words">
        /// One entry for each word. Present when the status is `ready`, the `include` parameter lists `words`, and the transcription supports word-level segmentation.
        /// </param>
        /// <param name="sentences">
        /// One entry for each chunk the speech recognition model detects as a sentence. Present when the status is `ready`, the `include` parameter lists `sentences`, and the transcription supports sentence-level segmentation.
        /// </param>
        /// <param name="utterances">
        /// One entry for each speaker turn. Present when the status is `ready`, the `include` parameter lists `utterances`, and the transcription supports speaker-turn segmentation.
        /// </param>
        /// <param name="error">
        /// Details about the failure. Present when the status is `failed`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AssetTranscriptionResponse(
            global::TwelveLabs.AssetTranscriptionStatus status,
            global::System.Collections.Generic.IList<global::TwelveLabs.AssetTranscriptionEntry>? words,
            global::System.Collections.Generic.IList<global::TwelveLabs.AssetTranscriptionEntry>? sentences,
            global::System.Collections.Generic.IList<global::TwelveLabs.AssetTranscriptionUtterance>? utterances,
            global::TwelveLabs.AssetTranscriptionError? error)
        {
            this.Status = status;
            this.Words = words;
            this.Sentences = sentences;
            this.Utterances = utterances;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssetTranscriptionResponse" /> class.
        /// </summary>
        public AssetTranscriptionResponse()
        {
        }

    }
}