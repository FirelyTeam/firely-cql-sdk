/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Compiler.Ir;

/// <summary>
/// A function value. The emitter prints it as a local function (the style the previous
/// pipeline produced for query iterators) and passes its name where the delegate is expected.
/// <see cref="Type"/> is the corresponding <c>Func&lt;…&gt;</c> delegate type, which is what
/// operator overload resolution matches against parameters like <c>Func&lt;T, bool?&gt;</c>.
/// </summary>
internal sealed class IrLambda : IrExpression
{
    public IrLambda(IReadOnlyList<IrLocal> parameters, IrExpression body)
    {
        Parameters = parameters;
        Body = body;
        Type = System.Linq.Expressions.Expression.GetFuncType(
            [.. parameters.Select(p => p.Type), body.Type]);
    }

    /// <summary>The parameter variables; occurrences in <see cref="Body"/> are these same
    /// instances (reference identity, see <see cref="IrLocal"/>).</summary>
    public IReadOnlyList<IrLocal> Parameters { get; }

    public IrExpression Body { get; }

    public override Type Type { get; }
}
