/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System.Collections.Immutable;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Reflection.PortableExecutable;
using System.Runtime.Loader;
using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.CodeGeneration.NET.Toolkit;
using Hl7.Cql.CodeGeneration.NET.Toolkit.Extensions;
using Hl7.Cql.CqlToElm;
using Hl7.Cql.CqlToElm.Toolkit;
using Hl7.Cql.CqlToElm.Toolkit.Extensions;
using Hl7.Cql.Invocation.Toolkit;
using Hl7.Cql.Invocation.Toolkit.Errors;
using Hl7.Cql.Invocation.Toolkit.Internal;
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
        cqlAssemblyInfo.ReadError.Should().BeNull();
        cqlAssemblyInfo.HasReadErrors.Should().BeFalse();
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
        cqlAssemblyInfo.ReadError.Should().BeNull();
        cqlAssemblyInfo.HasReadErrors.Should().BeFalse();
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
        cqlLibraryInfo.ReadError.Should().Be(
            new CqlLibraryDeclaredByMoreThanOneTypeError(
                cqlAssemblyInfo.AssemblyName!.FullName,
                Identifier("SameLibrary", "1.0.0"),
                ["First", "Second"]));
        cqlLibraryInfo.ReadError!.GetMessage().Should().ContainAll("SameLibrary-1.0.0", "'First'", "'Second'", "more than one type");
        cqlLibraryInfo.IsSupported.Should().BeFalse();
        cqlAssemblyInfo.HasReadErrors.Should().BeTrue();
        cqlAssemblyInfo.IsSupported.Should().BeFalse();
    }

    [TestMethod]
    public void ReadCqlAssemblyInfo_ReadTwice_GivesEqualLibrariesWithEqualReadErrors()
    {
        AssemblyBinary[] assemblies =
        [
            AssemblyWithADuplicateLibrary(),
            Compile("TypeWithTwoCqlLibraryAttributes", TypeWithTwoCqlLibraryAttributes),
        ];

        foreach (var assembly in assemblies)
        {
            var first = InvocationToolkit.ReadCqlAssemblyInfo(assembly);
            var second = InvocationToolkit.ReadCqlAssemblyInfo(assembly);

            first.Libraries.Values.Should().OnlyContain(cqlLibraryInfo => cqlLibraryInfo.ReadError != null);
            first.Libraries.Should().Equal(second.Libraries);
        }
    }

    [TestMethod]
    public void ReadCqlAssemblyInfo_OfATypeWithTwoCqlLibraryAttributes_ReportsAnErrorOnBothLibraries()
    {
        var cqlAssemblyInfo = InvocationToolkit.ReadCqlAssemblyInfo(Compile("TypeWithTwoCqlLibraryAttributes", TypeWithTwoCqlLibraryAttributes));

        cqlAssemblyInfo.Libraries.Keys.Should().BeEquivalentTo([Identifier("BrokenFirst", "1.0.0"), Identifier("BrokenSecond", "1.0.0")]);
        foreach (var cqlLibraryInfo in cqlAssemblyInfo.Libraries.Values)
        {
            cqlLibraryInfo.ReadError.Should().Be(
                new CqlLibraryTypeWithMoreThanOneAttributeError(
                    cqlAssemblyInfo.AssemblyName!.FullName,
                    cqlLibraryInfo.LibraryIdentifier,
                    "TwoCqlLibraryAttributes",
                    "CqlLibraryAttribute"));
            cqlLibraryInfo.ReadError!.GetMessage().Should().ContainAll("TwoCqlLibraryAttributes", "more than one CqlLibraryAttribute");
            cqlLibraryInfo.IsSupported.Should().BeFalse();
        }

        cqlAssemblyInfo.HasReadErrors.Should().BeTrue();
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

        cqlAssemblyInfo.HasReadErrors.Should().BeTrue();
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

        cqlAssemblyInfo.Libraries[LibraryIdentifier].ReadError.Should().NotBeNull();
        invoker.LibraryInvokers.Should().NotContainKey(LibraryIdentifier);
        warnings.Should().Contain(warning => warning.Contains(className) && warning.Contains(className + "_Copy"));
    }

    [TestMethod]
    public void CreateLibrarySetInvoker_WithOneLibraryInTwoAssemblies_SkipsBothAndNamesEachAssembly()
    {
        var firstCopy = Compile(
            "FirstCopy",
            LibraryType("Shared", "SharedLibrary", "1.0.0", GeneratorToolName, CurrentGeneratorVersion));
        var secondCopy = Compile(
            "SecondCopy",
            LibraryType("Shared", "SharedLibrary", "1.0.0", GeneratorToolName, CurrentGeneratorVersion));
        var warnings = new List<string>();
        using var loggerFactory = new WarningCollectingLoggerFactory(warnings);

        using var invoker = new InvocationToolkit(loggerFactory)
                            .AddAssemblyBinaries([firstCopy, secondCopy])
                            .CreateLibrarySetInvoker();

        // Reading one assembly at a time, the reader cannot see the other copy.
        InvocationToolkit.ReadCqlAssemblyInfo(firstCopy).HasReadErrors.Should().BeFalse();
        InvocationToolkit.ReadCqlAssemblyInfo(secondCopy).HasReadErrors.Should().BeFalse();
        invoker.LibraryInvokers.Should().NotContainKey(Identifier("SharedLibrary", "1.0.0"));
        warnings.Should().Contain(warning => warning.Contains("'Shared, FirstCopy'") && warning.Contains("'Shared, SecondCopy'"));
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
        cqlLibraryInfo.ReadError.Should().Be(
            new CqlLibraryDeclaredByMoreThanOneTypeError(
                cqlAssemblyInfo.AssemblyName!.FullName,
                Identifier("NestedLibrary", "1.0.0"),
                ["OuterA+Library", "OuterB+Library"]));
        cqlLibraryInfo.IsSupported.Should().BeFalse();
        warnings.Should().Contain(warning => warning.Contains("'OuterA+Library'") && warning.Contains("'OuterB+Library'"));
    }

    [TestMethod]
    public void ReadCqlAssemblyInfo_OfACorruptAttributeNextToAHealthyLibrary_ReportsAnErrorAsTheInvokerCannotLoadIt()
    {
        const string corruptIdentifier = "CorruptPrologLibrary";
        var original = Compile(
            "CorruptAttributeProlog",
            GeneratedLibrary.Value.cSharp,
            LibraryType("CorruptProlog", corruptIdentifier, "1.0.0", GeneratorToolName, CurrentGeneratorVersion));
        byte[] assemblyBytes = [.. original.AssemblyBytes!];

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

        cqlAssemblyInfo.ReadError.Should().Be(
            new CqlLibraryAttributeValueError(
                InvocationToolkit.ReadCqlAssemblyInfo(original).AssemblyName!.FullName,
                "CorruptProlog",
                "CqlLibraryAttribute"));
        ShouldHoldNothingButTheReadError(cqlAssemblyInfo, assembly);
        createLibrarySetInvoker.Should().Throw<CustomAttributeFormatException>();
    }

    [TestMethod]
    public void ReadCqlAssemblyInfo_OfAnAssemblyWhoseNestedTypesFormACycle_ReportsAnUnreadableError()
    {
        var assembly = AssemblyWithCyclicNestedTypes();

        var cqlAssemblyInfo = InvocationToolkit.ReadCqlAssemblyInfo(assembly);

        var readError = cqlAssemblyInfo.ReadError.Should().BeOfType<CqlAssemblyUnreadableError>().Which;
        readError.AssemblyName.Should().StartWith("CyclicNestedTypes,");
        readError.Exception.Should().BeOfType<BadImageFormatException>().Which.Message.Should().Contain("form a cycle");
        ShouldHoldNothingButTheReadError(cqlAssemblyInfo, assembly);
    }

    [TestMethod]
    public void ReadCqlAssemblyInfo_OfACqlLibraryAttributeThatCountsNamedArgumentsItLacks_ReportsAnErrorAsTheInvokerCannotLoadIt()
    {
        var original = Compile(
            "MalformedNamedArgumentCount",
            GeneratedLibrary.Value.cSharp,
            LibraryType("NamedArgumentCount", "NamedArgumentCountLibrary", "1.0.0", GeneratorToolName, CurrentGeneratorVersion));
        var assembly = WithAttributeValueChanged(
            original,
            AttributeValue("NamedArgumentCountLibrary", "1.0.0"),
            value => value[^2] = 0x01);

        var cqlAssemblyInfo = InvocationToolkit.ReadCqlAssemblyInfo(assembly);
        var createLibrarySetInvoker = () =>
        {
            using var invoker = new InvocationToolkit().AddAssemblyBinaries([assembly]).CreateLibrarySetInvoker();
            return invoker.LibraryInvokers.Count;
        };

        cqlAssemblyInfo.ReadError.Should().Be(
            new CqlLibraryAttributeValueError(
                InvocationToolkit.ReadCqlAssemblyInfo(original).AssemblyName!.FullName,
                "NamedArgumentCount",
                "CqlLibraryAttribute"));
        ShouldHoldNothingButTheReadError(cqlAssemblyInfo, assembly);
        createLibrarySetInvoker.Should().Throw<CustomAttributeFormatException>();
    }

    [TestMethod]
    public void ReadCqlAssemblyInfo_IgnoresAMalformedGeneratedCodeAttributeOnATypeThatDeclaresNoLibrary_AsTheInvokerDoes()
    {
        var assembly = WithAttributeValueChanged(
            Compile(
                "MalformedUnrelatedGeneratedCode",
                GeneratedLibrary.Value.cSharp,
                """[System.CodeDom.Compiler.GeneratedCode("UnrelatedTool", "1.2.3")] public class Unrelated { }"""),
            AttributeValue("UnrelatedTool", "1.2.3"),
            value => value[0] = 0x02);

        var cqlAssemblyInfo = InvocationToolkit.ReadCqlAssemblyInfo(assembly);
        using var invoker = new InvocationToolkit()
                            .AddAssemblyBinaries([assembly])
                            .CreateLibrarySetInvoker();

        cqlAssemblyInfo.ReadError.Should().BeNull();
        cqlAssemblyInfo.Libraries[LibraryIdentifier].IsSupported.Should().BeTrue();
        invoker.LibraryInvokers.Should().ContainKey(LibraryIdentifier);
    }

    [TestMethod]
    public void ReadCqlAssemblyInfo_IgnoresAnAttributeDerivedFromCqlLibraryAttribute_AsTheInvokerDoes()
    {
        var assembly = Compile(
            "DerivedCqlLibraryAttribute",
            """
            public sealed class LocalCqlLibraryAttribute : Hl7.Cql.Abstractions.CqlLibraryAttribute
            {
                public LocalCqlLibraryAttribute(string identifier, string version) : base(identifier, version) { }
            }
            """,
            $$"""
            [System.CodeDom.Compiler.GeneratedCode("{{GeneratorToolName}}", "{{CurrentGeneratorVersion}}")]
            [Hl7.Cql.Abstractions.CqlLibrary("DerivedAttributeLibrary", "1.0.0")]
            [LocalCqlLibrary("OtherLibrary", "1.0.0")]
            public class WithDerivedAttribute { }
            """);

        var read = InvocationToolkit.ReadCqlAssemblyInfo(assembly).Libraries.Values;
        var reflected = LibraryInfosByReflection(assembly, "WithDerivedAttribute");

        read.Should().Equal(new CqlLibraryInfo(Identifier("DerivedAttributeLibrary", "1.0.0"), Version.Parse(CurrentGeneratorVersion)));
        reflected.Should().Equal(read);
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
    public void ReadCqlAssemblyInfo_OfAModuleWithoutAnAssemblyManifest_ReportsAModuleWithoutManifestError()
    {
        var assembly = ModuleWithoutAnAssemblyManifest();

        var cqlAssemblyInfo = InvocationToolkit.ReadCqlAssemblyInfo(assembly);

        cqlAssemblyInfo.ReadError.Should().BeOfType<CqlModuleWithoutManifestError>()
                       .Which.ModuleName.Should().StartWith("GeneratedLibraryModule");
        cqlAssemblyInfo.ReadError!.AssemblyName.Should().BeNull();
        ShouldHoldNothingButTheReadError(cqlAssemblyInfo, assembly);
    }

    [TestMethod]
    public void ReadCqlAssemblyInfo_OfAPEFileWithoutMetadata_ReportsAWithoutMetadataError()
    {
        var peImage = new BlobBuilder();
        new PEFileWithoutMetadataBuilder().Serialize(peImage);
        var assembly = new AssemblyBinary(peImage.ToArray());

        var cqlAssemblyInfo = InvocationToolkit.ReadCqlAssemblyInfo(assembly);

        cqlAssemblyInfo.ReadError.Should().Be(new CqlAssemblyWithoutMetadataError());
        ShouldHoldNothingButTheReadError(cqlAssemblyInfo, assembly);
    }

    [TestMethod]
    [DynamicData(nameof(BytesThatAreNotAnAssembly))]
    public void ReadCqlAssemblyInfo_OfBytesThatAreNotAnAssembly_ReportsAnUnreadableError(byte[] bytes)
    {
        var assembly = new AssemblyBinary(bytes);

        var cqlAssemblyInfo = InvocationToolkit.ReadCqlAssemblyInfo(assembly);

        var readError = cqlAssemblyInfo.ReadError.Should().BeOfType<CqlAssemblyUnreadableError>().Which;
        readError.Exception.Should().NotBeNull();
        readError.AssemblyName.Should().BeNull();
        ShouldHoldNothingButTheReadError(cqlAssemblyInfo, assembly);
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
                         .ReadError.Should().BeOfType<CqlAssemblyUnreadableError>();
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
    /// <see cref="CqlAssemblyInfo.ReadError"/> and the assembly binary it was given.
    /// </summary>
    private static void ShouldHoldNothingButTheReadError(CqlAssemblyInfo cqlAssemblyInfo, AssemblyBinary assembly)
    {
        cqlAssemblyInfo.AssemblyBinary.Should().BeSameAs(assembly);
        cqlAssemblyInfo.AssemblyName.Should().BeNull();
        cqlAssemblyInfo.Libraries.Should().BeEmpty();
        cqlAssemblyInfo.IsSupported.Should().BeFalse();
        cqlAssemblyInfo.HasReadErrors.Should().BeTrue();
    }

    /// <summary>
    /// The libraries that <see cref="CqlLibraryTypeRule.GetLibraryInfos"/>, the invoker's read through reflection,
    /// finds on a type of <paramref name="assembly"/>, loaded in a collectible context of its own.
    /// </summary>
    private static List<CqlLibraryInfo> LibraryInfosByReflection(AssemblyBinary assembly, string typeName)
    {
        var loadContext = new AssemblyLoadContext(nameof(LibraryInfosByReflection), isCollectible: true);
        try
        {
            var type = loadContext.LoadFromStream(new MemoryStream(assembly.AssemblyBytes!)).GetType(typeName, throwOnError: true)!;
            return CqlLibraryTypeRule.GetLibraryInfos(type);
        }
        finally
        {
            loadContext.Unload();
        }
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

    /// <summary>
    /// Builds a PE file with a single empty section and no CLI header, so it holds no .NET metadata, as a native
    /// library does.
    /// </summary>
    private sealed class PEFileWithoutMetadataBuilder() : PEBuilder(PEHeaderBuilder.CreateLibraryHeader(), deterministicIdProvider: null)
    {
        protected override ImmutableArray<Section> CreateSections() =>
            [new Section(".text", SectionCharacteristics.ContainsCode | SectionCharacteristics.MemRead | SectionCharacteristics.MemExecute)];

        protected override BlobBuilder SerializeSection(string name, SectionLocation location)
        {
            var section = new BlobBuilder();
            section.WriteInt32(0);
            return section;
        }

        protected override PEDirectoriesBuilder GetDirectories() => new();
    }

    /// <summary>
    /// The value blob a compiler writes for an attribute whose constructor takes two strings: the prolog <c>0x0001</c>,
    /// the two arguments as serialized strings, and a count of no named arguments.
    /// </summary>
    private static byte[] AttributeValue(string first, string second) =>
        [0x01, 0x00, .. SerializedString(first), .. SerializedString(second), 0x00, 0x00];

    private static byte[] SerializedString(string value)
    {
        var utf8 = System.Text.Encoding.UTF8.GetBytes(value);
        utf8.Length.Should().BeLessThan(0x80, "a longer string has a longer length prefix");
        return [(byte)utf8.Length, .. utf8];
    }

    /// <summary>
    /// A copy of <paramref name="assembly"/> in which <paramref name="change"/> has edited the one attribute value
    /// blob that equals <paramref name="value"/>, keeping its length.
    /// </summary>
    private static AssemblyBinary WithAttributeValueChanged(AssemblyBinary assembly, byte[] value, Action<byte[]> change)
    {
        byte[] assemblyBytes = [.. assembly.AssemblyBytes!];
        var offset = assemblyBytes.AsSpan().IndexOf(value);
        offset.Should().BeGreaterThanOrEqualTo(0).And.Be(assemblyBytes.AsSpan().LastIndexOf(value));

        var changed = value.ToArray();
        change(changed);
        changed.CopyTo(assemblyBytes, offset);
        return new AssemblyBinary(assemblyBytes);
    }

    /// <summary>
    /// Builds an assembly whose two types are each nested in the other, which no compiler writes: its NestedClass
    /// table makes their declaring types a cycle.
    /// </summary>
    private static AssemblyBinary AssemblyWithCyclicNestedTypes()
    {
        var metadata = new MetadataBuilder();
        metadata.AddModule(0, metadata.GetOrAddString("CyclicNestedTypes.dll"), metadata.GetOrAddGuid(Guid.NewGuid()), default, default);
        metadata.AddAssembly(
            metadata.GetOrAddString("CyclicNestedTypes"),
            new Version(1, 0, 0, 0),
            default,
            default,
            default,
            System.Reflection.AssemblyHashAlgorithm.None);

        var noFields = MetadataTokens.FieldDefinitionHandle(1);
        var noMethods = MetadataTokens.MethodDefinitionHandle(1);
        metadata.AddTypeDefinition(default, default, metadata.GetOrAddString("<Module>"), default, noFields, noMethods);
        var first = metadata.AddTypeDefinition(TypeAttributes.NestedPublic, default, metadata.GetOrAddString("First"), default, noFields, noMethods);
        var second = metadata.AddTypeDefinition(TypeAttributes.NestedPublic, default, metadata.GetOrAddString("Second"), default, noFields, noMethods);
        metadata.AddNestedType(first, second);
        metadata.AddNestedType(second, first);

        var image = new BlobBuilder();
        new ManagedPEBuilder(PEHeaderBuilder.CreateLibraryHeader(), new MetadataRootBuilder(metadata), new BlobBuilder()).Serialize(image);
        return new AssemblyBinary(image.ToArray());
    }

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
