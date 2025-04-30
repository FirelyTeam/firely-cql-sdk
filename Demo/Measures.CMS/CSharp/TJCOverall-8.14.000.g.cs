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
        object izzzzzzzzzzzzzk_ = context.ResolveParameter("TJCOverall-8.14.000", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)izzzzzzzzzzzzzk_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> izzzzzzzzzzzzzl_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient izzzzzzzzzzzzzm_ = context.Operators.SingletonFrom<Patient>(izzzzzzzzzzzzzl_);

        return izzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Non Elective Inpatient Encounter with Age")]
    public IEnumerable<Encounter> Non_Elective_Inpatient_Encounter_with_Age(CqlContext context)
    {
        CqlValueSet izzzzzzzzzzzzzn_ = this.Nonelective_Inpatient_Encounter(context);
        IEnumerable<Encounter> izzzzzzzzzzzzzo_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, izzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? izzzzzzzzzzzzzp_(Encounter NonElectiveEncounter)
        {
            Patient izzzzzzzzzzzzzr_ = this.Patient(context);
            Date izzzzzzzzzzzzzs_ = izzzzzzzzzzzzzr_?.BirthDateElement;
            string izzzzzzzzzzzzzt_ = izzzzzzzzzzzzzs_?.Value;
            CqlDate izzzzzzzzzzzzzu_ = context.Operators.ConvertStringToDate(izzzzzzzzzzzzzt_);
            Period izzzzzzzzzzzzzv_ = NonElectiveEncounter?.Period;
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzzzzzzzzv_);
            CqlDateTime izzzzzzzzzzzzzx_ = context.Operators.Start(izzzzzzzzzzzzzw_);
            CqlDate izzzzzzzzzzzzzy_ = context.Operators.DateFrom(izzzzzzzzzzzzzx_);
            int? izzzzzzzzzzzzzz_ = context.Operators.CalculateAgeAt(izzzzzzzzzzzzzu_, izzzzzzzzzzzzzy_, "year");
            bool? jzzzzzzzzzzzzza_ = context.Operators.GreaterOrEqual(izzzzzzzzzzzzzz_, 18);
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzzzzzzzzv_);
            CqlDateTime jzzzzzzzzzzzzzd_ = context.Operators.End(jzzzzzzzzzzzzzc_);
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzze_ = this.Measurement_Period(context);
            bool? jzzzzzzzzzzzzzf_ = context.Operators.In<CqlDateTime>(jzzzzzzzzzzzzzd_, jzzzzzzzzzzzzze_, "day");
            bool? jzzzzzzzzzzzzzg_ = context.Operators.And(jzzzzzzzzzzzzza_, jzzzzzzzzzzzzzf_);

            return jzzzzzzzzzzzzzg_;
        };
        IEnumerable<Encounter> izzzzzzzzzzzzzq_ = context.Operators.Where<Encounter>(izzzzzzzzzzzzzo_, izzzzzzzzzzzzzp_);

        return izzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Ischemic Stroke Encounter")]
    public IEnumerable<Encounter> Ischemic_Stroke_Encounter(CqlContext context)
    {
        IEnumerable<Encounter> jzzzzzzzzzzzzzh_ = this.Non_Elective_Inpatient_Encounter_with_Age(context);
        bool? jzzzzzzzzzzzzzi_(Encounter NonElectiveEncounterWithAge)
        {
            Condition jzzzzzzzzzzzzzk_ = CQMCommon_2_2_000.Instance.principalDiagnosis(context, NonElectiveEncounterWithAge);
            CodeableConcept jzzzzzzzzzzzzzl_ = jzzzzzzzzzzzzzk_?.Code;
            CqlConcept jzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, jzzzzzzzzzzzzzl_);
            CqlValueSet jzzzzzzzzzzzzzn_ = this.Ischemic_Stroke(context);
            bool? jzzzzzzzzzzzzzo_ = context.Operators.ConceptInValueSet(jzzzzzzzzzzzzzm_, jzzzzzzzzzzzzzn_);

            return jzzzzzzzzzzzzzo_;
        };
        IEnumerable<Encounter> jzzzzzzzzzzzzzj_ = context.Operators.Where<Encounter>(jzzzzzzzzzzzzzh_, jzzzzzzzzzzzzzi_);

        return jzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Ischemic Stroke Encounters with Discharge Disposition")]
    public IEnumerable<Encounter> Ischemic_Stroke_Encounters_with_Discharge_Disposition(CqlContext context)
    {
        IEnumerable<Encounter> jzzzzzzzzzzzzzp_ = this.Ischemic_Stroke_Encounter(context);
        bool? jzzzzzzzzzzzzzq_(Encounter IschemicStrokeEncounter)
        {
            Encounter.HospitalizationComponent jzzzzzzzzzzzzzs_ = IschemicStrokeEncounter?.Hospitalization;
            CodeableConcept jzzzzzzzzzzzzzt_ = jzzzzzzzzzzzzzs_?.DischargeDisposition;
            CqlConcept jzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, jzzzzzzzzzzzzzt_);
            CqlValueSet jzzzzzzzzzzzzzv_ = this.Discharge_To_Acute_Care_Facility(context);
            bool? jzzzzzzzzzzzzzw_ = context.Operators.ConceptInValueSet(jzzzzzzzzzzzzzu_, jzzzzzzzzzzzzzv_);
            CodeableConcept jzzzzzzzzzzzzzy_ = jzzzzzzzzzzzzzs_?.DischargeDisposition;
            CqlConcept jzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, jzzzzzzzzzzzzzy_);
            CqlValueSet kzzzzzzzzzzzzza_ = this.Left_Against_Medical_Advice(context);
            bool? kzzzzzzzzzzzzzb_ = context.Operators.ConceptInValueSet(jzzzzzzzzzzzzzz_, kzzzzzzzzzzzzza_);
            bool? kzzzzzzzzzzzzzc_ = context.Operators.Or(jzzzzzzzzzzzzzw_, kzzzzzzzzzzzzzb_);
            CodeableConcept kzzzzzzzzzzzzze_ = jzzzzzzzzzzzzzs_?.DischargeDisposition;
            CqlConcept kzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, kzzzzzzzzzzzzze_);
            CqlValueSet kzzzzzzzzzzzzzg_ = this.Patient_Expired(context);
            bool? kzzzzzzzzzzzzzh_ = context.Operators.ConceptInValueSet(kzzzzzzzzzzzzzf_, kzzzzzzzzzzzzzg_);
            bool? kzzzzzzzzzzzzzi_ = context.Operators.Or(kzzzzzzzzzzzzzc_, kzzzzzzzzzzzzzh_);
            CodeableConcept kzzzzzzzzzzzzzk_ = jzzzzzzzzzzzzzs_?.DischargeDisposition;
            CqlConcept kzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, kzzzzzzzzzzzzzk_);
            CqlValueSet kzzzzzzzzzzzzzm_ = this.Discharged_to_Home_for_Hospice_Care(context);
            bool? kzzzzzzzzzzzzzn_ = context.Operators.ConceptInValueSet(kzzzzzzzzzzzzzl_, kzzzzzzzzzzzzzm_);
            bool? kzzzzzzzzzzzzzo_ = context.Operators.Or(kzzzzzzzzzzzzzi_, kzzzzzzzzzzzzzn_);
            CodeableConcept kzzzzzzzzzzzzzq_ = jzzzzzzzzzzzzzs_?.DischargeDisposition;
            CqlConcept kzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, kzzzzzzzzzzzzzq_);
            CqlValueSet kzzzzzzzzzzzzzs_ = this.Discharged_to_Health_Care_Facility_for_Hospice_Care(context);
            bool? kzzzzzzzzzzzzzt_ = context.Operators.ConceptInValueSet(kzzzzzzzzzzzzzr_, kzzzzzzzzzzzzzs_);
            bool? kzzzzzzzzzzzzzu_ = context.Operators.Or(kzzzzzzzzzzzzzo_, kzzzzzzzzzzzzzt_);

            return kzzzzzzzzzzzzzu_;
        };
        IEnumerable<Encounter> jzzzzzzzzzzzzzr_ = context.Operators.Where<Encounter>(jzzzzzzzzzzzzzp_, jzzzzzzzzzzzzzq_);

        return jzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Intervention Comfort Measures")]
    public IEnumerable<object> Intervention_Comfort_Measures(CqlContext context)
    {
        CqlValueSet kzzzzzzzzzzzzzv_ = this.Comfort_Measures(context);
        IEnumerable<ServiceRequest> kzzzzzzzzzzzzzw_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, kzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        bool? kzzzzzzzzzzzzzx_(ServiceRequest SR)
        {
            Code<RequestStatus> lzzzzzzzzzzzzze_ = SR?.StatusElement;
            RequestStatus? lzzzzzzzzzzzzzf_ = lzzzzzzzzzzzzze_?.Value;
            Code<RequestStatus> lzzzzzzzzzzzzzg_ = context.Operators.Convert<Code<RequestStatus>>(lzzzzzzzzzzzzzf_);
            string lzzzzzzzzzzzzzh_ = context.Operators.Convert<string>(lzzzzzzzzzzzzzg_);
            string[] lzzzzzzzzzzzzzi_ = [
                "active",
                "completed",
                "on-hold",
            ];
            bool? lzzzzzzzzzzzzzj_ = context.Operators.In<string>(lzzzzzzzzzzzzzh_, lzzzzzzzzzzzzzi_ as IEnumerable<string>);
            Code<RequestIntent> lzzzzzzzzzzzzzk_ = SR?.IntentElement;
            RequestIntent? lzzzzzzzzzzzzzl_ = lzzzzzzzzzzzzzk_?.Value;
            Code<RequestIntent> lzzzzzzzzzzzzzm_ = context.Operators.Convert<Code<RequestIntent>>(lzzzzzzzzzzzzzl_);
            string lzzzzzzzzzzzzzn_ = context.Operators.Convert<string>(lzzzzzzzzzzzzzm_);
            string[] lzzzzzzzzzzzzzo_ = [
                "order",
                "original-order",
                "reflex-order",
                "filler-order",
                "instance-order",
            ];
            bool? lzzzzzzzzzzzzzp_ = context.Operators.In<string>(lzzzzzzzzzzzzzn_, lzzzzzzzzzzzzzo_ as IEnumerable<string>);
            bool? lzzzzzzzzzzzzzq_ = context.Operators.And(lzzzzzzzzzzzzzj_, lzzzzzzzzzzzzzp_);
            FhirBoolean lzzzzzzzzzzzzzr_ = SR?.DoNotPerformElement;
            bool? lzzzzzzzzzzzzzs_ = lzzzzzzzzzzzzzr_?.Value;
            bool? lzzzzzzzzzzzzzt_ = context.Operators.IsTrue(lzzzzzzzzzzzzzs_);
            bool? lzzzzzzzzzzzzzu_ = context.Operators.Not(lzzzzzzzzzzzzzt_);
            bool? lzzzzzzzzzzzzzv_ = context.Operators.And(lzzzzzzzzzzzzzq_, lzzzzzzzzzzzzzu_);

            return lzzzzzzzzzzzzzv_;
        };
        IEnumerable<ServiceRequest> kzzzzzzzzzzzzzy_ = context.Operators.Where<ServiceRequest>(kzzzzzzzzzzzzzw_, kzzzzzzzzzzzzzx_);
        IEnumerable<Procedure> lzzzzzzzzzzzzza_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, kzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        bool? lzzzzzzzzzzzzzb_(Procedure InterventionPerformed)
        {
            Code<EventStatus> lzzzzzzzzzzzzzw_ = InterventionPerformed?.StatusElement;
            EventStatus? lzzzzzzzzzzzzzx_ = lzzzzzzzzzzzzzw_?.Value;
            string lzzzzzzzzzzzzzy_ = context.Operators.Convert<string>(lzzzzzzzzzzzzzx_);
            string[] lzzzzzzzzzzzzzz_ = [
                "completed",
                "in-progress",
            ];
            bool? mzzzzzzzzzzzzza_ = context.Operators.In<string>(lzzzzzzzzzzzzzy_, lzzzzzzzzzzzzzz_ as IEnumerable<string>);

            return mzzzzzzzzzzzzza_;
        };
        IEnumerable<Procedure> lzzzzzzzzzzzzzc_ = context.Operators.Where<Procedure>(lzzzzzzzzzzzzza_, lzzzzzzzzzzzzzb_);
        IEnumerable<object> lzzzzzzzzzzzzzd_ = context.Operators.Union<object>(kzzzzzzzzzzzzzy_ as IEnumerable<object>, lzzzzzzzzzzzzzc_ as IEnumerable<object>);

        return lzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Comfort Measures during Hospitalization")]
    public IEnumerable<Encounter> Comfort_Measures_during_Hospitalization(CqlContext context)
    {
        IEnumerable<Encounter> mzzzzzzzzzzzzzb_ = this.Ischemic_Stroke_Encounter(context);
        IEnumerable<Encounter> mzzzzzzzzzzzzzc_(Encounter IschemicStrokeEncounter)
        {
            IEnumerable<object> mzzzzzzzzzzzzze_ = this.Intervention_Comfort_Measures(context);
            bool? mzzzzzzzzzzzzzf_(object ComfortMeasure)
            {
                object mzzzzzzzzzzzzzj_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                object mzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzj_);
                CqlInterval<CqlDateTime> mzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.toInterval(context, mzzzzzzzzzzzzzk_);
                CqlDateTime mzzzzzzzzzzzzzm_ = context.Operators.Start(mzzzzzzzzzzzzzl_);
                object mzzzzzzzzzzzzzn_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "authoredOn");
                CqlDateTime mzzzzzzzzzzzzzo_ = context.Operators.LateBoundProperty<CqlDateTime>(mzzzzzzzzzzzzzn_, "value");
                CqlInterval<CqlDateTime> mzzzzzzzzzzzzzp_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservation(context, IschemicStrokeEncounter);
                bool? mzzzzzzzzzzzzzq_ = context.Operators.In<CqlDateTime>(mzzzzzzzzzzzzzm_ ?? mzzzzzzzzzzzzzo_, mzzzzzzzzzzzzzp_, default);

                return mzzzzzzzzzzzzzq_;
            };
            IEnumerable<object> mzzzzzzzzzzzzzg_ = context.Operators.Where<object>(mzzzzzzzzzzzzze_, mzzzzzzzzzzzzzf_);
            Encounter mzzzzzzzzzzzzzh_(object ComfortMeasure) =>
                IschemicStrokeEncounter;
            IEnumerable<Encounter> mzzzzzzzzzzzzzi_ = context.Operators.Select<object, Encounter>(mzzzzzzzzzzzzzg_, mzzzzzzzzzzzzzh_);

            return mzzzzzzzzzzzzzi_;
        };
        IEnumerable<Encounter> mzzzzzzzzzzzzzd_ = context.Operators.SelectMany<Encounter, Encounter>(mzzzzzzzzzzzzzb_, mzzzzzzzzzzzzzc_);

        return mzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Encounter with Comfort Measures during Hospitalization")]
    public IEnumerable<Encounter> Encounter_with_Comfort_Measures_during_Hospitalization(CqlContext context)
    {
        IEnumerable<Encounter> mzzzzzzzzzzzzzr_ = this.Ischemic_Stroke_Encounter(context);
        IEnumerable<Encounter> mzzzzzzzzzzzzzs_(Encounter IschemicStrokeEncounter)
        {
            IEnumerable<object> mzzzzzzzzzzzzzu_ = this.Intervention_Comfort_Measures(context);
            bool? mzzzzzzzzzzzzzv_(object ComfortMeasure)
            {
                object mzzzzzzzzzzzzzz_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                object nzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzz_);
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.toInterval(context, nzzzzzzzzzzzzza_);
                CqlDateTime nzzzzzzzzzzzzzc_ = context.Operators.Start(nzzzzzzzzzzzzzb_);
                object nzzzzzzzzzzzzzd_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "authoredOn");
                CqlDateTime nzzzzzzzzzzzzze_ = context.Operators.LateBoundProperty<CqlDateTime>(nzzzzzzzzzzzzzd_, "value");
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzzf_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservation(context, IschemicStrokeEncounter);
                bool? nzzzzzzzzzzzzzg_ = context.Operators.In<CqlDateTime>(nzzzzzzzzzzzzzc_ ?? nzzzzzzzzzzzzze_, nzzzzzzzzzzzzzf_, default);

                return nzzzzzzzzzzzzzg_;
            };
            IEnumerable<object> mzzzzzzzzzzzzzw_ = context.Operators.Where<object>(mzzzzzzzzzzzzzu_, mzzzzzzzzzzzzzv_);
            Encounter mzzzzzzzzzzzzzx_(object ComfortMeasure) =>
                IschemicStrokeEncounter;
            IEnumerable<Encounter> mzzzzzzzzzzzzzy_ = context.Operators.Select<object, Encounter>(mzzzzzzzzzzzzzw_, mzzzzzzzzzzzzzx_);

            return mzzzzzzzzzzzzzy_;
        };
        IEnumerable<Encounter> mzzzzzzzzzzzzzt_ = context.Operators.SelectMany<Encounter, Encounter>(mzzzzzzzzzzzzzr_, mzzzzzzzzzzzzzs_);

        return mzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("CalendarDayOfOrDayAfter")]
    public CqlInterval<CqlDate> CalendarDayOfOrDayAfter(CqlContext context, CqlDateTime StartValue)
    {
        CqlDate nzzzzzzzzzzzzzh_ = context.Operators.DateFrom(StartValue);
        CqlQuantity nzzzzzzzzzzzzzj_ = context.Operators.Quantity(1m, "day");
        CqlDate nzzzzzzzzzzzzzk_ = context.Operators.Add(nzzzzzzzzzzzzzh_, nzzzzzzzzzzzzzj_);
        CqlInterval<CqlDate> nzzzzzzzzzzzzzl_ = context.Operators.Interval(nzzzzzzzzzzzzzh_, nzzzzzzzzzzzzzk_, true, true);

        return nzzzzzzzzzzzzzl_;
    }


    #endregion Expressions

}
