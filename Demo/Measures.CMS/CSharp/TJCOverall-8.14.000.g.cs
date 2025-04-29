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

    #region ValueSet: Comfort Measures
    [CqlValueSetDefinition(
        definitionName: "Comfort Measures",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/1.3.6.1.4.1.33895.1.3.0.45",
        valueSetVersion: null)]
    public CqlValueSet Comfort_Measures(CqlContext context) => _Comfort_Measures;

    private static readonly CqlValueSet _Comfort_Measures = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/1.3.6.1.4.1.33895.1.3.0.45", null);
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

    #region ValueSet: Ischemic Stroke
    [CqlValueSetDefinition(
        definitionName: "Ischemic Stroke",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.247",
        valueSetVersion: null)]
    public CqlValueSet Ischemic_Stroke(CqlContext context) => _Ischemic_Stroke;

    private static readonly CqlValueSet _Ischemic_Stroke = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.247", null);
    #endregion

    #region ValueSet: Left Against Medical Advice
    [CqlValueSetDefinition(
        definitionName: "Left Against Medical Advice",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.308",
        valueSetVersion: null)]
    public CqlValueSet Left_Against_Medical_Advice(CqlContext context) => _Left_Against_Medical_Advice;

    private static readonly CqlValueSet _Left_Against_Medical_Advice = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.308", null);
    #endregion

    #region ValueSet: Nonelective Inpatient Encounter
    [CqlValueSetDefinition(
        definitionName: "Nonelective Inpatient Encounter",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.424",
        valueSetVersion: null)]
    public CqlValueSet Nonelective_Inpatient_Encounter(CqlContext context) => _Nonelective_Inpatient_Encounter;

    private static readonly CqlValueSet _Nonelective_Inpatient_Encounter = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.424", null);
    #endregion

    #region ValueSet: Patient Expired
    [CqlValueSetDefinition(
        definitionName: "Patient Expired",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309",
        valueSetVersion: null)]
    public CqlValueSet Patient_Expired(CqlContext context) => _Patient_Expired;

    private static readonly CqlValueSet _Patient_Expired = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309", null);
    #endregion

    #endregion ValueSets

    #region Parameters

    [CqlParameterDefinition(
        definitionName: "Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        object yzzzzzzzzzzzzzzzzzzzzw_ = context.ResolveParameter("TJCOverall-8.14.000", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)yzzzzzzzzzzzzzzzzzzzzw_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition(
        definitionName: "Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> yzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient yzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.SingletonFrom<Patient>(yzzzzzzzzzzzzzzzzzzzzx_);

        return yzzzzzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition(
        definitionName: "Non Elective Inpatient Encounter with Age")]
    public IEnumerable<Encounter> Non_Elective_Inpatient_Encounter_with_Age(CqlContext context)
    {
        CqlValueSet yzzzzzzzzzzzzzzzzzzzzz_ = this.Nonelective_Inpatient_Encounter(context);
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? zzzzzzzzzzzzzzzzzzzzzb_(Encounter NonElectiveEncounter)
        {
            Patient zzzzzzzzzzzzzzzzzzzzzd_ = this.Patient(context);
            Date zzzzzzzzzzzzzzzzzzzzze_ = zzzzzzzzzzzzzzzzzzzzzd_?.BirthDateElement;
            string zzzzzzzzzzzzzzzzzzzzzf_ = zzzzzzzzzzzzzzzzzzzzze_?.Value;
            CqlDate zzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.ConvertStringToDate(zzzzzzzzzzzzzzzzzzzzzf_);
            Period zzzzzzzzzzzzzzzzzzzzzh_ = NonElectiveEncounter?.Period;
            CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzzzzzzzzzzzzzzzzh_);
            CqlDateTime zzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Start(zzzzzzzzzzzzzzzzzzzzzi_);
            CqlDate zzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.DateFrom(zzzzzzzzzzzzzzzzzzzzzj_);
            int? zzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.CalculateAgeAt(zzzzzzzzzzzzzzzzzzzzzg_, zzzzzzzzzzzzzzzzzzzzzk_, "year");
            bool? zzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.GreaterOrEqual(zzzzzzzzzzzzzzzzzzzzzl_, 18);
            CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzzzzzzzzzzzzzzzzh_);
            CqlDateTime zzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.End(zzzzzzzzzzzzzzzzzzzzzo_);
            CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzq_ = this.Measurement_Period(context);
            bool? zzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.In<CqlDateTime>(zzzzzzzzzzzzzzzzzzzzzp_, zzzzzzzzzzzzzzzzzzzzzq_, "day");
            bool? zzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.And(zzzzzzzzzzzzzzzzzzzzzm_, zzzzzzzzzzzzzzzzzzzzzr_);

            return zzzzzzzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Where<Encounter>(zzzzzzzzzzzzzzzzzzzzza_, zzzzzzzzzzzzzzzzzzzzzb_);

        return zzzzzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition(
        definitionName: "Ischemic Stroke Encounter")]
    public IEnumerable<Encounter> Ischemic_Stroke_Encounter(CqlContext context)
    {
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzt_ = this.Non_Elective_Inpatient_Encounter_with_Age(context);
        bool? zzzzzzzzzzzzzzzzzzzzzu_(Encounter NonElectiveEncounterWithAge)
        {
            Condition zzzzzzzzzzzzzzzzzzzzzw_ = CQMCommon_2_2_000.Instance.principalDiagnosis(context, NonElectiveEncounterWithAge);
            CodeableConcept zzzzzzzzzzzzzzzzzzzzzx_ = zzzzzzzzzzzzzzzzzzzzzw_?.Code;
            CqlConcept zzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, zzzzzzzzzzzzzzzzzzzzzx_);
            CqlValueSet zzzzzzzzzzzzzzzzzzzzzz_ = this.Ischemic_Stroke(context);
            bool? azzzzzzzzzzzzzzzzzzzzza_ = context.Operators.ConceptInValueSet(zzzzzzzzzzzzzzzzzzzzzy_, zzzzzzzzzzzzzzzzzzzzzz_);

            return azzzzzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Encounter>(zzzzzzzzzzzzzzzzzzzzzt_, zzzzzzzzzzzzzzzzzzzzzu_);

        return zzzzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition(
        definitionName: "Ischemic Stroke Encounters with Discharge Disposition")]
    public IEnumerable<Encounter> Ischemic_Stroke_Encounters_with_Discharge_Disposition(CqlContext context)
    {
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzb_ = this.Ischemic_Stroke_Encounter(context);
        bool? azzzzzzzzzzzzzzzzzzzzzc_(Encounter IschemicStrokeEncounter)
        {
            Encounter.HospitalizationComponent azzzzzzzzzzzzzzzzzzzzze_ = IschemicStrokeEncounter?.Hospitalization;
            CodeableConcept azzzzzzzzzzzzzzzzzzzzzf_ = azzzzzzzzzzzzzzzzzzzzze_?.DischargeDisposition;
            CqlConcept azzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, azzzzzzzzzzzzzzzzzzzzzf_);
            CqlValueSet azzzzzzzzzzzzzzzzzzzzzh_ = this.Discharge_To_Acute_Care_Facility(context);
            bool? azzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.ConceptInValueSet(azzzzzzzzzzzzzzzzzzzzzg_, azzzzzzzzzzzzzzzzzzzzzh_);
            CodeableConcept azzzzzzzzzzzzzzzzzzzzzk_ = azzzzzzzzzzzzzzzzzzzzze_?.DischargeDisposition;
            CqlConcept azzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, azzzzzzzzzzzzzzzzzzzzzk_);
            CqlValueSet azzzzzzzzzzzzzzzzzzzzzm_ = this.Left_Against_Medical_Advice(context);
            bool? azzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.ConceptInValueSet(azzzzzzzzzzzzzzzzzzzzzl_, azzzzzzzzzzzzzzzzzzzzzm_);
            bool? azzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Or(azzzzzzzzzzzzzzzzzzzzzi_, azzzzzzzzzzzzzzzzzzzzzn_);
            CodeableConcept azzzzzzzzzzzzzzzzzzzzzq_ = azzzzzzzzzzzzzzzzzzzzze_?.DischargeDisposition;
            CqlConcept azzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, azzzzzzzzzzzzzzzzzzzzzq_);
            CqlValueSet azzzzzzzzzzzzzzzzzzzzzs_ = this.Patient_Expired(context);
            bool? azzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.ConceptInValueSet(azzzzzzzzzzzzzzzzzzzzzr_, azzzzzzzzzzzzzzzzzzzzzs_);
            bool? azzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Or(azzzzzzzzzzzzzzzzzzzzzo_, azzzzzzzzzzzzzzzzzzzzzt_);
            CodeableConcept azzzzzzzzzzzzzzzzzzzzzw_ = azzzzzzzzzzzzzzzzzzzzze_?.DischargeDisposition;
            CqlConcept azzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, azzzzzzzzzzzzzzzzzzzzzw_);
            CqlValueSet azzzzzzzzzzzzzzzzzzzzzy_ = this.Discharged_to_Home_for_Hospice_Care(context);
            bool? azzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.ConceptInValueSet(azzzzzzzzzzzzzzzzzzzzzx_, azzzzzzzzzzzzzzzzzzzzzy_);
            bool? bzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Or(azzzzzzzzzzzzzzzzzzzzzu_, azzzzzzzzzzzzzzzzzzzzzz_);
            CodeableConcept bzzzzzzzzzzzzzzzzzzzzzc_ = azzzzzzzzzzzzzzzzzzzzze_?.DischargeDisposition;
            CqlConcept bzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bzzzzzzzzzzzzzzzzzzzzzc_);
            CqlValueSet bzzzzzzzzzzzzzzzzzzzzze_ = this.Discharged_to_Health_Care_Facility_for_Hospice_Care(context);
            bool? bzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.ConceptInValueSet(bzzzzzzzzzzzzzzzzzzzzzd_, bzzzzzzzzzzzzzzzzzzzzze_);
            bool? bzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Or(bzzzzzzzzzzzzzzzzzzzzza_, bzzzzzzzzzzzzzzzzzzzzzf_);

            return bzzzzzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Where<Encounter>(azzzzzzzzzzzzzzzzzzzzzb_, azzzzzzzzzzzzzzzzzzzzzc_);

        return azzzzzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition(
        definitionName: "Intervention Comfort Measures")]
    public IEnumerable<object> Intervention_Comfort_Measures(CqlContext context)
    {
        CqlValueSet bzzzzzzzzzzzzzzzzzzzzzh_ = this.Comfort_Measures(context);
        IEnumerable<ServiceRequest> bzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        bool? bzzzzzzzzzzzzzzzzzzzzzj_(ServiceRequest SR)
        {
            Code<RequestStatus> bzzzzzzzzzzzzzzzzzzzzzq_ = SR?.StatusElement;
            RequestStatus? bzzzzzzzzzzzzzzzzzzzzzr_ = bzzzzzzzzzzzzzzzzzzzzzq_?.Value;
            Code<RequestStatus> bzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Convert<Code<RequestStatus>>(bzzzzzzzzzzzzzzzzzzzzzr_);
            string bzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Convert<string>(bzzzzzzzzzzzzzzzzzzzzzs_);
            string[] bzzzzzzzzzzzzzzzzzzzzzu_ = [
                "active",
                "completed",
                "on-hold",
            ];
            bool? bzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.In<string>(bzzzzzzzzzzzzzzzzzzzzzt_, bzzzzzzzzzzzzzzzzzzzzzu_ as IEnumerable<string>);
            Code<RequestIntent> bzzzzzzzzzzzzzzzzzzzzzw_ = SR?.IntentElement;
            RequestIntent? bzzzzzzzzzzzzzzzzzzzzzx_ = bzzzzzzzzzzzzzzzzzzzzzw_?.Value;
            Code<RequestIntent> bzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Convert<Code<RequestIntent>>(bzzzzzzzzzzzzzzzzzzzzzx_);
            string bzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Convert<string>(bzzzzzzzzzzzzzzzzzzzzzy_);
            string[] czzzzzzzzzzzzzzzzzzzzza_ = [
                "order",
                "original-order",
                "reflex-order",
                "filler-order",
                "instance-order",
            ];
            bool? czzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.In<string>(bzzzzzzzzzzzzzzzzzzzzzz_, czzzzzzzzzzzzzzzzzzzzza_ as IEnumerable<string>);
            bool? czzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.And(bzzzzzzzzzzzzzzzzzzzzzv_, czzzzzzzzzzzzzzzzzzzzzb_);
            FhirBoolean czzzzzzzzzzzzzzzzzzzzzd_ = SR?.DoNotPerformElement;
            bool? czzzzzzzzzzzzzzzzzzzzze_ = czzzzzzzzzzzzzzzzzzzzzd_?.Value;
            bool? czzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.IsTrue(czzzzzzzzzzzzzzzzzzzzze_);
            bool? czzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Not(czzzzzzzzzzzzzzzzzzzzzf_);
            bool? czzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.And(czzzzzzzzzzzzzzzzzzzzzc_, czzzzzzzzzzzzzzzzzzzzzg_);

            return czzzzzzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<ServiceRequest> bzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Where<ServiceRequest>(bzzzzzzzzzzzzzzzzzzzzzi_, bzzzzzzzzzzzzzzzzzzzzzj_);
        IEnumerable<Procedure> bzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        bool? bzzzzzzzzzzzzzzzzzzzzzn_(Procedure InterventionPerformed)
        {
            Code<EventStatus> czzzzzzzzzzzzzzzzzzzzzi_ = InterventionPerformed?.StatusElement;
            EventStatus? czzzzzzzzzzzzzzzzzzzzzj_ = czzzzzzzzzzzzzzzzzzzzzi_?.Value;
            string czzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Convert<string>(czzzzzzzzzzzzzzzzzzzzzj_);
            string[] czzzzzzzzzzzzzzzzzzzzzl_ = [
                "completed",
                "in-progress",
            ];
            bool? czzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.In<string>(czzzzzzzzzzzzzzzzzzzzzk_, czzzzzzzzzzzzzzzzzzzzzl_ as IEnumerable<string>);

            return czzzzzzzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<Procedure> bzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<Procedure>(bzzzzzzzzzzzzzzzzzzzzzm_, bzzzzzzzzzzzzzzzzzzzzzn_);
        IEnumerable<object> bzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Union<object>(bzzzzzzzzzzzzzzzzzzzzzk_ as IEnumerable<object>, bzzzzzzzzzzzzzzzzzzzzzo_ as IEnumerable<object>);

        return bzzzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition(
        definitionName: "Comfort Measures during Hospitalization")]
    public IEnumerable<Encounter> Comfort_Measures_during_Hospitalization(CqlContext context)
    {
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzn_ = this.Ischemic_Stroke_Encounter(context);
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzo_(Encounter IschemicStrokeEncounter)
        {
            IEnumerable<object> czzzzzzzzzzzzzzzzzzzzzq_ = this.Intervention_Comfort_Measures(context);
            bool? czzzzzzzzzzzzzzzzzzzzzr_(object ComfortMeasure)
            {
                object czzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                object czzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzzzzv_);
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.toInterval(context, czzzzzzzzzzzzzzzzzzzzzw_);
                CqlDateTime czzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Start(czzzzzzzzzzzzzzzzzzzzzx_);
                object czzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "authoredOn");
                CqlDateTime dzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.LateBoundProperty<CqlDateTime>(czzzzzzzzzzzzzzzzzzzzzz_, "value");
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzb_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservation(context, IschemicStrokeEncounter);
                bool? dzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.In<CqlDateTime>(czzzzzzzzzzzzzzzzzzzzzy_ ?? dzzzzzzzzzzzzzzzzzzzzza_, dzzzzzzzzzzzzzzzzzzzzzb_, default);

                return dzzzzzzzzzzzzzzzzzzzzzc_;
            };
            IEnumerable<object> czzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Where<object>(czzzzzzzzzzzzzzzzzzzzzq_, czzzzzzzzzzzzzzzzzzzzzr_);
            Encounter czzzzzzzzzzzzzzzzzzzzzt_(object ComfortMeasure) =>
                IschemicStrokeEncounter;
            IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Select<object, Encounter>(czzzzzzzzzzzzzzzzzzzzzs_, czzzzzzzzzzzzzzzzzzzzzt_);

            return czzzzzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.SelectMany<Encounter, Encounter>(czzzzzzzzzzzzzzzzzzzzzn_, czzzzzzzzzzzzzzzzzzzzzo_);

        return czzzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition(
        definitionName: "Encounter with Comfort Measures during Hospitalization")]
    public IEnumerable<Encounter> Encounter_with_Comfort_Measures_during_Hospitalization(CqlContext context)
    {
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzd_ = this.Ischemic_Stroke_Encounter(context);
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzze_(Encounter IschemicStrokeEncounter)
        {
            IEnumerable<object> dzzzzzzzzzzzzzzzzzzzzzg_ = this.Intervention_Comfort_Measures(context);
            bool? dzzzzzzzzzzzzzzzzzzzzzh_(object ComfortMeasure)
            {
                object dzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                object dzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzl_);
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.toInterval(context, dzzzzzzzzzzzzzzzzzzzzzm_);
                CqlDateTime dzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Start(dzzzzzzzzzzzzzzzzzzzzzn_);
                object dzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "authoredOn");
                CqlDateTime dzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.LateBoundProperty<CqlDateTime>(dzzzzzzzzzzzzzzzzzzzzzp_, "value");
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzr_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservation(context, IschemicStrokeEncounter);
                bool? dzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.In<CqlDateTime>(dzzzzzzzzzzzzzzzzzzzzzo_ ?? dzzzzzzzzzzzzzzzzzzzzzq_, dzzzzzzzzzzzzzzzzzzzzzr_, default);

                return dzzzzzzzzzzzzzzzzzzzzzs_;
            };
            IEnumerable<object> dzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<object>(dzzzzzzzzzzzzzzzzzzzzzg_, dzzzzzzzzzzzzzzzzzzzzzh_);
            Encounter dzzzzzzzzzzzzzzzzzzzzzj_(object ComfortMeasure) =>
                IschemicStrokeEncounter;
            IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Select<object, Encounter>(dzzzzzzzzzzzzzzzzzzzzzi_, dzzzzzzzzzzzzzzzzzzzzzj_);

            return dzzzzzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.SelectMany<Encounter, Encounter>(dzzzzzzzzzzzzzzzzzzzzzd_, dzzzzzzzzzzzzzzzzzzzzze_);

        return dzzzzzzzzzzzzzzzzzzzzzf_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public CqlInterval<CqlDate> CalendarDayOfOrDayAfter(CqlContext context, CqlDateTime StartValue)
    {
        CqlDate dzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.DateFrom(StartValue);
        CqlQuantity dzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Quantity(1m, "day");
        CqlDate dzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Add(dzzzzzzzzzzzzzzzzzzzzzt_, dzzzzzzzzzzzzzzzzzzzzzv_);
        CqlInterval<CqlDate> dzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Interval(dzzzzzzzzzzzzzzzzzzzzzt_, dzzzzzzzzzzzzzzzzzzzzzw_, true, true);

        return dzzzzzzzzzzzzzzzzzzzzzx_;
    }


    #endregion Expressions

}
