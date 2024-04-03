using System;
using System.Reflection;
using Hl7.Cql.Abstractions.Exceptions;
using Hl7.Cql.Compiler;
using MethodDecorator.Fody.Interfaces;

[module: RethrowExceptionsAsExpressionBuilderException]


namespace Hl7.Cql.Compiler;

[AttributeUsage(AttributeTargets.Method | AttributeTargets.Constructor | AttributeTargets.Assembly | AttributeTargets.Module)]
internal class RethrowExceptionsAsExpressionBuilderExceptionAttribute : Attribute, IMethodDecorator
{
    private IBuilderNode _builderNode = null!;

    public void Init(object instance, MethodBase method, object[] args)
    {
        _builderNode = (IBuilderNode)instance;
    }

    public void OnEntry()
    {
    }

    public void OnExit()
    {
    }

    public void OnException(Exception exception)
    {
        if (exception is not CqlException<ExpressionBuildingError>)
            throw _builderNode.NewExpressionBuildingException(innerException: exception);
    }
}
