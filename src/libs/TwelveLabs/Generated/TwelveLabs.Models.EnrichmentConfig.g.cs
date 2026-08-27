#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Metadata enrichment configuration. The `type` field selects one variant:<br/>
    /// - `type: json_schema` - Structured extraction conforming to a provided JSON Schema.<br/>
    /// - `type: description` - Natural-language instructions that the platform converts into a schema internally.
    /// </summary>
    public readonly partial struct EnrichmentConfig : global::System.IEquatable<EnrichmentConfig>
    {
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EnrichmentConfigDiscriminatorType? Type { get; }

        /// <summary>
        /// Structured extraction conforming to a provided JSON Schema.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::TwelveLabs.EnrichmentConfigVariant1? JsonSchema { get; init; }
#else
        public global::TwelveLabs.EnrichmentConfigVariant1? JsonSchema { get; }
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
            out global::TwelveLabs.EnrichmentConfigVariant1? value)
        {
            value = JsonSchema;
            return IsJsonSchema;
        }

        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EnrichmentConfigVariant1 PickJsonSchema() => IsJsonSchema
            ? JsonSchema!
            : throw new global::System.InvalidOperationException($"Expected union variant 'JsonSchema' but the value was {ToString()}.");

        /// <summary>
        /// Natural-language instructions that the platform converts into a JSON Schema internally.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::TwelveLabs.EnrichmentConfigVariant2? Description { get; init; }
#else
        public global::TwelveLabs.EnrichmentConfigVariant2? Description { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Description))]
#endif
        public bool IsDescription => Description != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickDescription(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::TwelveLabs.EnrichmentConfigVariant2? value)
        {
            value = Description;
            return IsDescription;
        }

        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EnrichmentConfigVariant2 PickDescription() => IsDescription
            ? Description!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Description' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator EnrichmentConfig(global::TwelveLabs.EnrichmentConfigVariant1 value) => new EnrichmentConfig((global::TwelveLabs.EnrichmentConfigVariant1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::TwelveLabs.EnrichmentConfigVariant1?(EnrichmentConfig @this) => @this.JsonSchema;

        /// <summary>
        ///
        /// </summary>
        public EnrichmentConfig(global::TwelveLabs.EnrichmentConfigVariant1? value)
        {
            JsonSchema = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static EnrichmentConfig FromJsonSchema(global::TwelveLabs.EnrichmentConfigVariant1? value) => new EnrichmentConfig(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator EnrichmentConfig(global::TwelveLabs.EnrichmentConfigVariant2 value) => new EnrichmentConfig((global::TwelveLabs.EnrichmentConfigVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::TwelveLabs.EnrichmentConfigVariant2?(EnrichmentConfig @this) => @this.Description;

        /// <summary>
        ///
        /// </summary>
        public EnrichmentConfig(global::TwelveLabs.EnrichmentConfigVariant2? value)
        {
            Description = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static EnrichmentConfig FromDescription(global::TwelveLabs.EnrichmentConfigVariant2? value) => new EnrichmentConfig(value);

        /// <summary>
        ///
        /// </summary>
        public EnrichmentConfig(
            global::TwelveLabs.EnrichmentConfigDiscriminatorType? type,
            global::TwelveLabs.EnrichmentConfigVariant1? jsonSchema,
            global::TwelveLabs.EnrichmentConfigVariant2? description
            )
        {
            Type = type;

            JsonSchema = jsonSchema;
            Description = description;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Description as object ??
            JsonSchema as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            JsonSchema?.ToString() ??
            Description?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsJsonSchema && !IsDescription || !IsJsonSchema && IsDescription;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::TwelveLabs.EnrichmentConfigVariant1, TResult>? jsonSchema = null,
            global::System.Func<global::TwelveLabs.EnrichmentConfigVariant2, TResult>? description = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsJsonSchema && jsonSchema != null)
            {
                return jsonSchema(JsonSchema!);
            }
            else if (IsDescription && description != null)
            {
                return description(Description!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::TwelveLabs.EnrichmentConfigVariant1>? jsonSchema = null,

            global::System.Action<global::TwelveLabs.EnrichmentConfigVariant2>? description = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsJsonSchema)
            {
                jsonSchema?.Invoke(JsonSchema!);
            }
            else if (IsDescription)
            {
                description?.Invoke(Description!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::TwelveLabs.EnrichmentConfigVariant1>? jsonSchema = null,
            global::System.Action<global::TwelveLabs.EnrichmentConfigVariant2>? description = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsJsonSchema)
            {
                jsonSchema?.Invoke(JsonSchema!);
            }
            else if (IsDescription)
            {
                description?.Invoke(Description!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                JsonSchema,
                typeof(global::TwelveLabs.EnrichmentConfigVariant1),
                Description,
                typeof(global::TwelveLabs.EnrichmentConfigVariant2),
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
        public bool Equals(EnrichmentConfig other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::TwelveLabs.EnrichmentConfigVariant1?>.Default.Equals(JsonSchema, other.JsonSchema) &&
                global::System.Collections.Generic.EqualityComparer<global::TwelveLabs.EnrichmentConfigVariant2?>.Default.Equals(Description, other.Description)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(EnrichmentConfig obj1, EnrichmentConfig obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<EnrichmentConfig>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(EnrichmentConfig obj1, EnrichmentConfig obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is EnrichmentConfig o && Equals(o);
        }
    }
}
