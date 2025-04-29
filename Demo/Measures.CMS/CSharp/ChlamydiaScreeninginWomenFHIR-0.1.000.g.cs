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
        CqlDateTime ozzzzzzzzzzw_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime ozzzzzzzzzzx_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> ozzzzzzzzzzy_ = context.Operators.Interval(ozzzzzzzzzzw_, ozzzzzzzzzzx_, true, true);
        object ozzzzzzzzzzz_ = context.ResolveParameter("ChlamydiaScreeninginWomenFHIR-0.1.000", "Measurement Period", ozzzzzzzzzzy_);

        return (CqlInterval<CqlDateTime>)ozzzzzzzzzzz_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> pzzzzzzzzzza_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient pzzzzzzzzzzb_ = context.Operators.SingletonFrom<Patient>(pzzzzzzzzzza_);

        return pzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? pzzzzzzzzzzc_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return pzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> pzzzzzzzzzzd_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return pzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? pzzzzzzzzzze_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return pzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode pzzzzzzzzzzf_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return pzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Qualifying Encounters")]
    public IEnumerable<Encounter> Qualifying_Encounters(CqlContext context)
    {
        CqlValueSet pzzzzzzzzzzg_ = this.Office_Visit(context);
        IEnumerable<Encounter> pzzzzzzzzzzh_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, pzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet pzzzzzzzzzzi_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> pzzzzzzzzzzj_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, pzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> pzzzzzzzzzzk_ = context.Operators.Union<Encounter>(pzzzzzzzzzzh_, pzzzzzzzzzzj_);
        CqlValueSet pzzzzzzzzzzl_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> pzzzzzzzzzzm_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, pzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet pzzzzzzzzzzn_ = this.Preventive_Care_Services__Initial_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> pzzzzzzzzzzo_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, pzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> pzzzzzzzzzzp_ = context.Operators.Union<Encounter>(pzzzzzzzzzzm_, pzzzzzzzzzzo_);
        IEnumerable<Encounter> pzzzzzzzzzzq_ = context.Operators.Union<Encounter>(pzzzzzzzzzzk_, pzzzzzzzzzzp_);
        CqlValueSet pzzzzzzzzzzr_ = this.Preventive_Care__Established_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> pzzzzzzzzzzs_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, pzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet pzzzzzzzzzzt_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter> pzzzzzzzzzzu_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, pzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> pzzzzzzzzzzv_ = context.Operators.Union<Encounter>(pzzzzzzzzzzs_, pzzzzzzzzzzu_);
        IEnumerable<Encounter> pzzzzzzzzzzw_ = context.Operators.Union<Encounter>(pzzzzzzzzzzq_, pzzzzzzzzzzv_);
        CqlValueSet pzzzzzzzzzzx_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> pzzzzzzzzzzy_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, pzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet pzzzzzzzzzzz_ = this.Virtual_Encounter(context);
        IEnumerable<Encounter> qzzzzzzzzzza_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, pzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> qzzzzzzzzzzb_ = context.Operators.Union<Encounter>(pzzzzzzzzzzy_, qzzzzzzzzzza_);
        IEnumerable<Encounter> qzzzzzzzzzzc_ = context.Operators.Union<Encounter>(pzzzzzzzzzzw_, qzzzzzzzzzzb_);
        IEnumerable<Encounter> qzzzzzzzzzzd_ = Status_1_8_000.Instance.isEncounterPerformed(context, qzzzzzzzzzzc_);
        bool? qzzzzzzzzzze_(Encounter ValidEncounters)
        {
            CqlInterval<CqlDateTime> qzzzzzzzzzzg_ = this.Measurement_Period(context);
            Period qzzzzzzzzzzh_ = ValidEncounters?.Period;
            CqlInterval<CqlDateTime> qzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzzzzzzh_);
            CqlInterval<CqlDateTime> qzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.toInterval(context, qzzzzzzzzzzi_ as object);
            bool? qzzzzzzzzzzk_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(qzzzzzzzzzzg_, qzzzzzzzzzzj_, "day");

            return qzzzzzzzzzzk_;
        };
        IEnumerable<Encounter> qzzzzzzzzzzf_ = context.Operators.Where<Encounter>(qzzzzzzzzzzd_, qzzzzzzzzzze_);

        return qzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Has Assessments Identifying Sexual Activity")]
    public bool? Has_Assessments_Identifying_Sexual_Activity(CqlContext context)
    {
        CqlCode qzzzzzzzzzzl_ = this.Have_you_ever_had_vaginal_intercourse__PhenX_(context);
        IEnumerable<CqlCode> qzzzzzzzzzzm_ = context.Operators.ToList<CqlCode>(qzzzzzzzzzzl_);
        IEnumerable<Observation> qzzzzzzzzzzn_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, qzzzzzzzzzzm_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> qzzzzzzzzzzo_ = Status_1_8_000.Instance.isAssessmentPerformed(context, qzzzzzzzzzzn_);
        bool? qzzzzzzzzzzp_(Observation SexualActivityAssessment)
        {
            DataType qzzzzzzzzzzs_ = SexualActivityAssessment?.Value;
            object qzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzs_);
            CqlCode qzzzzzzzzzzu_ = this.Yes__qualifier_value_(context);
            CqlConcept qzzzzzzzzzzv_ = context.Operators.ConvertCodeToConcept(qzzzzzzzzzzu_);
            bool? qzzzzzzzzzzw_ = context.Operators.Equivalent(qzzzzzzzzzzt_ as CqlConcept, qzzzzzzzzzzv_);
            DataType qzzzzzzzzzzx_ = SexualActivityAssessment?.Effective;
            object qzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzx_);
            CqlInterval<CqlDateTime> qzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.toInterval(context, qzzzzzzzzzzy_);
            CqlInterval<CqlDateTime> rzzzzzzzzzza_()
            {
                bool rzzzzzzzzzzd_()
                {
                    CqlInterval<CqlDateTime> rzzzzzzzzzze_ = this.Measurement_Period(context);
                    CqlDateTime rzzzzzzzzzzf_ = context.Operators.End(rzzzzzzzzzze_);

                    return rzzzzzzzzzzf_ is null;
                };
                if (rzzzzzzzzzzd_())
                {
                    return default;
                }
                else
                {
                    CqlInterval<CqlDateTime> rzzzzzzzzzzg_ = this.Measurement_Period(context);
                    CqlDateTime rzzzzzzzzzzh_ = context.Operators.End(rzzzzzzzzzzg_);
                    CqlDateTime rzzzzzzzzzzj_ = context.Operators.End(rzzzzzzzzzzg_);
                    CqlInterval<CqlDateTime> rzzzzzzzzzzk_ = context.Operators.Interval(rzzzzzzzzzzh_, rzzzzzzzzzzj_, true, true);

                    return rzzzzzzzzzzk_;
                }
            };
            bool? rzzzzzzzzzzb_ = context.Operators.SameOrBefore(qzzzzzzzzzzz_, rzzzzzzzzzza_(), default);
            bool? rzzzzzzzzzzc_ = context.Operators.And(qzzzzzzzzzzw_, rzzzzzzzzzzb_);

            return rzzzzzzzzzzc_;
        };
        IEnumerable<Observation> qzzzzzzzzzzq_ = context.Operators.Where<Observation>(qzzzzzzzzzzo_, qzzzzzzzzzzp_);
        bool? qzzzzzzzzzzr_ = context.Operators.Exists<Observation>(qzzzzzzzzzzq_);

        return qzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Has Diagnoses Identifying Sexual Activity")]
    public bool? Has_Diagnoses_Identifying_Sexual_Activity(CqlContext context)
    {
        CqlValueSet rzzzzzzzzzzl_ = this.Diagnoses_Used_to_Indicate_Sexual_Activity(context);
        IEnumerable<Condition> rzzzzzzzzzzm_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, rzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet rzzzzzzzzzzn_ = this.HIV(context);
        IEnumerable<Condition> rzzzzzzzzzzo_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, rzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> rzzzzzzzzzzp_ = context.Operators.Union<Condition>(rzzzzzzzzzzm_, rzzzzzzzzzzo_);
        CqlValueSet rzzzzzzzzzzq_ = this.Complications_of_Pregnancy__Childbirth_and_the_Puerperium(context);
        IEnumerable<Condition> rzzzzzzzzzzr_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, rzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> rzzzzzzzzzzs_ = context.Operators.Union<Condition>(rzzzzzzzzzzp_, rzzzzzzzzzzr_);
        bool? rzzzzzzzzzzt_(Condition SexualActivityDiagnosis)
        {
            CqlInterval<CqlDateTime> rzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, SexualActivityDiagnosis);
            CqlInterval<CqlDateTime> rzzzzzzzzzzx_ = this.Measurement_Period(context);
            bool? rzzzzzzzzzzy_ = context.Operators.Overlaps(rzzzzzzzzzzw_, rzzzzzzzzzzx_, default);

            return rzzzzzzzzzzy_;
        };
        IEnumerable<Condition> rzzzzzzzzzzu_ = context.Operators.Where<Condition>(rzzzzzzzzzzs_, rzzzzzzzzzzt_);
        bool? rzzzzzzzzzzv_ = context.Operators.Exists<Condition>(rzzzzzzzzzzu_);

        return rzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Has Active Contraceptive Medications")]
    public bool? Has_Active_Contraceptive_Medications(CqlContext context)
    {
        CqlValueSet rzzzzzzzzzzz_ = this.Contraceptive_Medications(context);
        IEnumerable<MedicationRequest> szzzzzzzzzza_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, rzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> szzzzzzzzzzc_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, rzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> szzzzzzzzzzd_ = context.Operators.Union<MedicationRequest>(szzzzzzzzzza_, szzzzzzzzzzc_);
        IEnumerable<MedicationRequest> szzzzzzzzzze_ = Status_1_8_000.Instance.isMedicationActive(context, szzzzzzzzzzd_);
        bool? szzzzzzzzzzf_(MedicationRequest ActiveContraceptives)
        {
            CqlInterval<CqlDate> szzzzzzzzzzi_ = CumulativeMedicationDuration_4_1_000.Instance.medicationRequestPeriod(context, ActiveContraceptives);
            CqlDate szzzzzzzzzzj_ = szzzzzzzzzzi_?.low;
            CqlDateTime szzzzzzzzzzk_ = context.Operators.ConvertDateToDateTime(szzzzzzzzzzj_);
            CqlDate szzzzzzzzzzm_ = szzzzzzzzzzi_?.high;
            CqlDateTime szzzzzzzzzzn_ = context.Operators.ConvertDateToDateTime(szzzzzzzzzzm_);
            bool? szzzzzzzzzzp_ = szzzzzzzzzzi_?.lowClosed;
            bool? szzzzzzzzzzr_ = szzzzzzzzzzi_?.highClosed;
            CqlInterval<CqlDateTime> szzzzzzzzzzs_ = context.Operators.Interval(szzzzzzzzzzk_, szzzzzzzzzzn_, szzzzzzzzzzp_, szzzzzzzzzzr_);
            CqlInterval<CqlDateTime> szzzzzzzzzzt_ = this.Measurement_Period(context);
            bool? szzzzzzzzzzu_ = context.Operators.Overlaps(szzzzzzzzzzs_, szzzzzzzzzzt_, default);

            return szzzzzzzzzzu_;
        };
        IEnumerable<MedicationRequest> szzzzzzzzzzg_ = context.Operators.Where<MedicationRequest>(szzzzzzzzzze_, szzzzzzzzzzf_);
        bool? szzzzzzzzzzh_ = context.Operators.Exists<MedicationRequest>(szzzzzzzzzzg_);

        return szzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Has Ordered Contraceptive Medications")]
    public bool? Has_Ordered_Contraceptive_Medications(CqlContext context)
    {
        CqlValueSet szzzzzzzzzzv_ = this.Contraceptive_Medications(context);
        IEnumerable<MedicationRequest> szzzzzzzzzzw_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, szzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> szzzzzzzzzzy_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, szzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> szzzzzzzzzzz_ = context.Operators.Union<MedicationRequest>(szzzzzzzzzzw_, szzzzzzzzzzy_);
        IEnumerable<MedicationRequest> tzzzzzzzzzza_ = Status_1_8_000.Instance.isMedicationOrder(context, szzzzzzzzzzz_);
        bool? tzzzzzzzzzzb_(MedicationRequest OrderedContraceptives)
        {
            CqlInterval<CqlDateTime> tzzzzzzzzzze_ = this.Measurement_Period(context);
            FhirDateTime tzzzzzzzzzzf_ = OrderedContraceptives?.AuthoredOnElement;
            CqlDateTime tzzzzzzzzzzg_ = context.Operators.Convert<CqlDateTime>(tzzzzzzzzzzf_);
            CqlInterval<CqlDateTime> tzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.toInterval(context, tzzzzzzzzzzg_ as object);
            bool? tzzzzzzzzzzi_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(tzzzzzzzzzze_, tzzzzzzzzzzh_, "day");

            return tzzzzzzzzzzi_;
        };
        IEnumerable<MedicationRequest> tzzzzzzzzzzc_ = context.Operators.Where<MedicationRequest>(tzzzzzzzzzza_, tzzzzzzzzzzb_);
        bool? tzzzzzzzzzzd_ = context.Operators.Exists<MedicationRequest>(tzzzzzzzzzzc_);

        return tzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Has Laboratory Tests Identifying Sexual Activity But Not Pregnancy")]
    public bool? Has_Laboratory_Tests_Identifying_Sexual_Activity_But_Not_Pregnancy(CqlContext context)
    {
        CqlValueSet tzzzzzzzzzzj_ = this.Pap_Test(context);
        IEnumerable<ServiceRequest> tzzzzzzzzzzk_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, tzzzzzzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        CqlValueSet tzzzzzzzzzzl_ = this.Lab_Tests_During_Pregnancy(context);
        IEnumerable<ServiceRequest> tzzzzzzzzzzm_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, tzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> tzzzzzzzzzzn_ = context.Operators.Union<ServiceRequest>(tzzzzzzzzzzk_, tzzzzzzzzzzm_);
        CqlValueSet tzzzzzzzzzzo_ = this.Lab_Tests_for_Sexually_Transmitted_Infections(context);
        IEnumerable<ServiceRequest> tzzzzzzzzzzp_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, tzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> tzzzzzzzzzzq_ = context.Operators.Union<ServiceRequest>(tzzzzzzzzzzn_, tzzzzzzzzzzp_);
        IEnumerable<ServiceRequest> tzzzzzzzzzzr_ = Status_1_8_000.Instance.isLaboratoryTestOrder(context, tzzzzzzzzzzq_);
        bool? tzzzzzzzzzzs_(ServiceRequest LabOrders)
        {
            CqlInterval<CqlDateTime> tzzzzzzzzzzv_ = this.Measurement_Period(context);
            FhirDateTime tzzzzzzzzzzw_ = LabOrders?.AuthoredOnElement;
            CqlDateTime tzzzzzzzzzzx_ = context.Operators.Convert<CqlDateTime>(tzzzzzzzzzzw_);
            CqlInterval<CqlDateTime> tzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.toInterval(context, tzzzzzzzzzzx_ as object);
            bool? tzzzzzzzzzzz_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(tzzzzzzzzzzv_, tzzzzzzzzzzy_, "day");

            return tzzzzzzzzzzz_;
        };
        IEnumerable<ServiceRequest> tzzzzzzzzzzt_ = context.Operators.Where<ServiceRequest>(tzzzzzzzzzzr_, tzzzzzzzzzzs_);
        bool? tzzzzzzzzzzu_ = context.Operators.Exists<ServiceRequest>(tzzzzzzzzzzt_);

        return tzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Has Laboratory Tests Identifying Sexual Activity")]
    public bool? Has_Laboratory_Tests_Identifying_Sexual_Activity(CqlContext context)
    {
        CqlValueSet uzzzzzzzzzza_ = this.Pregnancy_Test(context);
        IEnumerable<ServiceRequest> uzzzzzzzzzzb_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, uzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> uzzzzzzzzzzc_ = Status_1_8_000.Instance.isLaboratoryTestOrder(context, uzzzzzzzzzzb_);
        bool? uzzzzzzzzzzd_(ServiceRequest PregnancyTest)
        {
            CqlInterval<CqlDateTime> uzzzzzzzzzzi_ = this.Measurement_Period(context);
            FhirDateTime uzzzzzzzzzzj_ = PregnancyTest?.AuthoredOnElement;
            CqlDateTime uzzzzzzzzzzk_ = context.Operators.Convert<CqlDateTime>(uzzzzzzzzzzj_);
            CqlInterval<CqlDateTime> uzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.toInterval(context, uzzzzzzzzzzk_ as object);
            bool? uzzzzzzzzzzm_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(uzzzzzzzzzzi_, uzzzzzzzzzzl_, "day");

            return uzzzzzzzzzzm_;
        };
        IEnumerable<ServiceRequest> uzzzzzzzzzze_ = context.Operators.Where<ServiceRequest>(uzzzzzzzzzzc_, uzzzzzzzzzzd_);
        bool? uzzzzzzzzzzf_ = context.Operators.Exists<ServiceRequest>(uzzzzzzzzzze_);
        bool? uzzzzzzzzzzg_ = this.Has_Laboratory_Tests_Identifying_Sexual_Activity_But_Not_Pregnancy(context);
        bool? uzzzzzzzzzzh_ = context.Operators.Or(uzzzzzzzzzzf_, uzzzzzzzzzzg_);

        return uzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Has Diagnostic Studies Identifying Sexual Activity")]
    public bool? Has_Diagnostic_Studies_Identifying_Sexual_Activity(CqlContext context)
    {
        CqlValueSet uzzzzzzzzzzn_ = this.Diagnostic_Studies_During_Pregnancy(context);
        IEnumerable<ServiceRequest> uzzzzzzzzzzo_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, uzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> uzzzzzzzzzzp_ = Status_1_8_000.Instance.isDiagnosticStudyOrder(context, uzzzzzzzzzzo_);
        bool? uzzzzzzzzzzq_(ServiceRequest SexualActivityDiagnostics)
        {
            CqlInterval<CqlDateTime> uzzzzzzzzzzt_ = this.Measurement_Period(context);
            FhirDateTime uzzzzzzzzzzu_ = SexualActivityDiagnostics?.AuthoredOnElement;
            CqlDateTime uzzzzzzzzzzv_ = context.Operators.Convert<CqlDateTime>(uzzzzzzzzzzu_);
            CqlInterval<CqlDateTime> uzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.toInterval(context, uzzzzzzzzzzv_ as object);
            bool? uzzzzzzzzzzx_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(uzzzzzzzzzzt_, uzzzzzzzzzzw_, "day");

            return uzzzzzzzzzzx_;
        };
        IEnumerable<ServiceRequest> uzzzzzzzzzzr_ = context.Operators.Where<ServiceRequest>(uzzzzzzzzzzp_, uzzzzzzzzzzq_);
        bool? uzzzzzzzzzzs_ = context.Operators.Exists<ServiceRequest>(uzzzzzzzzzzr_);

        return uzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Has Procedures Identifying Sexual Activity")]
    public bool? Has_Procedures_Identifying_Sexual_Activity(CqlContext context)
    {
        CqlValueSet uzzzzzzzzzzy_ = this.Procedures_Used_to_Indicate_Sexual_Activity(context);
        IEnumerable<Procedure> uzzzzzzzzzzz_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, uzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> vzzzzzzzzzza_ = Status_1_8_000.Instance.isProcedurePerformed(context, uzzzzzzzzzzz_);
        bool? vzzzzzzzzzzb_(Procedure ProceduresForSexualActivity)
        {
            CqlInterval<CqlDateTime> vzzzzzzzzzze_ = this.Measurement_Period(context);
            DataType vzzzzzzzzzzf_ = ProceduresForSexualActivity?.Performed;
            object vzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzf_);
            CqlInterval<CqlDateTime> vzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.toInterval(context, vzzzzzzzzzzg_);
            bool? vzzzzzzzzzzi_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(vzzzzzzzzzze_, vzzzzzzzzzzh_, "day");

            return vzzzzzzzzzzi_;
        };
        IEnumerable<Procedure> vzzzzzzzzzzc_ = context.Operators.Where<Procedure>(vzzzzzzzzzza_, vzzzzzzzzzzb_);
        bool? vzzzzzzzzzzd_ = context.Operators.Exists<Procedure>(vzzzzzzzzzzc_);

        return vzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient vzzzzzzzzzzj_ = this.Patient(context);
        Date vzzzzzzzzzzk_ = vzzzzzzzzzzj_?.BirthDateElement;
        string vzzzzzzzzzzl_ = vzzzzzzzzzzk_?.Value;
        CqlDate vzzzzzzzzzzm_ = context.Operators.ConvertStringToDate(vzzzzzzzzzzl_);
        CqlInterval<CqlDateTime> vzzzzzzzzzzn_ = this.Measurement_Period(context);
        CqlDateTime vzzzzzzzzzzo_ = context.Operators.End(vzzzzzzzzzzn_);
        CqlDate vzzzzzzzzzzp_ = context.Operators.DateFrom(vzzzzzzzzzzo_);
        int? vzzzzzzzzzzq_ = context.Operators.CalculateAgeAt(vzzzzzzzzzzm_, vzzzzzzzzzzp_, "year");
        CqlInterval<int?> vzzzzzzzzzzr_ = context.Operators.Interval(16, 24, true, true);
        bool? vzzzzzzzzzzs_ = context.Operators.In<int?>(vzzzzzzzzzzq_, vzzzzzzzzzzr_, default);
        Code<AdministrativeGender> vzzzzzzzzzzu_ = vzzzzzzzzzzj_?.GenderElement;
        AdministrativeGender? vzzzzzzzzzzv_ = vzzzzzzzzzzu_?.Value;
        string vzzzzzzzzzzw_ = context.Operators.Convert<string>(vzzzzzzzzzzv_);
        bool? vzzzzzzzzzzx_ = context.Operators.Equal(vzzzzzzzzzzw_, "female");
        bool? vzzzzzzzzzzy_ = context.Operators.And(vzzzzzzzzzzs_, vzzzzzzzzzzx_);
        IEnumerable<Encounter> vzzzzzzzzzzz_ = this.Qualifying_Encounters(context);
        bool? wzzzzzzzzzza_ = context.Operators.Exists<Encounter>(vzzzzzzzzzzz_);
        bool? wzzzzzzzzzzb_ = context.Operators.And(vzzzzzzzzzzy_, wzzzzzzzzzza_);
        bool? wzzzzzzzzzzc_ = this.Has_Assessments_Identifying_Sexual_Activity(context);
        bool? wzzzzzzzzzzd_ = this.Has_Diagnoses_Identifying_Sexual_Activity(context);
        bool? wzzzzzzzzzze_ = context.Operators.Or(wzzzzzzzzzzc_, wzzzzzzzzzzd_);
        bool? wzzzzzzzzzzf_ = this.Has_Active_Contraceptive_Medications(context);
        bool? wzzzzzzzzzzg_ = context.Operators.Or(wzzzzzzzzzze_, wzzzzzzzzzzf_);
        bool? wzzzzzzzzzzh_ = this.Has_Ordered_Contraceptive_Medications(context);
        bool? wzzzzzzzzzzi_ = context.Operators.Or(wzzzzzzzzzzg_, wzzzzzzzzzzh_);
        bool? wzzzzzzzzzzj_ = this.Has_Laboratory_Tests_Identifying_Sexual_Activity(context);
        bool? wzzzzzzzzzzk_ = context.Operators.Or(wzzzzzzzzzzi_, wzzzzzzzzzzj_);
        bool? wzzzzzzzzzzl_ = this.Has_Diagnostic_Studies_Identifying_Sexual_Activity(context);
        bool? wzzzzzzzzzzm_ = context.Operators.Or(wzzzzzzzzzzk_, wzzzzzzzzzzl_);
        bool? wzzzzzzzzzzn_ = this.Has_Procedures_Identifying_Sexual_Activity(context);
        bool? wzzzzzzzzzzo_ = context.Operators.Or(wzzzzzzzzzzm_, wzzzzzzzzzzn_);
        bool? wzzzzzzzzzzp_ = context.Operators.And(wzzzzzzzzzzb_, wzzzzzzzzzzo_);

        return wzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? wzzzzzzzzzzq_ = this.Initial_Population(context);

        return wzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Has Pregnancy Test Exclusion")]
    public bool? Has_Pregnancy_Test_Exclusion(CqlContext context)
    {
        CqlValueSet wzzzzzzzzzzr_ = this.Pregnancy_Test(context);
        IEnumerable<ServiceRequest> wzzzzzzzzzzs_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, wzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> wzzzzzzzzzzt_ = Status_1_8_000.Instance.isLaboratoryTestOrder(context, wzzzzzzzzzzs_);
        IEnumerable<ServiceRequest> wzzzzzzzzzzu_(ServiceRequest PregnancyTest)
        {
            CqlValueSet xzzzzzzzzzzh_ = this.XRay_Study(context);
            IEnumerable<ServiceRequest> xzzzzzzzzzzi_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, xzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
            IEnumerable<ServiceRequest> xzzzzzzzzzzj_ = Status_1_8_000.Instance.isDiagnosticStudyOrder(context, xzzzzzzzzzzi_);
            bool? xzzzzzzzzzzk_(ServiceRequest XrayOrder)
            {
                FhirDateTime xzzzzzzzzzzo_ = XrayOrder?.AuthoredOnElement;
                CqlDateTime xzzzzzzzzzzp_ = context.Operators.Convert<CqlDateTime>(xzzzzzzzzzzo_);
                CqlInterval<CqlDateTime> xzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.toInterval(context, xzzzzzzzzzzp_ as object);
                CqlDateTime xzzzzzzzzzzr_ = context.Operators.Start(xzzzzzzzzzzq_);
                FhirDateTime xzzzzzzzzzzs_ = PregnancyTest?.AuthoredOnElement;
                CqlDateTime xzzzzzzzzzzt_ = context.Operators.Convert<CqlDateTime>(xzzzzzzzzzzs_);
                CqlInterval<CqlDateTime> xzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.toInterval(context, xzzzzzzzzzzt_ as object);
                CqlDateTime xzzzzzzzzzzv_ = context.Operators.End(xzzzzzzzzzzu_);
                CqlDateTime xzzzzzzzzzzx_ = context.Operators.Convert<CqlDateTime>(xzzzzzzzzzzs_);
                CqlInterval<CqlDateTime> xzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.toInterval(context, xzzzzzzzzzzx_ as object);
                CqlDateTime xzzzzzzzzzzz_ = context.Operators.End(xzzzzzzzzzzy_);
                CqlQuantity yzzzzzzzzzza_ = context.Operators.Quantity(6m, "days");
                CqlDateTime yzzzzzzzzzzb_ = context.Operators.Add(xzzzzzzzzzzz_, yzzzzzzzzzza_);
                CqlInterval<CqlDateTime> yzzzzzzzzzzc_ = context.Operators.Interval(xzzzzzzzzzzv_, yzzzzzzzzzzb_, true, true);
                bool? yzzzzzzzzzzd_ = context.Operators.In<CqlDateTime>(xzzzzzzzzzzr_, yzzzzzzzzzzc_, "day");
                CqlDateTime yzzzzzzzzzzf_ = context.Operators.Convert<CqlDateTime>(xzzzzzzzzzzs_);
                CqlInterval<CqlDateTime> yzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.toInterval(context, yzzzzzzzzzzf_ as object);
                CqlDateTime yzzzzzzzzzzh_ = context.Operators.End(yzzzzzzzzzzg_);
                bool? yzzzzzzzzzzi_ = context.Operators.Not((bool?)(yzzzzzzzzzzh_ is null));
                bool? yzzzzzzzzzzj_ = context.Operators.And(yzzzzzzzzzzd_, yzzzzzzzzzzi_);

                return yzzzzzzzzzzj_;
            };
            IEnumerable<ServiceRequest> xzzzzzzzzzzl_ = context.Operators.Where<ServiceRequest>(xzzzzzzzzzzj_, xzzzzzzzzzzk_);
            ServiceRequest xzzzzzzzzzzm_(ServiceRequest XrayOrder) =>
                PregnancyTest;
            IEnumerable<ServiceRequest> xzzzzzzzzzzn_ = context.Operators.Select<ServiceRequest, ServiceRequest>(xzzzzzzzzzzl_, xzzzzzzzzzzm_);

            return xzzzzzzzzzzn_;
        };
        IEnumerable<ServiceRequest> wzzzzzzzzzzv_ = context.Operators.SelectMany<ServiceRequest, ServiceRequest>(wzzzzzzzzzzt_, wzzzzzzzzzzu_);
        bool? wzzzzzzzzzzw_(ServiceRequest PregnancyTest)
        {
            CqlInterval<CqlDateTime> yzzzzzzzzzzk_ = this.Measurement_Period(context);
            FhirDateTime yzzzzzzzzzzl_ = PregnancyTest?.AuthoredOnElement;
            CqlDateTime yzzzzzzzzzzm_ = context.Operators.Convert<CqlDateTime>(yzzzzzzzzzzl_);
            CqlInterval<CqlDateTime> yzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.toInterval(context, yzzzzzzzzzzm_ as object);
            bool? yzzzzzzzzzzo_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(yzzzzzzzzzzk_, yzzzzzzzzzzn_, default);

            return yzzzzzzzzzzo_;
        };
        IEnumerable<ServiceRequest> wzzzzzzzzzzx_ = context.Operators.Where<ServiceRequest>(wzzzzzzzzzzv_, wzzzzzzzzzzw_);
        IEnumerable<ServiceRequest> wzzzzzzzzzzz_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, wzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> xzzzzzzzzzza_ = Status_1_8_000.Instance.isLaboratoryTestOrder(context, wzzzzzzzzzzz_);
        IEnumerable<ServiceRequest> xzzzzzzzzzzb_(ServiceRequest PregnancyTestOrder)
        {
            CqlValueSet yzzzzzzzzzzp_ = this.Isotretinoin(context);
            IEnumerable<MedicationRequest> yzzzzzzzzzzq_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, yzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> yzzzzzzzzzzs_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, yzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> yzzzzzzzzzzt_ = context.Operators.Union<MedicationRequest>(yzzzzzzzzzzq_, yzzzzzzzzzzs_);
            IEnumerable<MedicationRequest> yzzzzzzzzzzu_ = Status_1_8_000.Instance.isMedicationOrder(context, yzzzzzzzzzzt_);
            bool? yzzzzzzzzzzv_(MedicationRequest AccutaneOrder)
            {
                FhirDateTime yzzzzzzzzzzz_ = AccutaneOrder?.AuthoredOnElement;
                CqlDateTime zzzzzzzzzzza_ = context.Operators.Convert<CqlDateTime>(yzzzzzzzzzzz_);
                CqlInterval<CqlDateTime> zzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.toInterval(context, zzzzzzzzzzza_ as object);
                CqlDateTime zzzzzzzzzzzc_ = context.Operators.Start(zzzzzzzzzzzb_);
                FhirDateTime zzzzzzzzzzzd_ = PregnancyTestOrder?.AuthoredOnElement;
                CqlDateTime zzzzzzzzzzze_ = context.Operators.Convert<CqlDateTime>(zzzzzzzzzzzd_);
                CqlInterval<CqlDateTime> zzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.toInterval(context, zzzzzzzzzzze_ as object);
                CqlDateTime zzzzzzzzzzzg_ = context.Operators.End(zzzzzzzzzzzf_);
                CqlDateTime zzzzzzzzzzzi_ = context.Operators.Convert<CqlDateTime>(zzzzzzzzzzzd_);
                CqlInterval<CqlDateTime> zzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.toInterval(context, zzzzzzzzzzzi_ as object);
                CqlDateTime zzzzzzzzzzzk_ = context.Operators.End(zzzzzzzzzzzj_);
                CqlQuantity zzzzzzzzzzzl_ = context.Operators.Quantity(6m, "days");
                CqlDateTime zzzzzzzzzzzm_ = context.Operators.Add(zzzzzzzzzzzk_, zzzzzzzzzzzl_);
                CqlInterval<CqlDateTime> zzzzzzzzzzzn_ = context.Operators.Interval(zzzzzzzzzzzg_, zzzzzzzzzzzm_, true, true);
                bool? zzzzzzzzzzzo_ = context.Operators.In<CqlDateTime>(zzzzzzzzzzzc_, zzzzzzzzzzzn_, "day");
                CqlDateTime zzzzzzzzzzzq_ = context.Operators.Convert<CqlDateTime>(zzzzzzzzzzzd_);
                CqlInterval<CqlDateTime> zzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.toInterval(context, zzzzzzzzzzzq_ as object);
                CqlDateTime zzzzzzzzzzzs_ = context.Operators.End(zzzzzzzzzzzr_);
                bool? zzzzzzzzzzzt_ = context.Operators.Not((bool?)(zzzzzzzzzzzs_ is null));
                bool? zzzzzzzzzzzu_ = context.Operators.And(zzzzzzzzzzzo_, zzzzzzzzzzzt_);

                return zzzzzzzzzzzu_;
            };
            IEnumerable<MedicationRequest> yzzzzzzzzzzw_ = context.Operators.Where<MedicationRequest>(yzzzzzzzzzzu_, yzzzzzzzzzzv_);
            ServiceRequest yzzzzzzzzzzx_(MedicationRequest AccutaneOrder) =>
                PregnancyTestOrder;
            IEnumerable<ServiceRequest> yzzzzzzzzzzy_ = context.Operators.Select<MedicationRequest, ServiceRequest>(yzzzzzzzzzzw_, yzzzzzzzzzzx_);

            return yzzzzzzzzzzy_;
        };
        IEnumerable<ServiceRequest> xzzzzzzzzzzc_ = context.Operators.SelectMany<ServiceRequest, ServiceRequest>(xzzzzzzzzzza_, xzzzzzzzzzzb_);
        bool? xzzzzzzzzzzd_(ServiceRequest PregnancyTestOrder)
        {
            CqlInterval<CqlDateTime> zzzzzzzzzzzv_ = this.Measurement_Period(context);
            FhirDateTime zzzzzzzzzzzw_ = PregnancyTestOrder?.AuthoredOnElement;
            CqlDateTime zzzzzzzzzzzx_ = context.Operators.Convert<CqlDateTime>(zzzzzzzzzzzw_);
            CqlInterval<CqlDateTime> zzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.toInterval(context, zzzzzzzzzzzx_ as object);
            bool? zzzzzzzzzzzz_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(zzzzzzzzzzzv_, zzzzzzzzzzzy_, default);

            return zzzzzzzzzzzz_;
        };
        IEnumerable<ServiceRequest> xzzzzzzzzzze_ = context.Operators.Where<ServiceRequest>(xzzzzzzzzzzc_, xzzzzzzzzzzd_);
        IEnumerable<ServiceRequest> xzzzzzzzzzzf_ = context.Operators.Union<ServiceRequest>(wzzzzzzzzzzx_, xzzzzzzzzzze_);
        bool? xzzzzzzzzzzg_ = context.Operators.Exists<ServiceRequest>(xzzzzzzzzzzf_);

        return xzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? azzzzzzzzzzza_ = Hospice_6_12_000.Instance.Has_Hospice_Services(context);
        bool? azzzzzzzzzzzb_ = this.Has_Pregnancy_Test_Exclusion(context);
        bool? azzzzzzzzzzzc_ = this.Has_Assessments_Identifying_Sexual_Activity(context);
        bool? azzzzzzzzzzzd_ = context.Operators.Not(azzzzzzzzzzzc_);
        bool? azzzzzzzzzzze_ = context.Operators.And(azzzzzzzzzzzb_, azzzzzzzzzzzd_);
        bool? azzzzzzzzzzzf_ = this.Has_Diagnoses_Identifying_Sexual_Activity(context);
        bool? azzzzzzzzzzzg_ = context.Operators.Not(azzzzzzzzzzzf_);
        bool? azzzzzzzzzzzh_ = context.Operators.And(azzzzzzzzzzze_, azzzzzzzzzzzg_);
        bool? azzzzzzzzzzzi_ = this.Has_Active_Contraceptive_Medications(context);
        bool? azzzzzzzzzzzj_ = context.Operators.Not(azzzzzzzzzzzi_);
        bool? azzzzzzzzzzzk_ = context.Operators.And(azzzzzzzzzzzh_, azzzzzzzzzzzj_);
        bool? azzzzzzzzzzzl_ = this.Has_Ordered_Contraceptive_Medications(context);
        bool? azzzzzzzzzzzm_ = context.Operators.Not(azzzzzzzzzzzl_);
        bool? azzzzzzzzzzzn_ = context.Operators.And(azzzzzzzzzzzk_, azzzzzzzzzzzm_);
        bool? azzzzzzzzzzzo_ = this.Has_Laboratory_Tests_Identifying_Sexual_Activity_But_Not_Pregnancy(context);
        bool? azzzzzzzzzzzp_ = context.Operators.Not(azzzzzzzzzzzo_);
        bool? azzzzzzzzzzzq_ = context.Operators.And(azzzzzzzzzzzn_, azzzzzzzzzzzp_);
        bool? azzzzzzzzzzzr_ = this.Has_Diagnostic_Studies_Identifying_Sexual_Activity(context);
        bool? azzzzzzzzzzzs_ = context.Operators.Not(azzzzzzzzzzzr_);
        bool? azzzzzzzzzzzt_ = context.Operators.And(azzzzzzzzzzzq_, azzzzzzzzzzzs_);
        bool? azzzzzzzzzzzu_ = this.Has_Procedures_Identifying_Sexual_Activity(context);
        bool? azzzzzzzzzzzv_ = context.Operators.Not(azzzzzzzzzzzu_);
        bool? azzzzzzzzzzzw_ = context.Operators.And(azzzzzzzzzzzt_, azzzzzzzzzzzv_);
        bool? azzzzzzzzzzzx_ = context.Operators.Or(azzzzzzzzzzza_, azzzzzzzzzzzw_);

        return azzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        CqlValueSet azzzzzzzzzzzy_ = this.Chlamydia_Screening(context);
        IEnumerable<Observation> azzzzzzzzzzzz_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, azzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> bzzzzzzzzzzza_ = Status_1_8_000.Instance.isLaboratoryTestPerformed(context, azzzzzzzzzzzz_);
        bool? bzzzzzzzzzzzb_(Observation ChlamydiaTest)
        {
            object bzzzzzzzzzzze_()
            {
                bool bzzzzzzzzzzzm_()
                {
                    DataType bzzzzzzzzzzzp_ = ChlamydiaTest?.Effective;
                    object bzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzp_);
                    bool bzzzzzzzzzzzr_ = bzzzzzzzzzzzq_ is CqlDateTime;

                    return bzzzzzzzzzzzr_;
                };
                bool bzzzzzzzzzzzn_()
                {
                    DataType bzzzzzzzzzzzs_ = ChlamydiaTest?.Effective;
                    object bzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzs_);
                    bool bzzzzzzzzzzzu_ = bzzzzzzzzzzzt_ is CqlInterval<CqlDateTime>;

                    return bzzzzzzzzzzzu_;
                };
                bool bzzzzzzzzzzzo_()
                {
                    DataType bzzzzzzzzzzzv_ = ChlamydiaTest?.Effective;
                    object bzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzv_);
                    bool bzzzzzzzzzzzx_ = bzzzzzzzzzzzw_ is CqlDateTime;

                    return bzzzzzzzzzzzx_;
                };
                if (bzzzzzzzzzzzm_())
                {
                    DataType bzzzzzzzzzzzy_ = ChlamydiaTest?.Effective;
                    object bzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzy_);

                    return (bzzzzzzzzzzzz_ as CqlDateTime) as object;
                }
                else if (bzzzzzzzzzzzn_())
                {
                    DataType czzzzzzzzzzza_ = ChlamydiaTest?.Effective;
                    object czzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzza_);

                    return (czzzzzzzzzzzb_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (bzzzzzzzzzzzo_())
                {
                    DataType czzzzzzzzzzzc_ = ChlamydiaTest?.Effective;
                    object czzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzc_);

                    return (czzzzzzzzzzzd_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime bzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.latest(context, bzzzzzzzzzzze_());
            CqlInterval<CqlDateTime> bzzzzzzzzzzzg_ = this.Measurement_Period(context);
            bool? bzzzzzzzzzzzh_ = context.Operators.In<CqlDateTime>(bzzzzzzzzzzzf_, bzzzzzzzzzzzg_, "day");
            DataType bzzzzzzzzzzzi_ = ChlamydiaTest?.Value;
            object bzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzi_);
            bool? bzzzzzzzzzzzk_ = context.Operators.Not((bool?)(bzzzzzzzzzzzj_ is null));
            bool? bzzzzzzzzzzzl_ = context.Operators.And(bzzzzzzzzzzzh_, bzzzzzzzzzzzk_);

            return bzzzzzzzzzzzl_;
        };
        IEnumerable<Observation> bzzzzzzzzzzzc_ = context.Operators.Where<Observation>(bzzzzzzzzzzza_, bzzzzzzzzzzzb_);
        bool? bzzzzzzzzzzzd_ = context.Operators.Exists<Observation>(bzzzzzzzzzzzc_);

        return bzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Stratification 1")]
    public bool? Stratification_1(CqlContext context)
    {
        Patient czzzzzzzzzzze_ = this.Patient(context);
        Date czzzzzzzzzzzf_ = czzzzzzzzzzze_?.BirthDateElement;
        string czzzzzzzzzzzg_ = czzzzzzzzzzzf_?.Value;
        CqlDate czzzzzzzzzzzh_ = context.Operators.ConvertStringToDate(czzzzzzzzzzzg_);
        CqlInterval<CqlDateTime> czzzzzzzzzzzi_ = this.Measurement_Period(context);
        CqlDateTime czzzzzzzzzzzj_ = context.Operators.End(czzzzzzzzzzzi_);
        CqlDate czzzzzzzzzzzk_ = context.Operators.DateFrom(czzzzzzzzzzzj_);
        int? czzzzzzzzzzzl_ = context.Operators.CalculateAgeAt(czzzzzzzzzzzh_, czzzzzzzzzzzk_, "year");
        CqlInterval<int?> czzzzzzzzzzzm_ = context.Operators.Interval(16, 20, true, true);
        bool? czzzzzzzzzzzn_ = context.Operators.In<int?>(czzzzzzzzzzzl_, czzzzzzzzzzzm_, default);

        return czzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Stratification 2")]
    public bool? Stratification_2(CqlContext context)
    {
        Patient czzzzzzzzzzzo_ = this.Patient(context);
        Date czzzzzzzzzzzp_ = czzzzzzzzzzzo_?.BirthDateElement;
        string czzzzzzzzzzzq_ = czzzzzzzzzzzp_?.Value;
        CqlDate czzzzzzzzzzzr_ = context.Operators.ConvertStringToDate(czzzzzzzzzzzq_);
        CqlInterval<CqlDateTime> czzzzzzzzzzzs_ = this.Measurement_Period(context);
        CqlDateTime czzzzzzzzzzzt_ = context.Operators.End(czzzzzzzzzzzs_);
        CqlDate czzzzzzzzzzzu_ = context.Operators.DateFrom(czzzzzzzzzzzt_);
        int? czzzzzzzzzzzv_ = context.Operators.CalculateAgeAt(czzzzzzzzzzzr_, czzzzzzzzzzzu_, "year");
        CqlInterval<int?> czzzzzzzzzzzw_ = context.Operators.Interval(21, 24, true, true);
        bool? czzzzzzzzzzzx_ = context.Operators.In<int?>(czzzzzzzzzzzv_, czzzzzzzzzzzw_, default);

        return czzzzzzzzzzzx_;
    }


    #endregion Expressions

}
