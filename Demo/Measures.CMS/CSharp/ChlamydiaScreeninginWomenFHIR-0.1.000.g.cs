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
        CqlDateTime ezzzzzzzzzzzzzzzzzzzzv_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime ezzzzzzzzzzzzzzzzzzzzw_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Interval(ezzzzzzzzzzzzzzzzzzzzv_, ezzzzzzzzzzzzzzzzzzzzw_, true, true);
        object ezzzzzzzzzzzzzzzzzzzzy_ = context.ResolveParameter("ChlamydiaScreeninginWomenFHIR-0.1.000", "Measurement Period", ezzzzzzzzzzzzzzzzzzzzx_);

        return (CqlInterval<CqlDateTime>)ezzzzzzzzzzzzzzzzzzzzy_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> ezzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient fzzzzzzzzzzzzzzzzzzzza_ = context.Operators.SingletonFrom<Patient>(ezzzzzzzzzzzzzzzzzzzzz_);

        return fzzzzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? fzzzzzzzzzzzzzzzzzzzzb_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return fzzzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> fzzzzzzzzzzzzzzzzzzzzc_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return fzzzzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? fzzzzzzzzzzzzzzzzzzzzd_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return fzzzzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode fzzzzzzzzzzzzzzzzzzzze_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return fzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Qualifying Encounters")]
    public IEnumerable<Encounter> Qualifying_Encounters(CqlContext context)
    {
        CqlValueSet fzzzzzzzzzzzzzzzzzzzzf_ = this.Office_Visit(context);
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet fzzzzzzzzzzzzzzzzzzzzh_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Union<Encounter>(fzzzzzzzzzzzzzzzzzzzzg_, fzzzzzzzzzzzzzzzzzzzzi_);
        CqlValueSet fzzzzzzzzzzzzzzzzzzzzk_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet fzzzzzzzzzzzzzzzzzzzzm_ = this.Preventive_Care_Services__Initial_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Union<Encounter>(fzzzzzzzzzzzzzzzzzzzzl_, fzzzzzzzzzzzzzzzzzzzzn_);
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Union<Encounter>(fzzzzzzzzzzzzzzzzzzzzj_, fzzzzzzzzzzzzzzzzzzzzo_);
        CqlValueSet fzzzzzzzzzzzzzzzzzzzzq_ = this.Preventive_Care__Established_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet fzzzzzzzzzzzzzzzzzzzzs_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Union<Encounter>(fzzzzzzzzzzzzzzzzzzzzr_, fzzzzzzzzzzzzzzzzzzzzt_);
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Union<Encounter>(fzzzzzzzzzzzzzzzzzzzzp_, fzzzzzzzzzzzzzzzzzzzzu_);
        CqlValueSet fzzzzzzzzzzzzzzzzzzzzw_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet fzzzzzzzzzzzzzzzzzzzzy_ = this.Virtual_Encounter(context);
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Union<Encounter>(fzzzzzzzzzzzzzzzzzzzzx_, fzzzzzzzzzzzzzzzzzzzzz_);
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Union<Encounter>(fzzzzzzzzzzzzzzzzzzzzv_, gzzzzzzzzzzzzzzzzzzzza_);
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzzzzc_ = Status_1_8_000.Instance.isEncounterPerformed(context, gzzzzzzzzzzzzzzzzzzzzb_);
        bool? gzzzzzzzzzzzzzzzzzzzzd_(Encounter ValidEncounters)
        {
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzf_ = this.Measurement_Period(context);
            Period gzzzzzzzzzzzzzzzzzzzzg_ = ValidEncounters?.Period;
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzzzzzzzzzzzzzzzg_);
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.toInterval(context, gzzzzzzzzzzzzzzzzzzzzh_ as object);
            bool? gzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(gzzzzzzzzzzzzzzzzzzzzf_, gzzzzzzzzzzzzzzzzzzzzi_, "day");

            return gzzzzzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Where<Encounter>(gzzzzzzzzzzzzzzzzzzzzc_, gzzzzzzzzzzzzzzzzzzzzd_);

        return gzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Has Assessments Identifying Sexual Activity")]
    public bool? Has_Assessments_Identifying_Sexual_Activity(CqlContext context)
    {
        CqlCode gzzzzzzzzzzzzzzzzzzzzk_ = this.Have_you_ever_had_vaginal_intercourse__PhenX_(context);
        IEnumerable<CqlCode> gzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.ToList<CqlCode>(gzzzzzzzzzzzzzzzzzzzzk_);
        IEnumerable<Observation> gzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, gzzzzzzzzzzzzzzzzzzzzl_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> gzzzzzzzzzzzzzzzzzzzzn_ = Status_1_8_000.Instance.isAssessmentPerformed(context, gzzzzzzzzzzzzzzzzzzzzm_);
        bool? gzzzzzzzzzzzzzzzzzzzzo_(Observation SexualActivityAssessment)
        {
            DataType gzzzzzzzzzzzzzzzzzzzzr_ = SexualActivityAssessment?.Value;
            object gzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzr_);
            CqlCode gzzzzzzzzzzzzzzzzzzzzt_ = this.Yes__qualifier_value_(context);
            CqlConcept gzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.ConvertCodeToConcept(gzzzzzzzzzzzzzzzzzzzzt_);
            bool? gzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Equivalent(gzzzzzzzzzzzzzzzzzzzzs_ as CqlConcept, gzzzzzzzzzzzzzzzzzzzzu_);
            DataType gzzzzzzzzzzzzzzzzzzzzw_ = SexualActivityAssessment?.Effective;
            object gzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzw_);
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.toInterval(context, gzzzzzzzzzzzzzzzzzzzzx_);
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzz_()
            {
                bool hzzzzzzzzzzzzzzzzzzzzc_()
                {
                    CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzd_ = this.Measurement_Period(context);
                    CqlDateTime hzzzzzzzzzzzzzzzzzzzze_ = context.Operators.End(hzzzzzzzzzzzzzzzzzzzzd_);

                    return hzzzzzzzzzzzzzzzzzzzze_ is null;
                };
                if (hzzzzzzzzzzzzzzzzzzzzc_())
                {
                    return default;
                }
                else
                {
                    CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzf_ = this.Measurement_Period(context);
                    CqlDateTime hzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.End(hzzzzzzzzzzzzzzzzzzzzf_);
                    CqlDateTime hzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.End(hzzzzzzzzzzzzzzzzzzzzf_);
                    CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Interval(hzzzzzzzzzzzzzzzzzzzzg_, hzzzzzzzzzzzzzzzzzzzzi_, true, true);

                    return hzzzzzzzzzzzzzzzzzzzzj_;
                }
            };
            bool? hzzzzzzzzzzzzzzzzzzzza_ = context.Operators.SameOrBefore(gzzzzzzzzzzzzzzzzzzzzy_, gzzzzzzzzzzzzzzzzzzzzz_(), default);
            bool? hzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.And(gzzzzzzzzzzzzzzzzzzzzv_, hzzzzzzzzzzzzzzzzzzzza_);

            return hzzzzzzzzzzzzzzzzzzzzb_;
        };
        IEnumerable<Observation> gzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Observation>(gzzzzzzzzzzzzzzzzzzzzn_, gzzzzzzzzzzzzzzzzzzzzo_);
        bool? gzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Exists<Observation>(gzzzzzzzzzzzzzzzzzzzzp_);

        return gzzzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Has Diagnoses Identifying Sexual Activity")]
    public bool? Has_Diagnoses_Identifying_Sexual_Activity(CqlContext context)
    {
        CqlValueSet hzzzzzzzzzzzzzzzzzzzzk_ = this.Diagnoses_Used_to_Indicate_Sexual_Activity(context);
        IEnumerable<Condition> hzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet hzzzzzzzzzzzzzzzzzzzzm_ = this.HIV(context);
        IEnumerable<Condition> hzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> hzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Union<Condition>(hzzzzzzzzzzzzzzzzzzzzl_, hzzzzzzzzzzzzzzzzzzzzn_);
        CqlValueSet hzzzzzzzzzzzzzzzzzzzzp_ = this.Complications_of_Pregnancy__Childbirth_and_the_Puerperium(context);
        IEnumerable<Condition> hzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> hzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Union<Condition>(hzzzzzzzzzzzzzzzzzzzzo_, hzzzzzzzzzzzzzzzzzzzzq_);
        bool? hzzzzzzzzzzzzzzzzzzzzs_(Condition SexualActivityDiagnosis)
        {
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, SexualActivityDiagnosis);
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzw_ = this.Measurement_Period(context);
            bool? hzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Overlaps(hzzzzzzzzzzzzzzzzzzzzv_, hzzzzzzzzzzzzzzzzzzzzw_, default);

            return hzzzzzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<Condition> hzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Where<Condition>(hzzzzzzzzzzzzzzzzzzzzr_, hzzzzzzzzzzzzzzzzzzzzs_);
        bool? hzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Exists<Condition>(hzzzzzzzzzzzzzzzzzzzzt_);

        return hzzzzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Has Active Contraceptive Medications")]
    public bool? Has_Active_Contraceptive_Medications(CqlContext context)
    {
        CqlValueSet hzzzzzzzzzzzzzzzzzzzzy_ = this.Contraceptive_Medications(context);
        IEnumerable<MedicationRequest> hzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> izzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> izzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Union<MedicationRequest>(hzzzzzzzzzzzzzzzzzzzzz_, izzzzzzzzzzzzzzzzzzzzb_);
        IEnumerable<MedicationRequest> izzzzzzzzzzzzzzzzzzzzd_ = Status_1_8_000.Instance.isMedicationActive(context, izzzzzzzzzzzzzzzzzzzzc_);
        bool? izzzzzzzzzzzzzzzzzzzze_(MedicationRequest ActiveContraceptives)
        {
            CqlInterval<CqlDate> izzzzzzzzzzzzzzzzzzzzh_ = CumulativeMedicationDuration_4_1_000.Instance.medicationRequestPeriod(context, ActiveContraceptives);
            CqlDate izzzzzzzzzzzzzzzzzzzzi_ = izzzzzzzzzzzzzzzzzzzzh_?.low;
            CqlDateTime izzzzzzzzzzzzzzzzzzzzj_ = context.Operators.ConvertDateToDateTime(izzzzzzzzzzzzzzzzzzzzi_);
            CqlDate izzzzzzzzzzzzzzzzzzzzl_ = izzzzzzzzzzzzzzzzzzzzh_?.high;
            CqlDateTime izzzzzzzzzzzzzzzzzzzzm_ = context.Operators.ConvertDateToDateTime(izzzzzzzzzzzzzzzzzzzzl_);
            bool? izzzzzzzzzzzzzzzzzzzzo_ = izzzzzzzzzzzzzzzzzzzzh_?.lowClosed;
            bool? izzzzzzzzzzzzzzzzzzzzq_ = izzzzzzzzzzzzzzzzzzzzh_?.highClosed;
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Interval(izzzzzzzzzzzzzzzzzzzzj_, izzzzzzzzzzzzzzzzzzzzm_, izzzzzzzzzzzzzzzzzzzzo_, izzzzzzzzzzzzzzzzzzzzq_);
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzs_ = this.Measurement_Period(context);
            bool? izzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Overlaps(izzzzzzzzzzzzzzzzzzzzr_, izzzzzzzzzzzzzzzzzzzzs_, default);

            return izzzzzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<MedicationRequest> izzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Where<MedicationRequest>(izzzzzzzzzzzzzzzzzzzzd_, izzzzzzzzzzzzzzzzzzzze_);
        bool? izzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Exists<MedicationRequest>(izzzzzzzzzzzzzzzzzzzzf_);

        return izzzzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Has Ordered Contraceptive Medications")]
    public bool? Has_Ordered_Contraceptive_Medications(CqlContext context)
    {
        CqlValueSet izzzzzzzzzzzzzzzzzzzzu_ = this.Contraceptive_Medications(context);
        IEnumerable<MedicationRequest> izzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, izzzzzzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> izzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, izzzzzzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> izzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Union<MedicationRequest>(izzzzzzzzzzzzzzzzzzzzv_, izzzzzzzzzzzzzzzzzzzzx_);
        IEnumerable<MedicationRequest> izzzzzzzzzzzzzzzzzzzzz_ = Status_1_8_000.Instance.isMedicationOrder(context, izzzzzzzzzzzzzzzzzzzzy_);
        bool? jzzzzzzzzzzzzzzzzzzzza_(MedicationRequest OrderedContraceptives)
        {
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzd_ = this.Measurement_Period(context);
            FhirDateTime jzzzzzzzzzzzzzzzzzzzze_ = OrderedContraceptives?.AuthoredOnElement;
            CqlDateTime jzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Convert<CqlDateTime>(jzzzzzzzzzzzzzzzzzzzze_);
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.toInterval(context, jzzzzzzzzzzzzzzzzzzzzf_ as object);
            bool? jzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(jzzzzzzzzzzzzzzzzzzzzd_, jzzzzzzzzzzzzzzzzzzzzg_, "day");

            return jzzzzzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<MedicationRequest> jzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Where<MedicationRequest>(izzzzzzzzzzzzzzzzzzzzz_, jzzzzzzzzzzzzzzzzzzzza_);
        bool? jzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Exists<MedicationRequest>(jzzzzzzzzzzzzzzzzzzzzb_);

        return jzzzzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Has Laboratory Tests Identifying Sexual Activity But Not Pregnancy")]
    public bool? Has_Laboratory_Tests_Identifying_Sexual_Activity_But_Not_Pregnancy(CqlContext context)
    {
        CqlValueSet jzzzzzzzzzzzzzzzzzzzzi_ = this.Pap_Test(context);
        IEnumerable<ServiceRequest> jzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, jzzzzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        CqlValueSet jzzzzzzzzzzzzzzzzzzzzk_ = this.Lab_Tests_During_Pregnancy(context);
        IEnumerable<ServiceRequest> jzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, jzzzzzzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> jzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Union<ServiceRequest>(jzzzzzzzzzzzzzzzzzzzzj_, jzzzzzzzzzzzzzzzzzzzzl_);
        CqlValueSet jzzzzzzzzzzzzzzzzzzzzn_ = this.Lab_Tests_for_Sexually_Transmitted_Infections(context);
        IEnumerable<ServiceRequest> jzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, jzzzzzzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> jzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Union<ServiceRequest>(jzzzzzzzzzzzzzzzzzzzzm_, jzzzzzzzzzzzzzzzzzzzzo_);
        IEnumerable<ServiceRequest> jzzzzzzzzzzzzzzzzzzzzq_ = Status_1_8_000.Instance.isLaboratoryTestOrder(context, jzzzzzzzzzzzzzzzzzzzzp_);
        bool? jzzzzzzzzzzzzzzzzzzzzr_(ServiceRequest LabOrders)
        {
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzu_ = this.Measurement_Period(context);
            FhirDateTime jzzzzzzzzzzzzzzzzzzzzv_ = LabOrders?.AuthoredOnElement;
            CqlDateTime jzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Convert<CqlDateTime>(jzzzzzzzzzzzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.toInterval(context, jzzzzzzzzzzzzzzzzzzzzw_ as object);
            bool? jzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(jzzzzzzzzzzzzzzzzzzzzu_, jzzzzzzzzzzzzzzzzzzzzx_, "day");

            return jzzzzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<ServiceRequest> jzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Where<ServiceRequest>(jzzzzzzzzzzzzzzzzzzzzq_, jzzzzzzzzzzzzzzzzzzzzr_);
        bool? jzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Exists<ServiceRequest>(jzzzzzzzzzzzzzzzzzzzzs_);

        return jzzzzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Has Laboratory Tests Identifying Sexual Activity")]
    public bool? Has_Laboratory_Tests_Identifying_Sexual_Activity(CqlContext context)
    {
        CqlValueSet jzzzzzzzzzzzzzzzzzzzzz_ = this.Pregnancy_Test(context);
        IEnumerable<ServiceRequest> kzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, jzzzzzzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> kzzzzzzzzzzzzzzzzzzzzb_ = Status_1_8_000.Instance.isLaboratoryTestOrder(context, kzzzzzzzzzzzzzzzzzzzza_);
        bool? kzzzzzzzzzzzzzzzzzzzzc_(ServiceRequest PregnancyTest)
        {
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzh_ = this.Measurement_Period(context);
            FhirDateTime kzzzzzzzzzzzzzzzzzzzzi_ = PregnancyTest?.AuthoredOnElement;
            CqlDateTime kzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Convert<CqlDateTime>(kzzzzzzzzzzzzzzzzzzzzi_);
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.toInterval(context, kzzzzzzzzzzzzzzzzzzzzj_ as object);
            bool? kzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(kzzzzzzzzzzzzzzzzzzzzh_, kzzzzzzzzzzzzzzzzzzzzk_, "day");

            return kzzzzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<ServiceRequest> kzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Where<ServiceRequest>(kzzzzzzzzzzzzzzzzzzzzb_, kzzzzzzzzzzzzzzzzzzzzc_);
        bool? kzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Exists<ServiceRequest>(kzzzzzzzzzzzzzzzzzzzzd_);
        bool? kzzzzzzzzzzzzzzzzzzzzf_ = this.Has_Laboratory_Tests_Identifying_Sexual_Activity_But_Not_Pregnancy(context);
        bool? kzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Or(kzzzzzzzzzzzzzzzzzzzze_, kzzzzzzzzzzzzzzzzzzzzf_);

        return kzzzzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Has Diagnostic Studies Identifying Sexual Activity")]
    public bool? Has_Diagnostic_Studies_Identifying_Sexual_Activity(CqlContext context)
    {
        CqlValueSet kzzzzzzzzzzzzzzzzzzzzm_ = this.Diagnostic_Studies_During_Pregnancy(context);
        IEnumerable<ServiceRequest> kzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, kzzzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> kzzzzzzzzzzzzzzzzzzzzo_ = Status_1_8_000.Instance.isDiagnosticStudyOrder(context, kzzzzzzzzzzzzzzzzzzzzn_);
        bool? kzzzzzzzzzzzzzzzzzzzzp_(ServiceRequest SexualActivityDiagnostics)
        {
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzs_ = this.Measurement_Period(context);
            FhirDateTime kzzzzzzzzzzzzzzzzzzzzt_ = SexualActivityDiagnostics?.AuthoredOnElement;
            CqlDateTime kzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Convert<CqlDateTime>(kzzzzzzzzzzzzzzzzzzzzt_);
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.toInterval(context, kzzzzzzzzzzzzzzzzzzzzu_ as object);
            bool? kzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(kzzzzzzzzzzzzzzzzzzzzs_, kzzzzzzzzzzzzzzzzzzzzv_, "day");

            return kzzzzzzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<ServiceRequest> kzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Where<ServiceRequest>(kzzzzzzzzzzzzzzzzzzzzo_, kzzzzzzzzzzzzzzzzzzzzp_);
        bool? kzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Exists<ServiceRequest>(kzzzzzzzzzzzzzzzzzzzzq_);

        return kzzzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Has Procedures Identifying Sexual Activity")]
    public bool? Has_Procedures_Identifying_Sexual_Activity(CqlContext context)
    {
        CqlValueSet kzzzzzzzzzzzzzzzzzzzzx_ = this.Procedures_Used_to_Indicate_Sexual_Activity(context);
        IEnumerable<Procedure> kzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, kzzzzzzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> kzzzzzzzzzzzzzzzzzzzzz_ = Status_1_8_000.Instance.isProcedurePerformed(context, kzzzzzzzzzzzzzzzzzzzzy_);
        bool? lzzzzzzzzzzzzzzzzzzzza_(Procedure ProceduresForSexualActivity)
        {
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzd_ = this.Measurement_Period(context);
            DataType lzzzzzzzzzzzzzzzzzzzze_ = ProceduresForSexualActivity?.Performed;
            object lzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzze_);
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.toInterval(context, lzzzzzzzzzzzzzzzzzzzzf_);
            bool? lzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(lzzzzzzzzzzzzzzzzzzzzd_, lzzzzzzzzzzzzzzzzzzzzg_, "day");

            return lzzzzzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<Procedure> lzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Where<Procedure>(kzzzzzzzzzzzzzzzzzzzzz_, lzzzzzzzzzzzzzzzzzzzza_);
        bool? lzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Exists<Procedure>(lzzzzzzzzzzzzzzzzzzzzb_);

        return lzzzzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient lzzzzzzzzzzzzzzzzzzzzi_ = this.Patient(context);
        Date lzzzzzzzzzzzzzzzzzzzzj_ = lzzzzzzzzzzzzzzzzzzzzi_?.BirthDateElement;
        string lzzzzzzzzzzzzzzzzzzzzk_ = lzzzzzzzzzzzzzzzzzzzzj_?.Value;
        CqlDate lzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.ConvertStringToDate(lzzzzzzzzzzzzzzzzzzzzk_);
        CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzm_ = this.Measurement_Period(context);
        CqlDateTime lzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.End(lzzzzzzzzzzzzzzzzzzzzm_);
        CqlDate lzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.DateFrom(lzzzzzzzzzzzzzzzzzzzzn_);
        int? lzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.CalculateAgeAt(lzzzzzzzzzzzzzzzzzzzzl_, lzzzzzzzzzzzzzzzzzzzzo_, "year");
        CqlInterval<int?> lzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Interval(16, 24, true, true);
        bool? lzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.In<int?>(lzzzzzzzzzzzzzzzzzzzzp_, lzzzzzzzzzzzzzzzzzzzzq_, default);
        Code<AdministrativeGender> lzzzzzzzzzzzzzzzzzzzzt_ = lzzzzzzzzzzzzzzzzzzzzi_?.GenderElement;
        AdministrativeGender? lzzzzzzzzzzzzzzzzzzzzu_ = lzzzzzzzzzzzzzzzzzzzzt_?.Value;
        string lzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Convert<string>(lzzzzzzzzzzzzzzzzzzzzu_);
        bool? lzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Equal(lzzzzzzzzzzzzzzzzzzzzv_, "female");
        bool? lzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.And(lzzzzzzzzzzzzzzzzzzzzr_, lzzzzzzzzzzzzzzzzzzzzw_);
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzy_ = this.Qualifying_Encounters(context);
        bool? lzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Exists<Encounter>(lzzzzzzzzzzzzzzzzzzzzy_);
        bool? mzzzzzzzzzzzzzzzzzzzza_ = context.Operators.And(lzzzzzzzzzzzzzzzzzzzzx_, lzzzzzzzzzzzzzzzzzzzzz_);
        bool? mzzzzzzzzzzzzzzzzzzzzb_ = this.Has_Assessments_Identifying_Sexual_Activity(context);
        bool? mzzzzzzzzzzzzzzzzzzzzc_ = this.Has_Diagnoses_Identifying_Sexual_Activity(context);
        bool? mzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Or(mzzzzzzzzzzzzzzzzzzzzb_, mzzzzzzzzzzzzzzzzzzzzc_);
        bool? mzzzzzzzzzzzzzzzzzzzze_ = this.Has_Active_Contraceptive_Medications(context);
        bool? mzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Or(mzzzzzzzzzzzzzzzzzzzzd_, mzzzzzzzzzzzzzzzzzzzze_);
        bool? mzzzzzzzzzzzzzzzzzzzzg_ = this.Has_Ordered_Contraceptive_Medications(context);
        bool? mzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Or(mzzzzzzzzzzzzzzzzzzzzf_, mzzzzzzzzzzzzzzzzzzzzg_);
        bool? mzzzzzzzzzzzzzzzzzzzzi_ = this.Has_Laboratory_Tests_Identifying_Sexual_Activity(context);
        bool? mzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Or(mzzzzzzzzzzzzzzzzzzzzh_, mzzzzzzzzzzzzzzzzzzzzi_);
        bool? mzzzzzzzzzzzzzzzzzzzzk_ = this.Has_Diagnostic_Studies_Identifying_Sexual_Activity(context);
        bool? mzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Or(mzzzzzzzzzzzzzzzzzzzzj_, mzzzzzzzzzzzzzzzzzzzzk_);
        bool? mzzzzzzzzzzzzzzzzzzzzm_ = this.Has_Procedures_Identifying_Sexual_Activity(context);
        bool? mzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Or(mzzzzzzzzzzzzzzzzzzzzl_, mzzzzzzzzzzzzzzzzzzzzm_);
        bool? mzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.And(mzzzzzzzzzzzzzzzzzzzza_, mzzzzzzzzzzzzzzzzzzzzn_);

        return mzzzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? mzzzzzzzzzzzzzzzzzzzzp_ = this.Initial_Population(context);

        return mzzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Has Pregnancy Test Exclusion")]
    public bool? Has_Pregnancy_Test_Exclusion(CqlContext context)
    {
        CqlValueSet mzzzzzzzzzzzzzzzzzzzzq_ = this.Pregnancy_Test(context);
        IEnumerable<ServiceRequest> mzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, mzzzzzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> mzzzzzzzzzzzzzzzzzzzzs_ = Status_1_8_000.Instance.isLaboratoryTestOrder(context, mzzzzzzzzzzzzzzzzzzzzr_);
        IEnumerable<ServiceRequest> mzzzzzzzzzzzzzzzzzzzzt_(ServiceRequest PregnancyTest)
        {
            CqlValueSet nzzzzzzzzzzzzzzzzzzzzg_ = this.XRay_Study(context);
            IEnumerable<ServiceRequest> nzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, nzzzzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
            IEnumerable<ServiceRequest> nzzzzzzzzzzzzzzzzzzzzi_ = Status_1_8_000.Instance.isDiagnosticStudyOrder(context, nzzzzzzzzzzzzzzzzzzzzh_);
            bool? nzzzzzzzzzzzzzzzzzzzzj_(ServiceRequest XrayOrder)
            {
                FhirDateTime nzzzzzzzzzzzzzzzzzzzzn_ = XrayOrder?.AuthoredOnElement;
                CqlDateTime nzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Convert<CqlDateTime>(nzzzzzzzzzzzzzzzzzzzzn_);
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.toInterval(context, nzzzzzzzzzzzzzzzzzzzzo_ as object);
                CqlDateTime nzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Start(nzzzzzzzzzzzzzzzzzzzzp_);
                FhirDateTime nzzzzzzzzzzzzzzzzzzzzr_ = PregnancyTest?.AuthoredOnElement;
                CqlDateTime nzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Convert<CqlDateTime>(nzzzzzzzzzzzzzzzzzzzzr_);
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.toInterval(context, nzzzzzzzzzzzzzzzzzzzzs_ as object);
                CqlDateTime nzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.End(nzzzzzzzzzzzzzzzzzzzzt_);
                CqlDateTime nzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Convert<CqlDateTime>(nzzzzzzzzzzzzzzzzzzzzr_);
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.toInterval(context, nzzzzzzzzzzzzzzzzzzzzw_ as object);
                CqlDateTime nzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.End(nzzzzzzzzzzzzzzzzzzzzx_);
                CqlQuantity nzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Quantity(6m, "days");
                CqlDateTime ozzzzzzzzzzzzzzzzzzzza_ = context.Operators.Add(nzzzzzzzzzzzzzzzzzzzzy_, nzzzzzzzzzzzzzzzzzzzzz_);
                CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Interval(nzzzzzzzzzzzzzzzzzzzzu_, ozzzzzzzzzzzzzzzzzzzza_, true, true);
                bool? ozzzzzzzzzzzzzzzzzzzzc_ = context.Operators.In<CqlDateTime>(nzzzzzzzzzzzzzzzzzzzzq_, ozzzzzzzzzzzzzzzzzzzzb_, "day");
                CqlDateTime ozzzzzzzzzzzzzzzzzzzze_ = context.Operators.Convert<CqlDateTime>(nzzzzzzzzzzzzzzzzzzzzr_);
                CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.toInterval(context, ozzzzzzzzzzzzzzzzzzzze_ as object);
                CqlDateTime ozzzzzzzzzzzzzzzzzzzzg_ = context.Operators.End(ozzzzzzzzzzzzzzzzzzzzf_);
                bool? ozzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Not((bool?)(ozzzzzzzzzzzzzzzzzzzzg_ is null));
                bool? ozzzzzzzzzzzzzzzzzzzzi_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzzzc_, ozzzzzzzzzzzzzzzzzzzzh_);

                return ozzzzzzzzzzzzzzzzzzzzi_;
            };
            IEnumerable<ServiceRequest> nzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Where<ServiceRequest>(nzzzzzzzzzzzzzzzzzzzzi_, nzzzzzzzzzzzzzzzzzzzzj_);
            ServiceRequest nzzzzzzzzzzzzzzzzzzzzl_(ServiceRequest XrayOrder) =>
                PregnancyTest;
            IEnumerable<ServiceRequest> nzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Select<ServiceRequest, ServiceRequest>(nzzzzzzzzzzzzzzzzzzzzk_, nzzzzzzzzzzzzzzzzzzzzl_);

            return nzzzzzzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<ServiceRequest> mzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.SelectMany<ServiceRequest, ServiceRequest>(mzzzzzzzzzzzzzzzzzzzzs_, mzzzzzzzzzzzzzzzzzzzzt_);
        bool? mzzzzzzzzzzzzzzzzzzzzv_(ServiceRequest PregnancyTest)
        {
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzj_ = this.Measurement_Period(context);
            FhirDateTime ozzzzzzzzzzzzzzzzzzzzk_ = PregnancyTest?.AuthoredOnElement;
            CqlDateTime ozzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Convert<CqlDateTime>(ozzzzzzzzzzzzzzzzzzzzk_);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.toInterval(context, ozzzzzzzzzzzzzzzzzzzzl_ as object);
            bool? ozzzzzzzzzzzzzzzzzzzzn_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ozzzzzzzzzzzzzzzzzzzzj_, ozzzzzzzzzzzzzzzzzzzzm_, default);

            return ozzzzzzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<ServiceRequest> mzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Where<ServiceRequest>(mzzzzzzzzzzzzzzzzzzzzu_, mzzzzzzzzzzzzzzzzzzzzv_);
        IEnumerable<ServiceRequest> mzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, mzzzzzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> mzzzzzzzzzzzzzzzzzzzzz_ = Status_1_8_000.Instance.isLaboratoryTestOrder(context, mzzzzzzzzzzzzzzzzzzzzy_);
        IEnumerable<ServiceRequest> nzzzzzzzzzzzzzzzzzzzza_(ServiceRequest PregnancyTestOrder)
        {
            CqlValueSet ozzzzzzzzzzzzzzzzzzzzo_ = this.Isotretinoin(context);
            IEnumerable<MedicationRequest> ozzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ozzzzzzzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> ozzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ozzzzzzzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> ozzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Union<MedicationRequest>(ozzzzzzzzzzzzzzzzzzzzp_, ozzzzzzzzzzzzzzzzzzzzr_);
            IEnumerable<MedicationRequest> ozzzzzzzzzzzzzzzzzzzzt_ = Status_1_8_000.Instance.isMedicationOrder(context, ozzzzzzzzzzzzzzzzzzzzs_);
            bool? ozzzzzzzzzzzzzzzzzzzzu_(MedicationRequest AccutaneOrder)
            {
                FhirDateTime ozzzzzzzzzzzzzzzzzzzzy_ = AccutaneOrder?.AuthoredOnElement;
                CqlDateTime ozzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Convert<CqlDateTime>(ozzzzzzzzzzzzzzzzzzzzy_);
                CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.toInterval(context, ozzzzzzzzzzzzzzzzzzzzz_ as object);
                CqlDateTime pzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Start(pzzzzzzzzzzzzzzzzzzzza_);
                FhirDateTime pzzzzzzzzzzzzzzzzzzzzc_ = PregnancyTestOrder?.AuthoredOnElement;
                CqlDateTime pzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Convert<CqlDateTime>(pzzzzzzzzzzzzzzzzzzzzc_);
                CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.toInterval(context, pzzzzzzzzzzzzzzzzzzzzd_ as object);
                CqlDateTime pzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.End(pzzzzzzzzzzzzzzzzzzzze_);
                CqlDateTime pzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Convert<CqlDateTime>(pzzzzzzzzzzzzzzzzzzzzc_);
                CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.toInterval(context, pzzzzzzzzzzzzzzzzzzzzh_ as object);
                CqlDateTime pzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.End(pzzzzzzzzzzzzzzzzzzzzi_);
                CqlQuantity pzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Quantity(6m, "days");
                CqlDateTime pzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Add(pzzzzzzzzzzzzzzzzzzzzj_, pzzzzzzzzzzzzzzzzzzzzk_);
                CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Interval(pzzzzzzzzzzzzzzzzzzzzf_, pzzzzzzzzzzzzzzzzzzzzl_, true, true);
                bool? pzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.In<CqlDateTime>(pzzzzzzzzzzzzzzzzzzzzb_, pzzzzzzzzzzzzzzzzzzzzm_, "day");
                CqlDateTime pzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Convert<CqlDateTime>(pzzzzzzzzzzzzzzzzzzzzc_);
                CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.toInterval(context, pzzzzzzzzzzzzzzzzzzzzp_ as object);
                CqlDateTime pzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.End(pzzzzzzzzzzzzzzzzzzzzq_);
                bool? pzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Not((bool?)(pzzzzzzzzzzzzzzzzzzzzr_ is null));
                bool? pzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.And(pzzzzzzzzzzzzzzzzzzzzn_, pzzzzzzzzzzzzzzzzzzzzs_);

                return pzzzzzzzzzzzzzzzzzzzzt_;
            };
            IEnumerable<MedicationRequest> ozzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<MedicationRequest>(ozzzzzzzzzzzzzzzzzzzzt_, ozzzzzzzzzzzzzzzzzzzzu_);
            ServiceRequest ozzzzzzzzzzzzzzzzzzzzw_(MedicationRequest AccutaneOrder) =>
                PregnancyTestOrder;
            IEnumerable<ServiceRequest> ozzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Select<MedicationRequest, ServiceRequest>(ozzzzzzzzzzzzzzzzzzzzv_, ozzzzzzzzzzzzzzzzzzzzw_);

            return ozzzzzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<ServiceRequest> nzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.SelectMany<ServiceRequest, ServiceRequest>(mzzzzzzzzzzzzzzzzzzzzz_, nzzzzzzzzzzzzzzzzzzzza_);
        bool? nzzzzzzzzzzzzzzzzzzzzc_(ServiceRequest PregnancyTestOrder)
        {
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzu_ = this.Measurement_Period(context);
            FhirDateTime pzzzzzzzzzzzzzzzzzzzzv_ = PregnancyTestOrder?.AuthoredOnElement;
            CqlDateTime pzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Convert<CqlDateTime>(pzzzzzzzzzzzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.toInterval(context, pzzzzzzzzzzzzzzzzzzzzw_ as object);
            bool? pzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(pzzzzzzzzzzzzzzzzzzzzu_, pzzzzzzzzzzzzzzzzzzzzx_, default);

            return pzzzzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<ServiceRequest> nzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Where<ServiceRequest>(nzzzzzzzzzzzzzzzzzzzzb_, nzzzzzzzzzzzzzzzzzzzzc_);
        IEnumerable<ServiceRequest> nzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Union<ServiceRequest>(mzzzzzzzzzzzzzzzzzzzzw_, nzzzzzzzzzzzzzzzzzzzzd_);
        bool? nzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Exists<ServiceRequest>(nzzzzzzzzzzzzzzzzzzzze_);

        return nzzzzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? pzzzzzzzzzzzzzzzzzzzzz_ = Hospice_6_12_000.Instance.Has_Hospice_Services(context);
        bool? qzzzzzzzzzzzzzzzzzzzza_ = this.Has_Pregnancy_Test_Exclusion(context);
        bool? qzzzzzzzzzzzzzzzzzzzzb_ = this.Has_Assessments_Identifying_Sexual_Activity(context);
        bool? qzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Not(qzzzzzzzzzzzzzzzzzzzzb_);
        bool? qzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.And(qzzzzzzzzzzzzzzzzzzzza_, qzzzzzzzzzzzzzzzzzzzzc_);
        bool? qzzzzzzzzzzzzzzzzzzzze_ = this.Has_Diagnoses_Identifying_Sexual_Activity(context);
        bool? qzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Not(qzzzzzzzzzzzzzzzzzzzze_);
        bool? qzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.And(qzzzzzzzzzzzzzzzzzzzzd_, qzzzzzzzzzzzzzzzzzzzzf_);
        bool? qzzzzzzzzzzzzzzzzzzzzh_ = this.Has_Active_Contraceptive_Medications(context);
        bool? qzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Not(qzzzzzzzzzzzzzzzzzzzzh_);
        bool? qzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.And(qzzzzzzzzzzzzzzzzzzzzg_, qzzzzzzzzzzzzzzzzzzzzi_);
        bool? qzzzzzzzzzzzzzzzzzzzzk_ = this.Has_Ordered_Contraceptive_Medications(context);
        bool? qzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Not(qzzzzzzzzzzzzzzzzzzzzk_);
        bool? qzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.And(qzzzzzzzzzzzzzzzzzzzzj_, qzzzzzzzzzzzzzzzzzzzzl_);
        bool? qzzzzzzzzzzzzzzzzzzzzn_ = this.Has_Laboratory_Tests_Identifying_Sexual_Activity_But_Not_Pregnancy(context);
        bool? qzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Not(qzzzzzzzzzzzzzzzzzzzzn_);
        bool? qzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.And(qzzzzzzzzzzzzzzzzzzzzm_, qzzzzzzzzzzzzzzzzzzzzo_);
        bool? qzzzzzzzzzzzzzzzzzzzzq_ = this.Has_Diagnostic_Studies_Identifying_Sexual_Activity(context);
        bool? qzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Not(qzzzzzzzzzzzzzzzzzzzzq_);
        bool? qzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.And(qzzzzzzzzzzzzzzzzzzzzp_, qzzzzzzzzzzzzzzzzzzzzr_);
        bool? qzzzzzzzzzzzzzzzzzzzzt_ = this.Has_Procedures_Identifying_Sexual_Activity(context);
        bool? qzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Not(qzzzzzzzzzzzzzzzzzzzzt_);
        bool? qzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.And(qzzzzzzzzzzzzzzzzzzzzs_, qzzzzzzzzzzzzzzzzzzzzu_);
        bool? qzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Or(pzzzzzzzzzzzzzzzzzzzzz_, qzzzzzzzzzzzzzzzzzzzzv_);

        return qzzzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        CqlValueSet qzzzzzzzzzzzzzzzzzzzzx_ = this.Chlamydia_Screening(context);
        IEnumerable<Observation> qzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> qzzzzzzzzzzzzzzzzzzzzz_ = Status_1_8_000.Instance.isLaboratoryTestPerformed(context, qzzzzzzzzzzzzzzzzzzzzy_);
        bool? rzzzzzzzzzzzzzzzzzzzza_(Observation ChlamydiaTest)
        {
            object rzzzzzzzzzzzzzzzzzzzzd_()
            {
                bool rzzzzzzzzzzzzzzzzzzzzl_()
                {
                    DataType rzzzzzzzzzzzzzzzzzzzzo_ = ChlamydiaTest?.Effective;
                    object rzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzo_);
                    bool rzzzzzzzzzzzzzzzzzzzzq_ = rzzzzzzzzzzzzzzzzzzzzp_ is CqlDateTime;

                    return rzzzzzzzzzzzzzzzzzzzzq_;
                };
                bool rzzzzzzzzzzzzzzzzzzzzm_()
                {
                    DataType rzzzzzzzzzzzzzzzzzzzzr_ = ChlamydiaTest?.Effective;
                    object rzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzr_);
                    bool rzzzzzzzzzzzzzzzzzzzzt_ = rzzzzzzzzzzzzzzzzzzzzs_ is CqlInterval<CqlDateTime>;

                    return rzzzzzzzzzzzzzzzzzzzzt_;
                };
                bool rzzzzzzzzzzzzzzzzzzzzn_()
                {
                    DataType rzzzzzzzzzzzzzzzzzzzzu_ = ChlamydiaTest?.Effective;
                    object rzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzu_);
                    bool rzzzzzzzzzzzzzzzzzzzzw_ = rzzzzzzzzzzzzzzzzzzzzv_ is CqlDateTime;

                    return rzzzzzzzzzzzzzzzzzzzzw_;
                };
                if (rzzzzzzzzzzzzzzzzzzzzl_())
                {
                    DataType rzzzzzzzzzzzzzzzzzzzzx_ = ChlamydiaTest?.Effective;
                    object rzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzx_);

                    return (rzzzzzzzzzzzzzzzzzzzzy_ as CqlDateTime) as object;
                }
                else if (rzzzzzzzzzzzzzzzzzzzzm_())
                {
                    DataType rzzzzzzzzzzzzzzzzzzzzz_ = ChlamydiaTest?.Effective;
                    object szzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzz_);

                    return (szzzzzzzzzzzzzzzzzzzza_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (rzzzzzzzzzzzzzzzzzzzzn_())
                {
                    DataType szzzzzzzzzzzzzzzzzzzzb_ = ChlamydiaTest?.Effective;
                    object szzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzb_);

                    return (szzzzzzzzzzzzzzzzzzzzc_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime rzzzzzzzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.latest(context, rzzzzzzzzzzzzzzzzzzzzd_());
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzf_ = this.Measurement_Period(context);
            bool? rzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.In<CqlDateTime>(rzzzzzzzzzzzzzzzzzzzze_, rzzzzzzzzzzzzzzzzzzzzf_, "day");
            DataType rzzzzzzzzzzzzzzzzzzzzh_ = ChlamydiaTest?.Value;
            object rzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzh_);
            bool? rzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Not((bool?)(rzzzzzzzzzzzzzzzzzzzzi_ is null));
            bool? rzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.And(rzzzzzzzzzzzzzzzzzzzzg_, rzzzzzzzzzzzzzzzzzzzzj_);

            return rzzzzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<Observation> rzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Where<Observation>(qzzzzzzzzzzzzzzzzzzzzz_, rzzzzzzzzzzzzzzzzzzzza_);
        bool? rzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Exists<Observation>(rzzzzzzzzzzzzzzzzzzzzb_);

        return rzzzzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Stratification 1")]
    public bool? Stratification_1(CqlContext context)
    {
        Patient szzzzzzzzzzzzzzzzzzzzd_ = this.Patient(context);
        Date szzzzzzzzzzzzzzzzzzzze_ = szzzzzzzzzzzzzzzzzzzzd_?.BirthDateElement;
        string szzzzzzzzzzzzzzzzzzzzf_ = szzzzzzzzzzzzzzzzzzzze_?.Value;
        CqlDate szzzzzzzzzzzzzzzzzzzzg_ = context.Operators.ConvertStringToDate(szzzzzzzzzzzzzzzzzzzzf_);
        CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzh_ = this.Measurement_Period(context);
        CqlDateTime szzzzzzzzzzzzzzzzzzzzi_ = context.Operators.End(szzzzzzzzzzzzzzzzzzzzh_);
        CqlDate szzzzzzzzzzzzzzzzzzzzj_ = context.Operators.DateFrom(szzzzzzzzzzzzzzzzzzzzi_);
        int? szzzzzzzzzzzzzzzzzzzzk_ = context.Operators.CalculateAgeAt(szzzzzzzzzzzzzzzzzzzzg_, szzzzzzzzzzzzzzzzzzzzj_, "year");
        CqlInterval<int?> szzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Interval(16, 20, true, true);
        bool? szzzzzzzzzzzzzzzzzzzzm_ = context.Operators.In<int?>(szzzzzzzzzzzzzzzzzzzzk_, szzzzzzzzzzzzzzzzzzzzl_, default);

        return szzzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Stratification 2")]
    public bool? Stratification_2(CqlContext context)
    {
        Patient szzzzzzzzzzzzzzzzzzzzn_ = this.Patient(context);
        Date szzzzzzzzzzzzzzzzzzzzo_ = szzzzzzzzzzzzzzzzzzzzn_?.BirthDateElement;
        string szzzzzzzzzzzzzzzzzzzzp_ = szzzzzzzzzzzzzzzzzzzzo_?.Value;
        CqlDate szzzzzzzzzzzzzzzzzzzzq_ = context.Operators.ConvertStringToDate(szzzzzzzzzzzzzzzzzzzzp_);
        CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzr_ = this.Measurement_Period(context);
        CqlDateTime szzzzzzzzzzzzzzzzzzzzs_ = context.Operators.End(szzzzzzzzzzzzzzzzzzzzr_);
        CqlDate szzzzzzzzzzzzzzzzzzzzt_ = context.Operators.DateFrom(szzzzzzzzzzzzzzzzzzzzs_);
        int? szzzzzzzzzzzzzzzzzzzzu_ = context.Operators.CalculateAgeAt(szzzzzzzzzzzzzzzzzzzzq_, szzzzzzzzzzzzzzzzzzzzt_, "year");
        CqlInterval<int?> szzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Interval(21, 24, true, true);
        bool? szzzzzzzzzzzzzzzzzzzzw_ = context.Operators.In<int?>(szzzzzzzzzzzzzzzzzzzzu_, szzzzzzzzzzzzzzzzzzzzv_, default);

        return szzzzzzzzzzzzzzzzzzzzw_;
    }


    #endregion Expressions

}
