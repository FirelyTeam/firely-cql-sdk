using Hl7.Cql.Abstractions;
using Hl7.Cql.Elm;

namespace Hl7.Cql.Compiler;

/// <seealso cref="ParameterDef"/>
/// <seealso cref="CqlParameterDefinitionAttribute"/>
internal class CqlParameterDefinition(
    LambdaExpression lambda,
    string name)
    : CqlDefinition(lambda, name);