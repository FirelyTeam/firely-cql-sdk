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
[CqlLibrary("TJCOverallFHIR", "1.8.000")]
public partial class TJCOverallFHIR_1_8_000 : ILibrary, ISingleton<TJCOverallFHIR_1_8_000>
{
    private TJCOverallFHIR_1_8_000() {}

    public static TJCOverallFHIR_1_8_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "TJCOverallFHIR";
    public string Version => "1.8.000";
    public ILibrary[] Dependencies => [MATGlobalCommonFunctionsFHIR4_6_1_000.Instance, FHIRHelpers_4_0_001.Instance];

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

    #region ValueSet: Emergency Department Visit
    [CqlValueSetDefinition(
        definitionName: "Emergency Department Visit",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292",
        valueSetVersion: null)]
    public CqlValueSet Emergency_Department_Visit(CqlContext context) => _Emergency_Department_Visit;

    private static readonly CqlValueSet _Emergency_Department_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292", null);
    #endregion

    #region ValueSet: Encounter Inpatient
    [CqlValueSetDefinition(
        definitionName: "Encounter Inpatient",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307",
        valueSetVersion: null)]
    public CqlValueSet Encounter_Inpatient(CqlContext context) => _Encounter_Inpatient;

    private static readonly CqlValueSet _Encounter_Inpatient = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);
    #endregion

    #region ValueSet: Hemorrhagic Stroke
    [CqlValueSetDefinition(
        definitionName: "Hemorrhagic Stroke",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.212",
        valueSetVersion: null)]
    public CqlValueSet Hemorrhagic_Stroke(CqlContext context) => _Hemorrhagic_Stroke;

    private static readonly CqlValueSet _Hemorrhagic_Stroke = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.212", null);
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

    #region ValueSet: Non-Elective Inpatient
    [CqlValueSetDefinition(
        definitionName: "Non-Elective Inpatient",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.424",
        valueSetVersion: null)]
    public CqlValueSet Non_Elective_Inpatient(CqlContext context) => _Non_Elective_Inpatient;

    private static readonly CqlValueSet _Non_Elective_Inpatient = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.424", null);
    #endregion

    #region ValueSet: Observation Services
    [CqlValueSetDefinition(
        definitionName: "Observation Services",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143",
        valueSetVersion: null)]
    public CqlValueSet Observation_Services(CqlContext context) => _Observation_Services;

    private static readonly CqlValueSet _Observation_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143", null);
    #endregion

    #region ValueSet: Patient Expired
    [CqlValueSetDefinition(
        definitionName: "Patient Expired",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309",
        valueSetVersion: null)]
    public CqlValueSet Patient_Expired(CqlContext context) => _Patient_Expired;

    private static readonly CqlValueSet _Patient_Expired = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309", null);
    #endregion

    #region ValueSet: Ticagrelor Therapy
    [CqlValueSetDefinition(
        definitionName: "Ticagrelor Therapy",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.39",
        valueSetVersion: null)]
    public CqlValueSet Ticagrelor_Therapy(CqlContext context) => _Ticagrelor_Therapy;

    private static readonly CqlValueSet _Ticagrelor_Therapy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.39", null);
    #endregion

    #endregion ValueSets

    #region Codes

    #region Code: Birth date
    [CqlCodeDefinition(
        definitionName: "Birth date",
        codeId: "21112-8",
        codeSystem: "http://loinc.org")]
    public CqlCode Birth_date(CqlContext context) => _Birth_date;

    private static readonly CqlCode _Birth_date = new CqlCode("21112-8", "http://loinc.org", default, default);
    #endregion

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition(
        definitionName: "LOINC")]
    public CqlCode[] LOINC(CqlContext context)
    {
        CqlCode[] wzzzzzzzzzzzzh_ = [
            new CqlCode("21112-8", "http://loinc.org", default, default),
        ];

        return wzzzzzzzzzzzzh_;
    }


    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition(
        definitionName: "Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime wzzzzzzzzzzzzi_ = context.Operators.DateTime(2019, 1, 1, 0, 0, 0, 0, default);
        CqlDateTime wzzzzzzzzzzzzj_ = context.Operators.DateTime(2020, 1, 1, 0, 0, 0, 0, default);
        CqlInterval<CqlDateTime> wzzzzzzzzzzzzk_ = context.Operators.Interval(wzzzzzzzzzzzzi_, wzzzzzzzzzzzzj_, true, false);
        object wzzzzzzzzzzzzl_ = context.ResolveParameter("TJCOverallFHIR-1.8.000", "Measurement Period", wzzzzzzzzzzzzk_);

        return (CqlInterval<CqlDateTime>)wzzzzzzzzzzzzl_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition(
        definitionName: "Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> wzzzzzzzzzzzzm_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient wzzzzzzzzzzzzn_ = context.Operators.SingletonFrom<Patient>(wzzzzzzzzzzzzm_);

        return wzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition(
        definitionName: "Non Elective Inpatient Encounter")]
    public IEnumerable<Encounter> Non_Elective_Inpatient_Encounter(CqlContext context)
    {
        CqlValueSet wzzzzzzzzzzzzo_ = this.Non_Elective_Inpatient(context);
        IEnumerable<Encounter> wzzzzzzzzzzzzp_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, wzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        bool? wzzzzzzzzzzzzq_(Encounter NonElectiveEncounter)
        {
            Period wzzzzzzzzzzzzs_ = NonElectiveEncounter?.Period;
            CqlInterval<CqlDateTime> wzzzzzzzzzzzzt_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, wzzzzzzzzzzzzs_);
            int? wzzzzzzzzzzzzu_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.LengthInDays(context, wzzzzzzzzzzzzt_);
            bool? wzzzzzzzzzzzzv_ = context.Operators.LessOrEqual(wzzzzzzzzzzzzu_, 120);
            CqlInterval<CqlDateTime> wzzzzzzzzzzzzx_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, wzzzzzzzzzzzzs_);
            CqlDateTime wzzzzzzzzzzzzy_ = context.Operators.End(wzzzzzzzzzzzzx_);
            CqlInterval<CqlDateTime> wzzzzzzzzzzzzz_ = this.Measurement_Period(context);
            bool? xzzzzzzzzzzzza_ = context.Operators.In<CqlDateTime>(wzzzzzzzzzzzzy_, wzzzzzzzzzzzzz_, "day");
            bool? xzzzzzzzzzzzzb_ = context.Operators.And(wzzzzzzzzzzzzv_, xzzzzzzzzzzzza_);

            return xzzzzzzzzzzzzb_;
        };
        IEnumerable<Encounter> wzzzzzzzzzzzzr_ = context.Operators.Where<Encounter>(wzzzzzzzzzzzzp_, wzzzzzzzzzzzzq_);

        return wzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition(
        definitionName: "All Stroke Encounter")]
    public IEnumerable<Encounter> All_Stroke_Encounter(CqlContext context)
    {
        IEnumerable<Encounter> xzzzzzzzzzzzzc_ = this.Non_Elective_Inpatient_Encounter(context);
        bool? xzzzzzzzzzzzzd_(Encounter NonElectiveEncounter)
        {
            Condition xzzzzzzzzzzzzf_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.PrincipalDiagnosis(context, NonElectiveEncounter);
            CodeableConcept xzzzzzzzzzzzzg_ = xzzzzzzzzzzzzf_?.Code;
            CqlConcept xzzzzzzzzzzzzh_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, xzzzzzzzzzzzzg_);
            CqlValueSet xzzzzzzzzzzzzi_ = this.Hemorrhagic_Stroke(context);
            bool? xzzzzzzzzzzzzj_ = context.Operators.ConceptInValueSet(xzzzzzzzzzzzzh_, xzzzzzzzzzzzzi_);
            CodeableConcept xzzzzzzzzzzzzl_ = xzzzzzzzzzzzzf_?.Code;
            CqlConcept xzzzzzzzzzzzzm_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, xzzzzzzzzzzzzl_);
            CqlValueSet xzzzzzzzzzzzzn_ = this.Ischemic_Stroke(context);
            bool? xzzzzzzzzzzzzo_ = context.Operators.ConceptInValueSet(xzzzzzzzzzzzzm_, xzzzzzzzzzzzzn_);
            bool? xzzzzzzzzzzzzp_ = context.Operators.Or(xzzzzzzzzzzzzj_, xzzzzzzzzzzzzo_);

            return xzzzzzzzzzzzzp_;
        };
        IEnumerable<Encounter> xzzzzzzzzzzzze_ = context.Operators.Where<Encounter>(xzzzzzzzzzzzzc_, xzzzzzzzzzzzzd_);

        return xzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition(
        definitionName: "Encounter with Principal Diagnosis and Age")]
    public IEnumerable<Encounter> Encounter_with_Principal_Diagnosis_and_Age(CqlContext context)
    {
        IEnumerable<Encounter> xzzzzzzzzzzzzq_ = this.All_Stroke_Encounter(context);
        IEnumerable<Encounter> xzzzzzzzzzzzzr_(Encounter AllStrokeEncounter)
        {
            IEnumerable<Patient> xzzzzzzzzzzzzt_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
            bool? xzzzzzzzzzzzzu_(Patient BirthDate)
            {
                Patient xzzzzzzzzzzzzy_ = this.Patient(context);
                Date xzzzzzzzzzzzzz_ = xzzzzzzzzzzzzy_?.BirthDateElement;
                string yzzzzzzzzzzzza_ = xzzzzzzzzzzzzz_?.Value;
                CqlDateTime yzzzzzzzzzzzzb_ = context.Operators.ConvertStringToDateTime(yzzzzzzzzzzzza_);
                Period yzzzzzzzzzzzzc_ = AllStrokeEncounter?.Period;
                CqlInterval<CqlDateTime> yzzzzzzzzzzzzd_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, yzzzzzzzzzzzzc_);
                CqlDateTime yzzzzzzzzzzzze_ = context.Operators.Start(yzzzzzzzzzzzzd_);
                int? yzzzzzzzzzzzzf_ = context.Operators.CalculateAgeAt(yzzzzzzzzzzzzb_, yzzzzzzzzzzzze_, "year");
                bool? yzzzzzzzzzzzzg_ = context.Operators.GreaterOrEqual(yzzzzzzzzzzzzf_, 18);

                return yzzzzzzzzzzzzg_;
            };
            IEnumerable<Patient> xzzzzzzzzzzzzv_ = context.Operators.Where<Patient>(xzzzzzzzzzzzzt_, xzzzzzzzzzzzzu_);
            Encounter xzzzzzzzzzzzzw_(Patient BirthDate) =>
                AllStrokeEncounter;
            IEnumerable<Encounter> xzzzzzzzzzzzzx_ = context.Operators.Select<Patient, Encounter>(xzzzzzzzzzzzzv_, xzzzzzzzzzzzzw_);

            return xzzzzzzzzzzzzx_;
        };
        IEnumerable<Encounter> xzzzzzzzzzzzzs_ = context.Operators.SelectMany<Encounter, Encounter>(xzzzzzzzzzzzzq_, xzzzzzzzzzzzzr_);

        return xzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition(
        definitionName: "Ischemic Stroke Encounter")]
    public IEnumerable<Encounter> Ischemic_Stroke_Encounter(CqlContext context)
    {
        IEnumerable<Encounter> yzzzzzzzzzzzzh_ = this.Encounter_with_Principal_Diagnosis_and_Age(context);
        bool? yzzzzzzzzzzzzi_(Encounter EncounterWithAge)
        {
            Condition yzzzzzzzzzzzzk_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.PrincipalDiagnosis(context, EncounterWithAge);
            CodeableConcept yzzzzzzzzzzzzl_ = yzzzzzzzzzzzzk_?.Code;
            CqlConcept yzzzzzzzzzzzzm_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, yzzzzzzzzzzzzl_);
            CqlValueSet yzzzzzzzzzzzzn_ = this.Ischemic_Stroke(context);
            bool? yzzzzzzzzzzzzo_ = context.Operators.ConceptInValueSet(yzzzzzzzzzzzzm_, yzzzzzzzzzzzzn_);

            return yzzzzzzzzzzzzo_;
        };
        IEnumerable<Encounter> yzzzzzzzzzzzzj_ = context.Operators.Where<Encounter>(yzzzzzzzzzzzzh_, yzzzzzzzzzzzzi_);

        return yzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition(
        definitionName: "Ischemic Stroke Encounters with Discharge Disposition")]
    public IEnumerable<Encounter> Ischemic_Stroke_Encounters_with_Discharge_Disposition(CqlContext context)
    {
        IEnumerable<Encounter> yzzzzzzzzzzzzp_ = this.Ischemic_Stroke_Encounter(context);
        bool? yzzzzzzzzzzzzq_(Encounter IschemicStrokeEncounter)
        {
            Encounter.HospitalizationComponent yzzzzzzzzzzzzs_ = IschemicStrokeEncounter?.Hospitalization;
            CodeableConcept yzzzzzzzzzzzzt_ = yzzzzzzzzzzzzs_?.DischargeDisposition;
            CqlConcept yzzzzzzzzzzzzu_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, yzzzzzzzzzzzzt_);
            CqlValueSet yzzzzzzzzzzzzv_ = this.Discharge_To_Acute_Care_Facility(context);
            bool? yzzzzzzzzzzzzw_ = context.Operators.ConceptInValueSet(yzzzzzzzzzzzzu_, yzzzzzzzzzzzzv_);
            CodeableConcept yzzzzzzzzzzzzy_ = yzzzzzzzzzzzzs_?.DischargeDisposition;
            CqlConcept yzzzzzzzzzzzzz_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, yzzzzzzzzzzzzy_);
            CqlValueSet zzzzzzzzzzzzza_ = this.Left_Against_Medical_Advice(context);
            bool? zzzzzzzzzzzzzb_ = context.Operators.ConceptInValueSet(yzzzzzzzzzzzzz_, zzzzzzzzzzzzza_);
            bool? zzzzzzzzzzzzzc_ = context.Operators.Or(yzzzzzzzzzzzzw_, zzzzzzzzzzzzzb_);
            CodeableConcept zzzzzzzzzzzzze_ = yzzzzzzzzzzzzs_?.DischargeDisposition;
            CqlConcept zzzzzzzzzzzzzf_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, zzzzzzzzzzzzze_);
            CqlValueSet zzzzzzzzzzzzzg_ = this.Patient_Expired(context);
            bool? zzzzzzzzzzzzzh_ = context.Operators.ConceptInValueSet(zzzzzzzzzzzzzf_, zzzzzzzzzzzzzg_);
            bool? zzzzzzzzzzzzzi_ = context.Operators.Or(zzzzzzzzzzzzzc_, zzzzzzzzzzzzzh_);
            CodeableConcept zzzzzzzzzzzzzk_ = yzzzzzzzzzzzzs_?.DischargeDisposition;
            CqlConcept zzzzzzzzzzzzzl_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, zzzzzzzzzzzzzk_);
            CqlValueSet zzzzzzzzzzzzzm_ = this.Discharged_to_Home_for_Hospice_Care(context);
            bool? zzzzzzzzzzzzzn_ = context.Operators.ConceptInValueSet(zzzzzzzzzzzzzl_, zzzzzzzzzzzzzm_);
            bool? zzzzzzzzzzzzzo_ = context.Operators.Or(zzzzzzzzzzzzzi_, zzzzzzzzzzzzzn_);
            CodeableConcept zzzzzzzzzzzzzq_ = yzzzzzzzzzzzzs_?.DischargeDisposition;
            CqlConcept zzzzzzzzzzzzzr_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, zzzzzzzzzzzzzq_);
            CqlValueSet zzzzzzzzzzzzzs_ = this.Discharged_to_Health_Care_Facility_for_Hospice_Care(context);
            bool? zzzzzzzzzzzzzt_ = context.Operators.ConceptInValueSet(zzzzzzzzzzzzzr_, zzzzzzzzzzzzzs_);
            bool? zzzzzzzzzzzzzu_ = context.Operators.Or(zzzzzzzzzzzzzo_, zzzzzzzzzzzzzt_);

            return zzzzzzzzzzzzzu_;
        };
        IEnumerable<Encounter> yzzzzzzzzzzzzr_ = context.Operators.Where<Encounter>(yzzzzzzzzzzzzp_, yzzzzzzzzzzzzq_);

        return yzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition(
        definitionName: "Intervention Comfort Measures")]
    public IEnumerable<object> Intervention_Comfort_Measures(CqlContext context)
    {
        CqlValueSet zzzzzzzzzzzzzv_ = this.Comfort_Measures(context);
        IEnumerable<ServiceRequest> zzzzzzzzzzzzzw_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, zzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/StructureDefinition/ServiceRequest"));
        bool? zzzzzzzzzzzzzx_(ServiceRequest P)
        {
            Code<RequestIntent> azzzzzzzzzzzzze_ = P?.IntentElement;
            string azzzzzzzzzzzzzf_ = FHIRHelpers_4_0_001.Instance.ToString(context, azzzzzzzzzzzzze_);
            bool? azzzzzzzzzzzzzg_ = context.Operators.Equal(azzzzzzzzzzzzzf_, "order");

            return azzzzzzzzzzzzzg_;
        };
        IEnumerable<ServiceRequest> zzzzzzzzzzzzzy_ = context.Operators.Where<ServiceRequest>(zzzzzzzzzzzzzw_, zzzzzzzzzzzzzx_);
        IEnumerable<Procedure> azzzzzzzzzzzzza_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, zzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? azzzzzzzzzzzzzb_(Procedure InterventionPerformed)
        {
            Code<EventStatus> azzzzzzzzzzzzzh_ = InterventionPerformed?.StatusElement;
            string azzzzzzzzzzzzzi_ = FHIRHelpers_4_0_001.Instance.ToString(context, azzzzzzzzzzzzzh_);
            string[] azzzzzzzzzzzzzj_ = [
                "completed",
                "in-progress",
            ];
            bool? azzzzzzzzzzzzzk_ = context.Operators.In<string>(azzzzzzzzzzzzzi_, azzzzzzzzzzzzzj_ as IEnumerable<string>);

            return azzzzzzzzzzzzzk_;
        };
        IEnumerable<Procedure> azzzzzzzzzzzzzc_ = context.Operators.Where<Procedure>(azzzzzzzzzzzzza_, azzzzzzzzzzzzzb_);
        IEnumerable<object> azzzzzzzzzzzzzd_ = context.Operators.Union<object>(zzzzzzzzzzzzzy_ as IEnumerable<object>, azzzzzzzzzzzzzc_ as IEnumerable<object>);

        return azzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition(
        definitionName: "Comfort Measures during Hospitalization")]
    public IEnumerable<Encounter> Comfort_Measures_during_Hospitalization(CqlContext context)
    {
        IEnumerable<Encounter> azzzzzzzzzzzzzl_ = this.Ischemic_Stroke_Encounter(context);
        IEnumerable<Encounter> azzzzzzzzzzzzzm_(Encounter IschemicStrokeEncounter)
        {
            IEnumerable<object> azzzzzzzzzzzzzo_ = this.Intervention_Comfort_Measures(context);
            bool? azzzzzzzzzzzzzp_(object ComfortMeasure)
            {
                object azzzzzzzzzzzzzt_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                FhirDateTime azzzzzzzzzzzzzu_ = context.Operators.LateBoundProperty<FhirDateTime>(ComfortMeasure, "authoredOn");
                CqlDateTime azzzzzzzzzzzzzv_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, (azzzzzzzzzzzzzt_ as FhirDateTime) ?? azzzzzzzzzzzzzu_);
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzw_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.HospitalizationWithObservation(context, IschemicStrokeEncounter);
                bool? azzzzzzzzzzzzzx_ = context.Operators.In<CqlDateTime>(azzzzzzzzzzzzzv_, azzzzzzzzzzzzzw_, default);

                return azzzzzzzzzzzzzx_;
            };
            IEnumerable<object> azzzzzzzzzzzzzq_ = context.Operators.Where<object>(azzzzzzzzzzzzzo_, azzzzzzzzzzzzzp_);
            Encounter azzzzzzzzzzzzzr_(object ComfortMeasure) =>
                IschemicStrokeEncounter;
            IEnumerable<Encounter> azzzzzzzzzzzzzs_ = context.Operators.Select<object, Encounter>(azzzzzzzzzzzzzq_, azzzzzzzzzzzzzr_);

            return azzzzzzzzzzzzzs_;
        };
        IEnumerable<Encounter> azzzzzzzzzzzzzn_ = context.Operators.SelectMany<Encounter, Encounter>(azzzzzzzzzzzzzl_, azzzzzzzzzzzzzm_);

        return azzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition(
        definitionName: "Encounter with Comfort Measures during Hospitalization")]
    public IEnumerable<Encounter> Encounter_with_Comfort_Measures_during_Hospitalization(CqlContext context)
    {
        IEnumerable<Encounter> azzzzzzzzzzzzzy_ = this.Ischemic_Stroke_Encounter(context);
        IEnumerable<Encounter> azzzzzzzzzzzzzz_(Encounter IschemicStrokeEncounter)
        {
            IEnumerable<object> bzzzzzzzzzzzzzb_ = this.Intervention_Comfort_Measures(context);
            bool? bzzzzzzzzzzzzzc_(object ComfortMeasure)
            {
                object bzzzzzzzzzzzzzg_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzh_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, bzzzzzzzzzzzzzg_);
                CqlDateTime bzzzzzzzzzzzzzi_ = context.Operators.Start(bzzzzzzzzzzzzzh_);
                FhirDateTime bzzzzzzzzzzzzzj_ = context.Operators.LateBoundProperty<FhirDateTime>(ComfortMeasure, "authoredOn");
                CqlDateTime bzzzzzzzzzzzzzk_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, bzzzzzzzzzzzzzj_);
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzl_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.HospitalizationWithObservation(context, IschemicStrokeEncounter);
                bool? bzzzzzzzzzzzzzm_ = context.Operators.In<CqlDateTime>(bzzzzzzzzzzzzzi_ ?? bzzzzzzzzzzzzzk_, bzzzzzzzzzzzzzl_, default);

                return bzzzzzzzzzzzzzm_;
            };
            IEnumerable<object> bzzzzzzzzzzzzzd_ = context.Operators.Where<object>(bzzzzzzzzzzzzzb_, bzzzzzzzzzzzzzc_);
            Encounter bzzzzzzzzzzzzze_(object ComfortMeasure) =>
                IschemicStrokeEncounter;
            IEnumerable<Encounter> bzzzzzzzzzzzzzf_ = context.Operators.Select<object, Encounter>(bzzzzzzzzzzzzzd_, bzzzzzzzzzzzzze_);

            return bzzzzzzzzzzzzzf_;
        };
        IEnumerable<Encounter> bzzzzzzzzzzzzza_ = context.Operators.SelectMany<Encounter, Encounter>(azzzzzzzzzzzzzy_, azzzzzzzzzzzzzz_);

        return bzzzzzzzzzzzzza_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public CqlInterval<CqlDate> CalendarDayOfOrDayAfter(CqlContext context, CqlDateTime StartValue)
    {
        CqlDate bzzzzzzzzzzzzzn_ = context.Operators.DateFrom(StartValue);
        CqlQuantity bzzzzzzzzzzzzzo_ = context.Operators.Quantity(1m, "day");
        CqlDateTime bzzzzzzzzzzzzzp_ = context.Operators.Add(StartValue, bzzzzzzzzzzzzzo_);
        CqlDate bzzzzzzzzzzzzzq_ = context.Operators.DateFrom(bzzzzzzzzzzzzzp_);
        CqlInterval<CqlDate> bzzzzzzzzzzzzzr_ = context.Operators.Interval(bzzzzzzzzzzzzzn_, bzzzzzzzzzzzzzq_, true, true);

        return bzzzzzzzzzzzzzr_;
    }


    #endregion Expressions

}
