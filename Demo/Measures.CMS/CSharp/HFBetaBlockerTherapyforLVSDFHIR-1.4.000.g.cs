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
    private static readonly CqlCode _Substance_with_beta_adrenergic_receptor_antagonist_mechanism_of_action__substance_ = new CqlCode("373254001", "http://snomed.info/sct");

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("SNOMEDCT")]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT =
      new CqlCodeSystem("http://snomed.info/sct", null, [
          _Substance_with_beta_adrenergic_receptor_antagonist_mechanism_of_action__substance_]);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime rzzzzzzzzzzzzzzzzzx_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime rzzzzzzzzzzzzzzzzzy_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzz_ = context.Operators.Interval(rzzzzzzzzzzzzzzzzzx_, rzzzzzzzzzzzzzzzzzy_, true, true);
        object szzzzzzzzzzzzzzzzza_ = context.ResolveParameter("HFBetaBlockerTherapyforLVSDFHIR-1.4.000", "Measurement Period", rzzzzzzzzzzzzzzzzzz_);

        return (CqlInterval<CqlDateTime>)szzzzzzzzzzzzzzzzza_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> szzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient szzzzzzzzzzzzzzzzzc_ = context.Operators.SingletonFrom<Patient>(szzzzzzzzzzzzzzzzzb_);

        return szzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        bool? szzzzzzzzzzzzzzzzzd_ = AHAOverall_2_8_000.Instance.Is_Adults_With_Two_Qualifying_Outpatient_Encounters_and_One_Heart_Failure_Outpatient_Encounter_During_the_Measurement_Period(context);

        return szzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? szzzzzzzzzzzzzzzzze_ = this.Initial_Population(context);
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzf_ = AHAOverall_2_8_000.Instance.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
        bool? szzzzzzzzzzzzzzzzzg_ = context.Operators.Exists<Encounter>(szzzzzzzzzzzzzzzzzf_);
        bool? szzzzzzzzzzzzzzzzzh_ = context.Operators.And(szzzzzzzzzzzzzzzzze_, szzzzzzzzzzzzzzzzzg_);

        return szzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? szzzzzzzzzzzzzzzzzi_ = AHAOverall_2_8_000.Instance.Has_Heart_Transplant(context);
        bool? szzzzzzzzzzzzzzzzzj_ = AHAOverall_2_8_000.Instance.Has_Heart_Transplant_Complications(context);
        bool? szzzzzzzzzzzzzzzzzk_ = context.Operators.Or(szzzzzzzzzzzzzzzzzi_, szzzzzzzzzzzzzzzzzj_);
        bool? szzzzzzzzzzzzzzzzzl_ = AHAOverall_2_8_000.Instance.Has_Left_Ventricular_Assist_Device(context);
        bool? szzzzzzzzzzzzzzzzzm_ = context.Operators.Or(szzzzzzzzzzzzzzzzzk_, szzzzzzzzzzzzzzzzzl_);
        bool? szzzzzzzzzzzzzzzzzn_ = AHAOverall_2_8_000.Instance.Has_Left_Ventricular_Assist_Device_Complications(context);
        bool? szzzzzzzzzzzzzzzzzo_ = context.Operators.Or(szzzzzzzzzzzzzzzzzm_, szzzzzzzzzzzzzzzzzn_);

        return szzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Has Beta Blocker Therapy for LVSD Ordered")]
    public bool? Has_Beta_Blocker_Therapy_for_LVSD_Ordered(CqlContext context)
    {
        CqlValueSet szzzzzzzzzzzzzzzzzp_ = this.Beta_Blocker_Therapy_for_LVSD(context);
        IEnumerable<MedicationRequest> szzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> szzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> szzzzzzzzzzzzzzzzzt_ = context.Operators.Union<MedicationRequest>(szzzzzzzzzzzzzzzzzq_, szzzzzzzzzzzzzzzzzs_);
        bool? szzzzzzzzzzzzzzzzzu_(MedicationRequest BetaBlockerOrdered)
        {
            bool? szzzzzzzzzzzzzzzzzx_ = AHAOverall_2_8_000.Instance.isOrderedDuringHeartFailureOutpatientEncounter(context, BetaBlockerOrdered);

            return szzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<MedicationRequest> szzzzzzzzzzzzzzzzzv_ = context.Operators.Where<MedicationRequest>(szzzzzzzzzzzzzzzzzt_, szzzzzzzzzzzzzzzzzu_);
        bool? szzzzzzzzzzzzzzzzzw_ = context.Operators.Exists<MedicationRequest>(szzzzzzzzzzzzzzzzzv_);

        return szzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Is Currently Taking Beta Blocker Therapy for LVSD")]
    public bool? Is_Currently_Taking_Beta_Blocker_Therapy_for_LVSD(CqlContext context)
    {
        CqlValueSet szzzzzzzzzzzzzzzzzy_ = this.Beta_Blocker_Therapy_for_LVSD(context);
        IEnumerable<MedicationRequest> szzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> tzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> tzzzzzzzzzzzzzzzzzc_ = context.Operators.Union<MedicationRequest>(szzzzzzzzzzzzzzzzzz_, tzzzzzzzzzzzzzzzzzb_);
        bool? tzzzzzzzzzzzzzzzzzd_(MedicationRequest ActiveBetaBlocker)
        {
            bool? tzzzzzzzzzzzzzzzzzg_ = AHAOverall_2_8_000.Instance.overlapsAfterHeartFailureOutpatientEncounter(context, ActiveBetaBlocker);

            return tzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<MedicationRequest> tzzzzzzzzzzzzzzzzze_ = context.Operators.Where<MedicationRequest>(tzzzzzzzzzzzzzzzzzc_, tzzzzzzzzzzzzzzzzzd_);
        bool? tzzzzzzzzzzzzzzzzzf_ = context.Operators.Exists<MedicationRequest>(tzzzzzzzzzzzzzzzzze_);

        return tzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        bool? tzzzzzzzzzzzzzzzzzh_ = this.Has_Beta_Blocker_Therapy_for_LVSD_Ordered(context);
        bool? tzzzzzzzzzzzzzzzzzi_ = this.Is_Currently_Taking_Beta_Blocker_Therapy_for_LVSD(context);
        bool? tzzzzzzzzzzzzzzzzzj_ = context.Operators.Or(tzzzzzzzzzzzzzzzzzh_, tzzzzzzzzzzzzzzzzzi_);

        return tzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Has Consecutive Heart Rates Less than 50")]
    public bool? Has_Consecutive_Heart_Rates_Less_than_50(CqlContext context)
    {
        IEnumerable<Observation> tzzzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/heartrate"));
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzl_ = AHAOverall_2_8_000.Instance.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
        IEnumerable<ValueTuple<Observation, Encounter>> tzzzzzzzzzzzzzzzzzm_ = context.Operators.CrossJoin<Observation, Encounter>(tzzzzzzzzzzzzzzzzzk_, tzzzzzzzzzzzzzzzzzl_);
        (CqlTupleMetadata, Observation HeartRate, Encounter ModerateOrSevereLVSDHFOutpatientEncounter)? tzzzzzzzzzzzzzzzzzn_(ValueTuple<Observation, Encounter> _valueTuple)
        {
            (CqlTupleMetadata, Observation HeartRate, Encounter ModerateOrSevereLVSDHFOutpatientEncounter)? tzzzzzzzzzzzzzzzzzv_ = (CqlTupleMetadata_FUFPMQdRaTBgLhghDWfUUBaNF, _valueTuple.Item1, _valueTuple.Item2);

            return tzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<(CqlTupleMetadata, Observation HeartRate, Encounter ModerateOrSevereLVSDHFOutpatientEncounter)?> tzzzzzzzzzzzzzzzzzo_ = context.Operators.Select<ValueTuple<Observation, Encounter>, (CqlTupleMetadata, Observation HeartRate, Encounter ModerateOrSevereLVSDHFOutpatientEncounter)?>(tzzzzzzzzzzzzzzzzzm_, tzzzzzzzzzzzzzzzzzn_);
        bool? tzzzzzzzzzzzzzzzzzp_((CqlTupleMetadata, Observation HeartRate, Encounter ModerateOrSevereLVSDHFOutpatientEncounter)? tuple_fufpmqdratbglhghdwfuubanf)
        {
            Period tzzzzzzzzzzzzzzzzzw_ = tuple_fufpmqdratbglhghdwfuubanf?.ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzzzzzzzzzzzzzzw_);
            DataType tzzzzzzzzzzzzzzzzzy_ = tuple_fufpmqdratbglhghdwfuubanf?.HeartRate?.Effective;
            object tzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzy_);
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.toInterval(context, tzzzzzzzzzzzzzzzzzz_);
            bool? uzzzzzzzzzzzzzzzzzb_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(tzzzzzzzzzzzzzzzzzx_, uzzzzzzzzzzzzzzzzza_, default);
            Code<ObservationStatus> uzzzzzzzzzzzzzzzzzc_ = tuple_fufpmqdratbglhghdwfuubanf?.HeartRate?.StatusElement;
            ObservationStatus? uzzzzzzzzzzzzzzzzzd_ = uzzzzzzzzzzzzzzzzzc_?.Value;
            string uzzzzzzzzzzzzzzzzze_ = context.Operators.Convert<string>(uzzzzzzzzzzzzzzzzzd_);
            string[] uzzzzzzzzzzzzzzzzzf_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? uzzzzzzzzzzzzzzzzzg_ = context.Operators.In<string>(uzzzzzzzzzzzzzzzzze_, uzzzzzzzzzzzzzzzzzf_ as IEnumerable<string>);
            bool? uzzzzzzzzzzzzzzzzzh_ = context.Operators.And(uzzzzzzzzzzzzzzzzzb_, uzzzzzzzzzzzzzzzzzg_);
            DataType uzzzzzzzzzzzzzzzzzi_ = tuple_fufpmqdratbglhghdwfuubanf?.HeartRate?.Value;
            CqlQuantity uzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, uzzzzzzzzzzzzzzzzzi_ as Quantity);
            CqlQuantity uzzzzzzzzzzzzzzzzzk_ = context.Operators.Quantity(50m, "/min");
            bool? uzzzzzzzzzzzzzzzzzl_ = context.Operators.Less(uzzzzzzzzzzzzzzzzzj_, uzzzzzzzzzzzzzzzzzk_);
            bool? uzzzzzzzzzzzzzzzzzm_ = context.Operators.And(uzzzzzzzzzzzzzzzzzh_, uzzzzzzzzzzzzzzzzzl_);
            IEnumerable<Observation> uzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/heartrate"));
            bool? uzzzzzzzzzzzzzzzzzo_(Observation MostRecentPriorHeartRate)
            {
                Period uzzzzzzzzzzzzzzzzzy_ = tuple_fufpmqdratbglhghdwfuubanf?.ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
                CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzzzzzzzzzzzzzy_);
                DataType vzzzzzzzzzzzzzzzzza_ = MostRecentPriorHeartRate?.Effective;
                object vzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzza_);
                CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.toInterval(context, vzzzzzzzzzzzzzzzzzb_);
                bool? vzzzzzzzzzzzzzzzzzd_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(uzzzzzzzzzzzzzzzzzz_, vzzzzzzzzzzzzzzzzzc_, default);
                object vzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzza_);
                CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.toInterval(context, vzzzzzzzzzzzzzzzzzf_);
                DataType vzzzzzzzzzzzzzzzzzh_ = tuple_fufpmqdratbglhghdwfuubanf?.HeartRate?.Effective;
                object vzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzh_);
                CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.toInterval(context, vzzzzzzzzzzzzzzzzzi_);
                bool? vzzzzzzzzzzzzzzzzzk_ = context.Operators.Before(vzzzzzzzzzzzzzzzzzg_, vzzzzzzzzzzzzzzzzzj_, default);
                bool? vzzzzzzzzzzzzzzzzzl_ = context.Operators.And(vzzzzzzzzzzzzzzzzzd_, vzzzzzzzzzzzzzzzzzk_);

                return vzzzzzzzzzzzzzzzzzl_;
            };
            IEnumerable<Observation> uzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Observation>(uzzzzzzzzzzzzzzzzzn_, uzzzzzzzzzzzzzzzzzo_);
            object uzzzzzzzzzzzzzzzzzq_(Observation @this)
            {
                DataType vzzzzzzzzzzzzzzzzzm_ = @this?.Effective;
                object vzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzm_);
                CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.toInterval(context, vzzzzzzzzzzzzzzzzzn_);
                CqlDateTime vzzzzzzzzzzzzzzzzzp_ = context.Operators.Start(vzzzzzzzzzzzzzzzzzo_);

                return vzzzzzzzzzzzzzzzzzp_;
            };
            IEnumerable<Observation> uzzzzzzzzzzzzzzzzzr_ = context.Operators.SortBy<Observation>(uzzzzzzzzzzzzzzzzzp_, uzzzzzzzzzzzzzzzzzq_, System.ComponentModel.ListSortDirection.Ascending);
            Observation uzzzzzzzzzzzzzzzzzs_ = context.Operators.Last<Observation>(uzzzzzzzzzzzzzzzzzr_);
            DataType uzzzzzzzzzzzzzzzzzt_ = uzzzzzzzzzzzzzzzzzs_?.Value;
            CqlQuantity uzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, uzzzzzzzzzzzzzzzzzt_ as Quantity);
            bool? uzzzzzzzzzzzzzzzzzw_ = context.Operators.Less(uzzzzzzzzzzzzzzzzzu_, uzzzzzzzzzzzzzzzzzk_);
            bool? uzzzzzzzzzzzzzzzzzx_ = context.Operators.And(uzzzzzzzzzzzzzzzzzm_, uzzzzzzzzzzzzzzzzzw_);

            return uzzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<(CqlTupleMetadata, Observation HeartRate, Encounter ModerateOrSevereLVSDHFOutpatientEncounter)?> tzzzzzzzzzzzzzzzzzq_ = context.Operators.Where<(CqlTupleMetadata, Observation HeartRate, Encounter ModerateOrSevereLVSDHFOutpatientEncounter)?>(tzzzzzzzzzzzzzzzzzo_, tzzzzzzzzzzzzzzzzzp_);
        Observation tzzzzzzzzzzzzzzzzzr_((CqlTupleMetadata, Observation HeartRate, Encounter ModerateOrSevereLVSDHFOutpatientEncounter)? tuple_fufpmqdratbglhghdwfuubanf) =>
            tuple_fufpmqdratbglhghdwfuubanf?.HeartRate;
        IEnumerable<Observation> tzzzzzzzzzzzzzzzzzs_ = context.Operators.Select<(CqlTupleMetadata, Observation HeartRate, Encounter ModerateOrSevereLVSDHFOutpatientEncounter)?, Observation>(tzzzzzzzzzzzzzzzzzq_, tzzzzzzzzzzzzzzzzzr_);
        IEnumerable<Observation> tzzzzzzzzzzzzzzzzzt_ = context.Operators.Distinct<Observation>(tzzzzzzzzzzzzzzzzzs_);
        bool? tzzzzzzzzzzzzzzzzzu_ = context.Operators.Exists<Observation>(tzzzzzzzzzzzzzzzzzt_);

        return tzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Has Hypotension Diagnosis")]
    public bool? Has_Hypotension_Diagnosis(CqlContext context)
    {
        CqlValueSet vzzzzzzzzzzzzzzzzzq_ = this.Hypotension(context);
        IEnumerable<Condition> vzzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? vzzzzzzzzzzzzzzzzzs_(Condition Hypotension)
        {
            bool? vzzzzzzzzzzzzzzzzzv_ = AHAOverall_2_8_000.Instance.overlapsHeartFailureOutpatientEncounter(context, Hypotension);
            bool? vzzzzzzzzzzzzzzzzzw_ = AHAOverall_2_8_000.Instance.isConfirmedActiveDiagnosis(context, Hypotension);
            bool? vzzzzzzzzzzzzzzzzzx_ = context.Operators.And(vzzzzzzzzzzzzzzzzzv_, vzzzzzzzzzzzzzzzzzw_);

            return vzzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<Condition> vzzzzzzzzzzzzzzzzzt_ = context.Operators.Where<Condition>(vzzzzzzzzzzzzzzzzzr_, vzzzzzzzzzzzzzzzzzs_);
        bool? vzzzzzzzzzzzzzzzzzu_ = context.Operators.Exists<Condition>(vzzzzzzzzzzzzzzzzzt_);

        return vzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Has Asthma Diagnosis")]
    public bool? Has_Asthma_Diagnosis(CqlContext context)
    {
        CqlValueSet vzzzzzzzzzzzzzzzzzy_ = this.Asthma(context);
        IEnumerable<Condition> vzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? wzzzzzzzzzzzzzzzzza_(Condition Asthma)
        {
            bool? wzzzzzzzzzzzzzzzzzd_ = AHAOverall_2_8_000.Instance.overlapsHeartFailureOutpatientEncounter(context, Asthma);
            bool? wzzzzzzzzzzzzzzzzze_ = AHAOverall_2_8_000.Instance.isConfirmedActiveDiagnosis(context, Asthma);
            bool? wzzzzzzzzzzzzzzzzzf_ = context.Operators.And(wzzzzzzzzzzzzzzzzzd_, wzzzzzzzzzzzzzzzzze_);

            return wzzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<Condition> wzzzzzzzzzzzzzzzzzb_ = context.Operators.Where<Condition>(vzzzzzzzzzzzzzzzzzz_, wzzzzzzzzzzzzzzzzza_);
        bool? wzzzzzzzzzzzzzzzzzc_ = context.Operators.Exists<Condition>(wzzzzzzzzzzzzzzzzzb_);

        return wzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Has Diagnosis of Allergy or Intolerance to Beta Blocker Therapy")]
    public bool? Has_Diagnosis_of_Allergy_or_Intolerance_to_Beta_Blocker_Therapy(CqlContext context)
    {
        CqlValueSet wzzzzzzzzzzzzzzzzzg_ = this.Allergy_to_Beta_Blocker_Therapy(context);
        IEnumerable<Condition> wzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet wzzzzzzzzzzzzzzzzzi_ = this.Intolerance_to_Beta_Blocker_Therapy(context);
        IEnumerable<Condition> wzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> wzzzzzzzzzzzzzzzzzk_ = context.Operators.Union<Condition>(wzzzzzzzzzzzzzzzzzh_, wzzzzzzzzzzzzzzzzzj_);
        bool? wzzzzzzzzzzzzzzzzzl_(Condition BetaBlockerAllergyOrIntoleranceDiagnosis)
        {
            bool? wzzzzzzzzzzzzzzzzzo_ = AHAOverall_2_8_000.Instance.overlapsAfterHeartFailureOutpatientEncounter(context, BetaBlockerAllergyOrIntoleranceDiagnosis);
            bool? wzzzzzzzzzzzzzzzzzp_ = AHAOverall_2_8_000.Instance.isConfirmedActiveDiagnosis(context, BetaBlockerAllergyOrIntoleranceDiagnosis);
            bool? wzzzzzzzzzzzzzzzzzq_ = context.Operators.And(wzzzzzzzzzzzzzzzzzo_, wzzzzzzzzzzzzzzzzzp_);

            return wzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<Condition> wzzzzzzzzzzzzzzzzzm_ = context.Operators.Where<Condition>(wzzzzzzzzzzzzzzzzzk_, wzzzzzzzzzzzzzzzzzl_);
        bool? wzzzzzzzzzzzzzzzzzn_ = context.Operators.Exists<Condition>(wzzzzzzzzzzzzzzzzzm_);

        return wzzzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Has Bradycardia Diagnosis")]
    public bool? Has_Bradycardia_Diagnosis(CqlContext context)
    {
        CqlValueSet wzzzzzzzzzzzzzzzzzr_ = this.Bradycardia(context);
        IEnumerable<Condition> wzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? wzzzzzzzzzzzzzzzzzt_(Condition Bradycardia)
        {
            bool? wzzzzzzzzzzzzzzzzzw_ = AHAOverall_2_8_000.Instance.overlapsHeartFailureOutpatientEncounter(context, Bradycardia);
            bool? wzzzzzzzzzzzzzzzzzx_ = AHAOverall_2_8_000.Instance.isConfirmedActiveDiagnosis(context, Bradycardia);
            bool? wzzzzzzzzzzzzzzzzzy_ = context.Operators.And(wzzzzzzzzzzzzzzzzzw_, wzzzzzzzzzzzzzzzzzx_);

            return wzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<Condition> wzzzzzzzzzzzzzzzzzu_ = context.Operators.Where<Condition>(wzzzzzzzzzzzzzzzzzs_, wzzzzzzzzzzzzzzzzzt_);
        bool? wzzzzzzzzzzzzzzzzzv_ = context.Operators.Exists<Condition>(wzzzzzzzzzzzzzzzzzu_);

        return wzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Has Allergy or Intolerance to Beta Blocker Therapy Ingredient")]
    [CqlTag("commentedOut", "implies logic")]
    [CqlTag("commentedOutReason", "implies not available in cql-execution. Reference https://github.com/cqframework/cql-execution/issues/319.")]
    public bool? Has_Allergy_or_Intolerance_to_Beta_Blocker_Therapy_Ingredient(CqlContext context)
    {
        CqlValueSet wzzzzzzzzzzzzzzzzzz_ = this.Beta_Blocker_Therapy_Ingredient(context);
        IEnumerable<AllergyIntolerance> xzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<AllergyIntolerance>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-allergyintolerance"));
        CqlCode xzzzzzzzzzzzzzzzzzb_ = this.Substance_with_beta_adrenergic_receptor_antagonist_mechanism_of_action__substance_(context);
        IEnumerable<CqlCode> xzzzzzzzzzzzzzzzzzc_ = context.Operators.ToList<CqlCode>(xzzzzzzzzzzzzzzzzzb_);
        IEnumerable<AllergyIntolerance> xzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<AllergyIntolerance>(new RetrieveParameters(default, default, xzzzzzzzzzzzzzzzzzc_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-allergyintolerance"));
        IEnumerable<AllergyIntolerance> xzzzzzzzzzzzzzzzzze_ = context.Operators.Union<AllergyIntolerance>(xzzzzzzzzzzzzzzzzza_, xzzzzzzzzzzzzzzzzzd_);
        bool? xzzzzzzzzzzzzzzzzzf_(AllergyIntolerance BetaBlockerAllergyIntolerance)
        {
            bool? xzzzzzzzzzzzzzzzzzi_ = AHAOverall_2_8_000.Instance.overlapsAfterHeartFailureOutpatientEncounter(context, BetaBlockerAllergyIntolerance);
            CodeableConcept xzzzzzzzzzzzzzzzzzj_ = BetaBlockerAllergyIntolerance?.ClinicalStatus;
            CqlConcept xzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, xzzzzzzzzzzzzzzzzzj_);
            CqlCode xzzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.allergy_active(context);
            CqlConcept xzzzzzzzzzzzzzzzzzm_ = context.Operators.ConvertCodeToConcept(xzzzzzzzzzzzzzzzzzl_);
            bool? xzzzzzzzzzzzzzzzzzn_ = context.Operators.Equivalent(xzzzzzzzzzzzzzzzzzk_, xzzzzzzzzzzzzzzzzzm_);
            bool? xzzzzzzzzzzzzzzzzzo_ = context.Operators.And(xzzzzzzzzzzzzzzzzzi_, xzzzzzzzzzzzzzzzzzn_);

            return xzzzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<AllergyIntolerance> xzzzzzzzzzzzzzzzzzg_ = context.Operators.Where<AllergyIntolerance>(xzzzzzzzzzzzzzzzzze_, xzzzzzzzzzzzzzzzzzf_);
        bool? xzzzzzzzzzzzzzzzzzh_ = context.Operators.Exists<AllergyIntolerance>(xzzzzzzzzzzzzzzzzzg_);

        return xzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Has Atrioventricular Block Diagnosis")]
    public bool? Has_Atrioventricular_Block_Diagnosis(CqlContext context)
    {
        CqlValueSet xzzzzzzzzzzzzzzzzzp_ = this.Atrioventricular_Block(context);
        IEnumerable<Condition> xzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? xzzzzzzzzzzzzzzzzzr_(Condition AtrioventricularBlock)
        {
            bool? xzzzzzzzzzzzzzzzzzu_ = AHAOverall_2_8_000.Instance.overlapsHeartFailureOutpatientEncounter(context, AtrioventricularBlock);
            bool? xzzzzzzzzzzzzzzzzzv_ = AHAOverall_2_8_000.Instance.isConfirmedActiveDiagnosis(context, AtrioventricularBlock);
            bool? xzzzzzzzzzzzzzzzzzw_ = context.Operators.And(xzzzzzzzzzzzzzzzzzu_, xzzzzzzzzzzzzzzzzzv_);

            return xzzzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<Condition> xzzzzzzzzzzzzzzzzzs_ = context.Operators.Where<Condition>(xzzzzzzzzzzzzzzzzzq_, xzzzzzzzzzzzzzzzzzr_);
        bool? xzzzzzzzzzzzzzzzzzt_ = context.Operators.Exists<Condition>(xzzzzzzzzzzzzzzzzzs_);

        return xzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Has Diagnosis of Cardiac Pacer in Situ")]
    public bool? Has_Diagnosis_of_Cardiac_Pacer_in_Situ(CqlContext context)
    {
        CqlValueSet xzzzzzzzzzzzzzzzzzx_ = this.Cardiac_Pacer_in_Situ(context);
        IEnumerable<Condition> xzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? xzzzzzzzzzzzzzzzzzz_(Condition CardiacPacerDiagnosis)
        {
            bool? yzzzzzzzzzzzzzzzzzc_ = AHAOverall_2_8_000.Instance.overlapsAfterHeartFailureOutpatientEncounter(context, CardiacPacerDiagnosis);
            bool? yzzzzzzzzzzzzzzzzzd_ = AHAOverall_2_8_000.Instance.isConfirmedActiveDiagnosis(context, CardiacPacerDiagnosis);
            bool? yzzzzzzzzzzzzzzzzze_ = context.Operators.And(yzzzzzzzzzzzzzzzzzc_, yzzzzzzzzzzzzzzzzzd_);

            return yzzzzzzzzzzzzzzzzze_;
        };
        IEnumerable<Condition> yzzzzzzzzzzzzzzzzza_ = context.Operators.Where<Condition>(xzzzzzzzzzzzzzzzzzy_, xzzzzzzzzzzzzzzzzzz_);
        bool? yzzzzzzzzzzzzzzzzzb_ = context.Operators.Exists<Condition>(yzzzzzzzzzzzzzzzzza_);

        return yzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Has Cardiac Pacer Device Implanted")]
    public bool? Has_Cardiac_Pacer_Device_Implanted(CqlContext context)
    {
        CqlValueSet yzzzzzzzzzzzzzzzzzf_ = this.Cardiac_Pacer(context);
        IEnumerable<Procedure> yzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> yzzzzzzzzzzzzzzzzzh_(Procedure ImplantedCardiacPacer)
        {
            IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzm_ = AHAOverall_2_8_000.Instance.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
            bool? yzzzzzzzzzzzzzzzzzn_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
            {
                DataType yzzzzzzzzzzzzzzzzzr_ = ImplantedCardiacPacer?.Performed;
                object yzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzr_);
                CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.toInterval(context, yzzzzzzzzzzzzzzzzzs_);
                CqlDateTime yzzzzzzzzzzzzzzzzzu_ = context.Operators.Start(yzzzzzzzzzzzzzzzzzt_);
                Period yzzzzzzzzzzzzzzzzzv_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
                CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzzzzzzzzzzzzzzv_);
                CqlDateTime yzzzzzzzzzzzzzzzzzx_ = context.Operators.End(yzzzzzzzzzzzzzzzzzw_);
                bool? yzzzzzzzzzzzzzzzzzy_ = context.Operators.Before(yzzzzzzzzzzzzzzzzzu_, yzzzzzzzzzzzzzzzzzx_, default);

                return yzzzzzzzzzzzzzzzzzy_;
            };
            IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<Encounter>(yzzzzzzzzzzzzzzzzzm_, yzzzzzzzzzzzzzzzzzn_);
            Procedure yzzzzzzzzzzzzzzzzzp_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter) =>
                ImplantedCardiacPacer;
            IEnumerable<Procedure> yzzzzzzzzzzzzzzzzzq_ = context.Operators.Select<Encounter, Procedure>(yzzzzzzzzzzzzzzzzzo_, yzzzzzzzzzzzzzzzzzp_);

            return yzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<Procedure> yzzzzzzzzzzzzzzzzzi_ = context.Operators.SelectMany<Procedure, Procedure>(yzzzzzzzzzzzzzzzzzg_, yzzzzzzzzzzzzzzzzzh_);
        bool? yzzzzzzzzzzzzzzzzzj_(Procedure ImplantedCardiacPacer)
        {
            Code<EventStatus> yzzzzzzzzzzzzzzzzzz_ = ImplantedCardiacPacer?.StatusElement;
            EventStatus? zzzzzzzzzzzzzzzzzza_ = yzzzzzzzzzzzzzzzzzz_?.Value;
            string zzzzzzzzzzzzzzzzzzb_ = context.Operators.Convert<string>(zzzzzzzzzzzzzzzzzza_);
            bool? zzzzzzzzzzzzzzzzzzc_ = context.Operators.Equal(zzzzzzzzzzzzzzzzzzb_, "completed");

            return zzzzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<Procedure> yzzzzzzzzzzzzzzzzzk_ = context.Operators.Where<Procedure>(yzzzzzzzzzzzzzzzzzi_, yzzzzzzzzzzzzzzzzzj_);
        bool? yzzzzzzzzzzzzzzzzzl_ = context.Operators.Exists<Procedure>(yzzzzzzzzzzzzzzzzzk_);

        return yzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Atrioventricular Block without Cardiac Pacer")]
    public bool? Atrioventricular_Block_without_Cardiac_Pacer(CqlContext context)
    {
        bool? zzzzzzzzzzzzzzzzzzd_ = this.Has_Atrioventricular_Block_Diagnosis(context);
        bool? zzzzzzzzzzzzzzzzzze_ = this.Has_Diagnosis_of_Cardiac_Pacer_in_Situ(context);
        bool? zzzzzzzzzzzzzzzzzzf_ = context.Operators.Not(zzzzzzzzzzzzzzzzzze_);
        bool? zzzzzzzzzzzzzzzzzzg_ = context.Operators.And(zzzzzzzzzzzzzzzzzzd_, zzzzzzzzzzzzzzzzzzf_);
        bool? zzzzzzzzzzzzzzzzzzh_ = this.Has_Cardiac_Pacer_Device_Implanted(context);
        bool? zzzzzzzzzzzzzzzzzzi_ = context.Operators.Not(zzzzzzzzzzzzzzzzzzh_);
        bool? zzzzzzzzzzzzzzzzzzj_ = context.Operators.And(zzzzzzzzzzzzzzzzzzg_, zzzzzzzzzzzzzzzzzzi_);

        return zzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Denominator Exceptions")]
    [CqlTag("commentedOuf", "\"Has Medical or Patient Reason for Not Ordering Beta Blocker for LVSD\"")]
    [CqlTag("commentedOufReason", "Negation issue noted in https://github.com/cqframework/cql-execution/issues/296, which is tied to https://oncprojectracking.healthit.gov/support/browse/BONNIEMAT-1455")]
    public bool? Denominator_Exceptions(CqlContext context)
    {
        bool? zzzzzzzzzzzzzzzzzzk_ = this.Has_Consecutive_Heart_Rates_Less_than_50(context);
        bool? zzzzzzzzzzzzzzzzzzl_ = this.Has_Hypotension_Diagnosis(context);
        bool? zzzzzzzzzzzzzzzzzzm_ = context.Operators.Or(zzzzzzzzzzzzzzzzzzk_, zzzzzzzzzzzzzzzzzzl_);
        bool? zzzzzzzzzzzzzzzzzzn_ = this.Has_Asthma_Diagnosis(context);
        bool? zzzzzzzzzzzzzzzzzzo_ = context.Operators.Or(zzzzzzzzzzzzzzzzzzm_, zzzzzzzzzzzzzzzzzzn_);
        bool? zzzzzzzzzzzzzzzzzzp_ = this.Has_Diagnosis_of_Allergy_or_Intolerance_to_Beta_Blocker_Therapy(context);
        bool? zzzzzzzzzzzzzzzzzzq_ = context.Operators.Or(zzzzzzzzzzzzzzzzzzo_, zzzzzzzzzzzzzzzzzzp_);
        bool? zzzzzzzzzzzzzzzzzzr_ = this.Has_Bradycardia_Diagnosis(context);
        bool? zzzzzzzzzzzzzzzzzzs_ = context.Operators.Or(zzzzzzzzzzzzzzzzzzq_, zzzzzzzzzzzzzzzzzzr_);
        bool? zzzzzzzzzzzzzzzzzzt_ = this.Has_Allergy_or_Intolerance_to_Beta_Blocker_Therapy_Ingredient(context);
        bool? zzzzzzzzzzzzzzzzzzu_ = context.Operators.Or(zzzzzzzzzzzzzzzzzzs_, zzzzzzzzzzzzzzzzzzt_);
        bool? zzzzzzzzzzzzzzzzzzv_ = this.Atrioventricular_Block_without_Cardiac_Pacer(context);
        bool? zzzzzzzzzzzzzzzzzzw_ = context.Operators.Or(zzzzzzzzzzzzzzzzzzu_, zzzzzzzzzzzzzzzzzzv_);

        return zzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? zzzzzzzzzzzzzzzzzzx_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return zzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> zzzzzzzzzzzzzzzzzzy_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return zzzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? zzzzzzzzzzzzzzzzzzz_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return zzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode azzzzzzzzzzzzzzzzzza_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return azzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Has Arrhythmia Diagnosis")]
    public bool? Has_Arrhythmia_Diagnosis(CqlContext context)
    {
        CqlValueSet azzzzzzzzzzzzzzzzzzb_ = this.Arrhythmia(context);
        IEnumerable<Condition> azzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? azzzzzzzzzzzzzzzzzzd_(Condition Arrhythmia)
        {
            bool? azzzzzzzzzzzzzzzzzzg_ = AHAOverall_2_8_000.Instance.overlapsHeartFailureOutpatientEncounter(context, Arrhythmia);
            bool? azzzzzzzzzzzzzzzzzzh_ = AHAOverall_2_8_000.Instance.isConfirmedActiveDiagnosis(context, Arrhythmia);
            bool? azzzzzzzzzzzzzzzzzzi_ = context.Operators.And(azzzzzzzzzzzzzzzzzzg_, azzzzzzzzzzzzzzzzzzh_);

            return azzzzzzzzzzzzzzzzzzi_;
        };
        IEnumerable<Condition> azzzzzzzzzzzzzzzzzze_ = context.Operators.Where<Condition>(azzzzzzzzzzzzzzzzzzc_, azzzzzzzzzzzzzzzzzzd_);
        bool? azzzzzzzzzzzzzzzzzzf_ = context.Operators.Exists<Condition>(azzzzzzzzzzzzzzzzzze_);

        return azzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Has Medical or Patient Reason for Not Ordering Beta Blocker for LVSD")]
    public bool? Has_Medical_or_Patient_Reason_for_Not_Ordering_Beta_Blocker_for_LVSD(CqlContext context)
    {
        CqlValueSet azzzzzzzzzzzzzzzzzzj_ = this.Beta_Blocker_Therapy_for_LVSD(context);
        IEnumerable<MedicationRequest> azzzzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-mednotrequested"));
        IEnumerable<MedicationRequest> azzzzzzzzzzzzzzzzzzl_(MedicationRequest NoBetaBlockerOrdered)
        {
            IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzq_ = AHAOverall_2_8_000.Instance.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
            bool? azzzzzzzzzzzzzzzzzzr_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
            {
                FhirDateTime azzzzzzzzzzzzzzzzzzv_ = NoBetaBlockerOrdered?.AuthoredOnElement;
                CqlDateTime azzzzzzzzzzzzzzzzzzw_ = context.Operators.Convert<CqlDateTime>(azzzzzzzzzzzzzzzzzzv_);
                Period azzzzzzzzzzzzzzzzzzx_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzzzzzzzzzzzzx_);
                bool? azzzzzzzzzzzzzzzzzzz_ = context.Operators.In<CqlDateTime>(azzzzzzzzzzzzzzzzzzw_, azzzzzzzzzzzzzzzzzzy_, "day");

                return azzzzzzzzzzzzzzzzzzz_;
            };
            IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzs_ = context.Operators.Where<Encounter>(azzzzzzzzzzzzzzzzzzq_, azzzzzzzzzzzzzzzzzzr_);
            MedicationRequest azzzzzzzzzzzzzzzzzzt_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter) =>
                NoBetaBlockerOrdered;
            IEnumerable<MedicationRequest> azzzzzzzzzzzzzzzzzzu_ = context.Operators.Select<Encounter, MedicationRequest>(azzzzzzzzzzzzzzzzzzs_, azzzzzzzzzzzzzzzzzzt_);

            return azzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<MedicationRequest> azzzzzzzzzzzzzzzzzzm_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(azzzzzzzzzzzzzzzzzzk_, azzzzzzzzzzzzzzzzzzl_);
        bool? azzzzzzzzzzzzzzzzzzn_(MedicationRequest NoBetaBlockerOrdered)
        {
            List<CodeableConcept> bzzzzzzzzzzzzzzzzzza_ = NoBetaBlockerOrdered?.ReasonCode;
            CqlConcept bzzzzzzzzzzzzzzzzzzb_(CodeableConcept @this)
            {
                CqlConcept bzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return bzzzzzzzzzzzzzzzzzzl_;
            };
            IEnumerable<CqlConcept> bzzzzzzzzzzzzzzzzzzc_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)bzzzzzzzzzzzzzzzzzza_, bzzzzzzzzzzzzzzzzzzb_);
            CqlValueSet bzzzzzzzzzzzzzzzzzzd_ = this.Medical_Reason(context);
            bool? bzzzzzzzzzzzzzzzzzze_ = context.Operators.ConceptsInValueSet(bzzzzzzzzzzzzzzzzzzc_, bzzzzzzzzzzzzzzzzzzd_);
            CqlConcept bzzzzzzzzzzzzzzzzzzg_(CodeableConcept @this)
            {
                CqlConcept bzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return bzzzzzzzzzzzzzzzzzzm_;
            };
            IEnumerable<CqlConcept> bzzzzzzzzzzzzzzzzzzh_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)bzzzzzzzzzzzzzzzzzza_, bzzzzzzzzzzzzzzzzzzg_);
            CqlValueSet bzzzzzzzzzzzzzzzzzzi_ = this.Patient_Reason(context);
            bool? bzzzzzzzzzzzzzzzzzzj_ = context.Operators.ConceptsInValueSet(bzzzzzzzzzzzzzzzzzzh_, bzzzzzzzzzzzzzzzzzzi_);
            bool? bzzzzzzzzzzzzzzzzzzk_ = context.Operators.Or(bzzzzzzzzzzzzzzzzzze_, bzzzzzzzzzzzzzzzzzzj_);

            return bzzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<MedicationRequest> azzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<MedicationRequest>(azzzzzzzzzzzzzzzzzzm_, azzzzzzzzzzzzzzzzzzn_);
        bool? azzzzzzzzzzzzzzzzzzp_ = context.Operators.Exists<MedicationRequest>(azzzzzzzzzzzzzzzzzzo_);

        return azzzzzzzzzzzzzzzzzzp_;
    }


    #endregion Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_FUFPMQdRaTBgLhghDWfUUBaNF = new(
        [typeof(Observation), typeof(Encounter)],
        ["HeartRate", "ModerateOrSevereLVSDHFOutpatientEncounter"]);

    #endregion CqlTupleMetadata Properties

}
