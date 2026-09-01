#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Specifies how the platform divides the video into segments.<br/>
    /// The structure of this object depends on the model version:<br/>
    /// - **With Marengo 3.5**: Place your settings in the `temporal` object. Both strategies are available: `dynamic` divides the video into variable-length segments that follow scene changes, and `fixed` divides it into equal-length segments. Default: `temporal.dynamic`, `min_duration_sec: 2`.<br/>
    /// - **With Marengo 3.0**: Provide the settings directly in this object. Default: `dynamic`, `min_duration_sec: 4`.<br/>
    /// Using a structure that does not match your model version returns a `400` error.
    /// </summary>
    public readonly partial struct AsyncVideoInputRequestSegmentation : global::System.IEquatable<AsyncVideoInputRequestSegmentation>
    {
        /// <summary>
        /// Specifies how the platform divides the video into segments. The `strategy` field selects one variant:<br/>
        /// - `strategy: fixed` - Creates segments of equal, predetermined length. Use this for consistent timing.<br/>
        /// - `strategy: dynamic` - Creates segments of variable length that align with scene boundaries. Use this for content-aware segmentation.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::TwelveLabs.VideoSegmentation? VideoSegmentation { get; init; }
#else
        public global::TwelveLabs.VideoSegmentation? VideoSegmentation { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VideoSegmentation))]
#endif
        public bool IsVideoSegmentation => VideoSegmentation != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickVideoSegmentation(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::TwelveLabs.VideoSegmentation? value)
        {
            value = VideoSegmentation;
            return IsVideoSegmentation;
        }

        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoSegmentation PickVideoSegmentation() => IsVideoSegmentation
            ? VideoSegmentation!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'VideoSegmentation' but the value was {ToString()}.");

        /// <summary>
        /// Wraps your settings in a `temporal` object. Use with Marengo 3.5.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::TwelveLabs.AsyncTemporalSegmentation? AsyncTemporalSegmentation { get; init; }
#else
        public global::TwelveLabs.AsyncTemporalSegmentation? AsyncTemporalSegmentation { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AsyncTemporalSegmentation))]
#endif
        public bool IsAsyncTemporalSegmentation => AsyncTemporalSegmentation != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAsyncTemporalSegmentation(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::TwelveLabs.AsyncTemporalSegmentation? value)
        {
            value = AsyncTemporalSegmentation;
            return IsAsyncTemporalSegmentation;
        }

        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncTemporalSegmentation PickAsyncTemporalSegmentation() => IsAsyncTemporalSegmentation
            ? AsyncTemporalSegmentation!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AsyncTemporalSegmentation' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AsyncVideoInputRequestSegmentation(global::TwelveLabs.VideoSegmentation value) => new AsyncVideoInputRequestSegmentation((global::TwelveLabs.VideoSegmentation?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::TwelveLabs.VideoSegmentation?(AsyncVideoInputRequestSegmentation @this) => @this.VideoSegmentation;

        /// <summary>
        ///
        /// </summary>
        public AsyncVideoInputRequestSegmentation(global::TwelveLabs.VideoSegmentation? value)
        {
            VideoSegmentation = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AsyncVideoInputRequestSegmentation FromVideoSegmentation(global::TwelveLabs.VideoSegmentation? value) => new AsyncVideoInputRequestSegmentation(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AsyncVideoInputRequestSegmentation(global::TwelveLabs.AsyncTemporalSegmentation value) => new AsyncVideoInputRequestSegmentation((global::TwelveLabs.AsyncTemporalSegmentation?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::TwelveLabs.AsyncTemporalSegmentation?(AsyncVideoInputRequestSegmentation @this) => @this.AsyncTemporalSegmentation;

        /// <summary>
        ///
        /// </summary>
        public AsyncVideoInputRequestSegmentation(global::TwelveLabs.AsyncTemporalSegmentation? value)
        {
            AsyncTemporalSegmentation = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AsyncVideoInputRequestSegmentation FromAsyncTemporalSegmentation(global::TwelveLabs.AsyncTemporalSegmentation? value) => new AsyncVideoInputRequestSegmentation(value);

        /// <summary>
        ///
        /// </summary>
        public AsyncVideoInputRequestSegmentation(
            global::TwelveLabs.VideoSegmentation? videoSegmentation,
            global::TwelveLabs.AsyncTemporalSegmentation? asyncTemporalSegmentation
            )
        {
            VideoSegmentation = videoSegmentation;
            AsyncTemporalSegmentation = asyncTemporalSegmentation;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            AsyncTemporalSegmentation as object ??
            VideoSegmentation as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            VideoSegmentation?.ToString() ??
            AsyncTemporalSegmentation?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsVideoSegmentation && !IsAsyncTemporalSegmentation || !IsVideoSegmentation && IsAsyncTemporalSegmentation;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::TwelveLabs.VideoSegmentation?, TResult>? videoSegmentation = null,
            global::System.Func<global::TwelveLabs.AsyncTemporalSegmentation, TResult>? asyncTemporalSegmentation = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsVideoSegmentation && videoSegmentation != null)
            {
                return videoSegmentation(VideoSegmentation!);
            }
            else if (IsAsyncTemporalSegmentation && asyncTemporalSegmentation != null)
            {
                return asyncTemporalSegmentation(AsyncTemporalSegmentation!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::TwelveLabs.VideoSegmentation?>? videoSegmentation = null,

            global::System.Action<global::TwelveLabs.AsyncTemporalSegmentation>? asyncTemporalSegmentation = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsVideoSegmentation)
            {
                videoSegmentation?.Invoke(VideoSegmentation!);
            }
            else if (IsAsyncTemporalSegmentation)
            {
                asyncTemporalSegmentation?.Invoke(AsyncTemporalSegmentation!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::TwelveLabs.VideoSegmentation?>? videoSegmentation = null,
            global::System.Action<global::TwelveLabs.AsyncTemporalSegmentation>? asyncTemporalSegmentation = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsVideoSegmentation)
            {
                videoSegmentation?.Invoke(VideoSegmentation!);
            }
            else if (IsAsyncTemporalSegmentation)
            {
                asyncTemporalSegmentation?.Invoke(AsyncTemporalSegmentation!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                VideoSegmentation,
                typeof(global::TwelveLabs.VideoSegmentation),
                AsyncTemporalSegmentation,
                typeof(global::TwelveLabs.AsyncTemporalSegmentation),
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
        public bool Equals(AsyncVideoInputRequestSegmentation other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::TwelveLabs.VideoSegmentation?>.Default.Equals(VideoSegmentation, other.VideoSegmentation) &&
                global::System.Collections.Generic.EqualityComparer<global::TwelveLabs.AsyncTemporalSegmentation?>.Default.Equals(AsyncTemporalSegmentation, other.AsyncTemporalSegmentation)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AsyncVideoInputRequestSegmentation obj1, AsyncVideoInputRequestSegmentation obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AsyncVideoInputRequestSegmentation>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AsyncVideoInputRequestSegmentation obj1, AsyncVideoInputRequestSegmentation obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AsyncVideoInputRequestSegmentation o && Equals(o);
        }
    }
}
