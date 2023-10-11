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
            UnionInterval, UnionList
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
        public static BuiltinNaryFunctionDef<Union> UnionInterval = new(nameof(UnionInterval), T.ToIntervalType(), T.ToIntervalType(), T.ToIntervalType());
        public static BuiltinNaryFunctionDef<Union> UnionList = new(nameof(UnionList), T.ToListType(), T.ToListType(), T.ToListType());
    }

    internal class BuiltInUnaryFunctionDef<E> : BuiltInFunctionDef where E : UnaryExpression, new()
    {
        public BuiltInUnaryFunctionDef(string name, TypeSpecifier operand, TypeSpecifier resultType) : base(name, new[] { operand }, resultType)
        {
        }
    }

    internal class BuiltinNaryFunctionDef<E> : BuiltInFunctionDef where E : NaryExpression, new()
    {
        // Convenience constructor for Nary functions having just two operands.
        // (don't want to have to specify the array for the common case)
        public BuiltinNaryFunctionDef(string name, TypeSpecifier lhs, TypeSpecifier rhs, TypeSpecifier resultType)
            : base(name, new[] { lhs, rhs }, resultType)
        {
        }
    }
}