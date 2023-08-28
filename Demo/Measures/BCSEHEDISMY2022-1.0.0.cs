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
    public CqlValueSet Absence_of_Left_Breast() => __Absence_of_Left_Breast.Value;

    private CqlValueSet Absence_of_Right_Breast_Value() =>
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1330", null);

    [CqlDeclaration("Absence of Right Breast")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1330")]
    public CqlValueSet Absence_of_Right_Breast() => __Absence_of_Right_Breast.Value;

    private CqlValueSet Bilateral_Mastectomy_Value() =>
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1042", null);

    [CqlDeclaration("Bilateral Mastectomy")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1042")]
    public CqlValueSet Bilateral_Mastectomy() => __Bilateral_Mastectomy.Value;

    private CqlValueSet Bilateral_Modifier_Value() =>
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1043", null);

    [CqlDeclaration("Bilateral Modifier")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1043")]
    public CqlValueSet Bilateral_Modifier() => __Bilateral_Modifier.Value;

    private CqlValueSet Clinical_Bilateral_Modifier_Value() =>
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1951", null);

    [CqlDeclaration("Clinical Bilateral Modifier")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1951")]
    public CqlValueSet Clinical_Bilateral_Modifier() => __Clinical_Bilateral_Modifier.Value;

    private CqlValueSet Clinical_Left_Modifier_Value() =>
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1949", null);

    [CqlDeclaration("Clinical Left Modifier")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1949")]
    public CqlValueSet Clinical_Left_Modifier() => __Clinical_Left_Modifier.Value;

    private CqlValueSet Clinical_Right_Modifier_Value() =>
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1950", null);

    [CqlDeclaration("Clinical Right Modifier")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1950")]
    public CqlValueSet Clinical_Right_Modifier() => __Clinical_Right_Modifier.Value;

    private CqlValueSet Clinical_Unilateral_Mastectomy_Value() =>
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1948", null);

    [CqlDeclaration("Clinical Unilateral Mastectomy")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1948")]
    public CqlValueSet Clinical_Unilateral_Mastectomy() => __Clinical_Unilateral_Mastectomy.Value;

    private CqlValueSet History_of_Bilateral_Mastectomy_Value() =>
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1331", null);

    [CqlDeclaration("History of Bilateral Mastectomy")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1331")]
    public CqlValueSet History_of_Bilateral_Mastectomy() => __History_of_Bilateral_Mastectomy.Value;

    private CqlValueSet Left_Modifier_Value() =>
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1148", null);

    [CqlDeclaration("Left Modifier")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1148")]
    public CqlValueSet Left_Modifier() => __Left_Modifier.Value;

    private CqlValueSet Mammography_Value() =>
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1168", null);

    [CqlDeclaration("Mammography")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1168")]
    public CqlValueSet Mammography() => __Mammography.Value;

    private CqlValueSet Right_Modifier_Value() =>
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1230", null);

    [CqlDeclaration("Right Modifier")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1230")]
    public CqlValueSet Right_Modifier() => __Right_Modifier.Value;

    private CqlValueSet Unilateral_Mastectomy_Value() =>
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1256", null);

    [CqlDeclaration("Unilateral Mastectomy")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1256")]
    public CqlValueSet Unilateral_Mastectomy() => __Unilateral_Mastectomy.Value;

    private CqlValueSet Unilateral_Mastectomy_Left_Value() =>
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1334", null);

    [CqlDeclaration("Unilateral Mastectomy Left")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1334")]
    public CqlValueSet Unilateral_Mastectomy_Left() => __Unilateral_Mastectomy_Left.Value;

    private CqlValueSet Unilateral_Mastectomy_Right_Value() =>
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1335", null);

    [CqlDeclaration("Unilateral Mastectomy Right")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1335")]
    public CqlValueSet Unilateral_Mastectomy_Right() => __Unilateral_Mastectomy_Right.Value;

    private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		var a_ = context.ResolveParameter("BCSEHEDISMY2022-1.0.0", "Measurement Period", null);

		return (CqlInterval<CqlDateTime>)a_;
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
		var g_ = b_.Subtract(e_, (int?)2);
		var i_ = b_.ConvertIntegerToDecimal((int?)0);
		var k_ = b_.DateTime(g_, (int?)10, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, i_);

		return k_;
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
		bool? c_(Coverage C)
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
		var u_ = NCQAHealthPlanEnrollment_1_0_0.Health_Plan_Enrollment_Criteria(a_, f_, t_, (int?)0);
		var y_ = c_.End(b_);
		var aa_ = c_.DateFrom(y_);
		var ad_ = c_.Start(b_);
		var af_ = c_.DateFrom(ad_);
		var ah_ = c_.Quantity(1m, "year");
		var aj_ = c_.Subtract(af_, ah_);
		var am_ = c_.End(b_);
		var ao_ = c_.DateFrom(am_);
		var aq_ = c_.Quantity(1m, "year");
		var as_ = c_.Subtract(ao_, aq_);
		var au_ = c_.Interval(aj_, as_, true, true);
		var av_ = NCQAHealthPlanEnrollment_1_0_0.Health_Plan_Enrollment_Criteria(a_, aa_, au_, (int?)45);
		var ax_ = c_.And(u_, av_);
		var bb_ = c_.End(b_);
		var bd_ = c_.DateFrom(bb_);
		var bg_ = c_.Start(b_);
		var bi_ = c_.DateFrom(bg_);
		var bl_ = c_.End(b_);
		var bn_ = c_.DateFrom(bl_);
		var bp_ = c_.Interval(bi_, bn_, true, true);
		var bq_ = NCQAHealthPlanEnrollment_1_0_0.Health_Plan_Enrollment_Criteria(a_, bd_, bp_, (int?)45);
		var bs_ = c_.And(ax_, bq_);

		return bs_;
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
		var o_ = d_.Interval((int?)52, (int?)74, true, true);
		var q_ = d_.ElementInInterval<int?>(m_, o_, null);
		var s_ = a_.GenderElement;
		var t_ = s_.Value;
		var v_ = d_.EnumEqualsString(t_, "female");
		var x_ = d_.And(q_, v_);
		var y_ = this.Enrolled_During_Participation_Period();
		var aa_ = d_.And(x_, y_);

		return aa_;
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
		bool? e_(Condition RightMastectomyDiagnosis)
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
		bool? i_(Procedure UnilateralMastectomyProcedure)
		{
			var z_ = UnilateralMastectomyProcedure.BodySite;
			CqlConcept aa_(CodeableConcept X)
			{
				var ag_ = FHIRHelpers_4_0_001.ToConcept(X);

				return ag_;
			};
			var ab_ = context.Operators;
			var ac_ = ab_.SelectOrNull<CodeableConcept, CqlConcept>((z_ as IEnumerable<CodeableConcept>), aa_);
			var ad_ = this.Right_Modifier();
			var af_ = ab_.ConceptsInValueSet(ac_, ad_);

			return af_;
		};
		var j_ = context.Operators;
		var k_ = j_.WhereOrNull<Procedure>(h_, i_);
		var m_ = j_.ListUnion<Procedure>(d_, k_);
		var n_ = this.Clinical_Unilateral_Mastectomy();
		var p_ = b_.RetrieveByValueSet<Procedure>(n_, null);
		var q_ = NCQAStatus_1_0_0.Completed_Procedure(p_);
		bool? r_(Procedure ClinicalUnilateralMastectomyProcedure)
		{
			var ah_ = ClinicalUnilateralMastectomyProcedure.BodySite;
			CqlConcept ai_(CodeableConcept X)
			{
				var ao_ = FHIRHelpers_4_0_001.ToConcept(X);

				return ao_;
			};
			var aj_ = context.Operators;
			var ak_ = aj_.SelectOrNull<CodeableConcept, CqlConcept>((ah_ as IEnumerable<CodeableConcept>), ai_);
			var al_ = this.Clinical_Right_Modifier();
			var an_ = aj_.ConceptsInValueSet(ak_, al_);

			return an_;
		};
		var t_ = j_.WhereOrNull<Procedure>(q_, r_);
		var v_ = j_.ListUnion<Procedure>(m_, t_);
		bool? w_(Procedure RightMastectomyProcedure)
		{
			var ap_ = RightMastectomyProcedure.Performed;
			var aq_ = NCQAFHIRBase_1_0_0.Normalize_Interval(ap_);
			var ar_ = context.Operators;
			var as_ = ar_.End(aq_);
			var at_ = this.Measurement_Period();
			var av_ = ar_.End(at_);
			var ax_ = ar_.SameOrBefore(as_, av_, null);

			return ax_;
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
		bool? e_(Condition LeftMastectomyDiagnosis)
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
		bool? i_(Procedure UnilateralMastectomyProcedure)
		{
			var z_ = UnilateralMastectomyProcedure.BodySite;
			CqlConcept aa_(CodeableConcept X)
			{
				var ag_ = FHIRHelpers_4_0_001.ToConcept(X);

				return ag_;
			};
			var ab_ = context.Operators;
			var ac_ = ab_.SelectOrNull<CodeableConcept, CqlConcept>((z_ as IEnumerable<CodeableConcept>), aa_);
			var ad_ = this.Left_Modifier();
			var af_ = ab_.ConceptsInValueSet(ac_, ad_);

			return af_;
		};
		var j_ = context.Operators;
		var k_ = j_.WhereOrNull<Procedure>(h_, i_);
		var m_ = j_.ListUnion<Procedure>(d_, k_);
		var n_ = this.Clinical_Unilateral_Mastectomy();
		var p_ = b_.RetrieveByValueSet<Procedure>(n_, null);
		var q_ = NCQAStatus_1_0_0.Completed_Procedure(p_);
		bool? r_(Procedure ClinicalUnilateralMastectomyProcedure)
		{
			var ah_ = ClinicalUnilateralMastectomyProcedure.BodySite;
			CqlConcept ai_(CodeableConcept X)
			{
				var ao_ = FHIRHelpers_4_0_001.ToConcept(X);

				return ao_;
			};
			var aj_ = context.Operators;
			var ak_ = aj_.SelectOrNull<CodeableConcept, CqlConcept>((ah_ as IEnumerable<CodeableConcept>), ai_);
			var al_ = this.Clinical_Left_Modifier();
			var an_ = aj_.ConceptsInValueSet(ak_, al_);

			return an_;
		};
		var t_ = j_.WhereOrNull<Procedure>(q_, r_);
		var v_ = j_.ListUnion<Procedure>(m_, t_);
		bool? w_(Procedure LeftMastectomyProcedure)
		{
			var ap_ = LeftMastectomyProcedure.Performed;
			var aq_ = NCQAFHIRBase_1_0_0.Normalize_Interval(ap_);
			var ar_ = context.Operators;
			var as_ = ar_.End(aq_);
			var at_ = this.Measurement_Period();
			var av_ = ar_.End(at_);
			var ax_ = ar_.SameOrBefore(as_, av_, null);

			return ax_;
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
		bool? e_(Condition BilateralMastectomyHistory)
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
		bool? i_(Procedure UnilateralMastectomyProcedure)
		{
			var z_ = UnilateralMastectomyProcedure.BodySite;
			CqlConcept aa_(CodeableConcept X)
			{
				var ag_ = FHIRHelpers_4_0_001.ToConcept(X);

				return ag_;
			};
			var ab_ = context.Operators;
			var ac_ = ab_.SelectOrNull<CodeableConcept, CqlConcept>((z_ as IEnumerable<CodeableConcept>), aa_);
			var ad_ = this.Bilateral_Modifier();
			var af_ = ab_.ConceptsInValueSet(ac_, ad_);

			return af_;
		};
		var j_ = context.Operators;
		var k_ = j_.WhereOrNull<Procedure>(h_, i_);
		var m_ = j_.ListUnion<Procedure>(d_, k_);
		var n_ = this.Clinical_Unilateral_Mastectomy();
		var p_ = b_.RetrieveByValueSet<Procedure>(n_, null);
		var q_ = NCQAStatus_1_0_0.Completed_Procedure(p_);
		bool? r_(Procedure ClinicalUnilateralMastectomyProcedure)
		{
			var ah_ = ClinicalUnilateralMastectomyProcedure.BodySite;
			CqlConcept ai_(CodeableConcept X)
			{
				var ao_ = FHIRHelpers_4_0_001.ToConcept(X);

				return ao_;
			};
			var aj_ = context.Operators;
			var ak_ = aj_.SelectOrNull<CodeableConcept, CqlConcept>((ah_ as IEnumerable<CodeableConcept>), ai_);
			var al_ = this.Clinical_Bilateral_Modifier();
			var an_ = aj_.ConceptsInValueSet(ak_, al_);

			return an_;
		};
		var t_ = j_.WhereOrNull<Procedure>(q_, r_);
		var v_ = j_.ListUnion<Procedure>(m_, t_);
		bool? w_(Procedure BilateralMastectomyPerformed)
		{
			var ap_ = BilateralMastectomyPerformed.Performed;
			var aq_ = NCQAFHIRBase_1_0_0.Normalize_Interval(ap_);
			var ar_ = context.Operators;
			var as_ = ar_.End(aq_);
			var at_ = this.Measurement_Period();
			var av_ = ar_.End(at_);
			var ax_ = ar_.SameOrBefore(as_, av_, null);

			return ax_;
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
		bool? d_(Observation Mammogram)
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