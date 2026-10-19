/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable

using System.Runtime.Loader;
using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.CodeGeneration.NET.Toolkit;
using Hl7.Cql.CodeGeneration.NET.Toolkit.Extensions;
using Hl7.Cql.CqlToElm;
using Hl7.Cql.CqlToElm.Toolkit;
using Hl7.Cql.CqlToElm.Toolkit.Extensions;
using Hl7.Cql.Invocation.Toolkit;
using Hl7.Cql.Runtime;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

namespace CoreTests;

[TestClass]
public class CqlAssemblyInfoReaderTests
{
    private const string GeneratorToolName = LibrarySetCSharpCodeGenerator.GeneratorToolName;

    private const string LibraryCql = """
        library CqlLibraryInfoTest version '1.0.0'

        define "One": 1
        """;

    private static readonly CqlVersionedLibraryIdentifier LibraryIdentifier =
        CqlVersionedLibraryIdentifier.ParseFromIdentifierAndVersion("CqlLibraryInfoTest", "1.0.0");

    private static readonly Lazy<MetadataReference[]> PlatformReferences = new(() =>
        ((string)AppContext.GetData("TRUSTED_PLATFORM_ASSEMBLIES")!)
            .Split(Path.PathSeparator, StringSplitOptions.RemoveEmptyEntries)
            .Select(path => (MetadataReference)MetadataReference.CreateFromFile(path))
            .ToArray());

    /// <summary>
    /// The C# the code generator writes for <see cref="LibraryCql"/>, and the assembly the toolkit compiles from it.
    /// </summary>
    private static readonly Lazy<(string cSharp, AssemblyBinary assembly)> GeneratedLibrary = new(() =>
    {
        var elmToolkit = new CqlToolkit()
                         .AddCqlLibraries(CqlLibraryString.Parse(LibraryCql))
                         .CompileToAssemblies();
        var (_, _, _, assemblyBinary, debugSymbolsBinary) = elmToolkit.GetElmToAssemblyResults().Single();
        return (elmToolkit.GetElmToCSharpResults().Single().cSharp,
                new AssemblyBinary(assemblyBinary, debugSymbolsBinary));
    });

    [TestMethod]
    public void ReadCqlAssemblyInfo_OfAnAssemblyTheElmToolkitCompiles_ReturnsItsLibraryWithTheCurrentGeneratorVersion()
    {
        var assemblyInfo = InvocationToolkit.ReadCqlAssemblyInfo(GeneratedLibrary.Value.assembly);

        assemblyInfo.Libraries.Should().HaveCount(1)
                    .And.ContainKey(LibraryIdentifier)
                    .WhoseValue.Should().Be(new CqlLibraryInfo(LibraryIdentifier, ElmToolkit.GeneratorToolVersion));
        assemblyInfo.AssemblyName.Name.Should().NotBeNullOrEmpty();
        assemblyInfo.IsSupported.Should().BeTrue();
    }

    [TestMethod]
    public void ReadCqlAssemblyInfo_ReturnsTheAssemblyBinaryItWasGiven_DebugSymbolsIncluded()
    {
        var assemblyBinary = new AssemblyBinary(GeneratedLibrary.Value.assembly.AssemblyBytes, [1, 2, 3]);

        var assemblyInfo = InvocationToolkit.ReadCqlAssemblyInfo(assemblyBinary);

        assemblyInfo.AssemblyBinary.Should().BeSameAs(assemblyBinary);
    }

    [TestMethod]
    public void ReadCqlAssemblyInfo_OfAnAssemblyWithTwoLibraries_ReturnsEachWithItsOwnGeneratorVersion()
    {
        var assembly = Compile(
            "TwoGeneratedLibraries",
            LibraryType("First", "FirstLibrary", "1.0.0", GeneratorToolName, "6.0.0.0"),
            LibraryType("Second", "SecondLibrary", "2.0.0", GeneratorToolName, "5.1.0.0"));

        var assemblyInfo = InvocationToolkit.ReadCqlAssemblyInfo(assembly);

        assemblyInfo.AssemblyName.Name.Should().Be("TwoGeneratedLibraries");
        assemblyInfo.Libraries.Should().HaveCount(2);
        assemblyInfo.IsSupported.Should().BeFalse("SecondLibrary was written by an unsupported generator version");

        assemblyInfo.Libraries.TryGetValue(Identifier("FirstLibrary", "1.0.0"), out var first).Should().BeTrue();
        first!.GeneratorToolVersion.Should().Be(new Version(6, 0, 0, 0));
        first.IsSupported.Should().BeTrue();

        assemblyInfo.Libraries.TryGetValue(Identifier("SecondLibrary", "2.0.0"), out var second).Should().BeTrue();
        second!.GeneratorToolVersion.Should().Be(new Version(5, 1, 0, 0));
        second.IsSupported.Should().BeFalse();

        assemblyInfo.Libraries.TryGetValue(Identifier("ThirdLibrary", "1.0.0"), out var third).Should().BeFalse();
        third.Should().BeNull();
    }

    [TestMethod]
    public void ReadCqlAssemblyInfo_OfAnAssemblyWithoutCqlLibraries_ReturnsNoLibraries()
    {
        var assembly = Compile(
            "NoGeneratedLibraries",
            LibraryType("FromAnotherTool", "OtherLibrary", "1.0.0", "xsd", "4.8.3928.0"),
            $$"""
            [System.CodeDom.Compiler.GeneratedCode("{{GeneratorToolName}}", "6.0.0.0")]
            public class GeneratedButNotALibrary { }
            """,
            "public class NotGenerated { }");

        InvocationToolkit.ReadCqlAssemblyInfo(assembly).Libraries.Should().BeEmpty();
        InvocationToolkit.ReadCqlAssemblyInfo(assembly).IsSupported.Should().BeFalse("the assembly holds no CQL library to run");

        InvocationToolkit.TryReadCqlAssemblyInfo(assembly, out var assemblyInfo).Should().BeTrue();
        assemblyInfo!.Libraries.Should().BeEmpty();
    }

    [TestMethod]
    public void ReadCqlAssemblyInfo_DoesNotLoadTheAssembly()
    {
        const string assemblyName = "CqlLibraryInfoTest_NotLoaded";
        var assembly = RecompileWithGeneratorVersion(LibrarySetCSharpCodeGenerator.GeneratorToolVersion, assemblyName);

        var assemblyInfo = InvocationToolkit.ReadCqlAssemblyInfo(assembly);

        assemblyInfo.AssemblyName.Name.Should().Be(assemblyName);
        AssemblyLoadContext.All
                           .SelectMany(context => context.Assemblies)
                           .Should().NotContain(loaded => loaded.GetName().Name == assemblyName);
    }

    [TestMethod]
    public void ReadCqlAssemblyInfo_OfAnAssemblyWithADuplicateLibrary_ThrowsInvalidOperationException()
    {
        var read = () => InvocationToolkit.ReadCqlAssemblyInfo(AssemblyWithADuplicateLibrary());

        read.Should().Throw<InvalidOperationException>().WithMessage("*SameLibrary-1.0.0*");
    }

    [TestMethod]
    public void ReadCqlAssemblyInfo_OfAModuleWithoutAnAssemblyManifest_ThrowsBadImageFormatException()
    {
        var read = () => InvocationToolkit.ReadCqlAssemblyInfo(ModuleWithoutAnAssemblyManifest());

        read.Should().Throw<BadImageFormatException>();
    }

    [TestMethod]
    [DynamicData(nameof(BytesThatAreNotAnAssembly))]
    public void ReadCqlAssemblyInfo_OfBytesThatAreNotAnAssembly_ThrowsBadImageFormatException(byte[] bytes)
    {
        var read = () => InvocationToolkit.ReadCqlAssemblyInfo(new AssemblyBinary(bytes));

        read.Should().Throw<BadImageFormatException>();
    }

    [TestMethod]
    public void ReadCqlAssemblyInfo_OfAnAssemblyBinaryWithoutAssemblyBytes_ThrowsArgumentException()
    {
        var read = () => InvocationToolkit.ReadCqlAssemblyInfo(AssemblyBinary.Default);

        read.Should().Throw<ArgumentException>().WithParameterName("assemblyBinary");
    }

    [TestMethod]
    public void TryReadCqlAssemblyInfo_OfAnAssemblyThatReads_ReturnsTheSameResultAsRead()
    {
        var assembly = GeneratedLibrary.Value.assembly;
        var read = InvocationToolkit.ReadCqlAssemblyInfo(assembly);

        InvocationToolkit.TryReadCqlAssemblyInfo(assembly, out var assemblyInfo).Should().BeTrue();

        assemblyInfo!.AssemblyBinary.Should().BeSameAs(read.AssemblyBinary);
        assemblyInfo.AssemblyName.FullName.Should().Be(read.AssemblyName.FullName);
        assemblyInfo.Libraries.Should().Equal(read.Libraries);
    }

    [TestMethod]
    public void TryReadCqlAssemblyInfo_WhereReadThrows_ReturnsFalseWithoutThrowing()
    {
        (string because, AssemblyBinary? assembly)[] cases =
        [
            ("a null assembly binary", null),
            ("an assembly binary without assembly bytes", AssemblyBinary.Default),
            ("an empty array", new AssemblyBinary(Array.Empty<byte>())),
            ("bytes that are not an assembly", new AssemblyBinary("This is not an assembly."u8.ToArray())),
            ("a module without an assembly manifest", ModuleWithoutAnAssemblyManifest()),
            ("an assembly with a duplicate library", AssemblyWithADuplicateLibrary()),
        ];

        foreach (var (because, assembly) in cases)
        {
            CqlAssemblyInfo? assemblyInfo = null;
            var tryRead = () => InvocationToolkit.TryReadCqlAssemblyInfo(assembly, out assemblyInfo);

            tryRead.Should().NotThrow(because).Which.Should().BeFalse(because);
            assemblyInfo.Should().BeNull(because);
        }
    }

    [TestMethod]
    public void TryReadCqlAssemblyInfo_OfATruncatedAssembly_NeverThrows()
    {
        var assemblyBytes = GeneratedLibrary.Value.assembly.AssemblyBytes!;
        var step = Math.Max(1, assemblyBytes.Length / 200);

        for (var length = 0; length < assemblyBytes.Length; length += step)
        {
            var truncated = new AssemblyBinary(assemblyBytes[..length]);
            var tryRead = () => InvocationToolkit.TryReadCqlAssemblyInfo(truncated, out _);

            tryRead.Should().NotThrow($"for the first {length} of {assemblyBytes.Length} bytes");
        }

        // Cut inside the PE headers, the read fails.
        InvocationToolkit.TryReadCqlAssemblyInfo(new AssemblyBinary(assemblyBytes[..64]), out _).Should().BeFalse();
    }

    [TestMethod]
    [DataRow("5.0.0.0", false)]
    [DataRow("6.0.0.0", true)]
    [DataRow(LibrarySetCSharpCodeGenerator.GeneratorToolVersion, true)]
    [DataRow("7.0.0.0", false)]
    public void IsGeneratorToolVersionSupported_AgreesWithWhetherTheInvokerLoadsTheLibrary(string generatorVersion, bool expectedLoaded)
    {
        var assembly = RecompileWithGeneratorVersion(generatorVersion, $"CqlLibraryInfoTest_{generatorVersion.Replace('.', '_')}");
        var assemblyInfo = InvocationToolkit.ReadCqlAssemblyInfo(assembly);
        var libraryInfo = assemblyInfo.Libraries.Should().HaveCount(1)
                                      .And.ContainKey(LibraryIdentifier)
                                      .WhoseValue;

        using var invoker = new InvocationToolkit()
                            .AddAssemblyBinaries([assemblyInfo.AssemblyBinary])
                            .CreateLibrarySetInvoker();
        var loaded = invoker.LibraryInvokers.ContainsKey(LibraryIdentifier);

        loaded.Should().Be(expectedLoaded);
        InvocationToolkit.IsGeneratorToolVersionSupported(Version.Parse(generatorVersion)).Should().Be(loaded);
        libraryInfo.IsSupported.Should().Be(loaded);
        assemblyInfo.IsSupported.Should().Be(loaded);
    }

    [TestMethod]
    [DataRow("5.0.0.0", false)]
    [DataRow("6.0.0.0", true)]
    [DataRow("6.0.3.0", true)]
    public void ReadCqlAssemblyInfo_OfALibraryWithTheLegacyGeneratorToolName_RecognizesIt(string generatorVersion, bool expectedLoaded)
    {
        var assembly = RecompileWithGeneratorVersion(
            generatorVersion,
            $"CqlLibraryInfoTest_Legacy_{generatorVersion.Replace('.', '_')}",
            LibrarySetCSharpCodeGenerator.LegacyGeneratorToolName);
        var assemblyInfo = InvocationToolkit.ReadCqlAssemblyInfo(assembly);
        var libraryInfo = assemblyInfo.Libraries.Should().HaveCount(1)
                                      .And.ContainKey(LibraryIdentifier)
                                      .WhoseValue;

        using var invoker = new InvocationToolkit()
                            .AddAssemblyBinaries([assemblyInfo.AssemblyBinary])
                            .CreateLibrarySetInvoker();

        libraryInfo.GeneratorToolVersion.Should().Be(Version.Parse(generatorVersion));
        libraryInfo.IsSupported.Should().Be(expectedLoaded);
        assemblyInfo.IsSupported.Should().Be(expectedLoaded);
        invoker.LibraryInvokers.ContainsKey(LibraryIdentifier).Should().Be(expectedLoaded);
    }

    [TestMethod]
    [DataRow(GeneratorToolName)]
    [DataRow(LibrarySetCSharpCodeGenerator.LegacyGeneratorToolName)]
    public void CreateLibrarySetInvoker_KeepsTheSameLibraryInfoAsReadFromMetadata(string tool)
    {
        var assembly = RecompileWithGeneratorVersion(
            "6.0.0.0",
            $"CqlLibraryInfoTest_SameInfo_{(tool == GeneratorToolName ? "Current" : "Legacy")}",
            tool);
        var readFromMetadata = InvocationToolkit.ReadCqlAssemblyInfo(assembly).Libraries[LibraryIdentifier];

        using var invoker = new InvocationToolkit()
                            .AddAssemblyBinaries([assembly])
                            .CreateLibrarySetInvoker();

        invoker.LibraryInvokers[LibraryIdentifier].LibraryInfo.Should().Be(readFromMetadata);
    }

    [TestMethod]
    public void CreateLibrarySetInvoker_SkippingAnUnsupportedLibrary_WarnsWithTheLibraryAndTheSupportedRange()
    {
        var assembly = RecompileWithGeneratorVersion("5.0.0.0", "CqlLibraryInfoTest_Warning");
        var warnings = new List<string>();
        using var loggerFactory = new WarningCollectingLoggerFactory(warnings);

        using var invoker = new InvocationToolkit(loggerFactory)
                            .AddAssemblyBinaries([assembly])
                            .CreateLibrarySetInvoker();

        invoker.LibraryInvokers.Should().NotContainKey(LibraryIdentifier);
        warnings.Should().ContainSingle(warning =>
            warning.Contains(LibraryIdentifier.ToString())
            && warning.Contains("5.0.0.0")
            && warning.Contains(InvocationToolkit.MinSupportedGeneratorToolVersion.ToString())
            && warning.Contains(InvocationToolkit.FirstUnsupportedGeneratorToolVersion.ToString()));
    }

    [TestMethod]
    public void GeneratedCSharp_NamesTheGeneratorByItsCurrentName()
    {
        var cSharp = GeneratedLibrary.Value.cSharp;

        cSharp.Should().Contain(
            $"[System.CodeDom.Compiler.GeneratedCode(\"{GeneratorToolName}\", \"{LibrarySetCSharpCodeGenerator.GeneratorToolVersion}\")]");
        cSharp.Should().NotContain(LibrarySetCSharpCodeGenerator.LegacyGeneratorToolName);
    }

    /// <summary>
    /// Generator versions up to 6.0.3.0 wrote <see cref="LibrarySetCSharpCodeGenerator.LegacyGeneratorToolName"/>.
    /// Once the toolkit no longer supports any of them, this fails, as the reminder to remove that name and its
    /// acceptance by the invocation toolkit.
    /// </summary>
    [TestMethod]
    public void LegacyGeneratorToolName_IsStillWrittenByASupportedGeneratorVersion()
    {
        InvocationToolkit.MinSupportedGeneratorToolVersion.Should().BeLessThanOrEqualTo(
            new Version(6, 0, 3, 0),
            "no supported generator version writes the legacy tool name any more, so remove "
            + "LibrarySetCSharpCodeGenerator.LegacyGeneratorToolName and its acceptance in CqlLibraryTypeRule");
    }

    [TestMethod]
    public void IsGeneratorToolVersionSupported_WithComponentsLeftOut_CountsThemAsZero()
    {
        InvocationToolkit.IsGeneratorToolVersionSupported(new Version(6, 0)).Should().BeTrue();
        InvocationToolkit.IsGeneratorToolVersionSupported(new Version(7, 0)).Should().BeFalse();
    }

    public static IEnumerable<object[]> BytesThatAreNotAnAssembly =>
    [
        [Array.Empty<byte>()],
        [new byte[] { 0x4D, 0x5A }],
        ["This is not an assembly."u8.ToArray()],
    ];

    private static CqlVersionedLibraryIdentifier Identifier(string identifier, string version) =>
        CqlVersionedLibraryIdentifier.ParseFromIdentifierAndVersion(identifier, version);

    private static string LibraryType(string typeName, string identifier, string version, string tool, string generatorVersion) =>
        $$"""
        [System.CodeDom.Compiler.GeneratedCode("{{tool}}", "{{generatorVersion}}")]
        [Hl7.Cql.Abstractions.CqlLibrary("{{identifier}}", "{{version}}")]
        public class {{typeName}} { }
        """;

    private static AssemblyBinary AssemblyWithADuplicateLibrary() =>
        Compile(
            "DuplicateGeneratedLibraries",
            LibraryType("First", "SameLibrary", "1.0.0", GeneratorToolName, "6.0.0.0"),
            LibraryType("Second", "SameLibrary", "1.0.0", GeneratorToolName, "6.0.0.0"));

    private static AssemblyBinary ModuleWithoutAnAssemblyManifest() =>
        Compile(
            "GeneratedLibraryModule",
            OutputKind.NetModule,
            LibraryType("InAModule", "ModuleLibrary", "1.0.0", GeneratorToolName, "6.0.0.0"));

    /// <summary>
    /// Compiles the C# the code generator wrote for <see cref="LibraryCql"/> again, with its
    /// <see cref="System.CodeDom.Compiler.GeneratedCodeAttribute"/> naming <paramref name="tool"/> and
    /// <paramref name="generatorVersion"/>.
    /// </summary>
    private static AssemblyBinary RecompileWithGeneratorVersion(
        string generatorVersion,
        string assemblyName,
        string tool = GeneratorToolName)
    {
        var generatedCode = $"GeneratedCode(\"{GeneratorToolName}\", \"{LibrarySetCSharpCodeGenerator.GeneratorToolVersion}\")";
        var cSharp = GeneratedLibrary.Value.cSharp;
        cSharp.Should().Contain(generatedCode);

        return Compile(assemblyName, cSharp.Replace(generatedCode, $"GeneratedCode(\"{tool}\", \"{generatorVersion}\")"));
    }

    /// <summary>
    /// An <see cref="ILoggerFactory"/> that collects every message logged at warning level or above.
    /// </summary>
    private sealed class WarningCollectingLoggerFactory(List<string> warnings) : ILoggerFactory
    {
        public ILogger CreateLogger(string categoryName) => new WarningCollectingLogger(warnings);

        public void AddProvider(ILoggerProvider provider) { }

        public void Dispose() { }

        private sealed class WarningCollectingLogger(List<string> warnings) : ILogger
        {
            public IDisposable? BeginScope<TState>(TState state) where TState : notnull => null;

            public bool IsEnabled(LogLevel logLevel) => logLevel >= LogLevel.Warning;

            public void Log<TState>(
                LogLevel logLevel,
                EventId eventId,
                TState state,
                Exception? exception,
                Func<TState, Exception?, string> formatter)
            {
                if (logLevel < LogLevel.Warning)
                    return;

                lock (warnings)
                    warnings.Add(formatter(state, exception));
            }
        }
    }

    private static AssemblyBinary Compile(string assemblyName, params string[] sources) =>
        Compile(assemblyName, OutputKind.DynamicallyLinkedLibrary, sources);

    private static AssemblyBinary Compile(string assemblyName, OutputKind outputKind, params string[] sources)
    {
        var compilation = CSharpCompilation.Create(
            assemblyName,
            sources.Select(source => CSharpSyntaxTree.ParseText(source)),
            PlatformReferences.Value,
            new CSharpCompilationOptions(outputKind, nullableContextOptions: NullableContextOptions.Enable));

        using var stream = new MemoryStream();
        var result = compilation.Emit(stream);
        Assert.IsTrue(
            result.Success,
            string.Join(Environment.NewLine, result.Diagnostics.Where(diagnostic => diagnostic.Severity == DiagnosticSeverity.Error)));
        return new AssemblyBinary(stream.ToArray());
    }
}
