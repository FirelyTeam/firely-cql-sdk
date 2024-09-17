using FluentAssertions;
using Hl7.Cql.CqlToElm.LibraryProviders;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Text;

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