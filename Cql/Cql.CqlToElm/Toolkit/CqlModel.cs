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
/// <remarks>
/// Select at most one version of each model: <see cref="USCore311"/> and <see cref="USCore610"/> share a url, as do
/// <see cref="QICore411"/> and <see cref="QICore600"/>, and a <see cref="CqlToolkit"/> configured with two versions of
/// the same model throws an <see cref="ArgumentException"/>. Translate libraries written against another version
/// with a separate toolkit.
/// </remarks>
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

    /// <summary>
    /// Represents the US Core 3.1.1 model (<c>http://hl7.org/fhir/us/core</c>), which maps to <seealso cref="Models.USCore311"/>.
    /// This is the US Core model used together with <see cref="QICore411"/>.
    /// </summary>
    USCore311 = 3,

    /// <summary>
    /// Represents the QICore 4.1.1 model (<c>http://hl7.org/fhir/us/qicore</c>), which maps to <seealso cref="Models.QICore411"/>.
    /// </summary>
    QICore411 = 4,

    /// <summary>
    /// Represents the US Core 6.1.0 model (<c>http://hl7.org/fhir/us/core</c>), which maps to <seealso cref="Models.USCore610"/>.
    /// This is the US Core model used together with <see cref="QICore600"/>.
    /// </summary>
    USCore610 = 5,

    /// <summary>
    /// Represents the QICore 6.0.0 model (<c>http://hl7.org/fhir/us/qicore</c>), which maps to <seealso cref="Models.QICore600"/>.
    /// </summary>
    QICore600 = 6,
}
