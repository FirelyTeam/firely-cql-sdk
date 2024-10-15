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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.6.0")]
[CqlLibrary("ALARACTOQRFHIR", "0.1.001")]
public partial class ALARACTOQRFHIR_0_1_001 : ILibrary, ISingleton<ALARACTOQRFHIR_0_1_001>
{
    private ALARACTOQRFHIR_0_1_001() {}

    public static ALARACTOQRFHIR_0_1_001 Instance { get; } = new();

    #region Library Members
    public string Name => "ALARACTOQRFHIR";
    public string Version => "0.1.001";
    public ILibrary[] Dependencies => [FHIRHelpers_4_3_000.Instance, CQMCommon_2_0_000.Instance, QICoreCommon_2_0_000.Instance, SupplementalDataElements_3_4_000.Instance];
    #endregion Library Members

    [CqlDeclaration("Encounter Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307")]
    public CqlValueSet Encounter_Inpatient(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", default);


    [CqlDeclaration("Calculated CT global noise")]
    public CqlCode Calculated_CT_global_noise(CqlContext context) => 
        new CqlCode("96912-1", "http://loinc.org", default, default);


    [CqlDeclaration("Calculated CT size-adjusted dose")]
    public CqlCode Calculated_CT_size_adjusted_dose(CqlContext context) => 
        new CqlCode("96913-9", "http://loinc.org", default, default);


    [CqlDeclaration("CT dose and image quality category")]
    public CqlCode CT_dose_and_image_quality_category(CqlContext context) => 
        new CqlCode("96914-7", "http://loinc.org", default, default);


    [CqlDeclaration("LOINC")]
    public CqlCode[] LOINC(CqlContext context)
    {
        CqlCode[] a_ = [
            new CqlCode("96912-1", "http://loinc.org", default, default),
            new CqlCode("96913-9", "http://loinc.org", default, default),
            new CqlCode("96914-7", "http://loinc.org", default, default),
        ];

        return a_;
    }


    [CqlDeclaration("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
        CqlDateTime b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
        object d_ = context.ResolveParameter("ALARACTOQRFHIR-0.1.001", "Measurement Period", c_);

        return (CqlInterval<CqlDateTime>)d_;
    }


    [CqlDeclaration("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

        return b_;
    }


    [CqlDeclaration("Qualified Scan")]
    public IEnumerable<Observation> Qualified_Scan(CqlContext context)
    {
        CqlCode a_ = this.CT_dose_and_image_quality_category(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? d_(Observation CTScan)
        {
            CqlInterval<CqlDateTime> f_ = this.Measurement_Period(context);
            DataType g_ = CTScan?.Effective;
            object h_ = FHIRHelpers_4_3_000.Instance.ToValue(context, g_);
            CqlInterval<CqlDateTime> i_ = QICoreCommon_2_0_000.Instance.ToInterval(context, h_);
            bool? j_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(f_, i_, default);
            Patient k_ = this.Patient(context);
            Date l_ = k_?.BirthDateElement;
            string m_ = l_?.Value;
            CqlDate n_ = context.Operators.ConvertStringToDate(m_);
            CqlDateTime p_ = context.Operators.Start(f_);
            CqlDate q_ = context.Operators.DateFrom(p_);
            int? r_ = context.Operators.CalculateAgeAt(n_, q_, "year");
            bool? s_ = context.Operators.GreaterOrEqual(r_, 18);
            bool? t_ = context.Operators.And(j_, s_);

            return t_;
        };
        IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);

        return e_;
    }


    [CqlDeclaration("Initial Population")]
    public IEnumerable<Observation> Initial_Population(CqlContext context)
    {
        IEnumerable<Observation> a_ = this.Qualified_Scan(context);
        IEnumerable<Observation> c_(Observation CTScan)
        {
            CqlValueSet f_ = this.Encounter_Inpatient(context);
            IEnumerable<Encounter> g_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            bool? h_(Encounter InpatientEncounter)
            {
                CqlInterval<CqlDateTime> l_ = this.Measurement_Period(context);
                DataType m_ = CTScan?.Effective;
                object n_ = FHIRHelpers_4_3_000.Instance.ToValue(context, m_);
                CqlInterval<CqlDateTime> o_ = QICoreCommon_2_0_000.Instance.ToInterval(context, n_);
                bool? p_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(l_, o_, default);

                return p_;
            };
            IEnumerable<Encounter> i_ = context.Operators.Where<Encounter>(g_, h_);
            Observation j_(Encounter InpatientEncounter) => 
                CTScan;
            IEnumerable<Observation> k_ = context.Operators.Select<Encounter, Observation>(i_, j_);

            return k_;
        };
        IEnumerable<Observation> d_ = context.Operators.SelectMany<Observation, Observation>(a_, c_);
        IEnumerable<Observation> e_ = context.Operators.Except<Observation>(a_, d_);

        return e_;
    }

    public decimal? Global_Noise_Value(CqlContext context, Observation Obs)
    {
        List<Observation.ComponentComponent> a_ = Obs?.Component;
        bool? b_(Observation.ComponentComponent C)
        {
            CodeableConcept g_ = C?.Code;
            CqlConcept h_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, g_);
            CqlCode i_ = this.Calculated_CT_global_noise(context);
            CqlConcept j_ = context.Operators.ConvertCodeToConcept(i_);
            bool? k_ = context.Operators.Equivalent(h_, j_);
            DataType l_ = C?.Value;
            object m_ = FHIRHelpers_4_3_000.Instance.ToValue(context, l_);
            string n_ = (m_ as CqlQuantity)?.unit;
            bool? o_ = context.Operators.Equal(n_, "[hnsf'U]");
            bool? p_ = context.Operators.And(k_, o_);

            return p_;
        };
        IEnumerable<Observation.ComponentComponent> c_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)a_, b_);
        decimal? d_(Observation.ComponentComponent C)
        {
            DataType q_ = C?.Value;
            object r_ = FHIRHelpers_4_3_000.Instance.ToValue(context, q_);
            decimal? s_ = (r_ as CqlQuantity)?.value;

            return s_;
        };
        IEnumerable<decimal?> e_ = context.Operators.Select<Observation.ComponentComponent, decimal?>(c_, d_);
        decimal? f_ = context.Operators.SingletonFrom<decimal?>(e_);

        return f_;
    }

    public decimal? Size_Adjusted_Value(CqlContext context, Observation Obs)
    {
        List<Observation.ComponentComponent> a_ = Obs?.Component;
        bool? b_(Observation.ComponentComponent C)
        {
            CodeableConcept g_ = C?.Code;
            CqlConcept h_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, g_);
            CqlCode i_ = this.Calculated_CT_size_adjusted_dose(context);
            CqlConcept j_ = context.Operators.ConvertCodeToConcept(i_);
            bool? k_ = context.Operators.Equivalent(h_, j_);
            DataType l_ = C?.Value;
            object m_ = FHIRHelpers_4_3_000.Instance.ToValue(context, l_);
            string n_ = (m_ as CqlQuantity)?.unit;
            bool? o_ = context.Operators.Equal(n_, "mGy.cm");
            bool? p_ = context.Operators.And(k_, o_);

            return p_;
        };
        IEnumerable<Observation.ComponentComponent> c_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)a_, b_);
        decimal? d_(Observation.ComponentComponent C)
        {
            DataType q_ = C?.Value;
            object r_ = FHIRHelpers_4_3_000.Instance.ToValue(context, q_);
            decimal? s_ = (r_ as CqlQuantity)?.value;

            return s_;
        };
        IEnumerable<decimal?> e_ = context.Operators.Select<Observation.ComponentComponent, decimal?>(c_, d_);
        decimal? f_ = context.Operators.SingletonFrom<decimal?>(e_);

        return f_;
    }


    [CqlDeclaration("Denominator")]
    public IEnumerable<Observation> Denominator(CqlContext context)
    {
        IEnumerable<Observation> a_ = this.Initial_Population(context);
        bool? b_(Observation IP)
        {
            decimal? d_ = this.Global_Noise_Value(context, IP);
            bool? e_ = context.Operators.Not((bool?)(d_ is null));
            decimal? f_ = this.Size_Adjusted_Value(context, IP);
            bool? g_ = context.Operators.Not((bool?)(f_ is null));
            bool? h_ = context.Operators.And(e_, g_);
            DataType i_ = IP?.Value;
            object j_ = FHIRHelpers_4_3_000.Instance.ToValue(context, i_);
            bool? k_ = context.Operators.Not((bool?)(j_ is null));
            bool? l_ = context.Operators.And(h_, k_);

            return l_;
        };
        IEnumerable<Observation> c_ = context.Operators.Where<Observation>(a_, b_);

        return c_;
    }


    [CqlDeclaration("Denominator Exclusion")]
    public IEnumerable<Observation> Denominator_Exclusion(CqlContext context)
    {
        IEnumerable<Observation> a_ = this.Denominator(context);
        bool? b_(Observation Denominator)
        {
            DataType d_ = Denominator?.Value;
            object e_ = FHIRHelpers_4_3_000.Instance.ToValue(context, d_);
            CqlCode[] f_ = (e_ as CqlConcept)?.codes;
            bool? g_(CqlCode @this)
            {
                string l_ = @this?.code;
                bool? m_ = context.Operators.Not((bool?)(l_ is null));

                return m_;
            };
            IEnumerable<CqlCode> h_ = context.Operators.Where<CqlCode>((IEnumerable<CqlCode>)f_, g_);
            string i_(CqlCode @this)
            {
                string n_ = @this?.code;

                return n_;
            };
            IEnumerable<string> j_ = context.Operators.Select<CqlCode, string>(h_, i_);
            bool? k_ = context.Operators.Contains<string>(j_, "FULLBODY");

            return k_;
        };
        IEnumerable<Observation> c_ = context.Operators.Where<Observation>(a_, b_);

        return c_;
    }

    public bool? Qualifies(CqlContext context, Observation Obs, string code, decimal? noiseThreshold, decimal? sizeDoseThreshold)
    {
        DataType a_ = Obs?.Value;
        object b_ = FHIRHelpers_4_3_000.Instance.ToValue(context, a_);
        CqlCode[] c_ = (b_ as CqlConcept)?.codes;
        bool? d_(CqlCode @this)
        {
            string o_ = @this?.code;
            bool? p_ = context.Operators.Not((bool?)(o_ is null));

            return p_;
        };
        IEnumerable<CqlCode> e_ = context.Operators.Where<CqlCode>((IEnumerable<CqlCode>)c_, d_);
        string f_(CqlCode @this)
        {
            string q_ = @this?.code;

            return q_;
        };
        IEnumerable<string> g_ = context.Operators.Select<CqlCode, string>(e_, f_);
        bool? h_ = context.Operators.Contains<string>(g_, code);
        decimal? i_ = this.Global_Noise_Value(context, Obs);
        bool? j_ = context.Operators.GreaterOrEqual(i_, noiseThreshold);
        decimal? k_ = this.Size_Adjusted_Value(context, Obs);
        bool? l_ = context.Operators.GreaterOrEqual(k_, sizeDoseThreshold);
        bool? m_ = context.Operators.Or(j_, l_);
        bool? n_ = context.Operators.And(h_, m_);

        return n_;
    }

    public bool? CT_Scan_Qualifies(CqlContext context, Observation IP)
    {
        decimal? a_ = context.Operators.ConvertIntegerToDecimal(64);
        decimal? b_ = context.Operators.ConvertIntegerToDecimal(598);
        bool? c_ = this.Qualifies(context, IP, "ABDOPEL LD", a_, b_);
        decimal? d_ = context.Operators.ConvertIntegerToDecimal(29);
        decimal? e_ = context.Operators.ConvertIntegerToDecimal(644);
        bool? f_ = this.Qualifies(context, IP, "ABDOPEL RT", d_, e_);
        bool? g_ = context.Operators.Or(c_, f_);
        decimal? i_ = context.Operators.ConvertIntegerToDecimal(1260);
        bool? j_ = this.Qualifies(context, IP, "ABDOPEL HD", d_, i_);
        bool? k_ = context.Operators.Or(g_, j_);
        decimal? l_ = context.Operators.ConvertIntegerToDecimal(55);
        decimal? m_ = context.Operators.ConvertIntegerToDecimal(93);
        bool? n_ = this.Qualifies(context, IP, "CARDIAC LD", l_, m_);
        bool? o_ = context.Operators.Or(k_, n_);
        decimal? p_ = context.Operators.ConvertIntegerToDecimal(32);
        decimal? q_ = context.Operators.ConvertIntegerToDecimal(576);
        bool? r_ = this.Qualifies(context, IP, "CARDIAC RT", p_, q_);
        bool? s_ = context.Operators.Or(o_, r_);
        decimal? u_ = context.Operators.ConvertIntegerToDecimal(377);
        bool? v_ = this.Qualifies(context, IP, "CHEST LD", l_, u_);
        bool? w_ = context.Operators.Or(s_, v_);
        decimal? x_ = context.Operators.ConvertIntegerToDecimal(49);
        bool? z_ = this.Qualifies(context, IP, "CHEST RT", x_, u_);
        bool? aa_ = context.Operators.Or(w_, z_);
        decimal? ac_ = context.Operators.ConvertIntegerToDecimal(1282);
        bool? ad_ = this.Qualifies(context, IP, "CHEST-CARDIAC HD", x_, ac_);
        bool? ae_ = context.Operators.Or(aa_, ad_);
        decimal? af_ = context.Operators.ConvertIntegerToDecimal(115);
        decimal? ag_ = context.Operators.ConvertIntegerToDecimal(582);
        bool? ah_ = this.Qualifies(context, IP, "HEAD LD", af_, ag_);
        bool? ai_ = context.Operators.Or(ae_, ah_);
        decimal? ak_ = context.Operators.ConvertIntegerToDecimal(1025);
        bool? al_ = this.Qualifies(context, IP, "HEAD RT", af_, ak_);
        bool? am_ = context.Operators.Or(ai_, al_);
        decimal? ao_ = context.Operators.ConvertIntegerToDecimal(1832);
        bool? ap_ = this.Qualifies(context, IP, "HEAD HD", af_, ao_);
        bool? aq_ = context.Operators.Or(am_, ap_);
        decimal? ar_ = context.Operators.ConvertIntegerToDecimal(73);
        decimal? as_ = context.Operators.ConvertIntegerToDecimal(320);
        bool? at_ = this.Qualifies(context, IP, "EXTREMITIES", ar_, as_);
        bool? au_ = context.Operators.Or(aq_, at_);
        decimal? av_ = context.Operators.ConvertIntegerToDecimal(25);
        bool? ax_ = this.Qualifies(context, IP, "NECK-CSPINE", av_, i_);
        bool? ay_ = context.Operators.Or(au_, ax_);
        bool? bb_ = this.Qualifies(context, IP, "TSPINE-LSPINE", av_, i_);
        bool? bc_ = context.Operators.Or(ay_, bb_);
        decimal? be_ = context.Operators.ConvertIntegerToDecimal(1637);
        bool? bf_ = this.Qualifies(context, IP, "CAP", d_, be_);
        bool? bg_ = context.Operators.Or(bc_, bf_);
        decimal? bi_ = context.Operators.ConvertIntegerToDecimal(2520);
        bool? bj_ = this.Qualifies(context, IP, "TLSPINE", av_, bi_);
        bool? bk_ = context.Operators.Or(bg_, bj_);
        decimal? bm_ = context.Operators.ConvertIntegerToDecimal(2285);
        bool? bn_ = this.Qualifies(context, IP, "HEADNECK RT", av_, bm_);
        bool? bo_ = context.Operators.Or(bk_, bn_);
        decimal? bq_ = context.Operators.ConvertIntegerToDecimal(3092);
        bool? br_ = this.Qualifies(context, IP, "HEADNECK HD", av_, bq_);
        bool? bs_ = context.Operators.Or(bo_, br_);

        return bs_;
    }


    [CqlDeclaration("Numerator")]
    public IEnumerable<Observation> Numerator(CqlContext context)
    {
        IEnumerable<Observation> a_ = this.Denominator(context);
        bool? b_(Observation Denominator)
        {
            bool? d_ = this.CT_Scan_Qualifies(context, Denominator);

            return d_;
        };
        IEnumerable<Observation> c_ = context.Operators.Where<Observation>(a_, b_);

        return c_;
    }


    [CqlDeclaration("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_4_000.Instance.SDE_Ethnicity(context);

        return a_;
    }


    [CqlDeclaration("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_3_4_000.Instance.SDE_Payer(context);

        return a_;
    }


    [CqlDeclaration("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_4_000.Instance.SDE_Race(context);

        return a_;
    }


    [CqlDeclaration("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_3_4_000.Instance.SDE_Sex(context);

        return a_;
    }

}
