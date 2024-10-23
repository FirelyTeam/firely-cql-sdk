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

namespace Hl7.Cql.CodeGeneration.NET
{
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
            _version = GetType().Assembly.GetName().Version?.ToString() ?? "1.0.0";
            _tool = GetType()
                       .Assembly.GetCustomAttributes(false)
                       .OfType<AssemblyProductAttribute>()
                       .SingleOrDefault()?
                       .Product
                   ?? "ELM-to-CSharp";
            _aliasedUsings = BuildAliasedUsings(typeResolver);
        }

        private static List<(string, string)> BuildAliasedUsings(TypeResolver typeResolver) =>
            typeResolver.Aliases.ToList();

        private static HashSet<string> BuildUsings(TypeResolver typeResolver)
        {
            var hashSet = new HashSet<string>
            {
                nameof(System),
                typeof(Enumerable).Namespace!, // System.Linq
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
        /// Gets or sets the namespace for generated .NET types.
        /// </summary>
        private string? Namespace { get; }

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
        private readonly string _version;

        /// <summary>
        /// Gets the product of this <see cref="CSharpLibrarySetToStreamsWriter"/> as will appear in the <see cref="System.CodeDom.Compiler.GeneratedCodeAttribute.Tool"/>.
        /// </summary>
        private readonly string _tool;

        private record LibrarySetContext(
            LibrarySet LibrarySet,
            DefinitionDictionary<LambdaExpression> Definitions,
            CSharpSourceCodeWriterCallbacks Callbacks);

        private record LibraryContext(
            LibrarySetContext LibrarySetContext,
            Library Library,
            StreamWriter Writer,
            int Indent = 0)
        {
            public TupleMetadataBuilder TupleMetadataBuilder { get; init; } = new();

            public VersionedIdentifier LibraryVersionedIdentifier =>
                ((IGetVersionedIdentifier)Library).VersionedIdentifier.Result!;

            public string LibraryName => Library.GetVersionedIdentifier()!;
        }

        private record MethodContext(
            LibraryContext LibraryContext,
            string CqlName,
            LambdaExpression Overload,
            ILookup<string, string>? Tags);

        /// <summary>
        /// Writes C# source code from inputs.
        /// </summary>
        /// <param name="librarySet">A dependency graph containing dependent libraries.</param>
        /// <param name="definitions">The lambda expressions to write.</param>
        /// <param name="callbacks">Callbacks which is used during the processing of each stream.</param>
        public void ProcessDefinitions(
            LibrarySet librarySet,
            DefinitionDictionary<LambdaExpression> definitions,
            CSharpSourceCodeWriterCallbacks? callbacks = default)
        {
            List<Stream> streamsToDispose = new();
            callbacks ??= new();
            try
            {
                var librarySetContext = new LibrarySetContext(librarySet, definitions, callbacks);
                foreach (var (name, stream) in WriteLibraries(librarySetContext))
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

        private IEnumerable<(string name, Stream stream)> WriteLibraries(
            LibrarySetContext librarySetContext)
        {
            if (!librarySetContext.LibrarySet.Any())
            {
                _logger.LogInformation($"No libraries detected; skipping.");
                yield break;
            }

            foreach (Library library in librarySetContext.LibrarySet)
            {
                string libraryName = library.GetVersionedIdentifier()!;
                if (!librarySetContext.Callbacks.ShouldWriteLibrary(libraryName))
                {
                    _logger.LogInformation($"Skipping library {libraryName} as per callback.");
                    continue;
                }

                if (!librarySetContext.Definitions.Libraries.Contains(libraryName))
                {
                    _logger.LogInformation($"Skipping library {libraryName}, which has no definitions");
                    continue;
                }

                var stream = librarySetContext.Callbacks.GetStreamForLibraryName(libraryName);
                if (stream == null!)
                    continue;

                using var writer = new StreamWriter(stream, Encoding.UTF8, 1024, leaveOpen: true);
                var libraryContext = new LibraryContext(librarySetContext, library, writer);
                WriteNamespaceBlock(libraryContext);
                writer.Flush();
                yield return (libraryName, stream);
            }
        }

        private void WriteNamespaceBlock(
            LibraryContext libraryContext)
        {
            WriteUsings(libraryContext);

            // Namespace
            if (!string.IsNullOrWhiteSpace(Namespace))
                libraryContext.Writer.WriteLine($"namespace {Namespace};");

            libraryContext.Writer.WriteLine();
            WriteClass(libraryContext);
        }

        private void WriteClass(
            LibraryContext libraryContext)
        {
            var libraryName = libraryContext.LibraryName;
            var writer = libraryContext.Writer;
            writer.WriteLine(libraryContext.Indent, $"[System.CodeDom.Compiler.GeneratedCode({_tool.QuoteString()}, {_version.QuoteString()})]");

            var libraryAttribute = libraryName;
            var versionAttribute = string.Empty;
            var versionedIdentifier = libraryName.Split('-');
            if (versionedIdentifier.Length == 2)
            {
                if (Version.TryParse(versionedIdentifier[1], out _))
                {
                    libraryAttribute = versionedIdentifier[0];
                    versionAttribute = versionedIdentifier[1];
                }
            }

            writer.WriteLine(libraryContext.Indent, $"[CqlLibrary({libraryAttribute.QuoteString()}, {versionAttribute.QuoteString()})]");
            var className = VariableNameGenerator.NormalizeIdentifier(libraryName);
            writer.WriteLine(libraryContext.Indent, $"public partial class {className} : ILibrary, ISingleton<{className}>");
            writer.WriteLine(libraryContext.Indent, "{");
            // Class
            {
                var newLibraryContext = libraryContext with { Indent = libraryContext.Indent + 1 };
                writer.WriteLine(newLibraryContext.Indent, $"private {className}() {{}}");
                writer.WriteLine();
                writer.WriteLine(newLibraryContext.Indent, $"public static {className} Instance {{ get; }} = new();");
                writer.WriteLine();
                WriteLibraryMembers(newLibraryContext);
                WriteMethods(newLibraryContext);
                WriteCqlTupleMetadataProperties(newLibraryContext);
            }
            writer.WriteLine(libraryContext.Indent, "}");
        }

        private void WriteCqlTupleMetadataProperties(
            LibraryContext newLibraryContext)
        {
            var writer = newLibraryContext.Writer;
            var indentLevel = newLibraryContext.Indent;
            var tupleMetadataBuilder = newLibraryContext.TupleMetadataBuilder;

            // Cql Tuple Metadata
            foreach (var (propertyName, signature) in tupleMetadataBuilder.GetAllTupleMetadataPropertySignatures())
            {
                var types = string.Join(", ", signature.Select(t => $"typeof({_typeToCSharpConverter.ToCSharp(t.Type)})"));
                var names = string.Join(", ", signature.Select(t => t.PropName.QuoteString()));
                writer.WriteLine(indentLevel, $"private static CqlTupleMetadata {propertyName} = new(");
                writer.WriteLine(indentLevel+1, $"[{types}],");
                writer.WriteLine(indentLevel+1, $"[{names}]);");
                writer.WriteLine();
            }
        }

        private void WriteLibraryMembers(
            LibraryContext libraryContext)
        {
            var writer = libraryContext.Writer;
            var librarySet = libraryContext.LibrarySetContext.LibrarySet;
            var libraryName = libraryContext.LibraryName;
            var libraryVersionedIdentifier = libraryContext.LibraryVersionedIdentifier;
            var libraryNameToClassName = libraryContext.LibrarySetContext.Callbacks.LibraryNameToClassName!;
            var indent = libraryContext.Indent;

            writer.WriteLine(indent, "#region Library Members");
            writer.WriteLine(indent, $"public string Name => {libraryVersionedIdentifier.id.QuoteString()};");
            writer.WriteLine(indent, $"public string Version => {libraryVersionedIdentifier.version.QuoteString()};");

            var dependencies =
                librarySet.GetLibraryDependencies(libraryName, throwError: true)
                          .Select(dep => libraryNameToClassName(dep.GetVersionedIdentifier()!))
                          .Select(typeName => $"{typeName}.Instance");

            writer.WriteLine(indent, $"public ILibrary[] Dependencies => [{string.Join(", ", dependencies)}];");


            writer.WriteLine(indent, "#endregion Library Members");
        }

        private void WriteMethods(
            LibraryContext libraryContext)
        {
            var definitions = libraryContext.LibrarySetContext.Definitions;
            var libraryName = libraryContext.LibraryName;
            var writer = libraryContext.Writer;

            foreach (var kvp in definitions.DefinitionsForLibrary(libraryName))
            {
                foreach (var overload in kvp.Value)
                {
                    definitions.TryGetTags(libraryName, kvp.Key, overload.Signature, out var tags);
                    WriteMethod(new MethodContext(libraryContext, kvp.Key, overload.T, tags));
                    writer.WriteLine();
                }
            }
        }

        private static bool IsDefinition(LambdaExpression overload) =>
            overload.Parameters.Count == 1
                && overload.Parameters[0].Type == typeof(CqlContext);

        private void WriteMethod(
            MethodContext methodContext)
        {
            string libraryName = methodContext.LibraryContext.LibraryName;
            TextWriter writer = methodContext.LibraryContext.Writer;
            int indentLevel = methodContext.LibraryContext.Indent;
            string cqlName = methodContext.CqlName;
            LambdaExpression overload = methodContext.Overload;
            TupleMetadataBuilder tupleMetadataBuilder = methodContext.LibraryContext.TupleMetadataBuilder;

            var methodName = VariableNameGenerator.NormalizeIdentifier(cqlName);
            var isDef = IsDefinition(overload);

            var vng = new VariableNameGenerator(Enumerable.Empty<string>(), postfix: "_");

            var visitedBody = Transform(
                overload.Body,
                new RedundantCastsTransformer(),
                new SimplifyExpressionsVisitor(),
                new RenameVariablesVisitor(vng),
                new LocalVariableDeduper(_typeToCSharpConverter)
            );

            var expressionConverter = NewExpressionToCSharpConverter(libraryName);

            // Skip CqlContext
            var parameters = overload.Parameters.Skip(1);

            overload = Expression.Lambda(visitedBody, parameters);

            if (isDef)
            {
                writer.WriteLine();
                writer.WriteLine(indentLevel, $"[CqlDeclaration({cqlName.QuoteString()})]");
                WriteTags(methodContext);

                if (overload.ReturnType == typeof(CqlValueSet))
                {
                    if (overload.Body is NewExpression @new)
                    {
                        var arg = @new.Arguments[0];
                        if (arg is ConstantExpression { Value: string valueSetId })
                        {
                            writer.WriteLine(indentLevel, $"[CqlValueSet({valueSetId.QuoteString()})]");
                        }
                    }
                }
            }

            writer.Write(expressionConverter.ConvertTopLevelFunctionDefinition(overload, expressionConverter.NewContext(tupleMetadataBuilder, indentLevel), methodName!, "public"));
        }

        private ExpressionToCSharpConverter NewExpressionToCSharpConverter(string libraryName) =>
            new(_typeToCSharpConverter, libraryName);

        private void WriteTags(
            MethodContext methodContext)
        {
            if (methodContext.Tags != null)
            {
                TextWriter writer = methodContext.LibraryContext.Writer;
                int indentLevel = methodContext.LibraryContext.Indent;

                foreach (var group in methodContext.Tags)
                {
                    foreach (var tag in group)
                    {
                        writer.WriteLine(indentLevel, $"[CqlTag({group.Key.QuoteString()}, {tag.QuoteString()})]");
                    }
                }
            }
        }

        private void WriteUsings(LibraryContext context)
        {
            foreach (var @using in _usings)
            {
                context.Writer.WriteLine($"using {@using};");
            }
            foreach (var @using in _aliasedUsings)
            {
                context.Writer.WriteLine($"using {@using.Item1} = {@using.Item2};");
            }
        }

        private static Expression Transform(Expression body, params ExpressionVisitor[] visitors)
        {
            foreach (var visitor in visitors)
            {
                body = visitor.Visit(body);
            }

            return body;
        }
    }
}