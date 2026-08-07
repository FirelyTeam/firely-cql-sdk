/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Compiler.Infrastructure;
using Hl7.Cql.Runtime;

namespace Hl7.Cql.Compiler;

/// <summary>
/// Facilitates binding to <see cref="CqlContext"/> methods. See the remarks on
/// <see cref="CqlOperatorsBinder"/>.
/// </summary>
internal class CqlContextBinder
{
    private static readonly MethodInfo ResolveParameterMethod =
        ReflectionUtility.MethodOf(() => default(CqlContext)!.ResolveParameter(default!, default!, default!));

    /// <summary>
    /// Creates an expression which resolves a parameter in the CQL context,
    /// by binding to calling <see cref="CqlContext.ResolveParameter"/>.
    /// </summary>
    /// <param name="libraryKey">The key of the library containing the parameter.</param>
    /// <param name="parameterName">The name of the parameter.</param>
    /// <param name="defaultValue">The default value of the parameter.</param>
    /// <returns>The resolved parameter expression.</returns>
    public virtual CodeExpression ResolveParameter(
        string libraryKey,
        string parameterName,
        CodeExpression defaultValue) =>
        new CodeInvoke(
            CodeContextParameter.Instance,
            ResolveParameterMethod,
            new CodeConstant(libraryKey, typeof(string)),
            new CodeConstant(parameterName, typeof(string)),
            defaultValue
        );
}
