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
[CqlLibrary("HospitalHarmHyperglycemiainHospitalizedPatientsFHIR", "0.0.006")]
public class HospitalHarmHyperglycemiainHospitalizedPatientsFHIR_0_0_006
{


    internal CqlContext context;

    #region Cached values

    internal Lazy<CqlValueSet> __birth_date;
    internal Lazy<CqlValueSet> __Diabetes;
    internal Lazy<CqlValueSet> __Encounter_Inpatient;
    internal Lazy<CqlValueSet> __Glucose_lab_test;
    internal Lazy<CqlValueSet> __Hypoglycemics_Treatment_Medications;
    internal Lazy<CqlCode> __Birth_date;
    internal Lazy<CqlCode[]> __LOINC;
    internal Lazy<CqlInterval<CqlDateTime>> __Measurement_Period;
    internal Lazy<Patient> __Patient;
    internal Lazy<IEnumerable<Coding>> __SDE_Ethnicity;
    internal Lazy<IEnumerable<Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG>> __SDE_Payer;
    internal Lazy<IEnumerable<Coding>> __SDE_Race;
    internal Lazy<CqlCode> __SDE_Sex;
    internal Lazy<IEnumerable<Encounter>> __Inpatient_Encounter_During_Measurement_Period;
    internal Lazy<IEnumerable<Encounter>> __Qualifying_Encounters;
    internal Lazy<IEnumerable<Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW>> __Qualifying_Encounters_With_Hospitalization_Period;
    internal Lazy<IEnumerable<Encounter>> __Qualifying_Encounters_With_Existing_Diabetes_Diagnosis;
    internal Lazy<IEnumerable<Encounter>> __Qualifying_Encounters_With_Hypoglycemic_Medication;
    internal Lazy<IEnumerable<Encounter>> __Qualifying_Encounters_With_Elevated_Blood_Glucose_Lab;
    internal Lazy<IEnumerable<Encounter>> __Initial_Population;
    internal Lazy<IEnumerable<Encounter>> __Denominator;
    internal Lazy<IEnumerable<Tuples.Tuple_FdccSJcWTSebijGjABdUMLEdR>> __Pertinent_Encounters_With_Days;
    internal Lazy<IEnumerable<Tuples.Tuple_GiWKJXbiXAiGGBDVZJdMTaVhK>> __Pertinent_Encounters_With_Glucose_Result_Days;
    internal Lazy<IEnumerable<Tuples.Tuple_CAbQjTVRCSKOYWiIhECGMcDPA>> __Pertinent_Encounters_With_Hyperglycemic_Event_Days;
    internal Lazy<IEnumerable<Encounter>> __Numerator;

    #endregion
    public HospitalHarmHyperglycemiainHospitalizedPatientsFHIR_0_0_006(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");

        FHIRHelpers_4_0_001 = new FHIRHelpers_4_0_001(context);
        SupplementalDataElementsFHIR4_2_0_000 = new SupplementalDataElementsFHIR4_2_0_000(context);
        MATGlobalCommonFunctionsFHIR4_6_1_000 = new MATGlobalCommonFunctionsFHIR4_6_1_000(context);

        __birth_date = new Lazy<CqlValueSet>(this.birth_date_Value);
        __Diabetes = new Lazy<CqlValueSet>(this.Diabetes_Value);
        __Encounter_Inpatient = new Lazy<CqlValueSet>(this.Encounter_Inpatient_Value);
        __Glucose_lab_test = new Lazy<CqlValueSet>(this.Glucose_lab_test_Value);
        __Hypoglycemics_Treatment_Medications = new Lazy<CqlValueSet>(this.Hypoglycemics_Treatment_Medications_Value);
        __Birth_date = new Lazy<CqlCode>(this.Birth_date_Value);
        __LOINC = new Lazy<CqlCode[]>(this.LOINC_Value);
        __Measurement_Period = new Lazy<CqlInterval<CqlDateTime>>(this.Measurement_Period_Value);
        __Patient = new Lazy<Patient>(this.Patient_Value);
        __SDE_Ethnicity = new Lazy<IEnumerable<Coding>>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<IEnumerable<Coding>>(this.SDE_Race_Value);
        __SDE_Sex = new Lazy<CqlCode>(this.SDE_Sex_Value);
        __Inpatient_Encounter_During_Measurement_Period = new Lazy<IEnumerable<Encounter>>(this.Inpatient_Encounter_During_Measurement_Period_Value);
        __Qualifying_Encounters = new Lazy<IEnumerable<Encounter>>(this.Qualifying_Encounters_Value);
        __Qualifying_Encounters_With_Hospitalization_Period = new Lazy<IEnumerable<Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW>>(this.Qualifying_Encounters_With_Hospitalization_Period_Value);
        __Qualifying_Encounters_With_Existing_Diabetes_Diagnosis = new Lazy<IEnumerable<Encounter>>(this.Qualifying_Encounters_With_Existing_Diabetes_Diagnosis_Value);
        __Qualifying_Encounters_With_Hypoglycemic_Medication = new Lazy<IEnumerable<Encounter>>(this.Qualifying_Encounters_With_Hypoglycemic_Medication_Value);
        __Qualifying_Encounters_With_Elevated_Blood_Glucose_Lab = new Lazy<IEnumerable<Encounter>>(this.Qualifying_Encounters_With_Elevated_Blood_Glucose_Lab_Value);
        __Initial_Population = new Lazy<IEnumerable<Encounter>>(this.Initial_Population_Value);
        __Denominator = new Lazy<IEnumerable<Encounter>>(this.Denominator_Value);
        __Pertinent_Encounters_With_Days = new Lazy<IEnumerable<Tuples.Tuple_FdccSJcWTSebijGjABdUMLEdR>>(this.Pertinent_Encounters_With_Days_Value);
        __Pertinent_Encounters_With_Glucose_Result_Days = new Lazy<IEnumerable<Tuples.Tuple_GiWKJXbiXAiGGBDVZJdMTaVhK>>(this.Pertinent_Encounters_With_Glucose_Result_Days_Value);
        __Pertinent_Encounters_With_Hyperglycemic_Event_Days = new Lazy<IEnumerable<Tuples.Tuple_CAbQjTVRCSKOYWiIhECGMcDPA>>(this.Pertinent_Encounters_With_Hyperglycemic_Event_Days_Value);
        __Numerator = new Lazy<IEnumerable<Encounter>>(this.Numerator_Value);
    }
    #region Dependencies

    public FHIRHelpers_4_0_001 FHIRHelpers_4_0_001 { get; }
    public SupplementalDataElementsFHIR4_2_0_000 SupplementalDataElementsFHIR4_2_0_000 { get; }
    public MATGlobalCommonFunctionsFHIR4_6_1_000 MATGlobalCommonFunctionsFHIR4_6_1_000 { get; }

    #endregion

	private CqlValueSet birth_date_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.560.100.4", null);

    [CqlDeclaration("birth date")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.560.100.4")]
	public CqlValueSet birth_date() => 
		__birth_date.Value;

	private CqlValueSet Diabetes_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.103.12.1001", null);

    [CqlDeclaration("Diabetes")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.103.12.1001")]
	public CqlValueSet Diabetes() => 
		__Diabetes.Value;

	private CqlValueSet Encounter_Inpatient_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);

    [CqlDeclaration("Encounter Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307")]
	public CqlValueSet Encounter_Inpatient() => 
		__Encounter_Inpatient.Value;

	private CqlValueSet Glucose_lab_test_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.134", null);

    [CqlDeclaration("Glucose lab test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.134")]
	public CqlValueSet Glucose_lab_test() => 
		__Glucose_lab_test.Value;

	private CqlValueSet Hypoglycemics_Treatment_Medications_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1196.394", null);

    [CqlDeclaration("Hypoglycemics Treatment Medications")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1196.394")]
	public CqlValueSet Hypoglycemics_Treatment_Medications() => 
		__Hypoglycemics_Treatment_Medications.Value;

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
		var a_ = context.ResolveParameter("HospitalHarmHyperglycemiainHospitalizedPatientsFHIR-0.0.006", "Measurement Period", null);

		return (CqlInterval<CqlDateTime>)a_;
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

	private IEnumerable<Coding> SDE_Ethnicity_Value()
	{
		var a_ = SupplementalDataElementsFHIR4_2_0_000.SDE_Ethnicity();

		return a_;
	}

    [CqlDeclaration("SDE Ethnicity")]
	public IEnumerable<Coding> SDE_Ethnicity() => 
		__SDE_Ethnicity.Value;

	private IEnumerable<Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG> SDE_Payer_Value()
	{
		var a_ = SupplementalDataElementsFHIR4_2_0_000.SDE_Payer();

		return a_;
	}

    [CqlDeclaration("SDE Payer")]
	public IEnumerable<Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG> SDE_Payer() => 
		__SDE_Payer.Value;

	private IEnumerable<Coding> SDE_Race_Value()
	{
		var a_ = SupplementalDataElementsFHIR4_2_0_000.SDE_Race();

		return a_;
	}

    [CqlDeclaration("SDE Race")]
	public IEnumerable<Coding> SDE_Race() => 
		__SDE_Race.Value;

	private CqlCode SDE_Sex_Value()
	{
		var a_ = SupplementalDataElementsFHIR4_2_0_000.SDE_Sex();

		return a_;
	}

    [CqlDeclaration("SDE Sex")]
	public CqlCode SDE_Sex() => 
		__SDE_Sex.Value;

	private IEnumerable<Encounter> Inpatient_Encounter_During_Measurement_Period_Value()
	{
		var a_ = context.DataRetriever;
		var b_ = this.Encounter_Inpatient();
		var c_ = a_.RetrieveByValueSet<Encounter>(b_, null);

		return c_;
	}

    [CqlDeclaration("Inpatient Encounter During Measurement Period")]
	public IEnumerable<Encounter> Inpatient_Encounter_During_Measurement_Period() => 
		__Inpatient_Encounter_During_Measurement_Period.Value;

	private IEnumerable<Encounter> Qualifying_Encounters_Value()
	{
		var a_ = context.Operators;
		var b_ = this.Inpatient_Encounter_During_Measurement_Period();
		bool? c_(Encounter InpatientEncounter)
		{
			var e_ = context.Operators;
			var h_ = this.Patient();
			var i_ = h_?.BirthDateElement;
			var j_ = i_?.Value;
			var k_ = e_.ConvertStringToDateTime(j_);
			var m_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(InpatientEncounter);
			var n_ = e_.Start(m_);
			var o_ = e_.CalculateAgeAt(k_, n_, "year");
			var p_ = e_.GreaterOrEqual(o_, (int?)18);

			return p_;
		};
		var d_ = a_.WhereOrNull<Encounter>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Qualifying Encounters")]
	public IEnumerable<Encounter> Qualifying_Encounters() => 
		__Qualifying_Encounters.Value;

	private IEnumerable<Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW> Qualifying_Encounters_With_Hospitalization_Period_Value()
	{
		var a_ = context.Operators;
		var b_ = this.Qualifying_Encounters();
		Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW c_(Encounter QualifyingEncounter)
		{
			var e_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(QualifyingEncounter);
			var f_ = new Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW
			{
				encounter = QualifyingEncounter,
				hospitalizationPeriod = e_,
			};

			return f_;
		};
		var d_ = a_.SelectOrNull<Encounter, Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Qualifying Encounters With Hospitalization Period")]
	public IEnumerable<Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW> Qualifying_Encounters_With_Hospitalization_Period() => 
		__Qualifying_Encounters_With_Hospitalization_Period.Value;

	private IEnumerable<Encounter> Qualifying_Encounters_With_Existing_Diabetes_Diagnosis_Value()
	{
		var a_ = context.Operators;
		var c_ = this.Qualifying_Encounters_With_Hospitalization_Period();
		IEnumerable<Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW> d_(Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW EncounterWithHospitalization)
		{
			var h_ = context.Operators;
			var j_ = context.DataRetriever;
			var k_ = this.Diabetes();
			var l_ = j_.RetrieveByValueSet<Condition>(k_, null);
			bool? m_(Condition DiabetesDiagnosis)
			{
				var q_ = context.Operators;
				var s_ = DiabetesDiagnosis?.VerificationStatus;
				var t_ = FHIRHelpers_4_0_001.ToConcept(s_);
				var v_ = MATGlobalCommonFunctionsFHIR4_6_1_000.confirmed();
				var w_ = q_.ConvertCodeToConcept(v_);
				var x_ = q_.Equivalent(t_, w_);
				var aa_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Prevalence_Period(DiabetesDiagnosis);
				var ab_ = q_.Start(aa_);
				var ad_ = EncounterWithHospitalization?.hospitalizationPeriod;
				var ae_ = q_.End(ad_);
				var af_ = q_.Before(ab_, ae_, null);
				var ag_ = q_.And(x_, af_);

				return ag_;
			};
			var n_ = h_.WhereOrNull<Condition>(l_, m_);
			Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW o_(Condition DiabetesDiagnosis) => 
				EncounterWithHospitalization;
			var p_ = h_.SelectOrNull<Condition, Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW>(n_, o_);

			return p_;
		};
		var e_ = a_.SelectManyOrNull<Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW, Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW>(c_, d_);
		Encounter f_(Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW EncounterWithHospitalization)
		{
			var ah_ = EncounterWithHospitalization?.encounter;

			return ah_;
		};
		var g_ = a_.SelectOrNull<Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW, Encounter>(e_, f_);

		return g_;
	}

    [CqlDeclaration("Qualifying Encounters With Existing Diabetes Diagnosis")]
	public IEnumerable<Encounter> Qualifying_Encounters_With_Existing_Diabetes_Diagnosis() => 
		__Qualifying_Encounters_With_Existing_Diabetes_Diagnosis.Value;

	private IEnumerable<Encounter> Qualifying_Encounters_With_Hypoglycemic_Medication_Value()
	{
		var a_ = context.Operators;
		var d_ = this.Qualifying_Encounters_With_Hospitalization_Period();
		IEnumerable<MedicationAdministration> e_(Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW _EncounterWithHospitalization)
		{
			var l_ = context.Operators;
			var m_ = context.DataRetriever;
			var n_ = this.Hypoglycemics_Treatment_Medications();
			var o_ = m_.RetrieveByValueSet<MedicationAdministration>(n_, null);
			var r_ = m_.RetrieveByValueSet<MedicationAdministration>(n_, null);
			var s_ = l_.ListUnion<MedicationAdministration>(o_, r_);

			return s_;
		};
		Tuples.Tuple_EBCeiDEEJUjLQKCDbhKCQVIHW f_(Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW _EncounterWithHospitalization, MedicationAdministration _HypoglycemicMedication)
		{
			var t_ = new Tuples.Tuple_EBCeiDEEJUjLQKCDbhKCQVIHW
			{
				EncounterWithHospitalization = _EncounterWithHospitalization,
				HypoglycemicMedication = _HypoglycemicMedication,
			};

			return t_;
		};
		var g_ = a_.SelectManyResultsOrNull<Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW, MedicationAdministration, Tuples.Tuple_EBCeiDEEJUjLQKCDbhKCQVIHW>(d_, e_, f_);
		bool? h_(Tuples.Tuple_EBCeiDEEJUjLQKCDbhKCQVIHW tuple_ebceideejujlqkcdbhkcqvihw)
		{
			var u_ = context.Operators;
			var w_ = context.Deeper(new CallStackEntry("ToString", null, null));
			var x_ = w_.Operators;
			var y_ = x_.TypeConverter;
			var z_ = tuple_ebceideejujlqkcdbhkcqvihw.HypoglycemicMedication;
			var aa_ = z_?.StatusElement;
			var ab_ = y_.Convert<string>(aa_);
			var ac_ = u_.Equal(ab_, "completed");
			var ae_ = tuple_ebceideejujlqkcdbhkcqvihw.EncounterWithHospitalization;
			var af_ = ae_?.hospitalizationPeriod;
			var ah_ = z_?.Effective;
			var ai_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(ah_);
			var aj_ = u_.IntervalIncludesInterval<CqlDateTime>(af_, ai_, null);
			var ak_ = u_.And(ac_, aj_);

			return ak_;
		};
		var i_ = a_.WhereOrNull<Tuples.Tuple_EBCeiDEEJUjLQKCDbhKCQVIHW>(g_, h_);
		Encounter j_(Tuples.Tuple_EBCeiDEEJUjLQKCDbhKCQVIHW tuple_ebceideejujlqkcdbhkcqvihw)
		{
			var al_ = tuple_ebceideejujlqkcdbhkcqvihw.EncounterWithHospitalization;
			var am_ = al_?.encounter;

			return am_;
		};
		var k_ = a_.SelectOrNull<Tuples.Tuple_EBCeiDEEJUjLQKCDbhKCQVIHW, Encounter>(i_, j_);

		return k_;
	}

    [CqlDeclaration("Qualifying Encounters With Hypoglycemic Medication")]
	public IEnumerable<Encounter> Qualifying_Encounters_With_Hypoglycemic_Medication() => 
		__Qualifying_Encounters_With_Hypoglycemic_Medication.Value;

	private IEnumerable<Encounter> Qualifying_Encounters_With_Elevated_Blood_Glucose_Lab_Value()
	{
		var a_ = context.Operators;
		var c_ = this.Qualifying_Encounters_With_Hospitalization_Period();
		IEnumerable<Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW> d_(Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW EncounterWithHospitalization)
		{
			var h_ = context.Operators;
			var j_ = context.DataRetriever;
			var k_ = this.Glucose_lab_test();
			var l_ = j_.RetrieveByValueSet<Observation>(k_, null);
			bool? m_(Observation BloodGlucoseLab)
			{
				var q_ = context.Operators;
				var t_ = BloodGlucoseLab?.Effective;
				var u_ = FHIRHelpers_4_0_001.ToDateTime((t_ as FhirDateTime));
				var v_ = EncounterWithHospitalization?.hospitalizationPeriod;
				var w_ = q_.ElementInInterval<CqlDateTime>(u_, v_, null);
				var y_ = context.Deeper(new CallStackEntry("ToString", null, null));
				var z_ = y_.Operators;
				var aa_ = z_.TypeConverter;
				var ab_ = BloodGlucoseLab?.StatusElement;
				var ac_ = aa_.Convert<string>(ab_);
				var ad_ = q_.Equal(ac_, "final");
				var ae_ = q_.And(w_, ad_);
				var ag_ = BloodGlucoseLab?.Value;
				var ah_ = FHIRHelpers_4_0_001.ToQuantity((ag_ as Quantity));
				var aj_ = q_.Quantity(200m, "mg/dL");
				var ak_ = q_.GreaterOrEqual(ah_, aj_);
				var al_ = q_.And(ae_, ak_);

				return al_;
			};
			var n_ = h_.WhereOrNull<Observation>(l_, m_);
			Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW o_(Observation BloodGlucoseLab) => 
				EncounterWithHospitalization;
			var p_ = h_.SelectOrNull<Observation, Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW>(n_, o_);

			return p_;
		};
		var e_ = a_.SelectManyOrNull<Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW, Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW>(c_, d_);
		Encounter f_(Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW EncounterWithHospitalization)
		{
			var am_ = EncounterWithHospitalization?.encounter;

			return am_;
		};
		var g_ = a_.SelectOrNull<Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW, Encounter>(e_, f_);

		return g_;
	}

    [CqlDeclaration("Qualifying Encounters With Elevated Blood Glucose Lab")]
	public IEnumerable<Encounter> Qualifying_Encounters_With_Elevated_Blood_Glucose_Lab() => 
		__Qualifying_Encounters_With_Elevated_Blood_Glucose_Lab.Value;

	private IEnumerable<Encounter> Initial_Population_Value()
	{
		var a_ = context.Operators;
		var c_ = this.Qualifying_Encounters_With_Existing_Diabetes_Diagnosis();
		var d_ = this.Qualifying_Encounters_With_Hypoglycemic_Medication();
		var e_ = a_.ListUnion<Encounter>(c_, d_);
		var f_ = this.Qualifying_Encounters_With_Elevated_Blood_Glucose_Lab();
		var g_ = a_.ListUnion<Encounter>(e_, f_);

		return g_;
	}

    [CqlDeclaration("Initial Population")]
	public IEnumerable<Encounter> Initial_Population() => 
		__Initial_Population.Value;

	private IEnumerable<Encounter> Denominator_Value()
	{
		var a_ = this.Initial_Population();

		return a_;
	}

    [CqlDeclaration("Denominator")]
	public IEnumerable<Encounter> Denominator() => 
		__Denominator.Value;

    [CqlDeclaration("Crop Interval to 10 Days")]
	public CqlInterval<CqlDateTime> Crop_Interval_to_10_Days(CqlInterval<CqlDateTime> Period)
	{
		var a_ = context.Operators;
		var c_ = a_.Start(Period);
		var f_ = a_.End(Period);
		var i_ = a_.Start(Period);
		var k_ = a_.Quantity(10m, "days");
		var l_ = a_.Add(i_, k_);
		var m_ = new CqlDateTime[]
		{
			f_,
			l_,
		};
		var n_ = a_.MinOrNull<CqlDateTime>((m_ as IEnumerable<CqlDateTime>));
		var o_ = a_.Interval(c_, n_, true, true);

		return o_;
	}

    [CqlDeclaration("Interval To Day Numbers")]
	public IEnumerable<int?> Interval_To_Day_Numbers(CqlInterval<CqlDateTime> Period)
	{
		var a_ = context.Operators;
		var f_ = a_.Start(Period);
		var h_ = a_.End(Period);
		var i_ = a_.DurationBetween(f_, h_, "day");
		var j_ = a_.Interval((int?)1, i_, true, true);
		var k_ = new CqlInterval<int?>[]
		{
			j_,
		};
		var l_ = a_.ExpandList((k_ as IEnumerable<CqlInterval<int?>>), null);
		int? m_(CqlInterval<int?> DayExpand)
		{
			var o_ = context.Operators;
			var p_ = o_.End(DayExpand);

			return p_;
		};
		var n_ = a_.SelectOrNull<CqlInterval<int?>, int?>(l_, m_);

		return n_;
	}

    [CqlDeclaration("Days In Period")]
	public IEnumerable<Tuples.Tuple_BZfjDHYASdKbVKTOeigaYPBVf> Days_In_Period(CqlInterval<CqlDateTime> Period)
	{
		var a_ = context.Operators;
		var b_ = this.Interval_To_Day_Numbers(Period);
		Tuples.Tuple_BZfjDHYASdKbVKTOeigaYPBVf c_(int? DayIndex)
		{
			var e_ = context.Operators;
			var h_ = e_.Start(Period);
			var k_ = e_.Quantity(24m, "hours");
			var n_ = e_.Subtract(DayIndex, (int?)1);
			var o_ = e_.ConvertIntegerToQuantity(n_);
			var p_ = e_.Multiply(k_, o_);
			var q_ = e_.Add(h_, p_);
			CqlDateTime r_()
			{
				if ((context.Operators.Less(context.Operators.DurationBetween(context.Operators.Add(context.Operators.Start(Period), context.Operators.Multiply(context.Operators.Quantity(24m, "hours"), context.Operators.ConvertIntegerToQuantity(context.Operators.Subtract(DayIndex, (int?)1)))), context.Operators.End(Period), "hour"), (int?)24) ?? false))
				{
					var u_ = context.Operators;
					var w_ = u_.Start(Period);
					var z_ = u_.Quantity(24m, "hours");
					var ac_ = u_.Subtract(DayIndex, (int?)1);
					var ad_ = u_.ConvertIntegerToQuantity(ac_);
					var ae_ = u_.Multiply(z_, ad_);
					var af_ = u_.Add(w_, ae_);

					return af_;
				}
				else
				{
					var ag_ = context.Operators;
					var ai_ = ag_.Start(Period);
					var al_ = ag_.Quantity(24m, "hours");
					var an_ = ag_.ConvertIntegerToQuantity(DayIndex);
					var ao_ = ag_.Multiply(al_, an_);
					var ap_ = ag_.Add(ai_, ao_);

					return ap_;
				};
			};
			var s_ = e_.Interval(q_, r_(), true, false);
			var t_ = new Tuples.Tuple_BZfjDHYASdKbVKTOeigaYPBVf
			{
				dayIndex = DayIndex,
				dayPeriod = s_,
			};

			return t_;
		};
		var d_ = a_.SelectOrNull<int?, Tuples.Tuple_BZfjDHYASdKbVKTOeigaYPBVf>(b_, c_);

		return d_;
	}

	private IEnumerable<Tuples.Tuple_FdccSJcWTSebijGjABdUMLEdR> Pertinent_Encounters_With_Days_Value()
	{
		var a_ = context.Operators;
		var b_ = this.Initial_Population();
		Tuples.Tuple_FdccSJcWTSebijGjABdUMLEdR c_(Encounter PertinentEncounter)
		{
			var e_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(PertinentEncounter);
			var g_ = this.Crop_Interval_to_10_Days(e_);
			var i_ = this.Crop_Interval_to_10_Days(e_);
			var j_ = this.Days_In_Period(i_);
			var k_ = new Tuples.Tuple_FdccSJcWTSebijGjABdUMLEdR
			{
				encounter = PertinentEncounter,
				hospitalizationPeriod = e_,
				relevantPeriod = g_,
				relevantDays = j_,
			};

			return k_;
		};
		var d_ = a_.SelectOrNull<Encounter, Tuples.Tuple_FdccSJcWTSebijGjABdUMLEdR>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Pertinent Encounters With Days")]
	public IEnumerable<Tuples.Tuple_FdccSJcWTSebijGjABdUMLEdR> Pertinent_Encounters_With_Days() => 
		__Pertinent_Encounters_With_Days.Value;

	private IEnumerable<Tuples.Tuple_GiWKJXbiXAiGGBDVZJdMTaVhK> Pertinent_Encounters_With_Glucose_Result_Days_Value()
	{
		var a_ = context.Operators;
		var b_ = this.Pertinent_Encounters_With_Days();
		Tuples.Tuple_GiWKJXbiXAiGGBDVZJdMTaVhK c_(Tuples.Tuple_FdccSJcWTSebijGjABdUMLEdR PertinentEncounterDays)
		{
			var e_ = PertinentEncounterDays?.encounter;
			var f_ = PertinentEncounterDays?.relevantPeriod;
			var g_ = context.Operators;
			var h_ = PertinentEncounterDays?.relevantDays;
			Tuples.Tuple_EPQMNeOgChVRHOcBPRccPNZeF i_(Tuples.Tuple_BZfjDHYASdKbVKTOeigaYPBVf EncounterDay)
			{
				var l_ = EncounterDay?.dayIndex;
				var m_ = EncounterDay?.dayPeriod;
				var n_ = context.Operators;
				var p_ = context.DataRetriever;
				var q_ = this.Glucose_lab_test();
				var r_ = p_.RetrieveByValueSet<Observation>(q_, null);
				bool? s_(Observation BloodGlucoseLab1)
				{
					var ao_ = context.Operators;
					var ar_ = context.Deeper(new CallStackEntry("ToString", null, null));
					var as_ = ar_.Operators;
					var at_ = as_.TypeConverter;
					var au_ = BloodGlucoseLab1?.StatusElement;
					var av_ = at_.Convert<string>(au_);
					var aw_ = ao_.Equal(av_, "final");
					var ay_ = BloodGlucoseLab1?.Value;
					var az_ = FHIRHelpers_4_0_001.ToQuantity((ay_ as Quantity));
					var bb_ = ao_.Quantity(300m, "mg/dL");
					var bc_ = ao_.Greater(az_, bb_);
					var bd_ = ao_.And(aw_, bc_);
					var bf_ = BloodGlucoseLab1?.Effective;
					var bg_ = FHIRHelpers_4_0_001.ToDateTime((bf_ as FhirDateTime));
					var bh_ = EncounterDay?.dayPeriod;
					var bi_ = ao_.ElementInInterval<CqlDateTime>(bg_, bh_, null);
					var bj_ = ao_.And(bd_, bi_);

					return bj_;
				};
				var t_ = n_.WhereOrNull<Observation>(r_, s_);
				var u_ = n_.ExistsInList<Observation>(t_);
				var z_ = p_.RetrieveByValueSet<Observation>(q_, null);
				bool? aa_(Observation BloodGlucoseLab2)
				{
					var bk_ = context.Operators;
					var bn_ = context.Deeper(new CallStackEntry("ToString", null, null));
					var bo_ = bn_.Operators;
					var bp_ = bo_.TypeConverter;
					var bq_ = BloodGlucoseLab2?.StatusElement;
					var br_ = bp_.Convert<string>(bq_);
					var bs_ = bk_.Equal(br_, "final");
					var bu_ = BloodGlucoseLab2?.Value;
					var bv_ = FHIRHelpers_4_0_001.ToQuantity((bu_ as Quantity));
					var bx_ = bk_.Quantity(200m, "mg/dL");
					var by_ = bk_.GreaterOrEqual(bv_, bx_);
					var bz_ = bk_.And(bs_, by_);
					var cb_ = BloodGlucoseLab2?.Effective;
					var cc_ = FHIRHelpers_4_0_001.ToDateTime((cb_ as FhirDateTime));
					var cd_ = EncounterDay?.dayPeriod;
					var ce_ = bk_.ElementInInterval<CqlDateTime>(cc_, cd_, null);
					var cf_ = bk_.And(bz_, ce_);

					return cf_;
				};
				var ab_ = n_.WhereOrNull<Observation>(z_, aa_);
				var ac_ = n_.ExistsInList<Observation>(ab_);
				var ai_ = p_.RetrieveByValueSet<Observation>(q_, null);
				bool? aj_(Observation BloodGlucoseLab3)
				{
					var cg_ = context.Operators;
					var ci_ = context.Deeper(new CallStackEntry("ToString", null, null));
					var cj_ = ci_.Operators;
					var ck_ = cj_.TypeConverter;
					var cl_ = BloodGlucoseLab3?.StatusElement;
					var cm_ = ck_.Convert<string>(cl_);
					var cn_ = cg_.Equal(cm_, "final");
					var cp_ = BloodGlucoseLab3?.Effective;
					var cq_ = FHIRHelpers_4_0_001.ToDateTime((cp_ as FhirDateTime));
					var cr_ = EncounterDay?.dayPeriod;
					var cs_ = cg_.ElementInInterval<CqlDateTime>(cq_, cr_, null);
					var ct_ = cg_.And(cn_, cs_);

					return ct_;
				};
				var ak_ = n_.WhereOrNull<Observation>(ai_, aj_);
				var al_ = n_.ExistsInList<Observation>(ak_);
				var am_ = n_.Not(al_);
				var an_ = new Tuples.Tuple_EPQMNeOgChVRHOcBPRccPNZeF
				{
					dayIndex = l_,
					dayPeriod = m_,
					hasSevereResult = u_,
					hasElevatedResult = ac_,
					hasNoResult = am_,
				};

				return an_;
			};
			var j_ = g_.SelectOrNull<Tuples.Tuple_BZfjDHYASdKbVKTOeigaYPBVf, Tuples.Tuple_EPQMNeOgChVRHOcBPRccPNZeF>(h_, i_);
			var k_ = new Tuples.Tuple_GiWKJXbiXAiGGBDVZJdMTaVhK
			{
				encounter = e_,
				relevantPeriod = f_,
				relevantDays = j_,
			};

			return k_;
		};
		var d_ = a_.SelectOrNull<Tuples.Tuple_FdccSJcWTSebijGjABdUMLEdR, Tuples.Tuple_GiWKJXbiXAiGGBDVZJdMTaVhK>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Pertinent Encounters With Glucose Result Days")]
	public IEnumerable<Tuples.Tuple_GiWKJXbiXAiGGBDVZJdMTaVhK> Pertinent_Encounters_With_Glucose_Result_Days() => 
		__Pertinent_Encounters_With_Glucose_Result_Days.Value;

	private IEnumerable<Tuples.Tuple_CAbQjTVRCSKOYWiIhECGMcDPA> Pertinent_Encounters_With_Hyperglycemic_Event_Days_Value()
	{
		var a_ = context.Operators;
		var b_ = this.Pertinent_Encounters_With_Glucose_Result_Days();
		Tuples.Tuple_CAbQjTVRCSKOYWiIhECGMcDPA c_(Tuples.Tuple_GiWKJXbiXAiGGBDVZJdMTaVhK EncounterWithResultDays)
		{
			var e_ = EncounterWithResultDays?.encounter;
			var f_ = EncounterWithResultDays?.relevantPeriod;
			var g_ = context.Operators;
			var i_ = EncounterWithResultDays?.relevantDays;
			bool? j_(Tuples.Tuple_EPQMNeOgChVRHOcBPRccPNZeF EncounterDay)
			{
				var o_ = context.Operators;
				var p_ = EncounterDay?.dayIndex;
				var q_ = o_.Greater(p_, (int?)1);

				return q_;
			};
			var k_ = g_.WhereOrNull<Tuples.Tuple_EPQMNeOgChVRHOcBPRccPNZeF>(i_, j_);
			Tuples.Tuple_HBBaLFUhhUfQBEJKjEZegSRLi l_(Tuples.Tuple_EPQMNeOgChVRHOcBPRccPNZeF EncounterDay)
			{
				var r_ = EncounterDay?.dayIndex;
				var s_ = EncounterDay?.dayPeriod;
				var t_ = context.Operators;
				var u_ = EncounterDay?.hasSevereResult;
				var x_ = EncounterDay?.hasNoResult;
				var z_ = EncounterWithResultDays?.relevantDays;
				var ac_ = t_.Subtract(r_, (int?)2);
				var ad_ = t_.ListElementAt<Tuples.Tuple_EPQMNeOgChVRHOcBPRccPNZeF>(z_, ac_);
				var ae_ = ad_?.hasElevatedResult;
				var af_ = t_.And(x_, ae_);
				var ak_ = t_.Subtract(r_, (int?)3);
				var al_ = t_.ListElementAt<Tuples.Tuple_EPQMNeOgChVRHOcBPRccPNZeF>(z_, ak_);
				var am_ = al_?.hasElevatedResult;
				var an_ = t_.And(af_, am_);
				var ao_ = t_.Or(u_, an_);
				var ap_ = new Tuples.Tuple_HBBaLFUhhUfQBEJKjEZegSRLi
				{
					dayIndex = r_,
					dayPeriod = s_,
					hasHyperglycemicEvent = ao_,
				};

				return ap_;
			};
			var m_ = g_.SelectOrNull<Tuples.Tuple_EPQMNeOgChVRHOcBPRccPNZeF, Tuples.Tuple_HBBaLFUhhUfQBEJKjEZegSRLi>(k_, l_);
			var n_ = new Tuples.Tuple_CAbQjTVRCSKOYWiIhECGMcDPA
			{
				encounter = e_,
				relevantPeriod = f_,
				eligibleEventDays = m_,
			};

			return n_;
		};
		var d_ = a_.SelectOrNull<Tuples.Tuple_GiWKJXbiXAiGGBDVZJdMTaVhK, Tuples.Tuple_CAbQjTVRCSKOYWiIhECGMcDPA>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Pertinent Encounters With Hyperglycemic Event Days")]
	public IEnumerable<Tuples.Tuple_CAbQjTVRCSKOYWiIhECGMcDPA> Pertinent_Encounters_With_Hyperglycemic_Event_Days() => 
		__Pertinent_Encounters_With_Hyperglycemic_Event_Days.Value;

	private IEnumerable<Encounter> Numerator_Value()
	{
		var a_ = context.Operators;
		var c_ = this.Pertinent_Encounters_With_Hyperglycemic_Event_Days();
		bool? d_(Tuples.Tuple_CAbQjTVRCSKOYWiIhECGMcDPA EncounterWithEventDays)
		{
			var h_ = context.Operators;
			var j_ = EncounterWithEventDays?.eligibleEventDays;
			bool? k_(Tuples.Tuple_HBBaLFUhhUfQBEJKjEZegSRLi EligibleEventDay)
			{
				var n_ = EligibleEventDay?.hasHyperglycemicEvent;

				return n_;
			};
			var l_ = h_.WhereOrNull<Tuples.Tuple_HBBaLFUhhUfQBEJKjEZegSRLi>(j_, k_);
			var m_ = h_.ExistsInList<Tuples.Tuple_HBBaLFUhhUfQBEJKjEZegSRLi>(l_);

			return m_;
		};
		var e_ = a_.WhereOrNull<Tuples.Tuple_CAbQjTVRCSKOYWiIhECGMcDPA>(c_, d_);
		Encounter f_(Tuples.Tuple_CAbQjTVRCSKOYWiIhECGMcDPA EncounterWithEventDays)
		{
			var o_ = EncounterWithEventDays?.encounter;

			return o_;
		};
		var g_ = a_.SelectOrNull<Tuples.Tuple_CAbQjTVRCSKOYWiIhECGMcDPA, Encounter>(e_, f_);

		return g_;
	}

    [CqlDeclaration("Numerator")]
	public IEnumerable<Encounter> Numerator() => 
		__Numerator.Value;

    [CqlDeclaration("Denominator Observations")]
	public int? Denominator_Observations(Encounter QualifyingEncounter)
	{
		var a_ = context.Operators;
		var d_ = this.Pertinent_Encounters_With_Hyperglycemic_Event_Days();
		bool? e_(Tuples.Tuple_CAbQjTVRCSKOYWiIhECGMcDPA EncounterWithEventDays)
		{
			var j_ = context.Operators;
			var k_ = EncounterWithEventDays?.encounter;
			var l_ = j_.Equal(k_, QualifyingEncounter);

			return l_;
		};
		var f_ = a_.WhereOrNull<Tuples.Tuple_CAbQjTVRCSKOYWiIhECGMcDPA>(d_, e_);
		int? g_(Tuples.Tuple_CAbQjTVRCSKOYWiIhECGMcDPA EncounterWithEventDays)
		{
			var m_ = context.Operators;
			var n_ = EncounterWithEventDays?.eligibleEventDays;
			var o_ = m_.CountOrNull<Tuples.Tuple_HBBaLFUhhUfQBEJKjEZegSRLi>(n_);

			return o_;
		};
		var h_ = a_.SelectOrNull<Tuples.Tuple_CAbQjTVRCSKOYWiIhECGMcDPA, int?>(f_, g_);
		var i_ = a_.SingleOrNull<int?>(h_);

		return i_;
	}

    [CqlDeclaration("Numerator Observations")]
	public int? Numerator_Observations(Encounter QualifyingEncounter)
	{
		var a_ = context.Operators;
		var d_ = this.Pertinent_Encounters_With_Hyperglycemic_Event_Days();
		bool? e_(Tuples.Tuple_CAbQjTVRCSKOYWiIhECGMcDPA EncounterWithEventDays)
		{
			var j_ = context.Operators;
			var k_ = EncounterWithEventDays?.encounter;
			var l_ = j_.Equal(k_, QualifyingEncounter);

			return l_;
		};
		var f_ = a_.WhereOrNull<Tuples.Tuple_CAbQjTVRCSKOYWiIhECGMcDPA>(d_, e_);
		int? g_(Tuples.Tuple_CAbQjTVRCSKOYWiIhECGMcDPA EncounterWithEventDays)
		{
			var m_ = context.Operators;
			var o_ = EncounterWithEventDays?.eligibleEventDays;
			bool? p_(Tuples.Tuple_HBBaLFUhhUfQBEJKjEZegSRLi EligibleEventDay)
			{
				var s_ = EligibleEventDay?.hasHyperglycemicEvent;

				return s_;
			};
			var q_ = m_.WhereOrNull<Tuples.Tuple_HBBaLFUhhUfQBEJKjEZegSRLi>(o_, p_);
			var r_ = m_.CountOrNull<Tuples.Tuple_HBBaLFUhhUfQBEJKjEZegSRLi>(q_);

			return r_;
		};
		var h_ = a_.SelectOrNull<Tuples.Tuple_CAbQjTVRCSKOYWiIhECGMcDPA, int?>(f_, g_);
		var i_ = a_.SingleOrNull<int?>(h_);

		return i_;
	}

}