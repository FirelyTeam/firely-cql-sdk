/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Runtime;

namespace CoreTests.Packaging;

[TestClass]
public class CqlLibraryIdentifierTest
{
    [TestMethod]
    // Matches the IComparable.CompareTo(Object) convention used throughout the BCL (e.g.
    // Int32, String): a null argument should be treated as preceding any instance and return
    // a positive number, not throw.
    public void CompareTo_Null_ReturnsPositive_DoesNotThrow()
    {
        IComparable id = CqlLibraryIdentifier.NewVerbatim("foo");
        id.CompareTo(null).Should().BePositive();
    }

    [TestMethod]
    public void CompareTo_WrongType_StillThrowsArgumentException()
    {
        IComparable id = CqlLibraryIdentifier.NewVerbatim("foo");
        var act = () => id.CompareTo("not a CqlLibraryIdentifier");
        act.Should().Throw<ArgumentException>();
    }
}
