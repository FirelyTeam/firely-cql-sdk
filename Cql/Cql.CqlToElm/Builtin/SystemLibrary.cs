/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Elm;
using System;
using System.Linq;
using System.Xml;
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
            And,
            IntegerToDecimal, LongToDecimal, IntegerToLong, IntegerToQuantity, DecimalToQuantity, DateToDateTime, CodeToConcept,
        };

        private static BuiltInFunctionDef unary<T>(TypeSpecifier argument, TypeSpecifier result) where T : OperatorExpression =>
            new(typeof(T).Name, new[] { argument }, result, typeof(T));

        private static BuiltInFunctionDef binary<T>(TypeSpecifier first, TypeSpecifier second, TypeSpecifier result) where T : OperatorExpression =>
            new(typeof(T).Name, new[] { first, second }, result, typeof(T));

        public static BuiltInFunctionDef End = unary<End>(T.ToIntervalType(), T);
        public static BuiltInFunctionDef Exists = unary<Exists>(T.ToListType(), BooleanType);
        public static BuiltInFunctionDef IsFalse = unary<IsFalse>(BooleanType, BooleanType);
        public static BuiltInFunctionDef IsNull = unary<IsNull>(AnyType, BooleanType);
        public static BuiltInFunctionDef IsTrue = unary<IsTrue>(BooleanType, BooleanType);
        public static BuiltInFunctionDef ToList = unary<ToList>(T, T.ToListType());
        public static BuiltInFunctionDef Not = unary<Not>(BooleanType, BooleanType);
        public static BuiltInFunctionDef SingletonFrom = unary<SingletonFrom>(T.ToListType(), T);
        public static BuiltInFunctionDef Start = unary<Start>(T.ToIntervalType(), T);
        public static BuiltInFunctionDef PointFrom = unary<PointFrom>(T.ToIntervalType(), T);
        public static BuiltInFunctionDef Width = unary<Width>(T.ToIntervalType(), T);
        public static BuiltInFunctionDef Predecessor = unary<Predecessor>(T, T);
        public static BuiltInFunctionDef Successor = unary<Successor>(T, T);

        public static AsFunctionDef As = new();
        public static IsFunctionDef Is = new();
        public static MinValueFunctionDef MinValue = new();
        public static MaxValueFunctionDef MaxValue = new();

        public static BuiltInFunctionDef And = binary<And>(BooleanType, BooleanType, BooleanType);

        public static BuiltInFunctionDef IntegerToDecimal = unary<ToDecimal>(IntegerType, DecimalType);
        public static BuiltInFunctionDef LongToDecimal = unary<ToDecimal>(LongType, DecimalType);
        public static BuiltInFunctionDef IntegerToLong = unary<ToLong>(IntegerType, LongType);
        public static BuiltInFunctionDef IntegerToQuantity = unary<ToQuantity>(IntegerType, QuantityType);
        public static BuiltInFunctionDef LongToQuantity = unary<ToQuantity>(LongType, QuantityType);
        public static BuiltInFunctionDef DecimalToQuantity = unary<ToQuantity>(DecimalType, QuantityType);
        public static BuiltInFunctionDef DateToDateTime = unary<ToDateTime>(DateType, DateTimeType);
        public static BuiltInFunctionDef CodeToConcept = unary<ToConcept>(CodeType, ConceptType);

        public static BuiltInFunctionDef[] Add = binary<Add>(T, T, T).For(T, IntegerType, LongType, DecimalType, QuantityType);
        public static BuiltInFunctionDef[] AddDateTime = binary<Add>(T, QuantityType, T).For(T, DateType, DateTimeType, TimeType);

        public static BuiltInFunctionDef[] Subtract = binary<Subtract>(T, T, T).For(T, IntegerType, LongType, DecimalType, QuantityType);
        public static BuiltInFunctionDef[] SubtractDateTime = binary<Subtract>(T, QuantityType, T).For(T, DateType, DateTimeType, TimeType);

        public static BuiltInFunctionDef Concatenate = binary<Concatenate>(StringType, StringType, StringType);
        public static BuiltInFunctionDef[] DifferenceBetween = binary<DifferenceBetween>(T, T, IntegerType).For(T, DateType, DateTimeType, TimeType);
        public static BuiltInFunctionDef Implies = binary<Implies>(BooleanType, BooleanType, BooleanType);
        public static BuiltInFunctionDef Or = binary<Or>(BooleanType, BooleanType, BooleanType);
        public static BuiltInFunctionDef Xor = binary<Xor>(BooleanType, BooleanType, BooleanType);
    }
}