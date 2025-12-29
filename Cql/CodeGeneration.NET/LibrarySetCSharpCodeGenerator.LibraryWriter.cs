using System.Diagnostics;
using System.Threading;
using Hl7.Cql.Abstractions;
using Hl7.Cql.Compiler;
using Hl7.Cql.Compiler.Expressions;
using Hl7.Cql.Runtime;

namespace Hl7.Cql.CodeGeneration.NET;

partial class LibrarySetCSharpCodeGenerator
{
    private record LibraryWriter(
        LibrarySetWriter LibrarySetWriter,
        ElmLibrary Library,
        // ReSharper disable once InconsistentNaming
        IndentedStringBuilder sb) : IAddIndentMutable<LibraryWriter>
    {
        private CqlVersionedLibraryIdentifier LibraryVersionedIdentifier => Library.VersionedLibraryIdentifier!;
        public string LibraryName { get; } = Library.VersionedLibraryIdentifier;
        private string ClassName { get; } = IdentifierNormalizer.Normalize(Library.VersionedLibraryIdentifier);

        public LibraryWriter AddIndent(int addIndent = 1)
        {
            return this with { sb = sb.AddIndent(addIndent) };
        }

        public void WriteLibraryFile()
        {
            WriteUsings();
            WriteNamespaceFileScope();
            WriteClass();
        }

        private void WriteCqlTupleMetadataProperties()
        {
            var tupleMetadataBuilder = LibrarySetWriter.TupleMetadataBuilder;
            bool first = true;

            // Cql Tuple Metadata
            foreach (var (propertyName, signature) in tupleMetadataBuilder.GetLibraryTupleMetadataPropertySignatures(LibraryName))
            {
                if (first)
                {
                    sb.AppendLine("""
                                                 #region CqlTupleMetadata Properties

                                                 """);
                    first = false;
                }

                var types = string.Join(", ", signature.Select(t => $"typeof({LibrarySetWriter.TypeToCSharpConverter.ToCSharp(t.Type)})"));
                var names = string.Join(", ", signature.Select(t => t.PropName.QuoteString()));
                sb.AppendLine($"""
                                              private static CqlTupleMetadata {propertyName} = new(
                                                [{types}],
                                                [{names}]);

                                              """);
            }

            if (!first)
            {
                sb.AppendLine(
                    """
                    #endregion CqlTupleMetadata Properties

                    """);
            }
        }

        private void WriteLibraryInterfaceImplementation()
        {
            sb.AppendLine($"""
                                          #region ILibrary Implementation

                                          public string Name => {LibraryVersionedIdentifier.Identifier.ToString().QuoteString()};
                                          public string Version => {LibraryVersionedIdentifier.Version?.ToString().QuoteOrNullString()};
                                          """);
            var dependencies =
                LibrarySetWriter.LibrarySet
                                .GetLibraryDependencies(LibraryName, throwError: true)
                                .Select(dep => IdentifierNormalizer.Normalize(dep.VersionedLibraryIdentifier))
                                .Select(typeName => $"{typeName}.Instance");
            sb.AppendLine($"""
                                          public ILibrary[] Dependencies => [{string.Join(", ", dependencies)}];

                                          #endregion ILibrary Implementation

                                          """);
        }

        private void WriteUsings()
        {
            foreach (var @using in LibrarySetWriter.Usings)
                sb.AppendLine($"using {@using};");

            foreach (var @using in LibrarySetWriter.AliasedUsings)
                sb.AppendLine($"using {@using.Item1} = {@using.Item2};");

            sb.AppendLine();
        }

        private void WriteNamespaceFileScope()
        {
            if (LibrarySetWriter.Namespace is { Length: > 0 } @namespace)
            {
                sb.AppendLine($"namespace {@namespace};");
                sb.AppendLine();
            }
        }

        private CqlDefinition[]? definitions;

        public CqlDefinition[] Definitions =>
            LazyInitializer.EnsureInitialized(
                ref definitions,
                () => LibrarySetWriter
                      .Definitions
                      .SelectDefinitionsByLibraryName(LibraryName)
                      .Select(t => t.definition)
                      .ToArray());

        private CqlCodeDefinition[]? codeDefinitions;

        public CqlCodeDefinition[] CodeDefinitions =>
            LazyInitializer.EnsureInitialized(
                ref codeDefinitions,
                () => Definitions
                      .OfType<CqlCodeDefinition>()
                      .ToArray());

        private void WriteMethods()
        {
            string lastDefinitionRegion = "";

            // Assumption: definitions are already sorted by definition type
            foreach (var definition in Definitions)
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
                        sb.AppendLine($"""
                                                      #endregion {lastDefinitionRegion}

                                                      """);
                    }

                    sb.AppendLine($"""
                                                  #region {definitionRegion}

                                                  """);
                }

                lastDefinitionRegion = definitionRegion;

                var methodWriter = new DefinitionWriter(this, definition);
                methodWriter.WriteDefinition();
                sb.AppendLine();
            }

            if (lastDefinitionRegion != "")
            {
                sb.AppendLine($"""
                                              #endregion {lastDefinitionRegion}

                                              """);
            }
        }

        private void WriteClass()
        {
            sb.AppendLine(
                $"[System.CodeDom.Compiler.GeneratedCode({GeneratorToolName.QuoteString()}, {GeneratorToolVersion.QuoteString()})]");

            sb.AppendLine(
                LibraryVersionedIdentifier.Version is { } version && Version.TryParse(version, out _)
                    ? $"[CqlLibrary({LibraryVersionedIdentifier.Identifier.ToString().QuoteString()}, {version.ToString().QuoteString()})]"
                    : $"[CqlLibrary({LibraryVersionedIdentifier.Identifier.ToString().QuoteString()})]");

            sb.AppendLine($$"""
                                           public partial class {{ClassName}} : ILibrary, ISingleton<{{ClassName}}>
                                           {
                                           """);
            {
                var classBlockContext = AddIndent();
                classBlockContext.WriteClassConstructor();
                classBlockContext.WriteSingletonInstanceProperty();
                classBlockContext.WriteLibraryInterfaceImplementation();
                classBlockContext.WriteMethods();
                classBlockContext.WriteCqlTupleMetadataProperties();
            }
            sb.AppendLine("}");
        }

        private void WriteSingletonInstanceProperty()
        {
            sb.AppendLine($$"""
                                           public static {{ClassName}} Instance { get; } = new();

                                           """);
        }

        private void WriteClassConstructor()
        {
            sb.AppendLine($$"""
                                           private {{ClassName}}() {}

                                           """);
        }
    }

}