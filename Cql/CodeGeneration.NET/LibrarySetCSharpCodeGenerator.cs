/*
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;
using Hl7.Cql.CodeGeneration.NET.Visitors;
using Hl7.Cql.Compiler;
using Hl7.Cql.Compiler.Expressions;
using Hl7.Cql.Elm;
using Hl7.Cql.Operators;
using Hl7.Cql.Primitives;
using Hl7.Cql.Runtime;
using Hl7.Cql.ValueSets;
using System.Diagnostics;

namespace Hl7.Cql.CodeGeneration.NET;

/// <summary>
/// Processes a definition dictionary of <see cref="LambdaExpression"/> into a .NET classes per library.
/// </summary>
internal partial class LibrarySetCSharpCodeGenerator
{
    /// <summary>
    /// Gets the product of this <see cref="LibrarySetCSharpCodeGenerator"/> as will appear
    /// in the <see cref="System.CodeDom.Compiler.GeneratedCodeAttribute.Tool"/>.
    /// </summary>
    internal static string GeneratorToolName { get; } = GetGeneratorToolNameFromAssemblyProductName();

    private readonly TypeToCSharpConverter _typeToCSharpConverter;

    /// <summary>
    /// Gets the <see langword="using"/> statements to be included in the generated code.
    /// </summary>
    private readonly HashSet<string> _usings;

    /// <summary>
    /// Gets the aliased <see langword="using"/> statements to be included in the generated code.
    /// For example,
    /// <code>
    /// using Item1 = Item2;
    /// </code>
    /// </summary>
    private readonly IReadOnlyList<(string alias, string type)> _aliasedUsings;

    public LibrarySetCSharpCodeGenerator(
        TypeResolver typeResolver,
        TypeToCSharpConverter typeToCSharpConverter)
    {
        _typeToCSharpConverter = typeToCSharpConverter;
        _usings = BuildUsings(typeResolver);
        _aliasedUsings = typeResolver.Aliases.ToList();
    }

    private static string GetGeneratorToolNameFromAssemblyProductName() =>
        typeof(LibrarySetCSharpCodeGenerator)
            .Assembly
            .GetCustomAttributes(false)
            .OfType<AssemblyProductAttribute>()
            .SingleOrDefault()?
            .Product ?? "ELM-to-CSharp";

    private static HashSet<string> BuildUsings(TypeResolver typeResolver)
    {
        var hashSet = new HashSet<string>
        {
            nameof(System),
            typeof(Enumerable).Namespace!,    // System.Linq
            typeof(ICollection<>).Namespace!, // System.Collections.Generic
            typeof(CqlContext).Namespace!,
            typeof(CqlPrimitiveType).Namespace!,
            typeof(CqlDefinitionAttribute).Namespace!,
            typeof(IValueSetFacade).Namespace!,
            typeof(Iso8601.DateIso8601).Namespace!,
            typeof(PropertyInfo).Namespace!,
            typeof(RetrieveParameters).Namespace!,
        };

        foreach (var @using in typeResolver.ModelNamespaces)
            hashSet.Add(@using);

        return hashSet;
    }

    public IEnumerable<(Library library, string cSharp)> GenerateEachLibraryToCSharp(
        LibrarySet librarySet,
        CqlDefinitionDictionary definitions,
        BatchProcessExceptionHandlingStrategyBuilder<Library>? buildExceptionHandlingStrategy = null,
        Action<Library>? onBeforeProcessLibrary = null)
    {
        var librarySetWriter = new LibrarySetWriter(this, librarySet, definitions);
        return librarySetWriter.GenerateEachLibraryToCSharp(buildExceptionHandlingStrategy, onBeforeProcessLibrary);
    }

    #region Nested Types

    private record LibrarySetWriter
    (
        LibrarySetCSharpCodeGenerator Processor,
        LibrarySet LibrarySet,
        CqlDefinitionDictionary Definitions)
    {
        public TupleMetadataBuilder TupleMetadataBuilder { get; } = new();
        public TypeToCSharpConverter TypeToCSharpConverter => Processor._typeToCSharpConverter;
        public IReadOnlyList<(string alias, string type)> AliasedUsings => Processor._aliasedUsings;
        public HashSet<string> Usings => Processor._usings;
        public string? Namespace { get; } = null; // Not used right now

        public IEnumerable<(Library library, string cSharp)> GenerateEachLibraryToCSharp(
            BatchProcessExceptionHandlingStrategyBuilder<Library>? buildExceptionHandlingStrategy = null,
            Action<Library>? onBeforeProcessLibrary = null) =>
            LibrarySet
                .Where(library => Definitions.Libraries.Contains(library.GetVersionedIdentifier()!))
                .TrySelect(
                    library =>
                    {
                        onBeforeProcessLibrary?.Invoke(library);

                        using var cSharpWriter = new StringWriter();
                        var libraryWriter = new LibraryWriter(this, library, cSharpWriter);
                        libraryWriter.WriteLibraryFile();
                        cSharpWriter.Flush();
                        var cSharp = cSharpWriter.ToString();
                        return (library, cSharp);
                    },
                    buildExceptionHandlingStrategy);
    }

    private record LibraryWriter
    (
        LibrarySetWriter LibrarySetWriter,
        Library Library,
        IndentedTextWriter IndentedTextWriter) : IAddIndentMutable<LibraryWriter>
    {
        public LibraryWriter(
            LibrarySetWriter librarySetWriter,
            Library library,
            TextWriter textWriter,
            int indent = 0) : this(librarySetWriter, library, new IndentedTextWriter(textWriter, indent)) { }

        private VersionedIdentifier LibraryVersionedIdentifier => ((IGetVersionedIdentifier)Library).VersionedIdentifier.Result!;
        public string LibraryName { get; } = Library.GetVersionedIdentifier()!;
        private string ClassName { get; } = VariableNameGenerator.NormalizeIdentifier(Library.GetVersionedIdentifier()!)!;

        public LibraryWriter AddIndent(int addIndent = 1)
        {
            return this with { IndentedTextWriter = IndentedTextWriter.AddIndent(addIndent) };
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
                    IndentedTextWriter.WriteLine("#region CqlTupleMetadata Properties");
                    IndentedTextWriter.WriteLine();
                    first = false;
                }

                var types = string.Join(", ", signature.Select(t => $"typeof({LibrarySetWriter.TypeToCSharpConverter.ToCSharp(t.Type)})"));
                var names = string.Join(", ", signature.Select(t => t.PropName.QuoteString()));
                IndentedTextWriter.WriteLine($"private static CqlTupleMetadata {propertyName} = new(");
                IndentedTextWriter.WriteLine(1, $"[{types}],");
                IndentedTextWriter.WriteLine(1, $"[{names}]);");
                IndentedTextWriter.WriteLine();
            }

            if (!first)
            {
                IndentedTextWriter.WriteLine("#endregion CqlTupleMetadata Properties");
                IndentedTextWriter.WriteLine();
            }
        }

        private void WriteLibraryInterfaceImplementation()
        {
            IndentedTextWriter.WriteLine("#region ILibrary Implementation");
            IndentedTextWriter.WriteLine();
            IndentedTextWriter.WriteLine($"public string Name => {LibraryVersionedIdentifier.id.QuoteString()};");
            IndentedTextWriter.WriteLine($"public string Version => {LibraryVersionedIdentifier.version.QuoteString()};");
            var dependencies =
                LibrarySetWriter.LibrarySet
                                .GetLibraryDependencies(LibraryName, throwError: true)
                                .Select(dep => VariableNameGenerator.NormalizeIdentifier(dep.GetVersionedIdentifier()!))
                                .Select(typeName => $"{typeName}.Instance");
            IndentedTextWriter.WriteLine($"public ILibrary[] Dependencies => [{string.Join(", ", dependencies)}];");
            IndentedTextWriter.WriteLine();
            IndentedTextWriter.WriteLine("#endregion ILibrary Implementation");
            IndentedTextWriter.WriteLine();
        }

        private void WriteUsings()
        {
            foreach (var @using in LibrarySetWriter.Usings)
                IndentedTextWriter.WriteLine($"using {@using};");

            foreach (var @using in LibrarySetWriter.AliasedUsings)
                IndentedTextWriter.WriteLine($"using {@using.Item1} = {@using.Item2};");

            IndentedTextWriter.WriteLine();
        }

        private void WriteNamespaceFileScope()
        {
            if (LibrarySetWriter.Namespace is { Length: > 0 } @namespace)
            {
                IndentedTextWriter.WriteLine($"namespace {@namespace};");
                IndentedTextWriter.WriteLine();
            }
        }

        private void WriteMethods()
        {
            var definitions = LibrarySetWriter.Definitions;
            var libraryName = LibraryName;
            string lastDefinitionType = "";

            // Assumption: definitions are already sorted by definition type
            foreach ((_, _, CqlDefinition definition) in
                     definitions.EnumerateExpressionsByLibraryName(libraryName))
            {
                // Assumption: type name will be Cql....Definition
                Debug.Assert(definition.GetType().Name is {} name && name.StartsWith("Cql") && name.EndsWith("Definition"));
                string definitionType = definition.GetType().Name["Cql".Length..^"Definition".Length];

                if (lastDefinitionType != definitionType)
                {
                    if (lastDefinitionType != "")
                    {
                        IndentedTextWriter.WriteLine($"#endregion {lastDefinitionType}s");
                        IndentedTextWriter.WriteLine();
                    }

                    IndentedTextWriter.WriteLine($"#region {definitionType}s");
                    IndentedTextWriter.WriteLine();
                }

                lastDefinitionType = definitionType;

                var methodWriter = new DefinitionWriter(this, definition);
                methodWriter.WriteDefinition();
                IndentedTextWriter.WriteLine();
            }

            if (lastDefinitionType != "")
            {
                IndentedTextWriter.WriteLine($"#endregion {lastDefinitionType}s");
                IndentedTextWriter.WriteLine();
            }
        }

        private void WriteClass()
        {
            IndentedTextWriter.WriteLine(
                $"[System.CodeDom.Compiler.GeneratedCode({GeneratorToolName.QuoteString()}, {GeneratorToolVersion.QuoteString()})]");

            IndentedTextWriter.WriteLine(
                LibraryVersionedIdentifier.version is { } version && Version.TryParse(version, out _)
                    ? $"[CqlLibrary({LibraryVersionedIdentifier.id.QuoteString()}, {version.QuoteString()})]"
                    : $"[CqlLibrary({LibraryVersionedIdentifier.id.QuoteString()})]");

            IndentedTextWriter.WriteLine($"public partial class {ClassName} : ILibrary, ISingleton<{ClassName}>");
            IndentedTextWriter.WriteLine("{");
            {
                var classBlockContext = AddIndent();
                classBlockContext.WriteClassConstructor();
                classBlockContext.WriteSingletonInstanceProperty();
                classBlockContext.WriteLibraryInterfaceImplementation();
                classBlockContext.WriteMethods();
                classBlockContext.WriteCqlTupleMetadataProperties();
            }
            IndentedTextWriter.WriteLine("}");
        }

        private void WriteSingletonInstanceProperty()
        {
            IndentedTextWriter.WriteLine($"public static {ClassName} Instance {{ get; }} = new();");
            IndentedTextWriter.WriteLine();
        }

        private void WriteClassConstructor()
        {
            IndentedTextWriter.WriteLine($"private {ClassName}() {{}}");
            IndentedTextWriter.WriteLine();
        }
    }

    private record DefinitionWriter(
        LibraryWriter LibraryWriter,
        CqlDefinition CqlDefinition) : IAddIndentMutable<DefinitionWriter>
    {
        private static readonly VariableNameGenerator VariableNameGenerator = new(Enumerable.Empty<string>(), postfix: "_");

        public DefinitionWriter AddIndent(int addIndent = 1) =>
            this with { LibraryWriter = LibraryWriter.AddIndent(addIndent) };

        private IndentedTextWriter tw => LibraryWriter.IndentedTextWriter;

        public void WriteDefinition()
        {
            var definitionName = CqlDefinition.DefinitionName;
            string quotedDefinitionName = definitionName.QuoteString();
            string methodName  = VariableNameGenerator.NormalizeIdentifier(definitionName)!;
            string fieldName  = VariableNameGenerator.NormalizeIdentifier($"_{definitionName}")!;
            switch (CqlDefinition)
            {
                case CqlValueSetDefinition vsd:
                {
                    string quotedValueSetId = vsd.ValueSetId.QuoteString();
                    string quotedValueSetVersion = vsd.ValueSetVersion?.QuoteString() ?? "null";
                    tw.WriteLines(
                        $"""
                         #region ValueSet: {definitionName}
                         [CqlValueSetDefinition(
                             definitionName: {quotedDefinitionName},
                             valueSetId: {quotedValueSetId},
                             valueSetVersion: {quotedValueSetVersion})]
                         public CqlValueSet {methodName}(CqlContext context) => {fieldName};

                         private static readonly CqlValueSet {fieldName} = new CqlValueSet({quotedValueSetId}, {quotedValueSetVersion});
                         #endregion
                         """);
                    return;
                }

                case CqlCodeSystemDefinition csd:
                    break;

                case CqlParameterDefinition pd:
                    break;

                case CqlConceptDefinition cpd:
                    break;

                 case CqlCodeDefinition cd:
                     var quotedCodeId = cd.CodeId.QuoteString();
                     var quotedCodeSystem = cd.CodeSystem.QuoteString();
                     tw.WriteLines(
                         $"""
                          #region Code: {definitionName}
                          [CqlCodeDefinition(
                              definitionName: {quotedDefinitionName},
                              codeId: {quotedCodeId},
                              codeSystem: {quotedCodeSystem})]
                          public CqlCode {methodName }(CqlContext context) => {fieldName};

                          private static readonly CqlCode {fieldName} = new CqlCode({quotedCodeId}, {quotedCodeSystem}, default, default);
                          #endregion
                          """);
                     return;
            }

            string libraryName = LibraryWriter.LibraryName;
            var lambda = CqlDefinition.Lambda;
            var isDefinition = lambda is { Parameters: [{ Type: { } p0Type }] } && p0Type == typeof(CqlContext);
            TupleMetadataBuilder tupleMetadataBuilder = LibraryWriter.LibrarySetWriter.TupleMetadataBuilder;

            var visitedBody = Transform(
                lambda.Body,
                new RedundantCastsTransformer(),
                new SimplifyExpressionsVisitor(),
                new RenameVariablesVisitor(VariableNameGenerator),
                new LocalVariableDeduper(LibraryWriter.LibrarySetWriter.TypeToCSharpConverter)
            );

            // Skip CqlContext
            var parameters = lambda.Parameters.Skip(1);
            var transformedLambda = Expression.Lambda(visitedBody, parameters);

            var definitionToCSharpCodeProcessor = new LibraryDefinitionCSharpCodeGenerator(
                tupleMetadataBuilder,
                libraryName,
                LibraryWriter.LibrarySetWriter.TypeToCSharpConverter,
                tw.Indent);

            var definition = definitionToCSharpCodeProcessor.ProcessDefinition(
                transformedLambda,
                methodName,
                specifiers: "public");

            var definitionTypeName = CqlDefinition.GetType().Name;
            if (isDefinition)
            {
                List<string> lines = [$"definitionName: {definitionName.QuoteString()}"];
                switch (CqlDefinition)
                {
                    case CqlValueSetDefinition vsd:
                        //if (System.DateTime.Now.Second >= 0) return;
                        if (vsd.ValueSetId is {} vsid)
                            lines.Add($"valueSetId: {vsid.QuoteString()}");
                        if (vsd.ValueSetVersion is {} vsv)
                            lines.Add($"valueSetVersion: {vsv.QuoteString()}");
                        break;

                    case CqlCodeSystemDefinition csd:
                        //if (System.DateTime.Now.Second >= 0) return;
                        // if (csd.Codes.Length > 0)
                        // {
                        //     var indent = new string(' ', TextWriterExtensions.SpacesPerIndentLevel);
                        //     for (var i = 0; i < csd.Codes.Length; i++)
                        //     {
                        //         bool isFirst = i == 0;
                        //         bool isLast = i == csd.Codes.Length - 1;
                        //         var c = csd.Codes[i];
                        //         switch (isFirst, isLast)
                        //         {
                        //             case (false, false):
                        //                 lines.Add($"{indent}({c.codeId.QuoteString()}, {c.codeSystem.QuoteString()})");
                        //                 break;
                        //             case (true, true):
                        //                 lines.Add($"codes: [({c.codeId.QuoteString()}, {c.codeSystem.QuoteString()})]");
                        //                 break;
                        //             case (true, false):
                        //                 lines.Add($"codes: [({c.codeId.QuoteString()}, {c.codeSystem.QuoteString()})");
                        //                 break;
                        //             case (false, true):
                        //                 lines.Add($"{indent}({c.codeId.QuoteString()}, {c.codeSystem.QuoteString()}))]");
                        //                 break;
                        //         }
                        //     }}
                        break;

                    case CqlParameterDefinition pd:
                        break;

                    case CqlConceptDefinition cpd:
                        break;

                    case CqlCodeDefinition cd:
                        //if (System.DateTime.Now.Second >= 0) return;
                        if (cd.CodeId is {} cid)
                            lines.Add($"codeId: {cid.QuoteString()}");
                        if (cd.CodeSystem is {} cs)
                            lines.Add($"codeSystem: {cs.QuoteString()}");
                        break;
                }

                for (int i = 0; i < lines.Count-1; i++)
                    lines[i] = $"{lines[i]},";
                lines[^1] = $"{lines[^1]})]";

                tw.WriteLine($"[{definitionTypeName}(");
                var tw1 = tw.AddIndent();
                for (int i = 0; i < lines.Count; i++)
                    tw1.WriteLine($"{lines[i]}");
            }
            else
            {
                tw.WriteLine($"// NOT A DEFINITION {definitionTypeName}//");
            }

            if (CqlDefinition is CqlExpressionDefinition {} ed)
                WriteTags(ed);

            tw.WriteLine(definition);
        }

        private void WriteTags(CqlExpressionDefinition ed)
        {
            foreach (var tag in ed.Tags)
                foreach (var tagValue in tag.Values)
                    tw.WriteLine($"[CqlTag({tag.Name.QuoteString()}, {tagValue.QuoteString()})]");
        }

        private static Expression Transform(Expression body, params ExpressionVisitor[] visitors)
        {
            foreach (var visitor in visitors) body = visitor.Visit(body);
            return body;
        }
    }

    #endregion Nested Types
}