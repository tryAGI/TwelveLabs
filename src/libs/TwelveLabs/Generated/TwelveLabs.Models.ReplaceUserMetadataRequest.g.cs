
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReplaceUserMetadataRequest
    {
        /// <summary>
        /// Metadata that helps you categorize your assets. The object contains user-defined keys and values, where keys are strings and values are one of `string`, `integer`, `float`, or `boolean`.<br/>
        /// **Example**:<br/>
        /// ```JSON<br/>
        /// "user_metadata": {<br/>
        ///   "category": "recentlyAdded",<br/>
        ///   "batchNumber": 5,<br/>
        ///   "rating": 9.3,<br/>
        ///   "needsReview": true<br/>
        /// }<br/>
        /// ```<br/>
        /// &lt;Note title="Note"&gt;<br/>
        /// To store other types of data, such as objects or arrays, convert your data into string values before sending it.<br/>
        /// &lt;/Note&gt;
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::TwelveLabs.UserMetadata UserMetadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplaceUserMetadataRequest" /> class.
        /// </summary>
        /// <param name="userMetadata">
        /// Metadata that helps you categorize your assets. The object contains user-defined keys and values, where keys are strings and values are one of `string`, `integer`, `float`, or `boolean`.<br/>
        /// **Example**:<br/>
        /// ```JSON<br/>
        /// "user_metadata": {<br/>
        ///   "category": "recentlyAdded",<br/>
        ///   "batchNumber": 5,<br/>
        ///   "rating": 9.3,<br/>
        ///   "needsReview": true<br/>
        /// }<br/>
        /// ```<br/>
        /// &lt;Note title="Note"&gt;<br/>
        /// To store other types of data, such as objects or arrays, convert your data into string values before sending it.<br/>
        /// &lt;/Note&gt;
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReplaceUserMetadataRequest(
            global::TwelveLabs.UserMetadata userMetadata)
        {
            this.UserMetadata = userMetadata ?? throw new global::System.ArgumentNullException(nameof(userMetadata));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplaceUserMetadataRequest" /> class.
        /// </summary>
        public ReplaceUserMetadataRequest()
        {
        }

    }
}