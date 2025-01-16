using CqlSdkPrototype.Elm;
using Hl7.Cql.Abstractions;
using Hl7.Cql.Compiler;
using Hl7.Cql.Conversion;
using Hl7.Cql.Primitives;
using Hl7.Cql.Runtime;
using Hl7.Cql.Runtime.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoreTests;

[TestClass]
public class LibrarySetExpressionBuilderTests
{
    [TestMethod]
    public void LoadLibraryAndDependencies_CrossLibraryCodeSystems()
    {
        var serviceProvider = ElmApiState.AddCqlCompilerServices(new ServiceCollection().AddDebugLogging()).BuildServiceProvider(validateScopes: true);
        using var servicesScope = serviceProvider.CreateScope();
        LibrarySet librarySet = new();
        librarySet.LoadLibraryAndDependencies(LibrarySetsDirs.Cms.ElmDir, "CumulativeMedicationDuration");

        var definitionDictionary = servicesScope.ServiceProvider.GetRequiredService<LibrarySetExpressionBuilder>().ProcessLibrarySet(librarySet);
        var lambdaExpression = definitionDictionary["CumulativeMedicationDuration-4.1.000", "Every eight hours (qualifier value)"];
        Assert.IsNotNull(lambdaExpression);

        var del = lambdaExpression.Compile(true);
        var cqlContext = new CqlContext(CqlOperators.Create(serviceProvider.GetRequiredService<TypeResolver>(), serviceProvider.GetRequiredService<TypeConverter>()));
        var res = (CqlCode)del.DynamicInvoke(cqlContext);
        Assert.AreEqual(("307469008", "http://snomed.info/sct"), (res.code, res.system));
    }
}