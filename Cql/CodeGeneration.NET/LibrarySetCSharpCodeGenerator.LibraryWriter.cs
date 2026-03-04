using System.Diagnostics;
using Hl7.Cql.Abstractions;
using Hl7.Cql.Compiler;
using Hl7.Cql.Compiler.Expressions;
using Hl7.Cql.Runtime;

namespace Hl7.Cql.CodeGeneration.NET;

partial class LibrarySetCSharpCodeGenerator
{
    private class LibraryWriter
    {
        public LibraryWriter(
            LibrarySetWriter librarySetWriter)
        {
            LibrarySetWriter = librarySetWriter;
        }

        internal CqlVersionedLibraryIdentifier LibraryName => _library?.VersionedLibraryIdentifier ?? throw new InvalidOperationException("Library not initialized.");
        private string _className = string.Empty;
        private readonly Dictionary<string, int> _cacheFieldNameCount = new();

        public string GetUniqueCacheFieldName(string baseName)
        {
            if (string.IsNullOrEmpty(baseName))
                throw new ArgumentException("Base name cannot be null or empty.", nameof(baseName));

            var count = _cacheFieldNameCount.GetValueOrDefault(baseName, 0);
            string fieldName;
            do
            {
                fieldName = count == 0 ? baseName : $"{baseName}_{count}";
                count++;
            } while (_cacheFieldNameCount.ContainsKey(fieldName));

            _cacheFieldNameCount[baseName] = count;
            _cacheFieldNameCount[fieldName] = 0; // Mark this specific name as used
            return fieldName;
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
                        """
                        #region CqlTupleMetadata Properties

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

        private static string GetDefinitionRegion(CqlDefinition definition) =>
            definition switch
            {
                // CqlFunctionDefinition is a CqlExpressionDefinition
                // We combine them into one region otherwise we would have too many segments switching between Function and Expression
                CqlExpressionDefinition => "Functions and Expressions",

                // Extract the region name from the definition type name e.g. Cql[Parameter]Definition => Parameters
                _ => $"{definition.GetType().Name["Cql".Length..^"Definition".Length]}s"
            };

        private void AppendMethods()
        {
            string lastDefinitionRegion = "";

            // Pre-compute region counts for the region header
            var regionCounts = _definitions
                .GroupBy(GetDefinitionRegion)
                .ToDictionary(g => g.Key, g => g.Count());

            // Assumption: definitions are already sorted by definition type
            foreach (var definition in _definitions)
            {
                // Assumption: type name will be Cql....Definition
                Debug.Assert(definition.GetType().Name is { } name && name.StartsWith("Cql") && name.EndsWith("Definition"));
                string definitionRegion = GetDefinitionRegion(definition);

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
                  public partial class {{_className}} : ILibrary, ISingleton<{{_className}}>
                  {
                  """);

            using (ISB.Indent())
            {
                // Put logic first
                AppendMethods();

                // These are all boilerplate
                AppendSingletonLifetimeMembers();
                AppendLibraryInterfaceImplementation();
                AppendCqlTupleMetadataProperties();
            }

            ISB.AppendLine("}");
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