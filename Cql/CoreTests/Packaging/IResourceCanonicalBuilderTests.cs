#nullable enable

using Hl7.Cql.Packaging;

namespace CoreTests.Packaging;

[TestClass]
public class ResourceCanonicalBuilderTests
{
    [TestMethod]
    [DataRow("", null, "/Library/Identifier")]
    [DataRow("", "", "/Library/Identifier")]
    [DataRow("", "Version", "/Library/Identifier|Version")]
    public void BuildCanonical_ShouldReturnValidCanonical(
        string rootCanonical,
        string? version,
        string expectedCanonical)
    {
        // Arrange
        var rb = new ResourceCanonicalBuilder(rootCanonical);

        // Act
        var canonical = rb.BuildCanonical("Library", "Identifier", version);

        // Assert
        canonical.Should().Be(expectedCanonical);
    }
}