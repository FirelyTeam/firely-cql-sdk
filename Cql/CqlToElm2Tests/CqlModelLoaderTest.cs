using FluentAssertions;
using Hl7.Cql.Model;
using Hl7.Cql.Model.ModelProviders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CqlToElm2Tests;

[TestClass]
public class CqlModelLoaderTest
{
    [TestMethod]
    public void Load_System200_Model()
    {
        var bip = new BuiltInModelProvider();
        bip.TryGetModel("System", "2.0.0", out var model).Should().BeTrue();
        model!.TypeDefinitions.Count.Should().Be(18);
        model.TypeDefinitions.TryGetValue("Any", out var anyType).Should().BeTrue();
        anyType.Should().BeOfType<SimpleTypeDefinition>();
        model.TypeDefinitions.TryGetValue("Boolean", out var boolType).Should().BeTrue();
        boolType!.BaseType.Should().Be(anyType);

        // test class type and its members
        model.TypeDefinitions.TryGetValue("Quantity", out var quantityType).Should().BeTrue();
        quantityType!.BaseType.Should().Be(anyType);
        var quantityClass = quantityType.Should().BeOfType<ClassTypeDefinition>().Subject;
        quantityClass.Elements.Should().HaveCount(2);
        quantityClass.Elements.ContainsKey("value").Should().BeTrue();
        var valueTypeSpecifier = quantityClass.Elements["value"].Type.Should().BeOfType<NamedTypeSpecifier>().Subject;
        model.TypeDefinitions.TryGetValue("Decimal", out var decimalType).Should().BeTrue();
        valueTypeSpecifier.Type.Should().Be(decimalType);
        quantityClass.Elements.ContainsKey("unit").Should().BeTrue();
        var unitTypeSpecifier = quantityClass.Elements["unit"].Type.Should().BeOfType<NamedTypeSpecifier>().Subject;
        model.TypeDefinitions.TryGetValue("String", out var stringType).Should().BeTrue();
        unitTypeSpecifier.Type.Should().Be(stringType);

        // test generic type and its constraints

        model.TypeDefinitions.TryGetValue("Interval", out var _interval).Should().BeTrue();
        var intervalType = _interval.Should().BeOfType<GenericTypeDefinition>().Subject;
        intervalType.Arguments.Should().HaveCount(1);
        var argSpecifier = intervalType.Arguments[0].Should().BeOfType<GenericArgumentSpecifier>().Subject;
        argSpecifier.Argument.Should().Be("T");
        intervalType.Constraints.Should().HaveCount(1);
        intervalType.Constraints.Should().ContainKey(argSpecifier);
        var intervalChoice = intervalType.Constraints[argSpecifier].Should().BeOfType<ChoiceTypeSpecifier>().Subject;
        intervalChoice.Choices.Should().HaveCount(7);
        intervalType.Elements.ContainsKey("low").Should().BeTrue();
        var intervalLow = intervalType.Elements["low"].Type.Should().BeOfType<GenericArgumentSpecifier>().Subject;
        intervalLow.Argument.Should().Be("T");

    }


}
