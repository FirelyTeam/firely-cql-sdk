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
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using Hl7.Cql.Compiler;
using Hl7.Cql.Elm;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.Extensions.Options;
using Expression = System.Linq.Expressions.Expression;

namespace Hl7.Cql.CodeGeneration.NET
{
    /// <summary>
    /// Writes <see cref="LambdaExpression"/>s as members of a .NET class.
    /// </summary>
    internal class CSharpLibrarySetToStreamsWriter
    {
        private readonly ILogger<CSharpLibrarySetToStreamsWriter> _logger;
        private readonly IOptions<CSharpCodeWriterOptions> _options;
        private readonly TypeToCSharpConverter _typeToCSharpConverter;

        public CSharpLibrarySetToStreamsWriter(
            ILogger<CSharpLibrarySetToStreamsWriter> logger,
            IOptions<CSharpCodeWriterOptions> options,
            TypeResolver typeResolver,
            TypeToCSharpConverter typeToCSharpConverter)
        {
            _logger = logger;
            _typeToCSharpConverter = typeToCSharpConverter;
            _options = options;
            _contextAccessModifier = AccessModifier.Internal;
            _definesAccessModifier = AccessModifier.Internal;
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
        /// If <see langword="true"/>, classes will be declared with the <see langword="partial"/> keyword.
        /// </summary>
        private bool PartialClass { get; }

        /// <summary>
        /// The <see cref="AccessModifier"/> to use for the <see cref="CqlContext"/> class member; its default value is <see cref="AccessModifier.Internal"/>.
        /// </summary>
        private readonly AccessModifier _contextAccessModifier;

        /// <summary>
        /// The <see cref="AccessModifier"/> to use for all CQL defines; its default value is <see cref="AccessModifier.Internal"/>.
        /// </summary>
        private readonly AccessModifier _definesAccessModifier;

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

            foreach (var library in librarySet)
            {
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

                WriteClass(definitions, librarySet, callbacks.LibraryNameToClassName, libraryName, writer, indentLevel);

                if (!string.IsNullOrWhiteSpace(Namespace))
                {
                    writer.WriteLine(indentLevel, "}");
                }

                writer.Flush();
                yield return (libraryName, stream);
            }
        }

        private void WriteClass(DefinitionDictionary<LambdaExpression> definitions,
            LibrarySet librarySet,
            Func<string, string?> libraryNameToClassName,
            string libraryName,
            StreamWriter writer,
            int indentLevel)
        {
            writer.WriteLine(indentLevel, $"[System.CodeDom.Compiler.GeneratedCode({QuoteString(_tool)}, {QuoteString(_version)})]");

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

            writer.WriteLine(indentLevel, $"[CqlLibrary({QuoteString(libraryAttribute)}, {QuoteString(versionAttribute)})]");
            var className = VariableNameGenerator.NormalizeIdentifier(libraryName);
            if (PartialClass)
                writer.WriteLine(indentLevel, $"partial class {className}");
            else
                writer.WriteLine(indentLevel, $"public class {className}");
            writer.WriteLine(indentLevel, "{");
            writer.WriteLine();
            indentLevel += 1;
            // Class
            {
                writer.WriteLine();

                writer.WriteLine(indentLevel, $"{AccessModifierString(_contextAccessModifier)} CqlContext context;");
                writer.WriteLine();
                WriteCachedValues(definitions, libraryName, writer, indentLevel);

                // Write constructor
                writer.WriteLine(indentLevel, $"public {className}(CqlContext context)");
                writer.WriteLine(indentLevel, "{");
                {
                    indentLevel += 1;

                    writer.WriteLine(indentLevel, "this.context = context ?? throw new ArgumentNullException(\"context\");");
                    writer.WriteLine();

                    WriteDependencies(librarySet, libraryNameToClassName, libraryName, writer, indentLevel);
                    writer.WriteLine();
                    WriteCachedValueNames(definitions, libraryName, writer, indentLevel);
                    indentLevel -= 1;
                }
                writer.WriteLine(indentLevel, "}");

                WriteLibraryMembers(writer, librarySet, libraryName, libraryNameToClassName!, indentLevel);
                WriteMemoizedInstanceMethods(definitions, libraryName, writer, indentLevel);
                indentLevel -= 1;
                writer.WriteLine(indentLevel, "}");
            }
        }

        private void WriteMemoizedInstanceMethods(DefinitionDictionary<LambdaExpression> definitions, string libraryName, StreamWriter writer, int indentLevel)
        {
            foreach (var kvp in definitions.DefinitionsForLibrary(libraryName))
            {
                foreach (var overload in kvp.Value)
                {
                    definitions.TryGetTags(libraryName, kvp.Key, overload.Signature, out var tags);
                    WriteMemoizedInstanceMethod(libraryName, writer, indentLevel, kvp.Key, overload.T, tags);
                    writer.WriteLine();
                }
            }
        }

        private void WriteCachedValueNames(DefinitionDictionary<LambdaExpression> definitions, string libraryName, StreamWriter writer, int indentLevel)
        {
            foreach (var kvp in definitions.DefinitionsForLibrary(libraryName))
            {
                foreach (var overload in kvp.Value)
                {
                    if (IsDefinition(overload.Item2))
                    {
                        var methodName = VariableNameGenerator.NormalizeIdentifier(kvp.Key);
                        var cachedValueName = DefinitionCacheKeyForMethod(methodName!);
                        var returnType = _typeToCSharpConverter.ToCSharp(overload.Item2.ReturnType);
                        var privateMethodName = PrivateMethodNameFor(methodName!);
                        writer.WriteLine(indentLevel, $"{cachedValueName} = new Lazy<{returnType}>(this.{privateMethodName});");
                    }
                }
            }
        }

        private static void WriteDependencies(
            LibrarySet librarySet,
            Func<string, string?> libraryNameToClassName,
            string libraryName,
            StreamWriter writer,
            int indentLevel)
        {
            var requiredLibraries = librarySet.GetLibraryDependencies(libraryName, throwError: true);

            foreach (var dependentLibrary in requiredLibraries)
            {
                var typeName = libraryNameToClassName(dependentLibrary.GetVersionedIdentifier()!);
                var memberName = typeName;
                writer.WriteLine(indentLevel, $"{memberName} = new {typeName}(context);");
            }
        }

        private void WriteCachedValues(DefinitionDictionary<LambdaExpression> definitions,
            string libraryName, StreamWriter writer, int indentLevel)
        {
            writer.WriteLine(indentLevel, "#region Cached values");
            writer.WriteLine();
            var accessModifier = AccessModifierString(_definesAccessModifier);
            foreach (var kvp in definitions.DefinitionsForLibrary(libraryName))
            {
                foreach (var overload in kvp.Value)
                {
                    if (IsDefinition(overload.T))
                    {
                        var methodName = VariableNameGenerator.NormalizeIdentifier(kvp.Key);
                        var cachedValueName = DefinitionCacheKeyForMethod(methodName!);
                        var returnType = _typeToCSharpConverter.ToCSharp(overload.T.ReturnType);
                        writer.WriteLine(indentLevel, $"{accessModifier} Lazy<{returnType}> {cachedValueName};");
                    }
                }
            }
            writer.WriteLine();
            writer.WriteLine(indentLevel, "#endregion");
        }

        private static bool IsDefinition(LambdaExpression overload) =>
            overload.Parameters.Count == 1
                && overload.Parameters[0].Type == typeof(CqlContext);

        private void WriteLibraryMembers(TextWriter writer,
            LibrarySet librarySet,
            string libraryName,
            Func<string, string> libraryNameToClassName,
            int indent)
        {
            var requiredLibraries = librarySet.GetLibraryDependencies(libraryName, throwError: true);

            bool atFirst = true;

            foreach (var dependentLibrary in requiredLibraries)
            {
                if (atFirst)
                {
                    atFirst = false;
                    writer.WriteLine(indent, "#region Dependencies");
                    writer.WriteLine();
                }

                var typeName = libraryNameToClassName(dependentLibrary.GetVersionedIdentifier()!);
                var memberName = typeName;
                writer.WriteLine(indent, $"public {typeName} {memberName} {{ get; }}");
            }

            if (!atFirst)
            {
                writer.WriteLine();
                writer.WriteLine(indent, "#endregion");
                writer.WriteLine();
            }
        }

        private string DefinitionCacheKeyForMethod(string methodName)
        {
            if (methodName[0] == '@')
                return "__" + methodName[1..];
            else return "__" + methodName;
        }
        private string PrivateMethodNameFor(string methodName) => methodName + "_Value";

        private void WriteMemoizedInstanceMethod(string libraryName, TextWriter writer, int indentLevel,
            string cqlName,
            LambdaExpression overload,
            ILookup<string, string>? tags)
        {
            var methodName = VariableNameGenerator.NormalizeIdentifier(cqlName);
            var isDef = IsDefinition(overload);

            var vng = new VariableNameGenerator(Enumerable.Empty<string>(), postfix: "_");

            var simplifyNullConditionalMemberExpression = _options.Value.TypeFormat == CSharpCodeWriterTypeFormat.Var;
            var visitedBody = Transform(
                overload.Body,
                new RedundantCastsTransformer(),
                new SimplifyExpressionsVisitor()
                {
                    SimplifyNullConditionalMemberExpression = simplifyNullConditionalMemberExpression
                },
                new RenameVariablesVisitor(vng),
                new LocalVariableDeduper(_typeToCSharpConverter)
            );

            var expressionConverter = NewExpressionToCSharpConverter(libraryName);

            // Skip CqlContext
            var parameters = overload.Parameters.Skip(1);

            overload = Expression.Lambda(visitedBody, parameters);

            if (isDef)
            {
                // Definitions, which are CQL expressions without parameter, can be memoized,
                // so we generate a "generator" function (name ending in _Value) and a
                // getter function, which just calls triggers the lazy to invoke this
                // first _Value method.
                var cachedValueName = DefinitionCacheKeyForMethod(methodName!);
                var privateMethodName = PrivateMethodNameFor(methodName!);

                var func = expressionConverter.ConvertTopLevelFunctionDefinition(indentLevel, overload, privateMethodName, "private");
                writer.Write(func);
                writer.WriteLine();
                writer.WriteLine(indentLevel, $"[CqlDeclaration({QuoteString(cqlName)})]");
                WriteTags(writer, indentLevel, tags);

                if (overload.ReturnType == typeof(CqlValueSet))
                {
                    if (overload.Body is NewExpression @new)
                    {
                        var arg = @new.Arguments[0];
                        if (arg is ConstantExpression { Value: string valueSetId })
                        {
                            writer.WriteLine(indentLevel, $"[CqlValueSet({QuoteString(valueSetId)})]");
                        }
                    }
                }

                var lazyType = typeof(Lazy<>).MakeGenericType(visitedBody.Type);
                var valueFunc =
                    Expression.Lambda(
                    Expression.MakeMemberAccess(
                    Expression.Parameter(lazyType, cachedValueName),
                    lazyType.GetMember("Value").Single()));

                writer.Write(expressionConverter.ConvertTopLevelFunctionDefinition(indentLevel, valueFunc, methodName!, "public"));
            }
            else
            {
                writer.WriteLine(indentLevel, $"[CqlDeclaration({QuoteString(cqlName)})]");
                WriteTags(writer, indentLevel, tags);
                writer.Write(expressionConverter.ConvertTopLevelFunctionDefinition(indentLevel, overload, methodName!, "public"));
            }
        }

        private ExpressionToCSharpConverter NewExpressionToCSharpConverter(string libraryName) =>
            new(_options, _typeToCSharpConverter, new(), libraryName);

        private void WriteTags(TextWriter writer, int indentLevel, ILookup<string, string>? tags)
        {
            if (tags != null)
            {
                foreach (var group in tags)
                {
                    foreach (var tag in group)
                    {
                        writer.WriteLine(indentLevel, $"[CqlTag({QuoteString(group.Key)}, {QuoteString(tag)})]");
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

        private static string AccessModifierString(AccessModifier modifier) => modifier switch
        {
            AccessModifier.Public => "public",
            AccessModifier.Private => "private",
            AccessModifier.Internal => "internal",
            AccessModifier.Protected => "protected",
            AccessModifier.ProtectedInternal => "protected internal",
            _ => throw new ArgumentException("Invalid access modifier", nameof(modifier)),
        };

        private string QuoteString(string literal) =>
            SymbolDisplay.FormatLiteral(literal, true);
    }
}