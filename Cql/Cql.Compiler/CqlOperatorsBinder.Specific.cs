/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using Hl7.Cql.Compiler.Expressions;
using Hl7.Cql.Operators;
using Hl7.Cql.Primitives;
using Hl7.Cql.Runtime;
using Hl7.Cql.ValueSets;

namespace Hl7.Cql.Compiler;
partial class CqlOperatorsBinder
{
    private Expression SortBy(
        Expression source,
        Expression by,
        Expression order)
    {
        if (by is LambdaExpression lambda && order is ConstantExpression orderConstant && orderConstant.Type == typeof(ListSortDirection))
        {
            var elementType = _typeResolver.GetListElementType(source.Type) ?? throw new InvalidOperationException($"'{source.Type}' was expected to be a list type.");
            var call = BindToBestMethodOverload(nameof(ICqlOperators.SortBy), [source, lambda, orderConstant], [elementType])!;
            return call;

        }

        throw new ArgumentException("SortBy expects 3 parameters: source, lambda, and SortOrder constant", nameof(by));
    }

    private Expression InList(
        Expression left,
        Expression right)
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
            return NullExpression.Object;

        var call = Expression.Call(CqlExpressions.Operators_PropertyExpression, methodInfo, convertedArgs);
        return call;
    }

    private Expression Union(
        Expression left,
        Expression right)
    {
        if (left.Type == typeof(IValueSetFacade) && right.Type == typeof(IValueSetFacade))
        {
            return BindToBestMethodOverload(
                nameof(ICqlOperators.ValueSetUnion),
                [left.NewTypeAsExpression<IEnumerable<CqlCode>>(), right.NewTypeAsExpression<IEnumerable<CqlCode>>()],
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

        return BindToBestMethodOverload(nameof(ICqlOperators.Union), [left, right], [])!;
    }

    private Expression ResolveValueSet(Expression expression)
    {
        if (expression is NewExpression @new && @new.Type == typeof(CqlValueSet))
        {
            var call = BindToDirectMethod(nameof(ICqlOperators.ResolveValueSet), @new);
            return call;
        }

        throw new ArgumentException("Expression should be a constant CqlValueSet");
    }

    private Expression Coalesce(Expression operand)
    {
        if (!operand.Type.IsGenericType)
            throw new ArgumentException(
                "Operands to this method must be generic with a single generic type parameter, e.g. IEnumerable<T>",
                nameof(operand));

        var genericArgumentType = operand.Type.GetGenericArguments()[0];
        if (genericArgumentType.IsValueType)
        {

            if (genericArgumentType.IsGenericType && genericArgumentType.GetGenericTypeDefinition() == typeof(Nullable<>))
            {
                var underlying = Nullable.GetUnderlyingType(genericArgumentType)!;
                return BindToBestMethodOverload(nameof(ICqlOperators.CoalesceValueTypes), [operand], [underlying])!;
            }

            return BindToBestMethodOverload(nameof(ICqlOperators.CoalesceValueTypes), [operand], [genericArgumentType])!;
        }

        var call = BindToBestMethodOverload(nameof(ICqlOperators.Coalesce), [operand], [genericArgumentType])!;
        return call;

    }

    private Expression Flatten(Expression operand)
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

    private MethodCallExpression LateBoundProperty(
        Expression source,
        Expression propertyName,
        Expression typeExpression)
    {
        if (typeExpression is ConstantExpression { Value: Type type })
        {
            if (source.Type != typeof(object))
                source = source.NewTypeAsExpression<object>();

            var call = BindToBestMethodOverload(nameof(ICqlOperators.LateBoundProperty), [source, propertyName], [type!])!;
            return call;
        }

        throw new ArgumentException("Expected constant type expression", nameof(typeExpression));
    }

    /// <summary>
    /// Handles explicit conversions, i.e., the Convert operator
    /// </summary>
    private Expression BindConvert(
        Expression source,
        Expression typeExpression)
    {
        if (typeExpression is not ConstantExpression { Value: Type toType })
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


    private MethodCallExpression Retrieve(
        Expression typeExpression,
        Expression valueSetOrCodes,
        Expression codePropertyExpression,
        Expression templateId)
    {
        if (typeExpression is not ConstantExpression ce || ce.Type != typeof(Type))
            throw new ArgumentException("First parameter to Retrieve is expected to be a constant Type", nameof(typeExpression));

        if (ce.Value is not Type type
            || codePropertyExpression is not ConstantExpression cpe
            || cpe.Type != typeof(PropertyInfo))
            throw new ArgumentException("Second parameter to Retrieve is expected to be a constant PropertyInfo", nameof(codePropertyExpression));

        if (cpe.Value is PropertyInfo pi)
        {
            var declaringType = pi!.DeclaringType;
            var propName = pi.Name;
            var method = typeof(Type).GetMethod(nameof(Type.GetProperty), [typeof(string)])!;
            var typeOf = Expression.Constant(declaringType);
            codePropertyExpression = Expression.Call(typeOf, method, Expression.Constant(propName));
        }

        return Retrieve(type, valueSetOrCodes, codePropertyExpression, templateId);

    }


    protected MethodCallExpression Retrieve(
        Type resourceType,
        Expression codes,
        Expression codeProperty,
        Expression templateId)
    {
        var forType = typeof(ICqlOperators).GetMethod(nameof(ICqlOperators.Retrieve))!.MakeGenericMethod(resourceType);
        Expression codeExpression = NullExpression.ForType<IEnumerable<CqlCode>>();
        Expression valuesetExpression = NullExpression.ForType<CqlValueSet>();

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

        Expression createParameters = hasFilters
                                   ? Expression.New(constructor, codeProperty, valuesetExpression, codeExpression, templateId)
                                   : NullExpression.ForType<RetrieveParameters>();

        var call = BindToDirectMethod(forType, createParameters);
        return call;
    }

    private MethodCallExpression Select(
        Expression source,
        Expression lambda)
    {
        if (lambda is LambdaExpression lambdaExpr)
        {
            var sourceType = _typeResolver.GetListElementType(source.Type) ?? throw new InvalidOperationException($"'{source.Type}' was expected to be a list type.");
            var resultType = lambdaExpr.ReturnType;
            var call = BindToBestMethodOverload(nameof(ICqlOperators.Select), [source, lambda], [sourceType, resultType])!;
            return call;
        }

        throw new ArgumentException("Source is not generic", nameof(source));
    }

    private MethodCallExpression Where(
        Expression source,
        Expression lambda)
    {
        if (lambda is LambdaExpression lamdaExpr)
        {
            var sourceType = _typeResolver.GetListElementType(source.Type) ?? throw new InvalidOperationException($"'{source.Type}' was expected to be a list type.");
            var call = BindToBestMethodOverload(nameof(ICqlOperators.Where), [source, lambda], [sourceType])!;
            return call;
        }

        throw new ArgumentException("Source is not generic", nameof(source));
    }

    private MethodCallExpression SelectMany(
        Expression source,
        Expression collectionSelectorLambda)
    {
        if (collectionSelectorLambda is LambdaExpression collectionSelector)
        {
            var firstGenericArgument = _typeResolver.GetListElementType(source.Type) ?? throw new InvalidOperationException($"{source.Type} was expected to be a list type.");
            if (_typeResolver.IsListType(collectionSelector.ReturnType))
            {
                var secondGenericArgument = _typeResolver.GetListElementType(collectionSelector.ReturnType) ?? throw new InvalidOperationException($"{collectionSelector.Type} was expected to be a list type.");
                var call = BindToBestMethodOverload(nameof(ICqlOperators.SelectMany), [source, collectionSelector], [firstGenericArgument, secondGenericArgument])!;
                return call;
            }

            throw new ArgumentException("Collection selector does not return an IEnumerable", nameof(collectionSelectorLambda));
        }

        throw new ArgumentException("Source is not generic", nameof(source));
    }

    private MethodCallExpression SelectManyResults(
        Expression source,
        Expression collectionSelectorLambda,
        Expression resultSelectorLambda)
    {
        if (collectionSelectorLambda is not LambdaExpression collectionSelector)
            throw new ArgumentException("Source is not generic", nameof(source));

        var firstGenericArgument = _typeResolver.GetListElementType(source.Type) ??
                                   throw new InvalidOperationException(
                                       $"{source.Type} was expected to be a list type.");
        if (!_typeResolver.IsListType(collectionSelector.ReturnType))
            throw new ArgumentException("Collection lambda does not return an IEnumerable",
                nameof(collectionSelectorLambda));

        var secondGenericArgument = _typeResolver.GetListElementType(collectionSelector.ReturnType) ??
                                    throw new InvalidOperationException(
                                        $"{collectionSelector.Type} was expected to be a list type.");
        if (resultSelectorLambda is not LambdaExpression resultSelector)
            throw new ArgumentException("Result expression is not a lambda", nameof(resultSelectorLambda));

        var call = BindToBestMethodOverload(nameof(ICqlOperators.SelectManyResults), [source, collectionSelector, resultSelector], [firstGenericArgument, secondGenericArgument, resultSelector.ReturnType])!;
        return call;
    }
}