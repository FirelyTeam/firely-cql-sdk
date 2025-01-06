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
using Hl7.Cql.Compiler;
using Hl7.Cql.Elm;
using Hl7.Cql.Operators;
using Expression = System.Linq.Expressions.Expression;

namespace Hl7.Cql.CodeGeneration.NET;

/// <summary>
/// Processes a definition dictionary of <see cref="LambdaExpression"/> into a .NET classes per library.
/// </summary>
internal class DefinitionsToCSharpCodeProcessor
{
    private readonly ILogger<DefinitionsToCSharpCodeProcessor> _logger;

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
    /// Gets the version of this <see cref="DefinitionsToCSharpCodeProcessor"/> as will appear in the <see cref="System.CodeDom.Compiler.GeneratedCodeAttribute.Version"/>.
    /// </summary>
    private readonly string _generatorToolVersion;

    /// <summary>
    /// Gets the product of this <see cref="DefinitionsToCSharpCodeProcessor"/> as will appear in the <see cref="System.CodeDom.Compiler.GeneratedCodeAttribute.Tool"/>.
    /// </summary>
    private readonly string _generatorToolName;

    public DefinitionsToCSharpCodeProcessor(
        ILogger<DefinitionsToCSharpCodeProcessor> logger,
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

    /// <summary>
    /// Writes C# source code from inputs.
    /// </summary>
    /// <param name="librarySet">A dependency graph containing dependent libraries.</param>
    /// <param name="definitions">The lambda expressions to write.</param>
    /// <param name="callbacks">Callbacks which is used during the processing of each stream.</param>
    public void ProcessDefinitions(
        LibrarySet librarySet,
        DefinitionDictionary<LambdaExpression> definitions,
        CSharpSourceCodeWriterCallbacks? callbacks = null)
    {
        List<Stream> streamsToDispose = new();
        callbacks ??= new();
        try
        {
            var librarySetWriter = new LibrarySetWriter(this, librarySet, definitions, callbacks);
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

    private record IndentedWriter(StreamWriter StreamWriter, int Indent = 0) : IIndentMutator<IndentedWriter>
    {
        public void WriteLine(int addIndent, string text = "") => StreamWriter.WriteLine(Indent + addIndent, text);

        public void WriteLine(string text = "") => WriteLine(0, text);

        public IndentedWriter AddIndent(int addIndent = 1)
        {
            return this with { Indent = Indent + addIndent };
        }

        private StreamWriter StreamWriter { get; } = StreamWriter;

        public int Indent { get; private init; } = Indent;
    }

    private record LibrarySetWriter(
        DefinitionsToCSharpCodeProcessor Processor,
        LibrarySet LibrarySet,
        DefinitionDictionary<LambdaExpression> Definitions,
        CSharpSourceCodeWriterCallbacks Callbacks)
    {
        public TupleMetadataBuilder TupleMetadataBuilder => Processor._tupleMetadataBuilder;
        public string GeneratorToolName => Processor._generatorToolName;
        public string GeneratorToolVersion => Processor._generatorToolVersion;
        public TypeToCSharpConverter TypeToCSharpConverter => Processor._typeToCSharpConverter;
        public IReadOnlyList<(string alias, string type)> AliasedUsings => Processor._aliasedUsings;
        public HashSet<string> Usings => Processor._usings;
        public string? Namespace => null;
        public ILogger<DefinitionsToCSharpCodeProcessor> Logger => Processor._logger;

        public IEnumerable<(string name, Stream stream)> WriteLibraries()
        {
            if (!LibrarySet.Any())
            {
                Logger.LogInformation($"No libraries detected; skipping.");
                yield break;
            }

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

                if (WriteLibrary(library, stream))
                    yield return (libraryName, stream);
            }
        }

        private bool WriteLibrary(Library library, Stream stream)
        {
            using var writer = new StreamWriter(stream, Encoding.UTF8, 1024, leaveOpen: true);
            bool faulted = false;
            try
            {
                var libraryWriter = new LibraryWriter(this, library, writer);
                libraryWriter.WriteLibraryFile();
            }
            catch (Exception e)
            {
                faulted = true;
                if (Callbacks.ShouldThrowException is not { } shouldThrow
                    || shouldThrow(new CSharpSourceCodeWriterCallbacks.WriteLibraryExceptionContext(this, e, library)))
                    throw;
            }
            writer.Flush();
            return !faulted;
        }
    }

    private record LibraryWriter(
        LibrarySetWriter LibrarySetWriter,
        Library Library,
        IndentedWriter IndentedWriter) : IIndentMutator<LibraryWriter>
    {
        public LibraryWriter(
            LibrarySetWriter librarySetWriter,
            Library library,
            StreamWriter streamWriter,
            int indent = 0) : this(librarySetWriter, library, new IndentedWriter(streamWriter, indent)) {}

        private VersionedIdentifier LibraryVersionedIdentifier => ((IGetVersionedIdentifier)Library).VersionedIdentifier.Result!;
        public string LibraryName { get; } = Library.GetVersionedIdentifier()!;
        private string ClassName { get; } = VariableNameGenerator.NormalizeIdentifier(Library.GetVersionedIdentifier()!)!;

        public LibraryWriter AddIndent(int addIndent = 1)
        {
            return this with { IndentedWriter = IndentedWriter.AddIndent(addIndent) };
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

            // Cql Tuple Metadata
            foreach (var (propertyName, signature) in tupleMetadataBuilder.GetAllTupleMetadataPropertySignatures())
            {
                var types = string.Join(", ", signature.Select(t => $"typeof({LibrarySetWriter.TypeToCSharpConverter.ToCSharp(t.Type)})"));
                var names = string.Join(", ", signature.Select(t => t.PropName.QuoteString()));
                IndentedWriter.WriteLine($"private static CqlTupleMetadata {propertyName} = new(");
                IndentedWriter.WriteLine(1, $"[{types}],");
                IndentedWriter.WriteLine(1, $"[{names}]);");
                IndentedWriter.WriteLine();
            }
        }

        private void WriteLibraryInterfaceImplementation()
        {
            var libraryNameToClassName = LibrarySetWriter.Callbacks.LibraryNameToClassName;
            IndentedWriter.WriteLine("#region Library Members");
            IndentedWriter.WriteLine($"string ILibrary.Name => {LibraryVersionedIdentifier.id.QuoteString()};");
            IndentedWriter.WriteLine($"string ILibrary.Version => {LibraryVersionedIdentifier.version.QuoteString()};");
            var dependencies =
                LibrarySetWriter.LibrarySet
                                .GetLibraryDependencies(LibraryName, throwError: true)
                                .Select(dep => libraryNameToClassName(dep.GetVersionedIdentifier()!))
                                .Select(typeName => $"{typeName}.Instance");
            IndentedWriter.WriteLine($"IReadOnlyList<ILibrary> ILibrary.Dependencies => [{string.Join(", ", dependencies)}];");
            IndentedWriter.WriteLine("#endregion Library Members");
        }

        private void WriteUsings()
        {
            foreach (var @using in LibrarySetWriter.Usings)
                IndentedWriter.WriteLine($"using {@using};");

            foreach (var @using in LibrarySetWriter.AliasedUsings)
                IndentedWriter.WriteLine($"using {@using.Item1} = {@using.Item2};");

            IndentedWriter.WriteLine();
        }

        private void WriteNamespaceFileScope()
        {
            if (LibrarySetWriter.Namespace is { Length: > 0 } @namespace)
            {
                IndentedWriter.WriteLine($"namespace {@namespace};");
                IndentedWriter.WriteLine();
            }
        }

        private void WriteMethods()
        {
            var definitions = LibrarySetWriter.Definitions;
            var libraryName = LibraryName;

            foreach (var (definition, overloads) in definitions.DefinitionsForLibrary(libraryName))
            {
                foreach (var (signature, expression) in overloads)
                {
                    definitions.TryGetTags(libraryName, definition, signature, out var tags);
                    var methodWriter = CreateMethodWriter(definition, expression, tags);
                    methodWriter.WriteMethod();
                }
            }
        }

        private MethodWriter CreateMethodWriter(string definition, LambdaExpression expression, ILookup<string, string>? tags)
        {
            return new MethodWriter(this, definition, expression, tags);
        }

        private void WriteClass()
        {
            IndentedWriter.WriteLine($"[System.CodeDom.Compiler.GeneratedCode({LibrarySetWriter.GeneratorToolName.QuoteString()}, {LibrarySetWriter.GeneratorToolVersion.QuoteString()})]");

            IndentedWriter.WriteLine(
                LibraryVersionedIdentifier.version is { } version && Version.TryParse(version, out _)
                    ? $"[CqlLibrary({LibraryVersionedIdentifier.id.QuoteString()}, {version.QuoteString()})]"
                    : $"[CqlLibrary({LibraryVersionedIdentifier.id.QuoteString()})]");

            IndentedWriter.WriteLine($"public partial class {ClassName} : ILibrary, ISingleton<{ClassName}>");
            IndentedWriter.WriteLine("{");
            {
                var classBlockContext = AddIndent();
                classBlockContext.WriteClassConstructor();
                classBlockContext.WriteSingletonInstanceProperty();
                classBlockContext.WriteLibraryInterfaceImplementation();
                classBlockContext.WriteMethods();
                classBlockContext.WriteCqlTupleMetadataProperties();
            }
            IndentedWriter.WriteLine("}");
        }

        private void WriteSingletonInstanceProperty()
        {
            IndentedWriter.WriteLine($"public static {ClassName} Instance {{ get; }} = new();");
            IndentedWriter.WriteLine();
        }

        private void WriteClassConstructor()
        {
            IndentedWriter.WriteLine($"private {ClassName}() {{}}");
            IndentedWriter.WriteLine();
        }
    }

    private record MethodWriter(
        LibraryWriter LibraryWriter,
        string CqlName,
        LambdaExpression Overload,
        ILookup<string, string>? Tags) : IIndentMutator<MethodWriter>
    {
        private string MethodName { get; } = VariableNameGenerator.NormalizeIdentifier(CqlName)!;

        public MethodWriter AddIndent(int addIndent = 1)
        {
            return this with { LibraryWriter = LibraryWriter.AddIndent(addIndent) };
        }

        private IndentedWriter IndentedWriter => LibraryWriter.IndentedWriter;

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

            var expressionConverter = new ExpressionToCSharpConverter(LibraryWriter.LibrarySetWriter.TypeToCSharpConverter, libraryName);

            // Skip CqlContext
            var parameters = overload.Parameters.Skip(1);

            overload = Expression.Lambda(visitedBody, parameters);

            if (isDef)
            {
                IndentedWriter.WriteLine();
                IndentedWriter.WriteLine($"[CqlDeclaration({CqlName.QuoteString()})]");
                WriteTags();

                if (overload.ReturnType == typeof(CqlValueSet))
                {
                    if (overload.Body is NewExpression @new)
                    {
                        var arg = @new.Arguments[0];
                        if (arg is ConstantExpression { Value: string valueSetId })
                        {
                            IndentedWriter.WriteLine($"[CqlValueSet({valueSetId.QuoteString()})]");
                        }
                    }
                }
            }

            var topLevelFunctionContext = expressionConverter.NewContext(tupleMetadataBuilder, IndentedWriter.Indent);
            var topLevelFunction = expressionConverter.ConvertTopLevelFunctionDefinition(overload, topLevelFunctionContext, MethodName, "public");
            IndentedWriter.WriteLine(topLevelFunction);
            IndentedWriter.WriteLine();
        }

        private void WriteTags()
        {
            if (Tags == null)
                return;

            foreach (var group in Tags)
            {
                foreach (var tag in group)
                {
                    IndentedWriter.WriteLine($"[CqlTag({group.Key.QuoteString()}, {tag.QuoteString()})]");
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

file interface IIndentMutator<out TSelf>
{
    TSelf AddIndent(int addIndent = 1);
}