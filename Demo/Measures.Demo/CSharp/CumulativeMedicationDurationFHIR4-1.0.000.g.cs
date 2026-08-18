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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.3.4.0")]
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
        CqlBoolean b_ = context.Operators.Equal(a_, "h");
        if (b_.IsTrue)
        {
            decimal? c_ = context.Operators.ConvertIntegerToDecimal(frequency);
            decimal? d_ = period?.value;
            decimal? e_ = context.Operators.Divide(24.0m, d_);
            decimal? f_ = context.Operators.Multiply(c_, e_);
            return f_;
        }
        else
        {
            CqlBoolean g_ = context.Operators.Equal(a_, "min");
            if (g_.IsTrue)
            {
                decimal? h_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? i_ = period?.value;
                decimal? j_ = context.Operators.Divide(24.0m, i_);
                decimal? k_ = context.Operators.Multiply(h_, j_);
                decimal? l_ = context.Operators.ConvertIntegerToDecimal(60);
                decimal? m_ = context.Operators.Multiply(k_, l_);
                return m_;
            }
            else
            {
                CqlBoolean n_ = context.Operators.Equal(a_, "s");
                if (n_.IsTrue)
                {
                    decimal? o_ = context.Operators.ConvertIntegerToDecimal(frequency);
                    decimal? p_ = period?.value;
                    decimal? q_ = context.Operators.Divide(24.0m, p_);
                    decimal? r_ = context.Operators.Multiply(o_, q_);
                    decimal? s_ = context.Operators.ConvertIntegerToDecimal(60);
                    decimal? t_ = context.Operators.Multiply(r_, s_);
                    decimal? u_ = context.Operators.Multiply(t_, s_);
                    return u_;
                }
                else
                {
                    CqlBoolean v_ = context.Operators.Equal(a_, "d");
                    if (v_.IsTrue)
                    {
                        decimal? w_ = context.Operators.ConvertIntegerToDecimal(frequency);
                        decimal? x_ = period?.value;
                        decimal? y_ = context.Operators.Divide(24.0m, x_);
                        decimal? z_ = context.Operators.Multiply(w_, y_);
                        decimal? aa_ = context.Operators.ConvertIntegerToDecimal(24);
                        decimal? ab_ = context.Operators.Divide(z_, aa_);
                        return ab_;
                    }
                    else
                    {
                        CqlBoolean ac_ = context.Operators.Equal(a_, "wk");
                        if (ac_.IsTrue)
                        {
                            decimal? ad_ = context.Operators.ConvertIntegerToDecimal(frequency);
                            decimal? ae_ = period?.value;
                            decimal? af_ = context.Operators.Divide(24.0m, ae_);
                            decimal? ag_ = context.Operators.Multiply(ad_, af_);
                            int? ah_ = context.Operators.Multiply(24, 7);
                            decimal? ai_ = context.Operators.ConvertIntegerToDecimal(ah_);
                            decimal? aj_ = context.Operators.Divide(ag_, ai_);
                            return aj_;
                        }
                        else
                        {
                            CqlBoolean ak_ = context.Operators.Equal(a_, "mo");
                            if (ak_.IsTrue)
                            {
                                decimal? al_ = context.Operators.ConvertIntegerToDecimal(frequency);
                                decimal? am_ = period?.value;
                                decimal? an_ = context.Operators.Divide(24.0m, am_);
                                decimal? ao_ = context.Operators.Multiply(al_, an_);
                                int? ap_ = context.Operators.Multiply(24, 30);
                                decimal? aq_ = context.Operators.ConvertIntegerToDecimal(ap_);
                                decimal? ar_ = context.Operators.Divide(ao_, aq_);
                                return ar_;
                            }
                            else
                            {
                                CqlBoolean as_ = context.Operators.Equal(a_, "a");
                                if (as_.IsTrue)
                                {
                                    decimal? at_ = context.Operators.ConvertIntegerToDecimal(frequency);
                                    decimal? au_ = period?.value;
                                    decimal? av_ = context.Operators.Divide(24.0m, au_);
                                    decimal? aw_ = context.Operators.Multiply(at_, av_);
                                    int? ax_ = context.Operators.Multiply(24, 365);
                                    decimal? ay_ = context.Operators.ConvertIntegerToDecimal(ax_);
                                    decimal? az_ = context.Operators.Divide(aw_, ay_);
                                    return az_;
                                }
                                else
                                {
                                    CqlBoolean ba_ = context.Operators.Equal(a_, "hour");
                                    if (ba_.IsTrue)
                                    {
                                        decimal? bb_ = context.Operators.ConvertIntegerToDecimal(frequency);
                                        decimal? bc_ = period?.value;
                                        decimal? bd_ = context.Operators.Divide(24.0m, bc_);
                                        decimal? be_ = context.Operators.Multiply(bb_, bd_);
                                        return be_;
                                    }
                                    else
                                    {
                                        CqlBoolean bf_ = context.Operators.Equal(a_, "minute");
                                        if (bf_.IsTrue)
                                        {
                                            decimal? bg_ = context.Operators.ConvertIntegerToDecimal(frequency);
                                            decimal? bh_ = period?.value;
                                            decimal? bi_ = context.Operators.Divide(24.0m, bh_);
                                            decimal? bj_ = context.Operators.Multiply(bg_, bi_);
                                            decimal? bk_ = context.Operators.ConvertIntegerToDecimal(60);
                                            decimal? bl_ = context.Operators.Multiply(bj_, bk_);
                                            return bl_;
                                        }
                                        else
                                        {
                                            CqlBoolean bm_ = context.Operators.Equal(a_, "second");
                                            if (bm_.IsTrue)
                                            {
                                                decimal? bn_ = context.Operators.ConvertIntegerToDecimal(frequency);
                                                decimal? bo_ = period?.value;
                                                decimal? bp_ = context.Operators.Divide(24.0m, bo_);
                                                decimal? bq_ = context.Operators.Multiply(bn_, bp_);
                                                decimal? br_ = context.Operators.ConvertIntegerToDecimal(60);
                                                decimal? bs_ = context.Operators.Multiply(bq_, br_);
                                                decimal? bt_ = context.Operators.Multiply(bs_, br_);
                                                return bt_;
                                            }
                                            else
                                            {
                                                CqlBoolean bu_ = context.Operators.Equal(a_, "day");
                                                if (bu_.IsTrue)
                                                {
                                                    decimal? bv_ = context.Operators.ConvertIntegerToDecimal(frequency);
                                                    decimal? bw_ = period?.value;
                                                    decimal? bx_ = context.Operators.Divide(24.0m, bw_);
                                                    decimal? by_ = context.Operators.Multiply(bv_, bx_);
                                                    decimal? bz_ = context.Operators.ConvertIntegerToDecimal(24);
                                                    decimal? ca_ = context.Operators.Divide(by_, bz_);
                                                    return ca_;
                                                }
                                                else
                                                {
                                                    CqlBoolean cb_ = context.Operators.Equal(a_, "week");
                                                    if (cb_.IsTrue)
                                                    {
                                                        decimal? cc_ = context.Operators.ConvertIntegerToDecimal(frequency);
                                                        decimal? cd_ = period?.value;
                                                        decimal? ce_ = context.Operators.Divide(24.0m, cd_);
                                                        decimal? cf_ = context.Operators.Multiply(cc_, ce_);
                                                        int? cg_ = context.Operators.Multiply(24, 7);
                                                        decimal? ch_ = context.Operators.ConvertIntegerToDecimal(cg_);
                                                        decimal? ci_ = context.Operators.Divide(cf_, ch_);
                                                        return ci_;
                                                    }
                                                    else
                                                    {
                                                        CqlBoolean cj_ = context.Operators.Equal(a_, "month");
                                                        if (cj_.IsTrue)
                                                        {
                                                            decimal? ck_ = context.Operators.ConvertIntegerToDecimal(frequency);
                                                            decimal? cl_ = period?.value;
                                                            decimal? cm_ = context.Operators.Divide(24.0m, cl_);
                                                            decimal? cn_ = context.Operators.Multiply(ck_, cm_);
                                                            int? co_ = context.Operators.Multiply(24, 30);
                                                            decimal? cp_ = context.Operators.ConvertIntegerToDecimal(co_);
                                                            decimal? cq_ = context.Operators.Divide(cn_, cp_);
                                                            return cq_;
                                                        }
                                                        else
                                                        {
                                                            CqlBoolean cr_ = context.Operators.Equal(a_, "year");
                                                            if (cr_.IsTrue)
                                                            {
                                                                decimal? cs_ = context.Operators.ConvertIntegerToDecimal(frequency);
                                                                decimal? ct_ = period?.value;
                                                                decimal? cu_ = context.Operators.Divide(24.0m, ct_);
                                                                decimal? cv_ = context.Operators.Multiply(cs_, cu_);
                                                                int? cw_ = context.Operators.Multiply(24, 365);
                                                                decimal? cx_ = context.Operators.ConvertIntegerToDecimal(cw_);
                                                                decimal? cy_ = context.Operators.Divide(cv_, cx_);
                                                                return cy_;
                                                            }
                                                            else
                                                            {
                                                                CqlBoolean cz_ = context.Operators.Equal(a_, "hours");
                                                                if (cz_.IsTrue)
                                                                {
                                                                    decimal? da_ = context.Operators.ConvertIntegerToDecimal(frequency);
                                                                    decimal? db_ = period?.value;
                                                                    decimal? dc_ = context.Operators.Divide(24.0m, db_);
                                                                    decimal? dd_ = context.Operators.Multiply(da_, dc_);
                                                                    return dd_;
                                                                }
                                                                else
                                                                {
                                                                    CqlBoolean de_ = context.Operators.Equal(a_, "minutes");
                                                                    if (de_.IsTrue)
                                                                    {
                                                                        decimal? df_ = context.Operators.ConvertIntegerToDecimal(frequency);
                                                                        decimal? dg_ = period?.value;
                                                                        decimal? dh_ = context.Operators.Divide(24.0m, dg_);
                                                                        decimal? di_ = context.Operators.Multiply(df_, dh_);
                                                                        decimal? dj_ = context.Operators.ConvertIntegerToDecimal(60);
                                                                        decimal? dk_ = context.Operators.Multiply(di_, dj_);
                                                                        return dk_;
                                                                    }
                                                                    else
                                                                    {
                                                                        CqlBoolean dl_ = context.Operators.Equal(a_, "seconds");
                                                                        if (dl_.IsTrue)
                                                                        {
                                                                            decimal? dm_ = context.Operators.ConvertIntegerToDecimal(frequency);
                                                                            decimal? dn_ = period?.value;
                                                                            decimal? do_ = context.Operators.Divide(24.0m, dn_);
                                                                            decimal? dp_ = context.Operators.Multiply(dm_, do_);
                                                                            decimal? dq_ = context.Operators.ConvertIntegerToDecimal(60);
                                                                            decimal? dr_ = context.Operators.Multiply(dp_, dq_);
                                                                            decimal? ds_ = context.Operators.Multiply(dr_, dq_);
                                                                            return ds_;
                                                                        }
                                                                        else
                                                                        {
                                                                            CqlBoolean dt_ = context.Operators.Equal(a_, "days");
                                                                            if (dt_.IsTrue)
                                                                            {
                                                                                decimal? du_ = context.Operators.ConvertIntegerToDecimal(frequency);
                                                                                decimal? dv_ = period?.value;
                                                                                decimal? dw_ = context.Operators.Divide(24.0m, dv_);
                                                                                decimal? dx_ = context.Operators.Multiply(du_, dw_);
                                                                                decimal? dy_ = context.Operators.ConvertIntegerToDecimal(24);
                                                                                decimal? dz_ = context.Operators.Divide(dx_, dy_);
                                                                                return dz_;
                                                                            }
                                                                            else
                                                                            {
                                                                                CqlBoolean ea_ = context.Operators.Equal(a_, "weeks");
                                                                                if (ea_.IsTrue)
                                                                                {
                                                                                    decimal? eb_ = context.Operators.ConvertIntegerToDecimal(frequency);
                                                                                    decimal? ec_ = period?.value;
                                                                                    decimal? ed_ = context.Operators.Divide(24.0m, ec_);
                                                                                    decimal? ee_ = context.Operators.Multiply(eb_, ed_);
                                                                                    int? ef_ = context.Operators.Multiply(24, 7);
                                                                                    decimal? eg_ = context.Operators.ConvertIntegerToDecimal(ef_);
                                                                                    decimal? eh_ = context.Operators.Divide(ee_, eg_);
                                                                                    return eh_;
                                                                                }
                                                                                else
                                                                                {
                                                                                    CqlBoolean ei_ = context.Operators.Equal(a_, "months");
                                                                                    if (ei_.IsTrue)
                                                                                    {
                                                                                        decimal? ej_ = context.Operators.ConvertIntegerToDecimal(frequency);
                                                                                        decimal? ek_ = period?.value;
                                                                                        decimal? el_ = context.Operators.Divide(24.0m, ek_);
                                                                                        decimal? em_ = context.Operators.Multiply(ej_, el_);
                                                                                        int? en_ = context.Operators.Multiply(24, 30);
                                                                                        decimal? eo_ = context.Operators.ConvertIntegerToDecimal(en_);
                                                                                        decimal? ep_ = context.Operators.Divide(em_, eo_);
                                                                                        return ep_;
                                                                                    }
                                                                                    else
                                                                                    {
                                                                                        CqlBoolean eq_ = context.Operators.Equal(a_, "years");
                                                                                        if (eq_.IsTrue)
                                                                                        {
                                                                                            decimal? er_ = context.Operators.ConvertIntegerToDecimal(frequency);
                                                                                            decimal? es_ = period?.value;
                                                                                            decimal? et_ = context.Operators.Divide(24.0m, es_);
                                                                                            decimal? eu_ = context.Operators.Multiply(er_, et_);
                                                                                            int? ev_ = context.Operators.Multiply(24, 365);
                                                                                            decimal? ew_ = context.Operators.ConvertIntegerToDecimal(ev_);
                                                                                            decimal? ex_ = context.Operators.Divide(eu_, ew_);
                                                                                            return ex_;
                                                                                        }
                                                                                        else
                                                                                        {
                                                                                            string ey_ = this.ErrorLevel(context);
                                                                                            string ez_ = context.Operators.Concatenate("Unknown unit ", a_ ?? "");
                                                                                            object fa_ = context.Operators.Message<object>((object)null, "CMDLogic.ToDaily.UnknownUnit", ey_, ez_);
                                                                                            return fa_ as decimal?;
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
        CqlBoolean b_ = context.Operators.Equal(frequency, a_);
        if (b_.IsTrue)
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
            List<Dosage> e_ = R?.DosageInstruction;
            Dosage f_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)e_);
            Timing g_ = f_?.Timing;
            Timing.RepeatComponent h_ = g_?.Repeat;
            DataType i_ = h_?.Bounds;
            CqlInterval<CqlDateTime> j_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, i_ as Period);
            CqlDateTime k_ = context.Operators.End(j_);

            CqlBoolean l_() {
                List<Dosage> m_ = R?.DosageInstruction;
                Dosage n_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)m_);
                Timing o_ = n_?.Timing;
                Timing.RepeatComponent p_ = o_?.Repeat;
                DataType q_ = p_?.Bounds;
                CqlInterval<CqlDateTime> r_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, q_ as Period);
                CqlDateTime s_ = context.Operators.End(r_);
                CqlDateTime t_ = context.Operators.MaxValue<CqlDateTime>();
                CqlBoolean u_ = context.Operators.Equal(s_, t_);
                return u_;
            }

            if ((!((bool?)(/* CQL 'or' (177:14-177:84) */ ((CqlBoolean)(k_ is null)
                || l_())))) ?? false)
            {
                CqlDateTime v_ = context.Operators.Start(j_);
                MedicationRequest.DispenseRequestComponent w_ = R?.DispenseRequest;
                Period x_ = w_?.ValidityPeriod;
                CqlInterval<CqlDateTime> y_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, x_);
                CqlDateTime z_ = context.Operators.Start(y_);
                FhirDateTime aa_ = R?.AuthoredOnElement;
                CqlDateTime ab_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, aa_);
                CqlInterval<CqlDateTime> ac_ = context.Operators.Interval((v_ ?? z_) ?? ab_, k_, true, true);
                return ac_;
            }
            else
            {
                CqlDateTime ad_ = context.Operators.Start(j_);
                MedicationRequest.DispenseRequestComponent ae_ = R?.DispenseRequest;
                Period af_ = ae_?.ValidityPeriod;
                CqlInterval<CqlDateTime> ag_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, af_);
                CqlDateTime ah_ = context.Operators.Start(ag_);
                FhirDateTime ai_ = R?.AuthoredOnElement;
                CqlDateTime aj_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, ai_);
                Duration ak_ = ae_?.ExpectedSupplyDuration;
                CqlQuantity al_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, ak_);
                Quantity am_ = ae_?.Quantity;
                CqlQuantity an_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, am_);
                List<Dosage.DoseAndRateComponent> ao_ = f_?.DoseAndRate;
                Dosage.DoseAndRateComponent ap_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)ao_);
                DataType aq_ = ap_?.Dose;
                CqlInterval<CqlQuantity> ar_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, aq_ as Range);
                CqlQuantity as_ = context.Operators.End(ar_);
                CqlQuantity at_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, aq_ as Quantity);
                PositiveInt au_ = h_?.FrequencyMaxElement;
                Integer av_ = context.Operators.Convert<Integer>(au_);
                PositiveInt aw_ = h_?.FrequencyElement;
                Integer ax_ = context.Operators.Convert<Integer>(aw_);
                int? ay_ = FHIRHelpers_4_0_001.Instance.ToInteger(context, av_ ?? ax_);
                FhirDecimal az_ = h_?.PeriodElement;
                decimal? ba_ = FHIRHelpers_4_0_001.Instance.ToDecimal(context, az_);
                Code<Timing.UnitsOfTime> bb_ = h_?.PeriodUnitElement;
                Timing.UnitsOfTime? bc_ = bb_?.Value;
                string bd_ = context.Operators.Convert<string>(bc_);
                decimal? be_ = this.ToDaily(context, ay_, new CqlQuantity(ba_, bd_));
                List<Time> bf_ = h_?.TimeOfDayElement;
                int? bg_ = context.Operators.Count<Time>((IEnumerable<Time>)bf_);
                decimal? bh_ = context.Operators.ConvertIntegerToDecimal(bg_);
                CqlQuantity bi_ = context.Operators.ConvertDecimalToQuantity((be_ ?? bh_) ?? 1.0m);
                CqlQuantity bj_ = context.Operators.Multiply(as_ ?? at_, bi_);
                CqlQuantity bk_ = context.Operators.Divide(an_, bj_);
                UnsignedInt bl_ = ae_?.NumberOfRepeatsAllowedElement;
                Integer bm_ = context.Operators.Convert<Integer>(bl_);
                int? bn_ = FHIRHelpers_4_0_001.Instance.ToInteger(context, bm_);
                int? bo_ = context.Operators.Add(1, bn_ ?? 0);
                CqlQuantity bp_ = context.Operators.ConvertIntegerToQuantity(bo_);
                CqlQuantity bq_ = context.Operators.Multiply(al_ ?? bk_, bp_);
                CqlDateTime br_ = context.Operators.Add((ad_ ?? ah_) ?? aj_, bq_);
                CqlInterval<CqlDateTime> bs_ = context.Operators.Interval((ad_ ?? ah_) ?? aj_, br_, true, true);
                return bs_;
            }
        }

        IEnumerable<CqlInterval<CqlDateTime>> c_ = context.Operators.SelectDistinct<MedicationRequest, CqlInterval<CqlDateTime>>((IEnumerable<MedicationRequest>)a_, b_);
        CqlInterval<CqlDateTime> d_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(c_);
        return d_;
    }


    [CqlFunctionDefinition("MedicationDispensePeriod")]
    public CqlInterval<CqlDateTime> MedicationDispensePeriod(CqlContext context, MedicationDispense Dispense)
    {
        MedicationDispense[] a_ = [
            Dispense,
        ];

        CqlInterval<CqlDateTime> b_(MedicationDispense D) {
            FhirDateTime e_ = D?.WhenHandedOverElement;
            FhirDateTime f_ = D?.WhenPreparedElement;
            CqlDateTime g_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, e_ ?? f_);
            Quantity h_ = D?.DaysSupply;
            CqlQuantity i_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, h_);
            Quantity j_ = D?.Quantity;
            CqlQuantity k_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, j_);
            List<Dosage> l_ = D?.DosageInstruction;
            Dosage m_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)l_);
            List<Dosage.DoseAndRateComponent> n_ = m_?.DoseAndRate;
            Dosage.DoseAndRateComponent o_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)n_);
            DataType p_ = o_?.Dose;
            CqlInterval<CqlQuantity> q_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, p_ as Range);
            CqlQuantity r_ = context.Operators.End(q_);
            CqlQuantity s_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, p_ as Quantity);
            Timing t_ = m_?.Timing;
            Timing.RepeatComponent u_ = t_?.Repeat;
            PositiveInt v_ = u_?.FrequencyMaxElement;
            Integer w_ = context.Operators.Convert<Integer>(v_);
            PositiveInt x_ = u_?.FrequencyElement;
            Integer y_ = context.Operators.Convert<Integer>(x_);
            int? z_ = FHIRHelpers_4_0_001.Instance.ToInteger(context, w_ ?? y_);
            FhirDecimal aa_ = u_?.PeriodElement;
            decimal? ab_ = FHIRHelpers_4_0_001.Instance.ToDecimal(context, aa_);
            Code<Timing.UnitsOfTime> ac_ = u_?.PeriodUnitElement;
            Timing.UnitsOfTime? ad_ = ac_?.Value;
            string ae_ = context.Operators.Convert<string>(ad_);
            decimal? af_ = this.ToDaily(context, z_, new CqlQuantity(ab_, ae_));
            List<Time> ag_ = u_?.TimeOfDayElement;
            int? ah_ = context.Operators.Count<Time>((IEnumerable<Time>)ag_);
            decimal? ai_ = context.Operators.ConvertIntegerToDecimal(ah_);
            CqlQuantity aj_ = context.Operators.ConvertDecimalToQuantity((af_ ?? ai_) ?? 1.0m);
            CqlQuantity ak_ = context.Operators.Multiply(r_ ?? s_, aj_);
            CqlQuantity al_ = context.Operators.Divide(k_, ak_);
            CqlDateTime am_ = context.Operators.Add(g_, i_ ?? al_);
            CqlInterval<CqlDateTime> an_ = context.Operators.Interval(g_, am_, true, true);
            return an_;
        }

        IEnumerable<CqlInterval<CqlDateTime>> c_ = context.Operators.SelectDistinct<MedicationDispense, CqlInterval<CqlDateTime>>((IEnumerable<MedicationDispense>)a_, b_);
        CqlInterval<CqlDateTime> d_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(c_);
        return d_;
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
            DataType e_ = Administration?.Effective;
            CqlInterval<CqlDateTime> f_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, e_ as Period);
            CqlDateTime g_ = context.Operators.Start(f_);

            CqlBoolean h_() {
                DataType i_ = Administration?.Medication;
                CqlConcept j_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, i_ as CodeableConcept);
                CqlQuantity k_ = this.TherapeuticDuration(context, j_);
                return !((bool?)(k_ is null));
            }

            if (((bool?)(/* CQL 'and' (312:10-312:66) */ ((CqlBoolean)(!((bool?)(g_ is null)))
                && h_()))) ?? false)
            {
                DataType l_ = Administration?.Medication;
                CqlConcept m_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, l_ as CodeableConcept);
                CqlQuantity n_ = this.TherapeuticDuration(context, m_);
                CqlDateTime o_ = context.Operators.Add(g_, n_);
                CqlInterval<CqlDateTime> p_ = context.Operators.Interval(g_, o_, true, true);
                return p_;
            }
            else
            {
                return null as CqlInterval<CqlDateTime>;
            }
        }

        IEnumerable<CqlInterval<CqlDateTime>> c_ = context.Operators.SelectDistinct<MedicationAdministration, CqlInterval<CqlDateTime>>((IEnumerable<MedicationAdministration>)a_, b_);
        CqlInterval<CqlDateTime> d_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(c_);
        return d_;
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
                CqlInterval<CqlDateTime> i_ = context.Operators.Last<CqlInterval<CqlDateTime>>(R);
                CqlDateTime j_ = context.Operators.End(i_);
                CqlQuantity k_ = context.Operators.Quantity(1m, "day");
                CqlDateTime l_ = context.Operators.Add(j_, k_);
                CqlDateTime m_ = context.Operators.Start(X);
                CqlDateTime[] n_ = [
                    l_,
                    m_,
                ];
                CqlDateTime o_ = context.Operators.Max<CqlDateTime>((IEnumerable<CqlDateTime>)n_);
                CqlDateTime p_ = context.Operators.End(X);
                int? q_ = context.Operators.DurationBetween(m_, p_, "day");
                decimal? r_ = context.Operators.ConvertIntegerToDecimal(q_ ?? 0);
                CqlDateTime s_ = context.Operators.Add(o_, new CqlQuantity(r_, "day"));
                CqlInterval<CqlDateTime> t_ = context.Operators.Interval(o_, s_, true, true);
                return t_;
            }

            IEnumerable<CqlInterval<CqlDateTime>> e_ = context.Operators.SelectDistinct<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>((IEnumerable<CqlInterval<CqlDateTime>>)c_, d_);
            CqlInterval<CqlDateTime> f_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(e_);
            CqlInterval<CqlDateTime>[] g_ = [
                f_,
            ];
            IEnumerable<CqlInterval<CqlDateTime>> h_ = context.Operators.Union<CqlInterval<CqlDateTime>>(R, (IEnumerable<CqlInterval<CqlDateTime>>)g_);
            return h_;
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
            bool l_ = M is MedicationRequest;
            return l_;
        }


        CqlInterval<CqlDateTime> b_(object M) {
            CqlInterval<CqlDateTime> m_ = this.MedicationPeriod(context, M);
            return m_;
        }

        IEnumerable<CqlInterval<CqlDateTime>> c_ = context.Operators.WhereSelect<object, CqlInterval<CqlDateTime>>(Medications, a_, b_);
        IEnumerable<CqlInterval<CqlDateTime>> d_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(c_);

        bool? e_(object M) {
            bool n_ = M is MedicationDispense;
            return /* CQL 'or' (378:13-378:74) */ (n_
                || (M is MedicationAdministration));
        }


        CqlInterval<CqlDateTime> f_(object M) {
            CqlInterval<CqlDateTime> o_ = this.MedicationPeriod(context, M);
            return o_;
        }

        IEnumerable<CqlInterval<CqlDateTime>> g_ = context.Operators.WhereSelect<object, CqlInterval<CqlDateTime>>(Medications, e_, f_);
        IEnumerable<CqlInterval<CqlDateTime>> h_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(g_);
        IEnumerable<CqlInterval<CqlDateTime>> i_ = this.RolloutIntervals(context, h_);
        IEnumerable<CqlInterval<CqlDateTime>> j_ = context.Operators.Union<CqlInterval<CqlDateTime>>(d_, i_);
        int? k_ = this.CumulativeDuration(context, j_);
        return k_;
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
