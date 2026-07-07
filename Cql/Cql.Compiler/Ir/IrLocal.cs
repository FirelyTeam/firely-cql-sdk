/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Runtime;

namespace Hl7.Cql.Compiler.Ir;

/// <summary>
/// A local variable or lambda parameter.
///
/// <para><b>Reference identity is the variable's identity</b>: two <see cref="IrLocal"/>
/// instances denote the same variable if and only if they are the same instance. This mirrors
/// how <c>ParameterExpression</c> identity scoped query aliases in the previous pipeline.
/// The builder introduces one instance per alias/parameter and reuses it at every occurrence;
/// the emitter allocates the final C# name per method scope (using <see cref="NameHint"/>
/// where possible), so names never need to be unique at construction time.</para>
/// </summary>
internal sealed class IrLocal(Type type, string? nameHint = null) : IrExpression
{
    /// <summary>
    /// Optional preferred name (e.g. a CQL query alias). The emitter uses it when it is
    /// available and unique in the scope; otherwise it allocates a generated name.
    /// </summary>
    public string? NameHint { get; } = nameHint;

    public override Type Type { get; } = type;

    public override string ToString() => $"{NameHint ?? "<local>"}: {Type.Name}";
}

/// <summary>
/// The <see cref="CqlContext"/> parameter that every generated definition receives. Printed
/// as <c>context</c>. A single well-known instance is used so occurrences compare equal by
/// reference like any other variable.
/// </summary>
internal sealed class IrContextParameter : IrExpression
{
    private IrContextParameter() { }

    public static IrContextParameter Instance { get; } = new();

    public override Type Type => typeof(CqlContext);
}
