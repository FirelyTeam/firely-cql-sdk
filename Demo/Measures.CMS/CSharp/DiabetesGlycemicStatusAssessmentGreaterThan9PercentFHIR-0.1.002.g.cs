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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.8.0")]
[CqlLibrary("DiabetesGlycemicStatusAssessmentGreaterThan9PercentFHIR", "0.1.002")]
public partial class DiabetesGlycemicStatusAssessmentGreaterThan9PercentFHIR_0_1_002 : ILibrary, ISingleton<DiabetesGlycemicStatusAssessmentGreaterThan9PercentFHIR_0_1_002>
{
    private DiabetesGlycemicStatusAssessmentGreaterThan9PercentFHIR_0_1_002() {}

    public static DiabetesGlycemicStatusAssessmentGreaterThan9PercentFHIR_0_1_002 Instance { get; } = new();

    #region Library Members
    public string Name => "DiabetesGlycemicStatusAssessmentGreaterThan9PercentFHIR";
    public string Version => "0.1.002";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, QICoreCommon_2_1_000.Instance, SupplementalDataElements_3_5_000.Instance, Status_1_8_000.Instance, CumulativeMedicationDuration_4_1_000.Instance, AdultOutpatientEncounters_4_11_000.Instance, AdvancedIllnessandFrailty_1_16_000.Instance, Hospice_6_12_000.Instance, PalliativeCare_1_11_000.Instance];
    #endregion Library Members

    [CqlDeclaration("Diabetes")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.103.12.1001")]
    public CqlValueSet Diabetes(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.103.12.1001", default);


    [CqlDeclaration("HbA1c Laboratory Test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1013")]
    public CqlValueSet HbA1c_Laboratory_Test(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1013", default);


    [CqlDeclaration("Glucose management indicator")]
    public CqlCode Glucose_management_indicator(CqlContext context) => 
        new CqlCode("97506-0", "http://loinc.org", default, default);


    [CqlDeclaration("LOINC")]
    public CqlCode[] LOINC(CqlContext context)
    {
        CqlCode[] a_ = [
            new CqlCode("97506-0", "http://loinc.org", default, default),
        ];

        return a_;
    }


    [CqlDeclaration("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime b_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, true);
        object d_ = context.ResolveParameter("DiabetesGlycemicStatusAssessmentGreaterThan9PercentFHIR-0.1.002", "Measurement Period", c_);

        return (CqlInterval<CqlDateTime>)d_;
    }


    [CqlDeclaration("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

        return b_;
    }


    [CqlDeclaration("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return a_;
    }


    [CqlDeclaration("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return a_;
    }


    [CqlDeclaration("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return a_;
    }


    [CqlDeclaration("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return a_;
    }


    [CqlDeclaration("Initial Population")]
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
        CqlInterval<int?> i_ = context.Operators.Interval(18, 75, true, true);
        bool? j_ = context.Operators.In<int?>(h_, i_, default);
        IEnumerable<Encounter> k_ = AdultOutpatientEncounters_4_11_000.Instance.Qualifying_Encounters(context);
        bool? l_ = context.Operators.Exists<Encounter>(k_);
        bool? m_ = context.Operators.And(j_, l_);
        CqlValueSet n_ = this.Diabetes(context);
        IEnumerable<Condition> o_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, n_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? p_(Condition Diabetes)
        {
            CqlInterval<CqlDateTime> t_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, Diabetes);
            CqlInterval<CqlDateTime> u_ = this.Measurement_Period(context);
            bool? v_ = context.Operators.Overlaps(t_, u_, "day");

            return v_;
        };
        IEnumerable<Condition> q_ = context.Operators.Where<Condition>(o_, p_);
        bool? r_ = context.Operators.Exists<Condition>(q_);
        bool? s_ = context.Operators.And(m_, r_);

        return s_;
    }


    [CqlDeclaration("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? a_ = this.Initial_Population(context);

        return a_;
    }


    [CqlDeclaration("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? a_ = Hospice_6_12_000.Instance.Has_Hospice_Services(context);
        bool? b_ = AdvancedIllnessandFrailty_1_16_000.Instance.Is_Age_66_or_Older_Living_Long_Term_in_a_Nursing_Home(context);
        bool? c_ = context.Operators.Or(a_, b_);
        bool? d_ = AdvancedIllnessandFrailty_1_16_000.Instance.Is_Age_66_or_Older_with_Advanced_Illness_and_Frailty(context);
        bool? e_ = context.Operators.Or(c_, d_);
        bool? f_ = PalliativeCare_1_11_000.Instance.Has_Palliative_Care_in_the_Measurement_Period(context);
        bool? g_ = context.Operators.Or(e_, f_);

        return g_;
    }


    [CqlDeclaration("Glycemic Status Assessment")]
    public IEnumerable<Observation> Glycemic_Status_Assessment(CqlContext context)
    {
        CqlValueSet a_ = this.HbA1c_Laboratory_Test(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        CqlCode c_ = this.Glucose_management_indicator(context);
        IEnumerable<CqlCode> d_ = context.Operators.ToList<CqlCode>(c_);
        IEnumerable<Observation> e_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, d_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> f_ = context.Operators.Union<Observation>(b_, e_);
        IEnumerable<Observation> g_ = Status_1_8_000.Instance.isLaboratoryTestPerformed(context, f_);
        bool? h_(Observation GlycemicStatus)
        {
            object j_()
            {
                bool n_()
                {
                    DataType q_ = GlycemicStatus?.Effective;
                    object r_ = FHIRHelpers_4_4_000.Instance.ToValue(context, q_);
                    bool s_ = r_ is CqlDateTime;

                    return s_;
                };
                bool o_()
                {
                    DataType t_ = GlycemicStatus?.Effective;
                    object u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, t_);
                    bool v_ = u_ is CqlInterval<CqlDateTime>;

                    return v_;
                };
                bool p_()
                {
                    DataType w_ = GlycemicStatus?.Effective;
                    object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                    bool y_ = x_ is CqlDateTime;

                    return y_;
                };
                if (n_())
                {
                    DataType z_ = GlycemicStatus?.Effective;
                    object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);

                    return (aa_ as CqlDateTime) as object;
                }
                else if (o_())
                {
                    DataType ab_ = GlycemicStatus?.Effective;
                    object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);

                    return (ac_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (p_())
                {
                    DataType ad_ = GlycemicStatus?.Effective;
                    object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);

                    return (ae_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime k_ = QICoreCommon_2_1_000.Instance.latest(context, j_());
            CqlInterval<CqlDateTime> l_ = this.Measurement_Period(context);
            bool? m_ = context.Operators.In<CqlDateTime>(k_, l_, "day");

            return m_;
        };
        IEnumerable<Observation> i_ = context.Operators.Where<Observation>(g_, h_);

        return i_;
    }


    [CqlDeclaration("Most Recent Glycemic Status Date")]
    public CqlDate Most_Recent_Glycemic_Status_Date(CqlContext context)
    {
        IEnumerable<Observation> a_ = this.Glycemic_Status_Assessment(context);
        CqlDate b_(Observation QualifyingGlycemicStatus)
        {
            object g_()
            {
                bool j_()
                {
                    DataType m_ = QualifyingGlycemicStatus?.Effective;
                    object n_ = FHIRHelpers_4_4_000.Instance.ToValue(context, m_);
                    bool o_ = n_ is CqlDateTime;

                    return o_;
                };
                bool k_()
                {
                    DataType p_ = QualifyingGlycemicStatus?.Effective;
                    object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
                    bool r_ = q_ is CqlInterval<CqlDateTime>;

                    return r_;
                };
                bool l_()
                {
                    DataType s_ = QualifyingGlycemicStatus?.Effective;
                    object t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
                    bool u_ = t_ is CqlDateTime;

                    return u_;
                };
                if (j_())
                {
                    DataType v_ = QualifyingGlycemicStatus?.Effective;
                    object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);

                    return (w_ as CqlDateTime) as object;
                }
                else if (k_())
                {
                    DataType x_ = QualifyingGlycemicStatus?.Effective;
                    object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);

                    return (y_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (l_())
                {
                    DataType z_ = QualifyingGlycemicStatus?.Effective;
                    object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);

                    return (aa_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime h_ = QICoreCommon_2_1_000.Instance.latest(context, g_());
            CqlDate i_ = context.Operators.DateFrom(h_);

            return i_;
        };
        IEnumerable<CqlDate> c_ = context.Operators.Select<Observation, CqlDate>(a_, b_);
        IEnumerable<CqlDate> d_ = context.Operators.Distinct<CqlDate>(c_);
        IEnumerable<CqlDate> e_ = context.Operators.ListSort<CqlDate>(d_, System.ComponentModel.ListSortDirection.Ascending);
        CqlDate f_ = context.Operators.Last<CqlDate>(e_);

        return f_;
    }


    [CqlDeclaration("Lowest Glycemic Status Assessment Reading on Most Recent Day")]
    public Observation Lowest_Glycemic_Status_Assessment_Reading_on_Most_Recent_Day(CqlContext context)
    {
        IEnumerable<Observation> a_ = this.Glycemic_Status_Assessment(context);
        bool? b_(Observation QualifyingGlycemicStatus)
        {
            object k_()
            {
                bool p_()
                {
                    DataType s_ = QualifyingGlycemicStatus?.Effective;
                    object t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
                    bool u_ = t_ is CqlDateTime;

                    return u_;
                };
                bool q_()
                {
                    DataType v_ = QualifyingGlycemicStatus?.Effective;
                    object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                    bool x_ = w_ is CqlInterval<CqlDateTime>;

                    return x_;
                };
                bool r_()
                {
                    DataType y_ = QualifyingGlycemicStatus?.Effective;
                    object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                    bool aa_ = z_ is CqlDateTime;

                    return aa_;
                };
                if (p_())
                {
                    DataType ab_ = QualifyingGlycemicStatus?.Effective;
                    object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);

                    return (ac_ as CqlDateTime) as object;
                }
                else if (q_())
                {
                    DataType ad_ = QualifyingGlycemicStatus?.Effective;
                    object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);

                    return (ae_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (r_())
                {
                    DataType af_ = QualifyingGlycemicStatus?.Effective;
                    object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);

                    return (ag_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime l_ = QICoreCommon_2_1_000.Instance.latest(context, k_());
            CqlDate m_ = this.Most_Recent_Glycemic_Status_Date(context);
            CqlDateTime n_ = context.Operators.ConvertDateToDateTime(m_);
            bool? o_ = context.Operators.SameAs(l_, n_, "day");

            return o_;
        };
        IEnumerable<Observation> c_ = context.Operators.Where<Observation>(a_, b_);
        (CqlTupleMetadata, CqlQuantity QualifyingGlycemicStatusValue, Observation QualifyingGlycemicStatus)? d_(Observation QualifyingGlycemicStatus)
        {
            DataType ah_ = QualifyingGlycemicStatus?.Value;
            object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
            (CqlTupleMetadata, CqlQuantity QualifyingGlycemicStatusValue, Observation QualifyingGlycemicStatus)? aj_ = (CqlTupleMetadata_FOBYUiHifSfYFYhEEQajgLbgF, ai_ as CqlQuantity, QualifyingGlycemicStatus);

            return aj_;
        };
        IEnumerable<(CqlTupleMetadata, CqlQuantity QualifyingGlycemicStatusValue, Observation QualifyingGlycemicStatus)?> e_ = context.Operators.Select<Observation, (CqlTupleMetadata, CqlQuantity QualifyingGlycemicStatusValue, Observation QualifyingGlycemicStatus)?>(c_, d_);
        IEnumerable<(CqlTupleMetadata, CqlQuantity QualifyingGlycemicStatusValue, Observation QualifyingGlycemicStatus)?> f_ = context.Operators.Distinct<(CqlTupleMetadata, CqlQuantity QualifyingGlycemicStatusValue, Observation QualifyingGlycemicStatus)?>(e_);
        object g_((CqlTupleMetadata, CqlQuantity QualifyingGlycemicStatusValue, Observation QualifyingGlycemicStatus)? @this)
        {
            CqlQuantity ak_ = @this?.QualifyingGlycemicStatusValue;

            return ak_;
        };
        IEnumerable<(CqlTupleMetadata, CqlQuantity QualifyingGlycemicStatusValue, Observation QualifyingGlycemicStatus)?> h_ = context.Operators.SortBy<(CqlTupleMetadata, CqlQuantity QualifyingGlycemicStatusValue, Observation QualifyingGlycemicStatus)?>(f_, g_, System.ComponentModel.ListSortDirection.Ascending);
        (CqlTupleMetadata, CqlQuantity QualifyingGlycemicStatusValue, Observation QualifyingGlycemicStatus)? i_ = context.Operators.First<(CqlTupleMetadata, CqlQuantity QualifyingGlycemicStatusValue, Observation QualifyingGlycemicStatus)?>(h_);
        Observation j_ = i_?.QualifyingGlycemicStatus;

        return j_;
    }


    [CqlDeclaration("Has Most Recent Glycemic Status Assessment Without Result")]
    public bool? Has_Most_Recent_Glycemic_Status_Assessment_Without_Result(CqlContext context)
    {
        Observation a_ = this.Lowest_Glycemic_Status_Assessment_Reading_on_Most_Recent_Day(context);
        bool? b_ = context.Operators.Not((bool?)(a_ is null));
        DataType d_ = a_?.Value;
        object e_ = FHIRHelpers_4_4_000.Instance.ToValue(context, d_);
        bool? f_ = context.Operators.And(b_, (bool?)(e_ is null));

        return f_;
    }


    [CqlDeclaration("Has Most Recent Elevated Glycemic Status Assessment")]
    public bool? Has_Most_Recent_Elevated_Glycemic_Status_Assessment(CqlContext context)
    {
        Observation a_ = this.Lowest_Glycemic_Status_Assessment_Reading_on_Most_Recent_Day(context);
        DataType b_ = a_?.Value;
        object c_ = FHIRHelpers_4_4_000.Instance.ToValue(context, b_);
        CqlQuantity d_ = context.Operators.Quantity(9m, "%");
        bool? e_ = context.Operators.Greater(c_ as CqlQuantity, d_);

        return e_;
    }


    [CqlDeclaration("Has No Record Of Glycemic Status Assessment")]
    public bool? Has_No_Record_Of_Glycemic_Status_Assessment(CqlContext context)
    {
        IEnumerable<Observation> a_ = this.Glycemic_Status_Assessment(context);
        bool? b_ = context.Operators.Exists<Observation>(a_);
        bool? c_ = context.Operators.Not(b_);

        return c_;
    }


    [CqlDeclaration("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        bool? a_ = this.Has_Most_Recent_Glycemic_Status_Assessment_Without_Result(context);
        bool? b_ = this.Has_Most_Recent_Elevated_Glycemic_Status_Assessment(context);
        bool? c_ = context.Operators.Or(a_, b_);
        bool? d_ = this.Has_No_Record_Of_Glycemic_Status_Assessment(context);
        bool? e_ = context.Operators.Or(c_, d_);

        return e_;
    }

    private static CqlTupleMetadata CqlTupleMetadata_FOBYUiHifSfYFYhEEQajgLbgF = new(
        [typeof(CqlQuantity), typeof(Observation)],
        ["QualifyingGlycemicStatusValue", "QualifyingGlycemicStatus"]);

}
