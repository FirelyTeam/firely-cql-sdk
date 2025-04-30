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
[CqlLibrary("DepressionRemissionatTwelveMonthsFHIR", "0.2.000")]
public partial class DepressionRemissionatTwelveMonthsFHIR_0_2_000 : ILibrary, ISingleton<DepressionRemissionatTwelveMonthsFHIR_0_2_000>
{
    private DepressionRemissionatTwelveMonthsFHIR_0_2_000() {}

    public static DepressionRemissionatTwelveMonthsFHIR_0_2_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "DepressionRemissionatTwelveMonthsFHIR";
    public string Version => "0.2.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, SupplementalDataElements_3_5_000.Instance, QICoreCommon_2_1_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    [CqlValueSetDefinition("Bipolar Disorder", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.67.1.101.1.128", valueSetVersion: null)]
    public CqlValueSet Bipolar_Disorder(CqlContext _) => _Bipolar_Disorder;
    private static readonly CqlValueSet _Bipolar_Disorder = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.67.1.101.1.128", null);

    [CqlValueSetDefinition("Contact or Office Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1080.5", valueSetVersion: null)]
    public CqlValueSet Contact_or_Office_Visit(CqlContext _) => _Contact_or_Office_Visit;
    private static readonly CqlValueSet _Contact_or_Office_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1080.5", null);

    [CqlValueSetDefinition("Dysthymia", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.67.1.101.1.254", valueSetVersion: null)]
    public CqlValueSet Dysthymia(CqlContext _) => _Dysthymia;
    private static readonly CqlValueSet _Dysthymia = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.67.1.101.1.254", null);

    [CqlValueSetDefinition("Encounter Inpatient", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", valueSetVersion: null)]
    public CqlValueSet Encounter_Inpatient(CqlContext _) => _Encounter_Inpatient;
    private static readonly CqlValueSet _Encounter_Inpatient = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);

    [CqlValueSetDefinition("Hospice Care Ambulatory", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1584", valueSetVersion: null)]
    public CqlValueSet Hospice_Care_Ambulatory(CqlContext _) => _Hospice_Care_Ambulatory;
    private static readonly CqlValueSet _Hospice_Care_Ambulatory = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1584", null);

    [CqlValueSetDefinition("Hospice Diagnosis", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1165", valueSetVersion: null)]
    public CqlValueSet Hospice_Diagnosis(CqlContext _) => _Hospice_Diagnosis;
    private static readonly CqlValueSet _Hospice_Diagnosis = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1165", null);

    [CqlValueSetDefinition("Hospice Encounter", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1003", valueSetVersion: null)]
    public CqlValueSet Hospice_Encounter(CqlContext _) => _Hospice_Encounter;
    private static readonly CqlValueSet _Hospice_Encounter = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1003", null);

    [CqlValueSetDefinition("Major Depression Including Remission", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.113883.3.67.1.101.3.2444", valueSetVersion: null)]
    public CqlValueSet Major_Depression_Including_Remission(CqlContext _) => _Major_Depression_Including_Remission;
    private static readonly CqlValueSet _Major_Depression_Including_Remission = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.113883.3.67.1.101.3.2444", null);

    [CqlValueSetDefinition("Palliative Care Diagnosis", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1167", valueSetVersion: null)]
    public CqlValueSet Palliative_Care_Diagnosis(CqlContext _) => _Palliative_Care_Diagnosis;
    private static readonly CqlValueSet _Palliative_Care_Diagnosis = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1167", null);

    [CqlValueSetDefinition("Palliative Care Encounter", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1090", valueSetVersion: null)]
    public CqlValueSet Palliative_Care_Encounter(CqlContext _) => _Palliative_Care_Encounter;
    private static readonly CqlValueSet _Palliative_Care_Encounter = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1090", null);

    [CqlValueSetDefinition("Palliative Care Intervention", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1135", valueSetVersion: null)]
    public CqlValueSet Palliative_Care_Intervention(CqlContext _) => _Palliative_Care_Intervention;
    private static readonly CqlValueSet _Palliative_Care_Intervention = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1135", null);

    [CqlValueSetDefinition("Palliative or Hospice Care", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1579", valueSetVersion: null)]
    public CqlValueSet Palliative_or_Hospice_Care(CqlContext _) => _Palliative_or_Hospice_Care;
    private static readonly CqlValueSet _Palliative_or_Hospice_Care = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1579", null);

    [CqlValueSetDefinition("Personality Disorder Emotionally Labile", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.67.1.101.1.246", valueSetVersion: null)]
    public CqlValueSet Personality_Disorder_Emotionally_Labile(CqlContext _) => _Personality_Disorder_Emotionally_Labile;
    private static readonly CqlValueSet _Personality_Disorder_Emotionally_Labile = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.67.1.101.1.246", null);

    [CqlValueSetDefinition("Pervasive Developmental Disorder", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1152", valueSetVersion: null)]
    public CqlValueSet Pervasive_Developmental_Disorder(CqlContext _) => _Pervasive_Developmental_Disorder;
    private static readonly CqlValueSet _Pervasive_Developmental_Disorder = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1152", null);

    [CqlValueSetDefinition("PHQ 9 and PHQ 9M Tools", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.67.1.101.1.263", valueSetVersion: null)]
    public CqlValueSet PHQ_9_and_PHQ_9M_Tools(CqlContext _) => _PHQ_9_and_PHQ_9M_Tools;
    private static readonly CqlValueSet _PHQ_9_and_PHQ_9M_Tools = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.67.1.101.1.263", null);

    [CqlValueSetDefinition("Schizophrenia or Psychotic Disorder", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1104", valueSetVersion: null)]
    public CqlValueSet Schizophrenia_or_Psychotic_Disorder(CqlContext _) => _Schizophrenia_or_Psychotic_Disorder;
    private static readonly CqlValueSet _Schizophrenia_or_Psychotic_Disorder = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1104", null);

    #endregion ValueSets

    #region Codes

    [CqlCodeDefinition("Discharge to healthcare facility for hospice care (procedure)", codeId: "428371000124100", codeSystem: "http://snomed.info/sct")]
    public CqlCode Discharge_to_healthcare_facility_for_hospice_care__procedure_(CqlContext _) => _Discharge_to_healthcare_facility_for_hospice_care__procedure_;
    private static readonly CqlCode _Discharge_to_healthcare_facility_for_hospice_care__procedure_ = new CqlCode("428371000124100", "http://snomed.info/sct", default, default);

    [CqlCodeDefinition("Discharge to home for hospice care (procedure)", codeId: "428361000124107", codeSystem: "http://snomed.info/sct")]
    public CqlCode Discharge_to_home_for_hospice_care__procedure_(CqlContext _) => _Discharge_to_home_for_hospice_care__procedure_;
    private static readonly CqlCode _Discharge_to_home_for_hospice_care__procedure_ = new CqlCode("428361000124107", "http://snomed.info/sct", default, default);

    [CqlCodeDefinition("Functional Assessment of Chronic Illness Therapy - Palliative Care Questionnaire (FACIT-Pal)", codeId: "71007-9", codeSystem: "http://loinc.org")]
    public CqlCode Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal_(CqlContext _) => _Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal_;
    private static readonly CqlCode _Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal_ = new CqlCode("71007-9", "http://loinc.org", default, default);

    [CqlCodeDefinition("Hospice care [Minimum Data Set]", codeId: "45755-6", codeSystem: "http://loinc.org")]
    public CqlCode Hospice_care__Minimum_Data_Set_(CqlContext _) => _Hospice_care__Minimum_Data_Set_;
    private static readonly CqlCode _Hospice_care__Minimum_Data_Set_ = new CqlCode("45755-6", "http://loinc.org", default, default);

    [CqlCodeDefinition("Yes (qualifier value)", codeId: "373066001", codeSystem: "http://snomed.info/sct")]
    public CqlCode Yes__qualifier_value_(CqlContext _) => _Yes__qualifier_value_;
    private static readonly CqlCode _Yes__qualifier_value_ = new CqlCode("373066001", "http://snomed.info/sct", default, default);

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("LOINC")]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC = new CqlCodeSystem();

    [CqlCodeSystemDefinition("SNOMEDCT")]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT = new CqlCodeSystem();

    [CqlCodeSystemDefinition("ConditionVerificationStatusCodes")]
    public CqlCodeSystem ConditionVerificationStatusCodes(CqlContext _) => _ConditionVerificationStatusCodes;
    private static readonly CqlCodeSystem _ConditionVerificationStatusCodes = new CqlCodeSystem();

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Interval(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, true, true);
        object xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.ResolveParameter("DepressionRemissionatTwelveMonthsFHIR-0.2.000", "Measurement Period", xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

        return (CqlInterval<CqlDateTime>)xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.SingletonFrom<Patient>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);

        return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Depression Assessments Greater than 9")]
    public IEnumerable<Observation> Depression_Assessments_Greater_than_9(CqlContext context)
    {
        CqlValueSet xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.PHQ_9_and_PHQ_9M_Tools(context);
        IEnumerable<Observation> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_(Observation DepressionAssessment)
        {
            DataType yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = DepressionAssessment?.Value;
            object yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Greater(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ as int?, 9);
            Code<ObservationStatus> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = DepressionAssessment?.StatusElement;
            ObservationStatus? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_?.Value;
            Code<ObservationStatus> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Convert<Code<ObservationStatus>>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            string yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Convert<string>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            string[] yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.In<string>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ as IEnumerable<string>);
            bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.And(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);

            return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<Observation> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Where<Observation>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

        return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("isConfirmedActiveDiagnosis")]
    public bool? isConfirmedActiveDiagnosis(CqlContext context, Condition condition)
    {
        bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.isActive(context, condition);
        CodeableConcept yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = condition?.VerificationStatus;
        CqlConcept yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        CqlCode yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.confirmed(context);
        CqlConcept yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.ConvertCodeToConcept(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Equivalent(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.And(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);

        return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Depression Diagnoses")]
    public IEnumerable<Condition> Depression_Diagnoses(CqlContext context)
    {
        CqlValueSet yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Major_Depression_Including_Remission(context);
        IEnumerable<Condition> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Dysthymia(context);
        IEnumerable<Condition> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Union<Condition>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
        bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_(Condition Depression)
        {
            bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.isConfirmedActiveDiagnosis(context, Depression);

            return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<Condition> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Where<Condition>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);

        return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Denominator Identification Period")]
    public CqlInterval<CqlDateTime> Denominator_Identification_Period(CqlContext context)
    {
        CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Measurement_Period(context);
        CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Start(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
        CqlQuantity zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Quantity(14m, "months");
        CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Subtract(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Start(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
        CqlQuantity zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Quantity(2m, "months");
        CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Subtract(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
        CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Interval(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, true, false);

        return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Depression Encounter")]
    public IEnumerable<Encounter> Depression_Encounter(CqlContext context)
    {
        CqlValueSet zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Contact_or_Office_Visit(context);
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_(Encounter ValidEncounter)
        {
            IEnumerable<Condition> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Depression_Diagnoses(context);
            bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_(Condition Depression)
            {
                Period zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = ValidEncounter?.Period;
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, Depression);
                bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Overlaps(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, default);
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.End(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Denominator_Identification_Period(context);
                bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.In<CqlDateTime>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, default);
                bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.And(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                Code<Encounter.EncounterStatus> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = ValidEncounter?.StatusElement;
                Encounter.EncounterStatus? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_?.Value;
                Code<Encounter.EncounterStatus> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Equal(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, "finished");
                bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.And(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

                return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
            };
            IEnumerable<Condition> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Condition>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            Encounter zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_(Condition Depression) =>
                ValidEncounter;
            IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Select<Condition, Encounter>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);

            return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.SelectMany<Encounter, Encounter>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);

        return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Index Depression Assessment")]
    public Observation Index_Depression_Assessment(CqlContext context)
    {
        IEnumerable<Observation> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Depression_Assessments_Greater_than_9(context);
        IEnumerable<Observation> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_(Observation DepressionAssessment)
        {
            IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Depression_Encounter(context);
            bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_(Encounter DepressionEncounter)
            {
                Period azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = DepressionEncounter?.Period;
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Start(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                CqlQuantity azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Quantity(7m, "days");
                CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Subtract(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                CqlDate azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.ConvertDateTimeToDate(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.ConvertDateToDateTime(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.End(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Interval(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, true, true);
                DataType bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = DepressionAssessment?.Effective;
                object bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.toInterval(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, "day");

                return bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
            };
            IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Encounter>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            Observation azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_(Encounter DepressionEncounter) =>
                DepressionAssessment;
            IEnumerable<Observation> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Select<Encounter, Observation>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);

            return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<Observation> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.SelectMany<Observation, Observation>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        object azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_(Observation @this)
        {
            DataType bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = @this?.Effective;
            object bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.toInterval(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Start(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);

            return bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<Observation> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.SortBy<Observation>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, System.ComponentModel.ListSortDirection.Ascending);
        Observation azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.First<Observation>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);

        return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Patient(context);
        Date bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_?.BirthDateElement;
        string bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_?.Value;
        CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.ConvertStringToDateTime(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        Observation bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Index_Depression_Assessment(context);
        DataType bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_?.Effective;
        object bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.toInterval(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
        CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Start(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        int? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.CalculateAgeAt(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, "year");
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.GreaterOrEqual(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, 12);

        return bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Initial_Population(context);

        return bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Measure Assessment Period")]
    public CqlInterval<CqlDate> Measure_Assessment_Period(CqlContext context)
    {
        Observation bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Index_Depression_Assessment(context);
        Observation[] bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = [
            bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_,
        ];
        CqlInterval<CqlDate> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_(Observation FirstIndexAssessment)
        {
            DataType czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FirstIndexAssessment?.Effective;
            object czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.toInterval(context, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Start(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            CqlDate czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.DateFrom(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlQuantity czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Quantity(12m, "months");
            CqlDate czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Add(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlQuantity czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Quantity(60m, "days");
            CqlDate czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Subtract(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            object czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.toInterval(context, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Start(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlDate czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.DateFrom(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            CqlDate czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Add(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlDate czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Add(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            CqlInterval<CqlDate> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Interval(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, true, true);

            return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<CqlInterval<CqlDate>> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Select<Observation, CqlInterval<CqlDate>>((IEnumerable<Observation>)bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
        IEnumerable<CqlInterval<CqlDate>> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Distinct<CqlInterval<CqlDate>>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
        CqlInterval<CqlDate> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.SingletonFrom<CqlInterval<CqlDate>>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);

        return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Has Hospice Services in the Measure Assessment Period")]
    public bool? Has_Hospice_Services_in_the_Measure_Assessment_Period(CqlContext context)
    {
        CqlValueSet czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_(Encounter InpatientEncounter)
        {
            Encounter.HospitalizationComponent ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = InpatientEncounter?.Hospitalization;
            CodeableConcept ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_?.DischargeDisposition;
            CqlConcept ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            CqlCode ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Discharge_to_home_for_hospice_care__procedure_(context);
            CqlConcept ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.ConvertCodeToConcept(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Equivalent(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            CodeableConcept ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_?.DischargeDisposition;
            CqlConcept ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlCode ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Discharge_to_healthcare_facility_for_hospice_care__procedure_(context);
            CqlConcept ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.ConvertCodeToConcept(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Equivalent(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Or(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            Period ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = InpatientEncounter?.Period;
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.End(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Denominator_Identification_Period(context);
            CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Start(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            CqlInterval<CqlDate> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Measure_Assessment_Period(context);
            CqlDate ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.End(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.ConvertDateToDateTime(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Interval(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, true, true);
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.In<CqlDateTime>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, "day");
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.And(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            Code<Encounter.EncounterStatus> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = InpatientEncounter?.StatusElement;
            Encounter.EncounterStatus? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_?.Value;
            Code<Encounter.EncounterStatus> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Equal(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, "finished");
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.And(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);

            return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
        };
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Where<Encounter>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
        bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Exists<Encounter>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
        CqlValueSet dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Hospice_Encounter(context);
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_(Encounter HospiceEncounter)
        {
            Period fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = HospiceEncounter?.Period;
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Denominator_Identification_Period(context);
            CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Start(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            CqlInterval<CqlDate> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Measure_Assessment_Period(context);
            CqlDate fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.End(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.ConvertDateToDateTime(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Interval(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, true, true);
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Overlaps(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, "day");
            Code<Encounter.EncounterStatus> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = HospiceEncounter?.StatusElement;
            Encounter.EncounterStatus? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_?.Value;
            Code<Encounter.EncounterStatus> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            string fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Convert<string>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            string[] fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = [
                "cancelled",
                "entered-in-error",
                "unknown",
            ];
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.In<string>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ as IEnumerable<string>);
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Not(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.And(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

            return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Where<Encounter>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
        bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Exists<Encounter>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Or(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
        CqlCode dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Hospice_care__Minimum_Data_Set_(context);
        IEnumerable<CqlCode> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.ToList<CqlCode>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
        IEnumerable<Observation> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_(Observation HospiceAssessment)
        {
            DataType gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = HospiceAssessment?.Value;
            object gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            CqlCode gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Yes__qualifier_value_(context);
            CqlConcept gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.ConvertCodeToConcept(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Equivalent(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ as CqlConcept, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            DataType gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = HospiceAssessment?.Effective;
            object gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.toInterval(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Denominator_Identification_Period(context);
            CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Start(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlInterval<CqlDate> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Measure_Assessment_Period(context);
            CqlDate gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.End(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.ConvertDateToDateTime(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Interval(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, true, true);
            bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Overlaps(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, "day");
            bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.And(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            Code<ObservationStatus> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = HospiceAssessment?.StatusElement;
            ObservationStatus? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_?.Value;
            Code<ObservationStatus> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Convert<Code<ObservationStatus>>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            string gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Convert<string>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            string[] gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.In<string>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ as IEnumerable<string>);
            bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.And(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);

            return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<Observation> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Observation>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Exists<Observation>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
        bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Or(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        CqlValueSet dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Hospice_Care_Ambulatory(context);
        IEnumerable<ServiceRequest> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_(ServiceRequest HospiceOrder)
        {
            FhirDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = HospiceOrder?.AuthoredOnElement;
            CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Convert<CqlDateTime>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Denominator_Identification_Period(context);
            CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Start(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            CqlInterval<CqlDate> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Measure_Assessment_Period(context);
            CqlDate hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.End(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.ConvertDateToDateTime(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Interval(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, true, true);
            bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.In<CqlDateTime>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, "day");
            Code<RequestStatus> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = HospiceOrder?.StatusElement;
            RequestStatus? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_?.Value;
            Code<RequestStatus> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Convert<Code<RequestStatus>>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            string hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Convert<string>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            string[] hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = [
                "active",
                "completed",
            ];
            bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.In<string>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ as IEnumerable<string>);
            bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.And(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            Code<RequestIntent> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = HospiceOrder?.IntentElement;
            RequestIntent? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_?.Value;
            Code<RequestIntent> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Convert<Code<RequestIntent>>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            string hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Convert<string>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            string[] hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = [
                "order",
                "original-order",
                "reflex-order",
                "filler-order",
                "instance-order",
            ];
            bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.In<string>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ as IEnumerable<string>);
            bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.And(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            FhirBoolean hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = HospiceOrder?.DoNotPerformElement;
            bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_?.Value;
            bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.IsTrue(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Not(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.And(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);

            return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<ServiceRequest> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Where<ServiceRequest>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Exists<ServiceRequest>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
        bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Or(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        IEnumerable<Procedure> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_(Procedure HospicePerformed)
        {
            DataType hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = HospicePerformed?.Performed;
            object izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.toInterval(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Denominator_Identification_Period(context);
            CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Start(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            CqlInterval<CqlDate> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Measure_Assessment_Period(context);
            CqlDate izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.End(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.ConvertDateToDateTime(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Interval(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, true, true);
            bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Overlaps(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, "day");
            Code<EventStatus> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = HospicePerformed?.StatusElement;
            EventStatus? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_?.Value;
            string izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Convert<string>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            string[] izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = [
                "not-done",
                "entered-in-error",
                "unknown",
            ];
            bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.In<string>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ as IEnumerable<string>);
            bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Not(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.And(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);

            return izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<Procedure> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Where<Procedure>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
        bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Exists<Procedure>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
        bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Or(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
        CqlValueSet ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Hospice_Diagnosis(context);
        IEnumerable<Condition> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_(Condition HospiceCareDiagnosis)
        {
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, HospiceCareDiagnosis);
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Denominator_Identification_Period(context);
            CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Start(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            CqlInterval<CqlDate> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Measure_Assessment_Period(context);
            CqlDate izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.End(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.ConvertDateToDateTime(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Interval(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, true, true);
            bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Overlaps(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, "day");
            bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.isConfirmedActiveDiagnosis(context, HospiceCareDiagnosis);
            bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.And(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

            return izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<Condition> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Where<Condition>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Exists<Condition>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
        bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Or(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);

        return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Has Palliative Care in the Measure Assessment Period")]
    public bool? Has_Palliative_Care_in_the_Measure_Assessment_Period(CqlContext context)
    {
        CqlCode jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal_(context);
        IEnumerable<CqlCode> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.ToList<CqlCode>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
        IEnumerable<Observation> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_(Observation PalliativeAssessment)
        {
            DataType jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = PalliativeAssessment?.Effective;
            object jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.toInterval(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Denominator_Identification_Period(context);
            CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Start(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            CqlInterval<CqlDate> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Measure_Assessment_Period(context);
            CqlDate kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.End(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.ConvertDateToDateTime(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Interval(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, true, true);
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Overlaps(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, default);
            Code<ObservationStatus> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = PalliativeAssessment?.StatusElement;
            ObservationStatus? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_?.Value;
            Code<ObservationStatus> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Convert<Code<ObservationStatus>>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            string kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Convert<string>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            string[] kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.In<string>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ as IEnumerable<string>);
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.And(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);

            return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<Observation> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Where<Observation>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Exists<Observation>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        CqlValueSet jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Palliative_Care_Diagnosis(context);
        IEnumerable<Condition> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_(Condition PalliativeDiagnosis)
        {
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, PalliativeDiagnosis);
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Denominator_Identification_Period(context);
            CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Start(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            CqlInterval<CqlDate> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Measure_Assessment_Period(context);
            CqlDate kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.End(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.ConvertDateToDateTime(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Interval(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, true, true);
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Overlaps(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, default);
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.isConfirmedActiveDiagnosis(context, PalliativeDiagnosis);
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.And(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);

            return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<Condition> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Where<Condition>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Exists<Condition>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Or(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        CqlValueSet jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Palliative_Care_Encounter(context);
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_(Encounter PalliativeEncounter)
        {
            Period kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = PalliativeEncounter?.Period;
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Denominator_Identification_Period(context);
            CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Start(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            CqlInterval<CqlDate> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Measure_Assessment_Period(context);
            CqlDate lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.End(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.ConvertDateToDateTime(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Interval(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, true, true);
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Overlaps(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, default);
            Code<Encounter.EncounterStatus> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = PalliativeEncounter?.StatusElement;
            Encounter.EncounterStatus? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_?.Value;
            Code<Encounter.EncounterStatus> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Equal(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, "finished");
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.And(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);

            return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Encounter>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Exists<Encounter>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Or(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        CqlValueSet jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Palliative_Care_Intervention(context);
        IEnumerable<Procedure> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_(Procedure PalliativeIntervention)
        {
            DataType lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = PalliativeIntervention?.Performed;
            object lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.toInterval(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Denominator_Identification_Period(context);
            CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Start(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            CqlInterval<CqlDate> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Measure_Assessment_Period(context);
            CqlDate lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.End(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.ConvertDateToDateTime(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Interval(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, true, true);
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Overlaps(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, default);
            Code<EventStatus> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = PalliativeIntervention?.StatusElement;
            EventStatus? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_?.Value;
            string lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Convert<string>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            string[] mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = [
                "not-done",
                "entered-in-error",
                "unknown",
            ];
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.In<string>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ as IEnumerable<string>);
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Not(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.And(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);

            return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<Procedure> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Procedure>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Exists<Procedure>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Or(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);

        return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Patient Expired")]
    public bool? Patient_Expired(CqlContext context)
    {
        Patient mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Patient(context);
        DataType mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_?.Deceased;
        object mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
        CqlInterval<CqlDate> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Measure_Assessment_Period(context);
        CqlDate mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.End(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
        CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.ConvertDateToDateTime(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.SameOrBefore(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ as CqlDateTime, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, default);

        return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Has Mental Health Disorder Diagnoses")]
    public bool? Has_Mental_Health_Disorder_Diagnoses(CqlContext context)
    {
        CqlValueSet mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Bipolar_Disorder(context);
        IEnumerable<Condition> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Personality_Disorder_Emotionally_Labile(context);
        IEnumerable<Condition> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Union<Condition>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        CqlValueSet mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Schizophrenia_or_Psychotic_Disorder(context);
        IEnumerable<Condition> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Pervasive_Developmental_Disorder(context);
        IEnumerable<Condition> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Union<Condition>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
        IEnumerable<Condition> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Union<Condition>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
        bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_(Condition MentalHealthDisorderDiagnoses)
        {
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, MentalHealthDisorderDiagnoses);
            CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Start(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            CqlDate nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.ConvertDateTimeToDate(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            CqlInterval<CqlDate> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Measure_Assessment_Period(context);
            CqlDate nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.End(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.SameOrBefore(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, default);
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.isConfirmedActiveDiagnosis(context, MentalHealthDisorderDiagnoses);
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.And(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

            return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<Condition> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Where<Condition>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
        bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Exists<Condition>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);

        return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Has_Hospice_Services_in_the_Measure_Assessment_Period(context);
        bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Has_Palliative_Care_in_the_Measure_Assessment_Period(context);
        bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Or(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Patient_Expired(context);
        bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Or(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Has_Mental_Health_Disorder_Diagnoses(context);
        bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Or(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);

        return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        CqlValueSet nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.PHQ_9_and_PHQ_9M_Tools(context);
        IEnumerable<Observation> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_(Observation DepressionAssessment)
        {
            DataType nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = DepressionAssessment?.Effective;
            object nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.toInterval(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Start(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            CqlDate ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.ConvertDateTimeToDate(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            CqlInterval<CqlDate> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Measure_Assessment_Period(context);
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.In<CqlDate>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, default);
            Code<ObservationStatus> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = DepressionAssessment?.StatusElement;
            ObservationStatus? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_?.Value;
            Code<ObservationStatus> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Convert<Code<ObservationStatus>>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            string ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Convert<string>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            string[] ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.In<string>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ as IEnumerable<string>);
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

            return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<Observation> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Where<Observation>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        object nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_(Observation @this)
        {
            DataType ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = @this?.Effective;
            object ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.toInterval(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Start(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);

            return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<Observation> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.SortBy<Observation>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, System.ComponentModel.ListSortDirection.Ascending);
        Observation nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Last<Observation>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
        DataType nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_?.Value;
        object nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
        bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Less(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ as int?, 5);

        return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
    }


    #endregion Expressions

}
