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
		var a_ = context.Operators;
		var b_ = context.DataRetriever;
		var c_ = b_.RetrieveByValueSet<Patient>(null, null);
		var d_ = a_.SingleOrNull<Patient>(c_);

		return d_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient() => 
		__Patient.Value;

	private CqlDateTime October_1_Two_Years_Prior_to_the_Measurement_Period_Value()
	{
		var a_ = context.Operators;
		var e_ = this.Measurement_Period();
		var f_ = a_.Start(e_);
		var g_ = a_.ComponentFrom(f_, "year");
		var h_ = a_.Subtract(g_, (int?)2);
		var j_ = a_.ConvertIntegerToDecimal((int?)0);
		var k_ = a_.DateTime(h_, (int?)10, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, j_);

		return k_;
	}

    [CqlDeclaration("October 1 Two Years Prior to the Measurement Period")]
	public CqlDateTime October_1_Two_Years_Prior_to_the_Measurement_Period() => 
		__October_1_Two_Years_Prior_to_the_Measurement_Period.Value;

	private CqlInterval<CqlDateTime> Participation_Period_Value()
	{
		var a_ = context.Operators;
		var b_ = this.October_1_Two_Years_Prior_to_the_Measurement_Period();
		var d_ = this.Measurement_Period();
		var e_ = a_.End(d_);
		var f_ = a_.Interval(b_, e_, true, true);

		return f_;
	}

    [CqlDeclaration("Participation Period")]
	public CqlInterval<CqlDateTime> Participation_Period() => 
		__Participation_Period.Value;

	private IEnumerable<Coverage> Member_Coverage_Value()
	{
		var a_ = context.Operators;
		var b_ = context.DataRetriever;
		var c_ = b_.RetrieveByValueSet<Coverage>(null, null);
		bool? d_(Coverage C)
		{
			var f_ = context.Operators;
			var g_ = C?.Period;
			var h_ = NCQAFHIRBase_1_0_0.Normalize_Interval(g_);
			var i_ = this.Participation_Period();
			var j_ = f_.Overlaps(h_, i_, null);

			return j_;
		};
		var e_ = a_.WhereOrNull<Coverage>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Member Coverage")]
	public IEnumerable<Coverage> Member_Coverage() => 
		__Member_Coverage.Value;

	private bool? Enrolled_During_Participation_Period_Value()
	{
		var a_ = context.Operators;
		var c_ = this.Member_Coverage();
		var f_ = this.Measurement_Period();
		var g_ = a_.End(f_);
		var h_ = a_.DateFrom(g_);
		var k_ = this.October_1_Two_Years_Prior_to_the_Measurement_Period();
		var l_ = a_.DateFrom(k_);
		var q_ = a_.End(f_);
		var r_ = a_.DateFrom(q_);
		var t_ = a_.Quantity(2m, "years");
		var u_ = a_.Subtract(r_, t_);
		var v_ = a_.Interval(l_, u_, true, true);
		var w_ = NCQAHealthPlanEnrollment_1_0_0.Health_Plan_Enrollment_Criteria(c_, h_, v_, (int?)0);
		var ab_ = a_.End(f_);
		var ac_ = a_.DateFrom(ab_);
		var ai_ = a_.Start(f_);
		var aj_ = a_.DateFrom(ai_);
		var al_ = a_.Quantity(1m, "year");
		var am_ = a_.Subtract(aj_, al_);
		var ar_ = a_.End(f_);
		var as_ = a_.DateFrom(ar_);
		var au_ = a_.Quantity(1m, "year");
		var av_ = a_.Subtract(as_, au_);
		var aw_ = a_.Interval(am_, av_, true, true);
		var ax_ = NCQAHealthPlanEnrollment_1_0_0.Health_Plan_Enrollment_Criteria(c_, ac_, aw_, (int?)45);
		var ay_ = a_.And(w_, ax_);
		var bd_ = a_.End(f_);
		var be_ = a_.DateFrom(bd_);
		var bj_ = a_.Start(f_);
		var bk_ = a_.DateFrom(bj_);
		var bo_ = a_.End(f_);
		var bp_ = a_.DateFrom(bo_);
		var bq_ = a_.Interval(bk_, bp_, true, true);
		var br_ = NCQAHealthPlanEnrollment_1_0_0.Health_Plan_Enrollment_Criteria(c_, be_, bq_, (int?)45);
		var bs_ = a_.And(ay_, br_);

		return bs_;
	}

    [CqlDeclaration("Enrolled During Participation Period")]
	public bool? Enrolled_During_Participation_Period() => 
		__Enrolled_During_Participation_Period.Value;

	private bool? Initial_Population_Value()
	{
		var a_ = context.Operators;
		var f_ = a_.TypeConverter;
		var g_ = this.Patient();
		var h_ = g_?.BirthDateElement;
		var i_ = h_?.Value;
		var j_ = f_.Convert<CqlDate>(i_);
		var m_ = this.Measurement_Period();
		var n_ = a_.End(m_);
		var o_ = a_.DateFrom(n_);
		var p_ = a_.CalculateAgeAt(j_, o_, "year");
		var r_ = a_.Interval((int?)52, (int?)74, true, true);
		var s_ = a_.ElementInInterval<int?>(p_, r_, null);
		var v_ = g_?.GenderElement;
		var w_ = v_?.Value;
		var x_ = a_.EnumEqualsString(w_, "female");
		var y_ = a_.And(s_, x_);
		var z_ = this.Enrolled_During_Participation_Period();
		var aa_ = a_.And(y_, z_);

		return aa_;
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
		var b_ = context.DataRetriever;
		var c_ = this.Absence_of_Right_Breast();
		var d_ = b_.RetrieveByValueSet<Condition>(c_, null);
		var e_ = NCQAStatus_1_0_0.Active_Condition(d_);
		bool? f_(Condition RightMastectomyDiagnosis)
		{
			var h_ = context.Operators;
			var j_ = NCQAFHIRBase_1_0_0.Prevalence_Period(RightMastectomyDiagnosis);
			var k_ = h_.Start(j_);
			var m_ = this.Measurement_Period();
			var n_ = h_.End(m_);
			var o_ = h_.SameOrBefore(k_, n_, null);

			return o_;
		};
		var g_ = a_.WhereOrNull<Condition>(e_, f_);

		return g_;
	}

    [CqlDeclaration("Right Mastectomy Diagnosis")]
	public IEnumerable<Condition> Right_Mastectomy_Diagnosis() => 
		__Right_Mastectomy_Diagnosis.Value;

	private IEnumerable<Procedure> Right_Mastectomy_Procedure_Value()
	{
		var a_ = context.Operators;
		var d_ = context.DataRetriever;
		var e_ = this.Unilateral_Mastectomy_Right();
		var f_ = d_.RetrieveByValueSet<Procedure>(e_, null);
		var g_ = NCQAStatus_1_0_0.Completed_Procedure(f_);
		var j_ = this.Unilateral_Mastectomy();
		var k_ = d_.RetrieveByValueSet<Procedure>(j_, null);
		var l_ = NCQAStatus_1_0_0.Completed_Procedure(k_);
		bool? m_(Procedure UnilateralMastectomyProcedure)
		{
			var z_ = context.Operators;
			var ab_ = UnilateralMastectomyProcedure?.BodySite;
			CqlConcept ac_(CodeableConcept X)
			{
				var ag_ = FHIRHelpers_4_0_001.ToConcept(X);

				return ag_;
			};
			var ad_ = z_.SelectOrNull<CodeableConcept, CqlConcept>((ab_ as IEnumerable<CodeableConcept>), ac_);
			var ae_ = this.Right_Modifier();
			var af_ = z_.ConceptsInValueSet(ad_, ae_);

			return af_;
		};
		var n_ = a_.WhereOrNull<Procedure>(l_, m_);
		var o_ = a_.ListUnion<Procedure>(g_, n_);
		var r_ = this.Clinical_Unilateral_Mastectomy();
		var s_ = d_.RetrieveByValueSet<Procedure>(r_, null);
		var t_ = NCQAStatus_1_0_0.Completed_Procedure(s_);
		bool? u_(Procedure ClinicalUnilateralMastectomyProcedure)
		{
			var ah_ = context.Operators;
			var aj_ = ClinicalUnilateralMastectomyProcedure?.BodySite;
			CqlConcept ak_(CodeableConcept X)
			{
				var ao_ = FHIRHelpers_4_0_001.ToConcept(X);

				return ao_;
			};
			var al_ = ah_.SelectOrNull<CodeableConcept, CqlConcept>((aj_ as IEnumerable<CodeableConcept>), ak_);
			var am_ = this.Clinical_Right_Modifier();
			var an_ = ah_.ConceptsInValueSet(al_, am_);

			return an_;
		};
		var v_ = a_.WhereOrNull<Procedure>(t_, u_);
		var w_ = a_.ListUnion<Procedure>(o_, v_);
		bool? x_(Procedure RightMastectomyProcedure)
		{
			var ap_ = context.Operators;
			var ar_ = RightMastectomyProcedure?.Performed;
			var as_ = NCQAFHIRBase_1_0_0.Normalize_Interval(ar_);
			var at_ = ap_.End(as_);
			var av_ = this.Measurement_Period();
			var aw_ = ap_.End(av_);
			var ax_ = ap_.SameOrBefore(at_, aw_, null);

			return ax_;
		};
		var y_ = a_.WhereOrNull<Procedure>(w_, x_);

		return y_;
	}

    [CqlDeclaration("Right Mastectomy Procedure")]
	public IEnumerable<Procedure> Right_Mastectomy_Procedure() => 
		__Right_Mastectomy_Procedure.Value;

	private IEnumerable<Condition> Left_Mastectomy_Diagnosis_Value()
	{
		var a_ = context.Operators;
		var b_ = context.DataRetriever;
		var c_ = this.Absence_of_Left_Breast();
		var d_ = b_.RetrieveByValueSet<Condition>(c_, null);
		var e_ = NCQAStatus_1_0_0.Active_Condition(d_);
		bool? f_(Condition LeftMastectomyDiagnosis)
		{
			var h_ = context.Operators;
			var j_ = NCQAFHIRBase_1_0_0.Prevalence_Period(LeftMastectomyDiagnosis);
			var k_ = h_.Start(j_);
			var m_ = this.Measurement_Period();
			var n_ = h_.End(m_);
			var o_ = h_.SameOrBefore(k_, n_, null);

			return o_;
		};
		var g_ = a_.WhereOrNull<Condition>(e_, f_);

		return g_;
	}

    [CqlDeclaration("Left Mastectomy Diagnosis")]
	public IEnumerable<Condition> Left_Mastectomy_Diagnosis() => 
		__Left_Mastectomy_Diagnosis.Value;

	private IEnumerable<Procedure> Left_Mastectomy_Procedure_Value()
	{
		var a_ = context.Operators;
		var d_ = context.DataRetriever;
		var e_ = this.Unilateral_Mastectomy_Left();
		var f_ = d_.RetrieveByValueSet<Procedure>(e_, null);
		var g_ = NCQAStatus_1_0_0.Completed_Procedure(f_);
		var j_ = this.Unilateral_Mastectomy();
		var k_ = d_.RetrieveByValueSet<Procedure>(j_, null);
		var l_ = NCQAStatus_1_0_0.Completed_Procedure(k_);
		bool? m_(Procedure UnilateralMastectomyProcedure)
		{
			var z_ = context.Operators;
			var ab_ = UnilateralMastectomyProcedure?.BodySite;
			CqlConcept ac_(CodeableConcept X)
			{
				var ag_ = FHIRHelpers_4_0_001.ToConcept(X);

				return ag_;
			};
			var ad_ = z_.SelectOrNull<CodeableConcept, CqlConcept>((ab_ as IEnumerable<CodeableConcept>), ac_);
			var ae_ = this.Left_Modifier();
			var af_ = z_.ConceptsInValueSet(ad_, ae_);

			return af_;
		};
		var n_ = a_.WhereOrNull<Procedure>(l_, m_);
		var o_ = a_.ListUnion<Procedure>(g_, n_);
		var r_ = this.Clinical_Unilateral_Mastectomy();
		var s_ = d_.RetrieveByValueSet<Procedure>(r_, null);
		var t_ = NCQAStatus_1_0_0.Completed_Procedure(s_);
		bool? u_(Procedure ClinicalUnilateralMastectomyProcedure)
		{
			var ah_ = context.Operators;
			var aj_ = ClinicalUnilateralMastectomyProcedure?.BodySite;
			CqlConcept ak_(CodeableConcept X)
			{
				var ao_ = FHIRHelpers_4_0_001.ToConcept(X);

				return ao_;
			};
			var al_ = ah_.SelectOrNull<CodeableConcept, CqlConcept>((aj_ as IEnumerable<CodeableConcept>), ak_);
			var am_ = this.Clinical_Left_Modifier();
			var an_ = ah_.ConceptsInValueSet(al_, am_);

			return an_;
		};
		var v_ = a_.WhereOrNull<Procedure>(t_, u_);
		var w_ = a_.ListUnion<Procedure>(o_, v_);
		bool? x_(Procedure LeftMastectomyProcedure)
		{
			var ap_ = context.Operators;
			var ar_ = LeftMastectomyProcedure?.Performed;
			var as_ = NCQAFHIRBase_1_0_0.Normalize_Interval(ar_);
			var at_ = ap_.End(as_);
			var av_ = this.Measurement_Period();
			var aw_ = ap_.End(av_);
			var ax_ = ap_.SameOrBefore(at_, aw_, null);

			return ax_;
		};
		var y_ = a_.WhereOrNull<Procedure>(w_, x_);

		return y_;
	}

    [CqlDeclaration("Left Mastectomy Procedure")]
	public IEnumerable<Procedure> Left_Mastectomy_Procedure() => 
		__Left_Mastectomy_Procedure.Value;

	private IEnumerable<Condition> Bilateral_Mastectomy_Diagnosis_Value()
	{
		var a_ = context.Operators;
		var b_ = context.DataRetriever;
		var c_ = this.History_of_Bilateral_Mastectomy();
		var d_ = b_.RetrieveByValueSet<Condition>(c_, null);
		var e_ = NCQAStatus_1_0_0.Active_Condition(d_);
		bool? f_(Condition BilateralMastectomyHistory)
		{
			var h_ = context.Operators;
			var j_ = NCQAFHIRBase_1_0_0.Prevalence_Period(BilateralMastectomyHistory);
			var k_ = h_.Start(j_);
			var m_ = this.Measurement_Period();
			var n_ = h_.End(m_);
			var o_ = h_.SameOrBefore(k_, n_, null);

			return o_;
		};
		var g_ = a_.WhereOrNull<Condition>(e_, f_);

		return g_;
	}

    [CqlDeclaration("Bilateral Mastectomy Diagnosis")]
	public IEnumerable<Condition> Bilateral_Mastectomy_Diagnosis() => 
		__Bilateral_Mastectomy_Diagnosis.Value;

	private IEnumerable<Procedure> Bilateral_Mastectomy_Procedure_Value()
	{
		var a_ = context.Operators;
		var d_ = context.DataRetriever;
		var e_ = this.Bilateral_Mastectomy();
		var f_ = d_.RetrieveByValueSet<Procedure>(e_, null);
		var g_ = NCQAStatus_1_0_0.Completed_Procedure(f_);
		var j_ = this.Unilateral_Mastectomy();
		var k_ = d_.RetrieveByValueSet<Procedure>(j_, null);
		var l_ = NCQAStatus_1_0_0.Completed_Procedure(k_);
		bool? m_(Procedure UnilateralMastectomyProcedure)
		{
			var z_ = context.Operators;
			var ab_ = UnilateralMastectomyProcedure?.BodySite;
			CqlConcept ac_(CodeableConcept X)
			{
				var ag_ = FHIRHelpers_4_0_001.ToConcept(X);

				return ag_;
			};
			var ad_ = z_.SelectOrNull<CodeableConcept, CqlConcept>((ab_ as IEnumerable<CodeableConcept>), ac_);
			var ae_ = this.Bilateral_Modifier();
			var af_ = z_.ConceptsInValueSet(ad_, ae_);

			return af_;
		};
		var n_ = a_.WhereOrNull<Procedure>(l_, m_);
		var o_ = a_.ListUnion<Procedure>(g_, n_);
		var r_ = this.Clinical_Unilateral_Mastectomy();
		var s_ = d_.RetrieveByValueSet<Procedure>(r_, null);
		var t_ = NCQAStatus_1_0_0.Completed_Procedure(s_);
		bool? u_(Procedure ClinicalUnilateralMastectomyProcedure)
		{
			var ah_ = context.Operators;
			var aj_ = ClinicalUnilateralMastectomyProcedure?.BodySite;
			CqlConcept ak_(CodeableConcept X)
			{
				var ao_ = FHIRHelpers_4_0_001.ToConcept(X);

				return ao_;
			};
			var al_ = ah_.SelectOrNull<CodeableConcept, CqlConcept>((aj_ as IEnumerable<CodeableConcept>), ak_);
			var am_ = this.Clinical_Bilateral_Modifier();
			var an_ = ah_.ConceptsInValueSet(al_, am_);

			return an_;
		};
		var v_ = a_.WhereOrNull<Procedure>(t_, u_);
		var w_ = a_.ListUnion<Procedure>(o_, v_);
		bool? x_(Procedure BilateralMastectomyPerformed)
		{
			var ap_ = context.Operators;
			var ar_ = BilateralMastectomyPerformed?.Performed;
			var as_ = NCQAFHIRBase_1_0_0.Normalize_Interval(ar_);
			var at_ = ap_.End(as_);
			var av_ = this.Measurement_Period();
			var aw_ = ap_.End(av_);
			var ax_ = ap_.SameOrBefore(at_, aw_, null);

			return ax_;
		};
		var y_ = a_.WhereOrNull<Procedure>(w_, x_);

		return y_;
	}

    [CqlDeclaration("Bilateral Mastectomy Procedure")]
	public IEnumerable<Procedure> Bilateral_Mastectomy_Procedure() => 
		__Bilateral_Mastectomy_Procedure.Value;

	private bool? Mastectomy_Exclusion_Value()
	{
		var a_ = context.Operators;
		var f_ = this.Right_Mastectomy_Diagnosis();
		var g_ = a_.ExistsInList<Condition>(f_);
		var i_ = this.Right_Mastectomy_Procedure();
		var j_ = a_.ExistsInList<Procedure>(i_);
		var k_ = a_.Or(g_, j_);
		var n_ = this.Left_Mastectomy_Diagnosis();
		var o_ = a_.ExistsInList<Condition>(n_);
		var q_ = this.Left_Mastectomy_Procedure();
		var r_ = a_.ExistsInList<Procedure>(q_);
		var s_ = a_.Or(o_, r_);
		var t_ = a_.And(k_, s_);
		var v_ = this.Bilateral_Mastectomy_Diagnosis();
		var w_ = a_.ExistsInList<Condition>(v_);
		var x_ = a_.Or(t_, w_);
		var z_ = this.Bilateral_Mastectomy_Procedure();
		var aa_ = a_.ExistsInList<Procedure>(z_);
		var ab_ = a_.Or(x_, aa_);

		return ab_;
	}

    [CqlDeclaration("Mastectomy Exclusion")]
	public bool? Mastectomy_Exclusion() => 
		__Mastectomy_Exclusion.Value;

	private bool? Exclusions_Value()
	{
		var a_ = context.Operators;
		var d_ = NCQAHospice_1_0_0.Hospice_Intervention_or_Encounter();
		var e_ = this.Mastectomy_Exclusion();
		var f_ = a_.Or(d_, e_);
		var g_ = NCQAAdvancedIllnessandFrailty_1_0_0.Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80();
		var h_ = a_.Or(f_, g_);
		var i_ = this.Measurement_Period();
		var j_ = NCQAPalliativeCare_1_0_0.Palliative_Care_Overlapping_Period(i_);
		var k_ = a_.Or(h_, j_);

		return k_;
	}

    [CqlDeclaration("Exclusions")]
	public bool? Exclusions() => 
		__Exclusions.Value;

	private bool? Numerator_Value()
	{
		var a_ = context.Operators;
		var c_ = context.DataRetriever;
		var d_ = this.Mammography();
		var e_ = c_.RetrieveByValueSet<Observation>(d_, null);
		bool? f_(Observation Mammogram)
		{
			var i_ = context.Operators;
			var k_ = Mammogram?.Effective;
			var l_ = NCQAFHIRBase_1_0_0.Normalize_Interval(k_);
			var m_ = i_.End(l_);
			var n_ = this.Participation_Period();
			var o_ = i_.ElementInInterval<CqlDateTime>(m_, n_, null);

			return o_;
		};
		var g_ = a_.WhereOrNull<Observation>(e_, f_);
		var h_ = a_.ExistsInList<Observation>(g_);

		return h_;
	}

    [CqlDeclaration("Numerator")]
	public bool? Numerator() => 
		__Numerator.Value;

}