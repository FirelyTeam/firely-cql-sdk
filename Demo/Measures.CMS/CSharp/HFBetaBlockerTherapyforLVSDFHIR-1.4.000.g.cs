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

    #region ValueSet: Allergy to Beta Blocker Therapy
    [CqlValueSetDefinition(
        definitionName: "Allergy to Beta Blocker Therapy",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1177",
        valueSetVersion: null)]
    public CqlValueSet Allergy_to_Beta_Blocker_Therapy(CqlContext context) => _Allergy_to_Beta_Blocker_Therapy;

    private static readonly CqlValueSet _Allergy_to_Beta_Blocker_Therapy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1177", null);
    #endregion

    #region ValueSet: Arrhythmia
    [CqlValueSetDefinition(
        definitionName: "Arrhythmia",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.366",
        valueSetVersion: null)]
    public CqlValueSet Arrhythmia(CqlContext context) => _Arrhythmia;

    private static readonly CqlValueSet _Arrhythmia = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.366", null);
    #endregion

    #region ValueSet: Asthma
    [CqlValueSetDefinition(
        definitionName: "Asthma",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.362",
        valueSetVersion: null)]
    public CqlValueSet Asthma(CqlContext context) => _Asthma;

    private static readonly CqlValueSet _Asthma = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.362", null);
    #endregion

    #region ValueSet: Atrioventricular Block
    [CqlValueSetDefinition(
        definitionName: "Atrioventricular Block",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.367",
        valueSetVersion: null)]
    public CqlValueSet Atrioventricular_Block(CqlContext context) => _Atrioventricular_Block;

    private static readonly CqlValueSet _Atrioventricular_Block = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.367", null);
    #endregion

    #region ValueSet: Beta Blocker Therapy for LVSD
    [CqlValueSetDefinition(
        definitionName: "Beta Blocker Therapy for LVSD",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1184",
        valueSetVersion: null)]
    public CqlValueSet Beta_Blocker_Therapy_for_LVSD(CqlContext context) => _Beta_Blocker_Therapy_for_LVSD;

    private static readonly CqlValueSet _Beta_Blocker_Therapy_for_LVSD = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1184", null);
    #endregion

    #region ValueSet: Beta Blocker Therapy Ingredient
    [CqlValueSetDefinition(
        definitionName: "Beta Blocker Therapy Ingredient",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1493",
        valueSetVersion: null)]
    public CqlValueSet Beta_Blocker_Therapy_Ingredient(CqlContext context) => _Beta_Blocker_Therapy_Ingredient;

    private static readonly CqlValueSet _Beta_Blocker_Therapy_Ingredient = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1493", null);
    #endregion

    #region ValueSet: Bradycardia
    [CqlValueSetDefinition(
        definitionName: "Bradycardia",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.412",
        valueSetVersion: null)]
    public CqlValueSet Bradycardia(CqlContext context) => _Bradycardia;

    private static readonly CqlValueSet _Bradycardia = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.412", null);
    #endregion

    #region ValueSet: Cardiac Pacer
    [CqlValueSetDefinition(
        definitionName: "Cardiac Pacer",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1178.53",
        valueSetVersion: null)]
    public CqlValueSet Cardiac_Pacer(CqlContext context) => _Cardiac_Pacer;

    private static readonly CqlValueSet _Cardiac_Pacer = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1178.53", null);
    #endregion

    #region ValueSet: Cardiac Pacer in Situ
    [CqlValueSetDefinition(
        definitionName: "Cardiac Pacer in Situ",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.368",
        valueSetVersion: null)]
    public CqlValueSet Cardiac_Pacer_in_Situ(CqlContext context) => _Cardiac_Pacer_in_Situ;

    private static readonly CqlValueSet _Cardiac_Pacer_in_Situ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.368", null);
    #endregion

    #region ValueSet: Hypotension
    [CqlValueSetDefinition(
        definitionName: "Hypotension",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.370",
        valueSetVersion: null)]
    public CqlValueSet Hypotension(CqlContext context) => _Hypotension;

    private static readonly CqlValueSet _Hypotension = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.370", null);
    #endregion

    #region ValueSet: Intolerance to Beta Blocker Therapy
    [CqlValueSetDefinition(
        definitionName: "Intolerance to Beta Blocker Therapy",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1178",
        valueSetVersion: null)]
    public CqlValueSet Intolerance_to_Beta_Blocker_Therapy(CqlContext context) => _Intolerance_to_Beta_Blocker_Therapy;

    private static readonly CqlValueSet _Intolerance_to_Beta_Blocker_Therapy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1178", null);
    #endregion

    #region ValueSet: Medical Reason
    [CqlValueSetDefinition(
        definitionName: "Medical Reason",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1007",
        valueSetVersion: null)]
    public CqlValueSet Medical_Reason(CqlContext context) => _Medical_Reason;

    private static readonly CqlValueSet _Medical_Reason = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1007", null);
    #endregion

    #region ValueSet: Patient Reason
    [CqlValueSetDefinition(
        definitionName: "Patient Reason",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1008",
        valueSetVersion: null)]
    public CqlValueSet Patient_Reason(CqlContext context) => _Patient_Reason;

    private static readonly CqlValueSet _Patient_Reason = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1008", null);
    #endregion

    #endregion ValueSets

    #region Codes

    #region Code: Substance with beta adrenergic receptor antagonist mechanism of action (substance)
    [CqlCodeDefinition(
        definitionName: "Substance with beta adrenergic receptor antagonist mechanism of action (substance)",
        codeId: "373254001",
        codeSystem: "http://snomed.info/sct")]
    public CqlCode Substance_with_beta_adrenergic_receptor_antagonist_mechanism_of_action__substance_(CqlContext context) => _Substance_with_beta_adrenergic_receptor_antagonist_mechanism_of_action__substance_;

    private static readonly CqlCode _Substance_with_beta_adrenergic_receptor_antagonist_mechanism_of_action__substance_ = new CqlCode("373254001", "http://snomed.info/sct", default, default);
    #endregion

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition(
        definitionName: "SNOMEDCT")]
    public CqlCode[] SNOMEDCT(CqlContext context)
    {
        CqlCode[] kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = [
            new CqlCode("373254001", "http://snomed.info/sct", default, default),
        ];

        return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
    }


    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition(
        definitionName: "Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Interval(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, true, true);
        object kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.ResolveParameter("HFBetaBlockerTherapyforLVSDFHIR-1.4.000", "Measurement Period", kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);

        return (CqlInterval<CqlDateTime>)kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition(
        definitionName: "Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.SingletonFrom<Patient>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);

        return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition(
        definitionName: "Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = AHAOverall_2_8_000.Instance.Is_Adults_With_Two_Qualifying_Outpatient_Encounters_and_One_Heart_Failure_Outpatient_Encounter_During_the_Measurement_Period(context);

        return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Initial_Population(context);
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = AHAOverall_2_8_000.Instance.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
        bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Exists<Encounter>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
        bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.And(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);

        return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = AHAOverall_2_8_000.Instance.Has_Heart_Transplant(context);
        bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = AHAOverall_2_8_000.Instance.Has_Heart_Transplant_Complications(context);
        bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Or(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = AHAOverall_2_8_000.Instance.Has_Left_Ventricular_Assist_Device(context);
        bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Or(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
        bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = AHAOverall_2_8_000.Instance.Has_Left_Ventricular_Assist_Device_Complications(context);
        bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Or(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);

        return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has Beta Blocker Therapy for LVSD Ordered")]
    public bool? Has_Beta_Blocker_Therapy_for_LVSD_Ordered(CqlContext context)
    {
        CqlValueSet lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Beta_Blocker_Therapy_for_LVSD(context);
        IEnumerable<MedicationRequest> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Union<MedicationRequest>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_(MedicationRequest BetaBlockerOrdered)
        {
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = AHAOverall_2_8_000.Instance.isOrderedDuringHeartFailureOutpatientEncounter(context, BetaBlockerOrdered);

            return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<MedicationRequest> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Where<MedicationRequest>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Exists<MedicationRequest>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);

        return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition(
        definitionName: "Is Currently Taking Beta Blocker Therapy for LVSD")]
    public bool? Is_Currently_Taking_Beta_Blocker_Therapy_for_LVSD(CqlContext context)
    {
        CqlValueSet lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Beta_Blocker_Therapy_for_LVSD(context);
        IEnumerable<MedicationRequest> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Union<MedicationRequest>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
        bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_(MedicationRequest ActiveBetaBlocker)
        {
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = AHAOverall_2_8_000.Instance.overlapsAfterHeartFailureOutpatientEncounter(context, ActiveBetaBlocker);

            return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
        };
        IEnumerable<MedicationRequest> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Where<MedicationRequest>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
        bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Exists<MedicationRequest>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

        return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition(
        definitionName: "Numerator")]
    public bool? Numerator(CqlContext context)
    {
        bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Has_Beta_Blocker_Therapy_for_LVSD_Ordered(context);
        bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Is_Currently_Taking_Beta_Blocker_Therapy_for_LVSD(context);
        bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Or(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);

        return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has Consecutive Heart Rates Less than 50")]
    public bool? Has_Consecutive_Heart_Rates_Less_than_50(CqlContext context)
    {
        IEnumerable<Observation> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/heartrate"));
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = AHAOverall_2_8_000.Instance.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
        IEnumerable<ValueTuple<Observation, Encounter>> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.CrossJoin<Observation, Encounter>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
        (CqlTupleMetadata, Observation HeartRate, Encounter ModerateOrSevereLVSDHFOutpatientEncounter)? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_(ValueTuple<Observation, Encounter> _valueTuple)
        {
            (CqlTupleMetadata, Observation HeartRate, Encounter ModerateOrSevereLVSDHFOutpatientEncounter)? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = (CqlTupleMetadata_FUFPMQdRaTBgLhghDWfUUBaNF, _valueTuple.Item1, _valueTuple.Item2);

            return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<(CqlTupleMetadata, Observation HeartRate, Encounter ModerateOrSevereLVSDHFOutpatientEncounter)?> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Select<ValueTuple<Observation, Encounter>, (CqlTupleMetadata, Observation HeartRate, Encounter ModerateOrSevereLVSDHFOutpatientEncounter)?>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_((CqlTupleMetadata, Observation HeartRate, Encounter ModerateOrSevereLVSDHFOutpatientEncounter)? tuple_fufpmqdratbglhghdwfuubanf)
        {
            Period mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = tuple_fufpmqdratbglhghdwfuubanf?.ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            DataType mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = tuple_fufpmqdratbglhghdwfuubanf?.HeartRate?.Effective;
            object mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.toInterval(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, default);
            Code<ObservationStatus> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = tuple_fufpmqdratbglhghdwfuubanf?.HeartRate?.StatusElement;
            ObservationStatus? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_?.Value;
            string mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Convert<string>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            string[] nzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.In<string>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ as IEnumerable<string>);
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.And(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            DataType nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = tuple_fufpmqdratbglhghdwfuubanf?.HeartRate?.Value;
            CqlQuantity nzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ as Quantity);
            CqlQuantity nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Quantity(50m, "/min");
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Less(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.And(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            IEnumerable<Observation> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/heartrate"));
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_(Observation MostRecentPriorHeartRate)
            {
                Period nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = tuple_fufpmqdratbglhghdwfuubanf?.ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                DataType nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = MostRecentPriorHeartRate?.Effective;
                object nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.toInterval(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, default);
                object ozzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.toInterval(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                DataType ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = tuple_fufpmqdratbglhghdwfuubanf?.HeartRate?.Effective;
                object ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.toInterval(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Before(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, default);
                bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.And(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

                return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
            };
            IEnumerable<Observation> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Where<Observation>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            object nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_(Observation @this)
            {
                DataType ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = @this?.Effective;
                object ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.toInterval(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Start(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);

                return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
            };
            IEnumerable<Observation> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.SortBy<Observation>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, System.ComponentModel.ListSortDirection.Ascending);
            Observation nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Last<Observation>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            DataType nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_?.Value;
            CqlQuantity nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ as Quantity);
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Less(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.And(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);

            return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<(CqlTupleMetadata, Observation HeartRate, Encounter ModerateOrSevereLVSDHFOutpatientEncounter)?> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<(CqlTupleMetadata, Observation HeartRate, Encounter ModerateOrSevereLVSDHFOutpatientEncounter)?>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        Observation mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_((CqlTupleMetadata, Observation HeartRate, Encounter ModerateOrSevereLVSDHFOutpatientEncounter)? tuple_fufpmqdratbglhghdwfuubanf) =>
            tuple_fufpmqdratbglhghdwfuubanf?.HeartRate;
        IEnumerable<Observation> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Select<(CqlTupleMetadata, Observation HeartRate, Encounter ModerateOrSevereLVSDHFOutpatientEncounter)?, Observation>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        IEnumerable<Observation> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Distinct<Observation>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Exists<Observation>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);

        return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has Hypotension Diagnosis")]
    public bool? Has_Hypotension_Diagnosis(CqlContext context)
    {
        CqlValueSet ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Hypotension(context);
        IEnumerable<Condition> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_(Condition Hypotension)
        {
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = AHAOverall_2_8_000.Instance.overlapsHeartFailureOutpatientEncounter(context, Hypotension);
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = AHAOverall_2_8_000.Instance.isConfirmedActiveDiagnosis(context, Hypotension);
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);

            return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<Condition> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<Condition>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Exists<Condition>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);

        return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has Asthma Diagnosis")]
    public bool? Has_Asthma_Diagnosis(CqlContext context)
    {
        CqlValueSet ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Asthma(context);
        IEnumerable<Condition> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_(Condition Asthma)
        {
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = AHAOverall_2_8_000.Instance.overlapsHeartFailureOutpatientEncounter(context, Asthma);
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = AHAOverall_2_8_000.Instance.isConfirmedActiveDiagnosis(context, Asthma);
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

            return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<Condition> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Where<Condition>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Exists<Condition>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);

        return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has Diagnosis of Allergy or Intolerance to Beta Blocker Therapy")]
    public bool? Has_Diagnosis_of_Allergy_or_Intolerance_to_Beta_Blocker_Therapy(CqlContext context)
    {
        CqlValueSet pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Allergy_to_Beta_Blocker_Therapy(context);
        IEnumerable<Condition> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Intolerance_to_Beta_Blocker_Therapy(context);
        IEnumerable<Condition> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Union<Condition>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_(Condition BetaBlockerAllergyOrIntoleranceDiagnosis)
        {
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = AHAOverall_2_8_000.Instance.overlapsAfterHeartFailureOutpatientEncounter(context, BetaBlockerAllergyOrIntoleranceDiagnosis);
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = AHAOverall_2_8_000.Instance.isConfirmedActiveDiagnosis(context, BetaBlockerAllergyOrIntoleranceDiagnosis);
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.And(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

            return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<Condition> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Where<Condition>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
        bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Exists<Condition>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);

        return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has Bradycardia Diagnosis")]
    public bool? Has_Bradycardia_Diagnosis(CqlContext context)
    {
        CqlValueSet pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Bradycardia(context);
        IEnumerable<Condition> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_(Condition Bradycardia)
        {
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = AHAOverall_2_8_000.Instance.overlapsHeartFailureOutpatientEncounter(context, Bradycardia);
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = AHAOverall_2_8_000.Instance.isConfirmedActiveDiagnosis(context, Bradycardia);
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.And(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);

            return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<Condition> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Condition>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Exists<Condition>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

        return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has Allergy or Intolerance to Beta Blocker Therapy Ingredient")]
    [CqlTag("commentedOut", "implies logic")]
    [CqlTag("commentedOutReason", "implies not available in cql-execution. Reference https://github.com/cqframework/cql-execution/issues/319.")]
    public bool? Has_Allergy_or_Intolerance_to_Beta_Blocker_Therapy_Ingredient(CqlContext context)
    {
        CqlValueSet pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Beta_Blocker_Therapy_Ingredient(context);
        IEnumerable<AllergyIntolerance> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<AllergyIntolerance>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-allergyintolerance"));
        CqlCode pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Substance_with_beta_adrenergic_receptor_antagonist_mechanism_of_action__substance_(context);
        IEnumerable<CqlCode> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.ToList<CqlCode>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
        IEnumerable<AllergyIntolerance> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<AllergyIntolerance>(new RetrieveParameters(default, default, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-allergyintolerance"));
        IEnumerable<AllergyIntolerance> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Union<AllergyIntolerance>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
        bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_(AllergyIntolerance BetaBlockerAllergyIntolerance)
        {
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = AHAOverall_2_8_000.Instance.overlapsAfterHeartFailureOutpatientEncounter(context, BetaBlockerAllergyIntolerance);
            CodeableConcept qzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = BetaBlockerAllergyIntolerance?.ClinicalStatus;
            CqlConcept qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            CqlCode qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.allergy_active(context);
            CqlConcept qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.ConvertCodeToConcept(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Equivalent(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.And(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);

            return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<AllergyIntolerance> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Where<AllergyIntolerance>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
        bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Exists<AllergyIntolerance>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);

        return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has Atrioventricular Block Diagnosis")]
    public bool? Has_Atrioventricular_Block_Diagnosis(CqlContext context)
    {
        CqlValueSet qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Atrioventricular_Block(context);
        IEnumerable<Condition> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_(Condition AtrioventricularBlock)
        {
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = AHAOverall_2_8_000.Instance.overlapsHeartFailureOutpatientEncounter(context, AtrioventricularBlock);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = AHAOverall_2_8_000.Instance.isConfirmedActiveDiagnosis(context, AtrioventricularBlock);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.And(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);

            return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<Condition> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Where<Condition>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Exists<Condition>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);

        return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has Diagnosis of Cardiac Pacer in Situ")]
    public bool? Has_Diagnosis_of_Cardiac_Pacer_in_Situ(CqlContext context)
    {
        CqlValueSet qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Cardiac_Pacer_in_Situ(context);
        IEnumerable<Condition> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_(Condition CardiacPacerDiagnosis)
        {
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = AHAOverall_2_8_000.Instance.overlapsAfterHeartFailureOutpatientEncounter(context, CardiacPacerDiagnosis);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = AHAOverall_2_8_000.Instance.isConfirmedActiveDiagnosis(context, CardiacPacerDiagnosis);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.And(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

            return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<Condition> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Condition>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
        bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Exists<Condition>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);

        return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has Cardiac Pacer Device Implanted")]
    public bool? Has_Cardiac_Pacer_Device_Implanted(CqlContext context)
    {
        CqlValueSet rzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Cardiac_Pacer(context);
        IEnumerable<Procedure> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_(Procedure ImplantedCardiacPacer)
        {
            IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = AHAOverall_2_8_000.Instance.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
            bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
            {
                DataType rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = ImplantedCardiacPacer?.Performed;
                object rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.toInterval(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Start(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                Period rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
                CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.End(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Before(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, default);

                return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
            };
            IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Where<Encounter>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            Procedure rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter) =>
                ImplantedCardiacPacer;
            IEnumerable<Procedure> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Select<Encounter, Procedure>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

            return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<Procedure> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.SelectMany<Procedure, Procedure>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_(Procedure ImplantedCardiacPacer)
        {
            Code<EventStatus> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = ImplantedCardiacPacer?.StatusElement;
            EventStatus? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_?.Value;
            string rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Convert<string>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Equal(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, "completed");

            return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<Procedure> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Where<Procedure>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Exists<Procedure>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

        return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition(
        definitionName: "Atrioventricular Block without Cardiac Pacer")]
    public bool? Atrioventricular_Block_without_Cardiac_Pacer(CqlContext context)
    {
        bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Has_Atrioventricular_Block_Diagnosis(context);
        bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Has_Diagnosis_of_Cardiac_Pacer_in_Situ(context);
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Not(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.And(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Has_Cardiac_Pacer_Device_Implanted(context);
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Not(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.And(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);

        return szzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator Exceptions")]
    [CqlTag("commentedOuf", "\"Has Medical or Patient Reason for Not Ordering Beta Blocker for LVSD\"")]
    [CqlTag("commentedOufReason", "Negation issue noted in https://github.com/cqframework/cql-execution/issues/296, which is tied to https://oncprojectracking.healthit.gov/support/browse/BONNIEMAT-1455")]
    public bool? Denominator_Exceptions(CqlContext context)
    {
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Has_Consecutive_Heart_Rates_Less_than_50(context);
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Has_Hypotension_Diagnosis(context);
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Or(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Has_Asthma_Diagnosis(context);
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Or(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Has_Diagnosis_of_Allergy_or_Intolerance_to_Beta_Blocker_Therapy(context);
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Or(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Has_Bradycardia_Diagnosis(context);
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Or(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Has_Allergy_or_Intolerance_to_Beta_Blocker_Therapy_Ingredient(context);
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Or(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Atrioventricular_Block_without_Cardiac_Pacer(context);
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Or(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);

        return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode szzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has Arrhythmia Diagnosis")]
    public bool? Has_Arrhythmia_Diagnosis(CqlContext context)
    {
        CqlValueSet szzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Arrhythmia(context);
        IEnumerable<Condition> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_(Condition Arrhythmia)
        {
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = AHAOverall_2_8_000.Instance.overlapsHeartFailureOutpatientEncounter(context, Arrhythmia);
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = AHAOverall_2_8_000.Instance.isConfirmedActiveDiagnosis(context, Arrhythmia);
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.And(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);

            return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<Condition> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Where<Condition>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
        bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Exists<Condition>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

        return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has Medical or Patient Reason for Not Ordering Beta Blocker for LVSD")]
    public bool? Has_Medical_or_Patient_Reason_for_Not_Ordering_Beta_Blocker_for_LVSD(CqlContext context)
    {
        CqlValueSet tzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Beta_Blocker_Therapy_for_LVSD(context);
        IEnumerable<MedicationRequest> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-mednotrequested"));
        IEnumerable<MedicationRequest> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_(MedicationRequest NoBetaBlockerOrdered)
        {
            IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = AHAOverall_2_8_000.Instance.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
            {
                FhirDateTime tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = NoBetaBlockerOrdered?.AuthoredOnElement;
                CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Convert<CqlDateTime>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                Period tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
                CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.In<CqlDateTime>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, "day");

                return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
            };
            IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Where<Encounter>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            MedicationRequest tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter) =>
                NoBetaBlockerOrdered;
            IEnumerable<MedicationRequest> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Select<Encounter, MedicationRequest>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);

            return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<MedicationRequest> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
        bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_(MedicationRequest NoBetaBlockerOrdered)
        {
            List<CodeableConcept> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = NoBetaBlockerOrdered?.ReasonCode;
            CqlConcept tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_(CodeableConcept @this)
            {
                CqlConcept uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
            };
            IEnumerable<CqlConcept> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            CqlValueSet tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Medical_Reason(context);
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.ConceptsInValueSet(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            CqlConcept uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_(CodeableConcept @this)
            {
                CqlConcept uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
            };
            IEnumerable<CqlConcept> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            CqlValueSet uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Patient_Reason(context);
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.ConceptsInValueSet(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Or(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);

            return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<MedicationRequest> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Where<MedicationRequest>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Exists<MedicationRequest>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);

        return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
    }


    #endregion Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_FUFPMQdRaTBgLhghDWfUUBaNF = new(
        [typeof(Observation), typeof(Encounter)],
        ["HeartRate", "ModerateOrSevereLVSDHFOutpatientEncounter"]);

    #endregion CqlTupleMetadata Properties

}
