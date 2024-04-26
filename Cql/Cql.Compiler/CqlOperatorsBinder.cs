/*
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System;
using System.Linq.Expressions;
using Hl7.Cql.Abstractions;
using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.Compiler.Expressions;
using Hl7.Cql.Conversion;
using Hl7.Cql.Operators;
using Hl7.Cql.Runtime;
using Microsoft.Extensions.Logging;

namespace Hl7.Cql.Compiler
{
    /// <summary>
    /// Facilitates binding to <see cref="ICqlOperators"/> methods,
    /// by converting the method name and <see cref="Expression"/> arguments
    /// to the appropriate overload of the method.
    /// </summary>
    internal partial class CqlOperatorsBinder
    {
        private readonly ILogger<CqlOperatorsBinder> _logger;
        private readonly TypeConverter? _typeConverter;
        private readonly TypeResolver _typeResolver;


        /// <summary>
        /// Creates an instance.
        /// </summary>
        /// <param name="logger">
        /// The logger used in this binding.
        /// </param>
        /// <param name="typeResolver">
        /// The type resolver used in this binding.
        /// Note that if you provide a different instance of this class to <see cref="CqlOperators"/>, you will get errors at runtime.
        /// </param>
        /// <param name="typeConverter">
        /// If provided, this binding will use the supplied instance to determine whether
        /// a conversion is possible.  Note that if you provide a different instance of this class to <see cref="CqlOperators"/>,
        /// you may get errors at runtime, because this binding will think a conversion is possible when at runtime it is not.
        /// If not provided, only conversions defined in <see cref="CqlOperators"/> will be used.
        /// </param>
        public CqlOperatorsBinder(
            ILogger<CqlOperatorsBinder> logger,
            TypeResolver typeResolver,
            TypeConverter? typeConverter = null)
        {
            _typeConverter = typeConverter;
            _typeResolver = typeResolver;
            _logger = logger;
        }

        /// <summary>
        /// Facilitates binding to <see cref="ICqlOperators"/> methods,
        /// by converting the <param ref="methodName"/> and <see cref="Expression"/> <param ref="args"/>
        /// to the appropriate overload of the method.
        /// </summary>
        /// <param name="methodName">The method to bind to.</param>
        /// <param name="args">The arguments that will be bound to the closest matching overload.</param>
        /// <returns>Typically a <see cref="MethodCallExpression"/> that binds to the method.</returns>
        public virtual Expression BindToMethod(
            string methodName,
            params Expression[] args)
        {
            var result = methodName switch
            {
                // @formatter:off
                "Convert"                      => BindConvert(args[0], args[1]),
                "Aggregate"                    => BindToGenericMethod(nameof(ICqlOperators.Aggregate), genericTypeArguments: [_typeResolver.GetListElementType(args[0].Type, true)!, args[2].Type], args[0], args[2], args[1]), // NOTE: the order here is 0, 2, 1, maybe change the Aggregate method arguments as well?
                "CrossJoin"                    => BindToGenericMethod(nameof(ICqlOperators.CrossJoin), genericTypeArguments: args.SelectToArray(s => _typeResolver.GetListElementType(s.Type, true)!), args),
                "Message"                      => BindToGenericMethod(nameof(ICqlOperators.Message), genericTypeArguments: [args[0].Type], args),
                "ToList"                       => BindToGenericMethod(nameof(ICqlOperators.ToList), genericTypeArguments: [args[0].Type], args),
                "Coalesce"                     => Coalesce(args[0]),
                "Expand"                       => Expand(args[0], args[1]),
                "Flatten"                      => Flatten(args[0]),
                "InList"                       => InList(args[0], args[1]),
                "LateBoundProperty"            => LateBoundProperty(args[0], args[1], args[2]),
                "ListUnion"                    => ListUnion(args[0], args[1]),
                "MaxValue"                     => MaxValue(args[0]),
                "MinValue"                     => MinValue(args[0]),
                "ResolveValueSet"              => ResolveValueSet(args[0]),
                "Retrieve"                     => Retrieve(args[0], args[1], args[2]),
                "Select"                       => Select(args[0], args[1]),
                "SelectMany"                   => SelectMany(source: args[0], collectionSelectorLambda: args[1]),
                "SelectManyResults"            => SelectManyResults(source: args[0], collectionSelectorLambda: args[1], resultSelectorLambda: args[2]),
                "SortBy"                       => SortBy(args[0], args[1], args[2]),
                "Where"                        => Where(args[0], args[1]),
                "Width"                        => Width(args[0]),
                "Ratio" or "PropertyOrDefault" => throw new NotSupportedException($"Operator {methodName} is not supported by this binding."),
                _                              => BindToMethodConvertArgs(methodName, args),
                // @formatter:om
            };
            return result;
        }

        /// <summary>
        /// Converts the given <paramref name="expression"/> to the specified type <paramref name="type"/>.
        /// </summary>
        /// <param name="expression">The expression to convert.</param>
        /// <param name="type">The type to convert the expression to.</param>
        /// <returns>The converted expression.</returns>
        public virtual Expression ConvertToType(Expression expression, Type type) =>
            TryConvert(expression, type, out var t)
                ? t.arg!
                : throw new InvalidOperationException($"Cannot convert '{expression.Type.FullName}' to '{type.FullName}'");

        /// <summary>
        /// Casts the given <paramref name="expression"/> to the specified type <paramref name="type"/>.
        /// </summary>
        /// <param name="expression">The expression to cast.</param>
        /// <param name="type">The type to cast the expression to.</param>
        /// <returns>The expression that was cast.</returns>
        public virtual Expression CastToType(Expression expression, Type type)
        {
            if (expression.Type != typeof(object))
                throw new ArgumentException("Cast only allowed on Object typed expressions.", nameof(expression));

            return expression.ConvertExpression(type);
        }
    }
}