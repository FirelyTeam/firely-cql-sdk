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

    private CqlValueSet birth_date_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.560.100.4", null);

		return a_;
	}

    [CqlDeclaration("birth date")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.560.100.4")]
    public CqlValueSet birth_date() => __birth_date.Value;

    private CqlValueSet Diabetes_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.103.12.1001", null);

		return a_;
	}

    [CqlDeclaration("Diabetes")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.103.12.1001")]
    public CqlValueSet Diabetes() => __Diabetes.Value;

    private CqlValueSet Encounter_Inpatient_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);

		return a_;
	}

    [CqlDeclaration("Encounter Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307")]
    public CqlValueSet Encounter_Inpatient() => __Encounter_Inpatient.Value;

    private CqlValueSet Glucose_lab_test_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.134", null);

		return a_;
	}

    [CqlDeclaration("Glucose lab test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.134")]
    public CqlValueSet Glucose_lab_test() => __Glucose_lab_test.Value;

    private CqlValueSet Hypoglycemics_Treatment_Medications_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1196.394", null);

		return a_;
	}

    [CqlDeclaration("Hypoglycemics Treatment Medications")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1196.394")]
    public CqlValueSet Hypoglycemics_Treatment_Medications() => __Hypoglycemics_Treatment_Medications.Value;

    private CqlCode Birth_date_Value()
	{
		var a_ = new CqlCode("21112-8", "http://loinc.org", null, null);

		return a_;
	}

    [CqlDeclaration("Birth date")]
    public CqlCode Birth_date() => __Birth_date.Value;

    private CqlCode[] LOINC_Value()
	{
		var a_ = new CqlCode("21112-8", "http://loinc.org", null, null);
		var b_ = new CqlCode[]
		{
			a_,
		};

		return b_;
	}

    [CqlDeclaration("LOINC")]
    public CqlCode[] LOINC() => __LOINC.Value;

    private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		var a_ = context.ResolveParameter("HospitalHarmHyperglycemiainHospitalizedPatientsFHIR-0.0.006", "Measurement Period", null);
		var b_ = (CqlInterval<CqlDateTime>)a_;

		return b_;
	}

    [CqlDeclaration("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period() => __Measurement_Period.Value;

    private Patient Patient_Value()
	{
		var a_ = context.DataRetriever;
		var b_ = a_.RetrieveByValueSet<Patient>(null, null);
		var c_ = context.Operators;
		var d_ = c_.SingleOrNull<Patient>(b_);

		return d_;
	}

    [CqlDeclaration("Patient")]
    public Patient Patient() => __Patient.Value;

    private IEnumerable<Coding> SDE_Ethnicity_Value()
	{
		var a_ = SupplementalDataElementsFHIR4_2_0_000.SDE_Ethnicity();

		return a_;
	}

    [CqlDeclaration("SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity() => __SDE_Ethnicity.Value;

    private IEnumerable<Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG> SDE_Payer_Value()
	{
		var a_ = SupplementalDataElementsFHIR4_2_0_000.SDE_Payer();

		return a_;
	}

    [CqlDeclaration("SDE Payer")]
    public IEnumerable<Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG> SDE_Payer() => __SDE_Payer.Value;

    private IEnumerable<Coding> SDE_Race_Value()
	{
		var a_ = SupplementalDataElementsFHIR4_2_0_000.SDE_Race();

		return a_;
	}

    [CqlDeclaration("SDE Race")]
    public IEnumerable<Coding> SDE_Race() => __SDE_Race.Value;

    private CqlCode SDE_Sex_Value()
	{
		var a_ = SupplementalDataElementsFHIR4_2_0_000.SDE_Sex();

		return a_;
	}

    [CqlDeclaration("SDE Sex")]
    public CqlCode SDE_Sex() => __SDE_Sex.Value;

    private IEnumerable<Encounter> Inpatient_Encounter_During_Measurement_Period_Value()
	{
		var a_ = this.Encounter_Inpatient();
		var b_ = context.DataRetriever;
		var c_ = b_.RetrieveByValueSet<Encounter>(a_, null);

		return c_;
	}

    [CqlDeclaration("Inpatient Encounter During Measurement Period")]
    public IEnumerable<Encounter> Inpatient_Encounter_During_Measurement_Period() => __Inpatient_Encounter_During_Measurement_Period.Value;

    private IEnumerable<Encounter> Qualifying_Encounters_Value()
	{
		var a_ = this.Inpatient_Encounter_During_Measurement_Period();
		var b_ = (Encounter InpatientEncounter) =>
		{
			var e_ = this.Patient();
			var f_ = e_.BirthDateElement;
			var g_ = f_.Value;
			var h_ = context.Operators;
			var i_ = h_.ConvertStringToDateTime(g_);
			var j_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(InpatientEncounter);
			var l_ = h_.Start(j_);
			var n_ = h_.CalculateAgeAt(i_, l_, "year");
			var o_ = n_;
			var p_ = (int?)18;
			var q_ = p_;
			var s_ = h_.GreaterOrEqual(o_, q_);

			return s_;
		};
		var c_ = context.Operators;
		var d_ = c_.WhereOrNull<Encounter>(a_, b_);

		return d_;
	}

    [CqlDeclaration("Qualifying Encounters")]
    public IEnumerable<Encounter> Qualifying_Encounters() => __Qualifying_Encounters.Value;

    private IEnumerable<Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW> Qualifying_Encounters_With_Hospitalization_Period_Value()
	{
		var a_ = this.Qualifying_Encounters();
		var b_ = (Encounter QualifyingEncounter) =>
		{
			var e_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(QualifyingEncounter);
			var f_ = new Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW
			{
				encounter = QualifyingEncounter,
				hospitalizationPeriod = e_,
			};

			return f_;
		};
		var c_ = context.Operators;
		var d_ = c_.SelectOrNull<Encounter, Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW>(a_, b_);

		return d_;
	}

    [CqlDeclaration("Qualifying Encounters With Hospitalization Period")]
    public IEnumerable<Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW> Qualifying_Encounters_With_Hospitalization_Period() => __Qualifying_Encounters_With_Hospitalization_Period.Value;

    private IEnumerable<Encounter> Qualifying_Encounters_With_Existing_Diabetes_Diagnosis_Value()
	{
		var a_ = this.Qualifying_Encounters_With_Hospitalization_Period();
		var b_ = (Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW EncounterWithHospitalization) =>
		{
			var h_ = this.Diabetes();
			var i_ = context.DataRetriever;
			var j_ = i_.RetrieveByValueSet<Condition>(h_, null);
			var k_ = (Condition DiabetesDiagnosis) =>
			{
				var q_ = DiabetesDiagnosis.VerificationStatus;
				var r_ = FHIRHelpers_4_0_001.ToConcept(q_);
				var s_ = MATGlobalCommonFunctionsFHIR4_6_1_000.confirmed();
				var t_ = context.Operators;
				var u_ = t_.ConvertCodeToConcept(s_);
				var w_ = t_.Equivalent(r_, u_);
				var x_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Prevalence_Period(DiabetesDiagnosis);
				var z_ = t_.Start(x_);
				var aa_ = EncounterWithHospitalization.hospitalizationPeriod;
				var ac_ = t_.End(aa_);
				var ae_ = t_.Before(z_, ac_, null);
				var ag_ = t_.And(w_, ae_);

				return ag_;
			};
			var l_ = context.Operators;
			var m_ = l_.WhereOrNull<Condition>(j_, k_);
			var n_ = (Condition DiabetesDiagnosis) => EncounterWithHospitalization;
			var p_ = l_.SelectOrNull<Condition, Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW>(m_, n_);

			return p_;
		};
		var c_ = context.Operators;
		var d_ = c_.SelectManyOrNull<Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW, Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW>(a_, b_);
		var e_ = (Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW EncounterWithHospitalization) =>
		{
			var ah_ = EncounterWithHospitalization.encounter;

			return ah_;
		};
		var g_ = c_.SelectOrNull<Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW, Encounter>(d_, e_);

		return g_;
	}

    [CqlDeclaration("Qualifying Encounters With Existing Diabetes Diagnosis")]
    public IEnumerable<Encounter> Qualifying_Encounters_With_Existing_Diabetes_Diagnosis() => __Qualifying_Encounters_With_Existing_Diabetes_Diagnosis.Value;

    private IEnumerable<Encounter> Qualifying_Encounters_With_Hypoglycemic_Medication_Value()
	{
		var a_ = this.Qualifying_Encounters_With_Hospitalization_Period();
		var b_ = (Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW _EncounterWithHospitalization) =>
		{
			var l_ = this.Hypoglycemics_Treatment_Medications();
			var m_ = context.DataRetriever;
			var n_ = m_.RetrieveByValueSet<MedicationAdministration>(l_, null);
			var q_ = m_.RetrieveByValueSet<MedicationAdministration>(l_, null);
			var r_ = context.Operators;
			var s_ = r_.ListUnion<MedicationAdministration>(n_, q_);

			return s_;
		};
		var c_ = (Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW _EncounterWithHospitalization, MedicationAdministration _HypoglycemicMedication) =>
		{
			var t_ = new Tuples.Tuple_EBCeiDEEJUjLQKCDbhKCQVIHW
			{
				EncounterWithHospitalization = _EncounterWithHospitalization,
				HypoglycemicMedication = _HypoglycemicMedication,
			};

			return t_;
		};
		var d_ = context.Operators;
		var e_ = d_.SelectManyResultsOrNull<Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW, MedicationAdministration, Tuples.Tuple_EBCeiDEEJUjLQKCDbhKCQVIHW>(a_, b_, c_);
		var f_ = (Tuples.Tuple_EBCeiDEEJUjLQKCDbhKCQVIHW tuple_ebceideejujlqkcdbhkcqvihw) =>
		{
			var u_ = tuple_ebceideejujlqkcdbhkcqvihw.HypoglycemicMedication;
			var v_ = u_.StatusElement;
			var w_ = new CallStackEntry("ToString", null, null);
			var x_ = context.Deeper(w_);
			var y_ = x_.Operators;
			var z_ = y_.TypeConverter;
			var aa_ = z_.Convert<string>(v_);
			var ab_ = context.Operators;
			var ac_ = ab_.Equal(aa_, "completed");
			var ad_ = tuple_ebceideejujlqkcdbhkcqvihw.EncounterWithHospitalization;
			var ae_ = ad_.hospitalizationPeriod;
			var ag_ = u_.Effective;
			var ah_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(ag_);
			var aj_ = ab_.IntervalIncludesInterval<CqlDateTime>(ae_, ah_, null);
			var al_ = ab_.And(ac_, aj_);

			return al_;
		};
		var h_ = d_.WhereOrNull<Tuples.Tuple_EBCeiDEEJUjLQKCDbhKCQVIHW>(e_, f_);
		var i_ = (Tuples.Tuple_EBCeiDEEJUjLQKCDbhKCQVIHW tuple_ebceideejujlqkcdbhkcqvihw) =>
		{
			var am_ = tuple_ebceideejujlqkcdbhkcqvihw.EncounterWithHospitalization;
			var an_ = am_.encounter;

			return an_;
		};
		var k_ = d_.SelectOrNull<Tuples.Tuple_EBCeiDEEJUjLQKCDbhKCQVIHW, Encounter>(h_, i_);

		return k_;
	}

    [CqlDeclaration("Qualifying Encounters With Hypoglycemic Medication")]
    public IEnumerable<Encounter> Qualifying_Encounters_With_Hypoglycemic_Medication() => __Qualifying_Encounters_With_Hypoglycemic_Medication.Value;

    private IEnumerable<Encounter> Qualifying_Encounters_With_Elevated_Blood_Glucose_Lab_Value()
	{
		var a_ = this.Qualifying_Encounters_With_Hospitalization_Period();
		var b_ = (Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW EncounterWithHospitalization) =>
		{
			var h_ = this.Glucose_lab_test();
			var i_ = context.DataRetriever;
			var j_ = i_.RetrieveByValueSet<Observation>(h_, null);
			var k_ = (Observation BloodGlucoseLab) =>
			{
				var q_ = BloodGlucoseLab.Effective;
				var r_ = (q_ as FhirDateTime);
				var s_ = FHIRHelpers_4_0_001.ToDateTime(r_);
				var t_ = EncounterWithHospitalization.hospitalizationPeriod;
				var u_ = context.Operators;
				var v_ = u_.ElementInInterval<CqlDateTime>(s_, t_, null);
				var w_ = BloodGlucoseLab.StatusElement;
				var x_ = new CallStackEntry("ToString", null, null);
				var y_ = context.Deeper(x_);
				var z_ = y_.Operators;
				var aa_ = z_.TypeConverter;
				var ab_ = aa_.Convert<string>(w_);
				var ad_ = u_.Equal(ab_, "final");
				var af_ = u_.And(v_, ad_);
				var ag_ = BloodGlucoseLab.Value;
				var ah_ = (ag_ as Quantity);
				var ai_ = FHIRHelpers_4_0_001.ToQuantity(ah_);
				var ak_ = u_.Quantity(200m, "mg/dL");
				var am_ = u_.GreaterOrEqual(ai_, ak_);
				var ao_ = u_.And(af_, am_);

				return ao_;
			};
			var l_ = context.Operators;
			var m_ = l_.WhereOrNull<Observation>(j_, k_);
			var n_ = (Observation BloodGlucoseLab) => EncounterWithHospitalization;
			var p_ = l_.SelectOrNull<Observation, Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW>(m_, n_);

			return p_;
		};
		var c_ = context.Operators;
		var d_ = c_.SelectManyOrNull<Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW, Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW>(a_, b_);
		var e_ = (Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW EncounterWithHospitalization) =>
		{
			var ap_ = EncounterWithHospitalization.encounter;

			return ap_;
		};
		var g_ = c_.SelectOrNull<Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW, Encounter>(d_, e_);

		return g_;
	}

    [CqlDeclaration("Qualifying Encounters With Elevated Blood Glucose Lab")]
    public IEnumerable<Encounter> Qualifying_Encounters_With_Elevated_Blood_Glucose_Lab() => __Qualifying_Encounters_With_Elevated_Blood_Glucose_Lab.Value;

    private IEnumerable<Encounter> Initial_Population_Value()
	{
		var a_ = this.Qualifying_Encounters_With_Existing_Diabetes_Diagnosis();
		var b_ = this.Qualifying_Encounters_With_Hypoglycemic_Medication();
		var c_ = context.Operators;
		var d_ = c_.ListUnion<Encounter>(a_, b_);
		var e_ = this.Qualifying_Encounters_With_Elevated_Blood_Glucose_Lab();
		var g_ = c_.ListUnion<Encounter>(d_, e_);

		return g_;
	}

    [CqlDeclaration("Initial Population")]
    public IEnumerable<Encounter> Initial_Population() => __Initial_Population.Value;

    private IEnumerable<Encounter> Denominator_Value()
	{
		var a_ = this.Initial_Population();

		return a_;
	}

    [CqlDeclaration("Denominator")]
    public IEnumerable<Encounter> Denominator() => __Denominator.Value;

    [CqlDeclaration("Crop Interval to 10 Days")]
    public CqlInterval<CqlDateTime> Crop_Interval_to_10_Days(CqlInterval<CqlDateTime> Period)
	{
		var a_ = context.Operators;
		var b_ = a_.Start(Period);
		var d_ = a_.End(Period);
		var f_ = a_.Start(Period);
		var h_ = a_.Quantity(10m, "days");
		var j_ = a_.Add(f_, h_);
		var k_ = new CqlDateTime[]
		{
			d_,
			j_,
		};
		var l_ = (k_ as IEnumerable<CqlDateTime>);
		var n_ = a_.MinOrNull<CqlDateTime>(l_);
		var p_ = a_.Interval(b_, n_, true, true);

		return p_;
	}


    [CqlDeclaration("Interval To Day Numbers")]
    public IEnumerable<int?> Interval_To_Day_Numbers(CqlInterval<CqlDateTime> Period)
	{
		var a_ = (int?)1;
		var b_ = context.Operators;
		var c_ = b_.Start(Period);
		var e_ = b_.End(Period);
		var g_ = b_.DurationBetween(c_, e_, "day");
		var i_ = b_.Interval(a_, g_, true, true);
		var j_ = new CqlInterval<int?>[]
		{
			i_,
		};
		var k_ = (j_ as IEnumerable<CqlInterval<int?>>);
		var m_ = b_.ExpandList(k_, null);
		var n_ = (CqlInterval<int?> DayExpand) =>
		{
			var q_ = context.Operators;
			var r_ = q_.End(DayExpand);

			return r_;
		};
		var p_ = b_.SelectOrNull<CqlInterval<int?>, int?>(m_, n_);

		return p_;
	}


    [CqlDeclaration("Days In Period")]
    public IEnumerable<Tuples.Tuple_BZfjDHYASdKbVKTOeigaYPBVf> Days_In_Period(CqlInterval<CqlDateTime> Period)
	{
		var a_ = this.Interval_To_Day_Numbers(Period);
		var b_ = (int? DayIndex) =>
		{
			var e_ = context.Operators;
			var f_ = e_.Start(Period);
			var h_ = e_.Quantity(24m, "hours");
			var i_ = (int?)1;
			var k_ = e_.Subtract(DayIndex, i_);
			var m_ = e_.ConvertIntegerToQuantity(k_);
			var o_ = e_.Multiply(h_, m_);
			var q_ = e_.Add(f_, o_);
			var s_ = e_.Interval(q_, (((context.Operators.Less(context.Operators.DurationBetween(context.Operators.Add(context.Operators.Start(Period), context.Operators.Multiply(context.Operators.Quantity(24m, "hours"), context.Operators.ConvertIntegerToQuantity(context.Operators.Subtract(DayIndex, (int?)1)))), context.Operators.End(Period), "hour"), (int?)24) ?? false))
					? (context.Operators.Add(context.Operators.Start(Period), context.Operators.Multiply(context.Operators.Quantity(24m, "hours"), context.Operators.ConvertIntegerToQuantity(context.Operators.Subtract(DayIndex, (int?)1)))))
					: (context.Operators.Add(context.Operators.Start(Period), context.Operators.Multiply(context.Operators.Quantity(24m, "hours"), context.Operators.ConvertIntegerToQuantity(DayIndex)))))
, true, false);
			var t_ = new Tuples.Tuple_BZfjDHYASdKbVKTOeigaYPBVf
			{
				dayIndex = DayIndex,
				dayPeriod = s_,
			};

			return t_;
		};
		var c_ = context.Operators;
		var d_ = c_.SelectOrNull<int?, Tuples.Tuple_BZfjDHYASdKbVKTOeigaYPBVf>(a_, b_);

		return d_;
	}


    private IEnumerable<Tuples.Tuple_FdccSJcWTSebijGjABdUMLEdR> Pertinent_Encounters_With_Days_Value()
	{
		var a_ = this.Initial_Population();
		var b_ = (Encounter PertinentEncounter) =>
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
		var c_ = context.Operators;
		var d_ = c_.SelectOrNull<Encounter, Tuples.Tuple_FdccSJcWTSebijGjABdUMLEdR>(a_, b_);

		return d_;
	}

    [CqlDeclaration("Pertinent Encounters With Days")]
    public IEnumerable<Tuples.Tuple_FdccSJcWTSebijGjABdUMLEdR> Pertinent_Encounters_With_Days() => __Pertinent_Encounters_With_Days.Value;

    private IEnumerable<Tuples.Tuple_GiWKJXbiXAiGGBDVZJdMTaVhK> Pertinent_Encounters_With_Glucose_Result_Days_Value()
	{
		var a_ = this.Pertinent_Encounters_With_Days();
		var b_ = (Tuples.Tuple_FdccSJcWTSebijGjABdUMLEdR PertinentEncounterDays) =>
		{
			var e_ = PertinentEncounterDays.encounter;
			var f_ = PertinentEncounterDays.relevantPeriod;
			var g_ = PertinentEncounterDays.relevantDays;
			var h_ = (Tuples.Tuple_BZfjDHYASdKbVKTOeigaYPBVf EncounterDay) =>
			{
				var l_ = EncounterDay.dayIndex;
				var m_ = EncounterDay.dayPeriod;
				var n_ = this.Glucose_lab_test();
				var o_ = context.DataRetriever;
				var p_ = o_.RetrieveByValueSet<Observation>(n_, null);
				var q_ = (Observation BloodGlucoseLab1) =>
				{
					var ao_ = BloodGlucoseLab1.StatusElement;
					var ap_ = new CallStackEntry("ToString", null, null);
					var aq_ = context.Deeper(ap_);
					var ar_ = aq_.Operators;
					var as_ = ar_.TypeConverter;
					var at_ = as_.Convert<string>(ao_);
					var au_ = context.Operators;
					var av_ = au_.Equal(at_, "final");
					var aw_ = BloodGlucoseLab1.Value;
					var ax_ = (aw_ as Quantity);
					var ay_ = FHIRHelpers_4_0_001.ToQuantity(ax_);
					var ba_ = au_.Quantity(300m, "mg/dL");
					var bc_ = au_.Greater(ay_, ba_);
					var be_ = au_.And(av_, bc_);
					var bf_ = BloodGlucoseLab1.Effective;
					var bg_ = (bf_ as FhirDateTime);
					var bh_ = FHIRHelpers_4_0_001.ToDateTime(bg_);
					var bi_ = EncounterDay.dayPeriod;
					var bk_ = au_.ElementInInterval<CqlDateTime>(bh_, bi_, null);
					var bm_ = au_.And(be_, bk_);

					return bm_;
				};
				var r_ = context.Operators;
				var s_ = r_.WhereOrNull<Observation>(p_, q_);
				var u_ = r_.ExistsInList<Observation>(s_);
				var x_ = o_.RetrieveByValueSet<Observation>(n_, null);
				var y_ = (Observation BloodGlucoseLab2) =>
				{
					var bn_ = BloodGlucoseLab2.StatusElement;
					var bo_ = new CallStackEntry("ToString", null, null);
					var bp_ = context.Deeper(bo_);
					var bq_ = bp_.Operators;
					var br_ = bq_.TypeConverter;
					var bs_ = br_.Convert<string>(bn_);
					var bt_ = context.Operators;
					var bu_ = bt_.Equal(bs_, "final");
					var bv_ = BloodGlucoseLab2.Value;
					var bw_ = (bv_ as Quantity);
					var bx_ = FHIRHelpers_4_0_001.ToQuantity(bw_);
					var bz_ = bt_.Quantity(200m, "mg/dL");
					var cb_ = bt_.GreaterOrEqual(bx_, bz_);
					var cd_ = bt_.And(bu_, cb_);
					var ce_ = BloodGlucoseLab2.Effective;
					var cf_ = (ce_ as FhirDateTime);
					var cg_ = FHIRHelpers_4_0_001.ToDateTime(cf_);
					var ch_ = EncounterDay.dayPeriod;
					var cj_ = bt_.ElementInInterval<CqlDateTime>(cg_, ch_, null);
					var cl_ = bt_.And(cd_, cj_);

					return cl_;
				};
				var aa_ = r_.WhereOrNull<Observation>(x_, y_);
				var ac_ = r_.ExistsInList<Observation>(aa_);
				var af_ = o_.RetrieveByValueSet<Observation>(n_, null);
				var ag_ = (Observation BloodGlucoseLab3) =>
				{
					var cm_ = BloodGlucoseLab3.StatusElement;
					var cn_ = new CallStackEntry("ToString", null, null);
					var co_ = context.Deeper(cn_);
					var cp_ = co_.Operators;
					var cq_ = cp_.TypeConverter;
					var cr_ = cq_.Convert<string>(cm_);
					var cs_ = context.Operators;
					var ct_ = cs_.Equal(cr_, "final");
					var cu_ = BloodGlucoseLab3.Effective;
					var cv_ = (cu_ as FhirDateTime);
					var cw_ = FHIRHelpers_4_0_001.ToDateTime(cv_);
					var cx_ = EncounterDay.dayPeriod;
					var cz_ = cs_.ElementInInterval<CqlDateTime>(cw_, cx_, null);
					var db_ = cs_.And(ct_, cz_);

					return db_;
				};
				var ai_ = r_.WhereOrNull<Observation>(af_, ag_);
				var ak_ = r_.ExistsInList<Observation>(ai_);
				var am_ = r_.Not(ak_);
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
			var i_ = context.Operators;
			var j_ = i_.SelectOrNull<Tuples.Tuple_BZfjDHYASdKbVKTOeigaYPBVf, Tuples.Tuple_EPQMNeOgChVRHOcBPRccPNZeF>(g_, h_);
			var k_ = new Tuples.Tuple_GiWKJXbiXAiGGBDVZJdMTaVhK
			{
				encounter = e_,
				relevantPeriod = f_,
				relevantDays = j_,
			};

			return k_;
		};
		var c_ = context.Operators;
		var d_ = c_.SelectOrNull<Tuples.Tuple_FdccSJcWTSebijGjABdUMLEdR, Tuples.Tuple_GiWKJXbiXAiGGBDVZJdMTaVhK>(a_, b_);

		return d_;
	}

    [CqlDeclaration("Pertinent Encounters With Glucose Result Days")]
    public IEnumerable<Tuples.Tuple_GiWKJXbiXAiGGBDVZJdMTaVhK> Pertinent_Encounters_With_Glucose_Result_Days() => __Pertinent_Encounters_With_Glucose_Result_Days.Value;

    private IEnumerable<Tuples.Tuple_CAbQjTVRCSKOYWiIhECGMcDPA> Pertinent_Encounters_With_Hyperglycemic_Event_Days_Value()
	{
		var a_ = this.Pertinent_Encounters_With_Glucose_Result_Days();
		var b_ = (Tuples.Tuple_GiWKJXbiXAiGGBDVZJdMTaVhK EncounterWithResultDays) =>
		{
			var e_ = EncounterWithResultDays.encounter;
			var f_ = EncounterWithResultDays.relevantPeriod;
			var g_ = EncounterWithResultDays.relevantDays;
			var h_ = (Tuples.Tuple_EPQMNeOgChVRHOcBPRccPNZeF EncounterDay) =>
			{
				var o_ = EncounterDay.dayIndex;
				var p_ = o_;
				var q_ = (int?)1;
				var r_ = q_;
				var s_ = context.Operators;
				var t_ = s_.Greater(p_, r_);

				return t_;
			};
			var i_ = context.Operators;
			var j_ = i_.WhereOrNull<Tuples.Tuple_EPQMNeOgChVRHOcBPRccPNZeF>(g_, h_);
			var k_ = (Tuples.Tuple_EPQMNeOgChVRHOcBPRccPNZeF EncounterDay) =>
			{
				var u_ = EncounterDay.dayIndex;
				var v_ = EncounterDay.dayPeriod;
				var w_ = EncounterDay.hasSevereResult;
				var x_ = EncounterDay.hasNoResult;
				var y_ = EncounterWithResultDays.relevantDays;
				var aa_ = (int?)2;
				var ab_ = context.Operators;
				var ac_ = ab_.Subtract(u_, aa_);
				var ae_ = ab_.ListElementAt<Tuples.Tuple_EPQMNeOgChVRHOcBPRccPNZeF>(y_, ac_);
				var af_ = ae_.hasElevatedResult;
				var ah_ = ab_.And(x_, af_);
				var ak_ = (int?)3;
				var am_ = ab_.Subtract(u_, ak_);
				var ao_ = ab_.ListElementAt<Tuples.Tuple_EPQMNeOgChVRHOcBPRccPNZeF>(y_, am_);
				var ap_ = ao_.hasElevatedResult;
				var ar_ = ab_.And(ah_, ap_);
				var at_ = ab_.Or(w_, ar_);
				var au_ = new Tuples.Tuple_HBBaLFUhhUfQBEJKjEZegSRLi
				{
					dayIndex = u_,
					dayPeriod = v_,
					hasHyperglycemicEvent = at_,
				};

				return au_;
			};
			var m_ = i_.SelectOrNull<Tuples.Tuple_EPQMNeOgChVRHOcBPRccPNZeF, Tuples.Tuple_HBBaLFUhhUfQBEJKjEZegSRLi>(j_, k_);
			var n_ = new Tuples.Tuple_CAbQjTVRCSKOYWiIhECGMcDPA
			{
				encounter = e_,
				relevantPeriod = f_,
				eligibleEventDays = m_,
			};

			return n_;
		};
		var c_ = context.Operators;
		var d_ = c_.SelectOrNull<Tuples.Tuple_GiWKJXbiXAiGGBDVZJdMTaVhK, Tuples.Tuple_CAbQjTVRCSKOYWiIhECGMcDPA>(a_, b_);

		return d_;
	}

    [CqlDeclaration("Pertinent Encounters With Hyperglycemic Event Days")]
    public IEnumerable<Tuples.Tuple_CAbQjTVRCSKOYWiIhECGMcDPA> Pertinent_Encounters_With_Hyperglycemic_Event_Days() => __Pertinent_Encounters_With_Hyperglycemic_Event_Days.Value;

    private IEnumerable<Encounter> Numerator_Value()
	{
		var a_ = this.Pertinent_Encounters_With_Hyperglycemic_Event_Days();
		var b_ = (Tuples.Tuple_CAbQjTVRCSKOYWiIhECGMcDPA EncounterWithEventDays) =>
		{
			var h_ = EncounterWithEventDays.eligibleEventDays;
			var i_ = (Tuples.Tuple_HBBaLFUhhUfQBEJKjEZegSRLi EligibleEventDay) =>
			{
				var n_ = EligibleEventDay.hasHyperglycemicEvent;

				return n_;
			};
			var j_ = context.Operators;
			var k_ = j_.WhereOrNull<Tuples.Tuple_HBBaLFUhhUfQBEJKjEZegSRLi>(h_, i_);
			var m_ = j_.ExistsInList<Tuples.Tuple_HBBaLFUhhUfQBEJKjEZegSRLi>(k_);

			return m_;
		};
		var c_ = context.Operators;
		var d_ = c_.WhereOrNull<Tuples.Tuple_CAbQjTVRCSKOYWiIhECGMcDPA>(a_, b_);
		var e_ = (Tuples.Tuple_CAbQjTVRCSKOYWiIhECGMcDPA EncounterWithEventDays) =>
		{
			var o_ = EncounterWithEventDays.encounter;

			return o_;
		};
		var g_ = c_.SelectOrNull<Tuples.Tuple_CAbQjTVRCSKOYWiIhECGMcDPA, Encounter>(d_, e_);

		return g_;
	}

    [CqlDeclaration("Numerator")]
    public IEnumerable<Encounter> Numerator() => __Numerator.Value;

    [CqlDeclaration("Denominator Observations")]
    public int? Denominator_Observations(Encounter QualifyingEncounter)
	{
		var a_ = this.Pertinent_Encounters_With_Hyperglycemic_Event_Days();
		var b_ = (Tuples.Tuple_CAbQjTVRCSKOYWiIhECGMcDPA EncounterWithEventDays) =>
		{
			var j_ = EncounterWithEventDays.encounter;
			var k_ = context.Operators;
			var l_ = k_.Equal(j_, QualifyingEncounter);

			return l_;
		};
		var c_ = context.Operators;
		var d_ = c_.WhereOrNull<Tuples.Tuple_CAbQjTVRCSKOYWiIhECGMcDPA>(a_, b_);
		var e_ = (Tuples.Tuple_CAbQjTVRCSKOYWiIhECGMcDPA EncounterWithEventDays) =>
		{
			var m_ = EncounterWithEventDays.eligibleEventDays;
			var n_ = context.Operators;
			var o_ = n_.CountOrNull<Tuples.Tuple_HBBaLFUhhUfQBEJKjEZegSRLi>(m_);

			return o_;
		};
		var g_ = c_.SelectOrNull<Tuples.Tuple_CAbQjTVRCSKOYWiIhECGMcDPA, int?>(d_, e_);
		var i_ = c_.SingleOrNull<int?>(g_);

		return i_;
	}


    [CqlDeclaration("Numerator Observations")]
    public int? Numerator_Observations(Encounter QualifyingEncounter)
	{
		var a_ = this.Pertinent_Encounters_With_Hyperglycemic_Event_Days();
		var b_ = (Tuples.Tuple_CAbQjTVRCSKOYWiIhECGMcDPA EncounterWithEventDays) =>
		{
			var j_ = EncounterWithEventDays.encounter;
			var k_ = context.Operators;
			var l_ = k_.Equal(j_, QualifyingEncounter);

			return l_;
		};
		var c_ = context.Operators;
		var d_ = c_.WhereOrNull<Tuples.Tuple_CAbQjTVRCSKOYWiIhECGMcDPA>(a_, b_);
		var e_ = (Tuples.Tuple_CAbQjTVRCSKOYWiIhECGMcDPA EncounterWithEventDays) =>
		{
			var m_ = EncounterWithEventDays.eligibleEventDays;
			var n_ = (Tuples.Tuple_HBBaLFUhhUfQBEJKjEZegSRLi EligibleEventDay) =>
			{
				var s_ = EligibleEventDay.hasHyperglycemicEvent;

				return s_;
			};
			var o_ = context.Operators;
			var p_ = o_.WhereOrNull<Tuples.Tuple_HBBaLFUhhUfQBEJKjEZegSRLi>(m_, n_);
			var r_ = o_.CountOrNull<Tuples.Tuple_HBBaLFUhhUfQBEJKjEZegSRLi>(p_);

			return r_;
		};
		var g_ = c_.SelectOrNull<Tuples.Tuple_CAbQjTVRCSKOYWiIhECGMcDPA, int?>(d_, e_);
		var i_ = c_.SingleOrNull<int?>(g_);

		return i_;
	}


}