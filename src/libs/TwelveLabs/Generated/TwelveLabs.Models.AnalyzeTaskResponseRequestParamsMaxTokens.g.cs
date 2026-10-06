#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The maximum response length you set. The value is an integer in tokens or the string `unlimited`.
    /// </summary>
    public readonly partial struct AnalyzeTaskResponseRequestParamsMaxTokens : global::System.IEquatable<AnalyzeTaskResponseRequestParamsMaxTokens>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public int? AnalyzeTaskResponseRequestParamsMaxTokensVariant1 { get; init; }
#else
        public int? AnalyzeTaskResponseRequestParamsMaxTokensVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AnalyzeTaskResponseRequestParamsMaxTokensVariant1))]
#endif
        public bool IsAnalyzeTaskResponseRequestParamsMaxTokensVariant1 => AnalyzeTaskResponseRequestParamsMaxTokensVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAnalyzeTaskResponseRequestParamsMaxTokensVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out int? value)
        {
            value = AnalyzeTaskResponseRequestParamsMaxTokensVariant1;
            return IsAnalyzeTaskResponseRequestParamsMaxTokensVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public int PickAnalyzeTaskResponseRequestParamsMaxTokensVariant1() => AnalyzeTaskResponseRequestParamsMaxTokensVariant1 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AnalyzeTaskResponseRequestParamsMaxTokensVariant1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::TwelveLabs.AnalyzeTaskResponseRequestParamsMaxTokens1? AnalyzeTaskResponseRequestParamsMaxTokens1 { get; init; }
#else
        public global::TwelveLabs.AnalyzeTaskResponseRequestParamsMaxTokens1? AnalyzeTaskResponseRequestParamsMaxTokens1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AnalyzeTaskResponseRequestParamsMaxTokens1))]
#endif
        public bool IsAnalyzeTaskResponseRequestParamsMaxTokens1 => AnalyzeTaskResponseRequestParamsMaxTokens1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAnalyzeTaskResponseRequestParamsMaxTokens1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::TwelveLabs.AnalyzeTaskResponseRequestParamsMaxTokens1? value)
        {
            value = AnalyzeTaskResponseRequestParamsMaxTokens1;
            return IsAnalyzeTaskResponseRequestParamsMaxTokens1;
        }

        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskResponseRequestParamsMaxTokens1 PickAnalyzeTaskResponseRequestParamsMaxTokens1() => AnalyzeTaskResponseRequestParamsMaxTokens1 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AnalyzeTaskResponseRequestParamsMaxTokens1' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AnalyzeTaskResponseRequestParamsMaxTokens(int value) => new AnalyzeTaskResponseRequestParamsMaxTokens((int?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator int?(AnalyzeTaskResponseRequestParamsMaxTokens @this) => @this.AnalyzeTaskResponseRequestParamsMaxTokensVariant1;

        /// <summary>
        ///
        /// </summary>
        public AnalyzeTaskResponseRequestParamsMaxTokens(int? value)
        {
            AnalyzeTaskResponseRequestParamsMaxTokensVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AnalyzeTaskResponseRequestParamsMaxTokens FromAnalyzeTaskResponseRequestParamsMaxTokensVariant1(int? value) => new AnalyzeTaskResponseRequestParamsMaxTokens(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AnalyzeTaskResponseRequestParamsMaxTokens(global::TwelveLabs.AnalyzeTaskResponseRequestParamsMaxTokens1 value) => new AnalyzeTaskResponseRequestParamsMaxTokens((global::TwelveLabs.AnalyzeTaskResponseRequestParamsMaxTokens1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::TwelveLabs.AnalyzeTaskResponseRequestParamsMaxTokens1?(AnalyzeTaskResponseRequestParamsMaxTokens @this) => @this.AnalyzeTaskResponseRequestParamsMaxTokens1;

        /// <summary>
        ///
        /// </summary>
        public AnalyzeTaskResponseRequestParamsMaxTokens(global::TwelveLabs.AnalyzeTaskResponseRequestParamsMaxTokens1? value)
        {
            AnalyzeTaskResponseRequestParamsMaxTokens1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AnalyzeTaskResponseRequestParamsMaxTokens FromAnalyzeTaskResponseRequestParamsMaxTokens1(global::TwelveLabs.AnalyzeTaskResponseRequestParamsMaxTokens1? value) => new AnalyzeTaskResponseRequestParamsMaxTokens(value);

        /// <summary>
        ///
        /// </summary>
        public AnalyzeTaskResponseRequestParamsMaxTokens(
            int? analyzeTaskResponseRequestParamsMaxTokensVariant1,
            global::TwelveLabs.AnalyzeTaskResponseRequestParamsMaxTokens1? analyzeTaskResponseRequestParamsMaxTokens1
            )
        {
            AnalyzeTaskResponseRequestParamsMaxTokensVariant1 = analyzeTaskResponseRequestParamsMaxTokensVariant1;
            AnalyzeTaskResponseRequestParamsMaxTokens1 = analyzeTaskResponseRequestParamsMaxTokens1;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            AnalyzeTaskResponseRequestParamsMaxTokens1 as object ??
            AnalyzeTaskResponseRequestParamsMaxTokensVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            AnalyzeTaskResponseRequestParamsMaxTokensVariant1?.ToString() ??
            AnalyzeTaskResponseRequestParamsMaxTokens1?.ToValueString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsAnalyzeTaskResponseRequestParamsMaxTokensVariant1 && !IsAnalyzeTaskResponseRequestParamsMaxTokens1 || !IsAnalyzeTaskResponseRequestParamsMaxTokensVariant1 && IsAnalyzeTaskResponseRequestParamsMaxTokens1;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<int?, TResult>? analyzeTaskResponseRequestParamsMaxTokensVariant1 = null,
            global::System.Func<global::TwelveLabs.AnalyzeTaskResponseRequestParamsMaxTokens1?, TResult>? analyzeTaskResponseRequestParamsMaxTokens1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AnalyzeTaskResponseRequestParamsMaxTokensVariant1 is { } __value0 && analyzeTaskResponseRequestParamsMaxTokensVariant1 != null)
            {
                return analyzeTaskResponseRequestParamsMaxTokensVariant1(__value0);
            }
            else if (AnalyzeTaskResponseRequestParamsMaxTokens1 is { } __value1 && analyzeTaskResponseRequestParamsMaxTokens1 != null)
            {
                return analyzeTaskResponseRequestParamsMaxTokens1(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<int?>? analyzeTaskResponseRequestParamsMaxTokensVariant1 = null,

            global::System.Action<global::TwelveLabs.AnalyzeTaskResponseRequestParamsMaxTokens1?>? analyzeTaskResponseRequestParamsMaxTokens1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AnalyzeTaskResponseRequestParamsMaxTokensVariant1 is { } __value0)
            {
                analyzeTaskResponseRequestParamsMaxTokensVariant1?.Invoke(__value0);
            }
            else if (AnalyzeTaskResponseRequestParamsMaxTokens1 is { } __value1)
            {
                analyzeTaskResponseRequestParamsMaxTokens1?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<int?>? analyzeTaskResponseRequestParamsMaxTokensVariant1 = null,
            global::System.Action<global::TwelveLabs.AnalyzeTaskResponseRequestParamsMaxTokens1?>? analyzeTaskResponseRequestParamsMaxTokens1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AnalyzeTaskResponseRequestParamsMaxTokensVariant1 is { } __value0)
            {
                analyzeTaskResponseRequestParamsMaxTokensVariant1?.Invoke(__value0);
            }
            else if (AnalyzeTaskResponseRequestParamsMaxTokens1 is { } __value1)
            {
                analyzeTaskResponseRequestParamsMaxTokens1?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AnalyzeTaskResponseRequestParamsMaxTokensVariant1,
                typeof(int),
                AnalyzeTaskResponseRequestParamsMaxTokens1,
                typeof(global::TwelveLabs.AnalyzeTaskResponseRequestParamsMaxTokens1),
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
        public bool Equals(AnalyzeTaskResponseRequestParamsMaxTokens other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<int?>.Default.Equals(AnalyzeTaskResponseRequestParamsMaxTokensVariant1, other.AnalyzeTaskResponseRequestParamsMaxTokensVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::TwelveLabs.AnalyzeTaskResponseRequestParamsMaxTokens1?>.Default.Equals(AnalyzeTaskResponseRequestParamsMaxTokens1, other.AnalyzeTaskResponseRequestParamsMaxTokens1)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AnalyzeTaskResponseRequestParamsMaxTokens obj1, AnalyzeTaskResponseRequestParamsMaxTokens obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AnalyzeTaskResponseRequestParamsMaxTokens>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AnalyzeTaskResponseRequestParamsMaxTokens obj1, AnalyzeTaskResponseRequestParamsMaxTokens obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AnalyzeTaskResponseRequestParamsMaxTokens o && Equals(o);
        }
    }
}
