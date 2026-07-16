#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// A single result in the search response. The fields present depend on the `asset_type` field.
    /// </summary>
    public readonly partial struct SearchKnowledgeStoreHit : global::System.IEquatable<SearchKnowledgeStoreHit>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::TwelveLabs.SearchKnowledgeStoreHitDiscriminatorAssetType? AssetType { get; }

        /// <summary>
        /// A search result for a video.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::TwelveLabs.SearchKnowledgeStoreHitVariant1? Video { get; init; }
#else
        public global::TwelveLabs.SearchKnowledgeStoreHitVariant1? Video { get; }
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
            out global::TwelveLabs.SearchKnowledgeStoreHitVariant1? value)
        {
            value = Video;
            return IsVideo;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::TwelveLabs.SearchKnowledgeStoreHitVariant1 PickVideo() => IsVideo
            ? Video!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Video' but the value was {ToString()}.");

        /// <summary>
        /// A search result for an image. An image matches as a whole object and has no time range.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::TwelveLabs.SearchKnowledgeStoreHitVariant2? Image { get; init; }
#else
        public global::TwelveLabs.SearchKnowledgeStoreHitVariant2? Image { get; }
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
            out global::TwelveLabs.SearchKnowledgeStoreHitVariant2? value)
        {
            value = Image;
            return IsImage;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::TwelveLabs.SearchKnowledgeStoreHitVariant2 PickImage() => IsImage
            ? Image!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Image' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SearchKnowledgeStoreHit(global::TwelveLabs.SearchKnowledgeStoreHitVariant1 value) => new SearchKnowledgeStoreHit((global::TwelveLabs.SearchKnowledgeStoreHitVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::TwelveLabs.SearchKnowledgeStoreHitVariant1?(SearchKnowledgeStoreHit @this) => @this.Video;

        /// <summary>
        /// 
        /// </summary>
        public SearchKnowledgeStoreHit(global::TwelveLabs.SearchKnowledgeStoreHitVariant1? value)
        {
            Video = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static SearchKnowledgeStoreHit FromVideo(global::TwelveLabs.SearchKnowledgeStoreHitVariant1? value) => new SearchKnowledgeStoreHit(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SearchKnowledgeStoreHit(global::TwelveLabs.SearchKnowledgeStoreHitVariant2 value) => new SearchKnowledgeStoreHit((global::TwelveLabs.SearchKnowledgeStoreHitVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::TwelveLabs.SearchKnowledgeStoreHitVariant2?(SearchKnowledgeStoreHit @this) => @this.Image;

        /// <summary>
        /// 
        /// </summary>
        public SearchKnowledgeStoreHit(global::TwelveLabs.SearchKnowledgeStoreHitVariant2? value)
        {
            Image = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static SearchKnowledgeStoreHit FromImage(global::TwelveLabs.SearchKnowledgeStoreHitVariant2? value) => new SearchKnowledgeStoreHit(value);

        /// <summary>
        /// 
        /// </summary>
        public SearchKnowledgeStoreHit(
            global::TwelveLabs.SearchKnowledgeStoreHitDiscriminatorAssetType? assetType,
            global::TwelveLabs.SearchKnowledgeStoreHitVariant1? video,
            global::TwelveLabs.SearchKnowledgeStoreHitVariant2? image
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
            global::System.Func<global::TwelveLabs.SearchKnowledgeStoreHitVariant1, TResult>? video = null,
            global::System.Func<global::TwelveLabs.SearchKnowledgeStoreHitVariant2, TResult>? image = null,
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
            global::System.Action<global::TwelveLabs.SearchKnowledgeStoreHitVariant1>? video = null,

            global::System.Action<global::TwelveLabs.SearchKnowledgeStoreHitVariant2>? image = null,
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
            global::System.Action<global::TwelveLabs.SearchKnowledgeStoreHitVariant1>? video = null,
            global::System.Action<global::TwelveLabs.SearchKnowledgeStoreHitVariant2>? image = null,
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
                typeof(global::TwelveLabs.SearchKnowledgeStoreHitVariant1),
                Image,
                typeof(global::TwelveLabs.SearchKnowledgeStoreHitVariant2),
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
        public bool Equals(SearchKnowledgeStoreHit other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::TwelveLabs.SearchKnowledgeStoreHitVariant1?>.Default.Equals(Video, other.Video) &&
                global::System.Collections.Generic.EqualityComparer<global::TwelveLabs.SearchKnowledgeStoreHitVariant2?>.Default.Equals(Image, other.Image) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(SearchKnowledgeStoreHit obj1, SearchKnowledgeStoreHit obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SearchKnowledgeStoreHit>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(SearchKnowledgeStoreHit obj1, SearchKnowledgeStoreHit obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SearchKnowledgeStoreHit o && Equals(o);
        }
    }
}
