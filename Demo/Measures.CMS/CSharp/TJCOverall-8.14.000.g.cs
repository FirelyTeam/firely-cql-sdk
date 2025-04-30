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
[CqlLibrary("TJCOverall", "8.14.000")]
public partial class TJCOverall_8_14_000 : ILibrary, ISingleton<TJCOverall_8_14_000>
{
    private TJCOverall_8_14_000() {}

    public static TJCOverall_8_14_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "TJCOverall";
    public string Version => "8.14.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, CQMCommon_2_2_000.Instance, QICoreCommon_2_1_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

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

    [CqlValueSetDefinition("Ischemic Stroke", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.247", valueSetVersion: null)]
    public CqlValueSet Ischemic_Stroke(CqlContext _) => _Ischemic_Stroke;
    private static readonly CqlValueSet _Ischemic_Stroke = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.247", null);

    [CqlValueSetDefinition("Left Against Medical Advice", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.308", valueSetVersion: null)]
    public CqlValueSet Left_Against_Medical_Advice(CqlContext _) => _Left_Against_Medical_Advice;
    private static readonly CqlValueSet _Left_Against_Medical_Advice = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.308", null);

    [CqlValueSetDefinition("Nonelective Inpatient Encounter", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.424", valueSetVersion: null)]
    public CqlValueSet Nonelective_Inpatient_Encounter(CqlContext _) => _Nonelective_Inpatient_Encounter;
    private static readonly CqlValueSet _Nonelective_Inpatient_Encounter = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.424", null);

    [CqlValueSetDefinition("Patient Expired", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309", valueSetVersion: null)]
    public CqlValueSet Patient_Expired(CqlContext _) => _Patient_Expired;
    private static readonly CqlValueSet _Patient_Expired = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309", null);

    #endregion ValueSets

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        object mzzzzzzzzzzzzzzzzzzzzzu_ = context.ResolveParameter("TJCOverall-8.14.000", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)mzzzzzzzzzzzzzzzzzzzzzu_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> mzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient mzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.SingletonFrom<Patient>(mzzzzzzzzzzzzzzzzzzzzzv_);

        return mzzzzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Non Elective Inpatient Encounter with Age")]
    public IEnumerable<Encounter> Non_Elective_Inpatient_Encounter_with_Age(CqlContext context)
    {
        CqlValueSet mzzzzzzzzzzzzzzzzzzzzzx_ = this.Nonelective_Inpatient_Encounter(context);
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, mzzzzzzzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? mzzzzzzzzzzzzzzzzzzzzzz_(Encounter NonElectiveEncounter)
        {
            Patient nzzzzzzzzzzzzzzzzzzzzzb_ = this.Patient(context);
            Date nzzzzzzzzzzzzzzzzzzzzzc_ = nzzzzzzzzzzzzzzzzzzzzzb_?.BirthDateElement;
            string nzzzzzzzzzzzzzzzzzzzzzd_ = nzzzzzzzzzzzzzzzzzzzzzc_?.Value;
            CqlDate nzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.ConvertStringToDate(nzzzzzzzzzzzzzzzzzzzzzd_);
            Period nzzzzzzzzzzzzzzzzzzzzzf_ = NonElectiveEncounter?.Period;
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzzzzzzzzzzzzzzzzzf_);
            CqlDateTime nzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Start(nzzzzzzzzzzzzzzzzzzzzzg_);
            CqlDate nzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.DateFrom(nzzzzzzzzzzzzzzzzzzzzzh_);
            int? nzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.CalculateAgeAt(nzzzzzzzzzzzzzzzzzzzzze_, nzzzzzzzzzzzzzzzzzzzzzi_, "year");
            bool? nzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.GreaterOrEqual(nzzzzzzzzzzzzzzzzzzzzzj_, 18);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzzzzzzzzzzzzzzzzzf_);
            CqlDateTime nzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.End(nzzzzzzzzzzzzzzzzzzzzzm_);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzo_ = this.Measurement_Period(context);
            bool? nzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.In<CqlDateTime>(nzzzzzzzzzzzzzzzzzzzzzn_, nzzzzzzzzzzzzzzzzzzzzzo_, "day");
            bool? nzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.And(nzzzzzzzzzzzzzzzzzzzzzk_, nzzzzzzzzzzzzzzzzzzzzzp_);

            return nzzzzzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Where<Encounter>(mzzzzzzzzzzzzzzzzzzzzzy_, mzzzzzzzzzzzzzzzzzzzzzz_);

        return nzzzzzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Ischemic Stroke Encounter")]
    public IEnumerable<Encounter> Ischemic_Stroke_Encounter(CqlContext context)
    {
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzr_ = this.Non_Elective_Inpatient_Encounter_with_Age(context);
        bool? nzzzzzzzzzzzzzzzzzzzzzs_(Encounter NonElectiveEncounterWithAge)
        {
            Condition nzzzzzzzzzzzzzzzzzzzzzu_ = CQMCommon_2_2_000.Instance.principalDiagnosis(context, NonElectiveEncounterWithAge);
            CodeableConcept nzzzzzzzzzzzzzzzzzzzzzv_ = nzzzzzzzzzzzzzzzzzzzzzu_?.Code;
            CqlConcept nzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, nzzzzzzzzzzzzzzzzzzzzzv_);
            CqlValueSet nzzzzzzzzzzzzzzzzzzzzzx_ = this.Ischemic_Stroke(context);
            bool? nzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.ConceptInValueSet(nzzzzzzzzzzzzzzzzzzzzzw_, nzzzzzzzzzzzzzzzzzzzzzx_);

            return nzzzzzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Where<Encounter>(nzzzzzzzzzzzzzzzzzzzzzr_, nzzzzzzzzzzzzzzzzzzzzzs_);

        return nzzzzzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Ischemic Stroke Encounters with Discharge Disposition")]
    public IEnumerable<Encounter> Ischemic_Stroke_Encounters_with_Discharge_Disposition(CqlContext context)
    {
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzz_ = this.Ischemic_Stroke_Encounter(context);
        bool? ozzzzzzzzzzzzzzzzzzzzza_(Encounter IschemicStrokeEncounter)
        {
            Encounter.HospitalizationComponent ozzzzzzzzzzzzzzzzzzzzzc_ = IschemicStrokeEncounter?.Hospitalization;
            CodeableConcept ozzzzzzzzzzzzzzzzzzzzzd_ = ozzzzzzzzzzzzzzzzzzzzzc_?.DischargeDisposition;
            CqlConcept ozzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ozzzzzzzzzzzzzzzzzzzzzd_);
            CqlValueSet ozzzzzzzzzzzzzzzzzzzzzf_ = this.Discharge_To_Acute_Care_Facility(context);
            bool? ozzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.ConceptInValueSet(ozzzzzzzzzzzzzzzzzzzzze_, ozzzzzzzzzzzzzzzzzzzzzf_);
            CodeableConcept ozzzzzzzzzzzzzzzzzzzzzi_ = ozzzzzzzzzzzzzzzzzzzzzc_?.DischargeDisposition;
            CqlConcept ozzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ozzzzzzzzzzzzzzzzzzzzzi_);
            CqlValueSet ozzzzzzzzzzzzzzzzzzzzzk_ = this.Left_Against_Medical_Advice(context);
            bool? ozzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.ConceptInValueSet(ozzzzzzzzzzzzzzzzzzzzzj_, ozzzzzzzzzzzzzzzzzzzzzk_);
            bool? ozzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Or(ozzzzzzzzzzzzzzzzzzzzzg_, ozzzzzzzzzzzzzzzzzzzzzl_);
            CodeableConcept ozzzzzzzzzzzzzzzzzzzzzo_ = ozzzzzzzzzzzzzzzzzzzzzc_?.DischargeDisposition;
            CqlConcept ozzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ozzzzzzzzzzzzzzzzzzzzzo_);
            CqlValueSet ozzzzzzzzzzzzzzzzzzzzzq_ = this.Patient_Expired(context);
            bool? ozzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.ConceptInValueSet(ozzzzzzzzzzzzzzzzzzzzzp_, ozzzzzzzzzzzzzzzzzzzzzq_);
            bool? ozzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Or(ozzzzzzzzzzzzzzzzzzzzzm_, ozzzzzzzzzzzzzzzzzzzzzr_);
            CodeableConcept ozzzzzzzzzzzzzzzzzzzzzu_ = ozzzzzzzzzzzzzzzzzzzzzc_?.DischargeDisposition;
            CqlConcept ozzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ozzzzzzzzzzzzzzzzzzzzzu_);
            CqlValueSet ozzzzzzzzzzzzzzzzzzzzzw_ = this.Discharged_to_Home_for_Hospice_Care(context);
            bool? ozzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.ConceptInValueSet(ozzzzzzzzzzzzzzzzzzzzzv_, ozzzzzzzzzzzzzzzzzzzzzw_);
            bool? ozzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Or(ozzzzzzzzzzzzzzzzzzzzzs_, ozzzzzzzzzzzzzzzzzzzzzx_);
            CodeableConcept pzzzzzzzzzzzzzzzzzzzzza_ = ozzzzzzzzzzzzzzzzzzzzzc_?.DischargeDisposition;
            CqlConcept pzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, pzzzzzzzzzzzzzzzzzzzzza_);
            CqlValueSet pzzzzzzzzzzzzzzzzzzzzzc_ = this.Discharged_to_Health_Care_Facility_for_Hospice_Care(context);
            bool? pzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.ConceptInValueSet(pzzzzzzzzzzzzzzzzzzzzzb_, pzzzzzzzzzzzzzzzzzzzzzc_);
            bool? pzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Or(ozzzzzzzzzzzzzzzzzzzzzy_, pzzzzzzzzzzzzzzzzzzzzzd_);

            return pzzzzzzzzzzzzzzzzzzzzze_;
        };
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Where<Encounter>(nzzzzzzzzzzzzzzzzzzzzzz_, ozzzzzzzzzzzzzzzzzzzzza_);

        return ozzzzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Intervention Comfort Measures")]
    public IEnumerable<object> Intervention_Comfort_Measures(CqlContext context)
    {
        CqlValueSet pzzzzzzzzzzzzzzzzzzzzzf_ = this.Comfort_Measures(context);
        IEnumerable<ServiceRequest> pzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        bool? pzzzzzzzzzzzzzzzzzzzzzh_(ServiceRequest SR)
        {
            Code<RequestStatus> pzzzzzzzzzzzzzzzzzzzzzo_ = SR?.StatusElement;
            RequestStatus? pzzzzzzzzzzzzzzzzzzzzzp_ = pzzzzzzzzzzzzzzzzzzzzzo_?.Value;
            Code<RequestStatus> pzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Convert<Code<RequestStatus>>(pzzzzzzzzzzzzzzzzzzzzzp_);
            string pzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Convert<string>(pzzzzzzzzzzzzzzzzzzzzzq_);
            string[] pzzzzzzzzzzzzzzzzzzzzzs_ = [
                "active",
                "completed",
                "on-hold",
            ];
            bool? pzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.In<string>(pzzzzzzzzzzzzzzzzzzzzzr_, pzzzzzzzzzzzzzzzzzzzzzs_ as IEnumerable<string>);
            Code<RequestIntent> pzzzzzzzzzzzzzzzzzzzzzu_ = SR?.IntentElement;
            RequestIntent? pzzzzzzzzzzzzzzzzzzzzzv_ = pzzzzzzzzzzzzzzzzzzzzzu_?.Value;
            Code<RequestIntent> pzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Convert<Code<RequestIntent>>(pzzzzzzzzzzzzzzzzzzzzzv_);
            string pzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Convert<string>(pzzzzzzzzzzzzzzzzzzzzzw_);
            string[] pzzzzzzzzzzzzzzzzzzzzzy_ = [
                "order",
                "original-order",
                "reflex-order",
                "filler-order",
                "instance-order",
            ];
            bool? pzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.In<string>(pzzzzzzzzzzzzzzzzzzzzzx_, pzzzzzzzzzzzzzzzzzzzzzy_ as IEnumerable<string>);
            bool? qzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.And(pzzzzzzzzzzzzzzzzzzzzzt_, pzzzzzzzzzzzzzzzzzzzzzz_);
            FhirBoolean qzzzzzzzzzzzzzzzzzzzzzb_ = SR?.DoNotPerformElement;
            bool? qzzzzzzzzzzzzzzzzzzzzzc_ = qzzzzzzzzzzzzzzzzzzzzzb_?.Value;
            bool? qzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.IsTrue(qzzzzzzzzzzzzzzzzzzzzzc_);
            bool? qzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Not(qzzzzzzzzzzzzzzzzzzzzzd_);
            bool? qzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.And(qzzzzzzzzzzzzzzzzzzzzza_, qzzzzzzzzzzzzzzzzzzzzze_);

            return qzzzzzzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<ServiceRequest> pzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<ServiceRequest>(pzzzzzzzzzzzzzzzzzzzzzg_, pzzzzzzzzzzzzzzzzzzzzzh_);
        IEnumerable<Procedure> pzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        bool? pzzzzzzzzzzzzzzzzzzzzzl_(Procedure InterventionPerformed)
        {
            Code<EventStatus> qzzzzzzzzzzzzzzzzzzzzzg_ = InterventionPerformed?.StatusElement;
            EventStatus? qzzzzzzzzzzzzzzzzzzzzzh_ = qzzzzzzzzzzzzzzzzzzzzzg_?.Value;
            string qzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Convert<string>(qzzzzzzzzzzzzzzzzzzzzzh_);
            string[] qzzzzzzzzzzzzzzzzzzzzzj_ = [
                "completed",
                "in-progress",
            ];
            bool? qzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.In<string>(qzzzzzzzzzzzzzzzzzzzzzi_, qzzzzzzzzzzzzzzzzzzzzzj_ as IEnumerable<string>);

            return qzzzzzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<Procedure> pzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Where<Procedure>(pzzzzzzzzzzzzzzzzzzzzzk_, pzzzzzzzzzzzzzzzzzzzzzl_);
        IEnumerable<object> pzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Union<object>(pzzzzzzzzzzzzzzzzzzzzzi_ as IEnumerable<object>, pzzzzzzzzzzzzzzzzzzzzzm_ as IEnumerable<object>);

        return pzzzzzzzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Comfort Measures during Hospitalization")]
    public IEnumerable<Encounter> Comfort_Measures_during_Hospitalization(CqlContext context)
    {
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzl_ = this.Ischemic_Stroke_Encounter(context);
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzm_(Encounter IschemicStrokeEncounter)
        {
            IEnumerable<object> qzzzzzzzzzzzzzzzzzzzzzo_ = this.Intervention_Comfort_Measures(context);
            bool? qzzzzzzzzzzzzzzzzzzzzzp_(object ComfortMeasure)
            {
                object qzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                object qzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzt_);
                CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.toInterval(context, qzzzzzzzzzzzzzzzzzzzzzu_);
                CqlDateTime qzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Start(qzzzzzzzzzzzzzzzzzzzzzv_);
                object qzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "authoredOn");
                CqlDateTime qzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.LateBoundProperty<CqlDateTime>(qzzzzzzzzzzzzzzzzzzzzzx_, "value");
                CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzz_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservation(context, IschemicStrokeEncounter);
                bool? rzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.In<CqlDateTime>(qzzzzzzzzzzzzzzzzzzzzzw_ ?? qzzzzzzzzzzzzzzzzzzzzzy_, qzzzzzzzzzzzzzzzzzzzzzz_, default);

                return rzzzzzzzzzzzzzzzzzzzzza_;
            };
            IEnumerable<object> qzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Where<object>(qzzzzzzzzzzzzzzzzzzzzzo_, qzzzzzzzzzzzzzzzzzzzzzp_);
            Encounter qzzzzzzzzzzzzzzzzzzzzzr_(object ComfortMeasure) =>
                IschemicStrokeEncounter;
            IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Select<object, Encounter>(qzzzzzzzzzzzzzzzzzzzzzq_, qzzzzzzzzzzzzzzzzzzzzzr_);

            return qzzzzzzzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.SelectMany<Encounter, Encounter>(qzzzzzzzzzzzzzzzzzzzzzl_, qzzzzzzzzzzzzzzzzzzzzzm_);

        return qzzzzzzzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Encounter with Comfort Measures during Hospitalization")]
    public IEnumerable<Encounter> Encounter_with_Comfort_Measures_during_Hospitalization(CqlContext context)
    {
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzb_ = this.Ischemic_Stroke_Encounter(context);
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzc_(Encounter IschemicStrokeEncounter)
        {
            IEnumerable<object> rzzzzzzzzzzzzzzzzzzzzze_ = this.Intervention_Comfort_Measures(context);
            bool? rzzzzzzzzzzzzzzzzzzzzzf_(object ComfortMeasure)
            {
                object rzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                object rzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzj_);
                CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.toInterval(context, rzzzzzzzzzzzzzzzzzzzzzk_);
                CqlDateTime rzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Start(rzzzzzzzzzzzzzzzzzzzzzl_);
                object rzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "authoredOn");
                CqlDateTime rzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.LateBoundProperty<CqlDateTime>(rzzzzzzzzzzzzzzzzzzzzzn_, "value");
                CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzp_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservation(context, IschemicStrokeEncounter);
                bool? rzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.In<CqlDateTime>(rzzzzzzzzzzzzzzzzzzzzzm_ ?? rzzzzzzzzzzzzzzzzzzzzzo_, rzzzzzzzzzzzzzzzzzzzzzp_, default);

                return rzzzzzzzzzzzzzzzzzzzzzq_;
            };
            IEnumerable<object> rzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Where<object>(rzzzzzzzzzzzzzzzzzzzzze_, rzzzzzzzzzzzzzzzzzzzzzf_);
            Encounter rzzzzzzzzzzzzzzzzzzzzzh_(object ComfortMeasure) =>
                IschemicStrokeEncounter;
            IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Select<object, Encounter>(rzzzzzzzzzzzzzzzzzzzzzg_, rzzzzzzzzzzzzzzzzzzzzzh_);

            return rzzzzzzzzzzzzzzzzzzzzzi_;
        };
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.SelectMany<Encounter, Encounter>(rzzzzzzzzzzzzzzzzzzzzzb_, rzzzzzzzzzzzzzzzzzzzzzc_);

        return rzzzzzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("CalendarDayOfOrDayAfter")]
    public CqlInterval<CqlDate> CalendarDayOfOrDayAfter(CqlContext context, CqlDateTime StartValue)
    {
        CqlDate rzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.DateFrom(StartValue);
        CqlQuantity rzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Quantity(1m, "day");
        CqlDate rzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Add(rzzzzzzzzzzzzzzzzzzzzzr_, rzzzzzzzzzzzzzzzzzzzzzt_);
        CqlInterval<CqlDate> rzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Interval(rzzzzzzzzzzzzzzzzzzzzzr_, rzzzzzzzzzzzzzzzzzzzzzu_, true, true);

        return rzzzzzzzzzzzzzzzzzzzzzv_;
    }


    #endregion Expressions

}
