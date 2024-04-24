using System.Collections.Generic;

namespace Hl7.Cql.Compiler;

internal static class CqlOperatorsMethodsExtensions
{
    public static IEnumerable<MethodAndParameters> GetMethodsByName(
        this MethodAndParametersByParamCountByName methodsByMethodName,
        string methodName)
    {
        if (methodsByMethodName.TryGetValue(methodName, out var methodsByParamCount))
        {
            foreach (MethodAndParameters[] methodAndParametersArr in methodsByParamCount.Values)
            {
                foreach (MethodAndParameters methodAndParameters in methodAndParametersArr)
                {
                    yield return methodAndParameters;
                }
            }
        }
    }

    public static IEnumerable<MethodAndParameters> GetMethodsByNameAndParamCount(
        this MethodAndParametersByParamCountByName methodsByMethodName,
        string methodName,
        int paramCount)
    {
        if (methodsByMethodName.TryGetValue(methodName, out var methodsByParamCount)
            && methodsByParamCount.TryGetValue(paramCount, out var methodAndParametersArr))
        {
            foreach (MethodAndParameters methodAndParameters in methodAndParametersArr)
            {
                yield return methodAndParameters;
            }
        }
    }
}