/*
 * Copyright (c) 2025, Firely and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Elm;

namespace Hl7.Cql.CqlToElm.Test
{
    [TestClass]
    public class OrderingTest : Base
    {
        [TestMethod]
        public void Order_Simple()
        {
            var lib = CreateCqlToolkit().MakeLibrary("""
                library Test version '1.0.0'                define a: b
                                define b: true
                """);
            lib.statements.Should().HaveCount(2);
            lib.statements[0].Should().HaveType(SystemTypes.BooleanType);
            lib.statements[1].Should().HaveType(SystemTypes.BooleanType);
        }

        [TestMethod]
        public void Order_Indirection_2()
        {
            var lib = CreateCqlToolkit().MakeLibrary("""
                library Test version '1.0.0'                define a: b
                                define b: c
                                define c: true
                """);
            lib.statements.Should().HaveCount(3);
            lib.statements[0].Should().HaveType(SystemTypes.BooleanType);
            lib.statements[1].Should().HaveType(SystemTypes.BooleanType);
            lib.statements[2].Should().HaveType(SystemTypes.BooleanType);
        }

        [TestMethod]
        public void Function_Simple()
        {
            var lib = CreateCqlToolkit().MakeLibrary("""
                library Test version '1.0.0'                define a: b()
                                define function b(): true
                """);
            lib.statements.Should().HaveCount(2);
            lib.statements[0].Should().HaveType(SystemTypes.BooleanType);
            lib.statements[1].Should().HaveType(SystemTypes.BooleanType);
        }
        [TestMethod]
        public void Function_Indirection_2()
        {
            var lib = CreateCqlToolkit().MakeLibrary("""
                library Test version '1.0.0'                define a: b()
                                define function b(): c()
                                define function c(): true
                """);
            lib.statements.Should().HaveCount(3);
            lib.statements[0].Should().HaveType(SystemTypes.BooleanType);
            lib.statements[1].Should().HaveType(SystemTypes.BooleanType);
            lib.statements[2].Should().HaveType(SystemTypes.BooleanType);
        }
    }
}
