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

    [CqlValueSetDefinition("Antithrombotic Therapy for Ischemic Stroke", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.62", valueSetVersion: null)]
    public CqlValueSet Antithrombotic_Therapy_for_Ischemic_Stroke(CqlContext _) => _Antithrombotic_Therapy_for_Ischemic_Stroke;
    private static readonly CqlValueSet _Antithrombotic_Therapy_for_Ischemic_Stroke = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.62", null);

    [CqlValueSetDefinition("Medical Reason For Not Providing Treatment", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.473", valueSetVersion: null)]
    public CqlValueSet Medical_Reason_For_Not_Providing_Treatment(CqlContext _) => _Medical_Reason_For_Not_Providing_Treatment;
    private static readonly CqlValueSet _Medical_Reason_For_Not_Providing_Treatment = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.473", null);

    [CqlValueSetDefinition("Patient Refusal", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.93", valueSetVersion: null)]
    public CqlValueSet Patient_Refusal(CqlContext _) => _Patient_Refusal;
    private static readonly CqlValueSet _Patient_Refusal = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.93", null);

    [CqlValueSetDefinition("Pharmacological Contraindications For Antithrombotic Therapy", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.52", valueSetVersion: null)]
    public CqlValueSet Pharmacological_Contraindications_For_Antithrombotic_Therapy(CqlContext _) => _Pharmacological_Contraindications_For_Antithrombotic_Therapy;
    private static readonly CqlValueSet _Pharmacological_Contraindications_For_Antithrombotic_Therapy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.52", null);

    #endregion ValueSets

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime qzzzzzzzzzzzzp_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime qzzzzzzzzzzzzq_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> qzzzzzzzzzzzzr_ = context.Operators.Interval(qzzzzzzzzzzzzp_, qzzzzzzzzzzzzq_, true, true);
        object qzzzzzzzzzzzzs_ = context.ResolveParameter("DischargedonAntithromboticTherapyFHIR-0.9.000", "Measurement Period", qzzzzzzzzzzzzr_);

        return (CqlInterval<CqlDateTime>)qzzzzzzzzzzzzs_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> qzzzzzzzzzzzzt_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient qzzzzzzzzzzzzu_ = context.Operators.SingletonFrom<Patient>(qzzzzzzzzzzzzt_);

        return qzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> qzzzzzzzzzzzzv_ = TJCOverall_8_14_000.Instance.Ischemic_Stroke_Encounter(context);

        return qzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context)
    {
        IEnumerable<Encounter> qzzzzzzzzzzzzw_ = this.Initial_Population(context);

        return qzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Encounter with Comfort Measures during Hospitalization for Patients with Documented Ischemic Stroke")]
    public IEnumerable<Encounter> Encounter_with_Comfort_Measures_during_Hospitalization_for_Patients_with_Documented_Ischemic_Stroke(CqlContext context)
    {
        IEnumerable<Encounter> qzzzzzzzzzzzzx_ = this.Denominator(context);
        IEnumerable<Encounter> qzzzzzzzzzzzzy_(Encounter Encounter)
        {
            IEnumerable<object> rzzzzzzzzzzzza_ = TJCOverall_8_14_000.Instance.Intervention_Comfort_Measures(context);
            bool? rzzzzzzzzzzzzb_(object ComfortMeasure)
            {
                object rzzzzzzzzzzzzf_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                object rzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzf_);
                CqlInterval<CqlDateTime> rzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.toInterval(context, rzzzzzzzzzzzzg_);
                CqlDateTime rzzzzzzzzzzzzi_ = context.Operators.Start(rzzzzzzzzzzzzh_);
                object rzzzzzzzzzzzzj_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "authoredOn");
                CqlDateTime rzzzzzzzzzzzzk_ = context.Operators.LateBoundProperty<CqlDateTime>(rzzzzzzzzzzzzj_, "value");
                CqlInterval<CqlDateTime> rzzzzzzzzzzzzl_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservation(context, Encounter);
                bool? rzzzzzzzzzzzzm_ = context.Operators.In<CqlDateTime>(rzzzzzzzzzzzzi_ ?? rzzzzzzzzzzzzk_, rzzzzzzzzzzzzl_, default);

                return rzzzzzzzzzzzzm_;
            };
            IEnumerable<object> rzzzzzzzzzzzzc_ = context.Operators.Where<object>(rzzzzzzzzzzzza_, rzzzzzzzzzzzzb_);
            Encounter rzzzzzzzzzzzzd_(object ComfortMeasure) =>
                Encounter;
            IEnumerable<Encounter> rzzzzzzzzzzzze_ = context.Operators.Select<object, Encounter>(rzzzzzzzzzzzzc_, rzzzzzzzzzzzzd_);

            return rzzzzzzzzzzzze_;
        };
        IEnumerable<Encounter> qzzzzzzzzzzzzz_ = context.Operators.SelectMany<Encounter, Encounter>(qzzzzzzzzzzzzx_, qzzzzzzzzzzzzy_);

        return qzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public IEnumerable<Encounter> Denominator_Exclusions(CqlContext context)
    {
        IEnumerable<Encounter> rzzzzzzzzzzzzn_ = TJCOverall_8_14_000.Instance.Ischemic_Stroke_Encounters_with_Discharge_Disposition(context);
        IEnumerable<Encounter> rzzzzzzzzzzzzo_ = this.Encounter_with_Comfort_Measures_during_Hospitalization_for_Patients_with_Documented_Ischemic_Stroke(context);
        IEnumerable<Encounter> rzzzzzzzzzzzzp_ = context.Operators.Union<Encounter>(rzzzzzzzzzzzzn_, rzzzzzzzzzzzzo_);

        return rzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context)
    {
        IEnumerable<Encounter> rzzzzzzzzzzzzq_ = TJCOverall_8_14_000.Instance.Ischemic_Stroke_Encounter(context);
        IEnumerable<Encounter> rzzzzzzzzzzzzr_(Encounter IschemicStrokeEncounter)
        {
            CqlValueSet rzzzzzzzzzzzzt_ = this.Antithrombotic_Therapy_for_Ischemic_Stroke(context);
            IEnumerable<MedicationRequest> rzzzzzzzzzzzzu_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, rzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> rzzzzzzzzzzzzw_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, rzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> rzzzzzzzzzzzzx_ = context.Operators.Union<MedicationRequest>(rzzzzzzzzzzzzu_, rzzzzzzzzzzzzw_);
            bool? rzzzzzzzzzzzzy_(MedicationRequest DischargeAntithrombotic)
            {
                FhirDateTime szzzzzzzzzzzzc_ = DischargeAntithrombotic?.AuthoredOnElement;
                CqlDateTime szzzzzzzzzzzzd_ = context.Operators.Convert<CqlDateTime>(szzzzzzzzzzzzc_);
                Period szzzzzzzzzzzze_ = IschemicStrokeEncounter?.Period;
                CqlInterval<CqlDateTime> szzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzzzzzzzzze_);
                bool? szzzzzzzzzzzzg_ = context.Operators.In<CqlDateTime>(szzzzzzzzzzzzd_, szzzzzzzzzzzzf_, default);

                return szzzzzzzzzzzzg_;
            };
            IEnumerable<MedicationRequest> rzzzzzzzzzzzzz_ = context.Operators.Where<MedicationRequest>(rzzzzzzzzzzzzx_, rzzzzzzzzzzzzy_);
            Encounter szzzzzzzzzzzza_(MedicationRequest DischargeAntithrombotic) =>
                IschemicStrokeEncounter;
            IEnumerable<Encounter> szzzzzzzzzzzzb_ = context.Operators.Select<MedicationRequest, Encounter>(rzzzzzzzzzzzzz_, szzzzzzzzzzzza_);

            return szzzzzzzzzzzzb_;
        };
        IEnumerable<Encounter> rzzzzzzzzzzzzs_ = context.Operators.SelectMany<Encounter, Encounter>(rzzzzzzzzzzzzq_, rzzzzzzzzzzzzr_);

        return rzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Antithrombotic Therapy at Discharge")]
    public IEnumerable<MedicationRequest> Antithrombotic_Therapy_at_Discharge(CqlContext context)
    {
        CqlValueSet szzzzzzzzzzzzh_ = this.Antithrombotic_Therapy_for_Ischemic_Stroke(context);
        IEnumerable<MedicationRequest> szzzzzzzzzzzzi_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, szzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> szzzzzzzzzzzzk_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, szzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> szzzzzzzzzzzzl_ = context.Operators.Union<MedicationRequest>(szzzzzzzzzzzzi_, szzzzzzzzzzzzk_);
        bool? szzzzzzzzzzzzm_(MedicationRequest Antithrombotic)
        {
            bool? szzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.isCommunity(context, Antithrombotic);
            bool? szzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.isDischarge(context, Antithrombotic);
            bool? szzzzzzzzzzzzq_ = context.Operators.Or(szzzzzzzzzzzzo_, szzzzzzzzzzzzp_);
            Code<MedicationRequest.MedicationrequestStatus> szzzzzzzzzzzzr_ = Antithrombotic?.StatusElement;
            MedicationRequest.MedicationrequestStatus? szzzzzzzzzzzzs_ = szzzzzzzzzzzzr_?.Value;
            string szzzzzzzzzzzzt_ = context.Operators.Convert<string>(szzzzzzzzzzzzs_);
            string[] szzzzzzzzzzzzu_ = [
                "active",
                "completed",
            ];
            bool? szzzzzzzzzzzzv_ = context.Operators.In<string>(szzzzzzzzzzzzt_, szzzzzzzzzzzzu_ as IEnumerable<string>);
            bool? szzzzzzzzzzzzw_ = context.Operators.And(szzzzzzzzzzzzq_, szzzzzzzzzzzzv_);
            Code<MedicationRequest.MedicationRequestIntent> szzzzzzzzzzzzx_ = Antithrombotic?.IntentElement;
            MedicationRequest.MedicationRequestIntent? szzzzzzzzzzzzy_ = szzzzzzzzzzzzx_?.Value;
            string szzzzzzzzzzzzz_ = context.Operators.Convert<string>(szzzzzzzzzzzzy_);
            string[] tzzzzzzzzzzzza_ = [
                "order",
                "original-order",
                "reflex-order",
                "filler-order",
                "instance-order",
            ];
            bool? tzzzzzzzzzzzzb_ = context.Operators.In<string>(szzzzzzzzzzzzz_, tzzzzzzzzzzzza_ as IEnumerable<string>);
            bool? tzzzzzzzzzzzzc_ = context.Operators.And(szzzzzzzzzzzzw_, tzzzzzzzzzzzzb_);

            return tzzzzzzzzzzzzc_;
        };
        IEnumerable<MedicationRequest> szzzzzzzzzzzzn_ = context.Operators.Where<MedicationRequest>(szzzzzzzzzzzzl_, szzzzzzzzzzzzm_);

        return szzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Reason for Not Giving Antithrombotic at Discharge")]
    public IEnumerable<MedicationRequest> Reason_for_Not_Giving_Antithrombotic_at_Discharge(CqlContext context)
    {
        CqlValueSet tzzzzzzzzzzzzd_ = this.Antithrombotic_Therapy_for_Ischemic_Stroke(context);
        IEnumerable<MedicationRequest> tzzzzzzzzzzzze_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, tzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-mednotrequested"));
        IEnumerable<MedicationRequest> tzzzzzzzzzzzzg_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, tzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-mednotrequested"));
        IEnumerable<MedicationRequest> tzzzzzzzzzzzzh_ = context.Operators.Union<MedicationRequest>(tzzzzzzzzzzzze_, tzzzzzzzzzzzzg_);
        bool? tzzzzzzzzzzzzi_(MedicationRequest NoAntithromboticDischarge)
        {
            List<CodeableConcept> tzzzzzzzzzzzzk_ = NoAntithromboticDischarge?.ReasonCode;
            CqlConcept tzzzzzzzzzzzzl_(CodeableConcept @this)
            {
                CqlConcept tzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return tzzzzzzzzzzzzz_;
            };
            IEnumerable<CqlConcept> tzzzzzzzzzzzzm_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)tzzzzzzzzzzzzk_, tzzzzzzzzzzzzl_);
            CqlValueSet tzzzzzzzzzzzzn_ = this.Medical_Reason_For_Not_Providing_Treatment(context);
            bool? tzzzzzzzzzzzzo_ = context.Operators.ConceptsInValueSet(tzzzzzzzzzzzzm_, tzzzzzzzzzzzzn_);
            CqlConcept tzzzzzzzzzzzzq_(CodeableConcept @this)
            {
                CqlConcept uzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return uzzzzzzzzzzzza_;
            };
            IEnumerable<CqlConcept> tzzzzzzzzzzzzr_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)tzzzzzzzzzzzzk_, tzzzzzzzzzzzzq_);
            CqlValueSet tzzzzzzzzzzzzs_ = this.Patient_Refusal(context);
            bool? tzzzzzzzzzzzzt_ = context.Operators.ConceptsInValueSet(tzzzzzzzzzzzzr_, tzzzzzzzzzzzzs_);
            bool? tzzzzzzzzzzzzu_ = context.Operators.Or(tzzzzzzzzzzzzo_, tzzzzzzzzzzzzt_);
            bool? tzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.isCommunity(context, NoAntithromboticDischarge);
            bool? tzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.isDischarge(context, NoAntithromboticDischarge);
            bool? tzzzzzzzzzzzzx_ = context.Operators.Or(tzzzzzzzzzzzzv_, tzzzzzzzzzzzzw_);
            bool? tzzzzzzzzzzzzy_ = context.Operators.And(tzzzzzzzzzzzzu_, tzzzzzzzzzzzzx_);

            return tzzzzzzzzzzzzy_;
        };
        IEnumerable<MedicationRequest> tzzzzzzzzzzzzj_ = context.Operators.Where<MedicationRequest>(tzzzzzzzzzzzzh_, tzzzzzzzzzzzzi_);

        return tzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Encounter with Documented Reason for No Antithrombotic At Discharge")]
    public IEnumerable<Encounter> Encounter_with_Documented_Reason_for_No_Antithrombotic_At_Discharge(CqlContext context)
    {
        IEnumerable<Encounter> uzzzzzzzzzzzzb_ = TJCOverall_8_14_000.Instance.Ischemic_Stroke_Encounter(context);
        IEnumerable<Encounter> uzzzzzzzzzzzzc_(Encounter IschemicStrokeEncounter)
        {
            IEnumerable<MedicationRequest> uzzzzzzzzzzzze_ = this.Reason_for_Not_Giving_Antithrombotic_at_Discharge(context);
            bool? uzzzzzzzzzzzzf_(MedicationRequest NoDischargeAntithrombotic)
            {
                FhirDateTime uzzzzzzzzzzzzj_ = NoDischargeAntithrombotic?.AuthoredOnElement;
                CqlDateTime uzzzzzzzzzzzzk_ = context.Operators.Convert<CqlDateTime>(uzzzzzzzzzzzzj_);
                Period uzzzzzzzzzzzzl_ = IschemicStrokeEncounter?.Period;
                CqlInterval<CqlDateTime> uzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzzzzzzzzl_);
                bool? uzzzzzzzzzzzzn_ = context.Operators.In<CqlDateTime>(uzzzzzzzzzzzzk_, uzzzzzzzzzzzzm_, default);

                return uzzzzzzzzzzzzn_;
            };
            IEnumerable<MedicationRequest> uzzzzzzzzzzzzg_ = context.Operators.Where<MedicationRequest>(uzzzzzzzzzzzze_, uzzzzzzzzzzzzf_);
            Encounter uzzzzzzzzzzzzh_(MedicationRequest NoDischargeAntithrombotic) =>
                IschemicStrokeEncounter;
            IEnumerable<Encounter> uzzzzzzzzzzzzi_ = context.Operators.Select<MedicationRequest, Encounter>(uzzzzzzzzzzzzg_, uzzzzzzzzzzzzh_);

            return uzzzzzzzzzzzzi_;
        };
        IEnumerable<Encounter> uzzzzzzzzzzzzd_ = context.Operators.SelectMany<Encounter, Encounter>(uzzzzzzzzzzzzb_, uzzzzzzzzzzzzc_);

        return uzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Pharmacological Contraindications for Antithrombotic Therapy at Discharge")]
    public IEnumerable<MedicationRequest> Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge(CqlContext context)
    {
        CqlValueSet uzzzzzzzzzzzzo_ = this.Pharmacological_Contraindications_For_Antithrombotic_Therapy(context);
        IEnumerable<MedicationRequest> uzzzzzzzzzzzzp_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, uzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> uzzzzzzzzzzzzr_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, uzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> uzzzzzzzzzzzzs_ = context.Operators.Union<MedicationRequest>(uzzzzzzzzzzzzp_, uzzzzzzzzzzzzr_);
        bool? uzzzzzzzzzzzzt_(MedicationRequest Pharmacological)
        {
            bool? uzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.isCommunity(context, Pharmacological);
            bool? uzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.isDischarge(context, Pharmacological);
            bool? uzzzzzzzzzzzzx_ = context.Operators.Or(uzzzzzzzzzzzzv_, uzzzzzzzzzzzzw_);
            Code<MedicationRequest.MedicationrequestStatus> uzzzzzzzzzzzzy_ = Pharmacological?.StatusElement;
            MedicationRequest.MedicationrequestStatus? uzzzzzzzzzzzzz_ = uzzzzzzzzzzzzy_?.Value;
            string vzzzzzzzzzzzza_ = context.Operators.Convert<string>(uzzzzzzzzzzzzz_);
            string[] vzzzzzzzzzzzzb_ = [
                "active",
                "completed",
            ];
            bool? vzzzzzzzzzzzzc_ = context.Operators.In<string>(vzzzzzzzzzzzza_, vzzzzzzzzzzzzb_ as IEnumerable<string>);
            bool? vzzzzzzzzzzzzd_ = context.Operators.And(uzzzzzzzzzzzzx_, vzzzzzzzzzzzzc_);
            Code<MedicationRequest.MedicationRequestIntent> vzzzzzzzzzzzze_ = Pharmacological?.IntentElement;
            MedicationRequest.MedicationRequestIntent? vzzzzzzzzzzzzf_ = vzzzzzzzzzzzze_?.Value;
            string vzzzzzzzzzzzzg_ = context.Operators.Convert<string>(vzzzzzzzzzzzzf_);
            string[] vzzzzzzzzzzzzh_ = [
                "order",
                "original-order",
                "reflex-order",
                "filler-order",
                "instance-order",
            ];
            bool? vzzzzzzzzzzzzi_ = context.Operators.In<string>(vzzzzzzzzzzzzg_, vzzzzzzzzzzzzh_ as IEnumerable<string>);
            bool? vzzzzzzzzzzzzj_ = context.Operators.And(vzzzzzzzzzzzzd_, vzzzzzzzzzzzzi_);

            return vzzzzzzzzzzzzj_;
        };
        IEnumerable<MedicationRequest> uzzzzzzzzzzzzu_ = context.Operators.Where<MedicationRequest>(uzzzzzzzzzzzzs_, uzzzzzzzzzzzzt_);

        return uzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Encounter with Pharmacological Contraindications for Antithrombotic Therapy at Discharge")]
    public IEnumerable<Encounter> Encounter_with_Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge(CqlContext context)
    {
        IEnumerable<Encounter> vzzzzzzzzzzzzk_ = TJCOverall_8_14_000.Instance.Ischemic_Stroke_Encounter(context);
        IEnumerable<Encounter> vzzzzzzzzzzzzl_(Encounter IschemicStrokeEncounter)
        {
            IEnumerable<MedicationRequest> vzzzzzzzzzzzzn_ = this.Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge(context);
            bool? vzzzzzzzzzzzzo_(MedicationRequest DischargePharmacological)
            {
                FhirDateTime vzzzzzzzzzzzzs_ = DischargePharmacological?.AuthoredOnElement;
                CqlDateTime vzzzzzzzzzzzzt_ = context.Operators.Convert<CqlDateTime>(vzzzzzzzzzzzzs_);
                Period vzzzzzzzzzzzzu_ = IschemicStrokeEncounter?.Period;
                CqlInterval<CqlDateTime> vzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzzzzzzzzzu_);
                bool? vzzzzzzzzzzzzw_ = context.Operators.In<CqlDateTime>(vzzzzzzzzzzzzt_, vzzzzzzzzzzzzv_, default);

                return vzzzzzzzzzzzzw_;
            };
            IEnumerable<MedicationRequest> vzzzzzzzzzzzzp_ = context.Operators.Where<MedicationRequest>(vzzzzzzzzzzzzn_, vzzzzzzzzzzzzo_);
            Encounter vzzzzzzzzzzzzq_(MedicationRequest DischargePharmacological) =>
                IschemicStrokeEncounter;
            IEnumerable<Encounter> vzzzzzzzzzzzzr_ = context.Operators.Select<MedicationRequest, Encounter>(vzzzzzzzzzzzzp_, vzzzzzzzzzzzzq_);

            return vzzzzzzzzzzzzr_;
        };
        IEnumerable<Encounter> vzzzzzzzzzzzzm_ = context.Operators.SelectMany<Encounter, Encounter>(vzzzzzzzzzzzzk_, vzzzzzzzzzzzzl_);

        return vzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Denominator Exceptions")]
    public IEnumerable<Encounter> Denominator_Exceptions(CqlContext context)
    {
        IEnumerable<Encounter> vzzzzzzzzzzzzx_ = this.Encounter_with_Documented_Reason_for_No_Antithrombotic_At_Discharge(context);
        IEnumerable<Encounter> vzzzzzzzzzzzzy_ = this.Encounter_with_Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge(context);
        IEnumerable<Encounter> vzzzzzzzzzzzzz_ = context.Operators.Union<Encounter>(vzzzzzzzzzzzzx_, vzzzzzzzzzzzzy_);

        return vzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? wzzzzzzzzzzzza_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return wzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> wzzzzzzzzzzzzb_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return wzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? wzzzzzzzzzzzzc_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return wzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode wzzzzzzzzzzzzd_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return wzzzzzzzzzzzzd_;
    }


    #endregion Expressions

}
