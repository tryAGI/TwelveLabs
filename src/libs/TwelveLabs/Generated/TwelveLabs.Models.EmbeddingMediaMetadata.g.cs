#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Metadata for the media input. Available for the `image`, `text_image`, `audio`, `video`, and `multi_input` input types.
    /// </summary>
    public readonly partial struct EmbeddingMediaMetadata : global::System.IEquatable<EmbeddingMediaMetadata>
    {
        /// <summary>
        /// Metadata for image embeddings.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::TwelveLabs.EmbeddingMediaMetadataVariant1? EmbeddingMediaMetadataVariant1 { get; init; }
#else
        public global::TwelveLabs.EmbeddingMediaMetadataVariant1? EmbeddingMediaMetadataVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EmbeddingMediaMetadataVariant1))]
#endif
        public bool IsEmbeddingMediaMetadataVariant1 => EmbeddingMediaMetadataVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickEmbeddingMediaMetadataVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::TwelveLabs.EmbeddingMediaMetadataVariant1? value)
        {
            value = EmbeddingMediaMetadataVariant1;
            return IsEmbeddingMediaMetadataVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingMediaMetadataVariant1 PickEmbeddingMediaMetadataVariant1() => IsEmbeddingMediaMetadataVariant1
            ? EmbeddingMediaMetadataVariant1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'EmbeddingMediaMetadataVariant1' but the value was {ToString()}.");

        /// <summary>
        /// Metadata for text-image embeddings.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::TwelveLabs.EmbeddingMediaMetadataVariant2? EmbeddingMediaMetadataVariant2 { get; init; }
#else
        public global::TwelveLabs.EmbeddingMediaMetadataVariant2? EmbeddingMediaMetadataVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EmbeddingMediaMetadataVariant2))]
#endif
        public bool IsEmbeddingMediaMetadataVariant2 => EmbeddingMediaMetadataVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickEmbeddingMediaMetadataVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::TwelveLabs.EmbeddingMediaMetadataVariant2? value)
        {
            value = EmbeddingMediaMetadataVariant2;
            return IsEmbeddingMediaMetadataVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingMediaMetadataVariant2 PickEmbeddingMediaMetadataVariant2() => IsEmbeddingMediaMetadataVariant2
            ? EmbeddingMediaMetadataVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'EmbeddingMediaMetadataVariant2' but the value was {ToString()}.");

        /// <summary>
        /// Metadata for audio embeddings.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::TwelveLabs.EmbeddingMediaMetadataVariant3? EmbeddingMediaMetadataVariant3 { get; init; }
#else
        public global::TwelveLabs.EmbeddingMediaMetadataVariant3? EmbeddingMediaMetadataVariant3 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EmbeddingMediaMetadataVariant3))]
#endif
        public bool IsEmbeddingMediaMetadataVariant3 => EmbeddingMediaMetadataVariant3 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickEmbeddingMediaMetadataVariant3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::TwelveLabs.EmbeddingMediaMetadataVariant3? value)
        {
            value = EmbeddingMediaMetadataVariant3;
            return IsEmbeddingMediaMetadataVariant3;
        }

        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingMediaMetadataVariant3 PickEmbeddingMediaMetadataVariant3() => IsEmbeddingMediaMetadataVariant3
            ? EmbeddingMediaMetadataVariant3!
            : throw new global::System.InvalidOperationException($"Expected union variant 'EmbeddingMediaMetadataVariant3' but the value was {ToString()}.");

        /// <summary>
        /// Metadata for video embeddings.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::TwelveLabs.EmbeddingMediaMetadataVariant4? EmbeddingMediaMetadataVariant4 { get; init; }
#else
        public global::TwelveLabs.EmbeddingMediaMetadataVariant4? EmbeddingMediaMetadataVariant4 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EmbeddingMediaMetadataVariant4))]
#endif
        public bool IsEmbeddingMediaMetadataVariant4 => EmbeddingMediaMetadataVariant4 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickEmbeddingMediaMetadataVariant4(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::TwelveLabs.EmbeddingMediaMetadataVariant4? value)
        {
            value = EmbeddingMediaMetadataVariant4;
            return IsEmbeddingMediaMetadataVariant4;
        }

        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingMediaMetadataVariant4 PickEmbeddingMediaMetadataVariant4() => IsEmbeddingMediaMetadataVariant4
            ? EmbeddingMediaMetadataVariant4!
            : throw new global::System.InvalidOperationException($"Expected union variant 'EmbeddingMediaMetadataVariant4' but the value was {ToString()}.");

        /// <summary>
        /// Metadata for multi-input embeddings.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::TwelveLabs.EmbeddingMediaMetadataVariant5? EmbeddingMediaMetadataVariant5 { get; init; }
#else
        public global::TwelveLabs.EmbeddingMediaMetadataVariant5? EmbeddingMediaMetadataVariant5 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EmbeddingMediaMetadataVariant5))]
#endif
        public bool IsEmbeddingMediaMetadataVariant5 => EmbeddingMediaMetadataVariant5 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickEmbeddingMediaMetadataVariant5(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::TwelveLabs.EmbeddingMediaMetadataVariant5? value)
        {
            value = EmbeddingMediaMetadataVariant5;
            return IsEmbeddingMediaMetadataVariant5;
        }

        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingMediaMetadataVariant5 PickEmbeddingMediaMetadataVariant5() => IsEmbeddingMediaMetadataVariant5
            ? EmbeddingMediaMetadataVariant5!
            : throw new global::System.InvalidOperationException($"Expected union variant 'EmbeddingMediaMetadataVariant5' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator EmbeddingMediaMetadata(global::TwelveLabs.EmbeddingMediaMetadataVariant1 value) => new EmbeddingMediaMetadata((global::TwelveLabs.EmbeddingMediaMetadataVariant1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::TwelveLabs.EmbeddingMediaMetadataVariant1?(EmbeddingMediaMetadata @this) => @this.EmbeddingMediaMetadataVariant1;

        /// <summary>
        ///
        /// </summary>
        public EmbeddingMediaMetadata(global::TwelveLabs.EmbeddingMediaMetadataVariant1? value)
        {
            EmbeddingMediaMetadataVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static EmbeddingMediaMetadata FromEmbeddingMediaMetadataVariant1(global::TwelveLabs.EmbeddingMediaMetadataVariant1? value) => new EmbeddingMediaMetadata(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator EmbeddingMediaMetadata(global::TwelveLabs.EmbeddingMediaMetadataVariant2 value) => new EmbeddingMediaMetadata((global::TwelveLabs.EmbeddingMediaMetadataVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::TwelveLabs.EmbeddingMediaMetadataVariant2?(EmbeddingMediaMetadata @this) => @this.EmbeddingMediaMetadataVariant2;

        /// <summary>
        ///
        /// </summary>
        public EmbeddingMediaMetadata(global::TwelveLabs.EmbeddingMediaMetadataVariant2? value)
        {
            EmbeddingMediaMetadataVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static EmbeddingMediaMetadata FromEmbeddingMediaMetadataVariant2(global::TwelveLabs.EmbeddingMediaMetadataVariant2? value) => new EmbeddingMediaMetadata(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator EmbeddingMediaMetadata(global::TwelveLabs.EmbeddingMediaMetadataVariant3 value) => new EmbeddingMediaMetadata((global::TwelveLabs.EmbeddingMediaMetadataVariant3?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::TwelveLabs.EmbeddingMediaMetadataVariant3?(EmbeddingMediaMetadata @this) => @this.EmbeddingMediaMetadataVariant3;

        /// <summary>
        ///
        /// </summary>
        public EmbeddingMediaMetadata(global::TwelveLabs.EmbeddingMediaMetadataVariant3? value)
        {
            EmbeddingMediaMetadataVariant3 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static EmbeddingMediaMetadata FromEmbeddingMediaMetadataVariant3(global::TwelveLabs.EmbeddingMediaMetadataVariant3? value) => new EmbeddingMediaMetadata(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator EmbeddingMediaMetadata(global::TwelveLabs.EmbeddingMediaMetadataVariant4 value) => new EmbeddingMediaMetadata((global::TwelveLabs.EmbeddingMediaMetadataVariant4?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::TwelveLabs.EmbeddingMediaMetadataVariant4?(EmbeddingMediaMetadata @this) => @this.EmbeddingMediaMetadataVariant4;

        /// <summary>
        ///
        /// </summary>
        public EmbeddingMediaMetadata(global::TwelveLabs.EmbeddingMediaMetadataVariant4? value)
        {
            EmbeddingMediaMetadataVariant4 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static EmbeddingMediaMetadata FromEmbeddingMediaMetadataVariant4(global::TwelveLabs.EmbeddingMediaMetadataVariant4? value) => new EmbeddingMediaMetadata(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator EmbeddingMediaMetadata(global::TwelveLabs.EmbeddingMediaMetadataVariant5 value) => new EmbeddingMediaMetadata((global::TwelveLabs.EmbeddingMediaMetadataVariant5?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::TwelveLabs.EmbeddingMediaMetadataVariant5?(EmbeddingMediaMetadata @this) => @this.EmbeddingMediaMetadataVariant5;

        /// <summary>
        ///
        /// </summary>
        public EmbeddingMediaMetadata(global::TwelveLabs.EmbeddingMediaMetadataVariant5? value)
        {
            EmbeddingMediaMetadataVariant5 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static EmbeddingMediaMetadata FromEmbeddingMediaMetadataVariant5(global::TwelveLabs.EmbeddingMediaMetadataVariant5? value) => new EmbeddingMediaMetadata(value);

        /// <summary>
        ///
        /// </summary>
        public EmbeddingMediaMetadata(
            global::TwelveLabs.EmbeddingMediaMetadataVariant1? embeddingMediaMetadataVariant1,
            global::TwelveLabs.EmbeddingMediaMetadataVariant2? embeddingMediaMetadataVariant2,
            global::TwelveLabs.EmbeddingMediaMetadataVariant3? embeddingMediaMetadataVariant3,
            global::TwelveLabs.EmbeddingMediaMetadataVariant4? embeddingMediaMetadataVariant4,
            global::TwelveLabs.EmbeddingMediaMetadataVariant5? embeddingMediaMetadataVariant5
            )
        {
            EmbeddingMediaMetadataVariant1 = embeddingMediaMetadataVariant1;
            EmbeddingMediaMetadataVariant2 = embeddingMediaMetadataVariant2;
            EmbeddingMediaMetadataVariant3 = embeddingMediaMetadataVariant3;
            EmbeddingMediaMetadataVariant4 = embeddingMediaMetadataVariant4;
            EmbeddingMediaMetadataVariant5 = embeddingMediaMetadataVariant5;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            EmbeddingMediaMetadataVariant5 as object ??
            EmbeddingMediaMetadataVariant4 as object ??
            EmbeddingMediaMetadataVariant3 as object ??
            EmbeddingMediaMetadataVariant2 as object ??
            EmbeddingMediaMetadataVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            EmbeddingMediaMetadataVariant1?.ToString() ??
            EmbeddingMediaMetadataVariant2?.ToString() ??
            EmbeddingMediaMetadataVariant3?.ToString() ??
            EmbeddingMediaMetadataVariant4?.ToString() ??
            EmbeddingMediaMetadataVariant5?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsEmbeddingMediaMetadataVariant1 && !IsEmbeddingMediaMetadataVariant2 && !IsEmbeddingMediaMetadataVariant3 && !IsEmbeddingMediaMetadataVariant4 && !IsEmbeddingMediaMetadataVariant5 || !IsEmbeddingMediaMetadataVariant1 && IsEmbeddingMediaMetadataVariant2 && !IsEmbeddingMediaMetadataVariant3 && !IsEmbeddingMediaMetadataVariant4 && !IsEmbeddingMediaMetadataVariant5 || !IsEmbeddingMediaMetadataVariant1 && !IsEmbeddingMediaMetadataVariant2 && IsEmbeddingMediaMetadataVariant3 && !IsEmbeddingMediaMetadataVariant4 && !IsEmbeddingMediaMetadataVariant5 || !IsEmbeddingMediaMetadataVariant1 && !IsEmbeddingMediaMetadataVariant2 && !IsEmbeddingMediaMetadataVariant3 && IsEmbeddingMediaMetadataVariant4 && !IsEmbeddingMediaMetadataVariant5 || !IsEmbeddingMediaMetadataVariant1 && !IsEmbeddingMediaMetadataVariant2 && !IsEmbeddingMediaMetadataVariant3 && !IsEmbeddingMediaMetadataVariant4 && IsEmbeddingMediaMetadataVariant5;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::TwelveLabs.EmbeddingMediaMetadataVariant1, TResult>? embeddingMediaMetadataVariant1 = null,
            global::System.Func<global::TwelveLabs.EmbeddingMediaMetadataVariant2, TResult>? embeddingMediaMetadataVariant2 = null,
            global::System.Func<global::TwelveLabs.EmbeddingMediaMetadataVariant3, TResult>? embeddingMediaMetadataVariant3 = null,
            global::System.Func<global::TwelveLabs.EmbeddingMediaMetadataVariant4, TResult>? embeddingMediaMetadataVariant4 = null,
            global::System.Func<global::TwelveLabs.EmbeddingMediaMetadataVariant5, TResult>? embeddingMediaMetadataVariant5 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEmbeddingMediaMetadataVariant1 && embeddingMediaMetadataVariant1 != null)
            {
                return embeddingMediaMetadataVariant1(EmbeddingMediaMetadataVariant1!);
            }
            else if (IsEmbeddingMediaMetadataVariant2 && embeddingMediaMetadataVariant2 != null)
            {
                return embeddingMediaMetadataVariant2(EmbeddingMediaMetadataVariant2!);
            }
            else if (IsEmbeddingMediaMetadataVariant3 && embeddingMediaMetadataVariant3 != null)
            {
                return embeddingMediaMetadataVariant3(EmbeddingMediaMetadataVariant3!);
            }
            else if (IsEmbeddingMediaMetadataVariant4 && embeddingMediaMetadataVariant4 != null)
            {
                return embeddingMediaMetadataVariant4(EmbeddingMediaMetadataVariant4!);
            }
            else if (IsEmbeddingMediaMetadataVariant5 && embeddingMediaMetadataVariant5 != null)
            {
                return embeddingMediaMetadataVariant5(EmbeddingMediaMetadataVariant5!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::TwelveLabs.EmbeddingMediaMetadataVariant1>? embeddingMediaMetadataVariant1 = null,

            global::System.Action<global::TwelveLabs.EmbeddingMediaMetadataVariant2>? embeddingMediaMetadataVariant2 = null,

            global::System.Action<global::TwelveLabs.EmbeddingMediaMetadataVariant3>? embeddingMediaMetadataVariant3 = null,

            global::System.Action<global::TwelveLabs.EmbeddingMediaMetadataVariant4>? embeddingMediaMetadataVariant4 = null,

            global::System.Action<global::TwelveLabs.EmbeddingMediaMetadataVariant5>? embeddingMediaMetadataVariant5 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEmbeddingMediaMetadataVariant1)
            {
                embeddingMediaMetadataVariant1?.Invoke(EmbeddingMediaMetadataVariant1!);
            }
            else if (IsEmbeddingMediaMetadataVariant2)
            {
                embeddingMediaMetadataVariant2?.Invoke(EmbeddingMediaMetadataVariant2!);
            }
            else if (IsEmbeddingMediaMetadataVariant3)
            {
                embeddingMediaMetadataVariant3?.Invoke(EmbeddingMediaMetadataVariant3!);
            }
            else if (IsEmbeddingMediaMetadataVariant4)
            {
                embeddingMediaMetadataVariant4?.Invoke(EmbeddingMediaMetadataVariant4!);
            }
            else if (IsEmbeddingMediaMetadataVariant5)
            {
                embeddingMediaMetadataVariant5?.Invoke(EmbeddingMediaMetadataVariant5!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::TwelveLabs.EmbeddingMediaMetadataVariant1>? embeddingMediaMetadataVariant1 = null,
            global::System.Action<global::TwelveLabs.EmbeddingMediaMetadataVariant2>? embeddingMediaMetadataVariant2 = null,
            global::System.Action<global::TwelveLabs.EmbeddingMediaMetadataVariant3>? embeddingMediaMetadataVariant3 = null,
            global::System.Action<global::TwelveLabs.EmbeddingMediaMetadataVariant4>? embeddingMediaMetadataVariant4 = null,
            global::System.Action<global::TwelveLabs.EmbeddingMediaMetadataVariant5>? embeddingMediaMetadataVariant5 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEmbeddingMediaMetadataVariant1)
            {
                embeddingMediaMetadataVariant1?.Invoke(EmbeddingMediaMetadataVariant1!);
            }
            else if (IsEmbeddingMediaMetadataVariant2)
            {
                embeddingMediaMetadataVariant2?.Invoke(EmbeddingMediaMetadataVariant2!);
            }
            else if (IsEmbeddingMediaMetadataVariant3)
            {
                embeddingMediaMetadataVariant3?.Invoke(EmbeddingMediaMetadataVariant3!);
            }
            else if (IsEmbeddingMediaMetadataVariant4)
            {
                embeddingMediaMetadataVariant4?.Invoke(EmbeddingMediaMetadataVariant4!);
            }
            else if (IsEmbeddingMediaMetadataVariant5)
            {
                embeddingMediaMetadataVariant5?.Invoke(EmbeddingMediaMetadataVariant5!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                EmbeddingMediaMetadataVariant1,
                typeof(global::TwelveLabs.EmbeddingMediaMetadataVariant1),
                EmbeddingMediaMetadataVariant2,
                typeof(global::TwelveLabs.EmbeddingMediaMetadataVariant2),
                EmbeddingMediaMetadataVariant3,
                typeof(global::TwelveLabs.EmbeddingMediaMetadataVariant3),
                EmbeddingMediaMetadataVariant4,
                typeof(global::TwelveLabs.EmbeddingMediaMetadataVariant4),
                EmbeddingMediaMetadataVariant5,
                typeof(global::TwelveLabs.EmbeddingMediaMetadataVariant5),
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
                global::System.Collections.Generic.EqualityComparer<global::TwelveLabs.EmbeddingMediaMetadataVariant1?>.Default.Equals(EmbeddingMediaMetadataVariant1, other.EmbeddingMediaMetadataVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::TwelveLabs.EmbeddingMediaMetadataVariant2?>.Default.Equals(EmbeddingMediaMetadataVariant2, other.EmbeddingMediaMetadataVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::TwelveLabs.EmbeddingMediaMetadataVariant3?>.Default.Equals(EmbeddingMediaMetadataVariant3, other.EmbeddingMediaMetadataVariant3) &&
                global::System.Collections.Generic.EqualityComparer<global::TwelveLabs.EmbeddingMediaMetadataVariant4?>.Default.Equals(EmbeddingMediaMetadataVariant4, other.EmbeddingMediaMetadataVariant4) &&
                global::System.Collections.Generic.EqualityComparer<global::TwelveLabs.EmbeddingMediaMetadataVariant5?>.Default.Equals(EmbeddingMediaMetadataVariant5, other.EmbeddingMediaMetadataVariant5)
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
