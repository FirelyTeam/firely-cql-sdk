using System;
using Tuples;
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
    internal Lazy<IEnumerable<Tuple_CaKghTfWMNOTHSWhifjFZOVYO>> __SDE_Payer;
    internal Lazy<IEnumerable<Coding>> __SDE_Race;
    internal Lazy<CqlCode> __SDE_Sex;
    internal Lazy<IEnumerable<Encounter>> __Inpatient_Encounter_During_Measurement_Period;
    internal Lazy<IEnumerable<Encounter>> __Qualifying_Encounters;
    internal Lazy<IEnumerable<Tuple_GPLfQTPONQabPZigKbYFERDVQ>> __Qualifying_Encounters_With_Hospitalization_Period;
    internal Lazy<IEnumerable<Encounter>> __Qualifying_Encounters_With_Existing_Diabetes_Diagnosis;
    internal Lazy<IEnumerable<Encounter>> __Qualifying_Encounters_With_Hypoglycemic_Medication;
    internal Lazy<IEnumerable<Encounter>> __Qualifying_Encounters_With_Elevated_Blood_Glucose_Lab;
    internal Lazy<IEnumerable<Encounter>> __Initial_Population;
    internal Lazy<IEnumerable<Encounter>> __Denominator;
    internal Lazy<IEnumerable<Tuple_BFFMVKRWdCJDYTgBWYHeLPiha>> __Pertinent_Encounters_With_Days;
    internal Lazy<IEnumerable<Tuple_BVGhTTBTiPLQVGZRfJbXRNFfF>> __Pertinent_Encounters_With_Glucose_Result_Days;
    internal Lazy<IEnumerable<Tuple_DNEVNMCYfTaYQDAThWFVOgQaT>> __Pertinent_Encounters_With_Hyperglycemic_Event_Days;
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
        __SDE_Payer = new Lazy<IEnumerable<Tuple_CaKghTfWMNOTHSWhifjFZOVYO>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<IEnumerable<Coding>>(this.SDE_Race_Value);
        __SDE_Sex = new Lazy<CqlCode>(this.SDE_Sex_Value);
        __Inpatient_Encounter_During_Measurement_Period = new Lazy<IEnumerable<Encounter>>(this.Inpatient_Encounter_During_Measurement_Period_Value);
        __Qualifying_Encounters = new Lazy<IEnumerable<Encounter>>(this.Qualifying_Encounters_Value);
        __Qualifying_Encounters_With_Hospitalization_Period = new Lazy<IEnumerable<Tuple_GPLfQTPONQabPZigKbYFERDVQ>>(this.Qualifying_Encounters_With_Hospitalization_Period_Value);
        __Qualifying_Encounters_With_Existing_Diabetes_Diagnosis = new Lazy<IEnumerable<Encounter>>(this.Qualifying_Encounters_With_Existing_Diabetes_Diagnosis_Value);
        __Qualifying_Encounters_With_Hypoglycemic_Medication = new Lazy<IEnumerable<Encounter>>(this.Qualifying_Encounters_With_Hypoglycemic_Medication_Value);
        __Qualifying_Encounters_With_Elevated_Blood_Glucose_Lab = new Lazy<IEnumerable<Encounter>>(this.Qualifying_Encounters_With_Elevated_Blood_Glucose_Lab_Value);
        __Initial_Population = new Lazy<IEnumerable<Encounter>>(this.Initial_Population_Value);
        __Denominator = new Lazy<IEnumerable<Encounter>>(this.Denominator_Value);
        __Pertinent_Encounters_With_Days = new Lazy<IEnumerable<Tuple_BFFMVKRWdCJDYTgBWYHeLPiha>>(this.Pertinent_Encounters_With_Days_Value);
        __Pertinent_Encounters_With_Glucose_Result_Days = new Lazy<IEnumerable<Tuple_BVGhTTBTiPLQVGZRfJbXRNFfF>>(this.Pertinent_Encounters_With_Glucose_Result_Days_Value);
        __Pertinent_Encounters_With_Hyperglycemic_Event_Days = new Lazy<IEnumerable<Tuple_DNEVNMCYfTaYQDAThWFVOgQaT>>(this.Pertinent_Encounters_With_Hyperglycemic_Event_Days_Value);
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
		var b_ = context.Operators.SingletonFrom<Patient>(a_);

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

	private IEnumerable<Tuple_CaKghTfWMNOTHSWhifjFZOVYO> SDE_Payer_Value()
	{
		var a_ = SupplementalDataElementsFHIR4_2_0_000.SDE_Payer();

		return a_;
	}

    [CqlDeclaration("SDE Payer")]
	public IEnumerable<Tuple_CaKghTfWMNOTHSWhifjFZOVYO> SDE_Payer() => 
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
			var k_ = context.Operators.GreaterOrEqual(j_, 18);

			return k_;
		};
		var c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Qualifying Encounters")]
	public IEnumerable<Encounter> Qualifying_Encounters() => 
		__Qualifying_Encounters.Value;

	private IEnumerable<Tuple_GPLfQTPONQabPZigKbYFERDVQ> Qualifying_Encounters_With_Hospitalization_Period_Value()
	{
		var a_ = this.Qualifying_Encounters();
		Tuple_GPLfQTPONQabPZigKbYFERDVQ b_(Encounter QualifyingEncounter)
		{
			var d_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(QualifyingEncounter);
			var e_ = new Tuple_GPLfQTPONQabPZigKbYFERDVQ
			{
				encounter = QualifyingEncounter,
				hospitalizationPeriod = d_,
			};

			return e_;
		};
		var c_ = context.Operators.Select<Encounter, Tuple_GPLfQTPONQabPZigKbYFERDVQ>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Qualifying Encounters With Hospitalization Period")]
	public IEnumerable<Tuple_GPLfQTPONQabPZigKbYFERDVQ> Qualifying_Encounters_With_Hospitalization_Period() => 
		__Qualifying_Encounters_With_Hospitalization_Period.Value;

	private IEnumerable<Encounter> Qualifying_Encounters_With_Existing_Diabetes_Diagnosis_Value()
	{
		var a_ = this.Qualifying_Encounters_With_Hospitalization_Period();
		IEnumerable<Tuple_GPLfQTPONQabPZigKbYFERDVQ> b_(Tuple_GPLfQTPONQabPZigKbYFERDVQ EncounterWithHospitalization)
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
			var i_ = context.Operators.Where<Condition>(g_, h_);
			Tuple_GPLfQTPONQabPZigKbYFERDVQ j_(Condition DiabetesDiagnosis) => 
				EncounterWithHospitalization;
			var k_ = context.Operators.Select<Condition, Tuple_GPLfQTPONQabPZigKbYFERDVQ>(i_, j_);

			return k_;
		};
		var c_ = context.Operators.SelectMany<Tuple_GPLfQTPONQabPZigKbYFERDVQ, Tuple_GPLfQTPONQabPZigKbYFERDVQ>(a_, b_);
		Encounter d_(Tuple_GPLfQTPONQabPZigKbYFERDVQ EncounterWithHospitalization)
		{
			var w_ = EncounterWithHospitalization?.encounter;

			return w_;
		};
		var e_ = context.Operators.Select<Tuple_GPLfQTPONQabPZigKbYFERDVQ, Encounter>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Qualifying Encounters With Existing Diabetes Diagnosis")]
	public IEnumerable<Encounter> Qualifying_Encounters_With_Existing_Diabetes_Diagnosis() => 
		__Qualifying_Encounters_With_Existing_Diabetes_Diagnosis.Value;

	private IEnumerable<Encounter> Qualifying_Encounters_With_Hypoglycemic_Medication_Value()
	{
		var a_ = this.Qualifying_Encounters_With_Hospitalization_Period();
		var b_ = this.Hypoglycemics_Treatment_Medications();
		var c_ = context.Operators.RetrieveByValueSet<MedicationAdministration>(b_, null);
		var e_ = context.Operators.RetrieveByValueSet<MedicationAdministration>(b_, null);
		var f_ = context.Operators.Union<MedicationAdministration>(c_, e_);
		var g_ = context.Operators.CrossJoin<Tuple_GPLfQTPONQabPZigKbYFERDVQ, MedicationAdministration>(a_, f_);
		Tuple_CLXCRdeeSPOVHRdOZOXQZeIEB h_(ValueTuple<Tuple_GPLfQTPONQabPZigKbYFERDVQ, MedicationAdministration> _valueTuple)
		{
			var n_ = new Tuple_CLXCRdeeSPOVHRdOZOXQZeIEB
			{
				EncounterWithHospitalization = _valueTuple.Item1,
				HypoglycemicMedication = _valueTuple.Item2,
			};

			return n_;
		};
		var i_ = context.Operators.Select<ValueTuple<Tuple_GPLfQTPONQabPZigKbYFERDVQ, MedicationAdministration>, Tuple_CLXCRdeeSPOVHRdOZOXQZeIEB>(g_, h_);
		bool? j_(Tuple_CLXCRdeeSPOVHRdOZOXQZeIEB tuple_clxcrdeespovhrdozoxqzeieb)
		{
			var o_ = tuple_clxcrdeespovhrdozoxqzeieb.HypoglycemicMedication?.StatusElement;
			var p_ = FHIRHelpers_4_0_001.ToString(o_);
			var q_ = context.Operators.Equal(p_, "completed");
			var r_ = tuple_clxcrdeespovhrdozoxqzeieb.EncounterWithHospitalization?.hospitalizationPeriod;
			var s_ = tuple_clxcrdeespovhrdozoxqzeieb.HypoglycemicMedication?.Effective;
			var t_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(s_);
			var u_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(r_, t_, null);
			var v_ = context.Operators.And(q_, u_);

			return v_;
		};
		var k_ = context.Operators.Where<Tuple_CLXCRdeeSPOVHRdOZOXQZeIEB>(i_, j_);
		Encounter l_(Tuple_CLXCRdeeSPOVHRdOZOXQZeIEB tuple_clxcrdeespovhrdozoxqzeieb)
		{
			var w_ = tuple_clxcrdeespovhrdozoxqzeieb.EncounterWithHospitalization?.encounter;

			return w_;
		};
		var m_ = context.Operators.Select<Tuple_CLXCRdeeSPOVHRdOZOXQZeIEB, Encounter>(k_, l_);

		return m_;
	}

    [CqlDeclaration("Qualifying Encounters With Hypoglycemic Medication")]
	public IEnumerable<Encounter> Qualifying_Encounters_With_Hypoglycemic_Medication() => 
		__Qualifying_Encounters_With_Hypoglycemic_Medication.Value;

	private IEnumerable<Encounter> Qualifying_Encounters_With_Elevated_Blood_Glucose_Lab_Value()
	{
		var a_ = this.Qualifying_Encounters_With_Hospitalization_Period();
		IEnumerable<Tuple_GPLfQTPONQabPZigKbYFERDVQ> b_(Tuple_GPLfQTPONQabPZigKbYFERDVQ EncounterWithHospitalization)
		{
			var f_ = this.Glucose_lab_test();
			var g_ = context.Operators.RetrieveByValueSet<Observation>(f_, null);
			bool? h_(Observation BloodGlucoseLab)
			{
				var l_ = BloodGlucoseLab?.Effective;
				var m_ = FHIRHelpers_4_0_001.ToDateTime((l_ as FhirDateTime));
				var n_ = EncounterWithHospitalization?.hospitalizationPeriod;
				var o_ = context.Operators.In<CqlDateTime>(m_, n_, null);
				var p_ = BloodGlucoseLab?.StatusElement;
				var q_ = FHIRHelpers_4_0_001.ToString(p_);
				var r_ = context.Operators.Equal(q_, "final");
				var s_ = context.Operators.And(o_, r_);
				var t_ = BloodGlucoseLab?.Value;
				var u_ = FHIRHelpers_4_0_001.ToQuantity((t_ as Quantity));
				var v_ = context.Operators.Quantity(200m, "mg/dL");
				var w_ = context.Operators.GreaterOrEqual(u_, v_);
				var x_ = context.Operators.And(s_, w_);

				return x_;
			};
			var i_ = context.Operators.Where<Observation>(g_, h_);
			Tuple_GPLfQTPONQabPZigKbYFERDVQ j_(Observation BloodGlucoseLab) => 
				EncounterWithHospitalization;
			var k_ = context.Operators.Select<Observation, Tuple_GPLfQTPONQabPZigKbYFERDVQ>(i_, j_);

			return k_;
		};
		var c_ = context.Operators.SelectMany<Tuple_GPLfQTPONQabPZigKbYFERDVQ, Tuple_GPLfQTPONQabPZigKbYFERDVQ>(a_, b_);
		Encounter d_(Tuple_GPLfQTPONQabPZigKbYFERDVQ EncounterWithHospitalization)
		{
			var y_ = EncounterWithHospitalization?.encounter;

			return y_;
		};
		var e_ = context.Operators.Select<Tuple_GPLfQTPONQabPZigKbYFERDVQ, Encounter>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Qualifying Encounters With Elevated Blood Glucose Lab")]
	public IEnumerable<Encounter> Qualifying_Encounters_With_Elevated_Blood_Glucose_Lab() => 
		__Qualifying_Encounters_With_Elevated_Blood_Glucose_Lab.Value;

	private IEnumerable<Encounter> Initial_Population_Value()
	{
		var a_ = this.Qualifying_Encounters_With_Existing_Diabetes_Diagnosis();
		var b_ = this.Qualifying_Encounters_With_Hypoglycemic_Medication();
		var c_ = context.Operators.Union<Encounter>(a_, b_);
		var d_ = this.Qualifying_Encounters_With_Elevated_Blood_Glucose_Lab();
		var e_ = context.Operators.Union<Encounter>(c_, d_);

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
		var g_ = context.Operators.Min<CqlDateTime>((f_ as IEnumerable<CqlDateTime>));
		var h_ = context.Operators.Interval(a_, g_, true, true);

		return h_;
	}

    [CqlDeclaration("Interval To Day Numbers")]
	public IEnumerable<int?> Interval_To_Day_Numbers(CqlInterval<CqlDateTime> Period)
	{
		var a_ = context.Operators.Start(Period);
		var b_ = context.Operators.End(Period);
		var c_ = context.Operators.DurationBetween(a_, b_, "day");
		var d_ = context.Operators.Interval(1, c_, true, true);
		var e_ = new CqlInterval<int?>[]
		{
			d_,
		};
		var f_ = context.Operators.Expand((e_ as IEnumerable<CqlInterval<int?>>), null);
		int? g_(CqlInterval<int?> DayExpand)
		{
			var i_ = context.Operators.End(DayExpand);

			return i_;
		};
		var h_ = context.Operators.Select<CqlInterval<int?>, int?>(f_, g_);

		return h_;
	}

    [CqlDeclaration("Days In Period")]
	public IEnumerable<Tuple_ddJhZGNHefSCOAJJFEIEcXie> Days_In_Period(CqlInterval<CqlDateTime> Period)
	{
		var a_ = this.Interval_To_Day_Numbers(Period);
		Tuple_ddJhZGNHefSCOAJJFEIEcXie b_(int? DayIndex)
		{
			var d_ = context.Operators.Start(Period);
			var e_ = context.Operators.Quantity(24m, "hours");
			var f_ = context.Operators.Subtract(DayIndex, 1);
			var g_ = context.Operators.ConvertIntegerToQuantity(f_);
			var h_ = context.Operators.Multiply(e_, g_);
			var i_ = context.Operators.Add(d_, h_);
			CqlDateTime j_()
			{
				bool m_()
				{
					var n_ = context.Operators.Start(Period);
					var o_ = context.Operators.Quantity(24m, "hours");
					var p_ = context.Operators.Subtract(DayIndex, 1);
					var q_ = context.Operators.ConvertIntegerToQuantity(p_);
					var r_ = context.Operators.Multiply(o_, q_);
					var s_ = context.Operators.Add(n_, r_);
					var t_ = context.Operators.End(Period);
					var u_ = context.Operators.DurationBetween(s_, t_, "hour");
					var v_ = context.Operators.Less(u_, 24);

					return (v_ ?? false);
				};
				if (m_())
				{
					var w_ = context.Operators.Start(Period);
					var x_ = context.Operators.Quantity(24m, "hours");
					var y_ = context.Operators.Subtract(DayIndex, 1);
					var z_ = context.Operators.ConvertIntegerToQuantity(y_);
					var aa_ = context.Operators.Multiply(x_, z_);
					var ab_ = context.Operators.Add(w_, aa_);

					return ab_;
				}
				else
				{
					var ac_ = context.Operators.Start(Period);
					var ad_ = context.Operators.Quantity(24m, "hours");
					var ae_ = context.Operators.ConvertIntegerToQuantity(DayIndex);
					var af_ = context.Operators.Multiply(ad_, ae_);
					var ag_ = context.Operators.Add(ac_, af_);

					return ag_;
				}
			};
			var k_ = context.Operators.Interval(i_, j_(), true, false);
			var l_ = new Tuple_ddJhZGNHefSCOAJJFEIEcXie
			{
				dayIndex = DayIndex,
				dayPeriod = k_,
			};

			return l_;
		};
		var c_ = context.Operators.Select<int?, Tuple_ddJhZGNHefSCOAJJFEIEcXie>(a_, b_);

		return c_;
	}

	private IEnumerable<Tuple_BFFMVKRWdCJDYTgBWYHeLPiha> Pertinent_Encounters_With_Days_Value()
	{
		var a_ = this.Initial_Population();
		Tuple_BFFMVKRWdCJDYTgBWYHeLPiha b_(Encounter PertinentEncounter)
		{
			var d_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(PertinentEncounter);
			var f_ = this.Crop_Interval_to_10_Days(d_);
			var h_ = this.Crop_Interval_to_10_Days(d_);
			var i_ = this.Days_In_Period(h_);
			var j_ = new Tuple_BFFMVKRWdCJDYTgBWYHeLPiha
			{
				encounter = PertinentEncounter,
				hospitalizationPeriod = d_,
				relevantPeriod = f_,
				relevantDays = i_,
			};

			return j_;
		};
		var c_ = context.Operators.Select<Encounter, Tuple_BFFMVKRWdCJDYTgBWYHeLPiha>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Pertinent Encounters With Days")]
	public IEnumerable<Tuple_BFFMVKRWdCJDYTgBWYHeLPiha> Pertinent_Encounters_With_Days() => 
		__Pertinent_Encounters_With_Days.Value;

	private IEnumerable<Tuple_BVGhTTBTiPLQVGZRfJbXRNFfF> Pertinent_Encounters_With_Glucose_Result_Days_Value()
	{
		var a_ = this.Pertinent_Encounters_With_Days();
		Tuple_BVGhTTBTiPLQVGZRfJbXRNFfF b_(Tuple_BFFMVKRWdCJDYTgBWYHeLPiha PertinentEncounterDays)
		{
			var d_ = PertinentEncounterDays?.encounter;
			var e_ = PertinentEncounterDays?.relevantPeriod;
			var f_ = PertinentEncounterDays?.relevantDays;
			Tuple_HDgChhdKHffMeLJEWdDUjFSFd g_(Tuple_ddJhZGNHefSCOAJJFEIEcXie EncounterDay)
			{
				var j_ = EncounterDay?.dayIndex;
				var k_ = EncounterDay?.dayPeriod;
				var l_ = this.Glucose_lab_test();
				var m_ = context.Operators.RetrieveByValueSet<Observation>(l_, null);
				bool? n_(Observation BloodGlucoseLab1)
				{
					var ac_ = BloodGlucoseLab1?.StatusElement;
					var ad_ = FHIRHelpers_4_0_001.ToString(ac_);
					var ae_ = context.Operators.Equal(ad_, "final");
					var af_ = BloodGlucoseLab1?.Value;
					var ag_ = FHIRHelpers_4_0_001.ToQuantity((af_ as Quantity));
					var ah_ = context.Operators.Quantity(300m, "mg/dL");
					var ai_ = context.Operators.Greater(ag_, ah_);
					var aj_ = context.Operators.And(ae_, ai_);
					var ak_ = BloodGlucoseLab1?.Effective;
					var al_ = FHIRHelpers_4_0_001.ToDateTime((ak_ as FhirDateTime));
					var am_ = EncounterDay?.dayPeriod;
					var an_ = context.Operators.In<CqlDateTime>(al_, am_, null);
					var ao_ = context.Operators.And(aj_, an_);

					return ao_;
				};
				var o_ = context.Operators.Where<Observation>(m_, n_);
				var p_ = context.Operators.Exists<Observation>(o_);
				var r_ = context.Operators.RetrieveByValueSet<Observation>(l_, null);
				bool? s_(Observation BloodGlucoseLab2)
				{
					var ap_ = BloodGlucoseLab2?.StatusElement;
					var aq_ = FHIRHelpers_4_0_001.ToString(ap_);
					var ar_ = context.Operators.Equal(aq_, "final");
					var as_ = BloodGlucoseLab2?.Value;
					var at_ = FHIRHelpers_4_0_001.ToQuantity((as_ as Quantity));
					var au_ = context.Operators.Quantity(200m, "mg/dL");
					var av_ = context.Operators.GreaterOrEqual(at_, au_);
					var aw_ = context.Operators.And(ar_, av_);
					var ax_ = BloodGlucoseLab2?.Effective;
					var ay_ = FHIRHelpers_4_0_001.ToDateTime((ax_ as FhirDateTime));
					var az_ = EncounterDay?.dayPeriod;
					var ba_ = context.Operators.In<CqlDateTime>(ay_, az_, null);
					var bb_ = context.Operators.And(aw_, ba_);

					return bb_;
				};
				var t_ = context.Operators.Where<Observation>(r_, s_);
				var u_ = context.Operators.Exists<Observation>(t_);
				var w_ = context.Operators.RetrieveByValueSet<Observation>(l_, null);
				bool? x_(Observation BloodGlucoseLab3)
				{
					var bc_ = BloodGlucoseLab3?.StatusElement;
					var bd_ = FHIRHelpers_4_0_001.ToString(bc_);
					var be_ = context.Operators.Equal(bd_, "final");
					var bf_ = BloodGlucoseLab3?.Effective;
					var bg_ = FHIRHelpers_4_0_001.ToDateTime((bf_ as FhirDateTime));
					var bh_ = EncounterDay?.dayPeriod;
					var bi_ = context.Operators.In<CqlDateTime>(bg_, bh_, null);
					var bj_ = context.Operators.And(be_, bi_);

					return bj_;
				};
				var y_ = context.Operators.Where<Observation>(w_, x_);
				var z_ = context.Operators.Exists<Observation>(y_);
				var aa_ = context.Operators.Not(z_);
				var ab_ = new Tuple_HDgChhdKHffMeLJEWdDUjFSFd
				{
					dayIndex = j_,
					dayPeriod = k_,
					hasSevereResult = p_,
					hasElevatedResult = u_,
					hasNoResult = aa_,
				};

				return ab_;
			};
			var h_ = context.Operators.Select<Tuple_ddJhZGNHefSCOAJJFEIEcXie, Tuple_HDgChhdKHffMeLJEWdDUjFSFd>(f_, g_);
			var i_ = new Tuple_BVGhTTBTiPLQVGZRfJbXRNFfF
			{
				encounter = d_,
				relevantPeriod = e_,
				relevantDays = h_,
			};

			return i_;
		};
		var c_ = context.Operators.Select<Tuple_BFFMVKRWdCJDYTgBWYHeLPiha, Tuple_BVGhTTBTiPLQVGZRfJbXRNFfF>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Pertinent Encounters With Glucose Result Days")]
	public IEnumerable<Tuple_BVGhTTBTiPLQVGZRfJbXRNFfF> Pertinent_Encounters_With_Glucose_Result_Days() => 
		__Pertinent_Encounters_With_Glucose_Result_Days.Value;

	private IEnumerable<Tuple_DNEVNMCYfTaYQDAThWFVOgQaT> Pertinent_Encounters_With_Hyperglycemic_Event_Days_Value()
	{
		var a_ = this.Pertinent_Encounters_With_Glucose_Result_Days();
		Tuple_DNEVNMCYfTaYQDAThWFVOgQaT b_(Tuple_BVGhTTBTiPLQVGZRfJbXRNFfF EncounterWithResultDays)
		{
			var d_ = EncounterWithResultDays?.encounter;
			var e_ = EncounterWithResultDays?.relevantPeriod;
			var f_ = EncounterWithResultDays?.relevantDays;
			bool? g_(Tuple_HDgChhdKHffMeLJEWdDUjFSFd EncounterDay)
			{
				var l_ = EncounterDay?.dayIndex;
				var m_ = context.Operators.Greater(l_, 1);

				return m_;
			};
			var h_ = context.Operators.Where<Tuple_HDgChhdKHffMeLJEWdDUjFSFd>(f_, g_);
			Tuple_FNeERNKXWKJeEjWXREHDLePdY i_(Tuple_HDgChhdKHffMeLJEWdDUjFSFd EncounterDay)
			{
				var n_ = EncounterDay?.dayIndex;
				var o_ = EncounterDay?.dayPeriod;
				var p_ = EncounterDay?.hasSevereResult;
				var q_ = EncounterDay?.hasNoResult;
				var r_ = EncounterWithResultDays?.relevantDays;
				var t_ = context.Operators.Subtract(n_, 2);
				var u_ = context.Operators.Indexer<Tuple_HDgChhdKHffMeLJEWdDUjFSFd>(r_, t_);
				var v_ = u_?.hasElevatedResult;
				var w_ = context.Operators.And(q_, v_);
				var z_ = context.Operators.Subtract(n_, 3);
				var aa_ = context.Operators.Indexer<Tuple_HDgChhdKHffMeLJEWdDUjFSFd>(r_, z_);
				var ab_ = aa_?.hasElevatedResult;
				var ac_ = context.Operators.And(w_, ab_);
				var ad_ = context.Operators.Or(p_, ac_);
				var ae_ = new Tuple_FNeERNKXWKJeEjWXREHDLePdY
				{
					dayIndex = n_,
					dayPeriod = o_,
					hasHyperglycemicEvent = ad_,
				};

				return ae_;
			};
			var j_ = context.Operators.Select<Tuple_HDgChhdKHffMeLJEWdDUjFSFd, Tuple_FNeERNKXWKJeEjWXREHDLePdY>(h_, i_);
			var k_ = new Tuple_DNEVNMCYfTaYQDAThWFVOgQaT
			{
				encounter = d_,
				relevantPeriod = e_,
				eligibleEventDays = j_,
			};

			return k_;
		};
		var c_ = context.Operators.Select<Tuple_BVGhTTBTiPLQVGZRfJbXRNFfF, Tuple_DNEVNMCYfTaYQDAThWFVOgQaT>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Pertinent Encounters With Hyperglycemic Event Days")]
	public IEnumerable<Tuple_DNEVNMCYfTaYQDAThWFVOgQaT> Pertinent_Encounters_With_Hyperglycemic_Event_Days() => 
		__Pertinent_Encounters_With_Hyperglycemic_Event_Days.Value;

	private IEnumerable<Encounter> Numerator_Value()
	{
		var a_ = this.Pertinent_Encounters_With_Hyperglycemic_Event_Days();
		bool? b_(Tuple_DNEVNMCYfTaYQDAThWFVOgQaT EncounterWithEventDays)
		{
			var f_ = EncounterWithEventDays?.eligibleEventDays;
			bool? g_(Tuple_FNeERNKXWKJeEjWXREHDLePdY EligibleEventDay)
			{
				var j_ = EligibleEventDay?.hasHyperglycemicEvent;

				return j_;
			};
			var h_ = context.Operators.Where<Tuple_FNeERNKXWKJeEjWXREHDLePdY>(f_, g_);
			var i_ = context.Operators.Exists<Tuple_FNeERNKXWKJeEjWXREHDLePdY>(h_);

			return i_;
		};
		var c_ = context.Operators.Where<Tuple_DNEVNMCYfTaYQDAThWFVOgQaT>(a_, b_);
		Encounter d_(Tuple_DNEVNMCYfTaYQDAThWFVOgQaT EncounterWithEventDays)
		{
			var k_ = EncounterWithEventDays?.encounter;

			return k_;
		};
		var e_ = context.Operators.Select<Tuple_DNEVNMCYfTaYQDAThWFVOgQaT, Encounter>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Numerator")]
	public IEnumerable<Encounter> Numerator() => 
		__Numerator.Value;

    [CqlDeclaration("Denominator Observations")]
	public int? Denominator_Observations(Encounter QualifyingEncounter)
	{
		var a_ = this.Pertinent_Encounters_With_Hyperglycemic_Event_Days();
		bool? b_(Tuple_DNEVNMCYfTaYQDAThWFVOgQaT EncounterWithEventDays)
		{
			var g_ = EncounterWithEventDays?.encounter;
			var h_ = context.Operators.Equal(g_, QualifyingEncounter);

			return h_;
		};
		var c_ = context.Operators.Where<Tuple_DNEVNMCYfTaYQDAThWFVOgQaT>(a_, b_);
		int? d_(Tuple_DNEVNMCYfTaYQDAThWFVOgQaT EncounterWithEventDays)
		{
			var i_ = EncounterWithEventDays?.eligibleEventDays;
			var j_ = context.Operators.Count<Tuple_FNeERNKXWKJeEjWXREHDLePdY>(i_);

			return j_;
		};
		var e_ = context.Operators.Select<Tuple_DNEVNMCYfTaYQDAThWFVOgQaT, int?>(c_, d_);
		var f_ = context.Operators.SingletonFrom<int?>(e_);

		return f_;
	}

    [CqlDeclaration("Numerator Observations")]
	public int? Numerator_Observations(Encounter QualifyingEncounter)
	{
		var a_ = this.Pertinent_Encounters_With_Hyperglycemic_Event_Days();
		bool? b_(Tuple_DNEVNMCYfTaYQDAThWFVOgQaT EncounterWithEventDays)
		{
			var g_ = EncounterWithEventDays?.encounter;
			var h_ = context.Operators.Equal(g_, QualifyingEncounter);

			return h_;
		};
		var c_ = context.Operators.Where<Tuple_DNEVNMCYfTaYQDAThWFVOgQaT>(a_, b_);
		int? d_(Tuple_DNEVNMCYfTaYQDAThWFVOgQaT EncounterWithEventDays)
		{
			var i_ = EncounterWithEventDays?.eligibleEventDays;
			bool? j_(Tuple_FNeERNKXWKJeEjWXREHDLePdY EligibleEventDay)
			{
				var m_ = EligibleEventDay?.hasHyperglycemicEvent;

				return m_;
			};
			var k_ = context.Operators.Where<Tuple_FNeERNKXWKJeEjWXREHDLePdY>(i_, j_);
			var l_ = context.Operators.Count<Tuple_FNeERNKXWKJeEjWXREHDLePdY>(k_);

			return l_;
		};
		var e_ = context.Operators.Select<Tuple_DNEVNMCYfTaYQDAThWFVOgQaT, int?>(c_, d_);
		var f_ = context.Operators.SingletonFrom<int?>(e_);

		return f_;
	}

}
