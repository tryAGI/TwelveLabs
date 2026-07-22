
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The status of the connection. See [The connection object](/v1.3/api-reference/data-connectors/the-connection-object#connection-statuses) for the possible values.
    /// </summary>
    public enum ConnectionStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Active,
        /// <summary>
        /// 
        /// </summary>
        Expired,
        /// <summary>
        /// 
        /// </summary>
        Revoked,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConnectionStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConnectionStatus value)
        {
            return value switch
            {
                ConnectionStatus.Active => "active",
                ConnectionStatus.Expired => "expired",
                ConnectionStatus.Revoked => "revoked",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConnectionStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => ConnectionStatus.Active,
                "expired" => ConnectionStatus.Expired,
                "revoked" => ConnectionStatus.Revoked,
                _ => null,
            };
        }
    }
}