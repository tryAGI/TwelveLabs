
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
        public global::TwelveLabs.CreateAssetUploadRequestType? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateAssetUploadRequest? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public long? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.PresignedURLChunk? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateAssetUploadResponse? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.PresignedURLChunk>? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateMultipartUploadRequestBadRequestError? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateMultipartUploadRequestForbiddenError? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateMultipartUploadRequestInternalServerError? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.MultipartUploadStatusType? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ChunkInfoStatus? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ChunkInfo? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.PageInfo? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.GetUploadStatusResponse? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.ChunkInfo>? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.GetUploadStatusRequestBadRequestError? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.GetUploadStatusRequestForbiddenError? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.GetUploadStatusRequestInternalServerError? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IncompleteUploadSummary? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListIncompleteUploadsResponse? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.IncompleteUploadSummary>? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListIncompleteUploadsRequestBadRequestError? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListIncompleteUploadsRequestForbiddenError? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListIncompleteUploadsRequestInternalServerError? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CompletedChunkProofType? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CompletedChunk? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ReportChunkBatchRequest? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.CompletedChunk>? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ReportChunkBatchResponse? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ReportChunkBatchRequestBadRequestError? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ReportChunkBatchRequestForbiddenError? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RequestAdditionalPresignedURLsRequest? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RequestAdditionalPresignedURLsResponse? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RequestAdditionalPresignedUrlsRequestBadRequestError? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RequestAdditionalPresignedUrlsRequestForbiddenError? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RequestAdditionalPresignedUrlsRequestInternalServerError? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AssetDetailMethod? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AssetDetailStatus? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AssetHlsStatus? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AssetHLS? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AssetThumbnailStatus? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AssetThumbnail? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoStream? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AudioStream? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TechnicalMetadata? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.VideoStream>? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AudioStream>? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AssetError? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AssetDetail? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RetrieveAssetRequestBadRequestError? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RetrieveAssetRequestNotFoundError? Type68 { get; set; }
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
        public global::TwelveLabs.DeleteAssetRequestConflictError? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.UpdateAssetUserMetadataRequestBadRequestError? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.UpdateAssetUserMetadataRequestNotFoundError? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ReplaceAssetUserMetadataRequestBadRequestError? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ReplaceAssetUserMetadataRequestNotFoundError? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DeleteAssetUserMetadataRequestBadRequestError? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DeleteAssetUserMetadataRequestNotFoundError? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AssetsAssetIdTranscriptionGetParametersIncludeSchemaItems? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AssetTranscriptionStatus? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AssetTranscriptionEntry? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AssetTranscriptionUtterance? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AssetTranscriptionError? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AssetTranscriptionResponse? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AssetTranscriptionEntry>? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AssetTranscriptionUtterance>? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RetrieveAssetTranscriptionRequestBadRequestError? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RetrieveAssetTranscriptionRequestNotFoundError? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AssetStorageAccounting? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EnableAssetStorageAccountingRequestBadRequestError? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.FlatErrorResponse? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ConnectionsAuthorizePostRequestBodyContentApplicationJsonSchemaProvider? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DataConnectorsAuthorizeConnectionResponse200? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AuthorizeConnectionRequestBadRequestError? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ConnectionProvider? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ConnectionStatus? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ConnectionAccount? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.Connection? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DataConnectorsListConnectionsResponse200? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.Connection>? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListConnectionsRequestBadRequestError? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RetrieveConnectionRequestBadRequestError? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RetrieveConnectionRequestNotFoundError? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DeleteConnectionRequestBadRequestError? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DeleteConnectionRequestNotFoundError? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DataConnectorsCreateConnectionPickerTokenResponse200? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateConnectionPickerTokenRequestBadRequestError? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateConnectionPickerTokenRequestNotFoundError? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateConnectionPickerTokenRequestConflictError? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RedirectUri? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateRedirectUriRequestBadRequestError? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateRedirectUriRequestConflictError? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateRedirectUriRequestUnprocessableEntityError? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DataConnectorsListRedirectUrisResponse200? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.RedirectUri>? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListRedirectUrisRequestBadRequestError? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DeleteRedirectUriRequestBadRequestError? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DeleteRedirectUriRequestNotFoundError? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ConnectionsConnectionIdImportsPostRequestBodyContentApplicationJsonSchemaItemsItems? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ImportItemAction? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ImportItemStatus? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ImportItemError? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ImportItem? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ImportResult? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.ImportItem>? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ImportFilesRequestBadRequestError? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ImportFilesRequestNotFoundError? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ImportFilesRequestConflictError? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ImportProvider? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.Import? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ImportsListImportsResponse200? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.Import>? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListImportsRequestBadRequestError? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListImportsRequestNotFoundError? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ImportDetailProvider? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ImportDetail? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RetrieveImportRequestBadRequestError? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RetrieveImportRequestNotFoundError? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EntityCollectionsGetParametersSortBy? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EntityCollection? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EntityCollectionsListResponse200? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.EntityCollection>? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListEntityCollectionsRequestBadRequestError? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateEntityCollectionRequestBadRequestError? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RetrieveEntityCollectionRequestBadRequestError? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.UpdateEntityCollectionRequestBadRequestError? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DeleteEntityCollectionRequestBadRequestError? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EntityCollectionsEntityCollectionIdEntitiesGetParametersStatus? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EntityCollectionsEntityCollectionIdEntitiesGetParametersSortBy? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EntityMetadata? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EntityStatus? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.Entity? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EntityCollectionsEntitiesListResponse200? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.Entity>? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListEntitiesInCollectionRequestBadRequestError? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EntityCollectionsEntityCollectionIdEntitiesPostRequestBodyContentApplicationJsonSchemaMetadata? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateEntityRequestBadRequestError? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EntityCollectionsEntityCollectionIdEntitiesBulkPostRequestBodyContentApplicationJsonSchemaEntitiesItemsMetadata? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EntityCollectionsEntityCollectionIdEntitiesBulkPostRequestBodyContentApplicationJsonSchemaEntitiesItems? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.BulkCreateEntityResponseEntitiesItems? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.BulkCreateEntityResponseErrorsItems? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.BulkCreateEntityResponse? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.BulkCreateEntityResponseEntitiesItems>? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.BulkCreateEntityResponseErrorsItems>? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateEntitiesBulkRequestBadRequestError? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RetrieveEntityRequestBadRequestError? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EntityCollectionsEntityCollectionIdEntitiesEntityIdPatchRequestBodyContentApplicationJsonSchemaMetadata? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.UpdateEntityRequestBadRequestError? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DeleteEntityRequestBadRequestError? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AddEntityAssetsRequestBadRequestError? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RemoveEntityAssetsRequestBadRequestError? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EntityCollectionsEntitiesListByAssetResponse200? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListEntitiesByAssetRequestBadRequestError? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EnrichmentConfigJsonSchemaType? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EnrichmentConfigJsonSchemaJsonSchemaType? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EnrichmentConfigJsonSchemaJsonSchema? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EnrichmentConfigDescriptionType? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EnrichmentConfig? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EnrichmentConfigVariant1? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EnrichmentConfigVariant2? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EnrichmentConfigDiscriminator? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EnrichmentConfigDiscriminatorType? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IngestionConfig? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.KnowledgeStoreMetadataValue? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.KnowledgeStore? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::TwelveLabs.KnowledgeStoreMetadataValue>? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateKnowledgeStoreRequestBadRequestError? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateKnowledgeStoreRequestUnprocessableEntityError? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.KnowledgeStoresGetParametersSortBy? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.KnowledgeStoresListResponse200? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.KnowledgeStore>? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListKnowledgeStoresRequestBadRequestError? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RetrieveKnowledgeStoreRequestBadRequestError? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.UpdateKnowledgeStoreRequestBadRequestError? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.UpdateKnowledgeStoreRequestUnprocessableEntityError? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DeleteKnowledgeStoreRequestBadRequestError? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.KnowledgeStoreSearchQuery? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.KnowledgeStoreItemAssetType? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AssetTypeFilter? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.KnowledgeStoreItemAssetType>? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ItemIdFilter? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ItemCollectionIdFilter? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.MetadataScalarValue? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.MetadataRangeBound? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.UserMetadataValueFilter? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.MetadataScalarValue>? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::TwelveLabs.UserMetadataValueFilter>? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.MetadataValueFilter? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::TwelveLabs.MetadataValueFilter>? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreatedAtFilter? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.GeoCircleFilter? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TagFilter? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchKnowledgeStoreFilter? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoSearchModality? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoSearchOptions? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.VideoSearchModality>? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchKnowledgeStoreOptions? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchKnowledgeStoreRequestGroupBy? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchKnowledgeStoreRequest? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoSearchSystemMetadata? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoSearchItemMetadata? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoMatch? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ImageSearchSystemMetadata? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ImageSearchItemMetadata? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchKnowledgeStoreHit? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchKnowledgeStoreHitVariant1? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchKnowledgeStoreHitVariant1AssetType? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.VideoMatch>? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchKnowledgeStoreHitVariant2? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchKnowledgeStoreHitVariant2AssetType? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchKnowledgeStoreHitDiscriminator? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchKnowledgeStoreHitDiscriminatorAssetType? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchKnowledgeStoreResponse? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.SearchKnowledgeStoreHit>? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchKnowledgeStoreRequestBadRequestError? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchKnowledgeStoreRequestNotFoundError? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchKnowledgeStoreRequestGoneError? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchKnowledgeStoreRequestUnprocessableEntityError? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.KnowledgeStoreItemStatus? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoMetadataAssetType? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ImageMetadataAssetType? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.KnowledgeStoreItemSystemMetadata? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.KnowledgeStoreItemSystemMetadataVariant1? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.KnowledgeStoreItemSystemMetadataVariant2? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.KnowledgeStoreItemSystemMetadataDiscriminator? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.KnowledgeStoreItemSystemMetadataDiscriminatorAssetType? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.KnowledgeStoreItem? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateKnowledgeStoreItemRequestBadRequestError? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateKnowledgeStoreItemRequestUnprocessableEntityError? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.KnowledgeStoresKnowledgeStoreIdItemsGetParametersSortBy? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.KnowledgeStoresKnowledgeStoreIdItemsGetParametersStatusSchemaItems? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.KnowledgeStoreItemsListResponse200? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.KnowledgeStoreItem>? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListKnowledgeStoreItemsRequestBadRequestError? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RetrieveKnowledgeStoreItemRequestBadRequestError? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DeleteKnowledgeStoreItemRequestBadRequestError? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.UpdateKnowledgeStoreItemMetadataRequestBadRequestError? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.UpdateKnowledgeStoreItemMetadataRequestNotFoundError? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.UpdateKnowledgeStoreItemMetadataRequestUnprocessableEntityError? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ReplaceKnowledgeStoreItemMetadataRequestBadRequestError? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ReplaceKnowledgeStoreItemMetadataRequestNotFoundError? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ReplaceKnowledgeStoreItemMetadataRequestUnprocessableEntityError? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateKnowledgeStoreItemTagRequest? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.KnowledgeStoreItemTag? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateKnowledgeStoreItemTagRequestBadRequestError? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateKnowledgeStoreItemTagRequestNotFoundError? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.KnowledgeStoreItemTagsListResponse200? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.KnowledgeStoreItemTag>? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListKnowledgeStoreItemTagsRequestBadRequestError? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListKnowledgeStoreItemTagsRequestNotFoundError? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RetrieveKnowledgeStoreItemTagRequestBadRequestError? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RetrieveKnowledgeStoreItemTagRequestNotFoundError? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.UpdateKnowledgeStoreItemTagRequest? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.UpdateKnowledgeStoreItemTagRequestBadRequestError? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.UpdateKnowledgeStoreItemTagRequestNotFoundError? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DeleteKnowledgeStoreItemTagRequestBadRequestError? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DeleteKnowledgeStoreItemTagRequestNotFoundError? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.KnowledgeStoreItemCollection? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateKnowledgeStoreItemCollectionRequestBadRequestError? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateKnowledgeStoreItemCollectionRequestUnprocessableEntityError? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.KnowledgeStoresKnowledgeStoreIdItemCollectionsGetParametersSortBy? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.KnowledgeStoreItemCollectionsListResponse200? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.KnowledgeStoreItemCollection>? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListKnowledgeStoreItemCollectionsRequestBadRequestError? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RetrieveKnowledgeStoreItemCollectionRequestBadRequestError? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.UpdateKnowledgeStoreItemCollectionRequestBadRequestError? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.UpdateKnowledgeStoreItemCollectionRequestUnprocessableEntityError? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DeleteKnowledgeStoreItemCollectionRequestBadRequestError? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.KnowledgeStoreItemCollectionsListItemsResponse200? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListKnowledgeStoreItemCollectionItemsRequestBadRequestError? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AddItemsToKnowledgeStoreItemCollectionRequestBadRequestError? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RemoveItemsFromKnowledgeStoreItemCollectionRequestBadRequestError? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseInputItemType? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseInputItemRole? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseInputItem? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponsesPostRequestBodyContentApplicationJsonSchemaIncludeItems? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.WebSearchToolInputType? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseToolInput? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseToolInputVariant1? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseToolInputDiscriminator? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseToolInputDiscriminatorType? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseSelectionKind? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseSelection? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TextResponseFormatTextType? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TextResponseFormatJsonSchemaType? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TextParamFormat? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TextParamFormatVariant1? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TextParamFormatVariant2? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TextParamFormatDiscriminator? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TextParamFormatDiscriminatorType? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TextParam? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseObjectType? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseObjectObject? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStatus? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseIncompleteDetails? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStandardOutputItemType? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStandardOutputItemStatus? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStandardOutputItemRole? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseOutputContentPartType? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseAnnotation? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseOutputContentPart? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.ResponseAnnotation>? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseWebSearchOutputItemType? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.WebSearchAction? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseOutputItem? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseOutputItemVariant1? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.ResponseOutputContentPart>? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseOutputItemVariant2? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseOutputItemVariant3? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseOutputItemVariant4? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseOutputItemDiscriminator? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseOutputItemDiscriminatorType? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseBilling? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseObject? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.ResponseOutputItem>? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateResponseRequestBadRequestError? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateResponseRequestUnprocessableEntityError? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamResponseEventType? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamOutputItemAddedEventType? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamContentPartAddedEventType? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamOutputTextDeltaEventType? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamOutputTextDoneEventType? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamContentPartDoneEventType? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamOutputItemDoneEventType? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamFuncCallArgsDoneEventType? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamWebSearchProgressEventType? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamEvent? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamEventVariant1? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamEventVariant2? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamEventVariant3? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamEventVariant4? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamEventVariant5? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamEventVariant6? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamEventVariant7? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamEventVariant8? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamEventVariant9? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamEventVariant10? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamEventVariant11? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamEventVariant12? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamEventVariant13? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamEventVariant14? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamEventDiscriminator? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamEventDiscriminatorType? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesPostRequestBodyContentApplicationJsonSchemaModelsItemsModelName? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesPostRequestBodyContentApplicationJsonSchemaModelsItems? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesCreateResponse201? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateIndexRequestBadRequestError? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexModelsItems? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.Index? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.IndexModelsItems>? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesListResponse200? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.Index>? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListIndexesRequestBadRequestError? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RetrieveIndexRequestBadRequestError? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.UpdateIndexRequestBadRequestError? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DeleteIndexRequestBadRequestError? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesIndexedAssetsCreateResponse202? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateIndexedAssetRequestBadRequestError? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateIndexedAssetRequestNotFoundError? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateIndexedAssetRequestInternalServerError? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesIndexIdIndexedAssetsIndexedAssetIdGetParametersEmbeddingOptionSchemaItems? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexedAssetDetailedStatus? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexedAssetDetailedSystemMetadata? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.HlsObjectStatus? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.HLSObject? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoSegment? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<double>? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexedAssetDetailedEmbeddingVideoEmbedding? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.VideoSegment>? Type392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexedAssetDetailedEmbedding? Type393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TranscriptionDataItems? Type394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.TranscriptionDataItems>? Type395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexedAssetDetailed? Type396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RetrieveIndexedAssetInformationRequestBadRequestError? Type397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RetrieveIndexedAssetInformationRequestNotFoundError? Type398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesIndexIdIndexedAssetsGetParametersStatusSchemaItems? Type399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesIndexIdIndexedAssetsGetParametersDuration? Type400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesIndexIdIndexedAssetsGetParametersFps? Type401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesIndexIdIndexedAssetsGetParametersWidth? Type402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesIndexIdIndexedAssetsGetParametersHeight? Type403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesIndexIdIndexedAssetsGetParametersSize? Type404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesIndexIdIndexedAssetsGetParametersUserMetadataSchema? Type405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexedAssetStatus? Type406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexedAssetSystemMetadata? Type407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexedAsset? Type408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesIndexedAssetsListResponse200? Type409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.IndexedAsset>? Type410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListIndexedAssetsRequestBadRequestError? Type411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DeleteIndexedAssetInformationRequestBadRequestError? Type412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.PartialUpdateIndexedAssetInformationRequestBadRequestError? Type413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexedAssetSummaryIndex? Type414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexedAssetSummary? Type415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesIndexedAssetsListByAssetResponse200? Type416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.IndexedAssetSummary>? Type417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListIndexedAssetsByAssetRequestBadRequestError? Type418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesIndexIdVideosGetParametersDuration? Type419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesIndexIdVideosGetParametersFps? Type420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesIndexIdVideosGetParametersWidth? Type421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesIndexIdVideosGetParametersHeight? Type422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesIndexIdVideosGetParametersSize? Type423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesIndexIdVideosGetParametersUserMetadataSchema? Type424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoVectorSystemMetadata? Type425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoVector? Type426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesVideosListResponse200? Type427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.VideoVector>? Type428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListVideosRequestBadRequestError? Type429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesIndexIdVideosVideoIdGetParametersEmbeddingOptionSchemaItems? Type430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesIndexIdVideosVideoIdGetResponsesContentApplicationJsonSchemaSystemMetadata? Type431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesIndexIdVideosVideoIdGetResponsesContentApplicationJsonSchemaEmbeddingVideoEmbedding? Type432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesIndexIdVideosVideoIdGetResponsesContentApplicationJsonSchemaEmbedding? Type433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.IndexesVideosRetrieveResponse200? Type434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RetrieveVideoInformationRequestBadRequestError? Type435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RetrieveVideoInformationRequestNotFoundError? Type436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.PartialUpdateVideoInformationRequestBadRequestError? Type437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DeleteVideoInformationRequestBadRequestError? Type438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TasksCreateResponse200? Type439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateVideoIndexingTaskRequestBadRequestError? Type440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TasksGetParametersStatusSchemaItems? Type441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoIndexingTaskSystemMetadata? Type442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoIndexingTask? Type443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TasksGetResponsesContentApplicationJsonSchemaPageInfo? Type444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TasksListResponse200? Type445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.VideoIndexingTask>? Type446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListVideoIndexingTasksRequestBadRequestError? Type447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TasksTaskIdGetResponsesContentApplicationJsonSchemaSystemMetadata? Type448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TasksRetrieveResponse200? Type449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RetrieveVideoIndexingTaskRequestBadRequestError? Type450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DeleteVideoIndexingTaskRequestBadRequestError? Type451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaType? Type452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaUrl? Type453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaFile? Type454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<byte[]>? Type456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaSearchOptionsItems? Type457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaTranscriptionOptionsItems? Type458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaGroupBy? Type459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaOperator? Type460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchItemClipsItems? Type461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchItem? Type462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.SearchItemClipsItems>? Type463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchResultsPageInfo? Type464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchPool? Type465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchResults? Type466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.SearchItem>? Type467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnyToVideoSearchRequestBadRequestError? Type468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchPageTokenGetResponsesContentApplicationJsonSchemaPageInfo? Type469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SearchRetrieveResponse200? Type470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnyToVideoRetrieveSpecificPageRequestBadRequestError? Type471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateEmbeddingsRequestInputType? Type472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateEmbeddingsRequestModelName? Type473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateEmbeddingsRequestEmbeddingDimension? Type474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TextInputRequest? Type475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.MediaSource? Type476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ImageInputRequest? Type477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TextImageInputRequest? Type478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AudioSegmentationFixed? Type479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AudioSegmentation? Type480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AudioSegmentationStrategy? Type481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AudioInputRequestEmbeddingOptionItems? Type482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AudioInputRequestEmbeddingScopeItems? Type483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AudioInputRequestEmbeddingTypeItems? Type484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AudioInputRequest? Type485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AudioInputRequestEmbeddingOptionItems>? Type486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AudioInputRequestEmbeddingScopeItems>? Type487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AudioInputRequestEmbeddingTypeItems>? Type488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoSegmentationDiscriminatorMappingDynamicDynamic? Type489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoSegmentationDiscriminatorMappingFixedFixed? Type490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoSegmentation? Type491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoSegmentationVariant1? Type492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoSegmentationVariant1Strategy? Type493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoSegmentationVariant2? Type494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoSegmentationVariant2Strategy? Type495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoSegmentationDiscriminator? Type496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoSegmentationDiscriminatorStrategy? Type497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoInputRequestEmbeddingOptionItems? Type498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoInputRequestEmbeddingScopeItems? Type499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoInputRequestEmbeddingTypeItems? Type500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoInputRequest? Type501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.VideoInputRequestEmbeddingOptionItems>? Type502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.VideoInputRequestEmbeddingScopeItems>? Type503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.VideoInputRequestEmbeddingTypeItems>? Type504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.MultiInputMediaSourceMediaType? Type505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.MultiInputMediaSource? Type506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.MultiInputRequest? Type507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.MultiInputMediaSource>? Type508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateEmbeddingsRequest? Type509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingDataEmbeddingOption? Type510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingDataEmbeddingScope? Type511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingDataQuadrant? Type512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingData? Type513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingUsageTruncationReason? Type514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingUsage? Type515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, int>? Type516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingImageMetadataInputType? Type517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingMediaMetadataInputType? Type518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingTextImageMetadataInputType? Type519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingAudioMetadataInputType? Type520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingAudioMetadataEmbeddingScopesItems? Type521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingVideoMetadataInputType? Type522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingVideoMetadataEmbeddingScopesItems? Type523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingMultiInputMetadataInputType? Type524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingMediaMetadata? Type525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingMediaMetadataVariant1? Type526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingMediaMetadataVariant2? Type527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingMediaMetadataVariant3? Type528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.EmbeddingAudioMetadataEmbeddingScopesItems>? Type529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingMediaMetadataVariant4? Type530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.EmbeddingVideoMetadataEmbeddingScopesItems>? Type531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingMediaMetadataVariant5? Type532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingMediaMetadataDiscriminator? Type533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingSuccessResponse? Type534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.EmbeddingData>? Type535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ErrorResponseError? Type536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ErrorResponse? Type537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateAsyncEmbeddingRequestInputType? Type538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateAsyncEmbeddingRequestModelName? Type539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateAsyncEmbeddingRequestEmbeddingDimension? Type540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TemporalSegmentationDiscriminatorMappingDynamicDynamic? Type541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TemporalSegmentationDiscriminatorMappingFixedFixed? Type542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TemporalSegmentation? Type543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TemporalSegmentationVariant1? Type544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TemporalSegmentationVariant1Strategy? Type545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TemporalSegmentationVariant2? Type546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TemporalSegmentationVariant2Strategy? Type547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TemporalSegmentationDiscriminator? Type548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TemporalSegmentationDiscriminatorStrategy? Type549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncTemporalSegmentation? Type550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncAudioInputRequestSegmentation? Type551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncAudioInputRequestEmbeddingOptionItems? Type552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncAudioInputRequestEmbeddingScopeItems? Type553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncAudioInputRequestEmbeddingTypeItems? Type554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TimeBasedMetadataEntry? Type555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncAudioInputRequest? Type556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AsyncAudioInputRequestEmbeddingOptionItems>? Type557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AsyncAudioInputRequestEmbeddingScopeItems>? Type558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AsyncAudioInputRequestEmbeddingTypeItems>? Type559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.TimeBasedMetadataEntry>? Type560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncVideoInputRequestSegmentation? Type561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncVideoInputRequestEmbeddingOptionItems? Type562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncVideoInputRequestEmbeddingScopeItems? Type563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncVideoInputRequestEmbeddingTypeItems? Type564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncVideoInputRequest? Type565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AsyncVideoInputRequestEmbeddingOptionItems>? Type566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AsyncVideoInputRequestEmbeddingScopeItems>? Type567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AsyncVideoInputRequestEmbeddingTypeItems>? Type568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DocumentSpatialSegmentationStrategy? Type569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DocumentSpatialSegmentation? Type570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DocumentSequentialSegmentationStrategy? Type571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DocumentSequentialSegmentation? Type572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DocumentSegmentation? Type573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncDocumentInputRequestEmbeddingOptionItems? Type574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncDocumentInputRequestEmbeddingTypeItems? Type575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncDocumentInputRequestEmbeddingScopeItems? Type576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncDocumentInputRequest? Type577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AsyncDocumentInputRequestEmbeddingOptionItems>? Type578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AsyncDocumentInputRequestEmbeddingTypeItems>? Type579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AsyncDocumentInputRequestEmbeddingScopeItems>? Type580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncImageInputRequestEmbeddingOptionItems? Type581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncImageInputRequestEmbeddingTypeItems? Type582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncImageInputRequestEmbeddingScopeItems? Type583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncImageInputRequest? Type584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AsyncImageInputRequestEmbeddingOptionItems>? Type585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AsyncImageInputRequestEmbeddingTypeItems>? Type586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AsyncImageInputRequestEmbeddingScopeItems>? Type587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateAsyncEmbeddingRequest? Type588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbedV2TasksPostResponsesContentApplicationJsonSchemaStatus? Type589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbedV2TasksPostResponsesContentApplicationJsonSchemaMetadata? Type590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbedV2TasksCreateResponse202? Type591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoEmbeddingMetadata? Type592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.MediaEmbeddingTaskVideoEmbedding? Type593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AudioEmbeddingMetadata? Type594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.MediaEmbeddingTaskAudioEmbedding? Type595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DocumentEmbeddingMetadata? Type596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.MediaEmbeddingTaskDocumentEmbedding? Type597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ImageEmbeddingMetadata? Type598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.MediaEmbeddingTaskImageEmbedding? Type599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.MediaEmbeddingTask? Type600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbedV2TasksGetResponsesContentApplicationJsonSchemaPageInfo? Type601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbedV2TasksListResponse200? Type602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.MediaEmbeddingTask>? Type603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListAsyncEmbeddingTasksRequestBadRequestError? Type604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingTaskResponseStatus? Type605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingTaskMediaMetadataInputType? Type606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncDocumentMetadataInputType? Type607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncDocumentMetadataEmbeddingScopesItems? Type608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncImageMetadataInputType? Type609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncImageMetadataEmbeddingScopesItems? Type610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingTaskMediaMetadata? Type611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingTaskMediaMetadataVariant1? Type612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingTaskMediaMetadataVariant2? Type613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingTaskMediaMetadataVariant3? Type614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AsyncDocumentMetadataEmbeddingScopesItems>? Type615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingTaskMediaMetadataVariant4? Type616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AsyncImageMetadataEmbeddingScopesItems>? Type617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingTaskMediaMetadataDiscriminator? Type618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingTaskResponseError? Type619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingTaskResponse? Type620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbedTasksPostRequestBodyContentMultipartFormDataSchemaVideoEmbeddingScopeItems? Type621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbedTasksCreateResponse200? Type622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateVideoEmbeddingTaskRequestBadRequestError? Type623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbedTasksGetResponsesContentApplicationJsonSchemaPageInfo? Type624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbedTasksListResponse200? Type625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListVideoEmbeddingTasksRequestBadRequestError? Type626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbedTasksTaskIdStatusGetResponsesContentApplicationJsonSchemaVideoEmbedding? Type627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbedTasksStatusResponse200? Type628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RetrieveVideoEmbeddingTaskRequestBadRequestError? Type629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbedTasksTaskIdGetParametersEmbeddingOptionSchemaItems? Type630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbedTasksTaskIdGetResponsesContentApplicationJsonSchemaVideoEmbedding? Type631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbedTasksRetrieveResponse200? Type632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RetrieveVideoEmbeddingRequestBadRequestError? Type633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.BaseSegment? Type634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TextEmbeddingResult? Type635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.BaseSegment>? Type636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.BaseEmbeddingMetadata? Type637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ImageEmbeddingResult? Type638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AudioSegment? Type639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AudioEmbeddingResult? Type640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AudioSegment>? Type641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EmbeddingResponse? Type642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateTextImageAudioEmbeddingRequestBadRequestError? Type643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzePostRequestBodyContentApplicationJsonSchemaModelName? Type644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoContext? Type645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoContextVariant1? Type646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoContextVariant1Type? Type647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoContextVariant2? Type648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoContextVariant2Type? Type649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoContextVariant3? Type650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoContextVariant3Type? Type651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoContextDiscriminator? Type652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.VideoContextDiscriminatorType? Type653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeImageInput? Type654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SmeMediaSourceMediaType? Type655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SMEMediaSource? Type656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzePromptV2? Type657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.SMEMediaSource>? Type658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SyncResponseFormatType? Type659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SyncResponseFormatJsonSchema? Type660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SyncResponseFormat? Type661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.StreamStartResponseEventType? Type662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.StreamStartResponseMetadata? Type663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.StreamTextResponseEventType? Type664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.StreamEndResponseEventType? Type665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.FinishReason? Type666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TokenUsage? Type667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.StreamEndResponseMetadata? Type668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskError? Type669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.StreamAnalyzeResponse? Type670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.StreamAnalyzeResponseVariant1? Type671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.StreamAnalyzeResponseVariant2? Type672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.StreamAnalyzeResponseVariant3? Type673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.StreamAnalyzeResponseDiscriminator? Type674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.StreamAnalyzeResponseDiscriminatorEventType? Type675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.NonStreamAnalyzeResponse? Type676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeResponse200? Type677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.GenerateTextRepresentationRequestBadRequestError? Type678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.GenerateTextRepresentationRequestNotFoundError? Type679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateAsyncAnalyzeRequestModelName? Type680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateAsyncAnalyzeRequestAnalysisMode? Type681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateAsyncAnalyzeRequestMaxTokens1? Type682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateAsyncAnalyzeRequestMaxTokens? Type683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncResponseFormatType? Type684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncResponseFormatJsonSchema? Type685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SegmentFieldType? Type686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SegmentFieldFormat? Type687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SegmentFieldItemsType? Type688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TimeArrayItemFieldType? Type689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TimeArrayItemFieldItemsType? Type690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TimeArrayItemFieldItems? Type691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.TimeArrayItemField? Type692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SegmentFieldItems? Type693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.TimeArrayItemField>? Type694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SegmentField? Type695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTimeRange? Type696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.SegmentDefinition? Type697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.SegmentField>? Type698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AnalyzeTimeRange>? Type699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncResponseFormatSegmentTimeFormat? Type700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AsyncResponseFormat? Type701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.SegmentDefinition>? Type702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateAsyncAnalyzeRequest? Type703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AnalyzeImageInput>? Type704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskStatus? Type705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateAnalyzeTaskResponse? Type706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTasksGetParametersAnalysisMode? Type707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskResponseVideoSourceType? Type708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskResponseVideoSourceSystemMetadata? Type709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskResponseVideoSource? Type710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskResponseRequestParamsAnalysisMode? Type711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskMediaSource? Type712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskResponseRequestParamsPromptV2? Type713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AnalyzeTaskMediaSource>? Type714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskResponseRequestParamsResponseFormatType? Type715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskResponseRequestParamsResponseFormatJsonSchema? Type716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskResponseRequestParamsResponseFormatSegmentTimeFormat? Type717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskSegmentFieldFormat? Type718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskTimeArrayItemFieldItems? Type719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskTimeArrayItemField? Type720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskSegmentFieldItems? Type721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AnalyzeTaskTimeArrayItemField>? Type722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskSegmentField? Type723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskResponseRequestParamsResponseFormatSegmentDefinitionsItems? Type724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AnalyzeTaskSegmentField>? Type725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskResponseRequestParamsResponseFormat? Type726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AnalyzeTaskResponseRequestParamsResponseFormatSegmentDefinitionsItems>? Type727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskResponseRequestParamsMaxTokens1? Type728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskResponseRequestParamsMaxTokens? Type729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskResponseRequestParams? Type730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskResultUsage? Type731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskResult? Type732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskWebhookInfo? Type733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeTaskResponse? Type734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AnalyzeTaskWebhookInfo>? Type735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeAsyncTasksListResponse200? Type736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AnalyzeTaskResponse>? Type737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ListAsyncAnalysisTasksRequestBadRequestError? Type738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CancelAnalyzeTaskResponseStatus? Type739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CancelAnalyzeTaskResponse? Type740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateAnalyzeBatchRequestModelName? Type741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateAnalyzeBatchRequestAnalysisMode? Type742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.BatchPrompt? Type743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.BatchDefaults? Type744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.BatchVideoContextType? Type745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.BatchVideoContext? Type746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.BatchItemRequest? Type747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateAnalyzeBatchRequest? Type748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.BatchItemRequest>? Type749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.BatchStatus? Type750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreatedBatchItem? Type751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateAnalyzeBatchResponse? Type752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.CreatedBatchItem>? Type753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeBatchesGetParametersAnalysisModeSchemaItems? Type754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeBatchStatusResponseAnalysisMode? Type755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeBatchStatusResponse? Type756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeAsyncBatchesListResponse200? Type757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AnalyzeBatchStatusResponse>? Type758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.BatchItemStatus? Type759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.BatchItemError? Type760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.BatchResultItem? Type761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateRequest? Type762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.UpdateUserMetadataRequest? Type763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ReplaceUserMetadataRequest? Type764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.EnableStorageAccountingRequest? Type765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AuthorizeConnectionRequest? Type766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateRedirectUriRequest? Type767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ImportFilesRequest? Type768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.ConnectionsConnectionIdImportsPostRequestBodyContentApplicationJsonSchemaItemsItems>? Type769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateRequest2? Type770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.UpdateRequest? Type771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateRequest3? Type772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateBulkRequest? Type773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.EntityCollectionsEntityCollectionIdEntitiesBulkPostRequestBodyContentApplicationJsonSchemaEntitiesItems>? Type774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.UpdateRequest2? Type775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateAssetsRequest? Type776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.DeleteAssetsRequest? Type777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateRequest4? Type778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.UpdateRequest3? Type779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateRequest5? Type780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.UpdateKnowledgeStoreItemMetadataRequest? Type781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ReplaceKnowledgeStoreItemMetadataRequest? Type782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateRequest6? Type783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.UpdateRequest4? Type784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AddItemsRequest? Type785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.RemoveItemsRequest? Type786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateStreamRequest? Type787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.ResponseInputItem>? Type788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.ResponsesPostRequestBodyContentApplicationJsonSchemaIncludeItems>? Type789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.ResponseToolInput>? Type790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.ResponseSelection>? Type791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateRequest7? Type792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.IndexesPostRequestBodyContentApplicationJsonSchemaModelsItems>? Type793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.UpdateRequest5? Type794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateRequest8? Type795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.UpdateRequest6? Type796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.UpdateRequest7? Type797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateRequest9? Type798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateRequest10? Type799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaSearchOptionsItems>? Type800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.SearchPostRequestBodyContentMultipartFormDataSchemaTranscriptionOptionsItems>? Type801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateRequest11? Type802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.EmbedTasksPostRequestBodyContentMultipartFormDataSchemaVideoEmbeddingScopeItems>? Type803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.CreateRequest12? Type804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.AnalyzeRequest? Type805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AssetsGetParametersAssetTypesSchemaItems>? Type806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AssetsAssetIdTranscriptionGetParametersIncludeSchemaItems>? Type807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.KnowledgeStoresKnowledgeStoreIdItemsGetParametersStatusSchemaItems>? Type808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.IndexesIndexIdIndexedAssetsGetParametersStatusSchemaItems>? Type809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::TwelveLabs.IndexesIndexIdIndexedAssetsGetParametersUserMetadataSchema>? Type810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.IndexesIndexIdIndexedAssetsIndexedAssetIdGetParametersEmbeddingOptionSchemaItems>? Type811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::TwelveLabs.IndexesIndexIdVideosGetParametersUserMetadataSchema>? Type812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.IndexesIndexIdVideosVideoIdGetParametersEmbeddingOptionSchemaItems>? Type813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.TasksGetParametersStatusSchemaItems>? Type814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.EmbedTasksTaskIdGetParametersEmbeddingOptionSchemaItems>? Type815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.BatchStatus>? Type816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::TwelveLabs.AnalyzeBatchesGetParametersAnalysisModeSchemaItems>? Type817 { get; set; }

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