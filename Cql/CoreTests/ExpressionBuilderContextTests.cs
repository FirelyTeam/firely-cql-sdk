using CqlSdkPrototype.Elm.Internal;
using Hl7.Cql.Abstractions;
using Hl7.Cql.Compiler;
using Hl7.Cql.Runtime.Hosting;
using Hl7.Fhir.Model;

namespace CoreTests;

[TestClass]
public class ExpressionBuilderContextTests
{

    [TestMethod]
    public void Get_Property_Uses_TypeResolver()
    {
        using var serviceProvider = ElmToAssemblyServices.AddCqlCompilerServices(new ServiceCollection().AddDebugLogging()).BuildServiceProvider(validateScopes: true);
        var property = ExpressionBuilderContext.GetProperty(typeof(MeasureReport.PopulationComponent), "id", serviceProvider.GetRequiredService<TypeResolver>())!;
        Assert.AreEqual(typeof(Element), property.DeclaringType);
        Assert.AreEqual(nameof(Element.ElementId), property.Name);
    }
}