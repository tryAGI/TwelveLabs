#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// A numeric scalar or an RFC 3339 timestamp with a timezone.
    /// </summary>
    public readonly partial struct MetadataRangeBound : global::System.IEquatable<MetadataRangeBound>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public int? MetadataRangeBoundVariant1 { get; init; }
#else
        public int? MetadataRangeBoundVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MetadataRangeBoundVariant1))]
#endif
        public bool IsMetadataRangeBoundVariant1 => MetadataRangeBoundVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickMetadataRangeBoundVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out int? value)
        {
            value = MetadataRangeBoundVariant1;
            return IsMetadataRangeBoundVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public int PickMetadataRangeBoundVariant1() => MetadataRangeBoundVariant1 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'MetadataRangeBoundVariant1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public double? MetadataRangeBoundVariant2 { get; init; }
#else
        public double? MetadataRangeBoundVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MetadataRangeBoundVariant2))]
#endif
        public bool IsMetadataRangeBoundVariant2 => MetadataRangeBoundVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickMetadataRangeBoundVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out double? value)
        {
            value = MetadataRangeBoundVariant2;
            return IsMetadataRangeBoundVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public double PickMetadataRangeBoundVariant2() => MetadataRangeBoundVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'MetadataRangeBoundVariant2' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.DateTime? DateTime { get; init; }
#else
        public global::System.DateTime? DateTime { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DateTime))]
#endif
        public bool IsDateTime => DateTime != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickDateTime(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.DateTime? value)
        {
            value = DateTime;
            return IsDateTime;
        }

        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime PickDateTime() => DateTime is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'DateTime' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator MetadataRangeBound(int value) => new MetadataRangeBound((int?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator int?(MetadataRangeBound @this) => @this.MetadataRangeBoundVariant1;

        /// <summary>
        ///
        /// </summary>
        public MetadataRangeBound(int? value)
        {
            MetadataRangeBoundVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static MetadataRangeBound FromMetadataRangeBoundVariant1(int? value) => new MetadataRangeBound(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator MetadataRangeBound(double value) => new MetadataRangeBound((double?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator double?(MetadataRangeBound @this) => @this.MetadataRangeBoundVariant2;

        /// <summary>
        ///
        /// </summary>
        public MetadataRangeBound(double? value)
        {
            MetadataRangeBoundVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static MetadataRangeBound FromMetadataRangeBoundVariant2(double? value) => new MetadataRangeBound(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator MetadataRangeBound(global::System.DateTime value) => new MetadataRangeBound((global::System.DateTime?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::System.DateTime?(MetadataRangeBound @this) => @this.DateTime;

        /// <summary>
        ///
        /// </summary>
        public MetadataRangeBound(global::System.DateTime? value)
        {
            DateTime = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static MetadataRangeBound FromDateTime(global::System.DateTime? value) => new MetadataRangeBound(value);

        /// <summary>
        ///
        /// </summary>
        public MetadataRangeBound(
            int? metadataRangeBoundVariant1,
            double? metadataRangeBoundVariant2,
            global::System.DateTime? dateTime
            )
        {
            MetadataRangeBoundVariant1 = metadataRangeBoundVariant1;
            MetadataRangeBoundVariant2 = metadataRangeBoundVariant2;
            DateTime = dateTime;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            DateTime as object ??
            MetadataRangeBoundVariant2 as object ??
            MetadataRangeBoundVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            MetadataRangeBoundVariant1?.ToString() ??
            MetadataRangeBoundVariant2?.ToString() ??
            DateTime?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsMetadataRangeBoundVariant1 && !IsMetadataRangeBoundVariant2 && !IsDateTime || !IsMetadataRangeBoundVariant1 && IsMetadataRangeBoundVariant2 && !IsDateTime || !IsMetadataRangeBoundVariant1 && !IsMetadataRangeBoundVariant2 && IsDateTime;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<int?, TResult>? metadataRangeBoundVariant1 = null,
            global::System.Func<double?, TResult>? metadataRangeBoundVariant2 = null,
            global::System.Func<global::System.DateTime?, TResult>? dateTime = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (MetadataRangeBoundVariant1 is { } __value0 && metadataRangeBoundVariant1 != null)
            {
                return metadataRangeBoundVariant1(__value0);
            }
            else if (MetadataRangeBoundVariant2 is { } __value1 && metadataRangeBoundVariant2 != null)
            {
                return metadataRangeBoundVariant2(__value1);
            }
            else if (DateTime is { } __value2 && dateTime != null)
            {
                return dateTime(__value2);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<int?>? metadataRangeBoundVariant1 = null,

            global::System.Action<double?>? metadataRangeBoundVariant2 = null,

            global::System.Action<global::System.DateTime?>? dateTime = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (MetadataRangeBoundVariant1 is { } __value0)
            {
                metadataRangeBoundVariant1?.Invoke(__value0);
            }
            else if (MetadataRangeBoundVariant2 is { } __value1)
            {
                metadataRangeBoundVariant2?.Invoke(__value1);
            }
            else if (DateTime is { } __value2)
            {
                dateTime?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<int?>? metadataRangeBoundVariant1 = null,
            global::System.Action<double?>? metadataRangeBoundVariant2 = null,
            global::System.Action<global::System.DateTime?>? dateTime = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (MetadataRangeBoundVariant1 is { } __value0)
            {
                metadataRangeBoundVariant1?.Invoke(__value0);
            }
            else if (MetadataRangeBoundVariant2 is { } __value1)
            {
                metadataRangeBoundVariant2?.Invoke(__value1);
            }
            else if (DateTime is { } __value2)
            {
                dateTime?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                MetadataRangeBoundVariant1,
                typeof(int),
                MetadataRangeBoundVariant2,
                typeof(double),
                DateTime,
                typeof(global::System.DateTime),
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
        public bool Equals(MetadataRangeBound other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<int?>.Default.Equals(MetadataRangeBoundVariant1, other.MetadataRangeBoundVariant1) &&
                global::System.Collections.Generic.EqualityComparer<double?>.Default.Equals(MetadataRangeBoundVariant2, other.MetadataRangeBoundVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::System.DateTime?>.Default.Equals(DateTime, other.DateTime)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(MetadataRangeBound obj1, MetadataRangeBound obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<MetadataRangeBound>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(MetadataRangeBound obj1, MetadataRangeBound obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is MetadataRangeBound o && Equals(o);
        }
    }
}
