using System.Linq.Expressions;
using Hl7.Cql.Conversion;
using Hl7.Cql.Elm;
using Hl7.Cql.Runtime;
using Microsoft.Extensions.Logging;

namespace Hl7.Cql.Compiler;

internal partial class LibrarySetExpressionBuilder : IBuilderNode
{
    private readonly ILoggerFactory _loggerFactory;
    private readonly OperatorBinding _operatorBinding;
    private readonly TypeManager _typeManager;
    private readonly LibraryDefinitionBuilderSettings _libraryDefinitionBuilderSettings;
    private readonly LibrarySet _librarySet;
    private readonly BuilderDebuggerInfo _debuggerInfo;
    private readonly TypeConverter _typeConverter;
    public DefinitionDictionary<LambdaExpression> LibrarySetDefinitions { get; }

    public LibrarySet LibrarySet => _librarySet;

    public LibraryExpressionBuilder CreateLibraryExpressionBuilder(
        Library library,
        DefinitionDictionary<LambdaExpression>? definitions = null) =>
        new(_loggerFactory, _operatorBinding, _typeManager, _typeConverter, library, _libraryDefinitionBuilderSettings, definitions ?? new(), this);
}