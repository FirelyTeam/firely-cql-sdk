/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions.Infrastructure;

namespace CoreTests.Abstractions;

[TestClass]
[TestCategory("UnitTest")]
public class ReflectionUtilityTests
{
    [TestMethod]
    public void GenericMethodDefinitionOf_NonGenericMethod_ThrowsNamingTheExpression()
    {
        Action act = () => ReflectionUtility.GenericMethodDefinitionOf(() => string.Empty.Trim());

        act.Should().ThrowExactly<InvalidOperationException>()
           .WithMessage("Expression is not a generic method: '() => string.Empty.Trim()'.");
    }
}
