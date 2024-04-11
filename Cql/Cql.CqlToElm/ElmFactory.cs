using Hl7.Cql.CqlToElm.Builtin;
using Hl7.Cql.Elm;
using System;
using System.Globalization;
using System.IO;

namespace Hl7.Cql.CqlToElm
{
    internal class ElmFactory
    {
        public ElmFactory(CoercionProvider coercionProvider, MessageProvider messaging)
        {
            CoercionProvider = coercionProvider;
            Messaging = messaging;
        }
        public CoercionProvider CoercionProvider { get; }
        public MessageProvider Messaging { get; }

        public Expression CreateElmNode(FunctionDef function, string? library, Expression[] arguments)
        {
            var nodeType = function is SystemFunction b ? b.ElmNodeType : typeof(FunctionRef);
            Expression result = (Expression)Activator.CreateInstance(nodeType)!;
            result = result switch
            {
                AggregateExpression ae => Populate(ae, arguments),
                Combine combine => Populate(combine, arguments),
                Between between => Populate(between, arguments),
                Date d => Populate(d, arguments),
                Elm.DateTime dt => Populate(dt, arguments),
                Expression e when arguments.Length == 0 => e,
                FunctionRef fr => Populate(function, library, fr, arguments),
                IndexOf io => Populate(io, arguments),
                Interval interval => Populate(interval, arguments),
                LastPositionOf lpo => Populate(lpo, arguments),
                Message msg => Populate(msg, arguments),
                NaryExpression ne => Populate(ne, arguments),
                PositionOf po => Populate(po, arguments),
                ProperBetween pb => Populate(pb, arguments),
                Round round => Populate(round, arguments),
                Slice slice => Populate(function, slice, arguments),
                Split split => Populate(split, arguments),
                Substring sub => Populate(sub, arguments),
                Time time => Populate(time, arguments),

                UnaryExpression ue => Populate(ue, arguments),
                BinaryExpression be => Populate(be, arguments),
                TernaryExpression te => Populate(te, arguments),
                IHasSource ihs => (Expression)Populate(ihs, arguments),
                _ => throw new InvalidOperationException($"Population of {result.GetType()} is not implemented.")
            };
            return result;
        }

        internal Literal Literal(int value) => 
            Literal(value.ToString(CultureInfo.InvariantCulture), SystemTypes.IntegerType);
        internal Literal Literal(long value) =>
            Literal(value.ToString(CultureInfo.InvariantCulture), SystemTypes.LongType);
        internal Literal Literal(bool value) =>
            Literal(value.ToString(CultureInfo.InvariantCulture).ToLowerInvariant(), SystemTypes.BooleanType);
        internal Literal Literal(decimal value) =>
            Literal(value.ToString(CultureInfo.InvariantCulture), SystemTypes.DecimalType);
        internal Literal Literal(string value) =>
            Literal(value, SystemTypes.StringType);
        internal Elm.Quantity Quantity(decimal value, string unit) =>
            new Elm.Quantity
            {
                value = value,
                valueSpecified = true,
                unit = unit
            }.WithResultType(SystemTypes.QuantityType);
                


        private Literal Literal(string value, NamedTypeSpecifier namedType) =>
            new Literal
            {
                value = value,
                valueType = namedType.name,
                resultTypeName = namedType.name,
                resultTypeSpecifier = namedType,
            };

        internal Expression If(Expression condition, Expression then, Expression @else)
        {
            var @if = new If();
            var convertCondition = CoercionProvider.Coerce(condition, SystemTypes.BooleanType);
            if (convertCondition.Success)
                condition = convertCondition.Result;
            else @if.AddError(Messaging.TypeFoundIsNotExpected(condition.resultTypeSpecifier, SystemTypes.BooleanType));

            var compatible = true;
            if (then is Null && then.resultTypeSpecifier == SystemTypes.AnyType)
            {
                if (@else.resultTypeSpecifier != SystemTypes.AnyType)
                {
                    var thenResult = CoercionProvider.Coerce(then, @else.resultTypeSpecifier);
                    then = thenResult.Result;
                }
            }
            else if (@else is Null && @else.resultTypeSpecifier == SystemTypes.AnyType)
            {
                if (then.resultTypeSpecifier != SystemTypes.AnyType)
                {
                    var elseResult = CoercionProvider.Coerce(@else, then.resultTypeSpecifier);
                    @else = elseResult.Result;
                }
            }
            else
            {
                var convertThenToElse = CoercionProvider.Coerce(then, @else.resultTypeSpecifier);
                var convertElseToThen = CoercionProvider.Coerce(@else, then.resultTypeSpecifier);
                if (convertThenToElse.Cost < convertElseToThen.Cost)
                {
                    if (convertThenToElse.Cost == CoercionCost.Incompatible)
                        compatible = false;
                    else
                        then = convertThenToElse.Result;
                }
                else
                {
                    if (convertElseToThen.Cost == CoercionCost.Incompatible)
                        compatible = false;
                    else
                        @else = convertElseToThen.Result;
                }
            }
            if (!compatible)
            {
                var choiceType = new ChoiceTypeSpecifier(then.resultTypeSpecifier, @else.resultTypeSpecifier);
                then = CoercionProvider.Coerce(then, choiceType).Result; // it will succeed
                @else = CoercionProvider.Coerce(@else, choiceType).Result; // it will succeed
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
        internal And Populate(Between binary, Expression[] arguments)
        {
            // we use Between to pattern match this overload, but between returns an And
            var gt = new GreaterOrEqual { operand = new[] { arguments[0], arguments[1] } }
                .WithResultType(SystemTypes.BooleanType);
            var lt = new LessOrEqual { operand = new[] { arguments[0], arguments[2] } }
                .WithResultType(SystemTypes.BooleanType);
            var and = new And { operand = new Expression[] { gt, lt } };
            return and;
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


        internal IndexOf Populate(IndexOf indexOf, Expression[] arguments)
        {
            if (arguments.Length != 2)
                throw new ArgumentException($"Expected 2 argument, but got {arguments.Length}.", nameof(arguments));
            indexOf.source = arguments[0];
            indexOf.element = arguments[1];
            return indexOf;
        }
        internal Interval Populate(Interval interval, Expression[] arguments)
        {
            if (arguments.Length != 4)
                throw new ArgumentException($"Expected 4 arguments, but got {arguments.Length}.", nameof(arguments));
            interval.low = arguments[0];
            interval.high = arguments[1];
            if (arguments[2] is Literal lowLiteral)
            {
                if (!bool.TryParse(lowLiteral.value, out var lc))
                    throw new ArgumentException($"Expected literal argument at index 2 to be a valid Boolean value.");
                interval.lowClosed = lc;
            }
            else interval.lowClosedExpression = arguments[2];
            if (arguments[3] is Literal highLiteral)
            {
                if (!bool.TryParse(highLiteral.value, out var hc))
                    throw new ArgumentException($"Expected literal argument at index 3 to be a valid Boolean value.");
                interval.highClosed = hc;
            }
            else interval.highClosedExpression = arguments[2];
            
            return interval;
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
        internal And Populate(ProperBetween between, Expression[] arguments)
        {
            // we use ProperBetween to pattern match this overload,
            // but proper between returns an And
            var gt = new Greater { operand = new[] { arguments[0], arguments[1] } }
                .WithResultType(SystemTypes.BooleanType);
            var lt = new Less { operand = new[] { arguments[0], arguments[2] } }
                .WithResultType(SystemTypes.BooleanType);
            var and = new And { operand = new Expression[] { gt, lt } };
            return and;
        }


        internal Round Populate(Round round, Expression[] arguments)
        {
            if (arguments.Length > 1)
            {
                round.precision = arguments[1];
            }
            else if (arguments.Length != 1)
                throw new ArgumentException($"Expected 1-2 argument, but got {arguments.Length}.", nameof(arguments));
            round.operand = arguments[0];
            return round;
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
                slice.startIndex = Literal(0);
                slice.endIndex = new Coalesce
                {
                    operand = new[] { arguments[1], Literal(0) },
                }.WithResultType(SystemTypes.IntegerType);
            }
            if (function.name == nameof(SystemLibrary.Tail))
            {
                slice.startIndex = Literal(1);
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
    }
}
