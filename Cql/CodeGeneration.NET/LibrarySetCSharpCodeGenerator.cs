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
using System.Threading;

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
                .Where(library => Definitions.Libraries.Contains(library.VersionedLibraryIdentifier))
                .TrySelect(
                    library =>
                    {
                        onBeforeProcessLibrary?.Invoke(library);

                        using var cSharpWriter = new StringWriter();
                        var libraryWriter = new LibraryWriter(this, library, cSharpWriter);
                        libraryWriter.WriteLibraryFile(library);
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

        private CqlVersionedLibraryIdentifier LibraryVersionedIdentifier => Library.VersionedLibraryIdentifier!;
        public string LibraryName { get; } = Library.VersionedLibraryIdentifier;
        private string ClassName { get; } = IdentifierNormalizer.Normalize(Library.VersionedLibraryIdentifier);
        private string? IncludedCacheClassName
        {
            get
            {
                var cacheInclude = Library.includes?
                    .FirstOrDefault(i => i.libraryName != null && i.libraryName.StartsWith("Cache"));
                if (cacheInclude != null)
                {
                    return IdentifierNormalizer.Normalize(cacheInclude.VersionedLibraryIdentifier);
                }
                return null;
            }
        }
        public LibraryWriter AddIndent(int addIndent = 1)
        {
            return this with { IndentedTextWriter = IndentedTextWriter.AddIndent(addIndent) };
        }

        public void WriteLibraryFile(Library library)
        {
            WriteUsings();
            WriteNamespaceFileScope();
            WriteClass(library);
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
                    IndentedTextWriter.WriteLine("""
                        #region CqlTupleMetadata Properties

                        """);
                    first = false;
                }

                var types = string.Join(", ", signature.Select(t => $"typeof({LibrarySetWriter.TypeToCSharpConverter.ToCSharp(t.Type)})"));
                var names = string.Join(", ", signature.Select(t => t.PropName.QuoteString()));
                IndentedTextWriter.WriteLine($"""
                                              private static CqlTupleMetadata {propertyName} = new(
                                                [{types}],
                                                [{names}]);

                                              """);
            }

            if (!first)
            {
                IndentedTextWriter.WriteLine(
                    """
                    #endregion CqlTupleMetadata Properties

                    """);
            }
        }

        private void WriteLibraryInterfaceImplementation()
        {
            IndentedTextWriter.WriteLine($"""
                                          #region ILibrary Implementation

                                          public string Name => {LibraryVersionedIdentifier.Identifier.ToString().QuoteString()};
                                          public string Version => {LibraryVersionedIdentifier.Version?.ToString().QuoteOrNullString()};
                                          """);
            var dependencies =
                LibrarySetWriter.LibrarySet
                                .GetLibraryDependencies(LibraryName, throwError: true)
                                .Select(dep => IdentifierNormalizer.Normalize(dep.VersionedLibraryIdentifier))
                                .Select(typeName => $"{typeName}.Instance");

            IndentedTextWriter.WriteLine($"""
                                          public ILibrary[] Dependencies => [];

                                          #endregion ILibrary Implementation

                                          """);
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

        private void WriteMethods(Library library)
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
                        IndentedTextWriter.WriteLine($"""
                                                      #endregion {lastDefinitionRegion}

                                                      """);
                    }

                    IndentedTextWriter.WriteLine($"""
                                                  #region {definitionRegion}

                                                  """);
                }

                lastDefinitionRegion = definitionRegion;

                var methodWriter = new DefinitionWriter(this, definition);
                methodWriter.WriteDefinition(library);
                IndentedTextWriter.WriteLine();
            }

            if (lastDefinitionRegion != "")
            {
                IndentedTextWriter.WriteLine($"""
                                              #endregion {lastDefinitionRegion}

                                              """);
            }
        }

        private void WriteClass(Library library)
        {
            IndentedTextWriter.WriteLine(
                $"[System.CodeDom.Compiler.GeneratedCode({GeneratorToolName.QuoteString()}, {GeneratorToolVersion.QuoteString()})]");

            IndentedTextWriter.WriteLine(
                LibraryVersionedIdentifier.Version is { } version && Version.TryParse(version, out _)
                    ? $"[CqlLibrary({LibraryVersionedIdentifier.Identifier.ToString().QuoteString()}, {version.ToString().QuoteString()})]"
                    : $"[CqlLibrary({LibraryVersionedIdentifier.Identifier.ToString().QuoteString()})]");

            IndentedTextWriter.WriteLine($$"""
                                           public partial class {{ClassName}} : ILibrary
                                           {
                                           """);
            {
                var classBlockContext = AddIndent();
                classBlockContext.WriteInternalProperties(library);
                classBlockContext.WriteLazyProperties(library);
                classBlockContext.WriteClassConstructor(library);
                classBlockContext.WriteSingletonInstanceProperty(library);
                classBlockContext.WriteLibraryInterfaceImplementation();
                classBlockContext.WriteMethods(library);
                classBlockContext.WriteCqlTupleMetadataProperties();
            }
            IndentedTextWriter.WriteLine("}");
        }

        private void WriteSingletonInstanceProperty(Library library)
        {
            if (library.contexts == null)
                IndentedTextWriter.WriteLine($$"""
                                           public static {{ClassName}} Instance { get; } = new();

                                           """);
        }

        private void WriteInternalProperties(Library library)
        {
            if (library.contexts != null)
            {
                bool isLibraryWithCache = library.identifier.id.StartsWith("Cache") || (library.includes != null && !library.includes.Any(i => i.libraryName != null && i.libraryName.StartsWith("Cache")));

                if (isLibraryWithCache)
                {
                    IndentedTextWriter.WriteLine($$"""
                                           internal CqlContext context;
                                           """);
                }
                else
                {
                    IndentedTextWriter.WriteLine($$"""
                                           internal CqlContext context;
                                           internal {{IncludedCacheClassName}} cache;

                                           """);
                }
            }
        }

        private void WriteLazyProperties(Library library)
        {
            if (library.contexts != null)
            {
                IndentedTextWriter.WriteLine($$"""
                                               #region Cached values
                                               """);

                foreach (var lambdaDef in Definitions.OfType<CqlLambdaDefinition>())
                {
                    var lambdaExpression = lambdaDef.LambdaExpression;
                    var methodName = IdentifierNormalizer.Normalize(lambdaDef.Name);
                    bool isCachableDefine = isDefinition(lambdaExpression);
                    bool isCacheLibrary = library.identifier.id.StartsWith("Cache") || (library.includes != null && !library.includes.Any(i => i.libraryName != null && i.libraryName.StartsWith("Cache")));
                    if (isCachableDefine)
                    {
                        var cachedValueName = DefinitionCacheKeyForMethod(methodName!);
                        var returnType = LibrarySetWriter.TypeToCSharpConverter.ToCSharp(lambdaExpression.ReturnType);

                        if(isCacheLibrary)
                            IndentedTextWriter.WriteLine($$"""
                                                   public Lazy<{{returnType}}> {{cachedValueName}};
                                                   """);
                        else
                            IndentedTextWriter.WriteLine($$"""
                                               internal Lazy<{{returnType}}> {{cachedValueName}};
                                               """);
                    }
                }
                IndentedTextWriter.WriteLine($$"""
                                               #endregion
                                               """);
            }
        }

        private void WriteClassConstructor(Library library)
        {
            if (library.contexts != null)
            {
                bool isLibraryWithCache = library.identifier.id.StartsWith("Cache") || (library.includes != null && !library.includes.Any(i => i.libraryName != null && i.libraryName.StartsWith("Cache")));

                if (isLibraryWithCache)
                {
                    IndentedTextWriter.WriteLine($$"""
                                           public {{ClassName}}(CqlContext context) {
                                                 this.context = context ?? throw new ArgumentNullException(nameof(context));
                                           """);
                }
                else
                {
                    IndentedTextWriter.WriteLine($$"""
                                           public {{ClassName}}(CqlContext context, {{IncludedCacheClassName}} cache) {
                                                 this.context = context ?? throw new ArgumentNullException(nameof(context));
                                                 this.cache = cache ?? throw new ArgumentNullException(nameof(cache));
                                           """);
                }

                foreach (var lambdaDef in Definitions.OfType<CqlLambdaDefinition>())
                {
                    var lambdaExpression = lambdaDef.LambdaExpression;
                    var methodName = IdentifierNormalizer.Normalize(lambdaDef.Name);
                    bool isCachableDefine = isDefinition(lambdaExpression);
                    if (isCachableDefine)
                    {
                        var cachedValueName = DefinitionCacheKeyForMethod(methodName!);
                        var returnType = LibrarySetWriter.TypeToCSharpConverter.ToCSharp(lambdaExpression.ReturnType);
                        var privateMethodName = methodName + "_Value";
                        IndentedTextWriter.WriteLine($$"""
                                                 {{cachedValueName}} = new Lazy<{{returnType}}>(() => this.{{privateMethodName}}(context));
                                           """);
                    }
                }

                IndentedTextWriter.WriteLine($$"""
                                           }
                                          
                                           """);
            }
        }
    }

    private record DefinitionWriter
    (
        LibraryWriter LibraryWriter,
        CqlDefinition CqlDefinition) : IAddIndentMutable<DefinitionWriter>
    {
        public DefinitionWriter AddIndent(int addIndent = 1) =>
            this with { LibraryWriter = LibraryWriter.AddIndent(addIndent) };

        private IndentedTextWriter tw => LibraryWriter.IndentedTextWriter;

        public void WriteDefinition(Library library)
        {
            var name = CqlDefinition.Name;
            string quotedName = name.QuoteString();
            string methodName = IdentifierNormalizer.Normalize(name);
            string fieldName = IdentifierNormalizer.Normalize($"_{name}");;
            var definitionAttributeTypeName = CqlDefinition.GetType().Name;            

                switch (CqlDefinition)
            {
                case CqlValueSetDefinition vsd:
                {
                    string quotedValueSetId = vsd.ValueSetId.QuoteString();
                    string quotedValueSetVersion = vsd.ValueSetVersion.QuoteOrNullString();
                    tw.WriteLine(
                        $$"""
                          [CqlValueSetDefinition({{quotedName}}, valueSetId: {{quotedValueSetId}}, valueSetVersion: {{quotedValueSetVersion}})]
                          public CqlValueSet {{methodName}}(CqlContext _) => {{fieldName}};
                          private static readonly CqlValueSet {{fieldName}} = new CqlValueSet({{quotedValueSetId}}, {{quotedValueSetVersion}});
                          """);
                } return;

                case CqlConceptDefinition ccd:
                {
                    string quotedConceptDisplay = ccd.Display.QuoteOrNullString();
                    string arrayOfCodes = string.Join(
                        ",",
                        ccd.Codes.Select(code =>
                        {
                            var cqlCodeDefinition = LibraryWriter.CodeDefinitions.FirstOrDefault(codeDefinition => codeDefinition.Code == code);
                            var codeField = cqlCodeDefinition is not null
                                                ? IdentifierNormalizer.Normalize($"_{cqlCodeDefinition.Name}")
                                                : $"new CqlCode({code.code!.QuoteString()}, {code.system.QuoteOrNullString()})";
                            return $"""

                                          {codeField}
                                    """;
                        }));
                    tw.WriteLine(
                        $$"""
                          [CqlConceptDefinition({{quotedName}})]
                          public CqlConcept {{methodName}}(CqlContext _) => {{fieldName}};
                          private static readonly CqlConcept {{fieldName}} =
                            new CqlConcept([{{arrayOfCodes}}],
                                {{quotedConceptDisplay}});
                          """);
                    } return;

                case CqlCodeSystemDefinition csd:
                {
                    string quotedCodeSystemId = csd.CodeSystem.id!.QuoteString();
                    string quotedCodeSystemVersion = csd.CodeSystem.version.QuoteOrNullString();
                    string arrayOfCodes = string.Join(
                        ",",
                        csd.CodeSystem.codes.Select(code =>
                        {
                            var cqlCodeDefinition = LibraryWriter.CodeDefinitions.FirstOrDefault(codeDefinition => codeDefinition.Code == code);
                            var codeField = cqlCodeDefinition is not null
                                       ? IdentifierNormalizer.Normalize($"_{cqlCodeDefinition.Name}")
                                       : $"new CqlCode({code.code!.QuoteString()}, {code.system.QuoteOrNullString()})";
                            return $"""

                                          {codeField}
                                    """;
                        }));
                    tw.WriteLine(
                        $$"""
                          [CqlCodeSystemDefinition({{quotedName}}, codeSystemId: {{quotedCodeSystemId}}, codeSystemVersion: {{quotedCodeSystemVersion}})]
                          public CqlCodeSystem {{methodName}}(CqlContext _) => {{fieldName}};
                          private static readonly CqlCodeSystem {{fieldName}} =
                            new CqlCodeSystem({{quotedCodeSystemId}}, {{quotedCodeSystemVersion}}, [{{arrayOfCodes}}]);
                          """);
                } return;

                case CqlCodeDefinition cd:
                {
                    var quotedCodeId = cd.Code.code!.QuoteString();
                    var quotedCodeSystem = cd.Code.system.QuoteOrNullString();
                    tw.WriteLine(
                        $$"""
                          [CqlCodeDefinition({{quotedName}}, codeId: {{quotedCodeId}}, codeSystem: {{quotedCodeSystem}})]
                          public CqlCode {{methodName}}(CqlContext _) => {{fieldName}};
                          private static readonly CqlCode {{fieldName}} = new CqlCode({{quotedCodeId}}, {{quotedCodeSystem}});
                          """);
                } return;
            }

            if (CqlDefinition is not CqlLambdaDefinition ld)
                throw new NotSupportedException($"No support for {CqlDefinition.GetType()}");

            tw.WriteLine(
                $"""
                 [{definitionAttributeTypeName}({quotedName})]
                 """);

            if (CqlDefinition is CqlExpressionDefinition ed)
                foreach (var tag in ed.Tags)
                    foreach (var tagValue in tag.Values)
                        tw.WriteLine($"[CqlTag({tag.Name.QuoteString()}, {tagValue.QuoteString()})]");

            VariableNameGenerator variableNameGenerator = new([], postfix: "_");

            var visitedBody = Transform(
                ld.LambdaExpression.Body,
                new RedundantCastsTransformer(),
                new SimplifyExpressionsVisitor(),
                new RenameVariablesVisitor(variableNameGenerator),
                new LocalVariableDeduper(LibraryWriter.LibrarySetWriter.TypeToCSharpConverter)
            );

            // Skip CqlContext
            var definitionToCSharpCodeProcessor = new LibraryDefinitionCSharpCodeGenerator(
                LibraryWriter.LibrarySetWriter.TupleMetadataBuilder,
                LibraryWriter.LibraryName,
                LibraryWriter.LibrarySetWriter.TypeToCSharpConverter,
                0);

            var parameters = ld.LambdaExpression.Parameters.Skip(1);
            var transformedLambda = Expression.Lambda(visitedBody, parameters);

            // Extract original parameter names if this is a CqlFunctionDefinition
            IReadOnlyDictionary<string, string>? originalParameterNames = CqlDefinition is CqlFunctionDefinition { OriginalParameterNames.Count: > 0 } functionDef
                ? functionDef.OriginalParameterNames
                : null;

            var lambdaExpression = ld.LambdaExpression;
            bool isCachableDefine = isDefinition(lambdaExpression);
            if (library.contexts != null && isCachableDefine)
            {
                var cachedMethodName = methodName + "_Value";
                var cachedDefinitionWithBody = definitionToCSharpCodeProcessor.ProcessDefinition(transformedLambda, cachedMethodName, specifiers: "private", library, originalParameterNames);
                tw.WriteLine(cachedDefinitionWithBody);

                var funcSb = new StringBuilder();
                funcSb.Append("public ");
                funcSb.Append(LibraryWriter.LibrarySetWriter.TypeToCSharpConverter.ToCSharp(transformedLambda.ReturnType) + " ");
                funcSb.Append(methodName + "() =>");
                funcSb.AppendLine();
                funcSb.Append("    __" + methodName + "?.Value;");
                funcSb.AppendLine();
                tw.WriteLine(funcSb.ToString());
            }
            else
            {
                var definitionWithBody = definitionToCSharpCodeProcessor.ProcessDefinition(transformedLambda, methodName, specifiers: "public", library, originalParameterNames);
                tw.WriteLine(definitionWithBody);
            }
        }

        private static Expression Transform(Expression body, params ExpressionVisitor[] visitors)
        {
            foreach (var visitor in visitors) body = visitor.Visit(body);
            return body;
        }
    }

    private static bool isDefinition(LambdaExpression lambdaExp) =>
        lambdaExp.Parameters.Count == 1
        && lambdaExp.Parameters[0].Type == typeof(CqlContext);

    private static string DefinitionCacheKeyForMethod(string methodName)
    {
        if (methodName[0] == '@')
            return "__" + methodName.Substring(1);
        else return "__" + methodName;
    }

    #endregion Nested Types
}