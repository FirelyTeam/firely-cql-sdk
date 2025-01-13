#nullable enable
using System.IO;
using System.Linq;
using System.Runtime.Loader;
using CoreTests.Tuples;
using CqlSdkPrototype;
using CqlSdkPrototype.Runtime;
using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.Fhir;
using Hl7.Cql.Packaging;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoreTests;

[TestClass]
public class RuntimeApiTests
{
    /// <seealso cref="CqlTupleTests.ExpressionReturningNestedTuplesFromAssemblyLoadedLibraryInstance_ResultCanBeSerialized"/>
    [TestMethod]
    public void TestAssemblyLoadContext()
    {
        // Arrange
        var file = @"Dlls/CqlNestedTupleTest-1.0.0.dll";
        var filePath = Path.GetFullPath(file);
        var ctx = FhirCqlContext.ForBundle();
        using var invocationScope = RuntimeApi
                                    .Create(RuntimeApiOptions.Default)
                                    .AddAssemblies([AssemblyData.Default.LoadFromFiles(new FileInfo(filePath))])
                                    .CreateInvocationScope();

        // Act
        var result = invocationScope
            .EnumerateLibraryDefinitionsResults(ctx, CqlVersionedLibraryIdentifier.Parse("CqlNestedTupleTest-1.0.0"))
            .Select(t => (t.definition, t.getResult()))
            .ToDictionary();

        // Assert
        Assert.IsNotNull(result);
        result.TryGetValue("Result", out var obj);
        Assert.IsNotNull(obj);
    }
}