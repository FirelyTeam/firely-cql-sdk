/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Elm;
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
                OverloadedFunctionDef.Create(Avg),
                AllTrue,
                AnyTrue,
                Count,
                Date,
                DateTime,
                OverloadedFunctionDef.Create(Max),
                OverloadedFunctionDef.Create(Min),
                Time);

        private static readonly ExpressionDef[] expressions = typeof(SystemLibrary)
                .GetFields(System.Reflection.BindingFlags.Static)
                .Where(field => typeof(ExpressionDef).IsAssignableFrom(field.FieldType))
                .Select(field => field.GetValue(null))
                .Cast<ExpressionDef>()
                .ToArray();

        private static BuiltInFunctionDef unary<T>(TypeSpecifier argument, TypeSpecifier result) where T : OperatorExpression =>
            new(typeof(T).Name, new[] { argument }, result, typeof(T));

        private static BuiltInFunctionDef binary<T>(TypeSpecifier first, TypeSpecifier second, TypeSpecifier result) where T : OperatorExpression =>
            new(typeof(T).Name, new[] { first, second }, result, typeof(T));

        private static BuiltInFunctionDef nary<T>(TypeSpecifier[] operands, int requiredParameterCount, TypeSpecifier result) where T : OperatorExpression =>
            new(typeof(T).Name, operands, result, typeof(T), requiredParameterCount);

        private static BuiltInFunctionDef nary<T>(TypeSpecifier operandType, int operandCount, int requiredParameterCount, TypeSpecifier result) where T : OperatorExpression =>
            new(typeof(T).Name, Enumerable.Range(0, operandCount).Select(i=>operandType).ToArray(), result, typeof(T), requiredParameterCount);

        private static BuiltInFunctionDef aggregate<T>(TypeSpecifier source, TypeSpecifier result) where T : AggregateExpression =>
            new(typeof(T).Name, new[] { source.ToListType() }, result, typeof(T));

        // Alphabetized
        public static FunctionDef[] Add = binary<Add>(T, T, T).For(T, IntegerType, LongType, DecimalType, QuantityType);
        public static FunctionDef[] AddDateTime = binary<Add>(T, QuantityType, T).For(T, DateType, DateTimeType, TimeType);
        public static FunctionDef AllTrue = aggregate<AllTrue>(BooleanType, BooleanType);
        public static FunctionDef And = binary<And>(BooleanType, BooleanType, BooleanType);
        public static FunctionDef AnyTrue = aggregate<AnyTrue>(BooleanType, BooleanType);
        public static FunctionDef[] Avg = aggregate<Avg>(T, T).For(T, DecimalType, QuantityType);
        public static AsFunctionDef As = new();
        public static CaseFunctionDef Case = new();
        public static FunctionDef CodeToConcept = unary<ToConcept>(CodeType, ConceptType);
        public static FunctionDef Concatenate = binary<Concatenate>(StringType, StringType, StringType);
        public static FunctionDef Count = aggregate<Count>(AnyType, IntegerType);
        public static FunctionDef Date = nary<Date>(IntegerType, 3, 1, DateType);
        public static FunctionDef DateTime = nary<DateTime>(new[] { IntegerType, IntegerType, IntegerType, IntegerType, IntegerType, IntegerType, IntegerType, DecimalType }, 1, DateTimeType);
        public static FunctionDef DateToDateTime = unary<ToDateTime>(DateType, DateTimeType);
        public static FunctionDef DecimalToQuantity = unary<ToQuantity>(DecimalType, QuantityType);
        public static FunctionDef[] DifferenceBetween = binary<DifferenceBetween>(T, T, IntegerType).For(T, DateType, DateTimeType, TimeType);
        public static FunctionDef[] Divide = binary<Divide>(T, T, T).For(T, DecimalType, QuantityType);
        public static FunctionDef[] DurationBetween = binary<DurationBetween>(T, T, IntegerType).For(T, DateType, DateTimeType, TimeType);
        public static FunctionDef End = unary<End>(T.ToIntervalType(), T);
        public static FunctionDef Equal = binary<Equal>(T, T, BooleanType);
        public static FunctionDef Equivalent = binary<Equivalent>(T, T, BooleanType);
        public static FunctionDef Exists = unary<Exists>(T.ToListType(), BooleanType);
        public static IfFunctionDef If = new();
        public static FunctionDef Implies = binary<Implies>(BooleanType, BooleanType, BooleanType);
        public static FunctionDef IntegerToDecimal = unary<ToDecimal>(IntegerType, DecimalType);
        public static FunctionDef IntegerToLong = unary<ToLong>(IntegerType, LongType);
        public static FunctionDef IntegerToQuantity = unary<ToQuantity>(IntegerType, QuantityType);
        public static IsFunctionDef Is = new();
        public static FunctionDef IsFalse = unary<IsFalse>(BooleanType, BooleanType);
        public static FunctionDef IsNull = unary<IsNull>(AnyType, BooleanType);
        public static FunctionDef IsTrue = unary<IsTrue>(BooleanType, BooleanType);
        public static FunctionDef[] Greater = binary<Greater>(T, T, BooleanType).For(T, ValidOrderedTypes.Append(StringType).ToArray());
        public static FunctionDef[] GreaterOrEqual = binary<GreaterOrEqual>(T, T, BooleanType).For(T, ValidOrderedTypes.Append(StringType).ToArray());
        public static FunctionDef[] Less = binary<Less>(T, T, BooleanType).For(T, ValidOrderedTypes.Append(StringType).ToArray());
        public static FunctionDef[] LessOrEqual = binary<LessOrEqual>(T, T, BooleanType).For(T, ValidOrderedTypes.Append(StringType).ToArray());
        public static FunctionDef LongToDecimal = unary<ToDecimal>(LongType, DecimalType);
        public static FunctionDef LongToQuantity = unary<ToQuantity>(LongType, QuantityType);
        public static FunctionDef[] Min = aggregate<Min>(T, T).For(T, IntegerType, LongType, DecimalType, QuantityType, DateType, DateTimeType, TimeType, StringType);
        public static MinValueFunctionDef MinValue = new();
        public static FunctionDef[] Max = aggregate<Max>(T, T).For(T, IntegerType, LongType, DecimalType, QuantityType, DateType, DateTimeType, TimeType, StringType);
        public static MaxValueFunctionDef MaxValue = new();
        public static FunctionDef[] Modulo = binary<Modulo>(T, T, T).For(T, IntegerType, LongType, DecimalType, QuantityType);
        public static FunctionDef[] Multiply = binary<Multiply>(T, T, T).For(T, IntegerType, LongType, DecimalType, QuantityType);
        public static FunctionDef Not = unary<Not>(BooleanType, BooleanType);
        public static FunctionDef NotEqual = binary<NotEqual>(T, T, BooleanType);
        public static FunctionDef Or = binary<Or>(BooleanType, BooleanType, BooleanType);
        public static FunctionDef PointFrom = unary<PointFrom>(T.ToIntervalType(), T);
        public static FunctionDef[] Power = binary<Power>(T, T, T).For(T, IntegerType, LongType, DecimalType);
        public static FunctionDef Predecessor = unary<Predecessor>(T, T);
        public static FunctionDef SingletonFrom = unary<SingletonFrom>(T.ToListType(), T);
        public static FunctionDef Start = unary<Start>(T.ToIntervalType(), T);
        public static FunctionDef[] Subtract = binary<Subtract>(T, T, T).For(T, IntegerType, LongType, DecimalType, QuantityType);
        public static FunctionDef[] SubtractDateTime = binary<Subtract>(T, QuantityType, T).For(T, DateType, DateTimeType, TimeType);
        public static FunctionDef Successor = unary<Successor>(T, T);
        public static FunctionDef Time = nary<Time>(IntegerType, 4, 1, TimeType);
        public static FunctionDef ToList = unary<ToList>(T, T.ToListType());
        public static FunctionDef[] TruncatedDivide = binary<TruncatedDivide>(T, T, T).For(T, IntegerType, LongType, DecimalType, QuantityType);
        public static FunctionDef Width = unary<Width>(T.ToIntervalType(), T);
        public static FunctionDef Xor = binary<Xor>(BooleanType, BooleanType, BooleanType);

    }

    internal static class FunctionDefinitionBuilders
    {
        public static BuiltInFunctionDef[] For(this BuiltInFunctionDef def, ParameterTypeSpecifier replace, params TypeSpecifier[] types) =>
            types.Select(t => def.ReplaceGenericParameters(new() { { replace, t } })).ToArray();
    }

}