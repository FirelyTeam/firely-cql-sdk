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
[CqlLibrary("ChlamydiaScreeninginWomenFHIR", "0.1.000")]
public partial class ChlamydiaScreeninginWomenFHIR_0_1_000 : ILibrary, ISingleton<ChlamydiaScreeninginWomenFHIR_0_1_000>
{
    private ChlamydiaScreeninginWomenFHIR_0_1_000() {}

    public static ChlamydiaScreeninginWomenFHIR_0_1_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "ChlamydiaScreeninginWomenFHIR";
    public string Version => "0.1.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, QICoreCommon_2_1_000.Instance, SupplementalDataElements_3_5_000.Instance, Hospice_6_12_000.Instance, CumulativeMedicationDuration_4_1_000.Instance, Status_1_8_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    #region ValueSet: Chlamydia Screening
    [CqlValueSetDefinition(
        definitionName: "Chlamydia Screening",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1052",
        valueSetVersion: null)]
    public CqlValueSet Chlamydia_Screening(CqlContext context) => _Chlamydia_Screening;

    private static readonly CqlValueSet _Chlamydia_Screening = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1052", null);
    #endregion

    #region ValueSet: Complications of Pregnancy, Childbirth and the Puerperium
    [CqlValueSetDefinition(
        definitionName: "Complications of Pregnancy, Childbirth and the Puerperium",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1012",
        valueSetVersion: null)]
    public CqlValueSet Complications_of_Pregnancy__Childbirth_and_the_Puerperium(CqlContext context) => _Complications_of_Pregnancy__Childbirth_and_the_Puerperium;

    private static readonly CqlValueSet _Complications_of_Pregnancy__Childbirth_and_the_Puerperium = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1012", null);
    #endregion

    #region ValueSet: Contraceptive Medications
    [CqlValueSetDefinition(
        definitionName: "Contraceptive Medications",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1080",
        valueSetVersion: null)]
    public CqlValueSet Contraceptive_Medications(CqlContext context) => _Contraceptive_Medications;

    private static readonly CqlValueSet _Contraceptive_Medications = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1080", null);
    #endregion

    #region ValueSet: Diagnoses Used to Indicate Sexual Activity
    [CqlValueSetDefinition(
        definitionName: "Diagnoses Used to Indicate Sexual Activity",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1018",
        valueSetVersion: null)]
    public CqlValueSet Diagnoses_Used_to_Indicate_Sexual_Activity(CqlContext context) => _Diagnoses_Used_to_Indicate_Sexual_Activity;

    private static readonly CqlValueSet _Diagnoses_Used_to_Indicate_Sexual_Activity = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1018", null);
    #endregion

    #region ValueSet: Diagnostic Studies During Pregnancy
    [CqlValueSetDefinition(
        definitionName: "Diagnostic Studies During Pregnancy",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1008",
        valueSetVersion: null)]
    public CqlValueSet Diagnostic_Studies_During_Pregnancy(CqlContext context) => _Diagnostic_Studies_During_Pregnancy;

    private static readonly CqlValueSet _Diagnostic_Studies_During_Pregnancy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1008", null);
    #endregion

    #region ValueSet: HIV
    [CqlValueSetDefinition(
        definitionName: "HIV",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1003",
        valueSetVersion: null)]
    public CqlValueSet HIV(CqlContext context) => _HIV;

    private static readonly CqlValueSet _HIV = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1003", null);
    #endregion

    #region ValueSet: Home Healthcare Services
    [CqlValueSetDefinition(
        definitionName: "Home Healthcare Services",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016",
        valueSetVersion: null)]
    public CqlValueSet Home_Healthcare_Services(CqlContext context) => _Home_Healthcare_Services;

    private static readonly CqlValueSet _Home_Healthcare_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", null);
    #endregion

    #region ValueSet: Isotretinoin
    [CqlValueSetDefinition(
        definitionName: "Isotretinoin",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1143",
        valueSetVersion: null)]
    public CqlValueSet Isotretinoin(CqlContext context) => _Isotretinoin;

    private static readonly CqlValueSet _Isotretinoin = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1143", null);
    #endregion

    #region ValueSet: Lab Tests During Pregnancy
    [CqlValueSetDefinition(
        definitionName: "Lab Tests During Pregnancy",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1007",
        valueSetVersion: null)]
    public CqlValueSet Lab_Tests_During_Pregnancy(CqlContext context) => _Lab_Tests_During_Pregnancy;

    private static readonly CqlValueSet _Lab_Tests_During_Pregnancy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1007", null);
    #endregion

    #region ValueSet: Lab Tests for Sexually Transmitted Infections
    [CqlValueSetDefinition(
        definitionName: "Lab Tests for Sexually Transmitted Infections",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1051",
        valueSetVersion: null)]
    public CqlValueSet Lab_Tests_for_Sexually_Transmitted_Infections(CqlContext context) => _Lab_Tests_for_Sexually_Transmitted_Infections;

    private static readonly CqlValueSet _Lab_Tests_for_Sexually_Transmitted_Infections = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1051", null);
    #endregion

    #region ValueSet: Office Visit
    [CqlValueSetDefinition(
        definitionName: "Office Visit",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001",
        valueSetVersion: null)]
    public CqlValueSet Office_Visit(CqlContext context) => _Office_Visit;

    private static readonly CqlValueSet _Office_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);
    #endregion

    #region ValueSet: Virtual Encounter
    [CqlValueSetDefinition(
        definitionName: "Virtual Encounter",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089",
        valueSetVersion: null)]
    public CqlValueSet Virtual_Encounter(CqlContext context) => _Virtual_Encounter;

    private static readonly CqlValueSet _Virtual_Encounter = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", null);
    #endregion

    #region ValueSet: Pap Test
    [CqlValueSetDefinition(
        definitionName: "Pap Test",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1017",
        valueSetVersion: null)]
    public CqlValueSet Pap_Test(CqlContext context) => _Pap_Test;

    private static readonly CqlValueSet _Pap_Test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1017", null);
    #endregion

    #region ValueSet: Pregnancy Test
    [CqlValueSetDefinition(
        definitionName: "Pregnancy Test",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1011",
        valueSetVersion: null)]
    public CqlValueSet Pregnancy_Test(CqlContext context) => _Pregnancy_Test;

    private static readonly CqlValueSet _Pregnancy_Test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1011", null);
    #endregion

    #region ValueSet: Preventive Care Services Established Office Visit, 18 and Up
    [CqlValueSetDefinition(
        definitionName: "Preventive Care Services Established Office Visit, 18 and Up",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025",
        valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Established_Office_Visit__18_and_Up(CqlContext context) => _Preventive_Care_Services_Established_Office_Visit__18_and_Up;

    private static readonly CqlValueSet _Preventive_Care_Services_Established_Office_Visit__18_and_Up = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", null);
    #endregion

    #region ValueSet: Preventive Care Services Initial Office Visit, 18 and Up
    [CqlValueSetDefinition(
        definitionName: "Preventive Care Services Initial Office Visit, 18 and Up",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023",
        valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up(CqlContext context) => _Preventive_Care_Services_Initial_Office_Visit__18_and_Up;

    private static readonly CqlValueSet _Preventive_Care_Services_Initial_Office_Visit__18_and_Up = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", null);
    #endregion

    #region ValueSet: Preventive Care Services, Initial Office Visit, 0 to 17
    [CqlValueSetDefinition(
        definitionName: "Preventive Care Services, Initial Office Visit, 0 to 17",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022",
        valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services__Initial_Office_Visit__0_to_17(CqlContext context) => _Preventive_Care_Services__Initial_Office_Visit__0_to_17;

    private static readonly CqlValueSet _Preventive_Care_Services__Initial_Office_Visit__0_to_17 = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022", null);
    #endregion

    #region ValueSet: Preventive Care, Established Office Visit, 0 to 17
    [CqlValueSetDefinition(
        definitionName: "Preventive Care, Established Office Visit, 0 to 17",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024",
        valueSetVersion: null)]
    public CqlValueSet Preventive_Care__Established_Office_Visit__0_to_17(CqlContext context) => _Preventive_Care__Established_Office_Visit__0_to_17;

    private static readonly CqlValueSet _Preventive_Care__Established_Office_Visit__0_to_17 = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024", null);
    #endregion

    #region ValueSet: Procedures Used to Indicate Sexual Activity
    [CqlValueSetDefinition(
        definitionName: "Procedures Used to Indicate Sexual Activity",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1017",
        valueSetVersion: null)]
    public CqlValueSet Procedures_Used_to_Indicate_Sexual_Activity(CqlContext context) => _Procedures_Used_to_Indicate_Sexual_Activity;

    private static readonly CqlValueSet _Procedures_Used_to_Indicate_Sexual_Activity = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1017", null);
    #endregion

    #region ValueSet: Telephone Visits
    [CqlValueSetDefinition(
        definitionName: "Telephone Visits",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080",
        valueSetVersion: null)]
    public CqlValueSet Telephone_Visits(CqlContext context) => _Telephone_Visits;

    private static readonly CqlValueSet _Telephone_Visits = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", null);
    #endregion

    #region ValueSet: XRay Study
    [CqlValueSetDefinition(
        definitionName: "XRay Study",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1034",
        valueSetVersion: null)]
    public CqlValueSet XRay_Study(CqlContext context) => _XRay_Study;

    private static readonly CqlValueSet _XRay_Study = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1034", null);
    #endregion

    #endregion ValueSets

    #region Codes

    #region Code: Female
    [CqlCodeDefinition(
        definitionName: "Female",
        codeId: "F",
        codeSystem: "http://terminology.hl7.org/CodeSystem/v3-AdministrativeGender")]
    public CqlCode Female(CqlContext context) => _Female;

    private static readonly CqlCode _Female = new CqlCode("F", "http://terminology.hl7.org/CodeSystem/v3-AdministrativeGender", default, default);
    #endregion

    #region Code: Have you ever had vaginal intercourse [PhenX]
    [CqlCodeDefinition(
        definitionName: "Have you ever had vaginal intercourse [PhenX]",
        codeId: "64728-9",
        codeSystem: "http://loinc.org")]
    public CqlCode Have_you_ever_had_vaginal_intercourse__PhenX_(CqlContext context) => _Have_you_ever_had_vaginal_intercourse__PhenX_;

    private static readonly CqlCode _Have_you_ever_had_vaginal_intercourse__PhenX_ = new CqlCode("64728-9", "http://loinc.org", default, default);
    #endregion

    #region Code: Yes (qualifier value)
    [CqlCodeDefinition(
        definitionName: "Yes (qualifier value)",
        codeId: "373066001",
        codeSystem: "http://snomed.info/sct")]
    public CqlCode Yes__qualifier_value_(CqlContext context) => _Yes__qualifier_value_;

    private static readonly CqlCode _Yes__qualifier_value_ = new CqlCode("373066001", "http://snomed.info/sct", default, default);
    #endregion

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition(
        definitionName: "AdministrativeGender")]
    public CqlCode[] AdministrativeGender(CqlContext context)
    {
        CqlCode[] lzzzzzzzzzzzzzx_ = [
            new CqlCode("F", "http://terminology.hl7.org/CodeSystem/v3-AdministrativeGender", default, default),
        ];

        return lzzzzzzzzzzzzzx_;
    }


    [CqlCodeSystemDefinition(
        definitionName: "LOINC")]
    public CqlCode[] LOINC(CqlContext context)
    {
        CqlCode[] lzzzzzzzzzzzzzy_ = [
            new CqlCode("64728-9", "http://loinc.org", default, default),
        ];

        return lzzzzzzzzzzzzzy_;
    }


    [CqlCodeSystemDefinition(
        definitionName: "SNOMEDCT")]
    public CqlCode[] SNOMEDCT(CqlContext context)
    {
        CqlCode[] lzzzzzzzzzzzzzz_ = [
            new CqlCode("373066001", "http://snomed.info/sct", default, default),
        ];

        return lzzzzzzzzzzzzzz_;
    }


    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition(
        definitionName: "Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime mzzzzzzzzzzzzza_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime mzzzzzzzzzzzzzb_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> mzzzzzzzzzzzzzc_ = context.Operators.Interval(mzzzzzzzzzzzzza_, mzzzzzzzzzzzzzb_, true, true);
        object mzzzzzzzzzzzzzd_ = context.ResolveParameter("ChlamydiaScreeninginWomenFHIR-0.1.000", "Measurement Period", mzzzzzzzzzzzzzc_);

        return (CqlInterval<CqlDateTime>)mzzzzzzzzzzzzzd_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition(
        definitionName: "Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> mzzzzzzzzzzzzze_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient mzzzzzzzzzzzzzf_ = context.Operators.SingletonFrom<Patient>(mzzzzzzzzzzzzze_);

        return mzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? mzzzzzzzzzzzzzg_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return mzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> mzzzzzzzzzzzzzh_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return mzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? mzzzzzzzzzzzzzi_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return mzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode mzzzzzzzzzzzzzj_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return mzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition(
        definitionName: "Qualifying Encounters")]
    public IEnumerable<Encounter> Qualifying_Encounters(CqlContext context)
    {
        CqlValueSet mzzzzzzzzzzzzzk_ = this.Office_Visit(context);
        IEnumerable<Encounter> mzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, mzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet mzzzzzzzzzzzzzm_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> mzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, mzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> mzzzzzzzzzzzzzo_ = context.Operators.Union<Encounter>(mzzzzzzzzzzzzzl_, mzzzzzzzzzzzzzn_);
        CqlValueSet mzzzzzzzzzzzzzp_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> mzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, mzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet mzzzzzzzzzzzzzr_ = this.Preventive_Care_Services__Initial_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> mzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, mzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> mzzzzzzzzzzzzzt_ = context.Operators.Union<Encounter>(mzzzzzzzzzzzzzq_, mzzzzzzzzzzzzzs_);
        IEnumerable<Encounter> mzzzzzzzzzzzzzu_ = context.Operators.Union<Encounter>(mzzzzzzzzzzzzzo_, mzzzzzzzzzzzzzt_);
        CqlValueSet mzzzzzzzzzzzzzv_ = this.Preventive_Care__Established_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> mzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, mzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet mzzzzzzzzzzzzzx_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter> mzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, mzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> mzzzzzzzzzzzzzz_ = context.Operators.Union<Encounter>(mzzzzzzzzzzzzzw_, mzzzzzzzzzzzzzy_);
        IEnumerable<Encounter> nzzzzzzzzzzzzza_ = context.Operators.Union<Encounter>(mzzzzzzzzzzzzzu_, mzzzzzzzzzzzzzz_);
        CqlValueSet nzzzzzzzzzzzzzb_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> nzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, nzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet nzzzzzzzzzzzzzd_ = this.Virtual_Encounter(context);
        IEnumerable<Encounter> nzzzzzzzzzzzzze_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, nzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> nzzzzzzzzzzzzzf_ = context.Operators.Union<Encounter>(nzzzzzzzzzzzzzc_, nzzzzzzzzzzzzze_);
        IEnumerable<Encounter> nzzzzzzzzzzzzzg_ = context.Operators.Union<Encounter>(nzzzzzzzzzzzzza_, nzzzzzzzzzzzzzf_);
        IEnumerable<Encounter> nzzzzzzzzzzzzzh_ = Status_1_8_000.Instance.isEncounterPerformed(context, nzzzzzzzzzzzzzg_);
        bool? nzzzzzzzzzzzzzi_(Encounter ValidEncounters)
        {
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzk_ = this.Measurement_Period(context);
            Period nzzzzzzzzzzzzzl_ = ValidEncounters?.Period;
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzzzzzzzzzl_);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.toInterval(context, nzzzzzzzzzzzzzm_ as object);
            bool? nzzzzzzzzzzzzzo_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(nzzzzzzzzzzzzzk_, nzzzzzzzzzzzzzn_, "day");

            return nzzzzzzzzzzzzzo_;
        };
        IEnumerable<Encounter> nzzzzzzzzzzzzzj_ = context.Operators.Where<Encounter>(nzzzzzzzzzzzzzh_, nzzzzzzzzzzzzzi_);

        return nzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has Assessments Identifying Sexual Activity")]
    public bool? Has_Assessments_Identifying_Sexual_Activity(CqlContext context)
    {
        CqlCode nzzzzzzzzzzzzzp_ = this.Have_you_ever_had_vaginal_intercourse__PhenX_(context);
        IEnumerable<CqlCode> nzzzzzzzzzzzzzq_ = context.Operators.ToList<CqlCode>(nzzzzzzzzzzzzzp_);
        IEnumerable<Observation> nzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, nzzzzzzzzzzzzzq_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> nzzzzzzzzzzzzzs_ = Status_1_8_000.Instance.isAssessmentPerformed(context, nzzzzzzzzzzzzzr_);
        bool? nzzzzzzzzzzzzzt_(Observation SexualActivityAssessment)
        {
            DataType nzzzzzzzzzzzzzw_ = SexualActivityAssessment?.Value;
            object nzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzw_);
            CqlCode nzzzzzzzzzzzzzy_ = this.Yes__qualifier_value_(context);
            CqlConcept nzzzzzzzzzzzzzz_ = context.Operators.ConvertCodeToConcept(nzzzzzzzzzzzzzy_);
            bool? ozzzzzzzzzzzzza_ = context.Operators.Equivalent(nzzzzzzzzzzzzzx_ as CqlConcept, nzzzzzzzzzzzzzz_);
            DataType ozzzzzzzzzzzzzb_ = SexualActivityAssessment?.Effective;
            object ozzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzb_);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.toInterval(context, ozzzzzzzzzzzzzc_);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzze_()
            {
                bool ozzzzzzzzzzzzzh_()
                {
                    CqlInterval<CqlDateTime> ozzzzzzzzzzzzzi_ = this.Measurement_Period(context);
                    CqlDateTime ozzzzzzzzzzzzzj_ = context.Operators.End(ozzzzzzzzzzzzzi_);

                    return ozzzzzzzzzzzzzj_ is null;
                };
                if (ozzzzzzzzzzzzzh_())
                {
                    return default;
                }
                else
                {
                    CqlInterval<CqlDateTime> ozzzzzzzzzzzzzk_ = this.Measurement_Period(context);
                    CqlDateTime ozzzzzzzzzzzzzl_ = context.Operators.End(ozzzzzzzzzzzzzk_);
                    CqlDateTime ozzzzzzzzzzzzzn_ = context.Operators.End(ozzzzzzzzzzzzzk_);
                    CqlInterval<CqlDateTime> ozzzzzzzzzzzzzo_ = context.Operators.Interval(ozzzzzzzzzzzzzl_, ozzzzzzzzzzzzzn_, true, true);

                    return ozzzzzzzzzzzzzo_;
                }
            };
            bool? ozzzzzzzzzzzzzf_ = context.Operators.SameOrBefore(ozzzzzzzzzzzzzd_, ozzzzzzzzzzzzze_(), default);
            bool? ozzzzzzzzzzzzzg_ = context.Operators.And(ozzzzzzzzzzzzza_, ozzzzzzzzzzzzzf_);

            return ozzzzzzzzzzzzzg_;
        };
        IEnumerable<Observation> nzzzzzzzzzzzzzu_ = context.Operators.Where<Observation>(nzzzzzzzzzzzzzs_, nzzzzzzzzzzzzzt_);
        bool? nzzzzzzzzzzzzzv_ = context.Operators.Exists<Observation>(nzzzzzzzzzzzzzu_);

        return nzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has Diagnoses Identifying Sexual Activity")]
    public bool? Has_Diagnoses_Identifying_Sexual_Activity(CqlContext context)
    {
        CqlValueSet ozzzzzzzzzzzzzp_ = this.Diagnoses_Used_to_Indicate_Sexual_Activity(context);
        IEnumerable<Condition> ozzzzzzzzzzzzzq_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ozzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet ozzzzzzzzzzzzzr_ = this.HIV(context);
        IEnumerable<Condition> ozzzzzzzzzzzzzs_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ozzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> ozzzzzzzzzzzzzt_ = context.Operators.Union<Condition>(ozzzzzzzzzzzzzq_, ozzzzzzzzzzzzzs_);
        CqlValueSet ozzzzzzzzzzzzzu_ = this.Complications_of_Pregnancy__Childbirth_and_the_Puerperium(context);
        IEnumerable<Condition> ozzzzzzzzzzzzzv_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ozzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> ozzzzzzzzzzzzzw_ = context.Operators.Union<Condition>(ozzzzzzzzzzzzzt_, ozzzzzzzzzzzzzv_);
        bool? ozzzzzzzzzzzzzx_(Condition SexualActivityDiagnosis)
        {
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, SexualActivityDiagnosis);
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzzb_ = this.Measurement_Period(context);
            bool? pzzzzzzzzzzzzzc_ = context.Operators.Overlaps(pzzzzzzzzzzzzza_, pzzzzzzzzzzzzzb_, default);

            return pzzzzzzzzzzzzzc_;
        };
        IEnumerable<Condition> ozzzzzzzzzzzzzy_ = context.Operators.Where<Condition>(ozzzzzzzzzzzzzw_, ozzzzzzzzzzzzzx_);
        bool? ozzzzzzzzzzzzzz_ = context.Operators.Exists<Condition>(ozzzzzzzzzzzzzy_);

        return ozzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has Active Contraceptive Medications")]
    public bool? Has_Active_Contraceptive_Medications(CqlContext context)
    {
        CqlValueSet pzzzzzzzzzzzzzd_ = this.Contraceptive_Medications(context);
        IEnumerable<MedicationRequest> pzzzzzzzzzzzzze_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, pzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> pzzzzzzzzzzzzzg_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, pzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> pzzzzzzzzzzzzzh_ = context.Operators.Union<MedicationRequest>(pzzzzzzzzzzzzze_, pzzzzzzzzzzzzzg_);
        IEnumerable<MedicationRequest> pzzzzzzzzzzzzzi_ = Status_1_8_000.Instance.isMedicationActive(context, pzzzzzzzzzzzzzh_);
        bool? pzzzzzzzzzzzzzj_(MedicationRequest ActiveContraceptives)
        {
            CqlInterval<CqlDate> pzzzzzzzzzzzzzm_ = CumulativeMedicationDuration_4_1_000.Instance.medicationRequestPeriod(context, ActiveContraceptives);
            CqlDate pzzzzzzzzzzzzzn_ = pzzzzzzzzzzzzzm_?.low;
            CqlDateTime pzzzzzzzzzzzzzo_ = context.Operators.ConvertDateToDateTime(pzzzzzzzzzzzzzn_);
            CqlDate pzzzzzzzzzzzzzq_ = pzzzzzzzzzzzzzm_?.high;
            CqlDateTime pzzzzzzzzzzzzzr_ = context.Operators.ConvertDateToDateTime(pzzzzzzzzzzzzzq_);
            bool? pzzzzzzzzzzzzzt_ = pzzzzzzzzzzzzzm_?.lowClosed;
            bool? pzzzzzzzzzzzzzv_ = pzzzzzzzzzzzzzm_?.highClosed;
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzzw_ = context.Operators.Interval(pzzzzzzzzzzzzzo_, pzzzzzzzzzzzzzr_, pzzzzzzzzzzzzzt_, pzzzzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzzx_ = this.Measurement_Period(context);
            bool? pzzzzzzzzzzzzzy_ = context.Operators.Overlaps(pzzzzzzzzzzzzzw_, pzzzzzzzzzzzzzx_, default);

            return pzzzzzzzzzzzzzy_;
        };
        IEnumerable<MedicationRequest> pzzzzzzzzzzzzzk_ = context.Operators.Where<MedicationRequest>(pzzzzzzzzzzzzzi_, pzzzzzzzzzzzzzj_);
        bool? pzzzzzzzzzzzzzl_ = context.Operators.Exists<MedicationRequest>(pzzzzzzzzzzzzzk_);

        return pzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has Ordered Contraceptive Medications")]
    public bool? Has_Ordered_Contraceptive_Medications(CqlContext context)
    {
        CqlValueSet pzzzzzzzzzzzzzz_ = this.Contraceptive_Medications(context);
        IEnumerable<MedicationRequest> qzzzzzzzzzzzzza_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, pzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> qzzzzzzzzzzzzzc_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, pzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> qzzzzzzzzzzzzzd_ = context.Operators.Union<MedicationRequest>(qzzzzzzzzzzzzza_, qzzzzzzzzzzzzzc_);
        IEnumerable<MedicationRequest> qzzzzzzzzzzzzze_ = Status_1_8_000.Instance.isMedicationOrder(context, qzzzzzzzzzzzzzd_);
        bool? qzzzzzzzzzzzzzf_(MedicationRequest OrderedContraceptives)
        {
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzi_ = this.Measurement_Period(context);
            FhirDateTime qzzzzzzzzzzzzzj_ = OrderedContraceptives?.AuthoredOnElement;
            CqlDateTime qzzzzzzzzzzzzzk_ = context.Operators.Convert<CqlDateTime>(qzzzzzzzzzzzzzj_);
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.toInterval(context, qzzzzzzzzzzzzzk_ as object);
            bool? qzzzzzzzzzzzzzm_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(qzzzzzzzzzzzzzi_, qzzzzzzzzzzzzzl_, "day");

            return qzzzzzzzzzzzzzm_;
        };
        IEnumerable<MedicationRequest> qzzzzzzzzzzzzzg_ = context.Operators.Where<MedicationRequest>(qzzzzzzzzzzzzze_, qzzzzzzzzzzzzzf_);
        bool? qzzzzzzzzzzzzzh_ = context.Operators.Exists<MedicationRequest>(qzzzzzzzzzzzzzg_);

        return qzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has Laboratory Tests Identifying Sexual Activity But Not Pregnancy")]
    public bool? Has_Laboratory_Tests_Identifying_Sexual_Activity_But_Not_Pregnancy(CqlContext context)
    {
        CqlValueSet qzzzzzzzzzzzzzn_ = this.Pap_Test(context);
        IEnumerable<ServiceRequest> qzzzzzzzzzzzzzo_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, qzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        CqlValueSet qzzzzzzzzzzzzzp_ = this.Lab_Tests_During_Pregnancy(context);
        IEnumerable<ServiceRequest> qzzzzzzzzzzzzzq_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, qzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> qzzzzzzzzzzzzzr_ = context.Operators.Union<ServiceRequest>(qzzzzzzzzzzzzzo_, qzzzzzzzzzzzzzq_);
        CqlValueSet qzzzzzzzzzzzzzs_ = this.Lab_Tests_for_Sexually_Transmitted_Infections(context);
        IEnumerable<ServiceRequest> qzzzzzzzzzzzzzt_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, qzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> qzzzzzzzzzzzzzu_ = context.Operators.Union<ServiceRequest>(qzzzzzzzzzzzzzr_, qzzzzzzzzzzzzzt_);
        IEnumerable<ServiceRequest> qzzzzzzzzzzzzzv_ = Status_1_8_000.Instance.isLaboratoryTestOrder(context, qzzzzzzzzzzzzzu_);
        bool? qzzzzzzzzzzzzzw_(ServiceRequest LabOrders)
        {
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzz_ = this.Measurement_Period(context);
            FhirDateTime rzzzzzzzzzzzzza_ = LabOrders?.AuthoredOnElement;
            CqlDateTime rzzzzzzzzzzzzzb_ = context.Operators.Convert<CqlDateTime>(rzzzzzzzzzzzzza_);
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.toInterval(context, rzzzzzzzzzzzzzb_ as object);
            bool? rzzzzzzzzzzzzzd_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(qzzzzzzzzzzzzzz_, rzzzzzzzzzzzzzc_, "day");

            return rzzzzzzzzzzzzzd_;
        };
        IEnumerable<ServiceRequest> qzzzzzzzzzzzzzx_ = context.Operators.Where<ServiceRequest>(qzzzzzzzzzzzzzv_, qzzzzzzzzzzzzzw_);
        bool? qzzzzzzzzzzzzzy_ = context.Operators.Exists<ServiceRequest>(qzzzzzzzzzzzzzx_);

        return qzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has Laboratory Tests Identifying Sexual Activity")]
    public bool? Has_Laboratory_Tests_Identifying_Sexual_Activity(CqlContext context)
    {
        CqlValueSet rzzzzzzzzzzzzze_ = this.Pregnancy_Test(context);
        IEnumerable<ServiceRequest> rzzzzzzzzzzzzzf_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, rzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> rzzzzzzzzzzzzzg_ = Status_1_8_000.Instance.isLaboratoryTestOrder(context, rzzzzzzzzzzzzzf_);
        bool? rzzzzzzzzzzzzzh_(ServiceRequest PregnancyTest)
        {
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzzm_ = this.Measurement_Period(context);
            FhirDateTime rzzzzzzzzzzzzzn_ = PregnancyTest?.AuthoredOnElement;
            CqlDateTime rzzzzzzzzzzzzzo_ = context.Operators.Convert<CqlDateTime>(rzzzzzzzzzzzzzn_);
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.toInterval(context, rzzzzzzzzzzzzzo_ as object);
            bool? rzzzzzzzzzzzzzq_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(rzzzzzzzzzzzzzm_, rzzzzzzzzzzzzzp_, "day");

            return rzzzzzzzzzzzzzq_;
        };
        IEnumerable<ServiceRequest> rzzzzzzzzzzzzzi_ = context.Operators.Where<ServiceRequest>(rzzzzzzzzzzzzzg_, rzzzzzzzzzzzzzh_);
        bool? rzzzzzzzzzzzzzj_ = context.Operators.Exists<ServiceRequest>(rzzzzzzzzzzzzzi_);
        bool? rzzzzzzzzzzzzzk_ = this.Has_Laboratory_Tests_Identifying_Sexual_Activity_But_Not_Pregnancy(context);
        bool? rzzzzzzzzzzzzzl_ = context.Operators.Or(rzzzzzzzzzzzzzj_, rzzzzzzzzzzzzzk_);

        return rzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has Diagnostic Studies Identifying Sexual Activity")]
    public bool? Has_Diagnostic_Studies_Identifying_Sexual_Activity(CqlContext context)
    {
        CqlValueSet rzzzzzzzzzzzzzr_ = this.Diagnostic_Studies_During_Pregnancy(context);
        IEnumerable<ServiceRequest> rzzzzzzzzzzzzzs_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, rzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> rzzzzzzzzzzzzzt_ = Status_1_8_000.Instance.isDiagnosticStudyOrder(context, rzzzzzzzzzzzzzs_);
        bool? rzzzzzzzzzzzzzu_(ServiceRequest SexualActivityDiagnostics)
        {
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzzx_ = this.Measurement_Period(context);
            FhirDateTime rzzzzzzzzzzzzzy_ = SexualActivityDiagnostics?.AuthoredOnElement;
            CqlDateTime rzzzzzzzzzzzzzz_ = context.Operators.Convert<CqlDateTime>(rzzzzzzzzzzzzzy_);
            CqlInterval<CqlDateTime> szzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.toInterval(context, rzzzzzzzzzzzzzz_ as object);
            bool? szzzzzzzzzzzzzb_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(rzzzzzzzzzzzzzx_, szzzzzzzzzzzzza_, "day");

            return szzzzzzzzzzzzzb_;
        };
        IEnumerable<ServiceRequest> rzzzzzzzzzzzzzv_ = context.Operators.Where<ServiceRequest>(rzzzzzzzzzzzzzt_, rzzzzzzzzzzzzzu_);
        bool? rzzzzzzzzzzzzzw_ = context.Operators.Exists<ServiceRequest>(rzzzzzzzzzzzzzv_);

        return rzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has Procedures Identifying Sexual Activity")]
    public bool? Has_Procedures_Identifying_Sexual_Activity(CqlContext context)
    {
        CqlValueSet szzzzzzzzzzzzzc_ = this.Procedures_Used_to_Indicate_Sexual_Activity(context);
        IEnumerable<Procedure> szzzzzzzzzzzzzd_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, szzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> szzzzzzzzzzzzze_ = Status_1_8_000.Instance.isProcedurePerformed(context, szzzzzzzzzzzzzd_);
        bool? szzzzzzzzzzzzzf_(Procedure ProceduresForSexualActivity)
        {
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzi_ = this.Measurement_Period(context);
            DataType szzzzzzzzzzzzzj_ = ProceduresForSexualActivity?.Performed;
            object szzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzj_);
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.toInterval(context, szzzzzzzzzzzzzk_);
            bool? szzzzzzzzzzzzzm_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(szzzzzzzzzzzzzi_, szzzzzzzzzzzzzl_, "day");

            return szzzzzzzzzzzzzm_;
        };
        IEnumerable<Procedure> szzzzzzzzzzzzzg_ = context.Operators.Where<Procedure>(szzzzzzzzzzzzze_, szzzzzzzzzzzzzf_);
        bool? szzzzzzzzzzzzzh_ = context.Operators.Exists<Procedure>(szzzzzzzzzzzzzg_);

        return szzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition(
        definitionName: "Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient szzzzzzzzzzzzzn_ = this.Patient(context);
        Date szzzzzzzzzzzzzo_ = szzzzzzzzzzzzzn_?.BirthDateElement;
        string szzzzzzzzzzzzzp_ = szzzzzzzzzzzzzo_?.Value;
        CqlDate szzzzzzzzzzzzzq_ = context.Operators.ConvertStringToDate(szzzzzzzzzzzzzp_);
        CqlInterval<CqlDateTime> szzzzzzzzzzzzzr_ = this.Measurement_Period(context);
        CqlDateTime szzzzzzzzzzzzzs_ = context.Operators.End(szzzzzzzzzzzzzr_);
        CqlDate szzzzzzzzzzzzzt_ = context.Operators.DateFrom(szzzzzzzzzzzzzs_);
        int? szzzzzzzzzzzzzu_ = context.Operators.CalculateAgeAt(szzzzzzzzzzzzzq_, szzzzzzzzzzzzzt_, "year");
        CqlInterval<int?> szzzzzzzzzzzzzv_ = context.Operators.Interval(16, 24, true, true);
        bool? szzzzzzzzzzzzzw_ = context.Operators.In<int?>(szzzzzzzzzzzzzu_, szzzzzzzzzzzzzv_, default);
        Code<AdministrativeGender> szzzzzzzzzzzzzy_ = szzzzzzzzzzzzzn_?.GenderElement;
        AdministrativeGender? szzzzzzzzzzzzzz_ = szzzzzzzzzzzzzy_?.Value;
        string tzzzzzzzzzzzzza_ = context.Operators.Convert<string>(szzzzzzzzzzzzzz_);
        bool? tzzzzzzzzzzzzzb_ = context.Operators.Equal(tzzzzzzzzzzzzza_, "female");
        bool? tzzzzzzzzzzzzzc_ = context.Operators.And(szzzzzzzzzzzzzw_, tzzzzzzzzzzzzzb_);
        IEnumerable<Encounter> tzzzzzzzzzzzzzd_ = this.Qualifying_Encounters(context);
        bool? tzzzzzzzzzzzzze_ = context.Operators.Exists<Encounter>(tzzzzzzzzzzzzzd_);
        bool? tzzzzzzzzzzzzzf_ = context.Operators.And(tzzzzzzzzzzzzzc_, tzzzzzzzzzzzzze_);
        bool? tzzzzzzzzzzzzzg_ = this.Has_Assessments_Identifying_Sexual_Activity(context);
        bool? tzzzzzzzzzzzzzh_ = this.Has_Diagnoses_Identifying_Sexual_Activity(context);
        bool? tzzzzzzzzzzzzzi_ = context.Operators.Or(tzzzzzzzzzzzzzg_, tzzzzzzzzzzzzzh_);
        bool? tzzzzzzzzzzzzzj_ = this.Has_Active_Contraceptive_Medications(context);
        bool? tzzzzzzzzzzzzzk_ = context.Operators.Or(tzzzzzzzzzzzzzi_, tzzzzzzzzzzzzzj_);
        bool? tzzzzzzzzzzzzzl_ = this.Has_Ordered_Contraceptive_Medications(context);
        bool? tzzzzzzzzzzzzzm_ = context.Operators.Or(tzzzzzzzzzzzzzk_, tzzzzzzzzzzzzzl_);
        bool? tzzzzzzzzzzzzzn_ = this.Has_Laboratory_Tests_Identifying_Sexual_Activity(context);
        bool? tzzzzzzzzzzzzzo_ = context.Operators.Or(tzzzzzzzzzzzzzm_, tzzzzzzzzzzzzzn_);
        bool? tzzzzzzzzzzzzzp_ = this.Has_Diagnostic_Studies_Identifying_Sexual_Activity(context);
        bool? tzzzzzzzzzzzzzq_ = context.Operators.Or(tzzzzzzzzzzzzzo_, tzzzzzzzzzzzzzp_);
        bool? tzzzzzzzzzzzzzr_ = this.Has_Procedures_Identifying_Sexual_Activity(context);
        bool? tzzzzzzzzzzzzzs_ = context.Operators.Or(tzzzzzzzzzzzzzq_, tzzzzzzzzzzzzzr_);
        bool? tzzzzzzzzzzzzzt_ = context.Operators.And(tzzzzzzzzzzzzzf_, tzzzzzzzzzzzzzs_);

        return tzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? tzzzzzzzzzzzzzu_ = this.Initial_Population(context);

        return tzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has Pregnancy Test Exclusion")]
    public bool? Has_Pregnancy_Test_Exclusion(CqlContext context)
    {
        CqlValueSet tzzzzzzzzzzzzzv_ = this.Pregnancy_Test(context);
        IEnumerable<ServiceRequest> tzzzzzzzzzzzzzw_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, tzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> tzzzzzzzzzzzzzx_ = Status_1_8_000.Instance.isLaboratoryTestOrder(context, tzzzzzzzzzzzzzw_);
        IEnumerable<ServiceRequest> tzzzzzzzzzzzzzy_(ServiceRequest PregnancyTest)
        {
            CqlValueSet uzzzzzzzzzzzzzl_ = this.XRay_Study(context);
            IEnumerable<ServiceRequest> uzzzzzzzzzzzzzm_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, uzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
            IEnumerable<ServiceRequest> uzzzzzzzzzzzzzn_ = Status_1_8_000.Instance.isDiagnosticStudyOrder(context, uzzzzzzzzzzzzzm_);
            bool? uzzzzzzzzzzzzzo_(ServiceRequest XrayOrder)
            {
                FhirDateTime uzzzzzzzzzzzzzs_ = XrayOrder?.AuthoredOnElement;
                CqlDateTime uzzzzzzzzzzzzzt_ = context.Operators.Convert<CqlDateTime>(uzzzzzzzzzzzzzs_);
                CqlInterval<CqlDateTime> uzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.toInterval(context, uzzzzzzzzzzzzzt_ as object);
                CqlDateTime uzzzzzzzzzzzzzv_ = context.Operators.Start(uzzzzzzzzzzzzzu_);
                FhirDateTime uzzzzzzzzzzzzzw_ = PregnancyTest?.AuthoredOnElement;
                CqlDateTime uzzzzzzzzzzzzzx_ = context.Operators.Convert<CqlDateTime>(uzzzzzzzzzzzzzw_);
                CqlInterval<CqlDateTime> uzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.toInterval(context, uzzzzzzzzzzzzzx_ as object);
                CqlDateTime uzzzzzzzzzzzzzz_ = context.Operators.End(uzzzzzzzzzzzzzy_);
                CqlDateTime vzzzzzzzzzzzzzb_ = context.Operators.Convert<CqlDateTime>(uzzzzzzzzzzzzzw_);
                CqlInterval<CqlDateTime> vzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.toInterval(context, vzzzzzzzzzzzzzb_ as object);
                CqlDateTime vzzzzzzzzzzzzzd_ = context.Operators.End(vzzzzzzzzzzzzzc_);
                CqlQuantity vzzzzzzzzzzzzze_ = context.Operators.Quantity(6m, "days");
                CqlDateTime vzzzzzzzzzzzzzf_ = context.Operators.Add(vzzzzzzzzzzzzzd_, vzzzzzzzzzzzzze_);
                CqlInterval<CqlDateTime> vzzzzzzzzzzzzzg_ = context.Operators.Interval(uzzzzzzzzzzzzzz_, vzzzzzzzzzzzzzf_, true, true);
                bool? vzzzzzzzzzzzzzh_ = context.Operators.In<CqlDateTime>(uzzzzzzzzzzzzzv_, vzzzzzzzzzzzzzg_, "day");
                CqlDateTime vzzzzzzzzzzzzzj_ = context.Operators.Convert<CqlDateTime>(uzzzzzzzzzzzzzw_);
                CqlInterval<CqlDateTime> vzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.toInterval(context, vzzzzzzzzzzzzzj_ as object);
                CqlDateTime vzzzzzzzzzzzzzl_ = context.Operators.End(vzzzzzzzzzzzzzk_);
                bool? vzzzzzzzzzzzzzm_ = context.Operators.Not((bool?)(vzzzzzzzzzzzzzl_ is null));
                bool? vzzzzzzzzzzzzzn_ = context.Operators.And(vzzzzzzzzzzzzzh_, vzzzzzzzzzzzzzm_);

                return vzzzzzzzzzzzzzn_;
            };
            IEnumerable<ServiceRequest> uzzzzzzzzzzzzzp_ = context.Operators.Where<ServiceRequest>(uzzzzzzzzzzzzzn_, uzzzzzzzzzzzzzo_);
            ServiceRequest uzzzzzzzzzzzzzq_(ServiceRequest XrayOrder) =>
                PregnancyTest;
            IEnumerable<ServiceRequest> uzzzzzzzzzzzzzr_ = context.Operators.Select<ServiceRequest, ServiceRequest>(uzzzzzzzzzzzzzp_, uzzzzzzzzzzzzzq_);

            return uzzzzzzzzzzzzzr_;
        };
        IEnumerable<ServiceRequest> tzzzzzzzzzzzzzz_ = context.Operators.SelectMany<ServiceRequest, ServiceRequest>(tzzzzzzzzzzzzzx_, tzzzzzzzzzzzzzy_);
        bool? uzzzzzzzzzzzzza_(ServiceRequest PregnancyTest)
        {
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzo_ = this.Measurement_Period(context);
            FhirDateTime vzzzzzzzzzzzzzp_ = PregnancyTest?.AuthoredOnElement;
            CqlDateTime vzzzzzzzzzzzzzq_ = context.Operators.Convert<CqlDateTime>(vzzzzzzzzzzzzzp_);
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.toInterval(context, vzzzzzzzzzzzzzq_ as object);
            bool? vzzzzzzzzzzzzzs_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(vzzzzzzzzzzzzzo_, vzzzzzzzzzzzzzr_, default);

            return vzzzzzzzzzzzzzs_;
        };
        IEnumerable<ServiceRequest> uzzzzzzzzzzzzzb_ = context.Operators.Where<ServiceRequest>(tzzzzzzzzzzzzzz_, uzzzzzzzzzzzzza_);
        IEnumerable<ServiceRequest> uzzzzzzzzzzzzzd_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, tzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> uzzzzzzzzzzzzze_ = Status_1_8_000.Instance.isLaboratoryTestOrder(context, uzzzzzzzzzzzzzd_);
        IEnumerable<ServiceRequest> uzzzzzzzzzzzzzf_(ServiceRequest PregnancyTestOrder)
        {
            CqlValueSet vzzzzzzzzzzzzzt_ = this.Isotretinoin(context);
            IEnumerable<MedicationRequest> vzzzzzzzzzzzzzu_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, vzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> vzzzzzzzzzzzzzw_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, vzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> vzzzzzzzzzzzzzx_ = context.Operators.Union<MedicationRequest>(vzzzzzzzzzzzzzu_, vzzzzzzzzzzzzzw_);
            IEnumerable<MedicationRequest> vzzzzzzzzzzzzzy_ = Status_1_8_000.Instance.isMedicationOrder(context, vzzzzzzzzzzzzzx_);
            bool? vzzzzzzzzzzzzzz_(MedicationRequest AccutaneOrder)
            {
                FhirDateTime wzzzzzzzzzzzzzd_ = AccutaneOrder?.AuthoredOnElement;
                CqlDateTime wzzzzzzzzzzzzze_ = context.Operators.Convert<CqlDateTime>(wzzzzzzzzzzzzzd_);
                CqlInterval<CqlDateTime> wzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.toInterval(context, wzzzzzzzzzzzzze_ as object);
                CqlDateTime wzzzzzzzzzzzzzg_ = context.Operators.Start(wzzzzzzzzzzzzzf_);
                FhirDateTime wzzzzzzzzzzzzzh_ = PregnancyTestOrder?.AuthoredOnElement;
                CqlDateTime wzzzzzzzzzzzzzi_ = context.Operators.Convert<CqlDateTime>(wzzzzzzzzzzzzzh_);
                CqlInterval<CqlDateTime> wzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.toInterval(context, wzzzzzzzzzzzzzi_ as object);
                CqlDateTime wzzzzzzzzzzzzzk_ = context.Operators.End(wzzzzzzzzzzzzzj_);
                CqlDateTime wzzzzzzzzzzzzzm_ = context.Operators.Convert<CqlDateTime>(wzzzzzzzzzzzzzh_);
                CqlInterval<CqlDateTime> wzzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.toInterval(context, wzzzzzzzzzzzzzm_ as object);
                CqlDateTime wzzzzzzzzzzzzzo_ = context.Operators.End(wzzzzzzzzzzzzzn_);
                CqlQuantity wzzzzzzzzzzzzzp_ = context.Operators.Quantity(6m, "days");
                CqlDateTime wzzzzzzzzzzzzzq_ = context.Operators.Add(wzzzzzzzzzzzzzo_, wzzzzzzzzzzzzzp_);
                CqlInterval<CqlDateTime> wzzzzzzzzzzzzzr_ = context.Operators.Interval(wzzzzzzzzzzzzzk_, wzzzzzzzzzzzzzq_, true, true);
                bool? wzzzzzzzzzzzzzs_ = context.Operators.In<CqlDateTime>(wzzzzzzzzzzzzzg_, wzzzzzzzzzzzzzr_, "day");
                CqlDateTime wzzzzzzzzzzzzzu_ = context.Operators.Convert<CqlDateTime>(wzzzzzzzzzzzzzh_);
                CqlInterval<CqlDateTime> wzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.toInterval(context, wzzzzzzzzzzzzzu_ as object);
                CqlDateTime wzzzzzzzzzzzzzw_ = context.Operators.End(wzzzzzzzzzzzzzv_);
                bool? wzzzzzzzzzzzzzx_ = context.Operators.Not((bool?)(wzzzzzzzzzzzzzw_ is null));
                bool? wzzzzzzzzzzzzzy_ = context.Operators.And(wzzzzzzzzzzzzzs_, wzzzzzzzzzzzzzx_);

                return wzzzzzzzzzzzzzy_;
            };
            IEnumerable<MedicationRequest> wzzzzzzzzzzzzza_ = context.Operators.Where<MedicationRequest>(vzzzzzzzzzzzzzy_, vzzzzzzzzzzzzzz_);
            ServiceRequest wzzzzzzzzzzzzzb_(MedicationRequest AccutaneOrder) =>
                PregnancyTestOrder;
            IEnumerable<ServiceRequest> wzzzzzzzzzzzzzc_ = context.Operators.Select<MedicationRequest, ServiceRequest>(wzzzzzzzzzzzzza_, wzzzzzzzzzzzzzb_);

            return wzzzzzzzzzzzzzc_;
        };
        IEnumerable<ServiceRequest> uzzzzzzzzzzzzzg_ = context.Operators.SelectMany<ServiceRequest, ServiceRequest>(uzzzzzzzzzzzzze_, uzzzzzzzzzzzzzf_);
        bool? uzzzzzzzzzzzzzh_(ServiceRequest PregnancyTestOrder)
        {
            CqlInterval<CqlDateTime> wzzzzzzzzzzzzzz_ = this.Measurement_Period(context);
            FhirDateTime xzzzzzzzzzzzzza_ = PregnancyTestOrder?.AuthoredOnElement;
            CqlDateTime xzzzzzzzzzzzzzb_ = context.Operators.Convert<CqlDateTime>(xzzzzzzzzzzzzza_);
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.toInterval(context, xzzzzzzzzzzzzzb_ as object);
            bool? xzzzzzzzzzzzzzd_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(wzzzzzzzzzzzzzz_, xzzzzzzzzzzzzzc_, default);

            return xzzzzzzzzzzzzzd_;
        };
        IEnumerable<ServiceRequest> uzzzzzzzzzzzzzi_ = context.Operators.Where<ServiceRequest>(uzzzzzzzzzzzzzg_, uzzzzzzzzzzzzzh_);
        IEnumerable<ServiceRequest> uzzzzzzzzzzzzzj_ = context.Operators.Union<ServiceRequest>(uzzzzzzzzzzzzzb_, uzzzzzzzzzzzzzi_);
        bool? uzzzzzzzzzzzzzk_ = context.Operators.Exists<ServiceRequest>(uzzzzzzzzzzzzzj_);

        return uzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? xzzzzzzzzzzzzze_ = Hospice_6_12_000.Instance.Has_Hospice_Services(context);
        bool? xzzzzzzzzzzzzzf_ = this.Has_Pregnancy_Test_Exclusion(context);
        bool? xzzzzzzzzzzzzzg_ = this.Has_Assessments_Identifying_Sexual_Activity(context);
        bool? xzzzzzzzzzzzzzh_ = context.Operators.Not(xzzzzzzzzzzzzzg_);
        bool? xzzzzzzzzzzzzzi_ = context.Operators.And(xzzzzzzzzzzzzzf_, xzzzzzzzzzzzzzh_);
        bool? xzzzzzzzzzzzzzj_ = this.Has_Diagnoses_Identifying_Sexual_Activity(context);
        bool? xzzzzzzzzzzzzzk_ = context.Operators.Not(xzzzzzzzzzzzzzj_);
        bool? xzzzzzzzzzzzzzl_ = context.Operators.And(xzzzzzzzzzzzzzi_, xzzzzzzzzzzzzzk_);
        bool? xzzzzzzzzzzzzzm_ = this.Has_Active_Contraceptive_Medications(context);
        bool? xzzzzzzzzzzzzzn_ = context.Operators.Not(xzzzzzzzzzzzzzm_);
        bool? xzzzzzzzzzzzzzo_ = context.Operators.And(xzzzzzzzzzzzzzl_, xzzzzzzzzzzzzzn_);
        bool? xzzzzzzzzzzzzzp_ = this.Has_Ordered_Contraceptive_Medications(context);
        bool? xzzzzzzzzzzzzzq_ = context.Operators.Not(xzzzzzzzzzzzzzp_);
        bool? xzzzzzzzzzzzzzr_ = context.Operators.And(xzzzzzzzzzzzzzo_, xzzzzzzzzzzzzzq_);
        bool? xzzzzzzzzzzzzzs_ = this.Has_Laboratory_Tests_Identifying_Sexual_Activity_But_Not_Pregnancy(context);
        bool? xzzzzzzzzzzzzzt_ = context.Operators.Not(xzzzzzzzzzzzzzs_);
        bool? xzzzzzzzzzzzzzu_ = context.Operators.And(xzzzzzzzzzzzzzr_, xzzzzzzzzzzzzzt_);
        bool? xzzzzzzzzzzzzzv_ = this.Has_Diagnostic_Studies_Identifying_Sexual_Activity(context);
        bool? xzzzzzzzzzzzzzw_ = context.Operators.Not(xzzzzzzzzzzzzzv_);
        bool? xzzzzzzzzzzzzzx_ = context.Operators.And(xzzzzzzzzzzzzzu_, xzzzzzzzzzzzzzw_);
        bool? xzzzzzzzzzzzzzy_ = this.Has_Procedures_Identifying_Sexual_Activity(context);
        bool? xzzzzzzzzzzzzzz_ = context.Operators.Not(xzzzzzzzzzzzzzy_);
        bool? yzzzzzzzzzzzzza_ = context.Operators.And(xzzzzzzzzzzzzzx_, xzzzzzzzzzzzzzz_);
        bool? yzzzzzzzzzzzzzb_ = context.Operators.Or(xzzzzzzzzzzzzze_, yzzzzzzzzzzzzza_);

        return yzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition(
        definitionName: "Numerator")]
    public bool? Numerator(CqlContext context)
    {
        CqlValueSet yzzzzzzzzzzzzzc_ = this.Chlamydia_Screening(context);
        IEnumerable<Observation> yzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, yzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> yzzzzzzzzzzzzze_ = Status_1_8_000.Instance.isLaboratoryTestPerformed(context, yzzzzzzzzzzzzzd_);
        bool? yzzzzzzzzzzzzzf_(Observation ChlamydiaTest)
        {
            object yzzzzzzzzzzzzzi_()
            {
                bool yzzzzzzzzzzzzzq_()
                {
                    DataType yzzzzzzzzzzzzzt_ = ChlamydiaTest?.Effective;
                    object yzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzt_);
                    bool yzzzzzzzzzzzzzv_ = yzzzzzzzzzzzzzu_ is CqlDateTime;

                    return yzzzzzzzzzzzzzv_;
                };
                bool yzzzzzzzzzzzzzr_()
                {
                    DataType yzzzzzzzzzzzzzw_ = ChlamydiaTest?.Effective;
                    object yzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzw_);
                    bool yzzzzzzzzzzzzzy_ = yzzzzzzzzzzzzzx_ is CqlInterval<CqlDateTime>;

                    return yzzzzzzzzzzzzzy_;
                };
                bool yzzzzzzzzzzzzzs_()
                {
                    DataType yzzzzzzzzzzzzzz_ = ChlamydiaTest?.Effective;
                    object zzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzz_);
                    bool zzzzzzzzzzzzzzb_ = zzzzzzzzzzzzzza_ is CqlDateTime;

                    return zzzzzzzzzzzzzzb_;
                };
                if (yzzzzzzzzzzzzzq_())
                {
                    DataType zzzzzzzzzzzzzzc_ = ChlamydiaTest?.Effective;
                    object zzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzc_);

                    return (zzzzzzzzzzzzzzd_ as CqlDateTime) as object;
                }
                else if (yzzzzzzzzzzzzzr_())
                {
                    DataType zzzzzzzzzzzzzze_ = ChlamydiaTest?.Effective;
                    object zzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzze_);

                    return (zzzzzzzzzzzzzzf_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (yzzzzzzzzzzzzzs_())
                {
                    DataType zzzzzzzzzzzzzzg_ = ChlamydiaTest?.Effective;
                    object zzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzg_);

                    return (zzzzzzzzzzzzzzh_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime yzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.latest(context, yzzzzzzzzzzzzzi_());
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzzk_ = this.Measurement_Period(context);
            bool? yzzzzzzzzzzzzzl_ = context.Operators.In<CqlDateTime>(yzzzzzzzzzzzzzj_, yzzzzzzzzzzzzzk_, "day");
            DataType yzzzzzzzzzzzzzm_ = ChlamydiaTest?.Value;
            object yzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzm_);
            bool? yzzzzzzzzzzzzzo_ = context.Operators.Not((bool?)(yzzzzzzzzzzzzzn_ is null));
            bool? yzzzzzzzzzzzzzp_ = context.Operators.And(yzzzzzzzzzzzzzl_, yzzzzzzzzzzzzzo_);

            return yzzzzzzzzzzzzzp_;
        };
        IEnumerable<Observation> yzzzzzzzzzzzzzg_ = context.Operators.Where<Observation>(yzzzzzzzzzzzzze_, yzzzzzzzzzzzzzf_);
        bool? yzzzzzzzzzzzzzh_ = context.Operators.Exists<Observation>(yzzzzzzzzzzzzzg_);

        return yzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition(
        definitionName: "Stratification 1")]
    public bool? Stratification_1(CqlContext context)
    {
        Patient zzzzzzzzzzzzzzi_ = this.Patient(context);
        Date zzzzzzzzzzzzzzj_ = zzzzzzzzzzzzzzi_?.BirthDateElement;
        string zzzzzzzzzzzzzzk_ = zzzzzzzzzzzzzzj_?.Value;
        CqlDate zzzzzzzzzzzzzzl_ = context.Operators.ConvertStringToDate(zzzzzzzzzzzzzzk_);
        CqlInterval<CqlDateTime> zzzzzzzzzzzzzzm_ = this.Measurement_Period(context);
        CqlDateTime zzzzzzzzzzzzzzn_ = context.Operators.End(zzzzzzzzzzzzzzm_);
        CqlDate zzzzzzzzzzzzzzo_ = context.Operators.DateFrom(zzzzzzzzzzzzzzn_);
        int? zzzzzzzzzzzzzzp_ = context.Operators.CalculateAgeAt(zzzzzzzzzzzzzzl_, zzzzzzzzzzzzzzo_, "year");
        CqlInterval<int?> zzzzzzzzzzzzzzq_ = context.Operators.Interval(16, 20, true, true);
        bool? zzzzzzzzzzzzzzr_ = context.Operators.In<int?>(zzzzzzzzzzzzzzp_, zzzzzzzzzzzzzzq_, default);

        return zzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition(
        definitionName: "Stratification 2")]
    public bool? Stratification_2(CqlContext context)
    {
        Patient zzzzzzzzzzzzzzs_ = this.Patient(context);
        Date zzzzzzzzzzzzzzt_ = zzzzzzzzzzzzzzs_?.BirthDateElement;
        string zzzzzzzzzzzzzzu_ = zzzzzzzzzzzzzzt_?.Value;
        CqlDate zzzzzzzzzzzzzzv_ = context.Operators.ConvertStringToDate(zzzzzzzzzzzzzzu_);
        CqlInterval<CqlDateTime> zzzzzzzzzzzzzzw_ = this.Measurement_Period(context);
        CqlDateTime zzzzzzzzzzzzzzx_ = context.Operators.End(zzzzzzzzzzzzzzw_);
        CqlDate zzzzzzzzzzzzzzy_ = context.Operators.DateFrom(zzzzzzzzzzzzzzx_);
        int? zzzzzzzzzzzzzzz_ = context.Operators.CalculateAgeAt(zzzzzzzzzzzzzzv_, zzzzzzzzzzzzzzy_, "year");
        CqlInterval<int?> azzzzzzzzzzzzzza_ = context.Operators.Interval(21, 24, true, true);
        bool? azzzzzzzzzzzzzzb_ = context.Operators.In<int?>(zzzzzzzzzzzzzzz_, azzzzzzzzzzzzzza_, default);

        return azzzzzzzzzzzzzzb_;
    }


    #endregion Expressions

}
