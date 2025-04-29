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
        CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Interval(jzzzzzzzzzzzzzzzzzzzzzzzzm_, jzzzzzzzzzzzzzzzzzzzzzzzzn_, true, true);
        object jzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.ResolveParameter("HFBetaBlockerTherapyforLVSDFHIR-1.4.000", "Measurement Period", jzzzzzzzzzzzzzzzzzzzzzzzzo_);

        return (CqlInterval<CqlDateTime>)jzzzzzzzzzzzzzzzzzzzzzzzzp_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> jzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient jzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.SingletonFrom<Patient>(jzzzzzzzzzzzzzzzzzzzzzzzzq_);

        return jzzzzzzzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzs_ = AHAOverall_2_8_000.Instance.Is_Adults_With_Two_Qualifying_Outpatient_Encounters_and_One_Heart_Failure_Outpatient_Encounter_During_the_Measurement_Period(context);

        return jzzzzzzzzzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Initial_Population(context);
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzzzzu_ = AHAOverall_2_8_000.Instance.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Exists<Encounter>(jzzzzzzzzzzzzzzzzzzzzzzzzu_);
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.And(jzzzzzzzzzzzzzzzzzzzzzzzzt_, jzzzzzzzzzzzzzzzzzzzzzzzzv_);

        return jzzzzzzzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzx_ = AHAOverall_2_8_000.Instance.Has_Heart_Transplant(context);
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzy_ = AHAOverall_2_8_000.Instance.Has_Heart_Transplant_Complications(context);
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Or(jzzzzzzzzzzzzzzzzzzzzzzzzx_, jzzzzzzzzzzzzzzzzzzzzzzzzy_);
        bool? kzzzzzzzzzzzzzzzzzzzzzzzza_ = AHAOverall_2_8_000.Instance.Has_Left_Ventricular_Assist_Device(context);
        bool? kzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Or(jzzzzzzzzzzzzzzzzzzzzzzzzz_, kzzzzzzzzzzzzzzzzzzzzzzzza_);
        bool? kzzzzzzzzzzzzzzzzzzzzzzzzc_ = AHAOverall_2_8_000.Instance.Has_Left_Ventricular_Assist_Device_Complications(context);
        bool? kzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Or(kzzzzzzzzzzzzzzzzzzzzzzzzb_, kzzzzzzzzzzzzzzzzzzzzzzzzc_);

        return kzzzzzzzzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Has Beta Blocker Therapy for LVSD Ordered")]
    public bool? Has_Beta_Blocker_Therapy_for_LVSD_Ordered(CqlContext context)
    {
        CqlValueSet kzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Beta_Blocker_Therapy_for_LVSD(context);
        IEnumerable<MedicationRequest> kzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, kzzzzzzzzzzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> kzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, kzzzzzzzzzzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> kzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Union<MedicationRequest>(kzzzzzzzzzzzzzzzzzzzzzzzzf_, kzzzzzzzzzzzzzzzzzzzzzzzzh_);
        bool? kzzzzzzzzzzzzzzzzzzzzzzzzj_(MedicationRequest BetaBlockerOrdered)
        {
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzm_ = AHAOverall_2_8_000.Instance.isOrderedDuringHeartFailureOutpatientEncounter(context, BetaBlockerOrdered);

            return kzzzzzzzzzzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<MedicationRequest> kzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Where<MedicationRequest>(kzzzzzzzzzzzzzzzzzzzzzzzzi_, kzzzzzzzzzzzzzzzzzzzzzzzzj_);
        bool? kzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Exists<MedicationRequest>(kzzzzzzzzzzzzzzzzzzzzzzzzk_);

        return kzzzzzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Is Currently Taking Beta Blocker Therapy for LVSD")]
    public bool? Is_Currently_Taking_Beta_Blocker_Therapy_for_LVSD(CqlContext context)
    {
        CqlValueSet kzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Beta_Blocker_Therapy_for_LVSD(context);
        IEnumerable<MedicationRequest> kzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, kzzzzzzzzzzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> kzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, kzzzzzzzzzzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> kzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Union<MedicationRequest>(kzzzzzzzzzzzzzzzzzzzzzzzzo_, kzzzzzzzzzzzzzzzzzzzzzzzzq_);
        bool? kzzzzzzzzzzzzzzzzzzzzzzzzs_(MedicationRequest ActiveBetaBlocker)
        {
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzv_ = AHAOverall_2_8_000.Instance.overlapsAfterHeartFailureOutpatientEncounter(context, ActiveBetaBlocker);

            return kzzzzzzzzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<MedicationRequest> kzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Where<MedicationRequest>(kzzzzzzzzzzzzzzzzzzzzzzzzr_, kzzzzzzzzzzzzzzzzzzzzzzzzs_);
        bool? kzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Exists<MedicationRequest>(kzzzzzzzzzzzzzzzzzzzzzzzzt_);

        return kzzzzzzzzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        bool? kzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Has_Beta_Blocker_Therapy_for_LVSD_Ordered(context);
        bool? kzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Is_Currently_Taking_Beta_Blocker_Therapy_for_LVSD(context);
        bool? kzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Or(kzzzzzzzzzzzzzzzzzzzzzzzzw_, kzzzzzzzzzzzzzzzzzzzzzzzzx_);

        return kzzzzzzzzzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Has Consecutive Heart Rates Less than 50")]
    public bool? Has_Consecutive_Heart_Rates_Less_than_50(CqlContext context)
    {
        IEnumerable<Observation> kzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/heartrate"));
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzzzzza_ = AHAOverall_2_8_000.Instance.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
        IEnumerable<ValueTuple<Observation, Encounter>> lzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.CrossJoin<Observation, Encounter>(kzzzzzzzzzzzzzzzzzzzzzzzzz_, lzzzzzzzzzzzzzzzzzzzzzzzza_);
        (CqlTupleMetadata, Observation HeartRate, Encounter ModerateOrSevereLVSDHFOutpatientEncounter)? lzzzzzzzzzzzzzzzzzzzzzzzzc_(ValueTuple<Observation, Encounter> _valueTuple)
        {
            (CqlTupleMetadata, Observation HeartRate, Encounter ModerateOrSevereLVSDHFOutpatientEncounter)? lzzzzzzzzzzzzzzzzzzzzzzzzk_ = (CqlTupleMetadata_FUFPMQdRaTBgLhghDWfUUBaNF, _valueTuple.Item1, _valueTuple.Item2);

            return lzzzzzzzzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<(CqlTupleMetadata, Observation HeartRate, Encounter ModerateOrSevereLVSDHFOutpatientEncounter)?> lzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Select<ValueTuple<Observation, Encounter>, (CqlTupleMetadata, Observation HeartRate, Encounter ModerateOrSevereLVSDHFOutpatientEncounter)?>(lzzzzzzzzzzzzzzzzzzzzzzzzb_, lzzzzzzzzzzzzzzzzzzzzzzzzc_);
        bool? lzzzzzzzzzzzzzzzzzzzzzzzze_((CqlTupleMetadata, Observation HeartRate, Encounter ModerateOrSevereLVSDHFOutpatientEncounter)? tuple_fufpmqdratbglhghdwfuubanf)
        {
            Period lzzzzzzzzzzzzzzzzzzzzzzzzl_ = tuple_fufpmqdratbglhghdwfuubanf?.ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzzzzzzzzzzzzzzzzzzzl_);
            DataType lzzzzzzzzzzzzzzzzzzzzzzzzn_ = tuple_fufpmqdratbglhghdwfuubanf?.HeartRate?.Effective;
            object lzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.toInterval(context, lzzzzzzzzzzzzzzzzzzzzzzzzo_);
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(lzzzzzzzzzzzzzzzzzzzzzzzzm_, lzzzzzzzzzzzzzzzzzzzzzzzzp_, default);
            Code<ObservationStatus> lzzzzzzzzzzzzzzzzzzzzzzzzr_ = tuple_fufpmqdratbglhghdwfuubanf?.HeartRate?.StatusElement;
            ObservationStatus? lzzzzzzzzzzzzzzzzzzzzzzzzs_ = lzzzzzzzzzzzzzzzzzzzzzzzzr_?.Value;
            string lzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Convert<string>(lzzzzzzzzzzzzzzzzzzzzzzzzs_);
            string[] lzzzzzzzzzzzzzzzzzzzzzzzzu_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.In<string>(lzzzzzzzzzzzzzzzzzzzzzzzzt_, lzzzzzzzzzzzzzzzzzzzzzzzzu_ as IEnumerable<string>);
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.And(lzzzzzzzzzzzzzzzzzzzzzzzzq_, lzzzzzzzzzzzzzzzzzzzzzzzzv_);
            DataType lzzzzzzzzzzzzzzzzzzzzzzzzx_ = tuple_fufpmqdratbglhghdwfuubanf?.HeartRate?.Value;
            CqlQuantity lzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, lzzzzzzzzzzzzzzzzzzzzzzzzx_ as Quantity);
            CqlQuantity lzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Quantity(50m, "/min");
            bool? mzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Less(lzzzzzzzzzzzzzzzzzzzzzzzzy_, lzzzzzzzzzzzzzzzzzzzzzzzzz_);
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.And(lzzzzzzzzzzzzzzzzzzzzzzzzw_, mzzzzzzzzzzzzzzzzzzzzzzzza_);
            IEnumerable<Observation> mzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/heartrate"));
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzd_(Observation MostRecentPriorHeartRate)
            {
                Period mzzzzzzzzzzzzzzzzzzzzzzzzn_ = tuple_fufpmqdratbglhghdwfuubanf?.ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
                CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzzzzzzzzzzzzzzzzzzzn_);
                DataType mzzzzzzzzzzzzzzzzzzzzzzzzp_ = MostRecentPriorHeartRate?.Effective;
                object mzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzzp_);
                CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.toInterval(context, mzzzzzzzzzzzzzzzzzzzzzzzzq_);
                bool? mzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(mzzzzzzzzzzzzzzzzzzzzzzzzo_, mzzzzzzzzzzzzzzzzzzzzzzzzr_, default);
                object mzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzzp_);
                CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.toInterval(context, mzzzzzzzzzzzzzzzzzzzzzzzzu_);
                DataType mzzzzzzzzzzzzzzzzzzzzzzzzw_ = tuple_fufpmqdratbglhghdwfuubanf?.HeartRate?.Effective;
                object mzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzzw_);
                CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.toInterval(context, mzzzzzzzzzzzzzzzzzzzzzzzzx_);
                bool? mzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Before(mzzzzzzzzzzzzzzzzzzzzzzzzv_, mzzzzzzzzzzzzzzzzzzzzzzzzy_, default);
                bool? nzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.And(mzzzzzzzzzzzzzzzzzzzzzzzzs_, mzzzzzzzzzzzzzzzzzzzzzzzzz_);

                return nzzzzzzzzzzzzzzzzzzzzzzzza_;
            };
            IEnumerable<Observation> mzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Where<Observation>(mzzzzzzzzzzzzzzzzzzzzzzzzc_, mzzzzzzzzzzzzzzzzzzzzzzzzd_);
            object mzzzzzzzzzzzzzzzzzzzzzzzzf_(Observation @this)
            {
                DataType nzzzzzzzzzzzzzzzzzzzzzzzzb_ = @this?.Effective;
                object nzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzzzzzzzb_);
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.toInterval(context, nzzzzzzzzzzzzzzzzzzzzzzzzc_);
                CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Start(nzzzzzzzzzzzzzzzzzzzzzzzzd_);

                return nzzzzzzzzzzzzzzzzzzzzzzzze_;
            };
            IEnumerable<Observation> mzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.SortBy<Observation>(mzzzzzzzzzzzzzzzzzzzzzzzze_, mzzzzzzzzzzzzzzzzzzzzzzzzf_, System.ComponentModel.ListSortDirection.Ascending);
            Observation mzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Last<Observation>(mzzzzzzzzzzzzzzzzzzzzzzzzg_);
            DataType mzzzzzzzzzzzzzzzzzzzzzzzzi_ = mzzzzzzzzzzzzzzzzzzzzzzzzh_?.Value;
            CqlQuantity mzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, mzzzzzzzzzzzzzzzzzzzzzzzzi_ as Quantity);
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Less(mzzzzzzzzzzzzzzzzzzzzzzzzj_, lzzzzzzzzzzzzzzzzzzzzzzzzz_);
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.And(mzzzzzzzzzzzzzzzzzzzzzzzzb_, mzzzzzzzzzzzzzzzzzzzzzzzzl_);

            return mzzzzzzzzzzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<(CqlTupleMetadata, Observation HeartRate, Encounter ModerateOrSevereLVSDHFOutpatientEncounter)?> lzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Where<(CqlTupleMetadata, Observation HeartRate, Encounter ModerateOrSevereLVSDHFOutpatientEncounter)?>(lzzzzzzzzzzzzzzzzzzzzzzzzd_, lzzzzzzzzzzzzzzzzzzzzzzzze_);
        Observation lzzzzzzzzzzzzzzzzzzzzzzzzg_((CqlTupleMetadata, Observation HeartRate, Encounter ModerateOrSevereLVSDHFOutpatientEncounter)? tuple_fufpmqdratbglhghdwfuubanf) =>
            tuple_fufpmqdratbglhghdwfuubanf?.HeartRate;
        IEnumerable<Observation> lzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Select<(CqlTupleMetadata, Observation HeartRate, Encounter ModerateOrSevereLVSDHFOutpatientEncounter)?, Observation>(lzzzzzzzzzzzzzzzzzzzzzzzzf_, lzzzzzzzzzzzzzzzzzzzzzzzzg_);
        IEnumerable<Observation> lzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Distinct<Observation>(lzzzzzzzzzzzzzzzzzzzzzzzzh_);
        bool? lzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Exists<Observation>(lzzzzzzzzzzzzzzzzzzzzzzzzi_);

        return lzzzzzzzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Has Hypotension Diagnosis")]
    public bool? Has_Hypotension_Diagnosis(CqlContext context)
    {
        CqlValueSet nzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Hypotension(context);
        IEnumerable<Condition> nzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, nzzzzzzzzzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? nzzzzzzzzzzzzzzzzzzzzzzzzh_(Condition Hypotension)
        {
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzk_ = AHAOverall_2_8_000.Instance.overlapsHeartFailureOutpatientEncounter(context, Hypotension);
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzl_ = AHAOverall_2_8_000.Instance.isConfirmedActiveDiagnosis(context, Hypotension);
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.And(nzzzzzzzzzzzzzzzzzzzzzzzzk_, nzzzzzzzzzzzzzzzzzzzzzzzzl_);

            return nzzzzzzzzzzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<Condition> nzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<Condition>(nzzzzzzzzzzzzzzzzzzzzzzzzg_, nzzzzzzzzzzzzzzzzzzzzzzzzh_);
        bool? nzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Exists<Condition>(nzzzzzzzzzzzzzzzzzzzzzzzzi_);

        return nzzzzzzzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Has Asthma Diagnosis")]
    public bool? Has_Asthma_Diagnosis(CqlContext context)
    {
        CqlValueSet nzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Asthma(context);
        IEnumerable<Condition> nzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, nzzzzzzzzzzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? nzzzzzzzzzzzzzzzzzzzzzzzzp_(Condition Asthma)
        {
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzs_ = AHAOverall_2_8_000.Instance.overlapsHeartFailureOutpatientEncounter(context, Asthma);
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzt_ = AHAOverall_2_8_000.Instance.isConfirmedActiveDiagnosis(context, Asthma);
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.And(nzzzzzzzzzzzzzzzzzzzzzzzzs_, nzzzzzzzzzzzzzzzzzzzzzzzzt_);

            return nzzzzzzzzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<Condition> nzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Where<Condition>(nzzzzzzzzzzzzzzzzzzzzzzzzo_, nzzzzzzzzzzzzzzzzzzzzzzzzp_);
        bool? nzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Exists<Condition>(nzzzzzzzzzzzzzzzzzzzzzzzzq_);

        return nzzzzzzzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Has Diagnosis of Allergy or Intolerance to Beta Blocker Therapy")]
    public bool? Has_Diagnosis_of_Allergy_or_Intolerance_to_Beta_Blocker_Therapy(CqlContext context)
    {
        CqlValueSet nzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Allergy_to_Beta_Blocker_Therapy(context);
        IEnumerable<Condition> nzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, nzzzzzzzzzzzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet nzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Intolerance_to_Beta_Blocker_Therapy(context);
        IEnumerable<Condition> nzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, nzzzzzzzzzzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> nzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Union<Condition>(nzzzzzzzzzzzzzzzzzzzzzzzzw_, nzzzzzzzzzzzzzzzzzzzzzzzzy_);
        bool? ozzzzzzzzzzzzzzzzzzzzzzzza_(Condition BetaBlockerAllergyOrIntoleranceDiagnosis)
        {
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzd_ = AHAOverall_2_8_000.Instance.overlapsAfterHeartFailureOutpatientEncounter(context, BetaBlockerAllergyOrIntoleranceDiagnosis);
            bool? ozzzzzzzzzzzzzzzzzzzzzzzze_ = AHAOverall_2_8_000.Instance.isConfirmedActiveDiagnosis(context, BetaBlockerAllergyOrIntoleranceDiagnosis);
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzzzzzzzd_, ozzzzzzzzzzzzzzzzzzzzzzzze_);

            return ozzzzzzzzzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<Condition> ozzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Where<Condition>(nzzzzzzzzzzzzzzzzzzzzzzzzz_, ozzzzzzzzzzzzzzzzzzzzzzzza_);
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Exists<Condition>(ozzzzzzzzzzzzzzzzzzzzzzzzb_);

        return ozzzzzzzzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Has Bradycardia Diagnosis")]
    public bool? Has_Bradycardia_Diagnosis(CqlContext context)
    {
        CqlValueSet ozzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Bradycardia(context);
        IEnumerable<Condition> ozzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ozzzzzzzzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzi_(Condition Bradycardia)
        {
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzl_ = AHAOverall_2_8_000.Instance.overlapsHeartFailureOutpatientEncounter(context, Bradycardia);
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzm_ = AHAOverall_2_8_000.Instance.isConfirmedActiveDiagnosis(context, Bradycardia);
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzzzzzzzl_, ozzzzzzzzzzzzzzzzzzzzzzzzm_);

            return ozzzzzzzzzzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<Condition> ozzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Where<Condition>(ozzzzzzzzzzzzzzzzzzzzzzzzh_, ozzzzzzzzzzzzzzzzzzzzzzzzi_);
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Exists<Condition>(ozzzzzzzzzzzzzzzzzzzzzzzzj_);

        return ozzzzzzzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Has Allergy or Intolerance to Beta Blocker Therapy Ingredient")]
    [CqlTag("commentedOut", "implies logic")]
    [CqlTag("commentedOutReason", "implies not available in cql-execution. Reference https://github.com/cqframework/cql-execution/issues/319.")]
    public bool? Has_Allergy_or_Intolerance_to_Beta_Blocker_Therapy_Ingredient(CqlContext context)
    {
        CqlValueSet ozzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Beta_Blocker_Therapy_Ingredient(context);
        IEnumerable<AllergyIntolerance> ozzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<AllergyIntolerance>(new RetrieveParameters(default, ozzzzzzzzzzzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-allergyintolerance"));
        CqlCode ozzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Substance_with_beta_adrenergic_receptor_antagonist_mechanism_of_action__substance_(context);
        IEnumerable<CqlCode> ozzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.ToList<CqlCode>(ozzzzzzzzzzzzzzzzzzzzzzzzq_);
        IEnumerable<AllergyIntolerance> ozzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<AllergyIntolerance>(new RetrieveParameters(default, default, ozzzzzzzzzzzzzzzzzzzzzzzzr_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-allergyintolerance"));
        IEnumerable<AllergyIntolerance> ozzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Union<AllergyIntolerance>(ozzzzzzzzzzzzzzzzzzzzzzzzp_, ozzzzzzzzzzzzzzzzzzzzzzzzs_);
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzu_(AllergyIntolerance BetaBlockerAllergyIntolerance)
        {
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzx_ = AHAOverall_2_8_000.Instance.overlapsAfterHeartFailureOutpatientEncounter(context, BetaBlockerAllergyIntolerance);
            CodeableConcept ozzzzzzzzzzzzzzzzzzzzzzzzy_ = BetaBlockerAllergyIntolerance?.ClinicalStatus;
            CqlConcept ozzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ozzzzzzzzzzzzzzzzzzzzzzzzy_);
            CqlCode pzzzzzzzzzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.allergy_active(context);
            CqlConcept pzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.ConvertCodeToConcept(pzzzzzzzzzzzzzzzzzzzzzzzza_);
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Equivalent(ozzzzzzzzzzzzzzzzzzzzzzzzz_, pzzzzzzzzzzzzzzzzzzzzzzzzb_);
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzzzzzzzx_, pzzzzzzzzzzzzzzzzzzzzzzzzc_);

            return pzzzzzzzzzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<AllergyIntolerance> ozzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<AllergyIntolerance>(ozzzzzzzzzzzzzzzzzzzzzzzzt_, ozzzzzzzzzzzzzzzzzzzzzzzzu_);
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Exists<AllergyIntolerance>(ozzzzzzzzzzzzzzzzzzzzzzzzv_);

        return ozzzzzzzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Has Atrioventricular Block Diagnosis")]
    public bool? Has_Atrioventricular_Block_Diagnosis(CqlContext context)
    {
        CqlValueSet pzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Atrioventricular_Block(context);
        IEnumerable<Condition> pzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? pzzzzzzzzzzzzzzzzzzzzzzzzg_(Condition AtrioventricularBlock)
        {
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzj_ = AHAOverall_2_8_000.Instance.overlapsHeartFailureOutpatientEncounter(context, AtrioventricularBlock);
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzk_ = AHAOverall_2_8_000.Instance.isConfirmedActiveDiagnosis(context, AtrioventricularBlock);
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.And(pzzzzzzzzzzzzzzzzzzzzzzzzj_, pzzzzzzzzzzzzzzzzzzzzzzzzk_);

            return pzzzzzzzzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<Condition> pzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Where<Condition>(pzzzzzzzzzzzzzzzzzzzzzzzzf_, pzzzzzzzzzzzzzzzzzzzzzzzzg_);
        bool? pzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Exists<Condition>(pzzzzzzzzzzzzzzzzzzzzzzzzh_);

        return pzzzzzzzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Has Diagnosis of Cardiac Pacer in Situ")]
    public bool? Has_Diagnosis_of_Cardiac_Pacer_in_Situ(CqlContext context)
    {
        CqlValueSet pzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Cardiac_Pacer_in_Situ(context);
        IEnumerable<Condition> pzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? pzzzzzzzzzzzzzzzzzzzzzzzzo_(Condition CardiacPacerDiagnosis)
        {
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzr_ = AHAOverall_2_8_000.Instance.overlapsAfterHeartFailureOutpatientEncounter(context, CardiacPacerDiagnosis);
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzs_ = AHAOverall_2_8_000.Instance.isConfirmedActiveDiagnosis(context, CardiacPacerDiagnosis);
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.And(pzzzzzzzzzzzzzzzzzzzzzzzzr_, pzzzzzzzzzzzzzzzzzzzzzzzzs_);

            return pzzzzzzzzzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<Condition> pzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Condition>(pzzzzzzzzzzzzzzzzzzzzzzzzn_, pzzzzzzzzzzzzzzzzzzzzzzzzo_);
        bool? pzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Exists<Condition>(pzzzzzzzzzzzzzzzzzzzzzzzzp_);

        return pzzzzzzzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Has Cardiac Pacer Device Implanted")]
    public bool? Has_Cardiac_Pacer_Device_Implanted(CqlContext context)
    {
        CqlValueSet pzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Cardiac_Pacer(context);
        IEnumerable<Procedure> pzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> pzzzzzzzzzzzzzzzzzzzzzzzzw_(Procedure ImplantedCardiacPacer)
        {
            IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzzzb_ = AHAOverall_2_8_000.Instance.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzc_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
            {
                DataType qzzzzzzzzzzzzzzzzzzzzzzzzg_ = ImplantedCardiacPacer?.Performed;
                object qzzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzzzzg_);
                CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.toInterval(context, qzzzzzzzzzzzzzzzzzzzzzzzzh_);
                CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Start(qzzzzzzzzzzzzzzzzzzzzzzzzi_);
                Period qzzzzzzzzzzzzzzzzzzzzzzzzk_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
                CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzzzzzzzzzzzzzzzzzzzzk_);
                CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.End(qzzzzzzzzzzzzzzzzzzzzzzzzl_);
                bool? qzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Before(qzzzzzzzzzzzzzzzzzzzzzzzzj_, qzzzzzzzzzzzzzzzzzzzzzzzzm_, default);

                return qzzzzzzzzzzzzzzzzzzzzzzzzn_;
            };
            IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Where<Encounter>(qzzzzzzzzzzzzzzzzzzzzzzzzb_, qzzzzzzzzzzzzzzzzzzzzzzzzc_);
            Procedure qzzzzzzzzzzzzzzzzzzzzzzzze_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter) =>
                ImplantedCardiacPacer;
            IEnumerable<Procedure> qzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Select<Encounter, Procedure>(qzzzzzzzzzzzzzzzzzzzzzzzzd_, qzzzzzzzzzzzzzzzzzzzzzzzze_);

            return qzzzzzzzzzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<Procedure> pzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.SelectMany<Procedure, Procedure>(pzzzzzzzzzzzzzzzzzzzzzzzzv_, pzzzzzzzzzzzzzzzzzzzzzzzzw_);
        bool? pzzzzzzzzzzzzzzzzzzzzzzzzy_(Procedure ImplantedCardiacPacer)
        {
            Code<EventStatus> qzzzzzzzzzzzzzzzzzzzzzzzzo_ = ImplantedCardiacPacer?.StatusElement;
            EventStatus? qzzzzzzzzzzzzzzzzzzzzzzzzp_ = qzzzzzzzzzzzzzzzzzzzzzzzzo_?.Value;
            string qzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Convert<string>(qzzzzzzzzzzzzzzzzzzzzzzzzp_);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Equal(qzzzzzzzzzzzzzzzzzzzzzzzzq_, "completed");

            return qzzzzzzzzzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<Procedure> pzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Where<Procedure>(pzzzzzzzzzzzzzzzzzzzzzzzzx_, pzzzzzzzzzzzzzzzzzzzzzzzzy_);
        bool? qzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Exists<Procedure>(pzzzzzzzzzzzzzzzzzzzzzzzzz_);

        return qzzzzzzzzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Atrioventricular Block without Cardiac Pacer")]
    public bool? Atrioventricular_Block_without_Cardiac_Pacer(CqlContext context)
    {
        bool? qzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Has_Atrioventricular_Block_Diagnosis(context);
        bool? qzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Has_Diagnosis_of_Cardiac_Pacer_in_Situ(context);
        bool? qzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Not(qzzzzzzzzzzzzzzzzzzzzzzzzt_);
        bool? qzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.And(qzzzzzzzzzzzzzzzzzzzzzzzzs_, qzzzzzzzzzzzzzzzzzzzzzzzzu_);
        bool? qzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Has_Cardiac_Pacer_Device_Implanted(context);
        bool? qzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Not(qzzzzzzzzzzzzzzzzzzzzzzzzw_);
        bool? qzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.And(qzzzzzzzzzzzzzzzzzzzzzzzzv_, qzzzzzzzzzzzzzzzzzzzzzzzzx_);

        return qzzzzzzzzzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Denominator Exceptions")]
    [CqlTag("commentedOuf", "\"Has Medical or Patient Reason for Not Ordering Beta Blocker for LVSD\"")]
    [CqlTag("commentedOufReason", "Negation issue noted in https://github.com/cqframework/cql-execution/issues/296, which is tied to https://oncprojectracking.healthit.gov/support/browse/BONNIEMAT-1455")]
    public bool? Denominator_Exceptions(CqlContext context)
    {
        bool? qzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Has_Consecutive_Heart_Rates_Less_than_50(context);
        bool? rzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Has_Hypotension_Diagnosis(context);
        bool? rzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Or(qzzzzzzzzzzzzzzzzzzzzzzzzz_, rzzzzzzzzzzzzzzzzzzzzzzzza_);
        bool? rzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Has_Asthma_Diagnosis(context);
        bool? rzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Or(rzzzzzzzzzzzzzzzzzzzzzzzzb_, rzzzzzzzzzzzzzzzzzzzzzzzzc_);
        bool? rzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Has_Diagnosis_of_Allergy_or_Intolerance_to_Beta_Blocker_Therapy(context);
        bool? rzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Or(rzzzzzzzzzzzzzzzzzzzzzzzzd_, rzzzzzzzzzzzzzzzzzzzzzzzze_);
        bool? rzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Has_Bradycardia_Diagnosis(context);
        bool? rzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Or(rzzzzzzzzzzzzzzzzzzzzzzzzf_, rzzzzzzzzzzzzzzzzzzzzzzzzg_);
        bool? rzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Has_Allergy_or_Intolerance_to_Beta_Blocker_Therapy_Ingredient(context);
        bool? rzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Or(rzzzzzzzzzzzzzzzzzzzzzzzzh_, rzzzzzzzzzzzzzzzzzzzzzzzzi_);
        bool? rzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Atrioventricular_Block_without_Cardiac_Pacer(context);
        bool? rzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Or(rzzzzzzzzzzzzzzzzzzzzzzzzj_, rzzzzzzzzzzzzzzzzzzzzzzzzk_);

        return rzzzzzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? rzzzzzzzzzzzzzzzzzzzzzzzzm_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return rzzzzzzzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> rzzzzzzzzzzzzzzzzzzzzzzzzn_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return rzzzzzzzzzzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? rzzzzzzzzzzzzzzzzzzzzzzzzo_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return rzzzzzzzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode rzzzzzzzzzzzzzzzzzzzzzzzzp_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return rzzzzzzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Has Arrhythmia Diagnosis")]
    public bool? Has_Arrhythmia_Diagnosis(CqlContext context)
    {
        CqlValueSet rzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Arrhythmia(context);
        IEnumerable<Condition> rzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? rzzzzzzzzzzzzzzzzzzzzzzzzs_(Condition Arrhythmia)
        {
            bool? rzzzzzzzzzzzzzzzzzzzzzzzzv_ = AHAOverall_2_8_000.Instance.overlapsHeartFailureOutpatientEncounter(context, Arrhythmia);
            bool? rzzzzzzzzzzzzzzzzzzzzzzzzw_ = AHAOverall_2_8_000.Instance.isConfirmedActiveDiagnosis(context, Arrhythmia);
            bool? rzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.And(rzzzzzzzzzzzzzzzzzzzzzzzzv_, rzzzzzzzzzzzzzzzzzzzzzzzzw_);

            return rzzzzzzzzzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<Condition> rzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Where<Condition>(rzzzzzzzzzzzzzzzzzzzzzzzzr_, rzzzzzzzzzzzzzzzzzzzzzzzzs_);
        bool? rzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Exists<Condition>(rzzzzzzzzzzzzzzzzzzzzzzzzt_);

        return rzzzzzzzzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Has Medical or Patient Reason for Not Ordering Beta Blocker for LVSD")]
    public bool? Has_Medical_or_Patient_Reason_for_Not_Ordering_Beta_Blocker_for_LVSD(CqlContext context)
    {
        CqlValueSet rzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Beta_Blocker_Therapy_for_LVSD(context);
        IEnumerable<MedicationRequest> rzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-mednotrequested"));
        IEnumerable<MedicationRequest> szzzzzzzzzzzzzzzzzzzzzzzza_(MedicationRequest NoBetaBlockerOrdered)
        {
            IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzzzzzzf_ = AHAOverall_2_8_000.Instance.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
            bool? szzzzzzzzzzzzzzzzzzzzzzzzg_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
            {
                FhirDateTime szzzzzzzzzzzzzzzzzzzzzzzzk_ = NoBetaBlockerOrdered?.AuthoredOnElement;
                CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Convert<CqlDateTime>(szzzzzzzzzzzzzzzzzzzzzzzzk_);
                Period szzzzzzzzzzzzzzzzzzzzzzzzm_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
                CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzzzzzzzzzzzzzzzzzzzzzm_);
                bool? szzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.In<CqlDateTime>(szzzzzzzzzzzzzzzzzzzzzzzzl_, szzzzzzzzzzzzzzzzzzzzzzzzn_, "day");

                return szzzzzzzzzzzzzzzzzzzzzzzzo_;
            };
            IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Where<Encounter>(szzzzzzzzzzzzzzzzzzzzzzzzf_, szzzzzzzzzzzzzzzzzzzzzzzzg_);
            MedicationRequest szzzzzzzzzzzzzzzzzzzzzzzzi_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter) =>
                NoBetaBlockerOrdered;
            IEnumerable<MedicationRequest> szzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Select<Encounter, MedicationRequest>(szzzzzzzzzzzzzzzzzzzzzzzzh_, szzzzzzzzzzzzzzzzzzzzzzzzi_);

            return szzzzzzzzzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<MedicationRequest> szzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(rzzzzzzzzzzzzzzzzzzzzzzzzz_, szzzzzzzzzzzzzzzzzzzzzzzza_);
        bool? szzzzzzzzzzzzzzzzzzzzzzzzc_(MedicationRequest NoBetaBlockerOrdered)
        {
            List<CodeableConcept> szzzzzzzzzzzzzzzzzzzzzzzzp_ = NoBetaBlockerOrdered?.ReasonCode;
            CqlConcept szzzzzzzzzzzzzzzzzzzzzzzzq_(CodeableConcept @this)
            {
                CqlConcept tzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return tzzzzzzzzzzzzzzzzzzzzzzzza_;
            };
            IEnumerable<CqlConcept> szzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)szzzzzzzzzzzzzzzzzzzzzzzzp_, szzzzzzzzzzzzzzzzzzzzzzzzq_);
            CqlValueSet szzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Medical_Reason(context);
            bool? szzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.ConceptsInValueSet(szzzzzzzzzzzzzzzzzzzzzzzzr_, szzzzzzzzzzzzzzzzzzzzzzzzs_);
            CqlConcept szzzzzzzzzzzzzzzzzzzzzzzzv_(CodeableConcept @this)
            {
                CqlConcept tzzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return tzzzzzzzzzzzzzzzzzzzzzzzzb_;
            };
            IEnumerable<CqlConcept> szzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)szzzzzzzzzzzzzzzzzzzzzzzzp_, szzzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlValueSet szzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Patient_Reason(context);
            bool? szzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.ConceptsInValueSet(szzzzzzzzzzzzzzzzzzzzzzzzw_, szzzzzzzzzzzzzzzzzzzzzzzzx_);
            bool? szzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Or(szzzzzzzzzzzzzzzzzzzzzzzzt_, szzzzzzzzzzzzzzzzzzzzzzzzy_);

            return szzzzzzzzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<MedicationRequest> szzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Where<MedicationRequest>(szzzzzzzzzzzzzzzzzzzzzzzzb_, szzzzzzzzzzzzzzzzzzzzzzzzc_);
        bool? szzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Exists<MedicationRequest>(szzzzzzzzzzzzzzzzzzzzzzzzd_);

        return szzzzzzzzzzzzzzzzzzzzzzzze_;
    }


    #endregion Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_FUFPMQdRaTBgLhghDWfUUBaNF = new(
        [typeof(Observation), typeof(Encounter)],
        ["HeartRate", "ModerateOrSevereLVSDHFOutpatientEncounter"]);

    #endregion CqlTupleMetadata Properties

}
