using FluentAssertions;
using Hl7.Cql.Elm;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hl7.Cql.CqlToElm.Test
{
    [TestClass]
    public class OrderingTest : Base
    {
        [ClassInitialize]
#pragma warning disable IDE0060 // Remove unused parameter
        public static void Initialize(TestContext context) => ClassInitialize();
#pragma warning restore IDE0060 // Remove unused parameter

        [TestMethod]
        public void Order_Simple()
        {
            var lib = MakeLibrary(@"library Test version '1.0.0'
                define a: b
                define b: true
                ");
            lib.statements.Should().HaveCount(2);
            lib.statements[0].Should().HaveType(SystemTypes.BooleanType);
            lib.statements[1].Should().HaveType(SystemTypes.BooleanType);
        }

        [TestMethod]
        public void Order_Indirection_2()
        {
            var lib = MakeLibrary(@"library Test version '1.0.0'
                define a: b
                define b: c
                define c: true
                ");
            lib.statements.Should().HaveCount(3);
            lib.statements[0].Should().HaveType(SystemTypes.BooleanType);
            lib.statements[1].Should().HaveType(SystemTypes.BooleanType);
            lib.statements[2].Should().HaveType(SystemTypes.BooleanType);
        }

        [TestMethod]
        public void Function_Simple()
        {
            var lib = MakeLibrary(@"library Test version '1.0.0'
                define a: b()
                define function b(): true
                ");
            lib.statements.Should().HaveCount(2);
            lib.statements[0].Should().HaveType(SystemTypes.BooleanType);
            lib.statements[1].Should().HaveType(SystemTypes.BooleanType);
        }
        [TestMethod]
        public void Function_Indirection_2()
        {
            var lib = MakeLibrary(@"library Test version '1.0.0'
                define a: b()
                define function b(): c()
                define function c(): true
                ");
            lib.statements.Should().HaveCount(3);
            lib.statements[0].Should().HaveType(SystemTypes.BooleanType);
            lib.statements[1].Should().HaveType(SystemTypes.BooleanType);
            lib.statements[2].Should().HaveType(SystemTypes.BooleanType);
        }
    }
}
