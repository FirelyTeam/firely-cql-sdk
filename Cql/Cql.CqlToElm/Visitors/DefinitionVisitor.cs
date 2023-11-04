using Antlr4.Runtime.Misc;
using Hl7.Cql.CqlToElm.Builtin;
using Hl7.Cql.CqlToElm.Grammar;
using Hl7.Cql.Elm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Hl7.Cql.CqlToElm.Visitors
{
    internal class DefinitionVisitor : Visitor<ISymbol>
    {
        public IModelProvider ModelProvider { get; }
        public TypeSpecifierVisitor TypeSpecifierVisitor { get; }
        public ILibraryProvider LibraryProvider { get; }
        public ExpressionVisitor ExpressionVisitor { get; }

        public DefinitionVisitor(
            LocalIdentifierProvider identifierProvider,
            InvocationBuilder invocationBuilder,
            IModelProvider modelProvider,
            ExpressionVisitor expressionVisitor,
            TypeSpecifierVisitor typeSpecifierVisitor,
            ILibraryProvider libraryProvider)
            : base(identifierProvider, invocationBuilder)
        {
            ModelProvider = modelProvider;
            TypeSpecifierVisitor = typeSpecifierVisitor;
            LibraryProvider = libraryProvider;
            ExpressionVisitor = expressionVisitor;
        }

        //   : 'include' qualifiedIdentifier ('version' versionSpecifier)? ('called' localIdentifier)?
        public override ISymbol VisitIncludeDefinition([NotNull] cqlParser.IncludeDefinitionContext context)
        {
            var (qualifier, id) = context.qualifiedIdentifier().Parse();
            var libraryName = string.IsNullOrWhiteSpace(qualifier) ? id : $"{qualifier}.{id}";
            var version = context.versionSpecifier()?.STRING().ParseString();
            var localIdentifier = context.localIdentifier()?.identifier().Parse() ?? libraryName;

            var resolveSuccess = LibraryProvider.TryResolveLibrary(libraryName, version, out var libraryScope, out var error);

            if (resolveSuccess)
            {

                return new IncludedLibrary(localIdentifier, libraryScope!).WithLocator(context.Locator());
            }
            else
            {
                var emptyLibrary = new LibraryScope(new VersionedIdentifier { id = libraryName, version = version });
                var errorInclude = new IncludedLibrary(localIdentifier, emptyLibrary);
                errorInclude.AddError(error!, ErrorType.semantic);
                return errorInclude.WithLocator(context.Locator());
            }
        }

        // 'using' qualifiedIdentifier ('version' versionSpecifier)? ('called' localIdentifier)?
        public override Element VisitUsingDefinition([NotNull] cqlParser.UsingDefinitionContext context)
        {
            // Although the rule allows for multiple qualifiers, it is not clear what a qualified model name would mean.
            // For now, we take the whole qualified name as the name of the model.
            var (ns, id) = context.qualifiedIdentifier().Parse();
            var modelName = string.IsNullOrWhiteSpace(ns) ? $"{id}" : $"{ns}.{id}";
            var modelVersion = context.versionSpecifier()?.STRING().ParseString();
            var localIdentifier = context.localIdentifier()?.identifier().Parse();

            var model = ModelProvider.ModelFromName(modelName, modelVersion)
                ?? throw new InvalidOperationException($"Model {modelName} version {modelVersion ?? "<unspecified>"} is not available.");

            var usingDef = new UsingDef()
            {
                uri = model.url,
                version = modelVersion,
                localIdentifier = localIdentifier ?? modelName,
            };

            return usingDef.WithLocator(context.Locator());
        }

        //accessModifier? 'codesystem' identifier ':' codesystemId('version' versionSpecifier)?
        public override Element VisitCodesystemDefinition([NotNull] cqlParser.CodesystemDefinitionContext context)
        {
            var codeSystemDef = new CodeSystemDef
            {
                accessLevel = context.accessModifier().Parse(),
                name = context.identifier().Parse(),
                id = context.codesystemId().STRING().ParseString(),
                version = context.versionSpecifier()?.STRING().ParseString(),
            }.WithLocator(context.Locator());

            return codeSystemDef;
        }

        //  : accessModifier? 'valueset' identifier ':' valuesetId ('version' versionSpecifier)? codesystems?
        public override Element VisitValuesetDefinition([NotNull] cqlParser.ValuesetDefinitionContext context)
        {
            var valueSetDef = new ValueSetDef
            {
                accessLevel = context.accessModifier().Parse(),
                name = context.identifier().Parse(),
                id = context.valuesetId().STRING().ParseString(),
                version = context.versionSpecifier()?.STRING().ParseString(),
                codeSystem = context.codesystems()?.codesystemIdentifier().Select(csi =>
                    csi.Parse()).ToArray(),
            }.WithLocator(context.Locator());

            return valueSetDef;
        }

        //: accessModifier? 'code' identifier ':' codeId 'from' codesystemIdentifier displayClause?
        public override Element VisitCodeDefinition([NotNull] cqlParser.CodeDefinitionContext context)
        {
            var codeDef = new CodeDef()
            {
                accessLevel = context.accessModifier().Parse(),
                name = context.identifier().Parse(),
                id = context.codeId().STRING().ParseString(),
                codeSystem = context.codesystemIdentifier().Parse(),
                display = context.displayClause()?.STRING()?.ParseString(),
            }.WithLocator(context.Locator());

            return codeDef;
        }

        //: accessModifier? 'concept' identifier ':' '{' codeIdentifier(',' codeIdentifier)* '}' displayClause?
        public override Element VisitConceptDefinition([NotNull] cqlParser.ConceptDefinitionContext context)
        {
            var conceptDef = new ConceptDef
            {
                accessLevel = context.accessModifier().Parse(),
                name = context.identifier().Parse(),
                code = context.codeIdentifier().Select(ci => ci.Parse()).ToArray(),
                display = context.displayClause()?.STRING().ParseString(),
            }.WithLocator(context.Locator());

            return conceptDef;
        }

        //: accessModifier? 'parameter' identifier (typeSpecifier)? ('default' expression)?
        public override ParameterDef VisitParameterDefinition([NotNull] cqlParser.ParameterDefinitionContext context)
        {
            var paramDef = new ParameterDef
            {
                accessLevel = context.accessModifier().Parse(),
                name = context.identifier().Parse(),
                @default = ExpressionVisitor.Visit(context.expression()),
            }.WithLocator(context.Locator());

            if (context.typeSpecifier() is { } typeSpec)
            {
                paramDef.parameterTypeSpecifier = TypeSpecifierVisitor.Visit(typeSpec);
                paramDef.parameterType = paramDef.parameterTypeSpecifier.TryToQualifiedName();
            }

            return paramDef;
        }

        // 'define' accessModifier? identifier ':' expression
        public override Element VisitExpressionDefinition([NotNull] cqlParser.ExpressionDefinitionContext context)
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
        public IEnumerable<Element> VisitStatements(cqlParser.StatementContext[] context)
        {
            ContextDef? activeContext = null;
            List<NamedTypeSpecifier> definedContexts = new();

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
                else if (statement is ContextDefWithNamedType cd)
                {
                    // If we encounter a context statement, it will be applied to all
                    // subsequent expressions we encounter
                    activeContext = cd.ContextDefinition;

                    // Make sure we create just one ContextDef per model type.
                    if (!definedContexts.Contains(cd.TypeName))
                    {
                        // Build an expression named after the context, which will
                        // do a retrieve for all data of that type.
                        ExpressionDef exprDef = buildContextExpression(statementContext, cd);

                        // Now return both the newly encountered context and the 
                        // expression def that represents it.
                        yield return cd.ContextDefinition;
                        yield return exprDef;

                        definedContexts.Add(cd.TypeName);
                    }
                }
                else
                    throw new InvalidOperationException($"Encountered unknown statement type {statement.GetType()}.");
            }
        }

        private ExpressionDef buildContextExpression(cqlParser.StatementContext statementContext, ContextDefWithNamedType cd)
        {
            var retrieve = new Retrieve
            {
                dataType = cd.TypeName.name,
                templateId = ModelProvider.GetDefaultProfileUriForType(cd.TypeName),
            }.WithLocator(statementContext.Locator()).WithResultType(cd.TypeName.ToListType());

            var singleton = SystemLibrary.SingletonFrom.Call(ModelProvider, statementContext, retrieve);
            var (_, exprName) = cd.TypeName;
            var exprDef = new ExpressionDef
            {
                name = exprName,
                expression = singleton,
                context = cd.ContextDefinition.name,
            }.WithLocator(statementContext.Locator()).WithResultType(singleton.resultTypeSpecifier);

            return exprDef;
        }

        //    : 'context' (modelIdentifier '.')? identifier
        public override Element VisitContextDefinition(cqlParser.ContextDefinitionContext context)
        {
            var identifier = context.identifier().Parse()!;
            var modelIdentifier = context.modelIdentifier()?.identifier().Parse();

            _ = LibraryContext.TryResolveNamedTypeSpecifier(modelIdentifier, identifier, out var namedType, out var error);

            var cd = new ContextDef
            {
                name = modelIdentifier is null ? identifier : $"{modelIdentifier}.{identifier}"
            }.WithLocator(context.Locator());

            if (error is not null) cd.AddError(error, ErrorType.semantic);

            return new ContextDefWithNamedType(namedType, cd);
        }


        // This class is only used as a communication vehicle between the ContextDef parser and the statement parser.
        // Its purpose is to fix a defect in ContextDef, which does not keep track of the full NamedTypeSpecificer the
        // context represents. This type name is concatenated to a string name, but we need the full typespecifier later.
        private class ContextDefWithNamedType : Element
        {
            public ContextDefWithNamedType(NamedTypeSpecifier typeName, ContextDef contextDefinition)
            {
                TypeName = typeName;
                ContextDefinition = contextDefinition;
            }

            public NamedTypeSpecifier TypeName { get; }

            public ContextDef ContextDefinition { get; }
        }
    }
}
