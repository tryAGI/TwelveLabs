#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// A tool that Jockey can use while it generates a response.
    /// </summary>
    public readonly partial struct ResponseToolInput : global::System.IEquatable<ResponseToolInput>
    {
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseToolInputDiscriminatorType? Type { get; }

        /// <summary>
        /// Searches the public web for content relevant to the request.<br/>
        /// Unknown properties are ignored.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::TwelveLabs.ResponseToolInputVariant1? JockeyWebSearch { get; init; }
#else
        public global::TwelveLabs.ResponseToolInputVariant1? JockeyWebSearch { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(JockeyWebSearch))]
#endif
        public bool IsJockeyWebSearch => JockeyWebSearch != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickJockeyWebSearch(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::TwelveLabs.ResponseToolInputVariant1? value)
        {
            value = JockeyWebSearch;
            return IsJockeyWebSearch;
        }

        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseToolInputVariant1 PickJockeyWebSearch() => JockeyWebSearch is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'JockeyWebSearch' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponseToolInput(global::TwelveLabs.ResponseToolInputVariant1 value) => new ResponseToolInput((global::TwelveLabs.ResponseToolInputVariant1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::TwelveLabs.ResponseToolInputVariant1?(ResponseToolInput @this) => @this.JockeyWebSearch;

        /// <summary>
        ///
        /// </summary>
        public ResponseToolInput(global::TwelveLabs.ResponseToolInputVariant1? value)
        {
            JockeyWebSearch = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponseToolInput FromJockeyWebSearch(global::TwelveLabs.ResponseToolInputVariant1? value) => new ResponseToolInput(value);

        /// <summary>
        ///
        /// </summary>
        public ResponseToolInput(
            global::TwelveLabs.ResponseToolInputDiscriminatorType? type,
            global::TwelveLabs.ResponseToolInputVariant1? jockeyWebSearch
            )
        {
            Type = type;

            JockeyWebSearch = jockeyWebSearch;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            JockeyWebSearch as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            JockeyWebSearch?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsJockeyWebSearch;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::TwelveLabs.ResponseToolInputVariant1, TResult>? jockeyWebSearch = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (JockeyWebSearch is { } __value0 && jockeyWebSearch != null)
            {
                return jockeyWebSearch(__value0);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::TwelveLabs.ResponseToolInputVariant1>? jockeyWebSearch = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (JockeyWebSearch is { } __value0)
            {
                jockeyWebSearch?.Invoke(__value0);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::TwelveLabs.ResponseToolInputVariant1>? jockeyWebSearch = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (JockeyWebSearch is { } __value0)
            {
                jockeyWebSearch?.Invoke(__value0);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                JockeyWebSearch,
                typeof(global::TwelveLabs.ResponseToolInputVariant1),
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
        public bool Equals(ResponseToolInput other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::TwelveLabs.ResponseToolInputVariant1?>.Default.Equals(JockeyWebSearch, other.JockeyWebSearch)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ResponseToolInput obj1, ResponseToolInput obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ResponseToolInput>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ResponseToolInput obj1, ResponseToolInput obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ResponseToolInput o && Equals(o);
        }
    }
}
