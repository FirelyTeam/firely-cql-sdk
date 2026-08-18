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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.3.5.0")]
[CqlLibrary("TJCOverall", "8.25.000")]
public partial class TJCOverall_8_25_000 : ILibrary, ISingleton<TJCOverall_8_25_000>
{
    #region ValueSets (8)

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

    #region Parameters (1)

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute);

    private const long _cacheIndex_Measurement_Period = 5065781295884409926L;

    private CqlInterval<CqlDateTime> Measurement_Period_Compute(CqlContext context)
    {
        object a_ = context.ResolveParameter("TJCOverall-8.25.000", "Measurement Period", (object)null);
        return (CqlInterval<CqlDateTime>)a_;
    }


    #endregion Parameters

    #region Functions and Expressions (7)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = -7914836517776615362L;

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("Non Elective Inpatient Encounter With Age")]
    public IEnumerable<Encounter> Non_Elective_Inpatient_Encounter_With_Age(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Non_Elective_Inpatient_Encounter_With_Age, Non_Elective_Inpatient_Encounter_With_Age_Compute);

    private const long _cacheIndex_Non_Elective_Inpatient_Encounter_With_Age = -5301151410846989508L;

    private IEnumerable<Encounter> Non_Elective_Inpatient_Encounter_With_Age_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Nonelective_Inpatient_Encounter(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

        bool? c_(Encounter NonElectiveEncounter) {
            Patient e_ = this.Patient(context);
            Date f_ = e_?.BirthDateElement;
            string g_ = f_?.Value;
            CqlDate h_ = context.Operators.ConvertStringToDate(g_);
            Period i_ = NonElectiveEncounter?.Period;
            CqlInterval<CqlDateTime> j_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, i_);
            CqlDateTime k_ = context.Operators.Start(j_);
            CqlDate l_ = context.Operators.DateFrom(k_);
            int? m_ = context.Operators.CalculateAgeAt(h_, l_, "year");
            CqlBoolean n_ = context.Operators.GreaterOrEqual(m_, 18);

            CqlBoolean o_() {
                Period p_ = NonElectiveEncounter?.Period;
                CqlInterval<CqlDateTime> q_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, p_);
                CqlDateTime r_ = context.Operators.End(q_);
                CqlInterval<CqlDateTime> s_ = this.Measurement_Period(context);
                CqlBoolean t_ = context.Operators.In<CqlDateTime>(r_, s_, "day");
                return t_;
            }

            return n_
                /* CQL 'and' (25:9-26:80) */ && o_();
        }

        IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Ischemic Stroke Encounter")]
    public IEnumerable<Encounter> Ischemic_Stroke_Encounter(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Ischemic_Stroke_Encounter, Ischemic_Stroke_Encounter_Compute);

    private const long _cacheIndex_Ischemic_Stroke_Encounter = -6504890826907683419L;

    private IEnumerable<Encounter> Ischemic_Stroke_Encounter_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Non_Elective_Inpatient_Encounter_With_Age(context);

        bool? b_(Encounter NonElectiveEncounterWithAge) {
            CqlValueSet d_ = this.Ischemic_Stroke(context);
            CqlBoolean e_ = CQMCommon_4_1_000.Instance.hasPrincipalDiagnosisOf(context, NonElectiveEncounterWithAge, d_);
            return e_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Ischemic Stroke Encounters With Discharge Disposition")]
    public IEnumerable<Encounter> Ischemic_Stroke_Encounters_With_Discharge_Disposition(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Ischemic_Stroke_Encounters_With_Discharge_Disposition, Ischemic_Stroke_Encounters_With_Discharge_Disposition_Compute);

    private const long _cacheIndex_Ischemic_Stroke_Encounters_With_Discharge_Disposition = -504688316559473445L;

    private IEnumerable<Encounter> Ischemic_Stroke_Encounters_With_Discharge_Disposition_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Ischemic_Stroke_Encounter(context);

        bool? b_(Encounter IschemicStrokeEncounter) {
            Encounter.HospitalizationComponent d_ = IschemicStrokeEncounter?.Hospitalization;
            CodeableConcept e_ = d_?.DischargeDisposition;
            CqlConcept f_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, e_);
            CqlValueSet g_ = this.Discharge_To_Acute_Care_Facility(context);
            CqlBoolean h_ = context.Operators.ConceptInValueSet(f_, g_);

            CqlBoolean i_() {
                Encounter.HospitalizationComponent m_ = IschemicStrokeEncounter?.Hospitalization;
                CodeableConcept n_ = m_?.DischargeDisposition;
                CqlConcept o_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, n_);
                CqlValueSet p_ = this.Left_Against_Medical_Advice(context);
                CqlBoolean q_ = context.Operators.ConceptInValueSet(o_, p_);
                return q_;
            }


            CqlBoolean j_() {
                Encounter.HospitalizationComponent r_ = IschemicStrokeEncounter?.Hospitalization;
                CodeableConcept s_ = r_?.DischargeDisposition;
                CqlConcept t_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, s_);
                CqlValueSet u_ = this.Patient_Expired(context);
                CqlBoolean v_ = context.Operators.ConceptInValueSet(t_, u_);
                return v_;
            }


            CqlBoolean k_() {
                Encounter.HospitalizationComponent w_ = IschemicStrokeEncounter?.Hospitalization;
                CodeableConcept x_ = w_?.DischargeDisposition;
                CqlConcept y_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, x_);
                CqlValueSet z_ = this.Discharged_to_Home_for_Hospice_Care(context);
                CqlBoolean aa_ = context.Operators.ConceptInValueSet(y_, z_);
                return aa_;
            }


            CqlBoolean l_() {
                Encounter.HospitalizationComponent ab_ = IschemicStrokeEncounter?.Hospitalization;
                CodeableConcept ac_ = ab_?.DischargeDisposition;
                CqlConcept ad_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ac_);
                CqlValueSet ae_ = this.Discharged_to_Health_Care_Facility_for_Hospice_Care(context);
                CqlBoolean af_ = context.Operators.ConceptInValueSet(ad_, ae_);
                return af_;
            }

            return h_
                /* CQL 'or' (35:11-36:47) */ || i_()
                /* CQL 'or' (35:11-37:35) */ || j_()
                /* CQL 'or' (35:11-38:55) */ || k_()
                /* CQL 'or' (35:4-39:71) */ || l_();
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Intervention Comfort Measures")]
    public IEnumerable<object> Intervention_Comfort_Measures(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Intervention_Comfort_Measures, Intervention_Comfort_Measures_Compute);

    private const long _cacheIndex_Intervention_Comfort_Measures = 8089168431957467543L;

    private IEnumerable<object> Intervention_Comfort_Measures_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Comfort_Measures(context);
        IEnumerable<ServiceRequest> b_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));

        bool? c_(ServiceRequest ComfortCare) {
            Code<RequestStatus> i_ = ComfortCare?.StatusElement;
            RequestStatus? j_ = i_?.Value;
            Code<RequestStatus> k_ = context.Operators.Convert<Code<RequestStatus>>(j_);
            string l_ = context.Operators.Convert<string>(k_);
            string[] m_ = [
                "active",
                "completed",
                "on-hold",
            ];
            CqlBoolean n_ = context.Operators.In<string>(l_, (IEnumerable<string>)m_);

            CqlBoolean o_() {
                Code<RequestIntent> p_ = ComfortCare?.IntentElement;
                RequestIntent? q_ = p_?.Value;
                Code<RequestIntent> r_ = context.Operators.Convert<Code<RequestIntent>>(q_);
                string s_ = context.Operators.Convert<string>(r_);
                string[] t_ = [
                    "order",
                    "original-order",
                    "reflex-order",
                    "filler-order",
                    "instance-order",
                ];
                CqlBoolean u_ = context.Operators.In<string>(s_, (IEnumerable<string>)t_);
                return u_;
            }

            return n_
                /* CQL 'and' (48:5-49:111) */ && o_();
        }

        IEnumerable<ServiceRequest> d_ = context.Operators.Where<ServiceRequest>(b_, c_);
        IEnumerable<Procedure> e_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

        bool? f_(Procedure ComfortCarePerformed) {
            Code<EventStatus> v_ = ComfortCarePerformed?.StatusElement;
            EventStatus? w_ = v_?.Value;
            string x_ = context.Operators.Convert<string>(w_);
            string[] y_ = [
                "completed",
                "in-progress",
            ];
            CqlBoolean z_ = context.Operators.In<string>(x_, (IEnumerable<string>)y_);
            return z_;
        }

        IEnumerable<Procedure> g_ = context.Operators.Where<Procedure>(e_, f_);
        IEnumerable<object> h_ = context.Operators.Union<object>(d_ as IEnumerable<object>, g_ as IEnumerable<object>);
        return h_;
    }


    [CqlExpressionDefinition("Encounter With Comfort Measures During Hospitalization")]
    public IEnumerable<Encounter> Encounter_With_Comfort_Measures_During_Hospitalization(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_Comfort_Measures_During_Hospitalization, Encounter_With_Comfort_Measures_During_Hospitalization_Compute);

    private const long _cacheIndex_Encounter_With_Comfort_Measures_During_Hospitalization = 8391212529694341440L;

    private IEnumerable<Encounter> Encounter_With_Comfort_Measures_During_Hospitalization_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Ischemic_Stroke_Encounter(context);

        bool? b_(Encounter IschemicStrokeEncounter) {
            IEnumerable<object> d_ = this.Intervention_Comfort_Measures(context);

            bool? e_(object ComfortMeasure) {
                object g_;
                object n_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                object o_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
                bool p_ = o_ is CqlDateTime;
                if (p_)
                {
                    g_ = o_ as CqlDateTime;
                }
                else
                {
                    bool q_ = o_ is CqlQuantity;
                    if (q_)
                    {
                        g_ = o_ as CqlQuantity;
                    }
                    else
                    {
                        bool r_ = o_ is CqlInterval<CqlDateTime>;
                        if (r_)
                        {
                            g_ = o_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool s_ = o_ is CqlInterval<CqlQuantity>;
                            if (s_)
                            {
                                g_ = o_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                g_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> h_ = QICoreCommon_4_0_000.Instance.toInterval(context, g_);
                CqlDateTime i_ = context.Operators.Start(h_);
                object j_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "authoredOn");
                CqlDateTime k_ = context.Operators.LateBoundProperty<CqlDateTime>(j_, "value");
                CqlInterval<CqlDateTime> l_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, IschemicStrokeEncounter);
                CqlBoolean m_ = context.Operators.In<CqlDateTime>(i_ ?? k_, l_, (string)default);
                return m_;
            }

            CqlBoolean f_ = context.Operators.WhereAny<object>(d_, e_);
            return f_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlFunctionDefinition("calendarDayOfOrDayAfter")]
    public CqlInterval<CqlDate> calendarDayOfOrDayAfter(CqlContext context, CqlDateTime StartValue)
    {
        CqlDate a_ = context.Operators.DateFrom(StartValue);
        CqlQuantity b_ = context.Operators.Quantity(1m, "day");
        CqlDate c_ = context.Operators.Add(a_, b_);
        CqlInterval<CqlDate> d_ = context.Operators.Interval(a_, c_, true, true);
        return d_;
    }


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private TJCOverall_8_25_000() {}

    public static TJCOverall_8_25_000 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "TJCOverall";
    public string Version => "8.25.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, CQMCommon_4_1_000.Instance, QICoreCommon_4_0_000.Instance, SupplementalDataElements_5_1_000.Instance];

    #endregion ILibrary Implementation

}
