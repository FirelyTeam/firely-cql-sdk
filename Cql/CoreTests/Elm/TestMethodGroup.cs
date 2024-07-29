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
        var func1 = new FunctionDef { name = "Println", resultTypeName = SystemTypes.IntegerType.TryToQualifiedName() };
        var func2 = new FunctionDef { name = "Println", resultTypeName = SystemTypes.BooleanType.TryToQualifiedName() };

        var mg = new MethodGroup("Println", [func1, func2]);

        mg.GetOverloads([SystemTypes.IntegerType]).Should().BeEquivalentTo([func1]);
        mg.GetOverloads([SystemTypes.BooleanType]).Should().BeEquivalentTo([func2]);
        mg.GetOverloads([SystemTypes.StringType]).Should().BeEquivalentTo<ExpressionDef>([]);
        mg.GetOverloads([]).Should().BeEquivalentTo<ExpressionDef>([]);
    }
}