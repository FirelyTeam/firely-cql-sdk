using Hl7.Cql.Operators;
using Hl7.Cql.Primitives;
using Hl7.Cql.Runtime;
using Hl7.Cql.ValueSets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace Hl7.Cql.Compiler;
partial class CqlOperatorsBinding
{

    private Expression Expand(
        Expression argument,
        Expression perQuantity)
    {
        if (perQuantity is ConstantExpression { Value: null })
            perQuantity = Expression.Constant(null, typeof(CqlQuantity));

        if (TypeResolver.ImplementsGenericIEnumerable(argument.Type))
        {

            var elementType = TypeResolver.GetListElementType(argument.Type)!;
            if (elementType == null)
                throw new ArgumentException($"Unable to determine element type for Expand argument.", nameof(argument));

            if (!IsInterval(elementType))
                throw new ArgumentException($"Expand expects a list element type to be an interval.",
                    nameof(argument));
            return BindToMethod(nameof(ICqlOperators.ExpandList), argument, perQuantity);
        }

        if (!IsInterval(argument.Type))
            throw new ArgumentException($"Expand allows only a List<Interval<T>> or an Interval<T> as a parameter.", nameof(argument));

        return BindToMethod(nameof(ICqlOperators.ExpandInterval), argument, perQuantity);
    }

    private Expression SortBy(
        Expression source,
        Expression by,
        Expression order)
    {
        if (by is LambdaExpression lambda && order is ConstantExpression orderConstant && orderConstant.Type == typeof(ListSortDirection))
        {
            var elementType = TypeResolver.GetListElementType(source.Type) ?? throw new InvalidOperationException($"'{source.Type}' was expected to be a list type.");
            var call = BindToGenericMethod(nameof(ICqlOperators.ListSortBy), [elementType], source, lambda, orderConstant);
            return call;

        }
        else throw new ArgumentException("SortBy expects 3 parameters: source, lambda, and SortOrder constant", nameof(by));
    }

    private Expression InList(
        Expression left,
        Expression right)
    {
        if (left.Type == typeof(CqlCode))
        {
            var rightElementType = TypeResolver.GetListElementType(right.Type);
            if (rightElementType == typeof(CqlCode))
            {
                return BindToMethodConvertArgs(nameof(ICqlOperators.CodeInList), left, right);
            }
        }

        var (methodInfo, convertedArgs) = ResolveMethodInfoWithPotentialArgumentConversions(nameof(ICqlOperators.InList), [left, right], false);
        if (methodInfo is null)
            return CqlContextExpressions.NullObject_ConstantExpression;

        var call = Expression.Call(CqlContextExpressions.Operators_PropertyExpression, methodInfo, convertedArgs);
        return call;
    }

    private Expression ListUnion(
        Expression left,
        Expression right)
    {
        if (left.Type == typeof(IValueSetFacade) && right.Type == typeof(IValueSetFacade))
        {
            return BindToMethodConvertArgs(nameof(ICqlOperators.ValueSetUnion), Expression.TypeAs(left, typeof(IEnumerable<CqlCode>)), Expression.TypeAs(right, typeof(IEnumerable<CqlCode>)));
        }
        var leftElementType = TypeResolver.GetListElementType(left.Type);
        if (leftElementType == typeof(CqlCode))
        {
            var rightElementType = TypeResolver.GetListElementType(right.Type);
            if (rightElementType == typeof(CqlCode))
            {
                return BindToMethodConvertArgs(nameof(ICqlOperators.ValueSetUnion), left, right);
            }
        }

        return BindToMethodConvertArgs(nameof(ICqlOperators.ListUnion), left, right);
    }

    private Expression ResolveValueSet(Expression expression)
    {
        if (expression is NewExpression @new && @new.Type == typeof(CqlValueSet))
        {
            var call = BindToMethod(nameof(ICqlOperators.ResolveValueSet), @new);
            return call;
        }
        else throw new ArgumentException("Expression should be a constant CqlValueSet");
    }

    private Expression Minimum(Expression typeConstant)
    {
        if (typeConstant is ConstantExpression { Value: Type t })
        {
            var call = BindToGenericMethod(nameof(ICqlOperators.Minimum), [t]);
            return call;
        }
        else throw new ArgumentException("Expression should be a constant expression whose type is Type", nameof(typeConstant));
    }

    private Expression Maximum(Expression typeConstant)
    {
        if (typeConstant is ConstantExpression { Value: Type t })
        {
            var call = BindToGenericMethod(nameof(ICqlOperators.Maximum), [t]);
            return call;
        }
        else throw new ArgumentException("Expression should be a constant expression whose type is Type", nameof(typeConstant));
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
                return BindToGenericMethod(nameof(ICqlOperators.CoalesceValueTypes), [underlying], operand);
            }

            return BindToGenericMethod(nameof(ICqlOperators.CoalesceValueTypes), [genericArgumentType], operand);
        }

        var call = BindToGenericMethod(nameof(ICqlOperators.Coalesce), [genericArgumentType], operand);
        return call;

    }

    private Expression Flatten(Expression operand)
    {
        var elementType = TypeResolver.GetListElementType(operand.Type, throwError: true)!;
        if (TypeResolver.ImplementsGenericIEnumerable(elementType))
        {
            var nestedElementType = TypeResolver.GetListElementType(elementType) ?? throw new InvalidOperationException($"'{elementType}' was expected to be a list type.");
            var call = BindToGenericMethod(nameof(ICqlOperators.FlattenList), [nestedElementType], operand);
            return call;
        }

        if (elementType == typeof(object))
        {
            // This scenario can happen in late-bound property chains
            var call = BindToMethod(nameof(ICqlOperators.FlattenLateBoundList), operand);
            return call;
        }

        return operand; // flatten is being called on a list that is already flat.
    }

    private Expression Width(Expression operand)
    {
        // This should be disallowed but isn't, so handle it:
        if (operand.Type == typeof(CqlInterval<object>))
            return Expression.Constant(null, typeof(int?));

        return BindToMethodConvertArgs(nameof(ICqlOperators.Width), operand);
    }

    private MethodCallExpression LateBoundProperty(
        Expression source,
        Expression propertyName,
        Expression typeExpression)
    {
        if (typeExpression is ConstantExpression { Value: Type type })
        {
            if (source.Type != typeof(object))
                source = Expression.TypeAs(source, typeof(object));

            var call = BindToGenericMethod(nameof(ICqlOperators.LateBoundProperty), [type!], source, propertyName);
            return call;
        }
        else throw new ArgumentException("Expected constant type expression", nameof(typeExpression));
    }

    private Expression Interval(
        Expression low,
        Expression high,
        Expression lowClosed,
        Expression highClosed)
    {
        if (low is ConstantExpression { Value: null } && high is ConstantExpression { Value: null })
        {
            return Expression.Constant(null, low.Type == high.Type ? typeof(CqlInterval<>).MakeGenericType(low.Type) : typeof(CqlInterval<object>));
        }

        var exactMethod = ICqlOperators_MethodInfos_By_Name[nameof(ICqlOperators.Interval)]
            .FirstOrDefault(m =>
                m.GetParameters()
                    .Select(p => p.ParameterType)
                    .SequenceEqual([low.Type, high.Type, typeof(bool?), typeof(bool?)]));

        if (exactMethod != null)
        {
            var call = BindToMethod(exactMethod, low, high, lowClosed, highClosed);
            return call;
        }

        return BindToMethod(nameof(ICqlOperators.Interval), low, high, lowClosed, highClosed);
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
            var call = BindToMethod(methodName, source);
            return call;
        }

        return TryConvert(source.Type, toType, source, out var convert)
            ? convert
            : throw new ArgumentException($"Cannot convert {source.Type} to {toType}", nameof(source));
    }


    private MethodCallExpression Retrieve(
        Expression typeExpression,
        Expression valueSetOrCodes,
        Expression codePropertyExpression)
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

        return Retrieve(type, valueSetOrCodes, codePropertyExpression);

    }

    protected MethodCallExpression Retrieve(
        Type resourceType,
        Expression codes,
        Expression codeProperty)
    {
        MethodInfo? forType = null;
        if (codes.Type == typeof(CqlValueSet))
        {
            var method = typeof(ICqlOperators).GetMethod(nameof(ICqlOperators.RetrieveByValueSet))!;
            forType = method.MakeGenericMethod(resourceType);
        }
        else if (TypeResolver.ImplementsGenericIEnumerable(codes.Type))
        {
            var elementType = TypeResolver.GetListElementType(codes.Type, true)!;
            if (elementType == typeof(CqlCode))
            {
                var method = typeof(ICqlOperators).GetMethod(nameof(ICqlOperators.RetrieveByCodes))!;
                forType = method.MakeGenericMethod(resourceType);
            }
            // cql-to-elm blindly calls ToList when an expression ref is used
            // for expressions like:
            // [Source : "Definition returning List<Code>"]
            // this ends up turning the codes expression into a List<List<Code>>
            else if (TypeResolver.ImplementsGenericIEnumerable(elementType) && TypeResolver.GetListElementType(elementType) == typeof(CqlCode))
            {
                // call Flatten.
                codes = Flatten(codes);
                var method = typeof(ICqlOperators).GetMethod(nameof(ICqlOperators.RetrieveByCodes))!;
                forType = method.MakeGenericMethod(resourceType);
            }
            else throw new ArgumentException($"Retrieve statements with an ExpressionRef in the terminology position must be list of {nameof(CqlCode)} or a list of lists of {nameof(CqlCode)}.  Instead, the list's element type is {elementType.Name}.", nameof(codes));
        }
        else
            throw new ArgumentException($"Retrieve statements can only accept terminology expressions whose type is {nameof(CqlValueSet)} or {nameof(IEnumerable<CqlCode>)}.  The expression provided has a type of {codes.Type.FullName}", nameof(codes));

        var call = BindToMethod(forType, codes, codeProperty);
        return call;
    }

    private MethodCallExpression Select(
        Expression source,
        Expression lambda)
    {
        if (lambda is LambdaExpression lambdaExpr)
        {
            var sourceType = TypeResolver.GetListElementType(source.Type) ?? throw new InvalidOperationException($"'{source.Type}' was expected to be a list type.");
            var resultType = lambdaExpr.ReturnType;
            var call = BindToGenericMethod(nameof(ICqlOperators.SelectOrNull), [sourceType, resultType], source, lambda);
            return call;
        }
        else throw new ArgumentException("Source is not generic", nameof(source));
    }
    private MethodCallExpression Where(
        Expression source,
        Expression lambda)
    {
        if (lambda is LambdaExpression lamdaExpr)
        {
            var sourceType = TypeResolver.GetListElementType(source.Type) ?? throw new InvalidOperationException($"'{source.Type}' was expected to be a list type.");
            var call = BindToGenericMethod(nameof(ICqlOperators.WhereOrNull), [sourceType], source, lambda);
            return call;
        }
        else throw new ArgumentException("Source is not generic", nameof(source));
    }

    private MethodCallExpression SelectMany(
        Expression source,
        Expression collectionSelectorLambda)
    {
        if (collectionSelectorLambda is LambdaExpression collectionSelector)
        {
            var firstGenericArgument = TypeResolver.GetListElementType(source.Type) ?? throw new InvalidOperationException($"{source.Type} was expected to be a list type.");
            if (TypeResolver.ImplementsGenericIEnumerable(collectionSelector.ReturnType))
            {
                var secondGenericArgument = TypeResolver.GetListElementType(collectionSelector.ReturnType) ?? throw new InvalidOperationException($"{collectionSelector.Type} was expected to be a list type.");
                var call = BindToGenericMethod(nameof(ICqlOperators.SelectManyOrNull), [firstGenericArgument, secondGenericArgument], source, collectionSelector);
                return call;
            }
            else throw new ArgumentException("Collection selector does not return an IEnumerable", nameof(collectionSelectorLambda));
        }
        else throw new ArgumentException("Source is not generic", nameof(source));
    }

    private MethodCallExpression SelectManyResults(
        Expression source,
        Expression collectionSelectorLambda,
        Expression resultSelectorLambda)
    {
        if (collectionSelectorLambda is not LambdaExpression collectionSelector)
            throw new ArgumentException("Source is not generic", nameof(source));

        var firstGenericArgument = TypeResolver.GetListElementType(source.Type) ??
                                   throw new InvalidOperationException(
                                       $"{source.Type} was expected to be a list type.");
        if (!TypeResolver.ImplementsGenericIEnumerable(collectionSelector.ReturnType))
            throw new ArgumentException("Collection lambda does not return an IEnumerable",
                nameof(collectionSelectorLambda));

        var secondGenericArgument = TypeResolver.GetListElementType(collectionSelector.ReturnType) ??
                                    throw new InvalidOperationException(
                                        $"{collectionSelector.Type} was expected to be a list type.");
        if (resultSelectorLambda is not LambdaExpression resultSelector)
            throw new ArgumentException("Result expression is not a lambda", nameof(resultSelectorLambda));

        var call = BindToGenericMethod(
            nameof(ICqlOperators.SelectManyResultsOrNull),
            [firstGenericArgument, secondGenericArgument, resultSelector.ReturnType], source,
            collectionSelector, resultSelector);
        return call;
    }

    private bool TryConvert(
        Type from, Type to,
        Expression fromExpr, [NotNullWhen(true)] out Expression? toExpr)
    {
        if (from == to)
        {
            toExpr = fromExpr;
            return true;
        }

        if (to.IsAssignableFrom(from))
        {
            toExpr = Expression.TypeAs(fromExpr, to);
            return true;
        }

        if (TypeConverter?.CanConvert(from, to) == true)
        {
            toExpr = BindToGenericMethod(nameof(ICqlOperators.Convert), [to], Expression.TypeAs(fromExpr, typeof(object)));
            return true;
        }

        if (fromExpr is ConstantExpression { Value: null }
            && Nullable.GetUnderlyingType(to) is not null)
        {
            toExpr = Expression.Constant(null, to);
            return true;
        }

        toExpr = null;
        return false;
    }
}
