/*
 * Copyright (c) 2025, Firely and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Elm;

#pragma warning disable CS1591
public partial class Narrative
{
    [XmlAttribute]
    // ReSharper disable once InconsistentNaming
    public string? r { get; set; }

    // ReSharper disable once InconsistentNaming
    [XmlElement]
    public Narrative[]? s { get; set; }
}
