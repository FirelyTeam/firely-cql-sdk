/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.CodeGeneration.NET.Toolkit;
using Hl7.Cql.CodeGeneration.NET.Toolkit.Extensions;
using Hl7.Cql.CqlToElm;
using Hl7.Cql.CqlToElm.Toolkit;
using Hl7.Cql.CqlToElm.Toolkit.Extensions;
using Hl7.Cql.Exceptions;
using Hl7.Cql.Fhir;
using Hl7.Cql.Invocation.Toolkit;
using Hl7.Cql.Invocation.Toolkit.Extensions;
using Hl7.Cql.Operators;
using Hl7.Cql.Primitives;
using Hl7.Cql.Runtime;
using Hl7.Cql.ValueSets;
using Hl7.Cql.ValueSets.Errors;
using Hl7.Fhir.Model;

namespace CoreTests;

/// <summary>
/// <see cref="HashValueSetDictionary"/> is the dictionary a context uses when the host passes none. A membership test
/// against a value set it does not hold is a run-time error (CQL §9.B, In (Valueset)), while listing the codes of such a
/// value set gives none.
/// </summary>
[TestClass]
public class HashValueSetDictionaryLookupTests
{
    private const string KnownValueSet = "http://example.org/ValueSet/known";
    private const string UnknownValueSet = "http://example.org/ValueSet/unknown";
    private const string CodeSystem = "http://snomed.info/sct";

    private static readonly CqlVersionedLibraryIdentifier MembershipLibrary =
        CqlVersionedLibraryIdentifier.ParseFromIdentifierAndVersion("ValueSetMembership", "1.0.0");

    private static readonly Lazy<LibrarySetInvoker> Invoker = new(() =>
    {
        var cqlToolkit = new CqlToolkit()
                         .AddCqlLibraries(
                             new[]
                             {
                                 $$"""
                                 library ValueSetMembership version '1.0.0'
                                 valueset "Unknown": '{{UnknownValueSet}}'
                                 define "StringIn": '111' in "Unknown"
                                 define "CodeIn": Code { system: '{{CodeSystem}}', code: '111' } in "Unknown"
                                 define "Expanded": Count("Unknown")
                                 """,
                             }.Select(CqlLibraryString.Parse))
                         .TranslateToElm();
        return new ElmToolkit().AddElmFromCqlToolkit(cqlToolkit).CreateLibrarySetInvoker();
    });

    private static HashValueSetDictionary CreateDictionary()
    {
        var dictionary = new HashValueSetDictionary();
        dictionary.Add(KnownValueSet, [new CqlCode("111", CodeSystem)]);
        return dictionary;
    }

    [TestMethod]
    public void CodeOverload_OfAnUnknownValueSet_SignalsAnError() =>
        AssertUnresolved(() => CreateDictionary().IsCodeInValueSet(UnknownValueSet, new CqlCode("111", CodeSystem)));

    [TestMethod]
    public void CodeAndSystemOverload_OfAnUnknownValueSet_SignalsAnError() =>
        AssertUnresolved(() => CreateDictionary().IsCodeInValueSet(UnknownValueSet, "111", CodeSystem));

    [TestMethod]
    public void StringOverload_OfAnUnknownValueSet_SignalsAnError() =>
        AssertUnresolved(() => CreateDictionary().IsCodeInValueSet(UnknownValueSet, "111"));

    [TestMethod]
    public void KnownValueSet_AnswersWithoutAnError()
    {
        var dictionary = CreateDictionary();

        Assert.IsTrue(dictionary.IsCodeInValueSet(KnownValueSet, new CqlCode("111", CodeSystem)));
        Assert.IsFalse(dictionary.IsCodeInValueSet(KnownValueSet, new CqlCode("999", CodeSystem)));
        Assert.IsTrue(dictionary.IsCodeInValueSet(KnownValueSet, "111", CodeSystem));
        Assert.IsFalse(dictionary.IsCodeInValueSet(KnownValueSet, "999", CodeSystem));
        Assert.IsTrue(dictionary.IsCodeInValueSet(KnownValueSet, "111"));
        Assert.IsFalse(dictionary.IsCodeInValueSet(KnownValueSet, "999"),
            "A value set the dictionary holds answers a miss with 'false'; only an unknown one is an error.");
    }

    [TestMethod]
    public void TryGetCodesInValueSet_OfAnUnknownValueSet_ReturnsFalse()
    {
        Assert.IsFalse(CreateDictionary().TryGetCodesInValueSet(UnknownValueSet, out var codes));
        Assert.IsNull(codes);
    }

    [TestMethod]
    public void OperatorsOfAContextWithoutValueSets_SignalAnEvaluationError()
    {
        // A context created without value sets gets an empty HashValueSetDictionary.
        var operators = FhirCqlContext.ForBundle().Operators;
        var valueSet = new CqlValueSet(UnknownValueSet, null);

        AssertUnresolved(() => operators.CodeInValueSet(new CqlCode("111", CodeSystem), valueSet));
        AssertUnresolved(() => operators.CodeInValueSet(new CqlCode("111", null), valueSet));
        AssertUnresolved(() => operators.StringInValueSet("111", valueSet));
        AssertUnresolved(() => operators.ConceptInValueSet(new CqlConcept(new[] { new CqlCode("111", CodeSystem) }), valueSet));
        AssertUnresolved(() => operators.CodeInList(new CqlCode("111", CodeSystem), operators.CreateValueSetFacade(valueSet)));

        ICqlError? caught = null;
        try
        {
            operators.StringInValueSet("111", valueSet);
        }
        catch (CqlException e) when (e.Error is ICqlEvaluationError)
        {
            caught = e.Error;
        }

        Assert.AreEqual(new CqlUnresolvedValueSetError(UnknownValueSet), caught);
    }

    [TestMethod]
    public void ExpandingAnUnknownValueSet_InAContextWithoutValueSets_GivesNoCodes() =>
        FhirCqlContext.ForBundle().Operators.CreateValueSetFacade(new CqlValueSet(UnknownValueSet, null))
                      .Should().BeEmpty();

    [TestMethod]
    public void RetrieveFilteredByAValueSet_InAContextWithoutValueSets_SignalsAnError()
    {
        // A retrieve filtered by a value set tests each candidate's code for membership.
        var bundle = new Bundle { Type = Bundle.BundleType.Collection };
        bundle.Entry.Add(new Bundle.EntryComponent { Resource = new Condition { Id = "c1", Code = new CodeableConcept(CodeSystem, "111") } });
        var operators = FhirCqlContext.ForBundle(bundle).Operators;
        var parameters = new RetrieveParameters(null, new CqlValueSet(UnknownValueSet, null), null,
                                                "http://hl7.org/fhir/StructureDefinition/Condition");

        AssertUnresolved(() => operators.Retrieve<Condition>(parameters)?.ToList());
    }

    [TestMethod]
    [DataRow("StringIn")]
    [DataRow("CodeIn")]
    public void EvaluatingAMembershipTest_InAContextWithoutValueSets_SignalsAnEvaluationError(string definition)
    {
        var invoke = () => Invoker.Value.InvokeLibraryDefinition(FhirCqlContext.ForBundle(), MembershipLibrary, definition);

        var exception = invoke.Should().Throw<CqlException<CqlUnresolvedValueSetError>>().Which;

        exception.Error.ValueSetUri.Should().Be(UnknownValueSet);
        exception.EvaluationFrames.Should().Equal(new CqlEvaluationFrame("ValueSetMembership", "1.0.0", definition));
    }

    [TestMethod]
    public void EvaluatingAnExpansion_InAContextWithoutValueSets_GivesNoCodes() =>
        // "Unknown" as an argument of Count is expanded to its codes.
        Invoker.Value.InvokeLibraryDefinition(FhirCqlContext.ForBundle(), MembershipLibrary, "Expanded")
               .Should().Be(0);

    private static void AssertUnresolved(Func<object?> membershipTest)
    {
        var exception = Assert.ThrowsExactly<CqlException<CqlUnresolvedValueSetError>>(() => membershipTest());
        Assert.AreEqual(UnknownValueSet, exception.Error.ValueSetUri);
    }
}
