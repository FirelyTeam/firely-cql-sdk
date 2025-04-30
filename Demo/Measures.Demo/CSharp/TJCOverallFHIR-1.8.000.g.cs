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
      new CqlCodeSystem("http://loinc.org", null,
          _Birth_date);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime jzzzzzzi_ = context.Operators.DateTime(2019, 1, 1, 0, 0, 0, 0, default);
        CqlDateTime jzzzzzzj_ = context.Operators.DateTime(2020, 1, 1, 0, 0, 0, 0, default);
        CqlInterval<CqlDateTime> jzzzzzzk_ = context.Operators.Interval(jzzzzzzi_, jzzzzzzj_, true, false);
        object jzzzzzzl_ = context.ResolveParameter("TJCOverallFHIR-1.8.000", "Measurement Period", jzzzzzzk_);

        return (CqlInterval<CqlDateTime>)jzzzzzzl_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> jzzzzzzm_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient jzzzzzzn_ = context.Operators.SingletonFrom<Patient>(jzzzzzzm_);

        return jzzzzzzn_;
    }


    [CqlExpressionDefinition("Non Elective Inpatient Encounter")]
    public IEnumerable<Encounter> Non_Elective_Inpatient_Encounter(CqlContext context)
    {
        CqlValueSet jzzzzzzo_ = this.Non_Elective_Inpatient(context);
        IEnumerable<Encounter> jzzzzzzp_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, jzzzzzzo_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        bool? jzzzzzzq_(Encounter NonElectiveEncounter)
        {
            Period jzzzzzzs_ = NonElectiveEncounter?.Period;
            CqlInterval<CqlDateTime> jzzzzzzt_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, jzzzzzzs_);
            int? jzzzzzzu_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.LengthInDays(context, jzzzzzzt_);
            bool? jzzzzzzv_ = context.Operators.LessOrEqual(jzzzzzzu_, 120);
            CqlInterval<CqlDateTime> jzzzzzzx_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, jzzzzzzs_);
            CqlDateTime jzzzzzzy_ = context.Operators.End(jzzzzzzx_);
            CqlInterval<CqlDateTime> jzzzzzzz_ = this.Measurement_Period(context);
            bool? kzzzzzza_ = context.Operators.In<CqlDateTime>(jzzzzzzy_, jzzzzzzz_, "day");
            bool? kzzzzzzb_ = context.Operators.And(jzzzzzzv_, kzzzzzza_);

            return kzzzzzzb_;
        };
        IEnumerable<Encounter> jzzzzzzr_ = context.Operators.Where<Encounter>(jzzzzzzp_, jzzzzzzq_);

        return jzzzzzzr_;
    }


    [CqlExpressionDefinition("All Stroke Encounter")]
    public IEnumerable<Encounter> All_Stroke_Encounter(CqlContext context)
    {
        IEnumerable<Encounter> kzzzzzzc_ = this.Non_Elective_Inpatient_Encounter(context);
        bool? kzzzzzzd_(Encounter NonElectiveEncounter)
        {
            Condition kzzzzzzf_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.PrincipalDiagnosis(context, NonElectiveEncounter);
            CodeableConcept kzzzzzzg_ = kzzzzzzf_?.Code;
            CqlConcept kzzzzzzh_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, kzzzzzzg_);
            CqlValueSet kzzzzzzi_ = this.Hemorrhagic_Stroke(context);
            bool? kzzzzzzj_ = context.Operators.ConceptInValueSet(kzzzzzzh_, kzzzzzzi_);
            CodeableConcept kzzzzzzl_ = kzzzzzzf_?.Code;
            CqlConcept kzzzzzzm_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, kzzzzzzl_);
            CqlValueSet kzzzzzzn_ = this.Ischemic_Stroke(context);
            bool? kzzzzzzo_ = context.Operators.ConceptInValueSet(kzzzzzzm_, kzzzzzzn_);
            bool? kzzzzzzp_ = context.Operators.Or(kzzzzzzj_, kzzzzzzo_);

            return kzzzzzzp_;
        };
        IEnumerable<Encounter> kzzzzzze_ = context.Operators.Where<Encounter>(kzzzzzzc_, kzzzzzzd_);

        return kzzzzzze_;
    }


    [CqlExpressionDefinition("Encounter with Principal Diagnosis and Age")]
    public IEnumerable<Encounter> Encounter_with_Principal_Diagnosis_and_Age(CqlContext context)
    {
        IEnumerable<Encounter> kzzzzzzq_ = this.All_Stroke_Encounter(context);
        IEnumerable<Encounter> kzzzzzzr_(Encounter AllStrokeEncounter)
        {
            IEnumerable<Patient> kzzzzzzt_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
            bool? kzzzzzzu_(Patient BirthDate)
            {
                Patient kzzzzzzy_ = this.Patient(context);
                Date kzzzzzzz_ = kzzzzzzy_?.BirthDateElement;
                string lzzzzzza_ = kzzzzzzz_?.Value;
                CqlDateTime lzzzzzzb_ = context.Operators.ConvertStringToDateTime(lzzzzzza_);
                Period lzzzzzzc_ = AllStrokeEncounter?.Period;
                CqlInterval<CqlDateTime> lzzzzzzd_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, lzzzzzzc_);
                CqlDateTime lzzzzzze_ = context.Operators.Start(lzzzzzzd_);
                int? lzzzzzzf_ = context.Operators.CalculateAgeAt(lzzzzzzb_, lzzzzzze_, "year");
                bool? lzzzzzzg_ = context.Operators.GreaterOrEqual(lzzzzzzf_, 18);

                return lzzzzzzg_;
            };
            IEnumerable<Patient> kzzzzzzv_ = context.Operators.Where<Patient>(kzzzzzzt_, kzzzzzzu_);
            Encounter kzzzzzzw_(Patient BirthDate) =>
                AllStrokeEncounter;
            IEnumerable<Encounter> kzzzzzzx_ = context.Operators.Select<Patient, Encounter>(kzzzzzzv_, kzzzzzzw_);

            return kzzzzzzx_;
        };
        IEnumerable<Encounter> kzzzzzzs_ = context.Operators.SelectMany<Encounter, Encounter>(kzzzzzzq_, kzzzzzzr_);

        return kzzzzzzs_;
    }


    [CqlExpressionDefinition("Ischemic Stroke Encounter")]
    public IEnumerable<Encounter> Ischemic_Stroke_Encounter(CqlContext context)
    {
        IEnumerable<Encounter> lzzzzzzh_ = this.Encounter_with_Principal_Diagnosis_and_Age(context);
        bool? lzzzzzzi_(Encounter EncounterWithAge)
        {
            Condition lzzzzzzk_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.PrincipalDiagnosis(context, EncounterWithAge);
            CodeableConcept lzzzzzzl_ = lzzzzzzk_?.Code;
            CqlConcept lzzzzzzm_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, lzzzzzzl_);
            CqlValueSet lzzzzzzn_ = this.Ischemic_Stroke(context);
            bool? lzzzzzzo_ = context.Operators.ConceptInValueSet(lzzzzzzm_, lzzzzzzn_);

            return lzzzzzzo_;
        };
        IEnumerable<Encounter> lzzzzzzj_ = context.Operators.Where<Encounter>(lzzzzzzh_, lzzzzzzi_);

        return lzzzzzzj_;
    }


    [CqlExpressionDefinition("Ischemic Stroke Encounters with Discharge Disposition")]
    public IEnumerable<Encounter> Ischemic_Stroke_Encounters_with_Discharge_Disposition(CqlContext context)
    {
        IEnumerable<Encounter> lzzzzzzp_ = this.Ischemic_Stroke_Encounter(context);
        bool? lzzzzzzq_(Encounter IschemicStrokeEncounter)
        {
            Encounter.HospitalizationComponent lzzzzzzs_ = IschemicStrokeEncounter?.Hospitalization;
            CodeableConcept lzzzzzzt_ = lzzzzzzs_?.DischargeDisposition;
            CqlConcept lzzzzzzu_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, lzzzzzzt_);
            CqlValueSet lzzzzzzv_ = this.Discharge_To_Acute_Care_Facility(context);
            bool? lzzzzzzw_ = context.Operators.ConceptInValueSet(lzzzzzzu_, lzzzzzzv_);
            CodeableConcept lzzzzzzy_ = lzzzzzzs_?.DischargeDisposition;
            CqlConcept lzzzzzzz_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, lzzzzzzy_);
            CqlValueSet mzzzzzza_ = this.Left_Against_Medical_Advice(context);
            bool? mzzzzzzb_ = context.Operators.ConceptInValueSet(lzzzzzzz_, mzzzzzza_);
            bool? mzzzzzzc_ = context.Operators.Or(lzzzzzzw_, mzzzzzzb_);
            CodeableConcept mzzzzzze_ = lzzzzzzs_?.DischargeDisposition;
            CqlConcept mzzzzzzf_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, mzzzzzze_);
            CqlValueSet mzzzzzzg_ = this.Patient_Expired(context);
            bool? mzzzzzzh_ = context.Operators.ConceptInValueSet(mzzzzzzf_, mzzzzzzg_);
            bool? mzzzzzzi_ = context.Operators.Or(mzzzzzzc_, mzzzzzzh_);
            CodeableConcept mzzzzzzk_ = lzzzzzzs_?.DischargeDisposition;
            CqlConcept mzzzzzzl_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, mzzzzzzk_);
            CqlValueSet mzzzzzzm_ = this.Discharged_to_Home_for_Hospice_Care(context);
            bool? mzzzzzzn_ = context.Operators.ConceptInValueSet(mzzzzzzl_, mzzzzzzm_);
            bool? mzzzzzzo_ = context.Operators.Or(mzzzzzzi_, mzzzzzzn_);
            CodeableConcept mzzzzzzq_ = lzzzzzzs_?.DischargeDisposition;
            CqlConcept mzzzzzzr_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, mzzzzzzq_);
            CqlValueSet mzzzzzzs_ = this.Discharged_to_Health_Care_Facility_for_Hospice_Care(context);
            bool? mzzzzzzt_ = context.Operators.ConceptInValueSet(mzzzzzzr_, mzzzzzzs_);
            bool? mzzzzzzu_ = context.Operators.Or(mzzzzzzo_, mzzzzzzt_);

            return mzzzzzzu_;
        };
        IEnumerable<Encounter> lzzzzzzr_ = context.Operators.Where<Encounter>(lzzzzzzp_, lzzzzzzq_);

        return lzzzzzzr_;
    }


    [CqlExpressionDefinition("Intervention Comfort Measures")]
    public IEnumerable<object> Intervention_Comfort_Measures(CqlContext context)
    {
        CqlValueSet mzzzzzzv_ = this.Comfort_Measures(context);
        IEnumerable<ServiceRequest> mzzzzzzw_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, mzzzzzzv_, default, "http://hl7.org/fhir/StructureDefinition/ServiceRequest"));
        bool? mzzzzzzx_(ServiceRequest P)
        {
            Code<RequestIntent> nzzzzzze_ = P?.IntentElement;
            string nzzzzzzf_ = FHIRHelpers_4_0_001.Instance.ToString(context, nzzzzzze_);
            bool? nzzzzzzg_ = context.Operators.Equal(nzzzzzzf_, "order");

            return nzzzzzzg_;
        };
        IEnumerable<ServiceRequest> mzzzzzzy_ = context.Operators.Where<ServiceRequest>(mzzzzzzw_, mzzzzzzx_);
        IEnumerable<Procedure> nzzzzzza_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, mzzzzzzv_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? nzzzzzzb_(Procedure InterventionPerformed)
        {
            Code<EventStatus> nzzzzzzh_ = InterventionPerformed?.StatusElement;
            string nzzzzzzi_ = FHIRHelpers_4_0_001.Instance.ToString(context, nzzzzzzh_);
            string[] nzzzzzzj_ = [
                "completed",
                "in-progress",
            ];
            bool? nzzzzzzk_ = context.Operators.In<string>(nzzzzzzi_, nzzzzzzj_ as IEnumerable<string>);

            return nzzzzzzk_;
        };
        IEnumerable<Procedure> nzzzzzzc_ = context.Operators.Where<Procedure>(nzzzzzza_, nzzzzzzb_);
        IEnumerable<object> nzzzzzzd_ = context.Operators.Union<object>(mzzzzzzy_ as IEnumerable<object>, nzzzzzzc_ as IEnumerable<object>);

        return nzzzzzzd_;
    }


    [CqlExpressionDefinition("Comfort Measures during Hospitalization")]
    public IEnumerable<Encounter> Comfort_Measures_during_Hospitalization(CqlContext context)
    {
        IEnumerable<Encounter> nzzzzzzl_ = this.Ischemic_Stroke_Encounter(context);
        IEnumerable<Encounter> nzzzzzzm_(Encounter IschemicStrokeEncounter)
        {
            IEnumerable<object> nzzzzzzo_ = this.Intervention_Comfort_Measures(context);
            bool? nzzzzzzp_(object ComfortMeasure)
            {
                object nzzzzzzt_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                FhirDateTime nzzzzzzu_ = context.Operators.LateBoundProperty<FhirDateTime>(ComfortMeasure, "authoredOn");
                CqlDateTime nzzzzzzv_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, (nzzzzzzt_ as FhirDateTime) ?? nzzzzzzu_);
                CqlInterval<CqlDateTime> nzzzzzzw_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.HospitalizationWithObservation(context, IschemicStrokeEncounter);
                bool? nzzzzzzx_ = context.Operators.In<CqlDateTime>(nzzzzzzv_, nzzzzzzw_, default);

                return nzzzzzzx_;
            };
            IEnumerable<object> nzzzzzzq_ = context.Operators.Where<object>(nzzzzzzo_, nzzzzzzp_);
            Encounter nzzzzzzr_(object ComfortMeasure) =>
                IschemicStrokeEncounter;
            IEnumerable<Encounter> nzzzzzzs_ = context.Operators.Select<object, Encounter>(nzzzzzzq_, nzzzzzzr_);

            return nzzzzzzs_;
        };
        IEnumerable<Encounter> nzzzzzzn_ = context.Operators.SelectMany<Encounter, Encounter>(nzzzzzzl_, nzzzzzzm_);

        return nzzzzzzn_;
    }


    [CqlExpressionDefinition("Encounter with Comfort Measures during Hospitalization")]
    public IEnumerable<Encounter> Encounter_with_Comfort_Measures_during_Hospitalization(CqlContext context)
    {
        IEnumerable<Encounter> nzzzzzzy_ = this.Ischemic_Stroke_Encounter(context);
        IEnumerable<Encounter> nzzzzzzz_(Encounter IschemicStrokeEncounter)
        {
            IEnumerable<object> ozzzzzzb_ = this.Intervention_Comfort_Measures(context);
            bool? ozzzzzzc_(object ComfortMeasure)
            {
                object ozzzzzzg_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                CqlInterval<CqlDateTime> ozzzzzzh_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, ozzzzzzg_);
                CqlDateTime ozzzzzzi_ = context.Operators.Start(ozzzzzzh_);
                FhirDateTime ozzzzzzj_ = context.Operators.LateBoundProperty<FhirDateTime>(ComfortMeasure, "authoredOn");
                CqlDateTime ozzzzzzk_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, ozzzzzzj_);
                CqlInterval<CqlDateTime> ozzzzzzl_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.HospitalizationWithObservation(context, IschemicStrokeEncounter);
                bool? ozzzzzzm_ = context.Operators.In<CqlDateTime>(ozzzzzzi_ ?? ozzzzzzk_, ozzzzzzl_, default);

                return ozzzzzzm_;
            };
            IEnumerable<object> ozzzzzzd_ = context.Operators.Where<object>(ozzzzzzb_, ozzzzzzc_);
            Encounter ozzzzzze_(object ComfortMeasure) =>
                IschemicStrokeEncounter;
            IEnumerable<Encounter> ozzzzzzf_ = context.Operators.Select<object, Encounter>(ozzzzzzd_, ozzzzzze_);

            return ozzzzzzf_;
        };
        IEnumerable<Encounter> ozzzzzza_ = context.Operators.SelectMany<Encounter, Encounter>(nzzzzzzy_, nzzzzzzz_);

        return ozzzzzza_;
    }


    [CqlExpressionDefinition("CalendarDayOfOrDayAfter")]
    public CqlInterval<CqlDate> CalendarDayOfOrDayAfter(CqlContext context, CqlDateTime StartValue)
    {
        CqlDate ozzzzzzn_ = context.Operators.DateFrom(StartValue);
        CqlQuantity ozzzzzzo_ = context.Operators.Quantity(1m, "day");
        CqlDateTime ozzzzzzp_ = context.Operators.Add(StartValue, ozzzzzzo_);
        CqlDate ozzzzzzq_ = context.Operators.DateFrom(ozzzzzzp_);
        CqlInterval<CqlDate> ozzzzzzr_ = context.Operators.Interval(ozzzzzzn_, ozzzzzzq_, true, true);

        return ozzzzzzr_;
    }


    #endregion Expressions

}
