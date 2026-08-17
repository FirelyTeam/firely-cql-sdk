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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.3.0.0")]
[CqlLibrary("CMS130FHIRColorectalCancerScrn", "1.0.000")]
public partial class CMS130FHIRColorectalCancerScrn_1_0_000 : ILibrary, ISingleton<CMS130FHIRColorectalCancerScrn_1_0_000>
{
    #region ValueSets (7)

    [CqlValueSetDefinition("Colonoscopy", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1020", valueSetVersion: null)]
    public CqlValueSet Colonoscopy(CqlContext _) => _Colonoscopy;
    private static readonly CqlValueSet _Colonoscopy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1020", null);

    [CqlValueSetDefinition("CT Colonography", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1038", valueSetVersion: null)]
    public CqlValueSet CT_Colonography(CqlContext _) => _CT_Colonography;
    private static readonly CqlValueSet _CT_Colonography = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1038", null);

    [CqlValueSetDefinition("Fecal Occult Blood Test (FOBT)", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1011", valueSetVersion: null)]
    public CqlValueSet Fecal_Occult_Blood_Test__FOBT_(CqlContext _) => _Fecal_Occult_Blood_Test__FOBT_;
    private static readonly CqlValueSet _Fecal_Occult_Blood_Test__FOBT_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1011", null);

    [CqlValueSetDefinition("sDNA FIT Test", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1039", valueSetVersion: null)]
    public CqlValueSet sDNA_FIT_Test(CqlContext _) => _sDNA_FIT_Test;
    private static readonly CqlValueSet _sDNA_FIT_Test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1039", null);

    [CqlValueSetDefinition("Flexible Sigmoidoscopy", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1010", valueSetVersion: null)]
    public CqlValueSet Flexible_Sigmoidoscopy(CqlContext _) => _Flexible_Sigmoidoscopy;
    private static readonly CqlValueSet _Flexible_Sigmoidoscopy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1010", null);

    [CqlValueSetDefinition("Malignant Neoplasm of Colon", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1001", valueSetVersion: null)]
    public CqlValueSet Malignant_Neoplasm_of_Colon(CqlContext _) => _Malignant_Neoplasm_of_Colon;
    private static readonly CqlValueSet _Malignant_Neoplasm_of_Colon = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1001", null);

    [CqlValueSetDefinition("Total Colectomy", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1019", valueSetVersion: null)]
    public CqlValueSet Total_Colectomy(CqlContext _) => _Total_Colectomy;
    private static readonly CqlValueSet _Total_Colectomy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1019", null);

    #endregion ValueSets

    #region Parameters (1)

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute);

    private const long _cacheIndex_Measurement_Period = 8727962915329166310L;

    private CqlInterval<CqlDateTime> Measurement_Period_Compute(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime b_ = context.Operators.DateTime(2027, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
        object d_ = context.ResolveParameter("CMS130FHIRColorectalCancerScrn-1.0.000", "Measurement Period", c_);
        return (CqlInterval<CqlDateTime>)d_;
    }


    #endregion Parameters

    #region Functions and Expressions (18)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = -5698627232654440380L;

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Ethnicity, SDE_Ethnicity_Compute);

    private const long _cacheIndex_SDE_Ethnicity = 1618786243604187050L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Payer, SDE_Payer_Compute);

    private const long _cacheIndex_SDE_Payer = 1608958109846461859L;

    private IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Race, SDE_Race_Compute);

    private const long _cacheIndex_SDE_Race = 1178978355528948591L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Sex, SDE_Sex_Compute);

    private const long _cacheIndex_SDE_Sex = -9223078807715422392L;

    private CqlCode SDE_Sex_Compute(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
        return a_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Initial_Population, Initial_Population_Compute);

    private const long _cacheIndex_Initial_Population = 3286266884843916874L;

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
        CqlInterval<int?> i_ = context.Operators.Interval(46, 75, true, true);
        bool? j_ = context.Operators.In<int?>(h_, i_, (string)default);
        // CQL 'and' (40:3-43:64): right operand skipped when left is false
        if (j_ is false)
        {
            return false;
        }
        else
        {
            IEnumerable<Encounter> k_ = AdultOutpatientEncounters_4_19_000.Instance.Qualifying_Encounters(context);
            bool? l_ = context.Operators.Exists<Encounter>(k_);
            return j_ & l_;
        }
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator, Denominator_Compute);

    private const long _cacheIndex_Denominator = 6295342635779330828L;

    private bool? Denominator_Compute(CqlContext context)
    {
        bool? a_ = this.Initial_Population(context);
        return a_;
    }


    [CqlExpressionDefinition("Malignant Neoplasm")]
    public IEnumerable<Condition> Malignant_Neoplasm(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Malignant_Neoplasm, Malignant_Neoplasm_Compute);

    private const long _cacheIndex_Malignant_Neoplasm = 584573600949950176L;

    private IEnumerable<Condition> Malignant_Neoplasm_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Malignant_Neoplasm_of_Colon(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> d_ = context.Operators.Union<Condition>(b_ as IEnumerable<Condition>, c_ as IEnumerable<Condition>);
        IEnumerable<Condition> e_ = Status_1_15_000.Instance.verified(context, d_);

        bool? f_(Condition ColorectalCancer) {
            CqlInterval<CqlDateTime> h_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, ColorectalCancer);
            CqlDateTime i_ = context.Operators.Start(h_);
            CqlInterval<CqlDateTime> j_ = this.Measurement_Period(context);
            CqlDateTime k_ = context.Operators.End(j_);
            bool? l_ = context.Operators.SameOrBefore(i_, k_, "day");
            return l_;
        }

        IEnumerable<Condition> g_ = context.Operators.Where<Condition>(e_, f_);
        return g_;
    }


    [CqlExpressionDefinition("Total Colectomy Performed")]
    public IEnumerable<Procedure> Total_Colectomy_Performed(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Total_Colectomy_Performed, Total_Colectomy_Performed_Compute);

    private const long _cacheIndex_Total_Colectomy_Performed = 8942615805545728627L;

    private IEnumerable<Procedure> Total_Colectomy_Performed_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Total_Colectomy(context);
        IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> c_ = Status_1_15_000.Instance.isProcedurePerformed(context, b_);

        bool? d_(Procedure Colectomy) {
            object f_;
            DataType l_ = Colectomy?.Performed;
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
            bool? k_ = context.Operators.SameOrBefore(h_, j_, "day");
            return k_;
        }

        IEnumerable<Procedure> e_ = context.Operators.Where<Procedure>(c_, d_);
        return e_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator_Exclusions, Denominator_Exclusions_Compute);

    private const long _cacheIndex_Denominator_Exclusions = 2426540308912967925L;

    private bool? Denominator_Exclusions_Compute(CqlContext context)
    {
        bool? a_ = Hospice_6_18_000.Instance.Has_Hospice_Services(context);
        bool? b_;
        // CQL 'or' (49:3-50:34): right operand skipped when left is true
        if (a_ is true)
        {
            b_ = true;
        }
        else
        {
            IEnumerable<Condition> f_ = this.Malignant_Neoplasm(context);
            bool? g_ = context.Operators.Exists<Condition>(f_);
            b_ = a_ | g_;
        }
        bool? c_;
        // CQL 'or' (49:3-51:41): right operand skipped when left is true
        if (b_ is true)
        {
            c_ = true;
        }
        else
        {
            IEnumerable<Procedure> h_ = this.Total_Colectomy_Performed(context);
            bool? i_ = context.Operators.Exists<Procedure>(h_);
            c_ = b_ | i_;
        }
        bool? d_;
        // CQL 'or' (49:3-52:73): right operand skipped when left is true
        if (c_ is true)
        {
            d_ = true;
        }
        else
        {
            bool? j_ = AdvancedIllnessandFrailty_1_27_000.Instance.Is_Age_66_or_Older_with_Advanced_Illness_and_Frailty(context);
            d_ = c_ | j_;
        }
        bool? e_;
        // CQL 'or' (49:3-53:74): right operand skipped when left is true
        if (d_ is true)
        {
            e_ = true;
        }
        else
        {
            bool? k_ = AdvancedIllnessandFrailty_1_27_000.Instance.Is_Age_66_or_Older_Living_Long_Term_in_a_Nursing_Home(context);
            e_ = d_ | k_;
        }
        // CQL 'or' (49:3-54:69): right operand skipped when left is true
        if (e_ is true)
        {
            return true;
        }
        else
        {
            bool? l_ = PalliativeCare_1_18_000.Instance.Has_Palliative_Care_in_the_Measurement_Period(context);
            return e_ | l_;
        }
    }


    [CqlExpressionDefinition("Fecal Occult Blood Test Performed")]
    public IEnumerable<Observation> Fecal_Occult_Blood_Test_Performed(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Fecal_Occult_Blood_Test_Performed, Fecal_Occult_Blood_Test_Performed_Compute);

    private const long _cacheIndex_Fecal_Occult_Blood_Test_Performed = -8973331652132369237L;

    private IEnumerable<Observation> Fecal_Occult_Blood_Test_Performed_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Fecal_Occult_Blood_Test__FOBT_(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));
        IEnumerable<Observation> c_ = Status_1_15_000.Instance.isLaboratoryTestPerformed(context, b_);

        bool? d_(Observation FecalOccultResult) {
            DataType f_ = FecalOccultResult?.Value;
            object g_ = FHIRHelpers_4_4_000.Instance.ToValue(context, f_);
            bool? h_ = !((bool?)(g_ is null));
            // CQL 'and' (65:5-66:83): right operand skipped when left is false
            if (h_ is false)
            {
                return false;
            }
            else
            {
                object i_;
                DataType m_ = FecalOccultResult?.Effective;
                object n_ = FHIRHelpers_4_4_000.Instance.ToValue(context, m_);
                bool o_ = n_ is CqlDateTime;
                if (o_)
                {
                    i_ = n_ as CqlDateTime;
                }
                else
                {
                    if (o_)
                    {
                        i_ = n_ as CqlDateTime;
                    }
                    else
                    {
                        bool p_ = n_ is CqlInterval<CqlDateTime>;
                        if (p_)
                        {
                            i_ = n_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            i_ = null;
                        }
                    }
                }
                CqlDateTime j_ = QICoreCommon_4_0_000.Instance.latest(context, i_);
                CqlInterval<CqlDateTime> k_ = this.Measurement_Period(context);
                bool? l_ = context.Operators.In<CqlDateTime>(j_, k_, "day");
                return h_ & l_;
            }
        }

        IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);
        return e_;
    }


    [CqlExpressionDefinition("Stool DNA with FIT Test Performed")]
    public IEnumerable<Observation> Stool_DNA_with_FIT_Test_Performed(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Stool_DNA_with_FIT_Test_Performed, Stool_DNA_with_FIT_Test_Performed_Compute);

    private const long _cacheIndex_Stool_DNA_with_FIT_Test_Performed = 7135797916654997859L;

    private IEnumerable<Observation> Stool_DNA_with_FIT_Test_Performed_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.sDNA_FIT_Test(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));
        IEnumerable<Observation> c_ = Status_1_15_000.Instance.isLaboratoryTestPerformed(context, b_);

        bool? d_(Observation sDNATest) {
            DataType f_ = sDNATest?.Value;
            object g_ = FHIRHelpers_4_4_000.Instance.ToValue(context, f_);
            bool? h_ = !((bool?)(g_ is null));
            // CQL 'and' (102:5-103:132): right operand skipped when left is false
            if (h_ is false)
            {
                return false;
            }
            else
            {
                object i_;
                DataType r_ = sDNATest?.Effective;
                object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
                bool t_ = s_ is CqlDateTime;
                if (t_)
                {
                    i_ = s_ as CqlDateTime;
                }
                else
                {
                    if (t_)
                    {
                        i_ = s_ as CqlDateTime;
                    }
                    else
                    {
                        bool u_ = s_ is CqlInterval<CqlDateTime>;
                        if (u_)
                        {
                            i_ = s_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            i_ = null;
                        }
                    }
                }
                CqlDateTime j_ = QICoreCommon_4_0_000.Instance.latest(context, i_);
                CqlInterval<CqlDateTime> k_ = this.Measurement_Period(context);
                CqlDateTime l_ = context.Operators.Start(k_);
                CqlQuantity m_ = context.Operators.Quantity(2m, "years");
                CqlDateTime n_ = context.Operators.Subtract(l_, m_);
                CqlDateTime o_ = context.Operators.End(k_);
                CqlInterval<CqlDateTime> p_ = context.Operators.Interval(n_, o_, true, true);
                bool? q_ = context.Operators.In<CqlDateTime>(j_, p_, "day");
                return h_ & q_;
            }
        }

        IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);
        return e_;
    }


    [CqlExpressionDefinition("Flexible Sigmoidoscopy Performed")]
    public IEnumerable<Procedure> Flexible_Sigmoidoscopy_Performed(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Flexible_Sigmoidoscopy_Performed, Flexible_Sigmoidoscopy_Performed_Compute);

    private const long _cacheIndex_Flexible_Sigmoidoscopy_Performed = -3126305953337278587L;

    private IEnumerable<Procedure> Flexible_Sigmoidoscopy_Performed_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Flexible_Sigmoidoscopy(context);
        IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> c_ = Status_1_15_000.Instance.isProcedurePerformed(context, b_);

        bool? d_(Procedure FlexibleSigmoidoscopy) {
            object f_;
            DataType p_ = FlexibleSigmoidoscopy?.Performed;
            object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
            bool r_ = q_ is CqlDateTime;
            if (r_)
            {
                f_ = q_ as CqlDateTime;
            }
            else
            {
                bool s_ = q_ is CqlQuantity;
                if (s_)
                {
                    f_ = q_ as CqlQuantity;
                }
                else
                {
                    bool t_ = q_ is CqlInterval<CqlDateTime>;
                    if (t_)
                    {
                        f_ = q_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bool u_ = q_ is CqlInterval<CqlQuantity>;
                        if (u_)
                        {
                            f_ = q_ as CqlInterval<CqlQuantity>;
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
            CqlDateTime j_ = context.Operators.Start(i_);
            CqlQuantity k_ = context.Operators.Quantity(4m, "years");
            CqlDateTime l_ = context.Operators.Subtract(j_, k_);
            CqlDateTime m_ = context.Operators.End(i_);
            CqlInterval<CqlDateTime> n_ = context.Operators.Interval(l_, m_, true, true);
            bool? o_ = context.Operators.In<CqlDateTime>(h_, n_, "day");
            return o_;
        }

        IEnumerable<Procedure> e_ = context.Operators.Where<Procedure>(c_, d_);
        return e_;
    }


    [CqlExpressionDefinition("CT Colonography Performed")]
    public IEnumerable<Observation> CT_Colonography_Performed(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_CT_Colonography_Performed, CT_Colonography_Performed_Compute);

    private const long _cacheIndex_CT_Colonography_Performed = 6875238329079171871L;

    private IEnumerable<Observation> CT_Colonography_Performed_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.CT_Colonography(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-clinical-result"));
        IEnumerable<Observation> c_ = Status_1_15_000.Instance.isDiagnosticStudyPerformed(context, b_);

        bool? d_(Observation Colonography) {
            DataType f_ = Colonography?.Effective;
            object g_ = FHIRHelpers_4_4_000.Instance.ToValue(context, f_);
            CqlInterval<CqlDateTime> h_ = QICoreCommon_4_0_000.Instance.toInterval(context, g_);
            CqlDateTime i_ = context.Operators.End(h_);
            CqlInterval<CqlDateTime> j_ = this.Measurement_Period(context);
            CqlDateTime k_ = context.Operators.Start(j_);
            CqlQuantity l_ = context.Operators.Quantity(4m, "years");
            CqlDateTime m_ = context.Operators.Subtract(k_, l_);
            CqlDateTime n_ = context.Operators.End(j_);
            CqlInterval<CqlDateTime> o_ = context.Operators.Interval(m_, n_, true, true);
            bool? p_ = context.Operators.In<CqlDateTime>(i_, o_, "day");
            return p_;
        }

        IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);
        return e_;
    }


    [CqlExpressionDefinition("Colonoscopy Performed")]
    public IEnumerable<Procedure> Colonoscopy_Performed(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Colonoscopy_Performed, Colonoscopy_Performed_Compute);

    private const long _cacheIndex_Colonoscopy_Performed = -2586072086965485321L;

    private IEnumerable<Procedure> Colonoscopy_Performed_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Colonoscopy(context);
        IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> c_ = Status_1_15_000.Instance.isProcedurePerformed(context, b_);

        bool? d_(Procedure ColonoscopyProcedure) {
            object f_;
            DataType p_ = ColonoscopyProcedure?.Performed;
            object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
            bool r_ = q_ is CqlDateTime;
            if (r_)
            {
                f_ = q_ as CqlDateTime;
            }
            else
            {
                bool s_ = q_ is CqlQuantity;
                if (s_)
                {
                    f_ = q_ as CqlQuantity;
                }
                else
                {
                    bool t_ = q_ is CqlInterval<CqlDateTime>;
                    if (t_)
                    {
                        f_ = q_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bool u_ = q_ is CqlInterval<CqlQuantity>;
                        if (u_)
                        {
                            f_ = q_ as CqlInterval<CqlQuantity>;
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
            CqlDateTime j_ = context.Operators.Start(i_);
            CqlQuantity k_ = context.Operators.Quantity(9m, "years");
            CqlDateTime l_ = context.Operators.Subtract(j_, k_);
            CqlDateTime m_ = context.Operators.End(i_);
            CqlInterval<CqlDateTime> n_ = context.Operators.Interval(l_, m_, true, true);
            bool? o_ = context.Operators.In<CqlDateTime>(h_, n_, "day");
            return o_;
        }

        IEnumerable<Procedure> e_ = context.Operators.Where<Procedure>(c_, d_);
        return e_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Numerator, Numerator_Compute);

    private const long _cacheIndex_Numerator = 1933575117686421266L;

    private bool? Numerator_Compute(CqlContext context)
    {
        IEnumerable<Observation> a_ = this.Fecal_Occult_Blood_Test_Performed(context);
        bool? b_ = context.Operators.Exists<Observation>(a_);
        bool? c_;
        // CQL 'or' (57:3-58:49): right operand skipped when left is true
        if (b_ is true)
        {
            c_ = true;
        }
        else
        {
            IEnumerable<Observation> f_ = this.Stool_DNA_with_FIT_Test_Performed(context);
            bool? g_ = context.Operators.Exists<Observation>(f_);
            c_ = b_ | g_;
        }
        bool? d_;
        // CQL 'or' (57:3-59:48): right operand skipped when left is true
        if (c_ is true)
        {
            d_ = true;
        }
        else
        {
            IEnumerable<Procedure> h_ = this.Flexible_Sigmoidoscopy_Performed(context);
            bool? i_ = context.Operators.Exists<Procedure>(h_);
            d_ = c_ | i_;
        }
        bool? e_;
        // CQL 'or' (57:3-60:41): right operand skipped when left is true
        if (d_ is true)
        {
            e_ = true;
        }
        else
        {
            IEnumerable<Observation> j_ = this.CT_Colonography_Performed(context);
            bool? k_ = context.Operators.Exists<Observation>(j_);
            e_ = d_ | k_;
        }
        // CQL 'or' (57:3-61:37): right operand skipped when left is true
        if (e_ is true)
        {
            return true;
        }
        else
        {
            IEnumerable<Procedure> l_ = this.Colonoscopy_Performed(context);
            bool? m_ = context.Operators.Exists<Procedure>(l_);
            return e_ | m_;
        }
    }


    [CqlExpressionDefinition("Stratification 1")]
    public bool? Stratification_1(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Stratification_1, Stratification_1_Compute);

    private const long _cacheIndex_Stratification_1 = -3902511774949246515L;

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
        CqlInterval<int?> i_ = context.Operators.Interval(46, 49, true, true);
        bool? j_ = context.Operators.In<int?>(h_, i_, (string)default);
        return j_;
    }


    [CqlExpressionDefinition("Stratification 2")]
    public bool? Stratification_2(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Stratification_2, Stratification_2_Compute);

    private const long _cacheIndex_Stratification_2 = -711583634882941276L;

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
        CqlInterval<int?> i_ = context.Operators.Interval(50, 75, true, true);
        bool? j_ = context.Operators.In<int?>(h_, i_, (string)default);
        return j_;
    }


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private CMS130FHIRColorectalCancerScrn_1_0_000() {}

    public static CMS130FHIRColorectalCancerScrn_1_0_000 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "CMS130FHIRColorectalCancerScrn";
    public string Version => "1.0.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, SupplementalDataElements_5_1_000.Instance, Hospice_6_18_000.Instance, PalliativeCare_1_18_000.Instance, AdultOutpatientEncounters_4_19_000.Instance, AdvancedIllnessandFrailty_1_27_000.Instance, Status_1_15_000.Instance, QICoreCommon_4_0_000.Instance];

    #endregion ILibrary Implementation

}
