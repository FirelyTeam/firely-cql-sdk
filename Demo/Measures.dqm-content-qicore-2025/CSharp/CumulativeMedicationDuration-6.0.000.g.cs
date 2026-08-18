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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.3.6.0")]
[CqlLibrary("CumulativeMedicationDuration", "6.0.000")]
public partial class CumulativeMedicationDuration_6_0_000 : ILibrary, ISingleton<CumulativeMedicationDuration_6_0_000>
{
    #region Codes (48)

    [CqlCodeDefinition("HS", codeId: "HS", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-TimingEvent")]
    public CqlCode HS(CqlContext _) => _HS;
    private static readonly CqlCode _HS = new CqlCode("HS", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent");

    [CqlCodeDefinition("WAKE", codeId: "WAKE", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-TimingEvent")]
    public CqlCode WAKE(CqlContext _) => _WAKE;
    private static readonly CqlCode _WAKE = new CqlCode("WAKE", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent");

    [CqlCodeDefinition("C", codeId: "C", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-TimingEvent")]
    public CqlCode C(CqlContext _) => _C;
    private static readonly CqlCode _C = new CqlCode("C", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent");

    [CqlCodeDefinition("CM", codeId: "CM", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-TimingEvent")]
    public CqlCode CM(CqlContext _) => _CM;
    private static readonly CqlCode _CM = new CqlCode("CM", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent");

    [CqlCodeDefinition("CD", codeId: "CD", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-TimingEvent")]
    public CqlCode CD(CqlContext _) => _CD;
    private static readonly CqlCode _CD = new CqlCode("CD", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent");

    [CqlCodeDefinition("CV", codeId: "CV", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-TimingEvent")]
    public CqlCode CV(CqlContext _) => _CV;
    private static readonly CqlCode _CV = new CqlCode("CV", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent");

    [CqlCodeDefinition("AC", codeId: "AC", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-TimingEvent")]
    public CqlCode AC(CqlContext _) => _AC;
    private static readonly CqlCode _AC = new CqlCode("AC", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent");

    [CqlCodeDefinition("ACM", codeId: "ACM", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-TimingEvent")]
    public CqlCode ACM(CqlContext _) => _ACM;
    private static readonly CqlCode _ACM = new CqlCode("ACM", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent");

    [CqlCodeDefinition("ACD", codeId: "ACD", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-TimingEvent")]
    public CqlCode ACD(CqlContext _) => _ACD;
    private static readonly CqlCode _ACD = new CqlCode("ACD", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent");

    [CqlCodeDefinition("ACV", codeId: "ACV", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-TimingEvent")]
    public CqlCode ACV(CqlContext _) => _ACV;
    private static readonly CqlCode _ACV = new CqlCode("ACV", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent");

    [CqlCodeDefinition("PC", codeId: "PC", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-TimingEvent")]
    public CqlCode PC(CqlContext _) => _PC;
    private static readonly CqlCode _PC = new CqlCode("PC", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent");

    [CqlCodeDefinition("PCM", codeId: "PCM", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-TimingEvent")]
    public CqlCode PCM(CqlContext _) => _PCM;
    private static readonly CqlCode _PCM = new CqlCode("PCM", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent");

    [CqlCodeDefinition("PCD", codeId: "PCD", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-TimingEvent")]
    public CqlCode PCD(CqlContext _) => _PCD;
    private static readonly CqlCode _PCD = new CqlCode("PCD", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent");

    [CqlCodeDefinition("PCV", codeId: "PCV", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-TimingEvent")]
    public CqlCode PCV(CqlContext _) => _PCV;
    private static readonly CqlCode _PCV = new CqlCode("PCV", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent");

    [CqlCodeDefinition("MORN", codeId: "MORN", codeSystem: "http://hl7.org/fhir/event-timing")]
    public CqlCode MORN(CqlContext _) => _MORN;
    private static readonly CqlCode _MORN = new CqlCode("MORN", "http://hl7.org/fhir/event-timing");

    [CqlCodeDefinition("MORN.early", codeId: "MORN.early", codeSystem: "http://hl7.org/fhir/event-timing")]
    public CqlCode MORN_early(CqlContext _) => _MORN_early;
    private static readonly CqlCode _MORN_early = new CqlCode("MORN.early", "http://hl7.org/fhir/event-timing");

    [CqlCodeDefinition("MORN.late", codeId: "MORN.late", codeSystem: "http://hl7.org/fhir/event-timing")]
    public CqlCode MORN_late(CqlContext _) => _MORN_late;
    private static readonly CqlCode _MORN_late = new CqlCode("MORN.late", "http://hl7.org/fhir/event-timing");

    [CqlCodeDefinition("NOON", codeId: "NOON", codeSystem: "http://hl7.org/fhir/event-timing")]
    public CqlCode NOON(CqlContext _) => _NOON;
    private static readonly CqlCode _NOON = new CqlCode("NOON", "http://hl7.org/fhir/event-timing");

    [CqlCodeDefinition("AFT", codeId: "AFT", codeSystem: "http://hl7.org/fhir/event-timing")]
    public CqlCode AFT(CqlContext _) => _AFT;
    private static readonly CqlCode _AFT = new CqlCode("AFT", "http://hl7.org/fhir/event-timing");

    [CqlCodeDefinition("AFT.early", codeId: "AFT.early", codeSystem: "http://hl7.org/fhir/event-timing")]
    public CqlCode AFT_early(CqlContext _) => _AFT_early;
    private static readonly CqlCode _AFT_early = new CqlCode("AFT.early", "http://hl7.org/fhir/event-timing");

    [CqlCodeDefinition("AFT.late", codeId: "AFT.late", codeSystem: "http://hl7.org/fhir/event-timing")]
    public CqlCode AFT_late(CqlContext _) => _AFT_late;
    private static readonly CqlCode _AFT_late = new CqlCode("AFT.late", "http://hl7.org/fhir/event-timing");

    [CqlCodeDefinition("EVE", codeId: "EVE", codeSystem: "http://hl7.org/fhir/event-timing")]
    public CqlCode EVE(CqlContext _) => _EVE;
    private static readonly CqlCode _EVE = new CqlCode("EVE", "http://hl7.org/fhir/event-timing");

    [CqlCodeDefinition("EVE.early", codeId: "EVE.early", codeSystem: "http://hl7.org/fhir/event-timing")]
    public CqlCode EVE_early(CqlContext _) => _EVE_early;
    private static readonly CqlCode _EVE_early = new CqlCode("EVE.early", "http://hl7.org/fhir/event-timing");

    [CqlCodeDefinition("EVE.late", codeId: "EVE.late", codeSystem: "http://hl7.org/fhir/event-timing")]
    public CqlCode EVE_late(CqlContext _) => _EVE_late;
    private static readonly CqlCode _EVE_late = new CqlCode("EVE.late", "http://hl7.org/fhir/event-timing");

    [CqlCodeDefinition("NIGHT", codeId: "NIGHT", codeSystem: "http://hl7.org/fhir/event-timing")]
    public CqlCode NIGHT(CqlContext _) => _NIGHT;
    private static readonly CqlCode _NIGHT = new CqlCode("NIGHT", "http://hl7.org/fhir/event-timing");

    [CqlCodeDefinition("PHS", codeId: "PHS", codeSystem: "http://hl7.org/fhir/event-timing")]
    public CqlCode PHS(CqlContext _) => _PHS;
    private static readonly CqlCode _PHS = new CqlCode("PHS", "http://hl7.org/fhir/event-timing");

    [CqlCodeDefinition("Every eight hours (qualifier value)", codeId: "307469008", codeSystem: "http://snomed.info/sct")]
    public CqlCode Every_eight_hours__qualifier_value_(CqlContext _) => _Every_eight_hours__qualifier_value_;
    private static readonly CqlCode _Every_eight_hours__qualifier_value_ = new CqlCode("307469008", "http://snomed.info/sct");

    [CqlCodeDefinition("Every eight to twelve hours (qualifier value)", codeId: "396140003", codeSystem: "http://snomed.info/sct")]
    public CqlCode Every_eight_to_twelve_hours__qualifier_value_(CqlContext _) => _Every_eight_to_twelve_hours__qualifier_value_;
    private static readonly CqlCode _Every_eight_to_twelve_hours__qualifier_value_ = new CqlCode("396140003", "http://snomed.info/sct");

    [CqlCodeDefinition("Every forty eight hours (qualifier value)", codeId: "396131002", codeSystem: "http://snomed.info/sct")]
    public CqlCode Every_forty_eight_hours__qualifier_value_(CqlContext _) => _Every_forty_eight_hours__qualifier_value_;
    private static readonly CqlCode _Every_forty_eight_hours__qualifier_value_ = new CqlCode("396131002", "http://snomed.info/sct");

    [CqlCodeDefinition("Every forty hours (qualifier value)", codeId: "396130001", codeSystem: "http://snomed.info/sct")]
    public CqlCode Every_forty_hours__qualifier_value_(CqlContext _) => _Every_forty_hours__qualifier_value_;
    private static readonly CqlCode _Every_forty_hours__qualifier_value_ = new CqlCode("396130001", "http://snomed.info/sct");

    [CqlCodeDefinition("Every four hours (qualifier value)", codeId: "225756002", codeSystem: "http://snomed.info/sct")]
    public CqlCode Every_four_hours__qualifier_value_(CqlContext _) => _Every_four_hours__qualifier_value_;
    private static readonly CqlCode _Every_four_hours__qualifier_value_ = new CqlCode("225756002", "http://snomed.info/sct");

    [CqlCodeDefinition("Every seventy two hours (qualifier value)", codeId: "396143001", codeSystem: "http://snomed.info/sct")]
    public CqlCode Every_seventy_two_hours__qualifier_value_(CqlContext _) => _Every_seventy_two_hours__qualifier_value_;
    private static readonly CqlCode _Every_seventy_two_hours__qualifier_value_ = new CqlCode("396143001", "http://snomed.info/sct");

    [CqlCodeDefinition("Every six hours (qualifier value)", codeId: "307468000", codeSystem: "http://snomed.info/sct")]
    public CqlCode Every_six_hours__qualifier_value_(CqlContext _) => _Every_six_hours__qualifier_value_;
    private static readonly CqlCode _Every_six_hours__qualifier_value_ = new CqlCode("307468000", "http://snomed.info/sct");

    [CqlCodeDefinition("Every six to eight hours (qualifier value)", codeId: "396139000", codeSystem: "http://snomed.info/sct")]
    public CqlCode Every_six_to_eight_hours__qualifier_value_(CqlContext _) => _Every_six_to_eight_hours__qualifier_value_;
    private static readonly CqlCode _Every_six_to_eight_hours__qualifier_value_ = new CqlCode("396139000", "http://snomed.info/sct");

    [CqlCodeDefinition("Every thirty six hours (qualifier value)", codeId: "396126004", codeSystem: "http://snomed.info/sct")]
    public CqlCode Every_thirty_six_hours__qualifier_value_(CqlContext _) => _Every_thirty_six_hours__qualifier_value_;
    private static readonly CqlCode _Every_thirty_six_hours__qualifier_value_ = new CqlCode("396126004", "http://snomed.info/sct");

    [CqlCodeDefinition("Every three to four hours (qualifier value)", codeId: "225754004", codeSystem: "http://snomed.info/sct")]
    public CqlCode Every_three_to_four_hours__qualifier_value_(CqlContext _) => _Every_three_to_four_hours__qualifier_value_;
    private static readonly CqlCode _Every_three_to_four_hours__qualifier_value_ = new CqlCode("225754004", "http://snomed.info/sct");

    [CqlCodeDefinition("Every three to six hours (qualifier value)", codeId: "396127008", codeSystem: "http://snomed.info/sct")]
    public CqlCode Every_three_to_six_hours__qualifier_value_(CqlContext _) => _Every_three_to_six_hours__qualifier_value_;
    private static readonly CqlCode _Every_three_to_six_hours__qualifier_value_ = new CqlCode("396127008", "http://snomed.info/sct");

    [CqlCodeDefinition("Every twelve hours (qualifier value)", codeId: "307470009", codeSystem: "http://snomed.info/sct")]
    public CqlCode Every_twelve_hours__qualifier_value_(CqlContext _) => _Every_twelve_hours__qualifier_value_;
    private static readonly CqlCode _Every_twelve_hours__qualifier_value_ = new CqlCode("307470009", "http://snomed.info/sct");

    [CqlCodeDefinition("Every twenty four hours (qualifier value)", codeId: "396125000", codeSystem: "http://snomed.info/sct")]
    public CqlCode Every_twenty_four_hours__qualifier_value_(CqlContext _) => _Every_twenty_four_hours__qualifier_value_;
    private static readonly CqlCode _Every_twenty_four_hours__qualifier_value_ = new CqlCode("396125000", "http://snomed.info/sct");

    [CqlCodeDefinition("Every two to four hours (qualifier value)", codeId: "225752000", codeSystem: "http://snomed.info/sct")]
    public CqlCode Every_two_to_four_hours__qualifier_value_(CqlContext _) => _Every_two_to_four_hours__qualifier_value_;
    private static readonly CqlCode _Every_two_to_four_hours__qualifier_value_ = new CqlCode("225752000", "http://snomed.info/sct");

    [CqlCodeDefinition("Four times daily (qualifier value)", codeId: "307439001", codeSystem: "http://snomed.info/sct")]
    public CqlCode Four_times_daily__qualifier_value_(CqlContext _) => _Four_times_daily__qualifier_value_;
    private static readonly CqlCode _Four_times_daily__qualifier_value_ = new CqlCode("307439001", "http://snomed.info/sct");

    [CqlCodeDefinition("Once daily (qualifier value)", codeId: "229797004", codeSystem: "http://snomed.info/sct")]
    public CqlCode Once_daily__qualifier_value_(CqlContext _) => _Once_daily__qualifier_value_;
    private static readonly CqlCode _Once_daily__qualifier_value_ = new CqlCode("229797004", "http://snomed.info/sct");

    [CqlCodeDefinition("One to four times a day (qualifier value)", codeId: "396109005", codeSystem: "http://snomed.info/sct")]
    public CqlCode One_to_four_times_a_day__qualifier_value_(CqlContext _) => _One_to_four_times_a_day__qualifier_value_;
    private static readonly CqlCode _One_to_four_times_a_day__qualifier_value_ = new CqlCode("396109005", "http://snomed.info/sct");

    [CqlCodeDefinition("One to three times a day (qualifier value)", codeId: "396108002", codeSystem: "http://snomed.info/sct")]
    public CqlCode One_to_three_times_a_day__qualifier_value_(CqlContext _) => _One_to_three_times_a_day__qualifier_value_;
    private static readonly CqlCode _One_to_three_times_a_day__qualifier_value_ = new CqlCode("396108002", "http://snomed.info/sct");

    [CqlCodeDefinition("One to two times a day (qualifier value)", codeId: "396107007", codeSystem: "http://snomed.info/sct")]
    public CqlCode One_to_two_times_a_day__qualifier_value_(CqlContext _) => _One_to_two_times_a_day__qualifier_value_;
    private static readonly CqlCode _One_to_two_times_a_day__qualifier_value_ = new CqlCode("396107007", "http://snomed.info/sct");

    [CqlCodeDefinition("Three times daily (qualifier value)", codeId: "229798009", codeSystem: "http://snomed.info/sct")]
    public CqlCode Three_times_daily__qualifier_value_(CqlContext _) => _Three_times_daily__qualifier_value_;
    private static readonly CqlCode _Three_times_daily__qualifier_value_ = new CqlCode("229798009", "http://snomed.info/sct");

    [CqlCodeDefinition("Twice a day (qualifier value)", codeId: "229799001", codeSystem: "http://snomed.info/sct")]
    public CqlCode Twice_a_day__qualifier_value_(CqlContext _) => _Twice_a_day__qualifier_value_;
    private static readonly CqlCode _Twice_a_day__qualifier_value_ = new CqlCode("229799001", "http://snomed.info/sct");

    [CqlCodeDefinition("Two to four times a day (qualifier value)", codeId: "396111001", codeSystem: "http://snomed.info/sct")]
    public CqlCode Two_to_four_times_a_day__qualifier_value_(CqlContext _) => _Two_to_four_times_a_day__qualifier_value_;
    private static readonly CqlCode _Two_to_four_times_a_day__qualifier_value_ = new CqlCode("396111001", "http://snomed.info/sct");

    #endregion Codes

    #region CodeSystems (2)

    [CqlCodeSystemDefinition("V3TimingEvent", codeSystemId: "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", codeSystemVersion: null)]
    public CqlCodeSystem V3TimingEvent(CqlContext _) => _V3TimingEvent;
    private static readonly CqlCodeSystem _V3TimingEvent =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, [
          _HS,
          _WAKE,
          _C,
          _CM,
          _CD,
          _CV,
          _AC,
          _ACM,
          _ACD,
          _ACV,
          _PC,
          _PCM,
          _PCD,
          _PCV]);

    [CqlCodeSystemDefinition("EventTiming", codeSystemId: "http://hl7.org/fhir/event-timing", codeSystemVersion: null)]
    public CqlCodeSystem EventTiming(CqlContext _) => _EventTiming;
    private static readonly CqlCodeSystem _EventTiming =
      new CqlCodeSystem("http://hl7.org/fhir/event-timing", null, [
          _MORN,
          _MORN_early,
          _MORN_late,
          _NOON,
          _AFT,
          _AFT_early,
          _AFT_late,
          _EVE,
          _EVE_early,
          _EVE_late,
          _NIGHT,
          _PHS]);

    #endregion CodeSystems

    #region Parameters (1)

    [CqlParameterDefinition("ErrorLevel")]
    public string ErrorLevel(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_ErrorLevel, ErrorLevel_Compute);

    private const long _cacheIndex_ErrorLevel = 772406137019326219L;

    private string ErrorLevel_Compute(CqlContext context)
    {
        object a_ = context.ResolveParameter("CumulativeMedicationDuration-6.0.000", "ErrorLevel", "Warning");
        return (string)a_;
    }


    #endregion Parameters

    #region Functions and Expressions (19)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = 4069894667121727423L;

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
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
        CqlCode a_ = this.HS(context);
        CqlBoolean b_ = context.Operators.Equivalent(frequency, a_);
        if (b_.IsTrue)
        {
            decimal? c_ = context.Operators.ConvertIntegerToDecimal(1);
            return c_;
        }
        else
        {
            CqlCode d_ = this.WAKE(context);
            CqlBoolean e_ = context.Operators.Equivalent(frequency, d_);
            if (e_.IsTrue)
            {
                decimal? f_ = context.Operators.ConvertIntegerToDecimal(1);
                return f_;
            }
            else
            {
                CqlCode g_ = this.C(context);
                CqlBoolean h_ = context.Operators.Equivalent(frequency, g_);
                if (h_.IsTrue)
                {
                    decimal? i_ = context.Operators.ConvertIntegerToDecimal(3);
                    return i_;
                }
                else
                {
                    CqlCode j_ = this.CM(context);
                    CqlBoolean k_ = context.Operators.Equivalent(frequency, j_);
                    if (k_.IsTrue)
                    {
                        decimal? l_ = context.Operators.ConvertIntegerToDecimal(1);
                        return l_;
                    }
                    else
                    {
                        CqlCode m_ = this.CD(context);
                        CqlBoolean n_ = context.Operators.Equivalent(frequency, m_);
                        if (n_.IsTrue)
                        {
                            decimal? o_ = context.Operators.ConvertIntegerToDecimal(1);
                            return o_;
                        }
                        else
                        {
                            CqlCode p_ = this.CV(context);
                            CqlBoolean q_ = context.Operators.Equivalent(frequency, p_);
                            if (q_.IsTrue)
                            {
                                decimal? r_ = context.Operators.ConvertIntegerToDecimal(1);
                                return r_;
                            }
                            else
                            {
                                CqlCode s_ = this.AC(context);
                                CqlBoolean t_ = context.Operators.Equivalent(frequency, s_);
                                if (t_.IsTrue)
                                {
                                    decimal? u_ = context.Operators.ConvertIntegerToDecimal(3);
                                    return u_;
                                }
                                else
                                {
                                    CqlCode v_ = this.ACM(context);
                                    CqlBoolean w_ = context.Operators.Equivalent(frequency, v_);
                                    if (w_.IsTrue)
                                    {
                                        decimal? x_ = context.Operators.ConvertIntegerToDecimal(1);
                                        return x_;
                                    }
                                    else
                                    {
                                        CqlCode y_ = this.ACD(context);
                                        CqlBoolean z_ = context.Operators.Equivalent(frequency, y_);
                                        if (z_.IsTrue)
                                        {
                                            decimal? aa_ = context.Operators.ConvertIntegerToDecimal(1);
                                            return aa_;
                                        }
                                        else
                                        {
                                            CqlCode ab_ = this.ACV(context);
                                            CqlBoolean ac_ = context.Operators.Equivalent(frequency, ab_);
                                            if (ac_.IsTrue)
                                            {
                                                decimal? ad_ = context.Operators.ConvertIntegerToDecimal(1);
                                                return ad_;
                                            }
                                            else
                                            {
                                                CqlCode ae_ = this.PC(context);
                                                CqlBoolean af_ = context.Operators.Equivalent(frequency, ae_);
                                                if (af_.IsTrue)
                                                {
                                                    decimal? ag_ = context.Operators.ConvertIntegerToDecimal(3);
                                                    return ag_;
                                                }
                                                else
                                                {
                                                    CqlCode ah_ = this.PCM(context);
                                                    CqlBoolean ai_ = context.Operators.Equivalent(frequency, ah_);
                                                    if (ai_.IsTrue)
                                                    {
                                                        decimal? aj_ = context.Operators.ConvertIntegerToDecimal(1);
                                                        return aj_;
                                                    }
                                                    else
                                                    {
                                                        CqlCode ak_ = this.PCD(context);
                                                        CqlBoolean al_ = context.Operators.Equivalent(frequency, ak_);
                                                        if (al_.IsTrue)
                                                        {
                                                            decimal? am_ = context.Operators.ConvertIntegerToDecimal(1);
                                                            return am_;
                                                        }
                                                        else
                                                        {
                                                            CqlCode an_ = this.PCV(context);
                                                            CqlBoolean ao_ = context.Operators.Equivalent(frequency, an_);
                                                            if (ao_.IsTrue)
                                                            {
                                                                decimal? ap_ = context.Operators.ConvertIntegerToDecimal(1);
                                                                return ap_;
                                                            }
                                                            else
                                                            {
                                                                CqlCode aq_ = this.MORN(context);
                                                                CqlBoolean ar_ = context.Operators.Equivalent(frequency, aq_);
                                                                if (ar_.IsTrue)
                                                                {
                                                                    decimal? as_ = context.Operators.ConvertIntegerToDecimal(1);
                                                                    return as_;
                                                                }
                                                                else
                                                                {
                                                                    CqlCode at_ = this.MORN_early(context);
                                                                    CqlBoolean au_ = context.Operators.Equivalent(frequency, at_);
                                                                    if (au_.IsTrue)
                                                                    {
                                                                        decimal? av_ = context.Operators.ConvertIntegerToDecimal(1);
                                                                        return av_;
                                                                    }
                                                                    else
                                                                    {
                                                                        CqlCode aw_ = this.MORN_late(context);
                                                                        CqlBoolean ax_ = context.Operators.Equivalent(frequency, aw_);
                                                                        if (ax_.IsTrue)
                                                                        {
                                                                            decimal? ay_ = context.Operators.ConvertIntegerToDecimal(1);
                                                                            return ay_;
                                                                        }
                                                                        else
                                                                        {
                                                                            CqlCode az_ = this.NOON(context);
                                                                            CqlBoolean ba_ = context.Operators.Equivalent(frequency, az_);
                                                                            if (ba_.IsTrue)
                                                                            {
                                                                                decimal? bb_ = context.Operators.ConvertIntegerToDecimal(1);
                                                                                return bb_;
                                                                            }
                                                                            else
                                                                            {
                                                                                CqlCode bc_ = this.AFT(context);
                                                                                CqlBoolean bd_ = context.Operators.Equivalent(frequency, bc_);
                                                                                if (bd_.IsTrue)
                                                                                {
                                                                                    decimal? be_ = context.Operators.ConvertIntegerToDecimal(1);
                                                                                    return be_;
                                                                                }
                                                                                else
                                                                                {
                                                                                    CqlCode bf_ = this.AFT_early(context);
                                                                                    CqlBoolean bg_ = context.Operators.Equivalent(frequency, bf_);
                                                                                    if (bg_.IsTrue)
                                                                                    {
                                                                                        decimal? bh_ = context.Operators.ConvertIntegerToDecimal(1);
                                                                                        return bh_;
                                                                                    }
                                                                                    else
                                                                                    {
                                                                                        CqlCode bi_ = this.AFT_late(context);
                                                                                        CqlBoolean bj_ = context.Operators.Equivalent(frequency, bi_);
                                                                                        if (bj_.IsTrue)
                                                                                        {
                                                                                            decimal? bk_ = context.Operators.ConvertIntegerToDecimal(1);
                                                                                            return bk_;
                                                                                        }
                                                                                        else
                                                                                        {
                                                                                            CqlCode bl_ = this.EVE(context);
                                                                                            CqlBoolean bm_ = context.Operators.Equivalent(frequency, bl_);
                                                                                            if (bm_.IsTrue)
                                                                                            {
                                                                                                decimal? bn_ = context.Operators.ConvertIntegerToDecimal(1);
                                                                                                return bn_;
                                                                                            }
                                                                                            else
                                                                                            {
                                                                                                CqlCode bo_ = this.EVE_early(context);
                                                                                                CqlBoolean bp_ = context.Operators.Equivalent(frequency, bo_);
                                                                                                if (bp_.IsTrue)
                                                                                                {
                                                                                                    decimal? bq_ = context.Operators.ConvertIntegerToDecimal(1);
                                                                                                    return bq_;
                                                                                                }
                                                                                                else
                                                                                                {
                                                                                                    CqlCode br_ = this.EVE_late(context);
                                                                                                    CqlBoolean bs_ = context.Operators.Equivalent(frequency, br_);
                                                                                                    if (bs_.IsTrue)
                                                                                                    {
                                                                                                        decimal? bt_ = context.Operators.ConvertIntegerToDecimal(1);
                                                                                                        return bt_;
                                                                                                    }
                                                                                                    else
                                                                                                    {
                                                                                                        CqlCode bu_ = this.NIGHT(context);
                                                                                                        CqlBoolean bv_ = context.Operators.Equivalent(frequency, bu_);
                                                                                                        if (bv_.IsTrue)
                                                                                                        {
                                                                                                            decimal? bw_ = context.Operators.ConvertIntegerToDecimal(1);
                                                                                                            return bw_;
                                                                                                        }
                                                                                                        else
                                                                                                        {
                                                                                                            CqlCode bx_ = this.PHS(context);
                                                                                                            CqlBoolean by_ = context.Operators.Equivalent(frequency, bx_);
                                                                                                            if (by_.IsTrue)
                                                                                                            {
                                                                                                                decimal? bz_ = context.Operators.ConvertIntegerToDecimal(1);
                                                                                                                return bz_;
                                                                                                            }
                                                                                                            else
                                                                                                            {
                                                                                                                CqlCode ca_ = this.Once_daily__qualifier_value_(context);
                                                                                                                CqlBoolean cb_ = context.Operators.Equivalent(frequency, ca_);
                                                                                                                if (cb_.IsTrue)
                                                                                                                {
                                                                                                                    return 1.0m;
                                                                                                                }
                                                                                                                else
                                                                                                                {
                                                                                                                    CqlCode cc_ = this.Twice_a_day__qualifier_value_(context);
                                                                                                                    CqlBoolean cd_ = context.Operators.Equivalent(frequency, cc_);
                                                                                                                    if (cd_.IsTrue)
                                                                                                                    {
                                                                                                                        return 2.0m;
                                                                                                                    }
                                                                                                                    else
                                                                                                                    {
                                                                                                                        CqlCode ce_ = this.Three_times_daily__qualifier_value_(context);
                                                                                                                        CqlBoolean cf_ = context.Operators.Equivalent(frequency, ce_);
                                                                                                                        if (cf_.IsTrue)
                                                                                                                        {
                                                                                                                            return 3.0m;
                                                                                                                        }
                                                                                                                        else
                                                                                                                        {
                                                                                                                            CqlCode cg_ = this.Four_times_daily__qualifier_value_(context);
                                                                                                                            CqlBoolean ch_ = context.Operators.Equivalent(frequency, cg_);
                                                                                                                            if (ch_.IsTrue)
                                                                                                                            {
                                                                                                                                return 4.0m;
                                                                                                                            }
                                                                                                                            else
                                                                                                                            {
                                                                                                                                CqlCode ci_ = this.Every_twenty_four_hours__qualifier_value_(context);
                                                                                                                                CqlBoolean cj_ = context.Operators.Equivalent(frequency, ci_);
                                                                                                                                if (cj_.IsTrue)
                                                                                                                                {
                                                                                                                                    return 1.0m;
                                                                                                                                }
                                                                                                                                else
                                                                                                                                {
                                                                                                                                    CqlCode ck_ = this.Every_twelve_hours__qualifier_value_(context);
                                                                                                                                    CqlBoolean cl_ = context.Operators.Equivalent(frequency, ck_);
                                                                                                                                    if (cl_.IsTrue)
                                                                                                                                    {
                                                                                                                                        return 2.0m;
                                                                                                                                    }
                                                                                                                                    else
                                                                                                                                    {
                                                                                                                                        CqlCode cm_ = this.Every_thirty_six_hours__qualifier_value_(context);
                                                                                                                                        CqlBoolean cn_ = context.Operators.Equivalent(frequency, cm_);
                                                                                                                                        if (cn_.IsTrue)
                                                                                                                                        {
                                                                                                                                            return 0.67m;
                                                                                                                                        }
                                                                                                                                        else
                                                                                                                                        {
                                                                                                                                            CqlCode co_ = this.Every_eight_hours__qualifier_value_(context);
                                                                                                                                            CqlBoolean cp_ = context.Operators.Equivalent(frequency, co_);
                                                                                                                                            if (cp_.IsTrue)
                                                                                                                                            {
                                                                                                                                                return 3.0m;
                                                                                                                                            }
                                                                                                                                            else
                                                                                                                                            {
                                                                                                                                                CqlCode cq_ = this.Every_four_hours__qualifier_value_(context);
                                                                                                                                                CqlBoolean cr_ = context.Operators.Equivalent(frequency, cq_);
                                                                                                                                                if (cr_.IsTrue)
                                                                                                                                                {
                                                                                                                                                    return 6.0m;
                                                                                                                                                }
                                                                                                                                                else
                                                                                                                                                {
                                                                                                                                                    CqlCode cs_ = this.Every_six_hours__qualifier_value_(context);
                                                                                                                                                    CqlBoolean ct_ = context.Operators.Equivalent(frequency, cs_);
                                                                                                                                                    if (ct_.IsTrue)
                                                                                                                                                    {
                                                                                                                                                        return 4.0m;
                                                                                                                                                    }
                                                                                                                                                    else
                                                                                                                                                    {
                                                                                                                                                        CqlCode cu_ = this.Every_seventy_two_hours__qualifier_value_(context);
                                                                                                                                                        CqlBoolean cv_ = context.Operators.Equivalent(frequency, cu_);
                                                                                                                                                        if (cv_.IsTrue)
                                                                                                                                                        {
                                                                                                                                                            return 0.33m;
                                                                                                                                                        }
                                                                                                                                                        else
                                                                                                                                                        {
                                                                                                                                                            CqlCode cw_ = this.Every_forty_eight_hours__qualifier_value_(context);
                                                                                                                                                            CqlBoolean cx_ = context.Operators.Equivalent(frequency, cw_);
                                                                                                                                                            if (cx_.IsTrue)
                                                                                                                                                            {
                                                                                                                                                                return 0.5m;
                                                                                                                                                            }
                                                                                                                                                            else
                                                                                                                                                            {
                                                                                                                                                                CqlCode cy_ = this.Every_eight_to_twelve_hours__qualifier_value_(context);
                                                                                                                                                                CqlBoolean cz_ = context.Operators.Equivalent(frequency, cy_);
                                                                                                                                                                if (cz_.IsTrue)
                                                                                                                                                                {
                                                                                                                                                                    return 3.0m;
                                                                                                                                                                }
                                                                                                                                                                else
                                                                                                                                                                {
                                                                                                                                                                    CqlCode da_ = this.Every_six_to_eight_hours__qualifier_value_(context);
                                                                                                                                                                    CqlBoolean db_ = context.Operators.Equivalent(frequency, da_);
                                                                                                                                                                    if (db_.IsTrue)
                                                                                                                                                                    {
                                                                                                                                                                        return 4.0m;
                                                                                                                                                                    }
                                                                                                                                                                    else
                                                                                                                                                                    {
                                                                                                                                                                        CqlCode dc_ = this.Every_three_to_four_hours__qualifier_value_(context);
                                                                                                                                                                        CqlBoolean dd_ = context.Operators.Equivalent(frequency, dc_);
                                                                                                                                                                        if (dd_.IsTrue)
                                                                                                                                                                        {
                                                                                                                                                                            return 8.0m;
                                                                                                                                                                        }
                                                                                                                                                                        else
                                                                                                                                                                        {
                                                                                                                                                                            CqlCode de_ = this.Every_three_to_six_hours__qualifier_value_(context);
                                                                                                                                                                            CqlBoolean df_ = context.Operators.Equivalent(frequency, de_);
                                                                                                                                                                            if (df_.IsTrue)
                                                                                                                                                                            {
                                                                                                                                                                                return 8.0m;
                                                                                                                                                                            }
                                                                                                                                                                            else
                                                                                                                                                                            {
                                                                                                                                                                                CqlCode dg_ = this.Every_two_to_four_hours__qualifier_value_(context);
                                                                                                                                                                                CqlBoolean dh_ = context.Operators.Equivalent(frequency, dg_);
                                                                                                                                                                                if (dh_.IsTrue)
                                                                                                                                                                                {
                                                                                                                                                                                    return 12.0m;
                                                                                                                                                                                }
                                                                                                                                                                                else
                                                                                                                                                                                {
                                                                                                                                                                                    CqlCode di_ = this.One_to_four_times_a_day__qualifier_value_(context);
                                                                                                                                                                                    CqlBoolean dj_ = context.Operators.Equivalent(frequency, di_);
                                                                                                                                                                                    if (dj_.IsTrue)
                                                                                                                                                                                    {
                                                                                                                                                                                        return 4.0m;
                                                                                                                                                                                    }
                                                                                                                                                                                    else
                                                                                                                                                                                    {
                                                                                                                                                                                        CqlCode dk_ = this.One_to_three_times_a_day__qualifier_value_(context);
                                                                                                                                                                                        CqlBoolean dl_ = context.Operators.Equivalent(frequency, dk_);
                                                                                                                                                                                        if (dl_.IsTrue)
                                                                                                                                                                                        {
                                                                                                                                                                                            return 3.0m;
                                                                                                                                                                                        }
                                                                                                                                                                                        else
                                                                                                                                                                                        {
                                                                                                                                                                                            CqlCode dm_ = this.One_to_two_times_a_day__qualifier_value_(context);
                                                                                                                                                                                            CqlBoolean dn_ = context.Operators.Equivalent(frequency, dm_);
                                                                                                                                                                                            if (dn_.IsTrue)
                                                                                                                                                                                            {
                                                                                                                                                                                                return 2.0m;
                                                                                                                                                                                            }
                                                                                                                                                                                            else
                                                                                                                                                                                            {
                                                                                                                                                                                                CqlCode do_ = this.Two_to_four_times_a_day__qualifier_value_(context);
                                                                                                                                                                                                CqlBoolean dp_ = context.Operators.Equivalent(frequency, do_);
                                                                                                                                                                                                if (dp_.IsTrue)
                                                                                                                                                                                                {
                                                                                                                                                                                                    return 4.0m;
                                                                                                                                                                                                }
                                                                                                                                                                                                else
                                                                                                                                                                                                {
                                                                                                                                                                                                    string dq_ = this.ErrorLevel(context);
                                                                                                                                                                                                    string dr_ = frequency?.code;
                                                                                                                                                                                                    string ds_ = context.Operators.Concatenate("Unknown frequency code ", dr_ ?? "");
                                                                                                                                                                                                    object dt_ = context.Operators.Message<object>((object)null, "CMDLogic.ToDaily.UnknownFrequencyCode", dq_, ds_);
                                                                                                                                                                                                    return dt_ as decimal?;
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
                }
            }
        }
    }


    [CqlFunctionDefinition("MedicationRequestPeriod")]
    public CqlInterval<CqlDate> MedicationRequestPeriod(CqlContext context, MedicationRequest Request)
    {
        MedicationRequest[] a_ = [
            Request,
        ];

        CqlInterval<CqlDate> b_(MedicationRequest R) {
            List<Dosage> e_ = R?.DosageInstruction;
            Dosage f_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)e_);
            Timing g_ = f_?.Timing;
            Timing.RepeatComponent h_ = g_?.Repeat;
            DataType i_ = h_?.Bounds;
            object j_ = FHIRHelpers_4_4_000.Instance.ToValue(context, i_);
            CqlDateTime k_ = context.Operators.Start(j_ as CqlInterval<CqlDateTime>);
            CqlDate l_ = context.Operators.DateFrom(k_);
            FhirDateTime m_ = R?.AuthoredOnElement;
            CqlDateTime n_ = context.Operators.Convert<CqlDateTime>(m_);
            CqlDate o_ = context.Operators.DateFrom(n_);
            MedicationRequest.DispenseRequestComponent p_ = R?.DispenseRequest;
            Period q_ = p_?.ValidityPeriod;
            CqlInterval<CqlDateTime> r_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, q_);
            CqlDateTime s_ = context.Operators.Start(r_);
            CqlDate t_ = context.Operators.DateFrom(s_);

            CqlBoolean u_() {
                MedicationRequest.DispenseRequestComponent v_ = R?.DispenseRequest;
                Duration w_ = v_?.ExpectedSupplyDuration;
                CqlQuantity x_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, w_);
                CqlQuantity y_ = context.Operators.ConvertQuantity(x_, "d");
                decimal? z_ = y_?.value;
                Quantity aa_ = v_?.Quantity;
                CqlQuantity ab_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, aa_);
                decimal? ac_ = ab_?.value;
                List<Dosage> ad_ = R?.DosageInstruction;
                Dosage ae_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)ad_);
                List<Dosage.DoseAndRateComponent> af_ = ae_?.DoseAndRate;
                Dosage.DoseAndRateComponent ag_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)af_);
                DataType ah_ = ag_?.Dose;
                object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                CqlQuantity aj_ = context.Operators.End(ai_ as CqlInterval<CqlQuantity>);
                decimal? ak_ = (aj_ ?? ai_ as CqlQuantity)?.value;
                Timing al_ = ae_?.Timing;
                Timing.RepeatComponent am_ = al_?.Repeat;
                PositiveInt an_ = am_?.FrequencyMaxElement;
                int? ao_ = an_?.Value;
                PositiveInt ap_ = am_?.FrequencyElement;
                int? aq_ = ap_?.Value;
                FhirDecimal ar_ = am_?.PeriodElement;
                decimal? as_ = ar_?.Value;
                Code<Timing.UnitsOfTime> at_ = am_?.PeriodUnitElement;
                Timing.UnitsOfTime? au_ = at_?.Value;
                string av_ = context.Operators.Convert<string>(au_);
                CqlQuantity aw_ = this.Quantity(context, as_, av_);
                decimal? ax_ = this.ToDaily(context, ao_ ?? aq_, aw_);
                List<Time> ay_ = am_?.TimeOfDayElement;

                string az_(Time @this) {
                    string bm_ = @this?.Value;
                    return bm_;
                }

                IEnumerable<string> ba_ = context.Operators.Select<Time, string>((IEnumerable<Time>)ay_, az_);

                CqlTime bb_(string @string) {
                    CqlTime bn_ = context.Operators.ConvertStringToTime(@string);
                    return bn_;
                }

                IEnumerable<CqlTime> bc_ = context.Operators.Select<string, CqlTime>(ba_, bb_);
                int? bd_ = context.Operators.Count<CqlTime>(bc_);
                decimal? be_ = context.Operators.ConvertIntegerToDecimal(bd_);
                decimal? bf_ = context.Operators.Multiply(ak_, (ax_ ?? be_) ?? 1.0m);
                decimal? bg_ = context.Operators.Divide(ac_, bf_);
                UnsignedInt bh_ = v_?.NumberOfRepeatsAllowedElement;
                int? bi_ = bh_?.Value;
                int? bj_ = context.Operators.Add(1, bi_ ?? 0);
                decimal? bk_ = context.Operators.ConvertIntegerToDecimal(bj_);
                decimal? bl_ = context.Operators.Multiply(z_ ?? bg_, bk_);
                return !((bool?)(bl_ is null));
            }

            if ((CqlBoolean)(!((bool?)(((l_ ?? o_) ?? t_) is null)))
                /* CQL 'and' (260:10-260:64) */ && u_())
            {
                Duration bo_ = p_?.ExpectedSupplyDuration;
                CqlQuantity bp_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, bo_);
                CqlQuantity bq_ = context.Operators.ConvertQuantity(bp_, "d");
                decimal? br_ = bq_?.value;
                Quantity bs_ = p_?.Quantity;
                CqlQuantity bt_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, bs_);
                decimal? bu_ = bt_?.value;
                List<Dosage.DoseAndRateComponent> bv_ = f_?.DoseAndRate;
                Dosage.DoseAndRateComponent bw_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)bv_);
                DataType bx_ = bw_?.Dose;
                object by_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bx_);
                CqlQuantity bz_ = context.Operators.End(by_ as CqlInterval<CqlQuantity>);
                decimal? ca_ = (bz_ ?? by_ as CqlQuantity)?.value;
                PositiveInt cb_ = h_?.FrequencyMaxElement;
                int? cc_ = cb_?.Value;
                PositiveInt cd_ = h_?.FrequencyElement;
                int? ce_ = cd_?.Value;
                FhirDecimal cf_ = h_?.PeriodElement;
                decimal? cg_ = cf_?.Value;
                Code<Timing.UnitsOfTime> ch_ = h_?.PeriodUnitElement;
                Timing.UnitsOfTime? ci_ = ch_?.Value;
                string cj_ = context.Operators.Convert<string>(ci_);
                CqlQuantity ck_ = this.Quantity(context, cg_, cj_);
                decimal? cl_ = this.ToDaily(context, cc_ ?? ce_, ck_);
                List<Time> cm_ = h_?.TimeOfDayElement;

                string cn_(Time @this) {
                    string df_ = @this?.Value;
                    return df_;
                }

                IEnumerable<string> co_ = context.Operators.Select<Time, string>((IEnumerable<Time>)cm_, cn_);

                CqlTime cp_(string @string) {
                    CqlTime dg_ = context.Operators.ConvertStringToTime(@string);
                    return dg_;
                }

                IEnumerable<CqlTime> cq_ = context.Operators.Select<string, CqlTime>(co_, cp_);
                int? cr_ = context.Operators.Count<CqlTime>(cq_);
                decimal? cs_ = context.Operators.ConvertIntegerToDecimal(cr_);
                decimal? ct_ = context.Operators.Multiply(ca_, (cl_ ?? cs_) ?? 1.0m);
                decimal? cu_ = context.Operators.Divide(bu_, ct_);
                UnsignedInt cv_ = p_?.NumberOfRepeatsAllowedElement;
                int? cw_ = cv_?.Value;
                int? cx_ = context.Operators.Add(1, cw_ ?? 0);
                decimal? cy_ = context.Operators.ConvertIntegerToDecimal(cx_);
                decimal? cz_ = context.Operators.Multiply(br_ ?? cu_, cy_);
                decimal? da_ = context.Operators.ConvertIntegerToDecimal(1);
                decimal? db_ = context.Operators.Subtract(cz_, da_);
                CqlQuantity dc_ = this.Quantity(context, db_, "day");
                CqlDate dd_ = context.Operators.Add((l_ ?? o_) ?? t_, dc_);
                CqlInterval<CqlDate> de_ = context.Operators.Interval((l_ ?? o_) ?? t_, dd_, true, true);
                return de_;
            }
            else
            {

                CqlBoolean dh_() {
                    List<Dosage> di_ = R?.DosageInstruction;
                    Dosage dj_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)di_);
                    Timing dk_ = dj_?.Timing;
                    Timing.RepeatComponent dl_ = dk_?.Repeat;
                    DataType dm_ = dl_?.Bounds;
                    object dn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dm_);
                    CqlDateTime do_ = (dn_ as CqlInterval<CqlDateTime>)?.high;
                    return !((bool?)(do_ is null));
                }

                if ((CqlBoolean)(!((bool?)(((l_ ?? o_) ?? t_) is null)))
                    /* CQL 'and' (262:15-262:71) */ && dh_())
                {
                    CqlDateTime dp_ = context.Operators.End(j_ as CqlInterval<CqlDateTime>);
                    CqlDate dq_ = context.Operators.DateFrom(dp_);
                    CqlInterval<CqlDate> dr_ = context.Operators.Interval((l_ ?? o_) ?? t_, dq_, true, true);
                    return dr_;
                }
                else
                {
                    return null as CqlInterval<CqlDate>;
                }
            }
        }

        IEnumerable<CqlInterval<CqlDate>> c_ = context.Operators.SelectDistinct<MedicationRequest, CqlInterval<CqlDate>>((IEnumerable<MedicationRequest>)a_, b_);
        CqlInterval<CqlDate> d_ = context.Operators.SingletonFrom<CqlInterval<CqlDate>>(c_);
        return d_;
    }


    [CqlFunctionDefinition("Quantity")]
    public CqlQuantity Quantity(CqlContext context, decimal? value, string unit) =>
    ((!((bool?)(value is null))) ?? false
        ? new CqlQuantity(value, unit)
        : default);


    [CqlFunctionDefinition("medicationRequestPeriod")]
    public CqlInterval<CqlDate> medicationRequestPeriod(CqlContext context, MedicationRequest Request)
    {
        MedicationRequest[] a_ = [
            Request,
        ];

        CqlInterval<CqlDate> b_(MedicationRequest R) {
            List<Dosage> e_ = R?.DosageInstruction;
            Dosage f_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)e_);
            Timing g_ = f_?.Timing;
            Timing.RepeatComponent h_ = g_?.Repeat;
            DataType i_ = h_?.Bounds;
            object j_ = FHIRHelpers_4_4_000.Instance.ToValue(context, i_);
            CqlDateTime k_ = context.Operators.Start(j_ as CqlInterval<CqlDateTime>);
            CqlDate l_ = context.Operators.DateFrom(k_);
            FhirDateTime m_ = R?.AuthoredOnElement;
            CqlDateTime n_ = context.Operators.Convert<CqlDateTime>(m_);
            CqlDate o_ = context.Operators.DateFrom(n_);
            MedicationRequest.DispenseRequestComponent p_ = R?.DispenseRequest;
            Period q_ = p_?.ValidityPeriod;
            CqlInterval<CqlDateTime> r_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, q_);
            CqlDateTime s_ = context.Operators.Start(r_);
            CqlDate t_ = context.Operators.DateFrom(s_);

            CqlBoolean u_() {
                MedicationRequest.DispenseRequestComponent v_ = R?.DispenseRequest;
                Duration w_ = v_?.ExpectedSupplyDuration;
                CqlQuantity x_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, w_);
                CqlQuantity y_ = context.Operators.ConvertQuantity(x_, "d");
                decimal? z_ = y_?.value;
                Quantity aa_ = v_?.Quantity;
                CqlQuantity ab_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, aa_);
                decimal? ac_ = ab_?.value;
                List<Dosage> ad_ = R?.DosageInstruction;
                Dosage ae_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)ad_);
                List<Dosage.DoseAndRateComponent> af_ = ae_?.DoseAndRate;
                Dosage.DoseAndRateComponent ag_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)af_);
                DataType ah_ = ag_?.Dose;
                object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                CqlQuantity aj_ = context.Operators.End(ai_ as CqlInterval<CqlQuantity>);
                decimal? ak_ = (aj_ ?? ai_ as CqlQuantity)?.value;
                Timing al_ = ae_?.Timing;
                Timing.RepeatComponent am_ = al_?.Repeat;
                PositiveInt an_ = am_?.FrequencyMaxElement;
                int? ao_ = an_?.Value;
                PositiveInt ap_ = am_?.FrequencyElement;
                int? aq_ = ap_?.Value;
                FhirDecimal ar_ = am_?.PeriodElement;
                decimal? as_ = ar_?.Value;
                Code<Timing.UnitsOfTime> at_ = am_?.PeriodUnitElement;
                Timing.UnitsOfTime? au_ = at_?.Value;
                string av_ = context.Operators.Convert<string>(au_);
                CqlQuantity aw_ = this.Quantity(context, as_, av_);
                decimal? ax_ = this.ToDaily(context, ao_ ?? aq_, aw_);
                List<Time> ay_ = am_?.TimeOfDayElement;

                string az_(Time @this) {
                    string bm_ = @this?.Value;
                    return bm_;
                }

                IEnumerable<string> ba_ = context.Operators.Select<Time, string>((IEnumerable<Time>)ay_, az_);

                CqlTime bb_(string @string) {
                    CqlTime bn_ = context.Operators.ConvertStringToTime(@string);
                    return bn_;
                }

                IEnumerable<CqlTime> bc_ = context.Operators.Select<string, CqlTime>(ba_, bb_);
                int? bd_ = context.Operators.Count<CqlTime>(bc_);
                decimal? be_ = context.Operators.ConvertIntegerToDecimal(bd_);
                decimal? bf_ = context.Operators.Multiply(ak_, (ax_ ?? be_) ?? 1.0m);
                decimal? bg_ = context.Operators.Divide(ac_, bf_);
                UnsignedInt bh_ = v_?.NumberOfRepeatsAllowedElement;
                int? bi_ = bh_?.Value;
                int? bj_ = context.Operators.Add(1, bi_ ?? 0);
                decimal? bk_ = context.Operators.ConvertIntegerToDecimal(bj_);
                decimal? bl_ = context.Operators.Multiply(z_ ?? bg_, bk_);
                return !((bool?)(bl_ is null));
            }

            if ((CqlBoolean)(!((bool?)(((l_ ?? o_) ?? t_) is null)))
                /* CQL 'and' (291:10-291:64) */ && u_())
            {
                Duration bo_ = p_?.ExpectedSupplyDuration;
                CqlQuantity bp_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, bo_);
                CqlQuantity bq_ = context.Operators.ConvertQuantity(bp_, "d");
                decimal? br_ = bq_?.value;
                Quantity bs_ = p_?.Quantity;
                CqlQuantity bt_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, bs_);
                decimal? bu_ = bt_?.value;
                List<Dosage.DoseAndRateComponent> bv_ = f_?.DoseAndRate;
                Dosage.DoseAndRateComponent bw_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)bv_);
                DataType bx_ = bw_?.Dose;
                object by_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bx_);
                CqlQuantity bz_ = context.Operators.End(by_ as CqlInterval<CqlQuantity>);
                decimal? ca_ = (bz_ ?? by_ as CqlQuantity)?.value;
                PositiveInt cb_ = h_?.FrequencyMaxElement;
                int? cc_ = cb_?.Value;
                PositiveInt cd_ = h_?.FrequencyElement;
                int? ce_ = cd_?.Value;
                FhirDecimal cf_ = h_?.PeriodElement;
                decimal? cg_ = cf_?.Value;
                Code<Timing.UnitsOfTime> ch_ = h_?.PeriodUnitElement;
                Timing.UnitsOfTime? ci_ = ch_?.Value;
                string cj_ = context.Operators.Convert<string>(ci_);
                CqlQuantity ck_ = this.Quantity(context, cg_, cj_);
                decimal? cl_ = this.ToDaily(context, cc_ ?? ce_, ck_);
                List<Time> cm_ = h_?.TimeOfDayElement;

                string cn_(Time @this) {
                    string df_ = @this?.Value;
                    return df_;
                }

                IEnumerable<string> co_ = context.Operators.Select<Time, string>((IEnumerable<Time>)cm_, cn_);

                CqlTime cp_(string @string) {
                    CqlTime dg_ = context.Operators.ConvertStringToTime(@string);
                    return dg_;
                }

                IEnumerable<CqlTime> cq_ = context.Operators.Select<string, CqlTime>(co_, cp_);
                int? cr_ = context.Operators.Count<CqlTime>(cq_);
                decimal? cs_ = context.Operators.ConvertIntegerToDecimal(cr_);
                decimal? ct_ = context.Operators.Multiply(ca_, (cl_ ?? cs_) ?? 1.0m);
                decimal? cu_ = context.Operators.Divide(bu_, ct_);
                UnsignedInt cv_ = p_?.NumberOfRepeatsAllowedElement;
                int? cw_ = cv_?.Value;
                int? cx_ = context.Operators.Add(1, cw_ ?? 0);
                decimal? cy_ = context.Operators.ConvertIntegerToDecimal(cx_);
                decimal? cz_ = context.Operators.Multiply(br_ ?? cu_, cy_);
                decimal? da_ = context.Operators.ConvertIntegerToDecimal(1);
                decimal? db_ = context.Operators.Subtract(cz_, da_);
                CqlQuantity dc_ = this.Quantity(context, db_, "day");
                CqlDate dd_ = context.Operators.Add((l_ ?? o_) ?? t_, dc_);
                CqlInterval<CqlDate> de_ = context.Operators.Interval((l_ ?? o_) ?? t_, dd_, true, true);
                return de_;
            }
            else
            {

                CqlBoolean dh_() {
                    List<Dosage> di_ = R?.DosageInstruction;
                    Dosage dj_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)di_);
                    Timing dk_ = dj_?.Timing;
                    Timing.RepeatComponent dl_ = dk_?.Repeat;
                    DataType dm_ = dl_?.Bounds;
                    object dn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dm_);
                    CqlDateTime do_ = (dn_ as CqlInterval<CqlDateTime>)?.high;
                    return !((bool?)(do_ is null));
                }

                if ((CqlBoolean)(!((bool?)(((l_ ?? o_) ?? t_) is null)))
                    /* CQL 'and' (293:15-293:71) */ && dh_())
                {
                    CqlDateTime dp_ = context.Operators.End(j_ as CqlInterval<CqlDateTime>);
                    CqlDate dq_ = context.Operators.DateFrom(dp_);
                    CqlInterval<CqlDate> dr_ = context.Operators.Interval((l_ ?? o_) ?? t_, dq_, true, true);
                    return dr_;
                }
                else
                {
                    return null as CqlInterval<CqlDate>;
                }
            }
        }

        IEnumerable<CqlInterval<CqlDate>> c_ = context.Operators.SelectDistinct<MedicationRequest, CqlInterval<CqlDate>>((IEnumerable<MedicationRequest>)a_, b_);
        CqlInterval<CqlDate> d_ = context.Operators.SingletonFrom<CqlInterval<CqlDate>>(c_);
        return d_;
    }


    [CqlFunctionDefinition("MedicationDispensePeriod")]
    public CqlInterval<CqlDate> MedicationDispensePeriod(CqlContext context, MedicationDispense Dispense)
    {
        MedicationDispense[] a_ = [
            Dispense,
        ];

        CqlInterval<CqlDate> b_(MedicationDispense D) {
            FhirDateTime e_ = D?.WhenHandedOverElement;
            CqlDateTime f_ = context.Operators.Convert<CqlDateTime>(e_);
            CqlDate g_ = context.Operators.DateFrom(f_);
            FhirDateTime h_ = D?.WhenPreparedElement;
            CqlDateTime i_ = context.Operators.Convert<CqlDateTime>(h_);
            CqlDate j_ = context.Operators.DateFrom(i_);

            CqlBoolean k_() {
                Quantity l_ = D?.DaysSupply;
                CqlQuantity m_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, l_);
                CqlQuantity n_ = context.Operators.ConvertQuantity(m_, "d");
                decimal? o_ = n_?.value;
                Quantity p_ = D?.Quantity;
                CqlQuantity q_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, p_);
                decimal? r_ = q_?.value;
                List<Dosage> s_ = D?.DosageInstruction;
                Dosage t_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)s_);
                List<Dosage.DoseAndRateComponent> u_ = t_?.DoseAndRate;
                Dosage.DoseAndRateComponent v_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)u_);
                DataType w_ = v_?.Dose;
                object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                CqlQuantity y_ = context.Operators.End(x_ as CqlInterval<CqlQuantity>);
                decimal? z_ = (y_ ?? x_ as CqlQuantity)?.value;
                Timing aa_ = t_?.Timing;
                Timing.RepeatComponent ab_ = aa_?.Repeat;
                PositiveInt ac_ = ab_?.FrequencyMaxElement;
                int? ad_ = ac_?.Value;
                PositiveInt ae_ = ab_?.FrequencyElement;
                int? af_ = ae_?.Value;
                FhirDecimal ag_ = ab_?.PeriodElement;
                decimal? ah_ = ag_?.Value;
                Code<Timing.UnitsOfTime> ai_ = ab_?.PeriodUnitElement;
                Timing.UnitsOfTime? aj_ = ai_?.Value;
                string ak_ = context.Operators.Convert<string>(aj_);
                CqlQuantity al_ = this.Quantity(context, ah_, ak_);
                decimal? am_ = this.ToDaily(context, ad_ ?? af_, al_);
                List<Time> an_ = ab_?.TimeOfDayElement;

                string ao_(Time @this) {
                    string aw_ = @this?.Value;
                    return aw_;
                }

                IEnumerable<string> ap_ = context.Operators.Select<Time, string>((IEnumerable<Time>)an_, ao_);

                CqlTime aq_(string @string) {
                    CqlTime ax_ = context.Operators.ConvertStringToTime(@string);
                    return ax_;
                }

                IEnumerable<CqlTime> ar_ = context.Operators.Select<string, CqlTime>(ap_, aq_);
                int? as_ = context.Operators.Count<CqlTime>(ar_);
                decimal? at_ = context.Operators.ConvertIntegerToDecimal(as_);
                decimal? au_ = context.Operators.Multiply(z_, (am_ ?? at_) ?? 1.0m);
                decimal? av_ = context.Operators.Divide(r_, au_);
                return !((bool?)((o_ ?? av_) is null));
            }

            if ((CqlBoolean)(!((bool?)((g_ ?? j_) is null)))
                /* CQL 'and' (387:10-387:64) */ && k_())
            {
                Quantity ay_ = D?.DaysSupply;
                CqlQuantity az_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, ay_);
                CqlQuantity ba_ = context.Operators.ConvertQuantity(az_, "d");
                decimal? bb_ = ba_?.value;
                Quantity bc_ = D?.Quantity;
                CqlQuantity bd_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, bc_);
                decimal? be_ = bd_?.value;
                List<Dosage> bf_ = D?.DosageInstruction;
                Dosage bg_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)bf_);
                List<Dosage.DoseAndRateComponent> bh_ = bg_?.DoseAndRate;
                Dosage.DoseAndRateComponent bi_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)bh_);
                DataType bj_ = bi_?.Dose;
                object bk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bj_);
                CqlQuantity bl_ = context.Operators.End(bk_ as CqlInterval<CqlQuantity>);
                decimal? bm_ = (bl_ ?? bk_ as CqlQuantity)?.value;
                Timing bn_ = bg_?.Timing;
                Timing.RepeatComponent bo_ = bn_?.Repeat;
                PositiveInt bp_ = bo_?.FrequencyMaxElement;
                int? bq_ = bp_?.Value;
                PositiveInt br_ = bo_?.FrequencyElement;
                int? bs_ = br_?.Value;
                FhirDecimal bt_ = bo_?.PeriodElement;
                decimal? bu_ = bt_?.Value;
                Code<Timing.UnitsOfTime> bv_ = bo_?.PeriodUnitElement;
                Timing.UnitsOfTime? bw_ = bv_?.Value;
                string bx_ = context.Operators.Convert<string>(bw_);
                CqlQuantity by_ = this.Quantity(context, bu_, bx_);
                decimal? bz_ = this.ToDaily(context, bq_ ?? bs_, by_);
                List<Time> ca_ = bo_?.TimeOfDayElement;

                string cb_(Time @this) {
                    string co_ = @this?.Value;
                    return co_;
                }

                IEnumerable<string> cc_ = context.Operators.Select<Time, string>((IEnumerable<Time>)ca_, cb_);

                CqlTime cd_(string @string) {
                    CqlTime cp_ = context.Operators.ConvertStringToTime(@string);
                    return cp_;
                }

                IEnumerable<CqlTime> ce_ = context.Operators.Select<string, CqlTime>(cc_, cd_);
                int? cf_ = context.Operators.Count<CqlTime>(ce_);
                decimal? cg_ = context.Operators.ConvertIntegerToDecimal(cf_);
                decimal? ch_ = context.Operators.Multiply(bm_, (bz_ ?? cg_) ?? 1.0m);
                decimal? ci_ = context.Operators.Divide(be_, ch_);
                decimal? cj_ = context.Operators.ConvertIntegerToDecimal(1);
                decimal? ck_ = context.Operators.Subtract(bb_ ?? ci_, cj_);
                CqlQuantity cl_ = this.Quantity(context, ck_, "day");
                CqlDate cm_ = context.Operators.Add(g_ ?? j_, cl_);
                CqlInterval<CqlDate> cn_ = context.Operators.Interval(g_ ?? j_, cm_, true, true);
                return cn_;
            }
            else
            {
                return null as CqlInterval<CqlDate>;
            }
        }

        IEnumerable<CqlInterval<CqlDate>> c_ = context.Operators.SelectDistinct<MedicationDispense, CqlInterval<CqlDate>>((IEnumerable<MedicationDispense>)a_, b_);
        CqlInterval<CqlDate> d_ = context.Operators.SingletonFrom<CqlInterval<CqlDate>>(c_);
        return d_;
    }


    [CqlFunctionDefinition("medicationDispensePeriod")]
    public CqlInterval<CqlDate> medicationDispensePeriod(CqlContext context, MedicationDispense Dispense)
    {
        MedicationDispense[] a_ = [
            Dispense,
        ];

        CqlInterval<CqlDate> b_(MedicationDispense D) {
            FhirDateTime e_ = D?.WhenHandedOverElement;
            CqlDateTime f_ = context.Operators.Convert<CqlDateTime>(e_);
            CqlDate g_ = context.Operators.DateFrom(f_);
            FhirDateTime h_ = D?.WhenPreparedElement;
            CqlDateTime i_ = context.Operators.Convert<CqlDateTime>(h_);
            CqlDate j_ = context.Operators.DateFrom(i_);

            CqlBoolean k_() {
                Quantity l_ = D?.DaysSupply;
                CqlQuantity m_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, l_);
                CqlQuantity n_ = context.Operators.ConvertQuantity(m_, "d");
                decimal? o_ = n_?.value;
                Quantity p_ = D?.Quantity;
                CqlQuantity q_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, p_);
                decimal? r_ = q_?.value;
                List<Dosage> s_ = D?.DosageInstruction;
                Dosage t_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)s_);
                List<Dosage.DoseAndRateComponent> u_ = t_?.DoseAndRate;
                Dosage.DoseAndRateComponent v_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)u_);
                DataType w_ = v_?.Dose;
                object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                CqlQuantity y_ = context.Operators.End(x_ as CqlInterval<CqlQuantity>);
                decimal? z_ = (y_ ?? x_ as CqlQuantity)?.value;
                Timing aa_ = t_?.Timing;
                Timing.RepeatComponent ab_ = aa_?.Repeat;
                PositiveInt ac_ = ab_?.FrequencyMaxElement;
                int? ad_ = ac_?.Value;
                PositiveInt ae_ = ab_?.FrequencyElement;
                int? af_ = ae_?.Value;
                FhirDecimal ag_ = ab_?.PeriodElement;
                decimal? ah_ = ag_?.Value;
                Code<Timing.UnitsOfTime> ai_ = ab_?.PeriodUnitElement;
                Timing.UnitsOfTime? aj_ = ai_?.Value;
                string ak_ = context.Operators.Convert<string>(aj_);
                CqlQuantity al_ = this.Quantity(context, ah_, ak_);
                decimal? am_ = this.ToDaily(context, ad_ ?? af_, al_);
                List<Time> an_ = ab_?.TimeOfDayElement;

                string ao_(Time @this) {
                    string aw_ = @this?.Value;
                    return aw_;
                }

                IEnumerable<string> ap_ = context.Operators.Select<Time, string>((IEnumerable<Time>)an_, ao_);

                CqlTime aq_(string @string) {
                    CqlTime ax_ = context.Operators.ConvertStringToTime(@string);
                    return ax_;
                }

                IEnumerable<CqlTime> ar_ = context.Operators.Select<string, CqlTime>(ap_, aq_);
                int? as_ = context.Operators.Count<CqlTime>(ar_);
                decimal? at_ = context.Operators.ConvertIntegerToDecimal(as_);
                decimal? au_ = context.Operators.Multiply(z_, (am_ ?? at_) ?? 1.0m);
                decimal? av_ = context.Operators.Divide(r_, au_);
                return !((bool?)((o_ ?? av_) is null));
            }

            if ((CqlBoolean)(!((bool?)((g_ ?? j_) is null)))
                /* CQL 'and' (438:10-438:64) */ && k_())
            {
                Quantity ay_ = D?.DaysSupply;
                CqlQuantity az_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, ay_);
                CqlQuantity ba_ = context.Operators.ConvertQuantity(az_, "d");
                decimal? bb_ = ba_?.value;
                Quantity bc_ = D?.Quantity;
                CqlQuantity bd_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, bc_);
                decimal? be_ = bd_?.value;
                List<Dosage> bf_ = D?.DosageInstruction;
                Dosage bg_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)bf_);
                List<Dosage.DoseAndRateComponent> bh_ = bg_?.DoseAndRate;
                Dosage.DoseAndRateComponent bi_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)bh_);
                DataType bj_ = bi_?.Dose;
                object bk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bj_);
                CqlQuantity bl_ = context.Operators.End(bk_ as CqlInterval<CqlQuantity>);
                decimal? bm_ = (bl_ ?? bk_ as CqlQuantity)?.value;
                Timing bn_ = bg_?.Timing;
                Timing.RepeatComponent bo_ = bn_?.Repeat;
                PositiveInt bp_ = bo_?.FrequencyMaxElement;
                int? bq_ = bp_?.Value;
                PositiveInt br_ = bo_?.FrequencyElement;
                int? bs_ = br_?.Value;
                FhirDecimal bt_ = bo_?.PeriodElement;
                decimal? bu_ = bt_?.Value;
                Code<Timing.UnitsOfTime> bv_ = bo_?.PeriodUnitElement;
                Timing.UnitsOfTime? bw_ = bv_?.Value;
                string bx_ = context.Operators.Convert<string>(bw_);
                CqlQuantity by_ = this.Quantity(context, bu_, bx_);
                decimal? bz_ = this.ToDaily(context, bq_ ?? bs_, by_);
                List<Time> ca_ = bo_?.TimeOfDayElement;

                string cb_(Time @this) {
                    string co_ = @this?.Value;
                    return co_;
                }

                IEnumerable<string> cc_ = context.Operators.Select<Time, string>((IEnumerable<Time>)ca_, cb_);

                CqlTime cd_(string @string) {
                    CqlTime cp_ = context.Operators.ConvertStringToTime(@string);
                    return cp_;
                }

                IEnumerable<CqlTime> ce_ = context.Operators.Select<string, CqlTime>(cc_, cd_);
                int? cf_ = context.Operators.Count<CqlTime>(ce_);
                decimal? cg_ = context.Operators.ConvertIntegerToDecimal(cf_);
                decimal? ch_ = context.Operators.Multiply(bm_, (bz_ ?? cg_) ?? 1.0m);
                decimal? ci_ = context.Operators.Divide(be_, ch_);
                decimal? cj_ = context.Operators.ConvertIntegerToDecimal(1);
                decimal? ck_ = context.Operators.Subtract(bb_ ?? ci_, cj_);
                CqlQuantity cl_ = this.Quantity(context, ck_, "day");
                CqlDate cm_ = context.Operators.Add(g_ ?? j_, cl_);
                CqlInterval<CqlDate> cn_ = context.Operators.Interval(g_ ?? j_, cm_, true, true);
                return cn_;
            }
            else
            {
                return null as CqlInterval<CqlDate>;
            }
        }

        IEnumerable<CqlInterval<CqlDate>> c_ = context.Operators.SelectDistinct<MedicationDispense, CqlInterval<CqlDate>>((IEnumerable<MedicationDispense>)a_, b_);
        CqlInterval<CqlDate> d_ = context.Operators.SingletonFrom<CqlInterval<CqlDate>>(c_);
        return d_;
    }


    [CqlFunctionDefinition("TherapeuticDuration")]
    public CqlQuantity TherapeuticDuration(CqlContext context, CqlConcept medication)
    {
        CqlQuantity a_ = context.Operators.Quantity(14m, "days");
        return a_;
    }


    [CqlFunctionDefinition("MedicationAdministrationPeriod")]
    public CqlInterval<CqlDate> MedicationAdministrationPeriod(CqlContext context, MedicationAdministration Administration)
    {
        MedicationAdministration[] a_ = [
            Administration,
        ];

        CqlInterval<CqlDate> b_(MedicationAdministration M) {
            DataType e_ = Administration?.Effective;
            object f_ = FHIRHelpers_4_4_000.Instance.ToValue(context, e_);
            CqlDateTime g_ = context.Operators.Start(f_ as CqlInterval<CqlDateTime>);
            CqlDate h_ = context.Operators.DateFrom(g_);

            CqlBoolean i_() {
                DataType j_ = Administration?.Medication;
                object k_ = FHIRHelpers_4_4_000.Instance.ToValue(context, j_);
                CqlQuantity l_ = this.TherapeuticDuration(context, k_ as CqlConcept);
                return !((bool?)(l_ is null));
            }

            if ((CqlBoolean)(!((bool?)(h_ is null)))
                /* CQL 'and' (475:10-475:66) */ && i_())
            {
                DataType m_ = Administration?.Medication;
                object n_ = FHIRHelpers_4_4_000.Instance.ToValue(context, m_);
                CqlQuantity o_ = this.TherapeuticDuration(context, n_ as CqlConcept);
                CqlDate p_ = context.Operators.Add(h_, o_);
                CqlQuantity q_ = context.Operators.ConvertIntegerToQuantity(1);
                CqlDate r_ = context.Operators.Subtract(p_, q_);
                CqlInterval<CqlDate> s_ = context.Operators.Interval(h_, r_, true, true);
                return s_;
            }
            else
            {
                return null as CqlInterval<CqlDate>;
            }
        }

        IEnumerable<CqlInterval<CqlDate>> c_ = context.Operators.SelectDistinct<MedicationAdministration, CqlInterval<CqlDate>>((IEnumerable<MedicationAdministration>)a_, b_);
        CqlInterval<CqlDate> d_ = context.Operators.SingletonFrom<CqlInterval<CqlDate>>(c_);
        return d_;
    }


    [CqlFunctionDefinition("medicationAdministrationPeriod")]
    public CqlInterval<CqlDate> medicationAdministrationPeriod(CqlContext context, MedicationAdministration Administration)
    {
        MedicationAdministration[] a_ = [
            Administration,
        ];

        CqlInterval<CqlDate> b_(MedicationAdministration M) {
            DataType e_ = Administration?.Effective;
            object f_ = FHIRHelpers_4_4_000.Instance.ToValue(context, e_);
            CqlDateTime g_ = context.Operators.Start(f_ as CqlInterval<CqlDateTime>);
            CqlDate h_ = context.Operators.DateFrom(g_);

            CqlBoolean i_() {
                DataType j_ = Administration?.Medication;
                object k_ = FHIRHelpers_4_4_000.Instance.ToValue(context, j_);
                CqlQuantity l_ = this.TherapeuticDuration(context, k_ as CqlConcept);
                return !((bool?)(l_ is null));
            }

            if ((CqlBoolean)(!((bool?)(h_ is null)))
                /* CQL 'and' (503:10-503:66) */ && i_())
            {
                DataType m_ = Administration?.Medication;
                object n_ = FHIRHelpers_4_4_000.Instance.ToValue(context, m_);
                CqlQuantity o_ = this.TherapeuticDuration(context, n_ as CqlConcept);
                CqlDate p_ = context.Operators.Add(h_, o_);
                CqlQuantity q_ = context.Operators.ConvertIntegerToQuantity(1);
                CqlDate r_ = context.Operators.Subtract(p_, q_);
                CqlInterval<CqlDate> s_ = context.Operators.Interval(h_, r_, true, true);
                return s_;
            }
            else
            {
                return null as CqlInterval<CqlDate>;
            }
        }

        IEnumerable<CqlInterval<CqlDate>> c_ = context.Operators.SelectDistinct<MedicationAdministration, CqlInterval<CqlDate>>((IEnumerable<MedicationAdministration>)a_, b_);
        CqlInterval<CqlDate> d_ = context.Operators.SingletonFrom<CqlInterval<CqlDate>>(c_);
        return d_;
    }


    [CqlFunctionDefinition("CumulativeDuration")]
    public int? CumulativeDuration(CqlContext context, IEnumerable<CqlInterval<CqlDate>> Intervals)
    {
        if ((!((bool?)(Intervals is null))) ?? false)
        {
            IEnumerable<CqlInterval<CqlDate>> a_ = context.Operators.Collapse(Intervals, "day");

            int? b_(CqlInterval<CqlDate> X) {
                CqlDate e_ = context.Operators.Start(X);
                CqlDate f_ = context.Operators.End(X);
                int? g_ = context.Operators.DifferenceBetween(e_, f_, "day");
                int? h_ = context.Operators.Add(g_, 1);
                return h_;
            }

            IEnumerable<int?> c_ = context.Operators.Select<CqlInterval<CqlDate>, int?>(a_, b_);
            int? d_ = context.Operators.Sum(c_);
            return d_;
        }
        else
        {
            return default;
        }
    }


    [CqlFunctionDefinition("cumulativeDuration")]
    public int? cumulativeDuration(CqlContext context, IEnumerable<CqlInterval<CqlDate>> Intervals)
    {
        if ((!((bool?)(Intervals is null))) ?? false)
        {
            IEnumerable<CqlInterval<CqlDate>> a_ = context.Operators.Collapse(Intervals, "day");

            int? b_(CqlInterval<CqlDate> X) {
                CqlDate e_ = context.Operators.Start(X);
                CqlDate f_ = context.Operators.End(X);
                int? g_ = context.Operators.DifferenceBetween(e_, f_, "day");
                int? h_ = context.Operators.Add(g_, 1);
                return h_;
            }

            IEnumerable<int?> c_ = context.Operators.Select<CqlInterval<CqlDate>, int?>(a_, b_);
            int? d_ = context.Operators.Sum(c_);
            return d_;
        }
        else
        {
            return default;
        }
    }


    [CqlFunctionDefinition("RolloutIntervals")]
    public IEnumerable<CqlInterval<CqlDate>> RolloutIntervals(CqlContext context, IEnumerable<CqlInterval<CqlDate>> intervals)
    {

        IEnumerable<CqlInterval<CqlDate>> a_(IEnumerable<CqlInterval<CqlDate>> R, CqlInterval<CqlDate> I) {
            CqlInterval<CqlDate>[] c_ = [
                I,
            ];

            CqlInterval<CqlDate> d_(CqlInterval<CqlDate> X) {
                CqlInterval<CqlDate> i_ = context.Operators.Last<CqlInterval<CqlDate>>(R);
                CqlDate j_ = context.Operators.End(i_);
                CqlQuantity k_ = context.Operators.Quantity(1m, "day");
                CqlDate l_ = context.Operators.Add(j_, k_);
                CqlDate m_ = context.Operators.Start(X);
                CqlDate[] n_ = [
                    l_,
                    m_,
                ];
                CqlDate o_ = context.Operators.Max<CqlDate>((IEnumerable<CqlDate>)n_);
                CqlDate p_ = context.Operators.End(X);
                int? q_ = context.Operators.DurationBetween(m_, p_, "day");
                decimal? r_ = context.Operators.ConvertIntegerToDecimal(q_ ?? 0);
                CqlQuantity s_ = this.Quantity(context, r_, "day");
                CqlDate t_ = context.Operators.Add(o_, s_);
                CqlInterval<CqlDate> u_ = context.Operators.Interval(o_, t_, true, true);
                return u_;
            }

            IEnumerable<CqlInterval<CqlDate>> e_ = context.Operators.SelectDistinct<CqlInterval<CqlDate>, CqlInterval<CqlDate>>((IEnumerable<CqlInterval<CqlDate>>)c_, d_);
            CqlInterval<CqlDate> f_ = context.Operators.SingletonFrom<CqlInterval<CqlDate>>(e_);
            CqlInterval<CqlDate>[] g_ = [
                f_,
            ];
            IEnumerable<CqlInterval<CqlDate>> h_ = context.Operators.Union<CqlInterval<CqlDate>>(R, (IEnumerable<CqlInterval<CqlDate>>)g_);
            return h_;
        }

        IEnumerable<CqlInterval<CqlDate>> b_ = context.Operators.Aggregate<CqlInterval<CqlDate>, IEnumerable<CqlInterval<CqlDate>>>(intervals, a_, null as IEnumerable<CqlInterval<CqlDate>>);
        return b_;
    }


    [CqlFunctionDefinition("rolloutIntervals")]
    public IEnumerable<CqlInterval<CqlDate>> rolloutIntervals(CqlContext context, IEnumerable<CqlInterval<CqlDate>> intervals)
    {

        IEnumerable<CqlInterval<CqlDate>> a_(IEnumerable<CqlInterval<CqlDate>> R, CqlInterval<CqlDate> I) {
            CqlInterval<CqlDate>[] c_ = [
                I,
            ];

            CqlInterval<CqlDate> d_(CqlInterval<CqlDate> X) {
                CqlInterval<CqlDate> i_ = context.Operators.Last<CqlInterval<CqlDate>>(R);
                CqlDate j_ = context.Operators.End(i_);
                CqlQuantity k_ = context.Operators.Quantity(1m, "day");
                CqlDate l_ = context.Operators.Add(j_, k_);
                CqlDate m_ = context.Operators.Start(X);
                CqlDate[] n_ = [
                    l_,
                    m_,
                ];
                CqlDate o_ = context.Operators.Max<CqlDate>((IEnumerable<CqlDate>)n_);
                CqlDate p_ = context.Operators.End(X);
                int? q_ = context.Operators.DurationBetween(m_, p_, "day");
                decimal? r_ = context.Operators.ConvertIntegerToDecimal(q_ ?? 0);
                CqlQuantity s_ = this.Quantity(context, r_, "day");
                CqlDate t_ = context.Operators.Add(o_, s_);
                CqlInterval<CqlDate> u_ = context.Operators.Interval(o_, t_, true, true);
                return u_;
            }

            IEnumerable<CqlInterval<CqlDate>> e_ = context.Operators.SelectDistinct<CqlInterval<CqlDate>, CqlInterval<CqlDate>>((IEnumerable<CqlInterval<CqlDate>>)c_, d_);
            CqlInterval<CqlDate> f_ = context.Operators.SingletonFrom<CqlInterval<CqlDate>>(e_);
            CqlInterval<CqlDate>[] g_ = [
                f_,
            ];
            IEnumerable<CqlInterval<CqlDate>> h_ = context.Operators.Union<CqlInterval<CqlDate>>(R, (IEnumerable<CqlInterval<CqlDate>>)g_);
            return h_;
        }

        IEnumerable<CqlInterval<CqlDate>> b_ = context.Operators.Aggregate<CqlInterval<CqlDate>, IEnumerable<CqlInterval<CqlDate>>>(intervals, a_, null as IEnumerable<CqlInterval<CqlDate>>);
        return b_;
    }


    [CqlFunctionDefinition("MedicationPeriod")]
    public CqlInterval<CqlDate> MedicationPeriod(CqlContext context, object medication)
    {
        if (medication is MedicationRequest)
        {
            CqlInterval<CqlDate> a_ = this.MedicationRequestPeriod(context, medication as MedicationRequest);
            return a_;
        }
        else if (medication is MedicationDispense)
        {
            CqlInterval<CqlDate> b_ = this.MedicationDispensePeriod(context, medication as MedicationDispense);
            return b_;
        }
        else
        {
            return null as CqlInterval<CqlDate>;
        }
    }


    [CqlFunctionDefinition("medicationPeriod")]
    public CqlInterval<CqlDate> medicationPeriod(CqlContext context, object medication)
    {
        if (medication is MedicationRequest)
        {
            CqlInterval<CqlDate> a_ = this.medicationRequestPeriod(context, medication as MedicationRequest);
            return a_;
        }
        else if (medication is MedicationDispense)
        {
            CqlInterval<CqlDate> b_ = this.medicationDispensePeriod(context, medication as MedicationDispense);
            return b_;
        }
        else
        {
            return null as CqlInterval<CqlDate>;
        }
    }


    [CqlFunctionDefinition("CumulativeMedicationDuration")]
    public int? CumulativeMedicationDuration(CqlContext context, IEnumerable<object> Medications)
    {

        bool? a_(object M) {
            bool l_ = M is MedicationRequest;
            return l_;
        }


        CqlInterval<CqlDate> b_(object M) {
            CqlInterval<CqlDate> m_ = this.MedicationRequestPeriod(context, M as MedicationRequest);
            return m_;
        }

        IEnumerable<CqlInterval<CqlDate>> c_ = context.Operators.WhereSelect<object, CqlInterval<CqlDate>>(Medications, a_, b_);
        IEnumerable<CqlInterval<CqlDate>> d_ = context.Operators.Distinct<CqlInterval<CqlDate>>(c_);

        bool? e_(object M) {
            bool n_ = M is MedicationDispense;
            return n_;
        }


        CqlInterval<CqlDate> f_(object M) {
            CqlInterval<CqlDate> o_ = this.MedicationDispensePeriod(context, M as MedicationDispense);
            return o_;
        }

        IEnumerable<CqlInterval<CqlDate>> g_ = context.Operators.WhereSelect<object, CqlInterval<CqlDate>>(Medications, e_, f_);
        IEnumerable<CqlInterval<CqlDate>> h_ = context.Operators.Distinct<CqlInterval<CqlDate>>(g_);
        IEnumerable<CqlInterval<CqlDate>> i_ = this.RolloutIntervals(context, h_);
        IEnumerable<CqlInterval<CqlDate>> j_ = context.Operators.Union<CqlInterval<CqlDate>>(d_, i_);
        int? k_ = this.CumulativeDuration(context, j_);
        return k_;
    }


    [CqlFunctionDefinition("cumulativeMedicationDuration")]
    public int? cumulativeMedicationDuration(CqlContext context, IEnumerable<object> Medications)
    {

        bool? a_(object M) {
            bool l_ = M is MedicationRequest;
            return l_;
        }


        CqlInterval<CqlDate> b_(object M) {
            CqlInterval<CqlDate> m_ = this.medicationRequestPeriod(context, M as MedicationRequest);
            return m_;
        }

        IEnumerable<CqlInterval<CqlDate>> c_ = context.Operators.WhereSelect<object, CqlInterval<CqlDate>>(Medications, a_, b_);
        IEnumerable<CqlInterval<CqlDate>> d_ = context.Operators.Distinct<CqlInterval<CqlDate>>(c_);

        bool? e_(object M) {
            bool n_ = M is MedicationDispense;
            return n_;
        }


        CqlInterval<CqlDate> f_(object M) {
            CqlInterval<CqlDate> o_ = this.medicationDispensePeriod(context, M as MedicationDispense);
            return o_;
        }

        IEnumerable<CqlInterval<CqlDate>> g_ = context.Operators.WhereSelect<object, CqlInterval<CqlDate>>(Medications, e_, f_);
        IEnumerable<CqlInterval<CqlDate>> h_ = context.Operators.Distinct<CqlInterval<CqlDate>>(g_);
        IEnumerable<CqlInterval<CqlDate>> i_ = this.rolloutIntervals(context, h_);
        IEnumerable<CqlInterval<CqlDate>> j_ = context.Operators.Union<CqlInterval<CqlDate>>(d_, i_);
        int? k_ = this.cumulativeDuration(context, j_);
        return k_;
    }


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private CumulativeMedicationDuration_6_0_000() {}

    public static CumulativeMedicationDuration_6_0_000 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "CumulativeMedicationDuration";
    public string Version => "6.0.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, QICoreCommon_4_0_000.Instance];

    #endregion ILibrary Implementation

}
