/*
 * Copyright (c) 2025, Firely and NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System.Collections.ObjectModel;
using Hl7.Cql.Abstractions;
using Hl7.Cql.Elm;

namespace Hl7.Cql.Compiler.Expressions;

/// <seealso cref="FunctionDef"/>
/// <seealso cref="CqlFunctionDefinitionAttribute"/>
internal class CqlFunctionDefinition(
    LambdaExpression lambdaExpression,
    string name,
    IReadOnlyDictionary<string, string>? originalParameterNames = null,
    params (string tagName, string[] tagValues)[] tags) : CqlExpressionDefinition(lambdaExpression, name, tags)
{
    /// <summary>
    /// Gets a dictionary mapping normalized C# parameter names to their original CQL parameter names.
    /// Only contains entries where the normalized name differs from the original name.
    /// </summary>
    public IReadOnlyDictionary<string, string> OriginalParameterNames { get; } = originalParameterNames ?? ReadOnlyDictionary<string, string>.Empty;
}