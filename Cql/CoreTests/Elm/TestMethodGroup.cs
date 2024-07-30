using FluentAssertions;
using Hl7.Cql.Compiler;
using Hl7.Cql.Elm;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoreTests;

[TestClass]
public class TestMethodGroup
{
    [TestMethod]
    public void SelectMethodOne()
    {
        var func1 = new FunctionDef { name = "Println", operand = [new OperandDef { name = "param1", operandType = SystemTypes.IntegerType.TryToQualifiedName() }] };
        var func2 = new FunctionDef { name = "Println", operand = [new OperandDef { name = "param1", operandTypeSpecifier = SystemTypes.BooleanType }] };

        var mg = new MethodGroup("Println", [func1, func2]);

        mg.GetOverloads([SystemTypes.IntegerType]).Should().BeEquivalentTo([func1]);
        mg.GetOverloads([SystemTypes.BooleanType]).Should().BeEquivalentTo([func2]);
        mg.GetOverloads([SystemTypes.StringType]).Should().BeEquivalentTo<ExpressionDef>([]);
        mg.GetOverloads([]).Should().BeEquivalentTo<ExpressionDef>([]);
    }

    [TestMethod]
    public void SelectMethodAmbiguous()
    {
        var func1 = new FunctionDef { name = "Println", operand = [new OperandDef { name = "param1", operandType = SystemTypes.IntegerType.TryToQualifiedName() }] };
        var func2 = new FunctionDef { name = "Println", operand = [new OperandDef { name = "param1", operandTypeSpecifier = SystemTypes.IntegerType }] };

        var mg = new MethodGroup("Println", [func1, func2]);

        mg.GetOverloads([SystemTypes.IntegerType]).Should().HaveCount(2);
    }

    [TestMethod]
    public void SelectMethodNoMatch()
    {
        var func1 = new FunctionDef { name = "Println", operand = [new OperandDef { name = "param1", operandType = SystemTypes.IntegerType.TryToQualifiedName() }] };
        var func2 = new FunctionDef { name = "Println", operand = [new OperandDef { name = "param1", operandTypeSpecifier = SystemTypes.BooleanType }] };

        var mg = new MethodGroup("Println", [func1, func2]);

        mg.GetOverloads([SystemTypes.StringType]).Should().BeEquivalentTo<ExpressionDef>([]);
    }

    [TestMethod]
    public void SelectFunctionAndDefinition()
    {
        var func1 = new FunctionDef { name = "Println", operand = [new OperandDef { name = "param1", operandTypeSpecifier = SystemTypes.IntegerType }] };
        var func2 = new ExpressionDef { name = "Println" };

        var mg = new MethodGroup("Println", [func1, func2]);

        mg.GetOverloads([SystemTypes.IntegerType]).Should().BeEquivalentTo<ExpressionDef>([func1]);
        mg.GetOverloads([]).Should().BeEquivalentTo([func2]);
    }

    [TestMethod]
    public void SelectFunctionAndDefinitionAmbiguous()
    {
        var func1 = new FunctionDef { name = "Println", operand = [] };
        var func2 = new ExpressionDef { name = "Println" };

        var mg = new MethodGroup("Println", [func1, func2]);

        mg.GetOverloads([]).Should().HaveCount(2);
    }
}