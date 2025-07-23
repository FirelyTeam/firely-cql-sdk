/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Elm;
using Hl7.Cql.Primitives;

namespace Hl7.Cql.CqlToElm.Test
{
    [TestClass]
    public class InfixSetTest : Base
    {
        [TestMethod]
        public void Interval_Except()
        {
            var library = CreateCqlToolkit().MakeLibraryFromExpression("Interval[1, 10] except Interval[4, 10]");
            var except = library.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Except>();
            var result = Run<CqlInterval<int?>>(except, library);
            result.Should().NotBeNull();
            result!.low.Should().Be(1);
            result.high.Should().Be(3);
            result.lowClosed.Should().BeTrue();
            result.highClosed.Should().BeTrue();
        }

        [TestMethod]
        public void Interval_Union()
        {
            var library = CreateCqlToolkit().MakeLibraryFromExpression("Interval[1, 10] union Interval[4, 15]");
            var union = library.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Union>();
            var result = Run<CqlInterval<int?>>(union, library);
            result.Should().NotBeNull();
            result!.low.Should().Be(1);
            result.high.Should().Be(15);
            result.lowClosed.Should().BeTrue();
            result.highClosed.Should().BeTrue();
        }
        [TestMethod]
        public void Interval_Union_Pipe_Operator()
        {
            var library = CreateCqlToolkit().MakeLibraryFromExpression("Interval[1, 10] | Interval[4, 15]");
            var union = library.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Union>();
            var result = Run<CqlInterval<int?>>(union, library);
            result.Should().NotBeNull();
            result!.low.Should().Be(1);
            result.high.Should().Be(15);
            result.lowClosed.Should().BeTrue();
            result.highClosed.Should().BeTrue();
        }

        [TestMethod]
        public void Interval_Intersect_Operator()
        {
            var library = CreateCqlToolkit().MakeLibraryFromExpression("Interval[1, 5] intersect Interval[3, 7]");
            var intersect = library.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Intersect>();
            var result = Run<CqlInterval<int?>>(intersect, library);
            result.Should().NotBeNull();
            result!.low.Should().Be(3);
            result.high.Should().Be(5);
            result.lowClosed.Should().BeTrue();
            result.highClosed.Should().BeTrue();
        }
    }
}
