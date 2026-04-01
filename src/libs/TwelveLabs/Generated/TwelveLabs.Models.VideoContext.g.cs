#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// An object specifying the source of the video content. Include exactly one source.
    /// </summary>
    public readonly partial struct VideoContext : global::System.IEquatable<VideoContext>
    {
        /// <summary>
        /// Provide the video via a URL.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::TwelveLabs.VideoContext0? VideoContext0 { get; init; }
#else
        public global::TwelveLabs.VideoContext0? VideoContext0 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VideoContext0))]
#endif
        public bool IsVideoContext0 => VideoContext0 != null;

        /// <summary>
        /// Provide the video via a unique identifier of an asset.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::TwelveLabs.VideoContext1? VideoContext1 { get; init; }
#else
        public global::TwelveLabs.VideoContext1? VideoContext1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VideoContext1))]
#endif
        public bool IsVideoContext1 => VideoContext1 != null;

        /// <summary>
        /// Provide the video via base64-encoded data.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::TwelveLabs.VideoContext2? VideoContext2 { get; init; }
#else
        public global::TwelveLabs.VideoContext2? VideoContext2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VideoContext2))]
#endif
        public bool IsVideoContext2 => VideoContext2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VideoContext(global::TwelveLabs.VideoContext0 value) => new VideoContext((global::TwelveLabs.VideoContext0?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::TwelveLabs.VideoContext0?(VideoContext @this) => @this.VideoContext0;

        /// <summary>
        /// 
        /// </summary>
        public VideoContext(global::TwelveLabs.VideoContext0? value)
        {
            VideoContext0 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VideoContext(global::TwelveLabs.VideoContext1 value) => new VideoContext((global::TwelveLabs.VideoContext1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::TwelveLabs.VideoContext1?(VideoContext @this) => @this.VideoContext1;

        /// <summary>
        /// 
        /// </summary>
        public VideoContext(global::TwelveLabs.VideoContext1? value)
        {
            VideoContext1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VideoContext(global::TwelveLabs.VideoContext2 value) => new VideoContext((global::TwelveLabs.VideoContext2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::TwelveLabs.VideoContext2?(VideoContext @this) => @this.VideoContext2;

        /// <summary>
        /// 
        /// </summary>
        public VideoContext(global::TwelveLabs.VideoContext2? value)
        {
            VideoContext2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public VideoContext(
            global::TwelveLabs.VideoContext0? videoContext0,
            global::TwelveLabs.VideoContext1? videoContext1,
            global::TwelveLabs.VideoContext2? videoContext2
            )
        {
            VideoContext0 = videoContext0;
            VideoContext1 = videoContext1;
            VideoContext2 = videoContext2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            VideoContext2 as object ??
            VideoContext1 as object ??
            VideoContext0 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            VideoContext0?.ToString() ??
            VideoContext1?.ToString() ??
            VideoContext2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsVideoContext0 && !IsVideoContext1 && !IsVideoContext2 || !IsVideoContext0 && IsVideoContext1 && !IsVideoContext2 || !IsVideoContext0 && !IsVideoContext1 && IsVideoContext2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::TwelveLabs.VideoContext0?, TResult>? videoContext0 = null,
            global::System.Func<global::TwelveLabs.VideoContext1?, TResult>? videoContext1 = null,
            global::System.Func<global::TwelveLabs.VideoContext2?, TResult>? videoContext2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsVideoContext0 && videoContext0 != null)
            {
                return videoContext0(VideoContext0!);
            }
            else if (IsVideoContext1 && videoContext1 != null)
            {
                return videoContext1(VideoContext1!);
            }
            else if (IsVideoContext2 && videoContext2 != null)
            {
                return videoContext2(VideoContext2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::TwelveLabs.VideoContext0?>? videoContext0 = null,
            global::System.Action<global::TwelveLabs.VideoContext1?>? videoContext1 = null,
            global::System.Action<global::TwelveLabs.VideoContext2?>? videoContext2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsVideoContext0)
            {
                videoContext0?.Invoke(VideoContext0!);
            }
            else if (IsVideoContext1)
            {
                videoContext1?.Invoke(VideoContext1!);
            }
            else if (IsVideoContext2)
            {
                videoContext2?.Invoke(VideoContext2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                VideoContext0,
                typeof(global::TwelveLabs.VideoContext0),
                VideoContext1,
                typeof(global::TwelveLabs.VideoContext1),
                VideoContext2,
                typeof(global::TwelveLabs.VideoContext2),
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
        public bool Equals(VideoContext other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::TwelveLabs.VideoContext0?>.Default.Equals(VideoContext0, other.VideoContext0) &&
                global::System.Collections.Generic.EqualityComparer<global::TwelveLabs.VideoContext1?>.Default.Equals(VideoContext1, other.VideoContext1) &&
                global::System.Collections.Generic.EqualityComparer<global::TwelveLabs.VideoContext2?>.Default.Equals(VideoContext2, other.VideoContext2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(VideoContext obj1, VideoContext obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<VideoContext>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(VideoContext obj1, VideoContext obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is VideoContext o && Equals(o);
        }
    }
}
