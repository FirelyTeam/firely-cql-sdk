using Hl7.Cql.Elm;
using System;
using static Hl7.Cql.Elm.SystemTypes;

namespace Hl7.Cql.CqlToElm
{

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
            Is, As, Cast,
            MinValue, MaxValue
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
        public static AsFunctionDef As = new(strict: false);
        public static AsFunctionDef Cast = new(strict: true);
        public static IsFunctionDef Is = new();
        public static MinValueFunctionDef MinValue = new();
        public static MaxValueFunctionDef MaxValue = new();
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
          : base(nameof(As), T)
        {
            operand = new[] { new OperandDef { name = $"operand", operandTypeSpecifier = AnyType }.WithResultType(AnyType) };
            Strict = strict;
        }

        public bool Strict { get; }

        // This method will probably remain unused, since we want `(cast) as` to not be influenced by automatic promotions,
        // i.e. I *think* `{ true } is Boolean` should be false, even though `{ true }` can be demoted to `Boolean`,
        // otherwise, testing for `Boolean` would be impossible. Maybe we should clarify the CQL spec to say
        // that `cast as` and also `is` are not subject to automatic promotion.
        //public UnaryExpression Build(IModelProvider provider, TypeSpecifier typeArgument, Expression argument)
        //{
        //    var castBuilder = new CastBuilder(provider);

        //    // Note how the official operand type is ignored, but we check against the given type argument now.
        //    var success = castBuilder.TryBuildCast(argument, typeArgument, out var cast);

        //    if (!success)
        //        throw new InvalidOperationException($"Failed to bind 'as' operator - the operand has type {typeArgument} which is not " +
        //            $"compatible with an argument of type {argument.resultTypeSpecifier}.");

        //    var asTypeSpec = typeArgument.ReplaceGenericParameters(castBuilder.GenericAssignments);
        //    return Create(asTypeSpec, cast!);
        //}

        internal As Create(TypeSpecifier typeArgument, Expression argument)
        {
            return new As()
            {
                strict = Strict,
                operand = argument,
                asTypeSpecifier = typeArgument,
                asType = typeArgument is NamedTypeSpecifier nts ? nts.name : null,
            }.WithResultType(typeArgument);
        }
    }


    internal class IsFunctionDef : BuiltInFunctionDef
    {
        public IsFunctionDef()
          : base(nameof(Is), T)
        {
            operand = new[] { new OperandDef { name = $"operand", operandTypeSpecifier = AnyType }.WithResultType(AnyType) };
        }

        internal Is Create(TypeSpecifier typeArgument, Expression argument)
        {
            return new Is()
            {
                operand = argument,
                isTypeSpecifier = typeArgument,
                isType = typeArgument is NamedTypeSpecifier nts ? nts.name : null,
            }.WithResultType(typeArgument);
        }
    }

    internal class MinValueFunctionDef : BuiltInFunctionDef
    {
        public MinValueFunctionDef()
            : base(nameof(MinValue), T)
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
            : base(nameof(MaxValue), T)
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