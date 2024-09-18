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
[CqlLibrary("BCSEHEDISMY2022", "1.0.0")]
public class BCSEHEDISMY2022_1_0_0
{

    public static BCSEHEDISMY2022_1_0_0 Instance { get; }  = new();

    [CqlDeclaration("Absence of Left Breast")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1329")]
	public CqlValueSet Absence_of_Left_Breast(CqlContext context) => 
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1329", null);

    [CqlDeclaration("Absence of Right Breast")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1330")]
	public CqlValueSet Absence_of_Right_Breast(CqlContext context) => 
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1330", null);

    [CqlDeclaration("Bilateral Mastectomy")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1042")]
	public CqlValueSet Bilateral_Mastectomy(CqlContext context) => 
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1042", null);

    [CqlDeclaration("Bilateral Modifier")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1043")]
	public CqlValueSet Bilateral_Modifier(CqlContext context) => 
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1043", null);

    [CqlDeclaration("Clinical Bilateral Modifier")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1951")]
	public CqlValueSet Clinical_Bilateral_Modifier(CqlContext context) => 
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1951", null);

    [CqlDeclaration("Clinical Left Modifier")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1949")]
	public CqlValueSet Clinical_Left_Modifier(CqlContext context) => 
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1949", null);

    [CqlDeclaration("Clinical Right Modifier")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1950")]
	public CqlValueSet Clinical_Right_Modifier(CqlContext context) => 
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1950", null);

    [CqlDeclaration("Clinical Unilateral Mastectomy")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1948")]
	public CqlValueSet Clinical_Unilateral_Mastectomy(CqlContext context) => 
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1948", null);

    [CqlDeclaration("History of Bilateral Mastectomy")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1331")]
	public CqlValueSet History_of_Bilateral_Mastectomy(CqlContext context) => 
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1331", null);

    [CqlDeclaration("Left Modifier")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1148")]
	public CqlValueSet Left_Modifier(CqlContext context) => 
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1148", null);

    [CqlDeclaration("Mammography")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1168")]
	public CqlValueSet Mammography(CqlContext context) => 
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1168", null);

    [CqlDeclaration("Right Modifier")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1230")]
	public CqlValueSet Right_Modifier(CqlContext context) => 
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1230", null);

    [CqlDeclaration("Unilateral Mastectomy")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1256")]
	public CqlValueSet Unilateral_Mastectomy(CqlContext context) => 
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1256", null);

    [CqlDeclaration("Unilateral Mastectomy Left")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1334")]
	public CqlValueSet Unilateral_Mastectomy_Left(CqlContext context) => 
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1334", null);

    [CqlDeclaration("Unilateral Mastectomy Right")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1335")]
	public CqlValueSet Unilateral_Mastectomy_Right(CqlContext context) => 
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1335", null);

    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
	{
		var a_ = context.ResolveParameter("BCSEHEDISMY2022-1.0.0", "Measurement Period", null);

		return (CqlInterval<CqlDateTime>)a_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient(CqlContext context)
	{
		var a_ = context.Operators.RetrieveByValueSet<Patient>(null, null);
		var b_ = context.Operators.SingleOrNull<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("October 1 Two Years Prior to the Measurement Period")]
	public CqlDateTime October_1_Two_Years_Prior_to_the_Measurement_Period(CqlContext context)
	{
		var a_ = this.Measurement_Period(context);
		var b_ = context.Operators.Start(a_);
		var c_ = context.Operators.ComponentFrom(b_, "year");
		var d_ = context.Operators.Subtract(c_, (int?)2);
		var e_ = context.Operators.ConvertIntegerToDecimal((int?)0);
		var f_ = context.Operators.DateTime(d_, (int?)10, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, e_);

		return f_;
	}

    [CqlDeclaration("Participation Period")]
	public CqlInterval<CqlDateTime> Participation_Period(CqlContext context)
	{
		var a_ = this.October_1_Two_Years_Prior_to_the_Measurement_Period(context);
		var b_ = this.Measurement_Period(context);
		var c_ = context.Operators.End(b_);
		var d_ = context.Operators.Interval(a_, c_, true, true);

		return d_;
	}

    [CqlDeclaration("Member Coverage")]
	public IEnumerable<Coverage> Member_Coverage(CqlContext context)
	{
		var a_ = context.Operators.RetrieveByValueSet<Coverage>(null, null);
		bool? b_(Coverage C)
		{
			var d_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, (C?.Period as object));
			var e_ = this.Participation_Period(context);
			var f_ = context.Operators.Overlaps(d_, e_, null);

			return f_;
		};
		var c_ = context.Operators.WhereOrNull<Coverage>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Enrolled During Participation Period")]
	public bool? Enrolled_During_Participation_Period(CqlContext context)
	{
		var a_ = this.Member_Coverage(context);
		var b_ = this.Measurement_Period(context);
		var c_ = context.Operators.End(b_);
		var d_ = context.Operators.DateFrom(c_);
		var e_ = this.October_1_Two_Years_Prior_to_the_Measurement_Period(context);
		var f_ = context.Operators.DateFrom(e_);
		var h_ = context.Operators.End(b_);
		var i_ = context.Operators.DateFrom(h_);
		var j_ = context.Operators.Quantity(2m, "years");
		var k_ = context.Operators.Subtract(i_, j_);
		var l_ = context.Operators.Interval(f_, k_, true, true);
		var m_ = NCQAHealthPlanEnrollment_1_0_0.Instance.Health_Plan_Enrollment_Criteria(context, a_, d_, l_, (int?)0);
		var p_ = context.Operators.End(b_);
		var q_ = context.Operators.DateFrom(p_);
		var s_ = context.Operators.Start(b_);
		var t_ = context.Operators.DateFrom(s_);
		var u_ = context.Operators.Quantity(1m, "year");
		var v_ = context.Operators.Subtract(t_, u_);
		var x_ = context.Operators.End(b_);
		var y_ = context.Operators.DateFrom(x_);
		var aa_ = context.Operators.Subtract(y_, u_);
		var ab_ = context.Operators.Interval(v_, aa_, true, true);
		var ac_ = NCQAHealthPlanEnrollment_1_0_0.Instance.Health_Plan_Enrollment_Criteria(context, a_, q_, ab_, (int?)45);
		var ad_ = context.Operators.And(m_, ac_);
		var ag_ = context.Operators.End(b_);
		var ah_ = context.Operators.DateFrom(ag_);
		var aj_ = context.Operators.Start(b_);
		var ak_ = context.Operators.DateFrom(aj_);
		var am_ = context.Operators.End(b_);
		var an_ = context.Operators.DateFrom(am_);
		var ao_ = context.Operators.Interval(ak_, an_, true, true);
		var ap_ = NCQAHealthPlanEnrollment_1_0_0.Instance.Health_Plan_Enrollment_Criteria(context, a_, ah_, ao_, (int?)45);
		var aq_ = context.Operators.And(ad_, ap_);

		return aq_;
	}

    [CqlDeclaration("Initial Population")]
	public bool? Initial_Population(CqlContext context)
	{
		var a_ = this.Patient(context);
		var b_ = context.Operators.Convert<CqlDate>(a_?.BirthDateElement?.Value);
		var c_ = this.Measurement_Period(context);
		var d_ = context.Operators.End(c_);
		var e_ = context.Operators.DateFrom(d_);
		var f_ = context.Operators.CalculateAgeAt(b_, e_, "year");
		var g_ = context.Operators.Interval((int?)52, (int?)74, true, true);
		var h_ = context.Operators.ElementInInterval<int?>(f_, g_, null);
		var j_ = context.Operators.EnumEqualsString(a_?.GenderElement?.Value, "female");
		var k_ = context.Operators.And(h_, j_);
		var l_ = this.Enrolled_During_Participation_Period(context);
		var m_ = context.Operators.And(k_, l_);

		return m_;
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
		var a_ = this.Absence_of_Right_Breast(context);
		var b_ = context.Operators.RetrieveByValueSet<Condition>(a_, null);
		var c_ = NCQAStatus_1_0_0.Instance.Active_Condition(context, b_);
		bool? d_(Condition RightMastectomyDiagnosis)
		{
			var f_ = NCQAFHIRBase_1_0_0.Instance.Prevalence_Period(context, RightMastectomyDiagnosis);
			var g_ = context.Operators.Start(f_);
			var h_ = this.Measurement_Period(context);
			var i_ = context.Operators.End(h_);
			var j_ = context.Operators.SameOrBefore(g_, i_, null);

			return j_;
		};
		var e_ = context.Operators.WhereOrNull<Condition>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Right Mastectomy Procedure")]
	public IEnumerable<Procedure> Right_Mastectomy_Procedure(CqlContext context)
	{
		var a_ = this.Unilateral_Mastectomy_Right(context);
		var b_ = context.Operators.RetrieveByValueSet<Procedure>(a_, null);
		var c_ = NCQAStatus_1_0_0.Instance.Completed_Procedure(context, b_);
		var d_ = this.Unilateral_Mastectomy(context);
		var e_ = context.Operators.RetrieveByValueSet<Procedure>(d_, null);
		var f_ = NCQAStatus_1_0_0.Instance.Completed_Procedure(context, e_);
		bool? g_(Procedure UnilateralMastectomyProcedure)
		{
			CqlConcept r_(CodeableConcept X)
			{
				var v_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, X);

				return v_;
			};
			var s_ = context.Operators.SelectOrNull<CodeableConcept, CqlConcept>((UnilateralMastectomyProcedure?.BodySite as IEnumerable<CodeableConcept>), r_);
			var t_ = this.Right_Modifier(context);
			var u_ = context.Operators.ConceptsInValueSet(s_, t_);

			return u_;
		};
		var h_ = context.Operators.WhereOrNull<Procedure>(f_, g_);
		var i_ = context.Operators.ListUnion<Procedure>(c_, h_);
		var j_ = this.Clinical_Unilateral_Mastectomy(context);
		var k_ = context.Operators.RetrieveByValueSet<Procedure>(j_, null);
		var l_ = NCQAStatus_1_0_0.Instance.Completed_Procedure(context, k_);
		bool? m_(Procedure ClinicalUnilateralMastectomyProcedure)
		{
			CqlConcept w_(CodeableConcept X)
			{
				var aa_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, X);

				return aa_;
			};
			var x_ = context.Operators.SelectOrNull<CodeableConcept, CqlConcept>((ClinicalUnilateralMastectomyProcedure?.BodySite as IEnumerable<CodeableConcept>), w_);
			var y_ = this.Clinical_Right_Modifier(context);
			var z_ = context.Operators.ConceptsInValueSet(x_, y_);

			return z_;
		};
		var n_ = context.Operators.WhereOrNull<Procedure>(l_, m_);
		var o_ = context.Operators.ListUnion<Procedure>(i_, n_);
		bool? p_(Procedure RightMastectomyProcedure)
		{
			var ab_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, RightMastectomyProcedure?.Performed);
			var ac_ = context.Operators.End(ab_);
			var ad_ = this.Measurement_Period(context);
			var ae_ = context.Operators.End(ad_);
			var af_ = context.Operators.SameOrBefore(ac_, ae_, null);

			return af_;
		};
		var q_ = context.Operators.WhereOrNull<Procedure>(o_, p_);

		return q_;
	}

    [CqlDeclaration("Left Mastectomy Diagnosis")]
	public IEnumerable<Condition> Left_Mastectomy_Diagnosis(CqlContext context)
	{
		var a_ = this.Absence_of_Left_Breast(context);
		var b_ = context.Operators.RetrieveByValueSet<Condition>(a_, null);
		var c_ = NCQAStatus_1_0_0.Instance.Active_Condition(context, b_);
		bool? d_(Condition LeftMastectomyDiagnosis)
		{
			var f_ = NCQAFHIRBase_1_0_0.Instance.Prevalence_Period(context, LeftMastectomyDiagnosis);
			var g_ = context.Operators.Start(f_);
			var h_ = this.Measurement_Period(context);
			var i_ = context.Operators.End(h_);
			var j_ = context.Operators.SameOrBefore(g_, i_, null);

			return j_;
		};
		var e_ = context.Operators.WhereOrNull<Condition>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Left Mastectomy Procedure")]
	public IEnumerable<Procedure> Left_Mastectomy_Procedure(CqlContext context)
	{
		var a_ = this.Unilateral_Mastectomy_Left(context);
		var b_ = context.Operators.RetrieveByValueSet<Procedure>(a_, null);
		var c_ = NCQAStatus_1_0_0.Instance.Completed_Procedure(context, b_);
		var d_ = this.Unilateral_Mastectomy(context);
		var e_ = context.Operators.RetrieveByValueSet<Procedure>(d_, null);
		var f_ = NCQAStatus_1_0_0.Instance.Completed_Procedure(context, e_);
		bool? g_(Procedure UnilateralMastectomyProcedure)
		{
			CqlConcept r_(CodeableConcept X)
			{
				var v_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, X);

				return v_;
			};
			var s_ = context.Operators.SelectOrNull<CodeableConcept, CqlConcept>((UnilateralMastectomyProcedure?.BodySite as IEnumerable<CodeableConcept>), r_);
			var t_ = this.Left_Modifier(context);
			var u_ = context.Operators.ConceptsInValueSet(s_, t_);

			return u_;
		};
		var h_ = context.Operators.WhereOrNull<Procedure>(f_, g_);
		var i_ = context.Operators.ListUnion<Procedure>(c_, h_);
		var j_ = this.Clinical_Unilateral_Mastectomy(context);
		var k_ = context.Operators.RetrieveByValueSet<Procedure>(j_, null);
		var l_ = NCQAStatus_1_0_0.Instance.Completed_Procedure(context, k_);
		bool? m_(Procedure ClinicalUnilateralMastectomyProcedure)
		{
			CqlConcept w_(CodeableConcept X)
			{
				var aa_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, X);

				return aa_;
			};
			var x_ = context.Operators.SelectOrNull<CodeableConcept, CqlConcept>((ClinicalUnilateralMastectomyProcedure?.BodySite as IEnumerable<CodeableConcept>), w_);
			var y_ = this.Clinical_Left_Modifier(context);
			var z_ = context.Operators.ConceptsInValueSet(x_, y_);

			return z_;
		};
		var n_ = context.Operators.WhereOrNull<Procedure>(l_, m_);
		var o_ = context.Operators.ListUnion<Procedure>(i_, n_);
		bool? p_(Procedure LeftMastectomyProcedure)
		{
			var ab_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, LeftMastectomyProcedure?.Performed);
			var ac_ = context.Operators.End(ab_);
			var ad_ = this.Measurement_Period(context);
			var ae_ = context.Operators.End(ad_);
			var af_ = context.Operators.SameOrBefore(ac_, ae_, null);

			return af_;
		};
		var q_ = context.Operators.WhereOrNull<Procedure>(o_, p_);

		return q_;
	}

    [CqlDeclaration("Bilateral Mastectomy Diagnosis")]
	public IEnumerable<Condition> Bilateral_Mastectomy_Diagnosis(CqlContext context)
	{
		var a_ = this.History_of_Bilateral_Mastectomy(context);
		var b_ = context.Operators.RetrieveByValueSet<Condition>(a_, null);
		var c_ = NCQAStatus_1_0_0.Instance.Active_Condition(context, b_);
		bool? d_(Condition BilateralMastectomyHistory)
		{
			var f_ = NCQAFHIRBase_1_0_0.Instance.Prevalence_Period(context, BilateralMastectomyHistory);
			var g_ = context.Operators.Start(f_);
			var h_ = this.Measurement_Period(context);
			var i_ = context.Operators.End(h_);
			var j_ = context.Operators.SameOrBefore(g_, i_, null);

			return j_;
		};
		var e_ = context.Operators.WhereOrNull<Condition>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Bilateral Mastectomy Procedure")]
	public IEnumerable<Procedure> Bilateral_Mastectomy_Procedure(CqlContext context)
	{
		var a_ = this.Bilateral_Mastectomy(context);
		var b_ = context.Operators.RetrieveByValueSet<Procedure>(a_, null);
		var c_ = NCQAStatus_1_0_0.Instance.Completed_Procedure(context, b_);
		var d_ = this.Unilateral_Mastectomy(context);
		var e_ = context.Operators.RetrieveByValueSet<Procedure>(d_, null);
		var f_ = NCQAStatus_1_0_0.Instance.Completed_Procedure(context, e_);
		bool? g_(Procedure UnilateralMastectomyProcedure)
		{
			CqlConcept r_(CodeableConcept X)
			{
				var v_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, X);

				return v_;
			};
			var s_ = context.Operators.SelectOrNull<CodeableConcept, CqlConcept>((UnilateralMastectomyProcedure?.BodySite as IEnumerable<CodeableConcept>), r_);
			var t_ = this.Bilateral_Modifier(context);
			var u_ = context.Operators.ConceptsInValueSet(s_, t_);

			return u_;
		};
		var h_ = context.Operators.WhereOrNull<Procedure>(f_, g_);
		var i_ = context.Operators.ListUnion<Procedure>(c_, h_);
		var j_ = this.Clinical_Unilateral_Mastectomy(context);
		var k_ = context.Operators.RetrieveByValueSet<Procedure>(j_, null);
		var l_ = NCQAStatus_1_0_0.Instance.Completed_Procedure(context, k_);
		bool? m_(Procedure ClinicalUnilateralMastectomyProcedure)
		{
			CqlConcept w_(CodeableConcept X)
			{
				var aa_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, X);

				return aa_;
			};
			var x_ = context.Operators.SelectOrNull<CodeableConcept, CqlConcept>((ClinicalUnilateralMastectomyProcedure?.BodySite as IEnumerable<CodeableConcept>), w_);
			var y_ = this.Clinical_Bilateral_Modifier(context);
			var z_ = context.Operators.ConceptsInValueSet(x_, y_);

			return z_;
		};
		var n_ = context.Operators.WhereOrNull<Procedure>(l_, m_);
		var o_ = context.Operators.ListUnion<Procedure>(i_, n_);
		bool? p_(Procedure BilateralMastectomyPerformed)
		{
			var ab_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, BilateralMastectomyPerformed?.Performed);
			var ac_ = context.Operators.End(ab_);
			var ad_ = this.Measurement_Period(context);
			var ae_ = context.Operators.End(ad_);
			var af_ = context.Operators.SameOrBefore(ac_, ae_, null);

			return af_;
		};
		var q_ = context.Operators.WhereOrNull<Procedure>(o_, p_);

		return q_;
	}

    [CqlDeclaration("Mastectomy Exclusion")]
	public bool? Mastectomy_Exclusion(CqlContext context)
	{
		var a_ = this.Right_Mastectomy_Diagnosis(context);
		var b_ = context.Operators.ExistsInList<Condition>(a_);
		var c_ = this.Right_Mastectomy_Procedure(context);
		var d_ = context.Operators.ExistsInList<Procedure>(c_);
		var e_ = context.Operators.Or(b_, d_);
		var f_ = this.Left_Mastectomy_Diagnosis(context);
		var g_ = context.Operators.ExistsInList<Condition>(f_);
		var h_ = this.Left_Mastectomy_Procedure(context);
		var i_ = context.Operators.ExistsInList<Procedure>(h_);
		var j_ = context.Operators.Or(g_, i_);
		var k_ = context.Operators.And(e_, j_);
		var l_ = this.Bilateral_Mastectomy_Diagnosis(context);
		var m_ = context.Operators.ExistsInList<Condition>(l_);
		var n_ = context.Operators.Or(k_, m_);
		var o_ = this.Bilateral_Mastectomy_Procedure(context);
		var p_ = context.Operators.ExistsInList<Procedure>(o_);
		var q_ = context.Operators.Or(n_, p_);

		return q_;
	}

    [CqlDeclaration("Exclusions")]
	public bool? Exclusions(CqlContext context)
	{
		var a_ = NCQAHospice_1_0_0.Instance.Hospice_Intervention_or_Encounter(context);
		var b_ = this.Mastectomy_Exclusion(context);
		var c_ = context.Operators.Or(a_, b_);
		var d_ = NCQAAdvancedIllnessandFrailty_1_0_0.Instance.Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80(context);
		var e_ = context.Operators.Or(c_, d_);
		var f_ = this.Measurement_Period(context);
		var g_ = NCQAPalliativeCare_1_0_0.Instance.Palliative_Care_Overlapping_Period(context, f_);
		var h_ = context.Operators.Or(e_, g_);

		return h_;
	}

    [CqlDeclaration("Numerator")]
	public bool? Numerator(CqlContext context)
	{
		var a_ = this.Mammography(context);
		var b_ = context.Operators.RetrieveByValueSet<Observation>(a_, null);
		bool? c_(Observation Mammogram)
		{
			var f_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, Mammogram?.Effective);
			var g_ = context.Operators.End(f_);
			var h_ = this.Participation_Period(context);
			var i_ = context.Operators.ElementInInterval<CqlDateTime>(g_, h_, null);

			return i_;
		};
		var d_ = context.Operators.WhereOrNull<Observation>(b_, c_);
		var e_ = context.Operators.ExistsInList<Observation>(d_);

		return e_;
	}

}