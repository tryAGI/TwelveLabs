
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SearchItemClipsItems
    {
        /// <summary>
        /// The start time of the matching video clip, expressed in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        public double? Start { get; set; }

        /// <summary>
        /// The end time of the matching video clip, expressed in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end")]
        public double? End { get; set; }

        /// <summary>
        /// The relevance ranking assigned by the model. Lower numbers indicate higher relevance, starting with 1 for the most relevant result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rank")]
        public int? Rank { get; set; }

        /// <summary>
        /// If thumbnail generation has been enabled for this index, the platform returns a string representing the URL of the thumbnail. Note that the URL expires in one hour.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thumbnail_url")]
        public string? ThumbnailUrl { get; set; }

        /// <summary>
        /// A transcription of the spoken words that are captured in the clip.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcription")]
        public string? Transcription { get; set; }

        /// <summary>
        /// A string representing the unique identifier of the video for the corresponding clip.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_id")]
        public string? VideoId { get; set; }

        /// <summary>
        /// Metadata that helps you categorize your assets. The object contains user-defined keys and values, where keys are strings. Each value is a string, a number, a boolean, or an array of strings. Send an integer wider than 53 bits (-9007199254740991 to 9007199254740991), and any identifier you want preserved verbatim, as a string.<br/>
        /// **Example**:<br/>
        /// ```JSON<br/>
        /// "user_metadata": {<br/>
        ///   "category": "recentlyAdded",<br/>
        ///   "batchNumber": 5,<br/>
        ///   "rating": 9.3,<br/>
        ///   "needsReview": true,<br/>
        ///   "hashtags": ["summer", "vlog"]<br/>
        /// }<br/>
        /// ```
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_metadata")]
        public global::TwelveLabs.UserMetadata? UserMetadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchItemClipsItems" /> class.
        /// </summary>
        /// <param name="start">
        /// The start time of the matching video clip, expressed in seconds.
        /// </param>
        /// <param name="end">
        /// The end time of the matching video clip, expressed in seconds.
        /// </param>
        /// <param name="rank">
        /// The relevance ranking assigned by the model. Lower numbers indicate higher relevance, starting with 1 for the most relevant result.
        /// </param>
        /// <param name="thumbnailUrl">
        /// If thumbnail generation has been enabled for this index, the platform returns a string representing the URL of the thumbnail. Note that the URL expires in one hour.
        /// </param>
        /// <param name="transcription">
        /// A transcription of the spoken words that are captured in the clip.
        /// </param>
        /// <param name="videoId">
        /// A string representing the unique identifier of the video for the corresponding clip.
        /// </param>
        /// <param name="userMetadata">
        /// Metadata that helps you categorize your assets. The object contains user-defined keys and values, where keys are strings. Each value is a string, a number, a boolean, or an array of strings. Send an integer wider than 53 bits (-9007199254740991 to 9007199254740991), and any identifier you want preserved verbatim, as a string.<br/>
        /// **Example**:<br/>
        /// ```JSON<br/>
        /// "user_metadata": {<br/>
        ///   "category": "recentlyAdded",<br/>
        ///   "batchNumber": 5,<br/>
        ///   "rating": 9.3,<br/>
        ///   "needsReview": true,<br/>
        ///   "hashtags": ["summer", "vlog"]<br/>
        /// }<br/>
        /// ```
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchItemClipsItems(
            double? start,
            double? end,
            int? rank,
            string? thumbnailUrl,
            string? transcription,
            string? videoId,
            global::TwelveLabs.UserMetadata? userMetadata)
        {
            this.Start = start;
            this.End = end;
            this.Rank = rank;
            this.ThumbnailUrl = thumbnailUrl;
            this.Transcription = transcription;
            this.VideoId = videoId;
            this.UserMetadata = userMetadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchItemClipsItems" /> class.
        /// </summary>
        public SearchItemClipsItems()
        {
        }

    }
}