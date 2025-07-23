/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Elm;

namespace Hl7.Cql.CqlToElm.Test
{
    [TestClass]
    public class BetweenTest : Base
    {
        [TestMethod]
        public void BetweenIntTrue()
        {
            var lib = CreateCqlToolkit().MakeLibraryFromExpression("4 between 2 and 6");
            var and = lib.Should().BeACorrectlyInitializedLibraryWithStatementOfType<And>();
            and.operand.Should().HaveCount(2);
            var ge = and.operand[0].Should().BeOfType<GreaterOrEqual>().Subject;
            var le = and.operand[1].Should().BeOfType<LessOrEqual>().Subject;
            var result = Run<bool?>(and, lib);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ProperBetweenIntFalse()
        {
            var lib = CreateCqlToolkit().MakeLibraryFromExpression("2 properly between 2 and 6");
            var and = lib.Should().BeACorrectlyInitializedLibraryWithStatementOfType<And>();
            and.operand.Should().HaveCount(2);
            var ge = and.operand[0].Should().BeOfType<Greater>().Subject;
            var le = and.operand[1].Should().BeOfType<Less>().Subject;
            var result = Run<bool?>(and, lib);
            Assert.IsFalse(result);
        }

    }
}

