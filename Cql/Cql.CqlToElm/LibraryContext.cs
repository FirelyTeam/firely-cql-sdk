using Antlr4.Runtime;
using Hl7.Cql.Elm;
using Hl7.Cql.Model;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace Hl7.Cql.CqlToElm
{
    internal class LibraryContext
    {
        public LibraryContext(IModelProvider modelProvider, ILogger<LibraryContext> logger)
        {
            ModelProvider = modelProvider;
            Log = logger;
        }

        private readonly ILogger<LibraryContext> Log;
        private readonly IModelProvider ModelProvider;

        public Library ActiveLibrary { get; set; } = new Library();
        public ContextDef? ActiveContext { get; set; }

        internal Expression? Ref(string? qualifier, string identifier, ParserRuleContext context)
        {
            Library library;

            if (string.IsNullOrWhiteSpace(qualifier))
                library = ActiveLibrary ?? throw new InvalidOperationException($"Unqualified identifier applied without a Library in context");
            else
                throw new NotImplementedException("Cannot refer using non-local identifiers yet.");

            if (library.valueSets?.Any(vs => vs.name == identifier) ?? false)
            {
                return new ValueSetRef
                {
                    libraryName = qualifier,
                    name = identifier,
                    resultTypeName = SystemTypes.ValueSetTypeQName,
                    resultTypeSpecifier = SystemTypes.ValueSetType,
                }.WithLocator(context);
            }
            else if (library.concepts?.Any(c => c.name == identifier) ?? false)
            {
                return new ConceptRef
                {
                    libraryName = qualifier,
                    name = identifier,
                    resultTypeName = SystemTypes.ConceptTypeQName,
                    resultTypeSpecifier = SystemTypes.ConceptType
                }.WithLocator(context);
            }
            else if (library.codeSystems?.Any(c => c.name == identifier) ?? false)
            {
                return new CodeSystemRef
                {
                    libraryName = qualifier,
                    name = identifier,
                    resultTypeName = SystemTypes.CodeSystemTypeQName,
                    resultTypeSpecifier = SystemTypes.CodeSystemType
                }.WithLocator(context);
            }
            else if (library.codes?.Any(c => c.name == identifier) ?? false)
            {
                return new CodeRef
                {
                    libraryName = qualifier,
                    name = identifier,
                    resultTypeName = SystemTypes.CodeTypeQName,
                    resultTypeSpecifier = SystemTypes.CodeType
                }.WithLocator(context);
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
                        name = identifier,
                        resultTypeName = param[0].parameterType,
                        resultTypeSpecifier = param[0].parameterTypeSpecifier
                    }.WithLocator(context);
                }
            }
            return null;
        }

        internal IEnumerable<(XmlQualifiedName qualifiedTypeName, string? templateName)> MatchDottedTypeName(string dotSeparatedId)
        {
            var parts = dotSeparatedId.Split(".");
            var usings = parts.Length == 2 ?
                ActiveLibrary.usings.Where(u => u.localIdentifier == parts[0]) :
                ActiveLibrary.usings;

            var name = parts.Length == 2 ? parts[1] : parts[0];

            foreach (var @using in usings)
            {
                if (ModelProvider.ModelFromUri(@using.uri) is { } model)
                {
                    if (model.TypeInfoFor(name) is { } type)
                    {
                        var qtn = model.ToQualifiedTypeName(name);
                        var templateId = identifierFor(type);
                        yield return (qtn, templateId);
                    }
                }
            }
        }

        internal (XmlQualifiedName qualifiedTypeName, string? templateName) ResolveDottedTypeName(string dottedName)
        {
            var types = MatchDottedTypeName(dottedName).ToArray();

            if (types.Length == 1)
            {
                return types[0];
            }
            else if (types.Length == 0)
            {
                var message = $"No type named {dottedName} found in any model.";
                var ex = new InvalidOperationException(message);
                Log.LogCritical(ex, ex.Message);
                throw ex;
            }
            else
            {
                var message = $"Ambiguous type name {dottedName}.";
                var ex = new InvalidOperationException(message);
                Log.LogCritical(ex, ex.Message);
                throw ex;
            }
        }

        private static string? identifierFor(Model.TypeInfo type) =>
            type switch
            {
                Model.ClassInfo cti => cti.identifier,
                _ => null
            };
    }
}
