#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Specifies how the platform divides the video into segments. The `strategy` field selects one variant:<br/>
    /// - `strategy: fixed` - Creates segments of equal, predetermined length. Use this for consistent timing.<br/>
    /// - `strategy: dynamic` - Creates segments of variable length that align with scene boundaries. Use this for content-aware segmentation.
    /// </summary>
    public readonly partial struct VideoSegmentation : global::System.IEquatable<VideoSegmentation>
    {
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoSegmentationDiscriminatorStrategy? Strategy { get; }

        /// <summary>
        /// Divides the video into segments of variable length that align with scene boundaries. Use this for content-aware segmentation.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::TwelveLabs.VideoSegmentationVariant1? Dynamic { get; init; }
#else
        public global::TwelveLabs.VideoSegmentationVariant1? Dynamic { get; }
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
            out global::TwelveLabs.VideoSegmentationVariant1? value)
        {
            value = Dynamic;
            return IsDynamic;
        }

        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoSegmentationVariant1 PickDynamic() => IsDynamic
            ? Dynamic!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Dynamic' but the value was {ToString()}.");

        /// <summary>
        /// Divides the video into segments of equal, predetermined length. Use this for consistent timing.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::TwelveLabs.VideoSegmentationVariant2? Fixed { get; init; }
#else
        public global::TwelveLabs.VideoSegmentationVariant2? Fixed { get; }
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
            out global::TwelveLabs.VideoSegmentationVariant2? value)
        {
            value = Fixed;
            return IsFixed;
        }

        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoSegmentationVariant2 PickFixed() => IsFixed
            ? Fixed!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Fixed' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator VideoSegmentation(global::TwelveLabs.VideoSegmentationVariant1 value) => new VideoSegmentation((global::TwelveLabs.VideoSegmentationVariant1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::TwelveLabs.VideoSegmentationVariant1?(VideoSegmentation @this) => @this.Dynamic;

        /// <summary>
        ///
        /// </summary>
        public VideoSegmentation(global::TwelveLabs.VideoSegmentationVariant1? value)
        {
            Dynamic = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static VideoSegmentation FromDynamic(global::TwelveLabs.VideoSegmentationVariant1? value) => new VideoSegmentation(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator VideoSegmentation(global::TwelveLabs.VideoSegmentationVariant2 value) => new VideoSegmentation((global::TwelveLabs.VideoSegmentationVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::TwelveLabs.VideoSegmentationVariant2?(VideoSegmentation @this) => @this.Fixed;

        /// <summary>
        ///
        /// </summary>
        public VideoSegmentation(global::TwelveLabs.VideoSegmentationVariant2? value)
        {
            Fixed = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static VideoSegmentation FromFixed(global::TwelveLabs.VideoSegmentationVariant2? value) => new VideoSegmentation(value);

        /// <summary>
        ///
        /// </summary>
        public VideoSegmentation(
            global::TwelveLabs.VideoSegmentationDiscriminatorStrategy? strategy,
            global::TwelveLabs.VideoSegmentationVariant1? dynamic,
            global::TwelveLabs.VideoSegmentationVariant2? @fixed
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
            global::System.Func<global::TwelveLabs.VideoSegmentationVariant1, TResult>? dynamic = null,
            global::System.Func<global::TwelveLabs.VideoSegmentationVariant2, TResult>? @fixed = null,
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
            global::System.Action<global::TwelveLabs.VideoSegmentationVariant1>? dynamic = null,

            global::System.Action<global::TwelveLabs.VideoSegmentationVariant2>? @fixed = null,
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
            global::System.Action<global::TwelveLabs.VideoSegmentationVariant1>? dynamic = null,
            global::System.Action<global::TwelveLabs.VideoSegmentationVariant2>? @fixed = null,
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
                typeof(global::TwelveLabs.VideoSegmentationVariant1),
                Fixed,
                typeof(global::TwelveLabs.VideoSegmentationVariant2),
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
        public bool Equals(VideoSegmentation other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::TwelveLabs.VideoSegmentationVariant1?>.Default.Equals(Dynamic, other.Dynamic) &&
                global::System.Collections.Generic.EqualityComparer<global::TwelveLabs.VideoSegmentationVariant2?>.Default.Equals(Fixed, other.Fixed)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(VideoSegmentation obj1, VideoSegmentation obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<VideoSegmentation>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(VideoSegmentation obj1, VideoSegmentation obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is VideoSegmentation o && Equals(o);
        }
    }
}
