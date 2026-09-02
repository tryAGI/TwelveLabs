#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// A single custom-metadata value: a string, a number, a boolean, or an array of strings. The value keeps the JSON type you send; a nested object, an array holding anything but strings, and a null value are rejected. An integer must fit in 53 bits (-9007199254740991 to 9007199254740991); send a wider value, and any identifier you want preserved verbatim, as a string.
    /// </summary>
    public readonly partial struct KnowledgeStoreMetadataValue : global::System.IEquatable<KnowledgeStoreMetadataValue>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public string? KnowledgeStoreMetadataValueVariant1 { get; init; }
#else
        public string? KnowledgeStoreMetadataValueVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(KnowledgeStoreMetadataValueVariant1))]
#endif
        public bool IsKnowledgeStoreMetadataValueVariant1 => KnowledgeStoreMetadataValueVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickKnowledgeStoreMetadataValueVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = KnowledgeStoreMetadataValueVariant1;
            return IsKnowledgeStoreMetadataValueVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public string PickKnowledgeStoreMetadataValueVariant1() => IsKnowledgeStoreMetadataValueVariant1
            ? KnowledgeStoreMetadataValueVariant1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'KnowledgeStoreMetadataValueVariant1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public int? KnowledgeStoreMetadataValueVariant2 { get; init; }
#else
        public int? KnowledgeStoreMetadataValueVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(KnowledgeStoreMetadataValueVariant2))]
#endif
        public bool IsKnowledgeStoreMetadataValueVariant2 => KnowledgeStoreMetadataValueVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickKnowledgeStoreMetadataValueVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out int? value)
        {
            value = KnowledgeStoreMetadataValueVariant2;
            return IsKnowledgeStoreMetadataValueVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public int PickKnowledgeStoreMetadataValueVariant2() => IsKnowledgeStoreMetadataValueVariant2
            ? KnowledgeStoreMetadataValueVariant2!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'KnowledgeStoreMetadataValueVariant2' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public double? KnowledgeStoreMetadataValueVariant3 { get; init; }
#else
        public double? KnowledgeStoreMetadataValueVariant3 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(KnowledgeStoreMetadataValueVariant3))]
#endif
        public bool IsKnowledgeStoreMetadataValueVariant3 => KnowledgeStoreMetadataValueVariant3 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickKnowledgeStoreMetadataValueVariant3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out double? value)
        {
            value = KnowledgeStoreMetadataValueVariant3;
            return IsKnowledgeStoreMetadataValueVariant3;
        }

        /// <summary>
        ///
        /// </summary>
        public double PickKnowledgeStoreMetadataValueVariant3() => IsKnowledgeStoreMetadataValueVariant3
            ? KnowledgeStoreMetadataValueVariant3!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'KnowledgeStoreMetadataValueVariant3' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public bool? KnowledgeStoreMetadataValueVariant4 { get; init; }
#else
        public bool? KnowledgeStoreMetadataValueVariant4 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(KnowledgeStoreMetadataValueVariant4))]
#endif
        public bool IsKnowledgeStoreMetadataValueVariant4 => KnowledgeStoreMetadataValueVariant4 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickKnowledgeStoreMetadataValueVariant4(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out bool? value)
        {
            value = KnowledgeStoreMetadataValueVariant4;
            return IsKnowledgeStoreMetadataValueVariant4;
        }

        /// <summary>
        ///
        /// </summary>
        public bool PickKnowledgeStoreMetadataValueVariant4() => IsKnowledgeStoreMetadataValueVariant4
            ? KnowledgeStoreMetadataValueVariant4!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'KnowledgeStoreMetadataValueVariant4' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<string>? KnowledgeStoreMetadataValueVariant5 { get; init; }
#else
        public global::System.Collections.Generic.IList<string>? KnowledgeStoreMetadataValueVariant5 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(KnowledgeStoreMetadataValueVariant5))]
#endif
        public bool IsKnowledgeStoreMetadataValueVariant5 => KnowledgeStoreMetadataValueVariant5 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickKnowledgeStoreMetadataValueVariant5(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.IList<string>? value)
        {
            value = KnowledgeStoreMetadataValueVariant5;
            return IsKnowledgeStoreMetadataValueVariant5;
        }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string> PickKnowledgeStoreMetadataValueVariant5() => IsKnowledgeStoreMetadataValueVariant5
            ? KnowledgeStoreMetadataValueVariant5!
            : throw new global::System.InvalidOperationException($"Expected union variant 'KnowledgeStoreMetadataValueVariant5' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator KnowledgeStoreMetadataValue(string value) => new KnowledgeStoreMetadataValue((string?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator string?(KnowledgeStoreMetadataValue @this) => @this.KnowledgeStoreMetadataValueVariant1;

        /// <summary>
        ///
        /// </summary>
        public KnowledgeStoreMetadataValue(string? value)
        {
            KnowledgeStoreMetadataValueVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static KnowledgeStoreMetadataValue FromKnowledgeStoreMetadataValueVariant1(string? value) => new KnowledgeStoreMetadataValue(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator KnowledgeStoreMetadataValue(int value) => new KnowledgeStoreMetadataValue((int?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator int?(KnowledgeStoreMetadataValue @this) => @this.KnowledgeStoreMetadataValueVariant2;

        /// <summary>
        ///
        /// </summary>
        public KnowledgeStoreMetadataValue(int? value)
        {
            KnowledgeStoreMetadataValueVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static KnowledgeStoreMetadataValue FromKnowledgeStoreMetadataValueVariant2(int? value) => new KnowledgeStoreMetadataValue(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator KnowledgeStoreMetadataValue(double value) => new KnowledgeStoreMetadataValue((double?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator double?(KnowledgeStoreMetadataValue @this) => @this.KnowledgeStoreMetadataValueVariant3;

        /// <summary>
        ///
        /// </summary>
        public KnowledgeStoreMetadataValue(double? value)
        {
            KnowledgeStoreMetadataValueVariant3 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static KnowledgeStoreMetadataValue FromKnowledgeStoreMetadataValueVariant3(double? value) => new KnowledgeStoreMetadataValue(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator KnowledgeStoreMetadataValue(bool value) => new KnowledgeStoreMetadataValue((bool?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator bool?(KnowledgeStoreMetadataValue @this) => @this.KnowledgeStoreMetadataValueVariant4;

        /// <summary>
        ///
        /// </summary>
        public KnowledgeStoreMetadataValue(bool? value)
        {
            KnowledgeStoreMetadataValueVariant4 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static KnowledgeStoreMetadataValue FromKnowledgeStoreMetadataValueVariant4(bool? value) => new KnowledgeStoreMetadataValue(value);

        /// <summary>
        ///
        /// </summary>
        public KnowledgeStoreMetadataValue(
            string? knowledgeStoreMetadataValueVariant1,
            int? knowledgeStoreMetadataValueVariant2,
            double? knowledgeStoreMetadataValueVariant3,
            bool? knowledgeStoreMetadataValueVariant4,
            global::System.Collections.Generic.IList<string>? knowledgeStoreMetadataValueVariant5
            )
        {
            KnowledgeStoreMetadataValueVariant1 = knowledgeStoreMetadataValueVariant1;
            KnowledgeStoreMetadataValueVariant2 = knowledgeStoreMetadataValueVariant2;
            KnowledgeStoreMetadataValueVariant3 = knowledgeStoreMetadataValueVariant3;
            KnowledgeStoreMetadataValueVariant4 = knowledgeStoreMetadataValueVariant4;
            KnowledgeStoreMetadataValueVariant5 = knowledgeStoreMetadataValueVariant5;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            KnowledgeStoreMetadataValueVariant5 as object ??
            KnowledgeStoreMetadataValueVariant4 as object ??
            KnowledgeStoreMetadataValueVariant3 as object ??
            KnowledgeStoreMetadataValueVariant2 as object ??
            KnowledgeStoreMetadataValueVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            KnowledgeStoreMetadataValueVariant1?.ToString() ??
            KnowledgeStoreMetadataValueVariant2?.ToString() ??
            KnowledgeStoreMetadataValueVariant3?.ToString() ??
            KnowledgeStoreMetadataValueVariant4?.ToString().ToLowerInvariant() ??
            KnowledgeStoreMetadataValueVariant5?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsKnowledgeStoreMetadataValueVariant1 && !IsKnowledgeStoreMetadataValueVariant2 && !IsKnowledgeStoreMetadataValueVariant3 && !IsKnowledgeStoreMetadataValueVariant4 && !IsKnowledgeStoreMetadataValueVariant5 || !IsKnowledgeStoreMetadataValueVariant1 && IsKnowledgeStoreMetadataValueVariant2 && !IsKnowledgeStoreMetadataValueVariant3 && !IsKnowledgeStoreMetadataValueVariant4 && !IsKnowledgeStoreMetadataValueVariant5 || !IsKnowledgeStoreMetadataValueVariant1 && !IsKnowledgeStoreMetadataValueVariant2 && IsKnowledgeStoreMetadataValueVariant3 && !IsKnowledgeStoreMetadataValueVariant4 && !IsKnowledgeStoreMetadataValueVariant5 || !IsKnowledgeStoreMetadataValueVariant1 && !IsKnowledgeStoreMetadataValueVariant2 && !IsKnowledgeStoreMetadataValueVariant3 && IsKnowledgeStoreMetadataValueVariant4 && !IsKnowledgeStoreMetadataValueVariant5 || !IsKnowledgeStoreMetadataValueVariant1 && !IsKnowledgeStoreMetadataValueVariant2 && !IsKnowledgeStoreMetadataValueVariant3 && !IsKnowledgeStoreMetadataValueVariant4 && IsKnowledgeStoreMetadataValueVariant5;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string, TResult>? knowledgeStoreMetadataValueVariant1 = null,
            global::System.Func<int?, TResult>? knowledgeStoreMetadataValueVariant2 = null,
            global::System.Func<double?, TResult>? knowledgeStoreMetadataValueVariant3 = null,
            global::System.Func<bool?, TResult>? knowledgeStoreMetadataValueVariant4 = null,
            global::System.Func<global::System.Collections.Generic.IList<string>, TResult>? knowledgeStoreMetadataValueVariant5 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsKnowledgeStoreMetadataValueVariant1 && knowledgeStoreMetadataValueVariant1 != null)
            {
                return knowledgeStoreMetadataValueVariant1(KnowledgeStoreMetadataValueVariant1!);
            }
            else if (IsKnowledgeStoreMetadataValueVariant2 && knowledgeStoreMetadataValueVariant2 != null)
            {
                return knowledgeStoreMetadataValueVariant2(KnowledgeStoreMetadataValueVariant2!);
            }
            else if (IsKnowledgeStoreMetadataValueVariant3 && knowledgeStoreMetadataValueVariant3 != null)
            {
                return knowledgeStoreMetadataValueVariant3(KnowledgeStoreMetadataValueVariant3!);
            }
            else if (IsKnowledgeStoreMetadataValueVariant4 && knowledgeStoreMetadataValueVariant4 != null)
            {
                return knowledgeStoreMetadataValueVariant4(KnowledgeStoreMetadataValueVariant4!);
            }
            else if (IsKnowledgeStoreMetadataValueVariant5 && knowledgeStoreMetadataValueVariant5 != null)
            {
                return knowledgeStoreMetadataValueVariant5(KnowledgeStoreMetadataValueVariant5!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<string>? knowledgeStoreMetadataValueVariant1 = null,

            global::System.Action<int?>? knowledgeStoreMetadataValueVariant2 = null,

            global::System.Action<double?>? knowledgeStoreMetadataValueVariant3 = null,

            global::System.Action<bool?>? knowledgeStoreMetadataValueVariant4 = null,

            global::System.Action<global::System.Collections.Generic.IList<string>>? knowledgeStoreMetadataValueVariant5 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsKnowledgeStoreMetadataValueVariant1)
            {
                knowledgeStoreMetadataValueVariant1?.Invoke(KnowledgeStoreMetadataValueVariant1!);
            }
            else if (IsKnowledgeStoreMetadataValueVariant2)
            {
                knowledgeStoreMetadataValueVariant2?.Invoke(KnowledgeStoreMetadataValueVariant2!);
            }
            else if (IsKnowledgeStoreMetadataValueVariant3)
            {
                knowledgeStoreMetadataValueVariant3?.Invoke(KnowledgeStoreMetadataValueVariant3!);
            }
            else if (IsKnowledgeStoreMetadataValueVariant4)
            {
                knowledgeStoreMetadataValueVariant4?.Invoke(KnowledgeStoreMetadataValueVariant4!);
            }
            else if (IsKnowledgeStoreMetadataValueVariant5)
            {
                knowledgeStoreMetadataValueVariant5?.Invoke(KnowledgeStoreMetadataValueVariant5!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<string>? knowledgeStoreMetadataValueVariant1 = null,
            global::System.Action<int?>? knowledgeStoreMetadataValueVariant2 = null,
            global::System.Action<double?>? knowledgeStoreMetadataValueVariant3 = null,
            global::System.Action<bool?>? knowledgeStoreMetadataValueVariant4 = null,
            global::System.Action<global::System.Collections.Generic.IList<string>>? knowledgeStoreMetadataValueVariant5 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsKnowledgeStoreMetadataValueVariant1)
            {
                knowledgeStoreMetadataValueVariant1?.Invoke(KnowledgeStoreMetadataValueVariant1!);
            }
            else if (IsKnowledgeStoreMetadataValueVariant2)
            {
                knowledgeStoreMetadataValueVariant2?.Invoke(KnowledgeStoreMetadataValueVariant2!);
            }
            else if (IsKnowledgeStoreMetadataValueVariant3)
            {
                knowledgeStoreMetadataValueVariant3?.Invoke(KnowledgeStoreMetadataValueVariant3!);
            }
            else if (IsKnowledgeStoreMetadataValueVariant4)
            {
                knowledgeStoreMetadataValueVariant4?.Invoke(KnowledgeStoreMetadataValueVariant4!);
            }
            else if (IsKnowledgeStoreMetadataValueVariant5)
            {
                knowledgeStoreMetadataValueVariant5?.Invoke(KnowledgeStoreMetadataValueVariant5!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                KnowledgeStoreMetadataValueVariant1,
                typeof(string),
                KnowledgeStoreMetadataValueVariant2,
                typeof(int),
                KnowledgeStoreMetadataValueVariant3,
                typeof(double),
                KnowledgeStoreMetadataValueVariant4,
                typeof(bool),
                KnowledgeStoreMetadataValueVariant5,
                typeof(global::System.Collections.Generic.IList<string>),
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
        public bool Equals(KnowledgeStoreMetadataValue other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(KnowledgeStoreMetadataValueVariant1, other.KnowledgeStoreMetadataValueVariant1) &&
                global::System.Collections.Generic.EqualityComparer<int?>.Default.Equals(KnowledgeStoreMetadataValueVariant2, other.KnowledgeStoreMetadataValueVariant2) &&
                global::System.Collections.Generic.EqualityComparer<double?>.Default.Equals(KnowledgeStoreMetadataValueVariant3, other.KnowledgeStoreMetadataValueVariant3) &&
                global::System.Collections.Generic.EqualityComparer<bool?>.Default.Equals(KnowledgeStoreMetadataValueVariant4, other.KnowledgeStoreMetadataValueVariant4) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<string>?>.Default.Equals(KnowledgeStoreMetadataValueVariant5, other.KnowledgeStoreMetadataValueVariant5)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(KnowledgeStoreMetadataValue obj1, KnowledgeStoreMetadataValue obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<KnowledgeStoreMetadataValue>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(KnowledgeStoreMetadataValue obj1, KnowledgeStoreMetadataValue obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is KnowledgeStoreMetadataValue o && Equals(o);
        }
    }
}
