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
        CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Interval(hzzzzzzzzzzzzzzzzzzzzzzf_, hzzzzzzzzzzzzzzzzzzzzzzg_, true, true);
        object hzzzzzzzzzzzzzzzzzzzzzzi_ = context.ResolveParameter("DischargedonAntithromboticTherapyFHIR-0.9.000", "Measurement Period", hzzzzzzzzzzzzzzzzzzzzzzh_);

        return (CqlInterval<CqlDateTime>)hzzzzzzzzzzzzzzzzzzzzzzi_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> hzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient hzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.SingletonFrom<Patient>(hzzzzzzzzzzzzzzzzzzzzzzj_);

        return hzzzzzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzzzl_ = TJCOverall_8_14_000.Instance.Ischemic_Stroke_Encounter(context);

        return hzzzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context)
    {
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzzzm_ = this.Initial_Population(context);

        return hzzzzzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Encounter with Comfort Measures during Hospitalization for Patients with Documented Ischemic Stroke")]
    public IEnumerable<Encounter> Encounter_with_Comfort_Measures_during_Hospitalization_for_Patients_with_Documented_Ischemic_Stroke(CqlContext context)
    {
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzzzn_ = this.Denominator(context);
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzzzo_(Encounter Encounter)
        {
            IEnumerable<object> hzzzzzzzzzzzzzzzzzzzzzzq_ = TJCOverall_8_14_000.Instance.Intervention_Comfort_Measures(context);
            bool? hzzzzzzzzzzzzzzzzzzzzzzr_(object ComfortMeasure)
            {
                object hzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                object hzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzzzv_);
                CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.toInterval(context, hzzzzzzzzzzzzzzzzzzzzzzw_);
                CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Start(hzzzzzzzzzzzzzzzzzzzzzzx_);
                object hzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "authoredOn");
                CqlDateTime izzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.LateBoundProperty<CqlDateTime>(hzzzzzzzzzzzzzzzzzzzzzzz_, "value");
                CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzzb_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservation(context, Encounter);
                bool? izzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.In<CqlDateTime>(hzzzzzzzzzzzzzzzzzzzzzzy_ ?? izzzzzzzzzzzzzzzzzzzzzza_, izzzzzzzzzzzzzzzzzzzzzzb_, default);

                return izzzzzzzzzzzzzzzzzzzzzzc_;
            };
            IEnumerable<object> hzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Where<object>(hzzzzzzzzzzzzzzzzzzzzzzq_, hzzzzzzzzzzzzzzzzzzzzzzr_);
            Encounter hzzzzzzzzzzzzzzzzzzzzzzt_(object ComfortMeasure) =>
                Encounter;
            IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Select<object, Encounter>(hzzzzzzzzzzzzzzzzzzzzzzs_, hzzzzzzzzzzzzzzzzzzzzzzt_);

            return hzzzzzzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.SelectMany<Encounter, Encounter>(hzzzzzzzzzzzzzzzzzzzzzzn_, hzzzzzzzzzzzzzzzzzzzzzzo_);

        return hzzzzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public IEnumerable<Encounter> Denominator_Exclusions(CqlContext context)
    {
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzzzd_ = TJCOverall_8_14_000.Instance.Ischemic_Stroke_Encounters_with_Discharge_Disposition(context);
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzzze_ = this.Encounter_with_Comfort_Measures_during_Hospitalization_for_Patients_with_Documented_Ischemic_Stroke(context);
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Union<Encounter>(izzzzzzzzzzzzzzzzzzzzzzd_, izzzzzzzzzzzzzzzzzzzzzze_);

        return izzzzzzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context)
    {
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzzzg_ = TJCOverall_8_14_000.Instance.Ischemic_Stroke_Encounter(context);
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzzzh_(Encounter IschemicStrokeEncounter)
        {
            CqlValueSet izzzzzzzzzzzzzzzzzzzzzzj_ = this.Antithrombotic_Therapy_for_Ischemic_Stroke(context);
            IEnumerable<MedicationRequest> izzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, izzzzzzzzzzzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> izzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, izzzzzzzzzzzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> izzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Union<MedicationRequest>(izzzzzzzzzzzzzzzzzzzzzzk_, izzzzzzzzzzzzzzzzzzzzzzm_);
            bool? izzzzzzzzzzzzzzzzzzzzzzo_(MedicationRequest DischargeAntithrombotic)
            {
                FhirDateTime izzzzzzzzzzzzzzzzzzzzzzs_ = DischargeAntithrombotic?.AuthoredOnElement;
                CqlDateTime izzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Convert<CqlDateTime>(izzzzzzzzzzzzzzzzzzzzzzs_);
                Period izzzzzzzzzzzzzzzzzzzzzzu_ = IschemicStrokeEncounter?.Period;
                CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzzzzzzzzzzzzzzzzzu_);
                bool? izzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.In<CqlDateTime>(izzzzzzzzzzzzzzzzzzzzzzt_, izzzzzzzzzzzzzzzzzzzzzzv_, default);

                return izzzzzzzzzzzzzzzzzzzzzzw_;
            };
            IEnumerable<MedicationRequest> izzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<MedicationRequest>(izzzzzzzzzzzzzzzzzzzzzzn_, izzzzzzzzzzzzzzzzzzzzzzo_);
            Encounter izzzzzzzzzzzzzzzzzzzzzzq_(MedicationRequest DischargeAntithrombotic) =>
                IschemicStrokeEncounter;
            IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Select<MedicationRequest, Encounter>(izzzzzzzzzzzzzzzzzzzzzzp_, izzzzzzzzzzzzzzzzzzzzzzq_);

            return izzzzzzzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.SelectMany<Encounter, Encounter>(izzzzzzzzzzzzzzzzzzzzzzg_, izzzzzzzzzzzzzzzzzzzzzzh_);

        return izzzzzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Antithrombotic Therapy at Discharge")]
    public IEnumerable<MedicationRequest> Antithrombotic_Therapy_at_Discharge(CqlContext context)
    {
        CqlValueSet izzzzzzzzzzzzzzzzzzzzzzx_ = this.Antithrombotic_Therapy_for_Ischemic_Stroke(context);
        IEnumerable<MedicationRequest> izzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, izzzzzzzzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> jzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, izzzzzzzzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> jzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Union<MedicationRequest>(izzzzzzzzzzzzzzzzzzzzzzy_, jzzzzzzzzzzzzzzzzzzzzzza_);
        bool? jzzzzzzzzzzzzzzzzzzzzzzc_(MedicationRequest Antithrombotic)
        {
            bool? jzzzzzzzzzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.isCommunity(context, Antithrombotic);
            bool? jzzzzzzzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.isDischarge(context, Antithrombotic);
            bool? jzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Or(jzzzzzzzzzzzzzzzzzzzzzze_, jzzzzzzzzzzzzzzzzzzzzzzf_);
            Code<MedicationRequest.MedicationrequestStatus> jzzzzzzzzzzzzzzzzzzzzzzh_ = Antithrombotic?.StatusElement;
            MedicationRequest.MedicationrequestStatus? jzzzzzzzzzzzzzzzzzzzzzzi_ = jzzzzzzzzzzzzzzzzzzzzzzh_?.Value;
            string jzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Convert<string>(jzzzzzzzzzzzzzzzzzzzzzzi_);
            string[] jzzzzzzzzzzzzzzzzzzzzzzk_ = [
                "active",
                "completed",
            ];
            bool? jzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.In<string>(jzzzzzzzzzzzzzzzzzzzzzzj_, jzzzzzzzzzzzzzzzzzzzzzzk_ as IEnumerable<string>);
            bool? jzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.And(jzzzzzzzzzzzzzzzzzzzzzzg_, jzzzzzzzzzzzzzzzzzzzzzzl_);
            Code<MedicationRequest.MedicationRequestIntent> jzzzzzzzzzzzzzzzzzzzzzzn_ = Antithrombotic?.IntentElement;
            MedicationRequest.MedicationRequestIntent? jzzzzzzzzzzzzzzzzzzzzzzo_ = jzzzzzzzzzzzzzzzzzzzzzzn_?.Value;
            string jzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Convert<string>(jzzzzzzzzzzzzzzzzzzzzzzo_);
            string[] jzzzzzzzzzzzzzzzzzzzzzzq_ = [
                "order",
                "original-order",
                "reflex-order",
                "filler-order",
                "instance-order",
            ];
            bool? jzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.In<string>(jzzzzzzzzzzzzzzzzzzzzzzp_, jzzzzzzzzzzzzzzzzzzzzzzq_ as IEnumerable<string>);
            bool? jzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.And(jzzzzzzzzzzzzzzzzzzzzzzm_, jzzzzzzzzzzzzzzzzzzzzzzr_);

            return jzzzzzzzzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<MedicationRequest> jzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Where<MedicationRequest>(jzzzzzzzzzzzzzzzzzzzzzzb_, jzzzzzzzzzzzzzzzzzzzzzzc_);

        return jzzzzzzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Reason for Not Giving Antithrombotic at Discharge")]
    public IEnumerable<MedicationRequest> Reason_for_Not_Giving_Antithrombotic_at_Discharge(CqlContext context)
    {
        CqlValueSet jzzzzzzzzzzzzzzzzzzzzzzt_ = this.Antithrombotic_Therapy_for_Ischemic_Stroke(context);
        IEnumerable<MedicationRequest> jzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, jzzzzzzzzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-mednotrequested"));
        IEnumerable<MedicationRequest> jzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, jzzzzzzzzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-mednotrequested"));
        IEnumerable<MedicationRequest> jzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Union<MedicationRequest>(jzzzzzzzzzzzzzzzzzzzzzzu_, jzzzzzzzzzzzzzzzzzzzzzzw_);
        bool? jzzzzzzzzzzzzzzzzzzzzzzy_(MedicationRequest NoAntithromboticDischarge)
        {
            List<CodeableConcept> kzzzzzzzzzzzzzzzzzzzzzza_ = NoAntithromboticDischarge?.ReasonCode;
            CqlConcept kzzzzzzzzzzzzzzzzzzzzzzb_(CodeableConcept @this)
            {
                CqlConcept kzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return kzzzzzzzzzzzzzzzzzzzzzzp_;
            };
            IEnumerable<CqlConcept> kzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)kzzzzzzzzzzzzzzzzzzzzzza_, kzzzzzzzzzzzzzzzzzzzzzzb_);
            CqlValueSet kzzzzzzzzzzzzzzzzzzzzzzd_ = this.Medical_Reason_For_Not_Providing_Treatment(context);
            bool? kzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.ConceptsInValueSet(kzzzzzzzzzzzzzzzzzzzzzzc_, kzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlConcept kzzzzzzzzzzzzzzzzzzzzzzg_(CodeableConcept @this)
            {
                CqlConcept kzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return kzzzzzzzzzzzzzzzzzzzzzzq_;
            };
            IEnumerable<CqlConcept> kzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)kzzzzzzzzzzzzzzzzzzzzzza_, kzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlValueSet kzzzzzzzzzzzzzzzzzzzzzzi_ = this.Patient_Refusal(context);
            bool? kzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.ConceptsInValueSet(kzzzzzzzzzzzzzzzzzzzzzzh_, kzzzzzzzzzzzzzzzzzzzzzzi_);
            bool? kzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Or(kzzzzzzzzzzzzzzzzzzzzzze_, kzzzzzzzzzzzzzzzzzzzzzzj_);
            bool? kzzzzzzzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.isCommunity(context, NoAntithromboticDischarge);
            bool? kzzzzzzzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.isDischarge(context, NoAntithromboticDischarge);
            bool? kzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Or(kzzzzzzzzzzzzzzzzzzzzzzl_, kzzzzzzzzzzzzzzzzzzzzzzm_);
            bool? kzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.And(kzzzzzzzzzzzzzzzzzzzzzzk_, kzzzzzzzzzzzzzzzzzzzzzzn_);

            return kzzzzzzzzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<MedicationRequest> jzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Where<MedicationRequest>(jzzzzzzzzzzzzzzzzzzzzzzx_, jzzzzzzzzzzzzzzzzzzzzzzy_);

        return jzzzzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Encounter with Documented Reason for No Antithrombotic At Discharge")]
    public IEnumerable<Encounter> Encounter_with_Documented_Reason_for_No_Antithrombotic_At_Discharge(CqlContext context)
    {
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzzr_ = TJCOverall_8_14_000.Instance.Ischemic_Stroke_Encounter(context);
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzzs_(Encounter IschemicStrokeEncounter)
        {
            IEnumerable<MedicationRequest> kzzzzzzzzzzzzzzzzzzzzzzu_ = this.Reason_for_Not_Giving_Antithrombotic_at_Discharge(context);
            bool? kzzzzzzzzzzzzzzzzzzzzzzv_(MedicationRequest NoDischargeAntithrombotic)
            {
                FhirDateTime kzzzzzzzzzzzzzzzzzzzzzzz_ = NoDischargeAntithrombotic?.AuthoredOnElement;
                CqlDateTime lzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Convert<CqlDateTime>(kzzzzzzzzzzzzzzzzzzzzzzz_);
                Period lzzzzzzzzzzzzzzzzzzzzzzb_ = IschemicStrokeEncounter?.Period;
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzzzzzzzzzzzzzzzzzb_);
                bool? lzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.In<CqlDateTime>(lzzzzzzzzzzzzzzzzzzzzzza_, lzzzzzzzzzzzzzzzzzzzzzzc_, default);

                return lzzzzzzzzzzzzzzzzzzzzzzd_;
            };
            IEnumerable<MedicationRequest> kzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Where<MedicationRequest>(kzzzzzzzzzzzzzzzzzzzzzzu_, kzzzzzzzzzzzzzzzzzzzzzzv_);
            Encounter kzzzzzzzzzzzzzzzzzzzzzzx_(MedicationRequest NoDischargeAntithrombotic) =>
                IschemicStrokeEncounter;
            IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Select<MedicationRequest, Encounter>(kzzzzzzzzzzzzzzzzzzzzzzw_, kzzzzzzzzzzzzzzzzzzzzzzx_);

            return kzzzzzzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.SelectMany<Encounter, Encounter>(kzzzzzzzzzzzzzzzzzzzzzzr_, kzzzzzzzzzzzzzzzzzzzzzzs_);

        return kzzzzzzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Pharmacological Contraindications for Antithrombotic Therapy at Discharge")]
    public IEnumerable<MedicationRequest> Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge(CqlContext context)
    {
        CqlValueSet lzzzzzzzzzzzzzzzzzzzzzze_ = this.Pharmacological_Contraindications_For_Antithrombotic_Therapy(context);
        IEnumerable<MedicationRequest> lzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, lzzzzzzzzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> lzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, lzzzzzzzzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> lzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Union<MedicationRequest>(lzzzzzzzzzzzzzzzzzzzzzzf_, lzzzzzzzzzzzzzzzzzzzzzzh_);
        bool? lzzzzzzzzzzzzzzzzzzzzzzj_(MedicationRequest Pharmacological)
        {
            bool? lzzzzzzzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.isCommunity(context, Pharmacological);
            bool? lzzzzzzzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.isDischarge(context, Pharmacological);
            bool? lzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Or(lzzzzzzzzzzzzzzzzzzzzzzl_, lzzzzzzzzzzzzzzzzzzzzzzm_);
            Code<MedicationRequest.MedicationrequestStatus> lzzzzzzzzzzzzzzzzzzzzzzo_ = Pharmacological?.StatusElement;
            MedicationRequest.MedicationrequestStatus? lzzzzzzzzzzzzzzzzzzzzzzp_ = lzzzzzzzzzzzzzzzzzzzzzzo_?.Value;
            string lzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Convert<string>(lzzzzzzzzzzzzzzzzzzzzzzp_);
            string[] lzzzzzzzzzzzzzzzzzzzzzzr_ = [
                "active",
                "completed",
            ];
            bool? lzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.In<string>(lzzzzzzzzzzzzzzzzzzzzzzq_, lzzzzzzzzzzzzzzzzzzzzzzr_ as IEnumerable<string>);
            bool? lzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.And(lzzzzzzzzzzzzzzzzzzzzzzn_, lzzzzzzzzzzzzzzzzzzzzzzs_);
            Code<MedicationRequest.MedicationRequestIntent> lzzzzzzzzzzzzzzzzzzzzzzu_ = Pharmacological?.IntentElement;
            MedicationRequest.MedicationRequestIntent? lzzzzzzzzzzzzzzzzzzzzzzv_ = lzzzzzzzzzzzzzzzzzzzzzzu_?.Value;
            string lzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Convert<string>(lzzzzzzzzzzzzzzzzzzzzzzv_);
            string[] lzzzzzzzzzzzzzzzzzzzzzzx_ = [
                "order",
                "original-order",
                "reflex-order",
                "filler-order",
                "instance-order",
            ];
            bool? lzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.In<string>(lzzzzzzzzzzzzzzzzzzzzzzw_, lzzzzzzzzzzzzzzzzzzzzzzx_ as IEnumerable<string>);
            bool? lzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.And(lzzzzzzzzzzzzzzzzzzzzzzt_, lzzzzzzzzzzzzzzzzzzzzzzy_);

            return lzzzzzzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<MedicationRequest> lzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Where<MedicationRequest>(lzzzzzzzzzzzzzzzzzzzzzzi_, lzzzzzzzzzzzzzzzzzzzzzzj_);

        return lzzzzzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Encounter with Pharmacological Contraindications for Antithrombotic Therapy at Discharge")]
    public IEnumerable<Encounter> Encounter_with_Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge(CqlContext context)
    {
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzza_ = TJCOverall_8_14_000.Instance.Ischemic_Stroke_Encounter(context);
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzb_(Encounter IschemicStrokeEncounter)
        {
            IEnumerable<MedicationRequest> mzzzzzzzzzzzzzzzzzzzzzzd_ = this.Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge(context);
            bool? mzzzzzzzzzzzzzzzzzzzzzze_(MedicationRequest DischargePharmacological)
            {
                FhirDateTime mzzzzzzzzzzzzzzzzzzzzzzi_ = DischargePharmacological?.AuthoredOnElement;
                CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Convert<CqlDateTime>(mzzzzzzzzzzzzzzzzzzzzzzi_);
                Period mzzzzzzzzzzzzzzzzzzzzzzk_ = IschemicStrokeEncounter?.Period;
                CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzzzzzzzzzzzzzzzzzk_);
                bool? mzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.In<CqlDateTime>(mzzzzzzzzzzzzzzzzzzzzzzj_, mzzzzzzzzzzzzzzzzzzzzzzl_, default);

                return mzzzzzzzzzzzzzzzzzzzzzzm_;
            };
            IEnumerable<MedicationRequest> mzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Where<MedicationRequest>(mzzzzzzzzzzzzzzzzzzzzzzd_, mzzzzzzzzzzzzzzzzzzzzzze_);
            Encounter mzzzzzzzzzzzzzzzzzzzzzzg_(MedicationRequest DischargePharmacological) =>
                IschemicStrokeEncounter;
            IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Select<MedicationRequest, Encounter>(mzzzzzzzzzzzzzzzzzzzzzzf_, mzzzzzzzzzzzzzzzzzzzzzzg_);

            return mzzzzzzzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.SelectMany<Encounter, Encounter>(mzzzzzzzzzzzzzzzzzzzzzza_, mzzzzzzzzzzzzzzzzzzzzzzb_);

        return mzzzzzzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Denominator Exceptions")]
    public IEnumerable<Encounter> Denominator_Exceptions(CqlContext context)
    {
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzn_ = this.Encounter_with_Documented_Reason_for_No_Antithrombotic_At_Discharge(context);
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzo_ = this.Encounter_with_Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge(context);
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Union<Encounter>(mzzzzzzzzzzzzzzzzzzzzzzn_, mzzzzzzzzzzzzzzzzzzzzzzo_);

        return mzzzzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? mzzzzzzzzzzzzzzzzzzzzzzq_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return mzzzzzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> mzzzzzzzzzzzzzzzzzzzzzzr_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return mzzzzzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? mzzzzzzzzzzzzzzzzzzzzzzs_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return mzzzzzzzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode mzzzzzzzzzzzzzzzzzzzzzzt_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return mzzzzzzzzzzzzzzzzzzzzzzt_;
    }


    #endregion Expressions

}
