using System.Text.Json;

namespace Hl7.Cql.Elm
{
    internal static class JsonSerializerOptionsExtensions
    {
        public static JsonSerializerOptions AddPolymorphicConverters(this JsonSerializerOptions options,
            bool strict)
        {
            options.Converters.Add(new XmlIncludeConverterFactory(strict));
            return options;
        }
        public static JsonSerializerOptions AddLibraryConverters(this JsonSerializerOptions options)
        {
            options.Converters.Add(new LibraryJsonConverter());
            options.Converters.Add(new DefConverter<UsingDef>());
            options.Converters.Add(new DefConverter<IncludeDef>());
            options.Converters.Add(new DefConverter<ParameterDef>());
            options.Converters.Add(new DefConverter<CodeSystemDef>());
            options.Converters.Add(new DefConverter<ValueSetDef>());
            options.Converters.Add(new DefConverter<CodeDef>());
            options.Converters.Add(new DefConverter<ConceptDef>());
            options.Converters.Add(new DefConverter<ContextDef>());
            options.Converters.Add(new DefConverter<ExpressionDef>());
            return options;
        }
    }
}
