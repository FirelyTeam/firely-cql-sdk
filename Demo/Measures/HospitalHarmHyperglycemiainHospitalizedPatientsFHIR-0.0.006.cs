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
    public CqlValueSet birth_date() => __birth_date.Value;

    private CqlValueSet Diabetes_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.103.12.1001", null);

    [CqlDeclaration("Diabetes")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.103.12.1001")]
    public CqlValueSet Diabetes() => __Diabetes.Value;

    private CqlValueSet Encounter_Inpatient_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);

    [CqlDeclaration("Encounter Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307")]
    public CqlValueSet Encounter_Inpatient() => __Encounter_Inpatient.Value;

    private CqlValueSet Glucose_lab_test_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.134", null);

    [CqlDeclaration("Glucose lab test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.134")]
    public CqlValueSet Glucose_lab_test() => __Glucose_lab_test.Value;

    private CqlValueSet Hypoglycemics_Treatment_Medications_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1196.394", null);

    [CqlDeclaration("Hypoglycemics Treatment Medications")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1196.394")]
    public CqlValueSet Hypoglycemics_Treatment_Medications() => __Hypoglycemics_Treatment_Medications.Value;

    private CqlCode Birth_date_Value() =>
		new CqlCode("21112-8", "http://loinc.org", null, null);

    [CqlDeclaration("Birth date")]
    public CqlCode Birth_date() => __Birth_date.Value;

    private CqlCode[] LOINC_Value()
	{
		var a_ = new CqlCode("21112-8", "http://loinc.org", null, null);

		return new CqlCode[]
		{
			a_,
		};
	}

    [CqlDeclaration("LOINC")]
    public CqlCode[] LOINC() => __LOINC.Value;

    private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		var a_ = context.ResolveParameter("HospitalHarmHyperglycemiainHospitalizedPatientsFHIR-0.0.006", "Measurement Period", null);

		return (CqlInterval<CqlDateTime>)a_;
	}

    [CqlDeclaration("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period() => __Measurement_Period.Value;

    private Patient Patient_Value()
	{
		var a_ = context?.DataRetriever.RetrieveByValueSet<Patient>(null, null);

		return context?.Operators.SingleOrNull<Patient>(a_);
	}

    [CqlDeclaration("Patient")]
    public Patient Patient() => __Patient.Value;

    private IEnumerable<Coding> SDE_Ethnicity_Value() =>
		SupplementalDataElementsFHIR4_2_0_000.SDE_Ethnicity();

    [CqlDeclaration("SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity() => __SDE_Ethnicity.Value;

    private IEnumerable<Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG> SDE_Payer_Value() =>
		SupplementalDataElementsFHIR4_2_0_000.SDE_Payer();

    [CqlDeclaration("SDE Payer")]
    public IEnumerable<Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG> SDE_Payer() => __SDE_Payer.Value;

    private IEnumerable<Coding> SDE_Race_Value() =>
		SupplementalDataElementsFHIR4_2_0_000.SDE_Race();

    [CqlDeclaration("SDE Race")]
    public IEnumerable<Coding> SDE_Race() => __SDE_Race.Value;

    private CqlCode SDE_Sex_Value() =>
		SupplementalDataElementsFHIR4_2_0_000.SDE_Sex();

    [CqlDeclaration("SDE Sex")]
    public CqlCode SDE_Sex() => __SDE_Sex.Value;

    private IEnumerable<Encounter> Inpatient_Encounter_During_Measurement_Period_Value()
	{
		var a_ = this.Encounter_Inpatient();

		return context?.DataRetriever.RetrieveByValueSet<Encounter>(a_, null);
	}

    [CqlDeclaration("Inpatient Encounter During Measurement Period")]
    public IEnumerable<Encounter> Inpatient_Encounter_During_Measurement_Period() => __Inpatient_Encounter_During_Measurement_Period.Value;

    private IEnumerable<Encounter> Qualifying_Encounters_Value()
	{
		var k_ = this.Inpatient_Encounter_During_Measurement_Period();
		var l_ = (Encounter InpatientEncounter) =>
		{
			var a_ = this.Patient();
			var b_ = a_?.BirthDateElement;
			var c_ = b_?.Value;
			var d_ = context?.Operators.ConvertStringToDateTime(c_);
			var e_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(InpatientEncounter);
			var f_ = context?.Operators.Start(e_);
			var g_ = context?.Operators.CalculateAgeAt(d_, f_, "year");
			var h_ = g_;
			var i_ = (int?)18;
			var j_ = i_;

			return context?.Operators.GreaterOrEqual(h_, j_);
		};

		return context?.Operators.WhereOrNull<Encounter>(k_, l_);
	}

    [CqlDeclaration("Qualifying Encounters")]
    public IEnumerable<Encounter> Qualifying_Encounters() => __Qualifying_Encounters.Value;

    private IEnumerable<Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW> Qualifying_Encounters_With_Hospitalization_Period_Value()
	{
		var c_ = this.Qualifying_Encounters();
		var d_ = (Encounter QualifyingEncounter) =>
		{
			var a_ = QualifyingEncounter;
			var b_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(QualifyingEncounter);

			return new Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW
			{
				encounter = a_,
				hospitalizationPeriod = b_,
			};
		};

		return context?.Operators.SelectOrNull<Encounter, Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW>(c_, d_);
	}

    [CqlDeclaration("Qualifying Encounters With Hospitalization Period")]
    public IEnumerable<Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW> Qualifying_Encounters_With_Hospitalization_Period() => __Qualifying_Encounters_With_Hospitalization_Period.Value;

    private IEnumerable<Encounter> Qualifying_Encounters_With_Existing_Diabetes_Diagnosis_Value()
	{
		var t_ = this.Qualifying_Encounters_With_Hospitalization_Period();
		var u_ = (Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW EncounterWithHospitalization) =>
		{
			var o_ = this.Diabetes();
			var p_ = context?.DataRetriever.RetrieveByValueSet<Condition>(o_, null);
			var q_ = (Condition DiabetesDiagnosis) =>
			{
				var a_ = DiabetesDiagnosis?.VerificationStatus;
				var b_ = FHIRHelpers_4_0_001.ToConcept(a_);
				var c_ = (b_ as object);
				var d_ = MATGlobalCommonFunctionsFHIR4_6_1_000.confirmed();
				var e_ = context?.Operators.ConvertCodeToConcept(d_);
				var f_ = (e_ as object);
				var g_ = context?.Operators.Equivalent(c_, f_);
				var h_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Prevalence_Period(DiabetesDiagnosis);
				var i_ = context?.Operators.Start(h_);
				var j_ = (i_ as object);
				var k_ = EncounterWithHospitalization?.hospitalizationPeriod;
				var l_ = context?.Operators.End(k_);
				var m_ = (l_ as object);
				var n_ = context?.Operators.Before(j_, m_, null);

				return context?.Operators.And(g_, n_);
			};
			var r_ = context?.Operators.WhereOrNull<Condition>(p_, q_);
			var s_ = (Condition DiabetesDiagnosis) => EncounterWithHospitalization;

			return context?.Operators.SelectOrNull<Condition, Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW>(r_, s_);
		};
		var v_ = context?.Operators.SelectManyOrNull<Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW, Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW>(t_, u_);
		var w_ = (Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW EncounterWithHospitalization) => EncounterWithHospitalization?.encounter;

		return context?.Operators.SelectOrNull<Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW, Encounter>(v_, w_);
	}

    [CqlDeclaration("Qualifying Encounters With Existing Diabetes Diagnosis")]
    public IEnumerable<Encounter> Qualifying_Encounters_With_Existing_Diabetes_Diagnosis() => __Qualifying_Encounters_With_Existing_Diabetes_Diagnosis.Value;

    private IEnumerable<Encounter> Qualifying_Encounters_With_Hypoglycemic_Medication_Value()
	{
		var u_ = this.Qualifying_Encounters_With_Hospitalization_Period();
		var v_ = (Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW _EncounterWithHospitalization) =>
		{
			var a_ = this.Hypoglycemics_Treatment_Medications();
			var b_ = context?.DataRetriever.RetrieveByValueSet<MedicationAdministration>(a_, null);
			var c_ = this.Hypoglycemics_Treatment_Medications();
			var d_ = context?.DataRetriever.RetrieveByValueSet<MedicationAdministration>(c_, null);

			return context?.Operators.ListUnion<MedicationAdministration>(b_, d_);
		};
		var w_ = (Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW _EncounterWithHospitalization, MedicationAdministration _HypoglycemicMedication) =>
		{
			var e_ = _EncounterWithHospitalization;
			var f_ = _HypoglycemicMedication;

			return new Tuples.Tuple_EBCeiDEEJUjLQKCDbhKCQVIHW
			{
				EncounterWithHospitalization = e_,
				HypoglycemicMedication = f_,
			};
		};
		var x_ = context?.Operators.SelectManyResultsOrNull<Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW, MedicationAdministration, Tuples.Tuple_EBCeiDEEJUjLQKCDbhKCQVIHW>(u_, v_, w_);
		var y_ = (Tuples.Tuple_EBCeiDEEJUjLQKCDbhKCQVIHW tuple_ebceideejujlqkcdbhkcqvihw) =>
		{
			var g_ = tuple_ebceideejujlqkcdbhkcqvihw?.HypoglycemicMedication;
			var h_ = g_?.StatusElement;
			var i_ = (h_ as object);
			var j_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(i_);
			var k_ = (j_ as object);
			var l_ = context?.Operators.Equal(k_, ("completed" as object));
			var m_ = tuple_ebceideejujlqkcdbhkcqvihw?.EncounterWithHospitalization;
			var n_ = m_?.hospitalizationPeriod;
			var o_ = tuple_ebceideejujlqkcdbhkcqvihw?.HypoglycemicMedication;
			var p_ = o_?.Effective;
			var q_ = (p_ as object);
			var r_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(q_);
			var s_ = context?.Operators.IntervalIncludesInterval<CqlDateTime>(n_, r_, null);

			return context?.Operators.And(l_, s_);
		};
		var z_ = context?.Operators.WhereOrNull<Tuples.Tuple_EBCeiDEEJUjLQKCDbhKCQVIHW>(x_, y_);
		var aa_ = (Tuples.Tuple_EBCeiDEEJUjLQKCDbhKCQVIHW tuple_ebceideejujlqkcdbhkcqvihw) =>
		{
			var t_ = tuple_ebceideejujlqkcdbhkcqvihw?.EncounterWithHospitalization;

			return t_?.encounter;
		};

		return context?.Operators.SelectOrNull<Tuples.Tuple_EBCeiDEEJUjLQKCDbhKCQVIHW, Encounter>(z_, aa_);
	}

    [CqlDeclaration("Qualifying Encounters With Hypoglycemic Medication")]
    public IEnumerable<Encounter> Qualifying_Encounters_With_Hypoglycemic_Medication() => __Qualifying_Encounters_With_Hypoglycemic_Medication.Value;

    private IEnumerable<Encounter> Qualifying_Encounters_With_Elevated_Blood_Glucose_Lab_Value()
	{
		var z_ = this.Qualifying_Encounters_With_Hospitalization_Period();
		var aa_ = (Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW EncounterWithHospitalization) =>
		{
			var u_ = this.Glucose_lab_test();
			var v_ = context?.DataRetriever.RetrieveByValueSet<Observation>(u_, null);
			var w_ = (Observation BloodGlucoseLab) =>
			{
				var a_ = BloodGlucoseLab?.Effective;
				var b_ = (a_ as object);
				var c_ = (b_ as FhirDateTime);
				var d_ = FHIRHelpers_4_0_001.ToDateTime(c_);
				var e_ = EncounterWithHospitalization?.hospitalizationPeriod;
				var f_ = context?.Operators.ElementInInterval<CqlDateTime>(d_, e_, null);
				var g_ = BloodGlucoseLab?.StatusElement;
				var h_ = (g_ as object);
				var i_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(h_);
				var j_ = (i_ as object);
				var k_ = context?.Operators.Equal(j_, ("final" as object));
				var l_ = context?.Operators.And(f_, k_);
				var m_ = BloodGlucoseLab?.Value;
				var n_ = (m_ as object);
				var o_ = (n_ as Quantity);
				var p_ = FHIRHelpers_4_0_001.ToQuantity(o_);
				var q_ = (p_ as object);
				var r_ = context?.Operators.Quantity(200m, "mg/dL");
				var s_ = (r_ as object);
				var t_ = context?.Operators.GreaterOrEqual(q_, s_);

				return context?.Operators.And(l_, t_);
			};
			var x_ = context?.Operators.WhereOrNull<Observation>(v_, w_);
			var y_ = (Observation BloodGlucoseLab) => EncounterWithHospitalization;

			return context?.Operators.SelectOrNull<Observation, Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW>(x_, y_);
		};
		var ab_ = context?.Operators.SelectManyOrNull<Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW, Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW>(z_, aa_);
		var ac_ = (Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW EncounterWithHospitalization) => EncounterWithHospitalization?.encounter;

		return context?.Operators.SelectOrNull<Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW, Encounter>(ab_, ac_);
	}

    [CqlDeclaration("Qualifying Encounters With Elevated Blood Glucose Lab")]
    public IEnumerable<Encounter> Qualifying_Encounters_With_Elevated_Blood_Glucose_Lab() => __Qualifying_Encounters_With_Elevated_Blood_Glucose_Lab.Value;

    private IEnumerable<Encounter> Initial_Population_Value()
	{
		var a_ = this.Qualifying_Encounters_With_Existing_Diabetes_Diagnosis();
		var b_ = this.Qualifying_Encounters_With_Hypoglycemic_Medication();
		var c_ = context?.Operators.ListUnion<Encounter>(a_, b_);
		var d_ = this.Qualifying_Encounters_With_Elevated_Blood_Glucose_Lab();

		return context?.Operators.ListUnion<Encounter>(c_, d_);
	}

    [CqlDeclaration("Initial Population")]
    public IEnumerable<Encounter> Initial_Population() => __Initial_Population.Value;

    private IEnumerable<Encounter> Denominator_Value() =>
		this.Initial_Population();

    [CqlDeclaration("Denominator")]
    public IEnumerable<Encounter> Denominator() => __Denominator.Value;

    [CqlDeclaration("Crop Interval to 10 Days")]
    public CqlInterval<CqlDateTime> Crop_Interval_to_10_Days(CqlInterval<CqlDateTime> Period)
	{
		var a_ = context?.Operators.Start(Period);
		var b_ = context?.Operators.End(Period);
		var c_ = context?.Operators.Start(Period);
		var d_ = context?.Operators.Quantity(10m, "days");
		var e_ = context?.Operators.Add(c_, d_);
		var f_ = new CqlDateTime[]
		{
			b_,
			e_,
		};
		var g_ = (f_ as IEnumerable<CqlDateTime>);
		var h_ = context?.Operators.MinOrNull<CqlDateTime>(g_);

		return context?.Operators.Interval(a_, h_, true, true);
	}


    [CqlDeclaration("Interval To Day Numbers")]
    public IEnumerable<int?> Interval_To_Day_Numbers(CqlInterval<CqlDateTime> Period)
	{
		var a_ = context?.Operators.Start(Period);
		var b_ = context?.Operators.End(Period);
		var c_ = context?.Operators.DurationBetween(a_, b_, "day");
		var d_ = context?.Operators.Interval((int?)1, c_, true, true);
		var e_ = new CqlInterval<int?>[]
		{
			d_,
		};
		var f_ = (e_ as IEnumerable<CqlInterval<int?>>);
		var g_ = context?.Operators.ExpandList(f_, null);
		var h_ = (CqlInterval<int?> DayExpand) => context?.Operators.End(DayExpand);

		return context?.Operators.SelectOrNull<CqlInterval<int?>, int?>(g_, h_);
	}


    [CqlDeclaration("Days In Period")]
    public IEnumerable<Tuples.Tuple_BZfjDHYASdKbVKTOeigaYPBVf> Days_In_Period(CqlInterval<CqlDateTime> Period)
	{
		var i_ = this.Interval_To_Day_Numbers(Period);
		var j_ = (int? DayIndex) =>
		{
			var a_ = DayIndex;
			var b_ = context?.Operators.Start(Period);
			var c_ = context?.Operators.Quantity(24m, "hours");
			var d_ = context?.Operators.Subtract(DayIndex, (int?)1);
			var e_ = context?.Operators.ConvertIntegerToQuantity(d_);
			var f_ = context?.Operators.Multiply(c_, e_);
			var g_ = context?.Operators.Add(b_, f_);
			var h_ = context?.Operators.Interval(g_, (((context?.Operators.Less(context?.Operators.DurationBetween(context?.Operators.Add(context?.Operators.Start(Period), context?.Operators.Multiply(context?.Operators.Quantity(24m, "hours"), context?.Operators.ConvertIntegerToQuantity(context?.Operators.Subtract(DayIndex, (int?)1)))), context?.Operators.End(Period), "hour"), (int?)24) ?? false))
					? (context?.Operators.Add(context?.Operators.Start(Period), context?.Operators.Multiply(context?.Operators.Quantity(24m, "hours"), context?.Operators.ConvertIntegerToQuantity(context?.Operators.Subtract(DayIndex, (int?)1)))))
					: (context?.Operators.Add(context?.Operators.Start(Period), context?.Operators.Multiply(context?.Operators.Quantity(24m, "hours"), context?.Operators.ConvertIntegerToQuantity(DayIndex)))))
, true, false);

			return new Tuples.Tuple_BZfjDHYASdKbVKTOeigaYPBVf
			{
				dayIndex = a_,
				dayPeriod = h_,
			};
		};

		return context?.Operators.SelectOrNull<int?, Tuples.Tuple_BZfjDHYASdKbVKTOeigaYPBVf>(i_, j_);
	}


    private IEnumerable<Tuples.Tuple_FdccSJcWTSebijGjABdUMLEdR> Pertinent_Encounters_With_Days_Value()
	{
		var h_ = this.Initial_Population();
		var i_ = (Encounter PertinentEncounter) =>
		{
			var a_ = PertinentEncounter;
			var b_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(PertinentEncounter);
			var c_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(PertinentEncounter);
			var d_ = this.Crop_Interval_to_10_Days(c_);
			var e_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(PertinentEncounter);
			var f_ = this.Crop_Interval_to_10_Days(e_);
			var g_ = this.Days_In_Period(f_);

			return new Tuples.Tuple_FdccSJcWTSebijGjABdUMLEdR
			{
				encounter = a_,
				hospitalizationPeriod = b_,
				relevantPeriod = d_,
				relevantDays = g_,
			};
		};

		return context?.Operators.SelectOrNull<Encounter, Tuples.Tuple_FdccSJcWTSebijGjABdUMLEdR>(h_, i_);
	}

    [CqlDeclaration("Pertinent Encounters With Days")]
    public IEnumerable<Tuples.Tuple_FdccSJcWTSebijGjABdUMLEdR> Pertinent_Encounters_With_Days() => __Pertinent_Encounters_With_Days.Value;

    private IEnumerable<Tuples.Tuple_GiWKJXbiXAiGGBDVZJdMTaVhK> Pertinent_Encounters_With_Glucose_Result_Days_Value()
	{
		var bw_ = this.Pertinent_Encounters_With_Days();
		var bx_ = (Tuples.Tuple_FdccSJcWTSebijGjABdUMLEdR PertinentEncounterDays) =>
		{
			var br_ = PertinentEncounterDays?.encounter;
			var bs_ = PertinentEncounterDays?.relevantPeriod;
			var bt_ = PertinentEncounterDays?.relevantDays;
			var bu_ = (Tuples.Tuple_BZfjDHYASdKbVKTOeigaYPBVf EncounterDay) =>
			{
				var az_ = EncounterDay?.dayIndex;
				var ba_ = EncounterDay?.dayPeriod;
				var bb_ = this.Glucose_lab_test();
				var bc_ = context?.DataRetriever.RetrieveByValueSet<Observation>(bb_, null);
				var bd_ = (Observation BloodGlucoseLab1) =>
				{
					var a_ = BloodGlucoseLab1?.StatusElement;
					var b_ = (a_ as object);
					var c_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(b_);
					var d_ = (c_ as object);
					var e_ = context?.Operators.Equal(d_, ("final" as object));
					var f_ = BloodGlucoseLab1?.Value;
					var g_ = (f_ as object);
					var h_ = (g_ as Quantity);
					var i_ = FHIRHelpers_4_0_001.ToQuantity(h_);
					var j_ = (i_ as object);
					var k_ = context?.Operators.Quantity(300m, "mg/dL");
					var l_ = (k_ as object);
					var m_ = context?.Operators.Greater(j_, l_);
					var n_ = context?.Operators.And(e_, m_);
					var o_ = BloodGlucoseLab1?.Effective;
					var p_ = (o_ as object);
					var q_ = (p_ as FhirDateTime);
					var r_ = FHIRHelpers_4_0_001.ToDateTime(q_);
					var s_ = EncounterDay?.dayPeriod;
					var t_ = context?.Operators.ElementInInterval<CqlDateTime>(r_, s_, null);

					return context?.Operators.And(n_, t_);
				};
				var be_ = context?.Operators.WhereOrNull<Observation>(bc_, bd_);
				var bf_ = context?.Operators.ExistsInList<Observation>(be_);
				var bg_ = this.Glucose_lab_test();
				var bh_ = context?.DataRetriever.RetrieveByValueSet<Observation>(bg_, null);
				var bi_ = (Observation BloodGlucoseLab2) =>
				{
					var u_ = BloodGlucoseLab2?.StatusElement;
					var v_ = (u_ as object);
					var w_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(v_);
					var x_ = (w_ as object);
					var y_ = context?.Operators.Equal(x_, ("final" as object));
					var z_ = BloodGlucoseLab2?.Value;
					var aa_ = (z_ as object);
					var ab_ = (aa_ as Quantity);
					var ac_ = FHIRHelpers_4_0_001.ToQuantity(ab_);
					var ad_ = (ac_ as object);
					var ae_ = context?.Operators.Quantity(200m, "mg/dL");
					var af_ = (ae_ as object);
					var ag_ = context?.Operators.GreaterOrEqual(ad_, af_);
					var ah_ = context?.Operators.And(y_, ag_);
					var ai_ = BloodGlucoseLab2?.Effective;
					var aj_ = (ai_ as object);
					var ak_ = (aj_ as FhirDateTime);
					var al_ = FHIRHelpers_4_0_001.ToDateTime(ak_);
					var am_ = EncounterDay?.dayPeriod;
					var an_ = context?.Operators.ElementInInterval<CqlDateTime>(al_, am_, null);

					return context?.Operators.And(ah_, an_);
				};
				var bj_ = context?.Operators.WhereOrNull<Observation>(bh_, bi_);
				var bk_ = context?.Operators.ExistsInList<Observation>(bj_);
				var bl_ = this.Glucose_lab_test();
				var bm_ = context?.DataRetriever.RetrieveByValueSet<Observation>(bl_, null);
				var bn_ = (Observation BloodGlucoseLab3) =>
				{
					var ao_ = BloodGlucoseLab3?.StatusElement;
					var ap_ = (ao_ as object);
					var aq_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(ap_);
					var ar_ = (aq_ as object);
					var as_ = context?.Operators.Equal(ar_, ("final" as object));
					var at_ = BloodGlucoseLab3?.Effective;
					var au_ = (at_ as object);
					var av_ = (au_ as FhirDateTime);
					var aw_ = FHIRHelpers_4_0_001.ToDateTime(av_);
					var ax_ = EncounterDay?.dayPeriod;
					var ay_ = context?.Operators.ElementInInterval<CqlDateTime>(aw_, ax_, null);

					return context?.Operators.And(as_, ay_);
				};
				var bo_ = context?.Operators.WhereOrNull<Observation>(bm_, bn_);
				var bp_ = context?.Operators.ExistsInList<Observation>(bo_);
				var bq_ = context?.Operators.Not(bp_);

				return new Tuples.Tuple_EPQMNeOgChVRHOcBPRccPNZeF
				{
					dayIndex = az_,
					dayPeriod = ba_,
					hasSevereResult = bf_,
					hasElevatedResult = bk_,
					hasNoResult = bq_,
				};
			};
			var bv_ = context?.Operators.SelectOrNull<Tuples.Tuple_BZfjDHYASdKbVKTOeigaYPBVf, Tuples.Tuple_EPQMNeOgChVRHOcBPRccPNZeF>(bt_, bu_);

			return new Tuples.Tuple_GiWKJXbiXAiGGBDVZJdMTaVhK
			{
				encounter = br_,
				relevantPeriod = bs_,
				relevantDays = bv_,
			};
		};

		return context?.Operators.SelectOrNull<Tuples.Tuple_FdccSJcWTSebijGjABdUMLEdR, Tuples.Tuple_GiWKJXbiXAiGGBDVZJdMTaVhK>(bw_, bx_);
	}

    [CqlDeclaration("Pertinent Encounters With Glucose Result Days")]
    public IEnumerable<Tuples.Tuple_GiWKJXbiXAiGGBDVZJdMTaVhK> Pertinent_Encounters_With_Glucose_Result_Days() => __Pertinent_Encounters_With_Glucose_Result_Days.Value;

    private IEnumerable<Tuples.Tuple_CAbQjTVRCSKOYWiIhECGMcDPA> Pertinent_Encounters_With_Hyperglycemic_Event_Days_Value()
	{
		var ac_ = this.Pertinent_Encounters_With_Glucose_Result_Days();
		var ad_ = (Tuples.Tuple_GiWKJXbiXAiGGBDVZJdMTaVhK EncounterWithResultDays) =>
		{
			var v_ = EncounterWithResultDays?.encounter;
			var w_ = EncounterWithResultDays?.relevantPeriod;
			var x_ = EncounterWithResultDays?.relevantDays;
			var y_ = (Tuples.Tuple_EPQMNeOgChVRHOcBPRccPNZeF EncounterDay) =>
			{
				var a_ = EncounterDay?.dayIndex;
				var b_ = a_;
				var c_ = (int?)1;
				var d_ = c_;

				return context?.Operators.Greater(b_, d_);
			};
			var z_ = context?.Operators.WhereOrNull<Tuples.Tuple_EPQMNeOgChVRHOcBPRccPNZeF>(x_, y_);
			var aa_ = (Tuples.Tuple_EPQMNeOgChVRHOcBPRccPNZeF EncounterDay) =>
			{
				var e_ = EncounterDay?.dayIndex;
				var f_ = EncounterDay?.dayPeriod;
				var g_ = EncounterDay?.hasSevereResult;
				var h_ = EncounterDay?.hasNoResult;
				var i_ = EncounterWithResultDays?.relevantDays;
				var j_ = EncounterDay?.dayIndex;
				var k_ = context?.Operators.Subtract(j_, (int?)2);
				var l_ = context?.Operators.ListElementAt<Tuples.Tuple_EPQMNeOgChVRHOcBPRccPNZeF>(i_, k_);
				var m_ = l_?.hasElevatedResult;
				var n_ = context?.Operators.And(h_, m_);
				var o_ = EncounterWithResultDays?.relevantDays;
				var p_ = EncounterDay?.dayIndex;
				var q_ = context?.Operators.Subtract(p_, (int?)3);
				var r_ = context?.Operators.ListElementAt<Tuples.Tuple_EPQMNeOgChVRHOcBPRccPNZeF>(o_, q_);
				var s_ = r_?.hasElevatedResult;
				var t_ = context?.Operators.And(n_, s_);
				var u_ = context?.Operators.Or(g_, t_);

				return new Tuples.Tuple_HBBaLFUhhUfQBEJKjEZegSRLi
				{
					dayIndex = e_,
					dayPeriod = f_,
					hasHyperglycemicEvent = u_,
				};
			};
			var ab_ = context?.Operators.SelectOrNull<Tuples.Tuple_EPQMNeOgChVRHOcBPRccPNZeF, Tuples.Tuple_HBBaLFUhhUfQBEJKjEZegSRLi>(z_, aa_);

			return new Tuples.Tuple_CAbQjTVRCSKOYWiIhECGMcDPA
			{
				encounter = v_,
				relevantPeriod = w_,
				eligibleEventDays = ab_,
			};
		};

		return context?.Operators.SelectOrNull<Tuples.Tuple_GiWKJXbiXAiGGBDVZJdMTaVhK, Tuples.Tuple_CAbQjTVRCSKOYWiIhECGMcDPA>(ac_, ad_);
	}

    [CqlDeclaration("Pertinent Encounters With Hyperglycemic Event Days")]
    public IEnumerable<Tuples.Tuple_CAbQjTVRCSKOYWiIhECGMcDPA> Pertinent_Encounters_With_Hyperglycemic_Event_Days() => __Pertinent_Encounters_With_Hyperglycemic_Event_Days.Value;

    private IEnumerable<Encounter> Numerator_Value()
	{
		var d_ = this.Pertinent_Encounters_With_Hyperglycemic_Event_Days();
		var e_ = (Tuples.Tuple_CAbQjTVRCSKOYWiIhECGMcDPA EncounterWithEventDays) =>
		{
			var a_ = EncounterWithEventDays?.eligibleEventDays;
			var b_ = (Tuples.Tuple_HBBaLFUhhUfQBEJKjEZegSRLi EligibleEventDay) => EligibleEventDay?.hasHyperglycemicEvent;
			var c_ = context?.Operators.WhereOrNull<Tuples.Tuple_HBBaLFUhhUfQBEJKjEZegSRLi>(a_, b_);

			return context?.Operators.ExistsInList<Tuples.Tuple_HBBaLFUhhUfQBEJKjEZegSRLi>(c_);
		};
		var f_ = context?.Operators.WhereOrNull<Tuples.Tuple_CAbQjTVRCSKOYWiIhECGMcDPA>(d_, e_);
		var g_ = (Tuples.Tuple_CAbQjTVRCSKOYWiIhECGMcDPA EncounterWithEventDays) => EncounterWithEventDays?.encounter;

		return context?.Operators.SelectOrNull<Tuples.Tuple_CAbQjTVRCSKOYWiIhECGMcDPA, Encounter>(f_, g_);
	}

    [CqlDeclaration("Numerator")]
    public IEnumerable<Encounter> Numerator() => __Numerator.Value;

    [CqlDeclaration("Denominator Observations")]
    public int? Denominator_Observations(Encounter QualifyingEncounter)
	{
		var d_ = this.Pertinent_Encounters_With_Hyperglycemic_Event_Days();
		var e_ = (Tuples.Tuple_CAbQjTVRCSKOYWiIhECGMcDPA EncounterWithEventDays) =>
		{
			var a_ = EncounterWithEventDays?.encounter;
			var b_ = (a_ as object);

			return context?.Operators.Equal(b_, (QualifyingEncounter as object));
		};
		var f_ = context?.Operators.WhereOrNull<Tuples.Tuple_CAbQjTVRCSKOYWiIhECGMcDPA>(d_, e_);
		var g_ = (Tuples.Tuple_CAbQjTVRCSKOYWiIhECGMcDPA EncounterWithEventDays) =>
		{
			var c_ = EncounterWithEventDays?.eligibleEventDays;

			return context?.Operators.CountOrNull<Tuples.Tuple_HBBaLFUhhUfQBEJKjEZegSRLi>(c_);
		};
		var h_ = context?.Operators.SelectOrNull<Tuples.Tuple_CAbQjTVRCSKOYWiIhECGMcDPA, int?>(f_, g_);

		return context?.Operators.SingleOrNull<int?>(h_);
	}


    [CqlDeclaration("Numerator Observations")]
    public int? Numerator_Observations(Encounter QualifyingEncounter)
	{
		var f_ = this.Pertinent_Encounters_With_Hyperglycemic_Event_Days();
		var g_ = (Tuples.Tuple_CAbQjTVRCSKOYWiIhECGMcDPA EncounterWithEventDays) =>
		{
			var a_ = EncounterWithEventDays?.encounter;
			var b_ = (a_ as object);

			return context?.Operators.Equal(b_, (QualifyingEncounter as object));
		};
		var h_ = context?.Operators.WhereOrNull<Tuples.Tuple_CAbQjTVRCSKOYWiIhECGMcDPA>(f_, g_);
		var i_ = (Tuples.Tuple_CAbQjTVRCSKOYWiIhECGMcDPA EncounterWithEventDays) =>
		{
			var c_ = EncounterWithEventDays?.eligibleEventDays;
			var d_ = (Tuples.Tuple_HBBaLFUhhUfQBEJKjEZegSRLi EligibleEventDay) => EligibleEventDay?.hasHyperglycemicEvent;
			var e_ = context?.Operators.WhereOrNull<Tuples.Tuple_HBBaLFUhhUfQBEJKjEZegSRLi>(c_, d_);

			return context?.Operators.CountOrNull<Tuples.Tuple_HBBaLFUhhUfQBEJKjEZegSRLi>(e_);
		};
		var j_ = context?.Operators.SelectOrNull<Tuples.Tuple_CAbQjTVRCSKOYWiIhECGMcDPA, int?>(h_, i_);

		return context?.Operators.SingleOrNull<int?>(j_);
	}


}