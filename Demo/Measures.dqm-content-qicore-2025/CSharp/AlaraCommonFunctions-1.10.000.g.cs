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
        bool? d_ = this.qualifies(context, Result, a_, b_, c_);
        bool? e_;
        // CQL 'or' (33:3-34:67): right operand skipped when left is true
        if (d_ is true)
        {
            e_ = true;
        }
        else
        {
            CqlCode u_ = this.Abdomen_and_Pelvis_Routine_Dose(context);
            decimal? v_ = context.Operators.ConvertIntegerToDecimal(29);
            decimal? w_ = context.Operators.ConvertIntegerToDecimal(644);
            bool? x_ = this.qualifies(context, Result, u_, v_, w_);
            e_ = d_ | x_;
        }
        bool? f_;
        // CQL 'or' (33:3-35:65): right operand skipped when left is true
        if (e_ is true)
        {
            f_ = true;
        }
        else
        {
            CqlCode y_ = this.Abdomen_and_Pelvis_High_Dose(context);
            decimal? z_ = context.Operators.ConvertIntegerToDecimal(29);
            decimal? aa_ = context.Operators.ConvertIntegerToDecimal(1260);
            bool? ab_ = this.qualifies(context, Result, y_, z_, aa_);
            f_ = e_ | ab_;
        }
        bool? g_;
        // CQL 'or' (33:3-36:51): right operand skipped when left is true
        if (f_ is true)
        {
            g_ = true;
        }
        else
        {
            CqlCode ac_ = this.Cardiac_Low_Dose(context);
            decimal? ad_ = context.Operators.ConvertIntegerToDecimal(55);
            decimal? ae_ = context.Operators.ConvertIntegerToDecimal(93);
            bool? af_ = this.qualifies(context, Result, ac_, ad_, ae_);
            g_ = f_ | af_;
        }
        bool? h_;
        // CQL 'or' (33:3-37:56): right operand skipped when left is true
        if (g_ is true)
        {
            h_ = true;
        }
        else
        {
            CqlCode ag_ = this.Cardiac_Routine_Dose(context);
            decimal? ah_ = context.Operators.ConvertIntegerToDecimal(32);
            decimal? ai_ = context.Operators.ConvertIntegerToDecimal(576);
            bool? aj_ = this.qualifies(context, Result, ag_, ah_, ai_);
            h_ = g_ | aj_;
        }
        bool? i_;
        // CQL 'or' (33:3-38:50): right operand skipped when left is true
        if (h_ is true)
        {
            i_ = true;
        }
        else
        {
            CqlCode ak_ = this.Chest_Low_Dose(context);
            decimal? al_ = context.Operators.ConvertIntegerToDecimal(55);
            decimal? am_ = context.Operators.ConvertIntegerToDecimal(377);
            bool? an_ = this.qualifies(context, Result, ak_, al_, am_);
            i_ = h_ | an_;
        }
        bool? j_;
        // CQL 'or' (33:3-39:54): right operand skipped when left is true
        if (i_ is true)
        {
            j_ = true;
        }
        else
        {
            CqlCode ao_ = this.Chest_Routine_Dose(context);
            decimal? ap_ = context.Operators.ConvertIntegerToDecimal(49);
            decimal? aq_ = context.Operators.ConvertIntegerToDecimal(377);
            bool? ar_ = this.qualifies(context, Result, ao_, ap_, aq_);
            j_ = i_ | ar_;
        }
        bool? k_;
        // CQL 'or' (33:3-40:73): right operand skipped when left is true
        if (j_ is true)
        {
            k_ = true;
        }
        else
        {
            CqlCode as_ = this.Cardiac_High_Dose_or_Chest_High_Dose(context);
            decimal? at_ = context.Operators.ConvertIntegerToDecimal(49);
            decimal? au_ = context.Operators.ConvertIntegerToDecimal(1282);
            bool? av_ = this.qualifies(context, Result, as_, at_, au_);
            k_ = j_ | av_;
        }
        bool? l_;
        // CQL 'or' (33:3-41:50): right operand skipped when left is true
        if (k_ is true)
        {
            l_ = true;
        }
        else
        {
            CqlCode aw_ = this.Head_Low_Dose(context);
            decimal? ax_ = context.Operators.ConvertIntegerToDecimal(115);
            decimal? ay_ = context.Operators.ConvertIntegerToDecimal(582);
            bool? az_ = this.qualifies(context, Result, aw_, ax_, ay_);
            l_ = k_ | az_;
        }
        bool? m_;
        // CQL 'or' (33:3-42:55): right operand skipped when left is true
        if (l_ is true)
        {
            m_ = true;
        }
        else
        {
            CqlCode ba_ = this.Head_Routine_Dose(context);
            decimal? bb_ = context.Operators.ConvertIntegerToDecimal(115);
            decimal? bc_ = context.Operators.ConvertIntegerToDecimal(1025);
            bool? bd_ = this.qualifies(context, Result, ba_, bb_, bc_);
            m_ = l_ | bd_;
        }
        bool? n_;
        // CQL 'or' (33:3-43:52): right operand skipped when left is true
        if (m_ is true)
        {
            n_ = true;
        }
        else
        {
            CqlCode be_ = this.Head_High_Dose(context);
            decimal? bf_ = context.Operators.ConvertIntegerToDecimal(115);
            decimal? bg_ = context.Operators.ConvertIntegerToDecimal(1832);
            bool? bh_ = this.qualifies(context, Result, be_, bf_, bg_);
            n_ = m_ | bh_;
        }
        bool? o_;
        // CQL 'or' (33:3-44:45): right operand skipped when left is true
        if (n_ is true)
        {
            o_ = true;
        }
        else
        {
            CqlCode bi_ = this.Extremity(context);
            decimal? bj_ = context.Operators.ConvertIntegerToDecimal(73);
            decimal? bk_ = context.Operators.ConvertIntegerToDecimal(320);
            bool? bl_ = this.qualifies(context, Result, bi_, bj_, bk_);
            o_ = n_ | bl_;
        }
        bool? p_;
        // CQL 'or' (33:3-45:59): right operand skipped when left is true
        if (o_ is true)
        {
            p_ = true;
        }
        else
        {
            CqlCode bm_ = this.Neck_or_Cervical_Spine(context);
            decimal? bn_ = context.Operators.ConvertIntegerToDecimal(25);
            decimal? bo_ = context.Operators.ConvertIntegerToDecimal(1260);
            bool? bp_ = this.qualifies(context, Result, bm_, bn_, bo_);
            p_ = o_ | bp_;
        }
        bool? q_;
        // CQL 'or' (33:3-46:61): right operand skipped when left is true
        if (p_ is true)
        {
            q_ = true;
        }
        else
        {
            CqlCode bq_ = this.Thoracic_or_Lumbar_Spine(context);
            decimal? br_ = context.Operators.ConvertIntegerToDecimal(25);
            decimal? bs_ = context.Operators.ConvertIntegerToDecimal(1260);
            bool? bt_ = this.qualifies(context, Result, bq_, br_, bs_);
            q_ = p_ | bt_;
        }
        bool? r_;
        // CQL 'or' (33:3-47:78): right operand skipped when left is true
        if (q_ is true)
        {
            r_ = true;
        }
        else
        {
            CqlCode bu_ = this.Simultaneous_Chest_and_Abdomen_and_Pelvis(context);
            decimal? bv_ = context.Operators.ConvertIntegerToDecimal(29);
            decimal? bw_ = context.Operators.ConvertIntegerToDecimal(1637);
            bool? bx_ = this.qualifies(context, Result, bu_, bv_, bw_);
            r_ = q_ | bx_;
        }
        bool? s_;
        // CQL 'or' (33:3-48:75): right operand skipped when left is true
        if (r_ is true)
        {
            s_ = true;
        }
        else
        {
            CqlCode by_ = this.Simultaneous_Thoracic_and_Lumbar_Spine(context);
            decimal? bz_ = context.Operators.ConvertIntegerToDecimal(25);
            decimal? ca_ = context.Operators.ConvertIntegerToDecimal(2520);
            bool? cb_ = this.qualifies(context, Result, by_, bz_, ca_);
            s_ = r_ | cb_;
        }
        bool? t_;
        // CQL 'or' (33:3-49:76): right operand skipped when left is true
        if (s_ is true)
        {
            t_ = true;
        }
        else
        {
            CqlCode cc_ = this.Simultaneous_Head_and_Neck_Routine_Dose(context);
            decimal? cd_ = context.Operators.ConvertIntegerToDecimal(25);
            decimal? ce_ = context.Operators.ConvertIntegerToDecimal(2285);
            bool? cf_ = this.qualifies(context, Result, cc_, cd_, ce_);
            t_ = s_ | cf_;
        }
        // CQL 'or' (33:3-50:73): right operand skipped when left is true
        if (t_ is true)
        {
            return true;
        }
        else
        {
            CqlCode cg_ = this.Simultaneous_Head_and_Neck_High_Dose(context);
            decimal? ch_ = context.Operators.ConvertIntegerToDecimal(25);
            decimal? ci_ = context.Operators.ConvertIntegerToDecimal(3092);
            bool? cj_ = this.qualifies(context, Result, cg_, ch_, ci_);
            return t_ | cj_;
        }
    }


    [CqlFunctionDefinition("qualifies")]
    public bool? qualifies(CqlContext context, Observation Result, CqlCode code, decimal? noiseThreshold, decimal? sizeDoseThreshold)
    {
        DataType a_ = Result?.Value;
        object b_ = FHIRHelpers_4_4_000.Instance.ToValue(context, a_);
        CqlConcept c_ = context.Operators.ConvertCodeToConcept(code);
        bool? d_ = context.Operators.Equivalent(b_ as CqlConcept, c_);
        // CQL 'and' (79:3-82:5): right operand skipped when left is false
        if (d_ is false)
        {
            return false;
        }
        else
        {
            decimal? e_ = this.globalNoiseValue(context, Result);
            bool? f_ = context.Operators.GreaterOrEqual(e_, noiseThreshold);
            bool? g_;
            // CQL 'or' (80:9-82:5): right operand skipped when left is true
            if (f_ is true)
            {
                g_ = true;
            }
            else
            {
                decimal? h_ = this.sizeAdjustedValue(context, Result);
                bool? i_ = context.Operators.GreaterOrEqual(h_, sizeDoseThreshold);
                g_ = f_ | i_;
            }
            return d_ & g_;
        }
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
            bool? k_ = context.Operators.In<string>(i_, (IEnumerable<string>)j_);
            bool? l_;
            // CQL 'and' (96:13-97:49): right operand skipped when left is false
            if (k_ is false)
            {
                l_ = false;
            }
            else
            {
                CodeableConcept m_ = C?.Code;
                CqlConcept n_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, m_);
                CqlCode o_ = this.Calculated_CT_global_noise(context);
                CqlConcept p_ = context.Operators.ConvertCodeToConcept(o_);
                bool? q_ = context.Operators.Equivalent(n_, p_);
                l_ = k_ & q_;
            }
            // CQL 'and' (96:7-98:54): right operand skipped when left is false
            if (l_ is false)
            {
                return false;
            }
            else
            {
                DataType r_ = C?.Value;
                object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
                string t_ = (s_ as CqlQuantity)?.unit;
                bool? u_ = context.Operators.Equal(t_, "[hnsf'U]");
                return l_ & u_;
            }
        }


        decimal? c_(Observation.ComponentComponent C) {
            DataType v_ = C?.Value;
            object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
            decimal? x_ = (w_ as CqlQuantity)?.value;
            return x_;
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
            bool? k_ = context.Operators.In<string>(i_, (IEnumerable<string>)j_);
            bool? l_;
            // CQL 'and' (112:13-113:55): right operand skipped when left is false
            if (k_ is false)
            {
                l_ = false;
            }
            else
            {
                CodeableConcept m_ = C?.Code;
                CqlConcept n_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, m_);
                CqlCode o_ = this.Calculated_CT_size_adjusted_dose(context);
                CqlConcept p_ = context.Operators.ConvertCodeToConcept(o_);
                bool? q_ = context.Operators.Equivalent(n_, p_);
                l_ = k_ & q_;
            }
            // CQL 'and' (112:7-114:51): right operand skipped when left is false
            if (l_ is false)
            {
                return false;
            }
            else
            {
                DataType r_ = C?.Value;
                object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
                string t_ = (s_ as CqlQuantity)?.unit;
                bool? u_ = context.Operators.Equal(t_, "mGy.cm");
                return l_ & u_;
            }
        }


        decimal? c_(Observation.ComponentComponent C) {
            DataType v_ = C?.Value;
            object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
            decimal? x_ = (w_ as CqlQuantity)?.value;
            return x_;
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
        bool? d_ = this.qualifies(context, Result, a_, b_, c_);
        bool? e_;
        // CQL 'or' (53:3-54:67): right operand skipped when left is true
        if (d_ is true)
        {
            e_ = true;
        }
        else
        {
            CqlCode u_ = this.Abdomen_and_Pelvis_Routine_Dose(context);
            decimal? v_ = context.Operators.ConvertIntegerToDecimal(29);
            decimal? w_ = context.Operators.ConvertIntegerToDecimal(644);
            bool? x_ = this.qualifies(context, Result, u_, v_, w_);
            e_ = d_ | x_;
        }
        bool? f_;
        // CQL 'or' (53:3-55:65): right operand skipped when left is true
        if (e_ is true)
        {
            f_ = true;
        }
        else
        {
            CqlCode y_ = this.Abdomen_and_Pelvis_High_Dose(context);
            decimal? z_ = context.Operators.ConvertIntegerToDecimal(29);
            decimal? aa_ = context.Operators.ConvertIntegerToDecimal(1260);
            bool? ab_ = this.qualifies(context, Result, y_, z_, aa_);
            f_ = e_ | ab_;
        }
        bool? g_;
        // CQL 'or' (53:3-56:51): right operand skipped when left is true
        if (f_ is true)
        {
            g_ = true;
        }
        else
        {
            CqlCode ac_ = this.Cardiac_Low_Dose(context);
            decimal? ad_ = context.Operators.ConvertIntegerToDecimal(55);
            decimal? ae_ = context.Operators.ConvertIntegerToDecimal(93);
            bool? af_ = this.qualifies(context, Result, ac_, ad_, ae_);
            g_ = f_ | af_;
        }
        bool? h_;
        // CQL 'or' (53:3-57:56): right operand skipped when left is true
        if (g_ is true)
        {
            h_ = true;
        }
        else
        {
            CqlCode ag_ = this.Cardiac_Routine_Dose(context);
            decimal? ah_ = context.Operators.ConvertIntegerToDecimal(32);
            decimal? ai_ = context.Operators.ConvertIntegerToDecimal(576);
            bool? aj_ = this.qualifies(context, Result, ag_, ah_, ai_);
            h_ = g_ | aj_;
        }
        bool? i_;
        // CQL 'or' (53:3-58:50): right operand skipped when left is true
        if (h_ is true)
        {
            i_ = true;
        }
        else
        {
            CqlCode ak_ = this.Chest_Low_Dose(context);
            decimal? al_ = context.Operators.ConvertIntegerToDecimal(55);
            decimal? am_ = context.Operators.ConvertIntegerToDecimal(377);
            bool? an_ = this.qualifies(context, Result, ak_, al_, am_);
            i_ = h_ | an_;
        }
        bool? j_;
        // CQL 'or' (53:3-59:54): right operand skipped when left is true
        if (i_ is true)
        {
            j_ = true;
        }
        else
        {
            CqlCode ao_ = this.Chest_Routine_Dose(context);
            decimal? ap_ = context.Operators.ConvertIntegerToDecimal(49);
            decimal? aq_ = context.Operators.ConvertIntegerToDecimal(377);
            bool? ar_ = this.qualifies(context, Result, ao_, ap_, aq_);
            j_ = i_ | ar_;
        }
        bool? k_;
        // CQL 'or' (53:3-60:73): right operand skipped when left is true
        if (j_ is true)
        {
            k_ = true;
        }
        else
        {
            CqlCode as_ = this.Cardiac_High_Dose_or_Chest_High_Dose(context);
            decimal? at_ = context.Operators.ConvertIntegerToDecimal(49);
            decimal? au_ = context.Operators.ConvertIntegerToDecimal(1282);
            bool? av_ = this.qualifies(context, Result, as_, at_, au_);
            k_ = j_ | av_;
        }
        bool? l_;
        // CQL 'or' (53:3-61:50): right operand skipped when left is true
        if (k_ is true)
        {
            l_ = true;
        }
        else
        {
            CqlCode aw_ = this.Head_Low_Dose(context);
            decimal? ax_ = context.Operators.ConvertIntegerToDecimal(115);
            decimal? ay_ = context.Operators.ConvertIntegerToDecimal(582);
            bool? az_ = this.qualifies(context, Result, aw_, ax_, ay_);
            l_ = k_ | az_;
        }
        bool? m_;
        // CQL 'or' (53:3-62:55): right operand skipped when left is true
        if (l_ is true)
        {
            m_ = true;
        }
        else
        {
            CqlCode ba_ = this.Head_Routine_Dose(context);
            decimal? bb_ = context.Operators.ConvertIntegerToDecimal(115);
            decimal? bc_ = context.Operators.ConvertIntegerToDecimal(1025);
            bool? bd_ = this.qualifies(context, Result, ba_, bb_, bc_);
            m_ = l_ | bd_;
        }
        bool? n_;
        // CQL 'or' (53:3-63:52): right operand skipped when left is true
        if (m_ is true)
        {
            n_ = true;
        }
        else
        {
            CqlCode be_ = this.Head_High_Dose(context);
            decimal? bf_ = context.Operators.ConvertIntegerToDecimal(115);
            decimal? bg_ = context.Operators.ConvertIntegerToDecimal(1832);
            bool? bh_ = this.qualifies(context, Result, be_, bf_, bg_);
            n_ = m_ | bh_;
        }
        bool? o_;
        // CQL 'or' (53:3-64:45): right operand skipped when left is true
        if (n_ is true)
        {
            o_ = true;
        }
        else
        {
            CqlCode bi_ = this.Extremity(context);
            decimal? bj_ = context.Operators.ConvertIntegerToDecimal(73);
            decimal? bk_ = context.Operators.ConvertIntegerToDecimal(320);
            bool? bl_ = this.qualifies(context, Result, bi_, bj_, bk_);
            o_ = n_ | bl_;
        }
        bool? p_;
        // CQL 'or' (53:3-65:59): right operand skipped when left is true
        if (o_ is true)
        {
            p_ = true;
        }
        else
        {
            CqlCode bm_ = this.Neck_or_Cervical_Spine(context);
            decimal? bn_ = context.Operators.ConvertIntegerToDecimal(25);
            decimal? bo_ = context.Operators.ConvertIntegerToDecimal(1260);
            bool? bp_ = this.qualifies(context, Result, bm_, bn_, bo_);
            p_ = o_ | bp_;
        }
        bool? q_;
        // CQL 'or' (53:3-66:61): right operand skipped when left is true
        if (p_ is true)
        {
            q_ = true;
        }
        else
        {
            CqlCode bq_ = this.Thoracic_or_Lumbar_Spine(context);
            decimal? br_ = context.Operators.ConvertIntegerToDecimal(25);
            decimal? bs_ = context.Operators.ConvertIntegerToDecimal(1260);
            bool? bt_ = this.qualifies(context, Result, bq_, br_, bs_);
            q_ = p_ | bt_;
        }
        bool? r_;
        // CQL 'or' (53:3-67:78): right operand skipped when left is true
        if (q_ is true)
        {
            r_ = true;
        }
        else
        {
            CqlCode bu_ = this.Simultaneous_Chest_and_Abdomen_and_Pelvis(context);
            decimal? bv_ = context.Operators.ConvertIntegerToDecimal(29);
            decimal? bw_ = context.Operators.ConvertIntegerToDecimal(1637);
            bool? bx_ = this.qualifies(context, Result, bu_, bv_, bw_);
            r_ = q_ | bx_;
        }
        bool? s_;
        // CQL 'or' (53:3-68:75): right operand skipped when left is true
        if (r_ is true)
        {
            s_ = true;
        }
        else
        {
            CqlCode by_ = this.Simultaneous_Thoracic_and_Lumbar_Spine(context);
            decimal? bz_ = context.Operators.ConvertIntegerToDecimal(25);
            decimal? ca_ = context.Operators.ConvertIntegerToDecimal(2520);
            bool? cb_ = this.qualifies(context, Result, by_, bz_, ca_);
            s_ = r_ | cb_;
        }
        bool? t_;
        // CQL 'or' (53:3-69:76): right operand skipped when left is true
        if (s_ is true)
        {
            t_ = true;
        }
        else
        {
            CqlCode cc_ = this.Simultaneous_Head_and_Neck_Routine_Dose(context);
            decimal? cd_ = context.Operators.ConvertIntegerToDecimal(25);
            decimal? ce_ = context.Operators.ConvertIntegerToDecimal(2285);
            bool? cf_ = this.qualifies(context, Result, cc_, cd_, ce_);
            t_ = s_ | cf_;
        }
        // CQL 'or' (53:3-70:73): right operand skipped when left is true
        if (t_ is true)
        {
            return true;
        }
        else
        {
            CqlCode cg_ = this.Simultaneous_Head_and_Neck_High_Dose(context);
            decimal? ch_ = context.Operators.ConvertIntegerToDecimal(25);
            decimal? ci_ = context.Operators.ConvertIntegerToDecimal(3092);
            bool? cj_ = this.qualifies(context, Result, cg_, ch_, ci_);
            return t_ | cj_;
        }
    }


    [CqlFunctionDefinition("Qualifies")]
    public bool? Qualifies(CqlContext context, Observation Result, CqlCode code, decimal? noiseThreshold, decimal? sizeDoseThreshold)
    {
        DataType a_ = Result?.Value;
        object b_ = FHIRHelpers_4_4_000.Instance.ToValue(context, a_);
        CqlConcept c_ = context.Operators.ConvertCodeToConcept(code);
        bool? d_ = context.Operators.Equivalent(b_ as CqlConcept, c_);
        // CQL 'and' (73:3-76:5): right operand skipped when left is false
        if (d_ is false)
        {
            return false;
        }
        else
        {
            decimal? e_ = this.Global_Noise_Value(context, Result);
            bool? f_ = context.Operators.GreaterOrEqual(e_, noiseThreshold);
            bool? g_;
            // CQL 'or' (74:9-76:5): right operand skipped when left is true
            if (f_ is true)
            {
                g_ = true;
            }
            else
            {
                decimal? h_ = this.Size_Adjusted_Value(context, Result);
                bool? i_ = context.Operators.GreaterOrEqual(h_, sizeDoseThreshold);
                g_ = f_ | i_;
            }
            return d_ & g_;
        }
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
            bool? k_ = context.Operators.In<string>(i_, (IEnumerable<string>)j_);
            bool? l_;
            // CQL 'and' (87:13-88:49): right operand skipped when left is false
            if (k_ is false)
            {
                l_ = false;
            }
            else
            {
                CodeableConcept m_ = C?.Code;
                CqlConcept n_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, m_);
                CqlCode o_ = this.Calculated_CT_global_noise(context);
                CqlConcept p_ = context.Operators.ConvertCodeToConcept(o_);
                bool? q_ = context.Operators.Equivalent(n_, p_);
                l_ = k_ & q_;
            }
            // CQL 'and' (87:7-89:54): right operand skipped when left is false
            if (l_ is false)
            {
                return false;
            }
            else
            {
                DataType r_ = C?.Value;
                object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
                string t_ = (s_ as CqlQuantity)?.unit;
                bool? u_ = context.Operators.Equal(t_, "[hnsf'U]");
                return l_ & u_;
            }
        }


        decimal? c_(Observation.ComponentComponent C) {
            DataType v_ = C?.Value;
            object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
            decimal? x_ = (w_ as CqlQuantity)?.value;
            return x_;
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
            bool? k_ = context.Operators.In<string>(i_, (IEnumerable<string>)j_);
            bool? l_;
            // CQL 'and' (104:13-105:55): right operand skipped when left is false
            if (k_ is false)
            {
                l_ = false;
            }
            else
            {
                CodeableConcept m_ = C?.Code;
                CqlConcept n_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, m_);
                CqlCode o_ = this.Calculated_CT_size_adjusted_dose(context);
                CqlConcept p_ = context.Operators.ConvertCodeToConcept(o_);
                bool? q_ = context.Operators.Equivalent(n_, p_);
                l_ = k_ & q_;
            }
            // CQL 'and' (104:7-106:51): right operand skipped when left is false
            if (l_ is false)
            {
                return false;
            }
            else
            {
                DataType r_ = C?.Value;
                object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
                string t_ = (s_ as CqlQuantity)?.unit;
                bool? u_ = context.Operators.Equal(t_, "mGy.cm");
                return l_ & u_;
            }
        }


        decimal? c_(Observation.ComponentComponent C) {
            DataType v_ = C?.Value;
            object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
            decimal? x_ = (w_ as CqlQuantity)?.value;
            return x_;
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
