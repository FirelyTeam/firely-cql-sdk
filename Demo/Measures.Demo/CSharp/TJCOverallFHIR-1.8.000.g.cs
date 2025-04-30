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
    private static readonly CqlCode _Birth_date = new CqlCode("21112-8", "http://loinc.org");

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("LOINC")]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC =
      new CqlCodeSystem("http://loinc.org", null, [
          _Birth_date]);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime xzzzzzzzzzzzt_ = context.Operators.DateTime(2019, 1, 1, 0, 0, 0, 0, default);
        CqlDateTime xzzzzzzzzzzzu_ = context.Operators.DateTime(2020, 1, 1, 0, 0, 0, 0, default);
        CqlInterval<CqlDateTime> xzzzzzzzzzzzv_ = context.Operators.Interval(xzzzzzzzzzzzt_, xzzzzzzzzzzzu_, true, false);
        object xzzzzzzzzzzzw_ = context.ResolveParameter("TJCOverallFHIR-1.8.000", "Measurement Period", xzzzzzzzzzzzv_);

        return (CqlInterval<CqlDateTime>)xzzzzzzzzzzzw_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> xzzzzzzzzzzzx_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient xzzzzzzzzzzzy_ = context.Operators.SingletonFrom<Patient>(xzzzzzzzzzzzx_);

        return xzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Non Elective Inpatient Encounter")]
    public IEnumerable<Encounter> Non_Elective_Inpatient_Encounter(CqlContext context)
    {
        CqlValueSet xzzzzzzzzzzzz_ = this.Non_Elective_Inpatient(context);
        IEnumerable<Encounter> yzzzzzzzzzzza_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, xzzzzzzzzzzzz_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        bool? yzzzzzzzzzzzb_(Encounter NonElectiveEncounter)
        {
            Period yzzzzzzzzzzzd_ = NonElectiveEncounter?.Period;
            CqlInterval<CqlDateTime> yzzzzzzzzzzze_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, yzzzzzzzzzzzd_);
            int? yzzzzzzzzzzzf_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.LengthInDays(context, yzzzzzzzzzzze_);
            bool? yzzzzzzzzzzzg_ = context.Operators.LessOrEqual(yzzzzzzzzzzzf_, 120);
            CqlInterval<CqlDateTime> yzzzzzzzzzzzi_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, yzzzzzzzzzzzd_);
            CqlDateTime yzzzzzzzzzzzj_ = context.Operators.End(yzzzzzzzzzzzi_);
            CqlInterval<CqlDateTime> yzzzzzzzzzzzk_ = this.Measurement_Period(context);
            bool? yzzzzzzzzzzzl_ = context.Operators.In<CqlDateTime>(yzzzzzzzzzzzj_, yzzzzzzzzzzzk_, "day");
            bool? yzzzzzzzzzzzm_ = context.Operators.And(yzzzzzzzzzzzg_, yzzzzzzzzzzzl_);

            return yzzzzzzzzzzzm_;
        };
        IEnumerable<Encounter> yzzzzzzzzzzzc_ = context.Operators.Where<Encounter>(yzzzzzzzzzzza_, yzzzzzzzzzzzb_);

        return yzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("All Stroke Encounter")]
    public IEnumerable<Encounter> All_Stroke_Encounter(CqlContext context)
    {
        IEnumerable<Encounter> yzzzzzzzzzzzn_ = this.Non_Elective_Inpatient_Encounter(context);
        bool? yzzzzzzzzzzzo_(Encounter NonElectiveEncounter)
        {
            Condition yzzzzzzzzzzzq_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.PrincipalDiagnosis(context, NonElectiveEncounter);
            CodeableConcept yzzzzzzzzzzzr_ = yzzzzzzzzzzzq_?.Code;
            CqlConcept yzzzzzzzzzzzs_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, yzzzzzzzzzzzr_);
            CqlValueSet yzzzzzzzzzzzt_ = this.Hemorrhagic_Stroke(context);
            bool? yzzzzzzzzzzzu_ = context.Operators.ConceptInValueSet(yzzzzzzzzzzzs_, yzzzzzzzzzzzt_);
            CodeableConcept yzzzzzzzzzzzw_ = yzzzzzzzzzzzq_?.Code;
            CqlConcept yzzzzzzzzzzzx_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, yzzzzzzzzzzzw_);
            CqlValueSet yzzzzzzzzzzzy_ = this.Ischemic_Stroke(context);
            bool? yzzzzzzzzzzzz_ = context.Operators.ConceptInValueSet(yzzzzzzzzzzzx_, yzzzzzzzzzzzy_);
            bool? zzzzzzzzzzzza_ = context.Operators.Or(yzzzzzzzzzzzu_, yzzzzzzzzzzzz_);

            return zzzzzzzzzzzza_;
        };
        IEnumerable<Encounter> yzzzzzzzzzzzp_ = context.Operators.Where<Encounter>(yzzzzzzzzzzzn_, yzzzzzzzzzzzo_);

        return yzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Encounter with Principal Diagnosis and Age")]
    public IEnumerable<Encounter> Encounter_with_Principal_Diagnosis_and_Age(CqlContext context)
    {
        IEnumerable<Encounter> zzzzzzzzzzzzb_ = this.All_Stroke_Encounter(context);
        IEnumerable<Encounter> zzzzzzzzzzzzc_(Encounter AllStrokeEncounter)
        {
            IEnumerable<Patient> zzzzzzzzzzzze_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
            bool? zzzzzzzzzzzzf_(Patient BirthDate)
            {
                Patient zzzzzzzzzzzzj_ = this.Patient(context);
                Date zzzzzzzzzzzzk_ = zzzzzzzzzzzzj_?.BirthDateElement;
                string zzzzzzzzzzzzl_ = zzzzzzzzzzzzk_?.Value;
                CqlDateTime zzzzzzzzzzzzm_ = context.Operators.ConvertStringToDateTime(zzzzzzzzzzzzl_);
                Period zzzzzzzzzzzzn_ = AllStrokeEncounter?.Period;
                CqlInterval<CqlDateTime> zzzzzzzzzzzzo_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, zzzzzzzzzzzzn_);
                CqlDateTime zzzzzzzzzzzzp_ = context.Operators.Start(zzzzzzzzzzzzo_);
                int? zzzzzzzzzzzzq_ = context.Operators.CalculateAgeAt(zzzzzzzzzzzzm_, zzzzzzzzzzzzp_, "year");
                bool? zzzzzzzzzzzzr_ = context.Operators.GreaterOrEqual(zzzzzzzzzzzzq_, 18);

                return zzzzzzzzzzzzr_;
            };
            IEnumerable<Patient> zzzzzzzzzzzzg_ = context.Operators.Where<Patient>(zzzzzzzzzzzze_, zzzzzzzzzzzzf_);
            Encounter zzzzzzzzzzzzh_(Patient BirthDate) =>
                AllStrokeEncounter;
            IEnumerable<Encounter> zzzzzzzzzzzzi_ = context.Operators.Select<Patient, Encounter>(zzzzzzzzzzzzg_, zzzzzzzzzzzzh_);

            return zzzzzzzzzzzzi_;
        };
        IEnumerable<Encounter> zzzzzzzzzzzzd_ = context.Operators.SelectMany<Encounter, Encounter>(zzzzzzzzzzzzb_, zzzzzzzzzzzzc_);

        return zzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Ischemic Stroke Encounter")]
    public IEnumerable<Encounter> Ischemic_Stroke_Encounter(CqlContext context)
    {
        IEnumerable<Encounter> zzzzzzzzzzzzs_ = this.Encounter_with_Principal_Diagnosis_and_Age(context);
        bool? zzzzzzzzzzzzt_(Encounter EncounterWithAge)
        {
            Condition zzzzzzzzzzzzv_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.PrincipalDiagnosis(context, EncounterWithAge);
            CodeableConcept zzzzzzzzzzzzw_ = zzzzzzzzzzzzv_?.Code;
            CqlConcept zzzzzzzzzzzzx_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, zzzzzzzzzzzzw_);
            CqlValueSet zzzzzzzzzzzzy_ = this.Ischemic_Stroke(context);
            bool? zzzzzzzzzzzzz_ = context.Operators.ConceptInValueSet(zzzzzzzzzzzzx_, zzzzzzzzzzzzy_);

            return zzzzzzzzzzzzz_;
        };
        IEnumerable<Encounter> zzzzzzzzzzzzu_ = context.Operators.Where<Encounter>(zzzzzzzzzzzzs_, zzzzzzzzzzzzt_);

        return zzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Ischemic Stroke Encounters with Discharge Disposition")]
    public IEnumerable<Encounter> Ischemic_Stroke_Encounters_with_Discharge_Disposition(CqlContext context)
    {
        IEnumerable<Encounter> azzzzzzzzzzzza_ = this.Ischemic_Stroke_Encounter(context);
        bool? azzzzzzzzzzzzb_(Encounter IschemicStrokeEncounter)
        {
            Encounter.HospitalizationComponent azzzzzzzzzzzzd_ = IschemicStrokeEncounter?.Hospitalization;
            CodeableConcept azzzzzzzzzzzze_ = azzzzzzzzzzzzd_?.DischargeDisposition;
            CqlConcept azzzzzzzzzzzzf_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, azzzzzzzzzzzze_);
            CqlValueSet azzzzzzzzzzzzg_ = this.Discharge_To_Acute_Care_Facility(context);
            bool? azzzzzzzzzzzzh_ = context.Operators.ConceptInValueSet(azzzzzzzzzzzzf_, azzzzzzzzzzzzg_);
            CodeableConcept azzzzzzzzzzzzj_ = azzzzzzzzzzzzd_?.DischargeDisposition;
            CqlConcept azzzzzzzzzzzzk_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, azzzzzzzzzzzzj_);
            CqlValueSet azzzzzzzzzzzzl_ = this.Left_Against_Medical_Advice(context);
            bool? azzzzzzzzzzzzm_ = context.Operators.ConceptInValueSet(azzzzzzzzzzzzk_, azzzzzzzzzzzzl_);
            bool? azzzzzzzzzzzzn_ = context.Operators.Or(azzzzzzzzzzzzh_, azzzzzzzzzzzzm_);
            CodeableConcept azzzzzzzzzzzzp_ = azzzzzzzzzzzzd_?.DischargeDisposition;
            CqlConcept azzzzzzzzzzzzq_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, azzzzzzzzzzzzp_);
            CqlValueSet azzzzzzzzzzzzr_ = this.Patient_Expired(context);
            bool? azzzzzzzzzzzzs_ = context.Operators.ConceptInValueSet(azzzzzzzzzzzzq_, azzzzzzzzzzzzr_);
            bool? azzzzzzzzzzzzt_ = context.Operators.Or(azzzzzzzzzzzzn_, azzzzzzzzzzzzs_);
            CodeableConcept azzzzzzzzzzzzv_ = azzzzzzzzzzzzd_?.DischargeDisposition;
            CqlConcept azzzzzzzzzzzzw_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, azzzzzzzzzzzzv_);
            CqlValueSet azzzzzzzzzzzzx_ = this.Discharged_to_Home_for_Hospice_Care(context);
            bool? azzzzzzzzzzzzy_ = context.Operators.ConceptInValueSet(azzzzzzzzzzzzw_, azzzzzzzzzzzzx_);
            bool? azzzzzzzzzzzzz_ = context.Operators.Or(azzzzzzzzzzzzt_, azzzzzzzzzzzzy_);
            CodeableConcept bzzzzzzzzzzzzb_ = azzzzzzzzzzzzd_?.DischargeDisposition;
            CqlConcept bzzzzzzzzzzzzc_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, bzzzzzzzzzzzzb_);
            CqlValueSet bzzzzzzzzzzzzd_ = this.Discharged_to_Health_Care_Facility_for_Hospice_Care(context);
            bool? bzzzzzzzzzzzze_ = context.Operators.ConceptInValueSet(bzzzzzzzzzzzzc_, bzzzzzzzzzzzzd_);
            bool? bzzzzzzzzzzzzf_ = context.Operators.Or(azzzzzzzzzzzzz_, bzzzzzzzzzzzze_);

            return bzzzzzzzzzzzzf_;
        };
        IEnumerable<Encounter> azzzzzzzzzzzzc_ = context.Operators.Where<Encounter>(azzzzzzzzzzzza_, azzzzzzzzzzzzb_);

        return azzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Intervention Comfort Measures")]
    public IEnumerable<object> Intervention_Comfort_Measures(CqlContext context)
    {
        CqlValueSet bzzzzzzzzzzzzg_ = this.Comfort_Measures(context);
        IEnumerable<ServiceRequest> bzzzzzzzzzzzzh_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, bzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/StructureDefinition/ServiceRequest"));
        bool? bzzzzzzzzzzzzi_(ServiceRequest P)
        {
            Code<RequestIntent> bzzzzzzzzzzzzp_ = P?.IntentElement;
            string bzzzzzzzzzzzzq_ = FHIRHelpers_4_0_001.Instance.ToString(context, bzzzzzzzzzzzzp_);
            bool? bzzzzzzzzzzzzr_ = context.Operators.Equal(bzzzzzzzzzzzzq_, "order");

            return bzzzzzzzzzzzzr_;
        };
        IEnumerable<ServiceRequest> bzzzzzzzzzzzzj_ = context.Operators.Where<ServiceRequest>(bzzzzzzzzzzzzh_, bzzzzzzzzzzzzi_);
        IEnumerable<Procedure> bzzzzzzzzzzzzl_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, bzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? bzzzzzzzzzzzzm_(Procedure InterventionPerformed)
        {
            Code<EventStatus> bzzzzzzzzzzzzs_ = InterventionPerformed?.StatusElement;
            string bzzzzzzzzzzzzt_ = FHIRHelpers_4_0_001.Instance.ToString(context, bzzzzzzzzzzzzs_);
            string[] bzzzzzzzzzzzzu_ = [
                "completed",
                "in-progress",
            ];
            bool? bzzzzzzzzzzzzv_ = context.Operators.In<string>(bzzzzzzzzzzzzt_, bzzzzzzzzzzzzu_ as IEnumerable<string>);

            return bzzzzzzzzzzzzv_;
        };
        IEnumerable<Procedure> bzzzzzzzzzzzzn_ = context.Operators.Where<Procedure>(bzzzzzzzzzzzzl_, bzzzzzzzzzzzzm_);
        IEnumerable<object> bzzzzzzzzzzzzo_ = context.Operators.Union<object>(bzzzzzzzzzzzzj_ as IEnumerable<object>, bzzzzzzzzzzzzn_ as IEnumerable<object>);

        return bzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Comfort Measures during Hospitalization")]
    public IEnumerable<Encounter> Comfort_Measures_during_Hospitalization(CqlContext context)
    {
        IEnumerable<Encounter> bzzzzzzzzzzzzw_ = this.Ischemic_Stroke_Encounter(context);
        IEnumerable<Encounter> bzzzzzzzzzzzzx_(Encounter IschemicStrokeEncounter)
        {
            IEnumerable<object> bzzzzzzzzzzzzz_ = this.Intervention_Comfort_Measures(context);
            bool? czzzzzzzzzzzza_(object ComfortMeasure)
            {
                object czzzzzzzzzzzze_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                FhirDateTime czzzzzzzzzzzzf_ = context.Operators.LateBoundProperty<FhirDateTime>(ComfortMeasure, "authoredOn");
                CqlDateTime czzzzzzzzzzzzg_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, (czzzzzzzzzzzze_ as FhirDateTime) ?? czzzzzzzzzzzzf_);
                CqlInterval<CqlDateTime> czzzzzzzzzzzzh_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.HospitalizationWithObservation(context, IschemicStrokeEncounter);
                bool? czzzzzzzzzzzzi_ = context.Operators.In<CqlDateTime>(czzzzzzzzzzzzg_, czzzzzzzzzzzzh_, default);

                return czzzzzzzzzzzzi_;
            };
            IEnumerable<object> czzzzzzzzzzzzb_ = context.Operators.Where<object>(bzzzzzzzzzzzzz_, czzzzzzzzzzzza_);
            Encounter czzzzzzzzzzzzc_(object ComfortMeasure) =>
                IschemicStrokeEncounter;
            IEnumerable<Encounter> czzzzzzzzzzzzd_ = context.Operators.Select<object, Encounter>(czzzzzzzzzzzzb_, czzzzzzzzzzzzc_);

            return czzzzzzzzzzzzd_;
        };
        IEnumerable<Encounter> bzzzzzzzzzzzzy_ = context.Operators.SelectMany<Encounter, Encounter>(bzzzzzzzzzzzzw_, bzzzzzzzzzzzzx_);

        return bzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Encounter with Comfort Measures during Hospitalization")]
    public IEnumerable<Encounter> Encounter_with_Comfort_Measures_during_Hospitalization(CqlContext context)
    {
        IEnumerable<Encounter> czzzzzzzzzzzzj_ = this.Ischemic_Stroke_Encounter(context);
        IEnumerable<Encounter> czzzzzzzzzzzzk_(Encounter IschemicStrokeEncounter)
        {
            IEnumerable<object> czzzzzzzzzzzzm_ = this.Intervention_Comfort_Measures(context);
            bool? czzzzzzzzzzzzn_(object ComfortMeasure)
            {
                object czzzzzzzzzzzzr_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                CqlInterval<CqlDateTime> czzzzzzzzzzzzs_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, czzzzzzzzzzzzr_);
                CqlDateTime czzzzzzzzzzzzt_ = context.Operators.Start(czzzzzzzzzzzzs_);
                FhirDateTime czzzzzzzzzzzzu_ = context.Operators.LateBoundProperty<FhirDateTime>(ComfortMeasure, "authoredOn");
                CqlDateTime czzzzzzzzzzzzv_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, czzzzzzzzzzzzu_);
                CqlInterval<CqlDateTime> czzzzzzzzzzzzw_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.HospitalizationWithObservation(context, IschemicStrokeEncounter);
                bool? czzzzzzzzzzzzx_ = context.Operators.In<CqlDateTime>(czzzzzzzzzzzzt_ ?? czzzzzzzzzzzzv_, czzzzzzzzzzzzw_, default);

                return czzzzzzzzzzzzx_;
            };
            IEnumerable<object> czzzzzzzzzzzzo_ = context.Operators.Where<object>(czzzzzzzzzzzzm_, czzzzzzzzzzzzn_);
            Encounter czzzzzzzzzzzzp_(object ComfortMeasure) =>
                IschemicStrokeEncounter;
            IEnumerable<Encounter> czzzzzzzzzzzzq_ = context.Operators.Select<object, Encounter>(czzzzzzzzzzzzo_, czzzzzzzzzzzzp_);

            return czzzzzzzzzzzzq_;
        };
        IEnumerable<Encounter> czzzzzzzzzzzzl_ = context.Operators.SelectMany<Encounter, Encounter>(czzzzzzzzzzzzj_, czzzzzzzzzzzzk_);

        return czzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("CalendarDayOfOrDayAfter")]
    public CqlInterval<CqlDate> CalendarDayOfOrDayAfter(CqlContext context, CqlDateTime StartValue)
    {
        CqlDate czzzzzzzzzzzzy_ = context.Operators.DateFrom(StartValue);
        CqlQuantity czzzzzzzzzzzzz_ = context.Operators.Quantity(1m, "day");
        CqlDateTime dzzzzzzzzzzzza_ = context.Operators.Add(StartValue, czzzzzzzzzzzzz_);
        CqlDate dzzzzzzzzzzzzb_ = context.Operators.DateFrom(dzzzzzzzzzzzza_);
        CqlInterval<CqlDate> dzzzzzzzzzzzzc_ = context.Operators.Interval(czzzzzzzzzzzzy_, dzzzzzzzzzzzzb_, true, true);

        return dzzzzzzzzzzzzc_;
    }


    #endregion Expressions

}
