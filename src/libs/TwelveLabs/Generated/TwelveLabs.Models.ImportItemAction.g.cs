
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The action taken for this file: created, skipped, retried, or rejected. The platform sets this value while processing the request, and the value does not change afterward. The [Import files](/v1.3/api-reference/data-connectors/imports/import-files) endpoint always returns this field. The [Retrieve an import](/v1.3/api-reference/data-connectors/imports/retrieve-an-import) endpoint omits it for imports from before this field existed. Treat an absent value as unknown rather than as a specific action.<br/>
    /// The `skipped` and `retried` values both mean the file was already imported through this account: for the `skipped` action, the platform returns the existing asset; for the `retried` action, the earlier fetch had failed, so the platform fetches the file again. See [The import object](/v1.3/api-reference/data-connectors/imports/the-import-object#item-actions) for the meaning of each value.
    /// </summary>
    public enum ImportItemAction
    {
        /// <summary>
        /// created, skipped, retried, or rejected. The platform sets this value while processing the request, and the value does not change afterward. The [Import files](/v1.3/api-reference/data-connectors/imports/import-files) endpoint always returns this field. The [Retrieve an import](/v1.3/api-reference/data-connectors/imports/retrieve-an-import) endpoint omits it for imports from before this field existed. Treat an absent value as unknown rather than as a specific action.
        /// </summary>
        Created,
        /// <summary>
        /// created, skipped, retried, or rejected. The platform sets this value while processing the request, and the value does not change afterward. The [Import files](/v1.3/api-reference/data-connectors/imports/import-files) endpoint always returns this field. The [Retrieve an import](/v1.3/api-reference/data-connectors/imports/retrieve-an-import) endpoint omits it for imports from before this field existed. Treat an absent value as unknown rather than as a specific action.
        /// </summary>
        Rejected,
        /// <summary>
        /// created, skipped, retried, or rejected. The platform sets this value while processing the request, and the value does not change afterward. The [Import files](/v1.3/api-reference/data-connectors/imports/import-files) endpoint always returns this field. The [Retrieve an import](/v1.3/api-reference/data-connectors/imports/retrieve-an-import) endpoint omits it for imports from before this field existed. Treat an absent value as unknown rather than as a specific action.
        /// </summary>
        Retried,
        /// <summary>
        /// created, skipped, retried, or rejected. The platform sets this value while processing the request, and the value does not change afterward. The [Import files](/v1.3/api-reference/data-connectors/imports/import-files) endpoint always returns this field. The [Retrieve an import](/v1.3/api-reference/data-connectors/imports/retrieve-an-import) endpoint omits it for imports from before this field existed. Treat an absent value as unknown rather than as a specific action.
        /// </summary>
        Skipped,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImportItemActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImportItemAction value)
        {
            return value switch
            {
                ImportItemAction.Created => "created",
                ImportItemAction.Rejected => "rejected",
                ImportItemAction.Retried => "retried",
                ImportItemAction.Skipped => "skipped",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImportItemAction? ToEnum(string value)
        {
            return value switch
            {
                "created" => ImportItemAction.Created,
                "rejected" => ImportItemAction.Rejected,
                "retried" => ImportItemAction.Retried,
                "skipped" => ImportItemAction.Skipped,
                _ => null,
            };
        }
    }
}