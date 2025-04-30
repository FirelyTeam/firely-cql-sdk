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
[CqlLibrary("AnticoagulationTherapyforAtrialFibrillationFlutterFHIR", "0.3.000")]
public partial class AnticoagulationTherapyforAtrialFibrillationFlutterFHIR_0_3_000 : ILibrary, ISingleton<AnticoagulationTherapyforAtrialFibrillationFlutterFHIR_0_3_000>
{
    private AnticoagulationTherapyforAtrialFibrillationFlutterFHIR_0_3_000() {}

    public static AnticoagulationTherapyforAtrialFibrillationFlutterFHIR_0_3_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "AnticoagulationTherapyforAtrialFibrillationFlutterFHIR";
    public string Version => "0.3.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, CQMCommon_2_2_000.Instance, QICoreCommon_2_1_000.Instance, SupplementalDataElements_3_5_000.Instance, TJCOverall_8_14_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    [CqlValueSetDefinition("Anticoagulant Therapy", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.200", valueSetVersion: null)]
    public CqlValueSet Anticoagulant_Therapy(CqlContext _) => _Anticoagulant_Therapy;
    private static readonly CqlValueSet _Anticoagulant_Therapy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.200", null);

    [CqlValueSetDefinition("Atrial Ablation", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.203", valueSetVersion: null)]
    public CqlValueSet Atrial_Ablation(CqlContext _) => _Atrial_Ablation;
    private static readonly CqlValueSet _Atrial_Ablation = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.203", null);

    [CqlValueSetDefinition("Atrial Fibrillation or Flutter", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.202", valueSetVersion: null)]
    public CqlValueSet Atrial_Fibrillation_or_Flutter(CqlContext _) => _Atrial_Fibrillation_or_Flutter;
    private static readonly CqlValueSet _Atrial_Fibrillation_or_Flutter = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.202", null);

    [CqlValueSetDefinition("Discharge To Acute Care Facility", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.87", valueSetVersion: null)]
    public CqlValueSet Discharge_To_Acute_Care_Facility(CqlContext _) => _Discharge_To_Acute_Care_Facility;
    private static readonly CqlValueSet _Discharge_To_Acute_Care_Facility = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.87", null);

    [CqlValueSetDefinition("Discharged to Health Care Facility for Hospice Care", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.207", valueSetVersion: null)]
    public CqlValueSet Discharged_to_Health_Care_Facility_for_Hospice_Care(CqlContext _) => _Discharged_to_Health_Care_Facility_for_Hospice_Care;
    private static readonly CqlValueSet _Discharged_to_Health_Care_Facility_for_Hospice_Care = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.207", null);

    [CqlValueSetDefinition("Discharged to Home for Hospice Care", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.209", valueSetVersion: null)]
    public CqlValueSet Discharged_to_Home_for_Hospice_Care(CqlContext _) => _Discharged_to_Home_for_Hospice_Care;
    private static readonly CqlValueSet _Discharged_to_Home_for_Hospice_Care = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.209", null);

    [CqlValueSetDefinition("History of Atrial Ablation", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.76", valueSetVersion: null)]
    public CqlValueSet History_of_Atrial_Ablation(CqlContext _) => _History_of_Atrial_Ablation;
    private static readonly CqlValueSet _History_of_Atrial_Ablation = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.76", null);

    [CqlValueSetDefinition("Left Against Medical Advice", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.308", valueSetVersion: null)]
    public CqlValueSet Left_Against_Medical_Advice(CqlContext _) => _Left_Against_Medical_Advice;
    private static readonly CqlValueSet _Left_Against_Medical_Advice = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.308", null);

    [CqlValueSetDefinition("Medical Reason For Not Providing Treatment", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.473", valueSetVersion: null)]
    public CqlValueSet Medical_Reason_For_Not_Providing_Treatment(CqlContext _) => _Medical_Reason_For_Not_Providing_Treatment;
    private static readonly CqlValueSet _Medical_Reason_For_Not_Providing_Treatment = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.473", null);

    [CqlValueSetDefinition("Patient Expired", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309", valueSetVersion: null)]
    public CqlValueSet Patient_Expired(CqlContext _) => _Patient_Expired;
    private static readonly CqlValueSet _Patient_Expired = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309", null);

    [CqlValueSetDefinition("Patient Refusal", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.93", valueSetVersion: null)]
    public CqlValueSet Patient_Refusal(CqlContext _) => _Patient_Refusal;
    private static readonly CqlValueSet _Patient_Refusal = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.93", null);

    #endregion ValueSets

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime ezzzzzzzzzzzzy_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime ezzzzzzzzzzzzz_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> fzzzzzzzzzzzza_ = context.Operators.Interval(ezzzzzzzzzzzzy_, ezzzzzzzzzzzzz_, true, true);
        object fzzzzzzzzzzzzb_ = context.ResolveParameter("AnticoagulationTherapyforAtrialFibrillationFlutterFHIR-0.3.000", "Measurement Period", fzzzzzzzzzzzza_);

        return (CqlInterval<CqlDateTime>)fzzzzzzzzzzzzb_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> fzzzzzzzzzzzzc_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient fzzzzzzzzzzzzd_ = context.Operators.SingletonFrom<Patient>(fzzzzzzzzzzzzc_);

        return fzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> fzzzzzzzzzzzze_ = TJCOverall_8_14_000.Instance.Ischemic_Stroke_Encounter(context);

        return fzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Encounter with a History of Atrial Ablation")]
    public IEnumerable<Encounter> Encounter_with_a_History_of_Atrial_Ablation(CqlContext context)
    {
        IEnumerable<Encounter> fzzzzzzzzzzzzf_ = TJCOverall_8_14_000.Instance.Ischemic_Stroke_Encounter(context);
        bool? fzzzzzzzzzzzzg_(Encounter IschemicStrokeEncounter)
        {
            CqlValueSet fzzzzzzzzzzzzq_ = this.Atrial_Ablation(context);
            IEnumerable<Procedure> fzzzzzzzzzzzzr_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, fzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            bool? fzzzzzzzzzzzzs_(Procedure AtrialAblationProcedure)
            {
                Code<EventStatus> fzzzzzzzzzzzzv_ = AtrialAblationProcedure?.StatusElement;
                EventStatus? fzzzzzzzzzzzzw_ = fzzzzzzzzzzzzv_?.Value;
                string fzzzzzzzzzzzzx_ = context.Operators.Convert<string>(fzzzzzzzzzzzzw_);
                bool? fzzzzzzzzzzzzy_ = context.Operators.Equal(fzzzzzzzzzzzzx_, "completed");
                DataType fzzzzzzzzzzzzz_ = AtrialAblationProcedure?.Performed;
                object gzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzz_);
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.toInterval(context, gzzzzzzzzzzzza_);
                CqlDateTime gzzzzzzzzzzzzc_ = context.Operators.Start(gzzzzzzzzzzzzb_);
                Period gzzzzzzzzzzzzd_ = IschemicStrokeEncounter?.Period;
                CqlInterval<CqlDateTime> gzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzzzzzzzd_);
                CqlDateTime gzzzzzzzzzzzzf_ = context.Operators.Start(gzzzzzzzzzzzze_);
                bool? gzzzzzzzzzzzzg_ = context.Operators.Before(gzzzzzzzzzzzzc_, gzzzzzzzzzzzzf_, default);
                bool? gzzzzzzzzzzzzh_ = context.Operators.And(fzzzzzzzzzzzzy_, gzzzzzzzzzzzzg_);

                return gzzzzzzzzzzzzh_;
            };
            IEnumerable<Procedure> fzzzzzzzzzzzzt_ = context.Operators.Where<Procedure>(fzzzzzzzzzzzzr_, fzzzzzzzzzzzzs_);
            bool? fzzzzzzzzzzzzu_ = context.Operators.Exists<Procedure>(fzzzzzzzzzzzzt_);

            return fzzzzzzzzzzzzu_;
        };
        IEnumerable<Encounter> fzzzzzzzzzzzzh_ = context.Operators.Where<Encounter>(fzzzzzzzzzzzzf_, fzzzzzzzzzzzzg_);
        IEnumerable<Encounter> fzzzzzzzzzzzzj_(Encounter IschemicStrokeEncounter)
        {
            CqlValueSet gzzzzzzzzzzzzi_ = this.History_of_Atrial_Ablation(context);
            IEnumerable<Condition> gzzzzzzzzzzzzj_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, gzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            bool? gzzzzzzzzzzzzk_(Condition AtrialAblationDiagnosis)
            {
                CodeableConcept gzzzzzzzzzzzzo_ = AtrialAblationDiagnosis?.VerificationStatus;
                CqlConcept gzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, gzzzzzzzzzzzzo_);
                bool? gzzzzzzzzzzzzq_ = context.Operators.Not((bool?)(gzzzzzzzzzzzzp_ is null));
                CqlConcept gzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, gzzzzzzzzzzzzo_);
                CqlCode gzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.confirmed(context);
                CqlConcept gzzzzzzzzzzzzu_ = context.Operators.ConvertCodeToConcept(gzzzzzzzzzzzzt_);
                bool? gzzzzzzzzzzzzv_ = context.Operators.Equivalent(gzzzzzzzzzzzzs_, gzzzzzzzzzzzzu_);
                bool? gzzzzzzzzzzzzw_ = context.Operators.And(gzzzzzzzzzzzzq_, gzzzzzzzzzzzzv_);
                DataType gzzzzzzzzzzzzx_ = AtrialAblationDiagnosis?.Onset;
                object gzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzx_);
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.toInterval(context, gzzzzzzzzzzzzy_);
                CqlDateTime hzzzzzzzzzzzza_ = context.Operators.Start(gzzzzzzzzzzzzz_);
                Period hzzzzzzzzzzzzb_ = IschemicStrokeEncounter?.Period;
                CqlInterval<CqlDateTime> hzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzzzzzzzb_);
                CqlDateTime hzzzzzzzzzzzzd_ = context.Operators.Start(hzzzzzzzzzzzzc_);
                bool? hzzzzzzzzzzzze_ = context.Operators.Before(hzzzzzzzzzzzza_, hzzzzzzzzzzzzd_, default);
                bool? hzzzzzzzzzzzzf_ = context.Operators.And(gzzzzzzzzzzzzw_, hzzzzzzzzzzzze_);

                return hzzzzzzzzzzzzf_;
            };
            IEnumerable<Condition> gzzzzzzzzzzzzl_ = context.Operators.Where<Condition>(gzzzzzzzzzzzzj_, gzzzzzzzzzzzzk_);
            Encounter gzzzzzzzzzzzzm_(Condition AtrialAblationDiagnosis) =>
                IschemicStrokeEncounter;
            IEnumerable<Encounter> gzzzzzzzzzzzzn_ = context.Operators.Select<Condition, Encounter>(gzzzzzzzzzzzzl_, gzzzzzzzzzzzzm_);

            return gzzzzzzzzzzzzn_;
        };
        IEnumerable<Encounter> fzzzzzzzzzzzzk_ = context.Operators.SelectMany<Encounter, Encounter>(fzzzzzzzzzzzzf_, fzzzzzzzzzzzzj_);
        IEnumerable<Encounter> fzzzzzzzzzzzzl_ = context.Operators.Union<Encounter>(fzzzzzzzzzzzzh_, fzzzzzzzzzzzzk_);
        IEnumerable<Encounter> fzzzzzzzzzzzzn_(Encounter IschemicStrokeEncounter)
        {
            CqlValueSet hzzzzzzzzzzzzg_ = this.History_of_Atrial_Ablation(context);
            IEnumerable<Observation> hzzzzzzzzzzzzh_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, hzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
            bool? hzzzzzzzzzzzzi_(Observation AtrialAblationObservation)
            {
                Code<ObservationStatus> hzzzzzzzzzzzzm_ = AtrialAblationObservation?.StatusElement;
                ObservationStatus? hzzzzzzzzzzzzn_ = hzzzzzzzzzzzzm_?.Value;
                Code<ObservationStatus> hzzzzzzzzzzzzo_ = context.Operators.Convert<Code<ObservationStatus>>(hzzzzzzzzzzzzn_);
                string hzzzzzzzzzzzzp_ = context.Operators.Convert<string>(hzzzzzzzzzzzzo_);
                string[] hzzzzzzzzzzzzq_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? hzzzzzzzzzzzzr_ = context.Operators.In<string>(hzzzzzzzzzzzzp_, hzzzzzzzzzzzzq_ as IEnumerable<string>);
                object hzzzzzzzzzzzzs_()
                {
                    bool hzzzzzzzzzzzzz_()
                    {
                        DataType izzzzzzzzzzzzc_ = AtrialAblationObservation?.Effective;
                        object izzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzc_);
                        bool izzzzzzzzzzzze_ = izzzzzzzzzzzzd_ is CqlDateTime;

                        return izzzzzzzzzzzze_;
                    };
                    bool izzzzzzzzzzzza_()
                    {
                        DataType izzzzzzzzzzzzf_ = AtrialAblationObservation?.Effective;
                        object izzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzf_);
                        bool izzzzzzzzzzzzh_ = izzzzzzzzzzzzg_ is CqlInterval<CqlDateTime>;

                        return izzzzzzzzzzzzh_;
                    };
                    bool izzzzzzzzzzzzb_()
                    {
                        DataType izzzzzzzzzzzzi_ = AtrialAblationObservation?.Effective;
                        object izzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzi_);
                        bool izzzzzzzzzzzzk_ = izzzzzzzzzzzzj_ is CqlDateTime;

                        return izzzzzzzzzzzzk_;
                    };
                    if (hzzzzzzzzzzzzz_())
                    {
                        DataType izzzzzzzzzzzzl_ = AtrialAblationObservation?.Effective;
                        object izzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzl_);

                        return (izzzzzzzzzzzzm_ as CqlDateTime) as object;
                    }
                    else if (izzzzzzzzzzzza_())
                    {
                        DataType izzzzzzzzzzzzn_ = AtrialAblationObservation?.Effective;
                        object izzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzn_);

                        return (izzzzzzzzzzzzo_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (izzzzzzzzzzzzb_())
                    {
                        DataType izzzzzzzzzzzzp_ = AtrialAblationObservation?.Effective;
                        object izzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzp_);

                        return (izzzzzzzzzzzzq_ as CqlDateTime) as object;
                    }
                    else
                    {
                        return null;
                    }
                };
                CqlDateTime hzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.earliest(context, hzzzzzzzzzzzzs_());
                Period hzzzzzzzzzzzzu_ = IschemicStrokeEncounter?.Period;
                CqlInterval<CqlDateTime> hzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzzzzzzzu_);
                CqlDateTime hzzzzzzzzzzzzw_ = context.Operators.End(hzzzzzzzzzzzzv_);
                bool? hzzzzzzzzzzzzx_ = context.Operators.SameOrBefore(hzzzzzzzzzzzzt_, hzzzzzzzzzzzzw_, default);
                bool? hzzzzzzzzzzzzy_ = context.Operators.And(hzzzzzzzzzzzzr_, hzzzzzzzzzzzzx_);

                return hzzzzzzzzzzzzy_;
            };
            IEnumerable<Observation> hzzzzzzzzzzzzj_ = context.Operators.Where<Observation>(hzzzzzzzzzzzzh_, hzzzzzzzzzzzzi_);
            Encounter hzzzzzzzzzzzzk_(Observation AtrialAblationObservation) =>
                IschemicStrokeEncounter;
            IEnumerable<Encounter> hzzzzzzzzzzzzl_ = context.Operators.Select<Observation, Encounter>(hzzzzzzzzzzzzj_, hzzzzzzzzzzzzk_);

            return hzzzzzzzzzzzzl_;
        };
        IEnumerable<Encounter> fzzzzzzzzzzzzo_ = context.Operators.SelectMany<Encounter, Encounter>(fzzzzzzzzzzzzf_, fzzzzzzzzzzzzn_);
        IEnumerable<Encounter> fzzzzzzzzzzzzp_ = context.Operators.Union<Encounter>(fzzzzzzzzzzzzl_, fzzzzzzzzzzzzo_);

        return fzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Encounter with Prior or Present Diagnosis of Atrial Fibrillation or Flutter")]
    public IEnumerable<Encounter> Encounter_with_Prior_or_Present_Diagnosis_of_Atrial_Fibrillation_or_Flutter(CqlContext context)
    {
        IEnumerable<Encounter> izzzzzzzzzzzzr_ = TJCOverall_8_14_000.Instance.Ischemic_Stroke_Encounter(context);
        IEnumerable<Encounter> izzzzzzzzzzzzs_(Encounter IschemicStrokeEncounter)
        {
            CqlValueSet izzzzzzzzzzzzy_ = this.Atrial_Fibrillation_or_Flutter(context);
            IEnumerable<Condition> izzzzzzzzzzzzz_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, izzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            bool? jzzzzzzzzzzzza_(Condition AtrialFibrillationFlutter)
            {
                CodeableConcept jzzzzzzzzzzzze_ = AtrialFibrillationFlutter?.VerificationStatus;
                CqlConcept jzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, jzzzzzzzzzzzze_);
                bool? jzzzzzzzzzzzzg_ = context.Operators.Not((bool?)(jzzzzzzzzzzzzf_ is null));
                CqlConcept jzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, jzzzzzzzzzzzze_);
                CqlCode jzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.confirmed(context);
                CqlConcept jzzzzzzzzzzzzk_ = context.Operators.ConvertCodeToConcept(jzzzzzzzzzzzzj_);
                bool? jzzzzzzzzzzzzl_ = context.Operators.Equivalent(jzzzzzzzzzzzzi_, jzzzzzzzzzzzzk_);
                bool? jzzzzzzzzzzzzm_ = context.Operators.And(jzzzzzzzzzzzzg_, jzzzzzzzzzzzzl_);
                DataType jzzzzzzzzzzzzn_ = AtrialFibrillationFlutter?.Onset;
                object jzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzn_);
                CqlInterval<CqlDateTime> jzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.toInterval(context, jzzzzzzzzzzzzo_);
                CqlDateTime jzzzzzzzzzzzzq_ = context.Operators.Start(jzzzzzzzzzzzzp_);
                Period jzzzzzzzzzzzzr_ = IschemicStrokeEncounter?.Period;
                CqlInterval<CqlDateTime> jzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzzzzzzzr_);
                CqlDateTime jzzzzzzzzzzzzt_ = context.Operators.End(jzzzzzzzzzzzzs_);
                bool? jzzzzzzzzzzzzu_ = context.Operators.SameOrBefore(jzzzzzzzzzzzzq_, jzzzzzzzzzzzzt_, default);
                bool? jzzzzzzzzzzzzv_ = context.Operators.And(jzzzzzzzzzzzzm_, jzzzzzzzzzzzzu_);

                return jzzzzzzzzzzzzv_;
            };
            IEnumerable<Condition> jzzzzzzzzzzzzb_ = context.Operators.Where<Condition>(izzzzzzzzzzzzz_, jzzzzzzzzzzzza_);
            Encounter jzzzzzzzzzzzzc_(Condition AtrialFibrillationFlutter) =>
                IschemicStrokeEncounter;
            IEnumerable<Encounter> jzzzzzzzzzzzzd_ = context.Operators.Select<Condition, Encounter>(jzzzzzzzzzzzzb_, jzzzzzzzzzzzzc_);

            return jzzzzzzzzzzzzd_;
        };
        IEnumerable<Encounter> izzzzzzzzzzzzt_ = context.Operators.SelectMany<Encounter, Encounter>(izzzzzzzzzzzzr_, izzzzzzzzzzzzs_);
        bool? izzzzzzzzzzzzv_(Encounter IschemicStrokeEncounter)
        {
            IEnumerable<Condition> jzzzzzzzzzzzzw_ = CQMCommon_2_2_000.Instance.encounterDiagnosis(context, IschemicStrokeEncounter);
            bool? jzzzzzzzzzzzzx_(Condition EncounterDiagnosis)
            {
                CodeableConcept kzzzzzzzzzzzza_ = EncounterDiagnosis?.Code;
                CqlConcept kzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, kzzzzzzzzzzzza_);
                CqlValueSet kzzzzzzzzzzzzc_ = this.Atrial_Fibrillation_or_Flutter(context);
                bool? kzzzzzzzzzzzzd_ = context.Operators.ConceptInValueSet(kzzzzzzzzzzzzb_, kzzzzzzzzzzzzc_);

                return kzzzzzzzzzzzzd_;
            };
            IEnumerable<Condition> jzzzzzzzzzzzzy_ = context.Operators.Where<Condition>(jzzzzzzzzzzzzw_, jzzzzzzzzzzzzx_);
            bool? jzzzzzzzzzzzzz_ = context.Operators.Exists<Condition>(jzzzzzzzzzzzzy_);

            return jzzzzzzzzzzzzz_;
        };
        IEnumerable<Encounter> izzzzzzzzzzzzw_ = context.Operators.Where<Encounter>(izzzzzzzzzzzzr_, izzzzzzzzzzzzv_);
        IEnumerable<Encounter> izzzzzzzzzzzzx_ = context.Operators.Union<Encounter>(izzzzzzzzzzzzt_, izzzzzzzzzzzzw_);

        return izzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context)
    {
        IEnumerable<Encounter> kzzzzzzzzzzzze_ = this.Encounter_with_a_History_of_Atrial_Ablation(context);
        IEnumerable<Encounter> kzzzzzzzzzzzzf_ = this.Encounter_with_Prior_or_Present_Diagnosis_of_Atrial_Fibrillation_or_Flutter(context);
        IEnumerable<Encounter> kzzzzzzzzzzzzg_ = context.Operators.Union<Encounter>(kzzzzzzzzzzzze_, kzzzzzzzzzzzzf_);

        return kzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Encounter with Comfort Measures during Hospitalization for Patients with Documented Atrial Fibrillation or Flutter")]
    public IEnumerable<Encounter> Encounter_with_Comfort_Measures_during_Hospitalization_for_Patients_with_Documented_Atrial_Fibrillation_or_Flutter(CqlContext context)
    {
        IEnumerable<Encounter> kzzzzzzzzzzzzh_ = this.Denominator(context);
        IEnumerable<Encounter> kzzzzzzzzzzzzi_(Encounter Encounter)
        {
            IEnumerable<object> kzzzzzzzzzzzzk_ = TJCOverall_8_14_000.Instance.Intervention_Comfort_Measures(context);
            bool? kzzzzzzzzzzzzl_(object ComfortMeasure)
            {
                object kzzzzzzzzzzzzp_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                object kzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzp_);
                CqlInterval<CqlDateTime> kzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.toInterval(context, kzzzzzzzzzzzzq_);
                CqlDateTime kzzzzzzzzzzzzs_ = context.Operators.Start(kzzzzzzzzzzzzr_);
                object kzzzzzzzzzzzzt_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "authoredOn");
                CqlDateTime kzzzzzzzzzzzzu_ = context.Operators.LateBoundProperty<CqlDateTime>(kzzzzzzzzzzzzt_, "value");
                CqlInterval<CqlDateTime> kzzzzzzzzzzzzv_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservation(context, Encounter);
                bool? kzzzzzzzzzzzzw_ = context.Operators.In<CqlDateTime>(kzzzzzzzzzzzzs_ ?? kzzzzzzzzzzzzu_, kzzzzzzzzzzzzv_, default);

                return kzzzzzzzzzzzzw_;
            };
            IEnumerable<object> kzzzzzzzzzzzzm_ = context.Operators.Where<object>(kzzzzzzzzzzzzk_, kzzzzzzzzzzzzl_);
            Encounter kzzzzzzzzzzzzn_(object ComfortMeasure) =>
                Encounter;
            IEnumerable<Encounter> kzzzzzzzzzzzzo_ = context.Operators.Select<object, Encounter>(kzzzzzzzzzzzzm_, kzzzzzzzzzzzzn_);

            return kzzzzzzzzzzzzo_;
        };
        IEnumerable<Encounter> kzzzzzzzzzzzzj_ = context.Operators.SelectMany<Encounter, Encounter>(kzzzzzzzzzzzzh_, kzzzzzzzzzzzzi_);

        return kzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public IEnumerable<Encounter> Denominator_Exclusions(CqlContext context)
    {
        IEnumerable<Encounter> kzzzzzzzzzzzzx_ = this.Denominator(context);
        bool? kzzzzzzzzzzzzy_(Encounter Encounter)
        {
            Code<Encounter.EncounterStatus> lzzzzzzzzzzzzc_ = Encounter?.StatusElement;
            Encounter.EncounterStatus? lzzzzzzzzzzzzd_ = lzzzzzzzzzzzzc_?.Value;
            Code<Encounter.EncounterStatus> lzzzzzzzzzzzze_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(lzzzzzzzzzzzzd_);
            bool? lzzzzzzzzzzzzf_ = context.Operators.Equal(lzzzzzzzzzzzze_, "finished");
            Encounter.HospitalizationComponent lzzzzzzzzzzzzg_ = Encounter?.Hospitalization;
            CodeableConcept lzzzzzzzzzzzzh_ = lzzzzzzzzzzzzg_?.DischargeDisposition;
            CqlConcept lzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, lzzzzzzzzzzzzh_);
            CqlValueSet lzzzzzzzzzzzzj_ = this.Discharge_To_Acute_Care_Facility(context);
            bool? lzzzzzzzzzzzzk_ = context.Operators.ConceptInValueSet(lzzzzzzzzzzzzi_, lzzzzzzzzzzzzj_);
            CodeableConcept lzzzzzzzzzzzzm_ = lzzzzzzzzzzzzg_?.DischargeDisposition;
            CqlConcept lzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, lzzzzzzzzzzzzm_);
            CqlValueSet lzzzzzzzzzzzzo_ = this.Left_Against_Medical_Advice(context);
            bool? lzzzzzzzzzzzzp_ = context.Operators.ConceptInValueSet(lzzzzzzzzzzzzn_, lzzzzzzzzzzzzo_);
            bool? lzzzzzzzzzzzzq_ = context.Operators.Or(lzzzzzzzzzzzzk_, lzzzzzzzzzzzzp_);
            CodeableConcept lzzzzzzzzzzzzs_ = lzzzzzzzzzzzzg_?.DischargeDisposition;
            CqlConcept lzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, lzzzzzzzzzzzzs_);
            CqlValueSet lzzzzzzzzzzzzu_ = this.Patient_Expired(context);
            bool? lzzzzzzzzzzzzv_ = context.Operators.ConceptInValueSet(lzzzzzzzzzzzzt_, lzzzzzzzzzzzzu_);
            bool? lzzzzzzzzzzzzw_ = context.Operators.Or(lzzzzzzzzzzzzq_, lzzzzzzzzzzzzv_);
            CodeableConcept lzzzzzzzzzzzzy_ = lzzzzzzzzzzzzg_?.DischargeDisposition;
            CqlConcept lzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, lzzzzzzzzzzzzy_);
            CqlValueSet mzzzzzzzzzzzza_ = this.Discharged_to_Home_for_Hospice_Care(context);
            bool? mzzzzzzzzzzzzb_ = context.Operators.ConceptInValueSet(lzzzzzzzzzzzzz_, mzzzzzzzzzzzza_);
            bool? mzzzzzzzzzzzzc_ = context.Operators.Or(lzzzzzzzzzzzzw_, mzzzzzzzzzzzzb_);
            CodeableConcept mzzzzzzzzzzzze_ = lzzzzzzzzzzzzg_?.DischargeDisposition;
            CqlConcept mzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, mzzzzzzzzzzzze_);
            CqlValueSet mzzzzzzzzzzzzg_ = this.Discharged_to_Health_Care_Facility_for_Hospice_Care(context);
            bool? mzzzzzzzzzzzzh_ = context.Operators.ConceptInValueSet(mzzzzzzzzzzzzf_, mzzzzzzzzzzzzg_);
            bool? mzzzzzzzzzzzzi_ = context.Operators.Or(mzzzzzzzzzzzzc_, mzzzzzzzzzzzzh_);
            bool? mzzzzzzzzzzzzj_ = context.Operators.And(lzzzzzzzzzzzzf_, mzzzzzzzzzzzzi_);

            return mzzzzzzzzzzzzj_;
        };
        IEnumerable<Encounter> kzzzzzzzzzzzzz_ = context.Operators.Where<Encounter>(kzzzzzzzzzzzzx_, kzzzzzzzzzzzzy_);
        IEnumerable<Encounter> lzzzzzzzzzzzza_ = this.Encounter_with_Comfort_Measures_during_Hospitalization_for_Patients_with_Documented_Atrial_Fibrillation_or_Flutter(context);
        IEnumerable<Encounter> lzzzzzzzzzzzzb_ = context.Operators.Union<Encounter>(kzzzzzzzzzzzzz_, lzzzzzzzzzzzza_);

        return lzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context)
    {
        IEnumerable<Encounter> mzzzzzzzzzzzzk_ = this.Denominator(context);
        IEnumerable<Encounter> mzzzzzzzzzzzzl_(Encounter Encounter)
        {
            CqlValueSet mzzzzzzzzzzzzn_ = this.Anticoagulant_Therapy(context);
            IEnumerable<MedicationRequest> mzzzzzzzzzzzzo_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, mzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> mzzzzzzzzzzzzq_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, mzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> mzzzzzzzzzzzzr_ = context.Operators.Union<MedicationRequest>(mzzzzzzzzzzzzo_, mzzzzzzzzzzzzq_);
            bool? mzzzzzzzzzzzzs_(MedicationRequest DischargeAnticoagulant)
            {
                bool? mzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.isCommunity(context, DischargeAnticoagulant);
                bool? mzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.isDischarge(context, DischargeAnticoagulant);
                bool? mzzzzzzzzzzzzy_ = context.Operators.Or(mzzzzzzzzzzzzw_, mzzzzzzzzzzzzx_);
                Code<MedicationRequest.MedicationrequestStatus> mzzzzzzzzzzzzz_ = DischargeAnticoagulant?.StatusElement;
                MedicationRequest.MedicationrequestStatus? nzzzzzzzzzzzza_ = mzzzzzzzzzzzzz_?.Value;
                string nzzzzzzzzzzzzb_ = context.Operators.Convert<string>(nzzzzzzzzzzzza_);
                string[] nzzzzzzzzzzzzc_ = [
                    "active",
                    "completed",
                ];
                bool? nzzzzzzzzzzzzd_ = context.Operators.In<string>(nzzzzzzzzzzzzb_, nzzzzzzzzzzzzc_ as IEnumerable<string>);
                bool? nzzzzzzzzzzzze_ = context.Operators.And(mzzzzzzzzzzzzy_, nzzzzzzzzzzzzd_);
                Code<MedicationRequest.MedicationRequestIntent> nzzzzzzzzzzzzf_ = DischargeAnticoagulant?.IntentElement;
                MedicationRequest.MedicationRequestIntent? nzzzzzzzzzzzzg_ = nzzzzzzzzzzzzf_?.Value;
                string nzzzzzzzzzzzzh_ = context.Operators.Convert<string>(nzzzzzzzzzzzzg_);
                string[] nzzzzzzzzzzzzi_ = [
                    "order",
                    "original-order",
                    "reflex-order",
                    "filler-order",
                    "instance-order",
                ];
                bool? nzzzzzzzzzzzzj_ = context.Operators.In<string>(nzzzzzzzzzzzzh_, nzzzzzzzzzzzzi_ as IEnumerable<string>);
                bool? nzzzzzzzzzzzzk_ = context.Operators.And(nzzzzzzzzzzzze_, nzzzzzzzzzzzzj_);
                FhirDateTime nzzzzzzzzzzzzl_ = DischargeAnticoagulant?.AuthoredOnElement;
                CqlDateTime nzzzzzzzzzzzzm_ = context.Operators.Convert<CqlDateTime>(nzzzzzzzzzzzzl_);
                Period nzzzzzzzzzzzzn_ = Encounter?.Period;
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzzzzzzzzn_);
                bool? nzzzzzzzzzzzzp_ = context.Operators.In<CqlDateTime>(nzzzzzzzzzzzzm_, nzzzzzzzzzzzzo_, default);
                bool? nzzzzzzzzzzzzq_ = context.Operators.And(nzzzzzzzzzzzzk_, nzzzzzzzzzzzzp_);

                return nzzzzzzzzzzzzq_;
            };
            IEnumerable<MedicationRequest> mzzzzzzzzzzzzt_ = context.Operators.Where<MedicationRequest>(mzzzzzzzzzzzzr_, mzzzzzzzzzzzzs_);
            Encounter mzzzzzzzzzzzzu_(MedicationRequest DischargeAnticoagulant) =>
                Encounter;
            IEnumerable<Encounter> mzzzzzzzzzzzzv_ = context.Operators.Select<MedicationRequest, Encounter>(mzzzzzzzzzzzzt_, mzzzzzzzzzzzzu_);

            return mzzzzzzzzzzzzv_;
        };
        IEnumerable<Encounter> mzzzzzzzzzzzzm_ = context.Operators.SelectMany<Encounter, Encounter>(mzzzzzzzzzzzzk_, mzzzzzzzzzzzzl_);

        return mzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Documented Reason for Not Giving Anticoagulant at Discharge")]
    public IEnumerable<MedicationRequest> Documented_Reason_for_Not_Giving_Anticoagulant_at_Discharge(CqlContext context)
    {
        CqlValueSet nzzzzzzzzzzzzr_ = this.Anticoagulant_Therapy(context);
        IEnumerable<MedicationRequest> nzzzzzzzzzzzzs_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, nzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-mednotrequested"));
        bool? nzzzzzzzzzzzzt_(MedicationRequest NoAnticoagulant)
        {
            List<CodeableConcept> nzzzzzzzzzzzzv_ = NoAnticoagulant?.ReasonCode;
            CqlConcept nzzzzzzzzzzzzw_(CodeableConcept @this)
            {
                CqlConcept ozzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return ozzzzzzzzzzzzq_;
            };
            IEnumerable<CqlConcept> nzzzzzzzzzzzzx_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)nzzzzzzzzzzzzv_, nzzzzzzzzzzzzw_);
            CqlValueSet nzzzzzzzzzzzzy_ = this.Medical_Reason_For_Not_Providing_Treatment(context);
            bool? nzzzzzzzzzzzzz_ = context.Operators.ConceptsInValueSet(nzzzzzzzzzzzzx_, nzzzzzzzzzzzzy_);
            CqlConcept ozzzzzzzzzzzzb_(CodeableConcept @this)
            {
                CqlConcept ozzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return ozzzzzzzzzzzzr_;
            };
            IEnumerable<CqlConcept> ozzzzzzzzzzzzc_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)nzzzzzzzzzzzzv_, ozzzzzzzzzzzzb_);
            CqlValueSet ozzzzzzzzzzzzd_ = this.Patient_Refusal(context);
            bool? ozzzzzzzzzzzze_ = context.Operators.ConceptsInValueSet(ozzzzzzzzzzzzc_, ozzzzzzzzzzzzd_);
            bool? ozzzzzzzzzzzzf_ = context.Operators.Or(nzzzzzzzzzzzzz_, ozzzzzzzzzzzze_);
            bool? ozzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.isCommunity(context, NoAnticoagulant);
            bool? ozzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.isDischarge(context, NoAnticoagulant);
            bool? ozzzzzzzzzzzzi_ = context.Operators.Or(ozzzzzzzzzzzzg_, ozzzzzzzzzzzzh_);
            bool? ozzzzzzzzzzzzj_ = context.Operators.And(ozzzzzzzzzzzzf_, ozzzzzzzzzzzzi_);
            Code<MedicationRequest.MedicationRequestIntent> ozzzzzzzzzzzzk_ = NoAnticoagulant?.IntentElement;
            MedicationRequest.MedicationRequestIntent? ozzzzzzzzzzzzl_ = ozzzzzzzzzzzzk_?.Value;
            string ozzzzzzzzzzzzm_ = context.Operators.Convert<string>(ozzzzzzzzzzzzl_);
            string[] ozzzzzzzzzzzzn_ = [
                "order",
                "original-order",
                "reflex-order",
                "filler-order",
                "instance-order",
            ];
            bool? ozzzzzzzzzzzzo_ = context.Operators.In<string>(ozzzzzzzzzzzzm_, ozzzzzzzzzzzzn_ as IEnumerable<string>);
            bool? ozzzzzzzzzzzzp_ = context.Operators.And(ozzzzzzzzzzzzj_, ozzzzzzzzzzzzo_);

            return ozzzzzzzzzzzzp_;
        };
        IEnumerable<MedicationRequest> nzzzzzzzzzzzzu_ = context.Operators.Where<MedicationRequest>(nzzzzzzzzzzzzs_, nzzzzzzzzzzzzt_);

        return nzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Denominator Exceptions")]
    public IEnumerable<Encounter> Denominator_Exceptions(CqlContext context)
    {
        IEnumerable<Encounter> ozzzzzzzzzzzzs_ = this.Denominator(context);
        IEnumerable<Encounter> ozzzzzzzzzzzzt_(Encounter Encounter)
        {
            IEnumerable<MedicationRequest> ozzzzzzzzzzzzv_ = this.Documented_Reason_for_Not_Giving_Anticoagulant_at_Discharge(context);
            bool? ozzzzzzzzzzzzw_(MedicationRequest NoDischargeAnticoagulant)
            {
                FhirDateTime pzzzzzzzzzzzza_ = NoDischargeAnticoagulant?.AuthoredOnElement;
                CqlDateTime pzzzzzzzzzzzzb_ = context.Operators.Convert<CqlDateTime>(pzzzzzzzzzzzza_);
                Period pzzzzzzzzzzzzc_ = Encounter?.Period;
                CqlInterval<CqlDateTime> pzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzzzzzzzzc_);
                bool? pzzzzzzzzzzzze_ = context.Operators.In<CqlDateTime>(pzzzzzzzzzzzzb_, pzzzzzzzzzzzzd_, default);

                return pzzzzzzzzzzzze_;
            };
            IEnumerable<MedicationRequest> ozzzzzzzzzzzzx_ = context.Operators.Where<MedicationRequest>(ozzzzzzzzzzzzv_, ozzzzzzzzzzzzw_);
            Encounter ozzzzzzzzzzzzy_(MedicationRequest NoDischargeAnticoagulant) =>
                Encounter;
            IEnumerable<Encounter> ozzzzzzzzzzzzz_ = context.Operators.Select<MedicationRequest, Encounter>(ozzzzzzzzzzzzx_, ozzzzzzzzzzzzy_);

            return ozzzzzzzzzzzzz_;
        };
        IEnumerable<Encounter> ozzzzzzzzzzzzu_ = context.Operators.SelectMany<Encounter, Encounter>(ozzzzzzzzzzzzs_, ozzzzzzzzzzzzt_);

        return ozzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? pzzzzzzzzzzzzf_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return pzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> pzzzzzzzzzzzzg_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return pzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? pzzzzzzzzzzzzh_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return pzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode pzzzzzzzzzzzzi_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return pzzzzzzzzzzzzi_;
    }


    #endregion Expressions

}
