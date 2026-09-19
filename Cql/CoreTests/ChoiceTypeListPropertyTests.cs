/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable

using Hl7.Cql.CodeGeneration.NET.Toolkit;
using Hl7.Cql.CodeGeneration.NET.Toolkit.Extensions;
using Hl7.Cql.Fhir;
using Hl7.Cql.Invocation.Toolkit;
using Hl7.Cql.Invocation.Toolkit.Extensions;
using Hl7.Cql.Primitives;
using Hl7.Cql.Runtime;
using Hl7.Cql.ValueSets;
using Hl7.Fhir.Model;

namespace CoreTests;

/// <summary>
/// A union of two resource types is a CQL choice type, which the generator erases to
/// <see cref="object"/>, so a property of the union's elements can only be reached by late
/// binding. Late binding has to preserve the property's cardinality: read as a scalar, a
/// list-valued element yields a value that no longer converts, and the filter then evaluates
/// against <see langword="null"/> instead of against the element's actual codes - a wrong answer
/// rather than a failure.
/// </summary>
[TestClass]
public class ChoiceTypeListPropertyTests
{
    private const string ReasonsValueSet = "http://fire.ly/ValueSet/late-bound-reasons";
    private const string CodeSystem = "http://fire.ly/CodeSystem/late-bound-reasons";
    private const string InValueSetCode = "E66.01";
    private const string OutOfValueSetCode = "Z00.00";

    private static LibrarySetInvoker _librarySetInvoker = null!;
    private static LibraryInvoker _library = null!;
    private static HashValueSetDictionary _valueSets = null!;

    [ClassInitialize]
    public static void Initialize(TestContext _)
    {
        _librarySetInvoker = new ElmToolkit()
                             .AddElmFiles((FileInfo[])
                             [
                                 new(Path.Combine("Input", "ELM", "Test", "ChoiceTypeListPropertyTest-1.0.0.json")),
                                 new(Path.Combine("Input", "ELM", "HL7", "FHIRHelpers-4.0.1.json")),
                             ])
                             .CreateLibrarySetInvoker();

        _library = _librarySetInvoker.LibraryInvokers[(CqlVersionedLibraryIdentifier)"ChoiceTypeListPropertyTest-1.0.0"]!;

        _valueSets = new HashValueSetDictionary();
        _valueSets.Add(ReasonsValueSet, [new CqlCode(InValueSetCode, CodeSystem)]);
    }

    [ClassCleanup]
    public static void Cleanup() => _librarySetInvoker?.Dispose();

    [TestMethod]
    public void ChoiceTypedSource_MatchesOnListValuedProperty()
    {
        var bundle = BundleOf(
            ServiceRequestWithReasons(InValueSetCode),
            MedicationRequestWithReasons(InValueSetCode));

        var matches = Invoke("Interventions With Reason", bundle);

        matches.Should().HaveCount(2, "both resources carry a reasonCode that is in the value set");
    }

    /// <summary>
    /// The matching code is the second entry, so a late-bound read that kept only the list's first
    /// element would miss it too.
    /// </summary>
    [TestMethod]
    public void ChoiceTypedSource_MatchesOnAnyElementOfTheList()
    {
        var bundle = BundleOf(ServiceRequestWithReasons(OutOfValueSetCode, InValueSetCode));

        Invoke("Interventions With Reason", bundle).Should().HaveCount(1);
    }

    [TestMethod]
    public void ChoiceTypedSource_DoesNotMatchWhenNoCodeIsInTheValueSet()
    {
        var bundle = BundleOf(
            ServiceRequestWithReasons(OutOfValueSetCode),
            MedicationRequestWithReasons(OutOfValueSetCode));

        Invoke("Interventions With Reason", bundle).Should().BeEmpty();
    }

    /// <summary>
    /// The strongly typed control: a single retrieve resolves <c>reasonCode</c> at design time, so
    /// this path never goes through late binding. It pins what the choice-typed definition above
    /// has to agree with.
    /// </summary>
    [TestMethod]
    public void StronglyTypedSource_MatchesOnListValuedProperty()
    {
        var matching = new Procedure { ReasonCode = [Concept(InValueSetCode)] };
        var nonMatching = new Procedure { ReasonCode = [Concept(OutOfValueSetCode)] };

        Invoke("Procedures With Reason", BundleOf(matching, nonMatching)).Should().HaveCount(1);
    }

    private static IEnumerable<object> Invoke(string define, Bundle bundle)
    {
        var context = FhirCqlContext.ForBundle(bundle: bundle, valueSets: _valueSets);
        return _library.Invoke<IEnumerable<object>>(define, context)
               ?? throw new AssertFailedException($"'{define}' returned null.");
    }

    private static Bundle BundleOf(params Resource[] resources)
    {
        var bundle = new Bundle();
        foreach (var resource in resources)
            bundle.Entry.Add(new Bundle.EntryComponent { Resource = resource });
        return bundle;
    }

    private static ServiceRequest ServiceRequestWithReasons(params string[] codes) =>
        new()
        {
            Status = RequestStatus.Completed,
            Intent = RequestIntent.Order,
            Subject = new ResourceReference("Patient/1"),
            ReasonCode = [.. codes.Select(Concept)],
        };

    private static MedicationRequest MedicationRequestWithReasons(params string[] codes) =>
        new()
        {
            Status = MedicationRequest.MedicationrequestStatus.Completed,
            Intent = MedicationRequest.MedicationRequestIntent.Order,
            Subject = new ResourceReference("Patient/1"),
            ReasonCode = [.. codes.Select(Concept)],
        };

    private static CodeableConcept Concept(string code) => new(CodeSystem, code);
}
