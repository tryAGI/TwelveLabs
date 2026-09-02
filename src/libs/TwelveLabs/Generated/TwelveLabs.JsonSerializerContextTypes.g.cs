
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace TwelveLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        /// Runtime object lists used by dynamic JSON payloads such as tool arguments.
        /// </summary>
        public global::System.Collections.Generic.List<object>? ObjectList { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AssetsPostRequestBodyContentMultipartFormDataSchemaMethod? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AssetMethod? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AssetStatus? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.UserMetadata? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AssetSourceType? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AssetSourceDetailsProvider? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AssetSourceDetails? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AssetSource? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.Asset? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateAssetRequestBadRequestError? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateAssetUploadRequestType? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateAssetUploadRequest? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public long? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.PresignedURLChunk? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateAssetUploadResponse? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.PresignedURLChunk>? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateMultipartUploadRequestBadRequestError? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateMultipartUploadRequestForbiddenError? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateMultipartUploadRequestInternalServerError? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.MultipartUploadStatusType? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ChunkInfoStatus? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ChunkInfo? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.PageInfo? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.GetUploadStatusResponse? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.ChunkInfo>? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.GetUploadStatusRequestBadRequestError? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.GetUploadStatusRequestForbiddenError? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.GetUploadStatusRequestInternalServerError? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IncompleteUploadSummary? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListIncompleteUploadsResponse? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.IncompleteUploadSummary>? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListIncompleteUploadsRequestBadRequestError? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListIncompleteUploadsRequestForbiddenError? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListIncompleteUploadsRequestInternalServerError? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CompletedChunkProofType? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CompletedChunk? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ReportChunkBatchRequest? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.CompletedChunk>? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ReportChunkBatchResponse? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ReportChunkBatchRequestBadRequestError? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ReportChunkBatchRequestForbiddenError? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RequestAdditionalPresignedURLsRequest? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RequestAdditionalPresignedURLsResponse? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RequestAdditionalPresignedUrlsRequestBadRequestError? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RequestAdditionalPresignedUrlsRequestForbiddenError? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RequestAdditionalPresignedUrlsRequestInternalServerError? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AssetDetailMethod? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AssetDetailStatus? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AssetHlsStatus? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AssetHLS? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AssetThumbnailStatus? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AssetThumbnail? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoStream? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AudioStream? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TechnicalMetadata? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.VideoStream>? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AudioStream>? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AssetError? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AssetDetail? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RetrieveAssetRequestBadRequestError? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RetrieveAssetRequestNotFoundError? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AssetsGetParametersAssetTypesSchemaItems? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AssetsListResponse200? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AssetDetail>? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListAssetsRequestBadRequestError? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DeleteAssetRequestBadRequestError? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DeleteAssetRequestConflictError? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.UpdateAssetUserMetadataRequestBadRequestError? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.UpdateAssetUserMetadataRequestNotFoundError? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ReplaceAssetUserMetadataRequestBadRequestError? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ReplaceAssetUserMetadataRequestNotFoundError? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DeleteAssetUserMetadataRequestBadRequestError? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DeleteAssetUserMetadataRequestNotFoundError? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AssetsAssetIdTranscriptionGetParametersIncludeSchemaItems? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AssetTranscriptionStatus? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AssetTranscriptionEntry? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AssetTranscriptionUtterance? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AssetTranscriptionError? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AssetTranscriptionResponse? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AssetTranscriptionEntry>? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AssetTranscriptionUtterance>? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RetrieveAssetTranscriptionRequestBadRequestError? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RetrieveAssetTranscriptionRequestNotFoundError? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ConnectionsAuthorizePostRequestBodyContentApplicationJsonSchemaProvider? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DataConnectorsAuthorizeConnectionResponse200? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AuthorizeConnectionRequestBadRequestError? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ConnectionProvider? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ConnectionStatus? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ConnectionAccount? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.Connection? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DataConnectorsListConnectionsResponse200? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.Connection>? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListConnectionsRequestBadRequestError? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RetrieveConnectionRequestBadRequestError? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RetrieveConnectionRequestNotFoundError? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DeleteConnectionRequestBadRequestError? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DeleteConnectionRequestNotFoundError? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DataConnectorsCreateConnectionPickerTokenResponse200? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateConnectionPickerTokenRequestBadRequestError? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateConnectionPickerTokenRequestNotFoundError? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateConnectionPickerTokenRequestConflictError? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RedirectUri? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateRedirectUriRequestBadRequestError? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateRedirectUriRequestConflictError? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateRedirectUriRequestUnprocessableEntityError? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DataConnectorsListRedirectUrisResponse200? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.RedirectUri>? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListRedirectUrisRequestBadRequestError? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DeleteRedirectUriRequestBadRequestError? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DeleteRedirectUriRequestNotFoundError? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ConnectionsConnectionIdImportsPostRequestBodyContentApplicationJsonSchemaItemsItems? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ImportItemAction? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ImportItemStatus? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ImportItemError? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ImportItem? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ImportResult? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.ImportItem>? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ImportFilesRequestBadRequestError? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ImportFilesRequestNotFoundError? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ImportFilesRequestConflictError? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ImportProvider? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.Import? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ImportsListImportsResponse200? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.Import>? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListImportsRequestBadRequestError? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListImportsRequestNotFoundError? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ImportDetailProvider? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ImportDetail? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RetrieveImportRequestBadRequestError? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RetrieveImportRequestNotFoundError? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EntityCollectionsGetParametersSortBy? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EntityCollection? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EntityCollectionsListResponse200? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.EntityCollection>? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListEntityCollectionsRequestBadRequestError? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateEntityCollectionRequestBadRequestError? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RetrieveEntityCollectionRequestBadRequestError? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.UpdateEntityCollectionRequestBadRequestError? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DeleteEntityCollectionRequestBadRequestError? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EntityCollectionsEntityCollectionIdEntitiesGetParametersStatus? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EntityCollectionsEntityCollectionIdEntitiesGetParametersSortBy? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EntityMetadata? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EntityStatus? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.Entity? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EntityCollectionsEntitiesListResponse200? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.Entity>? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListEntitiesInCollectionRequestBadRequestError? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EntityCollectionsEntityCollectionIdEntitiesPostRequestBodyContentApplicationJsonSchemaMetadata? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateEntityRequestBadRequestError? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EntityCollectionsEntityCollectionIdEntitiesBulkPostRequestBodyContentApplicationJsonSchemaEntitiesItemsMetadata? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EntityCollectionsEntityCollectionIdEntitiesBulkPostRequestBodyContentApplicationJsonSchemaEntitiesItems? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.BulkCreateEntityResponseEntitiesItems? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.BulkCreateEntityResponseErrorsItems? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.BulkCreateEntityResponse? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.BulkCreateEntityResponseEntitiesItems>? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.BulkCreateEntityResponseErrorsItems>? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateEntitiesBulkRequestBadRequestError? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RetrieveEntityRequestBadRequestError? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EntityCollectionsEntityCollectionIdEntitiesEntityIdPatchRequestBodyContentApplicationJsonSchemaMetadata? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.UpdateEntityRequestBadRequestError? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DeleteEntityRequestBadRequestError? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AddEntityAssetsRequestBadRequestError? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RemoveEntityAssetsRequestBadRequestError? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EntityCollectionsEntitiesListByAssetResponse200? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListEntitiesByAssetRequestBadRequestError? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EnrichmentConfigJsonSchemaType? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EnrichmentConfigJsonSchemaJsonSchemaType? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EnrichmentConfigJsonSchemaJsonSchema? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EnrichmentConfigDescriptionType? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EnrichmentConfig? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EnrichmentConfigVariant1? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EnrichmentConfigVariant2? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EnrichmentConfigDiscriminator? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EnrichmentConfigDiscriminatorType? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IngestionConfig? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.KnowledgeStoreMetadataValue? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.KnowledgeStore? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateKnowledgeStoreRequestBadRequestError? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.KnowledgeStoresGetParametersSortBy? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.KnowledgeStoresListResponse200? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.KnowledgeStore>? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListKnowledgeStoresRequestBadRequestError? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RetrieveKnowledgeStoreRequestBadRequestError? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.UpdateKnowledgeStoreRequestBadRequestError? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DeleteKnowledgeStoreRequestBadRequestError? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.KnowledgeStoreSearchQuery? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.KnowledgeStoreItemAssetType? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AssetTypeFilter? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.KnowledgeStoreItemAssetType>? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ItemIdFilter? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchKnowledgeStoreFilter? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoSearchModality? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoSearchOptions? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.VideoSearchModality>? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchKnowledgeStoreOptions? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchKnowledgeStoreRequestGroupBy? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchKnowledgeStoreRequest? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoSearchSystemMetadata? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoSearchItemMetadata? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoMatch? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ImageSearchSystemMetadata? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ImageSearchItemMetadata? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchKnowledgeStoreHit? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchKnowledgeStoreHitVariant1? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchKnowledgeStoreHitVariant1AssetType? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.VideoMatch>? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchKnowledgeStoreHitVariant2? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchKnowledgeStoreHitVariant2AssetType? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchKnowledgeStoreHitDiscriminator? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchKnowledgeStoreHitDiscriminatorAssetType? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchKnowledgeStoreResponse? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.SearchKnowledgeStoreHit>? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchKnowledgeStoreRequestBadRequestError? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchKnowledgeStoreRequestNotFoundError? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchKnowledgeStoreRequestGoneError? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.KnowledgeStoreItemStatus? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoMetadataAssetType? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ImageMetadataAssetType? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.KnowledgeStoreItemSystemMetadata? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.KnowledgeStoreItemSystemMetadataVariant1? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.KnowledgeStoreItemSystemMetadataVariant2? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.KnowledgeStoreItemSystemMetadataDiscriminator? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.KnowledgeStoreItemSystemMetadataDiscriminatorAssetType? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.KnowledgeStoreItem? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateKnowledgeStoreItemRequestBadRequestError? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.KnowledgeStoresKnowledgeStoreIdItemsGetParametersSortBy? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.KnowledgeStoresKnowledgeStoreIdItemsGetParametersStatusSchemaItems? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.KnowledgeStoreItemsListResponse200? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.KnowledgeStoreItem>? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListKnowledgeStoreItemsRequestBadRequestError? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RetrieveKnowledgeStoreItemRequestBadRequestError? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DeleteKnowledgeStoreItemRequestBadRequestError? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.KnowledgeStoreItemCollection? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateKnowledgeStoreItemCollectionRequestBadRequestError? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.KnowledgeStoresKnowledgeStoreIdItemCollectionsGetParametersSortBy? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.KnowledgeStoreItemCollectionsListResponse200? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.KnowledgeStoreItemCollection>? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListKnowledgeStoreItemCollectionsRequestBadRequestError? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RetrieveKnowledgeStoreItemCollectionRequestBadRequestError? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.UpdateKnowledgeStoreItemCollectionRequestBadRequestError? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DeleteKnowledgeStoreItemCollectionRequestBadRequestError? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.KnowledgeStoreItemCollectionsListItemsResponse200? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListKnowledgeStoreItemCollectionItemsRequestBadRequestError? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AddItemsToKnowledgeStoreItemCollectionRequestBadRequestError? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RemoveItemsFromKnowledgeStoreItemCollectionRequestBadRequestError? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseInputItemType? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseInputItemRole? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseInputItem? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponsesPostRequestBodyContentApplicationJsonSchemaIncludeItems? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseSelectionKind? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseSelection? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TextResponseFormatTextType? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TextResponseFormatJsonSchemaType? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TextParamFormat? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TextParamFormatVariant1? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TextParamFormatVariant2? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TextParamFormatDiscriminator? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TextParamFormatDiscriminatorType? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TextParam? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseObjectType? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseObjectObject? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStatus? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseIncompleteDetails? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseOutputItemType? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseOutputItemRole? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseOutputContentPartType? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseAnnotationType? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseAnnotation? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseOutputContentPart? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.ResponseAnnotation>? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseOutputItem? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.ResponseOutputContentPart>? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseUsage? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseObject? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.ResponseOutputItem>? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateResponseRequestBadRequestError? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamResponseEventType? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamOutputItemAddedEventType? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamContentPartAddedEventType? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamOutputTextDeltaEventType? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamOutputTextDoneEventType? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamContentPartDoneEventType? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamOutputItemDoneEventType? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamFuncCallArgsDoneEventType? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamEvent? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamEventVariant1? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamEventVariant2? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamEventVariant3? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamEventVariant4? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamEventVariant5? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamEventVariant6? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamEventVariant7? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamEventVariant8? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamEventVariant9? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamEventVariant10? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamEventVariant11? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamEventDiscriminator? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamEventDiscriminatorType? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesPostRequestBodyContentApplicationJsonSchemaModelsItemsModelName? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesPostRequestBodyContentApplicationJsonSchemaModelsItems? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesCreateResponse201? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateIndexRequestBadRequestError? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexModelsItems? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.Index? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.IndexModelsItems>? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesListResponse200? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.Index>? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListIndexesRequestBadRequestError? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RetrieveIndexRequestBadRequestError? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.UpdateIndexRequestBadRequestError? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DeleteIndexRequestBadRequestError? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesIndexedAssetsCreateResponse202? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateIndexedAssetRequestBadRequestError? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateIndexedAssetRequestNotFoundError? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateIndexedAssetRequestInternalServerError? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesIndexIdIndexedAssetsIndexedAssetIdGetParametersEmbeddingOptionSchemaItems? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexedAssetDetailedStatus? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexedAssetDetailedSystemMetadata? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.HlsObjectStatus? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.HLSObject? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoSegment? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<double>? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexedAssetDetailedEmbeddingVideoEmbedding? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.VideoSegment>? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexedAssetDetailedEmbedding? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TranscriptionDataItems? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.TranscriptionDataItems>? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexedAssetDetailed? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RetrieveIndexedAssetInformationRequestBadRequestError? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RetrieveIndexedAssetInformationRequestNotFoundError? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesIndexIdIndexedAssetsGetParametersStatusSchemaItems? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesIndexIdIndexedAssetsGetParametersDuration? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesIndexIdIndexedAssetsGetParametersFps? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesIndexIdIndexedAssetsGetParametersWidth? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesIndexIdIndexedAssetsGetParametersHeight? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesIndexIdIndexedAssetsGetParametersSize? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesIndexIdIndexedAssetsGetParametersUserMetadataSchema? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexedAssetStatus? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexedAssetSystemMetadata? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexedAsset? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesIndexedAssetsListResponse200? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.IndexedAsset>? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListIndexedAssetsRequestBadRequestError? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DeleteIndexedAssetInformationRequestBadRequestError? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.PartialUpdateIndexedAssetInformationRequestBadRequestError? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexedAssetSummaryIndex? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexedAssetSummary? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesIndexedAssetsListByAssetResponse200? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.IndexedAssetSummary>? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListIndexedAssetsByAssetRequestBadRequestError? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesIndexIdVideosGetParametersDuration? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesIndexIdVideosGetParametersFps? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesIndexIdVideosGetParametersWidth? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesIndexIdVideosGetParametersHeight? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesIndexIdVideosGetParametersSize? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesIndexIdVideosGetParametersUserMetadataSchema? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoVectorSystemMetadata? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoVector? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesVideosListResponse200? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.VideoVector>? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListVideosRequestBadRequestError? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesIndexIdVideosVideoIdGetParametersEmbeddingOptionSchemaItems? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesIndexIdVideosVideoIdGetResponsesContentApplicationJsonSchemaSystemMetadata? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesIndexIdVideosVideoIdGetResponsesContentApplicationJsonSchemaEmbeddingVideoEmbedding? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesIndexIdVideosVideoIdGetResponsesContentApplicationJsonSchemaEmbedding? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesVideosRetrieveResponse200? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RetrieveVideoInformationRequestBadRequestError? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RetrieveVideoInformationRequestNotFoundError? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.PartialUpdateVideoInformationRequestBadRequestError? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DeleteVideoInformationRequestBadRequestError? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TasksCreateResponse200? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateVideoIndexingTaskRequestBadRequestError? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TasksGetParametersStatusSchemaItems? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoIndexingTaskSystemMetadata? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoIndexingTask? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TasksGetResponsesContentApplicationJsonSchemaPageInfo? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TasksListResponse200? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.VideoIndexingTask>? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListVideoIndexingTasksRequestBadRequestError? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TasksTaskIdGetResponsesContentApplicationJsonSchemaSystemMetadata? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TasksRetrieveResponse200? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RetrieveVideoIndexingTaskRequestBadRequestError? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DeleteVideoIndexingTaskRequestBadRequestError? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaType? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaUrl? Type392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaFile? Type393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<byte[]>? Type395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaSearchOptionsItems? Type396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaTranscriptionOptionsItems? Type397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaGroupBy? Type398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaOperator? Type399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchItemClipsItems? Type400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchItem? Type401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.SearchItemClipsItems>? Type402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchResultsPageInfo? Type403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchPool? Type404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchResults? Type405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.SearchItem>? Type406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnyToVideoSearchRequestBadRequestError? Type407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchPageTokenGetResponsesContentApplicationJsonSchemaPageInfo? Type408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchRetrieveResponse200? Type409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnyToVideoRetrieveSpecificPageRequestBadRequestError? Type410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateEmbeddingsRequestInputType? Type411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateEmbeddingsRequestModelName? Type412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TextInputRequest? Type413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.MediaSource? Type414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ImageInputRequest? Type415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TextImageInputRequest? Type416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AudioSegmentationFixed? Type417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AudioSegmentation? Type418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AudioSegmentationStrategy? Type419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AudioInputRequestEmbeddingOptionItems? Type420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AudioInputRequestEmbeddingScopeItems? Type421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AudioInputRequestEmbeddingTypeItems? Type422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AudioInputRequest? Type423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AudioInputRequestEmbeddingOptionItems>? Type424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AudioInputRequestEmbeddingScopeItems>? Type425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AudioInputRequestEmbeddingTypeItems>? Type426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoSegmentationDiscriminatorMappingDynamicDynamic? Type427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoSegmentationDiscriminatorMappingFixedFixed? Type428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoSegmentation? Type429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoSegmentationVariant1? Type430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoSegmentationVariant1Strategy? Type431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoSegmentationVariant2? Type432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoSegmentationVariant2Strategy? Type433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoSegmentationDiscriminator? Type434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoSegmentationDiscriminatorStrategy? Type435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoInputRequestEmbeddingOptionItems? Type436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoInputRequestEmbeddingScopeItems? Type437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoInputRequestEmbeddingTypeItems? Type438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoInputRequest? Type439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.VideoInputRequestEmbeddingOptionItems>? Type440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.VideoInputRequestEmbeddingScopeItems>? Type441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.VideoInputRequestEmbeddingTypeItems>? Type442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.MultiInputMediaSourceMediaType? Type443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.MultiInputMediaSource? Type444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.MultiInputRequest? Type445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.MultiInputMediaSource>? Type446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateEmbeddingsRequest? Type447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingDataEmbeddingOption? Type448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingDataEmbeddingScope? Type449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingData? Type450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingUsage? Type451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, int>? Type452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingImageMetadataInputType? Type453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingMediaMetadataInputType? Type454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingTextImageMetadataInputType? Type455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingAudioMetadataInputType? Type456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingAudioMetadataEmbeddingScopesItems? Type457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingVideoMetadataInputType? Type458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingVideoMetadataEmbeddingScopesItems? Type459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingMultiInputMetadataInputType? Type460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingMediaMetadata? Type461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingMediaMetadataVariant1? Type462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingMediaMetadataVariant2? Type463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingMediaMetadataVariant3? Type464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.EmbeddingAudioMetadataEmbeddingScopesItems>? Type465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingMediaMetadataVariant4? Type466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.EmbeddingVideoMetadataEmbeddingScopesItems>? Type467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingMediaMetadataVariant5? Type468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingMediaMetadataDiscriminator? Type469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingSuccessResponse? Type470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.EmbeddingData>? Type471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ErrorResponseError? Type472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ErrorResponse? Type473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateAsyncEmbeddingRequestInputType? Type474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateAsyncEmbeddingRequestModelName? Type475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TemporalSegmentationDiscriminatorMappingDynamicDynamic? Type476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TemporalSegmentationDiscriminatorMappingFixedFixed? Type477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TemporalSegmentation? Type478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TemporalSegmentationVariant1? Type479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TemporalSegmentationVariant1Strategy? Type480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TemporalSegmentationVariant2? Type481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TemporalSegmentationVariant2Strategy? Type482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TemporalSegmentationDiscriminator? Type483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TemporalSegmentationDiscriminatorStrategy? Type484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncTemporalSegmentation? Type485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncAudioInputRequestSegmentation? Type486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncAudioInputRequestEmbeddingOptionItems? Type487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncAudioInputRequestEmbeddingScopeItems? Type488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncAudioInputRequestEmbeddingTypeItems? Type489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TimeBasedMetadataEntry? Type490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncAudioInputRequest? Type491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AsyncAudioInputRequestEmbeddingOptionItems>? Type492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AsyncAudioInputRequestEmbeddingScopeItems>? Type493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AsyncAudioInputRequestEmbeddingTypeItems>? Type494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.TimeBasedMetadataEntry>? Type495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncVideoInputRequestSegmentation? Type496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncVideoInputRequestEmbeddingOptionItems? Type497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncVideoInputRequestEmbeddingScopeItems? Type498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncVideoInputRequestEmbeddingTypeItems? Type499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncVideoInputRequest? Type500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AsyncVideoInputRequestEmbeddingOptionItems>? Type501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AsyncVideoInputRequestEmbeddingScopeItems>? Type502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AsyncVideoInputRequestEmbeddingTypeItems>? Type503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncDocumentInputRequestEmbeddingOptionItems? Type504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncDocumentInputRequestEmbeddingTypeItems? Type505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncDocumentInputRequestEmbeddingScopeItems? Type506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncDocumentInputRequest? Type507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AsyncDocumentInputRequestEmbeddingOptionItems>? Type508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AsyncDocumentInputRequestEmbeddingTypeItems>? Type509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AsyncDocumentInputRequestEmbeddingScopeItems>? Type510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncImageInputRequestEmbeddingOptionItems? Type511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncImageInputRequestEmbeddingTypeItems? Type512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncImageInputRequestEmbeddingScopeItems? Type513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncImageInputRequest? Type514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AsyncImageInputRequestEmbeddingOptionItems>? Type515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AsyncImageInputRequestEmbeddingTypeItems>? Type516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AsyncImageInputRequestEmbeddingScopeItems>? Type517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateAsyncEmbeddingRequest? Type518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbedV2TasksPostResponsesContentApplicationJsonSchemaStatus? Type519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbedV2TasksCreateResponse202? Type520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoEmbeddingMetadata? Type521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.MediaEmbeddingTaskVideoEmbedding? Type522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AudioEmbeddingMetadata? Type523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.MediaEmbeddingTaskAudioEmbedding? Type524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DocumentEmbeddingMetadata? Type525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.MediaEmbeddingTaskDocumentEmbedding? Type526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ImageEmbeddingMetadata? Type527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.MediaEmbeddingTaskImageEmbedding? Type528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.MediaEmbeddingTask? Type529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbedV2TasksGetResponsesContentApplicationJsonSchemaPageInfo? Type530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbedV2TasksListResponse200? Type531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.MediaEmbeddingTask>? Type532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListAsyncEmbeddingTasksRequestBadRequestError? Type533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingTaskResponseStatus? Type534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingTaskMediaMetadataInputType? Type535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncDocumentMetadataInputType? Type536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncDocumentMetadataEmbeddingScopesItems? Type537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncImageMetadataInputType? Type538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncImageMetadataEmbeddingScopesItems? Type539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingTaskMediaMetadata? Type540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingTaskMediaMetadataVariant1? Type541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingTaskMediaMetadataVariant2? Type542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingTaskMediaMetadataVariant3? Type543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AsyncDocumentMetadataEmbeddingScopesItems>? Type544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingTaskMediaMetadataVariant4? Type545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AsyncImageMetadataEmbeddingScopesItems>? Type546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingTaskMediaMetadataDiscriminator? Type547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingTaskResponseError? Type548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingTaskResponse? Type549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbedTasksPostRequestBodyContentMultipartFormDataSchemaVideoEmbeddingScopeItems? Type550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbedTasksCreateResponse200? Type551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateVideoEmbeddingTaskRequestBadRequestError? Type552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbedTasksGetResponsesContentApplicationJsonSchemaPageInfo? Type553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbedTasksListResponse200? Type554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListVideoEmbeddingTasksRequestBadRequestError? Type555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbedTasksTaskIdStatusGetResponsesContentApplicationJsonSchemaVideoEmbedding? Type556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbedTasksStatusResponse200? Type557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RetrieveVideoEmbeddingTaskRequestBadRequestError? Type558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbedTasksTaskIdGetParametersEmbeddingOptionSchemaItems? Type559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbedTasksTaskIdGetResponsesContentApplicationJsonSchemaVideoEmbedding? Type560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbedTasksRetrieveResponse200? Type561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RetrieveVideoEmbeddingRequestBadRequestError? Type562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.BaseSegment? Type563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TextEmbeddingResult? Type564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.BaseSegment>? Type565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.BaseEmbeddingMetadata? Type566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ImageEmbeddingResult? Type567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AudioSegment? Type568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AudioEmbeddingResult? Type569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AudioSegment>? Type570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingResponse? Type571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateTextImageAudioEmbeddingRequestBadRequestError? Type572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzePostRequestBodyContentApplicationJsonSchemaModelName? Type573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoContext? Type574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoContextVariant1? Type575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoContextVariant1Type? Type576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoContextVariant2? Type577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoContextVariant2Type? Type578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoContextVariant3? Type579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoContextVariant3Type? Type580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoContextDiscriminator? Type581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoContextDiscriminatorType? Type582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SmeMediaSourceMediaType? Type583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SMEMediaSource? Type584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzePromptV2? Type585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.SMEMediaSource>? Type586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SyncResponseFormatType? Type587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SyncResponseFormatJsonSchema? Type588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SyncResponseFormat? Type589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.StreamStartResponseEventType? Type590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.StreamStartResponseMetadata? Type591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.StreamTextResponseEventType? Type592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.StreamEndResponseEventType? Type593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.FinishReason? Type594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TokenUsage? Type595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.StreamEndResponseMetadata? Type596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskError? Type597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.StreamAnalyzeResponse? Type598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.StreamAnalyzeResponseVariant1? Type599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.StreamAnalyzeResponseVariant2? Type600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.StreamAnalyzeResponseVariant3? Type601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.StreamAnalyzeResponseDiscriminator? Type602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.StreamAnalyzeResponseDiscriminatorEventType? Type603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.NonStreamAnalyzeResponse? Type604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeResponse200? Type605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.GenerateTextRepresentationRequestBadRequestError? Type606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.GenerateTextRepresentationRequestNotFoundError? Type607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateAsyncAnalyzeRequestModelName? Type608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateAsyncAnalyzeRequestAnalysisMode? Type609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncResponseFormatType? Type610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncResponseFormatJsonSchema? Type611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SegmentFieldType? Type612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SegmentFieldFormat? Type613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SegmentFieldItemsType? Type614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SegmentFieldItems? Type615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SegmentField? Type616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTimeRange? Type617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SegmentDefinition? Type618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.SegmentField>? Type619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AnalyzeTimeRange>? Type620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncResponseFormatSegmentTimeFormat? Type621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncResponseFormat? Type622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.SegmentDefinition>? Type623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateAsyncAnalyzeRequest? Type624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskStatus? Type625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateAnalyzeTaskResponse? Type626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTasksGetParametersAnalysisMode? Type627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskResponseVideoSourceType? Type628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskResponseVideoSourceSystemMetadata? Type629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskResponseVideoSource? Type630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskResponseRequestParamsAnalysisMode? Type631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskResponseRequestParamsPromptV2MediaSourcesItems? Type632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskResponseRequestParamsPromptV2? Type633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AnalyzeTaskResponseRequestParamsPromptV2MediaSourcesItems>? Type634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskResponseRequestParamsResponseFormatType? Type635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskResponseRequestParamsResponseFormatJsonSchema? Type636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskResponseRequestParamsResponseFormatSegmentDefinitionsItemsFieldsItemsItems? Type637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskResponseRequestParamsResponseFormatSegmentDefinitionsItemsFieldsItems? Type638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskResponseRequestParamsResponseFormatSegmentDefinitionsItemsMediaSourcesItems? Type639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskResponseRequestParamsResponseFormatSegmentDefinitionsItems? Type640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AnalyzeTaskResponseRequestParamsResponseFormatSegmentDefinitionsItemsFieldsItems>? Type641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AnalyzeTaskResponseRequestParamsResponseFormatSegmentDefinitionsItemsMediaSourcesItems>? Type642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskResponseRequestParamsResponseFormat? Type643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AnalyzeTaskResponseRequestParamsResponseFormatSegmentDefinitionsItems>? Type644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskResponseRequestParams? Type645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskResultUsage? Type646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskResult? Type647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskWebhookInfo? Type648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskResponse? Type649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AnalyzeTaskWebhookInfo>? Type650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeAsyncTasksListResponse200? Type651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AnalyzeTaskResponse>? Type652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListAsyncAnalysisTasksRequestBadRequestError? Type653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateAnalyzeBatchRequestModelName? Type654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateAnalyzeBatchRequestAnalysisMode? Type655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.BatchPrompt? Type656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.BatchDefaults? Type657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.BatchVideoContextType? Type658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.BatchVideoContext? Type659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.BatchItemRequest? Type660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateAnalyzeBatchRequest? Type661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.BatchItemRequest>? Type662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.BatchStatus? Type663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreatedBatchItem? Type664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateAnalyzeBatchResponse? Type665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.CreatedBatchItem>? Type666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeBatchesGetParametersAnalysisModeSchemaItems? Type667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeBatchStatusResponseAnalysisMode? Type668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeBatchStatusResponse? Type669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeAsyncBatchesListResponse200? Type670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AnalyzeBatchStatusResponse>? Type671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.BatchItemStatus? Type672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.BatchItemError? Type673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.BatchResultItem? Type674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateRequest? Type675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.UpdateUserMetadataRequest? Type676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ReplaceUserMetadataRequest? Type677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AuthorizeConnectionRequest? Type678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateRedirectUriRequest? Type679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ImportFilesRequest? Type680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.ConnectionsConnectionIdImportsPostRequestBodyContentApplicationJsonSchemaItemsItems>? Type681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateRequest2? Type682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.UpdateRequest? Type683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateRequest3? Type684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateBulkRequest? Type685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.EntityCollectionsEntityCollectionIdEntitiesBulkPostRequestBodyContentApplicationJsonSchemaEntitiesItems>? Type686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.UpdateRequest2? Type687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateAssetsRequest? Type688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DeleteAssetsRequest? Type689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateRequest4? Type690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.UpdateRequest3? Type691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateRequest5? Type692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateRequest6? Type693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.UpdateRequest4? Type694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AddItemsRequest? Type695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RemoveItemsRequest? Type696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateStreamRequest? Type697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.ResponseInputItem>? Type698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.ResponsesPostRequestBodyContentApplicationJsonSchemaIncludeItems>? Type699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.ResponseSelection>? Type700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateRequest7? Type701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.IndexesPostRequestBodyContentApplicationJsonSchemaModelsItems>? Type702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.UpdateRequest5? Type703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateRequest8? Type704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.UpdateRequest6? Type705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.UpdateRequest7? Type706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateRequest9? Type707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateRequest10? Type708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaSearchOptionsItems>? Type709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaTranscriptionOptionsItems>? Type710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateRequest11? Type711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.EmbedTasksPostRequestBodyContentMultipartFormDataSchemaVideoEmbeddingScopeItems>? Type712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateRequest12? Type713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeRequest? Type714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AssetsGetParametersAssetTypesSchemaItems>? Type715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AssetsAssetIdTranscriptionGetParametersIncludeSchemaItems>? Type716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.KnowledgeStoresKnowledgeStoreIdItemsGetParametersStatusSchemaItems>? Type717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.IndexesIndexIdIndexedAssetsGetParametersStatusSchemaItems>? Type718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.IndexesIndexIdIndexedAssetsIndexedAssetIdGetParametersEmbeddingOptionSchemaItems>? Type719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.IndexesIndexIdVideosVideoIdGetParametersEmbeddingOptionSchemaItems>? Type720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.TasksGetParametersStatusSchemaItems>? Type721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.EmbedTasksTaskIdGetParametersEmbeddingOptionSchemaItems>? Type722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.BatchStatus>? Type723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AnalyzeBatchesGetParametersAnalysisModeSchemaItems>? Type724 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.PresignedURLChunk>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.ChunkInfo>? ListType1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.IncompleteUploadSummary>? ListType2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.CompletedChunk>? ListType3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.VideoStream>? ListType4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.AudioStream>? ListType5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.AssetDetail>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.AssetTranscriptionEntry>? ListType7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.AssetTranscriptionUtterance>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.Connection>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.RedirectUri>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.ImportItem>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.Import>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.EntityCollection>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.Entity>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.BulkCreateEntityResponseEntitiesItems>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.BulkCreateEntityResponseErrorsItems>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.KnowledgeStore>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.KnowledgeStoreItemAssetType>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.VideoSearchModality>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.VideoMatch>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.SearchKnowledgeStoreHit>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.KnowledgeStoreItem>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.KnowledgeStoreItemCollection>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.ResponseAnnotation>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.ResponseOutputContentPart>? ListType26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.ResponseOutputItem>? ListType27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.IndexModelsItems>? ListType28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.Index>? ListType29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<double>? ListType30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.VideoSegment>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.TranscriptionDataItems>? ListType32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.IndexedAsset>? ListType33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.IndexedAssetSummary>? ListType34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.VideoVector>? ListType35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.VideoIndexingTask>? ListType36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<byte[]>? ListType37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.SearchItemClipsItems>? ListType38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.SearchItem>? ListType39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.AudioInputRequestEmbeddingOptionItems>? ListType40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.AudioInputRequestEmbeddingScopeItems>? ListType41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.AudioInputRequestEmbeddingTypeItems>? ListType42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.VideoInputRequestEmbeddingOptionItems>? ListType43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.VideoInputRequestEmbeddingScopeItems>? ListType44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.VideoInputRequestEmbeddingTypeItems>? ListType45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.MultiInputMediaSource>? ListType46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.EmbeddingAudioMetadataEmbeddingScopesItems>? ListType47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.EmbeddingVideoMetadataEmbeddingScopesItems>? ListType48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.EmbeddingData>? ListType49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.AsyncAudioInputRequestEmbeddingOptionItems>? ListType50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.AsyncAudioInputRequestEmbeddingScopeItems>? ListType51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.AsyncAudioInputRequestEmbeddingTypeItems>? ListType52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.TimeBasedMetadataEntry>? ListType53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.AsyncVideoInputRequestEmbeddingOptionItems>? ListType54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.AsyncVideoInputRequestEmbeddingScopeItems>? ListType55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.AsyncVideoInputRequestEmbeddingTypeItems>? ListType56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.AsyncDocumentInputRequestEmbeddingOptionItems>? ListType57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.AsyncDocumentInputRequestEmbeddingTypeItems>? ListType58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.AsyncDocumentInputRequestEmbeddingScopeItems>? ListType59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.AsyncImageInputRequestEmbeddingOptionItems>? ListType60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.AsyncImageInputRequestEmbeddingTypeItems>? ListType61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.AsyncImageInputRequestEmbeddingScopeItems>? ListType62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.MediaEmbeddingTask>? ListType63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.AsyncDocumentMetadataEmbeddingScopesItems>? ListType64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.AsyncImageMetadataEmbeddingScopesItems>? ListType65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.BaseSegment>? ListType66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.AudioSegment>? ListType67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.SMEMediaSource>? ListType68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.SegmentField>? ListType69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.AnalyzeTimeRange>? ListType70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.SegmentDefinition>? ListType71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.AnalyzeTaskResponseRequestParamsPromptV2MediaSourcesItems>? ListType72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.AnalyzeTaskResponseRequestParamsResponseFormatSegmentDefinitionsItemsFieldsItems>? ListType73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.AnalyzeTaskResponseRequestParamsResponseFormatSegmentDefinitionsItemsMediaSourcesItems>? ListType74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.AnalyzeTaskResponseRequestParamsResponseFormatSegmentDefinitionsItems>? ListType75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.AnalyzeTaskWebhookInfo>? ListType76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.AnalyzeTaskResponse>? ListType77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.BatchItemRequest>? ListType78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.CreatedBatchItem>? ListType79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.AnalyzeBatchStatusResponse>? ListType80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.ConnectionsConnectionIdImportsPostRequestBodyContentApplicationJsonSchemaItemsItems>? ListType81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.EntityCollectionsEntityCollectionIdEntitiesBulkPostRequestBodyContentApplicationJsonSchemaEntitiesItems>? ListType82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.ResponseInputItem>? ListType83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.ResponsesPostRequestBodyContentApplicationJsonSchemaIncludeItems>? ListType84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.ResponseSelection>? ListType85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.IndexesPostRequestBodyContentApplicationJsonSchemaModelsItems>? ListType86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaSearchOptionsItems>? ListType87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaTranscriptionOptionsItems>? ListType88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.EmbedTasksPostRequestBodyContentMultipartFormDataSchemaVideoEmbeddingScopeItems>? ListType89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.AssetsGetParametersAssetTypesSchemaItems>? ListType90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.AssetsAssetIdTranscriptionGetParametersIncludeSchemaItems>? ListType91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.KnowledgeStoresKnowledgeStoreIdItemsGetParametersStatusSchemaItems>? ListType92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.IndexesIndexIdIndexedAssetsGetParametersStatusSchemaItems>? ListType93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.IndexesIndexIdIndexedAssetsIndexedAssetIdGetParametersEmbeddingOptionSchemaItems>? ListType94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.IndexesIndexIdVideosVideoIdGetParametersEmbeddingOptionSchemaItems>? ListType95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.TasksGetParametersStatusSchemaItems>? ListType96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.EmbedTasksTaskIdGetParametersEmbeddingOptionSchemaItems>? ListType97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.BatchStatus>? ListType98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.AnalyzeBatchesGetParametersAnalysisModeSchemaItems>? ListType99 { get; set; }
    }
}