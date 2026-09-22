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
            ServiceRequestWithReasons("sr", InValueSetCode),
            MedicationRequestWithReasons("mr", InValueSetCode));

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
        var bundle = BundleOf(ServiceRequestWithReasons("sr", OutOfValueSetCode, InValueSetCode));

        Invoke("Interventions With Reason", bundle).Should().HaveCount(1);
    }

    [TestMethod]
    public void ChoiceTypedSource_DoesNotMatchWhenNoCodeIsInTheValueSet()
    {
        var bundle = BundleOf(
            ServiceRequestWithReasons("sr", OutOfValueSetCode),
            MedicationRequestWithReasons("mr", OutOfValueSetCode));

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
        var matching = new Procedure { Id = "match", ReasonCode = [Concept(InValueSetCode)] };
        var nonMatching = new Procedure { Id = "no-match", ReasonCode = [Concept(OutOfValueSetCode)] };

        Invoke("Procedures With Reason", BundleOf(matching, nonMatching)).Should().HaveCount(1);
    }

    /// <summary>
    /// A choice member whose type cannot be resolved has unknown cardinality, so the list recovery
    /// must be abandoned rather than inferred from the resolvable subset: were the read typed as a
    /// list off the members that do resolve, a runtime value of the unresolvable alternative whose
    /// path is scalar would convert to <see langword="null"/> - the same silent-wrong-answer class
    /// this fix closes, pointed the other way.
    /// </summary>
    /// <remarks>
    /// These two tests assert the emitted C#, not a runtime result, because declining the recovery
    /// is an abstention, not a correct outcome: the <see cref="object"/>-typed emission still wraps
    /// a list-valued <c>reasonCode</c> in a singleton and converts it to <see langword="null"/>, so
    /// there is no runtime value these fixtures get right, and asserting one would pin a defect as
    /// correct behaviour. The abstention restores the pre-fix behaviour rather than inventing a new
    /// wrong answer, but it is a known remaining gap in #1636's coverage, not a complete fix for
    /// this shape of input.
    /// </remarks>
    [TestMethod]
    public void UnresolvableChoiceMember_DeclinesTheListRecovery()
    {
        var allMembersResolve = GenerateCSharp("ChoiceTypeListPropertyTest");
        var oneMemberUnresolvable = GenerateCSharp("ChoiceTypeUnresolvedMemberTest");

        allMembersResolve.Should()
                         .Contain(
                             "LateBoundProperty<IEnumerable<CodeableConcept>>",
                             "every member of the choice resolves, so reasonCode's list cardinality can be read off them");

        oneMemberUnresolvable.Should()
                             .NotContain(
                                 "LateBoundProperty<IEnumerable<",
                                 "a member that does not resolve cannot be shown to make the path list-valued");
        oneMemberUnresolvable.Should()
                             .Contain(
                                 "LateBoundProperty<object>",
                                 "the read falls back to the erased type the choice already has");
    }

    /// <summary>
    /// The other arm of the same guard: a member that is itself a heterogeneous choice resolves,
    /// but to <see cref="object"/>, which is just as uninspectable for the path - so the recovery
    /// must be declined here too. See the remarks on
    /// <see cref="UnresolvableChoiceMember_DeclinesTheListRecovery"/> for why the emitted C#, not a
    /// runtime result, is asserted.
    /// </summary>
    [TestMethod]
    public void NestedHeterogeneousChoiceMember_DeclinesTheListRecovery()
    {
        var oneMemberIsANestedChoice = GenerateCSharp("ChoiceTypeNestedChoiceMemberTest");

        oneMemberIsANestedChoice.Should()
                                .NotContain(
                                    "LateBoundProperty<IEnumerable<",
                                    "a nested heterogeneous choice collapses to object, which cannot be shown to make the path list-valued");
        oneMemberIsANestedChoice.Should()
                                .Contain(
                                    "LateBoundProperty<object>",
                                    "the read falls back to the erased type the choice already has");
    }

    private static string GenerateCSharp(string libraryName) =>
        new ElmToolkit()
            .AddElmFiles((FileInfo[])
            [
                new(Path.Combine("Input", "ELM", "Test", $"{libraryName}-1.0.0.json")),
                new(Path.Combine("Input", "ELM", "HL7", "FHIRHelpers-4.0.1.json")),
            ])
            .CompileToAssemblies()
            .GetElmToCSharpResults()
            .Single(result => result.libraryIdentifier.ToString() == $"{libraryName}-1.0.0")
            .cSharp;

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

    // Every resource carries an id: a union eliminates duplicates, and resources that differ in
    // nothing else collapse into one, which has nothing to do with what is under test here.
    private static ServiceRequest ServiceRequestWithReasons(string id, params string[] codes) =>
        new()
        {
            Id = id,
            Status = RequestStatus.Completed,
            Intent = RequestIntent.Order,
            Subject = new ResourceReference("Patient/1"),
            ReasonCode = [.. codes.Select(Concept)],
        };

    private static MedicationRequest MedicationRequestWithReasons(string id, params string[] codes) =>
        new()
        {
            Id = id,
            Status = MedicationRequest.MedicationrequestStatus.Completed,
            Intent = MedicationRequest.MedicationRequestIntent.Order,
            Subject = new ResourceReference("Patient/1"),
            ReasonCode = [.. codes.Select(Concept)],
        };

    private static CodeableConcept Concept(string code) => new(CodeSystem, code);
}
