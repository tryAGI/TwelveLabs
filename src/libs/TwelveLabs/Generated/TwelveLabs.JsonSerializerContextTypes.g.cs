
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
        /// String arrays used by dynamic JSON option values.
        /// </summary>
        public string[]? StringArray { get; set; }

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
        public global::TwelveLabs.UserMetadataValue? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::TwelveLabs.UserMetadataValue>? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AssetSourceType? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AssetSourceDetailsProvider? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AssetSourceDetails? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AssetSource? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.Asset? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateAssetRequestBadRequestError? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.FlatErrorResponse? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateAssetUploadRequestType? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateAssetUploadRequest? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public long? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.PresignedURLChunk? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateAssetUploadResponse? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.PresignedURLChunk>? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateMultipartUploadRequestBadRequestError? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateMultipartUploadRequestForbiddenError? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateMultipartUploadRequestInternalServerError? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.MultipartUploadStatusType? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ChunkInfoStatus? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ChunkInfo? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.PageInfo? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.GetUploadStatusResponse? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.ChunkInfo>? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.GetUploadStatusRequestBadRequestError? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.GetUploadStatusRequestForbiddenError? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.GetUploadStatusRequestInternalServerError? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IncompleteUploadSummary? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListIncompleteUploadsResponse? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.IncompleteUploadSummary>? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListIncompleteUploadsRequestBadRequestError? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListIncompleteUploadsRequestForbiddenError? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListIncompleteUploadsRequestInternalServerError? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CompletedChunkProofType? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CompletedChunk? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ReportChunkBatchRequest? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.CompletedChunk>? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ReportChunkBatchResponse? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ReportChunkBatchRequestBadRequestError? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ReportChunkBatchRequestForbiddenError? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RequestAdditionalPresignedURLsRequest? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RequestAdditionalPresignedURLsResponse? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RequestAdditionalPresignedUrlsRequestBadRequestError? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RequestAdditionalPresignedUrlsRequestForbiddenError? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RequestAdditionalPresignedUrlsRequestInternalServerError? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AssetDetailMethod? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AssetDetailStatus? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AssetHlsStatus? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AssetHLS? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AssetThumbnailStatus? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AssetThumbnail? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoStream? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AudioStream? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TechnicalMetadata? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.VideoStream>? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AudioStream>? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AssetError? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AssetDetail? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RetrieveAssetRequestBadRequestError? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AssetsGetParametersAssetTypesSchemaItems? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AssetsListResponse200? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AssetDetail>? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListAssetsRequestBadRequestError? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DeleteAssetRequestBadRequestError? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.UpdateAssetUserMetadataRequestBadRequestError? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ReplaceAssetUserMetadataRequestBadRequestError? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DeleteAssetUserMetadataRequestBadRequestError? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AssetsAssetIdTranscriptionGetParametersIncludeSchemaItems? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AssetTranscriptionStatus? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AssetTranscriptionEntry? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AssetTranscriptionUtterance? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AssetTranscriptionError? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AssetTranscriptionResponse? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AssetTranscriptionEntry>? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AssetTranscriptionUtterance>? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RetrieveAssetTranscriptionRequestBadRequestError? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RetrieveAssetTranscriptionRequestNotFoundError? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AssetStorageAccounting? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EnableAssetStorageAccountingRequestBadRequestError? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ConnectionsAuthorizePostRequestBodyContentApplicationJsonSchemaProvider? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DataConnectorsAuthorizeConnectionResponse200? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AuthorizeConnectionRequestBadRequestError? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ConnectionProvider? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ConnectionStatus? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ConnectionAccount? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.Connection? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DataConnectorsListConnectionsResponse200? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.Connection>? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListConnectionsRequestBadRequestError? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RetrieveConnectionRequestBadRequestError? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RetrieveConnectionRequestNotFoundError? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DeleteConnectionRequestBadRequestError? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DeleteConnectionRequestNotFoundError? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DataConnectorsCreateConnectionPickerTokenResponse200? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateConnectionPickerTokenRequestBadRequestError? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateConnectionPickerTokenRequestNotFoundError? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateConnectionPickerTokenRequestConflictError? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RedirectUri? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateRedirectUriRequestBadRequestError? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateRedirectUriRequestConflictError? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateRedirectUriRequestUnprocessableEntityError? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DataConnectorsListRedirectUrisResponse200? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.RedirectUri>? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListRedirectUrisRequestBadRequestError? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DeleteRedirectUriRequestBadRequestError? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DeleteRedirectUriRequestNotFoundError? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ConnectionsConnectionIdImportsPostRequestBodyContentApplicationJsonSchemaItemsItems? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ImportItemAction? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ImportItemStatus? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ImportItemError? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ImportItem? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ImportResult? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.ImportItem>? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ImportFilesRequestBadRequestError? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ImportFilesRequestNotFoundError? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ImportFilesRequestConflictError? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ImportProvider? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.Import? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ImportsListImportsResponse200? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.Import>? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListImportsRequestBadRequestError? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListImportsRequestNotFoundError? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ImportDetailProvider? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ImportDetail? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RetrieveImportRequestBadRequestError? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RetrieveImportRequestNotFoundError? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EntityCollectionsGetParametersSortBy? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EntityCollection? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EntityCollectionsListResponse200? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.EntityCollection>? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListEntityCollectionsRequestBadRequestError? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateEntityCollectionRequestBadRequestError? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RetrieveEntityCollectionRequestBadRequestError? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.UpdateEntityCollectionRequestBadRequestError? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DeleteEntityCollectionRequestBadRequestError? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EntityCollectionsEntityCollectionIdEntitiesGetParametersStatus? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EntityCollectionsEntityCollectionIdEntitiesGetParametersSortBy? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EntityMetadata? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EntityStatus? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.Entity? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EntityCollectionsEntitiesListResponse200? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.Entity>? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListEntitiesInCollectionRequestBadRequestError? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EntityCollectionsEntityCollectionIdEntitiesPostRequestBodyContentApplicationJsonSchemaMetadata? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateEntityRequestBadRequestError? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EntityCollectionsEntityCollectionIdEntitiesBulkPostRequestBodyContentApplicationJsonSchemaEntitiesItemsMetadata? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EntityCollectionsEntityCollectionIdEntitiesBulkPostRequestBodyContentApplicationJsonSchemaEntitiesItems? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.BulkCreateEntityResponseEntitiesItems? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.BulkCreateEntityResponseErrorsItems? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.BulkCreateEntityResponse? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.BulkCreateEntityResponseEntitiesItems>? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.BulkCreateEntityResponseErrorsItems>? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateEntitiesBulkRequestBadRequestError? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RetrieveEntityRequestBadRequestError? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EntityCollectionsEntityCollectionIdEntitiesEntityIdPatchRequestBodyContentApplicationJsonSchemaMetadata? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.UpdateEntityRequestBadRequestError? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DeleteEntityRequestBadRequestError? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AddEntityAssetsRequestBadRequestError? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RemoveEntityAssetsRequestBadRequestError? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EntityCollectionsEntitiesListByAssetResponse200? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListEntitiesByAssetRequestBadRequestError? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EnrichmentConfigJsonSchemaType? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EnrichmentConfigJsonSchemaJsonSchemaType? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EnrichmentConfigJsonSchemaJsonSchema? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EnrichmentConfigDescriptionType? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EnrichmentConfig? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EnrichmentConfigVariant1? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EnrichmentConfigVariant2? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EnrichmentConfigDiscriminator? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EnrichmentConfigDiscriminatorType? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IngestionConfig? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.KnowledgeStoreMetadataValue? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.KnowledgeStore? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::TwelveLabs.KnowledgeStoreMetadataValue>? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateKnowledgeStoreRequestBadRequestError? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateKnowledgeStoreRequestUnprocessableEntityError? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.KnowledgeStoresGetParametersSortBy? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.KnowledgeStoresListResponse200? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.KnowledgeStore>? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListKnowledgeStoresRequestBadRequestError? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RetrieveKnowledgeStoreRequestBadRequestError? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.UpdateKnowledgeStoreRequestBadRequestError? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.UpdateKnowledgeStoreRequestUnprocessableEntityError? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DeleteKnowledgeStoreRequestBadRequestError? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.KnowledgeStoreSearchQuery? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.KnowledgeStoreItemAssetType? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AssetTypeFilter? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.KnowledgeStoreItemAssetType>? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ItemIdFilter? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ItemCollectionIdFilter? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.MetadataScalarValue? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.MetadataRangeBound? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.UserMetadataValueFilter? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.MetadataScalarValue>? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::TwelveLabs.UserMetadataValueFilter>? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.MetadataValueFilter? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::TwelveLabs.MetadataValueFilter>? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreatedAtFilter? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.GeoCircleFilter? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TagFilter? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchKnowledgeStoreFilter? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoSearchModality? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoSearchOptions? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.VideoSearchModality>? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchKnowledgeStoreOptions? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchKnowledgeStoreRequestGroupBy? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchKnowledgeStoreRequest? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoSearchSystemMetadata? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoSearchItemMetadata? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoMatch? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ImageSearchSystemMetadata? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ImageSearchItemMetadata? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchKnowledgeStoreHit? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchKnowledgeStoreHitVariant1? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchKnowledgeStoreHitVariant1AssetType? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.VideoMatch>? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchKnowledgeStoreHitVariant2? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchKnowledgeStoreHitVariant2AssetType? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchKnowledgeStoreHitDiscriminator? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchKnowledgeStoreHitDiscriminatorAssetType? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchKnowledgeStoreResponse? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.SearchKnowledgeStoreHit>? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchKnowledgeStoreRequestBadRequestError? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchKnowledgeStoreRequestNotFoundError? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchKnowledgeStoreRequestGoneError? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchKnowledgeStoreRequestUnprocessableEntityError? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.KnowledgeStoreItemStatus? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoMetadataAssetType? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ImageMetadataAssetType? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.KnowledgeStoreItemSystemMetadata? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.KnowledgeStoreItemSystemMetadataVariant1? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.KnowledgeStoreItemSystemMetadataVariant2? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.KnowledgeStoreItemSystemMetadataDiscriminator? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.KnowledgeStoreItemSystemMetadataDiscriminatorAssetType? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.KnowledgeStoreItem? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateKnowledgeStoreItemRequestBadRequestError? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateKnowledgeStoreItemRequestUnprocessableEntityError? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.KnowledgeStoresKnowledgeStoreIdItemsGetParametersStatusSchemaItems? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.KnowledgeStoreItemsListResponse200? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.KnowledgeStoreItem>? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RetrieveKnowledgeStoreItemRequestBadRequestError? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DeleteKnowledgeStoreItemRequestBadRequestError? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.UpdateKnowledgeStoreItemMetadataRequestBadRequestError? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.UpdateKnowledgeStoreItemMetadataRequestNotFoundError? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.UpdateKnowledgeStoreItemMetadataRequestUnprocessableEntityError? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ReplaceKnowledgeStoreItemMetadataRequestBadRequestError? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ReplaceKnowledgeStoreItemMetadataRequestNotFoundError? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ReplaceKnowledgeStoreItemMetadataRequestUnprocessableEntityError? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateKnowledgeStoreItemTagRequest? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.KnowledgeStoreItemTag? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateKnowledgeStoreItemTagRequestBadRequestError? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateKnowledgeStoreItemTagRequestNotFoundError? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.KnowledgeStoreItemTagsListResponse200? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.KnowledgeStoreItemTag>? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListKnowledgeStoreItemTagsRequestBadRequestError? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListKnowledgeStoreItemTagsRequestNotFoundError? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RetrieveKnowledgeStoreItemTagRequestBadRequestError? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RetrieveKnowledgeStoreItemTagRequestNotFoundError? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.UpdateKnowledgeStoreItemTagRequest? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.UpdateKnowledgeStoreItemTagRequestBadRequestError? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.UpdateKnowledgeStoreItemTagRequestNotFoundError? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DeleteKnowledgeStoreItemTagRequestBadRequestError? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DeleteKnowledgeStoreItemTagRequestNotFoundError? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.KnowledgeStoreItemCollection? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateKnowledgeStoreItemCollectionRequestBadRequestError? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateKnowledgeStoreItemCollectionRequestUnprocessableEntityError? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.KnowledgeStoresKnowledgeStoreIdItemCollectionsGetParametersSortBy? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.KnowledgeStoreItemCollectionsListResponse200? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.KnowledgeStoreItemCollection>? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListKnowledgeStoreItemCollectionsRequestBadRequestError? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RetrieveKnowledgeStoreItemCollectionRequestBadRequestError? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.UpdateKnowledgeStoreItemCollectionRequestBadRequestError? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.UpdateKnowledgeStoreItemCollectionRequestUnprocessableEntityError? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DeleteKnowledgeStoreItemCollectionRequestBadRequestError? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.KnowledgeStoreItemCollectionsListItemsResponse200? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListKnowledgeStoreItemCollectionItemsRequestBadRequestError? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AddItemsToKnowledgeStoreItemCollectionRequestBadRequestError? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RemoveItemsFromKnowledgeStoreItemCollectionRequestBadRequestError? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseInputItemType? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseInputItemRole? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseInputItem? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponsesPostRequestBodyContentApplicationJsonSchemaIncludeItems? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.WebSearchToolInputType? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseToolInput? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseToolInputVariant1? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseToolInputDiscriminator? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseToolInputDiscriminatorType? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseSelectionKind? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseSelection? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TextResponseFormatTextType? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TextResponseFormatJsonSchemaType? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TextParamFormat? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TextParamFormatVariant1? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TextParamFormatVariant2? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TextParamFormatDiscriminator? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TextParamFormatDiscriminatorType? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TextParam? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseObjectType? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseObjectObject? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStatus? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseIncompleteDetails? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStandardOutputItemType? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStandardOutputItemStatus? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStandardOutputItemRole? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseOutputContentPartType? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseAnnotation? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseOutputContentPart? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.ResponseAnnotation>? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseWebSearchOutputItemType? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.WebSearchAction? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseOutputItem? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseOutputItemVariant1? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.ResponseOutputContentPart>? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseOutputItemVariant2? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseOutputItemVariant3? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseOutputItemVariant4? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseOutputItemDiscriminator? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseOutputItemDiscriminatorType? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseBilling? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseObject? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.ResponseOutputItem>? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateResponseRequestBadRequestError? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateResponseRequestUnprocessableEntityError? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamResponseEventType? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamOutputItemAddedEventType? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamContentPartAddedEventType? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamOutputTextDeltaEventType? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamOutputTextDoneEventType? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamContentPartDoneEventType? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamOutputItemDoneEventType? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamFuncCallArgsDoneEventType? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamWebSearchProgressEventType? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamEvent? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamEventVariant1? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamEventVariant2? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamEventVariant3? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamEventVariant4? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamEventVariant5? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamEventVariant6? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamEventVariant7? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamEventVariant8? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamEventVariant9? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamEventVariant10? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamEventVariant11? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamEventVariant12? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamEventVariant13? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamEventVariant14? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamEventDiscriminator? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamEventDiscriminatorType? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesPostRequestBodyContentApplicationJsonSchemaModelsItemsModelName? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesPostRequestBodyContentApplicationJsonSchemaModelsItems? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesCreateResponse201? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateIndexRequestBadRequestError? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexModelsItems? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.Index? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.IndexModelsItems>? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesListResponse200? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.Index>? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListIndexesRequestBadRequestError? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RetrieveIndexRequestBadRequestError? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.UpdateIndexRequestBadRequestError? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DeleteIndexRequestBadRequestError? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesIndexedAssetsCreateResponse202? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateIndexedAssetRequestBadRequestError? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateIndexedAssetRequestInternalServerError? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesIndexIdIndexedAssetsIndexedAssetIdGetParametersEmbeddingOptionSchemaItems? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexedAssetDetailedStatus? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexedAssetDetailedSystemMetadata? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.HlsObjectStatus? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.HLSObject? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoSegment? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<double>? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexedAssetDetailedEmbeddingVideoEmbedding? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.VideoSegment>? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexedAssetDetailedEmbedding? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TranscriptionDataItems? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.TranscriptionDataItems>? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexedAssetDetailed? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RetrieveIndexedAssetInformationRequestBadRequestError? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RetrieveIndexedAssetInformationRequestNotFoundError? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesIndexIdIndexedAssetsGetParametersStatusSchemaItems? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesIndexIdIndexedAssetsGetParametersDuration? Type392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesIndexIdIndexedAssetsGetParametersFps? Type393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesIndexIdIndexedAssetsGetParametersWidth? Type394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesIndexIdIndexedAssetsGetParametersHeight? Type395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesIndexIdIndexedAssetsGetParametersSize? Type396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesIndexIdIndexedAssetsGetParametersUserMetadataSchema? Type397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexedAssetStatus? Type398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexedAssetSystemMetadata? Type399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexedAsset? Type400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesIndexedAssetsListResponse200? Type401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.IndexedAsset>? Type402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListIndexedAssetsRequestBadRequestError? Type403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DeleteIndexedAssetInformationRequestBadRequestError? Type404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.PartialUpdateIndexedAssetInformationRequestBadRequestError? Type405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexedAssetSummaryIndex? Type406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexedAssetSummary? Type407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesIndexedAssetsListByAssetResponse200? Type408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.IndexedAssetSummary>? Type409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListIndexedAssetsByAssetRequestBadRequestError? Type410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesIndexIdVideosGetParametersDuration? Type411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesIndexIdVideosGetParametersFps? Type412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesIndexIdVideosGetParametersWidth? Type413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesIndexIdVideosGetParametersHeight? Type414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesIndexIdVideosGetParametersSize? Type415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesIndexIdVideosGetParametersUserMetadataSchema? Type416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoVectorSystemMetadata? Type417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoVector? Type418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesVideosListResponse200? Type419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.VideoVector>? Type420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListVideosRequestBadRequestError? Type421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesIndexIdVideosVideoIdGetParametersEmbeddingOptionSchemaItems? Type422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesIndexIdVideosVideoIdGetResponsesContentApplicationJsonSchemaSystemMetadata? Type423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesIndexIdVideosVideoIdGetResponsesContentApplicationJsonSchemaEmbeddingVideoEmbedding? Type424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesIndexIdVideosVideoIdGetResponsesContentApplicationJsonSchemaEmbedding? Type425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesVideosRetrieveResponse200? Type426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RetrieveVideoInformationRequestBadRequestError? Type427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RetrieveVideoInformationRequestNotFoundError? Type428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.PartialUpdateVideoInformationRequestBadRequestError? Type429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DeleteVideoInformationRequestBadRequestError? Type430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TasksCreateResponse200? Type431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateVideoIndexingTaskRequestBadRequestError? Type432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TasksGetParametersStatusSchemaItems? Type433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoIndexingTaskSystemMetadata? Type434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoIndexingTask? Type435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TasksGetResponsesContentApplicationJsonSchemaPageInfo? Type436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TasksListResponse200? Type437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.VideoIndexingTask>? Type438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListVideoIndexingTasksRequestBadRequestError? Type439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TasksTaskIdGetResponsesContentApplicationJsonSchemaSystemMetadata? Type440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TasksRetrieveResponse200? Type441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RetrieveVideoIndexingTaskRequestBadRequestError? Type442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DeleteVideoIndexingTaskRequestBadRequestError? Type443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaType? Type444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaUrl? Type445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaFile? Type446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<byte[]>? Type448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaSearchOptionsItems? Type449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaTranscriptionOptionsItems? Type450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaGroupBy? Type451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaOperator? Type452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchItemClipsItems? Type453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchItem? Type454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.SearchItemClipsItems>? Type455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchResultsPageInfo? Type456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchPool? Type457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchResults? Type458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.SearchItem>? Type459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnyToVideoSearchRequestBadRequestError? Type460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchPageTokenGetResponsesContentApplicationJsonSchemaPageInfo? Type461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchRetrieveResponse200? Type462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnyToVideoRetrieveSpecificPageRequestBadRequestError? Type463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateEmbeddingsRequestInputType? Type464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateEmbeddingsRequestModelName? Type465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateEmbeddingsRequestEmbeddingDimension? Type466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TextInputRequest? Type467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.MediaSource? Type468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ImageInputRequest? Type469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TextImageInputRequest? Type470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AudioSegmentationFixed? Type471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AudioSegmentation? Type472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AudioSegmentationStrategy? Type473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AudioInputRequestEmbeddingOptionItems? Type474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AudioInputRequestEmbeddingScopeItems? Type475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AudioInputRequestEmbeddingTypeItems? Type476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AudioInputRequest? Type477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AudioInputRequestEmbeddingOptionItems>? Type478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AudioInputRequestEmbeddingScopeItems>? Type479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AudioInputRequestEmbeddingTypeItems>? Type480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoSegmentationDiscriminatorMappingDynamicDynamic? Type481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoSegmentationDiscriminatorMappingFixedFixed? Type482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoSegmentation? Type483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoSegmentationVariant1? Type484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoSegmentationVariant1Strategy? Type485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoSegmentationVariant2? Type486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoSegmentationVariant2Strategy? Type487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoSegmentationDiscriminator? Type488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoSegmentationDiscriminatorStrategy? Type489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoInputRequestEmbeddingOptionItems? Type490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoInputRequestEmbeddingScopeItems? Type491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoInputRequestEmbeddingTypeItems? Type492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoInputRequest? Type493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.VideoInputRequestEmbeddingOptionItems>? Type494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.VideoInputRequestEmbeddingScopeItems>? Type495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.VideoInputRequestEmbeddingTypeItems>? Type496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.MultiInputMediaSourceMediaType? Type497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.MultiInputMediaSource? Type498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.MultiInputRequest? Type499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.MultiInputMediaSource>? Type500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateEmbeddingsRequest? Type501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingDataEmbeddingOption? Type502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingDataEmbeddingScope? Type503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingDataQuadrant? Type504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingData? Type505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingUsageTruncationReason? Type506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingUsage? Type507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, int>? Type508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingImageMetadataInputType? Type509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingMediaMetadataInputType? Type510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingTextImageMetadataInputType? Type511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingAudioMetadataInputType? Type512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingAudioMetadataEmbeddingScopesItems? Type513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingVideoMetadataInputType? Type514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingVideoMetadataEmbeddingScopesItems? Type515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingMultiInputMetadataInputType? Type516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingMediaMetadata? Type517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingMediaMetadataVariant1? Type518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingMediaMetadataVariant2? Type519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingMediaMetadataVariant3? Type520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.EmbeddingAudioMetadataEmbeddingScopesItems>? Type521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingMediaMetadataVariant4? Type522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.EmbeddingVideoMetadataEmbeddingScopesItems>? Type523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingMediaMetadataVariant5? Type524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingMediaMetadataDiscriminator? Type525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingSuccessResponse? Type526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.EmbeddingData>? Type527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ErrorResponseError? Type528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ErrorResponse? Type529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateAsyncEmbeddingRequestInputType? Type530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateAsyncEmbeddingRequestModelName? Type531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateAsyncEmbeddingRequestEmbeddingDimension? Type532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TemporalSegmentationDiscriminatorMappingDynamicDynamic? Type533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TemporalSegmentationDiscriminatorMappingFixedFixed? Type534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TemporalSegmentation? Type535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TemporalSegmentationVariant1? Type536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TemporalSegmentationVariant1Strategy? Type537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TemporalSegmentationVariant2? Type538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TemporalSegmentationVariant2Strategy? Type539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TemporalSegmentationDiscriminator? Type540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TemporalSegmentationDiscriminatorStrategy? Type541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncTemporalSegmentation? Type542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncAudioInputRequestSegmentation? Type543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncAudioInputRequestEmbeddingOptionItems? Type544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncAudioInputRequestEmbeddingScopeItems? Type545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncAudioInputRequestEmbeddingTypeItems? Type546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TimeBasedMetadataEntry? Type547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncAudioInputRequest? Type548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AsyncAudioInputRequestEmbeddingOptionItems>? Type549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AsyncAudioInputRequestEmbeddingScopeItems>? Type550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AsyncAudioInputRequestEmbeddingTypeItems>? Type551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.TimeBasedMetadataEntry>? Type552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncVideoInputRequestSegmentation? Type553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncVideoInputRequestEmbeddingOptionItems? Type554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncVideoInputRequestEmbeddingScopeItems? Type555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncVideoInputRequestEmbeddingTypeItems? Type556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncVideoInputRequest? Type557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AsyncVideoInputRequestEmbeddingOptionItems>? Type558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AsyncVideoInputRequestEmbeddingScopeItems>? Type559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AsyncVideoInputRequestEmbeddingTypeItems>? Type560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DocumentSpatialSegmentationStrategy? Type561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DocumentSpatialSegmentation? Type562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DocumentSequentialSegmentationStrategy? Type563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DocumentSequentialSegmentation? Type564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DocumentSegmentation? Type565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncDocumentInputRequestEmbeddingOptionItems? Type566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncDocumentInputRequestEmbeddingTypeItems? Type567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncDocumentInputRequestEmbeddingScopeItems? Type568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncDocumentInputRequest? Type569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AsyncDocumentInputRequestEmbeddingOptionItems>? Type570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AsyncDocumentInputRequestEmbeddingTypeItems>? Type571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AsyncDocumentInputRequestEmbeddingScopeItems>? Type572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncImageInputRequestEmbeddingOptionItems? Type573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncImageInputRequestEmbeddingTypeItems? Type574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncImageInputRequestEmbeddingScopeItems? Type575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncImageInputRequest? Type576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AsyncImageInputRequestEmbeddingOptionItems>? Type577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AsyncImageInputRequestEmbeddingTypeItems>? Type578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AsyncImageInputRequestEmbeddingScopeItems>? Type579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateAsyncEmbeddingRequest? Type580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbedV2TasksPostResponsesContentApplicationJsonSchemaStatus? Type581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbedV2TasksPostResponsesContentApplicationJsonSchemaMetadata? Type582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbedV2TasksCreateResponse202? Type583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoEmbeddingMetadata? Type584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.MediaEmbeddingTaskVideoEmbedding? Type585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AudioEmbeddingMetadata? Type586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.MediaEmbeddingTaskAudioEmbedding? Type587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DocumentEmbeddingMetadata? Type588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.MediaEmbeddingTaskDocumentEmbedding? Type589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ImageEmbeddingMetadata? Type590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.MediaEmbeddingTaskImageEmbedding? Type591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.MediaEmbeddingTask? Type592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbedV2TasksGetResponsesContentApplicationJsonSchemaPageInfo? Type593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbedV2TasksListResponse200? Type594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.MediaEmbeddingTask>? Type595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListAsyncEmbeddingTasksRequestBadRequestError? Type596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingTaskResponseStatus? Type597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingTaskMediaMetadataInputType? Type598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncDocumentMetadataInputType? Type599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncDocumentMetadataEmbeddingScopesItems? Type600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncImageMetadataInputType? Type601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncImageMetadataEmbeddingScopesItems? Type602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingTaskMediaMetadata? Type603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingTaskMediaMetadataVariant1? Type604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingTaskMediaMetadataVariant2? Type605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingTaskMediaMetadataVariant3? Type606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AsyncDocumentMetadataEmbeddingScopesItems>? Type607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingTaskMediaMetadataVariant4? Type608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AsyncImageMetadataEmbeddingScopesItems>? Type609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingTaskMediaMetadataDiscriminator? Type610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingTaskResponseError? Type611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingTaskResponse? Type612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbedTasksPostRequestBodyContentMultipartFormDataSchemaVideoEmbeddingScopeItems? Type613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbedTasksCreateResponse200? Type614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateVideoEmbeddingTaskRequestBadRequestError? Type615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbedTasksGetResponsesContentApplicationJsonSchemaPageInfo? Type616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbedTasksListResponse200? Type617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListVideoEmbeddingTasksRequestBadRequestError? Type618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbedTasksTaskIdStatusGetResponsesContentApplicationJsonSchemaVideoEmbedding? Type619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbedTasksStatusResponse200? Type620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RetrieveVideoEmbeddingTaskRequestBadRequestError? Type621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbedTasksTaskIdGetParametersEmbeddingOptionSchemaItems? Type622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbedTasksTaskIdGetResponsesContentApplicationJsonSchemaVideoEmbedding? Type623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbedTasksRetrieveResponse200? Type624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RetrieveVideoEmbeddingRequestBadRequestError? Type625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.BaseSegment? Type626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TextEmbeddingResult? Type627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.BaseSegment>? Type628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.BaseEmbeddingMetadata? Type629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ImageEmbeddingResult? Type630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AudioSegment? Type631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AudioEmbeddingResult? Type632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AudioSegment>? Type633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingResponse? Type634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateTextImageAudioEmbeddingRequestBadRequestError? Type635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzePostRequestBodyContentApplicationJsonSchemaModelName? Type636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoContext? Type637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoContextVariant1? Type638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoContextVariant1Type? Type639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoContextVariant2? Type640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoContextVariant2Type? Type641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoContextVariant3? Type642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoContextVariant3Type? Type643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoContextDiscriminator? Type644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoContextDiscriminatorType? Type645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeImageInput? Type646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SmeMediaSourceMediaType? Type647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SMEMediaSource? Type648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzePromptV2? Type649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.SMEMediaSource>? Type650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SyncResponseFormatType? Type651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SyncResponseFormatJsonSchema? Type652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SyncResponseFormat? Type653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.StreamStartResponseEventType? Type654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.StreamStartResponseMetadata? Type655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.StreamTextResponseEventType? Type656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.StreamEndResponseEventType? Type657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.FinishReason? Type658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TokenUsage? Type659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.StreamEndResponseMetadata? Type660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskError? Type661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.StreamAnalyzeResponse? Type662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.StreamAnalyzeResponseVariant1? Type663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.StreamAnalyzeResponseVariant2? Type664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.StreamAnalyzeResponseVariant3? Type665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.StreamAnalyzeResponseDiscriminator? Type666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.StreamAnalyzeResponseDiscriminatorEventType? Type667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.NonStreamAnalyzeResponse? Type668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeResponse200? Type669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.GenerateTextRepresentationRequestBadRequestError? Type670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateAsyncAnalyzeRequestModelName? Type671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateAsyncAnalyzeRequestAnalysisMode? Type672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateAsyncAnalyzeRequestMaxTokens1? Type673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateAsyncAnalyzeRequestMaxTokens? Type674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncResponseFormatType? Type675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncResponseFormatJsonSchema? Type676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SegmentFieldType? Type677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SegmentFieldFormat? Type678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SegmentFieldItemsType? Type679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TimeArrayItemFieldType? Type680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TimeArrayItemFieldItemsType? Type681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TimeArrayItemFieldItems? Type682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TimeArrayItemField? Type683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SegmentFieldItems? Type684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.TimeArrayItemField>? Type685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SegmentField? Type686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTimeRange? Type687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SegmentDefinition? Type688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.SegmentField>? Type689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AnalyzeTimeRange>? Type690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncResponseFormatSegmentTimeFormat? Type691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncResponseFormat? Type692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.SegmentDefinition>? Type693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateAsyncAnalyzeRequest? Type694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AnalyzeImageInput>? Type695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskStatus? Type696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateAnalyzeTaskResponse? Type697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTasksGetParametersAnalysisMode? Type698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskResponseVideoSourceType? Type699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskResponseVideoSourceSystemMetadata? Type700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskResponseVideoSource? Type701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskResponseRequestParamsAnalysisMode? Type702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskMediaSource? Type703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskResponseRequestParamsPromptV2? Type704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AnalyzeTaskMediaSource>? Type705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskResponseRequestParamsResponseFormatType? Type706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskResponseRequestParamsResponseFormatJsonSchema? Type707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskResponseRequestParamsResponseFormatSegmentTimeFormat? Type708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskSegmentFieldFormat? Type709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskTimeArrayItemFieldItems? Type710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskTimeArrayItemField? Type711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskSegmentFieldItems? Type712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AnalyzeTaskTimeArrayItemField>? Type713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskSegmentField? Type714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskResponseRequestParamsResponseFormatSegmentDefinitionsItems? Type715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AnalyzeTaskSegmentField>? Type716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskResponseRequestParamsResponseFormat? Type717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AnalyzeTaskResponseRequestParamsResponseFormatSegmentDefinitionsItems>? Type718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskResponseRequestParamsMaxTokens1? Type719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskResponseRequestParamsMaxTokens? Type720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskResponseRequestParams? Type721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskResultUsage? Type722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskResult? Type723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskWebhookInfo? Type724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskResponse? Type725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AnalyzeTaskWebhookInfo>? Type726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeAsyncTasksListResponse200? Type727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AnalyzeTaskResponse>? Type728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListAsyncAnalysisTasksRequestBadRequestError? Type729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CancelAnalyzeTaskResponseStatus? Type730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CancelAnalyzeTaskResponse? Type731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateAnalyzeBatchRequestModelName? Type732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateAnalyzeBatchRequestAnalysisMode? Type733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.BatchPrompt? Type734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.BatchDefaults? Type735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.BatchVideoContextType? Type736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.BatchVideoContext? Type737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.BatchItemRequest? Type738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateAnalyzeBatchRequest? Type739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.BatchItemRequest>? Type740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.BatchStatus? Type741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreatedBatchItem? Type742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateAnalyzeBatchResponse? Type743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.CreatedBatchItem>? Type744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeBatchesGetParametersAnalysisModeSchemaItems? Type745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeBatchStatusResponseAnalysisMode? Type746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeBatchStatusResponse? Type747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeAsyncBatchesListResponse200? Type748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AnalyzeBatchStatusResponse>? Type749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.BatchItemStatus? Type750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.BatchItemError? Type751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.BatchResultItem? Type752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateRequest? Type753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.UpdateUserMetadataRequest? Type754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ReplaceUserMetadataRequest? Type755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EnableStorageAccountingRequest? Type756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AuthorizeConnectionRequest? Type757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateRedirectUriRequest? Type758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ImportFilesRequest? Type759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.ConnectionsConnectionIdImportsPostRequestBodyContentApplicationJsonSchemaItemsItems>? Type760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateRequest2? Type761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.UpdateRequest? Type762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateRequest3? Type763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateBulkRequest? Type764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.EntityCollectionsEntityCollectionIdEntitiesBulkPostRequestBodyContentApplicationJsonSchemaEntitiesItems>? Type765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.UpdateRequest2? Type766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateAssetsRequest? Type767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DeleteAssetsRequest? Type768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateRequest4? Type769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.UpdateRequest3? Type770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateRequest5? Type771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.UpdateKnowledgeStoreItemMetadataRequest? Type772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ReplaceKnowledgeStoreItemMetadataRequest? Type773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateRequest6? Type774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.UpdateRequest4? Type775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AddItemsRequest? Type776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RemoveItemsRequest? Type777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateStreamRequest? Type778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.ResponseInputItem>? Type779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.ResponsesPostRequestBodyContentApplicationJsonSchemaIncludeItems>? Type780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.ResponseToolInput>? Type781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.ResponseSelection>? Type782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateRequest7? Type783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.IndexesPostRequestBodyContentApplicationJsonSchemaModelsItems>? Type784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.UpdateRequest5? Type785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateRequest8? Type786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.UpdateRequest6? Type787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.UpdateRequest7? Type788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateRequest9? Type789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateRequest10? Type790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaSearchOptionsItems>? Type791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaTranscriptionOptionsItems>? Type792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateRequest11? Type793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.EmbedTasksPostRequestBodyContentMultipartFormDataSchemaVideoEmbeddingScopeItems>? Type794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateRequest12? Type795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeRequest? Type796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AssetsGetParametersAssetTypesSchemaItems>? Type797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AssetsAssetIdTranscriptionGetParametersIncludeSchemaItems>? Type798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.KnowledgeStoresKnowledgeStoreIdItemsGetParametersStatusSchemaItems>? Type799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.IndexesIndexIdIndexedAssetsGetParametersStatusSchemaItems>? Type800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::TwelveLabs.IndexesIndexIdIndexedAssetsGetParametersUserMetadataSchema>? Type801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.IndexesIndexIdIndexedAssetsIndexedAssetIdGetParametersEmbeddingOptionSchemaItems>? Type802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::TwelveLabs.IndexesIndexIdVideosGetParametersUserMetadataSchema>? Type803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.IndexesIndexIdVideosVideoIdGetParametersEmbeddingOptionSchemaItems>? Type804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.TasksGetParametersStatusSchemaItems>? Type805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.EmbedTasksTaskIdGetParametersEmbeddingOptionSchemaItems>? Type806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.BatchStatus>? Type807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AnalyzeBatchesGetParametersAnalysisModeSchemaItems>? Type808 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.PresignedURLChunk>? ListType1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.ChunkInfo>? ListType2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.IncompleteUploadSummary>? ListType3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.CompletedChunk>? ListType4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.VideoStream>? ListType5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.AudioStream>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.AssetDetail>? ListType7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.AssetTranscriptionEntry>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.AssetTranscriptionUtterance>? ListType9 { get; set; }
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
        public global::System.Collections.Generic.List<global::TwelveLabs.MetadataScalarValue>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.VideoSearchModality>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.VideoMatch>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.SearchKnowledgeStoreHit>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.KnowledgeStoreItem>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.KnowledgeStoreItemTag>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.KnowledgeStoreItemCollection>? ListType26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.ResponseAnnotation>? ListType27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.ResponseOutputContentPart>? ListType28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.ResponseOutputItem>? ListType29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.IndexModelsItems>? ListType30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.Index>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<double>? ListType32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.VideoSegment>? ListType33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.TranscriptionDataItems>? ListType34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.IndexedAsset>? ListType35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.IndexedAssetSummary>? ListType36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.VideoVector>? ListType37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.VideoIndexingTask>? ListType38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<byte[]>? ListType39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.SearchItemClipsItems>? ListType40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.SearchItem>? ListType41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.AudioInputRequestEmbeddingOptionItems>? ListType42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.AudioInputRequestEmbeddingScopeItems>? ListType43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.AudioInputRequestEmbeddingTypeItems>? ListType44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.VideoInputRequestEmbeddingOptionItems>? ListType45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.VideoInputRequestEmbeddingScopeItems>? ListType46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.VideoInputRequestEmbeddingTypeItems>? ListType47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.MultiInputMediaSource>? ListType48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.EmbeddingAudioMetadataEmbeddingScopesItems>? ListType49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.EmbeddingVideoMetadataEmbeddingScopesItems>? ListType50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.EmbeddingData>? ListType51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.AsyncAudioInputRequestEmbeddingOptionItems>? ListType52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.AsyncAudioInputRequestEmbeddingScopeItems>? ListType53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.AsyncAudioInputRequestEmbeddingTypeItems>? ListType54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.TimeBasedMetadataEntry>? ListType55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.AsyncVideoInputRequestEmbeddingOptionItems>? ListType56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.AsyncVideoInputRequestEmbeddingScopeItems>? ListType57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.AsyncVideoInputRequestEmbeddingTypeItems>? ListType58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.AsyncDocumentInputRequestEmbeddingOptionItems>? ListType59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.AsyncDocumentInputRequestEmbeddingTypeItems>? ListType60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.AsyncDocumentInputRequestEmbeddingScopeItems>? ListType61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.AsyncImageInputRequestEmbeddingOptionItems>? ListType62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.AsyncImageInputRequestEmbeddingTypeItems>? ListType63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.AsyncImageInputRequestEmbeddingScopeItems>? ListType64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.MediaEmbeddingTask>? ListType65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.AsyncDocumentMetadataEmbeddingScopesItems>? ListType66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.AsyncImageMetadataEmbeddingScopesItems>? ListType67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.BaseSegment>? ListType68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.AudioSegment>? ListType69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.SMEMediaSource>? ListType70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.TimeArrayItemField>? ListType71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.SegmentField>? ListType72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.AnalyzeTimeRange>? ListType73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.SegmentDefinition>? ListType74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.AnalyzeImageInput>? ListType75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.AnalyzeTaskMediaSource>? ListType76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.AnalyzeTaskTimeArrayItemField>? ListType77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.AnalyzeTaskSegmentField>? ListType78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.AnalyzeTaskResponseRequestParamsResponseFormatSegmentDefinitionsItems>? ListType79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.AnalyzeTaskWebhookInfo>? ListType80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.AnalyzeTaskResponse>? ListType81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.BatchItemRequest>? ListType82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.CreatedBatchItem>? ListType83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.AnalyzeBatchStatusResponse>? ListType84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.ConnectionsConnectionIdImportsPostRequestBodyContentApplicationJsonSchemaItemsItems>? ListType85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.EntityCollectionsEntityCollectionIdEntitiesBulkPostRequestBodyContentApplicationJsonSchemaEntitiesItems>? ListType86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.ResponseInputItem>? ListType87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.ResponsesPostRequestBodyContentApplicationJsonSchemaIncludeItems>? ListType88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.ResponseToolInput>? ListType89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.ResponseSelection>? ListType90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.IndexesPostRequestBodyContentApplicationJsonSchemaModelsItems>? ListType91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaSearchOptionsItems>? ListType92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaTranscriptionOptionsItems>? ListType93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.EmbedTasksPostRequestBodyContentMultipartFormDataSchemaVideoEmbeddingScopeItems>? ListType94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.AssetsGetParametersAssetTypesSchemaItems>? ListType95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.AssetsAssetIdTranscriptionGetParametersIncludeSchemaItems>? ListType96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.KnowledgeStoresKnowledgeStoreIdItemsGetParametersStatusSchemaItems>? ListType97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.IndexesIndexIdIndexedAssetsGetParametersStatusSchemaItems>? ListType98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.IndexesIndexIdIndexedAssetsIndexedAssetIdGetParametersEmbeddingOptionSchemaItems>? ListType99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.IndexesIndexIdVideosVideoIdGetParametersEmbeddingOptionSchemaItems>? ListType100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.TasksGetParametersStatusSchemaItems>? ListType101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.EmbedTasksTaskIdGetParametersEmbeddingOptionSchemaItems>? ListType102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.BatchStatus>? ListType103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::TwelveLabs.AnalyzeBatchesGetParametersAnalysisModeSchemaItems>? ListType104 { get; set; }
    }
}