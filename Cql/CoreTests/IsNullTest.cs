/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.CodeGeneration.NET.Toolkit;
using Hl7.Cql.CodeGeneration.NET.Toolkit.Extensions;
using Hl7.Cql.CodeGeneration.NET.Toolkit.Internal;
using Hl7.Cql.Compiler;
using Hl7.Cql.CqlToElm;
using Hl7.Cql.CqlToElm.Toolkit;
using Hl7.Cql.CqlToElm.Toolkit.Extensions;
using Hl7.Cql.Fhir;
using Hl7.Cql.Invocation.Toolkit;
using Hl7.Cql.Invocation.Toolkit.Extensions;
using Hl7.Cql.Runtime;
using Hl7.Cql.Runtime.Hosting;
using Library = Hl7.Cql.Elm.Library;

namespace CoreTests;

[TestClass]
public class IsNullTest
{
    private static ServiceProvider BuildServiceProvider() =>
        ElmToolkitServices.AddCqlCompilerServices(new ServiceCollection().AddDebugLogging()).BuildServiceProvider(validateScopes: true);

    [TestMethod]
    public void IsNull_Integer_Literal_Should_Be_False()
    {
        // Arrange
        using var serviceProvider = BuildServiceProvider();
        using var servicesScope = serviceProvider.CreateScope();

        var libraryString = CqlLibraryString.Parse("""
           library IsNullTest version '1.0.0'

           define "IsNull_Integer": IsNull(1)
           """);
        var elmLibrary = CreateElmLibrary(libraryString);

        // Act
        var libraryExpressionBuilder = servicesScope.ServiceProvider
                                                    .GetRequiredService<LibraryExpressionBuilder>();
        var definitions = libraryExpressionBuilder.ProcessLibrary(elmLibrary);

        // Assert
        Assert.IsNotNull(definitions);
        Assert.IsTrue(definitions.Libraries.Any());

        var result = InvokeLibrary(elmLibrary, "IsNull_Integer");
        Assert.IsNotNull(result);
        Assert.IsInstanceOfType<bool?>(result);
        Assert.AreEqual(false, result);
    }

    [TestMethod]
    public void IsNull_Null_Integer_Should_Be_True()
    {
        // Arrange
        using var serviceProvider = BuildServiceProvider();
        using var servicesScope = serviceProvider.CreateScope();

        var libraryString = CqlLibraryString.Parse("""
           library IsNullTest version '1.0.0'

           define "IsNull_Null_Integer": IsNull(null as Integer)
           """);
        var elmLibrary = CreateElmLibrary(libraryString);

        // Act
        var definitions = servicesScope.ServiceProvider
                                       .GetRequiredService<LibraryExpressionBuilder>()
                                       .ProcessLibrary(elmLibrary);

        // Assert
        Assert.IsNotNull(definitions);
        Assert.IsTrue(definitions.Libraries.Any());

        var result = InvokeLibrary(elmLibrary, "IsNull_Null_Integer");
        Assert.IsNotNull(result);
        Assert.IsInstanceOfType<bool?>(result);
        Assert.AreEqual(true, result);
    }

    [TestMethod]
    public void IsNull_String_Literal_Should_Be_False()
    {
        // Arrange
        using var serviceProvider = BuildServiceProvider();
        using var servicesScope = serviceProvider.CreateScope();

        var libraryString = CqlLibraryString.Parse("""
           library IsNullTest version '1.0.0'

           define "IsNull_String": IsNull('test')
           """);
        var elmLibrary = CreateElmLibrary(libraryString);

        // Act
        var definitions = servicesScope.ServiceProvider
                                       .GetRequiredService<LibraryExpressionBuilder>()
                                       .ProcessLibrary(elmLibrary);

        // Assert
        Assert.IsNotNull(definitions);
        Assert.IsTrue(definitions.Libraries.Any());

        var result = InvokeLibrary(elmLibrary, "IsNull_String");
        Assert.IsNotNull(result);
        Assert.IsInstanceOfType<bool?>(result);
        Assert.AreEqual(false, result);
    }

    [TestMethod]
    public void IsNull_Null_String_Should_Be_True()
    {
        // Arrange
        using var serviceProvider = BuildServiceProvider();
        using var servicesScope = serviceProvider.CreateScope();

        var libraryString = CqlLibraryString.Parse("""
           library IsNullTest version '1.0.0'

           define "IsNull_Null_String": IsNull(null as String)
           """);
        var elmLibrary = CreateElmLibrary(libraryString);

        // Act
        var definitions = servicesScope.ServiceProvider
                                       .GetRequiredService<LibraryExpressionBuilder>()
                                       .ProcessLibrary(elmLibrary);

        // Assert
        Assert.IsNotNull(definitions);
        Assert.IsTrue(definitions.Libraries.Any());

        var result = InvokeLibrary(elmLibrary, "IsNull_Null_String");
        Assert.IsNotNull(result);
        Assert.IsInstanceOfType<bool?>(result);
        Assert.AreEqual(true, result);
    }

    [TestMethod]
    public void IsNull_Of_Cast_To_Any_Should_Be_False()
    {
        // Arrange
        using var serviceProvider = BuildServiceProvider();
        using var servicesScope = serviceProvider.CreateScope();

        var libraryString = CqlLibraryString.Parse("""
           library IsNullTest version '1.0.0'

           define "IsNull_Integer_As_Any": IsNull(1 as Any)
           """);
        var elmLibrary = CreateElmLibrary(libraryString);

        // Act
        var definitions = servicesScope.ServiceProvider
                                       .GetRequiredService<LibraryExpressionBuilder>()
                                       .ProcessLibrary(elmLibrary);

        // Assert
        Assert.IsNotNull(definitions);
        Assert.IsTrue(definitions.Libraries.Any());

        var result = InvokeLibrary(elmLibrary, "IsNull_Integer_As_Any");
        Assert.IsNotNull(result);
        Assert.IsInstanceOfType<bool?>(result);
        Assert.AreEqual(false, result);
    }

    private static Library CreateElmLibrary(CqlLibraryString libraryString)
    {
        var cqlToolkitConfig = new CqlToolkitConfig([CqlModel.ElmR1, CqlModel.Fhir401]);
        var cqlToolkit = new CqlToolkit(config: cqlToolkitConfig)
                         .AddCqlLibraries([libraryString])
                         .TranslateToElm();
        var elmLibrary = cqlToolkit.GetCqlToolkitResults().First().elmLibrary;

        return elmLibrary;
    }

    private static object InvokeLibrary(Library elmLibrary, string definition)
    {
        var elmToolkit = new ElmToolkit(
#if DEBUG
                                config:new(){DebugSymbolsFormat = DebugSymbolsFormat.Embedded}
#endif
                             )
                        .AddElmLibraries([elmLibrary])
                        .CompileToAssemblies();

        var (libraryIdentifier, _, _, assemblyBinary, debugSymbols) = elmToolkit.GetElmToAssemblyResults().First();
        var assembly = new AssemblyBinary(assemblyBinary, debugSymbols);

        var invoker = new InvocationToolkit()
                       .AddAssemblyBinaries([assembly])
                       .CreateLibrarySetInvoker();

        return invoker.InvokeLibraryDefinition(
            FhirCqlContext.ForBundle(),
            libraryIdentifier,
            definition);
    }
}
