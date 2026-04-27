#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Configuration for metadata enrichment. Provide **exactly one** of `json_schema` or `description`.<br/>
    /// - Use `json_schema` for structured extraction — the platform will extract data conforming to the provided schema.<br/>
    /// - Use `description` for natural-language instructions — the platform converts them into a schema internally.
    /// </summary>
    public readonly partial struct EnrichmentConfig : global::System.IEquatable<EnrichmentConfig>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::TwelveLabs.EnrichmentConfig0? EnrichmentConfig0 { get; init; }
#else
        public global::TwelveLabs.EnrichmentConfig0? EnrichmentConfig0 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EnrichmentConfig0))]
#endif
        public bool IsEnrichmentConfig0 => EnrichmentConfig0 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::TwelveLabs.EnrichmentConfig1? EnrichmentConfig1 { get; init; }
#else
        public global::TwelveLabs.EnrichmentConfig1? EnrichmentConfig1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EnrichmentConfig1))]
#endif
        public bool IsEnrichmentConfig1 => EnrichmentConfig1 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EnrichmentConfig(global::TwelveLabs.EnrichmentConfig0 value) => new EnrichmentConfig((global::TwelveLabs.EnrichmentConfig0?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::TwelveLabs.EnrichmentConfig0?(EnrichmentConfig @this) => @this.EnrichmentConfig0;

        /// <summary>
        /// 
        /// </summary>
        public EnrichmentConfig(global::TwelveLabs.EnrichmentConfig0? value)
        {
            EnrichmentConfig0 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EnrichmentConfig(global::TwelveLabs.EnrichmentConfig1 value) => new EnrichmentConfig((global::TwelveLabs.EnrichmentConfig1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::TwelveLabs.EnrichmentConfig1?(EnrichmentConfig @this) => @this.EnrichmentConfig1;

        /// <summary>
        /// 
        /// </summary>
        public EnrichmentConfig(global::TwelveLabs.EnrichmentConfig1? value)
        {
            EnrichmentConfig1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public EnrichmentConfig(
            global::TwelveLabs.EnrichmentConfig0? enrichmentConfig0,
            global::TwelveLabs.EnrichmentConfig1? enrichmentConfig1
            )
        {
            EnrichmentConfig0 = enrichmentConfig0;
            EnrichmentConfig1 = enrichmentConfig1;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            EnrichmentConfig1 as object ??
            EnrichmentConfig0 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            EnrichmentConfig0?.ToString() ??
            EnrichmentConfig1?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsEnrichmentConfig0 && !IsEnrichmentConfig1 || !IsEnrichmentConfig0 && IsEnrichmentConfig1;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::TwelveLabs.EnrichmentConfig0?, TResult>? enrichmentConfig0 = null,
            global::System.Func<global::TwelveLabs.EnrichmentConfig1?, TResult>? enrichmentConfig1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEnrichmentConfig0 && enrichmentConfig0 != null)
            {
                return enrichmentConfig0(EnrichmentConfig0!);
            }
            else if (IsEnrichmentConfig1 && enrichmentConfig1 != null)
            {
                return enrichmentConfig1(EnrichmentConfig1!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::TwelveLabs.EnrichmentConfig0?>? enrichmentConfig0 = null,
            global::System.Action<global::TwelveLabs.EnrichmentConfig1?>? enrichmentConfig1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEnrichmentConfig0)
            {
                enrichmentConfig0?.Invoke(EnrichmentConfig0!);
            }
            else if (IsEnrichmentConfig1)
            {
                enrichmentConfig1?.Invoke(EnrichmentConfig1!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                EnrichmentConfig0,
                typeof(global::TwelveLabs.EnrichmentConfig0),
                EnrichmentConfig1,
                typeof(global::TwelveLabs.EnrichmentConfig1),
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
                global::System.Collections.Generic.EqualityComparer<global::TwelveLabs.EnrichmentConfig0?>.Default.Equals(EnrichmentConfig0, other.EnrichmentConfig0) &&
                global::System.Collections.Generic.EqualityComparer<global::TwelveLabs.EnrichmentConfig1?>.Default.Equals(EnrichmentConfig1, other.EnrichmentConfig1) 
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
