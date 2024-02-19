using Hl7.Cql.CqlToElm.Builtin;
using Hl7.Cql.Elm;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Configuration.Assemblies;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Hl7.Cql.CqlToElm
{


    /// <summary>
    /// Builds the implicit casts described in the CQL spec. Given the type of the parameter and an expression 
    /// representing the argument at the call site, this class will the necessary chain of nested expressions
    /// to implement the implicit casts.
    /// 
    /// See https://cql.hl7.org/03-developersguide.html#conversion-precedence
    /// </summary>
    internal class InvocationBuilder
    {
        public IModelProvider Provider { get; }
        public TypeConverter TypeConverter { get; }

        public InvocationBuilder(IModelProvider provider, TypeConverter typeConverter)
        {
            Provider = provider;
            TypeConverter = typeConverter;
        }

        /// <summary>
        /// Invokes a system function.
        /// </summary>
        /// <param name="systemFunction">The system function to invoke.</param>
        /// <param name="arguments">The arguments to invoke.</param>
        /// <returns>The invocation of this system function.</returns>
        internal Expression Invoke(SystemFunction systemFunction, params Expression[] arguments)
        {
            var result = MatchSignature(systemFunction, arguments);
            var newArguments = result.Arguments
                .Select(cr => cr.Result)
                .ToArray();
            var expression = CreateElmNode(systemFunction, null, newArguments);
            if (!result.Compatible)
                expression.AddError(result.Error ?? result.Function.GetUnresolvedOperatorMessage(arguments));
            expression = systemFunction.Validate(expression);
            var newResultType = ReplaceGenericTypes(systemFunction.resultTypeSpecifier, result.GenericInferences);
            return expression
                .WithResultType(newResultType);
        }

        /// <summary>
        /// Invokes an overloaded function.
        /// </summary>
        /// <param name="overloadedFunction">The overloaded function to invoke.</param>
        /// <param name="arguments">The arguments to invoke.</param>
        /// <returns>The invocation of the best-matching overload.</returns>
        internal Expression Invoke(OverloadedFunctionDef overloadedFunction, params Expression[] arguments)
        {
            var result = SelectBestOverload(overloadedFunction, arguments);
            var newArguments = result.Arguments
                .Select(cr => cr.Result)
                .ToArray();
            var expression = CreateElmNode(result.Function, null, newArguments);
            if (!result.Compatible)
                expression.AddError(result.Error ?? result.Function.GetUnresolvedOperatorMessage(arguments));
            if (result.Function is SystemFunction systemFunction)
                expression = systemFunction.Validate(expression);
            var newResultType = ReplaceGenericTypes(result.Function.resultTypeSpecifier, result.GenericInferences);
            return expression
                .WithResultType(newResultType);
        }

        /// <summary>
        /// Invokes a user defined function.
        /// </summary>
        /// <param name="function">The overloaded function to invoke.</param>
        /// <param name="library">The libary in which this function is defined, or <see langword="null"/> if the function is colocated within the same library as the invocation site.</param>
        /// <param name="arguments">The arguments to invoke.</param>
        /// <returns>The invocation of the best-matching overload.</returns>
        internal Expression Invoke(FunctionDef function, string? library, params Expression[] arguments)
        {
            var result = MatchSignature(function, arguments);
            var newArguments = result.Arguments
                .Select(cr => cr.Result)
                .ToArray();
            var expression = CreateElmNode(function, null, newArguments);
            if (!result.Compatible)
                expression.AddError(result.Error ?? result.Function.GetUnresolvedOperatorMessage(arguments));
            var newResultType = ReplaceGenericTypes(function.resultTypeSpecifier, result.GenericInferences);
            return expression
                .WithResultType(newResultType);
        }

        private Expression CreateElmNode(FunctionDef function, string? library, Expression[] arguments)
        {
            var nodeType = function is SystemFunction b ? b.ElmNodeType : typeof(FunctionRef);
            Expression result = (Expression)Activator.CreateInstance(nodeType)!;
            result = result switch
            {
                AggregateExpression ae => Populate(ae, arguments),
                Combine combine => Populate(combine, arguments),
                BinaryExpression be => Populate(be, arguments),
                Date d => Populate(d, arguments),
                Elm.DateTime dt => Populate(dt, arguments),
                Expression e when arguments.Length == 0 => e,
                FunctionRef fr => Populate(function, library, fr, arguments),
                IHasSource ihs => (Expression)Populate(ihs, arguments),
                LastPositionOf lpo => Populate(lpo, arguments),
                Message msg => Populate(msg, arguments),
                NaryExpression ne => Populate(ne, arguments),
                PositionOf po => Populate(po, arguments),
                Slice slice => Populate(function, slice, arguments),
                Split split => Populate(split, arguments),
                Substring sub => Populate(sub, arguments),
                TernaryExpression te => Populate(te, arguments),
                Time time => Populate(time, arguments),
                UnaryExpression ue => Populate(ue, arguments),
                _ => throw new InvalidOperationException($"Cannot convert {result.GetType()} to {typeof(Expression)}")
            };
            return result;
        }

        internal Expression If(Expression condition, Expression then, Expression @else)
        {
            var @if = new If();                
            var convertCondition = TypeConverter.Convert(condition, SystemTypes.BooleanType);
            if (convertCondition.Success)
                condition = convertCondition.Result;
            else if (convertCondition.Error is not null)
                @if.AddError(convertCondition.Error);

            var convertThenToElse = TypeConverter.Convert(then, @else.resultTypeSpecifier);
            var convertElseToThen = TypeConverter.Convert(@else, then.resultTypeSpecifier);
            var compatible = true;
            if (convertThenToElse.Cost < convertElseToThen.Cost)
            {
                if (convertThenToElse.Cost == ConversionCost.Incompatible)
                    compatible = false;
                else
                    then = convertThenToElse.Result;
            }
            else
            {
                if (convertElseToThen.Cost == ConversionCost.Incompatible)
                    compatible = false;
                else 
                    @else = convertElseToThen.Result;
            }
            if (!compatible)
            {
                var choiceType = new ChoiceTypeSpecifier(then.resultTypeSpecifier, @else.resultTypeSpecifier);
                then = TypeConverter.Convert(then, choiceType).Result; // it will succeed
                @else = TypeConverter.Convert(@else, choiceType).Result; // it will succeed
            }

            @if.condition = condition;
            @if.then = then;
            @if.@else = @else;
            return @if
                .WithResultType(then.resultTypeSpecifier);
        }

        internal Expression Case(Expression? comparand, CaseItem[] caseItems, Expression @else)
        {
            var @case = new Case();
            @case.comparand = comparand;
            if (caseItems.Length < 1)
            {
                @case.AddError($"At least one case item must exist in a case statement");
                return @case;
            }
            @case.caseItem = caseItems;
            @case.@else = @else;
            return @case
                .WithResultType(@else.resultTypeSpecifier);
        }

        internal Expression MinValue(NamedTypeSpecifier type) =>
            new MinValue { valueType = type.name }.WithResultType(type);

        internal Expression MaxValue(NamedTypeSpecifier type) =>
            new MaxValue { valueType = type.name }.WithResultType(type);

        #region Node populators

        internal AggregateExpression Populate(AggregateExpression aggregate, Expression[] arguments)
        {
            if (arguments.Length != 1)
                throw new ArgumentException($"Expected 1 argument, but got {arguments.Length}.", nameof(arguments));
            aggregate.source = arguments[0];
            return aggregate;
        }
        internal BinaryExpression Populate(BinaryExpression binary, Expression[] arguments)
        {
            if (binary is IHasPrecision hp)
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
                binary.operand = new[] { arguments[0], arguments[1] };
            }
            else if (arguments.Length != 2)
                throw new ArgumentException($"Expected 2 arguments, but got {arguments.Length}.", nameof(arguments));
            else binary.operand = arguments;
            return binary;
        }
        internal Combine Populate(Combine combine, Expression[] arguments)
        {
            combine.source = arguments[0];
            if (arguments.Length > 1)
                combine.separator = arguments[1];
            return combine;
        }
        internal Date Populate(Date date, Expression[] arguments)
        {
            if (arguments.Length > 0)
                date.year = arguments[0];
            if (arguments.Length > 1)
                date.month = arguments[1];
            if (arguments.Length > 2)
                date.day = arguments[2];
            return date;
        }
        internal Elm.DateTime Populate(Elm.DateTime dateTime, Expression[] arguments)
        {
            if (arguments.Length > 0)
                dateTime.year = arguments[0];
            if (arguments.Length > 1)
                dateTime.month = arguments[1];
            if (arguments.Length > 2)
                dateTime.day = arguments[2];
            if (arguments.Length > 3)
                dateTime.hour = arguments[3];
            if (arguments.Length > 4)
                dateTime.minute = arguments[4];
            if (arguments.Length > 5)
                dateTime.second = arguments[5];
            if (arguments.Length > 6)
                dateTime.millisecond = arguments[6];
            if (arguments.Length > 7)
                dateTime.timezoneOffset = arguments[7];
            return dateTime;
        }

        internal FunctionRef Populate(FunctionDef function, string? library, FunctionRef @ref, Expression[] arguments)
        {
            @ref.name = function.name;
            @ref.operand = arguments;
            @ref.libraryName = library;
            return @ref;
        }


        internal IHasSource Populate(IHasSource hasSource, Expression[] arguments)
        {
            hasSource.source = arguments[0];
            return hasSource;
        }
        internal LastPositionOf Populate(LastPositionOf lpo, Expression[] arguments)
        {
            lpo.@string = arguments[0];
            lpo.pattern = arguments[1];
            return lpo;
        }

        internal Message Populate(Message message, Expression[] arguments)
        {
            message.source = arguments[0];
            message.condition = arguments[1];
            message.code = arguments[2];
            message.severity = arguments[3];
            message.message = arguments[4];
            return message;
        }
        internal NaryExpression Populate(NaryExpression nary, Expression[] arguments)
        {
            nary.operand = arguments;
            return nary;
        }
        internal PositionOf Populate(PositionOf po, Expression[] arguments)
        {
            po.@string = arguments[0];
            po.pattern = arguments[1];
            return po;
        }
        internal Slice Populate(FunctionDef function, Slice slice, Expression[] arguments)
        {
            slice.source = arguments[0];
            // slice is used for Skip, Take & Tail functions.  there isn't a function called Slice
            if (function.name == nameof(SystemLibrary.Skip))
            {
                slice.startIndex = arguments[1];
                slice.endIndex = new Null().WithResultType(SystemTypes.IntegerType);
            }
            else if (function.name == nameof(SystemLibrary.Take))
            {
                slice.startIndex = new Literal { value = "0" }.WithResultType(SystemTypes.IntegerType);
                slice.endIndex = arguments[0];
            }
            if (function.name == nameof(SystemLibrary.Tail))
            {
                slice.startIndex = new Literal { value = "1" }.WithResultType(SystemTypes.IntegerType);
                slice.endIndex = new Null().WithResultType(SystemTypes.IntegerType);
            }
            return slice;
        }
        internal Split Populate(Split split, Expression[] arguments)
        {
            split.stringToSplit = arguments[0];
            split.separator = arguments[1];
            return split;
        }
        internal Substring Populate(Substring substring, Expression[] arguments)
        {
            substring.stringToSub = arguments[0];
            substring.startIndex = arguments[1];
            if (arguments.Length > 2)
                substring.length = arguments[2];
            return substring;
        }

        internal TernaryExpression Populate(TernaryExpression ternary, Expression[] arguments)
        {
            if (arguments.Length != 3)
                throw new ArgumentException($"Expected 3 arguments, but got {arguments.Length}.", nameof(arguments));
            ternary.operand = arguments;
            return ternary;
        }
        internal Time Populate(Time time, Expression[] arguments)
        {
            if (arguments.Length > 0)
                time.hour = arguments[0];
            if (arguments.Length > 1)
                time.minute = arguments[1];
            if (arguments.Length > 2)
                time.second = arguments[2];
            if (arguments.Length > 3)
                time.millisecond = arguments[3];
            return time;
        }
        internal UnaryExpression Populate(UnaryExpression unary, Expression[] arguments)
        {
            if (unary is IHasPrecision hp && arguments.Length > 1 && arguments[1] is Literal literal)
            {
                if (Enum.TryParse<DateTimePrecision>(literal.value, out var precision))
                {
                    hp.precision = precision;
                    hp.precisionSpecified = true;
                }
                else throw new ArgumentException($"Expected argument 2 to be a string literal representing precision.");
            }
            else if (arguments.Length != 1)
                throw new ArgumentException($"Expected 1 argument, but got {arguments.Length}.", nameof(arguments));
            unary.operand = arguments[0];
            return unary;
        }

        #endregion

        #region Generic inference

        private static readonly System.Collections.ObjectModel.ReadOnlyDictionary<string, TypeSpecifier> EmptyInferences = new(new Dictionary<string, TypeSpecifier>());

        internal SignatureMatchResult MatchSignature(FunctionDef candidate, Expression[] arguments)
        {
            var operands = candidate.operand ?? Array.Empty<OperandDef>();
            var operandTypes = operands.Select(op => op.operandTypeSpecifier).ToArray();
            var flags = SignatureMatchFlags.None;
            int requiredArgumentCount = operands.Length;
            if (candidate is SystemFunction systemFunction && systemFunction.RequiredParameterCount.HasValue)
                requiredArgumentCount = Math.Min(systemFunction.RequiredParameterCount.Value, requiredArgumentCount);
            if (arguments.Length > operands.Length)
                flags |= SignatureMatchFlags.TooManyArguments;
            else if (arguments.Length < requiredArgumentCount)
                flags |= SignatureMatchFlags.TooFewArguments;
            if (flags > SignatureMatchFlags.None)
            {
                var conversionResults = arguments
                    .Select(arg => new ConversionResult<Expression>(arg, ConversionCost.ExactMatch))
                    .ToArray();
                return new SignatureMatchResult(candidate, conversionResults, EmptyInferences, flags);
            }
            // doing this to make debugging easier
            ConversionResult<Expression>[]? newOperands = null;
            IDictionary<string, TypeSpecifier>? genericInferences = null;
            var lowestCost = ConversionCost.Incompatible;
            // For each argument, try to use it for inference.
            // As we go, keep track of which of those inferences results in the cheapest translation cost.
            // We are using max cost here instead of total cost.
            for (int i = 0; i < arguments.Length; i++)
            {
                var inferences = InferGenericArgument(operands[i].operandTypeSpecifier, arguments[i].resultTypeSpecifier);
                if (inferences.Count > 0)
                {
                    var replaced = TryGenericReplacement(operandTypes, arguments, inferences);
                    var mostExpensiveOperand = (ConversionCost)replaced.Max(operand => (int)operand.Cost);
                    if (mostExpensiveOperand < lowestCost)
                    {
                        lowestCost = mostExpensiveOperand;
                        newOperands = replaced;
                        genericInferences = inferences;
                    }
                }
            }
            if (newOperands != null && genericInferences != null)
                return new SignatureMatchResult(candidate, newOperands, genericInferences, flags);
            else
            {
                newOperands = new ConversionResult<Expression>[arguments.Length];
                for(int i = 0; i < arguments.Length; i++)
                {
                    newOperands[i] = TypeConverter.Convert(arguments[i], operandTypes[i]);
                }
                string? error = null;
                if (newOperands.Any(op => op.Cost == ConversionCost.Incompatible))
                    error = candidate.GetUnresolvedOperatorMessage(arguments.Select(arg=>arg.resultTypeSpecifier).ToArray());
                return new SignatureMatchResult(candidate, newOperands, EmptyInferences, default, error);
            }
        }

        // At present we are not going to consider generics with mulitple type arguments, as those do not exist in any system functions.
        // We'll leave the type as Dictionary for now for future proofing
        internal Dictionary<string, TypeSpecifier> InferGenericArgument(TypeSpecifier operandType, TypeSpecifier argumentType) =>
            operandType switch
            {
                GenericTypeSpecifier generic => new() { { generic.typeArgumentName, argumentType } },
                ListTypeSpecifier opList when argumentType is ListTypeSpecifier argList => InferGenericArgument(opList.elementType, argList.elementType),
                ListTypeSpecifier opList when argumentType is not ListTypeSpecifier => InferGenericArgument(opList.elementType, argumentType),
                IntervalTypeSpecifier opInt when argumentType is IntervalTypeSpecifier argInt => InferGenericArgument(opInt.pointType, argInt.pointType),
                IntervalTypeSpecifier opInt when argumentType is not IntervalTypeSpecifier => InferGenericArgument(opInt.pointType, argumentType),
                _ => new()
            };

        internal ConversionResult<Expression>[] TryGenericReplacement(TypeSpecifier[] operandTypes,
            Expression[] arguments, IDictionary<string, TypeSpecifier> replacements)
        {
            var convertedArguments = new ConversionResult<Expression>[arguments.Length];
            for (int i = 0; i < arguments.Length; i++)
            {
                var argument = arguments[i];
                var operandType = operandTypes[i];
                convertedArguments[i] = TryGenericReplacement(operandType, argument, replacements);
            }
            return convertedArguments;
        }

        internal static TypeSpecifier ReplaceGenericTypes(TypeSpecifier type, IDictionary<string, TypeSpecifier> replacements)
        {
            if (type is GenericTypeSpecifier generic)
            {
                if (replacements.TryGetValue(generic.typeArgumentName, out var resolvedType))
                    return resolvedType;
                else throw new ArgumentException($"Generic type {generic.typeArgumentName} does not have a replacement defined.", nameof(replacements));
            }
            else if (type is ListTypeSpecifier listType)
                return ReplaceGenericTypes(listType.elementType, replacements).ToListType();
            else if (type is IntervalTypeSpecifier intervalType)
                return ReplaceGenericTypes(intervalType.pointType, replacements).ToIntervalType();
            else return type;
        }

        internal ConversionResult<Expression> TryGenericReplacement(TypeSpecifier operandType, Expression argument, IDictionary<string, TypeSpecifier> replacements)
        {
            var newType = ReplaceGenericTypes(operandType, replacements);
            var conversion = TypeConverter.Convert(argument, newType);
            return conversion;
        }

        /// <summary>
        /// Picks the function which has the lowest maximum cost in converting its operands to be compatible with the invocation.
        /// </summary>
        internal SignatureMatchResult SelectBestOverload(OverloadedFunctionDef overloadedFunction, Expression[] arguments)
        {
            var matches = overloadedFunction.Functions
                .Select(function => MatchSignature(function, arguments))
                .ToArray();
            var byCost = matches
                .Where(result => result.Compatible)
                .GroupBy(result => result.MostExpensive)
                .OrderBy(group => group.Key)
                .ToArray();
            if (byCost.Length > 0)
            {
                var cheapest = byCost[0].ToArray();
                if (cheapest.Length == 1)
                {
                    return cheapest[0];
                }
                else if (cheapest.Length > 0)
                {
                    // This can happen, for example, when adding an Int and a Long.
                    // There are two ways to convert this function where the most expensive conversion
                    // is implicit to simple type:
                    //      * The Integer can be converted to a Long, matching Add(Long,Long)
                    //      * Both can be converted to Decimals, matching Add(Decimal,Decimal)
                    // In the event where the maximum cost is the same across multiple overloads,
                    // see which, if any, has the lowest total cost.
                    var byTotalCost = cheapest
                        .GroupBy(result => result.TotalCost)
                        .OrderBy(group => group.Key)
                        .ToArray();
                    if (byTotalCost.Length > 1)
                    {
                        var lowestTotalCost = byTotalCost[0].ToArray();
                        if (lowestTotalCost.Length == 1)
                        {
                            return lowestTotalCost[0];
                        }
                    }
                    var argTypeString = string.Join(", ", arguments.Select(a => a.resultTypeSpecifier.ToString()));
                    // match cql-to-elm reference implementation (Java) error messages
                    var errorSb = new StringBuilder();
                    errorSb.AppendLine(CultureInfo.InvariantCulture, $"Call to operator {overloadedFunction.Name}({argTypeString}) is ambiguous with:");
                    foreach (var match in cheapest)
                    {
                        var matchTypeString = string.Join(", ", match.Arguments.Select(od => od.Result.resultTypeSpecifier.ToString()));
                        errorSb.AppendLine(CultureInfo.InvariantCulture, $"\t- {overloadedFunction.Name}({matchTypeString})");
                    }
                    return new(cheapest[0].Function,
                        cheapest[0].Arguments,
                        cheapest[0].GenericInferences,
                        cheapest[0].Flags | SignatureMatchFlags.Ambiguous,
                        errorSb.ToString());
                }
            }
            var firstMatch = matches[0];
            var result = new SignatureMatchResult(firstMatch.Function,
                firstMatch.Arguments,
                firstMatch.GenericInferences,
                firstMatch.Flags,
                firstMatch.Function.GetUnresolvedOperatorMessage(arguments.Select(t => t.resultTypeSpecifier).ToArray()));
            return result;
        }

        #endregion
    }


}

