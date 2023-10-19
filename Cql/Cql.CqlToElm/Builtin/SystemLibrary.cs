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
    internal static class FunctionDefinitionBuilders
    {
        public static BuiltInFunctionDef[] For(this BuiltInFunctionDef def, ParameterTypeSpecifier replace, params TypeSpecifier[] types) =>
            types.Select(t => def.ReplaceGenericParameters(new() { { replace, t } })).ToArray();
    }
    /// <summary>
    /// A Library that represents all the functions defined in the CQL spec.
    /// </summary>
    internal class SystemLibrary : Library
    {

        public SystemLibrary()
        {
            identifier = new VersionedIdentifier() { id = SystemModelPrefix, version = SystemModelVersion };
            systemFunctions = new ExpressionDef[]
            {
                IsNull, IsTrue, IsFalse,
                Not,
                Exists, SingletonFrom, ToList,
                Start, End, PointFrom, Width,
                Predecessor, Successor,
                Is, As,
                MinValue, MaxValue,
                And,
                IntegerToDecimal, LongToDecimal, IntegerToLong, IntegerToQuantity, DecimalToQuantity, DateToDateTime, CodeToConcept,
            };
            statements = systemFunctions;
        }

        private readonly ExpressionDef[] systemFunctions;

        private static BuiltInFunctionDef unary<T>(TypeSpecifier argument, TypeSpecifier result) where T : OperatorExpression =>
            new(typeof(T).Name, new[] { argument }, result, typeof(T));

        private static BuiltInFunctionDef binary<T>(TypeSpecifier first, TypeSpecifier second, TypeSpecifier result) where T : OperatorExpression =>
            new(typeof(T).Name, new[] { first, second }, result, typeof(T));

        public FunctionDef End = unary<End>(T.ToIntervalType(), T);
        public FunctionDef Exists = unary<Exists>(T.ToListType(), BooleanType);
        public FunctionDef IsFalse = unary<IsFalse>(BooleanType, BooleanType);
        public FunctionDef IsNull = unary<IsNull>(AnyType, BooleanType);
        public FunctionDef IsTrue = unary<IsTrue>(BooleanType, BooleanType);
        public FunctionDef ToList = unary<ToList>(T, T.ToListType());
        public FunctionDef Not = unary<Not>(BooleanType, BooleanType);
        public FunctionDef SingletonFrom = unary<SingletonFrom>(T.ToListType(), T);
        public FunctionDef Start = unary<Start>(T.ToIntervalType(), T);
        public FunctionDef PointFrom = unary<PointFrom>(T.ToIntervalType(), T);
        public FunctionDef Width = unary<Width>(T.ToIntervalType(), T);
        public FunctionDef Predecessor = unary<Predecessor>(T, T);
        public FunctionDef Successor = unary<Successor>(T, T);

        public AsFunctionDef As = new();
        public IsFunctionDef Is = new();
        public MinValueFunctionDef MinValue = new();
        public MaxValueFunctionDef MaxValue = new();

        public FunctionDef And = binary<And>(BooleanType, BooleanType, BooleanType);

        public FunctionDef IntegerToDecimal = unary<ToDecimal>(IntegerType, DecimalType);
        public FunctionDef LongToDecimal = unary<ToDecimal>(LongType, DecimalType);
        public FunctionDef IntegerToLong = unary<ToLong>(IntegerType, LongType);
        public FunctionDef IntegerToQuantity = unary<ToQuantity>(IntegerType, QuantityType);
        public FunctionDef LongToQuantity = unary<ToQuantity>(LongType, QuantityType);
        public FunctionDef DecimalToQuantity = unary<ToQuantity>(DecimalType, QuantityType);
        public FunctionDef DateToDateTime = unary<ToDateTime>(DateType, DateTimeType);
        public FunctionDef CodeToConcept = unary<ToConcept>(CodeType, ConceptType);

        public FunctionDef[] Add = binary<Add>(T, T, T).For(T, IntegerType, LongType, DecimalType, QuantityType);
        public FunctionDef[] AddDateTime = binary<Add>(T, QuantityType, T).For(T, DateType, DateTimeType, TimeType);

        public FunctionDef[] Subtract = binary<Subtract>(T, T, T).For(T, IntegerType, LongType, DecimalType, QuantityType);
        public FunctionDef[] SubtractDateTime = binary<Subtract>(T, QuantityType, T).For(T, DateType, DateTimeType, TimeType);

        public FunctionDef Concatenate = binary<Concatenate>(StringType, StringType, StringType);
        public FunctionDef[] DifferenceBetween = binary<DifferenceBetween>(T, T, IntegerType).For(T, DateType, DateTimeType, TimeType);
        public FunctionDef[] DurationBetween = binary<DurationBetween>(T, T, IntegerType).For(T, DateType, DateTimeType, TimeType);
        public FunctionDef Implies = binary<Implies>(BooleanType, BooleanType, BooleanType);
        public FunctionDef Or = binary<Or>(BooleanType, BooleanType, BooleanType);
        public FunctionDef Xor = binary<Xor>(BooleanType, BooleanType, BooleanType);
    }
}