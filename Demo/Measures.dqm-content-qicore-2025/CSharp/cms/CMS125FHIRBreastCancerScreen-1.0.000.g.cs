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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.3.8.0")]
[CqlLibrary("CMS125FHIRBreastCancerScreen", "1.0.000")]
public partial class CMS125FHIRBreastCancerScreen_1_0_000 : ILibrary, ISingleton<CMS125FHIRBreastCancerScreen_1_0_000>
{
    #region ValueSets (8)

    [CqlValueSetDefinition("Bilateral Mastectomy", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1005", valueSetVersion: null)]
    public CqlValueSet Bilateral_Mastectomy(CqlContext _) => _Bilateral_Mastectomy;
    private static readonly CqlValueSet _Bilateral_Mastectomy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1005", null);

    [CqlValueSetDefinition("History of bilateral mastectomy", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1068", valueSetVersion: null)]
    public CqlValueSet History_of_bilateral_mastectomy(CqlContext _) => _History_of_bilateral_mastectomy;
    private static readonly CqlValueSet _History_of_bilateral_mastectomy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1068", null);

    [CqlValueSetDefinition("Mammography", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1018", valueSetVersion: null)]
    public CqlValueSet Mammography(CqlContext _) => _Mammography;
    private static readonly CqlValueSet _Mammography = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1018", null);

    [CqlValueSetDefinition("Status Post Left Mastectomy", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1069", valueSetVersion: null)]
    public CqlValueSet Status_Post_Left_Mastectomy(CqlContext _) => _Status_Post_Left_Mastectomy;
    private static readonly CqlValueSet _Status_Post_Left_Mastectomy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1069", null);

    [CqlValueSetDefinition("Status Post Right Mastectomy", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1070", valueSetVersion: null)]
    public CqlValueSet Status_Post_Right_Mastectomy(CqlContext _) => _Status_Post_Right_Mastectomy;
    private static readonly CqlValueSet _Status_Post_Right_Mastectomy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1070", null);

    [CqlValueSetDefinition("Unilateral Mastectomy Left", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1133", valueSetVersion: null)]
    public CqlValueSet Unilateral_Mastectomy_Left(CqlContext _) => _Unilateral_Mastectomy_Left;
    private static readonly CqlValueSet _Unilateral_Mastectomy_Left = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1133", null);

    [CqlValueSetDefinition("Unilateral Mastectomy Right", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1134", valueSetVersion: null)]
    public CqlValueSet Unilateral_Mastectomy_Right(CqlContext _) => _Unilateral_Mastectomy_Right;
    private static readonly CqlValueSet _Unilateral_Mastectomy_Right = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1134", null);

    [CqlValueSetDefinition("Unilateral Mastectomy, Unspecified Laterality", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1071", valueSetVersion: null)]
    public CqlValueSet Unilateral_Mastectomy__Unspecified_Laterality(CqlContext _) => _Unilateral_Mastectomy__Unspecified_Laterality;
    private static readonly CqlValueSet _Unilateral_Mastectomy__Unspecified_Laterality = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1071", null);

    #endregion ValueSets

    #region Codes (2)

    [CqlCodeDefinition("Left (qualifier value)", codeId: "7771000", codeSystem: "http://snomed.info/sct")]
    public CqlCode Left__qualifier_value_(CqlContext _) => _Left__qualifier_value_;
    private static readonly CqlCode _Left__qualifier_value_ = new CqlCode("7771000", "http://snomed.info/sct");

    [CqlCodeDefinition("Right (qualifier value)", codeId: "24028007", codeSystem: "http://snomed.info/sct")]
    public CqlCode Right__qualifier_value_(CqlContext _) => _Right__qualifier_value_;
    private static readonly CqlCode _Right__qualifier_value_ = new CqlCode("24028007", "http://snomed.info/sct");

    #endregion Codes

    #region CodeSystems (1)

    [CqlCodeSystemDefinition("SNOMEDCT", codeSystemId: "http://snomed.info/sct", codeSystemVersion: null)]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT =
      new CqlCodeSystem("http://snomed.info/sct", null, [
          _Left__qualifier_value_,
          _Right__qualifier_value_]);

    #endregion CodeSystems

    #region Parameters (1)

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute);

    private const long _cacheIndex_Measurement_Period = 5556720956197335015L;

    private CqlInterval<CqlDateTime> Measurement_Period_Compute(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime b_ = context.Operators.DateTime(2027, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
        object d_ = context.ResolveParameter("CMS125FHIRBreastCancerScreen-1.0.000", "Measurement Period", c_);
        return (CqlInterval<CqlDateTime>)d_;
    }


    #endregion Parameters

    #region Functions and Expressions (18)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = 8606687644416454030L;

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Initial_Population, Initial_Population_Compute);

    private const long _cacheIndex_Initial_Population = 5772515229944674409L;

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
        CqlInterval<int?> i_ = context.Operators.Interval(42, 74, true, true);
        CqlBoolean j_ = context.Operators.In<int?>(h_, i_, (string)default);
        List<Extension> k_;
        bool u_ = a_ is DomainResource;
        if (u_)
        {
            k_ = (a_ as DomainResource).Extension;
        }
        else
        {
            k_ = default;
        }

        bool? l_(Extension @this) {
            FhirUri v_ = @this?.UrlElement;
            string w_ = FHIRHelpers_4_4_000.Instance.ToString(context, v_);
            CqlBoolean x_ = context.Operators.Equal(w_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-sex");
            return x_;
        }


        DataType m_(Extension @this) {
            DataType y_ = @this?.Value;
            return y_;
        }

        IEnumerable<DataType> n_ = context.Operators.WhereSelect<Extension, DataType>((IEnumerable<Extension>)k_, l_, m_);
        DataType o_ = context.Operators.SingletonFrom<DataType>(n_);
        CqlBoolean p_ = context.Operators.Equal(o_, "248152002");
        CqlBoolean q_ = p_;
        IEnumerable<Encounter> r_ = AdultOutpatientEncounters_4_19_000.Instance.Qualifying_Encounters(context);
        CqlBoolean s_ = context.Operators.Exists<Encounter>(r_);
        CqlBoolean t_ = s_;
        return j_
            /* CQL 'and' (34:3-37:33) */ && q_
            /* CQL 'and' (34:3-38:64) */ && t_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator, Denominator_Compute);

    private const long _cacheIndex_Denominator = -5431271486694348325L;

    private bool? Denominator_Compute(CqlContext context)
    {
        CqlBoolean a_ = this.Initial_Population(context);
        return a_;
    }


    [CqlExpressionDefinition("Right Mastectomy Diagnosis")]
    public IEnumerable<Condition> Right_Mastectomy_Diagnosis(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Right_Mastectomy_Diagnosis, Right_Mastectomy_Diagnosis_Compute);

    private const long _cacheIndex_Right_Mastectomy_Diagnosis = 6592406498959099697L;

    private IEnumerable<Condition> Right_Mastectomy_Diagnosis_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Status_Post_Right_Mastectomy(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> d_ = context.Operators.Union<Condition>(b_ as IEnumerable<Condition>, c_ as IEnumerable<Condition>);
        CqlValueSet e_ = this.Unilateral_Mastectomy__Unspecified_Laterality(context);
        IEnumerable<Condition> f_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, e_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> g_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, e_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> h_ = context.Operators.Union<Condition>(f_ as IEnumerable<Condition>, g_ as IEnumerable<Condition>);

        bool? i_(Condition UnilateralMastectomyDiagnosis) {
            List<CodeableConcept> o_ = UnilateralMastectomyDiagnosis?.BodySite;

            CqlConcept p_(CodeableConcept @this) {
                CqlConcept t_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return t_;
            }


            bool? q_(CqlConcept S) {
                CqlCode u_ = this.Right__qualifier_value_(context);
                CqlConcept v_ = context.Operators.ConvertCodeToConcept(u_);
                CqlBoolean w_ = context.Operators.Equivalent(S, v_);
                return w_;
            }

            IEnumerable<CqlConcept> r_ = context.Operators.SelectWhere<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)o_, p_, q_);
            CqlBoolean s_ = context.Operators.Exists<CqlConcept>(r_);
            return s_;
        }

        IEnumerable<Condition> j_ = context.Operators.Where<Condition>(h_, i_);
        IEnumerable<Condition> k_ = context.Operators.Union<Condition>(d_, j_);
        IEnumerable<Condition> l_ = Status_1_15_000.Instance.verified(context, k_);

        bool? m_(Condition RightMastectomy) {
            CqlInterval<CqlDateTime> x_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, RightMastectomy);
            CqlDateTime y_ = context.Operators.Start(x_);
            CqlInterval<CqlDateTime> z_ = this.Measurement_Period(context);
            CqlDateTime aa_ = context.Operators.End(z_);
            CqlBoolean ab_ = context.Operators.SameOrBefore(y_, aa_, (string)default);
            return ab_;
        }

        IEnumerable<Condition> n_ = context.Operators.Where<Condition>(l_, m_);
        return n_;
    }


    [CqlExpressionDefinition("Right Mastectomy Procedure")]
    public IEnumerable<Procedure> Right_Mastectomy_Procedure(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Right_Mastectomy_Procedure, Right_Mastectomy_Procedure_Compute);

    private const long _cacheIndex_Right_Mastectomy_Procedure = -3570005211201265090L;

    private IEnumerable<Procedure> Right_Mastectomy_Procedure_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Unilateral_Mastectomy_Right(context);
        IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> c_ = Status_1_15_000.Instance.isProcedurePerformed(context, b_);

        bool? d_(Procedure UnilateralMastectomyRightPerformed) {
            object f_;
            DataType l_ = UnilateralMastectomyRightPerformed?.Performed;
            object m_ = FHIRHelpers_4_4_000.Instance.ToValue(context, l_);
            bool n_ = m_ is CqlDateTime;
            if (n_)
            {
                f_ = m_ as CqlDateTime;
            }
            else
            {
                bool o_ = m_ is CqlQuantity;
                if (o_)
                {
                    f_ = m_ as CqlQuantity;
                }
                else
                {
                    bool p_ = m_ is CqlInterval<CqlDateTime>;
                    if (p_)
                    {
                        f_ = m_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bool q_ = m_ is CqlInterval<CqlQuantity>;
                        if (q_)
                        {
                            f_ = m_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            f_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> g_ = QICoreCommon_4_0_000.Instance.toInterval(context, f_);
            CqlDateTime h_ = context.Operators.End(g_);
            CqlInterval<CqlDateTime> i_ = this.Measurement_Period(context);
            CqlDateTime j_ = context.Operators.End(i_);
            CqlBoolean k_ = context.Operators.SameOrBefore(h_, j_, (string)default);
            return k_;
        }

        IEnumerable<Procedure> e_ = context.Operators.Where<Procedure>(c_, d_);
        return e_;
    }


    [CqlExpressionDefinition("Left Mastectomy Diagnosis")]
    public IEnumerable<Condition> Left_Mastectomy_Diagnosis(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Left_Mastectomy_Diagnosis, Left_Mastectomy_Diagnosis_Compute);

    private const long _cacheIndex_Left_Mastectomy_Diagnosis = -1087051068162643016L;

    private IEnumerable<Condition> Left_Mastectomy_Diagnosis_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Status_Post_Left_Mastectomy(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> d_ = context.Operators.Union<Condition>(b_ as IEnumerable<Condition>, c_ as IEnumerable<Condition>);
        CqlValueSet e_ = this.Unilateral_Mastectomy__Unspecified_Laterality(context);
        IEnumerable<Condition> f_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, e_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> g_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, e_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> h_ = context.Operators.Union<Condition>(f_ as IEnumerable<Condition>, g_ as IEnumerable<Condition>);

        bool? i_(Condition UnilateralMastectomyDiagnosis) {
            List<CodeableConcept> o_ = UnilateralMastectomyDiagnosis?.BodySite;

            CqlConcept p_(CodeableConcept @this) {
                CqlConcept t_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return t_;
            }


            bool? q_(CqlConcept S) {
                CqlCode u_ = this.Left__qualifier_value_(context);
                CqlConcept v_ = context.Operators.ConvertCodeToConcept(u_);
                CqlBoolean w_ = context.Operators.Equivalent(S, v_);
                return w_;
            }

            IEnumerable<CqlConcept> r_ = context.Operators.SelectWhere<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)o_, p_, q_);
            CqlBoolean s_ = context.Operators.Exists<CqlConcept>(r_);
            return s_;
        }

        IEnumerable<Condition> j_ = context.Operators.Where<Condition>(h_, i_);
        IEnumerable<Condition> k_ = context.Operators.Union<Condition>(d_, j_);
        IEnumerable<Condition> l_ = Status_1_15_000.Instance.verified(context, k_);

        bool? m_(Condition LeftMastectomy) {
            CqlInterval<CqlDateTime> x_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, LeftMastectomy);
            CqlDateTime y_ = context.Operators.Start(x_);
            CqlInterval<CqlDateTime> z_ = this.Measurement_Period(context);
            CqlDateTime aa_ = context.Operators.End(z_);
            CqlBoolean ab_ = context.Operators.SameOrBefore(y_, aa_, (string)default);
            return ab_;
        }

        IEnumerable<Condition> n_ = context.Operators.Where<Condition>(l_, m_);
        return n_;
    }


    [CqlExpressionDefinition("Left Mastectomy Procedure")]
    public IEnumerable<Procedure> Left_Mastectomy_Procedure(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Left_Mastectomy_Procedure, Left_Mastectomy_Procedure_Compute);

    private const long _cacheIndex_Left_Mastectomy_Procedure = -745559226129717414L;

    private IEnumerable<Procedure> Left_Mastectomy_Procedure_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Unilateral_Mastectomy_Left(context);
        IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> c_ = Status_1_15_000.Instance.isProcedurePerformed(context, b_);

        bool? d_(Procedure UnilateralMastectomyLeftPerformed) {
            object f_;
            DataType l_ = UnilateralMastectomyLeftPerformed?.Performed;
            object m_ = FHIRHelpers_4_4_000.Instance.ToValue(context, l_);
            bool n_ = m_ is CqlDateTime;
            if (n_)
            {
                f_ = m_ as CqlDateTime;
            }
            else
            {
                bool o_ = m_ is CqlQuantity;
                if (o_)
                {
                    f_ = m_ as CqlQuantity;
                }
                else
                {
                    bool p_ = m_ is CqlInterval<CqlDateTime>;
                    if (p_)
                    {
                        f_ = m_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bool q_ = m_ is CqlInterval<CqlQuantity>;
                        if (q_)
                        {
                            f_ = m_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            f_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> g_ = QICoreCommon_4_0_000.Instance.toInterval(context, f_);
            CqlDateTime h_ = context.Operators.End(g_);
            CqlInterval<CqlDateTime> i_ = this.Measurement_Period(context);
            CqlDateTime j_ = context.Operators.End(i_);
            CqlBoolean k_ = context.Operators.SameOrBefore(h_, j_, (string)default);
            return k_;
        }

        IEnumerable<Procedure> e_ = context.Operators.Where<Procedure>(c_, d_);
        return e_;
    }


    [CqlExpressionDefinition("Bilateral Mastectomy Diagnosis")]
    public IEnumerable<Condition> Bilateral_Mastectomy_Diagnosis(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Bilateral_Mastectomy_Diagnosis, Bilateral_Mastectomy_Diagnosis_Compute);

    private const long _cacheIndex_Bilateral_Mastectomy_Diagnosis = 4488951625559911591L;

    private IEnumerable<Condition> Bilateral_Mastectomy_Diagnosis_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.History_of_bilateral_mastectomy(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> d_ = context.Operators.Union<Condition>(b_ as IEnumerable<Condition>, c_ as IEnumerable<Condition>);
        IEnumerable<Condition> e_ = Status_1_15_000.Instance.verified(context, d_);

        bool? f_(Condition BilateralMastectomyHistory) {
            CqlInterval<CqlDateTime> h_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, BilateralMastectomyHistory);
            CqlDateTime i_ = context.Operators.Start(h_);
            CqlInterval<CqlDateTime> j_ = this.Measurement_Period(context);
            CqlDateTime k_ = context.Operators.End(j_);
            CqlBoolean l_ = context.Operators.SameOrBefore(i_, k_, (string)default);
            return l_;
        }

        IEnumerable<Condition> g_ = context.Operators.Where<Condition>(e_, f_);
        return g_;
    }


    [CqlExpressionDefinition("Bilateral Mastectomy Procedure")]
    public IEnumerable<Procedure> Bilateral_Mastectomy_Procedure(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Bilateral_Mastectomy_Procedure, Bilateral_Mastectomy_Procedure_Compute);

    private const long _cacheIndex_Bilateral_Mastectomy_Procedure = -4962569767963537815L;

    private IEnumerable<Procedure> Bilateral_Mastectomy_Procedure_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Bilateral_Mastectomy(context);
        IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> c_ = Status_1_15_000.Instance.isProcedurePerformed(context, b_);

        bool? d_(Procedure BilateralMastectomyPerformed) {
            object f_;
            DataType l_ = BilateralMastectomyPerformed?.Performed;
            object m_ = FHIRHelpers_4_4_000.Instance.ToValue(context, l_);
            bool n_ = m_ is CqlDateTime;
            if (n_)
            {
                f_ = m_ as CqlDateTime;
            }
            else
            {
                bool o_ = m_ is CqlQuantity;
                if (o_)
                {
                    f_ = m_ as CqlQuantity;
                }
                else
                {
                    bool p_ = m_ is CqlInterval<CqlDateTime>;
                    if (p_)
                    {
                        f_ = m_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bool q_ = m_ is CqlInterval<CqlQuantity>;
                        if (q_)
                        {
                            f_ = m_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            f_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> g_ = QICoreCommon_4_0_000.Instance.toInterval(context, f_);
            CqlDateTime h_ = context.Operators.End(g_);
            CqlInterval<CqlDateTime> i_ = this.Measurement_Period(context);
            CqlDateTime j_ = context.Operators.End(i_);
            CqlBoolean k_ = context.Operators.SameOrBefore(h_, j_, (string)default);
            return k_;
        }

        IEnumerable<Procedure> e_ = context.Operators.Where<Procedure>(c_, d_);
        return e_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator_Exclusions, Denominator_Exclusions_Compute);

    private const long _cacheIndex_Denominator_Exclusions = -838195469322575899L;

    private bool? Denominator_Exclusions_Compute(CqlContext context)
    {
        CqlBoolean a_ = Hospice_6_18_000.Instance.Has_Hospice_Services(context);
        IEnumerable<Condition> b_ = this.Right_Mastectomy_Diagnosis(context);
        CqlBoolean c_ = context.Operators.Exists<Condition>(b_);
        IEnumerable<Procedure> d_ = this.Right_Mastectomy_Procedure(context);
        CqlBoolean e_ = context.Operators.Exists<Procedure>(d_);
        CqlBoolean f_ = e_;
        IEnumerable<Condition> g_ = this.Left_Mastectomy_Diagnosis(context);
        CqlBoolean h_ = context.Operators.Exists<Condition>(g_);
        IEnumerable<Procedure> i_ = this.Left_Mastectomy_Procedure(context);
        CqlBoolean j_ = context.Operators.Exists<Procedure>(i_);
        CqlBoolean k_ = j_;
        CqlBoolean l_ = h_
            /* CQL 'or' (48:13-50:9) */ || k_;
        CqlBoolean m_ = (c_
            /* CQL 'or' (45:10-47:7) */ || f_)
            /* CQL 'and' (45:8-51:5) */ && l_;
        IEnumerable<Condition> n_ = this.Bilateral_Mastectomy_Diagnosis(context);
        CqlBoolean o_ = context.Operators.Exists<Condition>(n_);
        CqlBoolean p_ = o_;
        IEnumerable<Procedure> q_ = this.Bilateral_Mastectomy_Procedure(context);
        CqlBoolean r_ = context.Operators.Exists<Procedure>(q_);
        CqlBoolean s_ = r_;
        return a_
            /* CQL 'or' (44:3-51:5) */ || m_
            /* CQL 'or' (44:3-52:46) */ || p_
            /* CQL 'or' (44:3-53:46) */ || s_
            /* CQL 'or' (44:3-54:73) */ || AdvancedIllnessandFrailty_1_27_000.Instance.Is_Age_66_or_Older_with_Advanced_Illness_and_Frailty(context)
            /* CQL 'or' (44:3-55:74) */ || AdvancedIllnessandFrailty_1_27_000.Instance.Is_Age_66_or_Older_Living_Long_Term_in_a_Nursing_Home(context)
            /* CQL 'or' (44:3-56:69) */ || PalliativeCare_1_18_000.Instance.Has_Palliative_Care_in_the_Measurement_Period(context);
    }


    [CqlExpressionDefinition("October 1 Two Years Prior to the Measurement Period")]
    public CqlDateTime October_1_Two_Years_Prior_to_the_Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_October_1_Two_Years_Prior_to_the_Measurement_Period, October_1_Two_Years_Prior_to_the_Measurement_Period_Compute);

    private const long _cacheIndex_October_1_Two_Years_Prior_to_the_Measurement_Period = -2207243454754975926L;

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


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Numerator, Numerator_Compute);

    private const long _cacheIndex_Numerator = 8052686255296442553L;

    private bool? Numerator_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Mammography(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-clinical-result"));
        IEnumerable<Observation> c_ = Status_1_15_000.Instance.isDiagnosticStudyPerformed(context, b_);

        bool? d_(Observation Mammogram) {
            DataType f_ = Mammogram?.Effective;
            object g_ = FHIRHelpers_4_4_000.Instance.ToValue(context, f_);
            CqlInterval<CqlDateTime> h_ = QICoreCommon_4_0_000.Instance.toInterval(context, g_);
            CqlDateTime i_ = context.Operators.End(h_);
            CqlDateTime j_ = this.October_1_Two_Years_Prior_to_the_Measurement_Period(context);
            CqlInterval<CqlDateTime> k_ = this.Measurement_Period(context);
            CqlDateTime l_ = context.Operators.End(k_);
            CqlInterval<CqlDateTime> m_ = context.Operators.Interval(j_, l_, true, true);
            CqlBoolean n_ = context.Operators.In<CqlDateTime>(i_, m_, "day");
            return n_;
        }

        CqlBoolean e_ = context.Operators.WhereAny<Observation>(c_, d_);
        return e_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Ethnicity, SDE_Ethnicity_Compute);

    private const long _cacheIndex_SDE_Ethnicity = 2058975436399114785L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Payer, SDE_Payer_Compute);

    private const long _cacheIndex_SDE_Payer = 2500397001132296590L;

    private IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Race, SDE_Race_Compute);

    private const long _cacheIndex_SDE_Race = -1497321803102244495L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Sex, SDE_Sex_Compute);

    private const long _cacheIndex_SDE_Sex = 5549240662922130053L;

    private CqlCode SDE_Sex_Compute(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
        return a_;
    }


    [CqlExpressionDefinition("Stratification 1")]
    public bool? Stratification_1(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Stratification_1, Stratification_1_Compute);

    private const long _cacheIndex_Stratification_1 = 536189169464865893L;

    private bool? Stratification_1_Compute(CqlContext context)
    {
        Patient a_ = this.Patient(context);
        Date b_ = a_?.BirthDateElement;
        string c_ = b_?.Value;
        CqlDate d_ = context.Operators.ConvertStringToDate(c_);
        CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
        CqlDateTime f_ = context.Operators.End(e_);
        CqlDate g_ = context.Operators.DateFrom(f_);
        int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
        CqlInterval<int?> i_ = context.Operators.Interval(42, 51, true, true);
        CqlBoolean j_ = context.Operators.In<int?>(h_, i_, (string)default);
        return j_;
    }


    [CqlExpressionDefinition("Stratification 2")]
    public bool? Stratification_2(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Stratification_2, Stratification_2_Compute);

    private const long _cacheIndex_Stratification_2 = -7558575256401005941L;

    private bool? Stratification_2_Compute(CqlContext context)
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
        return j_;
    }


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private CMS125FHIRBreastCancerScreen_1_0_000() {}

    public static CMS125FHIRBreastCancerScreen_1_0_000 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "CMS125FHIRBreastCancerScreen";
    public string Version => "1.0.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, SupplementalDataElements_5_1_000.Instance, QICoreCommon_4_0_000.Instance, AdultOutpatientEncounters_4_19_000.Instance, Hospice_6_18_000.Instance, Status_1_15_000.Instance, PalliativeCare_1_18_000.Instance, AdvancedIllnessandFrailty_1_27_000.Instance];

    #endregion ILibrary Implementation

}
