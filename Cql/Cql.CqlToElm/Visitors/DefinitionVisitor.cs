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
        public LibraryBuilder LibraryBuilder { get; }
        public ILibraryProvider LibraryProvider { get; }
        public ExpressionVisitor ExpressionVisitor { get; }


        public DefinitionVisitor(
            LocalIdentifierProvider identifierProvider,
            InvocationBuilder invocationBuilder,
            IModelProvider modelProvider,
            ExpressionVisitor expressionVisitor,
            TypeSpecifierVisitor typeSpecifierVisitor,
            LibraryBuilder libraryBuilder,
            ILibraryProvider libraryProvider)
            : base(identifierProvider, invocationBuilder)
        {
            ModelProvider = modelProvider;
            TypeSpecifierVisitor = typeSpecifierVisitor;
            LibraryBuilder = libraryBuilder;
            LibraryProvider = libraryProvider;
            ExpressionVisitor = expressionVisitor;
        }

        //   : 'include' qualifiedIdentifier ('version' versionSpecifier)? ('called' localIdentifier)?
        public override IDefinitionElement VisitIncludeDefinition([NotNull] cqlParser.IncludeDefinitionContext context)
        {
            var (qualifier, id) = context.qualifiedIdentifier().Parse();
            var libraryName = string.IsNullOrWhiteSpace(qualifier) ? id : $"{qualifier}.{id}";
            var version = context.versionSpecifier()?.STRING().ParseString();
            var localIdentifier = context.localIdentifier()?.identifier().Parse() ?? id;

            var resolveSuccess = LibraryProvider.TryResolveLibrary(libraryName, version, out var library, out var error);

            if (resolveSuccess)
            {
                return new IncludeDefSymbol(localIdentifier, new ReferencedLibrary(library!)).WithLocator(context.Locator());
            }
            else
            {
                // To be able to continue to parse, create an empty library scope with the name and version
                // and return that so we can act as if some library was found.
                var emptyLibrary = new Library { identifier = new VersionedIdentifier { id = libraryName, version = version } };
                var errorInclude = new IncludeDefSymbol(localIdentifier, new ReferencedLibrary(emptyLibrary));
                errorInclude.AddError(error!);
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

            var success = ModelProvider.TryGetModelFromName(modelName, out var model, modelVersion);

            if (success)
                return new UsingDefSymbol(localIdentifier, modelVersion, model!).WithLocator(context.Locator());
            else
            {
                var emptyModel = new Model.ModelInfo() { name = modelName, version = modelVersion };
                var error = $"Model {modelName} version {modelVersion ?? "<unspecified>"} is not available.";
                var usingDef = new UsingDefSymbol(localIdentifier, modelVersion, emptyModel).AddError(error);
                return usingDef.WithLocator(context.Locator());
            }
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

            var defaultExpr = context.expression() is { } expr ? ExpressionVisitor.Visit(expr) : null;
            var typeSpec = context.typeSpecifier() is { } ts ? TypeSpecifierVisitor.Visit(ts) : null;

            var coercedDefault = (typeSpec, defaultExpr) switch
            {
                ({ } t, null) => new Null().WithResultType(t),
                (null, { } def) => def,
                ({ } t, { } def) => coerceDefault(t, def),
                (null, null) => null,
            };

            if (coercedDefault is null)
            {
                paramDef.AddError("Parameter must have either a type or a default value.");
                paramDef.parameterTypeSpecifier = SystemTypes.AnyType;
            }
            else
            {
                if (coercedDefault is not Null) paramDef.@default = coercedDefault;
                paramDef.parameterTypeSpecifier = coercedDefault.resultTypeSpecifier;
            }

            paramDef.parameterType = paramDef.parameterTypeSpecifier.TryToQualifiedName();
            return paramDef.WithResultType(paramDef.parameterTypeSpecifier);

            Expression coerceDefault(TypeSpecifier type, Expression defaultExpr)
            {
                InvocationBuilder ib = new(ModelProvider);
                var (result, _, error) = ib.BuildImplicitCast(defaultExpr, type, out var _);

                if (error is null)
                    return result;
                else
                    return defaultExpr.AddError($"Default value cannot be converted to parameter type {type}.");
            }
        }

        // 'define' accessModifier? identifier ':' expression
        public override IDefinitionElement VisitExpressionDefinition([NotNull] cqlParser.ExpressionDefinitionContext context)
        {
            var expression = ExpressionVisitor.Visit(context.expression());
            if (expression is null)
            {
                var msg = $"Expression type {context.expression().GetType()} is not implemented.";
                var errorDef = new ExpressionDef()
                {
                    accessLevel = context.accessModifier().Parse(),
                    name = context.identifier().Parse(),
                    expression = new Null().WithResultType(SystemTypes.AnyType)
                };
                return errorDef
                    .AddError(msg)
                    .WithLocator(context.Locator())
                    .WithResultType(SystemTypes.AnyType);
            }
            else
            {
                var def = new ExpressionDef
                {
                    accessLevel = context.accessModifier().Parse(),
                    name = context.identifier().Parse(),
                    expression = expression,
                };
                return def
                    .WithLocator(context.Locator())
                    .WithResultType(expression.resultTypeSpecifier);
            }
        }

        //  'define' accessModifier? fluentModifier? 'function' identifierOrFunctionIdentifier '(' (operandDefinition (',' operandDefinition)*)? ')'
        // ('returns' typeSpecifier)? ':' (functionBody | 'external')
        public override IDefinitionElement VisitFunctionDefinition([NotNull] cqlParser.FunctionDefinitionContext context)
        {
            var access = context.accessModifier().Parse();
            var isFluent = context.fluentModifier() is not null;
            var identifier = context.identifierOrFunctionIdentifier().Parse();
            var operands = context.operandDefinition().Select(od => od.Parse(TypeSpecifierVisitor)).ToArray();
            var returnType = context.typeSpecifier() is { } ts ? TypeSpecifierVisitor.Visit(ts) : null;
            var functionBody = context.functionBody();

            var functionDef = new FunctionDef
            {
                accessLevel = access,
                name = identifier,
                fluent = isFluent,
                operand = operands,
            }.WithLocator(context.Locator());

            if (functionBody is not null)
            {
                // Enter a new scope for the function body, so that the operands are visible
                LibraryBuilder.EnterScope();
                foreach (var operand in operands)
                    LibraryBuilder.CurrentScope.TryAdd(operand);

                // Visit the function body, which will add the expression to the functionDef
                functionDef.expression = ExpressionVisitor.Visit(functionBody.expression());

                // Exit the scope for the function body
                LibraryBuilder.ExitScope();

                // If the function has a return type, make sure the expression is of that type.
                var expressionType = functionDef.expression.resultTypeSpecifier;
                if (returnType is not null)
                {
                    if (!expressionType.IsSubtypeOf(returnType, ModelProvider))
                        functionDef.AddError($"Function {functionDef.name} has declared return type {returnType} but " +
                            $"the function body returns incompatible type {expressionType}.");

                    functionDef.resultTypeSpecifier = returnType;
                }
                else
                    functionDef.resultTypeSpecifier = expressionType;
            }
            else
            {
                functionDef.external = true;

                if (returnType is null)
                {
                    functionDef.AddError("External functions must specify a return type.");
                    functionDef.WithResultType(SystemTypes.AnyType);   //TODO: might want to introduce some kind of error type.
                }
                else
                    functionDef.WithResultType(returnType);
            }

            return functionDef;
        }

        public void VisitDefinitions(cqlParser.DefinitionContext[] context)
        {
            foreach (var definitionContext in context)
            {
                var definition = Visit(definitionContext);
                add(definition);
            }
        }

        // statement : expressionDefinition   | contextDefinition | functionDefinition ;
        public void VisitStatements(cqlParser.StatementContext[] context)
        {
            ContextDef? activeContext = null;
            List<string> definedContexts = new();

            // Go over the statements in order, since they can be interleaved
            // with context statements, which become active immediately.
            foreach (var statementContext in context)
            {
#if DEBUG
                var statementText = statementContext.GetText();
#endif
                var statement = Visit(statementContext);

                if (statement is ExpressionDef ed)
                {
                    // If there is an active context, set it on the expression we just parsed.
                    if (activeContext is not null)
                        ed.context = activeContext.name;

                    add(ed);
                }
                else if (statement is ContextDef cd)
                {
                    // If we encounter a context statement, it will be applied to all
                    // subsequent expressions we encounter
                    activeContext = cd;

                    // Make sure we create just one ContextDef per model type.
                    if (!definedContexts.Contains(cd.name))
                    {
                        add(cd);

                        if (cd.resultTypeSpecifier is not null && !cd.IsUnfiltered)
                        {
                            // Build an expression named after the context, which will
                            // do a retrieve for all data of that type.
                            ExpressionDef exprDef = buildContextExpression(statementContext, cd);
                            add(exprDef);
                        }

                        definedContexts.Add(cd.name);
                    }
                }
                else
                    throw new InvalidOperationException($"Encountered unknown statement type {statement.GetType()}.");
            }

        }

        private void add(IDefinitionElement s)
        {
            if (!LibraryBuilder.CurrentScope.TryAdd(s))
                LibraryBuilder.AddError($"Duplicate identifier {s.Name} in scope.", ErrorType.semantic);
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

            var cd = new ContextDef
            {
                name = modelIdentifier is null ? identifier : $"{modelIdentifier}.{identifier}"
            }.WithLocator(context.Locator());

            if (!cd.IsUnfiltered)
            {
                _ = LibraryBuilder.SymbolTable.TryResolveNamedTypeSpecifier(modelIdentifier, identifier, out var namedType, out var error);
                cd = cd.WithResultType(namedType);
                if (error is not null) cd.AddError(error);
            }

            return cd;
        }
    }
}