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
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.Extensions.Options;
using Expression = System.Linq.Expressions.Expression;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;


/*
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.3.0")]
public static class Status_1_6_000_ServiceCollectionExtensions
{
    public static IServiceCollection AddStatus_1_6_000(this IServiceCollection services)
    {
        services.TryAddSingleton<Status_1_6_000>();
        services.AddFHIRHelpers_4_3_000(services);
        return services;
    }
}
*/

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
            // _contextAccessModifier = AccessModifier.Internal;
            // _definesAccessModifier = AccessModifier.Internal;
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
                typeof(IServiceCollection).Namespace!,
                typeof(ServiceCollectionDescriptorExtensions).Namespace!,
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
        private bool PartialClass { get; } = true;

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
                WritePragmas(writer);

                // Namespace
                if (!string.IsNullOrWhiteSpace(Namespace))
                {
                    writer.WriteLine(indentLevel, $"namespace {Namespace}");
                    writer.WriteLine(indentLevel, "{");
                    writer.WriteLine();
                    indentLevel += 1;
                }

                var requiredLibraries = librarySet.GetLibraryDependencies(libraryName, throwError: true);
                WriteServiceCollectionExtensionsClass(callbacks.LibraryNameToClassName, libraryName, writer, indentLevel, requiredLibraries);
                WriteClass(definitions, callbacks.LibraryNameToClassName, libraryName, writer, indentLevel, requiredLibraries);

                if (!string.IsNullOrWhiteSpace(Namespace))
                {
                    writer.WriteLine(indentLevel, "}");
                }

                writer.Flush();
                yield return (libraryName, stream);
            }
        }

        private void WriteServiceCollectionExtensionsClass(
            Func<string, string?> libraryNameToClassName,
            string libraryName,
            StreamWriter writer,
            int indentLevel,
            IReadOnlySet<Library> requiredLibraries)
        {
            WriteGeneratedCodeAttribute(writer, indentLevel);
            var className = $"{libraryNameToClassName(libraryName)}";
            writer.WriteLine(indentLevel, $"public static {(PartialClass ? "partial " : "")}class {className}ServiceCollectionExtensions");
            writer.WriteLine(indentLevel, "{");
            indentLevel += 1;
            {
                writer.WriteLine(indentLevel, $"public static IServiceCollection Add{className}(this IServiceCollection services)");
                writer.WriteLine(indentLevel, "{");
                indentLevel += 1;
                {
                    writer.WriteLine(indentLevel, $"services.TryAddSingleton<{className}>();");
                    foreach (var dependentLibrary in requiredLibraries)
                    {
                        var typeName = libraryNameToClassName(dependentLibrary.GetVersionedIdentifier()!);
                        writer.WriteLine(indentLevel, $"services.Add{typeName}();");
                    }
                    writer.WriteLine(indentLevel, "return services;");
                }
                indentLevel -= 1;
                writer.WriteLine(indentLevel, "}");
            }
            indentLevel -= 1;
            writer.WriteLine(indentLevel, "}");
            writer.WriteLine();
        }

        private void WriteClass(
            DefinitionDictionary<LambdaExpression> definitions,
            Func<string, string?> libraryNameToClassName,
            string libraryName,
            StreamWriter writer,
            int indentLevel,
            IReadOnlySet<Library> requiredLibraries)
        {
            WriteGeneratedCodeAttribute(writer, indentLevel);
            var (identifier, version) = ParseVersionedIdentifierParts(libraryName);
            writer.WriteLine(indentLevel, $"[CqlLibrary({QuoteString(identifier)}, {QuoteString(version)})]");
            var className = libraryNameToClassName(libraryName);
            writer.Write(indentLevel, $"public {(PartialClass ? "partial " : "")}class {className}");
            WritePrimaryConstructor(libraryNameToClassName, writer, indentLevel, requiredLibraries);
            writer.WriteLine(indentLevel, "{");
            writer.WriteLine();
            indentLevel += 1;
            WriteDefinitionMethods(definitions, libraryName, writer, indentLevel);
            indentLevel -= 1;
            writer.WriteLine(indentLevel, "}");
        }

        private static (string identifier, string version) ParseVersionedIdentifierParts(string versionedIdentifierString)
        {
            var libraryAttribute = versionedIdentifierString;
            var versionAttribute = string.Empty;
            var versionedIdentifier = versionedIdentifierString.Split('-');
            if (versionedIdentifier.Length == 2)
            {
                if (Version.TryParse(versionedIdentifier[1], out _))
                {
                    libraryAttribute = versionedIdentifier[0];
                    versionAttribute = versionedIdentifier[1];
                }
            }

            return (libraryAttribute, versionAttribute);
        }

        private void WriteGeneratedCodeAttribute(StreamWriter writer, int indentLevel) =>
            writer.WriteLine(indentLevel, $"[System.CodeDom.Compiler.GeneratedCode({QuoteString(_tool)}, {QuoteString(_version)})]");

        private void WriteDefinitionMethods(DefinitionDictionary<LambdaExpression> definitions, string libraryName, StreamWriter writer, int indentLevel)
        {
            foreach (var kvp in definitions.DefinitionsForLibrary(libraryName))
            {
                foreach (var overload in kvp.Value)
                {
                    definitions.TryGetTags(libraryName, kvp.Key, overload.Signature, out var tags);
                    WriteDefinitionMethod(libraryName, writer, indentLevel, kvp.Key, overload.T, tags);
                    writer.WriteLine();
                }
            }
        }

        private static void WritePrimaryConstructor(
            Func<string, string?> libraryNameToClassName,
            StreamWriter writer,
            int indentLevel,
            IReadOnlySet<Library> requiredLibraries)
        {
            if (requiredLibraries.Count == 0)
            {
                writer.WriteLine();
                return;
            }

            writer.WriteLine("(");
            indentLevel++;
            bool atFirst = true;
            foreach (var dependentLibrary in requiredLibraries)
            {
                if (atFirst)
                {
                    atFirst = false;
                }
                else
                {
                    writer.WriteLine(",");
                }

                var typeName = libraryNameToClassName(dependentLibrary.GetVersionedIdentifier()!);
                var memberName = VariableNameGenerator.NormalizePrimaryConstructorIdentifier(typeName);
                writer.Write(indentLevel,$"{typeName} {memberName}");
            }
            indentLevel--;
            writer.WriteLine(")");
        }

        private static bool IsDefinition(LambdaExpression overload) =>
            overload.Parameters.Count == 1
                && overload.Parameters[0].Type == typeof(CqlContext);

        private void WriteDefinitionMethod(
            string libraryName,
            TextWriter writer,
            int indentLevel,
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

                var func = expressionConverter.ConvertTopLevelFunctionDefinition(indentLevel, overload, methodName!, "public ");
                writer.Write(func);
            }
            else
            {
                writer.WriteLine(indentLevel, $"[CqlDeclaration({QuoteString(cqlName)})]");
                WriteTags(writer, indentLevel, tags);
                writer.Write(expressionConverter.ConvertTopLevelFunctionDefinition(indentLevel, overload, methodName!, "public "));
            }
        }

        private ExpressionToCSharpConverter NewExpressionToCSharpConverter(string libraryName) =>
            new(_options, _typeToCSharpConverter, libraryName);

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

        private void WritePragmas(TextWriter writer)
        {
            writer.WriteLine();
            writer.WriteLine("#pragma warning disable CS9113 // Parameter is unread.");
            writer.WriteLine();
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