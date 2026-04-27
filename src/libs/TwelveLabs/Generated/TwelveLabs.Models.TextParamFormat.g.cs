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
        /// Plain text output format (default).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::TwelveLabs.TextResponseFormatText? TextResponseFormatText { get; init; }
#else
        public global::TwelveLabs.TextResponseFormatText? TextResponseFormatText { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TextResponseFormatText))]
#endif
        public bool IsTextResponseFormatText => TextResponseFormatText != null;

        /// <summary>
        /// Structured JSON output conforming to a provided schema.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::TwelveLabs.TextResponseFormatJsonSchema? TextResponseFormatJsonSchema { get; init; }
#else
        public global::TwelveLabs.TextResponseFormatJsonSchema? TextResponseFormatJsonSchema { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TextResponseFormatJsonSchema))]
#endif
        public bool IsTextResponseFormatJsonSchema => TextResponseFormatJsonSchema != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TextParamFormat(global::TwelveLabs.TextResponseFormatText value) => new TextParamFormat((global::TwelveLabs.TextResponseFormatText?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::TwelveLabs.TextResponseFormatText?(TextParamFormat @this) => @this.TextResponseFormatText;

        /// <summary>
        /// 
        /// </summary>
        public TextParamFormat(global::TwelveLabs.TextResponseFormatText? value)
        {
            TextResponseFormatText = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TextParamFormat(global::TwelveLabs.TextResponseFormatJsonSchema value) => new TextParamFormat((global::TwelveLabs.TextResponseFormatJsonSchema?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::TwelveLabs.TextResponseFormatJsonSchema?(TextParamFormat @this) => @this.TextResponseFormatJsonSchema;

        /// <summary>
        /// 
        /// </summary>
        public TextParamFormat(global::TwelveLabs.TextResponseFormatJsonSchema? value)
        {
            TextResponseFormatJsonSchema = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public TextParamFormat(
            global::TwelveLabs.TextResponseFormatText? textResponseFormatText,
            global::TwelveLabs.TextResponseFormatJsonSchema? textResponseFormatJsonSchema
            )
        {
            TextResponseFormatText = textResponseFormatText;
            TextResponseFormatJsonSchema = textResponseFormatJsonSchema;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            TextResponseFormatJsonSchema as object ??
            TextResponseFormatText as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            TextResponseFormatText?.ToString() ??
            TextResponseFormatJsonSchema?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsTextResponseFormatText && !IsTextResponseFormatJsonSchema || !IsTextResponseFormatText && IsTextResponseFormatJsonSchema;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::TwelveLabs.TextResponseFormatText?, TResult>? textResponseFormatText = null,
            global::System.Func<global::TwelveLabs.TextResponseFormatJsonSchema?, TResult>? textResponseFormatJsonSchema = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTextResponseFormatText && textResponseFormatText != null)
            {
                return textResponseFormatText(TextResponseFormatText!);
            }
            else if (IsTextResponseFormatJsonSchema && textResponseFormatJsonSchema != null)
            {
                return textResponseFormatJsonSchema(TextResponseFormatJsonSchema!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::TwelveLabs.TextResponseFormatText?>? textResponseFormatText = null,
            global::System.Action<global::TwelveLabs.TextResponseFormatJsonSchema?>? textResponseFormatJsonSchema = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTextResponseFormatText)
            {
                textResponseFormatText?.Invoke(TextResponseFormatText!);
            }
            else if (IsTextResponseFormatJsonSchema)
            {
                textResponseFormatJsonSchema?.Invoke(TextResponseFormatJsonSchema!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                TextResponseFormatText,
                typeof(global::TwelveLabs.TextResponseFormatText),
                TextResponseFormatJsonSchema,
                typeof(global::TwelveLabs.TextResponseFormatJsonSchema),
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
                global::System.Collections.Generic.EqualityComparer<global::TwelveLabs.TextResponseFormatText?>.Default.Equals(TextResponseFormatText, other.TextResponseFormatText) &&
                global::System.Collections.Generic.EqualityComparer<global::TwelveLabs.TextResponseFormatJsonSchema?>.Default.Equals(TextResponseFormatJsonSchema, other.TextResponseFormatJsonSchema) 
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
