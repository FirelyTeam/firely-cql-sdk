using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Hl7.Cql.Compiler;
using Hl7.Cql.Elm;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoreTests;

[TestClass]
public class TestElmPreprocessor()
{
    [TestMethod]
    public void TestAddResultTypeSpecifierNoSignatureNeeded()
    {
        var lib = ProcessWithStatements(
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

    private readonly FunctionDef _getNumADefInt = new()
    {
        name = "getNumA",
        operand = [new OperandDef { name = "param1", operandTypeSpecifier = SystemTypes.IntegerType }],
        resultTypeSpecifier = SystemTypes.IntegerType
    };

    private readonly FunctionDef _getNumADefBool = new()
    {
        name = "getNumA",
        operand = [new OperandDef { name = "param1", operandTypeSpecifier = SystemTypes.BooleanType }],
        resultTypeSpecifier = SystemTypes.BooleanType
    };

    [TestMethod]
    public void TestAddResultTypeSpecifierWithSignature()
    {
        var lib = ProcessWithStatements(
            [
                new FunctionDef { name = "add", resultTypeName = SystemTypes.IntegerType.TryToQualifiedName(),
                    expression = new Add
                    {
                        operand =
                        [
                            new FunctionRef { name = "getNumA", signature = [SystemTypes.IntegerType] },
                            new FunctionRef { name = "getNumA", signature = [SystemTypes.BooleanType] }
                        ]
                    }
                },
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
        var lib = ProcessWithStatements(
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


    [TestMethod]
    public void TestAddResultTypeSpecifierWithDefinition()
    {
        var lib = ProcessWithStatements(
            [
                new FunctionDef { name = "add", resultTypeSpecifier = SystemTypes.IntegerType,
                    expression = new Add
                    {
                        operand =
                        [
                            new ExpressionRef { name = "getNumA" },
                            new ExpressionRef { name = "getNumA" }
                        ]
                    }
                },
                new ExpressionDef { name = "getNumA", resultTypeSpecifier = SystemTypes.IntegerType },
            ]
        );

        // Assert
        var addExpression = lib.statements.Select(s => s as FunctionDef).Single(fd => fd?.name == "add")
                               .expression.Should().BeOfType<Add>().Subject;
        addExpression.operand[0].GetTypeSpecifier().Should().Be(SystemTypes.IntegerType);
        addExpression.operand[1].GetTypeSpecifier().Should().Be(SystemTypes.IntegerType);
    }

    [TestMethod]
    public void TestAmbiguousOverloadsFix()
    {
        var lib = ProcessWithStatements(
            [
                new FunctionDef { name = "next", resultTypeSpecifier = SystemTypes.IntegerType,
                   operand = [new OperandDef { name = "p", operandTypeSpecifier = SystemTypes.IntegerType }],
                },
                new FunctionDef { name = "next", resultTypeSpecifier = SystemTypes.LongType,
                    operand = [new OperandDef { name = "p", operandTypeSpecifier = SystemTypes.LongType }],
                },
                new FunctionDef { name = "next", resultTypeSpecifier = SystemTypes.IntegerType,
                    operand = [new OperandDef { name = "p", operandTypeSpecifier = SystemTypes.IntegerType }],
                },
            ]
        );

        // Assert
        var overloadsFixer = new AmbiguousOverloadCorrector();
        overloadsFixer.Fix(lib);

        lib.statements.Select(s => s as FunctionDef).Where(fd => fd?.name == "next")
                               .Should().HaveCount(2);
    }

    private static Library ProcessWithStatements(IEnumerable<ExpressionDef> defs)
    {
        var lib = new Library
        {
            identifier = new VersionedIdentifier { id = "Test", version = "1.0.0" },
            statements = defs.ToArray()
        };

        var lset = new LibrarySet(name: "test", lib);

        var preprocessor = new ElmPreprocessor(lset);
        preprocessor.Preprocess(lib);
        return lib;
    }
}