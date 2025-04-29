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

    [CqlValueSetDefinition("Diagnosis of Hypertension", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.263", valueSetVersion: null)]
    public CqlValueSet Diagnosis_of_Hypertension(CqlContext _) => _Diagnosis_of_Hypertension;
    private static readonly CqlValueSet _Diagnosis_of_Hypertension = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.263", null);

    [CqlValueSetDefinition("Dietary Recommendations", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1515", valueSetVersion: null)]
    public CqlValueSet Dietary_Recommendations(CqlContext _) => _Dietary_Recommendations;
    private static readonly CqlValueSet _Dietary_Recommendations = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1515", null);

    [CqlValueSetDefinition("Encounter to Screen for Blood Pressure", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1920", valueSetVersion: null)]
    public CqlValueSet Encounter_to_Screen_for_Blood_Pressure(CqlContext _) => _Encounter_to_Screen_for_Blood_Pressure;
    private static readonly CqlValueSet _Encounter_to_Screen_for_Blood_Pressure = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1920", null);

    [CqlValueSetDefinition("Finding of Elevated Blood Pressure or Hypertension", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.514", valueSetVersion: null)]
    public CqlValueSet Finding_of_Elevated_Blood_Pressure_or_Hypertension(CqlContext _) => _Finding_of_Elevated_Blood_Pressure_or_Hypertension;
    private static readonly CqlValueSet _Finding_of_Elevated_Blood_Pressure_or_Hypertension = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.514", null);

    [CqlValueSetDefinition("Follow Up Within 4 Weeks", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1578", valueSetVersion: null)]
    public CqlValueSet Follow_Up_Within_4_Weeks(CqlContext _) => _Follow_Up_Within_4_Weeks;
    private static readonly CqlValueSet _Follow_Up_Within_4_Weeks = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1578", null);

    [CqlValueSetDefinition("Follow Up Within 6 Months", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1108.125", valueSetVersion: null)]
    public CqlValueSet Follow_Up_Within_6_Months(CqlContext _) => _Follow_Up_Within_6_Months;
    private static readonly CqlValueSet _Follow_Up_Within_6_Months = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1108.125", null);

    [CqlValueSetDefinition("Laboratory Tests for Hypertension", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1482", valueSetVersion: null)]
    public CqlValueSet Laboratory_Tests_for_Hypertension(CqlContext _) => _Laboratory_Tests_for_Hypertension;
    private static readonly CqlValueSet _Laboratory_Tests_for_Hypertension = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1482", null);

    [CqlValueSetDefinition("Lifestyle Recommendation", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1581", valueSetVersion: null)]
    public CqlValueSet Lifestyle_Recommendation(CqlContext _) => _Lifestyle_Recommendation;
    private static readonly CqlValueSet _Lifestyle_Recommendation = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1581", null);

    [CqlValueSetDefinition("Medical Reason", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1007", valueSetVersion: null)]
    public CqlValueSet Medical_Reason(CqlContext _) => _Medical_Reason;
    private static readonly CqlValueSet _Medical_Reason = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1007", null);

    [CqlValueSetDefinition("Patient Declined", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1582", valueSetVersion: null)]
    public CqlValueSet Patient_Declined(CqlContext _) => _Patient_Declined;
    private static readonly CqlValueSet _Patient_Declined = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1582", null);

    [CqlValueSetDefinition("Pharmacologic Therapy for Hypertension", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.1577", valueSetVersion: null)]
    public CqlValueSet Pharmacologic_Therapy_for_Hypertension(CqlContext _) => _Pharmacologic_Therapy_for_Hypertension;
    private static readonly CqlValueSet _Pharmacologic_Therapy_for_Hypertension = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.1577", null);

    [CqlValueSetDefinition("Recommendation to Increase Physical Activity", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1518", valueSetVersion: null)]
    public CqlValueSet Recommendation_to_Increase_Physical_Activity(CqlContext _) => _Recommendation_to_Increase_Physical_Activity;
    private static readonly CqlValueSet _Recommendation_to_Increase_Physical_Activity = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1518", null);

    [CqlValueSetDefinition("Referral or Counseling for Alcohol Consumption", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1583", valueSetVersion: null)]
    public CqlValueSet Referral_or_Counseling_for_Alcohol_Consumption(CqlContext _) => _Referral_or_Counseling_for_Alcohol_Consumption;
    private static readonly CqlValueSet _Referral_or_Counseling_for_Alcohol_Consumption = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1583", null);

    [CqlValueSetDefinition("Referral to Primary Care or Alternate Provider", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1580", valueSetVersion: null)]
    public CqlValueSet Referral_to_Primary_Care_or_Alternate_Provider(CqlContext _) => _Referral_to_Primary_Care_or_Alternate_Provider;
    private static readonly CqlValueSet _Referral_to_Primary_Care_or_Alternate_Provider = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1580", null);

    [CqlValueSetDefinition("Weight Reduction Recommended", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1510", valueSetVersion: null)]
    public CqlValueSet Weight_Reduction_Recommended(CqlContext _) => _Weight_Reduction_Recommended;
    private static readonly CqlValueSet _Weight_Reduction_Recommended = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1510", null);

    #endregion ValueSets

    #region Codes

    [CqlCodeDefinition("Diastolic blood pressure", codeId: "8462-4", codeSystem: "http://loinc.org")]
    public CqlCode Diastolic_blood_pressure(CqlContext _) => _Diastolic_blood_pressure;
    private static readonly CqlCode _Diastolic_blood_pressure = new CqlCode("8462-4", "http://loinc.org", default, default);

    [CqlCodeDefinition("12 lead EKG panel", codeId: "34534-8", codeSystem: "http://loinc.org")]
    public CqlCode _12_lead_EKG_panel(CqlContext _) => __12_lead_EKG_panel;
    private static readonly CqlCode __12_lead_EKG_panel = new CqlCode("34534-8", "http://loinc.org", default, default);

    [CqlCodeDefinition("EKG study", codeId: "11524-6", codeSystem: "http://loinc.org")]
    public CqlCode EKG_study(CqlContext _) => _EKG_study;
    private static readonly CqlCode _EKG_study = new CqlCode("11524-6", "http://loinc.org", default, default);

    [CqlCodeDefinition("Systolic blood pressure", codeId: "8480-6", codeSystem: "http://loinc.org")]
    public CqlCode Systolic_blood_pressure(CqlContext _) => _Systolic_blood_pressure;
    private static readonly CqlCode _Systolic_blood_pressure = new CqlCode("8480-6", "http://loinc.org", default, default);

    [CqlCodeDefinition("virtual", codeId: "VR", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-ActCode")]
    public CqlCode @virtual(CqlContext _) => _virtual;
    private static readonly CqlCode _virtual = new CqlCode("VR", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default);

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("ActCode")]
    public CqlCodeSystem ActCode(CqlContext _) => _ActCode;
    private static readonly CqlCodeSystem _ActCode = new CqlCodeSystem();

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
        CqlDateTime tzzzzzzzzzzzzzzzzzzf_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime tzzzzzzzzzzzzzzzzzzg_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzh_ = context.Operators.Interval(tzzzzzzzzzzzzzzzzzzf_, tzzzzzzzzzzzzzzzzzzg_, true, true);
        object tzzzzzzzzzzzzzzzzzzi_ = context.ResolveParameter("PCSBPScreeningFollowUpFHIR-0.2.000", "Measurement Period", tzzzzzzzzzzzzzzzzzzh_);

        return (CqlInterval<CqlDateTime>)tzzzzzzzzzzzzzzzzzzi_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> tzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient tzzzzzzzzzzzzzzzzzzk_ = context.Operators.SingletonFrom<Patient>(tzzzzzzzzzzzzzzzzzzj_);

        return tzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Qualifying Encounter during Measurement Period")]
    public IEnumerable<Encounter> Qualifying_Encounter_during_Measurement_Period(CqlContext context)
    {
        CqlValueSet tzzzzzzzzzzzzzzzzzzl_ = this.Encounter_to_Screen_for_Blood_Pressure(context);
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? tzzzzzzzzzzzzzzzzzzn_(Encounter ValidEncounter)
        {
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzp_ = this.Measurement_Period(context);
            Period tzzzzzzzzzzzzzzzzzzq_ = ValidEncounter?.Period;
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzzzzzzzzzzzzzzzq_);
            bool? tzzzzzzzzzzzzzzzzzzs_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(tzzzzzzzzzzzzzzzzzzp_, tzzzzzzzzzzzzzzzzzzr_, "day");
            Code<Encounter.EncounterStatus> tzzzzzzzzzzzzzzzzzzt_ = ValidEncounter?.StatusElement;
            Encounter.EncounterStatus? tzzzzzzzzzzzzzzzzzzu_ = tzzzzzzzzzzzzzzzzzzt_?.Value;
            Code<Encounter.EncounterStatus> tzzzzzzzzzzzzzzzzzzv_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(tzzzzzzzzzzzzzzzzzzu_);
            bool? tzzzzzzzzzzzzzzzzzzw_ = context.Operators.Equivalent(tzzzzzzzzzzzzzzzzzzv_, "finished");
            bool? tzzzzzzzzzzzzzzzzzzx_ = context.Operators.And(tzzzzzzzzzzzzzzzzzzs_, tzzzzzzzzzzzzzzzzzzw_);
            Coding tzzzzzzzzzzzzzzzzzzy_ = ValidEncounter?.Class;
            CqlCode tzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToCode(context, tzzzzzzzzzzzzzzzzzzy_);
            CqlCode uzzzzzzzzzzzzzzzzzza_ = this.@virtual(context);
            bool? uzzzzzzzzzzzzzzzzzzb_ = context.Operators.Equivalent(tzzzzzzzzzzzzzzzzzzz_, uzzzzzzzzzzzzzzzzzza_);
            bool? uzzzzzzzzzzzzzzzzzzc_ = context.Operators.Not(uzzzzzzzzzzzzzzzzzzb_);
            bool? uzzzzzzzzzzzzzzzzzzd_ = context.Operators.And(tzzzzzzzzzzzzzzzzzzx_, uzzzzzzzzzzzzzzzzzzc_);

            return uzzzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<Encounter>(tzzzzzzzzzzzzzzzzzzm_, tzzzzzzzzzzzzzzzzzzn_);

        return tzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzze_ = this.Qualifying_Encounter_during_Measurement_Period(context);
        bool? uzzzzzzzzzzzzzzzzzzf_(Encounter QualifyingEncounter)
        {
            Patient uzzzzzzzzzzzzzzzzzzh_ = this.Patient(context);
            Date uzzzzzzzzzzzzzzzzzzi_ = uzzzzzzzzzzzzzzzzzzh_?.BirthDateElement;
            string uzzzzzzzzzzzzzzzzzzj_ = uzzzzzzzzzzzzzzzzzzi_?.Value;
            CqlDateTime uzzzzzzzzzzzzzzzzzzk_ = context.Operators.ConvertStringToDateTime(uzzzzzzzzzzzzzzzzzzj_);
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzl_ = this.Measurement_Period(context);
            CqlDateTime uzzzzzzzzzzzzzzzzzzm_ = context.Operators.Start(uzzzzzzzzzzzzzzzzzzl_);
            int? uzzzzzzzzzzzzzzzzzzn_ = context.Operators.CalculateAgeAt(uzzzzzzzzzzzzzzzzzzk_, uzzzzzzzzzzzzzzzzzzm_, "year");
            bool? uzzzzzzzzzzzzzzzzzzo_ = context.Operators.GreaterOrEqual(uzzzzzzzzzzzzzzzzzzn_, 18);

            return uzzzzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzg_ = context.Operators.Where<Encounter>(uzzzzzzzzzzzzzzzzzze_, uzzzzzzzzzzzzzzzzzzf_);

        return uzzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context)
    {
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzp_ = this.Initial_Population(context);

        return uzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public IEnumerable<Encounter> Denominator_Exclusions(CqlContext context)
    {
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzq_ = this.Qualifying_Encounter_during_Measurement_Period(context);
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzr_(Encounter QualifyingEncounter)
        {
            CqlValueSet uzzzzzzzzzzzzzzzzzzt_ = this.Diagnosis_of_Hypertension(context);
            IEnumerable<Condition> uzzzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            bool? uzzzzzzzzzzzzzzzzzzv_(Condition Hypertension)
            {
                bool? uzzzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.isProblemListItem(context, Hypertension);
                bool? vzzzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.isHealthConcern(context, Hypertension);
                bool? vzzzzzzzzzzzzzzzzzzb_ = context.Operators.Or(uzzzzzzzzzzzzzzzzzzz_, vzzzzzzzzzzzzzzzzzza_);
                CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzc_()
                {
                    bool vzzzzzzzzzzzzzzzzzzh_()
                    {
                        CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, Hypertension);
                        CqlDateTime vzzzzzzzzzzzzzzzzzzj_ = context.Operators.Start(vzzzzzzzzzzzzzzzzzzi_);

                        return vzzzzzzzzzzzzzzzzzzj_ is null;
                    };
                    if (vzzzzzzzzzzzzzzzzzzh_())
                    {
                        return default;
                    }
                    else
                    {
                        CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, Hypertension);
                        CqlDateTime vzzzzzzzzzzzzzzzzzzl_ = context.Operators.Start(vzzzzzzzzzzzzzzzzzzk_);
                        CqlDateTime vzzzzzzzzzzzzzzzzzzn_ = context.Operators.Start(vzzzzzzzzzzzzzzzzzzk_);
                        CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzo_ = context.Operators.Interval(vzzzzzzzzzzzzzzzzzzl_, vzzzzzzzzzzzzzzzzzzn_, true, true);

                        return vzzzzzzzzzzzzzzzzzzo_;
                    }
                };
                Period vzzzzzzzzzzzzzzzzzzd_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzzzzzzzzzzzzzzzd_);
                bool? vzzzzzzzzzzzzzzzzzzf_ = context.Operators.SameOrBefore(vzzzzzzzzzzzzzzzzzzc_(), vzzzzzzzzzzzzzzzzzze_, "day");
                bool? vzzzzzzzzzzzzzzzzzzg_ = context.Operators.And(vzzzzzzzzzzzzzzzzzzb_, vzzzzzzzzzzzzzzzzzzf_);

                return vzzzzzzzzzzzzzzzzzzg_;
            };
            IEnumerable<Condition> uzzzzzzzzzzzzzzzzzzw_ = context.Operators.Where<Condition>(uzzzzzzzzzzzzzzzzzzu_, uzzzzzzzzzzzzzzzzzzv_);
            Encounter uzzzzzzzzzzzzzzzzzzx_(Condition Hypertension) =>
                QualifyingEncounter;
            IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzy_ = context.Operators.Select<Condition, Encounter>(uzzzzzzzzzzzzzzzzzzw_, uzzzzzzzzzzzzzzzzzzx_);

            return uzzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzs_ = context.Operators.SelectMany<Encounter, Encounter>(uzzzzzzzzzzzzzzzzzzq_, uzzzzzzzzzzzzzzzzzzr_);

        return uzzzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Encounter with Normal Blood Pressure Reading")]
    public IEnumerable<Encounter> Encounter_with_Normal_Blood_Pressure_Reading(CqlContext context)
    {
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzp_ = this.Qualifying_Encounter_during_Measurement_Period(context);
        bool? vzzzzzzzzzzzzzzzzzzq_(Encounter QualifyingEncounter)
        {
            IEnumerable<Observation> vzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/bp"));
            bool? vzzzzzzzzzzzzzzzzzzt_(Observation BloodPressure)
            {
                DataType wzzzzzzzzzzzzzzzzzzz_ = BloodPressure?.Effective;
                object xzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzz_);
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.toInterval(context, xzzzzzzzzzzzzzzzzzza_);
                CqlDateTime xzzzzzzzzzzzzzzzzzzc_ = context.Operators.End(xzzzzzzzzzzzzzzzzzzb_);
                Period xzzzzzzzzzzzzzzzzzzd_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzzzzzzzzzzzzzd_);
                bool? xzzzzzzzzzzzzzzzzzzf_ = context.Operators.In<CqlDateTime>(xzzzzzzzzzzzzzzzzzzc_, xzzzzzzzzzzzzzzzzzze_, default);
                Code<ObservationStatus> xzzzzzzzzzzzzzzzzzzg_ = BloodPressure?.StatusElement;
                ObservationStatus? xzzzzzzzzzzzzzzzzzzh_ = xzzzzzzzzzzzzzzzzzzg_?.Value;
                string xzzzzzzzzzzzzzzzzzzi_ = context.Operators.Convert<string>(xzzzzzzzzzzzzzzzzzzh_);
                string[] xzzzzzzzzzzzzzzzzzzj_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? xzzzzzzzzzzzzzzzzzzk_ = context.Operators.In<string>(xzzzzzzzzzzzzzzzzzzi_, xzzzzzzzzzzzzzzzzzzj_ as IEnumerable<string>);
                bool? xzzzzzzzzzzzzzzzzzzl_ = context.Operators.And(xzzzzzzzzzzzzzzzzzzf_, xzzzzzzzzzzzzzzzzzzk_);

                return xzzzzzzzzzzzzzzzzzzl_;
            };
            IEnumerable<Observation> vzzzzzzzzzzzzzzzzzzu_ = context.Operators.Where<Observation>(vzzzzzzzzzzzzzzzzzzs_, vzzzzzzzzzzzzzzzzzzt_);
            object vzzzzzzzzzzzzzzzzzzv_(Observation @this)
            {
                DataType xzzzzzzzzzzzzzzzzzzm_ = @this?.Effective;
                object xzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzm_);
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.toInterval(context, xzzzzzzzzzzzzzzzzzzn_);
                CqlDateTime xzzzzzzzzzzzzzzzzzzp_ = context.Operators.Start(xzzzzzzzzzzzzzzzzzzo_);

                return xzzzzzzzzzzzzzzzzzzp_;
            };
            IEnumerable<Observation> vzzzzzzzzzzzzzzzzzzw_ = context.Operators.SortBy<Observation>(vzzzzzzzzzzzzzzzzzzu_, vzzzzzzzzzzzzzzzzzzv_, System.ComponentModel.ListSortDirection.Ascending);
            Observation vzzzzzzzzzzzzzzzzzzx_ = context.Operators.Last<Observation>(vzzzzzzzzzzzzzzzzzzw_);
            List<Observation.ComponentComponent> vzzzzzzzzzzzzzzzzzzy_ = vzzzzzzzzzzzzzzzzzzx_?.Component;
            bool? vzzzzzzzzzzzzzzzzzzz_(Observation.ComponentComponent @this)
            {
                CodeableConcept xzzzzzzzzzzzzzzzzzzq_ = @this?.Code;
                List<Coding> xzzzzzzzzzzzzzzzzzzr_ = xzzzzzzzzzzzzzzzzzzq_?.Coding;
                Coding xzzzzzzzzzzzzzzzzzzs_ = context.Operators.First<Coding>((IEnumerable<Coding>)xzzzzzzzzzzzzzzzzzzr_);
                FhirUri xzzzzzzzzzzzzzzzzzzt_ = xzzzzzzzzzzzzzzzzzzs_?.SystemElement;
                string xzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToString(context, xzzzzzzzzzzzzzzzzzzt_);
                bool? xzzzzzzzzzzzzzzzzzzv_ = context.Operators.Equal(xzzzzzzzzzzzzzzzzzzu_, "http://loinc.org");
                List<Coding> xzzzzzzzzzzzzzzzzzzx_ = xzzzzzzzzzzzzzzzzzzq_?.Coding;
                Coding xzzzzzzzzzzzzzzzzzzy_ = context.Operators.First<Coding>((IEnumerable<Coding>)xzzzzzzzzzzzzzzzzzzx_);
                Code xzzzzzzzzzzzzzzzzzzz_ = xzzzzzzzzzzzzzzzzzzy_?.CodeElement;
                string yzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToString(context, xzzzzzzzzzzzzzzzzzzz_);
                bool? yzzzzzzzzzzzzzzzzzzb_ = context.Operators.Equal(yzzzzzzzzzzzzzzzzzza_, "8480-6");
                bool? yzzzzzzzzzzzzzzzzzzc_ = context.Operators.And(xzzzzzzzzzzzzzzzzzzv_, yzzzzzzzzzzzzzzzzzzb_);

                return yzzzzzzzzzzzzzzzzzzc_;
            };
            IEnumerable<Observation.ComponentComponent> wzzzzzzzzzzzzzzzzzza_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)vzzzzzzzzzzzzzzzzzzy_, vzzzzzzzzzzzzzzzzzzz_);
            Observation.ComponentComponent wzzzzzzzzzzzzzzzzzzb_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(wzzzzzzzzzzzzzzzzzza_);
            DataType wzzzzzzzzzzzzzzzzzzc_ = wzzzzzzzzzzzzzzzzzzb_?.Value;
            object wzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzc_);
            CqlQuantity wzzzzzzzzzzzzzzzzzze_ = context.Operators.Quantity(1m, "mm[Hg]");
            CqlQuantity wzzzzzzzzzzzzzzzzzzf_ = context.Operators.Quantity(120m, "mm[Hg]");
            CqlInterval<CqlQuantity> wzzzzzzzzzzzzzzzzzzg_ = context.Operators.Interval(wzzzzzzzzzzzzzzzzzze_, wzzzzzzzzzzzzzzzzzzf_, true, false);
            bool? wzzzzzzzzzzzzzzzzzzh_ = context.Operators.In<CqlQuantity>(wzzzzzzzzzzzzzzzzzzd_ as CqlQuantity, wzzzzzzzzzzzzzzzzzzg_, default);
            bool? wzzzzzzzzzzzzzzzzzzj_(Observation BloodPressure)
            {
                DataType yzzzzzzzzzzzzzzzzzzd_ = BloodPressure?.Effective;
                object yzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzd_);
                CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.toInterval(context, yzzzzzzzzzzzzzzzzzze_);
                CqlDateTime yzzzzzzzzzzzzzzzzzzg_ = context.Operators.End(yzzzzzzzzzzzzzzzzzzf_);
                Period yzzzzzzzzzzzzzzzzzzh_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzzzzzzzzzzzzzzzh_);
                bool? yzzzzzzzzzzzzzzzzzzj_ = context.Operators.In<CqlDateTime>(yzzzzzzzzzzzzzzzzzzg_, yzzzzzzzzzzzzzzzzzzi_, default);
                Code<ObservationStatus> yzzzzzzzzzzzzzzzzzzk_ = BloodPressure?.StatusElement;
                ObservationStatus? yzzzzzzzzzzzzzzzzzzl_ = yzzzzzzzzzzzzzzzzzzk_?.Value;
                string yzzzzzzzzzzzzzzzzzzm_ = context.Operators.Convert<string>(yzzzzzzzzzzzzzzzzzzl_);
                string[] yzzzzzzzzzzzzzzzzzzn_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? yzzzzzzzzzzzzzzzzzzo_ = context.Operators.In<string>(yzzzzzzzzzzzzzzzzzzm_, yzzzzzzzzzzzzzzzzzzn_ as IEnumerable<string>);
                bool? yzzzzzzzzzzzzzzzzzzp_ = context.Operators.And(yzzzzzzzzzzzzzzzzzzj_, yzzzzzzzzzzzzzzzzzzo_);

                return yzzzzzzzzzzzzzzzzzzp_;
            };
            IEnumerable<Observation> wzzzzzzzzzzzzzzzzzzk_ = context.Operators.Where<Observation>(vzzzzzzzzzzzzzzzzzzs_, wzzzzzzzzzzzzzzzzzzj_);
            object wzzzzzzzzzzzzzzzzzzl_(Observation @this)
            {
                DataType yzzzzzzzzzzzzzzzzzzq_ = @this?.Effective;
                object yzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzq_);
                CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.toInterval(context, yzzzzzzzzzzzzzzzzzzr_);
                CqlDateTime yzzzzzzzzzzzzzzzzzzt_ = context.Operators.Start(yzzzzzzzzzzzzzzzzzzs_);

                return yzzzzzzzzzzzzzzzzzzt_;
            };
            IEnumerable<Observation> wzzzzzzzzzzzzzzzzzzm_ = context.Operators.SortBy<Observation>(wzzzzzzzzzzzzzzzzzzk_, wzzzzzzzzzzzzzzzzzzl_, System.ComponentModel.ListSortDirection.Ascending);
            Observation wzzzzzzzzzzzzzzzzzzn_ = context.Operators.Last<Observation>(wzzzzzzzzzzzzzzzzzzm_);
            List<Observation.ComponentComponent> wzzzzzzzzzzzzzzzzzzo_ = wzzzzzzzzzzzzzzzzzzn_?.Component;
            bool? wzzzzzzzzzzzzzzzzzzp_(Observation.ComponentComponent @this)
            {
                CodeableConcept yzzzzzzzzzzzzzzzzzzu_ = @this?.Code;
                List<Coding> yzzzzzzzzzzzzzzzzzzv_ = yzzzzzzzzzzzzzzzzzzu_?.Coding;
                Coding yzzzzzzzzzzzzzzzzzzw_ = context.Operators.First<Coding>((IEnumerable<Coding>)yzzzzzzzzzzzzzzzzzzv_);
                FhirUri yzzzzzzzzzzzzzzzzzzx_ = yzzzzzzzzzzzzzzzzzzw_?.SystemElement;
                string yzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToString(context, yzzzzzzzzzzzzzzzzzzx_);
                bool? yzzzzzzzzzzzzzzzzzzz_ = context.Operators.Equal(yzzzzzzzzzzzzzzzzzzy_, "http://loinc.org");
                List<Coding> zzzzzzzzzzzzzzzzzzzb_ = yzzzzzzzzzzzzzzzzzzu_?.Coding;
                Coding zzzzzzzzzzzzzzzzzzzc_ = context.Operators.First<Coding>((IEnumerable<Coding>)zzzzzzzzzzzzzzzzzzzb_);
                Code zzzzzzzzzzzzzzzzzzzd_ = zzzzzzzzzzzzzzzzzzzc_?.CodeElement;
                string zzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToString(context, zzzzzzzzzzzzzzzzzzzd_);
                bool? zzzzzzzzzzzzzzzzzzzf_ = context.Operators.Equal(zzzzzzzzzzzzzzzzzzze_, "8462-4");
                bool? zzzzzzzzzzzzzzzzzzzg_ = context.Operators.And(yzzzzzzzzzzzzzzzzzzz_, zzzzzzzzzzzzzzzzzzzf_);

                return zzzzzzzzzzzzzzzzzzzg_;
            };
            IEnumerable<Observation.ComponentComponent> wzzzzzzzzzzzzzzzzzzq_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)wzzzzzzzzzzzzzzzzzzo_, wzzzzzzzzzzzzzzzzzzp_);
            Observation.ComponentComponent wzzzzzzzzzzzzzzzzzzr_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(wzzzzzzzzzzzzzzzzzzq_);
            DataType wzzzzzzzzzzzzzzzzzzs_ = wzzzzzzzzzzzzzzzzzzr_?.Value;
            object wzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzs_);
            CqlQuantity wzzzzzzzzzzzzzzzzzzv_ = context.Operators.Quantity(80m, "mm[Hg]");
            CqlInterval<CqlQuantity> wzzzzzzzzzzzzzzzzzzw_ = context.Operators.Interval(wzzzzzzzzzzzzzzzzzze_, wzzzzzzzzzzzzzzzzzzv_, true, false);
            bool? wzzzzzzzzzzzzzzzzzzx_ = context.Operators.In<CqlQuantity>(wzzzzzzzzzzzzzzzzzzt_ as CqlQuantity, wzzzzzzzzzzzzzzzzzzw_, default);
            bool? wzzzzzzzzzzzzzzzzzzy_ = context.Operators.And(wzzzzzzzzzzzzzzzzzzh_, wzzzzzzzzzzzzzzzzzzx_);

            return wzzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzr_ = context.Operators.Where<Encounter>(vzzzzzzzzzzzzzzzzzzp_, vzzzzzzzzzzzzzzzzzzq_);

        return vzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Encounter with Elevated Blood Pressure Reading SBP 120 to 129 AND DBP less than 80")]
    public IEnumerable<Encounter> Encounter_with_Elevated_Blood_Pressure_Reading_SBP_120_to_129_AND_DBP_less_than_80(CqlContext context)
    {
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzh_ = this.Qualifying_Encounter_during_Measurement_Period(context);
        bool? zzzzzzzzzzzzzzzzzzzi_(Encounter QualifyingEncounter)
        {
            IEnumerable<Observation> zzzzzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/bp"));
            bool? zzzzzzzzzzzzzzzzzzzl_(Observation BloodPressure)
            {
                DataType azzzzzzzzzzzzzzzzzzzr_ = BloodPressure?.Effective;
                object azzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzr_);
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.toInterval(context, azzzzzzzzzzzzzzzzzzzs_);
                CqlDateTime azzzzzzzzzzzzzzzzzzzu_ = context.Operators.End(azzzzzzzzzzzzzzzzzzzt_);
                Period azzzzzzzzzzzzzzzzzzzv_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzzzzzzzzzzzzzv_);
                bool? azzzzzzzzzzzzzzzzzzzx_ = context.Operators.In<CqlDateTime>(azzzzzzzzzzzzzzzzzzzu_, azzzzzzzzzzzzzzzzzzzw_, default);
                Code<ObservationStatus> azzzzzzzzzzzzzzzzzzzy_ = BloodPressure?.StatusElement;
                ObservationStatus? azzzzzzzzzzzzzzzzzzzz_ = azzzzzzzzzzzzzzzzzzzy_?.Value;
                string bzzzzzzzzzzzzzzzzzzza_ = context.Operators.Convert<string>(azzzzzzzzzzzzzzzzzzzz_);
                string[] bzzzzzzzzzzzzzzzzzzzb_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? bzzzzzzzzzzzzzzzzzzzc_ = context.Operators.In<string>(bzzzzzzzzzzzzzzzzzzza_, bzzzzzzzzzzzzzzzzzzzb_ as IEnumerable<string>);
                bool? bzzzzzzzzzzzzzzzzzzzd_ = context.Operators.And(azzzzzzzzzzzzzzzzzzzx_, bzzzzzzzzzzzzzzzzzzzc_);

                return bzzzzzzzzzzzzzzzzzzzd_;
            };
            IEnumerable<Observation> zzzzzzzzzzzzzzzzzzzm_ = context.Operators.Where<Observation>(zzzzzzzzzzzzzzzzzzzk_, zzzzzzzzzzzzzzzzzzzl_);
            object zzzzzzzzzzzzzzzzzzzn_(Observation @this)
            {
                DataType bzzzzzzzzzzzzzzzzzzze_ = @this?.Effective;
                object bzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzze_);
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.toInterval(context, bzzzzzzzzzzzzzzzzzzzf_);
                CqlDateTime bzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Start(bzzzzzzzzzzzzzzzzzzzg_);

                return bzzzzzzzzzzzzzzzzzzzh_;
            };
            IEnumerable<Observation> zzzzzzzzzzzzzzzzzzzo_ = context.Operators.SortBy<Observation>(zzzzzzzzzzzzzzzzzzzm_, zzzzzzzzzzzzzzzzzzzn_, System.ComponentModel.ListSortDirection.Ascending);
            Observation zzzzzzzzzzzzzzzzzzzp_ = context.Operators.Last<Observation>(zzzzzzzzzzzzzzzzzzzo_);
            List<Observation.ComponentComponent> zzzzzzzzzzzzzzzzzzzq_ = zzzzzzzzzzzzzzzzzzzp_?.Component;
            bool? zzzzzzzzzzzzzzzzzzzr_(Observation.ComponentComponent @this)
            {
                CodeableConcept bzzzzzzzzzzzzzzzzzzzi_ = @this?.Code;
                List<Coding> bzzzzzzzzzzzzzzzzzzzj_ = bzzzzzzzzzzzzzzzzzzzi_?.Coding;
                Coding bzzzzzzzzzzzzzzzzzzzk_ = context.Operators.First<Coding>((IEnumerable<Coding>)bzzzzzzzzzzzzzzzzzzzj_);
                FhirUri bzzzzzzzzzzzzzzzzzzzl_ = bzzzzzzzzzzzzzzzzzzzk_?.SystemElement;
                string bzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToString(context, bzzzzzzzzzzzzzzzzzzzl_);
                bool? bzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Equal(bzzzzzzzzzzzzzzzzzzzm_, "http://loinc.org");
                List<Coding> bzzzzzzzzzzzzzzzzzzzp_ = bzzzzzzzzzzzzzzzzzzzi_?.Coding;
                Coding bzzzzzzzzzzzzzzzzzzzq_ = context.Operators.First<Coding>((IEnumerable<Coding>)bzzzzzzzzzzzzzzzzzzzp_);
                Code bzzzzzzzzzzzzzzzzzzzr_ = bzzzzzzzzzzzzzzzzzzzq_?.CodeElement;
                string bzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToString(context, bzzzzzzzzzzzzzzzzzzzr_);
                bool? bzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Equal(bzzzzzzzzzzzzzzzzzzzs_, "8480-6");
                bool? bzzzzzzzzzzzzzzzzzzzu_ = context.Operators.And(bzzzzzzzzzzzzzzzzzzzn_, bzzzzzzzzzzzzzzzzzzzt_);

                return bzzzzzzzzzzzzzzzzzzzu_;
            };
            IEnumerable<Observation.ComponentComponent> zzzzzzzzzzzzzzzzzzzs_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)zzzzzzzzzzzzzzzzzzzq_, zzzzzzzzzzzzzzzzzzzr_);
            Observation.ComponentComponent zzzzzzzzzzzzzzzzzzzt_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(zzzzzzzzzzzzzzzzzzzs_);
            DataType zzzzzzzzzzzzzzzzzzzu_ = zzzzzzzzzzzzzzzzzzzt_?.Value;
            object zzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzu_);
            CqlQuantity zzzzzzzzzzzzzzzzzzzw_ = context.Operators.Quantity(120m, "mm[Hg]");
            CqlQuantity zzzzzzzzzzzzzzzzzzzx_ = context.Operators.Quantity(129m, "mm[Hg]");
            CqlInterval<CqlQuantity> zzzzzzzzzzzzzzzzzzzy_ = context.Operators.Interval(zzzzzzzzzzzzzzzzzzzw_, zzzzzzzzzzzzzzzzzzzx_, true, true);
            bool? zzzzzzzzzzzzzzzzzzzz_ = context.Operators.In<CqlQuantity>(zzzzzzzzzzzzzzzzzzzv_ as CqlQuantity, zzzzzzzzzzzzzzzzzzzy_, default);
            bool? azzzzzzzzzzzzzzzzzzzb_(Observation BloodPressure)
            {
                DataType bzzzzzzzzzzzzzzzzzzzv_ = BloodPressure?.Effective;
                object bzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzv_);
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.toInterval(context, bzzzzzzzzzzzzzzzzzzzw_);
                CqlDateTime bzzzzzzzzzzzzzzzzzzzy_ = context.Operators.End(bzzzzzzzzzzzzzzzzzzzx_);
                Period bzzzzzzzzzzzzzzzzzzzz_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzzzzzzzzzzzzzz_);
                bool? czzzzzzzzzzzzzzzzzzzb_ = context.Operators.In<CqlDateTime>(bzzzzzzzzzzzzzzzzzzzy_, czzzzzzzzzzzzzzzzzzza_, default);
                Code<ObservationStatus> czzzzzzzzzzzzzzzzzzzc_ = BloodPressure?.StatusElement;
                ObservationStatus? czzzzzzzzzzzzzzzzzzzd_ = czzzzzzzzzzzzzzzzzzzc_?.Value;
                string czzzzzzzzzzzzzzzzzzze_ = context.Operators.Convert<string>(czzzzzzzzzzzzzzzzzzzd_);
                string[] czzzzzzzzzzzzzzzzzzzf_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? czzzzzzzzzzzzzzzzzzzg_ = context.Operators.In<string>(czzzzzzzzzzzzzzzzzzze_, czzzzzzzzzzzzzzzzzzzf_ as IEnumerable<string>);
                bool? czzzzzzzzzzzzzzzzzzzh_ = context.Operators.And(czzzzzzzzzzzzzzzzzzzb_, czzzzzzzzzzzzzzzzzzzg_);

                return czzzzzzzzzzzzzzzzzzzh_;
            };
            IEnumerable<Observation> azzzzzzzzzzzzzzzzzzzc_ = context.Operators.Where<Observation>(zzzzzzzzzzzzzzzzzzzk_, azzzzzzzzzzzzzzzzzzzb_);
            object azzzzzzzzzzzzzzzzzzzd_(Observation @this)
            {
                DataType czzzzzzzzzzzzzzzzzzzi_ = @this?.Effective;
                object czzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzzi_);
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.toInterval(context, czzzzzzzzzzzzzzzzzzzj_);
                CqlDateTime czzzzzzzzzzzzzzzzzzzl_ = context.Operators.Start(czzzzzzzzzzzzzzzzzzzk_);

                return czzzzzzzzzzzzzzzzzzzl_;
            };
            IEnumerable<Observation> azzzzzzzzzzzzzzzzzzze_ = context.Operators.SortBy<Observation>(azzzzzzzzzzzzzzzzzzzc_, azzzzzzzzzzzzzzzzzzzd_, System.ComponentModel.ListSortDirection.Ascending);
            Observation azzzzzzzzzzzzzzzzzzzf_ = context.Operators.Last<Observation>(azzzzzzzzzzzzzzzzzzze_);
            List<Observation.ComponentComponent> azzzzzzzzzzzzzzzzzzzg_ = azzzzzzzzzzzzzzzzzzzf_?.Component;
            bool? azzzzzzzzzzzzzzzzzzzh_(Observation.ComponentComponent @this)
            {
                CodeableConcept czzzzzzzzzzzzzzzzzzzm_ = @this?.Code;
                List<Coding> czzzzzzzzzzzzzzzzzzzn_ = czzzzzzzzzzzzzzzzzzzm_?.Coding;
                Coding czzzzzzzzzzzzzzzzzzzo_ = context.Operators.First<Coding>((IEnumerable<Coding>)czzzzzzzzzzzzzzzzzzzn_);
                FhirUri czzzzzzzzzzzzzzzzzzzp_ = czzzzzzzzzzzzzzzzzzzo_?.SystemElement;
                string czzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToString(context, czzzzzzzzzzzzzzzzzzzp_);
                bool? czzzzzzzzzzzzzzzzzzzr_ = context.Operators.Equal(czzzzzzzzzzzzzzzzzzzq_, "http://loinc.org");
                List<Coding> czzzzzzzzzzzzzzzzzzzt_ = czzzzzzzzzzzzzzzzzzzm_?.Coding;
                Coding czzzzzzzzzzzzzzzzzzzu_ = context.Operators.First<Coding>((IEnumerable<Coding>)czzzzzzzzzzzzzzzzzzzt_);
                Code czzzzzzzzzzzzzzzzzzzv_ = czzzzzzzzzzzzzzzzzzzu_?.CodeElement;
                string czzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToString(context, czzzzzzzzzzzzzzzzzzzv_);
                bool? czzzzzzzzzzzzzzzzzzzx_ = context.Operators.Equal(czzzzzzzzzzzzzzzzzzzw_, "8462-4");
                bool? czzzzzzzzzzzzzzzzzzzy_ = context.Operators.And(czzzzzzzzzzzzzzzzzzzr_, czzzzzzzzzzzzzzzzzzzx_);

                return czzzzzzzzzzzzzzzzzzzy_;
            };
            IEnumerable<Observation.ComponentComponent> azzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)azzzzzzzzzzzzzzzzzzzg_, azzzzzzzzzzzzzzzzzzzh_);
            Observation.ComponentComponent azzzzzzzzzzzzzzzzzzzj_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(azzzzzzzzzzzzzzzzzzzi_);
            DataType azzzzzzzzzzzzzzzzzzzk_ = azzzzzzzzzzzzzzzzzzzj_?.Value;
            object azzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzk_);
            CqlQuantity azzzzzzzzzzzzzzzzzzzm_ = context.Operators.Quantity(1m, "mm[Hg]");
            CqlQuantity azzzzzzzzzzzzzzzzzzzn_ = context.Operators.Quantity(80m, "mm[Hg]");
            CqlInterval<CqlQuantity> azzzzzzzzzzzzzzzzzzzo_ = context.Operators.Interval(azzzzzzzzzzzzzzzzzzzm_, azzzzzzzzzzzzzzzzzzzn_, true, false);
            bool? azzzzzzzzzzzzzzzzzzzp_ = context.Operators.In<CqlQuantity>(azzzzzzzzzzzzzzzzzzzl_ as CqlQuantity, azzzzzzzzzzzzzzzzzzzo_, default);
            bool? azzzzzzzzzzzzzzzzzzzq_ = context.Operators.And(zzzzzzzzzzzzzzzzzzzz_, azzzzzzzzzzzzzzzzzzzp_);

            return azzzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzj_ = context.Operators.Where<Encounter>(zzzzzzzzzzzzzzzzzzzh_, zzzzzzzzzzzzzzzzzzzi_);

        return zzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Follow up with Rescreen Within 6 Months")]
    public IEnumerable<ServiceRequest> Follow_up_with_Rescreen_Within_6_Months(CqlContext context)
    {
        CqlValueSet czzzzzzzzzzzzzzzzzzzz_ = this.Follow_Up_Within_6_Months(context);
        IEnumerable<ServiceRequest> dzzzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        bool? dzzzzzzzzzzzzzzzzzzzb_(ServiceRequest FollowUp)
        {
            Code<RequestIntent> dzzzzzzzzzzzzzzzzzzzd_ = FollowUp?.IntentElement;
            RequestIntent? dzzzzzzzzzzzzzzzzzzze_ = dzzzzzzzzzzzzzzzzzzzd_?.Value;
            Code<RequestIntent> dzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Convert<Code<RequestIntent>>(dzzzzzzzzzzzzzzzzzzze_);
            bool? dzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Equivalent(dzzzzzzzzzzzzzzzzzzzf_, "order");

            return dzzzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<ServiceRequest> dzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Where<ServiceRequest>(dzzzzzzzzzzzzzzzzzzza_, dzzzzzzzzzzzzzzzzzzzb_);

        return dzzzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("NonPharmacological Interventions")]
    public IEnumerable<ServiceRequest> NonPharmacological_Interventions(CqlContext context)
    {
        CqlValueSet dzzzzzzzzzzzzzzzzzzzh_ = this.Lifestyle_Recommendation(context);
        IEnumerable<ServiceRequest> dzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        CqlValueSet dzzzzzzzzzzzzzzzzzzzj_ = this.Weight_Reduction_Recommended(context);
        IEnumerable<ServiceRequest> dzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> dzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Union<ServiceRequest>(dzzzzzzzzzzzzzzzzzzzi_, dzzzzzzzzzzzzzzzzzzzk_);
        CqlValueSet dzzzzzzzzzzzzzzzzzzzm_ = this.Dietary_Recommendations(context);
        IEnumerable<ServiceRequest> dzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        CqlValueSet dzzzzzzzzzzzzzzzzzzzo_ = this.Recommendation_to_Increase_Physical_Activity(context);
        IEnumerable<ServiceRequest> dzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> dzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Union<ServiceRequest>(dzzzzzzzzzzzzzzzzzzzn_, dzzzzzzzzzzzzzzzzzzzp_);
        IEnumerable<ServiceRequest> dzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Union<ServiceRequest>(dzzzzzzzzzzzzzzzzzzzl_, dzzzzzzzzzzzzzzzzzzzq_);
        CqlValueSet dzzzzzzzzzzzzzzzzzzzs_ = this.Referral_or_Counseling_for_Alcohol_Consumption(context);
        IEnumerable<ServiceRequest> dzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> dzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Union<ServiceRequest>(dzzzzzzzzzzzzzzzzzzzr_, dzzzzzzzzzzzzzzzzzzzt_);
        bool? dzzzzzzzzzzzzzzzzzzzv_(ServiceRequest NonPharmaInterventions)
        {
            Code<RequestIntent> dzzzzzzzzzzzzzzzzzzzx_ = NonPharmaInterventions?.IntentElement;
            RequestIntent? dzzzzzzzzzzzzzzzzzzzy_ = dzzzzzzzzzzzzzzzzzzzx_?.Value;
            Code<RequestIntent> dzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Convert<Code<RequestIntent>>(dzzzzzzzzzzzzzzzzzzzy_);
            bool? ezzzzzzzzzzzzzzzzzzza_ = context.Operators.Equivalent(dzzzzzzzzzzzzzzzzzzzz_, "order");

            return ezzzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<ServiceRequest> dzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Where<ServiceRequest>(dzzzzzzzzzzzzzzzzzzzu_, dzzzzzzzzzzzzzzzzzzzv_);

        return dzzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Referral to Alternate or Primary Healthcare Professional for Hypertensive Reading")]
    public IEnumerable<ServiceRequest> Referral_to_Alternate_or_Primary_Healthcare_Professional_for_Hypertensive_Reading(CqlContext context)
    {
        CqlValueSet ezzzzzzzzzzzzzzzzzzzb_ = this.Referral_to_Primary_Care_or_Alternate_Provider(context);
        IEnumerable<ServiceRequest> ezzzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        bool? ezzzzzzzzzzzzzzzzzzzd_(ServiceRequest Referral)
        {
            List<CodeableConcept> ezzzzzzzzzzzzzzzzzzzf_ = Referral?.ReasonCode;
            CqlConcept ezzzzzzzzzzzzzzzzzzzg_(CodeableConcept @this)
            {
                CqlConcept ezzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return ezzzzzzzzzzzzzzzzzzzp_;
            };
            IEnumerable<CqlConcept> ezzzzzzzzzzzzzzzzzzzh_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)ezzzzzzzzzzzzzzzzzzzf_, ezzzzzzzzzzzzzzzzzzzg_);
            CqlValueSet ezzzzzzzzzzzzzzzzzzzi_ = this.Finding_of_Elevated_Blood_Pressure_or_Hypertension(context);
            bool? ezzzzzzzzzzzzzzzzzzzj_ = context.Operators.ConceptsInValueSet(ezzzzzzzzzzzzzzzzzzzh_, ezzzzzzzzzzzzzzzzzzzi_);
            Code<RequestIntent> ezzzzzzzzzzzzzzzzzzzk_ = Referral?.IntentElement;
            RequestIntent? ezzzzzzzzzzzzzzzzzzzl_ = ezzzzzzzzzzzzzzzzzzzk_?.Value;
            Code<RequestIntent> ezzzzzzzzzzzzzzzzzzzm_ = context.Operators.Convert<Code<RequestIntent>>(ezzzzzzzzzzzzzzzzzzzl_);
            bool? ezzzzzzzzzzzzzzzzzzzn_ = context.Operators.Equivalent(ezzzzzzzzzzzzzzzzzzzm_, "order");
            bool? ezzzzzzzzzzzzzzzzzzzo_ = context.Operators.And(ezzzzzzzzzzzzzzzzzzzj_, ezzzzzzzzzzzzzzzzzzzn_);

            return ezzzzzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<ServiceRequest> ezzzzzzzzzzzzzzzzzzze_ = context.Operators.Where<ServiceRequest>(ezzzzzzzzzzzzzzzzzzzc_, ezzzzzzzzzzzzzzzzzzzd_);

        return ezzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Encounter with Elevated Blood Pressure Reading SBP 120 to 129 AND DBP less than 80 and Interventions")]
    public IEnumerable<Encounter> Encounter_with_Elevated_Blood_Pressure_Reading_SBP_120_to_129_AND_DBP_less_than_80_and_Interventions(CqlContext context)
    {
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzq_ = this.Encounter_with_Elevated_Blood_Pressure_Reading_SBP_120_to_129_AND_DBP_less_than_80(context);
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzr_(Encounter ElevatedEncounter)
        {
            IEnumerable<ServiceRequest> ezzzzzzzzzzzzzzzzzzzz_ = this.Follow_up_with_Rescreen_Within_6_Months(context);
            bool? fzzzzzzzzzzzzzzzzzzza_(ServiceRequest Twoto6MonthRescreen)
            {
                FhirDateTime fzzzzzzzzzzzzzzzzzzze_ = Twoto6MonthRescreen?.AuthoredOnElement;
                CqlDateTime fzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Convert<CqlDateTime>(fzzzzzzzzzzzzzzzzzzze_);
                Period fzzzzzzzzzzzzzzzzzzzg_ = ElevatedEncounter?.Period;
                CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzzzzzzzzzzzzzzzg_);
                bool? fzzzzzzzzzzzzzzzzzzzi_ = context.Operators.In<CqlDateTime>(fzzzzzzzzzzzzzzzzzzzf_, fzzzzzzzzzzzzzzzzzzzh_, "day");

                return fzzzzzzzzzzzzzzzzzzzi_;
            };
            IEnumerable<ServiceRequest> fzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Where<ServiceRequest>(ezzzzzzzzzzzzzzzzzzzz_, fzzzzzzzzzzzzzzzzzzza_);
            Encounter fzzzzzzzzzzzzzzzzzzzc_(ServiceRequest Twoto6MonthRescreen) =>
                ElevatedEncounter;
            IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Select<ServiceRequest, Encounter>(fzzzzzzzzzzzzzzzzzzzb_, fzzzzzzzzzzzzzzzzzzzc_);

            return fzzzzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzs_ = context.Operators.SelectMany<Encounter, Encounter>(ezzzzzzzzzzzzzzzzzzzq_, ezzzzzzzzzzzzzzzzzzzr_);
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzt_(Encounter ElevatedEncounter)
        {
            IEnumerable<ServiceRequest> fzzzzzzzzzzzzzzzzzzzj_ = this.NonPharmacological_Interventions(context);
            bool? fzzzzzzzzzzzzzzzzzzzk_(ServiceRequest NonPharmInterventions)
            {
                FhirDateTime fzzzzzzzzzzzzzzzzzzzo_ = NonPharmInterventions?.AuthoredOnElement;
                CqlDateTime fzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Convert<CqlDateTime>(fzzzzzzzzzzzzzzzzzzzo_);
                Period fzzzzzzzzzzzzzzzzzzzq_ = ElevatedEncounter?.Period;
                CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzzzzzzzzzzzzzzzq_);
                bool? fzzzzzzzzzzzzzzzzzzzs_ = context.Operators.In<CqlDateTime>(fzzzzzzzzzzzzzzzzzzzp_, fzzzzzzzzzzzzzzzzzzzr_, "day");

                return fzzzzzzzzzzzzzzzzzzzs_;
            };
            IEnumerable<ServiceRequest> fzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<ServiceRequest>(fzzzzzzzzzzzzzzzzzzzj_, fzzzzzzzzzzzzzzzzzzzk_);
            Encounter fzzzzzzzzzzzzzzzzzzzm_(ServiceRequest NonPharmInterventions) =>
                ElevatedEncounter;
            IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Select<ServiceRequest, Encounter>(fzzzzzzzzzzzzzzzzzzzl_, fzzzzzzzzzzzzzzzzzzzm_);

            return fzzzzzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzu_ = context.Operators.SelectMany<Encounter, Encounter>(ezzzzzzzzzzzzzzzzzzzs_, ezzzzzzzzzzzzzzzzzzzt_);
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzw_(Encounter ElevatedEncounter)
        {
            IEnumerable<ServiceRequest> fzzzzzzzzzzzzzzzzzzzt_ = this.Referral_to_Alternate_or_Primary_Healthcare_Professional_for_Hypertensive_Reading(context);
            bool? fzzzzzzzzzzzzzzzzzzzu_(ServiceRequest Referral)
            {
                FhirDateTime fzzzzzzzzzzzzzzzzzzzy_ = Referral?.AuthoredOnElement;
                CqlDateTime fzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Convert<CqlDateTime>(fzzzzzzzzzzzzzzzzzzzy_);
                Period gzzzzzzzzzzzzzzzzzzza_ = ElevatedEncounter?.Period;
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzzzzzzzzzzzzzza_);
                bool? gzzzzzzzzzzzzzzzzzzzc_ = context.Operators.In<CqlDateTime>(fzzzzzzzzzzzzzzzzzzzz_, gzzzzzzzzzzzzzzzzzzzb_, "day");

                return gzzzzzzzzzzzzzzzzzzzc_;
            };
            IEnumerable<ServiceRequest> fzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<ServiceRequest>(fzzzzzzzzzzzzzzzzzzzt_, fzzzzzzzzzzzzzzzzzzzu_);
            Encounter fzzzzzzzzzzzzzzzzzzzw_(ServiceRequest Referral) =>
                ElevatedEncounter;
            IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Select<ServiceRequest, Encounter>(fzzzzzzzzzzzzzzzzzzzv_, fzzzzzzzzzzzzzzzzzzzw_);

            return fzzzzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzx_ = context.Operators.SelectMany<Encounter, Encounter>(ezzzzzzzzzzzzzzzzzzzq_, ezzzzzzzzzzzzzzzzzzzw_);
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzy_ = context.Operators.Union<Encounter>(ezzzzzzzzzzzzzzzzzzzu_, ezzzzzzzzzzzzzzzzzzzx_);

        return ezzzzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Encounter with Hypertensive Reading Within Year Prior")]
    public IEnumerable<Encounter> Encounter_with_Hypertensive_Reading_Within_Year_Prior(CqlContext context)
    {
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzzzd_ = this.Qualifying_Encounter_during_Measurement_Period(context);
        bool? gzzzzzzzzzzzzzzzzzzze_(Encounter QualifyingEncounter)
        {
            IEnumerable<Observation> gzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/bp"));
            bool? gzzzzzzzzzzzzzzzzzzzh_(Observation BloodPressure)
            {
                DataType izzzzzzzzzzzzzzzzzzzn_ = BloodPressure?.Effective;
                object izzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzn_);
                CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.toInterval(context, izzzzzzzzzzzzzzzzzzzo_);
                CqlDateTime izzzzzzzzzzzzzzzzzzzq_ = context.Operators.End(izzzzzzzzzzzzzzzzzzzp_);
                Period izzzzzzzzzzzzzzzzzzzr_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzzzzzzzzzzzzzzr_);
                CqlDateTime izzzzzzzzzzzzzzzzzzzt_ = context.Operators.Start(izzzzzzzzzzzzzzzzzzzs_);
                CqlQuantity izzzzzzzzzzzzzzzzzzzu_ = context.Operators.Quantity(1m, "year");
                CqlDateTime izzzzzzzzzzzzzzzzzzzv_ = context.Operators.Subtract(izzzzzzzzzzzzzzzzzzzt_, izzzzzzzzzzzzzzzzzzzu_);
                CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzzzzzzzzzzzzzzr_);
                CqlDateTime izzzzzzzzzzzzzzzzzzzy_ = context.Operators.Start(izzzzzzzzzzzzzzzzzzzx_);
                CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzz_ = context.Operators.Interval(izzzzzzzzzzzzzzzzzzzv_, izzzzzzzzzzzzzzzzzzzy_, true, true);
                bool? jzzzzzzzzzzzzzzzzzzza_ = context.Operators.In<CqlDateTime>(izzzzzzzzzzzzzzzzzzzq_, izzzzzzzzzzzzzzzzzzzz_, default);
                CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzzzzzzzzzzzzzzr_);
                CqlDateTime jzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Start(jzzzzzzzzzzzzzzzzzzzc_);
                bool? jzzzzzzzzzzzzzzzzzzze_ = context.Operators.Not((bool?)(jzzzzzzzzzzzzzzzzzzzd_ is null));
                bool? jzzzzzzzzzzzzzzzzzzzf_ = context.Operators.And(jzzzzzzzzzzzzzzzzzzza_, jzzzzzzzzzzzzzzzzzzze_);
                Code<ObservationStatus> jzzzzzzzzzzzzzzzzzzzg_ = BloodPressure?.StatusElement;
                ObservationStatus? jzzzzzzzzzzzzzzzzzzzh_ = jzzzzzzzzzzzzzzzzzzzg_?.Value;
                string jzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Convert<string>(jzzzzzzzzzzzzzzzzzzzh_);
                string[] jzzzzzzzzzzzzzzzzzzzj_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? jzzzzzzzzzzzzzzzzzzzk_ = context.Operators.In<string>(jzzzzzzzzzzzzzzzzzzzi_, jzzzzzzzzzzzzzzzzzzzj_ as IEnumerable<string>);
                bool? jzzzzzzzzzzzzzzzzzzzl_ = context.Operators.And(jzzzzzzzzzzzzzzzzzzzf_, jzzzzzzzzzzzzzzzzzzzk_);

                return jzzzzzzzzzzzzzzzzzzzl_;
            };
            IEnumerable<Observation> gzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<Observation>(gzzzzzzzzzzzzzzzzzzzg_, gzzzzzzzzzzzzzzzzzzzh_);
            object gzzzzzzzzzzzzzzzzzzzj_(Observation @this)
            {
                DataType jzzzzzzzzzzzzzzzzzzzm_ = @this?.Effective;
                object jzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzm_);
                CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.toInterval(context, jzzzzzzzzzzzzzzzzzzzn_);
                CqlDateTime jzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Start(jzzzzzzzzzzzzzzzzzzzo_);

                return jzzzzzzzzzzzzzzzzzzzp_;
            };
            IEnumerable<Observation> gzzzzzzzzzzzzzzzzzzzk_ = context.Operators.SortBy<Observation>(gzzzzzzzzzzzzzzzzzzzi_, gzzzzzzzzzzzzzzzzzzzj_, System.ComponentModel.ListSortDirection.Ascending);
            Observation gzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Last<Observation>(gzzzzzzzzzzzzzzzzzzzk_);
            List<Observation.ComponentComponent> gzzzzzzzzzzzzzzzzzzzm_ = gzzzzzzzzzzzzzzzzzzzl_?.Component;
            bool? gzzzzzzzzzzzzzzzzzzzn_(Observation.ComponentComponent @this)
            {
                CodeableConcept jzzzzzzzzzzzzzzzzzzzq_ = @this?.Code;
                List<Coding> jzzzzzzzzzzzzzzzzzzzr_ = jzzzzzzzzzzzzzzzzzzzq_?.Coding;
                Coding jzzzzzzzzzzzzzzzzzzzs_ = context.Operators.First<Coding>((IEnumerable<Coding>)jzzzzzzzzzzzzzzzzzzzr_);
                FhirUri jzzzzzzzzzzzzzzzzzzzt_ = jzzzzzzzzzzzzzzzzzzzs_?.SystemElement;
                string jzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToString(context, jzzzzzzzzzzzzzzzzzzzt_);
                bool? jzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Equal(jzzzzzzzzzzzzzzzzzzzu_, "http://loinc.org");
                List<Coding> jzzzzzzzzzzzzzzzzzzzx_ = jzzzzzzzzzzzzzzzzzzzq_?.Coding;
                Coding jzzzzzzzzzzzzzzzzzzzy_ = context.Operators.First<Coding>((IEnumerable<Coding>)jzzzzzzzzzzzzzzzzzzzx_);
                Code jzzzzzzzzzzzzzzzzzzzz_ = jzzzzzzzzzzzzzzzzzzzy_?.CodeElement;
                string kzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToString(context, jzzzzzzzzzzzzzzzzzzzz_);
                bool? kzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Equal(kzzzzzzzzzzzzzzzzzzza_, "8480-6");
                bool? kzzzzzzzzzzzzzzzzzzzc_ = context.Operators.And(jzzzzzzzzzzzzzzzzzzzv_, kzzzzzzzzzzzzzzzzzzzb_);

                return kzzzzzzzzzzzzzzzzzzzc_;
            };
            IEnumerable<Observation.ComponentComponent> gzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)gzzzzzzzzzzzzzzzzzzzm_, gzzzzzzzzzzzzzzzzzzzn_);
            Observation.ComponentComponent gzzzzzzzzzzzzzzzzzzzp_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(gzzzzzzzzzzzzzzzzzzzo_);
            DataType gzzzzzzzzzzzzzzzzzzzq_ = gzzzzzzzzzzzzzzzzzzzp_?.Value;
            object gzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzq_);
            CqlQuantity gzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Quantity(0m, "mm[Hg]");
            bool? gzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Greater(gzzzzzzzzzzzzzzzzzzzr_ as CqlQuantity, gzzzzzzzzzzzzzzzzzzzs_);
            bool? gzzzzzzzzzzzzzzzzzzzv_(Observation BloodPressure)
            {
                DataType kzzzzzzzzzzzzzzzzzzzd_ = BloodPressure?.Effective;
                object kzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzd_);
                CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.toInterval(context, kzzzzzzzzzzzzzzzzzzze_);
                CqlDateTime kzzzzzzzzzzzzzzzzzzzg_ = context.Operators.End(kzzzzzzzzzzzzzzzzzzzf_);
                Period kzzzzzzzzzzzzzzzzzzzh_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzzzzzzzzzzzzzzzh_);
                CqlDateTime kzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Start(kzzzzzzzzzzzzzzzzzzzi_);
                CqlQuantity kzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Quantity(1m, "year");
                CqlDateTime kzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Subtract(kzzzzzzzzzzzzzzzzzzzj_, kzzzzzzzzzzzzzzzzzzzk_);
                CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzzzzzzzzzzzzzzzh_);
                CqlDateTime kzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Start(kzzzzzzzzzzzzzzzzzzzn_);
                CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Interval(kzzzzzzzzzzzzzzzzzzzl_, kzzzzzzzzzzzzzzzzzzzo_, true, true);
                bool? kzzzzzzzzzzzzzzzzzzzq_ = context.Operators.In<CqlDateTime>(kzzzzzzzzzzzzzzzzzzzg_, kzzzzzzzzzzzzzzzzzzzp_, default);
                CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzzzzzzzzzzzzzzzh_);
                CqlDateTime kzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Start(kzzzzzzzzzzzzzzzzzzzs_);
                bool? kzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Not((bool?)(kzzzzzzzzzzzzzzzzzzzt_ is null));
                bool? kzzzzzzzzzzzzzzzzzzzv_ = context.Operators.And(kzzzzzzzzzzzzzzzzzzzq_, kzzzzzzzzzzzzzzzzzzzu_);
                Code<ObservationStatus> kzzzzzzzzzzzzzzzzzzzw_ = BloodPressure?.StatusElement;
                ObservationStatus? kzzzzzzzzzzzzzzzzzzzx_ = kzzzzzzzzzzzzzzzzzzzw_?.Value;
                string kzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Convert<string>(kzzzzzzzzzzzzzzzzzzzx_);
                string[] kzzzzzzzzzzzzzzzzzzzz_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? lzzzzzzzzzzzzzzzzzzza_ = context.Operators.In<string>(kzzzzzzzzzzzzzzzzzzzy_, kzzzzzzzzzzzzzzzzzzzz_ as IEnumerable<string>);
                bool? lzzzzzzzzzzzzzzzzzzzb_ = context.Operators.And(kzzzzzzzzzzzzzzzzzzzv_, lzzzzzzzzzzzzzzzzzzza_);

                return lzzzzzzzzzzzzzzzzzzzb_;
            };
            IEnumerable<Observation> gzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Where<Observation>(gzzzzzzzzzzzzzzzzzzzg_, gzzzzzzzzzzzzzzzzzzzv_);
            object gzzzzzzzzzzzzzzzzzzzx_(Observation @this)
            {
                DataType lzzzzzzzzzzzzzzzzzzzc_ = @this?.Effective;
                object lzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzc_);
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.toInterval(context, lzzzzzzzzzzzzzzzzzzzd_);
                CqlDateTime lzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Start(lzzzzzzzzzzzzzzzzzzze_);

                return lzzzzzzzzzzzzzzzzzzzf_;
            };
            IEnumerable<Observation> gzzzzzzzzzzzzzzzzzzzy_ = context.Operators.SortBy<Observation>(gzzzzzzzzzzzzzzzzzzzw_, gzzzzzzzzzzzzzzzzzzzx_, System.ComponentModel.ListSortDirection.Ascending);
            Observation gzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Last<Observation>(gzzzzzzzzzzzzzzzzzzzy_);
            List<Observation.ComponentComponent> hzzzzzzzzzzzzzzzzzzza_ = gzzzzzzzzzzzzzzzzzzzz_?.Component;
            bool? hzzzzzzzzzzzzzzzzzzzb_(Observation.ComponentComponent @this)
            {
                CodeableConcept lzzzzzzzzzzzzzzzzzzzg_ = @this?.Code;
                List<Coding> lzzzzzzzzzzzzzzzzzzzh_ = lzzzzzzzzzzzzzzzzzzzg_?.Coding;
                Coding lzzzzzzzzzzzzzzzzzzzi_ = context.Operators.First<Coding>((IEnumerable<Coding>)lzzzzzzzzzzzzzzzzzzzh_);
                FhirUri lzzzzzzzzzzzzzzzzzzzj_ = lzzzzzzzzzzzzzzzzzzzi_?.SystemElement;
                string lzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToString(context, lzzzzzzzzzzzzzzzzzzzj_);
                bool? lzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Equal(lzzzzzzzzzzzzzzzzzzzk_, "http://loinc.org");
                List<Coding> lzzzzzzzzzzzzzzzzzzzn_ = lzzzzzzzzzzzzzzzzzzzg_?.Coding;
                Coding lzzzzzzzzzzzzzzzzzzzo_ = context.Operators.First<Coding>((IEnumerable<Coding>)lzzzzzzzzzzzzzzzzzzzn_);
                Code lzzzzzzzzzzzzzzzzzzzp_ = lzzzzzzzzzzzzzzzzzzzo_?.CodeElement;
                string lzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToString(context, lzzzzzzzzzzzzzzzzzzzp_);
                bool? lzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Equal(lzzzzzzzzzzzzzzzzzzzq_, "8462-4");
                bool? lzzzzzzzzzzzzzzzzzzzs_ = context.Operators.And(lzzzzzzzzzzzzzzzzzzzl_, lzzzzzzzzzzzzzzzzzzzr_);

                return lzzzzzzzzzzzzzzzzzzzs_;
            };
            IEnumerable<Observation.ComponentComponent> hzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)hzzzzzzzzzzzzzzzzzzza_, hzzzzzzzzzzzzzzzzzzzb_);
            Observation.ComponentComponent hzzzzzzzzzzzzzzzzzzzd_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(hzzzzzzzzzzzzzzzzzzzc_);
            DataType hzzzzzzzzzzzzzzzzzzze_ = hzzzzzzzzzzzzzzzzzzzd_?.Value;
            object hzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzze_);
            bool? hzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Greater(hzzzzzzzzzzzzzzzzzzzf_ as CqlQuantity, gzzzzzzzzzzzzzzzzzzzs_);
            bool? hzzzzzzzzzzzzzzzzzzzi_ = context.Operators.And(gzzzzzzzzzzzzzzzzzzzt_, hzzzzzzzzzzzzzzzzzzzh_);
            bool? hzzzzzzzzzzzzzzzzzzzk_(Observation BloodPressure)
            {
                DataType lzzzzzzzzzzzzzzzzzzzt_ = BloodPressure?.Effective;
                object lzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzt_);
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.toInterval(context, lzzzzzzzzzzzzzzzzzzzu_);
                CqlDateTime lzzzzzzzzzzzzzzzzzzzw_ = context.Operators.End(lzzzzzzzzzzzzzzzzzzzv_);
                Period lzzzzzzzzzzzzzzzzzzzx_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzzzzzzzzzzzzzzx_);
                CqlDateTime lzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Start(lzzzzzzzzzzzzzzzzzzzy_);
                CqlQuantity mzzzzzzzzzzzzzzzzzzza_ = context.Operators.Quantity(1m, "year");
                CqlDateTime mzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Subtract(lzzzzzzzzzzzzzzzzzzzz_, mzzzzzzzzzzzzzzzzzzza_);
                CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzzzzzzzzzzzzzzx_);
                CqlDateTime mzzzzzzzzzzzzzzzzzzze_ = context.Operators.Start(mzzzzzzzzzzzzzzzzzzzd_);
                CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Interval(mzzzzzzzzzzzzzzzzzzzb_, mzzzzzzzzzzzzzzzzzzze_, true, true);
                bool? mzzzzzzzzzzzzzzzzzzzg_ = context.Operators.In<CqlDateTime>(lzzzzzzzzzzzzzzzzzzzw_, mzzzzzzzzzzzzzzzzzzzf_, default);
                CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzzzzzzzzzzzzzzx_);
                CqlDateTime mzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Start(mzzzzzzzzzzzzzzzzzzzi_);
                bool? mzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Not((bool?)(mzzzzzzzzzzzzzzzzzzzj_ is null));
                bool? mzzzzzzzzzzzzzzzzzzzl_ = context.Operators.And(mzzzzzzzzzzzzzzzzzzzg_, mzzzzzzzzzzzzzzzzzzzk_);
                Code<ObservationStatus> mzzzzzzzzzzzzzzzzzzzm_ = BloodPressure?.StatusElement;
                ObservationStatus? mzzzzzzzzzzzzzzzzzzzn_ = mzzzzzzzzzzzzzzzzzzzm_?.Value;
                string mzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Convert<string>(mzzzzzzzzzzzzzzzzzzzn_);
                string[] mzzzzzzzzzzzzzzzzzzzp_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? mzzzzzzzzzzzzzzzzzzzq_ = context.Operators.In<string>(mzzzzzzzzzzzzzzzzzzzo_, mzzzzzzzzzzzzzzzzzzzp_ as IEnumerable<string>);
                bool? mzzzzzzzzzzzzzzzzzzzr_ = context.Operators.And(mzzzzzzzzzzzzzzzzzzzl_, mzzzzzzzzzzzzzzzzzzzq_);

                return mzzzzzzzzzzzzzzzzzzzr_;
            };
            IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Observation>(gzzzzzzzzzzzzzzzzzzzg_, hzzzzzzzzzzzzzzzzzzzk_);
            object hzzzzzzzzzzzzzzzzzzzm_(Observation @this)
            {
                DataType mzzzzzzzzzzzzzzzzzzzs_ = @this?.Effective;
                object mzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzs_);
                CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.toInterval(context, mzzzzzzzzzzzzzzzzzzzt_);
                CqlDateTime mzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Start(mzzzzzzzzzzzzzzzzzzzu_);

                return mzzzzzzzzzzzzzzzzzzzv_;
            };
            IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzn_ = context.Operators.SortBy<Observation>(hzzzzzzzzzzzzzzzzzzzl_, hzzzzzzzzzzzzzzzzzzzm_, System.ComponentModel.ListSortDirection.Ascending);
            Observation hzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Last<Observation>(hzzzzzzzzzzzzzzzzzzzn_);
            List<Observation.ComponentComponent> hzzzzzzzzzzzzzzzzzzzp_ = hzzzzzzzzzzzzzzzzzzzo_?.Component;
            bool? hzzzzzzzzzzzzzzzzzzzq_(Observation.ComponentComponent @this)
            {
                CodeableConcept mzzzzzzzzzzzzzzzzzzzw_ = @this?.Code;
                List<Coding> mzzzzzzzzzzzzzzzzzzzx_ = mzzzzzzzzzzzzzzzzzzzw_?.Coding;
                Coding mzzzzzzzzzzzzzzzzzzzy_ = context.Operators.First<Coding>((IEnumerable<Coding>)mzzzzzzzzzzzzzzzzzzzx_);
                FhirUri mzzzzzzzzzzzzzzzzzzzz_ = mzzzzzzzzzzzzzzzzzzzy_?.SystemElement;
                string nzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToString(context, mzzzzzzzzzzzzzzzzzzzz_);
                bool? nzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Equal(nzzzzzzzzzzzzzzzzzzza_, "http://loinc.org");
                List<Coding> nzzzzzzzzzzzzzzzzzzzd_ = mzzzzzzzzzzzzzzzzzzzw_?.Coding;
                Coding nzzzzzzzzzzzzzzzzzzze_ = context.Operators.First<Coding>((IEnumerable<Coding>)nzzzzzzzzzzzzzzzzzzzd_);
                Code nzzzzzzzzzzzzzzzzzzzf_ = nzzzzzzzzzzzzzzzzzzze_?.CodeElement;
                string nzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToString(context, nzzzzzzzzzzzzzzzzzzzf_);
                bool? nzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Equal(nzzzzzzzzzzzzzzzzzzzg_, "8480-6");
                bool? nzzzzzzzzzzzzzzzzzzzi_ = context.Operators.And(nzzzzzzzzzzzzzzzzzzzb_, nzzzzzzzzzzzzzzzzzzzh_);

                return nzzzzzzzzzzzzzzzzzzzi_;
            };
            IEnumerable<Observation.ComponentComponent> hzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)hzzzzzzzzzzzzzzzzzzzp_, hzzzzzzzzzzzzzzzzzzzq_);
            Observation.ComponentComponent hzzzzzzzzzzzzzzzzzzzs_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(hzzzzzzzzzzzzzzzzzzzr_);
            DataType hzzzzzzzzzzzzzzzzzzzt_ = hzzzzzzzzzzzzzzzzzzzs_?.Value;
            object hzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzt_);
            CqlQuantity hzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Quantity(130m, "mm[Hg]");
            bool? hzzzzzzzzzzzzzzzzzzzw_ = context.Operators.GreaterOrEqual(hzzzzzzzzzzzzzzzzzzzu_ as CqlQuantity, hzzzzzzzzzzzzzzzzzzzv_);
            bool? hzzzzzzzzzzzzzzzzzzzy_(Observation BloodPressure)
            {
                DataType nzzzzzzzzzzzzzzzzzzzj_ = BloodPressure?.Effective;
                object nzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzzj_);
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.toInterval(context, nzzzzzzzzzzzzzzzzzzzk_);
                CqlDateTime nzzzzzzzzzzzzzzzzzzzm_ = context.Operators.End(nzzzzzzzzzzzzzzzzzzzl_);
                Period nzzzzzzzzzzzzzzzzzzzn_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzzzzzzzzzzzzzzzn_);
                CqlDateTime nzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Start(nzzzzzzzzzzzzzzzzzzzo_);
                CqlQuantity nzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Quantity(1m, "year");
                CqlDateTime nzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Subtract(nzzzzzzzzzzzzzzzzzzzp_, nzzzzzzzzzzzzzzzzzzzq_);
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzzzzzzzzzzzzzzzn_);
                CqlDateTime nzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Start(nzzzzzzzzzzzzzzzzzzzt_);
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Interval(nzzzzzzzzzzzzzzzzzzzr_, nzzzzzzzzzzzzzzzzzzzu_, true, true);
                bool? nzzzzzzzzzzzzzzzzzzzw_ = context.Operators.In<CqlDateTime>(nzzzzzzzzzzzzzzzzzzzm_, nzzzzzzzzzzzzzzzzzzzv_, default);
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzzzzzzzzzzzzzzzn_);
                CqlDateTime nzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Start(nzzzzzzzzzzzzzzzzzzzy_);
                bool? ozzzzzzzzzzzzzzzzzzza_ = context.Operators.Not((bool?)(nzzzzzzzzzzzzzzzzzzzz_ is null));
                bool? ozzzzzzzzzzzzzzzzzzzb_ = context.Operators.And(nzzzzzzzzzzzzzzzzzzzw_, ozzzzzzzzzzzzzzzzzzza_);
                Code<ObservationStatus> ozzzzzzzzzzzzzzzzzzzc_ = BloodPressure?.StatusElement;
                ObservationStatus? ozzzzzzzzzzzzzzzzzzzd_ = ozzzzzzzzzzzzzzzzzzzc_?.Value;
                string ozzzzzzzzzzzzzzzzzzze_ = context.Operators.Convert<string>(ozzzzzzzzzzzzzzzzzzzd_);
                string[] ozzzzzzzzzzzzzzzzzzzf_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? ozzzzzzzzzzzzzzzzzzzg_ = context.Operators.In<string>(ozzzzzzzzzzzzzzzzzzze_, ozzzzzzzzzzzzzzzzzzzf_ as IEnumerable<string>);
                bool? ozzzzzzzzzzzzzzzzzzzh_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzzb_, ozzzzzzzzzzzzzzzzzzzg_);

                return ozzzzzzzzzzzzzzzzzzzh_;
            };
            IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Where<Observation>(gzzzzzzzzzzzzzzzzzzzg_, hzzzzzzzzzzzzzzzzzzzy_);
            object izzzzzzzzzzzzzzzzzzza_(Observation @this)
            {
                DataType ozzzzzzzzzzzzzzzzzzzi_ = @this?.Effective;
                object ozzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzi_);
                CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.toInterval(context, ozzzzzzzzzzzzzzzzzzzj_);
                CqlDateTime ozzzzzzzzzzzzzzzzzzzl_ = context.Operators.Start(ozzzzzzzzzzzzzzzzzzzk_);

                return ozzzzzzzzzzzzzzzzzzzl_;
            };
            IEnumerable<Observation> izzzzzzzzzzzzzzzzzzzb_ = context.Operators.SortBy<Observation>(hzzzzzzzzzzzzzzzzzzzz_, izzzzzzzzzzzzzzzzzzza_, System.ComponentModel.ListSortDirection.Ascending);
            Observation izzzzzzzzzzzzzzzzzzzc_ = context.Operators.Last<Observation>(izzzzzzzzzzzzzzzzzzzb_);
            List<Observation.ComponentComponent> izzzzzzzzzzzzzzzzzzzd_ = izzzzzzzzzzzzzzzzzzzc_?.Component;
            bool? izzzzzzzzzzzzzzzzzzze_(Observation.ComponentComponent @this)
            {
                CodeableConcept ozzzzzzzzzzzzzzzzzzzm_ = @this?.Code;
                List<Coding> ozzzzzzzzzzzzzzzzzzzn_ = ozzzzzzzzzzzzzzzzzzzm_?.Coding;
                Coding ozzzzzzzzzzzzzzzzzzzo_ = context.Operators.First<Coding>((IEnumerable<Coding>)ozzzzzzzzzzzzzzzzzzzn_);
                FhirUri ozzzzzzzzzzzzzzzzzzzp_ = ozzzzzzzzzzzzzzzzzzzo_?.SystemElement;
                string ozzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToString(context, ozzzzzzzzzzzzzzzzzzzp_);
                bool? ozzzzzzzzzzzzzzzzzzzr_ = context.Operators.Equal(ozzzzzzzzzzzzzzzzzzzq_, "http://loinc.org");
                List<Coding> ozzzzzzzzzzzzzzzzzzzt_ = ozzzzzzzzzzzzzzzzzzzm_?.Coding;
                Coding ozzzzzzzzzzzzzzzzzzzu_ = context.Operators.First<Coding>((IEnumerable<Coding>)ozzzzzzzzzzzzzzzzzzzt_);
                Code ozzzzzzzzzzzzzzzzzzzv_ = ozzzzzzzzzzzzzzzzzzzu_?.CodeElement;
                string ozzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToString(context, ozzzzzzzzzzzzzzzzzzzv_);
                bool? ozzzzzzzzzzzzzzzzzzzx_ = context.Operators.Equal(ozzzzzzzzzzzzzzzzzzzw_, "8462-4");
                bool? ozzzzzzzzzzzzzzzzzzzy_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzzr_, ozzzzzzzzzzzzzzzzzzzx_);

                return ozzzzzzzzzzzzzzzzzzzy_;
            };
            IEnumerable<Observation.ComponentComponent> izzzzzzzzzzzzzzzzzzzf_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)izzzzzzzzzzzzzzzzzzzd_, izzzzzzzzzzzzzzzzzzze_);
            Observation.ComponentComponent izzzzzzzzzzzzzzzzzzzg_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(izzzzzzzzzzzzzzzzzzzf_);
            DataType izzzzzzzzzzzzzzzzzzzh_ = izzzzzzzzzzzzzzzzzzzg_?.Value;
            object izzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzh_);
            CqlQuantity izzzzzzzzzzzzzzzzzzzj_ = context.Operators.Quantity(80m, "mm[Hg]");
            bool? izzzzzzzzzzzzzzzzzzzk_ = context.Operators.GreaterOrEqual(izzzzzzzzzzzzzzzzzzzi_ as CqlQuantity, izzzzzzzzzzzzzzzzzzzj_);
            bool? izzzzzzzzzzzzzzzzzzzl_ = context.Operators.Or(hzzzzzzzzzzzzzzzzzzzw_, izzzzzzzzzzzzzzzzzzzk_);
            bool? izzzzzzzzzzzzzzzzzzzm_ = context.Operators.And(hzzzzzzzzzzzzzzzzzzzi_, izzzzzzzzzzzzzzzzzzzl_);

            return izzzzzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Where<Encounter>(gzzzzzzzzzzzzzzzzzzzd_, gzzzzzzzzzzzzzzzzzzze_);

        return gzzzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Encounter with First Hypertensive Reading SBP Greater than or Equal to 130 OR DBP Greater than or Equal to 80")]
    public IEnumerable<Encounter> Encounter_with_First_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_130_OR_DBP_Greater_than_or_Equal_to_80(CqlContext context)
    {
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzz_ = this.Qualifying_Encounter_during_Measurement_Period(context);
        bool? pzzzzzzzzzzzzzzzzzzza_(Encounter QualifyingEncounter)
        {
            IEnumerable<Observation> pzzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/bp"));
            bool? pzzzzzzzzzzzzzzzzzzzf_(Observation BloodPressure)
            {
                DataType rzzzzzzzzzzzzzzzzzzzl_ = BloodPressure?.Effective;
                object rzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzl_);
                CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.toInterval(context, rzzzzzzzzzzzzzzzzzzzm_);
                CqlDateTime rzzzzzzzzzzzzzzzzzzzo_ = context.Operators.End(rzzzzzzzzzzzzzzzzzzzn_);
                Period rzzzzzzzzzzzzzzzzzzzp_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzzzzzzzzzzzzzzp_);
                bool? rzzzzzzzzzzzzzzzzzzzr_ = context.Operators.In<CqlDateTime>(rzzzzzzzzzzzzzzzzzzzo_, rzzzzzzzzzzzzzzzzzzzq_, "day");

                return rzzzzzzzzzzzzzzzzzzzr_;
            };
            IEnumerable<Observation> pzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Where<Observation>(pzzzzzzzzzzzzzzzzzzze_, pzzzzzzzzzzzzzzzzzzzf_);
            object pzzzzzzzzzzzzzzzzzzzh_(Observation @this)
            {
                DataType rzzzzzzzzzzzzzzzzzzzs_ = @this?.Effective;
                object rzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzs_);
                CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.toInterval(context, rzzzzzzzzzzzzzzzzzzzt_);
                CqlDateTime rzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Start(rzzzzzzzzzzzzzzzzzzzu_);

                return rzzzzzzzzzzzzzzzzzzzv_;
            };
            IEnumerable<Observation> pzzzzzzzzzzzzzzzzzzzi_ = context.Operators.SortBy<Observation>(pzzzzzzzzzzzzzzzzzzzg_, pzzzzzzzzzzzzzzzzzzzh_, System.ComponentModel.ListSortDirection.Ascending);
            Observation pzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Last<Observation>(pzzzzzzzzzzzzzzzzzzzi_);
            List<Observation.ComponentComponent> pzzzzzzzzzzzzzzzzzzzk_ = pzzzzzzzzzzzzzzzzzzzj_?.Component;
            bool? pzzzzzzzzzzzzzzzzzzzl_(Observation.ComponentComponent @this)
            {
                CodeableConcept rzzzzzzzzzzzzzzzzzzzw_ = @this?.Code;
                List<Coding> rzzzzzzzzzzzzzzzzzzzx_ = rzzzzzzzzzzzzzzzzzzzw_?.Coding;
                Coding rzzzzzzzzzzzzzzzzzzzy_ = context.Operators.First<Coding>((IEnumerable<Coding>)rzzzzzzzzzzzzzzzzzzzx_);
                FhirUri rzzzzzzzzzzzzzzzzzzzz_ = rzzzzzzzzzzzzzzzzzzzy_?.SystemElement;
                string szzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToString(context, rzzzzzzzzzzzzzzzzzzzz_);
                bool? szzzzzzzzzzzzzzzzzzzb_ = context.Operators.Equal(szzzzzzzzzzzzzzzzzzza_, "http://loinc.org");
                List<Coding> szzzzzzzzzzzzzzzzzzzd_ = rzzzzzzzzzzzzzzzzzzzw_?.Coding;
                Coding szzzzzzzzzzzzzzzzzzze_ = context.Operators.First<Coding>((IEnumerable<Coding>)szzzzzzzzzzzzzzzzzzzd_);
                Code szzzzzzzzzzzzzzzzzzzf_ = szzzzzzzzzzzzzzzzzzze_?.CodeElement;
                string szzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToString(context, szzzzzzzzzzzzzzzzzzzf_);
                bool? szzzzzzzzzzzzzzzzzzzh_ = context.Operators.Equal(szzzzzzzzzzzzzzzzzzzg_, "8480-6");
                bool? szzzzzzzzzzzzzzzzzzzi_ = context.Operators.And(szzzzzzzzzzzzzzzzzzzb_, szzzzzzzzzzzzzzzzzzzh_);

                return szzzzzzzzzzzzzzzzzzzi_;
            };
            IEnumerable<Observation.ComponentComponent> pzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)pzzzzzzzzzzzzzzzzzzzk_, pzzzzzzzzzzzzzzzzzzzl_);
            Observation.ComponentComponent pzzzzzzzzzzzzzzzzzzzn_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(pzzzzzzzzzzzzzzzzzzzm_);
            DataType pzzzzzzzzzzzzzzzzzzzo_ = pzzzzzzzzzzzzzzzzzzzn_?.Value;
            object pzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzo_);
            CqlQuantity pzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Quantity(0m, "mm[Hg]");
            bool? pzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Greater(pzzzzzzzzzzzzzzzzzzzp_ as CqlQuantity, pzzzzzzzzzzzzzzzzzzzq_);
            bool? pzzzzzzzzzzzzzzzzzzzt_(Observation BloodPressure)
            {
                DataType szzzzzzzzzzzzzzzzzzzj_ = BloodPressure?.Effective;
                object szzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzj_);
                CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.toInterval(context, szzzzzzzzzzzzzzzzzzzk_);
                CqlDateTime szzzzzzzzzzzzzzzzzzzm_ = context.Operators.End(szzzzzzzzzzzzzzzzzzzl_);
                Period szzzzzzzzzzzzzzzzzzzn_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzzzzzzzzzzzzzzzzn_);
                bool? szzzzzzzzzzzzzzzzzzzp_ = context.Operators.In<CqlDateTime>(szzzzzzzzzzzzzzzzzzzm_, szzzzzzzzzzzzzzzzzzzo_, "day");

                return szzzzzzzzzzzzzzzzzzzp_;
            };
            IEnumerable<Observation> pzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Where<Observation>(pzzzzzzzzzzzzzzzzzzze_, pzzzzzzzzzzzzzzzzzzzt_);
            object pzzzzzzzzzzzzzzzzzzzv_(Observation @this)
            {
                DataType szzzzzzzzzzzzzzzzzzzq_ = @this?.Effective;
                object szzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzq_);
                CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.toInterval(context, szzzzzzzzzzzzzzzzzzzr_);
                CqlDateTime szzzzzzzzzzzzzzzzzzzt_ = context.Operators.Start(szzzzzzzzzzzzzzzzzzzs_);

                return szzzzzzzzzzzzzzzzzzzt_;
            };
            IEnumerable<Observation> pzzzzzzzzzzzzzzzzzzzw_ = context.Operators.SortBy<Observation>(pzzzzzzzzzzzzzzzzzzzu_, pzzzzzzzzzzzzzzzzzzzv_, System.ComponentModel.ListSortDirection.Ascending);
            Observation pzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Last<Observation>(pzzzzzzzzzzzzzzzzzzzw_);
            List<Observation.ComponentComponent> pzzzzzzzzzzzzzzzzzzzy_ = pzzzzzzzzzzzzzzzzzzzx_?.Component;
            bool? pzzzzzzzzzzzzzzzzzzzz_(Observation.ComponentComponent @this)
            {
                CodeableConcept szzzzzzzzzzzzzzzzzzzu_ = @this?.Code;
                List<Coding> szzzzzzzzzzzzzzzzzzzv_ = szzzzzzzzzzzzzzzzzzzu_?.Coding;
                Coding szzzzzzzzzzzzzzzzzzzw_ = context.Operators.First<Coding>((IEnumerable<Coding>)szzzzzzzzzzzzzzzzzzzv_);
                FhirUri szzzzzzzzzzzzzzzzzzzx_ = szzzzzzzzzzzzzzzzzzzw_?.SystemElement;
                string szzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToString(context, szzzzzzzzzzzzzzzzzzzx_);
                bool? szzzzzzzzzzzzzzzzzzzz_ = context.Operators.Equal(szzzzzzzzzzzzzzzzzzzy_, "http://loinc.org");
                List<Coding> tzzzzzzzzzzzzzzzzzzzb_ = szzzzzzzzzzzzzzzzzzzu_?.Coding;
                Coding tzzzzzzzzzzzzzzzzzzzc_ = context.Operators.First<Coding>((IEnumerable<Coding>)tzzzzzzzzzzzzzzzzzzzb_);
                Code tzzzzzzzzzzzzzzzzzzzd_ = tzzzzzzzzzzzzzzzzzzzc_?.CodeElement;
                string tzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToString(context, tzzzzzzzzzzzzzzzzzzzd_);
                bool? tzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Equal(tzzzzzzzzzzzzzzzzzzze_, "8462-4");
                bool? tzzzzzzzzzzzzzzzzzzzg_ = context.Operators.And(szzzzzzzzzzzzzzzzzzzz_, tzzzzzzzzzzzzzzzzzzzf_);

                return tzzzzzzzzzzzzzzzzzzzg_;
            };
            IEnumerable<Observation.ComponentComponent> qzzzzzzzzzzzzzzzzzzza_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)pzzzzzzzzzzzzzzzzzzzy_, pzzzzzzzzzzzzzzzzzzzz_);
            Observation.ComponentComponent qzzzzzzzzzzzzzzzzzzzb_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(qzzzzzzzzzzzzzzzzzzza_);
            DataType qzzzzzzzzzzzzzzzzzzzc_ = qzzzzzzzzzzzzzzzzzzzb_?.Value;
            object qzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzc_);
            bool? qzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Greater(qzzzzzzzzzzzzzzzzzzzd_ as CqlQuantity, pzzzzzzzzzzzzzzzzzzzq_);
            bool? qzzzzzzzzzzzzzzzzzzzg_ = context.Operators.And(pzzzzzzzzzzzzzzzzzzzr_, qzzzzzzzzzzzzzzzzzzzf_);
            bool? qzzzzzzzzzzzzzzzzzzzi_(Observation BloodPressure)
            {
                DataType tzzzzzzzzzzzzzzzzzzzh_ = BloodPressure?.Effective;
                object tzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzh_);
                CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.toInterval(context, tzzzzzzzzzzzzzzzzzzzi_);
                CqlDateTime tzzzzzzzzzzzzzzzzzzzk_ = context.Operators.End(tzzzzzzzzzzzzzzzzzzzj_);
                Period tzzzzzzzzzzzzzzzzzzzl_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzzzzzzzzzzzzzzzzl_);
                bool? tzzzzzzzzzzzzzzzzzzzn_ = context.Operators.In<CqlDateTime>(tzzzzzzzzzzzzzzzzzzzk_, tzzzzzzzzzzzzzzzzzzzm_, "day");

                return tzzzzzzzzzzzzzzzzzzzn_;
            };
            IEnumerable<Observation> qzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Where<Observation>(pzzzzzzzzzzzzzzzzzzze_, qzzzzzzzzzzzzzzzzzzzi_);
            object qzzzzzzzzzzzzzzzzzzzk_(Observation @this)
            {
                DataType tzzzzzzzzzzzzzzzzzzzo_ = @this?.Effective;
                object tzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzo_);
                CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.toInterval(context, tzzzzzzzzzzzzzzzzzzzp_);
                CqlDateTime tzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Start(tzzzzzzzzzzzzzzzzzzzq_);

                return tzzzzzzzzzzzzzzzzzzzr_;
            };
            IEnumerable<Observation> qzzzzzzzzzzzzzzzzzzzl_ = context.Operators.SortBy<Observation>(qzzzzzzzzzzzzzzzzzzzj_, qzzzzzzzzzzzzzzzzzzzk_, System.ComponentModel.ListSortDirection.Ascending);
            Observation qzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Last<Observation>(qzzzzzzzzzzzzzzzzzzzl_);
            List<Observation.ComponentComponent> qzzzzzzzzzzzzzzzzzzzn_ = qzzzzzzzzzzzzzzzzzzzm_?.Component;
            bool? qzzzzzzzzzzzzzzzzzzzo_(Observation.ComponentComponent @this)
            {
                CodeableConcept tzzzzzzzzzzzzzzzzzzzs_ = @this?.Code;
                List<Coding> tzzzzzzzzzzzzzzzzzzzt_ = tzzzzzzzzzzzzzzzzzzzs_?.Coding;
                Coding tzzzzzzzzzzzzzzzzzzzu_ = context.Operators.First<Coding>((IEnumerable<Coding>)tzzzzzzzzzzzzzzzzzzzt_);
                FhirUri tzzzzzzzzzzzzzzzzzzzv_ = tzzzzzzzzzzzzzzzzzzzu_?.SystemElement;
                string tzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToString(context, tzzzzzzzzzzzzzzzzzzzv_);
                bool? tzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Equal(tzzzzzzzzzzzzzzzzzzzw_, "http://loinc.org");
                List<Coding> tzzzzzzzzzzzzzzzzzzzz_ = tzzzzzzzzzzzzzzzzzzzs_?.Coding;
                Coding uzzzzzzzzzzzzzzzzzzza_ = context.Operators.First<Coding>((IEnumerable<Coding>)tzzzzzzzzzzzzzzzzzzzz_);
                Code uzzzzzzzzzzzzzzzzzzzb_ = uzzzzzzzzzzzzzzzzzzza_?.CodeElement;
                string uzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToString(context, uzzzzzzzzzzzzzzzzzzzb_);
                bool? uzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Equal(uzzzzzzzzzzzzzzzzzzzc_, "8480-6");
                bool? uzzzzzzzzzzzzzzzzzzze_ = context.Operators.And(tzzzzzzzzzzzzzzzzzzzx_, uzzzzzzzzzzzzzzzzzzzd_);

                return uzzzzzzzzzzzzzzzzzzze_;
            };
            IEnumerable<Observation.ComponentComponent> qzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)qzzzzzzzzzzzzzzzzzzzn_, qzzzzzzzzzzzzzzzzzzzo_);
            Observation.ComponentComponent qzzzzzzzzzzzzzzzzzzzq_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(qzzzzzzzzzzzzzzzzzzzp_);
            DataType qzzzzzzzzzzzzzzzzzzzr_ = qzzzzzzzzzzzzzzzzzzzq_?.Value;
            object qzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzr_);
            CqlQuantity qzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Quantity(130m, "mm[Hg]");
            bool? qzzzzzzzzzzzzzzzzzzzu_ = context.Operators.GreaterOrEqual(qzzzzzzzzzzzzzzzzzzzs_ as CqlQuantity, qzzzzzzzzzzzzzzzzzzzt_);
            bool? qzzzzzzzzzzzzzzzzzzzw_(Observation BloodPressure)
            {
                DataType uzzzzzzzzzzzzzzzzzzzf_ = BloodPressure?.Effective;
                object uzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzf_);
                CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.toInterval(context, uzzzzzzzzzzzzzzzzzzzg_);
                CqlDateTime uzzzzzzzzzzzzzzzzzzzi_ = context.Operators.End(uzzzzzzzzzzzzzzzzzzzh_);
                Period uzzzzzzzzzzzzzzzzzzzj_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzzzzzzzzzzzzzzzj_);
                bool? uzzzzzzzzzzzzzzzzzzzl_ = context.Operators.In<CqlDateTime>(uzzzzzzzzzzzzzzzzzzzi_, uzzzzzzzzzzzzzzzzzzzk_, "day");

                return uzzzzzzzzzzzzzzzzzzzl_;
            };
            IEnumerable<Observation> qzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Where<Observation>(pzzzzzzzzzzzzzzzzzzze_, qzzzzzzzzzzzzzzzzzzzw_);
            object qzzzzzzzzzzzzzzzzzzzy_(Observation @this)
            {
                DataType uzzzzzzzzzzzzzzzzzzzm_ = @this?.Effective;
                object uzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzm_);
                CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.toInterval(context, uzzzzzzzzzzzzzzzzzzzn_);
                CqlDateTime uzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Start(uzzzzzzzzzzzzzzzzzzzo_);

                return uzzzzzzzzzzzzzzzzzzzp_;
            };
            IEnumerable<Observation> qzzzzzzzzzzzzzzzzzzzz_ = context.Operators.SortBy<Observation>(qzzzzzzzzzzzzzzzzzzzx_, qzzzzzzzzzzzzzzzzzzzy_, System.ComponentModel.ListSortDirection.Ascending);
            Observation rzzzzzzzzzzzzzzzzzzza_ = context.Operators.Last<Observation>(qzzzzzzzzzzzzzzzzzzzz_);
            List<Observation.ComponentComponent> rzzzzzzzzzzzzzzzzzzzb_ = rzzzzzzzzzzzzzzzzzzza_?.Component;
            bool? rzzzzzzzzzzzzzzzzzzzc_(Observation.ComponentComponent @this)
            {
                CodeableConcept uzzzzzzzzzzzzzzzzzzzq_ = @this?.Code;
                List<Coding> uzzzzzzzzzzzzzzzzzzzr_ = uzzzzzzzzzzzzzzzzzzzq_?.Coding;
                Coding uzzzzzzzzzzzzzzzzzzzs_ = context.Operators.First<Coding>((IEnumerable<Coding>)uzzzzzzzzzzzzzzzzzzzr_);
                FhirUri uzzzzzzzzzzzzzzzzzzzt_ = uzzzzzzzzzzzzzzzzzzzs_?.SystemElement;
                string uzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToString(context, uzzzzzzzzzzzzzzzzzzzt_);
                bool? uzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Equal(uzzzzzzzzzzzzzzzzzzzu_, "http://loinc.org");
                List<Coding> uzzzzzzzzzzzzzzzzzzzx_ = uzzzzzzzzzzzzzzzzzzzq_?.Coding;
                Coding uzzzzzzzzzzzzzzzzzzzy_ = context.Operators.First<Coding>((IEnumerable<Coding>)uzzzzzzzzzzzzzzzzzzzx_);
                Code uzzzzzzzzzzzzzzzzzzzz_ = uzzzzzzzzzzzzzzzzzzzy_?.CodeElement;
                string vzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToString(context, uzzzzzzzzzzzzzzzzzzzz_);
                bool? vzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Equal(vzzzzzzzzzzzzzzzzzzza_, "8462-4");
                bool? vzzzzzzzzzzzzzzzzzzzc_ = context.Operators.And(uzzzzzzzzzzzzzzzzzzzv_, vzzzzzzzzzzzzzzzzzzzb_);

                return vzzzzzzzzzzzzzzzzzzzc_;
            };
            IEnumerable<Observation.ComponentComponent> rzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)rzzzzzzzzzzzzzzzzzzzb_, rzzzzzzzzzzzzzzzzzzzc_);
            Observation.ComponentComponent rzzzzzzzzzzzzzzzzzzze_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(rzzzzzzzzzzzzzzzzzzzd_);
            DataType rzzzzzzzzzzzzzzzzzzzf_ = rzzzzzzzzzzzzzzzzzzze_?.Value;
            object rzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzf_);
            CqlQuantity rzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Quantity(80m, "mm[Hg]");
            bool? rzzzzzzzzzzzzzzzzzzzi_ = context.Operators.GreaterOrEqual(rzzzzzzzzzzzzzzzzzzzg_ as CqlQuantity, rzzzzzzzzzzzzzzzzzzzh_);
            bool? rzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Or(qzzzzzzzzzzzzzzzzzzzu_, rzzzzzzzzzzzzzzzzzzzi_);
            bool? rzzzzzzzzzzzzzzzzzzzk_ = context.Operators.And(qzzzzzzzzzzzzzzzzzzzg_, rzzzzzzzzzzzzzzzzzzzj_);

            return rzzzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Where<Encounter>(ozzzzzzzzzzzzzzzzzzzz_, pzzzzzzzzzzzzzzzzzzza_);
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzc_ = this.Encounter_with_Hypertensive_Reading_Within_Year_Prior(context);
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Except<Encounter>(pzzzzzzzzzzzzzzzzzzzb_, pzzzzzzzzzzzzzzzzzzzc_);

        return pzzzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("First Hypertensive Reading Interventions or Referral to Alternate Professional")]
    public IEnumerable<ServiceRequest> First_Hypertensive_Reading_Interventions_or_Referral_to_Alternate_Professional(CqlContext context)
    {
        CqlValueSet vzzzzzzzzzzzzzzzzzzzd_ = this.Follow_Up_Within_4_Weeks(context);
        IEnumerable<ServiceRequest> vzzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> vzzzzzzzzzzzzzzzzzzzf_(ServiceRequest FourWeekRescreen)
        {
            IEnumerable<ServiceRequest> vzzzzzzzzzzzzzzzzzzzj_ = this.NonPharmacological_Interventions(context);
            bool? vzzzzzzzzzzzzzzzzzzzk_(ServiceRequest NonPharmInterventionsHTN)
            {
                FhirDateTime vzzzzzzzzzzzzzzzzzzzo_ = FourWeekRescreen?.AuthoredOnElement;
                CqlDateTime vzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Convert<CqlDateTime>(vzzzzzzzzzzzzzzzzzzzo_);
                CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzq_ = this.Measurement_Period(context);
                bool? vzzzzzzzzzzzzzzzzzzzr_ = context.Operators.In<CqlDateTime>(vzzzzzzzzzzzzzzzzzzzp_, vzzzzzzzzzzzzzzzzzzzq_, "day");
                FhirDateTime vzzzzzzzzzzzzzzzzzzzs_ = NonPharmInterventionsHTN?.AuthoredOnElement;
                CqlDateTime vzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Convert<CqlDateTime>(vzzzzzzzzzzzzzzzzzzzs_);
                bool? vzzzzzzzzzzzzzzzzzzzv_ = context.Operators.In<CqlDateTime>(vzzzzzzzzzzzzzzzzzzzt_, vzzzzzzzzzzzzzzzzzzzq_, "day");
                bool? vzzzzzzzzzzzzzzzzzzzw_ = context.Operators.And(vzzzzzzzzzzzzzzzzzzzr_, vzzzzzzzzzzzzzzzzzzzv_);
                Code<RequestIntent> vzzzzzzzzzzzzzzzzzzzx_ = FourWeekRescreen?.IntentElement;
                RequestIntent? vzzzzzzzzzzzzzzzzzzzy_ = vzzzzzzzzzzzzzzzzzzzx_?.Value;
                Code<RequestIntent> vzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Convert<Code<RequestIntent>>(vzzzzzzzzzzzzzzzzzzzy_);
                bool? wzzzzzzzzzzzzzzzzzzza_ = context.Operators.Equivalent(vzzzzzzzzzzzzzzzzzzzz_, "order");
                bool? wzzzzzzzzzzzzzzzzzzzb_ = context.Operators.And(vzzzzzzzzzzzzzzzzzzzw_, wzzzzzzzzzzzzzzzzzzza_);

                return wzzzzzzzzzzzzzzzzzzzb_;
            };
            IEnumerable<ServiceRequest> vzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<ServiceRequest>(vzzzzzzzzzzzzzzzzzzzj_, vzzzzzzzzzzzzzzzzzzzk_);
            ServiceRequest vzzzzzzzzzzzzzzzzzzzm_(ServiceRequest NonPharmInterventionsHTN) =>
                FourWeekRescreen;
            IEnumerable<ServiceRequest> vzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Select<ServiceRequest, ServiceRequest>(vzzzzzzzzzzzzzzzzzzzl_, vzzzzzzzzzzzzzzzzzzzm_);

            return vzzzzzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<ServiceRequest> vzzzzzzzzzzzzzzzzzzzg_ = context.Operators.SelectMany<ServiceRequest, ServiceRequest>(vzzzzzzzzzzzzzzzzzzze_, vzzzzzzzzzzzzzzzzzzzf_);
        IEnumerable<ServiceRequest> vzzzzzzzzzzzzzzzzzzzh_ = this.Referral_to_Alternate_or_Primary_Healthcare_Professional_for_Hypertensive_Reading(context);
        IEnumerable<ServiceRequest> vzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Union<ServiceRequest>(vzzzzzzzzzzzzzzzzzzzg_, vzzzzzzzzzzzzzzzzzzzh_);

        return vzzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Encounter with First Hypertensive Reading SBP Greater than or Equal to 130 OR DBP Greater than or Equal to 80 and Interventions")]
    public IEnumerable<Encounter> Encounter_with_First_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_130_OR_DBP_Greater_than_or_Equal_to_80_and_Interventions(CqlContext context)
    {
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzc_ = this.Encounter_with_First_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_130_OR_DBP_Greater_than_or_Equal_to_80(context);
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzd_(Encounter FirstHTNEncounter)
        {
            IEnumerable<ServiceRequest> wzzzzzzzzzzzzzzzzzzzf_ = this.First_Hypertensive_Reading_Interventions_or_Referral_to_Alternate_Professional(context);
            bool? wzzzzzzzzzzzzzzzzzzzg_(ServiceRequest FirstHTNIntervention)
            {
                FhirDateTime wzzzzzzzzzzzzzzzzzzzk_ = FirstHTNIntervention?.AuthoredOnElement;
                CqlDateTime wzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Convert<CqlDateTime>(wzzzzzzzzzzzzzzzzzzzk_);
                Period wzzzzzzzzzzzzzzzzzzzm_ = FirstHTNEncounter?.Period;
                CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzzzzzzzzzzzzzzzm_);
                bool? wzzzzzzzzzzzzzzzzzzzo_ = context.Operators.In<CqlDateTime>(wzzzzzzzzzzzzzzzzzzzl_, wzzzzzzzzzzzzzzzzzzzn_, "day");

                return wzzzzzzzzzzzzzzzzzzzo_;
            };
            IEnumerable<ServiceRequest> wzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Where<ServiceRequest>(wzzzzzzzzzzzzzzzzzzzf_, wzzzzzzzzzzzzzzzzzzzg_);
            Encounter wzzzzzzzzzzzzzzzzzzzi_(ServiceRequest FirstHTNIntervention) =>
                FirstHTNEncounter;
            IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Select<ServiceRequest, Encounter>(wzzzzzzzzzzzzzzzzzzzh_, wzzzzzzzzzzzzzzzzzzzi_);

            return wzzzzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzze_ = context.Operators.SelectMany<Encounter, Encounter>(wzzzzzzzzzzzzzzzzzzzc_, wzzzzzzzzzzzzzzzzzzzd_);

        return wzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Encounter with Second Hypertensive Reading SBP 130 to 139 OR DBP 80 to 89")]
    public IEnumerable<Encounter> Encounter_with_Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89(CqlContext context)
    {
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzp_ = this.Qualifying_Encounter_during_Measurement_Period(context);
        bool? wzzzzzzzzzzzzzzzzzzzq_(Encounter QualifyingEncounter)
        {
            IEnumerable<Observation> wzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/bp"));
            bool? wzzzzzzzzzzzzzzzzzzzt_(Observation BloodPressure)
            {
                DataType zzzzzzzzzzzzzzzzzzzzh_ = BloodPressure?.Effective;
                object zzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzzh_);
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.toInterval(context, zzzzzzzzzzzzzzzzzzzzi_);
                CqlDateTime zzzzzzzzzzzzzzzzzzzzk_ = context.Operators.End(zzzzzzzzzzzzzzzzzzzzj_);
                Period zzzzzzzzzzzzzzzzzzzzl_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzzzzzzzzzzzzzzzl_);
                bool? zzzzzzzzzzzzzzzzzzzzn_ = context.Operators.In<CqlDateTime>(zzzzzzzzzzzzzzzzzzzzk_, zzzzzzzzzzzzzzzzzzzzm_, "day");
                Code<ObservationStatus> zzzzzzzzzzzzzzzzzzzzo_ = BloodPressure?.StatusElement;
                ObservationStatus? zzzzzzzzzzzzzzzzzzzzp_ = zzzzzzzzzzzzzzzzzzzzo_?.Value;
                string zzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Convert<string>(zzzzzzzzzzzzzzzzzzzzp_);
                string[] zzzzzzzzzzzzzzzzzzzzr_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? zzzzzzzzzzzzzzzzzzzzs_ = context.Operators.In<string>(zzzzzzzzzzzzzzzzzzzzq_, zzzzzzzzzzzzzzzzzzzzr_ as IEnumerable<string>);
                bool? zzzzzzzzzzzzzzzzzzzzt_ = context.Operators.And(zzzzzzzzzzzzzzzzzzzzn_, zzzzzzzzzzzzzzzzzzzzs_);

                return zzzzzzzzzzzzzzzzzzzzt_;
            };
            IEnumerable<Observation> wzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Where<Observation>(wzzzzzzzzzzzzzzzzzzzs_, wzzzzzzzzzzzzzzzzzzzt_);
            object wzzzzzzzzzzzzzzzzzzzv_(Observation @this)
            {
                DataType zzzzzzzzzzzzzzzzzzzzu_ = @this?.Effective;
                object zzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzzu_);
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.toInterval(context, zzzzzzzzzzzzzzzzzzzzv_);
                CqlDateTime zzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Start(zzzzzzzzzzzzzzzzzzzzw_);

                return zzzzzzzzzzzzzzzzzzzzx_;
            };
            IEnumerable<Observation> wzzzzzzzzzzzzzzzzzzzw_ = context.Operators.SortBy<Observation>(wzzzzzzzzzzzzzzzzzzzu_, wzzzzzzzzzzzzzzzzzzzv_, System.ComponentModel.ListSortDirection.Ascending);
            Observation wzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Last<Observation>(wzzzzzzzzzzzzzzzzzzzw_);
            List<Observation.ComponentComponent> wzzzzzzzzzzzzzzzzzzzy_ = wzzzzzzzzzzzzzzzzzzzx_?.Component;
            bool? wzzzzzzzzzzzzzzzzzzzz_(Observation.ComponentComponent @this)
            {
                CodeableConcept zzzzzzzzzzzzzzzzzzzzy_ = @this?.Code;
                List<Coding> zzzzzzzzzzzzzzzzzzzzz_ = zzzzzzzzzzzzzzzzzzzzy_?.Coding;
                Coding azzzzzzzzzzzzzzzzzzzza_ = context.Operators.First<Coding>((IEnumerable<Coding>)zzzzzzzzzzzzzzzzzzzzz_);
                FhirUri azzzzzzzzzzzzzzzzzzzzb_ = azzzzzzzzzzzzzzzzzzzza_?.SystemElement;
                string azzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToString(context, azzzzzzzzzzzzzzzzzzzzb_);
                bool? azzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Equal(azzzzzzzzzzzzzzzzzzzzc_, "http://loinc.org");
                List<Coding> azzzzzzzzzzzzzzzzzzzzf_ = zzzzzzzzzzzzzzzzzzzzy_?.Coding;
                Coding azzzzzzzzzzzzzzzzzzzzg_ = context.Operators.First<Coding>((IEnumerable<Coding>)azzzzzzzzzzzzzzzzzzzzf_);
                Code azzzzzzzzzzzzzzzzzzzzh_ = azzzzzzzzzzzzzzzzzzzzg_?.CodeElement;
                string azzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToString(context, azzzzzzzzzzzzzzzzzzzzh_);
                bool? azzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Equal(azzzzzzzzzzzzzzzzzzzzi_, "8480-6");
                bool? azzzzzzzzzzzzzzzzzzzzk_ = context.Operators.And(azzzzzzzzzzzzzzzzzzzzd_, azzzzzzzzzzzzzzzzzzzzj_);

                return azzzzzzzzzzzzzzzzzzzzk_;
            };
            IEnumerable<Observation.ComponentComponent> xzzzzzzzzzzzzzzzzzzza_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)wzzzzzzzzzzzzzzzzzzzy_, wzzzzzzzzzzzzzzzzzzzz_);
            Observation.ComponentComponent xzzzzzzzzzzzzzzzzzzzb_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(xzzzzzzzzzzzzzzzzzzza_);
            DataType xzzzzzzzzzzzzzzzzzzzc_ = xzzzzzzzzzzzzzzzzzzzb_?.Value;
            object xzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzc_);
            CqlQuantity xzzzzzzzzzzzzzzzzzzze_ = context.Operators.Quantity(130m, "mm[Hg]");
            CqlQuantity xzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Quantity(139m, "mm[Hg]");
            CqlInterval<CqlQuantity> xzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Interval(xzzzzzzzzzzzzzzzzzzze_, xzzzzzzzzzzzzzzzzzzzf_, true, true);
            bool? xzzzzzzzzzzzzzzzzzzzh_ = context.Operators.In<CqlQuantity>(xzzzzzzzzzzzzzzzzzzzd_ as CqlQuantity, xzzzzzzzzzzzzzzzzzzzg_, default);
            bool? xzzzzzzzzzzzzzzzzzzzj_(Observation BloodPressure)
            {
                DataType azzzzzzzzzzzzzzzzzzzzl_ = BloodPressure?.Effective;
                object azzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzl_);
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.toInterval(context, azzzzzzzzzzzzzzzzzzzzm_);
                CqlDateTime azzzzzzzzzzzzzzzzzzzzo_ = context.Operators.End(azzzzzzzzzzzzzzzzzzzzn_);
                Period azzzzzzzzzzzzzzzzzzzzp_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzzzzzzzzzzzzzzp_);
                bool? azzzzzzzzzzzzzzzzzzzzr_ = context.Operators.In<CqlDateTime>(azzzzzzzzzzzzzzzzzzzzo_, azzzzzzzzzzzzzzzzzzzzq_, "day");
                Code<ObservationStatus> azzzzzzzzzzzzzzzzzzzzs_ = BloodPressure?.StatusElement;
                ObservationStatus? azzzzzzzzzzzzzzzzzzzzt_ = azzzzzzzzzzzzzzzzzzzzs_?.Value;
                string azzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Convert<string>(azzzzzzzzzzzzzzzzzzzzt_);
                string[] azzzzzzzzzzzzzzzzzzzzv_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? azzzzzzzzzzzzzzzzzzzzw_ = context.Operators.In<string>(azzzzzzzzzzzzzzzzzzzzu_, azzzzzzzzzzzzzzzzzzzzv_ as IEnumerable<string>);
                bool? azzzzzzzzzzzzzzzzzzzzx_ = context.Operators.And(azzzzzzzzzzzzzzzzzzzzr_, azzzzzzzzzzzzzzzzzzzzw_);

                return azzzzzzzzzzzzzzzzzzzzx_;
            };
            IEnumerable<Observation> xzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Where<Observation>(wzzzzzzzzzzzzzzzzzzzs_, xzzzzzzzzzzzzzzzzzzzj_);
            object xzzzzzzzzzzzzzzzzzzzl_(Observation @this)
            {
                DataType azzzzzzzzzzzzzzzzzzzzy_ = @this?.Effective;
                object azzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzy_);
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.toInterval(context, azzzzzzzzzzzzzzzzzzzzz_);
                CqlDateTime bzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Start(bzzzzzzzzzzzzzzzzzzzza_);

                return bzzzzzzzzzzzzzzzzzzzzb_;
            };
            IEnumerable<Observation> xzzzzzzzzzzzzzzzzzzzm_ = context.Operators.SortBy<Observation>(xzzzzzzzzzzzzzzzzzzzk_, xzzzzzzzzzzzzzzzzzzzl_, System.ComponentModel.ListSortDirection.Ascending);
            Observation xzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Last<Observation>(xzzzzzzzzzzzzzzzzzzzm_);
            List<Observation.ComponentComponent> xzzzzzzzzzzzzzzzzzzzo_ = xzzzzzzzzzzzzzzzzzzzn_?.Component;
            bool? xzzzzzzzzzzzzzzzzzzzp_(Observation.ComponentComponent @this)
            {
                CodeableConcept bzzzzzzzzzzzzzzzzzzzzc_ = @this?.Code;
                List<Coding> bzzzzzzzzzzzzzzzzzzzzd_ = bzzzzzzzzzzzzzzzzzzzzc_?.Coding;
                Coding bzzzzzzzzzzzzzzzzzzzze_ = context.Operators.First<Coding>((IEnumerable<Coding>)bzzzzzzzzzzzzzzzzzzzzd_);
                FhirUri bzzzzzzzzzzzzzzzzzzzzf_ = bzzzzzzzzzzzzzzzzzzzze_?.SystemElement;
                string bzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToString(context, bzzzzzzzzzzzzzzzzzzzzf_);
                bool? bzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Equal(bzzzzzzzzzzzzzzzzzzzzg_, "http://loinc.org");
                List<Coding> bzzzzzzzzzzzzzzzzzzzzj_ = bzzzzzzzzzzzzzzzzzzzzc_?.Coding;
                Coding bzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.First<Coding>((IEnumerable<Coding>)bzzzzzzzzzzzzzzzzzzzzj_);
                Code bzzzzzzzzzzzzzzzzzzzzl_ = bzzzzzzzzzzzzzzzzzzzzk_?.CodeElement;
                string bzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToString(context, bzzzzzzzzzzzzzzzzzzzzl_);
                bool? bzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Equal(bzzzzzzzzzzzzzzzzzzzzm_, "8462-4");
                bool? bzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.And(bzzzzzzzzzzzzzzzzzzzzh_, bzzzzzzzzzzzzzzzzzzzzn_);

                return bzzzzzzzzzzzzzzzzzzzzo_;
            };
            IEnumerable<Observation.ComponentComponent> xzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)xzzzzzzzzzzzzzzzzzzzo_, xzzzzzzzzzzzzzzzzzzzp_);
            Observation.ComponentComponent xzzzzzzzzzzzzzzzzzzzr_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(xzzzzzzzzzzzzzzzzzzzq_);
            DataType xzzzzzzzzzzzzzzzzzzzs_ = xzzzzzzzzzzzzzzzzzzzr_?.Value;
            object xzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzs_);
            CqlQuantity xzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Quantity(80m, "mm[Hg]");
            CqlQuantity xzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Quantity(89m, "mm[Hg]");
            CqlInterval<CqlQuantity> xzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Interval(xzzzzzzzzzzzzzzzzzzzu_, xzzzzzzzzzzzzzzzzzzzv_, true, true);
            bool? xzzzzzzzzzzzzzzzzzzzx_ = context.Operators.In<CqlQuantity>(xzzzzzzzzzzzzzzzzzzzt_ as CqlQuantity, xzzzzzzzzzzzzzzzzzzzw_, default);
            bool? xzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Or(xzzzzzzzzzzzzzzzzzzzh_, xzzzzzzzzzzzzzzzzzzzx_);
            bool? yzzzzzzzzzzzzzzzzzzza_(Observation BloodPressure)
            {
                DataType bzzzzzzzzzzzzzzzzzzzzp_ = BloodPressure?.Effective;
                object bzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzp_);
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.toInterval(context, bzzzzzzzzzzzzzzzzzzzzq_);
                CqlDateTime bzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.End(bzzzzzzzzzzzzzzzzzzzzr_);
                Period bzzzzzzzzzzzzzzzzzzzzt_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzzzzzzzzzzzzzzt_);
                bool? bzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.In<CqlDateTime>(bzzzzzzzzzzzzzzzzzzzzs_, bzzzzzzzzzzzzzzzzzzzzu_, "day");
                Code<ObservationStatus> bzzzzzzzzzzzzzzzzzzzzw_ = BloodPressure?.StatusElement;
                ObservationStatus? bzzzzzzzzzzzzzzzzzzzzx_ = bzzzzzzzzzzzzzzzzzzzzw_?.Value;
                string bzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Convert<string>(bzzzzzzzzzzzzzzzzzzzzx_);
                string[] bzzzzzzzzzzzzzzzzzzzzz_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? czzzzzzzzzzzzzzzzzzzza_ = context.Operators.In<string>(bzzzzzzzzzzzzzzzzzzzzy_, bzzzzzzzzzzzzzzzzzzzzz_ as IEnumerable<string>);
                bool? czzzzzzzzzzzzzzzzzzzzb_ = context.Operators.And(bzzzzzzzzzzzzzzzzzzzzv_, czzzzzzzzzzzzzzzzzzzza_);

                return czzzzzzzzzzzzzzzzzzzzb_;
            };
            IEnumerable<Observation> yzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Where<Observation>(wzzzzzzzzzzzzzzzzzzzs_, yzzzzzzzzzzzzzzzzzzza_);
            object yzzzzzzzzzzzzzzzzzzzc_(Observation @this)
            {
                DataType czzzzzzzzzzzzzzzzzzzzc_ = @this?.Effective;
                object czzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzzzc_);
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.toInterval(context, czzzzzzzzzzzzzzzzzzzzd_);
                CqlDateTime czzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Start(czzzzzzzzzzzzzzzzzzzze_);

                return czzzzzzzzzzzzzzzzzzzzf_;
            };
            IEnumerable<Observation> yzzzzzzzzzzzzzzzzzzzd_ = context.Operators.SortBy<Observation>(yzzzzzzzzzzzzzzzzzzzb_, yzzzzzzzzzzzzzzzzzzzc_, System.ComponentModel.ListSortDirection.Ascending);
            Observation yzzzzzzzzzzzzzzzzzzze_ = context.Operators.Last<Observation>(yzzzzzzzzzzzzzzzzzzzd_);
            List<Observation.ComponentComponent> yzzzzzzzzzzzzzzzzzzzf_ = yzzzzzzzzzzzzzzzzzzze_?.Component;
            bool? yzzzzzzzzzzzzzzzzzzzg_(Observation.ComponentComponent @this)
            {
                CodeableConcept czzzzzzzzzzzzzzzzzzzzg_ = @this?.Code;
                List<Coding> czzzzzzzzzzzzzzzzzzzzh_ = czzzzzzzzzzzzzzzzzzzzg_?.Coding;
                Coding czzzzzzzzzzzzzzzzzzzzi_ = context.Operators.First<Coding>((IEnumerable<Coding>)czzzzzzzzzzzzzzzzzzzzh_);
                FhirUri czzzzzzzzzzzzzzzzzzzzj_ = czzzzzzzzzzzzzzzzzzzzi_?.SystemElement;
                string czzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToString(context, czzzzzzzzzzzzzzzzzzzzj_);
                bool? czzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Equal(czzzzzzzzzzzzzzzzzzzzk_, "http://loinc.org");
                List<Coding> czzzzzzzzzzzzzzzzzzzzn_ = czzzzzzzzzzzzzzzzzzzzg_?.Coding;
                Coding czzzzzzzzzzzzzzzzzzzzo_ = context.Operators.First<Coding>((IEnumerable<Coding>)czzzzzzzzzzzzzzzzzzzzn_);
                Code czzzzzzzzzzzzzzzzzzzzp_ = czzzzzzzzzzzzzzzzzzzzo_?.CodeElement;
                string czzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToString(context, czzzzzzzzzzzzzzzzzzzzp_);
                bool? czzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Equal(czzzzzzzzzzzzzzzzzzzzq_, "8480-6");
                bool? czzzzzzzzzzzzzzzzzzzzs_ = context.Operators.And(czzzzzzzzzzzzzzzzzzzzl_, czzzzzzzzzzzzzzzzzzzzr_);

                return czzzzzzzzzzzzzzzzzzzzs_;
            };
            IEnumerable<Observation.ComponentComponent> yzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)yzzzzzzzzzzzzzzzzzzzf_, yzzzzzzzzzzzzzzzzzzzg_);
            Observation.ComponentComponent yzzzzzzzzzzzzzzzzzzzi_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(yzzzzzzzzzzzzzzzzzzzh_);
            DataType yzzzzzzzzzzzzzzzzzzzj_ = yzzzzzzzzzzzzzzzzzzzi_?.Value;
            object yzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzj_);
            CqlQuantity yzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Quantity(140m, "mm[Hg]");
            bool? yzzzzzzzzzzzzzzzzzzzm_ = context.Operators.GreaterOrEqual(yzzzzzzzzzzzzzzzzzzzk_ as CqlQuantity, yzzzzzzzzzzzzzzzzzzzl_);
            bool? yzzzzzzzzzzzzzzzzzzzo_(Observation BloodPressure)
            {
                DataType czzzzzzzzzzzzzzzzzzzzt_ = BloodPressure?.Effective;
                object czzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzzzt_);
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.toInterval(context, czzzzzzzzzzzzzzzzzzzzu_);
                CqlDateTime czzzzzzzzzzzzzzzzzzzzw_ = context.Operators.End(czzzzzzzzzzzzzzzzzzzzv_);
                Period czzzzzzzzzzzzzzzzzzzzx_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzzzzzzzzzzzzzzzzx_);
                bool? czzzzzzzzzzzzzzzzzzzzz_ = context.Operators.In<CqlDateTime>(czzzzzzzzzzzzzzzzzzzzw_, czzzzzzzzzzzzzzzzzzzzy_, "day");
                Code<ObservationStatus> dzzzzzzzzzzzzzzzzzzzza_ = BloodPressure?.StatusElement;
                ObservationStatus? dzzzzzzzzzzzzzzzzzzzzb_ = dzzzzzzzzzzzzzzzzzzzza_?.Value;
                string dzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Convert<string>(dzzzzzzzzzzzzzzzzzzzzb_);
                string[] dzzzzzzzzzzzzzzzzzzzzd_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? dzzzzzzzzzzzzzzzzzzzze_ = context.Operators.In<string>(dzzzzzzzzzzzzzzzzzzzzc_, dzzzzzzzzzzzzzzzzzzzzd_ as IEnumerable<string>);
                bool? dzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.And(czzzzzzzzzzzzzzzzzzzzz_, dzzzzzzzzzzzzzzzzzzzze_);

                return dzzzzzzzzzzzzzzzzzzzzf_;
            };
            IEnumerable<Observation> yzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Observation>(wzzzzzzzzzzzzzzzzzzzs_, yzzzzzzzzzzzzzzzzzzzo_);
            object yzzzzzzzzzzzzzzzzzzzq_(Observation @this)
            {
                DataType dzzzzzzzzzzzzzzzzzzzzg_ = @this?.Effective;
                object dzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzg_);
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.toInterval(context, dzzzzzzzzzzzzzzzzzzzzh_);
                CqlDateTime dzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Start(dzzzzzzzzzzzzzzzzzzzzi_);

                return dzzzzzzzzzzzzzzzzzzzzj_;
            };
            IEnumerable<Observation> yzzzzzzzzzzzzzzzzzzzr_ = context.Operators.SortBy<Observation>(yzzzzzzzzzzzzzzzzzzzp_, yzzzzzzzzzzzzzzzzzzzq_, System.ComponentModel.ListSortDirection.Ascending);
            Observation yzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Last<Observation>(yzzzzzzzzzzzzzzzzzzzr_);
            List<Observation.ComponentComponent> yzzzzzzzzzzzzzzzzzzzt_ = yzzzzzzzzzzzzzzzzzzzs_?.Component;
            bool? yzzzzzzzzzzzzzzzzzzzu_(Observation.ComponentComponent @this)
            {
                CodeableConcept dzzzzzzzzzzzzzzzzzzzzk_ = @this?.Code;
                List<Coding> dzzzzzzzzzzzzzzzzzzzzl_ = dzzzzzzzzzzzzzzzzzzzzk_?.Coding;
                Coding dzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.First<Coding>((IEnumerable<Coding>)dzzzzzzzzzzzzzzzzzzzzl_);
                FhirUri dzzzzzzzzzzzzzzzzzzzzn_ = dzzzzzzzzzzzzzzzzzzzzm_?.SystemElement;
                string dzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToString(context, dzzzzzzzzzzzzzzzzzzzzn_);
                bool? dzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Equal(dzzzzzzzzzzzzzzzzzzzzo_, "http://loinc.org");
                List<Coding> dzzzzzzzzzzzzzzzzzzzzr_ = dzzzzzzzzzzzzzzzzzzzzk_?.Coding;
                Coding dzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.First<Coding>((IEnumerable<Coding>)dzzzzzzzzzzzzzzzzzzzzr_);
                Code dzzzzzzzzzzzzzzzzzzzzt_ = dzzzzzzzzzzzzzzzzzzzzs_?.CodeElement;
                string dzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToString(context, dzzzzzzzzzzzzzzzzzzzzt_);
                bool? dzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Equal(dzzzzzzzzzzzzzzzzzzzzu_, "8462-4");
                bool? dzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.And(dzzzzzzzzzzzzzzzzzzzzp_, dzzzzzzzzzzzzzzzzzzzzv_);

                return dzzzzzzzzzzzzzzzzzzzzw_;
            };
            IEnumerable<Observation.ComponentComponent> yzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)yzzzzzzzzzzzzzzzzzzzt_, yzzzzzzzzzzzzzzzzzzzu_);
            Observation.ComponentComponent yzzzzzzzzzzzzzzzzzzzw_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(yzzzzzzzzzzzzzzzzzzzv_);
            DataType yzzzzzzzzzzzzzzzzzzzx_ = yzzzzzzzzzzzzzzzzzzzw_?.Value;
            object yzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzx_);
            CqlQuantity yzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Quantity(90m, "mm[Hg]");
            bool? zzzzzzzzzzzzzzzzzzzza_ = context.Operators.GreaterOrEqual(yzzzzzzzzzzzzzzzzzzzy_ as CqlQuantity, yzzzzzzzzzzzzzzzzzzzz_);
            bool? zzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Or(yzzzzzzzzzzzzzzzzzzzm_, zzzzzzzzzzzzzzzzzzzza_);
            bool? zzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Not(zzzzzzzzzzzzzzzzzzzzb_);
            bool? zzzzzzzzzzzzzzzzzzzzd_ = context.Operators.And(xzzzzzzzzzzzzzzzzzzzy_, zzzzzzzzzzzzzzzzzzzzc_);
            IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzze_ = this.Encounter_with_Hypertensive_Reading_Within_Year_Prior(context);
            bool? zzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Exists<Encounter>(zzzzzzzzzzzzzzzzzzzze_);
            bool? zzzzzzzzzzzzzzzzzzzzg_ = context.Operators.And(zzzzzzzzzzzzzzzzzzzzd_, zzzzzzzzzzzzzzzzzzzzf_);

            return zzzzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Where<Encounter>(wzzzzzzzzzzzzzzzzzzzp_, wzzzzzzzzzzzzzzzzzzzq_);

        return wzzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Laboratory Test or ECG for Hypertension")]
    public IEnumerable<ServiceRequest> Laboratory_Test_or_ECG_for_Hypertension(CqlContext context)
    {
        CqlCode dzzzzzzzzzzzzzzzzzzzzx_ = this._12_lead_EKG_panel(context);
        IEnumerable<CqlCode> dzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.ToList<CqlCode>(dzzzzzzzzzzzzzzzzzzzzx_);
        IEnumerable<ServiceRequest> dzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, default, dzzzzzzzzzzzzzzzzzzzzy_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        CqlCode ezzzzzzzzzzzzzzzzzzzza_ = this.EKG_study(context);
        IEnumerable<CqlCode> ezzzzzzzzzzzzzzzzzzzzb_ = context.Operators.ToList<CqlCode>(ezzzzzzzzzzzzzzzzzzzza_);
        IEnumerable<ServiceRequest> ezzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, default, ezzzzzzzzzzzzzzzzzzzzb_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> ezzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Union<ServiceRequest>(dzzzzzzzzzzzzzzzzzzzzz_, ezzzzzzzzzzzzzzzzzzzzc_);
        CqlValueSet ezzzzzzzzzzzzzzzzzzzze_ = this.Laboratory_Tests_for_Hypertension(context);
        IEnumerable<ServiceRequest> ezzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> ezzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Union<ServiceRequest>(ezzzzzzzzzzzzzzzzzzzzd_, ezzzzzzzzzzzzzzzzzzzzf_);
        bool? ezzzzzzzzzzzzzzzzzzzzh_(ServiceRequest EKGLab)
        {
            Code<RequestIntent> ezzzzzzzzzzzzzzzzzzzzj_ = EKGLab?.IntentElement;
            RequestIntent? ezzzzzzzzzzzzzzzzzzzzk_ = ezzzzzzzzzzzzzzzzzzzzj_?.Value;
            Code<RequestIntent> ezzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Convert<Code<RequestIntent>>(ezzzzzzzzzzzzzzzzzzzzk_);
            bool? ezzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Equivalent(ezzzzzzzzzzzzzzzzzzzzl_, "order");

            return ezzzzzzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<ServiceRequest> ezzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<ServiceRequest>(ezzzzzzzzzzzzzzzzzzzzg_, ezzzzzzzzzzzzzzzzzzzzh_);

        return ezzzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Second Hypertensive Reading SBP 130 to 139 OR DBP 80 to 89 and Interventions")]
    public IEnumerable<ServiceRequest> Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89_and_Interventions(CqlContext context)
    {
        IEnumerable<ServiceRequest> ezzzzzzzzzzzzzzzzzzzzn_ = this.Follow_up_with_Rescreen_Within_6_Months(context);
        IEnumerable<ServiceRequest> ezzzzzzzzzzzzzzzzzzzzo_(ServiceRequest Rescreen2to6)
        {
            IEnumerable<ServiceRequest> ezzzzzzzzzzzzzzzzzzzzs_ = this.Laboratory_Test_or_ECG_for_Hypertension(context);
            bool? ezzzzzzzzzzzzzzzzzzzzt_(ServiceRequest LabECGIntervention)
            {
                FhirDateTime ezzzzzzzzzzzzzzzzzzzzx_ = Rescreen2to6?.AuthoredOnElement;
                CqlDateTime ezzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Convert<CqlDateTime>(ezzzzzzzzzzzzzzzzzzzzx_);
                CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzz_ = this.Measurement_Period(context);
                bool? fzzzzzzzzzzzzzzzzzzzza_ = context.Operators.In<CqlDateTime>(ezzzzzzzzzzzzzzzzzzzzy_, ezzzzzzzzzzzzzzzzzzzzz_, "day");
                FhirDateTime fzzzzzzzzzzzzzzzzzzzzb_ = LabECGIntervention?.AuthoredOnElement;
                CqlDateTime fzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Convert<CqlDateTime>(fzzzzzzzzzzzzzzzzzzzzb_);
                bool? fzzzzzzzzzzzzzzzzzzzze_ = context.Operators.In<CqlDateTime>(fzzzzzzzzzzzzzzzzzzzzc_, ezzzzzzzzzzzzzzzzzzzzz_, "day");
                bool? fzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.And(fzzzzzzzzzzzzzzzzzzzza_, fzzzzzzzzzzzzzzzzzzzze_);

                return fzzzzzzzzzzzzzzzzzzzzf_;
            };
            IEnumerable<ServiceRequest> ezzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Where<ServiceRequest>(ezzzzzzzzzzzzzzzzzzzzs_, ezzzzzzzzzzzzzzzzzzzzt_);
            ServiceRequest ezzzzzzzzzzzzzzzzzzzzv_(ServiceRequest LabECGIntervention) =>
                Rescreen2to6;
            IEnumerable<ServiceRequest> ezzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Select<ServiceRequest, ServiceRequest>(ezzzzzzzzzzzzzzzzzzzzu_, ezzzzzzzzzzzzzzzzzzzzv_);

            return ezzzzzzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<ServiceRequest> ezzzzzzzzzzzzzzzzzzzzp_ = context.Operators.SelectMany<ServiceRequest, ServiceRequest>(ezzzzzzzzzzzzzzzzzzzzn_, ezzzzzzzzzzzzzzzzzzzzo_);
        IEnumerable<ServiceRequest> ezzzzzzzzzzzzzzzzzzzzq_(ServiceRequest Rescreen2to6)
        {
            IEnumerable<ServiceRequest> fzzzzzzzzzzzzzzzzzzzzg_ = this.NonPharmacological_Interventions(context);
            bool? fzzzzzzzzzzzzzzzzzzzzh_(ServiceRequest NonPharmSecondIntervention)
            {
                FhirDateTime fzzzzzzzzzzzzzzzzzzzzl_ = NonPharmSecondIntervention?.AuthoredOnElement;
                CqlDateTime fzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Convert<CqlDateTime>(fzzzzzzzzzzzzzzzzzzzzl_);
                CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzn_ = this.Measurement_Period(context);
                bool? fzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.In<CqlDateTime>(fzzzzzzzzzzzzzzzzzzzzm_, fzzzzzzzzzzzzzzzzzzzzn_, "day");

                return fzzzzzzzzzzzzzzzzzzzzo_;
            };
            IEnumerable<ServiceRequest> fzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<ServiceRequest>(fzzzzzzzzzzzzzzzzzzzzg_, fzzzzzzzzzzzzzzzzzzzzh_);
            ServiceRequest fzzzzzzzzzzzzzzzzzzzzj_(ServiceRequest NonPharmSecondIntervention) =>
                Rescreen2to6;
            IEnumerable<ServiceRequest> fzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Select<ServiceRequest, ServiceRequest>(fzzzzzzzzzzzzzzzzzzzzi_, fzzzzzzzzzzzzzzzzzzzzj_);

            return fzzzzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<ServiceRequest> ezzzzzzzzzzzzzzzzzzzzr_ = context.Operators.SelectMany<ServiceRequest, ServiceRequest>(ezzzzzzzzzzzzzzzzzzzzp_, ezzzzzzzzzzzzzzzzzzzzq_);

        return ezzzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Encounter with Second Hypertensive Reading SBP 130 to 139 OR DBP 80 to 89 and Interventions")]
    public IEnumerable<Encounter> Encounter_with_Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89_and_Interventions(CqlContext context)
    {
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzp_ = this.Encounter_with_Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89(context);
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzq_(Encounter SecondHTNEncounterReading)
        {
            IEnumerable<ServiceRequest> fzzzzzzzzzzzzzzzzzzzzw_ = this.Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89_and_Interventions(context);
            bool? fzzzzzzzzzzzzzzzzzzzzx_(ServiceRequest EncounterInterventions)
            {
                FhirDateTime gzzzzzzzzzzzzzzzzzzzzb_ = EncounterInterventions?.AuthoredOnElement;
                CqlDateTime gzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Convert<CqlDateTime>(gzzzzzzzzzzzzzzzzzzzzb_);
                Period gzzzzzzzzzzzzzzzzzzzzd_ = SecondHTNEncounterReading?.Period;
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzzzzzzzzzzzzzzzd_);
                bool? gzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.In<CqlDateTime>(gzzzzzzzzzzzzzzzzzzzzc_, gzzzzzzzzzzzzzzzzzzzze_, "day");

                return gzzzzzzzzzzzzzzzzzzzzf_;
            };
            IEnumerable<ServiceRequest> fzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Where<ServiceRequest>(fzzzzzzzzzzzzzzzzzzzzw_, fzzzzzzzzzzzzzzzzzzzzx_);
            Encounter fzzzzzzzzzzzzzzzzzzzzz_(ServiceRequest EncounterInterventions) =>
                SecondHTNEncounterReading;
            IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Select<ServiceRequest, Encounter>(fzzzzzzzzzzzzzzzzzzzzy_, fzzzzzzzzzzzzzzzzzzzzz_);

            return gzzzzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.SelectMany<Encounter, Encounter>(fzzzzzzzzzzzzzzzzzzzzp_, fzzzzzzzzzzzzzzzzzzzzq_);
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzt_(Encounter SecondHTNEncounterReading)
        {
            IEnumerable<ServiceRequest> gzzzzzzzzzzzzzzzzzzzzg_ = this.Referral_to_Alternate_or_Primary_Healthcare_Professional_for_Hypertensive_Reading(context);
            bool? gzzzzzzzzzzzzzzzzzzzzh_(ServiceRequest ReferralForHTN)
            {
                FhirDateTime gzzzzzzzzzzzzzzzzzzzzl_ = ReferralForHTN?.AuthoredOnElement;
                CqlDateTime gzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Convert<CqlDateTime>(gzzzzzzzzzzzzzzzzzzzzl_);
                Period gzzzzzzzzzzzzzzzzzzzzn_ = SecondHTNEncounterReading?.Period;
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzzzzzzzzzzzzzzzn_);
                bool? gzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.In<CqlDateTime>(gzzzzzzzzzzzzzzzzzzzzm_, gzzzzzzzzzzzzzzzzzzzzo_, "day");

                return gzzzzzzzzzzzzzzzzzzzzp_;
            };
            IEnumerable<ServiceRequest> gzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<ServiceRequest>(gzzzzzzzzzzzzzzzzzzzzg_, gzzzzzzzzzzzzzzzzzzzzh_);
            Encounter gzzzzzzzzzzzzzzzzzzzzj_(ServiceRequest ReferralForHTN) =>
                SecondHTNEncounterReading;
            IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Select<ServiceRequest, Encounter>(gzzzzzzzzzzzzzzzzzzzzi_, gzzzzzzzzzzzzzzzzzzzzj_);

            return gzzzzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.SelectMany<Encounter, Encounter>(fzzzzzzzzzzzzzzzzzzzzp_, fzzzzzzzzzzzzzzzzzzzzt_);
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Union<Encounter>(fzzzzzzzzzzzzzzzzzzzzr_, fzzzzzzzzzzzzzzzzzzzzu_);

        return fzzzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Encounter with Second Hypertensive Reading SBP Greater than or Equal to 140 OR DBP Greater than or Equal to 90")]
    public IEnumerable<Encounter> Encounter_with_Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90(CqlContext context)
    {
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzzzzq_ = this.Qualifying_Encounter_during_Measurement_Period(context);
        bool? gzzzzzzzzzzzzzzzzzzzzr_(Encounter QualifyingEncounter)
        {
            IEnumerable<Observation> gzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/bp"));
            bool? gzzzzzzzzzzzzzzzzzzzzu_(Observation BloodPressure)
            {
                DataType jzzzzzzzzzzzzzzzzzzzzd_ = BloodPressure?.Effective;
                object jzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzd_);
                CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.toInterval(context, jzzzzzzzzzzzzzzzzzzzze_);
                CqlDateTime jzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.End(jzzzzzzzzzzzzzzzzzzzzf_);
                Period jzzzzzzzzzzzzzzzzzzzzh_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzzzzzzzzzzzzzzzh_);
                bool? jzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.In<CqlDateTime>(jzzzzzzzzzzzzzzzzzzzzg_, jzzzzzzzzzzzzzzzzzzzzi_, default);
                Code<ObservationStatus> jzzzzzzzzzzzzzzzzzzzzk_ = BloodPressure?.StatusElement;
                ObservationStatus? jzzzzzzzzzzzzzzzzzzzzl_ = jzzzzzzzzzzzzzzzzzzzzk_?.Value;
                string jzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Convert<string>(jzzzzzzzzzzzzzzzzzzzzl_);
                string[] jzzzzzzzzzzzzzzzzzzzzn_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? jzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.In<string>(jzzzzzzzzzzzzzzzzzzzzm_, jzzzzzzzzzzzzzzzzzzzzn_ as IEnumerable<string>);
                bool? jzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.And(jzzzzzzzzzzzzzzzzzzzzj_, jzzzzzzzzzzzzzzzzzzzzo_);

                return jzzzzzzzzzzzzzzzzzzzzp_;
            };
            IEnumerable<Observation> gzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Observation>(gzzzzzzzzzzzzzzzzzzzzt_, gzzzzzzzzzzzzzzzzzzzzu_);
            object gzzzzzzzzzzzzzzzzzzzzw_(Observation @this)
            {
                DataType jzzzzzzzzzzzzzzzzzzzzq_ = @this?.Effective;
                object jzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzq_);
                CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.toInterval(context, jzzzzzzzzzzzzzzzzzzzzr_);
                CqlDateTime jzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Start(jzzzzzzzzzzzzzzzzzzzzs_);

                return jzzzzzzzzzzzzzzzzzzzzt_;
            };
            IEnumerable<Observation> gzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.SortBy<Observation>(gzzzzzzzzzzzzzzzzzzzzv_, gzzzzzzzzzzzzzzzzzzzzw_, System.ComponentModel.ListSortDirection.Ascending);
            Observation gzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Last<Observation>(gzzzzzzzzzzzzzzzzzzzzx_);
            List<Observation.ComponentComponent> gzzzzzzzzzzzzzzzzzzzzz_ = gzzzzzzzzzzzzzzzzzzzzy_?.Component;
            bool? hzzzzzzzzzzzzzzzzzzzza_(Observation.ComponentComponent @this)
            {
                CodeableConcept jzzzzzzzzzzzzzzzzzzzzu_ = @this?.Code;
                List<Coding> jzzzzzzzzzzzzzzzzzzzzv_ = jzzzzzzzzzzzzzzzzzzzzu_?.Coding;
                Coding jzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.First<Coding>((IEnumerable<Coding>)jzzzzzzzzzzzzzzzzzzzzv_);
                FhirUri jzzzzzzzzzzzzzzzzzzzzx_ = jzzzzzzzzzzzzzzzzzzzzw_?.SystemElement;
                string jzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToString(context, jzzzzzzzzzzzzzzzzzzzzx_);
                bool? jzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Equal(jzzzzzzzzzzzzzzzzzzzzy_, "http://loinc.org");
                List<Coding> kzzzzzzzzzzzzzzzzzzzzb_ = jzzzzzzzzzzzzzzzzzzzzu_?.Coding;
                Coding kzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.First<Coding>((IEnumerable<Coding>)kzzzzzzzzzzzzzzzzzzzzb_);
                Code kzzzzzzzzzzzzzzzzzzzzd_ = kzzzzzzzzzzzzzzzzzzzzc_?.CodeElement;
                string kzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToString(context, kzzzzzzzzzzzzzzzzzzzzd_);
                bool? kzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Equal(kzzzzzzzzzzzzzzzzzzzze_, "8480-6");
                bool? kzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.And(jzzzzzzzzzzzzzzzzzzzzz_, kzzzzzzzzzzzzzzzzzzzzf_);

                return kzzzzzzzzzzzzzzzzzzzzg_;
            };
            IEnumerable<Observation.ComponentComponent> hzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)gzzzzzzzzzzzzzzzzzzzzz_, hzzzzzzzzzzzzzzzzzzzza_);
            Observation.ComponentComponent hzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(hzzzzzzzzzzzzzzzzzzzzb_);
            DataType hzzzzzzzzzzzzzzzzzzzzd_ = hzzzzzzzzzzzzzzzzzzzzc_?.Value;
            object hzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzd_);
            CqlQuantity hzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Quantity(0m, "mm[Hg]");
            bool? hzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Greater(hzzzzzzzzzzzzzzzzzzzze_ as CqlQuantity, hzzzzzzzzzzzzzzzzzzzzf_);
            bool? hzzzzzzzzzzzzzzzzzzzzi_(Observation BloodPressure)
            {
                DataType kzzzzzzzzzzzzzzzzzzzzh_ = BloodPressure?.Effective;
                object kzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzh_);
                CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.toInterval(context, kzzzzzzzzzzzzzzzzzzzzi_);
                CqlDateTime kzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.End(kzzzzzzzzzzzzzzzzzzzzj_);
                Period kzzzzzzzzzzzzzzzzzzzzl_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzzzzzzzzzzzzzzzzl_);
                bool? kzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.In<CqlDateTime>(kzzzzzzzzzzzzzzzzzzzzk_, kzzzzzzzzzzzzzzzzzzzzm_, default);
                Code<ObservationStatus> kzzzzzzzzzzzzzzzzzzzzo_ = BloodPressure?.StatusElement;
                ObservationStatus? kzzzzzzzzzzzzzzzzzzzzp_ = kzzzzzzzzzzzzzzzzzzzzo_?.Value;
                string kzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Convert<string>(kzzzzzzzzzzzzzzzzzzzzp_);
                string[] kzzzzzzzzzzzzzzzzzzzzr_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? kzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.In<string>(kzzzzzzzzzzzzzzzzzzzzq_, kzzzzzzzzzzzzzzzzzzzzr_ as IEnumerable<string>);
                bool? kzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.And(kzzzzzzzzzzzzzzzzzzzzn_, kzzzzzzzzzzzzzzzzzzzzs_);

                return kzzzzzzzzzzzzzzzzzzzzt_;
            };
            IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Where<Observation>(gzzzzzzzzzzzzzzzzzzzzt_, hzzzzzzzzzzzzzzzzzzzzi_);
            object hzzzzzzzzzzzzzzzzzzzzk_(Observation @this)
            {
                DataType kzzzzzzzzzzzzzzzzzzzzu_ = @this?.Effective;
                object kzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzu_);
                CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.toInterval(context, kzzzzzzzzzzzzzzzzzzzzv_);
                CqlDateTime kzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Start(kzzzzzzzzzzzzzzzzzzzzw_);

                return kzzzzzzzzzzzzzzzzzzzzx_;
            };
            IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.SortBy<Observation>(hzzzzzzzzzzzzzzzzzzzzj_, hzzzzzzzzzzzzzzzzzzzzk_, System.ComponentModel.ListSortDirection.Ascending);
            Observation hzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Last<Observation>(hzzzzzzzzzzzzzzzzzzzzl_);
            List<Observation.ComponentComponent> hzzzzzzzzzzzzzzzzzzzzn_ = hzzzzzzzzzzzzzzzzzzzzm_?.Component;
            bool? hzzzzzzzzzzzzzzzzzzzzo_(Observation.ComponentComponent @this)
            {
                CodeableConcept kzzzzzzzzzzzzzzzzzzzzy_ = @this?.Code;
                List<Coding> kzzzzzzzzzzzzzzzzzzzzz_ = kzzzzzzzzzzzzzzzzzzzzy_?.Coding;
                Coding lzzzzzzzzzzzzzzzzzzzza_ = context.Operators.First<Coding>((IEnumerable<Coding>)kzzzzzzzzzzzzzzzzzzzzz_);
                FhirUri lzzzzzzzzzzzzzzzzzzzzb_ = lzzzzzzzzzzzzzzzzzzzza_?.SystemElement;
                string lzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToString(context, lzzzzzzzzzzzzzzzzzzzzb_);
                bool? lzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Equal(lzzzzzzzzzzzzzzzzzzzzc_, "http://loinc.org");
                List<Coding> lzzzzzzzzzzzzzzzzzzzzf_ = kzzzzzzzzzzzzzzzzzzzzy_?.Coding;
                Coding lzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.First<Coding>((IEnumerable<Coding>)lzzzzzzzzzzzzzzzzzzzzf_);
                Code lzzzzzzzzzzzzzzzzzzzzh_ = lzzzzzzzzzzzzzzzzzzzzg_?.CodeElement;
                string lzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToString(context, lzzzzzzzzzzzzzzzzzzzzh_);
                bool? lzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Equal(lzzzzzzzzzzzzzzzzzzzzi_, "8462-4");
                bool? lzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.And(lzzzzzzzzzzzzzzzzzzzzd_, lzzzzzzzzzzzzzzzzzzzzj_);

                return lzzzzzzzzzzzzzzzzzzzzk_;
            };
            IEnumerable<Observation.ComponentComponent> hzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)hzzzzzzzzzzzzzzzzzzzzn_, hzzzzzzzzzzzzzzzzzzzzo_);
            Observation.ComponentComponent hzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(hzzzzzzzzzzzzzzzzzzzzp_);
            DataType hzzzzzzzzzzzzzzzzzzzzr_ = hzzzzzzzzzzzzzzzzzzzzq_?.Value;
            object hzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzr_);
            bool? hzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Greater(hzzzzzzzzzzzzzzzzzzzzs_ as CqlQuantity, hzzzzzzzzzzzzzzzzzzzzf_);
            bool? hzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.And(hzzzzzzzzzzzzzzzzzzzzg_, hzzzzzzzzzzzzzzzzzzzzu_);
            bool? hzzzzzzzzzzzzzzzzzzzzx_(Observation BloodPressure)
            {
                DataType lzzzzzzzzzzzzzzzzzzzzl_ = BloodPressure?.Effective;
                object lzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzl_);
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.toInterval(context, lzzzzzzzzzzzzzzzzzzzzm_);
                CqlDateTime lzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.End(lzzzzzzzzzzzzzzzzzzzzn_);
                Period lzzzzzzzzzzzzzzzzzzzzp_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzzzzzzzzzzzzzzzp_);
                bool? lzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.In<CqlDateTime>(lzzzzzzzzzzzzzzzzzzzzo_, lzzzzzzzzzzzzzzzzzzzzq_, default);
                Code<ObservationStatus> lzzzzzzzzzzzzzzzzzzzzs_ = BloodPressure?.StatusElement;
                ObservationStatus? lzzzzzzzzzzzzzzzzzzzzt_ = lzzzzzzzzzzzzzzzzzzzzs_?.Value;
                string lzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Convert<string>(lzzzzzzzzzzzzzzzzzzzzt_);
                string[] lzzzzzzzzzzzzzzzzzzzzv_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? lzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.In<string>(lzzzzzzzzzzzzzzzzzzzzu_, lzzzzzzzzzzzzzzzzzzzzv_ as IEnumerable<string>);
                bool? lzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.And(lzzzzzzzzzzzzzzzzzzzzr_, lzzzzzzzzzzzzzzzzzzzzw_);

                return lzzzzzzzzzzzzzzzzzzzzx_;
            };
            IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Where<Observation>(gzzzzzzzzzzzzzzzzzzzzt_, hzzzzzzzzzzzzzzzzzzzzx_);
            object hzzzzzzzzzzzzzzzzzzzzz_(Observation @this)
            {
                DataType lzzzzzzzzzzzzzzzzzzzzy_ = @this?.Effective;
                object lzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzy_);
                CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.toInterval(context, lzzzzzzzzzzzzzzzzzzzzz_);
                CqlDateTime mzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Start(mzzzzzzzzzzzzzzzzzzzza_);

                return mzzzzzzzzzzzzzzzzzzzzb_;
            };
            IEnumerable<Observation> izzzzzzzzzzzzzzzzzzzza_ = context.Operators.SortBy<Observation>(hzzzzzzzzzzzzzzzzzzzzy_, hzzzzzzzzzzzzzzzzzzzzz_, System.ComponentModel.ListSortDirection.Ascending);
            Observation izzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Last<Observation>(izzzzzzzzzzzzzzzzzzzza_);
            List<Observation.ComponentComponent> izzzzzzzzzzzzzzzzzzzzc_ = izzzzzzzzzzzzzzzzzzzzb_?.Component;
            bool? izzzzzzzzzzzzzzzzzzzzd_(Observation.ComponentComponent @this)
            {
                CodeableConcept mzzzzzzzzzzzzzzzzzzzzc_ = @this?.Code;
                List<Coding> mzzzzzzzzzzzzzzzzzzzzd_ = mzzzzzzzzzzzzzzzzzzzzc_?.Coding;
                Coding mzzzzzzzzzzzzzzzzzzzze_ = context.Operators.First<Coding>((IEnumerable<Coding>)mzzzzzzzzzzzzzzzzzzzzd_);
                FhirUri mzzzzzzzzzzzzzzzzzzzzf_ = mzzzzzzzzzzzzzzzzzzzze_?.SystemElement;
                string mzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToString(context, mzzzzzzzzzzzzzzzzzzzzf_);
                bool? mzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Equal(mzzzzzzzzzzzzzzzzzzzzg_, "http://loinc.org");
                List<Coding> mzzzzzzzzzzzzzzzzzzzzj_ = mzzzzzzzzzzzzzzzzzzzzc_?.Coding;
                Coding mzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.First<Coding>((IEnumerable<Coding>)mzzzzzzzzzzzzzzzzzzzzj_);
                Code mzzzzzzzzzzzzzzzzzzzzl_ = mzzzzzzzzzzzzzzzzzzzzk_?.CodeElement;
                string mzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToString(context, mzzzzzzzzzzzzzzzzzzzzl_);
                bool? mzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Equal(mzzzzzzzzzzzzzzzzzzzzm_, "8480-6");
                bool? mzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.And(mzzzzzzzzzzzzzzzzzzzzh_, mzzzzzzzzzzzzzzzzzzzzn_);

                return mzzzzzzzzzzzzzzzzzzzzo_;
            };
            IEnumerable<Observation.ComponentComponent> izzzzzzzzzzzzzzzzzzzze_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)izzzzzzzzzzzzzzzzzzzzc_, izzzzzzzzzzzzzzzzzzzzd_);
            Observation.ComponentComponent izzzzzzzzzzzzzzzzzzzzf_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(izzzzzzzzzzzzzzzzzzzze_);
            DataType izzzzzzzzzzzzzzzzzzzzg_ = izzzzzzzzzzzzzzzzzzzzf_?.Value;
            object izzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzg_);
            CqlQuantity izzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Quantity(140m, "mm[Hg]");
            bool? izzzzzzzzzzzzzzzzzzzzj_ = context.Operators.GreaterOrEqual(izzzzzzzzzzzzzzzzzzzzh_ as CqlQuantity, izzzzzzzzzzzzzzzzzzzzi_);
            bool? izzzzzzzzzzzzzzzzzzzzl_(Observation BloodPressure)
            {
                DataType mzzzzzzzzzzzzzzzzzzzzp_ = BloodPressure?.Effective;
                object mzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzp_);
                CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.toInterval(context, mzzzzzzzzzzzzzzzzzzzzq_);
                CqlDateTime mzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.End(mzzzzzzzzzzzzzzzzzzzzr_);
                Period mzzzzzzzzzzzzzzzzzzzzt_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzzzzzzzzzzzzzzzt_);
                bool? mzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.In<CqlDateTime>(mzzzzzzzzzzzzzzzzzzzzs_, mzzzzzzzzzzzzzzzzzzzzu_, default);
                Code<ObservationStatus> mzzzzzzzzzzzzzzzzzzzzw_ = BloodPressure?.StatusElement;
                ObservationStatus? mzzzzzzzzzzzzzzzzzzzzx_ = mzzzzzzzzzzzzzzzzzzzzw_?.Value;
                string mzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Convert<string>(mzzzzzzzzzzzzzzzzzzzzx_);
                string[] mzzzzzzzzzzzzzzzzzzzzz_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? nzzzzzzzzzzzzzzzzzzzza_ = context.Operators.In<string>(mzzzzzzzzzzzzzzzzzzzzy_, mzzzzzzzzzzzzzzzzzzzzz_ as IEnumerable<string>);
                bool? nzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.And(mzzzzzzzzzzzzzzzzzzzzv_, nzzzzzzzzzzzzzzzzzzzza_);

                return nzzzzzzzzzzzzzzzzzzzzb_;
            };
            IEnumerable<Observation> izzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Where<Observation>(gzzzzzzzzzzzzzzzzzzzzt_, izzzzzzzzzzzzzzzzzzzzl_);
            object izzzzzzzzzzzzzzzzzzzzn_(Observation @this)
            {
                DataType nzzzzzzzzzzzzzzzzzzzzc_ = @this?.Effective;
                object nzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzzzc_);
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.toInterval(context, nzzzzzzzzzzzzzzzzzzzzd_);
                CqlDateTime nzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Start(nzzzzzzzzzzzzzzzzzzzze_);

                return nzzzzzzzzzzzzzzzzzzzzf_;
            };
            IEnumerable<Observation> izzzzzzzzzzzzzzzzzzzzo_ = context.Operators.SortBy<Observation>(izzzzzzzzzzzzzzzzzzzzm_, izzzzzzzzzzzzzzzzzzzzn_, System.ComponentModel.ListSortDirection.Ascending);
            Observation izzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Last<Observation>(izzzzzzzzzzzzzzzzzzzzo_);
            List<Observation.ComponentComponent> izzzzzzzzzzzzzzzzzzzzq_ = izzzzzzzzzzzzzzzzzzzzp_?.Component;
            bool? izzzzzzzzzzzzzzzzzzzzr_(Observation.ComponentComponent @this)
            {
                CodeableConcept nzzzzzzzzzzzzzzzzzzzzg_ = @this?.Code;
                List<Coding> nzzzzzzzzzzzzzzzzzzzzh_ = nzzzzzzzzzzzzzzzzzzzzg_?.Coding;
                Coding nzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.First<Coding>((IEnumerable<Coding>)nzzzzzzzzzzzzzzzzzzzzh_);
                FhirUri nzzzzzzzzzzzzzzzzzzzzj_ = nzzzzzzzzzzzzzzzzzzzzi_?.SystemElement;
                string nzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToString(context, nzzzzzzzzzzzzzzzzzzzzj_);
                bool? nzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Equal(nzzzzzzzzzzzzzzzzzzzzk_, "http://loinc.org");
                List<Coding> nzzzzzzzzzzzzzzzzzzzzn_ = nzzzzzzzzzzzzzzzzzzzzg_?.Coding;
                Coding nzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.First<Coding>((IEnumerable<Coding>)nzzzzzzzzzzzzzzzzzzzzn_);
                Code nzzzzzzzzzzzzzzzzzzzzp_ = nzzzzzzzzzzzzzzzzzzzzo_?.CodeElement;
                string nzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToString(context, nzzzzzzzzzzzzzzzzzzzzp_);
                bool? nzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Equal(nzzzzzzzzzzzzzzzzzzzzq_, "8462-4");
                bool? nzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.And(nzzzzzzzzzzzzzzzzzzzzl_, nzzzzzzzzzzzzzzzzzzzzr_);

                return nzzzzzzzzzzzzzzzzzzzzs_;
            };
            IEnumerable<Observation.ComponentComponent> izzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)izzzzzzzzzzzzzzzzzzzzq_, izzzzzzzzzzzzzzzzzzzzr_);
            Observation.ComponentComponent izzzzzzzzzzzzzzzzzzzzt_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(izzzzzzzzzzzzzzzzzzzzs_);
            DataType izzzzzzzzzzzzzzzzzzzzu_ = izzzzzzzzzzzzzzzzzzzzt_?.Value;
            object izzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzu_);
            CqlQuantity izzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Quantity(90m, "mm[Hg]");
            bool? izzzzzzzzzzzzzzzzzzzzx_ = context.Operators.GreaterOrEqual(izzzzzzzzzzzzzzzzzzzzv_ as CqlQuantity, izzzzzzzzzzzzzzzzzzzzw_);
            bool? izzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Or(izzzzzzzzzzzzzzzzzzzzj_, izzzzzzzzzzzzzzzzzzzzx_);
            bool? izzzzzzzzzzzzzzzzzzzzz_ = context.Operators.And(hzzzzzzzzzzzzzzzzzzzzv_, izzzzzzzzzzzzzzzzzzzzy_);
            IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzza_ = this.Encounter_with_Hypertensive_Reading_Within_Year_Prior(context);
            bool? jzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Exists<Encounter>(jzzzzzzzzzzzzzzzzzzzza_);
            bool? jzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.And(izzzzzzzzzzzzzzzzzzzzz_, jzzzzzzzzzzzzzzzzzzzzb_);

            return jzzzzzzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Where<Encounter>(gzzzzzzzzzzzzzzzzzzzzq_, gzzzzzzzzzzzzzzzzzzzzr_);

        return gzzzzzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Second Hypertensive Reading SBP Greater than or Equal to 140 OR DBP Greater than or Equal to 90 Interventions")]
    public IEnumerable<ServiceRequest> Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90_Interventions(CqlContext context)
    {
        CqlValueSet nzzzzzzzzzzzzzzzzzzzzt_ = this.Follow_Up_Within_4_Weeks(context);
        IEnumerable<ServiceRequest> nzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, nzzzzzzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> nzzzzzzzzzzzzzzzzzzzzv_(ServiceRequest WeeksRescreen)
        {
            IEnumerable<ServiceRequest> ozzzzzzzzzzzzzzzzzzzzb_ = this.Laboratory_Test_or_ECG_for_Hypertension(context);
            bool? ozzzzzzzzzzzzzzzzzzzzc_(ServiceRequest ECGLabTest)
            {
                FhirDateTime ozzzzzzzzzzzzzzzzzzzzg_ = WeeksRescreen?.AuthoredOnElement;
                CqlDateTime ozzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Convert<CqlDateTime>(ozzzzzzzzzzzzzzzzzzzzg_);
                CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzi_ = this.Measurement_Period(context);
                bool? ozzzzzzzzzzzzzzzzzzzzj_ = context.Operators.In<CqlDateTime>(ozzzzzzzzzzzzzzzzzzzzh_, ozzzzzzzzzzzzzzzzzzzzi_, "day");
                FhirDateTime ozzzzzzzzzzzzzzzzzzzzk_ = ECGLabTest?.AuthoredOnElement;
                CqlDateTime ozzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Convert<CqlDateTime>(ozzzzzzzzzzzzzzzzzzzzk_);
                bool? ozzzzzzzzzzzzzzzzzzzzn_ = context.Operators.In<CqlDateTime>(ozzzzzzzzzzzzzzzzzzzzl_, ozzzzzzzzzzzzzzzzzzzzi_, "day");
                bool? ozzzzzzzzzzzzzzzzzzzzo_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzzzj_, ozzzzzzzzzzzzzzzzzzzzn_);
                Code<RequestIntent> ozzzzzzzzzzzzzzzzzzzzp_ = WeeksRescreen?.IntentElement;
                RequestIntent? ozzzzzzzzzzzzzzzzzzzzq_ = ozzzzzzzzzzzzzzzzzzzzp_?.Value;
                Code<RequestIntent> ozzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Convert<Code<RequestIntent>>(ozzzzzzzzzzzzzzzzzzzzq_);
                bool? ozzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Equivalent(ozzzzzzzzzzzzzzzzzzzzr_, "order");
                bool? ozzzzzzzzzzzzzzzzzzzzt_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzzzo_, ozzzzzzzzzzzzzzzzzzzzs_);
                Code<RequestIntent> ozzzzzzzzzzzzzzzzzzzzu_ = ECGLabTest?.IntentElement;
                RequestIntent? ozzzzzzzzzzzzzzzzzzzzv_ = ozzzzzzzzzzzzzzzzzzzzu_?.Value;
                Code<RequestIntent> ozzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Convert<Code<RequestIntent>>(ozzzzzzzzzzzzzzzzzzzzv_);
                bool? ozzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Equivalent(ozzzzzzzzzzzzzzzzzzzzw_, "order");
                bool? ozzzzzzzzzzzzzzzzzzzzy_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzzzt_, ozzzzzzzzzzzzzzzzzzzzx_);

                return ozzzzzzzzzzzzzzzzzzzzy_;
            };
            IEnumerable<ServiceRequest> ozzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Where<ServiceRequest>(ozzzzzzzzzzzzzzzzzzzzb_, ozzzzzzzzzzzzzzzzzzzzc_);
            ServiceRequest ozzzzzzzzzzzzzzzzzzzze_(ServiceRequest ECGLabTest) =>
                WeeksRescreen;
            IEnumerable<ServiceRequest> ozzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Select<ServiceRequest, ServiceRequest>(ozzzzzzzzzzzzzzzzzzzzd_, ozzzzzzzzzzzzzzzzzzzze_);

            return ozzzzzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<ServiceRequest> nzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.SelectMany<ServiceRequest, ServiceRequest>(nzzzzzzzzzzzzzzzzzzzzu_, nzzzzzzzzzzzzzzzzzzzzv_);
        IEnumerable<ServiceRequest> nzzzzzzzzzzzzzzzzzzzzx_(ServiceRequest WeeksRescreen)
        {
            IEnumerable<ServiceRequest> ozzzzzzzzzzzzzzzzzzzzz_ = this.NonPharmacological_Interventions(context);
            bool? pzzzzzzzzzzzzzzzzzzzza_(ServiceRequest HTNInterventions)
            {
                FhirDateTime pzzzzzzzzzzzzzzzzzzzze_ = HTNInterventions?.AuthoredOnElement;
                CqlDateTime pzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Convert<CqlDateTime>(pzzzzzzzzzzzzzzzzzzzze_);
                CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzg_ = this.Measurement_Period(context);
                bool? pzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.In<CqlDateTime>(pzzzzzzzzzzzzzzzzzzzzf_, pzzzzzzzzzzzzzzzzzzzzg_, "day");

                return pzzzzzzzzzzzzzzzzzzzzh_;
            };
            IEnumerable<ServiceRequest> pzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Where<ServiceRequest>(ozzzzzzzzzzzzzzzzzzzzz_, pzzzzzzzzzzzzzzzzzzzza_);
            ServiceRequest pzzzzzzzzzzzzzzzzzzzzc_(ServiceRequest HTNInterventions) =>
                WeeksRescreen;
            IEnumerable<ServiceRequest> pzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Select<ServiceRequest, ServiceRequest>(pzzzzzzzzzzzzzzzzzzzzb_, pzzzzzzzzzzzzzzzzzzzzc_);

            return pzzzzzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<ServiceRequest> nzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.SelectMany<ServiceRequest, ServiceRequest>(nzzzzzzzzzzzzzzzzzzzzw_, nzzzzzzzzzzzzzzzzzzzzx_);
        IEnumerable<ServiceRequest> nzzzzzzzzzzzzzzzzzzzzz_(ServiceRequest WeeksRescreen)
        {
            CqlValueSet pzzzzzzzzzzzzzzzzzzzzi_ = this.Pharmacologic_Therapy_for_Hypertension(context);
            IEnumerable<MedicationRequest> pzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> pzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> pzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Union<MedicationRequest>(pzzzzzzzzzzzzzzzzzzzzj_, pzzzzzzzzzzzzzzzzzzzzl_);
            bool? pzzzzzzzzzzzzzzzzzzzzn_(MedicationRequest Medications)
            {
                FhirDateTime pzzzzzzzzzzzzzzzzzzzzr_ = Medications?.AuthoredOnElement;
                CqlDateTime pzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Convert<CqlDateTime>(pzzzzzzzzzzzzzzzzzzzzr_);
                CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzt_ = this.Measurement_Period(context);
                bool? pzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.In<CqlDateTime>(pzzzzzzzzzzzzzzzzzzzzs_, pzzzzzzzzzzzzzzzzzzzzt_, "day");
                Code<MedicationRequest.MedicationrequestStatus> pzzzzzzzzzzzzzzzzzzzzv_ = Medications?.StatusElement;
                MedicationRequest.MedicationrequestStatus? pzzzzzzzzzzzzzzzzzzzzw_ = pzzzzzzzzzzzzzzzzzzzzv_?.Value;
                string pzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Convert<string>(pzzzzzzzzzzzzzzzzzzzzw_);
                bool? pzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Equivalent(pzzzzzzzzzzzzzzzzzzzzx_, "active");
                bool? pzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.And(pzzzzzzzzzzzzzzzzzzzzu_, pzzzzzzzzzzzzzzzzzzzzy_);

                return pzzzzzzzzzzzzzzzzzzzzz_;
            };
            IEnumerable<MedicationRequest> pzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<MedicationRequest>(pzzzzzzzzzzzzzzzzzzzzm_, pzzzzzzzzzzzzzzzzzzzzn_);
            ServiceRequest pzzzzzzzzzzzzzzzzzzzzp_(MedicationRequest Medications) =>
                WeeksRescreen;
            IEnumerable<ServiceRequest> pzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Select<MedicationRequest, ServiceRequest>(pzzzzzzzzzzzzzzzzzzzzo_, pzzzzzzzzzzzzzzzzzzzzp_);

            return pzzzzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<ServiceRequest> ozzzzzzzzzzzzzzzzzzzza_ = context.Operators.SelectMany<ServiceRequest, ServiceRequest>(nzzzzzzzzzzzzzzzzzzzzy_, nzzzzzzzzzzzzzzzzzzzzz_);

        return ozzzzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Encounter with Second Hypertensive Reading SBP Greater than or Equal to 140 OR DBP Greater than or Equal to 90 and Interventions")]
    public IEnumerable<Encounter> Encounter_with_Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90_and_Interventions(CqlContext context)
    {
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzza_ = this.Encounter_with_Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90(context);
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzb_(Encounter SecondHTNEncounterReading140Over90)
        {
            IEnumerable<ServiceRequest> qzzzzzzzzzzzzzzzzzzzzh_ = this.Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90_Interventions(context);
            bool? qzzzzzzzzzzzzzzzzzzzzi_(ServiceRequest SecondHTN140Over90Interventions)
            {
                FhirDateTime qzzzzzzzzzzzzzzzzzzzzm_ = SecondHTN140Over90Interventions?.AuthoredOnElement;
                CqlDateTime qzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Convert<CqlDateTime>(qzzzzzzzzzzzzzzzzzzzzm_);
                Period qzzzzzzzzzzzzzzzzzzzzo_ = SecondHTNEncounterReading140Over90?.Period;
                CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzzzzzzzzzzzzzzzzo_);
                bool? qzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.In<CqlDateTime>(qzzzzzzzzzzzzzzzzzzzzn_, qzzzzzzzzzzzzzzzzzzzzp_, "day");

                return qzzzzzzzzzzzzzzzzzzzzq_;
            };
            IEnumerable<ServiceRequest> qzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Where<ServiceRequest>(qzzzzzzzzzzzzzzzzzzzzh_, qzzzzzzzzzzzzzzzzzzzzi_);
            Encounter qzzzzzzzzzzzzzzzzzzzzk_(ServiceRequest SecondHTN140Over90Interventions) =>
                SecondHTNEncounterReading140Over90;
            IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Select<ServiceRequest, Encounter>(qzzzzzzzzzzzzzzzzzzzzj_, qzzzzzzzzzzzzzzzzzzzzk_);

            return qzzzzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.SelectMany<Encounter, Encounter>(qzzzzzzzzzzzzzzzzzzzza_, qzzzzzzzzzzzzzzzzzzzzb_);
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzze_(Encounter SecondHTNEncounterReading140Over90)
        {
            IEnumerable<ServiceRequest> qzzzzzzzzzzzzzzzzzzzzr_ = this.Referral_to_Alternate_or_Primary_Healthcare_Professional_for_Hypertensive_Reading(context);
            bool? qzzzzzzzzzzzzzzzzzzzzs_(ServiceRequest ReferralToProfessional)
            {
                FhirDateTime qzzzzzzzzzzzzzzzzzzzzw_ = ReferralToProfessional?.AuthoredOnElement;
                CqlDateTime qzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Convert<CqlDateTime>(qzzzzzzzzzzzzzzzzzzzzw_);
                Period qzzzzzzzzzzzzzzzzzzzzy_ = SecondHTNEncounterReading140Over90?.Period;
                CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzzzzzzzzzzzzzzzzy_);
                bool? rzzzzzzzzzzzzzzzzzzzza_ = context.Operators.In<CqlDateTime>(qzzzzzzzzzzzzzzzzzzzzx_, qzzzzzzzzzzzzzzzzzzzzz_, "day");

                return rzzzzzzzzzzzzzzzzzzzza_;
            };
            IEnumerable<ServiceRequest> qzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Where<ServiceRequest>(qzzzzzzzzzzzzzzzzzzzzr_, qzzzzzzzzzzzzzzzzzzzzs_);
            Encounter qzzzzzzzzzzzzzzzzzzzzu_(ServiceRequest ReferralToProfessional) =>
                SecondHTNEncounterReading140Over90;
            IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Select<ServiceRequest, Encounter>(qzzzzzzzzzzzzzzzzzzzzt_, qzzzzzzzzzzzzzzzzzzzzu_);

            return qzzzzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.SelectMany<Encounter, Encounter>(qzzzzzzzzzzzzzzzzzzzza_, qzzzzzzzzzzzzzzzzzzzze_);
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Union<Encounter>(qzzzzzzzzzzzzzzzzzzzzc_, qzzzzzzzzzzzzzzzzzzzzf_);

        return qzzzzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context)
    {
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzb_ = this.Encounter_with_Normal_Blood_Pressure_Reading(context);
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzc_ = this.Encounter_with_Elevated_Blood_Pressure_Reading_SBP_120_to_129_AND_DBP_less_than_80_and_Interventions(context);
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Union<Encounter>(rzzzzzzzzzzzzzzzzzzzzb_, rzzzzzzzzzzzzzzzzzzzzc_);
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzze_ = this.Encounter_with_First_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_130_OR_DBP_Greater_than_or_Equal_to_80_and_Interventions(context);
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzf_ = this.Encounter_with_Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89_and_Interventions(context);
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Union<Encounter>(rzzzzzzzzzzzzzzzzzzzze_, rzzzzzzzzzzzzzzzzzzzzf_);
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Union<Encounter>(rzzzzzzzzzzzzzzzzzzzzd_, rzzzzzzzzzzzzzzzzzzzzg_);
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzi_ = this.Encounter_with_Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90_and_Interventions(context);
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Union<Encounter>(rzzzzzzzzzzzzzzzzzzzzh_, rzzzzzzzzzzzzzzzzzzzzi_);

        return rzzzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Encounter with Medical Reason for Not Obtaining or Patient Declined Blood Pressure Measurement")]
    public IEnumerable<Encounter> Encounter_with_Medical_Reason_for_Not_Obtaining_or_Patient_Declined_Blood_Pressure_Measurement(CqlContext context)
    {
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzk_ = this.Qualifying_Encounter_during_Measurement_Period(context);
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzl_(Encounter QualifyingEncounter)
        {
            CqlCode rzzzzzzzzzzzzzzzzzzzzn_ = this.Systolic_blood_pressure(context);
            IEnumerable<CqlCode> rzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.ToList<CqlCode>(rzzzzzzzzzzzzzzzzzzzzn_);
            IEnumerable<Observation> rzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, rzzzzzzzzzzzzzzzzzzzzo_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observationnotdone"));
            CqlCode rzzzzzzzzzzzzzzzzzzzzq_ = this.Diastolic_blood_pressure(context);
            IEnumerable<CqlCode> rzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.ToList<CqlCode>(rzzzzzzzzzzzzzzzzzzzzq_);
            IEnumerable<Observation> rzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, rzzzzzzzzzzzzzzzzzzzzr_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observationnotdone"));
            IEnumerable<Observation> rzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Union<Observation>(rzzzzzzzzzzzzzzzzzzzzp_, rzzzzzzzzzzzzzzzzzzzzs_);
            bool? rzzzzzzzzzzzzzzzzzzzzu_(Observation NoBPScreen)
            {
                Instant rzzzzzzzzzzzzzzzzzzzzy_ = NoBPScreen?.IssuedElement;
                DateTimeOffset? rzzzzzzzzzzzzzzzzzzzzz_ = rzzzzzzzzzzzzzzzzzzzzy_?.Value;
                CqlDateTime szzzzzzzzzzzzzzzzzzzza_ = context.Operators.Convert<CqlDateTime>(rzzzzzzzzzzzzzzzzzzzzz_);
                Period szzzzzzzzzzzzzzzzzzzzb_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzzzzzzzzzzzzzzzzzb_);
                bool? szzzzzzzzzzzzzzzzzzzzd_ = context.Operators.In<CqlDateTime>(szzzzzzzzzzzzzzzzzzzza_, szzzzzzzzzzzzzzzzzzzzc_, "day");
                bool? szzzzzzzzzzzzzzzzzzzze_(Extension @this)
                {
                    string tzzzzzzzzzzzzzzzzzzzzb_ = @this?.Url;
                    FhirString tzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Convert<FhirString>(tzzzzzzzzzzzzzzzzzzzzb_);
                    string tzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToString(context, tzzzzzzzzzzzzzzzzzzzzc_);
                    bool? tzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Equal(tzzzzzzzzzzzzzzzzzzzzd_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-notDoneReason");

                    return tzzzzzzzzzzzzzzzzzzzze_;
                };
                IEnumerable<Extension> szzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(NoBPScreen is DomainResource
                        ? (NoBPScreen as DomainResource).Extension
                        : default), szzzzzzzzzzzzzzzzzzzze_);
                object szzzzzzzzzzzzzzzzzzzzg_(Extension @this)
                {
                    DataType tzzzzzzzzzzzzzzzzzzzzf_ = @this?.Value;

                    return tzzzzzzzzzzzzzzzzzzzzf_;
                };
                IEnumerable<object> szzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Select<Extension, object>(szzzzzzzzzzzzzzzzzzzzf_, szzzzzzzzzzzzzzzzzzzzg_);
                object szzzzzzzzzzzzzzzzzzzzi_ = context.Operators.SingletonFrom<object>(szzzzzzzzzzzzzzzzzzzzh_);
                CqlConcept szzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, szzzzzzzzzzzzzzzzzzzzi_ as CodeableConcept);
                CqlValueSet szzzzzzzzzzzzzzzzzzzzk_ = this.Patient_Declined(context);
                bool? szzzzzzzzzzzzzzzzzzzzl_ = context.Operators.ConceptInValueSet(szzzzzzzzzzzzzzzzzzzzj_, szzzzzzzzzzzzzzzzzzzzk_);
                bool? szzzzzzzzzzzzzzzzzzzzm_(Extension @this)
                {
                    string tzzzzzzzzzzzzzzzzzzzzg_ = @this?.Url;
                    FhirString tzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Convert<FhirString>(tzzzzzzzzzzzzzzzzzzzzg_);
                    string tzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToString(context, tzzzzzzzzzzzzzzzzzzzzh_);
                    bool? tzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Equal(tzzzzzzzzzzzzzzzzzzzzi_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-notDoneReason");

                    return tzzzzzzzzzzzzzzzzzzzzj_;
                };
                IEnumerable<Extension> szzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(NoBPScreen is DomainResource
                        ? (NoBPScreen as DomainResource).Extension
                        : default), szzzzzzzzzzzzzzzzzzzzm_);
                object szzzzzzzzzzzzzzzzzzzzo_(Extension @this)
                {
                    DataType tzzzzzzzzzzzzzzzzzzzzk_ = @this?.Value;

                    return tzzzzzzzzzzzzzzzzzzzzk_;
                };
                IEnumerable<object> szzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Select<Extension, object>(szzzzzzzzzzzzzzzzzzzzn_, szzzzzzzzzzzzzzzzzzzzo_);
                object szzzzzzzzzzzzzzzzzzzzq_ = context.Operators.SingletonFrom<object>(szzzzzzzzzzzzzzzzzzzzp_);
                CqlConcept szzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, szzzzzzzzzzzzzzzzzzzzq_ as CodeableConcept);
                CqlValueSet szzzzzzzzzzzzzzzzzzzzs_ = this.Medical_Reason(context);
                bool? szzzzzzzzzzzzzzzzzzzzt_ = context.Operators.ConceptInValueSet(szzzzzzzzzzzzzzzzzzzzr_, szzzzzzzzzzzzzzzzzzzzs_);
                bool? szzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Or(szzzzzzzzzzzzzzzzzzzzl_, szzzzzzzzzzzzzzzzzzzzt_);
                bool? szzzzzzzzzzzzzzzzzzzzv_ = context.Operators.And(szzzzzzzzzzzzzzzzzzzzd_, szzzzzzzzzzzzzzzzzzzzu_);
                Code<ObservationStatus> szzzzzzzzzzzzzzzzzzzzw_ = NoBPScreen?.StatusElement;
                ObservationStatus? szzzzzzzzzzzzzzzzzzzzx_ = szzzzzzzzzzzzzzzzzzzzw_?.Value;
                Code<ObservationStatus> szzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Convert<Code<ObservationStatus>>(szzzzzzzzzzzzzzzzzzzzx_);
                bool? szzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Equal(szzzzzzzzzzzzzzzzzzzzy_, "cancelled");
                bool? tzzzzzzzzzzzzzzzzzzzza_ = context.Operators.And(szzzzzzzzzzzzzzzzzzzzv_, szzzzzzzzzzzzzzzzzzzzz_);

                return tzzzzzzzzzzzzzzzzzzzza_;
            };
            IEnumerable<Observation> rzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Observation>(rzzzzzzzzzzzzzzzzzzzzt_, rzzzzzzzzzzzzzzzzzzzzu_);
            Encounter rzzzzzzzzzzzzzzzzzzzzw_(Observation NoBPScreen) =>
                QualifyingEncounter;
            IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Select<Observation, Encounter>(rzzzzzzzzzzzzzzzzzzzzv_, rzzzzzzzzzzzzzzzzzzzzw_);

            return rzzzzzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.SelectMany<Encounter, Encounter>(rzzzzzzzzzzzzzzzzzzzzk_, rzzzzzzzzzzzzzzzzzzzzl_);

        return rzzzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("NonPharmacological Intervention Not Ordered")]
    public IEnumerable<ServiceRequest> NonPharmacological_Intervention_Not_Ordered(CqlContext context)
    {
        CqlValueSet tzzzzzzzzzzzzzzzzzzzzl_ = this.Lifestyle_Recommendation(context);
        IEnumerable<ServiceRequest> tzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> tzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> tzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Union<ServiceRequest>(tzzzzzzzzzzzzzzzzzzzzm_, tzzzzzzzzzzzzzzzzzzzzo_);
        CqlValueSet tzzzzzzzzzzzzzzzzzzzzq_ = this.Weight_Reduction_Recommended(context);
        IEnumerable<ServiceRequest> tzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> tzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> tzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Union<ServiceRequest>(tzzzzzzzzzzzzzzzzzzzzr_, tzzzzzzzzzzzzzzzzzzzzt_);
        IEnumerable<ServiceRequest> tzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Union<ServiceRequest>(tzzzzzzzzzzzzzzzzzzzzp_, tzzzzzzzzzzzzzzzzzzzzu_);
        CqlValueSet tzzzzzzzzzzzzzzzzzzzzw_ = this.Dietary_Recommendations(context);
        IEnumerable<ServiceRequest> tzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> tzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> uzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Union<ServiceRequest>(tzzzzzzzzzzzzzzzzzzzzx_, tzzzzzzzzzzzzzzzzzzzzz_);
        IEnumerable<ServiceRequest> uzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Union<ServiceRequest>(tzzzzzzzzzzzzzzzzzzzzv_, uzzzzzzzzzzzzzzzzzzzza_);
        CqlValueSet uzzzzzzzzzzzzzzzzzzzzc_ = this.Recommendation_to_Increase_Physical_Activity(context);
        IEnumerable<ServiceRequest> uzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> uzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> uzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Union<ServiceRequest>(uzzzzzzzzzzzzzzzzzzzzd_, uzzzzzzzzzzzzzzzzzzzzf_);
        IEnumerable<ServiceRequest> uzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Union<ServiceRequest>(uzzzzzzzzzzzzzzzzzzzzb_, uzzzzzzzzzzzzzzzzzzzzg_);
        CqlValueSet uzzzzzzzzzzzzzzzzzzzzi_ = this.Referral_or_Counseling_for_Alcohol_Consumption(context);
        IEnumerable<ServiceRequest> uzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> uzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> uzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Union<ServiceRequest>(uzzzzzzzzzzzzzzzzzzzzj_, uzzzzzzzzzzzzzzzzzzzzl_);
        IEnumerable<ServiceRequest> uzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Union<ServiceRequest>(uzzzzzzzzzzzzzzzzzzzzh_, uzzzzzzzzzzzzzzzzzzzzm_);
        bool? uzzzzzzzzzzzzzzzzzzzzo_(ServiceRequest NonPharmIntervention)
        {
            bool? uzzzzzzzzzzzzzzzzzzzzq_(Extension @this)
            {
                string vzzzzzzzzzzzzzzzzzzzzd_ = @this?.Url;
                FhirString vzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Convert<FhirString>(vzzzzzzzzzzzzzzzzzzzzd_);
                string vzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToString(context, vzzzzzzzzzzzzzzzzzzzze_);
                bool? vzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Equal(vzzzzzzzzzzzzzzzzzzzzf_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerformReason");

                return vzzzzzzzzzzzzzzzzzzzzg_;
            };
            IEnumerable<Extension> uzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(NonPharmIntervention is DomainResource
                    ? (NonPharmIntervention as DomainResource).Extension
                    : default), uzzzzzzzzzzzzzzzzzzzzq_);
            object uzzzzzzzzzzzzzzzzzzzzs_(Extension @this)
            {
                DataType vzzzzzzzzzzzzzzzzzzzzh_ = @this?.Value;

                return vzzzzzzzzzzzzzzzzzzzzh_;
            };
            IEnumerable<object> uzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Select<Extension, object>(uzzzzzzzzzzzzzzzzzzzzr_, uzzzzzzzzzzzzzzzzzzzzs_);
            object uzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.SingletonFrom<object>(uzzzzzzzzzzzzzzzzzzzzt_);
            CqlConcept uzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, uzzzzzzzzzzzzzzzzzzzzu_ as CodeableConcept);
            CqlValueSet uzzzzzzzzzzzzzzzzzzzzw_ = this.Patient_Declined(context);
            bool? uzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.ConceptInValueSet(uzzzzzzzzzzzzzzzzzzzzv_, uzzzzzzzzzzzzzzzzzzzzw_);
            Code<RequestStatus> uzzzzzzzzzzzzzzzzzzzzy_ = NonPharmIntervention?.StatusElement;
            RequestStatus? uzzzzzzzzzzzzzzzzzzzzz_ = uzzzzzzzzzzzzzzzzzzzzy_?.Value;
            Code<RequestStatus> vzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Convert<Code<RequestStatus>>(uzzzzzzzzzzzzzzzzzzzzz_);
            bool? vzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Equal(vzzzzzzzzzzzzzzzzzzzza_, "completed");
            bool? vzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.And(uzzzzzzzzzzzzzzzzzzzzx_, vzzzzzzzzzzzzzzzzzzzzb_);

            return vzzzzzzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<ServiceRequest> uzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<ServiceRequest>(uzzzzzzzzzzzzzzzzzzzzn_, uzzzzzzzzzzzzzzzzzzzzo_);

        return uzzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Laboratory Test or ECG for Hypertension Not Ordered")]
    public IEnumerable<ServiceRequest> Laboratory_Test_or_ECG_for_Hypertension_Not_Ordered(CqlContext context)
    {
        CqlCode vzzzzzzzzzzzzzzzzzzzzi_ = this._12_lead_EKG_panel(context);
        IEnumerable<CqlCode> vzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.ToList<CqlCode>(vzzzzzzzzzzzzzzzzzzzzi_);
        IEnumerable<ServiceRequest> vzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, default, vzzzzzzzzzzzzzzzzzzzzj_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        CqlCode vzzzzzzzzzzzzzzzzzzzzl_ = this.EKG_study(context);
        IEnumerable<CqlCode> vzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.ToList<CqlCode>(vzzzzzzzzzzzzzzzzzzzzl_);
        IEnumerable<ServiceRequest> vzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, default, vzzzzzzzzzzzzzzzzzzzzm_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> vzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Union<ServiceRequest>(vzzzzzzzzzzzzzzzzzzzzk_, vzzzzzzzzzzzzzzzzzzzzn_);
        CqlValueSet vzzzzzzzzzzzzzzzzzzzzp_ = this.Laboratory_Tests_for_Hypertension(context);
        IEnumerable<ServiceRequest> vzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> vzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> vzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Union<ServiceRequest>(vzzzzzzzzzzzzzzzzzzzzq_, vzzzzzzzzzzzzzzzzzzzzs_);
        IEnumerable<ServiceRequest> vzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Union<ServiceRequest>(vzzzzzzzzzzzzzzzzzzzzo_, vzzzzzzzzzzzzzzzzzzzzt_);
        bool? vzzzzzzzzzzzzzzzzzzzzv_(ServiceRequest LabECGNotDone)
        {
            bool? vzzzzzzzzzzzzzzzzzzzzx_(Extension @this)
            {
                string wzzzzzzzzzzzzzzzzzzzzf_ = @this?.Url;
                FhirString wzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Convert<FhirString>(wzzzzzzzzzzzzzzzzzzzzf_);
                string wzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToString(context, wzzzzzzzzzzzzzzzzzzzzg_);
                bool? wzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Equal(wzzzzzzzzzzzzzzzzzzzzh_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerformReason");

                return wzzzzzzzzzzzzzzzzzzzzi_;
            };
            IEnumerable<Extension> vzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(LabECGNotDone is DomainResource
                    ? (LabECGNotDone as DomainResource).Extension
                    : default), vzzzzzzzzzzzzzzzzzzzzx_);
            object vzzzzzzzzzzzzzzzzzzzzz_(Extension @this)
            {
                DataType wzzzzzzzzzzzzzzzzzzzzj_ = @this?.Value;

                return wzzzzzzzzzzzzzzzzzzzzj_;
            };
            IEnumerable<object> wzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Select<Extension, object>(vzzzzzzzzzzzzzzzzzzzzy_, vzzzzzzzzzzzzzzzzzzzzz_);
            object wzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.SingletonFrom<object>(wzzzzzzzzzzzzzzzzzzzza_);
            CqlConcept wzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, wzzzzzzzzzzzzzzzzzzzzb_ as CodeableConcept);
            CqlValueSet wzzzzzzzzzzzzzzzzzzzzd_ = this.Patient_Declined(context);
            bool? wzzzzzzzzzzzzzzzzzzzze_ = context.Operators.ConceptInValueSet(wzzzzzzzzzzzzzzzzzzzzc_, wzzzzzzzzzzzzzzzzzzzzd_);

            return wzzzzzzzzzzzzzzzzzzzze_;
        };
        IEnumerable<ServiceRequest> vzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Where<ServiceRequest>(vzzzzzzzzzzzzzzzzzzzzu_, vzzzzzzzzzzzzzzzzzzzzv_);

        return vzzzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Second Hypertensive Reading SBP 130 to 139 OR DBP 80 to 89 Interventions Declined")]
    public IEnumerable<ServiceRequest> Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89_Interventions_Declined(CqlContext context)
    {
        CqlValueSet wzzzzzzzzzzzzzzzzzzzzk_ = this.Referral_to_Primary_Care_or_Alternate_Provider(context);
        IEnumerable<ServiceRequest> wzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> wzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> wzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Union<ServiceRequest>(wzzzzzzzzzzzzzzzzzzzzl_, wzzzzzzzzzzzzzzzzzzzzn_);
        CqlValueSet wzzzzzzzzzzzzzzzzzzzzp_ = this.Follow_Up_Within_6_Months(context);
        IEnumerable<ServiceRequest> wzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> wzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> wzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Union<ServiceRequest>(wzzzzzzzzzzzzzzzzzzzzq_, wzzzzzzzzzzzzzzzzzzzzs_);
        IEnumerable<ServiceRequest> wzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Union<ServiceRequest>(wzzzzzzzzzzzzzzzzzzzzo_, wzzzzzzzzzzzzzzzzzzzzt_);
        bool? wzzzzzzzzzzzzzzzzzzzzv_(ServiceRequest SecondHTNDeclinedReferralAndFollowUp)
        {
            bool? xzzzzzzzzzzzzzzzzzzzzb_(Extension @this)
            {
                string xzzzzzzzzzzzzzzzzzzzzo_ = @this?.Url;
                FhirString xzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Convert<FhirString>(xzzzzzzzzzzzzzzzzzzzzo_);
                string xzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToString(context, xzzzzzzzzzzzzzzzzzzzzp_);
                bool? xzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Equal(xzzzzzzzzzzzzzzzzzzzzq_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerformReason");

                return xzzzzzzzzzzzzzzzzzzzzr_;
            };
            IEnumerable<Extension> xzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(SecondHTNDeclinedReferralAndFollowUp is DomainResource
                    ? (SecondHTNDeclinedReferralAndFollowUp as DomainResource).Extension
                    : default), xzzzzzzzzzzzzzzzzzzzzb_);
            object xzzzzzzzzzzzzzzzzzzzzd_(Extension @this)
            {
                DataType xzzzzzzzzzzzzzzzzzzzzs_ = @this?.Value;

                return xzzzzzzzzzzzzzzzzzzzzs_;
            };
            IEnumerable<object> xzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Select<Extension, object>(xzzzzzzzzzzzzzzzzzzzzc_, xzzzzzzzzzzzzzzzzzzzzd_);
            object xzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.SingletonFrom<object>(xzzzzzzzzzzzzzzzzzzzze_);
            CqlConcept xzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, xzzzzzzzzzzzzzzzzzzzzf_ as CodeableConcept);
            CqlValueSet xzzzzzzzzzzzzzzzzzzzzh_ = this.Patient_Declined(context);
            bool? xzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.ConceptInValueSet(xzzzzzzzzzzzzzzzzzzzzg_, xzzzzzzzzzzzzzzzzzzzzh_);
            Code<RequestStatus> xzzzzzzzzzzzzzzzzzzzzj_ = SecondHTNDeclinedReferralAndFollowUp?.StatusElement;
            RequestStatus? xzzzzzzzzzzzzzzzzzzzzk_ = xzzzzzzzzzzzzzzzzzzzzj_?.Value;
            Code<RequestStatus> xzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Convert<Code<RequestStatus>>(xzzzzzzzzzzzzzzzzzzzzk_);
            bool? xzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Equal(xzzzzzzzzzzzzzzzzzzzzl_, "completed");
            bool? xzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.And(xzzzzzzzzzzzzzzzzzzzzi_, xzzzzzzzzzzzzzzzzzzzzm_);

            return xzzzzzzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<ServiceRequest> wzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Where<ServiceRequest>(wzzzzzzzzzzzzzzzzzzzzu_, wzzzzzzzzzzzzzzzzzzzzv_);
        IEnumerable<ServiceRequest> wzzzzzzzzzzzzzzzzzzzzx_ = this.Laboratory_Test_or_ECG_for_Hypertension_Not_Ordered(context);
        IEnumerable<ServiceRequest> wzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Union<ServiceRequest>(wzzzzzzzzzzzzzzzzzzzzw_, wzzzzzzzzzzzzzzzzzzzzx_);
        IEnumerable<ServiceRequest> wzzzzzzzzzzzzzzzzzzzzz_ = this.NonPharmacological_Intervention_Not_Ordered(context);
        IEnumerable<ServiceRequest> xzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Union<ServiceRequest>(wzzzzzzzzzzzzzzzzzzzzy_, wzzzzzzzzzzzzzzzzzzzzz_);

        return xzzzzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Second Hypertensive Reading SBP Greater than or Equal to 140 OR DBP Greater than or Equal to 90 Interventions Declined")]
    public IEnumerable<object> Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90_Interventions_Declined(CqlContext context)
    {
        CqlValueSet xzzzzzzzzzzzzzzzzzzzzt_ = this.Referral_to_Primary_Care_or_Alternate_Provider(context);
        IEnumerable<ServiceRequest> xzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> xzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> xzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Union<ServiceRequest>(xzzzzzzzzzzzzzzzzzzzzu_, xzzzzzzzzzzzzzzzzzzzzw_);
        CqlValueSet xzzzzzzzzzzzzzzzzzzzzy_ = this.Follow_Up_Within_4_Weeks(context);
        IEnumerable<ServiceRequest> xzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> yzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> yzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Union<ServiceRequest>(xzzzzzzzzzzzzzzzzzzzzz_, yzzzzzzzzzzzzzzzzzzzzb_);
        IEnumerable<ServiceRequest> yzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Union<ServiceRequest>(xzzzzzzzzzzzzzzzzzzzzx_, yzzzzzzzzzzzzzzzzzzzzc_);
        bool? yzzzzzzzzzzzzzzzzzzzze_(ServiceRequest SecondHTN140Over90ReferralFollowUpNotDone)
        {
            bool? yzzzzzzzzzzzzzzzzzzzzs_(Extension @this)
            {
                string zzzzzzzzzzzzzzzzzzzzzf_ = @this?.Url;
                FhirString zzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Convert<FhirString>(zzzzzzzzzzzzzzzzzzzzzf_);
                string zzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToString(context, zzzzzzzzzzzzzzzzzzzzzg_);
                bool? zzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Equal(zzzzzzzzzzzzzzzzzzzzzh_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerformReason");

                return zzzzzzzzzzzzzzzzzzzzzi_;
            };
            IEnumerable<Extension> yzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(SecondHTN140Over90ReferralFollowUpNotDone is DomainResource
                    ? (SecondHTN140Over90ReferralFollowUpNotDone as DomainResource).Extension
                    : default), yzzzzzzzzzzzzzzzzzzzzs_);
            object yzzzzzzzzzzzzzzzzzzzzu_(Extension @this)
            {
                DataType zzzzzzzzzzzzzzzzzzzzzj_ = @this?.Value;

                return zzzzzzzzzzzzzzzzzzzzzj_;
            };
            IEnumerable<object> yzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Select<Extension, object>(yzzzzzzzzzzzzzzzzzzzzt_, yzzzzzzzzzzzzzzzzzzzzu_);
            object yzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.SingletonFrom<object>(yzzzzzzzzzzzzzzzzzzzzv_);
            CqlConcept yzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, yzzzzzzzzzzzzzzzzzzzzw_ as CodeableConcept);
            CqlValueSet yzzzzzzzzzzzzzzzzzzzzy_ = this.Patient_Declined(context);
            bool? yzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.ConceptInValueSet(yzzzzzzzzzzzzzzzzzzzzx_, yzzzzzzzzzzzzzzzzzzzzy_);
            Code<RequestStatus> zzzzzzzzzzzzzzzzzzzzza_ = SecondHTN140Over90ReferralFollowUpNotDone?.StatusElement;
            RequestStatus? zzzzzzzzzzzzzzzzzzzzzb_ = zzzzzzzzzzzzzzzzzzzzza_?.Value;
            Code<RequestStatus> zzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Convert<Code<RequestStatus>>(zzzzzzzzzzzzzzzzzzzzzb_);
            bool? zzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Equal(zzzzzzzzzzzzzzzzzzzzzc_, "completed");
            bool? zzzzzzzzzzzzzzzzzzzzze_ = context.Operators.And(yzzzzzzzzzzzzzzzzzzzzz_, zzzzzzzzzzzzzzzzzzzzzd_);

            return zzzzzzzzzzzzzzzzzzzzze_;
        };
        IEnumerable<ServiceRequest> yzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Where<ServiceRequest>(yzzzzzzzzzzzzzzzzzzzzd_, yzzzzzzzzzzzzzzzzzzzze_);
        CqlValueSet yzzzzzzzzzzzzzzzzzzzzg_ = this.Pharmacologic_Therapy_for_Hypertension(context);
        IEnumerable<MedicationRequest> yzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-mednotrequested"));
        IEnumerable<MedicationRequest> yzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-mednotrequested"));
        IEnumerable<MedicationRequest> yzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Union<MedicationRequest>(yzzzzzzzzzzzzzzzzzzzzh_, yzzzzzzzzzzzzzzzzzzzzj_);
        bool? yzzzzzzzzzzzzzzzzzzzzl_(MedicationRequest MedicationRequestNotOrdered)
        {
            Code<MedicationRequest.MedicationrequestStatus> zzzzzzzzzzzzzzzzzzzzzk_ = MedicationRequestNotOrdered?.StatusElement;
            MedicationRequest.MedicationrequestStatus? zzzzzzzzzzzzzzzzzzzzzl_ = zzzzzzzzzzzzzzzzzzzzzk_?.Value;
            string zzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Convert<string>(zzzzzzzzzzzzzzzzzzzzzl_);
            bool? zzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Equal(zzzzzzzzzzzzzzzzzzzzzm_, "completed");

            return zzzzzzzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<MedicationRequest> yzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Where<MedicationRequest>(yzzzzzzzzzzzzzzzzzzzzk_, yzzzzzzzzzzzzzzzzzzzzl_);
        IEnumerable<object> yzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Union<object>(yzzzzzzzzzzzzzzzzzzzzf_ as IEnumerable<object>, yzzzzzzzzzzzzzzzzzzzzm_ as IEnumerable<object>);
        IEnumerable<ServiceRequest> yzzzzzzzzzzzzzzzzzzzzo_ = this.Laboratory_Test_or_ECG_for_Hypertension_Not_Ordered(context);
        IEnumerable<object> yzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Union<object>(yzzzzzzzzzzzzzzzzzzzzn_ as IEnumerable<object>, yzzzzzzzzzzzzzzzzzzzzo_ as IEnumerable<object>);
        IEnumerable<ServiceRequest> yzzzzzzzzzzzzzzzzzzzzq_ = this.NonPharmacological_Intervention_Not_Ordered(context);
        IEnumerable<object> yzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Union<object>(yzzzzzzzzzzzzzzzzzzzzp_ as IEnumerable<object>, yzzzzzzzzzzzzzzzzzzzzq_ as IEnumerable<object>);

        return yzzzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Encounter with Order for Hypertension Follow Up Declined by Patient")]
    public IEnumerable<Encounter> Encounter_with_Order_for_Hypertension_Follow_Up_Declined_by_Patient(CqlContext context)
    {
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzo_ = this.Encounter_with_Elevated_Blood_Pressure_Reading_SBP_120_to_129_AND_DBP_less_than_80(context);
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzp_(Encounter ElevatedBPEncounter)
        {
            CqlValueSet azzzzzzzzzzzzzzzzzzzzzl_ = this.Referral_to_Primary_Care_or_Alternate_Provider(context);
            IEnumerable<ServiceRequest> azzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
            IEnumerable<ServiceRequest> azzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
            IEnumerable<ServiceRequest> azzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Union<ServiceRequest>(azzzzzzzzzzzzzzzzzzzzzm_, azzzzzzzzzzzzzzzzzzzzzo_);
            CqlValueSet azzzzzzzzzzzzzzzzzzzzzq_ = this.Follow_Up_Within_6_Months(context);
            IEnumerable<ServiceRequest> azzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
            IEnumerable<ServiceRequest> azzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
            IEnumerable<ServiceRequest> azzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Union<ServiceRequest>(azzzzzzzzzzzzzzzzzzzzzr_, azzzzzzzzzzzzzzzzzzzzzt_);
            IEnumerable<ServiceRequest> azzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Union<ServiceRequest>(azzzzzzzzzzzzzzzzzzzzzp_, azzzzzzzzzzzzzzzzzzzzzu_);
            bool? azzzzzzzzzzzzzzzzzzzzzw_(ServiceRequest ElevatedBPDeclinedInterventions)
            {
                bool? bzzzzzzzzzzzzzzzzzzzzza_(Extension @this)
                {
                    string bzzzzzzzzzzzzzzzzzzzzzt_ = @this?.Url;
                    FhirString bzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Convert<FhirString>(bzzzzzzzzzzzzzzzzzzzzzt_);
                    string bzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToString(context, bzzzzzzzzzzzzzzzzzzzzzu_);
                    bool? bzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Equal(bzzzzzzzzzzzzzzzzzzzzzv_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerformReason");

                    return bzzzzzzzzzzzzzzzzzzzzzw_;
                };
                IEnumerable<Extension> bzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(ElevatedBPDeclinedInterventions is DomainResource
                        ? (ElevatedBPDeclinedInterventions as DomainResource).Extension
                        : default), bzzzzzzzzzzzzzzzzzzzzza_);
                object bzzzzzzzzzzzzzzzzzzzzzc_(Extension @this)
                {
                    DataType bzzzzzzzzzzzzzzzzzzzzzx_ = @this?.Value;

                    return bzzzzzzzzzzzzzzzzzzzzzx_;
                };
                IEnumerable<object> bzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Select<Extension, object>(bzzzzzzzzzzzzzzzzzzzzzb_, bzzzzzzzzzzzzzzzzzzzzzc_);
                object bzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.SingletonFrom<object>(bzzzzzzzzzzzzzzzzzzzzzd_);
                CqlConcept bzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bzzzzzzzzzzzzzzzzzzzzze_ as CodeableConcept);
                CqlValueSet bzzzzzzzzzzzzzzzzzzzzzg_ = this.Patient_Declined(context);
                bool? bzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.ConceptInValueSet(bzzzzzzzzzzzzzzzzzzzzzf_, bzzzzzzzzzzzzzzzzzzzzzg_);
                FhirDateTime bzzzzzzzzzzzzzzzzzzzzzi_ = ElevatedBPDeclinedInterventions?.AuthoredOnElement;
                CqlDateTime bzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Convert<CqlDateTime>(bzzzzzzzzzzzzzzzzzzzzzi_);
                Period bzzzzzzzzzzzzzzzzzzzzzk_ = ElevatedBPEncounter?.Period;
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzzzzzzzzzzzzzzzk_);
                bool? bzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.In<CqlDateTime>(bzzzzzzzzzzzzzzzzzzzzzj_, bzzzzzzzzzzzzzzzzzzzzzl_, "day");
                bool? bzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.And(bzzzzzzzzzzzzzzzzzzzzzh_, bzzzzzzzzzzzzzzzzzzzzzm_);
                Code<RequestStatus> bzzzzzzzzzzzzzzzzzzzzzo_ = ElevatedBPDeclinedInterventions?.StatusElement;
                RequestStatus? bzzzzzzzzzzzzzzzzzzzzzp_ = bzzzzzzzzzzzzzzzzzzzzzo_?.Value;
                Code<RequestStatus> bzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Convert<Code<RequestStatus>>(bzzzzzzzzzzzzzzzzzzzzzp_);
                bool? bzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Equal(bzzzzzzzzzzzzzzzzzzzzzq_, "completed");
                bool? bzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.And(bzzzzzzzzzzzzzzzzzzzzzn_, bzzzzzzzzzzzzzzzzzzzzzr_);

                return bzzzzzzzzzzzzzzzzzzzzzs_;
            };
            IEnumerable<ServiceRequest> azzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Where<ServiceRequest>(azzzzzzzzzzzzzzzzzzzzzv_, azzzzzzzzzzzzzzzzzzzzzw_);
            Encounter azzzzzzzzzzzzzzzzzzzzzy_(ServiceRequest ElevatedBPDeclinedInterventions) =>
                ElevatedBPEncounter;
            IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Select<ServiceRequest, Encounter>(azzzzzzzzzzzzzzzzzzzzzx_, azzzzzzzzzzzzzzzzzzzzzy_);

            return azzzzzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.SelectMany<Encounter, Encounter>(zzzzzzzzzzzzzzzzzzzzzo_, zzzzzzzzzzzzzzzzzzzzzp_);
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzs_(Encounter ElevatedBPEncounter)
        {
            IEnumerable<ServiceRequest> bzzzzzzzzzzzzzzzzzzzzzy_ = this.NonPharmacological_Intervention_Not_Ordered(context);
            bool? bzzzzzzzzzzzzzzzzzzzzzz_(ServiceRequest NotOrdered)
            {
                FhirDateTime czzzzzzzzzzzzzzzzzzzzzd_ = NotOrdered?.AuthoredOnElement;
                CqlDateTime czzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Convert<CqlDateTime>(czzzzzzzzzzzzzzzzzzzzzd_);
                Period czzzzzzzzzzzzzzzzzzzzzf_ = ElevatedBPEncounter?.Period;
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzzzzzzzzzzzzzzzzzf_);
                bool? czzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.In<CqlDateTime>(czzzzzzzzzzzzzzzzzzzzze_, czzzzzzzzzzzzzzzzzzzzzg_, "day");

                return czzzzzzzzzzzzzzzzzzzzzh_;
            };
            IEnumerable<ServiceRequest> czzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Where<ServiceRequest>(bzzzzzzzzzzzzzzzzzzzzzy_, bzzzzzzzzzzzzzzzzzzzzzz_);
            Encounter czzzzzzzzzzzzzzzzzzzzzb_(ServiceRequest NotOrdered) =>
                ElevatedBPEncounter;
            IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Select<ServiceRequest, Encounter>(czzzzzzzzzzzzzzzzzzzzza_, czzzzzzzzzzzzzzzzzzzzzb_);

            return czzzzzzzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.SelectMany<Encounter, Encounter>(zzzzzzzzzzzzzzzzzzzzzo_, zzzzzzzzzzzzzzzzzzzzzs_);
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Union<Encounter>(zzzzzzzzzzzzzzzzzzzzzq_, zzzzzzzzzzzzzzzzzzzzzt_);
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzv_ = this.Encounter_with_First_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_130_OR_DBP_Greater_than_or_Equal_to_80(context);
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzw_(Encounter FirstHTNEncounter)
        {
            CqlValueSet czzzzzzzzzzzzzzzzzzzzzi_ = this.Follow_Up_Within_4_Weeks(context);
            IEnumerable<ServiceRequest> czzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
            IEnumerable<ServiceRequest> czzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
            IEnumerable<ServiceRequest> czzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Union<ServiceRequest>(czzzzzzzzzzzzzzzzzzzzzj_, czzzzzzzzzzzzzzzzzzzzzl_);
            CqlValueSet czzzzzzzzzzzzzzzzzzzzzn_ = this.Referral_to_Primary_Care_or_Alternate_Provider(context);
            IEnumerable<ServiceRequest> czzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
            IEnumerable<ServiceRequest> czzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
            IEnumerable<ServiceRequest> czzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Union<ServiceRequest>(czzzzzzzzzzzzzzzzzzzzzo_, czzzzzzzzzzzzzzzzzzzzzq_);
            IEnumerable<ServiceRequest> czzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Union<ServiceRequest>(czzzzzzzzzzzzzzzzzzzzzm_, czzzzzzzzzzzzzzzzzzzzzr_);
            bool? czzzzzzzzzzzzzzzzzzzzzt_(ServiceRequest FirstHTNDeclinedInterventions)
            {
                bool? czzzzzzzzzzzzzzzzzzzzzx_(Extension @this)
                {
                    string dzzzzzzzzzzzzzzzzzzzzzq_ = @this?.Url;
                    FhirString dzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Convert<FhirString>(dzzzzzzzzzzzzzzzzzzzzzq_);
                    string dzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToString(context, dzzzzzzzzzzzzzzzzzzzzzr_);
                    bool? dzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Equal(dzzzzzzzzzzzzzzzzzzzzzs_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerformReason");

                    return dzzzzzzzzzzzzzzzzzzzzzt_;
                };
                IEnumerable<Extension> czzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(FirstHTNDeclinedInterventions is DomainResource
                        ? (FirstHTNDeclinedInterventions as DomainResource).Extension
                        : default), czzzzzzzzzzzzzzzzzzzzzx_);
                object czzzzzzzzzzzzzzzzzzzzzz_(Extension @this)
                {
                    DataType dzzzzzzzzzzzzzzzzzzzzzu_ = @this?.Value;

                    return dzzzzzzzzzzzzzzzzzzzzzu_;
                };
                IEnumerable<object> dzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Select<Extension, object>(czzzzzzzzzzzzzzzzzzzzzy_, czzzzzzzzzzzzzzzzzzzzzz_);
                object dzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.SingletonFrom<object>(dzzzzzzzzzzzzzzzzzzzzza_);
                CqlConcept dzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, dzzzzzzzzzzzzzzzzzzzzzb_ as CodeableConcept);
                CqlValueSet dzzzzzzzzzzzzzzzzzzzzzd_ = this.Patient_Declined(context);
                bool? dzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.ConceptInValueSet(dzzzzzzzzzzzzzzzzzzzzzc_, dzzzzzzzzzzzzzzzzzzzzzd_);
                FhirDateTime dzzzzzzzzzzzzzzzzzzzzzf_ = FirstHTNDeclinedInterventions?.AuthoredOnElement;
                CqlDateTime dzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Convert<CqlDateTime>(dzzzzzzzzzzzzzzzzzzzzzf_);
                Period dzzzzzzzzzzzzzzzzzzzzzh_ = FirstHTNEncounter?.Period;
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzzzzzzzzzzzzzzzzzzh_);
                bool? dzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.In<CqlDateTime>(dzzzzzzzzzzzzzzzzzzzzzg_, dzzzzzzzzzzzzzzzzzzzzzi_, "day");
                bool? dzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.And(dzzzzzzzzzzzzzzzzzzzzze_, dzzzzzzzzzzzzzzzzzzzzzj_);
                Code<RequestStatus> dzzzzzzzzzzzzzzzzzzzzzl_ = FirstHTNDeclinedInterventions?.StatusElement;
                RequestStatus? dzzzzzzzzzzzzzzzzzzzzzm_ = dzzzzzzzzzzzzzzzzzzzzzl_?.Value;
                Code<RequestStatus> dzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Convert<Code<RequestStatus>>(dzzzzzzzzzzzzzzzzzzzzzm_);
                bool? dzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Equal(dzzzzzzzzzzzzzzzzzzzzzn_, "completed");
                bool? dzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.And(dzzzzzzzzzzzzzzzzzzzzzk_, dzzzzzzzzzzzzzzzzzzzzzo_);

                return dzzzzzzzzzzzzzzzzzzzzzp_;
            };
            IEnumerable<ServiceRequest> czzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Where<ServiceRequest>(czzzzzzzzzzzzzzzzzzzzzs_, czzzzzzzzzzzzzzzzzzzzzt_);
            Encounter czzzzzzzzzzzzzzzzzzzzzv_(ServiceRequest FirstHTNDeclinedInterventions) =>
                FirstHTNEncounter;
            IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Select<ServiceRequest, Encounter>(czzzzzzzzzzzzzzzzzzzzzu_, czzzzzzzzzzzzzzzzzzzzzv_);

            return czzzzzzzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.SelectMany<Encounter, Encounter>(zzzzzzzzzzzzzzzzzzzzzv_, zzzzzzzzzzzzzzzzzzzzzw_);
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzz_(Encounter FirstHTNEncounter)
        {
            IEnumerable<ServiceRequest> dzzzzzzzzzzzzzzzzzzzzzv_ = this.NonPharmacological_Intervention_Not_Ordered(context);
            bool? dzzzzzzzzzzzzzzzzzzzzzw_(ServiceRequest NoNonPharm)
            {
                FhirDateTime ezzzzzzzzzzzzzzzzzzzzza_ = NoNonPharm?.AuthoredOnElement;
                CqlDateTime ezzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Convert<CqlDateTime>(ezzzzzzzzzzzzzzzzzzzzza_);
                Period ezzzzzzzzzzzzzzzzzzzzzc_ = FirstHTNEncounter?.Period;
                CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzzzzzzzzzzzzzzzzzc_);
                bool? ezzzzzzzzzzzzzzzzzzzzze_ = context.Operators.In<CqlDateTime>(ezzzzzzzzzzzzzzzzzzzzzb_, ezzzzzzzzzzzzzzzzzzzzzd_, "day");

                return ezzzzzzzzzzzzzzzzzzzzze_;
            };
            IEnumerable<ServiceRequest> dzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Where<ServiceRequest>(dzzzzzzzzzzzzzzzzzzzzzv_, dzzzzzzzzzzzzzzzzzzzzzw_);
            Encounter dzzzzzzzzzzzzzzzzzzzzzy_(ServiceRequest NoNonPharm) =>
                FirstHTNEncounter;
            IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Select<ServiceRequest, Encounter>(dzzzzzzzzzzzzzzzzzzzzzx_, dzzzzzzzzzzzzzzzzzzzzzy_);

            return dzzzzzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzza_ = context.Operators.SelectMany<Encounter, Encounter>(zzzzzzzzzzzzzzzzzzzzzv_, zzzzzzzzzzzzzzzzzzzzzz_);
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Union<Encounter>(zzzzzzzzzzzzzzzzzzzzzx_, azzzzzzzzzzzzzzzzzzzzza_);
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Union<Encounter>(zzzzzzzzzzzzzzzzzzzzzu_, azzzzzzzzzzzzzzzzzzzzzb_);
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzd_ = this.Encounter_with_Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89(context);
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzze_(Encounter SecondHTNEncounter)
        {
            IEnumerable<ServiceRequest> ezzzzzzzzzzzzzzzzzzzzzf_ = this.Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89_Interventions_Declined(context);
            bool? ezzzzzzzzzzzzzzzzzzzzzg_(ServiceRequest SecondHTNDeclinedInterventions)
            {
                FhirDateTime ezzzzzzzzzzzzzzzzzzzzzk_ = SecondHTNDeclinedInterventions?.AuthoredOnElement;
                CqlDateTime ezzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Convert<CqlDateTime>(ezzzzzzzzzzzzzzzzzzzzzk_);
                Period ezzzzzzzzzzzzzzzzzzzzzm_ = SecondHTNEncounter?.Period;
                CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzzzzzzzzzzzzzzzzzm_);
                bool? ezzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.In<CqlDateTime>(ezzzzzzzzzzzzzzzzzzzzzl_, ezzzzzzzzzzzzzzzzzzzzzn_, "day");

                return ezzzzzzzzzzzzzzzzzzzzzo_;
            };
            IEnumerable<ServiceRequest> ezzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Where<ServiceRequest>(ezzzzzzzzzzzzzzzzzzzzzf_, ezzzzzzzzzzzzzzzzzzzzzg_);
            Encounter ezzzzzzzzzzzzzzzzzzzzzi_(ServiceRequest SecondHTNDeclinedInterventions) =>
                SecondHTNEncounter;
            IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Select<ServiceRequest, Encounter>(ezzzzzzzzzzzzzzzzzzzzzh_, ezzzzzzzzzzzzzzzzzzzzzi_);

            return ezzzzzzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.SelectMany<Encounter, Encounter>(azzzzzzzzzzzzzzzzzzzzzd_, azzzzzzzzzzzzzzzzzzzzze_);
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzg_ = this.Encounter_with_Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90(context);
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzh_(Encounter SecondHTN140Over90Encounter)
        {
            IEnumerable<object> ezzzzzzzzzzzzzzzzzzzzzp_ = this.Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90_Interventions_Declined(context);
            bool? ezzzzzzzzzzzzzzzzzzzzzq_(object SecondHTN140Over90DeclinedInterventions)
            {
                object ezzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.LateBoundProperty<object>(SecondHTN140Over90DeclinedInterventions, "authoredOn");
                CqlDateTime ezzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.LateBoundProperty<CqlDateTime>(ezzzzzzzzzzzzzzzzzzzzzu_, "value");
                Period ezzzzzzzzzzzzzzzzzzzzzw_ = SecondHTN140Over90Encounter?.Period;
                CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzzzzzzzzzzzzzzzzzw_);
                bool? ezzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.In<CqlDateTime>(ezzzzzzzzzzzzzzzzzzzzzv_, ezzzzzzzzzzzzzzzzzzzzzx_, "day");

                return ezzzzzzzzzzzzzzzzzzzzzy_;
            };
            IEnumerable<object> ezzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Where<object>(ezzzzzzzzzzzzzzzzzzzzzp_, ezzzzzzzzzzzzzzzzzzzzzq_);
            Encounter ezzzzzzzzzzzzzzzzzzzzzs_(object SecondHTN140Over90DeclinedInterventions) =>
                SecondHTN140Over90Encounter;
            IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Select<object, Encounter>(ezzzzzzzzzzzzzzzzzzzzzr_, ezzzzzzzzzzzzzzzzzzzzzs_);

            return ezzzzzzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.SelectMany<Encounter, Encounter>(azzzzzzzzzzzzzzzzzzzzzg_, azzzzzzzzzzzzzzzzzzzzzh_);
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Union<Encounter>(azzzzzzzzzzzzzzzzzzzzzf_, azzzzzzzzzzzzzzzzzzzzzi_);
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Union<Encounter>(azzzzzzzzzzzzzzzzzzzzzc_, azzzzzzzzzzzzzzzzzzzzzj_);

        return azzzzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Denominator Exceptions")]
    public IEnumerable<Encounter> Denominator_Exceptions(CqlContext context)
    {
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzz_ = this.Encounter_with_Medical_Reason_for_Not_Obtaining_or_Patient_Declined_Blood_Pressure_Measurement(context);
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzza_ = this.Encounter_with_Order_for_Hypertension_Follow_Up_Declined_by_Patient(context);
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Union<Encounter>(ezzzzzzzzzzzzzzzzzzzzzz_, fzzzzzzzzzzzzzzzzzzzzza_);

        return fzzzzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? fzzzzzzzzzzzzzzzzzzzzzc_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return fzzzzzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> fzzzzzzzzzzzzzzzzzzzzzd_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return fzzzzzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? fzzzzzzzzzzzzzzzzzzzzze_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return fzzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode fzzzzzzzzzzzzzzzzzzzzzf_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return fzzzzzzzzzzzzzzzzzzzzzf_;
    }


    #endregion Expressions

}
