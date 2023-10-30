using Antlr4.Runtime.Misc;
using Hl7.Cql.CqlToElm.Builtin;
using Hl7.Cql.CqlToElm.Grammar;
using Hl7.Cql.Elm;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Hl7.Cql.CqlToElm.Visitors
{
    internal class LibraryVisitor : Visitor<Library>
    {
        public LibraryVisitor(
            ConverterContext converterContext,
            LibraryContext libraryContext,
            IConfiguration configuration,
            IModelProvider modelProvider,
            ParameterDefinitionVisitor parameterDefinitionVisitor,
            ExpressionVisitor expressionVisitor,
            LocalIdentifierProvider localIdentifierProvider) : base(localIdentifierProvider)
        {
            ConverterContext = converterContext;
            LibraryContext = libraryContext;
            Configuration = configuration;
            ModelProvider = modelProvider;
            ParameterDefinitionVisitor = parameterDefinitionVisitor;
            ExpressionVisitor = expressionVisitor;
        }

        #region Services
        private LibraryContext LibraryContext { get; }
        private IConfiguration Configuration { get; }
        private IModelProvider ModelProvider { get; }
        private ParameterDefinitionVisitor ParameterDefinitionVisitor { get; }
        private ExpressionVisitor ExpressionVisitor { get; }
        public ConverterContext ConverterContext { get; }
        #endregion

        private UsingDef? GetDefaultSystemUsingDef()
        {
            var systemUri = Configuration[nameof(CqlToElmOptions.SystemElmModelUri)];
            var systemVersion = Configuration[nameof(CqlToElmOptions.SystemElmModelVersion)] ?? SystemTypes.SystemModelVersion;

            if (string.IsNullOrWhiteSpace(systemUri))
                return null;

            if (ModelProvider.ModelFromUri(systemUri, systemVersion) is { } model)
            {
                return new UsingDef
                {
                    uri = model.url,
                    localIdentifier = "System",
                }.WithId();
            }
            else
                throw new InvalidOperationException($"Model {systemUri} version {systemVersion} is not available.");
        }

        // libraryDefinition? definition* statement* EOF;
        public override Library VisitLibrary([NotNull] cqlParser.LibraryContext context)
        {
            var library = new Library
            {
                identifier = context.libraryDefinition().Parse()
            };

            ConverterContext.AddLibrary(library);
            LibraryContext.ActiveLibrary = library;

            var usings = new LinkedList<UsingDef>();
            var includes = new LinkedList<IncludeDef>();
            var codeSystems = new LinkedList<CodeSystemDef>();
            var valueSets = new LinkedList<ValueSetDef>();
            var codes = new LinkedList<CodeDef>();
            var concepts = new LinkedList<ConceptDef>();
            var parameters = new LinkedList<ParameterDef>();
            var statements = new LinkedList<ExpressionDef>();
            var contextDefs = new LinkedList<ContextDef>();
            var contextStatements = new Dictionary<string, ExpressionDef>();


            var systemUsing = GetDefaultSystemUsingDef();
            if (systemUsing is not null) usings.AddLast(systemUsing);

            // visit usings first so parameters can refer to models
            foreach (var child in context.definition())
            {
                if (child.usingDefinition() is { } udc)
                {
                    var usingDef = udc.Parse(ModelProvider);
                    usings.AddLast(usingDef);
                }
            }

            library.usings = usings.ToArray();

            int i = 1;
            bool declarations = true;
            while (declarations && i < context.ChildCount)
            {
                var child = context.GetChild(i);
                switch (child)
                {
                    case cqlParser.DefinitionContext _def:
                        {
                            var definition = _def.GetChild(0);
                            switch (definition)
                            {
                                case cqlParser.IncludeDefinitionContext include:
                                    {
                                        var includeDef = include.Parse();
                                        includes.AddLast(includeDef);
                                    }
                                    break;
                                case cqlParser.CodesystemDefinitionContext codeSystem:
                                    {
                                        var codeSystemDef = codeSystem.Parse();
                                        codeSystems.AddLast(codeSystemDef);
                                    }
                                    break;
                                case cqlParser.ValuesetDefinitionContext valueSet:
                                    {
                                        var valueSetDef = valueSet.Parse();
                                        valueSets.AddLast(valueSetDef);
                                    }
                                    break;
                                case cqlParser.CodeDefinitionContext code:
                                    {
                                        var codeDef = code.Parse();
                                        codes.AddLast(codeDef);
                                    }
                                    break;
                                case cqlParser.ConceptDefinitionContext concept:
                                    {
                                        var conceptDef = concept.Parse();
                                        concepts.AddLast(conceptDef);
                                    }
                                    break;
                                case cqlParser.ParameterDefinitionContext parameter:
                                    {
                                        var parameterDef = ParameterDefinitionVisitor.Visit(parameter);
                                        parameters.AddLast(parameterDef);
                                    }
                                    break;

                                default: break;
                            }
                        }
                        i++;
                        break;
                    default:
                        declarations = false;
                        break;
                }
            }

            library.includes = includes.ToArray();
            library.codeSystems = codeSystems.ToArray();
            library.valueSets = valueSets.ToArray();
            library.codes = codes.ToArray();
            library.concepts = concepts.ToArray();
            library.parameters = parameters.ToArray();

            for (; i < context.ChildCount - 1; i++)
            {
                var child = context.GetChild(i);
                switch (child)
                {
                    case cqlParser.StatementContext statement:
                        {
                            var statementChild = statement.GetChild(0);
                            switch (statementChild)
                            {
                                case cqlParser.ExpressionDefinitionContext expression:
                                    {
                                        var expressionDef = expression.Parse(ExpressionVisitor);
                                        if (LibraryContext.ActiveContext != null)
                                            expressionDef.context = LibraryContext.ActiveContext.name;
                                        statements.AddLast(expressionDef);
                                    }
                                    break;
                                case cqlParser.ContextDefinitionContext ctx:
                                    {
                                        var (namedType, contextDef) = ctx.Parse(LibraryContext);
                                        LibraryContext.ActiveContext = contextDef;

                                        if (!contextStatements.ContainsKey(contextDef.name))
                                        {
                                            var (_, exprName) = namedType.GetNameComponents();

                                            var retrieve = new Retrieve
                                            {
                                                dataType = namedType.name,
                                                templateId = ModelProvider.GetDefaultProfileUriForType(namedType),
                                            }.WithLocator(ctx.Locator()).WithResultType(namedType.ToListType());

                                            Expression singleton = SystemLibrary.SingletonFrom.Call(ModelProvider, ctx, retrieve);

                                            var exprDef = new ExpressionDef
                                            {
                                                name = exprName,
                                                expression = singleton,
                                                context = contextDef.name,
                                            }.WithLocator(ctx.Locator()).WithResultType(singleton.resultTypeSpecifier);

                                            contextStatements.Add(contextDef.name, exprDef);

                                            contextDefs.AddLast(contextDef);
                                            statements.AddLast(exprDef);
                                        }
                                    }
                                    break;

                                default:
                                    throw new InvalidOperationException($"Unexpected context type {child.GetType().FullName}");
                            }
                        }
                        break;
                    default:
                        break;
                }
            }

            library.statements = statements.ToArray();
            library.contexts = contextDefs.ToArray();
            return library;
        }

    }
}
