using System;
using System.Linq;
using System.Collections.Generic;
using Hl7.Cql.Runtime;
using Hl7.Cql.Primitives;
using Hl7.Cql.Abstractions;
using Hl7.Cql.ValueSets;
using Hl7.Cql.Iso8601;
using System.Reflection;
using Hl7.Cql.Operators;
using Hl7.Fhir.Model;
using Range = Hl7.Fhir.Model.Range;
using Task = Hl7.Fhir.Model.Task;

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "3.1.0.0")]
[CqlLibrary("BCSEHEDISMY2022", "1.0.0")]
public partial class BCSEHEDISMY2022_1_0_0 : ILibrary, ISingleton<BCSEHEDISMY2022_1_0_0>
{
    private BCSEHEDISMY2022_1_0_0() {}

    public static BCSEHEDISMY2022_1_0_0 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "BCSEHEDISMY2022";
    public string Version => "1.0.0";
    public ILibrary[] Dependencies => [FHIRHelpers_4_0_001.Instance, NCQAHealthPlanEnrollment_1_0_0.Instance, NCQAStatus_1_0_0.Instance, NCQAFHIRBase_1_0_0.Instance, NCQAHospice_1_0_0.Instance, NCQAAdvancedIllnessandFrailty_1_0_0.Instance, NCQAPalliativeCare_1_0_0.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    [CqlValueSetDefinition("Absence of Left Breast", valueSetId: "https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1329", valueSetVersion: null)]
    public CqlValueSet Absence_of_Left_Breast(CqlContext _) => _Absence_of_Left_Breast;
    private static readonly CqlValueSet _Absence_of_Left_Breast = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1329", null);

    [CqlValueSetDefinition("Absence of Right Breast", valueSetId: "https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1330", valueSetVersion: null)]
    public CqlValueSet Absence_of_Right_Breast(CqlContext _) => _Absence_of_Right_Breast;
    private static readonly CqlValueSet _Absence_of_Right_Breast = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1330", null);

    [CqlValueSetDefinition("Bilateral Mastectomy", valueSetId: "https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1042", valueSetVersion: null)]
    public CqlValueSet Bilateral_Mastectomy(CqlContext _) => _Bilateral_Mastectomy;
    private static readonly CqlValueSet _Bilateral_Mastectomy = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1042", null);

    [CqlValueSetDefinition("Bilateral Modifier", valueSetId: "https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1043", valueSetVersion: null)]
    public CqlValueSet Bilateral_Modifier(CqlContext _) => _Bilateral_Modifier;
    private static readonly CqlValueSet _Bilateral_Modifier = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1043", null);

    [CqlValueSetDefinition("Clinical Bilateral Modifier", valueSetId: "https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1951", valueSetVersion: null)]
    public CqlValueSet Clinical_Bilateral_Modifier(CqlContext _) => _Clinical_Bilateral_Modifier;
    private static readonly CqlValueSet _Clinical_Bilateral_Modifier = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1951", null);

    [CqlValueSetDefinition("Clinical Left Modifier", valueSetId: "https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1949", valueSetVersion: null)]
    public CqlValueSet Clinical_Left_Modifier(CqlContext _) => _Clinical_Left_Modifier;
    private static readonly CqlValueSet _Clinical_Left_Modifier = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1949", null);

    [CqlValueSetDefinition("Clinical Right Modifier", valueSetId: "https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1950", valueSetVersion: null)]
    public CqlValueSet Clinical_Right_Modifier(CqlContext _) => _Clinical_Right_Modifier;
    private static readonly CqlValueSet _Clinical_Right_Modifier = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1950", null);

    [CqlValueSetDefinition("Clinical Unilateral Mastectomy", valueSetId: "https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1948", valueSetVersion: null)]
    public CqlValueSet Clinical_Unilateral_Mastectomy(CqlContext _) => _Clinical_Unilateral_Mastectomy;
    private static readonly CqlValueSet _Clinical_Unilateral_Mastectomy = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1948", null);

    [CqlValueSetDefinition("History of Bilateral Mastectomy", valueSetId: "https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1331", valueSetVersion: null)]
    public CqlValueSet History_of_Bilateral_Mastectomy(CqlContext _) => _History_of_Bilateral_Mastectomy;
    private static readonly CqlValueSet _History_of_Bilateral_Mastectomy = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1331", null);

    [CqlValueSetDefinition("Left Modifier", valueSetId: "https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1148", valueSetVersion: null)]
    public CqlValueSet Left_Modifier(CqlContext _) => _Left_Modifier;
    private static readonly CqlValueSet _Left_Modifier = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1148", null);

    [CqlValueSetDefinition("Mammography", valueSetId: "https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1168", valueSetVersion: null)]
    public CqlValueSet Mammography(CqlContext _) => _Mammography;
    private static readonly CqlValueSet _Mammography = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1168", null);

    [CqlValueSetDefinition("Right Modifier", valueSetId: "https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1230", valueSetVersion: null)]
    public CqlValueSet Right_Modifier(CqlContext _) => _Right_Modifier;
    private static readonly CqlValueSet _Right_Modifier = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1230", null);

    [CqlValueSetDefinition("Unilateral Mastectomy", valueSetId: "https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1256", valueSetVersion: null)]
    public CqlValueSet Unilateral_Mastectomy(CqlContext _) => _Unilateral_Mastectomy;
    private static readonly CqlValueSet _Unilateral_Mastectomy = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1256", null);

    [CqlValueSetDefinition("Unilateral Mastectomy Left", valueSetId: "https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1334", valueSetVersion: null)]
    public CqlValueSet Unilateral_Mastectomy_Left(CqlContext _) => _Unilateral_Mastectomy_Left;
    private static readonly CqlValueSet _Unilateral_Mastectomy_Left = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1334", null);

    [CqlValueSetDefinition("Unilateral Mastectomy Right", valueSetId: "https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1335", valueSetVersion: null)]
    public CqlValueSet Unilateral_Mastectomy_Right(CqlContext _) => _Unilateral_Mastectomy_Right;
    private static readonly CqlValueSet _Unilateral_Mastectomy_Right = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1335", null);

    #endregion ValueSets

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        object a_ = context.ResolveParameter("BCSEHEDISMY2022-1.0.0", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)a_;
    }


    #endregion Parameters

    #region Functions and Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

        return b_;
    }


    [CqlExpressionDefinition("October 1 Two Years Prior to the Measurement Period")]
    public CqlDateTime October_1_Two_Years_Prior_to_the_Measurement_Period(CqlContext context)
    {
        CqlInterval<CqlDateTime> a_ = this.Measurement_Period(context);
        CqlDateTime b_ = context.Operators.Start(a_);
        int? c_ = context.Operators.DateTimeComponentFrom(b_, "year");
        int? d_ = context.Operators.Subtract(c_, 2);
        decimal? e_ = context.Operators.ConvertIntegerToDecimal(0);
        CqlDateTime f_ = context.Operators.DateTime(d_, 10, 1, 0, 0, 0, 0, e_);

        return f_;
    }


    [CqlExpressionDefinition("Participation Period")]
    public CqlInterval<CqlDateTime> Participation_Period(CqlContext context)
    {
        CqlDateTime a_ = this.October_1_Two_Years_Prior_to_the_Measurement_Period(context);
        CqlInterval<CqlDateTime> b_ = this.Measurement_Period(context);
        CqlDateTime c_ = context.Operators.End(b_);
        CqlInterval<CqlDateTime> d_ = context.Operators.Interval(a_, c_, true, true);

        return d_;
    }


    [CqlExpressionDefinition("Member Coverage")]
    public IEnumerable<Coverage> Member_Coverage(CqlContext context)
    {
        IEnumerable<Coverage> a_ = context.Operators.Retrieve<Coverage>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Coverage"));
        bool? b_(Coverage C)
        {
            Period d_ = C?.Period;
            CqlInterval<CqlDateTime> e_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, d_ as object);
            CqlInterval<CqlDateTime> f_ = this.Participation_Period(context);
            bool? g_ = context.Operators.Overlaps(e_, f_, default);

            return g_;
        };
        IEnumerable<Coverage> c_ = context.Operators.Where<Coverage>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Enrolled During Participation Period")]
    public bool? Enrolled_During_Participation_Period(CqlContext context)
    {
        IEnumerable<Coverage> a_ = this.Member_Coverage(context);
        CqlInterval<CqlDateTime> b_ = this.Measurement_Period(context);
        CqlDateTime c_ = context.Operators.End(b_);
        CqlDate d_ = context.Operators.DateFrom(c_);
        CqlDateTime e_ = this.October_1_Two_Years_Prior_to_the_Measurement_Period(context);
        CqlDate f_ = context.Operators.DateFrom(e_);
        CqlDateTime h_ = context.Operators.End(b_);
        CqlDate i_ = context.Operators.DateFrom(h_);
        CqlQuantity j_ = context.Operators.Quantity(2m, "years");
        CqlDate k_ = context.Operators.Subtract(i_, j_);
        CqlInterval<CqlDate> l_ = context.Operators.Interval(f_, k_, true, true);
        bool? m_ = NCQAHealthPlanEnrollment_1_0_0.Instance.Health_Plan_Enrollment_Criteria(context, a_, d_, l_, 0);
        CqlDateTime p_ = context.Operators.End(b_);
        CqlDate q_ = context.Operators.DateFrom(p_);
        CqlDateTime s_ = context.Operators.Start(b_);
        CqlDate t_ = context.Operators.DateFrom(s_);
        CqlQuantity u_ = context.Operators.Quantity(1m, "year");
        CqlDate v_ = context.Operators.Subtract(t_, u_);
        CqlDateTime x_ = context.Operators.End(b_);
        CqlDate y_ = context.Operators.DateFrom(x_);
        CqlDate aa_ = context.Operators.Subtract(y_, u_);
        CqlInterval<CqlDate> ab_ = context.Operators.Interval(v_, aa_, true, true);
        bool? ac_ = NCQAHealthPlanEnrollment_1_0_0.Instance.Health_Plan_Enrollment_Criteria(context, a_, q_, ab_, 45);
        bool? ad_ = context.Operators.And(m_, ac_);
        CqlDateTime ag_ = context.Operators.End(b_);
        CqlDate ah_ = context.Operators.DateFrom(ag_);
        CqlDateTime aj_ = context.Operators.Start(b_);
        CqlDate ak_ = context.Operators.DateFrom(aj_);
        CqlDateTime am_ = context.Operators.End(b_);
        CqlDate an_ = context.Operators.DateFrom(am_);
        CqlInterval<CqlDate> ao_ = context.Operators.Interval(ak_, an_, true, true);
        bool? ap_ = NCQAHealthPlanEnrollment_1_0_0.Instance.Health_Plan_Enrollment_Criteria(context, a_, ah_, ao_, 45);
        bool? aq_ = context.Operators.And(ad_, ap_);

        return aq_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient a_ = this.Patient(context);
        Date b_ = a_?.BirthDateElement;
        string c_ = b_?.Value;
        CqlDate d_ = context.Operators.ConvertStringToDate(c_);
        CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
        CqlDateTime f_ = context.Operators.End(e_);
        CqlDate g_ = context.Operators.DateFrom(f_);
        int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
        CqlInterval<int?> i_ = context.Operators.Interval(52, 74, true, true);
        bool? j_ = context.Operators.In<int?>(h_, i_, default);
        Code<AdministrativeGender> l_ = a_?.GenderElement;
        AdministrativeGender? m_ = l_?.Value;
        string n_ = context.Operators.Convert<string>(m_);
        bool? o_ = context.Operators.Equal(n_, "female");
        bool? p_ = context.Operators.And(j_, o_);
        bool? q_ = this.Enrolled_During_Participation_Period(context);
        bool? r_ = context.Operators.And(p_, q_);

        return r_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? a_ = this.Initial_Population(context);

        return a_;
    }


    [CqlExpressionDefinition("Right Mastectomy Diagnosis")]
    public IEnumerable<Condition> Right_Mastectomy_Diagnosis(CqlContext context)
    {
        CqlValueSet a_ = this.Absence_of_Right_Breast(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        IEnumerable<Condition> c_ = NCQAStatus_1_0_0.Instance.Active_Condition(context, b_);
        bool? d_(Condition RightMastectomyDiagnosis)
        {
            CqlInterval<CqlDateTime> f_ = NCQAFHIRBase_1_0_0.Instance.Prevalence_Period(context, RightMastectomyDiagnosis);
            CqlDateTime g_ = context.Operators.Start(f_);
            CqlInterval<CqlDateTime> h_ = this.Measurement_Period(context);
            CqlDateTime i_ = context.Operators.End(h_);
            bool? j_ = context.Operators.SameOrBefore(g_, i_, default);

            return j_;
        };
        IEnumerable<Condition> e_ = context.Operators.Where<Condition>(c_, d_);

        return e_;
    }


    [CqlExpressionDefinition("Right Mastectomy Procedure")]
    public IEnumerable<Procedure> Right_Mastectomy_Procedure(CqlContext context)
    {
        CqlValueSet a_ = this.Unilateral_Mastectomy_Right(context);
        IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        IEnumerable<Procedure> c_ = NCQAStatus_1_0_0.Instance.Completed_Procedure(context, b_);
        CqlValueSet d_ = this.Unilateral_Mastectomy(context);
        IEnumerable<Procedure> e_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        IEnumerable<Procedure> f_ = NCQAStatus_1_0_0.Instance.Completed_Procedure(context, e_);
        bool? g_(Procedure UnilateralMastectomyProcedure)
        {
            List<CodeableConcept> r_ = UnilateralMastectomyProcedure?.BodySite;
            CqlConcept s_(CodeableConcept X)
            {
                CqlConcept w_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, X);

                return w_;
            };
            IEnumerable<CqlConcept> t_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)r_, s_);
            CqlValueSet u_ = this.Right_Modifier(context);
            bool? v_ = context.Operators.ConceptsInValueSet(t_, u_);

            return v_;
        };
        IEnumerable<Procedure> h_ = context.Operators.Where<Procedure>(f_, g_);
        IEnumerable<Procedure> i_ = context.Operators.Union<Procedure>(c_, h_);
        CqlValueSet j_ = this.Clinical_Unilateral_Mastectomy(context);
        IEnumerable<Procedure> k_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, j_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        IEnumerable<Procedure> l_ = NCQAStatus_1_0_0.Instance.Completed_Procedure(context, k_);
        bool? m_(Procedure ClinicalUnilateralMastectomyProcedure)
        {
            List<CodeableConcept> x_ = ClinicalUnilateralMastectomyProcedure?.BodySite;
            CqlConcept y_(CodeableConcept X)
            {
                CqlConcept ac_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, X);

                return ac_;
            };
            IEnumerable<CqlConcept> z_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)x_, y_);
            CqlValueSet aa_ = this.Clinical_Right_Modifier(context);
            bool? ab_ = context.Operators.ConceptsInValueSet(z_, aa_);

            return ab_;
        };
        IEnumerable<Procedure> n_ = context.Operators.Where<Procedure>(l_, m_);
        IEnumerable<Procedure> o_ = context.Operators.Union<Procedure>(i_, n_);
        bool? p_(Procedure RightMastectomyProcedure)
        {
            DataType ad_ = RightMastectomyProcedure?.Performed;
            CqlInterval<CqlDateTime> ae_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, ad_);
            CqlDateTime af_ = context.Operators.End(ae_);
            CqlInterval<CqlDateTime> ag_ = this.Measurement_Period(context);
            CqlDateTime ah_ = context.Operators.End(ag_);
            bool? ai_ = context.Operators.SameOrBefore(af_, ah_, default);

            return ai_;
        };
        IEnumerable<Procedure> q_ = context.Operators.Where<Procedure>(o_, p_);

        return q_;
    }


    [CqlExpressionDefinition("Left Mastectomy Diagnosis")]
    public IEnumerable<Condition> Left_Mastectomy_Diagnosis(CqlContext context)
    {
        CqlValueSet a_ = this.Absence_of_Left_Breast(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        IEnumerable<Condition> c_ = NCQAStatus_1_0_0.Instance.Active_Condition(context, b_);
        bool? d_(Condition LeftMastectomyDiagnosis)
        {
            CqlInterval<CqlDateTime> f_ = NCQAFHIRBase_1_0_0.Instance.Prevalence_Period(context, LeftMastectomyDiagnosis);
            CqlDateTime g_ = context.Operators.Start(f_);
            CqlInterval<CqlDateTime> h_ = this.Measurement_Period(context);
            CqlDateTime i_ = context.Operators.End(h_);
            bool? j_ = context.Operators.SameOrBefore(g_, i_, default);

            return j_;
        };
        IEnumerable<Condition> e_ = context.Operators.Where<Condition>(c_, d_);

        return e_;
    }


    [CqlExpressionDefinition("Left Mastectomy Procedure")]
    public IEnumerable<Procedure> Left_Mastectomy_Procedure(CqlContext context)
    {
        CqlValueSet a_ = this.Unilateral_Mastectomy_Left(context);
        IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        IEnumerable<Procedure> c_ = NCQAStatus_1_0_0.Instance.Completed_Procedure(context, b_);
        CqlValueSet d_ = this.Unilateral_Mastectomy(context);
        IEnumerable<Procedure> e_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        IEnumerable<Procedure> f_ = NCQAStatus_1_0_0.Instance.Completed_Procedure(context, e_);
        bool? g_(Procedure UnilateralMastectomyProcedure)
        {
            List<CodeableConcept> r_ = UnilateralMastectomyProcedure?.BodySite;
            CqlConcept s_(CodeableConcept X)
            {
                CqlConcept w_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, X);

                return w_;
            };
            IEnumerable<CqlConcept> t_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)r_, s_);
            CqlValueSet u_ = this.Left_Modifier(context);
            bool? v_ = context.Operators.ConceptsInValueSet(t_, u_);

            return v_;
        };
        IEnumerable<Procedure> h_ = context.Operators.Where<Procedure>(f_, g_);
        IEnumerable<Procedure> i_ = context.Operators.Union<Procedure>(c_, h_);
        CqlValueSet j_ = this.Clinical_Unilateral_Mastectomy(context);
        IEnumerable<Procedure> k_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, j_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        IEnumerable<Procedure> l_ = NCQAStatus_1_0_0.Instance.Completed_Procedure(context, k_);
        bool? m_(Procedure ClinicalUnilateralMastectomyProcedure)
        {
            List<CodeableConcept> x_ = ClinicalUnilateralMastectomyProcedure?.BodySite;
            CqlConcept y_(CodeableConcept X)
            {
                CqlConcept ac_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, X);

                return ac_;
            };
            IEnumerable<CqlConcept> z_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)x_, y_);
            CqlValueSet aa_ = this.Clinical_Left_Modifier(context);
            bool? ab_ = context.Operators.ConceptsInValueSet(z_, aa_);

            return ab_;
        };
        IEnumerable<Procedure> n_ = context.Operators.Where<Procedure>(l_, m_);
        IEnumerable<Procedure> o_ = context.Operators.Union<Procedure>(i_, n_);
        bool? p_(Procedure LeftMastectomyProcedure)
        {
            DataType ad_ = LeftMastectomyProcedure?.Performed;
            CqlInterval<CqlDateTime> ae_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, ad_);
            CqlDateTime af_ = context.Operators.End(ae_);
            CqlInterval<CqlDateTime> ag_ = this.Measurement_Period(context);
            CqlDateTime ah_ = context.Operators.End(ag_);
            bool? ai_ = context.Operators.SameOrBefore(af_, ah_, default);

            return ai_;
        };
        IEnumerable<Procedure> q_ = context.Operators.Where<Procedure>(o_, p_);

        return q_;
    }


    [CqlExpressionDefinition("Bilateral Mastectomy Diagnosis")]
    public IEnumerable<Condition> Bilateral_Mastectomy_Diagnosis(CqlContext context)
    {
        CqlValueSet a_ = this.History_of_Bilateral_Mastectomy(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        IEnumerable<Condition> c_ = NCQAStatus_1_0_0.Instance.Active_Condition(context, b_);
        bool? d_(Condition BilateralMastectomyHistory)
        {
            CqlInterval<CqlDateTime> f_ = NCQAFHIRBase_1_0_0.Instance.Prevalence_Period(context, BilateralMastectomyHistory);
            CqlDateTime g_ = context.Operators.Start(f_);
            CqlInterval<CqlDateTime> h_ = this.Measurement_Period(context);
            CqlDateTime i_ = context.Operators.End(h_);
            bool? j_ = context.Operators.SameOrBefore(g_, i_, default);

            return j_;
        };
        IEnumerable<Condition> e_ = context.Operators.Where<Condition>(c_, d_);

        return e_;
    }


    [CqlExpressionDefinition("Bilateral Mastectomy Procedure")]
    public IEnumerable<Procedure> Bilateral_Mastectomy_Procedure(CqlContext context)
    {
        CqlValueSet a_ = this.Bilateral_Mastectomy(context);
        IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        IEnumerable<Procedure> c_ = NCQAStatus_1_0_0.Instance.Completed_Procedure(context, b_);
        CqlValueSet d_ = this.Unilateral_Mastectomy(context);
        IEnumerable<Procedure> e_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        IEnumerable<Procedure> f_ = NCQAStatus_1_0_0.Instance.Completed_Procedure(context, e_);
        bool? g_(Procedure UnilateralMastectomyProcedure)
        {
            List<CodeableConcept> r_ = UnilateralMastectomyProcedure?.BodySite;
            CqlConcept s_(CodeableConcept X)
            {
                CqlConcept w_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, X);

                return w_;
            };
            IEnumerable<CqlConcept> t_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)r_, s_);
            CqlValueSet u_ = this.Bilateral_Modifier(context);
            bool? v_ = context.Operators.ConceptsInValueSet(t_, u_);

            return v_;
        };
        IEnumerable<Procedure> h_ = context.Operators.Where<Procedure>(f_, g_);
        IEnumerable<Procedure> i_ = context.Operators.Union<Procedure>(c_, h_);
        CqlValueSet j_ = this.Clinical_Unilateral_Mastectomy(context);
        IEnumerable<Procedure> k_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, j_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        IEnumerable<Procedure> l_ = NCQAStatus_1_0_0.Instance.Completed_Procedure(context, k_);
        bool? m_(Procedure ClinicalUnilateralMastectomyProcedure)
        {
            List<CodeableConcept> x_ = ClinicalUnilateralMastectomyProcedure?.BodySite;
            CqlConcept y_(CodeableConcept X)
            {
                CqlConcept ac_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, X);

                return ac_;
            };
            IEnumerable<CqlConcept> z_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)x_, y_);
            CqlValueSet aa_ = this.Clinical_Bilateral_Modifier(context);
            bool? ab_ = context.Operators.ConceptsInValueSet(z_, aa_);

            return ab_;
        };
        IEnumerable<Procedure> n_ = context.Operators.Where<Procedure>(l_, m_);
        IEnumerable<Procedure> o_ = context.Operators.Union<Procedure>(i_, n_);
        bool? p_(Procedure BilateralMastectomyPerformed)
        {
            DataType ad_ = BilateralMastectomyPerformed?.Performed;
            CqlInterval<CqlDateTime> ae_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, ad_);
            CqlDateTime af_ = context.Operators.End(ae_);
            CqlInterval<CqlDateTime> ag_ = this.Measurement_Period(context);
            CqlDateTime ah_ = context.Operators.End(ag_);
            bool? ai_ = context.Operators.SameOrBefore(af_, ah_, default);

            return ai_;
        };
        IEnumerable<Procedure> q_ = context.Operators.Where<Procedure>(o_, p_);

        return q_;
    }


    [CqlExpressionDefinition("Mastectomy Exclusion")]
    public bool? Mastectomy_Exclusion(CqlContext context)
    {
        IEnumerable<Condition> a_ = this.Right_Mastectomy_Diagnosis(context);
        bool? b_ = context.Operators.Exists<Condition>(a_);
        IEnumerable<Procedure> c_ = this.Right_Mastectomy_Procedure(context);
        bool? d_ = context.Operators.Exists<Procedure>(c_);
        bool? e_ = context.Operators.Or(b_, d_);
        IEnumerable<Condition> f_ = this.Left_Mastectomy_Diagnosis(context);
        bool? g_ = context.Operators.Exists<Condition>(f_);
        IEnumerable<Procedure> h_ = this.Left_Mastectomy_Procedure(context);
        bool? i_ = context.Operators.Exists<Procedure>(h_);
        bool? j_ = context.Operators.Or(g_, i_);
        bool? k_ = context.Operators.And(e_, j_);
        IEnumerable<Condition> l_ = this.Bilateral_Mastectomy_Diagnosis(context);
        bool? m_ = context.Operators.Exists<Condition>(l_);
        bool? n_ = context.Operators.Or(k_, m_);
        IEnumerable<Procedure> o_ = this.Bilateral_Mastectomy_Procedure(context);
        bool? p_ = context.Operators.Exists<Procedure>(o_);
        bool? q_ = context.Operators.Or(n_, p_);

        return q_;
    }


    [CqlExpressionDefinition("Exclusions")]
    public bool? Exclusions(CqlContext context)
    {
        bool? a_ = NCQAHospice_1_0_0.Instance.Hospice_Intervention_or_Encounter(context);
        bool? b_ = this.Mastectomy_Exclusion(context);
        bool? c_ = context.Operators.Or(a_, b_);
        bool? d_ = NCQAAdvancedIllnessandFrailty_1_0_0.Instance.Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80(context);
        bool? e_ = context.Operators.Or(c_, d_);
        CqlInterval<CqlDateTime> f_ = this.Measurement_Period(context);
        bool? g_ = NCQAPalliativeCare_1_0_0.Instance.Palliative_Care_Overlapping_Period(context, f_);
        bool? h_ = context.Operators.Or(e_, g_);

        return h_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        CqlValueSet a_ = this.Mammography(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? c_(Observation Mammogram)
        {
            DataType f_ = Mammogram?.Effective;
            CqlInterval<CqlDateTime> g_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, f_);
            CqlDateTime h_ = context.Operators.End(g_);
            CqlInterval<CqlDateTime> i_ = this.Participation_Period(context);
            bool? j_ = context.Operators.In<CqlDateTime>(h_, i_, default);

            return j_;
        };
        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);
        bool? e_ = context.Operators.Exists<Observation>(d_);

        return e_;
    }


    #endregion Functions and Expressions

}
