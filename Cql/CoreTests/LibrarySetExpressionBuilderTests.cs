using Hl7.Cql.CodeGeneration.NET.Toolkit;
using Hl7.Cql.Compiler;
using Hl7.Cql.Fhir;
using Hl7.Cql.Invocation.Toolkit.Extensions;
using Hl7.Cql.Primitives;
using Hl7.Cql.Runtime;

namespace CoreTests;

[TestClass]
public class LibrarySetExpressionBuilderTests
{
    [TestMethod]
    public void LoadLibraryAndDependencies_CrossLibraryCodeSystems()
    {
        LibrarySet librarySet = new();
        librarySet.LoadLibraryAndDependencies(LibrarySetsDirs.Cms.ElmDir, "CumulativeMedicationDuration");

        var librarySetInvoker = new ElmToolkit()
                                .AddElmLibraries(librarySet)
                                .CompileToAssemblies()
                                .CreateInvocationToolkit()
                                .CreateLibrarySetInvoker();
        var cqlContext = FhirCqlContext.CreateContext();
        var cqlCode = librarySetInvoker.InvokeLibraryDefinition(
                          cqlContext,
                          (CqlVersionedLibraryIdentifier)"CumulativeMedicationDuration-4.1.000",
                          "Every eight hours (qualifier value)") as CqlCode;
        Assert.AreEqual(new CqlCode("307469008", "http://snomed.info/sct"), cqlCode);
    }
}