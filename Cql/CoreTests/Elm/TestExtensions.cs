using System;
using FluentAssertions;
using Hl7.Cql.Abstractions.Exceptions;
using Hl7.Cql.Elm;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoreTests;

[TestClass]
public class TestExtensions
{
    [TestMethod]
    public void TestGetTypeSpecifier()
    {
        var func = new FunctionDef { name = "Println", resultTypeName = SystemTypes.IntegerType.TryToQualifiedName() };
        func.GetTypeSpecifier().Should().NotBeNull().And.Subject.Equals(SystemTypes.IntegerType).Should().BeTrue();

        func = new FunctionDef { name = "Println2", resultTypeSpecifier = SystemTypes.BooleanType };
        func.GetTypeSpecifier().Should().NotBeNull().And.Subject.Equals(SystemTypes.BooleanType).Should().BeTrue();

        func = new FunctionDef { name = "Println3" };
        func.GetTypeSpecifier().Should().BeNull();

        var od = new OperandDef { name = "param1", resultTypeName = SystemTypes.IntegerType.TryToQualifiedName() };
        od.GetTypeSpecifier().Should().NotBeNull().And.Subject.Equals(SystemTypes.IntegerType).Should().BeTrue();

        od = new OperandDef { name = "param2", resultTypeSpecifier = SystemTypes.BooleanType };
        od.GetTypeSpecifier().Should().NotBeNull().And.Subject.Equals(SystemTypes.BooleanType).Should().BeTrue();

        od = new OperandDef { name = "param3", operandType = SystemTypes.BooleanType.TryToQualifiedName() };
        od.GetTypeSpecifier().Should().NotBeNull().And.Subject.Equals(SystemTypes.BooleanType).Should().BeTrue();

        od = new OperandDef { name = "param3", operandTypeSpecifier = SystemTypes.StringType };
        od.GetTypeSpecifier().Should().NotBeNull().And.Subject.Equals(SystemTypes.StringType).Should().BeTrue();

        od = new OperandDef { name = "param4" };
        od.GetTypeSpecifier().Should().BeNull();
    }

    [TestMethod]
    public void TestExactlyMatchesSignature()
    {
        var testSig = new FunctionDef
        {
            name = "Println",
            resultTypeName = SystemTypes.IntegerType.TryToQualifiedName(),
            operand = [new OperandDef { name = "param1", operandTypeSpecifier = SystemTypes.BooleanType },
                new OperandDef { name = "param2", operandTypeSpecifier = SystemTypes.StringType }]
        }.GetSignature();

        var goodSig = new TypeSpecifier[] { SystemTypes.BooleanType, SystemTypes.StringType };

        testSig.ExactlyMatches(goodSig).Should().BeTrue();

        var wrongSig = new TypeSpecifier[] { SystemTypes.BooleanType, SystemTypes.IntegerType };

        testSig.ExactlyMatches(wrongSig).Should().BeFalse();
        testSig.ExactlyMatches([]).Should().BeFalse();
    }

    [TestMethod]
    public void TestExactlyMatchesSignatureNoParams()
    {
        var testSig = new FunctionDef
        {
            name = "Now",
            resultTypeName = SystemTypes.DateTimeType.TryToQualifiedName(),
        }.GetSignature();

        var goodSig = Array.Empty<TypeSpecifier>();
        testSig.ExactlyMatches(goodSig).Should().BeTrue();

        var wrongSig = new TypeSpecifier[] { SystemTypes.BooleanType, SystemTypes.StringType };

        testSig.ExactlyMatches(wrongSig).Should().BeFalse();
    }
}