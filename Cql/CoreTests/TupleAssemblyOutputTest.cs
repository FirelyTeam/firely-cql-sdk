using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.Loader;
using Hl7.Cql.Fhir;
using Hl7.Cql.Packaging;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoreTests;

[TestClass]
public class TupleAssemblyOutputTest
{
    [TestMethod]
    public void ReturnsTupleWithNamedFields()
    {
        var file = @"Assemblies/CqlTupleTest-1.0.0.dll";
        var filePath = Path.GetFullPath(file);

        var asm = new AssemblyLoadContext("CqlTupleTest");
        asm.LoadFromAssemblyPath(filePath);

        var ctx = FhirCqlContext.ForBundle();
        var result = asm.Run("CqlTupleTest", "1.0.0", ctx);
        Assert.IsNotNull(result);

        result.TryGetValue("Result", out var value);
        Assert.IsNotNull(value);
        Assert.IsInstanceOfType(value, typeof(ValueTuple<string, string>));
        var valueTuple = (ValueTuple<string, string>)value;
        Assert.AreEqual("success", valueTuple.status); //doesn't compile because the compiler replaces valueTuple.status with valueTuple.Item1
        Assert.IsNotNull(valueTuple.GetType().GetField("status")); // fails, because the compiler replaced all custom names with default names, the custom names are not part of the runtime type information
        Assert.IsNotNull(valueTuple.GetType().GetField("result")); // fails, because the compiler replaced all custom names with default names, the custom names are not part of the runtime type information
    }
}
