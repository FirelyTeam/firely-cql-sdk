/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Exceptions;

/// <summary>
/// Marker interface for <see cref="ICqlError"/> values that the CQL specification requires to be signalled to the
/// calling environment during expression evaluation, as opposed to failures inside the SDK.
/// </summary>
/// <remarks>
/// Errors are thrown as <see cref="CqlException{TError}"/> of their concrete type, so a host recognizes any evaluation
/// error with <c>catch (CqlException e) when (e.Error is ICqlEvaluationError)</c>.
/// </remarks>
public interface ICqlEvaluationError : ICqlError
{
}
