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
            bool? g_ = context.Operators.Equal(a_, "min");
            if (g_ ?? false)
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
                bool? n_ = context.Operators.Equal(a_, "s");
                if (n_ ?? false)
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
                    bool? v_ = context.Operators.Equal(a_, "d");
                    if (v_ ?? false)
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
                        bool? ac_ = context.Operators.Equal(a_, "wk");
                        if (ac_ ?? false)
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
                            bool? ak_ = context.Operators.Equal(a_, "mo");
                            if (ak_ ?? false)
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
                                bool? as_ = context.Operators.Equal(a_, "a");
                                if (as_ ?? false)
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
                                    bool? ba_ = context.Operators.Equal(a_, "hour");
                                    if (ba_ ?? false)
                                    {
                                        decimal? bb_ = context.Operators.ConvertIntegerToDecimal(frequency);
                                        decimal? bc_ = period?.value;
                                        decimal? bd_ = context.Operators.Divide(24.0m, bc_);
                                        decimal? be_ = context.Operators.Multiply(bb_, bd_);
                                        return be_;
                                    }
                                    else
                                    {
                                        bool? bf_ = context.Operators.Equal(a_, "minute");
                                        if (bf_ ?? false)
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
                                            bool? bm_ = context.Operators.Equal(a_, "second");
                                            if (bm_ ?? false)
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
                                                bool? bu_ = context.Operators.Equal(a_, "day");
                                                if (bu_ ?? false)
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
                                                    bool? cb_ = context.Operators.Equal(a_, "week");
                                                    if (cb_ ?? false)
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
                                                        bool? cj_ = context.Operators.Equal(a_, "month");
                                                        if (cj_ ?? false)
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
                                                            bool? cr_ = context.Operators.Equal(a_, "year");
                                                            if (cr_ ?? false)
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
                                                                bool? cz_ = context.Operators.Equal(a_, "hours");
                                                                if (cz_ ?? false)
                                                                {
                                                                    decimal? da_ = context.Operators.ConvertIntegerToDecimal(frequency);
                                                                    decimal? db_ = period?.value;
                                                                    decimal? dc_ = context.Operators.Divide(24.0m, db_);
                                                                    decimal? dd_ = context.Operators.Multiply(da_, dc_);
                                                                    return dd_;
                                                                }
                                                                else
                                                                {
                                                                    bool? de_ = context.Operators.Equal(a_, "minutes");
                                                                    if (de_ ?? false)
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
                                                                        bool? dl_ = context.Operators.Equal(a_, "seconds");
                                                                        if (dl_ ?? false)
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
                                                                            bool? dt_ = context.Operators.Equal(a_, "days");
                                                                            if (dt_ ?? false)
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
                                                                                bool? ea_ = context.Operators.Equal(a_, "weeks");
                                                                                if (ea_ ?? false)
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
                                                                                    bool? ei_ = context.Operators.Equal(a_, "months");
                                                                                    if (ei_ ?? false)
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
                                                                                        bool? eq_ = context.Operators.Equal(a_, "years");
                                                                                        if (eq_ ?? false)
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
        bool? b_ = context.Operators.Equivalent(frequency, a_);
        if (b_ ?? false)
        {
            decimal? c_ = context.Operators.ConvertIntegerToDecimal(1);
            return c_;
        }
        else
        {
            CqlCode d_ = this.WAKE(context);
            bool? e_ = context.Operators.Equivalent(frequency, d_);
            if (e_ ?? false)
            {
                decimal? f_ = context.Operators.ConvertIntegerToDecimal(1);
                return f_;
            }
            else
            {
                CqlCode g_ = this.C(context);
                bool? h_ = context.Operators.Equivalent(frequency, g_);
                if (h_ ?? false)
                {
                    decimal? i_ = context.Operators.ConvertIntegerToDecimal(3);
                    return i_;
                }
                else
                {
                    CqlCode j_ = this.CM(context);
                    bool? k_ = context.Operators.Equivalent(frequency, j_);
                    if (k_ ?? false)
                    {
                        decimal? l_ = context.Operators.ConvertIntegerToDecimal(1);
                        return l_;
                    }
                    else
                    {
                        CqlCode m_ = this.CD(context);
                        bool? n_ = context.Operators.Equivalent(frequency, m_);
                        if (n_ ?? false)
                        {
                            decimal? o_ = context.Operators.ConvertIntegerToDecimal(1);
                            return o_;
                        }
                        else
                        {
                            CqlCode p_ = this.CV(context);
                            bool? q_ = context.Operators.Equivalent(frequency, p_);
                            if (q_ ?? false)
                            {
                                decimal? r_ = context.Operators.ConvertIntegerToDecimal(1);
                                return r_;
                            }
                            else
                            {
                                CqlCode s_ = this.AC(context);
                                bool? t_ = context.Operators.Equivalent(frequency, s_);
                                if (t_ ?? false)
                                {
                                    decimal? u_ = context.Operators.ConvertIntegerToDecimal(3);
                                    return u_;
                                }
                                else
                                {
                                    CqlCode v_ = this.ACM(context);
                                    bool? w_ = context.Operators.Equivalent(frequency, v_);
                                    if (w_ ?? false)
                                    {
                                        decimal? x_ = context.Operators.ConvertIntegerToDecimal(1);
                                        return x_;
                                    }
                                    else
                                    {
                                        CqlCode y_ = this.ACD(context);
                                        bool? z_ = context.Operators.Equivalent(frequency, y_);
                                        if (z_ ?? false)
                                        {
                                            decimal? aa_ = context.Operators.ConvertIntegerToDecimal(1);
                                            return aa_;
                                        }
                                        else
                                        {
                                            CqlCode ab_ = this.ACV(context);
                                            bool? ac_ = context.Operators.Equivalent(frequency, ab_);
                                            if (ac_ ?? false)
                                            {
                                                decimal? ad_ = context.Operators.ConvertIntegerToDecimal(1);
                                                return ad_;
                                            }
                                            else
                                            {
                                                CqlCode ae_ = this.PC(context);
                                                bool? af_ = context.Operators.Equivalent(frequency, ae_);
                                                if (af_ ?? false)
                                                {
                                                    decimal? ag_ = context.Operators.ConvertIntegerToDecimal(3);
                                                    return ag_;
                                                }
                                                else
                                                {
                                                    CqlCode ah_ = this.PCM(context);
                                                    bool? ai_ = context.Operators.Equivalent(frequency, ah_);
                                                    if (ai_ ?? false)
                                                    {
                                                        decimal? aj_ = context.Operators.ConvertIntegerToDecimal(1);
                                                        return aj_;
                                                    }
                                                    else
                                                    {
                                                        CqlCode ak_ = this.PCD(context);
                                                        bool? al_ = context.Operators.Equivalent(frequency, ak_);
                                                        if (al_ ?? false)
                                                        {
                                                            decimal? am_ = context.Operators.ConvertIntegerToDecimal(1);
                                                            return am_;
                                                        }
                                                        else
                                                        {
                                                            CqlCode an_ = this.PCV(context);
                                                            bool? ao_ = context.Operators.Equivalent(frequency, an_);
                                                            if (ao_ ?? false)
                                                            {
                                                                decimal? ap_ = context.Operators.ConvertIntegerToDecimal(1);
                                                                return ap_;
                                                            }
                                                            else
                                                            {
                                                                CqlCode aq_ = this.MORN(context);
                                                                bool? ar_ = context.Operators.Equivalent(frequency, aq_);
                                                                if (ar_ ?? false)
                                                                {
                                                                    decimal? as_ = context.Operators.ConvertIntegerToDecimal(1);
                                                                    return as_;
                                                                }
                                                                else
                                                                {
                                                                    CqlCode at_ = this.MORN_early(context);
                                                                    bool? au_ = context.Operators.Equivalent(frequency, at_);
                                                                    if (au_ ?? false)
                                                                    {
                                                                        decimal? av_ = context.Operators.ConvertIntegerToDecimal(1);
                                                                        return av_;
                                                                    }
                                                                    else
                                                                    {
                                                                        CqlCode aw_ = this.MORN_late(context);
                                                                        bool? ax_ = context.Operators.Equivalent(frequency, aw_);
                                                                        if (ax_ ?? false)
                                                                        {
                                                                            decimal? ay_ = context.Operators.ConvertIntegerToDecimal(1);
                                                                            return ay_;
                                                                        }
                                                                        else
                                                                        {
                                                                            CqlCode az_ = this.NOON(context);
                                                                            bool? ba_ = context.Operators.Equivalent(frequency, az_);
                                                                            if (ba_ ?? false)
                                                                            {
                                                                                decimal? bb_ = context.Operators.ConvertIntegerToDecimal(1);
                                                                                return bb_;
                                                                            }
                                                                            else
                                                                            {
                                                                                CqlCode bc_ = this.AFT(context);
                                                                                bool? bd_ = context.Operators.Equivalent(frequency, bc_);
                                                                                if (bd_ ?? false)
                                                                                {
                                                                                    decimal? be_ = context.Operators.ConvertIntegerToDecimal(1);
                                                                                    return be_;
                                                                                }
                                                                                else
                                                                                {
                                                                                    CqlCode bf_ = this.AFT_early(context);
                                                                                    bool? bg_ = context.Operators.Equivalent(frequency, bf_);
                                                                                    if (bg_ ?? false)
                                                                                    {
                                                                                        decimal? bh_ = context.Operators.ConvertIntegerToDecimal(1);
                                                                                        return bh_;
                                                                                    }
                                                                                    else
                                                                                    {
                                                                                        CqlCode bi_ = this.AFT_late(context);
                                                                                        bool? bj_ = context.Operators.Equivalent(frequency, bi_);
                                                                                        if (bj_ ?? false)
                                                                                        {
                                                                                            decimal? bk_ = context.Operators.ConvertIntegerToDecimal(1);
                                                                                            return bk_;
                                                                                        }
                                                                                        else
                                                                                        {
                                                                                            CqlCode bl_ = this.EVE(context);
                                                                                            bool? bm_ = context.Operators.Equivalent(frequency, bl_);
                                                                                            if (bm_ ?? false)
                                                                                            {
                                                                                                decimal? bn_ = context.Operators.ConvertIntegerToDecimal(1);
                                                                                                return bn_;
                                                                                            }
                                                                                            else
                                                                                            {
                                                                                                CqlCode bo_ = this.EVE_early(context);
                                                                                                bool? bp_ = context.Operators.Equivalent(frequency, bo_);
                                                                                                if (bp_ ?? false)
                                                                                                {
                                                                                                    decimal? bq_ = context.Operators.ConvertIntegerToDecimal(1);
                                                                                                    return bq_;
                                                                                                }
                                                                                                else
                                                                                                {
                                                                                                    CqlCode br_ = this.EVE_late(context);
                                                                                                    bool? bs_ = context.Operators.Equivalent(frequency, br_);
                                                                                                    if (bs_ ?? false)
                                                                                                    {
                                                                                                        decimal? bt_ = context.Operators.ConvertIntegerToDecimal(1);
                                                                                                        return bt_;
                                                                                                    }
                                                                                                    else
                                                                                                    {
                                                                                                        CqlCode bu_ = this.NIGHT(context);
                                                                                                        bool? bv_ = context.Operators.Equivalent(frequency, bu_);
                                                                                                        if (bv_ ?? false)
                                                                                                        {
                                                                                                            decimal? bw_ = context.Operators.ConvertIntegerToDecimal(1);
                                                                                                            return bw_;
                                                                                                        }
                                                                                                        else
                                                                                                        {
                                                                                                            CqlCode bx_ = this.PHS(context);
                                                                                                            bool? by_ = context.Operators.Equivalent(frequency, bx_);
                                                                                                            if (by_ ?? false)
                                                                                                            {
                                                                                                                decimal? bz_ = context.Operators.ConvertIntegerToDecimal(1);
                                                                                                                return bz_;
                                                                                                            }
                                                                                                            else
                                                                                                            {
                                                                                                                CqlCode ca_ = this.Once_daily__qualifier_value_(context);
                                                                                                                bool? cb_ = context.Operators.Equivalent(frequency, ca_);
                                                                                                                if (cb_ ?? false)
                                                                                                                {
                                                                                                                    return 1.0m;
                                                                                                                }
                                                                                                                else
                                                                                                                {
                                                                                                                    CqlCode cc_ = this.Twice_a_day__qualifier_value_(context);
                                                                                                                    bool? cd_ = context.Operators.Equivalent(frequency, cc_);
                                                                                                                    if (cd_ ?? false)
                                                                                                                    {
                                                                                                                        return 2.0m;
                                                                                                                    }
                                                                                                                    else
                                                                                                                    {
                                                                                                                        CqlCode ce_ = this.Three_times_daily__qualifier_value_(context);
                                                                                                                        bool? cf_ = context.Operators.Equivalent(frequency, ce_);
                                                                                                                        if (cf_ ?? false)
                                                                                                                        {
                                                                                                                            return 3.0m;
                                                                                                                        }
                                                                                                                        else
                                                                                                                        {
                                                                                                                            CqlCode cg_ = this.Four_times_daily__qualifier_value_(context);
                                                                                                                            bool? ch_ = context.Operators.Equivalent(frequency, cg_);
                                                                                                                            if (ch_ ?? false)
                                                                                                                            {
                                                                                                                                return 4.0m;
                                                                                                                            }
                                                                                                                            else
                                                                                                                            {
                                                                                                                                CqlCode ci_ = this.Every_twenty_four_hours__qualifier_value_(context);
                                                                                                                                bool? cj_ = context.Operators.Equivalent(frequency, ci_);
                                                                                                                                if (cj_ ?? false)
                                                                                                                                {
                                                                                                                                    return 1.0m;
                                                                                                                                }
                                                                                                                                else
                                                                                                                                {
                                                                                                                                    CqlCode ck_ = this.Every_twelve_hours__qualifier_value_(context);
                                                                                                                                    bool? cl_ = context.Operators.Equivalent(frequency, ck_);
                                                                                                                                    if (cl_ ?? false)
                                                                                                                                    {
                                                                                                                                        return 2.0m;
                                                                                                                                    }
                                                                                                                                    else
                                                                                                                                    {
                                                                                                                                        CqlCode cm_ = this.Every_thirty_six_hours__qualifier_value_(context);
                                                                                                                                        bool? cn_ = context.Operators.Equivalent(frequency, cm_);
                                                                                                                                        if (cn_ ?? false)
                                                                                                                                        {
                                                                                                                                            return 0.67m;
                                                                                                                                        }
                                                                                                                                        else
                                                                                                                                        {
                                                                                                                                            CqlCode co_ = this.Every_eight_hours__qualifier_value_(context);
                                                                                                                                            bool? cp_ = context.Operators.Equivalent(frequency, co_);
                                                                                                                                            if (cp_ ?? false)
                                                                                                                                            {
                                                                                                                                                return 3.0m;
                                                                                                                                            }
                                                                                                                                            else
                                                                                                                                            {
                                                                                                                                                CqlCode cq_ = this.Every_four_hours__qualifier_value_(context);
                                                                                                                                                bool? cr_ = context.Operators.Equivalent(frequency, cq_);
                                                                                                                                                if (cr_ ?? false)
                                                                                                                                                {
                                                                                                                                                    return 6.0m;
                                                                                                                                                }
                                                                                                                                                else
                                                                                                                                                {
                                                                                                                                                    CqlCode cs_ = this.Every_six_hours__qualifier_value_(context);
                                                                                                                                                    bool? ct_ = context.Operators.Equivalent(frequency, cs_);
                                                                                                                                                    if (ct_ ?? false)
                                                                                                                                                    {
                                                                                                                                                        return 4.0m;
                                                                                                                                                    }
                                                                                                                                                    else
                                                                                                                                                    {
                                                                                                                                                        CqlCode cu_ = this.Every_seventy_two_hours__qualifier_value_(context);
                                                                                                                                                        bool? cv_ = context.Operators.Equivalent(frequency, cu_);
                                                                                                                                                        if (cv_ ?? false)
                                                                                                                                                        {
                                                                                                                                                            return 0.33m;
                                                                                                                                                        }
                                                                                                                                                        else
                                                                                                                                                        {
                                                                                                                                                            CqlCode cw_ = this.Every_forty_eight_hours__qualifier_value_(context);
                                                                                                                                                            bool? cx_ = context.Operators.Equivalent(frequency, cw_);
                                                                                                                                                            if (cx_ ?? false)
                                                                                                                                                            {
                                                                                                                                                                return 0.5m;
                                                                                                                                                            }
                                                                                                                                                            else
                                                                                                                                                            {
                                                                                                                                                                CqlCode cy_ = this.Every_eight_to_twelve_hours__qualifier_value_(context);
                                                                                                                                                                bool? cz_ = context.Operators.Equivalent(frequency, cy_);
                                                                                                                                                                if (cz_ ?? false)
                                                                                                                                                                {
                                                                                                                                                                    return 3.0m;
                                                                                                                                                                }
                                                                                                                                                                else
                                                                                                                                                                {
                                                                                                                                                                    CqlCode da_ = this.Every_six_to_eight_hours__qualifier_value_(context);
                                                                                                                                                                    bool? db_ = context.Operators.Equivalent(frequency, da_);
                                                                                                                                                                    if (db_ ?? false)
                                                                                                                                                                    {
                                                                                                                                                                        return 4.0m;
                                                                                                                                                                    }
                                                                                                                                                                    else
                                                                                                                                                                    {
                                                                                                                                                                        CqlCode dc_ = this.Every_three_to_four_hours__qualifier_value_(context);
                                                                                                                                                                        bool? dd_ = context.Operators.Equivalent(frequency, dc_);
                                                                                                                                                                        if (dd_ ?? false)
                                                                                                                                                                        {
                                                                                                                                                                            return 8.0m;
                                                                                                                                                                        }
                                                                                                                                                                        else
                                                                                                                                                                        {
                                                                                                                                                                            CqlCode de_ = this.Every_three_to_six_hours__qualifier_value_(context);
                                                                                                                                                                            bool? df_ = context.Operators.Equivalent(frequency, de_);
                                                                                                                                                                            if (df_ ?? false)
                                                                                                                                                                            {
                                                                                                                                                                                return 8.0m;
                                                                                                                                                                            }
                                                                                                                                                                            else
                                                                                                                                                                            {
                                                                                                                                                                                CqlCode dg_ = this.Every_two_to_four_hours__qualifier_value_(context);
                                                                                                                                                                                bool? dh_ = context.Operators.Equivalent(frequency, dg_);
                                                                                                                                                                                if (dh_ ?? false)
                                                                                                                                                                                {
                                                                                                                                                                                    return 12.0m;
                                                                                                                                                                                }
                                                                                                                                                                                else
                                                                                                                                                                                {
                                                                                                                                                                                    CqlCode di_ = this.One_to_four_times_a_day__qualifier_value_(context);
                                                                                                                                                                                    bool? dj_ = context.Operators.Equivalent(frequency, di_);
                                                                                                                                                                                    if (dj_ ?? false)
                                                                                                                                                                                    {
                                                                                                                                                                                        return 4.0m;
                                                                                                                                                                                    }
                                                                                                                                                                                    else
                                                                                                                                                                                    {
                                                                                                                                                                                        CqlCode dk_ = this.One_to_three_times_a_day__qualifier_value_(context);
                                                                                                                                                                                        bool? dl_ = context.Operators.Equivalent(frequency, dk_);
                                                                                                                                                                                        if (dl_ ?? false)
                                                                                                                                                                                        {
                                                                                                                                                                                            return 3.0m;
                                                                                                                                                                                        }
                                                                                                                                                                                        else
                                                                                                                                                                                        {
                                                                                                                                                                                            CqlCode dm_ = this.One_to_two_times_a_day__qualifier_value_(context);
                                                                                                                                                                                            bool? dn_ = context.Operators.Equivalent(frequency, dm_);
                                                                                                                                                                                            if (dn_ ?? false)
                                                                                                                                                                                            {
                                                                                                                                                                                                return 2.0m;
                                                                                                                                                                                            }
                                                                                                                                                                                            else
                                                                                                                                                                                            {
                                                                                                                                                                                                CqlCode do_ = this.Two_to_four_times_a_day__qualifier_value_(context);
                                                                                                                                                                                                bool? dp_ = context.Operators.Equivalent(frequency, do_);
                                                                                                                                                                                                if (dp_ ?? false)
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
            bool? u_ = !((bool?)(((l_ ?? o_) ?? t_) is null));
            bool? v_;
            // CQL 'and' (260:10-260:64): right operand skipped when left is false
            if (u_ is false)
            {
                v_ = false;
            }
            else
            {
                Duration w_ = p_?.ExpectedSupplyDuration;
                CqlQuantity x_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, w_);
                CqlQuantity y_ = context.Operators.ConvertQuantity(x_, "d");
                decimal? z_ = y_?.value;
                Quantity aa_ = p_?.Quantity;
                CqlQuantity ab_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, aa_);
                decimal? ac_ = ab_?.value;
                List<Dosage.DoseAndRateComponent> ad_ = f_?.DoseAndRate;
                Dosage.DoseAndRateComponent ae_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)ad_);
                DataType af_ = ae_?.Dose;
                object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                CqlQuantity ah_ = context.Operators.End(ag_ as CqlInterval<CqlQuantity>);
                decimal? ai_ = (ah_ ?? ag_ as CqlQuantity)?.value;
                PositiveInt aj_ = h_?.FrequencyMaxElement;
                int? ak_ = aj_?.Value;
                PositiveInt al_ = h_?.FrequencyElement;
                int? am_ = al_?.Value;
                FhirDecimal an_ = h_?.PeriodElement;
                decimal? ao_ = an_?.Value;
                Code<Timing.UnitsOfTime> ap_ = h_?.PeriodUnitElement;
                Timing.UnitsOfTime? aq_ = ap_?.Value;
                string ar_ = context.Operators.Convert<string>(aq_);
                CqlQuantity as_ = this.Quantity(context, ao_, ar_);
                decimal? at_ = this.ToDaily(context, ak_ ?? am_, as_);
                List<Time> au_ = h_?.TimeOfDayElement;

                string av_(Time @this) {
                    string bi_ = @this?.Value;
                    return bi_;
                }

                IEnumerable<string> aw_ = context.Operators.Select<Time, string>((IEnumerable<Time>)au_, av_);

                CqlTime ax_(string @string) {
                    CqlTime bj_ = context.Operators.ConvertStringToTime(@string);
                    return bj_;
                }

                IEnumerable<CqlTime> ay_ = context.Operators.Select<string, CqlTime>(aw_, ax_);
                int? az_ = context.Operators.Count<CqlTime>(ay_);
                decimal? ba_ = context.Operators.ConvertIntegerToDecimal(az_);
                decimal? bb_ = context.Operators.Multiply(ai_, (at_ ?? ba_) ?? 1.0m);
                decimal? bc_ = context.Operators.Divide(ac_, bb_);
                UnsignedInt bd_ = p_?.NumberOfRepeatsAllowedElement;
                int? be_ = bd_?.Value;
                int? bf_ = context.Operators.Add(1, be_ ?? 0);
                decimal? bg_ = context.Operators.ConvertIntegerToDecimal(bf_);
                decimal? bh_ = context.Operators.Multiply(z_ ?? bc_, bg_);
                v_ = u_ & (!((bool?)(bh_ is null)));
            }
            if (v_ ?? false)
            {
                Duration bk_ = p_?.ExpectedSupplyDuration;
                CqlQuantity bl_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, bk_);
                CqlQuantity bm_ = context.Operators.ConvertQuantity(bl_, "d");
                decimal? bn_ = bm_?.value;
                Quantity bo_ = p_?.Quantity;
                CqlQuantity bp_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, bo_);
                decimal? bq_ = bp_?.value;
                List<Dosage.DoseAndRateComponent> br_ = f_?.DoseAndRate;
                Dosage.DoseAndRateComponent bs_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)br_);
                DataType bt_ = bs_?.Dose;
                object bu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bt_);
                CqlQuantity bv_ = context.Operators.End(bu_ as CqlInterval<CqlQuantity>);
                decimal? bw_ = (bv_ ?? bu_ as CqlQuantity)?.value;
                PositiveInt bx_ = h_?.FrequencyMaxElement;
                int? by_ = bx_?.Value;
                PositiveInt bz_ = h_?.FrequencyElement;
                int? ca_ = bz_?.Value;
                FhirDecimal cb_ = h_?.PeriodElement;
                decimal? cc_ = cb_?.Value;
                Code<Timing.UnitsOfTime> cd_ = h_?.PeriodUnitElement;
                Timing.UnitsOfTime? ce_ = cd_?.Value;
                string cf_ = context.Operators.Convert<string>(ce_);
                CqlQuantity cg_ = this.Quantity(context, cc_, cf_);
                decimal? ch_ = this.ToDaily(context, by_ ?? ca_, cg_);
                List<Time> ci_ = h_?.TimeOfDayElement;

                string cj_(Time @this) {
                    string db_ = @this?.Value;
                    return db_;
                }

                IEnumerable<string> ck_ = context.Operators.Select<Time, string>((IEnumerable<Time>)ci_, cj_);

                CqlTime cl_(string @string) {
                    CqlTime dc_ = context.Operators.ConvertStringToTime(@string);
                    return dc_;
                }

                IEnumerable<CqlTime> cm_ = context.Operators.Select<string, CqlTime>(ck_, cl_);
                int? cn_ = context.Operators.Count<CqlTime>(cm_);
                decimal? co_ = context.Operators.ConvertIntegerToDecimal(cn_);
                decimal? cp_ = context.Operators.Multiply(bw_, (ch_ ?? co_) ?? 1.0m);
                decimal? cq_ = context.Operators.Divide(bq_, cp_);
                UnsignedInt cr_ = p_?.NumberOfRepeatsAllowedElement;
                int? cs_ = cr_?.Value;
                int? ct_ = context.Operators.Add(1, cs_ ?? 0);
                decimal? cu_ = context.Operators.ConvertIntegerToDecimal(ct_);
                decimal? cv_ = context.Operators.Multiply(bn_ ?? cq_, cu_);
                decimal? cw_ = context.Operators.ConvertIntegerToDecimal(1);
                decimal? cx_ = context.Operators.Subtract(cv_, cw_);
                CqlQuantity cy_ = this.Quantity(context, cx_, "day");
                CqlDate cz_ = context.Operators.Add((l_ ?? o_) ?? t_, cy_);
                CqlInterval<CqlDate> da_ = context.Operators.Interval((l_ ?? o_) ?? t_, cz_, true, true);
                return da_;
            }
            else
            {
                bool? dd_;
                // CQL 'and' (262:15-262:71): right operand skipped when left is false
                if (u_ is false)
                {
                    dd_ = false;
                }
                else
                {
                    CqlDateTime de_ = (j_ as CqlInterval<CqlDateTime>)?.high;
                    dd_ = u_ & (!((bool?)(de_ is null)));
                }
                if (dd_ ?? false)
                {
                    CqlDateTime df_ = context.Operators.End(j_ as CqlInterval<CqlDateTime>);
                    CqlDate dg_ = context.Operators.DateFrom(df_);
                    CqlInterval<CqlDate> dh_ = context.Operators.Interval((l_ ?? o_) ?? t_, dg_, true, true);
                    return dh_;
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
            bool? u_ = !((bool?)(((l_ ?? o_) ?? t_) is null));
            bool? v_;
            // CQL 'and' (291:10-291:64): right operand skipped when left is false
            if (u_ is false)
            {
                v_ = false;
            }
            else
            {
                Duration w_ = p_?.ExpectedSupplyDuration;
                CqlQuantity x_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, w_);
                CqlQuantity y_ = context.Operators.ConvertQuantity(x_, "d");
                decimal? z_ = y_?.value;
                Quantity aa_ = p_?.Quantity;
                CqlQuantity ab_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, aa_);
                decimal? ac_ = ab_?.value;
                List<Dosage.DoseAndRateComponent> ad_ = f_?.DoseAndRate;
                Dosage.DoseAndRateComponent ae_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)ad_);
                DataType af_ = ae_?.Dose;
                object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                CqlQuantity ah_ = context.Operators.End(ag_ as CqlInterval<CqlQuantity>);
                decimal? ai_ = (ah_ ?? ag_ as CqlQuantity)?.value;
                PositiveInt aj_ = h_?.FrequencyMaxElement;
                int? ak_ = aj_?.Value;
                PositiveInt al_ = h_?.FrequencyElement;
                int? am_ = al_?.Value;
                FhirDecimal an_ = h_?.PeriodElement;
                decimal? ao_ = an_?.Value;
                Code<Timing.UnitsOfTime> ap_ = h_?.PeriodUnitElement;
                Timing.UnitsOfTime? aq_ = ap_?.Value;
                string ar_ = context.Operators.Convert<string>(aq_);
                CqlQuantity as_ = this.Quantity(context, ao_, ar_);
                decimal? at_ = this.ToDaily(context, ak_ ?? am_, as_);
                List<Time> au_ = h_?.TimeOfDayElement;

                string av_(Time @this) {
                    string bi_ = @this?.Value;
                    return bi_;
                }

                IEnumerable<string> aw_ = context.Operators.Select<Time, string>((IEnumerable<Time>)au_, av_);

                CqlTime ax_(string @string) {
                    CqlTime bj_ = context.Operators.ConvertStringToTime(@string);
                    return bj_;
                }

                IEnumerable<CqlTime> ay_ = context.Operators.Select<string, CqlTime>(aw_, ax_);
                int? az_ = context.Operators.Count<CqlTime>(ay_);
                decimal? ba_ = context.Operators.ConvertIntegerToDecimal(az_);
                decimal? bb_ = context.Operators.Multiply(ai_, (at_ ?? ba_) ?? 1.0m);
                decimal? bc_ = context.Operators.Divide(ac_, bb_);
                UnsignedInt bd_ = p_?.NumberOfRepeatsAllowedElement;
                int? be_ = bd_?.Value;
                int? bf_ = context.Operators.Add(1, be_ ?? 0);
                decimal? bg_ = context.Operators.ConvertIntegerToDecimal(bf_);
                decimal? bh_ = context.Operators.Multiply(z_ ?? bc_, bg_);
                v_ = u_ & (!((bool?)(bh_ is null)));
            }
            if (v_ ?? false)
            {
                Duration bk_ = p_?.ExpectedSupplyDuration;
                CqlQuantity bl_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, bk_);
                CqlQuantity bm_ = context.Operators.ConvertQuantity(bl_, "d");
                decimal? bn_ = bm_?.value;
                Quantity bo_ = p_?.Quantity;
                CqlQuantity bp_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, bo_);
                decimal? bq_ = bp_?.value;
                List<Dosage.DoseAndRateComponent> br_ = f_?.DoseAndRate;
                Dosage.DoseAndRateComponent bs_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)br_);
                DataType bt_ = bs_?.Dose;
                object bu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bt_);
                CqlQuantity bv_ = context.Operators.End(bu_ as CqlInterval<CqlQuantity>);
                decimal? bw_ = (bv_ ?? bu_ as CqlQuantity)?.value;
                PositiveInt bx_ = h_?.FrequencyMaxElement;
                int? by_ = bx_?.Value;
                PositiveInt bz_ = h_?.FrequencyElement;
                int? ca_ = bz_?.Value;
                FhirDecimal cb_ = h_?.PeriodElement;
                decimal? cc_ = cb_?.Value;
                Code<Timing.UnitsOfTime> cd_ = h_?.PeriodUnitElement;
                Timing.UnitsOfTime? ce_ = cd_?.Value;
                string cf_ = context.Operators.Convert<string>(ce_);
                CqlQuantity cg_ = this.Quantity(context, cc_, cf_);
                decimal? ch_ = this.ToDaily(context, by_ ?? ca_, cg_);
                List<Time> ci_ = h_?.TimeOfDayElement;

                string cj_(Time @this) {
                    string db_ = @this?.Value;
                    return db_;
                }

                IEnumerable<string> ck_ = context.Operators.Select<Time, string>((IEnumerable<Time>)ci_, cj_);

                CqlTime cl_(string @string) {
                    CqlTime dc_ = context.Operators.ConvertStringToTime(@string);
                    return dc_;
                }

                IEnumerable<CqlTime> cm_ = context.Operators.Select<string, CqlTime>(ck_, cl_);
                int? cn_ = context.Operators.Count<CqlTime>(cm_);
                decimal? co_ = context.Operators.ConvertIntegerToDecimal(cn_);
                decimal? cp_ = context.Operators.Multiply(bw_, (ch_ ?? co_) ?? 1.0m);
                decimal? cq_ = context.Operators.Divide(bq_, cp_);
                UnsignedInt cr_ = p_?.NumberOfRepeatsAllowedElement;
                int? cs_ = cr_?.Value;
                int? ct_ = context.Operators.Add(1, cs_ ?? 0);
                decimal? cu_ = context.Operators.ConvertIntegerToDecimal(ct_);
                decimal? cv_ = context.Operators.Multiply(bn_ ?? cq_, cu_);
                decimal? cw_ = context.Operators.ConvertIntegerToDecimal(1);
                decimal? cx_ = context.Operators.Subtract(cv_, cw_);
                CqlQuantity cy_ = this.Quantity(context, cx_, "day");
                CqlDate cz_ = context.Operators.Add((l_ ?? o_) ?? t_, cy_);
                CqlInterval<CqlDate> da_ = context.Operators.Interval((l_ ?? o_) ?? t_, cz_, true, true);
                return da_;
            }
            else
            {
                bool? dd_;
                // CQL 'and' (293:15-293:71): right operand skipped when left is false
                if (u_ is false)
                {
                    dd_ = false;
                }
                else
                {
                    CqlDateTime de_ = (j_ as CqlInterval<CqlDateTime>)?.high;
                    dd_ = u_ & (!((bool?)(de_ is null)));
                }
                if (dd_ ?? false)
                {
                    CqlDateTime df_ = context.Operators.End(j_ as CqlInterval<CqlDateTime>);
                    CqlDate dg_ = context.Operators.DateFrom(df_);
                    CqlInterval<CqlDate> dh_ = context.Operators.Interval((l_ ?? o_) ?? t_, dg_, true, true);
                    return dh_;
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
            bool? k_ = !((bool?)((g_ ?? j_) is null));
            bool? l_;
            // CQL 'and' (387:10-387:64): right operand skipped when left is false
            if (k_ is false)
            {
                l_ = false;
            }
            else
            {
                Quantity m_ = D?.DaysSupply;
                CqlQuantity n_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, m_);
                CqlQuantity o_ = context.Operators.ConvertQuantity(n_, "d");
                decimal? p_ = o_?.value;
                Quantity q_ = D?.Quantity;
                CqlQuantity r_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, q_);
                decimal? s_ = r_?.value;
                List<Dosage> t_ = D?.DosageInstruction;
                Dosage u_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)t_);
                List<Dosage.DoseAndRateComponent> v_ = u_?.DoseAndRate;
                Dosage.DoseAndRateComponent w_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)v_);
                DataType x_ = w_?.Dose;
                object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                CqlQuantity z_ = context.Operators.End(y_ as CqlInterval<CqlQuantity>);
                decimal? aa_ = (z_ ?? y_ as CqlQuantity)?.value;
                Timing ab_ = u_?.Timing;
                Timing.RepeatComponent ac_ = ab_?.Repeat;
                PositiveInt ad_ = ac_?.FrequencyMaxElement;
                int? ae_ = ad_?.Value;
                PositiveInt af_ = ac_?.FrequencyElement;
                int? ag_ = af_?.Value;
                FhirDecimal ah_ = ac_?.PeriodElement;
                decimal? ai_ = ah_?.Value;
                Code<Timing.UnitsOfTime> aj_ = ac_?.PeriodUnitElement;
                Timing.UnitsOfTime? ak_ = aj_?.Value;
                string al_ = context.Operators.Convert<string>(ak_);
                CqlQuantity am_ = this.Quantity(context, ai_, al_);
                decimal? an_ = this.ToDaily(context, ae_ ?? ag_, am_);
                List<Time> ao_ = ac_?.TimeOfDayElement;

                string ap_(Time @this) {
                    string ax_ = @this?.Value;
                    return ax_;
                }

                IEnumerable<string> aq_ = context.Operators.Select<Time, string>((IEnumerable<Time>)ao_, ap_);

                CqlTime ar_(string @string) {
                    CqlTime ay_ = context.Operators.ConvertStringToTime(@string);
                    return ay_;
                }

                IEnumerable<CqlTime> as_ = context.Operators.Select<string, CqlTime>(aq_, ar_);
                int? at_ = context.Operators.Count<CqlTime>(as_);
                decimal? au_ = context.Operators.ConvertIntegerToDecimal(at_);
                decimal? av_ = context.Operators.Multiply(aa_, (an_ ?? au_) ?? 1.0m);
                decimal? aw_ = context.Operators.Divide(s_, av_);
                l_ = k_ & (!((bool?)((p_ ?? aw_) is null)));
            }
            if (l_ ?? false)
            {
                Quantity az_ = D?.DaysSupply;
                CqlQuantity ba_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, az_);
                CqlQuantity bb_ = context.Operators.ConvertQuantity(ba_, "d");
                decimal? bc_ = bb_?.value;
                Quantity bd_ = D?.Quantity;
                CqlQuantity be_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, bd_);
                decimal? bf_ = be_?.value;
                List<Dosage> bg_ = D?.DosageInstruction;
                Dosage bh_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)bg_);
                List<Dosage.DoseAndRateComponent> bi_ = bh_?.DoseAndRate;
                Dosage.DoseAndRateComponent bj_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)bi_);
                DataType bk_ = bj_?.Dose;
                object bl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bk_);
                CqlQuantity bm_ = context.Operators.End(bl_ as CqlInterval<CqlQuantity>);
                decimal? bn_ = (bm_ ?? bl_ as CqlQuantity)?.value;
                Timing bo_ = bh_?.Timing;
                Timing.RepeatComponent bp_ = bo_?.Repeat;
                PositiveInt bq_ = bp_?.FrequencyMaxElement;
                int? br_ = bq_?.Value;
                PositiveInt bs_ = bp_?.FrequencyElement;
                int? bt_ = bs_?.Value;
                FhirDecimal bu_ = bp_?.PeriodElement;
                decimal? bv_ = bu_?.Value;
                Code<Timing.UnitsOfTime> bw_ = bp_?.PeriodUnitElement;
                Timing.UnitsOfTime? bx_ = bw_?.Value;
                string by_ = context.Operators.Convert<string>(bx_);
                CqlQuantity bz_ = this.Quantity(context, bv_, by_);
                decimal? ca_ = this.ToDaily(context, br_ ?? bt_, bz_);
                List<Time> cb_ = bp_?.TimeOfDayElement;

                string cc_(Time @this) {
                    string cp_ = @this?.Value;
                    return cp_;
                }

                IEnumerable<string> cd_ = context.Operators.Select<Time, string>((IEnumerable<Time>)cb_, cc_);

                CqlTime ce_(string @string) {
                    CqlTime cq_ = context.Operators.ConvertStringToTime(@string);
                    return cq_;
                }

                IEnumerable<CqlTime> cf_ = context.Operators.Select<string, CqlTime>(cd_, ce_);
                int? cg_ = context.Operators.Count<CqlTime>(cf_);
                decimal? ch_ = context.Operators.ConvertIntegerToDecimal(cg_);
                decimal? ci_ = context.Operators.Multiply(bn_, (ca_ ?? ch_) ?? 1.0m);
                decimal? cj_ = context.Operators.Divide(bf_, ci_);
                decimal? ck_ = context.Operators.ConvertIntegerToDecimal(1);
                decimal? cl_ = context.Operators.Subtract(bc_ ?? cj_, ck_);
                CqlQuantity cm_ = this.Quantity(context, cl_, "day");
                CqlDate cn_ = context.Operators.Add(g_ ?? j_, cm_);
                CqlInterval<CqlDate> co_ = context.Operators.Interval(g_ ?? j_, cn_, true, true);
                return co_;
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
            bool? k_ = !((bool?)((g_ ?? j_) is null));
            bool? l_;
            // CQL 'and' (438:10-438:64): right operand skipped when left is false
            if (k_ is false)
            {
                l_ = false;
            }
            else
            {
                Quantity m_ = D?.DaysSupply;
                CqlQuantity n_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, m_);
                CqlQuantity o_ = context.Operators.ConvertQuantity(n_, "d");
                decimal? p_ = o_?.value;
                Quantity q_ = D?.Quantity;
                CqlQuantity r_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, q_);
                decimal? s_ = r_?.value;
                List<Dosage> t_ = D?.DosageInstruction;
                Dosage u_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)t_);
                List<Dosage.DoseAndRateComponent> v_ = u_?.DoseAndRate;
                Dosage.DoseAndRateComponent w_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)v_);
                DataType x_ = w_?.Dose;
                object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                CqlQuantity z_ = context.Operators.End(y_ as CqlInterval<CqlQuantity>);
                decimal? aa_ = (z_ ?? y_ as CqlQuantity)?.value;
                Timing ab_ = u_?.Timing;
                Timing.RepeatComponent ac_ = ab_?.Repeat;
                PositiveInt ad_ = ac_?.FrequencyMaxElement;
                int? ae_ = ad_?.Value;
                PositiveInt af_ = ac_?.FrequencyElement;
                int? ag_ = af_?.Value;
                FhirDecimal ah_ = ac_?.PeriodElement;
                decimal? ai_ = ah_?.Value;
                Code<Timing.UnitsOfTime> aj_ = ac_?.PeriodUnitElement;
                Timing.UnitsOfTime? ak_ = aj_?.Value;
                string al_ = context.Operators.Convert<string>(ak_);
                CqlQuantity am_ = this.Quantity(context, ai_, al_);
                decimal? an_ = this.ToDaily(context, ae_ ?? ag_, am_);
                List<Time> ao_ = ac_?.TimeOfDayElement;

                string ap_(Time @this) {
                    string ax_ = @this?.Value;
                    return ax_;
                }

                IEnumerable<string> aq_ = context.Operators.Select<Time, string>((IEnumerable<Time>)ao_, ap_);

                CqlTime ar_(string @string) {
                    CqlTime ay_ = context.Operators.ConvertStringToTime(@string);
                    return ay_;
                }

                IEnumerable<CqlTime> as_ = context.Operators.Select<string, CqlTime>(aq_, ar_);
                int? at_ = context.Operators.Count<CqlTime>(as_);
                decimal? au_ = context.Operators.ConvertIntegerToDecimal(at_);
                decimal? av_ = context.Operators.Multiply(aa_, (an_ ?? au_) ?? 1.0m);
                decimal? aw_ = context.Operators.Divide(s_, av_);
                l_ = k_ & (!((bool?)((p_ ?? aw_) is null)));
            }
            if (l_ ?? false)
            {
                Quantity az_ = D?.DaysSupply;
                CqlQuantity ba_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, az_);
                CqlQuantity bb_ = context.Operators.ConvertQuantity(ba_, "d");
                decimal? bc_ = bb_?.value;
                Quantity bd_ = D?.Quantity;
                CqlQuantity be_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, bd_);
                decimal? bf_ = be_?.value;
                List<Dosage> bg_ = D?.DosageInstruction;
                Dosage bh_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)bg_);
                List<Dosage.DoseAndRateComponent> bi_ = bh_?.DoseAndRate;
                Dosage.DoseAndRateComponent bj_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)bi_);
                DataType bk_ = bj_?.Dose;
                object bl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bk_);
                CqlQuantity bm_ = context.Operators.End(bl_ as CqlInterval<CqlQuantity>);
                decimal? bn_ = (bm_ ?? bl_ as CqlQuantity)?.value;
                Timing bo_ = bh_?.Timing;
                Timing.RepeatComponent bp_ = bo_?.Repeat;
                PositiveInt bq_ = bp_?.FrequencyMaxElement;
                int? br_ = bq_?.Value;
                PositiveInt bs_ = bp_?.FrequencyElement;
                int? bt_ = bs_?.Value;
                FhirDecimal bu_ = bp_?.PeriodElement;
                decimal? bv_ = bu_?.Value;
                Code<Timing.UnitsOfTime> bw_ = bp_?.PeriodUnitElement;
                Timing.UnitsOfTime? bx_ = bw_?.Value;
                string by_ = context.Operators.Convert<string>(bx_);
                CqlQuantity bz_ = this.Quantity(context, bv_, by_);
                decimal? ca_ = this.ToDaily(context, br_ ?? bt_, bz_);
                List<Time> cb_ = bp_?.TimeOfDayElement;

                string cc_(Time @this) {
                    string cp_ = @this?.Value;
                    return cp_;
                }

                IEnumerable<string> cd_ = context.Operators.Select<Time, string>((IEnumerable<Time>)cb_, cc_);

                CqlTime ce_(string @string) {
                    CqlTime cq_ = context.Operators.ConvertStringToTime(@string);
                    return cq_;
                }

                IEnumerable<CqlTime> cf_ = context.Operators.Select<string, CqlTime>(cd_, ce_);
                int? cg_ = context.Operators.Count<CqlTime>(cf_);
                decimal? ch_ = context.Operators.ConvertIntegerToDecimal(cg_);
                decimal? ci_ = context.Operators.Multiply(bn_, (ca_ ?? ch_) ?? 1.0m);
                decimal? cj_ = context.Operators.Divide(bf_, ci_);
                decimal? ck_ = context.Operators.ConvertIntegerToDecimal(1);
                decimal? cl_ = context.Operators.Subtract(bc_ ?? cj_, ck_);
                CqlQuantity cm_ = this.Quantity(context, cl_, "day");
                CqlDate cn_ = context.Operators.Add(g_ ?? j_, cm_);
                CqlInterval<CqlDate> co_ = context.Operators.Interval(g_ ?? j_, cn_, true, true);
                return co_;
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
            bool? i_ = !((bool?)(h_ is null));
            bool? j_;
            // CQL 'and' (475:10-475:66): right operand skipped when left is false
            if (i_ is false)
            {
                j_ = false;
            }
            else
            {
                DataType k_ = Administration?.Medication;
                object l_ = FHIRHelpers_4_4_000.Instance.ToValue(context, k_);
                CqlQuantity m_ = this.TherapeuticDuration(context, l_ as CqlConcept);
                j_ = i_ & (!((bool?)(m_ is null)));
            }
            if (j_ ?? false)
            {
                DataType n_ = Administration?.Medication;
                object o_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
                CqlQuantity p_ = this.TherapeuticDuration(context, o_ as CqlConcept);
                CqlDate q_ = context.Operators.Add(h_, p_);
                CqlQuantity r_ = context.Operators.ConvertIntegerToQuantity(1);
                CqlDate s_ = context.Operators.Subtract(q_, r_);
                CqlInterval<CqlDate> t_ = context.Operators.Interval(h_, s_, true, true);
                return t_;
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
            bool? i_ = !((bool?)(h_ is null));
            bool? j_;
            // CQL 'and' (503:10-503:66): right operand skipped when left is false
            if (i_ is false)
            {
                j_ = false;
            }
            else
            {
                DataType k_ = Administration?.Medication;
                object l_ = FHIRHelpers_4_4_000.Instance.ToValue(context, k_);
                CqlQuantity m_ = this.TherapeuticDuration(context, l_ as CqlConcept);
                j_ = i_ & (!((bool?)(m_ is null)));
            }
            if (j_ ?? false)
            {
                DataType n_ = Administration?.Medication;
                object o_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
                CqlQuantity p_ = this.TherapeuticDuration(context, o_ as CqlConcept);
                CqlDate q_ = context.Operators.Add(h_, p_);
                CqlQuantity r_ = context.Operators.ConvertIntegerToQuantity(1);
                CqlDate s_ = context.Operators.Subtract(q_, r_);
                CqlInterval<CqlDate> t_ = context.Operators.Interval(h_, s_, true, true);
                return t_;
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
            return l_ as bool?;
        }


        CqlInterval<CqlDate> b_(object M) {
            CqlInterval<CqlDate> m_ = this.MedicationRequestPeriod(context, M as MedicationRequest);
            return m_;
        }

        IEnumerable<CqlInterval<CqlDate>> c_ = context.Operators.WhereSelect<object, CqlInterval<CqlDate>>(Medications, a_, b_);
        IEnumerable<CqlInterval<CqlDate>> d_ = context.Operators.Distinct<CqlInterval<CqlDate>>(c_);

        bool? e_(object M) {
            bool n_ = M is MedicationDispense;
            return n_ as bool?;
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
            return l_ as bool?;
        }


        CqlInterval<CqlDate> b_(object M) {
            CqlInterval<CqlDate> m_ = this.medicationRequestPeriod(context, M as MedicationRequest);
            return m_;
        }

        IEnumerable<CqlInterval<CqlDate>> c_ = context.Operators.WhereSelect<object, CqlInterval<CqlDate>>(Medications, a_, b_);
        IEnumerable<CqlInterval<CqlDate>> d_ = context.Operators.Distinct<CqlInterval<CqlDate>>(c_);

        bool? e_(object M) {
            bool n_ = M is MedicationDispense;
            return n_ as bool?;
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
