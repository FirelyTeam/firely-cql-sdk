/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.CqlToElm.LibraryProviders;

namespace Hl7.Cql.CqlToElm.Test
{
    [TestClass]
    public class StreamInspectorTest
    {

        private static StreamReader StringStream(string s) => new StreamReader(new MemoryStream(Encoding.UTF8.GetBytes(s)), Encoding.UTF8);

        [TestMethod]
        public void FromCql_IdentifierOnly()
        {
            var si = new StreamInspector();
            using var ss = StringStream("library Foo\n");
            var vi = si.FromCql(ss);
            vi.Should().NotBeNull();
            vi!.id.Should().Be("Foo");
            vi!.version.Should().BeNull();
        }

        [TestMethod]
        public void FromCql_VersionedIdentifier()
        {
            var si = new StreamInspector();
            using var ss = StringStream("library Foo version '1.0.0'");
            var vi = si.FromCql(ss);
            vi.Should().NotBeNull();
            vi!.id.Should().Be("Foo");
            vi!.version.Should().Be("1.0.0");
        }

        [TestMethod]
        public void FromCql_Malformed()
        {
            var si = new StreamInspector();
            using var ss = StringStream("library Foo version '1.0.0"); // missing end quote
            var vi = si.FromCql(ss);
            vi.Should().BeNull();
        }
    }
}