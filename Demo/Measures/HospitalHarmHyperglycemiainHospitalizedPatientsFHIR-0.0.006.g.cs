using System;
using Tuples;
using System.Linq;
using System.Collections.Generic;
using Hl7.Cql.Runtime;
using Hl7.Cql.Primitives;
using Hl7.Cql.Abstractions;
using Hl7.Cql.ValueSets;
using Hl7.Cql.Iso8601;
using Hl7.Fhir.Model;
using Range = Hl7.Fhir.Model.Range;
using Task = Hl7.Fhir.Model.Task;
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.0.0")]
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
    internal Lazy<IEnumerable<Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG>> __SDE_Payer;
    internal Lazy<IEnumerable<Coding>> __SDE_Race;
    internal Lazy<CqlCode> __SDE_Sex;
    internal Lazy<IEnumerable<Encounter>> __Inpatient_Encounter_During_Measurement_Period;
    internal Lazy<IEnumerable<Encounter>> __Qualifying_Encounters;
    internal Lazy<IEnumerable<Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW>> __Qualifying_Encounters_With_Hospitalization_Period;
    internal Lazy<IEnumerable<Encounter>> __Qualifying_Encounters_With_Existing_Diabetes_Diagnosis;
    internal Lazy<IEnumerable<Encounter>> __Qualifying_Encounters_With_Hypoglycemic_Medication;
    internal Lazy<IEnumerable<Encounter>> __Qualifying_Encounters_With_Elevated_Blood_Glucose_Lab;
    internal Lazy<IEnumerable<Encounter>> __Initial_Population;
    internal Lazy<IEnumerable<Encounter>> __Denominator;
    internal Lazy<IEnumerable<Tuple_FdccSJcWTSebijGjABdUMLEdR>> __Pertinent_Encounters_With_Days;
    internal Lazy<IEnumerable<Tuple_GiWKJXbiXAiGGBDVZJdMTaVhK>> __Pertinent_Encounters_With_Glucose_Result_Days;
    internal Lazy<IEnumerable<Tuple_CAbQjTVRCSKOYWiIhECGMcDPA>> __Pertinent_Encounters_With_Hyperglycemic_Event_Days;
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
        __SDE_Payer = new Lazy<IEnumerable<Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<IEnumerable<Coding>>(this.SDE_Race_Value);
        __SDE_Sex = new Lazy<CqlCode>(this.SDE_Sex_Value);
        __Inpatient_Encounter_During_Measurement_Period = new Lazy<IEnumerable<Encounter>>(this.Inpatient_Encounter_During_Measurement_Period_Value);
        __Qualifying_Encounters = new Lazy<IEnumerable<Encounter>>(this.Qualifying_Encounters_Value);
        __Qualifying_Encounters_With_Hospitalization_Period = new Lazy<IEnumerable<Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW>>(this.Qualifying_Encounters_With_Hospitalization_Period_Value);
        __Qualifying_Encounters_With_Existing_Diabetes_Diagnosis = new Lazy<IEnumerable<Encounter>>(this.Qualifying_Encounters_With_Existing_Diabetes_Diagnosis_Value);
        __Qualifying_Encounters_With_Hypoglycemic_Medication = new Lazy<IEnumerable<Encounter>>(this.Qualifying_Encounters_With_Hypoglycemic_Medication_Value);
        __Qualifying_Encounters_With_Elevated_Blood_Glucose_Lab = new Lazy<IEnumerable<Encounter>>(this.Qualifying_Encounters_With_Elevated_Blood_Glucose_Lab_Value);
        __Initial_Population = new Lazy<IEnumerable<Encounter>>(this.Initial_Population_Value);
        __Denominator = new Lazy<IEnumerable<Encounter>>(this.Denominator_Value);
        __Pertinent_Encounters_With_Days = new Lazy<IEnumerable<Tuple_FdccSJcWTSebijGjABdUMLEdR>>(this.Pertinent_Encounters_With_Days_Value);
        __Pertinent_Encounters_With_Glucose_Result_Days = new Lazy<IEnumerable<Tuple_GiWKJXbiXAiGGBDVZJdMTaVhK>>(this.Pertinent_Encounters_With_Glucose_Result_Days_Value);
        __Pertinent_Encounters_With_Hyperglycemic_Event_Days = new Lazy<IEnumerable<Tuple_CAbQjTVRCSKOYWiIhECGMcDPA>>(this.Pertinent_Encounters_With_Hyperglycemic_Event_Days_Value);
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
		CqlCode[] a_ = new CqlCode[]
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
		object a_ = context.ResolveParameter("HospitalHarmHyperglycemiainHospitalizedPatientsFHIR-0.0.006", "Measurement Period", null);

		return (CqlInterval<CqlDateTime>)a_;
	}

    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period() => 
		__Measurement_Period.Value;

	private Patient Patient_Value()
	{
		IEnumerable<Patient> a_ = context.Operators.RetrieveByValueSet<Patient>(null, null);
		Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient() => 
		__Patient.Value;

	private IEnumerable<Coding> SDE_Ethnicity_Value()
	{
		IEnumerable<Coding> a_ = SupplementalDataElementsFHIR4_2_0_000.SDE_Ethnicity();

		return a_;
	}

    [CqlDeclaration("SDE Ethnicity")]
	public IEnumerable<Coding> SDE_Ethnicity() => 
		__SDE_Ethnicity.Value;

	private IEnumerable<Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG> SDE_Payer_Value()
	{
		IEnumerable<Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG> a_ = SupplementalDataElementsFHIR4_2_0_000.SDE_Payer();

		return a_;
	}

    [CqlDeclaration("SDE Payer")]
	public IEnumerable<Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG> SDE_Payer() => 
		__SDE_Payer.Value;

	private IEnumerable<Coding> SDE_Race_Value()
	{
		IEnumerable<Coding> a_ = SupplementalDataElementsFHIR4_2_0_000.SDE_Race();

		return a_;
	}

    [CqlDeclaration("SDE Race")]
	public IEnumerable<Coding> SDE_Race() => 
		__SDE_Race.Value;

	private CqlCode SDE_Sex_Value()
	{
		CqlCode a_ = SupplementalDataElementsFHIR4_2_0_000.SDE_Sex();

		return a_;
	}

    [CqlDeclaration("SDE Sex")]
	public CqlCode SDE_Sex() => 
		__SDE_Sex.Value;

	private IEnumerable<Encounter> Inpatient_Encounter_During_Measurement_Period_Value()
	{
		CqlValueSet a_ = this.Encounter_Inpatient();
		IEnumerable<Encounter> b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);

		return b_;
	}

    [CqlDeclaration("Inpatient Encounter During Measurement Period")]
	public IEnumerable<Encounter> Inpatient_Encounter_During_Measurement_Period() => 
		__Inpatient_Encounter_During_Measurement_Period.Value;

	private IEnumerable<Encounter> Qualifying_Encounters_Value()
	{
		IEnumerable<Encounter> a_ = this.Inpatient_Encounter_During_Measurement_Period();
		bool? b_(Encounter InpatientEncounter)
		{
			Patient d_ = this.Patient();
			CqlDateTime e_ = context.Operators.ConvertStringToDateTime(d_?.BirthDateElement?.Value);
			CqlInterval<CqlDateTime> f_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(InpatientEncounter);
			CqlDateTime g_ = context.Operators.Start(f_);
			int? h_ = context.Operators.CalculateAgeAt(e_, g_, "year");
			bool? i_ = context.Operators.GreaterOrEqual(h_, 18);

			return i_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Qualifying Encounters")]
	public IEnumerable<Encounter> Qualifying_Encounters() => 
		__Qualifying_Encounters.Value;

	private IEnumerable<Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW> Qualifying_Encounters_With_Hospitalization_Period_Value()
	{
		IEnumerable<Encounter> a_ = this.Qualifying_Encounters();
		Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW b_(Encounter QualifyingEncounter)
		{
			CqlInterval<CqlDateTime> d_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(QualifyingEncounter);
			Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW e_ = new Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW
			{
				encounter = QualifyingEncounter,
				hospitalizationPeriod = d_,
			};

			return e_;
		};
		IEnumerable<Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW> c_ = context.Operators.Select<Encounter, Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Qualifying Encounters With Hospitalization Period")]
	public IEnumerable<Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW> Qualifying_Encounters_With_Hospitalization_Period() => 
		__Qualifying_Encounters_With_Hospitalization_Period.Value;

	private IEnumerable<Encounter> Qualifying_Encounters_With_Existing_Diabetes_Diagnosis_Value()
	{
		IEnumerable<Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW> a_ = this.Qualifying_Encounters_With_Hospitalization_Period();
		IEnumerable<Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW> b_(Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW EncounterWithHospitalization)
		{
			CqlValueSet f_ = this.Diabetes();
			IEnumerable<Condition> g_ = context.Operators.RetrieveByValueSet<Condition>(f_, null);
			bool? h_(Condition DiabetesDiagnosis)
			{
				CqlConcept l_ = FHIRHelpers_4_0_001.ToConcept(DiabetesDiagnosis?.VerificationStatus);
				CqlCode m_ = MATGlobalCommonFunctionsFHIR4_6_1_000.confirmed();
				CqlConcept n_ = context.Operators.ConvertCodeToConcept(m_);
				bool? o_ = context.Operators.Equivalent(l_, n_);
				CqlInterval<CqlDateTime> p_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Prevalence_Period(DiabetesDiagnosis);
				CqlDateTime q_ = context.Operators.Start(p_);
				CqlDateTime r_ = context.Operators.End(EncounterWithHospitalization?.hospitalizationPeriod);
				bool? s_ = context.Operators.Before(q_, r_, null);
				bool? t_ = context.Operators.And(o_, s_);

				return t_;
			};
			IEnumerable<Condition> i_ = context.Operators.Where<Condition>(g_, h_);
			Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW j_(Condition DiabetesDiagnosis) => 
				EncounterWithHospitalization;
			IEnumerable<Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW> k_ = context.Operators.Select<Condition, Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW>(i_, j_);

			return k_;
		};
		IEnumerable<Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW> c_ = context.Operators.SelectMany<Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW, Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW>(a_, b_);
		Encounter d_(Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW EncounterWithHospitalization) => 
			EncounterWithHospitalization?.encounter;
		IEnumerable<Encounter> e_ = context.Operators.Select<Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW, Encounter>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Qualifying Encounters With Existing Diabetes Diagnosis")]
	public IEnumerable<Encounter> Qualifying_Encounters_With_Existing_Diabetes_Diagnosis() => 
		__Qualifying_Encounters_With_Existing_Diabetes_Diagnosis.Value;

	private IEnumerable<Encounter> Qualifying_Encounters_With_Hypoglycemic_Medication_Value()
	{
		IEnumerable<Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW> a_ = this.Qualifying_Encounters_With_Hospitalization_Period();
		CqlValueSet b_ = this.Hypoglycemics_Treatment_Medications();
		IEnumerable<MedicationAdministration> c_ = context.Operators.RetrieveByValueSet<MedicationAdministration>(b_, null);
		IEnumerable<MedicationAdministration> e_ = context.Operators.RetrieveByValueSet<MedicationAdministration>(b_, null);
		IEnumerable<MedicationAdministration> f_ = context.Operators.ListUnion<MedicationAdministration>(c_, e_);
		IEnumerable<ValueTuple<Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW,MedicationAdministration>> g_ = context.Operators.CrossJoin<Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW, MedicationAdministration>(a_, f_);
		Tuple_EBCeiDEEJUjLQKCDbhKCQVIHW h_(ValueTuple<Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW,MedicationAdministration> _valueTuple)
		{
			Tuple_EBCeiDEEJUjLQKCDbhKCQVIHW n_ = new Tuple_EBCeiDEEJUjLQKCDbhKCQVIHW
			{
				EncounterWithHospitalization = _valueTuple.Item1,
				HypoglycemicMedication = _valueTuple.Item2,
			};

			return n_;
		};
		IEnumerable<Tuple_EBCeiDEEJUjLQKCDbhKCQVIHW> i_ = context.Operators.Select<ValueTuple<Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW,MedicationAdministration>, Tuple_EBCeiDEEJUjLQKCDbhKCQVIHW>(g_, h_);
		bool? j_(Tuple_EBCeiDEEJUjLQKCDbhKCQVIHW tuple_ebceideejujlqkcdbhkcqvihw)
		{
			string o_ = context.Operators.Convert<string>(tuple_ebceideejujlqkcdbhkcqvihw.HypoglycemicMedication?.StatusElement);
			bool? p_ = context.Operators.Equal(o_, "completed");
			CqlInterval<CqlDateTime> q_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(tuple_ebceideejujlqkcdbhkcqvihw.HypoglycemicMedication?.Effective);
			bool? r_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(tuple_ebceideejujlqkcdbhkcqvihw.EncounterWithHospitalization?.hospitalizationPeriod, q_, null);
			bool? s_ = context.Operators.And(p_, r_);

			return s_;
		};
		IEnumerable<Tuple_EBCeiDEEJUjLQKCDbhKCQVIHW> k_ = context.Operators.Where<Tuple_EBCeiDEEJUjLQKCDbhKCQVIHW>(i_, j_);
		Encounter l_(Tuple_EBCeiDEEJUjLQKCDbhKCQVIHW tuple_ebceideejujlqkcdbhkcqvihw) => 
			tuple_ebceideejujlqkcdbhkcqvihw.EncounterWithHospitalization?.encounter;
		IEnumerable<Encounter> m_ = context.Operators.Select<Tuple_EBCeiDEEJUjLQKCDbhKCQVIHW, Encounter>(k_, l_);

		return m_;
	}

    [CqlDeclaration("Qualifying Encounters With Hypoglycemic Medication")]
	public IEnumerable<Encounter> Qualifying_Encounters_With_Hypoglycemic_Medication() => 
		__Qualifying_Encounters_With_Hypoglycemic_Medication.Value;

	private IEnumerable<Encounter> Qualifying_Encounters_With_Elevated_Blood_Glucose_Lab_Value()
	{
		IEnumerable<Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW> a_ = this.Qualifying_Encounters_With_Hospitalization_Period();
		IEnumerable<Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW> b_(Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW EncounterWithHospitalization)
		{
			CqlValueSet f_ = this.Glucose_lab_test();
			IEnumerable<Observation> g_ = context.Operators.RetrieveByValueSet<Observation>(f_, null);
			bool? h_(Observation BloodGlucoseLab)
			{
				CqlDateTime l_ = FHIRHelpers_4_0_001.ToDateTime((BloodGlucoseLab?.Effective as FhirDateTime));
				bool? m_ = context.Operators.In<CqlDateTime>(l_, EncounterWithHospitalization?.hospitalizationPeriod, null);
				string n_ = context.Operators.Convert<string>(BloodGlucoseLab?.StatusElement);
				bool? o_ = context.Operators.Equal(n_, "final");
				bool? p_ = context.Operators.And(m_, o_);
				CqlQuantity q_ = FHIRHelpers_4_0_001.ToQuantity((BloodGlucoseLab?.Value as Quantity));
				CqlQuantity r_ = context.Operators.Quantity(200m, "mg/dL");
				bool? s_ = context.Operators.GreaterOrEqual(q_, r_);
				bool? t_ = context.Operators.And(p_, s_);

				return t_;
			};
			IEnumerable<Observation> i_ = context.Operators.Where<Observation>(g_, h_);
			Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW j_(Observation BloodGlucoseLab) => 
				EncounterWithHospitalization;
			IEnumerable<Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW> k_ = context.Operators.Select<Observation, Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW>(i_, j_);

			return k_;
		};
		IEnumerable<Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW> c_ = context.Operators.SelectMany<Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW, Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW>(a_, b_);
		Encounter d_(Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW EncounterWithHospitalization) => 
			EncounterWithHospitalization?.encounter;
		IEnumerable<Encounter> e_ = context.Operators.Select<Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW, Encounter>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Qualifying Encounters With Elevated Blood Glucose Lab")]
	public IEnumerable<Encounter> Qualifying_Encounters_With_Elevated_Blood_Glucose_Lab() => 
		__Qualifying_Encounters_With_Elevated_Blood_Glucose_Lab.Value;

	private IEnumerable<Encounter> Initial_Population_Value()
	{
		IEnumerable<Encounter> a_ = this.Qualifying_Encounters_With_Existing_Diabetes_Diagnosis();
		IEnumerable<Encounter> b_ = this.Qualifying_Encounters_With_Hypoglycemic_Medication();
		IEnumerable<Encounter> c_ = context.Operators.ListUnion<Encounter>(a_, b_);
		IEnumerable<Encounter> d_ = this.Qualifying_Encounters_With_Elevated_Blood_Glucose_Lab();
		IEnumerable<Encounter> e_ = context.Operators.ListUnion<Encounter>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Initial Population")]
	public IEnumerable<Encounter> Initial_Population() => 
		__Initial_Population.Value;

	private IEnumerable<Encounter> Denominator_Value()
	{
		IEnumerable<Encounter> a_ = this.Initial_Population();

		return a_;
	}

    [CqlDeclaration("Denominator")]
	public IEnumerable<Encounter> Denominator() => 
		__Denominator.Value;

    [CqlDeclaration("Crop Interval to 10 Days")]
	public CqlInterval<CqlDateTime> Crop_Interval_to_10_Days(CqlInterval<CqlDateTime> Period)
	{
		CqlDateTime a_ = context.Operators.Start(Period);
		CqlDateTime b_ = context.Operators.End(Period);
		CqlQuantity d_ = context.Operators.Quantity(10m, "days");
		CqlDateTime e_ = context.Operators.Add(a_, d_);
		CqlDateTime[] f_ = new CqlDateTime[]
		{
			b_,
			e_,
		};
		CqlDateTime g_ = context.Operators.Min<CqlDateTime>((f_ as IEnumerable<CqlDateTime>));
		CqlInterval<CqlDateTime> h_ = context.Operators.Interval(a_, g_, true, true);

		return h_;
	}

    [CqlDeclaration("Interval To Day Numbers")]
	public IEnumerable<int?> Interval_To_Day_Numbers(CqlInterval<CqlDateTime> Period)
	{
		CqlDateTime a_ = context.Operators.Start(Period);
		CqlDateTime b_ = context.Operators.End(Period);
		int? c_ = context.Operators.DurationBetween(a_, b_, "day");
		CqlInterval<int?> d_ = context.Operators.Interval(1, c_, true, true);
		CqlInterval<int?>[] e_ = new CqlInterval<int?>[]
		{
			d_,
		};
		IEnumerable<CqlInterval<int?>> f_ = context.Operators.Expand((e_ as IEnumerable<CqlInterval<int?>>), null);
		int? g_(CqlInterval<int?> DayExpand)
		{
			int? i_ = context.Operators.End(DayExpand);

			return i_;
		};
		IEnumerable<int?> h_ = context.Operators.Select<CqlInterval<int?>, int?>(f_, g_);

		return h_;
	}

    [CqlDeclaration("Days In Period")]
	public IEnumerable<Tuple_BZfjDHYASdKbVKTOeigaYPBVf> Days_In_Period(CqlInterval<CqlDateTime> Period)
	{
		IEnumerable<int?> a_ = this.Interval_To_Day_Numbers(Period);
		Tuple_BZfjDHYASdKbVKTOeigaYPBVf b_(int? DayIndex)
		{
			CqlDateTime d_ = context.Operators.Start(Period);
			CqlQuantity e_ = context.Operators.Quantity(24m, "hours");
			int? f_ = context.Operators.Subtract(DayIndex, 1);
			CqlQuantity g_ = context.Operators.ConvertIntegerToQuantity(f_);
			CqlQuantity h_ = context.Operators.Multiply(e_, g_);
			CqlDateTime i_ = context.Operators.Add(d_, h_);
			CqlDateTime j_()
			{
				bool m_()
				{
					CqlDateTime n_ = context.Operators.Start(Period);
					CqlQuantity o_ = context.Operators.Quantity(24m, "hours");
					int? p_ = context.Operators.Subtract(DayIndex, 1);
					CqlQuantity q_ = context.Operators.ConvertIntegerToQuantity(p_);
					CqlQuantity r_ = context.Operators.Multiply(o_, q_);
					CqlDateTime s_ = context.Operators.Add(n_, r_);
					CqlDateTime t_ = context.Operators.End(Period);
					int? u_ = context.Operators.DurationBetween(s_, t_, "hour");
					bool? v_ = context.Operators.Less(u_, 24);

					return (v_ ?? false);
				};
				if (m_())
				{
					CqlDateTime w_ = context.Operators.Start(Period);
					CqlQuantity x_ = context.Operators.Quantity(24m, "hours");
					int? y_ = context.Operators.Subtract(DayIndex, 1);
					CqlQuantity z_ = context.Operators.ConvertIntegerToQuantity(y_);
					CqlQuantity aa_ = context.Operators.Multiply(x_, z_);
					CqlDateTime ab_ = context.Operators.Add(w_, aa_);

					return ab_;
				}
				else
				{
					CqlDateTime ac_ = context.Operators.Start(Period);
					CqlQuantity ad_ = context.Operators.Quantity(24m, "hours");
					CqlQuantity ae_ = context.Operators.ConvertIntegerToQuantity(DayIndex);
					CqlQuantity af_ = context.Operators.Multiply(ad_, ae_);
					CqlDateTime ag_ = context.Operators.Add(ac_, af_);

					return ag_;
				};
			};
			CqlInterval<CqlDateTime> k_ = context.Operators.Interval(i_, j_(), true, false);
			Tuple_BZfjDHYASdKbVKTOeigaYPBVf l_ = new Tuple_BZfjDHYASdKbVKTOeigaYPBVf
			{
				dayIndex = DayIndex,
				dayPeriod = k_,
			};

			return l_;
		};
		IEnumerable<Tuple_BZfjDHYASdKbVKTOeigaYPBVf> c_ = context.Operators.Select<int?, Tuple_BZfjDHYASdKbVKTOeigaYPBVf>(a_, b_);

		return c_;
	}

	private IEnumerable<Tuple_FdccSJcWTSebijGjABdUMLEdR> Pertinent_Encounters_With_Days_Value()
	{
		IEnumerable<Encounter> a_ = this.Initial_Population();
		Tuple_FdccSJcWTSebijGjABdUMLEdR b_(Encounter PertinentEncounter)
		{
			CqlInterval<CqlDateTime> d_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(PertinentEncounter);
			CqlInterval<CqlDateTime> f_ = this.Crop_Interval_to_10_Days(d_);
			CqlInterval<CqlDateTime> h_ = this.Crop_Interval_to_10_Days(d_);
			IEnumerable<Tuple_BZfjDHYASdKbVKTOeigaYPBVf> i_ = this.Days_In_Period(h_);
			Tuple_FdccSJcWTSebijGjABdUMLEdR j_ = new Tuple_FdccSJcWTSebijGjABdUMLEdR
			{
				encounter = PertinentEncounter,
				hospitalizationPeriod = d_,
				relevantPeriod = f_,
				relevantDays = i_,
			};

			return j_;
		};
		IEnumerable<Tuple_FdccSJcWTSebijGjABdUMLEdR> c_ = context.Operators.Select<Encounter, Tuple_FdccSJcWTSebijGjABdUMLEdR>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Pertinent Encounters With Days")]
	public IEnumerable<Tuple_FdccSJcWTSebijGjABdUMLEdR> Pertinent_Encounters_With_Days() => 
		__Pertinent_Encounters_With_Days.Value;

	private IEnumerable<Tuple_GiWKJXbiXAiGGBDVZJdMTaVhK> Pertinent_Encounters_With_Glucose_Result_Days_Value()
	{
		IEnumerable<Tuple_FdccSJcWTSebijGjABdUMLEdR> a_ = this.Pertinent_Encounters_With_Days();
		Tuple_GiWKJXbiXAiGGBDVZJdMTaVhK b_(Tuple_FdccSJcWTSebijGjABdUMLEdR PertinentEncounterDays)
		{
			Tuple_EPQMNeOgChVRHOcBPRccPNZeF d_(Tuple_BZfjDHYASdKbVKTOeigaYPBVf EncounterDay)
			{
				CqlValueSet g_ = this.Glucose_lab_test();
				IEnumerable<Observation> h_ = context.Operators.RetrieveByValueSet<Observation>(g_, null);
				bool? i_(Observation BloodGlucoseLab1)
				{
					string x_ = context.Operators.Convert<string>(BloodGlucoseLab1?.StatusElement);
					bool? y_ = context.Operators.Equal(x_, "final");
					CqlQuantity z_ = FHIRHelpers_4_0_001.ToQuantity((BloodGlucoseLab1?.Value as Quantity));
					CqlQuantity aa_ = context.Operators.Quantity(300m, "mg/dL");
					bool? ab_ = context.Operators.Greater(z_, aa_);
					bool? ac_ = context.Operators.And(y_, ab_);
					CqlDateTime ad_ = FHIRHelpers_4_0_001.ToDateTime((BloodGlucoseLab1?.Effective as FhirDateTime));
					bool? ae_ = context.Operators.In<CqlDateTime>(ad_, EncounterDay?.dayPeriod, null);
					bool? af_ = context.Operators.And(ac_, ae_);

					return af_;
				};
				IEnumerable<Observation> j_ = context.Operators.Where<Observation>(h_, i_);
				bool? k_ = context.Operators.Exists<Observation>(j_);
				IEnumerable<Observation> m_ = context.Operators.RetrieveByValueSet<Observation>(g_, null);
				bool? n_(Observation BloodGlucoseLab2)
				{
					string ag_ = context.Operators.Convert<string>(BloodGlucoseLab2?.StatusElement);
					bool? ah_ = context.Operators.Equal(ag_, "final");
					CqlQuantity ai_ = FHIRHelpers_4_0_001.ToQuantity((BloodGlucoseLab2?.Value as Quantity));
					CqlQuantity aj_ = context.Operators.Quantity(200m, "mg/dL");
					bool? ak_ = context.Operators.GreaterOrEqual(ai_, aj_);
					bool? al_ = context.Operators.And(ah_, ak_);
					CqlDateTime am_ = FHIRHelpers_4_0_001.ToDateTime((BloodGlucoseLab2?.Effective as FhirDateTime));
					bool? an_ = context.Operators.In<CqlDateTime>(am_, EncounterDay?.dayPeriod, null);
					bool? ao_ = context.Operators.And(al_, an_);

					return ao_;
				};
				IEnumerable<Observation> o_ = context.Operators.Where<Observation>(m_, n_);
				bool? p_ = context.Operators.Exists<Observation>(o_);
				IEnumerable<Observation> r_ = context.Operators.RetrieveByValueSet<Observation>(g_, null);
				bool? s_(Observation BloodGlucoseLab3)
				{
					string ap_ = context.Operators.Convert<string>(BloodGlucoseLab3?.StatusElement);
					bool? aq_ = context.Operators.Equal(ap_, "final");
					CqlDateTime ar_ = FHIRHelpers_4_0_001.ToDateTime((BloodGlucoseLab3?.Effective as FhirDateTime));
					bool? as_ = context.Operators.In<CqlDateTime>(ar_, EncounterDay?.dayPeriod, null);
					bool? at_ = context.Operators.And(aq_, as_);

					return at_;
				};
				IEnumerable<Observation> t_ = context.Operators.Where<Observation>(r_, s_);
				bool? u_ = context.Operators.Exists<Observation>(t_);
				bool? v_ = context.Operators.Not(u_);
				Tuple_EPQMNeOgChVRHOcBPRccPNZeF w_ = new Tuple_EPQMNeOgChVRHOcBPRccPNZeF
				{
					dayIndex = EncounterDay?.dayIndex,
					dayPeriod = EncounterDay?.dayPeriod,
					hasSevereResult = k_,
					hasElevatedResult = p_,
					hasNoResult = v_,
				};

				return w_;
			};
			IEnumerable<Tuple_EPQMNeOgChVRHOcBPRccPNZeF> e_ = context.Operators.Select<Tuple_BZfjDHYASdKbVKTOeigaYPBVf, Tuple_EPQMNeOgChVRHOcBPRccPNZeF>(PertinentEncounterDays?.relevantDays, d_);
			Tuple_GiWKJXbiXAiGGBDVZJdMTaVhK f_ = new Tuple_GiWKJXbiXAiGGBDVZJdMTaVhK
			{
				encounter = PertinentEncounterDays?.encounter,
				relevantPeriod = PertinentEncounterDays?.relevantPeriod,
				relevantDays = e_,
			};

			return f_;
		};
		IEnumerable<Tuple_GiWKJXbiXAiGGBDVZJdMTaVhK> c_ = context.Operators.Select<Tuple_FdccSJcWTSebijGjABdUMLEdR, Tuple_GiWKJXbiXAiGGBDVZJdMTaVhK>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Pertinent Encounters With Glucose Result Days")]
	public IEnumerable<Tuple_GiWKJXbiXAiGGBDVZJdMTaVhK> Pertinent_Encounters_With_Glucose_Result_Days() => 
		__Pertinent_Encounters_With_Glucose_Result_Days.Value;

	private IEnumerable<Tuple_CAbQjTVRCSKOYWiIhECGMcDPA> Pertinent_Encounters_With_Hyperglycemic_Event_Days_Value()
	{
		IEnumerable<Tuple_GiWKJXbiXAiGGBDVZJdMTaVhK> a_ = this.Pertinent_Encounters_With_Glucose_Result_Days();
		Tuple_CAbQjTVRCSKOYWiIhECGMcDPA b_(Tuple_GiWKJXbiXAiGGBDVZJdMTaVhK EncounterWithResultDays)
		{
			bool? d_(Tuple_EPQMNeOgChVRHOcBPRccPNZeF EncounterDay)
			{
				bool? i_ = context.Operators.Greater(EncounterDay?.dayIndex, 1);

				return i_;
			};
			IEnumerable<Tuple_EPQMNeOgChVRHOcBPRccPNZeF> e_ = context.Operators.Where<Tuple_EPQMNeOgChVRHOcBPRccPNZeF>(EncounterWithResultDays?.relevantDays, d_);
			Tuple_HBBaLFUhhUfQBEJKjEZegSRLi f_(Tuple_EPQMNeOgChVRHOcBPRccPNZeF EncounterDay)
			{
				int? j_ = context.Operators.Subtract(EncounterDay?.dayIndex, 2);
				Tuple_EPQMNeOgChVRHOcBPRccPNZeF k_ = context.Operators.Indexer<Tuple_EPQMNeOgChVRHOcBPRccPNZeF>(EncounterWithResultDays?.relevantDays, j_);
				bool? l_ = context.Operators.And(EncounterDay?.hasNoResult, k_?.hasElevatedResult);
				int? m_ = context.Operators.Subtract(EncounterDay?.dayIndex, 3);
				Tuple_EPQMNeOgChVRHOcBPRccPNZeF n_ = context.Operators.Indexer<Tuple_EPQMNeOgChVRHOcBPRccPNZeF>(EncounterWithResultDays?.relevantDays, m_);
				bool? o_ = context.Operators.And(l_, n_?.hasElevatedResult);
				bool? p_ = context.Operators.Or(EncounterDay?.hasSevereResult, o_);
				Tuple_HBBaLFUhhUfQBEJKjEZegSRLi q_ = new Tuple_HBBaLFUhhUfQBEJKjEZegSRLi
				{
					dayIndex = EncounterDay?.dayIndex,
					dayPeriod = EncounterDay?.dayPeriod,
					hasHyperglycemicEvent = p_,
				};

				return q_;
			};
			IEnumerable<Tuple_HBBaLFUhhUfQBEJKjEZegSRLi> g_ = context.Operators.Select<Tuple_EPQMNeOgChVRHOcBPRccPNZeF, Tuple_HBBaLFUhhUfQBEJKjEZegSRLi>(e_, f_);
			Tuple_CAbQjTVRCSKOYWiIhECGMcDPA h_ = new Tuple_CAbQjTVRCSKOYWiIhECGMcDPA
			{
				encounter = EncounterWithResultDays?.encounter,
				relevantPeriod = EncounterWithResultDays?.relevantPeriod,
				eligibleEventDays = g_,
			};

			return h_;
		};
		IEnumerable<Tuple_CAbQjTVRCSKOYWiIhECGMcDPA> c_ = context.Operators.Select<Tuple_GiWKJXbiXAiGGBDVZJdMTaVhK, Tuple_CAbQjTVRCSKOYWiIhECGMcDPA>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Pertinent Encounters With Hyperglycemic Event Days")]
	public IEnumerable<Tuple_CAbQjTVRCSKOYWiIhECGMcDPA> Pertinent_Encounters_With_Hyperglycemic_Event_Days() => 
		__Pertinent_Encounters_With_Hyperglycemic_Event_Days.Value;

	private IEnumerable<Encounter> Numerator_Value()
	{
		IEnumerable<Tuple_CAbQjTVRCSKOYWiIhECGMcDPA> a_ = this.Pertinent_Encounters_With_Hyperglycemic_Event_Days();
		bool? b_(Tuple_CAbQjTVRCSKOYWiIhECGMcDPA EncounterWithEventDays)
		{
			bool? f_(Tuple_HBBaLFUhhUfQBEJKjEZegSRLi EligibleEventDay) => 
				EligibleEventDay?.hasHyperglycemicEvent;
			IEnumerable<Tuple_HBBaLFUhhUfQBEJKjEZegSRLi> g_ = context.Operators.Where<Tuple_HBBaLFUhhUfQBEJKjEZegSRLi>(EncounterWithEventDays?.eligibleEventDays, f_);
			bool? h_ = context.Operators.Exists<Tuple_HBBaLFUhhUfQBEJKjEZegSRLi>(g_);

			return h_;
		};
		IEnumerable<Tuple_CAbQjTVRCSKOYWiIhECGMcDPA> c_ = context.Operators.Where<Tuple_CAbQjTVRCSKOYWiIhECGMcDPA>(a_, b_);
		Encounter d_(Tuple_CAbQjTVRCSKOYWiIhECGMcDPA EncounterWithEventDays) => 
			EncounterWithEventDays?.encounter;
		IEnumerable<Encounter> e_ = context.Operators.Select<Tuple_CAbQjTVRCSKOYWiIhECGMcDPA, Encounter>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Numerator")]
	public IEnumerable<Encounter> Numerator() => 
		__Numerator.Value;

    [CqlDeclaration("Denominator Observations")]
	public int? Denominator_Observations(Encounter QualifyingEncounter)
	{
		IEnumerable<Tuple_CAbQjTVRCSKOYWiIhECGMcDPA> a_ = this.Pertinent_Encounters_With_Hyperglycemic_Event_Days();
		bool? b_(Tuple_CAbQjTVRCSKOYWiIhECGMcDPA EncounterWithEventDays)
		{
			bool? g_ = context.Operators.Equal(EncounterWithEventDays?.encounter, QualifyingEncounter);

			return g_;
		};
		IEnumerable<Tuple_CAbQjTVRCSKOYWiIhECGMcDPA> c_ = context.Operators.Where<Tuple_CAbQjTVRCSKOYWiIhECGMcDPA>(a_, b_);
		int? d_(Tuple_CAbQjTVRCSKOYWiIhECGMcDPA EncounterWithEventDays)
		{
			int? h_ = context.Operators.Count<Tuple_HBBaLFUhhUfQBEJKjEZegSRLi>(EncounterWithEventDays?.eligibleEventDays);

			return h_;
		};
		IEnumerable<int?> e_ = context.Operators.Select<Tuple_CAbQjTVRCSKOYWiIhECGMcDPA, int?>(c_, d_);
		int? f_ = context.Operators.SingletonFrom<int?>(e_);

		return f_;
	}

    [CqlDeclaration("Numerator Observations")]
	public int? Numerator_Observations(Encounter QualifyingEncounter)
	{
		IEnumerable<Tuple_CAbQjTVRCSKOYWiIhECGMcDPA> a_ = this.Pertinent_Encounters_With_Hyperglycemic_Event_Days();
		bool? b_(Tuple_CAbQjTVRCSKOYWiIhECGMcDPA EncounterWithEventDays)
		{
			bool? g_ = context.Operators.Equal(EncounterWithEventDays?.encounter, QualifyingEncounter);

			return g_;
		};
		IEnumerable<Tuple_CAbQjTVRCSKOYWiIhECGMcDPA> c_ = context.Operators.Where<Tuple_CAbQjTVRCSKOYWiIhECGMcDPA>(a_, b_);
		int? d_(Tuple_CAbQjTVRCSKOYWiIhECGMcDPA EncounterWithEventDays)
		{
			bool? h_(Tuple_HBBaLFUhhUfQBEJKjEZegSRLi EligibleEventDay) => 
				EligibleEventDay?.hasHyperglycemicEvent;
			IEnumerable<Tuple_HBBaLFUhhUfQBEJKjEZegSRLi> i_ = context.Operators.Where<Tuple_HBBaLFUhhUfQBEJKjEZegSRLi>(EncounterWithEventDays?.eligibleEventDays, h_);
			int? j_ = context.Operators.Count<Tuple_HBBaLFUhhUfQBEJKjEZegSRLi>(i_);

			return j_;
		};
		IEnumerable<int?> e_ = context.Operators.Select<Tuple_CAbQjTVRCSKOYWiIhECGMcDPA, int?>(c_, d_);
		int? f_ = context.Operators.SingletonFrom<int?>(e_);

		return f_;
	}

}
