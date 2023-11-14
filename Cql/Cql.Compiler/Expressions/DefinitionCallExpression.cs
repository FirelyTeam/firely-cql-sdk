/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/cql-sdk/main/LICENSE
 */

using Hl7.Cql.Runtime;
using System;
using System.Linq.Expressions;
using System.Reflection;

namespace Hl7.Cql.Compiler
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

    /// <summary>
    /// This is a custom expression representing the invocation of a definition using
    /// a lookup on a <see cref="DefinitionDictionary{T}"/>.
    /// </summary>
    /// <remarks>The expression reduces to a lookup on a
    /// <see cref="DefinitionDictionary{Delegate}"/> expression by item, plus the invocation
    /// of the delegate, if found.</remarks>.
    internal class DefinitionCallExpression : Expression
    {
        private static readonly PropertyInfo itemProperty =
            typeof(DefinitionDictionary<Delegate>)
            .GetProperty("Item", new[] { typeof(string), typeof(string), typeof(Type[]) })!;
        public DefinitionCallExpression(Expression definitions,
            string libraryName,
            string definitionName,
            Expression cqlContextParameter,
            Type definitionType,
            Type? retrieveContextType,
            ParameterExpression? retrieveContext)
        {
            if (definitions.Type != typeof(DefinitionDictionary<Delegate>))
                throw new ArgumentException($"Argument should be of type {nameof(DefinitionDictionary<Delegate>)}",
                    nameof(definitions));

            if (!definitionType.IsAssignableTo(typeof(MulticastDelegate)))
                throw new ArgumentException("Argument should be a delegate type", nameof(definitionType));

            Definitions = definitions;
            LibraryName = libraryName;
            DefinitionName = definitionName;
            CqlContextParameter = cqlContextParameter;
            DefinitionType = definitionType;
            RetrieveContextType = retrieveContextType;
            RetrieveContextParameter = retrieveContext;
        }

        public override bool CanReduce => true;

        public override ExpressionType NodeType => ExpressionType.Extension;

        public override Expression Reduce()
        {
            Expression[] indices;
            if (RetrieveContextParameter != null)
            {
                indices = new Expression[]
                {
                    Constant(LibraryName),
                    Constant(DefinitionName),
                    NewArrayInit(typeof(Type), new[] { Constant(RetrieveContextParameter.Type) }),
                };
            }
            else
            {
                indices = new Expression[]
                {
                    Constant(LibraryName),
                    Constant(DefinitionName),
                    NewArrayInit(typeof(Type))
                };
            }

            var index = MakeIndex(Definitions, itemProperty, indices);
            var asFunc = TypeAs(index, DefinitionType);
            var invoke = RetrieveContextType == null
                        ? Invoke(asFunc, CqlContextParameter)
                        : Invoke(asFunc, CqlContextParameter, RetrieveContextParameter as Expression ?? Default(RetrieveContextType));
            return invoke;
        }

        protected override Expression VisitChildren(ExpressionVisitor visitor) => this;

        internal static Type GetReturnTypeFromDelegateType(Type delegateType)
        {
            return delegateType.GetGenericArguments()[^1];
        }

        public override Type Type => GetReturnTypeFromDelegateType(DefinitionType);

        public Expression Definitions { get; }
        /// <summary>
        /// The type of the retrieve context; will be <see langword="null"/> in Unfiltered contexts
        /// </summary>
        public Type? RetrieveContextType { get; }
        public ParameterExpression? RetrieveContextParameter { get; }
        public string LibraryName { get; }
        public string DefinitionName { get; }
        public Expression CqlContextParameter { get; }
        public Type DefinitionType { get; }
    }
}
