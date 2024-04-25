// Global using directives

global using MethodAndParameters = (System.Reflection.MethodInfo method, System.Reflection.ParameterInfo[] parameters);
global using MethodAndParametersByParamCountByName = System.Collections.ObjectModel.ReadOnlyDictionary<string, System.Collections.ObjectModel.ReadOnlyDictionary<int, (System.Reflection.MethodInfo method, System.Reflection.ParameterInfo[] parameters)[]>>;