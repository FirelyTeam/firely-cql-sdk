/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Compiler.CodeModel;

/// <summary>
/// Throws an exception. Used only for the generator's error-recovery stubs; carries a result
/// type so it can stand in for an expression of any type.
/// </summary>
internal sealed class CodeThrow : CodeExpression
{
    public CodeThrow(CodeExpression exception, Type resultType)
    {
        if (!typeof(Exception).IsAssignableFrom(exception.Type))
            throw new ArgumentException($"Throw operand must be an Exception, not {exception.Type}.");
        Exception = exception;
        Type = resultType;
    }

    public CodeExpression Exception { get; }

    public override Type Type { get; }
}
