/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable

using Hl7.Cql.Abstractions;
using Hl7.Cql.Compiler.Infrastructure;

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
        var expectedBirthDateProperty = ReflectionUtility.PropertyOf(() => default(TestPatient)!.BirthDate);

        var patientTypeInfo = new PatientTypeInfo(
            resolveType: () =>
            {
                typeCounter++;
                return typeof(TestPatient);
            },
            resolveBirthDateProperty: _ =>
            {
                birthDateCounter++;
                return expectedBirthDateProperty;
            });

        _ = patientTypeInfo.Type;
        _ = patientTypeInfo.Type;
        _ = patientTypeInfo.BirthDateProperty;
        _ = patientTypeInfo.BirthDateProperty;

        typeCounter.Should().Be(1);
        birthDateCounter.Should().Be(1);
    }

    [TestMethod]
    public void BirthDateProperty_IsNullWithoutInvokingResolver_WhenPatientTypeIsNull()
    {
        var birthDateCounter = 0;

        var patientTypeInfo = new PatientTypeInfo(
            resolveType: () => null,
            resolveBirthDateProperty: _ =>
            {
                birthDateCounter++;
                return ReflectionUtility.PropertyOf(() => default(TestPatient)!.BirthDate);
            });

        patientTypeInfo.BirthDateProperty.Should().BeNull();
        birthDateCounter.Should().Be(0);
    }

    private sealed class TestPatient
    {
        public DateTime? BirthDate { get; set; }
    }
}
