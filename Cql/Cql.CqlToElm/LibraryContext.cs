using Hl7.Cql.Elm;
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

        /// <summary>
        /// Returns a reference to a user-defined ValueSet, CodeSystem, Concept, Code, Parameter, Definition or Context.
        /// </summary>
        /// <param name="qualifier"></param>
        /// <param name="identifier"></param>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException"></exception>
        /// <exception cref="NotImplementedException"></exception>
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


        internal bool TryResolveTypeIdentifier(string? qualifier, string typeName, out ModelResolveResult? result, out string? error)
        {
            // If the typename is qualified, only look in the specified model, otherwise try all models.
            var usings = ActiveLibrary.usings;
            result = null;

            if (qualifier is not null)
            {
                usings = usings.Where(u => u.localIdentifier == qualifier).ToArray();

                if (usings.Length > 1)
                {
                    error = $"Ambiguous qualifier '{qualifier}', matches {modelNamesList(usings.Select(u => (u.uri, u.version)))}.";
                    return false;
                }
                else if (usings.Length == 0)
                {
                    error = $"There is no model matching qualifier '{qualifier}'.";
                    return false;
                }
            }

            var matches = new List<ModelResolveResult>();

            foreach (var @using in usings)
            {
                if (ModelProvider.TryFindTypeInfoByName(@using.uri, typeName, out var typeInfo, out var model))
                    matches.Add(new ModelResolveResult(model!, typeInfo!));
            }

            error = matches.Count switch
            {
                0 => $"There is no type named '{typeName}' in model(s) {modelNamesList(usings.Select(u => (u.uri, u.version)))}.",
                > 1 => $"Ambiguous type name '{typeName}', matches {modelNamesList(matches.Select(m => (m.Model.url, m.Model.version)))}.",
                _ => null,
            };

            result = matches.FirstOrDefault();
            return matches.Count == 1;

            static string modelNamesList(IEnumerable<(string uri, string version)> models) =>
                string.Join(", ", models.Select(m => $"{m.uri} (version {m.version ?? "unspecified"})"));
        }

        internal bool TryResolveNamedTypeSpecifier(string? qualifier, string typeName, out NamedTypeSpecifier namedType, out string? error)
        {
            var success = TryResolveTypeIdentifier(qualifier, typeName, out var result, out error);

            if (result is null)
                namedType = new NamedTypeSpecifier { name = Model.QualifiedName.MakeQualifiedTypeName(qualifier ?? "nosystem", typeName) };
            else
                namedType = result.ToNamedType();

            return success;
        }
    }
}
