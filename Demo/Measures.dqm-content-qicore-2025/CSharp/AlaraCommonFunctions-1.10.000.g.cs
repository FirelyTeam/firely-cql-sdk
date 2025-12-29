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
[CqlLibrary("AlaraCommonFunctions", "1.10.000")]
public partial class AlaraCommonFunctions_1_10_000 : ILibrary, ISingleton<AlaraCommonFunctions_1_10_000>
{
    private AlaraCommonFunctions_1_10_000() {}

    public static AlaraCommonFunctions_1_10_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "AlaraCommonFunctions";
    public string Version => "1.10.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance];

    #endregion ILibrary Implementation

    #region Codes

    [CqlCodeDefinition("Abdomen and Pelvis High Dose", codeId: "LA31754-7", codeSystem: "http://loinc.org")]
    public CqlCode Abdomen_and_Pelvis_High_Dose(CqlContext _) => _Abdomen_and_Pelvis_High_Dose;
    private static readonly CqlCode _Abdomen_and_Pelvis_High_Dose = new CqlCode("LA31754-7", "http://loinc.org");

    [CqlCodeDefinition("Abdomen and Pelvis Low Dose", codeId: "LA31752-1", codeSystem: "http://loinc.org")]
    public CqlCode Abdomen_and_Pelvis_Low_Dose(CqlContext _) => _Abdomen_and_Pelvis_Low_Dose;
    private static readonly CqlCode _Abdomen_and_Pelvis_Low_Dose = new CqlCode("LA31752-1", "http://loinc.org");

    [CqlCodeDefinition("Abdomen and Pelvis Routine Dose", codeId: "LA31753-9", codeSystem: "http://loinc.org")]
    public CqlCode Abdomen_and_Pelvis_Routine_Dose(CqlContext _) => _Abdomen_and_Pelvis_Routine_Dose;
    private static readonly CqlCode _Abdomen_and_Pelvis_Routine_Dose = new CqlCode("LA31753-9", "http://loinc.org");

    [CqlCodeDefinition("Calculated CT global noise", codeId: "96912-1", codeSystem: "http://loinc.org")]
    public CqlCode Calculated_CT_global_noise(CqlContext _) => _Calculated_CT_global_noise;
    private static readonly CqlCode _Calculated_CT_global_noise = new CqlCode("96912-1", "http://loinc.org");

    [CqlCodeDefinition("Calculated CT size-adjusted dose", codeId: "96913-9", codeSystem: "http://loinc.org")]
    public CqlCode Calculated_CT_size_adjusted_dose(CqlContext _) => _Calculated_CT_size_adjusted_dose;
    private static readonly CqlCode _Calculated_CT_size_adjusted_dose = new CqlCode("96913-9", "http://loinc.org");

    [CqlCodeDefinition("Cardiac High Dose or Chest High Dose", codeId: "LA31761-2", codeSystem: "http://loinc.org")]
    public CqlCode Cardiac_High_Dose_or_Chest_High_Dose(CqlContext _) => _Cardiac_High_Dose_or_Chest_High_Dose;
    private static readonly CqlCode _Cardiac_High_Dose_or_Chest_High_Dose = new CqlCode("LA31761-2", "http://loinc.org");

    [CqlCodeDefinition("Cardiac Low Dose", codeId: "LA31755-4", codeSystem: "http://loinc.org")]
    public CqlCode Cardiac_Low_Dose(CqlContext _) => _Cardiac_Low_Dose;
    private static readonly CqlCode _Cardiac_Low_Dose = new CqlCode("LA31755-4", "http://loinc.org");

    [CqlCodeDefinition("Cardiac Routine Dose", codeId: "LA31756-2", codeSystem: "http://loinc.org")]
    public CqlCode Cardiac_Routine_Dose(CqlContext _) => _Cardiac_Routine_Dose;
    private static readonly CqlCode _Cardiac_Routine_Dose = new CqlCode("LA31756-2", "http://loinc.org");

    [CqlCodeDefinition("Chest Low Dose", codeId: "LA31758-8", codeSystem: "http://loinc.org")]
    public CqlCode Chest_Low_Dose(CqlContext _) => _Chest_Low_Dose;
    private static readonly CqlCode _Chest_Low_Dose = new CqlCode("LA31758-8", "http://loinc.org");

    [CqlCodeDefinition("Chest Routine Dose", codeId: "LA31759-6", codeSystem: "http://loinc.org")]
    public CqlCode Chest_Routine_Dose(CqlContext _) => _Chest_Routine_Dose;
    private static readonly CqlCode _Chest_Routine_Dose = new CqlCode("LA31759-6", "http://loinc.org");

    [CqlCodeDefinition("Extremity", codeId: "LA31765-3", codeSystem: "http://loinc.org")]
    public CqlCode Extremity(CqlContext _) => _Extremity;
    private static readonly CqlCode _Extremity = new CqlCode("LA31765-3", "http://loinc.org");

    [CqlCodeDefinition("Head High Dose", codeId: "LA31764-6", codeSystem: "http://loinc.org")]
    public CqlCode Head_High_Dose(CqlContext _) => _Head_High_Dose;
    private static readonly CqlCode _Head_High_Dose = new CqlCode("LA31764-6", "http://loinc.org");

    [CqlCodeDefinition("Head Low Dose", codeId: "LA31762-0", codeSystem: "http://loinc.org")]
    public CqlCode Head_Low_Dose(CqlContext _) => _Head_Low_Dose;
    private static readonly CqlCode _Head_Low_Dose = new CqlCode("LA31762-0", "http://loinc.org");

    [CqlCodeDefinition("Head Routine Dose", codeId: "LA31763-8", codeSystem: "http://loinc.org")]
    public CqlCode Head_Routine_Dose(CqlContext _) => _Head_Routine_Dose;
    private static readonly CqlCode _Head_Routine_Dose = new CqlCode("LA31763-8", "http://loinc.org");

    [CqlCodeDefinition("Neck or Cervical Spine", codeId: "LA31766-1", codeSystem: "http://loinc.org")]
    public CqlCode Neck_or_Cervical_Spine(CqlContext _) => _Neck_or_Cervical_Spine;
    private static readonly CqlCode _Neck_or_Cervical_Spine = new CqlCode("LA31766-1", "http://loinc.org");

    [CqlCodeDefinition("Simultaneous Chest and Abdomen and Pelvis", codeId: "LA31768-7", codeSystem: "http://loinc.org")]
    public CqlCode Simultaneous_Chest_and_Abdomen_and_Pelvis(CqlContext _) => _Simultaneous_Chest_and_Abdomen_and_Pelvis;
    private static readonly CqlCode _Simultaneous_Chest_and_Abdomen_and_Pelvis = new CqlCode("LA31768-7", "http://loinc.org");

    [CqlCodeDefinition("Simultaneous Head and Neck High Dose", codeId: "LA31770-3", codeSystem: "http://loinc.org")]
    public CqlCode Simultaneous_Head_and_Neck_High_Dose(CqlContext _) => _Simultaneous_Head_and_Neck_High_Dose;
    private static readonly CqlCode _Simultaneous_Head_and_Neck_High_Dose = new CqlCode("LA31770-3", "http://loinc.org");

    [CqlCodeDefinition("Simultaneous Head and Neck Routine Dose", codeId: "LA31769-5", codeSystem: "http://loinc.org")]
    public CqlCode Simultaneous_Head_and_Neck_Routine_Dose(CqlContext _) => _Simultaneous_Head_and_Neck_Routine_Dose;
    private static readonly CqlCode _Simultaneous_Head_and_Neck_Routine_Dose = new CqlCode("LA31769-5", "http://loinc.org");

    [CqlCodeDefinition("Simultaneous Thoracic and Lumbar Spine", codeId: "LA31851-1", codeSystem: "http://loinc.org")]
    public CqlCode Simultaneous_Thoracic_and_Lumbar_Spine(CqlContext _) => _Simultaneous_Thoracic_and_Lumbar_Spine;
    private static readonly CqlCode _Simultaneous_Thoracic_and_Lumbar_Spine = new CqlCode("LA31851-1", "http://loinc.org");

    [CqlCodeDefinition("Thoracic or Lumbar Spine", codeId: "LA31767-9", codeSystem: "http://loinc.org")]
    public CqlCode Thoracic_or_Lumbar_Spine(CqlContext _) => _Thoracic_or_Lumbar_Spine;
    private static readonly CqlCode _Thoracic_or_Lumbar_Spine = new CqlCode("LA31767-9", "http://loinc.org");

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("LOINC", codeSystemId: "http://loinc.org", codeSystemVersion: null)]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC =
      new CqlCodeSystem("http://loinc.org", null, [
          _Abdomen_and_Pelvis_High_Dose,
          _Abdomen_and_Pelvis_Low_Dose,
          _Abdomen_and_Pelvis_Routine_Dose,
          _Calculated_CT_global_noise,
          _Calculated_CT_size_adjusted_dose,
          _Cardiac_High_Dose_or_Chest_High_Dose,
          _Cardiac_Low_Dose,
          _Cardiac_Routine_Dose,
          _Chest_Low_Dose,
          _Chest_Routine_Dose,
          _Extremity,
          _Head_High_Dose,
          _Head_Low_Dose,
          _Head_Routine_Dose,
          _Neck_or_Cervical_Spine,
          _Simultaneous_Chest_and_Abdomen_and_Pelvis,
          _Simultaneous_Head_and_Neck_High_Dose,
          _Simultaneous_Head_and_Neck_Routine_Dose,
          _Simultaneous_Thoracic_and_Lumbar_Spine,
          _Thoracic_or_Lumbar_Spine]);

    #endregion CodeSystems

    #region Functions and Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

        return b_;
    }


    [CqlFunctionDefinition("CT Scan Qualifies")]
    public bool? CT_Scan_Qualifies(CqlContext context, Observation Result)
    {
        CqlCode a_ = this.Abdomen_and_Pelvis_Low_Dose(context);
        decimal? b_ = context.Operators.ConvertIntegerToDecimal(64);
        decimal? c_ = context.Operators.ConvertIntegerToDecimal(598);
        bool? d_ = this.qualifies(context, Result, a_, b_, c_);
        CqlCode e_ = this.Abdomen_and_Pelvis_Routine_Dose(context);
        decimal? f_ = context.Operators.ConvertIntegerToDecimal(29);
        decimal? g_ = context.Operators.ConvertIntegerToDecimal(644);
        bool? h_ = this.qualifies(context, Result, e_, f_, g_);
        bool? i_ = context.Operators.Or(d_, h_);
        CqlCode j_ = this.Abdomen_and_Pelvis_High_Dose(context);
        decimal? l_ = context.Operators.ConvertIntegerToDecimal(1260);
        bool? m_ = this.qualifies(context, Result, j_, f_, l_);
        bool? n_ = context.Operators.Or(i_, m_);
        CqlCode o_ = this.Cardiac_Low_Dose(context);
        decimal? p_ = context.Operators.ConvertIntegerToDecimal(55);
        decimal? q_ = context.Operators.ConvertIntegerToDecimal(93);
        bool? r_ = this.qualifies(context, Result, o_, p_, q_);
        bool? s_ = context.Operators.Or(n_, r_);
        CqlCode t_ = this.Cardiac_Routine_Dose(context);
        decimal? u_ = context.Operators.ConvertIntegerToDecimal(32);
        decimal? v_ = context.Operators.ConvertIntegerToDecimal(576);
        bool? w_ = this.qualifies(context, Result, t_, u_, v_);
        bool? x_ = context.Operators.Or(s_, w_);
        CqlCode y_ = this.Chest_Low_Dose(context);
        decimal? aa_ = context.Operators.ConvertIntegerToDecimal(377);
        bool? ab_ = this.qualifies(context, Result, y_, p_, aa_);
        bool? ac_ = context.Operators.Or(x_, ab_);
        CqlCode ad_ = this.Chest_Routine_Dose(context);
        decimal? ae_ = context.Operators.ConvertIntegerToDecimal(49);
        bool? ag_ = this.qualifies(context, Result, ad_, ae_, aa_);
        bool? ah_ = context.Operators.Or(ac_, ag_);
        CqlCode ai_ = this.Cardiac_High_Dose_or_Chest_High_Dose(context);
        decimal? ak_ = context.Operators.ConvertIntegerToDecimal(1282);
        bool? al_ = this.qualifies(context, Result, ai_, ae_, ak_);
        bool? am_ = context.Operators.Or(ah_, al_);
        CqlCode an_ = this.Head_Low_Dose(context);
        decimal? ao_ = context.Operators.ConvertIntegerToDecimal(115);
        decimal? ap_ = context.Operators.ConvertIntegerToDecimal(582);
        bool? aq_ = this.qualifies(context, Result, an_, ao_, ap_);
        bool? ar_ = context.Operators.Or(am_, aq_);
        CqlCode as_ = this.Head_Routine_Dose(context);
        decimal? au_ = context.Operators.ConvertIntegerToDecimal(1025);
        bool? av_ = this.qualifies(context, Result, as_, ao_, au_);
        bool? aw_ = context.Operators.Or(ar_, av_);
        CqlCode ax_ = this.Head_High_Dose(context);
        decimal? az_ = context.Operators.ConvertIntegerToDecimal(1832);
        bool? ba_ = this.qualifies(context, Result, ax_, ao_, az_);
        bool? bb_ = context.Operators.Or(aw_, ba_);
        CqlCode bc_ = this.Extremity(context);
        decimal? bd_ = context.Operators.ConvertIntegerToDecimal(73);
        decimal? be_ = context.Operators.ConvertIntegerToDecimal(320);
        bool? bf_ = this.qualifies(context, Result, bc_, bd_, be_);
        bool? bg_ = context.Operators.Or(bb_, bf_);
        CqlCode bh_ = this.Neck_or_Cervical_Spine(context);
        decimal? bi_ = context.Operators.ConvertIntegerToDecimal(25);
        bool? bk_ = this.qualifies(context, Result, bh_, bi_, l_);
        bool? bl_ = context.Operators.Or(bg_, bk_);
        CqlCode bm_ = this.Thoracic_or_Lumbar_Spine(context);
        bool? bp_ = this.qualifies(context, Result, bm_, bi_, l_);
        bool? bq_ = context.Operators.Or(bl_, bp_);
        CqlCode br_ = this.Simultaneous_Chest_and_Abdomen_and_Pelvis(context);
        decimal? bt_ = context.Operators.ConvertIntegerToDecimal(1637);
        bool? bu_ = this.qualifies(context, Result, br_, f_, bt_);
        bool? bv_ = context.Operators.Or(bq_, bu_);
        CqlCode bw_ = this.Simultaneous_Thoracic_and_Lumbar_Spine(context);
        decimal? by_ = context.Operators.ConvertIntegerToDecimal(2520);
        bool? bz_ = this.qualifies(context, Result, bw_, bi_, by_);
        bool? ca_ = context.Operators.Or(bv_, bz_);
        CqlCode cb_ = this.Simultaneous_Head_and_Neck_Routine_Dose(context);
        decimal? cd_ = context.Operators.ConvertIntegerToDecimal(2285);
        bool? ce_ = this.qualifies(context, Result, cb_, bi_, cd_);
        bool? cf_ = context.Operators.Or(ca_, ce_);
        CqlCode cg_ = this.Simultaneous_Head_and_Neck_High_Dose(context);
        decimal? ci_ = context.Operators.ConvertIntegerToDecimal(3092);
        bool? cj_ = this.qualifies(context, Result, cg_, bi_, ci_);
        bool? ck_ = context.Operators.Or(cf_, cj_);

        return ck_;
    }


    [CqlFunctionDefinition("qualifies")]
    public bool? qualifies(CqlContext context, Observation Result, CqlCode code, decimal? noiseThreshold, decimal? sizeDoseThreshold)
    {
        DataType a_ = Result?.Value;
        object b_ = FHIRHelpers_4_4_000.Instance.ToValue(context, a_);
        CqlConcept c_ = context.Operators.ConvertCodeToConcept(code);
        bool? d_ = context.Operators.Equivalent(b_ as CqlConcept, c_);
        decimal? e_ = this.globalNoiseValue(context, Result);
        bool? f_ = context.Operators.GreaterOrEqual(e_, noiseThreshold);
        decimal? g_ = this.sizeAdjustedValue(context, Result);
        bool? h_ = context.Operators.GreaterOrEqual(g_, sizeDoseThreshold);
        bool? i_ = context.Operators.Or(f_, h_);
        bool? j_ = context.Operators.And(d_, i_);

        return j_;
    }


    [CqlFunctionDefinition("globalNoiseValue")]
    public decimal? globalNoiseValue(CqlContext context, Observation Result)
    {
        List<Observation.ComponentComponent> a_ = Result?.Component;
        bool? b_(Observation.ComponentComponent C)
        {
            Code<ObservationStatus> h_ = Result?.StatusElement;
            ObservationStatus? i_ = h_?.Value;
            string j_ = context.Operators.Convert<string>(i_);
            string[] k_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? l_ = context.Operators.In<string>(j_, (IEnumerable<string>)k_);
            CodeableConcept m_ = C?.Code;
            CqlConcept n_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, m_);
            CqlCode o_ = this.Calculated_CT_global_noise(context);
            CqlConcept p_ = context.Operators.ConvertCodeToConcept(o_);
            bool? q_ = context.Operators.Equivalent(n_, p_);
            bool? r_ = context.Operators.And(l_, q_);
            DataType s_ = C?.Value;
            object t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
            string u_ = (t_ as CqlQuantity)?.unit;
            bool? v_ = context.Operators.Equal(u_, "[hnsf'U]");
            bool? w_ = context.Operators.And(r_, v_);

            return w_;
        };
        IEnumerable<Observation.ComponentComponent> c_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)a_, b_);
        decimal? d_(Observation.ComponentComponent C)
        {
            DataType x_ = C?.Value;
            object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
            decimal? z_ = (y_ as CqlQuantity)?.value;

            return z_;
        };
        IEnumerable<decimal?> e_ = context.Operators.Select<Observation.ComponentComponent, decimal?>(c_, d_);
        IEnumerable<decimal?> f_ = context.Operators.Distinct<decimal?>(e_);
        decimal? g_ = context.Operators.SingletonFrom<decimal?>(f_);

        return g_;
    }


    [CqlFunctionDefinition("sizeAdjustedValue")]
    public decimal? sizeAdjustedValue(CqlContext context, Observation Result)
    {
        List<Observation.ComponentComponent> a_ = Result?.Component;
        bool? b_(Observation.ComponentComponent C)
        {
            Code<ObservationStatus> h_ = Result?.StatusElement;
            ObservationStatus? i_ = h_?.Value;
            string j_ = context.Operators.Convert<string>(i_);
            string[] k_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? l_ = context.Operators.In<string>(j_, (IEnumerable<string>)k_);
            CodeableConcept m_ = C?.Code;
            CqlConcept n_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, m_);
            CqlCode o_ = this.Calculated_CT_size_adjusted_dose(context);
            CqlConcept p_ = context.Operators.ConvertCodeToConcept(o_);
            bool? q_ = context.Operators.Equivalent(n_, p_);
            bool? r_ = context.Operators.And(l_, q_);
            DataType s_ = C?.Value;
            object t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
            string u_ = (t_ as CqlQuantity)?.unit;
            bool? v_ = context.Operators.Equal(u_, "mGy.cm");
            bool? w_ = context.Operators.And(r_, v_);

            return w_;
        };
        IEnumerable<Observation.ComponentComponent> c_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)a_, b_);
        decimal? d_(Observation.ComponentComponent C)
        {
            DataType x_ = C?.Value;
            object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
            decimal? z_ = (y_ as CqlQuantity)?.value;

            return z_;
        };
        IEnumerable<decimal?> e_ = context.Operators.Select<Observation.ComponentComponent, decimal?>(c_, d_);
        IEnumerable<decimal?> f_ = context.Operators.Distinct<decimal?>(e_);
        decimal? g_ = context.Operators.SingletonFrom<decimal?>(f_);

        return g_;
    }


    [CqlFunctionDefinition("ctScanQualifies")]
    public bool? ctScanQualifies(CqlContext context, Observation Result)
    {
        CqlCode a_ = this.Abdomen_and_Pelvis_Low_Dose(context);
        decimal? b_ = context.Operators.ConvertIntegerToDecimal(64);
        decimal? c_ = context.Operators.ConvertIntegerToDecimal(598);
        bool? d_ = this.qualifies(context, Result, a_, b_, c_);
        CqlCode e_ = this.Abdomen_and_Pelvis_Routine_Dose(context);
        decimal? f_ = context.Operators.ConvertIntegerToDecimal(29);
        decimal? g_ = context.Operators.ConvertIntegerToDecimal(644);
        bool? h_ = this.qualifies(context, Result, e_, f_, g_);
        bool? i_ = context.Operators.Or(d_, h_);
        CqlCode j_ = this.Abdomen_and_Pelvis_High_Dose(context);
        decimal? l_ = context.Operators.ConvertIntegerToDecimal(1260);
        bool? m_ = this.qualifies(context, Result, j_, f_, l_);
        bool? n_ = context.Operators.Or(i_, m_);
        CqlCode o_ = this.Cardiac_Low_Dose(context);
        decimal? p_ = context.Operators.ConvertIntegerToDecimal(55);
        decimal? q_ = context.Operators.ConvertIntegerToDecimal(93);
        bool? r_ = this.qualifies(context, Result, o_, p_, q_);
        bool? s_ = context.Operators.Or(n_, r_);
        CqlCode t_ = this.Cardiac_Routine_Dose(context);
        decimal? u_ = context.Operators.ConvertIntegerToDecimal(32);
        decimal? v_ = context.Operators.ConvertIntegerToDecimal(576);
        bool? w_ = this.qualifies(context, Result, t_, u_, v_);
        bool? x_ = context.Operators.Or(s_, w_);
        CqlCode y_ = this.Chest_Low_Dose(context);
        decimal? aa_ = context.Operators.ConvertIntegerToDecimal(377);
        bool? ab_ = this.qualifies(context, Result, y_, p_, aa_);
        bool? ac_ = context.Operators.Or(x_, ab_);
        CqlCode ad_ = this.Chest_Routine_Dose(context);
        decimal? ae_ = context.Operators.ConvertIntegerToDecimal(49);
        bool? ag_ = this.qualifies(context, Result, ad_, ae_, aa_);
        bool? ah_ = context.Operators.Or(ac_, ag_);
        CqlCode ai_ = this.Cardiac_High_Dose_or_Chest_High_Dose(context);
        decimal? ak_ = context.Operators.ConvertIntegerToDecimal(1282);
        bool? al_ = this.qualifies(context, Result, ai_, ae_, ak_);
        bool? am_ = context.Operators.Or(ah_, al_);
        CqlCode an_ = this.Head_Low_Dose(context);
        decimal? ao_ = context.Operators.ConvertIntegerToDecimal(115);
        decimal? ap_ = context.Operators.ConvertIntegerToDecimal(582);
        bool? aq_ = this.qualifies(context, Result, an_, ao_, ap_);
        bool? ar_ = context.Operators.Or(am_, aq_);
        CqlCode as_ = this.Head_Routine_Dose(context);
        decimal? au_ = context.Operators.ConvertIntegerToDecimal(1025);
        bool? av_ = this.qualifies(context, Result, as_, ao_, au_);
        bool? aw_ = context.Operators.Or(ar_, av_);
        CqlCode ax_ = this.Head_High_Dose(context);
        decimal? az_ = context.Operators.ConvertIntegerToDecimal(1832);
        bool? ba_ = this.qualifies(context, Result, ax_, ao_, az_);
        bool? bb_ = context.Operators.Or(aw_, ba_);
        CqlCode bc_ = this.Extremity(context);
        decimal? bd_ = context.Operators.ConvertIntegerToDecimal(73);
        decimal? be_ = context.Operators.ConvertIntegerToDecimal(320);
        bool? bf_ = this.qualifies(context, Result, bc_, bd_, be_);
        bool? bg_ = context.Operators.Or(bb_, bf_);
        CqlCode bh_ = this.Neck_or_Cervical_Spine(context);
        decimal? bi_ = context.Operators.ConvertIntegerToDecimal(25);
        bool? bk_ = this.qualifies(context, Result, bh_, bi_, l_);
        bool? bl_ = context.Operators.Or(bg_, bk_);
        CqlCode bm_ = this.Thoracic_or_Lumbar_Spine(context);
        bool? bp_ = this.qualifies(context, Result, bm_, bi_, l_);
        bool? bq_ = context.Operators.Or(bl_, bp_);
        CqlCode br_ = this.Simultaneous_Chest_and_Abdomen_and_Pelvis(context);
        decimal? bt_ = context.Operators.ConvertIntegerToDecimal(1637);
        bool? bu_ = this.qualifies(context, Result, br_, f_, bt_);
        bool? bv_ = context.Operators.Or(bq_, bu_);
        CqlCode bw_ = this.Simultaneous_Thoracic_and_Lumbar_Spine(context);
        decimal? by_ = context.Operators.ConvertIntegerToDecimal(2520);
        bool? bz_ = this.qualifies(context, Result, bw_, bi_, by_);
        bool? ca_ = context.Operators.Or(bv_, bz_);
        CqlCode cb_ = this.Simultaneous_Head_and_Neck_Routine_Dose(context);
        decimal? cd_ = context.Operators.ConvertIntegerToDecimal(2285);
        bool? ce_ = this.qualifies(context, Result, cb_, bi_, cd_);
        bool? cf_ = context.Operators.Or(ca_, ce_);
        CqlCode cg_ = this.Simultaneous_Head_and_Neck_High_Dose(context);
        decimal? ci_ = context.Operators.ConvertIntegerToDecimal(3092);
        bool? cj_ = this.qualifies(context, Result, cg_, bi_, ci_);
        bool? ck_ = context.Operators.Or(cf_, cj_);

        return ck_;
    }


    [CqlFunctionDefinition("Qualifies")]
    public bool? Qualifies(CqlContext context, Observation Result, CqlCode code, decimal? noiseThreshold, decimal? sizeDoseThreshold)
    {
        DataType a_ = Result?.Value;
        object b_ = FHIRHelpers_4_4_000.Instance.ToValue(context, a_);
        CqlConcept c_ = context.Operators.ConvertCodeToConcept(code);
        bool? d_ = context.Operators.Equivalent(b_ as CqlConcept, c_);
        decimal? e_ = this.Global_Noise_Value(context, Result);
        bool? f_ = context.Operators.GreaterOrEqual(e_, noiseThreshold);
        decimal? g_ = this.Size_Adjusted_Value(context, Result);
        bool? h_ = context.Operators.GreaterOrEqual(g_, sizeDoseThreshold);
        bool? i_ = context.Operators.Or(f_, h_);
        bool? j_ = context.Operators.And(d_, i_);

        return j_;
    }


    [CqlFunctionDefinition("Global Noise Value")]
    public decimal? Global_Noise_Value(CqlContext context, Observation Result)
    {
        List<Observation.ComponentComponent> a_ = Result?.Component;
        bool? b_(Observation.ComponentComponent C)
        {
            Code<ObservationStatus> h_ = Result?.StatusElement;
            ObservationStatus? i_ = h_?.Value;
            string j_ = context.Operators.Convert<string>(i_);
            string[] k_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? l_ = context.Operators.In<string>(j_, (IEnumerable<string>)k_);
            CodeableConcept m_ = C?.Code;
            CqlConcept n_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, m_);
            CqlCode o_ = this.Calculated_CT_global_noise(context);
            CqlConcept p_ = context.Operators.ConvertCodeToConcept(o_);
            bool? q_ = context.Operators.Equivalent(n_, p_);
            bool? r_ = context.Operators.And(l_, q_);
            DataType s_ = C?.Value;
            object t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
            string u_ = (t_ as CqlQuantity)?.unit;
            bool? v_ = context.Operators.Equal(u_, "[hnsf'U]");
            bool? w_ = context.Operators.And(r_, v_);

            return w_;
        };
        IEnumerable<Observation.ComponentComponent> c_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)a_, b_);
        decimal? d_(Observation.ComponentComponent C)
        {
            DataType x_ = C?.Value;
            object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
            decimal? z_ = (y_ as CqlQuantity)?.value;

            return z_;
        };
        IEnumerable<decimal?> e_ = context.Operators.Select<Observation.ComponentComponent, decimal?>(c_, d_);
        IEnumerable<decimal?> f_ = context.Operators.Distinct<decimal?>(e_);
        decimal? g_ = context.Operators.SingletonFrom<decimal?>(f_);

        return g_;
    }


    [CqlFunctionDefinition("Size Adjusted Value")]
    public decimal? Size_Adjusted_Value(CqlContext context, Observation Result)
    {
        List<Observation.ComponentComponent> a_ = Result?.Component;
        bool? b_(Observation.ComponentComponent C)
        {
            Code<ObservationStatus> h_ = Result?.StatusElement;
            ObservationStatus? i_ = h_?.Value;
            string j_ = context.Operators.Convert<string>(i_);
            string[] k_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? l_ = context.Operators.In<string>(j_, (IEnumerable<string>)k_);
            CodeableConcept m_ = C?.Code;
            CqlConcept n_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, m_);
            CqlCode o_ = this.Calculated_CT_size_adjusted_dose(context);
            CqlConcept p_ = context.Operators.ConvertCodeToConcept(o_);
            bool? q_ = context.Operators.Equivalent(n_, p_);
            bool? r_ = context.Operators.And(l_, q_);
            DataType s_ = C?.Value;
            object t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
            string u_ = (t_ as CqlQuantity)?.unit;
            bool? v_ = context.Operators.Equal(u_, "mGy.cm");
            bool? w_ = context.Operators.And(r_, v_);

            return w_;
        };
        IEnumerable<Observation.ComponentComponent> c_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)a_, b_);
        decimal? d_(Observation.ComponentComponent C)
        {
            DataType x_ = C?.Value;
            object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
            decimal? z_ = (y_ as CqlQuantity)?.value;

            return z_;
        };
        IEnumerable<decimal?> e_ = context.Operators.Select<Observation.ComponentComponent, decimal?>(c_, d_);
        IEnumerable<decimal?> f_ = context.Operators.Distinct<decimal?>(e_);
        decimal? g_ = context.Operators.SingletonFrom<decimal?>(f_);

        return g_;
    }


    #endregion Functions and Expressions

}
