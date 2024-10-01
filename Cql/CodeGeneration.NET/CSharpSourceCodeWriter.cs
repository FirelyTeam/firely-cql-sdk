/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;
using Hl7.Cql.CodeGeneration.NET.Visitors;
using Hl7.Cql.Graph;
using Hl7.Cql.Primitives;
using Hl7.Cql.Runtime;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;

namespace Hl7.Cql.CodeGeneration.NET
{
    /// <summary>
    /// Writes <see cref="LambdaExpression"/>s as members of a .NET class.
    /// </summary>
    internal class CSharpSourceCodeWriter
    {
        /// <summary>
        /// Creates an instance.
        /// </summary>
        /// <param name="log">The <see cref="ILogger{TCategoryName}"/> to report output.</param>
        public CSharpSourceCodeWriter(ILogger<CSharpSourceCodeWriter> log)
        {
            Log = log;
        }

        /// <summary>
        /// Gets or sets the namespace for generated .NET types.
        /// </summary>
        public string? Namespace { get; set; }
        /// <summary>
        /// If <see langword="true"/>, classes will be declared with the <see langword="partial"/> keyword.
        /// </summary>
        public bool PartialClass { get; set; }

        /// <summary>
        /// The <see cref="AccessModifier"/> to use for the <see cref="CqlContext"/> class member; its default value is <see cref="AccessModifier.Internal"/>.
        /// </summary>
        public AccessModifier ContextAccessModifier { get; set; } = AccessModifier.Internal;
        /// <summary>
        /// The <see cref="AccessModifier"/> to use for all CQL defines; its default value is <see cref="AccessModifier.Internal"/>.
        /// </summary>
        public AccessModifier DefinesAccessModifier { get; set; } = AccessModifier.Internal;

        /// <summary>
        /// Gets the <see langword="using"/> statements to be included in the generated code.
        /// </summary>
        public IList<string> Usings { get; } = new List<string>
        {
            nameof(System),
            typeof(Enumerable).Namespace!, // System.Linq
            typeof(ICollection<>).Namespace!, // System.Collections.Generic
            typeof(CqlContext).Namespace!,
            typeof(CqlPrimitiveType).Namespace!,
        };
        /// <summary>
        /// Gets the aliased <see langword="using"/> statements to be included in the generated code.
        /// For example,
        /// <code>
        /// using Item1 = Item2;
        /// </code>
        /// </summary>
        public IList<(string, string)> AliasedUsings { get; } = new List<(string, string)>
        {
        };

        /// <summary>
        /// Gets the version of this <see cref="CSharpSourceCodeWriter"/> as will appear in the <see cref="System.CodeDom.Compiler.GeneratedCodeAttribute.Version"/>.
        /// </summary>
        public string Version => GetType().Assembly?.GetName()?.Version?.ToString() ?? "1.0.0";
        /// <summary>
        /// Gets the product of this <see cref="CSharpSourceCodeWriter"/> as will appear in the <see cref="System.CodeDom.Compiler.GeneratedCodeAttribute.Tool"/>.
        /// </summary>
        public string Tool =>
                GetType()
                .Assembly?
                .GetCustomAttributes(false)
                .OfType<AssemblyProductAttribute>()
                .SingleOrDefault()?
                .Product
            ?? "ELM-to-CSharp";

        internal ILogger<CSharpSourceCodeWriter> Log { get; }

        /// <summary>
        /// Writes C# source code from inputs.
        /// </summary>
        /// <param name="definitions">The lambda expressions to write.</param>
        /// <param name="tupleTypes">Tuple types generated during lambda creation.</param>
        /// <param name="dependencyGraph">A dependency graph containing dependent libraries.</param>
        /// <param name="libraryNameToStream">A function that provides a <see cref="Stream"/> to write the source code given the name of the library being generated.</param>
        /// <param name="closeStream">When <see langword="true"/>, <see cref="Stream"/>s provided by <paramref name="libraryNameToStream"/> will be closed when writing is done.  Default value is <see langword="true"/></param>
        /// <param name="writeFile">A function that determines whether the given library should be generated or not; default is <see langword="null" />.  When <see langword="null" />, all libraries are written.</param>
        /// 
        public void Write(DefinitionDictionary<LambdaExpression> definitions,
            IEnumerable<Type> tupleTypes,
            DirectedGraph dependencyGraph,
            Func<string, Stream> libraryNameToStream,
            bool closeStream = true,
            Predicate<string>? writeFile = null)
        {
            var libraryNameToClassName = VariableNameGenerator.NormalizeIdentifier;
            bool defaultWriteFile(string nodeId) => true;
            writeFile ??= defaultWriteFile;

            writeTupleTypes(tupleTypes, libraryNameToStream, closeStream);

            writeLibraries(definitions, dependencyGraph, libraryNameToStream, closeStream, writeFile!, libraryNameToClassName);
        }

        private void writeLibraries(DefinitionDictionary<LambdaExpression> definitions,
            DirectedGraph dependencyGraph,
            Func<string, Stream> libraryNameToStream,
            bool closeStream, Predicate<string> writeFile, Func<string?, string?> libraryNameToClassName)
        {
            var buildOrder = DetermineBuildOrder(dependencyGraph);

            foreach (var library in buildOrder)
            {
                string libraryName = library.NodeId;

                if (!writeFile(libraryName))
                    continue;

                if (!definitions.Libraries.Contains(libraryName))
                {
                    Log.LogInformation($"Skipping library {libraryName}, which has no definitions");
                    continue;
                }

                var stream = libraryNameToStream(libraryName);

                try
                {
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

                    writeClass(definitions, dependencyGraph, libraryNameToClassName, libraryName, writer, indentLevel);

                    if (!string.IsNullOrWhiteSpace(Namespace))
                    {
                        writer.WriteLine(indentLevel, "}");
                        indentLevel -= 1;
                    }
                }
                finally
                {
                    if (closeStream && stream != null)
                    {
                        stream.Close();
                    }
                }
            }
        }

        private void writeClass(DefinitionDictionary<LambdaExpression> definitions,
            DirectedGraph dependencyGraph,
            Func<string?, string?> libraryNameToClassName,
            string libraryName, StreamWriter writer,
            int indentLevel)
        {
            writer.WriteLine(indentLevel, $"[System.CodeDom.Compiler.GeneratedCode(\"{Tool}\", \"{Version}\")]");

            var libraryAttribute = libraryName;
            var versionAttribute = string.Empty;
            var nameAndVersion = libraryName.Split('-');
            if (nameAndVersion.Length == 2)
            {
                if (System.Version.TryParse(nameAndVersion[1], out var version))
                {
                    libraryAttribute = nameAndVersion[0];
                    versionAttribute = nameAndVersion[1];
                }
            }

            writer.WriteLine(indentLevel, $"[CqlLibrary(\"{libraryAttribute}\", \"{versionAttribute}\")]");
            var className = VariableNameGenerator.NormalizeIdentifier(libraryName);
            if (PartialClass)
                writer.WriteLine(indentLevel, $"public partial class {className}");
            else
                writer.WriteLine(indentLevel, $"public class {className}");
            writer.WriteLine(indentLevel, "{");
            writer.WriteLine();
            indentLevel += 1;
            // Class
            {
                writer.WriteLine(indentLevel, $"public static {className} Instance {{ get; }}  = new();");
                writer.WriteLine();

                writeMethods(definitions, libraryName, writer, indentLevel);
                indentLevel -= 1;
                writer.WriteLine(indentLevel, "}");
            }
        }

        private void writeMethods(DefinitionDictionary<LambdaExpression> definitions, string libraryName, StreamWriter writer, int indentLevel)
        {
            foreach (var kvp in definitions.DefinitionsForLibrary(libraryName))
            {
                foreach (var overload in kvp.Value)
                {
                    definitions.TryGetTags(libraryName, kvp.Key, overload.Signature, out var tags);
                    writeMethod(libraryName, writer, indentLevel, kvp.Key, overload.T, tags);
                    writer.WriteLine();
                }
            }
        }
        
        private void writeTupleTypes(IEnumerable<Type> tupleTypes, Func<string, Stream> libraryNameToStream, bool closeStream)
        {
            if (tupleTypes.Any())
            {
                foreach (var tupleType in tupleTypes!)
                {
                    if (tupleType == null)
                        continue;
                    var tupleTypeStream = libraryNameToStream(Path.Combine(tupleType.Namespace!, tupleType.Name));
                    try
                    {
                        var writer = new StreamWriter(tupleTypeStream);
                        WriteUsings(writer);
                        var indentLevel = 0;
                        writer.WriteLine();
                        writer.WriteLine(indentLevel, $"namespace {tupleType.Namespace}");
                        writer.WriteLine(indentLevel, "{");
                        indentLevel += 1;
                        WriteTupleType(writer, indentLevel, tupleType);
                        indentLevel -= 1;
                        writer.WriteLine(indentLevel, "}");
                        writer.Flush();
                    }
                    finally
                    {
                        if (closeStream && tupleTypeStream != null)
                        {
                            tupleTypeStream.Close();
                            tupleTypeStream = null;
                        }
                    }
                }
            }
            else
            {
                Log.LogInformation($"No tuple types detected; skipping.");
            }
        }

        private static bool isDefinition(LambdaExpression overload) =>
            overload.Parameters.Count == 1
                && overload.Parameters[0].Type == typeof(CqlContext);

        private IList<DirectedGraphNode> DetermineBuildOrder(DirectedGraph minimalGraph)
        {
            var sorted = minimalGraph.TopologicalSort()
                .Where(n => n.NodeId != minimalGraph.StartNode.NodeId
                    && n.NodeId != minimalGraph.EndNode.NodeId)
                .ToList();
            return sorted;
        }

        private void writeMethod(string libraryName, TextWriter writer, int indentLevel,
            string cqlName,
            LambdaExpression overload,
            ILookup<string, string>? tags)
        {
            var methodName = VariableNameGenerator.NormalizeIdentifier(cqlName);
            var isDef = isDefinition(overload);

            var vng = new VariableNameGenerator(Enumerable.Empty<string>(), postfix: "_");

            var visitedBody = Transform(overload.Body,
                new RedundantCastsTransformer(),
                new SimplifyExpressionsVisitor(),
                new RenameVariablesVisitor(vng),
                new LocalVariableDeduper()
            );

            var expressionConverter = new ExpressionConverter(libraryName);

            // Skip CqlContext
            var parameters = overload.Parameters.Skip(1);

            overload = Expression.Lambda(visitedBody, parameters);

            if (isDef)
            {
                writer.WriteLine(indentLevel, $"[CqlDeclaration(\"{cqlName}\")]");
                WriteTags(writer, indentLevel, tags);

                if (overload.ReturnType == typeof(CqlValueSet))
                {
                    if (overload.Body is NewExpression @new)
                    {
                        var arg = @new.Arguments[0];
                        if (arg is ConstantExpression constant)
                        {
                            if (constant.Value is string valueSetId)
                            {
                                writer.WriteLine(indentLevel, $"[CqlValueSet(\"{valueSetId}\")]");
                            }
                        }
                    }
                }

                writer.Write(expressionConverter.ConvertTopLevelFunctionDefinition(indentLevel, overload, methodName!, "public"));
            }
            else
            {
                writer.WriteLine(indentLevel, $"[CqlDeclaration(\"{cqlName}\")]");
                WriteTags(writer, indentLevel, tags);
                writer.Write(expressionConverter.ConvertTopLevelFunctionDefinition(indentLevel, overload, methodName!, "public"));
                //      writer.WriteLine();
            }
        }

        private static void WriteTags(TextWriter writer, int indentLevel, ILookup<string, string>? tags)
        {
            if (tags != null)
            {
                foreach (var group in tags)
                {
                    foreach (var tag in group)
                    {
                        writer.WriteLine(indentLevel, $"[CqlTag(\"{group.Key}\", \"{tag}\")]");
                    }
                }
            }
        }

        private void WriteUsings(TextWriter writer)
        {
            foreach (var @using in Usings.Distinct())
            {
                writer.WriteLine($"using {@using};");
            }
            foreach (var @using in AliasedUsings)
            {
                writer.WriteLine($"using {@using.Item1} = {@using.Item2};");
            }
        }

        private int WriteTupleType(TextWriter writer, int indentLevel, Type tupleType)
        {
            writer.WriteLine(indentLevel, $"[System.CodeDom.Compiler.GeneratedCode(\"{Tool}\", \"{Version}\")]");
            writer.WriteLine(indentLevel, $"public class {tupleType.Name}: {ExpressionConverter.PrettyTypeName(tupleType.BaseType!)}");
            writer.WriteLine(indentLevel, "{");

            indentLevel++;
            foreach (var property in tupleType.GetProperties())
            {
                var normalizedName = VariableNameGenerator.NormalizeIdentifier(property.Name);
                var propertyType = ExpressionConverter.PrettyTypeName(property.PropertyType);
                var cqlDeclarationAttribute = property.GetCustomAttribute<CqlDeclarationAttribute>();
                if (cqlDeclarationAttribute != null)
                {
                    writer.WriteLine(indentLevel, $"[CqlDeclaration(\"{cqlDeclarationAttribute.Name}\")]");
                }
                writer.WriteLine(indentLevel, $"public {propertyType} {normalizedName} {{ get; set; }}");
            }
            indentLevel--;
            writer.WriteLine(indentLevel, $"}}");
            return indentLevel;
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


    }
}

