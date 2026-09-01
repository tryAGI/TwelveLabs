#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Specifies how the platform divides the audio into segments.<br/>
    /// The structure of this object depends on the model version:<br/>
    /// - **With Marengo 3.5**: Place your settings in the `temporal` object. Both strategies are available: `dynamic` divides the audio into variable-length segments that follow scene changes, and `fixed` divides it into equal-length segments. Default: `temporal.dynamic`, `min_duration_sec: 2`.<br/>
    /// - **With Marengo 3.0**: Provide the settings directly in this object. Only `fixed` segmentation is available. Default: `fixed`, `duration_sec: 6`.<br/>
    /// Using a structure that does not match your model version returns a `400` error.
    /// </summary>
    public readonly partial struct AsyncAudioInputRequestSegmentation : global::System.IEquatable<AsyncAudioInputRequestSegmentation>
    {
        /// <summary>
        /// Specifies how the platform divides the audio into segments.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::TwelveLabs.AudioSegmentation? AudioSegmentation { get; init; }
#else
        public global::TwelveLabs.AudioSegmentation? AudioSegmentation { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AudioSegmentation))]
#endif
        public bool IsAudioSegmentation => AudioSegmentation != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAudioSegmentation(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::TwelveLabs.AudioSegmentation? value)
        {
            value = AudioSegmentation;
            return IsAudioSegmentation;
        }

        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AudioSegmentation PickAudioSegmentation() => IsAudioSegmentation
            ? AudioSegmentation!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AudioSegmentation' but the value was {ToString()}.");

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
        public static implicit operator AsyncAudioInputRequestSegmentation(global::TwelveLabs.AudioSegmentation value) => new AsyncAudioInputRequestSegmentation((global::TwelveLabs.AudioSegmentation?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::TwelveLabs.AudioSegmentation?(AsyncAudioInputRequestSegmentation @this) => @this.AudioSegmentation;

        /// <summary>
        ///
        /// </summary>
        public AsyncAudioInputRequestSegmentation(global::TwelveLabs.AudioSegmentation? value)
        {
            AudioSegmentation = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AsyncAudioInputRequestSegmentation FromAudioSegmentation(global::TwelveLabs.AudioSegmentation? value) => new AsyncAudioInputRequestSegmentation(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AsyncAudioInputRequestSegmentation(global::TwelveLabs.AsyncTemporalSegmentation value) => new AsyncAudioInputRequestSegmentation((global::TwelveLabs.AsyncTemporalSegmentation?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::TwelveLabs.AsyncTemporalSegmentation?(AsyncAudioInputRequestSegmentation @this) => @this.AsyncTemporalSegmentation;

        /// <summary>
        ///
        /// </summary>
        public AsyncAudioInputRequestSegmentation(global::TwelveLabs.AsyncTemporalSegmentation? value)
        {
            AsyncTemporalSegmentation = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AsyncAudioInputRequestSegmentation FromAsyncTemporalSegmentation(global::TwelveLabs.AsyncTemporalSegmentation? value) => new AsyncAudioInputRequestSegmentation(value);

        /// <summary>
        ///
        /// </summary>
        public AsyncAudioInputRequestSegmentation(
            global::TwelveLabs.AudioSegmentation? audioSegmentation,
            global::TwelveLabs.AsyncTemporalSegmentation? asyncTemporalSegmentation
            )
        {
            AudioSegmentation = audioSegmentation;
            AsyncTemporalSegmentation = asyncTemporalSegmentation;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            AsyncTemporalSegmentation as object ??
            AudioSegmentation as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            AudioSegmentation?.ToString() ??
            AsyncTemporalSegmentation?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsAudioSegmentation && !IsAsyncTemporalSegmentation || !IsAudioSegmentation && IsAsyncTemporalSegmentation;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::TwelveLabs.AudioSegmentation, TResult>? audioSegmentation = null,
            global::System.Func<global::TwelveLabs.AsyncTemporalSegmentation, TResult>? asyncTemporalSegmentation = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAudioSegmentation && audioSegmentation != null)
            {
                return audioSegmentation(AudioSegmentation!);
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
            global::System.Action<global::TwelveLabs.AudioSegmentation>? audioSegmentation = null,

            global::System.Action<global::TwelveLabs.AsyncTemporalSegmentation>? asyncTemporalSegmentation = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAudioSegmentation)
            {
                audioSegmentation?.Invoke(AudioSegmentation!);
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
            global::System.Action<global::TwelveLabs.AudioSegmentation>? audioSegmentation = null,
            global::System.Action<global::TwelveLabs.AsyncTemporalSegmentation>? asyncTemporalSegmentation = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAudioSegmentation)
            {
                audioSegmentation?.Invoke(AudioSegmentation!);
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
                AudioSegmentation,
                typeof(global::TwelveLabs.AudioSegmentation),
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
        public bool Equals(AsyncAudioInputRequestSegmentation other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::TwelveLabs.AudioSegmentation?>.Default.Equals(AudioSegmentation, other.AudioSegmentation) &&
                global::System.Collections.Generic.EqualityComparer<global::TwelveLabs.AsyncTemporalSegmentation?>.Default.Equals(AsyncTemporalSegmentation, other.AsyncTemporalSegmentation)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AsyncAudioInputRequestSegmentation obj1, AsyncAudioInputRequestSegmentation obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AsyncAudioInputRequestSegmentation>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AsyncAudioInputRequestSegmentation obj1, AsyncAudioInputRequestSegmentation obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AsyncAudioInputRequestSegmentation o && Equals(o);
        }
    }
}
