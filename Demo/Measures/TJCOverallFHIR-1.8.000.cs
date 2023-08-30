using System;
using System.Linq;
using System.Collections.Generic;
using Hl7.Cql.Runtime;
using Hl7.Cql.Primitives;
using Hl7.Cql;
using Hl7.Cql.ValueSets;
using Hl7.Cql.Iso8601;
using Hl7.Fhir.Model;
using Range = Hl7.Fhir.Model.Range;
using Task = Hl7.Fhir.Model.Task;
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "0.0.1.0")]
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
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/1.3.6.1.4.1.33895.1.3.0.45", null);

    [CqlDeclaration("Comfort Measures")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/1.3.6.1.4.1.33895.1.3.0.45")]
	public CqlValueSet Comfort_Measures() => 
		__Comfort_Measures.Value;

	private CqlValueSet Discharge_To_Acute_Care_Facility_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.87", null);

    [CqlDeclaration("Discharge To Acute Care Facility")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.87")]
	public CqlValueSet Discharge_To_Acute_Care_Facility() => 
		__Discharge_To_Acute_Care_Facility.Value;

	private CqlValueSet Discharged_to_Health_Care_Facility_for_Hospice_Care_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.207", null);

    [CqlDeclaration("Discharged to Health Care Facility for Hospice Care")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.207")]
	public CqlValueSet Discharged_to_Health_Care_Facility_for_Hospice_Care() => 
		__Discharged_to_Health_Care_Facility_for_Hospice_Care.Value;

	private CqlValueSet Discharged_to_Home_for_Hospice_Care_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.209", null);

    [CqlDeclaration("Discharged to Home for Hospice Care")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.209")]
	public CqlValueSet Discharged_to_Home_for_Hospice_Care() => 
		__Discharged_to_Home_for_Hospice_Care.Value;

	private CqlValueSet Emergency_Department_Visit_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292", null);

    [CqlDeclaration("Emergency Department Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292")]
	public CqlValueSet Emergency_Department_Visit() => 
		__Emergency_Department_Visit.Value;

	private CqlValueSet Encounter_Inpatient_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);

    [CqlDeclaration("Encounter Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307")]
	public CqlValueSet Encounter_Inpatient() => 
		__Encounter_Inpatient.Value;

	private CqlValueSet Hemorrhagic_Stroke_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.212", null);

    [CqlDeclaration("Hemorrhagic Stroke")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.212")]
	public CqlValueSet Hemorrhagic_Stroke() => 
		__Hemorrhagic_Stroke.Value;

	private CqlValueSet Ischemic_Stroke_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.247", null);

    [CqlDeclaration("Ischemic Stroke")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.247")]
	public CqlValueSet Ischemic_Stroke() => 
		__Ischemic_Stroke.Value;

	private CqlValueSet Left_Against_Medical_Advice_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.308", null);

    [CqlDeclaration("Left Against Medical Advice")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.308")]
	public CqlValueSet Left_Against_Medical_Advice() => 
		__Left_Against_Medical_Advice.Value;

	private CqlValueSet Non_Elective_Inpatient_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.424", null);

    [CqlDeclaration("Non-Elective Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.424")]
	public CqlValueSet Non_Elective_Inpatient() => 
		__Non_Elective_Inpatient.Value;

	private CqlValueSet Observation_Services_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143", null);

    [CqlDeclaration("Observation Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143")]
	public CqlValueSet Observation_Services() => 
		__Observation_Services.Value;

	private CqlValueSet Patient_Expired_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309", null);

    [CqlDeclaration("Patient Expired")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309")]
	public CqlValueSet Patient_Expired() => 
		__Patient_Expired.Value;

	private CqlValueSet Ticagrelor_Therapy_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.39", null);

    [CqlDeclaration("Ticagrelor Therapy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.39")]
	public CqlValueSet Ticagrelor_Therapy() => 
		__Ticagrelor_Therapy.Value;

	private CqlCode Birth_date_Value() => 
		new CqlCode("21112-8", "http://loinc.org", null, null);

    [CqlDeclaration("Birth date")]
	public CqlCode Birth_date() => 
		__Birth_date.Value;

	private CqlCode[] LOINC_Value()
	{
		var a_ = new CqlCode[]
		{
			new CqlCode("21112-8", "http://loinc.org", null, null),
		};

		return a_;
	}

    [CqlDeclaration("LOINC")]
	public CqlCode[] LOINC() => 
		__LOINC.Value;

	private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		var a_ = context.Operators;
		var d_ = a_.ConvertIntegerToDecimal(default);
		var e_ = a_.DateTime((int?)2019, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, d_);
		var h_ = a_.ConvertIntegerToDecimal(default);
		var i_ = a_.DateTime((int?)2020, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, h_);
		var j_ = a_.Interval(e_, i_, true, false);
		var k_ = context.ResolveParameter("TJCOverallFHIR-1.8.000", "Measurement Period", j_);

		return (CqlInterval<CqlDateTime>)k_;
	}

    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period() => 
		__Measurement_Period.Value;

	private Patient Patient_Value()
	{
		var a_ = context.Operators;
		var b_ = context.DataRetriever;
		var c_ = b_.RetrieveByValueSet<Patient>(null, null);
		var d_ = a_.SingleOrNull<Patient>(c_);

		return d_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient() => 
		__Patient.Value;

	private IEnumerable<Encounter> Non_Elective_Inpatient_Encounter_Value()
	{
		var a_ = context.Operators;
		var b_ = context.DataRetriever;
		var c_ = this.Non_Elective_Inpatient();
		var d_ = b_.RetrieveByValueSet<Encounter>(c_, null);
		bool? e_(Encounter NonElectiveEncounter)
		{
			var g_ = context.Operators;
			var i_ = NonElectiveEncounter?.Period;
			var j_ = FHIRHelpers_4_0_001.ToInterval(i_);
			var k_ = MATGlobalCommonFunctionsFHIR4_6_1_000.LengthInDays(j_);
			var l_ = g_.LessOrEqual(k_, (int?)120);
			var p_ = FHIRHelpers_4_0_001.ToInterval(i_);
			var q_ = g_.End(p_);
			var r_ = this.Measurement_Period();
			var s_ = g_.ElementInInterval<CqlDateTime>(q_, r_, "day");
			var t_ = g_.And(l_, s_);

			return t_;
		};
		var f_ = a_.WhereOrNull<Encounter>(d_, e_);

		return f_;
	}

    [CqlDeclaration("Non Elective Inpatient Encounter")]
	public IEnumerable<Encounter> Non_Elective_Inpatient_Encounter() => 
		__Non_Elective_Inpatient_Encounter.Value;

	private IEnumerable<Encounter> All_Stroke_Encounter_Value()
	{
		var a_ = context.Operators;
		var b_ = this.Non_Elective_Inpatient_Encounter();
		bool? c_(Encounter NonElectiveEncounter)
		{
			var e_ = context.Operators;
			var g_ = MATGlobalCommonFunctionsFHIR4_6_1_000.PrincipalDiagnosis(NonElectiveEncounter);
			var h_ = g_?.Code;
			var i_ = FHIRHelpers_4_0_001.ToConcept(h_);
			var j_ = this.Hemorrhagic_Stroke();
			var k_ = e_.ConceptInValueSet(i_, j_);
			var n_ = g_?.Code;
			var o_ = FHIRHelpers_4_0_001.ToConcept(n_);
			var p_ = this.Ischemic_Stroke();
			var q_ = e_.ConceptInValueSet(o_, p_);
			var r_ = e_.Or(k_, q_);

			return r_;
		};
		var d_ = a_.WhereOrNull<Encounter>(b_, c_);

		return d_;
	}

    [CqlDeclaration("All Stroke Encounter")]
	public IEnumerable<Encounter> All_Stroke_Encounter() => 
		__All_Stroke_Encounter.Value;

	private IEnumerable<Encounter> Encounter_with_Principal_Diagnosis_and_Age_Value()
	{
		var a_ = context.Operators;
		var b_ = this.All_Stroke_Encounter();
		IEnumerable<Encounter> c_(Encounter AllStrokeEncounter)
		{
			var e_ = context.Operators;
			var g_ = context.DataRetriever;
			var h_ = g_.RetrieveByValueSet<Patient>(null, null);
			bool? i_(Patient BirthDate)
			{
				var m_ = context.Operators;
				var p_ = this.Patient();
				var q_ = p_?.BirthDateElement;
				var r_ = q_?.Value;
				var s_ = m_.ConvertStringToDateTime(r_);
				var u_ = AllStrokeEncounter?.Period;
				var v_ = FHIRHelpers_4_0_001.ToInterval(u_);
				var w_ = m_.Start(v_);
				var x_ = m_.CalculateAgeAt(s_, w_, "year");
				var y_ = m_.GreaterOrEqual(x_, (int?)18);

				return y_;
			};
			var j_ = e_.WhereOrNull<Patient>(h_, i_);
			Encounter k_(Patient BirthDate) => 
				AllStrokeEncounter;
			var l_ = e_.SelectOrNull<Patient, Encounter>(j_, k_);

			return l_;
		};
		var d_ = a_.SelectManyOrNull<Encounter, Encounter>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Encounter with Principal Diagnosis and Age")]
	public IEnumerable<Encounter> Encounter_with_Principal_Diagnosis_and_Age() => 
		__Encounter_with_Principal_Diagnosis_and_Age.Value;

	private IEnumerable<Encounter> Ischemic_Stroke_Encounter_Value()
	{
		var a_ = context.Operators;
		var b_ = this.Encounter_with_Principal_Diagnosis_and_Age();
		bool? c_(Encounter EncounterWithAge)
		{
			var e_ = context.Operators;
			var f_ = MATGlobalCommonFunctionsFHIR4_6_1_000.PrincipalDiagnosis(EncounterWithAge);
			var g_ = f_?.Code;
			var h_ = FHIRHelpers_4_0_001.ToConcept(g_);
			var i_ = this.Ischemic_Stroke();
			var j_ = e_.ConceptInValueSet(h_, i_);

			return j_;
		};
		var d_ = a_.WhereOrNull<Encounter>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Ischemic Stroke Encounter")]
	public IEnumerable<Encounter> Ischemic_Stroke_Encounter() => 
		__Ischemic_Stroke_Encounter.Value;

	private IEnumerable<Encounter> Ischemic_Stroke_Encounters_with_Discharge_Disposition_Value()
	{
		var a_ = context.Operators;
		var b_ = this.Ischemic_Stroke_Encounter();
		bool? c_(Encounter IschemicStrokeEncounter)
		{
			var e_ = context.Operators;
			var j_ = IschemicStrokeEncounter?.Hospitalization;
			var k_ = j_?.DischargeDisposition;
			var l_ = FHIRHelpers_4_0_001.ToConcept(k_);
			var m_ = this.Discharge_To_Acute_Care_Facility();
			var n_ = e_.ConceptInValueSet(l_, m_);
			var q_ = j_?.DischargeDisposition;
			var r_ = FHIRHelpers_4_0_001.ToConcept(q_);
			var s_ = this.Left_Against_Medical_Advice();
			var t_ = e_.ConceptInValueSet(r_, s_);
			var u_ = e_.Or(n_, t_);
			var x_ = j_?.DischargeDisposition;
			var y_ = FHIRHelpers_4_0_001.ToConcept(x_);
			var z_ = this.Patient_Expired();
			var aa_ = e_.ConceptInValueSet(y_, z_);
			var ab_ = e_.Or(u_, aa_);
			var ae_ = j_?.DischargeDisposition;
			var af_ = FHIRHelpers_4_0_001.ToConcept(ae_);
			var ag_ = this.Discharged_to_Home_for_Hospice_Care();
			var ah_ = e_.ConceptInValueSet(af_, ag_);
			var ai_ = e_.Or(ab_, ah_);
			var al_ = j_?.DischargeDisposition;
			var am_ = FHIRHelpers_4_0_001.ToConcept(al_);
			var an_ = this.Discharged_to_Health_Care_Facility_for_Hospice_Care();
			var ao_ = e_.ConceptInValueSet(am_, an_);
			var ap_ = e_.Or(ai_, ao_);

			return ap_;
		};
		var d_ = a_.WhereOrNull<Encounter>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Ischemic Stroke Encounters with Discharge Disposition")]
	public IEnumerable<Encounter> Ischemic_Stroke_Encounters_with_Discharge_Disposition() => 
		__Ischemic_Stroke_Encounters_with_Discharge_Disposition.Value;

	private IEnumerable<object> Intervention_Comfort_Measures_Value()
	{
		var a_ = context.Operators;
		var c_ = context.DataRetriever;
		var d_ = this.Comfort_Measures();
		var e_ = c_.RetrieveByValueSet<ServiceRequest>(d_, null);
		bool? f_(ServiceRequest P)
		{
			var o_ = context.Operators;
			var p_ = context.Deeper(new CallStackEntry("ToString", null, null));
			var q_ = p_.Operators;
			var r_ = q_.TypeConverter;
			var s_ = P?.IntentElement;
			var t_ = r_.Convert<string>(s_);
			var u_ = o_.Equal(t_, "order");

			return u_;
		};
		var g_ = a_.WhereOrNull<ServiceRequest>(e_, f_);
		var k_ = c_.RetrieveByValueSet<Procedure>(d_, null);
		bool? l_(Procedure InterventionPerformed)
		{
			var v_ = context.Operators;
			var w_ = context.Deeper(new CallStackEntry("ToString", null, null));
			var x_ = w_.Operators;
			var y_ = x_.TypeConverter;
			var z_ = InterventionPerformed?.StatusElement;
			var aa_ = y_.Convert<string>(z_);
			var ab_ = new string[]
			{
				"completed",
				"in-progress",
			};
			var ac_ = v_.InList<string>(aa_, (ab_ as IEnumerable<string>));

			return ac_;
		};
		var m_ = a_.WhereOrNull<Procedure>(k_, l_);
		var n_ = a_.ListUnion<object>((g_ as IEnumerable<object>), (m_ as IEnumerable<object>));

		return n_;
	}

    [CqlDeclaration("Intervention Comfort Measures")]
	public IEnumerable<object> Intervention_Comfort_Measures() => 
		__Intervention_Comfort_Measures.Value;

	private IEnumerable<Encounter> Comfort_Measures_during_Hospitalization_Value()
	{
		var a_ = context.Operators;
		var b_ = this.Ischemic_Stroke_Encounter();
		IEnumerable<Encounter> c_(Encounter IschemicStrokeEncounter)
		{
			var e_ = context.Operators;
			var g_ = this.Intervention_Comfort_Measures();
			bool? h_(object ComfortMeasure)
			{
				var l_ = context.Operators;
				var n_ = l_.LateBoundProperty<object>(ComfortMeasure, "performed");
				var p_ = l_.LateBoundProperty<FhirDateTime>(ComfortMeasure, "authoredOn");
				var q_ = ((n_ as FhirDateTime) ?? p_);
				var r_ = FHIRHelpers_4_0_001.ToDateTime(q_);
				var s_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(IschemicStrokeEncounter);
				var t_ = l_.ElementInInterval<CqlDateTime>(r_, s_, null);

				return t_;
			};
			var i_ = e_.WhereOrNull<object>(g_, h_);
			Encounter j_(object ComfortMeasure) => 
				IschemicStrokeEncounter;
			var k_ = e_.SelectOrNull<object, Encounter>(i_, j_);

			return k_;
		};
		var d_ = a_.SelectManyOrNull<Encounter, Encounter>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Comfort Measures during Hospitalization")]
	public IEnumerable<Encounter> Comfort_Measures_during_Hospitalization() => 
		__Comfort_Measures_during_Hospitalization.Value;

	private IEnumerable<Encounter> Encounter_with_Comfort_Measures_during_Hospitalization_Value()
	{
		var a_ = context.Operators;
		var b_ = this.Ischemic_Stroke_Encounter();
		IEnumerable<Encounter> c_(Encounter IschemicStrokeEncounter)
		{
			var e_ = context.Operators;
			var g_ = this.Intervention_Comfort_Measures();
			bool? h_(object ComfortMeasure)
			{
				var l_ = context.Operators;
				var o_ = l_.LateBoundProperty<object>(ComfortMeasure, "performed");
				var p_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(o_);
				var q_ = l_.Start(p_);
				var s_ = l_.LateBoundProperty<FhirDateTime>(ComfortMeasure, "authoredOn");
				var t_ = FHIRHelpers_4_0_001.ToDateTime(s_);
				var u_ = (q_ ?? t_);
				var v_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(IschemicStrokeEncounter);
				var w_ = l_.ElementInInterval<CqlDateTime>(u_, v_, null);

				return w_;
			};
			var i_ = e_.WhereOrNull<object>(g_, h_);
			Encounter j_(object ComfortMeasure) => 
				IschemicStrokeEncounter;
			var k_ = e_.SelectOrNull<object, Encounter>(i_, j_);

			return k_;
		};
		var d_ = a_.SelectManyOrNull<Encounter, Encounter>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Encounter with Comfort Measures during Hospitalization")]
	public IEnumerable<Encounter> Encounter_with_Comfort_Measures_during_Hospitalization() => 
		__Encounter_with_Comfort_Measures_during_Hospitalization.Value;

    [CqlDeclaration("CalendarDayOfOrDayAfter")]
	public CqlInterval<CqlDate> CalendarDayOfOrDayAfter(CqlDateTime StartValue)
	{
		var a_ = context.Operators;
		var c_ = a_.DateFrom(StartValue);
		var g_ = a_.Quantity(1m, "day");
		var h_ = a_.Add(StartValue, g_);
		var i_ = a_.DateFrom(h_);
		var j_ = a_.Interval(c_, i_, true, true);

		return j_;
	}

}