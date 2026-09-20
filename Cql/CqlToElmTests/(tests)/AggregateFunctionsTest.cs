/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable

using Hl7.Cql.Elm;

namespace Hl7.Cql.CqlToElm.Test
{
    [TestClass]
    public class AggregateFunctionsTest : Base
    {
        [TestMethod]
        public void GeometricMean_SpecExample()
        {
            // Spec: GeometricMean(X) = Power(Product(X), 1 / Count(X)), so GeometricMean({2.0, 8.0}) is 4.0.
            var library = CreateCqlToolkit().MakeLibraryFromExpression("GeometricMean({ 2.0, 8.0 })");
            var expr = library.Should().BeACorrectlyInitializedLibraryWithStatementOfType<GeometricMean>();
            Run<decimal?>(expr, library).Should().Be(4.0m);
        }

        [TestMethod]
        public void GeometricMean_NullSourceIsNull()
        {
            var library = CreateCqlToolkit().MakeLibraryFromExpression("GeometricMean(null as List<Decimal>)");
            var expr = library.Should().BeACorrectlyInitializedLibraryWithStatementOfType<GeometricMean>();
            Run<decimal?>(expr, library).Should().BeNull();
        }

        [TestMethod]
        public void Count_NullSourceIsZero()
        {
            // Spec: "If the list is null, the result is 0", illustrated by CountNull0.
            var library = CreateCqlToolkit().MakeLibraryFromExpression("Count(null as List<Integer>)");
            var expr = library.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Count>();
            Run<int?>(expr, library).Should().Be(0);
        }

        [TestMethod]
        public void Count_AllNullElementsIsZero()
        {
            var library = CreateCqlToolkit().MakeLibraryFromExpression("Count({ null, null, null })");
            var expr = library.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Count>();
            Run<int?>(expr, library).Should().Be(0);
        }

        [TestMethod]
        public void Count_CountsNonNullElements()
        {
            var library = CreateCqlToolkit().MakeLibraryFromExpression("Count({ 1, 2, 3, 4, 5 })");
            var expr = library.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Count>();
            Run<int?>(expr, library).Should().Be(5);
        }
    }
}
