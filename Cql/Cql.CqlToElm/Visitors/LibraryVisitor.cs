using Antlr4.Runtime.Misc;
using Hl7.Cql.CqlToElm.Grammar;
using Hl7.Cql.Elm;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Hl7.Cql.CqlToElm.Visitors
{
    internal class LibraryVisitor : Visitor<Library>
    {
        public LibraryVisitor(IServiceProvider services) : base(services)
        {
        }

        #region Services
        private ConverterContext ConverterContext => Services.GetRequiredService<ConverterContext>();
        private LibraryContext LibraryContext => Services.GetRequiredService<LibraryContext>();

        private IConfiguration Configuration => Services.GetRequiredService<IConfiguration>();
        private IModelProvider ModelProvider => Services.GetRequiredService<IModelProvider>();
        private VersionedIdentifierVisitor VersionedIdentifierVisitor => Services.GetRequiredService<VersionedIdentifierVisitor>();
        private ParameterDefinitionVisitor ParameterDefinitionVisitor => Services.GetRequiredService<ParameterDefinitionVisitor>();
        private ExpressionDefinitionVisitor ExpressionDefinitionVisitor => Services.GetRequiredService<ExpressionDefinitionVisitor>();
        private ExpressionVisitor ExpressionVisitor => Services.GetRequiredService<ExpressionVisitor>();
        private ContextDefVisitor ContextDefVisitor => Services.GetRequiredService<ContextDefVisitor>();


        #endregion
        public override Library VisitLibrary([NotNull] cqlParser.LibraryContext context)
        {
            var library = new Library
            {
                identifier = VersionedIdentifierVisitor.Visit(context.GetChild(0))
            };
            ConverterContext.AddLibrary(library);
            if (LibraryContext.Library == null)
                LibraryContext.Library = library;
            else throw new InvalidOperationException($"This scope already contains a library");

            var usings = new LinkedList<UsingDef>();
            var includes = new LinkedList<IncludeDef>();
            var codeSystems = new LinkedList<CodeSystemDef>();
            var valueSets = new LinkedList<ValueSetDef>();
            var codes = new LinkedList<CodeDef>();
            var concepts = new LinkedList<ConceptDef>();
            var parameters = new LinkedList<ParameterDef>();
            var statements = new LinkedList<ExpressionDef>();
            var contextStatements = new Dictionary<string, ExpressionDef>();

            var defaultSystemUri = Configuration[nameof(CqlToElmOptions.SystemElmModelUri)];
            var defaultSystemVersion = Configuration[nameof(CqlToElmOptions.SystemElmModelVersion)];
            if (!string.IsNullOrWhiteSpace(defaultSystemUri)
                && !string.IsNullOrWhiteSpace(defaultSystemVersion))
            {
                var model = ModelProvider.ModelFromUri(defaultSystemUri, defaultSystemVersion);
                if (model != null)
                {
                    usings.AddFirst(new UsingDef
                    {
                        uri = model.url,
                        localIdentifier = "System",
                        localId = NextId(),
                    });
                }
                else throw new InvalidOperationException($"Model {defaultSystemUri} version {defaultSystemVersion} is not available.");
            }
            // visit usings first so parameters can refer to models
            foreach (var child in context.children.OfType<cqlParser.DefinitionContext>())
            {
                if (child.GetChild(0) is cqlParser.UsingDefinitionContext udc)
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
                                        var expressionDef = ExpressionDefinitionVisitor.Visit(expression);
                                        if (LibraryContext.ActiveContext != null)
                                            expressionDef.context = LibraryContext.ActiveContext.name;
                                        statements.AddLast(expressionDef);
                                    }
                                    break;
                                case cqlParser.ContextDefinitionContext ctx:
                                    {
                                        var contextDef = ContextDefVisitor.Visit(ctx);
                                        LibraryContext.ActiveContext = contextDef;
                                        if (!contextStatements.ContainsKey(contextDef.name))
                                        {
                                            var (dataType, templateId) = LibraryContext.UnambiguousType(contextDef.name);
                                            var elementType = NamedType(dataType.Name, ctx);
                                            var retrieve = new Retrieve
                                            {
                                                localId = NextId(),
                                                locator = ctx.Locator(),
                                                dataType = dataType,
                                                templateId = templateId,
                                                resultTypeSpecifier = ListType(elementType, ctx),
                                            };
                                            var singleton = new SingletonFrom
                                            {
                                                localId = NextId(),
                                                locator = ctx.Locator(),
                                                operand = retrieve,
                                                resultTypeSpecifier = elementType,
                                                resultTypeName = elementType.name,
                                            };
                                            var exprDef = new ExpressionDef
                                            {
                                                localId = NextId(),
                                                locator = ctx.Locator(),
                                                name = contextDef.name,
                                                expression = singleton,
                                                resultTypeSpecifier = elementType,
                                                resultTypeName = elementType.name,
                                            };
                                            contextStatements.Add(contextDef.name, exprDef);
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
            return library;
        }

    }
}
