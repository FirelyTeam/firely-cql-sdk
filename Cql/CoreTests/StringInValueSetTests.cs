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
using Hl7.Cql.Primitives;
using Hl7.Cql.Runtime;
using Hl7.Cql.ValueSets;
using Hl7.Cql.ValueSets.Errors;
using Hl7.Fhir.Specification.Source;
using FhirValueSet = Hl7.Fhir.Model.ValueSet;

namespace CoreTests;

/// <summary>
/// A code without a code system, such as a string, cannot say which system it is from. Tested against a value set that
/// holds codes from more than one system it is a run-time error (CQL §9.B, In (Valueset)); against a value set of one
/// system it answers as a code of that system. Every value set dictionary that answers it behaves the same.
/// </summary>
[TestClass]
public class StringInValueSetTests
{
    private const string ValueSetUri = "http://example.org/ValueSet/under-test";
    private const string Snomed = "http://snomed.info/sct";
    private const string Loinc = "http://loinc.org";

    private static readonly CqlCode[] OneSystem = [new("111", Snomed), new("222", Snomed)];

    private static readonly CqlCode[] SeveralSystems = [new("111", Snomed), new("222", Loinc)];

    /// <summary>The ways a membership test of a string reaches a value set of the given codes.</summary>
    public enum MembershipPath
    {
        /// <summary>The facade on its own, which does not know its canonical URI.</summary>
        InMemoryValueSet,

        /// <summary>A <see cref="HashValueSetDictionary"/> the value set was added to.</summary>
        HashValueSetDictionary,

        /// <summary>The facade a dictionary hands out for a value set, which asks the dictionary.</summary>
        CqlValueSetFacade,

        /// <summary>A <see cref="ValueSetSource"/> the codes were added to.</summary>
        ValueSetSourceAdded,

        /// <summary>A <see cref="ValueSetSource"/> that resolves the value set through its resource resolver.</summary>
        ValueSetSourceResolved,
    }

    private static Func<string, bool> MembershipTest(MembershipPath path, CqlCode[] codes)
    {
        switch (path)
        {
            case MembershipPath.InMemoryValueSet:
                return new InMemoryValueSet(codes).IsCodeInValueSet;

            case MembershipPath.HashValueSetDictionary:
            {
                var hash = new HashValueSetDictionary();
                hash.Add(ValueSetUri, codes);
                return code => hash.IsCodeInValueSet(ValueSetUri, code);
            }

            case MembershipPath.CqlValueSetFacade:
            {
                var hash = new HashValueSetDictionary();
                hash.Add(ValueSetUri, codes);
                return hash.GetValueSet(ValueSetUri).IsCodeInValueSet;
            }

            case MembershipPath.ValueSetSourceAdded:
            {
                var source = new ValueSetSource();
                source.Add(ValueSetUri, codes);
                return code => source.IsCodeInValueSet(ValueSetUri, code);
            }

            case MembershipPath.ValueSetSourceResolved:
                // A source per test, so the value set is resolved on the call under test rather than found cached.
                return code => new ValueSetSource(new InMemoryResourceResolver(ToFhirValueSet(codes)))
                    .IsCodeInValueSet(ValueSetUri, code);

            default:
                throw new ArgumentOutOfRangeException(nameof(path), path, null);
        }
    }

    private static FhirValueSet ToFhirValueSet(IEnumerable<CqlCode> codes) =>
        new()
        {
            Url = ValueSetUri,
            Expansion = new FhirValueSet.ExpansionComponent
            {
                Contains = codes.Select(c => new FhirValueSet.ContainsComponent { System = c.system, Code = c.code }).ToList()
            }
        };

    /// <summary>The value set the error names: a facade tested on its own does not know it.</summary>
    private static string? ExpectedValueSetUri(MembershipPath path) =>
        path == MembershipPath.InMemoryValueSet ? null : ValueSetUri;

    [TestMethod]
    [DataRow(MembershipPath.InMemoryValueSet)]
    [DataRow(MembershipPath.HashValueSetDictionary)]
    [DataRow(MembershipPath.CqlValueSetFacade)]
    [DataRow(MembershipPath.ValueSetSourceAdded)]
    [DataRow(MembershipPath.ValueSetSourceResolved)]
    public void ValueSetOfOneSystem_AnswersWithoutAnError(MembershipPath path)
    {
        var isIn = MembershipTest(path, OneSystem);

        isIn("111").Should().BeTrue();
        isIn("999").Should().BeFalse();
    }

    [TestMethod]
    [DataRow(MembershipPath.InMemoryValueSet)]
    [DataRow(MembershipPath.HashValueSetDictionary)]
    [DataRow(MembershipPath.CqlValueSetFacade)]
    [DataRow(MembershipPath.ValueSetSourceAdded)]
    [DataRow(MembershipPath.ValueSetSourceResolved)]
    public void ValueSetOfSeveralSystems_SignalsAnError(MembershipPath path)
    {
        var isIn = MembershipTest(path, SeveralSystems);

        // A code that matches one of the systems and a code that matches none are equally ambiguous.
        AssertAmbiguous(() => isIn("111"), ExpectedValueSetUri(path), "111");
        AssertAmbiguous(() => isIn("999"), ExpectedValueSetUri(path), "999");
    }

    [TestMethod]
    [DataRow(MembershipPath.InMemoryValueSet)]
    [DataRow(MembershipPath.HashValueSetDictionary)]
    [DataRow(MembershipPath.CqlValueSetFacade)]
    [DataRow(MembershipPath.ValueSetSourceAdded)]
    [DataRow(MembershipPath.ValueSetSourceResolved)]
    public void NullCode_IsNotInTheValueSet_WhateverItsSystems(MembershipPath path)
    {
        // CQL §9.B, In (Valueset): "If the code argument is null, the result is false."
        MembershipTest(path, OneSystem)(null!).Should().BeFalse();
        MembershipTest(path, SeveralSystems)(null!).Should().BeFalse();
    }

    [TestMethod]
    [DataRow(MembershipPath.InMemoryValueSet)]
    [DataRow(MembershipPath.HashValueSetDictionary)]
    [DataRow(MembershipPath.CqlValueSetFacade)]
    [DataRow(MembershipPath.ValueSetSourceAdded)]
    [DataRow(MembershipPath.ValueSetSourceResolved)]
    public void SystemsThatDifferOnlyInCase_AreOneSystem(MembershipPath path)
    {
        var isIn = MembershipTest(path, [new("111", Snomed), new("222", Snomed.ToUpperInvariant())]);

        isIn("222").Should().BeTrue();
    }

    [TestMethod]
    [DataRow(MembershipPath.InMemoryValueSet)]
    [DataRow(MembershipPath.HashValueSetDictionary)]
    [DataRow(MembershipPath.CqlValueSetFacade)]
    [DataRow(MembershipPath.ValueSetSourceAdded)]
    [DataRow(MembershipPath.ValueSetSourceResolved)]
    public void CodeWithoutASystem_DoesNotAddASystem(MembershipPath path)
    {
        var isIn = MembershipTest(path, [new("111", Snomed), new("444", null)]);

        isIn("444").Should().BeTrue();
        isIn("111").Should().BeTrue();
    }

    [TestMethod]
    public void OperatorsOfAnEvaluation_SignalAnEvaluationError_ForACodeWithoutASystem()
    {
        var valueSets = new HashValueSetDictionary();
        valueSets.Add(ValueSetUri, SeveralSystems);
        var operators = FhirCqlContext.ForBundle(valueSets: valueSets).Operators;
        var valueSet = new CqlValueSet(ValueSetUri, null);

        AssertAmbiguous(() => operators.StringInValueSet("111", valueSet), ValueSetUri, "111");
        AssertAmbiguous(() => operators.StringsInValueSet(["999", "111"], valueSet), ValueSetUri, "999");
        // The runtime tests a Code without a system as a string.
        AssertAmbiguous(() => operators.CodeInValueSet(new CqlCode("111", null), valueSet), ValueSetUri, "111");
        AssertAmbiguous(() => operators.ConceptInValueSet(new CqlConcept(new[] { new CqlCode("111", null) }), valueSet),
                        ValueSetUri, "111");

        // A Code that names its system is not ambiguous.
        operators.CodeInValueSet(new CqlCode("111", Snomed), valueSet).Should().BeTrue();
        operators.CodeInValueSet(new CqlCode("111", Loinc), valueSet).Should().BeFalse();

        ICqlError? caught = null;
        try
        {
            operators.StringInValueSet("111", valueSet);
        }
        catch (CqlException e) when (e.Error is ICqlEvaluationError)
        {
            caught = e.Error;
        }

        caught.Should().Be(new CqlAmbiguousStringInValueSetError(ValueSetUri, "111"));
    }

    [TestMethod]
    public void OperatorsOfAnEvaluation_AnswerAStringAgainstAValueSetOfOneSystem()
    {
        var valueSets = new HashValueSetDictionary();
        valueSets.Add(ValueSetUri, OneSystem);
        var operators = FhirCqlContext.ForBundle(valueSets: valueSets).Operators;
        var valueSet = new CqlValueSet(ValueSetUri, null);

        operators.StringInValueSet("111", valueSet).Should().BeTrue();
        operators.StringInValueSet("999", valueSet).Should().BeFalse();
        operators.CodeInValueSet(new CqlCode("222", null), valueSet).Should().BeTrue();
    }

    private static readonly CqlVersionedLibraryIdentifier MembershipLibrary =
        CqlVersionedLibraryIdentifier.ParseFromIdentifierAndVersion("StringMembership", "1.0.0");

    private static readonly Lazy<LibrarySetInvoker> Invoker = new(() =>
    {
        var cqlToolkit = new CqlToolkit()
                         .AddCqlLibraries(
                             new[]
                             {
                                 $$"""
                                 library StringMembership version '1.0.0'
                                 valueset "Under Test": '{{ValueSetUri}}'
                                 define "StringIn": '111' in "Under Test"
                                 define "CodeIn": Code { system: '{{Snomed}}', code: '111' } in "Under Test"
                                 """,
                             }.Select(CqlLibraryString.Parse))
                         .TranslateToElm();
        return new ElmToolkit().AddElmFromCqlToolkit(cqlToolkit).CreateLibrarySetInvoker();
    });

    private static object? Evaluate(CqlCode[] codes, string definition)
    {
        var valueSets = new HashValueSetDictionary();
        valueSets.Add(ValueSetUri, codes);
        return Invoker.Value.InvokeLibraryDefinition(FhirCqlContext.ForBundle(valueSets: valueSets), MembershipLibrary, definition);
    }

    [TestMethod]
    public void EvaluatingAStringInAValueSetOfSeveralSystems_SignalsAnEvaluationError()
    {
        var evaluate = () => Evaluate(SeveralSystems, "StringIn");

        var exception = evaluate.Should().Throw<CqlException<CqlAmbiguousStringInValueSetError>>().Which;

        exception.Error.Should().Be(new CqlAmbiguousStringInValueSetError(ValueSetUri, "111"));
        exception.EvaluationFrames.Should().Equal(new CqlEvaluationFrame("StringMembership", "1.0.0", "StringIn"));
    }

    [TestMethod]
    public void EvaluatingAStringInAValueSetOfOneSystem_AnswersTrue() =>
        Evaluate(OneSystem, "StringIn").Should().Be(true);

    [TestMethod]
    public void EvaluatingACodeWithItsSystemInAValueSetOfSeveralSystems_AnswersTrue() =>
        Evaluate(SeveralSystems, "CodeIn").Should().Be(true);

    [TestMethod]
    public void AmbiguousStringInValueSetError_MessageNamesTheCodeAndTheValueSet()
    {
        new CqlAmbiguousStringInValueSetError(ValueSetUri, "111").GetMessage().Should().StartWith(
            $"Whether '111' is in the value set '{ValueSetUri}' is ambiguous: the value set holds codes from more than " +
            "one code system");
        new CqlAmbiguousStringInValueSetError(null, "111").GetMessage().Should().StartWith(
            "Whether '111' is in the value set is ambiguous:");
    }

    private static void AssertAmbiguous(Func<object?> membershipTest, string? valueSetUri, string code)
    {
        var exception = Assert.ThrowsExactly<CqlException<CqlAmbiguousStringInValueSetError>>(() => membershipTest());
        exception.Error.ValueSetUri.Should().Be(valueSetUri);
        exception.Error.Code.Should().Be(code);
    }
}
