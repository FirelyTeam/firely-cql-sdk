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

    [DataRow("RootUrl", null, "RootUrl/Library/Identifier")]
    [DataRow("RootUrl", "", "RootUrl/Library/Identifier")]
    [DataRow("RootUrl", "Version", "RootUrl/Library/Identifier|Version")]
    public void BuildCanonical_ShouldReturnValidCanonical_WhenCreatedWithRootedUrl(
        string rootCanonical,
        string? version,
        string expectedCanonical)
    {
        // Arrange
        var resourceCanonicalBuilder = ResourceCanonicalBuilderFactory.Create(rootCanonical);

        // Act
        var canonical = resourceCanonicalBuilder("Library", "Identifier", version);

        // Assert
        canonical.Should().Be(expectedCanonical);
    }
}