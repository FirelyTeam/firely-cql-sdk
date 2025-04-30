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
[CqlLibrary("HFBetaBlockerTherapyforLVSDFHIR", "1.4.000")]
public partial class HFBetaBlockerTherapyforLVSDFHIR_1_4_000 : ILibrary, ISingleton<HFBetaBlockerTherapyforLVSDFHIR_1_4_000>
{
    private HFBetaBlockerTherapyforLVSDFHIR_1_4_000() {}

    public static HFBetaBlockerTherapyforLVSDFHIR_1_4_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "HFBetaBlockerTherapyforLVSDFHIR";
    public string Version => "1.4.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, SupplementalDataElements_3_5_000.Instance, QICoreCommon_2_1_000.Instance, AHAOverall_2_8_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    [CqlValueSetDefinition("Allergy to Beta Blocker Therapy", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1177", valueSetVersion: null)]
    public CqlValueSet Allergy_to_Beta_Blocker_Therapy(CqlContext _) => _Allergy_to_Beta_Blocker_Therapy;
    private static readonly CqlValueSet _Allergy_to_Beta_Blocker_Therapy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1177", null);

    [CqlValueSetDefinition("Arrhythmia", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.366", valueSetVersion: null)]
    public CqlValueSet Arrhythmia(CqlContext _) => _Arrhythmia;
    private static readonly CqlValueSet _Arrhythmia = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.366", null);

    [CqlValueSetDefinition("Asthma", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.362", valueSetVersion: null)]
    public CqlValueSet Asthma(CqlContext _) => _Asthma;
    private static readonly CqlValueSet _Asthma = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.362", null);

    [CqlValueSetDefinition("Atrioventricular Block", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.367", valueSetVersion: null)]
    public CqlValueSet Atrioventricular_Block(CqlContext _) => _Atrioventricular_Block;
    private static readonly CqlValueSet _Atrioventricular_Block = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.367", null);

    [CqlValueSetDefinition("Beta Blocker Therapy for LVSD", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1184", valueSetVersion: null)]
    public CqlValueSet Beta_Blocker_Therapy_for_LVSD(CqlContext _) => _Beta_Blocker_Therapy_for_LVSD;
    private static readonly CqlValueSet _Beta_Blocker_Therapy_for_LVSD = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1184", null);

    [CqlValueSetDefinition("Beta Blocker Therapy Ingredient", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1493", valueSetVersion: null)]
    public CqlValueSet Beta_Blocker_Therapy_Ingredient(CqlContext _) => _Beta_Blocker_Therapy_Ingredient;
    private static readonly CqlValueSet _Beta_Blocker_Therapy_Ingredient = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1493", null);

    [CqlValueSetDefinition("Bradycardia", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.412", valueSetVersion: null)]
    public CqlValueSet Bradycardia(CqlContext _) => _Bradycardia;
    private static readonly CqlValueSet _Bradycardia = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.412", null);

    [CqlValueSetDefinition("Cardiac Pacer", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1178.53", valueSetVersion: null)]
    public CqlValueSet Cardiac_Pacer(CqlContext _) => _Cardiac_Pacer;
    private static readonly CqlValueSet _Cardiac_Pacer = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1178.53", null);

    [CqlValueSetDefinition("Cardiac Pacer in Situ", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.368", valueSetVersion: null)]
    public CqlValueSet Cardiac_Pacer_in_Situ(CqlContext _) => _Cardiac_Pacer_in_Situ;
    private static readonly CqlValueSet _Cardiac_Pacer_in_Situ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.368", null);

    [CqlValueSetDefinition("Hypotension", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.370", valueSetVersion: null)]
    public CqlValueSet Hypotension(CqlContext _) => _Hypotension;
    private static readonly CqlValueSet _Hypotension = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.370", null);

    [CqlValueSetDefinition("Intolerance to Beta Blocker Therapy", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1178", valueSetVersion: null)]
    public CqlValueSet Intolerance_to_Beta_Blocker_Therapy(CqlContext _) => _Intolerance_to_Beta_Blocker_Therapy;
    private static readonly CqlValueSet _Intolerance_to_Beta_Blocker_Therapy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1178", null);

    [CqlValueSetDefinition("Medical Reason", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1007", valueSetVersion: null)]
    public CqlValueSet Medical_Reason(CqlContext _) => _Medical_Reason;
    private static readonly CqlValueSet _Medical_Reason = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1007", null);

    [CqlValueSetDefinition("Patient Reason", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1008", valueSetVersion: null)]
    public CqlValueSet Patient_Reason(CqlContext _) => _Patient_Reason;
    private static readonly CqlValueSet _Patient_Reason = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1008", null);

    #endregion ValueSets

    #region Codes

    [CqlCodeDefinition("Substance with beta adrenergic receptor antagonist mechanism of action (substance)", codeId: "373254001", codeSystem: "http://snomed.info/sct")]
    public CqlCode Substance_with_beta_adrenergic_receptor_antagonist_mechanism_of_action__substance_(CqlContext _) => _Substance_with_beta_adrenergic_receptor_antagonist_mechanism_of_action__substance_;
    private static readonly CqlCode _Substance_with_beta_adrenergic_receptor_antagonist_mechanism_of_action__substance_ = new CqlCode("373254001", "http://snomed.info/sct", default, default);

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("SNOMEDCT")]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT = new CqlCodeSystem();

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Interval(kzzzzzzzzzzzzzzzzzzzzzzzzzzy_, kzzzzzzzzzzzzzzzzzzzzzzzzzzz_, true, true);
        object lzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.ResolveParameter("HFBetaBlockerTherapyforLVSDFHIR-1.4.000", "Measurement Period", lzzzzzzzzzzzzzzzzzzzzzzzzzza_);

        return (CqlInterval<CqlDateTime>)lzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> lzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient lzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.SingletonFrom<Patient>(lzzzzzzzzzzzzzzzzzzzzzzzzzzc_);

        return lzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        bool? lzzzzzzzzzzzzzzzzzzzzzzzzzze_ = AHAOverall_2_8_000.Instance.Is_Adults_With_Two_Qualifying_Outpatient_Encounters_and_One_Heart_Failure_Outpatient_Encounter_During_the_Measurement_Period(context);

        return lzzzzzzzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Initial_Population(context);
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = AHAOverall_2_8_000.Instance.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
        bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Exists<Encounter>(lzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
        bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.And(lzzzzzzzzzzzzzzzzzzzzzzzzzzf_, lzzzzzzzzzzzzzzzzzzzzzzzzzzh_);

        return lzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = AHAOverall_2_8_000.Instance.Has_Heart_Transplant(context);
        bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = AHAOverall_2_8_000.Instance.Has_Heart_Transplant_Complications(context);
        bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Or(lzzzzzzzzzzzzzzzzzzzzzzzzzzj_, lzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = AHAOverall_2_8_000.Instance.Has_Left_Ventricular_Assist_Device(context);
        bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Or(lzzzzzzzzzzzzzzzzzzzzzzzzzzl_, lzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = AHAOverall_2_8_000.Instance.Has_Left_Ventricular_Assist_Device_Complications(context);
        bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Or(lzzzzzzzzzzzzzzzzzzzzzzzzzzn_, lzzzzzzzzzzzzzzzzzzzzzzzzzzo_);

        return lzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Has Beta Blocker Therapy for LVSD Ordered")]
    public bool? Has_Beta_Blocker_Therapy_for_LVSD_Ordered(CqlContext context)
    {
        CqlValueSet lzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Beta_Blocker_Therapy_for_LVSD(context);
        IEnumerable<MedicationRequest> lzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, lzzzzzzzzzzzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> lzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, lzzzzzzzzzzzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> lzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Union<MedicationRequest>(lzzzzzzzzzzzzzzzzzzzzzzzzzzr_, lzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
        bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzv_(MedicationRequest BetaBlockerOrdered)
        {
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = AHAOverall_2_8_000.Instance.isOrderedDuringHeartFailureOutpatientEncounter(context, BetaBlockerOrdered);

            return lzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<MedicationRequest> lzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Where<MedicationRequest>(lzzzzzzzzzzzzzzzzzzzzzzzzzzu_, lzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
        bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Exists<MedicationRequest>(lzzzzzzzzzzzzzzzzzzzzzzzzzzw_);

        return lzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Is Currently Taking Beta Blocker Therapy for LVSD")]
    public bool? Is_Currently_Taking_Beta_Blocker_Therapy_for_LVSD(CqlContext context)
    {
        CqlValueSet lzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Beta_Blocker_Therapy_for_LVSD(context);
        IEnumerable<MedicationRequest> mzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, lzzzzzzzzzzzzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> mzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, lzzzzzzzzzzzzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> mzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Union<MedicationRequest>(mzzzzzzzzzzzzzzzzzzzzzzzzzza_, mzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        bool? mzzzzzzzzzzzzzzzzzzzzzzzzzze_(MedicationRequest ActiveBetaBlocker)
        {
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = AHAOverall_2_8_000.Instance.overlapsAfterHeartFailureOutpatientEncounter(context, ActiveBetaBlocker);

            return mzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<MedicationRequest> mzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Where<MedicationRequest>(mzzzzzzzzzzzzzzzzzzzzzzzzzzd_, mzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Exists<MedicationRequest>(mzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

        return mzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Has_Beta_Blocker_Therapy_for_LVSD_Ordered(context);
        bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Is_Currently_Taking_Beta_Blocker_Therapy_for_LVSD(context);
        bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Or(mzzzzzzzzzzzzzzzzzzzzzzzzzzi_, mzzzzzzzzzzzzzzzzzzzzzzzzzzj_);

        return mzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Has Consecutive Heart Rates Less than 50")]
    public bool? Has_Consecutive_Heart_Rates_Less_than_50(CqlContext context)
    {
        IEnumerable<Observation> mzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/heartrate"));
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = AHAOverall_2_8_000.Instance.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
        IEnumerable<ValueTuple<Observation, Encounter>> mzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.CrossJoin<Observation, Encounter>(mzzzzzzzzzzzzzzzzzzzzzzzzzzl_, mzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        (CqlTupleMetadata, Observation HeartRate, Encounter ModerateOrSevereLVSDHFOutpatientEncounter)? mzzzzzzzzzzzzzzzzzzzzzzzzzzo_(ValueTuple<Observation, Encounter> _valueTuple)
        {
            (CqlTupleMetadata, Observation HeartRate, Encounter ModerateOrSevereLVSDHFOutpatientEncounter)? mzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = (CqlTupleMetadata_FUFPMQdRaTBgLhghDWfUUBaNF, _valueTuple.Item1, _valueTuple.Item2);

            return mzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<(CqlTupleMetadata, Observation HeartRate, Encounter ModerateOrSevereLVSDHFOutpatientEncounter)?> mzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Select<ValueTuple<Observation, Encounter>, (CqlTupleMetadata, Observation HeartRate, Encounter ModerateOrSevereLVSDHFOutpatientEncounter)?>(mzzzzzzzzzzzzzzzzzzzzzzzzzzn_, mzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzq_((CqlTupleMetadata, Observation HeartRate, Encounter ModerateOrSevereLVSDHFOutpatientEncounter)? tuple_fufpmqdratbglhghdwfuubanf)
        {
            Period mzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = tuple_fufpmqdratbglhghdwfuubanf?.ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            DataType mzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = tuple_fufpmqdratbglhghdwfuubanf?.HeartRate?.Effective;
            object nzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.toInterval(context, nzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(mzzzzzzzzzzzzzzzzzzzzzzzzzzy_, nzzzzzzzzzzzzzzzzzzzzzzzzzzb_, default);
            Code<ObservationStatus> nzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = tuple_fufpmqdratbglhghdwfuubanf?.HeartRate?.StatusElement;
            ObservationStatus? nzzzzzzzzzzzzzzzzzzzzzzzzzze_ = nzzzzzzzzzzzzzzzzzzzzzzzzzzd_?.Value;
            string nzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Convert<string>(nzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            string[] nzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.In<string>(nzzzzzzzzzzzzzzzzzzzzzzzzzzf_, nzzzzzzzzzzzzzzzzzzzzzzzzzzg_ as IEnumerable<string>);
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.And(nzzzzzzzzzzzzzzzzzzzzzzzzzzc_, nzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            DataType nzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = tuple_fufpmqdratbglhghdwfuubanf?.HeartRate?.Value;
            CqlQuantity nzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzj_ as Quantity);
            CqlQuantity nzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Quantity(50m, "/min");
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Less(nzzzzzzzzzzzzzzzzzzzzzzzzzzk_, nzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.And(nzzzzzzzzzzzzzzzzzzzzzzzzzzi_, nzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            IEnumerable<Observation> nzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/heartrate"));
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzp_(Observation MostRecentPriorHeartRate)
            {
                Period nzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = tuple_fufpmqdratbglhghdwfuubanf?.ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
                CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                DataType ozzzzzzzzzzzzzzzzzzzzzzzzzzb_ = MostRecentPriorHeartRate?.Effective;
                object ozzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.toInterval(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                bool? ozzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ozzzzzzzzzzzzzzzzzzzzzzzzzza_, ozzzzzzzzzzzzzzzzzzzzzzzzzzd_, default);
                object ozzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.toInterval(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                DataType ozzzzzzzzzzzzzzzzzzzzzzzzzzi_ = tuple_fufpmqdratbglhghdwfuubanf?.HeartRate?.Effective;
                object ozzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.toInterval(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Before(ozzzzzzzzzzzzzzzzzzzzzzzzzzh_, ozzzzzzzzzzzzzzzzzzzzzzzzzzk_, default);
                bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzzzzzzzzze_, ozzzzzzzzzzzzzzzzzzzzzzzzzzl_);

                return ozzzzzzzzzzzzzzzzzzzzzzzzzzm_;
            };
            IEnumerable<Observation> nzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Where<Observation>(nzzzzzzzzzzzzzzzzzzzzzzzzzzo_, nzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            object nzzzzzzzzzzzzzzzzzzzzzzzzzzr_(Observation @this)
            {
                DataType ozzzzzzzzzzzzzzzzzzzzzzzzzzn_ = @this?.Effective;
                object ozzzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.toInterval(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Start(ozzzzzzzzzzzzzzzzzzzzzzzzzzp_);

                return ozzzzzzzzzzzzzzzzzzzzzzzzzzq_;
            };
            IEnumerable<Observation> nzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.SortBy<Observation>(nzzzzzzzzzzzzzzzzzzzzzzzzzzq_, nzzzzzzzzzzzzzzzzzzzzzzzzzzr_, System.ComponentModel.ListSortDirection.Ascending);
            Observation nzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Last<Observation>(nzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            DataType nzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = nzzzzzzzzzzzzzzzzzzzzzzzzzzt_?.Value;
            CqlQuantity nzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzu_ as Quantity);
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Less(nzzzzzzzzzzzzzzzzzzzzzzzzzzv_, nzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.And(nzzzzzzzzzzzzzzzzzzzzzzzzzzn_, nzzzzzzzzzzzzzzzzzzzzzzzzzzx_);

            return nzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<(CqlTupleMetadata, Observation HeartRate, Encounter ModerateOrSevereLVSDHFOutpatientEncounter)?> mzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Where<(CqlTupleMetadata, Observation HeartRate, Encounter ModerateOrSevereLVSDHFOutpatientEncounter)?>(mzzzzzzzzzzzzzzzzzzzzzzzzzzp_, mzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        Observation mzzzzzzzzzzzzzzzzzzzzzzzzzzs_((CqlTupleMetadata, Observation HeartRate, Encounter ModerateOrSevereLVSDHFOutpatientEncounter)? tuple_fufpmqdratbglhghdwfuubanf) =>
            tuple_fufpmqdratbglhghdwfuubanf?.HeartRate;
        IEnumerable<Observation> mzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Select<(CqlTupleMetadata, Observation HeartRate, Encounter ModerateOrSevereLVSDHFOutpatientEncounter)?, Observation>(mzzzzzzzzzzzzzzzzzzzzzzzzzzr_, mzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        IEnumerable<Observation> mzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Distinct<Observation>(mzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
        bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Exists<Observation>(mzzzzzzzzzzzzzzzzzzzzzzzzzzu_);

        return mzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Has Hypotension Diagnosis")]
    public bool? Has_Hypotension_Diagnosis(CqlContext context)
    {
        CqlValueSet ozzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Hypotension(context);
        IEnumerable<Condition> ozzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ozzzzzzzzzzzzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzt_(Condition Hypotension)
        {
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzw_ = AHAOverall_2_8_000.Instance.overlapsHeartFailureOutpatientEncounter(context, Hypotension);
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzx_ = AHAOverall_2_8_000.Instance.isConfirmedActiveDiagnosis(context, Hypotension);
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzzzzzzzzzw_, ozzzzzzzzzzzzzzzzzzzzzzzzzzx_);

            return ozzzzzzzzzzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<Condition> ozzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Where<Condition>(ozzzzzzzzzzzzzzzzzzzzzzzzzzs_, ozzzzzzzzzzzzzzzzzzzzzzzzzzt_);
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Exists<Condition>(ozzzzzzzzzzzzzzzzzzzzzzzzzzu_);

        return ozzzzzzzzzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Has Asthma Diagnosis")]
    public bool? Has_Asthma_Diagnosis(CqlContext context)
    {
        CqlValueSet ozzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Asthma(context);
        IEnumerable<Condition> pzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ozzzzzzzzzzzzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzb_(Condition Asthma)
        {
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzze_ = AHAOverall_2_8_000.Instance.overlapsHeartFailureOutpatientEncounter(context, Asthma);
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = AHAOverall_2_8_000.Instance.isConfirmedActiveDiagnosis(context, Asthma);
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.And(pzzzzzzzzzzzzzzzzzzzzzzzzzze_, pzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

            return pzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<Condition> pzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Where<Condition>(pzzzzzzzzzzzzzzzzzzzzzzzzzza_, pzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
        bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Exists<Condition>(pzzzzzzzzzzzzzzzzzzzzzzzzzzc_);

        return pzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Has Diagnosis of Allergy or Intolerance to Beta Blocker Therapy")]
    public bool? Has_Diagnosis_of_Allergy_or_Intolerance_to_Beta_Blocker_Therapy(CqlContext context)
    {
        CqlValueSet pzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Allergy_to_Beta_Blocker_Therapy(context);
        IEnumerable<Condition> pzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet pzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Intolerance_to_Beta_Blocker_Therapy(context);
        IEnumerable<Condition> pzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> pzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Union<Condition>(pzzzzzzzzzzzzzzzzzzzzzzzzzzi_, pzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzm_(Condition BetaBlockerAllergyOrIntoleranceDiagnosis)
        {
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = AHAOverall_2_8_000.Instance.overlapsAfterHeartFailureOutpatientEncounter(context, BetaBlockerAllergyOrIntoleranceDiagnosis);
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = AHAOverall_2_8_000.Instance.isConfirmedActiveDiagnosis(context, BetaBlockerAllergyOrIntoleranceDiagnosis);
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.And(pzzzzzzzzzzzzzzzzzzzzzzzzzzp_, pzzzzzzzzzzzzzzzzzzzzzzzzzzq_);

            return pzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<Condition> pzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Where<Condition>(pzzzzzzzzzzzzzzzzzzzzzzzzzzl_, pzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Exists<Condition>(pzzzzzzzzzzzzzzzzzzzzzzzzzzn_);

        return pzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Has Bradycardia Diagnosis")]
    public bool? Has_Bradycardia_Diagnosis(CqlContext context)
    {
        CqlValueSet pzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Bradycardia(context);
        IEnumerable<Condition> pzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzu_(Condition Bradycardia)
        {
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = AHAOverall_2_8_000.Instance.overlapsHeartFailureOutpatientEncounter(context, Bradycardia);
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = AHAOverall_2_8_000.Instance.isConfirmedActiveDiagnosis(context, Bradycardia);
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.And(pzzzzzzzzzzzzzzzzzzzzzzzzzzx_, pzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

            return pzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<Condition> pzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Condition>(pzzzzzzzzzzzzzzzzzzzzzzzzzzt_, pzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
        bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Exists<Condition>(pzzzzzzzzzzzzzzzzzzzzzzzzzzv_);

        return pzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Has Allergy or Intolerance to Beta Blocker Therapy Ingredient")]
    [CqlTag("commentedOut", "implies logic")]
    [CqlTag("commentedOutReason", "implies not available in cql-execution. Reference https://github.com/cqframework/cql-execution/issues/319.")]
    public bool? Has_Allergy_or_Intolerance_to_Beta_Blocker_Therapy_Ingredient(CqlContext context)
    {
        CqlValueSet qzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Beta_Blocker_Therapy_Ingredient(context);
        IEnumerable<AllergyIntolerance> qzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<AllergyIntolerance>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-allergyintolerance"));
        CqlCode qzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Substance_with_beta_adrenergic_receptor_antagonist_mechanism_of_action__substance_(context);
        IEnumerable<CqlCode> qzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.ToList<CqlCode>(qzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        IEnumerable<AllergyIntolerance> qzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<AllergyIntolerance>(new RetrieveParameters(default, default, qzzzzzzzzzzzzzzzzzzzzzzzzzzd_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-allergyintolerance"));
        IEnumerable<AllergyIntolerance> qzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Union<AllergyIntolerance>(qzzzzzzzzzzzzzzzzzzzzzzzzzzb_, qzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzg_(AllergyIntolerance BetaBlockerAllergyIntolerance)
        {
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = AHAOverall_2_8_000.Instance.overlapsAfterHeartFailureOutpatientEncounter(context, BetaBlockerAllergyIntolerance);
            CodeableConcept qzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = BetaBlockerAllergyIntolerance?.ClinicalStatus;
            CqlConcept qzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            CqlCode qzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.allergy_active(context);
            CqlConcept qzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.ConvertCodeToConcept(qzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Equivalent(qzzzzzzzzzzzzzzzzzzzzzzzzzzl_, qzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.And(qzzzzzzzzzzzzzzzzzzzzzzzzzzj_, qzzzzzzzzzzzzzzzzzzzzzzzzzzo_);

            return qzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<AllergyIntolerance> qzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Where<AllergyIntolerance>(qzzzzzzzzzzzzzzzzzzzzzzzzzzf_, qzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
        bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Exists<AllergyIntolerance>(qzzzzzzzzzzzzzzzzzzzzzzzzzzh_);

        return qzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Has Atrioventricular Block Diagnosis")]
    public bool? Has_Atrioventricular_Block_Diagnosis(CqlContext context)
    {
        CqlValueSet qzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Atrioventricular_Block(context);
        IEnumerable<Condition> qzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzs_(Condition AtrioventricularBlock)
        {
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = AHAOverall_2_8_000.Instance.overlapsHeartFailureOutpatientEncounter(context, AtrioventricularBlock);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = AHAOverall_2_8_000.Instance.isConfirmedActiveDiagnosis(context, AtrioventricularBlock);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.And(qzzzzzzzzzzzzzzzzzzzzzzzzzzv_, qzzzzzzzzzzzzzzzzzzzzzzzzzzw_);

            return qzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<Condition> qzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Where<Condition>(qzzzzzzzzzzzzzzzzzzzzzzzzzzr_, qzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Exists<Condition>(qzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

        return qzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Has Diagnosis of Cardiac Pacer in Situ")]
    public bool? Has_Diagnosis_of_Cardiac_Pacer_in_Situ(CqlContext context)
    {
        CqlValueSet qzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Cardiac_Pacer_in_Situ(context);
        IEnumerable<Condition> qzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? rzzzzzzzzzzzzzzzzzzzzzzzzzza_(Condition CardiacPacerDiagnosis)
        {
            bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = AHAOverall_2_8_000.Instance.overlapsAfterHeartFailureOutpatientEncounter(context, CardiacPacerDiagnosis);
            bool? rzzzzzzzzzzzzzzzzzzzzzzzzzze_ = AHAOverall_2_8_000.Instance.isConfirmedActiveDiagnosis(context, CardiacPacerDiagnosis);
            bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.And(rzzzzzzzzzzzzzzzzzzzzzzzzzzd_, rzzzzzzzzzzzzzzzzzzzzzzzzzze_);

            return rzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<Condition> rzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Where<Condition>(qzzzzzzzzzzzzzzzzzzzzzzzzzzz_, rzzzzzzzzzzzzzzzzzzzzzzzzzza_);
        bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Exists<Condition>(rzzzzzzzzzzzzzzzzzzzzzzzzzzb_);

        return rzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Has Cardiac Pacer Device Implanted")]
    public bool? Has_Cardiac_Pacer_Device_Implanted(CqlContext context)
    {
        CqlValueSet rzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Cardiac_Pacer(context);
        IEnumerable<Procedure> rzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> rzzzzzzzzzzzzzzzzzzzzzzzzzzi_(Procedure ImplantedCardiacPacer)
        {
            IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = AHAOverall_2_8_000.Instance.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
            bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzo_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
            {
                DataType rzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = ImplantedCardiacPacer?.Performed;
                object rzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.toInterval(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Start(rzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                Period rzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
                CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.End(rzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Before(rzzzzzzzzzzzzzzzzzzzzzzzzzzv_, rzzzzzzzzzzzzzzzzzzzzzzzzzzy_, default);

                return rzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
            };
            IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Encounter>(rzzzzzzzzzzzzzzzzzzzzzzzzzzn_, rzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            Procedure rzzzzzzzzzzzzzzzzzzzzzzzzzzq_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter) =>
                ImplantedCardiacPacer;
            IEnumerable<Procedure> rzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Select<Encounter, Procedure>(rzzzzzzzzzzzzzzzzzzzzzzzzzzp_, rzzzzzzzzzzzzzzzzzzzzzzzzzzq_);

            return rzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<Procedure> rzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.SelectMany<Procedure, Procedure>(rzzzzzzzzzzzzzzzzzzzzzzzzzzh_, rzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzk_(Procedure ImplantedCardiacPacer)
        {
            Code<EventStatus> szzzzzzzzzzzzzzzzzzzzzzzzzza_ = ImplantedCardiacPacer?.StatusElement;
            EventStatus? szzzzzzzzzzzzzzzzzzzzzzzzzzb_ = szzzzzzzzzzzzzzzzzzzzzzzzzza_?.Value;
            string szzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Convert<string>(szzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            bool? szzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Equal(szzzzzzzzzzzzzzzzzzzzzzzzzzc_, "completed");

            return szzzzzzzzzzzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<Procedure> rzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Procedure>(rzzzzzzzzzzzzzzzzzzzzzzzzzzj_, rzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Exists<Procedure>(rzzzzzzzzzzzzzzzzzzzzzzzzzzl_);

        return rzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Atrioventricular Block without Cardiac Pacer")]
    public bool? Atrioventricular_Block_without_Cardiac_Pacer(CqlContext context)
    {
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Has_Atrioventricular_Block_Diagnosis(context);
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Has_Diagnosis_of_Cardiac_Pacer_in_Situ(context);
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Not(szzzzzzzzzzzzzzzzzzzzzzzzzzf_);
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.And(szzzzzzzzzzzzzzzzzzzzzzzzzze_, szzzzzzzzzzzzzzzzzzzzzzzzzzg_);
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Has_Cardiac_Pacer_Device_Implanted(context);
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Not(szzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.And(szzzzzzzzzzzzzzzzzzzzzzzzzzh_, szzzzzzzzzzzzzzzzzzzzzzzzzzj_);

        return szzzzzzzzzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Denominator Exceptions")]
    [CqlTag("commentedOuf", "\"Has Medical or Patient Reason for Not Ordering Beta Blocker for LVSD\"")]
    [CqlTag("commentedOufReason", "Negation issue noted in https://github.com/cqframework/cql-execution/issues/296, which is tied to https://oncprojectracking.healthit.gov/support/browse/BONNIEMAT-1455")]
    public bool? Denominator_Exceptions(CqlContext context)
    {
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Has_Consecutive_Heart_Rates_Less_than_50(context);
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Has_Hypotension_Diagnosis(context);
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Or(szzzzzzzzzzzzzzzzzzzzzzzzzzl_, szzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Has_Asthma_Diagnosis(context);
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Or(szzzzzzzzzzzzzzzzzzzzzzzzzzn_, szzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Has_Diagnosis_of_Allergy_or_Intolerance_to_Beta_Blocker_Therapy(context);
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Or(szzzzzzzzzzzzzzzzzzzzzzzzzzp_, szzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Has_Bradycardia_Diagnosis(context);
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Or(szzzzzzzzzzzzzzzzzzzzzzzzzzr_, szzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Has_Allergy_or_Intolerance_to_Beta_Blocker_Therapy_Ingredient(context);
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Or(szzzzzzzzzzzzzzzzzzzzzzzzzzt_, szzzzzzzzzzzzzzzzzzzzzzzzzzu_);
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Atrioventricular_Block_without_Cardiac_Pacer(context);
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Or(szzzzzzzzzzzzzzzzzzzzzzzzzzv_, szzzzzzzzzzzzzzzzzzzzzzzzzzw_);

        return szzzzzzzzzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? szzzzzzzzzzzzzzzzzzzzzzzzzzy_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return szzzzzzzzzzzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> szzzzzzzzzzzzzzzzzzzzzzzzzzz_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return szzzzzzzzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? tzzzzzzzzzzzzzzzzzzzzzzzzzza_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return tzzzzzzzzzzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode tzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return tzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Has Arrhythmia Diagnosis")]
    public bool? Has_Arrhythmia_Diagnosis(CqlContext context)
    {
        CqlValueSet tzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Arrhythmia(context);
        IEnumerable<Condition> tzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? tzzzzzzzzzzzzzzzzzzzzzzzzzze_(Condition Arrhythmia)
        {
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = AHAOverall_2_8_000.Instance.overlapsHeartFailureOutpatientEncounter(context, Arrhythmia);
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = AHAOverall_2_8_000.Instance.isConfirmedActiveDiagnosis(context, Arrhythmia);
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.And(tzzzzzzzzzzzzzzzzzzzzzzzzzzh_, tzzzzzzzzzzzzzzzzzzzzzzzzzzi_);

            return tzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<Condition> tzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Where<Condition>(tzzzzzzzzzzzzzzzzzzzzzzzzzzd_, tzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Exists<Condition>(tzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

        return tzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Has Medical or Patient Reason for Not Ordering Beta Blocker for LVSD")]
    public bool? Has_Medical_or_Patient_Reason_for_Not_Ordering_Beta_Blocker_for_LVSD(CqlContext context)
    {
        CqlValueSet tzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Beta_Blocker_Therapy_for_LVSD(context);
        IEnumerable<MedicationRequest> tzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-mednotrequested"));
        IEnumerable<MedicationRequest> tzzzzzzzzzzzzzzzzzzzzzzzzzzm_(MedicationRequest NoBetaBlockerOrdered)
        {
            IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = AHAOverall_2_8_000.Instance.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzs_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
            {
                FhirDateTime tzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = NoBetaBlockerOrdered?.AuthoredOnElement;
                CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Convert<CqlDateTime>(tzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                Period tzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
                CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                bool? uzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.In<CqlDateTime>(tzzzzzzzzzzzzzzzzzzzzzzzzzzx_, tzzzzzzzzzzzzzzzzzzzzzzzzzzz_, "day");

                return uzzzzzzzzzzzzzzzzzzzzzzzzzza_;
            };
            IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Where<Encounter>(tzzzzzzzzzzzzzzzzzzzzzzzzzzr_, tzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            MedicationRequest tzzzzzzzzzzzzzzzzzzzzzzzzzzu_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter) =>
                NoBetaBlockerOrdered;
            IEnumerable<MedicationRequest> tzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Select<Encounter, MedicationRequest>(tzzzzzzzzzzzzzzzzzzzzzzzzzzt_, tzzzzzzzzzzzzzzzzzzzzzzzzzzu_);

            return tzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<MedicationRequest> tzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(tzzzzzzzzzzzzzzzzzzzzzzzzzzl_, tzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzo_(MedicationRequest NoBetaBlockerOrdered)
        {
            List<CodeableConcept> uzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = NoBetaBlockerOrdered?.ReasonCode;
            CqlConcept uzzzzzzzzzzzzzzzzzzzzzzzzzzc_(CodeableConcept @this)
            {
                CqlConcept uzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return uzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
            };
            IEnumerable<CqlConcept> uzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)uzzzzzzzzzzzzzzzzzzzzzzzzzzb_, uzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            CqlValueSet uzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Medical_Reason(context);
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.ConceptsInValueSet(uzzzzzzzzzzzzzzzzzzzzzzzzzzd_, uzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            CqlConcept uzzzzzzzzzzzzzzzzzzzzzzzzzzh_(CodeableConcept @this)
            {
                CqlConcept uzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return uzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
            };
            IEnumerable<CqlConcept> uzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)uzzzzzzzzzzzzzzzzzzzzzzzzzzb_, uzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            CqlValueSet uzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Patient_Reason(context);
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.ConceptsInValueSet(uzzzzzzzzzzzzzzzzzzzzzzzzzzi_, uzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Or(uzzzzzzzzzzzzzzzzzzzzzzzzzzf_, uzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

            return uzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<MedicationRequest> tzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<MedicationRequest>(tzzzzzzzzzzzzzzzzzzzzzzzzzzn_, tzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Exists<MedicationRequest>(tzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

        return tzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
    }


    #endregion Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_FUFPMQdRaTBgLhghDWfUUBaNF = new(
        [typeof(Observation), typeof(Encounter)],
        ["HeartRate", "ModerateOrSevereLVSDHFOutpatientEncounter"]);

    #endregion CqlTupleMetadata Properties

}
