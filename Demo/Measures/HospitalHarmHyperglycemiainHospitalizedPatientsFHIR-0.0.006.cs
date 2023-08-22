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
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.560.100.4", 
			null);

    [CqlDeclaration("birth date")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.560.100.4")]
    public CqlValueSet birth_date() => __birth_date.Value;

    private CqlValueSet Diabetes_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.103.12.1001", 
			null);

    [CqlDeclaration("Diabetes")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.103.12.1001")]
    public CqlValueSet Diabetes() => __Diabetes.Value;

    private CqlValueSet Encounter_Inpatient_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", 
			null);

    [CqlDeclaration("Encounter Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307")]
    public CqlValueSet Encounter_Inpatient() => __Encounter_Inpatient.Value;

    private CqlValueSet Glucose_lab_test_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.134", 
			null);

    [CqlDeclaration("Glucose lab test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.134")]
    public CqlValueSet Glucose_lab_test() => __Glucose_lab_test.Value;

    private CqlValueSet Hypoglycemics_Treatment_Medications_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1196.394", 
			null);

    [CqlDeclaration("Hypoglycemics Treatment Medications")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1196.394")]
    public CqlValueSet Hypoglycemics_Treatment_Medications() => __Hypoglycemics_Treatment_Medications.Value;

    private CqlCode Birth_date_Value() =>
		new CqlCode("21112-8", 
			"http://loinc.org", 
			null, 
			null);

    [CqlDeclaration("Birth date")]
    public CqlCode Birth_date() => __Birth_date.Value;

    private CqlCode[] LOINC_Value()
	{
		var a_ = new CqlCode("21112-8", 
			"http://loinc.org", 
			null, 
			null);

		return new CqlCode[]
		{
			a_,
		};
	}

    [CqlDeclaration("LOINC")]
    public CqlCode[] LOINC() => __LOINC.Value;

    private CqlInterval<CqlDateTime> Measurement_Period_Value() =>
		(CqlInterval<CqlDateTime>)context.ResolveParameter("HospitalHarmHyperglycemiainHospitalizedPatientsFHIR-0.0.006", "Measurement Period", null);

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
		var a_ = this.Inpatient_Encounter_During_Measurement_Period();
		var b_ = (Encounter InpatientEncounter) =>
		{
			var a_ = this.Patient()?.BirthDateElement?.Value;
			var b_ = context?.Operators.ConvertStringToDateTime(a_);
			var c_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(InpatientEncounter);
			var d_ = context?.Operators.Start(c_);
			var e_ = context?.Operators.CalculateAgeAt(b_, d_, "year");
			var f_ = (e_ as object);
			var g_ = ((int?)18 as object);

			return context?.Operators.GreaterOrEqual(f_, g_);
		};

		return context?.Operators.WhereOrNull<Encounter>(a_, b_);
	}

    [CqlDeclaration("Qualifying Encounters")]
    public IEnumerable<Encounter> Qualifying_Encounters() => __Qualifying_Encounters.Value;

    private IEnumerable<Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW> Qualifying_Encounters_With_Hospitalization_Period_Value()
	{
		var a_ = this.Qualifying_Encounters();
		var b_ = (Encounter QualifyingEncounter) =>
		{
			var a_ = QualifyingEncounter;
			var b_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(QualifyingEncounter);

			return new Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW
			{
				encounter = a_,
				hospitalizationPeriod = b_,
			};
		};

		return context?.Operators.SelectOrNull<Encounter, Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW>(a_, b_);
	}

    [CqlDeclaration("Qualifying Encounters With Hospitalization Period")]
    public IEnumerable<Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW> Qualifying_Encounters_With_Hospitalization_Period() => __Qualifying_Encounters_With_Hospitalization_Period.Value;

    private IEnumerable<Encounter> Qualifying_Encounters_With_Existing_Diabetes_Diagnosis_Value()
	{
		var a_ = this.Qualifying_Encounters_With_Hospitalization_Period();
		var b_ = (Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW EncounterWithHospitalization) =>
		{
			var a_ = this.Diabetes();
			var b_ = context?.DataRetriever.RetrieveByValueSet<Condition>(a_, null);
			var c_ = (Condition DiabetesDiagnosis) =>
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
			var d_ = context?.Operators.WhereOrNull<Condition>(b_, c_);
			var e_ = (Condition DiabetesDiagnosis) => EncounterWithHospitalization;

			return context?.Operators.SelectOrNull<Condition, Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW>(d_, e_);
		};
		var c_ = context?.Operators.SelectManyOrNull<Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW, Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW>(a_, b_);
		var d_ = (Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW EncounterWithHospitalization) => EncounterWithHospitalization?.encounter;

		return context?.Operators.SelectOrNull<Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW, Encounter>(c_, d_);
	}

    [CqlDeclaration("Qualifying Encounters With Existing Diabetes Diagnosis")]
    public IEnumerable<Encounter> Qualifying_Encounters_With_Existing_Diabetes_Diagnosis() => __Qualifying_Encounters_With_Existing_Diabetes_Diagnosis.Value;

    private IEnumerable<Encounter> Qualifying_Encounters_With_Hypoglycemic_Medication_Value()
	{
		var a_ = this.Qualifying_Encounters_With_Hospitalization_Period();
		var b_ = (Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW _EncounterWithHospitalization) =>
		{
			var a_ = this.Hypoglycemics_Treatment_Medications();
			var b_ = context?.DataRetriever.RetrieveByValueSet<MedicationAdministration>(a_, null);
			var c_ = this.Hypoglycemics_Treatment_Medications();
			var d_ = context?.DataRetriever.RetrieveByValueSet<MedicationAdministration>(c_, null);

			return context?.Operators.ListUnion<MedicationAdministration>(b_, d_);
		};
		var c_ = (Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW _EncounterWithHospitalization, MedicationAdministration _HypoglycemicMedication) =>
		{
			var a_ = _EncounterWithHospitalization;
			var b_ = _HypoglycemicMedication;

			return new Tuples.Tuple_EBCeiDEEJUjLQKCDbhKCQVIHW
			{
				EncounterWithHospitalization = a_,
				HypoglycemicMedication = b_,
			};
		};
		var d_ = context?.Operators.SelectManyResultsOrNull<Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW, MedicationAdministration, Tuples.Tuple_EBCeiDEEJUjLQKCDbhKCQVIHW>(a_, b_, c_);
		var e_ = (Tuples.Tuple_EBCeiDEEJUjLQKCDbhKCQVIHW tuple_ebceideejujlqkcdbhkcqvihw) =>
		{
			var a_ = (tuple_ebceideejujlqkcdbhkcqvihw?.HypoglycemicMedication?.StatusElement as object);
			var b_ = (context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(a_);
			var c_ = (b_ as object);
			var d_ = context?.Operators.Equal(c_, ("completed" as object));
			var e_ = tuple_ebceideejujlqkcdbhkcqvihw?.EncounterWithHospitalization?.hospitalizationPeriod;
			var f_ = (tuple_ebceideejujlqkcdbhkcqvihw?.HypoglycemicMedication?.Effective as object);
			var g_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(f_);
			var h_ = context?.Operators.IntervalIncludesInterval<CqlDateTime>(e_, g_, null);

			return context?.Operators.And(d_, h_);
		};
		var f_ = context?.Operators.WhereOrNull<Tuples.Tuple_EBCeiDEEJUjLQKCDbhKCQVIHW>(d_, e_);
		var g_ = (Tuples.Tuple_EBCeiDEEJUjLQKCDbhKCQVIHW tuple_ebceideejujlqkcdbhkcqvihw) => tuple_ebceideejujlqkcdbhkcqvihw?.EncounterWithHospitalization?.encounter;

		return context?.Operators.SelectOrNull<Tuples.Tuple_EBCeiDEEJUjLQKCDbhKCQVIHW, Encounter>(f_, g_);
	}

    [CqlDeclaration("Qualifying Encounters With Hypoglycemic Medication")]
    public IEnumerable<Encounter> Qualifying_Encounters_With_Hypoglycemic_Medication() => __Qualifying_Encounters_With_Hypoglycemic_Medication.Value;

    private IEnumerable<Encounter> Qualifying_Encounters_With_Elevated_Blood_Glucose_Lab_Value()
	{
		var a_ = this.Qualifying_Encounters_With_Hospitalization_Period();
		var b_ = (Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW EncounterWithHospitalization) =>
		{
			var a_ = this.Glucose_lab_test();
			var b_ = context?.DataRetriever.RetrieveByValueSet<Observation>(a_, null);
			var c_ = (Observation BloodGlucoseLab) =>
			{
				var a_ = ((BloodGlucoseLab?.Effective as object) as FhirDateTime);
				var b_ = FHIRHelpers_4_0_001.ToDateTime(a_);
				var c_ = EncounterWithHospitalization?.hospitalizationPeriod;
				var d_ = context?.Operators.ElementInInterval<CqlDateTime>(b_, c_, null);
				var e_ = (BloodGlucoseLab?.StatusElement as object);
				var f_ = (context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(e_);
				var g_ = (f_ as object);
				var h_ = context?.Operators.Equal(g_, ("final" as object));
				var i_ = context?.Operators.And(d_, h_);
				var j_ = ((BloodGlucoseLab?.Value as object) as Quantity);
				var k_ = FHIRHelpers_4_0_001.ToQuantity(j_);
				var l_ = (k_ as object);
				var m_ = (context?.Operators.Quantity(200m, "mg/dL") as object);
				var n_ = context?.Operators.GreaterOrEqual(l_, m_);

				return context?.Operators.And(i_, n_);
			};
			var d_ = context?.Operators.WhereOrNull<Observation>(b_, c_);
			var e_ = (Observation BloodGlucoseLab) => EncounterWithHospitalization;

			return context?.Operators.SelectOrNull<Observation, Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW>(d_, e_);
		};
		var c_ = context?.Operators.SelectManyOrNull<Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW, Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW>(a_, b_);
		var d_ = (Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW EncounterWithHospitalization) => EncounterWithHospitalization?.encounter;

		return context?.Operators.SelectOrNull<Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW, Encounter>(c_, d_);
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
		var a_ = this.Interval_To_Day_Numbers(Period);
		var b_ = (int? DayIndex) =>
		{
			var a_ = DayIndex;
			var b_ = context?.Operators.Start(Period);
			var c_ = context?.Operators.Quantity(24m, "hours");
			var d_ = context?.Operators.Subtract(DayIndex, (int?)1);
			var e_ = context?.Operators.ConvertIntegerToQuantity(d_);
			var f_ = context?.Operators.Multiply(c_, e_);
			var g_ = context?.Operators.Add(b_, f_);
			var h_ = (((context?.Operators.Less((context?.Operators.DurationBetween(context?.Operators.Add(context?.Operators.Start(Period), context?.Operators.Multiply(context?.Operators.Quantity(24m, "hours"), context?.Operators.ConvertIntegerToQuantity(context?.Operators.Subtract(DayIndex, (int?)1)))), context?.Operators.End(Period), "hour") as object), ((int?)24 as object)) ?? false))
				? (context?.Operators.Add(context?.Operators.Start(Period), context?.Operators.Multiply(context?.Operators.Quantity(24m, "hours"), context?.Operators.ConvertIntegerToQuantity(context?.Operators.Subtract(DayIndex, (int?)1)))))
				: (context?.Operators.Add(context?.Operators.Start(Period), context?.Operators.Multiply(context?.Operators.Quantity(24m, "hours"), context?.Operators.ConvertIntegerToQuantity(DayIndex)))))
;
			var i_ = context?.Operators.Interval(g_, h_, true, false);

			return new Tuples.Tuple_BZfjDHYASdKbVKTOeigaYPBVf
			{
				dayIndex = a_,
				dayPeriod = i_,
			};
		};

		return context?.Operators.SelectOrNull<int?, Tuples.Tuple_BZfjDHYASdKbVKTOeigaYPBVf>(a_, b_);
	}


    private IEnumerable<Tuples.Tuple_FdccSJcWTSebijGjABdUMLEdR> Pertinent_Encounters_With_Days_Value()
	{
		var a_ = this.Initial_Population();
		var b_ = (Encounter PertinentEncounter) =>
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

		return context?.Operators.SelectOrNull<Encounter, Tuples.Tuple_FdccSJcWTSebijGjABdUMLEdR>(a_, b_);
	}

    [CqlDeclaration("Pertinent Encounters With Days")]
    public IEnumerable<Tuples.Tuple_FdccSJcWTSebijGjABdUMLEdR> Pertinent_Encounters_With_Days() => __Pertinent_Encounters_With_Days.Value;

    private IEnumerable<Tuples.Tuple_GiWKJXbiXAiGGBDVZJdMTaVhK> Pertinent_Encounters_With_Glucose_Result_Days_Value()
	{
		var a_ = this.Pertinent_Encounters_With_Days();
		var b_ = (Tuples.Tuple_FdccSJcWTSebijGjABdUMLEdR PertinentEncounterDays) =>
		{
			var a_ = PertinentEncounterDays?.encounter;
			var b_ = PertinentEncounterDays?.relevantPeriod;
			var c_ = PertinentEncounterDays?.relevantDays;
			var d_ = (Tuples.Tuple_BZfjDHYASdKbVKTOeigaYPBVf EncounterDay) =>
			{
				var a_ = EncounterDay?.dayIndex;
				var b_ = EncounterDay?.dayPeriod;
				var c_ = this.Glucose_lab_test();
				var d_ = context?.DataRetriever.RetrieveByValueSet<Observation>(c_, null);
				var e_ = (Observation BloodGlucoseLab1) =>
				{
					var a_ = (BloodGlucoseLab1?.StatusElement as object);
					var b_ = (context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(a_);
					var c_ = (b_ as object);
					var d_ = context?.Operators.Equal(c_, ("final" as object));
					var e_ = ((BloodGlucoseLab1?.Value as object) as Quantity);
					var f_ = FHIRHelpers_4_0_001.ToQuantity(e_);
					var g_ = (f_ as object);
					var h_ = (context?.Operators.Quantity(300m, "mg/dL") as object);
					var i_ = context?.Operators.Greater(g_, h_);
					var j_ = context?.Operators.And(d_, i_);
					var k_ = ((BloodGlucoseLab1?.Effective as object) as FhirDateTime);
					var l_ = FHIRHelpers_4_0_001.ToDateTime(k_);
					var m_ = EncounterDay?.dayPeriod;
					var n_ = context?.Operators.ElementInInterval<CqlDateTime>(l_, m_, null);

					return context?.Operators.And(j_, n_);
				};
				var f_ = context?.Operators.WhereOrNull<Observation>(d_, e_);
				var g_ = context?.Operators.ExistsInList<Observation>(f_);
				var h_ = this.Glucose_lab_test();
				var i_ = context?.DataRetriever.RetrieveByValueSet<Observation>(h_, null);
				var j_ = (Observation BloodGlucoseLab2) =>
				{
					var a_ = (BloodGlucoseLab2?.StatusElement as object);
					var b_ = (context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(a_);
					var c_ = (b_ as object);
					var d_ = context?.Operators.Equal(c_, ("final" as object));
					var e_ = ((BloodGlucoseLab2?.Value as object) as Quantity);
					var f_ = FHIRHelpers_4_0_001.ToQuantity(e_);
					var g_ = (f_ as object);
					var h_ = (context?.Operators.Quantity(200m, "mg/dL") as object);
					var i_ = context?.Operators.GreaterOrEqual(g_, h_);
					var j_ = context?.Operators.And(d_, i_);
					var k_ = ((BloodGlucoseLab2?.Effective as object) as FhirDateTime);
					var l_ = FHIRHelpers_4_0_001.ToDateTime(k_);
					var m_ = EncounterDay?.dayPeriod;
					var n_ = context?.Operators.ElementInInterval<CqlDateTime>(l_, m_, null);

					return context?.Operators.And(j_, n_);
				};
				var k_ = context?.Operators.WhereOrNull<Observation>(i_, j_);
				var l_ = context?.Operators.ExistsInList<Observation>(k_);
				var m_ = this.Glucose_lab_test();
				var n_ = context?.DataRetriever.RetrieveByValueSet<Observation>(m_, null);
				var o_ = (Observation BloodGlucoseLab3) =>
				{
					var a_ = (BloodGlucoseLab3?.StatusElement as object);
					var b_ = (context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(a_);
					var c_ = (b_ as object);
					var d_ = context?.Operators.Equal(c_, ("final" as object));
					var e_ = ((BloodGlucoseLab3?.Effective as object) as FhirDateTime);
					var f_ = FHIRHelpers_4_0_001.ToDateTime(e_);
					var g_ = EncounterDay?.dayPeriod;
					var h_ = context?.Operators.ElementInInterval<CqlDateTime>(f_, g_, null);

					return context?.Operators.And(d_, h_);
				};
				var p_ = context?.Operators.WhereOrNull<Observation>(n_, o_);
				var q_ = context?.Operators.ExistsInList<Observation>(p_);
				var r_ = context?.Operators.Not(q_);

				return new Tuples.Tuple_EPQMNeOgChVRHOcBPRccPNZeF
				{
					dayIndex = a_,
					dayPeriod = b_,
					hasSevereResult = g_,
					hasElevatedResult = l_,
					hasNoResult = r_,
				};
			};
			var e_ = context?.Operators.SelectOrNull<Tuples.Tuple_BZfjDHYASdKbVKTOeigaYPBVf, Tuples.Tuple_EPQMNeOgChVRHOcBPRccPNZeF>(c_, d_);

			return new Tuples.Tuple_GiWKJXbiXAiGGBDVZJdMTaVhK
			{
				encounter = a_,
				relevantPeriod = b_,
				relevantDays = e_,
			};
		};

		return context?.Operators.SelectOrNull<Tuples.Tuple_FdccSJcWTSebijGjABdUMLEdR, Tuples.Tuple_GiWKJXbiXAiGGBDVZJdMTaVhK>(a_, b_);
	}

    [CqlDeclaration("Pertinent Encounters With Glucose Result Days")]
    public IEnumerable<Tuples.Tuple_GiWKJXbiXAiGGBDVZJdMTaVhK> Pertinent_Encounters_With_Glucose_Result_Days() => __Pertinent_Encounters_With_Glucose_Result_Days.Value;

    private IEnumerable<Tuples.Tuple_CAbQjTVRCSKOYWiIhECGMcDPA> Pertinent_Encounters_With_Hyperglycemic_Event_Days_Value()
	{
		var a_ = this.Pertinent_Encounters_With_Glucose_Result_Days();
		var b_ = (Tuples.Tuple_GiWKJXbiXAiGGBDVZJdMTaVhK EncounterWithResultDays) =>
		{
			var a_ = EncounterWithResultDays?.encounter;
			var b_ = EncounterWithResultDays?.relevantPeriod;
			var c_ = EncounterWithResultDays?.relevantDays;
			var d_ = (Tuples.Tuple_EPQMNeOgChVRHOcBPRccPNZeF EncounterDay) =>
			{
				var a_ = (EncounterDay?.dayIndex as object);
				var b_ = ((int?)1 as object);

				return context?.Operators.Greater(a_, b_);
			};
			var e_ = context?.Operators.WhereOrNull<Tuples.Tuple_EPQMNeOgChVRHOcBPRccPNZeF>(c_, d_);
			var f_ = (Tuples.Tuple_EPQMNeOgChVRHOcBPRccPNZeF EncounterDay) =>
			{
				var a_ = EncounterDay?.dayIndex;
				var b_ = EncounterDay?.dayPeriod;
				var c_ = EncounterDay?.hasSevereResult;
				var d_ = EncounterDay?.hasNoResult;
				var e_ = EncounterWithResultDays?.relevantDays;
				var f_ = EncounterDay?.dayIndex;
				var g_ = context?.Operators.Subtract(f_, (int?)2);
				var h_ = context?.Operators.ListElementAt<Tuples.Tuple_EPQMNeOgChVRHOcBPRccPNZeF>(e_, g_);
				var i_ = h_?.hasElevatedResult;
				var j_ = context?.Operators.And(d_, i_);
				var k_ = EncounterWithResultDays?.relevantDays;
				var l_ = EncounterDay?.dayIndex;
				var m_ = context?.Operators.Subtract(l_, (int?)3);
				var n_ = context?.Operators.ListElementAt<Tuples.Tuple_EPQMNeOgChVRHOcBPRccPNZeF>(k_, m_);
				var o_ = n_?.hasElevatedResult;
				var p_ = context?.Operators.And(j_, o_);
				var q_ = context?.Operators.Or(c_, p_);

				return new Tuples.Tuple_HBBaLFUhhUfQBEJKjEZegSRLi
				{
					dayIndex = a_,
					dayPeriod = b_,
					hasHyperglycemicEvent = q_,
				};
			};
			var g_ = context?.Operators.SelectOrNull<Tuples.Tuple_EPQMNeOgChVRHOcBPRccPNZeF, Tuples.Tuple_HBBaLFUhhUfQBEJKjEZegSRLi>(e_, f_);

			return new Tuples.Tuple_CAbQjTVRCSKOYWiIhECGMcDPA
			{
				encounter = a_,
				relevantPeriod = b_,
				eligibleEventDays = g_,
			};
		};

		return context?.Operators.SelectOrNull<Tuples.Tuple_GiWKJXbiXAiGGBDVZJdMTaVhK, Tuples.Tuple_CAbQjTVRCSKOYWiIhECGMcDPA>(a_, b_);
	}

    [CqlDeclaration("Pertinent Encounters With Hyperglycemic Event Days")]
    public IEnumerable<Tuples.Tuple_CAbQjTVRCSKOYWiIhECGMcDPA> Pertinent_Encounters_With_Hyperglycemic_Event_Days() => __Pertinent_Encounters_With_Hyperglycemic_Event_Days.Value;

    private IEnumerable<Encounter> Numerator_Value()
	{
		var a_ = this.Pertinent_Encounters_With_Hyperglycemic_Event_Days();
		var b_ = (Tuples.Tuple_CAbQjTVRCSKOYWiIhECGMcDPA EncounterWithEventDays) =>
		{
			var a_ = EncounterWithEventDays?.eligibleEventDays;
			var b_ = (Tuples.Tuple_HBBaLFUhhUfQBEJKjEZegSRLi EligibleEventDay) => EligibleEventDay?.hasHyperglycemicEvent;
			var c_ = context?.Operators.WhereOrNull<Tuples.Tuple_HBBaLFUhhUfQBEJKjEZegSRLi>(a_, b_);

			return context?.Operators.ExistsInList<Tuples.Tuple_HBBaLFUhhUfQBEJKjEZegSRLi>(c_);
		};
		var c_ = context?.Operators.WhereOrNull<Tuples.Tuple_CAbQjTVRCSKOYWiIhECGMcDPA>(a_, b_);
		var d_ = (Tuples.Tuple_CAbQjTVRCSKOYWiIhECGMcDPA EncounterWithEventDays) => EncounterWithEventDays?.encounter;

		return context?.Operators.SelectOrNull<Tuples.Tuple_CAbQjTVRCSKOYWiIhECGMcDPA, Encounter>(c_, d_);
	}

    [CqlDeclaration("Numerator")]
    public IEnumerable<Encounter> Numerator() => __Numerator.Value;

    [CqlDeclaration("Denominator Observations")]
    public int? Denominator_Observations(Encounter QualifyingEncounter)
	{
		var a_ = this.Pertinent_Encounters_With_Hyperglycemic_Event_Days();
		var b_ = (Tuples.Tuple_CAbQjTVRCSKOYWiIhECGMcDPA EncounterWithEventDays) =>
		{
			var a_ = (EncounterWithEventDays?.encounter as object);

			return context?.Operators.Equal(a_, (QualifyingEncounter as object));
		};
		var c_ = context?.Operators.WhereOrNull<Tuples.Tuple_CAbQjTVRCSKOYWiIhECGMcDPA>(a_, b_);
		var d_ = (Tuples.Tuple_CAbQjTVRCSKOYWiIhECGMcDPA EncounterWithEventDays) =>
		{
			var a_ = EncounterWithEventDays?.eligibleEventDays;

			return context?.Operators.CountOrNull<Tuples.Tuple_HBBaLFUhhUfQBEJKjEZegSRLi>(a_);
		};
		var e_ = context?.Operators.SelectOrNull<Tuples.Tuple_CAbQjTVRCSKOYWiIhECGMcDPA, int?>(c_, d_);

		return context?.Operators.SingleOrNull<int?>(e_);
	}


    [CqlDeclaration("Numerator Observations")]
    public int? Numerator_Observations(Encounter QualifyingEncounter)
	{
		var a_ = this.Pertinent_Encounters_With_Hyperglycemic_Event_Days();
		var b_ = (Tuples.Tuple_CAbQjTVRCSKOYWiIhECGMcDPA EncounterWithEventDays) =>
		{
			var a_ = (EncounterWithEventDays?.encounter as object);

			return context?.Operators.Equal(a_, (QualifyingEncounter as object));
		};
		var c_ = context?.Operators.WhereOrNull<Tuples.Tuple_CAbQjTVRCSKOYWiIhECGMcDPA>(a_, b_);
		var d_ = (Tuples.Tuple_CAbQjTVRCSKOYWiIhECGMcDPA EncounterWithEventDays) =>
		{
			var a_ = EncounterWithEventDays?.eligibleEventDays;
			var b_ = (Tuples.Tuple_HBBaLFUhhUfQBEJKjEZegSRLi EligibleEventDay) => EligibleEventDay?.hasHyperglycemicEvent;
			var c_ = context?.Operators.WhereOrNull<Tuples.Tuple_HBBaLFUhhUfQBEJKjEZegSRLi>(a_, b_);

			return context?.Operators.CountOrNull<Tuples.Tuple_HBBaLFUhhUfQBEJKjEZegSRLi>(c_);
		};
		var e_ = context?.Operators.SelectOrNull<Tuples.Tuple_CAbQjTVRCSKOYWiIhECGMcDPA, int?>(c_, d_);

		return context?.Operators.SingleOrNull<int?>(e_);
	}


}