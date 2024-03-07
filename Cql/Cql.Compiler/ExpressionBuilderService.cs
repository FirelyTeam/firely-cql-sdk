using System;
using System.Linq.Expressions;
using System.Reflection;
using Hl7.Cql.Elm;
using Hl7.Cql.Runtime;
using Microsoft.Extensions.Logging;
using Expression = Hl7.Cql.Elm.Expression;

namespace Hl7.Cql.Compiler;

internal class ExpressionBuilderService
{
    private readonly ILoggerFactory _loggerFactory;
    private readonly OperatorBinding _operatorBinding;
    private readonly TypeManager _typeManager;

    public ExpressionBuilderService(
        ILoggerFactory loggerFactory, 
        OperatorBinding operatorBinding,
        TypeManager typeManager)
    {
        _loggerFactory = loggerFactory;
        _operatorBinding = operatorBinding;
        _typeManager = typeManager;
    }

    public DefinitionDictionary<LambdaExpression> BuildLibraryDefinitions(Library library) => 
        LibraryExpressionBuilder.BuildLibraryDefinitions(_operatorBinding, _typeManager, _loggerFactory, library);

    public MemberInfo? GetProperty(
        Type type,
        string name)
    {
        var expressionBuilder = new ExpressionBuilder(_typeManager, _loggerFactory.CreateLogger<ExpressionBuilder>());
        return expressionBuilder.GetProperty(type, name);
    }

    public LambdaExpression Lambda(
        Library library,
        Expression expression,
        OperatorBinding operatorBinding,
        DefinitionDictionary<LambdaExpression>? lambdas = null)
    {
        var expressionBuilder = new ExpressionBuilder(_typeManager, _loggerFactory.CreateLogger<ExpressionBuilder>());
        return expressionBuilder.Lambda(library, expression, operatorBinding, lambdas);
    }
}