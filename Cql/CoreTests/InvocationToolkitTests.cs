#nullable enable
using CoreTests.Tuples;
using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.Fhir;
using Hl7.Cql.Invocation.Toolkit;
using Hl7.Cql.Invocation.Toolkit.Extensions;
using Hl7.Cql.Runtime;

namespace CoreTests;

[TestClass]
public class InvocationToolkitTests
{
    /// <seealso cref="CqlTupleTests.ExpressionReturningNestedTuplesFromAssemblyLoadedLibraryInstance_ResultCanBeSerialized"/>
    [TestMethod]
    public void TestRuntimeScopeAgainstLibraryDefinitionResults()
    {
        // Arrange
        var filePath = new DirectoryInfo(Directory.GetCurrentDirectory())
                       .SelfAndParents()
                       .Select(dir => Path.GetFullPath(Path.Combine(dir.FullName, "Dlls", "CqlNestedTupleTest-1.0.0.dll")))
                       .First(File.Exists);
        var ctx = FhirCqlContext.ForBundle();
        using var librarySetInvoker = new InvocationToolkit()
                                    .AddAssemblyBinaries(AssemblyBinary.Default.LoadFromFile(new FileInfo(filePath)))
                                    .CreateLibrarySetInvoker();

        // Act
        var result = librarySetInvoker
                     .EnumerateLibraryDefinitionsResults(ctx, CqlVersionedLibraryIdentifier.Parse("CqlNestedTupleTest-1.0.0"))
                     .ToDictionary(t => t.definitionInvoker.DefinitionName);

        // Assert
        Assert.IsNotNull(result);
        result.TryGetValue("Result", out var obj);
        Assert.IsNotNull(obj);
    }
}