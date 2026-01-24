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
using Hl7.Cql.Runtime.Internal;
using Hl7.Fhir.Model;
using Range = Hl7.Fhir.Model.Range;
using Task = Hl7.Fhir.Model.Task;

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "6.0.0.0")]
[CqlLibrary("CMS125FHIRBreastCancerScreen", "1.0.000")]
public partial class CMS125FHIRBreastCancerScreen_1_0_000 : ILibrary, ILibraryInternals, ISingleton<CMS125FHIRBreastCancerScreen_1_0_000>
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
        _cache?.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute, context) ?? Measurement_Period_Compute(context);

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
        _cache?.GetOrCompute(_cacheIndex_Patient, Patient_Compute, context) ?? Patient_Compute(context);

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Initial_Population, Initial_Population_Compute, context) ?? Initial_Population_Compute(context);

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
        bool? j_ = context.Operators.In<int?>(h_, i_, default);

        List<Extension> k_() {

            bool v_() {
                Patient w_ = this.Patient(context);
                bool x_ = w_ is DomainResource;
                return x_;
            }

            if (v_())
            {
                Patient y_ = this.Patient(context);
                return (y_ as DomainResource).Extension;
            }
            else
            {
                return default;
            };
        }


        bool? l_(Extension @this) {
            FhirUri z_ = @this?.UrlElement;
            string aa_ = FHIRHelpers_4_4_000.Instance.ToString(context, z_);
            bool? ab_ = context.Operators.Equal(aa_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-sex");
            return ab_;
        }

        IEnumerable<Extension> m_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(k_()), l_);

        DataType n_(Extension @this) {
            DataType ac_ = @this?.Value;
            return ac_;
        }

        IEnumerable<DataType> o_ = context.Operators.Select<Extension, DataType>(m_, n_);
        DataType p_ = context.Operators.SingletonFrom<DataType>(o_);
        bool? q_ = context.Operators.Equal(p_, "248152002");
        bool? r_ = context.Operators.And(j_, q_);
        IEnumerable<Encounter> s_ = AdultOutpatientEncounters_4_19_000.Instance.Qualifying_Encounters(context);
        bool? t_ = context.Operators.Exists<Encounter>(s_);
        bool? u_ = context.Operators.And(r_, t_);
        return u_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Denominator, Denominator_Compute, context) ?? Denominator_Compute(context);

    private bool? Denominator_Compute(CqlContext context)
    {
        bool? a_ = this.Initial_Population(context);
        return a_;
    }


    [CqlExpressionDefinition("Right Mastectomy Diagnosis")]
    public IEnumerable<object> Right_Mastectomy_Diagnosis(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Right_Mastectomy_Diagnosis, Right_Mastectomy_Diagnosis_Compute, context) ?? Right_Mastectomy_Diagnosis_Compute(context);

    private IEnumerable<object> Right_Mastectomy_Diagnosis_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Status_Post_Right_Mastectomy(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<object> e_ = context.Operators.Union<object>(b_ as IEnumerable<object>, d_ as IEnumerable<object>);
        CqlValueSet f_ = this.Unilateral_Mastectomy__Unspecified_Laterality(context);
        IEnumerable<Condition> g_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> i_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<object> j_ = context.Operators.Union<object>(g_ as IEnumerable<object>, i_ as IEnumerable<object>);

        bool? k_(object UnilateralMastectomyDiagnosis) {
            object q_ = context.Operators.LateBoundProperty<object>(UnilateralMastectomyDiagnosis, "bodySite");
            object[] r_ = [
                q_,
            ];

            CqlConcept s_(object @this) {
                CqlConcept z_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this as CodeableConcept);
                return z_;
            }

            IEnumerable<CqlConcept> t_ = context.Operators.Select<object, CqlConcept>((IEnumerable<object>)r_, s_);
            CqlConcept u_ = context.Operators.SingletonFrom<CqlConcept>(t_);
            CqlConcept[] v_ = [
                u_,
            ];

            bool? w_(CqlConcept S) {
                CqlCode aa_ = this.Right__qualifier_value_(context);
                CqlConcept ab_ = context.Operators.ConvertCodeToConcept(aa_);
                bool? ac_ = context.Operators.Equivalent(S, ab_);
                return ac_;
            }

            IEnumerable<CqlConcept> x_ = context.Operators.Where<CqlConcept>((IEnumerable<CqlConcept>)v_, w_);
            bool? y_ = context.Operators.Exists<CqlConcept>(x_);
            return y_;
        }

        IEnumerable<object> l_ = context.Operators.Where<object>(j_, k_);
        IEnumerable<object> m_ = context.Operators.Union<object>(e_, l_);
        IEnumerable<object> n_ = Status_1_15_000.Instance.verified(context, m_);

        bool? o_(object RightMastectomy) {
            CqlInterval<CqlDateTime> ad_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, RightMastectomy);
            CqlDateTime ae_ = context.Operators.Start(ad_);
            CqlInterval<CqlDateTime> af_ = this.Measurement_Period(context);
            CqlDateTime ag_ = context.Operators.End(af_);
            bool? ah_ = context.Operators.SameOrBefore(ae_, ag_, default);
            return ah_;
        }

        IEnumerable<object> p_ = context.Operators.Where<object>(n_, o_);
        return p_;
    }


    [CqlExpressionDefinition("Right Mastectomy Procedure")]
    public IEnumerable<Procedure> Right_Mastectomy_Procedure(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Right_Mastectomy_Procedure, Right_Mastectomy_Procedure_Compute, context) ?? Right_Mastectomy_Procedure_Compute(context);

    private IEnumerable<Procedure> Right_Mastectomy_Procedure_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Unilateral_Mastectomy_Right(context);
        IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> c_ = Status_1_15_000.Instance.isProcedurePerformed(context, b_);

        bool? d_(Procedure UnilateralMastectomyRightPerformed) {

            object f_() {

                bool l_() {
                    DataType p_ = UnilateralMastectomyRightPerformed?.Performed;
                    object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
                    bool r_ = q_ is CqlDateTime;
                    return r_;
                }


                bool m_() {
                    DataType s_ = UnilateralMastectomyRightPerformed?.Performed;
                    object t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
                    bool u_ = t_ is CqlInterval<CqlDateTime>;
                    return u_;
                }


                bool n_() {
                    DataType v_ = UnilateralMastectomyRightPerformed?.Performed;
                    object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                    bool x_ = w_ is CqlQuantity;
                    return x_;
                }


                bool o_() {
                    DataType y_ = UnilateralMastectomyRightPerformed?.Performed;
                    object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                    bool aa_ = z_ is CqlInterval<CqlQuantity>;
                    return aa_;
                }

                if (l_())
                {
                    DataType ab_ = UnilateralMastectomyRightPerformed?.Performed;
                    object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                    return (ac_ as CqlDateTime) as object;
                }
                else if (m_())
                {
                    DataType ad_ = UnilateralMastectomyRightPerformed?.Performed;
                    object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                    return (ae_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (n_())
                {
                    DataType af_ = UnilateralMastectomyRightPerformed?.Performed;
                    object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                    return (ag_ as CqlQuantity) as object;
                }
                else if (o_())
                {
                    DataType ah_ = UnilateralMastectomyRightPerformed?.Performed;
                    object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                    return (ai_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> g_ = QICoreCommon_4_0_000.Instance.toInterval(context, f_());
            CqlDateTime h_ = context.Operators.End(g_);
            CqlInterval<CqlDateTime> i_ = this.Measurement_Period(context);
            CqlDateTime j_ = context.Operators.End(i_);
            bool? k_ = context.Operators.SameOrBefore(h_, j_, default);
            return k_;
        }

        IEnumerable<Procedure> e_ = context.Operators.Where<Procedure>(c_, d_);
        return e_;
    }


    [CqlExpressionDefinition("Left Mastectomy Diagnosis")]
    public IEnumerable<object> Left_Mastectomy_Diagnosis(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Left_Mastectomy_Diagnosis, Left_Mastectomy_Diagnosis_Compute, context) ?? Left_Mastectomy_Diagnosis_Compute(context);

    private IEnumerable<object> Left_Mastectomy_Diagnosis_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Status_Post_Left_Mastectomy(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<object> e_ = context.Operators.Union<object>(b_ as IEnumerable<object>, d_ as IEnumerable<object>);
        CqlValueSet f_ = this.Unilateral_Mastectomy__Unspecified_Laterality(context);
        IEnumerable<Condition> g_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> i_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<object> j_ = context.Operators.Union<object>(g_ as IEnumerable<object>, i_ as IEnumerable<object>);

        bool? k_(object UnilateralMastectomyDiagnosis) {
            object q_ = context.Operators.LateBoundProperty<object>(UnilateralMastectomyDiagnosis, "bodySite");
            object[] r_ = [
                q_,
            ];

            CqlConcept s_(object @this) {
                CqlConcept z_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this as CodeableConcept);
                return z_;
            }

            IEnumerable<CqlConcept> t_ = context.Operators.Select<object, CqlConcept>((IEnumerable<object>)r_, s_);
            CqlConcept u_ = context.Operators.SingletonFrom<CqlConcept>(t_);
            CqlConcept[] v_ = [
                u_,
            ];

            bool? w_(CqlConcept S) {
                CqlCode aa_ = this.Left__qualifier_value_(context);
                CqlConcept ab_ = context.Operators.ConvertCodeToConcept(aa_);
                bool? ac_ = context.Operators.Equivalent(S, ab_);
                return ac_;
            }

            IEnumerable<CqlConcept> x_ = context.Operators.Where<CqlConcept>((IEnumerable<CqlConcept>)v_, w_);
            bool? y_ = context.Operators.Exists<CqlConcept>(x_);
            return y_;
        }

        IEnumerable<object> l_ = context.Operators.Where<object>(j_, k_);
        IEnumerable<object> m_ = context.Operators.Union<object>(e_, l_);
        IEnumerable<object> n_ = Status_1_15_000.Instance.verified(context, m_);

        bool? o_(object LeftMastectomy) {
            CqlInterval<CqlDateTime> ad_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, LeftMastectomy);
            CqlDateTime ae_ = context.Operators.Start(ad_);
            CqlInterval<CqlDateTime> af_ = this.Measurement_Period(context);
            CqlDateTime ag_ = context.Operators.End(af_);
            bool? ah_ = context.Operators.SameOrBefore(ae_, ag_, default);
            return ah_;
        }

        IEnumerable<object> p_ = context.Operators.Where<object>(n_, o_);
        return p_;
    }


    [CqlExpressionDefinition("Left Mastectomy Procedure")]
    public IEnumerable<Procedure> Left_Mastectomy_Procedure(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Left_Mastectomy_Procedure, Left_Mastectomy_Procedure_Compute, context) ?? Left_Mastectomy_Procedure_Compute(context);

    private IEnumerable<Procedure> Left_Mastectomy_Procedure_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Unilateral_Mastectomy_Left(context);
        IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> c_ = Status_1_15_000.Instance.isProcedurePerformed(context, b_);

        bool? d_(Procedure UnilateralMastectomyLeftPerformed) {

            object f_() {

                bool l_() {
                    DataType p_ = UnilateralMastectomyLeftPerformed?.Performed;
                    object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
                    bool r_ = q_ is CqlDateTime;
                    return r_;
                }


                bool m_() {
                    DataType s_ = UnilateralMastectomyLeftPerformed?.Performed;
                    object t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
                    bool u_ = t_ is CqlInterval<CqlDateTime>;
                    return u_;
                }


                bool n_() {
                    DataType v_ = UnilateralMastectomyLeftPerformed?.Performed;
                    object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                    bool x_ = w_ is CqlQuantity;
                    return x_;
                }


                bool o_() {
                    DataType y_ = UnilateralMastectomyLeftPerformed?.Performed;
                    object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                    bool aa_ = z_ is CqlInterval<CqlQuantity>;
                    return aa_;
                }

                if (l_())
                {
                    DataType ab_ = UnilateralMastectomyLeftPerformed?.Performed;
                    object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                    return (ac_ as CqlDateTime) as object;
                }
                else if (m_())
                {
                    DataType ad_ = UnilateralMastectomyLeftPerformed?.Performed;
                    object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                    return (ae_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (n_())
                {
                    DataType af_ = UnilateralMastectomyLeftPerformed?.Performed;
                    object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                    return (ag_ as CqlQuantity) as object;
                }
                else if (o_())
                {
                    DataType ah_ = UnilateralMastectomyLeftPerformed?.Performed;
                    object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                    return (ai_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> g_ = QICoreCommon_4_0_000.Instance.toInterval(context, f_());
            CqlDateTime h_ = context.Operators.End(g_);
            CqlInterval<CqlDateTime> i_ = this.Measurement_Period(context);
            CqlDateTime j_ = context.Operators.End(i_);
            bool? k_ = context.Operators.SameOrBefore(h_, j_, default);
            return k_;
        }

        IEnumerable<Procedure> e_ = context.Operators.Where<Procedure>(c_, d_);
        return e_;
    }


    [CqlExpressionDefinition("Bilateral Mastectomy Diagnosis")]
    public IEnumerable<object> Bilateral_Mastectomy_Diagnosis(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Bilateral_Mastectomy_Diagnosis, Bilateral_Mastectomy_Diagnosis_Compute, context) ?? Bilateral_Mastectomy_Diagnosis_Compute(context);

    private IEnumerable<object> Bilateral_Mastectomy_Diagnosis_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.History_of_bilateral_mastectomy(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<object> e_ = context.Operators.Union<object>(b_ as IEnumerable<object>, d_ as IEnumerable<object>);
        IEnumerable<object> f_ = Status_1_15_000.Instance.verified(context, e_);

        bool? g_(object BilateralMastectomyHistory) {
            CqlInterval<CqlDateTime> i_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, BilateralMastectomyHistory);
            CqlDateTime j_ = context.Operators.Start(i_);
            CqlInterval<CqlDateTime> k_ = this.Measurement_Period(context);
            CqlDateTime l_ = context.Operators.End(k_);
            bool? m_ = context.Operators.SameOrBefore(j_, l_, default);
            return m_;
        }

        IEnumerable<object> h_ = context.Operators.Where<object>(f_, g_);
        return h_;
    }


    [CqlExpressionDefinition("Bilateral Mastectomy Procedure")]
    public IEnumerable<Procedure> Bilateral_Mastectomy_Procedure(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Bilateral_Mastectomy_Procedure, Bilateral_Mastectomy_Procedure_Compute, context) ?? Bilateral_Mastectomy_Procedure_Compute(context);

    private IEnumerable<Procedure> Bilateral_Mastectomy_Procedure_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Bilateral_Mastectomy(context);
        IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> c_ = Status_1_15_000.Instance.isProcedurePerformed(context, b_);

        bool? d_(Procedure BilateralMastectomyPerformed) {

            object f_() {

                bool l_() {
                    DataType p_ = BilateralMastectomyPerformed?.Performed;
                    object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
                    bool r_ = q_ is CqlDateTime;
                    return r_;
                }


                bool m_() {
                    DataType s_ = BilateralMastectomyPerformed?.Performed;
                    object t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
                    bool u_ = t_ is CqlInterval<CqlDateTime>;
                    return u_;
                }


                bool n_() {
                    DataType v_ = BilateralMastectomyPerformed?.Performed;
                    object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                    bool x_ = w_ is CqlQuantity;
                    return x_;
                }


                bool o_() {
                    DataType y_ = BilateralMastectomyPerformed?.Performed;
                    object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                    bool aa_ = z_ is CqlInterval<CqlQuantity>;
                    return aa_;
                }

                if (l_())
                {
                    DataType ab_ = BilateralMastectomyPerformed?.Performed;
                    object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                    return (ac_ as CqlDateTime) as object;
                }
                else if (m_())
                {
                    DataType ad_ = BilateralMastectomyPerformed?.Performed;
                    object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                    return (ae_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (n_())
                {
                    DataType af_ = BilateralMastectomyPerformed?.Performed;
                    object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                    return (ag_ as CqlQuantity) as object;
                }
                else if (o_())
                {
                    DataType ah_ = BilateralMastectomyPerformed?.Performed;
                    object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                    return (ai_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> g_ = QICoreCommon_4_0_000.Instance.toInterval(context, f_());
            CqlDateTime h_ = context.Operators.End(g_);
            CqlInterval<CqlDateTime> i_ = this.Measurement_Period(context);
            CqlDateTime j_ = context.Operators.End(i_);
            bool? k_ = context.Operators.SameOrBefore(h_, j_, default);
            return k_;
        }

        IEnumerable<Procedure> e_ = context.Operators.Where<Procedure>(c_, d_);
        return e_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Denominator_Exclusions, Denominator_Exclusions_Compute, context) ?? Denominator_Exclusions_Compute(context);

    private bool? Denominator_Exclusions_Compute(CqlContext context)
    {
        bool? a_ = Hospice_6_18_000.Instance.Has_Hospice_Services(context);
        IEnumerable<object> b_ = this.Right_Mastectomy_Diagnosis(context);
        bool? c_ = context.Operators.Exists<object>(b_);
        IEnumerable<Procedure> d_ = this.Right_Mastectomy_Procedure(context);
        bool? e_ = context.Operators.Exists<Procedure>(d_);
        bool? f_ = context.Operators.Or(c_, e_);
        IEnumerable<object> g_ = this.Left_Mastectomy_Diagnosis(context);
        bool? h_ = context.Operators.Exists<object>(g_);
        IEnumerable<Procedure> i_ = this.Left_Mastectomy_Procedure(context);
        bool? j_ = context.Operators.Exists<Procedure>(i_);
        bool? k_ = context.Operators.Or(h_, j_);
        bool? l_ = context.Operators.And(f_, k_);
        bool? m_ = context.Operators.Or(a_, l_);
        IEnumerable<object> n_ = this.Bilateral_Mastectomy_Diagnosis(context);
        bool? o_ = context.Operators.Exists<object>(n_);
        bool? p_ = context.Operators.Or(m_, o_);
        IEnumerable<Procedure> q_ = this.Bilateral_Mastectomy_Procedure(context);
        bool? r_ = context.Operators.Exists<Procedure>(q_);
        bool? s_ = context.Operators.Or(p_, r_);
        bool? t_ = AdvancedIllnessandFrailty_1_27_000.Instance.Is_Age_66_or_Older_with_Advanced_Illness_and_Frailty(context);
        bool? u_ = context.Operators.Or(s_, t_);
        bool? v_ = AdvancedIllnessandFrailty_1_27_000.Instance.Is_Age_66_or_Older_Living_Long_Term_in_a_Nursing_Home(context);
        bool? w_ = context.Operators.Or(u_, v_);
        bool? x_ = PalliativeCare_1_18_000.Instance.Has_Palliative_Care_in_the_Measurement_Period(context);
        bool? y_ = context.Operators.Or(w_, x_);
        return y_;
    }


    [CqlExpressionDefinition("October 1 Two Years Prior to the Measurement Period")]
    public CqlDateTime October_1_Two_Years_Prior_to_the_Measurement_Period(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_October_1_Two_Years_Prior_to_the_Measurement_Period, October_1_Two_Years_Prior_to_the_Measurement_Period_Compute, context) ?? October_1_Two_Years_Prior_to_the_Measurement_Period_Compute(context);

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
        _cache?.GetOrCompute(_cacheIndex_Numerator, Numerator_Compute, context) ?? Numerator_Compute(context);

    private bool? Numerator_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Mammography(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-clinical-result"));
        IEnumerable<Observation> c_ = Status_1_15_000.Instance.isDiagnosticStudyPerformed(context, b_);

        bool? d_(Observation Mammogram) {
            DataType g_ = Mammogram?.Effective;
            object h_ = FHIRHelpers_4_4_000.Instance.ToValue(context, g_);
            CqlInterval<CqlDateTime> i_ = QICoreCommon_4_0_000.Instance.toInterval(context, h_);
            CqlDateTime j_ = context.Operators.End(i_);
            CqlDateTime k_ = this.October_1_Two_Years_Prior_to_the_Measurement_Period(context);
            CqlInterval<CqlDateTime> l_ = this.Measurement_Period(context);
            CqlDateTime m_ = context.Operators.End(l_);
            CqlInterval<CqlDateTime> n_ = context.Operators.Interval(k_, m_, true, true);
            bool? o_ = context.Operators.In<CqlDateTime>(j_, n_, "day");
            return o_;
        }

        IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);
        bool? f_ = context.Operators.Exists<Observation>(e_);
        return f_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_SDE_Ethnicity, SDE_Ethnicity_Compute, context) ?? SDE_Ethnicity_Compute(context);

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_SDE_Payer, SDE_Payer_Compute, context) ?? SDE_Payer_Compute(context);

    private IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_SDE_Race, SDE_Race_Compute, context) ?? SDE_Race_Compute(context);

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_SDE_Sex, SDE_Sex_Compute, context) ?? SDE_Sex_Compute(context);

    private CqlCode SDE_Sex_Compute(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
        return a_;
    }


    [CqlExpressionDefinition("Stratification 1")]
    public bool? Stratification_1(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Stratification_1, Stratification_1_Compute, context) ?? Stratification_1_Compute(context);

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
        bool? j_ = context.Operators.In<int?>(h_, i_, default);
        return j_;
    }


    [CqlExpressionDefinition("Stratification 2")]
    public bool? Stratification_2(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Stratification_2, Stratification_2_Compute, context) ?? Stratification_2_Compute(context);

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
        bool? j_ = context.Operators.In<int?>(h_, i_, default);
        return j_;
    }


    #endregion Functions and Expressions

    #region Cache Index Fields (19)

    private int _cacheIndex_Measurement_Period = -1;
    private int _cacheIndex_Patient = -1;
    private int _cacheIndex_Initial_Population = -1;
    private int _cacheIndex_Denominator = -1;
    private int _cacheIndex_Right_Mastectomy_Diagnosis = -1;
    private int _cacheIndex_Right_Mastectomy_Procedure = -1;
    private int _cacheIndex_Left_Mastectomy_Diagnosis = -1;
    private int _cacheIndex_Left_Mastectomy_Procedure = -1;
    private int _cacheIndex_Bilateral_Mastectomy_Diagnosis = -1;
    private int _cacheIndex_Bilateral_Mastectomy_Procedure = -1;
    private int _cacheIndex_Denominator_Exclusions = -1;
    private int _cacheIndex_October_1_Two_Years_Prior_to_the_Measurement_Period = -1;
    private int _cacheIndex_Numerator = -1;
    private int _cacheIndex_SDE_Ethnicity = -1;
    private int _cacheIndex_SDE_Payer = -1;
    private int _cacheIndex_SDE_Race = -1;
    private int _cacheIndex_SDE_Sex = -1;
    private int _cacheIndex_Stratification_1 = -1;
    private int _cacheIndex_Stratification_2 = -1;

    #endregion Cache Index Fields

    #region ILibraryInternals Implementation

    private CqlLibraryInvocationCache _cache = CqlLibraryInvocationCache.NeverCached;

    /// <summary>
    /// Initializes cache indices for this library's cached expressions.
    /// </summary>
    /// <param name="libraryInvocationSet">The library invocation set performing initialization.</param>
    /// <param name="startIndex">The starting index for cache field assignment.</param>
    /// <returns>The number of cache indices initialized (number of cached expressions in this library).</returns>
    int ILibraryInternals.InitializeCacheIndices(
        CqlLibraryInvocationSet libraryInvocationSet,
        int startIndex)
    {
        var index = startIndex;
        _cacheIndex_Measurement_Period = index++;
        _cacheIndex_Patient = index++;
        _cacheIndex_Initial_Population = index++;
        _cacheIndex_Denominator = index++;
        _cacheIndex_Right_Mastectomy_Diagnosis = index++;
        _cacheIndex_Right_Mastectomy_Procedure = index++;
        _cacheIndex_Left_Mastectomy_Diagnosis = index++;
        _cacheIndex_Left_Mastectomy_Procedure = index++;
        _cacheIndex_Bilateral_Mastectomy_Diagnosis = index++;
        _cacheIndex_Bilateral_Mastectomy_Procedure = index++;
        _cacheIndex_Denominator_Exclusions = index++;
        _cacheIndex_October_1_Two_Years_Prior_to_the_Measurement_Period = index++;
        _cacheIndex_Numerator = index++;
        _cacheIndex_SDE_Ethnicity = index++;
        _cacheIndex_SDE_Payer = index++;
        _cacheIndex_SDE_Race = index++;
        _cacheIndex_SDE_Sex = index++;
        _cacheIndex_Stratification_1 = index++;
        _cacheIndex_Stratification_2 = index++;
        return index - startIndex;
    }

    /// <summary>
    /// Sets the cache instance that this library will use for caching computed values.
    /// </summary>
    /// <param name="cache">The cache instance to use.</param>
    void ILibraryInternals.SetCacheInstance(CqlLibraryInvocationCache cache)
    {
        _cache = cache;
    }

    #endregion ILibraryInternals Implementation

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
