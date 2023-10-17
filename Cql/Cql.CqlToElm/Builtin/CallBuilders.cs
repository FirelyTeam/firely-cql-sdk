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
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Hl7.Cql.CqlToElm.Builtin
{
    internal record CallBuilderResult(FunctionDef Def, Expression Result, int Cost, string? Error)
    {
        public bool Success => Error is null;

        public static implicit operator Expression(CallBuilderResult result) =>
            result.Success ?
                result.Result
                : throw new InvalidOperationException($"Failed to bind to {operatorType(result.Def.operand.Length)} '{result.Def.name}' - {result.Error}");

        private static string operatorType(int numArgs)
        {
            return numArgs switch
            {
                0 => "definition",
                1 => "unary operator",
                2 => "binary operator",
                3 => "ternary operator",
                _ => "function"
            };
        }

        public CallBuilderResult Or(CallBuilderResult other)
        {
            if (!Success && other.Success)
                return other;
            else if (Success && !other.Success)
                return this;

            return Cost <= other.Cost ? this : other;
        }

        public static CallBuilderResult Combine(IEnumerable<CallBuilderResult> results)
        {
            var first = results.FirstOrDefault() ?? throw new InvalidOperationException("Combine should be called with at least one result.");

            var bestCandidates = results.Where(r => r.Success).OrderBy(r => r.Cost).GroupBy(r => r.Cost).FirstOrDefault()?.AsEnumerable().ToList();

            return bestCandidates switch
            {
                null => first with { Error = $"No matching overload found." },
                [var one] => one,
                var many => new(first.Def, first.Result, 0, $"Ambiguous call to {first.Def.name}.")
            };
        }
    }

    internal static class CallBuilders
    {
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

        public static CallBuilderResult Call(this BuiltInFunctionDef def, IModelProvider provider, ParserRuleContext context, params Expression[] arguments)
        {
            var castResult = autoCastParams(def, arguments, provider);
            var expr = def.CreateElmNode(castResult.Casters)
                    .WithResultType(castResult.ReturnType).WithLocator(context.Locator());

            return new CallBuilderResult(def, expr, castResult.Cost, castResult.Error);
        }

        public static CallBuilderResult Call(this BuiltInFunctionDef[] def, IModelProvider provider, ParserRuleContext context, params Expression[] arguments)
        {
            return CallBuilderResult.Combine(def.Select(d => d.Call(provider, context, arguments)));            
        }

        public static Expression Build(this BuiltInFunctionDef def, ParserRuleContext context, params Expression[] arguments)
        {
            return def.CreateElmNode(arguments)
                    .WithResultType(def.resultTypeSpecifier).WithLocator(context.Locator());
        }

        public static As Call(this AsFunctionDef _, bool strict, TypeSpecifier typeArgument, Expression argument, ParserRuleContext context)
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

        public static Is Call(this IsFunctionDef _, TypeSpecifier typeArgument, Expression argument, ParserRuleContext context)
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

        public static MinValue Call(this MinValueFunctionDef _, NamedTypeSpecifier typeArgument, ParserRuleContext context)
        {
            return new MinValue()
            {
                valueType = typeArgument.name,
            }.WithResultType(typeArgument).WithLocator(context.Locator());
        }

        public static MaxValue Call(this MaxValueFunctionDef _, NamedTypeSpecifier typeArgument, ParserRuleContext context)
        {
            return new MaxValue()
            {
                valueType = typeArgument.name,
            }.WithResultType(typeArgument).WithLocator(context.Locator());
        }

        private static FunctionMatchResult autoCastParams(FunctionDef def, Expression[] arguments, IModelProvider provider)
        {
            var castBuilder = new CastBuilder(provider);
            return castBuilder.Build(def, arguments);
        }
    }
}