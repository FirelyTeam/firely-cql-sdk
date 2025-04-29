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

    [CqlValueSetDefinition("Encounter Inpatient", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", valueSetVersion: null)]
    public CqlValueSet Encounter_Inpatient(CqlContext _) => _Encounter_Inpatient;
    private static readonly CqlValueSet _Encounter_Inpatient = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);

    [CqlValueSetDefinition("Hemorrhagic Stroke", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.212", valueSetVersion: null)]
    public CqlValueSet Hemorrhagic_Stroke(CqlContext _) => _Hemorrhagic_Stroke;
    private static readonly CqlValueSet _Hemorrhagic_Stroke = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.212", null);

    [CqlValueSetDefinition("Ischemic Stroke", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.247", valueSetVersion: null)]
    public CqlValueSet Ischemic_Stroke(CqlContext _) => _Ischemic_Stroke;
    private static readonly CqlValueSet _Ischemic_Stroke = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.247", null);

    [CqlValueSetDefinition("Left Against Medical Advice", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.308", valueSetVersion: null)]
    public CqlValueSet Left_Against_Medical_Advice(CqlContext _) => _Left_Against_Medical_Advice;
    private static readonly CqlValueSet _Left_Against_Medical_Advice = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.308", null);

    [CqlValueSetDefinition("Non-Elective Inpatient", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.424", valueSetVersion: null)]
    public CqlValueSet Non_Elective_Inpatient(CqlContext _) => _Non_Elective_Inpatient;
    private static readonly CqlValueSet _Non_Elective_Inpatient = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.424", null);

    [CqlValueSetDefinition("Observation Services", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143", valueSetVersion: null)]
    public CqlValueSet Observation_Services(CqlContext _) => _Observation_Services;
    private static readonly CqlValueSet _Observation_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143", null);

    [CqlValueSetDefinition("Patient Expired", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309", valueSetVersion: null)]
    public CqlValueSet Patient_Expired(CqlContext _) => _Patient_Expired;
    private static readonly CqlValueSet _Patient_Expired = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309", null);

    [CqlValueSetDefinition("Ticagrelor Therapy", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.39", valueSetVersion: null)]
    public CqlValueSet Ticagrelor_Therapy(CqlContext _) => _Ticagrelor_Therapy;
    private static readonly CqlValueSet _Ticagrelor_Therapy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.39", null);

    #endregion ValueSets

    #region Codes

    [CqlCodeDefinition("Birth date", codeId: "21112-8", codeSystem: "http://loinc.org")]
    public CqlCode Birth_date(CqlContext _) => _Birth_date;
    private static readonly CqlCode _Birth_date = new CqlCode("21112-8", "http://loinc.org", default, default);

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("LOINC")]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC = new CqlCodeSystem();

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime szzzzzzzzzzzzzzr_ = context.Operators.DateTime(2019, 1, 1, 0, 0, 0, 0, default);
        CqlDateTime szzzzzzzzzzzzzzs_ = context.Operators.DateTime(2020, 1, 1, 0, 0, 0, 0, default);
        CqlInterval<CqlDateTime> szzzzzzzzzzzzzzt_ = context.Operators.Interval(szzzzzzzzzzzzzzr_, szzzzzzzzzzzzzzs_, true, false);
        object szzzzzzzzzzzzzzu_ = context.ResolveParameter("TJCOverallFHIR-1.8.000", "Measurement Period", szzzzzzzzzzzzzzt_);

        return (CqlInterval<CqlDateTime>)szzzzzzzzzzzzzzu_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> szzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient szzzzzzzzzzzzzzw_ = context.Operators.SingletonFrom<Patient>(szzzzzzzzzzzzzzv_);

        return szzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Non Elective Inpatient Encounter")]
    public IEnumerable<Encounter> Non_Elective_Inpatient_Encounter(CqlContext context)
    {
        CqlValueSet szzzzzzzzzzzzzzx_ = this.Non_Elective_Inpatient(context);
        IEnumerable<Encounter> szzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, szzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        bool? szzzzzzzzzzzzzzz_(Encounter NonElectiveEncounter)
        {
            Period tzzzzzzzzzzzzzzb_ = NonElectiveEncounter?.Period;
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzc_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, tzzzzzzzzzzzzzzb_);
            int? tzzzzzzzzzzzzzzd_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.LengthInDays(context, tzzzzzzzzzzzzzzc_);
            bool? tzzzzzzzzzzzzzze_ = context.Operators.LessOrEqual(tzzzzzzzzzzzzzzd_, 120);
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzg_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, tzzzzzzzzzzzzzzb_);
            CqlDateTime tzzzzzzzzzzzzzzh_ = context.Operators.End(tzzzzzzzzzzzzzzg_);
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzi_ = this.Measurement_Period(context);
            bool? tzzzzzzzzzzzzzzj_ = context.Operators.In<CqlDateTime>(tzzzzzzzzzzzzzzh_, tzzzzzzzzzzzzzzi_, "day");
            bool? tzzzzzzzzzzzzzzk_ = context.Operators.And(tzzzzzzzzzzzzzze_, tzzzzzzzzzzzzzzj_);

            return tzzzzzzzzzzzzzzk_;
        };
        IEnumerable<Encounter> tzzzzzzzzzzzzzza_ = context.Operators.Where<Encounter>(szzzzzzzzzzzzzzy_, szzzzzzzzzzzzzzz_);

        return tzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("All Stroke Encounter")]
    public IEnumerable<Encounter> All_Stroke_Encounter(CqlContext context)
    {
        IEnumerable<Encounter> tzzzzzzzzzzzzzzl_ = this.Non_Elective_Inpatient_Encounter(context);
        bool? tzzzzzzzzzzzzzzm_(Encounter NonElectiveEncounter)
        {
            Condition tzzzzzzzzzzzzzzo_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.PrincipalDiagnosis(context, NonElectiveEncounter);
            CodeableConcept tzzzzzzzzzzzzzzp_ = tzzzzzzzzzzzzzzo_?.Code;
            CqlConcept tzzzzzzzzzzzzzzq_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, tzzzzzzzzzzzzzzp_);
            CqlValueSet tzzzzzzzzzzzzzzr_ = this.Hemorrhagic_Stroke(context);
            bool? tzzzzzzzzzzzzzzs_ = context.Operators.ConceptInValueSet(tzzzzzzzzzzzzzzq_, tzzzzzzzzzzzzzzr_);
            CodeableConcept tzzzzzzzzzzzzzzu_ = tzzzzzzzzzzzzzzo_?.Code;
            CqlConcept tzzzzzzzzzzzzzzv_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, tzzzzzzzzzzzzzzu_);
            CqlValueSet tzzzzzzzzzzzzzzw_ = this.Ischemic_Stroke(context);
            bool? tzzzzzzzzzzzzzzx_ = context.Operators.ConceptInValueSet(tzzzzzzzzzzzzzzv_, tzzzzzzzzzzzzzzw_);
            bool? tzzzzzzzzzzzzzzy_ = context.Operators.Or(tzzzzzzzzzzzzzzs_, tzzzzzzzzzzzzzzx_);

            return tzzzzzzzzzzzzzzy_;
        };
        IEnumerable<Encounter> tzzzzzzzzzzzzzzn_ = context.Operators.Where<Encounter>(tzzzzzzzzzzzzzzl_, tzzzzzzzzzzzzzzm_);

        return tzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Encounter with Principal Diagnosis and Age")]
    public IEnumerable<Encounter> Encounter_with_Principal_Diagnosis_and_Age(CqlContext context)
    {
        IEnumerable<Encounter> tzzzzzzzzzzzzzzz_ = this.All_Stroke_Encounter(context);
        IEnumerable<Encounter> uzzzzzzzzzzzzzza_(Encounter AllStrokeEncounter)
        {
            IEnumerable<Patient> uzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
            bool? uzzzzzzzzzzzzzzd_(Patient BirthDate)
            {
                Patient uzzzzzzzzzzzzzzh_ = this.Patient(context);
                Date uzzzzzzzzzzzzzzi_ = uzzzzzzzzzzzzzzh_?.BirthDateElement;
                string uzzzzzzzzzzzzzzj_ = uzzzzzzzzzzzzzzi_?.Value;
                CqlDateTime uzzzzzzzzzzzzzzk_ = context.Operators.ConvertStringToDateTime(uzzzzzzzzzzzzzzj_);
                Period uzzzzzzzzzzzzzzl_ = AllStrokeEncounter?.Period;
                CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzm_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, uzzzzzzzzzzzzzzl_);
                CqlDateTime uzzzzzzzzzzzzzzn_ = context.Operators.Start(uzzzzzzzzzzzzzzm_);
                int? uzzzzzzzzzzzzzzo_ = context.Operators.CalculateAgeAt(uzzzzzzzzzzzzzzk_, uzzzzzzzzzzzzzzn_, "year");
                bool? uzzzzzzzzzzzzzzp_ = context.Operators.GreaterOrEqual(uzzzzzzzzzzzzzzo_, 18);

                return uzzzzzzzzzzzzzzp_;
            };
            IEnumerable<Patient> uzzzzzzzzzzzzzze_ = context.Operators.Where<Patient>(uzzzzzzzzzzzzzzc_, uzzzzzzzzzzzzzzd_);
            Encounter uzzzzzzzzzzzzzzf_(Patient BirthDate) =>
                AllStrokeEncounter;
            IEnumerable<Encounter> uzzzzzzzzzzzzzzg_ = context.Operators.Select<Patient, Encounter>(uzzzzzzzzzzzzzze_, uzzzzzzzzzzzzzzf_);

            return uzzzzzzzzzzzzzzg_;
        };
        IEnumerable<Encounter> uzzzzzzzzzzzzzzb_ = context.Operators.SelectMany<Encounter, Encounter>(tzzzzzzzzzzzzzzz_, uzzzzzzzzzzzzzza_);

        return uzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Ischemic Stroke Encounter")]
    public IEnumerable<Encounter> Ischemic_Stroke_Encounter(CqlContext context)
    {
        IEnumerable<Encounter> uzzzzzzzzzzzzzzq_ = this.Encounter_with_Principal_Diagnosis_and_Age(context);
        bool? uzzzzzzzzzzzzzzr_(Encounter EncounterWithAge)
        {
            Condition uzzzzzzzzzzzzzzt_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.PrincipalDiagnosis(context, EncounterWithAge);
            CodeableConcept uzzzzzzzzzzzzzzu_ = uzzzzzzzzzzzzzzt_?.Code;
            CqlConcept uzzzzzzzzzzzzzzv_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, uzzzzzzzzzzzzzzu_);
            CqlValueSet uzzzzzzzzzzzzzzw_ = this.Ischemic_Stroke(context);
            bool? uzzzzzzzzzzzzzzx_ = context.Operators.ConceptInValueSet(uzzzzzzzzzzzzzzv_, uzzzzzzzzzzzzzzw_);

            return uzzzzzzzzzzzzzzx_;
        };
        IEnumerable<Encounter> uzzzzzzzzzzzzzzs_ = context.Operators.Where<Encounter>(uzzzzzzzzzzzzzzq_, uzzzzzzzzzzzzzzr_);

        return uzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Ischemic Stroke Encounters with Discharge Disposition")]
    public IEnumerable<Encounter> Ischemic_Stroke_Encounters_with_Discharge_Disposition(CqlContext context)
    {
        IEnumerable<Encounter> uzzzzzzzzzzzzzzy_ = this.Ischemic_Stroke_Encounter(context);
        bool? uzzzzzzzzzzzzzzz_(Encounter IschemicStrokeEncounter)
        {
            Encounter.HospitalizationComponent vzzzzzzzzzzzzzzb_ = IschemicStrokeEncounter?.Hospitalization;
            CodeableConcept vzzzzzzzzzzzzzzc_ = vzzzzzzzzzzzzzzb_?.DischargeDisposition;
            CqlConcept vzzzzzzzzzzzzzzd_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, vzzzzzzzzzzzzzzc_);
            CqlValueSet vzzzzzzzzzzzzzze_ = this.Discharge_To_Acute_Care_Facility(context);
            bool? vzzzzzzzzzzzzzzf_ = context.Operators.ConceptInValueSet(vzzzzzzzzzzzzzzd_, vzzzzzzzzzzzzzze_);
            CodeableConcept vzzzzzzzzzzzzzzh_ = vzzzzzzzzzzzzzzb_?.DischargeDisposition;
            CqlConcept vzzzzzzzzzzzzzzi_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, vzzzzzzzzzzzzzzh_);
            CqlValueSet vzzzzzzzzzzzzzzj_ = this.Left_Against_Medical_Advice(context);
            bool? vzzzzzzzzzzzzzzk_ = context.Operators.ConceptInValueSet(vzzzzzzzzzzzzzzi_, vzzzzzzzzzzzzzzj_);
            bool? vzzzzzzzzzzzzzzl_ = context.Operators.Or(vzzzzzzzzzzzzzzf_, vzzzzzzzzzzzzzzk_);
            CodeableConcept vzzzzzzzzzzzzzzn_ = vzzzzzzzzzzzzzzb_?.DischargeDisposition;
            CqlConcept vzzzzzzzzzzzzzzo_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, vzzzzzzzzzzzzzzn_);
            CqlValueSet vzzzzzzzzzzzzzzp_ = this.Patient_Expired(context);
            bool? vzzzzzzzzzzzzzzq_ = context.Operators.ConceptInValueSet(vzzzzzzzzzzzzzzo_, vzzzzzzzzzzzzzzp_);
            bool? vzzzzzzzzzzzzzzr_ = context.Operators.Or(vzzzzzzzzzzzzzzl_, vzzzzzzzzzzzzzzq_);
            CodeableConcept vzzzzzzzzzzzzzzt_ = vzzzzzzzzzzzzzzb_?.DischargeDisposition;
            CqlConcept vzzzzzzzzzzzzzzu_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, vzzzzzzzzzzzzzzt_);
            CqlValueSet vzzzzzzzzzzzzzzv_ = this.Discharged_to_Home_for_Hospice_Care(context);
            bool? vzzzzzzzzzzzzzzw_ = context.Operators.ConceptInValueSet(vzzzzzzzzzzzzzzu_, vzzzzzzzzzzzzzzv_);
            bool? vzzzzzzzzzzzzzzx_ = context.Operators.Or(vzzzzzzzzzzzzzzr_, vzzzzzzzzzzzzzzw_);
            CodeableConcept vzzzzzzzzzzzzzzz_ = vzzzzzzzzzzzzzzb_?.DischargeDisposition;
            CqlConcept wzzzzzzzzzzzzzza_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, vzzzzzzzzzzzzzzz_);
            CqlValueSet wzzzzzzzzzzzzzzb_ = this.Discharged_to_Health_Care_Facility_for_Hospice_Care(context);
            bool? wzzzzzzzzzzzzzzc_ = context.Operators.ConceptInValueSet(wzzzzzzzzzzzzzza_, wzzzzzzzzzzzzzzb_);
            bool? wzzzzzzzzzzzzzzd_ = context.Operators.Or(vzzzzzzzzzzzzzzx_, wzzzzzzzzzzzzzzc_);

            return wzzzzzzzzzzzzzzd_;
        };
        IEnumerable<Encounter> vzzzzzzzzzzzzzza_ = context.Operators.Where<Encounter>(uzzzzzzzzzzzzzzy_, uzzzzzzzzzzzzzzz_);

        return vzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Intervention Comfort Measures")]
    public IEnumerable<object> Intervention_Comfort_Measures(CqlContext context)
    {
        CqlValueSet wzzzzzzzzzzzzzze_ = this.Comfort_Measures(context);
        IEnumerable<ServiceRequest> wzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, wzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/StructureDefinition/ServiceRequest"));
        bool? wzzzzzzzzzzzzzzg_(ServiceRequest P)
        {
            Code<RequestIntent> wzzzzzzzzzzzzzzn_ = P?.IntentElement;
            string wzzzzzzzzzzzzzzo_ = FHIRHelpers_4_0_001.Instance.ToString(context, wzzzzzzzzzzzzzzn_);
            bool? wzzzzzzzzzzzzzzp_ = context.Operators.Equal(wzzzzzzzzzzzzzzo_, "order");

            return wzzzzzzzzzzzzzzp_;
        };
        IEnumerable<ServiceRequest> wzzzzzzzzzzzzzzh_ = context.Operators.Where<ServiceRequest>(wzzzzzzzzzzzzzzf_, wzzzzzzzzzzzzzzg_);
        IEnumerable<Procedure> wzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, wzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? wzzzzzzzzzzzzzzk_(Procedure InterventionPerformed)
        {
            Code<EventStatus> wzzzzzzzzzzzzzzq_ = InterventionPerformed?.StatusElement;
            string wzzzzzzzzzzzzzzr_ = FHIRHelpers_4_0_001.Instance.ToString(context, wzzzzzzzzzzzzzzq_);
            string[] wzzzzzzzzzzzzzzs_ = [
                "completed",
                "in-progress",
            ];
            bool? wzzzzzzzzzzzzzzt_ = context.Operators.In<string>(wzzzzzzzzzzzzzzr_, wzzzzzzzzzzzzzzs_ as IEnumerable<string>);

            return wzzzzzzzzzzzzzzt_;
        };
        IEnumerable<Procedure> wzzzzzzzzzzzzzzl_ = context.Operators.Where<Procedure>(wzzzzzzzzzzzzzzj_, wzzzzzzzzzzzzzzk_);
        IEnumerable<object> wzzzzzzzzzzzzzzm_ = context.Operators.Union<object>(wzzzzzzzzzzzzzzh_ as IEnumerable<object>, wzzzzzzzzzzzzzzl_ as IEnumerable<object>);

        return wzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Comfort Measures during Hospitalization")]
    public IEnumerable<Encounter> Comfort_Measures_during_Hospitalization(CqlContext context)
    {
        IEnumerable<Encounter> wzzzzzzzzzzzzzzu_ = this.Ischemic_Stroke_Encounter(context);
        IEnumerable<Encounter> wzzzzzzzzzzzzzzv_(Encounter IschemicStrokeEncounter)
        {
            IEnumerable<object> wzzzzzzzzzzzzzzx_ = this.Intervention_Comfort_Measures(context);
            bool? wzzzzzzzzzzzzzzy_(object ComfortMeasure)
            {
                object xzzzzzzzzzzzzzzc_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                FhirDateTime xzzzzzzzzzzzzzzd_ = context.Operators.LateBoundProperty<FhirDateTime>(ComfortMeasure, "authoredOn");
                CqlDateTime xzzzzzzzzzzzzzze_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, (xzzzzzzzzzzzzzzc_ as FhirDateTime) ?? xzzzzzzzzzzzzzzd_);
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzf_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.HospitalizationWithObservation(context, IschemicStrokeEncounter);
                bool? xzzzzzzzzzzzzzzg_ = context.Operators.In<CqlDateTime>(xzzzzzzzzzzzzzze_, xzzzzzzzzzzzzzzf_, default);

                return xzzzzzzzzzzzzzzg_;
            };
            IEnumerable<object> wzzzzzzzzzzzzzzz_ = context.Operators.Where<object>(wzzzzzzzzzzzzzzx_, wzzzzzzzzzzzzzzy_);
            Encounter xzzzzzzzzzzzzzza_(object ComfortMeasure) =>
                IschemicStrokeEncounter;
            IEnumerable<Encounter> xzzzzzzzzzzzzzzb_ = context.Operators.Select<object, Encounter>(wzzzzzzzzzzzzzzz_, xzzzzzzzzzzzzzza_);

            return xzzzzzzzzzzzzzzb_;
        };
        IEnumerable<Encounter> wzzzzzzzzzzzzzzw_ = context.Operators.SelectMany<Encounter, Encounter>(wzzzzzzzzzzzzzzu_, wzzzzzzzzzzzzzzv_);

        return wzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Encounter with Comfort Measures during Hospitalization")]
    public IEnumerable<Encounter> Encounter_with_Comfort_Measures_during_Hospitalization(CqlContext context)
    {
        IEnumerable<Encounter> xzzzzzzzzzzzzzzh_ = this.Ischemic_Stroke_Encounter(context);
        IEnumerable<Encounter> xzzzzzzzzzzzzzzi_(Encounter IschemicStrokeEncounter)
        {
            IEnumerable<object> xzzzzzzzzzzzzzzk_ = this.Intervention_Comfort_Measures(context);
            bool? xzzzzzzzzzzzzzzl_(object ComfortMeasure)
            {
                object xzzzzzzzzzzzzzzp_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzq_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, xzzzzzzzzzzzzzzp_);
                CqlDateTime xzzzzzzzzzzzzzzr_ = context.Operators.Start(xzzzzzzzzzzzzzzq_);
                FhirDateTime xzzzzzzzzzzzzzzs_ = context.Operators.LateBoundProperty<FhirDateTime>(ComfortMeasure, "authoredOn");
                CqlDateTime xzzzzzzzzzzzzzzt_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, xzzzzzzzzzzzzzzs_);
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzu_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.HospitalizationWithObservation(context, IschemicStrokeEncounter);
                bool? xzzzzzzzzzzzzzzv_ = context.Operators.In<CqlDateTime>(xzzzzzzzzzzzzzzr_ ?? xzzzzzzzzzzzzzzt_, xzzzzzzzzzzzzzzu_, default);

                return xzzzzzzzzzzzzzzv_;
            };
            IEnumerable<object> xzzzzzzzzzzzzzzm_ = context.Operators.Where<object>(xzzzzzzzzzzzzzzk_, xzzzzzzzzzzzzzzl_);
            Encounter xzzzzzzzzzzzzzzn_(object ComfortMeasure) =>
                IschemicStrokeEncounter;
            IEnumerable<Encounter> xzzzzzzzzzzzzzzo_ = context.Operators.Select<object, Encounter>(xzzzzzzzzzzzzzzm_, xzzzzzzzzzzzzzzn_);

            return xzzzzzzzzzzzzzzo_;
        };
        IEnumerable<Encounter> xzzzzzzzzzzzzzzj_ = context.Operators.SelectMany<Encounter, Encounter>(xzzzzzzzzzzzzzzh_, xzzzzzzzzzzzzzzi_);

        return xzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("CalendarDayOfOrDayAfter")]
    public CqlInterval<CqlDate> CalendarDayOfOrDayAfter(CqlContext context, CqlDateTime StartValue)
    {
        CqlDate xzzzzzzzzzzzzzzw_ = context.Operators.DateFrom(StartValue);
        CqlQuantity xzzzzzzzzzzzzzzx_ = context.Operators.Quantity(1m, "day");
        CqlDateTime xzzzzzzzzzzzzzzy_ = context.Operators.Add(StartValue, xzzzzzzzzzzzzzzx_);
        CqlDate xzzzzzzzzzzzzzzz_ = context.Operators.DateFrom(xzzzzzzzzzzzzzzy_);
        CqlInterval<CqlDate> yzzzzzzzzzzzzzza_ = context.Operators.Interval(xzzzzzzzzzzzzzzw_, xzzzzzzzzzzzzzzz_, true, true);

        return yzzzzzzzzzzzzzza_;
    }


    #endregion Expressions

}
