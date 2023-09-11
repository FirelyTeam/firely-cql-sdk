/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/cql-sdk/main/LICENSE
 */

using Hl7.Cql.CodeGeneration.NET.Visitors;
using Hl7.Cql.Compiler;
using Hl7.Cql.Compiler.Expressions;
using Hl7.Cql.Graph;
using Hl7.Cql.Primitives;
using Hl7.Cql.Runtime;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;

namespace Hl7.Cql.CodeGeneration.NET
{
    internal static class DebugViewHelper
    {
        public static string GetDebugView(this Expression exp)
        {
            var propertyInfo = typeof(Expression).GetProperty("DebugView", BindingFlags.Instance | BindingFlags.NonPublic)!;
            return (string)propertyInfo.GetValue(exp)!;
        }
    }

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

        internal MethodBuilder MethodBuilder { get; } = new MethodBuilder();

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
        /// <param name="libraryNameToClassName">A function that defines the class name to create given the name of the library being generated.</param>
        /// <param name="closeStream">When <see langword="true"/>, <see cref="Stream"/>s provided by <paramref name="libraryNameToStream"/> will be closed when writing is done.  Default value is <see langword="true"/></param>
        /// <param name="writeFile">A function that determines whether the given library should be generated or not; default is <see langword="null" />.  When <see langword="null" />, all libraries are written.</param>
        public void Write(DefinitionDictionary<LambdaExpression> definitions,
            IEnumerable<Type> tupleTypes,
            DirectedGraph dependencyGraph,
            Func<string, Stream> libraryNameToStream,
            Func<string, string?>? libraryNameToClassName = null,
            bool closeStream = true,
            Func<string, bool>? writeFile = null)
        {
            if (libraryNameToClassName == null)
                libraryNameToClassName = VariableNameGenerator.NormalizeIdentifier;

            bool defaultWriteFile(string nodeId) => true;
            writeFile ??= defaultWriteFile;
            var typesAndMethods = MethodBuilder.CreateMethodsFor(definitions);
            var methods = typesAndMethods.Item1;
            var interfaceTypes = typesAndMethods.Item2;
            var minimalGraph = dependencyGraph;
            var buildOrder = DetermineBuildOrder(minimalGraph);

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
                    if (!string.IsNullOrWhiteSpace(Namespace))
                    {
                        writer.WriteLine(indentLevel, $"namespace {Namespace}");
                        writer.WriteLine(indentLevel, "{");
                        writer.WriteLine();
                        indentLevel += 1;
                    }
                    // Namespace
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
                            writer.WriteLine(indentLevel, $"partial class {className}");
                        else
                            writer.WriteLine(indentLevel, $"public class {className}");
                        writer.WriteLine(indentLevel, "{");
                        writer.WriteLine();
                        indentLevel += 1;
                        // Class
                        {
                            writer.WriteLine();

                            writer.WriteLine(indentLevel, $"{AccessModifierString(ContextAccessModifier)} CqlContext context;");
                            writer.WriteLine();
                            writer.WriteLine(indentLevel, "#region Cached values");
                            writer.WriteLine();
                            var accessModifier = AccessModifierString(DefinesAccessModifier);
                            foreach (var kvp in definitions.DefinitionsForLibrary(libraryName))
                            {
                                foreach (var overload in kvp.Value)
                                {
                                    if (isDefinition(overload.T))
                                    {
                                        var methodName = VariableNameGenerator.NormalizeIdentifier(kvp.Key);
                                        var cachedValueName = DefinitionCacheKeyForMethod(methodName!);
                                        var returnType = PrettyTypeName(overload.T.ReturnType);
                                        writer.WriteLine(indentLevel, $"{accessModifier} Lazy<{returnType}> {cachedValueName};");
                                    }
                                }
                            }
                            writer.WriteLine();
                            writer.WriteLine(indentLevel, "#endregion");
                            writer.WriteLine(indentLevel, $"public {className}(CqlContext context)");
                            writer.WriteLine(indentLevel, "{");
                            {
                                indentLevel += 1;

                                writer.WriteLine(indentLevel, "this.context = context ?? throw new ArgumentNullException(\"context\");");
                                writer.WriteLine();

                                var node = dependencyGraph.Nodes[libraryName];
                                var requiredLibraries = node.ForwardEdges?
                                    .Select(edge => edge.ToId)
                                    .Except(new[] { dependencyGraph.EndNode.NodeId })
                                    .Distinct();
                                foreach (var dependentLibrary in requiredLibraries!)
                                {
                                    var typeName = libraryNameToClassName!(dependentLibrary);
                                    var memberName = typeName;
                                    writer.WriteLine(indentLevel, $"{memberName} = new {typeName}(context);");
                                }
                                writer.WriteLine();
                                foreach (var kvp in definitions.DefinitionsForLibrary(libraryName))
                                {
                                    foreach (var overload in kvp.Value)
                                    {
                                        if (isDefinition(overload.Item2))
                                        {
                                            var methodName = VariableNameGenerator.NormalizeIdentifier(kvp.Key);
                                            var cachedValueName = DefinitionCacheKeyForMethod(methodName!);
                                            var returnType = PrettyTypeName(overload.Item2.ReturnType);
                                            var privateMethodName = PrivateMethodNameFor(methodName!);
                                            writer.WriteLine(indentLevel, $"{cachedValueName} = new Lazy<{returnType}>(this.{privateMethodName});");
                                        }
                                    }
                                }
                                indentLevel -= 1;
                            }
                            writer.WriteLine(indentLevel, "}");

                            var libraryToMemberNames = WriteLibraryMembers(writer, minimalGraph, libraryName, libraryNameToClassName!, indentLevel);
                            var invocationsTransformer = new InvocationsToMethodCallsTransformer(definitions, methods, interfaceTypes, libraryToMemberNames, libraryName);
                            foreach (var kvp in definitions.DefinitionsForLibrary(libraryName))
                            {
                                foreach (var overload in kvp.Value)
                                {
                                    definitions.TryGetTags(libraryName, kvp.Key, overload.Signature, out var tags);
                                    WriteMemoizedInstanceMethod(writer, indentLevel, invocationsTransformer, kvp.Key, overload.T, tags);
                                    writer.WriteLine();
                                }
                            }
                            indentLevel -= 1;
                            writer.WriteLine(indentLevel, "}");
                        }
                        indentLevel -= 1;
                        if (!string.IsNullOrWhiteSpace(Namespace))
                        {
                            writer.WriteLine(indentLevel, "}");
                            indentLevel -= 1;
                        }
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

        private static bool isDefinition(LambdaExpression overload) =>
            overload.Parameters.Count == 1
                && overload.Parameters[0].Type == typeof(CqlContext);

        private Dictionary<string, string> WriteLibraryMembers(TextWriter writer,
            DirectedGraph dependencyGraph,
            string libraryName,
            Func<string, string> libraryNameToClassName,
            int indent)
        {
            var libToMemberNames = new Dictionary<string, string>();
            var node = dependencyGraph.Nodes[libraryName];
            var requiredLibraries = node.ForwardEdges?
                .Select(edge => edge.ToId)
                .Except(new[] { dependencyGraph.EndNode.NodeId })
                .Distinct();
            if (requiredLibraries != null)
            {

                writer.WriteLine(indent, "#region Dependencies");
                writer.WriteLine();

                foreach (var dependentLibrary in requiredLibraries)
                {
                    var typeName = libraryNameToClassName(dependentLibrary);
                    var memberName = typeName;
                    libToMemberNames.Add(dependentLibrary, memberName);
                    writer.WriteLine(indent, $"public {typeName} {memberName} {{ get; }}");
                }
                writer.WriteLine();
                writer.WriteLine(indent, "#endregion");
                writer.WriteLine();
            }
            return libToMemberNames;
        }

        private IList<DirectedGraphNode> DetermineBuildOrder(DirectedGraph minimalGraph)
        {
            var sorted = minimalGraph.TopologicalSort()
                .Where(n => n.NodeId != minimalGraph.StartNode.NodeId
                    && n.NodeId != minimalGraph.EndNode.NodeId)
                .ToList();
            return sorted;
        }

        private string DefinitionCacheKeyForMethod(string methodName)
        {
            if (methodName[0] == '@')
                return "__" + methodName.Substring(1);
            else return "__" + methodName;
        }
        private string PrivateMethodNameFor(string methodName) => methodName + "_Value";

        private void WriteMemoizedInstanceMethod(TextWriter writer, int indentLevel, InvocationsToMethodCallsTransformer invocationsTransformer,
            string cqlName,
            LambdaExpression overload,
            ILookup<string, string>? tags)
        {
            var methodName = VariableNameGenerator.NormalizeIdentifier(cqlName);
            var isDef = isDefinition(overload);

            var vng = new VariableNameGenerator(Enumerable.Empty<string>(), postfix: "_");

            var visitedBody = Transform(overload.Body,
                invocationsTransformer,
                new RedundantCastsTransformer(),
                new SimplifyExpressionsVisitor(),
                new RenameVariablesVisitor(vng)
            //    new LocalVariableDeduper()
            );

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

                var func = convertTopLevelFunctionDefinition(indentLevel, overload, privateMethodName, "private");
                writer.Write(func);
                writer.WriteLine();
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

                var lazyType = typeof(Lazy<>).MakeGenericType(visitedBody.Type);
                var valueFunc =
                    Expression.Lambda(
                    Expression.MakeMemberAccess(
                    Expression.Parameter(lazyType, cachedValueName),
                    lazyType.GetMember("Value").Single()));

                writer.Write(convertTopLevelFunctionDefinition(indentLevel, valueFunc, methodName!, "public"));
                //     writer.WriteLine();
            }
            else
            {
                writer.WriteLine(indentLevel, $"[CqlDeclaration(\"{cqlName}\")]");
                WriteTags(writer, indentLevel, tags);
                writer.Write(convertTopLevelFunctionDefinition(indentLevel, overload, methodName!, "public"));
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
            writer.WriteLine();
            writer.WriteLine(indentLevel, $"[System.CodeDom.Compiler.GeneratedCode(\"{Tool}\", \"{Version}\")]");
            writer.WriteLine(indentLevel, $"public class {tupleType.Name}: {PrettyTypeName(tupleType.BaseType!)}");
            writer.WriteLine(indentLevel, "{");

            indentLevel++;
            foreach (var property in tupleType.GetProperties())
            {
                var normalizedName = VariableNameGenerator.NormalizeIdentifier(property.Name);
                var propertyType = PrettyTypeName(property.PropertyType);
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



        private static string ToCode(int indent, Expression expression, bool leadingIndent = true)
        {
            var leadingIndentString = leadingIndent ? IndentString(indent) : string.Empty;

            return expression switch
            {
                ConstantExpression constant => convertConstantExpression(constant.Type, constant.Value, leadingIndentString),
                NewExpression @new => convertNewExpression(leadingIndentString, @new),
                MethodCallExpression call => convertMethodCallExpression(indent, leadingIndentString, call),
                LambdaExpression lambda => convertLambdaExpression(indent, leadingIndentString, lambda),
                BinaryExpression binary => convertBinaryExpression(indent, leadingIndentString, binary),
                UnaryExpression unary => convertUnaryExpression(indent, leadingIndentString, unary),
                NewArrayExpression newArray => convertNewArrayExpression(indent, leadingIndentString, newArray),
                MemberExpression me => convertMemberExpression(leadingIndentString, me),
                MemberInitExpression memberInit => convertMemberInitExpression(indent, leadingIndentString, memberInit),
                ConditionalExpression ce => convertConditionalExpression(indent, leadingIndentString, ce),
                TypeBinaryExpression typeBinary => convertTypeBinaryExpression(indent, typeBinary),
                ParameterExpression pe => convertParameterExpression(leadingIndentString, pe),
                DefaultExpression de => convertDefaultExpression(leadingIndentString, de),
                NullConditionalMemberExpression nullp => convertNullConditionalMemberExpression(leadingIndentString, nullp),
                BlockExpression block => convertBlockExpression(indent, block),
                InvocationExpression invocation => convertInvocationExpression(leadingIndentString, invocation),
                CaseWhenThenExpression cwt => convertCaseWhenThenExpression(indent, cwt),
                ElmAsExpression ea => ToCode(indent, ea.Reduce(), leadingIndent),
                _ => throw new NotSupportedException($"Don't know how to convert an expression of type {expression.GetType()} into C#."),
            };
        }

        private static readonly ObjectIDGenerator gen = new();

        private static string convertBlockExpression(int indent, BlockExpression block)
        {
            var sb = new StringBuilder();

            sb.AppendLine(indent, "{");

            var lastExpression = block.Expressions.LastOrDefault();
            var isFirstStatement = true;

            foreach (var childStatement in block.Expressions)
            {
                if (ReferenceEquals(childStatement, lastExpression))
                {

                    if (childStatement is not CaseWhenThenExpression)
                    {
                        if (!isFirstStatement) sb.AppendLine();
                        sb.Append(indent + 1, "return ");
                    }
                    sb.Append(ToCode(indent + 1, childStatement, false));
                }
                else
                {
                    sb.Append(ToCode(indent + 1, childStatement));
                }

                sb.AppendLine(";");
                isFirstStatement = false;
            }

            sb.Append(indent, "}");

            return sb.ToString();
        }

        private static string convertNullConditionalMemberExpression(string indentString, NullConditionalMemberExpression nullp)
        {
            return $"{indentString}{Parenthesize(ToCode(0, nullp.MemberExpression.Expression!))}?.{nullp.MemberExpression.Member.Name}";
        }

        private static string convertConstantExpression(Type constantType, object? value, string? identString = "")
        {
            return $"{identString}{formatValue(constantType, value)}";

            string formatValue(Type constantType, object? value)
            {
                if (value == default)
                {
                    return constantType.IsValueType ? "default" : "null";
                }
                else
                {
                    if (constantType.IsEnum)
                        return $"{constantType.Namespace}.{constantType.Name}.{value}";
                    if (constantType == typeof(string))
                        return SymbolDisplay.FormatLiteral((string)value, true);
                    else if (constantType == typeof(bool))
                        return value.ToString()!.ToLowerInvariant();
                    else if (constantType == typeof(bool?))
                        return value.ToString()!.ToLowerInvariant();
                    else if (constantType == typeof(Uri))
                        return $"new Uri(\"{value}\")";
                    else if (constantType == typeof(decimal))
                        return ((decimal)value).ToString(CultureInfo.InvariantCulture) + "m";
                    else if (constantType == typeof(decimal?))
                        return ((decimal?)value).Value.ToString(CultureInfo.InvariantCulture) + "m";
                    else if (typeof(Type).IsAssignableFrom(constantType))
                        return $"typeof({PrettyTypeName((Type)value)})";
                    else
                    {
                        var str = value.ToString()!;
                        return str;
                    }
                }
            }
        }


        private static string convertParameterExpression(string leadingIndentString, ParameterExpression pe)
        {
            return $"{leadingIndentString}{paramName(pe)}";
        }

        private static string convertInvocationExpression(string leadingIndentString, InvocationExpression invoc)
        {
            if (invoc.Expression is ParameterExpression pe && !invoc.Arguments.Any())
                return $"{leadingIndentString}{pe.Name}()";
            else
                throw new NotImplementedException();
        }
        private static string convertMethodCallExpression(int indent, string leadingIndentString, MethodCallExpression call)
        {
            var sb = new StringBuilder();
            sb.Append(leadingIndentString);

            var @object = call switch
            {
                { Object: not null } => $"{Parenthesize(ToCode(indent, call.Object, false))}.",
                { Method.IsStatic: true } ext when ext.Method.IsExtensionMethod() =>
                        $"{Parenthesize(ToCode(indent, call.Arguments[0], false))}.",
                { Method.IsStatic: true } => $"{PrettyTypeName(call.Method.DeclaringType!)}.",
                _ => throw new InvalidOperationException("Calls should be either static or have a non-null object.")
            };

            sb.Append(CultureInfo.InvariantCulture, $"{@object}{PrettyMethodName(call.Method)}(");

            var paramList = call.Method.IsExtensionMethod() ? call.Arguments.Skip(1) : call.Arguments;

            bool firstArg = true;
            foreach (var argument in paramList)
            {
                var argAsCode = ToCode(indent + 1, argument, false);
                if (firstArg)
                {
                    sb.Append(argAsCode);
                    firstArg = false;
                }
                else
                {
                    sb.Append(", ");
                    sb.Append(argAsCode);
                }
            }

            sb.Append(')');
            return sb.ToString();
        }

        private static string convertDefaultExpression(string leadingIndentString, DefaultExpression de)
        {
            var isNullableType = !de.Type.IsValueType || Nullable.GetUnderlyingType(de.Type) is not null;
            var defaultExpression = isNullableType ? "null" : $"default({PrettyTypeName(de.Type)})";
            return $"{leadingIndentString}{defaultExpression}";
        }

        private static string convertTypeBinaryExpression(int indent, TypeBinaryExpression typeBinary)
        {
            if (typeBinary.NodeType == ExpressionType.TypeIs)
            {
                var left = ToCode(indent, typeBinary.Expression, false);
                var type = PrettyTypeName(typeBinary.TypeOperand);
                var @is = $"{left} is {type}";
                return @is;
            }
            else
                throw new NotSupportedException($"Don't know how to convert a type binary operator {typeBinary.NodeType} into C#.");
        }

        private static string convertConditionalExpression(int indent, string leadingIndentString, ConditionalExpression ce)
        {
            var conditionalSb = new StringBuilder();
            conditionalSb.Append(leadingIndentString);
            conditionalSb.Append('(');
            var test = ToCode(indent, ce.Test, false);
            conditionalSb.AppendLine(CultureInfo.InvariantCulture, $"{Parenthesize(test)}");

            var ifTrue = $"{Parenthesize(ToCode(indent + 2, ce.IfTrue, false))}";
            var ifFalse = $"{Parenthesize(ToCode(indent + 2, ce.IfFalse, false))}";
            conditionalSb.AppendLine(CultureInfo.InvariantCulture, $"{IndentString(indent + 1)}? {ifTrue}");
            conditionalSb.Append(CultureInfo.InvariantCulture, $"{IndentString(indent + 1)}: {ifFalse})");

            if (ce.IfTrue.Type != ce.Type || ce.IfFalse.Type != ce.Type)
                return $"(({PrettyTypeName(ce.Type)}){conditionalSb})";
            else
                return conditionalSb.ToString();
        }

        private static string convertCaseWhenThenExpression(int indent, CaseWhenThenExpression conditional)
        {
            var sb = new StringBuilder();

            bool firstCase = true;
            foreach (var c in conditional.WhenThenCases)
            {
                if (firstCase)
                    sb.Append(indent, "if (");
                else
                    sb.Append(indent, "else if (");

                sb.Append(ToCode(indent + 1, c.When, false));
                sb.AppendLine(")");
                sb.AppendLine(convertConditionalStatementBlock(indent, c.Then));
                firstCase = false;
            }

            sb.AppendLine(indent, "else");
            sb.Append(convertConditionalStatementBlock(indent, conditional.ElseCase));

            return sb.ToString();
        }

        private static string convertConditionalStatementBlock(int indent, Expression conditionalActionBlock)
        {
            if (conditionalActionBlock is BlockExpression)
            {
                return ToCode(indent, conditionalActionBlock);
            }
            else
            {
                var sb = new StringBuilder();
                sb.AppendLine(indent, "{");
                sb.Append(indent + 1, "return ");
                sb.Append(ToCode(indent + 1, conditionalActionBlock, false));
                sb.AppendLine(";");
                sb.Append(indent, "}");

                return sb.ToString();
            }
        }

        private static string convertMemberInitExpression(int indent, string leadingIndentString, MemberInitExpression memberInit)
        {
            var memberInitSb = new StringBuilder();
            memberInitSb.Append(leadingIndentString);
            var arrayType = PrettyTypeName(memberInit.Type);
#pragma warning disable CA1305 // Specify IFormatProvider
            memberInitSb.AppendLine($"new {arrayType}");
#pragma warning restore CA1305 // Specify IFormatProvider
            var braceIndent = IndentString(indent);
            memberInitSb.Append(braceIndent);
            memberInitSb.AppendLine("{");
            var braceIndentPlusOne = IndentString(indent + 1);

            foreach (var binding in memberInit.Bindings)
            {
                if (binding is MemberAssignment assignment)
                {
                    var memberName = assignment.Member.Name;
                    var assignmentCode = ToCode(indent + 1, assignment.Expression, false);
                    memberInitSb.Append(braceIndentPlusOne);
#pragma warning disable CA1305 // Specify IFormatProvider
                    memberInitSb.Append($"{memberName} = {assignmentCode}");
#pragma warning restore CA1305 // Specify IFormatProvider
                    memberInitSb.AppendLine(",");
                }
                else
                    throw new NotSupportedException($"Don't know how to convert a new member init of type {binding.GetType()} into C#.");
            }

            memberInitSb.Append(braceIndent);
            memberInitSb.Append("}");

            return memberInitSb.ToString();
        }

        private static string convertNewArrayExpression(int indent, string leadingIndentString, NewArrayExpression newArray)
        {
            switch (newArray.NodeType)
            {
                case ExpressionType.NewArrayInit:
                    {
                        var newArraySb = new StringBuilder();
                        newArraySb.Append(leadingIndentString);

                        var arrayType = PrettyTypeName(newArray.Type);

#pragma warning disable CA1305 // Specify IFormatProvider
                        newArraySb.AppendLine($"new {arrayType}");
#pragma warning restore CA1305 // Specify IFormatProvider
                        var braceIndent = IndentString(indent);
                        newArraySb.Append(braceIndent);
                        newArraySb.AppendLine("{");

                        foreach (var expr in newArray.Expressions)
                        {
                            var exprCode = ToCode(indent + 1, expr);
                            newArraySb.Append(exprCode);
                            newArraySb.AppendLine(",");
                        }

                        newArraySb.Append(braceIndent);
                        newArraySb.Append('}');
                        return newArraySb.ToString();
                    }
                case ExpressionType.NewArrayBounds:
                    {
                        var newArraySb = new StringBuilder();
                        newArraySb.Append(leadingIndentString);
                        var arrayType = PrettyTypeName(newArray.Type.GetElementType()!);
                        var size = ToCode(0, newArray.Expressions[0], false);
#pragma warning disable CA1305 // Specify IFormatProvider
                        newArraySb.AppendLine($"new {arrayType}[{size}]");
#pragma warning restore CA1305 // Specify IFormatProvider
                        return newArraySb.ToString();
                    }

                default:
                    throw new NotSupportedException($"Don't know how to convert new array operator {newArray.NodeType} into C#.");
            }
        }

        private static string convertNewExpression(string leadingIndentString, NewExpression @new)
        {
            var arguments = @new.Arguments.Select(a => ToCode(0, a));
            var argString = string.Join(", ", arguments);

            var newSb = new StringBuilder();
            newSb.Append(CultureInfo.InvariantCulture, $"{leadingIndentString}new {PrettyTypeName(@new.Type)}");
            newSb.Append(CultureInfo.InvariantCulture, $"({argString})");
            return newSb.ToString();
        }

        private static string convertMemberExpression(string leadingIndentString, MemberExpression me)
        {
            var nullProp = me.Expression is not null && Nullable.GetUnderlyingType(me.Expression.Type) != null ? "?" : "";
            var @object = me.Expression is not null ? ToCode(0, me.Expression) : PrettyTypeName(me.Member.DeclaringType!);
            var memberName = escapeKeywords(me.Member.Name);
            var nullCoalesce = $"{@object}{nullProp}.{memberName}";
            return $"{leadingIndentString}{nullCoalesce}";
        }


        private static string convertLambdaExpression(int indent, string leadingIndentString, LambdaExpression lambda, bool functionMode = false)
        {
            var lambdaSb = new StringBuilder();
            lambdaSb.Append(leadingIndentString);

            var lambdaParameters = $"({string.Join(", ", lambda.Parameters.Select(p => $"{PrettyTypeName(p.Type)} {escapeKeywords(p.Name!)}"))})";
            lambdaSb.Append(lambdaParameters);

            if (lambda.Body is BlockExpression)
            {
                if (!functionMode)
                    lambdaSb.AppendLine(" =>");
                else
                    lambdaSb.AppendLine();

                var lambdaBody = ToCode(indent, lambda.Body);
                lambdaSb.Append(lambdaBody);
            }
            else
            {
                lambdaSb.AppendLine(" => ");
                var lambdaBody = ToCode(indent + 1, lambda.Body);
                lambdaSb.Append(lambdaBody);
            }

            return lambdaSb.ToString();
        }


        private static string convertLocalFunctionDefinition(int indent, string leadingIndentString, LambdaExpression function, string name)
        {
            var funcSb = new StringBuilder();
            funcSb.Append(leadingIndentString);
            funcSb.Append(PrettyTypeName(function.ReturnType) + " ");
            funcSb.Append(name);

            var lambda = convertLambdaExpression(indent, "", function, functionMode: true);
            funcSb.Append(lambda);

            return funcSb.ToString();
        }

        private static string convertTopLevelFunctionDefinition(int indent, LambdaExpression function, string name, string specifiers)
        {
            var funcSb = new StringBuilder();

            funcSb.Append(indent, specifiers + " ");
            funcSb.Append(PrettyTypeName(function.ReturnType) + " ");
            funcSb.Append(name);

            var lambda = convertLambdaExpression(indent, "", function, functionMode: true);
            funcSb.Append(lambda);

            if (function.Body is not BlockExpression)
                funcSb.AppendLine(";");
            else
                funcSb.AppendLine();

            return funcSb.ToString();
        }


        // Linq.Expressions needs an explicit conversion from a value type
        // type to object, but the C# compiler will insert that boxing,
        // so we can remove those casts. 
        internal static Expression StripBoxing(Expression node)
        {
            // (x as object) => x
            // ((object)x) => x
            if (node is UnaryExpression
                {
                    NodeType: ExpressionType.ConvertChecked or
                            ExpressionType.Convert or
                            ExpressionType.TypeAs
                } cast &&
                cast.Type == typeof(object) &&
                cast.Operand.Type.IsValueType)
            {
                return StripBoxing(cast.Operand);
            }
            else
            {
                return node;
            }
        }

        private static string convertUnaryExpression(int indent, string leadingIndentString, UnaryExpression unary)
        {
            //var stripped = unary;
            var stripped = StripBoxing(unary);

            if (stripped is not UnaryExpression strippedUnary)
                return ToCode(indent, stripped, false);

            switch (strippedUnary.NodeType)
            {
                case ExpressionType.ConvertChecked:
                case ExpressionType.Convert:
                case ExpressionType.TypeAs:
                    {
                        var operand = ToCode(indent, strippedUnary.Operand, false);

                        var typeName = PrettyTypeName(strippedUnary.Type);
                        var code = strippedUnary.NodeType == ExpressionType.TypeAs ?
                            $"{leadingIndentString}{Parenthesize($"{operand} as {typeName}")}" :
                            $"{leadingIndentString}{Parenthesize($"({typeName}){operand}")}";
                        return code;
                    }
                default:
                    throw new NotSupportedException($"Don't know how to convert unary operator {strippedUnary.NodeType} into C#.");
            }
        }

        private static string paramName(ParameterExpression p)
        {
            if (p.Name is not null) return p.Name;
            else
                return $"var{gen.GetId(p, out var _)}";
        }

        private static string convertBinaryExpression(int indent, string leadingIndentString, BinaryExpression binary)
        {
            var left = StripBoxing(binary.Left);
            var right = StripBoxing(binary.Right);

            if (binary.NodeType == ExpressionType.Assign &&
                left is ParameterExpression parameter)
            {
                if (right is LambdaExpression le)
                    return convertLocalFunctionDefinition(indent, leadingIndentString, le, parameter.Name!);

                var rightCode = ToCode(indent, right, false);
                string typeDeclaration = "var";
                if (rightCode == "null" || rightCode == "default")
                    typeDeclaration = PrettyTypeName(left.Type);
                var assignment = $"{leadingIndentString}{typeDeclaration} {paramName(parameter)} = {rightCode}";
                return assignment;
            }
            else
            {
                var @operator = binary.NodeType == ExpressionType.Equal && right is ConstantExpression
                    ? "is"
                    : BinaryOperatorFor(binary.NodeType);

                var leftCode = ToCode(indent, left, false);
                var rightCode = ToCode(indent, right, false);
                var binaryString = $"{leadingIndentString}({leftCode} {@operator} {rightCode})";
                return binaryString;
            }
        }

        private static string BinaryOperatorFor(ExpressionType nodeType) => nodeType switch
        {
            ExpressionType.Add => "+",
            ExpressionType.AddAssign or ExpressionType.AddAssignChecked or ExpressionType.AddChecked => "+=",
            ExpressionType.And => "&",
            ExpressionType.AndAlso => "&&",
            ExpressionType.AndAssign => "&=",
            ExpressionType.Assign => "=",
            ExpressionType.Coalesce => "??",
            ExpressionType.Divide => "/",
            ExpressionType.DivideAssign => "/=",
            ExpressionType.Equal => "==",
            ExpressionType.ExclusiveOr => "^^",
            ExpressionType.ExclusiveOrAssign => "^^=",
            ExpressionType.GreaterThan => ">",
            ExpressionType.GreaterThanOrEqual => ">=",
            ExpressionType.LeftShift => "<<",
            ExpressionType.LeftShiftAssign => "<<=",
            ExpressionType.LessThan => "<",
            ExpressionType.LessThanOrEqual => "<=",
            ExpressionType.Modulo => "%",
            ExpressionType.ModuloAssign => "%=",
            ExpressionType.Multiply or ExpressionType.MultiplyChecked => "*",
            ExpressionType.MultiplyAssign or ExpressionType.MultiplyAssignChecked => "*=",
            ExpressionType.NotEqual => "!=",
            ExpressionType.Or => "|",
            ExpressionType.OrAssign => "|=",
            ExpressionType.OrElse => "||",
            ExpressionType.RightShift => ">>",
            ExpressionType.RightShiftAssign => ">>=",
            ExpressionType.Subtract or ExpressionType.SubtractChecked => "-",
            ExpressionType.SubtractAssign or ExpressionType.SubtractAssignChecked => "-=",
            ExpressionType.TypeAs => "as",
            ExpressionType.TypeIs => "is",
            _ => throw new NotSupportedException($"Don't know how to convert operator {nodeType} into C#."),
        };

        private static string IndentString(int indent) => new string(Enumerable.Repeat('\t', indent).ToArray());

        private static string PrettyMethodName(MethodInfo method)
        {
            if (method.IsGenericMethod)
            {
                var genericArgs = string.Join(", ", method.GetGenericArguments().Select(PrettyTypeName));
                return $"{method.Name}<{genericArgs}>";
            }
            else
                return method.Name;
        }

        private static string PrettyTypeName(Type type)
        {
            string typeName = type.Name;
            if (type == typeof(int))
                return "int";
            else if (type == typeof(bool))
                return "bool";
            else if (type == typeof(decimal))
                return "decimal";
            else if (type == typeof(float))
                return "float";
            else if (type == typeof(double))
                return "double";
            else if (type == typeof(string))
                return "string";
            else if (type == typeof(object))
                return "object";
            if (type.IsGenericType)
            {
                if (type.IsGenericTypeDefinition == false && type.GetGenericTypeDefinition() == typeof(Nullable<>))
                {
                    typeName = $"{PrettyTypeName(Nullable.GetUnderlyingType(type)!)}?";
                }
                else
                {
                    if (type.IsGenericType)
                    {
                        var tildeIndex = type.Name.IndexOf('`');
                        var rootName = type.Name.Substring(0, tildeIndex);
                        var genericArgumentNames = type.GetGenericArguments()
                            .Select(PrettyTypeName);
                        var prettyName = $"{rootName}<{string.Join(",", genericArgumentNames)}>";
                        typeName = prettyName;
                    }
                }
            }
            if (type.IsNested)
            {
                typeName = $"{PrettyTypeName(type.DeclaringType!)}.{typeName}";
            }
            if (typeName.StartsWith("Tuple_"))
            {
                return $"{type.Namespace}.{typeName}";
            }
            else if (type.IsArray)
            {
                var elementType = type.GetElementType() ??
                    throw new InvalidOperationException($"Unable to get array element type for {type.FullName}");
                return $"{PrettyTypeName(elementType)}[]";
            }
            else return typeName;
        }

        private static string Parenthesize(string term)
        {
            term = term.Trim();
            if (term.StartsWith('(') && term.EndsWith(')')) return term;

            return term.ToCharArray().Any(char.IsWhiteSpace) ? $"({term})" : term;
        }


        private static string escapeKeywords(string symbol)
        {
            var keyword = SyntaxFacts.GetKeywordKind(symbol);
            return keyword == SyntaxKind.None ? symbol : $"@{symbol}";
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

