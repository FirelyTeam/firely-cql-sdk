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
[CqlLibrary("PCSBPScreeningFollowUpFHIR", "0.2.000")]
public partial class PCSBPScreeningFollowUpFHIR_0_2_000 : ILibrary, ISingleton<PCSBPScreeningFollowUpFHIR_0_2_000>
{
    private PCSBPScreeningFollowUpFHIR_0_2_000() {}

    public static PCSBPScreeningFollowUpFHIR_0_2_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "PCSBPScreeningFollowUpFHIR";
    public string Version => "0.2.000";
    public ILibrary[] Dependencies => [CQMCommon_2_2_000.Instance, FHIRHelpers_4_4_000.Instance, QICoreCommon_2_1_000.Instance, SupplementalDataElements_3_5_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    #region ValueSet: Diagnosis of Hypertension
    [CqlValueSetDefinition(
        definitionName: "Diagnosis of Hypertension",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.263",
        valueSetVersion: null)]
    public CqlValueSet Diagnosis_of_Hypertension(CqlContext context) => _Diagnosis_of_Hypertension;

    private static readonly CqlValueSet _Diagnosis_of_Hypertension = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.263", null);
    #endregion

    #region ValueSet: Dietary Recommendations
    [CqlValueSetDefinition(
        definitionName: "Dietary Recommendations",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1515",
        valueSetVersion: null)]
    public CqlValueSet Dietary_Recommendations(CqlContext context) => _Dietary_Recommendations;

    private static readonly CqlValueSet _Dietary_Recommendations = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1515", null);
    #endregion

    #region ValueSet: Encounter to Screen for Blood Pressure
    [CqlValueSetDefinition(
        definitionName: "Encounter to Screen for Blood Pressure",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1920",
        valueSetVersion: null)]
    public CqlValueSet Encounter_to_Screen_for_Blood_Pressure(CqlContext context) => _Encounter_to_Screen_for_Blood_Pressure;

    private static readonly CqlValueSet _Encounter_to_Screen_for_Blood_Pressure = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1920", null);
    #endregion

    #region ValueSet: Finding of Elevated Blood Pressure or Hypertension
    [CqlValueSetDefinition(
        definitionName: "Finding of Elevated Blood Pressure or Hypertension",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.514",
        valueSetVersion: null)]
    public CqlValueSet Finding_of_Elevated_Blood_Pressure_or_Hypertension(CqlContext context) => _Finding_of_Elevated_Blood_Pressure_or_Hypertension;

    private static readonly CqlValueSet _Finding_of_Elevated_Blood_Pressure_or_Hypertension = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.514", null);
    #endregion

    #region ValueSet: Follow Up Within 4 Weeks
    [CqlValueSetDefinition(
        definitionName: "Follow Up Within 4 Weeks",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1578",
        valueSetVersion: null)]
    public CqlValueSet Follow_Up_Within_4_Weeks(CqlContext context) => _Follow_Up_Within_4_Weeks;

    private static readonly CqlValueSet _Follow_Up_Within_4_Weeks = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1578", null);
    #endregion

    #region ValueSet: Follow Up Within 6 Months
    [CqlValueSetDefinition(
        definitionName: "Follow Up Within 6 Months",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1108.125",
        valueSetVersion: null)]
    public CqlValueSet Follow_Up_Within_6_Months(CqlContext context) => _Follow_Up_Within_6_Months;

    private static readonly CqlValueSet _Follow_Up_Within_6_Months = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1108.125", null);
    #endregion

    #region ValueSet: Laboratory Tests for Hypertension
    [CqlValueSetDefinition(
        definitionName: "Laboratory Tests for Hypertension",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1482",
        valueSetVersion: null)]
    public CqlValueSet Laboratory_Tests_for_Hypertension(CqlContext context) => _Laboratory_Tests_for_Hypertension;

    private static readonly CqlValueSet _Laboratory_Tests_for_Hypertension = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1482", null);
    #endregion

    #region ValueSet: Lifestyle Recommendation
    [CqlValueSetDefinition(
        definitionName: "Lifestyle Recommendation",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1581",
        valueSetVersion: null)]
    public CqlValueSet Lifestyle_Recommendation(CqlContext context) => _Lifestyle_Recommendation;

    private static readonly CqlValueSet _Lifestyle_Recommendation = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1581", null);
    #endregion

    #region ValueSet: Medical Reason
    [CqlValueSetDefinition(
        definitionName: "Medical Reason",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1007",
        valueSetVersion: null)]
    public CqlValueSet Medical_Reason(CqlContext context) => _Medical_Reason;

    private static readonly CqlValueSet _Medical_Reason = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1007", null);
    #endregion

    #region ValueSet: Patient Declined
    [CqlValueSetDefinition(
        definitionName: "Patient Declined",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1582",
        valueSetVersion: null)]
    public CqlValueSet Patient_Declined(CqlContext context) => _Patient_Declined;

    private static readonly CqlValueSet _Patient_Declined = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1582", null);
    #endregion

    #region ValueSet: Pharmacologic Therapy for Hypertension
    [CqlValueSetDefinition(
        definitionName: "Pharmacologic Therapy for Hypertension",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.1577",
        valueSetVersion: null)]
    public CqlValueSet Pharmacologic_Therapy_for_Hypertension(CqlContext context) => _Pharmacologic_Therapy_for_Hypertension;

    private static readonly CqlValueSet _Pharmacologic_Therapy_for_Hypertension = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.1577", null);
    #endregion

    #region ValueSet: Recommendation to Increase Physical Activity
    [CqlValueSetDefinition(
        definitionName: "Recommendation to Increase Physical Activity",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1518",
        valueSetVersion: null)]
    public CqlValueSet Recommendation_to_Increase_Physical_Activity(CqlContext context) => _Recommendation_to_Increase_Physical_Activity;

    private static readonly CqlValueSet _Recommendation_to_Increase_Physical_Activity = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1518", null);
    #endregion

    #region ValueSet: Referral or Counseling for Alcohol Consumption
    [CqlValueSetDefinition(
        definitionName: "Referral or Counseling for Alcohol Consumption",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1583",
        valueSetVersion: null)]
    public CqlValueSet Referral_or_Counseling_for_Alcohol_Consumption(CqlContext context) => _Referral_or_Counseling_for_Alcohol_Consumption;

    private static readonly CqlValueSet _Referral_or_Counseling_for_Alcohol_Consumption = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1583", null);
    #endregion

    #region ValueSet: Referral to Primary Care or Alternate Provider
    [CqlValueSetDefinition(
        definitionName: "Referral to Primary Care or Alternate Provider",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1580",
        valueSetVersion: null)]
    public CqlValueSet Referral_to_Primary_Care_or_Alternate_Provider(CqlContext context) => _Referral_to_Primary_Care_or_Alternate_Provider;

    private static readonly CqlValueSet _Referral_to_Primary_Care_or_Alternate_Provider = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1580", null);
    #endregion

    #region ValueSet: Weight Reduction Recommended
    [CqlValueSetDefinition(
        definitionName: "Weight Reduction Recommended",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1510",
        valueSetVersion: null)]
    public CqlValueSet Weight_Reduction_Recommended(CqlContext context) => _Weight_Reduction_Recommended;

    private static readonly CqlValueSet _Weight_Reduction_Recommended = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1510", null);
    #endregion

    #endregion ValueSets

    #region Codes

    #region Code: Diastolic blood pressure
    [CqlCodeDefinition(
        definitionName: "Diastolic blood pressure",
        codeId: "8462-4",
        codeSystem: "http://loinc.org")]
    public CqlCode Diastolic_blood_pressure(CqlContext context) => _Diastolic_blood_pressure;

    private static readonly CqlCode _Diastolic_blood_pressure = new CqlCode("8462-4", "http://loinc.org", default, default);
    #endregion

    #region Code: 12 lead EKG panel
    [CqlCodeDefinition(
        definitionName: "12 lead EKG panel",
        codeId: "34534-8",
        codeSystem: "http://loinc.org")]
    public CqlCode _12_lead_EKG_panel(CqlContext context) => __12_lead_EKG_panel;

    private static readonly CqlCode __12_lead_EKG_panel = new CqlCode("34534-8", "http://loinc.org", default, default);
    #endregion

    #region Code: EKG study
    [CqlCodeDefinition(
        definitionName: "EKG study",
        codeId: "11524-6",
        codeSystem: "http://loinc.org")]
    public CqlCode EKG_study(CqlContext context) => _EKG_study;

    private static readonly CqlCode _EKG_study = new CqlCode("11524-6", "http://loinc.org", default, default);
    #endregion

    #region Code: Systolic blood pressure
    [CqlCodeDefinition(
        definitionName: "Systolic blood pressure",
        codeId: "8480-6",
        codeSystem: "http://loinc.org")]
    public CqlCode Systolic_blood_pressure(CqlContext context) => _Systolic_blood_pressure;

    private static readonly CqlCode _Systolic_blood_pressure = new CqlCode("8480-6", "http://loinc.org", default, default);
    #endregion

    #region Code: virtual
    [CqlCodeDefinition(
        definitionName: "virtual",
        codeId: "VR",
        codeSystem: "http://terminology.hl7.org/CodeSystem/v3-ActCode")]
    public CqlCode @virtual(CqlContext context) => _virtual;

    private static readonly CqlCode _virtual = new CqlCode("VR", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default);
    #endregion

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition(
        definitionName: "ActCode")]
    public CqlCode[] ActCode(CqlContext context)
    {
        CqlCode[] ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = [
            new CqlCode("VR", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default),
        ];

        return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
    }


    [CqlCodeSystemDefinition(
        definitionName: "LOINC")]
    public CqlCode[] LOINC(CqlContext context)
    {
        CqlCode[] ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = [
            new CqlCode("8462-4", "http://loinc.org", default, default),
            new CqlCode("34534-8", "http://loinc.org", default, default),
            new CqlCode("11524-6", "http://loinc.org", default, default),
            new CqlCode("8480-6", "http://loinc.org", default, default),
        ];

        return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlCodeSystemDefinition(
        definitionName: "SNOMEDCT")]
    public CqlCode[] SNOMEDCT(CqlContext context)
    {
        CqlCode[] ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = []
;

        return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
    }


    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition(
        definitionName: "Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Interval(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, true, true);
        object ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.ResolveParameter("PCSBPScreeningFollowUpFHIR-0.2.000", "Measurement Period", ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);

        return (CqlInterval<CqlDateTime>)ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition(
        definitionName: "Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.SingletonFrom<Patient>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);

        return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition(
        definitionName: "Qualifying Encounter during Measurement Period")]
    public IEnumerable<Encounter> Qualifying_Encounter_during_Measurement_Period(CqlContext context)
    {
        CqlValueSet ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Encounter_to_Screen_for_Blood_Pressure(context);
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_(Encounter ValidEncounter)
        {
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Measurement_Period(context);
            Period pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = ValidEncounter?.Period;
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, "day");
            Code<Encounter.EncounterStatus> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = ValidEncounter?.StatusElement;
            Encounter.EncounterStatus? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_?.Value;
            Code<Encounter.EncounterStatus> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Equivalent(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, "finished");
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.And(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            Coding pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = ValidEncounter?.Class;
            CqlCode pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToCode(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            CqlCode pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.@virtual(context);
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Equivalent(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Not(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.And(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);

            return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Where<Encounter>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

        return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition(
        definitionName: "Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Qualifying_Encounter_during_Measurement_Period(context);
        bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_(Encounter QualifyingEncounter)
        {
            Patient pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Patient(context);
            Date pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_?.BirthDateElement;
            string pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_?.Value;
            CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.ConvertStringToDateTime(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Measurement_Period(context);
            CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Start(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            int? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.CalculateAgeAt(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, "year");
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.GreaterOrEqual(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, 18);

            return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Where<Encounter>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);

        return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context)
    {
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Initial_Population(context);

        return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator Exclusions")]
    public IEnumerable<Encounter> Denominator_Exclusions(CqlContext context)
    {
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Qualifying_Encounter_during_Measurement_Period(context);
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_(Encounter QualifyingEncounter)
        {
            CqlValueSet qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Diagnosis_of_Hypertension(context);
            IEnumerable<Condition> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_(Condition Hypertension)
            {
                bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.isProblemListItem(context, Hypertension);
                bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.isHealthConcern(context, Hypertension);
                bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Or(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_()
                {
                    bool qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_()
                    {
                        CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, Hypertension);
                        CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Start(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

                        return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ is null;
                    };
                    if (qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_())
                    {
                        return default;
                    }
                    else
                    {
                        CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, Hypertension);
                        CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Start(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                        CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Start(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                        CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Interval(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, true, true);

                        return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
                    }
                };
                Period qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.SameOrBefore(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_(), qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, "day");
                bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.And(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);

                return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
            };
            IEnumerable<Condition> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Where<Condition>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            Encounter qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_(Condition Hypertension) =>
                QualifyingEncounter;
            IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Select<Condition, Encounter>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);

            return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.SelectMany<Encounter, Encounter>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);

        return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition(
        definitionName: "Encounter with Normal Blood Pressure Reading")]
    public IEnumerable<Encounter> Encounter_with_Normal_Blood_Pressure_Reading(CqlContext context)
    {
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Qualifying_Encounter_during_Measurement_Period(context);
        bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_(Encounter QualifyingEncounter)
        {
            IEnumerable<Observation> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/bp"));
            bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_(Observation BloodPressure)
            {
                DataType szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = BloodPressure?.Effective;
                object szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.toInterval(context, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.End(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                Period szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.In<CqlDateTime>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, default);
                Code<ObservationStatus> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = BloodPressure?.StatusElement;
                ObservationStatus? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_?.Value;
                string szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Convert<string>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                string[] szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.In<string>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ as IEnumerable<string>);
                bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.And(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);

                return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
            };
            IEnumerable<Observation> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Where<Observation>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            object rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_(Observation @this)
            {
                DataType szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = @this?.Effective;
                object szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.toInterval(context, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Start(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

                return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
            };
            IEnumerable<Observation> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.SortBy<Observation>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, System.ComponentModel.ListSortDirection.Ascending);
            Observation rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Last<Observation>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            List<Observation.ComponentComponent> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_?.Component;
            bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_(Observation.ComponentComponent @this)
            {
                CodeableConcept tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = @this?.Code;
                List<Coding> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_?.Coding;
                Coding tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.First<Coding>((IEnumerable<Coding>)tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                FhirUri tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_?.SystemElement;
                string tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToString(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Equal(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, "http://loinc.org");
                List<Coding> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_?.Coding;
                Coding tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.First<Coding>((IEnumerable<Coding>)tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                Code tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_?.CodeElement;
                string tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToString(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Equal(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, "8480-6");
                bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.And(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);

                return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
            };
            IEnumerable<Observation.ComponentComponent> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            Observation.ComponentComponent rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            DataType rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_?.Value;
            object rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlQuantity rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Quantity(1m, "mm[Hg]");
            CqlQuantity rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Quantity(120m, "mm[Hg]");
            CqlInterval<CqlQuantity> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Interval(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, true, false);
            bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.In<CqlQuantity>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ as CqlQuantity, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, default);
            bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_(Observation BloodPressure)
            {
                DataType tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = BloodPressure?.Effective;
                object tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.toInterval(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.End(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                Period tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.In<CqlDateTime>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, default);
                Code<ObservationStatus> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = BloodPressure?.StatusElement;
                ObservationStatus? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_?.Value;
                string tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Convert<string>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                string[] tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.In<string>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ as IEnumerable<string>);
                bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.And(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

                return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
            };
            IEnumerable<Observation> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Observation>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            object rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_(Observation @this)
            {
                DataType uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = @this?.Effective;
                object uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.toInterval(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Start(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);

                return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
            };
            IEnumerable<Observation> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.SortBy<Observation>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, System.ComponentModel.ListSortDirection.Ascending);
            Observation rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Last<Observation>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            List<Observation.ComponentComponent> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_?.Component;
            bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_(Observation.ComponentComponent @this)
            {
                CodeableConcept uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = @this?.Code;
                List<Coding> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_?.Coding;
                Coding uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.First<Coding>((IEnumerable<Coding>)uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                FhirUri uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_?.SystemElement;
                string uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToString(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Equal(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, "http://loinc.org");
                List<Coding> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_?.Coding;
                Coding uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.First<Coding>((IEnumerable<Coding>)uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                Code uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_?.CodeElement;
                string uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToString(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Equal(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, "8462-4");
                bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.And(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);

                return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
            };
            IEnumerable<Observation.ComponentComponent> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            Observation.ComponentComponent szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            DataType szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_?.Value;
            object szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlQuantity szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Quantity(80m, "mm[Hg]");
            CqlInterval<CqlQuantity> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Interval(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, true, false);
            bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.In<CqlQuantity>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ as CqlQuantity, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, default);
            bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.And(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);

            return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Where<Encounter>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);

        return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition(
        definitionName: "Encounter with Elevated Blood Pressure Reading SBP 120 to 129 AND DBP less than 80")]
    public IEnumerable<Encounter> Encounter_with_Elevated_Blood_Pressure_Reading_SBP_120_to_129_AND_DBP_less_than_80(CqlContext context)
    {
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Qualifying_Encounter_during_Measurement_Period(context);
        bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_(Encounter QualifyingEncounter)
        {
            IEnumerable<Observation> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/bp"));
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_(Observation BloodPressure)
            {
                DataType wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = BloodPressure?.Effective;
                object wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.toInterval(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.End(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                Period wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.In<CqlDateTime>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, default);
                Code<ObservationStatus> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = BloodPressure?.StatusElement;
                ObservationStatus? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_?.Value;
                string wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Convert<string>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                string[] wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.In<string>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ as IEnumerable<string>);
                bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.And(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);

                return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
            };
            IEnumerable<Observation> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Where<Observation>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            object uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_(Observation @this)
            {
                DataType wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = @this?.Effective;
                object wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.toInterval(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Start(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);

                return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
            };
            IEnumerable<Observation> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.SortBy<Observation>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, System.ComponentModel.ListSortDirection.Ascending);
            Observation vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Last<Observation>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            List<Observation.ComponentComponent> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_?.Component;
            bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_(Observation.ComponentComponent @this)
            {
                CodeableConcept wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = @this?.Code;
                List<Coding> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_?.Coding;
                Coding wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.First<Coding>((IEnumerable<Coding>)wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                FhirUri wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_?.SystemElement;
                string wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToString(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Equal(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, "http://loinc.org");
                List<Coding> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_?.Coding;
                Coding xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.First<Coding>((IEnumerable<Coding>)xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                Code xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_?.CodeElement;
                string xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToString(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Equal(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, "8480-6");
                bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.And(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);

                return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
            };
            IEnumerable<Observation.ComponentComponent> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            Observation.ComponentComponent vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            DataType vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_?.Value;
            object vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            CqlQuantity vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Quantity(120m, "mm[Hg]");
            CqlQuantity vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Quantity(129m, "mm[Hg]");
            CqlInterval<CqlQuantity> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Interval(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, true, true);
            bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.In<CqlQuantity>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ as CqlQuantity, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, default);
            bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_(Observation BloodPressure)
            {
                DataType xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = BloodPressure?.Effective;
                object xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.toInterval(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.End(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                Period xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.In<CqlDateTime>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, default);
                Code<ObservationStatus> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = BloodPressure?.StatusElement;
                ObservationStatus? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_?.Value;
                string xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Convert<string>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                string[] xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.In<string>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ as IEnumerable<string>);
                bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.And(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);

                return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
            };
            IEnumerable<Observation> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Where<Observation>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            object vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_(Observation @this)
            {
                DataType xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = @this?.Effective;
                object xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.toInterval(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Start(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);

                return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
            };
            IEnumerable<Observation> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.SortBy<Observation>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, System.ComponentModel.ListSortDirection.Ascending);
            Observation vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Last<Observation>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            List<Observation.ComponentComponent> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_?.Component;
            bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_(Observation.ComponentComponent @this)
            {
                CodeableConcept xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = @this?.Code;
                List<Coding> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_?.Coding;
                Coding xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.First<Coding>((IEnumerable<Coding>)xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                FhirUri yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_?.SystemElement;
                string yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToString(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Equal(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, "http://loinc.org");
                List<Coding> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_?.Coding;
                Coding yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.First<Coding>((IEnumerable<Coding>)yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                Code yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_?.CodeElement;
                string yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToString(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Equal(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, "8462-4");
                bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.And(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);

                return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
            };
            IEnumerable<Observation.ComponentComponent> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            Observation.ComponentComponent vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            DataType vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_?.Value;
            object vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlQuantity vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Quantity(1m, "mm[Hg]");
            CqlQuantity vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Quantity(80m, "mm[Hg]");
            CqlInterval<CqlQuantity> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Interval(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, true, false);
            bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.In<CqlQuantity>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ as CqlQuantity, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, default);
            bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.And(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);

            return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
        };
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Where<Encounter>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

        return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition(
        definitionName: "Follow up with Rescreen Within 6 Months")]
    public IEnumerable<ServiceRequest> Follow_up_with_Rescreen_Within_6_Months(CqlContext context)
    {
        CqlValueSet yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Follow_Up_Within_6_Months(context);
        IEnumerable<ServiceRequest> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_(ServiceRequest FollowUp)
        {
            Code<RequestIntent> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = FollowUp?.IntentElement;
            RequestIntent? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_?.Value;
            Code<RequestIntent> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Convert<Code<RequestIntent>>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Equivalent(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, "order");

            return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<ServiceRequest> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Where<ServiceRequest>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);

        return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition(
        definitionName: "NonPharmacological Interventions")]
    public IEnumerable<ServiceRequest> NonPharmacological_Interventions(CqlContext context)
    {
        CqlValueSet yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Lifestyle_Recommendation(context);
        IEnumerable<ServiceRequest> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        CqlValueSet yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Weight_Reduction_Recommended(context);
        IEnumerable<ServiceRequest> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Union<ServiceRequest>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
        CqlValueSet yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Dietary_Recommendations(context);
        IEnumerable<ServiceRequest> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        CqlValueSet yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Recommendation_to_Increase_Physical_Activity(context);
        IEnumerable<ServiceRequest> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Union<ServiceRequest>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
        IEnumerable<ServiceRequest> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Union<ServiceRequest>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
        CqlValueSet zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Referral_or_Counseling_for_Alcohol_Consumption(context);
        IEnumerable<ServiceRequest> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Union<ServiceRequest>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_(ServiceRequest NonPharmaInterventions)
        {
            Code<RequestIntent> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = NonPharmaInterventions?.IntentElement;
            RequestIntent? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_?.Value;
            Code<RequestIntent> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Convert<Code<RequestIntent>>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Equivalent(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, "order");

            return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<ServiceRequest> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Where<ServiceRequest>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);

        return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition(
        definitionName: "Referral to Alternate or Primary Healthcare Professional for Hypertensive Reading")]
    public IEnumerable<ServiceRequest> Referral_to_Alternate_or_Primary_Healthcare_Professional_for_Hypertensive_Reading(CqlContext context)
    {
        CqlValueSet zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Referral_to_Primary_Care_or_Alternate_Provider(context);
        IEnumerable<ServiceRequest> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_(ServiceRequest Referral)
        {
            List<CodeableConcept> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = Referral?.ReasonCode;
            CqlConcept zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_(CodeableConcept @this)
            {
                CqlConcept azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
            };
            IEnumerable<CqlConcept> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            CqlValueSet zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Finding_of_Elevated_Blood_Pressure_or_Hypertension(context);
            bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.ConceptsInValueSet(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            Code<RequestIntent> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = Referral?.IntentElement;
            RequestIntent? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_?.Value;
            Code<RequestIntent> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Convert<Code<RequestIntent>>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Equivalent(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, "order");
            bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.And(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

            return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<ServiceRequest> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<ServiceRequest>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);

        return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition(
        definitionName: "Encounter with Elevated Blood Pressure Reading SBP 120 to 129 AND DBP less than 80 and Interventions")]
    public IEnumerable<Encounter> Encounter_with_Elevated_Blood_Pressure_Reading_SBP_120_to_129_AND_DBP_less_than_80_and_Interventions(CqlContext context)
    {
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Encounter_with_Elevated_Blood_Pressure_Reading_SBP_120_to_129_AND_DBP_less_than_80(context);
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_(Encounter ElevatedEncounter)
        {
            IEnumerable<ServiceRequest> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Follow_up_with_Rescreen_Within_6_Months(context);
            bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_(ServiceRequest Twoto6MonthRescreen)
            {
                FhirDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = Twoto6MonthRescreen?.AuthoredOnElement;
                CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Convert<CqlDateTime>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                Period azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = ElevatedEncounter?.Period;
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.In<CqlDateTime>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, "day");

                return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
            };
            IEnumerable<ServiceRequest> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Where<ServiceRequest>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            Encounter azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_(ServiceRequest Twoto6MonthRescreen) =>
                ElevatedEncounter;
            IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Select<ServiceRequest, Encounter>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);

            return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.SelectMany<Encounter, Encounter>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_(Encounter ElevatedEncounter)
        {
            IEnumerable<ServiceRequest> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.NonPharmacological_Interventions(context);
            bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_(ServiceRequest NonPharmInterventions)
            {
                FhirDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = NonPharmInterventions?.AuthoredOnElement;
                CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Convert<CqlDateTime>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                Period bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = ElevatedEncounter?.Period;
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.In<CqlDateTime>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, "day");

                return bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
            };
            IEnumerable<ServiceRequest> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Where<ServiceRequest>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            Encounter azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_(ServiceRequest NonPharmInterventions) =>
                ElevatedEncounter;
            IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Select<ServiceRequest, Encounter>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);

            return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.SelectMany<Encounter, Encounter>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_(Encounter ElevatedEncounter)
        {
            IEnumerable<ServiceRequest> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Referral_to_Alternate_or_Primary_Healthcare_Professional_for_Hypertensive_Reading(context);
            bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_(ServiceRequest Referral)
            {
                FhirDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = Referral?.AuthoredOnElement;
                CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Convert<CqlDateTime>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                Period bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = ElevatedEncounter?.Period;
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.In<CqlDateTime>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, "day");

                return bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
            };
            IEnumerable<ServiceRequest> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Where<ServiceRequest>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            Encounter bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_(ServiceRequest Referral) =>
                ElevatedEncounter;
            IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Select<ServiceRequest, Encounter>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);

            return bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
        };
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.SelectMany<Encounter, Encounter>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Union<Encounter>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);

        return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition(
        definitionName: "Encounter with Hypertensive Reading Within Year Prior")]
    public IEnumerable<Encounter> Encounter_with_Hypertensive_Reading_Within_Year_Prior(CqlContext context)
    {
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Qualifying_Encounter_during_Measurement_Period(context);
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_(Encounter QualifyingEncounter)
        {
            IEnumerable<Observation> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/bp"));
            bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_(Observation BloodPressure)
            {
                DataType dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = BloodPressure?.Effective;
                object dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.toInterval(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.End(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                Period ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Start(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                CqlQuantity ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Quantity(1m, "year");
                CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Subtract(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Start(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Interval(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, true, true);
                bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.In<CqlDateTime>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, default);
                CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Start(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Not((bool?)(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ is null));
                bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.And(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                Code<ObservationStatus> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = BloodPressure?.StatusElement;
                ObservationStatus? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_?.Value;
                string ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Convert<string>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                string[] ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.In<string>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ as IEnumerable<string>);
                bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.And(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);

                return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
            };
            IEnumerable<Observation> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Where<Observation>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            object bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_(Observation @this)
            {
                DataType ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = @this?.Effective;
                object ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.toInterval(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Start(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

                return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
            };
            IEnumerable<Observation> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.SortBy<Observation>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, System.ComponentModel.ListSortDirection.Ascending);
            Observation bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Last<Observation>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            List<Observation.ComponentComponent> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_?.Component;
            bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_(Observation.ComponentComponent @this)
            {
                CodeableConcept fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = @this?.Code;
                List<Coding> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_?.Coding;
                Coding fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.First<Coding>((IEnumerable<Coding>)fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                FhirUri fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_?.SystemElement;
                string fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToString(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Equal(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, "http://loinc.org");
                List<Coding> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_?.Coding;
                Coding fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.First<Coding>((IEnumerable<Coding>)fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                Code fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_?.CodeElement;
                string fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToString(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Equal(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, "8480-6");
                bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.And(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);

                return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
            };
            IEnumerable<Observation.ComponentComponent> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            Observation.ComponentComponent czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            DataType czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_?.Value;
            object czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            CqlQuantity czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Quantity(0m, "mm[Hg]");
            bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Greater(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ as CqlQuantity, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_(Observation BloodPressure)
            {
                DataType fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = BloodPressure?.Effective;
                object fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.toInterval(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.End(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                Period fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Start(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                CqlQuantity fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Quantity(1m, "year");
                CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Subtract(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Start(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Interval(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, true, true);
                bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.In<CqlDateTime>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, default);
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Start(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Not((bool?)(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ is null));
                bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.And(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                Code<ObservationStatus> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = BloodPressure?.StatusElement;
                ObservationStatus? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_?.Value;
                string gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Convert<string>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                string[] gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.In<string>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ as IEnumerable<string>);
                bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.And(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);

                return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
            };
            IEnumerable<Observation> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Where<Observation>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            object czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_(Observation @this)
            {
                DataType gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = @this?.Effective;
                object gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.toInterval(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Start(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

                return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
            };
            IEnumerable<Observation> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.SortBy<Observation>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, System.ComponentModel.ListSortDirection.Ascending);
            Observation czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Last<Observation>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            List<Observation.ComponentComponent> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_?.Component;
            bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_(Observation.ComponentComponent @this)
            {
                CodeableConcept gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = @this?.Code;
                List<Coding> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_?.Coding;
                Coding gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.First<Coding>((IEnumerable<Coding>)gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                FhirUri gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_?.SystemElement;
                string gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToString(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Equal(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, "http://loinc.org");
                List<Coding> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_?.Coding;
                Coding gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.First<Coding>((IEnumerable<Coding>)gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                Code hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_?.CodeElement;
                string hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToString(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Equal(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, "8462-4");
                bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.And(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);

                return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
            };
            IEnumerable<Observation.ComponentComponent> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            Observation.ComponentComponent czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            DataType czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_?.Value;
            object czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Greater(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ as CqlQuantity, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.And(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_(Observation BloodPressure)
            {
                DataType hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = BloodPressure?.Effective;
                object hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.toInterval(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.End(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                Period hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Start(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                CqlQuantity hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Quantity(1m, "year");
                CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Subtract(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Start(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Interval(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, true, true);
                bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.In<CqlDateTime>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, default);
                CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Start(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Not((bool?)(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ is null));
                bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.And(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                Code<ObservationStatus> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = BloodPressure?.StatusElement;
                ObservationStatus? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_?.Value;
                string hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Convert<string>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                string[] izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.In<string>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ as IEnumerable<string>);
                bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.And(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);

                return izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
            };
            IEnumerable<Observation> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Where<Observation>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            object czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_(Observation @this)
            {
                DataType izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = @this?.Effective;
                object izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.toInterval(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Start(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

                return izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
            };
            IEnumerable<Observation> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.SortBy<Observation>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, System.ComponentModel.ListSortDirection.Ascending);
            Observation czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Last<Observation>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            List<Observation.ComponentComponent> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_?.Component;
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_(Observation.ComponentComponent @this)
            {
                CodeableConcept izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = @this?.Code;
                List<Coding> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_?.Coding;
                Coding izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.First<Coding>((IEnumerable<Coding>)izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                FhirUri izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_?.SystemElement;
                string izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToString(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Equal(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, "http://loinc.org");
                List<Coding> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_?.Coding;
                Coding izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.First<Coding>((IEnumerable<Coding>)izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                Code izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_?.CodeElement;
                string izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToString(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Equal(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, "8480-6");
                bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.And(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);

                return izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
            };
            IEnumerable<Observation.ComponentComponent> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            Observation.ComponentComponent dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            DataType dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_?.Value;
            object dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            CqlQuantity dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Quantity(130m, "mm[Hg]");
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.GreaterOrEqual(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ as CqlQuantity, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_(Observation BloodPressure)
            {
                DataType izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = BloodPressure?.Effective;
                object izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.toInterval(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.End(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                Period izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Start(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                CqlQuantity jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Quantity(1m, "year");
                CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Subtract(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Start(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Interval(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, true, true);
                bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.In<CqlDateTime>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, default);
                CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Start(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Not((bool?)(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ is null));
                bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.And(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                Code<ObservationStatus> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = BloodPressure?.StatusElement;
                ObservationStatus? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_?.Value;
                string jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Convert<string>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                string[] jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.In<string>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ as IEnumerable<string>);
                bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.And(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);

                return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
            };
            IEnumerable<Observation> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Where<Observation>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            object dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_(Observation @this)
            {
                DataType jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = @this?.Effective;
                object jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.toInterval(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Start(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);

                return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
            };
            IEnumerable<Observation> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.SortBy<Observation>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, System.ComponentModel.ListSortDirection.Ascending);
            Observation dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Last<Observation>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            List<Observation.ComponentComponent> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_?.Component;
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_(Observation.ComponentComponent @this)
            {
                CodeableConcept jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = @this?.Code;
                List<Coding> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_?.Coding;
                Coding jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.First<Coding>((IEnumerable<Coding>)jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                FhirUri kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_?.SystemElement;
                string kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToString(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Equal(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, "http://loinc.org");
                List<Coding> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_?.Coding;
                Coding kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.First<Coding>((IEnumerable<Coding>)kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                Code kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_?.CodeElement;
                string kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToString(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Equal(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, "8462-4");
                bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.And(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);

                return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
            };
            IEnumerable<Observation.ComponentComponent> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            Observation.ComponentComponent dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            DataType dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_?.Value;
            object dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            CqlQuantity dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Quantity(80m, "mm[Hg]");
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.GreaterOrEqual(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ as CqlQuantity, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Or(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.And(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);

            return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Where<Encounter>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

        return bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition(
        definitionName: "Encounter with First Hypertensive Reading SBP Greater than or Equal to 130 OR DBP Greater than or Equal to 80")]
    public IEnumerable<Encounter> Encounter_with_First_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_130_OR_DBP_Greater_than_or_Equal_to_80(CqlContext context)
    {
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Qualifying_Encounter_during_Measurement_Period(context);
        bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_(Encounter QualifyingEncounter)
        {
            IEnumerable<Observation> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/bp"));
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_(Observation BloodPressure)
            {
                DataType mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = BloodPressure?.Effective;
                object mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.toInterval(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.End(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                Period nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.In<CqlDateTime>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, "day");

                return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
            };
            IEnumerable<Observation> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Where<Observation>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            object kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_(Observation @this)
            {
                DataType nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = @this?.Effective;
                object nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.toInterval(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Start(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

                return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
            };
            IEnumerable<Observation> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.SortBy<Observation>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, System.ComponentModel.ListSortDirection.Ascending);
            Observation kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Last<Observation>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            List<Observation.ComponentComponent> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_?.Component;
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_(Observation.ComponentComponent @this)
            {
                CodeableConcept nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = @this?.Code;
                List<Coding> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_?.Coding;
                Coding nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.First<Coding>((IEnumerable<Coding>)nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                FhirUri nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_?.SystemElement;
                string nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToString(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Equal(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, "http://loinc.org");
                List<Coding> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_?.Coding;
                Coding nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.First<Coding>((IEnumerable<Coding>)nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                Code nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_?.CodeElement;
                string nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToString(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Equal(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, "8480-6");
                bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.And(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);

                return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
            };
            IEnumerable<Observation.ComponentComponent> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            Observation.ComponentComponent kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            DataType kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_?.Value;
            object lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            CqlQuantity lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Quantity(0m, "mm[Hg]");
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Greater(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ as CqlQuantity, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_(Observation BloodPressure)
            {
                DataType nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = BloodPressure?.Effective;
                object nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.toInterval(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.End(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                Period nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.In<CqlDateTime>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, "day");

                return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
            };
            IEnumerable<Observation> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Where<Observation>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            object lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_(Observation @this)
            {
                DataType ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = @this?.Effective;
                object ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.toInterval(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Start(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);

                return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
            };
            IEnumerable<Observation> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.SortBy<Observation>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, System.ComponentModel.ListSortDirection.Ascending);
            Observation lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Last<Observation>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            List<Observation.ComponentComponent> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_?.Component;
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_(Observation.ComponentComponent @this)
            {
                CodeableConcept ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = @this?.Code;
                List<Coding> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_?.Coding;
                Coding ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.First<Coding>((IEnumerable<Coding>)ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                FhirUri ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_?.SystemElement;
                string ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToString(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Equal(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, "http://loinc.org");
                List<Coding> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_?.Coding;
                Coding ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.First<Coding>((IEnumerable<Coding>)ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                Code ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_?.CodeElement;
                string ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToString(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Equal(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, "8462-4");
                bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);

                return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
            };
            IEnumerable<Observation.ComponentComponent> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            Observation.ComponentComponent lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            DataType lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_?.Value;
            object lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Greater(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ as CqlQuantity, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.And(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_(Observation BloodPressure)
            {
                DataType ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = BloodPressure?.Effective;
                object ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.toInterval(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.End(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                Period ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.In<CqlDateTime>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, "day");

                return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
            };
            IEnumerable<Observation> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Where<Observation>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            object lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_(Observation @this)
            {
                DataType ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = @this?.Effective;
                object pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.toInterval(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Start(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);

                return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
            };
            IEnumerable<Observation> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.SortBy<Observation>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, System.ComponentModel.ListSortDirection.Ascending);
            Observation lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Last<Observation>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            List<Observation.ComponentComponent> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_?.Component;
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_(Observation.ComponentComponent @this)
            {
                CodeableConcept pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = @this?.Code;
                List<Coding> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_?.Coding;
                Coding pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.First<Coding>((IEnumerable<Coding>)pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                FhirUri pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_?.SystemElement;
                string pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToString(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Equal(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, "http://loinc.org");
                List<Coding> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_?.Coding;
                Coding pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.First<Coding>((IEnumerable<Coding>)pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                Code pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_?.CodeElement;
                string pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToString(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Equal(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, "8480-6");
                bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.And(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);

                return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
            };
            IEnumerable<Observation.ComponentComponent> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            Observation.ComponentComponent mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            DataType mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_?.Value;
            object mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            CqlQuantity mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Quantity(130m, "mm[Hg]");
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.GreaterOrEqual(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ as CqlQuantity, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_(Observation BloodPressure)
            {
                DataType pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = BloodPressure?.Effective;
                object pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.toInterval(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.End(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                Period pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.In<CqlDateTime>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, "day");

                return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
            };
            IEnumerable<Observation> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<Observation>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            object mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_(Observation @this)
            {
                DataType pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = @this?.Effective;
                object pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.toInterval(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Start(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

                return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
            };
            IEnumerable<Observation> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.SortBy<Observation>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, System.ComponentModel.ListSortDirection.Ascending);
            Observation mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Last<Observation>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            List<Observation.ComponentComponent> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_?.Component;
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_(Observation.ComponentComponent @this)
            {
                CodeableConcept qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = @this?.Code;
                List<Coding> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_?.Coding;
                Coding qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.First<Coding>((IEnumerable<Coding>)qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                FhirUri qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_?.SystemElement;
                string qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToString(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Equal(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, "http://loinc.org");
                List<Coding> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_?.Coding;
                Coding qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.First<Coding>((IEnumerable<Coding>)qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                Code qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_?.CodeElement;
                string qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToString(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Equal(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, "8462-4");
                bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.And(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);

                return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
            };
            IEnumerable<Observation.ComponentComponent> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            Observation.ComponentComponent mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            DataType mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_?.Value;
            object mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            CqlQuantity mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Quantity(80m, "mm[Hg]");
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.GreaterOrEqual(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ as CqlQuantity, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Or(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.And(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);

            return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Where<Encounter>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Encounter_with_Hypertensive_Reading_Within_Year_Prior(context);
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Except<Encounter>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);

        return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition(
        definitionName: "First Hypertensive Reading Interventions or Referral to Alternate Professional")]
    public IEnumerable<ServiceRequest> First_Hypertensive_Reading_Interventions_or_Referral_to_Alternate_Professional(CqlContext context)
    {
        CqlValueSet qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Follow_Up_Within_4_Weeks(context);
        IEnumerable<ServiceRequest> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_(ServiceRequest FourWeekRescreen)
        {
            IEnumerable<ServiceRequest> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.NonPharmacological_Interventions(context);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_(ServiceRequest NonPharmInterventionsHTN)
            {
                FhirDateTime qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = FourWeekRescreen?.AuthoredOnElement;
                CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Convert<CqlDateTime>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Measurement_Period(context);
                bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.In<CqlDateTime>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, "day");
                FhirDateTime rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = NonPharmInterventionsHTN?.AuthoredOnElement;
                CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Convert<CqlDateTime>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.In<CqlDateTime>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, "day");
                bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.And(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                Code<RequestIntent> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FourWeekRescreen?.IntentElement;
                RequestIntent? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_?.Value;
                Code<RequestIntent> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Convert<Code<RequestIntent>>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Equivalent(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, "order");
                bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.And(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);

                return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
            };
            IEnumerable<ServiceRequest> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Where<ServiceRequest>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            ServiceRequest qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_(ServiceRequest NonPharmInterventionsHTN) =>
                FourWeekRescreen;
            IEnumerable<ServiceRequest> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Select<ServiceRequest, ServiceRequest>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);

            return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<ServiceRequest> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.SelectMany<ServiceRequest, ServiceRequest>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        IEnumerable<ServiceRequest> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Referral_to_Alternate_or_Primary_Healthcare_Professional_for_Hypertensive_Reading(context);
        IEnumerable<ServiceRequest> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Union<ServiceRequest>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);

        return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition(
        definitionName: "Encounter with First Hypertensive Reading SBP Greater than or Equal to 130 OR DBP Greater than or Equal to 80 and Interventions")]
    public IEnumerable<Encounter> Encounter_with_First_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_130_OR_DBP_Greater_than_or_Equal_to_80_and_Interventions(CqlContext context)
    {
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Encounter_with_First_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_130_OR_DBP_Greater_than_or_Equal_to_80(context);
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_(Encounter FirstHTNEncounter)
        {
            IEnumerable<ServiceRequest> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.First_Hypertensive_Reading_Interventions_or_Referral_to_Alternate_Professional(context);
            bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_(ServiceRequest FirstHTNIntervention)
            {
                FhirDateTime rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FirstHTNIntervention?.AuthoredOnElement;
                CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Convert<CqlDateTime>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                Period rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FirstHTNEncounter?.Period;
                CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.In<CqlDateTime>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, "day");

                return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
            };
            IEnumerable<ServiceRequest> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Where<ServiceRequest>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            Encounter rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_(ServiceRequest FirstHTNIntervention) =>
                FirstHTNEncounter;
            IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Select<ServiceRequest, Encounter>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

            return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.SelectMany<Encounter, Encounter>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);

        return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition(
        definitionName: "Encounter with Second Hypertensive Reading SBP 130 to 139 OR DBP 80 to 89")]
    public IEnumerable<Encounter> Encounter_with_Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89(CqlContext context)
    {
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Qualifying_Encounter_during_Measurement_Period(context);
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_(Encounter QualifyingEncounter)
        {
            IEnumerable<Observation> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/bp"));
            bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_(Observation BloodPressure)
            {
                DataType uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = BloodPressure?.Effective;
                object uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.toInterval(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.End(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                Period uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.In<CqlDateTime>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, "day");
                Code<ObservationStatus> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = BloodPressure?.StatusElement;
                ObservationStatus? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_?.Value;
                string vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Convert<string>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                string[] vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.In<string>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ as IEnumerable<string>);
                bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.And(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);

                return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
            };
            IEnumerable<Observation> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Where<Observation>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            object szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_(Observation @this)
            {
                DataType vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = @this?.Effective;
                object vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.toInterval(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Start(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);

                return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
            };
            IEnumerable<Observation> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.SortBy<Observation>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, System.ComponentModel.ListSortDirection.Ascending);
            Observation szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Last<Observation>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            List<Observation.ComponentComponent> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_?.Component;
            bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_(Observation.ComponentComponent @this)
            {
                CodeableConcept vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = @this?.Code;
                List<Coding> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_?.Coding;
                Coding vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.First<Coding>((IEnumerable<Coding>)vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                FhirUri vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_?.SystemElement;
                string vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToString(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Equal(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, "http://loinc.org");
                List<Coding> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_?.Coding;
                Coding vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.First<Coding>((IEnumerable<Coding>)vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                Code vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_?.CodeElement;
                string vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToString(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Equal(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, "8480-6");
                bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.And(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);

                return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
            };
            IEnumerable<Observation.ComponentComponent> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            Observation.ComponentComponent szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            DataType szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_?.Value;
            object szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlQuantity szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Quantity(130m, "mm[Hg]");
            CqlQuantity szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Quantity(139m, "mm[Hg]");
            CqlInterval<CqlQuantity> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Interval(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, true, true);
            bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.In<CqlQuantity>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ as CqlQuantity, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, default);
            bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_(Observation BloodPressure)
            {
                DataType vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = BloodPressure?.Effective;
                object vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.toInterval(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.End(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                Period wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.In<CqlDateTime>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, "day");
                Code<ObservationStatus> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = BloodPressure?.StatusElement;
                ObservationStatus? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_?.Value;
                string wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Convert<string>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                string[] wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.In<string>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ as IEnumerable<string>);
                bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.And(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);

                return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
            };
            IEnumerable<Observation> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Observation>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            object szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_(Observation @this)
            {
                DataType wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = @this?.Effective;
                object wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.toInterval(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Start(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);

                return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
            };
            IEnumerable<Observation> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.SortBy<Observation>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, System.ComponentModel.ListSortDirection.Ascending);
            Observation szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Last<Observation>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            List<Observation.ComponentComponent> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_?.Component;
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_(Observation.ComponentComponent @this)
            {
                CodeableConcept wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = @this?.Code;
                List<Coding> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_?.Coding;
                Coding wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.First<Coding>((IEnumerable<Coding>)wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                FhirUri wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_?.SystemElement;
                string wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToString(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Equal(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, "http://loinc.org");
                List<Coding> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_?.Coding;
                Coding wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.First<Coding>((IEnumerable<Coding>)wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                Code wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_?.CodeElement;
                string wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToString(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Equal(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, "8462-4");
                bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.And(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

                return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
            };
            IEnumerable<Observation.ComponentComponent> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            Observation.ComponentComponent tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            DataType tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_?.Value;
            object tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlQuantity tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Quantity(80m, "mm[Hg]");
            CqlQuantity tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Quantity(89m, "mm[Hg]");
            CqlInterval<CqlQuantity> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Interval(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, true, true);
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.In<CqlQuantity>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ as CqlQuantity, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, default);
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Or(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_(Observation BloodPressure)
            {
                DataType xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = BloodPressure?.Effective;
                object xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.toInterval(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.End(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                Period xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.In<CqlDateTime>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, "day");
                Code<ObservationStatus> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = BloodPressure?.StatusElement;
                ObservationStatus? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_?.Value;
                string xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Convert<string>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                string[] xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.In<string>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ as IEnumerable<string>);
                bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.And(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);

                return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
            };
            IEnumerable<Observation> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Where<Observation>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            object tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_(Observation @this)
            {
                DataType xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = @this?.Effective;
                object xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.toInterval(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Start(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

                return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
            };
            IEnumerable<Observation> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.SortBy<Observation>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, System.ComponentModel.ListSortDirection.Ascending);
            Observation tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Last<Observation>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            List<Observation.ComponentComponent> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_?.Component;
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_(Observation.ComponentComponent @this)
            {
                CodeableConcept xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = @this?.Code;
                List<Coding> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_?.Coding;
                Coding xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.First<Coding>((IEnumerable<Coding>)xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                FhirUri xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_?.SystemElement;
                string xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToString(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Equal(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, "http://loinc.org");
                List<Coding> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_?.Coding;
                Coding xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.First<Coding>((IEnumerable<Coding>)xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                Code yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_?.CodeElement;
                string yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToString(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Equal(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, "8480-6");
                bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.And(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);

                return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
            };
            IEnumerable<Observation.ComponentComponent> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            Observation.ComponentComponent tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            DataType tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_?.Value;
            object tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlQuantity tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Quantity(140m, "mm[Hg]");
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.GreaterOrEqual(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ as CqlQuantity, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_(Observation BloodPressure)
            {
                DataType yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = BloodPressure?.Effective;
                object yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.toInterval(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.End(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                Period yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.In<CqlDateTime>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, "day");
                Code<ObservationStatus> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = BloodPressure?.StatusElement;
                ObservationStatus? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_?.Value;
                string yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Convert<string>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                string[] yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.In<string>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ as IEnumerable<string>);
                bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.And(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

                return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
            };
            IEnumerable<Observation> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Where<Observation>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            object uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_(Observation @this)
            {
                DataType yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = @this?.Effective;
                object yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.toInterval(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Start(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

                return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
            };
            IEnumerable<Observation> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.SortBy<Observation>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, System.ComponentModel.ListSortDirection.Ascending);
            Observation uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Last<Observation>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            List<Observation.ComponentComponent> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_?.Component;
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_(Observation.ComponentComponent @this)
            {
                CodeableConcept yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = @this?.Code;
                List<Coding> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_?.Coding;
                Coding yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.First<Coding>((IEnumerable<Coding>)yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                FhirUri yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_?.SystemElement;
                string yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToString(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Equal(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, "http://loinc.org");
                List<Coding> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_?.Coding;
                Coding zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.First<Coding>((IEnumerable<Coding>)zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                Code zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_?.CodeElement;
                string zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToString(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Equal(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, "8462-4");
                bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.And(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);

                return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
            };
            IEnumerable<Observation.ComponentComponent> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            Observation.ComponentComponent uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            DataType uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_?.Value;
            object uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlQuantity uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Quantity(90m, "mm[Hg]");
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.GreaterOrEqual(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ as CqlQuantity, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Or(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Not(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.And(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Encounter_with_Hypertensive_Reading_Within_Year_Prior(context);
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Exists<Encounter>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.And(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);

            return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Where<Encounter>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);

        return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition(
        definitionName: "Laboratory Test or ECG for Hypertension")]
    public IEnumerable<ServiceRequest> Laboratory_Test_or_ECG_for_Hypertension(CqlContext context)
    {
        CqlCode zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this._12_lead_EKG_panel(context);
        IEnumerable<CqlCode> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.ToList<CqlCode>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        IEnumerable<ServiceRequest> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, default, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        CqlCode zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.EKG_study(context);
        IEnumerable<CqlCode> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.ToList<CqlCode>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
        IEnumerable<ServiceRequest> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, default, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Union<ServiceRequest>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        CqlValueSet zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Laboratory_Tests_for_Hypertension(context);
        IEnumerable<ServiceRequest> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Union<ServiceRequest>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_(ServiceRequest EKGLab)
        {
            Code<RequestIntent> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = EKGLab?.IntentElement;
            RequestIntent? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_?.Value;
            Code<RequestIntent> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Convert<Code<RequestIntent>>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Equivalent(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, "order");

            return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<ServiceRequest> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Where<ServiceRequest>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);

        return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition(
        definitionName: "Second Hypertensive Reading SBP 130 to 139 OR DBP 80 to 89 and Interventions")]
    public IEnumerable<ServiceRequest> Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89_and_Interventions(CqlContext context)
    {
        IEnumerable<ServiceRequest> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Follow_up_with_Rescreen_Within_6_Months(context);
        IEnumerable<ServiceRequest> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_(ServiceRequest Rescreen2to6)
        {
            IEnumerable<ServiceRequest> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Laboratory_Test_or_ECG_for_Hypertension(context);
            bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_(ServiceRequest LabECGIntervention)
            {
                FhirDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = Rescreen2to6?.AuthoredOnElement;
                CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Convert<CqlDateTime>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Measurement_Period(context);
                bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.In<CqlDateTime>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, "day");
                FhirDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = LabECGIntervention?.AuthoredOnElement;
                CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Convert<CqlDateTime>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.In<CqlDateTime>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, "day");
                bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.And(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

                return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
            };
            IEnumerable<ServiceRequest> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Where<ServiceRequest>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            ServiceRequest azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_(ServiceRequest LabECGIntervention) =>
                Rescreen2to6;
            IEnumerable<ServiceRequest> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Select<ServiceRequest, ServiceRequest>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);

            return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<ServiceRequest> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.SelectMany<ServiceRequest, ServiceRequest>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
        IEnumerable<ServiceRequest> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_(ServiceRequest Rescreen2to6)
        {
            IEnumerable<ServiceRequest> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.NonPharmacological_Interventions(context);
            bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_(ServiceRequest NonPharmSecondIntervention)
            {
                FhirDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = NonPharmSecondIntervention?.AuthoredOnElement;
                CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Convert<CqlDateTime>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Measurement_Period(context);
                bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.In<CqlDateTime>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, "day");

                return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
            };
            IEnumerable<ServiceRequest> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Where<ServiceRequest>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            ServiceRequest azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_(ServiceRequest NonPharmSecondIntervention) =>
                Rescreen2to6;
            IEnumerable<ServiceRequest> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Select<ServiceRequest, ServiceRequest>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);

            return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<ServiceRequest> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.SelectMany<ServiceRequest, ServiceRequest>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);

        return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition(
        definitionName: "Encounter with Second Hypertensive Reading SBP 130 to 139 OR DBP 80 to 89 and Interventions")]
    public IEnumerable<Encounter> Encounter_with_Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89_and_Interventions(CqlContext context)
    {
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Encounter_with_Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89(context);
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_(Encounter SecondHTNEncounterReading)
        {
            IEnumerable<ServiceRequest> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89_and_Interventions(context);
            bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_(ServiceRequest EncounterInterventions)
            {
                FhirDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = EncounterInterventions?.AuthoredOnElement;
                CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Convert<CqlDateTime>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                Period bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = SecondHTNEncounterReading?.Period;
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.In<CqlDateTime>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, "day");

                return bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
            };
            IEnumerable<ServiceRequest> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Where<ServiceRequest>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            Encounter bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_(ServiceRequest EncounterInterventions) =>
                SecondHTNEncounterReading;
            IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Select<ServiceRequest, Encounter>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

            return bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.SelectMany<Encounter, Encounter>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_(Encounter SecondHTNEncounterReading)
        {
            IEnumerable<ServiceRequest> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Referral_to_Alternate_or_Primary_Healthcare_Professional_for_Hypertensive_Reading(context);
            bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_(ServiceRequest ReferralForHTN)
            {
                FhirDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = ReferralForHTN?.AuthoredOnElement;
                CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Convert<CqlDateTime>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                Period bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = SecondHTNEncounterReading?.Period;
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.In<CqlDateTime>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, "day");

                return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
            };
            IEnumerable<ServiceRequest> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Where<ServiceRequest>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            Encounter bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_(ServiceRequest ReferralForHTN) =>
                SecondHTNEncounterReading;
            IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Select<ServiceRequest, Encounter>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);

            return bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.SelectMany<Encounter, Encounter>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Union<Encounter>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

        return bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition(
        definitionName: "Encounter with Second Hypertensive Reading SBP Greater than or Equal to 140 OR DBP Greater than or Equal to 90")]
    public IEnumerable<Encounter> Encounter_with_Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90(CqlContext context)
    {
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Qualifying_Encounter_during_Measurement_Period(context);
        bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_(Encounter QualifyingEncounter)
        {
            IEnumerable<Observation> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/bp"));
            bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_(Observation BloodPressure)
            {
                DataType ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = BloodPressure?.Effective;
                object ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.toInterval(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.End(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                Period ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.In<CqlDateTime>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, default);
                Code<ObservationStatus> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = BloodPressure?.StatusElement;
                ObservationStatus? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_?.Value;
                string ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Convert<string>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                string[] ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.In<string>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ as IEnumerable<string>);
                bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.And(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

                return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
            };
            IEnumerable<Observation> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Where<Observation>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            object czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_(Observation @this)
            {
                DataType fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = @this?.Effective;
                object fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.toInterval(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Start(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);

                return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
            };
            IEnumerable<Observation> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.SortBy<Observation>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, System.ComponentModel.ListSortDirection.Ascending);
            Observation czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Last<Observation>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            List<Observation.ComponentComponent> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_?.Component;
            bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_(Observation.ComponentComponent @this)
            {
                CodeableConcept fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = @this?.Code;
                List<Coding> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_?.Coding;
                Coding fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.First<Coding>((IEnumerable<Coding>)fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                FhirUri fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_?.SystemElement;
                string fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToString(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Equal(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, "http://loinc.org");
                List<Coding> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_?.Coding;
                Coding fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.First<Coding>((IEnumerable<Coding>)fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                Code fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_?.CodeElement;
                string fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToString(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Equal(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, "8480-6");
                bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.And(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);

                return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
            };
            IEnumerable<Observation.ComponentComponent> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            Observation.ComponentComponent czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            DataType czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_?.Value;
            object czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlQuantity czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Quantity(0m, "mm[Hg]");
            bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Greater(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ as CqlQuantity, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_(Observation BloodPressure)
            {
                DataType fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = BloodPressure?.Effective;
                object fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.toInterval(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.End(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                Period fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.In<CqlDateTime>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, default);
                Code<ObservationStatus> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = BloodPressure?.StatusElement;
                ObservationStatus? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_?.Value;
                string gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Convert<string>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                string[] gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.In<string>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ as IEnumerable<string>);
                bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.And(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);

                return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
            };
            IEnumerable<Observation> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Where<Observation>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            object czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_(Observation @this)
            {
                DataType gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = @this?.Effective;
                object gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.toInterval(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Start(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);

                return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
            };
            IEnumerable<Observation> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.SortBy<Observation>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, System.ComponentModel.ListSortDirection.Ascending);
            Observation czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Last<Observation>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            List<Observation.ComponentComponent> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_?.Component;
            bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_(Observation.ComponentComponent @this)
            {
                CodeableConcept gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = @this?.Code;
                List<Coding> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_?.Coding;
                Coding gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.First<Coding>((IEnumerable<Coding>)gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                FhirUri gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_?.SystemElement;
                string gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToString(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Equal(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, "http://loinc.org");
                List<Coding> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_?.Coding;
                Coding gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.First<Coding>((IEnumerable<Coding>)gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                Code gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_?.CodeElement;
                string gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToString(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Equal(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, "8462-4");
                bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.And(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);

                return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
            };
            IEnumerable<Observation.ComponentComponent> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            Observation.ComponentComponent dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            DataType dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_?.Value;
            object dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Greater(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ as CqlQuantity, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.And(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_(Observation BloodPressure)
            {
                DataType gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = BloodPressure?.Effective;
                object gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.toInterval(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.End(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                Period hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.In<CqlDateTime>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, default);
                Code<ObservationStatus> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = BloodPressure?.StatusElement;
                ObservationStatus? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_?.Value;
                string hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Convert<string>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                string[] hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.In<string>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ as IEnumerable<string>);
                bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.And(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);

                return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
            };
            IEnumerable<Observation> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Where<Observation>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            object dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_(Observation @this)
            {
                DataType hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = @this?.Effective;
                object hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.toInterval(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Start(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);

                return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
            };
            IEnumerable<Observation> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.SortBy<Observation>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, System.ComponentModel.ListSortDirection.Ascending);
            Observation dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Last<Observation>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            List<Observation.ComponentComponent> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_?.Component;
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_(Observation.ComponentComponent @this)
            {
                CodeableConcept hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = @this?.Code;
                List<Coding> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_?.Coding;
                Coding hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.First<Coding>((IEnumerable<Coding>)hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                FhirUri hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_?.SystemElement;
                string hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToString(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Equal(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, "http://loinc.org");
                List<Coding> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_?.Coding;
                Coding hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.First<Coding>((IEnumerable<Coding>)hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                Code hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_?.CodeElement;
                string hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToString(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Equal(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, "8480-6");
                bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.And(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

                return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
            };
            IEnumerable<Observation.ComponentComponent> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            Observation.ComponentComponent dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            DataType dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_?.Value;
            object dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            CqlQuantity dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Quantity(140m, "mm[Hg]");
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.GreaterOrEqual(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ as CqlQuantity, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_(Observation BloodPressure)
            {
                DataType izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = BloodPressure?.Effective;
                object izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.toInterval(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.End(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                Period izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.In<CqlDateTime>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, default);
                Code<ObservationStatus> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = BloodPressure?.StatusElement;
                ObservationStatus? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_?.Value;
                string izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Convert<string>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                string[] izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.In<string>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ as IEnumerable<string>);
                bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.And(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);

                return izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
            };
            IEnumerable<Observation> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Where<Observation>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            object dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_(Observation @this)
            {
                DataType izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = @this?.Effective;
                object izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.toInterval(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Start(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

                return izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
            };
            IEnumerable<Observation> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.SortBy<Observation>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, System.ComponentModel.ListSortDirection.Ascending);
            Observation ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Last<Observation>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            List<Observation.ComponentComponent> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_?.Component;
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_(Observation.ComponentComponent @this)
            {
                CodeableConcept izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = @this?.Code;
                List<Coding> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_?.Coding;
                Coding izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.First<Coding>((IEnumerable<Coding>)izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                FhirUri izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_?.SystemElement;
                string izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToString(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Equal(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, "http://loinc.org");
                List<Coding> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_?.Coding;
                Coding izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.First<Coding>((IEnumerable<Coding>)izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                Code jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_?.CodeElement;
                string jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToString(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Equal(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, "8462-4");
                bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.And(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);

                return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
            };
            IEnumerable<Observation.ComponentComponent> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            Observation.ComponentComponent ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            DataType ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_?.Value;
            object ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            CqlQuantity ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Quantity(90m, "mm[Hg]");
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.GreaterOrEqual(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ as CqlQuantity, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Or(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.And(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Encounter_with_Hypertensive_Reading_Within_Year_Prior(context);
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Exists<Encounter>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.And(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);

            return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Where<Encounter>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);

        return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition(
        definitionName: "Second Hypertensive Reading SBP Greater than or Equal to 140 OR DBP Greater than or Equal to 90 Interventions")]
    public IEnumerable<ServiceRequest> Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90_Interventions(CqlContext context)
    {
        CqlValueSet jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Follow_Up_Within_4_Weeks(context);
        IEnumerable<ServiceRequest> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_(ServiceRequest WeeksRescreen)
        {
            IEnumerable<ServiceRequest> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Laboratory_Test_or_ECG_for_Hypertension(context);
            bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_(ServiceRequest ECGLabTest)
            {
                FhirDateTime jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = WeeksRescreen?.AuthoredOnElement;
                CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Convert<CqlDateTime>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Measurement_Period(context);
                bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.In<CqlDateTime>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, "day");
                FhirDateTime jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = ECGLabTest?.AuthoredOnElement;
                CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Convert<CqlDateTime>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.In<CqlDateTime>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, "day");
                bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.And(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                Code<RequestIntent> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = WeeksRescreen?.IntentElement;
                RequestIntent? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_?.Value;
                Code<RequestIntent> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Convert<Code<RequestIntent>>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Equivalent(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, "order");
                bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.And(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                Code<RequestIntent> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = ECGLabTest?.IntentElement;
                RequestIntent? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_?.Value;
                Code<RequestIntent> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Convert<Code<RequestIntent>>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Equivalent(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, "order");
                bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.And(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);

                return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
            };
            IEnumerable<ServiceRequest> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<ServiceRequest>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            ServiceRequest jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_(ServiceRequest ECGLabTest) =>
                WeeksRescreen;
            IEnumerable<ServiceRequest> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Select<ServiceRequest, ServiceRequest>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

            return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<ServiceRequest> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.SelectMany<ServiceRequest, ServiceRequest>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
        IEnumerable<ServiceRequest> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_(ServiceRequest WeeksRescreen)
        {
            IEnumerable<ServiceRequest> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.NonPharmacological_Interventions(context);
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_(ServiceRequest HTNInterventions)
            {
                FhirDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = HTNInterventions?.AuthoredOnElement;
                CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Convert<CqlDateTime>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Measurement_Period(context);
                bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.In<CqlDateTime>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, "day");

                return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
            };
            IEnumerable<ServiceRequest> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Where<ServiceRequest>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            ServiceRequest kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_(ServiceRequest HTNInterventions) =>
                WeeksRescreen;
            IEnumerable<ServiceRequest> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Select<ServiceRequest, ServiceRequest>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);

            return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<ServiceRequest> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.SelectMany<ServiceRequest, ServiceRequest>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        IEnumerable<ServiceRequest> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_(ServiceRequest WeeksRescreen)
        {
            CqlValueSet kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Pharmacologic_Therapy_for_Hypertension(context);
            IEnumerable<MedicationRequest> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Union<MedicationRequest>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_(MedicationRequest Medications)
            {
                FhirDateTime lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = Medications?.AuthoredOnElement;
                CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Convert<CqlDateTime>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Measurement_Period(context);
                bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.In<CqlDateTime>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, "day");
                Code<MedicationRequest.MedicationrequestStatus> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = Medications?.StatusElement;
                MedicationRequest.MedicationrequestStatus? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_?.Value;
                string lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Convert<string>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Equivalent(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, "active");
                bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.And(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);

                return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
            };
            IEnumerable<MedicationRequest> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Where<MedicationRequest>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            ServiceRequest lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_(MedicationRequest Medications) =>
                WeeksRescreen;
            IEnumerable<ServiceRequest> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Select<MedicationRequest, ServiceRequest>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);

            return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
        };
        IEnumerable<ServiceRequest> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.SelectMany<ServiceRequest, ServiceRequest>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

        return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition(
        definitionName: "Encounter with Second Hypertensive Reading SBP Greater than or Equal to 140 OR DBP Greater than or Equal to 90 and Interventions")]
    public IEnumerable<Encounter> Encounter_with_Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90_and_Interventions(CqlContext context)
    {
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Encounter_with_Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90(context);
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_(Encounter SecondHTNEncounterReading140Over90)
        {
            IEnumerable<ServiceRequest> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90_Interventions(context);
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_(ServiceRequest SecondHTN140Over90Interventions)
            {
                FhirDateTime lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = SecondHTN140Over90Interventions?.AuthoredOnElement;
                CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Convert<CqlDateTime>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                Period lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = SecondHTNEncounterReading140Over90?.Period;
                CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.In<CqlDateTime>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, "day");

                return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
            };
            IEnumerable<ServiceRequest> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Where<ServiceRequest>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            Encounter lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_(ServiceRequest SecondHTN140Over90Interventions) =>
                SecondHTNEncounterReading140Over90;
            IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Select<ServiceRequest, Encounter>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);

            return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.SelectMany<Encounter, Encounter>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_(Encounter SecondHTNEncounterReading140Over90)
        {
            IEnumerable<ServiceRequest> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Referral_to_Alternate_or_Primary_Healthcare_Professional_for_Hypertensive_Reading(context);
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_(ServiceRequest ReferralToProfessional)
            {
                FhirDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = ReferralToProfessional?.AuthoredOnElement;
                CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Convert<CqlDateTime>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                Period mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = SecondHTNEncounterReading140Over90?.Period;
                CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.In<CqlDateTime>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, "day");

                return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
            };
            IEnumerable<ServiceRequest> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Where<ServiceRequest>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            Encounter mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_(ServiceRequest ReferralToProfessional) =>
                SecondHTNEncounterReading140Over90;
            IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Select<ServiceRequest, Encounter>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

            return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.SelectMany<Encounter, Encounter>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Union<Encounter>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);

        return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition(
        definitionName: "Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context)
    {
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Encounter_with_Normal_Blood_Pressure_Reading(context);
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Encounter_with_Elevated_Blood_Pressure_Reading_SBP_120_to_129_AND_DBP_less_than_80_and_Interventions(context);
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Union<Encounter>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Encounter_with_First_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_130_OR_DBP_Greater_than_or_Equal_to_80_and_Interventions(context);
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Encounter_with_Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89_and_Interventions(context);
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Union<Encounter>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Union<Encounter>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Encounter_with_Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90_and_Interventions(context);
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Union<Encounter>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

        return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition(
        definitionName: "Encounter with Medical Reason for Not Obtaining or Patient Declined Blood Pressure Measurement")]
    public IEnumerable<Encounter> Encounter_with_Medical_Reason_for_Not_Obtaining_or_Patient_Declined_Blood_Pressure_Measurement(CqlContext context)
    {
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Qualifying_Encounter_during_Measurement_Period(context);
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_(Encounter QualifyingEncounter)
        {
            CqlCode mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Systolic_blood_pressure(context);
            IEnumerable<CqlCode> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.ToList<CqlCode>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            IEnumerable<Observation> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observationnotdone"));
            CqlCode nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Diastolic_blood_pressure(context);
            IEnumerable<CqlCode> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.ToList<CqlCode>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            IEnumerable<Observation> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observationnotdone"));
            IEnumerable<Observation> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Union<Observation>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_(Observation NoBPScreen)
            {
                Instant nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = NoBPScreen?.IssuedElement;
                DateTimeOffset? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_?.Value;
                CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Convert<CqlDateTime>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                Period nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.In<CqlDateTime>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, "day");
                bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_(Extension @this)
                {
                    string ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = @this?.Url;
                    FhirString ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Convert<FhirString>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                    string ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToString(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                    bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Equal(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-notDoneReason");

                    return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
                };
                IEnumerable<Extension> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(NoBPScreen is DomainResource
                        ? (NoBPScreen as DomainResource).Extension
                        : default), nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                object nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_(Extension @this)
                {
                    DataType ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = @this?.Value;

                    return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
                };
                IEnumerable<object> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Select<Extension, object>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                object nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.SingletonFrom<object>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                CqlConcept nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ as CodeableConcept);
                CqlValueSet nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Patient_Declined(context);
                bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.ConceptInValueSet(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_(Extension @this)
                {
                    string ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = @this?.Url;
                    FhirString ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Convert<FhirString>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                    string ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToString(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                    bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Equal(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-notDoneReason");

                    return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
                };
                IEnumerable<Extension> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(NoBPScreen is DomainResource
                        ? (NoBPScreen as DomainResource).Extension
                        : default), nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                object nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_(Extension @this)
                {
                    DataType ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = @this?.Value;

                    return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
                };
                IEnumerable<object> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Select<Extension, object>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                object ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.SingletonFrom<object>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                CqlConcept ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ as CodeableConcept);
                CqlValueSet ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Medical_Reason(context);
                bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.ConceptInValueSet(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Or(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.And(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                Code<ObservationStatus> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = NoBPScreen?.StatusElement;
                ObservationStatus? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_?.Value;
                Code<ObservationStatus> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Convert<Code<ObservationStatus>>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Equal(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, "cancelled");
                bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

                return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
            };
            IEnumerable<Observation> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Where<Observation>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            Encounter nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_(Observation NoBPScreen) =>
                QualifyingEncounter;
            IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Select<Observation, Encounter>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);

            return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
        };
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.SelectMany<Encounter, Encounter>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);

        return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition(
        definitionName: "NonPharmacological Intervention Not Ordered")]
    public IEnumerable<ServiceRequest> NonPharmacological_Intervention_Not_Ordered(CqlContext context)
    {
        CqlValueSet ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Lifestyle_Recommendation(context);
        IEnumerable<ServiceRequest> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Union<ServiceRequest>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
        CqlValueSet pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Weight_Reduction_Recommended(context);
        IEnumerable<ServiceRequest> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Union<ServiceRequest>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        IEnumerable<ServiceRequest> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Union<ServiceRequest>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
        CqlValueSet pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Dietary_Recommendations(context);
        IEnumerable<ServiceRequest> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Union<ServiceRequest>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        IEnumerable<ServiceRequest> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Union<ServiceRequest>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
        CqlValueSet pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Recommendation_to_Increase_Physical_Activity(context);
        IEnumerable<ServiceRequest> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Union<ServiceRequest>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        IEnumerable<ServiceRequest> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Union<ServiceRequest>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
        CqlValueSet pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Referral_or_Counseling_for_Alcohol_Consumption(context);
        IEnumerable<ServiceRequest> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Union<ServiceRequest>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
        IEnumerable<ServiceRequest> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Union<ServiceRequest>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
        bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_(ServiceRequest NonPharmIntervention)
        {
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_(Extension @this)
            {
                string qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = @this?.Url;
                FhirString qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Convert<FhirString>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                string qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToString(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Equal(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerformReason");

                return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
            };
            IEnumerable<Extension> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(NonPharmIntervention is DomainResource
                    ? (NonPharmIntervention as DomainResource).Extension
                    : default), qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            object qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_(Extension @this)
            {
                DataType qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = @this?.Value;

                return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
            };
            IEnumerable<object> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Select<Extension, object>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            object qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.SingletonFrom<object>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            CqlConcept qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ as CodeableConcept);
            CqlValueSet qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Patient_Declined(context);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.ConceptInValueSet(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            Code<RequestStatus> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = NonPharmIntervention?.StatusElement;
            RequestStatus? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_?.Value;
            Code<RequestStatus> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Convert<Code<RequestStatus>>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Equal(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, "completed");
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.And(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);

            return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<ServiceRequest> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Where<ServiceRequest>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

        return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition(
        definitionName: "Laboratory Test or ECG for Hypertension Not Ordered")]
    public IEnumerable<ServiceRequest> Laboratory_Test_or_ECG_for_Hypertension_Not_Ordered(CqlContext context)
    {
        CqlCode qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this._12_lead_EKG_panel(context);
        IEnumerable<CqlCode> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.ToList<CqlCode>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
        IEnumerable<ServiceRequest> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, default, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        CqlCode qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.EKG_study(context);
        IEnumerable<CqlCode> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.ToList<CqlCode>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
        IEnumerable<ServiceRequest> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, default, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Union<ServiceRequest>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
        CqlValueSet rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Laboratory_Tests_for_Hypertension(context);
        IEnumerable<ServiceRequest> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Union<ServiceRequest>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
        IEnumerable<ServiceRequest> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Union<ServiceRequest>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_(ServiceRequest LabECGNotDone)
        {
            bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_(Extension @this)
            {
                string rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = @this?.Url;
                FhirString rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Convert<FhirString>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                string rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToString(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Equal(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerformReason");

                return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
            };
            IEnumerable<Extension> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(LabECGNotDone is DomainResource
                    ? (LabECGNotDone as DomainResource).Extension
                    : default), rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            object rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_(Extension @this)
            {
                DataType rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = @this?.Value;

                return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
            };
            IEnumerable<object> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Select<Extension, object>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            object rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.SingletonFrom<object>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            CqlConcept rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ as CodeableConcept);
            CqlValueSet rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Patient_Declined(context);
            bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.ConceptInValueSet(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);

            return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<ServiceRequest> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Where<ServiceRequest>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);

        return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition(
        definitionName: "Second Hypertensive Reading SBP 130 to 139 OR DBP 80 to 89 Interventions Declined")]
    public IEnumerable<ServiceRequest> Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89_Interventions_Declined(CqlContext context)
    {
        CqlValueSet rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Referral_to_Primary_Care_or_Alternate_Provider(context);
        IEnumerable<ServiceRequest> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Union<ServiceRequest>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
        CqlValueSet szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Follow_Up_Within_6_Months(context);
        IEnumerable<ServiceRequest> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Union<ServiceRequest>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
        IEnumerable<ServiceRequest> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Union<ServiceRequest>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_(ServiceRequest SecondHTNDeclinedReferralAndFollowUp)
        {
            bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_(Extension @this)
            {
                string szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = @this?.Url;
                FhirString tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Convert<FhirString>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                string tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToString(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Equal(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerformReason");

                return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
            };
            IEnumerable<Extension> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(SecondHTNDeclinedReferralAndFollowUp is DomainResource
                    ? (SecondHTNDeclinedReferralAndFollowUp as DomainResource).Extension
                    : default), szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            object szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_(Extension @this)
            {
                DataType tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = @this?.Value;

                return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
            };
            IEnumerable<object> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Select<Extension, object>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            object szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.SingletonFrom<object>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            CqlConcept szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ as CodeableConcept);
            CqlValueSet szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Patient_Declined(context);
            bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.ConceptInValueSet(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            Code<RequestStatus> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = SecondHTNDeclinedReferralAndFollowUp?.StatusElement;
            RequestStatus? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_?.Value;
            Code<RequestStatus> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Convert<Code<RequestStatus>>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Equal(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, "completed");
            bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.And(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);

            return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<ServiceRequest> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Where<ServiceRequest>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
        IEnumerable<ServiceRequest> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Laboratory_Test_or_ECG_for_Hypertension_Not_Ordered(context);
        IEnumerable<ServiceRequest> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Union<ServiceRequest>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        IEnumerable<ServiceRequest> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.NonPharmacological_Intervention_Not_Ordered(context);
        IEnumerable<ServiceRequest> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Union<ServiceRequest>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

        return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition(
        definitionName: "Second Hypertensive Reading SBP Greater than or Equal to 140 OR DBP Greater than or Equal to 90 Interventions Declined")]
    public IEnumerable<object> Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90_Interventions_Declined(CqlContext context)
    {
        CqlValueSet tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Referral_to_Primary_Care_or_Alternate_Provider(context);
        IEnumerable<ServiceRequest> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Union<ServiceRequest>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
        CqlValueSet tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Follow_Up_Within_4_Weeks(context);
        IEnumerable<ServiceRequest> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Union<ServiceRequest>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        IEnumerable<ServiceRequest> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Union<ServiceRequest>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_(ServiceRequest SecondHTN140Over90ReferralFollowUpNotDone)
        {
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_(Extension @this)
            {
                string uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = @this?.Url;
                FhirString uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Convert<FhirString>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                string uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToString(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Equal(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerformReason");

                return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
            };
            IEnumerable<Extension> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(SecondHTN140Over90ReferralFollowUpNotDone is DomainResource
                    ? (SecondHTN140Over90ReferralFollowUpNotDone as DomainResource).Extension
                    : default), uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            object uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_(Extension @this)
            {
                DataType uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = @this?.Value;

                return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
            };
            IEnumerable<object> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Select<Extension, object>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            object uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.SingletonFrom<object>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlConcept uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ as CodeableConcept);
            CqlValueSet uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Patient_Declined(context);
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.ConceptInValueSet(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            Code<RequestStatus> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = SecondHTN140Over90ReferralFollowUpNotDone?.StatusElement;
            RequestStatus? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_?.Value;
            Code<RequestStatus> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Convert<Code<RequestStatus>>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Equal(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, "completed");
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.And(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);

            return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<ServiceRequest> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Where<ServiceRequest>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        CqlValueSet tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Pharmacologic_Therapy_for_Hypertension(context);
        IEnumerable<MedicationRequest> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-mednotrequested"));
        IEnumerable<MedicationRequest> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-mednotrequested"));
        IEnumerable<MedicationRequest> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Union<MedicationRequest>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
        bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_(MedicationRequest MedicationRequestNotOrdered)
        {
            Code<MedicationRequest.MedicationrequestStatus> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = MedicationRequestNotOrdered?.StatusElement;
            MedicationRequest.MedicationrequestStatus? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_?.Value;
            string uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Convert<string>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Equal(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, "completed");

            return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<MedicationRequest> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Where<MedicationRequest>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
        IEnumerable<object> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Union<object>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ as IEnumerable<object>, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ as IEnumerable<object>);
        IEnumerable<ServiceRequest> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Laboratory_Test_or_ECG_for_Hypertension_Not_Ordered(context);
        IEnumerable<object> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Union<object>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ as IEnumerable<object>, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ as IEnumerable<object>);
        IEnumerable<ServiceRequest> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.NonPharmacological_Intervention_Not_Ordered(context);
        IEnumerable<object> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Union<object>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ as IEnumerable<object>, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ as IEnumerable<object>);

        return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition(
        definitionName: "Encounter with Order for Hypertension Follow Up Declined by Patient")]
    public IEnumerable<Encounter> Encounter_with_Order_for_Hypertension_Follow_Up_Declined_by_Patient(CqlContext context)
    {
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Encounter_with_Elevated_Blood_Pressure_Reading_SBP_120_to_129_AND_DBP_less_than_80(context);
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_(Encounter ElevatedBPEncounter)
        {
            CqlValueSet vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Referral_to_Primary_Care_or_Alternate_Provider(context);
            IEnumerable<ServiceRequest> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
            IEnumerable<ServiceRequest> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
            IEnumerable<ServiceRequest> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Union<ServiceRequest>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            CqlValueSet wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Follow_Up_Within_6_Months(context);
            IEnumerable<ServiceRequest> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
            IEnumerable<ServiceRequest> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
            IEnumerable<ServiceRequest> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Union<ServiceRequest>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            IEnumerable<ServiceRequest> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Union<ServiceRequest>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_(ServiceRequest ElevatedBPDeclinedInterventions)
            {
                bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_(Extension @this)
                {
                    string xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = @this?.Url;
                    FhirString xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Convert<FhirString>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                    string xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToString(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                    bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Equal(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerformReason");

                    return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
                };
                IEnumerable<Extension> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(ElevatedBPDeclinedInterventions is DomainResource
                        ? (ElevatedBPDeclinedInterventions as DomainResource).Extension
                        : default), wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                object wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_(Extension @this)
                {
                    DataType xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = @this?.Value;

                    return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
                };
                IEnumerable<object> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Select<Extension, object>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                object wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.SingletonFrom<object>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                CqlConcept wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ as CodeableConcept);
                CqlValueSet wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Patient_Declined(context);
                bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.ConceptInValueSet(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                FhirDateTime wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = ElevatedBPDeclinedInterventions?.AuthoredOnElement;
                CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Convert<CqlDateTime>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                Period wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = ElevatedBPEncounter?.Period;
                CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.In<CqlDateTime>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, "day");
                bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.And(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                Code<RequestStatus> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = ElevatedBPDeclinedInterventions?.StatusElement;
                RequestStatus? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_?.Value;
                Code<RequestStatus> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Convert<Code<RequestStatus>>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Equal(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, "completed");
                bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.And(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);

                return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
            };
            IEnumerable<ServiceRequest> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<ServiceRequest>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            Encounter wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_(ServiceRequest ElevatedBPDeclinedInterventions) =>
                ElevatedBPEncounter;
            IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Select<ServiceRequest, Encounter>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);

            return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.SelectMany<Encounter, Encounter>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_(Encounter ElevatedBPEncounter)
        {
            IEnumerable<ServiceRequest> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.NonPharmacological_Intervention_Not_Ordered(context);
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_(ServiceRequest NotOrdered)
            {
                FhirDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = NotOrdered?.AuthoredOnElement;
                CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Convert<CqlDateTime>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                Period xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = ElevatedBPEncounter?.Period;
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.In<CqlDateTime>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, "day");

                return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
            };
            IEnumerable<ServiceRequest> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<ServiceRequest>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            Encounter xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_(ServiceRequest NotOrdered) =>
                ElevatedBPEncounter;
            IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Select<ServiceRequest, Encounter>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);

            return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.SelectMany<Encounter, Encounter>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Union<Encounter>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Encounter_with_First_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_130_OR_DBP_Greater_than_or_Equal_to_80(context);
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_(Encounter FirstHTNEncounter)
        {
            CqlValueSet xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Follow_Up_Within_4_Weeks(context);
            IEnumerable<ServiceRequest> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
            IEnumerable<ServiceRequest> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
            IEnumerable<ServiceRequest> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Union<ServiceRequest>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            CqlValueSet xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Referral_to_Primary_Care_or_Alternate_Provider(context);
            IEnumerable<ServiceRequest> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
            IEnumerable<ServiceRequest> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
            IEnumerable<ServiceRequest> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Union<ServiceRequest>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            IEnumerable<ServiceRequest> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Union<ServiceRequest>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_(ServiceRequest FirstHTNDeclinedInterventions)
            {
                bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_(Extension @this)
                {
                    string zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = @this?.Url;
                    FhirString zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Convert<FhirString>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                    string zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToString(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                    bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Equal(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerformReason");

                    return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
                };
                IEnumerable<Extension> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(FirstHTNDeclinedInterventions is DomainResource
                        ? (FirstHTNDeclinedInterventions as DomainResource).Extension
                        : default), yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                object yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_(Extension @this)
                {
                    DataType zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = @this?.Value;

                    return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
                };
                IEnumerable<object> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Select<Extension, object>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                object yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.SingletonFrom<object>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                CqlConcept yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ as CodeableConcept);
                CqlValueSet yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Patient_Declined(context);
                bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.ConceptInValueSet(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                FhirDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FirstHTNDeclinedInterventions?.AuthoredOnElement;
                CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Convert<CqlDateTime>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                Period yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = FirstHTNEncounter?.Period;
                CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.In<CqlDateTime>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, "day");
                bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.And(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                Code<RequestStatus> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = FirstHTNDeclinedInterventions?.StatusElement;
                RequestStatus? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_?.Value;
                Code<RequestStatus> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Convert<Code<RequestStatus>>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Equal(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, "completed");
                bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.And(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

                return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
            };
            IEnumerable<ServiceRequest> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Where<ServiceRequest>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            Encounter yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_(ServiceRequest FirstHTNDeclinedInterventions) =>
                FirstHTNEncounter;
            IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Select<ServiceRequest, Encounter>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);

            return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.SelectMany<Encounter, Encounter>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_(Encounter FirstHTNEncounter)
        {
            IEnumerable<ServiceRequest> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.NonPharmacological_Intervention_Not_Ordered(context);
            bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_(ServiceRequest NoNonPharm)
            {
                FhirDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = NoNonPharm?.AuthoredOnElement;
                CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Convert<CqlDateTime>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                Period zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FirstHTNEncounter?.Period;
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.In<CqlDateTime>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, "day");

                return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
            };
            IEnumerable<ServiceRequest> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<ServiceRequest>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            Encounter zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_(ServiceRequest NoNonPharm) =>
                FirstHTNEncounter;
            IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Select<ServiceRequest, Encounter>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);

            return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.SelectMany<Encounter, Encounter>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Union<Encounter>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Union<Encounter>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Encounter_with_Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89(context);
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_(Encounter SecondHTNEncounter)
        {
            IEnumerable<ServiceRequest> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89_Interventions_Declined(context);
            bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_(ServiceRequest SecondHTNDeclinedInterventions)
            {
                FhirDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = SecondHTNDeclinedInterventions?.AuthoredOnElement;
                CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Convert<CqlDateTime>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                Period zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = SecondHTNEncounter?.Period;
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.In<CqlDateTime>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, "day");

                return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
            };
            IEnumerable<ServiceRequest> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Where<ServiceRequest>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            Encounter zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_(ServiceRequest SecondHTNDeclinedInterventions) =>
                SecondHTNEncounter;
            IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Select<ServiceRequest, Encounter>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

            return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.SelectMany<Encounter, Encounter>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Encounter_with_Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90(context);
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_(Encounter SecondHTN140Over90Encounter)
        {
            IEnumerable<object> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90_Interventions_Declined(context);
            bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_(object SecondHTN140Over90DeclinedInterventions)
            {
                object azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.LateBoundProperty<object>(SecondHTN140Over90DeclinedInterventions, "authoredOn");
                CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.LateBoundProperty<CqlDateTime>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, "value");
                Period azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = SecondHTN140Over90Encounter?.Period;
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.In<CqlDateTime>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, "day");

                return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
            };
            IEnumerable<object> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Where<object>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            Encounter azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_(object SecondHTN140Over90DeclinedInterventions) =>
                SecondHTN140Over90Encounter;
            IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Select<object, Encounter>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);

            return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
        };
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.SelectMany<Encounter, Encounter>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Union<Encounter>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Union<Encounter>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);

        return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator Exceptions")]
    public IEnumerable<Encounter> Denominator_Exceptions(CqlContext context)
    {
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Encounter_with_Medical_Reason_for_Not_Obtaining_or_Patient_Declined_Blood_Pressure_Measurement(context);
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Encounter_with_Order_for_Hypertension_Follow_Up_Declined_by_Patient(context);
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Union<Encounter>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);

        return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
    }


    #endregion Expressions

}
