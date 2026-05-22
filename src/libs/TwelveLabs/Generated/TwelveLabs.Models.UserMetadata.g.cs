
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Metadata that helps you categorize your assets. You can specify a list of keys and values. Keys must be of type `string`, and values can be of the following types: `string`, `integer`, `float` or `boolean`.<br/>
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
    /// If you want to store other types of data such as objects or arrays, you must convert your data into string values.<br/>
    /// &lt;/Note&gt;
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