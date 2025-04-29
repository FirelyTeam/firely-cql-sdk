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
        CqlDateTime xzzzzzzzzzzzzzq_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime xzzzzzzzzzzzzzr_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> xzzzzzzzzzzzzzs_ = context.Operators.Interval(xzzzzzzzzzzzzzq_, xzzzzzzzzzzzzzr_, true, true);
        object xzzzzzzzzzzzzzt_ = context.ResolveParameter("PCSBPScreeningFollowUpFHIR-0.2.000", "Measurement Period", xzzzzzzzzzzzzzs_);

        return (CqlInterval<CqlDateTime>)xzzzzzzzzzzzzzt_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> xzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient xzzzzzzzzzzzzzv_ = context.Operators.SingletonFrom<Patient>(xzzzzzzzzzzzzzu_);

        return xzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Qualifying Encounter during Measurement Period")]
    public IEnumerable<Encounter> Qualifying_Encounter_during_Measurement_Period(CqlContext context)
    {
        CqlValueSet xzzzzzzzzzzzzzw_ = this.Encounter_to_Screen_for_Blood_Pressure(context);
        IEnumerable<Encounter> xzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, xzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? xzzzzzzzzzzzzzy_(Encounter ValidEncounter)
        {
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzza_ = this.Measurement_Period(context);
            Period yzzzzzzzzzzzzzb_ = ValidEncounter?.Period;
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzzzzzzzzzzb_);
            bool? yzzzzzzzzzzzzzd_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(yzzzzzzzzzzzzza_, yzzzzzzzzzzzzzc_, "day");
            Code<Encounter.EncounterStatus> yzzzzzzzzzzzzze_ = ValidEncounter?.StatusElement;
            Encounter.EncounterStatus? yzzzzzzzzzzzzzf_ = yzzzzzzzzzzzzze_?.Value;
            Code<Encounter.EncounterStatus> yzzzzzzzzzzzzzg_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(yzzzzzzzzzzzzzf_);
            bool? yzzzzzzzzzzzzzh_ = context.Operators.Equivalent(yzzzzzzzzzzzzzg_, "finished");
            bool? yzzzzzzzzzzzzzi_ = context.Operators.And(yzzzzzzzzzzzzzd_, yzzzzzzzzzzzzzh_);
            Coding yzzzzzzzzzzzzzj_ = ValidEncounter?.Class;
            CqlCode yzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToCode(context, yzzzzzzzzzzzzzj_);
            CqlCode yzzzzzzzzzzzzzl_ = this.@virtual(context);
            bool? yzzzzzzzzzzzzzm_ = context.Operators.Equivalent(yzzzzzzzzzzzzzk_, yzzzzzzzzzzzzzl_);
            bool? yzzzzzzzzzzzzzn_ = context.Operators.Not(yzzzzzzzzzzzzzm_);
            bool? yzzzzzzzzzzzzzo_ = context.Operators.And(yzzzzzzzzzzzzzi_, yzzzzzzzzzzzzzn_);

            return yzzzzzzzzzzzzzo_;
        };
        IEnumerable<Encounter> xzzzzzzzzzzzzzz_ = context.Operators.Where<Encounter>(xzzzzzzzzzzzzzx_, xzzzzzzzzzzzzzy_);

        return xzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> yzzzzzzzzzzzzzp_ = this.Qualifying_Encounter_during_Measurement_Period(context);
        bool? yzzzzzzzzzzzzzq_(Encounter QualifyingEncounter)
        {
            Patient yzzzzzzzzzzzzzs_ = this.Patient(context);
            Date yzzzzzzzzzzzzzt_ = yzzzzzzzzzzzzzs_?.BirthDateElement;
            string yzzzzzzzzzzzzzu_ = yzzzzzzzzzzzzzt_?.Value;
            CqlDateTime yzzzzzzzzzzzzzv_ = context.Operators.ConvertStringToDateTime(yzzzzzzzzzzzzzu_);
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzzw_ = this.Measurement_Period(context);
            CqlDateTime yzzzzzzzzzzzzzx_ = context.Operators.Start(yzzzzzzzzzzzzzw_);
            int? yzzzzzzzzzzzzzy_ = context.Operators.CalculateAgeAt(yzzzzzzzzzzzzzv_, yzzzzzzzzzzzzzx_, "year");
            bool? yzzzzzzzzzzzzzz_ = context.Operators.GreaterOrEqual(yzzzzzzzzzzzzzy_, 18);

            return yzzzzzzzzzzzzzz_;
        };
        IEnumerable<Encounter> yzzzzzzzzzzzzzr_ = context.Operators.Where<Encounter>(yzzzzzzzzzzzzzp_, yzzzzzzzzzzzzzq_);

        return yzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context)
    {
        IEnumerable<Encounter> zzzzzzzzzzzzzza_ = this.Initial_Population(context);

        return zzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public IEnumerable<Encounter> Denominator_Exclusions(CqlContext context)
    {
        IEnumerable<Encounter> zzzzzzzzzzzzzzb_ = this.Qualifying_Encounter_during_Measurement_Period(context);
        IEnumerable<Encounter> zzzzzzzzzzzzzzc_(Encounter QualifyingEncounter)
        {
            CqlValueSet zzzzzzzzzzzzzze_ = this.Diagnosis_of_Hypertension(context);
            IEnumerable<Condition> zzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, zzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            bool? zzzzzzzzzzzzzzg_(Condition Hypertension)
            {
                bool? zzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.isProblemListItem(context, Hypertension);
                bool? zzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.isHealthConcern(context, Hypertension);
                bool? zzzzzzzzzzzzzzm_ = context.Operators.Or(zzzzzzzzzzzzzzk_, zzzzzzzzzzzzzzl_);
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzn_()
                {
                    bool zzzzzzzzzzzzzzs_()
                    {
                        CqlInterval<CqlDateTime> zzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, Hypertension);
                        CqlDateTime zzzzzzzzzzzzzzu_ = context.Operators.Start(zzzzzzzzzzzzzzt_);

                        return zzzzzzzzzzzzzzu_ is null;
                    };
                    if (zzzzzzzzzzzzzzs_())
                    {
                        return default;
                    }
                    else
                    {
                        CqlInterval<CqlDateTime> zzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, Hypertension);
                        CqlDateTime zzzzzzzzzzzzzzw_ = context.Operators.Start(zzzzzzzzzzzzzzv_);
                        CqlDateTime zzzzzzzzzzzzzzy_ = context.Operators.Start(zzzzzzzzzzzzzzv_);
                        CqlInterval<CqlDateTime> zzzzzzzzzzzzzzz_ = context.Operators.Interval(zzzzzzzzzzzzzzw_, zzzzzzzzzzzzzzy_, true, true);

                        return zzzzzzzzzzzzzzz_;
                    }
                };
                Period zzzzzzzzzzzzzzo_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzzzzzzzzzo_);
                bool? zzzzzzzzzzzzzzq_ = context.Operators.SameOrBefore(zzzzzzzzzzzzzzn_(), zzzzzzzzzzzzzzp_, "day");
                bool? zzzzzzzzzzzzzzr_ = context.Operators.And(zzzzzzzzzzzzzzm_, zzzzzzzzzzzzzzq_);

                return zzzzzzzzzzzzzzr_;
            };
            IEnumerable<Condition> zzzzzzzzzzzzzzh_ = context.Operators.Where<Condition>(zzzzzzzzzzzzzzf_, zzzzzzzzzzzzzzg_);
            Encounter zzzzzzzzzzzzzzi_(Condition Hypertension) =>
                QualifyingEncounter;
            IEnumerable<Encounter> zzzzzzzzzzzzzzj_ = context.Operators.Select<Condition, Encounter>(zzzzzzzzzzzzzzh_, zzzzzzzzzzzzzzi_);

            return zzzzzzzzzzzzzzj_;
        };
        IEnumerable<Encounter> zzzzzzzzzzzzzzd_ = context.Operators.SelectMany<Encounter, Encounter>(zzzzzzzzzzzzzzb_, zzzzzzzzzzzzzzc_);

        return zzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Encounter with Normal Blood Pressure Reading")]
    public IEnumerable<Encounter> Encounter_with_Normal_Blood_Pressure_Reading(CqlContext context)
    {
        IEnumerable<Encounter> azzzzzzzzzzzzzza_ = this.Qualifying_Encounter_during_Measurement_Period(context);
        bool? azzzzzzzzzzzzzzb_(Encounter QualifyingEncounter)
        {
            IEnumerable<Observation> azzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/bp"));
            bool? azzzzzzzzzzzzzze_(Observation BloodPressure)
            {
                DataType bzzzzzzzzzzzzzzk_ = BloodPressure?.Effective;
                object bzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzk_);
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.toInterval(context, bzzzzzzzzzzzzzzl_);
                CqlDateTime bzzzzzzzzzzzzzzn_ = context.Operators.End(bzzzzzzzzzzzzzzm_);
                Period bzzzzzzzzzzzzzzo_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzzzzzzzzo_);
                bool? bzzzzzzzzzzzzzzq_ = context.Operators.In<CqlDateTime>(bzzzzzzzzzzzzzzn_, bzzzzzzzzzzzzzzp_, default);
                Code<ObservationStatus> bzzzzzzzzzzzzzzr_ = BloodPressure?.StatusElement;
                ObservationStatus? bzzzzzzzzzzzzzzs_ = bzzzzzzzzzzzzzzr_?.Value;
                string bzzzzzzzzzzzzzzt_ = context.Operators.Convert<string>(bzzzzzzzzzzzzzzs_);
                string[] bzzzzzzzzzzzzzzu_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? bzzzzzzzzzzzzzzv_ = context.Operators.In<string>(bzzzzzzzzzzzzzzt_, bzzzzzzzzzzzzzzu_ as IEnumerable<string>);
                bool? bzzzzzzzzzzzzzzw_ = context.Operators.And(bzzzzzzzzzzzzzzq_, bzzzzzzzzzzzzzzv_);

                return bzzzzzzzzzzzzzzw_;
            };
            IEnumerable<Observation> azzzzzzzzzzzzzzf_ = context.Operators.Where<Observation>(azzzzzzzzzzzzzzd_, azzzzzzzzzzzzzze_);
            object azzzzzzzzzzzzzzg_(Observation @this)
            {
                DataType bzzzzzzzzzzzzzzx_ = @this?.Effective;
                object bzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzx_);
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.toInterval(context, bzzzzzzzzzzzzzzy_);
                CqlDateTime czzzzzzzzzzzzzza_ = context.Operators.Start(bzzzzzzzzzzzzzzz_);

                return czzzzzzzzzzzzzza_;
            };
            IEnumerable<Observation> azzzzzzzzzzzzzzh_ = context.Operators.SortBy<Observation>(azzzzzzzzzzzzzzf_, azzzzzzzzzzzzzzg_, System.ComponentModel.ListSortDirection.Ascending);
            Observation azzzzzzzzzzzzzzi_ = context.Operators.Last<Observation>(azzzzzzzzzzzzzzh_);
            List<Observation.ComponentComponent> azzzzzzzzzzzzzzj_ = azzzzzzzzzzzzzzi_?.Component;
            bool? azzzzzzzzzzzzzzk_(Observation.ComponentComponent @this)
            {
                CodeableConcept czzzzzzzzzzzzzzb_ = @this?.Code;
                List<Coding> czzzzzzzzzzzzzzc_ = czzzzzzzzzzzzzzb_?.Coding;
                Coding czzzzzzzzzzzzzzd_ = context.Operators.First<Coding>((IEnumerable<Coding>)czzzzzzzzzzzzzzc_);
                FhirUri czzzzzzzzzzzzzze_ = czzzzzzzzzzzzzzd_?.SystemElement;
                string czzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToString(context, czzzzzzzzzzzzzze_);
                bool? czzzzzzzzzzzzzzg_ = context.Operators.Equal(czzzzzzzzzzzzzzf_, "http://loinc.org");
                List<Coding> czzzzzzzzzzzzzzi_ = czzzzzzzzzzzzzzb_?.Coding;
                Coding czzzzzzzzzzzzzzj_ = context.Operators.First<Coding>((IEnumerable<Coding>)czzzzzzzzzzzzzzi_);
                Code czzzzzzzzzzzzzzk_ = czzzzzzzzzzzzzzj_?.CodeElement;
                string czzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToString(context, czzzzzzzzzzzzzzk_);
                bool? czzzzzzzzzzzzzzm_ = context.Operators.Equal(czzzzzzzzzzzzzzl_, "8480-6");
                bool? czzzzzzzzzzzzzzn_ = context.Operators.And(czzzzzzzzzzzzzzg_, czzzzzzzzzzzzzzm_);

                return czzzzzzzzzzzzzzn_;
            };
            IEnumerable<Observation.ComponentComponent> azzzzzzzzzzzzzzl_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)azzzzzzzzzzzzzzj_, azzzzzzzzzzzzzzk_);
            Observation.ComponentComponent azzzzzzzzzzzzzzm_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(azzzzzzzzzzzzzzl_);
            DataType azzzzzzzzzzzzzzn_ = azzzzzzzzzzzzzzm_?.Value;
            object azzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzn_);
            CqlQuantity azzzzzzzzzzzzzzp_ = context.Operators.Quantity(1m, "mm[Hg]");
            CqlQuantity azzzzzzzzzzzzzzq_ = context.Operators.Quantity(120m, "mm[Hg]");
            CqlInterval<CqlQuantity> azzzzzzzzzzzzzzr_ = context.Operators.Interval(azzzzzzzzzzzzzzp_, azzzzzzzzzzzzzzq_, true, false);
            bool? azzzzzzzzzzzzzzs_ = context.Operators.In<CqlQuantity>(azzzzzzzzzzzzzzo_ as CqlQuantity, azzzzzzzzzzzzzzr_, default);
            bool? azzzzzzzzzzzzzzu_(Observation BloodPressure)
            {
                DataType czzzzzzzzzzzzzzo_ = BloodPressure?.Effective;
                object czzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzo_);
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.toInterval(context, czzzzzzzzzzzzzzp_);
                CqlDateTime czzzzzzzzzzzzzzr_ = context.Operators.End(czzzzzzzzzzzzzzq_);
                Period czzzzzzzzzzzzzzs_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzzzzzzzzzzs_);
                bool? czzzzzzzzzzzzzzu_ = context.Operators.In<CqlDateTime>(czzzzzzzzzzzzzzr_, czzzzzzzzzzzzzzt_, default);
                Code<ObservationStatus> czzzzzzzzzzzzzzv_ = BloodPressure?.StatusElement;
                ObservationStatus? czzzzzzzzzzzzzzw_ = czzzzzzzzzzzzzzv_?.Value;
                string czzzzzzzzzzzzzzx_ = context.Operators.Convert<string>(czzzzzzzzzzzzzzw_);
                string[] czzzzzzzzzzzzzzy_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? czzzzzzzzzzzzzzz_ = context.Operators.In<string>(czzzzzzzzzzzzzzx_, czzzzzzzzzzzzzzy_ as IEnumerable<string>);
                bool? dzzzzzzzzzzzzzza_ = context.Operators.And(czzzzzzzzzzzzzzu_, czzzzzzzzzzzzzzz_);

                return dzzzzzzzzzzzzzza_;
            };
            IEnumerable<Observation> azzzzzzzzzzzzzzv_ = context.Operators.Where<Observation>(azzzzzzzzzzzzzzd_, azzzzzzzzzzzzzzu_);
            object azzzzzzzzzzzzzzw_(Observation @this)
            {
                DataType dzzzzzzzzzzzzzzb_ = @this?.Effective;
                object dzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzb_);
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.toInterval(context, dzzzzzzzzzzzzzzc_);
                CqlDateTime dzzzzzzzzzzzzzze_ = context.Operators.Start(dzzzzzzzzzzzzzzd_);

                return dzzzzzzzzzzzzzze_;
            };
            IEnumerable<Observation> azzzzzzzzzzzzzzx_ = context.Operators.SortBy<Observation>(azzzzzzzzzzzzzzv_, azzzzzzzzzzzzzzw_, System.ComponentModel.ListSortDirection.Ascending);
            Observation azzzzzzzzzzzzzzy_ = context.Operators.Last<Observation>(azzzzzzzzzzzzzzx_);
            List<Observation.ComponentComponent> azzzzzzzzzzzzzzz_ = azzzzzzzzzzzzzzy_?.Component;
            bool? bzzzzzzzzzzzzzza_(Observation.ComponentComponent @this)
            {
                CodeableConcept dzzzzzzzzzzzzzzf_ = @this?.Code;
                List<Coding> dzzzzzzzzzzzzzzg_ = dzzzzzzzzzzzzzzf_?.Coding;
                Coding dzzzzzzzzzzzzzzh_ = context.Operators.First<Coding>((IEnumerable<Coding>)dzzzzzzzzzzzzzzg_);
                FhirUri dzzzzzzzzzzzzzzi_ = dzzzzzzzzzzzzzzh_?.SystemElement;
                string dzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToString(context, dzzzzzzzzzzzzzzi_);
                bool? dzzzzzzzzzzzzzzk_ = context.Operators.Equal(dzzzzzzzzzzzzzzj_, "http://loinc.org");
                List<Coding> dzzzzzzzzzzzzzzm_ = dzzzzzzzzzzzzzzf_?.Coding;
                Coding dzzzzzzzzzzzzzzn_ = context.Operators.First<Coding>((IEnumerable<Coding>)dzzzzzzzzzzzzzzm_);
                Code dzzzzzzzzzzzzzzo_ = dzzzzzzzzzzzzzzn_?.CodeElement;
                string dzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToString(context, dzzzzzzzzzzzzzzo_);
                bool? dzzzzzzzzzzzzzzq_ = context.Operators.Equal(dzzzzzzzzzzzzzzp_, "8462-4");
                bool? dzzzzzzzzzzzzzzr_ = context.Operators.And(dzzzzzzzzzzzzzzk_, dzzzzzzzzzzzzzzq_);

                return dzzzzzzzzzzzzzzr_;
            };
            IEnumerable<Observation.ComponentComponent> bzzzzzzzzzzzzzzb_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)azzzzzzzzzzzzzzz_, bzzzzzzzzzzzzzza_);
            Observation.ComponentComponent bzzzzzzzzzzzzzzc_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(bzzzzzzzzzzzzzzb_);
            DataType bzzzzzzzzzzzzzzd_ = bzzzzzzzzzzzzzzc_?.Value;
            object bzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzd_);
            CqlQuantity bzzzzzzzzzzzzzzg_ = context.Operators.Quantity(80m, "mm[Hg]");
            CqlInterval<CqlQuantity> bzzzzzzzzzzzzzzh_ = context.Operators.Interval(azzzzzzzzzzzzzzp_, bzzzzzzzzzzzzzzg_, true, false);
            bool? bzzzzzzzzzzzzzzi_ = context.Operators.In<CqlQuantity>(bzzzzzzzzzzzzzze_ as CqlQuantity, bzzzzzzzzzzzzzzh_, default);
            bool? bzzzzzzzzzzzzzzj_ = context.Operators.And(azzzzzzzzzzzzzzs_, bzzzzzzzzzzzzzzi_);

            return bzzzzzzzzzzzzzzj_;
        };
        IEnumerable<Encounter> azzzzzzzzzzzzzzc_ = context.Operators.Where<Encounter>(azzzzzzzzzzzzzza_, azzzzzzzzzzzzzzb_);

        return azzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Encounter with Elevated Blood Pressure Reading SBP 120 to 129 AND DBP less than 80")]
    public IEnumerable<Encounter> Encounter_with_Elevated_Blood_Pressure_Reading_SBP_120_to_129_AND_DBP_less_than_80(CqlContext context)
    {
        IEnumerable<Encounter> dzzzzzzzzzzzzzzs_ = this.Qualifying_Encounter_during_Measurement_Period(context);
        bool? dzzzzzzzzzzzzzzt_(Encounter QualifyingEncounter)
        {
            IEnumerable<Observation> dzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/bp"));
            bool? dzzzzzzzzzzzzzzw_(Observation BloodPressure)
            {
                DataType fzzzzzzzzzzzzzzc_ = BloodPressure?.Effective;
                object fzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzc_);
                CqlInterval<CqlDateTime> fzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.toInterval(context, fzzzzzzzzzzzzzzd_);
                CqlDateTime fzzzzzzzzzzzzzzf_ = context.Operators.End(fzzzzzzzzzzzzzze_);
                Period fzzzzzzzzzzzzzzg_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzzzzzzzzzzg_);
                bool? fzzzzzzzzzzzzzzi_ = context.Operators.In<CqlDateTime>(fzzzzzzzzzzzzzzf_, fzzzzzzzzzzzzzzh_, default);
                Code<ObservationStatus> fzzzzzzzzzzzzzzj_ = BloodPressure?.StatusElement;
                ObservationStatus? fzzzzzzzzzzzzzzk_ = fzzzzzzzzzzzzzzj_?.Value;
                string fzzzzzzzzzzzzzzl_ = context.Operators.Convert<string>(fzzzzzzzzzzzzzzk_);
                string[] fzzzzzzzzzzzzzzm_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? fzzzzzzzzzzzzzzn_ = context.Operators.In<string>(fzzzzzzzzzzzzzzl_, fzzzzzzzzzzzzzzm_ as IEnumerable<string>);
                bool? fzzzzzzzzzzzzzzo_ = context.Operators.And(fzzzzzzzzzzzzzzi_, fzzzzzzzzzzzzzzn_);

                return fzzzzzzzzzzzzzzo_;
            };
            IEnumerable<Observation> dzzzzzzzzzzzzzzx_ = context.Operators.Where<Observation>(dzzzzzzzzzzzzzzv_, dzzzzzzzzzzzzzzw_);
            object dzzzzzzzzzzzzzzy_(Observation @this)
            {
                DataType fzzzzzzzzzzzzzzp_ = @this?.Effective;
                object fzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzp_);
                CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.toInterval(context, fzzzzzzzzzzzzzzq_);
                CqlDateTime fzzzzzzzzzzzzzzs_ = context.Operators.Start(fzzzzzzzzzzzzzzr_);

                return fzzzzzzzzzzzzzzs_;
            };
            IEnumerable<Observation> dzzzzzzzzzzzzzzz_ = context.Operators.SortBy<Observation>(dzzzzzzzzzzzzzzx_, dzzzzzzzzzzzzzzy_, System.ComponentModel.ListSortDirection.Ascending);
            Observation ezzzzzzzzzzzzzza_ = context.Operators.Last<Observation>(dzzzzzzzzzzzzzzz_);
            List<Observation.ComponentComponent> ezzzzzzzzzzzzzzb_ = ezzzzzzzzzzzzzza_?.Component;
            bool? ezzzzzzzzzzzzzzc_(Observation.ComponentComponent @this)
            {
                CodeableConcept fzzzzzzzzzzzzzzt_ = @this?.Code;
                List<Coding> fzzzzzzzzzzzzzzu_ = fzzzzzzzzzzzzzzt_?.Coding;
                Coding fzzzzzzzzzzzzzzv_ = context.Operators.First<Coding>((IEnumerable<Coding>)fzzzzzzzzzzzzzzu_);
                FhirUri fzzzzzzzzzzzzzzw_ = fzzzzzzzzzzzzzzv_?.SystemElement;
                string fzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToString(context, fzzzzzzzzzzzzzzw_);
                bool? fzzzzzzzzzzzzzzy_ = context.Operators.Equal(fzzzzzzzzzzzzzzx_, "http://loinc.org");
                List<Coding> gzzzzzzzzzzzzzza_ = fzzzzzzzzzzzzzzt_?.Coding;
                Coding gzzzzzzzzzzzzzzb_ = context.Operators.First<Coding>((IEnumerable<Coding>)gzzzzzzzzzzzzzza_);
                Code gzzzzzzzzzzzzzzc_ = gzzzzzzzzzzzzzzb_?.CodeElement;
                string gzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToString(context, gzzzzzzzzzzzzzzc_);
                bool? gzzzzzzzzzzzzzze_ = context.Operators.Equal(gzzzzzzzzzzzzzzd_, "8480-6");
                bool? gzzzzzzzzzzzzzzf_ = context.Operators.And(fzzzzzzzzzzzzzzy_, gzzzzzzzzzzzzzze_);

                return gzzzzzzzzzzzzzzf_;
            };
            IEnumerable<Observation.ComponentComponent> ezzzzzzzzzzzzzzd_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)ezzzzzzzzzzzzzzb_, ezzzzzzzzzzzzzzc_);
            Observation.ComponentComponent ezzzzzzzzzzzzzze_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(ezzzzzzzzzzzzzzd_);
            DataType ezzzzzzzzzzzzzzf_ = ezzzzzzzzzzzzzze_?.Value;
            object ezzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzf_);
            CqlQuantity ezzzzzzzzzzzzzzh_ = context.Operators.Quantity(120m, "mm[Hg]");
            CqlQuantity ezzzzzzzzzzzzzzi_ = context.Operators.Quantity(129m, "mm[Hg]");
            CqlInterval<CqlQuantity> ezzzzzzzzzzzzzzj_ = context.Operators.Interval(ezzzzzzzzzzzzzzh_, ezzzzzzzzzzzzzzi_, true, true);
            bool? ezzzzzzzzzzzzzzk_ = context.Operators.In<CqlQuantity>(ezzzzzzzzzzzzzzg_ as CqlQuantity, ezzzzzzzzzzzzzzj_, default);
            bool? ezzzzzzzzzzzzzzm_(Observation BloodPressure)
            {
                DataType gzzzzzzzzzzzzzzg_ = BloodPressure?.Effective;
                object gzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzg_);
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.toInterval(context, gzzzzzzzzzzzzzzh_);
                CqlDateTime gzzzzzzzzzzzzzzj_ = context.Operators.End(gzzzzzzzzzzzzzzi_);
                Period gzzzzzzzzzzzzzzk_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzzzzzzzzzk_);
                bool? gzzzzzzzzzzzzzzm_ = context.Operators.In<CqlDateTime>(gzzzzzzzzzzzzzzj_, gzzzzzzzzzzzzzzl_, default);
                Code<ObservationStatus> gzzzzzzzzzzzzzzn_ = BloodPressure?.StatusElement;
                ObservationStatus? gzzzzzzzzzzzzzzo_ = gzzzzzzzzzzzzzzn_?.Value;
                string gzzzzzzzzzzzzzzp_ = context.Operators.Convert<string>(gzzzzzzzzzzzzzzo_);
                string[] gzzzzzzzzzzzzzzq_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? gzzzzzzzzzzzzzzr_ = context.Operators.In<string>(gzzzzzzzzzzzzzzp_, gzzzzzzzzzzzzzzq_ as IEnumerable<string>);
                bool? gzzzzzzzzzzzzzzs_ = context.Operators.And(gzzzzzzzzzzzzzzm_, gzzzzzzzzzzzzzzr_);

                return gzzzzzzzzzzzzzzs_;
            };
            IEnumerable<Observation> ezzzzzzzzzzzzzzn_ = context.Operators.Where<Observation>(dzzzzzzzzzzzzzzv_, ezzzzzzzzzzzzzzm_);
            object ezzzzzzzzzzzzzzo_(Observation @this)
            {
                DataType gzzzzzzzzzzzzzzt_ = @this?.Effective;
                object gzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzt_);
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.toInterval(context, gzzzzzzzzzzzzzzu_);
                CqlDateTime gzzzzzzzzzzzzzzw_ = context.Operators.Start(gzzzzzzzzzzzzzzv_);

                return gzzzzzzzzzzzzzzw_;
            };
            IEnumerable<Observation> ezzzzzzzzzzzzzzp_ = context.Operators.SortBy<Observation>(ezzzzzzzzzzzzzzn_, ezzzzzzzzzzzzzzo_, System.ComponentModel.ListSortDirection.Ascending);
            Observation ezzzzzzzzzzzzzzq_ = context.Operators.Last<Observation>(ezzzzzzzzzzzzzzp_);
            List<Observation.ComponentComponent> ezzzzzzzzzzzzzzr_ = ezzzzzzzzzzzzzzq_?.Component;
            bool? ezzzzzzzzzzzzzzs_(Observation.ComponentComponent @this)
            {
                CodeableConcept gzzzzzzzzzzzzzzx_ = @this?.Code;
                List<Coding> gzzzzzzzzzzzzzzy_ = gzzzzzzzzzzzzzzx_?.Coding;
                Coding gzzzzzzzzzzzzzzz_ = context.Operators.First<Coding>((IEnumerable<Coding>)gzzzzzzzzzzzzzzy_);
                FhirUri hzzzzzzzzzzzzzza_ = gzzzzzzzzzzzzzzz_?.SystemElement;
                string hzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToString(context, hzzzzzzzzzzzzzza_);
                bool? hzzzzzzzzzzzzzzc_ = context.Operators.Equal(hzzzzzzzzzzzzzzb_, "http://loinc.org");
                List<Coding> hzzzzzzzzzzzzzze_ = gzzzzzzzzzzzzzzx_?.Coding;
                Coding hzzzzzzzzzzzzzzf_ = context.Operators.First<Coding>((IEnumerable<Coding>)hzzzzzzzzzzzzzze_);
                Code hzzzzzzzzzzzzzzg_ = hzzzzzzzzzzzzzzf_?.CodeElement;
                string hzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToString(context, hzzzzzzzzzzzzzzg_);
                bool? hzzzzzzzzzzzzzzi_ = context.Operators.Equal(hzzzzzzzzzzzzzzh_, "8462-4");
                bool? hzzzzzzzzzzzzzzj_ = context.Operators.And(hzzzzzzzzzzzzzzc_, hzzzzzzzzzzzzzzi_);

                return hzzzzzzzzzzzzzzj_;
            };
            IEnumerable<Observation.ComponentComponent> ezzzzzzzzzzzzzzt_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)ezzzzzzzzzzzzzzr_, ezzzzzzzzzzzzzzs_);
            Observation.ComponentComponent ezzzzzzzzzzzzzzu_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(ezzzzzzzzzzzzzzt_);
            DataType ezzzzzzzzzzzzzzv_ = ezzzzzzzzzzzzzzu_?.Value;
            object ezzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzv_);
            CqlQuantity ezzzzzzzzzzzzzzx_ = context.Operators.Quantity(1m, "mm[Hg]");
            CqlQuantity ezzzzzzzzzzzzzzy_ = context.Operators.Quantity(80m, "mm[Hg]");
            CqlInterval<CqlQuantity> ezzzzzzzzzzzzzzz_ = context.Operators.Interval(ezzzzzzzzzzzzzzx_, ezzzzzzzzzzzzzzy_, true, false);
            bool? fzzzzzzzzzzzzzza_ = context.Operators.In<CqlQuantity>(ezzzzzzzzzzzzzzw_ as CqlQuantity, ezzzzzzzzzzzzzzz_, default);
            bool? fzzzzzzzzzzzzzzb_ = context.Operators.And(ezzzzzzzzzzzzzzk_, fzzzzzzzzzzzzzza_);

            return fzzzzzzzzzzzzzzb_;
        };
        IEnumerable<Encounter> dzzzzzzzzzzzzzzu_ = context.Operators.Where<Encounter>(dzzzzzzzzzzzzzzs_, dzzzzzzzzzzzzzzt_);

        return dzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Follow up with Rescreen Within 6 Months")]
    public IEnumerable<ServiceRequest> Follow_up_with_Rescreen_Within_6_Months(CqlContext context)
    {
        CqlValueSet hzzzzzzzzzzzzzzk_ = this.Follow_Up_Within_6_Months(context);
        IEnumerable<ServiceRequest> hzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, hzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        bool? hzzzzzzzzzzzzzzm_(ServiceRequest FollowUp)
        {
            Code<RequestIntent> hzzzzzzzzzzzzzzo_ = FollowUp?.IntentElement;
            RequestIntent? hzzzzzzzzzzzzzzp_ = hzzzzzzzzzzzzzzo_?.Value;
            Code<RequestIntent> hzzzzzzzzzzzzzzq_ = context.Operators.Convert<Code<RequestIntent>>(hzzzzzzzzzzzzzzp_);
            bool? hzzzzzzzzzzzzzzr_ = context.Operators.Equivalent(hzzzzzzzzzzzzzzq_, "order");

            return hzzzzzzzzzzzzzzr_;
        };
        IEnumerable<ServiceRequest> hzzzzzzzzzzzzzzn_ = context.Operators.Where<ServiceRequest>(hzzzzzzzzzzzzzzl_, hzzzzzzzzzzzzzzm_);

        return hzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("NonPharmacological Interventions")]
    public IEnumerable<ServiceRequest> NonPharmacological_Interventions(CqlContext context)
    {
        CqlValueSet hzzzzzzzzzzzzzzs_ = this.Lifestyle_Recommendation(context);
        IEnumerable<ServiceRequest> hzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, hzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        CqlValueSet hzzzzzzzzzzzzzzu_ = this.Weight_Reduction_Recommended(context);
        IEnumerable<ServiceRequest> hzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, hzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> hzzzzzzzzzzzzzzw_ = context.Operators.Union<ServiceRequest>(hzzzzzzzzzzzzzzt_, hzzzzzzzzzzzzzzv_);
        CqlValueSet hzzzzzzzzzzzzzzx_ = this.Dietary_Recommendations(context);
        IEnumerable<ServiceRequest> hzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, hzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        CqlValueSet hzzzzzzzzzzzzzzz_ = this.Recommendation_to_Increase_Physical_Activity(context);
        IEnumerable<ServiceRequest> izzzzzzzzzzzzzza_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, hzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> izzzzzzzzzzzzzzb_ = context.Operators.Union<ServiceRequest>(hzzzzzzzzzzzzzzy_, izzzzzzzzzzzzzza_);
        IEnumerable<ServiceRequest> izzzzzzzzzzzzzzc_ = context.Operators.Union<ServiceRequest>(hzzzzzzzzzzzzzzw_, izzzzzzzzzzzzzzb_);
        CqlValueSet izzzzzzzzzzzzzzd_ = this.Referral_or_Counseling_for_Alcohol_Consumption(context);
        IEnumerable<ServiceRequest> izzzzzzzzzzzzzze_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, izzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> izzzzzzzzzzzzzzf_ = context.Operators.Union<ServiceRequest>(izzzzzzzzzzzzzzc_, izzzzzzzzzzzzzze_);
        bool? izzzzzzzzzzzzzzg_(ServiceRequest NonPharmaInterventions)
        {
            Code<RequestIntent> izzzzzzzzzzzzzzi_ = NonPharmaInterventions?.IntentElement;
            RequestIntent? izzzzzzzzzzzzzzj_ = izzzzzzzzzzzzzzi_?.Value;
            Code<RequestIntent> izzzzzzzzzzzzzzk_ = context.Operators.Convert<Code<RequestIntent>>(izzzzzzzzzzzzzzj_);
            bool? izzzzzzzzzzzzzzl_ = context.Operators.Equivalent(izzzzzzzzzzzzzzk_, "order");

            return izzzzzzzzzzzzzzl_;
        };
        IEnumerable<ServiceRequest> izzzzzzzzzzzzzzh_ = context.Operators.Where<ServiceRequest>(izzzzzzzzzzzzzzf_, izzzzzzzzzzzzzzg_);

        return izzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Referral to Alternate or Primary Healthcare Professional for Hypertensive Reading")]
    public IEnumerable<ServiceRequest> Referral_to_Alternate_or_Primary_Healthcare_Professional_for_Hypertensive_Reading(CqlContext context)
    {
        CqlValueSet izzzzzzzzzzzzzzm_ = this.Referral_to_Primary_Care_or_Alternate_Provider(context);
        IEnumerable<ServiceRequest> izzzzzzzzzzzzzzn_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, izzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        bool? izzzzzzzzzzzzzzo_(ServiceRequest Referral)
        {
            List<CodeableConcept> izzzzzzzzzzzzzzq_ = Referral?.ReasonCode;
            CqlConcept izzzzzzzzzzzzzzr_(CodeableConcept @this)
            {
                CqlConcept jzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return jzzzzzzzzzzzzzza_;
            };
            IEnumerable<CqlConcept> izzzzzzzzzzzzzzs_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)izzzzzzzzzzzzzzq_, izzzzzzzzzzzzzzr_);
            CqlValueSet izzzzzzzzzzzzzzt_ = this.Finding_of_Elevated_Blood_Pressure_or_Hypertension(context);
            bool? izzzzzzzzzzzzzzu_ = context.Operators.ConceptsInValueSet(izzzzzzzzzzzzzzs_, izzzzzzzzzzzzzzt_);
            Code<RequestIntent> izzzzzzzzzzzzzzv_ = Referral?.IntentElement;
            RequestIntent? izzzzzzzzzzzzzzw_ = izzzzzzzzzzzzzzv_?.Value;
            Code<RequestIntent> izzzzzzzzzzzzzzx_ = context.Operators.Convert<Code<RequestIntent>>(izzzzzzzzzzzzzzw_);
            bool? izzzzzzzzzzzzzzy_ = context.Operators.Equivalent(izzzzzzzzzzzzzzx_, "order");
            bool? izzzzzzzzzzzzzzz_ = context.Operators.And(izzzzzzzzzzzzzzu_, izzzzzzzzzzzzzzy_);

            return izzzzzzzzzzzzzzz_;
        };
        IEnumerable<ServiceRequest> izzzzzzzzzzzzzzp_ = context.Operators.Where<ServiceRequest>(izzzzzzzzzzzzzzn_, izzzzzzzzzzzzzzo_);

        return izzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Encounter with Elevated Blood Pressure Reading SBP 120 to 129 AND DBP less than 80 and Interventions")]
    public IEnumerable<Encounter> Encounter_with_Elevated_Blood_Pressure_Reading_SBP_120_to_129_AND_DBP_less_than_80_and_Interventions(CqlContext context)
    {
        IEnumerable<Encounter> jzzzzzzzzzzzzzzb_ = this.Encounter_with_Elevated_Blood_Pressure_Reading_SBP_120_to_129_AND_DBP_less_than_80(context);
        IEnumerable<Encounter> jzzzzzzzzzzzzzzc_(Encounter ElevatedEncounter)
        {
            IEnumerable<ServiceRequest> jzzzzzzzzzzzzzzk_ = this.Follow_up_with_Rescreen_Within_6_Months(context);
            bool? jzzzzzzzzzzzzzzl_(ServiceRequest Twoto6MonthRescreen)
            {
                FhirDateTime jzzzzzzzzzzzzzzp_ = Twoto6MonthRescreen?.AuthoredOnElement;
                CqlDateTime jzzzzzzzzzzzzzzq_ = context.Operators.Convert<CqlDateTime>(jzzzzzzzzzzzzzzp_);
                Period jzzzzzzzzzzzzzzr_ = ElevatedEncounter?.Period;
                CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzzzzzzzzzr_);
                bool? jzzzzzzzzzzzzzzt_ = context.Operators.In<CqlDateTime>(jzzzzzzzzzzzzzzq_, jzzzzzzzzzzzzzzs_, "day");

                return jzzzzzzzzzzzzzzt_;
            };
            IEnumerable<ServiceRequest> jzzzzzzzzzzzzzzm_ = context.Operators.Where<ServiceRequest>(jzzzzzzzzzzzzzzk_, jzzzzzzzzzzzzzzl_);
            Encounter jzzzzzzzzzzzzzzn_(ServiceRequest Twoto6MonthRescreen) =>
                ElevatedEncounter;
            IEnumerable<Encounter> jzzzzzzzzzzzzzzo_ = context.Operators.Select<ServiceRequest, Encounter>(jzzzzzzzzzzzzzzm_, jzzzzzzzzzzzzzzn_);

            return jzzzzzzzzzzzzzzo_;
        };
        IEnumerable<Encounter> jzzzzzzzzzzzzzzd_ = context.Operators.SelectMany<Encounter, Encounter>(jzzzzzzzzzzzzzzb_, jzzzzzzzzzzzzzzc_);
        IEnumerable<Encounter> jzzzzzzzzzzzzzze_(Encounter ElevatedEncounter)
        {
            IEnumerable<ServiceRequest> jzzzzzzzzzzzzzzu_ = this.NonPharmacological_Interventions(context);
            bool? jzzzzzzzzzzzzzzv_(ServiceRequest NonPharmInterventions)
            {
                FhirDateTime jzzzzzzzzzzzzzzz_ = NonPharmInterventions?.AuthoredOnElement;
                CqlDateTime kzzzzzzzzzzzzzza_ = context.Operators.Convert<CqlDateTime>(jzzzzzzzzzzzzzzz_);
                Period kzzzzzzzzzzzzzzb_ = ElevatedEncounter?.Period;
                CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzzzzzzzzzzb_);
                bool? kzzzzzzzzzzzzzzd_ = context.Operators.In<CqlDateTime>(kzzzzzzzzzzzzzza_, kzzzzzzzzzzzzzzc_, "day");

                return kzzzzzzzzzzzzzzd_;
            };
            IEnumerable<ServiceRequest> jzzzzzzzzzzzzzzw_ = context.Operators.Where<ServiceRequest>(jzzzzzzzzzzzzzzu_, jzzzzzzzzzzzzzzv_);
            Encounter jzzzzzzzzzzzzzzx_(ServiceRequest NonPharmInterventions) =>
                ElevatedEncounter;
            IEnumerable<Encounter> jzzzzzzzzzzzzzzy_ = context.Operators.Select<ServiceRequest, Encounter>(jzzzzzzzzzzzzzzw_, jzzzzzzzzzzzzzzx_);

            return jzzzzzzzzzzzzzzy_;
        };
        IEnumerable<Encounter> jzzzzzzzzzzzzzzf_ = context.Operators.SelectMany<Encounter, Encounter>(jzzzzzzzzzzzzzzd_, jzzzzzzzzzzzzzze_);
        IEnumerable<Encounter> jzzzzzzzzzzzzzzh_(Encounter ElevatedEncounter)
        {
            IEnumerable<ServiceRequest> kzzzzzzzzzzzzzze_ = this.Referral_to_Alternate_or_Primary_Healthcare_Professional_for_Hypertensive_Reading(context);
            bool? kzzzzzzzzzzzzzzf_(ServiceRequest Referral)
            {
                FhirDateTime kzzzzzzzzzzzzzzj_ = Referral?.AuthoredOnElement;
                CqlDateTime kzzzzzzzzzzzzzzk_ = context.Operators.Convert<CqlDateTime>(kzzzzzzzzzzzzzzj_);
                Period kzzzzzzzzzzzzzzl_ = ElevatedEncounter?.Period;
                CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzzzzzzzzzzl_);
                bool? kzzzzzzzzzzzzzzn_ = context.Operators.In<CqlDateTime>(kzzzzzzzzzzzzzzk_, kzzzzzzzzzzzzzzm_, "day");

                return kzzzzzzzzzzzzzzn_;
            };
            IEnumerable<ServiceRequest> kzzzzzzzzzzzzzzg_ = context.Operators.Where<ServiceRequest>(kzzzzzzzzzzzzzze_, kzzzzzzzzzzzzzzf_);
            Encounter kzzzzzzzzzzzzzzh_(ServiceRequest Referral) =>
                ElevatedEncounter;
            IEnumerable<Encounter> kzzzzzzzzzzzzzzi_ = context.Operators.Select<ServiceRequest, Encounter>(kzzzzzzzzzzzzzzg_, kzzzzzzzzzzzzzzh_);

            return kzzzzzzzzzzzzzzi_;
        };
        IEnumerable<Encounter> jzzzzzzzzzzzzzzi_ = context.Operators.SelectMany<Encounter, Encounter>(jzzzzzzzzzzzzzzb_, jzzzzzzzzzzzzzzh_);
        IEnumerable<Encounter> jzzzzzzzzzzzzzzj_ = context.Operators.Union<Encounter>(jzzzzzzzzzzzzzzf_, jzzzzzzzzzzzzzzi_);

        return jzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Encounter with Hypertensive Reading Within Year Prior")]
    public IEnumerable<Encounter> Encounter_with_Hypertensive_Reading_Within_Year_Prior(CqlContext context)
    {
        IEnumerable<Encounter> kzzzzzzzzzzzzzzo_ = this.Qualifying_Encounter_during_Measurement_Period(context);
        bool? kzzzzzzzzzzzzzzp_(Encounter QualifyingEncounter)
        {
            IEnumerable<Observation> kzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/bp"));
            bool? kzzzzzzzzzzzzzzs_(Observation BloodPressure)
            {
                DataType mzzzzzzzzzzzzzzy_ = BloodPressure?.Effective;
                object mzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzy_);
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.toInterval(context, mzzzzzzzzzzzzzzz_);
                CqlDateTime nzzzzzzzzzzzzzzb_ = context.Operators.End(nzzzzzzzzzzzzzza_);
                Period nzzzzzzzzzzzzzzc_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzzzzzzzzzzc_);
                CqlDateTime nzzzzzzzzzzzzzze_ = context.Operators.Start(nzzzzzzzzzzzzzzd_);
                CqlQuantity nzzzzzzzzzzzzzzf_ = context.Operators.Quantity(1m, "year");
                CqlDateTime nzzzzzzzzzzzzzzg_ = context.Operators.Subtract(nzzzzzzzzzzzzzze_, nzzzzzzzzzzzzzzf_);
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzzzzzzzzzzc_);
                CqlDateTime nzzzzzzzzzzzzzzj_ = context.Operators.Start(nzzzzzzzzzzzzzzi_);
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzk_ = context.Operators.Interval(nzzzzzzzzzzzzzzg_, nzzzzzzzzzzzzzzj_, true, true);
                bool? nzzzzzzzzzzzzzzl_ = context.Operators.In<CqlDateTime>(nzzzzzzzzzzzzzzb_, nzzzzzzzzzzzzzzk_, default);
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzzzzzzzzzzc_);
                CqlDateTime nzzzzzzzzzzzzzzo_ = context.Operators.Start(nzzzzzzzzzzzzzzn_);
                bool? nzzzzzzzzzzzzzzp_ = context.Operators.Not((bool?)(nzzzzzzzzzzzzzzo_ is null));
                bool? nzzzzzzzzzzzzzzq_ = context.Operators.And(nzzzzzzzzzzzzzzl_, nzzzzzzzzzzzzzzp_);
                Code<ObservationStatus> nzzzzzzzzzzzzzzr_ = BloodPressure?.StatusElement;
                ObservationStatus? nzzzzzzzzzzzzzzs_ = nzzzzzzzzzzzzzzr_?.Value;
                string nzzzzzzzzzzzzzzt_ = context.Operators.Convert<string>(nzzzzzzzzzzzzzzs_);
                string[] nzzzzzzzzzzzzzzu_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? nzzzzzzzzzzzzzzv_ = context.Operators.In<string>(nzzzzzzzzzzzzzzt_, nzzzzzzzzzzzzzzu_ as IEnumerable<string>);
                bool? nzzzzzzzzzzzzzzw_ = context.Operators.And(nzzzzzzzzzzzzzzq_, nzzzzzzzzzzzzzzv_);

                return nzzzzzzzzzzzzzzw_;
            };
            IEnumerable<Observation> kzzzzzzzzzzzzzzt_ = context.Operators.Where<Observation>(kzzzzzzzzzzzzzzr_, kzzzzzzzzzzzzzzs_);
            object kzzzzzzzzzzzzzzu_(Observation @this)
            {
                DataType nzzzzzzzzzzzzzzx_ = @this?.Effective;
                object nzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzx_);
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.toInterval(context, nzzzzzzzzzzzzzzy_);
                CqlDateTime ozzzzzzzzzzzzzza_ = context.Operators.Start(nzzzzzzzzzzzzzzz_);

                return ozzzzzzzzzzzzzza_;
            };
            IEnumerable<Observation> kzzzzzzzzzzzzzzv_ = context.Operators.SortBy<Observation>(kzzzzzzzzzzzzzzt_, kzzzzzzzzzzzzzzu_, System.ComponentModel.ListSortDirection.Ascending);
            Observation kzzzzzzzzzzzzzzw_ = context.Operators.Last<Observation>(kzzzzzzzzzzzzzzv_);
            List<Observation.ComponentComponent> kzzzzzzzzzzzzzzx_ = kzzzzzzzzzzzzzzw_?.Component;
            bool? kzzzzzzzzzzzzzzy_(Observation.ComponentComponent @this)
            {
                CodeableConcept ozzzzzzzzzzzzzzb_ = @this?.Code;
                List<Coding> ozzzzzzzzzzzzzzc_ = ozzzzzzzzzzzzzzb_?.Coding;
                Coding ozzzzzzzzzzzzzzd_ = context.Operators.First<Coding>((IEnumerable<Coding>)ozzzzzzzzzzzzzzc_);
                FhirUri ozzzzzzzzzzzzzze_ = ozzzzzzzzzzzzzzd_?.SystemElement;
                string ozzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToString(context, ozzzzzzzzzzzzzze_);
                bool? ozzzzzzzzzzzzzzg_ = context.Operators.Equal(ozzzzzzzzzzzzzzf_, "http://loinc.org");
                List<Coding> ozzzzzzzzzzzzzzi_ = ozzzzzzzzzzzzzzb_?.Coding;
                Coding ozzzzzzzzzzzzzzj_ = context.Operators.First<Coding>((IEnumerable<Coding>)ozzzzzzzzzzzzzzi_);
                Code ozzzzzzzzzzzzzzk_ = ozzzzzzzzzzzzzzj_?.CodeElement;
                string ozzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToString(context, ozzzzzzzzzzzzzzk_);
                bool? ozzzzzzzzzzzzzzm_ = context.Operators.Equal(ozzzzzzzzzzzzzzl_, "8480-6");
                bool? ozzzzzzzzzzzzzzn_ = context.Operators.And(ozzzzzzzzzzzzzzg_, ozzzzzzzzzzzzzzm_);

                return ozzzzzzzzzzzzzzn_;
            };
            IEnumerable<Observation.ComponentComponent> kzzzzzzzzzzzzzzz_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)kzzzzzzzzzzzzzzx_, kzzzzzzzzzzzzzzy_);
            Observation.ComponentComponent lzzzzzzzzzzzzzza_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(kzzzzzzzzzzzzzzz_);
            DataType lzzzzzzzzzzzzzzb_ = lzzzzzzzzzzzzzza_?.Value;
            object lzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzb_);
            CqlQuantity lzzzzzzzzzzzzzzd_ = context.Operators.Quantity(0m, "mm[Hg]");
            bool? lzzzzzzzzzzzzzze_ = context.Operators.Greater(lzzzzzzzzzzzzzzc_ as CqlQuantity, lzzzzzzzzzzzzzzd_);
            bool? lzzzzzzzzzzzzzzg_(Observation BloodPressure)
            {
                DataType ozzzzzzzzzzzzzzo_ = BloodPressure?.Effective;
                object ozzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzo_);
                CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.toInterval(context, ozzzzzzzzzzzzzzp_);
                CqlDateTime ozzzzzzzzzzzzzzr_ = context.Operators.End(ozzzzzzzzzzzzzzq_);
                Period ozzzzzzzzzzzzzzs_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzzzzzzzzzzs_);
                CqlDateTime ozzzzzzzzzzzzzzu_ = context.Operators.Start(ozzzzzzzzzzzzzzt_);
                CqlQuantity ozzzzzzzzzzzzzzv_ = context.Operators.Quantity(1m, "year");
                CqlDateTime ozzzzzzzzzzzzzzw_ = context.Operators.Subtract(ozzzzzzzzzzzzzzu_, ozzzzzzzzzzzzzzv_);
                CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzzzzzzzzzzs_);
                CqlDateTime ozzzzzzzzzzzzzzz_ = context.Operators.Start(ozzzzzzzzzzzzzzy_);
                CqlInterval<CqlDateTime> pzzzzzzzzzzzzzza_ = context.Operators.Interval(ozzzzzzzzzzzzzzw_, ozzzzzzzzzzzzzzz_, true, true);
                bool? pzzzzzzzzzzzzzzb_ = context.Operators.In<CqlDateTime>(ozzzzzzzzzzzzzzr_, pzzzzzzzzzzzzzza_, default);
                CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzzzzzzzzzzs_);
                CqlDateTime pzzzzzzzzzzzzzze_ = context.Operators.Start(pzzzzzzzzzzzzzzd_);
                bool? pzzzzzzzzzzzzzzf_ = context.Operators.Not((bool?)(pzzzzzzzzzzzzzze_ is null));
                bool? pzzzzzzzzzzzzzzg_ = context.Operators.And(pzzzzzzzzzzzzzzb_, pzzzzzzzzzzzzzzf_);
                Code<ObservationStatus> pzzzzzzzzzzzzzzh_ = BloodPressure?.StatusElement;
                ObservationStatus? pzzzzzzzzzzzzzzi_ = pzzzzzzzzzzzzzzh_?.Value;
                string pzzzzzzzzzzzzzzj_ = context.Operators.Convert<string>(pzzzzzzzzzzzzzzi_);
                string[] pzzzzzzzzzzzzzzk_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? pzzzzzzzzzzzzzzl_ = context.Operators.In<string>(pzzzzzzzzzzzzzzj_, pzzzzzzzzzzzzzzk_ as IEnumerable<string>);
                bool? pzzzzzzzzzzzzzzm_ = context.Operators.And(pzzzzzzzzzzzzzzg_, pzzzzzzzzzzzzzzl_);

                return pzzzzzzzzzzzzzzm_;
            };
            IEnumerable<Observation> lzzzzzzzzzzzzzzh_ = context.Operators.Where<Observation>(kzzzzzzzzzzzzzzr_, lzzzzzzzzzzzzzzg_);
            object lzzzzzzzzzzzzzzi_(Observation @this)
            {
                DataType pzzzzzzzzzzzzzzn_ = @this?.Effective;
                object pzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzn_);
                CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.toInterval(context, pzzzzzzzzzzzzzzo_);
                CqlDateTime pzzzzzzzzzzzzzzq_ = context.Operators.Start(pzzzzzzzzzzzzzzp_);

                return pzzzzzzzzzzzzzzq_;
            };
            IEnumerable<Observation> lzzzzzzzzzzzzzzj_ = context.Operators.SortBy<Observation>(lzzzzzzzzzzzzzzh_, lzzzzzzzzzzzzzzi_, System.ComponentModel.ListSortDirection.Ascending);
            Observation lzzzzzzzzzzzzzzk_ = context.Operators.Last<Observation>(lzzzzzzzzzzzzzzj_);
            List<Observation.ComponentComponent> lzzzzzzzzzzzzzzl_ = lzzzzzzzzzzzzzzk_?.Component;
            bool? lzzzzzzzzzzzzzzm_(Observation.ComponentComponent @this)
            {
                CodeableConcept pzzzzzzzzzzzzzzr_ = @this?.Code;
                List<Coding> pzzzzzzzzzzzzzzs_ = pzzzzzzzzzzzzzzr_?.Coding;
                Coding pzzzzzzzzzzzzzzt_ = context.Operators.First<Coding>((IEnumerable<Coding>)pzzzzzzzzzzzzzzs_);
                FhirUri pzzzzzzzzzzzzzzu_ = pzzzzzzzzzzzzzzt_?.SystemElement;
                string pzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToString(context, pzzzzzzzzzzzzzzu_);
                bool? pzzzzzzzzzzzzzzw_ = context.Operators.Equal(pzzzzzzzzzzzzzzv_, "http://loinc.org");
                List<Coding> pzzzzzzzzzzzzzzy_ = pzzzzzzzzzzzzzzr_?.Coding;
                Coding pzzzzzzzzzzzzzzz_ = context.Operators.First<Coding>((IEnumerable<Coding>)pzzzzzzzzzzzzzzy_);
                Code qzzzzzzzzzzzzzza_ = pzzzzzzzzzzzzzzz_?.CodeElement;
                string qzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToString(context, qzzzzzzzzzzzzzza_);
                bool? qzzzzzzzzzzzzzzc_ = context.Operators.Equal(qzzzzzzzzzzzzzzb_, "8462-4");
                bool? qzzzzzzzzzzzzzzd_ = context.Operators.And(pzzzzzzzzzzzzzzw_, qzzzzzzzzzzzzzzc_);

                return qzzzzzzzzzzzzzzd_;
            };
            IEnumerable<Observation.ComponentComponent> lzzzzzzzzzzzzzzn_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)lzzzzzzzzzzzzzzl_, lzzzzzzzzzzzzzzm_);
            Observation.ComponentComponent lzzzzzzzzzzzzzzo_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(lzzzzzzzzzzzzzzn_);
            DataType lzzzzzzzzzzzzzzp_ = lzzzzzzzzzzzzzzo_?.Value;
            object lzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzp_);
            bool? lzzzzzzzzzzzzzzs_ = context.Operators.Greater(lzzzzzzzzzzzzzzq_ as CqlQuantity, lzzzzzzzzzzzzzzd_);
            bool? lzzzzzzzzzzzzzzt_ = context.Operators.And(lzzzzzzzzzzzzzze_, lzzzzzzzzzzzzzzs_);
            bool? lzzzzzzzzzzzzzzv_(Observation BloodPressure)
            {
                DataType qzzzzzzzzzzzzzze_ = BloodPressure?.Effective;
                object qzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzze_);
                CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.toInterval(context, qzzzzzzzzzzzzzzf_);
                CqlDateTime qzzzzzzzzzzzzzzh_ = context.Operators.End(qzzzzzzzzzzzzzzg_);
                Period qzzzzzzzzzzzzzzi_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzzzzzzzzzzi_);
                CqlDateTime qzzzzzzzzzzzzzzk_ = context.Operators.Start(qzzzzzzzzzzzzzzj_);
                CqlQuantity qzzzzzzzzzzzzzzl_ = context.Operators.Quantity(1m, "year");
                CqlDateTime qzzzzzzzzzzzzzzm_ = context.Operators.Subtract(qzzzzzzzzzzzzzzk_, qzzzzzzzzzzzzzzl_);
                CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzzzzzzzzzzi_);
                CqlDateTime qzzzzzzzzzzzzzzp_ = context.Operators.Start(qzzzzzzzzzzzzzzo_);
                CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzq_ = context.Operators.Interval(qzzzzzzzzzzzzzzm_, qzzzzzzzzzzzzzzp_, true, true);
                bool? qzzzzzzzzzzzzzzr_ = context.Operators.In<CqlDateTime>(qzzzzzzzzzzzzzzh_, qzzzzzzzzzzzzzzq_, default);
                CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzzzzzzzzzzi_);
                CqlDateTime qzzzzzzzzzzzzzzu_ = context.Operators.Start(qzzzzzzzzzzzzzzt_);
                bool? qzzzzzzzzzzzzzzv_ = context.Operators.Not((bool?)(qzzzzzzzzzzzzzzu_ is null));
                bool? qzzzzzzzzzzzzzzw_ = context.Operators.And(qzzzzzzzzzzzzzzr_, qzzzzzzzzzzzzzzv_);
                Code<ObservationStatus> qzzzzzzzzzzzzzzx_ = BloodPressure?.StatusElement;
                ObservationStatus? qzzzzzzzzzzzzzzy_ = qzzzzzzzzzzzzzzx_?.Value;
                string qzzzzzzzzzzzzzzz_ = context.Operators.Convert<string>(qzzzzzzzzzzzzzzy_);
                string[] rzzzzzzzzzzzzzza_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? rzzzzzzzzzzzzzzb_ = context.Operators.In<string>(qzzzzzzzzzzzzzzz_, rzzzzzzzzzzzzzza_ as IEnumerable<string>);
                bool? rzzzzzzzzzzzzzzc_ = context.Operators.And(qzzzzzzzzzzzzzzw_, rzzzzzzzzzzzzzzb_);

                return rzzzzzzzzzzzzzzc_;
            };
            IEnumerable<Observation> lzzzzzzzzzzzzzzw_ = context.Operators.Where<Observation>(kzzzzzzzzzzzzzzr_, lzzzzzzzzzzzzzzv_);
            object lzzzzzzzzzzzzzzx_(Observation @this)
            {
                DataType rzzzzzzzzzzzzzzd_ = @this?.Effective;
                object rzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzd_);
                CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.toInterval(context, rzzzzzzzzzzzzzze_);
                CqlDateTime rzzzzzzzzzzzzzzg_ = context.Operators.Start(rzzzzzzzzzzzzzzf_);

                return rzzzzzzzzzzzzzzg_;
            };
            IEnumerable<Observation> lzzzzzzzzzzzzzzy_ = context.Operators.SortBy<Observation>(lzzzzzzzzzzzzzzw_, lzzzzzzzzzzzzzzx_, System.ComponentModel.ListSortDirection.Ascending);
            Observation lzzzzzzzzzzzzzzz_ = context.Operators.Last<Observation>(lzzzzzzzzzzzzzzy_);
            List<Observation.ComponentComponent> mzzzzzzzzzzzzzza_ = lzzzzzzzzzzzzzzz_?.Component;
            bool? mzzzzzzzzzzzzzzb_(Observation.ComponentComponent @this)
            {
                CodeableConcept rzzzzzzzzzzzzzzh_ = @this?.Code;
                List<Coding> rzzzzzzzzzzzzzzi_ = rzzzzzzzzzzzzzzh_?.Coding;
                Coding rzzzzzzzzzzzzzzj_ = context.Operators.First<Coding>((IEnumerable<Coding>)rzzzzzzzzzzzzzzi_);
                FhirUri rzzzzzzzzzzzzzzk_ = rzzzzzzzzzzzzzzj_?.SystemElement;
                string rzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToString(context, rzzzzzzzzzzzzzzk_);
                bool? rzzzzzzzzzzzzzzm_ = context.Operators.Equal(rzzzzzzzzzzzzzzl_, "http://loinc.org");
                List<Coding> rzzzzzzzzzzzzzzo_ = rzzzzzzzzzzzzzzh_?.Coding;
                Coding rzzzzzzzzzzzzzzp_ = context.Operators.First<Coding>((IEnumerable<Coding>)rzzzzzzzzzzzzzzo_);
                Code rzzzzzzzzzzzzzzq_ = rzzzzzzzzzzzzzzp_?.CodeElement;
                string rzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToString(context, rzzzzzzzzzzzzzzq_);
                bool? rzzzzzzzzzzzzzzs_ = context.Operators.Equal(rzzzzzzzzzzzzzzr_, "8480-6");
                bool? rzzzzzzzzzzzzzzt_ = context.Operators.And(rzzzzzzzzzzzzzzm_, rzzzzzzzzzzzzzzs_);

                return rzzzzzzzzzzzzzzt_;
            };
            IEnumerable<Observation.ComponentComponent> mzzzzzzzzzzzzzzc_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)mzzzzzzzzzzzzzza_, mzzzzzzzzzzzzzzb_);
            Observation.ComponentComponent mzzzzzzzzzzzzzzd_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(mzzzzzzzzzzzzzzc_);
            DataType mzzzzzzzzzzzzzze_ = mzzzzzzzzzzzzzzd_?.Value;
            object mzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzze_);
            CqlQuantity mzzzzzzzzzzzzzzg_ = context.Operators.Quantity(130m, "mm[Hg]");
            bool? mzzzzzzzzzzzzzzh_ = context.Operators.GreaterOrEqual(mzzzzzzzzzzzzzzf_ as CqlQuantity, mzzzzzzzzzzzzzzg_);
            bool? mzzzzzzzzzzzzzzj_(Observation BloodPressure)
            {
                DataType rzzzzzzzzzzzzzzu_ = BloodPressure?.Effective;
                object rzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzu_);
                CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.toInterval(context, rzzzzzzzzzzzzzzv_);
                CqlDateTime rzzzzzzzzzzzzzzx_ = context.Operators.End(rzzzzzzzzzzzzzzw_);
                Period rzzzzzzzzzzzzzzy_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzzzzzzzzzy_);
                CqlDateTime szzzzzzzzzzzzzza_ = context.Operators.Start(rzzzzzzzzzzzzzzz_);
                CqlQuantity szzzzzzzzzzzzzzb_ = context.Operators.Quantity(1m, "year");
                CqlDateTime szzzzzzzzzzzzzzc_ = context.Operators.Subtract(szzzzzzzzzzzzzza_, szzzzzzzzzzzzzzb_);
                CqlInterval<CqlDateTime> szzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzzzzzzzzzy_);
                CqlDateTime szzzzzzzzzzzzzzf_ = context.Operators.Start(szzzzzzzzzzzzzze_);
                CqlInterval<CqlDateTime> szzzzzzzzzzzzzzg_ = context.Operators.Interval(szzzzzzzzzzzzzzc_, szzzzzzzzzzzzzzf_, true, true);
                bool? szzzzzzzzzzzzzzh_ = context.Operators.In<CqlDateTime>(rzzzzzzzzzzzzzzx_, szzzzzzzzzzzzzzg_, default);
                CqlInterval<CqlDateTime> szzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzzzzzzzzzy_);
                CqlDateTime szzzzzzzzzzzzzzk_ = context.Operators.Start(szzzzzzzzzzzzzzj_);
                bool? szzzzzzzzzzzzzzl_ = context.Operators.Not((bool?)(szzzzzzzzzzzzzzk_ is null));
                bool? szzzzzzzzzzzzzzm_ = context.Operators.And(szzzzzzzzzzzzzzh_, szzzzzzzzzzzzzzl_);
                Code<ObservationStatus> szzzzzzzzzzzzzzn_ = BloodPressure?.StatusElement;
                ObservationStatus? szzzzzzzzzzzzzzo_ = szzzzzzzzzzzzzzn_?.Value;
                string szzzzzzzzzzzzzzp_ = context.Operators.Convert<string>(szzzzzzzzzzzzzzo_);
                string[] szzzzzzzzzzzzzzq_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? szzzzzzzzzzzzzzr_ = context.Operators.In<string>(szzzzzzzzzzzzzzp_, szzzzzzzzzzzzzzq_ as IEnumerable<string>);
                bool? szzzzzzzzzzzzzzs_ = context.Operators.And(szzzzzzzzzzzzzzm_, szzzzzzzzzzzzzzr_);

                return szzzzzzzzzzzzzzs_;
            };
            IEnumerable<Observation> mzzzzzzzzzzzzzzk_ = context.Operators.Where<Observation>(kzzzzzzzzzzzzzzr_, mzzzzzzzzzzzzzzj_);
            object mzzzzzzzzzzzzzzl_(Observation @this)
            {
                DataType szzzzzzzzzzzzzzt_ = @this?.Effective;
                object szzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzt_);
                CqlInterval<CqlDateTime> szzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.toInterval(context, szzzzzzzzzzzzzzu_);
                CqlDateTime szzzzzzzzzzzzzzw_ = context.Operators.Start(szzzzzzzzzzzzzzv_);

                return szzzzzzzzzzzzzzw_;
            };
            IEnumerable<Observation> mzzzzzzzzzzzzzzm_ = context.Operators.SortBy<Observation>(mzzzzzzzzzzzzzzk_, mzzzzzzzzzzzzzzl_, System.ComponentModel.ListSortDirection.Ascending);
            Observation mzzzzzzzzzzzzzzn_ = context.Operators.Last<Observation>(mzzzzzzzzzzzzzzm_);
            List<Observation.ComponentComponent> mzzzzzzzzzzzzzzo_ = mzzzzzzzzzzzzzzn_?.Component;
            bool? mzzzzzzzzzzzzzzp_(Observation.ComponentComponent @this)
            {
                CodeableConcept szzzzzzzzzzzzzzx_ = @this?.Code;
                List<Coding> szzzzzzzzzzzzzzy_ = szzzzzzzzzzzzzzx_?.Coding;
                Coding szzzzzzzzzzzzzzz_ = context.Operators.First<Coding>((IEnumerable<Coding>)szzzzzzzzzzzzzzy_);
                FhirUri tzzzzzzzzzzzzzza_ = szzzzzzzzzzzzzzz_?.SystemElement;
                string tzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToString(context, tzzzzzzzzzzzzzza_);
                bool? tzzzzzzzzzzzzzzc_ = context.Operators.Equal(tzzzzzzzzzzzzzzb_, "http://loinc.org");
                List<Coding> tzzzzzzzzzzzzzze_ = szzzzzzzzzzzzzzx_?.Coding;
                Coding tzzzzzzzzzzzzzzf_ = context.Operators.First<Coding>((IEnumerable<Coding>)tzzzzzzzzzzzzzze_);
                Code tzzzzzzzzzzzzzzg_ = tzzzzzzzzzzzzzzf_?.CodeElement;
                string tzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToString(context, tzzzzzzzzzzzzzzg_);
                bool? tzzzzzzzzzzzzzzi_ = context.Operators.Equal(tzzzzzzzzzzzzzzh_, "8462-4");
                bool? tzzzzzzzzzzzzzzj_ = context.Operators.And(tzzzzzzzzzzzzzzc_, tzzzzzzzzzzzzzzi_);

                return tzzzzzzzzzzzzzzj_;
            };
            IEnumerable<Observation.ComponentComponent> mzzzzzzzzzzzzzzq_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)mzzzzzzzzzzzzzzo_, mzzzzzzzzzzzzzzp_);
            Observation.ComponentComponent mzzzzzzzzzzzzzzr_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(mzzzzzzzzzzzzzzq_);
            DataType mzzzzzzzzzzzzzzs_ = mzzzzzzzzzzzzzzr_?.Value;
            object mzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzs_);
            CqlQuantity mzzzzzzzzzzzzzzu_ = context.Operators.Quantity(80m, "mm[Hg]");
            bool? mzzzzzzzzzzzzzzv_ = context.Operators.GreaterOrEqual(mzzzzzzzzzzzzzzt_ as CqlQuantity, mzzzzzzzzzzzzzzu_);
            bool? mzzzzzzzzzzzzzzw_ = context.Operators.Or(mzzzzzzzzzzzzzzh_, mzzzzzzzzzzzzzzv_);
            bool? mzzzzzzzzzzzzzzx_ = context.Operators.And(lzzzzzzzzzzzzzzt_, mzzzzzzzzzzzzzzw_);

            return mzzzzzzzzzzzzzzx_;
        };
        IEnumerable<Encounter> kzzzzzzzzzzzzzzq_ = context.Operators.Where<Encounter>(kzzzzzzzzzzzzzzo_, kzzzzzzzzzzzzzzp_);

        return kzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Encounter with First Hypertensive Reading SBP Greater than or Equal to 130 OR DBP Greater than or Equal to 80")]
    public IEnumerable<Encounter> Encounter_with_First_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_130_OR_DBP_Greater_than_or_Equal_to_80(CqlContext context)
    {
        IEnumerable<Encounter> tzzzzzzzzzzzzzzk_ = this.Qualifying_Encounter_during_Measurement_Period(context);
        bool? tzzzzzzzzzzzzzzl_(Encounter QualifyingEncounter)
        {
            IEnumerable<Observation> tzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/bp"));
            bool? tzzzzzzzzzzzzzzq_(Observation BloodPressure)
            {
                DataType vzzzzzzzzzzzzzzw_ = BloodPressure?.Effective;
                object vzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzw_);
                CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.toInterval(context, vzzzzzzzzzzzzzzx_);
                CqlDateTime vzzzzzzzzzzzzzzz_ = context.Operators.End(vzzzzzzzzzzzzzzy_);
                Period wzzzzzzzzzzzzzza_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzzzzzzzzzza_);
                bool? wzzzzzzzzzzzzzzc_ = context.Operators.In<CqlDateTime>(vzzzzzzzzzzzzzzz_, wzzzzzzzzzzzzzzb_, "day");

                return wzzzzzzzzzzzzzzc_;
            };
            IEnumerable<Observation> tzzzzzzzzzzzzzzr_ = context.Operators.Where<Observation>(tzzzzzzzzzzzzzzp_, tzzzzzzzzzzzzzzq_);
            object tzzzzzzzzzzzzzzs_(Observation @this)
            {
                DataType wzzzzzzzzzzzzzzd_ = @this?.Effective;
                object wzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzd_);
                CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.toInterval(context, wzzzzzzzzzzzzzze_);
                CqlDateTime wzzzzzzzzzzzzzzg_ = context.Operators.Start(wzzzzzzzzzzzzzzf_);

                return wzzzzzzzzzzzzzzg_;
            };
            IEnumerable<Observation> tzzzzzzzzzzzzzzt_ = context.Operators.SortBy<Observation>(tzzzzzzzzzzzzzzr_, tzzzzzzzzzzzzzzs_, System.ComponentModel.ListSortDirection.Ascending);
            Observation tzzzzzzzzzzzzzzu_ = context.Operators.Last<Observation>(tzzzzzzzzzzzzzzt_);
            List<Observation.ComponentComponent> tzzzzzzzzzzzzzzv_ = tzzzzzzzzzzzzzzu_?.Component;
            bool? tzzzzzzzzzzzzzzw_(Observation.ComponentComponent @this)
            {
                CodeableConcept wzzzzzzzzzzzzzzh_ = @this?.Code;
                List<Coding> wzzzzzzzzzzzzzzi_ = wzzzzzzzzzzzzzzh_?.Coding;
                Coding wzzzzzzzzzzzzzzj_ = context.Operators.First<Coding>((IEnumerable<Coding>)wzzzzzzzzzzzzzzi_);
                FhirUri wzzzzzzzzzzzzzzk_ = wzzzzzzzzzzzzzzj_?.SystemElement;
                string wzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToString(context, wzzzzzzzzzzzzzzk_);
                bool? wzzzzzzzzzzzzzzm_ = context.Operators.Equal(wzzzzzzzzzzzzzzl_, "http://loinc.org");
                List<Coding> wzzzzzzzzzzzzzzo_ = wzzzzzzzzzzzzzzh_?.Coding;
                Coding wzzzzzzzzzzzzzzp_ = context.Operators.First<Coding>((IEnumerable<Coding>)wzzzzzzzzzzzzzzo_);
                Code wzzzzzzzzzzzzzzq_ = wzzzzzzzzzzzzzzp_?.CodeElement;
                string wzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToString(context, wzzzzzzzzzzzzzzq_);
                bool? wzzzzzzzzzzzzzzs_ = context.Operators.Equal(wzzzzzzzzzzzzzzr_, "8480-6");
                bool? wzzzzzzzzzzzzzzt_ = context.Operators.And(wzzzzzzzzzzzzzzm_, wzzzzzzzzzzzzzzs_);

                return wzzzzzzzzzzzzzzt_;
            };
            IEnumerable<Observation.ComponentComponent> tzzzzzzzzzzzzzzx_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)tzzzzzzzzzzzzzzv_, tzzzzzzzzzzzzzzw_);
            Observation.ComponentComponent tzzzzzzzzzzzzzzy_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(tzzzzzzzzzzzzzzx_);
            DataType tzzzzzzzzzzzzzzz_ = tzzzzzzzzzzzzzzy_?.Value;
            object uzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzz_);
            CqlQuantity uzzzzzzzzzzzzzzb_ = context.Operators.Quantity(0m, "mm[Hg]");
            bool? uzzzzzzzzzzzzzzc_ = context.Operators.Greater(uzzzzzzzzzzzzzza_ as CqlQuantity, uzzzzzzzzzzzzzzb_);
            bool? uzzzzzzzzzzzzzze_(Observation BloodPressure)
            {
                DataType wzzzzzzzzzzzzzzu_ = BloodPressure?.Effective;
                object wzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzu_);
                CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.toInterval(context, wzzzzzzzzzzzzzzv_);
                CqlDateTime wzzzzzzzzzzzzzzx_ = context.Operators.End(wzzzzzzzzzzzzzzw_);
                Period wzzzzzzzzzzzzzzy_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzzzzzzzzzzy_);
                bool? xzzzzzzzzzzzzzza_ = context.Operators.In<CqlDateTime>(wzzzzzzzzzzzzzzx_, wzzzzzzzzzzzzzzz_, "day");

                return xzzzzzzzzzzzzzza_;
            };
            IEnumerable<Observation> uzzzzzzzzzzzzzzf_ = context.Operators.Where<Observation>(tzzzzzzzzzzzzzzp_, uzzzzzzzzzzzzzze_);
            object uzzzzzzzzzzzzzzg_(Observation @this)
            {
                DataType xzzzzzzzzzzzzzzb_ = @this?.Effective;
                object xzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzb_);
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.toInterval(context, xzzzzzzzzzzzzzzc_);
                CqlDateTime xzzzzzzzzzzzzzze_ = context.Operators.Start(xzzzzzzzzzzzzzzd_);

                return xzzzzzzzzzzzzzze_;
            };
            IEnumerable<Observation> uzzzzzzzzzzzzzzh_ = context.Operators.SortBy<Observation>(uzzzzzzzzzzzzzzf_, uzzzzzzzzzzzzzzg_, System.ComponentModel.ListSortDirection.Ascending);
            Observation uzzzzzzzzzzzzzzi_ = context.Operators.Last<Observation>(uzzzzzzzzzzzzzzh_);
            List<Observation.ComponentComponent> uzzzzzzzzzzzzzzj_ = uzzzzzzzzzzzzzzi_?.Component;
            bool? uzzzzzzzzzzzzzzk_(Observation.ComponentComponent @this)
            {
                CodeableConcept xzzzzzzzzzzzzzzf_ = @this?.Code;
                List<Coding> xzzzzzzzzzzzzzzg_ = xzzzzzzzzzzzzzzf_?.Coding;
                Coding xzzzzzzzzzzzzzzh_ = context.Operators.First<Coding>((IEnumerable<Coding>)xzzzzzzzzzzzzzzg_);
                FhirUri xzzzzzzzzzzzzzzi_ = xzzzzzzzzzzzzzzh_?.SystemElement;
                string xzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToString(context, xzzzzzzzzzzzzzzi_);
                bool? xzzzzzzzzzzzzzzk_ = context.Operators.Equal(xzzzzzzzzzzzzzzj_, "http://loinc.org");
                List<Coding> xzzzzzzzzzzzzzzm_ = xzzzzzzzzzzzzzzf_?.Coding;
                Coding xzzzzzzzzzzzzzzn_ = context.Operators.First<Coding>((IEnumerable<Coding>)xzzzzzzzzzzzzzzm_);
                Code xzzzzzzzzzzzzzzo_ = xzzzzzzzzzzzzzzn_?.CodeElement;
                string xzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToString(context, xzzzzzzzzzzzzzzo_);
                bool? xzzzzzzzzzzzzzzq_ = context.Operators.Equal(xzzzzzzzzzzzzzzp_, "8462-4");
                bool? xzzzzzzzzzzzzzzr_ = context.Operators.And(xzzzzzzzzzzzzzzk_, xzzzzzzzzzzzzzzq_);

                return xzzzzzzzzzzzzzzr_;
            };
            IEnumerable<Observation.ComponentComponent> uzzzzzzzzzzzzzzl_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)uzzzzzzzzzzzzzzj_, uzzzzzzzzzzzzzzk_);
            Observation.ComponentComponent uzzzzzzzzzzzzzzm_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(uzzzzzzzzzzzzzzl_);
            DataType uzzzzzzzzzzzzzzn_ = uzzzzzzzzzzzzzzm_?.Value;
            object uzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzn_);
            bool? uzzzzzzzzzzzzzzq_ = context.Operators.Greater(uzzzzzzzzzzzzzzo_ as CqlQuantity, uzzzzzzzzzzzzzzb_);
            bool? uzzzzzzzzzzzzzzr_ = context.Operators.And(uzzzzzzzzzzzzzzc_, uzzzzzzzzzzzzzzq_);
            bool? uzzzzzzzzzzzzzzt_(Observation BloodPressure)
            {
                DataType xzzzzzzzzzzzzzzs_ = BloodPressure?.Effective;
                object xzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzs_);
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.toInterval(context, xzzzzzzzzzzzzzzt_);
                CqlDateTime xzzzzzzzzzzzzzzv_ = context.Operators.End(xzzzzzzzzzzzzzzu_);
                Period xzzzzzzzzzzzzzzw_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzzzzzzzzzw_);
                bool? xzzzzzzzzzzzzzzy_ = context.Operators.In<CqlDateTime>(xzzzzzzzzzzzzzzv_, xzzzzzzzzzzzzzzx_, "day");

                return xzzzzzzzzzzzzzzy_;
            };
            IEnumerable<Observation> uzzzzzzzzzzzzzzu_ = context.Operators.Where<Observation>(tzzzzzzzzzzzzzzp_, uzzzzzzzzzzzzzzt_);
            object uzzzzzzzzzzzzzzv_(Observation @this)
            {
                DataType xzzzzzzzzzzzzzzz_ = @this?.Effective;
                object yzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzz_);
                CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.toInterval(context, yzzzzzzzzzzzzzza_);
                CqlDateTime yzzzzzzzzzzzzzzc_ = context.Operators.Start(yzzzzzzzzzzzzzzb_);

                return yzzzzzzzzzzzzzzc_;
            };
            IEnumerable<Observation> uzzzzzzzzzzzzzzw_ = context.Operators.SortBy<Observation>(uzzzzzzzzzzzzzzu_, uzzzzzzzzzzzzzzv_, System.ComponentModel.ListSortDirection.Ascending);
            Observation uzzzzzzzzzzzzzzx_ = context.Operators.Last<Observation>(uzzzzzzzzzzzzzzw_);
            List<Observation.ComponentComponent> uzzzzzzzzzzzzzzy_ = uzzzzzzzzzzzzzzx_?.Component;
            bool? uzzzzzzzzzzzzzzz_(Observation.ComponentComponent @this)
            {
                CodeableConcept yzzzzzzzzzzzzzzd_ = @this?.Code;
                List<Coding> yzzzzzzzzzzzzzze_ = yzzzzzzzzzzzzzzd_?.Coding;
                Coding yzzzzzzzzzzzzzzf_ = context.Operators.First<Coding>((IEnumerable<Coding>)yzzzzzzzzzzzzzze_);
                FhirUri yzzzzzzzzzzzzzzg_ = yzzzzzzzzzzzzzzf_?.SystemElement;
                string yzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToString(context, yzzzzzzzzzzzzzzg_);
                bool? yzzzzzzzzzzzzzzi_ = context.Operators.Equal(yzzzzzzzzzzzzzzh_, "http://loinc.org");
                List<Coding> yzzzzzzzzzzzzzzk_ = yzzzzzzzzzzzzzzd_?.Coding;
                Coding yzzzzzzzzzzzzzzl_ = context.Operators.First<Coding>((IEnumerable<Coding>)yzzzzzzzzzzzzzzk_);
                Code yzzzzzzzzzzzzzzm_ = yzzzzzzzzzzzzzzl_?.CodeElement;
                string yzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToString(context, yzzzzzzzzzzzzzzm_);
                bool? yzzzzzzzzzzzzzzo_ = context.Operators.Equal(yzzzzzzzzzzzzzzn_, "8480-6");
                bool? yzzzzzzzzzzzzzzp_ = context.Operators.And(yzzzzzzzzzzzzzzi_, yzzzzzzzzzzzzzzo_);

                return yzzzzzzzzzzzzzzp_;
            };
            IEnumerable<Observation.ComponentComponent> vzzzzzzzzzzzzzza_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)uzzzzzzzzzzzzzzy_, uzzzzzzzzzzzzzzz_);
            Observation.ComponentComponent vzzzzzzzzzzzzzzb_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(vzzzzzzzzzzzzzza_);
            DataType vzzzzzzzzzzzzzzc_ = vzzzzzzzzzzzzzzb_?.Value;
            object vzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzc_);
            CqlQuantity vzzzzzzzzzzzzzze_ = context.Operators.Quantity(130m, "mm[Hg]");
            bool? vzzzzzzzzzzzzzzf_ = context.Operators.GreaterOrEqual(vzzzzzzzzzzzzzzd_ as CqlQuantity, vzzzzzzzzzzzzzze_);
            bool? vzzzzzzzzzzzzzzh_(Observation BloodPressure)
            {
                DataType yzzzzzzzzzzzzzzq_ = BloodPressure?.Effective;
                object yzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzq_);
                CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.toInterval(context, yzzzzzzzzzzzzzzr_);
                CqlDateTime yzzzzzzzzzzzzzzt_ = context.Operators.End(yzzzzzzzzzzzzzzs_);
                Period yzzzzzzzzzzzzzzu_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzzzzzzzzzzzu_);
                bool? yzzzzzzzzzzzzzzw_ = context.Operators.In<CqlDateTime>(yzzzzzzzzzzzzzzt_, yzzzzzzzzzzzzzzv_, "day");

                return yzzzzzzzzzzzzzzw_;
            };
            IEnumerable<Observation> vzzzzzzzzzzzzzzi_ = context.Operators.Where<Observation>(tzzzzzzzzzzzzzzp_, vzzzzzzzzzzzzzzh_);
            object vzzzzzzzzzzzzzzj_(Observation @this)
            {
                DataType yzzzzzzzzzzzzzzx_ = @this?.Effective;
                object yzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzx_);
                CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.toInterval(context, yzzzzzzzzzzzzzzy_);
                CqlDateTime zzzzzzzzzzzzzzza_ = context.Operators.Start(yzzzzzzzzzzzzzzz_);

                return zzzzzzzzzzzzzzza_;
            };
            IEnumerable<Observation> vzzzzzzzzzzzzzzk_ = context.Operators.SortBy<Observation>(vzzzzzzzzzzzzzzi_, vzzzzzzzzzzzzzzj_, System.ComponentModel.ListSortDirection.Ascending);
            Observation vzzzzzzzzzzzzzzl_ = context.Operators.Last<Observation>(vzzzzzzzzzzzzzzk_);
            List<Observation.ComponentComponent> vzzzzzzzzzzzzzzm_ = vzzzzzzzzzzzzzzl_?.Component;
            bool? vzzzzzzzzzzzzzzn_(Observation.ComponentComponent @this)
            {
                CodeableConcept zzzzzzzzzzzzzzzb_ = @this?.Code;
                List<Coding> zzzzzzzzzzzzzzzc_ = zzzzzzzzzzzzzzzb_?.Coding;
                Coding zzzzzzzzzzzzzzzd_ = context.Operators.First<Coding>((IEnumerable<Coding>)zzzzzzzzzzzzzzzc_);
                FhirUri zzzzzzzzzzzzzzze_ = zzzzzzzzzzzzzzzd_?.SystemElement;
                string zzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToString(context, zzzzzzzzzzzzzzze_);
                bool? zzzzzzzzzzzzzzzg_ = context.Operators.Equal(zzzzzzzzzzzzzzzf_, "http://loinc.org");
                List<Coding> zzzzzzzzzzzzzzzi_ = zzzzzzzzzzzzzzzb_?.Coding;
                Coding zzzzzzzzzzzzzzzj_ = context.Operators.First<Coding>((IEnumerable<Coding>)zzzzzzzzzzzzzzzi_);
                Code zzzzzzzzzzzzzzzk_ = zzzzzzzzzzzzzzzj_?.CodeElement;
                string zzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToString(context, zzzzzzzzzzzzzzzk_);
                bool? zzzzzzzzzzzzzzzm_ = context.Operators.Equal(zzzzzzzzzzzzzzzl_, "8462-4");
                bool? zzzzzzzzzzzzzzzn_ = context.Operators.And(zzzzzzzzzzzzzzzg_, zzzzzzzzzzzzzzzm_);

                return zzzzzzzzzzzzzzzn_;
            };
            IEnumerable<Observation.ComponentComponent> vzzzzzzzzzzzzzzo_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)vzzzzzzzzzzzzzzm_, vzzzzzzzzzzzzzzn_);
            Observation.ComponentComponent vzzzzzzzzzzzzzzp_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(vzzzzzzzzzzzzzzo_);
            DataType vzzzzzzzzzzzzzzq_ = vzzzzzzzzzzzzzzp_?.Value;
            object vzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzq_);
            CqlQuantity vzzzzzzzzzzzzzzs_ = context.Operators.Quantity(80m, "mm[Hg]");
            bool? vzzzzzzzzzzzzzzt_ = context.Operators.GreaterOrEqual(vzzzzzzzzzzzzzzr_ as CqlQuantity, vzzzzzzzzzzzzzzs_);
            bool? vzzzzzzzzzzzzzzu_ = context.Operators.Or(vzzzzzzzzzzzzzzf_, vzzzzzzzzzzzzzzt_);
            bool? vzzzzzzzzzzzzzzv_ = context.Operators.And(uzzzzzzzzzzzzzzr_, vzzzzzzzzzzzzzzu_);

            return vzzzzzzzzzzzzzzv_;
        };
        IEnumerable<Encounter> tzzzzzzzzzzzzzzm_ = context.Operators.Where<Encounter>(tzzzzzzzzzzzzzzk_, tzzzzzzzzzzzzzzl_);
        IEnumerable<Encounter> tzzzzzzzzzzzzzzn_ = this.Encounter_with_Hypertensive_Reading_Within_Year_Prior(context);
        IEnumerable<Encounter> tzzzzzzzzzzzzzzo_ = context.Operators.Except<Encounter>(tzzzzzzzzzzzzzzm_, tzzzzzzzzzzzzzzn_);

        return tzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("First Hypertensive Reading Interventions or Referral to Alternate Professional")]
    public IEnumerable<ServiceRequest> First_Hypertensive_Reading_Interventions_or_Referral_to_Alternate_Professional(CqlContext context)
    {
        CqlValueSet zzzzzzzzzzzzzzzo_ = this.Follow_Up_Within_4_Weeks(context);
        IEnumerable<ServiceRequest> zzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, zzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> zzzzzzzzzzzzzzzq_(ServiceRequest FourWeekRescreen)
        {
            IEnumerable<ServiceRequest> zzzzzzzzzzzzzzzu_ = this.NonPharmacological_Interventions(context);
            bool? zzzzzzzzzzzzzzzv_(ServiceRequest NonPharmInterventionsHTN)
            {
                FhirDateTime zzzzzzzzzzzzzzzz_ = FourWeekRescreen?.AuthoredOnElement;
                CqlDateTime azzzzzzzzzzzzzzza_ = context.Operators.Convert<CqlDateTime>(zzzzzzzzzzzzzzzz_);
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzb_ = this.Measurement_Period(context);
                bool? azzzzzzzzzzzzzzzc_ = context.Operators.In<CqlDateTime>(azzzzzzzzzzzzzzza_, azzzzzzzzzzzzzzzb_, "day");
                FhirDateTime azzzzzzzzzzzzzzzd_ = NonPharmInterventionsHTN?.AuthoredOnElement;
                CqlDateTime azzzzzzzzzzzzzzze_ = context.Operators.Convert<CqlDateTime>(azzzzzzzzzzzzzzzd_);
                bool? azzzzzzzzzzzzzzzg_ = context.Operators.In<CqlDateTime>(azzzzzzzzzzzzzzze_, azzzzzzzzzzzzzzzb_, "day");
                bool? azzzzzzzzzzzzzzzh_ = context.Operators.And(azzzzzzzzzzzzzzzc_, azzzzzzzzzzzzzzzg_);
                Code<RequestIntent> azzzzzzzzzzzzzzzi_ = FourWeekRescreen?.IntentElement;
                RequestIntent? azzzzzzzzzzzzzzzj_ = azzzzzzzzzzzzzzzi_?.Value;
                Code<RequestIntent> azzzzzzzzzzzzzzzk_ = context.Operators.Convert<Code<RequestIntent>>(azzzzzzzzzzzzzzzj_);
                bool? azzzzzzzzzzzzzzzl_ = context.Operators.Equivalent(azzzzzzzzzzzzzzzk_, "order");
                bool? azzzzzzzzzzzzzzzm_ = context.Operators.And(azzzzzzzzzzzzzzzh_, azzzzzzzzzzzzzzzl_);

                return azzzzzzzzzzzzzzzm_;
            };
            IEnumerable<ServiceRequest> zzzzzzzzzzzzzzzw_ = context.Operators.Where<ServiceRequest>(zzzzzzzzzzzzzzzu_, zzzzzzzzzzzzzzzv_);
            ServiceRequest zzzzzzzzzzzzzzzx_(ServiceRequest NonPharmInterventionsHTN) =>
                FourWeekRescreen;
            IEnumerable<ServiceRequest> zzzzzzzzzzzzzzzy_ = context.Operators.Select<ServiceRequest, ServiceRequest>(zzzzzzzzzzzzzzzw_, zzzzzzzzzzzzzzzx_);

            return zzzzzzzzzzzzzzzy_;
        };
        IEnumerable<ServiceRequest> zzzzzzzzzzzzzzzr_ = context.Operators.SelectMany<ServiceRequest, ServiceRequest>(zzzzzzzzzzzzzzzp_, zzzzzzzzzzzzzzzq_);
        IEnumerable<ServiceRequest> zzzzzzzzzzzzzzzs_ = this.Referral_to_Alternate_or_Primary_Healthcare_Professional_for_Hypertensive_Reading(context);
        IEnumerable<ServiceRequest> zzzzzzzzzzzzzzzt_ = context.Operators.Union<ServiceRequest>(zzzzzzzzzzzzzzzr_, zzzzzzzzzzzzzzzs_);

        return zzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Encounter with First Hypertensive Reading SBP Greater than or Equal to 130 OR DBP Greater than or Equal to 80 and Interventions")]
    public IEnumerable<Encounter> Encounter_with_First_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_130_OR_DBP_Greater_than_or_Equal_to_80_and_Interventions(CqlContext context)
    {
        IEnumerable<Encounter> azzzzzzzzzzzzzzzn_ = this.Encounter_with_First_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_130_OR_DBP_Greater_than_or_Equal_to_80(context);
        IEnumerable<Encounter> azzzzzzzzzzzzzzzo_(Encounter FirstHTNEncounter)
        {
            IEnumerable<ServiceRequest> azzzzzzzzzzzzzzzq_ = this.First_Hypertensive_Reading_Interventions_or_Referral_to_Alternate_Professional(context);
            bool? azzzzzzzzzzzzzzzr_(ServiceRequest FirstHTNIntervention)
            {
                FhirDateTime azzzzzzzzzzzzzzzv_ = FirstHTNIntervention?.AuthoredOnElement;
                CqlDateTime azzzzzzzzzzzzzzzw_ = context.Operators.Convert<CqlDateTime>(azzzzzzzzzzzzzzzv_);
                Period azzzzzzzzzzzzzzzx_ = FirstHTNEncounter?.Period;
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzzzzzzzzzx_);
                bool? azzzzzzzzzzzzzzzz_ = context.Operators.In<CqlDateTime>(azzzzzzzzzzzzzzzw_, azzzzzzzzzzzzzzzy_, "day");

                return azzzzzzzzzzzzzzzz_;
            };
            IEnumerable<ServiceRequest> azzzzzzzzzzzzzzzs_ = context.Operators.Where<ServiceRequest>(azzzzzzzzzzzzzzzq_, azzzzzzzzzzzzzzzr_);
            Encounter azzzzzzzzzzzzzzzt_(ServiceRequest FirstHTNIntervention) =>
                FirstHTNEncounter;
            IEnumerable<Encounter> azzzzzzzzzzzzzzzu_ = context.Operators.Select<ServiceRequest, Encounter>(azzzzzzzzzzzzzzzs_, azzzzzzzzzzzzzzzt_);

            return azzzzzzzzzzzzzzzu_;
        };
        IEnumerable<Encounter> azzzzzzzzzzzzzzzp_ = context.Operators.SelectMany<Encounter, Encounter>(azzzzzzzzzzzzzzzn_, azzzzzzzzzzzzzzzo_);

        return azzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Encounter with Second Hypertensive Reading SBP 130 to 139 OR DBP 80 to 89")]
    public IEnumerable<Encounter> Encounter_with_Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89(CqlContext context)
    {
        IEnumerable<Encounter> bzzzzzzzzzzzzzzza_ = this.Qualifying_Encounter_during_Measurement_Period(context);
        bool? bzzzzzzzzzzzzzzzb_(Encounter QualifyingEncounter)
        {
            IEnumerable<Observation> bzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/bp"));
            bool? bzzzzzzzzzzzzzzze_(Observation BloodPressure)
            {
                DataType dzzzzzzzzzzzzzzzs_ = BloodPressure?.Effective;
                object dzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzs_);
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.toInterval(context, dzzzzzzzzzzzzzzzt_);
                CqlDateTime dzzzzzzzzzzzzzzzv_ = context.Operators.End(dzzzzzzzzzzzzzzzu_);
                Period dzzzzzzzzzzzzzzzw_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzzzzzzzzzzzzw_);
                bool? dzzzzzzzzzzzzzzzy_ = context.Operators.In<CqlDateTime>(dzzzzzzzzzzzzzzzv_, dzzzzzzzzzzzzzzzx_, "day");
                Code<ObservationStatus> dzzzzzzzzzzzzzzzz_ = BloodPressure?.StatusElement;
                ObservationStatus? ezzzzzzzzzzzzzzza_ = dzzzzzzzzzzzzzzzz_?.Value;
                string ezzzzzzzzzzzzzzzb_ = context.Operators.Convert<string>(ezzzzzzzzzzzzzzza_);
                string[] ezzzzzzzzzzzzzzzc_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? ezzzzzzzzzzzzzzzd_ = context.Operators.In<string>(ezzzzzzzzzzzzzzzb_, ezzzzzzzzzzzzzzzc_ as IEnumerable<string>);
                bool? ezzzzzzzzzzzzzzze_ = context.Operators.And(dzzzzzzzzzzzzzzzy_, ezzzzzzzzzzzzzzzd_);

                return ezzzzzzzzzzzzzzze_;
            };
            IEnumerable<Observation> bzzzzzzzzzzzzzzzf_ = context.Operators.Where<Observation>(bzzzzzzzzzzzzzzzd_, bzzzzzzzzzzzzzzze_);
            object bzzzzzzzzzzzzzzzg_(Observation @this)
            {
                DataType ezzzzzzzzzzzzzzzf_ = @this?.Effective;
                object ezzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzf_);
                CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.toInterval(context, ezzzzzzzzzzzzzzzg_);
                CqlDateTime ezzzzzzzzzzzzzzzi_ = context.Operators.Start(ezzzzzzzzzzzzzzzh_);

                return ezzzzzzzzzzzzzzzi_;
            };
            IEnumerable<Observation> bzzzzzzzzzzzzzzzh_ = context.Operators.SortBy<Observation>(bzzzzzzzzzzzzzzzf_, bzzzzzzzzzzzzzzzg_, System.ComponentModel.ListSortDirection.Ascending);
            Observation bzzzzzzzzzzzzzzzi_ = context.Operators.Last<Observation>(bzzzzzzzzzzzzzzzh_);
            List<Observation.ComponentComponent> bzzzzzzzzzzzzzzzj_ = bzzzzzzzzzzzzzzzi_?.Component;
            bool? bzzzzzzzzzzzzzzzk_(Observation.ComponentComponent @this)
            {
                CodeableConcept ezzzzzzzzzzzzzzzj_ = @this?.Code;
                List<Coding> ezzzzzzzzzzzzzzzk_ = ezzzzzzzzzzzzzzzj_?.Coding;
                Coding ezzzzzzzzzzzzzzzl_ = context.Operators.First<Coding>((IEnumerable<Coding>)ezzzzzzzzzzzzzzzk_);
                FhirUri ezzzzzzzzzzzzzzzm_ = ezzzzzzzzzzzzzzzl_?.SystemElement;
                string ezzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToString(context, ezzzzzzzzzzzzzzzm_);
                bool? ezzzzzzzzzzzzzzzo_ = context.Operators.Equal(ezzzzzzzzzzzzzzzn_, "http://loinc.org");
                List<Coding> ezzzzzzzzzzzzzzzq_ = ezzzzzzzzzzzzzzzj_?.Coding;
                Coding ezzzzzzzzzzzzzzzr_ = context.Operators.First<Coding>((IEnumerable<Coding>)ezzzzzzzzzzzzzzzq_);
                Code ezzzzzzzzzzzzzzzs_ = ezzzzzzzzzzzzzzzr_?.CodeElement;
                string ezzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToString(context, ezzzzzzzzzzzzzzzs_);
                bool? ezzzzzzzzzzzzzzzu_ = context.Operators.Equal(ezzzzzzzzzzzzzzzt_, "8480-6");
                bool? ezzzzzzzzzzzzzzzv_ = context.Operators.And(ezzzzzzzzzzzzzzzo_, ezzzzzzzzzzzzzzzu_);

                return ezzzzzzzzzzzzzzzv_;
            };
            IEnumerable<Observation.ComponentComponent> bzzzzzzzzzzzzzzzl_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)bzzzzzzzzzzzzzzzj_, bzzzzzzzzzzzzzzzk_);
            Observation.ComponentComponent bzzzzzzzzzzzzzzzm_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(bzzzzzzzzzzzzzzzl_);
            DataType bzzzzzzzzzzzzzzzn_ = bzzzzzzzzzzzzzzzm_?.Value;
            object bzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzn_);
            CqlQuantity bzzzzzzzzzzzzzzzp_ = context.Operators.Quantity(130m, "mm[Hg]");
            CqlQuantity bzzzzzzzzzzzzzzzq_ = context.Operators.Quantity(139m, "mm[Hg]");
            CqlInterval<CqlQuantity> bzzzzzzzzzzzzzzzr_ = context.Operators.Interval(bzzzzzzzzzzzzzzzp_, bzzzzzzzzzzzzzzzq_, true, true);
            bool? bzzzzzzzzzzzzzzzs_ = context.Operators.In<CqlQuantity>(bzzzzzzzzzzzzzzzo_ as CqlQuantity, bzzzzzzzzzzzzzzzr_, default);
            bool? bzzzzzzzzzzzzzzzu_(Observation BloodPressure)
            {
                DataType ezzzzzzzzzzzzzzzw_ = BloodPressure?.Effective;
                object ezzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzw_);
                CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.toInterval(context, ezzzzzzzzzzzzzzzx_);
                CqlDateTime ezzzzzzzzzzzzzzzz_ = context.Operators.End(ezzzzzzzzzzzzzzzy_);
                Period fzzzzzzzzzzzzzzza_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzzzzzzzzzzza_);
                bool? fzzzzzzzzzzzzzzzc_ = context.Operators.In<CqlDateTime>(ezzzzzzzzzzzzzzzz_, fzzzzzzzzzzzzzzzb_, "day");
                Code<ObservationStatus> fzzzzzzzzzzzzzzzd_ = BloodPressure?.StatusElement;
                ObservationStatus? fzzzzzzzzzzzzzzze_ = fzzzzzzzzzzzzzzzd_?.Value;
                string fzzzzzzzzzzzzzzzf_ = context.Operators.Convert<string>(fzzzzzzzzzzzzzzze_);
                string[] fzzzzzzzzzzzzzzzg_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? fzzzzzzzzzzzzzzzh_ = context.Operators.In<string>(fzzzzzzzzzzzzzzzf_, fzzzzzzzzzzzzzzzg_ as IEnumerable<string>);
                bool? fzzzzzzzzzzzzzzzi_ = context.Operators.And(fzzzzzzzzzzzzzzzc_, fzzzzzzzzzzzzzzzh_);

                return fzzzzzzzzzzzzzzzi_;
            };
            IEnumerable<Observation> bzzzzzzzzzzzzzzzv_ = context.Operators.Where<Observation>(bzzzzzzzzzzzzzzzd_, bzzzzzzzzzzzzzzzu_);
            object bzzzzzzzzzzzzzzzw_(Observation @this)
            {
                DataType fzzzzzzzzzzzzzzzj_ = @this?.Effective;
                object fzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzj_);
                CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.toInterval(context, fzzzzzzzzzzzzzzzk_);
                CqlDateTime fzzzzzzzzzzzzzzzm_ = context.Operators.Start(fzzzzzzzzzzzzzzzl_);

                return fzzzzzzzzzzzzzzzm_;
            };
            IEnumerable<Observation> bzzzzzzzzzzzzzzzx_ = context.Operators.SortBy<Observation>(bzzzzzzzzzzzzzzzv_, bzzzzzzzzzzzzzzzw_, System.ComponentModel.ListSortDirection.Ascending);
            Observation bzzzzzzzzzzzzzzzy_ = context.Operators.Last<Observation>(bzzzzzzzzzzzzzzzx_);
            List<Observation.ComponentComponent> bzzzzzzzzzzzzzzzz_ = bzzzzzzzzzzzzzzzy_?.Component;
            bool? czzzzzzzzzzzzzzza_(Observation.ComponentComponent @this)
            {
                CodeableConcept fzzzzzzzzzzzzzzzn_ = @this?.Code;
                List<Coding> fzzzzzzzzzzzzzzzo_ = fzzzzzzzzzzzzzzzn_?.Coding;
                Coding fzzzzzzzzzzzzzzzp_ = context.Operators.First<Coding>((IEnumerable<Coding>)fzzzzzzzzzzzzzzzo_);
                FhirUri fzzzzzzzzzzzzzzzq_ = fzzzzzzzzzzzzzzzp_?.SystemElement;
                string fzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToString(context, fzzzzzzzzzzzzzzzq_);
                bool? fzzzzzzzzzzzzzzzs_ = context.Operators.Equal(fzzzzzzzzzzzzzzzr_, "http://loinc.org");
                List<Coding> fzzzzzzzzzzzzzzzu_ = fzzzzzzzzzzzzzzzn_?.Coding;
                Coding fzzzzzzzzzzzzzzzv_ = context.Operators.First<Coding>((IEnumerable<Coding>)fzzzzzzzzzzzzzzzu_);
                Code fzzzzzzzzzzzzzzzw_ = fzzzzzzzzzzzzzzzv_?.CodeElement;
                string fzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToString(context, fzzzzzzzzzzzzzzzw_);
                bool? fzzzzzzzzzzzzzzzy_ = context.Operators.Equal(fzzzzzzzzzzzzzzzx_, "8462-4");
                bool? fzzzzzzzzzzzzzzzz_ = context.Operators.And(fzzzzzzzzzzzzzzzs_, fzzzzzzzzzzzzzzzy_);

                return fzzzzzzzzzzzzzzzz_;
            };
            IEnumerable<Observation.ComponentComponent> czzzzzzzzzzzzzzzb_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)bzzzzzzzzzzzzzzzz_, czzzzzzzzzzzzzzza_);
            Observation.ComponentComponent czzzzzzzzzzzzzzzc_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(czzzzzzzzzzzzzzzb_);
            DataType czzzzzzzzzzzzzzzd_ = czzzzzzzzzzzzzzzc_?.Value;
            object czzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzd_);
            CqlQuantity czzzzzzzzzzzzzzzf_ = context.Operators.Quantity(80m, "mm[Hg]");
            CqlQuantity czzzzzzzzzzzzzzzg_ = context.Operators.Quantity(89m, "mm[Hg]");
            CqlInterval<CqlQuantity> czzzzzzzzzzzzzzzh_ = context.Operators.Interval(czzzzzzzzzzzzzzzf_, czzzzzzzzzzzzzzzg_, true, true);
            bool? czzzzzzzzzzzzzzzi_ = context.Operators.In<CqlQuantity>(czzzzzzzzzzzzzzze_ as CqlQuantity, czzzzzzzzzzzzzzzh_, default);
            bool? czzzzzzzzzzzzzzzj_ = context.Operators.Or(bzzzzzzzzzzzzzzzs_, czzzzzzzzzzzzzzzi_);
            bool? czzzzzzzzzzzzzzzl_(Observation BloodPressure)
            {
                DataType gzzzzzzzzzzzzzzza_ = BloodPressure?.Effective;
                object gzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzza_);
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.toInterval(context, gzzzzzzzzzzzzzzzb_);
                CqlDateTime gzzzzzzzzzzzzzzzd_ = context.Operators.End(gzzzzzzzzzzzzzzzc_);
                Period gzzzzzzzzzzzzzzze_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzzzzzzzzzze_);
                bool? gzzzzzzzzzzzzzzzg_ = context.Operators.In<CqlDateTime>(gzzzzzzzzzzzzzzzd_, gzzzzzzzzzzzzzzzf_, "day");
                Code<ObservationStatus> gzzzzzzzzzzzzzzzh_ = BloodPressure?.StatusElement;
                ObservationStatus? gzzzzzzzzzzzzzzzi_ = gzzzzzzzzzzzzzzzh_?.Value;
                string gzzzzzzzzzzzzzzzj_ = context.Operators.Convert<string>(gzzzzzzzzzzzzzzzi_);
                string[] gzzzzzzzzzzzzzzzk_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? gzzzzzzzzzzzzzzzl_ = context.Operators.In<string>(gzzzzzzzzzzzzzzzj_, gzzzzzzzzzzzzzzzk_ as IEnumerable<string>);
                bool? gzzzzzzzzzzzzzzzm_ = context.Operators.And(gzzzzzzzzzzzzzzzg_, gzzzzzzzzzzzzzzzl_);

                return gzzzzzzzzzzzzzzzm_;
            };
            IEnumerable<Observation> czzzzzzzzzzzzzzzm_ = context.Operators.Where<Observation>(bzzzzzzzzzzzzzzzd_, czzzzzzzzzzzzzzzl_);
            object czzzzzzzzzzzzzzzn_(Observation @this)
            {
                DataType gzzzzzzzzzzzzzzzn_ = @this?.Effective;
                object gzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzn_);
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.toInterval(context, gzzzzzzzzzzzzzzzo_);
                CqlDateTime gzzzzzzzzzzzzzzzq_ = context.Operators.Start(gzzzzzzzzzzzzzzzp_);

                return gzzzzzzzzzzzzzzzq_;
            };
            IEnumerable<Observation> czzzzzzzzzzzzzzzo_ = context.Operators.SortBy<Observation>(czzzzzzzzzzzzzzzm_, czzzzzzzzzzzzzzzn_, System.ComponentModel.ListSortDirection.Ascending);
            Observation czzzzzzzzzzzzzzzp_ = context.Operators.Last<Observation>(czzzzzzzzzzzzzzzo_);
            List<Observation.ComponentComponent> czzzzzzzzzzzzzzzq_ = czzzzzzzzzzzzzzzp_?.Component;
            bool? czzzzzzzzzzzzzzzr_(Observation.ComponentComponent @this)
            {
                CodeableConcept gzzzzzzzzzzzzzzzr_ = @this?.Code;
                List<Coding> gzzzzzzzzzzzzzzzs_ = gzzzzzzzzzzzzzzzr_?.Coding;
                Coding gzzzzzzzzzzzzzzzt_ = context.Operators.First<Coding>((IEnumerable<Coding>)gzzzzzzzzzzzzzzzs_);
                FhirUri gzzzzzzzzzzzzzzzu_ = gzzzzzzzzzzzzzzzt_?.SystemElement;
                string gzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToString(context, gzzzzzzzzzzzzzzzu_);
                bool? gzzzzzzzzzzzzzzzw_ = context.Operators.Equal(gzzzzzzzzzzzzzzzv_, "http://loinc.org");
                List<Coding> gzzzzzzzzzzzzzzzy_ = gzzzzzzzzzzzzzzzr_?.Coding;
                Coding gzzzzzzzzzzzzzzzz_ = context.Operators.First<Coding>((IEnumerable<Coding>)gzzzzzzzzzzzzzzzy_);
                Code hzzzzzzzzzzzzzzza_ = gzzzzzzzzzzzzzzzz_?.CodeElement;
                string hzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToString(context, hzzzzzzzzzzzzzzza_);
                bool? hzzzzzzzzzzzzzzzc_ = context.Operators.Equal(hzzzzzzzzzzzzzzzb_, "8480-6");
                bool? hzzzzzzzzzzzzzzzd_ = context.Operators.And(gzzzzzzzzzzzzzzzw_, hzzzzzzzzzzzzzzzc_);

                return hzzzzzzzzzzzzzzzd_;
            };
            IEnumerable<Observation.ComponentComponent> czzzzzzzzzzzzzzzs_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)czzzzzzzzzzzzzzzq_, czzzzzzzzzzzzzzzr_);
            Observation.ComponentComponent czzzzzzzzzzzzzzzt_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(czzzzzzzzzzzzzzzs_);
            DataType czzzzzzzzzzzzzzzu_ = czzzzzzzzzzzzzzzt_?.Value;
            object czzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzu_);
            CqlQuantity czzzzzzzzzzzzzzzw_ = context.Operators.Quantity(140m, "mm[Hg]");
            bool? czzzzzzzzzzzzzzzx_ = context.Operators.GreaterOrEqual(czzzzzzzzzzzzzzzv_ as CqlQuantity, czzzzzzzzzzzzzzzw_);
            bool? czzzzzzzzzzzzzzzz_(Observation BloodPressure)
            {
                DataType hzzzzzzzzzzzzzzze_ = BloodPressure?.Effective;
                object hzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzze_);
                CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.toInterval(context, hzzzzzzzzzzzzzzzf_);
                CqlDateTime hzzzzzzzzzzzzzzzh_ = context.Operators.End(hzzzzzzzzzzzzzzzg_);
                Period hzzzzzzzzzzzzzzzi_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzzzzzzzzzzi_);
                bool? hzzzzzzzzzzzzzzzk_ = context.Operators.In<CqlDateTime>(hzzzzzzzzzzzzzzzh_, hzzzzzzzzzzzzzzzj_, "day");
                Code<ObservationStatus> hzzzzzzzzzzzzzzzl_ = BloodPressure?.StatusElement;
                ObservationStatus? hzzzzzzzzzzzzzzzm_ = hzzzzzzzzzzzzzzzl_?.Value;
                string hzzzzzzzzzzzzzzzn_ = context.Operators.Convert<string>(hzzzzzzzzzzzzzzzm_);
                string[] hzzzzzzzzzzzzzzzo_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? hzzzzzzzzzzzzzzzp_ = context.Operators.In<string>(hzzzzzzzzzzzzzzzn_, hzzzzzzzzzzzzzzzo_ as IEnumerable<string>);
                bool? hzzzzzzzzzzzzzzzq_ = context.Operators.And(hzzzzzzzzzzzzzzzk_, hzzzzzzzzzzzzzzzp_);

                return hzzzzzzzzzzzzzzzq_;
            };
            IEnumerable<Observation> dzzzzzzzzzzzzzzza_ = context.Operators.Where<Observation>(bzzzzzzzzzzzzzzzd_, czzzzzzzzzzzzzzzz_);
            object dzzzzzzzzzzzzzzzb_(Observation @this)
            {
                DataType hzzzzzzzzzzzzzzzr_ = @this?.Effective;
                object hzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzr_);
                CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.toInterval(context, hzzzzzzzzzzzzzzzs_);
                CqlDateTime hzzzzzzzzzzzzzzzu_ = context.Operators.Start(hzzzzzzzzzzzzzzzt_);

                return hzzzzzzzzzzzzzzzu_;
            };
            IEnumerable<Observation> dzzzzzzzzzzzzzzzc_ = context.Operators.SortBy<Observation>(dzzzzzzzzzzzzzzza_, dzzzzzzzzzzzzzzzb_, System.ComponentModel.ListSortDirection.Ascending);
            Observation dzzzzzzzzzzzzzzzd_ = context.Operators.Last<Observation>(dzzzzzzzzzzzzzzzc_);
            List<Observation.ComponentComponent> dzzzzzzzzzzzzzzze_ = dzzzzzzzzzzzzzzzd_?.Component;
            bool? dzzzzzzzzzzzzzzzf_(Observation.ComponentComponent @this)
            {
                CodeableConcept hzzzzzzzzzzzzzzzv_ = @this?.Code;
                List<Coding> hzzzzzzzzzzzzzzzw_ = hzzzzzzzzzzzzzzzv_?.Coding;
                Coding hzzzzzzzzzzzzzzzx_ = context.Operators.First<Coding>((IEnumerable<Coding>)hzzzzzzzzzzzzzzzw_);
                FhirUri hzzzzzzzzzzzzzzzy_ = hzzzzzzzzzzzzzzzx_?.SystemElement;
                string hzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToString(context, hzzzzzzzzzzzzzzzy_);
                bool? izzzzzzzzzzzzzzza_ = context.Operators.Equal(hzzzzzzzzzzzzzzzz_, "http://loinc.org");
                List<Coding> izzzzzzzzzzzzzzzc_ = hzzzzzzzzzzzzzzzv_?.Coding;
                Coding izzzzzzzzzzzzzzzd_ = context.Operators.First<Coding>((IEnumerable<Coding>)izzzzzzzzzzzzzzzc_);
                Code izzzzzzzzzzzzzzze_ = izzzzzzzzzzzzzzzd_?.CodeElement;
                string izzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToString(context, izzzzzzzzzzzzzzze_);
                bool? izzzzzzzzzzzzzzzg_ = context.Operators.Equal(izzzzzzzzzzzzzzzf_, "8462-4");
                bool? izzzzzzzzzzzzzzzh_ = context.Operators.And(izzzzzzzzzzzzzzza_, izzzzzzzzzzzzzzzg_);

                return izzzzzzzzzzzzzzzh_;
            };
            IEnumerable<Observation.ComponentComponent> dzzzzzzzzzzzzzzzg_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)dzzzzzzzzzzzzzzze_, dzzzzzzzzzzzzzzzf_);
            Observation.ComponentComponent dzzzzzzzzzzzzzzzh_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(dzzzzzzzzzzzzzzzg_);
            DataType dzzzzzzzzzzzzzzzi_ = dzzzzzzzzzzzzzzzh_?.Value;
            object dzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzi_);
            CqlQuantity dzzzzzzzzzzzzzzzk_ = context.Operators.Quantity(90m, "mm[Hg]");
            bool? dzzzzzzzzzzzzzzzl_ = context.Operators.GreaterOrEqual(dzzzzzzzzzzzzzzzj_ as CqlQuantity, dzzzzzzzzzzzzzzzk_);
            bool? dzzzzzzzzzzzzzzzm_ = context.Operators.Or(czzzzzzzzzzzzzzzx_, dzzzzzzzzzzzzzzzl_);
            bool? dzzzzzzzzzzzzzzzn_ = context.Operators.Not(dzzzzzzzzzzzzzzzm_);
            bool? dzzzzzzzzzzzzzzzo_ = context.Operators.And(czzzzzzzzzzzzzzzj_, dzzzzzzzzzzzzzzzn_);
            IEnumerable<Encounter> dzzzzzzzzzzzzzzzp_ = this.Encounter_with_Hypertensive_Reading_Within_Year_Prior(context);
            bool? dzzzzzzzzzzzzzzzq_ = context.Operators.Exists<Encounter>(dzzzzzzzzzzzzzzzp_);
            bool? dzzzzzzzzzzzzzzzr_ = context.Operators.And(dzzzzzzzzzzzzzzzo_, dzzzzzzzzzzzzzzzq_);

            return dzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzc_ = context.Operators.Where<Encounter>(bzzzzzzzzzzzzzzza_, bzzzzzzzzzzzzzzzb_);

        return bzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Laboratory Test or ECG for Hypertension")]
    public IEnumerable<ServiceRequest> Laboratory_Test_or_ECG_for_Hypertension(CqlContext context)
    {
        CqlCode izzzzzzzzzzzzzzzi_ = this._12_lead_EKG_panel(context);
        IEnumerable<CqlCode> izzzzzzzzzzzzzzzj_ = context.Operators.ToList<CqlCode>(izzzzzzzzzzzzzzzi_);
        IEnumerable<ServiceRequest> izzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, default, izzzzzzzzzzzzzzzj_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        CqlCode izzzzzzzzzzzzzzzl_ = this.EKG_study(context);
        IEnumerable<CqlCode> izzzzzzzzzzzzzzzm_ = context.Operators.ToList<CqlCode>(izzzzzzzzzzzzzzzl_);
        IEnumerable<ServiceRequest> izzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, default, izzzzzzzzzzzzzzzm_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> izzzzzzzzzzzzzzzo_ = context.Operators.Union<ServiceRequest>(izzzzzzzzzzzzzzzk_, izzzzzzzzzzzzzzzn_);
        CqlValueSet izzzzzzzzzzzzzzzp_ = this.Laboratory_Tests_for_Hypertension(context);
        IEnumerable<ServiceRequest> izzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, izzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> izzzzzzzzzzzzzzzr_ = context.Operators.Union<ServiceRequest>(izzzzzzzzzzzzzzzo_, izzzzzzzzzzzzzzzq_);
        bool? izzzzzzzzzzzzzzzs_(ServiceRequest EKGLab)
        {
            Code<RequestIntent> izzzzzzzzzzzzzzzu_ = EKGLab?.IntentElement;
            RequestIntent? izzzzzzzzzzzzzzzv_ = izzzzzzzzzzzzzzzu_?.Value;
            Code<RequestIntent> izzzzzzzzzzzzzzzw_ = context.Operators.Convert<Code<RequestIntent>>(izzzzzzzzzzzzzzzv_);
            bool? izzzzzzzzzzzzzzzx_ = context.Operators.Equivalent(izzzzzzzzzzzzzzzw_, "order");

            return izzzzzzzzzzzzzzzx_;
        };
        IEnumerable<ServiceRequest> izzzzzzzzzzzzzzzt_ = context.Operators.Where<ServiceRequest>(izzzzzzzzzzzzzzzr_, izzzzzzzzzzzzzzzs_);

        return izzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Second Hypertensive Reading SBP 130 to 139 OR DBP 80 to 89 and Interventions")]
    public IEnumerable<ServiceRequest> Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89_and_Interventions(CqlContext context)
    {
        IEnumerable<ServiceRequest> izzzzzzzzzzzzzzzy_ = this.Follow_up_with_Rescreen_Within_6_Months(context);
        IEnumerable<ServiceRequest> izzzzzzzzzzzzzzzz_(ServiceRequest Rescreen2to6)
        {
            IEnumerable<ServiceRequest> jzzzzzzzzzzzzzzzd_ = this.Laboratory_Test_or_ECG_for_Hypertension(context);
            bool? jzzzzzzzzzzzzzzze_(ServiceRequest LabECGIntervention)
            {
                FhirDateTime jzzzzzzzzzzzzzzzi_ = Rescreen2to6?.AuthoredOnElement;
                CqlDateTime jzzzzzzzzzzzzzzzj_ = context.Operators.Convert<CqlDateTime>(jzzzzzzzzzzzzzzzi_);
                CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzk_ = this.Measurement_Period(context);
                bool? jzzzzzzzzzzzzzzzl_ = context.Operators.In<CqlDateTime>(jzzzzzzzzzzzzzzzj_, jzzzzzzzzzzzzzzzk_, "day");
                FhirDateTime jzzzzzzzzzzzzzzzm_ = LabECGIntervention?.AuthoredOnElement;
                CqlDateTime jzzzzzzzzzzzzzzzn_ = context.Operators.Convert<CqlDateTime>(jzzzzzzzzzzzzzzzm_);
                bool? jzzzzzzzzzzzzzzzp_ = context.Operators.In<CqlDateTime>(jzzzzzzzzzzzzzzzn_, jzzzzzzzzzzzzzzzk_, "day");
                bool? jzzzzzzzzzzzzzzzq_ = context.Operators.And(jzzzzzzzzzzzzzzzl_, jzzzzzzzzzzzzzzzp_);

                return jzzzzzzzzzzzzzzzq_;
            };
            IEnumerable<ServiceRequest> jzzzzzzzzzzzzzzzf_ = context.Operators.Where<ServiceRequest>(jzzzzzzzzzzzzzzzd_, jzzzzzzzzzzzzzzze_);
            ServiceRequest jzzzzzzzzzzzzzzzg_(ServiceRequest LabECGIntervention) =>
                Rescreen2to6;
            IEnumerable<ServiceRequest> jzzzzzzzzzzzzzzzh_ = context.Operators.Select<ServiceRequest, ServiceRequest>(jzzzzzzzzzzzzzzzf_, jzzzzzzzzzzzzzzzg_);

            return jzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<ServiceRequest> jzzzzzzzzzzzzzzza_ = context.Operators.SelectMany<ServiceRequest, ServiceRequest>(izzzzzzzzzzzzzzzy_, izzzzzzzzzzzzzzzz_);
        IEnumerable<ServiceRequest> jzzzzzzzzzzzzzzzb_(ServiceRequest Rescreen2to6)
        {
            IEnumerable<ServiceRequest> jzzzzzzzzzzzzzzzr_ = this.NonPharmacological_Interventions(context);
            bool? jzzzzzzzzzzzzzzzs_(ServiceRequest NonPharmSecondIntervention)
            {
                FhirDateTime jzzzzzzzzzzzzzzzw_ = NonPharmSecondIntervention?.AuthoredOnElement;
                CqlDateTime jzzzzzzzzzzzzzzzx_ = context.Operators.Convert<CqlDateTime>(jzzzzzzzzzzzzzzzw_);
                CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzy_ = this.Measurement_Period(context);
                bool? jzzzzzzzzzzzzzzzz_ = context.Operators.In<CqlDateTime>(jzzzzzzzzzzzzzzzx_, jzzzzzzzzzzzzzzzy_, "day");

                return jzzzzzzzzzzzzzzzz_;
            };
            IEnumerable<ServiceRequest> jzzzzzzzzzzzzzzzt_ = context.Operators.Where<ServiceRequest>(jzzzzzzzzzzzzzzzr_, jzzzzzzzzzzzzzzzs_);
            ServiceRequest jzzzzzzzzzzzzzzzu_(ServiceRequest NonPharmSecondIntervention) =>
                Rescreen2to6;
            IEnumerable<ServiceRequest> jzzzzzzzzzzzzzzzv_ = context.Operators.Select<ServiceRequest, ServiceRequest>(jzzzzzzzzzzzzzzzt_, jzzzzzzzzzzzzzzzu_);

            return jzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<ServiceRequest> jzzzzzzzzzzzzzzzc_ = context.Operators.SelectMany<ServiceRequest, ServiceRequest>(jzzzzzzzzzzzzzzza_, jzzzzzzzzzzzzzzzb_);

        return jzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Encounter with Second Hypertensive Reading SBP 130 to 139 OR DBP 80 to 89 and Interventions")]
    public IEnumerable<Encounter> Encounter_with_Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89_and_Interventions(CqlContext context)
    {
        IEnumerable<Encounter> kzzzzzzzzzzzzzzza_ = this.Encounter_with_Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89(context);
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzb_(Encounter SecondHTNEncounterReading)
        {
            IEnumerable<ServiceRequest> kzzzzzzzzzzzzzzzh_ = this.Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89_and_Interventions(context);
            bool? kzzzzzzzzzzzzzzzi_(ServiceRequest EncounterInterventions)
            {
                FhirDateTime kzzzzzzzzzzzzzzzm_ = EncounterInterventions?.AuthoredOnElement;
                CqlDateTime kzzzzzzzzzzzzzzzn_ = context.Operators.Convert<CqlDateTime>(kzzzzzzzzzzzzzzzm_);
                Period kzzzzzzzzzzzzzzzo_ = SecondHTNEncounterReading?.Period;
                CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzzzzzzzzzzzo_);
                bool? kzzzzzzzzzzzzzzzq_ = context.Operators.In<CqlDateTime>(kzzzzzzzzzzzzzzzn_, kzzzzzzzzzzzzzzzp_, "day");

                return kzzzzzzzzzzzzzzzq_;
            };
            IEnumerable<ServiceRequest> kzzzzzzzzzzzzzzzj_ = context.Operators.Where<ServiceRequest>(kzzzzzzzzzzzzzzzh_, kzzzzzzzzzzzzzzzi_);
            Encounter kzzzzzzzzzzzzzzzk_(ServiceRequest EncounterInterventions) =>
                SecondHTNEncounterReading;
            IEnumerable<Encounter> kzzzzzzzzzzzzzzzl_ = context.Operators.Select<ServiceRequest, Encounter>(kzzzzzzzzzzzzzzzj_, kzzzzzzzzzzzzzzzk_);

            return kzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzc_ = context.Operators.SelectMany<Encounter, Encounter>(kzzzzzzzzzzzzzzza_, kzzzzzzzzzzzzzzzb_);
        IEnumerable<Encounter> kzzzzzzzzzzzzzzze_(Encounter SecondHTNEncounterReading)
        {
            IEnumerable<ServiceRequest> kzzzzzzzzzzzzzzzr_ = this.Referral_to_Alternate_or_Primary_Healthcare_Professional_for_Hypertensive_Reading(context);
            bool? kzzzzzzzzzzzzzzzs_(ServiceRequest ReferralForHTN)
            {
                FhirDateTime kzzzzzzzzzzzzzzzw_ = ReferralForHTN?.AuthoredOnElement;
                CqlDateTime kzzzzzzzzzzzzzzzx_ = context.Operators.Convert<CqlDateTime>(kzzzzzzzzzzzzzzzw_);
                Period kzzzzzzzzzzzzzzzy_ = SecondHTNEncounterReading?.Period;
                CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzzzzzzzzzzzy_);
                bool? lzzzzzzzzzzzzzzza_ = context.Operators.In<CqlDateTime>(kzzzzzzzzzzzzzzzx_, kzzzzzzzzzzzzzzzz_, "day");

                return lzzzzzzzzzzzzzzza_;
            };
            IEnumerable<ServiceRequest> kzzzzzzzzzzzzzzzt_ = context.Operators.Where<ServiceRequest>(kzzzzzzzzzzzzzzzr_, kzzzzzzzzzzzzzzzs_);
            Encounter kzzzzzzzzzzzzzzzu_(ServiceRequest ReferralForHTN) =>
                SecondHTNEncounterReading;
            IEnumerable<Encounter> kzzzzzzzzzzzzzzzv_ = context.Operators.Select<ServiceRequest, Encounter>(kzzzzzzzzzzzzzzzt_, kzzzzzzzzzzzzzzzu_);

            return kzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzf_ = context.Operators.SelectMany<Encounter, Encounter>(kzzzzzzzzzzzzzzza_, kzzzzzzzzzzzzzzze_);
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzg_ = context.Operators.Union<Encounter>(kzzzzzzzzzzzzzzzc_, kzzzzzzzzzzzzzzzf_);

        return kzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Encounter with Second Hypertensive Reading SBP Greater than or Equal to 140 OR DBP Greater than or Equal to 90")]
    public IEnumerable<Encounter> Encounter_with_Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90(CqlContext context)
    {
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzb_ = this.Qualifying_Encounter_during_Measurement_Period(context);
        bool? lzzzzzzzzzzzzzzzc_(Encounter QualifyingEncounter)
        {
            IEnumerable<Observation> lzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/bp"));
            bool? lzzzzzzzzzzzzzzzf_(Observation BloodPressure)
            {
                DataType nzzzzzzzzzzzzzzzo_ = BloodPressure?.Effective;
                object nzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzo_);
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.toInterval(context, nzzzzzzzzzzzzzzzp_);
                CqlDateTime nzzzzzzzzzzzzzzzr_ = context.Operators.End(nzzzzzzzzzzzzzzzq_);
                Period nzzzzzzzzzzzzzzzs_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzzzzzzzzzzzs_);
                bool? nzzzzzzzzzzzzzzzu_ = context.Operators.In<CqlDateTime>(nzzzzzzzzzzzzzzzr_, nzzzzzzzzzzzzzzzt_, default);
                Code<ObservationStatus> nzzzzzzzzzzzzzzzv_ = BloodPressure?.StatusElement;
                ObservationStatus? nzzzzzzzzzzzzzzzw_ = nzzzzzzzzzzzzzzzv_?.Value;
                string nzzzzzzzzzzzzzzzx_ = context.Operators.Convert<string>(nzzzzzzzzzzzzzzzw_);
                string[] nzzzzzzzzzzzzzzzy_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? nzzzzzzzzzzzzzzzz_ = context.Operators.In<string>(nzzzzzzzzzzzzzzzx_, nzzzzzzzzzzzzzzzy_ as IEnumerable<string>);
                bool? ozzzzzzzzzzzzzzza_ = context.Operators.And(nzzzzzzzzzzzzzzzu_, nzzzzzzzzzzzzzzzz_);

                return ozzzzzzzzzzzzzzza_;
            };
            IEnumerable<Observation> lzzzzzzzzzzzzzzzg_ = context.Operators.Where<Observation>(lzzzzzzzzzzzzzzze_, lzzzzzzzzzzzzzzzf_);
            object lzzzzzzzzzzzzzzzh_(Observation @this)
            {
                DataType ozzzzzzzzzzzzzzzb_ = @this?.Effective;
                object ozzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzb_);
                CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.toInterval(context, ozzzzzzzzzzzzzzzc_);
                CqlDateTime ozzzzzzzzzzzzzzze_ = context.Operators.Start(ozzzzzzzzzzzzzzzd_);

                return ozzzzzzzzzzzzzzze_;
            };
            IEnumerable<Observation> lzzzzzzzzzzzzzzzi_ = context.Operators.SortBy<Observation>(lzzzzzzzzzzzzzzzg_, lzzzzzzzzzzzzzzzh_, System.ComponentModel.ListSortDirection.Ascending);
            Observation lzzzzzzzzzzzzzzzj_ = context.Operators.Last<Observation>(lzzzzzzzzzzzzzzzi_);
            List<Observation.ComponentComponent> lzzzzzzzzzzzzzzzk_ = lzzzzzzzzzzzzzzzj_?.Component;
            bool? lzzzzzzzzzzzzzzzl_(Observation.ComponentComponent @this)
            {
                CodeableConcept ozzzzzzzzzzzzzzzf_ = @this?.Code;
                List<Coding> ozzzzzzzzzzzzzzzg_ = ozzzzzzzzzzzzzzzf_?.Coding;
                Coding ozzzzzzzzzzzzzzzh_ = context.Operators.First<Coding>((IEnumerable<Coding>)ozzzzzzzzzzzzzzzg_);
                FhirUri ozzzzzzzzzzzzzzzi_ = ozzzzzzzzzzzzzzzh_?.SystemElement;
                string ozzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToString(context, ozzzzzzzzzzzzzzzi_);
                bool? ozzzzzzzzzzzzzzzk_ = context.Operators.Equal(ozzzzzzzzzzzzzzzj_, "http://loinc.org");
                List<Coding> ozzzzzzzzzzzzzzzm_ = ozzzzzzzzzzzzzzzf_?.Coding;
                Coding ozzzzzzzzzzzzzzzn_ = context.Operators.First<Coding>((IEnumerable<Coding>)ozzzzzzzzzzzzzzzm_);
                Code ozzzzzzzzzzzzzzzo_ = ozzzzzzzzzzzzzzzn_?.CodeElement;
                string ozzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToString(context, ozzzzzzzzzzzzzzzo_);
                bool? ozzzzzzzzzzzzzzzq_ = context.Operators.Equal(ozzzzzzzzzzzzzzzp_, "8480-6");
                bool? ozzzzzzzzzzzzzzzr_ = context.Operators.And(ozzzzzzzzzzzzzzzk_, ozzzzzzzzzzzzzzzq_);

                return ozzzzzzzzzzzzzzzr_;
            };
            IEnumerable<Observation.ComponentComponent> lzzzzzzzzzzzzzzzm_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)lzzzzzzzzzzzzzzzk_, lzzzzzzzzzzzzzzzl_);
            Observation.ComponentComponent lzzzzzzzzzzzzzzzn_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(lzzzzzzzzzzzzzzzm_);
            DataType lzzzzzzzzzzzzzzzo_ = lzzzzzzzzzzzzzzzn_?.Value;
            object lzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzo_);
            CqlQuantity lzzzzzzzzzzzzzzzq_ = context.Operators.Quantity(0m, "mm[Hg]");
            bool? lzzzzzzzzzzzzzzzr_ = context.Operators.Greater(lzzzzzzzzzzzzzzzp_ as CqlQuantity, lzzzzzzzzzzzzzzzq_);
            bool? lzzzzzzzzzzzzzzzt_(Observation BloodPressure)
            {
                DataType ozzzzzzzzzzzzzzzs_ = BloodPressure?.Effective;
                object ozzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzs_);
                CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.toInterval(context, ozzzzzzzzzzzzzzzt_);
                CqlDateTime ozzzzzzzzzzzzzzzv_ = context.Operators.End(ozzzzzzzzzzzzzzzu_);
                Period ozzzzzzzzzzzzzzzw_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzzzzzzzzzzzw_);
                bool? ozzzzzzzzzzzzzzzy_ = context.Operators.In<CqlDateTime>(ozzzzzzzzzzzzzzzv_, ozzzzzzzzzzzzzzzx_, default);
                Code<ObservationStatus> ozzzzzzzzzzzzzzzz_ = BloodPressure?.StatusElement;
                ObservationStatus? pzzzzzzzzzzzzzzza_ = ozzzzzzzzzzzzzzzz_?.Value;
                string pzzzzzzzzzzzzzzzb_ = context.Operators.Convert<string>(pzzzzzzzzzzzzzzza_);
                string[] pzzzzzzzzzzzzzzzc_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? pzzzzzzzzzzzzzzzd_ = context.Operators.In<string>(pzzzzzzzzzzzzzzzb_, pzzzzzzzzzzzzzzzc_ as IEnumerable<string>);
                bool? pzzzzzzzzzzzzzzze_ = context.Operators.And(ozzzzzzzzzzzzzzzy_, pzzzzzzzzzzzzzzzd_);

                return pzzzzzzzzzzzzzzze_;
            };
            IEnumerable<Observation> lzzzzzzzzzzzzzzzu_ = context.Operators.Where<Observation>(lzzzzzzzzzzzzzzze_, lzzzzzzzzzzzzzzzt_);
            object lzzzzzzzzzzzzzzzv_(Observation @this)
            {
                DataType pzzzzzzzzzzzzzzzf_ = @this?.Effective;
                object pzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzf_);
                CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.toInterval(context, pzzzzzzzzzzzzzzzg_);
                CqlDateTime pzzzzzzzzzzzzzzzi_ = context.Operators.Start(pzzzzzzzzzzzzzzzh_);

                return pzzzzzzzzzzzzzzzi_;
            };
            IEnumerable<Observation> lzzzzzzzzzzzzzzzw_ = context.Operators.SortBy<Observation>(lzzzzzzzzzzzzzzzu_, lzzzzzzzzzzzzzzzv_, System.ComponentModel.ListSortDirection.Ascending);
            Observation lzzzzzzzzzzzzzzzx_ = context.Operators.Last<Observation>(lzzzzzzzzzzzzzzzw_);
            List<Observation.ComponentComponent> lzzzzzzzzzzzzzzzy_ = lzzzzzzzzzzzzzzzx_?.Component;
            bool? lzzzzzzzzzzzzzzzz_(Observation.ComponentComponent @this)
            {
                CodeableConcept pzzzzzzzzzzzzzzzj_ = @this?.Code;
                List<Coding> pzzzzzzzzzzzzzzzk_ = pzzzzzzzzzzzzzzzj_?.Coding;
                Coding pzzzzzzzzzzzzzzzl_ = context.Operators.First<Coding>((IEnumerable<Coding>)pzzzzzzzzzzzzzzzk_);
                FhirUri pzzzzzzzzzzzzzzzm_ = pzzzzzzzzzzzzzzzl_?.SystemElement;
                string pzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToString(context, pzzzzzzzzzzzzzzzm_);
                bool? pzzzzzzzzzzzzzzzo_ = context.Operators.Equal(pzzzzzzzzzzzzzzzn_, "http://loinc.org");
                List<Coding> pzzzzzzzzzzzzzzzq_ = pzzzzzzzzzzzzzzzj_?.Coding;
                Coding pzzzzzzzzzzzzzzzr_ = context.Operators.First<Coding>((IEnumerable<Coding>)pzzzzzzzzzzzzzzzq_);
                Code pzzzzzzzzzzzzzzzs_ = pzzzzzzzzzzzzzzzr_?.CodeElement;
                string pzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToString(context, pzzzzzzzzzzzzzzzs_);
                bool? pzzzzzzzzzzzzzzzu_ = context.Operators.Equal(pzzzzzzzzzzzzzzzt_, "8462-4");
                bool? pzzzzzzzzzzzzzzzv_ = context.Operators.And(pzzzzzzzzzzzzzzzo_, pzzzzzzzzzzzzzzzu_);

                return pzzzzzzzzzzzzzzzv_;
            };
            IEnumerable<Observation.ComponentComponent> mzzzzzzzzzzzzzzza_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)lzzzzzzzzzzzzzzzy_, lzzzzzzzzzzzzzzzz_);
            Observation.ComponentComponent mzzzzzzzzzzzzzzzb_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(mzzzzzzzzzzzzzzza_);
            DataType mzzzzzzzzzzzzzzzc_ = mzzzzzzzzzzzzzzzb_?.Value;
            object mzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzc_);
            bool? mzzzzzzzzzzzzzzzf_ = context.Operators.Greater(mzzzzzzzzzzzzzzzd_ as CqlQuantity, lzzzzzzzzzzzzzzzq_);
            bool? mzzzzzzzzzzzzzzzg_ = context.Operators.And(lzzzzzzzzzzzzzzzr_, mzzzzzzzzzzzzzzzf_);
            bool? mzzzzzzzzzzzzzzzi_(Observation BloodPressure)
            {
                DataType pzzzzzzzzzzzzzzzw_ = BloodPressure?.Effective;
                object pzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzw_);
                CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.toInterval(context, pzzzzzzzzzzzzzzzx_);
                CqlDateTime pzzzzzzzzzzzzzzzz_ = context.Operators.End(pzzzzzzzzzzzzzzzy_);
                Period qzzzzzzzzzzzzzzza_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzzzzzzzzzzza_);
                bool? qzzzzzzzzzzzzzzzc_ = context.Operators.In<CqlDateTime>(pzzzzzzzzzzzzzzzz_, qzzzzzzzzzzzzzzzb_, default);
                Code<ObservationStatus> qzzzzzzzzzzzzzzzd_ = BloodPressure?.StatusElement;
                ObservationStatus? qzzzzzzzzzzzzzzze_ = qzzzzzzzzzzzzzzzd_?.Value;
                string qzzzzzzzzzzzzzzzf_ = context.Operators.Convert<string>(qzzzzzzzzzzzzzzze_);
                string[] qzzzzzzzzzzzzzzzg_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? qzzzzzzzzzzzzzzzh_ = context.Operators.In<string>(qzzzzzzzzzzzzzzzf_, qzzzzzzzzzzzzzzzg_ as IEnumerable<string>);
                bool? qzzzzzzzzzzzzzzzi_ = context.Operators.And(qzzzzzzzzzzzzzzzc_, qzzzzzzzzzzzzzzzh_);

                return qzzzzzzzzzzzzzzzi_;
            };
            IEnumerable<Observation> mzzzzzzzzzzzzzzzj_ = context.Operators.Where<Observation>(lzzzzzzzzzzzzzzze_, mzzzzzzzzzzzzzzzi_);
            object mzzzzzzzzzzzzzzzk_(Observation @this)
            {
                DataType qzzzzzzzzzzzzzzzj_ = @this?.Effective;
                object qzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzj_);
                CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.toInterval(context, qzzzzzzzzzzzzzzzk_);
                CqlDateTime qzzzzzzzzzzzzzzzm_ = context.Operators.Start(qzzzzzzzzzzzzzzzl_);

                return qzzzzzzzzzzzzzzzm_;
            };
            IEnumerable<Observation> mzzzzzzzzzzzzzzzl_ = context.Operators.SortBy<Observation>(mzzzzzzzzzzzzzzzj_, mzzzzzzzzzzzzzzzk_, System.ComponentModel.ListSortDirection.Ascending);
            Observation mzzzzzzzzzzzzzzzm_ = context.Operators.Last<Observation>(mzzzzzzzzzzzzzzzl_);
            List<Observation.ComponentComponent> mzzzzzzzzzzzzzzzn_ = mzzzzzzzzzzzzzzzm_?.Component;
            bool? mzzzzzzzzzzzzzzzo_(Observation.ComponentComponent @this)
            {
                CodeableConcept qzzzzzzzzzzzzzzzn_ = @this?.Code;
                List<Coding> qzzzzzzzzzzzzzzzo_ = qzzzzzzzzzzzzzzzn_?.Coding;
                Coding qzzzzzzzzzzzzzzzp_ = context.Operators.First<Coding>((IEnumerable<Coding>)qzzzzzzzzzzzzzzzo_);
                FhirUri qzzzzzzzzzzzzzzzq_ = qzzzzzzzzzzzzzzzp_?.SystemElement;
                string qzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToString(context, qzzzzzzzzzzzzzzzq_);
                bool? qzzzzzzzzzzzzzzzs_ = context.Operators.Equal(qzzzzzzzzzzzzzzzr_, "http://loinc.org");
                List<Coding> qzzzzzzzzzzzzzzzu_ = qzzzzzzzzzzzzzzzn_?.Coding;
                Coding qzzzzzzzzzzzzzzzv_ = context.Operators.First<Coding>((IEnumerable<Coding>)qzzzzzzzzzzzzzzzu_);
                Code qzzzzzzzzzzzzzzzw_ = qzzzzzzzzzzzzzzzv_?.CodeElement;
                string qzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToString(context, qzzzzzzzzzzzzzzzw_);
                bool? qzzzzzzzzzzzzzzzy_ = context.Operators.Equal(qzzzzzzzzzzzzzzzx_, "8480-6");
                bool? qzzzzzzzzzzzzzzzz_ = context.Operators.And(qzzzzzzzzzzzzzzzs_, qzzzzzzzzzzzzzzzy_);

                return qzzzzzzzzzzzzzzzz_;
            };
            IEnumerable<Observation.ComponentComponent> mzzzzzzzzzzzzzzzp_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)mzzzzzzzzzzzzzzzn_, mzzzzzzzzzzzzzzzo_);
            Observation.ComponentComponent mzzzzzzzzzzzzzzzq_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(mzzzzzzzzzzzzzzzp_);
            DataType mzzzzzzzzzzzzzzzr_ = mzzzzzzzzzzzzzzzq_?.Value;
            object mzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzr_);
            CqlQuantity mzzzzzzzzzzzzzzzt_ = context.Operators.Quantity(140m, "mm[Hg]");
            bool? mzzzzzzzzzzzzzzzu_ = context.Operators.GreaterOrEqual(mzzzzzzzzzzzzzzzs_ as CqlQuantity, mzzzzzzzzzzzzzzzt_);
            bool? mzzzzzzzzzzzzzzzw_(Observation BloodPressure)
            {
                DataType rzzzzzzzzzzzzzzza_ = BloodPressure?.Effective;
                object rzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzza_);
                CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.toInterval(context, rzzzzzzzzzzzzzzzb_);
                CqlDateTime rzzzzzzzzzzzzzzzd_ = context.Operators.End(rzzzzzzzzzzzzzzzc_);
                Period rzzzzzzzzzzzzzzze_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzzzzzzzzzze_);
                bool? rzzzzzzzzzzzzzzzg_ = context.Operators.In<CqlDateTime>(rzzzzzzzzzzzzzzzd_, rzzzzzzzzzzzzzzzf_, default);
                Code<ObservationStatus> rzzzzzzzzzzzzzzzh_ = BloodPressure?.StatusElement;
                ObservationStatus? rzzzzzzzzzzzzzzzi_ = rzzzzzzzzzzzzzzzh_?.Value;
                string rzzzzzzzzzzzzzzzj_ = context.Operators.Convert<string>(rzzzzzzzzzzzzzzzi_);
                string[] rzzzzzzzzzzzzzzzk_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? rzzzzzzzzzzzzzzzl_ = context.Operators.In<string>(rzzzzzzzzzzzzzzzj_, rzzzzzzzzzzzzzzzk_ as IEnumerable<string>);
                bool? rzzzzzzzzzzzzzzzm_ = context.Operators.And(rzzzzzzzzzzzzzzzg_, rzzzzzzzzzzzzzzzl_);

                return rzzzzzzzzzzzzzzzm_;
            };
            IEnumerable<Observation> mzzzzzzzzzzzzzzzx_ = context.Operators.Where<Observation>(lzzzzzzzzzzzzzzze_, mzzzzzzzzzzzzzzzw_);
            object mzzzzzzzzzzzzzzzy_(Observation @this)
            {
                DataType rzzzzzzzzzzzzzzzn_ = @this?.Effective;
                object rzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzn_);
                CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.toInterval(context, rzzzzzzzzzzzzzzzo_);
                CqlDateTime rzzzzzzzzzzzzzzzq_ = context.Operators.Start(rzzzzzzzzzzzzzzzp_);

                return rzzzzzzzzzzzzzzzq_;
            };
            IEnumerable<Observation> mzzzzzzzzzzzzzzzz_ = context.Operators.SortBy<Observation>(mzzzzzzzzzzzzzzzx_, mzzzzzzzzzzzzzzzy_, System.ComponentModel.ListSortDirection.Ascending);
            Observation nzzzzzzzzzzzzzzza_ = context.Operators.Last<Observation>(mzzzzzzzzzzzzzzzz_);
            List<Observation.ComponentComponent> nzzzzzzzzzzzzzzzb_ = nzzzzzzzzzzzzzzza_?.Component;
            bool? nzzzzzzzzzzzzzzzc_(Observation.ComponentComponent @this)
            {
                CodeableConcept rzzzzzzzzzzzzzzzr_ = @this?.Code;
                List<Coding> rzzzzzzzzzzzzzzzs_ = rzzzzzzzzzzzzzzzr_?.Coding;
                Coding rzzzzzzzzzzzzzzzt_ = context.Operators.First<Coding>((IEnumerable<Coding>)rzzzzzzzzzzzzzzzs_);
                FhirUri rzzzzzzzzzzzzzzzu_ = rzzzzzzzzzzzzzzzt_?.SystemElement;
                string rzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToString(context, rzzzzzzzzzzzzzzzu_);
                bool? rzzzzzzzzzzzzzzzw_ = context.Operators.Equal(rzzzzzzzzzzzzzzzv_, "http://loinc.org");
                List<Coding> rzzzzzzzzzzzzzzzy_ = rzzzzzzzzzzzzzzzr_?.Coding;
                Coding rzzzzzzzzzzzzzzzz_ = context.Operators.First<Coding>((IEnumerable<Coding>)rzzzzzzzzzzzzzzzy_);
                Code szzzzzzzzzzzzzzza_ = rzzzzzzzzzzzzzzzz_?.CodeElement;
                string szzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToString(context, szzzzzzzzzzzzzzza_);
                bool? szzzzzzzzzzzzzzzc_ = context.Operators.Equal(szzzzzzzzzzzzzzzb_, "8462-4");
                bool? szzzzzzzzzzzzzzzd_ = context.Operators.And(rzzzzzzzzzzzzzzzw_, szzzzzzzzzzzzzzzc_);

                return szzzzzzzzzzzzzzzd_;
            };
            IEnumerable<Observation.ComponentComponent> nzzzzzzzzzzzzzzzd_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)nzzzzzzzzzzzzzzzb_, nzzzzzzzzzzzzzzzc_);
            Observation.ComponentComponent nzzzzzzzzzzzzzzze_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(nzzzzzzzzzzzzzzzd_);
            DataType nzzzzzzzzzzzzzzzf_ = nzzzzzzzzzzzzzzze_?.Value;
            object nzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzf_);
            CqlQuantity nzzzzzzzzzzzzzzzh_ = context.Operators.Quantity(90m, "mm[Hg]");
            bool? nzzzzzzzzzzzzzzzi_ = context.Operators.GreaterOrEqual(nzzzzzzzzzzzzzzzg_ as CqlQuantity, nzzzzzzzzzzzzzzzh_);
            bool? nzzzzzzzzzzzzzzzj_ = context.Operators.Or(mzzzzzzzzzzzzzzzu_, nzzzzzzzzzzzzzzzi_);
            bool? nzzzzzzzzzzzzzzzk_ = context.Operators.And(mzzzzzzzzzzzzzzzg_, nzzzzzzzzzzzzzzzj_);
            IEnumerable<Encounter> nzzzzzzzzzzzzzzzl_ = this.Encounter_with_Hypertensive_Reading_Within_Year_Prior(context);
            bool? nzzzzzzzzzzzzzzzm_ = context.Operators.Exists<Encounter>(nzzzzzzzzzzzzzzzl_);
            bool? nzzzzzzzzzzzzzzzn_ = context.Operators.And(nzzzzzzzzzzzzzzzk_, nzzzzzzzzzzzzzzzm_);

            return nzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzd_ = context.Operators.Where<Encounter>(lzzzzzzzzzzzzzzzb_, lzzzzzzzzzzzzzzzc_);

        return lzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Second Hypertensive Reading SBP Greater than or Equal to 140 OR DBP Greater than or Equal to 90 Interventions")]
    public IEnumerable<ServiceRequest> Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90_Interventions(CqlContext context)
    {
        CqlValueSet szzzzzzzzzzzzzzze_ = this.Follow_Up_Within_4_Weeks(context);
        IEnumerable<ServiceRequest> szzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, szzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> szzzzzzzzzzzzzzzg_(ServiceRequest WeeksRescreen)
        {
            IEnumerable<ServiceRequest> szzzzzzzzzzzzzzzm_ = this.Laboratory_Test_or_ECG_for_Hypertension(context);
            bool? szzzzzzzzzzzzzzzn_(ServiceRequest ECGLabTest)
            {
                FhirDateTime szzzzzzzzzzzzzzzr_ = WeeksRescreen?.AuthoredOnElement;
                CqlDateTime szzzzzzzzzzzzzzzs_ = context.Operators.Convert<CqlDateTime>(szzzzzzzzzzzzzzzr_);
                CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzt_ = this.Measurement_Period(context);
                bool? szzzzzzzzzzzzzzzu_ = context.Operators.In<CqlDateTime>(szzzzzzzzzzzzzzzs_, szzzzzzzzzzzzzzzt_, "day");
                FhirDateTime szzzzzzzzzzzzzzzv_ = ECGLabTest?.AuthoredOnElement;
                CqlDateTime szzzzzzzzzzzzzzzw_ = context.Operators.Convert<CqlDateTime>(szzzzzzzzzzzzzzzv_);
                bool? szzzzzzzzzzzzzzzy_ = context.Operators.In<CqlDateTime>(szzzzzzzzzzzzzzzw_, szzzzzzzzzzzzzzzt_, "day");
                bool? szzzzzzzzzzzzzzzz_ = context.Operators.And(szzzzzzzzzzzzzzzu_, szzzzzzzzzzzzzzzy_);
                Code<RequestIntent> tzzzzzzzzzzzzzzza_ = WeeksRescreen?.IntentElement;
                RequestIntent? tzzzzzzzzzzzzzzzb_ = tzzzzzzzzzzzzzzza_?.Value;
                Code<RequestIntent> tzzzzzzzzzzzzzzzc_ = context.Operators.Convert<Code<RequestIntent>>(tzzzzzzzzzzzzzzzb_);
                bool? tzzzzzzzzzzzzzzzd_ = context.Operators.Equivalent(tzzzzzzzzzzzzzzzc_, "order");
                bool? tzzzzzzzzzzzzzzze_ = context.Operators.And(szzzzzzzzzzzzzzzz_, tzzzzzzzzzzzzzzzd_);
                Code<RequestIntent> tzzzzzzzzzzzzzzzf_ = ECGLabTest?.IntentElement;
                RequestIntent? tzzzzzzzzzzzzzzzg_ = tzzzzzzzzzzzzzzzf_?.Value;
                Code<RequestIntent> tzzzzzzzzzzzzzzzh_ = context.Operators.Convert<Code<RequestIntent>>(tzzzzzzzzzzzzzzzg_);
                bool? tzzzzzzzzzzzzzzzi_ = context.Operators.Equivalent(tzzzzzzzzzzzzzzzh_, "order");
                bool? tzzzzzzzzzzzzzzzj_ = context.Operators.And(tzzzzzzzzzzzzzzze_, tzzzzzzzzzzzzzzzi_);

                return tzzzzzzzzzzzzzzzj_;
            };
            IEnumerable<ServiceRequest> szzzzzzzzzzzzzzzo_ = context.Operators.Where<ServiceRequest>(szzzzzzzzzzzzzzzm_, szzzzzzzzzzzzzzzn_);
            ServiceRequest szzzzzzzzzzzzzzzp_(ServiceRequest ECGLabTest) =>
                WeeksRescreen;
            IEnumerable<ServiceRequest> szzzzzzzzzzzzzzzq_ = context.Operators.Select<ServiceRequest, ServiceRequest>(szzzzzzzzzzzzzzzo_, szzzzzzzzzzzzzzzp_);

            return szzzzzzzzzzzzzzzq_;
        };
        IEnumerable<ServiceRequest> szzzzzzzzzzzzzzzh_ = context.Operators.SelectMany<ServiceRequest, ServiceRequest>(szzzzzzzzzzzzzzzf_, szzzzzzzzzzzzzzzg_);
        IEnumerable<ServiceRequest> szzzzzzzzzzzzzzzi_(ServiceRequest WeeksRescreen)
        {
            IEnumerable<ServiceRequest> tzzzzzzzzzzzzzzzk_ = this.NonPharmacological_Interventions(context);
            bool? tzzzzzzzzzzzzzzzl_(ServiceRequest HTNInterventions)
            {
                FhirDateTime tzzzzzzzzzzzzzzzp_ = HTNInterventions?.AuthoredOnElement;
                CqlDateTime tzzzzzzzzzzzzzzzq_ = context.Operators.Convert<CqlDateTime>(tzzzzzzzzzzzzzzzp_);
                CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzr_ = this.Measurement_Period(context);
                bool? tzzzzzzzzzzzzzzzs_ = context.Operators.In<CqlDateTime>(tzzzzzzzzzzzzzzzq_, tzzzzzzzzzzzzzzzr_, "day");

                return tzzzzzzzzzzzzzzzs_;
            };
            IEnumerable<ServiceRequest> tzzzzzzzzzzzzzzzm_ = context.Operators.Where<ServiceRequest>(tzzzzzzzzzzzzzzzk_, tzzzzzzzzzzzzzzzl_);
            ServiceRequest tzzzzzzzzzzzzzzzn_(ServiceRequest HTNInterventions) =>
                WeeksRescreen;
            IEnumerable<ServiceRequest> tzzzzzzzzzzzzzzzo_ = context.Operators.Select<ServiceRequest, ServiceRequest>(tzzzzzzzzzzzzzzzm_, tzzzzzzzzzzzzzzzn_);

            return tzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<ServiceRequest> szzzzzzzzzzzzzzzj_ = context.Operators.SelectMany<ServiceRequest, ServiceRequest>(szzzzzzzzzzzzzzzh_, szzzzzzzzzzzzzzzi_);
        IEnumerable<ServiceRequest> szzzzzzzzzzzzzzzk_(ServiceRequest WeeksRescreen)
        {
            CqlValueSet tzzzzzzzzzzzzzzzt_ = this.Pharmacologic_Therapy_for_Hypertension(context);
            IEnumerable<MedicationRequest> tzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> tzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> tzzzzzzzzzzzzzzzx_ = context.Operators.Union<MedicationRequest>(tzzzzzzzzzzzzzzzu_, tzzzzzzzzzzzzzzzw_);
            bool? tzzzzzzzzzzzzzzzy_(MedicationRequest Medications)
            {
                FhirDateTime uzzzzzzzzzzzzzzzc_ = Medications?.AuthoredOnElement;
                CqlDateTime uzzzzzzzzzzzzzzzd_ = context.Operators.Convert<CqlDateTime>(uzzzzzzzzzzzzzzzc_);
                CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzze_ = this.Measurement_Period(context);
                bool? uzzzzzzzzzzzzzzzf_ = context.Operators.In<CqlDateTime>(uzzzzzzzzzzzzzzzd_, uzzzzzzzzzzzzzzze_, "day");
                Code<MedicationRequest.MedicationrequestStatus> uzzzzzzzzzzzzzzzg_ = Medications?.StatusElement;
                MedicationRequest.MedicationrequestStatus? uzzzzzzzzzzzzzzzh_ = uzzzzzzzzzzzzzzzg_?.Value;
                string uzzzzzzzzzzzzzzzi_ = context.Operators.Convert<string>(uzzzzzzzzzzzzzzzh_);
                bool? uzzzzzzzzzzzzzzzj_ = context.Operators.Equivalent(uzzzzzzzzzzzzzzzi_, "active");
                bool? uzzzzzzzzzzzzzzzk_ = context.Operators.And(uzzzzzzzzzzzzzzzf_, uzzzzzzzzzzzzzzzj_);

                return uzzzzzzzzzzzzzzzk_;
            };
            IEnumerable<MedicationRequest> tzzzzzzzzzzzzzzzz_ = context.Operators.Where<MedicationRequest>(tzzzzzzzzzzzzzzzx_, tzzzzzzzzzzzzzzzy_);
            ServiceRequest uzzzzzzzzzzzzzzza_(MedicationRequest Medications) =>
                WeeksRescreen;
            IEnumerable<ServiceRequest> uzzzzzzzzzzzzzzzb_ = context.Operators.Select<MedicationRequest, ServiceRequest>(tzzzzzzzzzzzzzzzz_, uzzzzzzzzzzzzzzza_);

            return uzzzzzzzzzzzzzzzb_;
        };
        IEnumerable<ServiceRequest> szzzzzzzzzzzzzzzl_ = context.Operators.SelectMany<ServiceRequest, ServiceRequest>(szzzzzzzzzzzzzzzj_, szzzzzzzzzzzzzzzk_);

        return szzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Encounter with Second Hypertensive Reading SBP Greater than or Equal to 140 OR DBP Greater than or Equal to 90 and Interventions")]
    public IEnumerable<Encounter> Encounter_with_Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90_and_Interventions(CqlContext context)
    {
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzl_ = this.Encounter_with_Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90(context);
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzm_(Encounter SecondHTNEncounterReading140Over90)
        {
            IEnumerable<ServiceRequest> uzzzzzzzzzzzzzzzs_ = this.Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90_Interventions(context);
            bool? uzzzzzzzzzzzzzzzt_(ServiceRequest SecondHTN140Over90Interventions)
            {
                FhirDateTime uzzzzzzzzzzzzzzzx_ = SecondHTN140Over90Interventions?.AuthoredOnElement;
                CqlDateTime uzzzzzzzzzzzzzzzy_ = context.Operators.Convert<CqlDateTime>(uzzzzzzzzzzzzzzzx_);
                Period uzzzzzzzzzzzzzzzz_ = SecondHTNEncounterReading140Over90?.Period;
                CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzzzzzzzzzzzz_);
                bool? vzzzzzzzzzzzzzzzb_ = context.Operators.In<CqlDateTime>(uzzzzzzzzzzzzzzzy_, vzzzzzzzzzzzzzzza_, "day");

                return vzzzzzzzzzzzzzzzb_;
            };
            IEnumerable<ServiceRequest> uzzzzzzzzzzzzzzzu_ = context.Operators.Where<ServiceRequest>(uzzzzzzzzzzzzzzzs_, uzzzzzzzzzzzzzzzt_);
            Encounter uzzzzzzzzzzzzzzzv_(ServiceRequest SecondHTN140Over90Interventions) =>
                SecondHTNEncounterReading140Over90;
            IEnumerable<Encounter> uzzzzzzzzzzzzzzzw_ = context.Operators.Select<ServiceRequest, Encounter>(uzzzzzzzzzzzzzzzu_, uzzzzzzzzzzzzzzzv_);

            return uzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzn_ = context.Operators.SelectMany<Encounter, Encounter>(uzzzzzzzzzzzzzzzl_, uzzzzzzzzzzzzzzzm_);
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzp_(Encounter SecondHTNEncounterReading140Over90)
        {
            IEnumerable<ServiceRequest> vzzzzzzzzzzzzzzzc_ = this.Referral_to_Alternate_or_Primary_Healthcare_Professional_for_Hypertensive_Reading(context);
            bool? vzzzzzzzzzzzzzzzd_(ServiceRequest ReferralToProfessional)
            {
                FhirDateTime vzzzzzzzzzzzzzzzh_ = ReferralToProfessional?.AuthoredOnElement;
                CqlDateTime vzzzzzzzzzzzzzzzi_ = context.Operators.Convert<CqlDateTime>(vzzzzzzzzzzzzzzzh_);
                Period vzzzzzzzzzzzzzzzj_ = SecondHTNEncounterReading140Over90?.Period;
                CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzzzzzzzzzzzzj_);
                bool? vzzzzzzzzzzzzzzzl_ = context.Operators.In<CqlDateTime>(vzzzzzzzzzzzzzzzi_, vzzzzzzzzzzzzzzzk_, "day");

                return vzzzzzzzzzzzzzzzl_;
            };
            IEnumerable<ServiceRequest> vzzzzzzzzzzzzzzze_ = context.Operators.Where<ServiceRequest>(vzzzzzzzzzzzzzzzc_, vzzzzzzzzzzzzzzzd_);
            Encounter vzzzzzzzzzzzzzzzf_(ServiceRequest ReferralToProfessional) =>
                SecondHTNEncounterReading140Over90;
            IEnumerable<Encounter> vzzzzzzzzzzzzzzzg_ = context.Operators.Select<ServiceRequest, Encounter>(vzzzzzzzzzzzzzzze_, vzzzzzzzzzzzzzzzf_);

            return vzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzq_ = context.Operators.SelectMany<Encounter, Encounter>(uzzzzzzzzzzzzzzzl_, uzzzzzzzzzzzzzzzp_);
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzr_ = context.Operators.Union<Encounter>(uzzzzzzzzzzzzzzzn_, uzzzzzzzzzzzzzzzq_);

        return uzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context)
    {
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzm_ = this.Encounter_with_Normal_Blood_Pressure_Reading(context);
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzn_ = this.Encounter_with_Elevated_Blood_Pressure_Reading_SBP_120_to_129_AND_DBP_less_than_80_and_Interventions(context);
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzo_ = context.Operators.Union<Encounter>(vzzzzzzzzzzzzzzzm_, vzzzzzzzzzzzzzzzn_);
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzp_ = this.Encounter_with_First_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_130_OR_DBP_Greater_than_or_Equal_to_80_and_Interventions(context);
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzq_ = this.Encounter_with_Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89_and_Interventions(context);
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzr_ = context.Operators.Union<Encounter>(vzzzzzzzzzzzzzzzp_, vzzzzzzzzzzzzzzzq_);
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzs_ = context.Operators.Union<Encounter>(vzzzzzzzzzzzzzzzo_, vzzzzzzzzzzzzzzzr_);
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzt_ = this.Encounter_with_Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90_and_Interventions(context);
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzu_ = context.Operators.Union<Encounter>(vzzzzzzzzzzzzzzzs_, vzzzzzzzzzzzzzzzt_);

        return vzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Encounter with Medical Reason for Not Obtaining or Patient Declined Blood Pressure Measurement")]
    public IEnumerable<Encounter> Encounter_with_Medical_Reason_for_Not_Obtaining_or_Patient_Declined_Blood_Pressure_Measurement(CqlContext context)
    {
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzv_ = this.Qualifying_Encounter_during_Measurement_Period(context);
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzw_(Encounter QualifyingEncounter)
        {
            CqlCode vzzzzzzzzzzzzzzzy_ = this.Systolic_blood_pressure(context);
            IEnumerable<CqlCode> vzzzzzzzzzzzzzzzz_ = context.Operators.ToList<CqlCode>(vzzzzzzzzzzzzzzzy_);
            IEnumerable<Observation> wzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, vzzzzzzzzzzzzzzzz_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observationnotdone"));
            CqlCode wzzzzzzzzzzzzzzzb_ = this.Diastolic_blood_pressure(context);
            IEnumerable<CqlCode> wzzzzzzzzzzzzzzzc_ = context.Operators.ToList<CqlCode>(wzzzzzzzzzzzzzzzb_);
            IEnumerable<Observation> wzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, wzzzzzzzzzzzzzzzc_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observationnotdone"));
            IEnumerable<Observation> wzzzzzzzzzzzzzzze_ = context.Operators.Union<Observation>(wzzzzzzzzzzzzzzza_, wzzzzzzzzzzzzzzzd_);
            bool? wzzzzzzzzzzzzzzzf_(Observation NoBPScreen)
            {
                Instant wzzzzzzzzzzzzzzzj_ = NoBPScreen?.IssuedElement;
                DateTimeOffset? wzzzzzzzzzzzzzzzk_ = wzzzzzzzzzzzzzzzj_?.Value;
                CqlDateTime wzzzzzzzzzzzzzzzl_ = context.Operators.Convert<CqlDateTime>(wzzzzzzzzzzzzzzzk_);
                Period wzzzzzzzzzzzzzzzm_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzzzzzzzzzzzm_);
                bool? wzzzzzzzzzzzzzzzo_ = context.Operators.In<CqlDateTime>(wzzzzzzzzzzzzzzzl_, wzzzzzzzzzzzzzzzn_, "day");
                bool? wzzzzzzzzzzzzzzzp_(Extension @this)
                {
                    string xzzzzzzzzzzzzzzzm_ = @this?.Url;
                    FhirString xzzzzzzzzzzzzzzzn_ = context.Operators.Convert<FhirString>(xzzzzzzzzzzzzzzzm_);
                    string xzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToString(context, xzzzzzzzzzzzzzzzn_);
                    bool? xzzzzzzzzzzzzzzzp_ = context.Operators.Equal(xzzzzzzzzzzzzzzzo_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-notDoneReason");

                    return xzzzzzzzzzzzzzzzp_;
                };
                IEnumerable<Extension> wzzzzzzzzzzzzzzzq_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(NoBPScreen is DomainResource
                        ? (NoBPScreen as DomainResource).Extension
                        : default), wzzzzzzzzzzzzzzzp_);
                object wzzzzzzzzzzzzzzzr_(Extension @this)
                {
                    DataType xzzzzzzzzzzzzzzzq_ = @this?.Value;

                    return xzzzzzzzzzzzzzzzq_;
                };
                IEnumerable<object> wzzzzzzzzzzzzzzzs_ = context.Operators.Select<Extension, object>(wzzzzzzzzzzzzzzzq_, wzzzzzzzzzzzzzzzr_);
                object wzzzzzzzzzzzzzzzt_ = context.Operators.SingletonFrom<object>(wzzzzzzzzzzzzzzzs_);
                CqlConcept wzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, wzzzzzzzzzzzzzzzt_ as CodeableConcept);
                CqlValueSet wzzzzzzzzzzzzzzzv_ = this.Patient_Declined(context);
                bool? wzzzzzzzzzzzzzzzw_ = context.Operators.ConceptInValueSet(wzzzzzzzzzzzzzzzu_, wzzzzzzzzzzzzzzzv_);
                bool? wzzzzzzzzzzzzzzzx_(Extension @this)
                {
                    string xzzzzzzzzzzzzzzzr_ = @this?.Url;
                    FhirString xzzzzzzzzzzzzzzzs_ = context.Operators.Convert<FhirString>(xzzzzzzzzzzzzzzzr_);
                    string xzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToString(context, xzzzzzzzzzzzzzzzs_);
                    bool? xzzzzzzzzzzzzzzzu_ = context.Operators.Equal(xzzzzzzzzzzzzzzzt_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-notDoneReason");

                    return xzzzzzzzzzzzzzzzu_;
                };
                IEnumerable<Extension> wzzzzzzzzzzzzzzzy_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(NoBPScreen is DomainResource
                        ? (NoBPScreen as DomainResource).Extension
                        : default), wzzzzzzzzzzzzzzzx_);
                object wzzzzzzzzzzzzzzzz_(Extension @this)
                {
                    DataType xzzzzzzzzzzzzzzzv_ = @this?.Value;

                    return xzzzzzzzzzzzzzzzv_;
                };
                IEnumerable<object> xzzzzzzzzzzzzzzza_ = context.Operators.Select<Extension, object>(wzzzzzzzzzzzzzzzy_, wzzzzzzzzzzzzzzzz_);
                object xzzzzzzzzzzzzzzzb_ = context.Operators.SingletonFrom<object>(xzzzzzzzzzzzzzzza_);
                CqlConcept xzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, xzzzzzzzzzzzzzzzb_ as CodeableConcept);
                CqlValueSet xzzzzzzzzzzzzzzzd_ = this.Medical_Reason(context);
                bool? xzzzzzzzzzzzzzzze_ = context.Operators.ConceptInValueSet(xzzzzzzzzzzzzzzzc_, xzzzzzzzzzzzzzzzd_);
                bool? xzzzzzzzzzzzzzzzf_ = context.Operators.Or(wzzzzzzzzzzzzzzzw_, xzzzzzzzzzzzzzzze_);
                bool? xzzzzzzzzzzzzzzzg_ = context.Operators.And(wzzzzzzzzzzzzzzzo_, xzzzzzzzzzzzzzzzf_);
                Code<ObservationStatus> xzzzzzzzzzzzzzzzh_ = NoBPScreen?.StatusElement;
                ObservationStatus? xzzzzzzzzzzzzzzzi_ = xzzzzzzzzzzzzzzzh_?.Value;
                Code<ObservationStatus> xzzzzzzzzzzzzzzzj_ = context.Operators.Convert<Code<ObservationStatus>>(xzzzzzzzzzzzzzzzi_);
                bool? xzzzzzzzzzzzzzzzk_ = context.Operators.Equal(xzzzzzzzzzzzzzzzj_, "cancelled");
                bool? xzzzzzzzzzzzzzzzl_ = context.Operators.And(xzzzzzzzzzzzzzzzg_, xzzzzzzzzzzzzzzzk_);

                return xzzzzzzzzzzzzzzzl_;
            };
            IEnumerable<Observation> wzzzzzzzzzzzzzzzg_ = context.Operators.Where<Observation>(wzzzzzzzzzzzzzzze_, wzzzzzzzzzzzzzzzf_);
            Encounter wzzzzzzzzzzzzzzzh_(Observation NoBPScreen) =>
                QualifyingEncounter;
            IEnumerable<Encounter> wzzzzzzzzzzzzzzzi_ = context.Operators.Select<Observation, Encounter>(wzzzzzzzzzzzzzzzg_, wzzzzzzzzzzzzzzzh_);

            return wzzzzzzzzzzzzzzzi_;
        };
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzx_ = context.Operators.SelectMany<Encounter, Encounter>(vzzzzzzzzzzzzzzzv_, vzzzzzzzzzzzzzzzw_);

        return vzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("NonPharmacological Intervention Not Ordered")]
    public IEnumerable<ServiceRequest> NonPharmacological_Intervention_Not_Ordered(CqlContext context)
    {
        CqlValueSet xzzzzzzzzzzzzzzzw_ = this.Lifestyle_Recommendation(context);
        IEnumerable<ServiceRequest> xzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> xzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> yzzzzzzzzzzzzzzza_ = context.Operators.Union<ServiceRequest>(xzzzzzzzzzzzzzzzx_, xzzzzzzzzzzzzzzzz_);
        CqlValueSet yzzzzzzzzzzzzzzzb_ = this.Weight_Reduction_Recommended(context);
        IEnumerable<ServiceRequest> yzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> yzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> yzzzzzzzzzzzzzzzf_ = context.Operators.Union<ServiceRequest>(yzzzzzzzzzzzzzzzc_, yzzzzzzzzzzzzzzze_);
        IEnumerable<ServiceRequest> yzzzzzzzzzzzzzzzg_ = context.Operators.Union<ServiceRequest>(yzzzzzzzzzzzzzzza_, yzzzzzzzzzzzzzzzf_);
        CqlValueSet yzzzzzzzzzzzzzzzh_ = this.Dietary_Recommendations(context);
        IEnumerable<ServiceRequest> yzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> yzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> yzzzzzzzzzzzzzzzl_ = context.Operators.Union<ServiceRequest>(yzzzzzzzzzzzzzzzi_, yzzzzzzzzzzzzzzzk_);
        IEnumerable<ServiceRequest> yzzzzzzzzzzzzzzzm_ = context.Operators.Union<ServiceRequest>(yzzzzzzzzzzzzzzzg_, yzzzzzzzzzzzzzzzl_);
        CqlValueSet yzzzzzzzzzzzzzzzn_ = this.Recommendation_to_Increase_Physical_Activity(context);
        IEnumerable<ServiceRequest> yzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> yzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> yzzzzzzzzzzzzzzzr_ = context.Operators.Union<ServiceRequest>(yzzzzzzzzzzzzzzzo_, yzzzzzzzzzzzzzzzq_);
        IEnumerable<ServiceRequest> yzzzzzzzzzzzzzzzs_ = context.Operators.Union<ServiceRequest>(yzzzzzzzzzzzzzzzm_, yzzzzzzzzzzzzzzzr_);
        CqlValueSet yzzzzzzzzzzzzzzzt_ = this.Referral_or_Counseling_for_Alcohol_Consumption(context);
        IEnumerable<ServiceRequest> yzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> yzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> yzzzzzzzzzzzzzzzx_ = context.Operators.Union<ServiceRequest>(yzzzzzzzzzzzzzzzu_, yzzzzzzzzzzzzzzzw_);
        IEnumerable<ServiceRequest> yzzzzzzzzzzzzzzzy_ = context.Operators.Union<ServiceRequest>(yzzzzzzzzzzzzzzzs_, yzzzzzzzzzzzzzzzx_);
        bool? yzzzzzzzzzzzzzzzz_(ServiceRequest NonPharmIntervention)
        {
            bool? zzzzzzzzzzzzzzzzb_(Extension @this)
            {
                string zzzzzzzzzzzzzzzzo_ = @this?.Url;
                FhirString zzzzzzzzzzzzzzzzp_ = context.Operators.Convert<FhirString>(zzzzzzzzzzzzzzzzo_);
                string zzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToString(context, zzzzzzzzzzzzzzzzp_);
                bool? zzzzzzzzzzzzzzzzr_ = context.Operators.Equal(zzzzzzzzzzzzzzzzq_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerformReason");

                return zzzzzzzzzzzzzzzzr_;
            };
            IEnumerable<Extension> zzzzzzzzzzzzzzzzc_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(NonPharmIntervention is DomainResource
                    ? (NonPharmIntervention as DomainResource).Extension
                    : default), zzzzzzzzzzzzzzzzb_);
            object zzzzzzzzzzzzzzzzd_(Extension @this)
            {
                DataType zzzzzzzzzzzzzzzzs_ = @this?.Value;

                return zzzzzzzzzzzzzzzzs_;
            };
            IEnumerable<object> zzzzzzzzzzzzzzzze_ = context.Operators.Select<Extension, object>(zzzzzzzzzzzzzzzzc_, zzzzzzzzzzzzzzzzd_);
            object zzzzzzzzzzzzzzzzf_ = context.Operators.SingletonFrom<object>(zzzzzzzzzzzzzzzze_);
            CqlConcept zzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, zzzzzzzzzzzzzzzzf_ as CodeableConcept);
            CqlValueSet zzzzzzzzzzzzzzzzh_ = this.Patient_Declined(context);
            bool? zzzzzzzzzzzzzzzzi_ = context.Operators.ConceptInValueSet(zzzzzzzzzzzzzzzzg_, zzzzzzzzzzzzzzzzh_);
            Code<RequestStatus> zzzzzzzzzzzzzzzzj_ = NonPharmIntervention?.StatusElement;
            RequestStatus? zzzzzzzzzzzzzzzzk_ = zzzzzzzzzzzzzzzzj_?.Value;
            Code<RequestStatus> zzzzzzzzzzzzzzzzl_ = context.Operators.Convert<Code<RequestStatus>>(zzzzzzzzzzzzzzzzk_);
            bool? zzzzzzzzzzzzzzzzm_ = context.Operators.Equal(zzzzzzzzzzzzzzzzl_, "completed");
            bool? zzzzzzzzzzzzzzzzn_ = context.Operators.And(zzzzzzzzzzzzzzzzi_, zzzzzzzzzzzzzzzzm_);

            return zzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<ServiceRequest> zzzzzzzzzzzzzzzza_ = context.Operators.Where<ServiceRequest>(yzzzzzzzzzzzzzzzy_, yzzzzzzzzzzzzzzzz_);

        return zzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Laboratory Test or ECG for Hypertension Not Ordered")]
    public IEnumerable<ServiceRequest> Laboratory_Test_or_ECG_for_Hypertension_Not_Ordered(CqlContext context)
    {
        CqlCode zzzzzzzzzzzzzzzzt_ = this._12_lead_EKG_panel(context);
        IEnumerable<CqlCode> zzzzzzzzzzzzzzzzu_ = context.Operators.ToList<CqlCode>(zzzzzzzzzzzzzzzzt_);
        IEnumerable<ServiceRequest> zzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, default, zzzzzzzzzzzzzzzzu_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        CqlCode zzzzzzzzzzzzzzzzw_ = this.EKG_study(context);
        IEnumerable<CqlCode> zzzzzzzzzzzzzzzzx_ = context.Operators.ToList<CqlCode>(zzzzzzzzzzzzzzzzw_);
        IEnumerable<ServiceRequest> zzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, default, zzzzzzzzzzzzzzzzx_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> zzzzzzzzzzzzzzzzz_ = context.Operators.Union<ServiceRequest>(zzzzzzzzzzzzzzzzv_, zzzzzzzzzzzzzzzzy_);
        CqlValueSet azzzzzzzzzzzzzzzza_ = this.Laboratory_Tests_for_Hypertension(context);
        IEnumerable<ServiceRequest> azzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, azzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> azzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, azzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> azzzzzzzzzzzzzzzze_ = context.Operators.Union<ServiceRequest>(azzzzzzzzzzzzzzzzb_, azzzzzzzzzzzzzzzzd_);
        IEnumerable<ServiceRequest> azzzzzzzzzzzzzzzzf_ = context.Operators.Union<ServiceRequest>(zzzzzzzzzzzzzzzzz_, azzzzzzzzzzzzzzzze_);
        bool? azzzzzzzzzzzzzzzzg_(ServiceRequest LabECGNotDone)
        {
            bool? azzzzzzzzzzzzzzzzi_(Extension @this)
            {
                string azzzzzzzzzzzzzzzzq_ = @this?.Url;
                FhirString azzzzzzzzzzzzzzzzr_ = context.Operators.Convert<FhirString>(azzzzzzzzzzzzzzzzq_);
                string azzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToString(context, azzzzzzzzzzzzzzzzr_);
                bool? azzzzzzzzzzzzzzzzt_ = context.Operators.Equal(azzzzzzzzzzzzzzzzs_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerformReason");

                return azzzzzzzzzzzzzzzzt_;
            };
            IEnumerable<Extension> azzzzzzzzzzzzzzzzj_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(LabECGNotDone is DomainResource
                    ? (LabECGNotDone as DomainResource).Extension
                    : default), azzzzzzzzzzzzzzzzi_);
            object azzzzzzzzzzzzzzzzk_(Extension @this)
            {
                DataType azzzzzzzzzzzzzzzzu_ = @this?.Value;

                return azzzzzzzzzzzzzzzzu_;
            };
            IEnumerable<object> azzzzzzzzzzzzzzzzl_ = context.Operators.Select<Extension, object>(azzzzzzzzzzzzzzzzj_, azzzzzzzzzzzzzzzzk_);
            object azzzzzzzzzzzzzzzzm_ = context.Operators.SingletonFrom<object>(azzzzzzzzzzzzzzzzl_);
            CqlConcept azzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, azzzzzzzzzzzzzzzzm_ as CodeableConcept);
            CqlValueSet azzzzzzzzzzzzzzzzo_ = this.Patient_Declined(context);
            bool? azzzzzzzzzzzzzzzzp_ = context.Operators.ConceptInValueSet(azzzzzzzzzzzzzzzzn_, azzzzzzzzzzzzzzzzo_);

            return azzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<ServiceRequest> azzzzzzzzzzzzzzzzh_ = context.Operators.Where<ServiceRequest>(azzzzzzzzzzzzzzzzf_, azzzzzzzzzzzzzzzzg_);

        return azzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Second Hypertensive Reading SBP 130 to 139 OR DBP 80 to 89 Interventions Declined")]
    public IEnumerable<ServiceRequest> Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89_Interventions_Declined(CqlContext context)
    {
        CqlValueSet azzzzzzzzzzzzzzzzv_ = this.Referral_to_Primary_Care_or_Alternate_Provider(context);
        IEnumerable<ServiceRequest> azzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> azzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> azzzzzzzzzzzzzzzzz_ = context.Operators.Union<ServiceRequest>(azzzzzzzzzzzzzzzzw_, azzzzzzzzzzzzzzzzy_);
        CqlValueSet bzzzzzzzzzzzzzzzza_ = this.Follow_Up_Within_6_Months(context);
        IEnumerable<ServiceRequest> bzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> bzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> bzzzzzzzzzzzzzzzze_ = context.Operators.Union<ServiceRequest>(bzzzzzzzzzzzzzzzzb_, bzzzzzzzzzzzzzzzzd_);
        IEnumerable<ServiceRequest> bzzzzzzzzzzzzzzzzf_ = context.Operators.Union<ServiceRequest>(azzzzzzzzzzzzzzzzz_, bzzzzzzzzzzzzzzzze_);
        bool? bzzzzzzzzzzzzzzzzg_(ServiceRequest SecondHTNDeclinedReferralAndFollowUp)
        {
            bool? bzzzzzzzzzzzzzzzzm_(Extension @this)
            {
                string bzzzzzzzzzzzzzzzzz_ = @this?.Url;
                FhirString czzzzzzzzzzzzzzzza_ = context.Operators.Convert<FhirString>(bzzzzzzzzzzzzzzzzz_);
                string czzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToString(context, czzzzzzzzzzzzzzzza_);
                bool? czzzzzzzzzzzzzzzzc_ = context.Operators.Equal(czzzzzzzzzzzzzzzzb_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerformReason");

                return czzzzzzzzzzzzzzzzc_;
            };
            IEnumerable<Extension> bzzzzzzzzzzzzzzzzn_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(SecondHTNDeclinedReferralAndFollowUp is DomainResource
                    ? (SecondHTNDeclinedReferralAndFollowUp as DomainResource).Extension
                    : default), bzzzzzzzzzzzzzzzzm_);
            object bzzzzzzzzzzzzzzzzo_(Extension @this)
            {
                DataType czzzzzzzzzzzzzzzzd_ = @this?.Value;

                return czzzzzzzzzzzzzzzzd_;
            };
            IEnumerable<object> bzzzzzzzzzzzzzzzzp_ = context.Operators.Select<Extension, object>(bzzzzzzzzzzzzzzzzn_, bzzzzzzzzzzzzzzzzo_);
            object bzzzzzzzzzzzzzzzzq_ = context.Operators.SingletonFrom<object>(bzzzzzzzzzzzzzzzzp_);
            CqlConcept bzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bzzzzzzzzzzzzzzzzq_ as CodeableConcept);
            CqlValueSet bzzzzzzzzzzzzzzzzs_ = this.Patient_Declined(context);
            bool? bzzzzzzzzzzzzzzzzt_ = context.Operators.ConceptInValueSet(bzzzzzzzzzzzzzzzzr_, bzzzzzzzzzzzzzzzzs_);
            Code<RequestStatus> bzzzzzzzzzzzzzzzzu_ = SecondHTNDeclinedReferralAndFollowUp?.StatusElement;
            RequestStatus? bzzzzzzzzzzzzzzzzv_ = bzzzzzzzzzzzzzzzzu_?.Value;
            Code<RequestStatus> bzzzzzzzzzzzzzzzzw_ = context.Operators.Convert<Code<RequestStatus>>(bzzzzzzzzzzzzzzzzv_);
            bool? bzzzzzzzzzzzzzzzzx_ = context.Operators.Equal(bzzzzzzzzzzzzzzzzw_, "completed");
            bool? bzzzzzzzzzzzzzzzzy_ = context.Operators.And(bzzzzzzzzzzzzzzzzt_, bzzzzzzzzzzzzzzzzx_);

            return bzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<ServiceRequest> bzzzzzzzzzzzzzzzzh_ = context.Operators.Where<ServiceRequest>(bzzzzzzzzzzzzzzzzf_, bzzzzzzzzzzzzzzzzg_);
        IEnumerable<ServiceRequest> bzzzzzzzzzzzzzzzzi_ = this.Laboratory_Test_or_ECG_for_Hypertension_Not_Ordered(context);
        IEnumerable<ServiceRequest> bzzzzzzzzzzzzzzzzj_ = context.Operators.Union<ServiceRequest>(bzzzzzzzzzzzzzzzzh_, bzzzzzzzzzzzzzzzzi_);
        IEnumerable<ServiceRequest> bzzzzzzzzzzzzzzzzk_ = this.NonPharmacological_Intervention_Not_Ordered(context);
        IEnumerable<ServiceRequest> bzzzzzzzzzzzzzzzzl_ = context.Operators.Union<ServiceRequest>(bzzzzzzzzzzzzzzzzj_, bzzzzzzzzzzzzzzzzk_);

        return bzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Second Hypertensive Reading SBP Greater than or Equal to 140 OR DBP Greater than or Equal to 90 Interventions Declined")]
    public IEnumerable<object> Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90_Interventions_Declined(CqlContext context)
    {
        CqlValueSet czzzzzzzzzzzzzzzze_ = this.Referral_to_Primary_Care_or_Alternate_Provider(context);
        IEnumerable<ServiceRequest> czzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, czzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> czzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, czzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> czzzzzzzzzzzzzzzzi_ = context.Operators.Union<ServiceRequest>(czzzzzzzzzzzzzzzzf_, czzzzzzzzzzzzzzzzh_);
        CqlValueSet czzzzzzzzzzzzzzzzj_ = this.Follow_Up_Within_4_Weeks(context);
        IEnumerable<ServiceRequest> czzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> czzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> czzzzzzzzzzzzzzzzn_ = context.Operators.Union<ServiceRequest>(czzzzzzzzzzzzzzzzk_, czzzzzzzzzzzzzzzzm_);
        IEnumerable<ServiceRequest> czzzzzzzzzzzzzzzzo_ = context.Operators.Union<ServiceRequest>(czzzzzzzzzzzzzzzzi_, czzzzzzzzzzzzzzzzn_);
        bool? czzzzzzzzzzzzzzzzp_(ServiceRequest SecondHTN140Over90ReferralFollowUpNotDone)
        {
            bool? dzzzzzzzzzzzzzzzzd_(Extension @this)
            {
                string dzzzzzzzzzzzzzzzzq_ = @this?.Url;
                FhirString dzzzzzzzzzzzzzzzzr_ = context.Operators.Convert<FhirString>(dzzzzzzzzzzzzzzzzq_);
                string dzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToString(context, dzzzzzzzzzzzzzzzzr_);
                bool? dzzzzzzzzzzzzzzzzt_ = context.Operators.Equal(dzzzzzzzzzzzzzzzzs_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerformReason");

                return dzzzzzzzzzzzzzzzzt_;
            };
            IEnumerable<Extension> dzzzzzzzzzzzzzzzze_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(SecondHTN140Over90ReferralFollowUpNotDone is DomainResource
                    ? (SecondHTN140Over90ReferralFollowUpNotDone as DomainResource).Extension
                    : default), dzzzzzzzzzzzzzzzzd_);
            object dzzzzzzzzzzzzzzzzf_(Extension @this)
            {
                DataType dzzzzzzzzzzzzzzzzu_ = @this?.Value;

                return dzzzzzzzzzzzzzzzzu_;
            };
            IEnumerable<object> dzzzzzzzzzzzzzzzzg_ = context.Operators.Select<Extension, object>(dzzzzzzzzzzzzzzzze_, dzzzzzzzzzzzzzzzzf_);
            object dzzzzzzzzzzzzzzzzh_ = context.Operators.SingletonFrom<object>(dzzzzzzzzzzzzzzzzg_);
            CqlConcept dzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, dzzzzzzzzzzzzzzzzh_ as CodeableConcept);
            CqlValueSet dzzzzzzzzzzzzzzzzj_ = this.Patient_Declined(context);
            bool? dzzzzzzzzzzzzzzzzk_ = context.Operators.ConceptInValueSet(dzzzzzzzzzzzzzzzzi_, dzzzzzzzzzzzzzzzzj_);
            Code<RequestStatus> dzzzzzzzzzzzzzzzzl_ = SecondHTN140Over90ReferralFollowUpNotDone?.StatusElement;
            RequestStatus? dzzzzzzzzzzzzzzzzm_ = dzzzzzzzzzzzzzzzzl_?.Value;
            Code<RequestStatus> dzzzzzzzzzzzzzzzzn_ = context.Operators.Convert<Code<RequestStatus>>(dzzzzzzzzzzzzzzzzm_);
            bool? dzzzzzzzzzzzzzzzzo_ = context.Operators.Equal(dzzzzzzzzzzzzzzzzn_, "completed");
            bool? dzzzzzzzzzzzzzzzzp_ = context.Operators.And(dzzzzzzzzzzzzzzzzk_, dzzzzzzzzzzzzzzzzo_);

            return dzzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<ServiceRequest> czzzzzzzzzzzzzzzzq_ = context.Operators.Where<ServiceRequest>(czzzzzzzzzzzzzzzzo_, czzzzzzzzzzzzzzzzp_);
        CqlValueSet czzzzzzzzzzzzzzzzr_ = this.Pharmacologic_Therapy_for_Hypertension(context);
        IEnumerable<MedicationRequest> czzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-mednotrequested"));
        IEnumerable<MedicationRequest> czzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-mednotrequested"));
        IEnumerable<MedicationRequest> czzzzzzzzzzzzzzzzv_ = context.Operators.Union<MedicationRequest>(czzzzzzzzzzzzzzzzs_, czzzzzzzzzzzzzzzzu_);
        bool? czzzzzzzzzzzzzzzzw_(MedicationRequest MedicationRequestNotOrdered)
        {
            Code<MedicationRequest.MedicationrequestStatus> dzzzzzzzzzzzzzzzzv_ = MedicationRequestNotOrdered?.StatusElement;
            MedicationRequest.MedicationrequestStatus? dzzzzzzzzzzzzzzzzw_ = dzzzzzzzzzzzzzzzzv_?.Value;
            string dzzzzzzzzzzzzzzzzx_ = context.Operators.Convert<string>(dzzzzzzzzzzzzzzzzw_);
            bool? dzzzzzzzzzzzzzzzzy_ = context.Operators.Equal(dzzzzzzzzzzzzzzzzx_, "completed");

            return dzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<MedicationRequest> czzzzzzzzzzzzzzzzx_ = context.Operators.Where<MedicationRequest>(czzzzzzzzzzzzzzzzv_, czzzzzzzzzzzzzzzzw_);
        IEnumerable<object> czzzzzzzzzzzzzzzzy_ = context.Operators.Union<object>(czzzzzzzzzzzzzzzzq_ as IEnumerable<object>, czzzzzzzzzzzzzzzzx_ as IEnumerable<object>);
        IEnumerable<ServiceRequest> czzzzzzzzzzzzzzzzz_ = this.Laboratory_Test_or_ECG_for_Hypertension_Not_Ordered(context);
        IEnumerable<object> dzzzzzzzzzzzzzzzza_ = context.Operators.Union<object>(czzzzzzzzzzzzzzzzy_ as IEnumerable<object>, czzzzzzzzzzzzzzzzz_ as IEnumerable<object>);
        IEnumerable<ServiceRequest> dzzzzzzzzzzzzzzzzb_ = this.NonPharmacological_Intervention_Not_Ordered(context);
        IEnumerable<object> dzzzzzzzzzzzzzzzzc_ = context.Operators.Union<object>(dzzzzzzzzzzzzzzzza_ as IEnumerable<object>, dzzzzzzzzzzzzzzzzb_ as IEnumerable<object>);

        return dzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Encounter with Order for Hypertension Follow Up Declined by Patient")]
    public IEnumerable<Encounter> Encounter_with_Order_for_Hypertension_Follow_Up_Declined_by_Patient(CqlContext context)
    {
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzz_ = this.Encounter_with_Elevated_Blood_Pressure_Reading_SBP_120_to_129_AND_DBP_less_than_80(context);
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzza_(Encounter ElevatedBPEncounter)
        {
            CqlValueSet ezzzzzzzzzzzzzzzzw_ = this.Referral_to_Primary_Care_or_Alternate_Provider(context);
            IEnumerable<ServiceRequest> ezzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
            IEnumerable<ServiceRequest> ezzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
            IEnumerable<ServiceRequest> fzzzzzzzzzzzzzzzza_ = context.Operators.Union<ServiceRequest>(ezzzzzzzzzzzzzzzzx_, ezzzzzzzzzzzzzzzzz_);
            CqlValueSet fzzzzzzzzzzzzzzzzb_ = this.Follow_Up_Within_6_Months(context);
            IEnumerable<ServiceRequest> fzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
            IEnumerable<ServiceRequest> fzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
            IEnumerable<ServiceRequest> fzzzzzzzzzzzzzzzzf_ = context.Operators.Union<ServiceRequest>(fzzzzzzzzzzzzzzzzc_, fzzzzzzzzzzzzzzzze_);
            IEnumerable<ServiceRequest> fzzzzzzzzzzzzzzzzg_ = context.Operators.Union<ServiceRequest>(fzzzzzzzzzzzzzzzza_, fzzzzzzzzzzzzzzzzf_);
            bool? fzzzzzzzzzzzzzzzzh_(ServiceRequest ElevatedBPDeclinedInterventions)
            {
                bool? fzzzzzzzzzzzzzzzzl_(Extension @this)
                {
                    string gzzzzzzzzzzzzzzzze_ = @this?.Url;
                    FhirString gzzzzzzzzzzzzzzzzf_ = context.Operators.Convert<FhirString>(gzzzzzzzzzzzzzzzze_);
                    string gzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToString(context, gzzzzzzzzzzzzzzzzf_);
                    bool? gzzzzzzzzzzzzzzzzh_ = context.Operators.Equal(gzzzzzzzzzzzzzzzzg_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerformReason");

                    return gzzzzzzzzzzzzzzzzh_;
                };
                IEnumerable<Extension> fzzzzzzzzzzzzzzzzm_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(ElevatedBPDeclinedInterventions is DomainResource
                        ? (ElevatedBPDeclinedInterventions as DomainResource).Extension
                        : default), fzzzzzzzzzzzzzzzzl_);
                object fzzzzzzzzzzzzzzzzn_(Extension @this)
                {
                    DataType gzzzzzzzzzzzzzzzzi_ = @this?.Value;

                    return gzzzzzzzzzzzzzzzzi_;
                };
                IEnumerable<object> fzzzzzzzzzzzzzzzzo_ = context.Operators.Select<Extension, object>(fzzzzzzzzzzzzzzzzm_, fzzzzzzzzzzzzzzzzn_);
                object fzzzzzzzzzzzzzzzzp_ = context.Operators.SingletonFrom<object>(fzzzzzzzzzzzzzzzzo_);
                CqlConcept fzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, fzzzzzzzzzzzzzzzzp_ as CodeableConcept);
                CqlValueSet fzzzzzzzzzzzzzzzzr_ = this.Patient_Declined(context);
                bool? fzzzzzzzzzzzzzzzzs_ = context.Operators.ConceptInValueSet(fzzzzzzzzzzzzzzzzq_, fzzzzzzzzzzzzzzzzr_);
                FhirDateTime fzzzzzzzzzzzzzzzzt_ = ElevatedBPDeclinedInterventions?.AuthoredOnElement;
                CqlDateTime fzzzzzzzzzzzzzzzzu_ = context.Operators.Convert<CqlDateTime>(fzzzzzzzzzzzzzzzzt_);
                Period fzzzzzzzzzzzzzzzzv_ = ElevatedBPEncounter?.Period;
                CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzzzzzzzzzzzzv_);
                bool? fzzzzzzzzzzzzzzzzx_ = context.Operators.In<CqlDateTime>(fzzzzzzzzzzzzzzzzu_, fzzzzzzzzzzzzzzzzw_, "day");
                bool? fzzzzzzzzzzzzzzzzy_ = context.Operators.And(fzzzzzzzzzzzzzzzzs_, fzzzzzzzzzzzzzzzzx_);
                Code<RequestStatus> fzzzzzzzzzzzzzzzzz_ = ElevatedBPDeclinedInterventions?.StatusElement;
                RequestStatus? gzzzzzzzzzzzzzzzza_ = fzzzzzzzzzzzzzzzzz_?.Value;
                Code<RequestStatus> gzzzzzzzzzzzzzzzzb_ = context.Operators.Convert<Code<RequestStatus>>(gzzzzzzzzzzzzzzzza_);
                bool? gzzzzzzzzzzzzzzzzc_ = context.Operators.Equal(gzzzzzzzzzzzzzzzzb_, "completed");
                bool? gzzzzzzzzzzzzzzzzd_ = context.Operators.And(fzzzzzzzzzzzzzzzzy_, gzzzzzzzzzzzzzzzzc_);

                return gzzzzzzzzzzzzzzzzd_;
            };
            IEnumerable<ServiceRequest> fzzzzzzzzzzzzzzzzi_ = context.Operators.Where<ServiceRequest>(fzzzzzzzzzzzzzzzzg_, fzzzzzzzzzzzzzzzzh_);
            Encounter fzzzzzzzzzzzzzzzzj_(ServiceRequest ElevatedBPDeclinedInterventions) =>
                ElevatedBPEncounter;
            IEnumerable<Encounter> fzzzzzzzzzzzzzzzzk_ = context.Operators.Select<ServiceRequest, Encounter>(fzzzzzzzzzzzzzzzzi_, fzzzzzzzzzzzzzzzzj_);

            return fzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzb_ = context.Operators.SelectMany<Encounter, Encounter>(dzzzzzzzzzzzzzzzzz_, ezzzzzzzzzzzzzzzza_);
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzd_(Encounter ElevatedBPEncounter)
        {
            IEnumerable<ServiceRequest> gzzzzzzzzzzzzzzzzj_ = this.NonPharmacological_Intervention_Not_Ordered(context);
            bool? gzzzzzzzzzzzzzzzzk_(ServiceRequest NotOrdered)
            {
                FhirDateTime gzzzzzzzzzzzzzzzzo_ = NotOrdered?.AuthoredOnElement;
                CqlDateTime gzzzzzzzzzzzzzzzzp_ = context.Operators.Convert<CqlDateTime>(gzzzzzzzzzzzzzzzzo_);
                Period gzzzzzzzzzzzzzzzzq_ = ElevatedBPEncounter?.Period;
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzzzzzzzzzzzq_);
                bool? gzzzzzzzzzzzzzzzzs_ = context.Operators.In<CqlDateTime>(gzzzzzzzzzzzzzzzzp_, gzzzzzzzzzzzzzzzzr_, "day");

                return gzzzzzzzzzzzzzzzzs_;
            };
            IEnumerable<ServiceRequest> gzzzzzzzzzzzzzzzzl_ = context.Operators.Where<ServiceRequest>(gzzzzzzzzzzzzzzzzj_, gzzzzzzzzzzzzzzzzk_);
            Encounter gzzzzzzzzzzzzzzzzm_(ServiceRequest NotOrdered) =>
                ElevatedBPEncounter;
            IEnumerable<Encounter> gzzzzzzzzzzzzzzzzn_ = context.Operators.Select<ServiceRequest, Encounter>(gzzzzzzzzzzzzzzzzl_, gzzzzzzzzzzzzzzzzm_);

            return gzzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzze_ = context.Operators.SelectMany<Encounter, Encounter>(dzzzzzzzzzzzzzzzzz_, ezzzzzzzzzzzzzzzzd_);
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzf_ = context.Operators.Union<Encounter>(ezzzzzzzzzzzzzzzzb_, ezzzzzzzzzzzzzzzze_);
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzg_ = this.Encounter_with_First_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_130_OR_DBP_Greater_than_or_Equal_to_80(context);
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzh_(Encounter FirstHTNEncounter)
        {
            CqlValueSet gzzzzzzzzzzzzzzzzt_ = this.Follow_Up_Within_4_Weeks(context);
            IEnumerable<ServiceRequest> gzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
            IEnumerable<ServiceRequest> gzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
            IEnumerable<ServiceRequest> gzzzzzzzzzzzzzzzzx_ = context.Operators.Union<ServiceRequest>(gzzzzzzzzzzzzzzzzu_, gzzzzzzzzzzzzzzzzw_);
            CqlValueSet gzzzzzzzzzzzzzzzzy_ = this.Referral_to_Primary_Care_or_Alternate_Provider(context);
            IEnumerable<ServiceRequest> gzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
            IEnumerable<ServiceRequest> hzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
            IEnumerable<ServiceRequest> hzzzzzzzzzzzzzzzzc_ = context.Operators.Union<ServiceRequest>(gzzzzzzzzzzzzzzzzz_, hzzzzzzzzzzzzzzzzb_);
            IEnumerable<ServiceRequest> hzzzzzzzzzzzzzzzzd_ = context.Operators.Union<ServiceRequest>(gzzzzzzzzzzzzzzzzx_, hzzzzzzzzzzzzzzzzc_);
            bool? hzzzzzzzzzzzzzzzze_(ServiceRequest FirstHTNDeclinedInterventions)
            {
                bool? hzzzzzzzzzzzzzzzzi_(Extension @this)
                {
                    string izzzzzzzzzzzzzzzzb_ = @this?.Url;
                    FhirString izzzzzzzzzzzzzzzzc_ = context.Operators.Convert<FhirString>(izzzzzzzzzzzzzzzzb_);
                    string izzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToString(context, izzzzzzzzzzzzzzzzc_);
                    bool? izzzzzzzzzzzzzzzze_ = context.Operators.Equal(izzzzzzzzzzzzzzzzd_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerformReason");

                    return izzzzzzzzzzzzzzzze_;
                };
                IEnumerable<Extension> hzzzzzzzzzzzzzzzzj_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(FirstHTNDeclinedInterventions is DomainResource
                        ? (FirstHTNDeclinedInterventions as DomainResource).Extension
                        : default), hzzzzzzzzzzzzzzzzi_);
                object hzzzzzzzzzzzzzzzzk_(Extension @this)
                {
                    DataType izzzzzzzzzzzzzzzzf_ = @this?.Value;

                    return izzzzzzzzzzzzzzzzf_;
                };
                IEnumerable<object> hzzzzzzzzzzzzzzzzl_ = context.Operators.Select<Extension, object>(hzzzzzzzzzzzzzzzzj_, hzzzzzzzzzzzzzzzzk_);
                object hzzzzzzzzzzzzzzzzm_ = context.Operators.SingletonFrom<object>(hzzzzzzzzzzzzzzzzl_);
                CqlConcept hzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, hzzzzzzzzzzzzzzzzm_ as CodeableConcept);
                CqlValueSet hzzzzzzzzzzzzzzzzo_ = this.Patient_Declined(context);
                bool? hzzzzzzzzzzzzzzzzp_ = context.Operators.ConceptInValueSet(hzzzzzzzzzzzzzzzzn_, hzzzzzzzzzzzzzzzzo_);
                FhirDateTime hzzzzzzzzzzzzzzzzq_ = FirstHTNDeclinedInterventions?.AuthoredOnElement;
                CqlDateTime hzzzzzzzzzzzzzzzzr_ = context.Operators.Convert<CqlDateTime>(hzzzzzzzzzzzzzzzzq_);
                Period hzzzzzzzzzzzzzzzzs_ = FirstHTNEncounter?.Period;
                CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzzzzzzzzzzzs_);
                bool? hzzzzzzzzzzzzzzzzu_ = context.Operators.In<CqlDateTime>(hzzzzzzzzzzzzzzzzr_, hzzzzzzzzzzzzzzzzt_, "day");
                bool? hzzzzzzzzzzzzzzzzv_ = context.Operators.And(hzzzzzzzzzzzzzzzzp_, hzzzzzzzzzzzzzzzzu_);
                Code<RequestStatus> hzzzzzzzzzzzzzzzzw_ = FirstHTNDeclinedInterventions?.StatusElement;
                RequestStatus? hzzzzzzzzzzzzzzzzx_ = hzzzzzzzzzzzzzzzzw_?.Value;
                Code<RequestStatus> hzzzzzzzzzzzzzzzzy_ = context.Operators.Convert<Code<RequestStatus>>(hzzzzzzzzzzzzzzzzx_);
                bool? hzzzzzzzzzzzzzzzzz_ = context.Operators.Equal(hzzzzzzzzzzzzzzzzy_, "completed");
                bool? izzzzzzzzzzzzzzzza_ = context.Operators.And(hzzzzzzzzzzzzzzzzv_, hzzzzzzzzzzzzzzzzz_);

                return izzzzzzzzzzzzzzzza_;
            };
            IEnumerable<ServiceRequest> hzzzzzzzzzzzzzzzzf_ = context.Operators.Where<ServiceRequest>(hzzzzzzzzzzzzzzzzd_, hzzzzzzzzzzzzzzzze_);
            Encounter hzzzzzzzzzzzzzzzzg_(ServiceRequest FirstHTNDeclinedInterventions) =>
                FirstHTNEncounter;
            IEnumerable<Encounter> hzzzzzzzzzzzzzzzzh_ = context.Operators.Select<ServiceRequest, Encounter>(hzzzzzzzzzzzzzzzzf_, hzzzzzzzzzzzzzzzzg_);

            return hzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzi_ = context.Operators.SelectMany<Encounter, Encounter>(ezzzzzzzzzzzzzzzzg_, ezzzzzzzzzzzzzzzzh_);
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzk_(Encounter FirstHTNEncounter)
        {
            IEnumerable<ServiceRequest> izzzzzzzzzzzzzzzzg_ = this.NonPharmacological_Intervention_Not_Ordered(context);
            bool? izzzzzzzzzzzzzzzzh_(ServiceRequest NoNonPharm)
            {
                FhirDateTime izzzzzzzzzzzzzzzzl_ = NoNonPharm?.AuthoredOnElement;
                CqlDateTime izzzzzzzzzzzzzzzzm_ = context.Operators.Convert<CqlDateTime>(izzzzzzzzzzzzzzzzl_);
                Period izzzzzzzzzzzzzzzzn_ = FirstHTNEncounter?.Period;
                CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzzzzzzzzzzzn_);
                bool? izzzzzzzzzzzzzzzzp_ = context.Operators.In<CqlDateTime>(izzzzzzzzzzzzzzzzm_, izzzzzzzzzzzzzzzzo_, "day");

                return izzzzzzzzzzzzzzzzp_;
            };
            IEnumerable<ServiceRequest> izzzzzzzzzzzzzzzzi_ = context.Operators.Where<ServiceRequest>(izzzzzzzzzzzzzzzzg_, izzzzzzzzzzzzzzzzh_);
            Encounter izzzzzzzzzzzzzzzzj_(ServiceRequest NoNonPharm) =>
                FirstHTNEncounter;
            IEnumerable<Encounter> izzzzzzzzzzzzzzzzk_ = context.Operators.Select<ServiceRequest, Encounter>(izzzzzzzzzzzzzzzzi_, izzzzzzzzzzzzzzzzj_);

            return izzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzl_ = context.Operators.SelectMany<Encounter, Encounter>(ezzzzzzzzzzzzzzzzg_, ezzzzzzzzzzzzzzzzk_);
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzm_ = context.Operators.Union<Encounter>(ezzzzzzzzzzzzzzzzi_, ezzzzzzzzzzzzzzzzl_);
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzn_ = context.Operators.Union<Encounter>(ezzzzzzzzzzzzzzzzf_, ezzzzzzzzzzzzzzzzm_);
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzo_ = this.Encounter_with_Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89(context);
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzp_(Encounter SecondHTNEncounter)
        {
            IEnumerable<ServiceRequest> izzzzzzzzzzzzzzzzq_ = this.Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89_Interventions_Declined(context);
            bool? izzzzzzzzzzzzzzzzr_(ServiceRequest SecondHTNDeclinedInterventions)
            {
                FhirDateTime izzzzzzzzzzzzzzzzv_ = SecondHTNDeclinedInterventions?.AuthoredOnElement;
                CqlDateTime izzzzzzzzzzzzzzzzw_ = context.Operators.Convert<CqlDateTime>(izzzzzzzzzzzzzzzzv_);
                Period izzzzzzzzzzzzzzzzx_ = SecondHTNEncounter?.Period;
                CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzzzzzzzzzzzx_);
                bool? izzzzzzzzzzzzzzzzz_ = context.Operators.In<CqlDateTime>(izzzzzzzzzzzzzzzzw_, izzzzzzzzzzzzzzzzy_, "day");

                return izzzzzzzzzzzzzzzzz_;
            };
            IEnumerable<ServiceRequest> izzzzzzzzzzzzzzzzs_ = context.Operators.Where<ServiceRequest>(izzzzzzzzzzzzzzzzq_, izzzzzzzzzzzzzzzzr_);
            Encounter izzzzzzzzzzzzzzzzt_(ServiceRequest SecondHTNDeclinedInterventions) =>
                SecondHTNEncounter;
            IEnumerable<Encounter> izzzzzzzzzzzzzzzzu_ = context.Operators.Select<ServiceRequest, Encounter>(izzzzzzzzzzzzzzzzs_, izzzzzzzzzzzzzzzzt_);

            return izzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzq_ = context.Operators.SelectMany<Encounter, Encounter>(ezzzzzzzzzzzzzzzzo_, ezzzzzzzzzzzzzzzzp_);
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzr_ = this.Encounter_with_Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90(context);
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzs_(Encounter SecondHTN140Over90Encounter)
        {
            IEnumerable<object> jzzzzzzzzzzzzzzzza_ = this.Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90_Interventions_Declined(context);
            bool? jzzzzzzzzzzzzzzzzb_(object SecondHTN140Over90DeclinedInterventions)
            {
                object jzzzzzzzzzzzzzzzzf_ = context.Operators.LateBoundProperty<object>(SecondHTN140Over90DeclinedInterventions, "authoredOn");
                CqlDateTime jzzzzzzzzzzzzzzzzg_ = context.Operators.LateBoundProperty<CqlDateTime>(jzzzzzzzzzzzzzzzzf_, "value");
                Period jzzzzzzzzzzzzzzzzh_ = SecondHTN140Over90Encounter?.Period;
                CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzzzzzzzzzzzh_);
                bool? jzzzzzzzzzzzzzzzzj_ = context.Operators.In<CqlDateTime>(jzzzzzzzzzzzzzzzzg_, jzzzzzzzzzzzzzzzzi_, "day");

                return jzzzzzzzzzzzzzzzzj_;
            };
            IEnumerable<object> jzzzzzzzzzzzzzzzzc_ = context.Operators.Where<object>(jzzzzzzzzzzzzzzzza_, jzzzzzzzzzzzzzzzzb_);
            Encounter jzzzzzzzzzzzzzzzzd_(object SecondHTN140Over90DeclinedInterventions) =>
                SecondHTN140Over90Encounter;
            IEnumerable<Encounter> jzzzzzzzzzzzzzzzze_ = context.Operators.Select<object, Encounter>(jzzzzzzzzzzzzzzzzc_, jzzzzzzzzzzzzzzzzd_);

            return jzzzzzzzzzzzzzzzze_;
        };
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzt_ = context.Operators.SelectMany<Encounter, Encounter>(ezzzzzzzzzzzzzzzzr_, ezzzzzzzzzzzzzzzzs_);
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzu_ = context.Operators.Union<Encounter>(ezzzzzzzzzzzzzzzzq_, ezzzzzzzzzzzzzzzzt_);
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzv_ = context.Operators.Union<Encounter>(ezzzzzzzzzzzzzzzzn_, ezzzzzzzzzzzzzzzzu_);

        return ezzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Denominator Exceptions")]
    public IEnumerable<Encounter> Denominator_Exceptions(CqlContext context)
    {
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzk_ = this.Encounter_with_Medical_Reason_for_Not_Obtaining_or_Patient_Declined_Blood_Pressure_Measurement(context);
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzl_ = this.Encounter_with_Order_for_Hypertension_Follow_Up_Declined_by_Patient(context);
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzm_ = context.Operators.Union<Encounter>(jzzzzzzzzzzzzzzzzk_, jzzzzzzzzzzzzzzzzl_);

        return jzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? jzzzzzzzzzzzzzzzzn_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return jzzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> jzzzzzzzzzzzzzzzzo_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return jzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? jzzzzzzzzzzzzzzzzp_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return jzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode jzzzzzzzzzzzzzzzzq_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return jzzzzzzzzzzzzzzzzq_;
    }


    #endregion Expressions

}
