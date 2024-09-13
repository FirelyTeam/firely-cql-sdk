using Hl7.Cql.Compiler;
using Hl7.Fhir.Model;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoreTests;

[TestClass]
public class ExpressionBuilderContextTests
{

    [TestMethod]
    public void Get_Property_Uses_TypeResolver()
    {
        using var serviceProvider = new ServiceCollection()
                                    .AddDebugLogging()
                                    .AddCqlCompilerServices()
                                    .BuildServiceProvider(validateScopes: true);
        var property = ExpressionBuilderContext.GetProperty(typeof(MeasureReport.PopulationComponent), "id", serviceProvider.GetTypeResolver())!;
        Assert.AreEqual(typeof(Element), property.DeclaringType);
        Assert.AreEqual(nameof(Element.ElementId), property.Name);
    }
}