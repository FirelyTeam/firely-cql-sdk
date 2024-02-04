using Antlr4.Runtime.Misc;
using Hl7.Cql.CqlToElm.Builtin;
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

        public override Expression VisitTermExpression([NotNull] cqlParser.TermExpressionContext context)
        {
            var term = base.VisitTermExpression(context);

            if (term is UsingRef ur)
                return SymbolScopeExtensions.MakeErrorReference(null, ur.UsingDef.localIdentifier,
                    "A reference to a model library is unexpected at this point.").WithLocator(context.Locator());
            else if (term is IncludeRef ir)
                return SymbolScopeExtensions.MakeErrorReference(null, ir.IncludeDef.localIdentifier,
                    "A reference to a library is unexpected at this point.").WithLocator(context.Locator());
            else if (term is null)
            {
                var message = $"Type {context.expressionTerm().GetType()} is not implemented";
                return new Message()
                {
                    source = new Null().WithResultType(SystemTypes.AnyType),
                    message = new Literal
                    {
                        value = message,
                        resultTypeSpecifier = SystemTypes.StringType
                    }
                }
                .AddError(message)
                .WithLocator(context.Locator())
                .WithResultType(SystemTypes.AnyType);
            }
            else return term;
        }

        public override Expression VisitInstanceSelector([NotNull] cqlParser.InstanceSelectorContext context)
        {
            var type = TypeSpecifierVisitor.Visit(context.namedTypeSpecifier());
            var elements = context
                .instanceElementSelector()
                .Select(ies =>
                {
                    var name = ies.referentialIdentifier().Parse();
                    var expression = Visit(ies.expression());
                    var ele = new InstanceElement()
                    {
                        name = name,
                        value = expression,
                    };
                    return ele;
                })
                .ToArray();
            var instance = new Instance { element = elements }
                .WithResultType(type)
                .WithLocator(context.Locator());
            return instance;
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
                    "A reference to a type is unexpected at this point.").WithLocator(context.Locator());

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
                return navigateIntoType(LeftExpressionTerm, memberName).WithLocator(context.Locator());
            }
        }

        private Expression navigateIntoType(Expression source, string memberName)
        {
            return source.resultTypeSpecifier switch
            {
                Elm.NamedTypeSpecifier nts => navigateIntoNamedType(source, nts, memberName),
                Elm.TupleTypeSpecifier tts => navigateIntoTuple(source, tts, memberName),
                Elm.IntervalTypeSpecifier ivs => navigateIntoInterval(source, ivs, memberName),
                Elm.ListTypeSpecifier lts => navigateIntoList(source, lts, memberName),
                _ => makeProp(source, memberName).AddError($"Type {source.resultTypeSpecifier} has no members.")
            };
        }

        private Expression navigateIntoList(Expression source, Elm.ListTypeSpecifier lts, string memberName)
        {
            // If we navigate into a list, say, Patient.name.family, we actually need to generate a
            // query. In this query, Patient.name is the source, and "family" is the property we need to
            // navigate into:
            //
            //    from Patient.name $this
            //    where $this.name is not null
            //    select $this.name
            //
            var aliasRef = new AliasRef { name = "$this" }.WithResultType(lts.elementType);
            var prop = navigateIntoType(aliasRef, memberName);

            var q = new Query()
            {
                source = new[] { new AliasedQuerySource()
                    {
                        expression = source,
                        alias = "$this"
                    }.WithResultType(lts) },
                where = new Not
                {
                    operand = new IsNull
                    {
                        operand = prop
                    }.WithResultType(SystemTypes.BooleanType)
                }.WithResultType(SystemTypes.BooleanType),
                @return = new ReturnClause()
                {
                    expression = prop,
                    distinct = false
                }
            }.WithResultType(prop.resultTypeSpecifier.ToListType());

            // If the result itself is again a list (as in Patient.name.given), then the FhirPath
            // logic requires us to flatten that list.
            return prop.resultTypeSpecifier switch
            {
                Elm.ListTypeSpecifier qlts => new Flatten { operand = q }.WithResultType(qlts),
                _ => q
            };
        }

        // https://build.fhir.org/ig/HL7/cql/04-logicalspecification.html#property
        // Property expressions can also be used to access the individual points and closed indicators
        // for interval types using the property names low, high, lowClosed, and highClosed.
        private Property navigateIntoInterval(Expression source, Elm.IntervalTypeSpecifier ivs, string memberName)
        {
            var prop = makeProp(source, memberName).WithResultType(ivs.pointType);

            return memberName switch
            {
                "low" or "high" => prop.WithResultType(ivs.pointType),
                "lowClosed" or "highClosed" => prop.WithResultType(SystemTypes.BooleanType),
                _ => prop.AddError($"Invalid interval property name '{memberName}'.")
            };
        }

        private Property makeProp(Expression source, string member) => new()
        {
            source = source,
            path = member,
            scope = null  // Don't know what this is for
        };

        private Property navigateIntoTuple(Expression source, Elm.TupleTypeSpecifier tts, string memberName)
        {
            var targetElement = tts.element.Where(e => e.name == memberName).SingleOrDefault();
            var prop = makeProp(source, memberName);

            if (targetElement is not null)
            {
                prop.WithResultType(targetElement.elementType);
            }
            else
            {
                prop.AddError($"Member '{memberName}' not found in tuple.");
                prop.WithResultType(SystemTypes.AnyType);
            }

            return prop;
        }

        private Property navigateIntoNamedType(Expression source, Elm.NamedTypeSpecifier nts, string memberName)
        {
            var (_, type) = ModelProvider.FindTypeInfoByNamedType(nts);

            var prop = makeProp(source, memberName);

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
            IDefinitionElement? symbolDef = null;

            var inScope = LibraryBuilder.CurrentScope.TryResolveIdentifier(libraryName, funcName, out var scopeDef, out var scopeError);
            var inSystemScope = LibraryBuilder.SystemScope.TryResolveIdentifier(libraryName, funcName, out var systemDef, out var systemError);
            if (inScope)
            {
                if (inSystemScope)
                    return error($"Ambiguous function {funcName} found in both local and system scope.");
                symbolDef = scopeDef;
            }
            else if (inSystemScope)
                symbolDef = systemDef;

            // All 3 of error cases in this 
            return symbolDef switch
            {
                OverloadedFunctionDef overloads => initializeFunctionRef(overloads, libraryName, paramList, fluent),
                FunctionDef funcDef => initializeFunctionRef(funcDef, libraryName, paramList, fluent),
                ExpressionDef => error($"Operator {funcName} is not a function and must not be called with ()."),
                _ => unresolved()
            }; ;

            FunctionRef error(string msg) => new FunctionRef { name = funcName, operand = paramList }
                .WithResultType(SystemTypes.AnyType)
                .AddError(msg);
            FunctionRef unresolved() => new FunctionRef { name = funcName, operand = paramList }
                    .WithResultType(SystemTypes.AnyType)
                    .AddUnresolvedOperatorError(funcName, paramList.Select(p => p.resultTypeSpecifier).ToArray());

        }

        private Expression initializeFunctionRef(FunctionDef funcDef, string? libraryName, Expression[] paramList, bool fluent)
        {
            var funcRef = funcDef.Call(ModelProvider, null, paramList);

            if (funcRef is FunctionRef fr)
                fr.libraryName = libraryName;

            if (fluent && !funcDef.fluent)
                funcRef.AddError($"Function '{funcDef.name}' is called fluently, but its definition is not marked as fluent.");

            return funcRef;
        }
        private Expression initializeFunctionRef(OverloadedFunctionDef funcDef, string? libraryName, Expression[] paramList, bool fluent)
        {
            var funcRef = funcDef.Call(ModelProvider, null, paramList, out var selectedOverload);
            if (funcRef is FunctionRef fr)
                fr.libraryName = libraryName;
            if (selectedOverload == null)
                funcRef.AddError($"Unable to resolve overload for {funcDef.Name} with arguments {paramList.Select(p => p.resultTypeSpecifier)}");
            else if (fluent && !selectedOverload.fluent)
                funcRef.AddError($"Function '{selectedOverload.name}' is called fluently, but its definition is not marked as fluent.");
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
