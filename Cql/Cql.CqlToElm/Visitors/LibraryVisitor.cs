using Antlr4.Runtime.Misc;
using Hl7.Cql.CqlToElm.Grammar;
using Hl7.Cql.Elm;
using Microsoft.Extensions.Configuration;

namespace Hl7.Cql.CqlToElm.Visitors
{
    internal class LibraryVisitor : Visitor<Library>
    {
        public LibraryVisitor(
            LibraryBuilder libraryBuilder,
            IConfiguration configuration,
            IModelProvider modelProvider,
            DefinitionVisitor definitionVisitor,
            LocalIdentifierProvider localIdentifierProvider,
            InvocationBuilder invocationBuilder) : base(localIdentifierProvider, invocationBuilder)
        {
            LibraryBuilder = libraryBuilder;
            Configuration = configuration;
            ModelProvider = modelProvider;
            DefinitionVisitor = definitionVisitor;
        }

        #region Services
        public LibraryBuilder LibraryBuilder { get; }
        private IConfiguration Configuration { get; }
        private IModelProvider ModelProvider { get; }
        public DefinitionVisitor DefinitionVisitor { get; }
        #endregion

        private UsingDefSymbol? GetDefaultSystemModel()
        {
            var systemUri = Configuration[nameof(CqlToElmOptions.SystemElmModelUri)];
            var systemVersion = Configuration[nameof(CqlToElmOptions.SystemElmModelVersion)] ?? SystemTypes.SystemModelVersion;

            if (string.IsNullOrWhiteSpace(systemUri))
                return null;

            var model = ModelProvider.GetModelFromUri(systemUri, systemVersion);
            if (model is not null)
                return new UsingDefSymbol("System", systemVersion, model);
            else return null;
        }

        // libraryDefinition? definition* statement* EOF;
        // definition : usingDefinition | includeDefinition | codesystemDefinition  | valuesetDefinition  | codeDefinition
        //     | conceptDefinition | parameterDefinition ;
        public override Library VisitLibrary([NotNull] cqlParser.LibraryContext context)
        {
            var identifier = context.libraryDefinition()?.Parse();
            if (identifier is not null)
                LibraryBuilder.Identifier = identifier;

            // Add the default model, System
            if (GetDefaultSystemModel() is { } systemModel)
                LibraryBuilder.CurrentScope.TryAdd(systemModel);

            // TODO: Add the default function library, SystemLibrary

            // Parse the definitions, this function will insert the visited definitions into the current scope.
            DefinitionVisitor.VisitDefinitions(context.definition());

            // The same is true for statements, although we have a specific visitor for those,
            // to handle the fact that statements can be expressions or contexts and we need
            // to make sure we change the context when we encounter one.
            DefinitionVisitor.VisitStatements(context.statement());

            var library = LibraryBuilder.Build();
            return library;
        }
    }
}
