#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// System-generated media metadata for the source asset. Its `asset_type` field<br/>
    /// always matches the item's top-level `asset_type` field.
    /// </summary>
    public readonly partial struct KnowledgeStoreItemSystemMetadata : global::System.IEquatable<KnowledgeStoreItemSystemMetadata>
    {
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.KnowledgeStoreItemSystemMetadataDiscriminatorAssetType? AssetType { get; }

        /// <summary>
        /// System-generated media metadata for a video item.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::TwelveLabs.KnowledgeStoreItemSystemMetadataVariant1? Video { get; init; }
#else
        public global::TwelveLabs.KnowledgeStoreItemSystemMetadataVariant1? Video { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Video))]
#endif
        public bool IsVideo => Video != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickVideo(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::TwelveLabs.KnowledgeStoreItemSystemMetadataVariant1? value)
        {
            value = Video;
            return IsVideo;
        }

        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.KnowledgeStoreItemSystemMetadataVariant1 PickVideo() => IsVideo
            ? Video!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Video' but the value was {ToString()}.");

        /// <summary>
        /// System-generated media metadata for an image item.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::TwelveLabs.KnowledgeStoreItemSystemMetadataVariant2? Image { get; init; }
#else
        public global::TwelveLabs.KnowledgeStoreItemSystemMetadataVariant2? Image { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Image))]
#endif
        public bool IsImage => Image != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickImage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::TwelveLabs.KnowledgeStoreItemSystemMetadataVariant2? value)
        {
            value = Image;
            return IsImage;
        }

        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.KnowledgeStoreItemSystemMetadataVariant2 PickImage() => IsImage
            ? Image!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Image' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator KnowledgeStoreItemSystemMetadata(global::TwelveLabs.KnowledgeStoreItemSystemMetadataVariant1 value) => new KnowledgeStoreItemSystemMetadata((global::TwelveLabs.KnowledgeStoreItemSystemMetadataVariant1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::TwelveLabs.KnowledgeStoreItemSystemMetadataVariant1?(KnowledgeStoreItemSystemMetadata @this) => @this.Video;

        /// <summary>
        ///
        /// </summary>
        public KnowledgeStoreItemSystemMetadata(global::TwelveLabs.KnowledgeStoreItemSystemMetadataVariant1? value)
        {
            Video = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static KnowledgeStoreItemSystemMetadata FromVideo(global::TwelveLabs.KnowledgeStoreItemSystemMetadataVariant1? value) => new KnowledgeStoreItemSystemMetadata(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator KnowledgeStoreItemSystemMetadata(global::TwelveLabs.KnowledgeStoreItemSystemMetadataVariant2 value) => new KnowledgeStoreItemSystemMetadata((global::TwelveLabs.KnowledgeStoreItemSystemMetadataVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::TwelveLabs.KnowledgeStoreItemSystemMetadataVariant2?(KnowledgeStoreItemSystemMetadata @this) => @this.Image;

        /// <summary>
        ///
        /// </summary>
        public KnowledgeStoreItemSystemMetadata(global::TwelveLabs.KnowledgeStoreItemSystemMetadataVariant2? value)
        {
            Image = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static KnowledgeStoreItemSystemMetadata FromImage(global::TwelveLabs.KnowledgeStoreItemSystemMetadataVariant2? value) => new KnowledgeStoreItemSystemMetadata(value);

        /// <summary>
        ///
        /// </summary>
        public KnowledgeStoreItemSystemMetadata(
            global::TwelveLabs.KnowledgeStoreItemSystemMetadataDiscriminatorAssetType? assetType,
            global::TwelveLabs.KnowledgeStoreItemSystemMetadataVariant1? video,
            global::TwelveLabs.KnowledgeStoreItemSystemMetadataVariant2? image
            )
        {
            AssetType = assetType;

            Video = video;
            Image = image;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Image as object ??
            Video as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Video?.ToString() ??
            Image?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsVideo && !IsImage || !IsVideo && IsImage;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::TwelveLabs.KnowledgeStoreItemSystemMetadataVariant1, TResult>? video = null,
            global::System.Func<global::TwelveLabs.KnowledgeStoreItemSystemMetadataVariant2, TResult>? image = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsVideo && video != null)
            {
                return video(Video!);
            }
            else if (IsImage && image != null)
            {
                return image(Image!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::TwelveLabs.KnowledgeStoreItemSystemMetadataVariant1>? video = null,

            global::System.Action<global::TwelveLabs.KnowledgeStoreItemSystemMetadataVariant2>? image = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsVideo)
            {
                video?.Invoke(Video!);
            }
            else if (IsImage)
            {
                image?.Invoke(Image!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::TwelveLabs.KnowledgeStoreItemSystemMetadataVariant1>? video = null,
            global::System.Action<global::TwelveLabs.KnowledgeStoreItemSystemMetadataVariant2>? image = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsVideo)
            {
                video?.Invoke(Video!);
            }
            else if (IsImage)
            {
                image?.Invoke(Image!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Video,
                typeof(global::TwelveLabs.KnowledgeStoreItemSystemMetadataVariant1),
                Image,
                typeof(global::TwelveLabs.KnowledgeStoreItemSystemMetadataVariant2),
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
        public bool Equals(KnowledgeStoreItemSystemMetadata other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::TwelveLabs.KnowledgeStoreItemSystemMetadataVariant1?>.Default.Equals(Video, other.Video) &&
                global::System.Collections.Generic.EqualityComparer<global::TwelveLabs.KnowledgeStoreItemSystemMetadataVariant2?>.Default.Equals(Image, other.Image)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(KnowledgeStoreItemSystemMetadata obj1, KnowledgeStoreItemSystemMetadata obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<KnowledgeStoreItemSystemMetadata>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(KnowledgeStoreItemSystemMetadata obj1, KnowledgeStoreItemSystemMetadata obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is KnowledgeStoreItemSystemMetadata o && Equals(o);
        }
    }
}
