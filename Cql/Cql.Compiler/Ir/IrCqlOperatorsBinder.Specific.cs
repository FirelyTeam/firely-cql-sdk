/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Compiler.Infrastructure;
using Hl7.Cql.Operators;
using Hl7.Cql.Primitives;
using Hl7.Cql.ValueSets;

namespace Hl7.Cql.Compiler.Ir;

/// <summary>
/// IR counterpart of <see cref="CqlOperatorsBinder"/>'s <c>.Specific.cs</c> partial: the hand-written bindings
/// (Select/Where/SelectMany/Retrieve/Coalesce/etc. with generic type construction). This is a
/// mechanical port; see the remarks on <see cref="IrCqlOperatorsBinder"/>.
/// </summary>
partial class IrCqlOperatorsBinder
{
    private IrExpression SortBy(
        IrExpression source,
        IrExpression by,
        IrExpression order)
    {
        if (by is IrLambda lambda && order is IrConstant orderConstant && orderConstant.Type == typeof(ListSortDirection))
        {
            var elementType = _typeResolver.GetListElementType(source.Type) ?? throw new InvalidOperationException($"'{source.Type}' was expected to be a list type.");
            var call = BindToBestMethodOverload(nameof(ICqlOperators.SortBy), [source, lambda, orderConstant], [elementType])!;
            return call;

        }

        throw new ArgumentException("SortBy expects 3 parameters: source, lambda, and SortOrder constant", nameof(by));
    }

    private IrExpression InList(
        IrExpression left,
        IrExpression right)
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
            return NullOfType<object>();

        var call = new IrInvoke(OperatorsReceiver, methodInfo, convertedArgs);
        return call;
    }

    private IrExpression Union(
        IrExpression left,
        IrExpression right)
    {
        if (left.Type == typeof(IValueSetFacade) && right.Type == typeof(IValueSetFacade))
        {
            return BindToBestMethodOverload(
                nameof(ICqlOperators.ValueSetUnion),
                [TypeAsExpression(left, typeof(IEnumerable<CqlCode>)), TypeAsExpression(right, typeof(IEnumerable<CqlCode>))],
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
                var leftAsObjectEnumerable = TypeAsExpression(left, typeof(IEnumerable<object>));
                var rightAsObjectEnumerable = TypeAsExpression(right, typeof(IEnumerable<object>));
                return BindToBestMethodOverload(nameof(ICqlOperators.Union), [leftAsObjectEnumerable, rightAsObjectEnumerable], [])!;
            }
        }

        return BindToBestMethodOverload(nameof(ICqlOperators.Union), [left, right], [])!;
    }

    private IrExpression ResolveValueSet(IrExpression expression)
    {
        if (expression is IrNew @new && @new.Type == typeof(CqlValueSet))
        {
            var call = BindToDirectMethod(nameof(ICqlOperators.ResolveValueSet), @new);
            return call;
        }

        throw new ArgumentException($"Expression should be a 'new {nameof(CqlValueSet)}(...)' construction, but was a {expression.GetType().Name} of type {expression.Type}.");
    }

    private IrExpression Coalesce(IrExpression operand)
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

    private IrExpression Flatten(IrExpression operand)
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

    private IrInvoke LateBoundProperty(
        IrExpression source,
        IrExpression propertyName,
        IrExpression typeExpression)
    {
        if (typeExpression is IrConstant { Value: Type type })
        {
            if (source.Type != typeof(object))
                source = TypeAsExpression(source, typeof(object));

            var call = BindToBestMethodOverload(nameof(ICqlOperators.LateBoundProperty), [source, propertyName], [type!])!;
            return call;
        }

        throw new ArgumentException("Expected constant type expression", nameof(typeExpression));
    }

    /// <summary>
    /// Handles explicit conversions, i.e., the Convert operator
    /// </summary>
    private IrExpression BindConvert(
        IrExpression source,
        IrExpression typeExpression)
    {
        if (typeExpression is not IrConstant { Value: Type toType })
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


    private IrInvoke Retrieve(
        IrExpression typeExpression,
        IrExpression valueSetOrCodes,
        IrExpression codePropertyExpression,
        IrExpression templateId)
    {
        if (typeExpression is not IrConstant ce || ce.Type != typeof(Type))
            throw new ArgumentException("First parameter to Retrieve is expected to be a constant Type", nameof(typeExpression));

        if (ce.Value is not Type type
            || codePropertyExpression is not IrConstant cpe
            || cpe.Type != typeof(PropertyInfo))
            throw new ArgumentException("Third parameter to Retrieve is expected to be a constant PropertyInfo", nameof(codePropertyExpression));

        if (cpe.Value is PropertyInfo pi)
        {
            var declaringType = pi!.DeclaringType;
            var propName = pi.Name;
            var method = typeof(Type).GetMethod(nameof(Type.GetProperty), [typeof(string)])!;
            var typeOf = new IrConstant(declaringType, typeof(Type));
            codePropertyExpression = new IrInvoke(typeOf, method, new IrConstant(propName, typeof(string)));
        }

        return Retrieve(type, valueSetOrCodes, codePropertyExpression, templateId);

    }


    protected IrInvoke Retrieve(
        Type resourceType,
        IrExpression codes,
        IrExpression codeProperty,
        IrExpression templateId)
    {
        var forType = typeof(ICqlOperators).GetMethod(nameof(ICqlOperators.Retrieve))!.MakeGenericMethod(resourceType);
        IrExpression codeExpression = NullOfType<IEnumerable<CqlCode>>();
        IrExpression valuesetExpression = NullOfType<CqlValueSet>();

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
        var hasFilters = !IsNullConstant(codeProperty) || !IsNullConstant(codeExpression)
                                                       || !IsNullConstant(valuesetExpression)
                                                       || !IsNullConstant(templateId);

        IrExpression createParameters = hasFilters
                                   ? new IrNew(constructor, codeProperty, valuesetExpression, codeExpression, templateId)
                                   : NullOfType<RetrieveParameters>();

        var call = BindToDirectMethod(forType, createParameters);
        return call;
    }

    private IrInvoke Select(
        IrExpression source,
        IrExpression lambda)
    {
        if (lambda is IrLambda lambdaExpr)
        {
            var sourceType = _typeResolver.GetListElementType(source.Type) ?? throw new InvalidOperationException($"'{source.Type}' was expected to be a list type.");
            var resultType = lambdaExpr.Body.Type;
            var call = BindToBestMethodOverload(nameof(ICqlOperators.Select), [source, lambda], [sourceType, resultType])!;
            return call;
        }

        throw new ArgumentException("Source is not generic", nameof(source));
    }

    private IrInvoke Where(
        IrExpression source,
        IrExpression lambda)
    {
        if (lambda is IrLambda)
        {
            var sourceType = _typeResolver.GetListElementType(source.Type) ?? throw new InvalidOperationException($"'{source.Type}' was expected to be a list type.");
            var call = BindToBestMethodOverload(nameof(ICqlOperators.Where), [source, lambda], [sourceType])!;
            return call;
        }

        throw new ArgumentException("Source is not generic", nameof(source));
    }

    private IrInvoke SelectMany(
        IrExpression source,
        IrExpression collectionSelectorLambda)
    {
        if (collectionSelectorLambda is IrLambda collectionSelector)
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

    private IrInvoke SelectManyResults(
        IrExpression source,
        IrExpression collectionSelectorLambda,
        IrExpression resultSelectorLambda)
    {
        if (collectionSelectorLambda is not IrLambda collectionSelector)
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
        if (resultSelectorLambda is not IrLambda resultSelector)
            throw new ArgumentException("Result expression is not a lambda", nameof(resultSelectorLambda));

        var call = BindToBestMethodOverload(nameof(ICqlOperators.SelectManyResults), [source, collectionSelector, resultSelector], [firstGenericArgument, secondGenericArgument, resultSelector.Body.Type])!;
        return call;
    }
}
