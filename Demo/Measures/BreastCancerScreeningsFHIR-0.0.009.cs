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
[CqlLibrary("BreastCancerScreeningsFHIR", "0.0.009")]
public class BreastCancerScreeningsFHIR_0_0_009
{


    internal CqlContext context;

    #region Cached values

    internal Lazy<CqlValueSet> __Bilateral_Mastectomy;
    internal Lazy<CqlValueSet> __History_of_bilateral_mastectomy;
    internal Lazy<CqlValueSet> __Left;
    internal Lazy<CqlValueSet> __Mammography;
    internal Lazy<CqlValueSet> __Online_Assessments;
    internal Lazy<CqlValueSet> __Right;
    internal Lazy<CqlValueSet> __Status_Post_Left_Mastectomy;
    internal Lazy<CqlValueSet> __Status_Post_Right_Mastectomy;
    internal Lazy<CqlValueSet> __Telephone_Visits;
    internal Lazy<CqlValueSet> __Unilateral_Mastectomy_Left;
    internal Lazy<CqlValueSet> __Unilateral_Mastectomy_Right;
    internal Lazy<CqlValueSet> __Unilateral_Mastectomy__Unspecified_Laterality;
    internal Lazy<CqlInterval<CqlDateTime>> __Measurement_Period;
    internal Lazy<Patient> __Patient;
    internal Lazy<IEnumerable<Coding>> __SDE_Ethnicity;
    internal Lazy<IEnumerable<Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG>> __SDE_Payer;
    internal Lazy<IEnumerable<Coding>> __SDE_Race;
    internal Lazy<CqlCode> __SDE_Sex;
    internal Lazy<IEnumerable<Encounter>> __Telehealth_Services;
    internal Lazy<int?> __Age_at_start_of_Measurement_Period;
    internal Lazy<bool?> __Initial_Population;
    internal Lazy<bool?> __Denominator;
    internal Lazy<IEnumerable<Condition>> __Right_Mastectomy_Diagnosis;
    internal Lazy<IEnumerable<Procedure>> __Right_Mastectomy_Procedure;
    internal Lazy<IEnumerable<Condition>> __Left_Mastectomy_Diagnosis;
    internal Lazy<IEnumerable<Procedure>> __Left_Mastectomy_Procedure;
    internal Lazy<IEnumerable<Condition>> __Bilateral_Mastectomy_Diagnosis;
    internal Lazy<IEnumerable<Procedure>> __Bilateral_Mastectomy_Procedure;
    internal Lazy<bool?> __Denominator_Exclusions;
    internal Lazy<bool?> __Observation_with_status;
    internal Lazy<bool?> __Diagnostic_Report_with_status;
    internal Lazy<bool?> __Numerator;
    internal Lazy<bool?> __Final_Numerator_Population;
    internal Lazy<bool?> __Observation_without_appropriate_status;
    internal Lazy<bool?> __Diagnostic_Report_without_appropriate_status;

    #endregion
    public BreastCancerScreeningsFHIR_0_0_009(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");

        FHIRHelpers_4_0_001 = new FHIRHelpers_4_0_001(context);
        SupplementalDataElementsFHIR4_2_0_000 = new SupplementalDataElementsFHIR4_2_0_000(context);
        MATGlobalCommonFunctionsFHIR4_6_1_000 = new MATGlobalCommonFunctionsFHIR4_6_1_000(context);
        AdultOutpatientEncountersFHIR4_2_2_000 = new AdultOutpatientEncountersFHIR4_2_2_000(context);
        AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000 = new AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000(context);
        PalliativeCareFHIR_0_6_000 = new PalliativeCareFHIR_0_6_000(context);
        CumulativeMedicationDurationFHIR4_1_0_000 = new CumulativeMedicationDurationFHIR4_1_0_000(context);
        HospiceFHIR4_2_3_000 = new HospiceFHIR4_2_3_000(context);

        __Bilateral_Mastectomy = new Lazy<CqlValueSet>(this.Bilateral_Mastectomy_Value);
        __History_of_bilateral_mastectomy = new Lazy<CqlValueSet>(this.History_of_bilateral_mastectomy_Value);
        __Left = new Lazy<CqlValueSet>(this.Left_Value);
        __Mammography = new Lazy<CqlValueSet>(this.Mammography_Value);
        __Online_Assessments = new Lazy<CqlValueSet>(this.Online_Assessments_Value);
        __Right = new Lazy<CqlValueSet>(this.Right_Value);
        __Status_Post_Left_Mastectomy = new Lazy<CqlValueSet>(this.Status_Post_Left_Mastectomy_Value);
        __Status_Post_Right_Mastectomy = new Lazy<CqlValueSet>(this.Status_Post_Right_Mastectomy_Value);
        __Telephone_Visits = new Lazy<CqlValueSet>(this.Telephone_Visits_Value);
        __Unilateral_Mastectomy_Left = new Lazy<CqlValueSet>(this.Unilateral_Mastectomy_Left_Value);
        __Unilateral_Mastectomy_Right = new Lazy<CqlValueSet>(this.Unilateral_Mastectomy_Right_Value);
        __Unilateral_Mastectomy__Unspecified_Laterality = new Lazy<CqlValueSet>(this.Unilateral_Mastectomy__Unspecified_Laterality_Value);
        __Measurement_Period = new Lazy<CqlInterval<CqlDateTime>>(this.Measurement_Period_Value);
        __Patient = new Lazy<Patient>(this.Patient_Value);
        __SDE_Ethnicity = new Lazy<IEnumerable<Coding>>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<IEnumerable<Coding>>(this.SDE_Race_Value);
        __SDE_Sex = new Lazy<CqlCode>(this.SDE_Sex_Value);
        __Telehealth_Services = new Lazy<IEnumerable<Encounter>>(this.Telehealth_Services_Value);
        __Age_at_start_of_Measurement_Period = new Lazy<int?>(this.Age_at_start_of_Measurement_Period_Value);
        __Initial_Population = new Lazy<bool?>(this.Initial_Population_Value);
        __Denominator = new Lazy<bool?>(this.Denominator_Value);
        __Right_Mastectomy_Diagnosis = new Lazy<IEnumerable<Condition>>(this.Right_Mastectomy_Diagnosis_Value);
        __Right_Mastectomy_Procedure = new Lazy<IEnumerable<Procedure>>(this.Right_Mastectomy_Procedure_Value);
        __Left_Mastectomy_Diagnosis = new Lazy<IEnumerable<Condition>>(this.Left_Mastectomy_Diagnosis_Value);
        __Left_Mastectomy_Procedure = new Lazy<IEnumerable<Procedure>>(this.Left_Mastectomy_Procedure_Value);
        __Bilateral_Mastectomy_Diagnosis = new Lazy<IEnumerable<Condition>>(this.Bilateral_Mastectomy_Diagnosis_Value);
        __Bilateral_Mastectomy_Procedure = new Lazy<IEnumerable<Procedure>>(this.Bilateral_Mastectomy_Procedure_Value);
        __Denominator_Exclusions = new Lazy<bool?>(this.Denominator_Exclusions_Value);
        __Observation_with_status = new Lazy<bool?>(this.Observation_with_status_Value);
        __Diagnostic_Report_with_status = new Lazy<bool?>(this.Diagnostic_Report_with_status_Value);
        __Numerator = new Lazy<bool?>(this.Numerator_Value);
        __Final_Numerator_Population = new Lazy<bool?>(this.Final_Numerator_Population_Value);
        __Observation_without_appropriate_status = new Lazy<bool?>(this.Observation_without_appropriate_status_Value);
        __Diagnostic_Report_without_appropriate_status = new Lazy<bool?>(this.Diagnostic_Report_without_appropriate_status_Value);
    }
    #region Dependencies

    public FHIRHelpers_4_0_001 FHIRHelpers_4_0_001 { get; }
    public SupplementalDataElementsFHIR4_2_0_000 SupplementalDataElementsFHIR4_2_0_000 { get; }
    public MATGlobalCommonFunctionsFHIR4_6_1_000 MATGlobalCommonFunctionsFHIR4_6_1_000 { get; }
    public AdultOutpatientEncountersFHIR4_2_2_000 AdultOutpatientEncountersFHIR4_2_2_000 { get; }
    public AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000 AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000 { get; }
    public PalliativeCareFHIR_0_6_000 PalliativeCareFHIR_0_6_000 { get; }
    public CumulativeMedicationDurationFHIR4_1_0_000 CumulativeMedicationDurationFHIR4_1_0_000 { get; }
    public HospiceFHIR4_2_3_000 HospiceFHIR4_2_3_000 { get; }

    #endregion

	private CqlValueSet Bilateral_Mastectomy_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1005", null);

    [CqlDeclaration("Bilateral Mastectomy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1005")]
	public CqlValueSet Bilateral_Mastectomy() => 
		__Bilateral_Mastectomy.Value;

	private CqlValueSet History_of_bilateral_mastectomy_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1068", null);

    [CqlDeclaration("History of bilateral mastectomy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1068")]
	public CqlValueSet History_of_bilateral_mastectomy() => 
		__History_of_bilateral_mastectomy.Value;

	private CqlValueSet Left_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.122.12.1036", null);

    [CqlDeclaration("Left")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.122.12.1036")]
	public CqlValueSet Left() => 
		__Left.Value;

	private CqlValueSet Mammography_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.11.1047", null);

    [CqlDeclaration("Mammography")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.11.1047")]
	public CqlValueSet Mammography() => 
		__Mammography.Value;

	private CqlValueSet Online_Assessments_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", null);

    [CqlDeclaration("Online Assessments")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089")]
	public CqlValueSet Online_Assessments() => 
		__Online_Assessments.Value;

	private CqlValueSet Right_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.122.12.1035", null);

    [CqlDeclaration("Right")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.122.12.1035")]
	public CqlValueSet Right() => 
		__Right.Value;

	private CqlValueSet Status_Post_Left_Mastectomy_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1069", null);

    [CqlDeclaration("Status Post Left Mastectomy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1069")]
	public CqlValueSet Status_Post_Left_Mastectomy() => 
		__Status_Post_Left_Mastectomy.Value;

	private CqlValueSet Status_Post_Right_Mastectomy_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1070", null);

    [CqlDeclaration("Status Post Right Mastectomy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1070")]
	public CqlValueSet Status_Post_Right_Mastectomy() => 
		__Status_Post_Right_Mastectomy.Value;

	private CqlValueSet Telephone_Visits_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", null);

    [CqlDeclaration("Telephone Visits")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080")]
	public CqlValueSet Telephone_Visits() => 
		__Telephone_Visits.Value;

	private CqlValueSet Unilateral_Mastectomy_Left_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1133", null);

    [CqlDeclaration("Unilateral Mastectomy Left")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1133")]
	public CqlValueSet Unilateral_Mastectomy_Left() => 
		__Unilateral_Mastectomy_Left.Value;

	private CqlValueSet Unilateral_Mastectomy_Right_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1134", null);

    [CqlDeclaration("Unilateral Mastectomy Right")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1134")]
	public CqlValueSet Unilateral_Mastectomy_Right() => 
		__Unilateral_Mastectomy_Right.Value;

	private CqlValueSet Unilateral_Mastectomy__Unspecified_Laterality_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1071", null);

    [CqlDeclaration("Unilateral Mastectomy, Unspecified Laterality")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1071")]
	public CqlValueSet Unilateral_Mastectomy__Unspecified_Laterality() => 
		__Unilateral_Mastectomy__Unspecified_Laterality.Value;

	private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		var a_ = context.Operators;
		var d_ = a_.ConvertIntegerToDecimal(default);
		var e_ = a_.DateTime((int?)2021, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, d_);
		var h_ = a_.ConvertIntegerToDecimal(default);
		var i_ = a_.DateTime((int?)2022, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, h_);
		var j_ = a_.Interval(e_, i_, true, false);
		var k_ = context.ResolveParameter("BreastCancerScreeningsFHIR-0.0.009", "Measurement Period", j_);

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

	private IEnumerable<Encounter> Telehealth_Services_Value()
	{
		var a_ = context.Operators;
		var c_ = context.DataRetriever;
		var d_ = this.Online_Assessments();
		var e_ = c_.RetrieveByValueSet<Encounter>(d_, null);
		var g_ = this.Telephone_Visits();
		var h_ = c_.RetrieveByValueSet<Encounter>(g_, null);
		var i_ = a_.ListUnion<Encounter>(e_, h_);
		bool? j_(Encounter TelehealthEncounter)
		{
			var l_ = context.Operators;
			var n_ = context.Deeper(new CallStackEntry("ToString", null, null));
			var o_ = n_.Operators;
			var p_ = o_.TypeConverter;
			var q_ = TelehealthEncounter?.StatusElement;
			var r_ = p_.Convert<string>(q_);
			var s_ = l_.Equal(r_, "finished");
			var u_ = this.Measurement_Period();
			var v_ = TelehealthEncounter?.Period;
			var w_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(v_);
			var x_ = l_.IntervalIncludesInterval<CqlDateTime>(u_, w_, null);
			var y_ = l_.And(s_, x_);

			return y_;
		};
		var k_ = a_.WhereOrNull<Encounter>(i_, j_);

		return k_;
	}

    [CqlDeclaration("Telehealth Services")]
	public IEnumerable<Encounter> Telehealth_Services() => 
		__Telehealth_Services.Value;

	private int? Age_at_start_of_Measurement_Period_Value()
	{
		var a_ = context.Operators;
		var c_ = a_.TypeConverter;
		var d_ = this.Patient();
		var e_ = d_?.BirthDateElement;
		var f_ = e_?.Value;
		var g_ = c_.Convert<CqlDate>(f_);
		var j_ = this.Measurement_Period();
		var k_ = a_.Start(j_);
		var l_ = a_.DateFrom(k_);
		var m_ = a_.CalculateAgeAt(g_, l_, "year");

		return m_;
	}

    [CqlDeclaration("Age at start of Measurement Period")]
	public int? Age_at_start_of_Measurement_Period() => 
		__Age_at_start_of_Measurement_Period.Value;

	private bool? Initial_Population_Value()
	{
		var a_ = context.Operators;
		var f_ = a_.TypeConverter;
		var g_ = this.Patient();
		var h_ = g_?.BirthDateElement;
		var i_ = h_?.Value;
		var j_ = f_.Convert<CqlDate>(i_);
		var m_ = this.Measurement_Period();
		var n_ = a_.Start(m_);
		var o_ = a_.DateFrom(n_);
		var p_ = a_.CalculateAgeAt(j_, o_, "year");
		var r_ = a_.Interval((int?)51, (int?)74, true, false);
		var s_ = a_.ElementInInterval<int?>(p_, r_, null);
		var u_ = context.Deeper(new CallStackEntry("ToString", null, null));
		var v_ = u_.Operators;
		var w_ = v_.TypeConverter;
		var y_ = g_?.GenderElement;
		var z_ = w_.Convert<string>(y_);
		var aa_ = a_.Equal(z_, "female");
		var ab_ = a_.And(s_, aa_);
		var ae_ = AdultOutpatientEncountersFHIR4_2_2_000.Qualifying_Encounters();
		var af_ = this.Telehealth_Services();
		var ag_ = a_.ListUnion<Encounter>(ae_, af_);
		var ah_ = a_.ExistsInList<Encounter>(ag_);
		var ai_ = a_.And(ab_, ah_);

		return ai_;
	}

    [CqlDeclaration("Initial Population")]
	public bool? Initial_Population() => 
		__Initial_Population.Value;

	private bool? Denominator_Value()
	{
		var a_ = this.Initial_Population();

		return a_;
	}

    [CqlDeclaration("Denominator")]
	public bool? Denominator() => 
		__Denominator.Value;

	private IEnumerable<Condition> Right_Mastectomy_Diagnosis_Value()
	{
		var a_ = context.Operators;
		var c_ = context.DataRetriever;
		var d_ = this.Status_Post_Right_Mastectomy();
		var e_ = c_.RetrieveByValueSet<Condition>(d_, null);
		var h_ = this.Unilateral_Mastectomy__Unspecified_Laterality();
		var i_ = c_.RetrieveByValueSet<Condition>(h_, null);
		bool? j_(Condition UnilateralMastectomyDiagnosis)
		{
			var o_ = context.Operators;
			var q_ = UnilateralMastectomyDiagnosis?.BodySite;
			CqlConcept r_(CodeableConcept X)
			{
				var v_ = FHIRHelpers_4_0_001.ToConcept(X);

				return v_;
			};
			var s_ = o_.SelectOrNull<CodeableConcept, CqlConcept>((q_ as IEnumerable<CodeableConcept>), r_);
			var t_ = this.Right();
			var u_ = o_.ConceptsInValueSet(s_, t_);

			return u_;
		};
		var k_ = a_.WhereOrNull<Condition>(i_, j_);
		var l_ = a_.ListUnion<Condition>(e_, k_);
		bool? m_(Condition RightMastectomy)
		{
			var w_ = context.Operators;
			var y_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Prevalence_Period(RightMastectomy);
			var z_ = w_.Start(y_);
			var ab_ = this.Measurement_Period();
			var ac_ = w_.End(ab_);
			var ad_ = w_.SameOrBefore(z_, ac_, null);

			return ad_;
		};
		var n_ = a_.WhereOrNull<Condition>(l_, m_);

		return n_;
	}

    [CqlDeclaration("Right Mastectomy Diagnosis")]
	public IEnumerable<Condition> Right_Mastectomy_Diagnosis() => 
		__Right_Mastectomy_Diagnosis.Value;

	private IEnumerable<Procedure> Right_Mastectomy_Procedure_Value()
	{
		var a_ = context.Operators;
		var b_ = context.DataRetriever;
		var c_ = this.Unilateral_Mastectomy_Right();
		var d_ = b_.RetrieveByValueSet<Procedure>(c_, null);
		bool? e_(Procedure UnilateralMastectomyRightPerformed)
		{
			var g_ = context.Operators;
			var i_ = context.Deeper(new CallStackEntry("ToString", null, null));
			var j_ = i_.Operators;
			var k_ = j_.TypeConverter;
			var l_ = UnilateralMastectomyRightPerformed?.StatusElement;
			var m_ = k_.Convert<string>(l_);
			var n_ = g_.Equal(m_, "completed");
			var q_ = UnilateralMastectomyRightPerformed?.Performed;
			var r_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(q_);
			var s_ = g_.End(r_);
			var u_ = this.Measurement_Period();
			var v_ = g_.End(u_);
			var w_ = g_.SameOrBefore(s_, v_, null);
			var x_ = g_.And(n_, w_);

			return x_;
		};
		var f_ = a_.WhereOrNull<Procedure>(d_, e_);

		return f_;
	}

    [CqlDeclaration("Right Mastectomy Procedure")]
	public IEnumerable<Procedure> Right_Mastectomy_Procedure() => 
		__Right_Mastectomy_Procedure.Value;

	private IEnumerable<Condition> Left_Mastectomy_Diagnosis_Value()
	{
		var a_ = context.Operators;
		var c_ = context.DataRetriever;
		var d_ = this.Status_Post_Left_Mastectomy();
		var e_ = c_.RetrieveByValueSet<Condition>(d_, null);
		var h_ = this.Unilateral_Mastectomy__Unspecified_Laterality();
		var i_ = c_.RetrieveByValueSet<Condition>(h_, null);
		bool? j_(Condition UnilateralMastectomyDiagnosis)
		{
			var o_ = context.Operators;
			var q_ = UnilateralMastectomyDiagnosis?.BodySite;
			CqlConcept r_(CodeableConcept X)
			{
				var v_ = FHIRHelpers_4_0_001.ToConcept(X);

				return v_;
			};
			var s_ = o_.SelectOrNull<CodeableConcept, CqlConcept>((q_ as IEnumerable<CodeableConcept>), r_);
			var t_ = this.Left();
			var u_ = o_.ConceptsInValueSet(s_, t_);

			return u_;
		};
		var k_ = a_.WhereOrNull<Condition>(i_, j_);
		var l_ = a_.ListUnion<Condition>(e_, k_);
		bool? m_(Condition LeftMastectomy)
		{
			var w_ = context.Operators;
			var y_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Prevalence_Period(LeftMastectomy);
			var z_ = w_.Start(y_);
			var ab_ = this.Measurement_Period();
			var ac_ = w_.End(ab_);
			var ad_ = w_.SameOrBefore(z_, ac_, null);

			return ad_;
		};
		var n_ = a_.WhereOrNull<Condition>(l_, m_);

		return n_;
	}

    [CqlDeclaration("Left Mastectomy Diagnosis")]
	public IEnumerable<Condition> Left_Mastectomy_Diagnosis() => 
		__Left_Mastectomy_Diagnosis.Value;

	private IEnumerable<Procedure> Left_Mastectomy_Procedure_Value()
	{
		var a_ = context.Operators;
		var b_ = context.DataRetriever;
		var c_ = this.Unilateral_Mastectomy_Left();
		var d_ = b_.RetrieveByValueSet<Procedure>(c_, null);
		bool? e_(Procedure UnilateralMastectomyLeftPerformed)
		{
			var g_ = context.Operators;
			var i_ = context.Deeper(new CallStackEntry("ToString", null, null));
			var j_ = i_.Operators;
			var k_ = j_.TypeConverter;
			var l_ = UnilateralMastectomyLeftPerformed?.StatusElement;
			var m_ = k_.Convert<string>(l_);
			var n_ = g_.Equal(m_, "completed");
			var q_ = UnilateralMastectomyLeftPerformed?.Performed;
			var r_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(q_);
			var s_ = g_.End(r_);
			var u_ = this.Measurement_Period();
			var v_ = g_.End(u_);
			var w_ = g_.SameOrBefore(s_, v_, null);
			var x_ = g_.And(n_, w_);

			return x_;
		};
		var f_ = a_.WhereOrNull<Procedure>(d_, e_);

		return f_;
	}

    [CqlDeclaration("Left Mastectomy Procedure")]
	public IEnumerable<Procedure> Left_Mastectomy_Procedure() => 
		__Left_Mastectomy_Procedure.Value;

	private IEnumerable<Condition> Bilateral_Mastectomy_Diagnosis_Value()
	{
		var a_ = context.Operators;
		var b_ = context.DataRetriever;
		var c_ = this.History_of_bilateral_mastectomy();
		var d_ = b_.RetrieveByValueSet<Condition>(c_, null);
		bool? e_(Condition BilateralMastectomyHistory)
		{
			var g_ = context.Operators;
			var i_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Prevalence_Period(BilateralMastectomyHistory);
			var j_ = g_.Start(i_);
			var l_ = this.Measurement_Period();
			var m_ = g_.End(l_);
			var n_ = g_.SameOrBefore(j_, m_, null);

			return n_;
		};
		var f_ = a_.WhereOrNull<Condition>(d_, e_);

		return f_;
	}

    [CqlDeclaration("Bilateral Mastectomy Diagnosis")]
	public IEnumerable<Condition> Bilateral_Mastectomy_Diagnosis() => 
		__Bilateral_Mastectomy_Diagnosis.Value;

	private IEnumerable<Procedure> Bilateral_Mastectomy_Procedure_Value()
	{
		var a_ = context.Operators;
		var b_ = context.DataRetriever;
		var c_ = this.Bilateral_Mastectomy();
		var d_ = b_.RetrieveByValueSet<Procedure>(c_, null);
		bool? e_(Procedure BilateralMastectomyPerformed)
		{
			var g_ = context.Operators;
			var i_ = context.Deeper(new CallStackEntry("ToString", null, null));
			var j_ = i_.Operators;
			var k_ = j_.TypeConverter;
			var l_ = BilateralMastectomyPerformed?.StatusElement;
			var m_ = k_.Convert<string>(l_);
			var n_ = g_.Equal(m_, "completed");
			var q_ = BilateralMastectomyPerformed?.Performed;
			var r_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(q_);
			var s_ = g_.End(r_);
			var u_ = this.Measurement_Period();
			var v_ = g_.End(u_);
			var w_ = g_.SameOrBefore(s_, v_, null);
			var x_ = g_.And(n_, w_);

			return x_;
		};
		var f_ = a_.WhereOrNull<Procedure>(d_, e_);

		return f_;
	}

    [CqlDeclaration("Bilateral Mastectomy Procedure")]
	public IEnumerable<Procedure> Bilateral_Mastectomy_Procedure() => 
		__Bilateral_Mastectomy_Procedure.Value;

	private bool? Denominator_Exclusions_Value()
	{
		var a_ = context.Operators;
		var g_ = HospiceFHIR4_2_3_000.Has_Hospice();
		var k_ = this.Right_Mastectomy_Diagnosis();
		var l_ = a_.ExistsInList<Condition>(k_);
		var n_ = this.Right_Mastectomy_Procedure();
		var o_ = a_.ExistsInList<Procedure>(n_);
		var p_ = a_.Or(l_, o_);
		var s_ = this.Left_Mastectomy_Diagnosis();
		var t_ = a_.ExistsInList<Condition>(s_);
		var v_ = this.Left_Mastectomy_Procedure();
		var w_ = a_.ExistsInList<Procedure>(v_);
		var x_ = a_.Or(t_, w_);
		var y_ = a_.And(p_, x_);
		var z_ = a_.Or(g_, y_);
		var ab_ = this.Bilateral_Mastectomy_Diagnosis();
		var ac_ = a_.ExistsInList<Condition>(ab_);
		var ad_ = a_.Or(z_, ac_);
		var af_ = this.Bilateral_Mastectomy_Procedure();
		var ag_ = a_.ExistsInList<Procedure>(af_);
		var ah_ = a_.Or(ad_, ag_);
		var ai_ = AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000.Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80();
		var aj_ = a_.Or(ah_, ai_);
		var ao_ = a_.TypeConverter;
		var ap_ = this.Patient();
		var aq_ = ap_?.BirthDateElement;
		var ar_ = aq_?.Value;
		var as_ = ao_.Convert<CqlDate>(ar_);
		var av_ = this.Measurement_Period();
		var aw_ = a_.Start(av_);
		var ax_ = a_.DateFrom(aw_);
		var ay_ = a_.CalculateAgeAt(as_, ax_, "year");
		var az_ = a_.GreaterOrEqual(ay_, (int?)65);
		var ba_ = AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000.Has_Long_Term_Care_Periods_Longer_Than_90_Consecutive_Days();
		var bb_ = a_.And(az_, ba_);
		var bc_ = a_.Or(aj_, bb_);
		var bd_ = PalliativeCareFHIR_0_6_000.Palliative_Care_in_the_Measurement_Period();
		var be_ = a_.Or(bc_, bd_);

		return be_;
	}

    [CqlDeclaration("Denominator Exclusions")]
	public bool? Denominator_Exclusions() => 
		__Denominator_Exclusions.Value;

	private bool? Observation_with_status_Value()
	{
		var a_ = context.Operators;
		var c_ = context.DataRetriever;
		var d_ = this.Mammography();
		var e_ = c_.RetrieveByValueSet<Observation>(d_, null);
		bool? f_(Observation Mammogram)
		{
			var i_ = context.Operators;
			var k_ = context.Deeper(new CallStackEntry("ToString", null, null));
			var l_ = k_.Operators;
			var m_ = l_.TypeConverter;
			var n_ = Mammogram?.StatusElement;
			var o_ = m_.Convert<string>(n_);
			var p_ = new string[]
			{
				"final",
				"amended",
				"corrected",
				"appended",
			};
			var q_ = i_.InList<string>(o_, (p_ as IEnumerable<string>));
			var u_ = Mammogram?.Effective;
			var v_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(u_);
			var w_ = i_.End(v_);
			var aa_ = this.Measurement_Period();
			var ab_ = i_.End(aa_);
			var ad_ = i_.Quantity(27m, "months");
			var ae_ = i_.Subtract(ab_, ad_);
			var ah_ = i_.End(aa_);
			var ai_ = i_.Interval(ae_, ah_, true, true);
			var aj_ = i_.ElementInInterval<CqlDateTime>(w_, ai_, null);
			var an_ = i_.End(aa_);
			var ao_ = i_.Not((bool?)(an_ is null));
			var ap_ = i_.And(aj_, ao_);
			var aq_ = i_.And(q_, ap_);

			return aq_;
		};
		var g_ = a_.WhereOrNull<Observation>(e_, f_);
		var h_ = a_.ExistsInList<Observation>(g_);

		return h_;
	}

    [CqlDeclaration("Observation with status")]
	public bool? Observation_with_status() => 
		__Observation_with_status.Value;

	private bool? Diagnostic_Report_with_status_Value()
	{
		var a_ = context.Operators;
		var c_ = context.DataRetriever;
		var d_ = this.Mammography();
		var e_ = c_.RetrieveByValueSet<DiagnosticReport>(d_, null);
		bool? f_(DiagnosticReport Mammogram)
		{
			var i_ = context.Operators;
			var k_ = context.Deeper(new CallStackEntry("ToString", null, null));
			var l_ = k_.Operators;
			var m_ = l_.TypeConverter;
			var n_ = Mammogram?.StatusElement;
			var o_ = m_.Convert<string>(n_);
			var p_ = new string[]
			{
				"final",
				"amended",
				"corrected",
				"appended",
			};
			var q_ = i_.InList<string>(o_, (p_ as IEnumerable<string>));
			var u_ = Mammogram?.Effective;
			var v_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(u_);
			var w_ = i_.End(v_);
			var aa_ = this.Measurement_Period();
			var ab_ = i_.End(aa_);
			var ad_ = i_.Quantity(27m, "months");
			var ae_ = i_.Subtract(ab_, ad_);
			var ah_ = i_.End(aa_);
			var ai_ = i_.Interval(ae_, ah_, true, true);
			var aj_ = i_.ElementInInterval<CqlDateTime>(w_, ai_, null);
			var an_ = i_.End(aa_);
			var ao_ = i_.Not((bool?)(an_ is null));
			var ap_ = i_.And(aj_, ao_);
			var aq_ = i_.And(q_, ap_);

			return aq_;
		};
		var g_ = a_.WhereOrNull<DiagnosticReport>(e_, f_);
		var h_ = a_.ExistsInList<DiagnosticReport>(g_);

		return h_;
	}

    [CqlDeclaration("Diagnostic Report with status")]
	public bool? Diagnostic_Report_with_status() => 
		__Diagnostic_Report_with_status.Value;

	private bool? Numerator_Value()
	{
		var a_ = context.Operators;
		var b_ = this.Observation_with_status();
		var c_ = this.Diagnostic_Report_with_status();
		var d_ = a_.Or(b_, c_);

		return d_;
	}

    [CqlDeclaration("Numerator")]
	public bool? Numerator() => 
		__Numerator.Value;

	private bool? Final_Numerator_Population_Value()
	{
		var a_ = context.Operators;
		var d_ = this.Numerator();
		var e_ = this.Initial_Population();
		var f_ = a_.And(d_, e_);
		var g_ = this.Denominator();
		var h_ = a_.And(f_, g_);
		var j_ = this.Denominator_Exclusions();
		var k_ = a_.Not(j_);
		var l_ = a_.And(h_, k_);

		return l_;
	}

    [CqlDeclaration("Final Numerator Population")]
	public bool? Final_Numerator_Population() => 
		__Final_Numerator_Population.Value;

	private bool? Observation_without_appropriate_status_Value()
	{
		var a_ = context.Operators;
		var c_ = context.DataRetriever;
		var d_ = this.Mammography();
		var e_ = c_.RetrieveByValueSet<Observation>(d_, null);
		bool? f_(Observation Mammogram)
		{
			var i_ = context.Operators;
			var l_ = context.Deeper(new CallStackEntry("ToString", null, null));
			var m_ = l_.Operators;
			var n_ = m_.TypeConverter;
			var o_ = Mammogram?.StatusElement;
			var p_ = n_.Convert<string>(o_);
			var q_ = new string[]
			{
				"final",
				"amended",
				"corrected",
				"appended",
			};
			var r_ = i_.InList<string>(p_, (q_ as IEnumerable<string>));
			var s_ = i_.Not(r_);
			var w_ = Mammogram?.Effective;
			var x_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(w_);
			var y_ = i_.End(x_);
			var ac_ = this.Measurement_Period();
			var ad_ = i_.End(ac_);
			var af_ = i_.Quantity(27m, "months");
			var ag_ = i_.Subtract(ad_, af_);
			var aj_ = i_.End(ac_);
			var ak_ = i_.Interval(ag_, aj_, true, true);
			var al_ = i_.ElementInInterval<CqlDateTime>(y_, ak_, null);
			var ap_ = i_.End(ac_);
			var aq_ = i_.Not((bool?)(ap_ is null));
			var ar_ = i_.And(al_, aq_);
			var as_ = i_.And(s_, ar_);

			return as_;
		};
		var g_ = a_.WhereOrNull<Observation>(e_, f_);
		var h_ = a_.ExistsInList<Observation>(g_);

		return h_;
	}

    [CqlDeclaration("Observation without appropriate status")]
	public bool? Observation_without_appropriate_status() => 
		__Observation_without_appropriate_status.Value;

	private bool? Diagnostic_Report_without_appropriate_status_Value()
	{
		var a_ = context.Operators;
		var c_ = context.DataRetriever;
		var d_ = this.Mammography();
		var e_ = c_.RetrieveByValueSet<DiagnosticReport>(d_, null);
		bool? f_(DiagnosticReport Mammogram)
		{
			var i_ = context.Operators;
			var l_ = context.Deeper(new CallStackEntry("ToString", null, null));
			var m_ = l_.Operators;
			var n_ = m_.TypeConverter;
			var o_ = Mammogram?.StatusElement;
			var p_ = n_.Convert<string>(o_);
			var q_ = new string[]
			{
				"final",
				"amended",
				"corrected",
				"appended",
			};
			var r_ = i_.InList<string>(p_, (q_ as IEnumerable<string>));
			var s_ = i_.Not(r_);
			var w_ = Mammogram?.Effective;
			var x_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(w_);
			var y_ = i_.End(x_);
			var ac_ = this.Measurement_Period();
			var ad_ = i_.End(ac_);
			var af_ = i_.Quantity(27m, "months");
			var ag_ = i_.Subtract(ad_, af_);
			var aj_ = i_.End(ac_);
			var ak_ = i_.Interval(ag_, aj_, true, true);
			var al_ = i_.ElementInInterval<CqlDateTime>(y_, ak_, null);
			var ap_ = i_.End(ac_);
			var aq_ = i_.Not((bool?)(ap_ is null));
			var ar_ = i_.And(al_, aq_);
			var as_ = i_.And(s_, ar_);

			return as_;
		};
		var g_ = a_.WhereOrNull<DiagnosticReport>(e_, f_);
		var h_ = a_.ExistsInList<DiagnosticReport>(g_);

		return h_;
	}

    [CqlDeclaration("Diagnostic Report without appropriate status")]
	public bool? Diagnostic_Report_without_appropriate_status() => 
		__Diagnostic_Report_without_appropriate_status.Value;

}