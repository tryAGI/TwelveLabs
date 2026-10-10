
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Details of a web search or page action. Read query text from `queries`.<br/>
    /// Other fields can include `type`, `url`, and `pattern`. Action types can include<br/>
    /// `search`, `open_page`, `find`, and `find_in_page`.<br/>
    /// These other fields have no fixed schema. Check their values before use and ignore fields you do not recognize.
    /// </summary>
    public sealed partial class WebSearchAction
    {
        /// <summary>
        /// The query strings for the action. An empty array contains no query strings.<br/>
        /// An absent field means query text is unavailable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("queries")]
        public global::System.Collections.Generic.IList<string>? Queries { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchAction" /> class.
        /// </summary>
        /// <param name="queries">
        /// The query strings for the action. An empty array contains no query strings.<br/>
        /// An absent field means query text is unavailable.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebSearchAction(
            global::System.Collections.Generic.IList<string>? queries)
        {
            this.Queries = queries;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchAction" /> class.
        /// </summary>
        public WebSearchAction()
        {
        }

    }
}