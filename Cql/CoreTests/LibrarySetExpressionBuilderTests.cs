using Hl7.Cql.Abstractions;
using Hl7.Cql.CodeGeneration.NET.Toolkit.Internal;
using Hl7.Cql.Compiler;
using Hl7.Cql.Operators;
using Hl7.Cql.Primitives;
using Hl7.Cql.Runtime;
using Hl7.Cql.Runtime.Hosting;

namespace CoreTests;

using TypeConverter = Hl7.Cql.Conversion.TypeConverter;


[TestClass]
public class LibrarySetExpressionBuilderTests
{
    [TestMethod]
    public void LoadLibraryAndDependencies_CrossLibraryCodeSystems()
    {
        var serviceProvider = ElmToolkitServices.AddCqlCompilerServices(new ServiceCollection().AddDebugLogging()).BuildServiceProvider(validateScopes: true);
        using var servicesScope = serviceProvider.CreateScope();
        LibrarySet librarySet = new();
        librarySet.LoadLibraryAndDependencies(LibrarySetsDirs.Cms.ElmDir, "CumulativeMedicationDuration");

        var librarySetExpressionBuilder = servicesScope.ServiceProvider.GetRequiredService<LibrarySetExpressionBuilder>();
        var librarySetDefinitions = librarySetExpressionBuilder.ProcessLibrarySet(librarySet);
        var lambdaExpression = librarySetDefinitions["CumulativeMedicationDuration-4.1.000", "Every eight hours (qualifier value)"];
        Assert.IsNotNull(lambdaExpression);

        var del = lambdaExpression.Compile(true);
        var cqlContext = new CqlContext(CqlOperators.Create(serviceProvider.GetRequiredService<TypeResolver>(), serviceProvider.GetRequiredService<TypeConverter>()));
        var res = (CqlCode)del.DynamicInvoke(cqlContext);
        Assert.AreEqual(("307469008", "http://snomed.info/sct"), (res.code, res.system));
    }
}