using Hl7.Cql.Elm;
using System;

namespace Hl7.Cql.CqlToElm
{

    internal class SystemLibrary : Library
    {
        public SystemLibrary()
        {
            identifier = new VersionedIdentifier() { id = SystemTypes.SystemModelPrefix, version = SystemTypes.SystemModelVersion };

            statements = systemFunctions;
        }

        private readonly ExpressionDef[] systemFunctions =
        {
            IsNull, IsTrue, IsFalse,
            Not,
            Exists, SingletonFrom, ToList,
            Start, End, PointFrom, Width,
            Predecessor, Successor,
            As, Cast,
            MinValue, MaxValue
        };

        public static BuiltInUnaryFunctionDef<End> End = new(nameof(End), SystemTypes.Generic("T").ToIntervalType(), SystemTypes.Generic("T"));
        public static BuiltInUnaryFunctionDef<Exists> Exists = new(nameof(Exists), SystemTypes.Generic("T").ToListType(), SystemTypes.BooleanType);
        public static BuiltInUnaryFunctionDef<IsFalse> IsFalse = new(nameof(IsFalse), SystemTypes.BooleanType, SystemTypes.BooleanType);
        public static BuiltInUnaryFunctionDef<IsNull> IsNull = new(nameof(IsNull), SystemTypes.AnyType, SystemTypes.BooleanType);
        public static BuiltInUnaryFunctionDef<IsTrue> IsTrue = new(nameof(IsTrue), SystemTypes.BooleanType, SystemTypes.BooleanType);
        public static BuiltInUnaryFunctionDef<ToList> ToList = new(nameof(ToList), SystemTypes.Generic("T"), SystemTypes.Generic("T").ToListType());
        public static BuiltInUnaryFunctionDef<Not> Not = new(nameof(Not), SystemTypes.BooleanType, SystemTypes.BooleanType);
        public static BuiltInUnaryFunctionDef<SingletonFrom> SingletonFrom = new(nameof(SingletonFrom), SystemTypes.Generic("T").ToListType(), SystemTypes.Generic("T"));
        public static BuiltInUnaryFunctionDef<Start> Start = new(nameof(Start), SystemTypes.Generic("T").ToIntervalType(), SystemTypes.Generic("T"));
        public static BuiltInUnaryFunctionDef<PointFrom> PointFrom = new(nameof(PointFrom), SystemTypes.Generic("T").ToIntervalType(), SystemTypes.Generic("T"));
        public static BuiltInUnaryFunctionDef<Width> Width = new(nameof(Width), SystemTypes.Generic("T").ToIntervalType(), SystemTypes.Generic("T"));
        public static BuiltInUnaryFunctionDef<Predecessor> Predecessor = new(nameof(Predecessor), SystemTypes.Generic("T"), SystemTypes.Generic("T"));
        public static BuiltInUnaryFunctionDef<Successor> Successor = new(nameof(Successor), SystemTypes.Generic("T"), SystemTypes.Generic("T"));
        public static AsFunctionDef As = new(strict: false);
        public static AsFunctionDef Cast = new(strict: true);
        public static MinValueFunctionDef MinValue = new();
        public static MinValueFunctionDef MaxValue = new();
    }

    //TODO: Subtypes for functions that only take ordered types?  The checking of the argument should really be done in the Build() method....
    internal class BuiltInFunctionDef : FunctionDef
    {
        public BuiltInFunctionDef(string name, TypeSpecifier resultType)
        {
            this.name = name;
            expression = null;
            external = true;
            fluent = false;   // not too sure, maybe should be true for fhirpath functions?
            context = null;    // any context?
            accessLevel = AccessModifier.Public;    // All built-in functions are public                
            resultTypeSpecifier = resultType;

            if (resultType is NamedTypeSpecifier nts)
                resultTypeName = nts.name;
        }
    }

    internal class BuiltInUnaryFunctionDef<E> : BuiltInFunctionDef where E : UnaryExpression, new()
    {
        public BuiltInUnaryFunctionDef(string name, TypeSpecifier operandType, TypeSpecifier resultType)
            : base(name, resultType)
        {
            operand = new[] { new OperandDef { name = $"operand", operandTypeSpecifier = operandType }.WithResultType(operandType) };
        }

        public virtual UnaryExpression Build(IModelProvider provider, Expression argument)
        {
            var castBuilder = new CastBuilder(provider);
            var to = operand[0].operandTypeSpecifier;
            var success = castBuilder.TryBuildCast(argument, to, out var cast);

            if (!success)
                throw new InvalidOperationException($"Failed to bind to unary operator '{name}' - the operand has type {to} which is not " +
                    $"compatible with an argument of type {argument.resultTypeSpecifier}.");

            var result = new E()
            {
                operand = cast
            }.WithResultType(resultTypeSpecifier.ReplaceGenericParameters(castBuilder.GenericAssignments));

            return result;
        }
    }

    internal class AsFunctionDef : BuiltInFunctionDef
    {
        public AsFunctionDef(bool strict)
          : base(nameof(As), SystemTypes.Generic("T"))
        {
            operand = new[] { new OperandDef { name = $"operand", operandTypeSpecifier = SystemTypes.AnyType }.WithResultType(SystemTypes.AnyType) };
            Strict = strict;
        }

        public bool Strict { get; }

        // TODO: Test this by replacing the the current implementation of cast/as and run tests in Cql/Cql.CqlToElmTests/AsTest.cs
        public UnaryExpression Build(IModelProvider provider, TypeSpecifier typeArgument, Expression argument)
        {
            var castBuilder = new CastBuilder(provider);

            // Note how the official operand type is ignored, but we check against the given type argument now.
            var success = castBuilder.TryBuildCast(argument, typeArgument, out var cast);

            if (!success)
                throw new InvalidOperationException($"Failed to bind 'as' operator - the operand has type {typeArgument} which is not " +
                    $"compatible with an argument of type {argument.resultTypeSpecifier}.");

            var asTypeSpec = typeArgument.ReplaceGenericParameters(castBuilder.GenericAssignments);
            return Create(asTypeSpec, cast!);
        }

        internal UnaryExpression Create(TypeSpecifier typeArgument, Expression argument)
        {
            return new As()
            {
                strict = Strict,
                operand = argument,
                asTypeSpecifier = typeArgument
            }.WithResultType(typeArgument);
        }
    }

    internal class MinValueFunctionDef : BuiltInFunctionDef
    {
        public MinValueFunctionDef()
            : base(nameof(MinValue), SystemTypes.Generic("T"))
        {
            operand = Array.Empty<OperandDef>();
        }

        public Expression Build(NamedTypeSpecifier typeArgument)
        {
            return new MinValue()
            {
                valueType = typeArgument.name,
            }.WithResultType(typeArgument);
        }
    }

    internal class MaxValueFunctionDef : BuiltInFunctionDef
    {
        public MaxValueFunctionDef()
            : base(nameof(MaxValue), SystemTypes.Generic("T"))
        {
            operand = Array.Empty<OperandDef>();
        }

        public Expression Build(NamedTypeSpecifier typeArgument)
        {
            return new MaxValue()
            {
                valueType = typeArgument.name,
            }.WithResultType(typeArgument);
        }
    }
}