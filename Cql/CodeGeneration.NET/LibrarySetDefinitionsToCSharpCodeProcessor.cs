/*
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;
using Hl7.Cql.CodeGeneration.NET.Visitors;
using Hl7.Cql.Primitives;
using Hl7.Cql.Runtime;
using Hl7.Cql.ValueSets;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using Hl7.Cql.Abstractions.Exceptions;
using Hl7.Cql.Compiler;
using Hl7.Cql.Elm;
using Hl7.Cql.Operators;
using Expression = System.Linq.Expressions.Expression;

namespace Hl7.Cql.CodeGeneration.NET;

/// <summary>
/// Processes a definition dictionary of <see cref="LambdaExpression"/> into a .NET classes per library.
/// </summary>
internal class LibrarySetDefinitionsToCSharpCodeProcessor
{
    private readonly ILogger<LibrarySetDefinitionsToCSharpCodeProcessor> _logger;

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

    /// <summary>
    /// Gets the <see cref="TupleMetadataBuilder"/> to be used to build tuples in the generated code.
    /// </summary>
    private readonly TupleMetadataBuilder _tupleMetadataBuilder;

    /// <summary>
    /// Gets the version of this <see cref="LibrarySetDefinitionsToCSharpCodeProcessor"/> as will appear in the <see cref="System.CodeDom.Compiler.GeneratedCodeAttribute.Version"/>.
    /// </summary>
    private readonly string _generatorToolVersion;

    /// <summary>
    /// Gets the product of this <see cref="LibrarySetDefinitionsToCSharpCodeProcessor"/> as will appear in the <see cref="System.CodeDom.Compiler.GeneratedCodeAttribute.Tool"/>.
    /// </summary>
    private readonly string _generatorToolName;

    public LibrarySetDefinitionsToCSharpCodeProcessor(
        ILogger<LibrarySetDefinitionsToCSharpCodeProcessor> logger,
        TypeResolver typeResolver,
        TypeToCSharpConverter typeToCSharpConverter)
    {
        _logger = logger;
        _typeToCSharpConverter = typeToCSharpConverter;
        _usings = BuildUsings(typeResolver);
        var thisAssembly = GetType().Assembly;
        _tupleMetadataBuilder = new TupleMetadataBuilder();
        _generatorToolVersion = thisAssembly.GetName().Version?.ToString() ?? "1.0.0";
        _generatorToolName = thisAssembly.GetCustomAttributes(false)
                                         .OfType<AssemblyProductAttribute>()
                                         .SingleOrDefault()?
                                         .Product ?? "ELM-to-CSharp";
        _aliasedUsings = typeResolver.Aliases.ToList();
    }

    private static HashSet<string> BuildUsings(TypeResolver typeResolver)
    {
        var hashSet = new HashSet<string>
        {
            nameof(System),
            typeof(Enumerable).Namespace!,    // System.Linq
            typeof(ICollection<>).Namespace!, // System.Collections.Generic
            typeof(CqlContext).Namespace!,
            typeof(CqlPrimitiveType).Namespace!,
            typeof(CqlDeclarationAttribute).Namespace!,
            typeof(IValueSetFacade).Namespace!,
            typeof(Iso8601.DateIso8601).Namespace!,
            typeof(PropertyInfo).Namespace!,
            typeof(RetrieveParameters).Namespace!,
        };

        foreach (var @using in typeResolver.ModelNamespaces)
            hashSet.Add(@using);

        return hashSet;
    }

    internal IEnumerable<(Library library, Func<string> generateCSharp)> GenerateCSharpV2(
        LibrarySet librarySet,
        DefinitionDictionary<LambdaExpression> definitions)
    {
        var librarySetWriter = new LibrarySetWriter(this, librarySet, definitions, CSharpSourceCodeWriterCallbacks.Default, default);
        return librarySetWriter.GenerateCSharpV2();
    }

    /// <summary>
    /// Writes C# source code from inputs.
    /// </summary>
    /// <param name="librarySet">A dependency graph containing dependent libraries.</param>
    /// <param name="definitions">The lambda expressions to write.</param>
    /// <param name="callbacks">Callbacks which is used during the processing of each stream.</param>
    /// <param name="processLibraryToCSharpExceptionHandling">Selecting the exception handling policy for writing libraries to C#.</param>
    /// <see cref="GenerateCSharpV2"/>
    [Obsolete("Use GenerateCSharpV2 instead")]
    public void ProcessDefinitions(
        LibrarySet librarySet,
        DefinitionDictionary<LambdaExpression> definitions,
        CSharpSourceCodeWriterCallbacks? callbacks = null,
        ProcessBatchItemExceptionHandling processLibraryToCSharpExceptionHandling = default)
    {
        List<Stream> streamsToDispose = new();
        callbacks ??= new();
        try
        {
            var librarySetWriter = new LibrarySetWriter(this, librarySet, definitions, callbacks, processLibraryToCSharpExceptionHandling);
            foreach (var (name, stream) in librarySetWriter.WriteLibraries())
            {
                streamsToDispose.Add(stream);
                callbacks.Step(name, stream);
            }

            callbacks.Done();
        }
        finally
        {
            foreach (var stream in streamsToDispose)
            {
                stream.Dispose();
            }
        }
    }

    #region Nested Types

    private record LibrarySetWriter(
        LibrarySetDefinitionsToCSharpCodeProcessor Processor,
        LibrarySet LibrarySet,
        DefinitionDictionary<LambdaExpression> Definitions,
        CSharpSourceCodeWriterCallbacks Callbacks,
        ProcessBatchItemExceptionHandling ProcessLibraryToCSharpExceptionHandling)
    {
        public ProcessBatchItemExceptionHandling ProcessLibraryToCSharpExceptionHandling { get; } = ProcessLibraryToCSharpExceptionHandling;
        public TupleMetadataBuilder TupleMetadataBuilder => Processor._tupleMetadataBuilder;
        public string GeneratorToolName => Processor._generatorToolName;
        public string GeneratorToolVersion => Processor._generatorToolVersion;
        public TypeToCSharpConverter TypeToCSharpConverter => Processor._typeToCSharpConverter;
        public IReadOnlyList<(string alias, string type)> AliasedUsings => Processor._aliasedUsings;
        public HashSet<string> Usings => Processor._usings;
        public string? Namespace => null;
        public ILogger<LibrarySetDefinitionsToCSharpCodeProcessor> Logger => Processor._logger;

        public IEnumerable<(string name, Stream stream)> WriteLibraries()
        {
            if (!LibrarySet.Any())
            {
                Logger.LogInformation($"No libraries detected; skipping.");
                return [];
            }

            IEnumerable<(string libraryName, Library library, Stream stream)> GetLibrariesForProcessing()
            {
                foreach (Library library in LibrarySet)
                {
                    string libraryName = library.GetVersionedIdentifier()!;
                    if (!Callbacks.ShouldWriteLibrary(libraryName))
                    {
                        Logger.LogInformation($"Skipping library {libraryName} as per callback.");
                        continue;
                    }

                    if (!Definitions.Libraries.Contains(libraryName))
                    {
                        Logger.LogInformation($"Skipping library {libraryName}, which has no definitions");
                        continue;
                    }

                    var stream = Callbacks.GetStreamForLibraryName(libraryName);
                    if (stream == null!)
                        continue;

                    yield return (libraryName, library, stream);
                }
            }

            return GetLibrariesForProcessing()
                   .TryProcessEach(t =>
                   {
                       WriteLibrary(t.library, t.stream);
                       return (t.libraryName, t.stream);
                   })
                   .WithEachException(t =>
                   {
                       var libraryName = t.Input.libraryName;
                       switch (ProcessLibraryToCSharpExceptionHandling)
                       {
                           case ProcessBatchItemExceptionHandling.ThrowException:
                               Logger.LogError(t.Exception, "Error writing library '{libraryName}' to C#.",
                                               libraryName);
                               break;
                           case ProcessBatchItemExceptionHandling.IgnoreExceptionAndContinue:
                               Logger.LogWarning(
                                   t.Exception,
                                   "Error writing library '{libraryName}' to C#, continuing.",
                                   libraryName);
                               break;
                           case ProcessBatchItemExceptionHandling.IgnoreExceptionAndBreak:
                               Logger.LogWarning(
                                   t.Exception, "Error writing library '{libraryName}' to C#, aborting.",
                                   libraryName);
                               break;
                       }
                   })
                   .HandleExceptions(ProcessLibraryToCSharpExceptionHandling);

            void WriteLibrary(Library library, Stream stream)
            {
                using var writer = new StreamWriter(stream, Encoding.UTF8, 1024, leaveOpen: true);
                var libraryWriter = new LibraryWriter(this, library, writer);
                libraryWriter.WriteLibraryFile();
                writer.Flush();
            }
        }

        public IEnumerable<(Library library, Func<string> generateCSharp)> GenerateCSharpV2()
        {
            foreach (var library in LibrarySet)
            {
                string libraryName = library.GetVersionedIdentifier()!;
                if (!Definitions.Libraries.Contains(libraryName))
                    continue;

                yield return (library,GenerateCSharp);

                string GenerateCSharp()
                {
                    using var cSharpWriter = new StringWriter();
                    var libraryWriter = new LibraryWriter(this, library, cSharpWriter);
                    libraryWriter.WriteLibraryFile();
                    cSharpWriter.Flush();
                    return cSharpWriter.ToString();
                }
            }
        }
    }

    private record LibraryWriter(
        LibrarySetWriter LibrarySetWriter,
        Library Library,
        IndentedTextWriter IndentedTextWriter) : IAddIndentMutable<LibraryWriter>
    {
        public LibraryWriter(
            LibrarySetWriter librarySetWriter,
            Library library,
            TextWriter textWriter,
            int indent = 0) : this(librarySetWriter, library, new IndentedTextWriter(textWriter, indent)) {}

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
            var libraryNameToClassName = LibrarySetWriter.Callbacks.LibraryNameToClassName;
            IndentedTextWriter.WriteLine("#region ILibrary Implementation");
            IndentedTextWriter.WriteLine();
            IndentedTextWriter.WriteLine($"string ILibrary.Name => {LibraryVersionedIdentifier.id.QuoteString()};");
            IndentedTextWriter.WriteLine($"string ILibrary.Version => {LibraryVersionedIdentifier.version.QuoteString()};");
            var dependencies =
                LibrarySetWriter.LibrarySet
                                .GetLibraryDependencies(LibraryName, throwError: true)
                                .Select(dep => libraryNameToClassName(dep.GetVersionedIdentifier()!))
                                .Select(typeName => $"{typeName}.Instance");
            IndentedTextWriter.WriteLine($"IReadOnlyList<ILibrary> ILibrary.Dependencies => [{string.Join(", ", dependencies)}];");
            IndentedTextWriter.WriteLine();
            IndentedTextWriter.WriteLine("#endregion Library Members");
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
            bool first = true;

            foreach (var (definition, overloads) in definitions.DefinitionsForLibrary(libraryName))
            {
                foreach (var (signature, expression) in overloads)
                {
                    if (first)
                    {
                        IndentedTextWriter.WriteLine("#region Definition Methods");
                        IndentedTextWriter.WriteLine();
                        first = false;
                    }
                    definitions.TryGetTags(libraryName, definition, signature, out var tags);
                    var methodWriter = CreateMethodWriter(definition, expression, tags);
                    methodWriter.WriteMethod();
                }
            }

            if (!first)
            {
                IndentedTextWriter.WriteLine("#endregion Definition Methods");
                IndentedTextWriter.WriteLine();
            }
        }

        private MethodWriter CreateMethodWriter(string definition, LambdaExpression expression, ILookup<string, string>? tags)
        {
            return new MethodWriter(this, definition, expression, tags);
        }

        private void WriteClass()
        {
            IndentedTextWriter.WriteLine($"[System.CodeDom.Compiler.GeneratedCode({LibrarySetWriter.GeneratorToolName.QuoteString()}, {LibrarySetWriter.GeneratorToolVersion.QuoteString()})]");

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

    private record MethodWriter(
        LibraryWriter LibraryWriter,
        string CqlName,
        LambdaExpression Overload,
        ILookup<string, string>? Tags) : IAddIndentMutable<MethodWriter>
    {
        private string MethodName { get; } = VariableNameGenerator.NormalizeIdentifier(CqlName)!;

        public MethodWriter AddIndent(int addIndent = 1)
        {
            return this with { LibraryWriter = LibraryWriter.AddIndent(addIndent) };
        }

        private IndentedTextWriter IndentedTextWriter => LibraryWriter.IndentedTextWriter;

        public void WriteMethod()
        {
            string libraryName = LibraryWriter.LibraryName;
            LambdaExpression overload = Overload;
            TupleMetadataBuilder tupleMetadataBuilder = LibraryWriter.LibrarySetWriter.TupleMetadataBuilder;
            var isDef = IsDefinition(overload);

            var vng = new VariableNameGenerator(Enumerable.Empty<string>(), postfix: "_");

            var visitedBody = Transform(
                overload.Body,
                new RedundantCastsTransformer(),
                new SimplifyExpressionsVisitor(),
                new RenameVariablesVisitor(vng),
                new LocalVariableDeduper(LibraryWriter.LibrarySetWriter.TypeToCSharpConverter)
            );

            // Skip CqlContext
            var parameters = overload.Parameters.Skip(1);

            overload = Expression.Lambda(visitedBody, parameters);

            if (isDef)
            {
                IndentedTextWriter.WriteLine($"[CqlDeclaration({CqlName.QuoteString()})]");
                WriteTags();

                if (overload.ReturnType == typeof(CqlValueSet))
                {
                    if (overload.Body is NewExpression @new)
                    {
                        var arg = @new.Arguments[0];
                        if (arg is ConstantExpression { Value: string valueSetId })
                        {
                            IndentedTextWriter.WriteLine($"[CqlValueSet({valueSetId.QuoteString()})]");
                        }
                    }
                }
            }

            var definitionToCSharpCodeProcessor = new LibraryDefinitionToCSharpCodeProcessor(tupleMetadataBuilder, libraryName, LibraryWriter.LibrarySetWriter.TypeToCSharpConverter, IndentedTextWriter.Indent);
            var definition = definitionToCSharpCodeProcessor.ProcessDefinition(overload, MethodName, "public");
            IndentedTextWriter.WriteLine(definition);
        }

        private void WriteTags()
        {
            if (Tags == null)
                return;

            foreach (var group in Tags)
            {
                foreach (var tag in group)
                {
                    IndentedTextWriter.WriteLine($"[CqlTag({group.Key.QuoteString()}, {tag.QuoteString()})]");
                }
            }
        }

        private static bool IsDefinition(LambdaExpression overload) =>
            overload.Parameters.Count == 1
            && overload.Parameters[0].Type == typeof(CqlContext);

        private static Expression Transform(Expression body, params ExpressionVisitor[] visitors)
        {
            foreach (var visitor in visitors) body = visitor.Visit(body);
            return body;
        }
    }

    #endregion Nested Types
}