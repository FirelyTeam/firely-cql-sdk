using System;
using Hl7.Cql.Packaging;
using Hl7.Fhir.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoreTests.Infrastructure;

[TestClass]
public class ResourceExtensionsTests
{
    [TestMethod]
    public void CanonicalUri_WithValidResourceEndsWithSlash_ReturnsCorrectUri()
    {
        // Arrange
        var resource = new Patient { Id = "123" };
        var resourceCanonicalRootUrl = "https://example.com/api/";

        // Act
        var result = resource.CanonicalUri(resourceCanonicalRootUrl);

        // Assert
        Assert.AreEqual("https://example.com/api/Patient/123", result);
    }

    [TestMethod]
    public void CanonicalUri_WithValidResourceNotEndsWithSlash_ReturnsCorrectUri()
    {
        // Arrange
        var resource = new Patient { Id = "123" };
        var resourceCanonicalRootUrl = "https://example.com/api";

        // Act
        var result = resource.CanonicalUri(resourceCanonicalRootUrl);

        // Assert
        Assert.AreEqual("https://example.com/api/Patient/123", result);
    }

    [TestMethod]

    public void CanonicalUri_WithNullResourceCanonicalRootUrl_ReturnsDefaultUri()
    {
        // Arrange
        var resource = new Patient { Id = "456" };
        string resourceCanonicalRootUrl = null;

        // Act
        var result = resource.CanonicalUri(resourceCanonicalRootUrl);

        // Assert
        Assert.AreEqual("#/Patient/456", result);
    }

    [TestMethod]

    public void CanonicalUri_WithEmptyResource_ThrowsArgumentException()
    {
        // Arrange
        var resource = new Patient { Id = "" };
        var resourceCanonicalRootUrl = "https://example.com/api/";

        // Act & Assert
        Assert.ThrowsException<ArgumentException>(() => resource.CanonicalUri(resourceCanonicalRootUrl));
    }

    [TestMethod]
    public void CanonicalUri_WithWhitespaceResourceId_ThrowsArgumentException()
    {
        // Arrange
        var resource = new Patient { Id = "   " };
        var resourceCanonicalRootUrl = "https://example.com/api/";

        // Act & Assert
        Assert.ThrowsException<ArgumentException>(() => resource.CanonicalUri(resourceCanonicalRootUrl));
    }
}