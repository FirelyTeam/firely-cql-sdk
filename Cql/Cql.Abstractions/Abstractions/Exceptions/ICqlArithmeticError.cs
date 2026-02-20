/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Exceptions;

/// <summary>
/// Marker interface for <see cref="ICqlError"/> values that represent arithmetic errors
/// during CQL expression evaluation.
/// </summary>
/// <remarks>
/// Callers that need to handle any arithmetic error without knowing the concrete
/// error type can catch <c>CqlException&lt;ICqlArithmeticError&gt;</c> or inspect
/// <c>exception.Error is ICqlArithmeticError</c>.
/// </remarks>
public interface ICqlArithmeticError : ICqlError
{
}
