/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Elm;

namespace Hl7.Cql.CqlToElm.Test
{
    /// <summary>
    /// <c>GeometricMean(argument List&lt;Decimal&gt;) Decimal</c> (§9.B GeometricMean): the Nth root of the product of
    /// the non-null elements; null when the source is null or has no non-null elements.
    /// </summary>
    [TestClass]
    public class GeometricMeanTest : Base
    {
        [TestMethod]
        [DataRow("GeometricMean({ 2.0, 8.0 })", 4.0)]
        [DataRow("GeometricMean({ 2.0, null, 8.0 })", 4.0)]
        public void GeometricMean_IsTheRootOfTheProduct(string cql, double expected)
        {
            var library = CreateCqlToolkit().MakeLibraryFromExpression(cql);
            var geometricMean = library.Should().BeACorrectlyInitializedLibraryWithStatementOfType<GeometricMean>();
            var result = Run<decimal?>(geometricMean, library);
            result.Should().Be((decimal)expected);
        }

        [TestMethod]
        [DataRow("GeometricMean({ null as Decimal, null as Decimal })")]
        [DataRow("GeometricMean(null as List<Decimal>)")]
        public void GeometricMean_WithoutNonNullElements_IsNull(string cql)
        {
            var library = CreateCqlToolkit().MakeLibraryFromExpression(cql);
            var geometricMean = library.Should().BeACorrectlyInitializedLibraryWithStatementOfType<GeometricMean>();
            var result = Run<decimal?>(geometricMean, library);
            result.Should().BeNull();
        }
    }
}
