/*
// * Copyright (c) 2024, NCQA and contributors
// * See the file CONTRIBUTORS for details.
// *
// * This file is licensed under the BSD 3-Clause license
// * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
// */
// Global using directives

global using ExpressionElementPairForIdentifier = System.Collections.Generic.KeyValuePair<string, (System.Linq.Expressions.Expression, Hl7.Cql.Elm.Element)>;
global using MethodAndParameters = (System.Reflection.MethodInfo method, System.Reflection.ParameterInfo[] parameters);
global using MethodAndParametersByParamCountByName = System.Collections.ObjectModel.ReadOnlyDictionary<string, System.Collections.ObjectModel.ReadOnlyDictionary<int, (System.Reflection.MethodInfo method, System.Reflection.ParameterInfo[] parameters)[]>>;