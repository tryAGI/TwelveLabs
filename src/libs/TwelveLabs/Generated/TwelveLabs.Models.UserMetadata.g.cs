
#nullable enable

namespace TwelveLabs
{
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
    public sealed partial class UserMetadata
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}