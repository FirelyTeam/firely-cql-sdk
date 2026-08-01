/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable

using Hl7.Cql.Fhir;
using Hl7.Cql.Operators;
using Hl7.Cql.Primitives;
using Hl7.Fhir.Model;

namespace CoreTests;

/// <summary>
/// The age operators resolve the patient type, the birth-date property and the patient retrieve once and reuse
/// them across calls. These tests pin down the behaviour that has to survive that: which patient is read, and what
/// happens when the data source holds none, several, or one without a birth date.
/// </summary>
[TestClass]
[TestCategory("UnitTest")]
public class AgeOperatorTests
{
    private static readonly CqlDate AsOf = new(2024, 6, 1);

    private static ICqlOperators OperatorsFor(params Resource[] resources)
    {
        var bundle = new Bundle { Type = Bundle.BundleType.Collection };
        foreach (var resource in resources)
            bundle.Entry.Add(new Bundle.EntryComponent { Resource = resource });

        return FhirCqlContext.ForBundle(bundle).Operators;
    }

    private static Patient PatientBornOn(string? birthDate, string id = "patient") =>
        new() { Id = id, BirthDate = birthDate };

    [TestMethod]
    public void AgeAt_WithOnePatient_CountsWholeYearsToTheAsOfDate()
    {
        var operators = OperatorsFor(PatientBornOn("1980-05-17"));

        Assert.AreEqual(44, operators.AgeAt(AsOf, "year"));
    }

    /// <summary>
    /// The birthday has not come round yet in the as-of year, so the count is one lower.
    /// </summary>
    [TestMethod]
    public void AgeAt_BeforeTheBirthdayInTheAsOfYear_CountsOneYearLess()
    {
        var operators = OperatorsFor(PatientBornOn("1980-12-31"));

        Assert.AreEqual(43, operators.AgeAt(AsOf, "year"));
    }

    [TestMethod]
    public void AgeAt_CalledRepeatedly_KeepsReturningTheSameAge()
    {
        var operators = OperatorsFor(PatientBornOn("1980-05-17"));

        // The retrieve and the property behind it are resolved once and reused; every later call has to see the
        // same patient as the first.
        for (var i = 0; i < 5; i++)
            Assert.AreEqual(44, operators.AgeAt(AsOf, "year"));
    }

    [TestMethod]
    public void AgeAt_WithNoPatient_IsNull()
    {
        var operators = OperatorsFor(new Observation { Id = "obs" });

        Assert.IsNull(operators.AgeAt(AsOf, "year"));
    }

    /// <summary>
    /// A CQL patient context is a single patient; several of them have no age to speak of.
    /// </summary>
    [TestMethod]
    public void AgeAt_WithMoreThanOnePatient_IsNull()
    {
        var operators = OperatorsFor(
            PatientBornOn("1980-05-17", "one"),
            PatientBornOn("1990-01-01", "two"));

        Assert.IsNull(operators.AgeAt(AsOf, "year"));
    }

    [TestMethod]
    public void AgeAt_WithAPatientWithoutABirthDate_IsNull()
    {
        var operators = OperatorsFor(PatientBornOn(null));

        Assert.IsNull(operators.AgeAt(AsOf, "year"));
    }

    [TestMethod]
    public void AgeAt_WithANullAsOfDate_IsNull()
    {
        var operators = OperatorsFor(PatientBornOn("1980-05-17"));

        Assert.IsNull(operators.AgeAt(null, "year"));
    }

    /// <summary>
    /// <c>Age</c> is <c>AgeAt</c> as of today, so it agrees with the age computed against the same date.
    /// </summary>
    [TestMethod]
    public void Age_AgreesWithAgeAtToday()
    {
        var operators = OperatorsFor(PatientBornOn("1980-05-17"));

        Assert.AreEqual(operators.AgeAt(operators.Today(), "year"), operators.Age("year"));
    }

    [TestMethod]
    public void Age_WithNoPatient_IsNull()
    {
        var operators = OperatorsFor(new Observation { Id = "obs" });

        Assert.IsNull(operators.Age("year"));
    }

    /// <summary>
    /// The two operators share one patient lookup, so neither may be affected by the other having run first.
    /// </summary>
    [TestMethod]
    public void AgeAndAgeAt_DoNotInterfereWithEachOther()
    {
        var operators = OperatorsFor(PatientBornOn("1980-05-17"));

        var ageFirst = operators.Age("year");
        Assert.AreEqual(44, operators.AgeAt(AsOf, "year"));
        Assert.AreEqual(ageFirst, operators.Age("year"));
    }
}
