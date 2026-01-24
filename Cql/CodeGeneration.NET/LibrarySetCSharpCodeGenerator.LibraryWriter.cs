using System.Diagnostics;
using Hl7.Cql.Abstractions;
using Hl7.Cql.Compiler;
using Hl7.Cql.Compiler.Expressions;
using Hl7.Cql.Runtime;

namespace Hl7.Cql.CodeGeneration.NET;

partial class LibrarySetCSharpCodeGenerator
{
    /// <summary>
    /// Generates C# code for a single CQL library, including cached expression definitions,
    /// cache index fields, and the ILibraryInternals implementation for cache initialization.
    /// </summary>
    private class LibraryWriter
    {
        public LibraryWriter(
            LibrarySetWriter librarySetWriter)
        {
            LibrarySetWriter = librarySetWriter;
        }

        internal CqlVersionedLibraryIdentifier LibraryName => _library?.VersionedLibraryIdentifier ?? throw new InvalidOperationException("Library not initialized.");
        private string _className = string.Empty;

        // Maps definition names to their assigned cache indices within this library
        private readonly Dictionary<string, int> _cacheIndices = new();
        private int _nextCacheIndex = 0;

        /// <summary>
        /// Gets or creates a cache index for the specified definition name.
        /// Indices are assigned sequentially starting from 0 within each library.
        /// </summary>
        public int GetOrCreateCacheIndex(string definitionName)
        {
            if (!_cacheIndices.TryGetValue(definitionName, out var index))
            {
                index = _nextCacheIndex++;
                _cacheIndices[definitionName] = index;
            }
            return index;
        }

        public void AppendLibraryFile(ElmLibrary library, IndentedStringBuilder isb)
        {
            _library = library;
            ISB = isb;
            _className = IdentifierNormalizer.Normalize(library.VersionedLibraryIdentifier);
            _definitions = LibrarySetWriter
                           .Definitions
                           .SelectDefinitionsByLibraryName(LibraryName)
                           .Select(t => t.definition)
                           .ToArray();
            CodeDefinitions = _definitions
                               .OfType<CqlCodeDefinition>()
                               .ToArray();

            AppendUsings();
            AppendNamespaceFileScope();
            AppendClass();
        }

        private void AppendCqlTupleMetadataProperties()
        {
            var tupleMetadataBuilder = LibrarySetWriter.TupleMetadataBuilder;
            var signatures = tupleMetadataBuilder.GetLibraryTupleMetadataPropertySignatures(LibraryName).ToList();
            for (var i = 0; i < signatures.Count; i++)
            {
                var (propertyName, signature) = signatures[i];
                if (i == 0)
                    ISB.AppendLine(
                        $"""
                         #region CqlTupleMetadata Properties ({signatures.Count})

                         """);

                var types = string.Join(", ", signature.Select(t => $"typeof({LibrarySetWriter.TypeToCSharpConverter.ToCSharp(t.Type)})"));
                var names = string.Join(", ", signature.Select(t => t.PropName.QuoteString()));
                ISB.AppendLine(
                    $"""
                     private static CqlTupleMetadata {propertyName} = new(
                        [{types}],
                        [{names}]);

                     """);
            }

            if (signatures.Count > 0)
                ISB.AppendLine(
                    """
                    #endregion CqlTupleMetadata Properties

                    """);
        }

        private void AppendLibraryInterfaceImplementation()
        {
            ISB.AppendLine(
                $"""
                 #region ILibrary Implementation

                 public string Name => {LibraryName!.Identifier.ToString().QuoteString()};
                 public string Version => {LibraryName!.Version?.ToString().QuoteOrNullString()};
                 """);
            var dependencies =
                LibrarySetWriter.LibrarySet
                                .GetLibraryDependencies(LibraryName, throwError: true)
                                .Select(dep => IdentifierNormalizer.Normalize(dep.VersionedLibraryIdentifier))
                                .Select(typeName => $"{typeName}.Instance");
            ISB.AppendLine(
                $"""
                 public ILibrary[] Dependencies => [{string.Join(", ", dependencies)}];

                 #endregion ILibrary Implementation

                 """);
        }

        private void AppendUsings()
        {
            foreach (var @using in LibrarySetWriter.Usings)
                ISB.AppendLine($"using {@using};");

            foreach (var @using in LibrarySetWriter.AliasedUsings)
                ISB.AppendLine($"using {@using.Item1} = {@using.Item2};");

            ISB.AppendLine();
        }

        private void AppendNamespaceFileScope()
        {
            if (LibrarySetWriter.Namespace is { Length: > 0 } @namespace)
            {
                ISB.AppendLine(
                    $"""
                     namespace {@namespace};

                     """);
            }
        }

        private CqlDefinition[] _definitions = Array.Empty<CqlDefinition>();

        public CqlCodeDefinition[] CodeDefinitions { get; private set; } = Array.Empty<CqlCodeDefinition>();

        public LibrarySetWriter LibrarySetWriter { get; }
        private ElmLibrary? _library;
        public IndentedStringBuilder ISB { get; private set; } = new();

        private void AppendMethods()
        {
            string lastDefinitionRegion = "";
            var regionCounts = new Dictionary<string, int>();

            // First pass: count definitions per region
            foreach (var definition in _definitions)
            {
                // Assumption: type name will be Cql....Definition
                Debug.Assert(definition.GetType().Name is { } name && name.StartsWith("Cql") && name.EndsWith("Definition"));
                string definitionRegion =
                    definition switch
                    {
                        // CqlFunctionDefinition is a CqlExpressionDefinition
                        // We combine them into one region otherwise we would have too many segments switching between Function and Expression
                        CqlExpressionDefinition => "Functions and Expressions",

                        // Extract the region name from the definition type name e.g. Cql[Parameter]Definition => Parameters
                        _ => $"{definition.GetType().Name["Cql".Length..^"Definition".Length]}s"
                    };

                regionCounts[definitionRegion] = regionCounts.GetValueOrDefault(definitionRegion, 0) + 1;
            }

            // Second pass: generate code with counts
            foreach (var definition in _definitions)
            {
                // Assumption: type name will be Cql....Definition
                Debug.Assert(definition.GetType().Name is { } name && name.StartsWith("Cql") && name.EndsWith("Definition"));
                string definitionRegion =
                    definition switch
                    {
                        // CqlFunctionDefinition is a CqlExpressionDefinition
                        // We combine them into one region otherwise we would have too many segments switching between Function and Expression
                        CqlExpressionDefinition => "Functions and Expressions",

                        // Extract the region name from the definition type name e.g. Cql[Parameter]Definition => Parameters
                        _ => $"{definition.GetType().Name["Cql".Length..^"Definition".Length]}s"
                    };

                if (lastDefinitionRegion != definitionRegion)
                {
                    if (lastDefinitionRegion != "")
                    {
                        ISB.AppendLine(
                            $"""
                             #endregion {lastDefinitionRegion}

                             """);
                    }

                    var count = regionCounts[definitionRegion];
                    ISB.AppendLine(
                        $"""
                         #region {definitionRegion} ({count})

                         """);
                }

                lastDefinitionRegion = definitionRegion;

                var methodWriter = new DefinitionWriter(this, definition);
                methodWriter.AppendDefinition();
                ISB.AppendLine();
            }

            if (lastDefinitionRegion != "")
            {
                ISB.AppendLine($"""
                                #endregion {lastDefinitionRegion}

                                """);
            }
        }

        private void AppendClass()
        {
            ISB.AppendLine(
                $"[System.CodeDom.Compiler.GeneratedCode({GeneratorToolName.QuoteString()}, {GeneratorToolVersion.QuoteString()})]");

            ISB.AppendLine(
                LibraryName!.Version is { } version && Version.TryParse(version, out _)
                    ? $"[CqlLibrary({LibraryName!.Identifier.ToString().QuoteString()}, {version.ToString().QuoteString()})]"
                    : $"[CqlLibrary({LibraryName!.Identifier.ToString().QuoteString()})]");

            ISB.AppendLine(
                $$"""
                  public partial class {{_className}} : ILibrary, ILibraryInternals, ISingleton<{{_className}}>
                  {
                  """);

            using (ISB.Indent())
            {
                // Put logic first
                AppendMethods();

                // Cache index fields (must come after AppendMethods so indices are assigned)
                AppendCacheIndexFields();

                // ILibraryInternals implementation
                AppendInitializeCacheIndicesMethod();

                // These are all boilerplate
                AppendSingletonLifetimeMembers();
                AppendLibraryInterfaceImplementation();
                AppendCqlTupleMetadataProperties();
            }

            ISB.AppendLine("}");
        }

        /// <summary>
        /// Generates cache index fields for cached definitions in this library.
        /// Each field is initialized to -1 (sentinel value indicating uninitialized state).
        /// Fields will be set to actual cache indices at runtime by CqlLibraryInvocationCache.
        /// </summary>
        private void AppendCacheIndexFields()
        {
            if (_cacheIndices.Count == 0)
                return;

            ISB.AppendLine(
                $"""
                 #region Cache Index Fields ({_cacheIndices.Count})

                 """);

            // Generate fields in deterministic order (sorted by assigned index)
            // Initialize to -1 to indicate uninitialized state
            var sortedIndices = _cacheIndices.OrderBy(kvp => kvp.Value).ToList();
            foreach (var (definitionName, _) in sortedIndices)
            {
                var fieldName = $"_cacheIndex_{IdentifierNormalizer.Normalize(definitionName)}";
                ISB.AppendLine($"private int {fieldName} = -1;");
            }

            ISB.AppendLine(
                """

                #endregion Cache Index Fields

                """);
        }

        /// <summary>
        /// Generates the InitializeCacheIndices method implementation.
        /// This method initializes cache index fields for this library only (dependencies are handled externally).
        /// It assigns sequential cache indices starting from the provided startIndex to each cached expression field in the library.
        /// Returns the total number of indices assigned.
        /// </summary>
        private void AppendInitializeCacheIndicesMethod()
        {
            ISB.AppendLine(
                """
                #region ILibraryInternals Implementation

                /// <summary>
                /// Initializes cache indices for this library's cached expressions.
                /// </summary>
                /// <param name="libraryInvocationSet">The library invocation set performing initialization.</param>
                /// <param name="startIndex">The starting index for cache field assignment.</param>
                /// <returns>The number of cache indices initialized (number of cached expressions in this library).</returns>
                int ILibraryInternals.InitializeCacheIndices(
                    CqlLibraryInvocationSet libraryInvocationSet,
                    int startIndex)
                {
                    var index = startIndex;
                """);

            using (ISB.Indent())
            {
                if (_cacheIndices.Count > 0)
                {
                    var sortedIndices = _cacheIndices.OrderBy(kvp => kvp.Value).ToList();
                    foreach (var (definitionName, _) in sortedIndices)
                    {
                        var fieldName = $"_cacheIndex_{IdentifierNormalizer.Normalize(definitionName)}";
                        ISB.AppendLine($"{fieldName} = index++;");
                    }
                }

                ISB.AppendLine("return index - startIndex;");
            }

            ISB.AppendLine(
                """
                }

                #endregion ILibraryInternals Implementation

                """);
        }

        private void AppendSingletonLifetimeMembers()
        {
            ISB.AppendLine(
                $$"""
                  #region Singleton Lifetime Members

                  private {{_className}}() {}

                  public static {{_className}} Instance { get; } = new();

                  #endregion

                  """);
        }
    }
}