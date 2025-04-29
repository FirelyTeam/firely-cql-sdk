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

    #region ValueSet: Anticoagulant Therapy
    [CqlValueSetDefinition(
        definitionName: "Anticoagulant Therapy",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.200",
        valueSetVersion: null)]
    public CqlValueSet Anticoagulant_Therapy(CqlContext context) => _Anticoagulant_Therapy;

    private static readonly CqlValueSet _Anticoagulant_Therapy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.200", null);
    #endregion

    #region ValueSet: Atrial Ablation
    [CqlValueSetDefinition(
        definitionName: "Atrial Ablation",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.203",
        valueSetVersion: null)]
    public CqlValueSet Atrial_Ablation(CqlContext context) => _Atrial_Ablation;

    private static readonly CqlValueSet _Atrial_Ablation = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.203", null);
    #endregion

    #region ValueSet: Atrial Fibrillation or Flutter
    [CqlValueSetDefinition(
        definitionName: "Atrial Fibrillation or Flutter",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.202",
        valueSetVersion: null)]
    public CqlValueSet Atrial_Fibrillation_or_Flutter(CqlContext context) => _Atrial_Fibrillation_or_Flutter;

    private static readonly CqlValueSet _Atrial_Fibrillation_or_Flutter = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.202", null);
    #endregion

    #region ValueSet: Discharge To Acute Care Facility
    [CqlValueSetDefinition(
        definitionName: "Discharge To Acute Care Facility",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.87",
        valueSetVersion: null)]
    public CqlValueSet Discharge_To_Acute_Care_Facility(CqlContext context) => _Discharge_To_Acute_Care_Facility;

    private static readonly CqlValueSet _Discharge_To_Acute_Care_Facility = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.87", null);
    #endregion

    #region ValueSet: Discharged to Health Care Facility for Hospice Care
    [CqlValueSetDefinition(
        definitionName: "Discharged to Health Care Facility for Hospice Care",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.207",
        valueSetVersion: null)]
    public CqlValueSet Discharged_to_Health_Care_Facility_for_Hospice_Care(CqlContext context) => _Discharged_to_Health_Care_Facility_for_Hospice_Care;

    private static readonly CqlValueSet _Discharged_to_Health_Care_Facility_for_Hospice_Care = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.207", null);
    #endregion

    #region ValueSet: Discharged to Home for Hospice Care
    [CqlValueSetDefinition(
        definitionName: "Discharged to Home for Hospice Care",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.209",
        valueSetVersion: null)]
    public CqlValueSet Discharged_to_Home_for_Hospice_Care(CqlContext context) => _Discharged_to_Home_for_Hospice_Care;

    private static readonly CqlValueSet _Discharged_to_Home_for_Hospice_Care = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.209", null);
    #endregion

    #region ValueSet: History of Atrial Ablation
    [CqlValueSetDefinition(
        definitionName: "History of Atrial Ablation",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.76",
        valueSetVersion: null)]
    public CqlValueSet History_of_Atrial_Ablation(CqlContext context) => _History_of_Atrial_Ablation;

    private static readonly CqlValueSet _History_of_Atrial_Ablation = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.76", null);
    #endregion

    #region ValueSet: Left Against Medical Advice
    [CqlValueSetDefinition(
        definitionName: "Left Against Medical Advice",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.308",
        valueSetVersion: null)]
    public CqlValueSet Left_Against_Medical_Advice(CqlContext context) => _Left_Against_Medical_Advice;

    private static readonly CqlValueSet _Left_Against_Medical_Advice = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.308", null);
    #endregion

    #region ValueSet: Medical Reason For Not Providing Treatment
    [CqlValueSetDefinition(
        definitionName: "Medical Reason For Not Providing Treatment",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.473",
        valueSetVersion: null)]
    public CqlValueSet Medical_Reason_For_Not_Providing_Treatment(CqlContext context) => _Medical_Reason_For_Not_Providing_Treatment;

    private static readonly CqlValueSet _Medical_Reason_For_Not_Providing_Treatment = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.473", null);
    #endregion

    #region ValueSet: Patient Expired
    [CqlValueSetDefinition(
        definitionName: "Patient Expired",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309",
        valueSetVersion: null)]
    public CqlValueSet Patient_Expired(CqlContext context) => _Patient_Expired;

    private static readonly CqlValueSet _Patient_Expired = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309", null);
    #endregion

    #region ValueSet: Patient Refusal
    [CqlValueSetDefinition(
        definitionName: "Patient Refusal",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.93",
        valueSetVersion: null)]
    public CqlValueSet Patient_Refusal(CqlContext context) => _Patient_Refusal;

    private static readonly CqlValueSet _Patient_Refusal = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.93", null);
    #endregion

    #endregion ValueSets

    #region Parameters

    [CqlParameterDefinition(
        definitionName: "Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime dzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime dzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Interval(dzzzzzzzzzzzzzzzzzzzzzy_, dzzzzzzzzzzzzzzzzzzzzzz_, true, true);
        object ezzzzzzzzzzzzzzzzzzzzzb_ = context.ResolveParameter("AnticoagulationTherapyforAtrialFibrillationFlutterFHIR-0.3.000", "Measurement Period", ezzzzzzzzzzzzzzzzzzzzza_);

        return (CqlInterval<CqlDateTime>)ezzzzzzzzzzzzzzzzzzzzzb_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition(
        definitionName: "Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> ezzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient ezzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.SingletonFrom<Patient>(ezzzzzzzzzzzzzzzzzzzzzc_);

        return ezzzzzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition(
        definitionName: "Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzze_ = TJCOverall_8_14_000.Instance.Ischemic_Stroke_Encounter(context);

        return ezzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition(
        definitionName: "Encounter with a History of Atrial Ablation")]
    public IEnumerable<Encounter> Encounter_with_a_History_of_Atrial_Ablation(CqlContext context)
    {
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzf_ = TJCOverall_8_14_000.Instance.Ischemic_Stroke_Encounter(context);
        bool? ezzzzzzzzzzzzzzzzzzzzzg_(Encounter IschemicStrokeEncounter)
        {
            CqlValueSet ezzzzzzzzzzzzzzzzzzzzzq_ = this.Atrial_Ablation(context);
            IEnumerable<Procedure> ezzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            bool? ezzzzzzzzzzzzzzzzzzzzzs_(Procedure AtrialAblationProcedure)
            {
                Code<EventStatus> ezzzzzzzzzzzzzzzzzzzzzv_ = AtrialAblationProcedure?.StatusElement;
                EventStatus? ezzzzzzzzzzzzzzzzzzzzzw_ = ezzzzzzzzzzzzzzzzzzzzzv_?.Value;
                string ezzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Convert<string>(ezzzzzzzzzzzzzzzzzzzzzw_);
                bool? ezzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Equal(ezzzzzzzzzzzzzzzzzzzzzx_, "completed");
                DataType ezzzzzzzzzzzzzzzzzzzzzz_ = AtrialAblationProcedure?.Performed;
                object fzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzzzzz_);
                CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.toInterval(context, fzzzzzzzzzzzzzzzzzzzzza_);
                CqlDateTime fzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Start(fzzzzzzzzzzzzzzzzzzzzzb_);
                Period fzzzzzzzzzzzzzzzzzzzzzd_ = IschemicStrokeEncounter?.Period;
                CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzzzzzzzzzzzzzzzzzd_);
                CqlDateTime fzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Start(fzzzzzzzzzzzzzzzzzzzzze_);
                bool? fzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Before(fzzzzzzzzzzzzzzzzzzzzzc_, fzzzzzzzzzzzzzzzzzzzzzf_, default);
                bool? fzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.And(ezzzzzzzzzzzzzzzzzzzzzy_, fzzzzzzzzzzzzzzzzzzzzzg_);

                return fzzzzzzzzzzzzzzzzzzzzzh_;
            };
            IEnumerable<Procedure> ezzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Where<Procedure>(ezzzzzzzzzzzzzzzzzzzzzr_, ezzzzzzzzzzzzzzzzzzzzzs_);
            bool? ezzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Exists<Procedure>(ezzzzzzzzzzzzzzzzzzzzzt_);

            return ezzzzzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Where<Encounter>(ezzzzzzzzzzzzzzzzzzzzzf_, ezzzzzzzzzzzzzzzzzzzzzg_);
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzj_(Encounter IschemicStrokeEncounter)
        {
            CqlValueSet fzzzzzzzzzzzzzzzzzzzzzi_ = this.History_of_Atrial_Ablation(context);
            IEnumerable<Condition> fzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            bool? fzzzzzzzzzzzzzzzzzzzzzk_(Condition AtrialAblationDiagnosis)
            {
                CodeableConcept fzzzzzzzzzzzzzzzzzzzzzo_ = AtrialAblationDiagnosis?.VerificationStatus;
                CqlConcept fzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, fzzzzzzzzzzzzzzzzzzzzzo_);
                bool? fzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Not((bool?)(fzzzzzzzzzzzzzzzzzzzzzp_ is null));
                CqlConcept fzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, fzzzzzzzzzzzzzzzzzzzzzo_);
                CqlCode fzzzzzzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.confirmed(context);
                CqlConcept fzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.ConvertCodeToConcept(fzzzzzzzzzzzzzzzzzzzzzt_);
                bool? fzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Equivalent(fzzzzzzzzzzzzzzzzzzzzzs_, fzzzzzzzzzzzzzzzzzzzzzu_);
                bool? fzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.And(fzzzzzzzzzzzzzzzzzzzzzq_, fzzzzzzzzzzzzzzzzzzzzzv_);
                DataType fzzzzzzzzzzzzzzzzzzzzzx_ = AtrialAblationDiagnosis?.Onset;
                object fzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzzzzzx_);
                CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.toInterval(context, fzzzzzzzzzzzzzzzzzzzzzy_);
                CqlDateTime gzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Start(fzzzzzzzzzzzzzzzzzzzzzz_);
                Period gzzzzzzzzzzzzzzzzzzzzzb_ = IschemicStrokeEncounter?.Period;
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzzzzzzzzzzzzzzzzb_);
                CqlDateTime gzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Start(gzzzzzzzzzzzzzzzzzzzzzc_);
                bool? gzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Before(gzzzzzzzzzzzzzzzzzzzzza_, gzzzzzzzzzzzzzzzzzzzzzd_, default);
                bool? gzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.And(fzzzzzzzzzzzzzzzzzzzzzw_, gzzzzzzzzzzzzzzzzzzzzze_);

                return gzzzzzzzzzzzzzzzzzzzzzf_;
            };
            IEnumerable<Condition> fzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Condition>(fzzzzzzzzzzzzzzzzzzzzzj_, fzzzzzzzzzzzzzzzzzzzzzk_);
            Encounter fzzzzzzzzzzzzzzzzzzzzzm_(Condition AtrialAblationDiagnosis) =>
                IschemicStrokeEncounter;
            IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Select<Condition, Encounter>(fzzzzzzzzzzzzzzzzzzzzzl_, fzzzzzzzzzzzzzzzzzzzzzm_);

            return fzzzzzzzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.SelectMany<Encounter, Encounter>(ezzzzzzzzzzzzzzzzzzzzzf_, ezzzzzzzzzzzzzzzzzzzzzj_);
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Union<Encounter>(ezzzzzzzzzzzzzzzzzzzzzh_, ezzzzzzzzzzzzzzzzzzzzzk_);
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzn_(Encounter IschemicStrokeEncounter)
        {
            CqlValueSet gzzzzzzzzzzzzzzzzzzzzzg_ = this.History_of_Atrial_Ablation(context);
            IEnumerable<Observation> gzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
            bool? gzzzzzzzzzzzzzzzzzzzzzi_(Observation AtrialAblationObservation)
            {
                Code<ObservationStatus> gzzzzzzzzzzzzzzzzzzzzzm_ = AtrialAblationObservation?.StatusElement;
                ObservationStatus? gzzzzzzzzzzzzzzzzzzzzzn_ = gzzzzzzzzzzzzzzzzzzzzzm_?.Value;
                Code<ObservationStatus> gzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Convert<Code<ObservationStatus>>(gzzzzzzzzzzzzzzzzzzzzzn_);
                string gzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Convert<string>(gzzzzzzzzzzzzzzzzzzzzzo_);
                string[] gzzzzzzzzzzzzzzzzzzzzzq_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? gzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.In<string>(gzzzzzzzzzzzzzzzzzzzzzp_, gzzzzzzzzzzzzzzzzzzzzzq_ as IEnumerable<string>);
                object gzzzzzzzzzzzzzzzzzzzzzs_()
                {
                    bool gzzzzzzzzzzzzzzzzzzzzzz_()
                    {
                        DataType hzzzzzzzzzzzzzzzzzzzzzc_ = AtrialAblationObservation?.Effective;
                        object hzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzzc_);
                        bool hzzzzzzzzzzzzzzzzzzzzze_ = hzzzzzzzzzzzzzzzzzzzzzd_ is CqlDateTime;

                        return hzzzzzzzzzzzzzzzzzzzzze_;
                    };
                    bool hzzzzzzzzzzzzzzzzzzzzza_()
                    {
                        DataType hzzzzzzzzzzzzzzzzzzzzzf_ = AtrialAblationObservation?.Effective;
                        object hzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzzf_);
                        bool hzzzzzzzzzzzzzzzzzzzzzh_ = hzzzzzzzzzzzzzzzzzzzzzg_ is CqlInterval<CqlDateTime>;

                        return hzzzzzzzzzzzzzzzzzzzzzh_;
                    };
                    bool hzzzzzzzzzzzzzzzzzzzzzb_()
                    {
                        DataType hzzzzzzzzzzzzzzzzzzzzzi_ = AtrialAblationObservation?.Effective;
                        object hzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzzi_);
                        bool hzzzzzzzzzzzzzzzzzzzzzk_ = hzzzzzzzzzzzzzzzzzzzzzj_ is CqlDateTime;

                        return hzzzzzzzzzzzzzzzzzzzzzk_;
                    };
                    if (gzzzzzzzzzzzzzzzzzzzzzz_())
                    {
                        DataType hzzzzzzzzzzzzzzzzzzzzzl_ = AtrialAblationObservation?.Effective;
                        object hzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzzl_);

                        return (hzzzzzzzzzzzzzzzzzzzzzm_ as CqlDateTime) as object;
                    }
                    else if (hzzzzzzzzzzzzzzzzzzzzza_())
                    {
                        DataType hzzzzzzzzzzzzzzzzzzzzzn_ = AtrialAblationObservation?.Effective;
                        object hzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzzn_);

                        return (hzzzzzzzzzzzzzzzzzzzzzo_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (hzzzzzzzzzzzzzzzzzzzzzb_())
                    {
                        DataType hzzzzzzzzzzzzzzzzzzzzzp_ = AtrialAblationObservation?.Effective;
                        object hzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzzp_);

                        return (hzzzzzzzzzzzzzzzzzzzzzq_ as CqlDateTime) as object;
                    }
                    else
                    {
                        return null;
                    }
                };
                CqlDateTime gzzzzzzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.earliest(context, gzzzzzzzzzzzzzzzzzzzzzs_());
                Period gzzzzzzzzzzzzzzzzzzzzzu_ = IschemicStrokeEncounter?.Period;
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzzzzzzzzzzzzzzzzu_);
                CqlDateTime gzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.End(gzzzzzzzzzzzzzzzzzzzzzv_);
                bool? gzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.SameOrBefore(gzzzzzzzzzzzzzzzzzzzzzt_, gzzzzzzzzzzzzzzzzzzzzzw_, default);
                bool? gzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.And(gzzzzzzzzzzzzzzzzzzzzzr_, gzzzzzzzzzzzzzzzzzzzzzx_);

                return gzzzzzzzzzzzzzzzzzzzzzy_;
            };
            IEnumerable<Observation> gzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Where<Observation>(gzzzzzzzzzzzzzzzzzzzzzh_, gzzzzzzzzzzzzzzzzzzzzzi_);
            Encounter gzzzzzzzzzzzzzzzzzzzzzk_(Observation AtrialAblationObservation) =>
                IschemicStrokeEncounter;
            IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Select<Observation, Encounter>(gzzzzzzzzzzzzzzzzzzzzzj_, gzzzzzzzzzzzzzzzzzzzzzk_);

            return gzzzzzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.SelectMany<Encounter, Encounter>(ezzzzzzzzzzzzzzzzzzzzzf_, ezzzzzzzzzzzzzzzzzzzzzn_);
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Union<Encounter>(ezzzzzzzzzzzzzzzzzzzzzl_, ezzzzzzzzzzzzzzzzzzzzzo_);

        return ezzzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition(
        definitionName: "Encounter with Prior or Present Diagnosis of Atrial Fibrillation or Flutter")]
    public IEnumerable<Encounter> Encounter_with_Prior_or_Present_Diagnosis_of_Atrial_Fibrillation_or_Flutter(CqlContext context)
    {
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzzr_ = TJCOverall_8_14_000.Instance.Ischemic_Stroke_Encounter(context);
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzzs_(Encounter IschemicStrokeEncounter)
        {
            CqlValueSet hzzzzzzzzzzzzzzzzzzzzzy_ = this.Atrial_Fibrillation_or_Flutter(context);
            IEnumerable<Condition> hzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            bool? izzzzzzzzzzzzzzzzzzzzza_(Condition AtrialFibrillationFlutter)
            {
                CodeableConcept izzzzzzzzzzzzzzzzzzzzze_ = AtrialFibrillationFlutter?.VerificationStatus;
                CqlConcept izzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, izzzzzzzzzzzzzzzzzzzzze_);
                bool? izzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Not((bool?)(izzzzzzzzzzzzzzzzzzzzzf_ is null));
                CqlConcept izzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, izzzzzzzzzzzzzzzzzzzzze_);
                CqlCode izzzzzzzzzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.confirmed(context);
                CqlConcept izzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.ConvertCodeToConcept(izzzzzzzzzzzzzzzzzzzzzj_);
                bool? izzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Equivalent(izzzzzzzzzzzzzzzzzzzzzi_, izzzzzzzzzzzzzzzzzzzzzk_);
                bool? izzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.And(izzzzzzzzzzzzzzzzzzzzzg_, izzzzzzzzzzzzzzzzzzzzzl_);
                DataType izzzzzzzzzzzzzzzzzzzzzn_ = AtrialFibrillationFlutter?.Onset;
                object izzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzn_);
                CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.toInterval(context, izzzzzzzzzzzzzzzzzzzzzo_);
                CqlDateTime izzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Start(izzzzzzzzzzzzzzzzzzzzzp_);
                Period izzzzzzzzzzzzzzzzzzzzzr_ = IschemicStrokeEncounter?.Period;
                CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzzzzzzzzzzzzzzzzr_);
                CqlDateTime izzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.End(izzzzzzzzzzzzzzzzzzzzzs_);
                bool? izzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.SameOrBefore(izzzzzzzzzzzzzzzzzzzzzq_, izzzzzzzzzzzzzzzzzzzzzt_, default);
                bool? izzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.And(izzzzzzzzzzzzzzzzzzzzzm_, izzzzzzzzzzzzzzzzzzzzzu_);

                return izzzzzzzzzzzzzzzzzzzzzv_;
            };
            IEnumerable<Condition> izzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Where<Condition>(hzzzzzzzzzzzzzzzzzzzzzz_, izzzzzzzzzzzzzzzzzzzzza_);
            Encounter izzzzzzzzzzzzzzzzzzzzzc_(Condition AtrialFibrillationFlutter) =>
                IschemicStrokeEncounter;
            IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Select<Condition, Encounter>(izzzzzzzzzzzzzzzzzzzzzb_, izzzzzzzzzzzzzzzzzzzzzc_);

            return izzzzzzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.SelectMany<Encounter, Encounter>(hzzzzzzzzzzzzzzzzzzzzzr_, hzzzzzzzzzzzzzzzzzzzzzs_);
        bool? hzzzzzzzzzzzzzzzzzzzzzv_(Encounter IschemicStrokeEncounter)
        {
            IEnumerable<Condition> izzzzzzzzzzzzzzzzzzzzzw_ = CQMCommon_2_2_000.Instance.encounterDiagnosis(context, IschemicStrokeEncounter);
            bool? izzzzzzzzzzzzzzzzzzzzzx_(Condition EncounterDiagnosis)
            {
                CodeableConcept jzzzzzzzzzzzzzzzzzzzzza_ = EncounterDiagnosis?.Code;
                CqlConcept jzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, jzzzzzzzzzzzzzzzzzzzzza_);
                CqlValueSet jzzzzzzzzzzzzzzzzzzzzzc_ = this.Atrial_Fibrillation_or_Flutter(context);
                bool? jzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.ConceptInValueSet(jzzzzzzzzzzzzzzzzzzzzzb_, jzzzzzzzzzzzzzzzzzzzzzc_);

                return jzzzzzzzzzzzzzzzzzzzzzd_;
            };
            IEnumerable<Condition> izzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Where<Condition>(izzzzzzzzzzzzzzzzzzzzzw_, izzzzzzzzzzzzzzzzzzzzzx_);
            bool? izzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Exists<Condition>(izzzzzzzzzzzzzzzzzzzzzy_);

            return izzzzzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Where<Encounter>(hzzzzzzzzzzzzzzzzzzzzzr_, hzzzzzzzzzzzzzzzzzzzzzv_);
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Union<Encounter>(hzzzzzzzzzzzzzzzzzzzzzt_, hzzzzzzzzzzzzzzzzzzzzzw_);

        return hzzzzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context)
    {
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzze_ = this.Encounter_with_a_History_of_Atrial_Ablation(context);
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzf_ = this.Encounter_with_Prior_or_Present_Diagnosis_of_Atrial_Fibrillation_or_Flutter(context);
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Union<Encounter>(jzzzzzzzzzzzzzzzzzzzzze_, jzzzzzzzzzzzzzzzzzzzzzf_);

        return jzzzzzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition(
        definitionName: "Encounter with Comfort Measures during Hospitalization for Patients with Documented Atrial Fibrillation or Flutter")]
    public IEnumerable<Encounter> Encounter_with_Comfort_Measures_during_Hospitalization_for_Patients_with_Documented_Atrial_Fibrillation_or_Flutter(CqlContext context)
    {
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzh_ = this.Denominator(context);
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzi_(Encounter Encounter)
        {
            IEnumerable<object> jzzzzzzzzzzzzzzzzzzzzzk_ = TJCOverall_8_14_000.Instance.Intervention_Comfort_Measures(context);
            bool? jzzzzzzzzzzzzzzzzzzzzzl_(object ComfortMeasure)
            {
                object jzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                object jzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzzp_);
                CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.toInterval(context, jzzzzzzzzzzzzzzzzzzzzzq_);
                CqlDateTime jzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Start(jzzzzzzzzzzzzzzzzzzzzzr_);
                object jzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "authoredOn");
                CqlDateTime jzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.LateBoundProperty<CqlDateTime>(jzzzzzzzzzzzzzzzzzzzzzt_, "value");
                CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzv_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservation(context, Encounter);
                bool? jzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.In<CqlDateTime>(jzzzzzzzzzzzzzzzzzzzzzs_ ?? jzzzzzzzzzzzzzzzzzzzzzu_, jzzzzzzzzzzzzzzzzzzzzzv_, default);

                return jzzzzzzzzzzzzzzzzzzzzzw_;
            };
            IEnumerable<object> jzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Where<object>(jzzzzzzzzzzzzzzzzzzzzzk_, jzzzzzzzzzzzzzzzzzzzzzl_);
            Encounter jzzzzzzzzzzzzzzzzzzzzzn_(object ComfortMeasure) =>
                Encounter;
            IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Select<object, Encounter>(jzzzzzzzzzzzzzzzzzzzzzm_, jzzzzzzzzzzzzzzzzzzzzzn_);

            return jzzzzzzzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.SelectMany<Encounter, Encounter>(jzzzzzzzzzzzzzzzzzzzzzh_, jzzzzzzzzzzzzzzzzzzzzzi_);

        return jzzzzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator Exclusions")]
    public IEnumerable<Encounter> Denominator_Exclusions(CqlContext context)
    {
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzx_ = this.Denominator(context);
        bool? jzzzzzzzzzzzzzzzzzzzzzy_(Encounter Encounter)
        {
            Code<Encounter.EncounterStatus> kzzzzzzzzzzzzzzzzzzzzzc_ = Encounter?.StatusElement;
            Encounter.EncounterStatus? kzzzzzzzzzzzzzzzzzzzzzd_ = kzzzzzzzzzzzzzzzzzzzzzc_?.Value;
            Code<Encounter.EncounterStatus> kzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(kzzzzzzzzzzzzzzzzzzzzzd_);
            bool? kzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Equal(kzzzzzzzzzzzzzzzzzzzzze_, "finished");
            Encounter.HospitalizationComponent kzzzzzzzzzzzzzzzzzzzzzg_ = Encounter?.Hospitalization;
            CodeableConcept kzzzzzzzzzzzzzzzzzzzzzh_ = kzzzzzzzzzzzzzzzzzzzzzg_?.DischargeDisposition;
            CqlConcept kzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, kzzzzzzzzzzzzzzzzzzzzzh_);
            CqlValueSet kzzzzzzzzzzzzzzzzzzzzzj_ = this.Discharge_To_Acute_Care_Facility(context);
            bool? kzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.ConceptInValueSet(kzzzzzzzzzzzzzzzzzzzzzi_, kzzzzzzzzzzzzzzzzzzzzzj_);
            CodeableConcept kzzzzzzzzzzzzzzzzzzzzzm_ = kzzzzzzzzzzzzzzzzzzzzzg_?.DischargeDisposition;
            CqlConcept kzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, kzzzzzzzzzzzzzzzzzzzzzm_);
            CqlValueSet kzzzzzzzzzzzzzzzzzzzzzo_ = this.Left_Against_Medical_Advice(context);
            bool? kzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.ConceptInValueSet(kzzzzzzzzzzzzzzzzzzzzzn_, kzzzzzzzzzzzzzzzzzzzzzo_);
            bool? kzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Or(kzzzzzzzzzzzzzzzzzzzzzk_, kzzzzzzzzzzzzzzzzzzzzzp_);
            CodeableConcept kzzzzzzzzzzzzzzzzzzzzzs_ = kzzzzzzzzzzzzzzzzzzzzzg_?.DischargeDisposition;
            CqlConcept kzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, kzzzzzzzzzzzzzzzzzzzzzs_);
            CqlValueSet kzzzzzzzzzzzzzzzzzzzzzu_ = this.Patient_Expired(context);
            bool? kzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.ConceptInValueSet(kzzzzzzzzzzzzzzzzzzzzzt_, kzzzzzzzzzzzzzzzzzzzzzu_);
            bool? kzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Or(kzzzzzzzzzzzzzzzzzzzzzq_, kzzzzzzzzzzzzzzzzzzzzzv_);
            CodeableConcept kzzzzzzzzzzzzzzzzzzzzzy_ = kzzzzzzzzzzzzzzzzzzzzzg_?.DischargeDisposition;
            CqlConcept kzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, kzzzzzzzzzzzzzzzzzzzzzy_);
            CqlValueSet lzzzzzzzzzzzzzzzzzzzzza_ = this.Discharged_to_Home_for_Hospice_Care(context);
            bool? lzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.ConceptInValueSet(kzzzzzzzzzzzzzzzzzzzzzz_, lzzzzzzzzzzzzzzzzzzzzza_);
            bool? lzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Or(kzzzzzzzzzzzzzzzzzzzzzw_, lzzzzzzzzzzzzzzzzzzzzzb_);
            CodeableConcept lzzzzzzzzzzzzzzzzzzzzze_ = kzzzzzzzzzzzzzzzzzzzzzg_?.DischargeDisposition;
            CqlConcept lzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, lzzzzzzzzzzzzzzzzzzzzze_);
            CqlValueSet lzzzzzzzzzzzzzzzzzzzzzg_ = this.Discharged_to_Health_Care_Facility_for_Hospice_Care(context);
            bool? lzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.ConceptInValueSet(lzzzzzzzzzzzzzzzzzzzzzf_, lzzzzzzzzzzzzzzzzzzzzzg_);
            bool? lzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Or(lzzzzzzzzzzzzzzzzzzzzzc_, lzzzzzzzzzzzzzzzzzzzzzh_);
            bool? lzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.And(kzzzzzzzzzzzzzzzzzzzzzf_, lzzzzzzzzzzzzzzzzzzzzzi_);

            return lzzzzzzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Where<Encounter>(jzzzzzzzzzzzzzzzzzzzzzx_, jzzzzzzzzzzzzzzzzzzzzzy_);
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzza_ = this.Encounter_with_Comfort_Measures_during_Hospitalization_for_Patients_with_Documented_Atrial_Fibrillation_or_Flutter(context);
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Union<Encounter>(jzzzzzzzzzzzzzzzzzzzzzz_, kzzzzzzzzzzzzzzzzzzzzza_);

        return kzzzzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition(
        definitionName: "Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context)
    {
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzzk_ = this.Denominator(context);
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzzl_(Encounter Encounter)
        {
            CqlValueSet lzzzzzzzzzzzzzzzzzzzzzn_ = this.Anticoagulant_Therapy(context);
            IEnumerable<MedicationRequest> lzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, lzzzzzzzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> lzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, lzzzzzzzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> lzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Union<MedicationRequest>(lzzzzzzzzzzzzzzzzzzzzzo_, lzzzzzzzzzzzzzzzzzzzzzq_);
            bool? lzzzzzzzzzzzzzzzzzzzzzs_(MedicationRequest DischargeAnticoagulant)
            {
                bool? lzzzzzzzzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.isCommunity(context, DischargeAnticoagulant);
                bool? lzzzzzzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.isDischarge(context, DischargeAnticoagulant);
                bool? lzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Or(lzzzzzzzzzzzzzzzzzzzzzw_, lzzzzzzzzzzzzzzzzzzzzzx_);
                Code<MedicationRequest.MedicationrequestStatus> lzzzzzzzzzzzzzzzzzzzzzz_ = DischargeAnticoagulant?.StatusElement;
                MedicationRequest.MedicationrequestStatus? mzzzzzzzzzzzzzzzzzzzzza_ = lzzzzzzzzzzzzzzzzzzzzzz_?.Value;
                string mzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Convert<string>(mzzzzzzzzzzzzzzzzzzzzza_);
                string[] mzzzzzzzzzzzzzzzzzzzzzc_ = [
                    "active",
                    "completed",
                ];
                bool? mzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.In<string>(mzzzzzzzzzzzzzzzzzzzzzb_, mzzzzzzzzzzzzzzzzzzzzzc_ as IEnumerable<string>);
                bool? mzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.And(lzzzzzzzzzzzzzzzzzzzzzy_, mzzzzzzzzzzzzzzzzzzzzzd_);
                Code<MedicationRequest.MedicationRequestIntent> mzzzzzzzzzzzzzzzzzzzzzf_ = DischargeAnticoagulant?.IntentElement;
                MedicationRequest.MedicationRequestIntent? mzzzzzzzzzzzzzzzzzzzzzg_ = mzzzzzzzzzzzzzzzzzzzzzf_?.Value;
                string mzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Convert<string>(mzzzzzzzzzzzzzzzzzzzzzg_);
                string[] mzzzzzzzzzzzzzzzzzzzzzi_ = [
                    "order",
                    "original-order",
                    "reflex-order",
                    "filler-order",
                    "instance-order",
                ];
                bool? mzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.In<string>(mzzzzzzzzzzzzzzzzzzzzzh_, mzzzzzzzzzzzzzzzzzzzzzi_ as IEnumerable<string>);
                bool? mzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.And(mzzzzzzzzzzzzzzzzzzzzze_, mzzzzzzzzzzzzzzzzzzzzzj_);
                FhirDateTime mzzzzzzzzzzzzzzzzzzzzzl_ = DischargeAnticoagulant?.AuthoredOnElement;
                CqlDateTime mzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Convert<CqlDateTime>(mzzzzzzzzzzzzzzzzzzzzzl_);
                Period mzzzzzzzzzzzzzzzzzzzzzn_ = Encounter?.Period;
                CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzzzzzzzzzzzzzzzzn_);
                bool? mzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.In<CqlDateTime>(mzzzzzzzzzzzzzzzzzzzzzm_, mzzzzzzzzzzzzzzzzzzzzzo_, default);
                bool? mzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.And(mzzzzzzzzzzzzzzzzzzzzzk_, mzzzzzzzzzzzzzzzzzzzzzp_);

                return mzzzzzzzzzzzzzzzzzzzzzq_;
            };
            IEnumerable<MedicationRequest> lzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Where<MedicationRequest>(lzzzzzzzzzzzzzzzzzzzzzr_, lzzzzzzzzzzzzzzzzzzzzzs_);
            Encounter lzzzzzzzzzzzzzzzzzzzzzu_(MedicationRequest DischargeAnticoagulant) =>
                Encounter;
            IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Select<MedicationRequest, Encounter>(lzzzzzzzzzzzzzzzzzzzzzt_, lzzzzzzzzzzzzzzzzzzzzzu_);

            return lzzzzzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.SelectMany<Encounter, Encounter>(lzzzzzzzzzzzzzzzzzzzzzk_, lzzzzzzzzzzzzzzzzzzzzzl_);

        return lzzzzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition(
        definitionName: "Documented Reason for Not Giving Anticoagulant at Discharge")]
    public IEnumerable<MedicationRequest> Documented_Reason_for_Not_Giving_Anticoagulant_at_Discharge(CqlContext context)
    {
        CqlValueSet mzzzzzzzzzzzzzzzzzzzzzr_ = this.Anticoagulant_Therapy(context);
        IEnumerable<MedicationRequest> mzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, mzzzzzzzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-mednotrequested"));
        bool? mzzzzzzzzzzzzzzzzzzzzzt_(MedicationRequest NoAnticoagulant)
        {
            List<CodeableConcept> mzzzzzzzzzzzzzzzzzzzzzv_ = NoAnticoagulant?.ReasonCode;
            CqlConcept mzzzzzzzzzzzzzzzzzzzzzw_(CodeableConcept @this)
            {
                CqlConcept nzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return nzzzzzzzzzzzzzzzzzzzzzq_;
            };
            IEnumerable<CqlConcept> mzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)mzzzzzzzzzzzzzzzzzzzzzv_, mzzzzzzzzzzzzzzzzzzzzzw_);
            CqlValueSet mzzzzzzzzzzzzzzzzzzzzzy_ = this.Medical_Reason_For_Not_Providing_Treatment(context);
            bool? mzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.ConceptsInValueSet(mzzzzzzzzzzzzzzzzzzzzzx_, mzzzzzzzzzzzzzzzzzzzzzy_);
            CqlConcept nzzzzzzzzzzzzzzzzzzzzzb_(CodeableConcept @this)
            {
                CqlConcept nzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return nzzzzzzzzzzzzzzzzzzzzzr_;
            };
            IEnumerable<CqlConcept> nzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)mzzzzzzzzzzzzzzzzzzzzzv_, nzzzzzzzzzzzzzzzzzzzzzb_);
            CqlValueSet nzzzzzzzzzzzzzzzzzzzzzd_ = this.Patient_Refusal(context);
            bool? nzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.ConceptsInValueSet(nzzzzzzzzzzzzzzzzzzzzzc_, nzzzzzzzzzzzzzzzzzzzzzd_);
            bool? nzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Or(mzzzzzzzzzzzzzzzzzzzzzz_, nzzzzzzzzzzzzzzzzzzzzze_);
            bool? nzzzzzzzzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.isCommunity(context, NoAnticoagulant);
            bool? nzzzzzzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.isDischarge(context, NoAnticoagulant);
            bool? nzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Or(nzzzzzzzzzzzzzzzzzzzzzg_, nzzzzzzzzzzzzzzzzzzzzzh_);
            bool? nzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.And(nzzzzzzzzzzzzzzzzzzzzzf_, nzzzzzzzzzzzzzzzzzzzzzi_);
            Code<MedicationRequest.MedicationRequestIntent> nzzzzzzzzzzzzzzzzzzzzzk_ = NoAnticoagulant?.IntentElement;
            MedicationRequest.MedicationRequestIntent? nzzzzzzzzzzzzzzzzzzzzzl_ = nzzzzzzzzzzzzzzzzzzzzzk_?.Value;
            string nzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Convert<string>(nzzzzzzzzzzzzzzzzzzzzzl_);
            string[] nzzzzzzzzzzzzzzzzzzzzzn_ = [
                "order",
                "original-order",
                "reflex-order",
                "filler-order",
                "instance-order",
            ];
            bool? nzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.In<string>(nzzzzzzzzzzzzzzzzzzzzzm_, nzzzzzzzzzzzzzzzzzzzzzn_ as IEnumerable<string>);
            bool? nzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.And(nzzzzzzzzzzzzzzzzzzzzzj_, nzzzzzzzzzzzzzzzzzzzzzo_);

            return nzzzzzzzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<MedicationRequest> mzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Where<MedicationRequest>(mzzzzzzzzzzzzzzzzzzzzzs_, mzzzzzzzzzzzzzzzzzzzzzt_);

        return mzzzzzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator Exceptions")]
    public IEnumerable<Encounter> Denominator_Exceptions(CqlContext context)
    {
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzs_ = this.Denominator(context);
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzt_(Encounter Encounter)
        {
            IEnumerable<MedicationRequest> nzzzzzzzzzzzzzzzzzzzzzv_ = this.Documented_Reason_for_Not_Giving_Anticoagulant_at_Discharge(context);
            bool? nzzzzzzzzzzzzzzzzzzzzzw_(MedicationRequest NoDischargeAnticoagulant)
            {
                FhirDateTime ozzzzzzzzzzzzzzzzzzzzza_ = NoDischargeAnticoagulant?.AuthoredOnElement;
                CqlDateTime ozzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Convert<CqlDateTime>(ozzzzzzzzzzzzzzzzzzzzza_);
                Period ozzzzzzzzzzzzzzzzzzzzzc_ = Encounter?.Period;
                CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzzzzzzzzzzzzzzzzzc_);
                bool? ozzzzzzzzzzzzzzzzzzzzze_ = context.Operators.In<CqlDateTime>(ozzzzzzzzzzzzzzzzzzzzzb_, ozzzzzzzzzzzzzzzzzzzzzd_, default);

                return ozzzzzzzzzzzzzzzzzzzzze_;
            };
            IEnumerable<MedicationRequest> nzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Where<MedicationRequest>(nzzzzzzzzzzzzzzzzzzzzzv_, nzzzzzzzzzzzzzzzzzzzzzw_);
            Encounter nzzzzzzzzzzzzzzzzzzzzzy_(MedicationRequest NoDischargeAnticoagulant) =>
                Encounter;
            IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Select<MedicationRequest, Encounter>(nzzzzzzzzzzzzzzzzzzzzzx_, nzzzzzzzzzzzzzzzzzzzzzy_);

            return nzzzzzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.SelectMany<Encounter, Encounter>(nzzzzzzzzzzzzzzzzzzzzzs_, nzzzzzzzzzzzzzzzzzzzzzt_);

        return nzzzzzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? ozzzzzzzzzzzzzzzzzzzzzf_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return ozzzzzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> ozzzzzzzzzzzzzzzzzzzzzg_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return ozzzzzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? ozzzzzzzzzzzzzzzzzzzzzh_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return ozzzzzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode ozzzzzzzzzzzzzzzzzzzzzi_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return ozzzzzzzzzzzzzzzzzzzzzi_;
    }


    #endregion Expressions

}
