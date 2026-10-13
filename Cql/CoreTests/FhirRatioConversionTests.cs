/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable

using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.CodeGeneration.NET.Toolkit;
using Hl7.Cql.CodeGeneration.NET.Toolkit.Extensions;
using Hl7.Cql.Fhir;
using Hl7.Cql.Invocation.Toolkit;
using Hl7.Cql.Invocation.Toolkit.Extensions;
using Hl7.Cql.Primitives;
using Hl7.Cql.Runtime;
using Hl7.Fhir.Model;
using CqlElm = Hl7.Cql.Elm;
using ElmLibrary = Hl7.Cql.Elm.Library;

namespace CoreTests;

/// <summary>
/// A FHIR <c>Ratio</c> read from a resource evaluates to a System Ratio. A library reaches the
/// System type either through <c>FHIRHelpers.ToRatio</c>, which builds the Ratio from its two
/// converted quantities, or - when the ELM hands the compiler a FHIR Ratio where a System Ratio is
/// required, without that conversion - through the FHIR type converter.
/// </summary>
[TestClass]
public class FhirRatioConversionTests
{
    private const string LibraryIdentifier = "FhirRatioTest-1.0.0";
    private const string WithoutConversionLibraryName = "FhirRatioTestWithoutConversion";
    private const string ImplicitlyConvertedDefinition = "Observation Ratio Implicitly Converted";

    private static readonly FileInfo FixtureFile = new(Path.Combine("Input", "ELM", "Test", "FhirRatioTest-1.0.0.json"));
    private static readonly FileInfo FhirHelpersFile = new(Path.Combine("Input", "ELM", "HL7", "FHIRHelpers-4.0.1.json"));

    private static LibrarySetInvoker _librarySetInvoker = null!;
    private static LibraryInvoker _library = null!;

    /// <summary>
    /// Compiled on first use, so that a failure to compile it fails only the tests that use it.
    /// </summary>
    private static readonly Lazy<CompiledLibrary> WithoutConversion = new(CompileWithoutConversion);

    [ClassInitialize]
    public static void Initialize(TestContext _)
    {
        _librarySetInvoker = new ElmToolkit()
                             .AddElmFiles(new[] { FhirHelpersFile, FixtureFile })
                             .CreateLibrarySetInvoker();
        _library = _librarySetInvoker.LibraryInvokers[(CqlVersionedLibraryIdentifier)LibraryIdentifier]!;
    }

    [ClassCleanup]
    public static void Cleanup()
    {
        _librarySetInvoker?.Dispose();
        if (WithoutConversion.IsValueCreated)
            WithoutConversion.Value.LibrarySetInvoker.Dispose();
    }

    [TestMethod]
    public void ObservationValueRatio_EvaluatesToSystemRatio()
    {
        var observation = ObservationWithValue(new Ratio(new Quantity(5, "mg"), new Quantity(10, "mL")));

        var ratio = Invoke<CqlRatio>(_library, "Observation Ratio", observation);

        AssertRatio(ratio, 5m, "mg", 10m, "mL");
    }

    [TestMethod]
    public void ObservationValueOfAnotherType_EvaluatesToNull()
    {
        var observation = ObservationWithValue(new Quantity(5, "mg"));

        Invoke<CqlRatio>(_library, "Observation Ratio", observation).Should().BeNull();
    }

    [TestMethod]
    public void MedicationRequestDoseRateRatio_EvaluatesToSystemRatio()
    {
        var medicationRequest = new MedicationRequest
        {
            Id = "mr",
            Status = MedicationRequest.MedicationrequestStatus.Active,
            Intent = MedicationRequest.MedicationRequestIntent.Order,
            Subject = new ResourceReference("Patient/1"),
            DosageInstruction =
            [
                new Dosage
                {
                    DoseAndRate =
                    [
                        new Dosage.DoseAndRateComponent { Rate = new Ratio(new Quantity(3, "mg"), new Quantity(1, "mL")) },
                    ],
                },
            ],
        };

        var ratio = Invoke<CqlRatio>(_library, "Dose Rate Ratio", medicationRequest);

        AssertRatio(ratio, 3m, "mg", 1m, "mL");
    }

    /// <summary>
    /// The FHIR Ratio passed to a function over the System Ratio, with the implicit
    /// <c>FHIRHelpers.ToRatio</c> conversion the translator inserts.
    /// </summary>
    [TestMethod]
    public void ImplicitConversion_ThroughFhirHelpers_EvaluatesToSystemRatio()
    {
        var observation = ObservationWithValue(new Ratio(new Quantity(5, "mg"), new Quantity(10, "mL")));

        var ratio = Invoke<CqlRatio>(_library, ImplicitlyConvertedDefinition, observation);

        AssertRatio(ratio, 5m, "mg", 10m, "mL");
    }

    /// <summary>
    /// Without the FHIRHelpers conversion the compiled library converts the FHIR Ratio argument itself,
    /// through the FHIR type converter, and evaluates to the same ratio as the library that keeps it.
    /// </summary>
    [TestMethod]
    public void ImplicitConversion_ThroughTypeConverter_EvaluatesToSystemRatio()
    {
        var observation = ObservationWithValue(new Ratio(new Quantity(5, "mg"), new Quantity(10, "mL")));

        var ratio = Invoke<CqlRatio>(WithoutConversion.Value.Library, ImplicitlyConvertedDefinition, observation);

        AssertRatio(ratio, 5m, "mg", 10m, "mL");
    }

    /// <summary>
    /// A System Ratio requires both parts (CQL 1.5.3, Appendix B - CQL Reference, Types, Ratio:
    /// "The numerator and denominator elements must be present (i.e. can not be null)."), so the type
    /// converter turns a FHIR Ratio missing one into <see langword="null"/>.
    /// </summary>
    [TestMethod]
    public void ImplicitConversion_ThroughTypeConverter_RatioMissingAPart_EvaluatesToNull()
    {
        var observation = ObservationWithValue(new Ratio { Numerator = new Quantity(5, "mg") });

        Invoke<CqlRatio>(WithoutConversion.Value.Library, ImplicitlyConvertedDefinition, observation).Should().BeNull();
    }

    /// <summary>
    /// Pins that the library under the converter tests binds the conversion the way they assume: the
    /// <c>FHIRHelpers.ToRatio</c> call is gone from the ELM, and the generated C# converts the FHIR
    /// Ratio to a <see cref="CqlRatio"/> through the operators' type converter instead. Were either to
    /// stop holding, the converter tests above would pass without exercising the converter.
    /// </summary>
    [TestMethod]
    public void WithoutConversion_BindsTheTypeConverter()
    {
        var calledFunctions = new List<string>();
        Walk(ImplicitlyConvertedExpression(FixtureWithoutRatioConversion()), node =>
        {
            if (node is CqlElm.FunctionRef functionRef)
                calledFunctions.Add(functionRef.name);
            return false;
        });

        calledFunctions.Should().Equal("Ratio Of");
        WithoutConversion.Value.CSharp.Should().Contain("Convert<CqlRatio>(");
    }

    private sealed record CompiledLibrary(LibrarySetInvoker LibrarySetInvoker, LibraryInvoker Library, string CSharp);

    private static CompiledLibrary CompileWithoutConversion()
    {
        var elmToolkit = new ElmToolkit()
                         .AddElmFiles(new[] { FhirHelpersFile })
                         .AddElmLibraries(FixtureWithoutRatioConversion())
                         .CompileToAssemblies();
        var identifier = $"{WithoutConversionLibraryName}-1.0.0";
        var cSharp = elmToolkit.GetElmToCSharpResults()
                               .Single(result => result.libraryIdentifier.ToString() == identifier)
                               .cSharp;
        var librarySetInvoker = new InvocationToolkit()
                                .AddAssemblyBinaries(elmToolkit.GetElmToAssemblyResults().Select(r => new AssemblyBinary(r.assemblyBinary, r.debugSymbolsBinary)))
                                .CreateLibrarySetInvoker();
        return new(librarySetInvoker, librarySetInvoker.LibraryInvokers[(CqlVersionedLibraryIdentifier)identifier]!, cSharp);
    }

    /// <summary>
    /// The checked-in fixture with the <c>FHIRHelpers.ToRatio</c> call the translator inserts for the
    /// argument of <c>"Ratio Of"</c> replaced by its own argument, so that the function - which takes a
    /// System Ratio - receives the FHIR Ratio itself. No CQL produces this ELM.
    /// </summary>
    private static ElmLibrary FixtureWithoutRatioConversion()
    {
        var library = ElmLibrary.LoadFromJson(FixtureFile);
        library.identifier.id = WithoutConversionLibraryName;

        var ratioOf = FindNode<CqlElm.FunctionRef>(ImplicitlyConvertedExpression(library), f => f.name == "Ratio Of");
        var toRatio = (CqlElm.FunctionRef)ratioOf.operand.Single();
        toRatio.name.Should().Be("ToRatio");
        ratioOf.operand = [toRatio.operand.Single()];

        return library;
    }

    private static CqlElm.Expression ImplicitlyConvertedExpression(ElmLibrary library) =>
        library.statements.Single(statement => statement.name == ImplicitlyConvertedDefinition).expression;

    private static T FindNode<T>(object root, Func<T, bool> predicate)
        where T : class
    {
        T? found = null;
        Walk(root, node =>
        {
            if (found is null && node is T candidate && predicate(candidate))
                found = candidate;
            return found is not null;
        });

        return found ?? throw new AssertFailedException($"No {typeof(T).Name} matching the predicate in the fixture.");
    }

    /// <summary>
    /// Visits every node under <paramref name="root"/>, depth first. The visitor returns
    /// <see langword="true"/> to skip the children of the node it was given.
    /// </summary>
    private static void Walk(object root, Func<object, bool> visit) =>
        CqlElm.ElmTreeWalker.Create((_, node) => visit(node)).Start(root);

    private static T? Invoke<T>(LibraryInvoker library, string define, Resource resource)
    {
        var bundle = new Bundle();
        bundle.Entry.Add(new Bundle.EntryComponent { Resource = resource });
        var context = FhirCqlContext.ForBundle(bundle: bundle);
        return library.Invoke<T>(define, context);
    }

    private static Observation ObservationWithValue(DataType value) =>
        new()
        {
            Id = "obs",
            Status = ObservationStatus.Final,
            Code = new CodeableConcept("http://loinc.org", "14959-1"),
            Subject = new ResourceReference("Patient/1"),
            Value = value,
        };

    private static void AssertRatio(CqlRatio? ratio, decimal numeratorValue, string numeratorUnit, decimal denominatorValue, string denominatorUnit)
    {
        ratio.Should().NotBeNull();
        ratio!.numerator.Should().NotBeNull();
        ratio.numerator!.value.Should().Be(numeratorValue);
        ratio.numerator.unit.Should().Be(numeratorUnit);
        ratio.denominator.Should().NotBeNull();
        ratio.denominator!.value.Should().Be(denominatorValue);
        ratio.denominator.unit.Should().Be(denominatorUnit);
    }
}
