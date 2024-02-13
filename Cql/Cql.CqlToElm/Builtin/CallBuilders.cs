﻿/* 
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
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Hl7.Cql.CqlToElm.Builtin
{
    internal static class CallBuilders
    {
        /// <summary>
        /// Uses the <see cref="SystemFunction{T}"/> to create an <see cref="Expression"/> for the invocation of that
        /// function with the given arguments. If arguments need to be cast first, it will attempt to do so.
        /// </summary>
        [DebuggerStepThrough]
        public static Expression Call(this FunctionDef def, InvocationBuilder builder, ParserRuleContext? context, params Expression[] arguments)
        {
            var callResult = buildCall(def, builder, context, arguments);
            return callResult switch
            {
                { Error: null, Expression: var e } => e.expr,
                { Error: not null, Expression: var e } => e.expr.AddError(callResult.Error),
            };
        }

        [DebuggerStepThrough]
        public static Expression Call(this OverloadedFunctionDef def,
            InvocationBuilder builder,
            ParserRuleContext? context,
            Expression[] arguments,
            out FunctionDef? selectedOverload)
        {
            var callResult = buildCall(def, builder, context, arguments, out selectedOverload);
            return callResult switch
            {
                { Error: null, Expression: var e } => e.expr,
                { Error: not null, Expression: var e } => e.expr.AddError(callResult.Error),
            };
        }

        private static ConversionResult<(Expression expr, FunctionDef def)> buildCall(this FunctionDef def, InvocationBuilder builder, ParserRuleContext? context, params Expression[] arguments)
        {
            var castResult = buildInvocation(def, arguments, builder);
            var elmNode = castResult.Expression;
            if (context is not null)
                elmNode = elmNode.WithLocator(context.Locator());
            return new((elmNode, def), castResult.Cost, castResult.Errors);
        }

        private static ConversionResult<(Expression expr, FunctionDef def)> buildCall(this OverloadedFunctionDef def,
            InvocationBuilder builder,
            ParserRuleContext? context,
            Expression[] arguments,
            out FunctionDef? selectedOverload)
        {
            var groupByCostLowestFirst = def.Functions
                .Select(f => (Function: f, Result: buildInvocation(f, arguments, builder)))
                .Where(t => t.Result.Success)
                .GroupBy(t => t.Result.Cost)
                .OrderBy(g => g.Key)
                .ToArray();
            // Presumably, the the best match has the lowest cost.
            // If there is more than overload with the same cost, the call is ambiguous.
            if (groupByCostLowestFirst.Length > 0)
            {
                var successfulMatches = groupByCostLowestFirst[0].ToArray();
                if (successfulMatches.Length == 1)
                {
                    var result = successfulMatches[0].Result;
                    var node = result.Expression;
                    var function = successfulMatches[0].Function;
                    if (context is not null)
                        node = node.WithLocator(context.Locator());
                    selectedOverload = successfulMatches[0].Function;
                    return new((node, function), result.Cost, result.Errors);
                }
                else if (successfulMatches.Length > 1) // Ambiguous
                {
                    var argTypeString = string.Join(", ", arguments.Select(a => a.resultTypeSpecifier.ToString()));
                    // match cql-to-elm reference implementation (Java) error messages
                    var errorSb = new StringBuilder();
                    errorSb.AppendLine(CultureInfo.InvariantCulture, $"Call to operator {def.Name}({argTypeString}) is ambiguous with:");
                    foreach (var match in successfulMatches)
                    {
                        var matchTypeString = string.Join(", ", match.Function.operand.Select(od => od.resultTypeSpecifier.ToString()));
                        errorSb.AppendLine(CultureInfo.InvariantCulture, $"\t- {def.Name}({matchTypeString})");
                    }
                    var error = errorSb.ToString();
                    var result = successfulMatches[0].Result;
                    var node = result.Expression;
                    var function = successfulMatches[0].Function;
                    if (context is not null)
                        node = node.WithLocator(context.Locator());
                    selectedOverload = null;
                    return new((node, function), ConversionCost.Incompatible, error);
                }
            }
            // need an overload to fail on
            var firstInvocation = buildInvocation(def.Functions[0], arguments, builder);
            var errorNode = firstInvocation.Expression;
            var unresolved = $"Could not resolve call to operator {def.Name} with signature({string.Join(", ", arguments.Select(t => t.resultTypeSpecifier.ToString()))}).";
            if (context is not null)
                errorNode = errorNode.WithLocator(context.Locator());
            selectedOverload = null;
            return new((errorNode, def.Functions[0]), ConversionCost.Incompatible, unresolved);
        }

        public static If Call(this SystemFunction<If> def, TypeConverter converter, ParserRuleContext context, Expression condition, Expression thenExpression, Expression elseExpression)
        {
            var ifNode = (If)def.CreateElmNode();

            var ifCastResult = converter.Convert(condition, SystemTypes.BooleanType);

            ifNode.condition = ifCastResult.Expression;
            if (ifCastResult.Error is not null)
                ifNode.AddError("The condition " + ifCastResult.Error);

            TypeSpecifier expressionType;

            // First, try to see whether the then expressions can be cast to the type of the else expression.
            var thenCastResult = converter.Convert(thenExpression, elseExpression.resultTypeSpecifier);

            if (thenCastResult.Success)
            {
                ifNode.then = thenCastResult.Expression;
                ifNode.@else = elseExpression;
                expressionType = elseExpression.resultTypeSpecifier;
            }
            else
            {
                // If that fails, try to see whether the else expression can be cast to the type of the then expression.
                var elseCastResult = converter.Convert(elseExpression, thenExpression.resultTypeSpecifier);

                if (elseCastResult.Success)
                {
                    ifNode.then = thenExpression;
                    ifNode.@else = elseCastResult.Expression;
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

        public static Case Call(this SystemFunction<Case> def,
            InvocationBuilder builder,
            ParserRuleContext context,
            Expression? comparand,
            CaseItem[] caseItems,
            Expression @else)
        {
            var @case = (Case)def.CreateElmNode();
            @case.comparand = comparand;
            if (caseItems.Length < 1)
            {
                @case.AddError($"At least one case item must exist in a case statement");
                return @case;
            }
            @case.caseItem = caseItems;
            @case.@else = @else;
            return @case
                .WithResultType(@else.resultTypeSpecifier)
                .WithLocator(context.Locator());
        }

        /// <summary>
        /// Uses the <see cref="SystemFunction{T}"/> to create an <see cref="Expression"/> for the invocation of that
        /// function with the given arguments. It will not attempt to cast the arguments to the parameters of the function.
        /// </summary>
        public static Expression Build(this FunctionDef def, ParserRuleContext context, params Expression[] arguments)
        {
            return def.CreateElmNode(arguments)
                    .WithResultType(def.resultTypeSpecifier).WithLocator(context.Locator());
        }

        public static As Build(this SystemFunction<As> _, bool strict, TypeSpecifier typeArgument, Expression argument, ParserRuleContext context)
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

        public static Is Build(this SystemFunction<Is> _, TypeSpecifier typeArgument, Expression argument, ParserRuleContext context)
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

        public static MinValue Build(this SystemFunction<MinValue> _, NamedTypeSpecifier typeArgument, ParserRuleContext context)
        {
            return new MinValue()
            {
                valueType = typeArgument.name,
            }.WithResultType(typeArgument).WithLocator(context.Locator());
        }

        public static MaxValue Build(this SystemFunction<MaxValue> _, NamedTypeSpecifier typeArgument, ParserRuleContext context)
        {
            return new MaxValue()
            {
                valueType = typeArgument.name,
            }.WithResultType(typeArgument).WithLocator(context.Locator());
        }

        [DebuggerStepThrough]
        private static ConversionResult<Expression> buildInvocation(FunctionDef def, Expression[] arguments, InvocationBuilder builder) =>
            builder.Build(def, arguments);

        /// <summary>
        /// Given a <see cref="FunctionDef"/>, creates an <see cref="Expression"/> for the invocation with the
        /// operands initialized to the arguments given.
        /// </summary>
        // TODO: consider a factory pattern here
        internal static Expression CreateElmNode(this FunctionDef def, params Expression[] arguments)
        {
            var nodeType = def is SystemFunction b ? b.ElmNodeType : typeof(FunctionRef);
            var result = Activator.CreateInstance(nodeType)!;
            if (result is BinaryExpression be)
            {
                if (result is IHasPrecision hp)
                {
                    if (arguments.Length > 2 && arguments[2] is Literal literal)
                    {
                        if (Enum.TryParse<DateTimePrecision>(literal.value, out var precision))
                        {
                            hp.precision = precision;
                            hp.precisionSpecified = true;
                        }
                        else throw new ArgumentException($"Expected argument 3 to be a string literal representing precision.");
                    }
                    be.operand = new[] { arguments[0], arguments[1] };
                }
                else if (arguments.Length != 2)
                    throw new ArgumentException($"Expected 2 arguments, but got {arguments.Length}.", nameof(arguments));
                else be.operand = arguments;
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
            else if (result is Round rnd)
            {
                rnd.operand = arguments[0];
                if (arguments.Length > 1)
                    rnd.precision = arguments[1];
                return rnd;
            }
            else if (result is Message msg)
            {
                msg.source = arguments[0];
                msg.condition = arguments[1];
                msg.code = arguments[2];
                msg.severity = arguments[3];
                msg.message = arguments[4];
                return msg;
            }
            else if (result is First f)
            {
                f.source = arguments[0];
                return f;
            }
            else if (result is Last l)
            {
                l.source = arguments[0];
                return l;
            }
            else if (result is IndexOf io)
            {
                io.source = arguments[0];
                return io;
            }
            else if (result is Slice slice) 
            {
                slice.source = arguments[0];
                // slice is used for Skip, Take & Tail functions.  there isn't a function called Slice
                if (def.name == nameof(SystemLibrary.Skip))
                {
                    slice.startIndex = arguments[1];
                    slice.endIndex = new Null().WithResultType(SystemTypes.IntegerType);
                }
                else if (def.name == nameof(SystemLibrary.Take))
                {
                    slice.startIndex = new Literal { value = "0" }.WithResultType(SystemTypes.IntegerType);
                    slice.endIndex = arguments[0];
                }
                if (def.name == nameof(SystemLibrary.Tail))
                {
                    slice.startIndex = new Literal { value = "1" }.WithResultType(SystemTypes.IntegerType);
                    slice.endIndex = new Null().WithResultType(SystemTypes.IntegerType);
                }
                return slice;
            }
            else if (result is Descendents desc)
            {
                desc.source = arguments[0];
                return desc;
            }
            else if (result is Combine combine)
            {
                combine.source = arguments[0];
                if (arguments.Length > 1)
                    combine.separator = arguments[1];
                return combine;
            }
            else if (result is LastPositionOf lpo)
            {
                lpo.@string = arguments[0];
                lpo.pattern = arguments[1];
                return lpo;
            }
            else if (result is PositionOf po)
            {
                po.@string = arguments[0];
                po.pattern = arguments[1];
                return po;
            }
            else if (result is Split sp)
            {
                sp.stringToSplit = arguments[0];
                sp.separator = arguments[1];
                return sp;
            }
            else if (result is Substring ss)
            {
                ss.stringToSub = arguments[0];
                ss.startIndex = arguments[1];
                if (arguments.Length > 2)
                    ss.length = arguments[2];
                return ss;
            }
            else if (result is FunctionRef fr)
            {
                fr.name = def.name;
                fr.operand = arguments;
                return fr;
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