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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.1.5.0")]
[CqlLibrary("CumulativeMedicationDurationFHIR4", "1.0.000")]
public partial class CumulativeMedicationDurationFHIR4_1_0_000 : ILibrary, ISingleton<CumulativeMedicationDurationFHIR4_1_0_000>
{
    #region Codes (26)

    [CqlCodeDefinition("AC", codeId: "AC", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-TimingEvent")]
    public CqlCode AC(CqlContext _) => _AC;
    private static readonly CqlCode _AC = new CqlCode("AC", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent");

    [CqlCodeDefinition("ACD", codeId: "ACD", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-TimingEvent")]
    public CqlCode ACD(CqlContext _) => _ACD;
    private static readonly CqlCode _ACD = new CqlCode("ACD", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent");

    [CqlCodeDefinition("ACM", codeId: "ACM", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-TimingEvent")]
    public CqlCode ACM(CqlContext _) => _ACM;
    private static readonly CqlCode _ACM = new CqlCode("ACM", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent");

    [CqlCodeDefinition("ACV", codeId: "ACV", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-TimingEvent")]
    public CqlCode ACV(CqlContext _) => _ACV;
    private static readonly CqlCode _ACV = new CqlCode("ACV", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent");

    [CqlCodeDefinition("AFT", codeId: "AFT", codeSystem: "http://hl7.org/fhir/event-timing")]
    public CqlCode AFT(CqlContext _) => _AFT;
    private static readonly CqlCode _AFT = new CqlCode("AFT", "http://hl7.org/fhir/event-timing");

    [CqlCodeDefinition("AFT.early", codeId: "AFT.early", codeSystem: "http://hl7.org/fhir/event-timing")]
    public CqlCode AFT_early(CqlContext _) => _AFT_early;
    private static readonly CqlCode _AFT_early = new CqlCode("AFT.early", "http://hl7.org/fhir/event-timing");

    [CqlCodeDefinition("AFT.late", codeId: "AFT.late", codeSystem: "http://hl7.org/fhir/event-timing")]
    public CqlCode AFT_late(CqlContext _) => _AFT_late;
    private static readonly CqlCode _AFT_late = new CqlCode("AFT.late", "http://hl7.org/fhir/event-timing");

    [CqlCodeDefinition("C", codeId: "C", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-TimingEvent")]
    public CqlCode C(CqlContext _) => _C;
    private static readonly CqlCode _C = new CqlCode("C", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent");

    [CqlCodeDefinition("CD", codeId: "CD", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-TimingEvent")]
    public CqlCode CD(CqlContext _) => _CD;
    private static readonly CqlCode _CD = new CqlCode("CD", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent");

    [CqlCodeDefinition("CM", codeId: "CM", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-TimingEvent")]
    public CqlCode CM(CqlContext _) => _CM;
    private static readonly CqlCode _CM = new CqlCode("CM", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent");

    [CqlCodeDefinition("CV", codeId: "CV", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-TimingEvent")]
    public CqlCode CV(CqlContext _) => _CV;
    private static readonly CqlCode _CV = new CqlCode("CV", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent");

    [CqlCodeDefinition("EVE", codeId: "EVE", codeSystem: "http://hl7.org/fhir/event-timing")]
    public CqlCode EVE(CqlContext _) => _EVE;
    private static readonly CqlCode _EVE = new CqlCode("EVE", "http://hl7.org/fhir/event-timing");

    [CqlCodeDefinition("EVE.early", codeId: "EVE.early", codeSystem: "http://hl7.org/fhir/event-timing")]
    public CqlCode EVE_early(CqlContext _) => _EVE_early;
    private static readonly CqlCode _EVE_early = new CqlCode("EVE.early", "http://hl7.org/fhir/event-timing");

    [CqlCodeDefinition("EVE.late", codeId: "EVE.late", codeSystem: "http://hl7.org/fhir/event-timing")]
    public CqlCode EVE_late(CqlContext _) => _EVE_late;
    private static readonly CqlCode _EVE_late = new CqlCode("EVE.late", "http://hl7.org/fhir/event-timing");

    [CqlCodeDefinition("HS", codeId: "HS", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-TimingEvent")]
    public CqlCode HS(CqlContext _) => _HS;
    private static readonly CqlCode _HS = new CqlCode("HS", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent");

    [CqlCodeDefinition("MORN", codeId: "MORN", codeSystem: "http://hl7.org/fhir/event-timing")]
    public CqlCode MORN(CqlContext _) => _MORN;
    private static readonly CqlCode _MORN = new CqlCode("MORN", "http://hl7.org/fhir/event-timing");

    [CqlCodeDefinition("MORN.early", codeId: "MORN.early", codeSystem: "http://hl7.org/fhir/event-timing")]
    public CqlCode MORN_early(CqlContext _) => _MORN_early;
    private static readonly CqlCode _MORN_early = new CqlCode("MORN.early", "http://hl7.org/fhir/event-timing");

    [CqlCodeDefinition("MORN.late", codeId: "MORN.late", codeSystem: "http://hl7.org/fhir/event-timing")]
    public CqlCode MORN_late(CqlContext _) => _MORN_late;
    private static readonly CqlCode _MORN_late = new CqlCode("MORN.late", "http://hl7.org/fhir/event-timing");

    [CqlCodeDefinition("NIGHT", codeId: "NIGHT", codeSystem: "http://hl7.org/fhir/event-timing")]
    public CqlCode NIGHT(CqlContext _) => _NIGHT;
    private static readonly CqlCode _NIGHT = new CqlCode("NIGHT", "http://hl7.org/fhir/event-timing");

    [CqlCodeDefinition("NOON", codeId: "NOON", codeSystem: "http://hl7.org/fhir/event-timing")]
    public CqlCode NOON(CqlContext _) => _NOON;
    private static readonly CqlCode _NOON = new CqlCode("NOON", "http://hl7.org/fhir/event-timing");

    [CqlCodeDefinition("PC", codeId: "PC", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-TimingEvent")]
    public CqlCode PC(CqlContext _) => _PC;
    private static readonly CqlCode _PC = new CqlCode("PC", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent");

    [CqlCodeDefinition("PCD", codeId: "PCD", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-TimingEvent")]
    public CqlCode PCD(CqlContext _) => _PCD;
    private static readonly CqlCode _PCD = new CqlCode("PCD", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent");

    [CqlCodeDefinition("PCM", codeId: "PCM", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-TimingEvent")]
    public CqlCode PCM(CqlContext _) => _PCM;
    private static readonly CqlCode _PCM = new CqlCode("PCM", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent");

    [CqlCodeDefinition("PCV", codeId: "PCV", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-TimingEvent")]
    public CqlCode PCV(CqlContext _) => _PCV;
    private static readonly CqlCode _PCV = new CqlCode("PCV", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent");

    [CqlCodeDefinition("PHS", codeId: "PHS", codeSystem: "http://hl7.org/fhir/event-timing")]
    public CqlCode PHS(CqlContext _) => _PHS;
    private static readonly CqlCode _PHS = new CqlCode("PHS", "http://hl7.org/fhir/event-timing");

    [CqlCodeDefinition("WAKE", codeId: "WAKE", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-TimingEvent")]
    public CqlCode WAKE(CqlContext _) => _WAKE;
    private static readonly CqlCode _WAKE = new CqlCode("WAKE", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent");

    #endregion Codes

    #region CodeSystems (2)

    [CqlCodeSystemDefinition("V3TimingEvent", codeSystemId: "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", codeSystemVersion: null)]
    public CqlCodeSystem V3TimingEvent(CqlContext _) => _V3TimingEvent;
    private static readonly CqlCodeSystem _V3TimingEvent =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, [
          _AC,
          _ACD,
          _ACM,
          _ACV,
          _C,
          _CD,
          _CM,
          _CV,
          _HS,
          _PC,
          _PCD,
          _PCM,
          _PCV,
          _WAKE]);

    [CqlCodeSystemDefinition("EventTiming", codeSystemId: "http://hl7.org/fhir/event-timing", codeSystemVersion: null)]
    public CqlCodeSystem EventTiming(CqlContext _) => _EventTiming;
    private static readonly CqlCodeSystem _EventTiming =
      new CqlCodeSystem("http://hl7.org/fhir/event-timing", null, [
          _AFT,
          _AFT_early,
          _AFT_late,
          _EVE,
          _EVE_early,
          _EVE_late,
          _MORN,
          _MORN_early,
          _MORN_late,
          _NIGHT,
          _NOON,
          _PHS]);

    #endregion CodeSystems

    #region Parameters (1)

    [CqlParameterDefinition("ErrorLevel")]
    public string ErrorLevel(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_ErrorLevel, ErrorLevel_Compute);

    private const long _cacheIndex_ErrorLevel = -3474294828027834309L;

    private string ErrorLevel_Compute(CqlContext context)
    {
        object a_ = context.ResolveParameter("CumulativeMedicationDurationFHIR4-1.0.000", "ErrorLevel", "Warning");
        return (string)a_;
    }


    #endregion Parameters

    #region Functions and Expressions (11)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = 489454038755907576L;

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToDaily")]
    public decimal? ToDaily(CqlContext context, int? frequency, CqlQuantity period)
    {
        string a_ = period?.unit;
        bool? b_ = context.Operators.Equal(a_, "h");
        if (b_ ?? false)
        {
            decimal? c_ = context.Operators.ConvertIntegerToDecimal(frequency);
            decimal? d_ = period?.value;
            decimal? e_ = context.Operators.Divide(24.0m, d_);
            decimal? f_ = context.Operators.Multiply(c_, e_);
            return f_;
        }
        else
        {
            string g_ = period?.unit;
            bool? h_ = context.Operators.Equal(g_, "min");
            if (h_ ?? false)
            {
                decimal? i_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? j_ = period?.value;
                decimal? k_ = context.Operators.Divide(24.0m, j_);
                decimal? l_ = context.Operators.Multiply(i_, k_);
                decimal? m_ = context.Operators.ConvertIntegerToDecimal(60);
                decimal? n_ = context.Operators.Multiply(l_, m_);
                return n_;
            }
            else
            {
                string o_ = period?.unit;
                bool? p_ = context.Operators.Equal(o_, "s");
                if (p_ ?? false)
                {
                    decimal? q_ = context.Operators.ConvertIntegerToDecimal(frequency);
                    decimal? r_ = period?.value;
                    decimal? s_ = context.Operators.Divide(24.0m, r_);
                    decimal? t_ = context.Operators.Multiply(q_, s_);
                    decimal? u_ = context.Operators.ConvertIntegerToDecimal(60);
                    decimal? v_ = context.Operators.Multiply(t_, u_);
                    decimal? w_ = context.Operators.Multiply(v_, u_);
                    return w_;
                }
                else
                {
                    string x_ = period?.unit;
                    bool? y_ = context.Operators.Equal(x_, "d");
                    if (y_ ?? false)
                    {
                        decimal? z_ = context.Operators.ConvertIntegerToDecimal(frequency);
                        decimal? aa_ = period?.value;
                        decimal? ab_ = context.Operators.Divide(24.0m, aa_);
                        decimal? ac_ = context.Operators.Multiply(z_, ab_);
                        decimal? ad_ = context.Operators.ConvertIntegerToDecimal(24);
                        decimal? ae_ = context.Operators.Divide(ac_, ad_);
                        return ae_;
                    }
                    else
                    {
                        string af_ = period?.unit;
                        bool? ag_ = context.Operators.Equal(af_, "wk");
                        if (ag_ ?? false)
                        {
                            decimal? ah_ = context.Operators.ConvertIntegerToDecimal(frequency);
                            decimal? ai_ = period?.value;
                            decimal? aj_ = context.Operators.Divide(24.0m, ai_);
                            decimal? ak_ = context.Operators.Multiply(ah_, aj_);
                            int? al_ = context.Operators.Multiply(24, 7);
                            decimal? am_ = context.Operators.ConvertIntegerToDecimal(al_);
                            decimal? an_ = context.Operators.Divide(ak_, am_);
                            return an_;
                        }
                        else
                        {
                            string ao_ = period?.unit;
                            bool? ap_ = context.Operators.Equal(ao_, "mo");
                            if (ap_ ?? false)
                            {
                                decimal? aq_ = context.Operators.ConvertIntegerToDecimal(frequency);
                                decimal? ar_ = period?.value;
                                decimal? as_ = context.Operators.Divide(24.0m, ar_);
                                decimal? at_ = context.Operators.Multiply(aq_, as_);
                                int? au_ = context.Operators.Multiply(24, 30);
                                decimal? av_ = context.Operators.ConvertIntegerToDecimal(au_);
                                decimal? aw_ = context.Operators.Divide(at_, av_);
                                return aw_;
                            }
                            else
                            {
                                string ax_ = period?.unit;
                                bool? ay_ = context.Operators.Equal(ax_, "a");
                                if (ay_ ?? false)
                                {
                                    decimal? az_ = context.Operators.ConvertIntegerToDecimal(frequency);
                                    decimal? ba_ = period?.value;
                                    decimal? bb_ = context.Operators.Divide(24.0m, ba_);
                                    decimal? bc_ = context.Operators.Multiply(az_, bb_);
                                    int? bd_ = context.Operators.Multiply(24, 365);
                                    decimal? be_ = context.Operators.ConvertIntegerToDecimal(bd_);
                                    decimal? bf_ = context.Operators.Divide(bc_, be_);
                                    return bf_;
                                }
                                else
                                {
                                    string bg_ = period?.unit;
                                    bool? bh_ = context.Operators.Equal(bg_, "hour");
                                    if (bh_ ?? false)
                                    {
                                        decimal? bi_ = context.Operators.ConvertIntegerToDecimal(frequency);
                                        decimal? bj_ = period?.value;
                                        decimal? bk_ = context.Operators.Divide(24.0m, bj_);
                                        decimal? bl_ = context.Operators.Multiply(bi_, bk_);
                                        return bl_;
                                    }
                                    else
                                    {
                                        string bm_ = period?.unit;
                                        bool? bn_ = context.Operators.Equal(bm_, "minute");
                                        if (bn_ ?? false)
                                        {
                                            decimal? bo_ = context.Operators.ConvertIntegerToDecimal(frequency);
                                            decimal? bp_ = period?.value;
                                            decimal? bq_ = context.Operators.Divide(24.0m, bp_);
                                            decimal? br_ = context.Operators.Multiply(bo_, bq_);
                                            decimal? bs_ = context.Operators.ConvertIntegerToDecimal(60);
                                            decimal? bt_ = context.Operators.Multiply(br_, bs_);
                                            return bt_;
                                        }
                                        else
                                        {
                                            string bu_ = period?.unit;
                                            bool? bv_ = context.Operators.Equal(bu_, "second");
                                            if (bv_ ?? false)
                                            {
                                                decimal? bw_ = context.Operators.ConvertIntegerToDecimal(frequency);
                                                decimal? bx_ = period?.value;
                                                decimal? by_ = context.Operators.Divide(24.0m, bx_);
                                                decimal? bz_ = context.Operators.Multiply(bw_, by_);
                                                decimal? ca_ = context.Operators.ConvertIntegerToDecimal(60);
                                                decimal? cb_ = context.Operators.Multiply(bz_, ca_);
                                                decimal? cc_ = context.Operators.Multiply(cb_, ca_);
                                                return cc_;
                                            }
                                            else
                                            {
                                                string cd_ = period?.unit;
                                                bool? ce_ = context.Operators.Equal(cd_, "day");
                                                if (ce_ ?? false)
                                                {
                                                    decimal? cf_ = context.Operators.ConvertIntegerToDecimal(frequency);
                                                    decimal? cg_ = period?.value;
                                                    decimal? ch_ = context.Operators.Divide(24.0m, cg_);
                                                    decimal? ci_ = context.Operators.Multiply(cf_, ch_);
                                                    decimal? cj_ = context.Operators.ConvertIntegerToDecimal(24);
                                                    decimal? ck_ = context.Operators.Divide(ci_, cj_);
                                                    return ck_;
                                                }
                                                else
                                                {
                                                    string cl_ = period?.unit;
                                                    bool? cm_ = context.Operators.Equal(cl_, "week");
                                                    if (cm_ ?? false)
                                                    {
                                                        decimal? cn_ = context.Operators.ConvertIntegerToDecimal(frequency);
                                                        decimal? co_ = period?.value;
                                                        decimal? cp_ = context.Operators.Divide(24.0m, co_);
                                                        decimal? cq_ = context.Operators.Multiply(cn_, cp_);
                                                        int? cr_ = context.Operators.Multiply(24, 7);
                                                        decimal? cs_ = context.Operators.ConvertIntegerToDecimal(cr_);
                                                        decimal? ct_ = context.Operators.Divide(cq_, cs_);
                                                        return ct_;
                                                    }
                                                    else
                                                    {
                                                        string cu_ = period?.unit;
                                                        bool? cv_ = context.Operators.Equal(cu_, "month");
                                                        if (cv_ ?? false)
                                                        {
                                                            decimal? cw_ = context.Operators.ConvertIntegerToDecimal(frequency);
                                                            decimal? cx_ = period?.value;
                                                            decimal? cy_ = context.Operators.Divide(24.0m, cx_);
                                                            decimal? cz_ = context.Operators.Multiply(cw_, cy_);
                                                            int? da_ = context.Operators.Multiply(24, 30);
                                                            decimal? db_ = context.Operators.ConvertIntegerToDecimal(da_);
                                                            decimal? dc_ = context.Operators.Divide(cz_, db_);
                                                            return dc_;
                                                        }
                                                        else
                                                        {
                                                            string dd_ = period?.unit;
                                                            bool? de_ = context.Operators.Equal(dd_, "year");
                                                            if (de_ ?? false)
                                                            {
                                                                decimal? df_ = context.Operators.ConvertIntegerToDecimal(frequency);
                                                                decimal? dg_ = period?.value;
                                                                decimal? dh_ = context.Operators.Divide(24.0m, dg_);
                                                                decimal? di_ = context.Operators.Multiply(df_, dh_);
                                                                int? dj_ = context.Operators.Multiply(24, 365);
                                                                decimal? dk_ = context.Operators.ConvertIntegerToDecimal(dj_);
                                                                decimal? dl_ = context.Operators.Divide(di_, dk_);
                                                                return dl_;
                                                            }
                                                            else
                                                            {
                                                                string dm_ = period?.unit;
                                                                bool? dn_ = context.Operators.Equal(dm_, "hours");
                                                                if (dn_ ?? false)
                                                                {
                                                                    decimal? do_ = context.Operators.ConvertIntegerToDecimal(frequency);
                                                                    decimal? dp_ = period?.value;
                                                                    decimal? dq_ = context.Operators.Divide(24.0m, dp_);
                                                                    decimal? dr_ = context.Operators.Multiply(do_, dq_);
                                                                    return dr_;
                                                                }
                                                                else
                                                                {
                                                                    string ds_ = period?.unit;
                                                                    bool? dt_ = context.Operators.Equal(ds_, "minutes");
                                                                    if (dt_ ?? false)
                                                                    {
                                                                        decimal? du_ = context.Operators.ConvertIntegerToDecimal(frequency);
                                                                        decimal? dv_ = period?.value;
                                                                        decimal? dw_ = context.Operators.Divide(24.0m, dv_);
                                                                        decimal? dx_ = context.Operators.Multiply(du_, dw_);
                                                                        decimal? dy_ = context.Operators.ConvertIntegerToDecimal(60);
                                                                        decimal? dz_ = context.Operators.Multiply(dx_, dy_);
                                                                        return dz_;
                                                                    }
                                                                    else
                                                                    {
                                                                        string ea_ = period?.unit;
                                                                        bool? eb_ = context.Operators.Equal(ea_, "seconds");
                                                                        if (eb_ ?? false)
                                                                        {
                                                                            decimal? ec_ = context.Operators.ConvertIntegerToDecimal(frequency);
                                                                            decimal? ed_ = period?.value;
                                                                            decimal? ee_ = context.Operators.Divide(24.0m, ed_);
                                                                            decimal? ef_ = context.Operators.Multiply(ec_, ee_);
                                                                            decimal? eg_ = context.Operators.ConvertIntegerToDecimal(60);
                                                                            decimal? eh_ = context.Operators.Multiply(ef_, eg_);
                                                                            decimal? ei_ = context.Operators.Multiply(eh_, eg_);
                                                                            return ei_;
                                                                        }
                                                                        else
                                                                        {
                                                                            string ej_ = period?.unit;
                                                                            bool? ek_ = context.Operators.Equal(ej_, "days");
                                                                            if (ek_ ?? false)
                                                                            {
                                                                                decimal? el_ = context.Operators.ConvertIntegerToDecimal(frequency);
                                                                                decimal? em_ = period?.value;
                                                                                decimal? en_ = context.Operators.Divide(24.0m, em_);
                                                                                decimal? eo_ = context.Operators.Multiply(el_, en_);
                                                                                decimal? ep_ = context.Operators.ConvertIntegerToDecimal(24);
                                                                                decimal? eq_ = context.Operators.Divide(eo_, ep_);
                                                                                return eq_;
                                                                            }
                                                                            else
                                                                            {
                                                                                string er_ = period?.unit;
                                                                                bool? es_ = context.Operators.Equal(er_, "weeks");
                                                                                if (es_ ?? false)
                                                                                {
                                                                                    decimal? et_ = context.Operators.ConvertIntegerToDecimal(frequency);
                                                                                    decimal? eu_ = period?.value;
                                                                                    decimal? ev_ = context.Operators.Divide(24.0m, eu_);
                                                                                    decimal? ew_ = context.Operators.Multiply(et_, ev_);
                                                                                    int? ex_ = context.Operators.Multiply(24, 7);
                                                                                    decimal? ey_ = context.Operators.ConvertIntegerToDecimal(ex_);
                                                                                    decimal? ez_ = context.Operators.Divide(ew_, ey_);
                                                                                    return ez_;
                                                                                }
                                                                                else
                                                                                {
                                                                                    string fa_ = period?.unit;
                                                                                    bool? fb_ = context.Operators.Equal(fa_, "months");
                                                                                    if (fb_ ?? false)
                                                                                    {
                                                                                        decimal? fc_ = context.Operators.ConvertIntegerToDecimal(frequency);
                                                                                        decimal? fd_ = period?.value;
                                                                                        decimal? fe_ = context.Operators.Divide(24.0m, fd_);
                                                                                        decimal? ff_ = context.Operators.Multiply(fc_, fe_);
                                                                                        int? fg_ = context.Operators.Multiply(24, 30);
                                                                                        decimal? fh_ = context.Operators.ConvertIntegerToDecimal(fg_);
                                                                                        decimal? fi_ = context.Operators.Divide(ff_, fh_);
                                                                                        return fi_;
                                                                                    }
                                                                                    else
                                                                                    {
                                                                                        string fj_ = period?.unit;
                                                                                        bool? fk_ = context.Operators.Equal(fj_, "years");
                                                                                        if (fk_ ?? false)
                                                                                        {
                                                                                            decimal? fl_ = context.Operators.ConvertIntegerToDecimal(frequency);
                                                                                            decimal? fm_ = period?.value;
                                                                                            decimal? fn_ = context.Operators.Divide(24.0m, fm_);
                                                                                            decimal? fo_ = context.Operators.Multiply(fl_, fn_);
                                                                                            int? fp_ = context.Operators.Multiply(24, 365);
                                                                                            decimal? fq_ = context.Operators.ConvertIntegerToDecimal(fp_);
                                                                                            decimal? fr_ = context.Operators.Divide(fo_, fq_);
                                                                                            return fr_;
                                                                                        }
                                                                                        else
                                                                                        {
                                                                                            string fs_ = this.ErrorLevel(context);
                                                                                            string ft_ = period?.unit;
                                                                                            string fu_ = context.Operators.Concatenate("Unknown unit ", ft_ ?? "");
                                                                                            object fv_ = context.Operators.Message<object>((object)null, "CMDLogic.ToDaily.UnknownUnit", fs_, fu_);
                                                                                            return fv_ as decimal?;
                                                                                        }
                                                                                    }
                                                                                }
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }


    [CqlFunctionDefinition("ToDaily")]
    public decimal? ToDaily(CqlContext context, CqlCode frequency)
    {
        CqlCode a_ = this.C(context);
        bool? b_ = context.Operators.Equal(frequency, a_);
        if (b_ ?? false)
        {
            return 3.0m;
        }
        else
        {
            string c_ = this.ErrorLevel(context);
            string d_ = frequency?.code;
            string e_ = context.Operators.Concatenate("Unknown frequency code ", d_ ?? "");
            object f_ = context.Operators.Message<object>((object)null, "CMDLogic.ToDaily.UnknownFrequencyCode", c_, e_);
            return f_ as decimal?;
        }
    }


    [CqlFunctionDefinition("MedicationRequestPeriod")]
    public CqlInterval<CqlDateTime> MedicationRequestPeriod(CqlContext context, MedicationRequest Request)
    {
        MedicationRequest[] a_ = [
            Request,
        ];

        CqlInterval<CqlDateTime> b_(MedicationRequest R) {
            List<Dosage> f_ = R?.DosageInstruction;
            Dosage g_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)f_);
            Timing h_ = g_?.Timing;
            Timing.RepeatComponent i_ = h_?.Repeat;
            DataType j_ = i_?.Bounds;
            CqlInterval<CqlDateTime> k_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, j_ as Period);
            CqlDateTime l_ = context.Operators.End(k_);
            CqlDateTime m_ = context.Operators.MaxValue<CqlDateTime>();
            bool? n_ = context.Operators.Equal(l_, m_);
            bool? o_ = context.Operators.Or((bool?)(l_ is null), n_);
            bool? p_ = context.Operators.Not(o_);
            if (p_ ?? false)
            {
                List<Dosage> q_ = R?.DosageInstruction;
                Dosage r_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)q_);
                Timing s_ = r_?.Timing;
                Timing.RepeatComponent t_ = s_?.Repeat;
                DataType u_ = t_?.Bounds;
                CqlInterval<CqlDateTime> v_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, u_ as Period);
                CqlDateTime w_ = context.Operators.Start(v_);
                MedicationRequest.DispenseRequestComponent x_ = R?.DispenseRequest;
                Period y_ = x_?.ValidityPeriod;
                CqlInterval<CqlDateTime> z_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, y_);
                CqlDateTime aa_ = context.Operators.Start(z_);
                FhirDateTime ab_ = R?.AuthoredOnElement;
                CqlDateTime ac_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, ab_);
                CqlDateTime ad_ = context.Operators.End(v_);
                CqlInterval<CqlDateTime> ae_ = context.Operators.Interval((w_ ?? aa_) ?? ac_, ad_, true, true);
                return ae_;
            }
            else
            {
                List<Dosage> af_ = R?.DosageInstruction;
                Dosage ag_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)af_);
                Timing ah_ = ag_?.Timing;
                Timing.RepeatComponent ai_ = ah_?.Repeat;
                DataType aj_ = ai_?.Bounds;
                CqlInterval<CqlDateTime> ak_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, aj_ as Period);
                CqlDateTime al_ = context.Operators.Start(ak_);
                MedicationRequest.DispenseRequestComponent am_ = R?.DispenseRequest;
                Period an_ = am_?.ValidityPeriod;
                CqlInterval<CqlDateTime> ao_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, an_);
                CqlDateTime ap_ = context.Operators.Start(ao_);
                FhirDateTime aq_ = R?.AuthoredOnElement;
                CqlDateTime ar_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, aq_);
                Duration as_ = am_?.ExpectedSupplyDuration;
                CqlQuantity at_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, as_);
                Quantity au_ = am_?.Quantity;
                CqlQuantity av_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, au_);
                List<Dosage.DoseAndRateComponent> aw_ = ag_?.DoseAndRate;
                Dosage.DoseAndRateComponent ax_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)aw_);
                DataType ay_ = ax_?.Dose;
                CqlInterval<CqlQuantity> az_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ay_ as Range);
                CqlQuantity ba_ = context.Operators.End(az_);
                CqlQuantity bb_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, ay_ as Quantity);
                PositiveInt bc_ = ai_?.FrequencyMaxElement;
                Integer bd_ = context.Operators.Convert<Integer>(bc_);
                PositiveInt be_ = ai_?.FrequencyElement;
                Integer bf_ = context.Operators.Convert<Integer>(be_);
                int? bg_ = FHIRHelpers_4_0_001.Instance.ToInteger(context, bd_ ?? bf_);
                FhirDecimal bh_ = ai_?.PeriodElement;
                decimal? bi_ = FHIRHelpers_4_0_001.Instance.ToDecimal(context, bh_);
                Code<Timing.UnitsOfTime> bj_ = ai_?.PeriodUnitElement;
                Timing.UnitsOfTime? bk_ = bj_?.Value;
                string bl_ = context.Operators.Convert<string>(bk_);
                decimal? bm_ = this.ToDaily(context, bg_, new CqlQuantity(bi_, bl_));
                List<Time> bn_ = ai_?.TimeOfDayElement;
                int? bo_ = context.Operators.Count<Time>((IEnumerable<Time>)bn_);
                decimal? bp_ = context.Operators.ConvertIntegerToDecimal(bo_);
                CqlQuantity bq_ = context.Operators.ConvertDecimalToQuantity((bm_ ?? bp_) ?? 1.0m);
                CqlQuantity br_ = context.Operators.Multiply(ba_ ?? bb_, bq_);
                CqlQuantity bs_ = context.Operators.Divide(av_, br_);
                UnsignedInt bt_ = am_?.NumberOfRepeatsAllowedElement;
                Integer bu_ = context.Operators.Convert<Integer>(bt_);
                int? bv_ = FHIRHelpers_4_0_001.Instance.ToInteger(context, bu_);
                int? bw_ = context.Operators.Add(1, bv_ ?? 0);
                CqlQuantity bx_ = context.Operators.ConvertIntegerToQuantity(bw_);
                CqlQuantity by_ = context.Operators.Multiply(at_ ?? bs_, bx_);
                CqlDateTime bz_ = context.Operators.Add((al_ ?? ap_) ?? ar_, by_);
                CqlInterval<CqlDateTime> ca_ = context.Operators.Interval((al_ ?? ap_) ?? ar_, bz_, true, true);
                return ca_;
            }
        }

        IEnumerable<CqlInterval<CqlDateTime>> c_ = context.Operators.Select<MedicationRequest, CqlInterval<CqlDateTime>>((IEnumerable<MedicationRequest>)a_, b_);
        IEnumerable<CqlInterval<CqlDateTime>> d_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(c_);
        CqlInterval<CqlDateTime> e_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(d_);
        return e_;
    }


    [CqlFunctionDefinition("MedicationDispensePeriod")]
    public CqlInterval<CqlDateTime> MedicationDispensePeriod(CqlContext context, MedicationDispense Dispense)
    {
        MedicationDispense[] a_ = [
            Dispense,
        ];

        CqlInterval<CqlDateTime> b_(MedicationDispense D) {
            FhirDateTime f_ = D?.WhenHandedOverElement;
            FhirDateTime g_ = D?.WhenPreparedElement;
            CqlDateTime h_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, f_ ?? g_);
            Quantity i_ = D?.DaysSupply;
            CqlQuantity j_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, i_);
            Quantity k_ = D?.Quantity;
            CqlQuantity l_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, k_);
            List<Dosage> m_ = D?.DosageInstruction;
            Dosage n_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)m_);
            List<Dosage.DoseAndRateComponent> o_ = n_?.DoseAndRate;
            Dosage.DoseAndRateComponent p_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)o_);
            DataType q_ = p_?.Dose;
            CqlInterval<CqlQuantity> r_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, q_ as Range);
            CqlQuantity s_ = context.Operators.End(r_);
            CqlQuantity t_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, q_ as Quantity);
            Timing u_ = n_?.Timing;
            Timing.RepeatComponent v_ = u_?.Repeat;
            PositiveInt w_ = v_?.FrequencyMaxElement;
            Integer x_ = context.Operators.Convert<Integer>(w_);
            PositiveInt y_ = v_?.FrequencyElement;
            Integer z_ = context.Operators.Convert<Integer>(y_);
            int? aa_ = FHIRHelpers_4_0_001.Instance.ToInteger(context, x_ ?? z_);
            FhirDecimal ab_ = v_?.PeriodElement;
            decimal? ac_ = FHIRHelpers_4_0_001.Instance.ToDecimal(context, ab_);
            Code<Timing.UnitsOfTime> ad_ = v_?.PeriodUnitElement;
            Timing.UnitsOfTime? ae_ = ad_?.Value;
            string af_ = context.Operators.Convert<string>(ae_);
            decimal? ag_ = this.ToDaily(context, aa_, new CqlQuantity(ac_, af_));
            List<Time> ah_ = v_?.TimeOfDayElement;
            int? ai_ = context.Operators.Count<Time>((IEnumerable<Time>)ah_);
            decimal? aj_ = context.Operators.ConvertIntegerToDecimal(ai_);
            CqlQuantity ak_ = context.Operators.ConvertDecimalToQuantity((ag_ ?? aj_) ?? 1.0m);
            CqlQuantity al_ = context.Operators.Multiply(s_ ?? t_, ak_);
            CqlQuantity am_ = context.Operators.Divide(l_, al_);
            CqlDateTime an_ = context.Operators.Add(h_, j_ ?? am_);
            CqlInterval<CqlDateTime> ao_ = context.Operators.Interval(h_, an_, true, true);
            return ao_;
        }

        IEnumerable<CqlInterval<CqlDateTime>> c_ = context.Operators.Select<MedicationDispense, CqlInterval<CqlDateTime>>((IEnumerable<MedicationDispense>)a_, b_);
        IEnumerable<CqlInterval<CqlDateTime>> d_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(c_);
        CqlInterval<CqlDateTime> e_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(d_);
        return e_;
    }


    [CqlFunctionDefinition("TherapeuticDuration")]
    public CqlQuantity TherapeuticDuration(CqlContext context, CqlConcept medication)
    {
        CqlQuantity a_ = context.Operators.Quantity(14m, "days");
        return a_;
    }


    [CqlFunctionDefinition("MedicationAdministrationPeriod")]
    public CqlInterval<CqlDateTime> MedicationAdministrationPeriod(CqlContext context, MedicationAdministration Administration)
    {
        MedicationAdministration[] a_ = [
            Administration,
        ];

        CqlInterval<CqlDateTime> b_(MedicationAdministration M) {
            DataType f_ = Administration?.Effective;
            CqlInterval<CqlDateTime> g_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, f_ as Period);
            CqlDateTime h_ = context.Operators.Start(g_);
            bool? i_ = context.Operators.Not((bool?)(h_ is null));
            DataType j_ = Administration?.Medication;
            CqlConcept k_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, j_ as CodeableConcept);
            CqlQuantity l_ = this.TherapeuticDuration(context, k_);
            bool? m_ = context.Operators.Not((bool?)(l_ is null));
            bool? n_ = context.Operators.And(i_, m_);
            if (n_ ?? false)
            {
                DataType o_ = Administration?.Effective;
                CqlInterval<CqlDateTime> p_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, o_ as Period);
                CqlDateTime q_ = context.Operators.Start(p_);
                DataType r_ = Administration?.Medication;
                CqlConcept s_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, r_ as CodeableConcept);
                CqlQuantity t_ = this.TherapeuticDuration(context, s_);
                CqlDateTime u_ = context.Operators.Add(q_, t_);
                CqlInterval<CqlDateTime> v_ = context.Operators.Interval(q_, u_, true, true);
                return v_;
            }
            else
            {
                return null as CqlInterval<CqlDateTime>;
            }
        }

        IEnumerable<CqlInterval<CqlDateTime>> c_ = context.Operators.Select<MedicationAdministration, CqlInterval<CqlDateTime>>((IEnumerable<MedicationAdministration>)a_, b_);
        IEnumerable<CqlInterval<CqlDateTime>> d_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(c_);
        CqlInterval<CqlDateTime> e_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(d_);
        return e_;
    }


    [CqlFunctionDefinition("CumulativeDuration")]
    public int? CumulativeDuration(CqlContext context, IEnumerable<CqlInterval<CqlDateTime>> Intervals)
    {
        IEnumerable<CqlInterval<CqlDateTime>> a_ = context.Operators.Collapse(Intervals, "day");

        int? b_(CqlInterval<CqlDateTime> X) {
            CqlDateTime e_ = context.Operators.Start(X);
            CqlDateTime f_ = context.Operators.End(X);
            int? g_ = context.Operators.DifferenceBetween(e_, f_, "day");
            return g_;
        }

        IEnumerable<int?> c_ = context.Operators.Select<CqlInterval<CqlDateTime>, int?>(a_, b_);
        int? d_ = context.Operators.Sum(c_);
        return d_;
    }


    [CqlFunctionDefinition("RolloutIntervals")]
    public IEnumerable<CqlInterval<CqlDateTime>> RolloutIntervals(CqlContext context, IEnumerable<CqlInterval<CqlDateTime>> intervals)
    {

        IEnumerable<CqlInterval<CqlDateTime>> a_(IEnumerable<CqlInterval<CqlDateTime>> R, CqlInterval<CqlDateTime> I) {
            CqlInterval<CqlDateTime>[] c_ = [
                I,
            ];

            CqlInterval<CqlDateTime> d_(CqlInterval<CqlDateTime> X) {
                CqlInterval<CqlDateTime> j_ = context.Operators.Last<CqlInterval<CqlDateTime>>(R);
                CqlDateTime k_ = context.Operators.End(j_);
                CqlQuantity l_ = context.Operators.Quantity(1m, "day");
                CqlDateTime m_ = context.Operators.Add(k_, l_);
                CqlDateTime n_ = context.Operators.Start(X);
                CqlDateTime[] o_ = [
                    m_,
                    n_,
                ];
                CqlDateTime p_ = context.Operators.Max<CqlDateTime>((IEnumerable<CqlDateTime>)o_);
                CqlDateTime q_ = context.Operators.End(X);
                int? r_ = context.Operators.DurationBetween(n_, q_, "day");
                decimal? s_ = context.Operators.ConvertIntegerToDecimal(r_ ?? 0);
                CqlDateTime t_ = context.Operators.Add(p_, new CqlQuantity(s_, "day"));
                CqlInterval<CqlDateTime> u_ = context.Operators.Interval(p_, t_, true, true);
                return u_;
            }

            IEnumerable<CqlInterval<CqlDateTime>> e_ = context.Operators.Select<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>((IEnumerable<CqlInterval<CqlDateTime>>)c_, d_);
            IEnumerable<CqlInterval<CqlDateTime>> f_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(e_);
            CqlInterval<CqlDateTime> g_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(f_);
            CqlInterval<CqlDateTime>[] h_ = [
                g_,
            ];
            IEnumerable<CqlInterval<CqlDateTime>> i_ = context.Operators.Union<CqlInterval<CqlDateTime>>(R, (IEnumerable<CqlInterval<CqlDateTime>>)h_);
            return i_;
        }

        IEnumerable<CqlInterval<CqlDateTime>> b_ = context.Operators.Aggregate<CqlInterval<CqlDateTime>, IEnumerable<CqlInterval<CqlDateTime>>>(intervals, a_, null as IEnumerable<CqlInterval<CqlDateTime>>);
        return b_;
    }


    [CqlFunctionDefinition("MedicationPeriod")]
    public CqlInterval<CqlDateTime> MedicationPeriod(CqlContext context, object medication)
    {
        if (medication is MedicationRequest)
        {
            CqlInterval<CqlDateTime> a_ = this.MedicationRequestPeriod(context, medication as MedicationRequest);
            return a_;
        }
        else if (medication is MedicationDispense)
        {
            CqlInterval<CqlDateTime> b_ = this.MedicationDispensePeriod(context, medication as MedicationDispense);
            return b_;
        }
        else if (medication is MedicationAdministration)
        {
            CqlInterval<CqlDateTime> c_ = this.MedicationAdministrationPeriod(context, medication as MedicationAdministration);
            return c_;
        }
        else
        {
            return null as CqlInterval<CqlDateTime>;
        }
    }


    [CqlFunctionDefinition("CumulativeMedicationDuration")]
    public int? CumulativeMedicationDuration(CqlContext context, IEnumerable<object> Medications)
    {

        bool? a_(object M) {
            bool n_ = M is MedicationRequest;
            return n_ as bool?;
        }

        IEnumerable<object> b_ = context.Operators.Where<object>(Medications, a_);

        CqlInterval<CqlDateTime> c_(object M) {
            CqlInterval<CqlDateTime> o_ = this.MedicationPeriod(context, M);
            return o_;
        }

        IEnumerable<CqlInterval<CqlDateTime>> d_ = context.Operators.Select<object, CqlInterval<CqlDateTime>>(b_, c_);
        IEnumerable<CqlInterval<CqlDateTime>> e_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(d_);

        bool? f_(object M) {
            bool p_ = M is MedicationDispense;
            bool q_ = M is MedicationAdministration;
            bool? r_ = context.Operators.Or(p_ as bool?, q_ as bool?);
            return r_;
        }

        IEnumerable<object> g_ = context.Operators.Where<object>(Medications, f_);

        CqlInterval<CqlDateTime> h_(object M) {
            CqlInterval<CqlDateTime> s_ = this.MedicationPeriod(context, M);
            return s_;
        }

        IEnumerable<CqlInterval<CqlDateTime>> i_ = context.Operators.Select<object, CqlInterval<CqlDateTime>>(g_, h_);
        IEnumerable<CqlInterval<CqlDateTime>> j_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(i_);
        IEnumerable<CqlInterval<CqlDateTime>> k_ = this.RolloutIntervals(context, j_);
        IEnumerable<CqlInterval<CqlDateTime>> l_ = context.Operators.Union<CqlInterval<CqlDateTime>>(e_, k_);
        int? m_ = this.CumulativeDuration(context, l_);
        return m_;
    }


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private CumulativeMedicationDurationFHIR4_1_0_000() {}

    public static CumulativeMedicationDurationFHIR4_1_0_000 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "CumulativeMedicationDurationFHIR4";
    public string Version => "1.0.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_0_001.Instance];

    #endregion ILibrary Implementation

}
