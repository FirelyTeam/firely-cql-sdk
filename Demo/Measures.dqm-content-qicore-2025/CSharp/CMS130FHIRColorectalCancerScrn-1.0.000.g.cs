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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "4.0.0.0")]
[CqlLibrary("CMS130FHIRColorectalCancerScrn", "1.0.000")]
public partial class CMS130FHIRColorectalCancerScrn_1_0_000 : ILibrary, ISingleton<CMS130FHIRColorectalCancerScrn_1_0_000>
{
    private CMS130FHIRColorectalCancerScrn_1_0_000() {}

    public static CMS130FHIRColorectalCancerScrn_1_0_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "CMS130FHIRColorectalCancerScrn";
    public string Version => "1.0.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, SupplementalDataElements_5_1_000.Instance, Hospice_6_18_000.Instance, PalliativeCare_1_18_000.Instance, AdultOutpatientEncounters_4_19_000.Instance, AdvancedIllnessandFrailty_1_27_000.Instance, Status_1_15_000.Instance, QICoreCommon_4_0_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

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

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        object a_ = context.ResolveParameter("CMS130FHIRColorectalCancerScrn-1.0.000", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)a_;
    }


    #endregion Parameters

    #region Functions and Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

        return b_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);

        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);

        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);

        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);

        return a_;
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
        CqlInterval<int?> i_ = context.Operators.Interval(46, 75, true, true);
        bool? j_ = context.Operators.In<int?>(h_, i_, default);
        IEnumerable<Encounter> k_ = AdultOutpatientEncounters_4_19_000.Instance.Qualifying_Encounters(context);
        bool? l_ = context.Operators.Exists<Encounter>(k_);
        bool? m_ = context.Operators.And(j_, l_);

        return m_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? a_ = this.Initial_Population(context);

        return a_;
    }


    [CqlExpressionDefinition("Malignant Neoplasm")]
    public IEnumerable<object> Malignant_Neoplasm(CqlContext context)
    {
        CqlValueSet a_ = this.Malignant_Neoplasm_of_Colon(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<object> e_ = context.Operators.Union<object>(b_ as IEnumerable<object>, d_ as IEnumerable<object>);
        IEnumerable<object> f_ = Status_1_15_000.Instance.verified(context, e_);
        bool? g_(object ColorectalCancer)
        {
            CqlInterval<CqlDateTime> i_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, ColorectalCancer);
            CqlDateTime j_ = context.Operators.Start(i_);
            CqlInterval<CqlDateTime> k_ = this.Measurement_Period(context);
            CqlDateTime l_ = context.Operators.End(k_);
            bool? m_ = context.Operators.SameOrBefore(j_, l_, "day");

            return m_;
        };
        IEnumerable<object> h_ = context.Operators.Where<object>(f_, g_);

        return h_;
    }


    [CqlExpressionDefinition("Total Colectomy Performed")]
    public IEnumerable<Procedure> Total_Colectomy_Performed(CqlContext context)
    {
        CqlValueSet a_ = this.Total_Colectomy(context);
        IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> c_ = Status_1_15_000.Instance.isProcedurePerformed(context, b_);
        bool? d_(Procedure Colectomy)
        {
            object f_()
            {
                bool l_()
                {
                    DataType p_ = Colectomy?.Performed;
                    object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
                    bool r_ = q_ is CqlDateTime;

                    return r_;
                };
                bool m_()
                {
                    DataType s_ = Colectomy?.Performed;
                    object t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
                    bool u_ = t_ is CqlInterval<CqlDateTime>;

                    return u_;
                };
                bool n_()
                {
                    DataType v_ = Colectomy?.Performed;
                    object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                    bool x_ = w_ is CqlQuantity;

                    return x_;
                };
                bool o_()
                {
                    DataType y_ = Colectomy?.Performed;
                    object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                    bool aa_ = z_ is CqlInterval<CqlQuantity>;

                    return aa_;
                };
                if (l_())
                {
                    DataType ab_ = Colectomy?.Performed;
                    object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);

                    return (ac_ as CqlDateTime) as object;
                }
                else if (m_())
                {
                    DataType ad_ = Colectomy?.Performed;
                    object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);

                    return (ae_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (n_())
                {
                    DataType af_ = Colectomy?.Performed;
                    object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);

                    return (ag_ as CqlQuantity) as object;
                }
                else if (o_())
                {
                    DataType ah_ = Colectomy?.Performed;
                    object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);

                    return (ai_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlInterval<CqlDateTime> g_ = QICoreCommon_4_0_000.Instance.toInterval(context, f_());
            CqlDateTime h_ = context.Operators.End(g_);
            CqlInterval<CqlDateTime> i_ = this.Measurement_Period(context);
            CqlDateTime j_ = context.Operators.End(i_);
            bool? k_ = context.Operators.SameOrBefore(h_, j_, "day");

            return k_;
        };
        IEnumerable<Procedure> e_ = context.Operators.Where<Procedure>(c_, d_);

        return e_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? a_ = Hospice_6_18_000.Instance.Has_Hospice_Services(context);
        IEnumerable<object> b_ = this.Malignant_Neoplasm(context);
        bool? c_ = context.Operators.Exists<object>(b_);
        bool? d_ = context.Operators.Or(a_, c_);
        IEnumerable<Procedure> e_ = this.Total_Colectomy_Performed(context);
        bool? f_ = context.Operators.Exists<Procedure>(e_);
        bool? g_ = context.Operators.Or(d_, f_);
        bool? h_ = AdvancedIllnessandFrailty_1_27_000.Instance.Is_Age_66_or_Older_with_Advanced_Illness_and_Frailty(context);
        bool? i_ = context.Operators.Or(g_, h_);
        bool? j_ = AdvancedIllnessandFrailty_1_27_000.Instance.Is_Age_66_or_Older_Living_Long_Term_in_a_Nursing_Home(context);
        bool? k_ = context.Operators.Or(i_, j_);
        bool? l_ = PalliativeCare_1_18_000.Instance.Has_Palliative_Care_in_the_Measurement_Period(context);
        bool? m_ = context.Operators.Or(k_, l_);

        return m_;
    }


    [CqlExpressionDefinition("Fecal Occult Blood Test Performed")]
    public IEnumerable<Observation> Fecal_Occult_Blood_Test_Performed(CqlContext context)
    {
        CqlValueSet a_ = this.Fecal_Occult_Blood_Test__FOBT_(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));
        IEnumerable<Observation> c_ = Status_1_15_000.Instance.isLaboratoryTestPerformed(context, b_);
        bool? d_(Observation FecalOccultResult)
        {
            DataType f_ = FecalOccultResult?.Value;
            object g_ = FHIRHelpers_4_4_000.Instance.ToValue(context, f_);
            bool? h_ = context.Operators.Not((bool?)(g_ is null));
            object i_()
            {
                bool n_()
                {
                    DataType q_ = FecalOccultResult?.Effective;
                    object r_ = FHIRHelpers_4_4_000.Instance.ToValue(context, q_);
                    bool s_ = r_ is CqlDateTime;

                    return s_;
                };
                bool o_()
                {
                    DataType t_ = FecalOccultResult?.Effective;
                    object u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, t_);
                    bool v_ = u_ is CqlInterval<CqlDateTime>;

                    return v_;
                };
                bool p_()
                {
                    DataType w_ = FecalOccultResult?.Effective;
                    object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                    bool y_ = x_ is CqlDateTime;

                    return y_;
                };
                if (n_())
                {
                    DataType z_ = FecalOccultResult?.Effective;
                    object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);

                    return (aa_ as CqlDateTime) as object;
                }
                else if (o_())
                {
                    DataType ab_ = FecalOccultResult?.Effective;
                    object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);

                    return (ac_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (p_())
                {
                    DataType ad_ = FecalOccultResult?.Effective;
                    object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);

                    return (ae_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime j_ = QICoreCommon_4_0_000.Instance.latest(context, i_());
            CqlInterval<CqlDateTime> k_ = this.Measurement_Period(context);
            bool? l_ = context.Operators.In<CqlDateTime>(j_, k_, "day");
            bool? m_ = context.Operators.And(h_, l_);

            return m_;
        };
        IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);

        return e_;
    }


    [CqlExpressionDefinition("Stool DNA with FIT Test Performed")]
    public IEnumerable<Observation> Stool_DNA_with_FIT_Test_Performed(CqlContext context)
    {
        CqlValueSet a_ = this.sDNA_FIT_Test(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));
        IEnumerable<Observation> c_ = Status_1_15_000.Instance.isLaboratoryTestPerformed(context, b_);
        bool? d_(Observation sDNATest)
        {
            DataType f_ = sDNATest?.Value;
            object g_ = FHIRHelpers_4_4_000.Instance.ToValue(context, f_);
            bool? h_ = context.Operators.Not((bool?)(g_ is null));
            object i_()
            {
                bool t_()
                {
                    DataType w_ = sDNATest?.Effective;
                    object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                    bool y_ = x_ is CqlDateTime;

                    return y_;
                };
                bool u_()
                {
                    DataType z_ = sDNATest?.Effective;
                    object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
                    bool ab_ = aa_ is CqlInterval<CqlDateTime>;

                    return ab_;
                };
                bool v_()
                {
                    DataType ac_ = sDNATest?.Effective;
                    object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                    bool ae_ = ad_ is CqlDateTime;

                    return ae_;
                };
                if (t_())
                {
                    DataType af_ = sDNATest?.Effective;
                    object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);

                    return (ag_ as CqlDateTime) as object;
                }
                else if (u_())
                {
                    DataType ah_ = sDNATest?.Effective;
                    object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);

                    return (ai_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (v_())
                {
                    DataType aj_ = sDNATest?.Effective;
                    object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);

                    return (ak_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime j_ = QICoreCommon_4_0_000.Instance.latest(context, i_());
            CqlInterval<CqlDateTime> k_ = this.Measurement_Period(context);
            CqlDateTime l_ = context.Operators.Start(k_);
            CqlQuantity m_ = context.Operators.Quantity(2m, "years");
            CqlDateTime n_ = context.Operators.Subtract(l_, m_);
            CqlDateTime p_ = context.Operators.End(k_);
            CqlInterval<CqlDateTime> q_ = context.Operators.Interval(n_, p_, true, true);
            bool? r_ = context.Operators.In<CqlDateTime>(j_, q_, "day");
            bool? s_ = context.Operators.And(h_, r_);

            return s_;
        };
        IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);

        return e_;
    }


    [CqlExpressionDefinition("Flexible Sigmoidoscopy Performed")]
    public IEnumerable<Procedure> Flexible_Sigmoidoscopy_Performed(CqlContext context)
    {
        CqlValueSet a_ = this.Flexible_Sigmoidoscopy(context);
        IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> c_ = Status_1_15_000.Instance.isProcedurePerformed(context, b_);
        bool? d_(Procedure FlexibleSigmoidoscopy)
        {
            object f_()
            {
                bool q_()
                {
                    DataType u_ = FlexibleSigmoidoscopy?.Performed;
                    object v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
                    bool w_ = v_ is CqlDateTime;

                    return w_;
                };
                bool r_()
                {
                    DataType x_ = FlexibleSigmoidoscopy?.Performed;
                    object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                    bool z_ = y_ is CqlInterval<CqlDateTime>;

                    return z_;
                };
                bool s_()
                {
                    DataType aa_ = FlexibleSigmoidoscopy?.Performed;
                    object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                    bool ac_ = ab_ is CqlQuantity;

                    return ac_;
                };
                bool t_()
                {
                    DataType ad_ = FlexibleSigmoidoscopy?.Performed;
                    object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                    bool af_ = ae_ is CqlInterval<CqlQuantity>;

                    return af_;
                };
                if (q_())
                {
                    DataType ag_ = FlexibleSigmoidoscopy?.Performed;
                    object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);

                    return (ah_ as CqlDateTime) as object;
                }
                else if (r_())
                {
                    DataType ai_ = FlexibleSigmoidoscopy?.Performed;
                    object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);

                    return (aj_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (s_())
                {
                    DataType ak_ = FlexibleSigmoidoscopy?.Performed;
                    object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);

                    return (al_ as CqlQuantity) as object;
                }
                else if (t_())
                {
                    DataType am_ = FlexibleSigmoidoscopy?.Performed;
                    object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);

                    return (an_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlInterval<CqlDateTime> g_ = QICoreCommon_4_0_000.Instance.toInterval(context, f_());
            CqlDateTime h_ = context.Operators.End(g_);
            CqlInterval<CqlDateTime> i_ = this.Measurement_Period(context);
            CqlDateTime j_ = context.Operators.Start(i_);
            CqlQuantity k_ = context.Operators.Quantity(4m, "years");
            CqlDateTime l_ = context.Operators.Subtract(j_, k_);
            CqlDateTime n_ = context.Operators.End(i_);
            CqlInterval<CqlDateTime> o_ = context.Operators.Interval(l_, n_, true, true);
            bool? p_ = context.Operators.In<CqlDateTime>(h_, o_, "day");

            return p_;
        };
        IEnumerable<Procedure> e_ = context.Operators.Where<Procedure>(c_, d_);

        return e_;
    }


    [CqlExpressionDefinition("CT Colonography Performed")]
    public IEnumerable<Observation> CT_Colonography_Performed(CqlContext context)
    {
        CqlValueSet a_ = this.CT_Colonography(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-clinical-result"));
        IEnumerable<Observation> c_ = Status_1_15_000.Instance.isDiagnosticStudyPerformed(context, b_);
        bool? d_(Observation Colonography)
        {
            DataType f_ = Colonography?.Effective;
            object g_ = FHIRHelpers_4_4_000.Instance.ToValue(context, f_);
            CqlInterval<CqlDateTime> h_ = QICoreCommon_4_0_000.Instance.toInterval(context, g_);
            CqlDateTime i_ = context.Operators.End(h_);
            CqlInterval<CqlDateTime> j_ = this.Measurement_Period(context);
            CqlDateTime k_ = context.Operators.Start(j_);
            CqlQuantity l_ = context.Operators.Quantity(4m, "years");
            CqlDateTime m_ = context.Operators.Subtract(k_, l_);
            CqlDateTime o_ = context.Operators.End(j_);
            CqlInterval<CqlDateTime> p_ = context.Operators.Interval(m_, o_, true, true);
            bool? q_ = context.Operators.In<CqlDateTime>(i_, p_, "day");

            return q_;
        };
        IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);

        return e_;
    }


    [CqlExpressionDefinition("Colonoscopy Performed")]
    public IEnumerable<Procedure> Colonoscopy_Performed(CqlContext context)
    {
        CqlValueSet a_ = this.Colonoscopy(context);
        IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> c_ = Status_1_15_000.Instance.isProcedurePerformed(context, b_);
        bool? d_(Procedure ColonoscopyProcedure)
        {
            object f_()
            {
                bool q_()
                {
                    DataType u_ = ColonoscopyProcedure?.Performed;
                    object v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
                    bool w_ = v_ is CqlDateTime;

                    return w_;
                };
                bool r_()
                {
                    DataType x_ = ColonoscopyProcedure?.Performed;
                    object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                    bool z_ = y_ is CqlInterval<CqlDateTime>;

                    return z_;
                };
                bool s_()
                {
                    DataType aa_ = ColonoscopyProcedure?.Performed;
                    object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                    bool ac_ = ab_ is CqlQuantity;

                    return ac_;
                };
                bool t_()
                {
                    DataType ad_ = ColonoscopyProcedure?.Performed;
                    object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                    bool af_ = ae_ is CqlInterval<CqlQuantity>;

                    return af_;
                };
                if (q_())
                {
                    DataType ag_ = ColonoscopyProcedure?.Performed;
                    object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);

                    return (ah_ as CqlDateTime) as object;
                }
                else if (r_())
                {
                    DataType ai_ = ColonoscopyProcedure?.Performed;
                    object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);

                    return (aj_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (s_())
                {
                    DataType ak_ = ColonoscopyProcedure?.Performed;
                    object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);

                    return (al_ as CqlQuantity) as object;
                }
                else if (t_())
                {
                    DataType am_ = ColonoscopyProcedure?.Performed;
                    object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);

                    return (an_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlInterval<CqlDateTime> g_ = QICoreCommon_4_0_000.Instance.toInterval(context, f_());
            CqlDateTime h_ = context.Operators.End(g_);
            CqlInterval<CqlDateTime> i_ = this.Measurement_Period(context);
            CqlDateTime j_ = context.Operators.Start(i_);
            CqlQuantity k_ = context.Operators.Quantity(9m, "years");
            CqlDateTime l_ = context.Operators.Subtract(j_, k_);
            CqlDateTime n_ = context.Operators.End(i_);
            CqlInterval<CqlDateTime> o_ = context.Operators.Interval(l_, n_, true, true);
            bool? p_ = context.Operators.In<CqlDateTime>(h_, o_, "day");

            return p_;
        };
        IEnumerable<Procedure> e_ = context.Operators.Where<Procedure>(c_, d_);

        return e_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        IEnumerable<Observation> a_ = this.Fecal_Occult_Blood_Test_Performed(context);
        bool? b_ = context.Operators.Exists<Observation>(a_);
        IEnumerable<Observation> c_ = this.Stool_DNA_with_FIT_Test_Performed(context);
        bool? d_ = context.Operators.Exists<Observation>(c_);
        bool? e_ = context.Operators.Or(b_, d_);
        IEnumerable<Procedure> f_ = this.Flexible_Sigmoidoscopy_Performed(context);
        bool? g_ = context.Operators.Exists<Procedure>(f_);
        bool? h_ = context.Operators.Or(e_, g_);
        IEnumerable<Observation> i_ = this.CT_Colonography_Performed(context);
        bool? j_ = context.Operators.Exists<Observation>(i_);
        bool? k_ = context.Operators.Or(h_, j_);
        IEnumerable<Procedure> l_ = this.Colonoscopy_Performed(context);
        bool? m_ = context.Operators.Exists<Procedure>(l_);
        bool? n_ = context.Operators.Or(k_, m_);

        return n_;
    }


    [CqlExpressionDefinition("Stratification 1")]
    public bool? Stratification_1(CqlContext context)
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
        bool? j_ = context.Operators.In<int?>(h_, i_, default);

        return j_;
    }


    [CqlExpressionDefinition("Stratification 2")]
    public bool? Stratification_2(CqlContext context)
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
        bool? j_ = context.Operators.In<int?>(h_, i_, default);

        return j_;
    }


    #endregion Functions and Expressions

}
