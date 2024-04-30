/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */
using System.Linq.Expressions;
using Hl7.Cql.Runtime;

namespace Hl7.Cql.Compiler;

internal interface ILibrarySetExpressionBuilderContext : IBuilderContext
{
    DefinitionDictionary<LambdaExpression> LibrarySetDefinitions { get; }
    LibrarySet LibrarySet { get; }
}