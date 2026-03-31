
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
        /// Metadata that helps you categorize your videos. You can specify a list of keys and values. Keys must be of type `string`, and values can be of the following types: `string`, `integer`, `float` or `boolean`.<br/>
        /// **Example**:<br/>
        /// ```JSON<br/>
        /// "user_metadata": {<br/>
        ///   "category": "recentlyAdded",<br/>
        ///   "batchNumber": 5,<br/>
        ///   "rating": 9.3,<br/>
        ///   "needsReview": true<br/>
        /// }<br/>
        /// ```<br/>
        /// &lt;Note title="Notes"&gt;<br/>
        /// -  If you want to store other types of data such as objects or arrays,  you must convert your data into string values.<br/>
        /// - You cannot override the following system-generated metadata fields:<br/>
        ///   - `duration`<br/>
        ///   - `filename`<br/>
        ///   - `fps`<br/>
        ///   - `height`<br/>
        ///   - `model_names`<br/>
        ///   - `size`<br/>
        ///   - `video_title`<br/>
        ///   - `width`<br/>
        /// &lt;/Note&gt;
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
        /// Metadata that helps you categorize your videos. You can specify a list of keys and values. Keys must be of type `string`, and values can be of the following types: `string`, `integer`, `float` or `boolean`.<br/>
        /// **Example**:<br/>
        /// ```JSON<br/>
        /// "user_metadata": {<br/>
        ///   "category": "recentlyAdded",<br/>
        ///   "batchNumber": 5,<br/>
        ///   "rating": 9.3,<br/>
        ///   "needsReview": true<br/>
        /// }<br/>
        /// ```<br/>
        /// &lt;Note title="Notes"&gt;<br/>
        /// -  If you want to store other types of data such as objects or arrays,  you must convert your data into string values.<br/>
        /// - You cannot override the following system-generated metadata fields:<br/>
        ///   - `duration`<br/>
        ///   - `filename`<br/>
        ///   - `fps`<br/>
        ///   - `height`<br/>
        ///   - `model_names`<br/>
        ///   - `size`<br/>
        ///   - `video_title`<br/>
        ///   - `width`<br/>
        /// &lt;/Note&gt;
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