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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "3.0.0.0")]
[CqlLibrary("BreastCancerScreeningFHIR", "0.0.001")]
public partial class BreastCancerScreeningFHIR_0_0_001 : ILibrary, ISingleton<BreastCancerScreeningFHIR_0_0_001>
{
    private BreastCancerScreeningFHIR_0_0_001() {}

    public static BreastCancerScreeningFHIR_0_0_001 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "BreastCancerScreeningFHIR";
    public string Version => "0.0.001";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, SupplementalDataElements_3_5_000.Instance, QICoreCommon_2_1_000.Instance, AdultOutpatientEncounters_4_11_000.Instance, Hospice_6_12_000.Instance, Status_1_8_000.Instance, PalliativeCare_1_11_000.Instance, AdvancedIllnessandFrailty_1_16_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

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

    #region Codes

    [CqlCodeDefinition("Female", codeId: "F", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-AdministrativeGender")]
    public CqlCode Female(CqlContext _) => _Female;
    private static readonly CqlCode _Female = new CqlCode("F", "http://terminology.hl7.org/CodeSystem/v3-AdministrativeGender");

    [CqlCodeDefinition("Left (qualifier value)", codeId: "7771000", codeSystem: "http://snomed.info/sct")]
    public CqlCode Left__qualifier_value_(CqlContext _) => _Left__qualifier_value_;
    private static readonly CqlCode _Left__qualifier_value_ = new CqlCode("7771000", "http://snomed.info/sct");

    [CqlCodeDefinition("Right (qualifier value)", codeId: "24028007", codeSystem: "http://snomed.info/sct")]
    public CqlCode Right__qualifier_value_(CqlContext _) => _Right__qualifier_value_;
    private static readonly CqlCode _Right__qualifier_value_ = new CqlCode("24028007", "http://snomed.info/sct");

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("AdministrativeGender", codeSystemId: "http://terminology.hl7.org/CodeSystem/v3-AdministrativeGender", codeSystemVersion: null)]
    public CqlCodeSystem AdministrativeGender(CqlContext _) => _AdministrativeGender;
    private static readonly CqlCodeSystem _AdministrativeGender =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/v3-AdministrativeGender", null, [
          _Female]);

    [CqlCodeSystemDefinition("SNOMEDCT", codeSystemId: "http://snomed.info/sct", codeSystemVersion: null)]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT =
      new CqlCodeSystem("http://snomed.info/sct", null, [
          _Left__qualifier_value_,
          _Right__qualifier_value_]);

    [CqlCodeSystemDefinition("LOINC", codeSystemId: "http://loinc.org", codeSystemVersion: null)]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC =
      new CqlCodeSystem("http://loinc.org", null, []);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime b_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, true);
        object d_ = context.ResolveParameter("BreastCancerScreeningFHIR-0.0.001", "Measurement Period", c_);

        return (CqlInterval<CqlDateTime>)d_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

        return b_;
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
        IEnumerable<Encounter> q_ = AdultOutpatientEncounters_4_11_000.Instance.Qualifying_Encounters(context);
        bool? r_ = context.Operators.Exists<Encounter>(q_);
        bool? s_ = context.Operators.And(p_, r_);

        return s_;
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
        CqlValueSet a_ = this.Status_Post_Right_Mastectomy(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet c_ = this.Unilateral_Mastectomy__Unspecified_Laterality(context);
        IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? e_(Condition UnilateralMastectomyDiagnosis)
        {
            List<CodeableConcept> j_ = UnilateralMastectomyDiagnosis?.BodySite;
            CqlConcept k_(CodeableConcept @this)
            {
                CqlConcept p_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return p_;
            };
            IEnumerable<CqlConcept> l_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)j_, k_);
            bool? m_(CqlConcept S)
            {
                CqlCode q_ = this.Right__qualifier_value_(context);
                CqlConcept r_ = context.Operators.ConvertCodeToConcept(q_);
                bool? s_ = context.Operators.Equivalent(S, r_);

                return s_;
            };
            IEnumerable<CqlConcept> n_ = context.Operators.Where<CqlConcept>(l_, m_);
            bool? o_ = context.Operators.Exists<CqlConcept>(n_);

            return o_;
        };
        IEnumerable<Condition> f_ = context.Operators.Where<Condition>(d_, e_);
        IEnumerable<Condition> g_ = context.Operators.Union<Condition>(b_, f_);
        bool? h_(Condition RightMastectomy)
        {
            CqlInterval<CqlDateTime> t_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, RightMastectomy);
            CqlDateTime u_ = context.Operators.Start(t_);
            CqlInterval<CqlDateTime> v_ = this.Measurement_Period(context);
            CqlDateTime w_ = context.Operators.End(v_);
            bool? x_ = context.Operators.SameOrBefore(u_, w_, default);

            return x_;
        };
        IEnumerable<Condition> i_ = context.Operators.Where<Condition>(g_, h_);

        return i_;
    }


    [CqlExpressionDefinition("Right Mastectomy Procedure")]
    public IEnumerable<Procedure> Right_Mastectomy_Procedure(CqlContext context)
    {
        CqlValueSet a_ = this.Unilateral_Mastectomy_Right(context);
        IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> c_ = Status_1_8_000.Instance.isProcedurePerformed(context, b_);
        bool? d_(Procedure UnilateralMastectomyRightPerformed)
        {
            DataType f_ = UnilateralMastectomyRightPerformed?.Performed;
            object g_ = FHIRHelpers_4_4_000.Instance.ToValue(context, f_);
            CqlInterval<CqlDateTime> h_ = QICoreCommon_2_1_000.Instance.toInterval(context, g_);
            CqlDateTime i_ = context.Operators.End(h_);
            CqlInterval<CqlDateTime> j_ = this.Measurement_Period(context);
            CqlDateTime k_ = context.Operators.End(j_);
            bool? l_ = context.Operators.SameOrBefore(i_, k_, default);

            return l_;
        };
        IEnumerable<Procedure> e_ = context.Operators.Where<Procedure>(c_, d_);

        return e_;
    }


    [CqlExpressionDefinition("Left Mastectomy Diagnosis")]
    public IEnumerable<Condition> Left_Mastectomy_Diagnosis(CqlContext context)
    {
        CqlValueSet a_ = this.Status_Post_Left_Mastectomy(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet c_ = this.Unilateral_Mastectomy__Unspecified_Laterality(context);
        IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? e_(Condition UnilateralMastectomyDiagnosis)
        {
            List<CodeableConcept> j_ = UnilateralMastectomyDiagnosis?.BodySite;
            CqlConcept k_(CodeableConcept @this)
            {
                CqlConcept p_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return p_;
            };
            IEnumerable<CqlConcept> l_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)j_, k_);
            bool? m_(CqlConcept S)
            {
                CqlCode q_ = this.Left__qualifier_value_(context);
                CqlConcept r_ = context.Operators.ConvertCodeToConcept(q_);
                bool? s_ = context.Operators.Equivalent(S, r_);

                return s_;
            };
            IEnumerable<CqlConcept> n_ = context.Operators.Where<CqlConcept>(l_, m_);
            bool? o_ = context.Operators.Exists<CqlConcept>(n_);

            return o_;
        };
        IEnumerable<Condition> f_ = context.Operators.Where<Condition>(d_, e_);
        IEnumerable<Condition> g_ = context.Operators.Union<Condition>(b_, f_);
        bool? h_(Condition LeftMastectomy)
        {
            CqlInterval<CqlDateTime> t_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, LeftMastectomy);
            CqlDateTime u_ = context.Operators.Start(t_);
            CqlInterval<CqlDateTime> v_ = this.Measurement_Period(context);
            CqlDateTime w_ = context.Operators.End(v_);
            bool? x_ = context.Operators.SameOrBefore(u_, w_, default);

            return x_;
        };
        IEnumerable<Condition> i_ = context.Operators.Where<Condition>(g_, h_);

        return i_;
    }


    [CqlExpressionDefinition("Left Mastectomy Procedure")]
    public IEnumerable<Procedure> Left_Mastectomy_Procedure(CqlContext context)
    {
        CqlValueSet a_ = this.Unilateral_Mastectomy_Left(context);
        IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> c_ = Status_1_8_000.Instance.isProcedurePerformed(context, b_);
        bool? d_(Procedure UnilateralMastectomyLeftPerformed)
        {
            DataType f_ = UnilateralMastectomyLeftPerformed?.Performed;
            object g_ = FHIRHelpers_4_4_000.Instance.ToValue(context, f_);
            CqlInterval<CqlDateTime> h_ = QICoreCommon_2_1_000.Instance.toInterval(context, g_);
            CqlDateTime i_ = context.Operators.End(h_);
            CqlInterval<CqlDateTime> j_ = this.Measurement_Period(context);
            CqlDateTime k_ = context.Operators.End(j_);
            bool? l_ = context.Operators.SameOrBefore(i_, k_, default);

            return l_;
        };
        IEnumerable<Procedure> e_ = context.Operators.Where<Procedure>(c_, d_);

        return e_;
    }


    [CqlExpressionDefinition("Bilateral Mastectomy Diagnosis")]
    public IEnumerable<Condition> Bilateral_Mastectomy_Diagnosis(CqlContext context)
    {
        CqlValueSet a_ = this.History_of_bilateral_mastectomy(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? c_(Condition BilateralMastectomyHistory)
        {
            CqlInterval<CqlDateTime> e_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, BilateralMastectomyHistory);
            CqlDateTime f_ = context.Operators.Start(e_);
            CqlInterval<CqlDateTime> g_ = this.Measurement_Period(context);
            CqlDateTime h_ = context.Operators.End(g_);
            bool? i_ = context.Operators.SameOrBefore(f_, h_, default);

            return i_;
        };
        IEnumerable<Condition> d_ = context.Operators.Where<Condition>(b_, c_);

        return d_;
    }


    [CqlExpressionDefinition("Bilateral Mastectomy Procedure")]
    public IEnumerable<Procedure> Bilateral_Mastectomy_Procedure(CqlContext context)
    {
        CqlValueSet a_ = this.Bilateral_Mastectomy(context);
        IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> c_ = Status_1_8_000.Instance.isProcedurePerformed(context, b_);
        bool? d_(Procedure BilateralMastectomyPerformed)
        {
            DataType f_ = BilateralMastectomyPerformed?.Performed;
            object g_ = FHIRHelpers_4_4_000.Instance.ToValue(context, f_);
            CqlInterval<CqlDateTime> h_ = QICoreCommon_2_1_000.Instance.toInterval(context, g_);
            CqlDateTime i_ = context.Operators.End(h_);
            CqlInterval<CqlDateTime> j_ = this.Measurement_Period(context);
            CqlDateTime k_ = context.Operators.End(j_);
            bool? l_ = context.Operators.SameOrBefore(i_, k_, default);

            return l_;
        };
        IEnumerable<Procedure> e_ = context.Operators.Where<Procedure>(c_, d_);

        return e_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? a_ = Hospice_6_12_000.Instance.Has_Hospice_Services(context);
        IEnumerable<Condition> b_ = this.Right_Mastectomy_Diagnosis(context);
        bool? c_ = context.Operators.Exists<Condition>(b_);
        IEnumerable<Procedure> d_ = this.Right_Mastectomy_Procedure(context);
        bool? e_ = context.Operators.Exists<Procedure>(d_);
        bool? f_ = context.Operators.Or(c_, e_);
        IEnumerable<Condition> g_ = this.Left_Mastectomy_Diagnosis(context);
        bool? h_ = context.Operators.Exists<Condition>(g_);
        IEnumerable<Procedure> i_ = this.Left_Mastectomy_Procedure(context);
        bool? j_ = context.Operators.Exists<Procedure>(i_);
        bool? k_ = context.Operators.Or(h_, j_);
        bool? l_ = context.Operators.And(f_, k_);
        bool? m_ = context.Operators.Or(a_, l_);
        IEnumerable<Condition> n_ = this.Bilateral_Mastectomy_Diagnosis(context);
        bool? o_ = context.Operators.Exists<Condition>(n_);
        bool? p_ = context.Operators.Or(m_, o_);
        IEnumerable<Procedure> q_ = this.Bilateral_Mastectomy_Procedure(context);
        bool? r_ = context.Operators.Exists<Procedure>(q_);
        bool? s_ = context.Operators.Or(p_, r_);
        bool? t_ = AdvancedIllnessandFrailty_1_16_000.Instance.Is_Age_66_or_Older_with_Advanced_Illness_and_Frailty(context);
        bool? u_ = context.Operators.Or(s_, t_);
        bool? v_ = AdvancedIllnessandFrailty_1_16_000.Instance.Is_Age_66_or_Older_Living_Long_Term_in_a_Nursing_Home(context);
        bool? w_ = context.Operators.Or(u_, v_);
        bool? x_ = PalliativeCare_1_11_000.Instance.Has_Palliative_Care_in_the_Measurement_Period(context);
        bool? y_ = context.Operators.Or(w_, x_);

        return y_;
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


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        CqlValueSet a_ = this.Mammography(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> c_ = Status_1_8_000.Instance.isDiagnosticStudyPerformed(context, b_);
        bool? d_(Observation Mammogram)
        {
            DataType g_ = Mammogram?.Effective;
            object h_ = FHIRHelpers_4_4_000.Instance.ToValue(context, g_);
            CqlInterval<CqlDateTime> i_ = QICoreCommon_2_1_000.Instance.toInterval(context, h_);
            CqlDateTime j_ = context.Operators.End(i_);
            CqlDateTime k_ = this.October_1_Two_Years_Prior_to_the_Measurement_Period(context);
            CqlInterval<CqlDateTime> l_ = this.Measurement_Period(context);
            CqlDateTime m_ = context.Operators.End(l_);
            CqlInterval<CqlDateTime> n_ = context.Operators.Interval(k_, m_, true, true);
            bool? o_ = context.Operators.In<CqlDateTime>(j_, n_, "day");

            return o_;
        };
        IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);
        bool? f_ = context.Operators.Exists<Observation>(e_);

        return f_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return a_;
    }


    #endregion Expressions

}
