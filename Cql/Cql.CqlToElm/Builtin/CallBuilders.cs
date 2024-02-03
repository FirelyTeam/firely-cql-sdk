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
        public static Expression Call(this FunctionDef def, IModelProvider provider, ParserRuleContext? context, params Expression[] arguments)
        {
            var callResult = buildCall(def, provider, context, arguments);

            return callResult switch
            {
                { Error: null, Result: var e } => e.expr,
                { Error: not null, Result: var e } => e.expr.AddError(callResult.Error),
            };
        }

        public static Expression Call(this OverloadedFunctionDef def, 
            IModelProvider provider, 
            ParserRuleContext? context, 
            Expression[] arguments,
            out FunctionDef? selectedOverload)
        {
            var callResult = buildCall(def, provider, context, arguments, out selectedOverload);

            return callResult switch
            {
                { Error: null, Result: var e } => e.expr,
                { Error: not null, Result: var e } => e.expr.AddError(callResult.Error),
            };
        }

        private static ResolveResult<(Expression expr, FunctionDef def)> buildCall(this FunctionDef def, IModelProvider provider, ParserRuleContext? context, params Expression[] arguments)
        {
            var castResult = buildInvocation(def, arguments, provider);
            var elmNode = castResult.Result;
            if (context is not null)
                elmNode = elmNode.WithLocator(context.Locator());
            return new((elmNode, def), castResult.Cost, castResult.Error);
        }

        private static ResolveResult<(Expression expr, FunctionDef def)> buildCall(this OverloadedFunctionDef def, 
            IModelProvider provider, 
            ParserRuleContext? context,             
            Expression[] arguments,
            out FunctionDef? selectedOverload)
        {
            ResolveResult<Expression>? castResult = null;
            foreach (var fd in def.Functions)
            {
                castResult = buildInvocation(fd, arguments, provider);
                if (castResult.Success)
                {
                    var node = castResult.Result;
                    if (context is not null)
                        node = node.WithLocator(context.Locator());
                    selectedOverload = fd;
                    return new((node, fd), castResult.Cost, castResult.Error);
                }
            }
            if (castResult != null)
            {
                var errorNode = castResult.Result;
                if (context is not null)
                    errorNode = errorNode.WithLocator(context.Locator());
                selectedOverload = null;
                return new((errorNode, def.Functions[0]), castResult.Cost, castResult.Error);
            }
            else throw new InvalidOperationException($"Unable to build call for {nameof(OverloadedFunctionDef)}."); // should never happen
        }

        /// <summary>
        /// Choses the best matching overload of a set of <see cref="BuiltInFunctionDef"/> to create an <see cref="Expression"/> for the 
        /// invocation, given the types of the arguments. If arguments need to be cast first, it will attempt to do so.
        /// </summary>
        public static Expression Call(this IEnumerable<FunctionDef> defs, IModelProvider provider, ParserRuleContext context, params Expression[] arguments)
        {
            var results = defs.Select(d => buildCall(d, provider, context, arguments)).ToList();
            if (!results.Any()) throw new ArgumentException("Should be called with at least one overload.", nameof(defs));

            var success = results.Any(r => r.Success);

            var bestCandidates = results
                .OrderBy(r => r.Cost)
                .GroupBy(r => r.Cost)
                .First()
                .AsEnumerable()
                .ToList();

            return bestCandidates switch
            {
                [var one] when success => one.Result.expr,
                [var one] when !success => one.Result.expr.AddError(one.Error!),
                var many when success => many.First().Result.expr.AddError($"Ambiguous call between {listSignatures(many.Select(m => m.Result.def))}."),
                var many when !success => many.First().Result.expr.AddError($"No matching overload found between {listSignatures(many.Select(m => m.Result.def))}."),
                _ => throw new InvalidOperationException("Should not be possible.")
            };

            static string listSignatures(IEnumerable<FunctionDef> defs) =>
                string.Join(", ", defs.Select(def => def.Signature()));
        }

        public static If Call(this IfFunctionDef def, InvocationBuilder builder, ParserRuleContext context, Expression condition, Expression thenExpression, Expression elseExpression)
        {
            var ifNode = (If)def.CreateElmNode();

            var ifCastResult = builder.BuildImplicitCast(condition, SystemTypes.BooleanType, out var _);

            ifNode.condition = ifCastResult.Result;
            if (ifCastResult.Error is not null)
                ifNode.AddError("The condition " + ifCastResult.Error);

            TypeSpecifier expressionType;

            // First, try to see whether the then expressions can be cast to the type of the else expression.
            var thenCastResult = builder.BuildImplicitCast(thenExpression, elseExpression.resultTypeSpecifier, out var _);

            if (thenCastResult.Success)
            {
                ifNode.then = thenCastResult.Result;
                ifNode.@else = elseExpression;
                expressionType = elseExpression.resultTypeSpecifier;
            }
            else
            {
                // If that fails, try to see whether the else expression can be cast to the type of the then expression.
                var elseCastResult = builder.BuildImplicitCast(elseExpression, thenExpression.resultTypeSpecifier, out var _);

                if (elseCastResult.Success)
                {
                    ifNode.then = thenExpression;
                    ifNode.@else = elseCastResult.Result;
                    expressionType = thenExpression.resultTypeSpecifier;
                }
                else
                {
                    // Failing both, we have to cast both expressions to a common type, which is a choice of both types.
                    var choiceType = new ChoiceTypeSpecifier(thenExpression.resultTypeSpecifier, elseExpression.resultTypeSpecifier);
                    ifNode.then = SystemLibrary.As.Build(strict: false, choiceType, thenExpression, context);
                    ifNode.@else = SystemLibrary.As.Build(strict: false, choiceType, elseExpression, context);
                    expressionType = choiceType;
                }
            }

            return ifNode.WithResultType(expressionType).WithLocator(context.Locator());
        }

        public static Case Call(this CaseFunctionDef def,
            InvocationBuilder builder,
            ParserRuleContext context,
            CaseItem[] caseItems,
            Expression @else)
        {
            var @case = (Case)def.CreateElmNode();
            if (caseItems.Length < 1)
            {
                @case.AddError($"At least one case item must exist in a case statement");
                return @case;
            }


            var type = caseItems[0].resultTypeSpecifier;
            var choiceTypes = new HashSet<TypeSpecifier>(caseItems.Length) { type };

            foreach(var caseItem in caseItems)
            {
                var when = caseItem.when;
                var whenCastResult = builder.BuildImplicitCast(when, SystemTypes.BooleanType, out var _);
                if (whenCastResult.Success)
                {
                    caseItem.when = whenCastResult.Result;
                }
                else caseItem.AddError($"Condition could not be converted to a boolean expression");

                var then = caseItem.then;
                var thenCastResult = builder.BuildImplicitCast(then, type, out var _);
                if (thenCastResult.Success)
                {
                    caseItem.then = thenCastResult.Result;
                }
                else if (!choiceTypes.Contains(then.resultTypeSpecifier))
                {
                    if (!choiceTypes.Contains(then.resultTypeSpecifier))
                        choiceTypes.Add(then.resultTypeSpecifier);
                }
            }
            var elseCastResult = builder.BuildImplicitCast(@else, type, out var _);
            if (elseCastResult.Success)
            {
                @else = elseCastResult.Result;
            }
            else
            {
                choiceTypes.Add(@else.resultTypeSpecifier);
            }

            if (choiceTypes.Count > 1)
            {
                type = new ChoiceTypeSpecifier(choiceTypes);
                foreach(var caseItem in caseItems)
                {
                    caseItem.then.resultTypeSpecifier = type;
                    caseItem.resultTypeSpecifier = type;
                }
                @else.resultTypeSpecifier = type;
            }

            @case.caseItem = caseItems;
            @case.@else = @else;
            return @case
                .WithResultType(type)
                .WithLocator(context.Locator());
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

        private static ResolveResult<Expression> buildInvocation(FunctionDef def, Expression[] arguments, IModelProvider provider)
        {
            var castBuilder = new InvocationBuilder(provider);
            return castBuilder.Build(def, arguments);
        }

        /// <summary>
        /// Given a <see cref="FunctionDef"/>, creates an <see cref="Expression"/> for the invocation with the
        /// operands initialized to the arguments given.
        /// </summary>
        internal static Expression CreateElmNode(this FunctionDef def, params Expression[] arguments)
        {
            var nodeType = def is BuiltInFunctionDef b ? b.ElmNodeType : typeof(FunctionRef);
            var result = Activator.CreateInstance(nodeType)!;

            if (result is BinaryExpression be)
            {
                if (arguments.Length != 2)
                    throw new ArgumentException($"Expected 2 arguments, but got {arguments.Length}.", nameof(arguments));
                be.operand = arguments;
                return be;
            }
            else if (result is UnaryExpression ue)
            {
                if (arguments.Length != 1)
                    throw new ArgumentException($"Expected 1 argument, but got {arguments.Length}.", nameof(arguments));
                ue.operand = arguments[0];
                return ue;
            }
            else if (result is TernaryExpression te)
            {
                if (arguments.Length != 3)
                    throw new ArgumentException($"Expected 3 arguments, but got {arguments.Length}.", nameof(arguments));
                te.operand = arguments;
                return te;
            }
            else if (result is NaryExpression ne)
            {
                ne.operand = arguments;
                return ne;
            }
            else if (result is AggregateExpression ae)
            {
                if (arguments.Length != 1)
                    throw new ArgumentException($"Expected 1 argument, but got {arguments.Length}.", nameof(arguments));
                ae.source = arguments[0];
                return ae;
            }
            else if (result is FunctionRef fr)
            {
                fr.name = def.name;
                fr.operand = arguments;
                return fr;
            }
            else if (result is Date d)
            {
                if (arguments.Length > 0)
                    d.year = arguments[0];
                if (arguments.Length > 1)
                    d.month = arguments[1];
                if (arguments.Length > 2)
                    d.day = arguments[2];
                return d;
            }
            else if (result is Elm.DateTime dt)
            {
                if (arguments.Length > 0)
                    dt.year = arguments[0];
                if (arguments.Length > 1)
                    dt.month = arguments[1];
                if (arguments.Length > 2)
                    dt.day = arguments[2];
                if (arguments.Length > 3)
                    dt.hour = arguments[3];
                if (arguments.Length > 4)
                    dt.minute = arguments[4];
                if (arguments.Length > 5)
                    dt.second = arguments[5];
                if (arguments.Length > 6)
                    dt.millisecond = arguments[6];
                if (arguments.Length > 7)
                    dt.timezoneOffset = arguments[7];
                return dt;
            }
            else if (result is Time t)
            {
                if (arguments.Length > 0)
                    t.hour = arguments[0];
                if (arguments.Length > 1)
                    t.minute = arguments[1];
                if (arguments.Length > 2)
                    t.second = arguments[2];
                if (arguments.Length > 3)
                    t.millisecond = arguments[3];
                return t;
            }
            else if (result is Expression e && arguments.Length == 0)
            {
                return e;
            }
            else
                throw new InvalidOperationException($"Don't know how to initialize an instance of {nodeType}.");
        }
    }
}