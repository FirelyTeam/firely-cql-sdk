/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using Expression = System.Linq.Expressions.Expression;

namespace Hl7.Cql.CodeGeneration.NET.Visitors
{

    internal class InvocationsToMethodCallsTransformer : ExpressionVisitor
    {
        public DefinitionDictionary<MethodInfo> Methods { get; }
        public IDictionary<string, Type> Types { get; }
        public IDictionary<string, string> LibraryMembers { get; }
        public string ThisLibrary { get; }

        public bool Throw { get; set; } = false;

        public InvocationsToMethodCallsTransformer(DefinitionDictionary<LambdaExpression> expressions,
            DefinitionDictionary<MethodInfo> methods,
            IDictionary<string, Type> types,
            IDictionary<string, string> libraryMembers,
            string thisLibrary)
        {
            Methods = methods;
            Types = types;
            LibraryMembers = libraryMembers;
            ThisLibrary = thisLibrary;
        }

        protected override Expression VisitInvocation(InvocationExpression node)
        {
            if (node.Expression.NodeType == ExpressionType.TypeAs
                && node.Expression is UnaryExpression typeAs)
            {
                if (typeAs.Operand.NodeType == ExpressionType.Index &&
                    typeAs.Operand is IndexExpression index)
                {
                    if (index.Arguments.Count >= 2)
                    {
                        if (index.Arguments[0] is ConstantExpression libraryConstant
                            && index.Arguments[1] is ConstantExpression definitionConstant)
                        {
                            var types = new Type[0];
                            if (index.Arguments.Count >= 3 && index.Arguments[2] is NewArrayExpression newArray)
                            {
                                if (newArray.Expressions.All(expr => expr.NodeType == ExpressionType.Constant))
                                {
                                    var constants = newArray.Expressions
                                        .Cast<ConstantExpression>();
                                    var values = constants
                                        .Select(c => c.Value)
                                        .Cast<Type>();
                                    types = values.ToArray();
                                }
                                else if (Throw) throw new InvalidOperationException("Unexpected values in Invocation index arguments; expected an array of constant type values.");
                            }
                            if (libraryConstant.Value is string libraryName && definitionConstant.Value is string definitionConstantString)
                            {
                                if (libraryName == ThisLibrary)
                                {
                                    if (Methods.TryGetValue(ThisLibrary, definitionConstantString, types, out var method)
                                        && method != null)
                                    {
                                        if (Types.TryGetValue(ThisLibrary, out var thisType))
                                        {
                                            var @this = System.Linq.Expressions.Expression.Parameter(thisType, "this");
                                            // this will never compile as an expression, but will translate into compilable source code
                                            var visitedArgs = node.Arguments
                                                .Skip(1)
                                                .Select(arg => Visit(arg))
                                                .ToArray();
                                            var call = System.Linq.Expressions.Expression.Call(@this, method, visitedArgs);
                                            return call;
                                        }
                                    }
                                    else if (Throw)
                                        throw new InvalidOperationException("This method can't be found and will not resolve at runtime.");
                                }
                                else if (Types.TryGetValue(libraryName, out var libraryInterfaceType))
                                {
                                    if (LibraryMembers.TryGetValue(libraryName, out var memberName))
                                    {
                                        if (Methods.TryGetValue(libraryName, definitionConstantString, types, out var method))
                                        {
                                            var nodeArguments = node.Arguments
                                                .Skip(1) // skip runtimecontext
                                                .ToArray();
                                            var argumentTypes = method!
                                                .GetParameters()
                                                .Select(p => p.ParameterType)
                                                .ToArray();
                                            var libMember = System.Linq.Expressions.Expression.Parameter(libraryInterfaceType, memberName);
                                            var newArguments = new Expression[nodeArguments.Length];
                                            for (int i = 0; i < nodeArguments.Length; i++)
                                            {
                                                var arg = Visit(nodeArguments[i]);
                                                if (argumentTypes[i].IsAssignableFrom(arg.Type))
                                                {
                                                    if (argumentTypes[i] != arg.Type)
                                                    {
                                                        newArguments[i] = Expression.Convert(arg, argumentTypes[i]);
                                                    }
                                                    else
                                                    {
                                                        newArguments[i] = arg;
                                                    }
                                                }
                                                else if (Throw) throw new InvalidOperationException($"Method {(string)definitionConstant.Value} has argument type {argumentTypes[i].Name} but the argument specified has a type of {node.Arguments[i].Type}");
                                            }
                                            if (newArguments.Any(arg => arg == null))
                                            {
                                            }
                                            var call = System.Linq.Expressions.Expression.Call(libMember, method, newArguments);
                                            return call;
                                        }
                                        else
                                        {
                                            if (Methods.TryGetDefinitionsForLibrary(libraryName, out var definitions)
                                                && definitions != null)
                                            {
                                                var defs = definitions
                                                    .Where(kvp => kvp.Key == (string)definitionConstant.Value)
                                                    .ToArray();
                                                if (defs.Length == 1) // the desired method exists.
                                                {
                                                    var def = defs[0];
                                                    if (def.Value.Count == 1) // there is only 1 overload
                                                    {
                                                        method = def.Value[0].Item2;
                                                        var nodeArguments = node.Arguments
                                                        .Skip(1) // skip runtimecontext
                                                        .ToArray();
                                                        var argumentTypes = method!
                                                            .GetParameters()
                                                            .Select(p => p.ParameterType)
                                                            .ToArray();
                                                        var libMember = System.Linq.Expressions.Expression.Parameter(libraryInterfaceType, memberName);
                                                        var newArguments = new Expression[nodeArguments.Length];
                                                        for (int i = 0; i < nodeArguments.Length; i++)
                                                        {
                                                            var arg = Visit(nodeArguments[i]);
                                                            var @as = Expression.TypeAs(arg, argumentTypes[i]);
                                                            newArguments[i] = @as;
                                                        }
                                                        var call = System.Linq.Expressions.Expression.Call(libMember, method, newArguments);
                                                        return call;
                                                    }
                                                }
                                            }
                                            if (Throw)
                                            {
                                                var typeNames = string.Join(", ", types.Select(t => t.Name));
                                                throw new InvalidOperationException($"No method defined for library type {libraryName}, method {(string)definitionConstant.Value} with types {typeNames}");
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (Throw)
                                            throw new InvalidOperationException($"No member defined for library type {libraryName}");
                                    }
                                }
                                else
                                {
                                    if (Throw)
                                        throw new InvalidOperationException($"No interface type defined for library type {libraryName}");
                                }
                            }
                        }
                    }
                }
            }
            if (Throw)
                throw new InvalidOperationException("No method with the required signature could be found, which means this will fail at runtime.");
            else return base.VisitInvocation(node);
        }




        protected override Expression VisitBlock(BlockExpression node)
        {
            if (node.Expressions.Count == 2 && node.Expressions[0].NodeType == ExpressionType.DebugInfo)
                return node.Expressions[1];
            else return node;
        }

    }


}

