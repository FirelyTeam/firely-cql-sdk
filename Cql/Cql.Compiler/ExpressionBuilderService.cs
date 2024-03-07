using System;
using System.Linq.Expressions;
using System.Reflection;
using System.Xml.Linq;
using Hl7.Cql.Elm;
using Hl7.Cql.Runtime;
using Microsoft.Extensions.Logging;
using Expression = Hl7.Cql.Elm.Expression;

namespace Hl7.Cql.Compiler;

internal class ExpressionBuilderService
{
    private readonly ILogger<ExpressionBuilder> _logger;
    private readonly OperatorBinding _operatorBinding;
    private readonly TypeManager _typeManager;

    public ExpressionBuilderService(
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

    public MemberInfo? GetProperty(
        Library library,
        Type type,
        string name)
    {
        var expressionBuilder = new ExpressionBuilder(_typeManager, _logger, library);
        return expressionBuilder.GetProperty(type, name);
    }

    public LambdaExpression Lambda(
        Library library,
        Expression expression,
        OperatorBinding operatorBinding,
        DefinitionDictionary<LambdaExpression>? lambdas = null)
    {
        var expressionBuilder = new ExpressionBuilder(_typeManager, _logger, library);
        return expressionBuilder.Lambda(expression, operatorBinding, lambdas/*, ctx*/);
    }
}