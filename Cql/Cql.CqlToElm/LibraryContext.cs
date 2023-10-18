using Hl7.Cql.Elm;
using Hl7.Cql.Model;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

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

        internal Expression? Ref(string? qualifier, string identifier)
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
                }.WithResultType(SystemTypes.ValueSetType);
            }
            else if (library.concepts?.Any(c => c.name == identifier) ?? false)
            {
                return new ConceptRef
                {
                    libraryName = qualifier,
                    name = identifier,
                }.WithResultType(SystemTypes.ConceptType);
            }
            else if (library.codeSystems?.Any(c => c.name == identifier) ?? false)
            {
                return new CodeSystemRef
                {
                    libraryName = qualifier,
                    name = identifier,
                }.WithResultType(SystemTypes.CodeSystemType);
            }
            else if (library.codes?.Any(c => c.name == identifier) ?? false)
            {
                return new CodeRef
                {
                    libraryName = qualifier,
                    name = identifier,
                }.WithResultType(SystemTypes.CodeType);
            }
            else
            {
                var param = library.parameters?
                    .Where(p => p.name == identifier)
                    .ToArray() ?? Array.Empty<ParameterDef>();

                if (param.Length > 0)
                {
                    if (param.Length > 1)
                        Log.LogCritical($"The parameter name {identifier} exists more than once in {library.identifier.id}.");

                    return new ParameterRef
                    {
                        libraryName = qualifier,
                        name = identifier,
                    }.WithResultType(param[0].parameterTypeSpecifier);
                }
                else
                    return null;
            }
        }

        private IEnumerable<ModelResolveResult> matchDottedTypeName(string dottedName)
        {
            var parts = dottedName.Split(".");
            var usings = parts.Length == 2 ?
                ActiveLibrary.usings.Where(u => u.localIdentifier == parts[0]) :
                ActiveLibrary.usings;

            var name = parts.Length == 2 ? parts[1] : parts[0];

            foreach (var @using in usings)
            {
                var namedType = QualifiedName.MakeQualifiedTypeName(@using.uri, name).ToNamedType();
                if(ModelProvider.TryResolveFromNamedType(namedType, out var result))
                    yield return result!;
            }
        }


        /// <summary>
        /// Given the literal (qualified) identifier for a type, returns the NamedTypeSpecifier for the type, 
        /// or throws an exception if the type is not found or is ambiguous.
        /// </summary>
        /// <param name="dottedName">A (possibly) qualified identifier for a type.</param>
        /// <returns></returns>
        internal ModelResolveResult ResolveDottedTypeName(string dottedName)
        {
            var types = matchDottedTypeName(dottedName).ToArray();

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
    }
}
