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
            IConfiguration configuration,
            IModelProvider modelProvider,
            DefinitionVisitor definitionVisitor,
            LocalIdentifierProvider localIdentifierProvider,
            InvocationBuilder invocationBuilder) : base(localIdentifierProvider, invocationBuilder)
        {
            ConverterContext = converterContext;
            Configuration = configuration;
            ModelProvider = modelProvider;
            DefinitionVisitor = definitionVisitor;
        }

        #region Services
        private IConfiguration Configuration { get; }
        private IModelProvider ModelProvider { get; }
        public DefinitionVisitor DefinitionVisitor { get; }
        public ConverterContext ConverterContext { get; }
        #endregion

        private ModelLibrary? GetDefaultSystemModel()
        {
            var systemUri = Configuration[nameof(CqlToElmOptions.SystemElmModelUri)];
            var systemVersion = Configuration[nameof(CqlToElmOptions.SystemElmModelVersion)] ?? SystemTypes.SystemModelVersion;

            if (string.IsNullOrWhiteSpace(systemUri))
                return null;

            if (ModelProvider.ModelFromUri(systemUri, systemVersion) is { } model)
                return new ModelLibrary("System", model);
            else
                throw new InvalidOperationException($"Model {systemUri} version {systemVersion} is not available.");
        }

        // libraryDefinition? definition* statement* EOF;
        // definition : usingDefinition | includeDefinition | codesystemDefinition  | valuesetDefinition  | codeDefinition
        //     | conceptDefinition | parameterDefinition ;
        public override Library VisitLibrary([NotNull] cqlParser.LibraryContext context)
        {
            var identifier = context.libraryDefinition().Parse();
            var libraryScope = new LibraryScope(identifier);
            ConverterContext.EnterScope(libraryScope);

            if (GetDefaultSystemModel() is { } systemModel)
                libraryScope.TryAdd(systemModel);

            foreach (var definition in context.definition())
            {
                libraryScope.TryAdd(DefinitionVisitor.Visit(definition));
            }
            context.definition().Select(DefinitionVisitor.Visit).ToList();

            // The same is true for statements, although we have a specific visitor for those,
            // to handle the fact that statements can be expressions or contexts and we need
            // to make sure we change the context when we encounter one.
            DefinitionVisitor.VisitStatements(context.statement()).ToList();

            var library = libraryScope.BuildLibrary();
            return library;
        }
    }
}
