﻿using Antlr4.Runtime.Misc;
using Hl7.Cql.CqlToElm.Builtin;
using Hl7.Cql.CqlToElm.Grammar;
using Hl7.Cql.Elm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Hl7.Cql.CqlToElm.Visitors
{
    internal class DefinitionVisitor : Visitor<IDefinitionElement>
    {
        public IModelProvider ModelProvider { get; }
        public TypeSpecifierVisitor TypeSpecifierVisitor { get; }
        public ConverterContext ConverterContext { get; }
        public ILibraryProvider LibraryProvider { get; }
        public ExpressionVisitor ExpressionVisitor { get; }

        public DefinitionVisitor(
            LocalIdentifierProvider identifierProvider,
            InvocationBuilder invocationBuilder,
            IModelProvider modelProvider,
            ExpressionVisitor expressionVisitor,
            TypeSpecifierVisitor typeSpecifierVisitor,
            ConverterContext converterContext,
            ILibraryProvider libraryProvider)
            : base(identifierProvider, invocationBuilder)
        {
            ModelProvider = modelProvider;
            TypeSpecifierVisitor = typeSpecifierVisitor;
            ConverterContext = converterContext;
            LibraryProvider = libraryProvider;
            ExpressionVisitor = expressionVisitor;
        }

        //   : 'include' qualifiedIdentifier ('version' versionSpecifier)? ('called' localIdentifier)?
        public override IDefinitionElement VisitIncludeDefinition([NotNull] cqlParser.IncludeDefinitionContext context)
        {
            var (qualifier, id) = context.qualifiedIdentifier().Parse();
            var libraryName = string.IsNullOrWhiteSpace(qualifier) ? id : $"{qualifier}.{id}";
            var version = context.versionSpecifier()?.STRING().ParseString();
            var localIdentifier = context.localIdentifier()?.identifier().Parse() ?? libraryName;

            var resolveSuccess = LibraryProvider.TryResolveLibrary(libraryName, version, out var library, out var error);

            if (resolveSuccess)
            {
                return new IncludeDefSymbol(localIdentifier, library!).WithLocator(context.Locator());
            }
            else
            {
                // To be able to continue to parse, create an empty library scope with the name and version
                // and return that so we can act as if some library was found.
                var emptyLibrary = new Library { identifier = new VersionedIdentifier { id = libraryName, version = version } };
                var errorInclude = new IncludeDefSymbol(localIdentifier, emptyLibrary);
                errorInclude.AddError(error!, ErrorType.semantic);
                return errorInclude.WithLocator(context.Locator());
            }
        }

        // 'using' qualifiedIdentifier ('version' versionSpecifier)? ('called' localIdentifier)?
        public override IDefinitionElement VisitUsingDefinition([NotNull] cqlParser.UsingDefinitionContext context)
        {
            // Although the rule allows for multiple qualifiers, it is not clear what a qualified model name would mean.
            // For now, we take the whole qualified name as the name of the model.
            var (ns, id) = context.qualifiedIdentifier().Parse();
            var modelName = string.IsNullOrWhiteSpace(ns) ? $"{id}" : $"{ns}.{id}";
            var modelVersion = context.versionSpecifier()?.STRING().ParseString();
            var localIdentifier = context.localIdentifier()?.identifier().Parse() ?? modelName;

            var model = ModelProvider.ModelFromName(modelName, modelVersion);

            if (model is null)
            {
                var emptyModel = new Model.ModelInfo() { name = modelName, version = modelVersion };
                var error = $"Model {modelName} version {modelVersion ?? "<unspecified>"} is not available.";
                var usingDef = new UsingDefSymbol(localIdentifier, emptyModel).AddError(error, ErrorType.semantic);
                return usingDef.WithLocator(context.Locator());
            }
            else
                return new UsingDefSymbol(localIdentifier, model).WithLocator(context.Locator());
        }

        //accessModifier? 'codesystem' identifier ':' codesystemId('version' versionSpecifier)?
        public override IDefinitionElement VisitCodesystemDefinition([NotNull] cqlParser.CodesystemDefinitionContext context)
        {
            var codeSystemDef = new CodeSystemDef
            {
                accessLevel = context.accessModifier().Parse(),
                name = context.identifier().Parse(),
                id = context.codesystemId().STRING().ParseString(),
                version = context.versionSpecifier()?.STRING().ParseString(),
            }.WithLocator(context.Locator()).WithResultType(SystemTypes.CodeSystemType);

            return codeSystemDef;
        }

        //  : accessModifier? 'valueset' identifier ':' valuesetId ('version' versionSpecifier)? codesystems?
        public override IDefinitionElement VisitValuesetDefinition([NotNull] cqlParser.ValuesetDefinitionContext context)
        {
            var valueSetDef = new ValueSetDef
            {
                accessLevel = context.accessModifier().Parse(),
                name = context.identifier().Parse(),
                id = context.valuesetId().STRING().ParseString(),
                version = context.versionSpecifier()?.STRING().ParseString(),
                codeSystem = context.codesystems()?.codesystemIdentifier().Select(csi =>
                    csi.Parse()).ToArray(),
            }.WithLocator(context.Locator()).WithResultType(SystemTypes.ValueSetType);

            return valueSetDef;
        }

        //: accessModifier? 'code' identifier ':' codeId 'from' codesystemIdentifier displayClause?
        public override IDefinitionElement VisitCodeDefinition([NotNull] cqlParser.CodeDefinitionContext context)
        {
            var codeDef = new CodeDef()
            {
                accessLevel = context.accessModifier().Parse(),
                name = context.identifier().Parse(),
                id = context.codeId().STRING().ParseString(),
                codeSystem = context.codesystemIdentifier().Parse(),
                display = context.displayClause()?.STRING()?.ParseString(),
            }.WithLocator(context.Locator()).WithResultType(SystemTypes.CodeType);

            return codeDef;
        }

        //: accessModifier? 'concept' identifier ':' '{' codeIdentifier(',' codeIdentifier)* '}' displayClause?
        public override IDefinitionElement VisitConceptDefinition([NotNull] cqlParser.ConceptDefinitionContext context)
        {
            var conceptDef = new ConceptDef
            {
                accessLevel = context.accessModifier().Parse(),
                name = context.identifier().Parse(),
                code = context.codeIdentifier().Select(ci => ci.Parse()).ToArray(),
                display = context.displayClause()?.STRING().ParseString(),
            }.WithLocator(context.Locator()).WithResultType(SystemTypes.ConceptType);

            return conceptDef;
        }

        //: accessModifier? 'parameter' identifier (typeSpecifier)? ('default' expression)?
        //    public override ParameterDef VisitParameterDefinition([NotNull] cqlParser.ParameterDefinitionContext context)
        public override IDefinitionElement VisitParameterDefinition([NotNull] cqlParser.ParameterDefinitionContext context)
        {
            var paramDef = new ParameterDef
            {
                accessLevel = context.accessModifier().Parse(),
                name = context.identifier().Parse(),
            }.WithLocator(context.Locator());

            if (context.expression() is { } expr)
            {
                paramDef.@default = ExpressionVisitor.Visit(expr);
            }

            var typeSpec = context.typeSpecifier() is { } ts ? TypeSpecifierVisitor.Visit(ts) : null;

            if (typeSpec is not null && paramDef.@default is null)
            {
                paramDef.parameterTypeSpecifier = typeSpec;
                paramDef.parameterType = typeSpec?.TryToQualifiedName();
            }
            else if (typeSpec is null && paramDef.@default is not null)
            {
                paramDef.parameterTypeSpecifier = paramDef.@default.resultTypeSpecifier;
                paramDef.parameterType = paramDef.parameterTypeSpecifier.TryToQualifiedName();
            }
            else
            {
                // TODO: both are set. We need to verify that the expression is assignable
                // to the specified parameter type, and if necessery provide a cast, just
                // like with expressions in operators.
                throw new NotImplementedException("TODO: Implement parameter type coercion.");
            }

            return paramDef.WithResultType(paramDef.parameterTypeSpecifier);
        }

        // 'define' accessModifier? identifier ':' expression
        public override IDefinitionElement VisitExpressionDefinition([NotNull] cqlParser.ExpressionDefinitionContext context)
        {
            var expression = ExpressionVisitor.Visit(context.expression());

            var def = new ExpressionDef
            {
                accessLevel = context.accessModifier().Parse(),
                name = context.identifier().Parse(),
                expression = expression,
            }.WithResultType(expression.resultTypeSpecifier).WithLocator(context.Locator());

            return def;
        }

        // statement : expressionDefinition   | contextDefinition | functionDefinition ;
        public IEnumerable<IDefinitionElement> VisitStatements(cqlParser.StatementContext[] context)
        {
            ContextDef? activeContext = null;
            List<TypeSpecifier> definedContexts = new();

            // Go over the statements in order, since they can be interleaved
            // with context statements, which become active immediately.
            foreach (var statementContext in context)
            {
                var statement = Visit(statementContext);

                if (statement is ExpressionDef ed)
                {
                    // If there is an active context, set it on the expression we just parsed.
                    if (activeContext is not null)
                        ed.context = activeContext.name;

                    yield return ed;
                }
                else if (statement is ContextDef cd)
                {
                    // If we encounter a context statement, it will be applied to all
                    // subsequent expressions we encounter
                    activeContext = cd;

                    // Make sure we create just one ContextDef per model type.
                    if (!definedContexts.Contains(cd.resultTypeSpecifier))
                    {
                        // Build an expression named after the context, which will
                        // do a retrieve for all data of that type.
                        ExpressionDef exprDef = buildContextExpression(statementContext, cd);

                        // Now return both the newly encountered context and the 
                        // expression def that represents it.
                        yield return cd;
                        yield return exprDef;

                        definedContexts.Add(cd.resultTypeSpecifier);
                    }
                }
                else
                    throw new InvalidOperationException($"Encountered unknown statement type {statement.GetType()}.");
            }
        }

        private ExpressionDef buildContextExpression(cqlParser.StatementContext statementContext, ContextDef cd)
        {
            var resultType = cd.resultTypeSpecifier as NamedTypeSpecifier ??
                throw new InvalidOperationException($"ContextDef {cd.name} has a resultType that is not a named type specifier.");

            var retrieve = new Retrieve
            {
                dataType = resultType.name,
                templateId = ModelProvider.GetDefaultProfileUriForType(resultType),
            }.WithLocator(statementContext.Locator()).WithResultType(resultType.ToListType());

            var singleton = SystemLibrary.SingletonFrom.Call(ModelProvider, statementContext, retrieve);
            var (_, exprName) = resultType;
            var exprDef = new ExpressionDef
            {
                name = exprName,
                expression = singleton,
                context = cd.name,
            }.WithLocator(statementContext.Locator()).WithResultType(singleton.resultTypeSpecifier);

            return exprDef;
        }

        //    : 'context' (modelIdentifier '.')? identifier
        public override IDefinitionElement VisitContextDefinition(cqlParser.ContextDefinitionContext context)
        {
            var identifier = context.identifier().Parse()!;
            var modelIdentifier = context.modelIdentifier()?.identifier().Parse();

            _ = ConverterContext.CurrentScope!.TryResolveNamedTypeSpecifier(modelIdentifier, identifier, out var namedType, out var error);

            var cd = new ContextDef
            {
                name = modelIdentifier is null ? identifier : $"{modelIdentifier}.{identifier}"
            }.WithLocator(context.Locator()).WithResultType(namedType);

            if (error is not null) cd.AddError(error, ErrorType.semantic);

            return cd;
        }
    }
}
