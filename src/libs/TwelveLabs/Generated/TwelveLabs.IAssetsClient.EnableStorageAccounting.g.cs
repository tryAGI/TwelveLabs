#nullable enable

namespace TwelveLabs
{
    public partial interface IAssetsClient
    {
        /// <summary>
        /// Enable storage accounting for an asset<br/>
        /// This method enables storage accounting for the specified asset. Storage accounting makes an asset count toward your Managed Intelligence allowance.<br/>
        /// **When to use this method**: Call it once for each asset that you uploaded before your plan moved to the new billing (a pre-migration asset). Enable storage accounting before you do either of the following:<br/>
        /// - Add the asset to a knowledge store.<br/>
        /// - Index the asset in an index for which Marengo is enabled.<br/>
        /// An asset that you upload after your plan moves already counts toward your Managed Intelligence allowance. You do not need to call this method for it.<br/>
        /// **Before you call this method**: The asset must have the `ready` status and a recorded size. To check, use the [`GET`](/v1.3/api-reference/manage-assets/retrieve) method of the `/assets/{asset_id}` endpoint and read the `status` and `size` fields.<br/>
        /// **After you call this method**:<br/>
        /// - The asset counts toward your Managed Intelligence allowance from the moment of the call.<br/>
        /// - Enabling storage accounting is permanent. You cannot turn it off.<br/>
        /// - If storage accounting is already on, the method returns the same response and changes nothing.
        /// </summary>
        /// <param name="assetId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.AssetStorageAccounting> EnableStorageAccountingAsync(
            string assetId,

            global::TwelveLabs.EnableStorageAccountingRequest request,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Enable storage accounting for an asset<br/>
        /// This method enables storage accounting for the specified asset. Storage accounting makes an asset count toward your Managed Intelligence allowance.<br/>
        /// **When to use this method**: Call it once for each asset that you uploaded before your plan moved to the new billing (a pre-migration asset). Enable storage accounting before you do either of the following:<br/>
        /// - Add the asset to a knowledge store.<br/>
        /// - Index the asset in an index for which Marengo is enabled.<br/>
        /// An asset that you upload after your plan moves already counts toward your Managed Intelligence allowance. You do not need to call this method for it.<br/>
        /// **Before you call this method**: The asset must have the `ready` status and a recorded size. To check, use the [`GET`](/v1.3/api-reference/manage-assets/retrieve) method of the `/assets/{asset_id}` endpoint and read the `status` and `size` fields.<br/>
        /// **After you call this method**:<br/>
        /// - The asset counts toward your Managed Intelligence allowance from the moment of the call.<br/>
        /// - Enabling storage accounting is permanent. You cannot turn it off.<br/>
        /// - If storage accounting is already on, the method returns the same response and changes nothing.
        /// </summary>
        /// <param name="assetId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.AutoSDKHttpResponse<global::TwelveLabs.AssetStorageAccounting>> EnableStorageAccountingAsResponseAsync(
            string assetId,

            global::TwelveLabs.EnableStorageAccountingRequest request,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Enable storage accounting for an asset<br/>
        /// This method enables storage accounting for the specified asset. Storage accounting makes an asset count toward your Managed Intelligence allowance.<br/>
        /// **When to use this method**: Call it once for each asset that you uploaded before your plan moved to the new billing (a pre-migration asset). Enable storage accounting before you do either of the following:<br/>
        /// - Add the asset to a knowledge store.<br/>
        /// - Index the asset in an index for which Marengo is enabled.<br/>
        /// An asset that you upload after your plan moves already counts toward your Managed Intelligence allowance. You do not need to call this method for it.<br/>
        /// **Before you call this method**: The asset must have the `ready` status and a recorded size. To check, use the [`GET`](/v1.3/api-reference/manage-assets/retrieve) method of the `/assets/{asset_id}` endpoint and read the `status` and `size` fields.<br/>
        /// **After you call this method**:<br/>
        /// - The asset counts toward your Managed Intelligence allowance from the moment of the call.<br/>
        /// - Enabling storage accounting is permanent. You cannot turn it off.<br/>
        /// - If storage accounting is already on, the method returns the same response and changes nothing.
        /// </summary>
        /// <param name="assetId"></param>
        /// <param name="enabled">
        /// Enables storage accounting for the asset. The only accepted value is `true`.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.AssetStorageAccounting> EnableStorageAccountingAsync(
            string assetId,
            bool enabled,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}