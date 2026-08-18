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
[CqlLibrary("AlaraCommonFunctions", "1.10.000")]
public partial class AlaraCommonFunctions_1_10_000 : ILibrary, ISingleton<AlaraCommonFunctions_1_10_000>
{
    #region Codes (20)

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

    #region CodeSystems (1)

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

    #region Functions and Expressions (9)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = 4553600017420016945L;

    private Patient Patient_Compute(CqlContext context)
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
        CqlBoolean d_ = this.qualifies(context, Result, a_, b_, c_);
        CqlCode e_ = this.Abdomen_and_Pelvis_Routine_Dose(context);
        decimal? f_ = context.Operators.ConvertIntegerToDecimal(29);
        decimal? g_ = context.Operators.ConvertIntegerToDecimal(644);
        CqlBoolean h_ = this.qualifies(context, Result, e_, f_, g_);
        CqlBoolean i_ = h_;
        CqlCode j_ = this.Abdomen_and_Pelvis_High_Dose(context);
        decimal? k_ = context.Operators.ConvertIntegerToDecimal(1260);
        CqlBoolean l_ = this.qualifies(context, Result, j_, f_, k_);
        CqlBoolean m_ = l_;
        CqlCode n_ = this.Cardiac_Low_Dose(context);
        decimal? o_ = context.Operators.ConvertIntegerToDecimal(55);
        decimal? p_ = context.Operators.ConvertIntegerToDecimal(93);
        CqlBoolean q_ = this.qualifies(context, Result, n_, o_, p_);
        CqlBoolean r_ = q_;
        CqlCode s_ = this.Cardiac_Routine_Dose(context);
        decimal? t_ = context.Operators.ConvertIntegerToDecimal(32);
        decimal? u_ = context.Operators.ConvertIntegerToDecimal(576);
        CqlBoolean v_ = this.qualifies(context, Result, s_, t_, u_);
        CqlBoolean w_ = v_;
        CqlCode x_ = this.Chest_Low_Dose(context);
        decimal? y_ = context.Operators.ConvertIntegerToDecimal(377);
        CqlBoolean z_ = this.qualifies(context, Result, x_, o_, y_);
        CqlBoolean aa_ = z_;
        CqlCode ab_ = this.Chest_Routine_Dose(context);
        decimal? ac_ = context.Operators.ConvertIntegerToDecimal(49);
        CqlBoolean ad_ = this.qualifies(context, Result, ab_, ac_, y_);
        CqlBoolean ae_ = ad_;
        CqlCode af_ = this.Cardiac_High_Dose_or_Chest_High_Dose(context);
        decimal? ag_ = context.Operators.ConvertIntegerToDecimal(1282);
        CqlBoolean ah_ = this.qualifies(context, Result, af_, ac_, ag_);
        CqlBoolean ai_ = ah_;
        CqlCode aj_ = this.Head_Low_Dose(context);
        decimal? ak_ = context.Operators.ConvertIntegerToDecimal(115);
        decimal? al_ = context.Operators.ConvertIntegerToDecimal(582);
        CqlBoolean am_ = this.qualifies(context, Result, aj_, ak_, al_);
        CqlBoolean an_ = am_;
        CqlCode ao_ = this.Head_Routine_Dose(context);
        decimal? ap_ = context.Operators.ConvertIntegerToDecimal(1025);
        CqlBoolean aq_ = this.qualifies(context, Result, ao_, ak_, ap_);
        CqlBoolean ar_ = aq_;
        CqlCode as_ = this.Head_High_Dose(context);
        decimal? at_ = context.Operators.ConvertIntegerToDecimal(1832);
        CqlBoolean au_ = this.qualifies(context, Result, as_, ak_, at_);
        CqlBoolean av_ = au_;
        CqlCode aw_ = this.Extremity(context);
        decimal? ax_ = context.Operators.ConvertIntegerToDecimal(73);
        decimal? ay_ = context.Operators.ConvertIntegerToDecimal(320);
        CqlBoolean az_ = this.qualifies(context, Result, aw_, ax_, ay_);
        CqlBoolean ba_ = az_;
        CqlCode bb_ = this.Neck_or_Cervical_Spine(context);
        decimal? bc_ = context.Operators.ConvertIntegerToDecimal(25);
        CqlBoolean bd_ = this.qualifies(context, Result, bb_, bc_, k_);
        CqlBoolean be_ = bd_;
        CqlCode bf_ = this.Thoracic_or_Lumbar_Spine(context);
        CqlBoolean bg_ = this.qualifies(context, Result, bf_, bc_, k_);
        CqlBoolean bh_ = bg_;
        CqlCode bi_ = this.Simultaneous_Chest_and_Abdomen_and_Pelvis(context);
        decimal? bj_ = context.Operators.ConvertIntegerToDecimal(1637);
        CqlBoolean bk_ = this.qualifies(context, Result, bi_, f_, bj_);
        CqlBoolean bl_ = bk_;
        CqlCode bm_ = this.Simultaneous_Thoracic_and_Lumbar_Spine(context);
        decimal? bn_ = context.Operators.ConvertIntegerToDecimal(2520);
        CqlBoolean bo_ = this.qualifies(context, Result, bm_, bc_, bn_);
        CqlBoolean bp_ = bo_;
        CqlCode bq_ = this.Simultaneous_Head_and_Neck_Routine_Dose(context);
        decimal? br_ = context.Operators.ConvertIntegerToDecimal(2285);
        CqlBoolean bs_ = this.qualifies(context, Result, bq_, bc_, br_);
        CqlBoolean bt_ = bs_;
        CqlCode bu_ = this.Simultaneous_Head_and_Neck_High_Dose(context);
        decimal? bv_ = context.Operators.ConvertIntegerToDecimal(3092);
        CqlBoolean bw_ = this.qualifies(context, Result, bu_, bc_, bv_);
        CqlBoolean bx_ = bw_;
        return d_
            /* CQL 'or' (33:3-34:67) */ || i_
            /* CQL 'or' (33:3-35:65) */ || m_
            /* CQL 'or' (33:3-36:51) */ || r_
            /* CQL 'or' (33:3-37:56) */ || w_
            /* CQL 'or' (33:3-38:50) */ || aa_
            /* CQL 'or' (33:3-39:54) */ || ae_
            /* CQL 'or' (33:3-40:73) */ || ai_
            /* CQL 'or' (33:3-41:50) */ || an_
            /* CQL 'or' (33:3-42:55) */ || ar_
            /* CQL 'or' (33:3-43:52) */ || av_
            /* CQL 'or' (33:3-44:45) */ || ba_
            /* CQL 'or' (33:3-45:59) */ || be_
            /* CQL 'or' (33:3-46:61) */ || bh_
            /* CQL 'or' (33:3-47:78) */ || bl_
            /* CQL 'or' (33:3-48:75) */ || bp_
            /* CQL 'or' (33:3-49:76) */ || bt_
            /* CQL 'or' (33:3-50:73) */ || bx_;
    }


    [CqlFunctionDefinition("qualifies")]
    public bool? qualifies(CqlContext context, Observation Result, CqlCode code, decimal? noiseThreshold, decimal? sizeDoseThreshold)
    {
        DataType a_ = Result?.Value;
        object b_ = FHIRHelpers_4_4_000.Instance.ToValue(context, a_);
        CqlConcept c_ = context.Operators.ConvertCodeToConcept(code);
        CqlBoolean d_ = context.Operators.Equivalent(b_ as CqlConcept, c_);
        decimal? e_ = this.globalNoiseValue(context, Result);
        CqlBoolean f_ = context.Operators.GreaterOrEqual(e_, noiseThreshold);
        decimal? g_ = this.sizeAdjustedValue(context, Result);
        CqlBoolean h_ = context.Operators.GreaterOrEqual(g_, sizeDoseThreshold);
        CqlBoolean i_ = h_;
        CqlBoolean j_ = f_
            /* CQL 'or' (80:9-82:5) */ || i_;
        return d_
            /* CQL 'and' (79:3-82:5) */ && j_;
    }


    [CqlFunctionDefinition("globalNoiseValue")]
    public decimal? globalNoiseValue(CqlContext context, Observation Result)
    {
        List<Observation.ComponentComponent> a_ = Result?.Component;

        bool? b_(Observation.ComponentComponent C) {
            Code<ObservationStatus> g_ = Result?.StatusElement;
            ObservationStatus? h_ = g_?.Value;
            string i_ = context.Operators.Convert<string>(h_);
            string[] j_ = [
                "final",
                "amended",
                "corrected",
            ];
            CqlBoolean k_ = context.Operators.In<string>(i_, (IEnumerable<string>)j_);
            CodeableConcept l_ = C?.Code;
            CqlConcept m_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, l_);
            CqlCode n_ = this.Calculated_CT_global_noise(context);
            CqlConcept o_ = context.Operators.ConvertCodeToConcept(n_);
            CqlBoolean p_ = context.Operators.Equivalent(m_, o_);
            CqlBoolean q_ = p_;
            DataType r_ = C?.Value;
            object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
            string t_ = (s_ as CqlQuantity)?.unit;
            CqlBoolean u_ = context.Operators.Equal(t_, "[hnsf'U]");
            CqlBoolean v_ = u_;
            return k_
                /* CQL 'and' (96:13-97:49) */ && q_
                /* CQL 'and' (96:7-98:54) */ && v_;
        }


        decimal? c_(Observation.ComponentComponent C) {
            DataType w_ = C?.Value;
            object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
            decimal? y_ = (x_ as CqlQuantity)?.value;
            return y_;
        }

        IEnumerable<decimal?> d_ = context.Operators.WhereSelect<Observation.ComponentComponent, decimal?>((IEnumerable<Observation.ComponentComponent>)a_, b_, c_);
        IEnumerable<decimal?> e_ = context.Operators.Distinct<decimal?>(d_);
        decimal? f_ = context.Operators.SingletonFrom<decimal?>(e_);
        return f_;
    }


    [CqlFunctionDefinition("sizeAdjustedValue")]
    public decimal? sizeAdjustedValue(CqlContext context, Observation Result)
    {
        List<Observation.ComponentComponent> a_ = Result?.Component;

        bool? b_(Observation.ComponentComponent C) {
            Code<ObservationStatus> g_ = Result?.StatusElement;
            ObservationStatus? h_ = g_?.Value;
            string i_ = context.Operators.Convert<string>(h_);
            string[] j_ = [
                "final",
                "amended",
                "corrected",
            ];
            CqlBoolean k_ = context.Operators.In<string>(i_, (IEnumerable<string>)j_);
            CodeableConcept l_ = C?.Code;
            CqlConcept m_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, l_);
            CqlCode n_ = this.Calculated_CT_size_adjusted_dose(context);
            CqlConcept o_ = context.Operators.ConvertCodeToConcept(n_);
            CqlBoolean p_ = context.Operators.Equivalent(m_, o_);
            CqlBoolean q_ = p_;
            DataType r_ = C?.Value;
            object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
            string t_ = (s_ as CqlQuantity)?.unit;
            CqlBoolean u_ = context.Operators.Equal(t_, "mGy.cm");
            CqlBoolean v_ = u_;
            return k_
                /* CQL 'and' (112:13-113:55) */ && q_
                /* CQL 'and' (112:7-114:51) */ && v_;
        }


        decimal? c_(Observation.ComponentComponent C) {
            DataType w_ = C?.Value;
            object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
            decimal? y_ = (x_ as CqlQuantity)?.value;
            return y_;
        }

        IEnumerable<decimal?> d_ = context.Operators.WhereSelect<Observation.ComponentComponent, decimal?>((IEnumerable<Observation.ComponentComponent>)a_, b_, c_);
        IEnumerable<decimal?> e_ = context.Operators.Distinct<decimal?>(d_);
        decimal? f_ = context.Operators.SingletonFrom<decimal?>(e_);
        return f_;
    }


    [CqlFunctionDefinition("ctScanQualifies")]
    public bool? ctScanQualifies(CqlContext context, Observation Result)
    {
        CqlCode a_ = this.Abdomen_and_Pelvis_Low_Dose(context);
        decimal? b_ = context.Operators.ConvertIntegerToDecimal(64);
        decimal? c_ = context.Operators.ConvertIntegerToDecimal(598);
        CqlBoolean d_ = this.qualifies(context, Result, a_, b_, c_);
        CqlCode e_ = this.Abdomen_and_Pelvis_Routine_Dose(context);
        decimal? f_ = context.Operators.ConvertIntegerToDecimal(29);
        decimal? g_ = context.Operators.ConvertIntegerToDecimal(644);
        CqlBoolean h_ = this.qualifies(context, Result, e_, f_, g_);
        CqlBoolean i_ = h_;
        CqlCode j_ = this.Abdomen_and_Pelvis_High_Dose(context);
        decimal? k_ = context.Operators.ConvertIntegerToDecimal(1260);
        CqlBoolean l_ = this.qualifies(context, Result, j_, f_, k_);
        CqlBoolean m_ = l_;
        CqlCode n_ = this.Cardiac_Low_Dose(context);
        decimal? o_ = context.Operators.ConvertIntegerToDecimal(55);
        decimal? p_ = context.Operators.ConvertIntegerToDecimal(93);
        CqlBoolean q_ = this.qualifies(context, Result, n_, o_, p_);
        CqlBoolean r_ = q_;
        CqlCode s_ = this.Cardiac_Routine_Dose(context);
        decimal? t_ = context.Operators.ConvertIntegerToDecimal(32);
        decimal? u_ = context.Operators.ConvertIntegerToDecimal(576);
        CqlBoolean v_ = this.qualifies(context, Result, s_, t_, u_);
        CqlBoolean w_ = v_;
        CqlCode x_ = this.Chest_Low_Dose(context);
        decimal? y_ = context.Operators.ConvertIntegerToDecimal(377);
        CqlBoolean z_ = this.qualifies(context, Result, x_, o_, y_);
        CqlBoolean aa_ = z_;
        CqlCode ab_ = this.Chest_Routine_Dose(context);
        decimal? ac_ = context.Operators.ConvertIntegerToDecimal(49);
        CqlBoolean ad_ = this.qualifies(context, Result, ab_, ac_, y_);
        CqlBoolean ae_ = ad_;
        CqlCode af_ = this.Cardiac_High_Dose_or_Chest_High_Dose(context);
        decimal? ag_ = context.Operators.ConvertIntegerToDecimal(1282);
        CqlBoolean ah_ = this.qualifies(context, Result, af_, ac_, ag_);
        CqlBoolean ai_ = ah_;
        CqlCode aj_ = this.Head_Low_Dose(context);
        decimal? ak_ = context.Operators.ConvertIntegerToDecimal(115);
        decimal? al_ = context.Operators.ConvertIntegerToDecimal(582);
        CqlBoolean am_ = this.qualifies(context, Result, aj_, ak_, al_);
        CqlBoolean an_ = am_;
        CqlCode ao_ = this.Head_Routine_Dose(context);
        decimal? ap_ = context.Operators.ConvertIntegerToDecimal(1025);
        CqlBoolean aq_ = this.qualifies(context, Result, ao_, ak_, ap_);
        CqlBoolean ar_ = aq_;
        CqlCode as_ = this.Head_High_Dose(context);
        decimal? at_ = context.Operators.ConvertIntegerToDecimal(1832);
        CqlBoolean au_ = this.qualifies(context, Result, as_, ak_, at_);
        CqlBoolean av_ = au_;
        CqlCode aw_ = this.Extremity(context);
        decimal? ax_ = context.Operators.ConvertIntegerToDecimal(73);
        decimal? ay_ = context.Operators.ConvertIntegerToDecimal(320);
        CqlBoolean az_ = this.qualifies(context, Result, aw_, ax_, ay_);
        CqlBoolean ba_ = az_;
        CqlCode bb_ = this.Neck_or_Cervical_Spine(context);
        decimal? bc_ = context.Operators.ConvertIntegerToDecimal(25);
        CqlBoolean bd_ = this.qualifies(context, Result, bb_, bc_, k_);
        CqlBoolean be_ = bd_;
        CqlCode bf_ = this.Thoracic_or_Lumbar_Spine(context);
        CqlBoolean bg_ = this.qualifies(context, Result, bf_, bc_, k_);
        CqlBoolean bh_ = bg_;
        CqlCode bi_ = this.Simultaneous_Chest_and_Abdomen_and_Pelvis(context);
        decimal? bj_ = context.Operators.ConvertIntegerToDecimal(1637);
        CqlBoolean bk_ = this.qualifies(context, Result, bi_, f_, bj_);
        CqlBoolean bl_ = bk_;
        CqlCode bm_ = this.Simultaneous_Thoracic_and_Lumbar_Spine(context);
        decimal? bn_ = context.Operators.ConvertIntegerToDecimal(2520);
        CqlBoolean bo_ = this.qualifies(context, Result, bm_, bc_, bn_);
        CqlBoolean bp_ = bo_;
        CqlCode bq_ = this.Simultaneous_Head_and_Neck_Routine_Dose(context);
        decimal? br_ = context.Operators.ConvertIntegerToDecimal(2285);
        CqlBoolean bs_ = this.qualifies(context, Result, bq_, bc_, br_);
        CqlBoolean bt_ = bs_;
        CqlCode bu_ = this.Simultaneous_Head_and_Neck_High_Dose(context);
        decimal? bv_ = context.Operators.ConvertIntegerToDecimal(3092);
        CqlBoolean bw_ = this.qualifies(context, Result, bu_, bc_, bv_);
        CqlBoolean bx_ = bw_;
        return d_
            /* CQL 'or' (53:3-54:67) */ || i_
            /* CQL 'or' (53:3-55:65) */ || m_
            /* CQL 'or' (53:3-56:51) */ || r_
            /* CQL 'or' (53:3-57:56) */ || w_
            /* CQL 'or' (53:3-58:50) */ || aa_
            /* CQL 'or' (53:3-59:54) */ || ae_
            /* CQL 'or' (53:3-60:73) */ || ai_
            /* CQL 'or' (53:3-61:50) */ || an_
            /* CQL 'or' (53:3-62:55) */ || ar_
            /* CQL 'or' (53:3-63:52) */ || av_
            /* CQL 'or' (53:3-64:45) */ || ba_
            /* CQL 'or' (53:3-65:59) */ || be_
            /* CQL 'or' (53:3-66:61) */ || bh_
            /* CQL 'or' (53:3-67:78) */ || bl_
            /* CQL 'or' (53:3-68:75) */ || bp_
            /* CQL 'or' (53:3-69:76) */ || bt_
            /* CQL 'or' (53:3-70:73) */ || bx_;
    }


    [CqlFunctionDefinition("Qualifies")]
    public bool? Qualifies(CqlContext context, Observation Result, CqlCode code, decimal? noiseThreshold, decimal? sizeDoseThreshold)
    {
        DataType a_ = Result?.Value;
        object b_ = FHIRHelpers_4_4_000.Instance.ToValue(context, a_);
        CqlConcept c_ = context.Operators.ConvertCodeToConcept(code);
        CqlBoolean d_ = context.Operators.Equivalent(b_ as CqlConcept, c_);
        decimal? e_ = this.Global_Noise_Value(context, Result);
        CqlBoolean f_ = context.Operators.GreaterOrEqual(e_, noiseThreshold);
        decimal? g_ = this.Size_Adjusted_Value(context, Result);
        CqlBoolean h_ = context.Operators.GreaterOrEqual(g_, sizeDoseThreshold);
        CqlBoolean i_ = h_;
        CqlBoolean j_ = f_
            /* CQL 'or' (74:9-76:5) */ || i_;
        return d_
            /* CQL 'and' (73:3-76:5) */ && j_;
    }


    [CqlFunctionDefinition("Global Noise Value")]
    public decimal? Global_Noise_Value(CqlContext context, Observation Result)
    {
        List<Observation.ComponentComponent> a_ = Result?.Component;

        bool? b_(Observation.ComponentComponent C) {
            Code<ObservationStatus> g_ = Result?.StatusElement;
            ObservationStatus? h_ = g_?.Value;
            string i_ = context.Operators.Convert<string>(h_);
            string[] j_ = [
                "final",
                "amended",
                "corrected",
            ];
            CqlBoolean k_ = context.Operators.In<string>(i_, (IEnumerable<string>)j_);
            CodeableConcept l_ = C?.Code;
            CqlConcept m_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, l_);
            CqlCode n_ = this.Calculated_CT_global_noise(context);
            CqlConcept o_ = context.Operators.ConvertCodeToConcept(n_);
            CqlBoolean p_ = context.Operators.Equivalent(m_, o_);
            CqlBoolean q_ = p_;
            DataType r_ = C?.Value;
            object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
            string t_ = (s_ as CqlQuantity)?.unit;
            CqlBoolean u_ = context.Operators.Equal(t_, "[hnsf'U]");
            CqlBoolean v_ = u_;
            return k_
                /* CQL 'and' (87:13-88:49) */ && q_
                /* CQL 'and' (87:7-89:54) */ && v_;
        }


        decimal? c_(Observation.ComponentComponent C) {
            DataType w_ = C?.Value;
            object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
            decimal? y_ = (x_ as CqlQuantity)?.value;
            return y_;
        }

        IEnumerable<decimal?> d_ = context.Operators.WhereSelect<Observation.ComponentComponent, decimal?>((IEnumerable<Observation.ComponentComponent>)a_, b_, c_);
        IEnumerable<decimal?> e_ = context.Operators.Distinct<decimal?>(d_);
        decimal? f_ = context.Operators.SingletonFrom<decimal?>(e_);
        return f_;
    }


    [CqlFunctionDefinition("Size Adjusted Value")]
    public decimal? Size_Adjusted_Value(CqlContext context, Observation Result)
    {
        List<Observation.ComponentComponent> a_ = Result?.Component;

        bool? b_(Observation.ComponentComponent C) {
            Code<ObservationStatus> g_ = Result?.StatusElement;
            ObservationStatus? h_ = g_?.Value;
            string i_ = context.Operators.Convert<string>(h_);
            string[] j_ = [
                "final",
                "amended",
                "corrected",
            ];
            CqlBoolean k_ = context.Operators.In<string>(i_, (IEnumerable<string>)j_);
            CodeableConcept l_ = C?.Code;
            CqlConcept m_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, l_);
            CqlCode n_ = this.Calculated_CT_size_adjusted_dose(context);
            CqlConcept o_ = context.Operators.ConvertCodeToConcept(n_);
            CqlBoolean p_ = context.Operators.Equivalent(m_, o_);
            CqlBoolean q_ = p_;
            DataType r_ = C?.Value;
            object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
            string t_ = (s_ as CqlQuantity)?.unit;
            CqlBoolean u_ = context.Operators.Equal(t_, "mGy.cm");
            CqlBoolean v_ = u_;
            return k_
                /* CQL 'and' (104:13-105:55) */ && q_
                /* CQL 'and' (104:7-106:51) */ && v_;
        }


        decimal? c_(Observation.ComponentComponent C) {
            DataType w_ = C?.Value;
            object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
            decimal? y_ = (x_ as CqlQuantity)?.value;
            return y_;
        }

        IEnumerable<decimal?> d_ = context.Operators.WhereSelect<Observation.ComponentComponent, decimal?>((IEnumerable<Observation.ComponentComponent>)a_, b_, c_);
        IEnumerable<decimal?> e_ = context.Operators.Distinct<decimal?>(d_);
        decimal? f_ = context.Operators.SingletonFrom<decimal?>(e_);
        return f_;
    }


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private AlaraCommonFunctions_1_10_000() {}

    public static AlaraCommonFunctions_1_10_000 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "AlaraCommonFunctions";
    public string Version => "1.10.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance];

    #endregion ILibrary Implementation

}
