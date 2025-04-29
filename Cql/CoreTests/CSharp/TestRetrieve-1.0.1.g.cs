using System;
using System.Linq;
using System.Collections.Generic;
using Hl7.Cql.Runtime;
using Hl7.Cql.Primitives;
using Hl7.Cql.Abstractions;
using Hl7.Cql.ValueSets;
using Hl7.Cql.Iso8601;
using System.Reflection;
using Hl7.Cql.Operators;
using Hl7.Fhir.Model;
using Range = Hl7.Fhir.Model.Range;
using Task = Hl7.Fhir.Model.Task;

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "3.0.0.0")]
[CqlLibrary("TestRetrieve", "1.0.1")]
public partial class TestRetrieve_1_0_1 : ILibrary, ISingleton<TestRetrieve_1_0_1>
{
    private TestRetrieve_1_0_1() {}

    public static TestRetrieve_1_0_1 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "TestRetrieve";
    public string Version => "1.0.1";
    public ILibrary[] Dependencies => [FHIRHelpers_4_0_1.Instance, TestRetrieveInclude_1_0_1.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    #region ValueSet: HIV
    [CqlValueSetDefinition(
        definitionName: "HIV",
        valueSetId: "2.16.840.1.113883.3.464.1003.120.12.1003",
        valueSetVersion: null)]
    public CqlValueSet HIV(CqlContext context) => _HIV;

    private static readonly CqlValueSet _HIV = new CqlValueSet("2.16.840.1.113883.3.464.1003.120.12.1003", null);
    #endregion

    #region ValueSet: Syphilis
    [CqlValueSetDefinition(
        definitionName: "Syphilis",
        valueSetId: "2.16.840.1.113883.3.464.1003.112.12.1002",
        valueSetVersion: null)]
    public CqlValueSet Syphilis(CqlContext context) => _Syphilis;

    private static readonly CqlValueSet _Syphilis = new CqlValueSet("2.16.840.1.113883.3.464.1003.112.12.1002", null);
    #endregion

    #region ValueSet: Complications of Pregnancy, Childbirth and the Puerperium
    [CqlValueSetDefinition(
        definitionName: "Complications of Pregnancy, Childbirth and the Puerperium",
        valueSetId: "2.16.840.1.113883.3.464.1003.111.12.1012",
        valueSetVersion: null)]
    public CqlValueSet Complications_of_Pregnancy__Childbirth_and_the_Puerperium(CqlContext context) => _Complications_of_Pregnancy__Childbirth_and_the_Puerperium;

    private static readonly CqlValueSet _Complications_of_Pregnancy__Childbirth_and_the_Puerperium = new CqlValueSet("2.16.840.1.113883.3.464.1003.111.12.1012", null);
    #endregion

    #region ValueSet: Pregnancy Test
    [CqlValueSetDefinition(
        definitionName: "Pregnancy Test",
        valueSetId: "2.16.840.1.113883.3.464.1003.111.12.1011",
        valueSetVersion: null)]
    public CqlValueSet Pregnancy_Test(CqlContext context) => _Pregnancy_Test;

    private static readonly CqlValueSet _Pregnancy_Test = new CqlValueSet("2.16.840.1.113883.3.464.1003.111.12.1011", null);
    #endregion

    #region ValueSet: Pap Test
    [CqlValueSetDefinition(
        definitionName: "Pap Test",
        valueSetId: "2.16.840.1.113883.3.464.1003.108.12.1017",
        valueSetVersion: null)]
    public CqlValueSet Pap_Test(CqlContext context) => _Pap_Test;

    private static readonly CqlValueSet _Pap_Test = new CqlValueSet("2.16.840.1.113883.3.464.1003.108.12.1017", null);
    #endregion

    #region ValueSet: Lab Tests During Pregnancy
    [CqlValueSetDefinition(
        definitionName: "Lab Tests During Pregnancy",
        valueSetId: "2.16.840.1.113883.3.464.1003.111.12.1007",
        valueSetVersion: null)]
    public CqlValueSet Lab_Tests_During_Pregnancy(CqlContext context) => _Lab_Tests_During_Pregnancy;

    private static readonly CqlValueSet _Lab_Tests_During_Pregnancy = new CqlValueSet("2.16.840.1.113883.3.464.1003.111.12.1007", null);
    #endregion

    #region ValueSet: Lab Tests for Sexually Transmitted Infections
    [CqlValueSetDefinition(
        definitionName: "Lab Tests for Sexually Transmitted Infections",
        valueSetId: "2.16.840.1.113883.3.464.1003.110.12.1051",
        valueSetVersion: null)]
    public CqlValueSet Lab_Tests_for_Sexually_Transmitted_Infections(CqlContext context) => _Lab_Tests_for_Sexually_Transmitted_Infections;

    private static readonly CqlValueSet _Lab_Tests_for_Sexually_Transmitted_Infections = new CqlValueSet("2.16.840.1.113883.3.464.1003.110.12.1051", null);
    #endregion

    #region ValueSet: Chlamydia Screening
    [CqlValueSetDefinition(
        definitionName: "Chlamydia Screening",
        valueSetId: "2.16.840.1.113883.3.464.1003.110.12.1052",
        valueSetVersion: null)]
    public CqlValueSet Chlamydia_Screening(CqlContext context) => _Chlamydia_Screening;

    private static readonly CqlValueSet _Chlamydia_Screening = new CqlValueSet("2.16.840.1.113883.3.464.1003.110.12.1052", null);
    #endregion

    #region ValueSet: Palliative Care Assessment
    [CqlValueSetDefinition(
        definitionName: "Palliative Care Assessment",
        valueSetId: "https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.2225",
        valueSetVersion: null)]
    public CqlValueSet Palliative_Care_Assessment(CqlContext context) => _Palliative_Care_Assessment;

    private static readonly CqlValueSet _Palliative_Care_Assessment = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.2225", null);
    #endregion

    #region ValueSet: Palliative Care Encounter
    [CqlValueSetDefinition(
        definitionName: "Palliative Care Encounter",
        valueSetId: "https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1450",
        valueSetVersion: null)]
    public CqlValueSet Palliative_Care_Encounter(CqlContext context) => _Palliative_Care_Encounter;

    private static readonly CqlValueSet _Palliative_Care_Encounter = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1450", null);
    #endregion

    #region ValueSet: Palliative Care Intervention
    [CqlValueSetDefinition(
        definitionName: "Palliative Care Intervention",
        valueSetId: "https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.2224",
        valueSetVersion: null)]
    public CqlValueSet Palliative_Care_Intervention(CqlContext context) => _Palliative_Care_Intervention;

    private static readonly CqlValueSet _Palliative_Care_Intervention = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.2224", null);
    #endregion

    #endregion ValueSets

    #region Codes

    #region Code: Encounter for palliative care
    [CqlCodeDefinition(
        definitionName: "Encounter for palliative care",
        codeId: "Z51.5",
        codeSystem: "http://hl7.org/fhir/sid/icd-10-cm")]
    public CqlCode Encounter_for_palliative_care(CqlContext context) => _Encounter_for_palliative_care;

    private static readonly CqlCode _Encounter_for_palliative_care = new CqlCode("Z51.5", "http://hl7.org/fhir/sid/icd-10-cm", default, default);
    #endregion

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition(
        definitionName: "ICD-10")]
    public CqlCode[] ICD_10(CqlContext context)
    {
        CqlCode[] gzzzzzy_ = [
            new CqlCode("Z51.5", "http://hl7.org/fhir/sid/icd-10-cm", default, default),
        ];

        return gzzzzzy_;
    }


    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition(
        definitionName: "MeasurementPeriod")]
    public object MeasurementPeriod(CqlContext context)
    {
        CqlDateTime gzzzzzz_ = context.Operators.DateTime(2013, 1, 1, 0, 0, 0, 0, default);
        CqlDateTime hzzzzza_ = context.Operators.DateTime(2014, 1, 1, 0, 0, 0, 0, default);
        CqlInterval<CqlDateTime> hzzzzzb_ = context.Operators.Interval(gzzzzzz_, hzzzzza_, true, false);
        object hzzzzzc_ = context.ResolveParameter("TestRetrieve-1.0.1", "MeasurementPeriod", hzzzzzb_);

        return hzzzzzc_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition(
        definitionName: "Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> hzzzzzd_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient hzzzzze_ = context.Operators.SingletonFrom<Patient>(hzzzzzd_);

        return hzzzzze_;
    }


    [CqlExpressionDefinition(
        definitionName: "InDemographic")]
    public IEnumerable<Patient> InDemographic(CqlContext context)
    {
        IEnumerable<Patient> hzzzzzf_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));

        return hzzzzzf_;
    }


    [CqlExpressionDefinition(
        definitionName: "SexuallyActive")]
    public bool? SexuallyActive(CqlContext context)
    {
        IEnumerable<Condition> hzzzzzg_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? hzzzzzh_ = context.Operators.Exists<Condition>(hzzzzzg_);
        IEnumerable<ServiceRequest> hzzzzzi_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/ServiceRequest"));
        bool? hzzzzzj_ = context.Operators.Exists<ServiceRequest>(hzzzzzi_);
        bool? hzzzzzk_ = context.Operators.Or(hzzzzzh_, hzzzzzj_);

        return hzzzzzk_;
    }


    #endregion Expressions

}
