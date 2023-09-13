/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/cql-sdk/main/LICENSE
 */

using Hl7.Cql.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace Hl7.Cql.Compiler
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

    /// <summary>
    /// This is a custom expression representing the invocation of a function using
    /// a lookup on a <see cref="DefinitionDictionary{T}"/>.
    /// </summary>
    /// <remarks>The expression reduces to a lookup on a
    /// <see cref="DefinitionDictionary{Delegate}"/> expression by item, plus the invocation
    /// of the delegate, if found.</remarks>.
    internal class FunctionCallExpression : Expression
    {
        private static readonly PropertyInfo itemProperty =
            typeof(DefinitionDictionary<Delegate>)
            .GetProperty("Item", new[] { typeof(string), typeof(string), typeof(Type[]) })!;

        public FunctionCallExpression(Expression definitions,
            string libraryName, string functionName, IReadOnlyCollection<Expression> arguments, Type functionType)
        {
            if (definitions.Type != typeof(DefinitionDictionary<Delegate>))
                throw new ArgumentException($"Argument should be of type {nameof(DefinitionDictionary<Delegate>)}",
                    nameof(definitions));

            if (!functionType.IsAssignableTo(typeof(MulticastDelegate)))
                throw new ArgumentException("Argument should be a delegate type", nameof(functionType));

            Definitions = definitions;
            LibraryName = libraryName;
            FunctionName = functionName;
            Arguments = arguments;
            FunctionType = functionType;
        }

        public override bool CanReduce => true;

        public override ExpressionType NodeType => ExpressionType.Extension;

        public override Expression Reduce()
        {
            var argumentTypesExpressions = Arguments
                .Skip(1)
                .Select(a => Constant(a.Type));

            var typeArrayInitializer = NewArrayInit(typeof(Type), argumentTypesExpressions);

            var indices = new Expression[]
            {
                Constant(LibraryName),
                Constant(FunctionName),
                typeArrayInitializer
            };

            var index = MakeIndex(Definitions, itemProperty, indices);
            var asFunc = TypeAs(index, FunctionType);
            var invoke = Invoke(asFunc, Arguments);

            return invoke;
        }

        protected override Expression VisitChildren(ExpressionVisitor visitor)
        {
            var visitedArgs = Arguments.Select(a => visitor.Visit(a)).ToList().AsReadOnly();

            return Update(visitedArgs);
        }

        public Expression Update(IReadOnlyCollection<Expression> arguments)
        {
            if (Enumerable.SequenceEqual(Arguments, arguments))
                return this;
            else
                return new FunctionCallExpression(Definitions, LibraryName, FunctionName, arguments, FunctionType);
        }

        public override Type Type => DefinitionCallExpression.GetReturnTypeFromDelegateType(FunctionType);

        public Expression Definitions { get; }
        public string LibraryName { get; }
        public string FunctionName { get; }
        public IReadOnlyCollection<Expression> Arguments { get; }
        public Type FunctionType { get; }
    }
}
