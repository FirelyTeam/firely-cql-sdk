/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable

namespace Hl7.Cql.Exceptions;

/// <summary>
/// Marker interface for <see cref="ICqlError"/> values that represent arithmetic errors
/// during CQL expression evaluation.
/// </summary>
/// <remarks>
/// Errors are thrown as a <see cref="CqlException{TError}"/> of their concrete type, so callers that need to handle
/// any arithmetic error without knowing that type use
/// <c>catch (CqlException e) when (e.Error is ICqlArithmeticError)</c>.
/// </remarks>
public interface ICqlArithmeticError : ICqlEvaluationError
{
}
