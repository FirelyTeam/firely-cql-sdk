using System;
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
[CqlLibrary("Exam125FHIR", "0.0.009")]
public class Exam125FHIR_0_0_009
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
    public Exam125FHIR_0_0_009(CqlContext context)
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
		var a_ = context.Operators.DateTime((int?)2021, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, default);
		var b_ = context.Operators.DateTime((int?)2022, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, default);
		var c_ = context.Operators.Interval(a_, b_, true, false);
		var d_ = context.ResolveParameter("Exam125FHIR-0.0.009", "Measurement Period", c_);

		return (CqlInterval<CqlDateTime>)d_;
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
		var a_ = this.Online_Assessments();
		var b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);
		var c_ = this.Telephone_Visits();
		var d_ = context.Operators.RetrieveByValueSet<Encounter>(c_, null);
		var e_ = context.Operators.ListUnion<Encounter>(b_, d_);
		bool? f_(Encounter TelehealthEncounter)
		{
			var h_ = context.Operators.Convert<string>(TelehealthEncounter?.StatusElement);
			var i_ = context.Operators.Equal(h_, "finished");
			var j_ = this.Measurement_Period();
			var k_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval((TelehealthEncounter?.Period as object));
			var l_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(j_, k_, null);
			var m_ = context.Operators.And(i_, l_);

			return m_;
		};
		var g_ = context.Operators.WhereOrNull<Encounter>(e_, f_);

		return g_;
	}

    [CqlDeclaration("Telehealth Services")]
	public IEnumerable<Encounter> Telehealth_Services() => 
		__Telehealth_Services.Value;

	private int? Age_at_start_of_Measurement_Period_Value()
	{
		var a_ = this.Patient();
		var b_ = context.Operators.Convert<CqlDateTime>(a_?.BirthDateElement?.Value);
		var c_ = this.Measurement_Period();
		var d_ = context.Operators.Start(c_);
		var e_ = context.Operators.DateFrom(d_);
		var f_ = context.Operators.Convert<CqlDateTime>(e_);
		var g_ = context.Operators.CalculateAgeAt(b_, f_, "year");

		return g_;
	}

    [CqlDeclaration("Age at start of Measurement Period")]
	public int? Age_at_start_of_Measurement_Period() => 
		__Age_at_start_of_Measurement_Period.Value;

	private bool? Initial_Population_Value()
	{
		var a_ = this.Patient();
		var b_ = context.Operators.Convert<CqlDateTime>(a_?.BirthDateElement?.Value);
		var c_ = this.Measurement_Period();
		var d_ = context.Operators.Start(c_);
		var e_ = context.Operators.DateFrom(d_);
		var f_ = context.Operators.Convert<CqlDateTime>(e_);
		var g_ = context.Operators.CalculateAgeAt(b_, f_, "year");
		var h_ = context.Operators.Interval((int?)51, (int?)74, true, false);
		var i_ = context.Operators.ElementInInterval<int?>(g_, h_, null);
		var k_ = context.Operators.Convert<string>(a_?.GenderElement);
		var l_ = context.Operators.Equal(k_, "female");
		var m_ = context.Operators.And(i_, l_);
		var n_ = AdultOutpatientEncountersFHIR4_2_2_000.Qualifying_Encounters();
		var o_ = this.Telehealth_Services();
		var p_ = context.Operators.ListUnion<Encounter>(n_, o_);
		var q_ = context.Operators.ExistsInList<Encounter>(p_);
		var r_ = context.Operators.And(m_, q_);

		return r_;
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
		var a_ = this.Status_Post_Right_Mastectomy();
		var b_ = context.Operators.RetrieveByValueSet<Condition>(a_, null);
		var c_ = this.Unilateral_Mastectomy__Unspecified_Laterality();
		var d_ = context.Operators.RetrieveByValueSet<Condition>(c_, null);
		bool? e_(Condition UnilateralMastectomyDiagnosis)
		{
			CqlConcept j_(CodeableConcept X)
			{
				var n_ = FHIRHelpers_4_0_001.ToConcept(X);

				return n_;
			};
			var k_ = context.Operators.SelectOrNull<CodeableConcept, CqlConcept>((UnilateralMastectomyDiagnosis?.BodySite as IEnumerable<CodeableConcept>), j_);
			var l_ = this.Right();
			var m_ = context.Operators.ConceptsInValueSet(k_, l_);

			return m_;
		};
		var f_ = context.Operators.WhereOrNull<Condition>(d_, e_);
		var g_ = context.Operators.ListUnion<Condition>(b_, f_);
		bool? h_(Condition RightMastectomy)
		{
			var o_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Prevalence_Period(RightMastectomy);
			var p_ = context.Operators.Start(o_);
			var q_ = this.Measurement_Period();
			var r_ = context.Operators.End(q_);
			var s_ = context.Operators.SameOrBefore(p_, r_, null);

			return s_;
		};
		var i_ = context.Operators.WhereOrNull<Condition>(g_, h_);

		return i_;
	}

    [CqlDeclaration("Right Mastectomy Diagnosis")]
	public IEnumerable<Condition> Right_Mastectomy_Diagnosis() => 
		__Right_Mastectomy_Diagnosis.Value;

	private IEnumerable<Procedure> Right_Mastectomy_Procedure_Value()
	{
		var a_ = this.Unilateral_Mastectomy_Right();
		var b_ = context.Operators.RetrieveByValueSet<Procedure>(a_, null);
		bool? c_(Procedure UnilateralMastectomyRightPerformed)
		{
			var e_ = context.Operators.Convert<string>(UnilateralMastectomyRightPerformed?.StatusElement);
			var f_ = context.Operators.Equal(e_, "completed");
			var g_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(UnilateralMastectomyRightPerformed?.Performed);
			var h_ = context.Operators.End(g_);
			var i_ = this.Measurement_Period();
			var j_ = context.Operators.End(i_);
			var k_ = context.Operators.SameOrBefore(h_, j_, null);
			var l_ = context.Operators.And(f_, k_);

			return l_;
		};
		var d_ = context.Operators.WhereOrNull<Procedure>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Right Mastectomy Procedure")]
	public IEnumerable<Procedure> Right_Mastectomy_Procedure() => 
		__Right_Mastectomy_Procedure.Value;

	private IEnumerable<Condition> Left_Mastectomy_Diagnosis_Value()
	{
		var a_ = this.Status_Post_Left_Mastectomy();
		var b_ = context.Operators.RetrieveByValueSet<Condition>(a_, null);
		var c_ = this.Unilateral_Mastectomy__Unspecified_Laterality();
		var d_ = context.Operators.RetrieveByValueSet<Condition>(c_, null);
		bool? e_(Condition UnilateralMastectomyDiagnosis)
		{
			CqlConcept j_(CodeableConcept X)
			{
				var n_ = FHIRHelpers_4_0_001.ToConcept(X);

				return n_;
			};
			var k_ = context.Operators.SelectOrNull<CodeableConcept, CqlConcept>((UnilateralMastectomyDiagnosis?.BodySite as IEnumerable<CodeableConcept>), j_);
			var l_ = this.Left();
			var m_ = context.Operators.ConceptsInValueSet(k_, l_);

			return m_;
		};
		var f_ = context.Operators.WhereOrNull<Condition>(d_, e_);
		var g_ = context.Operators.ListUnion<Condition>(b_, f_);
		bool? h_(Condition LeftMastectomy)
		{
			var o_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Prevalence_Period(LeftMastectomy);
			var p_ = context.Operators.Start(o_);
			var q_ = this.Measurement_Period();
			var r_ = context.Operators.End(q_);
			var s_ = context.Operators.SameOrBefore(p_, r_, null);

			return s_;
		};
		var i_ = context.Operators.WhereOrNull<Condition>(g_, h_);

		return i_;
	}

    [CqlDeclaration("Left Mastectomy Diagnosis")]
	public IEnumerable<Condition> Left_Mastectomy_Diagnosis() => 
		__Left_Mastectomy_Diagnosis.Value;

	private IEnumerable<Procedure> Left_Mastectomy_Procedure_Value()
	{
		var a_ = this.Unilateral_Mastectomy_Left();
		var b_ = context.Operators.RetrieveByValueSet<Procedure>(a_, null);
		bool? c_(Procedure UnilateralMastectomyLeftPerformed)
		{
			var e_ = context.Operators.Convert<string>(UnilateralMastectomyLeftPerformed?.StatusElement);
			var f_ = context.Operators.Equal(e_, "completed");
			var g_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(UnilateralMastectomyLeftPerformed?.Performed);
			var h_ = context.Operators.End(g_);
			var i_ = this.Measurement_Period();
			var j_ = context.Operators.End(i_);
			var k_ = context.Operators.SameOrBefore(h_, j_, null);
			var l_ = context.Operators.And(f_, k_);

			return l_;
		};
		var d_ = context.Operators.WhereOrNull<Procedure>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Left Mastectomy Procedure")]
	public IEnumerable<Procedure> Left_Mastectomy_Procedure() => 
		__Left_Mastectomy_Procedure.Value;

	private IEnumerable<Condition> Bilateral_Mastectomy_Diagnosis_Value()
	{
		var a_ = this.History_of_bilateral_mastectomy();
		var b_ = context.Operators.RetrieveByValueSet<Condition>(a_, null);
		bool? c_(Condition BilateralMastectomyHistory)
		{
			var e_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Prevalence_Period(BilateralMastectomyHistory);
			var f_ = context.Operators.Start(e_);
			var g_ = this.Measurement_Period();
			var h_ = context.Operators.End(g_);
			var i_ = context.Operators.SameOrBefore(f_, h_, null);

			return i_;
		};
		var d_ = context.Operators.WhereOrNull<Condition>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Bilateral Mastectomy Diagnosis")]
	public IEnumerable<Condition> Bilateral_Mastectomy_Diagnosis() => 
		__Bilateral_Mastectomy_Diagnosis.Value;

	private IEnumerable<Procedure> Bilateral_Mastectomy_Procedure_Value()
	{
		var a_ = this.Bilateral_Mastectomy();
		var b_ = context.Operators.RetrieveByValueSet<Procedure>(a_, null);
		bool? c_(Procedure BilateralMastectomyPerformed)
		{
			var e_ = context.Operators.Convert<string>(BilateralMastectomyPerformed?.StatusElement);
			var f_ = context.Operators.Equal(e_, "completed");
			var g_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(BilateralMastectomyPerformed?.Performed);
			var h_ = context.Operators.End(g_);
			var i_ = this.Measurement_Period();
			var j_ = context.Operators.End(i_);
			var k_ = context.Operators.SameOrBefore(h_, j_, null);
			var l_ = context.Operators.And(f_, k_);

			return l_;
		};
		var d_ = context.Operators.WhereOrNull<Procedure>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Bilateral Mastectomy Procedure")]
	public IEnumerable<Procedure> Bilateral_Mastectomy_Procedure() => 
		__Bilateral_Mastectomy_Procedure.Value;

	private bool? Denominator_Exclusions_Value()
	{
		var a_ = HospiceFHIR4_2_3_000.Has_Hospice();
		var b_ = this.Right_Mastectomy_Diagnosis();
		var c_ = context.Operators.ExistsInList<Condition>(b_);
		var d_ = this.Right_Mastectomy_Procedure();
		var e_ = context.Operators.ExistsInList<Procedure>(d_);
		var f_ = context.Operators.Or(c_, e_);
		var g_ = this.Left_Mastectomy_Diagnosis();
		var h_ = context.Operators.ExistsInList<Condition>(g_);
		var i_ = this.Left_Mastectomy_Procedure();
		var j_ = context.Operators.ExistsInList<Procedure>(i_);
		var k_ = context.Operators.Or(h_, j_);
		var l_ = context.Operators.And(f_, k_);
		var m_ = context.Operators.Or(a_, l_);
		var n_ = this.Bilateral_Mastectomy_Diagnosis();
		var o_ = context.Operators.ExistsInList<Condition>(n_);
		var p_ = context.Operators.Or(m_, o_);
		var q_ = this.Bilateral_Mastectomy_Procedure();
		var r_ = context.Operators.ExistsInList<Procedure>(q_);
		var s_ = context.Operators.Or(p_, r_);
		var t_ = AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000.Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80();
		var u_ = context.Operators.Or(s_, t_);
		var v_ = this.Patient();
		var w_ = context.Operators.Convert<CqlDateTime>(v_?.BirthDateElement?.Value);
		var x_ = this.Measurement_Period();
		var y_ = context.Operators.Start(x_);
		var z_ = context.Operators.DateFrom(y_);
		var aa_ = context.Operators.Convert<CqlDateTime>(z_);
		var ab_ = context.Operators.CalculateAgeAt(w_, aa_, "year");
		var ac_ = context.Operators.GreaterOrEqual(ab_, (int?)65);
		var ad_ = AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000.Has_Long_Term_Care_Periods_Longer_Than_90_Consecutive_Days();
		var ae_ = context.Operators.And(ac_, ad_);
		var af_ = context.Operators.Or(u_, ae_);
		var ag_ = PalliativeCareFHIR_0_6_000.Palliative_Care_in_the_Measurement_Period();
		var ah_ = context.Operators.Or(af_, ag_);

		return ah_;
	}

    [CqlDeclaration("Denominator Exclusions")]
	public bool? Denominator_Exclusions() => 
		__Denominator_Exclusions.Value;

	private bool? Observation_with_status_Value()
	{
		var a_ = this.Mammography();
		var b_ = context.Operators.RetrieveByValueSet<Observation>(a_, null);
		bool? c_(Observation Mammogram)
		{
			var f_ = context.Operators.Convert<string>(Mammogram?.StatusElement);
			var g_ = new string[]
			{
				"final",
				"amended",
				"corrected",
				"appended",
			};
			var h_ = context.Operators.InList<string>(f_, (g_ as IEnumerable<string>));
			var i_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(Mammogram?.Effective);
			var j_ = context.Operators.End(i_);
			var k_ = this.Measurement_Period();
			var l_ = context.Operators.End(k_);
			var m_ = context.Operators.Quantity((decimal?)27m, "months");
			var n_ = context.Operators.Subtract(l_, m_);
			var p_ = context.Operators.End(k_);
			var q_ = context.Operators.Interval(n_, p_, true, true);
			var r_ = context.Operators.ElementInInterval<CqlDateTime>(j_, q_, null);
			var t_ = context.Operators.End(k_);
			var u_ = context.Operators.Not((bool?)(t_ is null));
			var v_ = context.Operators.And(r_, u_);
			var w_ = context.Operators.And(h_, v_);

			return w_;
		};
		var d_ = context.Operators.WhereOrNull<Observation>(b_, c_);
		var e_ = context.Operators.ExistsInList<Observation>(d_);

		return e_;
	}

    [CqlDeclaration("Observation with status")]
	public bool? Observation_with_status() => 
		__Observation_with_status.Value;

	private bool? Diagnostic_Report_with_status_Value()
	{
		var a_ = this.Mammography();
		var b_ = context.Operators.RetrieveByValueSet<DiagnosticReport>(a_, null);
		bool? c_(DiagnosticReport Mammogram)
		{
			var f_ = context.Operators.Convert<string>(Mammogram?.StatusElement);
			var g_ = new string[]
			{
				"final",
				"amended",
				"corrected",
				"appended",
			};
			var h_ = context.Operators.InList<string>(f_, (g_ as IEnumerable<string>));
			var i_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(Mammogram?.Effective);
			var j_ = context.Operators.End(i_);
			var k_ = this.Measurement_Period();
			var l_ = context.Operators.End(k_);
			var m_ = context.Operators.Quantity((decimal?)27m, "months");
			var n_ = context.Operators.Subtract(l_, m_);
			var p_ = context.Operators.End(k_);
			var q_ = context.Operators.Interval(n_, p_, true, true);
			var r_ = context.Operators.ElementInInterval<CqlDateTime>(j_, q_, null);
			var t_ = context.Operators.End(k_);
			var u_ = context.Operators.Not((bool?)(t_ is null));
			var v_ = context.Operators.And(r_, u_);
			var w_ = context.Operators.And(h_, v_);

			return w_;
		};
		var d_ = context.Operators.WhereOrNull<DiagnosticReport>(b_, c_);
		var e_ = context.Operators.ExistsInList<DiagnosticReport>(d_);

		return e_;
	}

    [CqlDeclaration("Diagnostic Report with status")]
	public bool? Diagnostic_Report_with_status() => 
		__Diagnostic_Report_with_status.Value;

	private bool? Numerator_Value()
	{
		var a_ = this.Observation_with_status();
		var b_ = this.Diagnostic_Report_with_status();
		var c_ = context.Operators.Or(a_, b_);

		return c_;
	}

    [CqlDeclaration("Numerator")]
	public bool? Numerator() => 
		__Numerator.Value;

	private bool? Final_Numerator_Population_Value()
	{
		var a_ = this.Numerator();
		var b_ = this.Initial_Population();
		var c_ = context.Operators.And(a_, b_);
		var d_ = this.Denominator();
		var e_ = context.Operators.And(c_, d_);
		var f_ = this.Denominator_Exclusions();
		var g_ = context.Operators.Not(f_);
		var h_ = context.Operators.And(e_, g_);

		return h_;
	}

    [CqlDeclaration("Final Numerator Population")]
	public bool? Final_Numerator_Population() => 
		__Final_Numerator_Population.Value;

	private bool? Observation_without_appropriate_status_Value()
	{
		var a_ = this.Mammography();
		var b_ = context.Operators.RetrieveByValueSet<Observation>(a_, null);
		bool? c_(Observation Mammogram)
		{
			var f_ = context.Operators.Convert<string>(Mammogram?.StatusElement);
			var g_ = new string[]
			{
				"final",
				"amended",
				"corrected",
				"appended",
			};
			var h_ = context.Operators.InList<string>(f_, (g_ as IEnumerable<string>));
			var i_ = context.Operators.Not(h_);
			var j_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(Mammogram?.Effective);
			var k_ = context.Operators.End(j_);
			var l_ = this.Measurement_Period();
			var m_ = context.Operators.End(l_);
			var n_ = context.Operators.Quantity((decimal?)27m, "months");
			var o_ = context.Operators.Subtract(m_, n_);
			var q_ = context.Operators.End(l_);
			var r_ = context.Operators.Interval(o_, q_, true, true);
			var s_ = context.Operators.ElementInInterval<CqlDateTime>(k_, r_, null);
			var u_ = context.Operators.End(l_);
			var v_ = context.Operators.Not((bool?)(u_ is null));
			var w_ = context.Operators.And(s_, v_);
			var x_ = context.Operators.And(i_, w_);

			return x_;
		};
		var d_ = context.Operators.WhereOrNull<Observation>(b_, c_);
		var e_ = context.Operators.ExistsInList<Observation>(d_);

		return e_;
	}

    [CqlDeclaration("Observation without appropriate status")]
	public bool? Observation_without_appropriate_status() => 
		__Observation_without_appropriate_status.Value;

	private bool? Diagnostic_Report_without_appropriate_status_Value()
	{
		var a_ = this.Mammography();
		var b_ = context.Operators.RetrieveByValueSet<DiagnosticReport>(a_, null);
		bool? c_(DiagnosticReport Mammogram)
		{
			var f_ = context.Operators.Convert<string>(Mammogram?.StatusElement);
			var g_ = new string[]
			{
				"final",
				"amended",
				"corrected",
				"appended",
			};
			var h_ = context.Operators.InList<string>(f_, (g_ as IEnumerable<string>));
			var i_ = context.Operators.Not(h_);
			var j_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(Mammogram?.Effective);
			var k_ = context.Operators.End(j_);
			var l_ = this.Measurement_Period();
			var m_ = context.Operators.End(l_);
			var n_ = context.Operators.Quantity((decimal?)27m, "months");
			var o_ = context.Operators.Subtract(m_, n_);
			var q_ = context.Operators.End(l_);
			var r_ = context.Operators.Interval(o_, q_, true, true);
			var s_ = context.Operators.ElementInInterval<CqlDateTime>(k_, r_, null);
			var u_ = context.Operators.End(l_);
			var v_ = context.Operators.Not((bool?)(u_ is null));
			var w_ = context.Operators.And(s_, v_);
			var x_ = context.Operators.And(i_, w_);

			return x_;
		};
		var d_ = context.Operators.WhereOrNull<DiagnosticReport>(b_, c_);
		var e_ = context.Operators.ExistsInList<DiagnosticReport>(d_);

		return e_;
	}

    [CqlDeclaration("Diagnostic Report without appropriate status")]
	public bool? Diagnostic_Report_without_appropriate_status() => 
		__Diagnostic_Report_without_appropriate_status.Value;

}
