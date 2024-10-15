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
using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.Compiler;
using Hl7.Cql.Elm;
using Hl7.Cql.Operators;
using Microsoft.CodeAnalysis.CSharp;
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


        /// <summary>
        /// Writes C# source code from inputs.
        /// </summary>
        /// <param name="definitions">The lambda expressions to write.</param>
        /// <param name="librarySet">A dependency graph containing dependent libraries.</param>
        /// <param name="callbacks">Callbacks which is used during the processing of each stream.</param>
        public void ProcessDefinitions(
            DefinitionDictionary<LambdaExpression> definitions,
            LibrarySet librarySet,
            CSharpSourceCodeWriterCallbacks? callbacks = default)
        {
            List<Stream> streamsToDispose = new();
            callbacks ??= new();
            try
            {
                foreach (var (name, stream) in WriteLibraries(definitions, librarySet, callbacks))
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
            DefinitionDictionary<LambdaExpression> definitions,
            LibrarySet librarySet,
            CSharpSourceCodeWriterCallbacks callbacks)
        {
            if (!librarySet.Any())
            {
                _logger.LogInformation($"No libraries detected; skipping.");
                yield break;
            }

            foreach (Library library in librarySet)
            {
                var libraryVersionedIdentifier = ((IGetVersionedIdentifier)library).VersionedIdentifier.Result!;
                string libraryName = library.GetVersionedIdentifier()!;
                if (!callbacks.ShouldWriteLibrary(libraryName))
                {
                    _logger.LogInformation($"Skipping library {libraryName} as per callback.");
                    continue;
                }

                if (!definitions.Libraries.Contains(libraryName))
                {
                    _logger.LogInformation($"Skipping library {libraryName}, which has no definitions");
                    continue;
                }

                var stream = callbacks.GetStreamForLibraryName(libraryName);
                if (stream == null!)
                    continue;

                using var writer = new StreamWriter(stream, Encoding.UTF8, 1024, leaveOpen: true);
                int indentLevel = 0;
                WriteUsings(writer);

                // Namespace
                if (!string.IsNullOrWhiteSpace(Namespace))
                {
                    writer.WriteLine(indentLevel, $"namespace {Namespace}");
                    writer.WriteLine(indentLevel, "{");
                    writer.WriteLine();
                    indentLevel += 1;
                }

                WriteClass(definitions, librarySet, callbacks.LibraryNameToClassName, libraryName, libraryVersionedIdentifier, writer, indentLevel);

                if (!string.IsNullOrWhiteSpace(Namespace))
                {
                    writer.WriteLine(indentLevel, "}");
                }

                writer.Flush();
                yield return (libraryName, stream);
            }
        }

        private void WriteClass(
            DefinitionDictionary<LambdaExpression> definitions,
            LibrarySet librarySet,
            Func<string, string?> libraryNameToClassName,
            string libraryName,
            VersionedIdentifier libraryVersionedIdentifier,
            StreamWriter writer,
            int indentLevel)
        {
            var tupleMetadataBuilder = new TupleMetadataBuilder();

            writer.WriteLine(indentLevel, $"[System.CodeDom.Compiler.GeneratedCode({_tool.QuoteString()}, {_version.QuoteString()})]");

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

            writer.WriteLine(indentLevel, $"[CqlLibrary({libraryAttribute.QuoteString()}, {versionAttribute.QuoteString()})]");
            var className = VariableNameGenerator.NormalizeIdentifier(libraryName);
            writer.WriteLine(indentLevel, $"public partial class {className} : ILibrary, ISingleton<{className}>");
            writer.WriteLine(indentLevel, "{");
            indentLevel += 1;
            // Class
            {
                writer.WriteLine(indentLevel, $"private {className}() {{}}");
                writer.WriteLine();
                writer.WriteLine(indentLevel, $"public static {className} Instance {{ get; }} = new();");
                writer.WriteLine();
                WriteLibraryMembers(writer, librarySet, libraryName, libraryVersionedIdentifier, libraryNameToClassName!, indentLevel);
                WriteMethods(definitions, libraryName, writer, indentLevel, tupleMetadataBuilder);
                WriteCqlTupleMetadataProperties(writer, indentLevel, tupleMetadataBuilder);
            }
            indentLevel -= 1;
            writer.WriteLine(indentLevel, "}");
        }

        private void WriteCqlTupleMetadataProperties(
            StreamWriter writer,
            int indentLevel,
            TupleMetadataBuilder tupleMetadataBuilder)
        {
            // Cql Tuple Metadata
            foreach (var (propertyName, signature) in tupleMetadataBuilder.GetAllTupleMetadataPropertySignatures())
            {
                var types = string.Join(", ", signature.Select(t => $"typeof({_typeToCSharpConverter.ToCSharp(t.Type)})"));
                var names = string.Join(", ", signature.Select(t => t.Name.QuoteString()));
                writer.WriteLine(indentLevel, $"private static CqlTupleMetadata {propertyName} = new([{types}], [{names}]);");
            }
        }

        private void WriteLibraryMembers(
            TextWriter writer,
            LibrarySet librarySet,
            string libraryName,
            VersionedIdentifier libraryVersionedIdentifier,
            Func<string, string> libraryNameToClassName,
            int indent)
        {
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
            DefinitionDictionary<LambdaExpression> definitions,
            string libraryName,
            StreamWriter writer,
            int indentLevel,
            TupleMetadataBuilder tupleMetadataBuilder)
        {
            foreach (var kvp in definitions.DefinitionsForLibrary(libraryName))
            {
                foreach (var overload in kvp.Value)
                {
                    definitions.TryGetTags(libraryName, kvp.Key, overload.Signature, out var tags);
                    WriteMethod(libraryName, writer, indentLevel, kvp.Key, overload.T, tags, tupleMetadataBuilder);
                    writer.WriteLine();
                }
            }
        }

        private static bool IsDefinition(LambdaExpression overload) =>
            overload.Parameters.Count == 1
                && overload.Parameters[0].Type == typeof(CqlContext);

        private string DefinitionCacheKeyForMethod(string methodName)
        {
            if (methodName[0] == '@')
                return "__" + methodName[1..];
            else return "__" + methodName;
        }

        private void WriteMethod(
            string libraryName,
            TextWriter writer,
            int indentLevel,
            string cqlName,
            LambdaExpression overload,
            ILookup<string, string>? tags,
            TupleMetadataBuilder tupleMetadataBuilder)
        {
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
                WriteTags(writer, indentLevel, tags);

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

        private void WriteTags(TextWriter writer, int indentLevel, ILookup<string, string>? tags)
        {
            if (tags != null)
            {
                foreach (var group in tags)
                {
                    foreach (var tag in group)
                    {
                        writer.WriteLine(indentLevel, $"[CqlTag({group.Key.QuoteString()}, {tag.QuoteString()})]");
                    }
                }
            }
        }

        private void WriteUsings(TextWriter writer)
        {
            foreach (var @using in _usings)
            {
                writer.WriteLine($"using {@using};");
            }
            foreach (var @using in _aliasedUsings)
            {
                writer.WriteLine($"using {@using.Item1} = {@using.Item2};");
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