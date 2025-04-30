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
    private static readonly CqlCode _Female = new CqlCode("F", "http://terminology.hl7.org/CodeSystem/v3-AdministrativeGender");

    [CqlCodeDefinition("Have you ever had vaginal intercourse [PhenX]", codeId: "64728-9", codeSystem: "http://loinc.org")]
    public CqlCode Have_you_ever_had_vaginal_intercourse__PhenX_(CqlContext _) => _Have_you_ever_had_vaginal_intercourse__PhenX_;
    private static readonly CqlCode _Have_you_ever_had_vaginal_intercourse__PhenX_ = new CqlCode("64728-9", "http://loinc.org");

    [CqlCodeDefinition("Yes (qualifier value)", codeId: "373066001", codeSystem: "http://snomed.info/sct")]
    public CqlCode Yes__qualifier_value_(CqlContext _) => _Yes__qualifier_value_;
    private static readonly CqlCode _Yes__qualifier_value_ = new CqlCode("373066001", "http://snomed.info/sct");

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("AdministrativeGender")]
    public CqlCodeSystem AdministrativeGender(CqlContext _) => _AdministrativeGender;
    private static readonly CqlCodeSystem _AdministrativeGender =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/v3-AdministrativeGender", null, [
          _Female]);

    [CqlCodeSystemDefinition("LOINC")]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC =
      new CqlCodeSystem("http://loinc.org", null, [
          _Have_you_ever_had_vaginal_intercourse__PhenX_]);

    [CqlCodeSystemDefinition("SNOMEDCT")]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT =
      new CqlCodeSystem("http://snomed.info/sct", null, [
          _Yes__qualifier_value_]);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime ozzzzzzzzzzzzzr_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime ozzzzzzzzzzzzzs_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> ozzzzzzzzzzzzzt_ = context.Operators.Interval(ozzzzzzzzzzzzzr_, ozzzzzzzzzzzzzs_, true, true);
        object ozzzzzzzzzzzzzu_ = context.ResolveParameter("ChlamydiaScreeninginWomenFHIR-0.1.000", "Measurement Period", ozzzzzzzzzzzzzt_);

        return (CqlInterval<CqlDateTime>)ozzzzzzzzzzzzzu_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> ozzzzzzzzzzzzzv_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient ozzzzzzzzzzzzzw_ = context.Operators.SingletonFrom<Patient>(ozzzzzzzzzzzzzv_);

        return ozzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? ozzzzzzzzzzzzzx_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return ozzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> ozzzzzzzzzzzzzy_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return ozzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? ozzzzzzzzzzzzzz_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return ozzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode pzzzzzzzzzzzzza_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return pzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Qualifying Encounters")]
    public IEnumerable<Encounter> Qualifying_Encounters(CqlContext context)
    {
        CqlValueSet pzzzzzzzzzzzzzb_ = this.Office_Visit(context);
        IEnumerable<Encounter> pzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, pzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet pzzzzzzzzzzzzzd_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> pzzzzzzzzzzzzze_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, pzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> pzzzzzzzzzzzzzf_ = context.Operators.Union<Encounter>(pzzzzzzzzzzzzzc_, pzzzzzzzzzzzzze_);
        CqlValueSet pzzzzzzzzzzzzzg_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> pzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, pzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet pzzzzzzzzzzzzzi_ = this.Preventive_Care_Services__Initial_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> pzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, pzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> pzzzzzzzzzzzzzk_ = context.Operators.Union<Encounter>(pzzzzzzzzzzzzzh_, pzzzzzzzzzzzzzj_);
        IEnumerable<Encounter> pzzzzzzzzzzzzzl_ = context.Operators.Union<Encounter>(pzzzzzzzzzzzzzf_, pzzzzzzzzzzzzzk_);
        CqlValueSet pzzzzzzzzzzzzzm_ = this.Preventive_Care__Established_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> pzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, pzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet pzzzzzzzzzzzzzo_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter> pzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, pzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> pzzzzzzzzzzzzzq_ = context.Operators.Union<Encounter>(pzzzzzzzzzzzzzn_, pzzzzzzzzzzzzzp_);
        IEnumerable<Encounter> pzzzzzzzzzzzzzr_ = context.Operators.Union<Encounter>(pzzzzzzzzzzzzzl_, pzzzzzzzzzzzzzq_);
        CqlValueSet pzzzzzzzzzzzzzs_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> pzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, pzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet pzzzzzzzzzzzzzu_ = this.Virtual_Encounter(context);
        IEnumerable<Encounter> pzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, pzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> pzzzzzzzzzzzzzw_ = context.Operators.Union<Encounter>(pzzzzzzzzzzzzzt_, pzzzzzzzzzzzzzv_);
        IEnumerable<Encounter> pzzzzzzzzzzzzzx_ = context.Operators.Union<Encounter>(pzzzzzzzzzzzzzr_, pzzzzzzzzzzzzzw_);
        IEnumerable<Encounter> pzzzzzzzzzzzzzy_ = Status_1_8_000.Instance.isEncounterPerformed(context, pzzzzzzzzzzzzzx_);
        bool? pzzzzzzzzzzzzzz_(Encounter ValidEncounters)
        {
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzb_ = this.Measurement_Period(context);
            Period qzzzzzzzzzzzzzc_ = ValidEncounters?.Period;
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzzzzzzzzzc_);
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.toInterval(context, qzzzzzzzzzzzzzd_ as object);
            bool? qzzzzzzzzzzzzzf_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(qzzzzzzzzzzzzzb_, qzzzzzzzzzzzzze_, "day");

            return qzzzzzzzzzzzzzf_;
        };
        IEnumerable<Encounter> qzzzzzzzzzzzzza_ = context.Operators.Where<Encounter>(pzzzzzzzzzzzzzy_, pzzzzzzzzzzzzzz_);

        return qzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Has Assessments Identifying Sexual Activity")]
    public bool? Has_Assessments_Identifying_Sexual_Activity(CqlContext context)
    {
        CqlCode qzzzzzzzzzzzzzg_ = this.Have_you_ever_had_vaginal_intercourse__PhenX_(context);
        IEnumerable<CqlCode> qzzzzzzzzzzzzzh_ = context.Operators.ToList<CqlCode>(qzzzzzzzzzzzzzg_);
        IEnumerable<Observation> qzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, qzzzzzzzzzzzzzh_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> qzzzzzzzzzzzzzj_ = Status_1_8_000.Instance.isAssessmentPerformed(context, qzzzzzzzzzzzzzi_);
        bool? qzzzzzzzzzzzzzk_(Observation SexualActivityAssessment)
        {
            DataType qzzzzzzzzzzzzzn_ = SexualActivityAssessment?.Value;
            object qzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzn_);
            CqlCode qzzzzzzzzzzzzzp_ = this.Yes__qualifier_value_(context);
            CqlConcept qzzzzzzzzzzzzzq_ = context.Operators.ConvertCodeToConcept(qzzzzzzzzzzzzzp_);
            bool? qzzzzzzzzzzzzzr_ = context.Operators.Equivalent(qzzzzzzzzzzzzzo_ as CqlConcept, qzzzzzzzzzzzzzq_);
            DataType qzzzzzzzzzzzzzs_ = SexualActivityAssessment?.Effective;
            object qzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzs_);
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.toInterval(context, qzzzzzzzzzzzzzt_);
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzv_()
            {
                bool qzzzzzzzzzzzzzy_()
                {
                    CqlInterval<CqlDateTime> qzzzzzzzzzzzzzz_ = this.Measurement_Period(context);
                    CqlDateTime rzzzzzzzzzzzzza_ = context.Operators.End(qzzzzzzzzzzzzzz_);

                    return rzzzzzzzzzzzzza_ is null;
                };
                if (qzzzzzzzzzzzzzy_())
                {
                    return default;
                }
                else
                {
                    CqlInterval<CqlDateTime> rzzzzzzzzzzzzzb_ = this.Measurement_Period(context);
                    CqlDateTime rzzzzzzzzzzzzzc_ = context.Operators.End(rzzzzzzzzzzzzzb_);
                    CqlDateTime rzzzzzzzzzzzzze_ = context.Operators.End(rzzzzzzzzzzzzzb_);
                    CqlInterval<CqlDateTime> rzzzzzzzzzzzzzf_ = context.Operators.Interval(rzzzzzzzzzzzzzc_, rzzzzzzzzzzzzze_, true, true);

                    return rzzzzzzzzzzzzzf_;
                }
            };
            bool? qzzzzzzzzzzzzzw_ = context.Operators.SameOrBefore(qzzzzzzzzzzzzzu_, qzzzzzzzzzzzzzv_(), default);
            bool? qzzzzzzzzzzzzzx_ = context.Operators.And(qzzzzzzzzzzzzzr_, qzzzzzzzzzzzzzw_);

            return qzzzzzzzzzzzzzx_;
        };
        IEnumerable<Observation> qzzzzzzzzzzzzzl_ = context.Operators.Where<Observation>(qzzzzzzzzzzzzzj_, qzzzzzzzzzzzzzk_);
        bool? qzzzzzzzzzzzzzm_ = context.Operators.Exists<Observation>(qzzzzzzzzzzzzzl_);

        return qzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Has Diagnoses Identifying Sexual Activity")]
    public bool? Has_Diagnoses_Identifying_Sexual_Activity(CqlContext context)
    {
        CqlValueSet rzzzzzzzzzzzzzg_ = this.Diagnoses_Used_to_Indicate_Sexual_Activity(context);
        IEnumerable<Condition> rzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, rzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet rzzzzzzzzzzzzzi_ = this.HIV(context);
        IEnumerable<Condition> rzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, rzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> rzzzzzzzzzzzzzk_ = context.Operators.Union<Condition>(rzzzzzzzzzzzzzh_, rzzzzzzzzzzzzzj_);
        CqlValueSet rzzzzzzzzzzzzzl_ = this.Complications_of_Pregnancy__Childbirth_and_the_Puerperium(context);
        IEnumerable<Condition> rzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, rzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> rzzzzzzzzzzzzzn_ = context.Operators.Union<Condition>(rzzzzzzzzzzzzzk_, rzzzzzzzzzzzzzm_);
        bool? rzzzzzzzzzzzzzo_(Condition SexualActivityDiagnosis)
        {
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, SexualActivityDiagnosis);
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzzs_ = this.Measurement_Period(context);
            bool? rzzzzzzzzzzzzzt_ = context.Operators.Overlaps(rzzzzzzzzzzzzzr_, rzzzzzzzzzzzzzs_, default);

            return rzzzzzzzzzzzzzt_;
        };
        IEnumerable<Condition> rzzzzzzzzzzzzzp_ = context.Operators.Where<Condition>(rzzzzzzzzzzzzzn_, rzzzzzzzzzzzzzo_);
        bool? rzzzzzzzzzzzzzq_ = context.Operators.Exists<Condition>(rzzzzzzzzzzzzzp_);

        return rzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Has Active Contraceptive Medications")]
    public bool? Has_Active_Contraceptive_Medications(CqlContext context)
    {
        CqlValueSet rzzzzzzzzzzzzzu_ = this.Contraceptive_Medications(context);
        IEnumerable<MedicationRequest> rzzzzzzzzzzzzzv_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, rzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> rzzzzzzzzzzzzzx_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, rzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> rzzzzzzzzzzzzzy_ = context.Operators.Union<MedicationRequest>(rzzzzzzzzzzzzzv_, rzzzzzzzzzzzzzx_);
        IEnumerable<MedicationRequest> rzzzzzzzzzzzzzz_ = Status_1_8_000.Instance.isMedicationActive(context, rzzzzzzzzzzzzzy_);
        bool? szzzzzzzzzzzzza_(MedicationRequest ActiveContraceptives)
        {
            CqlInterval<CqlDate> szzzzzzzzzzzzzd_ = CumulativeMedicationDuration_4_1_000.Instance.medicationRequestPeriod(context, ActiveContraceptives);
            CqlDate szzzzzzzzzzzzze_ = szzzzzzzzzzzzzd_?.low;
            CqlDateTime szzzzzzzzzzzzzf_ = context.Operators.ConvertDateToDateTime(szzzzzzzzzzzzze_);
            CqlDate szzzzzzzzzzzzzh_ = szzzzzzzzzzzzzd_?.high;
            CqlDateTime szzzzzzzzzzzzzi_ = context.Operators.ConvertDateToDateTime(szzzzzzzzzzzzzh_);
            bool? szzzzzzzzzzzzzk_ = szzzzzzzzzzzzzd_?.lowClosed;
            bool? szzzzzzzzzzzzzm_ = szzzzzzzzzzzzzd_?.highClosed;
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzn_ = context.Operators.Interval(szzzzzzzzzzzzzf_, szzzzzzzzzzzzzi_, szzzzzzzzzzzzzk_, szzzzzzzzzzzzzm_);
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzo_ = this.Measurement_Period(context);
            bool? szzzzzzzzzzzzzp_ = context.Operators.Overlaps(szzzzzzzzzzzzzn_, szzzzzzzzzzzzzo_, default);

            return szzzzzzzzzzzzzp_;
        };
        IEnumerable<MedicationRequest> szzzzzzzzzzzzzb_ = context.Operators.Where<MedicationRequest>(rzzzzzzzzzzzzzz_, szzzzzzzzzzzzza_);
        bool? szzzzzzzzzzzzzc_ = context.Operators.Exists<MedicationRequest>(szzzzzzzzzzzzzb_);

        return szzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Has Ordered Contraceptive Medications")]
    public bool? Has_Ordered_Contraceptive_Medications(CqlContext context)
    {
        CqlValueSet szzzzzzzzzzzzzq_ = this.Contraceptive_Medications(context);
        IEnumerable<MedicationRequest> szzzzzzzzzzzzzr_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, szzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> szzzzzzzzzzzzzt_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, szzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> szzzzzzzzzzzzzu_ = context.Operators.Union<MedicationRequest>(szzzzzzzzzzzzzr_, szzzzzzzzzzzzzt_);
        IEnumerable<MedicationRequest> szzzzzzzzzzzzzv_ = Status_1_8_000.Instance.isMedicationOrder(context, szzzzzzzzzzzzzu_);
        bool? szzzzzzzzzzzzzw_(MedicationRequest OrderedContraceptives)
        {
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzz_ = this.Measurement_Period(context);
            FhirDateTime tzzzzzzzzzzzzza_ = OrderedContraceptives?.AuthoredOnElement;
            CqlDateTime tzzzzzzzzzzzzzb_ = context.Operators.Convert<CqlDateTime>(tzzzzzzzzzzzzza_);
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.toInterval(context, tzzzzzzzzzzzzzb_ as object);
            bool? tzzzzzzzzzzzzzd_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(szzzzzzzzzzzzzz_, tzzzzzzzzzzzzzc_, "day");

            return tzzzzzzzzzzzzzd_;
        };
        IEnumerable<MedicationRequest> szzzzzzzzzzzzzx_ = context.Operators.Where<MedicationRequest>(szzzzzzzzzzzzzv_, szzzzzzzzzzzzzw_);
        bool? szzzzzzzzzzzzzy_ = context.Operators.Exists<MedicationRequest>(szzzzzzzzzzzzzx_);

        return szzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Has Laboratory Tests Identifying Sexual Activity But Not Pregnancy")]
    public bool? Has_Laboratory_Tests_Identifying_Sexual_Activity_But_Not_Pregnancy(CqlContext context)
    {
        CqlValueSet tzzzzzzzzzzzzze_ = this.Pap_Test(context);
        IEnumerable<ServiceRequest> tzzzzzzzzzzzzzf_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, tzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        CqlValueSet tzzzzzzzzzzzzzg_ = this.Lab_Tests_During_Pregnancy(context);
        IEnumerable<ServiceRequest> tzzzzzzzzzzzzzh_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, tzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> tzzzzzzzzzzzzzi_ = context.Operators.Union<ServiceRequest>(tzzzzzzzzzzzzzf_, tzzzzzzzzzzzzzh_);
        CqlValueSet tzzzzzzzzzzzzzj_ = this.Lab_Tests_for_Sexually_Transmitted_Infections(context);
        IEnumerable<ServiceRequest> tzzzzzzzzzzzzzk_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, tzzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> tzzzzzzzzzzzzzl_ = context.Operators.Union<ServiceRequest>(tzzzzzzzzzzzzzi_, tzzzzzzzzzzzzzk_);
        IEnumerable<ServiceRequest> tzzzzzzzzzzzzzm_ = Status_1_8_000.Instance.isLaboratoryTestOrder(context, tzzzzzzzzzzzzzl_);
        bool? tzzzzzzzzzzzzzn_(ServiceRequest LabOrders)
        {
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzq_ = this.Measurement_Period(context);
            FhirDateTime tzzzzzzzzzzzzzr_ = LabOrders?.AuthoredOnElement;
            CqlDateTime tzzzzzzzzzzzzzs_ = context.Operators.Convert<CqlDateTime>(tzzzzzzzzzzzzzr_);
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.toInterval(context, tzzzzzzzzzzzzzs_ as object);
            bool? tzzzzzzzzzzzzzu_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(tzzzzzzzzzzzzzq_, tzzzzzzzzzzzzzt_, "day");

            return tzzzzzzzzzzzzzu_;
        };
        IEnumerable<ServiceRequest> tzzzzzzzzzzzzzo_ = context.Operators.Where<ServiceRequest>(tzzzzzzzzzzzzzm_, tzzzzzzzzzzzzzn_);
        bool? tzzzzzzzzzzzzzp_ = context.Operators.Exists<ServiceRequest>(tzzzzzzzzzzzzzo_);

        return tzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Has Laboratory Tests Identifying Sexual Activity")]
    public bool? Has_Laboratory_Tests_Identifying_Sexual_Activity(CqlContext context)
    {
        CqlValueSet tzzzzzzzzzzzzzv_ = this.Pregnancy_Test(context);
        IEnumerable<ServiceRequest> tzzzzzzzzzzzzzw_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, tzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> tzzzzzzzzzzzzzx_ = Status_1_8_000.Instance.isLaboratoryTestOrder(context, tzzzzzzzzzzzzzw_);
        bool? tzzzzzzzzzzzzzy_(ServiceRequest PregnancyTest)
        {
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzd_ = this.Measurement_Period(context);
            FhirDateTime uzzzzzzzzzzzzze_ = PregnancyTest?.AuthoredOnElement;
            CqlDateTime uzzzzzzzzzzzzzf_ = context.Operators.Convert<CqlDateTime>(uzzzzzzzzzzzzze_);
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.toInterval(context, uzzzzzzzzzzzzzf_ as object);
            bool? uzzzzzzzzzzzzzh_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(uzzzzzzzzzzzzzd_, uzzzzzzzzzzzzzg_, "day");

            return uzzzzzzzzzzzzzh_;
        };
        IEnumerable<ServiceRequest> tzzzzzzzzzzzzzz_ = context.Operators.Where<ServiceRequest>(tzzzzzzzzzzzzzx_, tzzzzzzzzzzzzzy_);
        bool? uzzzzzzzzzzzzza_ = context.Operators.Exists<ServiceRequest>(tzzzzzzzzzzzzzz_);
        bool? uzzzzzzzzzzzzzb_ = this.Has_Laboratory_Tests_Identifying_Sexual_Activity_But_Not_Pregnancy(context);
        bool? uzzzzzzzzzzzzzc_ = context.Operators.Or(uzzzzzzzzzzzzza_, uzzzzzzzzzzzzzb_);

        return uzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Has Diagnostic Studies Identifying Sexual Activity")]
    public bool? Has_Diagnostic_Studies_Identifying_Sexual_Activity(CqlContext context)
    {
        CqlValueSet uzzzzzzzzzzzzzi_ = this.Diagnostic_Studies_During_Pregnancy(context);
        IEnumerable<ServiceRequest> uzzzzzzzzzzzzzj_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, uzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> uzzzzzzzzzzzzzk_ = Status_1_8_000.Instance.isDiagnosticStudyOrder(context, uzzzzzzzzzzzzzj_);
        bool? uzzzzzzzzzzzzzl_(ServiceRequest SexualActivityDiagnostics)
        {
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzo_ = this.Measurement_Period(context);
            FhirDateTime uzzzzzzzzzzzzzp_ = SexualActivityDiagnostics?.AuthoredOnElement;
            CqlDateTime uzzzzzzzzzzzzzq_ = context.Operators.Convert<CqlDateTime>(uzzzzzzzzzzzzzp_);
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.toInterval(context, uzzzzzzzzzzzzzq_ as object);
            bool? uzzzzzzzzzzzzzs_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(uzzzzzzzzzzzzzo_, uzzzzzzzzzzzzzr_, "day");

            return uzzzzzzzzzzzzzs_;
        };
        IEnumerable<ServiceRequest> uzzzzzzzzzzzzzm_ = context.Operators.Where<ServiceRequest>(uzzzzzzzzzzzzzk_, uzzzzzzzzzzzzzl_);
        bool? uzzzzzzzzzzzzzn_ = context.Operators.Exists<ServiceRequest>(uzzzzzzzzzzzzzm_);

        return uzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Has Procedures Identifying Sexual Activity")]
    public bool? Has_Procedures_Identifying_Sexual_Activity(CqlContext context)
    {
        CqlValueSet uzzzzzzzzzzzzzt_ = this.Procedures_Used_to_Indicate_Sexual_Activity(context);
        IEnumerable<Procedure> uzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, uzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> uzzzzzzzzzzzzzv_ = Status_1_8_000.Instance.isProcedurePerformed(context, uzzzzzzzzzzzzzu_);
        bool? uzzzzzzzzzzzzzw_(Procedure ProceduresForSexualActivity)
        {
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzz_ = this.Measurement_Period(context);
            DataType vzzzzzzzzzzzzza_ = ProceduresForSexualActivity?.Performed;
            object vzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzza_);
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.toInterval(context, vzzzzzzzzzzzzzb_);
            bool? vzzzzzzzzzzzzzd_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(uzzzzzzzzzzzzzz_, vzzzzzzzzzzzzzc_, "day");

            return vzzzzzzzzzzzzzd_;
        };
        IEnumerable<Procedure> uzzzzzzzzzzzzzx_ = context.Operators.Where<Procedure>(uzzzzzzzzzzzzzv_, uzzzzzzzzzzzzzw_);
        bool? uzzzzzzzzzzzzzy_ = context.Operators.Exists<Procedure>(uzzzzzzzzzzzzzx_);

        return uzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient vzzzzzzzzzzzzze_ = this.Patient(context);
        Date vzzzzzzzzzzzzzf_ = vzzzzzzzzzzzzze_?.BirthDateElement;
        string vzzzzzzzzzzzzzg_ = vzzzzzzzzzzzzzf_?.Value;
        CqlDate vzzzzzzzzzzzzzh_ = context.Operators.ConvertStringToDate(vzzzzzzzzzzzzzg_);
        CqlInterval<CqlDateTime> vzzzzzzzzzzzzzi_ = this.Measurement_Period(context);
        CqlDateTime vzzzzzzzzzzzzzj_ = context.Operators.End(vzzzzzzzzzzzzzi_);
        CqlDate vzzzzzzzzzzzzzk_ = context.Operators.DateFrom(vzzzzzzzzzzzzzj_);
        int? vzzzzzzzzzzzzzl_ = context.Operators.CalculateAgeAt(vzzzzzzzzzzzzzh_, vzzzzzzzzzzzzzk_, "year");
        CqlInterval<int?> vzzzzzzzzzzzzzm_ = context.Operators.Interval(16, 24, true, true);
        bool? vzzzzzzzzzzzzzn_ = context.Operators.In<int?>(vzzzzzzzzzzzzzl_, vzzzzzzzzzzzzzm_, default);
        Code<AdministrativeGender> vzzzzzzzzzzzzzp_ = vzzzzzzzzzzzzze_?.GenderElement;
        AdministrativeGender? vzzzzzzzzzzzzzq_ = vzzzzzzzzzzzzzp_?.Value;
        string vzzzzzzzzzzzzzr_ = context.Operators.Convert<string>(vzzzzzzzzzzzzzq_);
        bool? vzzzzzzzzzzzzzs_ = context.Operators.Equal(vzzzzzzzzzzzzzr_, "female");
        bool? vzzzzzzzzzzzzzt_ = context.Operators.And(vzzzzzzzzzzzzzn_, vzzzzzzzzzzzzzs_);
        IEnumerable<Encounter> vzzzzzzzzzzzzzu_ = this.Qualifying_Encounters(context);
        bool? vzzzzzzzzzzzzzv_ = context.Operators.Exists<Encounter>(vzzzzzzzzzzzzzu_);
        bool? vzzzzzzzzzzzzzw_ = context.Operators.And(vzzzzzzzzzzzzzt_, vzzzzzzzzzzzzzv_);
        bool? vzzzzzzzzzzzzzx_ = this.Has_Assessments_Identifying_Sexual_Activity(context);
        bool? vzzzzzzzzzzzzzy_ = this.Has_Diagnoses_Identifying_Sexual_Activity(context);
        bool? vzzzzzzzzzzzzzz_ = context.Operators.Or(vzzzzzzzzzzzzzx_, vzzzzzzzzzzzzzy_);
        bool? wzzzzzzzzzzzzza_ = this.Has_Active_Contraceptive_Medications(context);
        bool? wzzzzzzzzzzzzzb_ = context.Operators.Or(vzzzzzzzzzzzzzz_, wzzzzzzzzzzzzza_);
        bool? wzzzzzzzzzzzzzc_ = this.Has_Ordered_Contraceptive_Medications(context);
        bool? wzzzzzzzzzzzzzd_ = context.Operators.Or(wzzzzzzzzzzzzzb_, wzzzzzzzzzzzzzc_);
        bool? wzzzzzzzzzzzzze_ = this.Has_Laboratory_Tests_Identifying_Sexual_Activity(context);
        bool? wzzzzzzzzzzzzzf_ = context.Operators.Or(wzzzzzzzzzzzzzd_, wzzzzzzzzzzzzze_);
        bool? wzzzzzzzzzzzzzg_ = this.Has_Diagnostic_Studies_Identifying_Sexual_Activity(context);
        bool? wzzzzzzzzzzzzzh_ = context.Operators.Or(wzzzzzzzzzzzzzf_, wzzzzzzzzzzzzzg_);
        bool? wzzzzzzzzzzzzzi_ = this.Has_Procedures_Identifying_Sexual_Activity(context);
        bool? wzzzzzzzzzzzzzj_ = context.Operators.Or(wzzzzzzzzzzzzzh_, wzzzzzzzzzzzzzi_);
        bool? wzzzzzzzzzzzzzk_ = context.Operators.And(vzzzzzzzzzzzzzw_, wzzzzzzzzzzzzzj_);

        return wzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? wzzzzzzzzzzzzzl_ = this.Initial_Population(context);

        return wzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Has Pregnancy Test Exclusion")]
    public bool? Has_Pregnancy_Test_Exclusion(CqlContext context)
    {
        CqlValueSet wzzzzzzzzzzzzzm_ = this.Pregnancy_Test(context);
        IEnumerable<ServiceRequest> wzzzzzzzzzzzzzn_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, wzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> wzzzzzzzzzzzzzo_ = Status_1_8_000.Instance.isLaboratoryTestOrder(context, wzzzzzzzzzzzzzn_);
        IEnumerable<ServiceRequest> wzzzzzzzzzzzzzp_(ServiceRequest PregnancyTest)
        {
            CqlValueSet xzzzzzzzzzzzzzc_ = this.XRay_Study(context);
            IEnumerable<ServiceRequest> xzzzzzzzzzzzzzd_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, xzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
            IEnumerable<ServiceRequest> xzzzzzzzzzzzzze_ = Status_1_8_000.Instance.isDiagnosticStudyOrder(context, xzzzzzzzzzzzzzd_);
            bool? xzzzzzzzzzzzzzf_(ServiceRequest XrayOrder)
            {
                FhirDateTime xzzzzzzzzzzzzzj_ = XrayOrder?.AuthoredOnElement;
                CqlDateTime xzzzzzzzzzzzzzk_ = context.Operators.Convert<CqlDateTime>(xzzzzzzzzzzzzzj_);
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.toInterval(context, xzzzzzzzzzzzzzk_ as object);
                CqlDateTime xzzzzzzzzzzzzzm_ = context.Operators.Start(xzzzzzzzzzzzzzl_);
                FhirDateTime xzzzzzzzzzzzzzn_ = PregnancyTest?.AuthoredOnElement;
                CqlDateTime xzzzzzzzzzzzzzo_ = context.Operators.Convert<CqlDateTime>(xzzzzzzzzzzzzzn_);
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.toInterval(context, xzzzzzzzzzzzzzo_ as object);
                CqlDateTime xzzzzzzzzzzzzzq_ = context.Operators.End(xzzzzzzzzzzzzzp_);
                CqlDateTime xzzzzzzzzzzzzzs_ = context.Operators.Convert<CqlDateTime>(xzzzzzzzzzzzzzn_);
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.toInterval(context, xzzzzzzzzzzzzzs_ as object);
                CqlDateTime xzzzzzzzzzzzzzu_ = context.Operators.End(xzzzzzzzzzzzzzt_);
                CqlQuantity xzzzzzzzzzzzzzv_ = context.Operators.Quantity(6m, "days");
                CqlDateTime xzzzzzzzzzzzzzw_ = context.Operators.Add(xzzzzzzzzzzzzzu_, xzzzzzzzzzzzzzv_);
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzx_ = context.Operators.Interval(xzzzzzzzzzzzzzq_, xzzzzzzzzzzzzzw_, true, true);
                bool? xzzzzzzzzzzzzzy_ = context.Operators.In<CqlDateTime>(xzzzzzzzzzzzzzm_, xzzzzzzzzzzzzzx_, "day");
                CqlDateTime yzzzzzzzzzzzzza_ = context.Operators.Convert<CqlDateTime>(xzzzzzzzzzzzzzn_);
                CqlInterval<CqlDateTime> yzzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.toInterval(context, yzzzzzzzzzzzzza_ as object);
                CqlDateTime yzzzzzzzzzzzzzc_ = context.Operators.End(yzzzzzzzzzzzzzb_);
                bool? yzzzzzzzzzzzzzd_ = context.Operators.Not((bool?)(yzzzzzzzzzzzzzc_ is null));
                bool? yzzzzzzzzzzzzze_ = context.Operators.And(xzzzzzzzzzzzzzy_, yzzzzzzzzzzzzzd_);

                return yzzzzzzzzzzzzze_;
            };
            IEnumerable<ServiceRequest> xzzzzzzzzzzzzzg_ = context.Operators.Where<ServiceRequest>(xzzzzzzzzzzzzze_, xzzzzzzzzzzzzzf_);
            ServiceRequest xzzzzzzzzzzzzzh_(ServiceRequest XrayOrder) =>
                PregnancyTest;
            IEnumerable<ServiceRequest> xzzzzzzzzzzzzzi_ = context.Operators.Select<ServiceRequest, ServiceRequest>(xzzzzzzzzzzzzzg_, xzzzzzzzzzzzzzh_);

            return xzzzzzzzzzzzzzi_;
        };
        IEnumerable<ServiceRequest> wzzzzzzzzzzzzzq_ = context.Operators.SelectMany<ServiceRequest, ServiceRequest>(wzzzzzzzzzzzzzo_, wzzzzzzzzzzzzzp_);
        bool? wzzzzzzzzzzzzzr_(ServiceRequest PregnancyTest)
        {
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzzf_ = this.Measurement_Period(context);
            FhirDateTime yzzzzzzzzzzzzzg_ = PregnancyTest?.AuthoredOnElement;
            CqlDateTime yzzzzzzzzzzzzzh_ = context.Operators.Convert<CqlDateTime>(yzzzzzzzzzzzzzg_);
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.toInterval(context, yzzzzzzzzzzzzzh_ as object);
            bool? yzzzzzzzzzzzzzj_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(yzzzzzzzzzzzzzf_, yzzzzzzzzzzzzzi_, default);

            return yzzzzzzzzzzzzzj_;
        };
        IEnumerable<ServiceRequest> wzzzzzzzzzzzzzs_ = context.Operators.Where<ServiceRequest>(wzzzzzzzzzzzzzq_, wzzzzzzzzzzzzzr_);
        IEnumerable<ServiceRequest> wzzzzzzzzzzzzzu_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, wzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> wzzzzzzzzzzzzzv_ = Status_1_8_000.Instance.isLaboratoryTestOrder(context, wzzzzzzzzzzzzzu_);
        IEnumerable<ServiceRequest> wzzzzzzzzzzzzzw_(ServiceRequest PregnancyTestOrder)
        {
            CqlValueSet yzzzzzzzzzzzzzk_ = this.Isotretinoin(context);
            IEnumerable<MedicationRequest> yzzzzzzzzzzzzzl_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, yzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> yzzzzzzzzzzzzzn_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, yzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> yzzzzzzzzzzzzzo_ = context.Operators.Union<MedicationRequest>(yzzzzzzzzzzzzzl_, yzzzzzzzzzzzzzn_);
            IEnumerable<MedicationRequest> yzzzzzzzzzzzzzp_ = Status_1_8_000.Instance.isMedicationOrder(context, yzzzzzzzzzzzzzo_);
            bool? yzzzzzzzzzzzzzq_(MedicationRequest AccutaneOrder)
            {
                FhirDateTime yzzzzzzzzzzzzzu_ = AccutaneOrder?.AuthoredOnElement;
                CqlDateTime yzzzzzzzzzzzzzv_ = context.Operators.Convert<CqlDateTime>(yzzzzzzzzzzzzzu_);
                CqlInterval<CqlDateTime> yzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.toInterval(context, yzzzzzzzzzzzzzv_ as object);
                CqlDateTime yzzzzzzzzzzzzzx_ = context.Operators.Start(yzzzzzzzzzzzzzw_);
                FhirDateTime yzzzzzzzzzzzzzy_ = PregnancyTestOrder?.AuthoredOnElement;
                CqlDateTime yzzzzzzzzzzzzzz_ = context.Operators.Convert<CqlDateTime>(yzzzzzzzzzzzzzy_);
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.toInterval(context, yzzzzzzzzzzzzzz_ as object);
                CqlDateTime zzzzzzzzzzzzzzb_ = context.Operators.End(zzzzzzzzzzzzzza_);
                CqlDateTime zzzzzzzzzzzzzzd_ = context.Operators.Convert<CqlDateTime>(yzzzzzzzzzzzzzy_);
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.toInterval(context, zzzzzzzzzzzzzzd_ as object);
                CqlDateTime zzzzzzzzzzzzzzf_ = context.Operators.End(zzzzzzzzzzzzzze_);
                CqlQuantity zzzzzzzzzzzzzzg_ = context.Operators.Quantity(6m, "days");
                CqlDateTime zzzzzzzzzzzzzzh_ = context.Operators.Add(zzzzzzzzzzzzzzf_, zzzzzzzzzzzzzzg_);
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzi_ = context.Operators.Interval(zzzzzzzzzzzzzzb_, zzzzzzzzzzzzzzh_, true, true);
                bool? zzzzzzzzzzzzzzj_ = context.Operators.In<CqlDateTime>(yzzzzzzzzzzzzzx_, zzzzzzzzzzzzzzi_, "day");
                CqlDateTime zzzzzzzzzzzzzzl_ = context.Operators.Convert<CqlDateTime>(yzzzzzzzzzzzzzy_);
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.toInterval(context, zzzzzzzzzzzzzzl_ as object);
                CqlDateTime zzzzzzzzzzzzzzn_ = context.Operators.End(zzzzzzzzzzzzzzm_);
                bool? zzzzzzzzzzzzzzo_ = context.Operators.Not((bool?)(zzzzzzzzzzzzzzn_ is null));
                bool? zzzzzzzzzzzzzzp_ = context.Operators.And(zzzzzzzzzzzzzzj_, zzzzzzzzzzzzzzo_);

                return zzzzzzzzzzzzzzp_;
            };
            IEnumerable<MedicationRequest> yzzzzzzzzzzzzzr_ = context.Operators.Where<MedicationRequest>(yzzzzzzzzzzzzzp_, yzzzzzzzzzzzzzq_);
            ServiceRequest yzzzzzzzzzzzzzs_(MedicationRequest AccutaneOrder) =>
                PregnancyTestOrder;
            IEnumerable<ServiceRequest> yzzzzzzzzzzzzzt_ = context.Operators.Select<MedicationRequest, ServiceRequest>(yzzzzzzzzzzzzzr_, yzzzzzzzzzzzzzs_);

            return yzzzzzzzzzzzzzt_;
        };
        IEnumerable<ServiceRequest> wzzzzzzzzzzzzzx_ = context.Operators.SelectMany<ServiceRequest, ServiceRequest>(wzzzzzzzzzzzzzv_, wzzzzzzzzzzzzzw_);
        bool? wzzzzzzzzzzzzzy_(ServiceRequest PregnancyTestOrder)
        {
            CqlInterval<CqlDateTime> zzzzzzzzzzzzzzq_ = this.Measurement_Period(context);
            FhirDateTime zzzzzzzzzzzzzzr_ = PregnancyTestOrder?.AuthoredOnElement;
            CqlDateTime zzzzzzzzzzzzzzs_ = context.Operators.Convert<CqlDateTime>(zzzzzzzzzzzzzzr_);
            CqlInterval<CqlDateTime> zzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.toInterval(context, zzzzzzzzzzzzzzs_ as object);
            bool? zzzzzzzzzzzzzzu_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(zzzzzzzzzzzzzzq_, zzzzzzzzzzzzzzt_, default);

            return zzzzzzzzzzzzzzu_;
        };
        IEnumerable<ServiceRequest> wzzzzzzzzzzzzzz_ = context.Operators.Where<ServiceRequest>(wzzzzzzzzzzzzzx_, wzzzzzzzzzzzzzy_);
        IEnumerable<ServiceRequest> xzzzzzzzzzzzzza_ = context.Operators.Union<ServiceRequest>(wzzzzzzzzzzzzzs_, wzzzzzzzzzzzzzz_);
        bool? xzzzzzzzzzzzzzb_ = context.Operators.Exists<ServiceRequest>(xzzzzzzzzzzzzza_);

        return xzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? zzzzzzzzzzzzzzv_ = Hospice_6_12_000.Instance.Has_Hospice_Services(context);
        bool? zzzzzzzzzzzzzzw_ = this.Has_Pregnancy_Test_Exclusion(context);
        bool? zzzzzzzzzzzzzzx_ = this.Has_Assessments_Identifying_Sexual_Activity(context);
        bool? zzzzzzzzzzzzzzy_ = context.Operators.Not(zzzzzzzzzzzzzzx_);
        bool? zzzzzzzzzzzzzzz_ = context.Operators.And(zzzzzzzzzzzzzzw_, zzzzzzzzzzzzzzy_);
        bool? azzzzzzzzzzzzzza_ = this.Has_Diagnoses_Identifying_Sexual_Activity(context);
        bool? azzzzzzzzzzzzzzb_ = context.Operators.Not(azzzzzzzzzzzzzza_);
        bool? azzzzzzzzzzzzzzc_ = context.Operators.And(zzzzzzzzzzzzzzz_, azzzzzzzzzzzzzzb_);
        bool? azzzzzzzzzzzzzzd_ = this.Has_Active_Contraceptive_Medications(context);
        bool? azzzzzzzzzzzzzze_ = context.Operators.Not(azzzzzzzzzzzzzzd_);
        bool? azzzzzzzzzzzzzzf_ = context.Operators.And(azzzzzzzzzzzzzzc_, azzzzzzzzzzzzzze_);
        bool? azzzzzzzzzzzzzzg_ = this.Has_Ordered_Contraceptive_Medications(context);
        bool? azzzzzzzzzzzzzzh_ = context.Operators.Not(azzzzzzzzzzzzzzg_);
        bool? azzzzzzzzzzzzzzi_ = context.Operators.And(azzzzzzzzzzzzzzf_, azzzzzzzzzzzzzzh_);
        bool? azzzzzzzzzzzzzzj_ = this.Has_Laboratory_Tests_Identifying_Sexual_Activity_But_Not_Pregnancy(context);
        bool? azzzzzzzzzzzzzzk_ = context.Operators.Not(azzzzzzzzzzzzzzj_);
        bool? azzzzzzzzzzzzzzl_ = context.Operators.And(azzzzzzzzzzzzzzi_, azzzzzzzzzzzzzzk_);
        bool? azzzzzzzzzzzzzzm_ = this.Has_Diagnostic_Studies_Identifying_Sexual_Activity(context);
        bool? azzzzzzzzzzzzzzn_ = context.Operators.Not(azzzzzzzzzzzzzzm_);
        bool? azzzzzzzzzzzzzzo_ = context.Operators.And(azzzzzzzzzzzzzzl_, azzzzzzzzzzzzzzn_);
        bool? azzzzzzzzzzzzzzp_ = this.Has_Procedures_Identifying_Sexual_Activity(context);
        bool? azzzzzzzzzzzzzzq_ = context.Operators.Not(azzzzzzzzzzzzzzp_);
        bool? azzzzzzzzzzzzzzr_ = context.Operators.And(azzzzzzzzzzzzzzo_, azzzzzzzzzzzzzzq_);
        bool? azzzzzzzzzzzzzzs_ = context.Operators.Or(zzzzzzzzzzzzzzv_, azzzzzzzzzzzzzzr_);

        return azzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        CqlValueSet azzzzzzzzzzzzzzt_ = this.Chlamydia_Screening(context);
        IEnumerable<Observation> azzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, azzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> azzzzzzzzzzzzzzv_ = Status_1_8_000.Instance.isLaboratoryTestPerformed(context, azzzzzzzzzzzzzzu_);
        bool? azzzzzzzzzzzzzzw_(Observation ChlamydiaTest)
        {
            object azzzzzzzzzzzzzzz_()
            {
                bool bzzzzzzzzzzzzzzh_()
                {
                    DataType bzzzzzzzzzzzzzzk_ = ChlamydiaTest?.Effective;
                    object bzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzk_);
                    bool bzzzzzzzzzzzzzzm_ = bzzzzzzzzzzzzzzl_ is CqlDateTime;

                    return bzzzzzzzzzzzzzzm_;
                };
                bool bzzzzzzzzzzzzzzi_()
                {
                    DataType bzzzzzzzzzzzzzzn_ = ChlamydiaTest?.Effective;
                    object bzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzn_);
                    bool bzzzzzzzzzzzzzzp_ = bzzzzzzzzzzzzzzo_ is CqlInterval<CqlDateTime>;

                    return bzzzzzzzzzzzzzzp_;
                };
                bool bzzzzzzzzzzzzzzj_()
                {
                    DataType bzzzzzzzzzzzzzzq_ = ChlamydiaTest?.Effective;
                    object bzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzq_);
                    bool bzzzzzzzzzzzzzzs_ = bzzzzzzzzzzzzzzr_ is CqlDateTime;

                    return bzzzzzzzzzzzzzzs_;
                };
                if (bzzzzzzzzzzzzzzh_())
                {
                    DataType bzzzzzzzzzzzzzzt_ = ChlamydiaTest?.Effective;
                    object bzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzt_);

                    return (bzzzzzzzzzzzzzzu_ as CqlDateTime) as object;
                }
                else if (bzzzzzzzzzzzzzzi_())
                {
                    DataType bzzzzzzzzzzzzzzv_ = ChlamydiaTest?.Effective;
                    object bzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzv_);

                    return (bzzzzzzzzzzzzzzw_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (bzzzzzzzzzzzzzzj_())
                {
                    DataType bzzzzzzzzzzzzzzx_ = ChlamydiaTest?.Effective;
                    object bzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzx_);

                    return (bzzzzzzzzzzzzzzy_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime bzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.latest(context, azzzzzzzzzzzzzzz_());
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzb_ = this.Measurement_Period(context);
            bool? bzzzzzzzzzzzzzzc_ = context.Operators.In<CqlDateTime>(bzzzzzzzzzzzzzza_, bzzzzzzzzzzzzzzb_, "day");
            DataType bzzzzzzzzzzzzzzd_ = ChlamydiaTest?.Value;
            object bzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzd_);
            bool? bzzzzzzzzzzzzzzf_ = context.Operators.Not((bool?)(bzzzzzzzzzzzzzze_ is null));
            bool? bzzzzzzzzzzzzzzg_ = context.Operators.And(bzzzzzzzzzzzzzzc_, bzzzzzzzzzzzzzzf_);

            return bzzzzzzzzzzzzzzg_;
        };
        IEnumerable<Observation> azzzzzzzzzzzzzzx_ = context.Operators.Where<Observation>(azzzzzzzzzzzzzzv_, azzzzzzzzzzzzzzw_);
        bool? azzzzzzzzzzzzzzy_ = context.Operators.Exists<Observation>(azzzzzzzzzzzzzzx_);

        return azzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Stratification 1")]
    public bool? Stratification_1(CqlContext context)
    {
        Patient bzzzzzzzzzzzzzzz_ = this.Patient(context);
        Date czzzzzzzzzzzzzza_ = bzzzzzzzzzzzzzzz_?.BirthDateElement;
        string czzzzzzzzzzzzzzb_ = czzzzzzzzzzzzzza_?.Value;
        CqlDate czzzzzzzzzzzzzzc_ = context.Operators.ConvertStringToDate(czzzzzzzzzzzzzzb_);
        CqlInterval<CqlDateTime> czzzzzzzzzzzzzzd_ = this.Measurement_Period(context);
        CqlDateTime czzzzzzzzzzzzzze_ = context.Operators.End(czzzzzzzzzzzzzzd_);
        CqlDate czzzzzzzzzzzzzzf_ = context.Operators.DateFrom(czzzzzzzzzzzzzze_);
        int? czzzzzzzzzzzzzzg_ = context.Operators.CalculateAgeAt(czzzzzzzzzzzzzzc_, czzzzzzzzzzzzzzf_, "year");
        CqlInterval<int?> czzzzzzzzzzzzzzh_ = context.Operators.Interval(16, 20, true, true);
        bool? czzzzzzzzzzzzzzi_ = context.Operators.In<int?>(czzzzzzzzzzzzzzg_, czzzzzzzzzzzzzzh_, default);

        return czzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Stratification 2")]
    public bool? Stratification_2(CqlContext context)
    {
        Patient czzzzzzzzzzzzzzj_ = this.Patient(context);
        Date czzzzzzzzzzzzzzk_ = czzzzzzzzzzzzzzj_?.BirthDateElement;
        string czzzzzzzzzzzzzzl_ = czzzzzzzzzzzzzzk_?.Value;
        CqlDate czzzzzzzzzzzzzzm_ = context.Operators.ConvertStringToDate(czzzzzzzzzzzzzzl_);
        CqlInterval<CqlDateTime> czzzzzzzzzzzzzzn_ = this.Measurement_Period(context);
        CqlDateTime czzzzzzzzzzzzzzo_ = context.Operators.End(czzzzzzzzzzzzzzn_);
        CqlDate czzzzzzzzzzzzzzp_ = context.Operators.DateFrom(czzzzzzzzzzzzzzo_);
        int? czzzzzzzzzzzzzzq_ = context.Operators.CalculateAgeAt(czzzzzzzzzzzzzzm_, czzzzzzzzzzzzzzp_, "year");
        CqlInterval<int?> czzzzzzzzzzzzzzr_ = context.Operators.Interval(21, 24, true, true);
        bool? czzzzzzzzzzzzzzs_ = context.Operators.In<int?>(czzzzzzzzzzzzzzq_, czzzzzzzzzzzzzzr_, default);

        return czzzzzzzzzzzzzzs_;
    }


    #endregion Expressions

}
