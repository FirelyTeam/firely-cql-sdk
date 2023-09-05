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
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "0.9.0.0")]
[CqlLibrary("BCSEHEDISMY2022", "1.0.0")]
public class BCSEHEDISMY2022_1_0_0
{


    internal CqlContext context;

    #region Cached values

    internal Lazy<CqlValueSet> __Absence_of_Left_Breast;
    internal Lazy<CqlValueSet> __Absence_of_Right_Breast;
    internal Lazy<CqlValueSet> __Bilateral_Mastectomy;
    internal Lazy<CqlValueSet> __Bilateral_Modifier;
    internal Lazy<CqlValueSet> __Clinical_Bilateral_Modifier;
    internal Lazy<CqlValueSet> __Clinical_Left_Modifier;
    internal Lazy<CqlValueSet> __Clinical_Right_Modifier;
    internal Lazy<CqlValueSet> __Clinical_Unilateral_Mastectomy;
    internal Lazy<CqlValueSet> __History_of_Bilateral_Mastectomy;
    internal Lazy<CqlValueSet> __Left_Modifier;
    internal Lazy<CqlValueSet> __Mammography;
    internal Lazy<CqlValueSet> __Right_Modifier;
    internal Lazy<CqlValueSet> __Unilateral_Mastectomy;
    internal Lazy<CqlValueSet> __Unilateral_Mastectomy_Left;
    internal Lazy<CqlValueSet> __Unilateral_Mastectomy_Right;
    internal Lazy<CqlInterval<CqlDateTime>> __Measurement_Period;
    internal Lazy<Patient> __Patient;
    internal Lazy<CqlDateTime> __October_1_Two_Years_Prior_to_the_Measurement_Period;
    internal Lazy<CqlInterval<CqlDateTime>> __Participation_Period;
    internal Lazy<IEnumerable<Coverage>> __Member_Coverage;
    internal Lazy<bool?> __Enrolled_During_Participation_Period;
    internal Lazy<bool?> __Initial_Population;
    internal Lazy<bool?> __Denominator;
    internal Lazy<IEnumerable<Condition>> __Right_Mastectomy_Diagnosis;
    internal Lazy<IEnumerable<Procedure>> __Right_Mastectomy_Procedure;
    internal Lazy<IEnumerable<Condition>> __Left_Mastectomy_Diagnosis;
    internal Lazy<IEnumerable<Procedure>> __Left_Mastectomy_Procedure;
    internal Lazy<IEnumerable<Condition>> __Bilateral_Mastectomy_Diagnosis;
    internal Lazy<IEnumerable<Procedure>> __Bilateral_Mastectomy_Procedure;
    internal Lazy<bool?> __Mastectomy_Exclusion;
    internal Lazy<bool?> __Exclusions;
    internal Lazy<bool?> __Numerator;

    #endregion
    public BCSEHEDISMY2022_1_0_0(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");

        FHIRHelpers_4_0_001 = new FHIRHelpers_4_0_001(context);
        NCQAHealthPlanEnrollment_1_0_0 = new NCQAHealthPlanEnrollment_1_0_0(context);
        NCQAStatus_1_0_0 = new NCQAStatus_1_0_0(context);
        NCQAFHIRBase_1_0_0 = new NCQAFHIRBase_1_0_0(context);
        NCQAHospice_1_0_0 = new NCQAHospice_1_0_0(context);
        NCQAAdvancedIllnessandFrailty_1_0_0 = new NCQAAdvancedIllnessandFrailty_1_0_0(context);
        NCQAPalliativeCare_1_0_0 = new NCQAPalliativeCare_1_0_0(context);

        __Absence_of_Left_Breast = new Lazy<CqlValueSet>(this.Absence_of_Left_Breast_Value);
        __Absence_of_Right_Breast = new Lazy<CqlValueSet>(this.Absence_of_Right_Breast_Value);
        __Bilateral_Mastectomy = new Lazy<CqlValueSet>(this.Bilateral_Mastectomy_Value);
        __Bilateral_Modifier = new Lazy<CqlValueSet>(this.Bilateral_Modifier_Value);
        __Clinical_Bilateral_Modifier = new Lazy<CqlValueSet>(this.Clinical_Bilateral_Modifier_Value);
        __Clinical_Left_Modifier = new Lazy<CqlValueSet>(this.Clinical_Left_Modifier_Value);
        __Clinical_Right_Modifier = new Lazy<CqlValueSet>(this.Clinical_Right_Modifier_Value);
        __Clinical_Unilateral_Mastectomy = new Lazy<CqlValueSet>(this.Clinical_Unilateral_Mastectomy_Value);
        __History_of_Bilateral_Mastectomy = new Lazy<CqlValueSet>(this.History_of_Bilateral_Mastectomy_Value);
        __Left_Modifier = new Lazy<CqlValueSet>(this.Left_Modifier_Value);
        __Mammography = new Lazy<CqlValueSet>(this.Mammography_Value);
        __Right_Modifier = new Lazy<CqlValueSet>(this.Right_Modifier_Value);
        __Unilateral_Mastectomy = new Lazy<CqlValueSet>(this.Unilateral_Mastectomy_Value);
        __Unilateral_Mastectomy_Left = new Lazy<CqlValueSet>(this.Unilateral_Mastectomy_Left_Value);
        __Unilateral_Mastectomy_Right = new Lazy<CqlValueSet>(this.Unilateral_Mastectomy_Right_Value);
        __Measurement_Period = new Lazy<CqlInterval<CqlDateTime>>(this.Measurement_Period_Value);
        __Patient = new Lazy<Patient>(this.Patient_Value);
        __October_1_Two_Years_Prior_to_the_Measurement_Period = new Lazy<CqlDateTime>(this.October_1_Two_Years_Prior_to_the_Measurement_Period_Value);
        __Participation_Period = new Lazy<CqlInterval<CqlDateTime>>(this.Participation_Period_Value);
        __Member_Coverage = new Lazy<IEnumerable<Coverage>>(this.Member_Coverage_Value);
        __Enrolled_During_Participation_Period = new Lazy<bool?>(this.Enrolled_During_Participation_Period_Value);
        __Initial_Population = new Lazy<bool?>(this.Initial_Population_Value);
        __Denominator = new Lazy<bool?>(this.Denominator_Value);
        __Right_Mastectomy_Diagnosis = new Lazy<IEnumerable<Condition>>(this.Right_Mastectomy_Diagnosis_Value);
        __Right_Mastectomy_Procedure = new Lazy<IEnumerable<Procedure>>(this.Right_Mastectomy_Procedure_Value);
        __Left_Mastectomy_Diagnosis = new Lazy<IEnumerable<Condition>>(this.Left_Mastectomy_Diagnosis_Value);
        __Left_Mastectomy_Procedure = new Lazy<IEnumerable<Procedure>>(this.Left_Mastectomy_Procedure_Value);
        __Bilateral_Mastectomy_Diagnosis = new Lazy<IEnumerable<Condition>>(this.Bilateral_Mastectomy_Diagnosis_Value);
        __Bilateral_Mastectomy_Procedure = new Lazy<IEnumerable<Procedure>>(this.Bilateral_Mastectomy_Procedure_Value);
        __Mastectomy_Exclusion = new Lazy<bool?>(this.Mastectomy_Exclusion_Value);
        __Exclusions = new Lazy<bool?>(this.Exclusions_Value);
        __Numerator = new Lazy<bool?>(this.Numerator_Value);
    }
    #region Dependencies

    public FHIRHelpers_4_0_001 FHIRHelpers_4_0_001 { get; }
    public NCQAHealthPlanEnrollment_1_0_0 NCQAHealthPlanEnrollment_1_0_0 { get; }
    public NCQAStatus_1_0_0 NCQAStatus_1_0_0 { get; }
    public NCQAFHIRBase_1_0_0 NCQAFHIRBase_1_0_0 { get; }
    public NCQAHospice_1_0_0 NCQAHospice_1_0_0 { get; }
    public NCQAAdvancedIllnessandFrailty_1_0_0 NCQAAdvancedIllnessandFrailty_1_0_0 { get; }
    public NCQAPalliativeCare_1_0_0 NCQAPalliativeCare_1_0_0 { get; }

    #endregion

	private CqlValueSet Absence_of_Left_Breast_Value() => 
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1329", null);

    [CqlDeclaration("Absence of Left Breast")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1329")]
	public CqlValueSet Absence_of_Left_Breast() => 
		__Absence_of_Left_Breast.Value;

	private CqlValueSet Absence_of_Right_Breast_Value() => 
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1330", null);

    [CqlDeclaration("Absence of Right Breast")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1330")]
	public CqlValueSet Absence_of_Right_Breast() => 
		__Absence_of_Right_Breast.Value;

	private CqlValueSet Bilateral_Mastectomy_Value() => 
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1042", null);

    [CqlDeclaration("Bilateral Mastectomy")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1042")]
	public CqlValueSet Bilateral_Mastectomy() => 
		__Bilateral_Mastectomy.Value;

	private CqlValueSet Bilateral_Modifier_Value() => 
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1043", null);

    [CqlDeclaration("Bilateral Modifier")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1043")]
	public CqlValueSet Bilateral_Modifier() => 
		__Bilateral_Modifier.Value;

	private CqlValueSet Clinical_Bilateral_Modifier_Value() => 
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1951", null);

    [CqlDeclaration("Clinical Bilateral Modifier")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1951")]
	public CqlValueSet Clinical_Bilateral_Modifier() => 
		__Clinical_Bilateral_Modifier.Value;

	private CqlValueSet Clinical_Left_Modifier_Value() => 
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1949", null);

    [CqlDeclaration("Clinical Left Modifier")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1949")]
	public CqlValueSet Clinical_Left_Modifier() => 
		__Clinical_Left_Modifier.Value;

	private CqlValueSet Clinical_Right_Modifier_Value() => 
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1950", null);

    [CqlDeclaration("Clinical Right Modifier")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1950")]
	public CqlValueSet Clinical_Right_Modifier() => 
		__Clinical_Right_Modifier.Value;

	private CqlValueSet Clinical_Unilateral_Mastectomy_Value() => 
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1948", null);

    [CqlDeclaration("Clinical Unilateral Mastectomy")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1948")]
	public CqlValueSet Clinical_Unilateral_Mastectomy() => 
		__Clinical_Unilateral_Mastectomy.Value;

	private CqlValueSet History_of_Bilateral_Mastectomy_Value() => 
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1331", null);

    [CqlDeclaration("History of Bilateral Mastectomy")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1331")]
	public CqlValueSet History_of_Bilateral_Mastectomy() => 
		__History_of_Bilateral_Mastectomy.Value;

	private CqlValueSet Left_Modifier_Value() => 
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1148", null);

    [CqlDeclaration("Left Modifier")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1148")]
	public CqlValueSet Left_Modifier() => 
		__Left_Modifier.Value;

	private CqlValueSet Mammography_Value() => 
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1168", null);

    [CqlDeclaration("Mammography")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1168")]
	public CqlValueSet Mammography() => 
		__Mammography.Value;

	private CqlValueSet Right_Modifier_Value() => 
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1230", null);

    [CqlDeclaration("Right Modifier")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1230")]
	public CqlValueSet Right_Modifier() => 
		__Right_Modifier.Value;

	private CqlValueSet Unilateral_Mastectomy_Value() => 
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1256", null);

    [CqlDeclaration("Unilateral Mastectomy")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1256")]
	public CqlValueSet Unilateral_Mastectomy() => 
		__Unilateral_Mastectomy.Value;

	private CqlValueSet Unilateral_Mastectomy_Left_Value() => 
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1334", null);

    [CqlDeclaration("Unilateral Mastectomy Left")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1334")]
	public CqlValueSet Unilateral_Mastectomy_Left() => 
		__Unilateral_Mastectomy_Left.Value;

	private CqlValueSet Unilateral_Mastectomy_Right_Value() => 
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1335", null);

    [CqlDeclaration("Unilateral Mastectomy Right")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1335")]
	public CqlValueSet Unilateral_Mastectomy_Right() => 
		__Unilateral_Mastectomy_Right.Value;

	private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		var a_ = context.ResolveParameter("BCSEHEDISMY2022-1.0.0", "Measurement Period", null);

		return (CqlInterval<CqlDateTime>)a_;
	}

    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period() => 
		__Measurement_Period.Value;

	private Patient Patient_Value()
	{
		var a_ = context.Operators.RetrieveByValueSet<Patient>(null, null);
		var b_ = context.Operators.SingleOrNull<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient() => 
		__Patient.Value;

	private CqlDateTime October_1_Two_Years_Prior_to_the_Measurement_Period_Value()
	{
		var a_ = this.Measurement_Period();
		var b_ = context.Operators.Start(a_);
		var c_ = context.Operators.ComponentFrom(b_, "year");
		var d_ = context.Operators.Subtract(c_, (int?)2);
		var e_ = context.Operators.ConvertIntegerToDecimal((int?)0);
		var f_ = context.Operators.DateTime(d_, (int?)10, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, e_);

		return f_;
	}

    [CqlDeclaration("October 1 Two Years Prior to the Measurement Period")]
	public CqlDateTime October_1_Two_Years_Prior_to_the_Measurement_Period() => 
		__October_1_Two_Years_Prior_to_the_Measurement_Period.Value;

	private CqlInterval<CqlDateTime> Participation_Period_Value()
	{
		var a_ = this.October_1_Two_Years_Prior_to_the_Measurement_Period();
		var b_ = this.Measurement_Period();
		var c_ = context.Operators.End(b_);
		var d_ = context.Operators.Interval(a_, c_, true, true);

		return d_;
	}

    [CqlDeclaration("Participation Period")]
	public CqlInterval<CqlDateTime> Participation_Period() => 
		__Participation_Period.Value;

	private IEnumerable<Coverage> Member_Coverage_Value()
	{
		var a_ = context.Operators.RetrieveByValueSet<Coverage>(null, null);
		bool? b_(Coverage C)
		{
			var d_ = C?.Period;
			var e_ = NCQAFHIRBase_1_0_0.Normalize_Interval(d_);
			var f_ = this.Participation_Period();
			var g_ = context.Operators.Overlaps(e_, f_, null);

			return g_;
		};
		var c_ = context.Operators.WhereOrNull<Coverage>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Member Coverage")]
	public IEnumerable<Coverage> Member_Coverage() => 
		__Member_Coverage.Value;

	private bool? Enrolled_During_Participation_Period_Value()
	{
		var a_ = this.Member_Coverage();
		var b_ = this.Measurement_Period();
		var c_ = context.Operators.End(b_);
		var d_ = context.Operators.DateFrom(c_);
		var e_ = this.October_1_Two_Years_Prior_to_the_Measurement_Period();
		var f_ = context.Operators.DateFrom(e_);
		var h_ = context.Operators.End(b_);
		var i_ = context.Operators.DateFrom(h_);
		var j_ = context.Operators.Quantity(2m, "years");
		var k_ = context.Operators.Subtract(i_, j_);
		var l_ = context.Operators.Interval(f_, k_, true, true);
		var m_ = NCQAHealthPlanEnrollment_1_0_0.Health_Plan_Enrollment_Criteria(a_, d_, l_, (int?)0);
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
		var ac_ = NCQAHealthPlanEnrollment_1_0_0.Health_Plan_Enrollment_Criteria(a_, q_, ab_, (int?)45);
		var ad_ = context.Operators.And(m_, ac_);
		var ag_ = context.Operators.End(b_);
		var ah_ = context.Operators.DateFrom(ag_);
		var aj_ = context.Operators.Start(b_);
		var ak_ = context.Operators.DateFrom(aj_);
		var am_ = context.Operators.End(b_);
		var an_ = context.Operators.DateFrom(am_);
		var ao_ = context.Operators.Interval(ak_, an_, true, true);
		var ap_ = NCQAHealthPlanEnrollment_1_0_0.Health_Plan_Enrollment_Criteria(a_, ah_, ao_, (int?)45);
		var aq_ = context.Operators.And(ad_, ap_);

		return aq_;
	}

    [CqlDeclaration("Enrolled During Participation Period")]
	public bool? Enrolled_During_Participation_Period() => 
		__Enrolled_During_Participation_Period.Value;

	private bool? Initial_Population_Value()
	{
		var a_ = this.Patient();
		var b_ = a_?.BirthDateElement;
		var c_ = b_?.Value;
		var d_ = context.Operators.Convert<CqlDate>(c_);
		var e_ = this.Measurement_Period();
		var f_ = context.Operators.End(e_);
		var g_ = context.Operators.DateFrom(f_);
		var h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
		var i_ = context.Operators.Interval((int?)52, (int?)74, true, true);
		var j_ = context.Operators.ElementInInterval<int?>(h_, i_, null);
		var l_ = a_?.GenderElement;
		var m_ = l_?.Value;
		var n_ = context.Operators.EnumEqualsString(m_, "female");
		var o_ = context.Operators.And(j_, n_);
		var p_ = this.Enrolled_During_Participation_Period();
		var q_ = context.Operators.And(o_, p_);

		return q_;
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
		var a_ = this.Absence_of_Right_Breast();
		var b_ = context.Operators.RetrieveByValueSet<Condition>(a_, null);
		var c_ = NCQAStatus_1_0_0.Active_Condition(b_);
		bool? d_(Condition RightMastectomyDiagnosis)
		{
			var f_ = NCQAFHIRBase_1_0_0.Prevalence_Period(RightMastectomyDiagnosis);
			var g_ = context.Operators.Start(f_);
			var h_ = this.Measurement_Period();
			var i_ = context.Operators.End(h_);
			var j_ = context.Operators.SameOrBefore(g_, i_, null);

			return j_;
		};
		var e_ = context.Operators.WhereOrNull<Condition>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Right Mastectomy Diagnosis")]
	public IEnumerable<Condition> Right_Mastectomy_Diagnosis() => 
		__Right_Mastectomy_Diagnosis.Value;

	private IEnumerable<Procedure> Right_Mastectomy_Procedure_Value()
	{
		var a_ = this.Unilateral_Mastectomy_Right();
		var b_ = context.Operators.RetrieveByValueSet<Procedure>(a_, null);
		var c_ = NCQAStatus_1_0_0.Completed_Procedure(b_);
		var d_ = this.Unilateral_Mastectomy();
		var e_ = context.Operators.RetrieveByValueSet<Procedure>(d_, null);
		var f_ = NCQAStatus_1_0_0.Completed_Procedure(e_);
		bool? g_(Procedure UnilateralMastectomyProcedure)
		{
			var r_ = UnilateralMastectomyProcedure?.BodySite;
			CqlConcept s_(CodeableConcept X)
			{
				var w_ = FHIRHelpers_4_0_001.ToConcept(X);

				return w_;
			};
			var t_ = context.Operators.SelectOrNull<CodeableConcept, CqlConcept>((r_ as IEnumerable<CodeableConcept>), s_);
			var u_ = this.Right_Modifier();
			var v_ = context.Operators.ConceptsInValueSet(t_, u_);

			return v_;
		};
		var h_ = context.Operators.WhereOrNull<Procedure>(f_, g_);
		var i_ = context.Operators.ListUnion<Procedure>(c_, h_);
		var j_ = this.Clinical_Unilateral_Mastectomy();
		var k_ = context.Operators.RetrieveByValueSet<Procedure>(j_, null);
		var l_ = NCQAStatus_1_0_0.Completed_Procedure(k_);
		bool? m_(Procedure ClinicalUnilateralMastectomyProcedure)
		{
			var x_ = ClinicalUnilateralMastectomyProcedure?.BodySite;
			CqlConcept y_(CodeableConcept X)
			{
				var ac_ = FHIRHelpers_4_0_001.ToConcept(X);

				return ac_;
			};
			var z_ = context.Operators.SelectOrNull<CodeableConcept, CqlConcept>((x_ as IEnumerable<CodeableConcept>), y_);
			var aa_ = this.Clinical_Right_Modifier();
			var ab_ = context.Operators.ConceptsInValueSet(z_, aa_);

			return ab_;
		};
		var n_ = context.Operators.WhereOrNull<Procedure>(l_, m_);
		var o_ = context.Operators.ListUnion<Procedure>(i_, n_);
		bool? p_(Procedure RightMastectomyProcedure)
		{
			var ad_ = RightMastectomyProcedure?.Performed;
			var ae_ = NCQAFHIRBase_1_0_0.Normalize_Interval(ad_);
			var af_ = context.Operators.End(ae_);
			var ag_ = this.Measurement_Period();
			var ah_ = context.Operators.End(ag_);
			var ai_ = context.Operators.SameOrBefore(af_, ah_, null);

			return ai_;
		};
		var q_ = context.Operators.WhereOrNull<Procedure>(o_, p_);

		return q_;
	}

    [CqlDeclaration("Right Mastectomy Procedure")]
	public IEnumerable<Procedure> Right_Mastectomy_Procedure() => 
		__Right_Mastectomy_Procedure.Value;

	private IEnumerable<Condition> Left_Mastectomy_Diagnosis_Value()
	{
		var a_ = this.Absence_of_Left_Breast();
		var b_ = context.Operators.RetrieveByValueSet<Condition>(a_, null);
		var c_ = NCQAStatus_1_0_0.Active_Condition(b_);
		bool? d_(Condition LeftMastectomyDiagnosis)
		{
			var f_ = NCQAFHIRBase_1_0_0.Prevalence_Period(LeftMastectomyDiagnosis);
			var g_ = context.Operators.Start(f_);
			var h_ = this.Measurement_Period();
			var i_ = context.Operators.End(h_);
			var j_ = context.Operators.SameOrBefore(g_, i_, null);

			return j_;
		};
		var e_ = context.Operators.WhereOrNull<Condition>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Left Mastectomy Diagnosis")]
	public IEnumerable<Condition> Left_Mastectomy_Diagnosis() => 
		__Left_Mastectomy_Diagnosis.Value;

	private IEnumerable<Procedure> Left_Mastectomy_Procedure_Value()
	{
		var a_ = this.Unilateral_Mastectomy_Left();
		var b_ = context.Operators.RetrieveByValueSet<Procedure>(a_, null);
		var c_ = NCQAStatus_1_0_0.Completed_Procedure(b_);
		var d_ = this.Unilateral_Mastectomy();
		var e_ = context.Operators.RetrieveByValueSet<Procedure>(d_, null);
		var f_ = NCQAStatus_1_0_0.Completed_Procedure(e_);
		bool? g_(Procedure UnilateralMastectomyProcedure)
		{
			var r_ = UnilateralMastectomyProcedure?.BodySite;
			CqlConcept s_(CodeableConcept X)
			{
				var w_ = FHIRHelpers_4_0_001.ToConcept(X);

				return w_;
			};
			var t_ = context.Operators.SelectOrNull<CodeableConcept, CqlConcept>((r_ as IEnumerable<CodeableConcept>), s_);
			var u_ = this.Left_Modifier();
			var v_ = context.Operators.ConceptsInValueSet(t_, u_);

			return v_;
		};
		var h_ = context.Operators.WhereOrNull<Procedure>(f_, g_);
		var i_ = context.Operators.ListUnion<Procedure>(c_, h_);
		var j_ = this.Clinical_Unilateral_Mastectomy();
		var k_ = context.Operators.RetrieveByValueSet<Procedure>(j_, null);
		var l_ = NCQAStatus_1_0_0.Completed_Procedure(k_);
		bool? m_(Procedure ClinicalUnilateralMastectomyProcedure)
		{
			var x_ = ClinicalUnilateralMastectomyProcedure?.BodySite;
			CqlConcept y_(CodeableConcept X)
			{
				var ac_ = FHIRHelpers_4_0_001.ToConcept(X);

				return ac_;
			};
			var z_ = context.Operators.SelectOrNull<CodeableConcept, CqlConcept>((x_ as IEnumerable<CodeableConcept>), y_);
			var aa_ = this.Clinical_Left_Modifier();
			var ab_ = context.Operators.ConceptsInValueSet(z_, aa_);

			return ab_;
		};
		var n_ = context.Operators.WhereOrNull<Procedure>(l_, m_);
		var o_ = context.Operators.ListUnion<Procedure>(i_, n_);
		bool? p_(Procedure LeftMastectomyProcedure)
		{
			var ad_ = LeftMastectomyProcedure?.Performed;
			var ae_ = NCQAFHIRBase_1_0_0.Normalize_Interval(ad_);
			var af_ = context.Operators.End(ae_);
			var ag_ = this.Measurement_Period();
			var ah_ = context.Operators.End(ag_);
			var ai_ = context.Operators.SameOrBefore(af_, ah_, null);

			return ai_;
		};
		var q_ = context.Operators.WhereOrNull<Procedure>(o_, p_);

		return q_;
	}

    [CqlDeclaration("Left Mastectomy Procedure")]
	public IEnumerable<Procedure> Left_Mastectomy_Procedure() => 
		__Left_Mastectomy_Procedure.Value;

	private IEnumerable<Condition> Bilateral_Mastectomy_Diagnosis_Value()
	{
		var a_ = this.History_of_Bilateral_Mastectomy();
		var b_ = context.Operators.RetrieveByValueSet<Condition>(a_, null);
		var c_ = NCQAStatus_1_0_0.Active_Condition(b_);
		bool? d_(Condition BilateralMastectomyHistory)
		{
			var f_ = NCQAFHIRBase_1_0_0.Prevalence_Period(BilateralMastectomyHistory);
			var g_ = context.Operators.Start(f_);
			var h_ = this.Measurement_Period();
			var i_ = context.Operators.End(h_);
			var j_ = context.Operators.SameOrBefore(g_, i_, null);

			return j_;
		};
		var e_ = context.Operators.WhereOrNull<Condition>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Bilateral Mastectomy Diagnosis")]
	public IEnumerable<Condition> Bilateral_Mastectomy_Diagnosis() => 
		__Bilateral_Mastectomy_Diagnosis.Value;

	private IEnumerable<Procedure> Bilateral_Mastectomy_Procedure_Value()
	{
		var a_ = this.Bilateral_Mastectomy();
		var b_ = context.Operators.RetrieveByValueSet<Procedure>(a_, null);
		var c_ = NCQAStatus_1_0_0.Completed_Procedure(b_);
		var d_ = this.Unilateral_Mastectomy();
		var e_ = context.Operators.RetrieveByValueSet<Procedure>(d_, null);
		var f_ = NCQAStatus_1_0_0.Completed_Procedure(e_);
		bool? g_(Procedure UnilateralMastectomyProcedure)
		{
			var r_ = UnilateralMastectomyProcedure?.BodySite;
			CqlConcept s_(CodeableConcept X)
			{
				var w_ = FHIRHelpers_4_0_001.ToConcept(X);

				return w_;
			};
			var t_ = context.Operators.SelectOrNull<CodeableConcept, CqlConcept>((r_ as IEnumerable<CodeableConcept>), s_);
			var u_ = this.Bilateral_Modifier();
			var v_ = context.Operators.ConceptsInValueSet(t_, u_);

			return v_;
		};
		var h_ = context.Operators.WhereOrNull<Procedure>(f_, g_);
		var i_ = context.Operators.ListUnion<Procedure>(c_, h_);
		var j_ = this.Clinical_Unilateral_Mastectomy();
		var k_ = context.Operators.RetrieveByValueSet<Procedure>(j_, null);
		var l_ = NCQAStatus_1_0_0.Completed_Procedure(k_);
		bool? m_(Procedure ClinicalUnilateralMastectomyProcedure)
		{
			var x_ = ClinicalUnilateralMastectomyProcedure?.BodySite;
			CqlConcept y_(CodeableConcept X)
			{
				var ac_ = FHIRHelpers_4_0_001.ToConcept(X);

				return ac_;
			};
			var z_ = context.Operators.SelectOrNull<CodeableConcept, CqlConcept>((x_ as IEnumerable<CodeableConcept>), y_);
			var aa_ = this.Clinical_Bilateral_Modifier();
			var ab_ = context.Operators.ConceptsInValueSet(z_, aa_);

			return ab_;
		};
		var n_ = context.Operators.WhereOrNull<Procedure>(l_, m_);
		var o_ = context.Operators.ListUnion<Procedure>(i_, n_);
		bool? p_(Procedure BilateralMastectomyPerformed)
		{
			var ad_ = BilateralMastectomyPerformed?.Performed;
			var ae_ = NCQAFHIRBase_1_0_0.Normalize_Interval(ad_);
			var af_ = context.Operators.End(ae_);
			var ag_ = this.Measurement_Period();
			var ah_ = context.Operators.End(ag_);
			var ai_ = context.Operators.SameOrBefore(af_, ah_, null);

			return ai_;
		};
		var q_ = context.Operators.WhereOrNull<Procedure>(o_, p_);

		return q_;
	}

    [CqlDeclaration("Bilateral Mastectomy Procedure")]
	public IEnumerable<Procedure> Bilateral_Mastectomy_Procedure() => 
		__Bilateral_Mastectomy_Procedure.Value;

	private bool? Mastectomy_Exclusion_Value()
	{
		var a_ = this.Right_Mastectomy_Diagnosis();
		var b_ = context.Operators.ExistsInList<Condition>(a_);
		var c_ = this.Right_Mastectomy_Procedure();
		var d_ = context.Operators.ExistsInList<Procedure>(c_);
		var e_ = context.Operators.Or(b_, d_);
		var f_ = this.Left_Mastectomy_Diagnosis();
		var g_ = context.Operators.ExistsInList<Condition>(f_);
		var h_ = this.Left_Mastectomy_Procedure();
		var i_ = context.Operators.ExistsInList<Procedure>(h_);
		var j_ = context.Operators.Or(g_, i_);
		var k_ = context.Operators.And(e_, j_);
		var l_ = this.Bilateral_Mastectomy_Diagnosis();
		var m_ = context.Operators.ExistsInList<Condition>(l_);
		var n_ = context.Operators.Or(k_, m_);
		var o_ = this.Bilateral_Mastectomy_Procedure();
		var p_ = context.Operators.ExistsInList<Procedure>(o_);
		var q_ = context.Operators.Or(n_, p_);

		return q_;
	}

    [CqlDeclaration("Mastectomy Exclusion")]
	public bool? Mastectomy_Exclusion() => 
		__Mastectomy_Exclusion.Value;

	private bool? Exclusions_Value()
	{
		var a_ = NCQAHospice_1_0_0.Hospice_Intervention_or_Encounter();
		var b_ = this.Mastectomy_Exclusion();
		var c_ = context.Operators.Or(a_, b_);
		var d_ = NCQAAdvancedIllnessandFrailty_1_0_0.Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80();
		var e_ = context.Operators.Or(c_, d_);
		var f_ = this.Measurement_Period();
		var g_ = NCQAPalliativeCare_1_0_0.Palliative_Care_Overlapping_Period(f_);
		var h_ = context.Operators.Or(e_, g_);

		return h_;
	}

    [CqlDeclaration("Exclusions")]
	public bool? Exclusions() => 
		__Exclusions.Value;

	private bool? Numerator_Value()
	{
		var a_ = this.Mammography();
		var b_ = context.Operators.RetrieveByValueSet<Observation>(a_, null);
		bool? c_(Observation Mammogram)
		{
			var f_ = Mammogram?.Effective;
			var g_ = NCQAFHIRBase_1_0_0.Normalize_Interval(f_);
			var h_ = context.Operators.End(g_);
			var i_ = this.Participation_Period();
			var j_ = context.Operators.ElementInInterval<CqlDateTime>(h_, i_, null);

			return j_;
		};
		var d_ = context.Operators.WhereOrNull<Observation>(b_, c_);
		var e_ = context.Operators.ExistsInList<Observation>(d_);

		return e_;
	}

    [CqlDeclaration("Numerator")]
	public bool? Numerator() => 
		__Numerator.Value;

}