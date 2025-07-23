/*
 * Copyright (c) 2025, Firely and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Packaging;
using Hl7.Fhir.Model;
using System.Diagnostics;

namespace CoreTests.Infrastructure;

[TestClass]
public class ResourceExtensionsTests
{
    // No need to add more tests. See ResourceFileNameTests.cs for more tests.
    [TestMethod]
    public void GetResourceFileName_WithNonLibraryOrMeasure_ThrowsUnreachableException()
    {
        // Arrange
        var resource = new Patient();

        // Act & Assert
        Assert.ThrowsException<UnreachableException>(() => resource.GetResourceFileName());
    }
}
