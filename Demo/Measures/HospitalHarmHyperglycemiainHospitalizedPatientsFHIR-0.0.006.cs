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
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.560.100.4", 
			null);
    }

    [CqlDeclaration("birth date")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.560.100.4")]
    public CqlValueSet birth_date() => __birth_date.Value;

    private CqlValueSet Diabetes_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.103.12.1001", 
			null);
    }

    [CqlDeclaration("Diabetes")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.103.12.1001")]
    public CqlValueSet Diabetes() => __Diabetes.Value;

    private CqlValueSet Encounter_Inpatient_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", 
			null);
    }

    [CqlDeclaration("Encounter Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307")]
    public CqlValueSet Encounter_Inpatient() => __Encounter_Inpatient.Value;

    private CqlValueSet Glucose_lab_test_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.134", 
			null);
    }

    [CqlDeclaration("Glucose lab test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.134")]
    public CqlValueSet Glucose_lab_test() => __Glucose_lab_test.Value;

    private CqlValueSet Hypoglycemics_Treatment_Medications_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1196.394", 
			null);
    }

    [CqlDeclaration("Hypoglycemics Treatment Medications")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1196.394")]
    public CqlValueSet Hypoglycemics_Treatment_Medications() => __Hypoglycemics_Treatment_Medications.Value;

    private CqlCode Birth_date_Value()
    {
        return new CqlCode("21112-8", 
			"http://loinc.org", 
			null, 
			null);
    }

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

    private CqlInterval<CqlDateTime> Measurement_Period_Value()
    {
        return ((CqlInterval<CqlDateTime>)context.ResolveParameter("HospitalHarmHyperglycemiainHospitalizedPatientsFHIR-0.0.006", 
			"Measurement Period", 
			null));
    }

    [CqlDeclaration("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period() => __Measurement_Period.Value;

    private Patient Patient_Value()
    {
        var a_ = context?.DataRetriever.RetrieveByValueSet<Patient>(null, 
			null);
        return context?.Operators.SingleOrNull<Patient>(a_);
    }
    [CqlDeclaration("Patient")]
    public Patient Patient() => __Patient.Value;

    private IEnumerable<Coding> SDE_Ethnicity_Value()
    {
        return SupplementalDataElementsFHIR4_2_0_000.SDE_Ethnicity();
    }
    [CqlDeclaration("SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity() => __SDE_Ethnicity.Value;

    private IEnumerable<Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG> SDE_Payer_Value()
    {
        return SupplementalDataElementsFHIR4_2_0_000.SDE_Payer();
    }
    [CqlDeclaration("SDE Payer")]
    public IEnumerable<Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG> SDE_Payer() => __SDE_Payer.Value;

    private IEnumerable<Coding> SDE_Race_Value()
    {
        return SupplementalDataElementsFHIR4_2_0_000.SDE_Race();
    }
    [CqlDeclaration("SDE Race")]
    public IEnumerable<Coding> SDE_Race() => __SDE_Race.Value;

    private CqlCode SDE_Sex_Value()
    {
        return SupplementalDataElementsFHIR4_2_0_000.SDE_Sex();
    }
    [CqlDeclaration("SDE Sex")]
    public CqlCode SDE_Sex() => __SDE_Sex.Value;

    private IEnumerable<Encounter> Inpatient_Encounter_During_Measurement_Period_Value()
    {
        var a_ = this.Encounter_Inpatient();
        var b_ = typeof(Encounter).GetProperty("Type");
        return context?.DataRetriever.RetrieveByValueSet<Encounter>(a_, 
			b_);
    }
    [CqlDeclaration("Inpatient Encounter During Measurement Period")]
    public IEnumerable<Encounter> Inpatient_Encounter_During_Measurement_Period() => __Inpatient_Encounter_During_Measurement_Period.Value;

    private IEnumerable<Encounter> Qualifying_Encounters_Value()
    {
        var a_ = this.Inpatient_Encounter_During_Measurement_Period();
        Func<Encounter,bool?> h_ = (InpatientEncounter) => 
        {
            var c_ = this.Patient()?.BirthDateElement?.Value;
            var d_ = context?.Operators.ConvertStringToDateTime(c_);
            var e_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(InpatientEncounter);
            var f_ = context?.Operators.Start(e_);
            var b_ = (context?.Operators.CalculateAgeAt(d_, 
				f_, 
				"year") as object);
            var g_ = (((int?)18) as object);
            return context?.Operators.GreaterOrEqual(b_, 
				g_);
        };
        return context?.Operators.WhereOrNull<Encounter>(a_, 
			h_);
    }
    [CqlDeclaration("Qualifying Encounters")]
    public IEnumerable<Encounter> Qualifying_Encounters() => __Qualifying_Encounters.Value;

    private IEnumerable<Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW> Qualifying_Encounters_With_Hospitalization_Period_Value()
    {
        var a_ = this.Qualifying_Encounters();
        Func<Encounter,Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW> d_ = (QualifyingEncounter) => 
        {
            var b_ = QualifyingEncounter;
            var c_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(QualifyingEncounter);
            return new Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW
			{
				encounter = b_,
				hospitalizationPeriod = c_,
			};
        };
        return context?.Operators.SelectOrNull<Encounter, Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW>(a_, 
			d_);
    }
    [CqlDeclaration("Qualifying Encounters With Hospitalization Period")]
    public IEnumerable<Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW> Qualifying_Encounters_With_Hospitalization_Period() => __Qualifying_Encounters_With_Hospitalization_Period.Value;

    private IEnumerable<Encounter> Qualifying_Encounters_With_Existing_Diabetes_Diagnosis_Value()
    {
        var a_ = this.Qualifying_Encounters_With_Hospitalization_Period();
        Func<Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW,IEnumerable<Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW>> r_ = (EncounterWithHospitalization) => 
        {
            var b_ = this.Diabetes();
            var c_ = typeof(Condition).GetProperty("Code");
            var d_ = context?.DataRetriever.RetrieveByValueSet<Condition>(b_, 
				c_);
            Func<Condition,bool?> o_ = (DiabetesDiagnosis) => 
            {
                var f_ = DiabetesDiagnosis?.VerificationStatus;
                var e_ = (FHIRHelpers_4_0_001.ToConcept(f_) as object);
                var h_ = MATGlobalCommonFunctionsFHIR4_6_1_000.confirmed();
                var g_ = (context?.Operators.ConvertCodeToConcept(h_) as object);
                var i_ = context?.Operators.Equivalent(e_, 
					g_);
                var k_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Prevalence_Period(DiabetesDiagnosis);
                var j_ = (context?.Operators.Start(k_) as object);
                var m_ = EncounterWithHospitalization?.hospitalizationPeriod;
                var l_ = (context?.Operators.End(m_) as object);
                var n_ = context?.Operators.Before(j_, 
					l_, 
					null);
                return context?.Operators.And(i_, 
					n_);
            };
            var p_ = context?.Operators.WhereOrNull<Condition>(d_, 
				o_);
            Func<Condition,Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW> q_ = (DiabetesDiagnosis) => EncounterWithHospitalization;
            return context?.Operators.SelectOrNull<Condition, Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW>(p_, 
				q_);
        };
        var s_ = context?.Operators.SelectManyOrNull<Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW, Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW>(a_, 
			r_);
        Func<Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW,Encounter> t_ = (EncounterWithHospitalization) => 
        {
            return EncounterWithHospitalization?.encounter;
        };
        return context?.Operators.SelectOrNull<Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW, Encounter>(s_, 
			t_);
    }
    [CqlDeclaration("Qualifying Encounters With Existing Diabetes Diagnosis")]
    public IEnumerable<Encounter> Qualifying_Encounters_With_Existing_Diabetes_Diagnosis() => __Qualifying_Encounters_With_Existing_Diabetes_Diagnosis.Value;

    private IEnumerable<Encounter> Qualifying_Encounters_With_Hypoglycemic_Medication_Value()
    {
        var a_ = this.Qualifying_Encounters_With_Hospitalization_Period();
        Func<Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW,IEnumerable<MedicationAdministration>> h_ = (_EncounterWithHospitalization) => 
        {
            var b_ = this.Hypoglycemics_Treatment_Medications();
            var c_ = typeof(MedicationAdministration).GetProperty("Medication");
            var d_ = context?.DataRetriever.RetrieveByValueSet<MedicationAdministration>(b_, 
				c_);
            return context?.Operators.ListUnion<MedicationAdministration>(d_, 
				d_);
        };
        Func<Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW,MedicationAdministration,Tuples.Tuple_EBCeiDEEJUjLQKCDbhKCQVIHW> k_ = (_EncounterWithHospitalization, _HypoglycemicMedication) => 
        {
            var i_ = _EncounterWithHospitalization;
            var j_ = _HypoglycemicMedication;
            return new Tuples.Tuple_EBCeiDEEJUjLQKCDbhKCQVIHW
			{
				EncounterWithHospitalization = i_,
				HypoglycemicMedication = j_,
			};
        };
        var l_ = context?.Operators.SelectManyResultsOrNull<Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW, MedicationAdministration, Tuples.Tuple_EBCeiDEEJUjLQKCDbhKCQVIHW>(a_, 
			h_, 
			k_);
        Func<Tuples.Tuple_EBCeiDEEJUjLQKCDbhKCQVIHW,bool?> u_ = (tuple_ebceideejujlqkcdbhkcqvihw) => 
        {
            var n_ = (tuple_ebceideejujlqkcdbhkcqvihw?.HypoglycemicMedication?.StatusElement as object);
            var m_ = ((context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(n_) as object);
            var o_ = ("completed" as object);
            var p_ = context?.Operators.Equal(m_, 
				o_);
            var q_ = tuple_ebceideejujlqkcdbhkcqvihw?.EncounterWithHospitalization?.hospitalizationPeriod;
            var r_ = (tuple_ebceideejujlqkcdbhkcqvihw?.HypoglycemicMedication?.Effective as object);
            var s_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(r_);
            var t_ = context?.Operators.IntervalIncludesInterval<CqlDateTime>(q_, 
				s_, 
				null);
            return context?.Operators.And(p_, 
				t_);
        };
        var v_ = context?.Operators.WhereOrNull<Tuples.Tuple_EBCeiDEEJUjLQKCDbhKCQVIHW>(l_, 
			u_);
        Func<Tuples.Tuple_EBCeiDEEJUjLQKCDbhKCQVIHW,Encounter> w_ = (tuple_ebceideejujlqkcdbhkcqvihw) => 
        {
            return tuple_ebceideejujlqkcdbhkcqvihw?.EncounterWithHospitalization?.encounter;
        };
        return context?.Operators.SelectOrNull<Tuples.Tuple_EBCeiDEEJUjLQKCDbhKCQVIHW, Encounter>(v_, 
			w_);
    }
    [CqlDeclaration("Qualifying Encounters With Hypoglycemic Medication")]
    public IEnumerable<Encounter> Qualifying_Encounters_With_Hypoglycemic_Medication() => __Qualifying_Encounters_With_Hypoglycemic_Medication.Value;

    private IEnumerable<Encounter> Qualifying_Encounters_With_Elevated_Blood_Glucose_Lab_Value()
    {
        var a_ = this.Qualifying_Encounters_With_Hospitalization_Period();
        Func<Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW,IEnumerable<Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW>> u_ = (EncounterWithHospitalization) => 
        {
            var b_ = this.Glucose_lab_test();
            var c_ = typeof(Observation).GetProperty("Code");
            var d_ = context?.DataRetriever.RetrieveByValueSet<Observation>(b_, 
				c_);
            Func<Observation,bool?> r_ = (BloodGlucoseLab) => 
            {
                var e_ = ((BloodGlucoseLab?.Effective as object) as FhirDateTime);
                var f_ = FHIRHelpers_4_0_001.ToDateTime(e_);
                var g_ = EncounterWithHospitalization?.hospitalizationPeriod;
                var h_ = context?.Operators.ElementInInterval<CqlDateTime>(f_, 
					g_, 
					null);
                var j_ = (BloodGlucoseLab?.StatusElement as object);
                var i_ = ((context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(j_) as object);
                var k_ = ("final" as object);
                var l_ = context?.Operators.Equal(i_, 
					k_);
                var m_ = context?.Operators.And(h_, 
					l_);
                var o_ = ((BloodGlucoseLab?.Value as object) as Quantity);
                var n_ = (FHIRHelpers_4_0_001.ToQuantity(o_) as object);
                var p_ = (context?.Operators.Quantity(200m, 
					"mg/dL") as object);
                var q_ = context?.Operators.GreaterOrEqual(n_, 
					p_);
                return context?.Operators.And(m_, 
					q_);
            };
            var s_ = context?.Operators.WhereOrNull<Observation>(d_, 
				r_);
            Func<Observation,Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW> t_ = (BloodGlucoseLab) => EncounterWithHospitalization;
            return context?.Operators.SelectOrNull<Observation, Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW>(s_, 
				t_);
        };
        var v_ = context?.Operators.SelectManyOrNull<Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW, Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW>(a_, 
			u_);
        Func<Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW,Encounter> w_ = (EncounterWithHospitalization) => 
        {
            return EncounterWithHospitalization?.encounter;
        };
        return context?.Operators.SelectOrNull<Tuples.Tuple_CXAFdKaHNVUHbTOBaaLVHDiaW, Encounter>(v_, 
			w_);
    }
    [CqlDeclaration("Qualifying Encounters With Elevated Blood Glucose Lab")]
    public IEnumerable<Encounter> Qualifying_Encounters_With_Elevated_Blood_Glucose_Lab() => __Qualifying_Encounters_With_Elevated_Blood_Glucose_Lab.Value;

    private IEnumerable<Encounter> Initial_Population_Value()
    {
        var a_ = this.Qualifying_Encounters_With_Existing_Diabetes_Diagnosis();
        var b_ = this.Qualifying_Encounters_With_Hypoglycemic_Medication();
        var c_ = context?.Operators.ListUnion<Encounter>(a_, 
			b_);
        var d_ = this.Qualifying_Encounters_With_Elevated_Blood_Glucose_Lab();
        return context?.Operators.ListUnion<Encounter>(c_, 
			d_);
    }
    [CqlDeclaration("Initial Population")]
    public IEnumerable<Encounter> Initial_Population() => __Initial_Population.Value;

    private IEnumerable<Encounter> Denominator_Value()
    {
        return this.Initial_Population();
    }
    [CqlDeclaration("Denominator")]
    public IEnumerable<Encounter> Denominator() => __Denominator.Value;

    [CqlDeclaration("Crop Interval to 10 Days")]
    public CqlInterval<CqlDateTime> Crop_Interval_to_10_Days(CqlInterval<CqlDateTime> Period)
    {
        var a_ = context?.Operators.Start(Period);
        var c_ = context?.Operators.End(Period);
        var f_ = context?.Operators.Quantity(10m, 
			"days");
        var d_ = context?.Operators.Add(a_, 
			f_);
        var b_ = (new CqlDateTime[]
		{
			c_,
			d_,
		} as IEnumerable<CqlDateTime>);
        var g_ = context?.Operators.MinOrNull<CqlDateTime>(b_);
        return context?.Operators.Interval(a_, 
			g_, 
			true, 
			true);
    }

    [CqlDeclaration("Interval To Day Numbers")]
    public IEnumerable<int?> Interval_To_Day_Numbers(CqlInterval<CqlDateTime> Period)
    {
        var c_ = context?.Operators.Start(Period);
        var d_ = context?.Operators.End(Period);
        var e_ = context?.Operators.DurationBetween(c_, 
			d_, 
			"day");
        var b_ = context?.Operators.Interval(((int?)1), 
			e_, 
			true, 
			true);
        var a_ = (new CqlInterval<int?>[]
		{
			b_,
		} as IEnumerable<CqlInterval<int?>>);
        var f_ = context?.Operators.ExpandList(a_, 
			null);
        Func<CqlInterval<int?>,int?> g_ = (DayExpand) => 
        {
            return context?.Operators.End(DayExpand);
        };
        return context?.Operators.SelectOrNull<CqlInterval<int?>, int?>(f_, 
			g_);
    }

    [CqlDeclaration("Days In Period")]
    public IEnumerable<Tuples.Tuple_BZfjDHYASdKbVKTOeigaYPBVf> Days_In_Period(CqlInterval<CqlDateTime> Period)
    {
        var a_ = this.Interval_To_Day_Numbers(Period);
        Func<int?,Tuples.Tuple_BZfjDHYASdKbVKTOeigaYPBVf> ac_ = (DayIndex) => 
        {
            var b_ = DayIndex;
            var d_ = context?.Operators.Start(Period);
            var e_ = context?.Operators.Quantity(24m, 
				"hours");
            var f_ = context?.Operators.Subtract(DayIndex, 
				((int?)1));
            var g_ = context?.Operators.ConvertIntegerToQuantity(f_);
            var h_ = context?.Operators.Multiply(e_, 
				g_);
            var i_ = context?.Operators.Add(d_, 
				h_);
            var r_ = context?.Operators.End(Period);
            var k_ = (context?.Operators.DurationBetween(i_, 
				r_, 
				"hour") as object);
            var s_ = (((int?)24) as object);
            var aa_ = context?.Operators.ConvertIntegerToQuantity(DayIndex);
            var ab_ = context?.Operators.Multiply(e_, 
				aa_);
            var j_ = (((context?.Operators.Less(k_, 
				s_) ?? false))
				? (context?.Operators.Add(d_, 
						h_))
				: (context?.Operators.Add(d_, 
						ab_)))
;
            var c_ = context?.Operators.Interval(i_, 
				j_, 
				true, 
				false);
            return new Tuples.Tuple_BZfjDHYASdKbVKTOeigaYPBVf
			{
				dayIndex = b_,
				dayPeriod = c_,
			};
        };
        return context?.Operators.SelectOrNull<int?, Tuples.Tuple_BZfjDHYASdKbVKTOeigaYPBVf>(a_, 
			ac_);
    }

    private IEnumerable<Tuples.Tuple_FdccSJcWTSebijGjABdUMLEdR> Pertinent_Encounters_With_Days_Value()
    {
        var a_ = this.Initial_Population();
        Func<Encounter,Tuples.Tuple_FdccSJcWTSebijGjABdUMLEdR> i_ = (PertinentEncounter) => 
        {
            var b_ = PertinentEncounter;
            var c_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(PertinentEncounter);
            var d_ = this.Crop_Interval_to_10_Days(c_);
            var f_ = this.Days_In_Period(d_);
            return new Tuples.Tuple_FdccSJcWTSebijGjABdUMLEdR
			{
				encounter = b_,
				hospitalizationPeriod = c_,
				relevantPeriod = d_,
				relevantDays = f_,
			};
        };
        return context?.Operators.SelectOrNull<Encounter, Tuples.Tuple_FdccSJcWTSebijGjABdUMLEdR>(a_, 
			i_);
    }
    [CqlDeclaration("Pertinent Encounters With Days")]
    public IEnumerable<Tuples.Tuple_FdccSJcWTSebijGjABdUMLEdR> Pertinent_Encounters_With_Days() => __Pertinent_Encounters_With_Days.Value;

    private IEnumerable<Tuples.Tuple_GiWKJXbiXAiGGBDVZJdMTaVhK> Pertinent_Encounters_With_Glucose_Result_Days_Value()
    {
        var a_ = this.Pertinent_Encounters_With_Days();
        Func<Tuples.Tuple_FdccSJcWTSebijGjABdUMLEdR,Tuples.Tuple_GiWKJXbiXAiGGBDVZJdMTaVhK> bj_ = (PertinentEncounterDays) => 
        {
            var b_ = PertinentEncounterDays?.encounter;
            var c_ = PertinentEncounterDays?.relevantPeriod;
            var e_ = PertinentEncounterDays?.relevantDays;
            Func<Tuples.Tuple_BZfjDHYASdKbVKTOeigaYPBVf,Tuples.Tuple_EPQMNeOgChVRHOcBPRccPNZeF> bi_ = (EncounterDay) => 
            {
                var f_ = EncounterDay?.dayIndex;
                var g_ = EncounterDay?.dayPeriod;
                var i_ = this.Glucose_lab_test();
                var j_ = typeof(Observation).GetProperty("Code");
                var k_ = context?.DataRetriever.RetrieveByValueSet<Observation>(i_, 
					j_);
                Func<Observation,bool?> y_ = (BloodGlucoseLab1) => 
                {
                    var m_ = (BloodGlucoseLab1?.StatusElement as object);
                    var l_ = ((context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(m_) as object);
                    var n_ = ("final" as object);
                    var o_ = context?.Operators.Equal(l_, 
						n_);
                    var q_ = ((BloodGlucoseLab1?.Value as object) as Quantity);
                    var p_ = (FHIRHelpers_4_0_001.ToQuantity(q_) as object);
                    var r_ = (context?.Operators.Quantity(300m, 
						"mg/dL") as object);
                    var s_ = context?.Operators.Greater(p_, 
						r_);
                    var t_ = context?.Operators.And(o_, 
						s_);
                    var u_ = ((BloodGlucoseLab1?.Effective as object) as FhirDateTime);
                    var v_ = FHIRHelpers_4_0_001.ToDateTime(u_);
                    var w_ = EncounterDay?.dayPeriod;
                    var x_ = context?.Operators.ElementInInterval<CqlDateTime>(v_, 
						w_, 
						null);
                    return context?.Operators.And(t_, 
						x_);
                };
                var z_ = context?.Operators.WhereOrNull<Observation>(k_, 
					y_);
                var h_ = context?.Operators.ExistsInList<Observation>(z_);
                Func<Observation,bool?> ar_ = (BloodGlucoseLab2) => 
                {
                    var af_ = (BloodGlucoseLab2?.StatusElement as object);
                    var ae_ = ((context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(af_) as object);
                    var ag_ = ("final" as object);
                    var ah_ = context?.Operators.Equal(ae_, 
						ag_);
                    var aj_ = ((BloodGlucoseLab2?.Value as object) as Quantity);
                    var ai_ = (FHIRHelpers_4_0_001.ToQuantity(aj_) as object);
                    var ak_ = (context?.Operators.Quantity(200m, 
						"mg/dL") as object);
                    var al_ = context?.Operators.GreaterOrEqual(ai_, 
						ak_);
                    var am_ = context?.Operators.And(ah_, 
						al_);
                    var an_ = ((BloodGlucoseLab2?.Effective as object) as FhirDateTime);
                    var ao_ = FHIRHelpers_4_0_001.ToDateTime(an_);
                    var ap_ = EncounterDay?.dayPeriod;
                    var aq_ = context?.Operators.ElementInInterval<CqlDateTime>(ao_, 
						ap_, 
						null);
                    return context?.Operators.And(am_, 
						aq_);
                };
                var as_ = context?.Operators.WhereOrNull<Observation>(k_, 
					ar_);
                var aa_ = context?.Operators.ExistsInList<Observation>(as_);
                Func<Observation,bool?> bf_ = (BloodGlucoseLab3) => 
                {
                    var ay_ = (BloodGlucoseLab3?.StatusElement as object);
                    var ax_ = ((context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(ay_) as object);
                    var az_ = ("final" as object);
                    var ba_ = context?.Operators.Equal(ax_, 
						az_);
                    var bb_ = ((BloodGlucoseLab3?.Effective as object) as FhirDateTime);
                    var bc_ = FHIRHelpers_4_0_001.ToDateTime(bb_);
                    var bd_ = EncounterDay?.dayPeriod;
                    var be_ = context?.Operators.ElementInInterval<CqlDateTime>(bc_, 
						bd_, 
						null);
                    return context?.Operators.And(ba_, 
						be_);
                };
                var bg_ = context?.Operators.WhereOrNull<Observation>(k_, 
					bf_);
                var bh_ = context?.Operators.ExistsInList<Observation>(bg_);
                var at_ = context?.Operators.Not(bh_);
                return new Tuples.Tuple_EPQMNeOgChVRHOcBPRccPNZeF
				{
					dayIndex = f_,
					dayPeriod = g_,
					hasSevereResult = h_,
					hasElevatedResult = aa_,
					hasNoResult = at_,
				};
            };
            var d_ = context?.Operators.SelectOrNull<Tuples.Tuple_BZfjDHYASdKbVKTOeigaYPBVf, Tuples.Tuple_EPQMNeOgChVRHOcBPRccPNZeF>(e_, 
				bi_);
            return new Tuples.Tuple_GiWKJXbiXAiGGBDVZJdMTaVhK
			{
				encounter = b_,
				relevantPeriod = c_,
				relevantDays = d_,
			};
        };
        return context?.Operators.SelectOrNull<Tuples.Tuple_FdccSJcWTSebijGjABdUMLEdR, Tuples.Tuple_GiWKJXbiXAiGGBDVZJdMTaVhK>(a_, 
			bj_);
    }
    [CqlDeclaration("Pertinent Encounters With Glucose Result Days")]
    public IEnumerable<Tuples.Tuple_GiWKJXbiXAiGGBDVZJdMTaVhK> Pertinent_Encounters_With_Glucose_Result_Days() => __Pertinent_Encounters_With_Glucose_Result_Days.Value;

    private IEnumerable<Tuples.Tuple_CAbQjTVRCSKOYWiIhECGMcDPA> Pertinent_Encounters_With_Hyperglycemic_Event_Days_Value()
    {
        var a_ = this.Pertinent_Encounters_With_Glucose_Result_Days();
        Func<Tuples.Tuple_GiWKJXbiXAiGGBDVZJdMTaVhK,Tuples.Tuple_CAbQjTVRCSKOYWiIhECGMcDPA> t_ = (EncounterWithResultDays) => 
        {
            var b_ = EncounterWithResultDays?.encounter;
            var c_ = EncounterWithResultDays?.relevantPeriod;
            var e_ = EncounterWithResultDays?.relevantDays;
            Func<Tuples.Tuple_EPQMNeOgChVRHOcBPRccPNZeF,bool?> h_ = (EncounterDay) => 
            {
                var f_ = (EncounterDay?.dayIndex as object);
                var g_ = (((int?)1) as object);
                return context?.Operators.Greater(f_, 
					g_);
            };
            var i_ = context?.Operators.WhereOrNull<Tuples.Tuple_EPQMNeOgChVRHOcBPRccPNZeF>(e_, 
				h_);
            Func<Tuples.Tuple_EPQMNeOgChVRHOcBPRccPNZeF,Tuples.Tuple_HBBaLFUhhUfQBEJKjEZegSRLi> s_ = (EncounterDay) => 
            {
                var j_ = EncounterDay?.dayIndex;
                var k_ = EncounterDay?.dayPeriod;
                var m_ = EncounterDay?.hasSevereResult;
                var n_ = EncounterDay?.hasNoResult;
                var o_ = (context?.Operators.ListElementAt<Tuples.Tuple_EPQMNeOgChVRHOcBPRccPNZeF>(EncounterWithResultDays?.relevantDays, 
						context?.Operators.Subtract(EncounterDay?.dayIndex, 
							((int?)2))))?.hasElevatedResult;
                var p_ = context?.Operators.And(n_, 
					o_);
                var q_ = (context?.Operators.ListElementAt<Tuples.Tuple_EPQMNeOgChVRHOcBPRccPNZeF>(EncounterWithResultDays?.relevantDays, 
						context?.Operators.Subtract(EncounterDay?.dayIndex, 
							((int?)3))))?.hasElevatedResult;
                var r_ = context?.Operators.And(p_, 
					q_);
                var l_ = context?.Operators.Or(m_, 
					r_);
                return new Tuples.Tuple_HBBaLFUhhUfQBEJKjEZegSRLi
				{
					dayIndex = j_,
					dayPeriod = k_,
					hasHyperglycemicEvent = l_,
				};
            };
            var d_ = context?.Operators.SelectOrNull<Tuples.Tuple_EPQMNeOgChVRHOcBPRccPNZeF, Tuples.Tuple_HBBaLFUhhUfQBEJKjEZegSRLi>(i_, 
				s_);
            return new Tuples.Tuple_CAbQjTVRCSKOYWiIhECGMcDPA
			{
				encounter = b_,
				relevantPeriod = c_,
				eligibleEventDays = d_,
			};
        };
        return context?.Operators.SelectOrNull<Tuples.Tuple_GiWKJXbiXAiGGBDVZJdMTaVhK, Tuples.Tuple_CAbQjTVRCSKOYWiIhECGMcDPA>(a_, 
			t_);
    }
    [CqlDeclaration("Pertinent Encounters With Hyperglycemic Event Days")]
    public IEnumerable<Tuples.Tuple_CAbQjTVRCSKOYWiIhECGMcDPA> Pertinent_Encounters_With_Hyperglycemic_Event_Days() => __Pertinent_Encounters_With_Hyperglycemic_Event_Days.Value;

    private IEnumerable<Encounter> Numerator_Value()
    {
        var a_ = this.Pertinent_Encounters_With_Hyperglycemic_Event_Days();
        Func<Tuples.Tuple_CAbQjTVRCSKOYWiIhECGMcDPA,bool?> e_ = (EncounterWithEventDays) => 
        {
            var b_ = EncounterWithEventDays?.eligibleEventDays;
            Func<Tuples.Tuple_HBBaLFUhhUfQBEJKjEZegSRLi,bool?> c_ = (EligibleEventDay) => 
            {
                return EligibleEventDay?.hasHyperglycemicEvent;
            };
            var d_ = context?.Operators.WhereOrNull<Tuples.Tuple_HBBaLFUhhUfQBEJKjEZegSRLi>(b_, 
				c_);
            return context?.Operators.ExistsInList<Tuples.Tuple_HBBaLFUhhUfQBEJKjEZegSRLi>(d_);
        };
        var f_ = context?.Operators.WhereOrNull<Tuples.Tuple_CAbQjTVRCSKOYWiIhECGMcDPA>(a_, 
			e_);
        Func<Tuples.Tuple_CAbQjTVRCSKOYWiIhECGMcDPA,Encounter> g_ = (EncounterWithEventDays) => 
        {
            return EncounterWithEventDays?.encounter;
        };
        return context?.Operators.SelectOrNull<Tuples.Tuple_CAbQjTVRCSKOYWiIhECGMcDPA, Encounter>(f_, 
			g_);
    }
    [CqlDeclaration("Numerator")]
    public IEnumerable<Encounter> Numerator() => __Numerator.Value;

    [CqlDeclaration("Denominator Observations")]
    public int? Denominator_Observations(Encounter QualifyingEncounter)
    {
        var a_ = this.Pertinent_Encounters_With_Hyperglycemic_Event_Days();
        Func<Tuples.Tuple_CAbQjTVRCSKOYWiIhECGMcDPA,bool?> d_ = (EncounterWithEventDays) => 
        {
            var b_ = (EncounterWithEventDays?.encounter as object);
            var c_ = (QualifyingEncounter as object);
            return context?.Operators.Equal(b_, 
				c_);
        };
        var e_ = context?.Operators.WhereOrNull<Tuples.Tuple_CAbQjTVRCSKOYWiIhECGMcDPA>(a_, 
			d_);
        Func<Tuples.Tuple_CAbQjTVRCSKOYWiIhECGMcDPA,int?> g_ = (EncounterWithEventDays) => 
        {
            var f_ = EncounterWithEventDays?.eligibleEventDays;
            return context?.Operators.CountOrNull<Tuples.Tuple_HBBaLFUhhUfQBEJKjEZegSRLi>(f_);
        };
        var h_ = context?.Operators.SelectOrNull<Tuples.Tuple_CAbQjTVRCSKOYWiIhECGMcDPA, int?>(e_, 
			g_);
        return context?.Operators.SingleOrNull<int?>(h_);
    }

    [CqlDeclaration("Numerator Observations")]
    public int? Numerator_Observations(Encounter QualifyingEncounter)
    {
        var a_ = this.Pertinent_Encounters_With_Hyperglycemic_Event_Days();
        Func<Tuples.Tuple_CAbQjTVRCSKOYWiIhECGMcDPA,bool?> d_ = (EncounterWithEventDays) => 
        {
            var b_ = (EncounterWithEventDays?.encounter as object);
            var c_ = (QualifyingEncounter as object);
            return context?.Operators.Equal(b_, 
				c_);
        };
        var e_ = context?.Operators.WhereOrNull<Tuples.Tuple_CAbQjTVRCSKOYWiIhECGMcDPA>(a_, 
			d_);
        Func<Tuples.Tuple_CAbQjTVRCSKOYWiIhECGMcDPA,int?> i_ = (EncounterWithEventDays) => 
        {
            var f_ = EncounterWithEventDays?.eligibleEventDays;
            Func<Tuples.Tuple_HBBaLFUhhUfQBEJKjEZegSRLi,bool?> g_ = (EligibleEventDay) => 
            {
                return EligibleEventDay?.hasHyperglycemicEvent;
            };
            var h_ = context?.Operators.WhereOrNull<Tuples.Tuple_HBBaLFUhhUfQBEJKjEZegSRLi>(f_, 
				g_);
            return context?.Operators.CountOrNull<Tuples.Tuple_HBBaLFUhhUfQBEJKjEZegSRLi>(h_);
        };
        var j_ = context?.Operators.SelectOrNull<Tuples.Tuple_CAbQjTVRCSKOYWiIhECGMcDPA, int?>(e_, 
			i_);
        return context?.Operators.SingleOrNull<int?>(j_);
    }

}