using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.Model
{
    internal class ModelDefinition
    {
        public ModelDefinition(string name,
            string version,
            string url)
        {
            Name = name;
            Version = version;
            Uri = url;
        }

        public string Name { get; }
        public string Version { get; }
        public string Uri { get; }

        internal Dictionary<string, ModelDefinition> RequiredModels { get; set; } = new();

        internal Dictionary<string, ContextDefinition> Contexts { get; set; } = new();
        internal Dictionary<string, TypeDefinition> TypeDefinitions { get; set; } = new();
        internal Dictionary<TypeSpecifier, Dictionary<TypeSpecifier, string>> ImplicitConversions { get; set; } =
            new(EqualityComparer<TypeSpecifier>.Default);

        public void AddType(TypeDefinition type) => TypeDefinitions.Add(type.Name, type);
        public bool TryGetType(string qualifiedName, [NotNullWhen(true)] out TypeDefinition? type) =>
            TypeDefinitions.TryGetValue(qualifiedName, out type);

        public bool TryGetImplicitConversion(TypeSpecifier from, TypeSpecifier to, [NotNullWhen(true)] out string? function)
        {
            if (ImplicitConversions.TryGetValue(from, out var tos))
            {
                if (tos.TryGetValue(to, out function))
                    return true;
            }
            function = null;
            return false;
        }

        public IEnumerable<KeyValuePair<TypeSpecifier, string>> ImplicitConversionsFrom(TypeSpecifier from) =>
            ImplicitConversions.TryGetValue(from, out var tos)
                ? tos.Select(kvp => new KeyValuePair<TypeSpecifier, string>(kvp.Key, kvp.Value))
                : Enumerable.Empty<KeyValuePair<TypeSpecifier, string>>();

        private List<ModelError> modelErrors = new();
        public IReadOnlyCollection<ModelError> ModelErrors => modelErrors.AsReadOnly();
        public bool HasErrors => modelErrors.Count > 0;
        public void AddError(string message, ErrorLocation location) => modelErrors.Add(new ModelError(message, location));
    }
}

internal record ModelError(string Message, ErrorLocation Location);
internal record ErrorLocation(int StartLine, int StartColumn, int EndLine, int EndColumn);

internal static class ErrorLocationExtensions
{
    public static ErrorLocation ToErrorLocation(this Antlr4.Runtime.ParserRuleContext ctx) =>
        new ErrorLocation(ctx.Start.Line, ctx.Start.Column, ctx.Stop.Line, ctx.Stop.Column);
}