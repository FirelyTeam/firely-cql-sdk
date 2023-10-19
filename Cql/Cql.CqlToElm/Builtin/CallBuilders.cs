/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Antlr4.Runtime;
using Hl7.Cql.Elm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Hl7.Cql.CqlToElm.Builtin
{
    internal static class CallBuilders
    {
        /// <summary>
        /// Uses the <see cref="BuiltInFunctionDef"/> to create an <see cref="Expression"/> for the invocation of that
        /// function with the given arguments. If arguments need to be cast first, it will attempt to do so.
        /// </summary>
        public static FunctionResolveResult Call(this FunctionDef def, IModelProvider provider, SystemLibrary library, ParserRuleContext context, params Expression[] arguments)
        {
            var castResult = buildInvocation(def, arguments, provider, library);
            
            return castResult with 
            { 
                Call = castResult.Call.WithLocator(context.Locator()) 
            };
        }

        /// <summary>
        /// Choses the best matching overload of a set of <see cref="BuiltInFunctionDef"/> to create an <see cref="Expression"/> for the 
        /// invocation, given the types of the arguments. If arguments need to be cast first, it will attempt to do so.
        /// </summary>
        public static FunctionResolveResult Call(this IEnumerable<FunctionDef> defs, IModelProvider provider, SystemLibrary library, ParserRuleContext context, params Expression[] arguments)
        {
            var results = defs.Select(d => (def: d, call: Call(d,provider, library, context, arguments))).ToList();            
            if(!results.Any()) throw new ArgumentException("Should be called with at least one overload.", nameof(defs));

            var bestCandidates = results
                .Where(r => r.call.Success)
                .OrderBy(r => r.call.Cost)
                .GroupBy(r => r.call.Cost)
                .FirstOrDefault()
                ?.AsEnumerable()
                .ToList();

            return bestCandidates switch
            {
                null => new(results.First().call.Call, int.MaxValue, listErrors(results.Select(r => r.call).ToList())),
                [var one] => one.call,
                var many => new(many.First().call.Call, int.MaxValue, $"Ambiguous call between {listSignatures(many.Select(m => m.def))}.")
            };

            static string listSignatures(IEnumerable<FunctionDef> defs) =>
                string.Join(", ", defs.Select(def => def.Signature()));

            static string listErrors(List<FunctionResolveResult> errorResults)
            {
                if(errorResults.Count == 1) 
                    return errorResults[0].Error!;
                else
                    return "No matching overload found: " + 
                        string.Join(Environment.NewLine, errorResults.Select(e => $"  {e.Error!}"));
            }
        }

        /// <summary>
        /// Uses the <see cref="BuiltInFunctionDef"/> to create an <see cref="Expression"/> for the invocation of that
        /// function with the given arguments. It will not attempt to cast the arguments to the parameters of the function.
        /// </summary>
        public static Expression Build(this FunctionDef def, ParserRuleContext context, params Expression[] arguments)
        {
            return def.CreateElmNode(arguments)
                    .WithResultType(def.resultTypeSpecifier).WithLocator(context.Locator());
        }

        public static As Build(this AsFunctionDef _, bool strict, TypeSpecifier typeArgument, Expression argument, ParserRuleContext context)
        {
            // Note that there is no automatic casting done here:
            // I *think* `{ true } is Boolean` should be false, even though `{ true }` can be demoted to `Boolean`,
            // otherwise, testing for `Boolean` would be impossible. Maybe we should clarify the CQL spec to say
            // that `cast as` and also `is` are not subject to automatic promotion.
            return new As()
            {
                strict = strict,
                operand = argument,
                asTypeSpecifier = typeArgument,
                asType = typeArgument.TryToQualifiedName()
            }.WithResultType(typeArgument).WithLocator(context.Locator());
        }

        public static Is Build(this IsFunctionDef _, TypeSpecifier typeArgument, Expression argument, ParserRuleContext context)
        {
            // Note that there is no automatic casting done here:
            // I *think* `{ true } is Boolean` should be false, even though `{ true }` can be demoted to `Boolean`,
            // otherwise, testing for `Boolean` would be impossible. Maybe we should clarify the CQL spec to say
            // that `cast as` and also `is` are not subject to automatic promotion.
            return new Is()
            {
                operand = argument,
                isTypeSpecifier = typeArgument,
                isType = typeArgument.TryToQualifiedName()
            }.WithResultType(typeArgument).WithLocator(context.Locator());
        }

        public static MinValue Build(this MinValueFunctionDef _, NamedTypeSpecifier typeArgument, ParserRuleContext context)
        {
            return new MinValue()
            {
                valueType = typeArgument.name,
            }.WithResultType(typeArgument).WithLocator(context.Locator());
        }

        public static MaxValue Build(this MaxValueFunctionDef _, NamedTypeSpecifier typeArgument, ParserRuleContext context)
        {
            return new MaxValue()
            {
                valueType = typeArgument.name,
            }.WithResultType(typeArgument).WithLocator(context.Locator());
        }

        private static FunctionResolveResult buildInvocation(FunctionDef def, Expression[] arguments, IModelProvider provider, SystemLibrary library)
        {
            var castBuilder = new InvocationBuilder(provider, library);
            return castBuilder.Build(def, arguments);
        }

                /// <summary>
        /// Given a <see cref="FunctionDef"/>, creates an <see cref="Expression"/> for the invocation with the
        /// operands initialized to the arguments given.
        /// </summary>
        internal static Expression CreateElmNode(this FunctionDef def, Expression[] arguments)
        {
            var nodeType = def is BuiltInFunctionDef b ? b.ElmNodeType : typeof(FunctionRef);
            var result = Activator.CreateInstance(nodeType)!;

            if(result is BinaryExpression be)
            {
                if(arguments.Length != 2)
                    throw new ArgumentException($"Expected 2 arguments, but got {arguments.Length}", nameof(arguments));
                be.operand = arguments;
                return be;
            }
            else if(result is UnaryExpression ue)
            {
                if(arguments.Length != 1)
                    throw new ArgumentException($"Expected 1 argument, but got {arguments.Length}", nameof(arguments));
                ue.operand = arguments[0];
                return ue;
            }
            else if(result is TernaryExpression te)
            {
                if(arguments.Length != 3)
                    throw new ArgumentException($"Expected 3 arguments, but got {arguments.Length}", nameof(arguments));
                te.operand = arguments;
                return te;
            }
            else if(result is NaryExpression ne)
            {
                ne.operand = arguments;
                return ne;
            }
            else if(result is FunctionRef fr)
            {
                fr.operand = arguments;
                return fr;
            }
            else if(result is Expression e && arguments.Length == 0)
            {
                return e;
            }
            else
                throw new InvalidOperationException($"Don't know how to initialize an instance of {nodeType}.");
        }        
    }
}