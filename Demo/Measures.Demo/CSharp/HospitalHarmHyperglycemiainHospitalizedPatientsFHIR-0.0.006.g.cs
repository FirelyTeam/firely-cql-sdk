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
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.4.0")]
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
    internal Lazy<IEnumerable<(CodeableConcept code, Period period)?>> __SDE_Payer;
    internal Lazy<IEnumerable<Coding>> __SDE_Race;
    internal Lazy<CqlCode> __SDE_Sex;
    internal Lazy<IEnumerable<Encounter>> __Inpatient_Encounter_During_Measurement_Period;
    internal Lazy<IEnumerable<Encounter>> __Qualifying_Encounters;
    internal Lazy<IEnumerable<(Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?>> __Qualifying_Encounters_With_Hospitalization_Period;
    internal Lazy<IEnumerable<Encounter>> __Qualifying_Encounters_With_Existing_Diabetes_Diagnosis;
    internal Lazy<IEnumerable<Encounter>> __Qualifying_Encounters_With_Hypoglycemic_Medication;
    internal Lazy<IEnumerable<Encounter>> __Qualifying_Encounters_With_Elevated_Blood_Glucose_Lab;
    internal Lazy<IEnumerable<Encounter>> __Initial_Population;
    internal Lazy<IEnumerable<Encounter>> __Denominator;
    internal Lazy<IEnumerable<(Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)?>> __Pertinent_Encounters_With_Days;
    internal Lazy<IEnumerable<(Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?> relevantDays)?>> __Pertinent_Encounters_With_Glucose_Result_Days;
    internal Lazy<IEnumerable<(Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?>> __Pertinent_Encounters_With_Hyperglycemic_Event_Days;
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
        __SDE_Payer = new Lazy<IEnumerable<(CodeableConcept code, Period period)?>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<IEnumerable<Coding>>(this.SDE_Race_Value);
        __SDE_Sex = new Lazy<CqlCode>(this.SDE_Sex_Value);
        __Inpatient_Encounter_During_Measurement_Period = new Lazy<IEnumerable<Encounter>>(this.Inpatient_Encounter_During_Measurement_Period_Value);
        __Qualifying_Encounters = new Lazy<IEnumerable<Encounter>>(this.Qualifying_Encounters_Value);
        __Qualifying_Encounters_With_Hospitalization_Period = new Lazy<IEnumerable<(Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?>>(this.Qualifying_Encounters_With_Hospitalization_Period_Value);
        __Qualifying_Encounters_With_Existing_Diabetes_Diagnosis = new Lazy<IEnumerable<Encounter>>(this.Qualifying_Encounters_With_Existing_Diabetes_Diagnosis_Value);
        __Qualifying_Encounters_With_Hypoglycemic_Medication = new Lazy<IEnumerable<Encounter>>(this.Qualifying_Encounters_With_Hypoglycemic_Medication_Value);
        __Qualifying_Encounters_With_Elevated_Blood_Glucose_Lab = new Lazy<IEnumerable<Encounter>>(this.Qualifying_Encounters_With_Elevated_Blood_Glucose_Lab_Value);
        __Initial_Population = new Lazy<IEnumerable<Encounter>>(this.Initial_Population_Value);
        __Denominator = new Lazy<IEnumerable<Encounter>>(this.Denominator_Value);
        __Pertinent_Encounters_With_Days = new Lazy<IEnumerable<(Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)?>>(this.Pertinent_Encounters_With_Days_Value);
        __Pertinent_Encounters_With_Glucose_Result_Days = new Lazy<IEnumerable<(Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?> relevantDays)?>>(this.Pertinent_Encounters_With_Glucose_Result_Days_Value);
        __Pertinent_Encounters_With_Hyperglycemic_Event_Days = new Lazy<IEnumerable<(Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?>>(this.Pertinent_Encounters_With_Hyperglycemic_Event_Days_Value);
        __Numerator = new Lazy<IEnumerable<Encounter>>(this.Numerator_Value);
    }
    #region Dependencies

    public FHIRHelpers_4_0_001 FHIRHelpers_4_0_001 { get; }
    public SupplementalDataElementsFHIR4_2_0_000 SupplementalDataElementsFHIR4_2_0_000 { get; }
    public MATGlobalCommonFunctionsFHIR4_6_1_000 MATGlobalCommonFunctionsFHIR4_6_1_000 { get; }

    #endregion

	private CqlValueSet birth_date_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.560.100.4", default);

    [CqlDeclaration("birth date")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.560.100.4")]
	public CqlValueSet birth_date() => 
		__birth_date.Value;

	private CqlValueSet Diabetes_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.103.12.1001", default);

    [CqlDeclaration("Diabetes")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.103.12.1001")]
	public CqlValueSet Diabetes() => 
		__Diabetes.Value;

	private CqlValueSet Encounter_Inpatient_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", default);

    [CqlDeclaration("Encounter Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307")]
	public CqlValueSet Encounter_Inpatient() => 
		__Encounter_Inpatient.Value;

	private CqlValueSet Glucose_lab_test_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.134", default);

    [CqlDeclaration("Glucose lab test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.134")]
	public CqlValueSet Glucose_lab_test() => 
		__Glucose_lab_test.Value;

	private CqlValueSet Hypoglycemics_Treatment_Medications_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1196.394", default);

    [CqlDeclaration("Hypoglycemics Treatment Medications")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1196.394")]
	public CqlValueSet Hypoglycemics_Treatment_Medications() => 
		__Hypoglycemics_Treatment_Medications.Value;

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
		object a_ = context.ResolveParameter("HospitalHarmHyperglycemiainHospitalizedPatientsFHIR-0.0.006", "Measurement Period", null);

		return (CqlInterval<CqlDateTime>)a_;
	}

    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period() => 
		__Measurement_Period.Value;

	private Patient Patient_Value()
	{
		IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
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

	private IEnumerable<(CodeableConcept code, Period period)?> SDE_Payer_Value()
	{
		IEnumerable<(CodeableConcept code, Period period)?> a_ = SupplementalDataElementsFHIR4_2_0_000.SDE_Payer();

		return a_;
	}

    [CqlDeclaration("SDE Payer")]
	public IEnumerable<(CodeableConcept code, Period period)?> SDE_Payer() => 
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
		IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));

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
			Date e_ = d_?.BirthDateElement;
			string f_ = e_?.Value;
			CqlDateTime g_ = context.Operators.ConvertStringToDateTime(f_);
			CqlInterval<CqlDateTime> h_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(InpatientEncounter);
			CqlDateTime i_ = context.Operators.Start(h_);
			int? j_ = context.Operators.CalculateAgeAt(g_, i_, "year");
			bool? k_ = context.Operators.GreaterOrEqual(j_, 18);

			return k_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Qualifying Encounters")]
	public IEnumerable<Encounter> Qualifying_Encounters() => 
		__Qualifying_Encounters.Value;

	private IEnumerable<(Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> Qualifying_Encounters_With_Hospitalization_Period_Value()
	{
		IEnumerable<Encounter> a_ = this.Qualifying_Encounters();
		(Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? b_(Encounter QualifyingEncounter)
		{
			CqlInterval<CqlDateTime> d_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(QualifyingEncounter);
			(Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? e_ = (QualifyingEncounter, d_);

			return e_;
		};
		IEnumerable<(Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> c_ = context.Operators.Select<Encounter, (Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Qualifying Encounters With Hospitalization Period")]
	public IEnumerable<(Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> Qualifying_Encounters_With_Hospitalization_Period() => 
		__Qualifying_Encounters_With_Hospitalization_Period.Value;

	private IEnumerable<Encounter> Qualifying_Encounters_With_Existing_Diabetes_Diagnosis_Value()
	{
		IEnumerable<(Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> a_ = this.Qualifying_Encounters_With_Hospitalization_Period();
		IEnumerable<(Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> b_((Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? EncounterWithHospitalization)
		{
			CqlValueSet f_ = this.Diabetes();
			IEnumerable<Condition> g_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
			bool? h_(Condition DiabetesDiagnosis)
			{
				CodeableConcept l_ = DiabetesDiagnosis?.VerificationStatus;
				CqlConcept m_ = FHIRHelpers_4_0_001.ToConcept(l_);
				CqlCode n_ = MATGlobalCommonFunctionsFHIR4_6_1_000.confirmed();
				CqlConcept o_ = context.Operators.ConvertCodeToConcept(n_);
				bool? p_ = context.Operators.Equivalent(m_, o_);
				CqlInterval<CqlDateTime> q_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Prevalence_Period(DiabetesDiagnosis);
				CqlDateTime r_ = context.Operators.Start(q_);
				CqlInterval<CqlDateTime> s_ = EncounterWithHospitalization?.hospitalizationPeriod;
				CqlDateTime t_ = context.Operators.End(s_);
				bool? u_ = context.Operators.Before(r_, t_, default);
				bool? v_ = context.Operators.And(p_, u_);

				return v_;
			};
			IEnumerable<Condition> i_ = context.Operators.Where<Condition>(g_, h_);
			(Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? j_(Condition DiabetesDiagnosis) => 
				EncounterWithHospitalization;
			IEnumerable<(Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> k_ = context.Operators.Select<Condition, (Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?>(i_, j_);

			return k_;
		};
		IEnumerable<(Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> c_ = context.Operators.SelectMany<(Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?, (Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?>(a_, b_);
		Encounter d_((Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? EncounterWithHospitalization)
		{
			Encounter w_ = EncounterWithHospitalization?.encounter;

			return w_;
		};
		IEnumerable<Encounter> e_ = context.Operators.Select<(Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?, Encounter>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Qualifying Encounters With Existing Diabetes Diagnosis")]
	public IEnumerable<Encounter> Qualifying_Encounters_With_Existing_Diabetes_Diagnosis() => 
		__Qualifying_Encounters_With_Existing_Diabetes_Diagnosis.Value;

	private IEnumerable<Encounter> Qualifying_Encounters_With_Hypoglycemic_Medication_Value()
	{
		IEnumerable<(Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> a_ = this.Qualifying_Encounters_With_Hospitalization_Period();
		CqlValueSet b_ = this.Hypoglycemics_Treatment_Medications();
		IEnumerable<MedicationAdministration> c_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, b_, default, "http://hl7.org/fhir/StructureDefinition/MedicationAdministration"));
		IEnumerable<MedicationAdministration> e_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, b_, default, "http://hl7.org/fhir/StructureDefinition/MedicationAdministration"));
		IEnumerable<MedicationAdministration> f_ = context.Operators.Union<MedicationAdministration>(c_, e_);
		IEnumerable<ValueTuple<(Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?, MedicationAdministration>> g_ = context.Operators.CrossJoin<(Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?, MedicationAdministration>(a_, f_);
		((Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? EncounterWithHospitalization, MedicationAdministration HypoglycemicMedication)? h_(ValueTuple<(Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?, MedicationAdministration> _valueTuple)
		{
			((Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? EncounterWithHospitalization, MedicationAdministration HypoglycemicMedication)? n_ = (_valueTuple.Item1, _valueTuple.Item2);

			return n_;
		};
		IEnumerable<((Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? EncounterWithHospitalization, MedicationAdministration HypoglycemicMedication)?> i_ = context.Operators.Select<ValueTuple<(Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?, MedicationAdministration>, ((Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? EncounterWithHospitalization, MedicationAdministration HypoglycemicMedication)?>(g_, h_);
		bool? j_(((Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? EncounterWithHospitalization, MedicationAdministration HypoglycemicMedication)? tuple_clxcrdeespovhrdozoxqzeieb)
		{
			Code<MedicationAdministration.MedicationAdministrationStatusCodes> o_ = tuple_clxcrdeespovhrdozoxqzeieb?.HypoglycemicMedication?.StatusElement;
			string p_ = FHIRHelpers_4_0_001.ToString(o_);
			bool? q_ = context.Operators.Equal(p_, "completed");
			CqlInterval<CqlDateTime> r_ = tuple_clxcrdeespovhrdozoxqzeieb?.EncounterWithHospitalization?.hospitalizationPeriod;
			DataType s_ = tuple_clxcrdeespovhrdozoxqzeieb?.HypoglycemicMedication?.Effective;
			CqlInterval<CqlDateTime> t_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(s_);
			bool? u_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(r_, t_, default);
			bool? v_ = context.Operators.And(q_, u_);

			return v_;
		};
		IEnumerable<((Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? EncounterWithHospitalization, MedicationAdministration HypoglycemicMedication)?> k_ = context.Operators.Where<((Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? EncounterWithHospitalization, MedicationAdministration HypoglycemicMedication)?>(i_, j_);
		Encounter l_(((Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? EncounterWithHospitalization, MedicationAdministration HypoglycemicMedication)? tuple_clxcrdeespovhrdozoxqzeieb)
		{
			Encounter w_ = tuple_clxcrdeespovhrdozoxqzeieb?.EncounterWithHospitalization?.encounter;

			return w_;
		};
		IEnumerable<Encounter> m_ = context.Operators.Select<((Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? EncounterWithHospitalization, MedicationAdministration HypoglycemicMedication)?, Encounter>(k_, l_);

		return m_;
	}

    [CqlDeclaration("Qualifying Encounters With Hypoglycemic Medication")]
	public IEnumerable<Encounter> Qualifying_Encounters_With_Hypoglycemic_Medication() => 
		__Qualifying_Encounters_With_Hypoglycemic_Medication.Value;

	private IEnumerable<Encounter> Qualifying_Encounters_With_Elevated_Blood_Glucose_Lab_Value()
	{
		IEnumerable<(Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> a_ = this.Qualifying_Encounters_With_Hospitalization_Period();
		IEnumerable<(Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> b_((Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? EncounterWithHospitalization)
		{
			CqlValueSet f_ = this.Glucose_lab_test();
			IEnumerable<Observation> g_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
			bool? h_(Observation BloodGlucoseLab)
			{
				DataType l_ = BloodGlucoseLab?.Effective;
				CqlDateTime m_ = FHIRHelpers_4_0_001.ToDateTime(l_ as FhirDateTime);
				CqlInterval<CqlDateTime> n_ = EncounterWithHospitalization?.hospitalizationPeriod;
				bool? o_ = context.Operators.In<CqlDateTime>(m_, n_, default);
				Code<ObservationStatus> p_ = BloodGlucoseLab?.StatusElement;
				string q_ = FHIRHelpers_4_0_001.ToString(p_);
				bool? r_ = context.Operators.Equal(q_, "final");
				bool? s_ = context.Operators.And(o_, r_);
				DataType t_ = BloodGlucoseLab?.Value;
				CqlQuantity u_ = FHIRHelpers_4_0_001.ToQuantity(t_ as Quantity);
				CqlQuantity v_ = context.Operators.Quantity(200m, "mg/dL");
				bool? w_ = context.Operators.GreaterOrEqual(u_, v_);
				bool? x_ = context.Operators.And(s_, w_);

				return x_;
			};
			IEnumerable<Observation> i_ = context.Operators.Where<Observation>(g_, h_);
			(Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? j_(Observation BloodGlucoseLab) => 
				EncounterWithHospitalization;
			IEnumerable<(Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> k_ = context.Operators.Select<Observation, (Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?>(i_, j_);

			return k_;
		};
		IEnumerable<(Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> c_ = context.Operators.SelectMany<(Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?, (Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?>(a_, b_);
		Encounter d_((Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? EncounterWithHospitalization)
		{
			Encounter y_ = EncounterWithHospitalization?.encounter;

			return y_;
		};
		IEnumerable<Encounter> e_ = context.Operators.Select<(Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?, Encounter>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Qualifying Encounters With Elevated Blood Glucose Lab")]
	public IEnumerable<Encounter> Qualifying_Encounters_With_Elevated_Blood_Glucose_Lab() => 
		__Qualifying_Encounters_With_Elevated_Blood_Glucose_Lab.Value;

	private IEnumerable<Encounter> Initial_Population_Value()
	{
		IEnumerable<Encounter> a_ = this.Qualifying_Encounters_With_Existing_Diabetes_Diagnosis();
		IEnumerable<Encounter> b_ = this.Qualifying_Encounters_With_Hypoglycemic_Medication();
		IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);
		IEnumerable<Encounter> d_ = this.Qualifying_Encounters_With_Elevated_Blood_Glucose_Lab();
		IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(c_, d_);

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
		CqlDateTime[] f_ = [
			b_,
			e_,
		];
		CqlDateTime g_ = context.Operators.Min<CqlDateTime>(f_ as IEnumerable<CqlDateTime>);
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
		CqlInterval<int?>[] e_ = [
			d_,
		];
		IEnumerable<CqlInterval<int?>> f_ = context.Operators.Expand(e_ as IEnumerable<CqlInterval<int?>>, default);
		int? g_(CqlInterval<int?> DayExpand)
		{
			int? i_ = context.Operators.End(DayExpand);

			return i_;
		};
		IEnumerable<int?> h_ = context.Operators.Select<CqlInterval<int?>, int?>(f_, g_);

		return h_;
	}

    [CqlDeclaration("Days In Period")]
	public IEnumerable<(int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> Days_In_Period(CqlInterval<CqlDateTime> Period)
	{
		IEnumerable<int?> a_ = this.Interval_To_Day_Numbers(Period);
		(int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)? b_(int? DayIndex)
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

					return v_ ?? false;
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
				}
			};
			CqlInterval<CqlDateTime> k_ = context.Operators.Interval(i_, j_(), true, false);
			(int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)? l_ = (DayIndex, k_);

			return l_;
		};
		IEnumerable<(int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> c_ = context.Operators.Select<int?, (int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?>(a_, b_);

		return c_;
	}

	private IEnumerable<(Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)?> Pertinent_Encounters_With_Days_Value()
	{
		IEnumerable<Encounter> a_ = this.Initial_Population();
		(Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)? b_(Encounter PertinentEncounter)
		{
			CqlInterval<CqlDateTime> d_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(PertinentEncounter);
			CqlInterval<CqlDateTime> f_ = this.Crop_Interval_to_10_Days(d_);
			CqlInterval<CqlDateTime> h_ = this.Crop_Interval_to_10_Days(d_);
			IEnumerable<(int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> i_ = this.Days_In_Period(h_);
			(Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)? j_ = (PertinentEncounter, d_, f_, i_);

			return j_;
		};
		IEnumerable<(Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)?> c_ = context.Operators.Select<Encounter, (Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)?>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Pertinent Encounters With Days")]
	public IEnumerable<(Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)?> Pertinent_Encounters_With_Days() => 
		__Pertinent_Encounters_With_Days.Value;

	private IEnumerable<(Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?> relevantDays)?> Pertinent_Encounters_With_Glucose_Result_Days_Value()
	{
		IEnumerable<(Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)?> a_ = this.Pertinent_Encounters_With_Days();
		(Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?> relevantDays)? b_((Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)? PertinentEncounterDays)
		{
			Encounter d_ = PertinentEncounterDays?.encounter;
			CqlInterval<CqlDateTime> e_ = PertinentEncounterDays?.relevantPeriod;
			IEnumerable<(int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> f_ = PertinentEncounterDays?.relevantDays;
			(int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)? g_((int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)? EncounterDay)
			{
				int? j_ = EncounterDay?.dayIndex;
				CqlInterval<CqlDateTime> k_ = EncounterDay?.dayPeriod;
				CqlValueSet l_ = this.Glucose_lab_test();
				IEnumerable<Observation> m_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
				bool? n_(Observation BloodGlucoseLab1)
				{
					Code<ObservationStatus> ac_ = BloodGlucoseLab1?.StatusElement;
					string ad_ = FHIRHelpers_4_0_001.ToString(ac_);
					bool? ae_ = context.Operators.Equal(ad_, "final");
					DataType af_ = BloodGlucoseLab1?.Value;
					CqlQuantity ag_ = FHIRHelpers_4_0_001.ToQuantity(af_ as Quantity);
					CqlQuantity ah_ = context.Operators.Quantity(300m, "mg/dL");
					bool? ai_ = context.Operators.Greater(ag_, ah_);
					bool? aj_ = context.Operators.And(ae_, ai_);
					DataType ak_ = BloodGlucoseLab1?.Effective;
					CqlDateTime al_ = FHIRHelpers_4_0_001.ToDateTime(ak_ as FhirDateTime);
					CqlInterval<CqlDateTime> am_ = EncounterDay?.dayPeriod;
					bool? an_ = context.Operators.In<CqlDateTime>(al_, am_, default);
					bool? ao_ = context.Operators.And(aj_, an_);

					return ao_;
				};
				IEnumerable<Observation> o_ = context.Operators.Where<Observation>(m_, n_);
				bool? p_ = context.Operators.Exists<Observation>(o_);
				IEnumerable<Observation> r_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
				bool? s_(Observation BloodGlucoseLab2)
				{
					Code<ObservationStatus> ap_ = BloodGlucoseLab2?.StatusElement;
					string aq_ = FHIRHelpers_4_0_001.ToString(ap_);
					bool? ar_ = context.Operators.Equal(aq_, "final");
					DataType as_ = BloodGlucoseLab2?.Value;
					CqlQuantity at_ = FHIRHelpers_4_0_001.ToQuantity(as_ as Quantity);
					CqlQuantity au_ = context.Operators.Quantity(200m, "mg/dL");
					bool? av_ = context.Operators.GreaterOrEqual(at_, au_);
					bool? aw_ = context.Operators.And(ar_, av_);
					DataType ax_ = BloodGlucoseLab2?.Effective;
					CqlDateTime ay_ = FHIRHelpers_4_0_001.ToDateTime(ax_ as FhirDateTime);
					CqlInterval<CqlDateTime> az_ = EncounterDay?.dayPeriod;
					bool? ba_ = context.Operators.In<CqlDateTime>(ay_, az_, default);
					bool? bb_ = context.Operators.And(aw_, ba_);

					return bb_;
				};
				IEnumerable<Observation> t_ = context.Operators.Where<Observation>(r_, s_);
				bool? u_ = context.Operators.Exists<Observation>(t_);
				IEnumerable<Observation> w_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
				bool? x_(Observation BloodGlucoseLab3)
				{
					Code<ObservationStatus> bc_ = BloodGlucoseLab3?.StatusElement;
					string bd_ = FHIRHelpers_4_0_001.ToString(bc_);
					bool? be_ = context.Operators.Equal(bd_, "final");
					DataType bf_ = BloodGlucoseLab3?.Effective;
					CqlDateTime bg_ = FHIRHelpers_4_0_001.ToDateTime(bf_ as FhirDateTime);
					CqlInterval<CqlDateTime> bh_ = EncounterDay?.dayPeriod;
					bool? bi_ = context.Operators.In<CqlDateTime>(bg_, bh_, default);
					bool? bj_ = context.Operators.And(be_, bi_);

					return bj_;
				};
				IEnumerable<Observation> y_ = context.Operators.Where<Observation>(w_, x_);
				bool? z_ = context.Operators.Exists<Observation>(y_);
				bool? aa_ = context.Operators.Not(z_);
				(int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)? ab_ = (j_, k_, p_, u_, aa_);

				return ab_;
			};
			IEnumerable<(int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?> h_ = context.Operators.Select<(int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?, (int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?>(f_, g_);
			(Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?> relevantDays)? i_ = (d_, e_, h_);

			return i_;
		};
		IEnumerable<(Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?> relevantDays)?> c_ = context.Operators.Select<(Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)?, (Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?> relevantDays)?>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Pertinent Encounters With Glucose Result Days")]
	public IEnumerable<(Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?> relevantDays)?> Pertinent_Encounters_With_Glucose_Result_Days() => 
		__Pertinent_Encounters_With_Glucose_Result_Days.Value;

	private IEnumerable<(Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> Pertinent_Encounters_With_Hyperglycemic_Event_Days_Value()
	{
		IEnumerable<(Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?> relevantDays)?> a_ = this.Pertinent_Encounters_With_Glucose_Result_Days();
		(Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? b_((Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?> relevantDays)? EncounterWithResultDays)
		{
			Encounter d_ = EncounterWithResultDays?.encounter;
			CqlInterval<CqlDateTime> e_ = EncounterWithResultDays?.relevantPeriod;
			IEnumerable<(int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?> f_ = EncounterWithResultDays?.relevantDays;
			bool? g_((int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)? EncounterDay)
			{
				int? l_ = EncounterDay?.dayIndex;
				bool? m_ = context.Operators.Greater(l_, 1);

				return m_;
			};
			IEnumerable<(int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?> h_ = context.Operators.Where<(int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?>(f_, g_);
			(int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)? i_((int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)? EncounterDay)
			{
				int? n_ = EncounterDay?.dayIndex;
				CqlInterval<CqlDateTime> o_ = EncounterDay?.dayPeriod;
				bool? p_ = EncounterDay?.hasSevereResult;
				bool? q_ = EncounterDay?.hasNoResult;
				IEnumerable<(int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?> r_ = EncounterWithResultDays?.relevantDays;
				int? t_ = context.Operators.Subtract(n_, 2);
				(int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)? u_ = context.Operators.Indexer<(int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?>(r_, t_);
				bool? v_ = u_?.hasElevatedResult;
				bool? w_ = context.Operators.And(q_, v_);
				int? z_ = context.Operators.Subtract(n_, 3);
				(int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)? aa_ = context.Operators.Indexer<(int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?>(r_, z_);
				bool? ab_ = aa_?.hasElevatedResult;
				bool? ac_ = context.Operators.And(w_, ab_);
				bool? ad_ = context.Operators.Or(p_, ac_);
				(int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)? ae_ = (n_, o_, ad_);

				return ae_;
			};
			IEnumerable<(int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> j_ = context.Operators.Select<(int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?, (int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?>(h_, i_);
			(Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? k_ = (d_, e_, j_);

			return k_;
		};
		IEnumerable<(Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> c_ = context.Operators.Select<(Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?> relevantDays)?, (Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Pertinent Encounters With Hyperglycemic Event Days")]
	public IEnumerable<(Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> Pertinent_Encounters_With_Hyperglycemic_Event_Days() => 
		__Pertinent_Encounters_With_Hyperglycemic_Event_Days.Value;

	private IEnumerable<Encounter> Numerator_Value()
	{
		IEnumerable<(Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> a_ = this.Pertinent_Encounters_With_Hyperglycemic_Event_Days();
		bool? b_((Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? EncounterWithEventDays)
		{
			IEnumerable<(int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> f_ = EncounterWithEventDays?.eligibleEventDays;
			bool? g_((int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)? EligibleEventDay)
			{
				bool? j_ = EligibleEventDay?.hasHyperglycemicEvent;

				return j_;
			};
			IEnumerable<(int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> h_ = context.Operators.Where<(int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?>(f_, g_);
			bool? i_ = context.Operators.Exists<(int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?>(h_);

			return i_;
		};
		IEnumerable<(Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> c_ = context.Operators.Where<(Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?>(a_, b_);
		Encounter d_((Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? EncounterWithEventDays)
		{
			Encounter k_ = EncounterWithEventDays?.encounter;

			return k_;
		};
		IEnumerable<Encounter> e_ = context.Operators.Select<(Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?, Encounter>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Numerator")]
	public IEnumerable<Encounter> Numerator() => 
		__Numerator.Value;

    [CqlDeclaration("Denominator Observations")]
	public int? Denominator_Observations(Encounter QualifyingEncounter)
	{
		IEnumerable<(Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> a_ = this.Pertinent_Encounters_With_Hyperglycemic_Event_Days();
		bool? b_((Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? EncounterWithEventDays)
		{
			Encounter g_ = EncounterWithEventDays?.encounter;
			bool? h_ = context.Operators.Equal(g_, QualifyingEncounter);

			return h_;
		};
		IEnumerable<(Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> c_ = context.Operators.Where<(Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?>(a_, b_);
		int? d_((Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? EncounterWithEventDays)
		{
			IEnumerable<(int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> i_ = EncounterWithEventDays?.eligibleEventDays;
			int? j_ = context.Operators.Count<(int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?>(i_);

			return j_;
		};
		IEnumerable<int?> e_ = context.Operators.Select<(Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?, int?>(c_, d_);
		int? f_ = context.Operators.SingletonFrom<int?>(e_);

		return f_;
	}

    [CqlDeclaration("Numerator Observations")]
	public int? Numerator_Observations(Encounter QualifyingEncounter)
	{
		IEnumerable<(Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> a_ = this.Pertinent_Encounters_With_Hyperglycemic_Event_Days();
		bool? b_((Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? EncounterWithEventDays)
		{
			Encounter g_ = EncounterWithEventDays?.encounter;
			bool? h_ = context.Operators.Equal(g_, QualifyingEncounter);

			return h_;
		};
		IEnumerable<(Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> c_ = context.Operators.Where<(Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?>(a_, b_);
		int? d_((Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? EncounterWithEventDays)
		{
			IEnumerable<(int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> i_ = EncounterWithEventDays?.eligibleEventDays;
			bool? j_((int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)? EligibleEventDay)
			{
				bool? m_ = EligibleEventDay?.hasHyperglycemicEvent;

				return m_;
			};
			IEnumerable<(int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> k_ = context.Operators.Where<(int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?>(i_, j_);
			int? l_ = context.Operators.Count<(int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?>(k_);

			return l_;
		};
		IEnumerable<int?> e_ = context.Operators.Select<(Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?, int?>(c_, d_);
		int? f_ = context.Operators.SingletonFrom<int?>(e_);

		return f_;
	}

}
