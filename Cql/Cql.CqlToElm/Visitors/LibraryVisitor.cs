using Antlr4.Runtime.Misc;
using Hl7.Cql.CqlToElm.Builtin;
using Hl7.Cql.CqlToElm.Grammar;
using Hl7.Cql.Elm;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Hl7.Cql.CqlToElm.Visitors
{
    internal class LibraryVisitor : Visitor<LibraryBuilder>
    {
        public LibraryVisitor(IServiceProvider services)
        {
            Services = services;
            Configuration = services.GetRequiredService<IOptions<CqlToElmOptions>>().Value;
        }


        public IServiceProvider Services { get; }
        public SystemLibrary SystemLibrary => Services.GetRequiredService<SystemLibrary>();


        private CqlToElmOptions Configuration { get; }
        private IModelProvider ModelProvider => Services.GetRequiredService<IModelProvider>();

        private UsingDefSymbol? GetDefaultSystemModel()
        {
            var systemUri = Configuration.SystemElmModelUri;
            var systemVersion = Configuration.SystemElmModelVersion ?? SystemTypes.SystemModelVersion;

            if (string.IsNullOrWhiteSpace(systemUri))
                return null;

            return ModelProvider.TryGetModelFromUri(systemUri, out var model, systemVersion) ?
                new UsingDefSymbol("System", systemVersion, model)
                : null;
        }

        // libraryDefinition? definition* statement* EOF;
        // definition : usingDefinition | includeDefinition | codesystemDefinition  | valuesetDefinition  | codeDefinition
        //     | conceptDefinition | parameterDefinition ;
        public override LibraryBuilder VisitLibrary([NotNull] cqlParser.LibraryContext context)
        {

            var identifier = context.libraryDefinition()?.Parse()
                ?? throw new InvalidOperationException($"This library does not have an identifier and cannot be processed.");
            var builder = new LibraryBuilder(identifier,
                SystemLibrary,
                Services.GetRequiredService<LocalIdentifierProvider>());
            // Add the default model, System
            if (GetDefaultSystemModel() is { } systemModel)
                builder.CurrentScope.TryAdd(systemModel);

            var defVisitor = new DefinitionVisitor(builder, Services);

            // Parse the definitions, this function will insert the visited definitions into the current scope.
            defVisitor.VisitDefinitions(context.definition());

            // The same is true for statements, although we have a specific visitor for those,
            // to handle the fact that statements can be expressions or contexts and we need
            // to make sure we change the context when we encounter one.
            defVisitor.VisitStatements(context.statement());

            return builder;
        }

        private class DefinitionVisitor : Visitor<IDefinitionElement>
        {
            public DefinitionVisitor(LibraryBuilder libraryBuilder, IServiceProvider services)
            {
                LibraryBuilder = libraryBuilder;
                Services = services;
                ExpressionVisitor = new ExpressionVisitor(services, libraryBuilder);
                TypeSpecifierVisitor = new TypeSpecifierVisitor(services, libraryBuilder);
                InvocationBuilder = services.GetRequiredService<InvocationBuilder>();

            }

            public LibraryBuilder LibraryBuilder { get; }
            public TypeSpecifierVisitor TypeSpecifierVisitor { get; }

            #region Services
            public IServiceProvider Services { get; }

            public IModelProvider ModelProvider => Services.GetRequiredService<IModelProvider>();
            public ILibraryProvider LibraryProvider => Services.GetRequiredService<ILibraryProvider>();
            public CoercionProvider CoercionProvider => Services.GetRequiredService<CoercionProvider>();
            public MessageProvider Messaging => Services.GetRequiredService<MessageProvider>();
            private InvocationBuilder InvocationBuilder { get; }

            #endregion

            public ExpressionVisitor ExpressionVisitor { get; }



            //   : 'include' qualifiedIdentifier ('version' versionSpecifier)? ('called' localIdentifier)?
            public override IDefinitionElement VisitIncludeDefinition([NotNull] cqlParser.IncludeDefinitionContext context)
            {
                var (qualifier, id) = context.qualifiedIdentifier().Parse();
                var libraryName = string.IsNullOrWhiteSpace(qualifier) ? id : $"{qualifier}.{id}";
                var version = context.versionSpecifier()?.STRING().ParseString();
                var localIdentifier = context.localIdentifier()?.identifier().Parse() ?? id;
                var vi = new VersionedIdentifier { id = libraryName, version = version };

                var resolveSuccess = LibraryProvider.TryResolveLibrary(libraryName, version, out var includedLibraryBuilder, out var error);
                if (resolveSuccess && includedLibraryBuilder is not null)
                {
                    return new ReferencedLibrary(localIdentifier, vi, includedLibraryBuilder.SymbolTable)
                        .WithLocator(context.Locator());
                }
                else
                {
                    error ??= Messaging.UnableToResolveLibrary(libraryName, version);
                    var errorInclude = new ReferencedLibrary(localIdentifier, vi, new Scopes.SymbolTable(vi.ToString()!, null));
                    return errorInclude
                        .AddError(error!)
                        .WithLocator(context.Locator());
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
                    var result = CoercionProvider.Coerce(defaultExpr, type);

                    if (result.Success)
                        return result.Result;
                    else
                        return defaultExpr.AddError($"Expected an expression of type '{type}', but found an expression of type '{defaultExpr.resultTypeSpecifier}'.");
                }
            }

            // 'define' accessModifier? identifier ':' expression
            public override IDefinitionElement VisitExpressionDefinition([NotNull] cqlParser.ExpressionDefinitionContext context)
            {
                var name = context.identifier().Parse();
                var expression = ExpressionVisitor.Visit(context.expression());
                if (expression is null)
                {
                    var msg = $"Expression type {context.expression().GetType()} is not implemented.";
                    var errorDef = new ExpressionDef()
                    {
                        accessLevel = context.accessModifier().Parse(),
                        name = name,
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
                        name = name,
                        expression = expression,
                    };
                    return def
                        .WithLocator(context.Locator())
                        .WithResultType(expression.resultTypeSpecifier);
                }
            }

            public override IDefinitionElement VisitOperandDefinition([NotNull] cqlParser.OperandDefinitionContext context)
            {
                var identifier = context.referentialIdentifier().Parse();
                var type = TypeSpecifierVisitor.Visit(context.typeSpecifier());

                var od = new OperandDef() { name = identifier, operandTypeSpecifier = type };
                return od.WithLocator(context.Locator()).WithResultType(type);
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

                var table = LibraryBuilder.SymbolTable;



                // Go over the statements in order, since they can be interleaved
                // with context statements, which become active immediately.
                foreach (var statementContext in context)
                {
#if DEBUG
                    var statementText = statementContext.GetText();
#endif
                    if (statementContext.expressionDefinition() is { } edCtx)
                    {
                        var access = edCtx.accessModifier().Parse();
                        var name = edCtx.identifier().Parse();
                        if (name is null)
                            throw new InvalidOperationException($"Expression definition name could not be parsed.");
                        var dd = new DeferredExpressionDef(name, access,
                            () =>
                            {
                                var ed = (ExpressionDef)Visit(edCtx);
                                ed.context = activeContext?.name;
                                return ed;
                            });
                        if (!table.TryAdd(dd))
                            LibraryBuilder.AddError(Messaging.IdentifierAlreadyInUse(dd.Name), ErrorType.semantic);
                    }
                    else if (statementContext.functionDefinition() is { } fdCtx)
                    {
                        var access = fdCtx.accessModifier().Parse();
                        var fluent = fdCtx.fluentModifier() is not null;
                        var name = fdCtx.identifierOrFunctionIdentifier().Parse();
                        var signature = fdCtx.operandDefinition()
                            .Select(Visit)
                            .Cast<OperandDef>()
                            .ToArray();
                        var dd = new DeferredFunctionDef(access, fluent, name, signature,
                            () =>
                            {
                                var fd = createFunctionDef(access, fluent, name, signature, fdCtx);
                                fd.context = activeContext?.name;
                                return fd;
                            });
                        if (!table.TryAdd(dd))
                            LibraryBuilder.AddError(Messaging.IdentifierAlreadyInUse(dd.Name), ErrorType.semantic);
                    }
                    else if (statementContext.contextDefinition() is { } cdCtx)
                    {
                        // If we encounter a context statement, it will be applied to all
                        // subsequent expressions we encounter
                        var cd = (ContextDef)Visit(cdCtx);
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
                        throw new InvalidOperationException(
                            "Encountered unknown statement type in statement rule.");
                }

                FunctionDef createFunctionDef(AccessModifier access, bool fluent, string name, OperandDef[] signature,
                    cqlParser.FunctionDefinitionContext context)
                {

                    var functionDef = new FunctionDef
                    {
                        accessLevel = access,
                        name = name,
                        fluent = fluent,
                        operand = signature,
                    }.WithLocator(context.Locator());

                    var returnType = context.typeSpecifier() is { } ts ? TypeSpecifierVisitor.Visit(ts) : null;
                    var functionBody = context.functionBody();
                    if (functionBody is not null)
                    {
                        var scopeName = $"{name}({signature.Select(op => op.resultTypeSpecifier.ToString())})";
                        // Enter a new scope for the function body, so that the operands are visible
                        using (var scope = LibraryBuilder.EnterStatementScope(scopeName))
                        {
                            foreach (var operand in signature)
                                scope.TryAdd(operand);

                            // Visit the function body, which will add the expression to the functionDef
                            functionDef.expression = ExpressionVisitor.Visit(functionBody.expression());
                        }

                        // If the function has a return type, make sure the expression is of that type.
                        var expressionType = functionDef.expression.resultTypeSpecifier;
                        if (returnType is not null)
                        {
                            var result = CoercionProvider.Coerce(functionDef.expression, returnType);
                            if (!result.Success)
                                functionDef.AddError($"Function {functionDef.name} has declared return type {returnType} but " +
                                    $"the function body returns incompatible type {expressionType}.");

                            functionDef.WithResultType(returnType);
                        }
                        else
                            functionDef.WithResultType(expressionType);
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
                    if (functionDef.resultTypeSpecifier is null)
                    {
                        throw new InvalidOperationException($"Result type specifier of function is null");
                    }
                    return functionDef;
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

                var singleton = InvocationBuilder.Invoke(SystemLibrary.SingletonFrom, retrieve);
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
                    string? error = null;
                    TypeSpecifier? resultType = null;
                    if (modelIdentifier is not null) // two terms
                    {
                        if (LibraryBuilder.SymbolTable.TryResolveSymbol(modelIdentifier, out var symbol))
                        {
                            if (symbol is UsingDefSymbol ud)
                            {
                                var type = TypeSpecifierVisitor.GetModelType(ud, identifier);
                                if (type is not null)
                                    resultType = type.ToNamedType();
                                else
                                {
                                    // library UsingTeest version '1.0.0'
                                    // using FHIR
                                    // context FHIR.doesnotexist
                                    error = Messaging.CouldNotResolveContextName(identifier, modelIdentifier);
                                }
                            }
                            else
                            {
                                // library UsingTeest version '1.0.0'
                                // define derp: false
                                // context derp.herp
                                error = Messaging.CouldNotResolveModel(modelIdentifier);
                            }

                        }
                        else
                        {
                            // library UsingTeest version '1.0.0'
                            // context doesnot.exist
                            error = Messaging.CouldNotResolveModel(modelIdentifier);
                        }
                    }
                    else
                    {
                        var usings = LibraryBuilder.SymbolTable.OfType<UsingDefSymbol>();
                        if (TypeSpecifierVisitor.TryGetMatchingTypes(usings, identifier, out var modelType, out var _))
                            resultType = modelType.ToNamedType();
                        else
                        {
                            var models = usings
                                .Select(ud => ud.localIdentifier)
                                .Where(li => li != "System")
                                .ToArray();
                            error = Messaging.CouldNotResolveContextName(identifier, models);
                        }
                    }
                    cd = cd.WithResultType(resultType);
                    if (error is not null) cd.AddError(error);
                }

                return cd;
            }
        }
    }
}