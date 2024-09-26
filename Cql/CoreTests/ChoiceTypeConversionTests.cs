#nullable enable
using System.Diagnostics;
using FluentAssertions;
using Hl7.Cql.Fhir;
using Hl7.Cql.Runtime;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoreTests;

[TestClass]
public class ChoiceTypeConversionTests
{
    private static CqlContext GetNewContext() => FhirCqlContext.WithDataSource();

    [TestMethod]
    public void ChoiceTypeConversionTest_1_0_0_ReturnDateAsChoiceInRangeMustBeTrue_MustReturnTrue()
    {
        // Arrange
        var rtx = GetNewContext();
        var choiceTypeConversionTest = new ChoiceTypeConversionTest_1_0_0(rtx);

        // Act
        var result = choiceTypeConversionTest.ReturnDateAsChoiceInRangeMustBeTrue();

        // Assert
        result.Should().BeTrue();
    }

    [TestMethod]
    public void ChoiceTypeConversionTest_1_0_0_ReturnDateAsChoiceOutOfRangeMustBeFalse_MustReturnFalse()
    {
        // Arrange
        var rtx = GetNewContext();
        var choiceTypeConversionTest = new ChoiceTypeConversionTest_1_0_0(rtx);

        // Act
        var result = choiceTypeConversionTest.ReturnDateAsChoiceOutOfRangeMustBeFalse();

        // Assert
        result.Should().BeFalse();
    }

    [TestMethod]
    public void ChoiceTypeConversionTest_1_0_0_ReturnStringAsChoiceInRangeMustBeNull_MustThrowUnreachableException()
    {
        // Arrange
        var rtx = GetNewContext();
        var choiceTypeConversionTest = new ChoiceTypeConversionTest_1_0_0(rtx);

        // Act
        var act = () => choiceTypeConversionTest.ReturnStringAsChoiceInRangeMustBeNull();

        // Assert
        act.Should().Throw<UnreachableException>();
    }
}