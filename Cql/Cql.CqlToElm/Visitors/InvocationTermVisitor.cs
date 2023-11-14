using Antlr4.Runtime.Misc;
using Hl7.Cql.CqlToElm.Grammar;
using Hl7.Cql.Elm;
using System;
using System.Linq;

namespace Hl7.Cql.CqlToElm.Visitors
{
    internal partial class ExpressionVisitor
    {
        // (qualifierExpression '.')* referentialIdentifier
        public override Expression VisitQualifiedIdentifierExpression([NotNull] cqlParser.QualifiedIdentifierExpressionContext context)
        {
            var qualifiers = context.qualifierExpression().Select(q => q.referentialIdentifier().Parse()).ToArray();
            var unqualified = context.referentialIdentifier().Parse();
            var libraryName = qualifiers.Any() ? string.Join(".", qualifiers) : null;

            var result = LibraryBuilder.CurrentScope.ResolveIdentifier(libraryName, unqualified);
            return result.WithLocator(context.Locator());
        }

        // : referentialIdentifier             #memberInvocation
        public override Expression VisitMemberInvocation([NotNull] cqlParser.MemberInvocationContext context)
        {
            var identifier = context.referentialIdentifier().Parse();
            var definitionRef = LibraryBuilder.CurrentScope!.ResolveIdentifier(null, identifier);

            var result = definitionRef switch
            {
                // UsingRefs should only be encountered in the context of a typespecifier, not an identifier
                UsingRef ur => throw new InvalidOperationException("Need to avoid this ever happening."),

                // IncludeRefs should only be encountered as a qualifier in a dotted path and
                // the expressionTerm rule should make sure that is resolved, so will we not end up here.
                IncludeRef ir => throw new InvalidOperationException("Need to avoid this ever happening."),

                // Otherwise, fine.
                var r => r
            };

            return result.WithLocator(context.Locator());
        }

        // function  : referentialIdentifier '(' paramList? ')'
        public override Expression VisitFunction([NotNull] cqlParser.FunctionContext context)
        {
            var funcName = context.referentialIdentifier().Parse();
            _ = LibraryBuilder.CurrentScope.TryResolveIdentifier(null, funcName, out var symbolRef, out var error);
            Expression result;

            symbolRef ??= new FunctionRef { name = funcName }
                    .WithResultType(SystemTypes.AnyType)
                    .AddError(error!, ErrorType.semantic);

            if (symbolRef is FunctionRef funcRef)
            {
                var parameters = context.paramList() is { } pars ? ParseParamList(pars) : Array.Empty<Expression>();
                funcRef.operand = parameters;
                result = funcRef;
            }
            else if (symbolRef is ExpressionRef)
            {
                symbolRef.AddError($"{funcName} is an expression, and should be invoked without the parenthesis.", ErrorType.semantic);
                result = symbolRef;
            }
            else
            {
                symbolRef.AddError($"{funcName} is not a function, so it cannot be invoked.", ErrorType.semantic);
                result = symbolRef;
            }

            return result.WithLocator(context.Locator());
        }

        // paramList : expression(',' expression)*
        public Expression[] ParseParamList(cqlParser.ParamListContext context) => context.expression().Select(Visit).ToArray();


        // | '$this'                           #thisInvocation
        public override Expression VisitThisInvocation([NotNull] cqlParser.ThisInvocationContext context)
        {
            throw new NotImplementedException("$this invocations not yet implemented.");
        }

        // | '$index'                          #indexInvocation
        public override Expression VisitIndexInvocation([NotNull] cqlParser.IndexInvocationContext context)
        {
            throw new NotImplementedException("$index invocations not yet implemented.");
        }

        // | '$total'                          #totalInvocation
        public override Expression VisitTotalInvocation([NotNull] cqlParser.TotalInvocationContext context)
        {
            throw new NotImplementedException("$total invocations not yet implemented.");
        }
    }

}
