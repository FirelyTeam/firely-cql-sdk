using Hl7.Cql.Compiler;
using Hl7.Cql.Primitives;
using Hl7.Cql.Runtime;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoreTests;

[TestClass]
public class LibrarySetExpressionBuilderTests
{
    [TestMethod]
    public void LoadLibraryAndDependencies_CrossLibraryCodeSystems()
    {
        using var cqlCompilerServices = ServiceProviderInitializer.CreateCqlCompilerServiceProvider();

        LibrarySet librarySet = new();
        librarySet.LoadLibraryAndDependencies(LibrarySetsDirs.Cms.ElmDir, "CumulativeMedicationDuration");
        var definitionDictionary = cqlCompilerServices.LibrarySetExpressionBuilder.ProcessLibrarySet(librarySet);
        var lambdaExpression = definitionDictionary["CumulativeMedicationDuration-4.0.000", "Every eight hours (qualifier value)"];
        Assert.IsNotNull(lambdaExpression);

        var del = lambdaExpression.Compile(true);
        var cqlContext = new CqlContext(CqlOperators.Create(cqlCompilerServices.TypeResolver, cqlCompilerServices.TypeConverter));
        var res = (CqlCode)del.DynamicInvoke(cqlContext);
        Assert.AreEqual(("307469008", "http://snomed.info/sct"), (res.code, res.system));
    }
}