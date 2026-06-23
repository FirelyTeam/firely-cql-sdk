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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.1.2.0")]
[CqlLibrary("TJCOverallFHIR", "1.8.000")]
public partial class TJCOverallFHIR_1_8_000 : ILibrary, ISingleton<TJCOverallFHIR_1_8_000>
{
    #region ValueSets (13)

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

    #region Codes (1)

    [CqlCodeDefinition("Birth date", codeId: "21112-8", codeSystem: "http://loinc.org")]
    public CqlCode Birth_date(CqlContext _) => _Birth_date;
    private static readonly CqlCode _Birth_date = new CqlCode("21112-8", "http://loinc.org");

    #endregion Codes

    #region CodeSystems (1)

    [CqlCodeSystemDefinition("LOINC", codeSystemId: "http://loinc.org", codeSystemVersion: null)]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC =
      new CqlCodeSystem("http://loinc.org", null, [
          _Birth_date]);

    #endregion CodeSystems

    #region Parameters (1)

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute);

    private const long _cacheIndex_Measurement_Period = 6905366931702746391L;

    private CqlInterval<CqlDateTime> Measurement_Period_Compute(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2019, 1, 1, 0, 0, 0, 0, (decimal?)default);
        CqlDateTime b_ = context.Operators.DateTime(2020, 1, 1, 0, 0, 0, 0, (decimal?)default);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
        object d_ = context.ResolveParameter("TJCOverallFHIR-1.8.000", "Measurement Period", c_);
        return (CqlInterval<CqlDateTime>)d_;
    }


    #endregion Parameters

    #region Functions and Expressions (10)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = -527641375573182733L;

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("Non Elective Inpatient Encounter")]
    public IEnumerable<Encounter> Non_Elective_Inpatient_Encounter(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Non_Elective_Inpatient_Encounter, Non_Elective_Inpatient_Encounter_Compute);

    private const long _cacheIndex_Non_Elective_Inpatient_Encounter = -6514317087613886639L;

    private IEnumerable<Encounter> Non_Elective_Inpatient_Encounter_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Non_Elective_Inpatient(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));

        bool? c_(Encounter NonElectiveEncounter) {
            Period e_ = NonElectiveEncounter?.Period;
            CqlInterval<CqlDateTime> f_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, e_);
            int? g_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.LengthInDays(context, f_);
            bool? h_ = context.Operators.LessOrEqual(g_, 120);
            CqlInterval<CqlDateTime> j_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, e_);
            CqlDateTime k_ = context.Operators.End(j_);
            CqlInterval<CqlDateTime> l_ = this.Measurement_Period(context);
            bool? m_ = context.Operators.In<CqlDateTime>(k_, l_, "day");
            bool? n_ = context.Operators.And(h_, m_);
            return n_;
        }

        IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("All Stroke Encounter")]
    public IEnumerable<Encounter> All_Stroke_Encounter(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_All_Stroke_Encounter, All_Stroke_Encounter_Compute);

    private const long _cacheIndex_All_Stroke_Encounter = 9081602270573019451L;

    private IEnumerable<Encounter> All_Stroke_Encounter_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Non_Elective_Inpatient_Encounter(context);

        bool? b_(Encounter NonElectiveEncounter) {
            Condition d_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.PrincipalDiagnosis(context, NonElectiveEncounter);
            CodeableConcept e_ = d_?.Code;
            CqlConcept f_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, e_);
            CqlValueSet g_ = this.Hemorrhagic_Stroke(context);
            bool? h_ = context.Operators.ConceptInValueSet(f_, g_);
            CodeableConcept j_ = d_?.Code;
            CqlConcept k_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, j_);
            CqlValueSet l_ = this.Ischemic_Stroke(context);
            bool? m_ = context.Operators.ConceptInValueSet(k_, l_);
            bool? n_ = context.Operators.Or(h_, m_);
            return n_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Encounter with Principal Diagnosis and Age")]
    public IEnumerable<Encounter> Encounter_with_Principal_Diagnosis_and_Age(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_with_Principal_Diagnosis_and_Age, Encounter_with_Principal_Diagnosis_and_Age_Compute);

    private const long _cacheIndex_Encounter_with_Principal_Diagnosis_and_Age = 8314958543275766337L;

    private IEnumerable<Encounter> Encounter_with_Principal_Diagnosis_and_Age_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.All_Stroke_Encounter(context);

        IEnumerable<Encounter> b_(Encounter AllStrokeEncounter) {
            IEnumerable<Patient> d_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));

            bool? e_(Patient BirthDate) {
                Patient i_ = this.Patient(context);
                Date j_ = i_?.BirthDateElement;
                string k_ = j_?.Value;
                CqlDateTime l_ = context.Operators.ConvertStringToDateTime(k_);
                Period m_ = AllStrokeEncounter?.Period;
                CqlInterval<CqlDateTime> n_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, m_);
                CqlDateTime o_ = context.Operators.Start(n_);
                int? p_ = context.Operators.CalculateAgeAt(l_, o_, "year");
                bool? q_ = context.Operators.GreaterOrEqual(p_, 18);
                return q_;
            }

            IEnumerable<Patient> f_ = context.Operators.Where<Patient>(d_, e_);
            Encounter g_(Patient BirthDate) => AllStrokeEncounter;
            IEnumerable<Encounter> h_ = context.Operators.Select<Patient, Encounter>(f_, g_);
            return h_;
        }

        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Ischemic Stroke Encounter")]
    public IEnumerable<Encounter> Ischemic_Stroke_Encounter(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Ischemic_Stroke_Encounter, Ischemic_Stroke_Encounter_Compute);

    private const long _cacheIndex_Ischemic_Stroke_Encounter = 3386773370828368879L;

    private IEnumerable<Encounter> Ischemic_Stroke_Encounter_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_with_Principal_Diagnosis_and_Age(context);

        bool? b_(Encounter EncounterWithAge) {
            Condition d_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.PrincipalDiagnosis(context, EncounterWithAge);
            CodeableConcept e_ = d_?.Code;
            CqlConcept f_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, e_);
            CqlValueSet g_ = this.Ischemic_Stroke(context);
            bool? h_ = context.Operators.ConceptInValueSet(f_, g_);
            return h_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Ischemic Stroke Encounters with Discharge Disposition")]
    public IEnumerable<Encounter> Ischemic_Stroke_Encounters_with_Discharge_Disposition(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Ischemic_Stroke_Encounters_with_Discharge_Disposition, Ischemic_Stroke_Encounters_with_Discharge_Disposition_Compute);

    private const long _cacheIndex_Ischemic_Stroke_Encounters_with_Discharge_Disposition = -3331621253114112533L;

    private IEnumerable<Encounter> Ischemic_Stroke_Encounters_with_Discharge_Disposition_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Ischemic_Stroke_Encounter(context);

        bool? b_(Encounter IschemicStrokeEncounter) {
            Encounter.HospitalizationComponent d_ = IschemicStrokeEncounter?.Hospitalization;
            CodeableConcept e_ = d_?.DischargeDisposition;
            CqlConcept f_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, e_);
            CqlValueSet g_ = this.Discharge_To_Acute_Care_Facility(context);
            bool? h_ = context.Operators.ConceptInValueSet(f_, g_);
            CodeableConcept j_ = d_?.DischargeDisposition;
            CqlConcept k_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, j_);
            CqlValueSet l_ = this.Left_Against_Medical_Advice(context);
            bool? m_ = context.Operators.ConceptInValueSet(k_, l_);
            bool? n_ = context.Operators.Or(h_, m_);
            CodeableConcept p_ = d_?.DischargeDisposition;
            CqlConcept q_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, p_);
            CqlValueSet r_ = this.Patient_Expired(context);
            bool? s_ = context.Operators.ConceptInValueSet(q_, r_);
            bool? t_ = context.Operators.Or(n_, s_);
            CodeableConcept v_ = d_?.DischargeDisposition;
            CqlConcept w_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, v_);
            CqlValueSet x_ = this.Discharged_to_Home_for_Hospice_Care(context);
            bool? y_ = context.Operators.ConceptInValueSet(w_, x_);
            bool? z_ = context.Operators.Or(t_, y_);
            CodeableConcept ab_ = d_?.DischargeDisposition;
            CqlConcept ac_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, ab_);
            CqlValueSet ad_ = this.Discharged_to_Health_Care_Facility_for_Hospice_Care(context);
            bool? ae_ = context.Operators.ConceptInValueSet(ac_, ad_);
            bool? af_ = context.Operators.Or(z_, ae_);
            return af_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Intervention Comfort Measures")]
    public IEnumerable<object> Intervention_Comfort_Measures(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Intervention_Comfort_Measures, Intervention_Comfort_Measures_Compute);

    private const long _cacheIndex_Intervention_Comfort_Measures = -541982402983301016L;

    private IEnumerable<object> Intervention_Comfort_Measures_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Comfort_Measures(context);
        IEnumerable<ServiceRequest> b_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/ServiceRequest"));

        bool? c_(ServiceRequest P) {
            Code<RequestIntent> j_ = P?.IntentElement;
            string k_ = FHIRHelpers_4_0_001.Instance.ToString(context, j_);
            bool? l_ = context.Operators.Equal(k_, "order");
            return l_;
        }

        IEnumerable<ServiceRequest> d_ = context.Operators.Where<ServiceRequest>(b_, c_);
        IEnumerable<Procedure> f_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));

        bool? g_(Procedure InterventionPerformed) {
            Code<EventStatus> m_ = InterventionPerformed?.StatusElement;
            string n_ = FHIRHelpers_4_0_001.Instance.ToString(context, m_);
            string[] o_ = [
                "completed",
                "in-progress",
            ];
            bool? p_ = context.Operators.In<string>(n_, (IEnumerable<string>)o_);
            return p_;
        }

        IEnumerable<Procedure> h_ = context.Operators.Where<Procedure>(f_, g_);
        IEnumerable<object> i_ = context.Operators.Union<object>(d_ as IEnumerable<object>, h_ as IEnumerable<object>);
        return i_;
    }


    [CqlExpressionDefinition("Comfort Measures during Hospitalization")]
    public IEnumerable<Encounter> Comfort_Measures_during_Hospitalization(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Comfort_Measures_during_Hospitalization, Comfort_Measures_during_Hospitalization_Compute);

    private const long _cacheIndex_Comfort_Measures_during_Hospitalization = -8966607307601606654L;

    private IEnumerable<Encounter> Comfort_Measures_during_Hospitalization_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Ischemic_Stroke_Encounter(context);

        IEnumerable<Encounter> b_(Encounter IschemicStrokeEncounter) {
            IEnumerable<object> d_ = this.Intervention_Comfort_Measures(context);

            bool? e_(object ComfortMeasure) {
                object i_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                FhirDateTime j_ = context.Operators.LateBoundProperty<FhirDateTime>(ComfortMeasure, "authoredOn");
                CqlDateTime k_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, (i_ as FhirDateTime) ?? j_);
                CqlInterval<CqlDateTime> l_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.HospitalizationWithObservation(context, IschemicStrokeEncounter);
                bool? m_ = context.Operators.In<CqlDateTime>(k_, l_, (string)default);
                return m_;
            }

            IEnumerable<object> f_ = context.Operators.Where<object>(d_, e_);
            Encounter g_(object ComfortMeasure) => IschemicStrokeEncounter;
            IEnumerable<Encounter> h_ = context.Operators.Select<object, Encounter>(f_, g_);
            return h_;
        }

        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Encounter with Comfort Measures during Hospitalization")]
    public IEnumerable<Encounter> Encounter_with_Comfort_Measures_during_Hospitalization(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_with_Comfort_Measures_during_Hospitalization, Encounter_with_Comfort_Measures_during_Hospitalization_Compute);

    private const long _cacheIndex_Encounter_with_Comfort_Measures_during_Hospitalization = -8352941911875374690L;

    private IEnumerable<Encounter> Encounter_with_Comfort_Measures_during_Hospitalization_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Ischemic_Stroke_Encounter(context);

        IEnumerable<Encounter> b_(Encounter IschemicStrokeEncounter) {
            IEnumerable<object> d_ = this.Intervention_Comfort_Measures(context);

            bool? e_(object ComfortMeasure) {
                object i_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                CqlInterval<CqlDateTime> j_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, i_);
                CqlDateTime k_ = context.Operators.Start(j_);
                FhirDateTime l_ = context.Operators.LateBoundProperty<FhirDateTime>(ComfortMeasure, "authoredOn");
                CqlDateTime m_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, l_);
                CqlInterval<CqlDateTime> n_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.HospitalizationWithObservation(context, IschemicStrokeEncounter);
                bool? o_ = context.Operators.In<CqlDateTime>(k_ ?? m_, n_, (string)default);
                return o_;
            }

            IEnumerable<object> f_ = context.Operators.Where<object>(d_, e_);
            Encounter g_(object ComfortMeasure) => IschemicStrokeEncounter;
            IEnumerable<Encounter> h_ = context.Operators.Select<object, Encounter>(f_, g_);
            return h_;
        }

        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
        return c_;
    }


    [CqlFunctionDefinition("CalendarDayOfOrDayAfter")]
    public CqlInterval<CqlDate> CalendarDayOfOrDayAfter(CqlContext context, CqlDateTime StartValue)
    {
        CqlDate a_ = context.Operators.DateFrom(StartValue);
        CqlQuantity b_ = context.Operators.Quantity(1m, "day");
        CqlDateTime c_ = context.Operators.Add(StartValue, b_);
        CqlDate d_ = context.Operators.DateFrom(c_);
        CqlInterval<CqlDate> e_ = context.Operators.Interval(a_, d_, true, true);
        return e_;
    }


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private TJCOverallFHIR_1_8_000() {}

    public static TJCOverallFHIR_1_8_000 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "TJCOverallFHIR";
    public string Version => "1.8.000";
    public ILibrary[] Dependencies => [MATGlobalCommonFunctionsFHIR4_6_1_000.Instance, FHIRHelpers_4_0_001.Instance];

    #endregion ILibrary Implementation

}
