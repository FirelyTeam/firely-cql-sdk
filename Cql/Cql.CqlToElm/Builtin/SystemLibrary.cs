/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Elm;
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
            UnionInterval, UnionList,
            And,
            IntegerToDecimal, LongToDecimal, IntegerToLong, IntegerToQuantity, DecimalToQuantity, DateToDateTime, CodeToConcept
        };

        public static BuiltInUnaryFunctionDef<End> End = new(nameof(End), T.ToIntervalType(), T);
        public static BuiltInUnaryFunctionDef<Exists> Exists = new(nameof(Exists), T.ToListType(), BooleanType);
        public static BuiltInUnaryFunctionDef<IsFalse> IsFalse = new(nameof(IsFalse), BooleanType, BooleanType);
        public static BuiltInUnaryFunctionDef<IsNull> IsNull = new(nameof(IsNull), AnyType, BooleanType);
        public static BuiltInUnaryFunctionDef<IsTrue> IsTrue = new(nameof(IsTrue), BooleanType, BooleanType);
        public static BuiltInUnaryFunctionDef<ToList> ToList = new(nameof(ToList), T, T.ToListType());
        public static BuiltInUnaryFunctionDef<Not> Not = new(nameof(Not), BooleanType, BooleanType);
        public static BuiltInUnaryFunctionDef<SingletonFrom> SingletonFrom = new(nameof(SingletonFrom), T.ToListType(), T);
        public static BuiltInUnaryFunctionDef<Start> Start = new(nameof(Start), T.ToIntervalType(), T);
        public static BuiltInUnaryFunctionDef<PointFrom> PointFrom = new(nameof(PointFrom), T.ToIntervalType(), T);
        public static BuiltInUnaryFunctionDef<Width> Width = new(nameof(Width), T.ToIntervalType(), T);
        public static BuiltInUnaryFunctionDef<Predecessor> Predecessor = new(nameof(Predecessor), T, T);
        public static BuiltInUnaryFunctionDef<Successor> Successor = new(nameof(Successor), T, T);

        public static AsFunctionDef As = new();
        public static IsFunctionDef Is = new();
        public static MinValueFunctionDef MinValue = new();
        public static MaxValueFunctionDef MaxValue = new();

        public static BuiltInNaryFunctionDef<Union> UnionInterval = new(nameof(Union), T.ToIntervalType(), T.ToIntervalType(), T.ToIntervalType());
        public static BuiltInNaryFunctionDef<Union> UnionList = new(nameof(Union), T.ToListType(), T.ToListType(), T.ToListType());

        public static BuiltInBinaryFunctionDef<And> And = new(nameof(And), BooleanType, BooleanType, BooleanType);

        public static BuiltInConversionFunctionDef<ToDecimal> IntegerToDecimal = new(nameof(ToDecimal), IntegerType, DecimalType);
        public static BuiltInConversionFunctionDef<ToDecimal> LongToDecimal = new(nameof(ToDecimal), LongType, DecimalType);
        public static BuiltInConversionFunctionDef<ToLong> IntegerToLong = new(nameof(ToLong), IntegerType, LongType);
        public static BuiltInConversionFunctionDef<ToQuantity> IntegerToQuantity = new(nameof(ToQuantity), IntegerType, QuantityType);
        public static BuiltInConversionFunctionDef<ToQuantity> LongToQuantity = new(nameof(ToQuantity), LongType, QuantityType);
        public static BuiltInConversionFunctionDef<ToQuantity> DecimalToQuantity = new(nameof(ToQuantity), DecimalType, QuantityType);
        public static BuiltInConversionFunctionDef<ToDateTime> DateToDateTime = new(nameof(ToDateTime), DateType, DateTimeType);
        public static BuiltInConversionFunctionDef<ToConcept> CodeToConcept = new(nameof(ToConcept), CodeType, ConceptType);

        public static BuiltInBinaryFunctionDef<Add> AddInteger = new(nameof(Add), IntegerType, IntegerType, IntegerType);
        public static BuiltInBinaryFunctionDef<Add> AddLong = new(nameof(Add), LongType, LongType, LongType);
        public static BuiltInBinaryFunctionDef<Add> AddDecimal = new(nameof(Add), DecimalType, DecimalType, DecimalType);
        public static BuiltInBinaryFunctionDef<Add> AddQuantity = new(nameof(Add), QuantityType, QuantityType, QuantityType);
        public static BuiltInBinaryFunctionDef<Add> AddDate = new(nameof(Add), DateType, QuantityType, DateType);
        public static BuiltInBinaryFunctionDef<Add> AddDateTime = new(nameof(Add), DateTimeType, QuantityType, DateTimeType);
        public static BuiltInBinaryFunctionDef<Add> AddTime = new(nameof(Add), TimeType, QuantityType, TimeType);

        public static BuiltInBinaryFunctionDef<Subtract> SubtractInteger = new(nameof(Add), IntegerType, IntegerType, IntegerType);
        public static BuiltInBinaryFunctionDef<Subtract> SubtractLong = new(nameof(Add), LongType, LongType, LongType);
        public static BuiltInBinaryFunctionDef<Subtract> SubtractDecimal = new(nameof(Add), DecimalType, DecimalType, DecimalType);
        public static BuiltInBinaryFunctionDef<Subtract> SubtractQuantity = new(nameof(Add), QuantityType, QuantityType, QuantityType);
        public static BuiltInBinaryFunctionDef<Subtract> SubtractDate = new(nameof(Add), DateType, QuantityType, DateType);
        public static BuiltInBinaryFunctionDef<Subtract> SubtractDateTime = new(nameof(Add), DateTimeType, QuantityType, DateTimeType);
        public static BuiltInBinaryFunctionDef<Subtract> SubtractTime = new(nameof(Add), TimeType, QuantityType, TimeType);

        public static BuiltInNaryFunctionDef<Concatenate> Concatenate = new(nameof(Concatenate), StringType, StringType, StringType);
    }


    internal class BuiltInConversionFunctionDef<U> : BuiltInFunctionDef where U : UnaryExpression, new()
    {
        public BuiltInConversionFunctionDef(string name, TypeSpecifier operand, TypeSpecifier resultType) : base(name, new[] { operand }, resultType)
        {
        }
    }


    internal class BuiltInUnaryFunctionDef<E> : BuiltInFunctionDef where E : UnaryExpression, new()
    {
        public BuiltInUnaryFunctionDef(string name, TypeSpecifier operand, TypeSpecifier resultType) : base(name, new[] { operand }, resultType)
        {
        }
    }

    internal class BuiltInBinaryFunctionDef<E> : BuiltInFunctionDef where E : BinaryExpression, new()
    {
        public BuiltInBinaryFunctionDef(string name, TypeSpecifier left, TypeSpecifier right, TypeSpecifier resultType) : base(name, new[] { left, right }, resultType)
        {
        }
    }

    internal class BuiltInNaryFunctionDef<E> : BuiltInFunctionDef where E : NaryExpression, new()
    {
        // Convenience constructor for Nary functions having just two operands.
        // (don't want to have to specify the array for the common case)
        public BuiltInNaryFunctionDef(string name, TypeSpecifier lhs, TypeSpecifier rhs, TypeSpecifier resultType)
            : base(name, new[] { lhs, rhs }, resultType)
        {
        }
    }
}