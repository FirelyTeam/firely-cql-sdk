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
        object lzzzzzzzzzzzzn_ = context.ResolveParameter("TJCOverall-8.14.000", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)lzzzzzzzzzzzzn_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> lzzzzzzzzzzzzo_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient lzzzzzzzzzzzzp_ = context.Operators.SingletonFrom<Patient>(lzzzzzzzzzzzzo_);

        return lzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Non Elective Inpatient Encounter with Age")]
    public IEnumerable<Encounter> Non_Elective_Inpatient_Encounter_with_Age(CqlContext context)
    {
        CqlValueSet lzzzzzzzzzzzzq_ = this.Nonelective_Inpatient_Encounter(context);
        IEnumerable<Encounter> lzzzzzzzzzzzzr_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, lzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? lzzzzzzzzzzzzs_(Encounter NonElectiveEncounter)
        {
            Patient lzzzzzzzzzzzzu_ = this.Patient(context);
            Date lzzzzzzzzzzzzv_ = lzzzzzzzzzzzzu_?.BirthDateElement;
            string lzzzzzzzzzzzzw_ = lzzzzzzzzzzzzv_?.Value;
            CqlDate lzzzzzzzzzzzzx_ = context.Operators.ConvertStringToDate(lzzzzzzzzzzzzw_);
            Period lzzzzzzzzzzzzy_ = NonElectiveEncounter?.Period;
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzzzzzzzy_);
            CqlDateTime mzzzzzzzzzzzza_ = context.Operators.Start(lzzzzzzzzzzzzz_);
            CqlDate mzzzzzzzzzzzzb_ = context.Operators.DateFrom(mzzzzzzzzzzzza_);
            int? mzzzzzzzzzzzzc_ = context.Operators.CalculateAgeAt(lzzzzzzzzzzzzx_, mzzzzzzzzzzzzb_, "year");
            bool? mzzzzzzzzzzzzd_ = context.Operators.GreaterOrEqual(mzzzzzzzzzzzzc_, 18);
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzzzzzzzy_);
            CqlDateTime mzzzzzzzzzzzzg_ = context.Operators.End(mzzzzzzzzzzzzf_);
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzh_ = this.Measurement_Period(context);
            bool? mzzzzzzzzzzzzi_ = context.Operators.In<CqlDateTime>(mzzzzzzzzzzzzg_, mzzzzzzzzzzzzh_, "day");
            bool? mzzzzzzzzzzzzj_ = context.Operators.And(mzzzzzzzzzzzzd_, mzzzzzzzzzzzzi_);

            return mzzzzzzzzzzzzj_;
        };
        IEnumerable<Encounter> lzzzzzzzzzzzzt_ = context.Operators.Where<Encounter>(lzzzzzzzzzzzzr_, lzzzzzzzzzzzzs_);

        return lzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Ischemic Stroke Encounter")]
    public IEnumerable<Encounter> Ischemic_Stroke_Encounter(CqlContext context)
    {
        IEnumerable<Encounter> mzzzzzzzzzzzzk_ = this.Non_Elective_Inpatient_Encounter_with_Age(context);
        bool? mzzzzzzzzzzzzl_(Encounter NonElectiveEncounterWithAge)
        {
            Condition mzzzzzzzzzzzzn_ = CQMCommon_2_2_000.Instance.principalDiagnosis(context, NonElectiveEncounterWithAge);
            CodeableConcept mzzzzzzzzzzzzo_ = mzzzzzzzzzzzzn_?.Code;
            CqlConcept mzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, mzzzzzzzzzzzzo_);
            CqlValueSet mzzzzzzzzzzzzq_ = this.Ischemic_Stroke(context);
            bool? mzzzzzzzzzzzzr_ = context.Operators.ConceptInValueSet(mzzzzzzzzzzzzp_, mzzzzzzzzzzzzq_);

            return mzzzzzzzzzzzzr_;
        };
        IEnumerable<Encounter> mzzzzzzzzzzzzm_ = context.Operators.Where<Encounter>(mzzzzzzzzzzzzk_, mzzzzzzzzzzzzl_);

        return mzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Ischemic Stroke Encounters with Discharge Disposition")]
    public IEnumerable<Encounter> Ischemic_Stroke_Encounters_with_Discharge_Disposition(CqlContext context)
    {
        IEnumerable<Encounter> mzzzzzzzzzzzzs_ = this.Ischemic_Stroke_Encounter(context);
        bool? mzzzzzzzzzzzzt_(Encounter IschemicStrokeEncounter)
        {
            Encounter.HospitalizationComponent mzzzzzzzzzzzzv_ = IschemicStrokeEncounter?.Hospitalization;
            CodeableConcept mzzzzzzzzzzzzw_ = mzzzzzzzzzzzzv_?.DischargeDisposition;
            CqlConcept mzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, mzzzzzzzzzzzzw_);
            CqlValueSet mzzzzzzzzzzzzy_ = this.Discharge_To_Acute_Care_Facility(context);
            bool? mzzzzzzzzzzzzz_ = context.Operators.ConceptInValueSet(mzzzzzzzzzzzzx_, mzzzzzzzzzzzzy_);
            CodeableConcept nzzzzzzzzzzzzb_ = mzzzzzzzzzzzzv_?.DischargeDisposition;
            CqlConcept nzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, nzzzzzzzzzzzzb_);
            CqlValueSet nzzzzzzzzzzzzd_ = this.Left_Against_Medical_Advice(context);
            bool? nzzzzzzzzzzzze_ = context.Operators.ConceptInValueSet(nzzzzzzzzzzzzc_, nzzzzzzzzzzzzd_);
            bool? nzzzzzzzzzzzzf_ = context.Operators.Or(mzzzzzzzzzzzzz_, nzzzzzzzzzzzze_);
            CodeableConcept nzzzzzzzzzzzzh_ = mzzzzzzzzzzzzv_?.DischargeDisposition;
            CqlConcept nzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, nzzzzzzzzzzzzh_);
            CqlValueSet nzzzzzzzzzzzzj_ = this.Patient_Expired(context);
            bool? nzzzzzzzzzzzzk_ = context.Operators.ConceptInValueSet(nzzzzzzzzzzzzi_, nzzzzzzzzzzzzj_);
            bool? nzzzzzzzzzzzzl_ = context.Operators.Or(nzzzzzzzzzzzzf_, nzzzzzzzzzzzzk_);
            CodeableConcept nzzzzzzzzzzzzn_ = mzzzzzzzzzzzzv_?.DischargeDisposition;
            CqlConcept nzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, nzzzzzzzzzzzzn_);
            CqlValueSet nzzzzzzzzzzzzp_ = this.Discharged_to_Home_for_Hospice_Care(context);
            bool? nzzzzzzzzzzzzq_ = context.Operators.ConceptInValueSet(nzzzzzzzzzzzzo_, nzzzzzzzzzzzzp_);
            bool? nzzzzzzzzzzzzr_ = context.Operators.Or(nzzzzzzzzzzzzl_, nzzzzzzzzzzzzq_);
            CodeableConcept nzzzzzzzzzzzzt_ = mzzzzzzzzzzzzv_?.DischargeDisposition;
            CqlConcept nzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, nzzzzzzzzzzzzt_);
            CqlValueSet nzzzzzzzzzzzzv_ = this.Discharged_to_Health_Care_Facility_for_Hospice_Care(context);
            bool? nzzzzzzzzzzzzw_ = context.Operators.ConceptInValueSet(nzzzzzzzzzzzzu_, nzzzzzzzzzzzzv_);
            bool? nzzzzzzzzzzzzx_ = context.Operators.Or(nzzzzzzzzzzzzr_, nzzzzzzzzzzzzw_);

            return nzzzzzzzzzzzzx_;
        };
        IEnumerable<Encounter> mzzzzzzzzzzzzu_ = context.Operators.Where<Encounter>(mzzzzzzzzzzzzs_, mzzzzzzzzzzzzt_);

        return mzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Intervention Comfort Measures")]
    public IEnumerable<object> Intervention_Comfort_Measures(CqlContext context)
    {
        CqlValueSet nzzzzzzzzzzzzy_ = this.Comfort_Measures(context);
        IEnumerable<ServiceRequest> nzzzzzzzzzzzzz_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, nzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        bool? ozzzzzzzzzzzza_(ServiceRequest SR)
        {
            Code<RequestStatus> ozzzzzzzzzzzzh_ = SR?.StatusElement;
            RequestStatus? ozzzzzzzzzzzzi_ = ozzzzzzzzzzzzh_?.Value;
            Code<RequestStatus> ozzzzzzzzzzzzj_ = context.Operators.Convert<Code<RequestStatus>>(ozzzzzzzzzzzzi_);
            string ozzzzzzzzzzzzk_ = context.Operators.Convert<string>(ozzzzzzzzzzzzj_);
            string[] ozzzzzzzzzzzzl_ = [
                "active",
                "completed",
                "on-hold",
            ];
            bool? ozzzzzzzzzzzzm_ = context.Operators.In<string>(ozzzzzzzzzzzzk_, ozzzzzzzzzzzzl_ as IEnumerable<string>);
            Code<RequestIntent> ozzzzzzzzzzzzn_ = SR?.IntentElement;
            RequestIntent? ozzzzzzzzzzzzo_ = ozzzzzzzzzzzzn_?.Value;
            Code<RequestIntent> ozzzzzzzzzzzzp_ = context.Operators.Convert<Code<RequestIntent>>(ozzzzzzzzzzzzo_);
            string ozzzzzzzzzzzzq_ = context.Operators.Convert<string>(ozzzzzzzzzzzzp_);
            string[] ozzzzzzzzzzzzr_ = [
                "order",
                "original-order",
                "reflex-order",
                "filler-order",
                "instance-order",
            ];
            bool? ozzzzzzzzzzzzs_ = context.Operators.In<string>(ozzzzzzzzzzzzq_, ozzzzzzzzzzzzr_ as IEnumerable<string>);
            bool? ozzzzzzzzzzzzt_ = context.Operators.And(ozzzzzzzzzzzzm_, ozzzzzzzzzzzzs_);
            FhirBoolean ozzzzzzzzzzzzu_ = SR?.DoNotPerformElement;
            bool? ozzzzzzzzzzzzv_ = ozzzzzzzzzzzzu_?.Value;
            bool? ozzzzzzzzzzzzw_ = context.Operators.IsTrue(ozzzzzzzzzzzzv_);
            bool? ozzzzzzzzzzzzx_ = context.Operators.Not(ozzzzzzzzzzzzw_);
            bool? ozzzzzzzzzzzzy_ = context.Operators.And(ozzzzzzzzzzzzt_, ozzzzzzzzzzzzx_);

            return ozzzzzzzzzzzzy_;
        };
        IEnumerable<ServiceRequest> ozzzzzzzzzzzzb_ = context.Operators.Where<ServiceRequest>(nzzzzzzzzzzzzz_, ozzzzzzzzzzzza_);
        IEnumerable<Procedure> ozzzzzzzzzzzzd_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, nzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        bool? ozzzzzzzzzzzze_(Procedure InterventionPerformed)
        {
            Code<EventStatus> ozzzzzzzzzzzzz_ = InterventionPerformed?.StatusElement;
            EventStatus? pzzzzzzzzzzzza_ = ozzzzzzzzzzzzz_?.Value;
            string pzzzzzzzzzzzzb_ = context.Operators.Convert<string>(pzzzzzzzzzzzza_);
            string[] pzzzzzzzzzzzzc_ = [
                "completed",
                "in-progress",
            ];
            bool? pzzzzzzzzzzzzd_ = context.Operators.In<string>(pzzzzzzzzzzzzb_, pzzzzzzzzzzzzc_ as IEnumerable<string>);

            return pzzzzzzzzzzzzd_;
        };
        IEnumerable<Procedure> ozzzzzzzzzzzzf_ = context.Operators.Where<Procedure>(ozzzzzzzzzzzzd_, ozzzzzzzzzzzze_);
        IEnumerable<object> ozzzzzzzzzzzzg_ = context.Operators.Union<object>(ozzzzzzzzzzzzb_ as IEnumerable<object>, ozzzzzzzzzzzzf_ as IEnumerable<object>);

        return ozzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Comfort Measures during Hospitalization")]
    public IEnumerable<Encounter> Comfort_Measures_during_Hospitalization(CqlContext context)
    {
        IEnumerable<Encounter> pzzzzzzzzzzzze_ = this.Ischemic_Stroke_Encounter(context);
        IEnumerable<Encounter> pzzzzzzzzzzzzf_(Encounter IschemicStrokeEncounter)
        {
            IEnumerable<object> pzzzzzzzzzzzzh_ = this.Intervention_Comfort_Measures(context);
            bool? pzzzzzzzzzzzzi_(object ComfortMeasure)
            {
                object pzzzzzzzzzzzzm_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                object pzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzm_);
                CqlInterval<CqlDateTime> pzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.toInterval(context, pzzzzzzzzzzzzn_);
                CqlDateTime pzzzzzzzzzzzzp_ = context.Operators.Start(pzzzzzzzzzzzzo_);
                object pzzzzzzzzzzzzq_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "authoredOn");
                CqlDateTime pzzzzzzzzzzzzr_ = context.Operators.LateBoundProperty<CqlDateTime>(pzzzzzzzzzzzzq_, "value");
                CqlInterval<CqlDateTime> pzzzzzzzzzzzzs_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservation(context, IschemicStrokeEncounter);
                bool? pzzzzzzzzzzzzt_ = context.Operators.In<CqlDateTime>(pzzzzzzzzzzzzp_ ?? pzzzzzzzzzzzzr_, pzzzzzzzzzzzzs_, default);

                return pzzzzzzzzzzzzt_;
            };
            IEnumerable<object> pzzzzzzzzzzzzj_ = context.Operators.Where<object>(pzzzzzzzzzzzzh_, pzzzzzzzzzzzzi_);
            Encounter pzzzzzzzzzzzzk_(object ComfortMeasure) =>
                IschemicStrokeEncounter;
            IEnumerable<Encounter> pzzzzzzzzzzzzl_ = context.Operators.Select<object, Encounter>(pzzzzzzzzzzzzj_, pzzzzzzzzzzzzk_);

            return pzzzzzzzzzzzzl_;
        };
        IEnumerable<Encounter> pzzzzzzzzzzzzg_ = context.Operators.SelectMany<Encounter, Encounter>(pzzzzzzzzzzzze_, pzzzzzzzzzzzzf_);

        return pzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Encounter with Comfort Measures during Hospitalization")]
    public IEnumerable<Encounter> Encounter_with_Comfort_Measures_during_Hospitalization(CqlContext context)
    {
        IEnumerable<Encounter> pzzzzzzzzzzzzu_ = this.Ischemic_Stroke_Encounter(context);
        IEnumerable<Encounter> pzzzzzzzzzzzzv_(Encounter IschemicStrokeEncounter)
        {
            IEnumerable<object> pzzzzzzzzzzzzx_ = this.Intervention_Comfort_Measures(context);
            bool? pzzzzzzzzzzzzy_(object ComfortMeasure)
            {
                object qzzzzzzzzzzzzc_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                object qzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzc_);
                CqlInterval<CqlDateTime> qzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.toInterval(context, qzzzzzzzzzzzzd_);
                CqlDateTime qzzzzzzzzzzzzf_ = context.Operators.Start(qzzzzzzzzzzzze_);
                object qzzzzzzzzzzzzg_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "authoredOn");
                CqlDateTime qzzzzzzzzzzzzh_ = context.Operators.LateBoundProperty<CqlDateTime>(qzzzzzzzzzzzzg_, "value");
                CqlInterval<CqlDateTime> qzzzzzzzzzzzzi_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservation(context, IschemicStrokeEncounter);
                bool? qzzzzzzzzzzzzj_ = context.Operators.In<CqlDateTime>(qzzzzzzzzzzzzf_ ?? qzzzzzzzzzzzzh_, qzzzzzzzzzzzzi_, default);

                return qzzzzzzzzzzzzj_;
            };
            IEnumerable<object> pzzzzzzzzzzzzz_ = context.Operators.Where<object>(pzzzzzzzzzzzzx_, pzzzzzzzzzzzzy_);
            Encounter qzzzzzzzzzzzza_(object ComfortMeasure) =>
                IschemicStrokeEncounter;
            IEnumerable<Encounter> qzzzzzzzzzzzzb_ = context.Operators.Select<object, Encounter>(pzzzzzzzzzzzzz_, qzzzzzzzzzzzza_);

            return qzzzzzzzzzzzzb_;
        };
        IEnumerable<Encounter> pzzzzzzzzzzzzw_ = context.Operators.SelectMany<Encounter, Encounter>(pzzzzzzzzzzzzu_, pzzzzzzzzzzzzv_);

        return pzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("CalendarDayOfOrDayAfter")]
    public CqlInterval<CqlDate> CalendarDayOfOrDayAfter(CqlContext context, CqlDateTime StartValue)
    {
        CqlDate qzzzzzzzzzzzzk_ = context.Operators.DateFrom(StartValue);
        CqlQuantity qzzzzzzzzzzzzm_ = context.Operators.Quantity(1m, "day");
        CqlDate qzzzzzzzzzzzzn_ = context.Operators.Add(qzzzzzzzzzzzzk_, qzzzzzzzzzzzzm_);
        CqlInterval<CqlDate> qzzzzzzzzzzzzo_ = context.Operators.Interval(qzzzzzzzzzzzzk_, qzzzzzzzzzzzzn_, true, true);

        return qzzzzzzzzzzzzo_;
    }


    #endregion Expressions

}
