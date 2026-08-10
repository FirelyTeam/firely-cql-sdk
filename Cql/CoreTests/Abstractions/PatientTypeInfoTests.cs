/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable

using Hl7.Cql.Abstractions;

namespace CoreTests.Abstractions;

[TestClass]
[TestCategory("UnitTest")]
public class PatientTypeInfoTests
{
    [TestMethod]
    public void Lookups_AreEvaluatedOnceAcrossRepeatedReads()
    {
        var typeCounter = 0;
        var birthDateCounter = 0;
        var expectedGetter = (Func<object, object?>)(patient => ((TestPatient)patient).BirthDate);

        var patientTypeInfo = new PatientTypeInfo(
            resolveType: () =>
            {
                typeCounter++;
                return typeof(TestPatient);
            },
            resolveBirthDateGetter: _ =>
            {
                birthDateCounter++;
                return expectedGetter;
            });

        _ = patientTypeInfo.Type;
        _ = patientTypeInfo.Type;
        _ = patientTypeInfo.BirthDateGetter;
        _ = patientTypeInfo.BirthDateGetter;

        patientTypeInfo.Type.Should().Be(typeof(TestPatient));
        patientTypeInfo.BirthDateGetter.Should().BeSameAs(expectedGetter);
        typeCounter.Should().Be(1);
        birthDateCounter.Should().Be(1);
    }

    [TestMethod]
    public void BirthDateGetter_IsNullWithoutInvokingResolver_WhenPatientTypeIsNull()
    {
        var birthDateCounter = 0;

        var patientTypeInfo = new PatientTypeInfo(
            resolveType: () => null,
            resolveBirthDateGetter: _ =>
            {
                birthDateCounter++;
                return _ => null;
            });

        patientTypeInfo.BirthDateGetter.Should().BeNull();
        birthDateCounter.Should().Be(0);
    }

    private sealed class TestPatient
    {
        public DateTime? BirthDate { get; set; }
    }
}
