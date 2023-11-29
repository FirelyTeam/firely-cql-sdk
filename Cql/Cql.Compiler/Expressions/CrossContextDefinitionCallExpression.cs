/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/cql-sdk/main/LICENSE
 */

using Hl7.Cql.Operators;
using Hl7.Cql.Primitives;
using Hl7.Cql.Runtime;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace Hl7.Cql.Compiler
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

    /// <summary>
    /// <para>
    /// This is a custom expression representing the invocation of a cross-context definition using
    /// a lookup on a <see cref="DefinitionDictionary{T}"/>.
    /// </para>
    /// <para>
    /// This expression specifically represents a call from an Unfiltered context to a context of any other type.
    /// Code generation for this type of expression differs from normal definition invocations.  
    /// Specifically, the return type of the expression is always a vector value.  
    /// If the return type of the definition is a scalar value, it will be promoted to a vector value.
    /// If the return type of the definition is already a vector value, the result will be a flattened vector of vectors.
    /// The invocation is replaced with a query over an unqualified retrieve statement which returns an invocation
    /// of the definition passing the iteration variable as the retrieve context parameter.
    /// </para>
    /// </summary>
    /// <remarks>The expression reduces to a lookup on a
    /// <see cref="DefinitionDictionary{Delegate}"/> expression by item, plus the invocation
    /// of the delegate, if found.</remarks>.
    internal class CrossContextDefinitionCallExpression : Expression
    {
        private static readonly PropertyInfo itemProperty =
            typeof(DefinitionDictionary<Delegate>).GetProperty("Item", new[] { typeof(string), typeof(string) })!;
        private static readonly PropertyInfo operatorsProperty =
             typeof(CqlContext).GetProperty(nameof(CqlContext.Operators))!;

        public CrossContextDefinitionCallExpression(Expression definitions,
            string libraryName, 
            string definitionName, 
            Expression cqlContextParameter, 
            Type functionType,
            Type retrieveContextType,
            bool flatten)
        {
            if (definitions.Type != typeof(DefinitionDictionary<Delegate>))
                throw new ArgumentException($"Argument should be of type {nameof(DefinitionDictionary<Delegate>)}",
                    nameof(definitions));

            if (!functionType.IsAssignableTo(typeof(MulticastDelegate)))
                throw new ArgumentException("Argument should be a delegate type", nameof(functionType));

            Definitions = definitions;
            LibraryName = libraryName;
            DefinitionName = definitionName;
            CqlContextParameter = cqlContextParameter;
            FunctionType = functionType;
            RetrieveContextType = retrieveContextType;
            Flatten = flatten;
        }

        public override bool CanReduce => true;

        public override ExpressionType NodeType => ExpressionType.Extension;

        public override Expression Reduce()
        {
            var bools = new[] { true };
            Enumerable.Range(1, 10)
                .Select(i => bools)
                .SelectMany(x => x);

            var operators = Property(CqlContextParameter, operatorsProperty)!;

            var retrieveMethod = operatorsProperty.PropertyType.GetMethod(nameof(ICqlOperators.RetrieveByValueSet))!;
            var typedRetrieve = retrieveMethod.MakeGenericMethod(RetrieveContextType);
            var source = Call(operators, typedRetrieve, Default(typeof(CqlValueSet)), Default(typeof(PropertyInfo)));

            var functionReturnType = GetReturnTypeFromDelegateType(FunctionType);
            var selectMethod = operatorsProperty.PropertyType.GetMethod(nameof(ICqlOperators.SelectOrNull))!;
            var genericSelect = selectMethod.MakeGenericMethod(RetrieveContextType, functionReturnType);
           
            var lambdaParameter = Parameter(RetrieveContextType, "x");

            var dce = new DefinitionCallExpression(Definitions,
                LibraryName,
                DefinitionName,
                CqlContextParameter,
                FunctionType,
                lambdaParameter);

            var lambda = Lambda(dce, lambdaParameter);
            var callSelect = Call(operators, genericSelect, source, lambda);

            // In cross-context references, when the define returns a scalar value T, the return type of the reference
            // is promoted to the vector value IEnumerable<T>.  When the define returns a vector value IEnumerable<T>,
            // the select call will return IEnumerable<IEnmerable<T>>.  This has to be flattened, because by spec,
            // cross-context references to defines which already return vector values (IEnumerable<T>), the result
            // should be remain IEnumerable<T>.
            if (Flatten)
            {
                var flattenMethod = operatorsProperty.PropertyType.GetMethod(nameof(ICqlOperators.FlattenList))!;
                var enumerableType = functionReturnType.GetGenericArguments()[0];
                var genericFlatten = flattenMethod.MakeGenericMethod(enumerableType);
                var callFlatten = Call(operators, genericFlatten, callSelect);
                return callFlatten;
            }
            else
            {
                return callSelect;
            }

        }

        protected override Expression VisitChildren(ExpressionVisitor visitor) => this;

        internal static Type GetReturnTypeFromDelegateType(Type delegateType)
        {
            return delegateType.GetGenericArguments()[^1];
        }

        public override Type Type => Flatten 
            ? GetReturnTypeFromDelegateType(FunctionType)
            : typeof(IEnumerable<>).MakeGenericType(GetReturnTypeFromDelegateType(FunctionType));


        public Expression Definitions { get; }
        /// <summary>
        /// The type of the target retrieve context.
        /// </summary>
        public Type RetrieveContextType { get; }
        /// <summary>
        /// <see langword="true" /> when <see cref="Type"/> is already a vector value.
        /// </summary>
        public bool Flatten { get; }
        public string LibraryName { get; }
        public string DefinitionName { get; }
        public Expression CqlContextParameter { get; }
        public Type FunctionType { get; }
    }
}
