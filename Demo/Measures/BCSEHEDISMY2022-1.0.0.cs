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

    private CqlValueSet Absence_of_Left_Breast_Value()
	{
		var a_ = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1329", null);

		return a_;
	}

    [CqlDeclaration("Absence of Left Breast")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1329")]
    public CqlValueSet Absence_of_Left_Breast() => __Absence_of_Left_Breast.Value;

    private CqlValueSet Absence_of_Right_Breast_Value()
	{
		var a_ = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1330", null);

		return a_;
	}

    [CqlDeclaration("Absence of Right Breast")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1330")]
    public CqlValueSet Absence_of_Right_Breast() => __Absence_of_Right_Breast.Value;

    private CqlValueSet Bilateral_Mastectomy_Value()
	{
		var a_ = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1042", null);

		return a_;
	}

    [CqlDeclaration("Bilateral Mastectomy")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1042")]
    public CqlValueSet Bilateral_Mastectomy() => __Bilateral_Mastectomy.Value;

    private CqlValueSet Bilateral_Modifier_Value()
	{
		var a_ = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1043", null);

		return a_;
	}

    [CqlDeclaration("Bilateral Modifier")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1043")]
    public CqlValueSet Bilateral_Modifier() => __Bilateral_Modifier.Value;

    private CqlValueSet Clinical_Bilateral_Modifier_Value()
	{
		var a_ = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1951", null);

		return a_;
	}

    [CqlDeclaration("Clinical Bilateral Modifier")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1951")]
    public CqlValueSet Clinical_Bilateral_Modifier() => __Clinical_Bilateral_Modifier.Value;

    private CqlValueSet Clinical_Left_Modifier_Value()
	{
		var a_ = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1949", null);

		return a_;
	}

    [CqlDeclaration("Clinical Left Modifier")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1949")]
    public CqlValueSet Clinical_Left_Modifier() => __Clinical_Left_Modifier.Value;

    private CqlValueSet Clinical_Right_Modifier_Value()
	{
		var a_ = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1950", null);

		return a_;
	}

    [CqlDeclaration("Clinical Right Modifier")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1950")]
    public CqlValueSet Clinical_Right_Modifier() => __Clinical_Right_Modifier.Value;

    private CqlValueSet Clinical_Unilateral_Mastectomy_Value()
	{
		var a_ = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1948", null);

		return a_;
	}

    [CqlDeclaration("Clinical Unilateral Mastectomy")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1948")]
    public CqlValueSet Clinical_Unilateral_Mastectomy() => __Clinical_Unilateral_Mastectomy.Value;

    private CqlValueSet History_of_Bilateral_Mastectomy_Value()
	{
		var a_ = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1331", null);

		return a_;
	}

    [CqlDeclaration("History of Bilateral Mastectomy")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1331")]
    public CqlValueSet History_of_Bilateral_Mastectomy() => __History_of_Bilateral_Mastectomy.Value;

    private CqlValueSet Left_Modifier_Value()
	{
		var a_ = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1148", null);

		return a_;
	}

    [CqlDeclaration("Left Modifier")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1148")]
    public CqlValueSet Left_Modifier() => __Left_Modifier.Value;

    private CqlValueSet Mammography_Value()
	{
		var a_ = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1168", null);

		return a_;
	}

    [CqlDeclaration("Mammography")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1168")]
    public CqlValueSet Mammography() => __Mammography.Value;

    private CqlValueSet Right_Modifier_Value()
	{
		var a_ = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1230", null);

		return a_;
	}

    [CqlDeclaration("Right Modifier")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1230")]
    public CqlValueSet Right_Modifier() => __Right_Modifier.Value;

    private CqlValueSet Unilateral_Mastectomy_Value()
	{
		var a_ = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1256", null);

		return a_;
	}

    [CqlDeclaration("Unilateral Mastectomy")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1256")]
    public CqlValueSet Unilateral_Mastectomy() => __Unilateral_Mastectomy.Value;

    private CqlValueSet Unilateral_Mastectomy_Left_Value()
	{
		var a_ = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1334", null);

		return a_;
	}

    [CqlDeclaration("Unilateral Mastectomy Left")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1334")]
    public CqlValueSet Unilateral_Mastectomy_Left() => __Unilateral_Mastectomy_Left.Value;

    private CqlValueSet Unilateral_Mastectomy_Right_Value()
	{
		var a_ = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1335", null);

		return a_;
	}

    [CqlDeclaration("Unilateral Mastectomy Right")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1335")]
    public CqlValueSet Unilateral_Mastectomy_Right() => __Unilateral_Mastectomy_Right.Value;

    private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		var a_ = context.ResolveParameter("BCSEHEDISMY2022-1.0.0", "Measurement Period", null);
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

    private CqlDateTime October_1_Two_Years_Prior_to_the_Measurement_Period_Value()
	{
		var a_ = this.Measurement_Period();
		var b_ = context.Operators;
		var c_ = b_.Start(a_);
		var e_ = b_.ComponentFrom(c_, "year");
		var f_ = (int?)2;
		var h_ = b_.Subtract(e_, f_);
		var i_ = (int?)10;
		var j_ = (int?)1;
		var k_ = (int?)0;
		var q_ = b_.ConvertIntegerToDecimal(k_);
		var s_ = b_.DateTime(h_, i_, j_, k_, k_, k_, k_, q_);

		return s_;
	}

    [CqlDeclaration("October 1 Two Years Prior to the Measurement Period")]
    public CqlDateTime October_1_Two_Years_Prior_to_the_Measurement_Period() => __October_1_Two_Years_Prior_to_the_Measurement_Period.Value;

    private CqlInterval<CqlDateTime> Participation_Period_Value()
	{
		var a_ = this.October_1_Two_Years_Prior_to_the_Measurement_Period();
		var b_ = this.Measurement_Period();
		var c_ = context.Operators;
		var d_ = c_.End(b_);
		var f_ = c_.Interval(a_, d_, true, true);

		return f_;
	}

    [CqlDeclaration("Participation Period")]
    public CqlInterval<CqlDateTime> Participation_Period() => __Participation_Period.Value;

    private IEnumerable<Coverage> Member_Coverage_Value()
	{
		var a_ = context.DataRetriever;
		var b_ = a_.RetrieveByValueSet<Coverage>(null, null);
		var c_ = (Coverage C) =>
		{
			var f_ = C.Period;
			var g_ = NCQAFHIRBase_1_0_0.Normalize_Interval(f_);
			var h_ = this.Participation_Period();
			var i_ = context.Operators;
			var j_ = i_.Overlaps(g_, h_, null);

			return j_;
		};
		var d_ = context.Operators;
		var e_ = d_.WhereOrNull<Coverage>(b_, c_);

		return e_;
	}

    [CqlDeclaration("Member Coverage")]
    public IEnumerable<Coverage> Member_Coverage() => __Member_Coverage.Value;

    private bool? Enrolled_During_Participation_Period_Value()
	{
		var a_ = this.Member_Coverage();
		var b_ = this.Measurement_Period();
		var c_ = context.Operators;
		var d_ = c_.End(b_);
		var f_ = c_.DateFrom(d_);
		var g_ = this.October_1_Two_Years_Prior_to_the_Measurement_Period();
		var i_ = c_.DateFrom(g_);
		var l_ = c_.End(b_);
		var n_ = c_.DateFrom(l_);
		var p_ = c_.Quantity(2m, "years");
		var r_ = c_.Subtract(n_, p_);
		var t_ = c_.Interval(i_, r_, true, true);
		var u_ = (int?)0;
		var v_ = NCQAHealthPlanEnrollment_1_0_0.Health_Plan_Enrollment_Criteria(a_, f_, t_, u_);
		var z_ = c_.End(b_);
		var ab_ = c_.DateFrom(z_);
		var ae_ = c_.Start(b_);
		var ag_ = c_.DateFrom(ae_);
		var ai_ = c_.Quantity(1m, "year");
		var ak_ = c_.Subtract(ag_, ai_);
		var an_ = c_.End(b_);
		var ap_ = c_.DateFrom(an_);
		var ar_ = c_.Quantity(1m, "year");
		var at_ = c_.Subtract(ap_, ar_);
		var av_ = c_.Interval(ak_, at_, true, true);
		var aw_ = (int?)45;
		var ax_ = NCQAHealthPlanEnrollment_1_0_0.Health_Plan_Enrollment_Criteria(a_, ab_, av_, aw_);
		var az_ = c_.And(v_, ax_);
		var bd_ = c_.End(b_);
		var bf_ = c_.DateFrom(bd_);
		var bi_ = c_.Start(b_);
		var bk_ = c_.DateFrom(bi_);
		var bn_ = c_.End(b_);
		var bp_ = c_.DateFrom(bn_);
		var br_ = c_.Interval(bk_, bp_, true, true);
		var bt_ = NCQAHealthPlanEnrollment_1_0_0.Health_Plan_Enrollment_Criteria(a_, bf_, br_, aw_);
		var bv_ = c_.And(az_, bt_);

		return bv_;
	}

    [CqlDeclaration("Enrolled During Participation Period")]
    public bool? Enrolled_During_Participation_Period() => __Enrolled_During_Participation_Period.Value;

    private bool? Initial_Population_Value()
	{
		var a_ = this.Patient();
		var b_ = a_.BirthDateElement;
		var c_ = b_.Value;
		var d_ = context.Operators;
		var e_ = d_.TypeConverter;
		var f_ = e_.Convert<CqlDate>(c_);
		var g_ = this.Measurement_Period();
		var i_ = d_.End(g_);
		var k_ = d_.DateFrom(i_);
		var m_ = d_.CalculateAgeAt(f_, k_, "year");
		var n_ = (int?)52;
		var o_ = (int?)74;
		var q_ = d_.Interval(n_, o_, true, true);
		var s_ = d_.ElementInInterval<int?>(m_, q_, null);
		var u_ = a_.GenderElement;
		var v_ = u_.Value;
		var w_ = v_;
		var y_ = d_.EnumEqualsString(w_, "female");
		var aa_ = d_.And(s_, y_);
		var ab_ = this.Enrolled_During_Participation_Period();
		var ad_ = d_.And(aa_, ab_);

		return ad_;
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
		var a_ = this.Absence_of_Right_Breast();
		var b_ = context.DataRetriever;
		var c_ = b_.RetrieveByValueSet<Condition>(a_, null);
		var d_ = NCQAStatus_1_0_0.Active_Condition(c_);
		var e_ = (Condition RightMastectomyDiagnosis) =>
		{
			var h_ = NCQAFHIRBase_1_0_0.Prevalence_Period(RightMastectomyDiagnosis);
			var i_ = context.Operators;
			var j_ = i_.Start(h_);
			var k_ = this.Measurement_Period();
			var m_ = i_.End(k_);
			var o_ = i_.SameOrBefore(j_, m_, null);

			return o_;
		};
		var f_ = context.Operators;
		var g_ = f_.WhereOrNull<Condition>(d_, e_);

		return g_;
	}

    [CqlDeclaration("Right Mastectomy Diagnosis")]
    public IEnumerable<Condition> Right_Mastectomy_Diagnosis() => __Right_Mastectomy_Diagnosis.Value;

    private IEnumerable<Procedure> Right_Mastectomy_Procedure_Value()
	{
		var a_ = this.Unilateral_Mastectomy_Right();
		var b_ = context.DataRetriever;
		var c_ = b_.RetrieveByValueSet<Procedure>(a_, null);
		var d_ = NCQAStatus_1_0_0.Completed_Procedure(c_);
		var e_ = this.Unilateral_Mastectomy();
		var g_ = b_.RetrieveByValueSet<Procedure>(e_, null);
		var h_ = NCQAStatus_1_0_0.Completed_Procedure(g_);
		var i_ = (Procedure UnilateralMastectomyProcedure) =>
		{
			var z_ = UnilateralMastectomyProcedure.BodySite;
			var aa_ = (z_ as IEnumerable<CodeableConcept>);
			var ab_ = (CodeableConcept X) =>
			{
				var ah_ = FHIRHelpers_4_0_001.ToConcept(X);

				return ah_;
			};
			var ac_ = context.Operators;
			var ad_ = ac_.SelectOrNull<CodeableConcept, CqlConcept>(aa_, ab_);
			var ae_ = this.Right_Modifier();
			var ag_ = ac_.ConceptsInValueSet(ad_, ae_);

			return ag_;
		};
		var j_ = context.Operators;
		var k_ = j_.WhereOrNull<Procedure>(h_, i_);
		var m_ = j_.ListUnion<Procedure>(d_, k_);
		var n_ = this.Clinical_Unilateral_Mastectomy();
		var p_ = b_.RetrieveByValueSet<Procedure>(n_, null);
		var q_ = NCQAStatus_1_0_0.Completed_Procedure(p_);
		var r_ = (Procedure ClinicalUnilateralMastectomyProcedure) =>
		{
			var ai_ = ClinicalUnilateralMastectomyProcedure.BodySite;
			var aj_ = (ai_ as IEnumerable<CodeableConcept>);
			var ak_ = (CodeableConcept X) =>
			{
				var aq_ = FHIRHelpers_4_0_001.ToConcept(X);

				return aq_;
			};
			var al_ = context.Operators;
			var am_ = al_.SelectOrNull<CodeableConcept, CqlConcept>(aj_, ak_);
			var an_ = this.Clinical_Right_Modifier();
			var ap_ = al_.ConceptsInValueSet(am_, an_);

			return ap_;
		};
		var t_ = j_.WhereOrNull<Procedure>(q_, r_);
		var v_ = j_.ListUnion<Procedure>(m_, t_);
		var w_ = (Procedure RightMastectomyProcedure) =>
		{
			var ar_ = RightMastectomyProcedure.Performed;
			var as_ = NCQAFHIRBase_1_0_0.Normalize_Interval(ar_);
			var at_ = context.Operators;
			var au_ = at_.End(as_);
			var av_ = this.Measurement_Period();
			var ax_ = at_.End(av_);
			var az_ = at_.SameOrBefore(au_, ax_, null);

			return az_;
		};
		var y_ = j_.WhereOrNull<Procedure>(v_, w_);

		return y_;
	}

    [CqlDeclaration("Right Mastectomy Procedure")]
    public IEnumerable<Procedure> Right_Mastectomy_Procedure() => __Right_Mastectomy_Procedure.Value;

    private IEnumerable<Condition> Left_Mastectomy_Diagnosis_Value()
	{
		var a_ = this.Absence_of_Left_Breast();
		var b_ = context.DataRetriever;
		var c_ = b_.RetrieveByValueSet<Condition>(a_, null);
		var d_ = NCQAStatus_1_0_0.Active_Condition(c_);
		var e_ = (Condition LeftMastectomyDiagnosis) =>
		{
			var h_ = NCQAFHIRBase_1_0_0.Prevalence_Period(LeftMastectomyDiagnosis);
			var i_ = context.Operators;
			var j_ = i_.Start(h_);
			var k_ = this.Measurement_Period();
			var m_ = i_.End(k_);
			var o_ = i_.SameOrBefore(j_, m_, null);

			return o_;
		};
		var f_ = context.Operators;
		var g_ = f_.WhereOrNull<Condition>(d_, e_);

		return g_;
	}

    [CqlDeclaration("Left Mastectomy Diagnosis")]
    public IEnumerable<Condition> Left_Mastectomy_Diagnosis() => __Left_Mastectomy_Diagnosis.Value;

    private IEnumerable<Procedure> Left_Mastectomy_Procedure_Value()
	{
		var a_ = this.Unilateral_Mastectomy_Left();
		var b_ = context.DataRetriever;
		var c_ = b_.RetrieveByValueSet<Procedure>(a_, null);
		var d_ = NCQAStatus_1_0_0.Completed_Procedure(c_);
		var e_ = this.Unilateral_Mastectomy();
		var g_ = b_.RetrieveByValueSet<Procedure>(e_, null);
		var h_ = NCQAStatus_1_0_0.Completed_Procedure(g_);
		var i_ = (Procedure UnilateralMastectomyProcedure) =>
		{
			var z_ = UnilateralMastectomyProcedure.BodySite;
			var aa_ = (z_ as IEnumerable<CodeableConcept>);
			var ab_ = (CodeableConcept X) =>
			{
				var ah_ = FHIRHelpers_4_0_001.ToConcept(X);

				return ah_;
			};
			var ac_ = context.Operators;
			var ad_ = ac_.SelectOrNull<CodeableConcept, CqlConcept>(aa_, ab_);
			var ae_ = this.Left_Modifier();
			var ag_ = ac_.ConceptsInValueSet(ad_, ae_);

			return ag_;
		};
		var j_ = context.Operators;
		var k_ = j_.WhereOrNull<Procedure>(h_, i_);
		var m_ = j_.ListUnion<Procedure>(d_, k_);
		var n_ = this.Clinical_Unilateral_Mastectomy();
		var p_ = b_.RetrieveByValueSet<Procedure>(n_, null);
		var q_ = NCQAStatus_1_0_0.Completed_Procedure(p_);
		var r_ = (Procedure ClinicalUnilateralMastectomyProcedure) =>
		{
			var ai_ = ClinicalUnilateralMastectomyProcedure.BodySite;
			var aj_ = (ai_ as IEnumerable<CodeableConcept>);
			var ak_ = (CodeableConcept X) =>
			{
				var aq_ = FHIRHelpers_4_0_001.ToConcept(X);

				return aq_;
			};
			var al_ = context.Operators;
			var am_ = al_.SelectOrNull<CodeableConcept, CqlConcept>(aj_, ak_);
			var an_ = this.Clinical_Left_Modifier();
			var ap_ = al_.ConceptsInValueSet(am_, an_);

			return ap_;
		};
		var t_ = j_.WhereOrNull<Procedure>(q_, r_);
		var v_ = j_.ListUnion<Procedure>(m_, t_);
		var w_ = (Procedure LeftMastectomyProcedure) =>
		{
			var ar_ = LeftMastectomyProcedure.Performed;
			var as_ = NCQAFHIRBase_1_0_0.Normalize_Interval(ar_);
			var at_ = context.Operators;
			var au_ = at_.End(as_);
			var av_ = this.Measurement_Period();
			var ax_ = at_.End(av_);
			var az_ = at_.SameOrBefore(au_, ax_, null);

			return az_;
		};
		var y_ = j_.WhereOrNull<Procedure>(v_, w_);

		return y_;
	}

    [CqlDeclaration("Left Mastectomy Procedure")]
    public IEnumerable<Procedure> Left_Mastectomy_Procedure() => __Left_Mastectomy_Procedure.Value;

    private IEnumerable<Condition> Bilateral_Mastectomy_Diagnosis_Value()
	{
		var a_ = this.History_of_Bilateral_Mastectomy();
		var b_ = context.DataRetriever;
		var c_ = b_.RetrieveByValueSet<Condition>(a_, null);
		var d_ = NCQAStatus_1_0_0.Active_Condition(c_);
		var e_ = (Condition BilateralMastectomyHistory) =>
		{
			var h_ = NCQAFHIRBase_1_0_0.Prevalence_Period(BilateralMastectomyHistory);
			var i_ = context.Operators;
			var j_ = i_.Start(h_);
			var k_ = this.Measurement_Period();
			var m_ = i_.End(k_);
			var o_ = i_.SameOrBefore(j_, m_, null);

			return o_;
		};
		var f_ = context.Operators;
		var g_ = f_.WhereOrNull<Condition>(d_, e_);

		return g_;
	}

    [CqlDeclaration("Bilateral Mastectomy Diagnosis")]
    public IEnumerable<Condition> Bilateral_Mastectomy_Diagnosis() => __Bilateral_Mastectomy_Diagnosis.Value;

    private IEnumerable<Procedure> Bilateral_Mastectomy_Procedure_Value()
	{
		var a_ = this.Bilateral_Mastectomy();
		var b_ = context.DataRetriever;
		var c_ = b_.RetrieveByValueSet<Procedure>(a_, null);
		var d_ = NCQAStatus_1_0_0.Completed_Procedure(c_);
		var e_ = this.Unilateral_Mastectomy();
		var g_ = b_.RetrieveByValueSet<Procedure>(e_, null);
		var h_ = NCQAStatus_1_0_0.Completed_Procedure(g_);
		var i_ = (Procedure UnilateralMastectomyProcedure) =>
		{
			var z_ = UnilateralMastectomyProcedure.BodySite;
			var aa_ = (z_ as IEnumerable<CodeableConcept>);
			var ab_ = (CodeableConcept X) =>
			{
				var ah_ = FHIRHelpers_4_0_001.ToConcept(X);

				return ah_;
			};
			var ac_ = context.Operators;
			var ad_ = ac_.SelectOrNull<CodeableConcept, CqlConcept>(aa_, ab_);
			var ae_ = this.Bilateral_Modifier();
			var ag_ = ac_.ConceptsInValueSet(ad_, ae_);

			return ag_;
		};
		var j_ = context.Operators;
		var k_ = j_.WhereOrNull<Procedure>(h_, i_);
		var m_ = j_.ListUnion<Procedure>(d_, k_);
		var n_ = this.Clinical_Unilateral_Mastectomy();
		var p_ = b_.RetrieveByValueSet<Procedure>(n_, null);
		var q_ = NCQAStatus_1_0_0.Completed_Procedure(p_);
		var r_ = (Procedure ClinicalUnilateralMastectomyProcedure) =>
		{
			var ai_ = ClinicalUnilateralMastectomyProcedure.BodySite;
			var aj_ = (ai_ as IEnumerable<CodeableConcept>);
			var ak_ = (CodeableConcept X) =>
			{
				var aq_ = FHIRHelpers_4_0_001.ToConcept(X);

				return aq_;
			};
			var al_ = context.Operators;
			var am_ = al_.SelectOrNull<CodeableConcept, CqlConcept>(aj_, ak_);
			var an_ = this.Clinical_Bilateral_Modifier();
			var ap_ = al_.ConceptsInValueSet(am_, an_);

			return ap_;
		};
		var t_ = j_.WhereOrNull<Procedure>(q_, r_);
		var v_ = j_.ListUnion<Procedure>(m_, t_);
		var w_ = (Procedure BilateralMastectomyPerformed) =>
		{
			var ar_ = BilateralMastectomyPerformed.Performed;
			var as_ = NCQAFHIRBase_1_0_0.Normalize_Interval(ar_);
			var at_ = context.Operators;
			var au_ = at_.End(as_);
			var av_ = this.Measurement_Period();
			var ax_ = at_.End(av_);
			var az_ = at_.SameOrBefore(au_, ax_, null);

			return az_;
		};
		var y_ = j_.WhereOrNull<Procedure>(v_, w_);

		return y_;
	}

    [CqlDeclaration("Bilateral Mastectomy Procedure")]
    public IEnumerable<Procedure> Bilateral_Mastectomy_Procedure() => __Bilateral_Mastectomy_Procedure.Value;

    private bool? Mastectomy_Exclusion_Value()
	{
		var a_ = this.Right_Mastectomy_Diagnosis();
		var b_ = context.Operators;
		var c_ = b_.ExistsInList<Condition>(a_);
		var d_ = this.Right_Mastectomy_Procedure();
		var f_ = b_.ExistsInList<Procedure>(d_);
		var h_ = b_.Or(c_, f_);
		var i_ = this.Left_Mastectomy_Diagnosis();
		var k_ = b_.ExistsInList<Condition>(i_);
		var l_ = this.Left_Mastectomy_Procedure();
		var n_ = b_.ExistsInList<Procedure>(l_);
		var p_ = b_.Or(k_, n_);
		var r_ = b_.And(h_, p_);
		var s_ = this.Bilateral_Mastectomy_Diagnosis();
		var u_ = b_.ExistsInList<Condition>(s_);
		var w_ = b_.Or(r_, u_);
		var x_ = this.Bilateral_Mastectomy_Procedure();
		var z_ = b_.ExistsInList<Procedure>(x_);
		var ab_ = b_.Or(w_, z_);

		return ab_;
	}

    [CqlDeclaration("Mastectomy Exclusion")]
    public bool? Mastectomy_Exclusion() => __Mastectomy_Exclusion.Value;

    private bool? Exclusions_Value()
	{
		var a_ = NCQAHospice_1_0_0.Hospice_Intervention_or_Encounter();
		var b_ = this.Mastectomy_Exclusion();
		var c_ = context.Operators;
		var d_ = c_.Or(a_, b_);
		var e_ = NCQAAdvancedIllnessandFrailty_1_0_0.Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80();
		var g_ = c_.Or(d_, e_);
		var h_ = this.Measurement_Period();
		var i_ = NCQAPalliativeCare_1_0_0.Palliative_Care_Overlapping_Period(h_);
		var k_ = c_.Or(g_, i_);

		return k_;
	}

    [CqlDeclaration("Exclusions")]
    public bool? Exclusions() => __Exclusions.Value;

    private bool? Numerator_Value()
	{
		var a_ = this.Mammography();
		var b_ = context.DataRetriever;
		var c_ = b_.RetrieveByValueSet<Observation>(a_, null);
		var d_ = (Observation Mammogram) =>
		{
			var i_ = Mammogram.Effective;
			var j_ = NCQAFHIRBase_1_0_0.Normalize_Interval(i_);
			var k_ = context.Operators;
			var l_ = k_.End(j_);
			var m_ = this.Participation_Period();
			var o_ = k_.ElementInInterval<CqlDateTime>(l_, m_, null);

			return o_;
		};
		var e_ = context.Operators;
		var f_ = e_.WhereOrNull<Observation>(c_, d_);
		var h_ = e_.ExistsInList<Observation>(f_);

		return h_;
	}

    [CqlDeclaration("Numerator")]
    public bool? Numerator() => __Numerator.Value;

}