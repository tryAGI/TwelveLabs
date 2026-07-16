
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// A matching clip from a video.
    /// </summary>
    public sealed partial class VideoMatch
    {
        /// <summary>
        /// The clip start offset, in seconds, within the source video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_sec")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double StartSec { get; set; }

        /// <summary>
        /// The clip end offset, in seconds, within the source video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_sec")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double EndSec { get; set; }

        /// <summary>
        /// The modalities that matched in this clip.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modalities")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::TwelveLabs.VideoSearchModality> Modalities { get; set; }

        /// <summary>
        /// The spoken words in the clip. Returned when spoken-word data is available for the clip, regardless of which modalities matched.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcription")]
        public string? Transcription { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoMatch" /> class.
        /// </summary>
        /// <param name="startSec">
        /// The clip start offset, in seconds, within the source video.
        /// </param>
        /// <param name="endSec">
        /// The clip end offset, in seconds, within the source video.
        /// </param>
        /// <param name="modalities">
        /// The modalities that matched in this clip.
        /// </param>
        /// <param name="transcription">
        /// The spoken words in the clip. Returned when spoken-word data is available for the clip, regardless of which modalities matched.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoMatch(
            double startSec,
            double endSec,
            global::System.Collections.Generic.IList<global::TwelveLabs.VideoSearchModality> modalities,
            string? transcription)
        {
            this.StartSec = startSec;
            this.EndSec = endSec;
            this.Modalities = modalities ?? throw new global::System.ArgumentNullException(nameof(modalities));
            this.Transcription = transcription;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoMatch" /> class.
        /// </summary>
        public VideoMatch()
        {
        }

    }
}