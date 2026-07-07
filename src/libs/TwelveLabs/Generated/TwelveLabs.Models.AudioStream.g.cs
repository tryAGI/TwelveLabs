
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The technical properties of a single audio stream within the media file.
    /// </summary>
    public sealed partial class AudioStream
    {
        /// <summary>
        /// The zero-based index of the stream within the media file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        public int? Index { get; set; }

        /// <summary>
        /// The codec of the audio stream.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("codec")]
        public string? Codec { get; set; }

        /// <summary>
        /// The descriptive long name of the audio codec.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("codec_long")]
        public string? CodecLong { get; set; }

        /// <summary>
        /// The sample rate of the audio stream, in hertz.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sample_rate")]
        public int? SampleRate { get; set; }

        /// <summary>
        /// The bit depth of the audio stream.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bit_depth")]
        public int? BitDepth { get; set; }

        /// <summary>
        /// The number of channels in the audio stream.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("channels")]
        public int? Channels { get; set; }

        /// <summary>
        /// The channel layout of the audio stream.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("channel_layout")]
        public string? ChannelLayout { get; set; }

        /// <summary>
        /// The bit rate of the audio stream, in bits per second.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bitrate_bps")]
        public long? BitrateBps { get; set; }

        /// <summary>
        /// The language of the audio stream, when present.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// The duration of the audio stream, in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_seconds")]
        public double? DurationSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioStream" /> class.
        /// </summary>
        /// <param name="index">
        /// The zero-based index of the stream within the media file.
        /// </param>
        /// <param name="codec">
        /// The codec of the audio stream.
        /// </param>
        /// <param name="codecLong">
        /// The descriptive long name of the audio codec.
        /// </param>
        /// <param name="sampleRate">
        /// The sample rate of the audio stream, in hertz.
        /// </param>
        /// <param name="bitDepth">
        /// The bit depth of the audio stream.
        /// </param>
        /// <param name="channels">
        /// The number of channels in the audio stream.
        /// </param>
        /// <param name="channelLayout">
        /// The channel layout of the audio stream.
        /// </param>
        /// <param name="bitrateBps">
        /// The bit rate of the audio stream, in bits per second.
        /// </param>
        /// <param name="language">
        /// The language of the audio stream, when present.
        /// </param>
        /// <param name="durationSeconds">
        /// The duration of the audio stream, in seconds.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudioStream(
            int? index,
            string? codec,
            string? codecLong,
            int? sampleRate,
            int? bitDepth,
            int? channels,
            string? channelLayout,
            long? bitrateBps,
            string? language,
            double? durationSeconds)
        {
            this.Index = index;
            this.Codec = codec;
            this.CodecLong = codecLong;
            this.SampleRate = sampleRate;
            this.BitDepth = bitDepth;
            this.Channels = channels;
            this.ChannelLayout = channelLayout;
            this.BitrateBps = bitrateBps;
            this.Language = language;
            this.DurationSeconds = durationSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioStream" /> class.
        /// </summary>
        public AudioStream()
        {
        }

    }
}