#nullable enable

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
    public string? ErrorLevel(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_ErrorLevel, ErrorLevel_Compute);

    private const long _cacheIndex_ErrorLevel = -3474294828027834309L;

    private string? ErrorLevel_Compute(CqlContext context)
    {
        object? a_ = context.ResolveParameter("CumulativeMedicationDurationFHIR4-1.0.000", "ErrorLevel", "Warning");
        return (string?)a_;
    }


    #endregion Parameters

    #region Functions and Expressions (11)

    [CqlExpressionDefinition("Patient")]
    public Patient? Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = 489454038755907576L;

    private Patient? Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient?>? a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient? b_ = context.Operators.SingletonFrom<Patient?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToDaily")]
    public decimal? ToDaily(CqlContext context, int? frequency, CqlQuantity? period)
    {
        string? a_ = period?.unit;
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
            string? g_ = period?.unit;
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
                string? o_ = period?.unit;
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
                    string? x_ = period?.unit;
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
                        string? af_ = period?.unit;
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
                            string? ao_ = period?.unit;
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
                                string? ax_ = period?.unit;
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
                                    string? bg_ = period?.unit;
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
                                        string? bm_ = period?.unit;
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
                                            string? bu_ = period?.unit;
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
                                                string? cd_ = period?.unit;
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
                                                    string? cl_ = period?.unit;
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
                                                        string? cu_ = period?.unit;
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
                                                            string? dd_ = period?.unit;
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
                                                                string? dm_ = period?.unit;
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
                                                                    string? ds_ = period?.unit;
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
                                                                        string? ea_ = period?.unit;
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
                                                                            string? ej_ = period?.unit;
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
                                                                                string? er_ = period?.unit;
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
                                                                                    string? fa_ = period?.unit;
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
                                                                                        string? fj_ = period?.unit;
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
                                                                                            string? fs_ = this.ErrorLevel(context);
                                                                                            string? ft_ = period?.unit;
                                                                                            string? fu_ = context.Operators.Concatenate("Unknown unit ", ft_ ?? "");
                                                                                            object? fv_ = context.Operators.Message<object?>((object?)null, "CMDLogic.ToDaily.UnknownUnit", fs_!, fu_!);
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
    public decimal? ToDaily(CqlContext context, CqlCode? frequency)
    {
        CqlCode? a_ = this.C(context);
        bool? b_ = context.Operators.Equal(frequency, a_);
        if (b_ ?? false)
        {
            return 3.0m;
        }
        else
        {
            string? c_ = this.ErrorLevel(context);
            string? d_ = frequency?.code;
            string? e_ = context.Operators.Concatenate("Unknown frequency code ", d_ ?? "");
            object? f_ = context.Operators.Message<object?>((object?)null, "CMDLogic.ToDaily.UnknownFrequencyCode", c_!, e_!);
            return f_ as decimal?;
        }
    }


    [CqlFunctionDefinition("MedicationRequestPeriod")]
    public CqlInterval<CqlDateTime?>? MedicationRequestPeriod(CqlContext context, MedicationRequest? Request)
    {
        MedicationRequest?[]? a_ = [
            Request,
        ];

        CqlInterval<CqlDateTime?>? b_(MedicationRequest? R) {
            List<Dosage>? e_ = R?.DosageInstruction;
            Dosage? f_ = context.Operators.SingletonFrom<Dosage?>((IEnumerable<Dosage?>?)e_);
            Timing? g_ = f_?.Timing;
            Timing.RepeatComponent? h_ = g_?.Repeat;
            DataType? i_ = h_?.Bounds;
            CqlInterval<CqlDateTime?>? j_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, i_ as Period);
            CqlDateTime? k_ = context.Operators.End(j_);
            CqlDateTime? l_ = context.Operators.MaxValue<CqlDateTime?>();
            bool? m_ = context.Operators.Equal(k_, l_);
            bool? n_ = context.Operators.Or((bool?)(k_ is null), m_);
            bool? o_ = context.Operators.Not(n_);
            if (o_ ?? false)
            {
                List<Dosage>? p_ = R?.DosageInstruction;
                Dosage? q_ = context.Operators.SingletonFrom<Dosage?>((IEnumerable<Dosage?>?)p_);
                Timing? r_ = q_?.Timing;
                Timing.RepeatComponent? s_ = r_?.Repeat;
                DataType? t_ = s_?.Bounds;
                CqlInterval<CqlDateTime?>? u_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, t_ as Period);
                CqlDateTime? v_ = context.Operators.Start(u_);
                MedicationRequest.DispenseRequestComponent? w_ = R?.DispenseRequest;
                Period? x_ = w_?.ValidityPeriod;
                CqlInterval<CqlDateTime?>? y_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, x_);
                CqlDateTime? z_ = context.Operators.Start(y_);
                FhirDateTime? aa_ = R?.AuthoredOnElement;
                CqlDateTime? ab_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, aa_);
                CqlDateTime? ac_ = context.Operators.End(u_);
                CqlInterval<CqlDateTime?>? ad_ = context.Operators.Interval((v_ ?? z_) ?? ab_, ac_, true, true);
                return ad_;
            }
            else
            {
                List<Dosage>? ae_ = R?.DosageInstruction;
                Dosage? af_ = context.Operators.SingletonFrom<Dosage?>((IEnumerable<Dosage?>?)ae_);
                Timing? ag_ = af_?.Timing;
                Timing.RepeatComponent? ah_ = ag_?.Repeat;
                DataType? ai_ = ah_?.Bounds;
                CqlInterval<CqlDateTime?>? aj_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ai_ as Period);
                CqlDateTime? ak_ = context.Operators.Start(aj_);
                MedicationRequest.DispenseRequestComponent? al_ = R?.DispenseRequest;
                Period? am_ = al_?.ValidityPeriod;
                CqlInterval<CqlDateTime?>? an_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, am_);
                CqlDateTime? ao_ = context.Operators.Start(an_);
                FhirDateTime? ap_ = R?.AuthoredOnElement;
                CqlDateTime? aq_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, ap_);
                Duration? ar_ = al_?.ExpectedSupplyDuration;
                CqlQuantity? as_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, ar_);
                Quantity? at_ = al_?.Quantity;
                CqlQuantity? au_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, at_);
                List<Dosage.DoseAndRateComponent>? av_ = af_?.DoseAndRate;
                Dosage.DoseAndRateComponent? aw_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent?>((IEnumerable<Dosage.DoseAndRateComponent?>?)av_);
                DataType? ax_ = aw_?.Dose;
                CqlInterval<CqlQuantity?>? ay_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ax_ as Range);
                CqlQuantity? az_ = context.Operators.End(ay_);
                CqlQuantity? ba_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, ax_ as Quantity);
                PositiveInt? bb_ = ah_?.FrequencyMaxElement;
                Integer? bc_ = context.Operators.Convert<Integer?>(bb_);
                PositiveInt? bd_ = ah_?.FrequencyElement;
                Integer? be_ = context.Operators.Convert<Integer?>(bd_);
                int? bf_ = FHIRHelpers_4_0_001.Instance.ToInteger(context, bc_ ?? be_);
                FhirDecimal? bg_ = ah_?.PeriodElement;
                decimal? bh_ = FHIRHelpers_4_0_001.Instance.ToDecimal(context, bg_);
                Code<Timing.UnitsOfTime>? bi_ = ah_?.PeriodUnitElement;
                Timing.UnitsOfTime? bj_ = bi_?.Value;
                string? bk_ = context.Operators.Convert<string?>(bj_);
                decimal? bl_ = this.ToDaily(context, bf_, new CqlQuantity(bh_, bk_));
                List<Time>? bm_ = ah_?.TimeOfDayElement;
                int? bn_ = context.Operators.Count<Time?>((IEnumerable<Time?>?)bm_);
                decimal? bo_ = context.Operators.ConvertIntegerToDecimal(bn_);
                CqlQuantity? bp_ = context.Operators.ConvertDecimalToQuantity((bl_ ?? bo_) ?? 1.0m);
                CqlQuantity? bq_ = context.Operators.Multiply(az_ ?? ba_, bp_);
                CqlQuantity? br_ = context.Operators.Divide(au_, bq_);
                UnsignedInt? bs_ = al_?.NumberOfRepeatsAllowedElement;
                Integer? bt_ = context.Operators.Convert<Integer?>(bs_);
                int? bu_ = FHIRHelpers_4_0_001.Instance.ToInteger(context, bt_);
                int? bv_ = context.Operators.Add(1, bu_ ?? 0);
                CqlQuantity? bw_ = context.Operators.ConvertIntegerToQuantity(bv_);
                CqlQuantity? bx_ = context.Operators.Multiply(as_ ?? br_, bw_);
                CqlDateTime? by_ = context.Operators.Add((ak_ ?? ao_) ?? aq_, bx_);
                CqlInterval<CqlDateTime?>? bz_ = context.Operators.Interval((ak_ ?? ao_) ?? aq_, by_, true, true);
                return bz_;
            }
        }

        IEnumerable<CqlInterval<CqlDateTime?>?>? c_ = context.Operators.SelectDistinct<MedicationRequest?, CqlInterval<CqlDateTime?>?>((IEnumerable<MedicationRequest?>?)a_, b_);
        CqlInterval<CqlDateTime?>? d_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime?>?>(c_);
        return d_;
    }


    [CqlFunctionDefinition("MedicationDispensePeriod")]
    public CqlInterval<CqlDateTime?>? MedicationDispensePeriod(CqlContext context, MedicationDispense? Dispense)
    {
        MedicationDispense?[]? a_ = [
            Dispense,
        ];

        CqlInterval<CqlDateTime?>? b_(MedicationDispense? D) {
            FhirDateTime? e_ = D?.WhenHandedOverElement;
            FhirDateTime? f_ = D?.WhenPreparedElement;
            CqlDateTime? g_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, e_ ?? f_);
            Quantity? h_ = D?.DaysSupply;
            CqlQuantity? i_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, h_);
            Quantity? j_ = D?.Quantity;
            CqlQuantity? k_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, j_);
            List<Dosage>? l_ = D?.DosageInstruction;
            Dosage? m_ = context.Operators.SingletonFrom<Dosage?>((IEnumerable<Dosage?>?)l_);
            List<Dosage.DoseAndRateComponent>? n_ = m_?.DoseAndRate;
            Dosage.DoseAndRateComponent? o_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent?>((IEnumerable<Dosage.DoseAndRateComponent?>?)n_);
            DataType? p_ = o_?.Dose;
            CqlInterval<CqlQuantity?>? q_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, p_ as Range);
            CqlQuantity? r_ = context.Operators.End(q_);
            CqlQuantity? s_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, p_ as Quantity);
            Timing? t_ = m_?.Timing;
            Timing.RepeatComponent? u_ = t_?.Repeat;
            PositiveInt? v_ = u_?.FrequencyMaxElement;
            Integer? w_ = context.Operators.Convert<Integer?>(v_);
            PositiveInt? x_ = u_?.FrequencyElement;
            Integer? y_ = context.Operators.Convert<Integer?>(x_);
            int? z_ = FHIRHelpers_4_0_001.Instance.ToInteger(context, w_ ?? y_);
            FhirDecimal? aa_ = u_?.PeriodElement;
            decimal? ab_ = FHIRHelpers_4_0_001.Instance.ToDecimal(context, aa_);
            Code<Timing.UnitsOfTime>? ac_ = u_?.PeriodUnitElement;
            Timing.UnitsOfTime? ad_ = ac_?.Value;
            string? ae_ = context.Operators.Convert<string?>(ad_);
            decimal? af_ = this.ToDaily(context, z_, new CqlQuantity(ab_, ae_));
            List<Time>? ag_ = u_?.TimeOfDayElement;
            int? ah_ = context.Operators.Count<Time?>((IEnumerable<Time?>?)ag_);
            decimal? ai_ = context.Operators.ConvertIntegerToDecimal(ah_);
            CqlQuantity? aj_ = context.Operators.ConvertDecimalToQuantity((af_ ?? ai_) ?? 1.0m);
            CqlQuantity? ak_ = context.Operators.Multiply(r_ ?? s_, aj_);
            CqlQuantity? al_ = context.Operators.Divide(k_, ak_);
            CqlDateTime? am_ = context.Operators.Add(g_, i_ ?? al_);
            CqlInterval<CqlDateTime?>? an_ = context.Operators.Interval(g_, am_, true, true);
            return an_;
        }

        IEnumerable<CqlInterval<CqlDateTime?>?>? c_ = context.Operators.SelectDistinct<MedicationDispense?, CqlInterval<CqlDateTime?>?>((IEnumerable<MedicationDispense?>?)a_, b_);
        CqlInterval<CqlDateTime?>? d_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime?>?>(c_);
        return d_;
    }


    [CqlFunctionDefinition("TherapeuticDuration")]
    public CqlQuantity? TherapeuticDuration(CqlContext context, CqlConcept? medication)
    {
        CqlQuantity? a_ = context.Operators.Quantity(14m, "days");
        return a_;
    }


    [CqlFunctionDefinition("MedicationAdministrationPeriod")]
    public CqlInterval<CqlDateTime?>? MedicationAdministrationPeriod(CqlContext context, MedicationAdministration? Administration)
    {
        MedicationAdministration?[]? a_ = [
            Administration,
        ];

        CqlInterval<CqlDateTime?>? b_(MedicationAdministration? M) {
            DataType? e_ = Administration?.Effective;
            CqlInterval<CqlDateTime?>? f_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, e_ as Period);
            CqlDateTime? g_ = context.Operators.Start(f_);
            bool? h_ = context.Operators.Not((bool?)(g_ is null));
            DataType? i_ = Administration?.Medication;
            CqlConcept? j_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, i_ as CodeableConcept);
            CqlQuantity? k_ = this.TherapeuticDuration(context, j_);
            bool? l_ = context.Operators.Not((bool?)(k_ is null));
            bool? m_ = context.Operators.And(h_, l_);
            if (m_ ?? false)
            {
                DataType? n_ = Administration?.Effective;
                CqlInterval<CqlDateTime?>? o_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, n_ as Period);
                CqlDateTime? p_ = context.Operators.Start(o_);
                DataType? q_ = Administration?.Medication;
                CqlConcept? r_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, q_ as CodeableConcept);
                CqlQuantity? s_ = this.TherapeuticDuration(context, r_);
                CqlDateTime? t_ = context.Operators.Add(p_, s_);
                CqlInterval<CqlDateTime?>? u_ = context.Operators.Interval(p_, t_, true, true);
                return u_;
            }
            else
            {
                return null as CqlInterval<CqlDateTime?>;
            }
        }

        IEnumerable<CqlInterval<CqlDateTime?>?>? c_ = context.Operators.SelectDistinct<MedicationAdministration?, CqlInterval<CqlDateTime?>?>((IEnumerable<MedicationAdministration?>?)a_, b_);
        CqlInterval<CqlDateTime?>? d_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime?>?>(c_);
        return d_;
    }


    [CqlFunctionDefinition("CumulativeDuration")]
    public int? CumulativeDuration(CqlContext context, IEnumerable<CqlInterval<CqlDateTime?>?>? Intervals)
    {
        IEnumerable<CqlInterval<CqlDateTime?>?>? a_ = context.Operators.Collapse(Intervals, "day");

        int? b_(CqlInterval<CqlDateTime?>? X) {
            CqlDateTime? e_ = context.Operators.Start(X);
            CqlDateTime? f_ = context.Operators.End(X);
            int? g_ = context.Operators.DifferenceBetween(e_, f_, "day");
            return g_;
        }

        IEnumerable<int?>? c_ = context.Operators.Select<CqlInterval<CqlDateTime?>?, int?>(a_, b_);
        int? d_ = context.Operators.Sum(c_);
        return d_;
    }


    [CqlFunctionDefinition("RolloutIntervals")]
    public IEnumerable<CqlInterval<CqlDateTime?>?>? RolloutIntervals(CqlContext context, IEnumerable<CqlInterval<CqlDateTime?>?>? intervals)
    {

        IEnumerable<CqlInterval<CqlDateTime?>?>? a_(IEnumerable<CqlInterval<CqlDateTime?>?>? R, CqlInterval<CqlDateTime?>? I) {
            CqlInterval<CqlDateTime?>?[]? c_ = [
                I,
            ];

            CqlInterval<CqlDateTime?>? d_(CqlInterval<CqlDateTime?>? X) {
                CqlInterval<CqlDateTime?>? i_ = context.Operators.Last<CqlInterval<CqlDateTime?>?>(((IEnumerable<CqlInterval<CqlDateTime>>)R)!);
                CqlDateTime? j_ = context.Operators.End(i_);
                CqlQuantity? k_ = context.Operators.Quantity(1m, "day");
                CqlDateTime? l_ = context.Operators.Add(j_, k_);
                CqlDateTime? m_ = context.Operators.Start(X);
                CqlDateTime?[]? n_ = [
                    l_,
                    m_,
                ];
                CqlDateTime? o_ = context.Operators.Max<CqlDateTime?>((IEnumerable<CqlDateTime?>?)n_);
                CqlDateTime? p_ = context.Operators.End(X);
                int? q_ = context.Operators.DurationBetween(m_, p_, "day");
                decimal? r_ = context.Operators.ConvertIntegerToDecimal(q_ ?? 0);
                CqlDateTime? s_ = context.Operators.Add(o_, new CqlQuantity(r_, "day"));
                CqlInterval<CqlDateTime?>? t_ = context.Operators.Interval(o_, s_, true, true);
                return t_;
            }

            IEnumerable<CqlInterval<CqlDateTime?>?>? e_ = context.Operators.SelectDistinct<CqlInterval<CqlDateTime?>?, CqlInterval<CqlDateTime?>?>((IEnumerable<CqlInterval<CqlDateTime?>?>?)c_, d_);
            CqlInterval<CqlDateTime?>? f_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime?>?>(e_);
            CqlInterval<CqlDateTime?>?[]? g_ = [
                f_,
            ];
            IEnumerable<CqlInterval<CqlDateTime?>?>? h_ = context.Operators.Union<CqlInterval<CqlDateTime?>?>(R, (IEnumerable<CqlInterval<CqlDateTime?>?>?)g_);
            return h_;
        }

        IEnumerable<CqlInterval<CqlDateTime?>?>? b_ = context.Operators.Aggregate<CqlInterval<CqlDateTime?>?, IEnumerable<CqlInterval<CqlDateTime?>?>?>(intervals, a_, null as IEnumerable<CqlInterval<CqlDateTime?>?>);
        return b_;
    }


    [CqlFunctionDefinition("MedicationPeriod")]
    public CqlInterval<CqlDateTime?>? MedicationPeriod(CqlContext context, object? medication)
    {
        if (medication is MedicationRequest)
        {
            CqlInterval<CqlDateTime?>? a_ = this.MedicationRequestPeriod(context, medication as MedicationRequest);
            return a_;
        }
        else if (medication is MedicationDispense)
        {
            CqlInterval<CqlDateTime?>? b_ = this.MedicationDispensePeriod(context, medication as MedicationDispense);
            return b_;
        }
        else if (medication is MedicationAdministration)
        {
            CqlInterval<CqlDateTime?>? c_ = this.MedicationAdministrationPeriod(context, medication as MedicationAdministration);
            return c_;
        }
        else
        {
            return null as CqlInterval<CqlDateTime?>;
        }
    }


    [CqlFunctionDefinition("CumulativeMedicationDuration")]
    public int? CumulativeMedicationDuration(CqlContext context, IEnumerable<object?>? Medications)
    {

        bool? a_(object? M) {
            bool l_ = M is MedicationRequest;
            return l_ as bool?;
        }


        CqlInterval<CqlDateTime?>? b_(object? M) {
            CqlInterval<CqlDateTime?>? m_ = this.MedicationPeriod(context, M);
            return m_;
        }

        IEnumerable<CqlInterval<CqlDateTime?>?>? c_ = context.Operators.WhereSelect<object?, CqlInterval<CqlDateTime?>?>(Medications, a_, b_);
        IEnumerable<CqlInterval<CqlDateTime?>?>? d_ = context.Operators.Distinct<CqlInterval<CqlDateTime?>?>(((IEnumerable<CqlInterval<CqlDateTime>>)c_)!);

        bool? e_(object? M) {
            bool n_ = M is MedicationDispense;
            bool o_ = M is MedicationAdministration;
            bool? p_ = context.Operators.Or(n_ as bool?, o_ as bool?);
            return p_;
        }


        CqlInterval<CqlDateTime?>? f_(object? M) {
            CqlInterval<CqlDateTime?>? q_ = this.MedicationPeriod(context, M);
            return q_;
        }

        IEnumerable<CqlInterval<CqlDateTime?>?>? g_ = context.Operators.WhereSelect<object?, CqlInterval<CqlDateTime?>?>(Medications, e_, f_);
        IEnumerable<CqlInterval<CqlDateTime?>?>? h_ = context.Operators.Distinct<CqlInterval<CqlDateTime?>?>(((IEnumerable<CqlInterval<CqlDateTime>>)g_)!);
        IEnumerable<CqlInterval<CqlDateTime?>?>? i_ = this.RolloutIntervals(context, h_);
        IEnumerable<CqlInterval<CqlDateTime?>?>? j_ = context.Operators.Union<CqlInterval<CqlDateTime?>?>(d_, i_);
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
