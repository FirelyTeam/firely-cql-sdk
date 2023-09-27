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
            Predecessor, Successor

            //TODO: turn As and MinValue/MaxValue into functions
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

        // As in most languages, As is a bit of a special case, since it's signature is hard to pin down, its argument being
        // "a type specifier" instead of a type.
        public static As As(Expression operand, TypeSpecifier targetType) => new As
        {
            operand = operand,
            asTypeSpecifier = targetType
        }.WithResultType(targetType);

        public static MinValue MinValue(NamedTypeSpecifier type) => new MinValue
        {
            valueType = type.name
        }.WithResultType(type);

        public static MaxValue MaxValue(NamedTypeSpecifier type) => new MaxValue
        {
            valueType = type.name
        }.WithResultType(type);

    }

    internal abstract class BuiltInFunctionDef<T> : FunctionDef where T : Expression, new()
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

    internal class BuiltInUnaryFunctionDef<E> : BuiltInFunctionDef<E> where E : UnaryExpression, new()
    {
        public BuiltInUnaryFunctionDef(string name, TypeSpecifier operandType, TypeSpecifier resultType)
            : base(name, resultType)
        {
            operand = new[] { new OperandDef { name = $"operand", operandTypeSpecifier = operandType }.WithResultType(operandType) };
        }

        public UnaryExpression Build(IModelProvider provider, Expression argument)
        {
            var castBuilder = new CastBuilder(provider);
            var from = argument.resultTypeSpecifier;
            var to = operand[0].operandTypeSpecifier;
            var success = castBuilder.TryBuildCast(argument, to, out var cast);

            if (!success)
                throw new InvalidOperationException($"Failed to bind to unary operator '{name}' - the operand has type {to} which is not " +
                    $"compatible with an argument of type {from}.");

            var result = new E()
            {
                operand = cast
            }.WithResultType(resultTypeSpecifier.ReplaceGenericParameters(castBuilder.GenericAssignments));

            return result;
        }
    }
}
