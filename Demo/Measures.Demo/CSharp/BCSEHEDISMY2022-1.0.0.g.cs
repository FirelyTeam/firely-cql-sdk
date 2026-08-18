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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.3.4.0")]
[CqlLibrary("BCSEHEDISMY2022", "1.0.0")]
public partial class BCSEHEDISMY2022_1_0_0 : ILibrary, ISingleton<BCSEHEDISMY2022_1_0_0>
{
    #region ValueSets (15)

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

    #region Parameters (1)

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute);

    private const long _cacheIndex_Measurement_Period = 4791158273458427164L;

    private CqlInterval<CqlDateTime> Measurement_Period_Compute(CqlContext context)
    {
        object a_ = context.ResolveParameter("BCSEHEDISMY2022-1.0.0", "Measurement Period", (object)null);
        return (CqlInterval<CqlDateTime>)a_;
    }


    #endregion Parameters

    #region Functions and Expressions (16)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = -8230616426423527869L;

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("October 1 Two Years Prior to the Measurement Period")]
    public CqlDateTime October_1_Two_Years_Prior_to_the_Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_October_1_Two_Years_Prior_to_the_Measurement_Period, October_1_Two_Years_Prior_to_the_Measurement_Period_Compute);

    private const long _cacheIndex_October_1_Two_Years_Prior_to_the_Measurement_Period = 8763074136773540993L;

    private CqlDateTime October_1_Two_Years_Prior_to_the_Measurement_Period_Compute(CqlContext context)
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
    public CqlInterval<CqlDateTime> Participation_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Participation_Period, Participation_Period_Compute);

    private const long _cacheIndex_Participation_Period = -3535798335845144052L;

    private CqlInterval<CqlDateTime> Participation_Period_Compute(CqlContext context)
    {
        CqlDateTime a_ = this.October_1_Two_Years_Prior_to_the_Measurement_Period(context);
        CqlInterval<CqlDateTime> b_ = this.Measurement_Period(context);
        CqlDateTime c_ = context.Operators.End(b_);
        CqlInterval<CqlDateTime> d_ = context.Operators.Interval(a_, c_, true, true);
        return d_;
    }


    [CqlExpressionDefinition("Member Coverage")]
    public IEnumerable<Coverage> Member_Coverage(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Member_Coverage, Member_Coverage_Compute);

    private const long _cacheIndex_Member_Coverage = 3272608673906847210L;

    private IEnumerable<Coverage> Member_Coverage_Compute(CqlContext context)
    {
        IEnumerable<Coverage> a_ = context.Operators.Retrieve<Coverage>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Coverage"));

        bool? b_(Coverage C) {
            Period d_ = C?.Period;
            CqlInterval<CqlDateTime> e_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, d_);
            CqlInterval<CqlDateTime> f_ = this.Participation_Period(context);
            CqlBoolean g_ = context.Operators.Overlaps(e_, f_, (string)default);
            return g_;
        }

        IEnumerable<Coverage> c_ = context.Operators.Where<Coverage>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Enrolled During Participation Period")]
    public bool? Enrolled_During_Participation_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Enrolled_During_Participation_Period, Enrolled_During_Participation_Period_Compute);

    private const long _cacheIndex_Enrolled_During_Participation_Period = -1256039623690830364L;

    private bool? Enrolled_During_Participation_Period_Compute(CqlContext context)
    {
        IEnumerable<Coverage> a_ = this.Member_Coverage(context);
        CqlInterval<CqlDateTime> b_ = this.Measurement_Period(context);
        CqlDateTime c_ = context.Operators.End(b_);
        CqlDate d_ = context.Operators.DateFrom(c_);
        CqlDateTime e_ = this.October_1_Two_Years_Prior_to_the_Measurement_Period(context);
        CqlDate f_ = context.Operators.DateFrom(e_);
        CqlQuantity g_ = context.Operators.Quantity(2m, "years");
        CqlDate h_ = context.Operators.Subtract(d_, g_);
        CqlInterval<CqlDate> i_ = context.Operators.Interval(f_, h_, true, true);
        CqlBoolean j_ = NCQAHealthPlanEnrollment_1_0_0.Instance.Health_Plan_Enrollment_Criteria(context, a_, d_, i_, 0);

        CqlBoolean k_() {
            IEnumerable<Coverage> m_ = this.Member_Coverage(context);
            CqlInterval<CqlDateTime> n_ = this.Measurement_Period(context);
            CqlDateTime o_ = context.Operators.End(n_);
            CqlDate p_ = context.Operators.DateFrom(o_);
            CqlDateTime q_ = context.Operators.Start(n_);
            CqlDate r_ = context.Operators.DateFrom(q_);
            CqlQuantity s_ = context.Operators.Quantity(1m, "year");
            CqlDate t_ = context.Operators.Subtract(r_, s_);
            CqlDate u_ = context.Operators.Subtract(p_, s_);
            CqlInterval<CqlDate> v_ = context.Operators.Interval(t_, u_, true, true);
            CqlBoolean w_ = NCQAHealthPlanEnrollment_1_0_0.Instance.Health_Plan_Enrollment_Criteria(context, m_, p_, v_, 45);
            return w_;
        }


        CqlBoolean l_() {
            IEnumerable<Coverage> x_ = this.Member_Coverage(context);
            CqlInterval<CqlDateTime> y_ = this.Measurement_Period(context);
            CqlDateTime z_ = context.Operators.End(y_);
            CqlDate aa_ = context.Operators.DateFrom(z_);
            CqlDateTime ab_ = context.Operators.Start(y_);
            CqlDate ac_ = context.Operators.DateFrom(ab_);
            CqlInterval<CqlDate> ad_ = context.Operators.Interval(ac_, aa_, true, true);
            CqlBoolean ae_ = NCQAHealthPlanEnrollment_1_0_0.Instance.Health_Plan_Enrollment_Criteria(context, x_, aa_, ad_, 45);
            return ae_;
        }

        return /* CQL 'and' (41:3-49:38) */ (/* CQL 'and' (41:3-46:47) */ (j_
            && k_())
            && l_());
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Initial_Population, Initial_Population_Compute);

    private const long _cacheIndex_Initial_Population = 7412707648530264563L;

    private bool? Initial_Population_Compute(CqlContext context)
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
        CqlBoolean j_ = context.Operators.In<int?>(h_, i_, (string)default);

        CqlBoolean k_() {
            Patient l_ = this.Patient(context);
            Code<AdministrativeGender> m_ = l_?.GenderElement;
            AdministrativeGender? n_ = m_?.Value;
            string o_ = context.Operators.Convert<string>(n_);
            CqlBoolean p_ = context.Operators.Equal(o_, "female");
            return p_;
        }

        return /* CQL 'and' (34:3-38:46) */ (/* CQL 'and' (34:3-37:39) */ (j_
            && k_())
            && this.Enrolled_During_Participation_Period(context));
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator, Denominator_Compute);

    private const long _cacheIndex_Denominator = -1462443103964629966L;

    private bool? Denominator_Compute(CqlContext context)
    {
        CqlBoolean a_ = this.Initial_Population(context);
        return a_;
    }


    [CqlExpressionDefinition("Right Mastectomy Diagnosis")]
    public IEnumerable<Condition> Right_Mastectomy_Diagnosis(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Right_Mastectomy_Diagnosis, Right_Mastectomy_Diagnosis_Compute);

    private const long _cacheIndex_Right_Mastectomy_Diagnosis = 414506849422330649L;

    private IEnumerable<Condition> Right_Mastectomy_Diagnosis_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Absence_of_Right_Breast(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        IEnumerable<Condition> c_ = NCQAStatus_1_0_0.Instance.Active_Condition(context, b_);

        bool? d_(Condition RightMastectomyDiagnosis) {
            CqlInterval<CqlDateTime> f_ = NCQAFHIRBase_1_0_0.Instance.Prevalence_Period(context, RightMastectomyDiagnosis);
            CqlDateTime g_ = context.Operators.Start(f_);
            CqlInterval<CqlDateTime> h_ = this.Measurement_Period(context);
            CqlDateTime i_ = context.Operators.End(h_);
            CqlBoolean j_ = context.Operators.SameOrBefore(g_, i_, (string)default);
            return j_;
        }

        IEnumerable<Condition> e_ = context.Operators.Where<Condition>(c_, d_);
        return e_;
    }


    [CqlExpressionDefinition("Right Mastectomy Procedure")]
    public IEnumerable<Procedure> Right_Mastectomy_Procedure(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Right_Mastectomy_Procedure, Right_Mastectomy_Procedure_Compute);

    private const long _cacheIndex_Right_Mastectomy_Procedure = -4497614126964516178L;

    private IEnumerable<Procedure> Right_Mastectomy_Procedure_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Unilateral_Mastectomy_Right(context);
        IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        IEnumerable<Procedure> c_ = NCQAStatus_1_0_0.Instance.Completed_Procedure(context, b_);
        CqlValueSet d_ = this.Unilateral_Mastectomy(context);
        IEnumerable<Procedure> e_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        IEnumerable<Procedure> f_ = NCQAStatus_1_0_0.Instance.Completed_Procedure(context, e_);

        bool? g_(Procedure UnilateralMastectomyProcedure) {
            List<CodeableConcept> r_ = UnilateralMastectomyProcedure?.BodySite;

            CqlConcept s_(CodeableConcept X) {
                CqlConcept w_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, X);
                return w_;
            }

            IEnumerable<CqlConcept> t_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)r_, s_);
            CqlValueSet u_ = this.Right_Modifier(context);
            CqlBoolean v_ = context.Operators.ConceptsInValueSet(t_, u_);
            return v_;
        }

        IEnumerable<Procedure> h_ = context.Operators.Where<Procedure>(f_, g_);
        IEnumerable<Procedure> i_ = context.Operators.Union<Procedure>(c_, h_);
        CqlValueSet j_ = this.Clinical_Unilateral_Mastectomy(context);
        IEnumerable<Procedure> k_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, j_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        IEnumerable<Procedure> l_ = NCQAStatus_1_0_0.Instance.Completed_Procedure(context, k_);

        bool? m_(Procedure ClinicalUnilateralMastectomyProcedure) {
            List<CodeableConcept> x_ = ClinicalUnilateralMastectomyProcedure?.BodySite;

            CqlConcept y_(CodeableConcept X) {
                CqlConcept ac_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, X);
                return ac_;
            }

            IEnumerable<CqlConcept> z_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)x_, y_);
            CqlValueSet aa_ = this.Clinical_Right_Modifier(context);
            CqlBoolean ab_ = context.Operators.ConceptsInValueSet(z_, aa_);
            return ab_;
        }

        IEnumerable<Procedure> n_ = context.Operators.Where<Procedure>(l_, m_);
        IEnumerable<Procedure> o_ = context.Operators.Union<Procedure>(i_, n_);

        bool? p_(Procedure RightMastectomyProcedure) {
            DataType ad_ = RightMastectomyProcedure?.Performed;
            CqlInterval<CqlDateTime> ae_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, ad_);
            CqlDateTime af_ = context.Operators.End(ae_);
            CqlInterval<CqlDateTime> ag_ = this.Measurement_Period(context);
            CqlDateTime ah_ = context.Operators.End(ag_);
            CqlBoolean ai_ = context.Operators.SameOrBefore(af_, ah_, (string)default);
            return ai_;
        }

        IEnumerable<Procedure> q_ = context.Operators.Where<Procedure>(o_, p_);
        return q_;
    }


    [CqlExpressionDefinition("Left Mastectomy Diagnosis")]
    public IEnumerable<Condition> Left_Mastectomy_Diagnosis(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Left_Mastectomy_Diagnosis, Left_Mastectomy_Diagnosis_Compute);

    private const long _cacheIndex_Left_Mastectomy_Diagnosis = -456883818808121631L;

    private IEnumerable<Condition> Left_Mastectomy_Diagnosis_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Absence_of_Left_Breast(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        IEnumerable<Condition> c_ = NCQAStatus_1_0_0.Instance.Active_Condition(context, b_);

        bool? d_(Condition LeftMastectomyDiagnosis) {
            CqlInterval<CqlDateTime> f_ = NCQAFHIRBase_1_0_0.Instance.Prevalence_Period(context, LeftMastectomyDiagnosis);
            CqlDateTime g_ = context.Operators.Start(f_);
            CqlInterval<CqlDateTime> h_ = this.Measurement_Period(context);
            CqlDateTime i_ = context.Operators.End(h_);
            CqlBoolean j_ = context.Operators.SameOrBefore(g_, i_, (string)default);
            return j_;
        }

        IEnumerable<Condition> e_ = context.Operators.Where<Condition>(c_, d_);
        return e_;
    }


    [CqlExpressionDefinition("Left Mastectomy Procedure")]
    public IEnumerable<Procedure> Left_Mastectomy_Procedure(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Left_Mastectomy_Procedure, Left_Mastectomy_Procedure_Compute);

    private const long _cacheIndex_Left_Mastectomy_Procedure = -9169843818973686218L;

    private IEnumerable<Procedure> Left_Mastectomy_Procedure_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Unilateral_Mastectomy_Left(context);
        IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        IEnumerable<Procedure> c_ = NCQAStatus_1_0_0.Instance.Completed_Procedure(context, b_);
        CqlValueSet d_ = this.Unilateral_Mastectomy(context);
        IEnumerable<Procedure> e_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        IEnumerable<Procedure> f_ = NCQAStatus_1_0_0.Instance.Completed_Procedure(context, e_);

        bool? g_(Procedure UnilateralMastectomyProcedure) {
            List<CodeableConcept> r_ = UnilateralMastectomyProcedure?.BodySite;

            CqlConcept s_(CodeableConcept X) {
                CqlConcept w_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, X);
                return w_;
            }

            IEnumerable<CqlConcept> t_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)r_, s_);
            CqlValueSet u_ = this.Left_Modifier(context);
            CqlBoolean v_ = context.Operators.ConceptsInValueSet(t_, u_);
            return v_;
        }

        IEnumerable<Procedure> h_ = context.Operators.Where<Procedure>(f_, g_);
        IEnumerable<Procedure> i_ = context.Operators.Union<Procedure>(c_, h_);
        CqlValueSet j_ = this.Clinical_Unilateral_Mastectomy(context);
        IEnumerable<Procedure> k_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, j_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        IEnumerable<Procedure> l_ = NCQAStatus_1_0_0.Instance.Completed_Procedure(context, k_);

        bool? m_(Procedure ClinicalUnilateralMastectomyProcedure) {
            List<CodeableConcept> x_ = ClinicalUnilateralMastectomyProcedure?.BodySite;

            CqlConcept y_(CodeableConcept X) {
                CqlConcept ac_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, X);
                return ac_;
            }

            IEnumerable<CqlConcept> z_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)x_, y_);
            CqlValueSet aa_ = this.Clinical_Left_Modifier(context);
            CqlBoolean ab_ = context.Operators.ConceptsInValueSet(z_, aa_);
            return ab_;
        }

        IEnumerable<Procedure> n_ = context.Operators.Where<Procedure>(l_, m_);
        IEnumerable<Procedure> o_ = context.Operators.Union<Procedure>(i_, n_);

        bool? p_(Procedure LeftMastectomyProcedure) {
            DataType ad_ = LeftMastectomyProcedure?.Performed;
            CqlInterval<CqlDateTime> ae_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, ad_);
            CqlDateTime af_ = context.Operators.End(ae_);
            CqlInterval<CqlDateTime> ag_ = this.Measurement_Period(context);
            CqlDateTime ah_ = context.Operators.End(ag_);
            CqlBoolean ai_ = context.Operators.SameOrBefore(af_, ah_, (string)default);
            return ai_;
        }

        IEnumerable<Procedure> q_ = context.Operators.Where<Procedure>(o_, p_);
        return q_;
    }


    [CqlExpressionDefinition("Bilateral Mastectomy Diagnosis")]
    public IEnumerable<Condition> Bilateral_Mastectomy_Diagnosis(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Bilateral_Mastectomy_Diagnosis, Bilateral_Mastectomy_Diagnosis_Compute);

    private const long _cacheIndex_Bilateral_Mastectomy_Diagnosis = -4969549744595762470L;

    private IEnumerable<Condition> Bilateral_Mastectomy_Diagnosis_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.History_of_Bilateral_Mastectomy(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        IEnumerable<Condition> c_ = NCQAStatus_1_0_0.Instance.Active_Condition(context, b_);

        bool? d_(Condition BilateralMastectomyHistory) {
            CqlInterval<CqlDateTime> f_ = NCQAFHIRBase_1_0_0.Instance.Prevalence_Period(context, BilateralMastectomyHistory);
            CqlDateTime g_ = context.Operators.Start(f_);
            CqlInterval<CqlDateTime> h_ = this.Measurement_Period(context);
            CqlDateTime i_ = context.Operators.End(h_);
            CqlBoolean j_ = context.Operators.SameOrBefore(g_, i_, (string)default);
            return j_;
        }

        IEnumerable<Condition> e_ = context.Operators.Where<Condition>(c_, d_);
        return e_;
    }


    [CqlExpressionDefinition("Bilateral Mastectomy Procedure")]
    public IEnumerable<Procedure> Bilateral_Mastectomy_Procedure(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Bilateral_Mastectomy_Procedure, Bilateral_Mastectomy_Procedure_Compute);

    private const long _cacheIndex_Bilateral_Mastectomy_Procedure = -2985614251869755476L;

    private IEnumerable<Procedure> Bilateral_Mastectomy_Procedure_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Bilateral_Mastectomy(context);
        IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        IEnumerable<Procedure> c_ = NCQAStatus_1_0_0.Instance.Completed_Procedure(context, b_);
        CqlValueSet d_ = this.Unilateral_Mastectomy(context);
        IEnumerable<Procedure> e_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        IEnumerable<Procedure> f_ = NCQAStatus_1_0_0.Instance.Completed_Procedure(context, e_);

        bool? g_(Procedure UnilateralMastectomyProcedure) {
            List<CodeableConcept> r_ = UnilateralMastectomyProcedure?.BodySite;

            CqlConcept s_(CodeableConcept X) {
                CqlConcept w_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, X);
                return w_;
            }

            IEnumerable<CqlConcept> t_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)r_, s_);
            CqlValueSet u_ = this.Bilateral_Modifier(context);
            CqlBoolean v_ = context.Operators.ConceptsInValueSet(t_, u_);
            return v_;
        }

        IEnumerable<Procedure> h_ = context.Operators.Where<Procedure>(f_, g_);
        IEnumerable<Procedure> i_ = context.Operators.Union<Procedure>(c_, h_);
        CqlValueSet j_ = this.Clinical_Unilateral_Mastectomy(context);
        IEnumerable<Procedure> k_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, j_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        IEnumerable<Procedure> l_ = NCQAStatus_1_0_0.Instance.Completed_Procedure(context, k_);

        bool? m_(Procedure ClinicalUnilateralMastectomyProcedure) {
            List<CodeableConcept> x_ = ClinicalUnilateralMastectomyProcedure?.BodySite;

            CqlConcept y_(CodeableConcept X) {
                CqlConcept ac_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, X);
                return ac_;
            }

            IEnumerable<CqlConcept> z_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)x_, y_);
            CqlValueSet aa_ = this.Clinical_Bilateral_Modifier(context);
            CqlBoolean ab_ = context.Operators.ConceptsInValueSet(z_, aa_);
            return ab_;
        }

        IEnumerable<Procedure> n_ = context.Operators.Where<Procedure>(l_, m_);
        IEnumerable<Procedure> o_ = context.Operators.Union<Procedure>(i_, n_);

        bool? p_(Procedure BilateralMastectomyPerformed) {
            DataType ad_ = BilateralMastectomyPerformed?.Performed;
            CqlInterval<CqlDateTime> ae_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, ad_);
            CqlDateTime af_ = context.Operators.End(ae_);
            CqlInterval<CqlDateTime> ag_ = this.Measurement_Period(context);
            CqlDateTime ah_ = context.Operators.End(ag_);
            CqlBoolean ai_ = context.Operators.SameOrBefore(af_, ah_, (string)default);
            return ai_;
        }

        IEnumerable<Procedure> q_ = context.Operators.Where<Procedure>(o_, p_);
        return q_;
    }


    [CqlExpressionDefinition("Mastectomy Exclusion")]
    public bool? Mastectomy_Exclusion(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Mastectomy_Exclusion, Mastectomy_Exclusion_Compute);

    private const long _cacheIndex_Mastectomy_Exclusion = 5525034230793920095L;

    private bool? Mastectomy_Exclusion_Compute(CqlContext context)
    {
        IEnumerable<Condition> a_ = this.Right_Mastectomy_Diagnosis(context);
        CqlBoolean b_ = context.Operators.Exists<Condition>(a_);

        CqlBoolean c_() {
            IEnumerable<Procedure> g_ = this.Right_Mastectomy_Procedure(context);
            CqlBoolean h_ = context.Operators.Exists<Procedure>(g_);
            return h_;
        }


        CqlBoolean d_() {
            IEnumerable<Condition> i_ = this.Left_Mastectomy_Diagnosis(context);
            CqlBoolean j_ = context.Operators.Exists<Condition>(i_);

            CqlBoolean k_() {
                IEnumerable<Procedure> l_ = this.Left_Mastectomy_Procedure(context);
                CqlBoolean m_ = context.Operators.Exists<Procedure>(l_);
                return m_;
            }

            return /* CQL 'or' (75:11-77:7) */ (j_
                || k_());
        }


        CqlBoolean e_() {
            IEnumerable<Condition> n_ = this.Bilateral_Mastectomy_Diagnosis(context);
            CqlBoolean o_ = context.Operators.Exists<Condition>(n_);
            return o_;
        }


        CqlBoolean f_() {
            IEnumerable<Procedure> p_ = this.Bilateral_Mastectomy_Procedure(context);
            CqlBoolean q_ = context.Operators.Exists<Procedure>(p_);
            return q_;
        }

        return /* CQL 'or' (72:3-80:46) */ (/* CQL 'or' (72:3-79:46) */ (/* CQL 'and' (72:3-78:3) */ (/* CQL 'or' (72:5-74:5) */ (b_
            || c_())
            && d_())
            || e_())
            || f_());
    }


    [CqlExpressionDefinition("Exclusions")]
    public bool? Exclusions(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Exclusions, Exclusions_Compute);

    private const long _cacheIndex_Exclusions = 3475869383710703363L;

    private bool? Exclusions_Compute(CqlContext context)
    {
        CqlBoolean a_ = NCQAHospice_1_0_0.Instance.Hospice_Intervention_or_Encounter(context);

        CqlBoolean b_() {
            CqlInterval<CqlDateTime> c_ = this.Measurement_Period(context);
            CqlBoolean d_ = NCQAPalliativeCare_1_0_0.Instance.Palliative_Care_Overlapping_Period(context, c_);
            return d_;
        }

        return /* CQL 'or' (66:3-69:83) */ (/* CQL 'or' (66:3-68:96) */ (/* CQL 'or' (66:3-67:29) */ (a_
            || this.Mastectomy_Exclusion(context))
            || NCQAAdvancedIllnessandFrailty_1_0_0.Instance.Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80(context))
            || b_());
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Numerator, Numerator_Compute);

    private const long _cacheIndex_Numerator = 7213918911563365619L;

    private bool? Numerator_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Mammography(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));

        bool? c_(Observation Mammogram) {
            DataType e_ = Mammogram?.Effective;
            CqlInterval<CqlDateTime> f_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, e_);
            CqlDateTime g_ = context.Operators.End(f_);
            CqlInterval<CqlDateTime> h_ = this.Participation_Period(context);
            CqlBoolean i_ = context.Operators.In<CqlDateTime>(g_, h_, (string)default);
            return i_;
        }

        CqlBoolean d_ = context.Operators.WhereAny<Observation>(b_, c_);
        return d_;
    }


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private BCSEHEDISMY2022_1_0_0() {}

    public static BCSEHEDISMY2022_1_0_0 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "BCSEHEDISMY2022";
    public string Version => "1.0.0";
    public ILibrary[] Dependencies => [FHIRHelpers_4_0_001.Instance, NCQAHealthPlanEnrollment_1_0_0.Instance, NCQAStatus_1_0_0.Instance, NCQAFHIRBase_1_0_0.Instance, NCQAHospice_1_0_0.Instance, NCQAAdvancedIllnessandFrailty_1_0_0.Instance, NCQAPalliativeCare_1_0_0.Instance];

    #endregion ILibrary Implementation

}
