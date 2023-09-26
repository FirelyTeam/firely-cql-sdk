using Hl7.Cql.Elm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Hl7.Cql.CqlToElm
{

    internal class SystemLibrary : Library
    {
        public SystemLibrary()
        {
            identifier = new VersionedIdentifier() { id = SystemTypes.SystemModelPrefix, version = SystemTypes.SystemModelVersion };

            statements = buildSystemFunctions().ToArray();
        }

        private IEnumerable<ExpressionDef> buildSystemFunctions()
        {
            yield return IsNull;
            yield return IsTrue;
            yield return IsFalse;
            yield return Not;
            yield return SingletonFrom;
        }

        public static BuiltInUnaryFunctionDef<IsNull> IsNull = new("IsNull", SystemTypes.AnyType, SystemTypes.BooleanType);
        public static BuiltInUnaryFunctionDef<IsTrue> IsTrue = new("IsTrue", SystemTypes.BooleanType, SystemTypes.BooleanType);
        public static BuiltInUnaryFunctionDef<IsFalse> IsFalse = new("IsFalse", SystemTypes.BooleanType, SystemTypes.BooleanType);
        public static BuiltInUnaryFunctionDef<Not> Not = new("Not", SystemTypes.BooleanType, SystemTypes.BooleanType);
        public static BuiltInUnaryFunctionDef<SingletonFrom> SingletonFrom = new("SingletonFrom", SystemTypes.Generic("T").ToListType(), SystemTypes.Generic("T"));

        // As in most languages, As is a bit of a special case, since it's signature is hard to pin down, its argument being
        // "a type specifier" instead of a type.
        public static As As(Expression operand, TypeSpecifier targetType) => new As
        {
            operand = operand,
            asTypeSpecifier = targetType
        }.WithResultType(targetType);
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
        }
    }

    internal class BuiltInUnaryFunctionDef<E> : BuiltInFunctionDef<E> where E : UnaryExpression, new()
    {
        public BuiltInUnaryFunctionDef(string name, TypeSpecifier operandType, TypeSpecifier resultType)
            : base(name, resultType)
        {
            operand = new[] { new OperandDef { name = $"operand", operandTypeSpecifier = operandType, resultTypeSpecifier = operandType } };
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
                resultTypeSpecifier = resultTypeSpecifier.ReplaceGenericParameters(castBuilder.GenericAssignments),
                operand = cast
            };

            return result;
        }
    }
}
