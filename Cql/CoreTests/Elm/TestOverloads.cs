using FluentAssertions;
using Hl7.Cql.Compiler;
using Hl7.Cql.Elm;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoreTests;

[TestClass]
public class TestOverloads
{
    [TestMethod]
    public void SelectMethodOne()
    {
        var func1 = new FunctionDef { name = "Println", operand = [new OperandDef { name = "param1", operandType = SystemTypes.IntegerType.TryToQualifiedName() }] };
        var func2 = new FunctionDef { name = "Println", operand = [new OperandDef { name = "param1", operandTypeSpecifier = SystemTypes.BooleanType }] };

        var mg = OverloadedFunctionDef.Create([func1, func2]);

        mg.FilterOverloads([SystemTypes.IntegerType]).Should().BeEquivalentTo([func1]);
        mg.FilterOverloads([SystemTypes.BooleanType]).Should().BeEquivalentTo([func2]);
        mg.FilterOverloads([SystemTypes.StringType]).Should().BeEquivalentTo<ExpressionDef>([]);
        mg.FilterOverloads([]).Should().BeEquivalentTo<ExpressionDef>([]);
    }

    [TestMethod]
    public void SelectMethodAmbiguous()
    {
        var func1 = new FunctionDef { name = "Println", operand = [new OperandDef { name = "param1", operandType = SystemTypes.IntegerType.TryToQualifiedName() }] };
        var func2 = new FunctionDef { name = "Println", operand = [new OperandDef { name = "param1", operandTypeSpecifier = SystemTypes.IntegerType }] };

        var mg = OverloadedFunctionDef.Create([func1, func2]);

        mg.FilterOverloads([SystemTypes.IntegerType]).Should().HaveCount(2);
    }

    [TestMethod]
    public void SelectMethodNoMatch()
    {
        var func1 = new FunctionDef { name = "Println", operand = [new OperandDef { name = "param1", operandType = SystemTypes.IntegerType.TryToQualifiedName() }] };
        var func2 = new FunctionDef { name = "Println", operand = [new OperandDef { name = "param1", operandTypeSpecifier = SystemTypes.BooleanType }] };

        var mg = OverloadedFunctionDef.Create([func1, func2]);

        mg.FilterOverloads([SystemTypes.StringType]).Should().BeEquivalentTo<ExpressionDef>([]);
    }
}