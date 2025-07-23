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
    public class IndexTest : Base
    {
        [TestMethod]
        public void LastIndexOf()
        {
            var lib = CreateCqlToolkit().MakeLibraryFromExpression("LastPositionOf('hi', 'Ohio is the place to be!')");
            var lpo = lib.Should().BeACorrectlyInitializedLibraryWithStatementOfType<LastPositionOf>();
            var result = Run<int?>(lpo, lib);
            result.Should().Be(1);
        }

    }
}
