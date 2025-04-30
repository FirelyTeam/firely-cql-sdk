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
        object zzzzzzzzzzzzw_ = context.ResolveParameter("TJCOverall-8.14.000", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)zzzzzzzzzzzzw_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> zzzzzzzzzzzzx_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient zzzzzzzzzzzzy_ = context.Operators.SingletonFrom<Patient>(zzzzzzzzzzzzx_);

        return zzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Non Elective Inpatient Encounter with Age")]
    public IEnumerable<Encounter> Non_Elective_Inpatient_Encounter_with_Age(CqlContext context)
    {
        CqlValueSet zzzzzzzzzzzzz_ = this.Nonelective_Inpatient_Encounter(context);
        IEnumerable<Encounter> azzzzzzzzzzzza_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, zzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? azzzzzzzzzzzzb_(Encounter NonElectiveEncounter)
        {
            Patient azzzzzzzzzzzzd_ = this.Patient(context);
            Date azzzzzzzzzzzze_ = azzzzzzzzzzzzd_?.BirthDateElement;
            string azzzzzzzzzzzzf_ = azzzzzzzzzzzze_?.Value;
            CqlDate azzzzzzzzzzzzg_ = context.Operators.ConvertStringToDate(azzzzzzzzzzzzf_);
            Period azzzzzzzzzzzzh_ = NonElectiveEncounter?.Period;
            CqlInterval<CqlDateTime> azzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzzzzzzh_);
            CqlDateTime azzzzzzzzzzzzj_ = context.Operators.Start(azzzzzzzzzzzzi_);
            CqlDate azzzzzzzzzzzzk_ = context.Operators.DateFrom(azzzzzzzzzzzzj_);
            int? azzzzzzzzzzzzl_ = context.Operators.CalculateAgeAt(azzzzzzzzzzzzg_, azzzzzzzzzzzzk_, "year");
            bool? azzzzzzzzzzzzm_ = context.Operators.GreaterOrEqual(azzzzzzzzzzzzl_, 18);
            CqlInterval<CqlDateTime> azzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzzzzzzh_);
            CqlDateTime azzzzzzzzzzzzp_ = context.Operators.End(azzzzzzzzzzzzo_);
            CqlInterval<CqlDateTime> azzzzzzzzzzzzq_ = this.Measurement_Period(context);
            bool? azzzzzzzzzzzzr_ = context.Operators.In<CqlDateTime>(azzzzzzzzzzzzp_, azzzzzzzzzzzzq_, "day");
            bool? azzzzzzzzzzzzs_ = context.Operators.And(azzzzzzzzzzzzm_, azzzzzzzzzzzzr_);

            return azzzzzzzzzzzzs_;
        };
        IEnumerable<Encounter> azzzzzzzzzzzzc_ = context.Operators.Where<Encounter>(azzzzzzzzzzzza_, azzzzzzzzzzzzb_);

        return azzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Ischemic Stroke Encounter")]
    public IEnumerable<Encounter> Ischemic_Stroke_Encounter(CqlContext context)
    {
        IEnumerable<Encounter> azzzzzzzzzzzzt_ = this.Non_Elective_Inpatient_Encounter_with_Age(context);
        bool? azzzzzzzzzzzzu_(Encounter NonElectiveEncounterWithAge)
        {
            Condition azzzzzzzzzzzzw_ = CQMCommon_2_2_000.Instance.principalDiagnosis(context, NonElectiveEncounterWithAge);
            CodeableConcept azzzzzzzzzzzzx_ = azzzzzzzzzzzzw_?.Code;
            CqlConcept azzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, azzzzzzzzzzzzx_);
            CqlValueSet azzzzzzzzzzzzz_ = this.Ischemic_Stroke(context);
            bool? bzzzzzzzzzzzza_ = context.Operators.ConceptInValueSet(azzzzzzzzzzzzy_, azzzzzzzzzzzzz_);

            return bzzzzzzzzzzzza_;
        };
        IEnumerable<Encounter> azzzzzzzzzzzzv_ = context.Operators.Where<Encounter>(azzzzzzzzzzzzt_, azzzzzzzzzzzzu_);

        return azzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Ischemic Stroke Encounters with Discharge Disposition")]
    public IEnumerable<Encounter> Ischemic_Stroke_Encounters_with_Discharge_Disposition(CqlContext context)
    {
        IEnumerable<Encounter> bzzzzzzzzzzzzb_ = this.Ischemic_Stroke_Encounter(context);
        bool? bzzzzzzzzzzzzc_(Encounter IschemicStrokeEncounter)
        {
            Encounter.HospitalizationComponent bzzzzzzzzzzzze_ = IschemicStrokeEncounter?.Hospitalization;
            CodeableConcept bzzzzzzzzzzzzf_ = bzzzzzzzzzzzze_?.DischargeDisposition;
            CqlConcept bzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bzzzzzzzzzzzzf_);
            CqlValueSet bzzzzzzzzzzzzh_ = this.Discharge_To_Acute_Care_Facility(context);
            bool? bzzzzzzzzzzzzi_ = context.Operators.ConceptInValueSet(bzzzzzzzzzzzzg_, bzzzzzzzzzzzzh_);
            CodeableConcept bzzzzzzzzzzzzk_ = bzzzzzzzzzzzze_?.DischargeDisposition;
            CqlConcept bzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bzzzzzzzzzzzzk_);
            CqlValueSet bzzzzzzzzzzzzm_ = this.Left_Against_Medical_Advice(context);
            bool? bzzzzzzzzzzzzn_ = context.Operators.ConceptInValueSet(bzzzzzzzzzzzzl_, bzzzzzzzzzzzzm_);
            bool? bzzzzzzzzzzzzo_ = context.Operators.Or(bzzzzzzzzzzzzi_, bzzzzzzzzzzzzn_);
            CodeableConcept bzzzzzzzzzzzzq_ = bzzzzzzzzzzzze_?.DischargeDisposition;
            CqlConcept bzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bzzzzzzzzzzzzq_);
            CqlValueSet bzzzzzzzzzzzzs_ = this.Patient_Expired(context);
            bool? bzzzzzzzzzzzzt_ = context.Operators.ConceptInValueSet(bzzzzzzzzzzzzr_, bzzzzzzzzzzzzs_);
            bool? bzzzzzzzzzzzzu_ = context.Operators.Or(bzzzzzzzzzzzzo_, bzzzzzzzzzzzzt_);
            CodeableConcept bzzzzzzzzzzzzw_ = bzzzzzzzzzzzze_?.DischargeDisposition;
            CqlConcept bzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bzzzzzzzzzzzzw_);
            CqlValueSet bzzzzzzzzzzzzy_ = this.Discharged_to_Home_for_Hospice_Care(context);
            bool? bzzzzzzzzzzzzz_ = context.Operators.ConceptInValueSet(bzzzzzzzzzzzzx_, bzzzzzzzzzzzzy_);
            bool? czzzzzzzzzzzza_ = context.Operators.Or(bzzzzzzzzzzzzu_, bzzzzzzzzzzzzz_);
            CodeableConcept czzzzzzzzzzzzc_ = bzzzzzzzzzzzze_?.DischargeDisposition;
            CqlConcept czzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, czzzzzzzzzzzzc_);
            CqlValueSet czzzzzzzzzzzze_ = this.Discharged_to_Health_Care_Facility_for_Hospice_Care(context);
            bool? czzzzzzzzzzzzf_ = context.Operators.ConceptInValueSet(czzzzzzzzzzzzd_, czzzzzzzzzzzze_);
            bool? czzzzzzzzzzzzg_ = context.Operators.Or(czzzzzzzzzzzza_, czzzzzzzzzzzzf_);

            return czzzzzzzzzzzzg_;
        };
        IEnumerable<Encounter> bzzzzzzzzzzzzd_ = context.Operators.Where<Encounter>(bzzzzzzzzzzzzb_, bzzzzzzzzzzzzc_);

        return bzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Intervention Comfort Measures")]
    public IEnumerable<object> Intervention_Comfort_Measures(CqlContext context)
    {
        CqlValueSet czzzzzzzzzzzzh_ = this.Comfort_Measures(context);
        IEnumerable<ServiceRequest> czzzzzzzzzzzzi_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, czzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        bool? czzzzzzzzzzzzj_(ServiceRequest SR)
        {
            Code<RequestStatus> czzzzzzzzzzzzq_ = SR?.StatusElement;
            RequestStatus? czzzzzzzzzzzzr_ = czzzzzzzzzzzzq_?.Value;
            Code<RequestStatus> czzzzzzzzzzzzs_ = context.Operators.Convert<Code<RequestStatus>>(czzzzzzzzzzzzr_);
            string czzzzzzzzzzzzt_ = context.Operators.Convert<string>(czzzzzzzzzzzzs_);
            string[] czzzzzzzzzzzzu_ = [
                "active",
                "completed",
                "on-hold",
            ];
            bool? czzzzzzzzzzzzv_ = context.Operators.In<string>(czzzzzzzzzzzzt_, czzzzzzzzzzzzu_ as IEnumerable<string>);
            Code<RequestIntent> czzzzzzzzzzzzw_ = SR?.IntentElement;
            RequestIntent? czzzzzzzzzzzzx_ = czzzzzzzzzzzzw_?.Value;
            Code<RequestIntent> czzzzzzzzzzzzy_ = context.Operators.Convert<Code<RequestIntent>>(czzzzzzzzzzzzx_);
            string czzzzzzzzzzzzz_ = context.Operators.Convert<string>(czzzzzzzzzzzzy_);
            string[] dzzzzzzzzzzzza_ = [
                "order",
                "original-order",
                "reflex-order",
                "filler-order",
                "instance-order",
            ];
            bool? dzzzzzzzzzzzzb_ = context.Operators.In<string>(czzzzzzzzzzzzz_, dzzzzzzzzzzzza_ as IEnumerable<string>);
            bool? dzzzzzzzzzzzzc_ = context.Operators.And(czzzzzzzzzzzzv_, dzzzzzzzzzzzzb_);
            FhirBoolean dzzzzzzzzzzzzd_ = SR?.DoNotPerformElement;
            bool? dzzzzzzzzzzzze_ = dzzzzzzzzzzzzd_?.Value;
            bool? dzzzzzzzzzzzzf_ = context.Operators.IsTrue(dzzzzzzzzzzzze_);
            bool? dzzzzzzzzzzzzg_ = context.Operators.Not(dzzzzzzzzzzzzf_);
            bool? dzzzzzzzzzzzzh_ = context.Operators.And(dzzzzzzzzzzzzc_, dzzzzzzzzzzzzg_);

            return dzzzzzzzzzzzzh_;
        };
        IEnumerable<ServiceRequest> czzzzzzzzzzzzk_ = context.Operators.Where<ServiceRequest>(czzzzzzzzzzzzi_, czzzzzzzzzzzzj_);
        IEnumerable<Procedure> czzzzzzzzzzzzm_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, czzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        bool? czzzzzzzzzzzzn_(Procedure InterventionPerformed)
        {
            Code<EventStatus> dzzzzzzzzzzzzi_ = InterventionPerformed?.StatusElement;
            EventStatus? dzzzzzzzzzzzzj_ = dzzzzzzzzzzzzi_?.Value;
            string dzzzzzzzzzzzzk_ = context.Operators.Convert<string>(dzzzzzzzzzzzzj_);
            string[] dzzzzzzzzzzzzl_ = [
                "completed",
                "in-progress",
            ];
            bool? dzzzzzzzzzzzzm_ = context.Operators.In<string>(dzzzzzzzzzzzzk_, dzzzzzzzzzzzzl_ as IEnumerable<string>);

            return dzzzzzzzzzzzzm_;
        };
        IEnumerable<Procedure> czzzzzzzzzzzzo_ = context.Operators.Where<Procedure>(czzzzzzzzzzzzm_, czzzzzzzzzzzzn_);
        IEnumerable<object> czzzzzzzzzzzzp_ = context.Operators.Union<object>(czzzzzzzzzzzzk_ as IEnumerable<object>, czzzzzzzzzzzzo_ as IEnumerable<object>);

        return czzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Comfort Measures during Hospitalization")]
    public IEnumerable<Encounter> Comfort_Measures_during_Hospitalization(CqlContext context)
    {
        IEnumerable<Encounter> dzzzzzzzzzzzzn_ = this.Ischemic_Stroke_Encounter(context);
        IEnumerable<Encounter> dzzzzzzzzzzzzo_(Encounter IschemicStrokeEncounter)
        {
            IEnumerable<object> dzzzzzzzzzzzzq_ = this.Intervention_Comfort_Measures(context);
            bool? dzzzzzzzzzzzzr_(object ComfortMeasure)
            {
                object dzzzzzzzzzzzzv_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                object dzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzv_);
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.toInterval(context, dzzzzzzzzzzzzw_);
                CqlDateTime dzzzzzzzzzzzzy_ = context.Operators.Start(dzzzzzzzzzzzzx_);
                object dzzzzzzzzzzzzz_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "authoredOn");
                CqlDateTime ezzzzzzzzzzzza_ = context.Operators.LateBoundProperty<CqlDateTime>(dzzzzzzzzzzzzz_, "value");
                CqlInterval<CqlDateTime> ezzzzzzzzzzzzb_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservation(context, IschemicStrokeEncounter);
                bool? ezzzzzzzzzzzzc_ = context.Operators.In<CqlDateTime>(dzzzzzzzzzzzzy_ ?? ezzzzzzzzzzzza_, ezzzzzzzzzzzzb_, default);

                return ezzzzzzzzzzzzc_;
            };
            IEnumerable<object> dzzzzzzzzzzzzs_ = context.Operators.Where<object>(dzzzzzzzzzzzzq_, dzzzzzzzzzzzzr_);
            Encounter dzzzzzzzzzzzzt_(object ComfortMeasure) =>
                IschemicStrokeEncounter;
            IEnumerable<Encounter> dzzzzzzzzzzzzu_ = context.Operators.Select<object, Encounter>(dzzzzzzzzzzzzs_, dzzzzzzzzzzzzt_);

            return dzzzzzzzzzzzzu_;
        };
        IEnumerable<Encounter> dzzzzzzzzzzzzp_ = context.Operators.SelectMany<Encounter, Encounter>(dzzzzzzzzzzzzn_, dzzzzzzzzzzzzo_);

        return dzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Encounter with Comfort Measures during Hospitalization")]
    public IEnumerable<Encounter> Encounter_with_Comfort_Measures_during_Hospitalization(CqlContext context)
    {
        IEnumerable<Encounter> ezzzzzzzzzzzzd_ = this.Ischemic_Stroke_Encounter(context);
        IEnumerable<Encounter> ezzzzzzzzzzzze_(Encounter IschemicStrokeEncounter)
        {
            IEnumerable<object> ezzzzzzzzzzzzg_ = this.Intervention_Comfort_Measures(context);
            bool? ezzzzzzzzzzzzh_(object ComfortMeasure)
            {
                object ezzzzzzzzzzzzl_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                object ezzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzl_);
                CqlInterval<CqlDateTime> ezzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.toInterval(context, ezzzzzzzzzzzzm_);
                CqlDateTime ezzzzzzzzzzzzo_ = context.Operators.Start(ezzzzzzzzzzzzn_);
                object ezzzzzzzzzzzzp_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "authoredOn");
                CqlDateTime ezzzzzzzzzzzzq_ = context.Operators.LateBoundProperty<CqlDateTime>(ezzzzzzzzzzzzp_, "value");
                CqlInterval<CqlDateTime> ezzzzzzzzzzzzr_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservation(context, IschemicStrokeEncounter);
                bool? ezzzzzzzzzzzzs_ = context.Operators.In<CqlDateTime>(ezzzzzzzzzzzzo_ ?? ezzzzzzzzzzzzq_, ezzzzzzzzzzzzr_, default);

                return ezzzzzzzzzzzzs_;
            };
            IEnumerable<object> ezzzzzzzzzzzzi_ = context.Operators.Where<object>(ezzzzzzzzzzzzg_, ezzzzzzzzzzzzh_);
            Encounter ezzzzzzzzzzzzj_(object ComfortMeasure) =>
                IschemicStrokeEncounter;
            IEnumerable<Encounter> ezzzzzzzzzzzzk_ = context.Operators.Select<object, Encounter>(ezzzzzzzzzzzzi_, ezzzzzzzzzzzzj_);

            return ezzzzzzzzzzzzk_;
        };
        IEnumerable<Encounter> ezzzzzzzzzzzzf_ = context.Operators.SelectMany<Encounter, Encounter>(ezzzzzzzzzzzzd_, ezzzzzzzzzzzze_);

        return ezzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("CalendarDayOfOrDayAfter")]
    public CqlInterval<CqlDate> CalendarDayOfOrDayAfter(CqlContext context, CqlDateTime StartValue)
    {
        CqlDate ezzzzzzzzzzzzt_ = context.Operators.DateFrom(StartValue);
        CqlQuantity ezzzzzzzzzzzzv_ = context.Operators.Quantity(1m, "day");
        CqlDate ezzzzzzzzzzzzw_ = context.Operators.Add(ezzzzzzzzzzzzt_, ezzzzzzzzzzzzv_);
        CqlInterval<CqlDate> ezzzzzzzzzzzzx_ = context.Operators.Interval(ezzzzzzzzzzzzt_, ezzzzzzzzzzzzw_, true, true);

        return ezzzzzzzzzzzzx_;
    }


    #endregion Expressions

}
