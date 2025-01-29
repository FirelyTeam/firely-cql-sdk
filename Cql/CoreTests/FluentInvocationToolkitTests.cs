#nullable enable
using CoreTests.Tuples;
using CqlSdkPrototype.Infrastructure;
using CqlSdkPrototype.Invocation;
using CqlSdkPrototype.Invocation.Extensions;
using CqlSdkPrototype.Invocation.Fluent;
using CqlSdkPrototype.Invocation.Fluent.Extensions;
using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.Fhir;

namespace CoreTests;

[TestClass]
public class FluentInvocationToolkitTests
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
        using var librarySetInvoker = new FluentInvocationToolkit()
                                    .AddAssemblyBinaries(AssemblyBinary.Default.LoadFromFile(new FileInfo(filePath)))
                                    .ToLibrarySetInvoker();

        // Act
        var result = librarySetInvoker
                     .EnumerateLibraryDefinitionsResults(ctx, CqlVersionedLibraryIdentifier.Parse("CqlNestedTupleTest-1.0.0"))
                     .Select(t => (definition: t.definitionInvoker.DefinitionName, t.getResult()))
                     .ToDictionary();

        // Assert
        Assert.IsNotNull(result);
        result.TryGetValue("Result", out var obj);
        Assert.IsNotNull(obj);
    }
}