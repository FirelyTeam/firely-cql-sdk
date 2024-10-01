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
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "1.0.0.0")]
[CqlLibrary("BreastCancerScreeningsFHIR", "0.0.009")]
public class BreastCancerScreeningsFHIR_0_0_009
{

    public static BreastCancerScreeningsFHIR_0_0_009 Instance { get; }  = new();

    [CqlDeclaration("Bilateral Mastectomy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1005")]
	public CqlValueSet Bilateral_Mastectomy(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1005", null);

    [CqlDeclaration("History of bilateral mastectomy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1068")]
	public CqlValueSet History_of_bilateral_mastectomy(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1068", null);

    [CqlDeclaration("Left")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.122.12.1036")]
	public CqlValueSet Left(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.122.12.1036", null);

    [CqlDeclaration("Mammography")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.11.1047")]
	public CqlValueSet Mammography(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.11.1047", null);

    [CqlDeclaration("Online Assessments")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089")]
	public CqlValueSet Online_Assessments(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", null);

    [CqlDeclaration("Right")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.122.12.1035")]
	public CqlValueSet Right(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.122.12.1035", null);

    [CqlDeclaration("Status Post Left Mastectomy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1069")]
	public CqlValueSet Status_Post_Left_Mastectomy(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1069", null);

    [CqlDeclaration("Status Post Right Mastectomy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1070")]
	public CqlValueSet Status_Post_Right_Mastectomy(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1070", null);

    [CqlDeclaration("Telephone Visits")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080")]
	public CqlValueSet Telephone_Visits(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", null);

    [CqlDeclaration("Unilateral Mastectomy Left")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1133")]
	public CqlValueSet Unilateral_Mastectomy_Left(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1133", null);

    [CqlDeclaration("Unilateral Mastectomy Right")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1134")]
	public CqlValueSet Unilateral_Mastectomy_Right(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1134", null);

    [CqlDeclaration("Unilateral Mastectomy, Unspecified Laterality")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1071")]
	public CqlValueSet Unilateral_Mastectomy__Unspecified_Laterality(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1071", null);

    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
	{
		var a_ = context.Operators.ConvertIntegerToDecimal(default);
		var b_ = context.Operators.DateTime((int?)2021, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, a_);
		var d_ = context.Operators.DateTime((int?)2022, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, a_);
		var e_ = context.Operators.Interval(b_, d_, true, false);
		var f_ = context.ResolveParameter("BreastCancerScreeningsFHIR-0.0.009", "Measurement Period", e_);

		return (CqlInterval<CqlDateTime>)f_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient(CqlContext context)
	{
		var a_ = context.Operators.RetrieveByValueSet<Patient>(null, null);
		var b_ = context.Operators.SingleOrNull<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("SDE Ethnicity")]
	public IEnumerable<Coding> SDE_Ethnicity(CqlContext context)
	{
		var a_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Ethnicity(context);

		return a_;
	}

    [CqlDeclaration("SDE Payer")]
	public IEnumerable<Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG> SDE_Payer(CqlContext context)
	{
		var a_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Payer(context);

		return a_;
	}

    [CqlDeclaration("SDE Race")]
	public IEnumerable<Coding> SDE_Race(CqlContext context)
	{
		var a_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Race(context);

		return a_;
	}

    [CqlDeclaration("SDE Sex")]
	public CqlCode SDE_Sex(CqlContext context)
	{
		var a_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Sex(context);

		return a_;
	}

    [CqlDeclaration("Telehealth Services")]
	public IEnumerable<Encounter> Telehealth_Services(CqlContext context)
	{
		var a_ = this.Online_Assessments(context);
		var b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);
		var c_ = this.Telephone_Visits(context);
		var d_ = context.Operators.RetrieveByValueSet<Encounter>(c_, null);
		var e_ = context.Operators.ListUnion<Encounter>(b_, d_);
		bool? f_(Encounter TelehealthEncounter)
		{
			var h_ = context.Operators.Convert<string>(TelehealthEncounter?.StatusElement);
			var i_ = context.Operators.Equal(h_, "finished");
			var j_ = this.Measurement_Period(context);
			var k_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, (TelehealthEncounter?.Period as object));
			var l_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(j_, k_, null);
			var m_ = context.Operators.And(i_, l_);

			return m_;
		};
		var g_ = context.Operators.WhereOrNull<Encounter>(e_, f_);

		return g_;
	}

    [CqlDeclaration("Age at start of Measurement Period")]
	public int? Age_at_start_of_Measurement_Period(CqlContext context)
	{
		var a_ = this.Patient(context);
		var b_ = context.Operators.Convert<CqlDate>(a_?.BirthDateElement?.Value);
		var c_ = this.Measurement_Period(context);
		var d_ = context.Operators.Start(c_);
		var e_ = context.Operators.DateFrom(d_);
		var f_ = context.Operators.CalculateAgeAt(b_, e_, "year");

		return f_;
	}

    [CqlDeclaration("Initial Population")]
	public bool? Initial_Population(CqlContext context)
	{
		var a_ = this.Patient(context);
		var b_ = context.Operators.Convert<CqlDate>(a_?.BirthDateElement?.Value);
		var c_ = this.Measurement_Period(context);
		var d_ = context.Operators.Start(c_);
		var e_ = context.Operators.DateFrom(d_);
		var f_ = context.Operators.CalculateAgeAt(b_, e_, "year");
		var g_ = context.Operators.Interval((int?)51, (int?)74, true, false);
		var h_ = context.Operators.ElementInInterval<int?>(f_, g_, null);
		var j_ = context.Operators.Convert<string>(a_?.GenderElement);
		var k_ = context.Operators.Equal(j_, "female");
		var l_ = context.Operators.And(h_, k_);
		var m_ = AdultOutpatientEncountersFHIR4_2_2_000.Instance.Qualifying_Encounters(context);
		var n_ = this.Telehealth_Services(context);
		var o_ = context.Operators.ListUnion<Encounter>(m_, n_);
		var p_ = context.Operators.ExistsInList<Encounter>(o_);
		var q_ = context.Operators.And(l_, p_);

		return q_;
	}

    [CqlDeclaration("Denominator")]
	public bool? Denominator(CqlContext context)
	{
		var a_ = this.Initial_Population(context);

		return a_;
	}

    [CqlDeclaration("Right Mastectomy Diagnosis")]
	public IEnumerable<Condition> Right_Mastectomy_Diagnosis(CqlContext context)
	{
		var a_ = this.Status_Post_Right_Mastectomy(context);
		var b_ = context.Operators.RetrieveByValueSet<Condition>(a_, null);
		var c_ = this.Unilateral_Mastectomy__Unspecified_Laterality(context);
		var d_ = context.Operators.RetrieveByValueSet<Condition>(c_, null);
		bool? e_(Condition UnilateralMastectomyDiagnosis)
		{
			CqlConcept j_(CodeableConcept X)
			{
				var n_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, X);

				return n_;
			};
			var k_ = context.Operators.SelectOrNull<CodeableConcept, CqlConcept>((UnilateralMastectomyDiagnosis?.BodySite as IEnumerable<CodeableConcept>), j_);
			var l_ = this.Right(context);
			var m_ = context.Operators.ConceptsInValueSet(k_, l_);

			return m_;
		};
		var f_ = context.Operators.WhereOrNull<Condition>(d_, e_);
		var g_ = context.Operators.ListUnion<Condition>(b_, f_);
		bool? h_(Condition RightMastectomy)
		{
			var o_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, RightMastectomy);
			var p_ = context.Operators.Start(o_);
			var q_ = this.Measurement_Period(context);
			var r_ = context.Operators.End(q_);
			var s_ = context.Operators.SameOrBefore(p_, r_, null);

			return s_;
		};
		var i_ = context.Operators.WhereOrNull<Condition>(g_, h_);

		return i_;
	}

    [CqlDeclaration("Right Mastectomy Procedure")]
	public IEnumerable<Procedure> Right_Mastectomy_Procedure(CqlContext context)
	{
		var a_ = this.Unilateral_Mastectomy_Right(context);
		var b_ = context.Operators.RetrieveByValueSet<Procedure>(a_, null);
		bool? c_(Procedure UnilateralMastectomyRightPerformed)
		{
			var e_ = context.Operators.Convert<string>(UnilateralMastectomyRightPerformed?.StatusElement);
			var f_ = context.Operators.Equal(e_, "completed");
			var g_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, UnilateralMastectomyRightPerformed?.Performed);
			var h_ = context.Operators.End(g_);
			var i_ = this.Measurement_Period(context);
			var j_ = context.Operators.End(i_);
			var k_ = context.Operators.SameOrBefore(h_, j_, null);
			var l_ = context.Operators.And(f_, k_);

			return l_;
		};
		var d_ = context.Operators.WhereOrNull<Procedure>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Left Mastectomy Diagnosis")]
	public IEnumerable<Condition> Left_Mastectomy_Diagnosis(CqlContext context)
	{
		var a_ = this.Status_Post_Left_Mastectomy(context);
		var b_ = context.Operators.RetrieveByValueSet<Condition>(a_, null);
		var c_ = this.Unilateral_Mastectomy__Unspecified_Laterality(context);
		var d_ = context.Operators.RetrieveByValueSet<Condition>(c_, null);
		bool? e_(Condition UnilateralMastectomyDiagnosis)
		{
			CqlConcept j_(CodeableConcept X)
			{
				var n_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, X);

				return n_;
			};
			var k_ = context.Operators.SelectOrNull<CodeableConcept, CqlConcept>((UnilateralMastectomyDiagnosis?.BodySite as IEnumerable<CodeableConcept>), j_);
			var l_ = this.Left(context);
			var m_ = context.Operators.ConceptsInValueSet(k_, l_);

			return m_;
		};
		var f_ = context.Operators.WhereOrNull<Condition>(d_, e_);
		var g_ = context.Operators.ListUnion<Condition>(b_, f_);
		bool? h_(Condition LeftMastectomy)
		{
			var o_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, LeftMastectomy);
			var p_ = context.Operators.Start(o_);
			var q_ = this.Measurement_Period(context);
			var r_ = context.Operators.End(q_);
			var s_ = context.Operators.SameOrBefore(p_, r_, null);

			return s_;
		};
		var i_ = context.Operators.WhereOrNull<Condition>(g_, h_);

		return i_;
	}

    [CqlDeclaration("Left Mastectomy Procedure")]
	public IEnumerable<Procedure> Left_Mastectomy_Procedure(CqlContext context)
	{
		var a_ = this.Unilateral_Mastectomy_Left(context);
		var b_ = context.Operators.RetrieveByValueSet<Procedure>(a_, null);
		bool? c_(Procedure UnilateralMastectomyLeftPerformed)
		{
			var e_ = context.Operators.Convert<string>(UnilateralMastectomyLeftPerformed?.StatusElement);
			var f_ = context.Operators.Equal(e_, "completed");
			var g_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, UnilateralMastectomyLeftPerformed?.Performed);
			var h_ = context.Operators.End(g_);
			var i_ = this.Measurement_Period(context);
			var j_ = context.Operators.End(i_);
			var k_ = context.Operators.SameOrBefore(h_, j_, null);
			var l_ = context.Operators.And(f_, k_);

			return l_;
		};
		var d_ = context.Operators.WhereOrNull<Procedure>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Bilateral Mastectomy Diagnosis")]
	public IEnumerable<Condition> Bilateral_Mastectomy_Diagnosis(CqlContext context)
	{
		var a_ = this.History_of_bilateral_mastectomy(context);
		var b_ = context.Operators.RetrieveByValueSet<Condition>(a_, null);
		bool? c_(Condition BilateralMastectomyHistory)
		{
			var e_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, BilateralMastectomyHistory);
			var f_ = context.Operators.Start(e_);
			var g_ = this.Measurement_Period(context);
			var h_ = context.Operators.End(g_);
			var i_ = context.Operators.SameOrBefore(f_, h_, null);

			return i_;
		};
		var d_ = context.Operators.WhereOrNull<Condition>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Bilateral Mastectomy Procedure")]
	public IEnumerable<Procedure> Bilateral_Mastectomy_Procedure(CqlContext context)
	{
		var a_ = this.Bilateral_Mastectomy(context);
		var b_ = context.Operators.RetrieveByValueSet<Procedure>(a_, null);
		bool? c_(Procedure BilateralMastectomyPerformed)
		{
			var e_ = context.Operators.Convert<string>(BilateralMastectomyPerformed?.StatusElement);
			var f_ = context.Operators.Equal(e_, "completed");
			var g_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, BilateralMastectomyPerformed?.Performed);
			var h_ = context.Operators.End(g_);
			var i_ = this.Measurement_Period(context);
			var j_ = context.Operators.End(i_);
			var k_ = context.Operators.SameOrBefore(h_, j_, null);
			var l_ = context.Operators.And(f_, k_);

			return l_;
		};
		var d_ = context.Operators.WhereOrNull<Procedure>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Denominator Exclusions")]
	public bool? Denominator_Exclusions(CqlContext context)
	{
		var a_ = HospiceFHIR4_2_3_000.Instance.Has_Hospice(context);
		var b_ = this.Right_Mastectomy_Diagnosis(context);
		var c_ = context.Operators.ExistsInList<Condition>(b_);
		var d_ = this.Right_Mastectomy_Procedure(context);
		var e_ = context.Operators.ExistsInList<Procedure>(d_);
		var f_ = context.Operators.Or(c_, e_);
		var g_ = this.Left_Mastectomy_Diagnosis(context);
		var h_ = context.Operators.ExistsInList<Condition>(g_);
		var i_ = this.Left_Mastectomy_Procedure(context);
		var j_ = context.Operators.ExistsInList<Procedure>(i_);
		var k_ = context.Operators.Or(h_, j_);
		var l_ = context.Operators.And(f_, k_);
		var m_ = context.Operators.Or(a_, l_);
		var n_ = this.Bilateral_Mastectomy_Diagnosis(context);
		var o_ = context.Operators.ExistsInList<Condition>(n_);
		var p_ = context.Operators.Or(m_, o_);
		var q_ = this.Bilateral_Mastectomy_Procedure(context);
		var r_ = context.Operators.ExistsInList<Procedure>(q_);
		var s_ = context.Operators.Or(p_, r_);
		var t_ = AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000.Instance.Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80(context);
		var u_ = context.Operators.Or(s_, t_);
		var v_ = this.Patient(context);
		var w_ = context.Operators.Convert<CqlDate>(v_?.BirthDateElement?.Value);
		var x_ = this.Measurement_Period(context);
		var y_ = context.Operators.Start(x_);
		var z_ = context.Operators.DateFrom(y_);
		var aa_ = context.Operators.CalculateAgeAt(w_, z_, "year");
		var ab_ = context.Operators.GreaterOrEqual(aa_, (int?)65);
		var ac_ = AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000.Instance.Has_Long_Term_Care_Periods_Longer_Than_90_Consecutive_Days(context);
		var ad_ = context.Operators.And(ab_, ac_);
		var ae_ = context.Operators.Or(u_, ad_);
		var af_ = PalliativeCareFHIR_0_6_000.Instance.Palliative_Care_in_the_Measurement_Period(context);
		var ag_ = context.Operators.Or(ae_, af_);

		return ag_;
	}

    [CqlDeclaration("Observation with status")]
	public bool? Observation_with_status(CqlContext context)
	{
		var a_ = this.Mammography(context);
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
			var i_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, Mammogram?.Effective);
			var j_ = context.Operators.End(i_);
			var k_ = this.Measurement_Period(context);
			var l_ = context.Operators.End(k_);
			var m_ = context.Operators.Quantity(27m, "months");
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

    [CqlDeclaration("Diagnostic Report with status")]
	public bool? Diagnostic_Report_with_status(CqlContext context)
	{
		var a_ = this.Mammography(context);
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
			var i_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, Mammogram?.Effective);
			var j_ = context.Operators.End(i_);
			var k_ = this.Measurement_Period(context);
			var l_ = context.Operators.End(k_);
			var m_ = context.Operators.Quantity(27m, "months");
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

    [CqlDeclaration("Numerator")]
	public bool? Numerator(CqlContext context)
	{
		var a_ = this.Observation_with_status(context);
		var b_ = this.Diagnostic_Report_with_status(context);
		var c_ = context.Operators.Or(a_, b_);

		return c_;
	}

    [CqlDeclaration("Final Numerator Population")]
	public bool? Final_Numerator_Population(CqlContext context)
	{
		var a_ = this.Numerator(context);
		var b_ = this.Initial_Population(context);
		var c_ = context.Operators.And(a_, b_);
		var d_ = this.Denominator(context);
		var e_ = context.Operators.And(c_, d_);
		var f_ = this.Denominator_Exclusions(context);
		var g_ = context.Operators.Not(f_);
		var h_ = context.Operators.And(e_, g_);

		return h_;
	}

    [CqlDeclaration("Observation without appropriate status")]
	public bool? Observation_without_appropriate_status(CqlContext context)
	{
		var a_ = this.Mammography(context);
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
			var j_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, Mammogram?.Effective);
			var k_ = context.Operators.End(j_);
			var l_ = this.Measurement_Period(context);
			var m_ = context.Operators.End(l_);
			var n_ = context.Operators.Quantity(27m, "months");
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

    [CqlDeclaration("Diagnostic Report without appropriate status")]
	public bool? Diagnostic_Report_without_appropriate_status(CqlContext context)
	{
		var a_ = this.Mammography(context);
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
			var j_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, Mammogram?.Effective);
			var k_ = context.Operators.End(j_);
			var l_ = this.Measurement_Period(context);
			var m_ = context.Operators.End(l_);
			var n_ = context.Operators.Quantity(27m, "months");
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

}