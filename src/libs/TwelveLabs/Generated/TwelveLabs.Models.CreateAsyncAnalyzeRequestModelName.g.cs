
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The video understanding model to use for analysis.<br/>
    /// - `pegasus1.6`: For details about this version, see the [Pegasus 1.6](/v1.3/docs/concepts/models/pegasus/pegasus-1-6) page.<br/>
    /// - `pegasus1.5`: For details about this version, see the [Pegasus 1.5](/v1.3/docs/concepts/models/pegasus/pegasus-1-5) page.<br/>
    /// **Default:** `pegasus1.5`<br/>
    /// Default Value: pegasus1.5
    /// </summary>
    public enum CreateAsyncAnalyzeRequestModelName
    {
        /// <summary>
        /// For details about this version, see the [Pegasus 1.5](/v1.3/docs/concepts/models/pegasus/pegasus-1-5) page.
        /// </summary>
        Pegasus15,
        /// <summary>
        /// For details about this version, see the [Pegasus 1.6](/v1.3/docs/concepts/models/pegasus/pegasus-1-6) page.
        /// </summary>
        Pegasus16,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateAsyncAnalyzeRequestModelNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAsyncAnalyzeRequestModelName value)
        {
            return value switch
            {
                CreateAsyncAnalyzeRequestModelName.Pegasus15 => "pegasus1.5",
                CreateAsyncAnalyzeRequestModelName.Pegasus16 => "pegasus1.6",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAsyncAnalyzeRequestModelName? ToEnum(string value)
        {
            return value switch
            {
                "pegasus1.5" => CreateAsyncAnalyzeRequestModelName.Pegasus15,
                "pegasus1.6" => CreateAsyncAnalyzeRequestModelName.Pegasus16,
                _ => null,
            };
        }
    }
}