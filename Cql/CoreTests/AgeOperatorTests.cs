/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */


using Hl7.Cql.Abstractions;
using Hl7.Cql.Fhir;
using Hl7.Cql.Operators;
using Hl7.Cql.Primitives;
using Hl7.Cql.Runtime;
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

    /// <summary>
    /// The birth-date resolve must happen only once across repeated age-operator calls, not once per call —
    /// that is the point of the memoization. A retrieve that counted more than once would mean the memoization
    /// had been bypassed.
    /// </summary>
    [TestMethod]
    public void AgeAt_CalledRepeatedly_RetrievesPatientOnce()
    {
        var retrieveCount = 0;
        var countingDataSource = new CountingDataSource(
            delegate { retrieveCount++; return [PatientBornOn("1980-05-17")]; });

        var operators = FhirCqlContext.WithDataSource(source: countingDataSource).Operators;

        for (var i = 0; i < 5; i++)
            operators.AgeAt(AsOf, "year");

        retrieveCount.Should().Be(1);
    }

    private sealed class CountingDataSource(Func<IEnumerable<object>> retrieve) : IDataSource
    {
        public IEnumerable<T> Retrieve<T>(RetrieveParameters? parameters = null) where T : class =>
            retrieve().OfType<T>();
    }

    #region A type resolver that cannot name the patient

    /// <summary>
    /// A model binding that has no patient type at all is a programming error, not missing data, and must still be
    /// reported as one — and must name the member that came back empty.
    /// </summary>
    [TestMethod]
    public void AgeOperators_WithoutAPatientType_Throw()
    {
        var operators = CqlOperators.Create(new IncompleteTypeResolver { HasPatientType = false });

        Assert.ThrowsException<InvalidOperationException>(() => operators.AgeAt(AsOf, "year"))
              .Message.Should().Contain(nameof(TypeResolver.PatientType));
        Assert.ThrowsException<InvalidOperationException>(() => operators.Age("year"))
              .Message.Should().Contain(nameof(TypeResolver.PatientType));
    }

    [TestMethod]
    public void AgeOperators_WithoutABirthDateGetter_Throw()
    {
        var operators = CqlOperators.Create(new IncompleteTypeResolver { HasPatientType = true });

        Assert.ThrowsException<InvalidOperationException>(() => operators.AgeAt(AsOf, "year"))
              .Message.Should().Contain(nameof(TypeResolver.PatientBirthDateGetter));
        Assert.ThrowsException<InvalidOperationException>(() => operators.Age("year"))
              .Message.Should().Contain(nameof(TypeResolver.PatientBirthDateGetter));
    }

    private sealed class IncompleteTypeResolver : BaseTypeResolver
    {
        public bool HasPatientType { get; init; }

        internal override PatientTypeInfo CreatePatientTypeInfo() =>
            new PatientTypeInfo(
                resolveType: () => HasPatientType ? typeof(Patient) : null,
                resolveBirthDateGetter: _ => null);

        internal override IEnumerable<Assembly> ModelAssemblies => throw new NotImplementedException();

        internal override IEnumerable<string> ModelNamespaces => throw new NotImplementedException();

        internal override PropertyInfo? GetPrimaryCodePath(string typeSpecifier) => throw new NotImplementedException();

        internal override bool ShouldUseSourceObject(Type type, string propertyName) => true;
    }

    #endregion
}
