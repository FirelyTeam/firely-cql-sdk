/*
 * Copyright (c) 2025, Firely and NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;
using Hl7.Cql.Elm;

namespace Hl7.Cql.Compiler.Expressions;

/// <seealso cref="ConceptDef"/>
/// <seealso cref="CqlConceptDefinitionAttribute"/>
internal class CqlConceptDefinition(
    LambdaExpression lambda,
    string definitionName)
    : CqlDefinition(lambda, definitionName);