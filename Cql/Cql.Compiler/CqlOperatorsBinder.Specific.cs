/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Compiler.Infrastructure;
using Hl7.Cql.Operators;
using Hl7.Cql.Primitives;
using Hl7.Cql.ValueSets;

namespace Hl7.Cql.Compiler;

/// <summary>
/// The hand-written bindings (Select/Where/SelectMany/Retrieve/Coalesce/etc. with generic
/// type construction). See the remarks on <see cref="CqlOperatorsBinder"/>.
/// </summary>
partial class CqlOperatorsBinder
{
    private CodeExpression SortBy(
        CodeExpression source,
        CodeExpression by,
        CodeExpression order)
    {
        if (by is CodeLambda lambda && order is CodeConstant orderConstant && orderConstant.Type == typeof(ListSortDirection))
        {
            var elementType = _typeResolver.GetListElementType(source.Type) ?? throw new InvalidOperationException($"'{source.Type}' was expected to be a list type.");
            var call = BindToBestMethodOverload(nameof(ICqlOperators.SortBy), [source, lambda, orderConstant], [elementType])!;
            return call;

        }

        throw new ArgumentException("SortBy expects 3 parameters: source, lambda, and SortOrder constant", nameof(by));
    }

    private CodeExpression InList(
        CodeExpression left,
        CodeExpression right)
    {
        if (left.Type == typeof(CqlCode))
        {
            var rightElementType = _typeResolver.GetListElementType(right.Type);
            if (rightElementType == typeof(CqlCode))
            {
                return BindToBestMethodOverload(nameof(ICqlOperators.CodeInList), [left, right], [])!;
            }
        }

        var (methodInfo, convertedArgs) = ResolveMethodInfoWithPotentialArgumentConversions(nameof(ICqlOperators.In), [left, right], [], false);
        if (methodInfo is null)
            return new CodeConstant(null, typeof(object));

        var call = new CodeInvoke(OperatorsReceiver, methodInfo, convertedArgs);
        return call;
    }

    private CodeExpression Union(
        CodeExpression left,
        CodeExpression right)
    {
        if (left.Type == typeof(IValueSetFacade) && right.Type == typeof(IValueSetFacade))
        {
            return BindToBestMethodOverload(
                nameof(ICqlOperators.ValueSetUnion),
                [left.NewTypeAsExpression(typeof(IEnumerable<CqlCode>)), right.NewTypeAsExpression(typeof(IEnumerable<CqlCode>))],
                [])!;
        }
        var leftElementType = _typeResolver.GetListElementType(left.Type);
        if (leftElementType == typeof(CqlCode))
        {
            var rightElementType = _typeResolver.GetListElementType(right.Type);
            if (rightElementType == typeof(CqlCode))
            {
                return BindToBestMethodOverload(nameof(ICqlOperators.ValueSetUnion), [left, right], [])!;
            }
        }

        // Check if we have compatible list types with different element types
        var leftListElementType = _typeResolver.GetListElementType(left.Type);
        var rightListElementType = _typeResolver.GetListElementType(right.Type);
        if (leftListElementType != null && rightListElementType != null && leftListElementType != rightListElementType)
        {
            // Check if the element types are structurally compatible for union
            if (ElmTupleTypeUtility.AreCompatibleForUnionOperation(leftListElementType, rightListElementType, _typeConverter))
            {
                // Cast both to IEnumerable<object> to allow union
                var leftAsObjectEnumerable = left.NewTypeAsExpression(typeof(IEnumerable<object>));
                var rightAsObjectEnumerable = right.NewTypeAsExpression(typeof(IEnumerable<object>));
                return BindToBestMethodOverload(nameof(ICqlOperators.Union), [leftAsObjectEnumerable, rightAsObjectEnumerable], [])!;
            }
        }

        return BindToBestMethodOverload(nameof(ICqlOperators.Union), [left, right], [])!;
    }

    private CodeExpression ResolveValueSet(CodeExpression expression)
    {
        if (expression is CodeNew @new && @new.Type == typeof(CqlValueSet))
        {
            var call = BindToDirectMethod(nameof(ICqlOperators.ResolveValueSet), @new);
            return call;
        }

        throw new ArgumentException($"Expression should be a 'new {nameof(CqlValueSet)}(...)' construction, but was a {expression.GetType().Name} of type {expression.Type}.");
    }

    private CodeExpression Coalesce(CodeExpression operand)
    {
        var elementType = _typeResolver.GetListElementType(operand.Type, throwError: false)
            ?? throw new ArgumentException(
                "Operands to this method must be list-like with a single element type, e.g. IEnumerable<T>",
                nameof(operand));

        if (elementType.IsValueType && Nullable.GetUnderlyingType(elementType) is null)
            throw new ArgumentException(
                $"Coalesce<T> requires T to be a reference type or Nullable<U>, but found non-nullable value type '{elementType}'.",
                nameof(operand));

        // Always use Coalesce<T>, which is unconstrained and handles reference types,
        // nullable value types (T = Nullable<U> returns null when no match), and tuples alike.
        return BindToBestMethodOverload(nameof(ICqlOperators.Coalesce), [operand], [elementType])!;
    }

    private CodeExpression Flatten(CodeExpression operand)
    {
        var elementType = _typeResolver.GetListElementType(operand.Type, throwError: true)!;
        if (_typeResolver.IsListType(elementType))
        {
            var nestedElementType = _typeResolver.GetListElementType(elementType) ?? throw new InvalidOperationException($"'{elementType}' was expected to be a list type.");
            var call = BindToBestMethodOverload(nameof(ICqlOperators.Flatten), [operand], [nestedElementType])!;
            return call;
        }

        if (elementType == typeof(object))
        {
            // This scenario can happen in late-bound property chains
            var call = BindToDirectMethod(nameof(ICqlOperators.FlattenLateBoundList), operand);
            return call;
        }

        return operand; // flatten is being called on a list that is already flat.
    }

    private CodeInvoke LateBoundProperty(
        CodeExpression source,
        CodeExpression propertyName,
        CodeExpression typeExpression)
    {
        if (typeExpression is CodeConstant { Value: Type type })
        {
            if (source.Type != typeof(object))
                source = source.NewTypeAsExpression(typeof(object));

            var call = BindToBestMethodOverload(nameof(ICqlOperators.LateBoundProperty), [source, propertyName], [type!])!;
            return call;
        }

        throw new ArgumentException("Expected constant type expression", nameof(typeExpression));
    }

    /// <summary>
    /// Handles explicit conversions, i.e., the Convert operator
    /// </summary>
    private CodeExpression BindConvert(
        CodeExpression source,
        CodeExpression typeExpression)
    {
        if (typeExpression is not CodeConstant { Value: Type toType })
            throw new ArgumentException("Expected constant type expression", nameof(typeExpression));

        var methodName = CqlOperators.ConversionFunctionName(source.Type, toType);
        if (methodName != null)
        {
            var call = BindToDirectMethod(methodName, source);
            return call;
        }

        return TryConvert(source, toType, out var t)
            ? t.arg!
            : throw new ArgumentException($"Cannot convert {source.Type} to {toType}", nameof(source));
    }


    private CodeInvoke Retrieve(
        CodeExpression typeExpression,
        CodeExpression valueSetOrCodes,
        CodeExpression codePropertyExpression,
        CodeExpression templateId)
    {
        if (typeExpression is not CodeConstant ce || ce.Type != typeof(Type))
            throw new ArgumentException("First parameter to Retrieve is expected to be a constant Type", nameof(typeExpression));

        if (ce.Value is not Type type
            || codePropertyExpression is not CodeConstant cpe
            || cpe.Type != typeof(PropertyInfo))
            throw new ArgumentException("Third parameter to Retrieve is expected to be a constant PropertyInfo", nameof(codePropertyExpression));

        if (cpe.Value is PropertyInfo pi)
        {
            var declaringType = pi!.DeclaringType;
            var propName = pi.Name;
            var method = typeof(Type).GetMethod(nameof(Type.GetProperty), [typeof(string)])!;
            var typeOf = new CodeConstant(declaringType, typeof(Type));
            codePropertyExpression = new CodeInvoke(typeOf, method, new CodeConstant(propName, typeof(string)));
        }

        return Retrieve(type, valueSetOrCodes, codePropertyExpression, templateId);

    }


    protected CodeInvoke Retrieve(
        Type resourceType,
        CodeExpression codes,
        CodeExpression codeProperty,
        CodeExpression templateId)
    {
        var forType = typeof(ICqlOperators).GetMethod(nameof(ICqlOperators.Retrieve))!.MakeGenericMethod(resourceType);
        CodeExpression codeExpression = new CodeConstant(null, typeof(IEnumerable<CqlCode>));
        CodeExpression valuesetExpression = new CodeConstant(null, typeof(CqlValueSet));

        if (codes.Type == typeof(CqlValueSet))
            valuesetExpression = codes;
        else if (_typeResolver.IsListType(codes.Type))
        {
            var elementType = _typeResolver.GetListElementType(codes.Type, true)!;
            if (elementType == typeof(CqlCode))
            {
                codeExpression = codes;
            }

            // cql-to-elm blindly calls ToList when an expression ref is used
            // for expressions like:
            // [Source : "Definition returning List<Code>"]
            // this ends up turning the codes expression into a List<List<Code>>
            else if (_typeResolver.IsListType(elementType) && _typeResolver.GetListElementType(elementType) == typeof(CqlCode))
            {
                // call Flatten.
                codeExpression = Flatten(codes);
            }
            else throw new ArgumentException($"Retrieve statements with an ExpressionRef in the terminology position must be list of {nameof(CqlCode)} or a list of lists of {nameof(CqlCode)}.  Instead, the list's element type is {elementType.Name}.", nameof(codes));
        }
        else
            throw new ArgumentException($"Retrieve statements can only accept terminology expressions whose type is {nameof(CqlValueSet)} or {nameof(IEnumerable<CqlCode>)}.  The expression provided has a type of {codes.Type.FullName}", nameof(codes));

        var constructor = typeof(RetrieveParameters).GetConstructors(BindingFlags.Public | BindingFlags.Instance).Single();
        var hasFilters = !codeProperty.IsNullConstant() || !codeExpression.IsNullConstant()
                                                       || !valuesetExpression.IsNullConstant()
                                                       || !templateId.IsNullConstant();

        CodeExpression createParameters = hasFilters
                                   ? new CodeNew(constructor, codeProperty, valuesetExpression, codeExpression, templateId)
                                   : new CodeConstant(null, typeof(RetrieveParameters));

        var call = BindToDirectMethod(forType, createParameters);
        return call;
    }

    private CodeInvoke Select(
        CodeExpression source,
        CodeExpression lambda)
    {
        if (lambda is CodeLambda lambdaExpr)
        {
            var sourceType = _typeResolver.GetListElementType(source.Type) ?? throw new InvalidOperationException($"'{source.Type}' was expected to be a list type.");
            var resultType = lambdaExpr.Body.Type;
            var call = BindToBestMethodOverload(nameof(ICqlOperators.Select), [source, lambda], [sourceType, resultType])!;
            return call;
        }

        throw new ArgumentException("Source is not generic", nameof(source));
    }

    private CodeInvoke Where(
        CodeExpression source,
        CodeExpression lambda)
    {
        if (lambda is CodeLambda)
        {
            var sourceType = _typeResolver.GetListElementType(source.Type) ?? throw new InvalidOperationException($"'{source.Type}' was expected to be a list type.");
            var call = BindToBestMethodOverload(nameof(ICqlOperators.Where), [source, lambda], [sourceType])!;
            return call;
        }

        throw new ArgumentException("Source is not generic", nameof(source));
    }

    private CodeInvoke SelectMany(
        CodeExpression source,
        CodeExpression collectionSelectorLambda)
    {
        if (collectionSelectorLambda is CodeLambda collectionSelector)
        {
            var firstGenericArgument = _typeResolver.GetListElementType(source.Type) ?? throw new InvalidOperationException($"{source.Type} was expected to be a list type.");
            if (_typeResolver.IsListType(collectionSelector.Body.Type))
            {
                var secondGenericArgument = _typeResolver.GetListElementType(collectionSelector.Body.Type) ?? throw new InvalidOperationException($"{collectionSelector.Type} was expected to be a list type.");
                var call = BindToBestMethodOverload(nameof(ICqlOperators.SelectMany), [source, collectionSelector], [firstGenericArgument, secondGenericArgument])!;
                return call;
            }

            throw new ArgumentException("Collection selector does not return an IEnumerable", nameof(collectionSelectorLambda));
        }

        throw new ArgumentException("Source is not generic", nameof(source));
    }

    private CodeInvoke SelectManyResults(
        CodeExpression source,
        CodeExpression collectionSelectorLambda,
        CodeExpression resultSelectorLambda)
    {
        if (collectionSelectorLambda is not CodeLambda collectionSelector)
            throw new ArgumentException("Source is not generic", nameof(source));

        var firstGenericArgument = _typeResolver.GetListElementType(source.Type) ??
                                   throw new InvalidOperationException(
                                       $"{source.Type} was expected to be a list type.");
        if (!_typeResolver.IsListType(collectionSelector.Body.Type))
            throw new ArgumentException("Collection lambda does not return an IEnumerable",
                nameof(collectionSelectorLambda));

        var secondGenericArgument = _typeResolver.GetListElementType(collectionSelector.Body.Type) ??
                                    throw new InvalidOperationException(
                                        $"{collectionSelector.Type} was expected to be a list type.");
        if (resultSelectorLambda is not CodeLambda resultSelector)
            throw new ArgumentException("Result expression is not a lambda", nameof(resultSelectorLambda));

        var call = BindToBestMethodOverload(nameof(ICqlOperators.SelectManyResults), [source, collectionSelector, resultSelector], [firstGenericArgument, secondGenericArgument, resultSelector.Body.Type])!;
        return call;
    }
}
