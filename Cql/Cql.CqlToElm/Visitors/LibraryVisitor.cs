using Antlr4.Runtime.Misc;
using Hl7.Cql.CqlToElm.Grammar;
using Hl7.Cql.Elm;
using Microsoft.Extensions.Configuration;
using System;
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
            DefinitionVisitor definitionVisitor,
            LocalIdentifierProvider localIdentifierProvider,
            InvocationBuilder invocationBuilder) : base(localIdentifierProvider, invocationBuilder)
        {
            ConverterContext = converterContext;
            LibraryContext = libraryContext;
            Configuration = configuration;
            ModelProvider = modelProvider;
            DefinitionVisitor = definitionVisitor;
        }

        #region Services
        private LibraryContext LibraryContext { get; }
        private IConfiguration Configuration { get; }
        private IModelProvider ModelProvider { get; }
        public DefinitionVisitor DefinitionVisitor { get; }
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
        // definition : usingDefinition | includeDefinition | codesystemDefinition  | valuesetDefinition  | codeDefinition
        //     | conceptDefinition | parameterDefinition ;
        public override Library VisitLibrary([NotNull] cqlParser.LibraryContext context)
        {
            var library = new Library
            {
                identifier = context.libraryDefinition().Parse()
            };

            ConverterContext.AddLibrary(library);
            LibraryContext.ActiveLibrary = library;

            // visit usings and includes first so later definitions can refer to models.
            var systemUsings = GetDefaultSystemUsingDef() is { } sys ? new[] { sys } : Enumerable.Empty<UsingDef>();
            var firstDefinitions =
                (from definition in context.definition()
                 let usingOrInclude = buildUsingOrInclude(definition)
                 where usingOrInclude is not null
                 select usingOrInclude).ToList();

            Element? buildUsingOrInclude(cqlParser.DefinitionContext context) => context switch
            {
                _ when context.usingDefinition() is { } @using => DefinitionVisitor.Visit(@using),
                _ when context.includeDefinition() is { } include => DefinitionVisitor.Visit(@include),
                _ => null
            };

            library.usings = systemUsings.Concat(firstDefinitions.OfType<UsingDef>()).ToArray();
            library.includes = firstDefinitions.OfType<IncludeDef>().ToArray();

            var definitions = context.definition().Select(DefinitionVisitor.Visit).ToList();
            library.codeSystems = definitions.OfType<CodeSystemDef>().ToArray();
            library.valueSets = definitions.OfType<ValueSetDef>().ToArray();
            library.codes = definitions.OfType<CodeDef>().ToArray();
            library.concepts = definitions.OfType<ConceptDef>().ToArray();
            library.parameters = definitions.OfType<ParameterDef>().ToArray();

            var statements = DefinitionVisitor.VisitStatements(context.statement()).ToList();
            library.statements = statements.OfType<ExpressionDef>().ToArray();
            library.contexts = statements.OfType<ContextDef>().ToArray();

            return library;
        }
    }
}
