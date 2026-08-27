#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Metadata for the media input.
    /// </summary>
    public readonly partial struct EmbeddingTaskMediaMetadata : global::System.IEquatable<EmbeddingTaskMediaMetadata>
    {
        /// <summary>
        /// Metadata for audio embeddings
        /// </summary>
#if NET6_0_OR_GREATER
        public global::TwelveLabs.EmbeddingTaskMediaMetadataVariant1? EmbeddingTaskMediaMetadataVariant1 { get; init; }
#else
        public global::TwelveLabs.EmbeddingTaskMediaMetadataVariant1? EmbeddingTaskMediaMetadataVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EmbeddingTaskMediaMetadataVariant1))]
#endif
        public bool IsEmbeddingTaskMediaMetadataVariant1 => EmbeddingTaskMediaMetadataVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickEmbeddingTaskMediaMetadataVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::TwelveLabs.EmbeddingTaskMediaMetadataVariant1? value)
        {
            value = EmbeddingTaskMediaMetadataVariant1;
            return IsEmbeddingTaskMediaMetadataVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingTaskMediaMetadataVariant1 PickEmbeddingTaskMediaMetadataVariant1() => IsEmbeddingTaskMediaMetadataVariant1
            ? EmbeddingTaskMediaMetadataVariant1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'EmbeddingTaskMediaMetadataVariant1' but the value was {ToString()}.");

        /// <summary>
        /// Metadata for video embeddings
        /// </summary>
#if NET6_0_OR_GREATER
        public global::TwelveLabs.EmbeddingTaskMediaMetadataVariant2? EmbeddingTaskMediaMetadataVariant2 { get; init; }
#else
        public global::TwelveLabs.EmbeddingTaskMediaMetadataVariant2? EmbeddingTaskMediaMetadataVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EmbeddingTaskMediaMetadataVariant2))]
#endif
        public bool IsEmbeddingTaskMediaMetadataVariant2 => EmbeddingTaskMediaMetadataVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickEmbeddingTaskMediaMetadataVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::TwelveLabs.EmbeddingTaskMediaMetadataVariant2? value)
        {
            value = EmbeddingTaskMediaMetadataVariant2;
            return IsEmbeddingTaskMediaMetadataVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingTaskMediaMetadataVariant2 PickEmbeddingTaskMediaMetadataVariant2() => IsEmbeddingTaskMediaMetadataVariant2
            ? EmbeddingTaskMediaMetadataVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'EmbeddingTaskMediaMetadataVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator EmbeddingTaskMediaMetadata(global::TwelveLabs.EmbeddingTaskMediaMetadataVariant1 value) => new EmbeddingTaskMediaMetadata((global::TwelveLabs.EmbeddingTaskMediaMetadataVariant1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::TwelveLabs.EmbeddingTaskMediaMetadataVariant1?(EmbeddingTaskMediaMetadata @this) => @this.EmbeddingTaskMediaMetadataVariant1;

        /// <summary>
        ///
        /// </summary>
        public EmbeddingTaskMediaMetadata(global::TwelveLabs.EmbeddingTaskMediaMetadataVariant1? value)
        {
            EmbeddingTaskMediaMetadataVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static EmbeddingTaskMediaMetadata FromEmbeddingTaskMediaMetadataVariant1(global::TwelveLabs.EmbeddingTaskMediaMetadataVariant1? value) => new EmbeddingTaskMediaMetadata(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator EmbeddingTaskMediaMetadata(global::TwelveLabs.EmbeddingTaskMediaMetadataVariant2 value) => new EmbeddingTaskMediaMetadata((global::TwelveLabs.EmbeddingTaskMediaMetadataVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::TwelveLabs.EmbeddingTaskMediaMetadataVariant2?(EmbeddingTaskMediaMetadata @this) => @this.EmbeddingTaskMediaMetadataVariant2;

        /// <summary>
        ///
        /// </summary>
        public EmbeddingTaskMediaMetadata(global::TwelveLabs.EmbeddingTaskMediaMetadataVariant2? value)
        {
            EmbeddingTaskMediaMetadataVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static EmbeddingTaskMediaMetadata FromEmbeddingTaskMediaMetadataVariant2(global::TwelveLabs.EmbeddingTaskMediaMetadataVariant2? value) => new EmbeddingTaskMediaMetadata(value);

        /// <summary>
        ///
        /// </summary>
        public EmbeddingTaskMediaMetadata(
            global::TwelveLabs.EmbeddingTaskMediaMetadataVariant1? embeddingTaskMediaMetadataVariant1,
            global::TwelveLabs.EmbeddingTaskMediaMetadataVariant2? embeddingTaskMediaMetadataVariant2
            )
        {
            EmbeddingTaskMediaMetadataVariant1 = embeddingTaskMediaMetadataVariant1;
            EmbeddingTaskMediaMetadataVariant2 = embeddingTaskMediaMetadataVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            EmbeddingTaskMediaMetadataVariant2 as object ??
            EmbeddingTaskMediaMetadataVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            EmbeddingTaskMediaMetadataVariant1?.ToString() ??
            EmbeddingTaskMediaMetadataVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsEmbeddingTaskMediaMetadataVariant1 && !IsEmbeddingTaskMediaMetadataVariant2 || !IsEmbeddingTaskMediaMetadataVariant1 && IsEmbeddingTaskMediaMetadataVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::TwelveLabs.EmbeddingTaskMediaMetadataVariant1, TResult>? embeddingTaskMediaMetadataVariant1 = null,
            global::System.Func<global::TwelveLabs.EmbeddingTaskMediaMetadataVariant2, TResult>? embeddingTaskMediaMetadataVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEmbeddingTaskMediaMetadataVariant1 && embeddingTaskMediaMetadataVariant1 != null)
            {
                return embeddingTaskMediaMetadataVariant1(EmbeddingTaskMediaMetadataVariant1!);
            }
            else if (IsEmbeddingTaskMediaMetadataVariant2 && embeddingTaskMediaMetadataVariant2 != null)
            {
                return embeddingTaskMediaMetadataVariant2(EmbeddingTaskMediaMetadataVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::TwelveLabs.EmbeddingTaskMediaMetadataVariant1>? embeddingTaskMediaMetadataVariant1 = null,

            global::System.Action<global::TwelveLabs.EmbeddingTaskMediaMetadataVariant2>? embeddingTaskMediaMetadataVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEmbeddingTaskMediaMetadataVariant1)
            {
                embeddingTaskMediaMetadataVariant1?.Invoke(EmbeddingTaskMediaMetadataVariant1!);
            }
            else if (IsEmbeddingTaskMediaMetadataVariant2)
            {
                embeddingTaskMediaMetadataVariant2?.Invoke(EmbeddingTaskMediaMetadataVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::TwelveLabs.EmbeddingTaskMediaMetadataVariant1>? embeddingTaskMediaMetadataVariant1 = null,
            global::System.Action<global::TwelveLabs.EmbeddingTaskMediaMetadataVariant2>? embeddingTaskMediaMetadataVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEmbeddingTaskMediaMetadataVariant1)
            {
                embeddingTaskMediaMetadataVariant1?.Invoke(EmbeddingTaskMediaMetadataVariant1!);
            }
            else if (IsEmbeddingTaskMediaMetadataVariant2)
            {
                embeddingTaskMediaMetadataVariant2?.Invoke(EmbeddingTaskMediaMetadataVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                EmbeddingTaskMediaMetadataVariant1,
                typeof(global::TwelveLabs.EmbeddingTaskMediaMetadataVariant1),
                EmbeddingTaskMediaMetadataVariant2,
                typeof(global::TwelveLabs.EmbeddingTaskMediaMetadataVariant2),
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
        public bool Equals(EmbeddingTaskMediaMetadata other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::TwelveLabs.EmbeddingTaskMediaMetadataVariant1?>.Default.Equals(EmbeddingTaskMediaMetadataVariant1, other.EmbeddingTaskMediaMetadataVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::TwelveLabs.EmbeddingTaskMediaMetadataVariant2?>.Default.Equals(EmbeddingTaskMediaMetadataVariant2, other.EmbeddingTaskMediaMetadataVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(EmbeddingTaskMediaMetadata obj1, EmbeddingTaskMediaMetadata obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<EmbeddingTaskMediaMetadata>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(EmbeddingTaskMediaMetadata obj1, EmbeddingTaskMediaMetadata obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is EmbeddingTaskMediaMetadata o && Equals(o);
        }
    }
}
