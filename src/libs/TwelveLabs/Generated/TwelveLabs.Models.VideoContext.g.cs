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
        ///
        /// </summary>
        public global::TwelveLabs.VideoContextDiscriminatorType? Type { get; }

        /// <summary>
        /// Provide the video via a URL.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::TwelveLabs.VideoContextVariant1? Url { get; init; }
#else
        public global::TwelveLabs.VideoContextVariant1? Url { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Url))]
#endif
        public bool IsUrl => Url != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickUrl(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::TwelveLabs.VideoContextVariant1? value)
        {
            value = Url;
            return IsUrl;
        }

        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoContextVariant1 PickUrl() => IsUrl
            ? Url!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Url' but the value was {ToString()}.");

        /// <summary>
        /// Provide the video via a unique identifier of an asset.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::TwelveLabs.VideoContextVariant2? AssetId { get; init; }
#else
        public global::TwelveLabs.VideoContextVariant2? AssetId { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AssetId))]
#endif
        public bool IsAssetId => AssetId != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAssetId(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::TwelveLabs.VideoContextVariant2? value)
        {
            value = AssetId;
            return IsAssetId;
        }

        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoContextVariant2 PickAssetId() => IsAssetId
            ? AssetId!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AssetId' but the value was {ToString()}.");

        /// <summary>
        /// Provide the video via base64-encoded data.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::TwelveLabs.VideoContextVariant3? Base64String { get; init; }
#else
        public global::TwelveLabs.VideoContextVariant3? Base64String { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Base64String))]
#endif
        public bool IsBase64String => Base64String != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBase64String(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::TwelveLabs.VideoContextVariant3? value)
        {
            value = Base64String;
            return IsBase64String;
        }

        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoContextVariant3 PickBase64String() => IsBase64String
            ? Base64String!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Base64String' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator VideoContext(global::TwelveLabs.VideoContextVariant1 value) => new VideoContext((global::TwelveLabs.VideoContextVariant1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::TwelveLabs.VideoContextVariant1?(VideoContext @this) => @this.Url;

        /// <summary>
        ///
        /// </summary>
        public VideoContext(global::TwelveLabs.VideoContextVariant1? value)
        {
            Url = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static VideoContext FromUrl(global::TwelveLabs.VideoContextVariant1? value) => new VideoContext(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator VideoContext(global::TwelveLabs.VideoContextVariant2 value) => new VideoContext((global::TwelveLabs.VideoContextVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::TwelveLabs.VideoContextVariant2?(VideoContext @this) => @this.AssetId;

        /// <summary>
        ///
        /// </summary>
        public VideoContext(global::TwelveLabs.VideoContextVariant2? value)
        {
            AssetId = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static VideoContext FromAssetId(global::TwelveLabs.VideoContextVariant2? value) => new VideoContext(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator VideoContext(global::TwelveLabs.VideoContextVariant3 value) => new VideoContext((global::TwelveLabs.VideoContextVariant3?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::TwelveLabs.VideoContextVariant3?(VideoContext @this) => @this.Base64String;

        /// <summary>
        ///
        /// </summary>
        public VideoContext(global::TwelveLabs.VideoContextVariant3? value)
        {
            Base64String = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static VideoContext FromBase64String(global::TwelveLabs.VideoContextVariant3? value) => new VideoContext(value);

        /// <summary>
        ///
        /// </summary>
        public VideoContext(
            global::TwelveLabs.VideoContextDiscriminatorType? type,
            global::TwelveLabs.VideoContextVariant1? url,
            global::TwelveLabs.VideoContextVariant2? assetId,
            global::TwelveLabs.VideoContextVariant3? base64String
            )
        {
            Type = type;

            Url = url;
            AssetId = assetId;
            Base64String = base64String;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Base64String as object ??
            AssetId as object ??
            Url as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Url?.ToString() ??
            AssetId?.ToString() ??
            Base64String?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsUrl && !IsAssetId && !IsBase64String || !IsUrl && IsAssetId && !IsBase64String || !IsUrl && !IsAssetId && IsBase64String;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::TwelveLabs.VideoContextVariant1, TResult>? url = null,
            global::System.Func<global::TwelveLabs.VideoContextVariant2, TResult>? assetId = null,
            global::System.Func<global::TwelveLabs.VideoContextVariant3, TResult>? base64String = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUrl && url != null)
            {
                return url(Url!);
            }
            else if (IsAssetId && assetId != null)
            {
                return assetId(AssetId!);
            }
            else if (IsBase64String && base64String != null)
            {
                return base64String(Base64String!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::TwelveLabs.VideoContextVariant1>? url = null,

            global::System.Action<global::TwelveLabs.VideoContextVariant2>? assetId = null,

            global::System.Action<global::TwelveLabs.VideoContextVariant3>? base64String = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUrl)
            {
                url?.Invoke(Url!);
            }
            else if (IsAssetId)
            {
                assetId?.Invoke(AssetId!);
            }
            else if (IsBase64String)
            {
                base64String?.Invoke(Base64String!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::TwelveLabs.VideoContextVariant1>? url = null,
            global::System.Action<global::TwelveLabs.VideoContextVariant2>? assetId = null,
            global::System.Action<global::TwelveLabs.VideoContextVariant3>? base64String = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUrl)
            {
                url?.Invoke(Url!);
            }
            else if (IsAssetId)
            {
                assetId?.Invoke(AssetId!);
            }
            else if (IsBase64String)
            {
                base64String?.Invoke(Base64String!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Url,
                typeof(global::TwelveLabs.VideoContextVariant1),
                AssetId,
                typeof(global::TwelveLabs.VideoContextVariant2),
                Base64String,
                typeof(global::TwelveLabs.VideoContextVariant3),
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
                global::System.Collections.Generic.EqualityComparer<global::TwelveLabs.VideoContextVariant1?>.Default.Equals(Url, other.Url) &&
                global::System.Collections.Generic.EqualityComparer<global::TwelveLabs.VideoContextVariant2?>.Default.Equals(AssetId, other.AssetId) &&
                global::System.Collections.Generic.EqualityComparer<global::TwelveLabs.VideoContextVariant3?>.Default.Equals(Base64String, other.Base64String)
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
