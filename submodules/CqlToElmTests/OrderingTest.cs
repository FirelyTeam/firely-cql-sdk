using FluentAssertions;
using Hl7.Cql.CqlToElm.Scopes;
using Hl7.Cql.CqlToElm.Visitors;
using Hl7.Cql.Elm;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.CqlToElm.Test
{
    [TestClass]
    public class OrderingTest: Base
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
