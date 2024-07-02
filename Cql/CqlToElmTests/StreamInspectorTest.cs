using FluentAssertions;
using Hl7.Cql.CqlToElm.LibraryProviders;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.CqlToElm.Test
{
    [TestClass]
    public class StreamInspectorTest
    {

        private static StreamReader StringStream(string s) => new StreamReader(new MemoryStream(Encoding.UTF8.GetBytes(s)), Encoding.UTF8);

        [TestMethod]
        public void FromCql_NameOnly()
        {
            var si = new StreamInspector();
            using var ss = StringStream("library Foo\n");
            var vi = si.FromCql(ss);
            vi.Should().NotBeNull();
            vi!.id.Should().Be("Foo");
            vi!.version.Should().BeNull();
        }

        [TestMethod]
        public void FromCql_NameAndVersion()
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