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
        CqlDateTime izzzzzzzzzzzzt_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime izzzzzzzzzzzzu_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> izzzzzzzzzzzzv_ = context.Operators.Interval(izzzzzzzzzzzzt_, izzzzzzzzzzzzu_, true, true);
        object izzzzzzzzzzzzw_ = context.ResolveParameter("DepressionRemissionatTwelveMonthsFHIR-0.2.000", "Measurement Period", izzzzzzzzzzzzv_);

        return (CqlInterval<CqlDateTime>)izzzzzzzzzzzzw_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> izzzzzzzzzzzzx_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient izzzzzzzzzzzzy_ = context.Operators.SingletonFrom<Patient>(izzzzzzzzzzzzx_);

        return izzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Depression Assessments Greater than 9")]
    public IEnumerable<Observation> Depression_Assessments_Greater_than_9(CqlContext context)
    {
        CqlValueSet izzzzzzzzzzzzz_ = this.PHQ_9_and_PHQ_9M_Tools(context);
        IEnumerable<Observation> jzzzzzzzzzzzza_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, izzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? jzzzzzzzzzzzzb_(Observation DepressionAssessment)
        {
            DataType jzzzzzzzzzzzzd_ = DepressionAssessment?.Value;
            object jzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzd_);
            bool? jzzzzzzzzzzzzf_ = context.Operators.Greater(jzzzzzzzzzzzze_ as int?, 9);
            Code<ObservationStatus> jzzzzzzzzzzzzg_ = DepressionAssessment?.StatusElement;
            ObservationStatus? jzzzzzzzzzzzzh_ = jzzzzzzzzzzzzg_?.Value;
            Code<ObservationStatus> jzzzzzzzzzzzzi_ = context.Operators.Convert<Code<ObservationStatus>>(jzzzzzzzzzzzzh_);
            string jzzzzzzzzzzzzj_ = context.Operators.Convert<string>(jzzzzzzzzzzzzi_);
            string[] jzzzzzzzzzzzzk_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? jzzzzzzzzzzzzl_ = context.Operators.In<string>(jzzzzzzzzzzzzj_, jzzzzzzzzzzzzk_ as IEnumerable<string>);
            bool? jzzzzzzzzzzzzm_ = context.Operators.And(jzzzzzzzzzzzzf_, jzzzzzzzzzzzzl_);

            return jzzzzzzzzzzzzm_;
        };
        IEnumerable<Observation> jzzzzzzzzzzzzc_ = context.Operators.Where<Observation>(jzzzzzzzzzzzza_, jzzzzzzzzzzzzb_);

        return jzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("isConfirmedActiveDiagnosis")]
    public bool? isConfirmedActiveDiagnosis(CqlContext context, Condition condition)
    {
        bool? jzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.isActive(context, condition);
        CodeableConcept jzzzzzzzzzzzzo_ = condition?.VerificationStatus;
        CqlConcept jzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, jzzzzzzzzzzzzo_);
        CqlCode jzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.confirmed(context);
        CqlConcept jzzzzzzzzzzzzr_ = context.Operators.ConvertCodeToConcept(jzzzzzzzzzzzzq_);
        bool? jzzzzzzzzzzzzs_ = context.Operators.Equivalent(jzzzzzzzzzzzzp_, jzzzzzzzzzzzzr_);
        bool? jzzzzzzzzzzzzt_ = context.Operators.And(jzzzzzzzzzzzzn_, jzzzzzzzzzzzzs_);

        return jzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Depression Diagnoses")]
    public IEnumerable<Condition> Depression_Diagnoses(CqlContext context)
    {
        CqlValueSet jzzzzzzzzzzzzu_ = this.Major_Depression_Including_Remission(context);
        IEnumerable<Condition> jzzzzzzzzzzzzv_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, jzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet jzzzzzzzzzzzzw_ = this.Dysthymia(context);
        IEnumerable<Condition> jzzzzzzzzzzzzx_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, jzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> jzzzzzzzzzzzzy_ = context.Operators.Union<Condition>(jzzzzzzzzzzzzv_, jzzzzzzzzzzzzx_);
        bool? jzzzzzzzzzzzzz_(Condition Depression)
        {
            bool? kzzzzzzzzzzzzb_ = this.isConfirmedActiveDiagnosis(context, Depression);

            return kzzzzzzzzzzzzb_;
        };
        IEnumerable<Condition> kzzzzzzzzzzzza_ = context.Operators.Where<Condition>(jzzzzzzzzzzzzy_, jzzzzzzzzzzzzz_);

        return kzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Denominator Identification Period")]
    public CqlInterval<CqlDateTime> Denominator_Identification_Period(CqlContext context)
    {
        CqlInterval<CqlDateTime> kzzzzzzzzzzzzc_ = this.Measurement_Period(context);
        CqlDateTime kzzzzzzzzzzzzd_ = context.Operators.Start(kzzzzzzzzzzzzc_);
        CqlQuantity kzzzzzzzzzzzze_ = context.Operators.Quantity(14m, "months");
        CqlDateTime kzzzzzzzzzzzzf_ = context.Operators.Subtract(kzzzzzzzzzzzzd_, kzzzzzzzzzzzze_);
        CqlDateTime kzzzzzzzzzzzzh_ = context.Operators.Start(kzzzzzzzzzzzzc_);
        CqlQuantity kzzzzzzzzzzzzi_ = context.Operators.Quantity(2m, "months");
        CqlDateTime kzzzzzzzzzzzzj_ = context.Operators.Subtract(kzzzzzzzzzzzzh_, kzzzzzzzzzzzzi_);
        CqlInterval<CqlDateTime> kzzzzzzzzzzzzk_ = context.Operators.Interval(kzzzzzzzzzzzzf_, kzzzzzzzzzzzzj_, true, false);

        return kzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Depression Encounter")]
    public IEnumerable<Encounter> Depression_Encounter(CqlContext context)
    {
        CqlValueSet kzzzzzzzzzzzzl_ = this.Contact_or_Office_Visit(context);
        IEnumerable<Encounter> kzzzzzzzzzzzzm_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, kzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> kzzzzzzzzzzzzn_(Encounter ValidEncounter)
        {
            IEnumerable<Condition> kzzzzzzzzzzzzp_ = this.Depression_Diagnoses(context);
            bool? kzzzzzzzzzzzzq_(Condition Depression)
            {
                Period kzzzzzzzzzzzzu_ = ValidEncounter?.Period;
                CqlInterval<CqlDateTime> kzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzzzzzzzzu_);
                CqlInterval<CqlDateTime> kzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, Depression);
                bool? kzzzzzzzzzzzzx_ = context.Operators.Overlaps(kzzzzzzzzzzzzv_, kzzzzzzzzzzzzw_, default);
                CqlInterval<CqlDateTime> kzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzzzzzzzzu_);
                CqlDateTime lzzzzzzzzzzzza_ = context.Operators.End(kzzzzzzzzzzzzz_);
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzb_ = this.Denominator_Identification_Period(context);
                bool? lzzzzzzzzzzzzc_ = context.Operators.In<CqlDateTime>(lzzzzzzzzzzzza_, lzzzzzzzzzzzzb_, default);
                bool? lzzzzzzzzzzzzd_ = context.Operators.And(kzzzzzzzzzzzzx_, lzzzzzzzzzzzzc_);
                Code<Encounter.EncounterStatus> lzzzzzzzzzzzze_ = ValidEncounter?.StatusElement;
                Encounter.EncounterStatus? lzzzzzzzzzzzzf_ = lzzzzzzzzzzzze_?.Value;
                Code<Encounter.EncounterStatus> lzzzzzzzzzzzzg_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(lzzzzzzzzzzzzf_);
                bool? lzzzzzzzzzzzzh_ = context.Operators.Equal(lzzzzzzzzzzzzg_, "finished");
                bool? lzzzzzzzzzzzzi_ = context.Operators.And(lzzzzzzzzzzzzd_, lzzzzzzzzzzzzh_);

                return lzzzzzzzzzzzzi_;
            };
            IEnumerable<Condition> kzzzzzzzzzzzzr_ = context.Operators.Where<Condition>(kzzzzzzzzzzzzp_, kzzzzzzzzzzzzq_);
            Encounter kzzzzzzzzzzzzs_(Condition Depression) =>
                ValidEncounter;
            IEnumerable<Encounter> kzzzzzzzzzzzzt_ = context.Operators.Select<Condition, Encounter>(kzzzzzzzzzzzzr_, kzzzzzzzzzzzzs_);

            return kzzzzzzzzzzzzt_;
        };
        IEnumerable<Encounter> kzzzzzzzzzzzzo_ = context.Operators.SelectMany<Encounter, Encounter>(kzzzzzzzzzzzzm_, kzzzzzzzzzzzzn_);

        return kzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Index Depression Assessment")]
    public Observation Index_Depression_Assessment(CqlContext context)
    {
        IEnumerable<Observation> lzzzzzzzzzzzzj_ = this.Depression_Assessments_Greater_than_9(context);
        IEnumerable<Observation> lzzzzzzzzzzzzk_(Observation DepressionAssessment)
        {
            IEnumerable<Encounter> lzzzzzzzzzzzzp_ = this.Depression_Encounter(context);
            bool? lzzzzzzzzzzzzq_(Encounter DepressionEncounter)
            {
                Period lzzzzzzzzzzzzu_ = DepressionEncounter?.Period;
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzzzzzzzu_);
                CqlDateTime lzzzzzzzzzzzzw_ = context.Operators.Start(lzzzzzzzzzzzzv_);
                CqlQuantity lzzzzzzzzzzzzx_ = context.Operators.Quantity(7m, "days");
                CqlDateTime lzzzzzzzzzzzzy_ = context.Operators.Subtract(lzzzzzzzzzzzzw_, lzzzzzzzzzzzzx_);
                CqlDate lzzzzzzzzzzzzz_ = context.Operators.ConvertDateTimeToDate(lzzzzzzzzzzzzy_);
                CqlDateTime mzzzzzzzzzzzza_ = context.Operators.ConvertDateToDateTime(lzzzzzzzzzzzzz_);
                CqlInterval<CqlDateTime> mzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzzzzzzzu_);
                CqlDateTime mzzzzzzzzzzzzd_ = context.Operators.End(mzzzzzzzzzzzzc_);
                CqlInterval<CqlDateTime> mzzzzzzzzzzzze_ = context.Operators.Interval(mzzzzzzzzzzzza_, mzzzzzzzzzzzzd_, true, true);
                DataType mzzzzzzzzzzzzf_ = DepressionAssessment?.Effective;
                object mzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzf_);
                CqlInterval<CqlDateTime> mzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.toInterval(context, mzzzzzzzzzzzzg_);
                bool? mzzzzzzzzzzzzi_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(mzzzzzzzzzzzze_, mzzzzzzzzzzzzh_, "day");

                return mzzzzzzzzzzzzi_;
            };
            IEnumerable<Encounter> lzzzzzzzzzzzzr_ = context.Operators.Where<Encounter>(lzzzzzzzzzzzzp_, lzzzzzzzzzzzzq_);
            Observation lzzzzzzzzzzzzs_(Encounter DepressionEncounter) =>
                DepressionAssessment;
            IEnumerable<Observation> lzzzzzzzzzzzzt_ = context.Operators.Select<Encounter, Observation>(lzzzzzzzzzzzzr_, lzzzzzzzzzzzzs_);

            return lzzzzzzzzzzzzt_;
        };
        IEnumerable<Observation> lzzzzzzzzzzzzl_ = context.Operators.SelectMany<Observation, Observation>(lzzzzzzzzzzzzj_, lzzzzzzzzzzzzk_);
        object lzzzzzzzzzzzzm_(Observation @this)
        {
            DataType mzzzzzzzzzzzzj_ = @this?.Effective;
            object mzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzj_);
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.toInterval(context, mzzzzzzzzzzzzk_);
            CqlDateTime mzzzzzzzzzzzzm_ = context.Operators.Start(mzzzzzzzzzzzzl_);

            return mzzzzzzzzzzzzm_;
        };
        IEnumerable<Observation> lzzzzzzzzzzzzn_ = context.Operators.SortBy<Observation>(lzzzzzzzzzzzzl_, lzzzzzzzzzzzzm_, System.ComponentModel.ListSortDirection.Ascending);
        Observation lzzzzzzzzzzzzo_ = context.Operators.First<Observation>(lzzzzzzzzzzzzn_);

        return lzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient mzzzzzzzzzzzzn_ = this.Patient(context);
        Date mzzzzzzzzzzzzo_ = mzzzzzzzzzzzzn_?.BirthDateElement;
        string mzzzzzzzzzzzzp_ = mzzzzzzzzzzzzo_?.Value;
        CqlDateTime mzzzzzzzzzzzzq_ = context.Operators.ConvertStringToDateTime(mzzzzzzzzzzzzp_);
        Observation mzzzzzzzzzzzzr_ = this.Index_Depression_Assessment(context);
        DataType mzzzzzzzzzzzzs_ = mzzzzzzzzzzzzr_?.Effective;
        object mzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzs_);
        CqlInterval<CqlDateTime> mzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.toInterval(context, mzzzzzzzzzzzzt_);
        CqlDateTime mzzzzzzzzzzzzv_ = context.Operators.Start(mzzzzzzzzzzzzu_);
        int? mzzzzzzzzzzzzw_ = context.Operators.CalculateAgeAt(mzzzzzzzzzzzzq_, mzzzzzzzzzzzzv_, "year");
        bool? mzzzzzzzzzzzzx_ = context.Operators.GreaterOrEqual(mzzzzzzzzzzzzw_, 12);

        return mzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? mzzzzzzzzzzzzy_ = this.Initial_Population(context);

        return mzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Measure Assessment Period")]
    public CqlInterval<CqlDate> Measure_Assessment_Period(CqlContext context)
    {
        Observation mzzzzzzzzzzzzz_ = this.Index_Depression_Assessment(context);
        Observation[] nzzzzzzzzzzzza_ = [
            mzzzzzzzzzzzzz_,
        ];
        CqlInterval<CqlDate> nzzzzzzzzzzzzb_(Observation FirstIndexAssessment)
        {
            DataType nzzzzzzzzzzzzf_ = FirstIndexAssessment?.Effective;
            object nzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzf_);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.toInterval(context, nzzzzzzzzzzzzg_);
            CqlDateTime nzzzzzzzzzzzzi_ = context.Operators.Start(nzzzzzzzzzzzzh_);
            CqlDate nzzzzzzzzzzzzj_ = context.Operators.DateFrom(nzzzzzzzzzzzzi_);
            CqlQuantity nzzzzzzzzzzzzk_ = context.Operators.Quantity(12m, "months");
            CqlDate nzzzzzzzzzzzzl_ = context.Operators.Add(nzzzzzzzzzzzzj_, nzzzzzzzzzzzzk_);
            CqlQuantity nzzzzzzzzzzzzm_ = context.Operators.Quantity(60m, "days");
            CqlDate nzzzzzzzzzzzzn_ = context.Operators.Subtract(nzzzzzzzzzzzzl_, nzzzzzzzzzzzzm_);
            object nzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzf_);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.toInterval(context, nzzzzzzzzzzzzp_);
            CqlDateTime nzzzzzzzzzzzzr_ = context.Operators.Start(nzzzzzzzzzzzzq_);
            CqlDate nzzzzzzzzzzzzs_ = context.Operators.DateFrom(nzzzzzzzzzzzzr_);
            CqlDate nzzzzzzzzzzzzu_ = context.Operators.Add(nzzzzzzzzzzzzs_, nzzzzzzzzzzzzk_);
            CqlDate nzzzzzzzzzzzzw_ = context.Operators.Add(nzzzzzzzzzzzzu_, nzzzzzzzzzzzzm_);
            CqlInterval<CqlDate> nzzzzzzzzzzzzx_ = context.Operators.Interval(nzzzzzzzzzzzzn_, nzzzzzzzzzzzzw_, true, true);

            return nzzzzzzzzzzzzx_;
        };
        IEnumerable<CqlInterval<CqlDate>> nzzzzzzzzzzzzc_ = context.Operators.Select<Observation, CqlInterval<CqlDate>>((IEnumerable<Observation>)nzzzzzzzzzzzza_, nzzzzzzzzzzzzb_);
        IEnumerable<CqlInterval<CqlDate>> nzzzzzzzzzzzzd_ = context.Operators.Distinct<CqlInterval<CqlDate>>(nzzzzzzzzzzzzc_);
        CqlInterval<CqlDate> nzzzzzzzzzzzze_ = context.Operators.SingletonFrom<CqlInterval<CqlDate>>(nzzzzzzzzzzzzd_);

        return nzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Has Hospice Services in the Measure Assessment Period")]
    public bool? Has_Hospice_Services_in_the_Measure_Assessment_Period(CqlContext context)
    {
        CqlValueSet nzzzzzzzzzzzzy_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter> nzzzzzzzzzzzzz_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, nzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? ozzzzzzzzzzzza_(Encounter InpatientEncounter)
        {
            Encounter.HospitalizationComponent pzzzzzzzzzzzzi_ = InpatientEncounter?.Hospitalization;
            CodeableConcept pzzzzzzzzzzzzj_ = pzzzzzzzzzzzzi_?.DischargeDisposition;
            CqlConcept pzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, pzzzzzzzzzzzzj_);
            CqlCode pzzzzzzzzzzzzl_ = this.Discharge_to_home_for_hospice_care__procedure_(context);
            CqlConcept pzzzzzzzzzzzzm_ = context.Operators.ConvertCodeToConcept(pzzzzzzzzzzzzl_);
            bool? pzzzzzzzzzzzzn_ = context.Operators.Equivalent(pzzzzzzzzzzzzk_, pzzzzzzzzzzzzm_);
            CodeableConcept pzzzzzzzzzzzzp_ = pzzzzzzzzzzzzi_?.DischargeDisposition;
            CqlConcept pzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, pzzzzzzzzzzzzp_);
            CqlCode pzzzzzzzzzzzzr_ = this.Discharge_to_healthcare_facility_for_hospice_care__procedure_(context);
            CqlConcept pzzzzzzzzzzzzs_ = context.Operators.ConvertCodeToConcept(pzzzzzzzzzzzzr_);
            bool? pzzzzzzzzzzzzt_ = context.Operators.Equivalent(pzzzzzzzzzzzzq_, pzzzzzzzzzzzzs_);
            bool? pzzzzzzzzzzzzu_ = context.Operators.Or(pzzzzzzzzzzzzn_, pzzzzzzzzzzzzt_);
            Period pzzzzzzzzzzzzv_ = InpatientEncounter?.Period;
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzzzzzzzzv_);
            CqlDateTime pzzzzzzzzzzzzx_ = context.Operators.End(pzzzzzzzzzzzzw_);
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzy_ = this.Denominator_Identification_Period(context);
            CqlDateTime pzzzzzzzzzzzzz_ = context.Operators.Start(pzzzzzzzzzzzzy_);
            CqlInterval<CqlDate> qzzzzzzzzzzzza_ = this.Measure_Assessment_Period(context);
            CqlDate qzzzzzzzzzzzzb_ = context.Operators.End(qzzzzzzzzzzzza_);
            CqlDateTime qzzzzzzzzzzzzc_ = context.Operators.ConvertDateToDateTime(qzzzzzzzzzzzzb_);
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzd_ = context.Operators.Interval(pzzzzzzzzzzzzz_, qzzzzzzzzzzzzc_, true, true);
            bool? qzzzzzzzzzzzze_ = context.Operators.In<CqlDateTime>(pzzzzzzzzzzzzx_, qzzzzzzzzzzzzd_, "day");
            bool? qzzzzzzzzzzzzf_ = context.Operators.And(pzzzzzzzzzzzzu_, qzzzzzzzzzzzze_);
            Code<Encounter.EncounterStatus> qzzzzzzzzzzzzg_ = InpatientEncounter?.StatusElement;
            Encounter.EncounterStatus? qzzzzzzzzzzzzh_ = qzzzzzzzzzzzzg_?.Value;
            Code<Encounter.EncounterStatus> qzzzzzzzzzzzzi_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(qzzzzzzzzzzzzh_);
            bool? qzzzzzzzzzzzzj_ = context.Operators.Equal(qzzzzzzzzzzzzi_, "finished");
            bool? qzzzzzzzzzzzzk_ = context.Operators.And(qzzzzzzzzzzzzf_, qzzzzzzzzzzzzj_);

            return qzzzzzzzzzzzzk_;
        };
        IEnumerable<Encounter> ozzzzzzzzzzzzb_ = context.Operators.Where<Encounter>(nzzzzzzzzzzzzz_, ozzzzzzzzzzzza_);
        bool? ozzzzzzzzzzzzc_ = context.Operators.Exists<Encounter>(ozzzzzzzzzzzzb_);
        CqlValueSet ozzzzzzzzzzzzd_ = this.Hospice_Encounter(context);
        IEnumerable<Encounter> ozzzzzzzzzzzze_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ozzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? ozzzzzzzzzzzzf_(Encounter HospiceEncounter)
        {
            Period qzzzzzzzzzzzzl_ = HospiceEncounter?.Period;
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzzzzzzzzl_);
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzn_ = this.Denominator_Identification_Period(context);
            CqlDateTime qzzzzzzzzzzzzo_ = context.Operators.Start(qzzzzzzzzzzzzn_);
            CqlInterval<CqlDate> qzzzzzzzzzzzzp_ = this.Measure_Assessment_Period(context);
            CqlDate qzzzzzzzzzzzzq_ = context.Operators.End(qzzzzzzzzzzzzp_);
            CqlDateTime qzzzzzzzzzzzzr_ = context.Operators.ConvertDateToDateTime(qzzzzzzzzzzzzq_);
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzs_ = context.Operators.Interval(qzzzzzzzzzzzzo_, qzzzzzzzzzzzzr_, true, true);
            bool? qzzzzzzzzzzzzt_ = context.Operators.Overlaps(qzzzzzzzzzzzzm_, qzzzzzzzzzzzzs_, "day");
            Code<Encounter.EncounterStatus> qzzzzzzzzzzzzu_ = HospiceEncounter?.StatusElement;
            Encounter.EncounterStatus? qzzzzzzzzzzzzv_ = qzzzzzzzzzzzzu_?.Value;
            Code<Encounter.EncounterStatus> qzzzzzzzzzzzzw_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(qzzzzzzzzzzzzv_);
            string qzzzzzzzzzzzzx_ = context.Operators.Convert<string>(qzzzzzzzzzzzzw_);
            string[] qzzzzzzzzzzzzy_ = [
                "cancelled",
                "entered-in-error",
                "unknown",
            ];
            bool? qzzzzzzzzzzzzz_ = context.Operators.In<string>(qzzzzzzzzzzzzx_, qzzzzzzzzzzzzy_ as IEnumerable<string>);
            bool? rzzzzzzzzzzzza_ = context.Operators.Not(qzzzzzzzzzzzzz_);
            bool? rzzzzzzzzzzzzb_ = context.Operators.And(qzzzzzzzzzzzzt_, rzzzzzzzzzzzza_);

            return rzzzzzzzzzzzzb_;
        };
        IEnumerable<Encounter> ozzzzzzzzzzzzg_ = context.Operators.Where<Encounter>(ozzzzzzzzzzzze_, ozzzzzzzzzzzzf_);
        bool? ozzzzzzzzzzzzh_ = context.Operators.Exists<Encounter>(ozzzzzzzzzzzzg_);
        bool? ozzzzzzzzzzzzi_ = context.Operators.Or(ozzzzzzzzzzzzc_, ozzzzzzzzzzzzh_);
        CqlCode ozzzzzzzzzzzzj_ = this.Hospice_care__Minimum_Data_Set_(context);
        IEnumerable<CqlCode> ozzzzzzzzzzzzk_ = context.Operators.ToList<CqlCode>(ozzzzzzzzzzzzj_);
        IEnumerable<Observation> ozzzzzzzzzzzzl_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, ozzzzzzzzzzzzk_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? ozzzzzzzzzzzzm_(Observation HospiceAssessment)
        {
            DataType rzzzzzzzzzzzzc_ = HospiceAssessment?.Value;
            object rzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzc_);
            CqlCode rzzzzzzzzzzzze_ = this.Yes__qualifier_value_(context);
            CqlConcept rzzzzzzzzzzzzf_ = context.Operators.ConvertCodeToConcept(rzzzzzzzzzzzze_);
            bool? rzzzzzzzzzzzzg_ = context.Operators.Equivalent(rzzzzzzzzzzzzd_ as CqlConcept, rzzzzzzzzzzzzf_);
            DataType rzzzzzzzzzzzzh_ = HospiceAssessment?.Effective;
            object rzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzh_);
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.toInterval(context, rzzzzzzzzzzzzi_);
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzk_ = this.Denominator_Identification_Period(context);
            CqlDateTime rzzzzzzzzzzzzl_ = context.Operators.Start(rzzzzzzzzzzzzk_);
            CqlInterval<CqlDate> rzzzzzzzzzzzzm_ = this.Measure_Assessment_Period(context);
            CqlDate rzzzzzzzzzzzzn_ = context.Operators.End(rzzzzzzzzzzzzm_);
            CqlDateTime rzzzzzzzzzzzzo_ = context.Operators.ConvertDateToDateTime(rzzzzzzzzzzzzn_);
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzp_ = context.Operators.Interval(rzzzzzzzzzzzzl_, rzzzzzzzzzzzzo_, true, true);
            bool? rzzzzzzzzzzzzq_ = context.Operators.Overlaps(rzzzzzzzzzzzzj_, rzzzzzzzzzzzzp_, "day");
            bool? rzzzzzzzzzzzzr_ = context.Operators.And(rzzzzzzzzzzzzg_, rzzzzzzzzzzzzq_);
            Code<ObservationStatus> rzzzzzzzzzzzzs_ = HospiceAssessment?.StatusElement;
            ObservationStatus? rzzzzzzzzzzzzt_ = rzzzzzzzzzzzzs_?.Value;
            Code<ObservationStatus> rzzzzzzzzzzzzu_ = context.Operators.Convert<Code<ObservationStatus>>(rzzzzzzzzzzzzt_);
            string rzzzzzzzzzzzzv_ = context.Operators.Convert<string>(rzzzzzzzzzzzzu_);
            string[] rzzzzzzzzzzzzw_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? rzzzzzzzzzzzzx_ = context.Operators.In<string>(rzzzzzzzzzzzzv_, rzzzzzzzzzzzzw_ as IEnumerable<string>);
            bool? rzzzzzzzzzzzzy_ = context.Operators.And(rzzzzzzzzzzzzr_, rzzzzzzzzzzzzx_);

            return rzzzzzzzzzzzzy_;
        };
        IEnumerable<Observation> ozzzzzzzzzzzzn_ = context.Operators.Where<Observation>(ozzzzzzzzzzzzl_, ozzzzzzzzzzzzm_);
        bool? ozzzzzzzzzzzzo_ = context.Operators.Exists<Observation>(ozzzzzzzzzzzzn_);
        bool? ozzzzzzzzzzzzp_ = context.Operators.Or(ozzzzzzzzzzzzi_, ozzzzzzzzzzzzo_);
        CqlValueSet ozzzzzzzzzzzzq_ = this.Hospice_Care_Ambulatory(context);
        IEnumerable<ServiceRequest> ozzzzzzzzzzzzr_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, ozzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        bool? ozzzzzzzzzzzzs_(ServiceRequest HospiceOrder)
        {
            FhirDateTime rzzzzzzzzzzzzz_ = HospiceOrder?.AuthoredOnElement;
            CqlDateTime szzzzzzzzzzzza_ = context.Operators.Convert<CqlDateTime>(rzzzzzzzzzzzzz_);
            CqlInterval<CqlDateTime> szzzzzzzzzzzzb_ = this.Denominator_Identification_Period(context);
            CqlDateTime szzzzzzzzzzzzc_ = context.Operators.Start(szzzzzzzzzzzzb_);
            CqlInterval<CqlDate> szzzzzzzzzzzzd_ = this.Measure_Assessment_Period(context);
            CqlDate szzzzzzzzzzzze_ = context.Operators.End(szzzzzzzzzzzzd_);
            CqlDateTime szzzzzzzzzzzzf_ = context.Operators.ConvertDateToDateTime(szzzzzzzzzzzze_);
            CqlInterval<CqlDateTime> szzzzzzzzzzzzg_ = context.Operators.Interval(szzzzzzzzzzzzc_, szzzzzzzzzzzzf_, true, true);
            bool? szzzzzzzzzzzzh_ = context.Operators.In<CqlDateTime>(szzzzzzzzzzzza_, szzzzzzzzzzzzg_, "day");
            Code<RequestStatus> szzzzzzzzzzzzi_ = HospiceOrder?.StatusElement;
            RequestStatus? szzzzzzzzzzzzj_ = szzzzzzzzzzzzi_?.Value;
            Code<RequestStatus> szzzzzzzzzzzzk_ = context.Operators.Convert<Code<RequestStatus>>(szzzzzzzzzzzzj_);
            string szzzzzzzzzzzzl_ = context.Operators.Convert<string>(szzzzzzzzzzzzk_);
            string[] szzzzzzzzzzzzm_ = [
                "active",
                "completed",
            ];
            bool? szzzzzzzzzzzzn_ = context.Operators.In<string>(szzzzzzzzzzzzl_, szzzzzzzzzzzzm_ as IEnumerable<string>);
            bool? szzzzzzzzzzzzo_ = context.Operators.And(szzzzzzzzzzzzh_, szzzzzzzzzzzzn_);
            Code<RequestIntent> szzzzzzzzzzzzp_ = HospiceOrder?.IntentElement;
            RequestIntent? szzzzzzzzzzzzq_ = szzzzzzzzzzzzp_?.Value;
            Code<RequestIntent> szzzzzzzzzzzzr_ = context.Operators.Convert<Code<RequestIntent>>(szzzzzzzzzzzzq_);
            string szzzzzzzzzzzzs_ = context.Operators.Convert<string>(szzzzzzzzzzzzr_);
            string[] szzzzzzzzzzzzt_ = [
                "order",
                "original-order",
                "reflex-order",
                "filler-order",
                "instance-order",
            ];
            bool? szzzzzzzzzzzzu_ = context.Operators.In<string>(szzzzzzzzzzzzs_, szzzzzzzzzzzzt_ as IEnumerable<string>);
            bool? szzzzzzzzzzzzv_ = context.Operators.And(szzzzzzzzzzzzo_, szzzzzzzzzzzzu_);
            FhirBoolean szzzzzzzzzzzzw_ = HospiceOrder?.DoNotPerformElement;
            bool? szzzzzzzzzzzzx_ = szzzzzzzzzzzzw_?.Value;
            bool? szzzzzzzzzzzzy_ = context.Operators.IsTrue(szzzzzzzzzzzzx_);
            bool? szzzzzzzzzzzzz_ = context.Operators.Not(szzzzzzzzzzzzy_);
            bool? tzzzzzzzzzzzza_ = context.Operators.And(szzzzzzzzzzzzv_, szzzzzzzzzzzzz_);

            return tzzzzzzzzzzzza_;
        };
        IEnumerable<ServiceRequest> ozzzzzzzzzzzzt_ = context.Operators.Where<ServiceRequest>(ozzzzzzzzzzzzr_, ozzzzzzzzzzzzs_);
        bool? ozzzzzzzzzzzzu_ = context.Operators.Exists<ServiceRequest>(ozzzzzzzzzzzzt_);
        bool? ozzzzzzzzzzzzv_ = context.Operators.Or(ozzzzzzzzzzzzp_, ozzzzzzzzzzzzu_);
        IEnumerable<Procedure> ozzzzzzzzzzzzx_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, ozzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        bool? ozzzzzzzzzzzzy_(Procedure HospicePerformed)
        {
            DataType tzzzzzzzzzzzzb_ = HospicePerformed?.Performed;
            object tzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzb_);
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.toInterval(context, tzzzzzzzzzzzzc_);
            CqlInterval<CqlDateTime> tzzzzzzzzzzzze_ = this.Denominator_Identification_Period(context);
            CqlDateTime tzzzzzzzzzzzzf_ = context.Operators.Start(tzzzzzzzzzzzze_);
            CqlInterval<CqlDate> tzzzzzzzzzzzzg_ = this.Measure_Assessment_Period(context);
            CqlDate tzzzzzzzzzzzzh_ = context.Operators.End(tzzzzzzzzzzzzg_);
            CqlDateTime tzzzzzzzzzzzzi_ = context.Operators.ConvertDateToDateTime(tzzzzzzzzzzzzh_);
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzj_ = context.Operators.Interval(tzzzzzzzzzzzzf_, tzzzzzzzzzzzzi_, true, true);
            bool? tzzzzzzzzzzzzk_ = context.Operators.Overlaps(tzzzzzzzzzzzzd_, tzzzzzzzzzzzzj_, "day");
            Code<EventStatus> tzzzzzzzzzzzzl_ = HospicePerformed?.StatusElement;
            EventStatus? tzzzzzzzzzzzzm_ = tzzzzzzzzzzzzl_?.Value;
            string tzzzzzzzzzzzzn_ = context.Operators.Convert<string>(tzzzzzzzzzzzzm_);
            string[] tzzzzzzzzzzzzo_ = [
                "not-done",
                "entered-in-error",
                "unknown",
            ];
            bool? tzzzzzzzzzzzzp_ = context.Operators.In<string>(tzzzzzzzzzzzzn_, tzzzzzzzzzzzzo_ as IEnumerable<string>);
            bool? tzzzzzzzzzzzzq_ = context.Operators.Not(tzzzzzzzzzzzzp_);
            bool? tzzzzzzzzzzzzr_ = context.Operators.And(tzzzzzzzzzzzzk_, tzzzzzzzzzzzzq_);

            return tzzzzzzzzzzzzr_;
        };
        IEnumerable<Procedure> ozzzzzzzzzzzzz_ = context.Operators.Where<Procedure>(ozzzzzzzzzzzzx_, ozzzzzzzzzzzzy_);
        bool? pzzzzzzzzzzzza_ = context.Operators.Exists<Procedure>(ozzzzzzzzzzzzz_);
        bool? pzzzzzzzzzzzzb_ = context.Operators.Or(ozzzzzzzzzzzzv_, pzzzzzzzzzzzza_);
        CqlValueSet pzzzzzzzzzzzzc_ = this.Hospice_Diagnosis(context);
        IEnumerable<Condition> pzzzzzzzzzzzzd_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, pzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? pzzzzzzzzzzzze_(Condition HospiceCareDiagnosis)
        {
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, HospiceCareDiagnosis);
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzt_ = this.Denominator_Identification_Period(context);
            CqlDateTime tzzzzzzzzzzzzu_ = context.Operators.Start(tzzzzzzzzzzzzt_);
            CqlInterval<CqlDate> tzzzzzzzzzzzzv_ = this.Measure_Assessment_Period(context);
            CqlDate tzzzzzzzzzzzzw_ = context.Operators.End(tzzzzzzzzzzzzv_);
            CqlDateTime tzzzzzzzzzzzzx_ = context.Operators.ConvertDateToDateTime(tzzzzzzzzzzzzw_);
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzy_ = context.Operators.Interval(tzzzzzzzzzzzzu_, tzzzzzzzzzzzzx_, true, true);
            bool? tzzzzzzzzzzzzz_ = context.Operators.Overlaps(tzzzzzzzzzzzzs_, tzzzzzzzzzzzzy_, "day");
            bool? uzzzzzzzzzzzza_ = this.isConfirmedActiveDiagnosis(context, HospiceCareDiagnosis);
            bool? uzzzzzzzzzzzzb_ = context.Operators.And(tzzzzzzzzzzzzz_, uzzzzzzzzzzzza_);

            return uzzzzzzzzzzzzb_;
        };
        IEnumerable<Condition> pzzzzzzzzzzzzf_ = context.Operators.Where<Condition>(pzzzzzzzzzzzzd_, pzzzzzzzzzzzze_);
        bool? pzzzzzzzzzzzzg_ = context.Operators.Exists<Condition>(pzzzzzzzzzzzzf_);
        bool? pzzzzzzzzzzzzh_ = context.Operators.Or(pzzzzzzzzzzzzb_, pzzzzzzzzzzzzg_);

        return pzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Has Palliative Care in the Measure Assessment Period")]
    public bool? Has_Palliative_Care_in_the_Measure_Assessment_Period(CqlContext context)
    {
        CqlCode uzzzzzzzzzzzzc_ = this.Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal_(context);
        IEnumerable<CqlCode> uzzzzzzzzzzzzd_ = context.Operators.ToList<CqlCode>(uzzzzzzzzzzzzc_);
        IEnumerable<Observation> uzzzzzzzzzzzze_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, uzzzzzzzzzzzzd_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? uzzzzzzzzzzzzf_(Observation PalliativeAssessment)
        {
            DataType vzzzzzzzzzzzza_ = PalliativeAssessment?.Effective;
            object vzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzza_);
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.toInterval(context, vzzzzzzzzzzzzb_);
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzd_ = this.Denominator_Identification_Period(context);
            CqlDateTime vzzzzzzzzzzzze_ = context.Operators.Start(vzzzzzzzzzzzzd_);
            CqlInterval<CqlDate> vzzzzzzzzzzzzf_ = this.Measure_Assessment_Period(context);
            CqlDate vzzzzzzzzzzzzg_ = context.Operators.End(vzzzzzzzzzzzzf_);
            CqlDateTime vzzzzzzzzzzzzh_ = context.Operators.ConvertDateToDateTime(vzzzzzzzzzzzzg_);
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzi_ = context.Operators.Interval(vzzzzzzzzzzzze_, vzzzzzzzzzzzzh_, true, true);
            bool? vzzzzzzzzzzzzj_ = context.Operators.Overlaps(vzzzzzzzzzzzzc_, vzzzzzzzzzzzzi_, default);
            Code<ObservationStatus> vzzzzzzzzzzzzk_ = PalliativeAssessment?.StatusElement;
            ObservationStatus? vzzzzzzzzzzzzl_ = vzzzzzzzzzzzzk_?.Value;
            Code<ObservationStatus> vzzzzzzzzzzzzm_ = context.Operators.Convert<Code<ObservationStatus>>(vzzzzzzzzzzzzl_);
            string vzzzzzzzzzzzzn_ = context.Operators.Convert<string>(vzzzzzzzzzzzzm_);
            string[] vzzzzzzzzzzzzo_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? vzzzzzzzzzzzzp_ = context.Operators.In<string>(vzzzzzzzzzzzzn_, vzzzzzzzzzzzzo_ as IEnumerable<string>);
            bool? vzzzzzzzzzzzzq_ = context.Operators.And(vzzzzzzzzzzzzj_, vzzzzzzzzzzzzp_);

            return vzzzzzzzzzzzzq_;
        };
        IEnumerable<Observation> uzzzzzzzzzzzzg_ = context.Operators.Where<Observation>(uzzzzzzzzzzzze_, uzzzzzzzzzzzzf_);
        bool? uzzzzzzzzzzzzh_ = context.Operators.Exists<Observation>(uzzzzzzzzzzzzg_);
        CqlValueSet uzzzzzzzzzzzzi_ = this.Palliative_Care_Diagnosis(context);
        IEnumerable<Condition> uzzzzzzzzzzzzj_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, uzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? uzzzzzzzzzzzzk_(Condition PalliativeDiagnosis)
        {
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, PalliativeDiagnosis);
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzs_ = this.Denominator_Identification_Period(context);
            CqlDateTime vzzzzzzzzzzzzt_ = context.Operators.Start(vzzzzzzzzzzzzs_);
            CqlInterval<CqlDate> vzzzzzzzzzzzzu_ = this.Measure_Assessment_Period(context);
            CqlDate vzzzzzzzzzzzzv_ = context.Operators.End(vzzzzzzzzzzzzu_);
            CqlDateTime vzzzzzzzzzzzzw_ = context.Operators.ConvertDateToDateTime(vzzzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzx_ = context.Operators.Interval(vzzzzzzzzzzzzt_, vzzzzzzzzzzzzw_, true, true);
            bool? vzzzzzzzzzzzzy_ = context.Operators.Overlaps(vzzzzzzzzzzzzr_, vzzzzzzzzzzzzx_, default);
            bool? vzzzzzzzzzzzzz_ = this.isConfirmedActiveDiagnosis(context, PalliativeDiagnosis);
            bool? wzzzzzzzzzzzza_ = context.Operators.And(vzzzzzzzzzzzzy_, vzzzzzzzzzzzzz_);

            return wzzzzzzzzzzzza_;
        };
        IEnumerable<Condition> uzzzzzzzzzzzzl_ = context.Operators.Where<Condition>(uzzzzzzzzzzzzj_, uzzzzzzzzzzzzk_);
        bool? uzzzzzzzzzzzzm_ = context.Operators.Exists<Condition>(uzzzzzzzzzzzzl_);
        bool? uzzzzzzzzzzzzn_ = context.Operators.Or(uzzzzzzzzzzzzh_, uzzzzzzzzzzzzm_);
        CqlValueSet uzzzzzzzzzzzzo_ = this.Palliative_Care_Encounter(context);
        IEnumerable<Encounter> uzzzzzzzzzzzzp_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, uzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? uzzzzzzzzzzzzq_(Encounter PalliativeEncounter)
        {
            Period wzzzzzzzzzzzzb_ = PalliativeEncounter?.Period;
            CqlInterval<CqlDateTime> wzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzzzzzzzzb_);
            CqlInterval<CqlDateTime> wzzzzzzzzzzzzd_ = this.Denominator_Identification_Period(context);
            CqlDateTime wzzzzzzzzzzzze_ = context.Operators.Start(wzzzzzzzzzzzzd_);
            CqlInterval<CqlDate> wzzzzzzzzzzzzf_ = this.Measure_Assessment_Period(context);
            CqlDate wzzzzzzzzzzzzg_ = context.Operators.End(wzzzzzzzzzzzzf_);
            CqlDateTime wzzzzzzzzzzzzh_ = context.Operators.ConvertDateToDateTime(wzzzzzzzzzzzzg_);
            CqlInterval<CqlDateTime> wzzzzzzzzzzzzi_ = context.Operators.Interval(wzzzzzzzzzzzze_, wzzzzzzzzzzzzh_, true, true);
            bool? wzzzzzzzzzzzzj_ = context.Operators.Overlaps(wzzzzzzzzzzzzc_, wzzzzzzzzzzzzi_, default);
            Code<Encounter.EncounterStatus> wzzzzzzzzzzzzk_ = PalliativeEncounter?.StatusElement;
            Encounter.EncounterStatus? wzzzzzzzzzzzzl_ = wzzzzzzzzzzzzk_?.Value;
            Code<Encounter.EncounterStatus> wzzzzzzzzzzzzm_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(wzzzzzzzzzzzzl_);
            bool? wzzzzzzzzzzzzn_ = context.Operators.Equal(wzzzzzzzzzzzzm_, "finished");
            bool? wzzzzzzzzzzzzo_ = context.Operators.And(wzzzzzzzzzzzzj_, wzzzzzzzzzzzzn_);

            return wzzzzzzzzzzzzo_;
        };
        IEnumerable<Encounter> uzzzzzzzzzzzzr_ = context.Operators.Where<Encounter>(uzzzzzzzzzzzzp_, uzzzzzzzzzzzzq_);
        bool? uzzzzzzzzzzzzs_ = context.Operators.Exists<Encounter>(uzzzzzzzzzzzzr_);
        bool? uzzzzzzzzzzzzt_ = context.Operators.Or(uzzzzzzzzzzzzn_, uzzzzzzzzzzzzs_);
        CqlValueSet uzzzzzzzzzzzzu_ = this.Palliative_Care_Intervention(context);
        IEnumerable<Procedure> uzzzzzzzzzzzzv_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, uzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        bool? uzzzzzzzzzzzzw_(Procedure PalliativeIntervention)
        {
            DataType wzzzzzzzzzzzzp_ = PalliativeIntervention?.Performed;
            object wzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzp_);
            CqlInterval<CqlDateTime> wzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.toInterval(context, wzzzzzzzzzzzzq_);
            CqlInterval<CqlDateTime> wzzzzzzzzzzzzs_ = this.Denominator_Identification_Period(context);
            CqlDateTime wzzzzzzzzzzzzt_ = context.Operators.Start(wzzzzzzzzzzzzs_);
            CqlInterval<CqlDate> wzzzzzzzzzzzzu_ = this.Measure_Assessment_Period(context);
            CqlDate wzzzzzzzzzzzzv_ = context.Operators.End(wzzzzzzzzzzzzu_);
            CqlDateTime wzzzzzzzzzzzzw_ = context.Operators.ConvertDateToDateTime(wzzzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> wzzzzzzzzzzzzx_ = context.Operators.Interval(wzzzzzzzzzzzzt_, wzzzzzzzzzzzzw_, true, true);
            bool? wzzzzzzzzzzzzy_ = context.Operators.Overlaps(wzzzzzzzzzzzzr_, wzzzzzzzzzzzzx_, default);
            Code<EventStatus> wzzzzzzzzzzzzz_ = PalliativeIntervention?.StatusElement;
            EventStatus? xzzzzzzzzzzzza_ = wzzzzzzzzzzzzz_?.Value;
            string xzzzzzzzzzzzzb_ = context.Operators.Convert<string>(xzzzzzzzzzzzza_);
            string[] xzzzzzzzzzzzzc_ = [
                "not-done",
                "entered-in-error",
                "unknown",
            ];
            bool? xzzzzzzzzzzzzd_ = context.Operators.In<string>(xzzzzzzzzzzzzb_, xzzzzzzzzzzzzc_ as IEnumerable<string>);
            bool? xzzzzzzzzzzzze_ = context.Operators.Not(xzzzzzzzzzzzzd_);
            bool? xzzzzzzzzzzzzf_ = context.Operators.And(wzzzzzzzzzzzzy_, xzzzzzzzzzzzze_);

            return xzzzzzzzzzzzzf_;
        };
        IEnumerable<Procedure> uzzzzzzzzzzzzx_ = context.Operators.Where<Procedure>(uzzzzzzzzzzzzv_, uzzzzzzzzzzzzw_);
        bool? uzzzzzzzzzzzzy_ = context.Operators.Exists<Procedure>(uzzzzzzzzzzzzx_);
        bool? uzzzzzzzzzzzzz_ = context.Operators.Or(uzzzzzzzzzzzzt_, uzzzzzzzzzzzzy_);

        return uzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Patient Expired")]
    public bool? Patient_Expired(CqlContext context)
    {
        Patient xzzzzzzzzzzzzg_ = this.Patient(context);
        DataType xzzzzzzzzzzzzh_ = xzzzzzzzzzzzzg_?.Deceased;
        object xzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzh_);
        CqlInterval<CqlDate> xzzzzzzzzzzzzj_ = this.Measure_Assessment_Period(context);
        CqlDate xzzzzzzzzzzzzk_ = context.Operators.End(xzzzzzzzzzzzzj_);
        CqlDateTime xzzzzzzzzzzzzl_ = context.Operators.ConvertDateToDateTime(xzzzzzzzzzzzzk_);
        bool? xzzzzzzzzzzzzm_ = context.Operators.SameOrBefore(xzzzzzzzzzzzzi_ as CqlDateTime, xzzzzzzzzzzzzl_, default);

        return xzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Has Mental Health Disorder Diagnoses")]
    public bool? Has_Mental_Health_Disorder_Diagnoses(CqlContext context)
    {
        CqlValueSet xzzzzzzzzzzzzn_ = this.Bipolar_Disorder(context);
        IEnumerable<Condition> xzzzzzzzzzzzzo_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, xzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet xzzzzzzzzzzzzp_ = this.Personality_Disorder_Emotionally_Labile(context);
        IEnumerable<Condition> xzzzzzzzzzzzzq_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, xzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> xzzzzzzzzzzzzr_ = context.Operators.Union<Condition>(xzzzzzzzzzzzzo_, xzzzzzzzzzzzzq_);
        CqlValueSet xzzzzzzzzzzzzs_ = this.Schizophrenia_or_Psychotic_Disorder(context);
        IEnumerable<Condition> xzzzzzzzzzzzzt_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, xzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet xzzzzzzzzzzzzu_ = this.Pervasive_Developmental_Disorder(context);
        IEnumerable<Condition> xzzzzzzzzzzzzv_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, xzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> xzzzzzzzzzzzzw_ = context.Operators.Union<Condition>(xzzzzzzzzzzzzt_, xzzzzzzzzzzzzv_);
        IEnumerable<Condition> xzzzzzzzzzzzzx_ = context.Operators.Union<Condition>(xzzzzzzzzzzzzr_, xzzzzzzzzzzzzw_);
        bool? xzzzzzzzzzzzzy_(Condition MentalHealthDisorderDiagnoses)
        {
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, MentalHealthDisorderDiagnoses);
            CqlDateTime yzzzzzzzzzzzzc_ = context.Operators.Start(yzzzzzzzzzzzzb_);
            CqlDate yzzzzzzzzzzzzd_ = context.Operators.ConvertDateTimeToDate(yzzzzzzzzzzzzc_);
            CqlInterval<CqlDate> yzzzzzzzzzzzze_ = this.Measure_Assessment_Period(context);
            CqlDate yzzzzzzzzzzzzf_ = context.Operators.End(yzzzzzzzzzzzze_);
            bool? yzzzzzzzzzzzzg_ = context.Operators.SameOrBefore(yzzzzzzzzzzzzd_, yzzzzzzzzzzzzf_, default);
            bool? yzzzzzzzzzzzzh_ = this.isConfirmedActiveDiagnosis(context, MentalHealthDisorderDiagnoses);
            bool? yzzzzzzzzzzzzi_ = context.Operators.And(yzzzzzzzzzzzzg_, yzzzzzzzzzzzzh_);

            return yzzzzzzzzzzzzi_;
        };
        IEnumerable<Condition> xzzzzzzzzzzzzz_ = context.Operators.Where<Condition>(xzzzzzzzzzzzzx_, xzzzzzzzzzzzzy_);
        bool? yzzzzzzzzzzzza_ = context.Operators.Exists<Condition>(xzzzzzzzzzzzzz_);

        return yzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? yzzzzzzzzzzzzj_ = this.Has_Hospice_Services_in_the_Measure_Assessment_Period(context);
        bool? yzzzzzzzzzzzzk_ = this.Has_Palliative_Care_in_the_Measure_Assessment_Period(context);
        bool? yzzzzzzzzzzzzl_ = context.Operators.Or(yzzzzzzzzzzzzj_, yzzzzzzzzzzzzk_);
        bool? yzzzzzzzzzzzzm_ = this.Patient_Expired(context);
        bool? yzzzzzzzzzzzzn_ = context.Operators.Or(yzzzzzzzzzzzzl_, yzzzzzzzzzzzzm_);
        bool? yzzzzzzzzzzzzo_ = this.Has_Mental_Health_Disorder_Diagnoses(context);
        bool? yzzzzzzzzzzzzp_ = context.Operators.Or(yzzzzzzzzzzzzn_, yzzzzzzzzzzzzo_);

        return yzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        CqlValueSet yzzzzzzzzzzzzq_ = this.PHQ_9_and_PHQ_9M_Tools(context);
        IEnumerable<Observation> yzzzzzzzzzzzzr_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, yzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? yzzzzzzzzzzzzs_(Observation DepressionAssessment)
        {
            DataType zzzzzzzzzzzzza_ = DepressionAssessment?.Effective;
            object zzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzza_);
            CqlInterval<CqlDateTime> zzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.toInterval(context, zzzzzzzzzzzzzb_);
            CqlDateTime zzzzzzzzzzzzzd_ = context.Operators.Start(zzzzzzzzzzzzzc_);
            CqlDate zzzzzzzzzzzzze_ = context.Operators.ConvertDateTimeToDate(zzzzzzzzzzzzzd_);
            CqlInterval<CqlDate> zzzzzzzzzzzzzf_ = this.Measure_Assessment_Period(context);
            bool? zzzzzzzzzzzzzg_ = context.Operators.In<CqlDate>(zzzzzzzzzzzzze_, zzzzzzzzzzzzzf_, default);
            Code<ObservationStatus> zzzzzzzzzzzzzh_ = DepressionAssessment?.StatusElement;
            ObservationStatus? zzzzzzzzzzzzzi_ = zzzzzzzzzzzzzh_?.Value;
            Code<ObservationStatus> zzzzzzzzzzzzzj_ = context.Operators.Convert<Code<ObservationStatus>>(zzzzzzzzzzzzzi_);
            string zzzzzzzzzzzzzk_ = context.Operators.Convert<string>(zzzzzzzzzzzzzj_);
            string[] zzzzzzzzzzzzzl_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? zzzzzzzzzzzzzm_ = context.Operators.In<string>(zzzzzzzzzzzzzk_, zzzzzzzzzzzzzl_ as IEnumerable<string>);
            bool? zzzzzzzzzzzzzn_ = context.Operators.And(zzzzzzzzzzzzzg_, zzzzzzzzzzzzzm_);

            return zzzzzzzzzzzzzn_;
        };
        IEnumerable<Observation> yzzzzzzzzzzzzt_ = context.Operators.Where<Observation>(yzzzzzzzzzzzzr_, yzzzzzzzzzzzzs_);
        object yzzzzzzzzzzzzu_(Observation @this)
        {
            DataType zzzzzzzzzzzzzo_ = @this?.Effective;
            object zzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzo_);
            CqlInterval<CqlDateTime> zzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.toInterval(context, zzzzzzzzzzzzzp_);
            CqlDateTime zzzzzzzzzzzzzr_ = context.Operators.Start(zzzzzzzzzzzzzq_);

            return zzzzzzzzzzzzzr_;
        };
        IEnumerable<Observation> yzzzzzzzzzzzzv_ = context.Operators.SortBy<Observation>(yzzzzzzzzzzzzt_, yzzzzzzzzzzzzu_, System.ComponentModel.ListSortDirection.Ascending);
        Observation yzzzzzzzzzzzzw_ = context.Operators.Last<Observation>(yzzzzzzzzzzzzv_);
        DataType yzzzzzzzzzzzzx_ = yzzzzzzzzzzzzw_?.Value;
        object yzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzx_);
        bool? yzzzzzzzzzzzzz_ = context.Operators.Less(yzzzzzzzzzzzzy_ as int?, 5);

        return yzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? zzzzzzzzzzzzzs_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return zzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> zzzzzzzzzzzzzt_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return zzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? zzzzzzzzzzzzzu_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return zzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode zzzzzzzzzzzzzv_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return zzzzzzzzzzzzzv_;
    }


    #endregion Expressions

}
