using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using System;

namespace Hl7.Cql.Packaging.Tests;

[TestClass]
public class ResourceFileNameTests
{
    [TestMethod]
    public void Create_ValidParameters_ShouldCreateResourceFileName()
    {
        var resourceFileName = ResourceFileName.Create("Type", "Identifier", "1.0.0");
        resourceFileName.Type.Should().Be("Type");
        resourceFileName.Identifier.Should().Be("Identifier");
        resourceFileName.Version.Should().Be("1.0.0");
    }

    [TestMethod]
    public void Create_InvalidType_ShouldThrowArgumentException()
    {
        Action act = () => ResourceFileName.Create("Invalid-Type", "Identifier", "1.0.0");
        act.Should().Throw<ArgumentException>()
           .And.ParamName.Should().Be("type");
    }

    [TestMethod]
    public void Create_InvalidIdentifier_ShouldThrowArgumentException()
    {
        Action act = () => ResourceFileName.Create("Type", "Invalid-Identifier", "1.0.0");
        act.Should().Throw<ArgumentException>()
           .And.ParamName.Should().Be("identifier");
    }

    [TestMethod]
    public void Create_InvalidVersion_ShouldThrowArgumentException()
    {
        Action act = () => ResourceFileName.Create("Type", "Identifier", "1.0.0-Invalid");
        act.Should().Throw<ArgumentException>()
           .And.ParamName.Should().Be("version");
    }

    [TestMethod]
    public void FileName_ShouldReturnCorrectFileName()
    {
        var resourceFileName = ResourceFileName.Create("Type", "Identifier", "1.0.0");
        resourceFileName.FileName.Should().Be("Type-Identifier-1.0.0.json");
    }

    [TestMethod]
    public void FileNameWithoutExtension_ShouldReturnCorrectFileNameWithoutExtension()
    {
        var resourceFileName = ResourceFileName.Create("Type", "Identifier", "1.0.0");
        resourceFileName.FileNameWithoutExtension.Should().Be("Type-Identifier-1.0.0");
    }

    [TestMethod]
    public void ToString_ShouldReturnCorrectStringRepresentation()
    {
        var resourceFileName = ResourceFileName.Create("Type", "Identifier", "1.0.0");
        resourceFileName.ToString().Should().Be("Type-Identifier-1.0.0.json");
    }

    [TestMethod]
    public void Parse_ValidString_ShouldReturnResourceFileName()
    {
        var resourceFileName = ResourceFileName.Parse("Type-Identifier-1.0.0.json", null);
        resourceFileName.Type.Should().Be("Type");
        resourceFileName.Identifier.Should().Be("Identifier");
        resourceFileName.Version.Should().Be("1.0.0");
    }

    [TestMethod]
    public void Parse_InvalidString_ShouldThrowFormatException()
    {
        Action act = () => ResourceFileName.Parse("Invalid-Str_ing", null);
        act.Should().Throw<FormatException>();
    }

    [TestMethod]
    public void TryParse_ValidStringWithExtension_ShouldReturnTrueAndResourceFileName()
    {
        var result = ResourceFileName.TryParse("Type-Identifier-1.0.0.json", null, out var resourceFileName);
        result.Should().BeTrue();
        resourceFileName.Type.Should().Be("Type");
        resourceFileName.Identifier.Should().Be("Identifier");
        resourceFileName.Version.Should().Be("1.0.0");
    }

    [TestMethod]
    public void TryParse_ValidString_ShouldReturnTrueAndResourceFileName()
    {
        var result = ResourceFileName.TryParse("Type-Identifier-1.0.0", null, out var resourceFileName);
        result.Should().BeTrue();
        resourceFileName.Type.Should().Be("Type");
        resourceFileName.Identifier.Should().Be("Identifier");
        resourceFileName.Version.Should().Be("1.0.0");
    }

    [TestMethod]
    public void TryParse_InvalidString_ShouldReturnFalse()
    {
        var result = ResourceFileName.TryParse("Invalid-Str_ing", null, out var resourceFileName);
        result.Should().BeFalse();
        resourceFileName.Should().Be(default(ResourceFileName));
    }
}