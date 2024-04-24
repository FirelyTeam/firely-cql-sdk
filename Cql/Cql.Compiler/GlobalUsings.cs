// Global using directives

global using CqlOperatorsMethod = Hl7.Cql.Abstractions.Infrastructure.ValueChoice<string, Hl7.Cql.Abstractions.CqlOperator>;
global using MethodAndParameters = (System.Reflection.MethodInfo method, System.Reflection.ParameterInfo[] parameters);
global using MethodAndParametersByParamCountByName = System.Collections.ObjectModel.ReadOnlyDictionary<string, System.Collections.ObjectModel.ReadOnlyDictionary<int, (System.Reflection.MethodInfo method, System.Reflection.ParameterInfo[] parameters)[]>>;