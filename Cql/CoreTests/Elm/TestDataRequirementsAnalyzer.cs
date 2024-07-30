using System.Collections.Generic;
using System.IO;
using System.Linq;
using FluentAssertions;
using Hl7.Cql.Compiler;
using Hl7.Cql.Elm;
using Hl7.Cql.Packaging;
using Hl7.Fhir.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Library = Hl7.Cql.Elm.Library;

namespace CoreTests;

[TestClass]
public class TestElmPreprocessor()
{
    // To check:
    // * No signature, but also no overloads
    // * Overloads, with a signature
    // * Overloads, no signature, but matches types of operands

    [TestMethod]
    public void TestAddResultTypeSpecifierNoSignatureNeeded()
    {
        var lib = ProcessWithFunctions(
            [
                new FunctionDef { name = "add", resultTypeSpecifier = SystemTypes.IntegerType,
                    expression = new Add { operand = [new FunctionRef { name ="getNumA" }, new FunctionRef { name = "getNumA" }] } },
                new FunctionDef { name = "getNumA", resultTypeSpecifier = SystemTypes.IntegerType },
            ]
        );

        // Assert
        var addExpression = lib.statements.Select(s => s as FunctionDef).Single(fd => fd?.name == "add")
                               .expression.Should().BeOfType<Add>().Subject;
        addExpression.operand[0].GetTypeSpecifier().Should().Be(SystemTypes.IntegerType);
        addExpression.operand[1].GetTypeSpecifier().Should().Be(SystemTypes.IntegerType);
    }

    private FunctionDef _getNumADefInt = new()
    {
        name = "getNumA",
        operand = [new OperandDef { name = "param1", operandTypeSpecifier = SystemTypes.IntegerType }],
        resultTypeSpecifier = SystemTypes.IntegerType
    };

    private FunctionDef _getNumADefBool = new()
    {
        name = "getNumA",
        operand = [new OperandDef { name = "param1", operandTypeSpecifier = SystemTypes.BooleanType }],
        resultTypeSpecifier = SystemTypes.BooleanType
    };

    [TestMethod]
    public void TestAddResultTypeSpecifierWithSignature()
    {
        var lib = ProcessWithFunctions(
            [
                new FunctionDef { name = "add", resultTypeName = SystemTypes.IntegerType.TryToQualifiedName(),
                    expression = new Add { operand = [new FunctionRef { name ="getNumA", signature = [SystemTypes.IntegerType]}, new FunctionRef { name = "getNumA", signature = [SystemTypes.BooleanType] }] } },
                _getNumADefInt, _getNumADefBool
            ]
        );

        // Assert
        var addExpression = lib.statements.Select(s => s as FunctionDef).Single(fd => fd?.name == "add")
                               .expression.Should().BeOfType<Add>().Subject;
        addExpression.operand[0].GetTypeSpecifier().Should().Be(SystemTypes.IntegerType);
        addExpression.operand[1].GetTypeSpecifier().Should().Be(SystemTypes.BooleanType);
    }


    [TestMethod]
    public void TestAddResultTypeSpecifierWithoutSignature()
    {
        var lib = ProcessWithFunctions(
            [
                new FunctionDef { name = "add", resultTypeName = SystemTypes.IntegerType.TryToQualifiedName(),
                    expression = new Add { operand =
                        [
                            new FunctionRef { name ="getNumA", operand = [new Literal { resultTypeSpecifier = SystemTypes.IntegerType } ]},
                            new FunctionRef { name ="getNumA", operand = [new Literal { resultTypeSpecifier = SystemTypes.BooleanType } ]}
                        ]}},
                _getNumADefInt, _getNumADefBool
            ]
        );

        // Assert
        var addExpression = lib.statements.Select(s => s as FunctionDef).Single(fd => fd?.name == "add")
                               .expression.Should().BeOfType<Add>().Subject;
        addExpression.operand[0].GetTypeSpecifier().Should().Be(SystemTypes.IntegerType);
        addExpression.operand[1].GetTypeSpecifier().Should().Be(SystemTypes.BooleanType);
    }

    private static Library ProcessWithFunctions(IEnumerable<ExpressionDef> defs)
    {
        var lib = new Library
        {
            identifier = new VersionedIdentifier { id = "Test", version = "1.0.0" },
            statements = defs.ToArray()
        };

        var lset = new LibrarySet(name: "test", lib);

        ElmPreprocessor.Process(lib, lset);
        return lib;
    }
}


[TestClass]
public class TestDataRequirementsAnalyzer
{
    private static (LibrarySet,Library) LoadTestLibrarySet()
    {
        var lset = new LibrarySet();
        lset.LoadLibraryAndDependencies(new DirectoryInfo("Input/ELM/HL7"), "TestRetrieve" );
        var main = lset.GetLibrary("TestRetrieve-1.0.1");
        return (lset, main);
    }


    [TestMethod]
    public void ConvertRetrievesToDataRequirements()
    {
        // Arrange
        var (lset, main) = LoadTestLibrarySet();

        // Act
        var analyzer = new DataRequirementsAnalyzer(lset,main);
        var dataRequirements = analyzer.Analyze();

        // Assert
        dataRequirements.Select(dr => dr.Type).Distinct().Should()
                        .BeEquivalentTo([
                            FHIRAllTypes.Patient, FHIRAllTypes.DiagnosticReport,
                            FHIRAllTypes.Condition, FHIRAllTypes.ServiceRequest
                        ]);
    }
}