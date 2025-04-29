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
        CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Interval(rzzzzzzzzzzzzzzzzzzzzzzzzzzs_, rzzzzzzzzzzzzzzzzzzzzzzzzzzt_, true, true);
        object rzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.ResolveParameter("PCSBPScreeningFollowUpFHIR-0.2.000", "Measurement Period", rzzzzzzzzzzzzzzzzzzzzzzzzzzu_);

        return (CqlInterval<CqlDateTime>)rzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> rzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient rzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.SingletonFrom<Patient>(rzzzzzzzzzzzzzzzzzzzzzzzzzzw_);

        return rzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Qualifying Encounter during Measurement Period")]
    public IEnumerable<Encounter> Qualifying_Encounter_during_Measurement_Period(CqlContext context)
    {
        CqlValueSet rzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Encounter_to_Screen_for_Blood_Pressure(context);
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzza_(Encounter ValidEncounter)
        {
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Measurement_Period(context);
            Period szzzzzzzzzzzzzzzzzzzzzzzzzzd_ = ValidEncounter?.Period;
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            bool? szzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(szzzzzzzzzzzzzzzzzzzzzzzzzzc_, szzzzzzzzzzzzzzzzzzzzzzzzzze_, "day");
            Code<Encounter.EncounterStatus> szzzzzzzzzzzzzzzzzzzzzzzzzzg_ = ValidEncounter?.StatusElement;
            Encounter.EncounterStatus? szzzzzzzzzzzzzzzzzzzzzzzzzzh_ = szzzzzzzzzzzzzzzzzzzzzzzzzzg_?.Value;
            Code<Encounter.EncounterStatus> szzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(szzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            bool? szzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Equivalent(szzzzzzzzzzzzzzzzzzzzzzzzzzi_, "finished");
            bool? szzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.And(szzzzzzzzzzzzzzzzzzzzzzzzzzf_, szzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            Coding szzzzzzzzzzzzzzzzzzzzzzzzzzl_ = ValidEncounter?.Class;
            CqlCode szzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToCode(context, szzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            CqlCode szzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.@virtual(context);
            bool? szzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Equivalent(szzzzzzzzzzzzzzzzzzzzzzzzzzm_, szzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            bool? szzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Not(szzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            bool? szzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.And(szzzzzzzzzzzzzzzzzzzzzzzzzzk_, szzzzzzzzzzzzzzzzzzzzzzzzzzp_);

            return szzzzzzzzzzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Where<Encounter>(rzzzzzzzzzzzzzzzzzzzzzzzzzzz_, szzzzzzzzzzzzzzzzzzzzzzzzzza_);

        return szzzzzzzzzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Qualifying_Encounter_during_Measurement_Period(context);
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzs_(Encounter QualifyingEncounter)
        {
            Patient szzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Patient(context);
            Date szzzzzzzzzzzzzzzzzzzzzzzzzzv_ = szzzzzzzzzzzzzzzzzzzzzzzzzzu_?.BirthDateElement;
            string szzzzzzzzzzzzzzzzzzzzzzzzzzw_ = szzzzzzzzzzzzzzzzzzzzzzzzzzv_?.Value;
            CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.ConvertStringToDateTime(szzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Measurement_Period(context);
            CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Start(szzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            int? tzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.CalculateAgeAt(szzzzzzzzzzzzzzzzzzzzzzzzzzx_, szzzzzzzzzzzzzzzzzzzzzzzzzzz_, "year");
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.GreaterOrEqual(tzzzzzzzzzzzzzzzzzzzzzzzzzza_, 18);

            return tzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
        };
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Where<Encounter>(szzzzzzzzzzzzzzzzzzzzzzzzzzr_, szzzzzzzzzzzzzzzzzzzzzzzzzzs_);

        return szzzzzzzzzzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context)
    {
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Initial_Population(context);

        return tzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public IEnumerable<Encounter> Denominator_Exclusions(CqlContext context)
    {
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Qualifying_Encounter_during_Measurement_Period(context);
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzzzzzze_(Encounter QualifyingEncounter)
        {
            CqlValueSet tzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Diagnosis_of_Hypertension(context);
            IEnumerable<Condition> tzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzi_(Condition Hypertension)
            {
                bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.isProblemListItem(context, Hypertension);
                bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.isHealthConcern(context, Hypertension);
                bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Or(tzzzzzzzzzzzzzzzzzzzzzzzzzzm_, tzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzzzzzzp_()
                {
                    bool tzzzzzzzzzzzzzzzzzzzzzzzzzzu_()
                    {
                        CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, Hypertension);
                        CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Start(tzzzzzzzzzzzzzzzzzzzzzzzzzzv_);

                        return tzzzzzzzzzzzzzzzzzzzzzzzzzzw_ is null;
                    };
                    if (tzzzzzzzzzzzzzzzzzzzzzzzzzzu_())
                    {
                        return default;
                    }
                    else
                    {
                        CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, Hypertension);
                        CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Start(tzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                        CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Start(tzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                        CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Interval(tzzzzzzzzzzzzzzzzzzzzzzzzzzy_, uzzzzzzzzzzzzzzzzzzzzzzzzzza_, true, true);

                        return uzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
                    }
                };
                Period tzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.SameOrBefore(tzzzzzzzzzzzzzzzzzzzzzzzzzzp_(), tzzzzzzzzzzzzzzzzzzzzzzzzzzr_, "day");
                bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.And(tzzzzzzzzzzzzzzzzzzzzzzzzzzo_, tzzzzzzzzzzzzzzzzzzzzzzzzzzs_);

                return tzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
            };
            IEnumerable<Condition> tzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Where<Condition>(tzzzzzzzzzzzzzzzzzzzzzzzzzzh_, tzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            Encounter tzzzzzzzzzzzzzzzzzzzzzzzzzzk_(Condition Hypertension) =>
                QualifyingEncounter;
            IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Select<Condition, Encounter>(tzzzzzzzzzzzzzzzzzzzzzzzzzzj_, tzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

            return tzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.SelectMany<Encounter, Encounter>(tzzzzzzzzzzzzzzzzzzzzzzzzzzd_, tzzzzzzzzzzzzzzzzzzzzzzzzzze_);

        return tzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Encounter with Normal Blood Pressure Reading")]
    public IEnumerable<Encounter> Encounter_with_Normal_Blood_Pressure_Reading(CqlContext context)
    {
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Qualifying_Encounter_during_Measurement_Period(context);
        bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzd_(Encounter QualifyingEncounter)
        {
            IEnumerable<Observation> uzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/bp"));
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzg_(Observation BloodPressure)
            {
                DataType vzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = BloodPressure?.Effective;
                object vzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.toInterval(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.End(vzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                Period vzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.In<CqlDateTime>(vzzzzzzzzzzzzzzzzzzzzzzzzzzp_, vzzzzzzzzzzzzzzzzzzzzzzzzzzr_, default);
                Code<ObservationStatus> vzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = BloodPressure?.StatusElement;
                ObservationStatus? vzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = vzzzzzzzzzzzzzzzzzzzzzzzzzzt_?.Value;
                string vzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Convert<string>(vzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                string[] vzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.In<string>(vzzzzzzzzzzzzzzzzzzzzzzzzzzv_, vzzzzzzzzzzzzzzzzzzzzzzzzzzw_ as IEnumerable<string>);
                bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.And(vzzzzzzzzzzzzzzzzzzzzzzzzzzs_, vzzzzzzzzzzzzzzzzzzzzzzzzzzx_);

                return vzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
            };
            IEnumerable<Observation> uzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Where<Observation>(uzzzzzzzzzzzzzzzzzzzzzzzzzzf_, uzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            object uzzzzzzzzzzzzzzzzzzzzzzzzzzi_(Observation @this)
            {
                DataType vzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = @this?.Effective;
                object wzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.toInterval(context, wzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Start(wzzzzzzzzzzzzzzzzzzzzzzzzzzb_);

                return wzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
            };
            IEnumerable<Observation> uzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.SortBy<Observation>(uzzzzzzzzzzzzzzzzzzzzzzzzzzh_, uzzzzzzzzzzzzzzzzzzzzzzzzzzi_, System.ComponentModel.ListSortDirection.Ascending);
            Observation uzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Last<Observation>(uzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            List<Observation.ComponentComponent> uzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = uzzzzzzzzzzzzzzzzzzzzzzzzzzk_?.Component;
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzm_(Observation.ComponentComponent @this)
            {
                CodeableConcept wzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = @this?.Code;
                List<Coding> wzzzzzzzzzzzzzzzzzzzzzzzzzze_ = wzzzzzzzzzzzzzzzzzzzzzzzzzzd_?.Coding;
                Coding wzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.First<Coding>((IEnumerable<Coding>)wzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                FhirUri wzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = wzzzzzzzzzzzzzzzzzzzzzzzzzzf_?.SystemElement;
                string wzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToString(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Equal(wzzzzzzzzzzzzzzzzzzzzzzzzzzh_, "http://loinc.org");
                List<Coding> wzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = wzzzzzzzzzzzzzzzzzzzzzzzzzzd_?.Coding;
                Coding wzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.First<Coding>((IEnumerable<Coding>)wzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                Code wzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = wzzzzzzzzzzzzzzzzzzzzzzzzzzl_?.CodeElement;
                string wzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToString(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Equal(wzzzzzzzzzzzzzzzzzzzzzzzzzzn_, "8480-6");
                bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.And(wzzzzzzzzzzzzzzzzzzzzzzzzzzi_, wzzzzzzzzzzzzzzzzzzzzzzzzzzo_);

                return wzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
            };
            IEnumerable<Observation.ComponentComponent> uzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)uzzzzzzzzzzzzzzzzzzzzzzzzzzl_, uzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            Observation.ComponentComponent uzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(uzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            DataType uzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = uzzzzzzzzzzzzzzzzzzzzzzzzzzo_?.Value;
            object uzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            CqlQuantity uzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Quantity(1m, "mm[Hg]");
            CqlQuantity uzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Quantity(120m, "mm[Hg]");
            CqlInterval<CqlQuantity> uzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Interval(uzzzzzzzzzzzzzzzzzzzzzzzzzzr_, uzzzzzzzzzzzzzzzzzzzzzzzzzzs_, true, false);
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.In<CqlQuantity>(uzzzzzzzzzzzzzzzzzzzzzzzzzzq_ as CqlQuantity, uzzzzzzzzzzzzzzzzzzzzzzzzzzt_, default);
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzw_(Observation BloodPressure)
            {
                DataType wzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = BloodPressure?.Effective;
                object wzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.toInterval(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.End(wzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                Period wzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.In<CqlDateTime>(wzzzzzzzzzzzzzzzzzzzzzzzzzzt_, wzzzzzzzzzzzzzzzzzzzzzzzzzzv_, default);
                Code<ObservationStatus> wzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = BloodPressure?.StatusElement;
                ObservationStatus? wzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = wzzzzzzzzzzzzzzzzzzzzzzzzzzx_?.Value;
                string wzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Convert<string>(wzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                string[] xzzzzzzzzzzzzzzzzzzzzzzzzzza_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.In<string>(wzzzzzzzzzzzzzzzzzzzzzzzzzzz_, xzzzzzzzzzzzzzzzzzzzzzzzzzza_ as IEnumerable<string>);
                bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.And(wzzzzzzzzzzzzzzzzzzzzzzzzzzw_, xzzzzzzzzzzzzzzzzzzzzzzzzzzb_);

                return xzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
            };
            IEnumerable<Observation> uzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Where<Observation>(uzzzzzzzzzzzzzzzzzzzzzzzzzzf_, uzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            object uzzzzzzzzzzzzzzzzzzzzzzzzzzy_(Observation @this)
            {
                DataType xzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = @this?.Effective;
                object xzzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.toInterval(context, xzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Start(xzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

                return xzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
            };
            IEnumerable<Observation> uzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.SortBy<Observation>(uzzzzzzzzzzzzzzzzzzzzzzzzzzx_, uzzzzzzzzzzzzzzzzzzzzzzzzzzy_, System.ComponentModel.ListSortDirection.Ascending);
            Observation vzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Last<Observation>(uzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            List<Observation.ComponentComponent> vzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = vzzzzzzzzzzzzzzzzzzzzzzzzzza_?.Component;
            bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzc_(Observation.ComponentComponent @this)
            {
                CodeableConcept xzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = @this?.Code;
                List<Coding> xzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = xzzzzzzzzzzzzzzzzzzzzzzzzzzh_?.Coding;
                Coding xzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.First<Coding>((IEnumerable<Coding>)xzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                FhirUri xzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = xzzzzzzzzzzzzzzzzzzzzzzzzzzj_?.SystemElement;
                string xzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToString(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Equal(xzzzzzzzzzzzzzzzzzzzzzzzzzzl_, "http://loinc.org");
                List<Coding> xzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = xzzzzzzzzzzzzzzzzzzzzzzzzzzh_?.Coding;
                Coding xzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.First<Coding>((IEnumerable<Coding>)xzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                Code xzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = xzzzzzzzzzzzzzzzzzzzzzzzzzzp_?.CodeElement;
                string xzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToString(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Equal(xzzzzzzzzzzzzzzzzzzzzzzzzzzr_, "8462-4");
                bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.And(xzzzzzzzzzzzzzzzzzzzzzzzzzzm_, xzzzzzzzzzzzzzzzzzzzzzzzzzzs_);

                return xzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
            };
            IEnumerable<Observation.ComponentComponent> vzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)vzzzzzzzzzzzzzzzzzzzzzzzzzzb_, vzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            Observation.ComponentComponent vzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(vzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            DataType vzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = vzzzzzzzzzzzzzzzzzzzzzzzzzze_?.Value;
            object vzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            CqlQuantity vzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Quantity(80m, "mm[Hg]");
            CqlInterval<CqlQuantity> vzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Interval(uzzzzzzzzzzzzzzzzzzzzzzzzzzr_, vzzzzzzzzzzzzzzzzzzzzzzzzzzi_, true, false);
            bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.In<CqlQuantity>(vzzzzzzzzzzzzzzzzzzzzzzzzzzg_ as CqlQuantity, vzzzzzzzzzzzzzzzzzzzzzzzzzzj_, default);
            bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.And(uzzzzzzzzzzzzzzzzzzzzzzzzzzu_, vzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

            return vzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Where<Encounter>(uzzzzzzzzzzzzzzzzzzzzzzzzzzc_, uzzzzzzzzzzzzzzzzzzzzzzzzzzd_);

        return uzzzzzzzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Encounter with Elevated Blood Pressure Reading SBP 120 to 129 AND DBP less than 80")]
    public IEnumerable<Encounter> Encounter_with_Elevated_Blood_Pressure_Reading_SBP_120_to_129_AND_DBP_less_than_80(CqlContext context)
    {
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Qualifying_Encounter_during_Measurement_Period(context);
        bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzv_(Encounter QualifyingEncounter)
        {
            IEnumerable<Observation> xzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/bp"));
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzy_(Observation BloodPressure)
            {
                DataType zzzzzzzzzzzzzzzzzzzzzzzzzzze_ = BloodPressure?.Effective;
                object zzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.toInterval(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.End(zzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                Period zzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.In<CqlDateTime>(zzzzzzzzzzzzzzzzzzzzzzzzzzzh_, zzzzzzzzzzzzzzzzzzzzzzzzzzzj_, default);
                Code<ObservationStatus> zzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = BloodPressure?.StatusElement;
                ObservationStatus? zzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = zzzzzzzzzzzzzzzzzzzzzzzzzzzl_?.Value;
                string zzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Convert<string>(zzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                string[] zzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.In<string>(zzzzzzzzzzzzzzzzzzzzzzzzzzzn_, zzzzzzzzzzzzzzzzzzzzzzzzzzzo_ as IEnumerable<string>);
                bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.And(zzzzzzzzzzzzzzzzzzzzzzzzzzzk_, zzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

                return zzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
            };
            IEnumerable<Observation> xzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Where<Observation>(xzzzzzzzzzzzzzzzzzzzzzzzzzzx_, xzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            object yzzzzzzzzzzzzzzzzzzzzzzzzzza_(Observation @this)
            {
                DataType zzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = @this?.Effective;
                object zzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.toInterval(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Start(zzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

                return zzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
            };
            IEnumerable<Observation> yzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.SortBy<Observation>(xzzzzzzzzzzzzzzzzzzzzzzzzzzz_, yzzzzzzzzzzzzzzzzzzzzzzzzzza_, System.ComponentModel.ListSortDirection.Ascending);
            Observation yzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Last<Observation>(yzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            List<Observation.ComponentComponent> yzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = yzzzzzzzzzzzzzzzzzzzzzzzzzzc_?.Component;
            bool? yzzzzzzzzzzzzzzzzzzzzzzzzzze_(Observation.ComponentComponent @this)
            {
                CodeableConcept zzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = @this?.Code;
                List<Coding> zzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = zzzzzzzzzzzzzzzzzzzzzzzzzzzv_?.Coding;
                Coding zzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.First<Coding>((IEnumerable<Coding>)zzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                FhirUri zzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = zzzzzzzzzzzzzzzzzzzzzzzzzzzx_?.SystemElement;
                string zzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToString(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                bool? azzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Equal(zzzzzzzzzzzzzzzzzzzzzzzzzzzz_, "http://loinc.org");
                List<Coding> azzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = zzzzzzzzzzzzzzzzzzzzzzzzzzzv_?.Coding;
                Coding azzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.First<Coding>((IEnumerable<Coding>)azzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                Code azzzzzzzzzzzzzzzzzzzzzzzzzzze_ = azzzzzzzzzzzzzzzzzzzzzzzzzzzd_?.CodeElement;
                string azzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToString(context, azzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Equal(azzzzzzzzzzzzzzzzzzzzzzzzzzzf_, "8480-6");
                bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.And(azzzzzzzzzzzzzzzzzzzzzzzzzzza_, azzzzzzzzzzzzzzzzzzzzzzzzzzzg_);

                return azzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
            };
            IEnumerable<Observation.ComponentComponent> yzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)yzzzzzzzzzzzzzzzzzzzzzzzzzzd_, yzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            Observation.ComponentComponent yzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(yzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            DataType yzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = yzzzzzzzzzzzzzzzzzzzzzzzzzzg_?.Value;
            object yzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            CqlQuantity yzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Quantity(120m, "mm[Hg]");
            CqlQuantity yzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Quantity(129m, "mm[Hg]");
            CqlInterval<CqlQuantity> yzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Interval(yzzzzzzzzzzzzzzzzzzzzzzzzzzj_, yzzzzzzzzzzzzzzzzzzzzzzzzzzk_, true, true);
            bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.In<CqlQuantity>(yzzzzzzzzzzzzzzzzzzzzzzzzzzi_ as CqlQuantity, yzzzzzzzzzzzzzzzzzzzzzzzzzzl_, default);
            bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzo_(Observation BloodPressure)
            {
                DataType azzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = BloodPressure?.Effective;
                object azzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.toInterval(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.End(azzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                Period azzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.In<CqlDateTime>(azzzzzzzzzzzzzzzzzzzzzzzzzzzl_, azzzzzzzzzzzzzzzzzzzzzzzzzzzn_, default);
                Code<ObservationStatus> azzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = BloodPressure?.StatusElement;
                ObservationStatus? azzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = azzzzzzzzzzzzzzzzzzzzzzzzzzzp_?.Value;
                string azzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Convert<string>(azzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                string[] azzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.In<string>(azzzzzzzzzzzzzzzzzzzzzzzzzzzr_, azzzzzzzzzzzzzzzzzzzzzzzzzzzs_ as IEnumerable<string>);
                bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.And(azzzzzzzzzzzzzzzzzzzzzzzzzzzo_, azzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

                return azzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
            };
            IEnumerable<Observation> yzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Observation>(xzzzzzzzzzzzzzzzzzzzzzzzzzzx_, yzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            object yzzzzzzzzzzzzzzzzzzzzzzzzzzq_(Observation @this)
            {
                DataType azzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = @this?.Effective;
                object azzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.toInterval(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Start(azzzzzzzzzzzzzzzzzzzzzzzzzzzx_);

                return azzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
            };
            IEnumerable<Observation> yzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.SortBy<Observation>(yzzzzzzzzzzzzzzzzzzzzzzzzzzp_, yzzzzzzzzzzzzzzzzzzzzzzzzzzq_, System.ComponentModel.ListSortDirection.Ascending);
            Observation yzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Last<Observation>(yzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            List<Observation.ComponentComponent> yzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = yzzzzzzzzzzzzzzzzzzzzzzzzzzs_?.Component;
            bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzu_(Observation.ComponentComponent @this)
            {
                CodeableConcept azzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = @this?.Code;
                List<Coding> bzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = azzzzzzzzzzzzzzzzzzzzzzzzzzzz_?.Coding;
                Coding bzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.First<Coding>((IEnumerable<Coding>)bzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                FhirUri bzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = bzzzzzzzzzzzzzzzzzzzzzzzzzzzb_?.SystemElement;
                string bzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToString(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Equal(bzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, "http://loinc.org");
                List<Coding> bzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = azzzzzzzzzzzzzzzzzzzzzzzzzzzz_?.Coding;
                Coding bzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.First<Coding>((IEnumerable<Coding>)bzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                Code bzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = bzzzzzzzzzzzzzzzzzzzzzzzzzzzh_?.CodeElement;
                string bzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToString(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Equal(bzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, "8462-4");
                bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.And(bzzzzzzzzzzzzzzzzzzzzzzzzzzze_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

                return bzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
            };
            IEnumerable<Observation.ComponentComponent> yzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)yzzzzzzzzzzzzzzzzzzzzzzzzzzt_, yzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            Observation.ComponentComponent yzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(yzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            DataType yzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = yzzzzzzzzzzzzzzzzzzzzzzzzzzw_?.Value;
            object yzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlQuantity yzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Quantity(1m, "mm[Hg]");
            CqlQuantity zzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Quantity(80m, "mm[Hg]");
            CqlInterval<CqlQuantity> zzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Interval(yzzzzzzzzzzzzzzzzzzzzzzzzzzz_, zzzzzzzzzzzzzzzzzzzzzzzzzzza_, true, false);
            bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.In<CqlQuantity>(yzzzzzzzzzzzzzzzzzzzzzzzzzzy_ as CqlQuantity, zzzzzzzzzzzzzzzzzzzzzzzzzzzb_, default);
            bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.And(yzzzzzzzzzzzzzzzzzzzzzzzzzzm_, zzzzzzzzzzzzzzzzzzzzzzzzzzzc_);

            return zzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Where<Encounter>(xzzzzzzzzzzzzzzzzzzzzzzzzzzu_, xzzzzzzzzzzzzzzzzzzzzzzzzzzv_);

        return xzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Follow up with Rescreen Within 6 Months")]
    public IEnumerable<ServiceRequest> Follow_up_with_Rescreen_Within_6_Months(CqlContext context)
    {
        CqlValueSet bzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Follow_Up_Within_6_Months(context);
        IEnumerable<ServiceRequest> bzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzo_(ServiceRequest FollowUp)
        {
            Code<RequestIntent> bzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FollowUp?.IntentElement;
            RequestIntent? bzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = bzzzzzzzzzzzzzzzzzzzzzzzzzzzq_?.Value;
            Code<RequestIntent> bzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Convert<Code<RequestIntent>>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Equivalent(bzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, "order");

            return bzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<ServiceRequest> bzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<ServiceRequest>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);

        return bzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("NonPharmacological Interventions")]
    public IEnumerable<ServiceRequest> NonPharmacological_Interventions(CqlContext context)
    {
        CqlValueSet bzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Lifestyle_Recommendation(context);
        IEnumerable<ServiceRequest> bzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        CqlValueSet bzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Weight_Reduction_Recommended(context);
        IEnumerable<ServiceRequest> bzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> bzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Union<ServiceRequest>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
        CqlValueSet bzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Dietary_Recommendations(context);
        IEnumerable<ServiceRequest> czzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        CqlValueSet czzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Recommendation_to_Increase_Physical_Activity(context);
        IEnumerable<ServiceRequest> czzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> czzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Union<ServiceRequest>(czzzzzzzzzzzzzzzzzzzzzzzzzzza_, czzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        IEnumerable<ServiceRequest> czzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Union<ServiceRequest>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, czzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
        CqlValueSet czzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Referral_or_Counseling_for_Alcohol_Consumption(context);
        IEnumerable<ServiceRequest> czzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> czzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Union<ServiceRequest>(czzzzzzzzzzzzzzzzzzzzzzzzzzze_, czzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
        bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzi_(ServiceRequest NonPharmaInterventions)
        {
            Code<RequestIntent> czzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = NonPharmaInterventions?.IntentElement;
            RequestIntent? czzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = czzzzzzzzzzzzzzzzzzzzzzzzzzzk_?.Value;
            Code<RequestIntent> czzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Convert<Code<RequestIntent>>(czzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Equivalent(czzzzzzzzzzzzzzzzzzzzzzzzzzzm_, "order");

            return czzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<ServiceRequest> czzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Where<ServiceRequest>(czzzzzzzzzzzzzzzzzzzzzzzzzzzh_, czzzzzzzzzzzzzzzzzzzzzzzzzzzi_);

        return czzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Referral to Alternate or Primary Healthcare Professional for Hypertensive Reading")]
    public IEnumerable<ServiceRequest> Referral_to_Alternate_or_Primary_Healthcare_Professional_for_Hypertensive_Reading(CqlContext context)
    {
        CqlValueSet czzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Referral_to_Primary_Care_or_Alternate_Provider(context);
        IEnumerable<ServiceRequest> czzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzq_(ServiceRequest Referral)
        {
            List<CodeableConcept> czzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = Referral?.ReasonCode;
            CqlConcept czzzzzzzzzzzzzzzzzzzzzzzzzzzt_(CodeableConcept @this)
            {
                CqlConcept dzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return dzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
            };
            IEnumerable<CqlConcept> czzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)czzzzzzzzzzzzzzzzzzzzzzzzzzzs_, czzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlValueSet czzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Finding_of_Elevated_Blood_Pressure_or_Hypertension(context);
            bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.ConceptsInValueSet(czzzzzzzzzzzzzzzzzzzzzzzzzzzu_, czzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            Code<RequestIntent> czzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = Referral?.IntentElement;
            RequestIntent? czzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = czzzzzzzzzzzzzzzzzzzzzzzzzzzx_?.Value;
            Code<RequestIntent> czzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Convert<Code<RequestIntent>>(czzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Equivalent(czzzzzzzzzzzzzzzzzzzzzzzzzzzz_, "order");
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.And(czzzzzzzzzzzzzzzzzzzzzzzzzzzw_, dzzzzzzzzzzzzzzzzzzzzzzzzzzza_);

            return dzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
        };
        IEnumerable<ServiceRequest> czzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Where<ServiceRequest>(czzzzzzzzzzzzzzzzzzzzzzzzzzzp_, czzzzzzzzzzzzzzzzzzzzzzzzzzzq_);

        return czzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Encounter with Elevated Blood Pressure Reading SBP 120 to 129 AND DBP less than 80 and Interventions")]
    public IEnumerable<Encounter> Encounter_with_Elevated_Blood_Pressure_Reading_SBP_120_to_129_AND_DBP_less_than_80_and_Interventions(CqlContext context)
    {
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Encounter_with_Elevated_Blood_Pressure_Reading_SBP_120_to_129_AND_DBP_less_than_80(context);
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzzzze_(Encounter ElevatedEncounter)
        {
            IEnumerable<ServiceRequest> dzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Follow_up_with_Rescreen_Within_6_Months(context);
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzn_(ServiceRequest Twoto6MonthRescreen)
            {
                FhirDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = Twoto6MonthRescreen?.AuthoredOnElement;
                CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Convert<CqlDateTime>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                Period dzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = ElevatedEncounter?.Period;
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.In<CqlDateTime>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, "day");

                return dzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
            };
            IEnumerable<ServiceRequest> dzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<ServiceRequest>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            Encounter dzzzzzzzzzzzzzzzzzzzzzzzzzzzp_(ServiceRequest Twoto6MonthRescreen) =>
                ElevatedEncounter;
            IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Select<ServiceRequest, Encounter>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

            return dzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.SelectMany<Encounter, Encounter>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, dzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzzzzg_(Encounter ElevatedEncounter)
        {
            IEnumerable<ServiceRequest> dzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.NonPharmacological_Interventions(context);
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzx_(ServiceRequest NonPharmInterventions)
            {
                FhirDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = NonPharmInterventions?.AuthoredOnElement;
                CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Convert<CqlDateTime>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                Period ezzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = ElevatedEncounter?.Period;
                CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.In<CqlDateTime>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzc_, ezzzzzzzzzzzzzzzzzzzzzzzzzzze_, "day");

                return ezzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
            };
            IEnumerable<ServiceRequest> dzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Where<ServiceRequest>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            Encounter dzzzzzzzzzzzzzzzzzzzzzzzzzzzz_(ServiceRequest NonPharmInterventions) =>
                ElevatedEncounter;
            IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Select<ServiceRequest, Encounter>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

            return ezzzzzzzzzzzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.SelectMany<Encounter, Encounter>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzzzzj_(Encounter ElevatedEncounter)
        {
            IEnumerable<ServiceRequest> ezzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Referral_to_Alternate_or_Primary_Healthcare_Professional_for_Hypertensive_Reading(context);
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzh_(ServiceRequest Referral)
            {
                FhirDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = Referral?.AuthoredOnElement;
                CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Convert<CqlDateTime>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                Period ezzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = ElevatedEncounter?.Period;
                CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.In<CqlDateTime>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzm_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzo_, "day");

                return ezzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
            };
            IEnumerable<ServiceRequest> ezzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<ServiceRequest>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzg_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            Encounter ezzzzzzzzzzzzzzzzzzzzzzzzzzzj_(ServiceRequest Referral) =>
                ElevatedEncounter;
            IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Select<ServiceRequest, Encounter>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzi_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzj_);

            return ezzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.SelectMany<Encounter, Encounter>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Union<Encounter>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

        return dzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Encounter with Hypertensive Reading Within Year Prior")]
    public IEnumerable<Encounter> Encounter_with_Hypertensive_Reading_Within_Year_Prior(CqlContext context)
    {
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Qualifying_Encounter_during_Measurement_Period(context);
        bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzr_(Encounter QualifyingEncounter)
        {
            IEnumerable<Observation> ezzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/bp"));
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzu_(Observation BloodPressure)
            {
                DataType hzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = BloodPressure?.Effective;
                object hzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.toInterval(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.End(hzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                Period hzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Start(hzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                CqlQuantity hzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Quantity(1m, "year");
                CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Subtract(hzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Start(hzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Interval(hzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, true, true);
                bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.In<CqlDateTime>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, default);
                CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Start(hzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Not((bool?)(hzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ is null));
                bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.And(hzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                Code<ObservationStatus> hzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = BloodPressure?.StatusElement;
                ObservationStatus? hzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = hzzzzzzzzzzzzzzzzzzzzzzzzzzzt_?.Value;
                string hzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Convert<string>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                string[] hzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.In<string>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ as IEnumerable<string>);
                bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.And(hzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);

                return hzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
            };
            IEnumerable<Observation> ezzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Observation>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzt_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            object ezzzzzzzzzzzzzzzzzzzzzzzzzzzw_(Observation @this)
            {
                DataType hzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = @this?.Effective;
                object izzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.toInterval(context, izzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Start(izzzzzzzzzzzzzzzzzzzzzzzzzzzb_);

                return izzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
            };
            IEnumerable<Observation> ezzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.SortBy<Observation>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzv_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzw_, System.ComponentModel.ListSortDirection.Ascending);
            Observation ezzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Last<Observation>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            List<Observation.ComponentComponent> ezzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = ezzzzzzzzzzzzzzzzzzzzzzzzzzzy_?.Component;
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzza_(Observation.ComponentComponent @this)
            {
                CodeableConcept izzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = @this?.Code;
                List<Coding> izzzzzzzzzzzzzzzzzzzzzzzzzzze_ = izzzzzzzzzzzzzzzzzzzzzzzzzzzd_?.Coding;
                Coding izzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.First<Coding>((IEnumerable<Coding>)izzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                FhirUri izzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = izzzzzzzzzzzzzzzzzzzzzzzzzzzf_?.SystemElement;
                string izzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToString(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Equal(izzzzzzzzzzzzzzzzzzzzzzzzzzzh_, "http://loinc.org");
                List<Coding> izzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = izzzzzzzzzzzzzzzzzzzzzzzzzzzd_?.Coding;
                Coding izzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.First<Coding>((IEnumerable<Coding>)izzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                Code izzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = izzzzzzzzzzzzzzzzzzzzzzzzzzzl_?.CodeElement;
                string izzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToString(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Equal(izzzzzzzzzzzzzzzzzzzzzzzzzzzn_, "8480-6");
                bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.And(izzzzzzzzzzzzzzzzzzzzzzzzzzzi_, izzzzzzzzzzzzzzzzzzzzzzzzzzzo_);

                return izzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
            };
            IEnumerable<Observation.ComponentComponent> fzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)ezzzzzzzzzzzzzzzzzzzzzzzzzzzz_, fzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            Observation.ComponentComponent fzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            DataType fzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = fzzzzzzzzzzzzzzzzzzzzzzzzzzzc_?.Value;
            object fzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlQuantity fzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Quantity(0m, "mm[Hg]");
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Greater(fzzzzzzzzzzzzzzzzzzzzzzzzzzze_ as CqlQuantity, fzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzi_(Observation BloodPressure)
            {
                DataType izzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = BloodPressure?.Effective;
                object izzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.toInterval(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.End(izzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                Period izzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Start(izzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                CqlQuantity izzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Quantity(1m, "year");
                CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Subtract(izzzzzzzzzzzzzzzzzzzzzzzzzzzw_, izzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Start(jzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Interval(izzzzzzzzzzzzzzzzzzzzzzzzzzzy_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, true, true);
                bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.In<CqlDateTime>(izzzzzzzzzzzzzzzzzzzzzzzzzzzt_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, default);
                CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Start(jzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Not((bool?)(jzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ is null));
                bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.And(jzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                Code<ObservationStatus> jzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = BloodPressure?.StatusElement;
                ObservationStatus? jzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = jzzzzzzzzzzzzzzzzzzzzzzzzzzzj_?.Value;
                string jzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Convert<string>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                string[] jzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.In<string>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ as IEnumerable<string>);
                bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.And(jzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);

                return jzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
            };
            IEnumerable<Observation> fzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Where<Observation>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzt_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            object fzzzzzzzzzzzzzzzzzzzzzzzzzzzk_(Observation @this)
            {
                DataType jzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = @this?.Effective;
                object jzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.toInterval(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Start(jzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);

                return jzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
            };
            IEnumerable<Observation> fzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.SortBy<Observation>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, System.ComponentModel.ListSortDirection.Ascending);
            Observation fzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Last<Observation>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            List<Observation.ComponentComponent> fzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = fzzzzzzzzzzzzzzzzzzzzzzzzzzzm_?.Component;
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzo_(Observation.ComponentComponent @this)
            {
                CodeableConcept jzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = @this?.Code;
                List<Coding> jzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = jzzzzzzzzzzzzzzzzzzzzzzzzzzzt_?.Coding;
                Coding jzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.First<Coding>((IEnumerable<Coding>)jzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                FhirUri jzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = jzzzzzzzzzzzzzzzzzzzzzzzzzzzv_?.SystemElement;
                string jzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToString(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Equal(jzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, "http://loinc.org");
                List<Coding> kzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = jzzzzzzzzzzzzzzzzzzzzzzzzzzzt_?.Coding;
                Coding kzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.First<Coding>((IEnumerable<Coding>)kzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                Code kzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = kzzzzzzzzzzzzzzzzzzzzzzzzzzzb_?.CodeElement;
                string kzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToString(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Equal(kzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, "8462-4");
                bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.And(jzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, kzzzzzzzzzzzzzzzzzzzzzzzzzzze_);

                return kzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
            };
            IEnumerable<Observation.ComponentComponent> fzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)fzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            Observation.ComponentComponent fzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            DataType fzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = fzzzzzzzzzzzzzzzzzzzzzzzzzzzq_?.Value;
            object fzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Greater(fzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ as CqlQuantity, fzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.And(fzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzx_(Observation BloodPressure)
            {
                DataType kzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = BloodPressure?.Effective;
                object kzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.toInterval(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.End(kzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                Period kzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Start(kzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                CqlQuantity kzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Quantity(1m, "year");
                CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Subtract(kzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Start(kzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Interval(kzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, true, true);
                bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.In<CqlDateTime>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, default);
                CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Start(kzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Not((bool?)(kzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ is null));
                bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.And(kzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                Code<ObservationStatus> kzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = BloodPressure?.StatusElement;
                ObservationStatus? lzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = kzzzzzzzzzzzzzzzzzzzzzzzzzzzz_?.Value;
                string lzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Convert<string>(lzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                string[] lzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.In<string>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ as IEnumerable<string>);
                bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.And(kzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);

                return lzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
            };
            IEnumerable<Observation> fzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Where<Observation>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzt_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            object fzzzzzzzzzzzzzzzzzzzzzzzzzzzz_(Observation @this)
            {
                DataType lzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = @this?.Effective;
                object lzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.toInterval(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Start(lzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);

                return lzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
            };
            IEnumerable<Observation> gzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.SortBy<Observation>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, System.ComponentModel.ListSortDirection.Ascending);
            Observation gzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Last<Observation>(gzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            List<Observation.ComponentComponent> gzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = gzzzzzzzzzzzzzzzzzzzzzzzzzzzb_?.Component;
            bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzd_(Observation.ComponentComponent @this)
            {
                CodeableConcept lzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = @this?.Code;
                List<Coding> lzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = lzzzzzzzzzzzzzzzzzzzzzzzzzzzj_?.Coding;
                Coding lzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.First<Coding>((IEnumerable<Coding>)lzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                FhirUri lzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = lzzzzzzzzzzzzzzzzzzzzzzzzzzzl_?.SystemElement;
                string lzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToString(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Equal(lzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, "http://loinc.org");
                List<Coding> lzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = lzzzzzzzzzzzzzzzzzzzzzzzzzzzj_?.Coding;
                Coding lzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.First<Coding>((IEnumerable<Coding>)lzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                Code lzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = lzzzzzzzzzzzzzzzzzzzzzzzzzzzr_?.CodeElement;
                string lzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToString(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Equal(lzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, "8480-6");
                bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.And(lzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);

                return lzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
            };
            IEnumerable<Observation.ComponentComponent> gzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)gzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            Observation.ComponentComponent gzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(gzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            DataType gzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = gzzzzzzzzzzzzzzzzzzzzzzzzzzzf_?.Value;
            object gzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlQuantity gzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Quantity(130m, "mm[Hg]");
            bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.GreaterOrEqual(gzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ as CqlQuantity, gzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzl_(Observation BloodPressure)
            {
                DataType lzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = BloodPressure?.Effective;
                object lzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.toInterval(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.End(lzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                Period mzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Start(mzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                CqlQuantity mzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Quantity(1m, "year");
                CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Subtract(mzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Start(mzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Interval(mzzzzzzzzzzzzzzzzzzzzzzzzzzze_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, true, true);
                bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.In<CqlDateTime>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, default);
                CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Start(mzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Not((bool?)(mzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ is null));
                bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.And(mzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                Code<ObservationStatus> mzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = BloodPressure?.StatusElement;
                ObservationStatus? mzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = mzzzzzzzzzzzzzzzzzzzzzzzzzzzp_?.Value;
                string mzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Convert<string>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                string[] mzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.In<string>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ as IEnumerable<string>);
                bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.And(mzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

                return mzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
            };
            IEnumerable<Observation> gzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Where<Observation>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzt_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            object gzzzzzzzzzzzzzzzzzzzzzzzzzzzn_(Observation @this)
            {
                DataType mzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = @this?.Effective;
                object mzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.toInterval(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Start(mzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);

                return mzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
            };
            IEnumerable<Observation> gzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.SortBy<Observation>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, System.ComponentModel.ListSortDirection.Ascending);
            Observation gzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Last<Observation>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            List<Observation.ComponentComponent> gzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = gzzzzzzzzzzzzzzzzzzzzzzzzzzzp_?.Component;
            bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzr_(Observation.ComponentComponent @this)
            {
                CodeableConcept mzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = @this?.Code;
                List<Coding> nzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = mzzzzzzzzzzzzzzzzzzzzzzzzzzzz_?.Coding;
                Coding nzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.First<Coding>((IEnumerable<Coding>)nzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                FhirUri nzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = nzzzzzzzzzzzzzzzzzzzzzzzzzzzb_?.SystemElement;
                string nzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToString(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Equal(nzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, "http://loinc.org");
                List<Coding> nzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = mzzzzzzzzzzzzzzzzzzzzzzzzzzzz_?.Coding;
                Coding nzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.First<Coding>((IEnumerable<Coding>)nzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                Code nzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = nzzzzzzzzzzzzzzzzzzzzzzzzzzzh_?.CodeElement;
                string nzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToString(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Equal(nzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, "8462-4");
                bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.And(nzzzzzzzzzzzzzzzzzzzzzzzzzzze_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

                return nzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
            };
            IEnumerable<Observation.ComponentComponent> gzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)gzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            Observation.ComponentComponent gzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            DataType gzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = gzzzzzzzzzzzzzzzzzzzzzzzzzzzt_?.Value;
            object gzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlQuantity gzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Quantity(80m, "mm[Hg]");
            bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.GreaterOrEqual(gzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ as CqlQuantity, gzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Or(gzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.And(fzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

            return gzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Where<Encounter>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzq_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzr_);

        return ezzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Encounter with First Hypertensive Reading SBP Greater than or Equal to 130 OR DBP Greater than or Equal to 80")]
    public IEnumerable<Encounter> Encounter_with_First_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_130_OR_DBP_Greater_than_or_Equal_to_80(CqlContext context)
    {
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Qualifying_Encounter_during_Measurement_Period(context);
        bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzn_(Encounter QualifyingEncounter)
        {
            IEnumerable<Observation> nzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/bp"));
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzs_(Observation BloodPressure)
            {
                DataType pzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = BloodPressure?.Effective;
                object pzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.toInterval(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.End(qzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                Period qzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.In<CqlDateTime>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, "day");

                return qzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
            };
            IEnumerable<Observation> nzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Where<Observation>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            object nzzzzzzzzzzzzzzzzzzzzzzzzzzzu_(Observation @this)
            {
                DataType qzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = @this?.Effective;
                object qzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.toInterval(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Start(qzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);

                return qzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
            };
            IEnumerable<Observation> nzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.SortBy<Observation>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, System.ComponentModel.ListSortDirection.Ascending);
            Observation nzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Last<Observation>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            List<Observation.ComponentComponent> nzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = nzzzzzzzzzzzzzzzzzzzzzzzzzzzw_?.Component;
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzy_(Observation.ComponentComponent @this)
            {
                CodeableConcept qzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = @this?.Code;
                List<Coding> qzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = qzzzzzzzzzzzzzzzzzzzzzzzzzzzj_?.Coding;
                Coding qzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.First<Coding>((IEnumerable<Coding>)qzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                FhirUri qzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = qzzzzzzzzzzzzzzzzzzzzzzzzzzzl_?.SystemElement;
                string qzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToString(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Equal(qzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, "http://loinc.org");
                List<Coding> qzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = qzzzzzzzzzzzzzzzzzzzzzzzzzzzj_?.Coding;
                Coding qzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.First<Coding>((IEnumerable<Coding>)qzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                Code qzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = qzzzzzzzzzzzzzzzzzzzzzzzzzzzr_?.CodeElement;
                string qzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToString(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Equal(qzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, "8480-6");
                bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.And(qzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);

                return qzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
            };
            IEnumerable<Observation.ComponentComponent> nzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)nzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            Observation.ComponentComponent ozzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            DataType ozzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = ozzzzzzzzzzzzzzzzzzzzzzzzzzza_?.Value;
            object ozzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            CqlQuantity ozzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Quantity(0m, "mm[Hg]");
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Greater(ozzzzzzzzzzzzzzzzzzzzzzzzzzzc_ as CqlQuantity, ozzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzg_(Observation BloodPressure)
            {
                DataType qzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = BloodPressure?.Effective;
                object qzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.toInterval(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.End(qzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                Period rzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.In<CqlDateTime>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, "day");

                return rzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
            };
            IEnumerable<Observation> ozzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Where<Observation>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            object ozzzzzzzzzzzzzzzzzzzzzzzzzzzi_(Observation @this)
            {
                DataType rzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = @this?.Effective;
                object rzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.toInterval(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Start(rzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

                return rzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
            };
            IEnumerable<Observation> ozzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.SortBy<Observation>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzh_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzi_, System.ComponentModel.ListSortDirection.Ascending);
            Observation ozzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Last<Observation>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            List<Observation.ComponentComponent> ozzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = ozzzzzzzzzzzzzzzzzzzzzzzzzzzk_?.Component;
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzm_(Observation.ComponentComponent @this)
            {
                CodeableConcept rzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = @this?.Code;
                List<Coding> rzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = rzzzzzzzzzzzzzzzzzzzzzzzzzzzh_?.Coding;
                Coding rzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.First<Coding>((IEnumerable<Coding>)rzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                FhirUri rzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = rzzzzzzzzzzzzzzzzzzzzzzzzzzzj_?.SystemElement;
                string rzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToString(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Equal(rzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, "http://loinc.org");
                List<Coding> rzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = rzzzzzzzzzzzzzzzzzzzzzzzzzzzh_?.Coding;
                Coding rzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.First<Coding>((IEnumerable<Coding>)rzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                Code rzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = rzzzzzzzzzzzzzzzzzzzzzzzzzzzp_?.CodeElement;
                string rzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToString(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Equal(rzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, "8462-4");
                bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.And(rzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);

                return rzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
            };
            IEnumerable<Observation.ComponentComponent> ozzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)ozzzzzzzzzzzzzzzzzzzzzzzzzzzl_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            Observation.ComponentComponent ozzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            DataType ozzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = ozzzzzzzzzzzzzzzzzzzzzzzzzzzo_?.Value;
            object ozzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Greater(ozzzzzzzzzzzzzzzzzzzzzzzzzzzq_ as CqlQuantity, ozzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzzzzzzzzzze_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzv_(Observation BloodPressure)
            {
                DataType rzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = BloodPressure?.Effective;
                object rzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.toInterval(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.End(rzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                Period rzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                bool? szzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.In<CqlDateTime>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, "day");

                return szzzzzzzzzzzzzzzzzzzzzzzzzzza_;
            };
            IEnumerable<Observation> ozzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Where<Observation>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            object ozzzzzzzzzzzzzzzzzzzzzzzzzzzx_(Observation @this)
            {
                DataType szzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = @this?.Effective;
                object szzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.toInterval(context, szzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Start(szzzzzzzzzzzzzzzzzzzzzzzzzzzd_);

                return szzzzzzzzzzzzzzzzzzzzzzzzzzze_;
            };
            IEnumerable<Observation> ozzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.SortBy<Observation>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzw_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzx_, System.ComponentModel.ListSortDirection.Ascending);
            Observation ozzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Last<Observation>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            List<Observation.ComponentComponent> pzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = ozzzzzzzzzzzzzzzzzzzzzzzzzzzz_?.Component;
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzb_(Observation.ComponentComponent @this)
            {
                CodeableConcept szzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = @this?.Code;
                List<Coding> szzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = szzzzzzzzzzzzzzzzzzzzzzzzzzzf_?.Coding;
                Coding szzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.First<Coding>((IEnumerable<Coding>)szzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                FhirUri szzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = szzzzzzzzzzzzzzzzzzzzzzzzzzzh_?.SystemElement;
                string szzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToString(context, szzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Equal(szzzzzzzzzzzzzzzzzzzzzzzzzzzj_, "http://loinc.org");
                List<Coding> szzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = szzzzzzzzzzzzzzzzzzzzzzzzzzzf_?.Coding;
                Coding szzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.First<Coding>((IEnumerable<Coding>)szzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                Code szzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = szzzzzzzzzzzzzzzzzzzzzzzzzzzn_?.CodeElement;
                string szzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToString(context, szzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Equal(szzzzzzzzzzzzzzzzzzzzzzzzzzzp_, "8480-6");
                bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.And(szzzzzzzzzzzzzzzzzzzzzzzzzzzk_, szzzzzzzzzzzzzzzzzzzzzzzzzzzq_);

                return szzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
            };
            IEnumerable<Observation.ComponentComponent> pzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)pzzzzzzzzzzzzzzzzzzzzzzzzzzza_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            Observation.ComponentComponent pzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            DataType pzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = pzzzzzzzzzzzzzzzzzzzzzzzzzzzd_?.Value;
            object pzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            CqlQuantity pzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Quantity(130m, "mm[Hg]");
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.GreaterOrEqual(pzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ as CqlQuantity, pzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzj_(Observation BloodPressure)
            {
                DataType szzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = BloodPressure?.Effective;
                object szzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.toInterval(context, szzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.End(szzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                Period szzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.In<CqlDateTime>(szzzzzzzzzzzzzzzzzzzzzzzzzzzv_, szzzzzzzzzzzzzzzzzzzzzzzzzzzx_, "day");

                return szzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
            };
            IEnumerable<Observation> pzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Where<Observation>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            object pzzzzzzzzzzzzzzzzzzzzzzzzzzzl_(Observation @this)
            {
                DataType szzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = @this?.Effective;
                object tzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.toInterval(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Start(tzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);

                return tzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
            };
            IEnumerable<Observation> pzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.SortBy<Observation>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, System.ComponentModel.ListSortDirection.Ascending);
            Observation pzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Last<Observation>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            List<Observation.ComponentComponent> pzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = pzzzzzzzzzzzzzzzzzzzzzzzzzzzn_?.Component;
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzp_(Observation.ComponentComponent @this)
            {
                CodeableConcept tzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = @this?.Code;
                List<Coding> tzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = tzzzzzzzzzzzzzzzzzzzzzzzzzzzd_?.Coding;
                Coding tzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.First<Coding>((IEnumerable<Coding>)tzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                FhirUri tzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = tzzzzzzzzzzzzzzzzzzzzzzzzzzzf_?.SystemElement;
                string tzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToString(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Equal(tzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, "http://loinc.org");
                List<Coding> tzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = tzzzzzzzzzzzzzzzzzzzzzzzzzzzd_?.Coding;
                Coding tzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.First<Coding>((IEnumerable<Coding>)tzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                Code tzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = tzzzzzzzzzzzzzzzzzzzzzzzzzzzl_?.CodeElement;
                string tzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToString(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Equal(tzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, "8462-4");
                bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.And(tzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);

                return tzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
            };
            IEnumerable<Observation.ComponentComponent> pzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)pzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            Observation.ComponentComponent pzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            DataType pzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = pzzzzzzzzzzzzzzzzzzzzzzzzzzzr_?.Value;
            object pzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            CqlQuantity pzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Quantity(80m, "mm[Hg]");
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.GreaterOrEqual(pzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ as CqlQuantity, pzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Or(pzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzzzzzzzzzzt_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);

            return pzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<Encounter>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Encounter_with_Hypertensive_Reading_Within_Year_Prior(context);
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Except<Encounter>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

        return nzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("First Hypertensive Reading Interventions or Referral to Alternate Professional")]
    public IEnumerable<ServiceRequest> First_Hypertensive_Reading_Interventions_or_Referral_to_Alternate_Professional(CqlContext context)
    {
        CqlValueSet tzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Follow_Up_Within_4_Weeks(context);
        IEnumerable<ServiceRequest> tzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> tzzzzzzzzzzzzzzzzzzzzzzzzzzzs_(ServiceRequest FourWeekRescreen)
        {
            IEnumerable<ServiceRequest> tzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.NonPharmacological_Interventions(context);
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzx_(ServiceRequest NonPharmInterventionsHTN)
            {
                FhirDateTime uzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = FourWeekRescreen?.AuthoredOnElement;
                CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Convert<CqlDateTime>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Measurement_Period(context);
                bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.In<CqlDateTime>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, "day");
                FhirDateTime uzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = NonPharmInterventionsHTN?.AuthoredOnElement;
                CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Convert<CqlDateTime>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.In<CqlDateTime>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, "day");
                bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.And(uzzzzzzzzzzzzzzzzzzzzzzzzzzze_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                Code<RequestIntent> uzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FourWeekRescreen?.IntentElement;
                RequestIntent? uzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = uzzzzzzzzzzzzzzzzzzzzzzzzzzzk_?.Value;
                Code<RequestIntent> uzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Convert<Code<RequestIntent>>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Equivalent(uzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, "order");
                bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.And(uzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);

                return uzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
            };
            IEnumerable<ServiceRequest> tzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Where<ServiceRequest>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            ServiceRequest tzzzzzzzzzzzzzzzzzzzzzzzzzzzz_(ServiceRequest NonPharmInterventionsHTN) =>
                FourWeekRescreen;
            IEnumerable<ServiceRequest> uzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Select<ServiceRequest, ServiceRequest>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

            return uzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<ServiceRequest> tzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.SelectMany<ServiceRequest, ServiceRequest>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        IEnumerable<ServiceRequest> tzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Referral_to_Alternate_or_Primary_Healthcare_Professional_for_Hypertensive_Reading(context);
        IEnumerable<ServiceRequest> tzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Union<ServiceRequest>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);

        return tzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Encounter with First Hypertensive Reading SBP Greater than or Equal to 130 OR DBP Greater than or Equal to 80 and Interventions")]
    public IEnumerable<Encounter> Encounter_with_First_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_130_OR_DBP_Greater_than_or_Equal_to_80_and_Interventions(CqlContext context)
    {
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Encounter_with_First_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_130_OR_DBP_Greater_than_or_Equal_to_80(context);
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzzzzzzzzq_(Encounter FirstHTNEncounter)
        {
            IEnumerable<ServiceRequest> uzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.First_Hypertensive_Reading_Interventions_or_Referral_to_Alternate_Professional(context);
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzt_(ServiceRequest FirstHTNIntervention)
            {
                FhirDateTime uzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FirstHTNIntervention?.AuthoredOnElement;
                CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Convert<CqlDateTime>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                Period uzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = FirstHTNEncounter?.Period;
                CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.In<CqlDateTime>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, vzzzzzzzzzzzzzzzzzzzzzzzzzzza_, "day");

                return vzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
            };
            IEnumerable<ServiceRequest> uzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Where<ServiceRequest>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            Encounter uzzzzzzzzzzzzzzzzzzzzzzzzzzzv_(ServiceRequest FirstHTNIntervention) =>
                FirstHTNEncounter;
            IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Select<ServiceRequest, Encounter>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);

            return uzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.SelectMany<Encounter, Encounter>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);

        return uzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Encounter with Second Hypertensive Reading SBP 130 to 139 OR DBP 80 to 89")]
    public IEnumerable<Encounter> Encounter_with_Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89(CqlContext context)
    {
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Qualifying_Encounter_during_Measurement_Period(context);
        bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzd_(Encounter QualifyingEncounter)
        {
            IEnumerable<Observation> vzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/bp"));
            bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzg_(Observation BloodPressure)
            {
                DataType xzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = BloodPressure?.Effective;
                object xzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.toInterval(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.End(xzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                Period xzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.In<CqlDateTime>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, "day");
                Code<ObservationStatus> yzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = BloodPressure?.StatusElement;
                ObservationStatus? yzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = yzzzzzzzzzzzzzzzzzzzzzzzzzzzb_?.Value;
                string yzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Convert<string>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                string[] yzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.In<string>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, yzzzzzzzzzzzzzzzzzzzzzzzzzzze_ as IEnumerable<string>);
                bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.And(yzzzzzzzzzzzzzzzzzzzzzzzzzzza_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

                return yzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
            };
            IEnumerable<Observation> vzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Where<Observation>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            object vzzzzzzzzzzzzzzzzzzzzzzzzzzzi_(Observation @this)
            {
                DataType yzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = @this?.Effective;
                object yzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.toInterval(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Start(yzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);

                return yzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
            };
            IEnumerable<Observation> vzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.SortBy<Observation>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, System.ComponentModel.ListSortDirection.Ascending);
            Observation vzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Last<Observation>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            List<Observation.ComponentComponent> vzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = vzzzzzzzzzzzzzzzzzzzzzzzzzzzk_?.Component;
            bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzm_(Observation.ComponentComponent @this)
            {
                CodeableConcept yzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = @this?.Code;
                List<Coding> yzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = yzzzzzzzzzzzzzzzzzzzzzzzzzzzl_?.Coding;
                Coding yzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.First<Coding>((IEnumerable<Coding>)yzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                FhirUri yzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = yzzzzzzzzzzzzzzzzzzzzzzzzzzzn_?.SystemElement;
                string yzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToString(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Equal(yzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, "http://loinc.org");
                List<Coding> yzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = yzzzzzzzzzzzzzzzzzzzzzzzzzzzl_?.Coding;
                Coding yzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.First<Coding>((IEnumerable<Coding>)yzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                Code yzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = yzzzzzzzzzzzzzzzzzzzzzzzzzzzt_?.CodeElement;
                string yzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToString(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Equal(yzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, "8480-6");
                bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.And(yzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);

                return yzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
            };
            IEnumerable<Observation.ComponentComponent> vzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)vzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            Observation.ComponentComponent vzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            DataType vzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = vzzzzzzzzzzzzzzzzzzzzzzzzzzzo_?.Value;
            object vzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            CqlQuantity vzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Quantity(130m, "mm[Hg]");
            CqlQuantity vzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Quantity(139m, "mm[Hg]");
            CqlInterval<CqlQuantity> vzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Interval(vzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, true, true);
            bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.In<CqlQuantity>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ as CqlQuantity, vzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, default);
            bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzw_(Observation BloodPressure)
            {
                DataType yzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = BloodPressure?.Effective;
                object yzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.toInterval(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.End(zzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                Period zzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.In<CqlDateTime>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, "day");
                Code<ObservationStatus> zzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = BloodPressure?.StatusElement;
                ObservationStatus? zzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = zzzzzzzzzzzzzzzzzzzzzzzzzzzzf_?.Value;
                string zzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Convert<string>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                string[] zzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.In<string>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ as IEnumerable<string>);
                bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.And(zzzzzzzzzzzzzzzzzzzzzzzzzzzze_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);

                return zzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
            };
            IEnumerable<Observation> vzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Where<Observation>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            object vzzzzzzzzzzzzzzzzzzzzzzzzzzzy_(Observation @this)
            {
                DataType zzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = @this?.Effective;
                object zzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.toInterval(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Start(zzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);

                return zzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
            };
            IEnumerable<Observation> vzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.SortBy<Observation>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, System.ComponentModel.ListSortDirection.Ascending);
            Observation wzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Last<Observation>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            List<Observation.ComponentComponent> wzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = wzzzzzzzzzzzzzzzzzzzzzzzzzzza_?.Component;
            bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzc_(Observation.ComponentComponent @this)
            {
                CodeableConcept zzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = @this?.Code;
                List<Coding> zzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = zzzzzzzzzzzzzzzzzzzzzzzzzzzzp_?.Coding;
                Coding zzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.First<Coding>((IEnumerable<Coding>)zzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                FhirUri zzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = zzzzzzzzzzzzzzzzzzzzzzzzzzzzr_?.SystemElement;
                string zzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToString(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Equal(zzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, "http://loinc.org");
                List<Coding> zzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = zzzzzzzzzzzzzzzzzzzzzzzzzzzzp_?.Coding;
                Coding zzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.First<Coding>((IEnumerable<Coding>)zzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                Code zzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = zzzzzzzzzzzzzzzzzzzzzzzzzzzzx_?.CodeElement;
                string zzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToString(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Equal(zzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, "8462-4");
                bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.And(zzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, azzzzzzzzzzzzzzzzzzzzzzzzzzzza_);

                return azzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
            };
            IEnumerable<Observation.ComponentComponent> wzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)wzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            Observation.ComponentComponent wzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            DataType wzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = wzzzzzzzzzzzzzzzzzzzzzzzzzzze_?.Value;
            object wzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            CqlQuantity wzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Quantity(80m, "mm[Hg]");
            CqlQuantity wzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Quantity(89m, "mm[Hg]");
            CqlInterval<CqlQuantity> wzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Interval(wzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, true, true);
            bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.In<CqlQuantity>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ as CqlQuantity, wzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, default);
            bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Or(vzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzn_(Observation BloodPressure)
            {
                DataType azzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = BloodPressure?.Effective;
                object azzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.toInterval(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.End(azzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                Period azzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.In<CqlDateTime>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, "day");
                Code<ObservationStatus> azzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = BloodPressure?.StatusElement;
                ObservationStatus? azzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = azzzzzzzzzzzzzzzzzzzzzzzzzzzzj_?.Value;
                string azzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Convert<string>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                string[] azzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.In<string>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ as IEnumerable<string>);
                bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.And(azzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);

                return azzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
            };
            IEnumerable<Observation> wzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<Observation>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            object wzzzzzzzzzzzzzzzzzzzzzzzzzzzp_(Observation @this)
            {
                DataType azzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = @this?.Effective;
                object azzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.toInterval(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Start(azzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);

                return azzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
            };
            IEnumerable<Observation> wzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.SortBy<Observation>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, System.ComponentModel.ListSortDirection.Ascending);
            Observation wzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Last<Observation>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            List<Observation.ComponentComponent> wzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = wzzzzzzzzzzzzzzzzzzzzzzzzzzzr_?.Component;
            bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzt_(Observation.ComponentComponent @this)
            {
                CodeableConcept azzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = @this?.Code;
                List<Coding> azzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = azzzzzzzzzzzzzzzzzzzzzzzzzzzzt_?.Coding;
                Coding azzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.First<Coding>((IEnumerable<Coding>)azzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                FhirUri azzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = azzzzzzzzzzzzzzzzzzzzzzzzzzzzv_?.SystemElement;
                string azzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToString(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Equal(azzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, "http://loinc.org");
                List<Coding> bzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = azzzzzzzzzzzzzzzzzzzzzzzzzzzzt_?.Coding;
                Coding bzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.First<Coding>((IEnumerable<Coding>)bzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                Code bzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = bzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_?.CodeElement;
                string bzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToString(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Equal(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, "8480-6");
                bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.And(azzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);

                return bzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
            };
            IEnumerable<Observation.ComponentComponent> wzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)wzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            Observation.ComponentComponent wzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            DataType wzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = wzzzzzzzzzzzzzzzzzzzzzzzzzzzv_?.Value;
            object wzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            CqlQuantity wzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Quantity(140m, "mm[Hg]");
            bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.GreaterOrEqual(wzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ as CqlQuantity, wzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzb_(Observation BloodPressure)
            {
                DataType bzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = BloodPressure?.Effective;
                object bzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.toInterval(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.End(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                Period bzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.In<CqlDateTime>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, "day");
                Code<ObservationStatus> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = BloodPressure?.StatusElement;
                ObservationStatus? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = bzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_?.Value;
                string bzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Convert<string>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                string[] bzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.In<string>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ as IEnumerable<string>);
                bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.And(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);

                return bzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
            };
            IEnumerable<Observation> xzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Where<Observation>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            object xzzzzzzzzzzzzzzzzzzzzzzzzzzzd_(Observation @this)
            {
                DataType bzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = @this?.Effective;
                object bzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.toInterval(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Start(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);

                return bzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
            };
            IEnumerable<Observation> xzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.SortBy<Observation>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, System.ComponentModel.ListSortDirection.Ascending);
            Observation xzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Last<Observation>(xzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            List<Observation.ComponentComponent> xzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = xzzzzzzzzzzzzzzzzzzzzzzzzzzzf_?.Component;
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzh_(Observation.ComponentComponent @this)
            {
                CodeableConcept bzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = @this?.Code;
                List<Coding> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = bzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_?.Coding;
                Coding bzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.First<Coding>((IEnumerable<Coding>)bzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                FhirUri czzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = bzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_?.SystemElement;
                string czzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToString(context, czzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Equal(czzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, "http://loinc.org");
                List<Coding> czzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = bzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_?.Coding;
                Coding czzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.First<Coding>((IEnumerable<Coding>)czzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                Code czzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = czzzzzzzzzzzzzzzzzzzzzzzzzzzzf_?.CodeElement;
                string czzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToString(context, czzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Equal(czzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, "8462-4");
                bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.And(czzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);

                return czzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
            };
            IEnumerable<Observation.ComponentComponent> xzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)xzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            Observation.ComponentComponent xzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            DataType xzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = xzzzzzzzzzzzzzzzzzzzzzzzzzzzj_?.Value;
            object xzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            CqlQuantity xzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Quantity(90m, "mm[Hg]");
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.GreaterOrEqual(xzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ as CqlQuantity, xzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Or(wzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Not(xzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.And(wzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Encounter_with_Hypertensive_Reading_Within_Year_Prior(context);
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Exists<Encounter>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.And(xzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);

            return xzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Where<Encounter>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);

        return vzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Laboratory Test or ECG for Hypertension")]
    public IEnumerable<ServiceRequest> Laboratory_Test_or_ECG_for_Hypertension(CqlContext context)
    {
        CqlCode czzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this._12_lead_EKG_panel(context);
        IEnumerable<CqlCode> czzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.ToList<CqlCode>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        IEnumerable<ServiceRequest> czzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, default, czzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        CqlCode czzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.EKG_study(context);
        IEnumerable<CqlCode> czzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.ToList<CqlCode>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        IEnumerable<ServiceRequest> czzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, default, czzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> czzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Union<ServiceRequest>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        CqlValueSet czzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Laboratory_Tests_for_Hypertension(context);
        IEnumerable<ServiceRequest> czzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> czzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Union<ServiceRequest>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzu_(ServiceRequest EKGLab)
        {
            Code<RequestIntent> czzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = EKGLab?.IntentElement;
            RequestIntent? czzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = czzzzzzzzzzzzzzzzzzzzzzzzzzzzw_?.Value;
            Code<RequestIntent> czzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Convert<Code<RequestIntent>>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Equivalent(czzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, "order");

            return czzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<ServiceRequest> czzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<ServiceRequest>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);

        return czzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Second Hypertensive Reading SBP 130 to 139 OR DBP 80 to 89 and Interventions")]
    public IEnumerable<ServiceRequest> Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89_and_Interventions(CqlContext context)
    {
        IEnumerable<ServiceRequest> dzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Follow_up_with_Rescreen_Within_6_Months(context);
        IEnumerable<ServiceRequest> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_(ServiceRequest Rescreen2to6)
        {
            IEnumerable<ServiceRequest> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Laboratory_Test_or_ECG_for_Hypertension(context);
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_(ServiceRequest LabECGIntervention)
            {
                FhirDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = Rescreen2to6?.AuthoredOnElement;
                CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Convert<CqlDateTime>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Measurement_Period(context);
                bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.In<CqlDateTime>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, "day");
                FhirDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = LabECGIntervention?.AuthoredOnElement;
                CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Convert<CqlDateTime>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.In<CqlDateTime>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, "day");
                bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.And(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);

                return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
            };
            IEnumerable<ServiceRequest> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Where<ServiceRequest>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            ServiceRequest dzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_(ServiceRequest LabECGIntervention) =>
                Rescreen2to6;
            IEnumerable<ServiceRequest> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Select<ServiceRequest, ServiceRequest>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);

            return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<ServiceRequest> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.SelectMany<ServiceRequest, ServiceRequest>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
        IEnumerable<ServiceRequest> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_(ServiceRequest Rescreen2to6)
        {
            IEnumerable<ServiceRequest> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.NonPharmacological_Interventions(context);
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_(ServiceRequest NonPharmSecondIntervention)
            {
                FhirDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = NonPharmSecondIntervention?.AuthoredOnElement;
                CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Convert<CqlDateTime>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Measurement_Period(context);
                bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.In<CqlDateTime>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzza_, "day");

                return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
            };
            IEnumerable<ServiceRequest> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<ServiceRequest>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            ServiceRequest dzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_(ServiceRequest NonPharmSecondIntervention) =>
                Rescreen2to6;
            IEnumerable<ServiceRequest> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Select<ServiceRequest, ServiceRequest>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);

            return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<ServiceRequest> dzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.SelectMany<ServiceRequest, ServiceRequest>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);

        return dzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Encounter with Second Hypertensive Reading SBP 130 to 139 OR DBP 80 to 89 and Interventions")]
    public IEnumerable<Encounter> Encounter_with_Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89_and_Interventions(CqlContext context)
    {
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Encounter_with_Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89(context);
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzd_(Encounter SecondHTNEncounterReading)
        {
            IEnumerable<ServiceRequest> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89_and_Interventions(context);
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzk_(ServiceRequest EncounterInterventions)
            {
                FhirDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = EncounterInterventions?.AuthoredOnElement;
                CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Convert<CqlDateTime>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                Period ezzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = SecondHTNEncounterReading?.Period;
                CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.In<CqlDateTime>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, "day");

                return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
            };
            IEnumerable<ServiceRequest> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<ServiceRequest>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            Encounter ezzzzzzzzzzzzzzzzzzzzzzzzzzzzm_(ServiceRequest EncounterInterventions) =>
                SecondHTNEncounterReading;
            IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Select<ServiceRequest, Encounter>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);

            return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.SelectMany<Encounter, Encounter>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzg_(Encounter SecondHTNEncounterReading)
        {
            IEnumerable<ServiceRequest> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Referral_to_Alternate_or_Primary_Healthcare_Professional_for_Hypertensive_Reading(context);
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzu_(ServiceRequest ReferralForHTN)
            {
                FhirDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = ReferralForHTN?.AuthoredOnElement;
                CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Convert<CqlDateTime>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                Period fzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = SecondHTNEncounterReading?.Period;
                CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.In<CqlDateTime>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, "day");

                return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
            };
            IEnumerable<ServiceRequest> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<ServiceRequest>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            Encounter ezzzzzzzzzzzzzzzzzzzzzzzzzzzzw_(ServiceRequest ReferralForHTN) =>
                SecondHTNEncounterReading;
            IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Select<ServiceRequest, Encounter>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);

            return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.SelectMany<Encounter, Encounter>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Union<Encounter>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzze_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);

        return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Encounter with Second Hypertensive Reading SBP Greater than or Equal to 140 OR DBP Greater than or Equal to 90")]
    public IEnumerable<Encounter> Encounter_with_Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90(CqlContext context)
    {
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Qualifying_Encounter_during_Measurement_Period(context);
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzze_(Encounter QualifyingEncounter)
        {
            IEnumerable<Observation> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/bp"));
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_(Observation BloodPressure)
            {
                DataType hzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = BloodPressure?.Effective;
                object hzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.toInterval(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.End(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                Period hzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.In<CqlDateTime>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, default);
                Code<ObservationStatus> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = BloodPressure?.StatusElement;
                ObservationStatus? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = hzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_?.Value;
                string hzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Convert<string>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                string[] izzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.In<string>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, izzzzzzzzzzzzzzzzzzzzzzzzzzzza_ as IEnumerable<string>);
                bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.And(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);

                return izzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
            };
            IEnumerable<Observation> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<Observation>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            object fzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_(Observation @this)
            {
                DataType izzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = @this?.Effective;
                object izzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.toInterval(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Start(izzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

                return izzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
            };
            IEnumerable<Observation> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.SortBy<Observation>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, System.ComponentModel.ListSortDirection.Ascending);
            Observation fzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Last<Observation>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            List<Observation.ComponentComponent> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = fzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_?.Component;
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_(Observation.ComponentComponent @this)
            {
                CodeableConcept izzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = @this?.Code;
                List<Coding> izzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = izzzzzzzzzzzzzzzzzzzzzzzzzzzzh_?.Coding;
                Coding izzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.First<Coding>((IEnumerable<Coding>)izzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                FhirUri izzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = izzzzzzzzzzzzzzzzzzzzzzzzzzzzj_?.SystemElement;
                string izzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToString(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Equal(izzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, "http://loinc.org");
                List<Coding> izzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = izzzzzzzzzzzzzzzzzzzzzzzzzzzzh_?.Coding;
                Coding izzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.First<Coding>((IEnumerable<Coding>)izzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                Code izzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = izzzzzzzzzzzzzzzzzzzzzzzzzzzzp_?.CodeElement;
                string izzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToString(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Equal(izzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, "8480-6");
                bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.And(izzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);

                return izzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
            };
            IEnumerable<Observation.ComponentComponent> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)fzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            Observation.ComponentComponent fzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            DataType fzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = fzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_?.Value;
            object fzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            CqlQuantity fzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Quantity(0m, "mm[Hg]");
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Greater(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ as CqlQuantity, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_(Observation BloodPressure)
            {
                DataType izzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = BloodPressure?.Effective;
                object izzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.toInterval(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.End(izzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                Period izzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.In<CqlDateTime>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, default);
                Code<ObservationStatus> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = BloodPressure?.StatusElement;
                ObservationStatus? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = jzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_?.Value;
                string jzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Convert<string>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                string[] jzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.In<string>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ as IEnumerable<string>);
                bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.And(jzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

                return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
            };
            IEnumerable<Observation> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Where<Observation>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            object fzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_(Observation @this)
            {
                DataType jzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = @this?.Effective;
                object jzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.toInterval(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Start(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);

                return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
            };
            IEnumerable<Observation> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.SortBy<Observation>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, System.ComponentModel.ListSortDirection.Ascending);
            Observation fzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Last<Observation>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            List<Observation.ComponentComponent> gzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = fzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_?.Component;
            bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_(Observation.ComponentComponent @this)
            {
                CodeableConcept jzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = @this?.Code;
                List<Coding> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = jzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_?.Coding;
                Coding jzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.First<Coding>((IEnumerable<Coding>)jzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                FhirUri jzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = jzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_?.SystemElement;
                string jzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToString(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Equal(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, "http://loinc.org");
                List<Coding> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = jzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_?.Coding;
                Coding jzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.First<Coding>((IEnumerable<Coding>)jzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                Code jzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = jzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_?.CodeElement;
                string jzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToString(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Equal(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, "8462-4");
                bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.And(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);

                return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
            };
            IEnumerable<Observation.ComponentComponent> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)gzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            Observation.ComponentComponent gzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            DataType gzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = gzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_?.Value;
            object gzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Greater(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ as CqlQuantity, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.And(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_(Observation BloodPressure)
            {
                DataType jzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = BloodPressure?.Effective;
                object jzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.toInterval(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.End(kzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                Period kzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.In<CqlDateTime>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, default);
                Code<ObservationStatus> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = BloodPressure?.StatusElement;
                ObservationStatus? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = kzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_?.Value;
                string kzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Convert<string>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                string[] kzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.In<string>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ as IEnumerable<string>);
                bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.And(kzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);

                return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
            };
            IEnumerable<Observation> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Observation>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            object gzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_(Observation @this)
            {
                DataType kzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = @this?.Effective;
                object kzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.toInterval(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Start(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);

                return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
            };
            IEnumerable<Observation> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.SortBy<Observation>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, System.ComponentModel.ListSortDirection.Ascending);
            Observation gzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Last<Observation>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            List<Observation.ComponentComponent> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = gzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_?.Component;
            bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_(Observation.ComponentComponent @this)
            {
                CodeableConcept kzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = @this?.Code;
                List<Coding> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = kzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_?.Coding;
                Coding kzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.First<Coding>((IEnumerable<Coding>)kzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                FhirUri kzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = kzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_?.SystemElement;
                string kzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToString(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Equal(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, "http://loinc.org");
                List<Coding> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = kzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_?.Coding;
                Coding kzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.First<Coding>((IEnumerable<Coding>)kzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                Code kzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = kzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_?.CodeElement;
                string kzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToString(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Equal(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, "8480-6");
                bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.And(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);

                return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
            };
            IEnumerable<Observation.ComponentComponent> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)gzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            Observation.ComponentComponent gzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            DataType gzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = gzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_?.Value;
            object gzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlQuantity gzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Quantity(140m, "mm[Hg]");
            bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.GreaterOrEqual(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ as CqlQuantity, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_(Observation BloodPressure)
            {
                DataType lzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = BloodPressure?.Effective;
                object lzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.toInterval(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.End(lzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                Period lzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.In<CqlDateTime>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, default);
                Code<ObservationStatus> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = BloodPressure?.StatusElement;
                ObservationStatus? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = lzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_?.Value;
                string lzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Convert<string>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                string[] lzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.In<string>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ as IEnumerable<string>);
                bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.And(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);

                return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
            };
            IEnumerable<Observation> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Where<Observation>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            object hzzzzzzzzzzzzzzzzzzzzzzzzzzzza_(Observation @this)
            {
                DataType lzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = @this?.Effective;
                object lzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.toInterval(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Start(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);

                return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
            };
            IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.SortBy<Observation>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, System.ComponentModel.ListSortDirection.Ascending);
            Observation hzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Last<Observation>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            List<Observation.ComponentComponent> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = hzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_?.Component;
            bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzze_(Observation.ComponentComponent @this)
            {
                CodeableConcept lzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = @this?.Code;
                List<Coding> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = lzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_?.Coding;
                Coding lzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.First<Coding>((IEnumerable<Coding>)lzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                FhirUri lzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = lzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_?.SystemElement;
                string lzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToString(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Equal(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, "http://loinc.org");
                List<Coding> mzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = lzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_?.Coding;
                Coding mzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.First<Coding>((IEnumerable<Coding>)mzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                Code mzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = mzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_?.CodeElement;
                string mzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToString(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Equal(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, "8462-4");
                bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.And(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);

                return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
            };
            IEnumerable<Observation.ComponentComponent> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)hzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            Observation.ComponentComponent hzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            DataType hzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = hzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_?.Value;
            object hzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            CqlQuantity hzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Quantity(90m, "mm[Hg]");
            bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.GreaterOrEqual(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ as CqlQuantity, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Or(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.And(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Encounter_with_Hypertensive_Reading_Within_Year_Prior(context);
            bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Exists<Encounter>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.And(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);

            return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Where<Encounter>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);

        return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Second Hypertensive Reading SBP Greater than or Equal to 140 OR DBP Greater than or Equal to 90 Interventions")]
    public IEnumerable<ServiceRequest> Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90_Interventions(CqlContext context)
    {
        CqlValueSet mzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Follow_Up_Within_4_Weeks(context);
        IEnumerable<ServiceRequest> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_(ServiceRequest WeeksRescreen)
        {
            IEnumerable<ServiceRequest> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Laboratory_Test_or_ECG_for_Hypertension(context);
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_(ServiceRequest ECGLabTest)
            {
                FhirDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = WeeksRescreen?.AuthoredOnElement;
                CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Convert<CqlDateTime>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Measurement_Period(context);
                bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.In<CqlDateTime>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, "day");
                FhirDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = ECGLabTest?.AuthoredOnElement;
                CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Convert<CqlDateTime>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.In<CqlDateTime>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, "day");
                bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.And(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                Code<RequestIntent> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = WeeksRescreen?.IntentElement;
                RequestIntent? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = nzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_?.Value;
                Code<RequestIntent> nzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Convert<Code<RequestIntent>>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Equivalent(nzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, "order");
                bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.And(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                Code<RequestIntent> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = ECGLabTest?.IntentElement;
                RequestIntent? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = nzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_?.Value;
                Code<RequestIntent> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Convert<Code<RequestIntent>>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Equivalent(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, "order");
                bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.And(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

                return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
            };
            IEnumerable<ServiceRequest> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Where<ServiceRequest>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            ServiceRequest mzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_(ServiceRequest ECGLabTest) =>
                WeeksRescreen;
            IEnumerable<ServiceRequest> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Select<ServiceRequest, ServiceRequest>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);

            return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<ServiceRequest> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.SelectMany<ServiceRequest, ServiceRequest>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        IEnumerable<ServiceRequest> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_(ServiceRequest WeeksRescreen)
        {
            IEnumerable<ServiceRequest> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.NonPharmacological_Interventions(context);
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_(ServiceRequest HTNInterventions)
            {
                FhirDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = HTNInterventions?.AuthoredOnElement;
                CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Convert<CqlDateTime>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Measurement_Period(context);
                bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.In<CqlDateTime>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, "day");

                return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
            };
            IEnumerable<ServiceRequest> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<ServiceRequest>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            ServiceRequest nzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_(ServiceRequest HTNInterventions) =>
                WeeksRescreen;
            IEnumerable<ServiceRequest> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Select<ServiceRequest, ServiceRequest>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

            return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<ServiceRequest> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.SelectMany<ServiceRequest, ServiceRequest>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        IEnumerable<ServiceRequest> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_(ServiceRequest WeeksRescreen)
        {
            CqlValueSet nzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Pharmacologic_Therapy_for_Hypertension(context);
            IEnumerable<MedicationRequest> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Union<MedicationRequest>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzza_(MedicationRequest Medications)
            {
                FhirDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = Medications?.AuthoredOnElement;
                CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Convert<CqlDateTime>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Measurement_Period(context);
                bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.In<CqlDateTime>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, "day");
                Code<MedicationRequest.MedicationrequestStatus> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = Medications?.StatusElement;
                MedicationRequest.MedicationrequestStatus? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = ozzzzzzzzzzzzzzzzzzzzzzzzzzzzi_?.Value;
                string ozzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Convert<string>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Equivalent(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, "active");
                bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);

                return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
            };
            IEnumerable<MedicationRequest> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Where<MedicationRequest>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            ServiceRequest ozzzzzzzzzzzzzzzzzzzzzzzzzzzzc_(MedicationRequest Medications) =>
                WeeksRescreen;
            IEnumerable<ServiceRequest> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Select<MedicationRequest, ServiceRequest>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);

            return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<ServiceRequest> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.SelectMany<ServiceRequest, ServiceRequest>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);

        return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Encounter with Second Hypertensive Reading SBP Greater than or Equal to 140 OR DBP Greater than or Equal to 90 and Interventions")]
    public IEnumerable<Encounter> Encounter_with_Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90_and_Interventions(CqlContext context)
    {
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Encounter_with_Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90(context);
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzo_(Encounter SecondHTNEncounterReading140Over90)
        {
            IEnumerable<ServiceRequest> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90_Interventions(context);
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzv_(ServiceRequest SecondHTN140Over90Interventions)
            {
                FhirDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = SecondHTN140Over90Interventions?.AuthoredOnElement;
                CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Convert<CqlDateTime>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                Period pzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = SecondHTNEncounterReading140Over90?.Period;
                CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.In<CqlDateTime>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, "day");

                return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
            };
            IEnumerable<ServiceRequest> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Where<ServiceRequest>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            Encounter ozzzzzzzzzzzzzzzzzzzzzzzzzzzzx_(ServiceRequest SecondHTN140Over90Interventions) =>
                SecondHTNEncounterReading140Over90;
            IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Select<ServiceRequest, Encounter>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);

            return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.SelectMany<Encounter, Encounter>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzr_(Encounter SecondHTNEncounterReading140Over90)
        {
            IEnumerable<ServiceRequest> pzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Referral_to_Alternate_or_Primary_Healthcare_Professional_for_Hypertensive_Reading(context);
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_(ServiceRequest ReferralToProfessional)
            {
                FhirDateTime pzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = ReferralToProfessional?.AuthoredOnElement;
                CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Convert<CqlDateTime>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                Period pzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = SecondHTNEncounterReading140Over90?.Period;
                CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.In<CqlDateTime>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, "day");

                return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
            };
            IEnumerable<ServiceRequest> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Where<ServiceRequest>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            Encounter pzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_(ServiceRequest ReferralToProfessional) =>
                SecondHTNEncounterReading140Over90;
            IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Select<ServiceRequest, Encounter>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);

            return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
        };
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.SelectMany<Encounter, Encounter>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Union<Encounter>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);

        return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context)
    {
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Encounter_with_Normal_Blood_Pressure_Reading(context);
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Encounter_with_Elevated_Blood_Pressure_Reading_SBP_120_to_129_AND_DBP_less_than_80_and_Interventions(context);
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Union<Encounter>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Encounter_with_First_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_130_OR_DBP_Greater_than_or_Equal_to_80_and_Interventions(context);
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Encounter_with_Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89_and_Interventions(context);
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Union<Encounter>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Union<Encounter>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Encounter_with_Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90_and_Interventions(context);
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Union<Encounter>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);

        return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Encounter with Medical Reason for Not Obtaining or Patient Declined Blood Pressure Measurement")]
    public IEnumerable<Encounter> Encounter_with_Medical_Reason_for_Not_Obtaining_or_Patient_Declined_Blood_Pressure_Measurement(CqlContext context)
    {
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Qualifying_Encounter_during_Measurement_Period(context);
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_(Encounter QualifyingEncounter)
        {
            CqlCode qzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Systolic_blood_pressure(context);
            IEnumerable<CqlCode> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.ToList<CqlCode>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            IEnumerable<Observation> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observationnotdone"));
            CqlCode qzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Diastolic_blood_pressure(context);
            IEnumerable<CqlCode> qzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.ToList<CqlCode>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            IEnumerable<Observation> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, qzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observationnotdone"));
            IEnumerable<Observation> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Union<Observation>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_(Observation NoBPScreen)
            {
                Instant qzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = NoBPScreen?.IssuedElement;
                DateTimeOffset? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = qzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_?.Value;
                CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Convert<CqlDateTime>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                Period qzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.In<CqlDateTime>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, "day");
                bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_(Extension @this)
                {
                    string rzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = @this?.Url;
                    FhirString rzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Convert<FhirString>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                    string rzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToString(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                    bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Equal(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-notDoneReason");

                    return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
                };
                IEnumerable<Extension> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(NoBPScreen is DomainResource
                        ? (NoBPScreen as DomainResource).Extension
                        : default), qzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                object qzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_(Extension @this)
                {
                    DataType rzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = @this?.Value;

                    return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
                };
                IEnumerable<object> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Select<Extension, object>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                object qzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.SingletonFrom<object>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                CqlConcept qzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ as CodeableConcept);
                CqlValueSet qzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Patient_Declined(context);
                bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.ConceptInValueSet(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_(Extension @this)
                {
                    string rzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = @this?.Url;
                    FhirString rzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Convert<FhirString>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                    string rzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToString(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                    bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Equal(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-notDoneReason");

                    return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
                };
                IEnumerable<Extension> rzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(NoBPScreen is DomainResource
                        ? (NoBPScreen as DomainResource).Extension
                        : default), qzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                object rzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_(Extension @this)
                {
                    DataType rzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = @this?.Value;

                    return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
                };
                IEnumerable<object> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Select<Extension, object>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                object rzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.SingletonFrom<object>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                CqlConcept rzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ as CodeableConcept);
                CqlValueSet rzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Medical_Reason(context);
                bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.ConceptInValueSet(rzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Or(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.And(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                Code<ObservationStatus> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = NoBPScreen?.StatusElement;
                ObservationStatus? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = rzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_?.Value;
                Code<ObservationStatus> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Convert<Code<ObservationStatus>>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Equal(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, "cancelled");
                bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.And(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);

                return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
            };
            IEnumerable<Observation> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<Observation>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            Encounter qzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_(Observation NoBPScreen) =>
                QualifyingEncounter;
            IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Select<Observation, Encounter>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);

            return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.SelectMany<Encounter, Encounter>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

        return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("NonPharmacological Intervention Not Ordered")]
    public IEnumerable<ServiceRequest> NonPharmacological_Intervention_Not_Ordered(CqlContext context)
    {
        CqlValueSet rzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Lifestyle_Recommendation(context);
        IEnumerable<ServiceRequest> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> szzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> szzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Union<ServiceRequest>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
        CqlValueSet szzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Weight_Reduction_Recommended(context);
        IEnumerable<ServiceRequest> szzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> szzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> szzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Union<ServiceRequest>(szzzzzzzzzzzzzzzzzzzzzzzzzzzze_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
        IEnumerable<ServiceRequest> szzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Union<ServiceRequest>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
        CqlValueSet szzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Dietary_Recommendations(context);
        IEnumerable<ServiceRequest> szzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> szzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> szzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Union<ServiceRequest>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        IEnumerable<ServiceRequest> szzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Union<ServiceRequest>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        CqlValueSet szzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Recommendation_to_Increase_Physical_Activity(context);
        IEnumerable<ServiceRequest> szzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> szzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> szzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Union<ServiceRequest>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        IEnumerable<ServiceRequest> szzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Union<ServiceRequest>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
        CqlValueSet szzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Referral_or_Counseling_for_Alcohol_Consumption(context);
        IEnumerable<ServiceRequest> szzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> szzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> szzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Union<ServiceRequest>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
        IEnumerable<ServiceRequest> tzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Union<ServiceRequest>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
        bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_(ServiceRequest NonPharmIntervention)
        {
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_(Extension @this)
            {
                string tzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = @this?.Url;
                FhirString tzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Convert<FhirString>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                string tzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToString(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Equal(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerformReason");

                return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
            };
            IEnumerable<Extension> tzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(NonPharmIntervention is DomainResource
                    ? (NonPharmIntervention as DomainResource).Extension
                    : default), tzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            object tzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_(Extension @this)
            {
                DataType tzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = @this?.Value;

                return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
            };
            IEnumerable<object> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Select<Extension, object>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            object tzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.SingletonFrom<object>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlConcept tzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ as CodeableConcept);
            CqlValueSet tzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Patient_Declined(context);
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.ConceptInValueSet(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            Code<RequestStatus> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = NonPharmIntervention?.StatusElement;
            RequestStatus? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = tzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_?.Value;
            Code<RequestStatus> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Convert<Code<RequestStatus>>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Equal(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, "completed");
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.And(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);

            return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<ServiceRequest> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Where<ServiceRequest>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);

        return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Laboratory Test or ECG for Hypertension Not Ordered")]
    public IEnumerable<ServiceRequest> Laboratory_Test_or_ECG_for_Hypertension_Not_Ordered(CqlContext context)
    {
        CqlCode tzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this._12_lead_EKG_panel(context);
        IEnumerable<CqlCode> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.ToList<CqlCode>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
        IEnumerable<ServiceRequest> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, default, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        CqlCode tzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.EKG_study(context);
        IEnumerable<CqlCode> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.ToList<CqlCode>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
        IEnumerable<ServiceRequest> uzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, default, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Union<ServiceRequest>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
        CqlValueSet uzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Laboratory_Tests_for_Hypertension(context);
        IEnumerable<ServiceRequest> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Union<ServiceRequest>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
        IEnumerable<ServiceRequest> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Union<ServiceRequest>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
        bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_(ServiceRequest LabECGNotDone)
        {
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_(Extension @this)
            {
                string uzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = @this?.Url;
                FhirString uzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Convert<FhirString>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                string uzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToString(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Equal(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerformReason");

                return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
            };
            IEnumerable<Extension> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(LabECGNotDone is DomainResource
                    ? (LabECGNotDone as DomainResource).Extension
                    : default), uzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            object uzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_(Extension @this)
            {
                DataType uzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = @this?.Value;

                return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
            };
            IEnumerable<object> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Select<Extension, object>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            object uzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.SingletonFrom<object>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlConcept uzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ as CodeableConcept);
            CqlValueSet uzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Patient_Declined(context);
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.ConceptInValueSet(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);

            return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<ServiceRequest> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Where<ServiceRequest>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);

        return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Second Hypertensive Reading SBP 130 to 139 OR DBP 80 to 89 Interventions Declined")]
    public IEnumerable<ServiceRequest> Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89_Interventions_Declined(CqlContext context)
    {
        CqlValueSet uzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Referral_to_Primary_Care_or_Alternate_Provider(context);
        IEnumerable<ServiceRequest> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> vzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Union<ServiceRequest>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
        CqlValueSet vzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Follow_Up_Within_6_Months(context);
        IEnumerable<ServiceRequest> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Union<ServiceRequest>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
        IEnumerable<ServiceRequest> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Union<ServiceRequest>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
        bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_(ServiceRequest SecondHTNDeclinedReferralAndFollowUp)
        {
            bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_(Extension @this)
            {
                string wzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = @this?.Url;
                FhirString wzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Convert<FhirString>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                string wzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToString(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Equal(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerformReason");

                return wzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
            };
            IEnumerable<Extension> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(SecondHTNDeclinedReferralAndFollowUp is DomainResource
                    ? (SecondHTNDeclinedReferralAndFollowUp as DomainResource).Extension
                    : default), vzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            object vzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_(Extension @this)
            {
                DataType wzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = @this?.Value;

                return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
            };
            IEnumerable<object> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Select<Extension, object>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            object vzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.SingletonFrom<object>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            CqlConcept vzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ as CodeableConcept);
            CqlValueSet vzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Patient_Declined(context);
            bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.ConceptInValueSet(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            Code<RequestStatus> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = SecondHTNDeclinedReferralAndFollowUp?.StatusElement;
            RequestStatus? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = vzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_?.Value;
            Code<RequestStatus> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Convert<Code<RequestStatus>>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Equal(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, "completed");
            bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.And(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

            return wzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<ServiceRequest> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Where<ServiceRequest>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        IEnumerable<ServiceRequest> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Laboratory_Test_or_ECG_for_Hypertension_Not_Ordered(context);
        IEnumerable<ServiceRequest> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Union<ServiceRequest>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        IEnumerable<ServiceRequest> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.NonPharmacological_Intervention_Not_Ordered(context);
        IEnumerable<ServiceRequest> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Union<ServiceRequest>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);

        return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Second Hypertensive Reading SBP Greater than or Equal to 140 OR DBP Greater than or Equal to 90 Interventions Declined")]
    public IEnumerable<object> Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90_Interventions_Declined(CqlContext context)
    {
        CqlValueSet wzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Referral_to_Primary_Care_or_Alternate_Provider(context);
        IEnumerable<ServiceRequest> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Union<ServiceRequest>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        CqlValueSet wzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Follow_Up_Within_4_Weeks(context);
        IEnumerable<ServiceRequest> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Union<ServiceRequest>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        IEnumerable<ServiceRequest> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Union<ServiceRequest>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_(ServiceRequest SecondHTN140Over90ReferralFollowUpNotDone)
        {
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_(Extension @this)
            {
                string xzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = @this?.Url;
                FhirString xzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Convert<FhirString>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                string xzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToString(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Equal(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerformReason");

                return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
            };
            IEnumerable<Extension> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(SecondHTN140Over90ReferralFollowUpNotDone is DomainResource
                    ? (SecondHTN140Over90ReferralFollowUpNotDone as DomainResource).Extension
                    : default), xzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            object xzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_(Extension @this)
            {
                DataType xzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = @this?.Value;

                return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
            };
            IEnumerable<object> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Select<Extension, object>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            object xzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.SingletonFrom<object>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlConcept xzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ as CodeableConcept);
            CqlValueSet xzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Patient_Declined(context);
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.ConceptInValueSet(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            Code<RequestStatus> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = SecondHTN140Over90ReferralFollowUpNotDone?.StatusElement;
            RequestStatus? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = xzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_?.Value;
            Code<RequestStatus> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Convert<Code<RequestStatus>>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Equal(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, "completed");
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.And(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);

            return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<ServiceRequest> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Where<ServiceRequest>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
        CqlValueSet wzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Pharmacologic_Therapy_for_Hypertension(context);
        IEnumerable<MedicationRequest> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-mednotrequested"));
        IEnumerable<MedicationRequest> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-mednotrequested"));
        IEnumerable<MedicationRequest> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Union<MedicationRequest>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
        bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_(MedicationRequest MedicationRequestNotOrdered)
        {
            Code<MedicationRequest.MedicationrequestStatus> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = MedicationRequestNotOrdered?.StatusElement;
            MedicationRequest.MedicationrequestStatus? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = xzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_?.Value;
            string xzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Convert<string>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Equal(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, "completed");

            return yzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<MedicationRequest> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Where<MedicationRequest>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
        IEnumerable<object> xzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Union<object>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ as IEnumerable<object>, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ as IEnumerable<object>);
        IEnumerable<ServiceRequest> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Laboratory_Test_or_ECG_for_Hypertension_Not_Ordered(context);
        IEnumerable<object> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Union<object>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ as IEnumerable<object>, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ as IEnumerable<object>);
        IEnumerable<ServiceRequest> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.NonPharmacological_Intervention_Not_Ordered(context);
        IEnumerable<object> xzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Union<object>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ as IEnumerable<object>, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ as IEnumerable<object>);

        return xzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Encounter with Order for Hypertension Follow Up Declined by Patient")]
    public IEnumerable<Encounter> Encounter_with_Order_for_Hypertension_Follow_Up_Declined_by_Patient(CqlContext context)
    {
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Encounter_with_Elevated_Blood_Pressure_Reading_SBP_120_to_129_AND_DBP_less_than_80(context);
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_(Encounter ElevatedBPEncounter)
        {
            CqlValueSet yzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Referral_to_Primary_Care_or_Alternate_Provider(context);
            IEnumerable<ServiceRequest> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
            IEnumerable<ServiceRequest> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
            IEnumerable<ServiceRequest> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Union<ServiceRequest>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            CqlValueSet zzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Follow_Up_Within_6_Months(context);
            IEnumerable<ServiceRequest> zzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
            IEnumerable<ServiceRequest> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
            IEnumerable<ServiceRequest> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Union<ServiceRequest>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            IEnumerable<ServiceRequest> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Union<ServiceRequest>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_(ServiceRequest ElevatedBPDeclinedInterventions)
            {
                bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_(Extension @this)
                {
                    string azzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = @this?.Url;
                    FhirString azzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Convert<FhirString>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                    string azzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToString(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                    bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Equal(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerformReason");

                    return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
                };
                IEnumerable<Extension> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(ElevatedBPDeclinedInterventions is DomainResource
                        ? (ElevatedBPDeclinedInterventions as DomainResource).Extension
                        : default), zzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                object zzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_(Extension @this)
                {
                    DataType azzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = @this?.Value;

                    return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
                };
                IEnumerable<object> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Select<Extension, object>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                object zzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.SingletonFrom<object>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                CqlConcept zzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ as CodeableConcept);
                CqlValueSet zzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Patient_Declined(context);
                bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.ConceptInValueSet(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                FhirDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = ElevatedBPDeclinedInterventions?.AuthoredOnElement;
                CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Convert<CqlDateTime>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                Period zzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = ElevatedBPEncounter?.Period;
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.In<CqlDateTime>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, "day");
                bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.And(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                Code<RequestStatus> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = ElevatedBPDeclinedInterventions?.StatusElement;
                RequestStatus? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = azzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_?.Value;
                Code<RequestStatus> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Convert<Code<RequestStatus>>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Equal(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, "completed");
                bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.And(azzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);

                return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
            };
            IEnumerable<ServiceRequest> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Where<ServiceRequest>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            Encounter zzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_(ServiceRequest ElevatedBPDeclinedInterventions) =>
                ElevatedBPEncounter;
            IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Select<ServiceRequest, Encounter>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);

            return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.SelectMany<Encounter, Encounter>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_(Encounter ElevatedBPEncounter)
        {
            IEnumerable<ServiceRequest> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.NonPharmacological_Intervention_Not_Ordered(context);
            bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_(ServiceRequest NotOrdered)
            {
                FhirDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = NotOrdered?.AuthoredOnElement;
                CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Convert<CqlDateTime>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                Period azzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = ElevatedBPEncounter?.Period;
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.In<CqlDateTime>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, "day");

                return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
            };
            IEnumerable<ServiceRequest> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Where<ServiceRequest>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            Encounter azzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_(ServiceRequest NotOrdered) =>
                ElevatedBPEncounter;
            IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Select<ServiceRequest, Encounter>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);

            return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.SelectMany<Encounter, Encounter>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Union<Encounter>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Encounter_with_First_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_130_OR_DBP_Greater_than_or_Equal_to_80(context);
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_(Encounter FirstHTNEncounter)
        {
            CqlValueSet azzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Follow_Up_Within_4_Weeks(context);
            IEnumerable<ServiceRequest> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
            IEnumerable<ServiceRequest> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
            IEnumerable<ServiceRequest> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Union<ServiceRequest>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            CqlValueSet bzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Referral_to_Primary_Care_or_Alternate_Provider(context);
            IEnumerable<ServiceRequest> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
            IEnumerable<ServiceRequest> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
            IEnumerable<ServiceRequest> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Union<ServiceRequest>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            IEnumerable<ServiceRequest> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Union<ServiceRequest>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_(ServiceRequest FirstHTNDeclinedInterventions)
            {
                bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_(Extension @this)
                {
                    string czzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = @this?.Url;
                    FhirString czzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Convert<FhirString>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                    string czzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToString(context, czzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                    bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Equal(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerformReason");

                    return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
                };
                IEnumerable<Extension> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(FirstHTNDeclinedInterventions is DomainResource
                        ? (FirstHTNDeclinedInterventions as DomainResource).Extension
                        : default), bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                object bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_(Extension @this)
                {
                    DataType czzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = @this?.Value;

                    return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
                };
                IEnumerable<object> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Select<Extension, object>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                object bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.SingletonFrom<object>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                CqlConcept bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ as CodeableConcept);
                CqlValueSet bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Patient_Declined(context);
                bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.ConceptInValueSet(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                FhirDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = FirstHTNDeclinedInterventions?.AuthoredOnElement;
                CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Convert<CqlDateTime>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                Period bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = FirstHTNEncounter?.Period;
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.In<CqlDateTime>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, "day");
                bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.And(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                Code<RequestStatus> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FirstHTNDeclinedInterventions?.StatusElement;
                RequestStatus? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_?.Value;
                Code<RequestStatus> czzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Convert<Code<RequestStatus>>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Equal(czzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, "completed");
                bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.And(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);

                return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
            };
            IEnumerable<ServiceRequest> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Where<ServiceRequest>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            Encounter bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_(ServiceRequest FirstHTNDeclinedInterventions) =>
                FirstHTNEncounter;
            IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Select<ServiceRequest, Encounter>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);

            return bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.SelectMany<Encounter, Encounter>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_(Encounter FirstHTNEncounter)
        {
            IEnumerable<ServiceRequest> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.NonPharmacological_Intervention_Not_Ordered(context);
            bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_(ServiceRequest NoNonPharm)
            {
                FhirDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = NoNonPharm?.AuthoredOnElement;
                CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Convert<CqlDateTime>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                Period czzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = FirstHTNEncounter?.Period;
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.In<CqlDateTime>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, "day");

                return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
            };
            IEnumerable<ServiceRequest> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Where<ServiceRequest>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            Encounter czzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_(ServiceRequest NoNonPharm) =>
                FirstHTNEncounter;
            IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Select<ServiceRequest, Encounter>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);

            return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.SelectMany<Encounter, Encounter>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Union<Encounter>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Union<Encounter>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Encounter_with_Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89(context);
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_(Encounter SecondHTNEncounter)
        {
            IEnumerable<ServiceRequest> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89_Interventions_Declined(context);
            bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_(ServiceRequest SecondHTNDeclinedInterventions)
            {
                FhirDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = SecondHTNDeclinedInterventions?.AuthoredOnElement;
                CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Convert<CqlDateTime>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                Period czzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = SecondHTNEncounter?.Period;
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.In<CqlDateTime>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, "day");

                return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
            };
            IEnumerable<ServiceRequest> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Where<ServiceRequest>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            Encounter czzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_(ServiceRequest SecondHTNDeclinedInterventions) =>
                SecondHTNEncounter;
            IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Select<ServiceRequest, Encounter>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);

            return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.SelectMany<Encounter, Encounter>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Encounter_with_Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90(context);
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_(Encounter SecondHTN140Over90Encounter)
        {
            IEnumerable<object> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90_Interventions_Declined(context);
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_(object SecondHTN140Over90DeclinedInterventions)
            {
                object dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.LateBoundProperty<object>(SecondHTN140Over90DeclinedInterventions, "authoredOn");
                CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.LateBoundProperty<CqlDateTime>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, "value");
                Period dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = SecondHTN140Over90Encounter?.Period;
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.In<CqlDateTime>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, "day");

                return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
            };
            IEnumerable<object> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Where<object>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            Encounter dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_(object SecondHTN140Over90DeclinedInterventions) =>
                SecondHTN140Over90Encounter;
            IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Select<object, Encounter>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

            return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.SelectMany<Encounter, Encounter>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Union<Encounter>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Union<Encounter>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);

        return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Denominator Exceptions")]
    public IEnumerable<Encounter> Denominator_Exceptions(CqlContext context)
    {
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Encounter_with_Medical_Reason_for_Not_Obtaining_or_Patient_Declined_Blood_Pressure_Measurement(context);
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Encounter_with_Order_for_Hypertension_Follow_Up_Declined_by_Patient(context);
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Union<Encounter>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);

        return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
    }


    #endregion Expressions

}
