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
    private static readonly CqlCode _Diastolic_blood_pressure = new CqlCode("8462-4", "http://loinc.org");

    [CqlCodeDefinition("12 lead EKG panel", codeId: "34534-8", codeSystem: "http://loinc.org")]
    public CqlCode _12_lead_EKG_panel(CqlContext _) => __12_lead_EKG_panel;
    private static readonly CqlCode __12_lead_EKG_panel = new CqlCode("34534-8", "http://loinc.org");

    [CqlCodeDefinition("EKG study", codeId: "11524-6", codeSystem: "http://loinc.org")]
    public CqlCode EKG_study(CqlContext _) => _EKG_study;
    private static readonly CqlCode _EKG_study = new CqlCode("11524-6", "http://loinc.org");

    [CqlCodeDefinition("Systolic blood pressure", codeId: "8480-6", codeSystem: "http://loinc.org")]
    public CqlCode Systolic_blood_pressure(CqlContext _) => _Systolic_blood_pressure;
    private static readonly CqlCode _Systolic_blood_pressure = new CqlCode("8480-6", "http://loinc.org");

    [CqlCodeDefinition("virtual", codeId: "VR", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-ActCode")]
    public CqlCode @virtual(CqlContext _) => _virtual;
    private static readonly CqlCode _virtual = new CqlCode("VR", "http://terminology.hl7.org/CodeSystem/v3-ActCode");

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("ActCode")]
    public CqlCodeSystem ActCode(CqlContext _) => _ActCode;
    private static readonly CqlCodeSystem _ActCode =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/v3-ActCode", null,
          _virtual);

    [CqlCodeSystemDefinition("LOINC")]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC =
      new CqlCodeSystem("http://loinc.org", null,
          _Diastolic_blood_pressure,
          __12_lead_EKG_panel,
          _EKG_study,
          _Systolic_blood_pressure);

    [CqlCodeSystemDefinition("SNOMEDCT")]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT =
      new CqlCodeSystem("http://snomed.info/sct", null);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime kzzzzzzzzzzzzzzzzz_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime lzzzzzzzzzzzzzzzza_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzb_ = context.Operators.Interval(kzzzzzzzzzzzzzzzzz_, lzzzzzzzzzzzzzzzza_, true, true);
        object lzzzzzzzzzzzzzzzzc_ = context.ResolveParameter("PCSBPScreeningFollowUpFHIR-0.2.000", "Measurement Period", lzzzzzzzzzzzzzzzzb_);

        return (CqlInterval<CqlDateTime>)lzzzzzzzzzzzzzzzzc_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> lzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient lzzzzzzzzzzzzzzzze_ = context.Operators.SingletonFrom<Patient>(lzzzzzzzzzzzzzzzzd_);

        return lzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Qualifying Encounter during Measurement Period")]
    public IEnumerable<Encounter> Qualifying_Encounter_during_Measurement_Period(CqlContext context)
    {
        CqlValueSet lzzzzzzzzzzzzzzzzf_ = this.Encounter_to_Screen_for_Blood_Pressure(context);
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, lzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? lzzzzzzzzzzzzzzzzh_(Encounter ValidEncounter)
        {
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzj_ = this.Measurement_Period(context);
            Period lzzzzzzzzzzzzzzzzk_ = ValidEncounter?.Period;
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzzzzzzzzzzzk_);
            bool? lzzzzzzzzzzzzzzzzm_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(lzzzzzzzzzzzzzzzzj_, lzzzzzzzzzzzzzzzzl_, "day");
            Code<Encounter.EncounterStatus> lzzzzzzzzzzzzzzzzn_ = ValidEncounter?.StatusElement;
            Encounter.EncounterStatus? lzzzzzzzzzzzzzzzzo_ = lzzzzzzzzzzzzzzzzn_?.Value;
            Code<Encounter.EncounterStatus> lzzzzzzzzzzzzzzzzp_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(lzzzzzzzzzzzzzzzzo_);
            bool? lzzzzzzzzzzzzzzzzq_ = context.Operators.Equivalent(lzzzzzzzzzzzzzzzzp_, "finished");
            bool? lzzzzzzzzzzzzzzzzr_ = context.Operators.And(lzzzzzzzzzzzzzzzzm_, lzzzzzzzzzzzzzzzzq_);
            Coding lzzzzzzzzzzzzzzzzs_ = ValidEncounter?.Class;
            CqlCode lzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToCode(context, lzzzzzzzzzzzzzzzzs_);
            CqlCode lzzzzzzzzzzzzzzzzu_ = this.@virtual(context);
            bool? lzzzzzzzzzzzzzzzzv_ = context.Operators.Equivalent(lzzzzzzzzzzzzzzzzt_, lzzzzzzzzzzzzzzzzu_);
            bool? lzzzzzzzzzzzzzzzzw_ = context.Operators.Not(lzzzzzzzzzzzzzzzzv_);
            bool? lzzzzzzzzzzzzzzzzx_ = context.Operators.And(lzzzzzzzzzzzzzzzzr_, lzzzzzzzzzzzzzzzzw_);

            return lzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzi_ = context.Operators.Where<Encounter>(lzzzzzzzzzzzzzzzzg_, lzzzzzzzzzzzzzzzzh_);

        return lzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzy_ = this.Qualifying_Encounter_during_Measurement_Period(context);
        bool? lzzzzzzzzzzzzzzzzz_(Encounter QualifyingEncounter)
        {
            Patient mzzzzzzzzzzzzzzzzb_ = this.Patient(context);
            Date mzzzzzzzzzzzzzzzzc_ = mzzzzzzzzzzzzzzzzb_?.BirthDateElement;
            string mzzzzzzzzzzzzzzzzd_ = mzzzzzzzzzzzzzzzzc_?.Value;
            CqlDateTime mzzzzzzzzzzzzzzzze_ = context.Operators.ConvertStringToDateTime(mzzzzzzzzzzzzzzzzd_);
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzf_ = this.Measurement_Period(context);
            CqlDateTime mzzzzzzzzzzzzzzzzg_ = context.Operators.Start(mzzzzzzzzzzzzzzzzf_);
            int? mzzzzzzzzzzzzzzzzh_ = context.Operators.CalculateAgeAt(mzzzzzzzzzzzzzzzze_, mzzzzzzzzzzzzzzzzg_, "year");
            bool? mzzzzzzzzzzzzzzzzi_ = context.Operators.GreaterOrEqual(mzzzzzzzzzzzzzzzzh_, 18);

            return mzzzzzzzzzzzzzzzzi_;
        };
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzza_ = context.Operators.Where<Encounter>(lzzzzzzzzzzzzzzzzy_, lzzzzzzzzzzzzzzzzz_);

        return mzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context)
    {
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzj_ = this.Initial_Population(context);

        return mzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public IEnumerable<Encounter> Denominator_Exclusions(CqlContext context)
    {
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzk_ = this.Qualifying_Encounter_during_Measurement_Period(context);
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzl_(Encounter QualifyingEncounter)
        {
            CqlValueSet mzzzzzzzzzzzzzzzzn_ = this.Diagnosis_of_Hypertension(context);
            IEnumerable<Condition> mzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, mzzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            bool? mzzzzzzzzzzzzzzzzp_(Condition Hypertension)
            {
                bool? mzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.isProblemListItem(context, Hypertension);
                bool? mzzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.isHealthConcern(context, Hypertension);
                bool? mzzzzzzzzzzzzzzzzv_ = context.Operators.Or(mzzzzzzzzzzzzzzzzt_, mzzzzzzzzzzzzzzzzu_);
                CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzw_()
                {
                    bool nzzzzzzzzzzzzzzzzb_()
                    {
                        CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, Hypertension);
                        CqlDateTime nzzzzzzzzzzzzzzzzd_ = context.Operators.Start(nzzzzzzzzzzzzzzzzc_);

                        return nzzzzzzzzzzzzzzzzd_ is null;
                    };
                    if (nzzzzzzzzzzzzzzzzb_())
                    {
                        return default;
                    }
                    else
                    {
                        CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, Hypertension);
                        CqlDateTime nzzzzzzzzzzzzzzzzf_ = context.Operators.Start(nzzzzzzzzzzzzzzzze_);
                        CqlDateTime nzzzzzzzzzzzzzzzzh_ = context.Operators.Start(nzzzzzzzzzzzzzzzze_);
                        CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzi_ = context.Operators.Interval(nzzzzzzzzzzzzzzzzf_, nzzzzzzzzzzzzzzzzh_, true, true);

                        return nzzzzzzzzzzzzzzzzi_;
                    }
                };
                Period mzzzzzzzzzzzzzzzzx_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzzzzzzzzzzzx_);
                bool? mzzzzzzzzzzzzzzzzz_ = context.Operators.SameOrBefore(mzzzzzzzzzzzzzzzzw_(), mzzzzzzzzzzzzzzzzy_, "day");
                bool? nzzzzzzzzzzzzzzzza_ = context.Operators.And(mzzzzzzzzzzzzzzzzv_, mzzzzzzzzzzzzzzzzz_);

                return nzzzzzzzzzzzzzzzza_;
            };
            IEnumerable<Condition> mzzzzzzzzzzzzzzzzq_ = context.Operators.Where<Condition>(mzzzzzzzzzzzzzzzzo_, mzzzzzzzzzzzzzzzzp_);
            Encounter mzzzzzzzzzzzzzzzzr_(Condition Hypertension) =>
                QualifyingEncounter;
            IEnumerable<Encounter> mzzzzzzzzzzzzzzzzs_ = context.Operators.Select<Condition, Encounter>(mzzzzzzzzzzzzzzzzq_, mzzzzzzzzzzzzzzzzr_);

            return mzzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzm_ = context.Operators.SelectMany<Encounter, Encounter>(mzzzzzzzzzzzzzzzzk_, mzzzzzzzzzzzzzzzzl_);

        return mzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Encounter with Normal Blood Pressure Reading")]
    public IEnumerable<Encounter> Encounter_with_Normal_Blood_Pressure_Reading(CqlContext context)
    {
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzj_ = this.Qualifying_Encounter_during_Measurement_Period(context);
        bool? nzzzzzzzzzzzzzzzzk_(Encounter QualifyingEncounter)
        {
            IEnumerable<Observation> nzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/bp"));
            bool? nzzzzzzzzzzzzzzzzn_(Observation BloodPressure)
            {
                DataType ozzzzzzzzzzzzzzzzt_ = BloodPressure?.Effective;
                object ozzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzt_);
                CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.toInterval(context, ozzzzzzzzzzzzzzzzu_);
                CqlDateTime ozzzzzzzzzzzzzzzzw_ = context.Operators.End(ozzzzzzzzzzzzzzzzv_);
                Period ozzzzzzzzzzzzzzzzx_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzzzzzzzzzzzzx_);
                bool? ozzzzzzzzzzzzzzzzz_ = context.Operators.In<CqlDateTime>(ozzzzzzzzzzzzzzzzw_, ozzzzzzzzzzzzzzzzy_, default);
                Code<ObservationStatus> pzzzzzzzzzzzzzzzza_ = BloodPressure?.StatusElement;
                ObservationStatus? pzzzzzzzzzzzzzzzzb_ = pzzzzzzzzzzzzzzzza_?.Value;
                string pzzzzzzzzzzzzzzzzc_ = context.Operators.Convert<string>(pzzzzzzzzzzzzzzzzb_);
                string[] pzzzzzzzzzzzzzzzzd_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? pzzzzzzzzzzzzzzzze_ = context.Operators.In<string>(pzzzzzzzzzzzzzzzzc_, pzzzzzzzzzzzzzzzzd_ as IEnumerable<string>);
                bool? pzzzzzzzzzzzzzzzzf_ = context.Operators.And(ozzzzzzzzzzzzzzzzz_, pzzzzzzzzzzzzzzzze_);

                return pzzzzzzzzzzzzzzzzf_;
            };
            IEnumerable<Observation> nzzzzzzzzzzzzzzzzo_ = context.Operators.Where<Observation>(nzzzzzzzzzzzzzzzzm_, nzzzzzzzzzzzzzzzzn_);
            object nzzzzzzzzzzzzzzzzp_(Observation @this)
            {
                DataType pzzzzzzzzzzzzzzzzg_ = @this?.Effective;
                object pzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzg_);
                CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.toInterval(context, pzzzzzzzzzzzzzzzzh_);
                CqlDateTime pzzzzzzzzzzzzzzzzj_ = context.Operators.Start(pzzzzzzzzzzzzzzzzi_);

                return pzzzzzzzzzzzzzzzzj_;
            };
            IEnumerable<Observation> nzzzzzzzzzzzzzzzzq_ = context.Operators.SortBy<Observation>(nzzzzzzzzzzzzzzzzo_, nzzzzzzzzzzzzzzzzp_, System.ComponentModel.ListSortDirection.Ascending);
            Observation nzzzzzzzzzzzzzzzzr_ = context.Operators.Last<Observation>(nzzzzzzzzzzzzzzzzq_);
            List<Observation.ComponentComponent> nzzzzzzzzzzzzzzzzs_ = nzzzzzzzzzzzzzzzzr_?.Component;
            bool? nzzzzzzzzzzzzzzzzt_(Observation.ComponentComponent @this)
            {
                CodeableConcept pzzzzzzzzzzzzzzzzk_ = @this?.Code;
                List<Coding> pzzzzzzzzzzzzzzzzl_ = pzzzzzzzzzzzzzzzzk_?.Coding;
                Coding pzzzzzzzzzzzzzzzzm_ = context.Operators.First<Coding>((IEnumerable<Coding>)pzzzzzzzzzzzzzzzzl_);
                FhirUri pzzzzzzzzzzzzzzzzn_ = pzzzzzzzzzzzzzzzzm_?.SystemElement;
                string pzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToString(context, pzzzzzzzzzzzzzzzzn_);
                bool? pzzzzzzzzzzzzzzzzp_ = context.Operators.Equal(pzzzzzzzzzzzzzzzzo_, "http://loinc.org");
                List<Coding> pzzzzzzzzzzzzzzzzr_ = pzzzzzzzzzzzzzzzzk_?.Coding;
                Coding pzzzzzzzzzzzzzzzzs_ = context.Operators.First<Coding>((IEnumerable<Coding>)pzzzzzzzzzzzzzzzzr_);
                Code pzzzzzzzzzzzzzzzzt_ = pzzzzzzzzzzzzzzzzs_?.CodeElement;
                string pzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToString(context, pzzzzzzzzzzzzzzzzt_);
                bool? pzzzzzzzzzzzzzzzzv_ = context.Operators.Equal(pzzzzzzzzzzzzzzzzu_, "8480-6");
                bool? pzzzzzzzzzzzzzzzzw_ = context.Operators.And(pzzzzzzzzzzzzzzzzp_, pzzzzzzzzzzzzzzzzv_);

                return pzzzzzzzzzzzzzzzzw_;
            };
            IEnumerable<Observation.ComponentComponent> nzzzzzzzzzzzzzzzzu_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)nzzzzzzzzzzzzzzzzs_, nzzzzzzzzzzzzzzzzt_);
            Observation.ComponentComponent nzzzzzzzzzzzzzzzzv_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(nzzzzzzzzzzzzzzzzu_);
            DataType nzzzzzzzzzzzzzzzzw_ = nzzzzzzzzzzzzzzzzv_?.Value;
            object nzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzw_);
            CqlQuantity nzzzzzzzzzzzzzzzzy_ = context.Operators.Quantity(1m, "mm[Hg]");
            CqlQuantity nzzzzzzzzzzzzzzzzz_ = context.Operators.Quantity(120m, "mm[Hg]");
            CqlInterval<CqlQuantity> ozzzzzzzzzzzzzzzza_ = context.Operators.Interval(nzzzzzzzzzzzzzzzzy_, nzzzzzzzzzzzzzzzzz_, true, false);
            bool? ozzzzzzzzzzzzzzzzb_ = context.Operators.In<CqlQuantity>(nzzzzzzzzzzzzzzzzx_ as CqlQuantity, ozzzzzzzzzzzzzzzza_, default);
            bool? ozzzzzzzzzzzzzzzzd_(Observation BloodPressure)
            {
                DataType pzzzzzzzzzzzzzzzzx_ = BloodPressure?.Effective;
                object pzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzx_);
                CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.toInterval(context, pzzzzzzzzzzzzzzzzy_);
                CqlDateTime qzzzzzzzzzzzzzzzza_ = context.Operators.End(pzzzzzzzzzzzzzzzzz_);
                Period qzzzzzzzzzzzzzzzzb_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzzzzzzzzzzzzb_);
                bool? qzzzzzzzzzzzzzzzzd_ = context.Operators.In<CqlDateTime>(qzzzzzzzzzzzzzzzza_, qzzzzzzzzzzzzzzzzc_, default);
                Code<ObservationStatus> qzzzzzzzzzzzzzzzze_ = BloodPressure?.StatusElement;
                ObservationStatus? qzzzzzzzzzzzzzzzzf_ = qzzzzzzzzzzzzzzzze_?.Value;
                string qzzzzzzzzzzzzzzzzg_ = context.Operators.Convert<string>(qzzzzzzzzzzzzzzzzf_);
                string[] qzzzzzzzzzzzzzzzzh_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? qzzzzzzzzzzzzzzzzi_ = context.Operators.In<string>(qzzzzzzzzzzzzzzzzg_, qzzzzzzzzzzzzzzzzh_ as IEnumerable<string>);
                bool? qzzzzzzzzzzzzzzzzj_ = context.Operators.And(qzzzzzzzzzzzzzzzzd_, qzzzzzzzzzzzzzzzzi_);

                return qzzzzzzzzzzzzzzzzj_;
            };
            IEnumerable<Observation> ozzzzzzzzzzzzzzzze_ = context.Operators.Where<Observation>(nzzzzzzzzzzzzzzzzm_, ozzzzzzzzzzzzzzzzd_);
            object ozzzzzzzzzzzzzzzzf_(Observation @this)
            {
                DataType qzzzzzzzzzzzzzzzzk_ = @this?.Effective;
                object qzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzk_);
                CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.toInterval(context, qzzzzzzzzzzzzzzzzl_);
                CqlDateTime qzzzzzzzzzzzzzzzzn_ = context.Operators.Start(qzzzzzzzzzzzzzzzzm_);

                return qzzzzzzzzzzzzzzzzn_;
            };
            IEnumerable<Observation> ozzzzzzzzzzzzzzzzg_ = context.Operators.SortBy<Observation>(ozzzzzzzzzzzzzzzze_, ozzzzzzzzzzzzzzzzf_, System.ComponentModel.ListSortDirection.Ascending);
            Observation ozzzzzzzzzzzzzzzzh_ = context.Operators.Last<Observation>(ozzzzzzzzzzzzzzzzg_);
            List<Observation.ComponentComponent> ozzzzzzzzzzzzzzzzi_ = ozzzzzzzzzzzzzzzzh_?.Component;
            bool? ozzzzzzzzzzzzzzzzj_(Observation.ComponentComponent @this)
            {
                CodeableConcept qzzzzzzzzzzzzzzzzo_ = @this?.Code;
                List<Coding> qzzzzzzzzzzzzzzzzp_ = qzzzzzzzzzzzzzzzzo_?.Coding;
                Coding qzzzzzzzzzzzzzzzzq_ = context.Operators.First<Coding>((IEnumerable<Coding>)qzzzzzzzzzzzzzzzzp_);
                FhirUri qzzzzzzzzzzzzzzzzr_ = qzzzzzzzzzzzzzzzzq_?.SystemElement;
                string qzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToString(context, qzzzzzzzzzzzzzzzzr_);
                bool? qzzzzzzzzzzzzzzzzt_ = context.Operators.Equal(qzzzzzzzzzzzzzzzzs_, "http://loinc.org");
                List<Coding> qzzzzzzzzzzzzzzzzv_ = qzzzzzzzzzzzzzzzzo_?.Coding;
                Coding qzzzzzzzzzzzzzzzzw_ = context.Operators.First<Coding>((IEnumerable<Coding>)qzzzzzzzzzzzzzzzzv_);
                Code qzzzzzzzzzzzzzzzzx_ = qzzzzzzzzzzzzzzzzw_?.CodeElement;
                string qzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToString(context, qzzzzzzzzzzzzzzzzx_);
                bool? qzzzzzzzzzzzzzzzzz_ = context.Operators.Equal(qzzzzzzzzzzzzzzzzy_, "8462-4");
                bool? rzzzzzzzzzzzzzzzza_ = context.Operators.And(qzzzzzzzzzzzzzzzzt_, qzzzzzzzzzzzzzzzzz_);

                return rzzzzzzzzzzzzzzzza_;
            };
            IEnumerable<Observation.ComponentComponent> ozzzzzzzzzzzzzzzzk_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)ozzzzzzzzzzzzzzzzi_, ozzzzzzzzzzzzzzzzj_);
            Observation.ComponentComponent ozzzzzzzzzzzzzzzzl_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(ozzzzzzzzzzzzzzzzk_);
            DataType ozzzzzzzzzzzzzzzzm_ = ozzzzzzzzzzzzzzzzl_?.Value;
            object ozzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzm_);
            CqlQuantity ozzzzzzzzzzzzzzzzp_ = context.Operators.Quantity(80m, "mm[Hg]");
            CqlInterval<CqlQuantity> ozzzzzzzzzzzzzzzzq_ = context.Operators.Interval(nzzzzzzzzzzzzzzzzy_, ozzzzzzzzzzzzzzzzp_, true, false);
            bool? ozzzzzzzzzzzzzzzzr_ = context.Operators.In<CqlQuantity>(ozzzzzzzzzzzzzzzzn_ as CqlQuantity, ozzzzzzzzzzzzzzzzq_, default);
            bool? ozzzzzzzzzzzzzzzzs_ = context.Operators.And(ozzzzzzzzzzzzzzzzb_, ozzzzzzzzzzzzzzzzr_);

            return ozzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Encounter>(nzzzzzzzzzzzzzzzzj_, nzzzzzzzzzzzzzzzzk_);

        return nzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Encounter with Elevated Blood Pressure Reading SBP 120 to 129 AND DBP less than 80")]
    public IEnumerable<Encounter> Encounter_with_Elevated_Blood_Pressure_Reading_SBP_120_to_129_AND_DBP_less_than_80(CqlContext context)
    {
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzb_ = this.Qualifying_Encounter_during_Measurement_Period(context);
        bool? rzzzzzzzzzzzzzzzzc_(Encounter QualifyingEncounter)
        {
            IEnumerable<Observation> rzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/bp"));
            bool? rzzzzzzzzzzzzzzzzf_(Observation BloodPressure)
            {
                DataType szzzzzzzzzzzzzzzzl_ = BloodPressure?.Effective;
                object szzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzl_);
                CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.toInterval(context, szzzzzzzzzzzzzzzzm_);
                CqlDateTime szzzzzzzzzzzzzzzzo_ = context.Operators.End(szzzzzzzzzzzzzzzzn_);
                Period szzzzzzzzzzzzzzzzp_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzzzzzzzzzzzzzp_);
                bool? szzzzzzzzzzzzzzzzr_ = context.Operators.In<CqlDateTime>(szzzzzzzzzzzzzzzzo_, szzzzzzzzzzzzzzzzq_, default);
                Code<ObservationStatus> szzzzzzzzzzzzzzzzs_ = BloodPressure?.StatusElement;
                ObservationStatus? szzzzzzzzzzzzzzzzt_ = szzzzzzzzzzzzzzzzs_?.Value;
                string szzzzzzzzzzzzzzzzu_ = context.Operators.Convert<string>(szzzzzzzzzzzzzzzzt_);
                string[] szzzzzzzzzzzzzzzzv_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? szzzzzzzzzzzzzzzzw_ = context.Operators.In<string>(szzzzzzzzzzzzzzzzu_, szzzzzzzzzzzzzzzzv_ as IEnumerable<string>);
                bool? szzzzzzzzzzzzzzzzx_ = context.Operators.And(szzzzzzzzzzzzzzzzr_, szzzzzzzzzzzzzzzzw_);

                return szzzzzzzzzzzzzzzzx_;
            };
            IEnumerable<Observation> rzzzzzzzzzzzzzzzzg_ = context.Operators.Where<Observation>(rzzzzzzzzzzzzzzzze_, rzzzzzzzzzzzzzzzzf_);
            object rzzzzzzzzzzzzzzzzh_(Observation @this)
            {
                DataType szzzzzzzzzzzzzzzzy_ = @this?.Effective;
                object szzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzy_);
                CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.toInterval(context, szzzzzzzzzzzzzzzzz_);
                CqlDateTime tzzzzzzzzzzzzzzzzb_ = context.Operators.Start(tzzzzzzzzzzzzzzzza_);

                return tzzzzzzzzzzzzzzzzb_;
            };
            IEnumerable<Observation> rzzzzzzzzzzzzzzzzi_ = context.Operators.SortBy<Observation>(rzzzzzzzzzzzzzzzzg_, rzzzzzzzzzzzzzzzzh_, System.ComponentModel.ListSortDirection.Ascending);
            Observation rzzzzzzzzzzzzzzzzj_ = context.Operators.Last<Observation>(rzzzzzzzzzzzzzzzzi_);
            List<Observation.ComponentComponent> rzzzzzzzzzzzzzzzzk_ = rzzzzzzzzzzzzzzzzj_?.Component;
            bool? rzzzzzzzzzzzzzzzzl_(Observation.ComponentComponent @this)
            {
                CodeableConcept tzzzzzzzzzzzzzzzzc_ = @this?.Code;
                List<Coding> tzzzzzzzzzzzzzzzzd_ = tzzzzzzzzzzzzzzzzc_?.Coding;
                Coding tzzzzzzzzzzzzzzzze_ = context.Operators.First<Coding>((IEnumerable<Coding>)tzzzzzzzzzzzzzzzzd_);
                FhirUri tzzzzzzzzzzzzzzzzf_ = tzzzzzzzzzzzzzzzze_?.SystemElement;
                string tzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToString(context, tzzzzzzzzzzzzzzzzf_);
                bool? tzzzzzzzzzzzzzzzzh_ = context.Operators.Equal(tzzzzzzzzzzzzzzzzg_, "http://loinc.org");
                List<Coding> tzzzzzzzzzzzzzzzzj_ = tzzzzzzzzzzzzzzzzc_?.Coding;
                Coding tzzzzzzzzzzzzzzzzk_ = context.Operators.First<Coding>((IEnumerable<Coding>)tzzzzzzzzzzzzzzzzj_);
                Code tzzzzzzzzzzzzzzzzl_ = tzzzzzzzzzzzzzzzzk_?.CodeElement;
                string tzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToString(context, tzzzzzzzzzzzzzzzzl_);
                bool? tzzzzzzzzzzzzzzzzn_ = context.Operators.Equal(tzzzzzzzzzzzzzzzzm_, "8480-6");
                bool? tzzzzzzzzzzzzzzzzo_ = context.Operators.And(tzzzzzzzzzzzzzzzzh_, tzzzzzzzzzzzzzzzzn_);

                return tzzzzzzzzzzzzzzzzo_;
            };
            IEnumerable<Observation.ComponentComponent> rzzzzzzzzzzzzzzzzm_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)rzzzzzzzzzzzzzzzzk_, rzzzzzzzzzzzzzzzzl_);
            Observation.ComponentComponent rzzzzzzzzzzzzzzzzn_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(rzzzzzzzzzzzzzzzzm_);
            DataType rzzzzzzzzzzzzzzzzo_ = rzzzzzzzzzzzzzzzzn_?.Value;
            object rzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzo_);
            CqlQuantity rzzzzzzzzzzzzzzzzq_ = context.Operators.Quantity(120m, "mm[Hg]");
            CqlQuantity rzzzzzzzzzzzzzzzzr_ = context.Operators.Quantity(129m, "mm[Hg]");
            CqlInterval<CqlQuantity> rzzzzzzzzzzzzzzzzs_ = context.Operators.Interval(rzzzzzzzzzzzzzzzzq_, rzzzzzzzzzzzzzzzzr_, true, true);
            bool? rzzzzzzzzzzzzzzzzt_ = context.Operators.In<CqlQuantity>(rzzzzzzzzzzzzzzzzp_ as CqlQuantity, rzzzzzzzzzzzzzzzzs_, default);
            bool? rzzzzzzzzzzzzzzzzv_(Observation BloodPressure)
            {
                DataType tzzzzzzzzzzzzzzzzp_ = BloodPressure?.Effective;
                object tzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzp_);
                CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.toInterval(context, tzzzzzzzzzzzzzzzzq_);
                CqlDateTime tzzzzzzzzzzzzzzzzs_ = context.Operators.End(tzzzzzzzzzzzzzzzzr_);
                Period tzzzzzzzzzzzzzzzzt_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzzzzzzzzzzzzzt_);
                bool? tzzzzzzzzzzzzzzzzv_ = context.Operators.In<CqlDateTime>(tzzzzzzzzzzzzzzzzs_, tzzzzzzzzzzzzzzzzu_, default);
                Code<ObservationStatus> tzzzzzzzzzzzzzzzzw_ = BloodPressure?.StatusElement;
                ObservationStatus? tzzzzzzzzzzzzzzzzx_ = tzzzzzzzzzzzzzzzzw_?.Value;
                string tzzzzzzzzzzzzzzzzy_ = context.Operators.Convert<string>(tzzzzzzzzzzzzzzzzx_);
                string[] tzzzzzzzzzzzzzzzzz_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? uzzzzzzzzzzzzzzzza_ = context.Operators.In<string>(tzzzzzzzzzzzzzzzzy_, tzzzzzzzzzzzzzzzzz_ as IEnumerable<string>);
                bool? uzzzzzzzzzzzzzzzzb_ = context.Operators.And(tzzzzzzzzzzzzzzzzv_, uzzzzzzzzzzzzzzzza_);

                return uzzzzzzzzzzzzzzzzb_;
            };
            IEnumerable<Observation> rzzzzzzzzzzzzzzzzw_ = context.Operators.Where<Observation>(rzzzzzzzzzzzzzzzze_, rzzzzzzzzzzzzzzzzv_);
            object rzzzzzzzzzzzzzzzzx_(Observation @this)
            {
                DataType uzzzzzzzzzzzzzzzzc_ = @this?.Effective;
                object uzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzc_);
                CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.toInterval(context, uzzzzzzzzzzzzzzzzd_);
                CqlDateTime uzzzzzzzzzzzzzzzzf_ = context.Operators.Start(uzzzzzzzzzzzzzzzze_);

                return uzzzzzzzzzzzzzzzzf_;
            };
            IEnumerable<Observation> rzzzzzzzzzzzzzzzzy_ = context.Operators.SortBy<Observation>(rzzzzzzzzzzzzzzzzw_, rzzzzzzzzzzzzzzzzx_, System.ComponentModel.ListSortDirection.Ascending);
            Observation rzzzzzzzzzzzzzzzzz_ = context.Operators.Last<Observation>(rzzzzzzzzzzzzzzzzy_);
            List<Observation.ComponentComponent> szzzzzzzzzzzzzzzza_ = rzzzzzzzzzzzzzzzzz_?.Component;
            bool? szzzzzzzzzzzzzzzzb_(Observation.ComponentComponent @this)
            {
                CodeableConcept uzzzzzzzzzzzzzzzzg_ = @this?.Code;
                List<Coding> uzzzzzzzzzzzzzzzzh_ = uzzzzzzzzzzzzzzzzg_?.Coding;
                Coding uzzzzzzzzzzzzzzzzi_ = context.Operators.First<Coding>((IEnumerable<Coding>)uzzzzzzzzzzzzzzzzh_);
                FhirUri uzzzzzzzzzzzzzzzzj_ = uzzzzzzzzzzzzzzzzi_?.SystemElement;
                string uzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToString(context, uzzzzzzzzzzzzzzzzj_);
                bool? uzzzzzzzzzzzzzzzzl_ = context.Operators.Equal(uzzzzzzzzzzzzzzzzk_, "http://loinc.org");
                List<Coding> uzzzzzzzzzzzzzzzzn_ = uzzzzzzzzzzzzzzzzg_?.Coding;
                Coding uzzzzzzzzzzzzzzzzo_ = context.Operators.First<Coding>((IEnumerable<Coding>)uzzzzzzzzzzzzzzzzn_);
                Code uzzzzzzzzzzzzzzzzp_ = uzzzzzzzzzzzzzzzzo_?.CodeElement;
                string uzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToString(context, uzzzzzzzzzzzzzzzzp_);
                bool? uzzzzzzzzzzzzzzzzr_ = context.Operators.Equal(uzzzzzzzzzzzzzzzzq_, "8462-4");
                bool? uzzzzzzzzzzzzzzzzs_ = context.Operators.And(uzzzzzzzzzzzzzzzzl_, uzzzzzzzzzzzzzzzzr_);

                return uzzzzzzzzzzzzzzzzs_;
            };
            IEnumerable<Observation.ComponentComponent> szzzzzzzzzzzzzzzzc_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)szzzzzzzzzzzzzzzza_, szzzzzzzzzzzzzzzzb_);
            Observation.ComponentComponent szzzzzzzzzzzzzzzzd_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(szzzzzzzzzzzzzzzzc_);
            DataType szzzzzzzzzzzzzzzze_ = szzzzzzzzzzzzzzzzd_?.Value;
            object szzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzze_);
            CqlQuantity szzzzzzzzzzzzzzzzg_ = context.Operators.Quantity(1m, "mm[Hg]");
            CqlQuantity szzzzzzzzzzzzzzzzh_ = context.Operators.Quantity(80m, "mm[Hg]");
            CqlInterval<CqlQuantity> szzzzzzzzzzzzzzzzi_ = context.Operators.Interval(szzzzzzzzzzzzzzzzg_, szzzzzzzzzzzzzzzzh_, true, false);
            bool? szzzzzzzzzzzzzzzzj_ = context.Operators.In<CqlQuantity>(szzzzzzzzzzzzzzzzf_ as CqlQuantity, szzzzzzzzzzzzzzzzi_, default);
            bool? szzzzzzzzzzzzzzzzk_ = context.Operators.And(rzzzzzzzzzzzzzzzzt_, szzzzzzzzzzzzzzzzj_);

            return szzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzd_ = context.Operators.Where<Encounter>(rzzzzzzzzzzzzzzzzb_, rzzzzzzzzzzzzzzzzc_);

        return rzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Follow up with Rescreen Within 6 Months")]
    public IEnumerable<ServiceRequest> Follow_up_with_Rescreen_Within_6_Months(CqlContext context)
    {
        CqlValueSet uzzzzzzzzzzzzzzzzt_ = this.Follow_Up_Within_6_Months(context);
        IEnumerable<ServiceRequest> uzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        bool? uzzzzzzzzzzzzzzzzv_(ServiceRequest FollowUp)
        {
            Code<RequestIntent> uzzzzzzzzzzzzzzzzx_ = FollowUp?.IntentElement;
            RequestIntent? uzzzzzzzzzzzzzzzzy_ = uzzzzzzzzzzzzzzzzx_?.Value;
            Code<RequestIntent> uzzzzzzzzzzzzzzzzz_ = context.Operators.Convert<Code<RequestIntent>>(uzzzzzzzzzzzzzzzzy_);
            bool? vzzzzzzzzzzzzzzzza_ = context.Operators.Equivalent(uzzzzzzzzzzzzzzzzz_, "order");

            return vzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<ServiceRequest> uzzzzzzzzzzzzzzzzw_ = context.Operators.Where<ServiceRequest>(uzzzzzzzzzzzzzzzzu_, uzzzzzzzzzzzzzzzzv_);

        return uzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("NonPharmacological Interventions")]
    public IEnumerable<ServiceRequest> NonPharmacological_Interventions(CqlContext context)
    {
        CqlValueSet vzzzzzzzzzzzzzzzzb_ = this.Lifestyle_Recommendation(context);
        IEnumerable<ServiceRequest> vzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        CqlValueSet vzzzzzzzzzzzzzzzzd_ = this.Weight_Reduction_Recommended(context);
        IEnumerable<ServiceRequest> vzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> vzzzzzzzzzzzzzzzzf_ = context.Operators.Union<ServiceRequest>(vzzzzzzzzzzzzzzzzc_, vzzzzzzzzzzzzzzzze_);
        CqlValueSet vzzzzzzzzzzzzzzzzg_ = this.Dietary_Recommendations(context);
        IEnumerable<ServiceRequest> vzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        CqlValueSet vzzzzzzzzzzzzzzzzi_ = this.Recommendation_to_Increase_Physical_Activity(context);
        IEnumerable<ServiceRequest> vzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> vzzzzzzzzzzzzzzzzk_ = context.Operators.Union<ServiceRequest>(vzzzzzzzzzzzzzzzzh_, vzzzzzzzzzzzzzzzzj_);
        IEnumerable<ServiceRequest> vzzzzzzzzzzzzzzzzl_ = context.Operators.Union<ServiceRequest>(vzzzzzzzzzzzzzzzzf_, vzzzzzzzzzzzzzzzzk_);
        CqlValueSet vzzzzzzzzzzzzzzzzm_ = this.Referral_or_Counseling_for_Alcohol_Consumption(context);
        IEnumerable<ServiceRequest> vzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> vzzzzzzzzzzzzzzzzo_ = context.Operators.Union<ServiceRequest>(vzzzzzzzzzzzzzzzzl_, vzzzzzzzzzzzzzzzzn_);
        bool? vzzzzzzzzzzzzzzzzp_(ServiceRequest NonPharmaInterventions)
        {
            Code<RequestIntent> vzzzzzzzzzzzzzzzzr_ = NonPharmaInterventions?.IntentElement;
            RequestIntent? vzzzzzzzzzzzzzzzzs_ = vzzzzzzzzzzzzzzzzr_?.Value;
            Code<RequestIntent> vzzzzzzzzzzzzzzzzt_ = context.Operators.Convert<Code<RequestIntent>>(vzzzzzzzzzzzzzzzzs_);
            bool? vzzzzzzzzzzzzzzzzu_ = context.Operators.Equivalent(vzzzzzzzzzzzzzzzzt_, "order");

            return vzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<ServiceRequest> vzzzzzzzzzzzzzzzzq_ = context.Operators.Where<ServiceRequest>(vzzzzzzzzzzzzzzzzo_, vzzzzzzzzzzzzzzzzp_);

        return vzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Referral to Alternate or Primary Healthcare Professional for Hypertensive Reading")]
    public IEnumerable<ServiceRequest> Referral_to_Alternate_or_Primary_Healthcare_Professional_for_Hypertensive_Reading(CqlContext context)
    {
        CqlValueSet vzzzzzzzzzzzzzzzzv_ = this.Referral_to_Primary_Care_or_Alternate_Provider(context);
        IEnumerable<ServiceRequest> vzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        bool? vzzzzzzzzzzzzzzzzx_(ServiceRequest Referral)
        {
            List<CodeableConcept> vzzzzzzzzzzzzzzzzz_ = Referral?.ReasonCode;
            CqlConcept wzzzzzzzzzzzzzzzza_(CodeableConcept @this)
            {
                CqlConcept wzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return wzzzzzzzzzzzzzzzzj_;
            };
            IEnumerable<CqlConcept> wzzzzzzzzzzzzzzzzb_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)vzzzzzzzzzzzzzzzzz_, wzzzzzzzzzzzzzzzza_);
            CqlValueSet wzzzzzzzzzzzzzzzzc_ = this.Finding_of_Elevated_Blood_Pressure_or_Hypertension(context);
            bool? wzzzzzzzzzzzzzzzzd_ = context.Operators.ConceptsInValueSet(wzzzzzzzzzzzzzzzzb_, wzzzzzzzzzzzzzzzzc_);
            Code<RequestIntent> wzzzzzzzzzzzzzzzze_ = Referral?.IntentElement;
            RequestIntent? wzzzzzzzzzzzzzzzzf_ = wzzzzzzzzzzzzzzzze_?.Value;
            Code<RequestIntent> wzzzzzzzzzzzzzzzzg_ = context.Operators.Convert<Code<RequestIntent>>(wzzzzzzzzzzzzzzzzf_);
            bool? wzzzzzzzzzzzzzzzzh_ = context.Operators.Equivalent(wzzzzzzzzzzzzzzzzg_, "order");
            bool? wzzzzzzzzzzzzzzzzi_ = context.Operators.And(wzzzzzzzzzzzzzzzzd_, wzzzzzzzzzzzzzzzzh_);

            return wzzzzzzzzzzzzzzzzi_;
        };
        IEnumerable<ServiceRequest> vzzzzzzzzzzzzzzzzy_ = context.Operators.Where<ServiceRequest>(vzzzzzzzzzzzzzzzzw_, vzzzzzzzzzzzzzzzzx_);

        return vzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Encounter with Elevated Blood Pressure Reading SBP 120 to 129 AND DBP less than 80 and Interventions")]
    public IEnumerable<Encounter> Encounter_with_Elevated_Blood_Pressure_Reading_SBP_120_to_129_AND_DBP_less_than_80_and_Interventions(CqlContext context)
    {
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzk_ = this.Encounter_with_Elevated_Blood_Pressure_Reading_SBP_120_to_129_AND_DBP_less_than_80(context);
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzl_(Encounter ElevatedEncounter)
        {
            IEnumerable<ServiceRequest> wzzzzzzzzzzzzzzzzt_ = this.Follow_up_with_Rescreen_Within_6_Months(context);
            bool? wzzzzzzzzzzzzzzzzu_(ServiceRequest Twoto6MonthRescreen)
            {
                FhirDateTime wzzzzzzzzzzzzzzzzy_ = Twoto6MonthRescreen?.AuthoredOnElement;
                CqlDateTime wzzzzzzzzzzzzzzzzz_ = context.Operators.Convert<CqlDateTime>(wzzzzzzzzzzzzzzzzy_);
                Period xzzzzzzzzzzzzzzzza_ = ElevatedEncounter?.Period;
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzzzzzzzzzzza_);
                bool? xzzzzzzzzzzzzzzzzc_ = context.Operators.In<CqlDateTime>(wzzzzzzzzzzzzzzzzz_, xzzzzzzzzzzzzzzzzb_, "day");

                return xzzzzzzzzzzzzzzzzc_;
            };
            IEnumerable<ServiceRequest> wzzzzzzzzzzzzzzzzv_ = context.Operators.Where<ServiceRequest>(wzzzzzzzzzzzzzzzzt_, wzzzzzzzzzzzzzzzzu_);
            Encounter wzzzzzzzzzzzzzzzzw_(ServiceRequest Twoto6MonthRescreen) =>
                ElevatedEncounter;
            IEnumerable<Encounter> wzzzzzzzzzzzzzzzzx_ = context.Operators.Select<ServiceRequest, Encounter>(wzzzzzzzzzzzzzzzzv_, wzzzzzzzzzzzzzzzzw_);

            return wzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzm_ = context.Operators.SelectMany<Encounter, Encounter>(wzzzzzzzzzzzzzzzzk_, wzzzzzzzzzzzzzzzzl_);
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzn_(Encounter ElevatedEncounter)
        {
            IEnumerable<ServiceRequest> xzzzzzzzzzzzzzzzzd_ = this.NonPharmacological_Interventions(context);
            bool? xzzzzzzzzzzzzzzzze_(ServiceRequest NonPharmInterventions)
            {
                FhirDateTime xzzzzzzzzzzzzzzzzi_ = NonPharmInterventions?.AuthoredOnElement;
                CqlDateTime xzzzzzzzzzzzzzzzzj_ = context.Operators.Convert<CqlDateTime>(xzzzzzzzzzzzzzzzzi_);
                Period xzzzzzzzzzzzzzzzzk_ = ElevatedEncounter?.Period;
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzzzzzzzzzzzk_);
                bool? xzzzzzzzzzzzzzzzzm_ = context.Operators.In<CqlDateTime>(xzzzzzzzzzzzzzzzzj_, xzzzzzzzzzzzzzzzzl_, "day");

                return xzzzzzzzzzzzzzzzzm_;
            };
            IEnumerable<ServiceRequest> xzzzzzzzzzzzzzzzzf_ = context.Operators.Where<ServiceRequest>(xzzzzzzzzzzzzzzzzd_, xzzzzzzzzzzzzzzzze_);
            Encounter xzzzzzzzzzzzzzzzzg_(ServiceRequest NonPharmInterventions) =>
                ElevatedEncounter;
            IEnumerable<Encounter> xzzzzzzzzzzzzzzzzh_ = context.Operators.Select<ServiceRequest, Encounter>(xzzzzzzzzzzzzzzzzf_, xzzzzzzzzzzzzzzzzg_);

            return xzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzo_ = context.Operators.SelectMany<Encounter, Encounter>(wzzzzzzzzzzzzzzzzm_, wzzzzzzzzzzzzzzzzn_);
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzq_(Encounter ElevatedEncounter)
        {
            IEnumerable<ServiceRequest> xzzzzzzzzzzzzzzzzn_ = this.Referral_to_Alternate_or_Primary_Healthcare_Professional_for_Hypertensive_Reading(context);
            bool? xzzzzzzzzzzzzzzzzo_(ServiceRequest Referral)
            {
                FhirDateTime xzzzzzzzzzzzzzzzzs_ = Referral?.AuthoredOnElement;
                CqlDateTime xzzzzzzzzzzzzzzzzt_ = context.Operators.Convert<CqlDateTime>(xzzzzzzzzzzzzzzzzs_);
                Period xzzzzzzzzzzzzzzzzu_ = ElevatedEncounter?.Period;
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzzzzzzzzzzzu_);
                bool? xzzzzzzzzzzzzzzzzw_ = context.Operators.In<CqlDateTime>(xzzzzzzzzzzzzzzzzt_, xzzzzzzzzzzzzzzzzv_, "day");

                return xzzzzzzzzzzzzzzzzw_;
            };
            IEnumerable<ServiceRequest> xzzzzzzzzzzzzzzzzp_ = context.Operators.Where<ServiceRequest>(xzzzzzzzzzzzzzzzzn_, xzzzzzzzzzzzzzzzzo_);
            Encounter xzzzzzzzzzzzzzzzzq_(ServiceRequest Referral) =>
                ElevatedEncounter;
            IEnumerable<Encounter> xzzzzzzzzzzzzzzzzr_ = context.Operators.Select<ServiceRequest, Encounter>(xzzzzzzzzzzzzzzzzp_, xzzzzzzzzzzzzzzzzq_);

            return xzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzr_ = context.Operators.SelectMany<Encounter, Encounter>(wzzzzzzzzzzzzzzzzk_, wzzzzzzzzzzzzzzzzq_);
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzs_ = context.Operators.Union<Encounter>(wzzzzzzzzzzzzzzzzo_, wzzzzzzzzzzzzzzzzr_);

        return wzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Encounter with Hypertensive Reading Within Year Prior")]
    public IEnumerable<Encounter> Encounter_with_Hypertensive_Reading_Within_Year_Prior(CqlContext context)
    {
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzx_ = this.Qualifying_Encounter_during_Measurement_Period(context);
        bool? xzzzzzzzzzzzzzzzzy_(Encounter QualifyingEncounter)
        {
            IEnumerable<Observation> yzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/bp"));
            bool? yzzzzzzzzzzzzzzzzb_(Observation BloodPressure)
            {
                DataType azzzzzzzzzzzzzzzzzh_ = BloodPressure?.Effective;
                object azzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzh_);
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.toInterval(context, azzzzzzzzzzzzzzzzzi_);
                CqlDateTime azzzzzzzzzzzzzzzzzk_ = context.Operators.End(azzzzzzzzzzzzzzzzzj_);
                Period azzzzzzzzzzzzzzzzzl_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzzzzzzzzzzzl_);
                CqlDateTime azzzzzzzzzzzzzzzzzn_ = context.Operators.Start(azzzzzzzzzzzzzzzzzm_);
                CqlQuantity azzzzzzzzzzzzzzzzzo_ = context.Operators.Quantity(1m, "year");
                CqlDateTime azzzzzzzzzzzzzzzzzp_ = context.Operators.Subtract(azzzzzzzzzzzzzzzzzn_, azzzzzzzzzzzzzzzzzo_);
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzzzzzzzzzzzl_);
                CqlDateTime azzzzzzzzzzzzzzzzzs_ = context.Operators.Start(azzzzzzzzzzzzzzzzzr_);
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzt_ = context.Operators.Interval(azzzzzzzzzzzzzzzzzp_, azzzzzzzzzzzzzzzzzs_, true, true);
                bool? azzzzzzzzzzzzzzzzzu_ = context.Operators.In<CqlDateTime>(azzzzzzzzzzzzzzzzzk_, azzzzzzzzzzzzzzzzzt_, default);
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzzzzzzzzzzzl_);
                CqlDateTime azzzzzzzzzzzzzzzzzx_ = context.Operators.Start(azzzzzzzzzzzzzzzzzw_);
                bool? azzzzzzzzzzzzzzzzzy_ = context.Operators.Not((bool?)(azzzzzzzzzzzzzzzzzx_ is null));
                bool? azzzzzzzzzzzzzzzzzz_ = context.Operators.And(azzzzzzzzzzzzzzzzzu_, azzzzzzzzzzzzzzzzzy_);
                Code<ObservationStatus> bzzzzzzzzzzzzzzzzza_ = BloodPressure?.StatusElement;
                ObservationStatus? bzzzzzzzzzzzzzzzzzb_ = bzzzzzzzzzzzzzzzzza_?.Value;
                string bzzzzzzzzzzzzzzzzzc_ = context.Operators.Convert<string>(bzzzzzzzzzzzzzzzzzb_);
                string[] bzzzzzzzzzzzzzzzzzd_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? bzzzzzzzzzzzzzzzzze_ = context.Operators.In<string>(bzzzzzzzzzzzzzzzzzc_, bzzzzzzzzzzzzzzzzzd_ as IEnumerable<string>);
                bool? bzzzzzzzzzzzzzzzzzf_ = context.Operators.And(azzzzzzzzzzzzzzzzzz_, bzzzzzzzzzzzzzzzzze_);

                return bzzzzzzzzzzzzzzzzzf_;
            };
            IEnumerable<Observation> yzzzzzzzzzzzzzzzzc_ = context.Operators.Where<Observation>(yzzzzzzzzzzzzzzzza_, yzzzzzzzzzzzzzzzzb_);
            object yzzzzzzzzzzzzzzzzd_(Observation @this)
            {
                DataType bzzzzzzzzzzzzzzzzzg_ = @this?.Effective;
                object bzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzg_);
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.toInterval(context, bzzzzzzzzzzzzzzzzzh_);
                CqlDateTime bzzzzzzzzzzzzzzzzzj_ = context.Operators.Start(bzzzzzzzzzzzzzzzzzi_);

                return bzzzzzzzzzzzzzzzzzj_;
            };
            IEnumerable<Observation> yzzzzzzzzzzzzzzzze_ = context.Operators.SortBy<Observation>(yzzzzzzzzzzzzzzzzc_, yzzzzzzzzzzzzzzzzd_, System.ComponentModel.ListSortDirection.Ascending);
            Observation yzzzzzzzzzzzzzzzzf_ = context.Operators.Last<Observation>(yzzzzzzzzzzzzzzzze_);
            List<Observation.ComponentComponent> yzzzzzzzzzzzzzzzzg_ = yzzzzzzzzzzzzzzzzf_?.Component;
            bool? yzzzzzzzzzzzzzzzzh_(Observation.ComponentComponent @this)
            {
                CodeableConcept bzzzzzzzzzzzzzzzzzk_ = @this?.Code;
                List<Coding> bzzzzzzzzzzzzzzzzzl_ = bzzzzzzzzzzzzzzzzzk_?.Coding;
                Coding bzzzzzzzzzzzzzzzzzm_ = context.Operators.First<Coding>((IEnumerable<Coding>)bzzzzzzzzzzzzzzzzzl_);
                FhirUri bzzzzzzzzzzzzzzzzzn_ = bzzzzzzzzzzzzzzzzzm_?.SystemElement;
                string bzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToString(context, bzzzzzzzzzzzzzzzzzn_);
                bool? bzzzzzzzzzzzzzzzzzp_ = context.Operators.Equal(bzzzzzzzzzzzzzzzzzo_, "http://loinc.org");
                List<Coding> bzzzzzzzzzzzzzzzzzr_ = bzzzzzzzzzzzzzzzzzk_?.Coding;
                Coding bzzzzzzzzzzzzzzzzzs_ = context.Operators.First<Coding>((IEnumerable<Coding>)bzzzzzzzzzzzzzzzzzr_);
                Code bzzzzzzzzzzzzzzzzzt_ = bzzzzzzzzzzzzzzzzzs_?.CodeElement;
                string bzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToString(context, bzzzzzzzzzzzzzzzzzt_);
                bool? bzzzzzzzzzzzzzzzzzv_ = context.Operators.Equal(bzzzzzzzzzzzzzzzzzu_, "8480-6");
                bool? bzzzzzzzzzzzzzzzzzw_ = context.Operators.And(bzzzzzzzzzzzzzzzzzp_, bzzzzzzzzzzzzzzzzzv_);

                return bzzzzzzzzzzzzzzzzzw_;
            };
            IEnumerable<Observation.ComponentComponent> yzzzzzzzzzzzzzzzzi_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)yzzzzzzzzzzzzzzzzg_, yzzzzzzzzzzzzzzzzh_);
            Observation.ComponentComponent yzzzzzzzzzzzzzzzzj_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(yzzzzzzzzzzzzzzzzi_);
            DataType yzzzzzzzzzzzzzzzzk_ = yzzzzzzzzzzzzzzzzj_?.Value;
            object yzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzk_);
            CqlQuantity yzzzzzzzzzzzzzzzzm_ = context.Operators.Quantity(0m, "mm[Hg]");
            bool? yzzzzzzzzzzzzzzzzn_ = context.Operators.Greater(yzzzzzzzzzzzzzzzzl_ as CqlQuantity, yzzzzzzzzzzzzzzzzm_);
            bool? yzzzzzzzzzzzzzzzzp_(Observation BloodPressure)
            {
                DataType bzzzzzzzzzzzzzzzzzx_ = BloodPressure?.Effective;
                object bzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzx_);
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.toInterval(context, bzzzzzzzzzzzzzzzzzy_);
                CqlDateTime czzzzzzzzzzzzzzzzza_ = context.Operators.End(bzzzzzzzzzzzzzzzzzz_);
                Period czzzzzzzzzzzzzzzzzb_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzzzzzzzzzzzzzb_);
                CqlDateTime czzzzzzzzzzzzzzzzzd_ = context.Operators.Start(czzzzzzzzzzzzzzzzzc_);
                CqlQuantity czzzzzzzzzzzzzzzzze_ = context.Operators.Quantity(1m, "year");
                CqlDateTime czzzzzzzzzzzzzzzzzf_ = context.Operators.Subtract(czzzzzzzzzzzzzzzzzd_, czzzzzzzzzzzzzzzzze_);
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzzzzzzzzzzzzzb_);
                CqlDateTime czzzzzzzzzzzzzzzzzi_ = context.Operators.Start(czzzzzzzzzzzzzzzzzh_);
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzj_ = context.Operators.Interval(czzzzzzzzzzzzzzzzzf_, czzzzzzzzzzzzzzzzzi_, true, true);
                bool? czzzzzzzzzzzzzzzzzk_ = context.Operators.In<CqlDateTime>(czzzzzzzzzzzzzzzzza_, czzzzzzzzzzzzzzzzzj_, default);
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzzzzzzzzzzzzzb_);
                CqlDateTime czzzzzzzzzzzzzzzzzn_ = context.Operators.Start(czzzzzzzzzzzzzzzzzm_);
                bool? czzzzzzzzzzzzzzzzzo_ = context.Operators.Not((bool?)(czzzzzzzzzzzzzzzzzn_ is null));
                bool? czzzzzzzzzzzzzzzzzp_ = context.Operators.And(czzzzzzzzzzzzzzzzzk_, czzzzzzzzzzzzzzzzzo_);
                Code<ObservationStatus> czzzzzzzzzzzzzzzzzq_ = BloodPressure?.StatusElement;
                ObservationStatus? czzzzzzzzzzzzzzzzzr_ = czzzzzzzzzzzzzzzzzq_?.Value;
                string czzzzzzzzzzzzzzzzzs_ = context.Operators.Convert<string>(czzzzzzzzzzzzzzzzzr_);
                string[] czzzzzzzzzzzzzzzzzt_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? czzzzzzzzzzzzzzzzzu_ = context.Operators.In<string>(czzzzzzzzzzzzzzzzzs_, czzzzzzzzzzzzzzzzzt_ as IEnumerable<string>);
                bool? czzzzzzzzzzzzzzzzzv_ = context.Operators.And(czzzzzzzzzzzzzzzzzp_, czzzzzzzzzzzzzzzzzu_);

                return czzzzzzzzzzzzzzzzzv_;
            };
            IEnumerable<Observation> yzzzzzzzzzzzzzzzzq_ = context.Operators.Where<Observation>(yzzzzzzzzzzzzzzzza_, yzzzzzzzzzzzzzzzzp_);
            object yzzzzzzzzzzzzzzzzr_(Observation @this)
            {
                DataType czzzzzzzzzzzzzzzzzw_ = @this?.Effective;
                object czzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzw_);
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.toInterval(context, czzzzzzzzzzzzzzzzzx_);
                CqlDateTime czzzzzzzzzzzzzzzzzz_ = context.Operators.Start(czzzzzzzzzzzzzzzzzy_);

                return czzzzzzzzzzzzzzzzzz_;
            };
            IEnumerable<Observation> yzzzzzzzzzzzzzzzzs_ = context.Operators.SortBy<Observation>(yzzzzzzzzzzzzzzzzq_, yzzzzzzzzzzzzzzzzr_, System.ComponentModel.ListSortDirection.Ascending);
            Observation yzzzzzzzzzzzzzzzzt_ = context.Operators.Last<Observation>(yzzzzzzzzzzzzzzzzs_);
            List<Observation.ComponentComponent> yzzzzzzzzzzzzzzzzu_ = yzzzzzzzzzzzzzzzzt_?.Component;
            bool? yzzzzzzzzzzzzzzzzv_(Observation.ComponentComponent @this)
            {
                CodeableConcept dzzzzzzzzzzzzzzzzza_ = @this?.Code;
                List<Coding> dzzzzzzzzzzzzzzzzzb_ = dzzzzzzzzzzzzzzzzza_?.Coding;
                Coding dzzzzzzzzzzzzzzzzzc_ = context.Operators.First<Coding>((IEnumerable<Coding>)dzzzzzzzzzzzzzzzzzb_);
                FhirUri dzzzzzzzzzzzzzzzzzd_ = dzzzzzzzzzzzzzzzzzc_?.SystemElement;
                string dzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToString(context, dzzzzzzzzzzzzzzzzzd_);
                bool? dzzzzzzzzzzzzzzzzzf_ = context.Operators.Equal(dzzzzzzzzzzzzzzzzze_, "http://loinc.org");
                List<Coding> dzzzzzzzzzzzzzzzzzh_ = dzzzzzzzzzzzzzzzzza_?.Coding;
                Coding dzzzzzzzzzzzzzzzzzi_ = context.Operators.First<Coding>((IEnumerable<Coding>)dzzzzzzzzzzzzzzzzzh_);
                Code dzzzzzzzzzzzzzzzzzj_ = dzzzzzzzzzzzzzzzzzi_?.CodeElement;
                string dzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToString(context, dzzzzzzzzzzzzzzzzzj_);
                bool? dzzzzzzzzzzzzzzzzzl_ = context.Operators.Equal(dzzzzzzzzzzzzzzzzzk_, "8462-4");
                bool? dzzzzzzzzzzzzzzzzzm_ = context.Operators.And(dzzzzzzzzzzzzzzzzzf_, dzzzzzzzzzzzzzzzzzl_);

                return dzzzzzzzzzzzzzzzzzm_;
            };
            IEnumerable<Observation.ComponentComponent> yzzzzzzzzzzzzzzzzw_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)yzzzzzzzzzzzzzzzzu_, yzzzzzzzzzzzzzzzzv_);
            Observation.ComponentComponent yzzzzzzzzzzzzzzzzx_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(yzzzzzzzzzzzzzzzzw_);
            DataType yzzzzzzzzzzzzzzzzy_ = yzzzzzzzzzzzzzzzzx_?.Value;
            object yzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzy_);
            bool? zzzzzzzzzzzzzzzzzb_ = context.Operators.Greater(yzzzzzzzzzzzzzzzzz_ as CqlQuantity, yzzzzzzzzzzzzzzzzm_);
            bool? zzzzzzzzzzzzzzzzzc_ = context.Operators.And(yzzzzzzzzzzzzzzzzn_, zzzzzzzzzzzzzzzzzb_);
            bool? zzzzzzzzzzzzzzzzze_(Observation BloodPressure)
            {
                DataType dzzzzzzzzzzzzzzzzzn_ = BloodPressure?.Effective;
                object dzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzn_);
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.toInterval(context, dzzzzzzzzzzzzzzzzzo_);
                CqlDateTime dzzzzzzzzzzzzzzzzzq_ = context.Operators.End(dzzzzzzzzzzzzzzzzzp_);
                Period dzzzzzzzzzzzzzzzzzr_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzzzzzzzzzzzzzzr_);
                CqlDateTime dzzzzzzzzzzzzzzzzzt_ = context.Operators.Start(dzzzzzzzzzzzzzzzzzs_);
                CqlQuantity dzzzzzzzzzzzzzzzzzu_ = context.Operators.Quantity(1m, "year");
                CqlDateTime dzzzzzzzzzzzzzzzzzv_ = context.Operators.Subtract(dzzzzzzzzzzzzzzzzzt_, dzzzzzzzzzzzzzzzzzu_);
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzzzzzzzzzzzzzzr_);
                CqlDateTime dzzzzzzzzzzzzzzzzzy_ = context.Operators.Start(dzzzzzzzzzzzzzzzzzx_);
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzz_ = context.Operators.Interval(dzzzzzzzzzzzzzzzzzv_, dzzzzzzzzzzzzzzzzzy_, true, true);
                bool? ezzzzzzzzzzzzzzzzza_ = context.Operators.In<CqlDateTime>(dzzzzzzzzzzzzzzzzzq_, dzzzzzzzzzzzzzzzzzz_, default);
                CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzzzzzzzzzzzzzzr_);
                CqlDateTime ezzzzzzzzzzzzzzzzzd_ = context.Operators.Start(ezzzzzzzzzzzzzzzzzc_);
                bool? ezzzzzzzzzzzzzzzzze_ = context.Operators.Not((bool?)(ezzzzzzzzzzzzzzzzzd_ is null));
                bool? ezzzzzzzzzzzzzzzzzf_ = context.Operators.And(ezzzzzzzzzzzzzzzzza_, ezzzzzzzzzzzzzzzzze_);
                Code<ObservationStatus> ezzzzzzzzzzzzzzzzzg_ = BloodPressure?.StatusElement;
                ObservationStatus? ezzzzzzzzzzzzzzzzzh_ = ezzzzzzzzzzzzzzzzzg_?.Value;
                string ezzzzzzzzzzzzzzzzzi_ = context.Operators.Convert<string>(ezzzzzzzzzzzzzzzzzh_);
                string[] ezzzzzzzzzzzzzzzzzj_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? ezzzzzzzzzzzzzzzzzk_ = context.Operators.In<string>(ezzzzzzzzzzzzzzzzzi_, ezzzzzzzzzzzzzzzzzj_ as IEnumerable<string>);
                bool? ezzzzzzzzzzzzzzzzzl_ = context.Operators.And(ezzzzzzzzzzzzzzzzzf_, ezzzzzzzzzzzzzzzzzk_);

                return ezzzzzzzzzzzzzzzzzl_;
            };
            IEnumerable<Observation> zzzzzzzzzzzzzzzzzf_ = context.Operators.Where<Observation>(yzzzzzzzzzzzzzzzza_, zzzzzzzzzzzzzzzzze_);
            object zzzzzzzzzzzzzzzzzg_(Observation @this)
            {
                DataType ezzzzzzzzzzzzzzzzzm_ = @this?.Effective;
                object ezzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzm_);
                CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.toInterval(context, ezzzzzzzzzzzzzzzzzn_);
                CqlDateTime ezzzzzzzzzzzzzzzzzp_ = context.Operators.Start(ezzzzzzzzzzzzzzzzzo_);

                return ezzzzzzzzzzzzzzzzzp_;
            };
            IEnumerable<Observation> zzzzzzzzzzzzzzzzzh_ = context.Operators.SortBy<Observation>(zzzzzzzzzzzzzzzzzf_, zzzzzzzzzzzzzzzzzg_, System.ComponentModel.ListSortDirection.Ascending);
            Observation zzzzzzzzzzzzzzzzzi_ = context.Operators.Last<Observation>(zzzzzzzzzzzzzzzzzh_);
            List<Observation.ComponentComponent> zzzzzzzzzzzzzzzzzj_ = zzzzzzzzzzzzzzzzzi_?.Component;
            bool? zzzzzzzzzzzzzzzzzk_(Observation.ComponentComponent @this)
            {
                CodeableConcept ezzzzzzzzzzzzzzzzzq_ = @this?.Code;
                List<Coding> ezzzzzzzzzzzzzzzzzr_ = ezzzzzzzzzzzzzzzzzq_?.Coding;
                Coding ezzzzzzzzzzzzzzzzzs_ = context.Operators.First<Coding>((IEnumerable<Coding>)ezzzzzzzzzzzzzzzzzr_);
                FhirUri ezzzzzzzzzzzzzzzzzt_ = ezzzzzzzzzzzzzzzzzs_?.SystemElement;
                string ezzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToString(context, ezzzzzzzzzzzzzzzzzt_);
                bool? ezzzzzzzzzzzzzzzzzv_ = context.Operators.Equal(ezzzzzzzzzzzzzzzzzu_, "http://loinc.org");
                List<Coding> ezzzzzzzzzzzzzzzzzx_ = ezzzzzzzzzzzzzzzzzq_?.Coding;
                Coding ezzzzzzzzzzzzzzzzzy_ = context.Operators.First<Coding>((IEnumerable<Coding>)ezzzzzzzzzzzzzzzzzx_);
                Code ezzzzzzzzzzzzzzzzzz_ = ezzzzzzzzzzzzzzzzzy_?.CodeElement;
                string fzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToString(context, ezzzzzzzzzzzzzzzzzz_);
                bool? fzzzzzzzzzzzzzzzzzb_ = context.Operators.Equal(fzzzzzzzzzzzzzzzzza_, "8480-6");
                bool? fzzzzzzzzzzzzzzzzzc_ = context.Operators.And(ezzzzzzzzzzzzzzzzzv_, fzzzzzzzzzzzzzzzzzb_);

                return fzzzzzzzzzzzzzzzzzc_;
            };
            IEnumerable<Observation.ComponentComponent> zzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)zzzzzzzzzzzzzzzzzj_, zzzzzzzzzzzzzzzzzk_);
            Observation.ComponentComponent zzzzzzzzzzzzzzzzzm_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(zzzzzzzzzzzzzzzzzl_);
            DataType zzzzzzzzzzzzzzzzzn_ = zzzzzzzzzzzzzzzzzm_?.Value;
            object zzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzn_);
            CqlQuantity zzzzzzzzzzzzzzzzzp_ = context.Operators.Quantity(130m, "mm[Hg]");
            bool? zzzzzzzzzzzzzzzzzq_ = context.Operators.GreaterOrEqual(zzzzzzzzzzzzzzzzzo_ as CqlQuantity, zzzzzzzzzzzzzzzzzp_);
            bool? zzzzzzzzzzzzzzzzzs_(Observation BloodPressure)
            {
                DataType fzzzzzzzzzzzzzzzzzd_ = BloodPressure?.Effective;
                object fzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzd_);
                CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.toInterval(context, fzzzzzzzzzzzzzzzzze_);
                CqlDateTime fzzzzzzzzzzzzzzzzzg_ = context.Operators.End(fzzzzzzzzzzzzzzzzzf_);
                Period fzzzzzzzzzzzzzzzzzh_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzzzzzzzzzzzzzh_);
                CqlDateTime fzzzzzzzzzzzzzzzzzj_ = context.Operators.Start(fzzzzzzzzzzzzzzzzzi_);
                CqlQuantity fzzzzzzzzzzzzzzzzzk_ = context.Operators.Quantity(1m, "year");
                CqlDateTime fzzzzzzzzzzzzzzzzzl_ = context.Operators.Subtract(fzzzzzzzzzzzzzzzzzj_, fzzzzzzzzzzzzzzzzzk_);
                CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzzzzzzzzzzzzzh_);
                CqlDateTime fzzzzzzzzzzzzzzzzzo_ = context.Operators.Start(fzzzzzzzzzzzzzzzzzn_);
                CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzp_ = context.Operators.Interval(fzzzzzzzzzzzzzzzzzl_, fzzzzzzzzzzzzzzzzzo_, true, true);
                bool? fzzzzzzzzzzzzzzzzzq_ = context.Operators.In<CqlDateTime>(fzzzzzzzzzzzzzzzzzg_, fzzzzzzzzzzzzzzzzzp_, default);
                CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzzzzzzzzzzzzzh_);
                CqlDateTime fzzzzzzzzzzzzzzzzzt_ = context.Operators.Start(fzzzzzzzzzzzzzzzzzs_);
                bool? fzzzzzzzzzzzzzzzzzu_ = context.Operators.Not((bool?)(fzzzzzzzzzzzzzzzzzt_ is null));
                bool? fzzzzzzzzzzzzzzzzzv_ = context.Operators.And(fzzzzzzzzzzzzzzzzzq_, fzzzzzzzzzzzzzzzzzu_);
                Code<ObservationStatus> fzzzzzzzzzzzzzzzzzw_ = BloodPressure?.StatusElement;
                ObservationStatus? fzzzzzzzzzzzzzzzzzx_ = fzzzzzzzzzzzzzzzzzw_?.Value;
                string fzzzzzzzzzzzzzzzzzy_ = context.Operators.Convert<string>(fzzzzzzzzzzzzzzzzzx_);
                string[] fzzzzzzzzzzzzzzzzzz_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? gzzzzzzzzzzzzzzzzza_ = context.Operators.In<string>(fzzzzzzzzzzzzzzzzzy_, fzzzzzzzzzzzzzzzzzz_ as IEnumerable<string>);
                bool? gzzzzzzzzzzzzzzzzzb_ = context.Operators.And(fzzzzzzzzzzzzzzzzzv_, gzzzzzzzzzzzzzzzzza_);

                return gzzzzzzzzzzzzzzzzzb_;
            };
            IEnumerable<Observation> zzzzzzzzzzzzzzzzzt_ = context.Operators.Where<Observation>(yzzzzzzzzzzzzzzzza_, zzzzzzzzzzzzzzzzzs_);
            object zzzzzzzzzzzzzzzzzu_(Observation @this)
            {
                DataType gzzzzzzzzzzzzzzzzzc_ = @this?.Effective;
                object gzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzc_);
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.toInterval(context, gzzzzzzzzzzzzzzzzzd_);
                CqlDateTime gzzzzzzzzzzzzzzzzzf_ = context.Operators.Start(gzzzzzzzzzzzzzzzzze_);

                return gzzzzzzzzzzzzzzzzzf_;
            };
            IEnumerable<Observation> zzzzzzzzzzzzzzzzzv_ = context.Operators.SortBy<Observation>(zzzzzzzzzzzzzzzzzt_, zzzzzzzzzzzzzzzzzu_, System.ComponentModel.ListSortDirection.Ascending);
            Observation zzzzzzzzzzzzzzzzzw_ = context.Operators.Last<Observation>(zzzzzzzzzzzzzzzzzv_);
            List<Observation.ComponentComponent> zzzzzzzzzzzzzzzzzx_ = zzzzzzzzzzzzzzzzzw_?.Component;
            bool? zzzzzzzzzzzzzzzzzy_(Observation.ComponentComponent @this)
            {
                CodeableConcept gzzzzzzzzzzzzzzzzzg_ = @this?.Code;
                List<Coding> gzzzzzzzzzzzzzzzzzh_ = gzzzzzzzzzzzzzzzzzg_?.Coding;
                Coding gzzzzzzzzzzzzzzzzzi_ = context.Operators.First<Coding>((IEnumerable<Coding>)gzzzzzzzzzzzzzzzzzh_);
                FhirUri gzzzzzzzzzzzzzzzzzj_ = gzzzzzzzzzzzzzzzzzi_?.SystemElement;
                string gzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToString(context, gzzzzzzzzzzzzzzzzzj_);
                bool? gzzzzzzzzzzzzzzzzzl_ = context.Operators.Equal(gzzzzzzzzzzzzzzzzzk_, "http://loinc.org");
                List<Coding> gzzzzzzzzzzzzzzzzzn_ = gzzzzzzzzzzzzzzzzzg_?.Coding;
                Coding gzzzzzzzzzzzzzzzzzo_ = context.Operators.First<Coding>((IEnumerable<Coding>)gzzzzzzzzzzzzzzzzzn_);
                Code gzzzzzzzzzzzzzzzzzp_ = gzzzzzzzzzzzzzzzzzo_?.CodeElement;
                string gzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToString(context, gzzzzzzzzzzzzzzzzzp_);
                bool? gzzzzzzzzzzzzzzzzzr_ = context.Operators.Equal(gzzzzzzzzzzzzzzzzzq_, "8462-4");
                bool? gzzzzzzzzzzzzzzzzzs_ = context.Operators.And(gzzzzzzzzzzzzzzzzzl_, gzzzzzzzzzzzzzzzzzr_);

                return gzzzzzzzzzzzzzzzzzs_;
            };
            IEnumerable<Observation.ComponentComponent> zzzzzzzzzzzzzzzzzz_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)zzzzzzzzzzzzzzzzzx_, zzzzzzzzzzzzzzzzzy_);
            Observation.ComponentComponent azzzzzzzzzzzzzzzzza_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(zzzzzzzzzzzzzzzzzz_);
            DataType azzzzzzzzzzzzzzzzzb_ = azzzzzzzzzzzzzzzzza_?.Value;
            object azzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzb_);
            CqlQuantity azzzzzzzzzzzzzzzzzd_ = context.Operators.Quantity(80m, "mm[Hg]");
            bool? azzzzzzzzzzzzzzzzze_ = context.Operators.GreaterOrEqual(azzzzzzzzzzzzzzzzzc_ as CqlQuantity, azzzzzzzzzzzzzzzzzd_);
            bool? azzzzzzzzzzzzzzzzzf_ = context.Operators.Or(zzzzzzzzzzzzzzzzzq_, azzzzzzzzzzzzzzzzze_);
            bool? azzzzzzzzzzzzzzzzzg_ = context.Operators.And(zzzzzzzzzzzzzzzzzc_, azzzzzzzzzzzzzzzzzf_);

            return azzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzz_ = context.Operators.Where<Encounter>(xzzzzzzzzzzzzzzzzx_, xzzzzzzzzzzzzzzzzy_);

        return xzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Encounter with First Hypertensive Reading SBP Greater than or Equal to 130 OR DBP Greater than or Equal to 80")]
    public IEnumerable<Encounter> Encounter_with_First_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_130_OR_DBP_Greater_than_or_Equal_to_80(CqlContext context)
    {
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzt_ = this.Qualifying_Encounter_during_Measurement_Period(context);
        bool? gzzzzzzzzzzzzzzzzzu_(Encounter QualifyingEncounter)
        {
            IEnumerable<Observation> gzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/bp"));
            bool? gzzzzzzzzzzzzzzzzzz_(Observation BloodPressure)
            {
                DataType jzzzzzzzzzzzzzzzzzf_ = BloodPressure?.Effective;
                object jzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzf_);
                CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.toInterval(context, jzzzzzzzzzzzzzzzzzg_);
                CqlDateTime jzzzzzzzzzzzzzzzzzi_ = context.Operators.End(jzzzzzzzzzzzzzzzzzh_);
                Period jzzzzzzzzzzzzzzzzzj_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzzzzzzzzzzzzj_);
                bool? jzzzzzzzzzzzzzzzzzl_ = context.Operators.In<CqlDateTime>(jzzzzzzzzzzzzzzzzzi_, jzzzzzzzzzzzzzzzzzk_, "day");

                return jzzzzzzzzzzzzzzzzzl_;
            };
            IEnumerable<Observation> hzzzzzzzzzzzzzzzzza_ = context.Operators.Where<Observation>(gzzzzzzzzzzzzzzzzzy_, gzzzzzzzzzzzzzzzzzz_);
            object hzzzzzzzzzzzzzzzzzb_(Observation @this)
            {
                DataType jzzzzzzzzzzzzzzzzzm_ = @this?.Effective;
                object jzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzm_);
                CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.toInterval(context, jzzzzzzzzzzzzzzzzzn_);
                CqlDateTime jzzzzzzzzzzzzzzzzzp_ = context.Operators.Start(jzzzzzzzzzzzzzzzzzo_);

                return jzzzzzzzzzzzzzzzzzp_;
            };
            IEnumerable<Observation> hzzzzzzzzzzzzzzzzzc_ = context.Operators.SortBy<Observation>(hzzzzzzzzzzzzzzzzza_, hzzzzzzzzzzzzzzzzzb_, System.ComponentModel.ListSortDirection.Ascending);
            Observation hzzzzzzzzzzzzzzzzzd_ = context.Operators.Last<Observation>(hzzzzzzzzzzzzzzzzzc_);
            List<Observation.ComponentComponent> hzzzzzzzzzzzzzzzzze_ = hzzzzzzzzzzzzzzzzzd_?.Component;
            bool? hzzzzzzzzzzzzzzzzzf_(Observation.ComponentComponent @this)
            {
                CodeableConcept jzzzzzzzzzzzzzzzzzq_ = @this?.Code;
                List<Coding> jzzzzzzzzzzzzzzzzzr_ = jzzzzzzzzzzzzzzzzzq_?.Coding;
                Coding jzzzzzzzzzzzzzzzzzs_ = context.Operators.First<Coding>((IEnumerable<Coding>)jzzzzzzzzzzzzzzzzzr_);
                FhirUri jzzzzzzzzzzzzzzzzzt_ = jzzzzzzzzzzzzzzzzzs_?.SystemElement;
                string jzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToString(context, jzzzzzzzzzzzzzzzzzt_);
                bool? jzzzzzzzzzzzzzzzzzv_ = context.Operators.Equal(jzzzzzzzzzzzzzzzzzu_, "http://loinc.org");
                List<Coding> jzzzzzzzzzzzzzzzzzx_ = jzzzzzzzzzzzzzzzzzq_?.Coding;
                Coding jzzzzzzzzzzzzzzzzzy_ = context.Operators.First<Coding>((IEnumerable<Coding>)jzzzzzzzzzzzzzzzzzx_);
                Code jzzzzzzzzzzzzzzzzzz_ = jzzzzzzzzzzzzzzzzzy_?.CodeElement;
                string kzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToString(context, jzzzzzzzzzzzzzzzzzz_);
                bool? kzzzzzzzzzzzzzzzzzb_ = context.Operators.Equal(kzzzzzzzzzzzzzzzzza_, "8480-6");
                bool? kzzzzzzzzzzzzzzzzzc_ = context.Operators.And(jzzzzzzzzzzzzzzzzzv_, kzzzzzzzzzzzzzzzzzb_);

                return kzzzzzzzzzzzzzzzzzc_;
            };
            IEnumerable<Observation.ComponentComponent> hzzzzzzzzzzzzzzzzzg_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)hzzzzzzzzzzzzzzzzze_, hzzzzzzzzzzzzzzzzzf_);
            Observation.ComponentComponent hzzzzzzzzzzzzzzzzzh_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(hzzzzzzzzzzzzzzzzzg_);
            DataType hzzzzzzzzzzzzzzzzzi_ = hzzzzzzzzzzzzzzzzzh_?.Value;
            object hzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzi_);
            CqlQuantity hzzzzzzzzzzzzzzzzzk_ = context.Operators.Quantity(0m, "mm[Hg]");
            bool? hzzzzzzzzzzzzzzzzzl_ = context.Operators.Greater(hzzzzzzzzzzzzzzzzzj_ as CqlQuantity, hzzzzzzzzzzzzzzzzzk_);
            bool? hzzzzzzzzzzzzzzzzzn_(Observation BloodPressure)
            {
                DataType kzzzzzzzzzzzzzzzzzd_ = BloodPressure?.Effective;
                object kzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzd_);
                CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.toInterval(context, kzzzzzzzzzzzzzzzzze_);
                CqlDateTime kzzzzzzzzzzzzzzzzzg_ = context.Operators.End(kzzzzzzzzzzzzzzzzzf_);
                Period kzzzzzzzzzzzzzzzzzh_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzzzzzzzzzzzzzh_);
                bool? kzzzzzzzzzzzzzzzzzj_ = context.Operators.In<CqlDateTime>(kzzzzzzzzzzzzzzzzzg_, kzzzzzzzzzzzzzzzzzi_, "day");

                return kzzzzzzzzzzzzzzzzzj_;
            };
            IEnumerable<Observation> hzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<Observation>(gzzzzzzzzzzzzzzzzzy_, hzzzzzzzzzzzzzzzzzn_);
            object hzzzzzzzzzzzzzzzzzp_(Observation @this)
            {
                DataType kzzzzzzzzzzzzzzzzzk_ = @this?.Effective;
                object kzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzk_);
                CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.toInterval(context, kzzzzzzzzzzzzzzzzzl_);
                CqlDateTime kzzzzzzzzzzzzzzzzzn_ = context.Operators.Start(kzzzzzzzzzzzzzzzzzm_);

                return kzzzzzzzzzzzzzzzzzn_;
            };
            IEnumerable<Observation> hzzzzzzzzzzzzzzzzzq_ = context.Operators.SortBy<Observation>(hzzzzzzzzzzzzzzzzzo_, hzzzzzzzzzzzzzzzzzp_, System.ComponentModel.ListSortDirection.Ascending);
            Observation hzzzzzzzzzzzzzzzzzr_ = context.Operators.Last<Observation>(hzzzzzzzzzzzzzzzzzq_);
            List<Observation.ComponentComponent> hzzzzzzzzzzzzzzzzzs_ = hzzzzzzzzzzzzzzzzzr_?.Component;
            bool? hzzzzzzzzzzzzzzzzzt_(Observation.ComponentComponent @this)
            {
                CodeableConcept kzzzzzzzzzzzzzzzzzo_ = @this?.Code;
                List<Coding> kzzzzzzzzzzzzzzzzzp_ = kzzzzzzzzzzzzzzzzzo_?.Coding;
                Coding kzzzzzzzzzzzzzzzzzq_ = context.Operators.First<Coding>((IEnumerable<Coding>)kzzzzzzzzzzzzzzzzzp_);
                FhirUri kzzzzzzzzzzzzzzzzzr_ = kzzzzzzzzzzzzzzzzzq_?.SystemElement;
                string kzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToString(context, kzzzzzzzzzzzzzzzzzr_);
                bool? kzzzzzzzzzzzzzzzzzt_ = context.Operators.Equal(kzzzzzzzzzzzzzzzzzs_, "http://loinc.org");
                List<Coding> kzzzzzzzzzzzzzzzzzv_ = kzzzzzzzzzzzzzzzzzo_?.Coding;
                Coding kzzzzzzzzzzzzzzzzzw_ = context.Operators.First<Coding>((IEnumerable<Coding>)kzzzzzzzzzzzzzzzzzv_);
                Code kzzzzzzzzzzzzzzzzzx_ = kzzzzzzzzzzzzzzzzzw_?.CodeElement;
                string kzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToString(context, kzzzzzzzzzzzzzzzzzx_);
                bool? kzzzzzzzzzzzzzzzzzz_ = context.Operators.Equal(kzzzzzzzzzzzzzzzzzy_, "8462-4");
                bool? lzzzzzzzzzzzzzzzzza_ = context.Operators.And(kzzzzzzzzzzzzzzzzzt_, kzzzzzzzzzzzzzzzzzz_);

                return lzzzzzzzzzzzzzzzzza_;
            };
            IEnumerable<Observation.ComponentComponent> hzzzzzzzzzzzzzzzzzu_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)hzzzzzzzzzzzzzzzzzs_, hzzzzzzzzzzzzzzzzzt_);
            Observation.ComponentComponent hzzzzzzzzzzzzzzzzzv_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(hzzzzzzzzzzzzzzzzzu_);
            DataType hzzzzzzzzzzzzzzzzzw_ = hzzzzzzzzzzzzzzzzzv_?.Value;
            object hzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzw_);
            bool? hzzzzzzzzzzzzzzzzzz_ = context.Operators.Greater(hzzzzzzzzzzzzzzzzzx_ as CqlQuantity, hzzzzzzzzzzzzzzzzzk_);
            bool? izzzzzzzzzzzzzzzzza_ = context.Operators.And(hzzzzzzzzzzzzzzzzzl_, hzzzzzzzzzzzzzzzzzz_);
            bool? izzzzzzzzzzzzzzzzzc_(Observation BloodPressure)
            {
                DataType lzzzzzzzzzzzzzzzzzb_ = BloodPressure?.Effective;
                object lzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzb_);
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.toInterval(context, lzzzzzzzzzzzzzzzzzc_);
                CqlDateTime lzzzzzzzzzzzzzzzzze_ = context.Operators.End(lzzzzzzzzzzzzzzzzzd_);
                Period lzzzzzzzzzzzzzzzzzf_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzzzzzzzzzzzzf_);
                bool? lzzzzzzzzzzzzzzzzzh_ = context.Operators.In<CqlDateTime>(lzzzzzzzzzzzzzzzzze_, lzzzzzzzzzzzzzzzzzg_, "day");

                return lzzzzzzzzzzzzzzzzzh_;
            };
            IEnumerable<Observation> izzzzzzzzzzzzzzzzzd_ = context.Operators.Where<Observation>(gzzzzzzzzzzzzzzzzzy_, izzzzzzzzzzzzzzzzzc_);
            object izzzzzzzzzzzzzzzzze_(Observation @this)
            {
                DataType lzzzzzzzzzzzzzzzzzi_ = @this?.Effective;
                object lzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzi_);
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.toInterval(context, lzzzzzzzzzzzzzzzzzj_);
                CqlDateTime lzzzzzzzzzzzzzzzzzl_ = context.Operators.Start(lzzzzzzzzzzzzzzzzzk_);

                return lzzzzzzzzzzzzzzzzzl_;
            };
            IEnumerable<Observation> izzzzzzzzzzzzzzzzzf_ = context.Operators.SortBy<Observation>(izzzzzzzzzzzzzzzzzd_, izzzzzzzzzzzzzzzzze_, System.ComponentModel.ListSortDirection.Ascending);
            Observation izzzzzzzzzzzzzzzzzg_ = context.Operators.Last<Observation>(izzzzzzzzzzzzzzzzzf_);
            List<Observation.ComponentComponent> izzzzzzzzzzzzzzzzzh_ = izzzzzzzzzzzzzzzzzg_?.Component;
            bool? izzzzzzzzzzzzzzzzzi_(Observation.ComponentComponent @this)
            {
                CodeableConcept lzzzzzzzzzzzzzzzzzm_ = @this?.Code;
                List<Coding> lzzzzzzzzzzzzzzzzzn_ = lzzzzzzzzzzzzzzzzzm_?.Coding;
                Coding lzzzzzzzzzzzzzzzzzo_ = context.Operators.First<Coding>((IEnumerable<Coding>)lzzzzzzzzzzzzzzzzzn_);
                FhirUri lzzzzzzzzzzzzzzzzzp_ = lzzzzzzzzzzzzzzzzzo_?.SystemElement;
                string lzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToString(context, lzzzzzzzzzzzzzzzzzp_);
                bool? lzzzzzzzzzzzzzzzzzr_ = context.Operators.Equal(lzzzzzzzzzzzzzzzzzq_, "http://loinc.org");
                List<Coding> lzzzzzzzzzzzzzzzzzt_ = lzzzzzzzzzzzzzzzzzm_?.Coding;
                Coding lzzzzzzzzzzzzzzzzzu_ = context.Operators.First<Coding>((IEnumerable<Coding>)lzzzzzzzzzzzzzzzzzt_);
                Code lzzzzzzzzzzzzzzzzzv_ = lzzzzzzzzzzzzzzzzzu_?.CodeElement;
                string lzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToString(context, lzzzzzzzzzzzzzzzzzv_);
                bool? lzzzzzzzzzzzzzzzzzx_ = context.Operators.Equal(lzzzzzzzzzzzzzzzzzw_, "8480-6");
                bool? lzzzzzzzzzzzzzzzzzy_ = context.Operators.And(lzzzzzzzzzzzzzzzzzr_, lzzzzzzzzzzzzzzzzzx_);

                return lzzzzzzzzzzzzzzzzzy_;
            };
            IEnumerable<Observation.ComponentComponent> izzzzzzzzzzzzzzzzzj_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)izzzzzzzzzzzzzzzzzh_, izzzzzzzzzzzzzzzzzi_);
            Observation.ComponentComponent izzzzzzzzzzzzzzzzzk_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(izzzzzzzzzzzzzzzzzj_);
            DataType izzzzzzzzzzzzzzzzzl_ = izzzzzzzzzzzzzzzzzk_?.Value;
            object izzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzl_);
            CqlQuantity izzzzzzzzzzzzzzzzzn_ = context.Operators.Quantity(130m, "mm[Hg]");
            bool? izzzzzzzzzzzzzzzzzo_ = context.Operators.GreaterOrEqual(izzzzzzzzzzzzzzzzzm_ as CqlQuantity, izzzzzzzzzzzzzzzzzn_);
            bool? izzzzzzzzzzzzzzzzzq_(Observation BloodPressure)
            {
                DataType lzzzzzzzzzzzzzzzzzz_ = BloodPressure?.Effective;
                object mzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzz_);
                CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.toInterval(context, mzzzzzzzzzzzzzzzzza_);
                CqlDateTime mzzzzzzzzzzzzzzzzzc_ = context.Operators.End(mzzzzzzzzzzzzzzzzzb_);
                Period mzzzzzzzzzzzzzzzzzd_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzzzzzzzzzzzzd_);
                bool? mzzzzzzzzzzzzzzzzzf_ = context.Operators.In<CqlDateTime>(mzzzzzzzzzzzzzzzzzc_, mzzzzzzzzzzzzzzzzze_, "day");

                return mzzzzzzzzzzzzzzzzzf_;
            };
            IEnumerable<Observation> izzzzzzzzzzzzzzzzzr_ = context.Operators.Where<Observation>(gzzzzzzzzzzzzzzzzzy_, izzzzzzzzzzzzzzzzzq_);
            object izzzzzzzzzzzzzzzzzs_(Observation @this)
            {
                DataType mzzzzzzzzzzzzzzzzzg_ = @this?.Effective;
                object mzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzg_);
                CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.toInterval(context, mzzzzzzzzzzzzzzzzzh_);
                CqlDateTime mzzzzzzzzzzzzzzzzzj_ = context.Operators.Start(mzzzzzzzzzzzzzzzzzi_);

                return mzzzzzzzzzzzzzzzzzj_;
            };
            IEnumerable<Observation> izzzzzzzzzzzzzzzzzt_ = context.Operators.SortBy<Observation>(izzzzzzzzzzzzzzzzzr_, izzzzzzzzzzzzzzzzzs_, System.ComponentModel.ListSortDirection.Ascending);
            Observation izzzzzzzzzzzzzzzzzu_ = context.Operators.Last<Observation>(izzzzzzzzzzzzzzzzzt_);
            List<Observation.ComponentComponent> izzzzzzzzzzzzzzzzzv_ = izzzzzzzzzzzzzzzzzu_?.Component;
            bool? izzzzzzzzzzzzzzzzzw_(Observation.ComponentComponent @this)
            {
                CodeableConcept mzzzzzzzzzzzzzzzzzk_ = @this?.Code;
                List<Coding> mzzzzzzzzzzzzzzzzzl_ = mzzzzzzzzzzzzzzzzzk_?.Coding;
                Coding mzzzzzzzzzzzzzzzzzm_ = context.Operators.First<Coding>((IEnumerable<Coding>)mzzzzzzzzzzzzzzzzzl_);
                FhirUri mzzzzzzzzzzzzzzzzzn_ = mzzzzzzzzzzzzzzzzzm_?.SystemElement;
                string mzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToString(context, mzzzzzzzzzzzzzzzzzn_);
                bool? mzzzzzzzzzzzzzzzzzp_ = context.Operators.Equal(mzzzzzzzzzzzzzzzzzo_, "http://loinc.org");
                List<Coding> mzzzzzzzzzzzzzzzzzr_ = mzzzzzzzzzzzzzzzzzk_?.Coding;
                Coding mzzzzzzzzzzzzzzzzzs_ = context.Operators.First<Coding>((IEnumerable<Coding>)mzzzzzzzzzzzzzzzzzr_);
                Code mzzzzzzzzzzzzzzzzzt_ = mzzzzzzzzzzzzzzzzzs_?.CodeElement;
                string mzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToString(context, mzzzzzzzzzzzzzzzzzt_);
                bool? mzzzzzzzzzzzzzzzzzv_ = context.Operators.Equal(mzzzzzzzzzzzzzzzzzu_, "8462-4");
                bool? mzzzzzzzzzzzzzzzzzw_ = context.Operators.And(mzzzzzzzzzzzzzzzzzp_, mzzzzzzzzzzzzzzzzzv_);

                return mzzzzzzzzzzzzzzzzzw_;
            };
            IEnumerable<Observation.ComponentComponent> izzzzzzzzzzzzzzzzzx_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)izzzzzzzzzzzzzzzzzv_, izzzzzzzzzzzzzzzzzw_);
            Observation.ComponentComponent izzzzzzzzzzzzzzzzzy_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(izzzzzzzzzzzzzzzzzx_);
            DataType izzzzzzzzzzzzzzzzzz_ = izzzzzzzzzzzzzzzzzy_?.Value;
            object jzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzz_);
            CqlQuantity jzzzzzzzzzzzzzzzzzb_ = context.Operators.Quantity(80m, "mm[Hg]");
            bool? jzzzzzzzzzzzzzzzzzc_ = context.Operators.GreaterOrEqual(jzzzzzzzzzzzzzzzzza_ as CqlQuantity, jzzzzzzzzzzzzzzzzzb_);
            bool? jzzzzzzzzzzzzzzzzzd_ = context.Operators.Or(izzzzzzzzzzzzzzzzzo_, jzzzzzzzzzzzzzzzzzc_);
            bool? jzzzzzzzzzzzzzzzzze_ = context.Operators.And(izzzzzzzzzzzzzzzzza_, jzzzzzzzzzzzzzzzzzd_);

            return jzzzzzzzzzzzzzzzzze_;
        };
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Encounter>(gzzzzzzzzzzzzzzzzzt_, gzzzzzzzzzzzzzzzzzu_);
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzw_ = this.Encounter_with_Hypertensive_Reading_Within_Year_Prior(context);
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzx_ = context.Operators.Except<Encounter>(gzzzzzzzzzzzzzzzzzv_, gzzzzzzzzzzzzzzzzzw_);

        return gzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("First Hypertensive Reading Interventions or Referral to Alternate Professional")]
    public IEnumerable<ServiceRequest> First_Hypertensive_Reading_Interventions_or_Referral_to_Alternate_Professional(CqlContext context)
    {
        CqlValueSet mzzzzzzzzzzzzzzzzzx_ = this.Follow_Up_Within_4_Weeks(context);
        IEnumerable<ServiceRequest> mzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, mzzzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> mzzzzzzzzzzzzzzzzzz_(ServiceRequest FourWeekRescreen)
        {
            IEnumerable<ServiceRequest> nzzzzzzzzzzzzzzzzzd_ = this.NonPharmacological_Interventions(context);
            bool? nzzzzzzzzzzzzzzzzze_(ServiceRequest NonPharmInterventionsHTN)
            {
                FhirDateTime nzzzzzzzzzzzzzzzzzi_ = FourWeekRescreen?.AuthoredOnElement;
                CqlDateTime nzzzzzzzzzzzzzzzzzj_ = context.Operators.Convert<CqlDateTime>(nzzzzzzzzzzzzzzzzzi_);
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzk_ = this.Measurement_Period(context);
                bool? nzzzzzzzzzzzzzzzzzl_ = context.Operators.In<CqlDateTime>(nzzzzzzzzzzzzzzzzzj_, nzzzzzzzzzzzzzzzzzk_, "day");
                FhirDateTime nzzzzzzzzzzzzzzzzzm_ = NonPharmInterventionsHTN?.AuthoredOnElement;
                CqlDateTime nzzzzzzzzzzzzzzzzzn_ = context.Operators.Convert<CqlDateTime>(nzzzzzzzzzzzzzzzzzm_);
                bool? nzzzzzzzzzzzzzzzzzp_ = context.Operators.In<CqlDateTime>(nzzzzzzzzzzzzzzzzzn_, nzzzzzzzzzzzzzzzzzk_, "day");
                bool? nzzzzzzzzzzzzzzzzzq_ = context.Operators.And(nzzzzzzzzzzzzzzzzzl_, nzzzzzzzzzzzzzzzzzp_);
                Code<RequestIntent> nzzzzzzzzzzzzzzzzzr_ = FourWeekRescreen?.IntentElement;
                RequestIntent? nzzzzzzzzzzzzzzzzzs_ = nzzzzzzzzzzzzzzzzzr_?.Value;
                Code<RequestIntent> nzzzzzzzzzzzzzzzzzt_ = context.Operators.Convert<Code<RequestIntent>>(nzzzzzzzzzzzzzzzzzs_);
                bool? nzzzzzzzzzzzzzzzzzu_ = context.Operators.Equivalent(nzzzzzzzzzzzzzzzzzt_, "order");
                bool? nzzzzzzzzzzzzzzzzzv_ = context.Operators.And(nzzzzzzzzzzzzzzzzzq_, nzzzzzzzzzzzzzzzzzu_);

                return nzzzzzzzzzzzzzzzzzv_;
            };
            IEnumerable<ServiceRequest> nzzzzzzzzzzzzzzzzzf_ = context.Operators.Where<ServiceRequest>(nzzzzzzzzzzzzzzzzzd_, nzzzzzzzzzzzzzzzzze_);
            ServiceRequest nzzzzzzzzzzzzzzzzzg_(ServiceRequest NonPharmInterventionsHTN) =>
                FourWeekRescreen;
            IEnumerable<ServiceRequest> nzzzzzzzzzzzzzzzzzh_ = context.Operators.Select<ServiceRequest, ServiceRequest>(nzzzzzzzzzzzzzzzzzf_, nzzzzzzzzzzzzzzzzzg_);

            return nzzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<ServiceRequest> nzzzzzzzzzzzzzzzzza_ = context.Operators.SelectMany<ServiceRequest, ServiceRequest>(mzzzzzzzzzzzzzzzzzy_, mzzzzzzzzzzzzzzzzzz_);
        IEnumerable<ServiceRequest> nzzzzzzzzzzzzzzzzzb_ = this.Referral_to_Alternate_or_Primary_Healthcare_Professional_for_Hypertensive_Reading(context);
        IEnumerable<ServiceRequest> nzzzzzzzzzzzzzzzzzc_ = context.Operators.Union<ServiceRequest>(nzzzzzzzzzzzzzzzzza_, nzzzzzzzzzzzzzzzzzb_);

        return nzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Encounter with First Hypertensive Reading SBP Greater than or Equal to 130 OR DBP Greater than or Equal to 80 and Interventions")]
    public IEnumerable<Encounter> Encounter_with_First_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_130_OR_DBP_Greater_than_or_Equal_to_80_and_Interventions(CqlContext context)
    {
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzw_ = this.Encounter_with_First_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_130_OR_DBP_Greater_than_or_Equal_to_80(context);
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzx_(Encounter FirstHTNEncounter)
        {
            IEnumerable<ServiceRequest> nzzzzzzzzzzzzzzzzzz_ = this.First_Hypertensive_Reading_Interventions_or_Referral_to_Alternate_Professional(context);
            bool? ozzzzzzzzzzzzzzzzza_(ServiceRequest FirstHTNIntervention)
            {
                FhirDateTime ozzzzzzzzzzzzzzzzze_ = FirstHTNIntervention?.AuthoredOnElement;
                CqlDateTime ozzzzzzzzzzzzzzzzzf_ = context.Operators.Convert<CqlDateTime>(ozzzzzzzzzzzzzzzzze_);
                Period ozzzzzzzzzzzzzzzzzg_ = FirstHTNEncounter?.Period;
                CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzzzzzzzzzzzzzg_);
                bool? ozzzzzzzzzzzzzzzzzi_ = context.Operators.In<CqlDateTime>(ozzzzzzzzzzzzzzzzzf_, ozzzzzzzzzzzzzzzzzh_, "day");

                return ozzzzzzzzzzzzzzzzzi_;
            };
            IEnumerable<ServiceRequest> ozzzzzzzzzzzzzzzzzb_ = context.Operators.Where<ServiceRequest>(nzzzzzzzzzzzzzzzzzz_, ozzzzzzzzzzzzzzzzza_);
            Encounter ozzzzzzzzzzzzzzzzzc_(ServiceRequest FirstHTNIntervention) =>
                FirstHTNEncounter;
            IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzd_ = context.Operators.Select<ServiceRequest, Encounter>(ozzzzzzzzzzzzzzzzzb_, ozzzzzzzzzzzzzzzzzc_);

            return ozzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzy_ = context.Operators.SelectMany<Encounter, Encounter>(nzzzzzzzzzzzzzzzzzw_, nzzzzzzzzzzzzzzzzzx_);

        return nzzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Encounter with Second Hypertensive Reading SBP 130 to 139 OR DBP 80 to 89")]
    public IEnumerable<Encounter> Encounter_with_Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89(CqlContext context)
    {
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzj_ = this.Qualifying_Encounter_during_Measurement_Period(context);
        bool? ozzzzzzzzzzzzzzzzzk_(Encounter QualifyingEncounter)
        {
            IEnumerable<Observation> ozzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/bp"));
            bool? ozzzzzzzzzzzzzzzzzn_(Observation BloodPressure)
            {
                DataType rzzzzzzzzzzzzzzzzzb_ = BloodPressure?.Effective;
                object rzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzb_);
                CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.toInterval(context, rzzzzzzzzzzzzzzzzzc_);
                CqlDateTime rzzzzzzzzzzzzzzzzze_ = context.Operators.End(rzzzzzzzzzzzzzzzzzd_);
                Period rzzzzzzzzzzzzzzzzzf_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzzzzzzzzzzzzf_);
                bool? rzzzzzzzzzzzzzzzzzh_ = context.Operators.In<CqlDateTime>(rzzzzzzzzzzzzzzzzze_, rzzzzzzzzzzzzzzzzzg_, "day");
                Code<ObservationStatus> rzzzzzzzzzzzzzzzzzi_ = BloodPressure?.StatusElement;
                ObservationStatus? rzzzzzzzzzzzzzzzzzj_ = rzzzzzzzzzzzzzzzzzi_?.Value;
                string rzzzzzzzzzzzzzzzzzk_ = context.Operators.Convert<string>(rzzzzzzzzzzzzzzzzzj_);
                string[] rzzzzzzzzzzzzzzzzzl_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? rzzzzzzzzzzzzzzzzzm_ = context.Operators.In<string>(rzzzzzzzzzzzzzzzzzk_, rzzzzzzzzzzzzzzzzzl_ as IEnumerable<string>);
                bool? rzzzzzzzzzzzzzzzzzn_ = context.Operators.And(rzzzzzzzzzzzzzzzzzh_, rzzzzzzzzzzzzzzzzzm_);

                return rzzzzzzzzzzzzzzzzzn_;
            };
            IEnumerable<Observation> ozzzzzzzzzzzzzzzzzo_ = context.Operators.Where<Observation>(ozzzzzzzzzzzzzzzzzm_, ozzzzzzzzzzzzzzzzzn_);
            object ozzzzzzzzzzzzzzzzzp_(Observation @this)
            {
                DataType rzzzzzzzzzzzzzzzzzo_ = @this?.Effective;
                object rzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzo_);
                CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.toInterval(context, rzzzzzzzzzzzzzzzzzp_);
                CqlDateTime rzzzzzzzzzzzzzzzzzr_ = context.Operators.Start(rzzzzzzzzzzzzzzzzzq_);

                return rzzzzzzzzzzzzzzzzzr_;
            };
            IEnumerable<Observation> ozzzzzzzzzzzzzzzzzq_ = context.Operators.SortBy<Observation>(ozzzzzzzzzzzzzzzzzo_, ozzzzzzzzzzzzzzzzzp_, System.ComponentModel.ListSortDirection.Ascending);
            Observation ozzzzzzzzzzzzzzzzzr_ = context.Operators.Last<Observation>(ozzzzzzzzzzzzzzzzzq_);
            List<Observation.ComponentComponent> ozzzzzzzzzzzzzzzzzs_ = ozzzzzzzzzzzzzzzzzr_?.Component;
            bool? ozzzzzzzzzzzzzzzzzt_(Observation.ComponentComponent @this)
            {
                CodeableConcept rzzzzzzzzzzzzzzzzzs_ = @this?.Code;
                List<Coding> rzzzzzzzzzzzzzzzzzt_ = rzzzzzzzzzzzzzzzzzs_?.Coding;
                Coding rzzzzzzzzzzzzzzzzzu_ = context.Operators.First<Coding>((IEnumerable<Coding>)rzzzzzzzzzzzzzzzzzt_);
                FhirUri rzzzzzzzzzzzzzzzzzv_ = rzzzzzzzzzzzzzzzzzu_?.SystemElement;
                string rzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToString(context, rzzzzzzzzzzzzzzzzzv_);
                bool? rzzzzzzzzzzzzzzzzzx_ = context.Operators.Equal(rzzzzzzzzzzzzzzzzzw_, "http://loinc.org");
                List<Coding> rzzzzzzzzzzzzzzzzzz_ = rzzzzzzzzzzzzzzzzzs_?.Coding;
                Coding szzzzzzzzzzzzzzzzza_ = context.Operators.First<Coding>((IEnumerable<Coding>)rzzzzzzzzzzzzzzzzzz_);
                Code szzzzzzzzzzzzzzzzzb_ = szzzzzzzzzzzzzzzzza_?.CodeElement;
                string szzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToString(context, szzzzzzzzzzzzzzzzzb_);
                bool? szzzzzzzzzzzzzzzzzd_ = context.Operators.Equal(szzzzzzzzzzzzzzzzzc_, "8480-6");
                bool? szzzzzzzzzzzzzzzzze_ = context.Operators.And(rzzzzzzzzzzzzzzzzzx_, szzzzzzzzzzzzzzzzzd_);

                return szzzzzzzzzzzzzzzzze_;
            };
            IEnumerable<Observation.ComponentComponent> ozzzzzzzzzzzzzzzzzu_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)ozzzzzzzzzzzzzzzzzs_, ozzzzzzzzzzzzzzzzzt_);
            Observation.ComponentComponent ozzzzzzzzzzzzzzzzzv_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(ozzzzzzzzzzzzzzzzzu_);
            DataType ozzzzzzzzzzzzzzzzzw_ = ozzzzzzzzzzzzzzzzzv_?.Value;
            object ozzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzw_);
            CqlQuantity ozzzzzzzzzzzzzzzzzy_ = context.Operators.Quantity(130m, "mm[Hg]");
            CqlQuantity ozzzzzzzzzzzzzzzzzz_ = context.Operators.Quantity(139m, "mm[Hg]");
            CqlInterval<CqlQuantity> pzzzzzzzzzzzzzzzzza_ = context.Operators.Interval(ozzzzzzzzzzzzzzzzzy_, ozzzzzzzzzzzzzzzzzz_, true, true);
            bool? pzzzzzzzzzzzzzzzzzb_ = context.Operators.In<CqlQuantity>(ozzzzzzzzzzzzzzzzzx_ as CqlQuantity, pzzzzzzzzzzzzzzzzza_, default);
            bool? pzzzzzzzzzzzzzzzzzd_(Observation BloodPressure)
            {
                DataType szzzzzzzzzzzzzzzzzf_ = BloodPressure?.Effective;
                object szzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzf_);
                CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.toInterval(context, szzzzzzzzzzzzzzzzzg_);
                CqlDateTime szzzzzzzzzzzzzzzzzi_ = context.Operators.End(szzzzzzzzzzzzzzzzzh_);
                Period szzzzzzzzzzzzzzzzzj_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzzzzzzzzzzzzzzj_);
                bool? szzzzzzzzzzzzzzzzzl_ = context.Operators.In<CqlDateTime>(szzzzzzzzzzzzzzzzzi_, szzzzzzzzzzzzzzzzzk_, "day");
                Code<ObservationStatus> szzzzzzzzzzzzzzzzzm_ = BloodPressure?.StatusElement;
                ObservationStatus? szzzzzzzzzzzzzzzzzn_ = szzzzzzzzzzzzzzzzzm_?.Value;
                string szzzzzzzzzzzzzzzzzo_ = context.Operators.Convert<string>(szzzzzzzzzzzzzzzzzn_);
                string[] szzzzzzzzzzzzzzzzzp_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? szzzzzzzzzzzzzzzzzq_ = context.Operators.In<string>(szzzzzzzzzzzzzzzzzo_, szzzzzzzzzzzzzzzzzp_ as IEnumerable<string>);
                bool? szzzzzzzzzzzzzzzzzr_ = context.Operators.And(szzzzzzzzzzzzzzzzzl_, szzzzzzzzzzzzzzzzzq_);

                return szzzzzzzzzzzzzzzzzr_;
            };
            IEnumerable<Observation> pzzzzzzzzzzzzzzzzze_ = context.Operators.Where<Observation>(ozzzzzzzzzzzzzzzzzm_, pzzzzzzzzzzzzzzzzzd_);
            object pzzzzzzzzzzzzzzzzzf_(Observation @this)
            {
                DataType szzzzzzzzzzzzzzzzzs_ = @this?.Effective;
                object szzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzs_);
                CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.toInterval(context, szzzzzzzzzzzzzzzzzt_);
                CqlDateTime szzzzzzzzzzzzzzzzzv_ = context.Operators.Start(szzzzzzzzzzzzzzzzzu_);

                return szzzzzzzzzzzzzzzzzv_;
            };
            IEnumerable<Observation> pzzzzzzzzzzzzzzzzzg_ = context.Operators.SortBy<Observation>(pzzzzzzzzzzzzzzzzze_, pzzzzzzzzzzzzzzzzzf_, System.ComponentModel.ListSortDirection.Ascending);
            Observation pzzzzzzzzzzzzzzzzzh_ = context.Operators.Last<Observation>(pzzzzzzzzzzzzzzzzzg_);
            List<Observation.ComponentComponent> pzzzzzzzzzzzzzzzzzi_ = pzzzzzzzzzzzzzzzzzh_?.Component;
            bool? pzzzzzzzzzzzzzzzzzj_(Observation.ComponentComponent @this)
            {
                CodeableConcept szzzzzzzzzzzzzzzzzw_ = @this?.Code;
                List<Coding> szzzzzzzzzzzzzzzzzx_ = szzzzzzzzzzzzzzzzzw_?.Coding;
                Coding szzzzzzzzzzzzzzzzzy_ = context.Operators.First<Coding>((IEnumerable<Coding>)szzzzzzzzzzzzzzzzzx_);
                FhirUri szzzzzzzzzzzzzzzzzz_ = szzzzzzzzzzzzzzzzzy_?.SystemElement;
                string tzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToString(context, szzzzzzzzzzzzzzzzzz_);
                bool? tzzzzzzzzzzzzzzzzzb_ = context.Operators.Equal(tzzzzzzzzzzzzzzzzza_, "http://loinc.org");
                List<Coding> tzzzzzzzzzzzzzzzzzd_ = szzzzzzzzzzzzzzzzzw_?.Coding;
                Coding tzzzzzzzzzzzzzzzzze_ = context.Operators.First<Coding>((IEnumerable<Coding>)tzzzzzzzzzzzzzzzzzd_);
                Code tzzzzzzzzzzzzzzzzzf_ = tzzzzzzzzzzzzzzzzze_?.CodeElement;
                string tzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToString(context, tzzzzzzzzzzzzzzzzzf_);
                bool? tzzzzzzzzzzzzzzzzzh_ = context.Operators.Equal(tzzzzzzzzzzzzzzzzzg_, "8462-4");
                bool? tzzzzzzzzzzzzzzzzzi_ = context.Operators.And(tzzzzzzzzzzzzzzzzzb_, tzzzzzzzzzzzzzzzzzh_);

                return tzzzzzzzzzzzzzzzzzi_;
            };
            IEnumerable<Observation.ComponentComponent> pzzzzzzzzzzzzzzzzzk_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)pzzzzzzzzzzzzzzzzzi_, pzzzzzzzzzzzzzzzzzj_);
            Observation.ComponentComponent pzzzzzzzzzzzzzzzzzl_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(pzzzzzzzzzzzzzzzzzk_);
            DataType pzzzzzzzzzzzzzzzzzm_ = pzzzzzzzzzzzzzzzzzl_?.Value;
            object pzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzm_);
            CqlQuantity pzzzzzzzzzzzzzzzzzo_ = context.Operators.Quantity(80m, "mm[Hg]");
            CqlQuantity pzzzzzzzzzzzzzzzzzp_ = context.Operators.Quantity(89m, "mm[Hg]");
            CqlInterval<CqlQuantity> pzzzzzzzzzzzzzzzzzq_ = context.Operators.Interval(pzzzzzzzzzzzzzzzzzo_, pzzzzzzzzzzzzzzzzzp_, true, true);
            bool? pzzzzzzzzzzzzzzzzzr_ = context.Operators.In<CqlQuantity>(pzzzzzzzzzzzzzzzzzn_ as CqlQuantity, pzzzzzzzzzzzzzzzzzq_, default);
            bool? pzzzzzzzzzzzzzzzzzs_ = context.Operators.Or(pzzzzzzzzzzzzzzzzzb_, pzzzzzzzzzzzzzzzzzr_);
            bool? pzzzzzzzzzzzzzzzzzu_(Observation BloodPressure)
            {
                DataType tzzzzzzzzzzzzzzzzzj_ = BloodPressure?.Effective;
                object tzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzj_);
                CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.toInterval(context, tzzzzzzzzzzzzzzzzzk_);
                CqlDateTime tzzzzzzzzzzzzzzzzzm_ = context.Operators.End(tzzzzzzzzzzzzzzzzzl_);
                Period tzzzzzzzzzzzzzzzzzn_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzzzzzzzzzzzzzzn_);
                bool? tzzzzzzzzzzzzzzzzzp_ = context.Operators.In<CqlDateTime>(tzzzzzzzzzzzzzzzzzm_, tzzzzzzzzzzzzzzzzzo_, "day");
                Code<ObservationStatus> tzzzzzzzzzzzzzzzzzq_ = BloodPressure?.StatusElement;
                ObservationStatus? tzzzzzzzzzzzzzzzzzr_ = tzzzzzzzzzzzzzzzzzq_?.Value;
                string tzzzzzzzzzzzzzzzzzs_ = context.Operators.Convert<string>(tzzzzzzzzzzzzzzzzzr_);
                string[] tzzzzzzzzzzzzzzzzzt_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? tzzzzzzzzzzzzzzzzzu_ = context.Operators.In<string>(tzzzzzzzzzzzzzzzzzs_, tzzzzzzzzzzzzzzzzzt_ as IEnumerable<string>);
                bool? tzzzzzzzzzzzzzzzzzv_ = context.Operators.And(tzzzzzzzzzzzzzzzzzp_, tzzzzzzzzzzzzzzzzzu_);

                return tzzzzzzzzzzzzzzzzzv_;
            };
            IEnumerable<Observation> pzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Observation>(ozzzzzzzzzzzzzzzzzm_, pzzzzzzzzzzzzzzzzzu_);
            object pzzzzzzzzzzzzzzzzzw_(Observation @this)
            {
                DataType tzzzzzzzzzzzzzzzzzw_ = @this?.Effective;
                object tzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzw_);
                CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.toInterval(context, tzzzzzzzzzzzzzzzzzx_);
                CqlDateTime tzzzzzzzzzzzzzzzzzz_ = context.Operators.Start(tzzzzzzzzzzzzzzzzzy_);

                return tzzzzzzzzzzzzzzzzzz_;
            };
            IEnumerable<Observation> pzzzzzzzzzzzzzzzzzx_ = context.Operators.SortBy<Observation>(pzzzzzzzzzzzzzzzzzv_, pzzzzzzzzzzzzzzzzzw_, System.ComponentModel.ListSortDirection.Ascending);
            Observation pzzzzzzzzzzzzzzzzzy_ = context.Operators.Last<Observation>(pzzzzzzzzzzzzzzzzzx_);
            List<Observation.ComponentComponent> pzzzzzzzzzzzzzzzzzz_ = pzzzzzzzzzzzzzzzzzy_?.Component;
            bool? qzzzzzzzzzzzzzzzzza_(Observation.ComponentComponent @this)
            {
                CodeableConcept uzzzzzzzzzzzzzzzzza_ = @this?.Code;
                List<Coding> uzzzzzzzzzzzzzzzzzb_ = uzzzzzzzzzzzzzzzzza_?.Coding;
                Coding uzzzzzzzzzzzzzzzzzc_ = context.Operators.First<Coding>((IEnumerable<Coding>)uzzzzzzzzzzzzzzzzzb_);
                FhirUri uzzzzzzzzzzzzzzzzzd_ = uzzzzzzzzzzzzzzzzzc_?.SystemElement;
                string uzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToString(context, uzzzzzzzzzzzzzzzzzd_);
                bool? uzzzzzzzzzzzzzzzzzf_ = context.Operators.Equal(uzzzzzzzzzzzzzzzzze_, "http://loinc.org");
                List<Coding> uzzzzzzzzzzzzzzzzzh_ = uzzzzzzzzzzzzzzzzza_?.Coding;
                Coding uzzzzzzzzzzzzzzzzzi_ = context.Operators.First<Coding>((IEnumerable<Coding>)uzzzzzzzzzzzzzzzzzh_);
                Code uzzzzzzzzzzzzzzzzzj_ = uzzzzzzzzzzzzzzzzzi_?.CodeElement;
                string uzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToString(context, uzzzzzzzzzzzzzzzzzj_);
                bool? uzzzzzzzzzzzzzzzzzl_ = context.Operators.Equal(uzzzzzzzzzzzzzzzzzk_, "8480-6");
                bool? uzzzzzzzzzzzzzzzzzm_ = context.Operators.And(uzzzzzzzzzzzzzzzzzf_, uzzzzzzzzzzzzzzzzzl_);

                return uzzzzzzzzzzzzzzzzzm_;
            };
            IEnumerable<Observation.ComponentComponent> qzzzzzzzzzzzzzzzzzb_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)pzzzzzzzzzzzzzzzzzz_, qzzzzzzzzzzzzzzzzza_);
            Observation.ComponentComponent qzzzzzzzzzzzzzzzzzc_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(qzzzzzzzzzzzzzzzzzb_);
            DataType qzzzzzzzzzzzzzzzzzd_ = qzzzzzzzzzzzzzzzzzc_?.Value;
            object qzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzd_);
            CqlQuantity qzzzzzzzzzzzzzzzzzf_ = context.Operators.Quantity(140m, "mm[Hg]");
            bool? qzzzzzzzzzzzzzzzzzg_ = context.Operators.GreaterOrEqual(qzzzzzzzzzzzzzzzzze_ as CqlQuantity, qzzzzzzzzzzzzzzzzzf_);
            bool? qzzzzzzzzzzzzzzzzzi_(Observation BloodPressure)
            {
                DataType uzzzzzzzzzzzzzzzzzn_ = BloodPressure?.Effective;
                object uzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzn_);
                CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.toInterval(context, uzzzzzzzzzzzzzzzzzo_);
                CqlDateTime uzzzzzzzzzzzzzzzzzq_ = context.Operators.End(uzzzzzzzzzzzzzzzzzp_);
                Period uzzzzzzzzzzzzzzzzzr_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzzzzzzzzzzzzzr_);
                bool? uzzzzzzzzzzzzzzzzzt_ = context.Operators.In<CqlDateTime>(uzzzzzzzzzzzzzzzzzq_, uzzzzzzzzzzzzzzzzzs_, "day");
                Code<ObservationStatus> uzzzzzzzzzzzzzzzzzu_ = BloodPressure?.StatusElement;
                ObservationStatus? uzzzzzzzzzzzzzzzzzv_ = uzzzzzzzzzzzzzzzzzu_?.Value;
                string uzzzzzzzzzzzzzzzzzw_ = context.Operators.Convert<string>(uzzzzzzzzzzzzzzzzzv_);
                string[] uzzzzzzzzzzzzzzzzzx_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? uzzzzzzzzzzzzzzzzzy_ = context.Operators.In<string>(uzzzzzzzzzzzzzzzzzw_, uzzzzzzzzzzzzzzzzzx_ as IEnumerable<string>);
                bool? uzzzzzzzzzzzzzzzzzz_ = context.Operators.And(uzzzzzzzzzzzzzzzzzt_, uzzzzzzzzzzzzzzzzzy_);

                return uzzzzzzzzzzzzzzzzzz_;
            };
            IEnumerable<Observation> qzzzzzzzzzzzzzzzzzj_ = context.Operators.Where<Observation>(ozzzzzzzzzzzzzzzzzm_, qzzzzzzzzzzzzzzzzzi_);
            object qzzzzzzzzzzzzzzzzzk_(Observation @this)
            {
                DataType vzzzzzzzzzzzzzzzzza_ = @this?.Effective;
                object vzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzza_);
                CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.toInterval(context, vzzzzzzzzzzzzzzzzzb_);
                CqlDateTime vzzzzzzzzzzzzzzzzzd_ = context.Operators.Start(vzzzzzzzzzzzzzzzzzc_);

                return vzzzzzzzzzzzzzzzzzd_;
            };
            IEnumerable<Observation> qzzzzzzzzzzzzzzzzzl_ = context.Operators.SortBy<Observation>(qzzzzzzzzzzzzzzzzzj_, qzzzzzzzzzzzzzzzzzk_, System.ComponentModel.ListSortDirection.Ascending);
            Observation qzzzzzzzzzzzzzzzzzm_ = context.Operators.Last<Observation>(qzzzzzzzzzzzzzzzzzl_);
            List<Observation.ComponentComponent> qzzzzzzzzzzzzzzzzzn_ = qzzzzzzzzzzzzzzzzzm_?.Component;
            bool? qzzzzzzzzzzzzzzzzzo_(Observation.ComponentComponent @this)
            {
                CodeableConcept vzzzzzzzzzzzzzzzzze_ = @this?.Code;
                List<Coding> vzzzzzzzzzzzzzzzzzf_ = vzzzzzzzzzzzzzzzzze_?.Coding;
                Coding vzzzzzzzzzzzzzzzzzg_ = context.Operators.First<Coding>((IEnumerable<Coding>)vzzzzzzzzzzzzzzzzzf_);
                FhirUri vzzzzzzzzzzzzzzzzzh_ = vzzzzzzzzzzzzzzzzzg_?.SystemElement;
                string vzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToString(context, vzzzzzzzzzzzzzzzzzh_);
                bool? vzzzzzzzzzzzzzzzzzj_ = context.Operators.Equal(vzzzzzzzzzzzzzzzzzi_, "http://loinc.org");
                List<Coding> vzzzzzzzzzzzzzzzzzl_ = vzzzzzzzzzzzzzzzzze_?.Coding;
                Coding vzzzzzzzzzzzzzzzzzm_ = context.Operators.First<Coding>((IEnumerable<Coding>)vzzzzzzzzzzzzzzzzzl_);
                Code vzzzzzzzzzzzzzzzzzn_ = vzzzzzzzzzzzzzzzzzm_?.CodeElement;
                string vzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToString(context, vzzzzzzzzzzzzzzzzzn_);
                bool? vzzzzzzzzzzzzzzzzzp_ = context.Operators.Equal(vzzzzzzzzzzzzzzzzzo_, "8462-4");
                bool? vzzzzzzzzzzzzzzzzzq_ = context.Operators.And(vzzzzzzzzzzzzzzzzzj_, vzzzzzzzzzzzzzzzzzp_);

                return vzzzzzzzzzzzzzzzzzq_;
            };
            IEnumerable<Observation.ComponentComponent> qzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)qzzzzzzzzzzzzzzzzzn_, qzzzzzzzzzzzzzzzzzo_);
            Observation.ComponentComponent qzzzzzzzzzzzzzzzzzq_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(qzzzzzzzzzzzzzzzzzp_);
            DataType qzzzzzzzzzzzzzzzzzr_ = qzzzzzzzzzzzzzzzzzq_?.Value;
            object qzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzr_);
            CqlQuantity qzzzzzzzzzzzzzzzzzt_ = context.Operators.Quantity(90m, "mm[Hg]");
            bool? qzzzzzzzzzzzzzzzzzu_ = context.Operators.GreaterOrEqual(qzzzzzzzzzzzzzzzzzs_ as CqlQuantity, qzzzzzzzzzzzzzzzzzt_);
            bool? qzzzzzzzzzzzzzzzzzv_ = context.Operators.Or(qzzzzzzzzzzzzzzzzzg_, qzzzzzzzzzzzzzzzzzu_);
            bool? qzzzzzzzzzzzzzzzzzw_ = context.Operators.Not(qzzzzzzzzzzzzzzzzzv_);
            bool? qzzzzzzzzzzzzzzzzzx_ = context.Operators.And(pzzzzzzzzzzzzzzzzzs_, qzzzzzzzzzzzzzzzzzw_);
            IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzy_ = this.Encounter_with_Hypertensive_Reading_Within_Year_Prior(context);
            bool? qzzzzzzzzzzzzzzzzzz_ = context.Operators.Exists<Encounter>(qzzzzzzzzzzzzzzzzzy_);
            bool? rzzzzzzzzzzzzzzzzza_ = context.Operators.And(qzzzzzzzzzzzzzzzzzx_, qzzzzzzzzzzzzzzzzzz_);

            return rzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Encounter>(ozzzzzzzzzzzzzzzzzj_, ozzzzzzzzzzzzzzzzzk_);

        return ozzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Laboratory Test or ECG for Hypertension")]
    public IEnumerable<ServiceRequest> Laboratory_Test_or_ECG_for_Hypertension(CqlContext context)
    {
        CqlCode vzzzzzzzzzzzzzzzzzr_ = this._12_lead_EKG_panel(context);
        IEnumerable<CqlCode> vzzzzzzzzzzzzzzzzzs_ = context.Operators.ToList<CqlCode>(vzzzzzzzzzzzzzzzzzr_);
        IEnumerable<ServiceRequest> vzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, default, vzzzzzzzzzzzzzzzzzs_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        CqlCode vzzzzzzzzzzzzzzzzzu_ = this.EKG_study(context);
        IEnumerable<CqlCode> vzzzzzzzzzzzzzzzzzv_ = context.Operators.ToList<CqlCode>(vzzzzzzzzzzzzzzzzzu_);
        IEnumerable<ServiceRequest> vzzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, default, vzzzzzzzzzzzzzzzzzv_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> vzzzzzzzzzzzzzzzzzx_ = context.Operators.Union<ServiceRequest>(vzzzzzzzzzzzzzzzzzt_, vzzzzzzzzzzzzzzzzzw_);
        CqlValueSet vzzzzzzzzzzzzzzzzzy_ = this.Laboratory_Tests_for_Hypertension(context);
        IEnumerable<ServiceRequest> vzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> wzzzzzzzzzzzzzzzzza_ = context.Operators.Union<ServiceRequest>(vzzzzzzzzzzzzzzzzzx_, vzzzzzzzzzzzzzzzzzz_);
        bool? wzzzzzzzzzzzzzzzzzb_(ServiceRequest EKGLab)
        {
            Code<RequestIntent> wzzzzzzzzzzzzzzzzzd_ = EKGLab?.IntentElement;
            RequestIntent? wzzzzzzzzzzzzzzzzze_ = wzzzzzzzzzzzzzzzzzd_?.Value;
            Code<RequestIntent> wzzzzzzzzzzzzzzzzzf_ = context.Operators.Convert<Code<RequestIntent>>(wzzzzzzzzzzzzzzzzze_);
            bool? wzzzzzzzzzzzzzzzzzg_ = context.Operators.Equivalent(wzzzzzzzzzzzzzzzzzf_, "order");

            return wzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<ServiceRequest> wzzzzzzzzzzzzzzzzzc_ = context.Operators.Where<ServiceRequest>(wzzzzzzzzzzzzzzzzza_, wzzzzzzzzzzzzzzzzzb_);

        return wzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Second Hypertensive Reading SBP 130 to 139 OR DBP 80 to 89 and Interventions")]
    public IEnumerable<ServiceRequest> Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89_and_Interventions(CqlContext context)
    {
        IEnumerable<ServiceRequest> wzzzzzzzzzzzzzzzzzh_ = this.Follow_up_with_Rescreen_Within_6_Months(context);
        IEnumerable<ServiceRequest> wzzzzzzzzzzzzzzzzzi_(ServiceRequest Rescreen2to6)
        {
            IEnumerable<ServiceRequest> wzzzzzzzzzzzzzzzzzm_ = this.Laboratory_Test_or_ECG_for_Hypertension(context);
            bool? wzzzzzzzzzzzzzzzzzn_(ServiceRequest LabECGIntervention)
            {
                FhirDateTime wzzzzzzzzzzzzzzzzzr_ = Rescreen2to6?.AuthoredOnElement;
                CqlDateTime wzzzzzzzzzzzzzzzzzs_ = context.Operators.Convert<CqlDateTime>(wzzzzzzzzzzzzzzzzzr_);
                CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzt_ = this.Measurement_Period(context);
                bool? wzzzzzzzzzzzzzzzzzu_ = context.Operators.In<CqlDateTime>(wzzzzzzzzzzzzzzzzzs_, wzzzzzzzzzzzzzzzzzt_, "day");
                FhirDateTime wzzzzzzzzzzzzzzzzzv_ = LabECGIntervention?.AuthoredOnElement;
                CqlDateTime wzzzzzzzzzzzzzzzzzw_ = context.Operators.Convert<CqlDateTime>(wzzzzzzzzzzzzzzzzzv_);
                bool? wzzzzzzzzzzzzzzzzzy_ = context.Operators.In<CqlDateTime>(wzzzzzzzzzzzzzzzzzw_, wzzzzzzzzzzzzzzzzzt_, "day");
                bool? wzzzzzzzzzzzzzzzzzz_ = context.Operators.And(wzzzzzzzzzzzzzzzzzu_, wzzzzzzzzzzzzzzzzzy_);

                return wzzzzzzzzzzzzzzzzzz_;
            };
            IEnumerable<ServiceRequest> wzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<ServiceRequest>(wzzzzzzzzzzzzzzzzzm_, wzzzzzzzzzzzzzzzzzn_);
            ServiceRequest wzzzzzzzzzzzzzzzzzp_(ServiceRequest LabECGIntervention) =>
                Rescreen2to6;
            IEnumerable<ServiceRequest> wzzzzzzzzzzzzzzzzzq_ = context.Operators.Select<ServiceRequest, ServiceRequest>(wzzzzzzzzzzzzzzzzzo_, wzzzzzzzzzzzzzzzzzp_);

            return wzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<ServiceRequest> wzzzzzzzzzzzzzzzzzj_ = context.Operators.SelectMany<ServiceRequest, ServiceRequest>(wzzzzzzzzzzzzzzzzzh_, wzzzzzzzzzzzzzzzzzi_);
        IEnumerable<ServiceRequest> wzzzzzzzzzzzzzzzzzk_(ServiceRequest Rescreen2to6)
        {
            IEnumerable<ServiceRequest> xzzzzzzzzzzzzzzzzza_ = this.NonPharmacological_Interventions(context);
            bool? xzzzzzzzzzzzzzzzzzb_(ServiceRequest NonPharmSecondIntervention)
            {
                FhirDateTime xzzzzzzzzzzzzzzzzzf_ = NonPharmSecondIntervention?.AuthoredOnElement;
                CqlDateTime xzzzzzzzzzzzzzzzzzg_ = context.Operators.Convert<CqlDateTime>(xzzzzzzzzzzzzzzzzzf_);
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzh_ = this.Measurement_Period(context);
                bool? xzzzzzzzzzzzzzzzzzi_ = context.Operators.In<CqlDateTime>(xzzzzzzzzzzzzzzzzzg_, xzzzzzzzzzzzzzzzzzh_, "day");

                return xzzzzzzzzzzzzzzzzzi_;
            };
            IEnumerable<ServiceRequest> xzzzzzzzzzzzzzzzzzc_ = context.Operators.Where<ServiceRequest>(xzzzzzzzzzzzzzzzzza_, xzzzzzzzzzzzzzzzzzb_);
            ServiceRequest xzzzzzzzzzzzzzzzzzd_(ServiceRequest NonPharmSecondIntervention) =>
                Rescreen2to6;
            IEnumerable<ServiceRequest> xzzzzzzzzzzzzzzzzze_ = context.Operators.Select<ServiceRequest, ServiceRequest>(xzzzzzzzzzzzzzzzzzc_, xzzzzzzzzzzzzzzzzzd_);

            return xzzzzzzzzzzzzzzzzze_;
        };
        IEnumerable<ServiceRequest> wzzzzzzzzzzzzzzzzzl_ = context.Operators.SelectMany<ServiceRequest, ServiceRequest>(wzzzzzzzzzzzzzzzzzj_, wzzzzzzzzzzzzzzzzzk_);

        return wzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Encounter with Second Hypertensive Reading SBP 130 to 139 OR DBP 80 to 89 and Interventions")]
    public IEnumerable<Encounter> Encounter_with_Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89_and_Interventions(CqlContext context)
    {
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzj_ = this.Encounter_with_Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89(context);
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzk_(Encounter SecondHTNEncounterReading)
        {
            IEnumerable<ServiceRequest> xzzzzzzzzzzzzzzzzzq_ = this.Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89_and_Interventions(context);
            bool? xzzzzzzzzzzzzzzzzzr_(ServiceRequest EncounterInterventions)
            {
                FhirDateTime xzzzzzzzzzzzzzzzzzv_ = EncounterInterventions?.AuthoredOnElement;
                CqlDateTime xzzzzzzzzzzzzzzzzzw_ = context.Operators.Convert<CqlDateTime>(xzzzzzzzzzzzzzzzzzv_);
                Period xzzzzzzzzzzzzzzzzzx_ = SecondHTNEncounterReading?.Period;
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzzzzzzzzzzzzx_);
                bool? xzzzzzzzzzzzzzzzzzz_ = context.Operators.In<CqlDateTime>(xzzzzzzzzzzzzzzzzzw_, xzzzzzzzzzzzzzzzzzy_, "day");

                return xzzzzzzzzzzzzzzzzzz_;
            };
            IEnumerable<ServiceRequest> xzzzzzzzzzzzzzzzzzs_ = context.Operators.Where<ServiceRequest>(xzzzzzzzzzzzzzzzzzq_, xzzzzzzzzzzzzzzzzzr_);
            Encounter xzzzzzzzzzzzzzzzzzt_(ServiceRequest EncounterInterventions) =>
                SecondHTNEncounterReading;
            IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzu_ = context.Operators.Select<ServiceRequest, Encounter>(xzzzzzzzzzzzzzzzzzs_, xzzzzzzzzzzzzzzzzzt_);

            return xzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzl_ = context.Operators.SelectMany<Encounter, Encounter>(xzzzzzzzzzzzzzzzzzj_, xzzzzzzzzzzzzzzzzzk_);
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzn_(Encounter SecondHTNEncounterReading)
        {
            IEnumerable<ServiceRequest> yzzzzzzzzzzzzzzzzza_ = this.Referral_to_Alternate_or_Primary_Healthcare_Professional_for_Hypertensive_Reading(context);
            bool? yzzzzzzzzzzzzzzzzzb_(ServiceRequest ReferralForHTN)
            {
                FhirDateTime yzzzzzzzzzzzzzzzzzf_ = ReferralForHTN?.AuthoredOnElement;
                CqlDateTime yzzzzzzzzzzzzzzzzzg_ = context.Operators.Convert<CqlDateTime>(yzzzzzzzzzzzzzzzzzf_);
                Period yzzzzzzzzzzzzzzzzzh_ = SecondHTNEncounterReading?.Period;
                CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzzzzzzzzzzzzzzh_);
                bool? yzzzzzzzzzzzzzzzzzj_ = context.Operators.In<CqlDateTime>(yzzzzzzzzzzzzzzzzzg_, yzzzzzzzzzzzzzzzzzi_, "day");

                return yzzzzzzzzzzzzzzzzzj_;
            };
            IEnumerable<ServiceRequest> yzzzzzzzzzzzzzzzzzc_ = context.Operators.Where<ServiceRequest>(yzzzzzzzzzzzzzzzzza_, yzzzzzzzzzzzzzzzzzb_);
            Encounter yzzzzzzzzzzzzzzzzzd_(ServiceRequest ReferralForHTN) =>
                SecondHTNEncounterReading;
            IEnumerable<Encounter> yzzzzzzzzzzzzzzzzze_ = context.Operators.Select<ServiceRequest, Encounter>(yzzzzzzzzzzzzzzzzzc_, yzzzzzzzzzzzzzzzzzd_);

            return yzzzzzzzzzzzzzzzzze_;
        };
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzo_ = context.Operators.SelectMany<Encounter, Encounter>(xzzzzzzzzzzzzzzzzzj_, xzzzzzzzzzzzzzzzzzn_);
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzp_ = context.Operators.Union<Encounter>(xzzzzzzzzzzzzzzzzzl_, xzzzzzzzzzzzzzzzzzo_);

        return xzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Encounter with Second Hypertensive Reading SBP Greater than or Equal to 140 OR DBP Greater than or Equal to 90")]
    public IEnumerable<Encounter> Encounter_with_Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90(CqlContext context)
    {
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzk_ = this.Qualifying_Encounter_during_Measurement_Period(context);
        bool? yzzzzzzzzzzzzzzzzzl_(Encounter QualifyingEncounter)
        {
            IEnumerable<Observation> yzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/bp"));
            bool? yzzzzzzzzzzzzzzzzzo_(Observation BloodPressure)
            {
                DataType azzzzzzzzzzzzzzzzzzx_ = BloodPressure?.Effective;
                object azzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzx_);
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.toInterval(context, azzzzzzzzzzzzzzzzzzy_);
                CqlDateTime bzzzzzzzzzzzzzzzzzza_ = context.Operators.End(azzzzzzzzzzzzzzzzzzz_);
                Period bzzzzzzzzzzzzzzzzzzb_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzzzzzzzzzzzzb_);
                bool? bzzzzzzzzzzzzzzzzzzd_ = context.Operators.In<CqlDateTime>(bzzzzzzzzzzzzzzzzzza_, bzzzzzzzzzzzzzzzzzzc_, default);
                Code<ObservationStatus> bzzzzzzzzzzzzzzzzzze_ = BloodPressure?.StatusElement;
                ObservationStatus? bzzzzzzzzzzzzzzzzzzf_ = bzzzzzzzzzzzzzzzzzze_?.Value;
                string bzzzzzzzzzzzzzzzzzzg_ = context.Operators.Convert<string>(bzzzzzzzzzzzzzzzzzzf_);
                string[] bzzzzzzzzzzzzzzzzzzh_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? bzzzzzzzzzzzzzzzzzzi_ = context.Operators.In<string>(bzzzzzzzzzzzzzzzzzzg_, bzzzzzzzzzzzzzzzzzzh_ as IEnumerable<string>);
                bool? bzzzzzzzzzzzzzzzzzzj_ = context.Operators.And(bzzzzzzzzzzzzzzzzzzd_, bzzzzzzzzzzzzzzzzzzi_);

                return bzzzzzzzzzzzzzzzzzzj_;
            };
            IEnumerable<Observation> yzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Observation>(yzzzzzzzzzzzzzzzzzn_, yzzzzzzzzzzzzzzzzzo_);
            object yzzzzzzzzzzzzzzzzzq_(Observation @this)
            {
                DataType bzzzzzzzzzzzzzzzzzzk_ = @this?.Effective;
                object bzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzk_);
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.toInterval(context, bzzzzzzzzzzzzzzzzzzl_);
                CqlDateTime bzzzzzzzzzzzzzzzzzzn_ = context.Operators.Start(bzzzzzzzzzzzzzzzzzzm_);

                return bzzzzzzzzzzzzzzzzzzn_;
            };
            IEnumerable<Observation> yzzzzzzzzzzzzzzzzzr_ = context.Operators.SortBy<Observation>(yzzzzzzzzzzzzzzzzzp_, yzzzzzzzzzzzzzzzzzq_, System.ComponentModel.ListSortDirection.Ascending);
            Observation yzzzzzzzzzzzzzzzzzs_ = context.Operators.Last<Observation>(yzzzzzzzzzzzzzzzzzr_);
            List<Observation.ComponentComponent> yzzzzzzzzzzzzzzzzzt_ = yzzzzzzzzzzzzzzzzzs_?.Component;
            bool? yzzzzzzzzzzzzzzzzzu_(Observation.ComponentComponent @this)
            {
                CodeableConcept bzzzzzzzzzzzzzzzzzzo_ = @this?.Code;
                List<Coding> bzzzzzzzzzzzzzzzzzzp_ = bzzzzzzzzzzzzzzzzzzo_?.Coding;
                Coding bzzzzzzzzzzzzzzzzzzq_ = context.Operators.First<Coding>((IEnumerable<Coding>)bzzzzzzzzzzzzzzzzzzp_);
                FhirUri bzzzzzzzzzzzzzzzzzzr_ = bzzzzzzzzzzzzzzzzzzq_?.SystemElement;
                string bzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToString(context, bzzzzzzzzzzzzzzzzzzr_);
                bool? bzzzzzzzzzzzzzzzzzzt_ = context.Operators.Equal(bzzzzzzzzzzzzzzzzzzs_, "http://loinc.org");
                List<Coding> bzzzzzzzzzzzzzzzzzzv_ = bzzzzzzzzzzzzzzzzzzo_?.Coding;
                Coding bzzzzzzzzzzzzzzzzzzw_ = context.Operators.First<Coding>((IEnumerable<Coding>)bzzzzzzzzzzzzzzzzzzv_);
                Code bzzzzzzzzzzzzzzzzzzx_ = bzzzzzzzzzzzzzzzzzzw_?.CodeElement;
                string bzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToString(context, bzzzzzzzzzzzzzzzzzzx_);
                bool? bzzzzzzzzzzzzzzzzzzz_ = context.Operators.Equal(bzzzzzzzzzzzzzzzzzzy_, "8480-6");
                bool? czzzzzzzzzzzzzzzzzza_ = context.Operators.And(bzzzzzzzzzzzzzzzzzzt_, bzzzzzzzzzzzzzzzzzzz_);

                return czzzzzzzzzzzzzzzzzza_;
            };
            IEnumerable<Observation.ComponentComponent> yzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)yzzzzzzzzzzzzzzzzzt_, yzzzzzzzzzzzzzzzzzu_);
            Observation.ComponentComponent yzzzzzzzzzzzzzzzzzw_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(yzzzzzzzzzzzzzzzzzv_);
            DataType yzzzzzzzzzzzzzzzzzx_ = yzzzzzzzzzzzzzzzzzw_?.Value;
            object yzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzx_);
            CqlQuantity yzzzzzzzzzzzzzzzzzz_ = context.Operators.Quantity(0m, "mm[Hg]");
            bool? zzzzzzzzzzzzzzzzzza_ = context.Operators.Greater(yzzzzzzzzzzzzzzzzzy_ as CqlQuantity, yzzzzzzzzzzzzzzzzzz_);
            bool? zzzzzzzzzzzzzzzzzzc_(Observation BloodPressure)
            {
                DataType czzzzzzzzzzzzzzzzzzb_ = BloodPressure?.Effective;
                object czzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzb_);
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.toInterval(context, czzzzzzzzzzzzzzzzzzc_);
                CqlDateTime czzzzzzzzzzzzzzzzzze_ = context.Operators.End(czzzzzzzzzzzzzzzzzzd_);
                Period czzzzzzzzzzzzzzzzzzf_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzzzzzzzzzzzzzzf_);
                bool? czzzzzzzzzzzzzzzzzzh_ = context.Operators.In<CqlDateTime>(czzzzzzzzzzzzzzzzzze_, czzzzzzzzzzzzzzzzzzg_, default);
                Code<ObservationStatus> czzzzzzzzzzzzzzzzzzi_ = BloodPressure?.StatusElement;
                ObservationStatus? czzzzzzzzzzzzzzzzzzj_ = czzzzzzzzzzzzzzzzzzi_?.Value;
                string czzzzzzzzzzzzzzzzzzk_ = context.Operators.Convert<string>(czzzzzzzzzzzzzzzzzzj_);
                string[] czzzzzzzzzzzzzzzzzzl_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? czzzzzzzzzzzzzzzzzzm_ = context.Operators.In<string>(czzzzzzzzzzzzzzzzzzk_, czzzzzzzzzzzzzzzzzzl_ as IEnumerable<string>);
                bool? czzzzzzzzzzzzzzzzzzn_ = context.Operators.And(czzzzzzzzzzzzzzzzzzh_, czzzzzzzzzzzzzzzzzzm_);

                return czzzzzzzzzzzzzzzzzzn_;
            };
            IEnumerable<Observation> zzzzzzzzzzzzzzzzzzd_ = context.Operators.Where<Observation>(yzzzzzzzzzzzzzzzzzn_, zzzzzzzzzzzzzzzzzzc_);
            object zzzzzzzzzzzzzzzzzze_(Observation @this)
            {
                DataType czzzzzzzzzzzzzzzzzzo_ = @this?.Effective;
                object czzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzo_);
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.toInterval(context, czzzzzzzzzzzzzzzzzzp_);
                CqlDateTime czzzzzzzzzzzzzzzzzzr_ = context.Operators.Start(czzzzzzzzzzzzzzzzzzq_);

                return czzzzzzzzzzzzzzzzzzr_;
            };
            IEnumerable<Observation> zzzzzzzzzzzzzzzzzzf_ = context.Operators.SortBy<Observation>(zzzzzzzzzzzzzzzzzzd_, zzzzzzzzzzzzzzzzzze_, System.ComponentModel.ListSortDirection.Ascending);
            Observation zzzzzzzzzzzzzzzzzzg_ = context.Operators.Last<Observation>(zzzzzzzzzzzzzzzzzzf_);
            List<Observation.ComponentComponent> zzzzzzzzzzzzzzzzzzh_ = zzzzzzzzzzzzzzzzzzg_?.Component;
            bool? zzzzzzzzzzzzzzzzzzi_(Observation.ComponentComponent @this)
            {
                CodeableConcept czzzzzzzzzzzzzzzzzzs_ = @this?.Code;
                List<Coding> czzzzzzzzzzzzzzzzzzt_ = czzzzzzzzzzzzzzzzzzs_?.Coding;
                Coding czzzzzzzzzzzzzzzzzzu_ = context.Operators.First<Coding>((IEnumerable<Coding>)czzzzzzzzzzzzzzzzzzt_);
                FhirUri czzzzzzzzzzzzzzzzzzv_ = czzzzzzzzzzzzzzzzzzu_?.SystemElement;
                string czzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToString(context, czzzzzzzzzzzzzzzzzzv_);
                bool? czzzzzzzzzzzzzzzzzzx_ = context.Operators.Equal(czzzzzzzzzzzzzzzzzzw_, "http://loinc.org");
                List<Coding> czzzzzzzzzzzzzzzzzzz_ = czzzzzzzzzzzzzzzzzzs_?.Coding;
                Coding dzzzzzzzzzzzzzzzzzza_ = context.Operators.First<Coding>((IEnumerable<Coding>)czzzzzzzzzzzzzzzzzzz_);
                Code dzzzzzzzzzzzzzzzzzzb_ = dzzzzzzzzzzzzzzzzzza_?.CodeElement;
                string dzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToString(context, dzzzzzzzzzzzzzzzzzzb_);
                bool? dzzzzzzzzzzzzzzzzzzd_ = context.Operators.Equal(dzzzzzzzzzzzzzzzzzzc_, "8462-4");
                bool? dzzzzzzzzzzzzzzzzzze_ = context.Operators.And(czzzzzzzzzzzzzzzzzzx_, dzzzzzzzzzzzzzzzzzzd_);

                return dzzzzzzzzzzzzzzzzzze_;
            };
            IEnumerable<Observation.ComponentComponent> zzzzzzzzzzzzzzzzzzj_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)zzzzzzzzzzzzzzzzzzh_, zzzzzzzzzzzzzzzzzzi_);
            Observation.ComponentComponent zzzzzzzzzzzzzzzzzzk_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(zzzzzzzzzzzzzzzzzzj_);
            DataType zzzzzzzzzzzzzzzzzzl_ = zzzzzzzzzzzzzzzzzzk_?.Value;
            object zzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzl_);
            bool? zzzzzzzzzzzzzzzzzzo_ = context.Operators.Greater(zzzzzzzzzzzzzzzzzzm_ as CqlQuantity, yzzzzzzzzzzzzzzzzzz_);
            bool? zzzzzzzzzzzzzzzzzzp_ = context.Operators.And(zzzzzzzzzzzzzzzzzza_, zzzzzzzzzzzzzzzzzzo_);
            bool? zzzzzzzzzzzzzzzzzzr_(Observation BloodPressure)
            {
                DataType dzzzzzzzzzzzzzzzzzzf_ = BloodPressure?.Effective;
                object dzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzf_);
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.toInterval(context, dzzzzzzzzzzzzzzzzzzg_);
                CqlDateTime dzzzzzzzzzzzzzzzzzzi_ = context.Operators.End(dzzzzzzzzzzzzzzzzzzh_);
                Period dzzzzzzzzzzzzzzzzzzj_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzzzzzzzzzzzzzzzj_);
                bool? dzzzzzzzzzzzzzzzzzzl_ = context.Operators.In<CqlDateTime>(dzzzzzzzzzzzzzzzzzzi_, dzzzzzzzzzzzzzzzzzzk_, default);
                Code<ObservationStatus> dzzzzzzzzzzzzzzzzzzm_ = BloodPressure?.StatusElement;
                ObservationStatus? dzzzzzzzzzzzzzzzzzzn_ = dzzzzzzzzzzzzzzzzzzm_?.Value;
                string dzzzzzzzzzzzzzzzzzzo_ = context.Operators.Convert<string>(dzzzzzzzzzzzzzzzzzzn_);
                string[] dzzzzzzzzzzzzzzzzzzp_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? dzzzzzzzzzzzzzzzzzzq_ = context.Operators.In<string>(dzzzzzzzzzzzzzzzzzzo_, dzzzzzzzzzzzzzzzzzzp_ as IEnumerable<string>);
                bool? dzzzzzzzzzzzzzzzzzzr_ = context.Operators.And(dzzzzzzzzzzzzzzzzzzl_, dzzzzzzzzzzzzzzzzzzq_);

                return dzzzzzzzzzzzzzzzzzzr_;
            };
            IEnumerable<Observation> zzzzzzzzzzzzzzzzzzs_ = context.Operators.Where<Observation>(yzzzzzzzzzzzzzzzzzn_, zzzzzzzzzzzzzzzzzzr_);
            object zzzzzzzzzzzzzzzzzzt_(Observation @this)
            {
                DataType dzzzzzzzzzzzzzzzzzzs_ = @this?.Effective;
                object dzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzs_);
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.toInterval(context, dzzzzzzzzzzzzzzzzzzt_);
                CqlDateTime dzzzzzzzzzzzzzzzzzzv_ = context.Operators.Start(dzzzzzzzzzzzzzzzzzzu_);

                return dzzzzzzzzzzzzzzzzzzv_;
            };
            IEnumerable<Observation> zzzzzzzzzzzzzzzzzzu_ = context.Operators.SortBy<Observation>(zzzzzzzzzzzzzzzzzzs_, zzzzzzzzzzzzzzzzzzt_, System.ComponentModel.ListSortDirection.Ascending);
            Observation zzzzzzzzzzzzzzzzzzv_ = context.Operators.Last<Observation>(zzzzzzzzzzzzzzzzzzu_);
            List<Observation.ComponentComponent> zzzzzzzzzzzzzzzzzzw_ = zzzzzzzzzzzzzzzzzzv_?.Component;
            bool? zzzzzzzzzzzzzzzzzzx_(Observation.ComponentComponent @this)
            {
                CodeableConcept dzzzzzzzzzzzzzzzzzzw_ = @this?.Code;
                List<Coding> dzzzzzzzzzzzzzzzzzzx_ = dzzzzzzzzzzzzzzzzzzw_?.Coding;
                Coding dzzzzzzzzzzzzzzzzzzy_ = context.Operators.First<Coding>((IEnumerable<Coding>)dzzzzzzzzzzzzzzzzzzx_);
                FhirUri dzzzzzzzzzzzzzzzzzzz_ = dzzzzzzzzzzzzzzzzzzy_?.SystemElement;
                string ezzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToString(context, dzzzzzzzzzzzzzzzzzzz_);
                bool? ezzzzzzzzzzzzzzzzzzb_ = context.Operators.Equal(ezzzzzzzzzzzzzzzzzza_, "http://loinc.org");
                List<Coding> ezzzzzzzzzzzzzzzzzzd_ = dzzzzzzzzzzzzzzzzzzw_?.Coding;
                Coding ezzzzzzzzzzzzzzzzzze_ = context.Operators.First<Coding>((IEnumerable<Coding>)ezzzzzzzzzzzzzzzzzzd_);
                Code ezzzzzzzzzzzzzzzzzzf_ = ezzzzzzzzzzzzzzzzzze_?.CodeElement;
                string ezzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToString(context, ezzzzzzzzzzzzzzzzzzf_);
                bool? ezzzzzzzzzzzzzzzzzzh_ = context.Operators.Equal(ezzzzzzzzzzzzzzzzzzg_, "8480-6");
                bool? ezzzzzzzzzzzzzzzzzzi_ = context.Operators.And(ezzzzzzzzzzzzzzzzzzb_, ezzzzzzzzzzzzzzzzzzh_);

                return ezzzzzzzzzzzzzzzzzzi_;
            };
            IEnumerable<Observation.ComponentComponent> zzzzzzzzzzzzzzzzzzy_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)zzzzzzzzzzzzzzzzzzw_, zzzzzzzzzzzzzzzzzzx_);
            Observation.ComponentComponent zzzzzzzzzzzzzzzzzzz_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(zzzzzzzzzzzzzzzzzzy_);
            DataType azzzzzzzzzzzzzzzzzza_ = zzzzzzzzzzzzzzzzzzz_?.Value;
            object azzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzza_);
            CqlQuantity azzzzzzzzzzzzzzzzzzc_ = context.Operators.Quantity(140m, "mm[Hg]");
            bool? azzzzzzzzzzzzzzzzzzd_ = context.Operators.GreaterOrEqual(azzzzzzzzzzzzzzzzzzb_ as CqlQuantity, azzzzzzzzzzzzzzzzzzc_);
            bool? azzzzzzzzzzzzzzzzzzf_(Observation BloodPressure)
            {
                DataType ezzzzzzzzzzzzzzzzzzj_ = BloodPressure?.Effective;
                object ezzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzj_);
                CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.toInterval(context, ezzzzzzzzzzzzzzzzzzk_);
                CqlDateTime ezzzzzzzzzzzzzzzzzzm_ = context.Operators.End(ezzzzzzzzzzzzzzzzzzl_);
                Period ezzzzzzzzzzzzzzzzzzn_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzzzzzzzzzzzzzzn_);
                bool? ezzzzzzzzzzzzzzzzzzp_ = context.Operators.In<CqlDateTime>(ezzzzzzzzzzzzzzzzzzm_, ezzzzzzzzzzzzzzzzzzo_, default);
                Code<ObservationStatus> ezzzzzzzzzzzzzzzzzzq_ = BloodPressure?.StatusElement;
                ObservationStatus? ezzzzzzzzzzzzzzzzzzr_ = ezzzzzzzzzzzzzzzzzzq_?.Value;
                string ezzzzzzzzzzzzzzzzzzs_ = context.Operators.Convert<string>(ezzzzzzzzzzzzzzzzzzr_);
                string[] ezzzzzzzzzzzzzzzzzzt_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? ezzzzzzzzzzzzzzzzzzu_ = context.Operators.In<string>(ezzzzzzzzzzzzzzzzzzs_, ezzzzzzzzzzzzzzzzzzt_ as IEnumerable<string>);
                bool? ezzzzzzzzzzzzzzzzzzv_ = context.Operators.And(ezzzzzzzzzzzzzzzzzzp_, ezzzzzzzzzzzzzzzzzzu_);

                return ezzzzzzzzzzzzzzzzzzv_;
            };
            IEnumerable<Observation> azzzzzzzzzzzzzzzzzzg_ = context.Operators.Where<Observation>(yzzzzzzzzzzzzzzzzzn_, azzzzzzzzzzzzzzzzzzf_);
            object azzzzzzzzzzzzzzzzzzh_(Observation @this)
            {
                DataType ezzzzzzzzzzzzzzzzzzw_ = @this?.Effective;
                object ezzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzw_);
                CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.toInterval(context, ezzzzzzzzzzzzzzzzzzx_);
                CqlDateTime ezzzzzzzzzzzzzzzzzzz_ = context.Operators.Start(ezzzzzzzzzzzzzzzzzzy_);

                return ezzzzzzzzzzzzzzzzzzz_;
            };
            IEnumerable<Observation> azzzzzzzzzzzzzzzzzzi_ = context.Operators.SortBy<Observation>(azzzzzzzzzzzzzzzzzzg_, azzzzzzzzzzzzzzzzzzh_, System.ComponentModel.ListSortDirection.Ascending);
            Observation azzzzzzzzzzzzzzzzzzj_ = context.Operators.Last<Observation>(azzzzzzzzzzzzzzzzzzi_);
            List<Observation.ComponentComponent> azzzzzzzzzzzzzzzzzzk_ = azzzzzzzzzzzzzzzzzzj_?.Component;
            bool? azzzzzzzzzzzzzzzzzzl_(Observation.ComponentComponent @this)
            {
                CodeableConcept fzzzzzzzzzzzzzzzzzza_ = @this?.Code;
                List<Coding> fzzzzzzzzzzzzzzzzzzb_ = fzzzzzzzzzzzzzzzzzza_?.Coding;
                Coding fzzzzzzzzzzzzzzzzzzc_ = context.Operators.First<Coding>((IEnumerable<Coding>)fzzzzzzzzzzzzzzzzzzb_);
                FhirUri fzzzzzzzzzzzzzzzzzzd_ = fzzzzzzzzzzzzzzzzzzc_?.SystemElement;
                string fzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToString(context, fzzzzzzzzzzzzzzzzzzd_);
                bool? fzzzzzzzzzzzzzzzzzzf_ = context.Operators.Equal(fzzzzzzzzzzzzzzzzzze_, "http://loinc.org");
                List<Coding> fzzzzzzzzzzzzzzzzzzh_ = fzzzzzzzzzzzzzzzzzza_?.Coding;
                Coding fzzzzzzzzzzzzzzzzzzi_ = context.Operators.First<Coding>((IEnumerable<Coding>)fzzzzzzzzzzzzzzzzzzh_);
                Code fzzzzzzzzzzzzzzzzzzj_ = fzzzzzzzzzzzzzzzzzzi_?.CodeElement;
                string fzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToString(context, fzzzzzzzzzzzzzzzzzzj_);
                bool? fzzzzzzzzzzzzzzzzzzl_ = context.Operators.Equal(fzzzzzzzzzzzzzzzzzzk_, "8462-4");
                bool? fzzzzzzzzzzzzzzzzzzm_ = context.Operators.And(fzzzzzzzzzzzzzzzzzzf_, fzzzzzzzzzzzzzzzzzzl_);

                return fzzzzzzzzzzzzzzzzzzm_;
            };
            IEnumerable<Observation.ComponentComponent> azzzzzzzzzzzzzzzzzzm_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)azzzzzzzzzzzzzzzzzzk_, azzzzzzzzzzzzzzzzzzl_);
            Observation.ComponentComponent azzzzzzzzzzzzzzzzzzn_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(azzzzzzzzzzzzzzzzzzm_);
            DataType azzzzzzzzzzzzzzzzzzo_ = azzzzzzzzzzzzzzzzzzn_?.Value;
            object azzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzo_);
            CqlQuantity azzzzzzzzzzzzzzzzzzq_ = context.Operators.Quantity(90m, "mm[Hg]");
            bool? azzzzzzzzzzzzzzzzzzr_ = context.Operators.GreaterOrEqual(azzzzzzzzzzzzzzzzzzp_ as CqlQuantity, azzzzzzzzzzzzzzzzzzq_);
            bool? azzzzzzzzzzzzzzzzzzs_ = context.Operators.Or(azzzzzzzzzzzzzzzzzzd_, azzzzzzzzzzzzzzzzzzr_);
            bool? azzzzzzzzzzzzzzzzzzt_ = context.Operators.And(zzzzzzzzzzzzzzzzzzp_, azzzzzzzzzzzzzzzzzzs_);
            IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzu_ = this.Encounter_with_Hypertensive_Reading_Within_Year_Prior(context);
            bool? azzzzzzzzzzzzzzzzzzv_ = context.Operators.Exists<Encounter>(azzzzzzzzzzzzzzzzzzu_);
            bool? azzzzzzzzzzzzzzzzzzw_ = context.Operators.And(azzzzzzzzzzzzzzzzzzt_, azzzzzzzzzzzzzzzzzzv_);

            return azzzzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzm_ = context.Operators.Where<Encounter>(yzzzzzzzzzzzzzzzzzk_, yzzzzzzzzzzzzzzzzzl_);

        return yzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Second Hypertensive Reading SBP Greater than or Equal to 140 OR DBP Greater than or Equal to 90 Interventions")]
    public IEnumerable<ServiceRequest> Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90_Interventions(CqlContext context)
    {
        CqlValueSet fzzzzzzzzzzzzzzzzzzn_ = this.Follow_Up_Within_4_Weeks(context);
        IEnumerable<ServiceRequest> fzzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> fzzzzzzzzzzzzzzzzzzp_(ServiceRequest WeeksRescreen)
        {
            IEnumerable<ServiceRequest> fzzzzzzzzzzzzzzzzzzv_ = this.Laboratory_Test_or_ECG_for_Hypertension(context);
            bool? fzzzzzzzzzzzzzzzzzzw_(ServiceRequest ECGLabTest)
            {
                FhirDateTime gzzzzzzzzzzzzzzzzzza_ = WeeksRescreen?.AuthoredOnElement;
                CqlDateTime gzzzzzzzzzzzzzzzzzzb_ = context.Operators.Convert<CqlDateTime>(gzzzzzzzzzzzzzzzzzza_);
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzc_ = this.Measurement_Period(context);
                bool? gzzzzzzzzzzzzzzzzzzd_ = context.Operators.In<CqlDateTime>(gzzzzzzzzzzzzzzzzzzb_, gzzzzzzzzzzzzzzzzzzc_, "day");
                FhirDateTime gzzzzzzzzzzzzzzzzzze_ = ECGLabTest?.AuthoredOnElement;
                CqlDateTime gzzzzzzzzzzzzzzzzzzf_ = context.Operators.Convert<CqlDateTime>(gzzzzzzzzzzzzzzzzzze_);
                bool? gzzzzzzzzzzzzzzzzzzh_ = context.Operators.In<CqlDateTime>(gzzzzzzzzzzzzzzzzzzf_, gzzzzzzzzzzzzzzzzzzc_, "day");
                bool? gzzzzzzzzzzzzzzzzzzi_ = context.Operators.And(gzzzzzzzzzzzzzzzzzzd_, gzzzzzzzzzzzzzzzzzzh_);
                Code<RequestIntent> gzzzzzzzzzzzzzzzzzzj_ = WeeksRescreen?.IntentElement;
                RequestIntent? gzzzzzzzzzzzzzzzzzzk_ = gzzzzzzzzzzzzzzzzzzj_?.Value;
                Code<RequestIntent> gzzzzzzzzzzzzzzzzzzl_ = context.Operators.Convert<Code<RequestIntent>>(gzzzzzzzzzzzzzzzzzzk_);
                bool? gzzzzzzzzzzzzzzzzzzm_ = context.Operators.Equivalent(gzzzzzzzzzzzzzzzzzzl_, "order");
                bool? gzzzzzzzzzzzzzzzzzzn_ = context.Operators.And(gzzzzzzzzzzzzzzzzzzi_, gzzzzzzzzzzzzzzzzzzm_);
                Code<RequestIntent> gzzzzzzzzzzzzzzzzzzo_ = ECGLabTest?.IntentElement;
                RequestIntent? gzzzzzzzzzzzzzzzzzzp_ = gzzzzzzzzzzzzzzzzzzo_?.Value;
                Code<RequestIntent> gzzzzzzzzzzzzzzzzzzq_ = context.Operators.Convert<Code<RequestIntent>>(gzzzzzzzzzzzzzzzzzzp_);
                bool? gzzzzzzzzzzzzzzzzzzr_ = context.Operators.Equivalent(gzzzzzzzzzzzzzzzzzzq_, "order");
                bool? gzzzzzzzzzzzzzzzzzzs_ = context.Operators.And(gzzzzzzzzzzzzzzzzzzn_, gzzzzzzzzzzzzzzzzzzr_);

                return gzzzzzzzzzzzzzzzzzzs_;
            };
            IEnumerable<ServiceRequest> fzzzzzzzzzzzzzzzzzzx_ = context.Operators.Where<ServiceRequest>(fzzzzzzzzzzzzzzzzzzv_, fzzzzzzzzzzzzzzzzzzw_);
            ServiceRequest fzzzzzzzzzzzzzzzzzzy_(ServiceRequest ECGLabTest) =>
                WeeksRescreen;
            IEnumerable<ServiceRequest> fzzzzzzzzzzzzzzzzzzz_ = context.Operators.Select<ServiceRequest, ServiceRequest>(fzzzzzzzzzzzzzzzzzzx_, fzzzzzzzzzzzzzzzzzzy_);

            return fzzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<ServiceRequest> fzzzzzzzzzzzzzzzzzzq_ = context.Operators.SelectMany<ServiceRequest, ServiceRequest>(fzzzzzzzzzzzzzzzzzzo_, fzzzzzzzzzzzzzzzzzzp_);
        IEnumerable<ServiceRequest> fzzzzzzzzzzzzzzzzzzr_(ServiceRequest WeeksRescreen)
        {
            IEnumerable<ServiceRequest> gzzzzzzzzzzzzzzzzzzt_ = this.NonPharmacological_Interventions(context);
            bool? gzzzzzzzzzzzzzzzzzzu_(ServiceRequest HTNInterventions)
            {
                FhirDateTime gzzzzzzzzzzzzzzzzzzy_ = HTNInterventions?.AuthoredOnElement;
                CqlDateTime gzzzzzzzzzzzzzzzzzzz_ = context.Operators.Convert<CqlDateTime>(gzzzzzzzzzzzzzzzzzzy_);
                CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzza_ = this.Measurement_Period(context);
                bool? hzzzzzzzzzzzzzzzzzzb_ = context.Operators.In<CqlDateTime>(gzzzzzzzzzzzzzzzzzzz_, hzzzzzzzzzzzzzzzzzza_, "day");

                return hzzzzzzzzzzzzzzzzzzb_;
            };
            IEnumerable<ServiceRequest> gzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<ServiceRequest>(gzzzzzzzzzzzzzzzzzzt_, gzzzzzzzzzzzzzzzzzzu_);
            ServiceRequest gzzzzzzzzzzzzzzzzzzw_(ServiceRequest HTNInterventions) =>
                WeeksRescreen;
            IEnumerable<ServiceRequest> gzzzzzzzzzzzzzzzzzzx_ = context.Operators.Select<ServiceRequest, ServiceRequest>(gzzzzzzzzzzzzzzzzzzv_, gzzzzzzzzzzzzzzzzzzw_);

            return gzzzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<ServiceRequest> fzzzzzzzzzzzzzzzzzzs_ = context.Operators.SelectMany<ServiceRequest, ServiceRequest>(fzzzzzzzzzzzzzzzzzzq_, fzzzzzzzzzzzzzzzzzzr_);
        IEnumerable<ServiceRequest> fzzzzzzzzzzzzzzzzzzt_(ServiceRequest WeeksRescreen)
        {
            CqlValueSet hzzzzzzzzzzzzzzzzzzc_ = this.Pharmacologic_Therapy_for_Hypertension(context);
            IEnumerable<MedicationRequest> hzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> hzzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> hzzzzzzzzzzzzzzzzzzg_ = context.Operators.Union<MedicationRequest>(hzzzzzzzzzzzzzzzzzzd_, hzzzzzzzzzzzzzzzzzzf_);
            bool? hzzzzzzzzzzzzzzzzzzh_(MedicationRequest Medications)
            {
                FhirDateTime hzzzzzzzzzzzzzzzzzzl_ = Medications?.AuthoredOnElement;
                CqlDateTime hzzzzzzzzzzzzzzzzzzm_ = context.Operators.Convert<CqlDateTime>(hzzzzzzzzzzzzzzzzzzl_);
                CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzn_ = this.Measurement_Period(context);
                bool? hzzzzzzzzzzzzzzzzzzo_ = context.Operators.In<CqlDateTime>(hzzzzzzzzzzzzzzzzzzm_, hzzzzzzzzzzzzzzzzzzn_, "day");
                Code<MedicationRequest.MedicationrequestStatus> hzzzzzzzzzzzzzzzzzzp_ = Medications?.StatusElement;
                MedicationRequest.MedicationrequestStatus? hzzzzzzzzzzzzzzzzzzq_ = hzzzzzzzzzzzzzzzzzzp_?.Value;
                string hzzzzzzzzzzzzzzzzzzr_ = context.Operators.Convert<string>(hzzzzzzzzzzzzzzzzzzq_);
                bool? hzzzzzzzzzzzzzzzzzzs_ = context.Operators.Equivalent(hzzzzzzzzzzzzzzzzzzr_, "active");
                bool? hzzzzzzzzzzzzzzzzzzt_ = context.Operators.And(hzzzzzzzzzzzzzzzzzzo_, hzzzzzzzzzzzzzzzzzzs_);

                return hzzzzzzzzzzzzzzzzzzt_;
            };
            IEnumerable<MedicationRequest> hzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<MedicationRequest>(hzzzzzzzzzzzzzzzzzzg_, hzzzzzzzzzzzzzzzzzzh_);
            ServiceRequest hzzzzzzzzzzzzzzzzzzj_(MedicationRequest Medications) =>
                WeeksRescreen;
            IEnumerable<ServiceRequest> hzzzzzzzzzzzzzzzzzzk_ = context.Operators.Select<MedicationRequest, ServiceRequest>(hzzzzzzzzzzzzzzzzzzi_, hzzzzzzzzzzzzzzzzzzj_);

            return hzzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<ServiceRequest> fzzzzzzzzzzzzzzzzzzu_ = context.Operators.SelectMany<ServiceRequest, ServiceRequest>(fzzzzzzzzzzzzzzzzzzs_, fzzzzzzzzzzzzzzzzzzt_);

        return fzzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Encounter with Second Hypertensive Reading SBP Greater than or Equal to 140 OR DBP Greater than or Equal to 90 and Interventions")]
    public IEnumerable<Encounter> Encounter_with_Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90_and_Interventions(CqlContext context)
    {
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzu_ = this.Encounter_with_Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90(context);
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzv_(Encounter SecondHTNEncounterReading140Over90)
        {
            IEnumerable<ServiceRequest> izzzzzzzzzzzzzzzzzzb_ = this.Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90_Interventions(context);
            bool? izzzzzzzzzzzzzzzzzzc_(ServiceRequest SecondHTN140Over90Interventions)
            {
                FhirDateTime izzzzzzzzzzzzzzzzzzg_ = SecondHTN140Over90Interventions?.AuthoredOnElement;
                CqlDateTime izzzzzzzzzzzzzzzzzzh_ = context.Operators.Convert<CqlDateTime>(izzzzzzzzzzzzzzzzzzg_);
                Period izzzzzzzzzzzzzzzzzzi_ = SecondHTNEncounterReading140Over90?.Period;
                CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzzzzzzzzzzzzzi_);
                bool? izzzzzzzzzzzzzzzzzzk_ = context.Operators.In<CqlDateTime>(izzzzzzzzzzzzzzzzzzh_, izzzzzzzzzzzzzzzzzzj_, "day");

                return izzzzzzzzzzzzzzzzzzk_;
            };
            IEnumerable<ServiceRequest> izzzzzzzzzzzzzzzzzzd_ = context.Operators.Where<ServiceRequest>(izzzzzzzzzzzzzzzzzzb_, izzzzzzzzzzzzzzzzzzc_);
            Encounter izzzzzzzzzzzzzzzzzze_(ServiceRequest SecondHTN140Over90Interventions) =>
                SecondHTNEncounterReading140Over90;
            IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzf_ = context.Operators.Select<ServiceRequest, Encounter>(izzzzzzzzzzzzzzzzzzd_, izzzzzzzzzzzzzzzzzze_);

            return izzzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzw_ = context.Operators.SelectMany<Encounter, Encounter>(hzzzzzzzzzzzzzzzzzzu_, hzzzzzzzzzzzzzzzzzzv_);
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzy_(Encounter SecondHTNEncounterReading140Over90)
        {
            IEnumerable<ServiceRequest> izzzzzzzzzzzzzzzzzzl_ = this.Referral_to_Alternate_or_Primary_Healthcare_Professional_for_Hypertensive_Reading(context);
            bool? izzzzzzzzzzzzzzzzzzm_(ServiceRequest ReferralToProfessional)
            {
                FhirDateTime izzzzzzzzzzzzzzzzzzq_ = ReferralToProfessional?.AuthoredOnElement;
                CqlDateTime izzzzzzzzzzzzzzzzzzr_ = context.Operators.Convert<CqlDateTime>(izzzzzzzzzzzzzzzzzzq_);
                Period izzzzzzzzzzzzzzzzzzs_ = SecondHTNEncounterReading140Over90?.Period;
                CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzzzzzzzzzzzzzs_);
                bool? izzzzzzzzzzzzzzzzzzu_ = context.Operators.In<CqlDateTime>(izzzzzzzzzzzzzzzzzzr_, izzzzzzzzzzzzzzzzzzt_, "day");

                return izzzzzzzzzzzzzzzzzzu_;
            };
            IEnumerable<ServiceRequest> izzzzzzzzzzzzzzzzzzn_ = context.Operators.Where<ServiceRequest>(izzzzzzzzzzzzzzzzzzl_, izzzzzzzzzzzzzzzzzzm_);
            Encounter izzzzzzzzzzzzzzzzzzo_(ServiceRequest ReferralToProfessional) =>
                SecondHTNEncounterReading140Over90;
            IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzp_ = context.Operators.Select<ServiceRequest, Encounter>(izzzzzzzzzzzzzzzzzzn_, izzzzzzzzzzzzzzzzzzo_);

            return izzzzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzz_ = context.Operators.SelectMany<Encounter, Encounter>(hzzzzzzzzzzzzzzzzzzu_, hzzzzzzzzzzzzzzzzzzy_);
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzza_ = context.Operators.Union<Encounter>(hzzzzzzzzzzzzzzzzzzw_, hzzzzzzzzzzzzzzzzzzz_);

        return izzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context)
    {
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzv_ = this.Encounter_with_Normal_Blood_Pressure_Reading(context);
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzw_ = this.Encounter_with_Elevated_Blood_Pressure_Reading_SBP_120_to_129_AND_DBP_less_than_80_and_Interventions(context);
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzx_ = context.Operators.Union<Encounter>(izzzzzzzzzzzzzzzzzzv_, izzzzzzzzzzzzzzzzzzw_);
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzy_ = this.Encounter_with_First_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_130_OR_DBP_Greater_than_or_Equal_to_80_and_Interventions(context);
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzz_ = this.Encounter_with_Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89_and_Interventions(context);
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzza_ = context.Operators.Union<Encounter>(izzzzzzzzzzzzzzzzzzy_, izzzzzzzzzzzzzzzzzzz_);
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzb_ = context.Operators.Union<Encounter>(izzzzzzzzzzzzzzzzzzx_, jzzzzzzzzzzzzzzzzzza_);
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzc_ = this.Encounter_with_Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90_and_Interventions(context);
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzd_ = context.Operators.Union<Encounter>(jzzzzzzzzzzzzzzzzzzb_, jzzzzzzzzzzzzzzzzzzc_);

        return jzzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Encounter with Medical Reason for Not Obtaining or Patient Declined Blood Pressure Measurement")]
    public IEnumerable<Encounter> Encounter_with_Medical_Reason_for_Not_Obtaining_or_Patient_Declined_Blood_Pressure_Measurement(CqlContext context)
    {
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzze_ = this.Qualifying_Encounter_during_Measurement_Period(context);
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzf_(Encounter QualifyingEncounter)
        {
            CqlCode jzzzzzzzzzzzzzzzzzzh_ = this.Systolic_blood_pressure(context);
            IEnumerable<CqlCode> jzzzzzzzzzzzzzzzzzzi_ = context.Operators.ToList<CqlCode>(jzzzzzzzzzzzzzzzzzzh_);
            IEnumerable<Observation> jzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, jzzzzzzzzzzzzzzzzzzi_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observationnotdone"));
            CqlCode jzzzzzzzzzzzzzzzzzzk_ = this.Diastolic_blood_pressure(context);
            IEnumerable<CqlCode> jzzzzzzzzzzzzzzzzzzl_ = context.Operators.ToList<CqlCode>(jzzzzzzzzzzzzzzzzzzk_);
            IEnumerable<Observation> jzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, jzzzzzzzzzzzzzzzzzzl_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observationnotdone"));
            IEnumerable<Observation> jzzzzzzzzzzzzzzzzzzn_ = context.Operators.Union<Observation>(jzzzzzzzzzzzzzzzzzzj_, jzzzzzzzzzzzzzzzzzzm_);
            bool? jzzzzzzzzzzzzzzzzzzo_(Observation NoBPScreen)
            {
                Instant jzzzzzzzzzzzzzzzzzzs_ = NoBPScreen?.IssuedElement;
                DateTimeOffset? jzzzzzzzzzzzzzzzzzzt_ = jzzzzzzzzzzzzzzzzzzs_?.Value;
                CqlDateTime jzzzzzzzzzzzzzzzzzzu_ = context.Operators.Convert<CqlDateTime>(jzzzzzzzzzzzzzzzzzzt_);
                Period jzzzzzzzzzzzzzzzzzzv_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzzzzzzzzzzzzzv_);
                bool? jzzzzzzzzzzzzzzzzzzx_ = context.Operators.In<CqlDateTime>(jzzzzzzzzzzzzzzzzzzu_, jzzzzzzzzzzzzzzzzzzw_, "day");
                bool? jzzzzzzzzzzzzzzzzzzy_(Extension @this)
                {
                    string kzzzzzzzzzzzzzzzzzzv_ = @this?.Url;
                    FhirString kzzzzzzzzzzzzzzzzzzw_ = context.Operators.Convert<FhirString>(kzzzzzzzzzzzzzzzzzzv_);
                    string kzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToString(context, kzzzzzzzzzzzzzzzzzzw_);
                    bool? kzzzzzzzzzzzzzzzzzzy_ = context.Operators.Equal(kzzzzzzzzzzzzzzzzzzx_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-notDoneReason");

                    return kzzzzzzzzzzzzzzzzzzy_;
                };
                IEnumerable<Extension> jzzzzzzzzzzzzzzzzzzz_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(NoBPScreen is DomainResource
                        ? (NoBPScreen as DomainResource).Extension
                        : default), jzzzzzzzzzzzzzzzzzzy_);
                object kzzzzzzzzzzzzzzzzzza_(Extension @this)
                {
                    DataType kzzzzzzzzzzzzzzzzzzz_ = @this?.Value;

                    return kzzzzzzzzzzzzzzzzzzz_;
                };
                IEnumerable<object> kzzzzzzzzzzzzzzzzzzb_ = context.Operators.Select<Extension, object>(jzzzzzzzzzzzzzzzzzzz_, kzzzzzzzzzzzzzzzzzza_);
                object kzzzzzzzzzzzzzzzzzzc_ = context.Operators.SingletonFrom<object>(kzzzzzzzzzzzzzzzzzzb_);
                CqlConcept kzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, kzzzzzzzzzzzzzzzzzzc_ as CodeableConcept);
                CqlValueSet kzzzzzzzzzzzzzzzzzze_ = this.Patient_Declined(context);
                bool? kzzzzzzzzzzzzzzzzzzf_ = context.Operators.ConceptInValueSet(kzzzzzzzzzzzzzzzzzzd_, kzzzzzzzzzzzzzzzzzze_);
                bool? kzzzzzzzzzzzzzzzzzzg_(Extension @this)
                {
                    string lzzzzzzzzzzzzzzzzzza_ = @this?.Url;
                    FhirString lzzzzzzzzzzzzzzzzzzb_ = context.Operators.Convert<FhirString>(lzzzzzzzzzzzzzzzzzza_);
                    string lzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToString(context, lzzzzzzzzzzzzzzzzzzb_);
                    bool? lzzzzzzzzzzzzzzzzzzd_ = context.Operators.Equal(lzzzzzzzzzzzzzzzzzzc_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-notDoneReason");

                    return lzzzzzzzzzzzzzzzzzzd_;
                };
                IEnumerable<Extension> kzzzzzzzzzzzzzzzzzzh_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(NoBPScreen is DomainResource
                        ? (NoBPScreen as DomainResource).Extension
                        : default), kzzzzzzzzzzzzzzzzzzg_);
                object kzzzzzzzzzzzzzzzzzzi_(Extension @this)
                {
                    DataType lzzzzzzzzzzzzzzzzzze_ = @this?.Value;

                    return lzzzzzzzzzzzzzzzzzze_;
                };
                IEnumerable<object> kzzzzzzzzzzzzzzzzzzj_ = context.Operators.Select<Extension, object>(kzzzzzzzzzzzzzzzzzzh_, kzzzzzzzzzzzzzzzzzzi_);
                object kzzzzzzzzzzzzzzzzzzk_ = context.Operators.SingletonFrom<object>(kzzzzzzzzzzzzzzzzzzj_);
                CqlConcept kzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, kzzzzzzzzzzzzzzzzzzk_ as CodeableConcept);
                CqlValueSet kzzzzzzzzzzzzzzzzzzm_ = this.Medical_Reason(context);
                bool? kzzzzzzzzzzzzzzzzzzn_ = context.Operators.ConceptInValueSet(kzzzzzzzzzzzzzzzzzzl_, kzzzzzzzzzzzzzzzzzzm_);
                bool? kzzzzzzzzzzzzzzzzzzo_ = context.Operators.Or(kzzzzzzzzzzzzzzzzzzf_, kzzzzzzzzzzzzzzzzzzn_);
                bool? kzzzzzzzzzzzzzzzzzzp_ = context.Operators.And(jzzzzzzzzzzzzzzzzzzx_, kzzzzzzzzzzzzzzzzzzo_);
                Code<ObservationStatus> kzzzzzzzzzzzzzzzzzzq_ = NoBPScreen?.StatusElement;
                ObservationStatus? kzzzzzzzzzzzzzzzzzzr_ = kzzzzzzzzzzzzzzzzzzq_?.Value;
                Code<ObservationStatus> kzzzzzzzzzzzzzzzzzzs_ = context.Operators.Convert<Code<ObservationStatus>>(kzzzzzzzzzzzzzzzzzzr_);
                bool? kzzzzzzzzzzzzzzzzzzt_ = context.Operators.Equal(kzzzzzzzzzzzzzzzzzzs_, "cancelled");
                bool? kzzzzzzzzzzzzzzzzzzu_ = context.Operators.And(kzzzzzzzzzzzzzzzzzzp_, kzzzzzzzzzzzzzzzzzzt_);

                return kzzzzzzzzzzzzzzzzzzu_;
            };
            IEnumerable<Observation> jzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Observation>(jzzzzzzzzzzzzzzzzzzn_, jzzzzzzzzzzzzzzzzzzo_);
            Encounter jzzzzzzzzzzzzzzzzzzq_(Observation NoBPScreen) =>
                QualifyingEncounter;
            IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzr_ = context.Operators.Select<Observation, Encounter>(jzzzzzzzzzzzzzzzzzzp_, jzzzzzzzzzzzzzzzzzzq_);

            return jzzzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzg_ = context.Operators.SelectMany<Encounter, Encounter>(jzzzzzzzzzzzzzzzzzze_, jzzzzzzzzzzzzzzzzzzf_);

        return jzzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("NonPharmacological Intervention Not Ordered")]
    public IEnumerable<ServiceRequest> NonPharmacological_Intervention_Not_Ordered(CqlContext context)
    {
        CqlValueSet lzzzzzzzzzzzzzzzzzzf_ = this.Lifestyle_Recommendation(context);
        IEnumerable<ServiceRequest> lzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, lzzzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> lzzzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, lzzzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> lzzzzzzzzzzzzzzzzzzj_ = context.Operators.Union<ServiceRequest>(lzzzzzzzzzzzzzzzzzzg_, lzzzzzzzzzzzzzzzzzzi_);
        CqlValueSet lzzzzzzzzzzzzzzzzzzk_ = this.Weight_Reduction_Recommended(context);
        IEnumerable<ServiceRequest> lzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, lzzzzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> lzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, lzzzzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> lzzzzzzzzzzzzzzzzzzo_ = context.Operators.Union<ServiceRequest>(lzzzzzzzzzzzzzzzzzzl_, lzzzzzzzzzzzzzzzzzzn_);
        IEnumerable<ServiceRequest> lzzzzzzzzzzzzzzzzzzp_ = context.Operators.Union<ServiceRequest>(lzzzzzzzzzzzzzzzzzzj_, lzzzzzzzzzzzzzzzzzzo_);
        CqlValueSet lzzzzzzzzzzzzzzzzzzq_ = this.Dietary_Recommendations(context);
        IEnumerable<ServiceRequest> lzzzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, lzzzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> lzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, lzzzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> lzzzzzzzzzzzzzzzzzzu_ = context.Operators.Union<ServiceRequest>(lzzzzzzzzzzzzzzzzzzr_, lzzzzzzzzzzzzzzzzzzt_);
        IEnumerable<ServiceRequest> lzzzzzzzzzzzzzzzzzzv_ = context.Operators.Union<ServiceRequest>(lzzzzzzzzzzzzzzzzzzp_, lzzzzzzzzzzzzzzzzzzu_);
        CqlValueSet lzzzzzzzzzzzzzzzzzzw_ = this.Recommendation_to_Increase_Physical_Activity(context);
        IEnumerable<ServiceRequest> lzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, lzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> lzzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, lzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> mzzzzzzzzzzzzzzzzzza_ = context.Operators.Union<ServiceRequest>(lzzzzzzzzzzzzzzzzzzx_, lzzzzzzzzzzzzzzzzzzz_);
        IEnumerable<ServiceRequest> mzzzzzzzzzzzzzzzzzzb_ = context.Operators.Union<ServiceRequest>(lzzzzzzzzzzzzzzzzzzv_, mzzzzzzzzzzzzzzzzzza_);
        CqlValueSet mzzzzzzzzzzzzzzzzzzc_ = this.Referral_or_Counseling_for_Alcohol_Consumption(context);
        IEnumerable<ServiceRequest> mzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, mzzzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> mzzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, mzzzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> mzzzzzzzzzzzzzzzzzzg_ = context.Operators.Union<ServiceRequest>(mzzzzzzzzzzzzzzzzzzd_, mzzzzzzzzzzzzzzzzzzf_);
        IEnumerable<ServiceRequest> mzzzzzzzzzzzzzzzzzzh_ = context.Operators.Union<ServiceRequest>(mzzzzzzzzzzzzzzzzzzb_, mzzzzzzzzzzzzzzzzzzg_);
        bool? mzzzzzzzzzzzzzzzzzzi_(ServiceRequest NonPharmIntervention)
        {
            bool? mzzzzzzzzzzzzzzzzzzk_(Extension @this)
            {
                string mzzzzzzzzzzzzzzzzzzx_ = @this?.Url;
                FhirString mzzzzzzzzzzzzzzzzzzy_ = context.Operators.Convert<FhirString>(mzzzzzzzzzzzzzzzzzzx_);
                string mzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToString(context, mzzzzzzzzzzzzzzzzzzy_);
                bool? nzzzzzzzzzzzzzzzzzza_ = context.Operators.Equal(mzzzzzzzzzzzzzzzzzzz_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerformReason");

                return nzzzzzzzzzzzzzzzzzza_;
            };
            IEnumerable<Extension> mzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(NonPharmIntervention is DomainResource
                    ? (NonPharmIntervention as DomainResource).Extension
                    : default), mzzzzzzzzzzzzzzzzzzk_);
            object mzzzzzzzzzzzzzzzzzzm_(Extension @this)
            {
                DataType nzzzzzzzzzzzzzzzzzzb_ = @this?.Value;

                return nzzzzzzzzzzzzzzzzzzb_;
            };
            IEnumerable<object> mzzzzzzzzzzzzzzzzzzn_ = context.Operators.Select<Extension, object>(mzzzzzzzzzzzzzzzzzzl_, mzzzzzzzzzzzzzzzzzzm_);
            object mzzzzzzzzzzzzzzzzzzo_ = context.Operators.SingletonFrom<object>(mzzzzzzzzzzzzzzzzzzn_);
            CqlConcept mzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, mzzzzzzzzzzzzzzzzzzo_ as CodeableConcept);
            CqlValueSet mzzzzzzzzzzzzzzzzzzq_ = this.Patient_Declined(context);
            bool? mzzzzzzzzzzzzzzzzzzr_ = context.Operators.ConceptInValueSet(mzzzzzzzzzzzzzzzzzzp_, mzzzzzzzzzzzzzzzzzzq_);
            Code<RequestStatus> mzzzzzzzzzzzzzzzzzzs_ = NonPharmIntervention?.StatusElement;
            RequestStatus? mzzzzzzzzzzzzzzzzzzt_ = mzzzzzzzzzzzzzzzzzzs_?.Value;
            Code<RequestStatus> mzzzzzzzzzzzzzzzzzzu_ = context.Operators.Convert<Code<RequestStatus>>(mzzzzzzzzzzzzzzzzzzt_);
            bool? mzzzzzzzzzzzzzzzzzzv_ = context.Operators.Equal(mzzzzzzzzzzzzzzzzzzu_, "completed");
            bool? mzzzzzzzzzzzzzzzzzzw_ = context.Operators.And(mzzzzzzzzzzzzzzzzzzr_, mzzzzzzzzzzzzzzzzzzv_);

            return mzzzzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<ServiceRequest> mzzzzzzzzzzzzzzzzzzj_ = context.Operators.Where<ServiceRequest>(mzzzzzzzzzzzzzzzzzzh_, mzzzzzzzzzzzzzzzzzzi_);

        return mzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Laboratory Test or ECG for Hypertension Not Ordered")]
    public IEnumerable<ServiceRequest> Laboratory_Test_or_ECG_for_Hypertension_Not_Ordered(CqlContext context)
    {
        CqlCode nzzzzzzzzzzzzzzzzzzc_ = this._12_lead_EKG_panel(context);
        IEnumerable<CqlCode> nzzzzzzzzzzzzzzzzzzd_ = context.Operators.ToList<CqlCode>(nzzzzzzzzzzzzzzzzzzc_);
        IEnumerable<ServiceRequest> nzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, default, nzzzzzzzzzzzzzzzzzzd_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        CqlCode nzzzzzzzzzzzzzzzzzzf_ = this.EKG_study(context);
        IEnumerable<CqlCode> nzzzzzzzzzzzzzzzzzzg_ = context.Operators.ToList<CqlCode>(nzzzzzzzzzzzzzzzzzzf_);
        IEnumerable<ServiceRequest> nzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, default, nzzzzzzzzzzzzzzzzzzg_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> nzzzzzzzzzzzzzzzzzzi_ = context.Operators.Union<ServiceRequest>(nzzzzzzzzzzzzzzzzzze_, nzzzzzzzzzzzzzzzzzzh_);
        CqlValueSet nzzzzzzzzzzzzzzzzzzj_ = this.Laboratory_Tests_for_Hypertension(context);
        IEnumerable<ServiceRequest> nzzzzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, nzzzzzzzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> nzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, nzzzzzzzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> nzzzzzzzzzzzzzzzzzzn_ = context.Operators.Union<ServiceRequest>(nzzzzzzzzzzzzzzzzzzk_, nzzzzzzzzzzzzzzzzzzm_);
        IEnumerable<ServiceRequest> nzzzzzzzzzzzzzzzzzzo_ = context.Operators.Union<ServiceRequest>(nzzzzzzzzzzzzzzzzzzi_, nzzzzzzzzzzzzzzzzzzn_);
        bool? nzzzzzzzzzzzzzzzzzzp_(ServiceRequest LabECGNotDone)
        {
            bool? nzzzzzzzzzzzzzzzzzzr_(Extension @this)
            {
                string nzzzzzzzzzzzzzzzzzzz_ = @this?.Url;
                FhirString ozzzzzzzzzzzzzzzzzza_ = context.Operators.Convert<FhirString>(nzzzzzzzzzzzzzzzzzzz_);
                string ozzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToString(context, ozzzzzzzzzzzzzzzzzza_);
                bool? ozzzzzzzzzzzzzzzzzzc_ = context.Operators.Equal(ozzzzzzzzzzzzzzzzzzb_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerformReason");

                return ozzzzzzzzzzzzzzzzzzc_;
            };
            IEnumerable<Extension> nzzzzzzzzzzzzzzzzzzs_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(LabECGNotDone is DomainResource
                    ? (LabECGNotDone as DomainResource).Extension
                    : default), nzzzzzzzzzzzzzzzzzzr_);
            object nzzzzzzzzzzzzzzzzzzt_(Extension @this)
            {
                DataType ozzzzzzzzzzzzzzzzzzd_ = @this?.Value;

                return ozzzzzzzzzzzzzzzzzzd_;
            };
            IEnumerable<object> nzzzzzzzzzzzzzzzzzzu_ = context.Operators.Select<Extension, object>(nzzzzzzzzzzzzzzzzzzs_, nzzzzzzzzzzzzzzzzzzt_);
            object nzzzzzzzzzzzzzzzzzzv_ = context.Operators.SingletonFrom<object>(nzzzzzzzzzzzzzzzzzzu_);
            CqlConcept nzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, nzzzzzzzzzzzzzzzzzzv_ as CodeableConcept);
            CqlValueSet nzzzzzzzzzzzzzzzzzzx_ = this.Patient_Declined(context);
            bool? nzzzzzzzzzzzzzzzzzzy_ = context.Operators.ConceptInValueSet(nzzzzzzzzzzzzzzzzzzw_, nzzzzzzzzzzzzzzzzzzx_);

            return nzzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<ServiceRequest> nzzzzzzzzzzzzzzzzzzq_ = context.Operators.Where<ServiceRequest>(nzzzzzzzzzzzzzzzzzzo_, nzzzzzzzzzzzzzzzzzzp_);

        return nzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Second Hypertensive Reading SBP 130 to 139 OR DBP 80 to 89 Interventions Declined")]
    public IEnumerable<ServiceRequest> Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89_Interventions_Declined(CqlContext context)
    {
        CqlValueSet ozzzzzzzzzzzzzzzzzze_ = this.Referral_to_Primary_Care_or_Alternate_Provider(context);
        IEnumerable<ServiceRequest> ozzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, ozzzzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> ozzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, ozzzzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> ozzzzzzzzzzzzzzzzzzi_ = context.Operators.Union<ServiceRequest>(ozzzzzzzzzzzzzzzzzzf_, ozzzzzzzzzzzzzzzzzzh_);
        CqlValueSet ozzzzzzzzzzzzzzzzzzj_ = this.Follow_Up_Within_6_Months(context);
        IEnumerable<ServiceRequest> ozzzzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, ozzzzzzzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> ozzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, ozzzzzzzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> ozzzzzzzzzzzzzzzzzzn_ = context.Operators.Union<ServiceRequest>(ozzzzzzzzzzzzzzzzzzk_, ozzzzzzzzzzzzzzzzzzm_);
        IEnumerable<ServiceRequest> ozzzzzzzzzzzzzzzzzzo_ = context.Operators.Union<ServiceRequest>(ozzzzzzzzzzzzzzzzzzi_, ozzzzzzzzzzzzzzzzzzn_);
        bool? ozzzzzzzzzzzzzzzzzzp_(ServiceRequest SecondHTNDeclinedReferralAndFollowUp)
        {
            bool? ozzzzzzzzzzzzzzzzzzv_(Extension @this)
            {
                string pzzzzzzzzzzzzzzzzzzi_ = @this?.Url;
                FhirString pzzzzzzzzzzzzzzzzzzj_ = context.Operators.Convert<FhirString>(pzzzzzzzzzzzzzzzzzzi_);
                string pzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToString(context, pzzzzzzzzzzzzzzzzzzj_);
                bool? pzzzzzzzzzzzzzzzzzzl_ = context.Operators.Equal(pzzzzzzzzzzzzzzzzzzk_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerformReason");

                return pzzzzzzzzzzzzzzzzzzl_;
            };
            IEnumerable<Extension> ozzzzzzzzzzzzzzzzzzw_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(SecondHTNDeclinedReferralAndFollowUp is DomainResource
                    ? (SecondHTNDeclinedReferralAndFollowUp as DomainResource).Extension
                    : default), ozzzzzzzzzzzzzzzzzzv_);
            object ozzzzzzzzzzzzzzzzzzx_(Extension @this)
            {
                DataType pzzzzzzzzzzzzzzzzzzm_ = @this?.Value;

                return pzzzzzzzzzzzzzzzzzzm_;
            };
            IEnumerable<object> ozzzzzzzzzzzzzzzzzzy_ = context.Operators.Select<Extension, object>(ozzzzzzzzzzzzzzzzzzw_, ozzzzzzzzzzzzzzzzzzx_);
            object ozzzzzzzzzzzzzzzzzzz_ = context.Operators.SingletonFrom<object>(ozzzzzzzzzzzzzzzzzzy_);
            CqlConcept pzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ozzzzzzzzzzzzzzzzzzz_ as CodeableConcept);
            CqlValueSet pzzzzzzzzzzzzzzzzzzb_ = this.Patient_Declined(context);
            bool? pzzzzzzzzzzzzzzzzzzc_ = context.Operators.ConceptInValueSet(pzzzzzzzzzzzzzzzzzza_, pzzzzzzzzzzzzzzzzzzb_);
            Code<RequestStatus> pzzzzzzzzzzzzzzzzzzd_ = SecondHTNDeclinedReferralAndFollowUp?.StatusElement;
            RequestStatus? pzzzzzzzzzzzzzzzzzze_ = pzzzzzzzzzzzzzzzzzzd_?.Value;
            Code<RequestStatus> pzzzzzzzzzzzzzzzzzzf_ = context.Operators.Convert<Code<RequestStatus>>(pzzzzzzzzzzzzzzzzzze_);
            bool? pzzzzzzzzzzzzzzzzzzg_ = context.Operators.Equal(pzzzzzzzzzzzzzzzzzzf_, "completed");
            bool? pzzzzzzzzzzzzzzzzzzh_ = context.Operators.And(pzzzzzzzzzzzzzzzzzzc_, pzzzzzzzzzzzzzzzzzzg_);

            return pzzzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<ServiceRequest> ozzzzzzzzzzzzzzzzzzq_ = context.Operators.Where<ServiceRequest>(ozzzzzzzzzzzzzzzzzzo_, ozzzzzzzzzzzzzzzzzzp_);
        IEnumerable<ServiceRequest> ozzzzzzzzzzzzzzzzzzr_ = this.Laboratory_Test_or_ECG_for_Hypertension_Not_Ordered(context);
        IEnumerable<ServiceRequest> ozzzzzzzzzzzzzzzzzzs_ = context.Operators.Union<ServiceRequest>(ozzzzzzzzzzzzzzzzzzq_, ozzzzzzzzzzzzzzzzzzr_);
        IEnumerable<ServiceRequest> ozzzzzzzzzzzzzzzzzzt_ = this.NonPharmacological_Intervention_Not_Ordered(context);
        IEnumerable<ServiceRequest> ozzzzzzzzzzzzzzzzzzu_ = context.Operators.Union<ServiceRequest>(ozzzzzzzzzzzzzzzzzzs_, ozzzzzzzzzzzzzzzzzzt_);

        return ozzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Second Hypertensive Reading SBP Greater than or Equal to 140 OR DBP Greater than or Equal to 90 Interventions Declined")]
    public IEnumerable<object> Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90_Interventions_Declined(CqlContext context)
    {
        CqlValueSet pzzzzzzzzzzzzzzzzzzn_ = this.Referral_to_Primary_Care_or_Alternate_Provider(context);
        IEnumerable<ServiceRequest> pzzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> pzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> pzzzzzzzzzzzzzzzzzzr_ = context.Operators.Union<ServiceRequest>(pzzzzzzzzzzzzzzzzzzo_, pzzzzzzzzzzzzzzzzzzq_);
        CqlValueSet pzzzzzzzzzzzzzzzzzzs_ = this.Follow_Up_Within_4_Weeks(context);
        IEnumerable<ServiceRequest> pzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> pzzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> pzzzzzzzzzzzzzzzzzzw_ = context.Operators.Union<ServiceRequest>(pzzzzzzzzzzzzzzzzzzt_, pzzzzzzzzzzzzzzzzzzv_);
        IEnumerable<ServiceRequest> pzzzzzzzzzzzzzzzzzzx_ = context.Operators.Union<ServiceRequest>(pzzzzzzzzzzzzzzzzzzr_, pzzzzzzzzzzzzzzzzzzw_);
        bool? pzzzzzzzzzzzzzzzzzzy_(ServiceRequest SecondHTN140Over90ReferralFollowUpNotDone)
        {
            bool? qzzzzzzzzzzzzzzzzzzm_(Extension @this)
            {
                string qzzzzzzzzzzzzzzzzzzz_ = @this?.Url;
                FhirString rzzzzzzzzzzzzzzzzzza_ = context.Operators.Convert<FhirString>(qzzzzzzzzzzzzzzzzzzz_);
                string rzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToString(context, rzzzzzzzzzzzzzzzzzza_);
                bool? rzzzzzzzzzzzzzzzzzzc_ = context.Operators.Equal(rzzzzzzzzzzzzzzzzzzb_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerformReason");

                return rzzzzzzzzzzzzzzzzzzc_;
            };
            IEnumerable<Extension> qzzzzzzzzzzzzzzzzzzn_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(SecondHTN140Over90ReferralFollowUpNotDone is DomainResource
                    ? (SecondHTN140Over90ReferralFollowUpNotDone as DomainResource).Extension
                    : default), qzzzzzzzzzzzzzzzzzzm_);
            object qzzzzzzzzzzzzzzzzzzo_(Extension @this)
            {
                DataType rzzzzzzzzzzzzzzzzzzd_ = @this?.Value;

                return rzzzzzzzzzzzzzzzzzzd_;
            };
            IEnumerable<object> qzzzzzzzzzzzzzzzzzzp_ = context.Operators.Select<Extension, object>(qzzzzzzzzzzzzzzzzzzn_, qzzzzzzzzzzzzzzzzzzo_);
            object qzzzzzzzzzzzzzzzzzzq_ = context.Operators.SingletonFrom<object>(qzzzzzzzzzzzzzzzzzzp_);
            CqlConcept qzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, qzzzzzzzzzzzzzzzzzzq_ as CodeableConcept);
            CqlValueSet qzzzzzzzzzzzzzzzzzzs_ = this.Patient_Declined(context);
            bool? qzzzzzzzzzzzzzzzzzzt_ = context.Operators.ConceptInValueSet(qzzzzzzzzzzzzzzzzzzr_, qzzzzzzzzzzzzzzzzzzs_);
            Code<RequestStatus> qzzzzzzzzzzzzzzzzzzu_ = SecondHTN140Over90ReferralFollowUpNotDone?.StatusElement;
            RequestStatus? qzzzzzzzzzzzzzzzzzzv_ = qzzzzzzzzzzzzzzzzzzu_?.Value;
            Code<RequestStatus> qzzzzzzzzzzzzzzzzzzw_ = context.Operators.Convert<Code<RequestStatus>>(qzzzzzzzzzzzzzzzzzzv_);
            bool? qzzzzzzzzzzzzzzzzzzx_ = context.Operators.Equal(qzzzzzzzzzzzzzzzzzzw_, "completed");
            bool? qzzzzzzzzzzzzzzzzzzy_ = context.Operators.And(qzzzzzzzzzzzzzzzzzzt_, qzzzzzzzzzzzzzzzzzzx_);

            return qzzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<ServiceRequest> pzzzzzzzzzzzzzzzzzzz_ = context.Operators.Where<ServiceRequest>(pzzzzzzzzzzzzzzzzzzx_, pzzzzzzzzzzzzzzzzzzy_);
        CqlValueSet qzzzzzzzzzzzzzzzzzza_ = this.Pharmacologic_Therapy_for_Hypertension(context);
        IEnumerable<MedicationRequest> qzzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-mednotrequested"));
        IEnumerable<MedicationRequest> qzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-mednotrequested"));
        IEnumerable<MedicationRequest> qzzzzzzzzzzzzzzzzzze_ = context.Operators.Union<MedicationRequest>(qzzzzzzzzzzzzzzzzzzb_, qzzzzzzzzzzzzzzzzzzd_);
        bool? qzzzzzzzzzzzzzzzzzzf_(MedicationRequest MedicationRequestNotOrdered)
        {
            Code<MedicationRequest.MedicationrequestStatus> rzzzzzzzzzzzzzzzzzze_ = MedicationRequestNotOrdered?.StatusElement;
            MedicationRequest.MedicationrequestStatus? rzzzzzzzzzzzzzzzzzzf_ = rzzzzzzzzzzzzzzzzzze_?.Value;
            string rzzzzzzzzzzzzzzzzzzg_ = context.Operators.Convert<string>(rzzzzzzzzzzzzzzzzzzf_);
            bool? rzzzzzzzzzzzzzzzzzzh_ = context.Operators.Equal(rzzzzzzzzzzzzzzzzzzg_, "completed");

            return rzzzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<MedicationRequest> qzzzzzzzzzzzzzzzzzzg_ = context.Operators.Where<MedicationRequest>(qzzzzzzzzzzzzzzzzzze_, qzzzzzzzzzzzzzzzzzzf_);
        IEnumerable<object> qzzzzzzzzzzzzzzzzzzh_ = context.Operators.Union<object>(pzzzzzzzzzzzzzzzzzzz_ as IEnumerable<object>, qzzzzzzzzzzzzzzzzzzg_ as IEnumerable<object>);
        IEnumerable<ServiceRequest> qzzzzzzzzzzzzzzzzzzi_ = this.Laboratory_Test_or_ECG_for_Hypertension_Not_Ordered(context);
        IEnumerable<object> qzzzzzzzzzzzzzzzzzzj_ = context.Operators.Union<object>(qzzzzzzzzzzzzzzzzzzh_ as IEnumerable<object>, qzzzzzzzzzzzzzzzzzzi_ as IEnumerable<object>);
        IEnumerable<ServiceRequest> qzzzzzzzzzzzzzzzzzzk_ = this.NonPharmacological_Intervention_Not_Ordered(context);
        IEnumerable<object> qzzzzzzzzzzzzzzzzzzl_ = context.Operators.Union<object>(qzzzzzzzzzzzzzzzzzzj_ as IEnumerable<object>, qzzzzzzzzzzzzzzzzzzk_ as IEnumerable<object>);

        return qzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Encounter with Order for Hypertension Follow Up Declined by Patient")]
    public IEnumerable<Encounter> Encounter_with_Order_for_Hypertension_Follow_Up_Declined_by_Patient(CqlContext context)
    {
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzi_ = this.Encounter_with_Elevated_Blood_Pressure_Reading_SBP_120_to_129_AND_DBP_less_than_80(context);
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzj_(Encounter ElevatedBPEncounter)
        {
            CqlValueSet szzzzzzzzzzzzzzzzzzf_ = this.Referral_to_Primary_Care_or_Alternate_Provider(context);
            IEnumerable<ServiceRequest> szzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
            IEnumerable<ServiceRequest> szzzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
            IEnumerable<ServiceRequest> szzzzzzzzzzzzzzzzzzj_ = context.Operators.Union<ServiceRequest>(szzzzzzzzzzzzzzzzzzg_, szzzzzzzzzzzzzzzzzzi_);
            CqlValueSet szzzzzzzzzzzzzzzzzzk_ = this.Follow_Up_Within_6_Months(context);
            IEnumerable<ServiceRequest> szzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
            IEnumerable<ServiceRequest> szzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
            IEnumerable<ServiceRequest> szzzzzzzzzzzzzzzzzzo_ = context.Operators.Union<ServiceRequest>(szzzzzzzzzzzzzzzzzzl_, szzzzzzzzzzzzzzzzzzn_);
            IEnumerable<ServiceRequest> szzzzzzzzzzzzzzzzzzp_ = context.Operators.Union<ServiceRequest>(szzzzzzzzzzzzzzzzzzj_, szzzzzzzzzzzzzzzzzzo_);
            bool? szzzzzzzzzzzzzzzzzzq_(ServiceRequest ElevatedBPDeclinedInterventions)
            {
                bool? szzzzzzzzzzzzzzzzzzu_(Extension @this)
                {
                    string tzzzzzzzzzzzzzzzzzzn_ = @this?.Url;
                    FhirString tzzzzzzzzzzzzzzzzzzo_ = context.Operators.Convert<FhirString>(tzzzzzzzzzzzzzzzzzzn_);
                    string tzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToString(context, tzzzzzzzzzzzzzzzzzzo_);
                    bool? tzzzzzzzzzzzzzzzzzzq_ = context.Operators.Equal(tzzzzzzzzzzzzzzzzzzp_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerformReason");

                    return tzzzzzzzzzzzzzzzzzzq_;
                };
                IEnumerable<Extension> szzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(ElevatedBPDeclinedInterventions is DomainResource
                        ? (ElevatedBPDeclinedInterventions as DomainResource).Extension
                        : default), szzzzzzzzzzzzzzzzzzu_);
                object szzzzzzzzzzzzzzzzzzw_(Extension @this)
                {
                    DataType tzzzzzzzzzzzzzzzzzzr_ = @this?.Value;

                    return tzzzzzzzzzzzzzzzzzzr_;
                };
                IEnumerable<object> szzzzzzzzzzzzzzzzzzx_ = context.Operators.Select<Extension, object>(szzzzzzzzzzzzzzzzzzv_, szzzzzzzzzzzzzzzzzzw_);
                object szzzzzzzzzzzzzzzzzzy_ = context.Operators.SingletonFrom<object>(szzzzzzzzzzzzzzzzzzx_);
                CqlConcept szzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, szzzzzzzzzzzzzzzzzzy_ as CodeableConcept);
                CqlValueSet tzzzzzzzzzzzzzzzzzza_ = this.Patient_Declined(context);
                bool? tzzzzzzzzzzzzzzzzzzb_ = context.Operators.ConceptInValueSet(szzzzzzzzzzzzzzzzzzz_, tzzzzzzzzzzzzzzzzzza_);
                FhirDateTime tzzzzzzzzzzzzzzzzzzc_ = ElevatedBPDeclinedInterventions?.AuthoredOnElement;
                CqlDateTime tzzzzzzzzzzzzzzzzzzd_ = context.Operators.Convert<CqlDateTime>(tzzzzzzzzzzzzzzzzzzc_);
                Period tzzzzzzzzzzzzzzzzzze_ = ElevatedBPEncounter?.Period;
                CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzzzzzzzzzzzzzzze_);
                bool? tzzzzzzzzzzzzzzzzzzg_ = context.Operators.In<CqlDateTime>(tzzzzzzzzzzzzzzzzzzd_, tzzzzzzzzzzzzzzzzzzf_, "day");
                bool? tzzzzzzzzzzzzzzzzzzh_ = context.Operators.And(tzzzzzzzzzzzzzzzzzzb_, tzzzzzzzzzzzzzzzzzzg_);
                Code<RequestStatus> tzzzzzzzzzzzzzzzzzzi_ = ElevatedBPDeclinedInterventions?.StatusElement;
                RequestStatus? tzzzzzzzzzzzzzzzzzzj_ = tzzzzzzzzzzzzzzzzzzi_?.Value;
                Code<RequestStatus> tzzzzzzzzzzzzzzzzzzk_ = context.Operators.Convert<Code<RequestStatus>>(tzzzzzzzzzzzzzzzzzzj_);
                bool? tzzzzzzzzzzzzzzzzzzl_ = context.Operators.Equal(tzzzzzzzzzzzzzzzzzzk_, "completed");
                bool? tzzzzzzzzzzzzzzzzzzm_ = context.Operators.And(tzzzzzzzzzzzzzzzzzzh_, tzzzzzzzzzzzzzzzzzzl_);

                return tzzzzzzzzzzzzzzzzzzm_;
            };
            IEnumerable<ServiceRequest> szzzzzzzzzzzzzzzzzzr_ = context.Operators.Where<ServiceRequest>(szzzzzzzzzzzzzzzzzzp_, szzzzzzzzzzzzzzzzzzq_);
            Encounter szzzzzzzzzzzzzzzzzzs_(ServiceRequest ElevatedBPDeclinedInterventions) =>
                ElevatedBPEncounter;
            IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzt_ = context.Operators.Select<ServiceRequest, Encounter>(szzzzzzzzzzzzzzzzzzr_, szzzzzzzzzzzzzzzzzzs_);

            return szzzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzk_ = context.Operators.SelectMany<Encounter, Encounter>(rzzzzzzzzzzzzzzzzzzi_, rzzzzzzzzzzzzzzzzzzj_);
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzm_(Encounter ElevatedBPEncounter)
        {
            IEnumerable<ServiceRequest> tzzzzzzzzzzzzzzzzzzs_ = this.NonPharmacological_Intervention_Not_Ordered(context);
            bool? tzzzzzzzzzzzzzzzzzzt_(ServiceRequest NotOrdered)
            {
                FhirDateTime tzzzzzzzzzzzzzzzzzzx_ = NotOrdered?.AuthoredOnElement;
                CqlDateTime tzzzzzzzzzzzzzzzzzzy_ = context.Operators.Convert<CqlDateTime>(tzzzzzzzzzzzzzzzzzzx_);
                Period tzzzzzzzzzzzzzzzzzzz_ = ElevatedBPEncounter?.Period;
                CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzzzzzzzzzzzzzzzz_);
                bool? uzzzzzzzzzzzzzzzzzzb_ = context.Operators.In<CqlDateTime>(tzzzzzzzzzzzzzzzzzzy_, uzzzzzzzzzzzzzzzzzza_, "day");

                return uzzzzzzzzzzzzzzzzzzb_;
            };
            IEnumerable<ServiceRequest> tzzzzzzzzzzzzzzzzzzu_ = context.Operators.Where<ServiceRequest>(tzzzzzzzzzzzzzzzzzzs_, tzzzzzzzzzzzzzzzzzzt_);
            Encounter tzzzzzzzzzzzzzzzzzzv_(ServiceRequest NotOrdered) =>
                ElevatedBPEncounter;
            IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzw_ = context.Operators.Select<ServiceRequest, Encounter>(tzzzzzzzzzzzzzzzzzzu_, tzzzzzzzzzzzzzzzzzzv_);

            return tzzzzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzn_ = context.Operators.SelectMany<Encounter, Encounter>(rzzzzzzzzzzzzzzzzzzi_, rzzzzzzzzzzzzzzzzzzm_);
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzo_ = context.Operators.Union<Encounter>(rzzzzzzzzzzzzzzzzzzk_, rzzzzzzzzzzzzzzzzzzn_);
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzp_ = this.Encounter_with_First_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_130_OR_DBP_Greater_than_or_Equal_to_80(context);
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzq_(Encounter FirstHTNEncounter)
        {
            CqlValueSet uzzzzzzzzzzzzzzzzzzc_ = this.Follow_Up_Within_4_Weeks(context);
            IEnumerable<ServiceRequest> uzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
            IEnumerable<ServiceRequest> uzzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
            IEnumerable<ServiceRequest> uzzzzzzzzzzzzzzzzzzg_ = context.Operators.Union<ServiceRequest>(uzzzzzzzzzzzzzzzzzzd_, uzzzzzzzzzzzzzzzzzzf_);
            CqlValueSet uzzzzzzzzzzzzzzzzzzh_ = this.Referral_to_Primary_Care_or_Alternate_Provider(context);
            IEnumerable<ServiceRequest> uzzzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
            IEnumerable<ServiceRequest> uzzzzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
            IEnumerable<ServiceRequest> uzzzzzzzzzzzzzzzzzzl_ = context.Operators.Union<ServiceRequest>(uzzzzzzzzzzzzzzzzzzi_, uzzzzzzzzzzzzzzzzzzk_);
            IEnumerable<ServiceRequest> uzzzzzzzzzzzzzzzzzzm_ = context.Operators.Union<ServiceRequest>(uzzzzzzzzzzzzzzzzzzg_, uzzzzzzzzzzzzzzzzzzl_);
            bool? uzzzzzzzzzzzzzzzzzzn_(ServiceRequest FirstHTNDeclinedInterventions)
            {
                bool? uzzzzzzzzzzzzzzzzzzr_(Extension @this)
                {
                    string vzzzzzzzzzzzzzzzzzzk_ = @this?.Url;
                    FhirString vzzzzzzzzzzzzzzzzzzl_ = context.Operators.Convert<FhirString>(vzzzzzzzzzzzzzzzzzzk_);
                    string vzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToString(context, vzzzzzzzzzzzzzzzzzzl_);
                    bool? vzzzzzzzzzzzzzzzzzzn_ = context.Operators.Equal(vzzzzzzzzzzzzzzzzzzm_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerformReason");

                    return vzzzzzzzzzzzzzzzzzzn_;
                };
                IEnumerable<Extension> uzzzzzzzzzzzzzzzzzzs_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(FirstHTNDeclinedInterventions is DomainResource
                        ? (FirstHTNDeclinedInterventions as DomainResource).Extension
                        : default), uzzzzzzzzzzzzzzzzzzr_);
                object uzzzzzzzzzzzzzzzzzzt_(Extension @this)
                {
                    DataType vzzzzzzzzzzzzzzzzzzo_ = @this?.Value;

                    return vzzzzzzzzzzzzzzzzzzo_;
                };
                IEnumerable<object> uzzzzzzzzzzzzzzzzzzu_ = context.Operators.Select<Extension, object>(uzzzzzzzzzzzzzzzzzzs_, uzzzzzzzzzzzzzzzzzzt_);
                object uzzzzzzzzzzzzzzzzzzv_ = context.Operators.SingletonFrom<object>(uzzzzzzzzzzzzzzzzzzu_);
                CqlConcept uzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, uzzzzzzzzzzzzzzzzzzv_ as CodeableConcept);
                CqlValueSet uzzzzzzzzzzzzzzzzzzx_ = this.Patient_Declined(context);
                bool? uzzzzzzzzzzzzzzzzzzy_ = context.Operators.ConceptInValueSet(uzzzzzzzzzzzzzzzzzzw_, uzzzzzzzzzzzzzzzzzzx_);
                FhirDateTime uzzzzzzzzzzzzzzzzzzz_ = FirstHTNDeclinedInterventions?.AuthoredOnElement;
                CqlDateTime vzzzzzzzzzzzzzzzzzza_ = context.Operators.Convert<CqlDateTime>(uzzzzzzzzzzzzzzzzzzz_);
                Period vzzzzzzzzzzzzzzzzzzb_ = FirstHTNEncounter?.Period;
                CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzzzzzzzzzzzzzzzb_);
                bool? vzzzzzzzzzzzzzzzzzzd_ = context.Operators.In<CqlDateTime>(vzzzzzzzzzzzzzzzzzza_, vzzzzzzzzzzzzzzzzzzc_, "day");
                bool? vzzzzzzzzzzzzzzzzzze_ = context.Operators.And(uzzzzzzzzzzzzzzzzzzy_, vzzzzzzzzzzzzzzzzzzd_);
                Code<RequestStatus> vzzzzzzzzzzzzzzzzzzf_ = FirstHTNDeclinedInterventions?.StatusElement;
                RequestStatus? vzzzzzzzzzzzzzzzzzzg_ = vzzzzzzzzzzzzzzzzzzf_?.Value;
                Code<RequestStatus> vzzzzzzzzzzzzzzzzzzh_ = context.Operators.Convert<Code<RequestStatus>>(vzzzzzzzzzzzzzzzzzzg_);
                bool? vzzzzzzzzzzzzzzzzzzi_ = context.Operators.Equal(vzzzzzzzzzzzzzzzzzzh_, "completed");
                bool? vzzzzzzzzzzzzzzzzzzj_ = context.Operators.And(vzzzzzzzzzzzzzzzzzze_, vzzzzzzzzzzzzzzzzzzi_);

                return vzzzzzzzzzzzzzzzzzzj_;
            };
            IEnumerable<ServiceRequest> uzzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<ServiceRequest>(uzzzzzzzzzzzzzzzzzzm_, uzzzzzzzzzzzzzzzzzzn_);
            Encounter uzzzzzzzzzzzzzzzzzzp_(ServiceRequest FirstHTNDeclinedInterventions) =>
                FirstHTNEncounter;
            IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzq_ = context.Operators.Select<ServiceRequest, Encounter>(uzzzzzzzzzzzzzzzzzzo_, uzzzzzzzzzzzzzzzzzzp_);

            return uzzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzr_ = context.Operators.SelectMany<Encounter, Encounter>(rzzzzzzzzzzzzzzzzzzp_, rzzzzzzzzzzzzzzzzzzq_);
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzt_(Encounter FirstHTNEncounter)
        {
            IEnumerable<ServiceRequest> vzzzzzzzzzzzzzzzzzzp_ = this.NonPharmacological_Intervention_Not_Ordered(context);
            bool? vzzzzzzzzzzzzzzzzzzq_(ServiceRequest NoNonPharm)
            {
                FhirDateTime vzzzzzzzzzzzzzzzzzzu_ = NoNonPharm?.AuthoredOnElement;
                CqlDateTime vzzzzzzzzzzzzzzzzzzv_ = context.Operators.Convert<CqlDateTime>(vzzzzzzzzzzzzzzzzzzu_);
                Period vzzzzzzzzzzzzzzzzzzw_ = FirstHTNEncounter?.Period;
                CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzzzzzzzzzzzzzzzw_);
                bool? vzzzzzzzzzzzzzzzzzzy_ = context.Operators.In<CqlDateTime>(vzzzzzzzzzzzzzzzzzzv_, vzzzzzzzzzzzzzzzzzzx_, "day");

                return vzzzzzzzzzzzzzzzzzzy_;
            };
            IEnumerable<ServiceRequest> vzzzzzzzzzzzzzzzzzzr_ = context.Operators.Where<ServiceRequest>(vzzzzzzzzzzzzzzzzzzp_, vzzzzzzzzzzzzzzzzzzq_);
            Encounter vzzzzzzzzzzzzzzzzzzs_(ServiceRequest NoNonPharm) =>
                FirstHTNEncounter;
            IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzt_ = context.Operators.Select<ServiceRequest, Encounter>(vzzzzzzzzzzzzzzzzzzr_, vzzzzzzzzzzzzzzzzzzs_);

            return vzzzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzu_ = context.Operators.SelectMany<Encounter, Encounter>(rzzzzzzzzzzzzzzzzzzp_, rzzzzzzzzzzzzzzzzzzt_);
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzv_ = context.Operators.Union<Encounter>(rzzzzzzzzzzzzzzzzzzr_, rzzzzzzzzzzzzzzzzzzu_);
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzw_ = context.Operators.Union<Encounter>(rzzzzzzzzzzzzzzzzzzo_, rzzzzzzzzzzzzzzzzzzv_);
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzx_ = this.Encounter_with_Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89(context);
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzy_(Encounter SecondHTNEncounter)
        {
            IEnumerable<ServiceRequest> vzzzzzzzzzzzzzzzzzzz_ = this.Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89_Interventions_Declined(context);
            bool? wzzzzzzzzzzzzzzzzzza_(ServiceRequest SecondHTNDeclinedInterventions)
            {
                FhirDateTime wzzzzzzzzzzzzzzzzzze_ = SecondHTNDeclinedInterventions?.AuthoredOnElement;
                CqlDateTime wzzzzzzzzzzzzzzzzzzf_ = context.Operators.Convert<CqlDateTime>(wzzzzzzzzzzzzzzzzzze_);
                Period wzzzzzzzzzzzzzzzzzzg_ = SecondHTNEncounter?.Period;
                CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzzzzzzzzzzzzzzg_);
                bool? wzzzzzzzzzzzzzzzzzzi_ = context.Operators.In<CqlDateTime>(wzzzzzzzzzzzzzzzzzzf_, wzzzzzzzzzzzzzzzzzzh_, "day");

                return wzzzzzzzzzzzzzzzzzzi_;
            };
            IEnumerable<ServiceRequest> wzzzzzzzzzzzzzzzzzzb_ = context.Operators.Where<ServiceRequest>(vzzzzzzzzzzzzzzzzzzz_, wzzzzzzzzzzzzzzzzzza_);
            Encounter wzzzzzzzzzzzzzzzzzzc_(ServiceRequest SecondHTNDeclinedInterventions) =>
                SecondHTNEncounter;
            IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzd_ = context.Operators.Select<ServiceRequest, Encounter>(wzzzzzzzzzzzzzzzzzzb_, wzzzzzzzzzzzzzzzzzzc_);

            return wzzzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzz_ = context.Operators.SelectMany<Encounter, Encounter>(rzzzzzzzzzzzzzzzzzzx_, rzzzzzzzzzzzzzzzzzzy_);
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzza_ = this.Encounter_with_Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90(context);
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzb_(Encounter SecondHTN140Over90Encounter)
        {
            IEnumerable<object> wzzzzzzzzzzzzzzzzzzj_ = this.Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90_Interventions_Declined(context);
            bool? wzzzzzzzzzzzzzzzzzzk_(object SecondHTN140Over90DeclinedInterventions)
            {
                object wzzzzzzzzzzzzzzzzzzo_ = context.Operators.LateBoundProperty<object>(SecondHTN140Over90DeclinedInterventions, "authoredOn");
                CqlDateTime wzzzzzzzzzzzzzzzzzzp_ = context.Operators.LateBoundProperty<CqlDateTime>(wzzzzzzzzzzzzzzzzzzo_, "value");
                Period wzzzzzzzzzzzzzzzzzzq_ = SecondHTN140Over90Encounter?.Period;
                CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzzzzzzzzzzzzzzq_);
                bool? wzzzzzzzzzzzzzzzzzzs_ = context.Operators.In<CqlDateTime>(wzzzzzzzzzzzzzzzzzzp_, wzzzzzzzzzzzzzzzzzzr_, "day");

                return wzzzzzzzzzzzzzzzzzzs_;
            };
            IEnumerable<object> wzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<object>(wzzzzzzzzzzzzzzzzzzj_, wzzzzzzzzzzzzzzzzzzk_);
            Encounter wzzzzzzzzzzzzzzzzzzm_(object SecondHTN140Over90DeclinedInterventions) =>
                SecondHTN140Over90Encounter;
            IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzn_ = context.Operators.Select<object, Encounter>(wzzzzzzzzzzzzzzzzzzl_, wzzzzzzzzzzzzzzzzzzm_);

            return wzzzzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzc_ = context.Operators.SelectMany<Encounter, Encounter>(szzzzzzzzzzzzzzzzzza_, szzzzzzzzzzzzzzzzzzb_);
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzd_ = context.Operators.Union<Encounter>(rzzzzzzzzzzzzzzzzzzz_, szzzzzzzzzzzzzzzzzzc_);
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzze_ = context.Operators.Union<Encounter>(rzzzzzzzzzzzzzzzzzzw_, szzzzzzzzzzzzzzzzzzd_);

        return szzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Denominator Exceptions")]
    public IEnumerable<Encounter> Denominator_Exceptions(CqlContext context)
    {
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzt_ = this.Encounter_with_Medical_Reason_for_Not_Obtaining_or_Patient_Declined_Blood_Pressure_Measurement(context);
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzu_ = this.Encounter_with_Order_for_Hypertension_Follow_Up_Declined_by_Patient(context);
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzv_ = context.Operators.Union<Encounter>(wzzzzzzzzzzzzzzzzzzt_, wzzzzzzzzzzzzzzzzzzu_);

        return wzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? wzzzzzzzzzzzzzzzzzzw_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return wzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> wzzzzzzzzzzzzzzzzzzx_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return wzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? wzzzzzzzzzzzzzzzzzzy_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return wzzzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode wzzzzzzzzzzzzzzzzzzz_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return wzzzzzzzzzzzzzzzzzzz_;
    }


    #endregion Expressions

}
