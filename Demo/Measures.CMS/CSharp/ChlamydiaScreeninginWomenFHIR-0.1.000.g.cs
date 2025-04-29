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

    [CqlValueSetDefinition("Chlamydia Screening", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1052", valueSetVersion: null)]
    public CqlValueSet Chlamydia_Screening(CqlContext _) => _Chlamydia_Screening;
    private static readonly CqlValueSet _Chlamydia_Screening = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1052", null);

    [CqlValueSetDefinition("Complications of Pregnancy, Childbirth and the Puerperium", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1012", valueSetVersion: null)]
    public CqlValueSet Complications_of_Pregnancy__Childbirth_and_the_Puerperium(CqlContext _) => _Complications_of_Pregnancy__Childbirth_and_the_Puerperium;
    private static readonly CqlValueSet _Complications_of_Pregnancy__Childbirth_and_the_Puerperium = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1012", null);

    [CqlValueSetDefinition("Contraceptive Medications", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1080", valueSetVersion: null)]
    public CqlValueSet Contraceptive_Medications(CqlContext _) => _Contraceptive_Medications;
    private static readonly CqlValueSet _Contraceptive_Medications = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1080", null);

    [CqlValueSetDefinition("Diagnoses Used to Indicate Sexual Activity", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1018", valueSetVersion: null)]
    public CqlValueSet Diagnoses_Used_to_Indicate_Sexual_Activity(CqlContext _) => _Diagnoses_Used_to_Indicate_Sexual_Activity;
    private static readonly CqlValueSet _Diagnoses_Used_to_Indicate_Sexual_Activity = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1018", null);

    [CqlValueSetDefinition("Diagnostic Studies During Pregnancy", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1008", valueSetVersion: null)]
    public CqlValueSet Diagnostic_Studies_During_Pregnancy(CqlContext _) => _Diagnostic_Studies_During_Pregnancy;
    private static readonly CqlValueSet _Diagnostic_Studies_During_Pregnancy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1008", null);

    [CqlValueSetDefinition("HIV", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1003", valueSetVersion: null)]
    public CqlValueSet HIV(CqlContext _) => _HIV;
    private static readonly CqlValueSet _HIV = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1003", null);

    [CqlValueSetDefinition("Home Healthcare Services", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", valueSetVersion: null)]
    public CqlValueSet Home_Healthcare_Services(CqlContext _) => _Home_Healthcare_Services;
    private static readonly CqlValueSet _Home_Healthcare_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", null);

    [CqlValueSetDefinition("Isotretinoin", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1143", valueSetVersion: null)]
    public CqlValueSet Isotretinoin(CqlContext _) => _Isotretinoin;
    private static readonly CqlValueSet _Isotretinoin = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1143", null);

    [CqlValueSetDefinition("Lab Tests During Pregnancy", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1007", valueSetVersion: null)]
    public CqlValueSet Lab_Tests_During_Pregnancy(CqlContext _) => _Lab_Tests_During_Pregnancy;
    private static readonly CqlValueSet _Lab_Tests_During_Pregnancy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1007", null);

    [CqlValueSetDefinition("Lab Tests for Sexually Transmitted Infections", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1051", valueSetVersion: null)]
    public CqlValueSet Lab_Tests_for_Sexually_Transmitted_Infections(CqlContext _) => _Lab_Tests_for_Sexually_Transmitted_Infections;
    private static readonly CqlValueSet _Lab_Tests_for_Sexually_Transmitted_Infections = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1051", null);

    [CqlValueSetDefinition("Office Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", valueSetVersion: null)]
    public CqlValueSet Office_Visit(CqlContext _) => _Office_Visit;
    private static readonly CqlValueSet _Office_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);

    [CqlValueSetDefinition("Virtual Encounter", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", valueSetVersion: null)]
    public CqlValueSet Virtual_Encounter(CqlContext _) => _Virtual_Encounter;
    private static readonly CqlValueSet _Virtual_Encounter = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", null);

    [CqlValueSetDefinition("Pap Test", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1017", valueSetVersion: null)]
    public CqlValueSet Pap_Test(CqlContext _) => _Pap_Test;
    private static readonly CqlValueSet _Pap_Test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1017", null);

    [CqlValueSetDefinition("Pregnancy Test", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1011", valueSetVersion: null)]
    public CqlValueSet Pregnancy_Test(CqlContext _) => _Pregnancy_Test;
    private static readonly CqlValueSet _Pregnancy_Test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1011", null);

    [CqlValueSetDefinition("Preventive Care Services Established Office Visit, 18 and Up", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Established_Office_Visit__18_and_Up(CqlContext _) => _Preventive_Care_Services_Established_Office_Visit__18_and_Up;
    private static readonly CqlValueSet _Preventive_Care_Services_Established_Office_Visit__18_and_Up = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", null);

    [CqlValueSetDefinition("Preventive Care Services Initial Office Visit, 18 and Up", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up(CqlContext _) => _Preventive_Care_Services_Initial_Office_Visit__18_and_Up;
    private static readonly CqlValueSet _Preventive_Care_Services_Initial_Office_Visit__18_and_Up = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", null);

    [CqlValueSetDefinition("Preventive Care Services, Initial Office Visit, 0 to 17", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services__Initial_Office_Visit__0_to_17(CqlContext _) => _Preventive_Care_Services__Initial_Office_Visit__0_to_17;
    private static readonly CqlValueSet _Preventive_Care_Services__Initial_Office_Visit__0_to_17 = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022", null);

    [CqlValueSetDefinition("Preventive Care, Established Office Visit, 0 to 17", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024", valueSetVersion: null)]
    public CqlValueSet Preventive_Care__Established_Office_Visit__0_to_17(CqlContext _) => _Preventive_Care__Established_Office_Visit__0_to_17;
    private static readonly CqlValueSet _Preventive_Care__Established_Office_Visit__0_to_17 = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024", null);

    [CqlValueSetDefinition("Procedures Used to Indicate Sexual Activity", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1017", valueSetVersion: null)]
    public CqlValueSet Procedures_Used_to_Indicate_Sexual_Activity(CqlContext _) => _Procedures_Used_to_Indicate_Sexual_Activity;
    private static readonly CqlValueSet _Procedures_Used_to_Indicate_Sexual_Activity = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1017", null);

    [CqlValueSetDefinition("Telephone Visits", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", valueSetVersion: null)]
    public CqlValueSet Telephone_Visits(CqlContext _) => _Telephone_Visits;
    private static readonly CqlValueSet _Telephone_Visits = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", null);

    [CqlValueSetDefinition("XRay Study", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1034", valueSetVersion: null)]
    public CqlValueSet XRay_Study(CqlContext _) => _XRay_Study;
    private static readonly CqlValueSet _XRay_Study = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1034", null);

    #endregion ValueSets

    #region Codes

    [CqlCodeDefinition("Female", codeId: "F", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-AdministrativeGender")]
    public CqlCode Female(CqlContext _) => _Female;
    private static readonly CqlCode _Female = new CqlCode("F", "http://terminology.hl7.org/CodeSystem/v3-AdministrativeGender", default, default);

    [CqlCodeDefinition("Have you ever had vaginal intercourse [PhenX]", codeId: "64728-9", codeSystem: "http://loinc.org")]
    public CqlCode Have_you_ever_had_vaginal_intercourse__PhenX_(CqlContext _) => _Have_you_ever_had_vaginal_intercourse__PhenX_;
    private static readonly CqlCode _Have_you_ever_had_vaginal_intercourse__PhenX_ = new CqlCode("64728-9", "http://loinc.org", default, default);

    [CqlCodeDefinition("Yes (qualifier value)", codeId: "373066001", codeSystem: "http://snomed.info/sct")]
    public CqlCode Yes__qualifier_value_(CqlContext _) => _Yes__qualifier_value_;
    private static readonly CqlCode _Yes__qualifier_value_ = new CqlCode("373066001", "http://snomed.info/sct", default, default);

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("AdministrativeGender")]
    public CqlCodeSystem AdministrativeGender(CqlContext _) => _AdministrativeGender;
    private static readonly CqlCodeSystem _AdministrativeGender = new CqlCodeSystem();

    [CqlCodeSystemDefinition("LOINC")]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC = new CqlCodeSystem();

    [CqlCodeSystemDefinition("SNOMEDCT")]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT = new CqlCodeSystem();

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime qzzzzzzzzzzzzzh_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime qzzzzzzzzzzzzzi_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> qzzzzzzzzzzzzzj_ = context.Operators.Interval(qzzzzzzzzzzzzzh_, qzzzzzzzzzzzzzi_, true, true);
        object qzzzzzzzzzzzzzk_ = context.ResolveParameter("ChlamydiaScreeninginWomenFHIR-0.1.000", "Measurement Period", qzzzzzzzzzzzzzj_);

        return (CqlInterval<CqlDateTime>)qzzzzzzzzzzzzzk_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> qzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient qzzzzzzzzzzzzzm_ = context.Operators.SingletonFrom<Patient>(qzzzzzzzzzzzzzl_);

        return qzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? qzzzzzzzzzzzzzn_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return qzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> qzzzzzzzzzzzzzo_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return qzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? qzzzzzzzzzzzzzp_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return qzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode qzzzzzzzzzzzzzq_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return qzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Qualifying Encounters")]
    public IEnumerable<Encounter> Qualifying_Encounters(CqlContext context)
    {
        CqlValueSet qzzzzzzzzzzzzzr_ = this.Office_Visit(context);
        IEnumerable<Encounter> qzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, qzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet qzzzzzzzzzzzzzt_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> qzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, qzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> qzzzzzzzzzzzzzv_ = context.Operators.Union<Encounter>(qzzzzzzzzzzzzzs_, qzzzzzzzzzzzzzu_);
        CqlValueSet qzzzzzzzzzzzzzw_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> qzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, qzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet qzzzzzzzzzzzzzy_ = this.Preventive_Care_Services__Initial_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> qzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, qzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> rzzzzzzzzzzzzza_ = context.Operators.Union<Encounter>(qzzzzzzzzzzzzzx_, qzzzzzzzzzzzzzz_);
        IEnumerable<Encounter> rzzzzzzzzzzzzzb_ = context.Operators.Union<Encounter>(qzzzzzzzzzzzzzv_, rzzzzzzzzzzzzza_);
        CqlValueSet rzzzzzzzzzzzzzc_ = this.Preventive_Care__Established_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> rzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, rzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet rzzzzzzzzzzzzze_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter> rzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, rzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> rzzzzzzzzzzzzzg_ = context.Operators.Union<Encounter>(rzzzzzzzzzzzzzd_, rzzzzzzzzzzzzzf_);
        IEnumerable<Encounter> rzzzzzzzzzzzzzh_ = context.Operators.Union<Encounter>(rzzzzzzzzzzzzzb_, rzzzzzzzzzzzzzg_);
        CqlValueSet rzzzzzzzzzzzzzi_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> rzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, rzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet rzzzzzzzzzzzzzk_ = this.Virtual_Encounter(context);
        IEnumerable<Encounter> rzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, rzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> rzzzzzzzzzzzzzm_ = context.Operators.Union<Encounter>(rzzzzzzzzzzzzzj_, rzzzzzzzzzzzzzl_);
        IEnumerable<Encounter> rzzzzzzzzzzzzzn_ = context.Operators.Union<Encounter>(rzzzzzzzzzzzzzh_, rzzzzzzzzzzzzzm_);
        IEnumerable<Encounter> rzzzzzzzzzzzzzo_ = Status_1_8_000.Instance.isEncounterPerformed(context, rzzzzzzzzzzzzzn_);
        bool? rzzzzzzzzzzzzzp_(Encounter ValidEncounters)
        {
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzzr_ = this.Measurement_Period(context);
            Period rzzzzzzzzzzzzzs_ = ValidEncounters?.Period;
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzzzzzzzzs_);
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.toInterval(context, rzzzzzzzzzzzzzt_ as object);
            bool? rzzzzzzzzzzzzzv_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(rzzzzzzzzzzzzzr_, rzzzzzzzzzzzzzu_, "day");

            return rzzzzzzzzzzzzzv_;
        };
        IEnumerable<Encounter> rzzzzzzzzzzzzzq_ = context.Operators.Where<Encounter>(rzzzzzzzzzzzzzo_, rzzzzzzzzzzzzzp_);

        return rzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Has Assessments Identifying Sexual Activity")]
    public bool? Has_Assessments_Identifying_Sexual_Activity(CqlContext context)
    {
        CqlCode rzzzzzzzzzzzzzw_ = this.Have_you_ever_had_vaginal_intercourse__PhenX_(context);
        IEnumerable<CqlCode> rzzzzzzzzzzzzzx_ = context.Operators.ToList<CqlCode>(rzzzzzzzzzzzzzw_);
        IEnumerable<Observation> rzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, rzzzzzzzzzzzzzx_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> rzzzzzzzzzzzzzz_ = Status_1_8_000.Instance.isAssessmentPerformed(context, rzzzzzzzzzzzzzy_);
        bool? szzzzzzzzzzzzza_(Observation SexualActivityAssessment)
        {
            DataType szzzzzzzzzzzzzd_ = SexualActivityAssessment?.Value;
            object szzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzd_);
            CqlCode szzzzzzzzzzzzzf_ = this.Yes__qualifier_value_(context);
            CqlConcept szzzzzzzzzzzzzg_ = context.Operators.ConvertCodeToConcept(szzzzzzzzzzzzzf_);
            bool? szzzzzzzzzzzzzh_ = context.Operators.Equivalent(szzzzzzzzzzzzze_ as CqlConcept, szzzzzzzzzzzzzg_);
            DataType szzzzzzzzzzzzzi_ = SexualActivityAssessment?.Effective;
            object szzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzi_);
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.toInterval(context, szzzzzzzzzzzzzj_);
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzl_()
            {
                bool szzzzzzzzzzzzzo_()
                {
                    CqlInterval<CqlDateTime> szzzzzzzzzzzzzp_ = this.Measurement_Period(context);
                    CqlDateTime szzzzzzzzzzzzzq_ = context.Operators.End(szzzzzzzzzzzzzp_);

                    return szzzzzzzzzzzzzq_ is null;
                };
                if (szzzzzzzzzzzzzo_())
                {
                    return default;
                }
                else
                {
                    CqlInterval<CqlDateTime> szzzzzzzzzzzzzr_ = this.Measurement_Period(context);
                    CqlDateTime szzzzzzzzzzzzzs_ = context.Operators.End(szzzzzzzzzzzzzr_);
                    CqlDateTime szzzzzzzzzzzzzu_ = context.Operators.End(szzzzzzzzzzzzzr_);
                    CqlInterval<CqlDateTime> szzzzzzzzzzzzzv_ = context.Operators.Interval(szzzzzzzzzzzzzs_, szzzzzzzzzzzzzu_, true, true);

                    return szzzzzzzzzzzzzv_;
                }
            };
            bool? szzzzzzzzzzzzzm_ = context.Operators.SameOrBefore(szzzzzzzzzzzzzk_, szzzzzzzzzzzzzl_(), default);
            bool? szzzzzzzzzzzzzn_ = context.Operators.And(szzzzzzzzzzzzzh_, szzzzzzzzzzzzzm_);

            return szzzzzzzzzzzzzn_;
        };
        IEnumerable<Observation> szzzzzzzzzzzzzb_ = context.Operators.Where<Observation>(rzzzzzzzzzzzzzz_, szzzzzzzzzzzzza_);
        bool? szzzzzzzzzzzzzc_ = context.Operators.Exists<Observation>(szzzzzzzzzzzzzb_);

        return szzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Has Diagnoses Identifying Sexual Activity")]
    public bool? Has_Diagnoses_Identifying_Sexual_Activity(CqlContext context)
    {
        CqlValueSet szzzzzzzzzzzzzw_ = this.Diagnoses_Used_to_Indicate_Sexual_Activity(context);
        IEnumerable<Condition> szzzzzzzzzzzzzx_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, szzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet szzzzzzzzzzzzzy_ = this.HIV(context);
        IEnumerable<Condition> szzzzzzzzzzzzzz_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, szzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> tzzzzzzzzzzzzza_ = context.Operators.Union<Condition>(szzzzzzzzzzzzzx_, szzzzzzzzzzzzzz_);
        CqlValueSet tzzzzzzzzzzzzzb_ = this.Complications_of_Pregnancy__Childbirth_and_the_Puerperium(context);
        IEnumerable<Condition> tzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, tzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> tzzzzzzzzzzzzzd_ = context.Operators.Union<Condition>(tzzzzzzzzzzzzza_, tzzzzzzzzzzzzzc_);
        bool? tzzzzzzzzzzzzze_(Condition SexualActivityDiagnosis)
        {
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, SexualActivityDiagnosis);
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzi_ = this.Measurement_Period(context);
            bool? tzzzzzzzzzzzzzj_ = context.Operators.Overlaps(tzzzzzzzzzzzzzh_, tzzzzzzzzzzzzzi_, default);

            return tzzzzzzzzzzzzzj_;
        };
        IEnumerable<Condition> tzzzzzzzzzzzzzf_ = context.Operators.Where<Condition>(tzzzzzzzzzzzzzd_, tzzzzzzzzzzzzze_);
        bool? tzzzzzzzzzzzzzg_ = context.Operators.Exists<Condition>(tzzzzzzzzzzzzzf_);

        return tzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Has Active Contraceptive Medications")]
    public bool? Has_Active_Contraceptive_Medications(CqlContext context)
    {
        CqlValueSet tzzzzzzzzzzzzzk_ = this.Contraceptive_Medications(context);
        IEnumerable<MedicationRequest> tzzzzzzzzzzzzzl_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, tzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> tzzzzzzzzzzzzzn_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, tzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> tzzzzzzzzzzzzzo_ = context.Operators.Union<MedicationRequest>(tzzzzzzzzzzzzzl_, tzzzzzzzzzzzzzn_);
        IEnumerable<MedicationRequest> tzzzzzzzzzzzzzp_ = Status_1_8_000.Instance.isMedicationActive(context, tzzzzzzzzzzzzzo_);
        bool? tzzzzzzzzzzzzzq_(MedicationRequest ActiveContraceptives)
        {
            CqlInterval<CqlDate> tzzzzzzzzzzzzzt_ = CumulativeMedicationDuration_4_1_000.Instance.medicationRequestPeriod(context, ActiveContraceptives);
            CqlDate tzzzzzzzzzzzzzu_ = tzzzzzzzzzzzzzt_?.low;
            CqlDateTime tzzzzzzzzzzzzzv_ = context.Operators.ConvertDateToDateTime(tzzzzzzzzzzzzzu_);
            CqlDate tzzzzzzzzzzzzzx_ = tzzzzzzzzzzzzzt_?.high;
            CqlDateTime tzzzzzzzzzzzzzy_ = context.Operators.ConvertDateToDateTime(tzzzzzzzzzzzzzx_);
            bool? uzzzzzzzzzzzzza_ = tzzzzzzzzzzzzzt_?.lowClosed;
            bool? uzzzzzzzzzzzzzc_ = tzzzzzzzzzzzzzt_?.highClosed;
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzd_ = context.Operators.Interval(tzzzzzzzzzzzzzv_, tzzzzzzzzzzzzzy_, uzzzzzzzzzzzzza_, uzzzzzzzzzzzzzc_);
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzze_ = this.Measurement_Period(context);
            bool? uzzzzzzzzzzzzzf_ = context.Operators.Overlaps(uzzzzzzzzzzzzzd_, uzzzzzzzzzzzzze_, default);

            return uzzzzzzzzzzzzzf_;
        };
        IEnumerable<MedicationRequest> tzzzzzzzzzzzzzr_ = context.Operators.Where<MedicationRequest>(tzzzzzzzzzzzzzp_, tzzzzzzzzzzzzzq_);
        bool? tzzzzzzzzzzzzzs_ = context.Operators.Exists<MedicationRequest>(tzzzzzzzzzzzzzr_);

        return tzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Has Ordered Contraceptive Medications")]
    public bool? Has_Ordered_Contraceptive_Medications(CqlContext context)
    {
        CqlValueSet uzzzzzzzzzzzzzg_ = this.Contraceptive_Medications(context);
        IEnumerable<MedicationRequest> uzzzzzzzzzzzzzh_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, uzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> uzzzzzzzzzzzzzj_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, uzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> uzzzzzzzzzzzzzk_ = context.Operators.Union<MedicationRequest>(uzzzzzzzzzzzzzh_, uzzzzzzzzzzzzzj_);
        IEnumerable<MedicationRequest> uzzzzzzzzzzzzzl_ = Status_1_8_000.Instance.isMedicationOrder(context, uzzzzzzzzzzzzzk_);
        bool? uzzzzzzzzzzzzzm_(MedicationRequest OrderedContraceptives)
        {
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzp_ = this.Measurement_Period(context);
            FhirDateTime uzzzzzzzzzzzzzq_ = OrderedContraceptives?.AuthoredOnElement;
            CqlDateTime uzzzzzzzzzzzzzr_ = context.Operators.Convert<CqlDateTime>(uzzzzzzzzzzzzzq_);
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.toInterval(context, uzzzzzzzzzzzzzr_ as object);
            bool? uzzzzzzzzzzzzzt_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(uzzzzzzzzzzzzzp_, uzzzzzzzzzzzzzs_, "day");

            return uzzzzzzzzzzzzzt_;
        };
        IEnumerable<MedicationRequest> uzzzzzzzzzzzzzn_ = context.Operators.Where<MedicationRequest>(uzzzzzzzzzzzzzl_, uzzzzzzzzzzzzzm_);
        bool? uzzzzzzzzzzzzzo_ = context.Operators.Exists<MedicationRequest>(uzzzzzzzzzzzzzn_);

        return uzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Has Laboratory Tests Identifying Sexual Activity But Not Pregnancy")]
    public bool? Has_Laboratory_Tests_Identifying_Sexual_Activity_But_Not_Pregnancy(CqlContext context)
    {
        CqlValueSet uzzzzzzzzzzzzzu_ = this.Pap_Test(context);
        IEnumerable<ServiceRequest> uzzzzzzzzzzzzzv_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, uzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        CqlValueSet uzzzzzzzzzzzzzw_ = this.Lab_Tests_During_Pregnancy(context);
        IEnumerable<ServiceRequest> uzzzzzzzzzzzzzx_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, uzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> uzzzzzzzzzzzzzy_ = context.Operators.Union<ServiceRequest>(uzzzzzzzzzzzzzv_, uzzzzzzzzzzzzzx_);
        CqlValueSet uzzzzzzzzzzzzzz_ = this.Lab_Tests_for_Sexually_Transmitted_Infections(context);
        IEnumerable<ServiceRequest> vzzzzzzzzzzzzza_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, uzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> vzzzzzzzzzzzzzb_ = context.Operators.Union<ServiceRequest>(uzzzzzzzzzzzzzy_, vzzzzzzzzzzzzza_);
        IEnumerable<ServiceRequest> vzzzzzzzzzzzzzc_ = Status_1_8_000.Instance.isLaboratoryTestOrder(context, vzzzzzzzzzzzzzb_);
        bool? vzzzzzzzzzzzzzd_(ServiceRequest LabOrders)
        {
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzg_ = this.Measurement_Period(context);
            FhirDateTime vzzzzzzzzzzzzzh_ = LabOrders?.AuthoredOnElement;
            CqlDateTime vzzzzzzzzzzzzzi_ = context.Operators.Convert<CqlDateTime>(vzzzzzzzzzzzzzh_);
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.toInterval(context, vzzzzzzzzzzzzzi_ as object);
            bool? vzzzzzzzzzzzzzk_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(vzzzzzzzzzzzzzg_, vzzzzzzzzzzzzzj_, "day");

            return vzzzzzzzzzzzzzk_;
        };
        IEnumerable<ServiceRequest> vzzzzzzzzzzzzze_ = context.Operators.Where<ServiceRequest>(vzzzzzzzzzzzzzc_, vzzzzzzzzzzzzzd_);
        bool? vzzzzzzzzzzzzzf_ = context.Operators.Exists<ServiceRequest>(vzzzzzzzzzzzzze_);

        return vzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Has Laboratory Tests Identifying Sexual Activity")]
    public bool? Has_Laboratory_Tests_Identifying_Sexual_Activity(CqlContext context)
    {
        CqlValueSet vzzzzzzzzzzzzzl_ = this.Pregnancy_Test(context);
        IEnumerable<ServiceRequest> vzzzzzzzzzzzzzm_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, vzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> vzzzzzzzzzzzzzn_ = Status_1_8_000.Instance.isLaboratoryTestOrder(context, vzzzzzzzzzzzzzm_);
        bool? vzzzzzzzzzzzzzo_(ServiceRequest PregnancyTest)
        {
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzt_ = this.Measurement_Period(context);
            FhirDateTime vzzzzzzzzzzzzzu_ = PregnancyTest?.AuthoredOnElement;
            CqlDateTime vzzzzzzzzzzzzzv_ = context.Operators.Convert<CqlDateTime>(vzzzzzzzzzzzzzu_);
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.toInterval(context, vzzzzzzzzzzzzzv_ as object);
            bool? vzzzzzzzzzzzzzx_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(vzzzzzzzzzzzzzt_, vzzzzzzzzzzzzzw_, "day");

            return vzzzzzzzzzzzzzx_;
        };
        IEnumerable<ServiceRequest> vzzzzzzzzzzzzzp_ = context.Operators.Where<ServiceRequest>(vzzzzzzzzzzzzzn_, vzzzzzzzzzzzzzo_);
        bool? vzzzzzzzzzzzzzq_ = context.Operators.Exists<ServiceRequest>(vzzzzzzzzzzzzzp_);
        bool? vzzzzzzzzzzzzzr_ = this.Has_Laboratory_Tests_Identifying_Sexual_Activity_But_Not_Pregnancy(context);
        bool? vzzzzzzzzzzzzzs_ = context.Operators.Or(vzzzzzzzzzzzzzq_, vzzzzzzzzzzzzzr_);

        return vzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Has Diagnostic Studies Identifying Sexual Activity")]
    public bool? Has_Diagnostic_Studies_Identifying_Sexual_Activity(CqlContext context)
    {
        CqlValueSet vzzzzzzzzzzzzzy_ = this.Diagnostic_Studies_During_Pregnancy(context);
        IEnumerable<ServiceRequest> vzzzzzzzzzzzzzz_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, vzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> wzzzzzzzzzzzzza_ = Status_1_8_000.Instance.isDiagnosticStudyOrder(context, vzzzzzzzzzzzzzz_);
        bool? wzzzzzzzzzzzzzb_(ServiceRequest SexualActivityDiagnostics)
        {
            CqlInterval<CqlDateTime> wzzzzzzzzzzzzze_ = this.Measurement_Period(context);
            FhirDateTime wzzzzzzzzzzzzzf_ = SexualActivityDiagnostics?.AuthoredOnElement;
            CqlDateTime wzzzzzzzzzzzzzg_ = context.Operators.Convert<CqlDateTime>(wzzzzzzzzzzzzzf_);
            CqlInterval<CqlDateTime> wzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.toInterval(context, wzzzzzzzzzzzzzg_ as object);
            bool? wzzzzzzzzzzzzzi_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(wzzzzzzzzzzzzze_, wzzzzzzzzzzzzzh_, "day");

            return wzzzzzzzzzzzzzi_;
        };
        IEnumerable<ServiceRequest> wzzzzzzzzzzzzzc_ = context.Operators.Where<ServiceRequest>(wzzzzzzzzzzzzza_, wzzzzzzzzzzzzzb_);
        bool? wzzzzzzzzzzzzzd_ = context.Operators.Exists<ServiceRequest>(wzzzzzzzzzzzzzc_);

        return wzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Has Procedures Identifying Sexual Activity")]
    public bool? Has_Procedures_Identifying_Sexual_Activity(CqlContext context)
    {
        CqlValueSet wzzzzzzzzzzzzzj_ = this.Procedures_Used_to_Indicate_Sexual_Activity(context);
        IEnumerable<Procedure> wzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, wzzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> wzzzzzzzzzzzzzl_ = Status_1_8_000.Instance.isProcedurePerformed(context, wzzzzzzzzzzzzzk_);
        bool? wzzzzzzzzzzzzzm_(Procedure ProceduresForSexualActivity)
        {
            CqlInterval<CqlDateTime> wzzzzzzzzzzzzzp_ = this.Measurement_Period(context);
            DataType wzzzzzzzzzzzzzq_ = ProceduresForSexualActivity?.Performed;
            object wzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzq_);
            CqlInterval<CqlDateTime> wzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.toInterval(context, wzzzzzzzzzzzzzr_);
            bool? wzzzzzzzzzzzzzt_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(wzzzzzzzzzzzzzp_, wzzzzzzzzzzzzzs_, "day");

            return wzzzzzzzzzzzzzt_;
        };
        IEnumerable<Procedure> wzzzzzzzzzzzzzn_ = context.Operators.Where<Procedure>(wzzzzzzzzzzzzzl_, wzzzzzzzzzzzzzm_);
        bool? wzzzzzzzzzzzzzo_ = context.Operators.Exists<Procedure>(wzzzzzzzzzzzzzn_);

        return wzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient wzzzzzzzzzzzzzu_ = this.Patient(context);
        Date wzzzzzzzzzzzzzv_ = wzzzzzzzzzzzzzu_?.BirthDateElement;
        string wzzzzzzzzzzzzzw_ = wzzzzzzzzzzzzzv_?.Value;
        CqlDate wzzzzzzzzzzzzzx_ = context.Operators.ConvertStringToDate(wzzzzzzzzzzzzzw_);
        CqlInterval<CqlDateTime> wzzzzzzzzzzzzzy_ = this.Measurement_Period(context);
        CqlDateTime wzzzzzzzzzzzzzz_ = context.Operators.End(wzzzzzzzzzzzzzy_);
        CqlDate xzzzzzzzzzzzzza_ = context.Operators.DateFrom(wzzzzzzzzzzzzzz_);
        int? xzzzzzzzzzzzzzb_ = context.Operators.CalculateAgeAt(wzzzzzzzzzzzzzx_, xzzzzzzzzzzzzza_, "year");
        CqlInterval<int?> xzzzzzzzzzzzzzc_ = context.Operators.Interval(16, 24, true, true);
        bool? xzzzzzzzzzzzzzd_ = context.Operators.In<int?>(xzzzzzzzzzzzzzb_, xzzzzzzzzzzzzzc_, default);
        Code<AdministrativeGender> xzzzzzzzzzzzzzf_ = wzzzzzzzzzzzzzu_?.GenderElement;
        AdministrativeGender? xzzzzzzzzzzzzzg_ = xzzzzzzzzzzzzzf_?.Value;
        string xzzzzzzzzzzzzzh_ = context.Operators.Convert<string>(xzzzzzzzzzzzzzg_);
        bool? xzzzzzzzzzzzzzi_ = context.Operators.Equal(xzzzzzzzzzzzzzh_, "female");
        bool? xzzzzzzzzzzzzzj_ = context.Operators.And(xzzzzzzzzzzzzzd_, xzzzzzzzzzzzzzi_);
        IEnumerable<Encounter> xzzzzzzzzzzzzzk_ = this.Qualifying_Encounters(context);
        bool? xzzzzzzzzzzzzzl_ = context.Operators.Exists<Encounter>(xzzzzzzzzzzzzzk_);
        bool? xzzzzzzzzzzzzzm_ = context.Operators.And(xzzzzzzzzzzzzzj_, xzzzzzzzzzzzzzl_);
        bool? xzzzzzzzzzzzzzn_ = this.Has_Assessments_Identifying_Sexual_Activity(context);
        bool? xzzzzzzzzzzzzzo_ = this.Has_Diagnoses_Identifying_Sexual_Activity(context);
        bool? xzzzzzzzzzzzzzp_ = context.Operators.Or(xzzzzzzzzzzzzzn_, xzzzzzzzzzzzzzo_);
        bool? xzzzzzzzzzzzzzq_ = this.Has_Active_Contraceptive_Medications(context);
        bool? xzzzzzzzzzzzzzr_ = context.Operators.Or(xzzzzzzzzzzzzzp_, xzzzzzzzzzzzzzq_);
        bool? xzzzzzzzzzzzzzs_ = this.Has_Ordered_Contraceptive_Medications(context);
        bool? xzzzzzzzzzzzzzt_ = context.Operators.Or(xzzzzzzzzzzzzzr_, xzzzzzzzzzzzzzs_);
        bool? xzzzzzzzzzzzzzu_ = this.Has_Laboratory_Tests_Identifying_Sexual_Activity(context);
        bool? xzzzzzzzzzzzzzv_ = context.Operators.Or(xzzzzzzzzzzzzzt_, xzzzzzzzzzzzzzu_);
        bool? xzzzzzzzzzzzzzw_ = this.Has_Diagnostic_Studies_Identifying_Sexual_Activity(context);
        bool? xzzzzzzzzzzzzzx_ = context.Operators.Or(xzzzzzzzzzzzzzv_, xzzzzzzzzzzzzzw_);
        bool? xzzzzzzzzzzzzzy_ = this.Has_Procedures_Identifying_Sexual_Activity(context);
        bool? xzzzzzzzzzzzzzz_ = context.Operators.Or(xzzzzzzzzzzzzzx_, xzzzzzzzzzzzzzy_);
        bool? yzzzzzzzzzzzzza_ = context.Operators.And(xzzzzzzzzzzzzzm_, xzzzzzzzzzzzzzz_);

        return yzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? yzzzzzzzzzzzzzb_ = this.Initial_Population(context);

        return yzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Has Pregnancy Test Exclusion")]
    public bool? Has_Pregnancy_Test_Exclusion(CqlContext context)
    {
        CqlValueSet yzzzzzzzzzzzzzc_ = this.Pregnancy_Test(context);
        IEnumerable<ServiceRequest> yzzzzzzzzzzzzzd_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, yzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> yzzzzzzzzzzzzze_ = Status_1_8_000.Instance.isLaboratoryTestOrder(context, yzzzzzzzzzzzzzd_);
        IEnumerable<ServiceRequest> yzzzzzzzzzzzzzf_(ServiceRequest PregnancyTest)
        {
            CqlValueSet yzzzzzzzzzzzzzs_ = this.XRay_Study(context);
            IEnumerable<ServiceRequest> yzzzzzzzzzzzzzt_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, yzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
            IEnumerable<ServiceRequest> yzzzzzzzzzzzzzu_ = Status_1_8_000.Instance.isDiagnosticStudyOrder(context, yzzzzzzzzzzzzzt_);
            bool? yzzzzzzzzzzzzzv_(ServiceRequest XrayOrder)
            {
                FhirDateTime yzzzzzzzzzzzzzz_ = XrayOrder?.AuthoredOnElement;
                CqlDateTime zzzzzzzzzzzzzza_ = context.Operators.Convert<CqlDateTime>(yzzzzzzzzzzzzzz_);
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.toInterval(context, zzzzzzzzzzzzzza_ as object);
                CqlDateTime zzzzzzzzzzzzzzc_ = context.Operators.Start(zzzzzzzzzzzzzzb_);
                FhirDateTime zzzzzzzzzzzzzzd_ = PregnancyTest?.AuthoredOnElement;
                CqlDateTime zzzzzzzzzzzzzze_ = context.Operators.Convert<CqlDateTime>(zzzzzzzzzzzzzzd_);
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.toInterval(context, zzzzzzzzzzzzzze_ as object);
                CqlDateTime zzzzzzzzzzzzzzg_ = context.Operators.End(zzzzzzzzzzzzzzf_);
                CqlDateTime zzzzzzzzzzzzzzi_ = context.Operators.Convert<CqlDateTime>(zzzzzzzzzzzzzzd_);
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.toInterval(context, zzzzzzzzzzzzzzi_ as object);
                CqlDateTime zzzzzzzzzzzzzzk_ = context.Operators.End(zzzzzzzzzzzzzzj_);
                CqlQuantity zzzzzzzzzzzzzzl_ = context.Operators.Quantity(6m, "days");
                CqlDateTime zzzzzzzzzzzzzzm_ = context.Operators.Add(zzzzzzzzzzzzzzk_, zzzzzzzzzzzzzzl_);
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzn_ = context.Operators.Interval(zzzzzzzzzzzzzzg_, zzzzzzzzzzzzzzm_, true, true);
                bool? zzzzzzzzzzzzzzo_ = context.Operators.In<CqlDateTime>(zzzzzzzzzzzzzzc_, zzzzzzzzzzzzzzn_, "day");
                CqlDateTime zzzzzzzzzzzzzzq_ = context.Operators.Convert<CqlDateTime>(zzzzzzzzzzzzzzd_);
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.toInterval(context, zzzzzzzzzzzzzzq_ as object);
                CqlDateTime zzzzzzzzzzzzzzs_ = context.Operators.End(zzzzzzzzzzzzzzr_);
                bool? zzzzzzzzzzzzzzt_ = context.Operators.Not((bool?)(zzzzzzzzzzzzzzs_ is null));
                bool? zzzzzzzzzzzzzzu_ = context.Operators.And(zzzzzzzzzzzzzzo_, zzzzzzzzzzzzzzt_);

                return zzzzzzzzzzzzzzu_;
            };
            IEnumerable<ServiceRequest> yzzzzzzzzzzzzzw_ = context.Operators.Where<ServiceRequest>(yzzzzzzzzzzzzzu_, yzzzzzzzzzzzzzv_);
            ServiceRequest yzzzzzzzzzzzzzx_(ServiceRequest XrayOrder) =>
                PregnancyTest;
            IEnumerable<ServiceRequest> yzzzzzzzzzzzzzy_ = context.Operators.Select<ServiceRequest, ServiceRequest>(yzzzzzzzzzzzzzw_, yzzzzzzzzzzzzzx_);

            return yzzzzzzzzzzzzzy_;
        };
        IEnumerable<ServiceRequest> yzzzzzzzzzzzzzg_ = context.Operators.SelectMany<ServiceRequest, ServiceRequest>(yzzzzzzzzzzzzze_, yzzzzzzzzzzzzzf_);
        bool? yzzzzzzzzzzzzzh_(ServiceRequest PregnancyTest)
        {
            CqlInterval<CqlDateTime> zzzzzzzzzzzzzzv_ = this.Measurement_Period(context);
            FhirDateTime zzzzzzzzzzzzzzw_ = PregnancyTest?.AuthoredOnElement;
            CqlDateTime zzzzzzzzzzzzzzx_ = context.Operators.Convert<CqlDateTime>(zzzzzzzzzzzzzzw_);
            CqlInterval<CqlDateTime> zzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.toInterval(context, zzzzzzzzzzzzzzx_ as object);
            bool? zzzzzzzzzzzzzzz_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(zzzzzzzzzzzzzzv_, zzzzzzzzzzzzzzy_, default);

            return zzzzzzzzzzzzzzz_;
        };
        IEnumerable<ServiceRequest> yzzzzzzzzzzzzzi_ = context.Operators.Where<ServiceRequest>(yzzzzzzzzzzzzzg_, yzzzzzzzzzzzzzh_);
        IEnumerable<ServiceRequest> yzzzzzzzzzzzzzk_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, yzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> yzzzzzzzzzzzzzl_ = Status_1_8_000.Instance.isLaboratoryTestOrder(context, yzzzzzzzzzzzzzk_);
        IEnumerable<ServiceRequest> yzzzzzzzzzzzzzm_(ServiceRequest PregnancyTestOrder)
        {
            CqlValueSet azzzzzzzzzzzzzza_ = this.Isotretinoin(context);
            IEnumerable<MedicationRequest> azzzzzzzzzzzzzzb_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, azzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> azzzzzzzzzzzzzzd_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, azzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> azzzzzzzzzzzzzze_ = context.Operators.Union<MedicationRequest>(azzzzzzzzzzzzzzb_, azzzzzzzzzzzzzzd_);
            IEnumerable<MedicationRequest> azzzzzzzzzzzzzzf_ = Status_1_8_000.Instance.isMedicationOrder(context, azzzzzzzzzzzzzze_);
            bool? azzzzzzzzzzzzzzg_(MedicationRequest AccutaneOrder)
            {
                FhirDateTime azzzzzzzzzzzzzzk_ = AccutaneOrder?.AuthoredOnElement;
                CqlDateTime azzzzzzzzzzzzzzl_ = context.Operators.Convert<CqlDateTime>(azzzzzzzzzzzzzzk_);
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.toInterval(context, azzzzzzzzzzzzzzl_ as object);
                CqlDateTime azzzzzzzzzzzzzzn_ = context.Operators.Start(azzzzzzzzzzzzzzm_);
                FhirDateTime azzzzzzzzzzzzzzo_ = PregnancyTestOrder?.AuthoredOnElement;
                CqlDateTime azzzzzzzzzzzzzzp_ = context.Operators.Convert<CqlDateTime>(azzzzzzzzzzzzzzo_);
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.toInterval(context, azzzzzzzzzzzzzzp_ as object);
                CqlDateTime azzzzzzzzzzzzzzr_ = context.Operators.End(azzzzzzzzzzzzzzq_);
                CqlDateTime azzzzzzzzzzzzzzt_ = context.Operators.Convert<CqlDateTime>(azzzzzzzzzzzzzzo_);
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.toInterval(context, azzzzzzzzzzzzzzt_ as object);
                CqlDateTime azzzzzzzzzzzzzzv_ = context.Operators.End(azzzzzzzzzzzzzzu_);
                CqlQuantity azzzzzzzzzzzzzzw_ = context.Operators.Quantity(6m, "days");
                CqlDateTime azzzzzzzzzzzzzzx_ = context.Operators.Add(azzzzzzzzzzzzzzv_, azzzzzzzzzzzzzzw_);
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzzy_ = context.Operators.Interval(azzzzzzzzzzzzzzr_, azzzzzzzzzzzzzzx_, true, true);
                bool? azzzzzzzzzzzzzzz_ = context.Operators.In<CqlDateTime>(azzzzzzzzzzzzzzn_, azzzzzzzzzzzzzzy_, "day");
                CqlDateTime bzzzzzzzzzzzzzzb_ = context.Operators.Convert<CqlDateTime>(azzzzzzzzzzzzzzo_);
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.toInterval(context, bzzzzzzzzzzzzzzb_ as object);
                CqlDateTime bzzzzzzzzzzzzzzd_ = context.Operators.End(bzzzzzzzzzzzzzzc_);
                bool? bzzzzzzzzzzzzzze_ = context.Operators.Not((bool?)(bzzzzzzzzzzzzzzd_ is null));
                bool? bzzzzzzzzzzzzzzf_ = context.Operators.And(azzzzzzzzzzzzzzz_, bzzzzzzzzzzzzzze_);

                return bzzzzzzzzzzzzzzf_;
            };
            IEnumerable<MedicationRequest> azzzzzzzzzzzzzzh_ = context.Operators.Where<MedicationRequest>(azzzzzzzzzzzzzzf_, azzzzzzzzzzzzzzg_);
            ServiceRequest azzzzzzzzzzzzzzi_(MedicationRequest AccutaneOrder) =>
                PregnancyTestOrder;
            IEnumerable<ServiceRequest> azzzzzzzzzzzzzzj_ = context.Operators.Select<MedicationRequest, ServiceRequest>(azzzzzzzzzzzzzzh_, azzzzzzzzzzzzzzi_);

            return azzzzzzzzzzzzzzj_;
        };
        IEnumerable<ServiceRequest> yzzzzzzzzzzzzzn_ = context.Operators.SelectMany<ServiceRequest, ServiceRequest>(yzzzzzzzzzzzzzl_, yzzzzzzzzzzzzzm_);
        bool? yzzzzzzzzzzzzzo_(ServiceRequest PregnancyTestOrder)
        {
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzg_ = this.Measurement_Period(context);
            FhirDateTime bzzzzzzzzzzzzzzh_ = PregnancyTestOrder?.AuthoredOnElement;
            CqlDateTime bzzzzzzzzzzzzzzi_ = context.Operators.Convert<CqlDateTime>(bzzzzzzzzzzzzzzh_);
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.toInterval(context, bzzzzzzzzzzzzzzi_ as object);
            bool? bzzzzzzzzzzzzzzk_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(bzzzzzzzzzzzzzzg_, bzzzzzzzzzzzzzzj_, default);

            return bzzzzzzzzzzzzzzk_;
        };
        IEnumerable<ServiceRequest> yzzzzzzzzzzzzzp_ = context.Operators.Where<ServiceRequest>(yzzzzzzzzzzzzzn_, yzzzzzzzzzzzzzo_);
        IEnumerable<ServiceRequest> yzzzzzzzzzzzzzq_ = context.Operators.Union<ServiceRequest>(yzzzzzzzzzzzzzi_, yzzzzzzzzzzzzzp_);
        bool? yzzzzzzzzzzzzzr_ = context.Operators.Exists<ServiceRequest>(yzzzzzzzzzzzzzq_);

        return yzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? bzzzzzzzzzzzzzzl_ = Hospice_6_12_000.Instance.Has_Hospice_Services(context);
        bool? bzzzzzzzzzzzzzzm_ = this.Has_Pregnancy_Test_Exclusion(context);
        bool? bzzzzzzzzzzzzzzn_ = this.Has_Assessments_Identifying_Sexual_Activity(context);
        bool? bzzzzzzzzzzzzzzo_ = context.Operators.Not(bzzzzzzzzzzzzzzn_);
        bool? bzzzzzzzzzzzzzzp_ = context.Operators.And(bzzzzzzzzzzzzzzm_, bzzzzzzzzzzzzzzo_);
        bool? bzzzzzzzzzzzzzzq_ = this.Has_Diagnoses_Identifying_Sexual_Activity(context);
        bool? bzzzzzzzzzzzzzzr_ = context.Operators.Not(bzzzzzzzzzzzzzzq_);
        bool? bzzzzzzzzzzzzzzs_ = context.Operators.And(bzzzzzzzzzzzzzzp_, bzzzzzzzzzzzzzzr_);
        bool? bzzzzzzzzzzzzzzt_ = this.Has_Active_Contraceptive_Medications(context);
        bool? bzzzzzzzzzzzzzzu_ = context.Operators.Not(bzzzzzzzzzzzzzzt_);
        bool? bzzzzzzzzzzzzzzv_ = context.Operators.And(bzzzzzzzzzzzzzzs_, bzzzzzzzzzzzzzzu_);
        bool? bzzzzzzzzzzzzzzw_ = this.Has_Ordered_Contraceptive_Medications(context);
        bool? bzzzzzzzzzzzzzzx_ = context.Operators.Not(bzzzzzzzzzzzzzzw_);
        bool? bzzzzzzzzzzzzzzy_ = context.Operators.And(bzzzzzzzzzzzzzzv_, bzzzzzzzzzzzzzzx_);
        bool? bzzzzzzzzzzzzzzz_ = this.Has_Laboratory_Tests_Identifying_Sexual_Activity_But_Not_Pregnancy(context);
        bool? czzzzzzzzzzzzzza_ = context.Operators.Not(bzzzzzzzzzzzzzzz_);
        bool? czzzzzzzzzzzzzzb_ = context.Operators.And(bzzzzzzzzzzzzzzy_, czzzzzzzzzzzzzza_);
        bool? czzzzzzzzzzzzzzc_ = this.Has_Diagnostic_Studies_Identifying_Sexual_Activity(context);
        bool? czzzzzzzzzzzzzzd_ = context.Operators.Not(czzzzzzzzzzzzzzc_);
        bool? czzzzzzzzzzzzzze_ = context.Operators.And(czzzzzzzzzzzzzzb_, czzzzzzzzzzzzzzd_);
        bool? czzzzzzzzzzzzzzf_ = this.Has_Procedures_Identifying_Sexual_Activity(context);
        bool? czzzzzzzzzzzzzzg_ = context.Operators.Not(czzzzzzzzzzzzzzf_);
        bool? czzzzzzzzzzzzzzh_ = context.Operators.And(czzzzzzzzzzzzzze_, czzzzzzzzzzzzzzg_);
        bool? czzzzzzzzzzzzzzi_ = context.Operators.Or(bzzzzzzzzzzzzzzl_, czzzzzzzzzzzzzzh_);

        return czzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        CqlValueSet czzzzzzzzzzzzzzj_ = this.Chlamydia_Screening(context);
        IEnumerable<Observation> czzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, czzzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> czzzzzzzzzzzzzzl_ = Status_1_8_000.Instance.isLaboratoryTestPerformed(context, czzzzzzzzzzzzzzk_);
        bool? czzzzzzzzzzzzzzm_(Observation ChlamydiaTest)
        {
            object czzzzzzzzzzzzzzp_()
            {
                bool czzzzzzzzzzzzzzx_()
                {
                    DataType dzzzzzzzzzzzzzza_ = ChlamydiaTest?.Effective;
                    object dzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzza_);
                    bool dzzzzzzzzzzzzzzc_ = dzzzzzzzzzzzzzzb_ is CqlDateTime;

                    return dzzzzzzzzzzzzzzc_;
                };
                bool czzzzzzzzzzzzzzy_()
                {
                    DataType dzzzzzzzzzzzzzzd_ = ChlamydiaTest?.Effective;
                    object dzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzd_);
                    bool dzzzzzzzzzzzzzzf_ = dzzzzzzzzzzzzzze_ is CqlInterval<CqlDateTime>;

                    return dzzzzzzzzzzzzzzf_;
                };
                bool czzzzzzzzzzzzzzz_()
                {
                    DataType dzzzzzzzzzzzzzzg_ = ChlamydiaTest?.Effective;
                    object dzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzg_);
                    bool dzzzzzzzzzzzzzzi_ = dzzzzzzzzzzzzzzh_ is CqlDateTime;

                    return dzzzzzzzzzzzzzzi_;
                };
                if (czzzzzzzzzzzzzzx_())
                {
                    DataType dzzzzzzzzzzzzzzj_ = ChlamydiaTest?.Effective;
                    object dzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzj_);

                    return (dzzzzzzzzzzzzzzk_ as CqlDateTime) as object;
                }
                else if (czzzzzzzzzzzzzzy_())
                {
                    DataType dzzzzzzzzzzzzzzl_ = ChlamydiaTest?.Effective;
                    object dzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzl_);

                    return (dzzzzzzzzzzzzzzm_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (czzzzzzzzzzzzzzz_())
                {
                    DataType dzzzzzzzzzzzzzzn_ = ChlamydiaTest?.Effective;
                    object dzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzn_);

                    return (dzzzzzzzzzzzzzzo_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime czzzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.latest(context, czzzzzzzzzzzzzzp_());
            CqlInterval<CqlDateTime> czzzzzzzzzzzzzzr_ = this.Measurement_Period(context);
            bool? czzzzzzzzzzzzzzs_ = context.Operators.In<CqlDateTime>(czzzzzzzzzzzzzzq_, czzzzzzzzzzzzzzr_, "day");
            DataType czzzzzzzzzzzzzzt_ = ChlamydiaTest?.Value;
            object czzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzt_);
            bool? czzzzzzzzzzzzzzv_ = context.Operators.Not((bool?)(czzzzzzzzzzzzzzu_ is null));
            bool? czzzzzzzzzzzzzzw_ = context.Operators.And(czzzzzzzzzzzzzzs_, czzzzzzzzzzzzzzv_);

            return czzzzzzzzzzzzzzw_;
        };
        IEnumerable<Observation> czzzzzzzzzzzzzzn_ = context.Operators.Where<Observation>(czzzzzzzzzzzzzzl_, czzzzzzzzzzzzzzm_);
        bool? czzzzzzzzzzzzzzo_ = context.Operators.Exists<Observation>(czzzzzzzzzzzzzzn_);

        return czzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Stratification 1")]
    public bool? Stratification_1(CqlContext context)
    {
        Patient dzzzzzzzzzzzzzzp_ = this.Patient(context);
        Date dzzzzzzzzzzzzzzq_ = dzzzzzzzzzzzzzzp_?.BirthDateElement;
        string dzzzzzzzzzzzzzzr_ = dzzzzzzzzzzzzzzq_?.Value;
        CqlDate dzzzzzzzzzzzzzzs_ = context.Operators.ConvertStringToDate(dzzzzzzzzzzzzzzr_);
        CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzt_ = this.Measurement_Period(context);
        CqlDateTime dzzzzzzzzzzzzzzu_ = context.Operators.End(dzzzzzzzzzzzzzzt_);
        CqlDate dzzzzzzzzzzzzzzv_ = context.Operators.DateFrom(dzzzzzzzzzzzzzzu_);
        int? dzzzzzzzzzzzzzzw_ = context.Operators.CalculateAgeAt(dzzzzzzzzzzzzzzs_, dzzzzzzzzzzzzzzv_, "year");
        CqlInterval<int?> dzzzzzzzzzzzzzzx_ = context.Operators.Interval(16, 20, true, true);
        bool? dzzzzzzzzzzzzzzy_ = context.Operators.In<int?>(dzzzzzzzzzzzzzzw_, dzzzzzzzzzzzzzzx_, default);

        return dzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Stratification 2")]
    public bool? Stratification_2(CqlContext context)
    {
        Patient dzzzzzzzzzzzzzzz_ = this.Patient(context);
        Date ezzzzzzzzzzzzzza_ = dzzzzzzzzzzzzzzz_?.BirthDateElement;
        string ezzzzzzzzzzzzzzb_ = ezzzzzzzzzzzzzza_?.Value;
        CqlDate ezzzzzzzzzzzzzzc_ = context.Operators.ConvertStringToDate(ezzzzzzzzzzzzzzb_);
        CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzd_ = this.Measurement_Period(context);
        CqlDateTime ezzzzzzzzzzzzzze_ = context.Operators.End(ezzzzzzzzzzzzzzd_);
        CqlDate ezzzzzzzzzzzzzzf_ = context.Operators.DateFrom(ezzzzzzzzzzzzzze_);
        int? ezzzzzzzzzzzzzzg_ = context.Operators.CalculateAgeAt(ezzzzzzzzzzzzzzc_, ezzzzzzzzzzzzzzf_, "year");
        CqlInterval<int?> ezzzzzzzzzzzzzzh_ = context.Operators.Interval(21, 24, true, true);
        bool? ezzzzzzzzzzzzzzi_ = context.Operators.In<int?>(ezzzzzzzzzzzzzzg_, ezzzzzzzzzzzzzzh_, default);

        return ezzzzzzzzzzzzzzi_;
    }


    #endregion Expressions

}
