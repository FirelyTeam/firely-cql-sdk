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
    private static readonly CqlCode _Discharge_to_healthcare_facility_for_hospice_care__procedure_ = new CqlCode("428371000124100", "http://snomed.info/sct");

    [CqlCodeDefinition("Discharge to home for hospice care (procedure)", codeId: "428361000124107", codeSystem: "http://snomed.info/sct")]
    public CqlCode Discharge_to_home_for_hospice_care__procedure_(CqlContext _) => _Discharge_to_home_for_hospice_care__procedure_;
    private static readonly CqlCode _Discharge_to_home_for_hospice_care__procedure_ = new CqlCode("428361000124107", "http://snomed.info/sct");

    [CqlCodeDefinition("Functional Assessment of Chronic Illness Therapy - Palliative Care Questionnaire (FACIT-Pal)", codeId: "71007-9", codeSystem: "http://loinc.org")]
    public CqlCode Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal_(CqlContext _) => _Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal_;
    private static readonly CqlCode _Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal_ = new CqlCode("71007-9", "http://loinc.org");

    [CqlCodeDefinition("Hospice care [Minimum Data Set]", codeId: "45755-6", codeSystem: "http://loinc.org")]
    public CqlCode Hospice_care__Minimum_Data_Set_(CqlContext _) => _Hospice_care__Minimum_Data_Set_;
    private static readonly CqlCode _Hospice_care__Minimum_Data_Set_ = new CqlCode("45755-6", "http://loinc.org");

    [CqlCodeDefinition("Yes (qualifier value)", codeId: "373066001", codeSystem: "http://snomed.info/sct")]
    public CqlCode Yes__qualifier_value_(CqlContext _) => _Yes__qualifier_value_;
    private static readonly CqlCode _Yes__qualifier_value_ = new CqlCode("373066001", "http://snomed.info/sct");

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("LOINC")]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC =
      new CqlCodeSystem("http://loinc.org", null, [
          _Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal_,
          _Hospice_care__Minimum_Data_Set_]);

    [CqlCodeSystemDefinition("SNOMEDCT")]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT =
      new CqlCodeSystem("http://snomed.info/sct", null, [
          _Discharge_to_healthcare_facility_for_hospice_care__procedure_,
          _Discharge_to_home_for_hospice_care__procedure_,
          _Yes__qualifier_value_]);

    [CqlCodeSystemDefinition("ConditionVerificationStatusCodes")]
    public CqlCodeSystem ConditionVerificationStatusCodes(CqlContext _) => _ConditionVerificationStatusCodes;
    private static readonly CqlCodeSystem _ConditionVerificationStatusCodes =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/condition-ver-status", null, []);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime mzzzzzzzzzzzzzzzr_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime mzzzzzzzzzzzzzzzs_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzt_ = context.Operators.Interval(mzzzzzzzzzzzzzzzr_, mzzzzzzzzzzzzzzzs_, true, true);
        object mzzzzzzzzzzzzzzzu_ = context.ResolveParameter("DepressionRemissionatTwelveMonthsFHIR-0.2.000", "Measurement Period", mzzzzzzzzzzzzzzzt_);

        return (CqlInterval<CqlDateTime>)mzzzzzzzzzzzzzzzu_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> mzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient mzzzzzzzzzzzzzzzw_ = context.Operators.SingletonFrom<Patient>(mzzzzzzzzzzzzzzzv_);

        return mzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Depression Assessments Greater than 9")]
    public IEnumerable<Observation> Depression_Assessments_Greater_than_9(CqlContext context)
    {
        CqlValueSet mzzzzzzzzzzzzzzzx_ = this.PHQ_9_and_PHQ_9M_Tools(context);
        IEnumerable<Observation> mzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, mzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? mzzzzzzzzzzzzzzzz_(Observation DepressionAssessment)
        {
            DataType nzzzzzzzzzzzzzzzb_ = DepressionAssessment?.Value;
            object nzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzb_);
            bool? nzzzzzzzzzzzzzzzd_ = context.Operators.Greater(nzzzzzzzzzzzzzzzc_ as int?, 9);
            Code<ObservationStatus> nzzzzzzzzzzzzzzze_ = DepressionAssessment?.StatusElement;
            ObservationStatus? nzzzzzzzzzzzzzzzf_ = nzzzzzzzzzzzzzzze_?.Value;
            Code<ObservationStatus> nzzzzzzzzzzzzzzzg_ = context.Operators.Convert<Code<ObservationStatus>>(nzzzzzzzzzzzzzzzf_);
            string nzzzzzzzzzzzzzzzh_ = context.Operators.Convert<string>(nzzzzzzzzzzzzzzzg_);
            string[] nzzzzzzzzzzzzzzzi_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? nzzzzzzzzzzzzzzzj_ = context.Operators.In<string>(nzzzzzzzzzzzzzzzh_, nzzzzzzzzzzzzzzzi_ as IEnumerable<string>);
            bool? nzzzzzzzzzzzzzzzk_ = context.Operators.And(nzzzzzzzzzzzzzzzd_, nzzzzzzzzzzzzzzzj_);

            return nzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<Observation> nzzzzzzzzzzzzzzza_ = context.Operators.Where<Observation>(mzzzzzzzzzzzzzzzy_, mzzzzzzzzzzzzzzzz_);

        return nzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("isConfirmedActiveDiagnosis")]
    public bool? isConfirmedActiveDiagnosis(CqlContext context, Condition condition)
    {
        bool? nzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.isActive(context, condition);
        CodeableConcept nzzzzzzzzzzzzzzzm_ = condition?.VerificationStatus;
        CqlConcept nzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, nzzzzzzzzzzzzzzzm_);
        CqlCode nzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.confirmed(context);
        CqlConcept nzzzzzzzzzzzzzzzp_ = context.Operators.ConvertCodeToConcept(nzzzzzzzzzzzzzzzo_);
        bool? nzzzzzzzzzzzzzzzq_ = context.Operators.Equivalent(nzzzzzzzzzzzzzzzn_, nzzzzzzzzzzzzzzzp_);
        bool? nzzzzzzzzzzzzzzzr_ = context.Operators.And(nzzzzzzzzzzzzzzzl_, nzzzzzzzzzzzzzzzq_);

        return nzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Depression Diagnoses")]
    public IEnumerable<Condition> Depression_Diagnoses(CqlContext context)
    {
        CqlValueSet nzzzzzzzzzzzzzzzs_ = this.Major_Depression_Including_Remission(context);
        IEnumerable<Condition> nzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, nzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet nzzzzzzzzzzzzzzzu_ = this.Dysthymia(context);
        IEnumerable<Condition> nzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, nzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> nzzzzzzzzzzzzzzzw_ = context.Operators.Union<Condition>(nzzzzzzzzzzzzzzzt_, nzzzzzzzzzzzzzzzv_);
        bool? nzzzzzzzzzzzzzzzx_(Condition Depression)
        {
            bool? nzzzzzzzzzzzzzzzz_ = this.isConfirmedActiveDiagnosis(context, Depression);

            return nzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<Condition> nzzzzzzzzzzzzzzzy_ = context.Operators.Where<Condition>(nzzzzzzzzzzzzzzzw_, nzzzzzzzzzzzzzzzx_);

        return nzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Denominator Identification Period")]
    public CqlInterval<CqlDateTime> Denominator_Identification_Period(CqlContext context)
    {
        CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzza_ = this.Measurement_Period(context);
        CqlDateTime ozzzzzzzzzzzzzzzb_ = context.Operators.Start(ozzzzzzzzzzzzzzza_);
        CqlQuantity ozzzzzzzzzzzzzzzc_ = context.Operators.Quantity(14m, "months");
        CqlDateTime ozzzzzzzzzzzzzzzd_ = context.Operators.Subtract(ozzzzzzzzzzzzzzzb_, ozzzzzzzzzzzzzzzc_);
        CqlDateTime ozzzzzzzzzzzzzzzf_ = context.Operators.Start(ozzzzzzzzzzzzzzza_);
        CqlQuantity ozzzzzzzzzzzzzzzg_ = context.Operators.Quantity(2m, "months");
        CqlDateTime ozzzzzzzzzzzzzzzh_ = context.Operators.Subtract(ozzzzzzzzzzzzzzzf_, ozzzzzzzzzzzzzzzg_);
        CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzi_ = context.Operators.Interval(ozzzzzzzzzzzzzzzd_, ozzzzzzzzzzzzzzzh_, true, false);

        return ozzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Depression Encounter")]
    public IEnumerable<Encounter> Depression_Encounter(CqlContext context)
    {
        CqlValueSet ozzzzzzzzzzzzzzzj_ = this.Contact_or_Office_Visit(context);
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ozzzzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzl_(Encounter ValidEncounter)
        {
            IEnumerable<Condition> ozzzzzzzzzzzzzzzn_ = this.Depression_Diagnoses(context);
            bool? ozzzzzzzzzzzzzzzo_(Condition Depression)
            {
                Period ozzzzzzzzzzzzzzzs_ = ValidEncounter?.Period;
                CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzzzzzzzzzzzs_);
                CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, Depression);
                bool? ozzzzzzzzzzzzzzzv_ = context.Operators.Overlaps(ozzzzzzzzzzzzzzzt_, ozzzzzzzzzzzzzzzu_, default);
                CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzzzzzzzzzzzs_);
                CqlDateTime ozzzzzzzzzzzzzzzy_ = context.Operators.End(ozzzzzzzzzzzzzzzx_);
                CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzz_ = this.Denominator_Identification_Period(context);
                bool? pzzzzzzzzzzzzzzza_ = context.Operators.In<CqlDateTime>(ozzzzzzzzzzzzzzzy_, ozzzzzzzzzzzzzzzz_, default);
                bool? pzzzzzzzzzzzzzzzb_ = context.Operators.And(ozzzzzzzzzzzzzzzv_, pzzzzzzzzzzzzzzza_);
                Code<Encounter.EncounterStatus> pzzzzzzzzzzzzzzzc_ = ValidEncounter?.StatusElement;
                Encounter.EncounterStatus? pzzzzzzzzzzzzzzzd_ = pzzzzzzzzzzzzzzzc_?.Value;
                Code<Encounter.EncounterStatus> pzzzzzzzzzzzzzzze_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(pzzzzzzzzzzzzzzzd_);
                bool? pzzzzzzzzzzzzzzzf_ = context.Operators.Equal(pzzzzzzzzzzzzzzze_, "finished");
                bool? pzzzzzzzzzzzzzzzg_ = context.Operators.And(pzzzzzzzzzzzzzzzb_, pzzzzzzzzzzzzzzzf_);

                return pzzzzzzzzzzzzzzzg_;
            };
            IEnumerable<Condition> ozzzzzzzzzzzzzzzp_ = context.Operators.Where<Condition>(ozzzzzzzzzzzzzzzn_, ozzzzzzzzzzzzzzzo_);
            Encounter ozzzzzzzzzzzzzzzq_(Condition Depression) =>
                ValidEncounter;
            IEnumerable<Encounter> ozzzzzzzzzzzzzzzr_ = context.Operators.Select<Condition, Encounter>(ozzzzzzzzzzzzzzzp_, ozzzzzzzzzzzzzzzq_);

            return ozzzzzzzzzzzzzzzr_;
        };
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzm_ = context.Operators.SelectMany<Encounter, Encounter>(ozzzzzzzzzzzzzzzk_, ozzzzzzzzzzzzzzzl_);

        return ozzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Index Depression Assessment")]
    public Observation Index_Depression_Assessment(CqlContext context)
    {
        IEnumerable<Observation> pzzzzzzzzzzzzzzzh_ = this.Depression_Assessments_Greater_than_9(context);
        IEnumerable<Observation> pzzzzzzzzzzzzzzzi_(Observation DepressionAssessment)
        {
            IEnumerable<Encounter> pzzzzzzzzzzzzzzzn_ = this.Depression_Encounter(context);
            bool? pzzzzzzzzzzzzzzzo_(Encounter DepressionEncounter)
            {
                Period pzzzzzzzzzzzzzzzs_ = DepressionEncounter?.Period;
                CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzzzzzzzzzzzs_);
                CqlDateTime pzzzzzzzzzzzzzzzu_ = context.Operators.Start(pzzzzzzzzzzzzzzzt_);
                CqlQuantity pzzzzzzzzzzzzzzzv_ = context.Operators.Quantity(7m, "days");
                CqlDateTime pzzzzzzzzzzzzzzzw_ = context.Operators.Subtract(pzzzzzzzzzzzzzzzu_, pzzzzzzzzzzzzzzzv_);
                CqlDate pzzzzzzzzzzzzzzzx_ = context.Operators.ConvertDateTimeToDate(pzzzzzzzzzzzzzzzw_);
                CqlDateTime pzzzzzzzzzzzzzzzy_ = context.Operators.ConvertDateToDateTime(pzzzzzzzzzzzzzzzx_);
                CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzzzzzzzzzzzs_);
                CqlDateTime qzzzzzzzzzzzzzzzb_ = context.Operators.End(qzzzzzzzzzzzzzzza_);
                CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzc_ = context.Operators.Interval(pzzzzzzzzzzzzzzzy_, qzzzzzzzzzzzzzzzb_, true, true);
                DataType qzzzzzzzzzzzzzzzd_ = DepressionAssessment?.Effective;
                object qzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzd_);
                CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.toInterval(context, qzzzzzzzzzzzzzzze_);
                bool? qzzzzzzzzzzzzzzzg_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(qzzzzzzzzzzzzzzzc_, qzzzzzzzzzzzzzzzf_, "day");

                return qzzzzzzzzzzzzzzzg_;
            };
            IEnumerable<Encounter> pzzzzzzzzzzzzzzzp_ = context.Operators.Where<Encounter>(pzzzzzzzzzzzzzzzn_, pzzzzzzzzzzzzzzzo_);
            Observation pzzzzzzzzzzzzzzzq_(Encounter DepressionEncounter) =>
                DepressionAssessment;
            IEnumerable<Observation> pzzzzzzzzzzzzzzzr_ = context.Operators.Select<Encounter, Observation>(pzzzzzzzzzzzzzzzp_, pzzzzzzzzzzzzzzzq_);

            return pzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<Observation> pzzzzzzzzzzzzzzzj_ = context.Operators.SelectMany<Observation, Observation>(pzzzzzzzzzzzzzzzh_, pzzzzzzzzzzzzzzzi_);
        object pzzzzzzzzzzzzzzzk_(Observation @this)
        {
            DataType qzzzzzzzzzzzzzzzh_ = @this?.Effective;
            object qzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzh_);
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.toInterval(context, qzzzzzzzzzzzzzzzi_);
            CqlDateTime qzzzzzzzzzzzzzzzk_ = context.Operators.Start(qzzzzzzzzzzzzzzzj_);

            return qzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<Observation> pzzzzzzzzzzzzzzzl_ = context.Operators.SortBy<Observation>(pzzzzzzzzzzzzzzzj_, pzzzzzzzzzzzzzzzk_, System.ComponentModel.ListSortDirection.Ascending);
        Observation pzzzzzzzzzzzzzzzm_ = context.Operators.First<Observation>(pzzzzzzzzzzzzzzzl_);

        return pzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient qzzzzzzzzzzzzzzzl_ = this.Patient(context);
        Date qzzzzzzzzzzzzzzzm_ = qzzzzzzzzzzzzzzzl_?.BirthDateElement;
        string qzzzzzzzzzzzzzzzn_ = qzzzzzzzzzzzzzzzm_?.Value;
        CqlDateTime qzzzzzzzzzzzzzzzo_ = context.Operators.ConvertStringToDateTime(qzzzzzzzzzzzzzzzn_);
        Observation qzzzzzzzzzzzzzzzp_ = this.Index_Depression_Assessment(context);
        DataType qzzzzzzzzzzzzzzzq_ = qzzzzzzzzzzzzzzzp_?.Effective;
        object qzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzq_);
        CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.toInterval(context, qzzzzzzzzzzzzzzzr_);
        CqlDateTime qzzzzzzzzzzzzzzzt_ = context.Operators.Start(qzzzzzzzzzzzzzzzs_);
        int? qzzzzzzzzzzzzzzzu_ = context.Operators.CalculateAgeAt(qzzzzzzzzzzzzzzzo_, qzzzzzzzzzzzzzzzt_, "year");
        bool? qzzzzzzzzzzzzzzzv_ = context.Operators.GreaterOrEqual(qzzzzzzzzzzzzzzzu_, 12);

        return qzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? qzzzzzzzzzzzzzzzw_ = this.Initial_Population(context);

        return qzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Measure Assessment Period")]
    public CqlInterval<CqlDate> Measure_Assessment_Period(CqlContext context)
    {
        Observation qzzzzzzzzzzzzzzzx_ = this.Index_Depression_Assessment(context);
        Observation[] qzzzzzzzzzzzzzzzy_ = [
            qzzzzzzzzzzzzzzzx_,
        ];
        CqlInterval<CqlDate> qzzzzzzzzzzzzzzzz_(Observation FirstIndexAssessment)
        {
            DataType rzzzzzzzzzzzzzzzd_ = FirstIndexAssessment?.Effective;
            object rzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzd_);
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.toInterval(context, rzzzzzzzzzzzzzzze_);
            CqlDateTime rzzzzzzzzzzzzzzzg_ = context.Operators.Start(rzzzzzzzzzzzzzzzf_);
            CqlDate rzzzzzzzzzzzzzzzh_ = context.Operators.DateFrom(rzzzzzzzzzzzzzzzg_);
            CqlQuantity rzzzzzzzzzzzzzzzi_ = context.Operators.Quantity(12m, "months");
            CqlDate rzzzzzzzzzzzzzzzj_ = context.Operators.Add(rzzzzzzzzzzzzzzzh_, rzzzzzzzzzzzzzzzi_);
            CqlQuantity rzzzzzzzzzzzzzzzk_ = context.Operators.Quantity(60m, "days");
            CqlDate rzzzzzzzzzzzzzzzl_ = context.Operators.Subtract(rzzzzzzzzzzzzzzzj_, rzzzzzzzzzzzzzzzk_);
            object rzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzd_);
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.toInterval(context, rzzzzzzzzzzzzzzzn_);
            CqlDateTime rzzzzzzzzzzzzzzzp_ = context.Operators.Start(rzzzzzzzzzzzzzzzo_);
            CqlDate rzzzzzzzzzzzzzzzq_ = context.Operators.DateFrom(rzzzzzzzzzzzzzzzp_);
            CqlDate rzzzzzzzzzzzzzzzs_ = context.Operators.Add(rzzzzzzzzzzzzzzzq_, rzzzzzzzzzzzzzzzi_);
            CqlDate rzzzzzzzzzzzzzzzu_ = context.Operators.Add(rzzzzzzzzzzzzzzzs_, rzzzzzzzzzzzzzzzk_);
            CqlInterval<CqlDate> rzzzzzzzzzzzzzzzv_ = context.Operators.Interval(rzzzzzzzzzzzzzzzl_, rzzzzzzzzzzzzzzzu_, true, true);

            return rzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<CqlInterval<CqlDate>> rzzzzzzzzzzzzzzza_ = context.Operators.Select<Observation, CqlInterval<CqlDate>>((IEnumerable<Observation>)qzzzzzzzzzzzzzzzy_, qzzzzzzzzzzzzzzzz_);
        IEnumerable<CqlInterval<CqlDate>> rzzzzzzzzzzzzzzzb_ = context.Operators.Distinct<CqlInterval<CqlDate>>(rzzzzzzzzzzzzzzza_);
        CqlInterval<CqlDate> rzzzzzzzzzzzzzzzc_ = context.Operators.SingletonFrom<CqlInterval<CqlDate>>(rzzzzzzzzzzzzzzzb_);

        return rzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Has Hospice Services in the Measure Assessment Period")]
    public bool? Has_Hospice_Services_in_the_Measure_Assessment_Period(CqlContext context)
    {
        CqlValueSet rzzzzzzzzzzzzzzzw_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? rzzzzzzzzzzzzzzzy_(Encounter InpatientEncounter)
        {
            Encounter.HospitalizationComponent tzzzzzzzzzzzzzzzg_ = InpatientEncounter?.Hospitalization;
            CodeableConcept tzzzzzzzzzzzzzzzh_ = tzzzzzzzzzzzzzzzg_?.DischargeDisposition;
            CqlConcept tzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, tzzzzzzzzzzzzzzzh_);
            CqlCode tzzzzzzzzzzzzzzzj_ = this.Discharge_to_home_for_hospice_care__procedure_(context);
            CqlConcept tzzzzzzzzzzzzzzzk_ = context.Operators.ConvertCodeToConcept(tzzzzzzzzzzzzzzzj_);
            bool? tzzzzzzzzzzzzzzzl_ = context.Operators.Equivalent(tzzzzzzzzzzzzzzzi_, tzzzzzzzzzzzzzzzk_);
            CodeableConcept tzzzzzzzzzzzzzzzn_ = tzzzzzzzzzzzzzzzg_?.DischargeDisposition;
            CqlConcept tzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, tzzzzzzzzzzzzzzzn_);
            CqlCode tzzzzzzzzzzzzzzzp_ = this.Discharge_to_healthcare_facility_for_hospice_care__procedure_(context);
            CqlConcept tzzzzzzzzzzzzzzzq_ = context.Operators.ConvertCodeToConcept(tzzzzzzzzzzzzzzzp_);
            bool? tzzzzzzzzzzzzzzzr_ = context.Operators.Equivalent(tzzzzzzzzzzzzzzzo_, tzzzzzzzzzzzzzzzq_);
            bool? tzzzzzzzzzzzzzzzs_ = context.Operators.Or(tzzzzzzzzzzzzzzzl_, tzzzzzzzzzzzzzzzr_);
            Period tzzzzzzzzzzzzzzzt_ = InpatientEncounter?.Period;
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzzzzzzzzzzzzt_);
            CqlDateTime tzzzzzzzzzzzzzzzv_ = context.Operators.End(tzzzzzzzzzzzzzzzu_);
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzw_ = this.Denominator_Identification_Period(context);
            CqlDateTime tzzzzzzzzzzzzzzzx_ = context.Operators.Start(tzzzzzzzzzzzzzzzw_);
            CqlInterval<CqlDate> tzzzzzzzzzzzzzzzy_ = this.Measure_Assessment_Period(context);
            CqlDate tzzzzzzzzzzzzzzzz_ = context.Operators.End(tzzzzzzzzzzzzzzzy_);
            CqlDateTime uzzzzzzzzzzzzzzza_ = context.Operators.ConvertDateToDateTime(tzzzzzzzzzzzzzzzz_);
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzb_ = context.Operators.Interval(tzzzzzzzzzzzzzzzx_, uzzzzzzzzzzzzzzza_, true, true);
            bool? uzzzzzzzzzzzzzzzc_ = context.Operators.In<CqlDateTime>(tzzzzzzzzzzzzzzzv_, uzzzzzzzzzzzzzzzb_, "day");
            bool? uzzzzzzzzzzzzzzzd_ = context.Operators.And(tzzzzzzzzzzzzzzzs_, uzzzzzzzzzzzzzzzc_);
            Code<Encounter.EncounterStatus> uzzzzzzzzzzzzzzze_ = InpatientEncounter?.StatusElement;
            Encounter.EncounterStatus? uzzzzzzzzzzzzzzzf_ = uzzzzzzzzzzzzzzze_?.Value;
            Code<Encounter.EncounterStatus> uzzzzzzzzzzzzzzzg_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(uzzzzzzzzzzzzzzzf_);
            bool? uzzzzzzzzzzzzzzzh_ = context.Operators.Equal(uzzzzzzzzzzzzzzzg_, "finished");
            bool? uzzzzzzzzzzzzzzzi_ = context.Operators.And(uzzzzzzzzzzzzzzzd_, uzzzzzzzzzzzzzzzh_);

            return uzzzzzzzzzzzzzzzi_;
        };
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzz_ = context.Operators.Where<Encounter>(rzzzzzzzzzzzzzzzx_, rzzzzzzzzzzzzzzzy_);
        bool? szzzzzzzzzzzzzzza_ = context.Operators.Exists<Encounter>(rzzzzzzzzzzzzzzzz_);
        CqlValueSet szzzzzzzzzzzzzzzb_ = this.Hospice_Encounter(context);
        IEnumerable<Encounter> szzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, szzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? szzzzzzzzzzzzzzzd_(Encounter HospiceEncounter)
        {
            Period uzzzzzzzzzzzzzzzj_ = HospiceEncounter?.Period;
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzzzzzzzzzzzj_);
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzl_ = this.Denominator_Identification_Period(context);
            CqlDateTime uzzzzzzzzzzzzzzzm_ = context.Operators.Start(uzzzzzzzzzzzzzzzl_);
            CqlInterval<CqlDate> uzzzzzzzzzzzzzzzn_ = this.Measure_Assessment_Period(context);
            CqlDate uzzzzzzzzzzzzzzzo_ = context.Operators.End(uzzzzzzzzzzzzzzzn_);
            CqlDateTime uzzzzzzzzzzzzzzzp_ = context.Operators.ConvertDateToDateTime(uzzzzzzzzzzzzzzzo_);
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzq_ = context.Operators.Interval(uzzzzzzzzzzzzzzzm_, uzzzzzzzzzzzzzzzp_, true, true);
            bool? uzzzzzzzzzzzzzzzr_ = context.Operators.Overlaps(uzzzzzzzzzzzzzzzk_, uzzzzzzzzzzzzzzzq_, "day");
            Code<Encounter.EncounterStatus> uzzzzzzzzzzzzzzzs_ = HospiceEncounter?.StatusElement;
            Encounter.EncounterStatus? uzzzzzzzzzzzzzzzt_ = uzzzzzzzzzzzzzzzs_?.Value;
            Code<Encounter.EncounterStatus> uzzzzzzzzzzzzzzzu_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(uzzzzzzzzzzzzzzzt_);
            string uzzzzzzzzzzzzzzzv_ = context.Operators.Convert<string>(uzzzzzzzzzzzzzzzu_);
            string[] uzzzzzzzzzzzzzzzw_ = [
                "cancelled",
                "entered-in-error",
                "unknown",
            ];
            bool? uzzzzzzzzzzzzzzzx_ = context.Operators.In<string>(uzzzzzzzzzzzzzzzv_, uzzzzzzzzzzzzzzzw_ as IEnumerable<string>);
            bool? uzzzzzzzzzzzzzzzy_ = context.Operators.Not(uzzzzzzzzzzzzzzzx_);
            bool? uzzzzzzzzzzzzzzzz_ = context.Operators.And(uzzzzzzzzzzzzzzzr_, uzzzzzzzzzzzzzzzy_);

            return uzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<Encounter> szzzzzzzzzzzzzzze_ = context.Operators.Where<Encounter>(szzzzzzzzzzzzzzzc_, szzzzzzzzzzzzzzzd_);
        bool? szzzzzzzzzzzzzzzf_ = context.Operators.Exists<Encounter>(szzzzzzzzzzzzzzze_);
        bool? szzzzzzzzzzzzzzzg_ = context.Operators.Or(szzzzzzzzzzzzzzza_, szzzzzzzzzzzzzzzf_);
        CqlCode szzzzzzzzzzzzzzzh_ = this.Hospice_care__Minimum_Data_Set_(context);
        IEnumerable<CqlCode> szzzzzzzzzzzzzzzi_ = context.Operators.ToList<CqlCode>(szzzzzzzzzzzzzzzh_);
        IEnumerable<Observation> szzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, szzzzzzzzzzzzzzzi_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? szzzzzzzzzzzzzzzk_(Observation HospiceAssessment)
        {
            DataType vzzzzzzzzzzzzzzza_ = HospiceAssessment?.Value;
            object vzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzza_);
            CqlCode vzzzzzzzzzzzzzzzc_ = this.Yes__qualifier_value_(context);
            CqlConcept vzzzzzzzzzzzzzzzd_ = context.Operators.ConvertCodeToConcept(vzzzzzzzzzzzzzzzc_);
            bool? vzzzzzzzzzzzzzzze_ = context.Operators.Equivalent(vzzzzzzzzzzzzzzzb_ as CqlConcept, vzzzzzzzzzzzzzzzd_);
            DataType vzzzzzzzzzzzzzzzf_ = HospiceAssessment?.Effective;
            object vzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzf_);
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.toInterval(context, vzzzzzzzzzzzzzzzg_);
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzi_ = this.Denominator_Identification_Period(context);
            CqlDateTime vzzzzzzzzzzzzzzzj_ = context.Operators.Start(vzzzzzzzzzzzzzzzi_);
            CqlInterval<CqlDate> vzzzzzzzzzzzzzzzk_ = this.Measure_Assessment_Period(context);
            CqlDate vzzzzzzzzzzzzzzzl_ = context.Operators.End(vzzzzzzzzzzzzzzzk_);
            CqlDateTime vzzzzzzzzzzzzzzzm_ = context.Operators.ConvertDateToDateTime(vzzzzzzzzzzzzzzzl_);
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzn_ = context.Operators.Interval(vzzzzzzzzzzzzzzzj_, vzzzzzzzzzzzzzzzm_, true, true);
            bool? vzzzzzzzzzzzzzzzo_ = context.Operators.Overlaps(vzzzzzzzzzzzzzzzh_, vzzzzzzzzzzzzzzzn_, "day");
            bool? vzzzzzzzzzzzzzzzp_ = context.Operators.And(vzzzzzzzzzzzzzzze_, vzzzzzzzzzzzzzzzo_);
            Code<ObservationStatus> vzzzzzzzzzzzzzzzq_ = HospiceAssessment?.StatusElement;
            ObservationStatus? vzzzzzzzzzzzzzzzr_ = vzzzzzzzzzzzzzzzq_?.Value;
            Code<ObservationStatus> vzzzzzzzzzzzzzzzs_ = context.Operators.Convert<Code<ObservationStatus>>(vzzzzzzzzzzzzzzzr_);
            string vzzzzzzzzzzzzzzzt_ = context.Operators.Convert<string>(vzzzzzzzzzzzzzzzs_);
            string[] vzzzzzzzzzzzzzzzu_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? vzzzzzzzzzzzzzzzv_ = context.Operators.In<string>(vzzzzzzzzzzzzzzzt_, vzzzzzzzzzzzzzzzu_ as IEnumerable<string>);
            bool? vzzzzzzzzzzzzzzzw_ = context.Operators.And(vzzzzzzzzzzzzzzzp_, vzzzzzzzzzzzzzzzv_);

            return vzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<Observation> szzzzzzzzzzzzzzzl_ = context.Operators.Where<Observation>(szzzzzzzzzzzzzzzj_, szzzzzzzzzzzzzzzk_);
        bool? szzzzzzzzzzzzzzzm_ = context.Operators.Exists<Observation>(szzzzzzzzzzzzzzzl_);
        bool? szzzzzzzzzzzzzzzn_ = context.Operators.Or(szzzzzzzzzzzzzzzg_, szzzzzzzzzzzzzzzm_);
        CqlValueSet szzzzzzzzzzzzzzzo_ = this.Hospice_Care_Ambulatory(context);
        IEnumerable<ServiceRequest> szzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, szzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        bool? szzzzzzzzzzzzzzzq_(ServiceRequest HospiceOrder)
        {
            FhirDateTime vzzzzzzzzzzzzzzzx_ = HospiceOrder?.AuthoredOnElement;
            CqlDateTime vzzzzzzzzzzzzzzzy_ = context.Operators.Convert<CqlDateTime>(vzzzzzzzzzzzzzzzx_);
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzz_ = this.Denominator_Identification_Period(context);
            CqlDateTime wzzzzzzzzzzzzzzza_ = context.Operators.Start(vzzzzzzzzzzzzzzzz_);
            CqlInterval<CqlDate> wzzzzzzzzzzzzzzzb_ = this.Measure_Assessment_Period(context);
            CqlDate wzzzzzzzzzzzzzzzc_ = context.Operators.End(wzzzzzzzzzzzzzzzb_);
            CqlDateTime wzzzzzzzzzzzzzzzd_ = context.Operators.ConvertDateToDateTime(wzzzzzzzzzzzzzzzc_);
            CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzze_ = context.Operators.Interval(wzzzzzzzzzzzzzzza_, wzzzzzzzzzzzzzzzd_, true, true);
            bool? wzzzzzzzzzzzzzzzf_ = context.Operators.In<CqlDateTime>(vzzzzzzzzzzzzzzzy_, wzzzzzzzzzzzzzzze_, "day");
            Code<RequestStatus> wzzzzzzzzzzzzzzzg_ = HospiceOrder?.StatusElement;
            RequestStatus? wzzzzzzzzzzzzzzzh_ = wzzzzzzzzzzzzzzzg_?.Value;
            Code<RequestStatus> wzzzzzzzzzzzzzzzi_ = context.Operators.Convert<Code<RequestStatus>>(wzzzzzzzzzzzzzzzh_);
            string wzzzzzzzzzzzzzzzj_ = context.Operators.Convert<string>(wzzzzzzzzzzzzzzzi_);
            string[] wzzzzzzzzzzzzzzzk_ = [
                "active",
                "completed",
            ];
            bool? wzzzzzzzzzzzzzzzl_ = context.Operators.In<string>(wzzzzzzzzzzzzzzzj_, wzzzzzzzzzzzzzzzk_ as IEnumerable<string>);
            bool? wzzzzzzzzzzzzzzzm_ = context.Operators.And(wzzzzzzzzzzzzzzzf_, wzzzzzzzzzzzzzzzl_);
            Code<RequestIntent> wzzzzzzzzzzzzzzzn_ = HospiceOrder?.IntentElement;
            RequestIntent? wzzzzzzzzzzzzzzzo_ = wzzzzzzzzzzzzzzzn_?.Value;
            Code<RequestIntent> wzzzzzzzzzzzzzzzp_ = context.Operators.Convert<Code<RequestIntent>>(wzzzzzzzzzzzzzzzo_);
            string wzzzzzzzzzzzzzzzq_ = context.Operators.Convert<string>(wzzzzzzzzzzzzzzzp_);
            string[] wzzzzzzzzzzzzzzzr_ = [
                "order",
                "original-order",
                "reflex-order",
                "filler-order",
                "instance-order",
            ];
            bool? wzzzzzzzzzzzzzzzs_ = context.Operators.In<string>(wzzzzzzzzzzzzzzzq_, wzzzzzzzzzzzzzzzr_ as IEnumerable<string>);
            bool? wzzzzzzzzzzzzzzzt_ = context.Operators.And(wzzzzzzzzzzzzzzzm_, wzzzzzzzzzzzzzzzs_);
            FhirBoolean wzzzzzzzzzzzzzzzu_ = HospiceOrder?.DoNotPerformElement;
            bool? wzzzzzzzzzzzzzzzv_ = wzzzzzzzzzzzzzzzu_?.Value;
            bool? wzzzzzzzzzzzzzzzw_ = context.Operators.IsTrue(wzzzzzzzzzzzzzzzv_);
            bool? wzzzzzzzzzzzzzzzx_ = context.Operators.Not(wzzzzzzzzzzzzzzzw_);
            bool? wzzzzzzzzzzzzzzzy_ = context.Operators.And(wzzzzzzzzzzzzzzzt_, wzzzzzzzzzzzzzzzx_);

            return wzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<ServiceRequest> szzzzzzzzzzzzzzzr_ = context.Operators.Where<ServiceRequest>(szzzzzzzzzzzzzzzp_, szzzzzzzzzzzzzzzq_);
        bool? szzzzzzzzzzzzzzzs_ = context.Operators.Exists<ServiceRequest>(szzzzzzzzzzzzzzzr_);
        bool? szzzzzzzzzzzzzzzt_ = context.Operators.Or(szzzzzzzzzzzzzzzn_, szzzzzzzzzzzzzzzs_);
        IEnumerable<Procedure> szzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, szzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        bool? szzzzzzzzzzzzzzzw_(Procedure HospicePerformed)
        {
            DataType wzzzzzzzzzzzzzzzz_ = HospicePerformed?.Performed;
            object xzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzz_);
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.toInterval(context, xzzzzzzzzzzzzzzza_);
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzc_ = this.Denominator_Identification_Period(context);
            CqlDateTime xzzzzzzzzzzzzzzzd_ = context.Operators.Start(xzzzzzzzzzzzzzzzc_);
            CqlInterval<CqlDate> xzzzzzzzzzzzzzzze_ = this.Measure_Assessment_Period(context);
            CqlDate xzzzzzzzzzzzzzzzf_ = context.Operators.End(xzzzzzzzzzzzzzzze_);
            CqlDateTime xzzzzzzzzzzzzzzzg_ = context.Operators.ConvertDateToDateTime(xzzzzzzzzzzzzzzzf_);
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzh_ = context.Operators.Interval(xzzzzzzzzzzzzzzzd_, xzzzzzzzzzzzzzzzg_, true, true);
            bool? xzzzzzzzzzzzzzzzi_ = context.Operators.Overlaps(xzzzzzzzzzzzzzzzb_, xzzzzzzzzzzzzzzzh_, "day");
            Code<EventStatus> xzzzzzzzzzzzzzzzj_ = HospicePerformed?.StatusElement;
            EventStatus? xzzzzzzzzzzzzzzzk_ = xzzzzzzzzzzzzzzzj_?.Value;
            string xzzzzzzzzzzzzzzzl_ = context.Operators.Convert<string>(xzzzzzzzzzzzzzzzk_);
            string[] xzzzzzzzzzzzzzzzm_ = [
                "not-done",
                "entered-in-error",
                "unknown",
            ];
            bool? xzzzzzzzzzzzzzzzn_ = context.Operators.In<string>(xzzzzzzzzzzzzzzzl_, xzzzzzzzzzzzzzzzm_ as IEnumerable<string>);
            bool? xzzzzzzzzzzzzzzzo_ = context.Operators.Not(xzzzzzzzzzzzzzzzn_);
            bool? xzzzzzzzzzzzzzzzp_ = context.Operators.And(xzzzzzzzzzzzzzzzi_, xzzzzzzzzzzzzzzzo_);

            return xzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<Procedure> szzzzzzzzzzzzzzzx_ = context.Operators.Where<Procedure>(szzzzzzzzzzzzzzzv_, szzzzzzzzzzzzzzzw_);
        bool? szzzzzzzzzzzzzzzy_ = context.Operators.Exists<Procedure>(szzzzzzzzzzzzzzzx_);
        bool? szzzzzzzzzzzzzzzz_ = context.Operators.Or(szzzzzzzzzzzzzzzt_, szzzzzzzzzzzzzzzy_);
        CqlValueSet tzzzzzzzzzzzzzzza_ = this.Hospice_Diagnosis(context);
        IEnumerable<Condition> tzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, tzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? tzzzzzzzzzzzzzzzc_(Condition HospiceCareDiagnosis)
        {
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, HospiceCareDiagnosis);
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzr_ = this.Denominator_Identification_Period(context);
            CqlDateTime xzzzzzzzzzzzzzzzs_ = context.Operators.Start(xzzzzzzzzzzzzzzzr_);
            CqlInterval<CqlDate> xzzzzzzzzzzzzzzzt_ = this.Measure_Assessment_Period(context);
            CqlDate xzzzzzzzzzzzzzzzu_ = context.Operators.End(xzzzzzzzzzzzzzzzt_);
            CqlDateTime xzzzzzzzzzzzzzzzv_ = context.Operators.ConvertDateToDateTime(xzzzzzzzzzzzzzzzu_);
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzw_ = context.Operators.Interval(xzzzzzzzzzzzzzzzs_, xzzzzzzzzzzzzzzzv_, true, true);
            bool? xzzzzzzzzzzzzzzzx_ = context.Operators.Overlaps(xzzzzzzzzzzzzzzzq_, xzzzzzzzzzzzzzzzw_, "day");
            bool? xzzzzzzzzzzzzzzzy_ = this.isConfirmedActiveDiagnosis(context, HospiceCareDiagnosis);
            bool? xzzzzzzzzzzzzzzzz_ = context.Operators.And(xzzzzzzzzzzzzzzzx_, xzzzzzzzzzzzzzzzy_);

            return xzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<Condition> tzzzzzzzzzzzzzzzd_ = context.Operators.Where<Condition>(tzzzzzzzzzzzzzzzb_, tzzzzzzzzzzzzzzzc_);
        bool? tzzzzzzzzzzzzzzze_ = context.Operators.Exists<Condition>(tzzzzzzzzzzzzzzzd_);
        bool? tzzzzzzzzzzzzzzzf_ = context.Operators.Or(szzzzzzzzzzzzzzzz_, tzzzzzzzzzzzzzzze_);

        return tzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Has Palliative Care in the Measure Assessment Period")]
    public bool? Has_Palliative_Care_in_the_Measure_Assessment_Period(CqlContext context)
    {
        CqlCode yzzzzzzzzzzzzzzza_ = this.Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal_(context);
        IEnumerable<CqlCode> yzzzzzzzzzzzzzzzb_ = context.Operators.ToList<CqlCode>(yzzzzzzzzzzzzzzza_);
        IEnumerable<Observation> yzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, yzzzzzzzzzzzzzzzb_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? yzzzzzzzzzzzzzzzd_(Observation PalliativeAssessment)
        {
            DataType yzzzzzzzzzzzzzzzy_ = PalliativeAssessment?.Effective;
            object yzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzy_);
            CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.toInterval(context, yzzzzzzzzzzzzzzzz_);
            CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzb_ = this.Denominator_Identification_Period(context);
            CqlDateTime zzzzzzzzzzzzzzzzc_ = context.Operators.Start(zzzzzzzzzzzzzzzzb_);
            CqlInterval<CqlDate> zzzzzzzzzzzzzzzzd_ = this.Measure_Assessment_Period(context);
            CqlDate zzzzzzzzzzzzzzzze_ = context.Operators.End(zzzzzzzzzzzzzzzzd_);
            CqlDateTime zzzzzzzzzzzzzzzzf_ = context.Operators.ConvertDateToDateTime(zzzzzzzzzzzzzzzze_);
            CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzg_ = context.Operators.Interval(zzzzzzzzzzzzzzzzc_, zzzzzzzzzzzzzzzzf_, true, true);
            bool? zzzzzzzzzzzzzzzzh_ = context.Operators.Overlaps(zzzzzzzzzzzzzzzza_, zzzzzzzzzzzzzzzzg_, default);
            Code<ObservationStatus> zzzzzzzzzzzzzzzzi_ = PalliativeAssessment?.StatusElement;
            ObservationStatus? zzzzzzzzzzzzzzzzj_ = zzzzzzzzzzzzzzzzi_?.Value;
            Code<ObservationStatus> zzzzzzzzzzzzzzzzk_ = context.Operators.Convert<Code<ObservationStatus>>(zzzzzzzzzzzzzzzzj_);
            string zzzzzzzzzzzzzzzzl_ = context.Operators.Convert<string>(zzzzzzzzzzzzzzzzk_);
            string[] zzzzzzzzzzzzzzzzm_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? zzzzzzzzzzzzzzzzn_ = context.Operators.In<string>(zzzzzzzzzzzzzzzzl_, zzzzzzzzzzzzzzzzm_ as IEnumerable<string>);
            bool? zzzzzzzzzzzzzzzzo_ = context.Operators.And(zzzzzzzzzzzzzzzzh_, zzzzzzzzzzzzzzzzn_);

            return zzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<Observation> yzzzzzzzzzzzzzzze_ = context.Operators.Where<Observation>(yzzzzzzzzzzzzzzzc_, yzzzzzzzzzzzzzzzd_);
        bool? yzzzzzzzzzzzzzzzf_ = context.Operators.Exists<Observation>(yzzzzzzzzzzzzzzze_);
        CqlValueSet yzzzzzzzzzzzzzzzg_ = this.Palliative_Care_Diagnosis(context);
        IEnumerable<Condition> yzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? yzzzzzzzzzzzzzzzi_(Condition PalliativeDiagnosis)
        {
            CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, PalliativeDiagnosis);
            CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzq_ = this.Denominator_Identification_Period(context);
            CqlDateTime zzzzzzzzzzzzzzzzr_ = context.Operators.Start(zzzzzzzzzzzzzzzzq_);
            CqlInterval<CqlDate> zzzzzzzzzzzzzzzzs_ = this.Measure_Assessment_Period(context);
            CqlDate zzzzzzzzzzzzzzzzt_ = context.Operators.End(zzzzzzzzzzzzzzzzs_);
            CqlDateTime zzzzzzzzzzzzzzzzu_ = context.Operators.ConvertDateToDateTime(zzzzzzzzzzzzzzzzt_);
            CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzv_ = context.Operators.Interval(zzzzzzzzzzzzzzzzr_, zzzzzzzzzzzzzzzzu_, true, true);
            bool? zzzzzzzzzzzzzzzzw_ = context.Operators.Overlaps(zzzzzzzzzzzzzzzzp_, zzzzzzzzzzzzzzzzv_, default);
            bool? zzzzzzzzzzzzzzzzx_ = this.isConfirmedActiveDiagnosis(context, PalliativeDiagnosis);
            bool? zzzzzzzzzzzzzzzzy_ = context.Operators.And(zzzzzzzzzzzzzzzzw_, zzzzzzzzzzzzzzzzx_);

            return zzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<Condition> yzzzzzzzzzzzzzzzj_ = context.Operators.Where<Condition>(yzzzzzzzzzzzzzzzh_, yzzzzzzzzzzzzzzzi_);
        bool? yzzzzzzzzzzzzzzzk_ = context.Operators.Exists<Condition>(yzzzzzzzzzzzzzzzj_);
        bool? yzzzzzzzzzzzzzzzl_ = context.Operators.Or(yzzzzzzzzzzzzzzzf_, yzzzzzzzzzzzzzzzk_);
        CqlValueSet yzzzzzzzzzzzzzzzm_ = this.Palliative_Care_Encounter(context);
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? yzzzzzzzzzzzzzzzo_(Encounter PalliativeEncounter)
        {
            Period zzzzzzzzzzzzzzzzz_ = PalliativeEncounter?.Period;
            CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzzzzzzzzzzzz_);
            CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzb_ = this.Denominator_Identification_Period(context);
            CqlDateTime azzzzzzzzzzzzzzzzc_ = context.Operators.Start(azzzzzzzzzzzzzzzzb_);
            CqlInterval<CqlDate> azzzzzzzzzzzzzzzzd_ = this.Measure_Assessment_Period(context);
            CqlDate azzzzzzzzzzzzzzzze_ = context.Operators.End(azzzzzzzzzzzzzzzzd_);
            CqlDateTime azzzzzzzzzzzzzzzzf_ = context.Operators.ConvertDateToDateTime(azzzzzzzzzzzzzzzze_);
            CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzg_ = context.Operators.Interval(azzzzzzzzzzzzzzzzc_, azzzzzzzzzzzzzzzzf_, true, true);
            bool? azzzzzzzzzzzzzzzzh_ = context.Operators.Overlaps(azzzzzzzzzzzzzzzza_, azzzzzzzzzzzzzzzzg_, default);
            Code<Encounter.EncounterStatus> azzzzzzzzzzzzzzzzi_ = PalliativeEncounter?.StatusElement;
            Encounter.EncounterStatus? azzzzzzzzzzzzzzzzj_ = azzzzzzzzzzzzzzzzi_?.Value;
            Code<Encounter.EncounterStatus> azzzzzzzzzzzzzzzzk_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(azzzzzzzzzzzzzzzzj_);
            bool? azzzzzzzzzzzzzzzzl_ = context.Operators.Equal(azzzzzzzzzzzzzzzzk_, "finished");
            bool? azzzzzzzzzzzzzzzzm_ = context.Operators.And(azzzzzzzzzzzzzzzzh_, azzzzzzzzzzzzzzzzl_);

            return azzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzp_ = context.Operators.Where<Encounter>(yzzzzzzzzzzzzzzzn_, yzzzzzzzzzzzzzzzo_);
        bool? yzzzzzzzzzzzzzzzq_ = context.Operators.Exists<Encounter>(yzzzzzzzzzzzzzzzp_);
        bool? yzzzzzzzzzzzzzzzr_ = context.Operators.Or(yzzzzzzzzzzzzzzzl_, yzzzzzzzzzzzzzzzq_);
        CqlValueSet yzzzzzzzzzzzzzzzs_ = this.Palliative_Care_Intervention(context);
        IEnumerable<Procedure> yzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        bool? yzzzzzzzzzzzzzzzu_(Procedure PalliativeIntervention)
        {
            DataType azzzzzzzzzzzzzzzzn_ = PalliativeIntervention?.Performed;
            object azzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzn_);
            CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.toInterval(context, azzzzzzzzzzzzzzzzo_);
            CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzq_ = this.Denominator_Identification_Period(context);
            CqlDateTime azzzzzzzzzzzzzzzzr_ = context.Operators.Start(azzzzzzzzzzzzzzzzq_);
            CqlInterval<CqlDate> azzzzzzzzzzzzzzzzs_ = this.Measure_Assessment_Period(context);
            CqlDate azzzzzzzzzzzzzzzzt_ = context.Operators.End(azzzzzzzzzzzzzzzzs_);
            CqlDateTime azzzzzzzzzzzzzzzzu_ = context.Operators.ConvertDateToDateTime(azzzzzzzzzzzzzzzzt_);
            CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzv_ = context.Operators.Interval(azzzzzzzzzzzzzzzzr_, azzzzzzzzzzzzzzzzu_, true, true);
            bool? azzzzzzzzzzzzzzzzw_ = context.Operators.Overlaps(azzzzzzzzzzzzzzzzp_, azzzzzzzzzzzzzzzzv_, default);
            Code<EventStatus> azzzzzzzzzzzzzzzzx_ = PalliativeIntervention?.StatusElement;
            EventStatus? azzzzzzzzzzzzzzzzy_ = azzzzzzzzzzzzzzzzx_?.Value;
            string azzzzzzzzzzzzzzzzz_ = context.Operators.Convert<string>(azzzzzzzzzzzzzzzzy_);
            string[] bzzzzzzzzzzzzzzzza_ = [
                "not-done",
                "entered-in-error",
                "unknown",
            ];
            bool? bzzzzzzzzzzzzzzzzb_ = context.Operators.In<string>(azzzzzzzzzzzzzzzzz_, bzzzzzzzzzzzzzzzza_ as IEnumerable<string>);
            bool? bzzzzzzzzzzzzzzzzc_ = context.Operators.Not(bzzzzzzzzzzzzzzzzb_);
            bool? bzzzzzzzzzzzzzzzzd_ = context.Operators.And(azzzzzzzzzzzzzzzzw_, bzzzzzzzzzzzzzzzzc_);

            return bzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<Procedure> yzzzzzzzzzzzzzzzv_ = context.Operators.Where<Procedure>(yzzzzzzzzzzzzzzzt_, yzzzzzzzzzzzzzzzu_);
        bool? yzzzzzzzzzzzzzzzw_ = context.Operators.Exists<Procedure>(yzzzzzzzzzzzzzzzv_);
        bool? yzzzzzzzzzzzzzzzx_ = context.Operators.Or(yzzzzzzzzzzzzzzzr_, yzzzzzzzzzzzzzzzw_);

        return yzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Patient Expired")]
    public bool? Patient_Expired(CqlContext context)
    {
        Patient bzzzzzzzzzzzzzzzze_ = this.Patient(context);
        DataType bzzzzzzzzzzzzzzzzf_ = bzzzzzzzzzzzzzzzze_?.Deceased;
        object bzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzf_);
        CqlInterval<CqlDate> bzzzzzzzzzzzzzzzzh_ = this.Measure_Assessment_Period(context);
        CqlDate bzzzzzzzzzzzzzzzzi_ = context.Operators.End(bzzzzzzzzzzzzzzzzh_);
        CqlDateTime bzzzzzzzzzzzzzzzzj_ = context.Operators.ConvertDateToDateTime(bzzzzzzzzzzzzzzzzi_);
        bool? bzzzzzzzzzzzzzzzzk_ = context.Operators.SameOrBefore(bzzzzzzzzzzzzzzzzg_ as CqlDateTime, bzzzzzzzzzzzzzzzzj_, default);

        return bzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Has Mental Health Disorder Diagnoses")]
    public bool? Has_Mental_Health_Disorder_Diagnoses(CqlContext context)
    {
        CqlValueSet bzzzzzzzzzzzzzzzzl_ = this.Bipolar_Disorder(context);
        IEnumerable<Condition> bzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet bzzzzzzzzzzzzzzzzn_ = this.Personality_Disorder_Emotionally_Labile(context);
        IEnumerable<Condition> bzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> bzzzzzzzzzzzzzzzzp_ = context.Operators.Union<Condition>(bzzzzzzzzzzzzzzzzm_, bzzzzzzzzzzzzzzzzo_);
        CqlValueSet bzzzzzzzzzzzzzzzzq_ = this.Schizophrenia_or_Psychotic_Disorder(context);
        IEnumerable<Condition> bzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet bzzzzzzzzzzzzzzzzs_ = this.Pervasive_Developmental_Disorder(context);
        IEnumerable<Condition> bzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> bzzzzzzzzzzzzzzzzu_ = context.Operators.Union<Condition>(bzzzzzzzzzzzzzzzzr_, bzzzzzzzzzzzzzzzzt_);
        IEnumerable<Condition> bzzzzzzzzzzzzzzzzv_ = context.Operators.Union<Condition>(bzzzzzzzzzzzzzzzzp_, bzzzzzzzzzzzzzzzzu_);
        bool? bzzzzzzzzzzzzzzzzw_(Condition MentalHealthDisorderDiagnoses)
        {
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, MentalHealthDisorderDiagnoses);
            CqlDateTime czzzzzzzzzzzzzzzza_ = context.Operators.Start(bzzzzzzzzzzzzzzzzz_);
            CqlDate czzzzzzzzzzzzzzzzb_ = context.Operators.ConvertDateTimeToDate(czzzzzzzzzzzzzzzza_);
            CqlInterval<CqlDate> czzzzzzzzzzzzzzzzc_ = this.Measure_Assessment_Period(context);
            CqlDate czzzzzzzzzzzzzzzzd_ = context.Operators.End(czzzzzzzzzzzzzzzzc_);
            bool? czzzzzzzzzzzzzzzze_ = context.Operators.SameOrBefore(czzzzzzzzzzzzzzzzb_, czzzzzzzzzzzzzzzzd_, default);
            bool? czzzzzzzzzzzzzzzzf_ = this.isConfirmedActiveDiagnosis(context, MentalHealthDisorderDiagnoses);
            bool? czzzzzzzzzzzzzzzzg_ = context.Operators.And(czzzzzzzzzzzzzzzze_, czzzzzzzzzzzzzzzzf_);

            return czzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<Condition> bzzzzzzzzzzzzzzzzx_ = context.Operators.Where<Condition>(bzzzzzzzzzzzzzzzzv_, bzzzzzzzzzzzzzzzzw_);
        bool? bzzzzzzzzzzzzzzzzy_ = context.Operators.Exists<Condition>(bzzzzzzzzzzzzzzzzx_);

        return bzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? czzzzzzzzzzzzzzzzh_ = this.Has_Hospice_Services_in_the_Measure_Assessment_Period(context);
        bool? czzzzzzzzzzzzzzzzi_ = this.Has_Palliative_Care_in_the_Measure_Assessment_Period(context);
        bool? czzzzzzzzzzzzzzzzj_ = context.Operators.Or(czzzzzzzzzzzzzzzzh_, czzzzzzzzzzzzzzzzi_);
        bool? czzzzzzzzzzzzzzzzk_ = this.Patient_Expired(context);
        bool? czzzzzzzzzzzzzzzzl_ = context.Operators.Or(czzzzzzzzzzzzzzzzj_, czzzzzzzzzzzzzzzzk_);
        bool? czzzzzzzzzzzzzzzzm_ = this.Has_Mental_Health_Disorder_Diagnoses(context);
        bool? czzzzzzzzzzzzzzzzn_ = context.Operators.Or(czzzzzzzzzzzzzzzzl_, czzzzzzzzzzzzzzzzm_);

        return czzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        CqlValueSet czzzzzzzzzzzzzzzzo_ = this.PHQ_9_and_PHQ_9M_Tools(context);
        IEnumerable<Observation> czzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? czzzzzzzzzzzzzzzzq_(Observation DepressionAssessment)
        {
            DataType czzzzzzzzzzzzzzzzy_ = DepressionAssessment?.Effective;
            object czzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzy_);
            CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.toInterval(context, czzzzzzzzzzzzzzzzz_);
            CqlDateTime dzzzzzzzzzzzzzzzzb_ = context.Operators.Start(dzzzzzzzzzzzzzzzza_);
            CqlDate dzzzzzzzzzzzzzzzzc_ = context.Operators.ConvertDateTimeToDate(dzzzzzzzzzzzzzzzzb_);
            CqlInterval<CqlDate> dzzzzzzzzzzzzzzzzd_ = this.Measure_Assessment_Period(context);
            bool? dzzzzzzzzzzzzzzzze_ = context.Operators.In<CqlDate>(dzzzzzzzzzzzzzzzzc_, dzzzzzzzzzzzzzzzzd_, default);
            Code<ObservationStatus> dzzzzzzzzzzzzzzzzf_ = DepressionAssessment?.StatusElement;
            ObservationStatus? dzzzzzzzzzzzzzzzzg_ = dzzzzzzzzzzzzzzzzf_?.Value;
            Code<ObservationStatus> dzzzzzzzzzzzzzzzzh_ = context.Operators.Convert<Code<ObservationStatus>>(dzzzzzzzzzzzzzzzzg_);
            string dzzzzzzzzzzzzzzzzi_ = context.Operators.Convert<string>(dzzzzzzzzzzzzzzzzh_);
            string[] dzzzzzzzzzzzzzzzzj_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? dzzzzzzzzzzzzzzzzk_ = context.Operators.In<string>(dzzzzzzzzzzzzzzzzi_, dzzzzzzzzzzzzzzzzj_ as IEnumerable<string>);
            bool? dzzzzzzzzzzzzzzzzl_ = context.Operators.And(dzzzzzzzzzzzzzzzze_, dzzzzzzzzzzzzzzzzk_);

            return dzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<Observation> czzzzzzzzzzzzzzzzr_ = context.Operators.Where<Observation>(czzzzzzzzzzzzzzzzp_, czzzzzzzzzzzzzzzzq_);
        object czzzzzzzzzzzzzzzzs_(Observation @this)
        {
            DataType dzzzzzzzzzzzzzzzzm_ = @this?.Effective;
            object dzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzm_);
            CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.toInterval(context, dzzzzzzzzzzzzzzzzn_);
            CqlDateTime dzzzzzzzzzzzzzzzzp_ = context.Operators.Start(dzzzzzzzzzzzzzzzzo_);

            return dzzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<Observation> czzzzzzzzzzzzzzzzt_ = context.Operators.SortBy<Observation>(czzzzzzzzzzzzzzzzr_, czzzzzzzzzzzzzzzzs_, System.ComponentModel.ListSortDirection.Ascending);
        Observation czzzzzzzzzzzzzzzzu_ = context.Operators.Last<Observation>(czzzzzzzzzzzzzzzzt_);
        DataType czzzzzzzzzzzzzzzzv_ = czzzzzzzzzzzzzzzzu_?.Value;
        object czzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzv_);
        bool? czzzzzzzzzzzzzzzzx_ = context.Operators.Less(czzzzzzzzzzzzzzzzw_ as int?, 5);

        return czzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? dzzzzzzzzzzzzzzzzq_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return dzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> dzzzzzzzzzzzzzzzzr_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return dzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? dzzzzzzzzzzzzzzzzs_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return dzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode dzzzzzzzzzzzzzzzzt_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return dzzzzzzzzzzzzzzzzt_;
    }


    #endregion Expressions

}
