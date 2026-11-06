
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
        public global::TwelveLabs.ReportChunkBatchRequestInternalServerError? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RequestAdditionalPresignedURLsRequest? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RequestAdditionalPresignedURLsResponse? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RequestAdditionalPresignedUrlsRequestBadRequestError? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RequestAdditionalPresignedUrlsRequestForbiddenError? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RequestAdditionalPresignedUrlsRequestInternalServerError? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AssetDetailMethod? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AssetDetailStatus? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AssetHlsStatus? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AssetHLS? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AssetThumbnailStatus? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AssetThumbnail? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoStream? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AudioStream? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TechnicalMetadata? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.VideoStream>? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AudioStream>? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AssetError? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AssetDetail? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RetrieveAssetRequestBadRequestError? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AssetsGetParametersAssetTypesSchemaItems? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AssetsListResponse200? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AssetDetail>? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListAssetsRequestBadRequestError? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DeleteAssetRequestBadRequestError? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.UpdateAssetUserMetadataRequestBadRequestError? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ReplaceAssetUserMetadataRequestBadRequestError? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DeleteAssetUserMetadataRequestBadRequestError? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AssetsAssetIdTranscriptionGetParametersIncludeSchemaItems? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AssetTranscriptionStatus? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AssetTranscriptionEntry? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AssetTranscriptionUtterance? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AssetTranscriptionError? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AssetTranscriptionResponse? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AssetTranscriptionEntry>? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AssetTranscriptionUtterance>? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RetrieveAssetTranscriptionRequestBadRequestError? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RetrieveAssetTranscriptionRequestNotFoundError? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AssetStorageAccounting? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EnableAssetStorageAccountingRequestBadRequestError? Type89 { get; set; }
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
        public global::TwelveLabs.DataConnectorsListConnectionsResponse200? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.Connection>? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListConnectionsRequestBadRequestError? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RetrieveConnectionRequestBadRequestError? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RetrieveConnectionRequestNotFoundError? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DeleteConnectionRequestBadRequestError? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DeleteConnectionRequestNotFoundError? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DataConnectorsCreateConnectionPickerTokenResponse200? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateConnectionPickerTokenRequestBadRequestError? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateConnectionPickerTokenRequestNotFoundError? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateConnectionPickerTokenRequestConflictError? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RedirectUri? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateRedirectUriRequestBadRequestError? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateRedirectUriRequestConflictError? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateRedirectUriRequestUnprocessableEntityError? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DataConnectorsListRedirectUrisResponse200? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.RedirectUri>? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListRedirectUrisRequestBadRequestError? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DeleteRedirectUriRequestBadRequestError? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DeleteRedirectUriRequestNotFoundError? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ConnectionsConnectionIdImportsPostRequestBodyContentApplicationJsonSchemaItemsItems? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ImportItemAction? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ImportItemStatus? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ImportItemError? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ImportItem? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ImportResult? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.ImportItem>? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ImportFilesRequestBadRequestError? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ImportFilesRequestNotFoundError? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ImportFilesRequestConflictError? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ImportProvider? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.Import? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ImportsListImportsResponse200? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.Import>? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListImportsRequestBadRequestError? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListImportsRequestNotFoundError? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ImportDetailProvider? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ImportDetail? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RetrieveImportRequestBadRequestError? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RetrieveImportRequestNotFoundError? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EntityCollectionsGetParametersSortBy? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EntityCollection? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EntityCollectionsListResponse200? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.EntityCollection>? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListEntityCollectionsRequestBadRequestError? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateEntityCollectionRequestBadRequestError? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RetrieveEntityCollectionRequestBadRequestError? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.UpdateEntityCollectionRequestBadRequestError? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DeleteEntityCollectionRequestBadRequestError? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EntityCollectionsEntityCollectionIdEntitiesGetParametersStatus? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EntityCollectionsEntityCollectionIdEntitiesGetParametersSortBy? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EntityMetadata? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EntityStatus? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.Entity? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EntityCollectionsEntitiesListResponse200? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.Entity>? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListEntitiesInCollectionRequestBadRequestError? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EntityCollectionsEntityCollectionIdEntitiesPostRequestBodyContentApplicationJsonSchemaMetadata? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateEntityRequestBadRequestError? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EntityCollectionsEntityCollectionIdEntitiesBulkPostRequestBodyContentApplicationJsonSchemaEntitiesItemsMetadata? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EntityCollectionsEntityCollectionIdEntitiesBulkPostRequestBodyContentApplicationJsonSchemaEntitiesItems? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.BulkCreateEntityResponseEntitiesItems? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.BulkCreateEntityResponseErrorsItems? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.BulkCreateEntityResponse? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.BulkCreateEntityResponseEntitiesItems>? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.BulkCreateEntityResponseErrorsItems>? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateEntitiesBulkRequestBadRequestError? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RetrieveEntityRequestBadRequestError? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EntityCollectionsEntityCollectionIdEntitiesEntityIdPatchRequestBodyContentApplicationJsonSchemaMetadata? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.UpdateEntityRequestBadRequestError? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DeleteEntityRequestBadRequestError? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AddEntityAssetsRequestBadRequestError? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RemoveEntityAssetsRequestBadRequestError? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EntityCollectionsEntitiesListByAssetResponse200? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListEntitiesByAssetRequestBadRequestError? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EnrichmentConfigJsonSchemaType? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EnrichmentConfigJsonSchemaJsonSchemaType? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EnrichmentConfigJsonSchemaJsonSchema? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type175 { get; set; }
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
        public global::System.Collections.Generic.Dictionary<string, global::TwelveLabs.KnowledgeStoreMetadataValue>? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateKnowledgeStoreRequestBadRequestError? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateKnowledgeStoreRequestUnprocessableEntityError? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.KnowledgeStoresGetParametersSortBy? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.KnowledgeStoresListResponse200? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.KnowledgeStore>? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListKnowledgeStoresRequestBadRequestError? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RetrieveKnowledgeStoreRequestBadRequestError? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.UpdateKnowledgeStoreRequestBadRequestError? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.UpdateKnowledgeStoreRequestUnprocessableEntityError? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DeleteKnowledgeStoreRequestBadRequestError? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.KnowledgeStoreSearchQuery? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.KnowledgeStoreItemAssetType? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AssetTypeFilter? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.KnowledgeStoreItemAssetType>? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ItemIdFilter? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ItemCollectionIdFilter? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.MetadataScalarValue? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.MetadataRangeBound? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.UserMetadataValueFilter? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.MetadataScalarValue>? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::TwelveLabs.UserMetadataValueFilter>? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.MetadataValueFilter? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::TwelveLabs.MetadataValueFilter>? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreatedAtFilter? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.GeoCircleFilter? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TagFilter? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchKnowledgeStoreFilter? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoSearchModality? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoSearchOptions? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.VideoSearchModality>? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchKnowledgeStoreOptions? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchKnowledgeStoreRequestGroupBy? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchKnowledgeStoreRequest? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoSearchSystemMetadata? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoSearchItemMetadata? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoMatch? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ImageSearchSystemMetadata? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ImageSearchItemMetadata? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchKnowledgeStoreHit? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchKnowledgeStoreHitVariant1? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchKnowledgeStoreHitVariant1AssetType? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.VideoMatch>? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchKnowledgeStoreHitVariant2? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchKnowledgeStoreHitVariant2AssetType? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchKnowledgeStoreHitDiscriminator? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchKnowledgeStoreHitDiscriminatorAssetType? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchKnowledgeStoreResponse? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.SearchKnowledgeStoreHit>? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchKnowledgeStoreRequestBadRequestError? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchKnowledgeStoreRequestNotFoundError? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchKnowledgeStoreRequestGoneError? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchKnowledgeStoreRequestUnprocessableEntityError? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.KnowledgeStoreItemStatus? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoMetadataAssetType? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ImageMetadataAssetType? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.KnowledgeStoreItemSystemMetadata? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.KnowledgeStoreItemSystemMetadataVariant1? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.KnowledgeStoreItemSystemMetadataVariant2? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.KnowledgeStoreItemSystemMetadataDiscriminator? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.KnowledgeStoreItemSystemMetadataDiscriminatorAssetType? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.KnowledgeStoreItem? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateKnowledgeStoreItemRequestBadRequestError? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateKnowledgeStoreItemRequestUnprocessableEntityError? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.KnowledgeStoresKnowledgeStoreIdItemsGetParametersStatusSchemaItems? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.KnowledgeStoreItemsListResponse200? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.KnowledgeStoreItem>? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RetrieveKnowledgeStoreItemRequestBadRequestError? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DeleteKnowledgeStoreItemRequestBadRequestError? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.UpdateKnowledgeStoreItemMetadataRequestBadRequestError? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.UpdateKnowledgeStoreItemMetadataRequestNotFoundError? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.UpdateKnowledgeStoreItemMetadataRequestUnprocessableEntityError? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ReplaceKnowledgeStoreItemMetadataRequestBadRequestError? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ReplaceKnowledgeStoreItemMetadataRequestNotFoundError? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ReplaceKnowledgeStoreItemMetadataRequestUnprocessableEntityError? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateKnowledgeStoreItemTagRequest? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.KnowledgeStoreItemTag? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateKnowledgeStoreItemTagRequestBadRequestError? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateKnowledgeStoreItemTagRequestNotFoundError? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.KnowledgeStoreItemTagsListResponse200? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.KnowledgeStoreItemTag>? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListKnowledgeStoreItemTagsRequestBadRequestError? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListKnowledgeStoreItemTagsRequestNotFoundError? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RetrieveKnowledgeStoreItemTagRequestBadRequestError? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RetrieveKnowledgeStoreItemTagRequestNotFoundError? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.UpdateKnowledgeStoreItemTagRequest? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.UpdateKnowledgeStoreItemTagRequestBadRequestError? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.UpdateKnowledgeStoreItemTagRequestNotFoundError? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DeleteKnowledgeStoreItemTagRequestBadRequestError? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DeleteKnowledgeStoreItemTagRequestNotFoundError? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.KnowledgeStoreItemCollection? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateKnowledgeStoreItemCollectionRequestBadRequestError? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateKnowledgeStoreItemCollectionRequestUnprocessableEntityError? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.KnowledgeStoresKnowledgeStoreIdItemCollectionsGetParametersSortBy? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.KnowledgeStoreItemCollectionsListResponse200? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.KnowledgeStoreItemCollection>? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListKnowledgeStoreItemCollectionsRequestBadRequestError? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RetrieveKnowledgeStoreItemCollectionRequestBadRequestError? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.UpdateKnowledgeStoreItemCollectionRequestBadRequestError? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.UpdateKnowledgeStoreItemCollectionRequestUnprocessableEntityError? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DeleteKnowledgeStoreItemCollectionRequestBadRequestError? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.KnowledgeStoreItemCollectionsListItemsResponse200? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListKnowledgeStoreItemCollectionItemsRequestBadRequestError? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AddItemsToKnowledgeStoreItemCollectionRequestBadRequestError? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RemoveItemsFromKnowledgeStoreItemCollectionRequestBadRequestError? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseInputItemType? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseInputItemRole? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseInputItem? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponsesPostRequestBodyContentApplicationJsonSchemaIncludeItems? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.WebSearchToolInputType? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseToolInput? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseToolInputVariant1? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseToolInputDiscriminator? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseToolInputDiscriminatorType? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseSelectionKind? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseSelection? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TextResponseFormatTextType? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TextResponseFormatJsonSchemaType? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TextParamFormat? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TextParamFormatVariant1? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TextParamFormatVariant2? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TextParamFormatDiscriminator? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TextParamFormatDiscriminatorType? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TextParam? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseObjectType? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseObjectObject? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStatus? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseIncompleteDetails? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStandardOutputItemType? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStandardOutputItemStatus? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStandardOutputItemRole? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseOutputContentPartType? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseAnnotation? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseOutputContentPart? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.ResponseAnnotation>? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseWebSearchOutputItemType? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.WebSearchAction? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseOutputItem? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseOutputItemVariant1? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.ResponseOutputContentPart>? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseOutputItemVariant2? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseOutputItemVariant3? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseOutputItemVariant4? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseOutputItemDiscriminator? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseOutputItemDiscriminatorType? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseBilling? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseObject? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.ResponseOutputItem>? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateResponseRequestBadRequestError? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateResponseRequestUnprocessableEntityError? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamResponseEventType? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamOutputItemAddedEventType? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamContentPartAddedEventType? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamOutputTextDeltaEventType? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamOutputTextDoneEventType? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamContentPartDoneEventType? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamOutputItemDoneEventType? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamFuncCallArgsDoneEventType? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamWebSearchProgressEventType? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamActivityEventType? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamActivityEventActivityStatus? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamActivityEventActivity? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamEvent? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamEventVariant1? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamEventVariant2? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamEventVariant3? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamEventVariant4? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamEventVariant5? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamEventVariant6? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamEventVariant7? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamEventVariant8? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamEventVariant9? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamEventVariant10? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamEventVariant11? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamEventVariant12? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamEventVariant13? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamEventVariant14? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamEventVariant15? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamEventDiscriminator? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamEventDiscriminatorType? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesPostRequestBodyContentApplicationJsonSchemaModelsItemsModelName? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesPostRequestBodyContentApplicationJsonSchemaModelsItems? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesCreateResponse201? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateIndexRequestBadRequestError? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexModelsItems? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.Index? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.IndexModelsItems>? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesListResponse200? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.Index>? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListIndexesRequestBadRequestError? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RetrieveIndexRequestBadRequestError? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.UpdateIndexRequestBadRequestError? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DeleteIndexRequestBadRequestError? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesIndexedAssetsCreateResponse202? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateIndexedAssetRequestBadRequestError? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateIndexedAssetRequestInternalServerError? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesIndexIdIndexedAssetsIndexedAssetIdGetParametersEmbeddingOptionSchemaItems? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexedAssetDetailedStatus? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexedAssetDetailedSystemMetadata? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.HlsObjectStatus? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.HLSObject? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoSegment? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<double>? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexedAssetDetailedEmbeddingVideoEmbedding? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.VideoSegment>? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexedAssetDetailedEmbedding? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TranscriptionDataItems? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.TranscriptionDataItems>? Type392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexedAssetDetailed? Type393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RetrieveIndexedAssetInformationRequestBadRequestError? Type394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RetrieveIndexedAssetInformationRequestNotFoundError? Type395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesIndexIdIndexedAssetsGetParametersStatusSchemaItems? Type396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesIndexIdIndexedAssetsGetParametersDuration? Type397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesIndexIdIndexedAssetsGetParametersFps? Type398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesIndexIdIndexedAssetsGetParametersWidth? Type399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesIndexIdIndexedAssetsGetParametersHeight? Type400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesIndexIdIndexedAssetsGetParametersSize? Type401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesIndexIdIndexedAssetsGetParametersUserMetadataSchema? Type402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexedAssetStatus? Type403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexedAssetSystemMetadata? Type404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexedAsset? Type405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesIndexedAssetsListResponse200? Type406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.IndexedAsset>? Type407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListIndexedAssetsRequestBadRequestError? Type408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DeleteIndexedAssetInformationRequestBadRequestError? Type409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.PartialUpdateIndexedAssetInformationRequestBadRequestError? Type410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexedAssetSummaryIndex? Type411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexedAssetSummary? Type412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesIndexedAssetsListByAssetResponse200? Type413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.IndexedAssetSummary>? Type414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListIndexedAssetsByAssetRequestBadRequestError? Type415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesIndexIdVideosGetParametersDuration? Type416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesIndexIdVideosGetParametersFps? Type417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesIndexIdVideosGetParametersWidth? Type418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesIndexIdVideosGetParametersHeight? Type419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesIndexIdVideosGetParametersSize? Type420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesIndexIdVideosGetParametersUserMetadataSchema? Type421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoVectorSystemMetadata? Type422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoVector? Type423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesVideosListResponse200? Type424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.VideoVector>? Type425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListVideosRequestBadRequestError? Type426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesIndexIdVideosVideoIdGetParametersEmbeddingOptionSchemaItems? Type427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesIndexIdVideosVideoIdGetResponsesContentApplicationJsonSchemaSystemMetadata? Type428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesIndexIdVideosVideoIdGetResponsesContentApplicationJsonSchemaEmbeddingVideoEmbedding? Type429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesIndexIdVideosVideoIdGetResponsesContentApplicationJsonSchemaEmbedding? Type430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesVideosRetrieveResponse200? Type431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RetrieveVideoInformationRequestBadRequestError? Type432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RetrieveVideoInformationRequestNotFoundError? Type433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.PartialUpdateVideoInformationRequestBadRequestError? Type434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DeleteVideoInformationRequestBadRequestError? Type435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TasksCreateResponse200? Type436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateVideoIndexingTaskRequestBadRequestError? Type437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TasksGetParametersStatusSchemaItems? Type438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoIndexingTaskSystemMetadata? Type439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoIndexingTask? Type440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TasksGetResponsesContentApplicationJsonSchemaPageInfo? Type441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TasksListResponse200? Type442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.VideoIndexingTask>? Type443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListVideoIndexingTasksRequestBadRequestError? Type444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TasksTaskIdGetResponsesContentApplicationJsonSchemaSystemMetadata? Type445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TasksRetrieveResponse200? Type446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RetrieveVideoIndexingTaskRequestBadRequestError? Type447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DeleteVideoIndexingTaskRequestBadRequestError? Type448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaType? Type449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaUrl? Type450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaFile? Type451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<byte[]>? Type453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaSearchOptionsItems? Type454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaTranscriptionOptionsItems? Type455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaGroupBy? Type456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaOperator? Type457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchItemClipsItems? Type458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchItem? Type459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.SearchItemClipsItems>? Type460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchResultsPageInfo? Type461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchPool? Type462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchResults? Type463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.SearchItem>? Type464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnyToVideoSearchRequestBadRequestError? Type465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchPageTokenGetResponsesContentApplicationJsonSchemaPageInfo? Type466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchRetrieveResponse200? Type467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnyToVideoRetrieveSpecificPageRequestBadRequestError? Type468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateEmbeddingsRequestInputType? Type469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateEmbeddingsRequestModelName? Type470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateEmbeddingsRequestEmbeddingDimension? Type471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TextInputRequest? Type472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.MediaSource? Type473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ImageInputRequest? Type474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TextImageInputRequest? Type475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AudioSegmentationFixed? Type476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AudioSegmentation? Type477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AudioSegmentationStrategy? Type478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AudioInputRequestEmbeddingOptionItems? Type479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AudioInputRequestEmbeddingScopeItems? Type480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AudioInputRequestEmbeddingTypeItems? Type481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AudioInputRequest? Type482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AudioInputRequestEmbeddingOptionItems>? Type483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AudioInputRequestEmbeddingScopeItems>? Type484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AudioInputRequestEmbeddingTypeItems>? Type485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoSegmentationDiscriminatorMappingDynamicDynamic? Type486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoSegmentationDiscriminatorMappingFixedFixed? Type487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoSegmentation? Type488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoSegmentationVariant1? Type489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoSegmentationVariant1Strategy? Type490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoSegmentationVariant2? Type491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoSegmentationVariant2Strategy? Type492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoSegmentationDiscriminator? Type493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoSegmentationDiscriminatorStrategy? Type494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoInputRequestEmbeddingOptionItems? Type495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoInputRequestEmbeddingScopeItems? Type496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoInputRequestEmbeddingTypeItems? Type497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoInputRequest? Type498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.VideoInputRequestEmbeddingOptionItems>? Type499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.VideoInputRequestEmbeddingScopeItems>? Type500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.VideoInputRequestEmbeddingTypeItems>? Type501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.MultiInputMediaSourceMediaType? Type502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.MultiInputMediaSource? Type503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.MultiInputRequest? Type504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.MultiInputMediaSource>? Type505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateEmbeddingsRequest? Type506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingDataEmbeddingOption? Type507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingDataEmbeddingScope? Type508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingDataQuadrant? Type509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingData? Type510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingUsageTruncationReason? Type511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingUsage? Type512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, int>? Type513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingImageMetadataInputType? Type514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingMediaMetadataInputType? Type515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingTextImageMetadataInputType? Type516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingAudioMetadataInputType? Type517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingAudioMetadataEmbeddingScopesItems? Type518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingVideoMetadataInputType? Type519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingVideoMetadataEmbeddingScopesItems? Type520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingMultiInputMetadataInputType? Type521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingMediaMetadata? Type522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingMediaMetadataVariant1? Type523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingMediaMetadataVariant2? Type524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingMediaMetadataVariant3? Type525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.EmbeddingAudioMetadataEmbeddingScopesItems>? Type526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingMediaMetadataVariant4? Type527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.EmbeddingVideoMetadataEmbeddingScopesItems>? Type528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingMediaMetadataVariant5? Type529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingMediaMetadataDiscriminator? Type530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingSuccessResponse? Type531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.EmbeddingData>? Type532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateAsyncEmbeddingRequestInputType? Type533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateAsyncEmbeddingRequestModelName? Type534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateAsyncEmbeddingRequestEmbeddingDimension? Type535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TemporalSegmentationDiscriminatorMappingDynamicDynamic? Type536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TemporalSegmentationDiscriminatorMappingFixedFixed? Type537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TemporalSegmentation? Type538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TemporalSegmentationVariant1? Type539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TemporalSegmentationVariant1Strategy? Type540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TemporalSegmentationVariant2? Type541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TemporalSegmentationVariant2Strategy? Type542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TemporalSegmentationDiscriminator? Type543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TemporalSegmentationDiscriminatorStrategy? Type544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncTemporalSegmentation? Type545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncAudioInputRequestSegmentation? Type546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncAudioInputRequestEmbeddingOptionItems? Type547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncAudioInputRequestEmbeddingScopeItems? Type548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncAudioInputRequestEmbeddingTypeItems? Type549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TimeBasedMetadataEntry? Type550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncAudioInputRequest? Type551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AsyncAudioInputRequestEmbeddingOptionItems>? Type552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AsyncAudioInputRequestEmbeddingScopeItems>? Type553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AsyncAudioInputRequestEmbeddingTypeItems>? Type554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.TimeBasedMetadataEntry>? Type555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncVideoInputRequestSegmentation? Type556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncVideoInputRequestEmbeddingOptionItems? Type557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncVideoInputRequestEmbeddingScopeItems? Type558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncVideoInputRequestEmbeddingTypeItems? Type559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncVideoInputRequest? Type560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AsyncVideoInputRequestEmbeddingOptionItems>? Type561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AsyncVideoInputRequestEmbeddingScopeItems>? Type562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AsyncVideoInputRequestEmbeddingTypeItems>? Type563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DocumentSpatialSegmentationStrategy? Type564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DocumentSpatialSegmentation? Type565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DocumentSequentialSegmentationStrategy? Type566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DocumentSequentialSegmentation? Type567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DocumentSegmentation? Type568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncDocumentInputRequestEmbeddingOptionItems? Type569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncDocumentInputRequestEmbeddingTypeItems? Type570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncDocumentInputRequestEmbeddingScopeItems? Type571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncDocumentInputRequest? Type572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AsyncDocumentInputRequestEmbeddingOptionItems>? Type573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AsyncDocumentInputRequestEmbeddingTypeItems>? Type574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AsyncDocumentInputRequestEmbeddingScopeItems>? Type575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncImageInputRequestEmbeddingOptionItems? Type576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncImageInputRequestEmbeddingTypeItems? Type577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncImageInputRequestEmbeddingScopeItems? Type578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncImageInputRequest? Type579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AsyncImageInputRequestEmbeddingOptionItems>? Type580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AsyncImageInputRequestEmbeddingTypeItems>? Type581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AsyncImageInputRequestEmbeddingScopeItems>? Type582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateAsyncEmbeddingRequest? Type583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbedV2TasksPostResponsesContentApplicationJsonSchemaStatus? Type584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbedV2TasksPostResponsesContentApplicationJsonSchemaMetadata? Type585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbedV2TasksCreateResponse202? Type586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoEmbeddingMetadata? Type587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.MediaEmbeddingTaskVideoEmbedding? Type588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AudioEmbeddingMetadata? Type589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.MediaEmbeddingTaskAudioEmbedding? Type590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DocumentEmbeddingMetadata? Type591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.MediaEmbeddingTaskDocumentEmbedding? Type592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ImageEmbeddingMetadata? Type593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.MediaEmbeddingTaskImageEmbedding? Type594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.MediaEmbeddingTask? Type595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbedV2TasksGetResponsesContentApplicationJsonSchemaPageInfo? Type596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbedV2TasksListResponse200? Type597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.MediaEmbeddingTask>? Type598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingTaskResponseStatus? Type599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingTaskMediaMetadataInputType? Type600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncDocumentMetadataInputType? Type601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncDocumentMetadataEmbeddingScopesItems? Type602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncImageMetadataInputType? Type603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncImageMetadataEmbeddingScopesItems? Type604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingTaskMediaMetadata? Type605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingTaskMediaMetadataVariant1? Type606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingTaskMediaMetadataVariant2? Type607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingTaskMediaMetadataVariant3? Type608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AsyncDocumentMetadataEmbeddingScopesItems>? Type609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingTaskMediaMetadataVariant4? Type610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AsyncImageMetadataEmbeddingScopesItems>? Type611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingTaskMediaMetadataDiscriminator? Type612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingTaskResponseError? Type613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingTaskResponse? Type614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbedTasksPostRequestBodyContentMultipartFormDataSchemaVideoEmbeddingScopeItems? Type615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbedTasksCreateResponse200? Type616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateVideoEmbeddingTaskRequestBadRequestError? Type617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbedTasksGetResponsesContentApplicationJsonSchemaPageInfo? Type618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbedTasksListResponse200? Type619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListVideoEmbeddingTasksRequestBadRequestError? Type620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbedTasksTaskIdStatusGetResponsesContentApplicationJsonSchemaVideoEmbedding? Type621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbedTasksStatusResponse200? Type622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RetrieveVideoEmbeddingTaskRequestBadRequestError? Type623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbedTasksTaskIdGetParametersEmbeddingOptionSchemaItems? Type624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbedTasksTaskIdGetResponsesContentApplicationJsonSchemaVideoEmbedding? Type625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbedTasksRetrieveResponse200? Type626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RetrieveVideoEmbeddingRequestBadRequestError? Type627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.BaseSegment? Type628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TextEmbeddingResult? Type629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.BaseSegment>? Type630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.BaseEmbeddingMetadata? Type631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ImageEmbeddingResult? Type632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AudioSegment? Type633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AudioEmbeddingResult? Type634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AudioSegment>? Type635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingResponse? Type636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateTextImageAudioEmbeddingRequestBadRequestError? Type637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzePostRequestBodyContentApplicationJsonSchemaModelName? Type638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoContext? Type639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoContextVariant1? Type640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoContextVariant1Type? Type641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoContextVariant2? Type642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoContextVariant2Type? Type643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoContextVariant3? Type644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoContextVariant3Type? Type645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoContextDiscriminator? Type646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoContextDiscriminatorType? Type647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeImageInput? Type648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SmeMediaSourceMediaType? Type649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SMEMediaSource? Type650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzePromptV2? Type651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.SMEMediaSource>? Type652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SyncResponseFormatType? Type653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SyncResponseFormatJsonSchema? Type654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SyncResponseFormat? Type655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.StreamStartResponseEventType? Type656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.StreamStartResponseMetadata? Type657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.StreamTextResponseEventType? Type658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.StreamEndResponseEventType? Type659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.FinishReason? Type660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TokenUsage? Type661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.StreamEndResponseMetadata? Type662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskError? Type663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.StreamAnalyzeResponse? Type664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.StreamAnalyzeResponseVariant1? Type665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.StreamAnalyzeResponseVariant2? Type666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.StreamAnalyzeResponseVariant3? Type667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.StreamAnalyzeResponseDiscriminator? Type668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.StreamAnalyzeResponseDiscriminatorEventType? Type669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.NonStreamAnalyzeResponse? Type670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeResponse200? Type671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.GenerateTextRepresentationRequestBadRequestError? Type672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateAsyncAnalyzeRequestModelName? Type673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateAsyncAnalyzeRequestAnalysisMode? Type674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateAsyncAnalyzeRequestMaxTokens1? Type675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateAsyncAnalyzeRequestMaxTokens? Type676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncResponseFormatType? Type677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncResponseFormatJsonSchema? Type678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SegmentFieldType? Type679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SegmentFieldFormat? Type680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SegmentFieldItemsType? Type681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TimeArrayItemFieldType? Type682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TimeArrayItemFieldItemsType? Type683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TimeArrayItemFieldItems? Type684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TimeArrayItemField? Type685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SegmentFieldItems? Type686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.TimeArrayItemField>? Type687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SegmentField? Type688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTimeRange? Type689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SegmentDefinition? Type690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.SegmentField>? Type691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AnalyzeTimeRange>? Type692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncResponseFormatSegmentTimeFormat? Type693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncResponseFormat? Type694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.SegmentDefinition>? Type695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateAsyncAnalyzeRequest? Type696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AnalyzeImageInput>? Type697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskStatus? Type698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateAnalyzeTaskResponse? Type699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ErrorResponseError? Type700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ErrorResponse? Type701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTasksGetParametersAnalysisMode? Type702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskResponseVideoSourceType? Type703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskResponseVideoSourceSystemMetadata? Type704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskResponseVideoSource? Type705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskResponseRequestParamsAnalysisMode? Type706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskMediaSource? Type707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskResponseRequestParamsPromptV2? Type708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AnalyzeTaskMediaSource>? Type709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskResponseRequestParamsResponseFormatType? Type710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskResponseRequestParamsResponseFormatJsonSchema? Type711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskResponseRequestParamsResponseFormatSegmentTimeFormat? Type712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskSegmentFieldFormat? Type713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskTimeArrayItemFieldItems? Type714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskTimeArrayItemField? Type715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskSegmentFieldItems? Type716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AnalyzeTaskTimeArrayItemField>? Type717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskSegmentField? Type718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskResponseRequestParamsResponseFormatSegmentDefinitionsItems? Type719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AnalyzeTaskSegmentField>? Type720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskResponseRequestParamsResponseFormat? Type721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AnalyzeTaskResponseRequestParamsResponseFormatSegmentDefinitionsItems>? Type722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskResponseRequestParamsMaxTokens1? Type723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskResponseRequestParamsMaxTokens? Type724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskResponseRequestParams? Type725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskResultUsage? Type726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskResult? Type727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskWebhookInfo? Type728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskResponse? Type729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AnalyzeTaskWebhookInfo>? Type730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeAsyncTasksListResponse200? Type731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AnalyzeTaskResponse>? Type732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListAsyncAnalysisTasksRequestBadRequestError? Type733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CancelAnalyzeTaskResponseStatus? Type734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CancelAnalyzeTaskResponse? Type735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateAnalyzeBatchRequestModelName? Type736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateAnalyzeBatchRequestAnalysisMode? Type737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.BatchPrompt? Type738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.BatchDefaults? Type739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.BatchVideoContextType? Type740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.BatchVideoContext? Type741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.BatchItemRequest? Type742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateAnalyzeBatchRequest? Type743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.BatchItemRequest>? Type744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.BatchStatus? Type745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreatedBatchItem? Type746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateAnalyzeBatchResponse? Type747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.CreatedBatchItem>? Type748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeBatchesGetParametersAnalysisModeSchemaItems? Type749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeBatchStatusResponseAnalysisMode? Type750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeBatchStatusResponse? Type751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeAsyncBatchesListResponse200? Type752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AnalyzeBatchStatusResponse>? Type753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.BatchItemStatus? Type754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.BatchItemError? Type755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.BatchResultItem? Type756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateRequest? Type757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.UpdateUserMetadataRequest? Type758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ReplaceUserMetadataRequest? Type759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EnableStorageAccountingRequest? Type760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AuthorizeConnectionRequest? Type761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateRedirectUriRequest? Type762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ImportFilesRequest? Type763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.ConnectionsConnectionIdImportsPostRequestBodyContentApplicationJsonSchemaItemsItems>? Type764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateRequest2? Type765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.UpdateRequest? Type766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateRequest3? Type767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateBulkRequest? Type768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.EntityCollectionsEntityCollectionIdEntitiesBulkPostRequestBodyContentApplicationJsonSchemaEntitiesItems>? Type769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.UpdateRequest2? Type770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateAssetsRequest? Type771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DeleteAssetsRequest? Type772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateRequest4? Type773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.UpdateRequest3? Type774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateRequest5? Type775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.UpdateKnowledgeStoreItemMetadataRequest? Type776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ReplaceKnowledgeStoreItemMetadataRequest? Type777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateRequest6? Type778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.UpdateRequest4? Type779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AddItemsRequest? Type780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RemoveItemsRequest? Type781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateStreamRequest? Type782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.ResponseInputItem>? Type783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.ResponsesPostRequestBodyContentApplicationJsonSchemaIncludeItems>? Type784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.ResponseToolInput>? Type785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.ResponseSelection>? Type786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateRequest7? Type787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.IndexesPostRequestBodyContentApplicationJsonSchemaModelsItems>? Type788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.UpdateRequest5? Type789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateRequest8? Type790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.UpdateRequest6? Type791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.UpdateRequest7? Type792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateRequest9? Type793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateRequest10? Type794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaSearchOptionsItems>? Type795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaTranscriptionOptionsItems>? Type796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateRequest11? Type797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.EmbedTasksPostRequestBodyContentMultipartFormDataSchemaVideoEmbeddingScopeItems>? Type798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateRequest12? Type799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeRequest? Type800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AssetsGetParametersAssetTypesSchemaItems>? Type801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AssetsAssetIdTranscriptionGetParametersIncludeSchemaItems>? Type802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.KnowledgeStoresKnowledgeStoreIdItemsGetParametersStatusSchemaItems>? Type803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.IndexesIndexIdIndexedAssetsGetParametersStatusSchemaItems>? Type804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::TwelveLabs.IndexesIndexIdIndexedAssetsGetParametersUserMetadataSchema>? Type805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.IndexesIndexIdIndexedAssetsIndexedAssetIdGetParametersEmbeddingOptionSchemaItems>? Type806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::TwelveLabs.IndexesIndexIdVideosGetParametersUserMetadataSchema>? Type807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.IndexesIndexIdVideosVideoIdGetParametersEmbeddingOptionSchemaItems>? Type808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.TasksGetParametersStatusSchemaItems>? Type809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.EmbedTasksTaskIdGetParametersEmbeddingOptionSchemaItems>? Type810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.BatchStatus>? Type811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AnalyzeBatchesGetParametersAnalysisModeSchemaItems>? Type812 { get; set; }

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