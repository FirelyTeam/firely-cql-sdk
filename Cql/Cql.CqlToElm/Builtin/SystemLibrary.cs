/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Elm;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Linq;
using static Hl7.Cql.Elm.SystemTypes;

namespace Hl7.Cql.CqlToElm.Builtin
{
    /// <summary>
    /// A Library that represents all the functions defined in the CQL spec.
    /// </summary>
    internal class SystemLibrary : Library
    {
        public SystemLibrary()
        {
            identifier = new VersionedIdentifier() { id = SystemModelPrefix, version = SystemModelVersion };
            statements = expressions;
        }

        // Only symbols with function-like usage should be added to the symbol table.
        // Otherwise, if all symbols were added, then functions like Add(1, 2) would resolve in this table,
        // but that syntax is not recognized by the cql-to-elm reference implementation.
        public SymbolTable Symbols = new SymbolTable(null,
            Abs,
            Avg,
            AllTrue,
            AnyTrue,
            Ceiling,
            Coalesce,
            Combine,
            Concatenate, // has three usages: +, &, and function usage in spec & tests
            Count,
            Date,
            DateTime,
            Descendants,
            EndsWith,
            Exists,
            Exp,
            First,
            Flatten,
            Floor,
            HighBoundary,
            Indexer, // functional usage supported in reference implementation but not mentioned in spec
            IndexOf,
            IsFalse,
            IsNull,
            IsTrue,
            Last,
            LastPositionOf,
            Length,
            ListEquivalent,
            Ln,
            Log,
            LowBoundary,
            Lower,
            Matches,
            Max,
            Median,
            Message,
            Min,
            Mode,
            Now,
            PopulationStdDev,
            PopulationVariance,
            PositionOf,
            Power, // has both operator and function usage in spec & tests
            Precision,
            ReplaceMatches,
            Round,
            Skip,
            Split,
            StartsWith,
            StdDev,
            Substring,
            Sum,
            Take,
            Tail,
            Time,
            TimeOfDay,
            ToBoolean,
            ToConcept,
            ToDateTime,
            ToDecimal,
            ToInteger,
            Today,
            ToStringFunction,
            ToQuantity,
            ToTime,
            Truncate,
            Upper,
            Variance);

        private static readonly ExpressionDef[] expressions = typeof(SystemLibrary)
                .GetFields(System.Reflection.BindingFlags.Static)
                .Where(field => typeof(ExpressionDef).IsAssignableFrom(field.FieldType))
                .Select(field => field.GetValue(null))
                .Cast<ExpressionDef>()
                .ToArray();

        private static SystemFunction<T> nullary<T>(TypeSpecifier result) where T : Expression =>
            new(EmptyOperands, result, typeof(T).Name);
        private static SystemFunction<T> unary<T>(TypeSpecifier argument, TypeSpecifier result, string? name = null) where T : OperatorExpression =>
            new(new[] { argument }, result, name ?? typeof(T).Name);
        private static SystemFunction<T> binary<T>(TypeSpecifier first, TypeSpecifier second, TypeSpecifier result, string? name = null) where T : OperatorExpression =>
            new(new[] { first, second }, result, name ?? typeof(T).Name);
        private static SystemFunction<T> binaryWithPrecision<T>(TypeSpecifier first, TypeSpecifier second, TypeSpecifier result) where T : OperatorExpression =>
            new(new[] { first, second, StringType, }, result, typeof(T).Name, 2);
        private static SystemFunction<T> nary<T>(TypeSpecifier[] operands, int requiredParameterCount, TypeSpecifier result) where T : OperatorExpression =>
            new(operands, result, typeof(T).Name, requiredParameterCount);
        private static SystemFunction<T> nary<T>(TypeSpecifier operandType, int operandCount, int requiredParameterCount, TypeSpecifier result) where T : OperatorExpression =>
            new(Enumerable.Range(0, operandCount).Select(i => operandType).ToArray(), result, typeof(T).Name, requiredParameterCount);
        private static SystemFunction<T> aggregate<T>(TypeSpecifier source, TypeSpecifier result) where T : AggregateExpression =>
            new(new[] { source.ToListType() }, result, typeof(T).Name);
        public static readonly TypeSpecifier[] EmptyOperands = System.Array.Empty<TypeSpecifier>();


        // Alphabetized
        public static OverloadedFunctionDef Abs = unary<Abs>(T, T).For(T, NumericTypes);
        public static OverloadedFunctionDef Add = binary<Add>(T, T, T).For(T, new[] { IntegerType, LongType, DecimalType, QuantityType, StringType }).Combine(binary<Add>(T, QuantityType, T).For(T, DateType, DateTimeType, TimeType));
        public static SystemFunction<AllTrue> AllTrue = aggregate<AllTrue>(BooleanType, BooleanType);
        public static SystemFunction<And> And = binary<And>(BooleanType, BooleanType, BooleanType);
        public static SystemFunction<AnyTrue> AnyTrue = aggregate<AnyTrue>(BooleanType, BooleanType);
        public static OverloadedFunctionDef Avg = aggregate<Avg>(T, T).For(T, DecimalType, QuantityType);
        public static SystemFunction<As> As = unary<As>(AnyType, T);
        public static SystemFunction<Case> Case = new SystemFunction<Case>(new TypeSpecifier[] { BooleanType, T, T }, T);
        public static OverloadedFunctionDef Ceiling = unary<Ceiling>(T, T).For(T, NumericTypes);
        public static OverloadedFunctionDef Coalesce = nary<Coalesce>(new[] { T, T, T, T, T }, 2, T).Combine(unary<Coalesce>(T.ToListType(), T));
        public static SystemFunction<ToConcept> CodeToConcept = unary<ToConcept>(CodeType, ConceptType);
        public static SystemFunction<Combine> Combine = nary<Combine>(new TypeSpecifier[] { StringType.ToListType(), StringType }, 1, StringType);
        public static SystemFunction<Concatenate> Concatenate = binary<Concatenate>(StringType, StringType, StringType);
        public static SystemFunction<Count> Count = aggregate<Count>(T, IntegerType);
        public static SystemFunction<Date> Date = nary<Date>(IntegerType, 3, 1, DateType);
        public static SystemFunction<DateTime> DateTime = nary<DateTime>(new[] { IntegerType, IntegerType, IntegerType, IntegerType, IntegerType, IntegerType, IntegerType, DecimalType }, 1, DateTimeType);
        public static SystemFunction<ToDateTime> DateToDateTime = unary<ToDateTime>(DateType, DateTimeType);
        public static SystemFunction<ToQuantity> DecimalToQuantity = unary<ToQuantity>(DecimalType, QuantityType);
        public static SystemFunction<Descendents> Descendants = unary<Descendents>(AnyType, AnyType, "descendents").IsFluent(); // this is always called like <any>.descendents()
        public static OverloadedFunctionDef DifferenceBetween = binaryWithPrecision<DifferenceBetween>(T, T, IntegerType)
            .ValidateWith(Validators.Validate)
            .For(T, DateType, DateTimeType, TimeType);
        public static OverloadedFunctionDef Divide = binary<Divide>(T, T, T).For(T, DecimalType, QuantityType);
        public static OverloadedFunctionDef DurationBetween = binaryWithPrecision<DurationBetween>(T, T, IntegerType)
            .ValidateWith(Validators.Validate)
            .For(T, DateType, DateTimeType, TimeType);
        public static SystemFunction<End> End = unary<End>(T.ToIntervalType(), T);
        public static SystemFunction<EndsWith> EndsWith = binary<EndsWith>(StringType, StringType, BooleanType);
        public static SystemFunction<Equal> Equal = binary<Equal>(T, T, BooleanType);
        public static SystemFunction<Equivalent> Equivalent = binary<Equivalent>(T, T, BooleanType);
        public static SystemFunction<Equivalent> ListEquivalent = binary<Equivalent>(T.ToListType(), T.ToListType(), BooleanType);
        public static SystemFunction<Exists> Exists = unary<Exists>(T.ToListType(), BooleanType);
        public static SystemFunction<Exp> Exp = unary<Exp>(DecimalType, DecimalType);
        public static SystemFunction<First> First = unary<First>(T.ToListType(), T);
        public static SystemFunction<Flatten> Flatten = unary<Flatten>(T.ToListType().ToListType(), T.ToListType());
        public static OverloadedFunctionDef Floor = unary<Floor>(T, T).For(T, NumericTypes);
        public static OverloadedFunctionDef HighBoundary = binary<HighBoundary>(T, IntegerType, T).For(T, DecimalType, DateType, DateTimeType, TimeType);
        public static SystemFunction<If> If = new SystemFunction<If>(new TypeSpecifier[] { BooleanType, T, T }, T);        
        public static SystemFunction<Implies> Implies = binary<Implies>(BooleanType, BooleanType, BooleanType);
        public static SystemFunction<Indexer> Indexer = binary<Indexer>(StringType, IntegerType, StringType);
        public static SystemFunction<IndexOf> IndexOf = binary<IndexOf>(T.ToListType(), T, IntegerType);
        public static SystemFunction<ToDecimal> IntegerToDecimal = unary<ToDecimal>(IntegerType, DecimalType);
        public static SystemFunction<ToLong> IntegerToLong = unary<ToLong>(IntegerType, LongType);
        public static SystemFunction<ToQuantity> IntegerToQuantity = unary<ToQuantity>(IntegerType, QuantityType);
        public static SystemFunction<Is> Is = unary<Is>(T, BooleanType);
        public static SystemFunction<IsFalse> IsFalse = unary<IsFalse>(BooleanType, BooleanType);
        public static SystemFunction<IsNull> IsNull = unary<IsNull>(AnyType, BooleanType);
        public static SystemFunction<IsTrue> IsTrue = unary<IsTrue>(BooleanType, BooleanType);
        public static OverloadedFunctionDef Greater = binary<Greater>(T, T, BooleanType).For(T, ValidOrderedTypes.Append(StringType).ToArray());
        public static OverloadedFunctionDef GreaterOrEqual = binary<GreaterOrEqual>(T, T, BooleanType).For(T, ValidOrderedTypes.Append(StringType).ToArray());
        public static SystemFunction<Last> Last = unary<Last>(T.ToListType(), T);
        public static SystemFunction<LastPositionOf> LastPositionOf = binary<LastPositionOf>(StringType, StringType, IntegerType);
        public static SystemFunction<Length> Length = unary<Length>(T.ToListType(), IntegerType);
        public static OverloadedFunctionDef Less = binary<Less>(T, T, BooleanType).For(T, ValidOrderedTypes.Append(StringType).ToArray());
        public static OverloadedFunctionDef LessOrEqual = binary<LessOrEqual>(T, T, BooleanType).For(T, ValidOrderedTypes.Append(StringType).ToArray());
        public static SystemFunction<Ln> Ln = unary<Ln>(DecimalType, DecimalType);
        public static SystemFunction<ToDecimal> LongToDecimal = unary<ToDecimal>(LongType, DecimalType);
        public static SystemFunction<ToQuantity> LongToQuantity = unary<ToQuantity>(LongType, QuantityType);
        public static SystemFunction<Log> Log = binary<Log>(DecimalType, DecimalType, DecimalType);
        public static SystemFunction<Lower> Lower = unary<Lower>(StringType, StringType);
        public static OverloadedFunctionDef LowBoundary = binary<LowBoundary>(T, IntegerType, T).For(T, DecimalType, DateType, DateTimeType, TimeType);
        public static SystemFunction<Matches> Matches = binary<Matches>(StringType, StringType, BooleanType);
        public static OverloadedFunctionDef Max = aggregate<Max>(T, T).For(T, IntegerType, LongType, DecimalType, QuantityType, DateType, DateTimeType, TimeType, StringType);
        public static SystemFunction<MaxValue> MaxValue = nullary<MaxValue>(T);
        public static OverloadedFunctionDef Median = aggregate<Median>(T, T).For(T, DecimalType, QuantityType);
        public static SystemFunction<Message> Message = nary<Message>(new TypeSpecifier[] { T, BooleanType, StringType, StringType, StringType }, 5, T);
        public static OverloadedFunctionDef Min = aggregate<Min>(T, T).For(T, IntegerType, LongType, DecimalType, QuantityType, DateType, DateTimeType, TimeType, StringType);
        public static SystemFunction<MinValue> MinValue = nullary<MinValue>(T);
        public static SystemFunction<Mode> Mode = aggregate<Mode>(T, T);
        public static OverloadedFunctionDef Modulo = binary<Modulo>(T, T, T).For(T, NumericTypes);
        public static OverloadedFunctionDef Multiply = binary<Multiply>(T, T, T).For(T, NumericTypes);
        public static SystemFunction<Not> Not = unary<Not>(BooleanType, BooleanType);
        public static SystemFunction<Now> Now = nullary<Now>(DateTimeType);
        public static SystemFunction<NotEqual> NotEqual = binary<NotEqual>(T, T, BooleanType);
        public static SystemFunction<Or> Or = binary<Or>(BooleanType, BooleanType, BooleanType);
        public static SystemFunction<PointFrom> PointFrom = unary<PointFrom>(T.ToIntervalType(), T);
        public static OverloadedFunctionDef PopulationStdDev = aggregate<PopulationStdDev>(T, T).For(T, DecimalType, QuantityType);
        public static OverloadedFunctionDef PopulationVariance = aggregate<PopulationVariance>(T, T).For(T, DecimalType, QuantityType);
        public static SystemFunction<PositionOf> PositionOf = binary<PositionOf>(StringType, StringType, IntegerType);
        public static OverloadedFunctionDef Power = binary<Power>(T, T, T).For(T, IntegerType, LongType, DecimalType);
        public static OverloadedFunctionDef Precision = unary<Precision>(T, IntegerType).For(T, DecimalType, DateType, DateTimeType, TimeType);
        public static SystemFunction<Predecessor> Predecessor = unary<Predecessor>(T, T);
        public static SystemFunction<ReplaceMatches> ReplaceMatches = nary<ReplaceMatches>(new[] { StringType, StringType, StringType }, 3, StringType);
        public static SystemFunction<Round> Round = nary<Round>(new[] { DecimalType, IntegerType }, 1, DecimalType);
        public static SystemFunction<SingletonFrom> SingletonFrom = unary<SingletonFrom>(T.ToListType(), T);
        public static SystemFunction<Slice> Skip = binary<Slice>(T.ToListType(), IntegerType, T.ToListType(), "Skip");
        public static SystemFunction<Split> Split = binary<Split>(StringType, StringType, StringType.ToListType());
        public static SystemFunction<Start> Start = unary<Start>(T.ToIntervalType(), T);
        public static SystemFunction<StartsWith> StartsWith = binary<StartsWith>(StringType, StringType, BooleanType);
        public static OverloadedFunctionDef StdDev = aggregate<StdDev>(T, T).For(T, DecimalType, QuantityType);
        public static SystemFunction<Substring> Substring = nary<Substring>(new[] { StringType, IntegerType, IntegerType }, 2, StringType);
        public static OverloadedFunctionDef Subtract = binary<Subtract>(T, T, T).For(T, NumericTypes).Combine(binary<Subtract>(T, QuantityType, T).For(T, DateType, DateTimeType, TimeType));
        public static SystemFunction<Successor> Successor = unary<Successor>(T, T);
        public static OverloadedFunctionDef Sum = aggregate<Sum>(T, T).For(T, NumericTypes);
        public static SystemFunction<Slice> Take = binary<Slice>(T.ToListType(), IntegerType, T.ToListType(), "Take");
        public static SystemFunction<Slice> Tail = unary<Slice>(T.ToListType(), T.ToListType(), "Tail");
        public static SystemFunction<Time> Time = nary<Time>(IntegerType, 4, 1, TimeType);
        public static SystemFunction<TimeOfDay> TimeOfDay = nullary<TimeOfDay>(TimeType);
        public static OverloadedFunctionDef ToBoolean = unary<ToBoolean>(T, BooleanType).For(T, IntegerType, LongType, DecimalType, StringType);
        public static OverloadedFunctionDef ToConcept = unary<ToConcept>(T, ConceptType).For(T, CodeType, CodeType.ToListType());
        public static OverloadedFunctionDef ToDateTime = unary<ToDateTime>(T, DateTimeType).For(T, DateType, StringType);
        public static OverloadedFunctionDef ToDecimal = unary<ToDecimal>(T, DecimalType).For(T,BooleanType, StringType);
        public static OverloadedFunctionDef ToInteger = unary<ToInteger>(T, IntegerType).For(T, BooleanType, StringType, LongType);
        public static SystemFunction<Today> Today = nullary<Today>(DateType);
        public static SystemFunction<ToList> ToList = unary<ToList>(T, T.ToListType());
        public static OverloadedFunctionDef ToQuantity = unary<ToQuantity>(T, QuantityType).For(T, DecimalType, IntegerType, RatioType, StringType);
        public static OverloadedFunctionDef ToStringFunction = unary<ToString>(T, StringType).For(T, BooleanType, IntegerType, LongType, DecimalType, QuantityType, RatioType, DateType, DateTimeType, TimeType);
        public static SystemFunction<ToTime> ToTime = unary<ToTime>(StringType, TimeType);
        public static SystemFunction<Truncate> Truncate = unary<Truncate>(DecimalType, IntegerType);
        public static OverloadedFunctionDef TruncatedDivide = binary<TruncatedDivide>(T, T, T).For(T, NumericTypes);
        public static SystemFunction<Upper> Upper = unary<Upper>(StringType, StringType);
        public static OverloadedFunctionDef Variance = aggregate<Variance>(T, T).For(T, DecimalType, QuantityType);
        public static SystemFunction<Width> Width = unary<Width>(T.ToIntervalType(), T);
        public static SystemFunction<Xor> Xor = binary<Xor>(BooleanType, BooleanType, BooleanType);
    }

    internal static class Validators
    {
        internal static void Validate(DifferenceBetween db) => db
            .HasSameOperandTypes()
            .HasValidPrecision(db.operand[0].resultTypeSpecifier, db.precisionSpecified, db.precision);
        internal static void Validate(DurationBetween db) => db
            .HasSameOperandTypes()
            .HasValidPrecision(db.operand[0].resultTypeSpecifier, db.precisionSpecified, db.precision);

        public static T HasSameOperandTypes<T>(this T element) where T : Element =>
            element switch
            {
                BinaryExpression be when be.operand[0].resultTypeSpecifier != be.operand[1].resultTypeSpecifier => element.AddError("Both operands must have the same type."),
                TernaryExpression te when te.operand.Distinct().Count() > 1 => element.AddError("Both operands must have the same type."),
                _ => element
            };

        public static T HasValidPrecision<T>(this T element, TypeSpecifier operandType, bool precisionSpecified, DateTimePrecision precision)
            where T : Element
        {
            if (precisionSpecified)
            {
                // For Date values, precision must be one of: years, months, weeks, or days.
                if (operandType == DateType && precision > DateTimePrecision.Day)
                    element.AddError("For Date values, precision must be one of: years, months, weeks, or days.");
                else if (operandType == TimeType && precision < DateTimePrecision.Hour)
                    element.AddError("For Time values, precision must be one of: hours, minutes, seconds, or milliseconds.");
            }
            return element;
        }
    }

    internal static class FunctionDefinitionBuilders
    {
        public static OverloadedFunctionDef For<T>(this SystemFunction<T> def, ParameterTypeSpecifier replace, params TypeSpecifier[] types)
            where T: Element =>
            OverloadedFunctionDef.Create(types.Select(t => def.ReplaceGenericParameters(new() { { replace, t } })).ToArray());

        public static OverloadedFunctionDef Combine(this OverloadedFunctionDef def, params OverloadedFunctionDef[] defs) =>
            OverloadedFunctionDef.Create(def.Functions.Concat(defs.SelectMany(def => def.Functions)).ToArray());

        public static OverloadedFunctionDef Combine<T>(this SystemFunction<T> def, params SystemFunction<T>[] defs) where T: Element =>
            OverloadedFunctionDef.Create(defs.Append(def).ToArray());


        public static SystemFunction<T> IsFluent<T>(this SystemFunction<T> function)
            where T: Element
        {
            function.fluent = true;
            function.fluentSpecified = true;
            return function;
        }
    }

}