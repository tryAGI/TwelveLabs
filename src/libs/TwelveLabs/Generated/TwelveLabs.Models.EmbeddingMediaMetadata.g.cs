#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Metadata for the media input. Available for image, text_image, audio, video, and multi_input inputs.
    /// </summary>
    public readonly partial struct EmbeddingMediaMetadata : global::System.IEquatable<EmbeddingMediaMetadata>
    {
        /// <summary>
        /// Metadata for image embeddings
        /// </summary>
#if NET6_0_OR_GREATER
        public global::TwelveLabs.EmbeddingImageMetadata? EmbeddingImageMetadata { get; init; }
#else
        public global::TwelveLabs.EmbeddingImageMetadata? EmbeddingImageMetadata { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EmbeddingImageMetadata))]
#endif
        public bool IsEmbeddingImageMetadata => EmbeddingImageMetadata != null;

        /// <summary>
        /// Metadata for text-image embeddings
        /// </summary>
#if NET6_0_OR_GREATER
        public global::TwelveLabs.EmbeddingTextImageMetadata? EmbeddingTextImageMetadata { get; init; }
#else
        public global::TwelveLabs.EmbeddingTextImageMetadata? EmbeddingTextImageMetadata { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EmbeddingTextImageMetadata))]
#endif
        public bool IsEmbeddingTextImageMetadata => EmbeddingTextImageMetadata != null;

        /// <summary>
        /// Metadata for audio embeddings
        /// </summary>
#if NET6_0_OR_GREATER
        public global::TwelveLabs.EmbeddingAudioMetadata? EmbeddingAudioMetadata { get; init; }
#else
        public global::TwelveLabs.EmbeddingAudioMetadata? EmbeddingAudioMetadata { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EmbeddingAudioMetadata))]
#endif
        public bool IsEmbeddingAudioMetadata => EmbeddingAudioMetadata != null;

        /// <summary>
        /// Metadata for video embeddings
        /// </summary>
#if NET6_0_OR_GREATER
        public global::TwelveLabs.EmbeddingVideoMetadata? EmbeddingVideoMetadata { get; init; }
#else
        public global::TwelveLabs.EmbeddingVideoMetadata? EmbeddingVideoMetadata { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EmbeddingVideoMetadata))]
#endif
        public bool IsEmbeddingVideoMetadata => EmbeddingVideoMetadata != null;

        /// <summary>
        /// Metadata for multi-input embeddings
        /// </summary>
#if NET6_0_OR_GREATER
        public global::TwelveLabs.EmbeddingMultiInputMetadata? EmbeddingMultiInputMetadata { get; init; }
#else
        public global::TwelveLabs.EmbeddingMultiInputMetadata? EmbeddingMultiInputMetadata { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EmbeddingMultiInputMetadata))]
#endif
        public bool IsEmbeddingMultiInputMetadata => EmbeddingMultiInputMetadata != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EmbeddingMediaMetadata(global::TwelveLabs.EmbeddingImageMetadata value) => new EmbeddingMediaMetadata((global::TwelveLabs.EmbeddingImageMetadata?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::TwelveLabs.EmbeddingImageMetadata?(EmbeddingMediaMetadata @this) => @this.EmbeddingImageMetadata;

        /// <summary>
        /// 
        /// </summary>
        public EmbeddingMediaMetadata(global::TwelveLabs.EmbeddingImageMetadata? value)
        {
            EmbeddingImageMetadata = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EmbeddingMediaMetadata(global::TwelveLabs.EmbeddingTextImageMetadata value) => new EmbeddingMediaMetadata((global::TwelveLabs.EmbeddingTextImageMetadata?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::TwelveLabs.EmbeddingTextImageMetadata?(EmbeddingMediaMetadata @this) => @this.EmbeddingTextImageMetadata;

        /// <summary>
        /// 
        /// </summary>
        public EmbeddingMediaMetadata(global::TwelveLabs.EmbeddingTextImageMetadata? value)
        {
            EmbeddingTextImageMetadata = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EmbeddingMediaMetadata(global::TwelveLabs.EmbeddingAudioMetadata value) => new EmbeddingMediaMetadata((global::TwelveLabs.EmbeddingAudioMetadata?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::TwelveLabs.EmbeddingAudioMetadata?(EmbeddingMediaMetadata @this) => @this.EmbeddingAudioMetadata;

        /// <summary>
        /// 
        /// </summary>
        public EmbeddingMediaMetadata(global::TwelveLabs.EmbeddingAudioMetadata? value)
        {
            EmbeddingAudioMetadata = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EmbeddingMediaMetadata(global::TwelveLabs.EmbeddingVideoMetadata value) => new EmbeddingMediaMetadata((global::TwelveLabs.EmbeddingVideoMetadata?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::TwelveLabs.EmbeddingVideoMetadata?(EmbeddingMediaMetadata @this) => @this.EmbeddingVideoMetadata;

        /// <summary>
        /// 
        /// </summary>
        public EmbeddingMediaMetadata(global::TwelveLabs.EmbeddingVideoMetadata? value)
        {
            EmbeddingVideoMetadata = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EmbeddingMediaMetadata(global::TwelveLabs.EmbeddingMultiInputMetadata value) => new EmbeddingMediaMetadata((global::TwelveLabs.EmbeddingMultiInputMetadata?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::TwelveLabs.EmbeddingMultiInputMetadata?(EmbeddingMediaMetadata @this) => @this.EmbeddingMultiInputMetadata;

        /// <summary>
        /// 
        /// </summary>
        public EmbeddingMediaMetadata(global::TwelveLabs.EmbeddingMultiInputMetadata? value)
        {
            EmbeddingMultiInputMetadata = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public EmbeddingMediaMetadata(
            global::TwelveLabs.EmbeddingImageMetadata? embeddingImageMetadata,
            global::TwelveLabs.EmbeddingTextImageMetadata? embeddingTextImageMetadata,
            global::TwelveLabs.EmbeddingAudioMetadata? embeddingAudioMetadata,
            global::TwelveLabs.EmbeddingVideoMetadata? embeddingVideoMetadata,
            global::TwelveLabs.EmbeddingMultiInputMetadata? embeddingMultiInputMetadata
            )
        {
            EmbeddingImageMetadata = embeddingImageMetadata;
            EmbeddingTextImageMetadata = embeddingTextImageMetadata;
            EmbeddingAudioMetadata = embeddingAudioMetadata;
            EmbeddingVideoMetadata = embeddingVideoMetadata;
            EmbeddingMultiInputMetadata = embeddingMultiInputMetadata;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            EmbeddingMultiInputMetadata as object ??
            EmbeddingVideoMetadata as object ??
            EmbeddingAudioMetadata as object ??
            EmbeddingTextImageMetadata as object ??
            EmbeddingImageMetadata as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            EmbeddingImageMetadata?.ToString() ??
            EmbeddingTextImageMetadata?.ToString() ??
            EmbeddingAudioMetadata?.ToString() ??
            EmbeddingVideoMetadata?.ToString() ??
            EmbeddingMultiInputMetadata?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsEmbeddingImageMetadata && !IsEmbeddingTextImageMetadata && !IsEmbeddingAudioMetadata && !IsEmbeddingVideoMetadata && !IsEmbeddingMultiInputMetadata || !IsEmbeddingImageMetadata && IsEmbeddingTextImageMetadata && !IsEmbeddingAudioMetadata && !IsEmbeddingVideoMetadata && !IsEmbeddingMultiInputMetadata || !IsEmbeddingImageMetadata && !IsEmbeddingTextImageMetadata && IsEmbeddingAudioMetadata && !IsEmbeddingVideoMetadata && !IsEmbeddingMultiInputMetadata || !IsEmbeddingImageMetadata && !IsEmbeddingTextImageMetadata && !IsEmbeddingAudioMetadata && IsEmbeddingVideoMetadata && !IsEmbeddingMultiInputMetadata || !IsEmbeddingImageMetadata && !IsEmbeddingTextImageMetadata && !IsEmbeddingAudioMetadata && !IsEmbeddingVideoMetadata && IsEmbeddingMultiInputMetadata;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::TwelveLabs.EmbeddingImageMetadata?, TResult>? embeddingImageMetadata = null,
            global::System.Func<global::TwelveLabs.EmbeddingTextImageMetadata?, TResult>? embeddingTextImageMetadata = null,
            global::System.Func<global::TwelveLabs.EmbeddingAudioMetadata?, TResult>? embeddingAudioMetadata = null,
            global::System.Func<global::TwelveLabs.EmbeddingVideoMetadata?, TResult>? embeddingVideoMetadata = null,
            global::System.Func<global::TwelveLabs.EmbeddingMultiInputMetadata?, TResult>? embeddingMultiInputMetadata = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEmbeddingImageMetadata && embeddingImageMetadata != null)
            {
                return embeddingImageMetadata(EmbeddingImageMetadata!);
            }
            else if (IsEmbeddingTextImageMetadata && embeddingTextImageMetadata != null)
            {
                return embeddingTextImageMetadata(EmbeddingTextImageMetadata!);
            }
            else if (IsEmbeddingAudioMetadata && embeddingAudioMetadata != null)
            {
                return embeddingAudioMetadata(EmbeddingAudioMetadata!);
            }
            else if (IsEmbeddingVideoMetadata && embeddingVideoMetadata != null)
            {
                return embeddingVideoMetadata(EmbeddingVideoMetadata!);
            }
            else if (IsEmbeddingMultiInputMetadata && embeddingMultiInputMetadata != null)
            {
                return embeddingMultiInputMetadata(EmbeddingMultiInputMetadata!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::TwelveLabs.EmbeddingImageMetadata?>? embeddingImageMetadata = null,
            global::System.Action<global::TwelveLabs.EmbeddingTextImageMetadata?>? embeddingTextImageMetadata = null,
            global::System.Action<global::TwelveLabs.EmbeddingAudioMetadata?>? embeddingAudioMetadata = null,
            global::System.Action<global::TwelveLabs.EmbeddingVideoMetadata?>? embeddingVideoMetadata = null,
            global::System.Action<global::TwelveLabs.EmbeddingMultiInputMetadata?>? embeddingMultiInputMetadata = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEmbeddingImageMetadata)
            {
                embeddingImageMetadata?.Invoke(EmbeddingImageMetadata!);
            }
            else if (IsEmbeddingTextImageMetadata)
            {
                embeddingTextImageMetadata?.Invoke(EmbeddingTextImageMetadata!);
            }
            else if (IsEmbeddingAudioMetadata)
            {
                embeddingAudioMetadata?.Invoke(EmbeddingAudioMetadata!);
            }
            else if (IsEmbeddingVideoMetadata)
            {
                embeddingVideoMetadata?.Invoke(EmbeddingVideoMetadata!);
            }
            else if (IsEmbeddingMultiInputMetadata)
            {
                embeddingMultiInputMetadata?.Invoke(EmbeddingMultiInputMetadata!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                EmbeddingImageMetadata,
                typeof(global::TwelveLabs.EmbeddingImageMetadata),
                EmbeddingTextImageMetadata,
                typeof(global::TwelveLabs.EmbeddingTextImageMetadata),
                EmbeddingAudioMetadata,
                typeof(global::TwelveLabs.EmbeddingAudioMetadata),
                EmbeddingVideoMetadata,
                typeof(global::TwelveLabs.EmbeddingVideoMetadata),
                EmbeddingMultiInputMetadata,
                typeof(global::TwelveLabs.EmbeddingMultiInputMetadata),
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
        public bool Equals(EmbeddingMediaMetadata other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::TwelveLabs.EmbeddingImageMetadata?>.Default.Equals(EmbeddingImageMetadata, other.EmbeddingImageMetadata) &&
                global::System.Collections.Generic.EqualityComparer<global::TwelveLabs.EmbeddingTextImageMetadata?>.Default.Equals(EmbeddingTextImageMetadata, other.EmbeddingTextImageMetadata) &&
                global::System.Collections.Generic.EqualityComparer<global::TwelveLabs.EmbeddingAudioMetadata?>.Default.Equals(EmbeddingAudioMetadata, other.EmbeddingAudioMetadata) &&
                global::System.Collections.Generic.EqualityComparer<global::TwelveLabs.EmbeddingVideoMetadata?>.Default.Equals(EmbeddingVideoMetadata, other.EmbeddingVideoMetadata) &&
                global::System.Collections.Generic.EqualityComparer<global::TwelveLabs.EmbeddingMultiInputMetadata?>.Default.Equals(EmbeddingMultiInputMetadata, other.EmbeddingMultiInputMetadata) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(EmbeddingMediaMetadata obj1, EmbeddingMediaMetadata obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<EmbeddingMediaMetadata>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(EmbeddingMediaMetadata obj1, EmbeddingMediaMetadata obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is EmbeddingMediaMetadata o && Equals(o);
        }
    }
}
