/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable

using System.Xml.Serialization;

namespace Hl7.Cql.CqlToElm.Test.Xml
{
    // The `versionTo` attribute of the test schema: the last specification version in which the tested feature appears.
    // It sits beside the generated classes in testSchema.cs, which predate the attribute.

    public partial class Tests
    {
        [XmlAttribute]
        public string? versionTo { get; set; }
    }

    public partial class Group
    {
        [XmlAttribute]
        public string? versionTo { get; set; }
    }

    public partial class Test
    {
        [XmlAttribute]
        public string? versionTo { get; set; }
    }
}
