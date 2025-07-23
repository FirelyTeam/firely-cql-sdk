/*
 * Copyright (c) 2025, Firely and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Runtime.Parsing;

/// <summary>
/// Represents a handler for CQL parse errors.
/// </summary>
/// <param name="parseError">The CQL parse error that occurred.</param>
public delegate void CqlParseErrorHandler(CqlParseError parseError);
