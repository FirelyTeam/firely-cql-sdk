/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Compiler.Infrastructure;
using Hl7.Cql.Runtime;

namespace Hl7.Cql.Compiler.Expressions
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

    /// <summary>
    /// This is a custom expression representing the invocation of a function using
    /// a lookup on a <see cref="DelegateDefinitionDictionary"/>.
    /// </summary>
    /// <remarks>The expression reduces to a lookup on a
    /// <see cref="DelegateDefinitionDictionary"/> expression by item, plus the invocation
    /// of the delegate, if found.</remarks>.
    internal class FunctionCallExpression : Expression
    {
        private static readonly ConstructorInfo DefinitionSignatureCtor =
            ReflectionUtility.ConstructorOf(() => new DefinitionSignature(default(string)!, default(Type[])!));

        private static readonly MethodInfo DefinitionDictionaryIndexGetter =
            ReflectionUtility.MethodOf(() => default(DelegateDefinitionDictionary)![default(string)!, default(DefinitionSignature)!]);

        public FunctionCallExpression(Expression definitions,
            string libraryName, string functionName, IReadOnlyCollection<Expression> arguments, Type functionType)
        {
            if (definitions.Type != typeof(DelegateDefinitionDictionary))
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
            return CallDefinitionDictionaryIndexGet(FunctionType, Definitions, LibraryName, FunctionName, Arguments);
        }

        internal static Expression CallDefinitionDictionaryIndexGet(
            Type functionType,
            Expression definitions,
            string libraryName,
            string functionName,
            IReadOnlyCollection<Expression> arguments)
        {
            var argumentTypesExpressions = arguments
                                           .Skip(1)
                                           .Select(a => Constant(a.Type));

            var newArrayExpression = NewArrayInit(typeof(Type), argumentTypesExpressions);
            var definitionSignatureCtor = DefinitionSignatureCtor;
            var definitionSignature = New(definitionSignatureCtor, [Constant(functionName), newArrayExpression]);
            var indexExpression = Call(definitions, DefinitionDictionaryIndexGetter, [Constant(libraryName), definitionSignature]);
            var asFunc = indexExpression.NewTypeAsExpression(functionType);
            var invoke = Invoke(asFunc, arguments);
            return invoke;
        }

        protected override Expression VisitChildren(ExpressionVisitor visitor)
        {
            var visitedArgs = Arguments.Select(a => visitor.Visit(a)).ToList().AsReadOnly();

            return Update(visitedArgs);
        }

        public Expression Update(IReadOnlyCollection<Expression> arguments)
        {
            if (Arguments.SequenceEqual(arguments))
                return this;
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
