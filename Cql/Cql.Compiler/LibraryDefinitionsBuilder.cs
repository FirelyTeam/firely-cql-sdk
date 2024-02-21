using System.Linq.Expressions;
using Hl7.Cql.Elm;
using Hl7.Cql.Runtime;
using Microsoft.Extensions.Logging;

namespace Hl7.Cql.Compiler;

internal class LibraryDefinitionsBuilder
{
    private readonly ILogger<ExpressionBuilder> _logger;
    private readonly OperatorBinding _operatorBinding;
    private readonly TypeManager _typeManager;

    public LibraryDefinitionsBuilder(
        ILogger<ExpressionBuilder> logger, 
        OperatorBinding operatorBinding,
        TypeManager typeManager)
    {
        _logger = logger;
        _operatorBinding = operatorBinding;
        _typeManager = typeManager;
    }

    public DefinitionDictionary<LambdaExpression> BuildLibraryDefinitions(Library library) => 
        ExpressionBuilder.BuildLibraryDefinitions(_operatorBinding, _typeManager, _logger, library);
}