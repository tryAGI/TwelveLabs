#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The output format for the response text. Defaults to plain text.<br/>
    /// Use `json_schema` to receive a structured JSON object conforming to a provided schema.
    /// </summary>
    public readonly partial struct TextParamFormat : global::System.IEquatable<TextParamFormat>
    {
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TextParamFormatDiscriminatorType? Type { get; }

        /// <summary>
        /// Plain text output format (default).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::TwelveLabs.TextParamFormatVariant1? Text { get; init; }
#else
        public global::TwelveLabs.TextParamFormatVariant1? Text { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Text))]
#endif
        public bool IsText => Text != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickText(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::TwelveLabs.TextParamFormatVariant1? value)
        {
            value = Text;
            return IsText;
        }

        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TextParamFormatVariant1 PickText() => IsText
            ? Text!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Text' but the value was {ToString()}.");

        /// <summary>
        /// Structured JSON output conforming to a provided schema.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::TwelveLabs.TextParamFormatVariant2? JsonSchema { get; init; }
#else
        public global::TwelveLabs.TextParamFormatVariant2? JsonSchema { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(JsonSchema))]
#endif
        public bool IsJsonSchema => JsonSchema != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickJsonSchema(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::TwelveLabs.TextParamFormatVariant2? value)
        {
            value = JsonSchema;
            return IsJsonSchema;
        }

        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TextParamFormatVariant2 PickJsonSchema() => IsJsonSchema
            ? JsonSchema!
            : throw new global::System.InvalidOperationException($"Expected union variant 'JsonSchema' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator TextParamFormat(global::TwelveLabs.TextParamFormatVariant1 value) => new TextParamFormat((global::TwelveLabs.TextParamFormatVariant1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::TwelveLabs.TextParamFormatVariant1?(TextParamFormat @this) => @this.Text;

        /// <summary>
        ///
        /// </summary>
        public TextParamFormat(global::TwelveLabs.TextParamFormatVariant1? value)
        {
            Text = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TextParamFormat FromText(global::TwelveLabs.TextParamFormatVariant1? value) => new TextParamFormat(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator TextParamFormat(global::TwelveLabs.TextParamFormatVariant2 value) => new TextParamFormat((global::TwelveLabs.TextParamFormatVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::TwelveLabs.TextParamFormatVariant2?(TextParamFormat @this) => @this.JsonSchema;

        /// <summary>
        ///
        /// </summary>
        public TextParamFormat(global::TwelveLabs.TextParamFormatVariant2? value)
        {
            JsonSchema = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TextParamFormat FromJsonSchema(global::TwelveLabs.TextParamFormatVariant2? value) => new TextParamFormat(value);

        /// <summary>
        ///
        /// </summary>
        public TextParamFormat(
            global::TwelveLabs.TextParamFormatDiscriminatorType? type,
            global::TwelveLabs.TextParamFormatVariant1? text,
            global::TwelveLabs.TextParamFormatVariant2? jsonSchema
            )
        {
            Type = type;

            Text = text;
            JsonSchema = jsonSchema;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            JsonSchema as object ??
            Text as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Text?.ToString() ??
            JsonSchema?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsText && !IsJsonSchema || !IsText && IsJsonSchema;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::TwelveLabs.TextParamFormatVariant1, TResult>? text = null,
            global::System.Func<global::TwelveLabs.TextParamFormatVariant2, TResult>? jsonSchema = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsText && text != null)
            {
                return text(Text!);
            }
            else if (IsJsonSchema && jsonSchema != null)
            {
                return jsonSchema(JsonSchema!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::TwelveLabs.TextParamFormatVariant1>? text = null,

            global::System.Action<global::TwelveLabs.TextParamFormatVariant2>? jsonSchema = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsText)
            {
                text?.Invoke(Text!);
            }
            else if (IsJsonSchema)
            {
                jsonSchema?.Invoke(JsonSchema!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::TwelveLabs.TextParamFormatVariant1>? text = null,
            global::System.Action<global::TwelveLabs.TextParamFormatVariant2>? jsonSchema = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsText)
            {
                text?.Invoke(Text!);
            }
            else if (IsJsonSchema)
            {
                jsonSchema?.Invoke(JsonSchema!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Text,
                typeof(global::TwelveLabs.TextParamFormatVariant1),
                JsonSchema,
                typeof(global::TwelveLabs.TextParamFormatVariant2),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        ///
        /// </summary>
        public bool Equals(TextParamFormat other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::TwelveLabs.TextParamFormatVariant1?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::TwelveLabs.TextParamFormatVariant2?>.Default.Equals(JsonSchema, other.JsonSchema)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(TextParamFormat obj1, TextParamFormat obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TextParamFormat>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(TextParamFormat obj1, TextParamFormat obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TextParamFormat o && Equals(o);
        }
    }
}
