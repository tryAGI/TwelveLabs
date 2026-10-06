#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace TwelveLabs.JsonConverters
{
    /// <inheritdoc />
    public class AnalyzeTaskResponseRequestParamsMaxTokensJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::TwelveLabs.AnalyzeTaskResponseRequestParamsMaxTokens>
    {
        /// <inheritdoc />
        public override global::TwelveLabs.AnalyzeTaskResponseRequestParamsMaxTokens Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);
                }
            }

            var __score0 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(int), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score0++;
                    }
                }
            }
            var __score1 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::TwelveLabs.AnalyzeTaskResponseRequestParamsMaxTokens1), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score1++;
                    }
                }
            }
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            int? analyzeTaskResponseRequestParamsMaxTokensVariant1 = default;
            global::TwelveLabs.AnalyzeTaskResponseRequestParamsMaxTokens1? analyzeTaskResponseRequestParamsMaxTokens1 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(int), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<int> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(int).Name}");
                        analyzeTaskResponseRequestParamsMaxTokensVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 1)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::TwelveLabs.AnalyzeTaskResponseRequestParamsMaxTokens1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::TwelveLabs.AnalyzeTaskResponseRequestParamsMaxTokens1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::TwelveLabs.AnalyzeTaskResponseRequestParamsMaxTokens1).Name}");
                        analyzeTaskResponseRequestParamsMaxTokens1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (analyzeTaskResponseRequestParamsMaxTokensVariant1 == null && analyzeTaskResponseRequestParamsMaxTokens1 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(int), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<int> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(int).Name}");
                    analyzeTaskResponseRequestParamsMaxTokensVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (analyzeTaskResponseRequestParamsMaxTokensVariant1 == null && analyzeTaskResponseRequestParamsMaxTokens1 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::TwelveLabs.AnalyzeTaskResponseRequestParamsMaxTokens1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::TwelveLabs.AnalyzeTaskResponseRequestParamsMaxTokens1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::TwelveLabs.AnalyzeTaskResponseRequestParamsMaxTokens1).Name}");
                    analyzeTaskResponseRequestParamsMaxTokens1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::TwelveLabs.AnalyzeTaskResponseRequestParamsMaxTokens(
                analyzeTaskResponseRequestParamsMaxTokensVariant1,

                analyzeTaskResponseRequestParamsMaxTokens1
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::TwelveLabs.AnalyzeTaskResponseRequestParamsMaxTokens value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsAnalyzeTaskResponseRequestParamsMaxTokensVariant1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(int), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<int> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(int).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickAnalyzeTaskResponseRequestParamsMaxTokensVariant1(), typeInfo);
            }
            else if (value.IsAnalyzeTaskResponseRequestParamsMaxTokens1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::TwelveLabs.AnalyzeTaskResponseRequestParamsMaxTokens1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::TwelveLabs.AnalyzeTaskResponseRequestParamsMaxTokens1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::TwelveLabs.AnalyzeTaskResponseRequestParamsMaxTokens1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickAnalyzeTaskResponseRequestParamsMaxTokens1(), typeInfo);
            }
        }
    }
}