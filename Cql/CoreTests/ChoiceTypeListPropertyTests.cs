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
using Hl7.Cql.Compiler;
using Hl7.Cql.Exceptions;
using Hl7.Cql.Fhir;
using Hl7.Cql.Invocation.Toolkit;
using Hl7.Cql.Invocation.Toolkit.Extensions;
using Hl7.Cql.Primitives;
using Hl7.Cql.Runtime;
using Hl7.Cql.ValueSets;
using Hl7.Fhir.Model;
using CqlElm = Hl7.Cql.Elm;
using ElmLibrary = Hl7.Cql.Elm.Library;

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

    private const string FhirNamespace = "http://hl7.org/fhir";
    private const string ChoiceScopedAlias = "Intervention";

    private static readonly FileInfo FixtureFile = new(Path.Combine("Input", "ELM", "Test", "ChoiceTypeListPropertyTest-1.0.0.json"));
    private static readonly FileInfo FhirHelpersFile = new(Path.Combine("Input", "ELM", "HL7", "FHIRHelpers-4.0.1.json"));

    private static LibrarySetInvoker _librarySetInvoker = null!;
    private static LibraryInvoker _library = null!;
    private static HashValueSetDictionary _valueSets = null!;

    [ClassInitialize]
    public static void Initialize(TestContext _)
    {
        _librarySetInvoker = new ElmToolkit()
                             .AddElmFiles(new[] { FhirHelpersFile })
                             .AddElmLibraries(MadieShapedFixture())
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
    /// The translator types the choice-scoped <c>reasonCode</c> read; the MADiE translator does not.
    /// The list recovery under test only runs for the untyped shape, so the fixture is stripped in
    /// code rather than by hand, and this test pins that the strip is still doing something: were
    /// the checked-in ELM to lose the result type, the other tests here would pass without
    /// exercising the recovery at all.
    /// </summary>
    [TestMethod]
    public void MadieShape_StripsTheResultTypeTheTranslatorEmits()
    {
        var translated = ChoiceScopedReasonCodeProperty(ElmLibrary.LoadFromJson(FixtureFile));
        var madie = ChoiceScopedReasonCodeProperty(MadieShapedFixture());

        translated.resultTypeSpecifier.Should().NotBeNull("the checked-in fixture is plain translator output, which types the read");
        madie.resultTypeSpecifier.Should().BeNull();
        madie.resultTypeName.Should().BeNull();
    }

    /// <summary>
    /// When every member of the choice resolves, the path's list cardinality is read off the
    /// members and the late-bound read is typed as that list.
    /// </summary>
    [TestMethod]
    public void EveryMemberResolves_RecoversTheListCardinality()
    {
        var allMembersResolve = GenerateCSharp(MadieShapedFixture());

        allMembersResolve.Should()
                         .Contain(
                             "LateBoundProperty<IEnumerable<CodeableConcept>>",
                             "every member of the choice resolves, so reasonCode's list cardinality can be read off them");
    }

    /// <summary>
    /// A choice member whose type cannot be resolved has unknown cardinality, so the list recovery
    /// must be abandoned rather than inferred from the resolvable subset: were the read typed as a
    /// list off the members that do resolve, a runtime value of the unresolvable alternative whose
    /// path is scalar would convert to <see langword="null"/> - the same silent-wrong-answer class
    /// this fix closes, pointed the other way.
    /// </summary>
    /// <remarks>
    /// Declining the recovery is an abstention, not a correct outcome. On translator output the
    /// scalar-typed read it leaves behind feeds a list-valued operator (<c>AnyInValueSet</c>), which
    /// the compiler rejects, so these two tests assert that the build fails rather than that a
    /// particular C# shape is emitted: a loud failure is the acceptable outcome here, and asserting
    /// a runtime value would pin a defect as correct behaviour. Handling this shape of input is a
    /// known remaining gap in #1636's coverage, not something this fix closes.
    /// </remarks>
    [TestMethod]
    public void UnresolvableChoiceMember_DeclinesTheListRecovery()
    {
        var oneMemberUnresolvable = WithMedicationRequestChoiceMemberReplaced(
            "ChoiceTypeUnresolvedMemberTest",
            () => new CqlElm.NamedTypeSpecifier(FhirNamespace, "UnresolvableIntervention"));

        var act = () => GenerateCSharp(oneMemberUnresolvable);

        act.Should()
           .Throw<CqlException<ExpressionBuildingError>>(
               "a member that does not resolve cannot be shown to make the path list-valued, and the scalar read left behind does not fit the list-valued operator");
    }

    /// <summary>
    /// The other arm of the same guard: a member that is itself a heterogeneous choice resolves,
    /// but to <see cref="object"/>, which is just as uninspectable for the path - so the recovery
    /// must be declined here too. See the remarks on
    /// <see cref="UnresolvableChoiceMember_DeclinesTheListRecovery"/> for why a build failure, not
    /// an emitted shape or a runtime result, is asserted.
    /// </summary>
    [TestMethod]
    public void NestedHeterogeneousChoiceMember_DeclinesTheListRecovery()
    {
        var oneMemberIsANestedChoice = WithMedicationRequestChoiceMemberReplaced(
            "ChoiceTypeNestedChoiceMemberTest",
            () => new CqlElm.ChoiceTypeSpecifier(
                new CqlElm.NamedTypeSpecifier(FhirNamespace, "MedicationRequest"),
                new CqlElm.NamedTypeSpecifier(FhirNamespace, "Condition")));

        var act = () => GenerateCSharp(oneMemberIsANestedChoice);

        act.Should()
           .Throw<CqlException<ExpressionBuildingError>>(
               "a nested heterogeneous choice collapses to object, which cannot be shown to make the path list-valued, and the scalar read left behind does not fit the list-valued operator");
    }

    private static string GenerateCSharp(ElmLibrary library) =>
        new ElmToolkit()
            .AddElmFiles(new[] { FhirHelpersFile })
            .AddElmLibraries(library)
            .CompileToAssemblies()
            .GetElmToCSharpResults()
            .Single(result => result.libraryIdentifier.ToString() == $"{library.identifier.id}-{library.identifier.version}")
            .cSharp;

    /// <summary>
    /// The checked-in fixture in the shape the MADiE translator emits for it: the <c>reasonCode</c>
    /// read off the choice-typed alias carries no result type, which leaves the choice type - erased
    /// to <see cref="object"/> - as the compiler's only source of information about the path.
    /// </summary>
    private static ElmLibrary MadieShapedFixture(string? libraryName = null)
    {
        var library = ElmLibrary.LoadFromJson(FixtureFile);
        if (libraryName is not null)
            library.identifier.id = libraryName;

        ChoiceScopedReasonCodeProperty(library).resultTypeSpecifier = null;
        ChoiceScopedReasonCodeProperty(library).resultTypeName = null;
        return library;
    }

    /// <summary>
    /// The MADiE-shaped fixture with the <c>MedicationRequest</c> member of the choice-typed alias's
    /// source type replaced by <paramref name="replacement"/>. Only the alias's source type is
    /// changed - that is the type the compiler consults for the path's cardinality - so the retrieves
    /// and the union keep their real types and the library still compiles. No CQL produces this ELM.
    /// </summary>
    private static ElmLibrary WithMedicationRequestChoiceMemberReplaced(string libraryName, Func<CqlElm.TypeSpecifier> replacement)
    {
        var library = MadieShapedFixture(libraryName);
        var medicationRequest = new CqlElm.NamedTypeSpecifier(FhirNamespace, "MedicationRequest");
        var source = FindNode<CqlElm.AliasedQuerySource>(library, s => s.alias == ChoiceScopedAlias);

        foreach (var typeSpecifier in new[] { source.resultTypeSpecifier, source.expression.resultTypeSpecifier })
        {
            Walk(typeSpecifier, node =>
            {
                if (node is not CqlElm.ChoiceTypeSpecifier { choice: { } members })
                    return false;

                for (var i = 0; i < members.Length; i++)
                {
                    if (members[i] is CqlElm.NamedTypeSpecifier named && named.name == medicationRequest.name)
                        members[i] = replacement();
                }

                // The replacement may itself name the member; do not descend into it.
                return true;
            });
        }

        return library;
    }

    private static CqlElm.Property ChoiceScopedReasonCodeProperty(ElmLibrary library) =>
        FindNode<CqlElm.Property>(library, p => p.path == "reasonCode" && p.scope == ChoiceScopedAlias);

    private static T FindNode<T>(ElmLibrary library, Func<T, bool> predicate)
        where T : class
    {
        T? found = null;
        Walk(library, node =>
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
