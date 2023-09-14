using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using Hl7.Cql.Elm;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;

namespace Hl7.Cql.CqlToElm
{
    internal class LibraryContext
    {
        public LibraryContext(IServiceProvider services)
        {
            Services = services;
        }

        private LocalIdentifierProvider LocalIdentifierProvider => Services.GetRequiredService<LocalIdentifierProvider>();
        private IModelProvider ModelProvider => Services.GetRequiredService<IModelProvider>();

        public Library? Library { get; set; }
        public ContextDef? ActiveContext { get; set; }
        internal IServiceProvider Services { get; }
        internal ILogger<LibraryContext> Log => Services.GetRequiredService<ILogger<LibraryContext>>();
        internal Expression? Ref(string? qualifier, string identifier, ParserRuleContext context)
        {
            Library library;
            if (string.IsNullOrWhiteSpace(qualifier))
                library = Library ?? throw new InvalidOperationException($"Unqualified identifier applied without a Library in context");
            else
                throw new NotImplementedException();

            var model = ModelProvider.GetSystemModel(library);
            if (library.valueSets?.Any(vs => vs.name == identifier) ?? false)
            {
                var vsName = ModelProvider.QualifiedTypeName(model, "ValueSet");
                return new ValueSetRef
                {
                    libraryName = qualifier,
                    localId = LocalIdentifierProvider.Next(),
                    locator = context.Locator(),
                    name = identifier,
                    resultTypeName = new XmlQualifiedName(vsName),
                    resultTypeSpecifier = new NamedTypeSpecifier
                    {
                        name = new XmlQualifiedName(vsName)
                    }
                };
            }
            else if (library.concepts?.Any(c => c.name == identifier) ?? false)
            {
                var conceptName = ModelProvider.QualifiedTypeName(model, "Concept");
                return new ConceptRef
                {
                    libraryName = qualifier,
                    localId = LocalIdentifierProvider.Next(),
                    locator = context.Locator(),
                    name = identifier,
                    resultTypeName = new XmlQualifiedName(conceptName),
                    resultTypeSpecifier = new NamedTypeSpecifier
                    {
                        name = new XmlQualifiedName(conceptName)
                    }
                };
            }
            else if (library.codeSystems?.Any(c => c.name == identifier) ?? false)
            {
                var csName = ModelProvider.QualifiedTypeName(model, "CodeSystem");
                return new CodeSystemRef
                {
                    libraryName = qualifier,
                    localId = LocalIdentifierProvider.Next(),
                    locator = context.Locator(),
                    name = identifier,
                    resultTypeName = new XmlQualifiedName(csName),
                    resultTypeSpecifier = new NamedTypeSpecifier
                    {
                        name = new XmlQualifiedName(csName)
                    }
                };
            }
            else if (library.codes?.Any(c => c.name == identifier) ?? false)
            {
                var codeName = ModelProvider.QualifiedTypeName(model, "Code");
                return new CodeRef
                {
                    libraryName = qualifier,
                    localId = LocalIdentifierProvider.Next(),
                    locator = context.Locator(),
                    name = identifier,
                    resultTypeName = new XmlQualifiedName(codeName),
                    resultTypeSpecifier = new NamedTypeSpecifier
                    {
                        name = new XmlQualifiedName(codeName)
                    }
                };
            }
            else
            {
                var param = library.parameters?
                    .Where(p => p.name == identifier)
                    .ToArray() ?? Array.Empty<ParameterDef>();
                if (param.Length > 1)
                    Log.LogCritical($"The parameter name {identifier} exists more than once in {library.identifier.id}.");

                if (param.Length > 0)
                {
                    return new ParameterRef
                    {
                        libraryName = qualifier,
                        localId = LocalIdentifierProvider.Next(),
                        locator = context.Locator(),
                        name = identifier,
                        resultTypeName = param[0].parameterType,
                        resultTypeSpecifier = param[0].parameterTypeSpecifier
                    };
                }
            }
            return null;
        }
        internal IEnumerable<(XmlQualifiedName qualifiedTypeName, string? templateName)> MatchingQualifiedTypeNames(string dotSeparatedId)
        {
            var parts = dotSeparatedId.Split(".");
            if (parts.Length == 2)
            {
                var @using = Library?.usings?.First(u => u.localIdentifier == parts[0]);
                if (@using != null)
                {
                    var uri = @using.uri;
                    var model = ModelProvider.ModelFromUri(uri);
                    if (model != null)
                    {
                        var type = ModelProvider.TypeInfoFor(model, parts[1]);
                        if (type != null)
                        {
                            var qtn = ModelProvider.QualifiedTypeName(model, parts[1]);
                            var templateId = IdentifierFor(type);
                            yield return (new XmlQualifiedName(qtn), templateId);
                        }
                    }
                }
            }
            else
            {
                foreach (var @using in Library?.usings ?? Enumerable.Empty<UsingDef>())
                {
                    var uri = @using.uri;
                    var model = ModelProvider.ModelFromUri(uri);
                    if (model != null)
                    {
                        var type = ModelProvider.TypeInfoFor(model, parts[0])
                            ?? ModelProvider.TypeInfoFor(model, $"{model.name}.{parts[0]}");
                        if (type != null)
                        {
                            var qtn = ModelProvider.QualifiedTypeName(model, parts[0]);
                            var templateId = IdentifierFor(type);
                            yield return (new XmlQualifiedName(qtn), templateId);
                        }
                    }
                }
            }
        }
        internal (XmlQualifiedName qualifiedTypeName, string? templateName) UnambiguousType(string qualifiedName)
        {
            var types = MatchingQualifiedTypeNames(qualifiedName)
                .ToArray();
            if (types.Length == 1)
            {
                return types[0];
            }
            var message = $"Unambigous type name {qualifiedName}";
            var ex = new InvalidOperationException(message);
            Log.LogCritical(ex, ex.Message);
            throw ex;
        }


        internal string? IdentifierFor(Model.TypeInfo type) =>
            type switch
            {
                Model.ClassInfo cti => cti.identifier,
                _ => null
            };
    }
}
