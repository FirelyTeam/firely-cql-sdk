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
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "0.9.0.0")]
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
		var a_ = context.Operators.RetrieveByValueSet<Patient>(null, null);
		var b_ = context.Operators.SingleOrNull<Patient>(a_);

		return b_;
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
		var a_ = this.Encounter_Inpatient();
		var b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);

		return b_;
	}

    [CqlDeclaration("Inpatient Encounter During Measurement Period")]
	public IEnumerable<Encounter> Inpatient_Encounter_During_Measurement_Period() => 
		__Inpatient_Encounter_During_Measurement_Period.Value;

	private IEnumerable<Encounter> Qualifying_Encounters_Value()
	{
		var a_ = this.Inpatient_Encounter_During_Measurement_Period();
		bool? b_(Encounter InpatientEncounter)
		{
			var d_ = this.Patient();
			var e_ = d_?.BirthDateElement;
			var f_ = e_?.Value;
			var g_ = context.Operators.ConvertStringToDateTime(f_);
			var h_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(InpatientEncounter);
			var i_ = context.Operators.Start(h_);
			var j_ = context.Operators.CalculateAgeAt(g_, i_, "year");
			var k_ = context.Operators.GreaterOrEqual(j_, (int?)18);

			return k_;
		};
		var c_ = context.Operators.WhereOrNull<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Qualifying Encounters")]
	public IEnumerable<Encounter> Qualifying_Encounters() => 
		__Qualifying_Encounters.Value;

	private IEnumerable<Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW> Qualifying_Encounters_With_Hospitalization_Period_Value()
	{
		var a_ = this.Qualifying_Encounters();
		Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW b_(Encounter QualifyingEncounter)
		{
			var d_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(QualifyingEncounter);
			var e_ = new Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW
			{
				encounter = QualifyingEncounter,
				hospitalizationPeriod = d_,
			};

			return e_;
		};
		var c_ = context.Operators.SelectOrNull<Encounter, Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Qualifying Encounters With Hospitalization Period")]
	public IEnumerable<Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW> Qualifying_Encounters_With_Hospitalization_Period() => 
		__Qualifying_Encounters_With_Hospitalization_Period.Value;

	private IEnumerable<Encounter> Qualifying_Encounters_With_Existing_Diabetes_Diagnosis_Value()
	{
		var a_ = this.Qualifying_Encounters_With_Hospitalization_Period();
		IEnumerable<Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW> b_(Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW EncounterWithHospitalization)
		{
			var f_ = this.Diabetes();
			var g_ = context.Operators.RetrieveByValueSet<Condition>(f_, null);
			bool? h_(Condition DiabetesDiagnosis)
			{
				var l_ = DiabetesDiagnosis?.VerificationStatus;
				var m_ = FHIRHelpers_4_0_001.ToConcept(l_);
				var n_ = MATGlobalCommonFunctionsFHIR4_6_1_000.confirmed();
				var o_ = context.Operators.ConvertCodeToConcept(n_);
				var p_ = context.Operators.Equivalent(m_, o_);
				var q_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Prevalence_Period(DiabetesDiagnosis);
				var r_ = context.Operators.Start(q_);
				var s_ = EncounterWithHospitalization?.hospitalizationPeriod;
				var t_ = context.Operators.End(s_);
				var u_ = context.Operators.Before(r_, t_, null);
				var v_ = context.Operators.And(p_, u_);

				return v_;
			};
			var i_ = context.Operators.WhereOrNull<Condition>(g_, h_);
			Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW j_(Condition DiabetesDiagnosis) => 
				EncounterWithHospitalization;
			var k_ = context.Operators.SelectOrNull<Condition, Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW>(i_, j_);

			return k_;
		};
		var c_ = context.Operators.SelectManyOrNull<Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW, Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW>(a_, b_);
		Encounter d_(Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW EncounterWithHospitalization)
		{
			var w_ = EncounterWithHospitalization?.encounter;

			return w_;
		};
		var e_ = context.Operators.SelectOrNull<Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW, Encounter>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Qualifying Encounters With Existing Diabetes Diagnosis")]
	public IEnumerable<Encounter> Qualifying_Encounters_With_Existing_Diabetes_Diagnosis() => 
		__Qualifying_Encounters_With_Existing_Diabetes_Diagnosis.Value;

	private IEnumerable<Encounter> Qualifying_Encounters_With_Hypoglycemic_Medication_Value()
	{
		var a_ = this.Qualifying_Encounters_With_Hospitalization_Period();
		IEnumerable<MedicationAdministration> b_(Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW _EncounterWithHospitalization)
		{
			var i_ = this.Hypoglycemics_Treatment_Medications();
			var j_ = context.Operators.RetrieveByValueSet<MedicationAdministration>(i_, null);
			var l_ = context.Operators.RetrieveByValueSet<MedicationAdministration>(i_, null);
			var m_ = context.Operators.ListUnion<MedicationAdministration>(j_, l_);

			return m_;
		};
		Tuples.Tuple_EBCeiDEEJUjLQKCDbhKCQVIHW c_(Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW _EncounterWithHospitalization, MedicationAdministration _HypoglycemicMedication)
		{
			var n_ = new Tuples.Tuple_EBCeiDEEJUjLQKCDbhKCQVIHW
			{
				EncounterWithHospitalization = _EncounterWithHospitalization,
				HypoglycemicMedication = _HypoglycemicMedication,
			};

			return n_;
		};
		var d_ = context.Operators.SelectManyResultsOrNull<Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW, MedicationAdministration, Tuples.Tuple_EBCeiDEEJUjLQKCDbhKCQVIHW>(a_, b_, c_);
		bool? e_(Tuples.Tuple_EBCeiDEEJUjLQKCDbhKCQVIHW tuple_ebceideejujlqkcdbhkcqvihw)
		{
			var o_ = tuple_ebceideejujlqkcdbhkcqvihw.HypoglycemicMedication?.StatusElement;
			var p_ = context.Operators.Convert<string>(o_);
			var q_ = context.Operators.Equal(p_, "completed");
			var r_ = tuple_ebceideejujlqkcdbhkcqvihw.EncounterWithHospitalization?.hospitalizationPeriod;
			var s_ = tuple_ebceideejujlqkcdbhkcqvihw.HypoglycemicMedication?.Effective;
			var t_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(s_);
			var u_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(r_, t_, null);
			var v_ = context.Operators.And(q_, u_);

			return v_;
		};
		var f_ = context.Operators.WhereOrNull<Tuples.Tuple_EBCeiDEEJUjLQKCDbhKCQVIHW>(d_, e_);
		Encounter g_(Tuples.Tuple_EBCeiDEEJUjLQKCDbhKCQVIHW tuple_ebceideejujlqkcdbhkcqvihw)
		{
			var w_ = tuple_ebceideejujlqkcdbhkcqvihw.EncounterWithHospitalization?.encounter;

			return w_;
		};
		var h_ = context.Operators.SelectOrNull<Tuples.Tuple_EBCeiDEEJUjLQKCDbhKCQVIHW, Encounter>(f_, g_);

		return h_;
	}

    [CqlDeclaration("Qualifying Encounters With Hypoglycemic Medication")]
	public IEnumerable<Encounter> Qualifying_Encounters_With_Hypoglycemic_Medication() => 
		__Qualifying_Encounters_With_Hypoglycemic_Medication.Value;

	private IEnumerable<Encounter> Qualifying_Encounters_With_Elevated_Blood_Glucose_Lab_Value()
	{
		var a_ = this.Qualifying_Encounters_With_Hospitalization_Period();
		IEnumerable<Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW> b_(Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW EncounterWithHospitalization)
		{
			var f_ = this.Glucose_lab_test();
			var g_ = context.Operators.RetrieveByValueSet<Observation>(f_, null);
			bool? h_(Observation BloodGlucoseLab)
			{
				var l_ = BloodGlucoseLab?.Effective;
				var m_ = FHIRHelpers_4_0_001.ToDateTime((l_ as FhirDateTime));
				var n_ = EncounterWithHospitalization?.hospitalizationPeriod;
				var o_ = context.Operators.ElementInInterval<CqlDateTime>(m_, n_, null);
				var p_ = BloodGlucoseLab?.StatusElement;
				var q_ = context.Operators.Convert<string>(p_);
				var r_ = context.Operators.Equal(q_, "final");
				var s_ = context.Operators.And(o_, r_);
				var t_ = BloodGlucoseLab?.Value;
				var u_ = FHIRHelpers_4_0_001.ToQuantity((t_ as Quantity));
				var v_ = context.Operators.Quantity(200m, "mg/dL");
				var w_ = context.Operators.GreaterOrEqual(u_, v_);
				var x_ = context.Operators.And(s_, w_);

				return x_;
			};
			var i_ = context.Operators.WhereOrNull<Observation>(g_, h_);
			Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW j_(Observation BloodGlucoseLab) => 
				EncounterWithHospitalization;
			var k_ = context.Operators.SelectOrNull<Observation, Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW>(i_, j_);

			return k_;
		};
		var c_ = context.Operators.SelectManyOrNull<Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW, Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW>(a_, b_);
		Encounter d_(Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW EncounterWithHospitalization)
		{
			var y_ = EncounterWithHospitalization?.encounter;

			return y_;
		};
		var e_ = context.Operators.SelectOrNull<Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW, Encounter>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Qualifying Encounters With Elevated Blood Glucose Lab")]
	public IEnumerable<Encounter> Qualifying_Encounters_With_Elevated_Blood_Glucose_Lab() => 
		__Qualifying_Encounters_With_Elevated_Blood_Glucose_Lab.Value;

	private IEnumerable<Encounter> Initial_Population_Value()
	{
		var a_ = this.Qualifying_Encounters_With_Existing_Diabetes_Diagnosis();
		var b_ = this.Qualifying_Encounters_With_Hypoglycemic_Medication();
		var c_ = context.Operators.ListUnion<Encounter>(a_, b_);
		var d_ = this.Qualifying_Encounters_With_Elevated_Blood_Glucose_Lab();
		var e_ = context.Operators.ListUnion<Encounter>(c_, d_);

		return e_;
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
		var a_ = context.Operators.Start(Period);
		var b_ = context.Operators.End(Period);
		var d_ = context.Operators.Quantity(10m, "days");
		var e_ = context.Operators.Add(a_, d_);
		var f_ = new CqlDateTime[]
		{
			b_,
			e_,
		};
		var g_ = context.Operators.MinOrNull<CqlDateTime>((f_ as IEnumerable<CqlDateTime>));
		var h_ = context.Operators.Interval(a_, g_, true, true);

		return h_;
	}

    [CqlDeclaration("Interval To Day Numbers")]
	public IEnumerable<int?> Interval_To_Day_Numbers(CqlInterval<CqlDateTime> Period)
	{
		var a_ = context.Operators.Start(Period);
		var b_ = context.Operators.End(Period);
		var c_ = context.Operators.DurationBetween(a_, b_, "day");
		var d_ = context.Operators.Interval((int?)1, c_, true, true);
		var e_ = new CqlInterval<int?>[]
		{
			d_,
		};
		var f_ = context.Operators.ExpandList((e_ as IEnumerable<CqlInterval<int?>>), null);
		int? g_(CqlInterval<int?> DayExpand)
		{
			var i_ = context.Operators.End(DayExpand);

			return i_;
		};
		var h_ = context.Operators.SelectOrNull<CqlInterval<int?>, int?>(f_, g_);

		return h_;
	}

    [CqlDeclaration("Days In Period")]
	public IEnumerable<Tuples.Tuple_BZfjDHYASdKbVKTOeigaYPBVf> Days_In_Period(CqlInterval<CqlDateTime> Period)
	{
		var a_ = this.Interval_To_Day_Numbers(Period);
		Tuples.Tuple_BZfjDHYASdKbVKTOeigaYPBVf b_(int? DayIndex)
		{
			var d_ = context.Operators.Start(Period);
			var e_ = context.Operators.Quantity(24m, "hours");
			var f_ = context.Operators.Subtract(DayIndex, (int?)1);
			var g_ = context.Operators.ConvertIntegerToQuantity(f_);
			var h_ = context.Operators.Multiply(e_, g_);
			var i_ = context.Operators.Add(d_, h_);
			CqlDateTime j_()
			{
				if ((context.Operators.Less(context.Operators.DurationBetween(context.Operators.Add(context.Operators.Start(Period), context.Operators.Multiply(context.Operators.Quantity(24m, "hours"), context.Operators.ConvertIntegerToQuantity(context.Operators.Subtract(DayIndex, (int?)1)))), context.Operators.End(Period), "hour"), (int?)24) ?? false))
				{
					var m_ = context.Operators.Start(Period);
					var n_ = context.Operators.Quantity(24m, "hours");
					var o_ = context.Operators.Subtract(DayIndex, (int?)1);
					var p_ = context.Operators.ConvertIntegerToQuantity(o_);
					var q_ = context.Operators.Multiply(n_, p_);
					var r_ = context.Operators.Add(m_, q_);

					return r_;
				}
				else
				{
					var s_ = context.Operators.Start(Period);
					var t_ = context.Operators.Quantity(24m, "hours");
					var u_ = context.Operators.ConvertIntegerToQuantity(DayIndex);
					var v_ = context.Operators.Multiply(t_, u_);
					var w_ = context.Operators.Add(s_, v_);

					return w_;
				};
			};
			var k_ = context.Operators.Interval(i_, j_(), true, false);
			var l_ = new Tuples.Tuple_BZfjDHYASdKbVKTOeigaYPBVf
			{
				dayIndex = DayIndex,
				dayPeriod = k_,
			};

			return l_;
		};
		var c_ = context.Operators.SelectOrNull<int?, Tuples.Tuple_BZfjDHYASdKbVKTOeigaYPBVf>(a_, b_);

		return c_;
	}

	private IEnumerable<Tuples.Tuple_FdccSJcWTSebijGjABdUMLEdR> Pertinent_Encounters_With_Days_Value()
	{
		var a_ = this.Initial_Population();
		Tuples.Tuple_FdccSJcWTSebijGjABdUMLEdR b_(Encounter PertinentEncounter)
		{
			var d_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(PertinentEncounter);
			var f_ = this.Crop_Interval_to_10_Days(d_);
			var h_ = this.Crop_Interval_to_10_Days(d_);
			var i_ = this.Days_In_Period(h_);
			var j_ = new Tuples.Tuple_FdccSJcWTSebijGjABdUMLEdR
			{
				encounter = PertinentEncounter,
				hospitalizationPeriod = d_,
				relevantPeriod = f_,
				relevantDays = i_,
			};

			return j_;
		};
		var c_ = context.Operators.SelectOrNull<Encounter, Tuples.Tuple_FdccSJcWTSebijGjABdUMLEdR>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Pertinent Encounters With Days")]
	public IEnumerable<Tuples.Tuple_FdccSJcWTSebijGjABdUMLEdR> Pertinent_Encounters_With_Days() => 
		__Pertinent_Encounters_With_Days.Value;

	private IEnumerable<Tuples.Tuple_GiWKJXbiXAiGGBDVZJdMTaVhK> Pertinent_Encounters_With_Glucose_Result_Days_Value()
	{
		var a_ = this.Pertinent_Encounters_With_Days();
		Tuples.Tuple_GiWKJXbiXAiGGBDVZJdMTaVhK b_(Tuples.Tuple_FdccSJcWTSebijGjABdUMLEdR PertinentEncounterDays)
		{
			var d_ = PertinentEncounterDays?.encounter;
			var e_ = PertinentEncounterDays?.relevantPeriod;
			var f_ = PertinentEncounterDays?.relevantDays;
			Tuples.Tuple_EPQMNeOgChVRHOcBPRccPNZeF g_(Tuples.Tuple_BZfjDHYASdKbVKTOeigaYPBVf EncounterDay)
			{
				var j_ = EncounterDay?.dayIndex;
				var k_ = EncounterDay?.dayPeriod;
				var l_ = this.Glucose_lab_test();
				var m_ = context.Operators.RetrieveByValueSet<Observation>(l_, null);
				bool? n_(Observation BloodGlucoseLab1)
				{
					var ac_ = BloodGlucoseLab1?.StatusElement;
					var ad_ = context.Operators.Convert<string>(ac_);
					var ae_ = context.Operators.Equal(ad_, "final");
					var af_ = BloodGlucoseLab1?.Value;
					var ag_ = FHIRHelpers_4_0_001.ToQuantity((af_ as Quantity));
					var ah_ = context.Operators.Quantity(300m, "mg/dL");
					var ai_ = context.Operators.Greater(ag_, ah_);
					var aj_ = context.Operators.And(ae_, ai_);
					var ak_ = BloodGlucoseLab1?.Effective;
					var al_ = FHIRHelpers_4_0_001.ToDateTime((ak_ as FhirDateTime));
					var am_ = EncounterDay?.dayPeriod;
					var an_ = context.Operators.ElementInInterval<CqlDateTime>(al_, am_, null);
					var ao_ = context.Operators.And(aj_, an_);

					return ao_;
				};
				var o_ = context.Operators.WhereOrNull<Observation>(m_, n_);
				var p_ = context.Operators.ExistsInList<Observation>(o_);
				var r_ = context.Operators.RetrieveByValueSet<Observation>(l_, null);
				bool? s_(Observation BloodGlucoseLab2)
				{
					var ap_ = BloodGlucoseLab2?.StatusElement;
					var aq_ = context.Operators.Convert<string>(ap_);
					var ar_ = context.Operators.Equal(aq_, "final");
					var as_ = BloodGlucoseLab2?.Value;
					var at_ = FHIRHelpers_4_0_001.ToQuantity((as_ as Quantity));
					var au_ = context.Operators.Quantity(200m, "mg/dL");
					var av_ = context.Operators.GreaterOrEqual(at_, au_);
					var aw_ = context.Operators.And(ar_, av_);
					var ax_ = BloodGlucoseLab2?.Effective;
					var ay_ = FHIRHelpers_4_0_001.ToDateTime((ax_ as FhirDateTime));
					var az_ = EncounterDay?.dayPeriod;
					var ba_ = context.Operators.ElementInInterval<CqlDateTime>(ay_, az_, null);
					var bb_ = context.Operators.And(aw_, ba_);

					return bb_;
				};
				var t_ = context.Operators.WhereOrNull<Observation>(r_, s_);
				var u_ = context.Operators.ExistsInList<Observation>(t_);
				var w_ = context.Operators.RetrieveByValueSet<Observation>(l_, null);
				bool? x_(Observation BloodGlucoseLab3)
				{
					var bc_ = BloodGlucoseLab3?.StatusElement;
					var bd_ = context.Operators.Convert<string>(bc_);
					var be_ = context.Operators.Equal(bd_, "final");
					var bf_ = BloodGlucoseLab3?.Effective;
					var bg_ = FHIRHelpers_4_0_001.ToDateTime((bf_ as FhirDateTime));
					var bh_ = EncounterDay?.dayPeriod;
					var bi_ = context.Operators.ElementInInterval<CqlDateTime>(bg_, bh_, null);
					var bj_ = context.Operators.And(be_, bi_);

					return bj_;
				};
				var y_ = context.Operators.WhereOrNull<Observation>(w_, x_);
				var z_ = context.Operators.ExistsInList<Observation>(y_);
				var aa_ = context.Operators.Not(z_);
				var ab_ = new Tuples.Tuple_EPQMNeOgChVRHOcBPRccPNZeF
				{
					dayIndex = j_,
					dayPeriod = k_,
					hasSevereResult = p_,
					hasElevatedResult = u_,
					hasNoResult = aa_,
				};

				return ab_;
			};
			var h_ = context.Operators.SelectOrNull<Tuples.Tuple_BZfjDHYASdKbVKTOeigaYPBVf, Tuples.Tuple_EPQMNeOgChVRHOcBPRccPNZeF>(f_, g_);
			var i_ = new Tuples.Tuple_GiWKJXbiXAiGGBDVZJdMTaVhK
			{
				encounter = d_,
				relevantPeriod = e_,
				relevantDays = h_,
			};

			return i_;
		};
		var c_ = context.Operators.SelectOrNull<Tuples.Tuple_FdccSJcWTSebijGjABdUMLEdR, Tuples.Tuple_GiWKJXbiXAiGGBDVZJdMTaVhK>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Pertinent Encounters With Glucose Result Days")]
	public IEnumerable<Tuples.Tuple_GiWKJXbiXAiGGBDVZJdMTaVhK> Pertinent_Encounters_With_Glucose_Result_Days() => 
		__Pertinent_Encounters_With_Glucose_Result_Days.Value;

	private IEnumerable<Tuples.Tuple_CAbQjTVRCSKOYWiIhECGMcDPA> Pertinent_Encounters_With_Hyperglycemic_Event_Days_Value()
	{
		var a_ = this.Pertinent_Encounters_With_Glucose_Result_Days();
		Tuples.Tuple_CAbQjTVRCSKOYWiIhECGMcDPA b_(Tuples.Tuple_GiWKJXbiXAiGGBDVZJdMTaVhK EncounterWithResultDays)
		{
			var d_ = EncounterWithResultDays?.encounter;
			var e_ = EncounterWithResultDays?.relevantPeriod;
			var f_ = EncounterWithResultDays?.relevantDays;
			bool? g_(Tuples.Tuple_EPQMNeOgChVRHOcBPRccPNZeF EncounterDay)
			{
				var l_ = EncounterDay?.dayIndex;
				var m_ = context.Operators.Greater(l_, (int?)1);

				return m_;
			};
			var h_ = context.Operators.WhereOrNull<Tuples.Tuple_EPQMNeOgChVRHOcBPRccPNZeF>(f_, g_);
			Tuples.Tuple_HBBaLFUhhUfQBEJKjEZegSRLi i_(Tuples.Tuple_EPQMNeOgChVRHOcBPRccPNZeF EncounterDay)
			{
				var n_ = EncounterDay?.dayIndex;
				var o_ = EncounterDay?.dayPeriod;
				var p_ = EncounterDay?.hasSevereResult;
				var q_ = EncounterDay?.hasNoResult;
				var r_ = EncounterWithResultDays?.relevantDays;
				var t_ = context.Operators.Subtract(n_, (int?)2);
				var u_ = context.Operators.ListElementAt<Tuples.Tuple_EPQMNeOgChVRHOcBPRccPNZeF>(r_, t_);
				var v_ = u_?.hasElevatedResult;
				var w_ = context.Operators.And(q_, v_);
				var z_ = context.Operators.Subtract(n_, (int?)3);
				var aa_ = context.Operators.ListElementAt<Tuples.Tuple_EPQMNeOgChVRHOcBPRccPNZeF>(r_, z_);
				var ab_ = aa_?.hasElevatedResult;
				var ac_ = context.Operators.And(w_, ab_);
				var ad_ = context.Operators.Or(p_, ac_);
				var ae_ = new Tuples.Tuple_HBBaLFUhhUfQBEJKjEZegSRLi
				{
					dayIndex = n_,
					dayPeriod = o_,
					hasHyperglycemicEvent = ad_,
				};

				return ae_;
			};
			var j_ = context.Operators.SelectOrNull<Tuples.Tuple_EPQMNeOgChVRHOcBPRccPNZeF, Tuples.Tuple_HBBaLFUhhUfQBEJKjEZegSRLi>(h_, i_);
			var k_ = new Tuples.Tuple_CAbQjTVRCSKOYWiIhECGMcDPA
			{
				encounter = d_,
				relevantPeriod = e_,
				eligibleEventDays = j_,
			};

			return k_;
		};
		var c_ = context.Operators.SelectOrNull<Tuples.Tuple_GiWKJXbiXAiGGBDVZJdMTaVhK, Tuples.Tuple_CAbQjTVRCSKOYWiIhECGMcDPA>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Pertinent Encounters With Hyperglycemic Event Days")]
	public IEnumerable<Tuples.Tuple_CAbQjTVRCSKOYWiIhECGMcDPA> Pertinent_Encounters_With_Hyperglycemic_Event_Days() => 
		__Pertinent_Encounters_With_Hyperglycemic_Event_Days.Value;

	private IEnumerable<Encounter> Numerator_Value()
	{
		var a_ = this.Pertinent_Encounters_With_Hyperglycemic_Event_Days();
		bool? b_(Tuples.Tuple_CAbQjTVRCSKOYWiIhECGMcDPA EncounterWithEventDays)
		{
			var f_ = EncounterWithEventDays?.eligibleEventDays;
			bool? g_(Tuples.Tuple_HBBaLFUhhUfQBEJKjEZegSRLi EligibleEventDay)
			{
				var j_ = EligibleEventDay?.hasHyperglycemicEvent;

				return j_;
			};
			var h_ = context.Operators.WhereOrNull<Tuples.Tuple_HBBaLFUhhUfQBEJKjEZegSRLi>(f_, g_);
			var i_ = context.Operators.ExistsInList<Tuples.Tuple_HBBaLFUhhUfQBEJKjEZegSRLi>(h_);

			return i_;
		};
		var c_ = context.Operators.WhereOrNull<Tuples.Tuple_CAbQjTVRCSKOYWiIhECGMcDPA>(a_, b_);
		Encounter d_(Tuples.Tuple_CAbQjTVRCSKOYWiIhECGMcDPA EncounterWithEventDays)
		{
			var k_ = EncounterWithEventDays?.encounter;

			return k_;
		};
		var e_ = context.Operators.SelectOrNull<Tuples.Tuple_CAbQjTVRCSKOYWiIhECGMcDPA, Encounter>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Numerator")]
	public IEnumerable<Encounter> Numerator() => 
		__Numerator.Value;

    [CqlDeclaration("Denominator Observations")]
	public int? Denominator_Observations(Encounter QualifyingEncounter)
	{
		var a_ = this.Pertinent_Encounters_With_Hyperglycemic_Event_Days();
		bool? b_(Tuples.Tuple_CAbQjTVRCSKOYWiIhECGMcDPA EncounterWithEventDays)
		{
			var g_ = EncounterWithEventDays?.encounter;
			var h_ = context.Operators.Equal(g_, QualifyingEncounter);

			return h_;
		};
		var c_ = context.Operators.WhereOrNull<Tuples.Tuple_CAbQjTVRCSKOYWiIhECGMcDPA>(a_, b_);
		int? d_(Tuples.Tuple_CAbQjTVRCSKOYWiIhECGMcDPA EncounterWithEventDays)
		{
			var i_ = EncounterWithEventDays?.eligibleEventDays;
			var j_ = context.Operators.CountOrNull<Tuples.Tuple_HBBaLFUhhUfQBEJKjEZegSRLi>(i_);

			return j_;
		};
		var e_ = context.Operators.SelectOrNull<Tuples.Tuple_CAbQjTVRCSKOYWiIhECGMcDPA, int?>(c_, d_);
		var f_ = context.Operators.SingleOrNull<int?>(e_);

		return f_;
	}

    [CqlDeclaration("Numerator Observations")]
	public int? Numerator_Observations(Encounter QualifyingEncounter)
	{
		var a_ = this.Pertinent_Encounters_With_Hyperglycemic_Event_Days();
		bool? b_(Tuples.Tuple_CAbQjTVRCSKOYWiIhECGMcDPA EncounterWithEventDays)
		{
			var g_ = EncounterWithEventDays?.encounter;
			var h_ = context.Operators.Equal(g_, QualifyingEncounter);

			return h_;
		};
		var c_ = context.Operators.WhereOrNull<Tuples.Tuple_CAbQjTVRCSKOYWiIhECGMcDPA>(a_, b_);
		int? d_(Tuples.Tuple_CAbQjTVRCSKOYWiIhECGMcDPA EncounterWithEventDays)
		{
			var i_ = EncounterWithEventDays?.eligibleEventDays;
			bool? j_(Tuples.Tuple_HBBaLFUhhUfQBEJKjEZegSRLi EligibleEventDay)
			{
				var m_ = EligibleEventDay?.hasHyperglycemicEvent;

				return m_;
			};
			var k_ = context.Operators.WhereOrNull<Tuples.Tuple_HBBaLFUhhUfQBEJKjEZegSRLi>(i_, j_);
			var l_ = context.Operators.CountOrNull<Tuples.Tuple_HBBaLFUhhUfQBEJKjEZegSRLi>(k_);

			return l_;
		};
		var e_ = context.Operators.SelectOrNull<Tuples.Tuple_CAbQjTVRCSKOYWiIhECGMcDPA, int?>(c_, d_);
		var f_ = context.Operators.SingleOrNull<int?>(e_);

		return f_;
	}

}