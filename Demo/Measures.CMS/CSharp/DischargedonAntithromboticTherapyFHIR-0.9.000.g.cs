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
[CqlLibrary("DischargedonAntithromboticTherapyFHIR", "0.9.000")]
public partial class DischargedonAntithromboticTherapyFHIR_0_9_000 : ILibrary, ISingleton<DischargedonAntithromboticTherapyFHIR_0_9_000>
{
    private DischargedonAntithromboticTherapyFHIR_0_9_000() {}

    public static DischargedonAntithromboticTherapyFHIR_0_9_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "DischargedonAntithromboticTherapyFHIR";
    public string Version => "0.9.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, CQMCommon_2_2_000.Instance, QICoreCommon_2_1_000.Instance, SupplementalDataElements_3_5_000.Instance, TJCOverall_8_14_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    #region ValueSet: Antithrombotic Therapy for Ischemic Stroke
    [CqlValueSetDefinition(
        definitionName: "Antithrombotic Therapy for Ischemic Stroke",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.62",
        valueSetVersion: null)]
    public CqlValueSet Antithrombotic_Therapy_for_Ischemic_Stroke(CqlContext context) => _Antithrombotic_Therapy_for_Ischemic_Stroke;

    private static readonly CqlValueSet _Antithrombotic_Therapy_for_Ischemic_Stroke = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.62", null);
    #endregion

    #region ValueSet: Medical Reason For Not Providing Treatment
    [CqlValueSetDefinition(
        definitionName: "Medical Reason For Not Providing Treatment",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.473",
        valueSetVersion: null)]
    public CqlValueSet Medical_Reason_For_Not_Providing_Treatment(CqlContext context) => _Medical_Reason_For_Not_Providing_Treatment;

    private static readonly CqlValueSet _Medical_Reason_For_Not_Providing_Treatment = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.473", null);
    #endregion

    #region ValueSet: Patient Refusal
    [CqlValueSetDefinition(
        definitionName: "Patient Refusal",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.93",
        valueSetVersion: null)]
    public CqlValueSet Patient_Refusal(CqlContext context) => _Patient_Refusal;

    private static readonly CqlValueSet _Patient_Refusal = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.93", null);
    #endregion

    #region ValueSet: Pharmacological Contraindications For Antithrombotic Therapy
    [CqlValueSetDefinition(
        definitionName: "Pharmacological Contraindications For Antithrombotic Therapy",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.52",
        valueSetVersion: null)]
    public CqlValueSet Pharmacological_Contraindications_For_Antithrombotic_Therapy(CqlContext context) => _Pharmacological_Contraindications_For_Antithrombotic_Therapy;

    private static readonly CqlValueSet _Pharmacological_Contraindications_For_Antithrombotic_Therapy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.52", null);
    #endregion

    #endregion ValueSets

    #region Parameters

    [CqlParameterDefinition(
        definitionName: "Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Interval(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, true, true);
        object vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.ResolveParameter("DischargedonAntithromboticTherapyFHIR-0.9.000", "Measurement Period", vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);

        return (CqlInterval<CqlDateTime>)vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition(
        definitionName: "Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.SingletonFrom<Patient>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);

        return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition(
        definitionName: "Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = TJCOverall_8_14_000.Instance.Ischemic_Stroke_Encounter(context);

        return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context)
    {
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Initial_Population(context);

        return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition(
        definitionName: "Encounter with Comfort Measures during Hospitalization for Patients with Documented Ischemic Stroke")]
    public IEnumerable<Encounter> Encounter_with_Comfort_Measures_during_Hospitalization_for_Patients_with_Documented_Ischemic_Stroke(CqlContext context)
    {
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Denominator(context);
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_(Encounter Encounter)
        {
            IEnumerable<object> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = TJCOverall_8_14_000.Instance.Intervention_Comfort_Measures(context);
            bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_(object ComfortMeasure)
            {
                object wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                object wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.toInterval(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Start(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                object wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "authoredOn");
                CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.LateBoundProperty<CqlDateTime>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, "value");
                CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservation(context, Encounter);
                bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.In<CqlDateTime>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ ?? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, default);

                return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
            };
            IEnumerable<object> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Where<object>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            Encounter wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_(object ComfortMeasure) =>
                Encounter;
            IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Select<object, Encounter>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);

            return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
        };
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.SelectMany<Encounter, Encounter>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);

        return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator Exclusions")]
    public IEnumerable<Encounter> Denominator_Exclusions(CqlContext context)
    {
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = TJCOverall_8_14_000.Instance.Ischemic_Stroke_Encounters_with_Discharge_Disposition(context);
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Encounter_with_Comfort_Measures_during_Hospitalization_for_Patients_with_Documented_Ischemic_Stroke(context);
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Union<Encounter>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);

        return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition(
        definitionName: "Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context)
    {
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = TJCOverall_8_14_000.Instance.Ischemic_Stroke_Encounter(context);
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_(Encounter IschemicStrokeEncounter)
        {
            CqlValueSet wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Antithrombotic_Therapy_for_Ischemic_Stroke(context);
            IEnumerable<MedicationRequest> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Union<MedicationRequest>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_(MedicationRequest DischargeAntithrombotic)
            {
                FhirDateTime wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = DischargeAntithrombotic?.AuthoredOnElement;
                CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Convert<CqlDateTime>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                Period xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = IschemicStrokeEncounter?.Period;
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.In<CqlDateTime>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, default);

                return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
            };
            IEnumerable<MedicationRequest> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Where<MedicationRequest>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            Encounter wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_(MedicationRequest DischargeAntithrombotic) =>
                IschemicStrokeEncounter;
            IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Select<MedicationRequest, Encounter>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);

            return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.SelectMany<Encounter, Encounter>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);

        return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition(
        definitionName: "Antithrombotic Therapy at Discharge")]
    public IEnumerable<MedicationRequest> Antithrombotic_Therapy_at_Discharge(CqlContext context)
    {
        CqlValueSet xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Antithrombotic_Therapy_for_Ischemic_Stroke(context);
        IEnumerable<MedicationRequest> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Union<MedicationRequest>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
        bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_(MedicationRequest Antithrombotic)
        {
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.isCommunity(context, Antithrombotic);
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.isDischarge(context, Antithrombotic);
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Or(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            Code<MedicationRequest.MedicationrequestStatus> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = Antithrombotic?.StatusElement;
            MedicationRequest.MedicationrequestStatus? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_?.Value;
            string xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Convert<string>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            string[] xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = [
                "active",
                "completed",
            ];
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.In<string>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ as IEnumerable<string>);
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.And(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            Code<MedicationRequest.MedicationRequestIntent> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = Antithrombotic?.IntentElement;
            MedicationRequest.MedicationRequestIntent? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_?.Value;
            string xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Convert<string>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            string[] xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = [
                "order",
                "original-order",
                "reflex-order",
                "filler-order",
                "instance-order",
            ];
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.In<string>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ as IEnumerable<string>);
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.And(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

            return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<MedicationRequest> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Where<MedicationRequest>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);

        return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition(
        definitionName: "Reason for Not Giving Antithrombotic at Discharge")]
    public IEnumerable<MedicationRequest> Reason_for_Not_Giving_Antithrombotic_at_Discharge(CqlContext context)
    {
        CqlValueSet yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Antithrombotic_Therapy_for_Ischemic_Stroke(context);
        IEnumerable<MedicationRequest> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-mednotrequested"));
        IEnumerable<MedicationRequest> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-mednotrequested"));
        IEnumerable<MedicationRequest> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Union<MedicationRequest>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
        bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_(MedicationRequest NoAntithromboticDischarge)
        {
            List<CodeableConcept> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = NoAntithromboticDischarge?.ReasonCode;
            CqlConcept yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_(CodeableConcept @this)
            {
                CqlConcept yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
            };
            IEnumerable<CqlConcept> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlValueSet yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Medical_Reason_For_Not_Providing_Treatment(context);
            bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.ConceptsInValueSet(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            CqlConcept yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_(CodeableConcept @this)
            {
                CqlConcept yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
            };
            IEnumerable<CqlConcept> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlValueSet yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Patient_Refusal(context);
            bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.ConceptsInValueSet(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Or(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.isCommunity(context, NoAntithromboticDischarge);
            bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.isDischarge(context, NoAntithromboticDischarge);
            bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Or(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.And(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);

            return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<MedicationRequest> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Where<MedicationRequest>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

        return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition(
        definitionName: "Encounter with Documented Reason for No Antithrombotic At Discharge")]
    public IEnumerable<Encounter> Encounter_with_Documented_Reason_for_No_Antithrombotic_At_Discharge(CqlContext context)
    {
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = TJCOverall_8_14_000.Instance.Ischemic_Stroke_Encounter(context);
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_(Encounter IschemicStrokeEncounter)
        {
            IEnumerable<MedicationRequest> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Reason_for_Not_Giving_Antithrombotic_at_Discharge(context);
            bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_(MedicationRequest NoDischargeAntithrombotic)
            {
                FhirDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = NoDischargeAntithrombotic?.AuthoredOnElement;
                CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Convert<CqlDateTime>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                Period zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = IschemicStrokeEncounter?.Period;
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.In<CqlDateTime>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, default);

                return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
            };
            IEnumerable<MedicationRequest> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Where<MedicationRequest>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            Encounter zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_(MedicationRequest NoDischargeAntithrombotic) =>
                IschemicStrokeEncounter;
            IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Select<MedicationRequest, Encounter>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);

            return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.SelectMany<Encounter, Encounter>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

        return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition(
        definitionName: "Pharmacological Contraindications for Antithrombotic Therapy at Discharge")]
    public IEnumerable<MedicationRequest> Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge(CqlContext context)
    {
        CqlValueSet zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Pharmacological_Contraindications_For_Antithrombotic_Therapy(context);
        IEnumerable<MedicationRequest> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Union<MedicationRequest>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_(MedicationRequest Pharmacological)
        {
            bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.isCommunity(context, Pharmacological);
            bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.isDischarge(context, Pharmacological);
            bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Or(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            Code<MedicationRequest.MedicationrequestStatus> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = Pharmacological?.StatusElement;
            MedicationRequest.MedicationrequestStatus? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_?.Value;
            string zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Convert<string>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            string[] zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = [
                "active",
                "completed",
            ];
            bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.In<string>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ as IEnumerable<string>);
            bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.And(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            Code<MedicationRequest.MedicationRequestIntent> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = Pharmacological?.IntentElement;
            MedicationRequest.MedicationRequestIntent? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_?.Value;
            string azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Convert<string>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            string[] azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = [
                "order",
                "original-order",
                "reflex-order",
                "filler-order",
                "instance-order",
            ];
            bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.In<string>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ as IEnumerable<string>);
            bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.And(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

            return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<MedicationRequest> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Where<MedicationRequest>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);

        return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition(
        definitionName: "Encounter with Pharmacological Contraindications for Antithrombotic Therapy at Discharge")]
    public IEnumerable<Encounter> Encounter_with_Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge(CqlContext context)
    {
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = TJCOverall_8_14_000.Instance.Ischemic_Stroke_Encounter(context);
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_(Encounter IschemicStrokeEncounter)
        {
            IEnumerable<MedicationRequest> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge(context);
            bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_(MedicationRequest DischargePharmacological)
            {
                FhirDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = DischargePharmacological?.AuthoredOnElement;
                CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Convert<CqlDateTime>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                Period azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = IschemicStrokeEncounter?.Period;
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.In<CqlDateTime>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, default);

                return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
            };
            IEnumerable<MedicationRequest> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Where<MedicationRequest>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            Encounter azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_(MedicationRequest DischargePharmacological) =>
                IschemicStrokeEncounter;
            IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Select<MedicationRequest, Encounter>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);

            return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.SelectMany<Encounter, Encounter>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);

        return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator Exceptions")]
    public IEnumerable<Encounter> Denominator_Exceptions(CqlContext context)
    {
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Encounter_with_Documented_Reason_for_No_Antithrombotic_At_Discharge(context);
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Encounter_with_Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge(context);
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Union<Encounter>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);

        return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
    }


    #endregion Expressions

}
