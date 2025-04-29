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
        object dzzzzzzzzzzzzr_ = context.ResolveParameter("TJCOverall-8.14.000", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)dzzzzzzzzzzzzr_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> dzzzzzzzzzzzzs_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient dzzzzzzzzzzzzt_ = context.Operators.SingletonFrom<Patient>(dzzzzzzzzzzzzs_);

        return dzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Non Elective Inpatient Encounter with Age")]
    public IEnumerable<Encounter> Non_Elective_Inpatient_Encounter_with_Age(CqlContext context)
    {
        CqlValueSet dzzzzzzzzzzzzu_ = this.Nonelective_Inpatient_Encounter(context);
        IEnumerable<Encounter> dzzzzzzzzzzzzv_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, dzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? dzzzzzzzzzzzzw_(Encounter NonElectiveEncounter)
        {
            Patient dzzzzzzzzzzzzy_ = this.Patient(context);
            Date dzzzzzzzzzzzzz_ = dzzzzzzzzzzzzy_?.BirthDateElement;
            string ezzzzzzzzzzzza_ = dzzzzzzzzzzzzz_?.Value;
            CqlDate ezzzzzzzzzzzzb_ = context.Operators.ConvertStringToDate(ezzzzzzzzzzzza_);
            Period ezzzzzzzzzzzzc_ = NonElectiveEncounter?.Period;
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzzzzzzzzc_);
            CqlDateTime ezzzzzzzzzzzze_ = context.Operators.Start(ezzzzzzzzzzzzd_);
            CqlDate ezzzzzzzzzzzzf_ = context.Operators.DateFrom(ezzzzzzzzzzzze_);
            int? ezzzzzzzzzzzzg_ = context.Operators.CalculateAgeAt(ezzzzzzzzzzzzb_, ezzzzzzzzzzzzf_, "year");
            bool? ezzzzzzzzzzzzh_ = context.Operators.GreaterOrEqual(ezzzzzzzzzzzzg_, 18);
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzzzzzzzzc_);
            CqlDateTime ezzzzzzzzzzzzk_ = context.Operators.End(ezzzzzzzzzzzzj_);
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzl_ = this.Measurement_Period(context);
            bool? ezzzzzzzzzzzzm_ = context.Operators.In<CqlDateTime>(ezzzzzzzzzzzzk_, ezzzzzzzzzzzzl_, "day");
            bool? ezzzzzzzzzzzzn_ = context.Operators.And(ezzzzzzzzzzzzh_, ezzzzzzzzzzzzm_);

            return ezzzzzzzzzzzzn_;
        };
        IEnumerable<Encounter> dzzzzzzzzzzzzx_ = context.Operators.Where<Encounter>(dzzzzzzzzzzzzv_, dzzzzzzzzzzzzw_);

        return dzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Ischemic Stroke Encounter")]
    public IEnumerable<Encounter> Ischemic_Stroke_Encounter(CqlContext context)
    {
        IEnumerable<Encounter> ezzzzzzzzzzzzo_ = this.Non_Elective_Inpatient_Encounter_with_Age(context);
        bool? ezzzzzzzzzzzzp_(Encounter NonElectiveEncounterWithAge)
        {
            Condition ezzzzzzzzzzzzr_ = CQMCommon_2_2_000.Instance.principalDiagnosis(context, NonElectiveEncounterWithAge);
            CodeableConcept ezzzzzzzzzzzzs_ = ezzzzzzzzzzzzr_?.Code;
            CqlConcept ezzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ezzzzzzzzzzzzs_);
            CqlValueSet ezzzzzzzzzzzzu_ = this.Ischemic_Stroke(context);
            bool? ezzzzzzzzzzzzv_ = context.Operators.ConceptInValueSet(ezzzzzzzzzzzzt_, ezzzzzzzzzzzzu_);

            return ezzzzzzzzzzzzv_;
        };
        IEnumerable<Encounter> ezzzzzzzzzzzzq_ = context.Operators.Where<Encounter>(ezzzzzzzzzzzzo_, ezzzzzzzzzzzzp_);

        return ezzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Ischemic Stroke Encounters with Discharge Disposition")]
    public IEnumerable<Encounter> Ischemic_Stroke_Encounters_with_Discharge_Disposition(CqlContext context)
    {
        IEnumerable<Encounter> ezzzzzzzzzzzzw_ = this.Ischemic_Stroke_Encounter(context);
        bool? ezzzzzzzzzzzzx_(Encounter IschemicStrokeEncounter)
        {
            Encounter.HospitalizationComponent ezzzzzzzzzzzzz_ = IschemicStrokeEncounter?.Hospitalization;
            CodeableConcept fzzzzzzzzzzzza_ = ezzzzzzzzzzzzz_?.DischargeDisposition;
            CqlConcept fzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, fzzzzzzzzzzzza_);
            CqlValueSet fzzzzzzzzzzzzc_ = this.Discharge_To_Acute_Care_Facility(context);
            bool? fzzzzzzzzzzzzd_ = context.Operators.ConceptInValueSet(fzzzzzzzzzzzzb_, fzzzzzzzzzzzzc_);
            CodeableConcept fzzzzzzzzzzzzf_ = ezzzzzzzzzzzzz_?.DischargeDisposition;
            CqlConcept fzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, fzzzzzzzzzzzzf_);
            CqlValueSet fzzzzzzzzzzzzh_ = this.Left_Against_Medical_Advice(context);
            bool? fzzzzzzzzzzzzi_ = context.Operators.ConceptInValueSet(fzzzzzzzzzzzzg_, fzzzzzzzzzzzzh_);
            bool? fzzzzzzzzzzzzj_ = context.Operators.Or(fzzzzzzzzzzzzd_, fzzzzzzzzzzzzi_);
            CodeableConcept fzzzzzzzzzzzzl_ = ezzzzzzzzzzzzz_?.DischargeDisposition;
            CqlConcept fzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, fzzzzzzzzzzzzl_);
            CqlValueSet fzzzzzzzzzzzzn_ = this.Patient_Expired(context);
            bool? fzzzzzzzzzzzzo_ = context.Operators.ConceptInValueSet(fzzzzzzzzzzzzm_, fzzzzzzzzzzzzn_);
            bool? fzzzzzzzzzzzzp_ = context.Operators.Or(fzzzzzzzzzzzzj_, fzzzzzzzzzzzzo_);
            CodeableConcept fzzzzzzzzzzzzr_ = ezzzzzzzzzzzzz_?.DischargeDisposition;
            CqlConcept fzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, fzzzzzzzzzzzzr_);
            CqlValueSet fzzzzzzzzzzzzt_ = this.Discharged_to_Home_for_Hospice_Care(context);
            bool? fzzzzzzzzzzzzu_ = context.Operators.ConceptInValueSet(fzzzzzzzzzzzzs_, fzzzzzzzzzzzzt_);
            bool? fzzzzzzzzzzzzv_ = context.Operators.Or(fzzzzzzzzzzzzp_, fzzzzzzzzzzzzu_);
            CodeableConcept fzzzzzzzzzzzzx_ = ezzzzzzzzzzzzz_?.DischargeDisposition;
            CqlConcept fzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, fzzzzzzzzzzzzx_);
            CqlValueSet fzzzzzzzzzzzzz_ = this.Discharged_to_Health_Care_Facility_for_Hospice_Care(context);
            bool? gzzzzzzzzzzzza_ = context.Operators.ConceptInValueSet(fzzzzzzzzzzzzy_, fzzzzzzzzzzzzz_);
            bool? gzzzzzzzzzzzzb_ = context.Operators.Or(fzzzzzzzzzzzzv_, gzzzzzzzzzzzza_);

            return gzzzzzzzzzzzzb_;
        };
        IEnumerable<Encounter> ezzzzzzzzzzzzy_ = context.Operators.Where<Encounter>(ezzzzzzzzzzzzw_, ezzzzzzzzzzzzx_);

        return ezzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Intervention Comfort Measures")]
    public IEnumerable<object> Intervention_Comfort_Measures(CqlContext context)
    {
        CqlValueSet gzzzzzzzzzzzzc_ = this.Comfort_Measures(context);
        IEnumerable<ServiceRequest> gzzzzzzzzzzzzd_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, gzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        bool? gzzzzzzzzzzzze_(ServiceRequest SR)
        {
            Code<RequestStatus> gzzzzzzzzzzzzl_ = SR?.StatusElement;
            RequestStatus? gzzzzzzzzzzzzm_ = gzzzzzzzzzzzzl_?.Value;
            Code<RequestStatus> gzzzzzzzzzzzzn_ = context.Operators.Convert<Code<RequestStatus>>(gzzzzzzzzzzzzm_);
            string gzzzzzzzzzzzzo_ = context.Operators.Convert<string>(gzzzzzzzzzzzzn_);
            string[] gzzzzzzzzzzzzp_ = [
                "active",
                "completed",
                "on-hold",
            ];
            bool? gzzzzzzzzzzzzq_ = context.Operators.In<string>(gzzzzzzzzzzzzo_, gzzzzzzzzzzzzp_ as IEnumerable<string>);
            Code<RequestIntent> gzzzzzzzzzzzzr_ = SR?.IntentElement;
            RequestIntent? gzzzzzzzzzzzzs_ = gzzzzzzzzzzzzr_?.Value;
            Code<RequestIntent> gzzzzzzzzzzzzt_ = context.Operators.Convert<Code<RequestIntent>>(gzzzzzzzzzzzzs_);
            string gzzzzzzzzzzzzu_ = context.Operators.Convert<string>(gzzzzzzzzzzzzt_);
            string[] gzzzzzzzzzzzzv_ = [
                "order",
                "original-order",
                "reflex-order",
                "filler-order",
                "instance-order",
            ];
            bool? gzzzzzzzzzzzzw_ = context.Operators.In<string>(gzzzzzzzzzzzzu_, gzzzzzzzzzzzzv_ as IEnumerable<string>);
            bool? gzzzzzzzzzzzzx_ = context.Operators.And(gzzzzzzzzzzzzq_, gzzzzzzzzzzzzw_);
            FhirBoolean gzzzzzzzzzzzzy_ = SR?.DoNotPerformElement;
            bool? gzzzzzzzzzzzzz_ = gzzzzzzzzzzzzy_?.Value;
            bool? hzzzzzzzzzzzza_ = context.Operators.IsTrue(gzzzzzzzzzzzzz_);
            bool? hzzzzzzzzzzzzb_ = context.Operators.Not(hzzzzzzzzzzzza_);
            bool? hzzzzzzzzzzzzc_ = context.Operators.And(gzzzzzzzzzzzzx_, hzzzzzzzzzzzzb_);

            return hzzzzzzzzzzzzc_;
        };
        IEnumerable<ServiceRequest> gzzzzzzzzzzzzf_ = context.Operators.Where<ServiceRequest>(gzzzzzzzzzzzzd_, gzzzzzzzzzzzze_);
        IEnumerable<Procedure> gzzzzzzzzzzzzh_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, gzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        bool? gzzzzzzzzzzzzi_(Procedure InterventionPerformed)
        {
            Code<EventStatus> hzzzzzzzzzzzzd_ = InterventionPerformed?.StatusElement;
            EventStatus? hzzzzzzzzzzzze_ = hzzzzzzzzzzzzd_?.Value;
            string hzzzzzzzzzzzzf_ = context.Operators.Convert<string>(hzzzzzzzzzzzze_);
            string[] hzzzzzzzzzzzzg_ = [
                "completed",
                "in-progress",
            ];
            bool? hzzzzzzzzzzzzh_ = context.Operators.In<string>(hzzzzzzzzzzzzf_, hzzzzzzzzzzzzg_ as IEnumerable<string>);

            return hzzzzzzzzzzzzh_;
        };
        IEnumerable<Procedure> gzzzzzzzzzzzzj_ = context.Operators.Where<Procedure>(gzzzzzzzzzzzzh_, gzzzzzzzzzzzzi_);
        IEnumerable<object> gzzzzzzzzzzzzk_ = context.Operators.Union<object>(gzzzzzzzzzzzzf_ as IEnumerable<object>, gzzzzzzzzzzzzj_ as IEnumerable<object>);

        return gzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Comfort Measures during Hospitalization")]
    public IEnumerable<Encounter> Comfort_Measures_during_Hospitalization(CqlContext context)
    {
        IEnumerable<Encounter> hzzzzzzzzzzzzi_ = this.Ischemic_Stroke_Encounter(context);
        IEnumerable<Encounter> hzzzzzzzzzzzzj_(Encounter IschemicStrokeEncounter)
        {
            IEnumerable<object> hzzzzzzzzzzzzl_ = this.Intervention_Comfort_Measures(context);
            bool? hzzzzzzzzzzzzm_(object ComfortMeasure)
            {
                object hzzzzzzzzzzzzq_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                object hzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzq_);
                CqlInterval<CqlDateTime> hzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.toInterval(context, hzzzzzzzzzzzzr_);
                CqlDateTime hzzzzzzzzzzzzt_ = context.Operators.Start(hzzzzzzzzzzzzs_);
                object hzzzzzzzzzzzzu_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "authoredOn");
                CqlDateTime hzzzzzzzzzzzzv_ = context.Operators.LateBoundProperty<CqlDateTime>(hzzzzzzzzzzzzu_, "value");
                CqlInterval<CqlDateTime> hzzzzzzzzzzzzw_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservation(context, IschemicStrokeEncounter);
                bool? hzzzzzzzzzzzzx_ = context.Operators.In<CqlDateTime>(hzzzzzzzzzzzzt_ ?? hzzzzzzzzzzzzv_, hzzzzzzzzzzzzw_, default);

                return hzzzzzzzzzzzzx_;
            };
            IEnumerable<object> hzzzzzzzzzzzzn_ = context.Operators.Where<object>(hzzzzzzzzzzzzl_, hzzzzzzzzzzzzm_);
            Encounter hzzzzzzzzzzzzo_(object ComfortMeasure) =>
                IschemicStrokeEncounter;
            IEnumerable<Encounter> hzzzzzzzzzzzzp_ = context.Operators.Select<object, Encounter>(hzzzzzzzzzzzzn_, hzzzzzzzzzzzzo_);

            return hzzzzzzzzzzzzp_;
        };
        IEnumerable<Encounter> hzzzzzzzzzzzzk_ = context.Operators.SelectMany<Encounter, Encounter>(hzzzzzzzzzzzzi_, hzzzzzzzzzzzzj_);

        return hzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Encounter with Comfort Measures during Hospitalization")]
    public IEnumerable<Encounter> Encounter_with_Comfort_Measures_during_Hospitalization(CqlContext context)
    {
        IEnumerable<Encounter> hzzzzzzzzzzzzy_ = this.Ischemic_Stroke_Encounter(context);
        IEnumerable<Encounter> hzzzzzzzzzzzzz_(Encounter IschemicStrokeEncounter)
        {
            IEnumerable<object> izzzzzzzzzzzzb_ = this.Intervention_Comfort_Measures(context);
            bool? izzzzzzzzzzzzc_(object ComfortMeasure)
            {
                object izzzzzzzzzzzzg_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                object izzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzg_);
                CqlInterval<CqlDateTime> izzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.toInterval(context, izzzzzzzzzzzzh_);
                CqlDateTime izzzzzzzzzzzzj_ = context.Operators.Start(izzzzzzzzzzzzi_);
                object izzzzzzzzzzzzk_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "authoredOn");
                CqlDateTime izzzzzzzzzzzzl_ = context.Operators.LateBoundProperty<CqlDateTime>(izzzzzzzzzzzzk_, "value");
                CqlInterval<CqlDateTime> izzzzzzzzzzzzm_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservation(context, IschemicStrokeEncounter);
                bool? izzzzzzzzzzzzn_ = context.Operators.In<CqlDateTime>(izzzzzzzzzzzzj_ ?? izzzzzzzzzzzzl_, izzzzzzzzzzzzm_, default);

                return izzzzzzzzzzzzn_;
            };
            IEnumerable<object> izzzzzzzzzzzzd_ = context.Operators.Where<object>(izzzzzzzzzzzzb_, izzzzzzzzzzzzc_);
            Encounter izzzzzzzzzzzze_(object ComfortMeasure) =>
                IschemicStrokeEncounter;
            IEnumerable<Encounter> izzzzzzzzzzzzf_ = context.Operators.Select<object, Encounter>(izzzzzzzzzzzzd_, izzzzzzzzzzzze_);

            return izzzzzzzzzzzzf_;
        };
        IEnumerable<Encounter> izzzzzzzzzzzza_ = context.Operators.SelectMany<Encounter, Encounter>(hzzzzzzzzzzzzy_, hzzzzzzzzzzzzz_);

        return izzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("CalendarDayOfOrDayAfter")]
    public CqlInterval<CqlDate> CalendarDayOfOrDayAfter(CqlContext context, CqlDateTime StartValue)
    {
        CqlDate izzzzzzzzzzzzo_ = context.Operators.DateFrom(StartValue);
        CqlQuantity izzzzzzzzzzzzq_ = context.Operators.Quantity(1m, "day");
        CqlDate izzzzzzzzzzzzr_ = context.Operators.Add(izzzzzzzzzzzzo_, izzzzzzzzzzzzq_);
        CqlInterval<CqlDate> izzzzzzzzzzzzs_ = context.Operators.Interval(izzzzzzzzzzzzo_, izzzzzzzzzzzzr_, true, true);

        return izzzzzzzzzzzzs_;
    }


    #endregion Expressions

}
