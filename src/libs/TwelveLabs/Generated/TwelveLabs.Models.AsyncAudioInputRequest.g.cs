
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// This field is required if the `input_type` parameter is `audio`.
    /// </summary>
    public sealed partial class AsyncAudioInputRequest
    {
        /// <summary>
        /// An object specifying the source of the media file. You must provide exactly one of `url`, `base64_string`, or `asset_id`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("media_source")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::TwelveLabs.MediaSource MediaSource { get; set; }

        /// <summary>
        /// The start time in seconds for processing the audio file.<br/>
        /// Use this parameter to process a portion of the audio file starting from a specific time.<br/>
        /// **Default**: 0 (start from the beginning).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_sec")]
        public double? StartSec { get; set; }

        /// <summary>
        /// The end time in seconds for processing the audio file.<br/>
        /// Use this parameter to process a portion of the audio file ending at a specific time. The end time must be greater than the start time.<br/>
        /// **Default**: End of the audio file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_sec")]
        public double? EndSec { get; set; }

        /// <summary>
        /// Specifies how the platform divides the audio into segments.<br/>
        /// The structure of this object depends on the model version:<br/>
        /// - **With Marengo 3.5**: Place your settings in the `temporal` object. Both strategies are available: `dynamic` divides the audio into variable-length segments that follow scene changes, and `fixed` divides it into equal-length segments. Default: `temporal.dynamic`, `min_duration_sec: 2`.<br/>
        /// - **With Marengo 3.0**: Provide the settings directly in this object. Only `fixed` segmentation is available. Default: `fixed`, `duration_sec: 6`.<br/>
        /// Using a structure that does not match your model version returns a `400` error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("segmentation")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.AsyncAudioInputRequestSegmentationJsonConverter))]
        public global::TwelveLabs.AsyncAudioInputRequestSegmentation? Segmentation { get; set; }

        /// <summary>
        /// The types of embeddings you wish to generate.<br/>
        /// **Values**:<br/>
        /// - `audio`: Generates embeddings based on audio content (sounds, music, effects). With Marengo 3.5, this value includes speech, music, and non-dialog audio.<br/>
        /// - `transcription`: Generates embeddings based on transcribed speech. Requires Marengo 3.0.<br/>
        /// You can specify multiple values to generate different types of embeddings for the same audio.<br/>
        /// **Default**: `["audio", "transcription"]` for Marengo 3.0; `["audio"]` for Marengo 3.5.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding_option")]
        public global::System.Collections.Generic.IList<global::TwelveLabs.AsyncAudioInputRequestEmbeddingOptionItems>? EmbeddingOption { get; set; }

        /// <summary>
        /// The scope for which you wish to generate embeddings.<br/>
        /// **Values**:<br/>
        /// - `clip`: Generates one embedding for each segment. Works with both Marengo 3.0 and Marengo 3.5.<br/>
        /// - `local`: Generates one embedding for each segment. Equivalent to `clip` when using Marengo 3.5.<br/>
        /// - `asset`: Generates one embedding for the entire audio file<br/>
        /// You can specify multiple scopes to generate embeddings at different levels.<br/>
        /// **Default**: `["clip", "asset"]`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding_scope")]
        public global::System.Collections.Generic.IList<global::TwelveLabs.AsyncAudioInputRequestEmbeddingScopeItems>? EmbeddingScope { get; set; }

        /// <summary>
        /// Specifies how to structure the embedding. Include this parameter only when the `embedding_option` parameter contains at least two values.<br/>
        /// **Values**:<br/>
        /// - `separate_embedding`: Returns separate embeddings for each modality specified in the `embedding_option` parameter.<br/>
        /// - `fused_embedding`: Returns a single combined embedding that integrates all modalities into one vector. With Marengo 3.5, this value requires the `time_based_metadata` field.<br/>
        /// Specify both values to receive separate and fused embeddings in the same response.<br/>
        /// **Default**: `separate_embedding`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding_type")]
        public global::System.Collections.Generic.IList<global::TwelveLabs.AsyncAudioInputRequestEmbeddingTypeItems>? EmbeddingType { get; set; }

        /// <summary>
        /// Your own time-aligned text, such as a stats feed or scene descriptions. The platform folds each entry into the fused embedding of the segments it overlaps in time, and it affects only that embedding. Requires the `fused_embedding` value in the `embedding_type` field. This field is supported only with Marengo 3.5.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("time_based_metadata")]
        public global::System.Collections.Generic.IList<global::TwelveLabs.TimeBasedMetadataEntry>? TimeBasedMetadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AsyncAudioInputRequest" /> class.
        /// </summary>
        /// <param name="mediaSource">
        /// An object specifying the source of the media file. You must provide exactly one of `url`, `base64_string`, or `asset_id`.
        /// </param>
        /// <param name="startSec">
        /// The start time in seconds for processing the audio file.<br/>
        /// Use this parameter to process a portion of the audio file starting from a specific time.<br/>
        /// **Default**: 0 (start from the beginning).
        /// </param>
        /// <param name="endSec">
        /// The end time in seconds for processing the audio file.<br/>
        /// Use this parameter to process a portion of the audio file ending at a specific time. The end time must be greater than the start time.<br/>
        /// **Default**: End of the audio file
        /// </param>
        /// <param name="segmentation">
        /// Specifies how the platform divides the audio into segments.<br/>
        /// The structure of this object depends on the model version:<br/>
        /// - **With Marengo 3.5**: Place your settings in the `temporal` object. Both strategies are available: `dynamic` divides the audio into variable-length segments that follow scene changes, and `fixed` divides it into equal-length segments. Default: `temporal.dynamic`, `min_duration_sec: 2`.<br/>
        /// - **With Marengo 3.0**: Provide the settings directly in this object. Only `fixed` segmentation is available. Default: `fixed`, `duration_sec: 6`.<br/>
        /// Using a structure that does not match your model version returns a `400` error.
        /// </param>
        /// <param name="embeddingOption">
        /// The types of embeddings you wish to generate.<br/>
        /// **Values**:<br/>
        /// - `audio`: Generates embeddings based on audio content (sounds, music, effects). With Marengo 3.5, this value includes speech, music, and non-dialog audio.<br/>
        /// - `transcription`: Generates embeddings based on transcribed speech. Requires Marengo 3.0.<br/>
        /// You can specify multiple values to generate different types of embeddings for the same audio.<br/>
        /// **Default**: `["audio", "transcription"]` for Marengo 3.0; `["audio"]` for Marengo 3.5.
        /// </param>
        /// <param name="embeddingScope">
        /// The scope for which you wish to generate embeddings.<br/>
        /// **Values**:<br/>
        /// - `clip`: Generates one embedding for each segment. Works with both Marengo 3.0 and Marengo 3.5.<br/>
        /// - `local`: Generates one embedding for each segment. Equivalent to `clip` when using Marengo 3.5.<br/>
        /// - `asset`: Generates one embedding for the entire audio file<br/>
        /// You can specify multiple scopes to generate embeddings at different levels.<br/>
        /// **Default**: `["clip", "asset"]`
        /// </param>
        /// <param name="embeddingType">
        /// Specifies how to structure the embedding. Include this parameter only when the `embedding_option` parameter contains at least two values.<br/>
        /// **Values**:<br/>
        /// - `separate_embedding`: Returns separate embeddings for each modality specified in the `embedding_option` parameter.<br/>
        /// - `fused_embedding`: Returns a single combined embedding that integrates all modalities into one vector. With Marengo 3.5, this value requires the `time_based_metadata` field.<br/>
        /// Specify both values to receive separate and fused embeddings in the same response.<br/>
        /// **Default**: `separate_embedding`.
        /// </param>
        /// <param name="timeBasedMetadata">
        /// Your own time-aligned text, such as a stats feed or scene descriptions. The platform folds each entry into the fused embedding of the segments it overlaps in time, and it affects only that embedding. Requires the `fused_embedding` value in the `embedding_type` field. This field is supported only with Marengo 3.5.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AsyncAudioInputRequest(
            global::TwelveLabs.MediaSource mediaSource,
            double? startSec,
            double? endSec,
            global::TwelveLabs.AsyncAudioInputRequestSegmentation? segmentation,
            global::System.Collections.Generic.IList<global::TwelveLabs.AsyncAudioInputRequestEmbeddingOptionItems>? embeddingOption,
            global::System.Collections.Generic.IList<global::TwelveLabs.AsyncAudioInputRequestEmbeddingScopeItems>? embeddingScope,
            global::System.Collections.Generic.IList<global::TwelveLabs.AsyncAudioInputRequestEmbeddingTypeItems>? embeddingType,
            global::System.Collections.Generic.IList<global::TwelveLabs.TimeBasedMetadataEntry>? timeBasedMetadata)
        {
            this.MediaSource = mediaSource ?? throw new global::System.ArgumentNullException(nameof(mediaSource));
            this.StartSec = startSec;
            this.EndSec = endSec;
            this.Segmentation = segmentation;
            this.EmbeddingOption = embeddingOption;
            this.EmbeddingScope = embeddingScope;
            this.EmbeddingType = embeddingType;
            this.TimeBasedMetadata = timeBasedMetadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AsyncAudioInputRequest" /> class.
        /// </summary>
        public AsyncAudioInputRequest()
        {
        }

    }
}