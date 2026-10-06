#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The maximum response length, in tokens. Provide an integer or the `unlimited` value.<br/>
    /// The allowed integer range and default depend on the analysis mode:<br/>
    /// | Mode | Min | Max | Default |<br/>
    /// |------|-----|-----|---------|<br/>
    /// | `general` | 512 | 98,304 | 4,096 |<br/>
    /// | `time_based_metadata` | 2,048 | 98,304 | 32,768 |<br/>
    /// - **Integer**: With video segmentation, the task fails if the output exceeds the limit. No partial output is returned.<br/>
    /// - **Unlimited**: Removes the token limit from video segmentation. It requires `analysis_mode` set to `time_based_metadata` and `model_name` set to `pegasus1.6`. Mutually exclusive with `response_format.segment_definitions[].time_ranges`.<br/>
    ///   The platform extracts as many segments as it can. If it stops before extracting every segment, the task still completes with the `status` field set to `ready`. The `error` field contains the warning that the results may be incomplete.
    /// </summary>
    public readonly partial struct CreateAsyncAnalyzeRequestMaxTokens : global::System.IEquatable<CreateAsyncAnalyzeRequestMaxTokens>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public int? CreateAsyncAnalyzeRequestMaxTokensVariant1 { get; init; }
#else
        public int? CreateAsyncAnalyzeRequestMaxTokensVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CreateAsyncAnalyzeRequestMaxTokensVariant1))]
#endif
        public bool IsCreateAsyncAnalyzeRequestMaxTokensVariant1 => CreateAsyncAnalyzeRequestMaxTokensVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCreateAsyncAnalyzeRequestMaxTokensVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out int? value)
        {
            value = CreateAsyncAnalyzeRequestMaxTokensVariant1;
            return IsCreateAsyncAnalyzeRequestMaxTokensVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public int PickCreateAsyncAnalyzeRequestMaxTokensVariant1() => CreateAsyncAnalyzeRequestMaxTokensVariant1 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'CreateAsyncAnalyzeRequestMaxTokensVariant1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::TwelveLabs.CreateAsyncAnalyzeRequestMaxTokens1? CreateAsyncAnalyzeRequestMaxTokens1 { get; init; }
#else
        public global::TwelveLabs.CreateAsyncAnalyzeRequestMaxTokens1? CreateAsyncAnalyzeRequestMaxTokens1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CreateAsyncAnalyzeRequestMaxTokens1))]
#endif
        public bool IsCreateAsyncAnalyzeRequestMaxTokens1 => CreateAsyncAnalyzeRequestMaxTokens1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCreateAsyncAnalyzeRequestMaxTokens1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::TwelveLabs.CreateAsyncAnalyzeRequestMaxTokens1? value)
        {
            value = CreateAsyncAnalyzeRequestMaxTokens1;
            return IsCreateAsyncAnalyzeRequestMaxTokens1;
        }

        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateAsyncAnalyzeRequestMaxTokens1 PickCreateAsyncAnalyzeRequestMaxTokens1() => CreateAsyncAnalyzeRequestMaxTokens1 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'CreateAsyncAnalyzeRequestMaxTokens1' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateAsyncAnalyzeRequestMaxTokens(int value) => new CreateAsyncAnalyzeRequestMaxTokens((int?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator int?(CreateAsyncAnalyzeRequestMaxTokens @this) => @this.CreateAsyncAnalyzeRequestMaxTokensVariant1;

        /// <summary>
        ///
        /// </summary>
        public CreateAsyncAnalyzeRequestMaxTokens(int? value)
        {
            CreateAsyncAnalyzeRequestMaxTokensVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateAsyncAnalyzeRequestMaxTokens FromCreateAsyncAnalyzeRequestMaxTokensVariant1(int? value) => new CreateAsyncAnalyzeRequestMaxTokens(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateAsyncAnalyzeRequestMaxTokens(global::TwelveLabs.CreateAsyncAnalyzeRequestMaxTokens1 value) => new CreateAsyncAnalyzeRequestMaxTokens((global::TwelveLabs.CreateAsyncAnalyzeRequestMaxTokens1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::TwelveLabs.CreateAsyncAnalyzeRequestMaxTokens1?(CreateAsyncAnalyzeRequestMaxTokens @this) => @this.CreateAsyncAnalyzeRequestMaxTokens1;

        /// <summary>
        ///
        /// </summary>
        public CreateAsyncAnalyzeRequestMaxTokens(global::TwelveLabs.CreateAsyncAnalyzeRequestMaxTokens1? value)
        {
            CreateAsyncAnalyzeRequestMaxTokens1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateAsyncAnalyzeRequestMaxTokens FromCreateAsyncAnalyzeRequestMaxTokens1(global::TwelveLabs.CreateAsyncAnalyzeRequestMaxTokens1? value) => new CreateAsyncAnalyzeRequestMaxTokens(value);

        /// <summary>
        ///
        /// </summary>
        public CreateAsyncAnalyzeRequestMaxTokens(
            int? createAsyncAnalyzeRequestMaxTokensVariant1,
            global::TwelveLabs.CreateAsyncAnalyzeRequestMaxTokens1? createAsyncAnalyzeRequestMaxTokens1
            )
        {
            CreateAsyncAnalyzeRequestMaxTokensVariant1 = createAsyncAnalyzeRequestMaxTokensVariant1;
            CreateAsyncAnalyzeRequestMaxTokens1 = createAsyncAnalyzeRequestMaxTokens1;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            CreateAsyncAnalyzeRequestMaxTokens1 as object ??
            CreateAsyncAnalyzeRequestMaxTokensVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            CreateAsyncAnalyzeRequestMaxTokensVariant1?.ToString() ??
            CreateAsyncAnalyzeRequestMaxTokens1?.ToValueString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsCreateAsyncAnalyzeRequestMaxTokensVariant1 && !IsCreateAsyncAnalyzeRequestMaxTokens1 || !IsCreateAsyncAnalyzeRequestMaxTokensVariant1 && IsCreateAsyncAnalyzeRequestMaxTokens1;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<int?, TResult>? createAsyncAnalyzeRequestMaxTokensVariant1 = null,
            global::System.Func<global::TwelveLabs.CreateAsyncAnalyzeRequestMaxTokens1?, TResult>? createAsyncAnalyzeRequestMaxTokens1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (CreateAsyncAnalyzeRequestMaxTokensVariant1 is { } __value0 && createAsyncAnalyzeRequestMaxTokensVariant1 != null)
            {
                return createAsyncAnalyzeRequestMaxTokensVariant1(__value0);
            }
            else if (CreateAsyncAnalyzeRequestMaxTokens1 is { } __value1 && createAsyncAnalyzeRequestMaxTokens1 != null)
            {
                return createAsyncAnalyzeRequestMaxTokens1(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<int?>? createAsyncAnalyzeRequestMaxTokensVariant1 = null,

            global::System.Action<global::TwelveLabs.CreateAsyncAnalyzeRequestMaxTokens1?>? createAsyncAnalyzeRequestMaxTokens1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (CreateAsyncAnalyzeRequestMaxTokensVariant1 is { } __value0)
            {
                createAsyncAnalyzeRequestMaxTokensVariant1?.Invoke(__value0);
            }
            else if (CreateAsyncAnalyzeRequestMaxTokens1 is { } __value1)
            {
                createAsyncAnalyzeRequestMaxTokens1?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<int?>? createAsyncAnalyzeRequestMaxTokensVariant1 = null,
            global::System.Action<global::TwelveLabs.CreateAsyncAnalyzeRequestMaxTokens1?>? createAsyncAnalyzeRequestMaxTokens1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (CreateAsyncAnalyzeRequestMaxTokensVariant1 is { } __value0)
            {
                createAsyncAnalyzeRequestMaxTokensVariant1?.Invoke(__value0);
            }
            else if (CreateAsyncAnalyzeRequestMaxTokens1 is { } __value1)
            {
                createAsyncAnalyzeRequestMaxTokens1?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                CreateAsyncAnalyzeRequestMaxTokensVariant1,
                typeof(int),
                CreateAsyncAnalyzeRequestMaxTokens1,
                typeof(global::TwelveLabs.CreateAsyncAnalyzeRequestMaxTokens1),
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
        public bool Equals(CreateAsyncAnalyzeRequestMaxTokens other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<int?>.Default.Equals(CreateAsyncAnalyzeRequestMaxTokensVariant1, other.CreateAsyncAnalyzeRequestMaxTokensVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::TwelveLabs.CreateAsyncAnalyzeRequestMaxTokens1?>.Default.Equals(CreateAsyncAnalyzeRequestMaxTokens1, other.CreateAsyncAnalyzeRequestMaxTokens1)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(CreateAsyncAnalyzeRequestMaxTokens obj1, CreateAsyncAnalyzeRequestMaxTokens obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateAsyncAnalyzeRequestMaxTokens>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(CreateAsyncAnalyzeRequestMaxTokens obj1, CreateAsyncAnalyzeRequestMaxTokens obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateAsyncAnalyzeRequestMaxTokens o && Equals(o);
        }
    }
}
