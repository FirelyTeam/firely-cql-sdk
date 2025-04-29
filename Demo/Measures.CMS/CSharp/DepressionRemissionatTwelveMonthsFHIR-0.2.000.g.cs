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

    #region ValueSet: Bipolar Disorder
    [CqlValueSetDefinition(
        definitionName: "Bipolar Disorder",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.67.1.101.1.128",
        valueSetVersion: null)]
    public CqlValueSet Bipolar_Disorder(CqlContext context) => _Bipolar_Disorder;

    private static readonly CqlValueSet _Bipolar_Disorder = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.67.1.101.1.128", null);
    #endregion

    #region ValueSet: Contact or Office Visit
    [CqlValueSetDefinition(
        definitionName: "Contact or Office Visit",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1080.5",
        valueSetVersion: null)]
    public CqlValueSet Contact_or_Office_Visit(CqlContext context) => _Contact_or_Office_Visit;

    private static readonly CqlValueSet _Contact_or_Office_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1080.5", null);
    #endregion

    #region ValueSet: Dysthymia
    [CqlValueSetDefinition(
        definitionName: "Dysthymia",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.67.1.101.1.254",
        valueSetVersion: null)]
    public CqlValueSet Dysthymia(CqlContext context) => _Dysthymia;

    private static readonly CqlValueSet _Dysthymia = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.67.1.101.1.254", null);
    #endregion

    #region ValueSet: Encounter Inpatient
    [CqlValueSetDefinition(
        definitionName: "Encounter Inpatient",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307",
        valueSetVersion: null)]
    public CqlValueSet Encounter_Inpatient(CqlContext context) => _Encounter_Inpatient;

    private static readonly CqlValueSet _Encounter_Inpatient = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);
    #endregion

    #region ValueSet: Hospice Care Ambulatory
    [CqlValueSetDefinition(
        definitionName: "Hospice Care Ambulatory",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1584",
        valueSetVersion: null)]
    public CqlValueSet Hospice_Care_Ambulatory(CqlContext context) => _Hospice_Care_Ambulatory;

    private static readonly CqlValueSet _Hospice_Care_Ambulatory = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1584", null);
    #endregion

    #region ValueSet: Hospice Diagnosis
    [CqlValueSetDefinition(
        definitionName: "Hospice Diagnosis",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1165",
        valueSetVersion: null)]
    public CqlValueSet Hospice_Diagnosis(CqlContext context) => _Hospice_Diagnosis;

    private static readonly CqlValueSet _Hospice_Diagnosis = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1165", null);
    #endregion

    #region ValueSet: Hospice Encounter
    [CqlValueSetDefinition(
        definitionName: "Hospice Encounter",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1003",
        valueSetVersion: null)]
    public CqlValueSet Hospice_Encounter(CqlContext context) => _Hospice_Encounter;

    private static readonly CqlValueSet _Hospice_Encounter = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1003", null);
    #endregion

    #region ValueSet: Major Depression Including Remission
    [CqlValueSetDefinition(
        definitionName: "Major Depression Including Remission",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.113883.3.67.1.101.3.2444",
        valueSetVersion: null)]
    public CqlValueSet Major_Depression_Including_Remission(CqlContext context) => _Major_Depression_Including_Remission;

    private static readonly CqlValueSet _Major_Depression_Including_Remission = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.113883.3.67.1.101.3.2444", null);
    #endregion

    #region ValueSet: Palliative Care Diagnosis
    [CqlValueSetDefinition(
        definitionName: "Palliative Care Diagnosis",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1167",
        valueSetVersion: null)]
    public CqlValueSet Palliative_Care_Diagnosis(CqlContext context) => _Palliative_Care_Diagnosis;

    private static readonly CqlValueSet _Palliative_Care_Diagnosis = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1167", null);
    #endregion

    #region ValueSet: Palliative Care Encounter
    [CqlValueSetDefinition(
        definitionName: "Palliative Care Encounter",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1090",
        valueSetVersion: null)]
    public CqlValueSet Palliative_Care_Encounter(CqlContext context) => _Palliative_Care_Encounter;

    private static readonly CqlValueSet _Palliative_Care_Encounter = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1090", null);
    #endregion

    #region ValueSet: Palliative Care Intervention
    [CqlValueSetDefinition(
        definitionName: "Palliative Care Intervention",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1135",
        valueSetVersion: null)]
    public CqlValueSet Palliative_Care_Intervention(CqlContext context) => _Palliative_Care_Intervention;

    private static readonly CqlValueSet _Palliative_Care_Intervention = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1135", null);
    #endregion

    #region ValueSet: Palliative or Hospice Care
    [CqlValueSetDefinition(
        definitionName: "Palliative or Hospice Care",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1579",
        valueSetVersion: null)]
    public CqlValueSet Palliative_or_Hospice_Care(CqlContext context) => _Palliative_or_Hospice_Care;

    private static readonly CqlValueSet _Palliative_or_Hospice_Care = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1579", null);
    #endregion

    #region ValueSet: Personality Disorder Emotionally Labile
    [CqlValueSetDefinition(
        definitionName: "Personality Disorder Emotionally Labile",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.67.1.101.1.246",
        valueSetVersion: null)]
    public CqlValueSet Personality_Disorder_Emotionally_Labile(CqlContext context) => _Personality_Disorder_Emotionally_Labile;

    private static readonly CqlValueSet _Personality_Disorder_Emotionally_Labile = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.67.1.101.1.246", null);
    #endregion

    #region ValueSet: Pervasive Developmental Disorder
    [CqlValueSetDefinition(
        definitionName: "Pervasive Developmental Disorder",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1152",
        valueSetVersion: null)]
    public CqlValueSet Pervasive_Developmental_Disorder(CqlContext context) => _Pervasive_Developmental_Disorder;

    private static readonly CqlValueSet _Pervasive_Developmental_Disorder = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1152", null);
    #endregion

    #region ValueSet: PHQ 9 and PHQ 9M Tools
    [CqlValueSetDefinition(
        definitionName: "PHQ 9 and PHQ 9M Tools",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.67.1.101.1.263",
        valueSetVersion: null)]
    public CqlValueSet PHQ_9_and_PHQ_9M_Tools(CqlContext context) => _PHQ_9_and_PHQ_9M_Tools;

    private static readonly CqlValueSet _PHQ_9_and_PHQ_9M_Tools = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.67.1.101.1.263", null);
    #endregion

    #region ValueSet: Schizophrenia or Psychotic Disorder
    [CqlValueSetDefinition(
        definitionName: "Schizophrenia or Psychotic Disorder",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1104",
        valueSetVersion: null)]
    public CqlValueSet Schizophrenia_or_Psychotic_Disorder(CqlContext context) => _Schizophrenia_or_Psychotic_Disorder;

    private static readonly CqlValueSet _Schizophrenia_or_Psychotic_Disorder = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1104", null);
    #endregion

    #endregion ValueSets

    #region Codes

    #region Code: Discharge to healthcare facility for hospice care (procedure)
    [CqlCodeDefinition(
        definitionName: "Discharge to healthcare facility for hospice care (procedure)",
        codeId: "428371000124100",
        codeSystem: "http://snomed.info/sct")]
    public CqlCode Discharge_to_healthcare_facility_for_hospice_care__procedure_(CqlContext context) => _Discharge_to_healthcare_facility_for_hospice_care__procedure_;

    private static readonly CqlCode _Discharge_to_healthcare_facility_for_hospice_care__procedure_ = new CqlCode("428371000124100", "http://snomed.info/sct", default, default);
    #endregion

    #region Code: Discharge to home for hospice care (procedure)
    [CqlCodeDefinition(
        definitionName: "Discharge to home for hospice care (procedure)",
        codeId: "428361000124107",
        codeSystem: "http://snomed.info/sct")]
    public CqlCode Discharge_to_home_for_hospice_care__procedure_(CqlContext context) => _Discharge_to_home_for_hospice_care__procedure_;

    private static readonly CqlCode _Discharge_to_home_for_hospice_care__procedure_ = new CqlCode("428361000124107", "http://snomed.info/sct", default, default);
    #endregion

    #region Code: Functional Assessment of Chronic Illness Therapy - Palliative Care Questionnaire (FACIT-Pal)
    [CqlCodeDefinition(
        definitionName: "Functional Assessment of Chronic Illness Therapy - Palliative Care Questionnaire (FACIT-Pal)",
        codeId: "71007-9",
        codeSystem: "http://loinc.org")]
    public CqlCode Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal_(CqlContext context) => _Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal_;

    private static readonly CqlCode _Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal_ = new CqlCode("71007-9", "http://loinc.org", default, default);
    #endregion

    #region Code: Hospice care [Minimum Data Set]
    [CqlCodeDefinition(
        definitionName: "Hospice care [Minimum Data Set]",
        codeId: "45755-6",
        codeSystem: "http://loinc.org")]
    public CqlCode Hospice_care__Minimum_Data_Set_(CqlContext context) => _Hospice_care__Minimum_Data_Set_;

    private static readonly CqlCode _Hospice_care__Minimum_Data_Set_ = new CqlCode("45755-6", "http://loinc.org", default, default);
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
        definitionName: "LOINC")]
    public CqlCode[] LOINC(CqlContext context)
    {
        CqlCode[] azzzzzzzzzzzzzzc_ = [
            new CqlCode("71007-9", "http://loinc.org", default, default),
            new CqlCode("45755-6", "http://loinc.org", default, default),
        ];

        return azzzzzzzzzzzzzzc_;
    }


    [CqlCodeSystemDefinition(
        definitionName: "SNOMEDCT")]
    public CqlCode[] SNOMEDCT(CqlContext context)
    {
        CqlCode[] azzzzzzzzzzzzzzd_ = [
            new CqlCode("428371000124100", "http://snomed.info/sct", default, default),
            new CqlCode("428361000124107", "http://snomed.info/sct", default, default),
            new CqlCode("373066001", "http://snomed.info/sct", default, default),
        ];

        return azzzzzzzzzzzzzzd_;
    }


    [CqlCodeSystemDefinition(
        definitionName: "ConditionVerificationStatusCodes")]
    public CqlCode[] ConditionVerificationStatusCodes(CqlContext context)
    {
        CqlCode[] azzzzzzzzzzzzzze_ = []
;

        return azzzzzzzzzzzzzze_;
    }


    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition(
        definitionName: "Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime azzzzzzzzzzzzzzf_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime azzzzzzzzzzzzzzg_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> azzzzzzzzzzzzzzh_ = context.Operators.Interval(azzzzzzzzzzzzzzf_, azzzzzzzzzzzzzzg_, true, true);
        object azzzzzzzzzzzzzzi_ = context.ResolveParameter("DepressionRemissionatTwelveMonthsFHIR-0.2.000", "Measurement Period", azzzzzzzzzzzzzzh_);

        return (CqlInterval<CqlDateTime>)azzzzzzzzzzzzzzi_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition(
        definitionName: "Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> azzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient azzzzzzzzzzzzzzk_ = context.Operators.SingletonFrom<Patient>(azzzzzzzzzzzzzzj_);

        return azzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition(
        definitionName: "Depression Assessments Greater than 9")]
    public IEnumerable<Observation> Depression_Assessments_Greater_than_9(CqlContext context)
    {
        CqlValueSet azzzzzzzzzzzzzzl_ = this.PHQ_9_and_PHQ_9M_Tools(context);
        IEnumerable<Observation> azzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, azzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? azzzzzzzzzzzzzzn_(Observation DepressionAssessment)
        {
            DataType azzzzzzzzzzzzzzp_ = DepressionAssessment?.Value;
            object azzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzp_);
            bool? azzzzzzzzzzzzzzr_ = context.Operators.Greater(azzzzzzzzzzzzzzq_ as int?, 9);
            Code<ObservationStatus> azzzzzzzzzzzzzzs_ = DepressionAssessment?.StatusElement;
            ObservationStatus? azzzzzzzzzzzzzzt_ = azzzzzzzzzzzzzzs_?.Value;
            Code<ObservationStatus> azzzzzzzzzzzzzzu_ = context.Operators.Convert<Code<ObservationStatus>>(azzzzzzzzzzzzzzt_);
            string azzzzzzzzzzzzzzv_ = context.Operators.Convert<string>(azzzzzzzzzzzzzzu_);
            string[] azzzzzzzzzzzzzzw_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? azzzzzzzzzzzzzzx_ = context.Operators.In<string>(azzzzzzzzzzzzzzv_, azzzzzzzzzzzzzzw_ as IEnumerable<string>);
            bool? azzzzzzzzzzzzzzy_ = context.Operators.And(azzzzzzzzzzzzzzr_, azzzzzzzzzzzzzzx_);

            return azzzzzzzzzzzzzzy_;
        };
        IEnumerable<Observation> azzzzzzzzzzzzzzo_ = context.Operators.Where<Observation>(azzzzzzzzzzzzzzm_, azzzzzzzzzzzzzzn_);

        return azzzzzzzzzzzzzzo_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public bool? isConfirmedActiveDiagnosis(CqlContext context, Condition condition)
    {
        bool? azzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.isActive(context, condition);
        CodeableConcept bzzzzzzzzzzzzzza_ = condition?.VerificationStatus;
        CqlConcept bzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bzzzzzzzzzzzzzza_);
        CqlCode bzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.confirmed(context);
        CqlConcept bzzzzzzzzzzzzzzd_ = context.Operators.ConvertCodeToConcept(bzzzzzzzzzzzzzzc_);
        bool? bzzzzzzzzzzzzzze_ = context.Operators.Equivalent(bzzzzzzzzzzzzzzb_, bzzzzzzzzzzzzzzd_);
        bool? bzzzzzzzzzzzzzzf_ = context.Operators.And(azzzzzzzzzzzzzzz_, bzzzzzzzzzzzzzze_);

        return bzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition(
        definitionName: "Depression Diagnoses")]
    public IEnumerable<Condition> Depression_Diagnoses(CqlContext context)
    {
        CqlValueSet bzzzzzzzzzzzzzzg_ = this.Major_Depression_Including_Remission(context);
        IEnumerable<Condition> bzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, bzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet bzzzzzzzzzzzzzzi_ = this.Dysthymia(context);
        IEnumerable<Condition> bzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, bzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> bzzzzzzzzzzzzzzk_ = context.Operators.Union<Condition>(bzzzzzzzzzzzzzzh_, bzzzzzzzzzzzzzzj_);
        bool? bzzzzzzzzzzzzzzl_(Condition Depression)
        {
            bool? bzzzzzzzzzzzzzzn_ = this.isConfirmedActiveDiagnosis(context, Depression);

            return bzzzzzzzzzzzzzzn_;
        };
        IEnumerable<Condition> bzzzzzzzzzzzzzzm_ = context.Operators.Where<Condition>(bzzzzzzzzzzzzzzk_, bzzzzzzzzzzzzzzl_);

        return bzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator Identification Period")]
    public CqlInterval<CqlDateTime> Denominator_Identification_Period(CqlContext context)
    {
        CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzo_ = this.Measurement_Period(context);
        CqlDateTime bzzzzzzzzzzzzzzp_ = context.Operators.Start(bzzzzzzzzzzzzzzo_);
        CqlQuantity bzzzzzzzzzzzzzzq_ = context.Operators.Quantity(14m, "months");
        CqlDateTime bzzzzzzzzzzzzzzr_ = context.Operators.Subtract(bzzzzzzzzzzzzzzp_, bzzzzzzzzzzzzzzq_);
        CqlDateTime bzzzzzzzzzzzzzzt_ = context.Operators.Start(bzzzzzzzzzzzzzzo_);
        CqlQuantity bzzzzzzzzzzzzzzu_ = context.Operators.Quantity(2m, "months");
        CqlDateTime bzzzzzzzzzzzzzzv_ = context.Operators.Subtract(bzzzzzzzzzzzzzzt_, bzzzzzzzzzzzzzzu_);
        CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzw_ = context.Operators.Interval(bzzzzzzzzzzzzzzr_, bzzzzzzzzzzzzzzv_, true, false);

        return bzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition(
        definitionName: "Depression Encounter")]
    public IEnumerable<Encounter> Depression_Encounter(CqlContext context)
    {
        CqlValueSet bzzzzzzzzzzzzzzx_ = this.Contact_or_Office_Visit(context);
        IEnumerable<Encounter> bzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, bzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> bzzzzzzzzzzzzzzz_(Encounter ValidEncounter)
        {
            IEnumerable<Condition> czzzzzzzzzzzzzzb_ = this.Depression_Diagnoses(context);
            bool? czzzzzzzzzzzzzzc_(Condition Depression)
            {
                Period czzzzzzzzzzzzzzg_ = ValidEncounter?.Period;
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzzzzzzzzzzg_);
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, Depression);
                bool? czzzzzzzzzzzzzzj_ = context.Operators.Overlaps(czzzzzzzzzzzzzzh_, czzzzzzzzzzzzzzi_, default);
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzzzzzzzzzzg_);
                CqlDateTime czzzzzzzzzzzzzzm_ = context.Operators.End(czzzzzzzzzzzzzzl_);
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzn_ = this.Denominator_Identification_Period(context);
                bool? czzzzzzzzzzzzzzo_ = context.Operators.In<CqlDateTime>(czzzzzzzzzzzzzzm_, czzzzzzzzzzzzzzn_, default);
                bool? czzzzzzzzzzzzzzp_ = context.Operators.And(czzzzzzzzzzzzzzj_, czzzzzzzzzzzzzzo_);
                Code<Encounter.EncounterStatus> czzzzzzzzzzzzzzq_ = ValidEncounter?.StatusElement;
                Encounter.EncounterStatus? czzzzzzzzzzzzzzr_ = czzzzzzzzzzzzzzq_?.Value;
                Code<Encounter.EncounterStatus> czzzzzzzzzzzzzzs_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(czzzzzzzzzzzzzzr_);
                bool? czzzzzzzzzzzzzzt_ = context.Operators.Equal(czzzzzzzzzzzzzzs_, "finished");
                bool? czzzzzzzzzzzzzzu_ = context.Operators.And(czzzzzzzzzzzzzzp_, czzzzzzzzzzzzzzt_);

                return czzzzzzzzzzzzzzu_;
            };
            IEnumerable<Condition> czzzzzzzzzzzzzzd_ = context.Operators.Where<Condition>(czzzzzzzzzzzzzzb_, czzzzzzzzzzzzzzc_);
            Encounter czzzzzzzzzzzzzze_(Condition Depression) =>
                ValidEncounter;
            IEnumerable<Encounter> czzzzzzzzzzzzzzf_ = context.Operators.Select<Condition, Encounter>(czzzzzzzzzzzzzzd_, czzzzzzzzzzzzzze_);

            return czzzzzzzzzzzzzzf_;
        };
        IEnumerable<Encounter> czzzzzzzzzzzzzza_ = context.Operators.SelectMany<Encounter, Encounter>(bzzzzzzzzzzzzzzy_, bzzzzzzzzzzzzzzz_);

        return czzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition(
        definitionName: "Index Depression Assessment")]
    public Observation Index_Depression_Assessment(CqlContext context)
    {
        IEnumerable<Observation> czzzzzzzzzzzzzzv_ = this.Depression_Assessments_Greater_than_9(context);
        IEnumerable<Observation> czzzzzzzzzzzzzzw_(Observation DepressionAssessment)
        {
            IEnumerable<Encounter> dzzzzzzzzzzzzzzb_ = this.Depression_Encounter(context);
            bool? dzzzzzzzzzzzzzzc_(Encounter DepressionEncounter)
            {
                Period dzzzzzzzzzzzzzzg_ = DepressionEncounter?.Period;
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzzzzzzzzzzzg_);
                CqlDateTime dzzzzzzzzzzzzzzi_ = context.Operators.Start(dzzzzzzzzzzzzzzh_);
                CqlQuantity dzzzzzzzzzzzzzzj_ = context.Operators.Quantity(7m, "days");
                CqlDateTime dzzzzzzzzzzzzzzk_ = context.Operators.Subtract(dzzzzzzzzzzzzzzi_, dzzzzzzzzzzzzzzj_);
                CqlDate dzzzzzzzzzzzzzzl_ = context.Operators.ConvertDateTimeToDate(dzzzzzzzzzzzzzzk_);
                CqlDateTime dzzzzzzzzzzzzzzm_ = context.Operators.ConvertDateToDateTime(dzzzzzzzzzzzzzzl_);
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzzzzzzzzzzzg_);
                CqlDateTime dzzzzzzzzzzzzzzp_ = context.Operators.End(dzzzzzzzzzzzzzzo_);
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzq_ = context.Operators.Interval(dzzzzzzzzzzzzzzm_, dzzzzzzzzzzzzzzp_, true, true);
                DataType dzzzzzzzzzzzzzzr_ = DepressionAssessment?.Effective;
                object dzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzr_);
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.toInterval(context, dzzzzzzzzzzzzzzs_);
                bool? dzzzzzzzzzzzzzzu_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(dzzzzzzzzzzzzzzq_, dzzzzzzzzzzzzzzt_, "day");

                return dzzzzzzzzzzzzzzu_;
            };
            IEnumerable<Encounter> dzzzzzzzzzzzzzzd_ = context.Operators.Where<Encounter>(dzzzzzzzzzzzzzzb_, dzzzzzzzzzzzzzzc_);
            Observation dzzzzzzzzzzzzzze_(Encounter DepressionEncounter) =>
                DepressionAssessment;
            IEnumerable<Observation> dzzzzzzzzzzzzzzf_ = context.Operators.Select<Encounter, Observation>(dzzzzzzzzzzzzzzd_, dzzzzzzzzzzzzzze_);

            return dzzzzzzzzzzzzzzf_;
        };
        IEnumerable<Observation> czzzzzzzzzzzzzzx_ = context.Operators.SelectMany<Observation, Observation>(czzzzzzzzzzzzzzv_, czzzzzzzzzzzzzzw_);
        object czzzzzzzzzzzzzzy_(Observation @this)
        {
            DataType dzzzzzzzzzzzzzzv_ = @this?.Effective;
            object dzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.toInterval(context, dzzzzzzzzzzzzzzw_);
            CqlDateTime dzzzzzzzzzzzzzzy_ = context.Operators.Start(dzzzzzzzzzzzzzzx_);

            return dzzzzzzzzzzzzzzy_;
        };
        IEnumerable<Observation> czzzzzzzzzzzzzzz_ = context.Operators.SortBy<Observation>(czzzzzzzzzzzzzzx_, czzzzzzzzzzzzzzy_, System.ComponentModel.ListSortDirection.Ascending);
        Observation dzzzzzzzzzzzzzza_ = context.Operators.First<Observation>(czzzzzzzzzzzzzzz_);

        return dzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition(
        definitionName: "Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient dzzzzzzzzzzzzzzz_ = this.Patient(context);
        Date ezzzzzzzzzzzzzza_ = dzzzzzzzzzzzzzzz_?.BirthDateElement;
        string ezzzzzzzzzzzzzzb_ = ezzzzzzzzzzzzzza_?.Value;
        CqlDateTime ezzzzzzzzzzzzzzc_ = context.Operators.ConvertStringToDateTime(ezzzzzzzzzzzzzzb_);
        Observation ezzzzzzzzzzzzzzd_ = this.Index_Depression_Assessment(context);
        DataType ezzzzzzzzzzzzzze_ = ezzzzzzzzzzzzzzd_?.Effective;
        object ezzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzze_);
        CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.toInterval(context, ezzzzzzzzzzzzzzf_);
        CqlDateTime ezzzzzzzzzzzzzzh_ = context.Operators.Start(ezzzzzzzzzzzzzzg_);
        int? ezzzzzzzzzzzzzzi_ = context.Operators.CalculateAgeAt(ezzzzzzzzzzzzzzc_, ezzzzzzzzzzzzzzh_, "year");
        bool? ezzzzzzzzzzzzzzj_ = context.Operators.GreaterOrEqual(ezzzzzzzzzzzzzzi_, 12);

        return ezzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? ezzzzzzzzzzzzzzk_ = this.Initial_Population(context);

        return ezzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition(
        definitionName: "Measure Assessment Period")]
    public CqlInterval<CqlDate> Measure_Assessment_Period(CqlContext context)
    {
        Observation ezzzzzzzzzzzzzzl_ = this.Index_Depression_Assessment(context);
        Observation[] ezzzzzzzzzzzzzzm_ = [
            ezzzzzzzzzzzzzzl_,
        ];
        CqlInterval<CqlDate> ezzzzzzzzzzzzzzn_(Observation FirstIndexAssessment)
        {
            DataType ezzzzzzzzzzzzzzr_ = FirstIndexAssessment?.Effective;
            object ezzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzr_);
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.toInterval(context, ezzzzzzzzzzzzzzs_);
            CqlDateTime ezzzzzzzzzzzzzzu_ = context.Operators.Start(ezzzzzzzzzzzzzzt_);
            CqlDate ezzzzzzzzzzzzzzv_ = context.Operators.DateFrom(ezzzzzzzzzzzzzzu_);
            CqlQuantity ezzzzzzzzzzzzzzw_ = context.Operators.Quantity(12m, "months");
            CqlDate ezzzzzzzzzzzzzzx_ = context.Operators.Add(ezzzzzzzzzzzzzzv_, ezzzzzzzzzzzzzzw_);
            CqlQuantity ezzzzzzzzzzzzzzy_ = context.Operators.Quantity(60m, "days");
            CqlDate ezzzzzzzzzzzzzzz_ = context.Operators.Subtract(ezzzzzzzzzzzzzzx_, ezzzzzzzzzzzzzzy_);
            object fzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzr_);
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.toInterval(context, fzzzzzzzzzzzzzzb_);
            CqlDateTime fzzzzzzzzzzzzzzd_ = context.Operators.Start(fzzzzzzzzzzzzzzc_);
            CqlDate fzzzzzzzzzzzzzze_ = context.Operators.DateFrom(fzzzzzzzzzzzzzzd_);
            CqlDate fzzzzzzzzzzzzzzg_ = context.Operators.Add(fzzzzzzzzzzzzzze_, ezzzzzzzzzzzzzzw_);
            CqlDate fzzzzzzzzzzzzzzi_ = context.Operators.Add(fzzzzzzzzzzzzzzg_, ezzzzzzzzzzzzzzy_);
            CqlInterval<CqlDate> fzzzzzzzzzzzzzzj_ = context.Operators.Interval(ezzzzzzzzzzzzzzz_, fzzzzzzzzzzzzzzi_, true, true);

            return fzzzzzzzzzzzzzzj_;
        };
        IEnumerable<CqlInterval<CqlDate>> ezzzzzzzzzzzzzzo_ = context.Operators.Select<Observation, CqlInterval<CqlDate>>((IEnumerable<Observation>)ezzzzzzzzzzzzzzm_, ezzzzzzzzzzzzzzn_);
        IEnumerable<CqlInterval<CqlDate>> ezzzzzzzzzzzzzzp_ = context.Operators.Distinct<CqlInterval<CqlDate>>(ezzzzzzzzzzzzzzo_);
        CqlInterval<CqlDate> ezzzzzzzzzzzzzzq_ = context.Operators.SingletonFrom<CqlInterval<CqlDate>>(ezzzzzzzzzzzzzzp_);

        return ezzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has Hospice Services in the Measure Assessment Period")]
    public bool? Has_Hospice_Services_in_the_Measure_Assessment_Period(CqlContext context)
    {
        CqlValueSet fzzzzzzzzzzzzzzk_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter> fzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, fzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? fzzzzzzzzzzzzzzm_(Encounter InpatientEncounter)
        {
            Encounter.HospitalizationComponent gzzzzzzzzzzzzzzu_ = InpatientEncounter?.Hospitalization;
            CodeableConcept gzzzzzzzzzzzzzzv_ = gzzzzzzzzzzzzzzu_?.DischargeDisposition;
            CqlConcept gzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, gzzzzzzzzzzzzzzv_);
            CqlCode gzzzzzzzzzzzzzzx_ = this.Discharge_to_home_for_hospice_care__procedure_(context);
            CqlConcept gzzzzzzzzzzzzzzy_ = context.Operators.ConvertCodeToConcept(gzzzzzzzzzzzzzzx_);
            bool? gzzzzzzzzzzzzzzz_ = context.Operators.Equivalent(gzzzzzzzzzzzzzzw_, gzzzzzzzzzzzzzzy_);
            CodeableConcept hzzzzzzzzzzzzzzb_ = gzzzzzzzzzzzzzzu_?.DischargeDisposition;
            CqlConcept hzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, hzzzzzzzzzzzzzzb_);
            CqlCode hzzzzzzzzzzzzzzd_ = this.Discharge_to_healthcare_facility_for_hospice_care__procedure_(context);
            CqlConcept hzzzzzzzzzzzzzze_ = context.Operators.ConvertCodeToConcept(hzzzzzzzzzzzzzzd_);
            bool? hzzzzzzzzzzzzzzf_ = context.Operators.Equivalent(hzzzzzzzzzzzzzzc_, hzzzzzzzzzzzzzze_);
            bool? hzzzzzzzzzzzzzzg_ = context.Operators.Or(gzzzzzzzzzzzzzzz_, hzzzzzzzzzzzzzzf_);
            Period hzzzzzzzzzzzzzzh_ = InpatientEncounter?.Period;
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzzzzzzzzzh_);
            CqlDateTime hzzzzzzzzzzzzzzj_ = context.Operators.End(hzzzzzzzzzzzzzzi_);
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzk_ = this.Denominator_Identification_Period(context);
            CqlDateTime hzzzzzzzzzzzzzzl_ = context.Operators.Start(hzzzzzzzzzzzzzzk_);
            CqlInterval<CqlDate> hzzzzzzzzzzzzzzm_ = this.Measure_Assessment_Period(context);
            CqlDate hzzzzzzzzzzzzzzn_ = context.Operators.End(hzzzzzzzzzzzzzzm_);
            CqlDateTime hzzzzzzzzzzzzzzo_ = context.Operators.ConvertDateToDateTime(hzzzzzzzzzzzzzzn_);
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzp_ = context.Operators.Interval(hzzzzzzzzzzzzzzl_, hzzzzzzzzzzzzzzo_, true, true);
            bool? hzzzzzzzzzzzzzzq_ = context.Operators.In<CqlDateTime>(hzzzzzzzzzzzzzzj_, hzzzzzzzzzzzzzzp_, "day");
            bool? hzzzzzzzzzzzzzzr_ = context.Operators.And(hzzzzzzzzzzzzzzg_, hzzzzzzzzzzzzzzq_);
            Code<Encounter.EncounterStatus> hzzzzzzzzzzzzzzs_ = InpatientEncounter?.StatusElement;
            Encounter.EncounterStatus? hzzzzzzzzzzzzzzt_ = hzzzzzzzzzzzzzzs_?.Value;
            Code<Encounter.EncounterStatus> hzzzzzzzzzzzzzzu_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(hzzzzzzzzzzzzzzt_);
            bool? hzzzzzzzzzzzzzzv_ = context.Operators.Equal(hzzzzzzzzzzzzzzu_, "finished");
            bool? hzzzzzzzzzzzzzzw_ = context.Operators.And(hzzzzzzzzzzzzzzr_, hzzzzzzzzzzzzzzv_);

            return hzzzzzzzzzzzzzzw_;
        };
        IEnumerable<Encounter> fzzzzzzzzzzzzzzn_ = context.Operators.Where<Encounter>(fzzzzzzzzzzzzzzl_, fzzzzzzzzzzzzzzm_);
        bool? fzzzzzzzzzzzzzzo_ = context.Operators.Exists<Encounter>(fzzzzzzzzzzzzzzn_);
        CqlValueSet fzzzzzzzzzzzzzzp_ = this.Hospice_Encounter(context);
        IEnumerable<Encounter> fzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, fzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? fzzzzzzzzzzzzzzr_(Encounter HospiceEncounter)
        {
            Period hzzzzzzzzzzzzzzx_ = HospiceEncounter?.Period;
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzzzzzzzzzx_);
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzz_ = this.Denominator_Identification_Period(context);
            CqlDateTime izzzzzzzzzzzzzza_ = context.Operators.Start(hzzzzzzzzzzzzzzz_);
            CqlInterval<CqlDate> izzzzzzzzzzzzzzb_ = this.Measure_Assessment_Period(context);
            CqlDate izzzzzzzzzzzzzzc_ = context.Operators.End(izzzzzzzzzzzzzzb_);
            CqlDateTime izzzzzzzzzzzzzzd_ = context.Operators.ConvertDateToDateTime(izzzzzzzzzzzzzzc_);
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzze_ = context.Operators.Interval(izzzzzzzzzzzzzza_, izzzzzzzzzzzzzzd_, true, true);
            bool? izzzzzzzzzzzzzzf_ = context.Operators.Overlaps(hzzzzzzzzzzzzzzy_, izzzzzzzzzzzzzze_, "day");
            Code<Encounter.EncounterStatus> izzzzzzzzzzzzzzg_ = HospiceEncounter?.StatusElement;
            Encounter.EncounterStatus? izzzzzzzzzzzzzzh_ = izzzzzzzzzzzzzzg_?.Value;
            Code<Encounter.EncounterStatus> izzzzzzzzzzzzzzi_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(izzzzzzzzzzzzzzh_);
            string izzzzzzzzzzzzzzj_ = context.Operators.Convert<string>(izzzzzzzzzzzzzzi_);
            string[] izzzzzzzzzzzzzzk_ = [
                "cancelled",
                "entered-in-error",
                "unknown",
            ];
            bool? izzzzzzzzzzzzzzl_ = context.Operators.In<string>(izzzzzzzzzzzzzzj_, izzzzzzzzzzzzzzk_ as IEnumerable<string>);
            bool? izzzzzzzzzzzzzzm_ = context.Operators.Not(izzzzzzzzzzzzzzl_);
            bool? izzzzzzzzzzzzzzn_ = context.Operators.And(izzzzzzzzzzzzzzf_, izzzzzzzzzzzzzzm_);

            return izzzzzzzzzzzzzzn_;
        };
        IEnumerable<Encounter> fzzzzzzzzzzzzzzs_ = context.Operators.Where<Encounter>(fzzzzzzzzzzzzzzq_, fzzzzzzzzzzzzzzr_);
        bool? fzzzzzzzzzzzzzzt_ = context.Operators.Exists<Encounter>(fzzzzzzzzzzzzzzs_);
        bool? fzzzzzzzzzzzzzzu_ = context.Operators.Or(fzzzzzzzzzzzzzzo_, fzzzzzzzzzzzzzzt_);
        CqlCode fzzzzzzzzzzzzzzv_ = this.Hospice_care__Minimum_Data_Set_(context);
        IEnumerable<CqlCode> fzzzzzzzzzzzzzzw_ = context.Operators.ToList<CqlCode>(fzzzzzzzzzzzzzzv_);
        IEnumerable<Observation> fzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, fzzzzzzzzzzzzzzw_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? fzzzzzzzzzzzzzzy_(Observation HospiceAssessment)
        {
            DataType izzzzzzzzzzzzzzo_ = HospiceAssessment?.Value;
            object izzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzo_);
            CqlCode izzzzzzzzzzzzzzq_ = this.Yes__qualifier_value_(context);
            CqlConcept izzzzzzzzzzzzzzr_ = context.Operators.ConvertCodeToConcept(izzzzzzzzzzzzzzq_);
            bool? izzzzzzzzzzzzzzs_ = context.Operators.Equivalent(izzzzzzzzzzzzzzp_ as CqlConcept, izzzzzzzzzzzzzzr_);
            DataType izzzzzzzzzzzzzzt_ = HospiceAssessment?.Effective;
            object izzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzt_);
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.toInterval(context, izzzzzzzzzzzzzzu_);
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzzw_ = this.Denominator_Identification_Period(context);
            CqlDateTime izzzzzzzzzzzzzzx_ = context.Operators.Start(izzzzzzzzzzzzzzw_);
            CqlInterval<CqlDate> izzzzzzzzzzzzzzy_ = this.Measure_Assessment_Period(context);
            CqlDate izzzzzzzzzzzzzzz_ = context.Operators.End(izzzzzzzzzzzzzzy_);
            CqlDateTime jzzzzzzzzzzzzzza_ = context.Operators.ConvertDateToDateTime(izzzzzzzzzzzzzzz_);
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzb_ = context.Operators.Interval(izzzzzzzzzzzzzzx_, jzzzzzzzzzzzzzza_, true, true);
            bool? jzzzzzzzzzzzzzzc_ = context.Operators.Overlaps(izzzzzzzzzzzzzzv_, jzzzzzzzzzzzzzzb_, "day");
            bool? jzzzzzzzzzzzzzzd_ = context.Operators.And(izzzzzzzzzzzzzzs_, jzzzzzzzzzzzzzzc_);
            Code<ObservationStatus> jzzzzzzzzzzzzzze_ = HospiceAssessment?.StatusElement;
            ObservationStatus? jzzzzzzzzzzzzzzf_ = jzzzzzzzzzzzzzze_?.Value;
            Code<ObservationStatus> jzzzzzzzzzzzzzzg_ = context.Operators.Convert<Code<ObservationStatus>>(jzzzzzzzzzzzzzzf_);
            string jzzzzzzzzzzzzzzh_ = context.Operators.Convert<string>(jzzzzzzzzzzzzzzg_);
            string[] jzzzzzzzzzzzzzzi_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? jzzzzzzzzzzzzzzj_ = context.Operators.In<string>(jzzzzzzzzzzzzzzh_, jzzzzzzzzzzzzzzi_ as IEnumerable<string>);
            bool? jzzzzzzzzzzzzzzk_ = context.Operators.And(jzzzzzzzzzzzzzzd_, jzzzzzzzzzzzzzzj_);

            return jzzzzzzzzzzzzzzk_;
        };
        IEnumerable<Observation> fzzzzzzzzzzzzzzz_ = context.Operators.Where<Observation>(fzzzzzzzzzzzzzzx_, fzzzzzzzzzzzzzzy_);
        bool? gzzzzzzzzzzzzzza_ = context.Operators.Exists<Observation>(fzzzzzzzzzzzzzzz_);
        bool? gzzzzzzzzzzzzzzb_ = context.Operators.Or(fzzzzzzzzzzzzzzu_, gzzzzzzzzzzzzzza_);
        CqlValueSet gzzzzzzzzzzzzzzc_ = this.Hospice_Care_Ambulatory(context);
        IEnumerable<ServiceRequest> gzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, gzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        bool? gzzzzzzzzzzzzzze_(ServiceRequest HospiceOrder)
        {
            FhirDateTime jzzzzzzzzzzzzzzl_ = HospiceOrder?.AuthoredOnElement;
            CqlDateTime jzzzzzzzzzzzzzzm_ = context.Operators.Convert<CqlDateTime>(jzzzzzzzzzzzzzzl_);
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzn_ = this.Denominator_Identification_Period(context);
            CqlDateTime jzzzzzzzzzzzzzzo_ = context.Operators.Start(jzzzzzzzzzzzzzzn_);
            CqlInterval<CqlDate> jzzzzzzzzzzzzzzp_ = this.Measure_Assessment_Period(context);
            CqlDate jzzzzzzzzzzzzzzq_ = context.Operators.End(jzzzzzzzzzzzzzzp_);
            CqlDateTime jzzzzzzzzzzzzzzr_ = context.Operators.ConvertDateToDateTime(jzzzzzzzzzzzzzzq_);
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzs_ = context.Operators.Interval(jzzzzzzzzzzzzzzo_, jzzzzzzzzzzzzzzr_, true, true);
            bool? jzzzzzzzzzzzzzzt_ = context.Operators.In<CqlDateTime>(jzzzzzzzzzzzzzzm_, jzzzzzzzzzzzzzzs_, "day");
            Code<RequestStatus> jzzzzzzzzzzzzzzu_ = HospiceOrder?.StatusElement;
            RequestStatus? jzzzzzzzzzzzzzzv_ = jzzzzzzzzzzzzzzu_?.Value;
            Code<RequestStatus> jzzzzzzzzzzzzzzw_ = context.Operators.Convert<Code<RequestStatus>>(jzzzzzzzzzzzzzzv_);
            string jzzzzzzzzzzzzzzx_ = context.Operators.Convert<string>(jzzzzzzzzzzzzzzw_);
            string[] jzzzzzzzzzzzzzzy_ = [
                "active",
                "completed",
            ];
            bool? jzzzzzzzzzzzzzzz_ = context.Operators.In<string>(jzzzzzzzzzzzzzzx_, jzzzzzzzzzzzzzzy_ as IEnumerable<string>);
            bool? kzzzzzzzzzzzzzza_ = context.Operators.And(jzzzzzzzzzzzzzzt_, jzzzzzzzzzzzzzzz_);
            Code<RequestIntent> kzzzzzzzzzzzzzzb_ = HospiceOrder?.IntentElement;
            RequestIntent? kzzzzzzzzzzzzzzc_ = kzzzzzzzzzzzzzzb_?.Value;
            Code<RequestIntent> kzzzzzzzzzzzzzzd_ = context.Operators.Convert<Code<RequestIntent>>(kzzzzzzzzzzzzzzc_);
            string kzzzzzzzzzzzzzze_ = context.Operators.Convert<string>(kzzzzzzzzzzzzzzd_);
            string[] kzzzzzzzzzzzzzzf_ = [
                "order",
                "original-order",
                "reflex-order",
                "filler-order",
                "instance-order",
            ];
            bool? kzzzzzzzzzzzzzzg_ = context.Operators.In<string>(kzzzzzzzzzzzzzze_, kzzzzzzzzzzzzzzf_ as IEnumerable<string>);
            bool? kzzzzzzzzzzzzzzh_ = context.Operators.And(kzzzzzzzzzzzzzza_, kzzzzzzzzzzzzzzg_);
            FhirBoolean kzzzzzzzzzzzzzzi_ = HospiceOrder?.DoNotPerformElement;
            bool? kzzzzzzzzzzzzzzj_ = kzzzzzzzzzzzzzzi_?.Value;
            bool? kzzzzzzzzzzzzzzk_ = context.Operators.IsTrue(kzzzzzzzzzzzzzzj_);
            bool? kzzzzzzzzzzzzzzl_ = context.Operators.Not(kzzzzzzzzzzzzzzk_);
            bool? kzzzzzzzzzzzzzzm_ = context.Operators.And(kzzzzzzzzzzzzzzh_, kzzzzzzzzzzzzzzl_);

            return kzzzzzzzzzzzzzzm_;
        };
        IEnumerable<ServiceRequest> gzzzzzzzzzzzzzzf_ = context.Operators.Where<ServiceRequest>(gzzzzzzzzzzzzzzd_, gzzzzzzzzzzzzzze_);
        bool? gzzzzzzzzzzzzzzg_ = context.Operators.Exists<ServiceRequest>(gzzzzzzzzzzzzzzf_);
        bool? gzzzzzzzzzzzzzzh_ = context.Operators.Or(gzzzzzzzzzzzzzzb_, gzzzzzzzzzzzzzzg_);
        IEnumerable<Procedure> gzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, gzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        bool? gzzzzzzzzzzzzzzk_(Procedure HospicePerformed)
        {
            DataType kzzzzzzzzzzzzzzn_ = HospicePerformed?.Performed;
            object kzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzn_);
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.toInterval(context, kzzzzzzzzzzzzzzo_);
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzq_ = this.Denominator_Identification_Period(context);
            CqlDateTime kzzzzzzzzzzzzzzr_ = context.Operators.Start(kzzzzzzzzzzzzzzq_);
            CqlInterval<CqlDate> kzzzzzzzzzzzzzzs_ = this.Measure_Assessment_Period(context);
            CqlDate kzzzzzzzzzzzzzzt_ = context.Operators.End(kzzzzzzzzzzzzzzs_);
            CqlDateTime kzzzzzzzzzzzzzzu_ = context.Operators.ConvertDateToDateTime(kzzzzzzzzzzzzzzt_);
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzv_ = context.Operators.Interval(kzzzzzzzzzzzzzzr_, kzzzzzzzzzzzzzzu_, true, true);
            bool? kzzzzzzzzzzzzzzw_ = context.Operators.Overlaps(kzzzzzzzzzzzzzzp_, kzzzzzzzzzzzzzzv_, "day");
            Code<EventStatus> kzzzzzzzzzzzzzzx_ = HospicePerformed?.StatusElement;
            EventStatus? kzzzzzzzzzzzzzzy_ = kzzzzzzzzzzzzzzx_?.Value;
            string kzzzzzzzzzzzzzzz_ = context.Operators.Convert<string>(kzzzzzzzzzzzzzzy_);
            string[] lzzzzzzzzzzzzzza_ = [
                "not-done",
                "entered-in-error",
                "unknown",
            ];
            bool? lzzzzzzzzzzzzzzb_ = context.Operators.In<string>(kzzzzzzzzzzzzzzz_, lzzzzzzzzzzzzzza_ as IEnumerable<string>);
            bool? lzzzzzzzzzzzzzzc_ = context.Operators.Not(lzzzzzzzzzzzzzzb_);
            bool? lzzzzzzzzzzzzzzd_ = context.Operators.And(kzzzzzzzzzzzzzzw_, lzzzzzzzzzzzzzzc_);

            return lzzzzzzzzzzzzzzd_;
        };
        IEnumerable<Procedure> gzzzzzzzzzzzzzzl_ = context.Operators.Where<Procedure>(gzzzzzzzzzzzzzzj_, gzzzzzzzzzzzzzzk_);
        bool? gzzzzzzzzzzzzzzm_ = context.Operators.Exists<Procedure>(gzzzzzzzzzzzzzzl_);
        bool? gzzzzzzzzzzzzzzn_ = context.Operators.Or(gzzzzzzzzzzzzzzh_, gzzzzzzzzzzzzzzm_);
        CqlValueSet gzzzzzzzzzzzzzzo_ = this.Hospice_Diagnosis(context);
        IEnumerable<Condition> gzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, gzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? gzzzzzzzzzzzzzzq_(Condition HospiceCareDiagnosis)
        {
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, HospiceCareDiagnosis);
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzf_ = this.Denominator_Identification_Period(context);
            CqlDateTime lzzzzzzzzzzzzzzg_ = context.Operators.Start(lzzzzzzzzzzzzzzf_);
            CqlInterval<CqlDate> lzzzzzzzzzzzzzzh_ = this.Measure_Assessment_Period(context);
            CqlDate lzzzzzzzzzzzzzzi_ = context.Operators.End(lzzzzzzzzzzzzzzh_);
            CqlDateTime lzzzzzzzzzzzzzzj_ = context.Operators.ConvertDateToDateTime(lzzzzzzzzzzzzzzi_);
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzk_ = context.Operators.Interval(lzzzzzzzzzzzzzzg_, lzzzzzzzzzzzzzzj_, true, true);
            bool? lzzzzzzzzzzzzzzl_ = context.Operators.Overlaps(lzzzzzzzzzzzzzze_, lzzzzzzzzzzzzzzk_, "day");
            bool? lzzzzzzzzzzzzzzm_ = this.isConfirmedActiveDiagnosis(context, HospiceCareDiagnosis);
            bool? lzzzzzzzzzzzzzzn_ = context.Operators.And(lzzzzzzzzzzzzzzl_, lzzzzzzzzzzzzzzm_);

            return lzzzzzzzzzzzzzzn_;
        };
        IEnumerable<Condition> gzzzzzzzzzzzzzzr_ = context.Operators.Where<Condition>(gzzzzzzzzzzzzzzp_, gzzzzzzzzzzzzzzq_);
        bool? gzzzzzzzzzzzzzzs_ = context.Operators.Exists<Condition>(gzzzzzzzzzzzzzzr_);
        bool? gzzzzzzzzzzzzzzt_ = context.Operators.Or(gzzzzzzzzzzzzzzn_, gzzzzzzzzzzzzzzs_);

        return gzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has Palliative Care in the Measure Assessment Period")]
    public bool? Has_Palliative_Care_in_the_Measure_Assessment_Period(CqlContext context)
    {
        CqlCode lzzzzzzzzzzzzzzo_ = this.Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal_(context);
        IEnumerable<CqlCode> lzzzzzzzzzzzzzzp_ = context.Operators.ToList<CqlCode>(lzzzzzzzzzzzzzzo_);
        IEnumerable<Observation> lzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, lzzzzzzzzzzzzzzp_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? lzzzzzzzzzzzzzzr_(Observation PalliativeAssessment)
        {
            DataType mzzzzzzzzzzzzzzm_ = PalliativeAssessment?.Effective;
            object mzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzm_);
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.toInterval(context, mzzzzzzzzzzzzzzn_);
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzp_ = this.Denominator_Identification_Period(context);
            CqlDateTime mzzzzzzzzzzzzzzq_ = context.Operators.Start(mzzzzzzzzzzzzzzp_);
            CqlInterval<CqlDate> mzzzzzzzzzzzzzzr_ = this.Measure_Assessment_Period(context);
            CqlDate mzzzzzzzzzzzzzzs_ = context.Operators.End(mzzzzzzzzzzzzzzr_);
            CqlDateTime mzzzzzzzzzzzzzzt_ = context.Operators.ConvertDateToDateTime(mzzzzzzzzzzzzzzs_);
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzu_ = context.Operators.Interval(mzzzzzzzzzzzzzzq_, mzzzzzzzzzzzzzzt_, true, true);
            bool? mzzzzzzzzzzzzzzv_ = context.Operators.Overlaps(mzzzzzzzzzzzzzzo_, mzzzzzzzzzzzzzzu_, default);
            Code<ObservationStatus> mzzzzzzzzzzzzzzw_ = PalliativeAssessment?.StatusElement;
            ObservationStatus? mzzzzzzzzzzzzzzx_ = mzzzzzzzzzzzzzzw_?.Value;
            Code<ObservationStatus> mzzzzzzzzzzzzzzy_ = context.Operators.Convert<Code<ObservationStatus>>(mzzzzzzzzzzzzzzx_);
            string mzzzzzzzzzzzzzzz_ = context.Operators.Convert<string>(mzzzzzzzzzzzzzzy_);
            string[] nzzzzzzzzzzzzzza_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? nzzzzzzzzzzzzzzb_ = context.Operators.In<string>(mzzzzzzzzzzzzzzz_, nzzzzzzzzzzzzzza_ as IEnumerable<string>);
            bool? nzzzzzzzzzzzzzzc_ = context.Operators.And(mzzzzzzzzzzzzzzv_, nzzzzzzzzzzzzzzb_);

            return nzzzzzzzzzzzzzzc_;
        };
        IEnumerable<Observation> lzzzzzzzzzzzzzzs_ = context.Operators.Where<Observation>(lzzzzzzzzzzzzzzq_, lzzzzzzzzzzzzzzr_);
        bool? lzzzzzzzzzzzzzzt_ = context.Operators.Exists<Observation>(lzzzzzzzzzzzzzzs_);
        CqlValueSet lzzzzzzzzzzzzzzu_ = this.Palliative_Care_Diagnosis(context);
        IEnumerable<Condition> lzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, lzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? lzzzzzzzzzzzzzzw_(Condition PalliativeDiagnosis)
        {
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, PalliativeDiagnosis);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzze_ = this.Denominator_Identification_Period(context);
            CqlDateTime nzzzzzzzzzzzzzzf_ = context.Operators.Start(nzzzzzzzzzzzzzze_);
            CqlInterval<CqlDate> nzzzzzzzzzzzzzzg_ = this.Measure_Assessment_Period(context);
            CqlDate nzzzzzzzzzzzzzzh_ = context.Operators.End(nzzzzzzzzzzzzzzg_);
            CqlDateTime nzzzzzzzzzzzzzzi_ = context.Operators.ConvertDateToDateTime(nzzzzzzzzzzzzzzh_);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzj_ = context.Operators.Interval(nzzzzzzzzzzzzzzf_, nzzzzzzzzzzzzzzi_, true, true);
            bool? nzzzzzzzzzzzzzzk_ = context.Operators.Overlaps(nzzzzzzzzzzzzzzd_, nzzzzzzzzzzzzzzj_, default);
            bool? nzzzzzzzzzzzzzzl_ = this.isConfirmedActiveDiagnosis(context, PalliativeDiagnosis);
            bool? nzzzzzzzzzzzzzzm_ = context.Operators.And(nzzzzzzzzzzzzzzk_, nzzzzzzzzzzzzzzl_);

            return nzzzzzzzzzzzzzzm_;
        };
        IEnumerable<Condition> lzzzzzzzzzzzzzzx_ = context.Operators.Where<Condition>(lzzzzzzzzzzzzzzv_, lzzzzzzzzzzzzzzw_);
        bool? lzzzzzzzzzzzzzzy_ = context.Operators.Exists<Condition>(lzzzzzzzzzzzzzzx_);
        bool? lzzzzzzzzzzzzzzz_ = context.Operators.Or(lzzzzzzzzzzzzzzt_, lzzzzzzzzzzzzzzy_);
        CqlValueSet mzzzzzzzzzzzzzza_ = this.Palliative_Care_Encounter(context);
        IEnumerable<Encounter> mzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, mzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? mzzzzzzzzzzzzzzc_(Encounter PalliativeEncounter)
        {
            Period nzzzzzzzzzzzzzzn_ = PalliativeEncounter?.Period;
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzzzzzzzzzzn_);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzp_ = this.Denominator_Identification_Period(context);
            CqlDateTime nzzzzzzzzzzzzzzq_ = context.Operators.Start(nzzzzzzzzzzzzzzp_);
            CqlInterval<CqlDate> nzzzzzzzzzzzzzzr_ = this.Measure_Assessment_Period(context);
            CqlDate nzzzzzzzzzzzzzzs_ = context.Operators.End(nzzzzzzzzzzzzzzr_);
            CqlDateTime nzzzzzzzzzzzzzzt_ = context.Operators.ConvertDateToDateTime(nzzzzzzzzzzzzzzs_);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzu_ = context.Operators.Interval(nzzzzzzzzzzzzzzq_, nzzzzzzzzzzzzzzt_, true, true);
            bool? nzzzzzzzzzzzzzzv_ = context.Operators.Overlaps(nzzzzzzzzzzzzzzo_, nzzzzzzzzzzzzzzu_, default);
            Code<Encounter.EncounterStatus> nzzzzzzzzzzzzzzw_ = PalliativeEncounter?.StatusElement;
            Encounter.EncounterStatus? nzzzzzzzzzzzzzzx_ = nzzzzzzzzzzzzzzw_?.Value;
            Code<Encounter.EncounterStatus> nzzzzzzzzzzzzzzy_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(nzzzzzzzzzzzzzzx_);
            bool? nzzzzzzzzzzzzzzz_ = context.Operators.Equal(nzzzzzzzzzzzzzzy_, "finished");
            bool? ozzzzzzzzzzzzzza_ = context.Operators.And(nzzzzzzzzzzzzzzv_, nzzzzzzzzzzzzzzz_);

            return ozzzzzzzzzzzzzza_;
        };
        IEnumerable<Encounter> mzzzzzzzzzzzzzzd_ = context.Operators.Where<Encounter>(mzzzzzzzzzzzzzzb_, mzzzzzzzzzzzzzzc_);
        bool? mzzzzzzzzzzzzzze_ = context.Operators.Exists<Encounter>(mzzzzzzzzzzzzzzd_);
        bool? mzzzzzzzzzzzzzzf_ = context.Operators.Or(lzzzzzzzzzzzzzzz_, mzzzzzzzzzzzzzze_);
        CqlValueSet mzzzzzzzzzzzzzzg_ = this.Palliative_Care_Intervention(context);
        IEnumerable<Procedure> mzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, mzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        bool? mzzzzzzzzzzzzzzi_(Procedure PalliativeIntervention)
        {
            DataType ozzzzzzzzzzzzzzb_ = PalliativeIntervention?.Performed;
            object ozzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzb_);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.toInterval(context, ozzzzzzzzzzzzzzc_);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzze_ = this.Denominator_Identification_Period(context);
            CqlDateTime ozzzzzzzzzzzzzzf_ = context.Operators.Start(ozzzzzzzzzzzzzze_);
            CqlInterval<CqlDate> ozzzzzzzzzzzzzzg_ = this.Measure_Assessment_Period(context);
            CqlDate ozzzzzzzzzzzzzzh_ = context.Operators.End(ozzzzzzzzzzzzzzg_);
            CqlDateTime ozzzzzzzzzzzzzzi_ = context.Operators.ConvertDateToDateTime(ozzzzzzzzzzzzzzh_);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzj_ = context.Operators.Interval(ozzzzzzzzzzzzzzf_, ozzzzzzzzzzzzzzi_, true, true);
            bool? ozzzzzzzzzzzzzzk_ = context.Operators.Overlaps(ozzzzzzzzzzzzzzd_, ozzzzzzzzzzzzzzj_, default);
            Code<EventStatus> ozzzzzzzzzzzzzzl_ = PalliativeIntervention?.StatusElement;
            EventStatus? ozzzzzzzzzzzzzzm_ = ozzzzzzzzzzzzzzl_?.Value;
            string ozzzzzzzzzzzzzzn_ = context.Operators.Convert<string>(ozzzzzzzzzzzzzzm_);
            string[] ozzzzzzzzzzzzzzo_ = [
                "not-done",
                "entered-in-error",
                "unknown",
            ];
            bool? ozzzzzzzzzzzzzzp_ = context.Operators.In<string>(ozzzzzzzzzzzzzzn_, ozzzzzzzzzzzzzzo_ as IEnumerable<string>);
            bool? ozzzzzzzzzzzzzzq_ = context.Operators.Not(ozzzzzzzzzzzzzzp_);
            bool? ozzzzzzzzzzzzzzr_ = context.Operators.And(ozzzzzzzzzzzzzzk_, ozzzzzzzzzzzzzzq_);

            return ozzzzzzzzzzzzzzr_;
        };
        IEnumerable<Procedure> mzzzzzzzzzzzzzzj_ = context.Operators.Where<Procedure>(mzzzzzzzzzzzzzzh_, mzzzzzzzzzzzzzzi_);
        bool? mzzzzzzzzzzzzzzk_ = context.Operators.Exists<Procedure>(mzzzzzzzzzzzzzzj_);
        bool? mzzzzzzzzzzzzzzl_ = context.Operators.Or(mzzzzzzzzzzzzzzf_, mzzzzzzzzzzzzzzk_);

        return mzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition(
        definitionName: "Patient Expired")]
    public bool? Patient_Expired(CqlContext context)
    {
        Patient ozzzzzzzzzzzzzzs_ = this.Patient(context);
        DataType ozzzzzzzzzzzzzzt_ = ozzzzzzzzzzzzzzs_?.Deceased;
        object ozzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzt_);
        CqlInterval<CqlDate> ozzzzzzzzzzzzzzv_ = this.Measure_Assessment_Period(context);
        CqlDate ozzzzzzzzzzzzzzw_ = context.Operators.End(ozzzzzzzzzzzzzzv_);
        CqlDateTime ozzzzzzzzzzzzzzx_ = context.Operators.ConvertDateToDateTime(ozzzzzzzzzzzzzzw_);
        bool? ozzzzzzzzzzzzzzy_ = context.Operators.SameOrBefore(ozzzzzzzzzzzzzzu_ as CqlDateTime, ozzzzzzzzzzzzzzx_, default);

        return ozzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has Mental Health Disorder Diagnoses")]
    public bool? Has_Mental_Health_Disorder_Diagnoses(CqlContext context)
    {
        CqlValueSet ozzzzzzzzzzzzzzz_ = this.Bipolar_Disorder(context);
        IEnumerable<Condition> pzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ozzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet pzzzzzzzzzzzzzzb_ = this.Personality_Disorder_Emotionally_Labile(context);
        IEnumerable<Condition> pzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, pzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> pzzzzzzzzzzzzzzd_ = context.Operators.Union<Condition>(pzzzzzzzzzzzzzza_, pzzzzzzzzzzzzzzc_);
        CqlValueSet pzzzzzzzzzzzzzze_ = this.Schizophrenia_or_Psychotic_Disorder(context);
        IEnumerable<Condition> pzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, pzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet pzzzzzzzzzzzzzzg_ = this.Pervasive_Developmental_Disorder(context);
        IEnumerable<Condition> pzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, pzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> pzzzzzzzzzzzzzzi_ = context.Operators.Union<Condition>(pzzzzzzzzzzzzzzf_, pzzzzzzzzzzzzzzh_);
        IEnumerable<Condition> pzzzzzzzzzzzzzzj_ = context.Operators.Union<Condition>(pzzzzzzzzzzzzzzd_, pzzzzzzzzzzzzzzi_);
        bool? pzzzzzzzzzzzzzzk_(Condition MentalHealthDisorderDiagnoses)
        {
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, MentalHealthDisorderDiagnoses);
            CqlDateTime pzzzzzzzzzzzzzzo_ = context.Operators.Start(pzzzzzzzzzzzzzzn_);
            CqlDate pzzzzzzzzzzzzzzp_ = context.Operators.ConvertDateTimeToDate(pzzzzzzzzzzzzzzo_);
            CqlInterval<CqlDate> pzzzzzzzzzzzzzzq_ = this.Measure_Assessment_Period(context);
            CqlDate pzzzzzzzzzzzzzzr_ = context.Operators.End(pzzzzzzzzzzzzzzq_);
            bool? pzzzzzzzzzzzzzzs_ = context.Operators.SameOrBefore(pzzzzzzzzzzzzzzp_, pzzzzzzzzzzzzzzr_, default);
            bool? pzzzzzzzzzzzzzzt_ = this.isConfirmedActiveDiagnosis(context, MentalHealthDisorderDiagnoses);
            bool? pzzzzzzzzzzzzzzu_ = context.Operators.And(pzzzzzzzzzzzzzzs_, pzzzzzzzzzzzzzzt_);

            return pzzzzzzzzzzzzzzu_;
        };
        IEnumerable<Condition> pzzzzzzzzzzzzzzl_ = context.Operators.Where<Condition>(pzzzzzzzzzzzzzzj_, pzzzzzzzzzzzzzzk_);
        bool? pzzzzzzzzzzzzzzm_ = context.Operators.Exists<Condition>(pzzzzzzzzzzzzzzl_);

        return pzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? pzzzzzzzzzzzzzzv_ = this.Has_Hospice_Services_in_the_Measure_Assessment_Period(context);
        bool? pzzzzzzzzzzzzzzw_ = this.Has_Palliative_Care_in_the_Measure_Assessment_Period(context);
        bool? pzzzzzzzzzzzzzzx_ = context.Operators.Or(pzzzzzzzzzzzzzzv_, pzzzzzzzzzzzzzzw_);
        bool? pzzzzzzzzzzzzzzy_ = this.Patient_Expired(context);
        bool? pzzzzzzzzzzzzzzz_ = context.Operators.Or(pzzzzzzzzzzzzzzx_, pzzzzzzzzzzzzzzy_);
        bool? qzzzzzzzzzzzzzza_ = this.Has_Mental_Health_Disorder_Diagnoses(context);
        bool? qzzzzzzzzzzzzzzb_ = context.Operators.Or(pzzzzzzzzzzzzzzz_, qzzzzzzzzzzzzzza_);

        return qzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition(
        definitionName: "Numerator")]
    public bool? Numerator(CqlContext context)
    {
        CqlValueSet qzzzzzzzzzzzzzzc_ = this.PHQ_9_and_PHQ_9M_Tools(context);
        IEnumerable<Observation> qzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, qzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? qzzzzzzzzzzzzzze_(Observation DepressionAssessment)
        {
            DataType qzzzzzzzzzzzzzzm_ = DepressionAssessment?.Effective;
            object qzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzm_);
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.toInterval(context, qzzzzzzzzzzzzzzn_);
            CqlDateTime qzzzzzzzzzzzzzzp_ = context.Operators.Start(qzzzzzzzzzzzzzzo_);
            CqlDate qzzzzzzzzzzzzzzq_ = context.Operators.ConvertDateTimeToDate(qzzzzzzzzzzzzzzp_);
            CqlInterval<CqlDate> qzzzzzzzzzzzzzzr_ = this.Measure_Assessment_Period(context);
            bool? qzzzzzzzzzzzzzzs_ = context.Operators.In<CqlDate>(qzzzzzzzzzzzzzzq_, qzzzzzzzzzzzzzzr_, default);
            Code<ObservationStatus> qzzzzzzzzzzzzzzt_ = DepressionAssessment?.StatusElement;
            ObservationStatus? qzzzzzzzzzzzzzzu_ = qzzzzzzzzzzzzzzt_?.Value;
            Code<ObservationStatus> qzzzzzzzzzzzzzzv_ = context.Operators.Convert<Code<ObservationStatus>>(qzzzzzzzzzzzzzzu_);
            string qzzzzzzzzzzzzzzw_ = context.Operators.Convert<string>(qzzzzzzzzzzzzzzv_);
            string[] qzzzzzzzzzzzzzzx_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? qzzzzzzzzzzzzzzy_ = context.Operators.In<string>(qzzzzzzzzzzzzzzw_, qzzzzzzzzzzzzzzx_ as IEnumerable<string>);
            bool? qzzzzzzzzzzzzzzz_ = context.Operators.And(qzzzzzzzzzzzzzzs_, qzzzzzzzzzzzzzzy_);

            return qzzzzzzzzzzzzzzz_;
        };
        IEnumerable<Observation> qzzzzzzzzzzzzzzf_ = context.Operators.Where<Observation>(qzzzzzzzzzzzzzzd_, qzzzzzzzzzzzzzze_);
        object qzzzzzzzzzzzzzzg_(Observation @this)
        {
            DataType rzzzzzzzzzzzzzza_ = @this?.Effective;
            object rzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzza_);
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.toInterval(context, rzzzzzzzzzzzzzzb_);
            CqlDateTime rzzzzzzzzzzzzzzd_ = context.Operators.Start(rzzzzzzzzzzzzzzc_);

            return rzzzzzzzzzzzzzzd_;
        };
        IEnumerable<Observation> qzzzzzzzzzzzzzzh_ = context.Operators.SortBy<Observation>(qzzzzzzzzzzzzzzf_, qzzzzzzzzzzzzzzg_, System.ComponentModel.ListSortDirection.Ascending);
        Observation qzzzzzzzzzzzzzzi_ = context.Operators.Last<Observation>(qzzzzzzzzzzzzzzh_);
        DataType qzzzzzzzzzzzzzzj_ = qzzzzzzzzzzzzzzi_?.Value;
        object qzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzj_);
        bool? qzzzzzzzzzzzzzzl_ = context.Operators.Less(qzzzzzzzzzzzzzzk_ as int?, 5);

        return qzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? rzzzzzzzzzzzzzze_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return rzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> rzzzzzzzzzzzzzzf_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return rzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? rzzzzzzzzzzzzzzg_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return rzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode rzzzzzzzzzzzzzzh_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return rzzzzzzzzzzzzzzh_;
    }


    #endregion Expressions

}
