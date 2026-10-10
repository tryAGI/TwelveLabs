#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// An item in the response output. Use `type` to distinguish messages,<br/>
    /// function calls, function results, and hosted web-search calls.<br/>
    /// An item has the same `id` in streaming events and the final response.
    /// </summary>
    public readonly partial struct ResponseOutputItem : global::System.IEquatable<ResponseOutputItem>
    {
        /// <summary>
        /// A message, function call, or function result in the response output.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::TwelveLabs.ResponseOutputItemVariant1? ResponseOutputItemVariant1 { get; init; }
#else
        public global::TwelveLabs.ResponseOutputItemVariant1? ResponseOutputItemVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseOutputItemVariant1))]
#endif
        public bool IsResponseOutputItemVariant1 => ResponseOutputItemVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseOutputItemVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::TwelveLabs.ResponseOutputItemVariant1? value)
        {
            value = ResponseOutputItemVariant1;
            return IsResponseOutputItemVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseOutputItemVariant1 PickResponseOutputItemVariant1() => ResponseOutputItemVariant1 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseOutputItemVariant1' but the value was {ToString()}.");

        /// <summary>
        /// A message, function call, or function result in the response output.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::TwelveLabs.ResponseOutputItemVariant2? ResponseOutputItemVariant2 { get; init; }
#else
        public global::TwelveLabs.ResponseOutputItemVariant2? ResponseOutputItemVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseOutputItemVariant2))]
#endif
        public bool IsResponseOutputItemVariant2 => ResponseOutputItemVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseOutputItemVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::TwelveLabs.ResponseOutputItemVariant2? value)
        {
            value = ResponseOutputItemVariant2;
            return IsResponseOutputItemVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseOutputItemVariant2 PickResponseOutputItemVariant2() => ResponseOutputItemVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseOutputItemVariant2' but the value was {ToString()}.");

        /// <summary>
        /// A message, function call, or function result in the response output.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::TwelveLabs.ResponseOutputItemVariant3? ResponseOutputItemVariant3 { get; init; }
#else
        public global::TwelveLabs.ResponseOutputItemVariant3? ResponseOutputItemVariant3 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseOutputItemVariant3))]
#endif
        public bool IsResponseOutputItemVariant3 => ResponseOutputItemVariant3 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseOutputItemVariant3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::TwelveLabs.ResponseOutputItemVariant3? value)
        {
            value = ResponseOutputItemVariant3;
            return IsResponseOutputItemVariant3;
        }

        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseOutputItemVariant3 PickResponseOutputItemVariant3() => ResponseOutputItemVariant3 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseOutputItemVariant3' but the value was {ToString()}.");

        /// <summary>
        /// A web-search call that Jockey ran, with its status and available action details.<br/>
        /// These items appear only with `include: ["intermediate_outputs"]` in the request.<br/>
        /// The `jockey:web_search` type follows the [Open Responses extension naming convention](https://www.openresponses.org/specification#extending-tools).<br/>
        /// Use this type in request `tools` to enable search. In response `output`, it identifies one call.<br/>
        /// If the response fails, the call keeps its last reported status. Response failure does not imply call completion.<br/>
        /// This item does not contain retrieved page contents or a separate search-results payload.<br/>
        /// Web sources cited by the answer appear in the message's `content[].annotations`.<br/>
        /// Use `session_id` to continue a conversation; this output item is not accepted in `input`.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::TwelveLabs.ResponseOutputItemVariant4? JockeyWebSearch { get; init; }
#else
        public global::TwelveLabs.ResponseOutputItemVariant4? JockeyWebSearch { get; }
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
            out global::TwelveLabs.ResponseOutputItemVariant4? value)
        {
            value = JockeyWebSearch;
            return IsJockeyWebSearch;
        }

        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseOutputItemVariant4 PickJockeyWebSearch() => JockeyWebSearch is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'JockeyWebSearch' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponseOutputItem(global::TwelveLabs.ResponseOutputItemVariant1 value) => new ResponseOutputItem((global::TwelveLabs.ResponseOutputItemVariant1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::TwelveLabs.ResponseOutputItemVariant1?(ResponseOutputItem @this) => @this.ResponseOutputItemVariant1;

        /// <summary>
        ///
        /// </summary>
        public ResponseOutputItem(global::TwelveLabs.ResponseOutputItemVariant1? value)
        {
            ResponseOutputItemVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponseOutputItem FromResponseOutputItemVariant1(global::TwelveLabs.ResponseOutputItemVariant1? value) => new ResponseOutputItem(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponseOutputItem(global::TwelveLabs.ResponseOutputItemVariant2 value) => new ResponseOutputItem((global::TwelveLabs.ResponseOutputItemVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::TwelveLabs.ResponseOutputItemVariant2?(ResponseOutputItem @this) => @this.ResponseOutputItemVariant2;

        /// <summary>
        ///
        /// </summary>
        public ResponseOutputItem(global::TwelveLabs.ResponseOutputItemVariant2? value)
        {
            ResponseOutputItemVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponseOutputItem FromResponseOutputItemVariant2(global::TwelveLabs.ResponseOutputItemVariant2? value) => new ResponseOutputItem(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponseOutputItem(global::TwelveLabs.ResponseOutputItemVariant3 value) => new ResponseOutputItem((global::TwelveLabs.ResponseOutputItemVariant3?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::TwelveLabs.ResponseOutputItemVariant3?(ResponseOutputItem @this) => @this.ResponseOutputItemVariant3;

        /// <summary>
        ///
        /// </summary>
        public ResponseOutputItem(global::TwelveLabs.ResponseOutputItemVariant3? value)
        {
            ResponseOutputItemVariant3 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponseOutputItem FromResponseOutputItemVariant3(global::TwelveLabs.ResponseOutputItemVariant3? value) => new ResponseOutputItem(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponseOutputItem(global::TwelveLabs.ResponseOutputItemVariant4 value) => new ResponseOutputItem((global::TwelveLabs.ResponseOutputItemVariant4?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::TwelveLabs.ResponseOutputItemVariant4?(ResponseOutputItem @this) => @this.JockeyWebSearch;

        /// <summary>
        ///
        /// </summary>
        public ResponseOutputItem(global::TwelveLabs.ResponseOutputItemVariant4? value)
        {
            JockeyWebSearch = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponseOutputItem FromJockeyWebSearch(global::TwelveLabs.ResponseOutputItemVariant4? value) => new ResponseOutputItem(value);

        /// <summary>
        ///
        /// </summary>
        public ResponseOutputItem(
            global::TwelveLabs.ResponseOutputItemVariant1? responseOutputItemVariant1,
            global::TwelveLabs.ResponseOutputItemVariant2? responseOutputItemVariant2,
            global::TwelveLabs.ResponseOutputItemVariant3? responseOutputItemVariant3,
            global::TwelveLabs.ResponseOutputItemVariant4? jockeyWebSearch
            )
        {
            ResponseOutputItemVariant1 = responseOutputItemVariant1;
            ResponseOutputItemVariant2 = responseOutputItemVariant2;
            ResponseOutputItemVariant3 = responseOutputItemVariant3;
            JockeyWebSearch = jockeyWebSearch;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            JockeyWebSearch as object ??
            ResponseOutputItemVariant3 as object ??
            ResponseOutputItemVariant2 as object ??
            ResponseOutputItemVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            ResponseOutputItemVariant1?.ToString() ??
            ResponseOutputItemVariant2?.ToString() ??
            ResponseOutputItemVariant3?.ToString() ??
            JockeyWebSearch?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsResponseOutputItemVariant1 && !IsResponseOutputItemVariant2 && !IsResponseOutputItemVariant3 && !IsJockeyWebSearch || !IsResponseOutputItemVariant1 && IsResponseOutputItemVariant2 && !IsResponseOutputItemVariant3 && !IsJockeyWebSearch || !IsResponseOutputItemVariant1 && !IsResponseOutputItemVariant2 && IsResponseOutputItemVariant3 && !IsJockeyWebSearch || !IsResponseOutputItemVariant1 && !IsResponseOutputItemVariant2 && !IsResponseOutputItemVariant3 && IsJockeyWebSearch;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::TwelveLabs.ResponseOutputItemVariant1, TResult>? responseOutputItemVariant1 = null,
            global::System.Func<global::TwelveLabs.ResponseOutputItemVariant2, TResult>? responseOutputItemVariant2 = null,
            global::System.Func<global::TwelveLabs.ResponseOutputItemVariant3, TResult>? responseOutputItemVariant3 = null,
            global::System.Func<global::TwelveLabs.ResponseOutputItemVariant4, TResult>? jockeyWebSearch = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ResponseOutputItemVariant1 is { } __value0 && responseOutputItemVariant1 != null)
            {
                return responseOutputItemVariant1(__value0);
            }
            else if (ResponseOutputItemVariant2 is { } __value1 && responseOutputItemVariant2 != null)
            {
                return responseOutputItemVariant2(__value1);
            }
            else if (ResponseOutputItemVariant3 is { } __value2 && responseOutputItemVariant3 != null)
            {
                return responseOutputItemVariant3(__value2);
            }
            else if (JockeyWebSearch is { } __value3 && jockeyWebSearch != null)
            {
                return jockeyWebSearch(__value3);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::TwelveLabs.ResponseOutputItemVariant1>? responseOutputItemVariant1 = null,

            global::System.Action<global::TwelveLabs.ResponseOutputItemVariant2>? responseOutputItemVariant2 = null,

            global::System.Action<global::TwelveLabs.ResponseOutputItemVariant3>? responseOutputItemVariant3 = null,

            global::System.Action<global::TwelveLabs.ResponseOutputItemVariant4>? jockeyWebSearch = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ResponseOutputItemVariant1 is { } __value0)
            {
                responseOutputItemVariant1?.Invoke(__value0);
            }
            else if (ResponseOutputItemVariant2 is { } __value1)
            {
                responseOutputItemVariant2?.Invoke(__value1);
            }
            else if (ResponseOutputItemVariant3 is { } __value2)
            {
                responseOutputItemVariant3?.Invoke(__value2);
            }
            else if (JockeyWebSearch is { } __value3)
            {
                jockeyWebSearch?.Invoke(__value3);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::TwelveLabs.ResponseOutputItemVariant1>? responseOutputItemVariant1 = null,
            global::System.Action<global::TwelveLabs.ResponseOutputItemVariant2>? responseOutputItemVariant2 = null,
            global::System.Action<global::TwelveLabs.ResponseOutputItemVariant3>? responseOutputItemVariant3 = null,
            global::System.Action<global::TwelveLabs.ResponseOutputItemVariant4>? jockeyWebSearch = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ResponseOutputItemVariant1 is { } __value0)
            {
                responseOutputItemVariant1?.Invoke(__value0);
            }
            else if (ResponseOutputItemVariant2 is { } __value1)
            {
                responseOutputItemVariant2?.Invoke(__value1);
            }
            else if (ResponseOutputItemVariant3 is { } __value2)
            {
                responseOutputItemVariant3?.Invoke(__value2);
            }
            else if (JockeyWebSearch is { } __value3)
            {
                jockeyWebSearch?.Invoke(__value3);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ResponseOutputItemVariant1,
                typeof(global::TwelveLabs.ResponseOutputItemVariant1),
                ResponseOutputItemVariant2,
                typeof(global::TwelveLabs.ResponseOutputItemVariant2),
                ResponseOutputItemVariant3,
                typeof(global::TwelveLabs.ResponseOutputItemVariant3),
                JockeyWebSearch,
                typeof(global::TwelveLabs.ResponseOutputItemVariant4),
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
        public bool Equals(ResponseOutputItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::TwelveLabs.ResponseOutputItemVariant1?>.Default.Equals(ResponseOutputItemVariant1, other.ResponseOutputItemVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::TwelveLabs.ResponseOutputItemVariant2?>.Default.Equals(ResponseOutputItemVariant2, other.ResponseOutputItemVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::TwelveLabs.ResponseOutputItemVariant3?>.Default.Equals(ResponseOutputItemVariant3, other.ResponseOutputItemVariant3) &&
                global::System.Collections.Generic.EqualityComparer<global::TwelveLabs.ResponseOutputItemVariant4?>.Default.Equals(JockeyWebSearch, other.JockeyWebSearch)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ResponseOutputItem obj1, ResponseOutputItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ResponseOutputItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ResponseOutputItem obj1, ResponseOutputItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ResponseOutputItem o && Equals(o);
        }
    }
}
