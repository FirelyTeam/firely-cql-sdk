/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

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

    /// <summary>
    /// The version the code generator writes now, which the toolkit runs.
    /// </summary>
    private const string CurrentGeneratorVersion = LibrarySetCSharpCodeGenerator.GeneratorToolVersion;

    /// <summary>
    /// The last version that wrote <see cref="LibrarySetCSharpCodeGenerator.LegacyGeneratorToolName"/>: a fixed fact,
    /// which no later version bump changes.
    /// </summary>
    private const string LastGeneratorVersionWithLegacyToolName = "6.0.3.0";

    /// <summary>
    /// A version older than any the toolkit runs, whatever its supported range.
    /// </summary>
    private static readonly string OlderUnsupportedGeneratorVersion =
        new Version(InvocationToolkit.MinSupportedGeneratorToolVersion.Major - 1, 0, 0, 0).ToString();

    /// <summary>
    /// The first version newer than the toolkit runs.
    /// </summary>
    private static readonly string NewerUnsupportedGeneratorVersion =
        InvocationToolkit.FirstUnsupportedGeneratorToolVersion.ToString();

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
        var cqlAssemblyInfo = InvocationToolkit.ReadCqlAssemblyInfo(GeneratedLibrary.Value.assembly);

        cqlAssemblyInfo.Libraries.Should().HaveCount(1)
                    .And.ContainKey(LibraryIdentifier)
                    .WhoseValue.Should().Be(new CqlLibraryInfo(LibraryIdentifier, ElmToolkit.GeneratorToolVersion));
        cqlAssemblyInfo.AssemblyName!.FullName.Should().Be(LoadedAssemblyName(GeneratedLibrary.Value.assembly).FullName);
        cqlAssemblyInfo.Error.Should().BeNull();
        cqlAssemblyInfo.HasErrors.Should().BeFalse();
        cqlAssemblyInfo.IsSupported.Should().BeTrue();
    }

    [TestMethod]
    public void ReadCqlAssemblyInfo_ReturnsTheAssemblyBinaryItWasGiven_DebugSymbolsIncluded()
    {
        var assemblyBinary = new AssemblyBinary(GeneratedLibrary.Value.assembly.AssemblyBytes, [1, 2, 3]);

        var cqlAssemblyInfo = InvocationToolkit.ReadCqlAssemblyInfo(assemblyBinary);

        cqlAssemblyInfo.AssemblyBinary.Should().BeSameAs(assemblyBinary);
    }

    [TestMethod]
    public void ReadCqlAssemblyInfo_OfAnAssemblyWithTwoLibraries_ReturnsEachWithItsOwnGeneratorVersion()
    {
        var assembly = Compile(
            "TwoGeneratedLibraries",
            LibraryType("First", "FirstLibrary", "1.0.0", GeneratorToolName, CurrentGeneratorVersion),
            LibraryType("Second", "SecondLibrary", "2.0.0", GeneratorToolName, OlderUnsupportedGeneratorVersion));

        var cqlAssemblyInfo = InvocationToolkit.ReadCqlAssemblyInfo(assembly);

        cqlAssemblyInfo.AssemblyName!.Name.Should().Be("TwoGeneratedLibraries");
        cqlAssemblyInfo.Libraries.Should().HaveCount(2);
        cqlAssemblyInfo.IsSupported.Should().BeFalse("SecondLibrary was written by an unsupported generator version");

        cqlAssemblyInfo.Libraries.TryGetValue(Identifier("FirstLibrary", "1.0.0"), out var first).Should().BeTrue();
        first!.GeneratorToolVersion.Should().Be(Version.Parse(CurrentGeneratorVersion));
        first.IsSupported.Should().BeTrue();

        cqlAssemblyInfo.Libraries.TryGetValue(Identifier("SecondLibrary", "2.0.0"), out var second).Should().BeTrue();
        second!.GeneratorToolVersion.Should().Be(Version.Parse(OlderUnsupportedGeneratorVersion));
        second.IsSupported.Should().BeFalse();

        cqlAssemblyInfo.Libraries.TryGetValue(Identifier("ThirdLibrary", "1.0.0"), out var third).Should().BeFalse();
        third.Should().BeNull();
    }

    [TestMethod]
    public void ReadCqlAssemblyInfo_OfAnAssemblyWithoutCqlLibraries_ReturnsNoLibraries()
    {
        var assembly = Compile(
            "NoGeneratedLibraries",
            LibraryType("FromAnotherTool", "OtherLibrary", "1.0.0", "xsd", "4.8.3928.0"),
            $$"""
            [System.CodeDom.Compiler.GeneratedCode("{{GeneratorToolName}}", "{{CurrentGeneratorVersion}}")]
            public class GeneratedButNotALibrary { }
            """,
            "public class NotGenerated { }");

        var cqlAssemblyInfo = InvocationToolkit.ReadCqlAssemblyInfo(assembly);

        cqlAssemblyInfo.Libraries.Should().BeEmpty();
        cqlAssemblyInfo.IsSupported.Should().BeFalse("the assembly holds no CQL library to run");
        cqlAssemblyInfo.Error.Should().BeNull();
        cqlAssemblyInfo.HasErrors.Should().BeFalse();
    }

    [TestMethod]
    public void ReadCqlAssemblyInfo_DoesNotLoadTheAssembly()
    {
        const string assemblyName = "CqlLibraryInfoTest_NotLoaded";
        var assembly = RecompileWithGeneratorVersion(LibrarySetCSharpCodeGenerator.GeneratorToolVersion, assemblyName);

        var cqlAssemblyInfo = InvocationToolkit.ReadCqlAssemblyInfo(assembly);

        cqlAssemblyInfo.AssemblyName!.Name.Should().Be(assemblyName);
        AssemblyLoadContext.All
                           .SelectMany(context => context.Assemblies)
                           .Should().NotContain(loaded => loaded.GetName().Name == assemblyName);
    }

    [TestMethod]
    public void ReadCqlAssemblyInfo_OfALibraryTwoTypesDeclare_ReportsAnErrorNamingBothTypes()
    {
        var cqlAssemblyInfo = InvocationToolkit.ReadCqlAssemblyInfo(AssemblyWithADuplicateLibrary());

        var cqlLibraryInfo = cqlAssemblyInfo.Libraries.Should().ContainSingle().Which.Value;
        cqlLibraryInfo.LibraryIdentifier.Should().Be(Identifier("SameLibrary", "1.0.0"));
        cqlLibraryInfo.Error.Should().BeOfType<InvalidOperationException>()
                      .Which.Message.Should().ContainAll("SameLibrary-1.0.0", "'First'", "'Second'", "more than one type");
        cqlLibraryInfo.IsSupported.Should().BeFalse();
        cqlAssemblyInfo.HasErrors.Should().BeTrue();
        cqlAssemblyInfo.IsSupported.Should().BeFalse();
    }

    [TestMethod]
    public void ReadCqlAssemblyInfo_OfATypeWithTwoCqlLibraryAttributes_ReportsAnErrorOnBothLibraries()
    {
        var cqlAssemblyInfo = InvocationToolkit.ReadCqlAssemblyInfo(Compile("TypeWithTwoCqlLibraryAttributes", TypeWithTwoCqlLibraryAttributes));

        cqlAssemblyInfo.Libraries.Keys.Should().BeEquivalentTo([Identifier("BrokenFirst", "1.0.0"), Identifier("BrokenSecond", "1.0.0")]);
        foreach (var cqlLibraryInfo in cqlAssemblyInfo.Libraries.Values)
        {
            cqlLibraryInfo.Error.Should().BeOfType<InvalidOperationException>()
                          .Which.Message.Should().ContainAll("TwoCqlLibraryAttributes", "more than one CqlLibraryAttribute");
            cqlLibraryInfo.IsSupported.Should().BeFalse();
        }

        cqlAssemblyInfo.HasErrors.Should().BeTrue();
    }

    [TestMethod]
    public void CreateLibrarySetInvoker_WithABrokenLibraryNextToAHealthyOne_LoadsTheHealthyOneAsTheReaderSays()
    {
        var assembly = Compile("HealthyAndBroken", GeneratedLibrary.Value.cSharp, TypeWithTwoCqlLibraryAttributes);
        var cqlAssemblyInfo = InvocationToolkit.ReadCqlAssemblyInfo(assembly);
        var warnings = new List<string>();
        using var loggerFactory = new WarningCollectingLoggerFactory(warnings);

        using var invoker = new InvocationToolkit(loggerFactory)
                            .AddAssemblyBinaries([cqlAssemblyInfo.AssemblyBinary])
                            .CreateLibrarySetInvoker();

        cqlAssemblyInfo.HasErrors.Should().BeTrue();
        cqlAssemblyInfo.IsSupported.Should().BeFalse();
        cqlAssemblyInfo.Libraries[LibraryIdentifier].IsSupported.Should().BeTrue();
        invoker.LibraryInvokers.Keys.Should().BeEquivalentTo([LibraryIdentifier]);
        warnings.Should().Contain(warning => warning.Contains("TwoCqlLibraryAttributes") && warning.Contains("more than one CqlLibraryAttribute"));
    }

    [TestMethod]
    public void CreateLibrarySetInvoker_WithALibraryTwoTypesDeclare_SkipsBothAsTheReaderSays()
    {
        var cSharp = GeneratedLibrary.Value.cSharp;
        var className = System.Text.RegularExpressions.Regex.Match(cSharp, @"public partial class (\w+)").Groups[1].Value;
        var assembly = Compile("DeclaredTwice", cSharp, cSharp.Replace(className, className + "_Copy"));
        var cqlAssemblyInfo = InvocationToolkit.ReadCqlAssemblyInfo(assembly);
        var warnings = new List<string>();
        using var loggerFactory = new WarningCollectingLoggerFactory(warnings);

        using var invoker = new InvocationToolkit(loggerFactory)
                            .AddAssemblyBinaries([cqlAssemblyInfo.AssemblyBinary])
                            .CreateLibrarySetInvoker();

        cqlAssemblyInfo.Libraries[LibraryIdentifier].Error.Should().NotBeNull();
        invoker.LibraryInvokers.Should().NotContainKey(LibraryIdentifier);
        warnings.Should().Contain(warning => warning.Contains(className) && warning.Contains(className + "_Copy"));
    }

    [TestMethod]
    public void ReadCqlAssemblyInfo_OfALibraryTwoNestedTypesOfTheSameNameDeclare_ReportsTheErrorTheInvokerLogs()
    {
        var assembly = Compile(
            "DuplicateNestedLibraries",
            $"public class OuterA {{ {LibraryType("Library", "NestedLibrary", "1.0.0", GeneratorToolName, CurrentGeneratorVersion)} }}",
            $"public class OuterB {{ {LibraryType("Library", "NestedLibrary", "1.0.0", GeneratorToolName, CurrentGeneratorVersion)} }}");
        var cqlAssemblyInfo = InvocationToolkit.ReadCqlAssemblyInfo(assembly);
        var warnings = new List<string>();
        using var loggerFactory = new WarningCollectingLoggerFactory(warnings);

        using var invoker = new InvocationToolkit(loggerFactory)
                            .AddAssemblyBinaries([assembly])
                            .CreateLibrarySetInvoker();

        var cqlLibraryInfo = cqlAssemblyInfo.Libraries.Should().ContainSingle().Which.Value;
        cqlLibraryInfo.LibraryIdentifier.Should().Be(Identifier("NestedLibrary", "1.0.0"));
        cqlLibraryInfo.Error.Should().BeOfType<InvalidOperationException>()
                      .Which.Message.Should().ContainAll("'OuterA+Library'", "'OuterB+Library'");
        cqlLibraryInfo.IsSupported.Should().BeFalse();
        warnings.Should().Contain(warning => warning.Contains("'OuterA+Library'") && warning.Contains("'OuterB+Library'"));
    }

    [TestMethod]
    public void ReadCqlAssemblyInfo_OfACorruptAttributeNextToAHealthyLibrary_ReportsAnErrorAsTheInvokerCannotLoadIt()
    {
        const string corruptIdentifier = "CorruptPrologLibrary";
        byte[] assemblyBytes =
        [
            .. Compile(
                   "CorruptAttributeProlog",
                   GeneratedLibrary.Value.cSharp,
                   LibraryType("CorruptProlog", corruptIdentifier, "1.0.0", GeneratorToolName, CurrentGeneratorVersion))
               .AssemblyBytes!,
        ];

        // The compiler writes the attribute's value blob as the prolog 0x0001 followed by its arguments as serialized
        // strings, the identifier first: overwrite that prolog.
        byte[] prologAndIdentifier = [0x01, 0x00, (byte)corruptIdentifier.Length, .. System.Text.Encoding.UTF8.GetBytes(corruptIdentifier)];
        var prologOffset = assemblyBytes.AsSpan().IndexOf(prologAndIdentifier);
        prologOffset.Should().BeGreaterThanOrEqualTo(0).And.Be(assemblyBytes.AsSpan().LastIndexOf(prologAndIdentifier));
        assemblyBytes[prologOffset] = 0x02;
        var assembly = new AssemblyBinary(assemblyBytes);

        var cqlAssemblyInfo = InvocationToolkit.ReadCqlAssemblyInfo(assembly);
        var createLibrarySetInvoker = () =>
        {
            using var invoker = new InvocationToolkit().AddAssemblyBinaries([assembly]).CreateLibrarySetInvoker();
            return invoker.LibraryInvokers.Count;
        };

        cqlAssemblyInfo.Error.Should().BeOfType<BadImageFormatException>();
        ShouldHoldNothingButTheError(cqlAssemblyInfo, assembly);
        createLibrarySetInvoker.Should().Throw<CustomAttributeFormatException>();
    }

    [TestMethod]
    public void ReadCqlAssemblyInfo_IgnoresALookAlikeCqlLibraryAttributeDefinedInTheAssembly_AsTheInvokerDoes()
    {
        var assembly = Compile(
            "LookAlikeInTheAssembly",
            LookAlikeCqlLibraryAttribute,
            LibraryType("LookAlike", "LookAlikeLibrary", "1.0.0", GeneratorToolName, CurrentGeneratorVersion));

        using var invoker = new InvocationToolkit()
                            .AddAssemblyBinaries([assembly])
                            .CreateLibrarySetInvoker();

        InvocationToolkit.ReadCqlAssemblyInfo(assembly).Libraries.Should().BeEmpty();
        invoker.LibraryInvokers.Should().BeEmpty();
    }

    [TestMethod]
    public void ReadCqlAssemblyInfo_IgnoresALookAlikeCqlLibraryAttributeFromAnotherAssembly()
    {
        var lookAlikes = Compile("LookAlikeAttributes", LookAlikeCqlLibraryAttribute);
        var references = PlatformReferences.Value
                                           .Where(reference => !Path.GetFileName(reference.Display ?? "").Equals("HL7.Cql.Abstractions.dll", StringComparison.OrdinalIgnoreCase))
                                           .Append(MetadataReference.CreateFromImage(lookAlikes.AssemblyBytes!));
        var assembly = Compile(
            "LookAlikeFromAnotherAssembly",
            OutputKind.DynamicallyLinkedLibrary,
            references,
            LibraryType("LookAlike", "LookAlikeLibrary", "1.0.0", GeneratorToolName, CurrentGeneratorVersion));

        InvocationToolkit.ReadCqlAssemblyInfo(assembly).Libraries.Should().BeEmpty();
    }

    [TestMethod]
    public void ReadCqlAssemblyInfo_OfAModuleWithoutAnAssemblyManifest_ReportsABadImageFormatError()
    {
        var assembly = ModuleWithoutAnAssemblyManifest();

        var cqlAssemblyInfo = InvocationToolkit.ReadCqlAssemblyInfo(assembly);

        cqlAssemblyInfo.Error.Should().BeOfType<BadImageFormatException>()
                       .Which.Message.Should().Contain("without an assembly manifest");
        ShouldHoldNothingButTheError(cqlAssemblyInfo, assembly);
    }

    [TestMethod]
    [DynamicData(nameof(BytesThatAreNotAnAssembly))]
    public void ReadCqlAssemblyInfo_OfBytesThatAreNotAnAssembly_ReportsABadImageFormatError(byte[] bytes)
    {
        var assembly = new AssemblyBinary(bytes);

        var cqlAssemblyInfo = InvocationToolkit.ReadCqlAssemblyInfo(assembly);

        cqlAssemblyInfo.Error.Should().BeOfType<BadImageFormatException>();
        ShouldHoldNothingButTheError(cqlAssemblyInfo, assembly);
    }

    [TestMethod]
    public void ReadCqlAssemblyInfo_OfATruncatedAssembly_NeverThrows()
    {
        var assemblyBytes = GeneratedLibrary.Value.assembly.AssemblyBytes!;
        var step = Math.Max(1, assemblyBytes.Length / 200);

        for (var length = 0; length < assemblyBytes.Length; length += step)
        {
            var truncated = new AssemblyBinary(assemblyBytes[..length]);
            var read = () => InvocationToolkit.ReadCqlAssemblyInfo(truncated);

            read.Should().NotThrow($"for the first {length} of {assemblyBytes.Length} bytes");
        }

        // Cut inside the PE headers, the read fails.
        InvocationToolkit.ReadCqlAssemblyInfo(new AssemblyBinary(assemblyBytes[..64]))
                         .Error.Should().BeOfType<BadImageFormatException>();
    }

    [TestMethod]
    public void ReadCqlAssemblyInfo_OfANullAssemblyBinary_ThrowsArgumentNullException()
    {
        var read = () => InvocationToolkit.ReadCqlAssemblyInfo(null!);

        read.Should().Throw<ArgumentNullException>().WithParameterName("assemblyBinary");
    }

    [TestMethod]
    public void ReadCqlAssemblyInfo_OfAnAssemblyBinaryWithoutAssemblyBytes_ThrowsArgumentException()
    {
        var read = () => InvocationToolkit.ReadCqlAssemblyInfo(AssemblyBinary.Default);

        read.Should().Throw<ArgumentException>().WithParameterName("assemblyBinary");
    }

    [TestMethod]
    [DynamicData(nameof(GeneratorVersionsAroundTheSupportedRange))]
    public void IsGeneratorToolVersionSupported_AgreesWithWhetherTheInvokerLoadsTheLibrary(string generatorVersion, bool expectedLoaded)
    {
        var assembly = RecompileWithGeneratorVersion(generatorVersion, $"CqlLibraryInfoTest_{generatorVersion.Replace('.', '_')}");
        var cqlAssemblyInfo = InvocationToolkit.ReadCqlAssemblyInfo(assembly);
        var cqlLibraryInfo = cqlAssemblyInfo.Libraries.Should().HaveCount(1)
                                      .And.ContainKey(LibraryIdentifier)
                                      .WhoseValue;

        using var invoker = new InvocationToolkit()
                            .AddAssemblyBinaries([cqlAssemblyInfo.AssemblyBinary])
                            .CreateLibrarySetInvoker();
        var loaded = invoker.LibraryInvokers.ContainsKey(LibraryIdentifier);

        loaded.Should().Be(expectedLoaded);
        InvocationToolkit.IsGeneratorToolVersionSupported(Version.Parse(generatorVersion)).Should().Be(loaded);
        cqlLibraryInfo.IsSupported.Should().Be(loaded);
        cqlAssemblyInfo.IsSupported.Should().Be(loaded);
    }

    [TestMethod]
    [DynamicData(nameof(GeneratorVersionsWithTheLegacyToolName))]
    public void ReadCqlAssemblyInfo_OfALibraryWithTheLegacyGeneratorToolName_RecognizesIt(string generatorVersion, bool expectedLoaded)
    {
        var assembly = RecompileWithGeneratorVersion(
            generatorVersion,
            $"CqlLibraryInfoTest_Legacy_{generatorVersion.Replace('.', '_')}",
            LibrarySetCSharpCodeGenerator.LegacyGeneratorToolName);
        var cqlAssemblyInfo = InvocationToolkit.ReadCqlAssemblyInfo(assembly);
        var cqlLibraryInfo = cqlAssemblyInfo.Libraries.Should().HaveCount(1)
                                      .And.ContainKey(LibraryIdentifier)
                                      .WhoseValue;

        using var invoker = new InvocationToolkit()
                            .AddAssemblyBinaries([cqlAssemblyInfo.AssemblyBinary])
                            .CreateLibrarySetInvoker();

        cqlLibraryInfo.GeneratorToolVersion.Should().Be(Version.Parse(generatorVersion));
        cqlLibraryInfo.IsSupported.Should().Be(expectedLoaded);
        cqlAssemblyInfo.IsSupported.Should().Be(expectedLoaded);
        invoker.LibraryInvokers.ContainsKey(LibraryIdentifier).Should().Be(expectedLoaded);
    }

    [TestMethod]
    [DataRow(GeneratorToolName)]
    [DataRow(LibrarySetCSharpCodeGenerator.LegacyGeneratorToolName)]
    public void CreateLibrarySetInvoker_KeepsTheSameLibraryInfoAsReadFromMetadata(string tool)
    {
        var assembly = RecompileWithGeneratorVersion(
            CurrentGeneratorVersion,
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
        var assembly = RecompileWithGeneratorVersion(OlderUnsupportedGeneratorVersion, "CqlLibraryInfoTest_Warning");
        var warnings = new List<string>();
        using var loggerFactory = new WarningCollectingLoggerFactory(warnings);

        using var invoker = new InvocationToolkit(loggerFactory)
                            .AddAssemblyBinaries([assembly])
                            .CreateLibrarySetInvoker();

        invoker.LibraryInvokers.Should().NotContainKey(LibraryIdentifier);
        warnings.Should().ContainSingle(warning =>
            warning.Contains(LibraryIdentifier.ToString())
            && warning.Contains(OlderUnsupportedGeneratorVersion)
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
            Version.Parse(LastGeneratorVersionWithLegacyToolName),
            "no supported generator version writes the legacy tool name any more, so remove "
            + "LibrarySetCSharpCodeGenerator.LegacyGeneratorToolName and its acceptance in CqlLibraryTypeRule");
    }

    [TestMethod]
    public void IsGeneratorToolVersionSupported_WithComponentsLeftOut_CountsThemAsZero()
    {
        var minSupported = InvocationToolkit.MinSupportedGeneratorToolVersion;
        var firstUnsupported = InvocationToolkit.FirstUnsupportedGeneratorToolVersion;

        InvocationToolkit.IsGeneratorToolVersionSupported(new Version(minSupported.Major, minSupported.Minor)).Should().BeTrue();
        InvocationToolkit.IsGeneratorToolVersionSupported(new Version(firstUnsupported.Major, firstUnsupported.Minor)).Should().BeFalse();
    }

    /// <summary>
    /// A version older than the supported range, its lower bound, the current version, and its exclusive upper bound,
    /// each with whether the toolkit runs it.
    /// </summary>
    public static IEnumerable<object[]> GeneratorVersionsAroundTheSupportedRange =>
    [
        [OlderUnsupportedGeneratorVersion, false],
        [InvocationToolkit.MinSupportedGeneratorToolVersion.ToString(), true],
        [CurrentGeneratorVersion, true],
        [NewerUnsupportedGeneratorVersion, false],
    ];

    /// <summary>
    /// Versions a library with the legacy tool name can carry, each with whether the toolkit runs it. The supported ones
    /// stay supported for as long as the legacy name is, which
    /// <see cref="LegacyGeneratorToolName_IsStillWrittenByASupportedGeneratorVersion"/> guards.
    /// </summary>
    public static IEnumerable<object[]> GeneratorVersionsWithTheLegacyToolName =>
    [
        [OlderUnsupportedGeneratorVersion, false],
        [InvocationToolkit.MinSupportedGeneratorToolVersion.ToString(), true],
        [LastGeneratorVersionWithLegacyToolName, true],
    ];

    public static IEnumerable<object[]> BytesThatAreNotAnAssembly =>
    [
        [Array.Empty<byte>()],
        [new byte[] { 0x4D, 0x5A }],
        ["This is not an assembly."u8.ToArray()],
    ];

    /// <summary>
    /// The name the runtime reports for <paramref name="assembly"/> once loaded, in a collectible context of its own.
    /// </summary>
    private static AssemblyName LoadedAssemblyName(AssemblyBinary assembly)
    {
        var loadContext = new AssemblyLoadContext(nameof(LoadedAssemblyName), isCollectible: true);
        try
        {
            return loadContext.LoadFromStream(new MemoryStream(assembly.AssemblyBytes!)).GetName();
        }
        finally
        {
            loadContext.Unload();
        }
    }

    /// <summary>
    /// Asserts that a result for bytes that could not be read holds nothing besides its
    /// <see cref="CqlAssemblyInfo.Error"/> and the assembly binary it was given.
    /// </summary>
    private static void ShouldHoldNothingButTheError(CqlAssemblyInfo cqlAssemblyInfo, AssemblyBinary assembly)
    {
        cqlAssemblyInfo.AssemblyBinary.Should().BeSameAs(assembly);
        cqlAssemblyInfo.AssemblyName.Should().BeNull();
        cqlAssemblyInfo.Libraries.Should().BeEmpty();
        cqlAssemblyInfo.IsSupported.Should().BeFalse();
        cqlAssemblyInfo.HasErrors.Should().BeTrue();
    }

    private static CqlVersionedLibraryIdentifier Identifier(string identifier, string version) =>
        CqlVersionedLibraryIdentifier.ParseFromIdentifierAndVersion(identifier, version);

    private static string LibraryType(string typeName, string identifier, string version, string tool, string generatorVersion) =>
        $$"""
        [System.CodeDom.Compiler.GeneratedCode("{{tool}}", "{{generatorVersion}}")]
        [Hl7.Cql.Abstractions.CqlLibrary("{{identifier}}", "{{version}}")]
        public class {{typeName}} { }
        """;

    /// <summary>
    /// A type that carries two <see cref="Hl7.Cql.Abstractions.CqlLibraryAttribute"/>s, which the toolkit does not accept.
    /// </summary>
    private static readonly string TypeWithTwoCqlLibraryAttributes = $$"""
        [System.CodeDom.Compiler.GeneratedCode("{{GeneratorToolName}}", "{{CurrentGeneratorVersion}}")]
        [Hl7.Cql.Abstractions.CqlLibrary("BrokenFirst", "1.0.0")]
        [Hl7.Cql.Abstractions.CqlLibrary("BrokenSecond", "1.0.0")]
        public class TwoCqlLibraryAttributes { }
        """;

    /// <summary>
    /// An attribute that looks like the SDK's <see cref="Hl7.Cql.Abstractions.CqlLibraryAttribute"/> but is not it.
    /// </summary>
    private const string LookAlikeCqlLibraryAttribute = """
        namespace Hl7.Cql.Abstractions
        {
            public sealed class CqlLibraryAttribute : System.Attribute
            {
                public CqlLibraryAttribute(string identifier, string version) { }
            }
        }
        """;

    private static AssemblyBinary AssemblyWithADuplicateLibrary() =>
        Compile(
            "DuplicateGeneratedLibraries",
            LibraryType("First", "SameLibrary", "1.0.0", GeneratorToolName, CurrentGeneratorVersion),
            LibraryType("Second", "SameLibrary", "1.0.0", GeneratorToolName, CurrentGeneratorVersion));

    private static AssemblyBinary ModuleWithoutAnAssemblyManifest() =>
        Compile(
            "GeneratedLibraryModule",
            OutputKind.NetModule,
            LibraryType("InAModule", "ModuleLibrary", "1.0.0", GeneratorToolName, CurrentGeneratorVersion));

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

    private static AssemblyBinary Compile(string assemblyName, OutputKind outputKind, params string[] sources) =>
        Compile(assemblyName, outputKind, PlatformReferences.Value, sources);

    private static AssemblyBinary Compile(
        string assemblyName,
        OutputKind outputKind,
        IEnumerable<MetadataReference> references,
        params string[] sources)
    {
        var compilation = CSharpCompilation.Create(
            assemblyName,
            sources.Select(source => CSharpSyntaxTree.ParseText(source)),
            references,
            new CSharpCompilationOptions(outputKind, nullableContextOptions: NullableContextOptions.Enable));

        using var stream = new MemoryStream();
        var result = compilation.Emit(stream);
        Assert.IsTrue(
            result.Success,
            string.Join(Environment.NewLine, result.Diagnostics.Where(diagnostic => diagnostic.Severity == DiagnosticSeverity.Error)));
        return new AssemblyBinary(stream.ToArray());
    }
}
