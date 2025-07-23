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
    public class LengthTest : Base
    {
        [TestMethod]
        public void LengthNullString()
        {
            var library = CreateCqlToolkit().MakeLibraryFromExpression("Length(null as String)");
            var length = library.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Length>();
            var result = Run<int?>(length, library);
            result.Should().BeNull();
        }
    }
}
