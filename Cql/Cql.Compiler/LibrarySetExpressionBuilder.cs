using System.Linq.Expressions;
using Hl7.Cql.Conversion;
using Hl7.Cql.Runtime;
using Microsoft.Extensions.Logging;

namespace Hl7.Cql.Compiler;

internal partial class LibrarySetExpressionBuilder
{
    public LibrarySetExpressionBuilder(
        ILoggerFactory loggerFactory,
        OperatorBinding operatorBinding,
        TypeManager typeManager,
        TypeConverter typeConverter,
        LibraryDefinitionBuilderSettings libraryDefinitionBuilderSettings,
        LibrarySet librarySet,
        DefinitionDictionary<LambdaExpression> definitions)
    {
        // External Services
        _loggerFactory = loggerFactory;
        _operatorBinding = operatorBinding;
        _typeManager = typeManager;
        _libraryDefinitionBuilderSettings = libraryDefinitionBuilderSettings;
        _typeConverter = typeConverter;

        // External State
        _librarySet = librarySet;
        LibrarySetDefinitions = definitions;

        // Internal State
        _debuggerInfo = new BuilderDebuggerInfo("LibrarySet", Name: _librarySet.Name!);
    }

    public DefinitionDictionary<LambdaExpression> ProcessLibrarySet() =>
        this.CatchRethrowExpressionBuildingException(_ =>
        {
            foreach (var library in LibrarySet)
            {
                var packageDefinitions = CreateLibraryExpressionBuilder(library, new()).ProcessLibrary();
                LibrarySetDefinitions.Merge(packageDefinitions);
            }

            return LibrarySetDefinitions;
        });
}