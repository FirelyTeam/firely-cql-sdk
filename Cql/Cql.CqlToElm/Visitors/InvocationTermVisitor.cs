using Antlr4.Runtime.Misc;
using Hl7.Cql.CqlToElm.Grammar;
using Hl7.Cql.Elm;
using Hl7.Cql.Model;
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

            var result = LibraryBuilder.CurrentScope.Ref(libraryName, unqualified);
            return result.WithLocator(context.Locator());
        }

        // This expression is used when constructing paths from left to right when parsing an invocation term.
        // It is set to the result of parsing the path so far, and then used to construct the next step in the path.
        private Expression? LeftExpressionTerm;

        // expressionTerm '.' qualifiedInvocation
        public override Expression VisitInvocationExpressionTerm([NotNull] cqlParser.InvocationExpressionTermContext context)
        {
            var lexpr = Visit(context.expressionTerm());
            if (lexpr is UsingRef ur)
                return SymbolScopeExtensions.MakeErrorReference(null, ur.UsingDef.localIdentifier,
                    "A reference to a model library is unexpected at this point.").WithLocator(context.Locator());

            LeftExpressionTerm = lexpr;

            var rexpr = Visit(context.qualifiedInvocation());

            return rexpr.WithLocator(context.Locator());
        }

        //  : referentialIdentifier             #qualifiedMemberInvocation
        public override Expression VisitQualifiedMemberInvocation([NotNull] cqlParser.QualifiedMemberInvocationContext context)
        {
            if (LeftExpressionTerm is null)
                throw new InvalidOperationException("LeftExpressionTerm is null, but should have been set by the invocation expression term.");

            var memberName = context.referentialIdentifier().Parse();

            // Slightly confusing, but the "member invocation" is syntactically equivalent to the invocation of an expression
            // qualified by a libraryname (XXX.y), so this rule needs to handle both.
            if (LeftExpressionTerm is IncludeRef ir)
            {
                var libraryName = ir.IncludeDef.localIdentifier;
                return LibraryBuilder.CurrentScope.Ref(libraryName, memberName).WithLocator(context.Locator());
            }

            // Left side is not a library name, so we must assume we are dealing with a true member invocation,
            // also known as a Property
            else
            {
                if (LeftExpressionTerm.resultTypeSpecifier is Elm.NamedTypeSpecifier nts)
                {
                    var (_, type) = ModelProvider.FindTypeInfoByNamedType(nts);

                    var prop = new Property
                    {
                        source = LeftExpressionTerm,
                        path = memberName,
                        scope = null  // Don't know what this is for
                    }.WithLocator(context.Locator());

                    if (type is ClassInfo ci && ci.TryGetElement(memberName, out var elementInfo))
                    {
                        return prop.WithResultType(elementInfo!.GetTypeSpecifierForElement(ModelProvider));
                    }
                    else
                    {
                        return prop
                            .AddError($"Member '{memberName}' not found for type {nts}.")
                            .WithResultType(SystemTypes.AnyType);
                    }
                }
                else
                {
                    // TODO:
                    // If the type is a list, Bryn's compiler introduces a Query with $this to project to a 
                    // list of the property's type.
                    // also, intervals are navigable, and maybe the others too.
                    throw new NotImplementedException($"Navigating into expressions of type {LeftExpressionTerm.resultTypeSpecifier} is not yet implemented.");
                }
            }
        }

        //  : identifierOrFunctionIdentifier '(' paramList? ')'
        public override Expression VisitQualifiedFunction([NotNull] cqlParser.QualifiedFunctionContext context)
        {
            if (LeftExpressionTerm is null)
                throw new InvalidOperationException("LeftExpressionTerm is null, but should have been set by the invocation expression term.");

            var functionName = context.identifierOrFunctionIdentifier().Parse();
            var paramList = ParseParamList(context.paramList());

            // Slightly confusing, but the "fluent function invocation" is syntactically equivalent to the invocation of a function
            // qualified by a libraryname (XXX.y), so this rule needs to handle both.
            if (LeftExpressionTerm is IncludeRef ir)
            {
                var libraryName = ir.IncludeDef.localIdentifier;
                return createFunctionInvocation(libraryName, functionName, paramList, fluent: false).WithLocator(context.Locator());
            }

            // Left side is not a library name, so we must assume we are dealing with a fluent function invocation.
            else
            {
                // Add left side of expression as first parameter.
                var allParameters = paramList.Prepend(LeftExpressionTerm).ToArray();
                return createFunctionInvocation(null, functionName, allParameters, fluent: true).WithLocator(context.Locator());
            }
        }

        // : referentialIdentifier             #memberInvocation
        public override Expression VisitMemberInvocation([NotNull] cqlParser.MemberInvocationContext context)
        {
            var identifier = context.referentialIdentifier().Parse();
            var definitionRef = LibraryBuilder.CurrentScope!.Ref(null, identifier);
            return definitionRef.WithLocator(context.Locator());
        }

        // function  : referentialIdentifier '(' paramList? ')'
        public override Expression VisitFunction([NotNull] cqlParser.FunctionContext context)
        {
            var funcName = context.referentialIdentifier().Parse();
            var paramList = ParseParamList(context.paramList());
            return createFunctionInvocation(null, funcName, paramList, fluent: false).WithLocator(context.Locator());
        }

        private Expression createFunctionInvocation(string? libraryName, string funcName, Expression[] paramList, bool fluent)
        {
            _ = LibraryBuilder.CurrentScope.TryResolveIdentifier(libraryName, funcName, out var symbolDef, out var error);

            return symbolDef switch
            {
                FunctionDef funcDef => initializeFunctionRef(funcDef, funcDef.ToRef(libraryName), paramList, fluent),
                ExpressionDef => errorRef($"{funcName} is an expression, and should be invoked without the parenthesis."),
                null => errorRef(error!),
                _ => errorRef($"'{funcName}' is not a function, so it cannot be invoked.")
            };

            FunctionRef errorRef(string error) => new FunctionRef { name = funcName, operand = paramList }
                    .WithResultType(SystemTypes.AnyType)
                    .AddError(error);
        }

        private Expression initializeFunctionRef(FunctionDef funcDef, FunctionRef funcRef, Expression[] paramList, bool fluent)
        {
            // TODO: cast all arguments to the expected types
            funcRef.operand = paramList;

            if (fluent && !funcDef.fluent)
                funcRef.AddError($"Function '{funcDef.name}' is called fluently, but its definition is not marked as fluent.");

            return funcRef;
        }

        // paramList : expression(',' expression)*
        public Expression[] ParseParamList(cqlParser.ParamListContext? context) => context?.expression().Select(Visit).ToArray()
            ?? Array.Empty<Expression>();


        // | '$this'                           #thisInvocation
        public override Expression VisitThisInvocation([NotNull] cqlParser.ThisInvocationContext context) =>
            LibraryBuilder.CurrentScope.Ref(null, context.GetText()).WithLocator(context.Locator());

        // | '$index'                          #indexInvocation
        public override Expression VisitIndexInvocation([NotNull] cqlParser.IndexInvocationContext context) =>
            LibraryBuilder.CurrentScope.Ref(null, context.GetText()).WithLocator(context.Locator());

        // | '$total'                          #totalInvocation
        public override Expression VisitTotalInvocation([NotNull] cqlParser.TotalInvocationContext context) =>
            LibraryBuilder.CurrentScope.Ref(null, context.GetText()).WithLocator(context.Locator());
    }

}
