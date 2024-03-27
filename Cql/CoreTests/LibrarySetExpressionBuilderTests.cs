using Hl7.Cql.Compiler;
using Hl7.Cql.Primitives;
using Hl7.Cql.Runtime;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoreTests;

[TestClass]
public class LibrarySetExpressionBuilderTests
{

    [TestMethod]
    public void LoadLibraryAndDependencies_CrossLibraryCodeSystems()
    {
        LibrarySet librarySet = new();
        librarySet.LoadLibraryAndDependencies(LibrarySetsDirs.Cms.ElmDir, "CumulativeMedicationDuration");
        var f = new LibraryDefinitionsBuilderFactory(NullLoggerFactory.Instance);
        var defs = f.LibraryDefinitionsBuilder.ProcessLibrarySet(librarySet);
        var lambdaExpression = defs["CumulativeMedicationDuration-4.0.000", "Every eight hours (qualifier value)"];
        Assert.IsNotNull(lambdaExpression);

        var del = lambdaExpression.Compile(true);
        var res = (CqlCode)del.DynamicInvoke(new CqlContext(CqlOperators.Create(f.FhirTypeResolver, f.TypeConverter)));
        Assert.AreEqual(("307469008", "http://snomed.info/sct"), (res.code, res.system));
    }

}