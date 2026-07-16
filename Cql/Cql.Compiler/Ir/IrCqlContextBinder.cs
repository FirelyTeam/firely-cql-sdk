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
/// IR counterpart of <see cref="CqlContextBinder"/>: facilitates binding to
/// <see cref="CqlContext"/> methods. This is a mechanical port; see the remarks on
/// <see cref="IrCqlOperatorsBinder"/>.
/// </summary>
internal class IrCqlContextBinder
{
    private static readonly MethodInfo ResolveParameterMethod =
        typeof(CqlContext).GetMethod(nameof(CqlContext.ResolveParameter))!;

    /// <summary>
    /// Creates an expression which resolves a parameter in the CQL context,
    /// by binding to calling <see cref="CqlContext.ResolveParameter"/>.
    /// </summary>
    /// <param name="libraryKey">The key of the library containing the parameter.</param>
    /// <param name="parameterName">The name of the parameter.</param>
    /// <param name="defaultValue">The default value of the parameter.</param>
    /// <returns>The resolved parameter expression.</returns>
    public virtual IrExpression ResolveParameter(
        string libraryKey,
        string parameterName,
        IrExpression defaultValue) =>
        new IrInvoke(
            IrContextParameter.Instance,
            ResolveParameterMethod,
            new IrConstant(libraryKey, typeof(string)),
            new IrConstant(parameterName, typeof(string)),
            defaultValue
        );
}
