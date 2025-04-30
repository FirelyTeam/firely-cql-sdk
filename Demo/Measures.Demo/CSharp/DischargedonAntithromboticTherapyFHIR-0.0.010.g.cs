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
[CqlLibrary("DischargedonAntithromboticTherapyFHIR", "0.0.010")]
public partial class DischargedonAntithromboticTherapyFHIR_0_0_010 : ILibrary, ISingleton<DischargedonAntithromboticTherapyFHIR_0_0_010>
{
    private DischargedonAntithromboticTherapyFHIR_0_0_010() {}

    public static DischargedonAntithromboticTherapyFHIR_0_0_010 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "DischargedonAntithromboticTherapyFHIR";
    public string Version => "0.0.010";
    public ILibrary[] Dependencies => [FHIRHelpers_4_0_001.Instance, SupplementalDataElementsFHIR4_2_0_000.Instance, MATGlobalCommonFunctionsFHIR4_6_1_000.Instance, TJCOverallFHIR_1_8_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    [CqlValueSetDefinition("Antithrombotic Therapy", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.201", valueSetVersion: null)]
    public CqlValueSet Antithrombotic_Therapy(CqlContext _) => _Antithrombotic_Therapy;
    private static readonly CqlValueSet _Antithrombotic_Therapy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.201", null);

    [CqlValueSetDefinition("Comfort Measures", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/1.3.6.1.4.1.33895.1.3.0.45", valueSetVersion: null)]
    public CqlValueSet Comfort_Measures(CqlContext _) => _Comfort_Measures;
    private static readonly CqlValueSet _Comfort_Measures = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/1.3.6.1.4.1.33895.1.3.0.45", null);

    [CqlValueSetDefinition("Discharge To Acute Care Facility", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.87", valueSetVersion: null)]
    public CqlValueSet Discharge_To_Acute_Care_Facility(CqlContext _) => _Discharge_To_Acute_Care_Facility;
    private static readonly CqlValueSet _Discharge_To_Acute_Care_Facility = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.87", null);

    [CqlValueSetDefinition("Discharged to Health Care Facility for Hospice Care", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.207", valueSetVersion: null)]
    public CqlValueSet Discharged_to_Health_Care_Facility_for_Hospice_Care(CqlContext _) => _Discharged_to_Health_Care_Facility_for_Hospice_Care;
    private static readonly CqlValueSet _Discharged_to_Health_Care_Facility_for_Hospice_Care = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.207", null);

    [CqlValueSetDefinition("Discharged to Home for Hospice Care", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.209", valueSetVersion: null)]
    public CqlValueSet Discharged_to_Home_for_Hospice_Care(CqlContext _) => _Discharged_to_Home_for_Hospice_Care;
    private static readonly CqlValueSet _Discharged_to_Home_for_Hospice_Care = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.209", null);

    [CqlValueSetDefinition("Emergency Department Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292", valueSetVersion: null)]
    public CqlValueSet Emergency_Department_Visit(CqlContext _) => _Emergency_Department_Visit;
    private static readonly CqlValueSet _Emergency_Department_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292", null);

    [CqlValueSetDefinition("Hemorrhagic Stroke", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.212", valueSetVersion: null)]
    public CqlValueSet Hemorrhagic_Stroke(CqlContext _) => _Hemorrhagic_Stroke;
    private static readonly CqlValueSet _Hemorrhagic_Stroke = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.212", null);

    [CqlValueSetDefinition("Ischemic Stroke", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.247", valueSetVersion: null)]
    public CqlValueSet Ischemic_Stroke(CqlContext _) => _Ischemic_Stroke;
    private static readonly CqlValueSet _Ischemic_Stroke = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.247", null);

    [CqlValueSetDefinition("Left Against Medical Advice", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.308", valueSetVersion: null)]
    public CqlValueSet Left_Against_Medical_Advice(CqlContext _) => _Left_Against_Medical_Advice;
    private static readonly CqlValueSet _Left_Against_Medical_Advice = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.308", null);

    [CqlValueSetDefinition("Medical Reason", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.473", valueSetVersion: null)]
    public CqlValueSet Medical_Reason(CqlContext _) => _Medical_Reason;
    private static readonly CqlValueSet _Medical_Reason = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.473", null);

    [CqlValueSetDefinition("Non-Elective Inpatient Encounter", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.424", valueSetVersion: null)]
    public CqlValueSet Non_Elective_Inpatient_Encounter(CqlContext _) => _Non_Elective_Inpatient_Encounter;
    private static readonly CqlValueSet _Non_Elective_Inpatient_Encounter = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.424", null);

    [CqlValueSetDefinition("Patient Expired", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309", valueSetVersion: null)]
    public CqlValueSet Patient_Expired(CqlContext _) => _Patient_Expired;
    private static readonly CqlValueSet _Patient_Expired = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309", null);

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
        object ozzzzzzs_ = context.ResolveParameter("DischargedonAntithromboticTherapyFHIR-0.0.010", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)ozzzzzzs_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> ozzzzzzt_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient ozzzzzzu_ = context.Operators.SingletonFrom<Patient>(ozzzzzzt_);

        return ozzzzzzu_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context)
    {
        IEnumerable<Encounter> ozzzzzzv_ = TJCOverallFHIR_1_8_000.Instance.Ischemic_Stroke_Encounter(context);

        return ozzzzzzv_;
    }


    [CqlExpressionDefinition("Antithrombotic Not Given at Discharge")]
    public IEnumerable<MedicationRequest> Antithrombotic_Not_Given_at_Discharge(CqlContext context)
    {
        CqlValueSet ozzzzzzw_ = this.Antithrombotic_Therapy(context);
        IEnumerable<MedicationRequest> ozzzzzzx_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ozzzzzzw_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
        bool? ozzzzzzy_(MedicationRequest NoAntithromboticDischarge)
        {
            FhirBoolean pzzzzzza_ = NoAntithromboticDischarge?.DoNotPerformElement;
            bool? pzzzzzzb_ = FHIRHelpers_4_0_001.Instance.ToBoolean(context, pzzzzzza_);
            bool? pzzzzzzc_ = context.Operators.IsTrue(pzzzzzzb_);
            List<CodeableConcept> pzzzzzzd_ = NoAntithromboticDischarge?.ReasonCode;
            CqlConcept pzzzzzze_(CodeableConcept X)
            {
                CqlConcept qzzzzzzd_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, X);

                return qzzzzzzd_;
            };
            IEnumerable<CqlConcept> pzzzzzzf_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)pzzzzzzd_, pzzzzzze_);
            CqlValueSet pzzzzzzg_ = this.Medical_Reason(context);
            bool? pzzzzzzh_ = context.Operators.ConceptsInValueSet(pzzzzzzf_, pzzzzzzg_);
            CqlConcept pzzzzzzj_(CodeableConcept X)
            {
                CqlConcept qzzzzzze_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, X);

                return qzzzzzze_;
            };
            IEnumerable<CqlConcept> pzzzzzzk_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)pzzzzzzd_, pzzzzzzj_);
            CqlValueSet pzzzzzzl_ = this.Patient_Refusal(context);
            bool? pzzzzzzm_ = context.Operators.ConceptsInValueSet(pzzzzzzk_, pzzzzzzl_);
            bool? pzzzzzzn_ = context.Operators.Or(pzzzzzzh_, pzzzzzzm_);
            bool? pzzzzzzo_ = context.Operators.And(pzzzzzzc_, pzzzzzzn_);
            List<CodeableConcept> pzzzzzzp_ = NoAntithromboticDischarge?.Category;
            bool? pzzzzzzq_(CodeableConcept C)
            {
                CqlConcept qzzzzzzf_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, C);
                CqlCode qzzzzzzg_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Community(context);
                CqlConcept qzzzzzzh_ = context.Operators.ConvertCodeToConcept(qzzzzzzg_);
                bool? qzzzzzzi_ = context.Operators.Equivalent(qzzzzzzf_, qzzzzzzh_);
                CqlCode qzzzzzzk_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Discharge(context);
                CqlConcept qzzzzzzl_ = context.Operators.ConvertCodeToConcept(qzzzzzzk_);
                bool? qzzzzzzm_ = context.Operators.Equivalent(qzzzzzzf_, qzzzzzzl_);
                bool? qzzzzzzn_ = context.Operators.Or(qzzzzzzi_, qzzzzzzm_);

                return qzzzzzzn_;
            };
            IEnumerable<CodeableConcept> pzzzzzzr_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)pzzzzzzp_, pzzzzzzq_);
            bool? pzzzzzzs_ = context.Operators.Exists<CodeableConcept>(pzzzzzzr_);
            bool? pzzzzzzt_ = context.Operators.And(pzzzzzzo_, pzzzzzzs_);
            Code<MedicationRequest.MedicationrequestStatus> pzzzzzzu_ = NoAntithromboticDischarge?.StatusElement;
            string pzzzzzzv_ = FHIRHelpers_4_0_001.Instance.ToString(context, pzzzzzzu_);
            string[] pzzzzzzw_ = [
                "completed",
                "cancelled",
            ];
            bool? pzzzzzzx_ = context.Operators.In<string>(pzzzzzzv_, pzzzzzzw_ as IEnumerable<string>);
            bool? pzzzzzzy_ = context.Operators.And(pzzzzzzt_, pzzzzzzx_);
            Code<MedicationRequest.MedicationRequestIntent> pzzzzzzz_ = NoAntithromboticDischarge?.IntentElement;
            string qzzzzzza_ = FHIRHelpers_4_0_001.Instance.ToString(context, pzzzzzzz_);
            bool? qzzzzzzb_ = context.Operators.Equal(qzzzzzza_, "order");
            bool? qzzzzzzc_ = context.Operators.And(pzzzzzzy_, qzzzzzzb_);

            return qzzzzzzc_;
        };
        IEnumerable<MedicationRequest> ozzzzzzz_ = context.Operators.Where<MedicationRequest>(ozzzzzzx_, ozzzzzzy_);

        return ozzzzzzz_;
    }


    [CqlExpressionDefinition("Encounter With No Antithrombotic At Discharge")]
    public IEnumerable<Encounter> Encounter_With_No_Antithrombotic_At_Discharge(CqlContext context)
    {
        IEnumerable<Encounter> qzzzzzzo_ = TJCOverallFHIR_1_8_000.Instance.Ischemic_Stroke_Encounter(context);
        IEnumerable<Encounter> qzzzzzzp_(Encounter IschemicStrokeEncounter)
        {
            IEnumerable<MedicationRequest> qzzzzzzr_ = this.Antithrombotic_Not_Given_at_Discharge(context);
            bool? qzzzzzzs_(MedicationRequest NoDischargeAntithrombotic)
            {
                FhirDateTime qzzzzzzw_ = NoDischargeAntithrombotic?.AuthoredOnElement;
                CqlDateTime qzzzzzzx_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, qzzzzzzw_);
                Period qzzzzzzy_ = IschemicStrokeEncounter?.Period;
                CqlInterval<CqlDateTime> qzzzzzzz_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, qzzzzzzy_);
                bool? rzzzzzza_ = context.Operators.In<CqlDateTime>(qzzzzzzx_, qzzzzzzz_, default);

                return rzzzzzza_;
            };
            IEnumerable<MedicationRequest> qzzzzzzt_ = context.Operators.Where<MedicationRequest>(qzzzzzzr_, qzzzzzzs_);
            Encounter qzzzzzzu_(MedicationRequest NoDischargeAntithrombotic) =>
                IschemicStrokeEncounter;
            IEnumerable<Encounter> qzzzzzzv_ = context.Operators.Select<MedicationRequest, Encounter>(qzzzzzzt_, qzzzzzzu_);

            return qzzzzzzv_;
        };
        IEnumerable<Encounter> qzzzzzzq_ = context.Operators.SelectMany<Encounter, Encounter>(qzzzzzzo_, qzzzzzzp_);

        return qzzzzzzq_;
    }


    [CqlExpressionDefinition("Pharmacological Contraindications for Antithrombotic Therapy at Discharge")]
    public IEnumerable<MedicationRequest> Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge(CqlContext context)
    {
        CqlValueSet rzzzzzzb_ = this.Pharmacological_Contraindications_For_Antithrombotic_Therapy(context);
        IEnumerable<MedicationRequest> rzzzzzzc_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, rzzzzzzb_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
        bool? rzzzzzzd_(MedicationRequest Pharmacological)
        {
            FhirBoolean rzzzzzzf_ = Pharmacological?.DoNotPerformElement;
            bool? rzzzzzzg_ = FHIRHelpers_4_0_001.Instance.ToBoolean(context, rzzzzzzf_);
            bool? rzzzzzzh_ = context.Operators.IsTrue(rzzzzzzg_);
            bool? rzzzzzzi_ = context.Operators.Not(rzzzzzzh_);
            List<CodeableConcept> rzzzzzzj_ = Pharmacological?.Category;
            bool? rzzzzzzk_(CodeableConcept C)
            {
                CqlConcept rzzzzzzx_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, C);
                CqlCode rzzzzzzy_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Community(context);
                CqlConcept rzzzzzzz_ = context.Operators.ConvertCodeToConcept(rzzzzzzy_);
                bool? szzzzzza_ = context.Operators.Equivalent(rzzzzzzx_, rzzzzzzz_);
                CqlCode szzzzzzc_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Discharge(context);
                CqlConcept szzzzzzd_ = context.Operators.ConvertCodeToConcept(szzzzzzc_);
                bool? szzzzzze_ = context.Operators.Equivalent(rzzzzzzx_, szzzzzzd_);
                bool? szzzzzzf_ = context.Operators.Or(szzzzzza_, szzzzzze_);

                return szzzzzzf_;
            };
            IEnumerable<CodeableConcept> rzzzzzzl_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)rzzzzzzj_, rzzzzzzk_);
            bool? rzzzzzzm_ = context.Operators.Exists<CodeableConcept>(rzzzzzzl_);
            bool? rzzzzzzn_ = context.Operators.And(rzzzzzzi_, rzzzzzzm_);
            Code<MedicationRequest.MedicationrequestStatus> rzzzzzzo_ = Pharmacological?.StatusElement;
            string rzzzzzzp_ = FHIRHelpers_4_0_001.Instance.ToString(context, rzzzzzzo_);
            string[] rzzzzzzq_ = [
                "active",
                "completed",
            ];
            bool? rzzzzzzr_ = context.Operators.In<string>(rzzzzzzp_, rzzzzzzq_ as IEnumerable<string>);
            bool? rzzzzzzs_ = context.Operators.And(rzzzzzzn_, rzzzzzzr_);
            Code<MedicationRequest.MedicationRequestIntent> rzzzzzzt_ = Pharmacological?.IntentElement;
            string rzzzzzzu_ = FHIRHelpers_4_0_001.Instance.ToString(context, rzzzzzzt_);
            bool? rzzzzzzv_ = context.Operators.Equal(rzzzzzzu_, "order");
            bool? rzzzzzzw_ = context.Operators.And(rzzzzzzs_, rzzzzzzv_);

            return rzzzzzzw_;
        };
        IEnumerable<MedicationRequest> rzzzzzze_ = context.Operators.Where<MedicationRequest>(rzzzzzzc_, rzzzzzzd_);

        return rzzzzzze_;
    }


    [CqlExpressionDefinition("Encounter With Pharmacological Contraindications for Antithrombotic Therapy at Discharge")]
    public IEnumerable<Encounter> Encounter_With_Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge(CqlContext context)
    {
        IEnumerable<Encounter> szzzzzzg_ = TJCOverallFHIR_1_8_000.Instance.Ischemic_Stroke_Encounter(context);
        IEnumerable<Encounter> szzzzzzh_(Encounter IschemicStrokeEncounter)
        {
            IEnumerable<MedicationRequest> szzzzzzj_ = this.Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge(context);
            bool? szzzzzzk_(MedicationRequest DischargePharmacological)
            {
                FhirDateTime szzzzzzo_ = DischargePharmacological?.AuthoredOnElement;
                CqlDateTime szzzzzzp_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, szzzzzzo_);
                Period szzzzzzq_ = IschemicStrokeEncounter?.Period;
                CqlInterval<CqlDateTime> szzzzzzr_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, szzzzzzq_);
                bool? szzzzzzs_ = context.Operators.In<CqlDateTime>(szzzzzzp_, szzzzzzr_, default);

                return szzzzzzs_;
            };
            IEnumerable<MedicationRequest> szzzzzzl_ = context.Operators.Where<MedicationRequest>(szzzzzzj_, szzzzzzk_);
            Encounter szzzzzzm_(MedicationRequest DischargePharmacological) =>
                IschemicStrokeEncounter;
            IEnumerable<Encounter> szzzzzzn_ = context.Operators.Select<MedicationRequest, Encounter>(szzzzzzl_, szzzzzzm_);

            return szzzzzzn_;
        };
        IEnumerable<Encounter> szzzzzzi_ = context.Operators.SelectMany<Encounter, Encounter>(szzzzzzg_, szzzzzzh_);

        return szzzzzzi_;
    }


    [CqlExpressionDefinition("Denominator Exceptions")]
    public IEnumerable<Encounter> Denominator_Exceptions(CqlContext context)
    {
        IEnumerable<Encounter> szzzzzzt_ = this.Encounter_With_No_Antithrombotic_At_Discharge(context);
        IEnumerable<Encounter> szzzzzzu_ = this.Encounter_With_Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge(context);
        IEnumerable<Encounter> szzzzzzv_ = context.Operators.Union<Encounter>(szzzzzzt_, szzzzzzu_);

        return szzzzzzv_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public IEnumerable<Encounter> Denominator_Exclusions(CqlContext context)
    {
        IEnumerable<Encounter> szzzzzzw_ = TJCOverallFHIR_1_8_000.Instance.Ischemic_Stroke_Encounters_with_Discharge_Disposition(context);
        IEnumerable<Encounter> szzzzzzx_ = TJCOverallFHIR_1_8_000.Instance.Encounter_with_Comfort_Measures_during_Hospitalization(context);
        IEnumerable<Encounter> szzzzzzy_ = context.Operators.Union<Encounter>(szzzzzzw_, szzzzzzx_);

        return szzzzzzy_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> szzzzzzz_ = TJCOverallFHIR_1_8_000.Instance.Encounter_with_Principal_Diagnosis_and_Age(context);

        return szzzzzzz_;
    }


    [CqlExpressionDefinition("Antithrombotic Therapy at Discharge")]
    public IEnumerable<MedicationRequest> Antithrombotic_Therapy_at_Discharge(CqlContext context)
    {
        CqlValueSet tzzzzzza_ = this.Antithrombotic_Therapy(context);
        IEnumerable<MedicationRequest> tzzzzzzb_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, tzzzzzza_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
        bool? tzzzzzzc_(MedicationRequest Antithrombotic)
        {
            FhirBoolean tzzzzzze_ = Antithrombotic?.DoNotPerformElement;
            bool? tzzzzzzf_ = FHIRHelpers_4_0_001.Instance.ToBoolean(context, tzzzzzze_);
            bool? tzzzzzzg_ = context.Operators.IsTrue(tzzzzzzf_);
            bool? tzzzzzzh_ = context.Operators.Not(tzzzzzzg_);
            List<CodeableConcept> tzzzzzzi_ = Antithrombotic?.Category;
            bool? tzzzzzzj_(CodeableConcept C)
            {
                CqlConcept tzzzzzzw_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, C);
                CqlCode tzzzzzzx_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Community(context);
                CqlConcept tzzzzzzy_ = context.Operators.ConvertCodeToConcept(tzzzzzzx_);
                bool? tzzzzzzz_ = context.Operators.Equivalent(tzzzzzzw_, tzzzzzzy_);
                CqlCode uzzzzzzb_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Discharge(context);
                CqlConcept uzzzzzzc_ = context.Operators.ConvertCodeToConcept(uzzzzzzb_);
                bool? uzzzzzzd_ = context.Operators.Equivalent(tzzzzzzw_, uzzzzzzc_);
                bool? uzzzzzze_ = context.Operators.Or(tzzzzzzz_, uzzzzzzd_);

                return uzzzzzze_;
            };
            IEnumerable<CodeableConcept> tzzzzzzk_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)tzzzzzzi_, tzzzzzzj_);
            bool? tzzzzzzl_ = context.Operators.Exists<CodeableConcept>(tzzzzzzk_);
            bool? tzzzzzzm_ = context.Operators.And(tzzzzzzh_, tzzzzzzl_);
            Code<MedicationRequest.MedicationrequestStatus> tzzzzzzn_ = Antithrombotic?.StatusElement;
            string tzzzzzzo_ = FHIRHelpers_4_0_001.Instance.ToString(context, tzzzzzzn_);
            string[] tzzzzzzp_ = [
                "active",
                "completed",
            ];
            bool? tzzzzzzq_ = context.Operators.In<string>(tzzzzzzo_, tzzzzzzp_ as IEnumerable<string>);
            bool? tzzzzzzr_ = context.Operators.And(tzzzzzzm_, tzzzzzzq_);
            Code<MedicationRequest.MedicationRequestIntent> tzzzzzzs_ = Antithrombotic?.IntentElement;
            string tzzzzzzt_ = FHIRHelpers_4_0_001.Instance.ToString(context, tzzzzzzs_);
            bool? tzzzzzzu_ = context.Operators.Equal(tzzzzzzt_, "order");
            bool? tzzzzzzv_ = context.Operators.And(tzzzzzzr_, tzzzzzzu_);

            return tzzzzzzv_;
        };
        IEnumerable<MedicationRequest> tzzzzzzd_ = context.Operators.Where<MedicationRequest>(tzzzzzzb_, tzzzzzzc_);

        return tzzzzzzd_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context)
    {
        IEnumerable<Encounter> uzzzzzzf_ = TJCOverallFHIR_1_8_000.Instance.Ischemic_Stroke_Encounter(context);
        IEnumerable<Encounter> uzzzzzzg_(Encounter IschemicStrokeEncounter)
        {
            IEnumerable<MedicationRequest> uzzzzzzi_ = this.Antithrombotic_Therapy_at_Discharge(context);
            bool? uzzzzzzj_(MedicationRequest DischargeAntithrombotic)
            {
                FhirDateTime uzzzzzzn_ = DischargeAntithrombotic?.AuthoredOnElement;
                CqlDateTime uzzzzzzo_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, uzzzzzzn_);
                Period uzzzzzzp_ = IschemicStrokeEncounter?.Period;
                CqlInterval<CqlDateTime> uzzzzzzq_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, uzzzzzzp_);
                bool? uzzzzzzr_ = context.Operators.In<CqlDateTime>(uzzzzzzo_, uzzzzzzq_, default);

                return uzzzzzzr_;
            };
            IEnumerable<MedicationRequest> uzzzzzzk_ = context.Operators.Where<MedicationRequest>(uzzzzzzi_, uzzzzzzj_);
            Encounter uzzzzzzl_(MedicationRequest DischargeAntithrombotic) =>
                IschemicStrokeEncounter;
            IEnumerable<Encounter> uzzzzzzm_ = context.Operators.Select<MedicationRequest, Encounter>(uzzzzzzk_, uzzzzzzl_);

            return uzzzzzzm_;
        };
        IEnumerable<Encounter> uzzzzzzh_ = context.Operators.SelectMany<Encounter, Encounter>(uzzzzzzf_, uzzzzzzg_);

        return uzzzzzzh_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity(CqlContext context)
    {
        IEnumerable<Coding> uzzzzzzs_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Ethnicity(context);

        return uzzzzzzs_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> uzzzzzzt_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Payer(context);

        return uzzzzzzt_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public IEnumerable<Coding> SDE_Race(CqlContext context)
    {
        IEnumerable<Coding> uzzzzzzu_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Race(context);

        return uzzzzzzu_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode uzzzzzzv_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Sex(context);

        return uzzzzzzv_;
    }


    #endregion Expressions

}
