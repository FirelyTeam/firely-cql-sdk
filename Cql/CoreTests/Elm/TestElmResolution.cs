using System;
using System.IO;
using FluentAssertions;
using Hl7.Cql.Abstractions.Exceptions;
using Hl7.Cql.Compiler;
using Hl7.Cql.Elm;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoreTests;

[TestClass]
public class TestElmResolution
{
    [TestMethod]
    public void TestResolveUsing()
    {
        // Arrange
        var (lset, main) = LoadTestLibrarySet();

        // Act
        lset.TryResolveDefinition<IncludeDef>(main!, "test", null, out var def).Should().BeTrue();
        def.Should().NotBeNull();
        def!.libraryName.Should().Be("test");
        def.path.Should().Be("TestRetrieveInclude");

        lset.TryResolveDefinition<IncludeDef>(main!, "testX", null, out var _).Should().BeFalse();
    }

    private static (LibrarySet,Library) LoadTestLibrarySet()
    {
        var lset = new LibrarySet();
        lset.LoadLibraryAndDependencies(new DirectoryInfo("Input/ELM/HL7"), "TestRetrieve" );
        var main = lset.GetLibrary("TestRetrieve-1.0.1");
        return (lset, main);
    }

    [TestMethod]
    public void TestResolveValueSet()
    {
        // Arrange
        var (lset, main) = LoadTestLibrarySet();

        // Act
        lset.TryResolveDefinition<ValueSetDef>(main!, "Pregnancy Test", null, out var def).Should().BeTrue();
        def.Should().NotBeNull();
        def!.name.Should().Be("Pregnancy Test");
        def.id.Should().Be("2.16.840.1.113883.3.464.1003.111.12.1011");

        lset.TryResolveDefinition<ValueSetDef>(main!, "Xlamydia", null, out var _).Should().BeFalse();
        lset.TryResolveDefinition<ValueSetDef>(main!, "Pregnancy Test", "test", out var _).Should().BeFalse();
    }

    [TestMethod]
    public void TestResolveQualifiedValueSet()
    {
        // Arrange
        var (lset, main) = LoadTestLibrarySet();

        // Act
        lset.TryResolveDefinition<ValueSetDef>(main!, "Chlamydia", "test", out var def).Should().BeTrue();
        def.Should().NotBeNull();
        def!.name.Should().Be("Chlamydia");
        def.id.Should().Be("2.16.840.1.113883.3.464.1003.112.12.1003");

        lset.TryResolveDefinition<ValueSetDef>(main!, "Xlamydia", "test", out var _).Should().BeFalse();
    }

    [TestMethod]
    public void CreateOverloadedDefs()
    {
        var lib = new Library
        {
            identifier = new VersionedIdentifier { id = "Test", version = "1.0.0" },
            statements =
            [
                new FunctionDef
                {
                    name = "Println",
                    operand = [ new OperandDef { name = "param1", operandTypeSpecifier = SystemTypes.IntegerType } ]
                },
                new FunctionDef
                {
                    name = "Println",
                    operand = [ new OperandDef { name = "param1", operandTypeSpecifier = SystemTypes.BooleanType } ]
                }
            ]
        };

        var libset = new LibrarySet(name: "Test", lib);

        libset.TryResolveDefinition(lib, "Println", null, out IFunctionElement def).Should().BeTrue();
        var group = def.Should().BeOfType<OverloadedFunctionDef>().Subject;
        group.Functions.Should().HaveCount(2);
    }

    [TestMethod]
    public void NoDuplicates()
    {
        var lib = new Library
        {
            identifier = new VersionedIdentifier { id = "Test", version = "1.0.0" },
            codes =
            [
                new CodeDef { name = "NL" },
                new CodeDef { name = "NL" },
            ]
        };

        var libset = new LibrarySet(name: "Test", lib);

        Assert.ThrowsException<CqlException<LibraryHasDuplicateDefinition>>(() => libset.TryResolveDefinition(lib, "NL", null, out CodeDef _));
    }
}