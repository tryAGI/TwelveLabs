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
        /// Metadata for audio embeddings.
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
        /// Metadata for video embeddings.
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
        /// Metadata for document embeddings. Only Marengo 3.5 returns this object.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::TwelveLabs.EmbeddingTaskMediaMetadataVariant3? EmbeddingTaskMediaMetadataVariant3 { get; init; }
#else
        public global::TwelveLabs.EmbeddingTaskMediaMetadataVariant3? EmbeddingTaskMediaMetadataVariant3 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EmbeddingTaskMediaMetadataVariant3))]
#endif
        public bool IsEmbeddingTaskMediaMetadataVariant3 => EmbeddingTaskMediaMetadataVariant3 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickEmbeddingTaskMediaMetadataVariant3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::TwelveLabs.EmbeddingTaskMediaMetadataVariant3? value)
        {
            value = EmbeddingTaskMediaMetadataVariant3;
            return IsEmbeddingTaskMediaMetadataVariant3;
        }

        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingTaskMediaMetadataVariant3 PickEmbeddingTaskMediaMetadataVariant3() => IsEmbeddingTaskMediaMetadataVariant3
            ? EmbeddingTaskMediaMetadataVariant3!
            : throw new global::System.InvalidOperationException($"Expected union variant 'EmbeddingTaskMediaMetadataVariant3' but the value was {ToString()}.");

        /// <summary>
        /// Metadata for image embeddings. Only Marengo 3.5 returns this object.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::TwelveLabs.EmbeddingTaskMediaMetadataVariant4? EmbeddingTaskMediaMetadataVariant4 { get; init; }
#else
        public global::TwelveLabs.EmbeddingTaskMediaMetadataVariant4? EmbeddingTaskMediaMetadataVariant4 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EmbeddingTaskMediaMetadataVariant4))]
#endif
        public bool IsEmbeddingTaskMediaMetadataVariant4 => EmbeddingTaskMediaMetadataVariant4 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickEmbeddingTaskMediaMetadataVariant4(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::TwelveLabs.EmbeddingTaskMediaMetadataVariant4? value)
        {
            value = EmbeddingTaskMediaMetadataVariant4;
            return IsEmbeddingTaskMediaMetadataVariant4;
        }

        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingTaskMediaMetadataVariant4 PickEmbeddingTaskMediaMetadataVariant4() => IsEmbeddingTaskMediaMetadataVariant4
            ? EmbeddingTaskMediaMetadataVariant4!
            : throw new global::System.InvalidOperationException($"Expected union variant 'EmbeddingTaskMediaMetadataVariant4' but the value was {ToString()}.");
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
        public static implicit operator EmbeddingTaskMediaMetadata(global::TwelveLabs.EmbeddingTaskMediaMetadataVariant3 value) => new EmbeddingTaskMediaMetadata((global::TwelveLabs.EmbeddingTaskMediaMetadataVariant3?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::TwelveLabs.EmbeddingTaskMediaMetadataVariant3?(EmbeddingTaskMediaMetadata @this) => @this.EmbeddingTaskMediaMetadataVariant3;

        /// <summary>
        ///
        /// </summary>
        public EmbeddingTaskMediaMetadata(global::TwelveLabs.EmbeddingTaskMediaMetadataVariant3? value)
        {
            EmbeddingTaskMediaMetadataVariant3 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static EmbeddingTaskMediaMetadata FromEmbeddingTaskMediaMetadataVariant3(global::TwelveLabs.EmbeddingTaskMediaMetadataVariant3? value) => new EmbeddingTaskMediaMetadata(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator EmbeddingTaskMediaMetadata(global::TwelveLabs.EmbeddingTaskMediaMetadataVariant4 value) => new EmbeddingTaskMediaMetadata((global::TwelveLabs.EmbeddingTaskMediaMetadataVariant4?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::TwelveLabs.EmbeddingTaskMediaMetadataVariant4?(EmbeddingTaskMediaMetadata @this) => @this.EmbeddingTaskMediaMetadataVariant4;

        /// <summary>
        ///
        /// </summary>
        public EmbeddingTaskMediaMetadata(global::TwelveLabs.EmbeddingTaskMediaMetadataVariant4? value)
        {
            EmbeddingTaskMediaMetadataVariant4 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static EmbeddingTaskMediaMetadata FromEmbeddingTaskMediaMetadataVariant4(global::TwelveLabs.EmbeddingTaskMediaMetadataVariant4? value) => new EmbeddingTaskMediaMetadata(value);

        /// <summary>
        ///
        /// </summary>
        public EmbeddingTaskMediaMetadata(
            global::TwelveLabs.EmbeddingTaskMediaMetadataVariant1? embeddingTaskMediaMetadataVariant1,
            global::TwelveLabs.EmbeddingTaskMediaMetadataVariant2? embeddingTaskMediaMetadataVariant2,
            global::TwelveLabs.EmbeddingTaskMediaMetadataVariant3? embeddingTaskMediaMetadataVariant3,
            global::TwelveLabs.EmbeddingTaskMediaMetadataVariant4? embeddingTaskMediaMetadataVariant4
            )
        {
            EmbeddingTaskMediaMetadataVariant1 = embeddingTaskMediaMetadataVariant1;
            EmbeddingTaskMediaMetadataVariant2 = embeddingTaskMediaMetadataVariant2;
            EmbeddingTaskMediaMetadataVariant3 = embeddingTaskMediaMetadataVariant3;
            EmbeddingTaskMediaMetadataVariant4 = embeddingTaskMediaMetadataVariant4;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            EmbeddingTaskMediaMetadataVariant4 as object ??
            EmbeddingTaskMediaMetadataVariant3 as object ??
            EmbeddingTaskMediaMetadataVariant2 as object ??
            EmbeddingTaskMediaMetadataVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            EmbeddingTaskMediaMetadataVariant1?.ToString() ??
            EmbeddingTaskMediaMetadataVariant2?.ToString() ??
            EmbeddingTaskMediaMetadataVariant3?.ToString() ??
            EmbeddingTaskMediaMetadataVariant4?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsEmbeddingTaskMediaMetadataVariant1 && !IsEmbeddingTaskMediaMetadataVariant2 && !IsEmbeddingTaskMediaMetadataVariant3 && !IsEmbeddingTaskMediaMetadataVariant4 || !IsEmbeddingTaskMediaMetadataVariant1 && IsEmbeddingTaskMediaMetadataVariant2 && !IsEmbeddingTaskMediaMetadataVariant3 && !IsEmbeddingTaskMediaMetadataVariant4 || !IsEmbeddingTaskMediaMetadataVariant1 && !IsEmbeddingTaskMediaMetadataVariant2 && IsEmbeddingTaskMediaMetadataVariant3 && !IsEmbeddingTaskMediaMetadataVariant4 || !IsEmbeddingTaskMediaMetadataVariant1 && !IsEmbeddingTaskMediaMetadataVariant2 && !IsEmbeddingTaskMediaMetadataVariant3 && IsEmbeddingTaskMediaMetadataVariant4;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::TwelveLabs.EmbeddingTaskMediaMetadataVariant1, TResult>? embeddingTaskMediaMetadataVariant1 = null,
            global::System.Func<global::TwelveLabs.EmbeddingTaskMediaMetadataVariant2, TResult>? embeddingTaskMediaMetadataVariant2 = null,
            global::System.Func<global::TwelveLabs.EmbeddingTaskMediaMetadataVariant3, TResult>? embeddingTaskMediaMetadataVariant3 = null,
            global::System.Func<global::TwelveLabs.EmbeddingTaskMediaMetadataVariant4, TResult>? embeddingTaskMediaMetadataVariant4 = null,
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
            else if (IsEmbeddingTaskMediaMetadataVariant3 && embeddingTaskMediaMetadataVariant3 != null)
            {
                return embeddingTaskMediaMetadataVariant3(EmbeddingTaskMediaMetadataVariant3!);
            }
            else if (IsEmbeddingTaskMediaMetadataVariant4 && embeddingTaskMediaMetadataVariant4 != null)
            {
                return embeddingTaskMediaMetadataVariant4(EmbeddingTaskMediaMetadataVariant4!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::TwelveLabs.EmbeddingTaskMediaMetadataVariant1>? embeddingTaskMediaMetadataVariant1 = null,

            global::System.Action<global::TwelveLabs.EmbeddingTaskMediaMetadataVariant2>? embeddingTaskMediaMetadataVariant2 = null,

            global::System.Action<global::TwelveLabs.EmbeddingTaskMediaMetadataVariant3>? embeddingTaskMediaMetadataVariant3 = null,

            global::System.Action<global::TwelveLabs.EmbeddingTaskMediaMetadataVariant4>? embeddingTaskMediaMetadataVariant4 = null,
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
            else if (IsEmbeddingTaskMediaMetadataVariant3)
            {
                embeddingTaskMediaMetadataVariant3?.Invoke(EmbeddingTaskMediaMetadataVariant3!);
            }
            else if (IsEmbeddingTaskMediaMetadataVariant4)
            {
                embeddingTaskMediaMetadataVariant4?.Invoke(EmbeddingTaskMediaMetadataVariant4!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::TwelveLabs.EmbeddingTaskMediaMetadataVariant1>? embeddingTaskMediaMetadataVariant1 = null,
            global::System.Action<global::TwelveLabs.EmbeddingTaskMediaMetadataVariant2>? embeddingTaskMediaMetadataVariant2 = null,
            global::System.Action<global::TwelveLabs.EmbeddingTaskMediaMetadataVariant3>? embeddingTaskMediaMetadataVariant3 = null,
            global::System.Action<global::TwelveLabs.EmbeddingTaskMediaMetadataVariant4>? embeddingTaskMediaMetadataVariant4 = null,
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
            else if (IsEmbeddingTaskMediaMetadataVariant3)
            {
                embeddingTaskMediaMetadataVariant3?.Invoke(EmbeddingTaskMediaMetadataVariant3!);
            }
            else if (IsEmbeddingTaskMediaMetadataVariant4)
            {
                embeddingTaskMediaMetadataVariant4?.Invoke(EmbeddingTaskMediaMetadataVariant4!);
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
                EmbeddingTaskMediaMetadataVariant3,
                typeof(global::TwelveLabs.EmbeddingTaskMediaMetadataVariant3),
                EmbeddingTaskMediaMetadataVariant4,
                typeof(global::TwelveLabs.EmbeddingTaskMediaMetadataVariant4),
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
                global::System.Collections.Generic.EqualityComparer<global::TwelveLabs.EmbeddingTaskMediaMetadataVariant2?>.Default.Equals(EmbeddingTaskMediaMetadataVariant2, other.EmbeddingTaskMediaMetadataVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::TwelveLabs.EmbeddingTaskMediaMetadataVariant3?>.Default.Equals(EmbeddingTaskMediaMetadataVariant3, other.EmbeddingTaskMediaMetadataVariant3) &&
                global::System.Collections.Generic.EqualityComparer<global::TwelveLabs.EmbeddingTaskMediaMetadataVariant4?>.Default.Equals(EmbeddingTaskMediaMetadataVariant4, other.EmbeddingTaskMediaMetadataVariant4)
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
