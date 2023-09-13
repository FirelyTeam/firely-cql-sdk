using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using Hl7.Cql.Elm;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        public IServiceProvider Services { get; }
        public ILogger<LibraryContext> Log => Services.GetRequiredService<ILogger<LibraryContext>>();


        public Expression? Ref(string? qualifier, string identifier, ParserRuleContext context)
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
    }
}
