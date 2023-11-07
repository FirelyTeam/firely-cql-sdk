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

        private UsingDefSymbol? GetDefaultSystemModel()
        {
            var systemUri = Configuration[nameof(CqlToElmOptions.SystemElmModelUri)];
            var systemVersion = Configuration[nameof(CqlToElmOptions.SystemElmModelVersion)] ?? SystemTypes.SystemModelVersion;

            if (string.IsNullOrWhiteSpace(systemUri))
                return null;

            if (ModelProvider.ModelFromUri(systemUri, systemVersion) is { } model)
                return new UsingDefSymbol("System", model);
            else
                throw new InvalidOperationException($"Model {systemUri} version {systemVersion} is not available.");
        }

        // libraryDefinition? definition* statement* EOF;
        // definition : usingDefinition | includeDefinition | codesystemDefinition  | valuesetDefinition  | codeDefinition
        //     | conceptDefinition | parameterDefinition ;
        public override Library VisitLibrary([NotNull] cqlParser.LibraryContext context)
        {
            var identifier = context.libraryDefinition().Parse();
            var libraryBuilder = new LibraryBuilder(identifier);
            ConverterContext.EnterScope(libraryBuilder);

            // Add the default model, System
            if (GetDefaultSystemModel() is { } systemModel)
                libraryBuilder.TryAdd(systemModel);

            // TODO: Add the default function library, SystemLibrary

            // Parse the definitions, these will insert themselves into the current symbol table.
            _ = context.definition().Select(DefinitionVisitor.Visit);

            // The same is true for statements, although we have a specific visitor for those,
            // to handle the fact that statements can be expressions or contexts and we need
            // to make sure we change the context when we encounter one.
            DefinitionVisitor.VisitStatements(context.statement()).ToList();

            var library = libraryBuilder.Build();
            return library;
        }
    }
}
