using System;
using System.Linq;
using System.Collections.Generic;
using Hl7.Cql.Runtime;
using Hl7.Cql.Primitives;
using Hl7.Cql.Abstractions;
using Hl7.Cql.ValueSets;
using Hl7.Cql.Iso8601;
using System.Reflection;
using Hl7.Fhir.Model;
using Range = Hl7.Fhir.Model.Range;
using Task = Hl7.Fhir.Model.Task;
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.4.0")]
[CqlLibrary("TJCOverallFHIR", "1.8.000")]
public class TJCOverallFHIR_1_8_000
{


    internal CqlContext context;

    #region Cached values

    internal Lazy<CqlValueSet> __Comfort_Measures;
    internal Lazy<CqlValueSet> __Discharge_To_Acute_Care_Facility;
    internal Lazy<CqlValueSet> __Discharged_to_Health_Care_Facility_for_Hospice_Care;
    internal Lazy<CqlValueSet> __Discharged_to_Home_for_Hospice_Care;
    internal Lazy<CqlValueSet> __Emergency_Department_Visit;
    internal Lazy<CqlValueSet> __Encounter_Inpatient;
    internal Lazy<CqlValueSet> __Hemorrhagic_Stroke;
    internal Lazy<CqlValueSet> __Ischemic_Stroke;
    internal Lazy<CqlValueSet> __Left_Against_Medical_Advice;
    internal Lazy<CqlValueSet> __Non_Elective_Inpatient;
    internal Lazy<CqlValueSet> __Observation_Services;
    internal Lazy<CqlValueSet> __Patient_Expired;
    internal Lazy<CqlValueSet> __Ticagrelor_Therapy;
    internal Lazy<CqlCode> __Birth_date;
    internal Lazy<CqlCode[]> __LOINC;
    internal Lazy<CqlInterval<CqlDateTime>> __Measurement_Period;
    internal Lazy<Patient> __Patient;
    internal Lazy<IEnumerable<Encounter>> __Non_Elective_Inpatient_Encounter;
    internal Lazy<IEnumerable<Encounter>> __All_Stroke_Encounter;
    internal Lazy<IEnumerable<Encounter>> __Encounter_with_Principal_Diagnosis_and_Age;
    internal Lazy<IEnumerable<Encounter>> __Ischemic_Stroke_Encounter;
    internal Lazy<IEnumerable<Encounter>> __Ischemic_Stroke_Encounters_with_Discharge_Disposition;
    internal Lazy<IEnumerable<object>> __Intervention_Comfort_Measures;
    internal Lazy<IEnumerable<Encounter>> __Comfort_Measures_during_Hospitalization;
    internal Lazy<IEnumerable<Encounter>> __Encounter_with_Comfort_Measures_during_Hospitalization;

    #endregion
    public TJCOverallFHIR_1_8_000(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");

        MATGlobalCommonFunctionsFHIR4_6_1_000 = new MATGlobalCommonFunctionsFHIR4_6_1_000(context);
        FHIRHelpers_4_0_001 = new FHIRHelpers_4_0_001(context);

        __Comfort_Measures = new Lazy<CqlValueSet>(this.Comfort_Measures_Value);
        __Discharge_To_Acute_Care_Facility = new Lazy<CqlValueSet>(this.Discharge_To_Acute_Care_Facility_Value);
        __Discharged_to_Health_Care_Facility_for_Hospice_Care = new Lazy<CqlValueSet>(this.Discharged_to_Health_Care_Facility_for_Hospice_Care_Value);
        __Discharged_to_Home_for_Hospice_Care = new Lazy<CqlValueSet>(this.Discharged_to_Home_for_Hospice_Care_Value);
        __Emergency_Department_Visit = new Lazy<CqlValueSet>(this.Emergency_Department_Visit_Value);
        __Encounter_Inpatient = new Lazy<CqlValueSet>(this.Encounter_Inpatient_Value);
        __Hemorrhagic_Stroke = new Lazy<CqlValueSet>(this.Hemorrhagic_Stroke_Value);
        __Ischemic_Stroke = new Lazy<CqlValueSet>(this.Ischemic_Stroke_Value);
        __Left_Against_Medical_Advice = new Lazy<CqlValueSet>(this.Left_Against_Medical_Advice_Value);
        __Non_Elective_Inpatient = new Lazy<CqlValueSet>(this.Non_Elective_Inpatient_Value);
        __Observation_Services = new Lazy<CqlValueSet>(this.Observation_Services_Value);
        __Patient_Expired = new Lazy<CqlValueSet>(this.Patient_Expired_Value);
        __Ticagrelor_Therapy = new Lazy<CqlValueSet>(this.Ticagrelor_Therapy_Value);
        __Birth_date = new Lazy<CqlCode>(this.Birth_date_Value);
        __LOINC = new Lazy<CqlCode[]>(this.LOINC_Value);
        __Measurement_Period = new Lazy<CqlInterval<CqlDateTime>>(this.Measurement_Period_Value);
        __Patient = new Lazy<Patient>(this.Patient_Value);
        __Non_Elective_Inpatient_Encounter = new Lazy<IEnumerable<Encounter>>(this.Non_Elective_Inpatient_Encounter_Value);
        __All_Stroke_Encounter = new Lazy<IEnumerable<Encounter>>(this.All_Stroke_Encounter_Value);
        __Encounter_with_Principal_Diagnosis_and_Age = new Lazy<IEnumerable<Encounter>>(this.Encounter_with_Principal_Diagnosis_and_Age_Value);
        __Ischemic_Stroke_Encounter = new Lazy<IEnumerable<Encounter>>(this.Ischemic_Stroke_Encounter_Value);
        __Ischemic_Stroke_Encounters_with_Discharge_Disposition = new Lazy<IEnumerable<Encounter>>(this.Ischemic_Stroke_Encounters_with_Discharge_Disposition_Value);
        __Intervention_Comfort_Measures = new Lazy<IEnumerable<object>>(this.Intervention_Comfort_Measures_Value);
        __Comfort_Measures_during_Hospitalization = new Lazy<IEnumerable<Encounter>>(this.Comfort_Measures_during_Hospitalization_Value);
        __Encounter_with_Comfort_Measures_during_Hospitalization = new Lazy<IEnumerable<Encounter>>(this.Encounter_with_Comfort_Measures_during_Hospitalization_Value);
    }
    #region Dependencies

    public MATGlobalCommonFunctionsFHIR4_6_1_000 MATGlobalCommonFunctionsFHIR4_6_1_000 { get; }
    public FHIRHelpers_4_0_001 FHIRHelpers_4_0_001 { get; }

    #endregion

	private CqlValueSet Comfort_Measures_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/1.3.6.1.4.1.33895.1.3.0.45", default);

    [CqlDeclaration("Comfort Measures")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/1.3.6.1.4.1.33895.1.3.0.45")]
	public CqlValueSet Comfort_Measures() => 
		__Comfort_Measures.Value;

	private CqlValueSet Discharge_To_Acute_Care_Facility_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.87", default);

    [CqlDeclaration("Discharge To Acute Care Facility")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.87")]
	public CqlValueSet Discharge_To_Acute_Care_Facility() => 
		__Discharge_To_Acute_Care_Facility.Value;

	private CqlValueSet Discharged_to_Health_Care_Facility_for_Hospice_Care_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.207", default);

    [CqlDeclaration("Discharged to Health Care Facility for Hospice Care")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.207")]
	public CqlValueSet Discharged_to_Health_Care_Facility_for_Hospice_Care() => 
		__Discharged_to_Health_Care_Facility_for_Hospice_Care.Value;

	private CqlValueSet Discharged_to_Home_for_Hospice_Care_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.209", default);

    [CqlDeclaration("Discharged to Home for Hospice Care")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.209")]
	public CqlValueSet Discharged_to_Home_for_Hospice_Care() => 
		__Discharged_to_Home_for_Hospice_Care.Value;

	private CqlValueSet Emergency_Department_Visit_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292", default);

    [CqlDeclaration("Emergency Department Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292")]
	public CqlValueSet Emergency_Department_Visit() => 
		__Emergency_Department_Visit.Value;

	private CqlValueSet Encounter_Inpatient_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", default);

    [CqlDeclaration("Encounter Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307")]
	public CqlValueSet Encounter_Inpatient() => 
		__Encounter_Inpatient.Value;

	private CqlValueSet Hemorrhagic_Stroke_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.212", default);

    [CqlDeclaration("Hemorrhagic Stroke")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.212")]
	public CqlValueSet Hemorrhagic_Stroke() => 
		__Hemorrhagic_Stroke.Value;

	private CqlValueSet Ischemic_Stroke_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.247", default);

    [CqlDeclaration("Ischemic Stroke")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.247")]
	public CqlValueSet Ischemic_Stroke() => 
		__Ischemic_Stroke.Value;

	private CqlValueSet Left_Against_Medical_Advice_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.308", default);

    [CqlDeclaration("Left Against Medical Advice")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.308")]
	public CqlValueSet Left_Against_Medical_Advice() => 
		__Left_Against_Medical_Advice.Value;

	private CqlValueSet Non_Elective_Inpatient_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.424", default);

    [CqlDeclaration("Non-Elective Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.424")]
	public CqlValueSet Non_Elective_Inpatient() => 
		__Non_Elective_Inpatient.Value;

	private CqlValueSet Observation_Services_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143", default);

    [CqlDeclaration("Observation Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143")]
	public CqlValueSet Observation_Services() => 
		__Observation_Services.Value;

	private CqlValueSet Patient_Expired_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309", default);

    [CqlDeclaration("Patient Expired")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309")]
	public CqlValueSet Patient_Expired() => 
		__Patient_Expired.Value;

	private CqlValueSet Ticagrelor_Therapy_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.39", default);

    [CqlDeclaration("Ticagrelor Therapy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.39")]
	public CqlValueSet Ticagrelor_Therapy() => 
		__Ticagrelor_Therapy.Value;

	private CqlCode Birth_date_Value() => 
		new CqlCode("21112-8", "http://loinc.org", default, default);

    [CqlDeclaration("Birth date")]
	public CqlCode Birth_date() => 
		__Birth_date.Value;

	private CqlCode[] LOINC_Value()
	{
		CqlCode[] a_ = [
			new CqlCode("21112-8", "http://loinc.org", default, default),
		];

		return a_;
	}

    [CqlDeclaration("LOINC")]
	public CqlCode[] LOINC() => 
		__LOINC.Value;

	private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		CqlDateTime a_ = context.Operators.DateTime(2019, 1, 1, 0, 0, 0, 0, default);
		CqlDateTime b_ = context.Operators.DateTime(2020, 1, 1, 0, 0, 0, 0, default);
		CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
		object d_ = context.ResolveParameter("TJCOverallFHIR-1.8.000", "Measurement Period", c_);

		return (CqlInterval<CqlDateTime>)d_;
	}

    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period() => 
		__Measurement_Period.Value;

	private Patient Patient_Value()
	{
		IEnumerable<Patient> a_ = context.Operators.RetrieveByValueSet<Patient>(default, default);
		Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient() => 
		__Patient.Value;

	private IEnumerable<Encounter> Non_Elective_Inpatient_Encounter_Value()
	{
		CqlValueSet a_ = this.Non_Elective_Inpatient();
		IEnumerable<Encounter> b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, default);
		bool? c_(Encounter NonElectiveEncounter)
		{
			Period e_ = NonElectiveEncounter?.Period;
			CqlInterval<CqlDateTime> f_ = FHIRHelpers_4_0_001.ToInterval(e_);
			int? g_ = MATGlobalCommonFunctionsFHIR4_6_1_000.LengthInDays(f_);
			bool? h_ = context.Operators.LessOrEqual(g_, 120);
			CqlInterval<CqlDateTime> j_ = FHIRHelpers_4_0_001.ToInterval(e_);
			CqlDateTime k_ = context.Operators.End(j_);
			CqlInterval<CqlDateTime> l_ = this.Measurement_Period();
			bool? m_ = context.Operators.In<CqlDateTime>(k_, l_, "day");
			bool? n_ = context.Operators.And(h_, m_);

			return n_;
		};
		IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Non Elective Inpatient Encounter")]
	public IEnumerable<Encounter> Non_Elective_Inpatient_Encounter() => 
		__Non_Elective_Inpatient_Encounter.Value;

	private IEnumerable<Encounter> All_Stroke_Encounter_Value()
	{
		IEnumerable<Encounter> a_ = this.Non_Elective_Inpatient_Encounter();
		bool? b_(Encounter NonElectiveEncounter)
		{
			Condition d_ = MATGlobalCommonFunctionsFHIR4_6_1_000.PrincipalDiagnosis(NonElectiveEncounter);
			CodeableConcept e_ = d_?.Code;
			CqlConcept f_ = FHIRHelpers_4_0_001.ToConcept(e_);
			CqlValueSet g_ = this.Hemorrhagic_Stroke();
			bool? h_ = context.Operators.ConceptInValueSet(f_, g_);
			CodeableConcept j_ = d_?.Code;
			CqlConcept k_ = FHIRHelpers_4_0_001.ToConcept(j_);
			CqlValueSet l_ = this.Ischemic_Stroke();
			bool? m_ = context.Operators.ConceptInValueSet(k_, l_);
			bool? n_ = context.Operators.Or(h_, m_);

			return n_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("All Stroke Encounter")]
	public IEnumerable<Encounter> All_Stroke_Encounter() => 
		__All_Stroke_Encounter.Value;

	private IEnumerable<Encounter> Encounter_with_Principal_Diagnosis_and_Age_Value()
	{
		IEnumerable<Encounter> a_ = this.All_Stroke_Encounter();
		IEnumerable<Encounter> b_(Encounter AllStrokeEncounter)
		{
			IEnumerable<Patient> d_ = context.Operators.RetrieveByValueSet<Patient>(default, default);
			bool? e_(Patient BirthDate)
			{
				Patient i_ = this.Patient();
				Date j_ = i_?.BirthDateElement;
				string k_ = j_?.Value;
				CqlDateTime l_ = context.Operators.ConvertStringToDateTime(k_);
				Period m_ = AllStrokeEncounter?.Period;
				CqlInterval<CqlDateTime> n_ = FHIRHelpers_4_0_001.ToInterval(m_);
				CqlDateTime o_ = context.Operators.Start(n_);
				int? p_ = context.Operators.CalculateAgeAt(l_, o_, "year");
				bool? q_ = context.Operators.GreaterOrEqual(p_, 18);

				return q_;
			};
			IEnumerable<Patient> f_ = context.Operators.Where<Patient>(d_, e_);
			Encounter g_(Patient BirthDate) => 
				AllStrokeEncounter;
			IEnumerable<Encounter> h_ = context.Operators.Select<Patient, Encounter>(f_, g_);

			return h_;
		};
		IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with Principal Diagnosis and Age")]
	public IEnumerable<Encounter> Encounter_with_Principal_Diagnosis_and_Age() => 
		__Encounter_with_Principal_Diagnosis_and_Age.Value;

	private IEnumerable<Encounter> Ischemic_Stroke_Encounter_Value()
	{
		IEnumerable<Encounter> a_ = this.Encounter_with_Principal_Diagnosis_and_Age();
		bool? b_(Encounter EncounterWithAge)
		{
			Condition d_ = MATGlobalCommonFunctionsFHIR4_6_1_000.PrincipalDiagnosis(EncounterWithAge);
			CodeableConcept e_ = d_?.Code;
			CqlConcept f_ = FHIRHelpers_4_0_001.ToConcept(e_);
			CqlValueSet g_ = this.Ischemic_Stroke();
			bool? h_ = context.Operators.ConceptInValueSet(f_, g_);

			return h_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Ischemic Stroke Encounter")]
	public IEnumerable<Encounter> Ischemic_Stroke_Encounter() => 
		__Ischemic_Stroke_Encounter.Value;

	private IEnumerable<Encounter> Ischemic_Stroke_Encounters_with_Discharge_Disposition_Value()
	{
		IEnumerable<Encounter> a_ = this.Ischemic_Stroke_Encounter();
		bool? b_(Encounter IschemicStrokeEncounter)
		{
			Encounter.HospitalizationComponent d_ = IschemicStrokeEncounter?.Hospitalization;
			CodeableConcept e_ = d_?.DischargeDisposition;
			CqlConcept f_ = FHIRHelpers_4_0_001.ToConcept(e_);
			CqlValueSet g_ = this.Discharge_To_Acute_Care_Facility();
			bool? h_ = context.Operators.ConceptInValueSet(f_, g_);
			CodeableConcept j_ = d_?.DischargeDisposition;
			CqlConcept k_ = FHIRHelpers_4_0_001.ToConcept(j_);
			CqlValueSet l_ = this.Left_Against_Medical_Advice();
			bool? m_ = context.Operators.ConceptInValueSet(k_, l_);
			bool? n_ = context.Operators.Or(h_, m_);
			CodeableConcept p_ = d_?.DischargeDisposition;
			CqlConcept q_ = FHIRHelpers_4_0_001.ToConcept(p_);
			CqlValueSet r_ = this.Patient_Expired();
			bool? s_ = context.Operators.ConceptInValueSet(q_, r_);
			bool? t_ = context.Operators.Or(n_, s_);
			CodeableConcept v_ = d_?.DischargeDisposition;
			CqlConcept w_ = FHIRHelpers_4_0_001.ToConcept(v_);
			CqlValueSet x_ = this.Discharged_to_Home_for_Hospice_Care();
			bool? y_ = context.Operators.ConceptInValueSet(w_, x_);
			bool? z_ = context.Operators.Or(t_, y_);
			CodeableConcept ab_ = d_?.DischargeDisposition;
			CqlConcept ac_ = FHIRHelpers_4_0_001.ToConcept(ab_);
			CqlValueSet ad_ = this.Discharged_to_Health_Care_Facility_for_Hospice_Care();
			bool? ae_ = context.Operators.ConceptInValueSet(ac_, ad_);
			bool? af_ = context.Operators.Or(z_, ae_);

			return af_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Ischemic Stroke Encounters with Discharge Disposition")]
	public IEnumerable<Encounter> Ischemic_Stroke_Encounters_with_Discharge_Disposition() => 
		__Ischemic_Stroke_Encounters_with_Discharge_Disposition.Value;

	private IEnumerable<object> Intervention_Comfort_Measures_Value()
	{
		CqlValueSet a_ = this.Comfort_Measures();
		IEnumerable<ServiceRequest> b_ = context.Operators.RetrieveByValueSet<ServiceRequest>(a_, default);
		bool? c_(ServiceRequest P)
		{
			Code<RequestIntent> j_ = P?.IntentElement;
			string k_ = FHIRHelpers_4_0_001.ToString(j_);
			bool? l_ = context.Operators.Equal(k_, "order");

			return l_;
		};
		IEnumerable<ServiceRequest> d_ = context.Operators.Where<ServiceRequest>(b_, c_);
		IEnumerable<Procedure> f_ = context.Operators.RetrieveByValueSet<Procedure>(a_, default);
		bool? g_(Procedure InterventionPerformed)
		{
			Code<EventStatus> m_ = InterventionPerformed?.StatusElement;
			string n_ = FHIRHelpers_4_0_001.ToString(m_);
			string[] o_ = [
				"completed",
				"in-progress",
			];
			bool? p_ = context.Operators.In<string>(n_, o_ as IEnumerable<string>);

			return p_;
		};
		IEnumerable<Procedure> h_ = context.Operators.Where<Procedure>(f_, g_);
		IEnumerable<object> i_ = context.Operators.Union<object>(d_ as IEnumerable<object>, h_ as IEnumerable<object>);

		return i_;
	}

    [CqlDeclaration("Intervention Comfort Measures")]
	public IEnumerable<object> Intervention_Comfort_Measures() => 
		__Intervention_Comfort_Measures.Value;

	private IEnumerable<Encounter> Comfort_Measures_during_Hospitalization_Value()
	{
		IEnumerable<Encounter> a_ = this.Ischemic_Stroke_Encounter();
		IEnumerable<Encounter> b_(Encounter IschemicStrokeEncounter)
		{
			IEnumerable<object> d_ = this.Intervention_Comfort_Measures();
			bool? e_(object ComfortMeasure)
			{
				object i_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
				FhirDateTime j_ = i_ switch { null => null , FhirDateTime a => a/* , Period => ???, FhirString => ???, Age => ???, Range => ??? */, _ => throw new System.Diagnostics.UnreachableException() };
				FhirDateTime k_ = context.Operators.LateBoundProperty<FhirDateTime>(ComfortMeasure, "authoredOn");
				CqlDateTime l_ = FHIRHelpers_4_0_001.ToDateTime(j_ ?? k_);
				CqlInterval<CqlDateTime> m_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(IschemicStrokeEncounter);
				bool? n_ = context.Operators.In<CqlDateTime>(l_, m_, default);

				return n_;
			};
			IEnumerable<object> f_ = context.Operators.Where<object>(d_, e_);
			Encounter g_(object ComfortMeasure) => 
				IschemicStrokeEncounter;
			IEnumerable<Encounter> h_ = context.Operators.Select<object, Encounter>(f_, g_);

			return h_;
		};
		IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Comfort Measures during Hospitalization")]
	public IEnumerable<Encounter> Comfort_Measures_during_Hospitalization() => 
		__Comfort_Measures_during_Hospitalization.Value;

	private IEnumerable<Encounter> Encounter_with_Comfort_Measures_during_Hospitalization_Value()
	{
		IEnumerable<Encounter> a_ = this.Ischemic_Stroke_Encounter();
		IEnumerable<Encounter> b_(Encounter IschemicStrokeEncounter)
		{
			IEnumerable<object> d_ = this.Intervention_Comfort_Measures();
			bool? e_(object ComfortMeasure)
			{
				object i_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
				CqlInterval<CqlDateTime> j_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(i_);
				CqlDateTime k_ = context.Operators.Start(j_);
				FhirDateTime l_ = context.Operators.LateBoundProperty<FhirDateTime>(ComfortMeasure, "authoredOn");
				CqlDateTime m_ = FHIRHelpers_4_0_001.ToDateTime(l_);
				CqlInterval<CqlDateTime> n_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(IschemicStrokeEncounter);
				bool? o_ = context.Operators.In<CqlDateTime>(k_ ?? m_, n_, default);

				return o_;
			};
			IEnumerable<object> f_ = context.Operators.Where<object>(d_, e_);
			Encounter g_(object ComfortMeasure) => 
				IschemicStrokeEncounter;
			IEnumerable<Encounter> h_ = context.Operators.Select<object, Encounter>(f_, g_);

			return h_;
		};
		IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with Comfort Measures during Hospitalization")]
	public IEnumerable<Encounter> Encounter_with_Comfort_Measures_during_Hospitalization() => 
		__Encounter_with_Comfort_Measures_during_Hospitalization.Value;

    [CqlDeclaration("CalendarDayOfOrDayAfter")]
	public CqlInterval<CqlDate> CalendarDayOfOrDayAfter(CqlDateTime StartValue)
	{
		CqlDate a_ = context.Operators.DateFrom(StartValue);
		CqlQuantity b_ = context.Operators.Quantity(1m, "day");
		CqlDateTime c_ = context.Operators.Add(StartValue, b_);
		CqlDate d_ = context.Operators.DateFrom(c_);
		CqlInterval<CqlDate> e_ = context.Operators.Interval(a_, d_, true, true);

		return e_;
	}

}
