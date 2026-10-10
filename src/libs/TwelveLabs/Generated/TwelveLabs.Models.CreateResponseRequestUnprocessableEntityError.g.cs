
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateResponseRequestUnprocessableEntityError
    {
        /// <summary>
        /// The error code. The value `parameter_invalid` means the requested tool is unavailable for this request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Code { get; set; }

        /// <summary>
        /// A human-readable description identifying the unavailable tool and recovery action.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateResponseRequestUnprocessableEntityError" /> class.
        /// </summary>
        /// <param name="code">
        /// The error code. The value `parameter_invalid` means the requested tool is unavailable for this request.
        /// </param>
        /// <param name="message">
        /// A human-readable description identifying the unavailable tool and recovery action.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateResponseRequestUnprocessableEntityError(
            string code,
            string message)
        {
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateResponseRequestUnprocessableEntityError" /> class.
        /// </summary>
        public CreateResponseRequestUnprocessableEntityError()
        {
        }

    }
}