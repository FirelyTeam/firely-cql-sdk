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

            statements = systemFunctions;
        }

        private readonly ExpressionDef[] systemFunctions =
        {
            IsNull, IsTrue, IsFalse,
            Not,
            Exists, SingletonFrom, ToList,
            Start, End, PointFrom, Width,
            Predecessor, Successor,
            Is, As,
            MinValue, MaxValue,
            And, Implies, Or, Xor,
            IntegerToDecimal, LongToDecimal, IntegerToLong, IntegerToQuantity, DecimalToQuantity, DateToDateTime, CodeToConcept,
            Concatenate,
            Equal, NotEqual, Equivalent,
        };

        private static BuiltInFunctionDef unary<T>(TypeSpecifier argument, TypeSpecifier result) where T : OperatorExpression =>
            new(typeof(T).Name, new[] { argument }, result, typeof(T));

        private static BuiltInFunctionDef binary<T>(TypeSpecifier first, TypeSpecifier second, TypeSpecifier result) where T : OperatorExpression =>
            new(typeof(T).Name, new[] { first, second }, result, typeof(T));

        public static FunctionDef End = unary<End>(T.ToIntervalType(), T);
        public static FunctionDef Exists = unary<Exists>(T.ToListType(), BooleanType);
        public static FunctionDef IsFalse = unary<IsFalse>(BooleanType, BooleanType);
        public static FunctionDef IsNull = unary<IsNull>(AnyType, BooleanType);
        public static FunctionDef IsTrue = unary<IsTrue>(BooleanType, BooleanType);
        public static FunctionDef ToList = unary<ToList>(T, T.ToListType());
        public static FunctionDef Not = unary<Not>(BooleanType, BooleanType);
        public static FunctionDef SingletonFrom = unary<SingletonFrom>(T.ToListType(), T);
        public static FunctionDef Start = unary<Start>(T.ToIntervalType(), T);
        public static FunctionDef PointFrom = unary<PointFrom>(T.ToIntervalType(), T);
        public static FunctionDef Width = unary<Width>(T.ToIntervalType(), T);
        public static FunctionDef Predecessor = unary<Predecessor>(T, T);
        public static FunctionDef Successor = unary<Successor>(T, T);
        public static AsFunctionDef As = new();
        public static IsFunctionDef Is = new();
        public static MinValueFunctionDef MinValue = new();
        public static MaxValueFunctionDef MaxValue = new();
        public static FunctionDef And = binary<And>(BooleanType, BooleanType, BooleanType);
        public static FunctionDef Implies = binary<Implies>(BooleanType, BooleanType, BooleanType);
        public static FunctionDef Or = binary<Or>(BooleanType, BooleanType, BooleanType);
        public static FunctionDef Xor = binary<Xor>(BooleanType, BooleanType, BooleanType);
        public static FunctionDef IntegerToDecimal = unary<ToDecimal>(IntegerType, DecimalType);
        public static FunctionDef LongToDecimal = unary<ToDecimal>(LongType, DecimalType);
        public static FunctionDef IntegerToLong = unary<ToLong>(IntegerType, LongType);
        public static FunctionDef IntegerToQuantity = unary<ToQuantity>(IntegerType, QuantityType);
        public static FunctionDef LongToQuantity = unary<ToQuantity>(LongType, QuantityType);
        public static FunctionDef DecimalToQuantity = unary<ToQuantity>(DecimalType, QuantityType);
        public static FunctionDef DateToDateTime = unary<ToDateTime>(DateType, DateTimeType);
        public static FunctionDef CodeToConcept = unary<ToConcept>(CodeType, ConceptType);
        public static FunctionDef[] Add = binary<Add>(T, T, T).For(T, IntegerType, LongType, DecimalType, QuantityType);
        public static FunctionDef[] AddDateTime = binary<Add>(T, QuantityType, T).For(T, DateType, DateTimeType, TimeType);
        public static FunctionDef[] Subtract = binary<Subtract>(T, T, T).For(T, IntegerType, LongType, DecimalType, QuantityType);
        public static FunctionDef[] SubtractDateTime = binary<Subtract>(T, QuantityType, T).For(T, DateType, DateTimeType, TimeType);
        public static FunctionDef Concatenate = binary<Concatenate>(StringType, StringType, StringType);
        public static FunctionDef[] DifferenceBetween = binary<DifferenceBetween>(T, T, IntegerType).For(T, DateType, DateTimeType, TimeType);
        public static FunctionDef[] DurationBetween = binary<DurationBetween>(T, T, IntegerType).For(T, DateType, DateTimeType, TimeType);
        public static FunctionDef Equal = binary<Equal>(T, T,BooleanType);
        public static FunctionDef NotEqual = binary<NotEqual>(T, T, BooleanType);
        public static FunctionDef Equivalent = binary<Equivalent>(T, T, BooleanType);
        public static FunctionDef[] Greater = binary<Greater>(T, T, BooleanType).For(T,
            ValidOrderedTypes.Append(StringType).ToArray());
        public static FunctionDef[] GreaterOrEqual = binary<GreaterOrEqual>(T, T, BooleanType).For(T,
            ValidOrderedTypes.Append(StringType).ToArray());
        public static FunctionDef[] Less = binary<Less>(T, T, BooleanType).For(T,
            ValidOrderedTypes.Append(StringType).ToArray());
        public static FunctionDef[] LessOrEqual = binary<LessOrEqual>(T, T, BooleanType).For(T,
            ValidOrderedTypes.Append(StringType).ToArray());
        public static FunctionDef[] Multiply = binary<Multiply>(T, T, T).For(T, IntegerType, LongType, DecimalType, QuantityType);
        public static FunctionDef[] Divide = binary<Divide>(T, T, T).For(T, DecimalType, QuantityType);
        public static FunctionDef[] TruncatedDivide = binary<TruncatedDivide>(T, T, T).For(T, IntegerType, LongType, DecimalType, QuantityType);
        public static FunctionDef[] Modulo = binary<Modulo>(T, T, T).For(T, IntegerType, LongType, DecimalType, QuantityType);
        public static FunctionDef[] Power = binary<Power>(T,T,T).For(T, IntegerType, LongType, DecimalType);                    
    }

    internal static class FunctionDefinitionBuilders
    {
        public static BuiltInFunctionDef[] For(this BuiltInFunctionDef def, ParameterTypeSpecifier replace, params TypeSpecifier[] types) =>
            types.Select(t => def.ReplaceGenericParameters(new() { { replace, t } })).ToArray();
    }

}