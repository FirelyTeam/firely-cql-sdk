#nullable enable
using System.IO;
using System.Runtime.Loader;
using CoreTests.Tuples;
using Hl7.Cql.Fhir;
using Hl7.Cql.Packaging;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoreTests;

[TestClass]
public class AssemblyLoadContextTests
{
    /// <seealso cref="CqlTupleTests.ExpressionReturningNestedTuplesFromAssemblyLoadedLibraryInstance_ResultCanBeSerialized"/>
    [TestMethod]
    [Ignore("When running the pipeline, the file cannot be found")]
    /*
     *  Failed TestAssemblyLoadContext [9 ms]
  Error Message:
   Test method CoreTests.AssemblyLoadContextTests.TestAssemblyLoadContext threw exception:
System.IO.FileNotFoundException: Could not load file or assembly 'D:\a\1\s\Cql\CoreTests\bin\Release\net8.0\Dlls\CqlNestedTupleTest-1.0.0.dll'. The system cannot find the path specified.
  Stack Trace:
      at System.Runtime.Loader.AssemblyLoadContext.LoadFromAssemblyPath(String assemblyPath)
   at CoreTests.AssemblyLoadContextTests.TestAssemblyLoadContext() in /_/Cql/CoreTests/AssemblyLoadContextTests.cs:line 22
   at System.RuntimeMethodHandle.InvokeMethod(Object target, Void** arguments, Signature sig, Boolean isConstructor)
   at System.Reflection.MethodBaseInvoker.InvokeWithNoArgs(Object obj, BindingFlags invokeAttr)
     */
    public void TestAssemblyLoadContext()
    {
        // Arrange
        var file = @"Dlls/CqlNestedTupleTest-1.0.0.dll";
        var filePath = Path.GetFullPath(file);
        var asm = new AssemblyLoadContext("CqlNestedTupleTest");
        asm.LoadFromAssemblyPath(filePath);
        var ctx = FhirCqlContext.ForBundle();

        // Act
        var result = asm.Run("CqlNestedTupleTest", "1.0.0", ctx);

        // Assert
        Assert.IsNotNull(result);
        result.TryGetValue("Result", out var obj);
        Assert.IsNotNull(obj);
    }
}