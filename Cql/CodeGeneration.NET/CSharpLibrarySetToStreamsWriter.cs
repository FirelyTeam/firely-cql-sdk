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
using static Hl7.Cql.CodeGeneration.NET.AssemblyCompiler;

namespace Hl7.Cql.CodeGeneration.NET;

/// <summary>
/// Writes <see cref="LambdaExpression"/>s as members of a .NET class.
/// </summary>
internal class CSharpLibrarySetToStreamsWriter
{
    private readonly ILogger<CSharpLibrarySetToStreamsWriter> _logger;
    private readonly TypeToCSharpConverter _typeToCSharpConverter;

    public CSharpLibrarySetToStreamsWriter(
        ILogger<CSharpLibrarySetToStreamsWriter> logger,
        TypeResolver typeResolver,
        TypeToCSharpConverter typeToCSharpConverter)
    {
        _logger = logger;
        _typeToCSharpConverter = typeToCSharpConverter;
        _usings = BuildUsings(typeResolver);
        var thisAssembly = GetType().Assembly;
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
    private readonly IList<(string, string)> _aliasedUsings;

    /// <summary>
    /// Gets the version of this <see cref="CSharpLibrarySetToStreamsWriter"/> as will appear in the <see cref="System.CodeDom.Compiler.GeneratedCodeAttribute.Version"/>.
    /// </summary>
    private readonly string _generatorToolVersion;

    /// <summary>
    /// Gets the product of this <see cref="CSharpLibrarySetToStreamsWriter"/> as will appear in the <see cref="System.CodeDom.Compiler.GeneratedCodeAttribute.Tool"/>.
    /// </summary>
    private readonly string _generatorToolName;

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
            foreach (var (name, stream) in new LibrarySetContext(this, librarySet, definitions, callbacks).WriteLibraries())
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

    private record LibrarySetContext(
        CSharpLibrarySetToStreamsWriter CSharpLibrarySetToStreamsWriter,
        LibrarySet LibrarySet,
        DefinitionDictionary<LambdaExpression> Definitions,
        CSharpSourceCodeWriterCallbacks Callbacks)
    {
        public TupleMetadataBuilder TupleMetadataBuilder { get; } = new();
        public string GeneratorToolName => CSharpLibrarySetToStreamsWriter._generatorToolName;
        public string GeneratorToolVersion => CSharpLibrarySetToStreamsWriter._generatorToolVersion;
        public TypeToCSharpConverter TypeToCSharpConverter => CSharpLibrarySetToStreamsWriter._typeToCSharpConverter;
        public IList<(string, string)> AliasedUsings => CSharpLibrarySetToStreamsWriter._aliasedUsings;
        public HashSet<string> Usings => CSharpLibrarySetToStreamsWriter._usings;
        public string? Namespace => null;
        private ILogger Logger => CSharpLibrarySetToStreamsWriter._logger;

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

                using var writer = new StreamWriter(stream, Encoding.UTF8, 1024, leaveOpen: true);
                bool errored = false;
                try
                {
                    new LibraryContext(this, library, new Writer(writer)).WriteLibraryFile();
                }
                catch (Exception e)
                {
                    errored = true;
                    if (Callbacks.ShouldThrowException?.Invoke(new CompileError(this, e, library)) ?? true)
                        throw;
                }
                writer.Flush();
                if (!errored)
                    yield return (libraryName, stream);
            }
        }
    }

    private record Writer(StreamWriter StreamWriter, int Indent = 0) : ICloneIndent<Writer>
    {
        public void WriteLine(int addIndent, string text = "") => StreamWriter.WriteLine(Indent + addIndent, text);

        public void WriteLine(string text = "") => WriteLine(0, text);

        public Writer AddIndent(int addIndent = 1)
        {
            return this with { Indent = Indent + addIndent };
        }
    }

    private record LibraryContext(
        LibrarySetContext LibrarySetContext,
        Library Library,
        Writer Writer) : ICloneIndent<LibraryContext>
    {
        private VersionedIdentifier LibraryVersionedIdentifier => ((IGetVersionedIdentifier)Library).VersionedIdentifier.Result!;
        public string LibraryName { get; } = Library.GetVersionedIdentifier()!;
        private string ClassName { get; } = VariableNameGenerator.NormalizeIdentifier(Library.GetVersionedIdentifier()!)!;

        public LibraryContext AddIndent(int addIndent = 1)
        {
            return this with { Writer = Writer.AddIndent(addIndent) };
        }

        public void WriteLibraryFile()
        {
            WriteUsings();
            WriteNamespaceFileScope();
            WriteClass();
        }

        private void WriteCqlTupleMetadataProperties()
        {
            var tupleMetadataBuilder = LibrarySetContext.TupleMetadataBuilder;

            // Cql Tuple Metadata
            foreach (var (propertyName, signature) in tupleMetadataBuilder.GetAllTupleMetadataPropertySignatures())
            {
                var types = string.Join(", ", signature.Select(t => $"typeof({LibrarySetContext.TypeToCSharpConverter.ToCSharp(t.Type)})"));
                var names = string.Join(", ", signature.Select(t => t.PropName.QuoteString()));
                Writer.WriteLine($"private static CqlTupleMetadata {propertyName} = new(");
                Writer.WriteLine(1, $"[{types}],");
                Writer.WriteLine(1, $"[{names}]);");
                Writer.WriteLine();
            }
        }

        private void WriteLibraryMembers()
        {
            var librarySet = LibrarySetContext.LibrarySet;
            var libraryName = LibraryName;
            var libraryVersionedIdentifier = LibraryVersionedIdentifier;
            var libraryNameToClassName = LibrarySetContext.Callbacks.LibraryNameToClassName;

            Writer.WriteLine("#region Library Members");
            Writer.WriteLine($"string ILibrary.Name => {libraryVersionedIdentifier.id.QuoteString()};");
            Writer.WriteLine($"string ILibrary.Version => {libraryVersionedIdentifier.version.QuoteString()};");

            var dependencies =
                librarySet.GetLibraryDependencies(libraryName, throwError: true)
                          .Select(dep => libraryNameToClassName(dep.GetVersionedIdentifier()!))
                          .Select(typeName => $"{typeName}.Instance");

            Writer.WriteLine($"IReadOnlyList<ILibrary> ILibrary.Dependencies => [{string.Join(", ", dependencies)}];");


            Writer.WriteLine("#endregion Library Members");
        }

        private void WriteUsings()
        {
            foreach (var @using in LibrarySetContext.Usings)
                Writer.WriteLine($"using {@using};");

            foreach (var @using in LibrarySetContext.AliasedUsings)
                Writer.WriteLine($"using {@using.Item1} = {@using.Item2};");

            Writer.WriteLine();
        }

        private void WriteNamespaceFileScope()
        {
            if (LibrarySetContext.Namespace is { Length: > 0 } @namespace)
            {
                Writer.WriteLine($"namespace {@namespace};");
                Writer.WriteLine();
            }
        }

        private void WriteMethods()
        {
            var definitions = LibrarySetContext.Definitions;
            var libraryName = LibraryName;

            foreach (var kvp in definitions.DefinitionsForLibrary(libraryName))
            {
                foreach (var overload in kvp.Value)
                {
                    definitions.TryGetTags(libraryName, kvp.Key, overload.Signature, out var tags);
                    new MethodContext(this, kvp.Key, overload.T, tags).WriteMethod();
                }
            }
        }

        private void WriteClass()
        {
            Writer.WriteLine($"[System.CodeDom.Compiler.GeneratedCode({LibrarySetContext.GeneratorToolName.QuoteString()}, {LibrarySetContext.GeneratorToolVersion.QuoteString()})]");

            Writer.WriteLine(
                LibraryVersionedIdentifier.version is { } version && Version.TryParse(version, out _)
                    ? $"[CqlLibrary({LibraryVersionedIdentifier.id.QuoteString()}, {version.QuoteString()})]"
                    : $"[CqlLibrary({LibraryVersionedIdentifier.id.QuoteString()})]");

            Writer.WriteLine($"public partial class {ClassName} : ILibrary, ISingleton<{ClassName}>");
            Writer.WriteLine("{");
            {
                var classBlockContext = AddIndent();
                classBlockContext.Writer.WriteLine($"private {ClassName}() {{}}");
                classBlockContext.Writer.WriteLine();
                classBlockContext.Writer.WriteLine($"public static {ClassName} Instance {{ get; }} = new();");
                classBlockContext.Writer.WriteLine();
                classBlockContext.WriteLibraryMembers();
                classBlockContext.WriteMethods();
                classBlockContext.WriteCqlTupleMetadataProperties();
            }
            Writer.WriteLine("}");
        }
    }

    private record MethodContext(
        LibraryContext LibraryContext,
        string CqlName,
        LambdaExpression Overload,
        ILookup<string, string>? Tags) : ICloneIndent<MethodContext>
    {
        private string MethodName { get; } = VariableNameGenerator.NormalizeIdentifier(CqlName)!;

        public MethodContext AddIndent(int addIndent = 1)
        {
            return this with { LibraryContext = LibraryContext.AddIndent(addIndent) };
        }

        private Writer Writer => LibraryContext.Writer;

        public void WriteMethod()
        {
            string libraryName = LibraryContext.LibraryName;
            LambdaExpression overload = Overload;
            TupleMetadataBuilder tupleMetadataBuilder = LibraryContext.LibrarySetContext.TupleMetadataBuilder;
            var isDef = IsDefinition(overload);

            var vng = new VariableNameGenerator(Enumerable.Empty<string>(), postfix: "_");

            var visitedBody = Transform(
                overload.Body,
                new RedundantCastsTransformer(),
                new SimplifyExpressionsVisitor(),
                new RenameVariablesVisitor(vng),
                new LocalVariableDeduper(LibraryContext.LibrarySetContext.TypeToCSharpConverter)
            );

            var expressionConverter = new ExpressionToCSharpConverter(LibraryContext.LibrarySetContext.TypeToCSharpConverter, libraryName);

            // Skip CqlContext
            var parameters = overload.Parameters.Skip(1);

            overload = Expression.Lambda(visitedBody, parameters);

            if (isDef)
            {
                Writer.WriteLine();
                Writer.WriteLine($"[CqlDeclaration({CqlName.QuoteString()})]");
                WriteTags();

                if (overload.ReturnType == typeof(CqlValueSet))
                {
                    if (overload.Body is NewExpression @new)
                    {
                        var arg = @new.Arguments[0];
                        if (arg is ConstantExpression { Value: string valueSetId })
                        {
                            Writer.WriteLine($"[CqlValueSet({valueSetId.QuoteString()})]");
                        }
                    }
                }
            }

            var topLevelFunctionContext = expressionConverter.NewContext(tupleMetadataBuilder, Writer.Indent);
            var topLevelFunction = expressionConverter.ConvertTopLevelFunctionDefinition(overload, topLevelFunctionContext, MethodName, "public");
            Writer.WriteLine(topLevelFunction);
            Writer.WriteLine();
        }

        private void WriteTags()
        {
            if (Tags == null)
                return;

            foreach (var group in Tags)
            {
                foreach (var tag in group)
                {
                    Writer.WriteLine($"[CqlTag({group.Key.QuoteString()}, {tag.QuoteString()})]");
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
}

file interface ICloneIndent<out TSelf>
{
    TSelf AddIndent(int addIndent = 1);
}