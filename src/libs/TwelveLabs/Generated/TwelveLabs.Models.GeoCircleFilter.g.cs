
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Narrows results to items captured within a circle. An item matches when the GPS coordinates embedded in its source media are within `radius_meters` of the center, measured as &lt;a href="https://en.wikipedia.org/wiki/Great-circle_distance" target="_blank"&gt;great-circle distance&lt;/a&gt;. Items with no coordinates never match. To read the GPS coordinates of the source media, use the [`GET`](/v1.3/api-reference/manage-assets/retrieve) method of the `/assets/{asset_id}` endpoint. The coordinates are the `geospatial_latitude` and `geospatial_longitude` fields of the `technical_metadata` object.<br/>
    /// If the circle matches more than 10,000 items, the platform returns a `422` error with the `metadata_filter_too_broad` code.
    /// </summary>
    public sealed partial class GeoCircleFilter
    {
        /// <summary>
        /// The latitude of the center, in decimal degrees. The value must be between -90 and 90.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latitude")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Latitude { get; set; }

        /// <summary>
        /// The longitude of the center, in decimal degrees. The value must be between -180 and 180.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("longitude")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Longitude { get; set; }

        /// <summary>
        /// The radius of the circle, in meters. The value must be greater than 0 and at most 20,037,508.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("radius_meters")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double RadiusMeters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GeoCircleFilter" /> class.
        /// </summary>
        /// <param name="latitude">
        /// The latitude of the center, in decimal degrees. The value must be between -90 and 90.
        /// </param>
        /// <param name="longitude">
        /// The longitude of the center, in decimal degrees. The value must be between -180 and 180.
        /// </param>
        /// <param name="radiusMeters">
        /// The radius of the circle, in meters. The value must be greater than 0 and at most 20,037,508.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GeoCircleFilter(
            double latitude,
            double longitude,
            double radiusMeters)
        {
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.RadiusMeters = radiusMeters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GeoCircleFilter" /> class.
        /// </summary>
        public GeoCircleFilter()
        {
        }

    }
}