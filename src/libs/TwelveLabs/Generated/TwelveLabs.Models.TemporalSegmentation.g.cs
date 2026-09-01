#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Specifies how the platform divides the file into segments. The `strategy` field selects one variant:<br/>
    /// - `dynamic`: Creates variable-length segments that align with scene or content boundaries. Use this for content-aware segmentation.<br/>
    /// - `fixed`: Creates equal-length segments. Use this for consistent timing.
    /// </summary>
    public readonly partial struct TemporalSegmentation : global::System.IEquatable<TemporalSegmentation>
    {
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TemporalSegmentationDiscriminatorStrategy? Strategy { get; }

        /// <summary>
        /// Divides the file into variable-length segments that align with scene or content boundaries. Use this for content-aware segmentation.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::TwelveLabs.TemporalSegmentationVariant1? Dynamic { get; init; }
#else
        public global::TwelveLabs.TemporalSegmentationVariant1? Dynamic { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Dynamic))]
#endif
        public bool IsDynamic => Dynamic != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickDynamic(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::TwelveLabs.TemporalSegmentationVariant1? value)
        {
            value = Dynamic;
            return IsDynamic;
        }

        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TemporalSegmentationVariant1 PickDynamic() => IsDynamic
            ? Dynamic!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Dynamic' but the value was {ToString()}.");

        /// <summary>
        /// Divides the file into equal-length segments. Use this for consistent timing.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::TwelveLabs.TemporalSegmentationVariant2? Fixed { get; init; }
#else
        public global::TwelveLabs.TemporalSegmentationVariant2? Fixed { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Fixed))]
#endif
        public bool IsFixed => Fixed != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickFixed(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::TwelveLabs.TemporalSegmentationVariant2? value)
        {
            value = Fixed;
            return IsFixed;
        }

        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TemporalSegmentationVariant2 PickFixed() => IsFixed
            ? Fixed!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Fixed' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator TemporalSegmentation(global::TwelveLabs.TemporalSegmentationVariant1 value) => new TemporalSegmentation((global::TwelveLabs.TemporalSegmentationVariant1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::TwelveLabs.TemporalSegmentationVariant1?(TemporalSegmentation @this) => @this.Dynamic;

        /// <summary>
        ///
        /// </summary>
        public TemporalSegmentation(global::TwelveLabs.TemporalSegmentationVariant1? value)
        {
            Dynamic = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TemporalSegmentation FromDynamic(global::TwelveLabs.TemporalSegmentationVariant1? value) => new TemporalSegmentation(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator TemporalSegmentation(global::TwelveLabs.TemporalSegmentationVariant2 value) => new TemporalSegmentation((global::TwelveLabs.TemporalSegmentationVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::TwelveLabs.TemporalSegmentationVariant2?(TemporalSegmentation @this) => @this.Fixed;

        /// <summary>
        ///
        /// </summary>
        public TemporalSegmentation(global::TwelveLabs.TemporalSegmentationVariant2? value)
        {
            Fixed = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TemporalSegmentation FromFixed(global::TwelveLabs.TemporalSegmentationVariant2? value) => new TemporalSegmentation(value);

        /// <summary>
        ///
        /// </summary>
        public TemporalSegmentation(
            global::TwelveLabs.TemporalSegmentationDiscriminatorStrategy? strategy,
            global::TwelveLabs.TemporalSegmentationVariant1? dynamic,
            global::TwelveLabs.TemporalSegmentationVariant2? @fixed
            )
        {
            Strategy = strategy;

            Dynamic = dynamic;
            Fixed = @fixed;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Fixed as object ??
            Dynamic as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Dynamic?.ToString() ??
            Fixed?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsDynamic && !IsFixed || !IsDynamic && IsFixed;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::TwelveLabs.TemporalSegmentationVariant1, TResult>? dynamic = null,
            global::System.Func<global::TwelveLabs.TemporalSegmentationVariant2, TResult>? @fixed = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDynamic && dynamic != null)
            {
                return dynamic(Dynamic!);
            }
            else if (IsFixed && @fixed != null)
            {
                return @fixed(Fixed!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::TwelveLabs.TemporalSegmentationVariant1>? dynamic = null,

            global::System.Action<global::TwelveLabs.TemporalSegmentationVariant2>? @fixed = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDynamic)
            {
                dynamic?.Invoke(Dynamic!);
            }
            else if (IsFixed)
            {
                @fixed?.Invoke(Fixed!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::TwelveLabs.TemporalSegmentationVariant1>? dynamic = null,
            global::System.Action<global::TwelveLabs.TemporalSegmentationVariant2>? @fixed = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDynamic)
            {
                dynamic?.Invoke(Dynamic!);
            }
            else if (IsFixed)
            {
                @fixed?.Invoke(Fixed!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Dynamic,
                typeof(global::TwelveLabs.TemporalSegmentationVariant1),
                Fixed,
                typeof(global::TwelveLabs.TemporalSegmentationVariant2),
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
        public bool Equals(TemporalSegmentation other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::TwelveLabs.TemporalSegmentationVariant1?>.Default.Equals(Dynamic, other.Dynamic) &&
                global::System.Collections.Generic.EqualityComparer<global::TwelveLabs.TemporalSegmentationVariant2?>.Default.Equals(Fixed, other.Fixed)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(TemporalSegmentation obj1, TemporalSegmentation obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TemporalSegmentation>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(TemporalSegmentation obj1, TemporalSegmentation obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TemporalSegmentation o && Equals(o);
        }
    }
}
