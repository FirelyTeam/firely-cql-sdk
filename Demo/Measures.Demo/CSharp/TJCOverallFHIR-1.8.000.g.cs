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
        CqlDateTime izzzzzzt_ = context.Operators.DateTime(2019, 1, 1, 0, 0, 0, 0, default);
        CqlDateTime izzzzzzu_ = context.Operators.DateTime(2020, 1, 1, 0, 0, 0, 0, default);
        CqlInterval<CqlDateTime> izzzzzzv_ = context.Operators.Interval(izzzzzzt_, izzzzzzu_, true, false);
        object izzzzzzw_ = context.ResolveParameter("TJCOverallFHIR-1.8.000", "Measurement Period", izzzzzzv_);

        return (CqlInterval<CqlDateTime>)izzzzzzw_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> izzzzzzx_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient izzzzzzy_ = context.Operators.SingletonFrom<Patient>(izzzzzzx_);

        return izzzzzzy_;
    }


    [CqlExpressionDefinition("Non Elective Inpatient Encounter")]
    public IEnumerable<Encounter> Non_Elective_Inpatient_Encounter(CqlContext context)
    {
        CqlValueSet izzzzzzz_ = this.Non_Elective_Inpatient(context);
        IEnumerable<Encounter> jzzzzzza_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, izzzzzzz_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        bool? jzzzzzzb_(Encounter NonElectiveEncounter)
        {
            Period jzzzzzzd_ = NonElectiveEncounter?.Period;
            CqlInterval<CqlDateTime> jzzzzzze_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, jzzzzzzd_);
            int? jzzzzzzf_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.LengthInDays(context, jzzzzzze_);
            bool? jzzzzzzg_ = context.Operators.LessOrEqual(jzzzzzzf_, 120);
            CqlInterval<CqlDateTime> jzzzzzzi_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, jzzzzzzd_);
            CqlDateTime jzzzzzzj_ = context.Operators.End(jzzzzzzi_);
            CqlInterval<CqlDateTime> jzzzzzzk_ = this.Measurement_Period(context);
            bool? jzzzzzzl_ = context.Operators.In<CqlDateTime>(jzzzzzzj_, jzzzzzzk_, "day");
            bool? jzzzzzzm_ = context.Operators.And(jzzzzzzg_, jzzzzzzl_);

            return jzzzzzzm_;
        };
        IEnumerable<Encounter> jzzzzzzc_ = context.Operators.Where<Encounter>(jzzzzzza_, jzzzzzzb_);

        return jzzzzzzc_;
    }


    [CqlExpressionDefinition("All Stroke Encounter")]
    public IEnumerable<Encounter> All_Stroke_Encounter(CqlContext context)
    {
        IEnumerable<Encounter> jzzzzzzn_ = this.Non_Elective_Inpatient_Encounter(context);
        bool? jzzzzzzo_(Encounter NonElectiveEncounter)
        {
            Condition jzzzzzzq_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.PrincipalDiagnosis(context, NonElectiveEncounter);
            CodeableConcept jzzzzzzr_ = jzzzzzzq_?.Code;
            CqlConcept jzzzzzzs_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, jzzzzzzr_);
            CqlValueSet jzzzzzzt_ = this.Hemorrhagic_Stroke(context);
            bool? jzzzzzzu_ = context.Operators.ConceptInValueSet(jzzzzzzs_, jzzzzzzt_);
            CodeableConcept jzzzzzzw_ = jzzzzzzq_?.Code;
            CqlConcept jzzzzzzx_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, jzzzzzzw_);
            CqlValueSet jzzzzzzy_ = this.Ischemic_Stroke(context);
            bool? jzzzzzzz_ = context.Operators.ConceptInValueSet(jzzzzzzx_, jzzzzzzy_);
            bool? kzzzzzza_ = context.Operators.Or(jzzzzzzu_, jzzzzzzz_);

            return kzzzzzza_;
        };
        IEnumerable<Encounter> jzzzzzzp_ = context.Operators.Where<Encounter>(jzzzzzzn_, jzzzzzzo_);

        return jzzzzzzp_;
    }


    [CqlExpressionDefinition("Encounter with Principal Diagnosis and Age")]
    public IEnumerable<Encounter> Encounter_with_Principal_Diagnosis_and_Age(CqlContext context)
    {
        IEnumerable<Encounter> kzzzzzzb_ = this.All_Stroke_Encounter(context);
        IEnumerable<Encounter> kzzzzzzc_(Encounter AllStrokeEncounter)
        {
            IEnumerable<Patient> kzzzzzze_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
            bool? kzzzzzzf_(Patient BirthDate)
            {
                Patient kzzzzzzj_ = this.Patient(context);
                Date kzzzzzzk_ = kzzzzzzj_?.BirthDateElement;
                string kzzzzzzl_ = kzzzzzzk_?.Value;
                CqlDateTime kzzzzzzm_ = context.Operators.ConvertStringToDateTime(kzzzzzzl_);
                Period kzzzzzzn_ = AllStrokeEncounter?.Period;
                CqlInterval<CqlDateTime> kzzzzzzo_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, kzzzzzzn_);
                CqlDateTime kzzzzzzp_ = context.Operators.Start(kzzzzzzo_);
                int? kzzzzzzq_ = context.Operators.CalculateAgeAt(kzzzzzzm_, kzzzzzzp_, "year");
                bool? kzzzzzzr_ = context.Operators.GreaterOrEqual(kzzzzzzq_, 18);

                return kzzzzzzr_;
            };
            IEnumerable<Patient> kzzzzzzg_ = context.Operators.Where<Patient>(kzzzzzze_, kzzzzzzf_);
            Encounter kzzzzzzh_(Patient BirthDate) =>
                AllStrokeEncounter;
            IEnumerable<Encounter> kzzzzzzi_ = context.Operators.Select<Patient, Encounter>(kzzzzzzg_, kzzzzzzh_);

            return kzzzzzzi_;
        };
        IEnumerable<Encounter> kzzzzzzd_ = context.Operators.SelectMany<Encounter, Encounter>(kzzzzzzb_, kzzzzzzc_);

        return kzzzzzzd_;
    }


    [CqlExpressionDefinition("Ischemic Stroke Encounter")]
    public IEnumerable<Encounter> Ischemic_Stroke_Encounter(CqlContext context)
    {
        IEnumerable<Encounter> kzzzzzzs_ = this.Encounter_with_Principal_Diagnosis_and_Age(context);
        bool? kzzzzzzt_(Encounter EncounterWithAge)
        {
            Condition kzzzzzzv_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.PrincipalDiagnosis(context, EncounterWithAge);
            CodeableConcept kzzzzzzw_ = kzzzzzzv_?.Code;
            CqlConcept kzzzzzzx_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, kzzzzzzw_);
            CqlValueSet kzzzzzzy_ = this.Ischemic_Stroke(context);
            bool? kzzzzzzz_ = context.Operators.ConceptInValueSet(kzzzzzzx_, kzzzzzzy_);

            return kzzzzzzz_;
        };
        IEnumerable<Encounter> kzzzzzzu_ = context.Operators.Where<Encounter>(kzzzzzzs_, kzzzzzzt_);

        return kzzzzzzu_;
    }


    [CqlExpressionDefinition("Ischemic Stroke Encounters with Discharge Disposition")]
    public IEnumerable<Encounter> Ischemic_Stroke_Encounters_with_Discharge_Disposition(CqlContext context)
    {
        IEnumerable<Encounter> lzzzzzza_ = this.Ischemic_Stroke_Encounter(context);
        bool? lzzzzzzb_(Encounter IschemicStrokeEncounter)
        {
            Encounter.HospitalizationComponent lzzzzzzd_ = IschemicStrokeEncounter?.Hospitalization;
            CodeableConcept lzzzzzze_ = lzzzzzzd_?.DischargeDisposition;
            CqlConcept lzzzzzzf_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, lzzzzzze_);
            CqlValueSet lzzzzzzg_ = this.Discharge_To_Acute_Care_Facility(context);
            bool? lzzzzzzh_ = context.Operators.ConceptInValueSet(lzzzzzzf_, lzzzzzzg_);
            CodeableConcept lzzzzzzj_ = lzzzzzzd_?.DischargeDisposition;
            CqlConcept lzzzzzzk_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, lzzzzzzj_);
            CqlValueSet lzzzzzzl_ = this.Left_Against_Medical_Advice(context);
            bool? lzzzzzzm_ = context.Operators.ConceptInValueSet(lzzzzzzk_, lzzzzzzl_);
            bool? lzzzzzzn_ = context.Operators.Or(lzzzzzzh_, lzzzzzzm_);
            CodeableConcept lzzzzzzp_ = lzzzzzzd_?.DischargeDisposition;
            CqlConcept lzzzzzzq_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, lzzzzzzp_);
            CqlValueSet lzzzzzzr_ = this.Patient_Expired(context);
            bool? lzzzzzzs_ = context.Operators.ConceptInValueSet(lzzzzzzq_, lzzzzzzr_);
            bool? lzzzzzzt_ = context.Operators.Or(lzzzzzzn_, lzzzzzzs_);
            CodeableConcept lzzzzzzv_ = lzzzzzzd_?.DischargeDisposition;
            CqlConcept lzzzzzzw_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, lzzzzzzv_);
            CqlValueSet lzzzzzzx_ = this.Discharged_to_Home_for_Hospice_Care(context);
            bool? lzzzzzzy_ = context.Operators.ConceptInValueSet(lzzzzzzw_, lzzzzzzx_);
            bool? lzzzzzzz_ = context.Operators.Or(lzzzzzzt_, lzzzzzzy_);
            CodeableConcept mzzzzzzb_ = lzzzzzzd_?.DischargeDisposition;
            CqlConcept mzzzzzzc_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, mzzzzzzb_);
            CqlValueSet mzzzzzzd_ = this.Discharged_to_Health_Care_Facility_for_Hospice_Care(context);
            bool? mzzzzzze_ = context.Operators.ConceptInValueSet(mzzzzzzc_, mzzzzzzd_);
            bool? mzzzzzzf_ = context.Operators.Or(lzzzzzzz_, mzzzzzze_);

            return mzzzzzzf_;
        };
        IEnumerable<Encounter> lzzzzzzc_ = context.Operators.Where<Encounter>(lzzzzzza_, lzzzzzzb_);

        return lzzzzzzc_;
    }


    [CqlExpressionDefinition("Intervention Comfort Measures")]
    public IEnumerable<object> Intervention_Comfort_Measures(CqlContext context)
    {
        CqlValueSet mzzzzzzg_ = this.Comfort_Measures(context);
        IEnumerable<ServiceRequest> mzzzzzzh_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, mzzzzzzg_, default, "http://hl7.org/fhir/StructureDefinition/ServiceRequest"));
        bool? mzzzzzzi_(ServiceRequest P)
        {
            Code<RequestIntent> mzzzzzzp_ = P?.IntentElement;
            string mzzzzzzq_ = FHIRHelpers_4_0_001.Instance.ToString(context, mzzzzzzp_);
            bool? mzzzzzzr_ = context.Operators.Equal(mzzzzzzq_, "order");

            return mzzzzzzr_;
        };
        IEnumerable<ServiceRequest> mzzzzzzj_ = context.Operators.Where<ServiceRequest>(mzzzzzzh_, mzzzzzzi_);
        IEnumerable<Procedure> mzzzzzzl_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, mzzzzzzg_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? mzzzzzzm_(Procedure InterventionPerformed)
        {
            Code<EventStatus> mzzzzzzs_ = InterventionPerformed?.StatusElement;
            string mzzzzzzt_ = FHIRHelpers_4_0_001.Instance.ToString(context, mzzzzzzs_);
            string[] mzzzzzzu_ = [
                "completed",
                "in-progress",
            ];
            bool? mzzzzzzv_ = context.Operators.In<string>(mzzzzzzt_, mzzzzzzu_ as IEnumerable<string>);

            return mzzzzzzv_;
        };
        IEnumerable<Procedure> mzzzzzzn_ = context.Operators.Where<Procedure>(mzzzzzzl_, mzzzzzzm_);
        IEnumerable<object> mzzzzzzo_ = context.Operators.Union<object>(mzzzzzzj_ as IEnumerable<object>, mzzzzzzn_ as IEnumerable<object>);

        return mzzzzzzo_;
    }


    [CqlExpressionDefinition("Comfort Measures during Hospitalization")]
    public IEnumerable<Encounter> Comfort_Measures_during_Hospitalization(CqlContext context)
    {
        IEnumerable<Encounter> mzzzzzzw_ = this.Ischemic_Stroke_Encounter(context);
        IEnumerable<Encounter> mzzzzzzx_(Encounter IschemicStrokeEncounter)
        {
            IEnumerable<object> mzzzzzzz_ = this.Intervention_Comfort_Measures(context);
            bool? nzzzzzza_(object ComfortMeasure)
            {
                object nzzzzzze_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                FhirDateTime nzzzzzzf_ = context.Operators.LateBoundProperty<FhirDateTime>(ComfortMeasure, "authoredOn");
                CqlDateTime nzzzzzzg_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, (nzzzzzze_ as FhirDateTime) ?? nzzzzzzf_);
                CqlInterval<CqlDateTime> nzzzzzzh_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.HospitalizationWithObservation(context, IschemicStrokeEncounter);
                bool? nzzzzzzi_ = context.Operators.In<CqlDateTime>(nzzzzzzg_, nzzzzzzh_, default);

                return nzzzzzzi_;
            };
            IEnumerable<object> nzzzzzzb_ = context.Operators.Where<object>(mzzzzzzz_, nzzzzzza_);
            Encounter nzzzzzzc_(object ComfortMeasure) =>
                IschemicStrokeEncounter;
            IEnumerable<Encounter> nzzzzzzd_ = context.Operators.Select<object, Encounter>(nzzzzzzb_, nzzzzzzc_);

            return nzzzzzzd_;
        };
        IEnumerable<Encounter> mzzzzzzy_ = context.Operators.SelectMany<Encounter, Encounter>(mzzzzzzw_, mzzzzzzx_);

        return mzzzzzzy_;
    }


    [CqlExpressionDefinition("Encounter with Comfort Measures during Hospitalization")]
    public IEnumerable<Encounter> Encounter_with_Comfort_Measures_during_Hospitalization(CqlContext context)
    {
        IEnumerable<Encounter> nzzzzzzj_ = this.Ischemic_Stroke_Encounter(context);
        IEnumerable<Encounter> nzzzzzzk_(Encounter IschemicStrokeEncounter)
        {
            IEnumerable<object> nzzzzzzm_ = this.Intervention_Comfort_Measures(context);
            bool? nzzzzzzn_(object ComfortMeasure)
            {
                object nzzzzzzr_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                CqlInterval<CqlDateTime> nzzzzzzs_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, nzzzzzzr_);
                CqlDateTime nzzzzzzt_ = context.Operators.Start(nzzzzzzs_);
                FhirDateTime nzzzzzzu_ = context.Operators.LateBoundProperty<FhirDateTime>(ComfortMeasure, "authoredOn");
                CqlDateTime nzzzzzzv_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, nzzzzzzu_);
                CqlInterval<CqlDateTime> nzzzzzzw_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.HospitalizationWithObservation(context, IschemicStrokeEncounter);
                bool? nzzzzzzx_ = context.Operators.In<CqlDateTime>(nzzzzzzt_ ?? nzzzzzzv_, nzzzzzzw_, default);

                return nzzzzzzx_;
            };
            IEnumerable<object> nzzzzzzo_ = context.Operators.Where<object>(nzzzzzzm_, nzzzzzzn_);
            Encounter nzzzzzzp_(object ComfortMeasure) =>
                IschemicStrokeEncounter;
            IEnumerable<Encounter> nzzzzzzq_ = context.Operators.Select<object, Encounter>(nzzzzzzo_, nzzzzzzp_);

            return nzzzzzzq_;
        };
        IEnumerable<Encounter> nzzzzzzl_ = context.Operators.SelectMany<Encounter, Encounter>(nzzzzzzj_, nzzzzzzk_);

        return nzzzzzzl_;
    }


    [CqlExpressionDefinition("CalendarDayOfOrDayAfter")]
    public CqlInterval<CqlDate> CalendarDayOfOrDayAfter(CqlContext context, CqlDateTime StartValue)
    {
        CqlDate nzzzzzzy_ = context.Operators.DateFrom(StartValue);
        CqlQuantity nzzzzzzz_ = context.Operators.Quantity(1m, "day");
        CqlDateTime ozzzzzza_ = context.Operators.Add(StartValue, nzzzzzzz_);
        CqlDate ozzzzzzb_ = context.Operators.DateFrom(ozzzzzza_);
        CqlInterval<CqlDate> ozzzzzzc_ = context.Operators.Interval(nzzzzzzy_, ozzzzzzb_, true, true);

        return ozzzzzzc_;
    }


    #endregion Expressions

}
