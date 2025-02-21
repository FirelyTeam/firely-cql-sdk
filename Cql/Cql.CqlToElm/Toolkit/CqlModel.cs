/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Model;

namespace Hl7.Cql.CqlToElm.Toolkit;

/// <summary>
/// Represents the model of CQL to use.
/// </summary>
public enum CqlModel
{
    /// <summary>
    /// Represents the ELM R1 model which maps to <seealso cref="Models.ElmR1"/>
    /// </summary>
    ElmR1 = 1,

    /// <summary>
    /// Represents the FHIR 4.0.1 model which maps to <seealso cref="Models.Fhir401"/>
    /// </summary>
    Fhir401 = 2,
}
