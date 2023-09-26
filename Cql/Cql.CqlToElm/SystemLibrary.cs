using Hl7.Cql.Elm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Hl7.Cql.CqlToElm
{
    internal class GenericTypeParameterTypeSpecifier : TypeSpecifier
    {
        public GenericTypeParameterTypeSpecifier(string name) => Name = name;

        public string Name { get; set; }
    }

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


    /* 
     *             operand = 
                .Select((ts, ix) => new OperandDef { name = $"param{ix}", operandTypeSpecifier = ts, resultTypeSpecifier = ts })
                .ToArray();
    */

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
                resultTypeSpecifier = castBuilder.Replace(resultTypeSpecifier),
                operand = cast
            };

            return result;
        }
    }

    internal class GenericParameterAssignments : Dictionary<GenericTypeParameterTypeSpecifier, TypeSpecifier>
    {
        // nothing
    }


    internal class CastBuilder
    {
        public GenericParameterAssignments GenericAssignments { get; } = new GenericParameterAssignments();
        public IModelProvider Provider { get; }

        public CastBuilder(IModelProvider provider)
        {
            Provider = provider;
        }

        // TODO: poor man's replace, should add this to the typespecs itself in a recursive way
        public TypeSpecifier Replace(TypeSpecifier ts)
        {
            if (ts is GenericTypeParameterTypeSpecifier gts)
            {
                if (GenericAssignments.TryGetValue(gts, out var replacement))
                    return replacement;
                else
                    throw new InvalidOperationException($"Found unbound generic parameter {gts.Name}.");
            }
            else if (ts is ListTypeSpecifier lts)
            {
                return new ListTypeSpecifier { elementType = Replace(lts.elementType) };
            }
            else
                return ts;
        }

        public bool TryBuildCast(Expression fromExpr, TypeSpecifier to, out Expression? result)
        {
            var from = fromExpr.resultTypeSpecifier;

            // The trivial case, equal types
            if (from == to)
            {
                result = fromExpr;
                return true;
            }

            // if parameter type is any, then any argument type is ok.
            // This is really a poor-mans IsAssignableTo, but it will do for now.
            if (to is NamedTypeSpecifier nts && nts.name == SystemTypes.AnyTypeQName)
            {
                result = fromExpr;
                return true;
            }

            // If the parameter type is a generic type parameter, then we can assign any type to it,
            // unless it is already assigned to previously, in which case we need to check we can cast
            // to the assigned type for that generic type parameter.
            if (to is GenericTypeParameterTypeSpecifier gtp)
            {
                if (GenericAssignments.TryGetValue(gtp, out var assignedType))
                    return TryBuildCast(fromExpr, assignedType, out result);
                else
                {
                    result = fromExpr;
                    GenericAssignments.Add(gtp, fromExpr.resultTypeSpecifier);
                    return true;
                }
            }

            // Nulls get promoted to any type necessary
            if (fromExpr is Null n)
            {
                result = SystemLibrary.As(n, to);
                return true;
            }

            // Casting a list of X to a list of Y
            if (from is ListTypeSpecifier fromList && to is ListTypeSpecifier toList)
            {
                var dummyNull = new Null { resultTypeSpecifier = fromList.elementType };
                var elementCastSuccess = TryBuildCast(dummyNull, toList.elementType, out var elementCast);

                // For now, we assume that we have no co- or contravariance, so only the "identity" cast is allowed
                // (note that this may mean we have assigned a type to a generic type parameter.
                if (elementCastSuccess && elementCast == dummyNull)
                {
                    result = fromExpr;
                    return true;
                }
                else
                {
                    result = default;
                    return false;
                }
            }

            // List demotion
            if (from is ListTypeSpecifier && to is not ListTypeSpecifier)
            {
                try
                {
                    var nested = SystemLibrary.SingletonFrom.Build(Provider, fromExpr);
                    return TryBuildCast(nested, to, out result);
                }
                catch
                {
                    result = default;
                    return false;
                }
            }


            // rest is not supported yet
            throw new NotImplementedException($"Cannot yet cast from {fromExpr.resultTypeSpecifier} to {to}.");
        }

    }

}
