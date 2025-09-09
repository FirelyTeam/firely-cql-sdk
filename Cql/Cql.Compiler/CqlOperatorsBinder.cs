/*
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;
using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.Compiler.Expressions;
using Hl7.Cql.Operators;
using Hl7.Cql.Primitives;

namespace Hl7.Cql.Compiler
{
    using TypeConverter = Hl7.Cql.Conversion.TypeConverter;

    /// <summary>
    /// Facilitates binding to <see cref="ICqlOperators"/> methods,
    /// by converting the method name and <see cref="Expression"/> arguments
    /// to the appropriate overload of the method.
    /// </summary>
    /// <param name="logger">
    /// The logger used.
    /// </param>
    /// <param name="typeResolver">
    /// The type resolver used.
    /// Note that if you provide a different instance of this class to <see cref="CqlOperators"/>, you will get errors at runtime.
    /// </param>
    /// <param name="typeConverter">
    /// If provided, this binding will use the supplied instance to determine whether
    /// a conversion is possible.  Note that if you provide a different instance of this class to <see cref="CqlOperators"/>,
    /// you may get errors at runtime, because this binding will think a conversion is possible when at runtime it is not.
    /// If not provided, only conversions defined in <see cref="CqlOperators"/> will be used.
    /// </param>
    internal partial class CqlOperatorsBinder(
        ILogger<CqlOperatorsBinder> logger,
        TypeResolver typeResolver,
        TypeConverter typeConverter)
    {
        private readonly ILogger<CqlOperatorsBinder> _logger = logger;
        private readonly TypeResolver _typeResolver = typeResolver;
        private readonly TypeConverter _typeConverter = typeConverter;

        /// <summary>
        /// Facilitates binding to <see cref="ICqlOperators"/> methods,
        /// by converting the <param ref="methodName"/> and <see cref="Expression"/> <param ref="args"/>
        /// to the appropriate overload of the method.
        /// </summary>
        /// <param name="methodName">The method to bind to.</param>
        /// <param name="args">The arguments that will be bound to the closest matching overload.</param>
        /// <param name="typeArgs">Optional types when binding to a specific generic method definition.</param>
        /// <returns>Typically a <see cref="MethodCallExpression"/> that binds to the method.</returns>
        public virtual Expression BindToMethod(
            string methodName,
            Expression[] args,
            Type[] typeArgs
            )
        {
            var result = (methodName, typeArgs.Length, args.Length) switch
            {
                // @formatter:off
                ("Convert"          ,0 , >= 2) => BindConvert(args[0], args[1]),
                ("Aggregate"        ,0 , _)    => BindToBestMethodOverload(nameof(ICqlOperators.Aggregate), args, [_typeResolver.GetListElementType(args[0].Type, true)!, args[2].Type])!,
                ("CrossJoin"        ,0 , _)    => BindToBestMethodOverload(nameof(ICqlOperators.CrossJoin), args, args.SelectToArray(s => _typeResolver.GetListElementType(s.Type, true)!))!,
                ("Message"          ,0 , _)    => BindToBestMethodOverload(nameof(ICqlOperators.Message), args, [args[0].Type])!,
                ("Coalesce"         ,0 , >=1)  => Coalesce(args[0]),
                ("Flatten"          ,0 , >=1)  => Flatten(args[0]),
                ("InList"           ,0 , >=2)  => InList(args[0], args[1]),
                ("LateBoundProperty",0 , >=3)  => LateBoundProperty(args[0], args[1], args[2]),
                ("Union"            ,0 , >=2)  => Union(args[0], args[1]),
                ("ListUnion"        ,0 , >=2)  => Union(args[0], args[1]),
                ("ResolveValueSet"  ,0 , >=1)  => ResolveValueSet(args[0]),
                ("Retrieve"         ,0 , >=3)  => Retrieve(args[0], args[1], args[2], args[3]),
                ("Select"           ,0 , >=2)  => Select(args[0], args[1]),
                ("SelectMany"       ,0 , >=2)  => SelectMany(source: args[0], collectionSelectorLambda: args[1]),
                ("SelectManyResults",0 , >=3)  => SelectManyResults(source: args[0], collectionSelectorLambda: args[1], resultSelectorLambda: args[2]),
                ("SortBy"           ,0 , >=3)  => SortBy(args[0], args[1], args[2]),
                ("Where"            ,0 , >=2)  => Where(args[0], args[1]),
                ("ToList"           ,_ , _)    => ToList(args) ?? BindToBestMethodOverload(methodName, args, typeArgs)!,
                ("Width"            ,_ , _)    => Width(args) ?? BindToBestMethodOverload(methodName, args, typeArgs)!,
                _                                        => BindToBestMethodOverload(methodName, args, typeArgs)!,
                // @formatter:om
            };
            return result;

            Expression? Width(Expression[] args) =>
                args is [{ Type:{} t }] && t == typeof(CqlInterval<object>)
                    ? NullExpression.Int32// This should be disallowed but isn't, so handle it:
                    : null;

            Expression? ToList(Expression[] args) =>
                args is [{ Type:{} t } a] && _typeResolver.IsListType(t)
                    ? a // Already a list type
                    : null;
        }
    }
}