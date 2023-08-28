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
    public CqlValueSet Bilateral_Mastectomy() => __Bilateral_Mastectomy.Value;

    private CqlValueSet History_of_bilateral_mastectomy_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1068", null);

    [CqlDeclaration("History of bilateral mastectomy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1068")]
    public CqlValueSet History_of_bilateral_mastectomy() => __History_of_bilateral_mastectomy.Value;

    private CqlValueSet Left_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.122.12.1036", null);

    [CqlDeclaration("Left")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.122.12.1036")]
    public CqlValueSet Left() => __Left.Value;

    private CqlValueSet Mammography_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.11.1047", null);

    [CqlDeclaration("Mammography")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.11.1047")]
    public CqlValueSet Mammography() => __Mammography.Value;

    private CqlValueSet Online_Assessments_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", null);

    [CqlDeclaration("Online Assessments")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089")]
    public CqlValueSet Online_Assessments() => __Online_Assessments.Value;

    private CqlValueSet Right_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.122.12.1035", null);

    [CqlDeclaration("Right")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.122.12.1035")]
    public CqlValueSet Right() => __Right.Value;

    private CqlValueSet Status_Post_Left_Mastectomy_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1069", null);

    [CqlDeclaration("Status Post Left Mastectomy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1069")]
    public CqlValueSet Status_Post_Left_Mastectomy() => __Status_Post_Left_Mastectomy.Value;

    private CqlValueSet Status_Post_Right_Mastectomy_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1070", null);

    [CqlDeclaration("Status Post Right Mastectomy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1070")]
    public CqlValueSet Status_Post_Right_Mastectomy() => __Status_Post_Right_Mastectomy.Value;

    private CqlValueSet Telephone_Visits_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", null);

    [CqlDeclaration("Telephone Visits")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080")]
    public CqlValueSet Telephone_Visits() => __Telephone_Visits.Value;

    private CqlValueSet Unilateral_Mastectomy_Left_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1133", null);

    [CqlDeclaration("Unilateral Mastectomy Left")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1133")]
    public CqlValueSet Unilateral_Mastectomy_Left() => __Unilateral_Mastectomy_Left.Value;

    private CqlValueSet Unilateral_Mastectomy_Right_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1134", null);

    [CqlDeclaration("Unilateral Mastectomy Right")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1134")]
    public CqlValueSet Unilateral_Mastectomy_Right() => __Unilateral_Mastectomy_Right.Value;

    private CqlValueSet Unilateral_Mastectomy__Unspecified_Laterality_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1071", null);

    [CqlDeclaration("Unilateral Mastectomy, Unspecified Laterality")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1071")]
    public CqlValueSet Unilateral_Mastectomy__Unspecified_Laterality() => __Unilateral_Mastectomy__Unspecified_Laterality.Value;

    private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		var a_ = context.Operators;
		var b_ = a_.ConvertIntegerToDecimal(default);
		var d_ = a_.DateTime((int?)2021, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, b_);
		var f_ = a_.ConvertIntegerToDecimal(default);
		var h_ = a_.DateTime((int?)2022, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, f_);
		var j_ = a_.Interval(d_, h_, true, false);
		var k_ = context.ResolveParameter("BreastCancerScreeningsFHIR-0.0.009", "Measurement Period", j_);

		return (CqlInterval<CqlDateTime>)k_;
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

    private IEnumerable<Encounter> Telehealth_Services_Value()
	{
		var a_ = this.Online_Assessments();
		var b_ = context.DataRetriever;
		var c_ = b_.RetrieveByValueSet<Encounter>(a_, null);
		var d_ = this.Telephone_Visits();
		var f_ = b_.RetrieveByValueSet<Encounter>(d_, null);
		var g_ = context.Operators;
		var h_ = g_.ListUnion<Encounter>(c_, f_);
		bool? i_(Encounter TelehealthEncounter)
		{
			var l_ = TelehealthEncounter.StatusElement;
			var m_ = new CallStackEntry("ToString", null, null);
			var n_ = context.Deeper(m_);
			var o_ = n_.Operators;
			var p_ = o_.TypeConverter;
			var q_ = p_.Convert<string>(l_);
			var r_ = context.Operators;
			var s_ = r_.Equal(q_, "finished");
			var t_ = this.Measurement_Period();
			var u_ = TelehealthEncounter.Period;
			var v_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(u_);
			var x_ = r_.IntervalIncludesInterval<CqlDateTime>(t_, v_, null);
			var z_ = r_.And(s_, x_);

			return z_;
		};
		var k_ = g_.WhereOrNull<Encounter>(h_, i_);

		return k_;
	}

    [CqlDeclaration("Telehealth Services")]
    public IEnumerable<Encounter> Telehealth_Services() => __Telehealth_Services.Value;

    private int? Age_at_start_of_Measurement_Period_Value()
	{
		var a_ = this.Patient();
		var b_ = a_.BirthDateElement;
		var c_ = b_.Value;
		var d_ = context.Operators;
		var e_ = d_.TypeConverter;
		var f_ = e_.Convert<CqlDate>(c_);
		var g_ = this.Measurement_Period();
		var i_ = d_.Start(g_);
		var k_ = d_.DateFrom(i_);
		var m_ = d_.CalculateAgeAt(f_, k_, "year");

		return m_;
	}

    [CqlDeclaration("Age at start of Measurement Period")]
    public int? Age_at_start_of_Measurement_Period() => __Age_at_start_of_Measurement_Period.Value;

    private bool? Initial_Population_Value()
	{
		var a_ = this.Patient();
		var b_ = a_.BirthDateElement;
		var c_ = b_.Value;
		var d_ = context.Operators;
		var e_ = d_.TypeConverter;
		var f_ = e_.Convert<CqlDate>(c_);
		var g_ = this.Measurement_Period();
		var i_ = d_.Start(g_);
		var k_ = d_.DateFrom(i_);
		var m_ = d_.CalculateAgeAt(f_, k_, "year");
		var o_ = d_.Interval((int?)51, (int?)74, true, false);
		var q_ = d_.ElementInInterval<int?>(m_, o_, null);
		var s_ = a_.GenderElement;
		var t_ = new CallStackEntry("ToString", null, null);
		var u_ = context.Deeper(t_);
		var v_ = u_.Operators;
		var w_ = v_.TypeConverter;
		var x_ = w_.Convert<string>(s_);
		var z_ = d_.Equal(x_, "female");
		var ab_ = d_.And(q_, z_);
		var ac_ = AdultOutpatientEncountersFHIR4_2_2_000.Qualifying_Encounters();
		var ad_ = this.Telehealth_Services();
		var af_ = d_.ListUnion<Encounter>(ac_, ad_);
		var ah_ = d_.ExistsInList<Encounter>(af_);
		var aj_ = d_.And(ab_, ah_);

		return aj_;
	}

    [CqlDeclaration("Initial Population")]
    public bool? Initial_Population() => __Initial_Population.Value;

    private bool? Denominator_Value()
	{
		var a_ = this.Initial_Population();

		return a_;
	}

    [CqlDeclaration("Denominator")]
    public bool? Denominator() => __Denominator.Value;

    private IEnumerable<Condition> Right_Mastectomy_Diagnosis_Value()
	{
		var a_ = this.Status_Post_Right_Mastectomy();
		var b_ = context.DataRetriever;
		var c_ = b_.RetrieveByValueSet<Condition>(a_, null);
		var d_ = this.Unilateral_Mastectomy__Unspecified_Laterality();
		var f_ = b_.RetrieveByValueSet<Condition>(d_, null);
		bool? g_(Condition UnilateralMastectomyDiagnosis)
		{
			var o_ = UnilateralMastectomyDiagnosis.BodySite;
			CqlConcept p_(CodeableConcept X)
			{
				var v_ = FHIRHelpers_4_0_001.ToConcept(X);

				return v_;
			};
			var q_ = context.Operators;
			var r_ = q_.SelectOrNull<CodeableConcept, CqlConcept>((o_ as IEnumerable<CodeableConcept>), p_);
			var s_ = this.Right();
			var u_ = q_.ConceptsInValueSet(r_, s_);

			return u_;
		};
		var h_ = context.Operators;
		var i_ = h_.WhereOrNull<Condition>(f_, g_);
		var k_ = h_.ListUnion<Condition>(c_, i_);
		bool? l_(Condition RightMastectomy)
		{
			var w_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Prevalence_Period(RightMastectomy);
			var x_ = context.Operators;
			var y_ = x_.Start(w_);
			var z_ = this.Measurement_Period();
			var ab_ = x_.End(z_);
			var ad_ = x_.SameOrBefore(y_, ab_, null);

			return ad_;
		};
		var n_ = h_.WhereOrNull<Condition>(k_, l_);

		return n_;
	}

    [CqlDeclaration("Right Mastectomy Diagnosis")]
    public IEnumerable<Condition> Right_Mastectomy_Diagnosis() => __Right_Mastectomy_Diagnosis.Value;

    private IEnumerable<Procedure> Right_Mastectomy_Procedure_Value()
	{
		var a_ = this.Unilateral_Mastectomy_Right();
		var b_ = context.DataRetriever;
		var c_ = b_.RetrieveByValueSet<Procedure>(a_, null);
		bool? d_(Procedure UnilateralMastectomyRightPerformed)
		{
			var g_ = UnilateralMastectomyRightPerformed.StatusElement;
			var h_ = new CallStackEntry("ToString", null, null);
			var i_ = context.Deeper(h_);
			var j_ = i_.Operators;
			var k_ = j_.TypeConverter;
			var l_ = k_.Convert<string>(g_);
			var m_ = context.Operators;
			var n_ = m_.Equal(l_, "completed");
			var o_ = UnilateralMastectomyRightPerformed.Performed;
			var p_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(o_);
			var r_ = m_.End(p_);
			var s_ = this.Measurement_Period();
			var u_ = m_.End(s_);
			var w_ = m_.SameOrBefore(r_, u_, null);
			var y_ = m_.And(n_, w_);

			return y_;
		};
		var e_ = context.Operators;
		var f_ = e_.WhereOrNull<Procedure>(c_, d_);

		return f_;
	}

    [CqlDeclaration("Right Mastectomy Procedure")]
    public IEnumerable<Procedure> Right_Mastectomy_Procedure() => __Right_Mastectomy_Procedure.Value;

    private IEnumerable<Condition> Left_Mastectomy_Diagnosis_Value()
	{
		var a_ = this.Status_Post_Left_Mastectomy();
		var b_ = context.DataRetriever;
		var c_ = b_.RetrieveByValueSet<Condition>(a_, null);
		var d_ = this.Unilateral_Mastectomy__Unspecified_Laterality();
		var f_ = b_.RetrieveByValueSet<Condition>(d_, null);
		bool? g_(Condition UnilateralMastectomyDiagnosis)
		{
			var o_ = UnilateralMastectomyDiagnosis.BodySite;
			CqlConcept p_(CodeableConcept X)
			{
				var v_ = FHIRHelpers_4_0_001.ToConcept(X);

				return v_;
			};
			var q_ = context.Operators;
			var r_ = q_.SelectOrNull<CodeableConcept, CqlConcept>((o_ as IEnumerable<CodeableConcept>), p_);
			var s_ = this.Left();
			var u_ = q_.ConceptsInValueSet(r_, s_);

			return u_;
		};
		var h_ = context.Operators;
		var i_ = h_.WhereOrNull<Condition>(f_, g_);
		var k_ = h_.ListUnion<Condition>(c_, i_);
		bool? l_(Condition LeftMastectomy)
		{
			var w_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Prevalence_Period(LeftMastectomy);
			var x_ = context.Operators;
			var y_ = x_.Start(w_);
			var z_ = this.Measurement_Period();
			var ab_ = x_.End(z_);
			var ad_ = x_.SameOrBefore(y_, ab_, null);

			return ad_;
		};
		var n_ = h_.WhereOrNull<Condition>(k_, l_);

		return n_;
	}

    [CqlDeclaration("Left Mastectomy Diagnosis")]
    public IEnumerable<Condition> Left_Mastectomy_Diagnosis() => __Left_Mastectomy_Diagnosis.Value;

    private IEnumerable<Procedure> Left_Mastectomy_Procedure_Value()
	{
		var a_ = this.Unilateral_Mastectomy_Left();
		var b_ = context.DataRetriever;
		var c_ = b_.RetrieveByValueSet<Procedure>(a_, null);
		bool? d_(Procedure UnilateralMastectomyLeftPerformed)
		{
			var g_ = UnilateralMastectomyLeftPerformed.StatusElement;
			var h_ = new CallStackEntry("ToString", null, null);
			var i_ = context.Deeper(h_);
			var j_ = i_.Operators;
			var k_ = j_.TypeConverter;
			var l_ = k_.Convert<string>(g_);
			var m_ = context.Operators;
			var n_ = m_.Equal(l_, "completed");
			var o_ = UnilateralMastectomyLeftPerformed.Performed;
			var p_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(o_);
			var r_ = m_.End(p_);
			var s_ = this.Measurement_Period();
			var u_ = m_.End(s_);
			var w_ = m_.SameOrBefore(r_, u_, null);
			var y_ = m_.And(n_, w_);

			return y_;
		};
		var e_ = context.Operators;
		var f_ = e_.WhereOrNull<Procedure>(c_, d_);

		return f_;
	}

    [CqlDeclaration("Left Mastectomy Procedure")]
    public IEnumerable<Procedure> Left_Mastectomy_Procedure() => __Left_Mastectomy_Procedure.Value;

    private IEnumerable<Condition> Bilateral_Mastectomy_Diagnosis_Value()
	{
		var a_ = this.History_of_bilateral_mastectomy();
		var b_ = context.DataRetriever;
		var c_ = b_.RetrieveByValueSet<Condition>(a_, null);
		bool? d_(Condition BilateralMastectomyHistory)
		{
			var g_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Prevalence_Period(BilateralMastectomyHistory);
			var h_ = context.Operators;
			var i_ = h_.Start(g_);
			var j_ = this.Measurement_Period();
			var l_ = h_.End(j_);
			var n_ = h_.SameOrBefore(i_, l_, null);

			return n_;
		};
		var e_ = context.Operators;
		var f_ = e_.WhereOrNull<Condition>(c_, d_);

		return f_;
	}

    [CqlDeclaration("Bilateral Mastectomy Diagnosis")]
    public IEnumerable<Condition> Bilateral_Mastectomy_Diagnosis() => __Bilateral_Mastectomy_Diagnosis.Value;

    private IEnumerable<Procedure> Bilateral_Mastectomy_Procedure_Value()
	{
		var a_ = this.Bilateral_Mastectomy();
		var b_ = context.DataRetriever;
		var c_ = b_.RetrieveByValueSet<Procedure>(a_, null);
		bool? d_(Procedure BilateralMastectomyPerformed)
		{
			var g_ = BilateralMastectomyPerformed.StatusElement;
			var h_ = new CallStackEntry("ToString", null, null);
			var i_ = context.Deeper(h_);
			var j_ = i_.Operators;
			var k_ = j_.TypeConverter;
			var l_ = k_.Convert<string>(g_);
			var m_ = context.Operators;
			var n_ = m_.Equal(l_, "completed");
			var o_ = BilateralMastectomyPerformed.Performed;
			var p_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(o_);
			var r_ = m_.End(p_);
			var s_ = this.Measurement_Period();
			var u_ = m_.End(s_);
			var w_ = m_.SameOrBefore(r_, u_, null);
			var y_ = m_.And(n_, w_);

			return y_;
		};
		var e_ = context.Operators;
		var f_ = e_.WhereOrNull<Procedure>(c_, d_);

		return f_;
	}

    [CqlDeclaration("Bilateral Mastectomy Procedure")]
    public IEnumerable<Procedure> Bilateral_Mastectomy_Procedure() => __Bilateral_Mastectomy_Procedure.Value;

    private bool? Denominator_Exclusions_Value()
	{
		var a_ = HospiceFHIR4_2_3_000.Has_Hospice();
		var b_ = this.Right_Mastectomy_Diagnosis();
		var c_ = context.Operators;
		var d_ = c_.ExistsInList<Condition>(b_);
		var e_ = this.Right_Mastectomy_Procedure();
		var g_ = c_.ExistsInList<Procedure>(e_);
		var i_ = c_.Or(d_, g_);
		var j_ = this.Left_Mastectomy_Diagnosis();
		var l_ = c_.ExistsInList<Condition>(j_);
		var m_ = this.Left_Mastectomy_Procedure();
		var o_ = c_.ExistsInList<Procedure>(m_);
		var q_ = c_.Or(l_, o_);
		var s_ = c_.And(i_, q_);
		var u_ = c_.Or(a_, s_);
		var v_ = this.Bilateral_Mastectomy_Diagnosis();
		var x_ = c_.ExistsInList<Condition>(v_);
		var z_ = c_.Or(u_, x_);
		var aa_ = this.Bilateral_Mastectomy_Procedure();
		var ac_ = c_.ExistsInList<Procedure>(aa_);
		var ae_ = c_.Or(z_, ac_);
		var af_ = AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000.Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80();
		var ah_ = c_.Or(ae_, af_);
		var ai_ = this.Patient();
		var aj_ = ai_.BirthDateElement;
		var ak_ = aj_.Value;
		var am_ = c_.TypeConverter;
		var an_ = am_.Convert<CqlDate>(ak_);
		var ao_ = this.Measurement_Period();
		var aq_ = c_.Start(ao_);
		var as_ = c_.DateFrom(aq_);
		var au_ = c_.CalculateAgeAt(an_, as_, "year");
		var aw_ = c_.GreaterOrEqual(au_, (int?)65);
		var ax_ = AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000.Has_Long_Term_Care_Periods_Longer_Than_90_Consecutive_Days();
		var az_ = c_.And(aw_, ax_);
		var bb_ = c_.Or(ah_, az_);
		var bc_ = PalliativeCareFHIR_0_6_000.Palliative_Care_in_the_Measurement_Period();
		var be_ = c_.Or(bb_, bc_);

		return be_;
	}

    [CqlDeclaration("Denominator Exclusions")]
    public bool? Denominator_Exclusions() => __Denominator_Exclusions.Value;

    private bool? Observation_with_status_Value()
	{
		var a_ = this.Mammography();
		var b_ = context.DataRetriever;
		var c_ = b_.RetrieveByValueSet<Observation>(a_, null);
		bool? d_(Observation Mammogram)
		{
			var i_ = Mammogram.StatusElement;
			var j_ = new CallStackEntry("ToString", null, null);
			var k_ = context.Deeper(j_);
			var l_ = k_.Operators;
			var m_ = l_.TypeConverter;
			var n_ = m_.Convert<string>(i_);
			var o_ = new string[]
			{
				"final",
				"amended",
				"corrected",
				"appended",
			};
			var p_ = context.Operators;
			var q_ = p_.InList<string>(n_, (o_ as IEnumerable<string>));
			var r_ = Mammogram.Effective;
			var s_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(r_);
			var u_ = p_.End(s_);
			var v_ = this.Measurement_Period();
			var x_ = p_.End(v_);
			var z_ = p_.Quantity(27m, "months");
			var ab_ = p_.Subtract(x_, z_);
			var ae_ = p_.End(v_);
			var ag_ = p_.Interval(ab_, ae_, true, true);
			var ai_ = p_.ElementInInterval<CqlDateTime>(u_, ag_, null);
			var al_ = p_.End(v_);
			var am_ = (al_ == null);
			var ao_ = p_.Not((bool?)am_);
			var aq_ = p_.And(ai_, ao_);
			var as_ = p_.And(q_, aq_);

			return as_;
		};
		var e_ = context.Operators;
		var f_ = e_.WhereOrNull<Observation>(c_, d_);
		var h_ = e_.ExistsInList<Observation>(f_);

		return h_;
	}

    [CqlDeclaration("Observation with status")]
    public bool? Observation_with_status() => __Observation_with_status.Value;

    private bool? Diagnostic_Report_with_status_Value()
	{
		var a_ = this.Mammography();
		var b_ = context.DataRetriever;
		var c_ = b_.RetrieveByValueSet<DiagnosticReport>(a_, null);
		bool? d_(DiagnosticReport Mammogram)
		{
			var i_ = Mammogram.StatusElement;
			var j_ = new CallStackEntry("ToString", null, null);
			var k_ = context.Deeper(j_);
			var l_ = k_.Operators;
			var m_ = l_.TypeConverter;
			var n_ = m_.Convert<string>(i_);
			var o_ = new string[]
			{
				"final",
				"amended",
				"corrected",
				"appended",
			};
			var p_ = context.Operators;
			var q_ = p_.InList<string>(n_, (o_ as IEnumerable<string>));
			var r_ = Mammogram.Effective;
			var s_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(r_);
			var u_ = p_.End(s_);
			var v_ = this.Measurement_Period();
			var x_ = p_.End(v_);
			var z_ = p_.Quantity(27m, "months");
			var ab_ = p_.Subtract(x_, z_);
			var ae_ = p_.End(v_);
			var ag_ = p_.Interval(ab_, ae_, true, true);
			var ai_ = p_.ElementInInterval<CqlDateTime>(u_, ag_, null);
			var al_ = p_.End(v_);
			var am_ = (al_ == null);
			var ao_ = p_.Not((bool?)am_);
			var aq_ = p_.And(ai_, ao_);
			var as_ = p_.And(q_, aq_);

			return as_;
		};
		var e_ = context.Operators;
		var f_ = e_.WhereOrNull<DiagnosticReport>(c_, d_);
		var h_ = e_.ExistsInList<DiagnosticReport>(f_);

		return h_;
	}

    [CqlDeclaration("Diagnostic Report with status")]
    public bool? Diagnostic_Report_with_status() => __Diagnostic_Report_with_status.Value;

    private bool? Numerator_Value()
	{
		var a_ = this.Observation_with_status();
		var b_ = this.Diagnostic_Report_with_status();
		var c_ = context.Operators;
		var d_ = c_.Or(a_, b_);

		return d_;
	}

    [CqlDeclaration("Numerator")]
    public bool? Numerator() => __Numerator.Value;

    private bool? Final_Numerator_Population_Value()
	{
		var a_ = this.Numerator();
		var b_ = this.Initial_Population();
		var c_ = context.Operators;
		var d_ = c_.And(a_, b_);
		var e_ = this.Denominator();
		var g_ = c_.And(d_, e_);
		var h_ = this.Denominator_Exclusions();
		var j_ = c_.Not(h_);
		var l_ = c_.And(g_, j_);

		return l_;
	}

    [CqlDeclaration("Final Numerator Population")]
    public bool? Final_Numerator_Population() => __Final_Numerator_Population.Value;

    private bool? Observation_without_appropriate_status_Value()
	{
		var a_ = this.Mammography();
		var b_ = context.DataRetriever;
		var c_ = b_.RetrieveByValueSet<Observation>(a_, null);
		bool? d_(Observation Mammogram)
		{
			var i_ = Mammogram.StatusElement;
			var j_ = new CallStackEntry("ToString", null, null);
			var k_ = context.Deeper(j_);
			var l_ = k_.Operators;
			var m_ = l_.TypeConverter;
			var n_ = m_.Convert<string>(i_);
			var o_ = new string[]
			{
				"final",
				"amended",
				"corrected",
				"appended",
			};
			var p_ = context.Operators;
			var q_ = p_.InList<string>(n_, (o_ as IEnumerable<string>));
			var s_ = p_.Not(q_);
			var t_ = Mammogram.Effective;
			var u_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(t_);
			var w_ = p_.End(u_);
			var x_ = this.Measurement_Period();
			var z_ = p_.End(x_);
			var ab_ = p_.Quantity(27m, "months");
			var ad_ = p_.Subtract(z_, ab_);
			var ag_ = p_.End(x_);
			var ai_ = p_.Interval(ad_, ag_, true, true);
			var ak_ = p_.ElementInInterval<CqlDateTime>(w_, ai_, null);
			var an_ = p_.End(x_);
			var ao_ = (an_ == null);
			var aq_ = p_.Not((bool?)ao_);
			var as_ = p_.And(ak_, aq_);
			var au_ = p_.And(s_, as_);

			return au_;
		};
		var e_ = context.Operators;
		var f_ = e_.WhereOrNull<Observation>(c_, d_);
		var h_ = e_.ExistsInList<Observation>(f_);

		return h_;
	}

    [CqlDeclaration("Observation without appropriate status")]
    public bool? Observation_without_appropriate_status() => __Observation_without_appropriate_status.Value;

    private bool? Diagnostic_Report_without_appropriate_status_Value()
	{
		var a_ = this.Mammography();
		var b_ = context.DataRetriever;
		var c_ = b_.RetrieveByValueSet<DiagnosticReport>(a_, null);
		bool? d_(DiagnosticReport Mammogram)
		{
			var i_ = Mammogram.StatusElement;
			var j_ = new CallStackEntry("ToString", null, null);
			var k_ = context.Deeper(j_);
			var l_ = k_.Operators;
			var m_ = l_.TypeConverter;
			var n_ = m_.Convert<string>(i_);
			var o_ = new string[]
			{
				"final",
				"amended",
				"corrected",
				"appended",
			};
			var p_ = context.Operators;
			var q_ = p_.InList<string>(n_, (o_ as IEnumerable<string>));
			var s_ = p_.Not(q_);
			var t_ = Mammogram.Effective;
			var u_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(t_);
			var w_ = p_.End(u_);
			var x_ = this.Measurement_Period();
			var z_ = p_.End(x_);
			var ab_ = p_.Quantity(27m, "months");
			var ad_ = p_.Subtract(z_, ab_);
			var ag_ = p_.End(x_);
			var ai_ = p_.Interval(ad_, ag_, true, true);
			var ak_ = p_.ElementInInterval<CqlDateTime>(w_, ai_, null);
			var an_ = p_.End(x_);
			var ao_ = (an_ == null);
			var aq_ = p_.Not((bool?)ao_);
			var as_ = p_.And(ak_, aq_);
			var au_ = p_.And(s_, as_);

			return au_;
		};
		var e_ = context.Operators;
		var f_ = e_.WhereOrNull<DiagnosticReport>(c_, d_);
		var h_ = e_.ExistsInList<DiagnosticReport>(f_);

		return h_;
	}

    [CqlDeclaration("Diagnostic Report without appropriate status")]
    public bool? Diagnostic_Report_without_appropriate_status() => __Diagnostic_Report_without_appropriate_status.Value;

}