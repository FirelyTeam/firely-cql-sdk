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

        decimal? a_() {

            bool b_() {
                string w_ = period?.unit;
                bool? x_ = context.Operators.Equal(w_, "h");
                return x_ ?? false;
            }


            bool c_() {
                string y_ = period?.unit;
                bool? z_ = context.Operators.Equal(y_, "min");
                return z_ ?? false;
            }


            bool d_() {
                string aa_ = period?.unit;
                bool? ab_ = context.Operators.Equal(aa_, "s");
                return ab_ ?? false;
            }


            bool e_() {
                string ac_ = period?.unit;
                bool? ad_ = context.Operators.Equal(ac_, "d");
                return ad_ ?? false;
            }


            bool f_() {
                string ae_ = period?.unit;
                bool? af_ = context.Operators.Equal(ae_, "wk");
                return af_ ?? false;
            }


            bool g_() {
                string ag_ = period?.unit;
                bool? ah_ = context.Operators.Equal(ag_, "mo");
                return ah_ ?? false;
            }


            bool h_() {
                string ai_ = period?.unit;
                bool? aj_ = context.Operators.Equal(ai_, "a");
                return aj_ ?? false;
            }


            bool i_() {
                string ak_ = period?.unit;
                bool? al_ = context.Operators.Equal(ak_, "hour");
                return al_ ?? false;
            }


            bool j_() {
                string am_ = period?.unit;
                bool? an_ = context.Operators.Equal(am_, "minute");
                return an_ ?? false;
            }


            bool k_() {
                string ao_ = period?.unit;
                bool? ap_ = context.Operators.Equal(ao_, "second");
                return ap_ ?? false;
            }


            bool l_() {
                string aq_ = period?.unit;
                bool? ar_ = context.Operators.Equal(aq_, "day");
                return ar_ ?? false;
            }


            bool m_() {
                string as_ = period?.unit;
                bool? at_ = context.Operators.Equal(as_, "week");
                return at_ ?? false;
            }


            bool n_() {
                string au_ = period?.unit;
                bool? av_ = context.Operators.Equal(au_, "month");
                return av_ ?? false;
            }


            bool o_() {
                string aw_ = period?.unit;
                bool? ax_ = context.Operators.Equal(aw_, "year");
                return ax_ ?? false;
            }


            bool p_() {
                string ay_ = period?.unit;
                bool? az_ = context.Operators.Equal(ay_, "hours");
                return az_ ?? false;
            }


            bool q_() {
                string ba_ = period?.unit;
                bool? bb_ = context.Operators.Equal(ba_, "minutes");
                return bb_ ?? false;
            }


            bool r_() {
                string bc_ = period?.unit;
                bool? bd_ = context.Operators.Equal(bc_, "seconds");
                return bd_ ?? false;
            }


            bool s_() {
                string be_ = period?.unit;
                bool? bf_ = context.Operators.Equal(be_, "days");
                return bf_ ?? false;
            }


            bool t_() {
                string bg_ = period?.unit;
                bool? bh_ = context.Operators.Equal(bg_, "weeks");
                return bh_ ?? false;
            }


            bool u_() {
                string bi_ = period?.unit;
                bool? bj_ = context.Operators.Equal(bi_, "months");
                return bj_ ?? false;
            }


            bool v_() {
                string bk_ = period?.unit;
                bool? bl_ = context.Operators.Equal(bk_, "years");
                return bl_ ?? false;
            }

            if (b_())
            {
                decimal? bm_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? bn_ = period?.value;
                decimal? bo_ = context.Operators.Divide(24.0m, bn_);
                decimal? bp_ = context.Operators.Multiply(bm_, bo_);
                return bp_;
            }
            else if (c_())
            {
                decimal? bq_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? br_ = period?.value;
                decimal? bs_ = context.Operators.Divide(24.0m, br_);
                decimal? bt_ = context.Operators.Multiply(bq_, bs_);
                decimal? bu_ = context.Operators.ConvertIntegerToDecimal(60);
                decimal? bv_ = context.Operators.Multiply(bt_, bu_);
                return bv_;
            }
            else if (d_())
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
            else if (e_())
            {
                decimal? cd_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? ce_ = period?.value;
                decimal? cf_ = context.Operators.Divide(24.0m, ce_);
                decimal? cg_ = context.Operators.Multiply(cd_, cf_);
                decimal? ch_ = context.Operators.ConvertIntegerToDecimal(24);
                decimal? ci_ = context.Operators.Divide(cg_, ch_);
                return ci_;
            }
            else if (f_())
            {
                decimal? cj_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? ck_ = period?.value;
                decimal? cl_ = context.Operators.Divide(24.0m, ck_);
                decimal? cm_ = context.Operators.Multiply(cj_, cl_);
                int? cn_ = context.Operators.Multiply(24, 7);
                decimal? co_ = context.Operators.ConvertIntegerToDecimal(cn_);
                decimal? cp_ = context.Operators.Divide(cm_, co_);
                return cp_;
            }
            else if (g_())
            {
                decimal? cq_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? cr_ = period?.value;
                decimal? cs_ = context.Operators.Divide(24.0m, cr_);
                decimal? ct_ = context.Operators.Multiply(cq_, cs_);
                int? cu_ = context.Operators.Multiply(24, 30);
                decimal? cv_ = context.Operators.ConvertIntegerToDecimal(cu_);
                decimal? cw_ = context.Operators.Divide(ct_, cv_);
                return cw_;
            }
            else if (h_())
            {
                decimal? cx_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? cy_ = period?.value;
                decimal? cz_ = context.Operators.Divide(24.0m, cy_);
                decimal? da_ = context.Operators.Multiply(cx_, cz_);
                int? db_ = context.Operators.Multiply(24, 365);
                decimal? dc_ = context.Operators.ConvertIntegerToDecimal(db_);
                decimal? dd_ = context.Operators.Divide(da_, dc_);
                return dd_;
            }
            else if (i_())
            {
                decimal? de_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? df_ = period?.value;
                decimal? dg_ = context.Operators.Divide(24.0m, df_);
                decimal? dh_ = context.Operators.Multiply(de_, dg_);
                return dh_;
            }
            else if (j_())
            {
                decimal? di_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? dj_ = period?.value;
                decimal? dk_ = context.Operators.Divide(24.0m, dj_);
                decimal? dl_ = context.Operators.Multiply(di_, dk_);
                decimal? dm_ = context.Operators.ConvertIntegerToDecimal(60);
                decimal? dn_ = context.Operators.Multiply(dl_, dm_);
                return dn_;
            }
            else if (k_())
            {
                decimal? do_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? dp_ = period?.value;
                decimal? dq_ = context.Operators.Divide(24.0m, dp_);
                decimal? dr_ = context.Operators.Multiply(do_, dq_);
                decimal? ds_ = context.Operators.ConvertIntegerToDecimal(60);
                decimal? dt_ = context.Operators.Multiply(dr_, ds_);
                decimal? du_ = context.Operators.Multiply(dt_, ds_);
                return du_;
            }
            else if (l_())
            {
                decimal? dv_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? dw_ = period?.value;
                decimal? dx_ = context.Operators.Divide(24.0m, dw_);
                decimal? dy_ = context.Operators.Multiply(dv_, dx_);
                decimal? dz_ = context.Operators.ConvertIntegerToDecimal(24);
                decimal? ea_ = context.Operators.Divide(dy_, dz_);
                return ea_;
            }
            else if (m_())
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
            else if (n_())
            {
                decimal? ei_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? ej_ = period?.value;
                decimal? ek_ = context.Operators.Divide(24.0m, ej_);
                decimal? el_ = context.Operators.Multiply(ei_, ek_);
                int? em_ = context.Operators.Multiply(24, 30);
                decimal? en_ = context.Operators.ConvertIntegerToDecimal(em_);
                decimal? eo_ = context.Operators.Divide(el_, en_);
                return eo_;
            }
            else if (o_())
            {
                decimal? ep_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? eq_ = period?.value;
                decimal? er_ = context.Operators.Divide(24.0m, eq_);
                decimal? es_ = context.Operators.Multiply(ep_, er_);
                int? et_ = context.Operators.Multiply(24, 365);
                decimal? eu_ = context.Operators.ConvertIntegerToDecimal(et_);
                decimal? ev_ = context.Operators.Divide(es_, eu_);
                return ev_;
            }
            else if (p_())
            {
                decimal? ew_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? ex_ = period?.value;
                decimal? ey_ = context.Operators.Divide(24.0m, ex_);
                decimal? ez_ = context.Operators.Multiply(ew_, ey_);
                return ez_;
            }
            else if (q_())
            {
                decimal? fa_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? fb_ = period?.value;
                decimal? fc_ = context.Operators.Divide(24.0m, fb_);
                decimal? fd_ = context.Operators.Multiply(fa_, fc_);
                decimal? fe_ = context.Operators.ConvertIntegerToDecimal(60);
                decimal? ff_ = context.Operators.Multiply(fd_, fe_);
                return ff_;
            }
            else if (r_())
            {
                decimal? fg_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? fh_ = period?.value;
                decimal? fi_ = context.Operators.Divide(24.0m, fh_);
                decimal? fj_ = context.Operators.Multiply(fg_, fi_);
                decimal? fk_ = context.Operators.ConvertIntegerToDecimal(60);
                decimal? fl_ = context.Operators.Multiply(fj_, fk_);
                decimal? fm_ = context.Operators.Multiply(fl_, fk_);
                return fm_;
            }
            else if (s_())
            {
                decimal? fn_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? fo_ = period?.value;
                decimal? fp_ = context.Operators.Divide(24.0m, fo_);
                decimal? fq_ = context.Operators.Multiply(fn_, fp_);
                decimal? fr_ = context.Operators.ConvertIntegerToDecimal(24);
                decimal? fs_ = context.Operators.Divide(fq_, fr_);
                return fs_;
            }
            else if (t_())
            {
                decimal? ft_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? fu_ = period?.value;
                decimal? fv_ = context.Operators.Divide(24.0m, fu_);
                decimal? fw_ = context.Operators.Multiply(ft_, fv_);
                int? fx_ = context.Operators.Multiply(24, 7);
                decimal? fy_ = context.Operators.ConvertIntegerToDecimal(fx_);
                decimal? fz_ = context.Operators.Divide(fw_, fy_);
                return fz_;
            }
            else if (u_())
            {
                decimal? ga_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? gb_ = period?.value;
                decimal? gc_ = context.Operators.Divide(24.0m, gb_);
                decimal? gd_ = context.Operators.Multiply(ga_, gc_);
                int? ge_ = context.Operators.Multiply(24, 30);
                decimal? gf_ = context.Operators.ConvertIntegerToDecimal(ge_);
                decimal? gg_ = context.Operators.Divide(gd_, gf_);
                return gg_;
            }
            else if (v_())
            {
                decimal? gh_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? gi_ = period?.value;
                decimal? gj_ = context.Operators.Divide(24.0m, gi_);
                decimal? gk_ = context.Operators.Multiply(gh_, gj_);
                int? gl_ = context.Operators.Multiply(24, 365);
                decimal? gm_ = context.Operators.ConvertIntegerToDecimal(gl_);
                decimal? gn_ = context.Operators.Divide(gk_, gm_);
                return gn_;
            }
            else
            {
                string go_ = this.ErrorLevel(context);
                string gp_ = period?.unit;
                string gq_ = context.Operators.Concatenate("Unknown unit ", gp_ ?? "");
                object gr_ = context.Operators.Message<object>((object)null, "CMDLogic.ToDaily.UnknownUnit", go_, gq_);
                return gr_ as decimal?;
            }
        }

        return a_();
    }


    [CqlFunctionDefinition("ToDaily")]
    public decimal? ToDaily(CqlContext context, CqlCode frequency)
    {

        decimal? a_() {

            bool b_() {
                CqlCode aw_ = this.HS(context);
                bool? ax_ = context.Operators.Equivalent(frequency, aw_);
                return ax_ ?? false;
            }


            bool c_() {
                CqlCode ay_ = this.WAKE(context);
                bool? az_ = context.Operators.Equivalent(frequency, ay_);
                return az_ ?? false;
            }


            bool d_() {
                CqlCode ba_ = this.C(context);
                bool? bb_ = context.Operators.Equivalent(frequency, ba_);
                return bb_ ?? false;
            }


            bool e_() {
                CqlCode bc_ = this.CM(context);
                bool? bd_ = context.Operators.Equivalent(frequency, bc_);
                return bd_ ?? false;
            }


            bool f_() {
                CqlCode be_ = this.CD(context);
                bool? bf_ = context.Operators.Equivalent(frequency, be_);
                return bf_ ?? false;
            }


            bool g_() {
                CqlCode bg_ = this.CV(context);
                bool? bh_ = context.Operators.Equivalent(frequency, bg_);
                return bh_ ?? false;
            }


            bool h_() {
                CqlCode bi_ = this.AC(context);
                bool? bj_ = context.Operators.Equivalent(frequency, bi_);
                return bj_ ?? false;
            }


            bool i_() {
                CqlCode bk_ = this.ACM(context);
                bool? bl_ = context.Operators.Equivalent(frequency, bk_);
                return bl_ ?? false;
            }


            bool j_() {
                CqlCode bm_ = this.ACD(context);
                bool? bn_ = context.Operators.Equivalent(frequency, bm_);
                return bn_ ?? false;
            }


            bool k_() {
                CqlCode bo_ = this.ACV(context);
                bool? bp_ = context.Operators.Equivalent(frequency, bo_);
                return bp_ ?? false;
            }


            bool l_() {
                CqlCode bq_ = this.PC(context);
                bool? br_ = context.Operators.Equivalent(frequency, bq_);
                return br_ ?? false;
            }


            bool m_() {
                CqlCode bs_ = this.PCM(context);
                bool? bt_ = context.Operators.Equivalent(frequency, bs_);
                return bt_ ?? false;
            }


            bool n_() {
                CqlCode bu_ = this.PCD(context);
                bool? bv_ = context.Operators.Equivalent(frequency, bu_);
                return bv_ ?? false;
            }


            bool o_() {
                CqlCode bw_ = this.PCV(context);
                bool? bx_ = context.Operators.Equivalent(frequency, bw_);
                return bx_ ?? false;
            }


            bool p_() {
                CqlCode by_ = this.MORN(context);
                bool? bz_ = context.Operators.Equivalent(frequency, by_);
                return bz_ ?? false;
            }


            bool q_() {
                CqlCode ca_ = this.MORN_early(context);
                bool? cb_ = context.Operators.Equivalent(frequency, ca_);
                return cb_ ?? false;
            }


            bool r_() {
                CqlCode cc_ = this.MORN_late(context);
                bool? cd_ = context.Operators.Equivalent(frequency, cc_);
                return cd_ ?? false;
            }


            bool s_() {
                CqlCode ce_ = this.NOON(context);
                bool? cf_ = context.Operators.Equivalent(frequency, ce_);
                return cf_ ?? false;
            }


            bool t_() {
                CqlCode cg_ = this.AFT(context);
                bool? ch_ = context.Operators.Equivalent(frequency, cg_);
                return ch_ ?? false;
            }


            bool u_() {
                CqlCode ci_ = this.AFT_early(context);
                bool? cj_ = context.Operators.Equivalent(frequency, ci_);
                return cj_ ?? false;
            }


            bool v_() {
                CqlCode ck_ = this.AFT_late(context);
                bool? cl_ = context.Operators.Equivalent(frequency, ck_);
                return cl_ ?? false;
            }


            bool w_() {
                CqlCode cm_ = this.EVE(context);
                bool? cn_ = context.Operators.Equivalent(frequency, cm_);
                return cn_ ?? false;
            }


            bool x_() {
                CqlCode co_ = this.EVE_early(context);
                bool? cp_ = context.Operators.Equivalent(frequency, co_);
                return cp_ ?? false;
            }


            bool y_() {
                CqlCode cq_ = this.EVE_late(context);
                bool? cr_ = context.Operators.Equivalent(frequency, cq_);
                return cr_ ?? false;
            }


            bool z_() {
                CqlCode cs_ = this.NIGHT(context);
                bool? ct_ = context.Operators.Equivalent(frequency, cs_);
                return ct_ ?? false;
            }


            bool aa_() {
                CqlCode cu_ = this.PHS(context);
                bool? cv_ = context.Operators.Equivalent(frequency, cu_);
                return cv_ ?? false;
            }


            bool ab_() {
                CqlCode cw_ = this.Once_daily__qualifier_value_(context);
                bool? cx_ = context.Operators.Equivalent(frequency, cw_);
                return cx_ ?? false;
            }


            bool ac_() {
                CqlCode cy_ = this.Twice_a_day__qualifier_value_(context);
                bool? cz_ = context.Operators.Equivalent(frequency, cy_);
                return cz_ ?? false;
            }


            bool ad_() {
                CqlCode da_ = this.Three_times_daily__qualifier_value_(context);
                bool? db_ = context.Operators.Equivalent(frequency, da_);
                return db_ ?? false;
            }


            bool ae_() {
                CqlCode dc_ = this.Four_times_daily__qualifier_value_(context);
                bool? dd_ = context.Operators.Equivalent(frequency, dc_);
                return dd_ ?? false;
            }


            bool af_() {
                CqlCode de_ = this.Every_twenty_four_hours__qualifier_value_(context);
                bool? df_ = context.Operators.Equivalent(frequency, de_);
                return df_ ?? false;
            }


            bool ag_() {
                CqlCode dg_ = this.Every_twelve_hours__qualifier_value_(context);
                bool? dh_ = context.Operators.Equivalent(frequency, dg_);
                return dh_ ?? false;
            }


            bool ah_() {
                CqlCode di_ = this.Every_thirty_six_hours__qualifier_value_(context);
                bool? dj_ = context.Operators.Equivalent(frequency, di_);
                return dj_ ?? false;
            }


            bool ai_() {
                CqlCode dk_ = this.Every_eight_hours__qualifier_value_(context);
                bool? dl_ = context.Operators.Equivalent(frequency, dk_);
                return dl_ ?? false;
            }


            bool aj_() {
                CqlCode dm_ = this.Every_four_hours__qualifier_value_(context);
                bool? dn_ = context.Operators.Equivalent(frequency, dm_);
                return dn_ ?? false;
            }


            bool ak_() {
                CqlCode do_ = this.Every_six_hours__qualifier_value_(context);
                bool? dp_ = context.Operators.Equivalent(frequency, do_);
                return dp_ ?? false;
            }


            bool al_() {
                CqlCode dq_ = this.Every_seventy_two_hours__qualifier_value_(context);
                bool? dr_ = context.Operators.Equivalent(frequency, dq_);
                return dr_ ?? false;
            }


            bool am_() {
                CqlCode ds_ = this.Every_forty_eight_hours__qualifier_value_(context);
                bool? dt_ = context.Operators.Equivalent(frequency, ds_);
                return dt_ ?? false;
            }


            bool an_() {
                CqlCode du_ = this.Every_eight_to_twelve_hours__qualifier_value_(context);
                bool? dv_ = context.Operators.Equivalent(frequency, du_);
                return dv_ ?? false;
            }


            bool ao_() {
                CqlCode dw_ = this.Every_six_to_eight_hours__qualifier_value_(context);
                bool? dx_ = context.Operators.Equivalent(frequency, dw_);
                return dx_ ?? false;
            }


            bool ap_() {
                CqlCode dy_ = this.Every_three_to_four_hours__qualifier_value_(context);
                bool? dz_ = context.Operators.Equivalent(frequency, dy_);
                return dz_ ?? false;
            }


            bool aq_() {
                CqlCode ea_ = this.Every_three_to_six_hours__qualifier_value_(context);
                bool? eb_ = context.Operators.Equivalent(frequency, ea_);
                return eb_ ?? false;
            }


            bool ar_() {
                CqlCode ec_ = this.Every_two_to_four_hours__qualifier_value_(context);
                bool? ed_ = context.Operators.Equivalent(frequency, ec_);
                return ed_ ?? false;
            }


            bool as_() {
                CqlCode ee_ = this.One_to_four_times_a_day__qualifier_value_(context);
                bool? ef_ = context.Operators.Equivalent(frequency, ee_);
                return ef_ ?? false;
            }


            bool at_() {
                CqlCode eg_ = this.One_to_three_times_a_day__qualifier_value_(context);
                bool? eh_ = context.Operators.Equivalent(frequency, eg_);
                return eh_ ?? false;
            }


            bool au_() {
                CqlCode ei_ = this.One_to_two_times_a_day__qualifier_value_(context);
                bool? ej_ = context.Operators.Equivalent(frequency, ei_);
                return ej_ ?? false;
            }


            bool av_() {
                CqlCode ek_ = this.Two_to_four_times_a_day__qualifier_value_(context);
                bool? el_ = context.Operators.Equivalent(frequency, ek_);
                return el_ ?? false;
            }

            if (b_())
            {
                decimal? em_ = context.Operators.ConvertIntegerToDecimal(1);
                return em_;
            }
            else if (c_())
            {
                decimal? en_ = context.Operators.ConvertIntegerToDecimal(1);
                return en_;
            }
            else if (d_())
            {
                decimal? eo_ = context.Operators.ConvertIntegerToDecimal(3);
                return eo_;
            }
            else if (e_())
            {
                decimal? ep_ = context.Operators.ConvertIntegerToDecimal(1);
                return ep_;
            }
            else if (f_())
            {
                decimal? eq_ = context.Operators.ConvertIntegerToDecimal(1);
                return eq_;
            }
            else if (g_())
            {
                decimal? er_ = context.Operators.ConvertIntegerToDecimal(1);
                return er_;
            }
            else if (h_())
            {
                decimal? es_ = context.Operators.ConvertIntegerToDecimal(3);
                return es_;
            }
            else if (i_())
            {
                decimal? et_ = context.Operators.ConvertIntegerToDecimal(1);
                return et_;
            }
            else if (j_())
            {
                decimal? eu_ = context.Operators.ConvertIntegerToDecimal(1);
                return eu_;
            }
            else if (k_())
            {
                decimal? ev_ = context.Operators.ConvertIntegerToDecimal(1);
                return ev_;
            }
            else if (l_())
            {
                decimal? ew_ = context.Operators.ConvertIntegerToDecimal(3);
                return ew_;
            }
            else if (m_())
            {
                decimal? ex_ = context.Operators.ConvertIntegerToDecimal(1);
                return ex_;
            }
            else if (n_())
            {
                decimal? ey_ = context.Operators.ConvertIntegerToDecimal(1);
                return ey_;
            }
            else if (o_())
            {
                decimal? ez_ = context.Operators.ConvertIntegerToDecimal(1);
                return ez_;
            }
            else if (p_())
            {
                decimal? fa_ = context.Operators.ConvertIntegerToDecimal(1);
                return fa_;
            }
            else if (q_())
            {
                decimal? fb_ = context.Operators.ConvertIntegerToDecimal(1);
                return fb_;
            }
            else if (r_())
            {
                decimal? fc_ = context.Operators.ConvertIntegerToDecimal(1);
                return fc_;
            }
            else if (s_())
            {
                decimal? fd_ = context.Operators.ConvertIntegerToDecimal(1);
                return fd_;
            }
            else if (t_())
            {
                decimal? fe_ = context.Operators.ConvertIntegerToDecimal(1);
                return fe_;
            }
            else if (u_())
            {
                decimal? ff_ = context.Operators.ConvertIntegerToDecimal(1);
                return ff_;
            }
            else if (v_())
            {
                decimal? fg_ = context.Operators.ConvertIntegerToDecimal(1);
                return fg_;
            }
            else if (w_())
            {
                decimal? fh_ = context.Operators.ConvertIntegerToDecimal(1);
                return fh_;
            }
            else if (x_())
            {
                decimal? fi_ = context.Operators.ConvertIntegerToDecimal(1);
                return fi_;
            }
            else if (y_())
            {
                decimal? fj_ = context.Operators.ConvertIntegerToDecimal(1);
                return fj_;
            }
            else if (z_())
            {
                decimal? fk_ = context.Operators.ConvertIntegerToDecimal(1);
                return fk_;
            }
            else if (aa_())
            {
                decimal? fl_ = context.Operators.ConvertIntegerToDecimal(1);
                return fl_;
            }
            else if (ab_())
            {
                return 1.0m;
            }
            else if (ac_())
            {
                return 2.0m;
            }
            else if (ad_())
            {
                return 3.0m;
            }
            else if (ae_())
            {
                return 4.0m;
            }
            else if (af_())
            {
                return 1.0m;
            }
            else if (ag_())
            {
                return 2.0m;
            }
            else if (ah_())
            {
                return 0.67m;
            }
            else if (ai_())
            {
                return 3.0m;
            }
            else if (aj_())
            {
                return 6.0m;
            }
            else if (ak_())
            {
                return 4.0m;
            }
            else if (al_())
            {
                return 0.33m;
            }
            else if (am_())
            {
                return 0.5m;
            }
            else if (an_())
            {
                return 3.0m;
            }
            else if (ao_())
            {
                return 4.0m;
            }
            else if (ap_())
            {
                return 8.0m;
            }
            else if (aq_())
            {
                return 8.0m;
            }
            else if (ar_())
            {
                return 12.0m;
            }
            else if (as_())
            {
                return 4.0m;
            }
            else if (at_())
            {
                return 3.0m;
            }
            else if (au_())
            {
                return 2.0m;
            }
            else if (av_())
            {
                return 4.0m;
            }
            else
            {
                string fm_ = this.ErrorLevel(context);
                string fn_ = frequency?.code;
                string fo_ = context.Operators.Concatenate("Unknown frequency code ", fn_ ?? "");
                object fp_ = context.Operators.Message<object>((object)null, "CMDLogic.ToDaily.UnknownFrequencyCode", fm_, fo_);
                return fp_ as decimal?;
            }
        }

        return a_();
    }


    [CqlFunctionDefinition("MedicationRequestPeriod")]
    public CqlInterval<CqlDate> MedicationRequestPeriod(CqlContext context, MedicationRequest Request)
    {
        MedicationRequest[] a_ = [
            Request,
        ];

        CqlInterval<CqlDate> b_(MedicationRequest R) {

            CqlInterval<CqlDate> f_() {

                bool g_() {
                    List<Dosage> i_ = R?.DosageInstruction;
                    Dosage j_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)i_);
                    Timing k_ = j_?.Timing;
                    Timing.RepeatComponent l_ = k_?.Repeat;
                    DataType m_ = l_?.Bounds;
                    object n_ = FHIRHelpers_4_4_000.Instance.ToValue(context, m_);
                    CqlDateTime o_ = context.Operators.Start(n_ as CqlInterval<CqlDateTime>);
                    CqlDate p_ = context.Operators.DateFrom(o_);
                    FhirDateTime q_ = R?.AuthoredOnElement;
                    CqlDateTime r_ = context.Operators.Convert<CqlDateTime>(q_);
                    CqlDate s_ = context.Operators.DateFrom(r_);
                    MedicationRequest.DispenseRequestComponent t_ = R?.DispenseRequest;
                    Period u_ = t_?.ValidityPeriod;
                    CqlInterval<CqlDateTime> v_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, u_);
                    CqlDateTime w_ = context.Operators.Start(v_);
                    CqlDate x_ = context.Operators.DateFrom(w_);
                    bool? y_ = context.Operators.Not((bool?)(((p_ ?? s_) ?? x_) is null));
                    Duration z_ = t_?.ExpectedSupplyDuration;
                    CqlQuantity aa_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, z_);
                    CqlQuantity ab_ = context.Operators.ConvertQuantity(aa_, "d");
                    decimal? ac_ = ab_?.value;
                    Quantity ad_ = t_?.Quantity;
                    CqlQuantity ae_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, ad_);
                    decimal? af_ = ae_?.value;
                    List<Dosage.DoseAndRateComponent> ag_ = j_?.DoseAndRate;
                    Dosage.DoseAndRateComponent ah_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)ag_);
                    DataType ai_ = ah_?.Dose;
                    object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                    CqlQuantity ak_ = context.Operators.End(aj_ as CqlInterval<CqlQuantity>);
                    decimal? al_ = (ak_ ?? aj_ as CqlQuantity)?.value;
                    PositiveInt am_ = l_?.FrequencyMaxElement;
                    int? an_ = am_?.Value;
                    PositiveInt ao_ = l_?.FrequencyElement;
                    int? ap_ = ao_?.Value;
                    FhirDecimal aq_ = l_?.PeriodElement;
                    decimal? ar_ = aq_?.Value;
                    Code<Timing.UnitsOfTime> as_ = l_?.PeriodUnitElement;
                    Timing.UnitsOfTime? at_ = as_?.Value;
                    string au_ = context.Operators.Convert<string>(at_);
                    CqlQuantity av_ = this.Quantity(context, ar_, au_);
                    decimal? aw_ = this.ToDaily(context, an_ ?? ap_, av_);
                    List<Time> ax_ = l_?.TimeOfDayElement;

                    string ay_(Time @this) {
                        string bn_ = @this?.Value;
                        return bn_;
                    }

                    IEnumerable<string> az_ = context.Operators.Select<Time, string>((IEnumerable<Time>)ax_, ay_);

                    CqlTime ba_(string @string) {
                        CqlTime bo_ = context.Operators.ConvertStringToTime(@string);
                        return bo_;
                    }

                    IEnumerable<CqlTime> bb_ = context.Operators.Select<string, CqlTime>(az_, ba_);
                    int? bc_ = context.Operators.Count<CqlTime>(bb_);
                    decimal? bd_ = context.Operators.ConvertIntegerToDecimal(bc_);
                    decimal? be_ = context.Operators.Multiply(al_, (aw_ ?? bd_) ?? 1.0m);
                    decimal? bf_ = context.Operators.Divide(af_, be_);
                    UnsignedInt bg_ = t_?.NumberOfRepeatsAllowedElement;
                    int? bh_ = bg_?.Value;
                    int? bi_ = context.Operators.Add(1, bh_ ?? 0);
                    decimal? bj_ = context.Operators.ConvertIntegerToDecimal(bi_);
                    decimal? bk_ = context.Operators.Multiply(ac_ ?? bf_, bj_);
                    bool? bl_ = context.Operators.Not((bool?)(bk_ is null));
                    bool? bm_ = context.Operators.And(y_, bl_);
                    return bm_ ?? false;
                }


                bool h_() {
                    List<Dosage> bp_ = R?.DosageInstruction;
                    Dosage bq_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)bp_);
                    Timing br_ = bq_?.Timing;
                    Timing.RepeatComponent bs_ = br_?.Repeat;
                    DataType bt_ = bs_?.Bounds;
                    object bu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bt_);
                    CqlDateTime bv_ = context.Operators.Start(bu_ as CqlInterval<CqlDateTime>);
                    CqlDate bw_ = context.Operators.DateFrom(bv_);
                    FhirDateTime bx_ = R?.AuthoredOnElement;
                    CqlDateTime by_ = context.Operators.Convert<CqlDateTime>(bx_);
                    CqlDate bz_ = context.Operators.DateFrom(by_);
                    MedicationRequest.DispenseRequestComponent ca_ = R?.DispenseRequest;
                    Period cb_ = ca_?.ValidityPeriod;
                    CqlInterval<CqlDateTime> cc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cb_);
                    CqlDateTime cd_ = context.Operators.Start(cc_);
                    CqlDate ce_ = context.Operators.DateFrom(cd_);
                    bool? cf_ = context.Operators.Not((bool?)(((bw_ ?? bz_) ?? ce_) is null));
                    CqlDateTime cg_ = (bu_ as CqlInterval<CqlDateTime>)?.high;
                    bool? ch_ = context.Operators.Not((bool?)(cg_ is null));
                    bool? ci_ = context.Operators.And(cf_, ch_);
                    return ci_ ?? false;
                }

                if (g_())
                {
                    List<Dosage> cj_ = R?.DosageInstruction;
                    Dosage ck_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)cj_);
                    Timing cl_ = ck_?.Timing;
                    Timing.RepeatComponent cm_ = cl_?.Repeat;
                    DataType cn_ = cm_?.Bounds;
                    object co_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cn_);
                    CqlDateTime cp_ = context.Operators.Start(co_ as CqlInterval<CqlDateTime>);
                    CqlDate cq_ = context.Operators.DateFrom(cp_);
                    FhirDateTime cr_ = R?.AuthoredOnElement;
                    CqlDateTime cs_ = context.Operators.Convert<CqlDateTime>(cr_);
                    CqlDate ct_ = context.Operators.DateFrom(cs_);
                    MedicationRequest.DispenseRequestComponent cu_ = R?.DispenseRequest;
                    Period cv_ = cu_?.ValidityPeriod;
                    CqlInterval<CqlDateTime> cw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cv_);
                    CqlDateTime cx_ = context.Operators.Start(cw_);
                    CqlDate cy_ = context.Operators.DateFrom(cx_);
                    Duration cz_ = cu_?.ExpectedSupplyDuration;
                    CqlQuantity da_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, cz_);
                    CqlQuantity db_ = context.Operators.ConvertQuantity(da_, "d");
                    decimal? dc_ = db_?.value;
                    Quantity dd_ = cu_?.Quantity;
                    CqlQuantity de_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, dd_);
                    decimal? df_ = de_?.value;
                    List<Dosage.DoseAndRateComponent> dg_ = ck_?.DoseAndRate;
                    Dosage.DoseAndRateComponent dh_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)dg_);
                    DataType di_ = dh_?.Dose;
                    object dj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, di_);
                    CqlQuantity dk_ = context.Operators.End(dj_ as CqlInterval<CqlQuantity>);
                    decimal? dl_ = (dk_ ?? dj_ as CqlQuantity)?.value;
                    PositiveInt dm_ = cm_?.FrequencyMaxElement;
                    int? dn_ = dm_?.Value;
                    PositiveInt do_ = cm_?.FrequencyElement;
                    int? dp_ = do_?.Value;
                    FhirDecimal dq_ = cm_?.PeriodElement;
                    decimal? dr_ = dq_?.Value;
                    Code<Timing.UnitsOfTime> ds_ = cm_?.PeriodUnitElement;
                    Timing.UnitsOfTime? dt_ = ds_?.Value;
                    string du_ = context.Operators.Convert<string>(dt_);
                    CqlQuantity dv_ = this.Quantity(context, dr_, du_);
                    decimal? dw_ = this.ToDaily(context, dn_ ?? dp_, dv_);
                    List<Time> dx_ = cm_?.TimeOfDayElement;

                    string dy_(Time @this) {
                        string eq_ = @this?.Value;
                        return eq_;
                    }

                    IEnumerable<string> dz_ = context.Operators.Select<Time, string>((IEnumerable<Time>)dx_, dy_);

                    CqlTime ea_(string @string) {
                        CqlTime er_ = context.Operators.ConvertStringToTime(@string);
                        return er_;
                    }

                    IEnumerable<CqlTime> eb_ = context.Operators.Select<string, CqlTime>(dz_, ea_);
                    int? ec_ = context.Operators.Count<CqlTime>(eb_);
                    decimal? ed_ = context.Operators.ConvertIntegerToDecimal(ec_);
                    decimal? ee_ = context.Operators.Multiply(dl_, (dw_ ?? ed_) ?? 1.0m);
                    decimal? ef_ = context.Operators.Divide(df_, ee_);
                    UnsignedInt eg_ = cu_?.NumberOfRepeatsAllowedElement;
                    int? eh_ = eg_?.Value;
                    int? ei_ = context.Operators.Add(1, eh_ ?? 0);
                    decimal? ej_ = context.Operators.ConvertIntegerToDecimal(ei_);
                    decimal? ek_ = context.Operators.Multiply(dc_ ?? ef_, ej_);
                    decimal? el_ = context.Operators.ConvertIntegerToDecimal(1);
                    decimal? em_ = context.Operators.Subtract(ek_, el_);
                    CqlQuantity en_ = this.Quantity(context, em_, "day");
                    CqlDate eo_ = context.Operators.Add((cq_ ?? ct_) ?? cy_, en_);
                    CqlInterval<CqlDate> ep_ = context.Operators.Interval((cq_ ?? ct_) ?? cy_, eo_, true, true);
                    return ep_;
                }
                else if (h_())
                {
                    List<Dosage> es_ = R?.DosageInstruction;
                    Dosage et_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)es_);
                    Timing eu_ = et_?.Timing;
                    Timing.RepeatComponent ev_ = eu_?.Repeat;
                    DataType ew_ = ev_?.Bounds;
                    object ex_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ew_);
                    CqlDateTime ey_ = context.Operators.Start(ex_ as CqlInterval<CqlDateTime>);
                    CqlDate ez_ = context.Operators.DateFrom(ey_);
                    FhirDateTime fa_ = R?.AuthoredOnElement;
                    CqlDateTime fb_ = context.Operators.Convert<CqlDateTime>(fa_);
                    CqlDate fc_ = context.Operators.DateFrom(fb_);
                    MedicationRequest.DispenseRequestComponent fd_ = R?.DispenseRequest;
                    Period fe_ = fd_?.ValidityPeriod;
                    CqlInterval<CqlDateTime> ff_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fe_);
                    CqlDateTime fg_ = context.Operators.Start(ff_);
                    CqlDate fh_ = context.Operators.DateFrom(fg_);
                    CqlDateTime fi_ = context.Operators.End(ex_ as CqlInterval<CqlDateTime>);
                    CqlDate fj_ = context.Operators.DateFrom(fi_);
                    CqlInterval<CqlDate> fk_ = context.Operators.Interval((ez_ ?? fc_) ?? fh_, fj_, true, true);
                    return fk_;
                }
                else
                {
                    return null as CqlInterval<CqlDate>;
                }
            }

            return f_();
        }

        IEnumerable<CqlInterval<CqlDate>> c_ = context.Operators.Select<MedicationRequest, CqlInterval<CqlDate>>((IEnumerable<MedicationRequest>)a_, b_);
        IEnumerable<CqlInterval<CqlDate>> d_ = context.Operators.Distinct<CqlInterval<CqlDate>>(c_);
        CqlInterval<CqlDate> e_ = context.Operators.SingletonFrom<CqlInterval<CqlDate>>(d_);
        return e_;
    }


    [CqlFunctionDefinition("Quantity")]
    public CqlQuantity Quantity(CqlContext context, decimal? value, string unit) =>
    ((context.Operators.Not((bool?)(value is null))) ?? false
        ? new CqlQuantity(value, unit)
        : default);


    [CqlFunctionDefinition("medicationRequestPeriod")]
    public CqlInterval<CqlDate> medicationRequestPeriod(CqlContext context, MedicationRequest Request)
    {
        MedicationRequest[] a_ = [
            Request,
        ];

        CqlInterval<CqlDate> b_(MedicationRequest R) {

            CqlInterval<CqlDate> f_() {

                bool g_() {
                    List<Dosage> i_ = R?.DosageInstruction;
                    Dosage j_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)i_);
                    Timing k_ = j_?.Timing;
                    Timing.RepeatComponent l_ = k_?.Repeat;
                    DataType m_ = l_?.Bounds;
                    object n_ = FHIRHelpers_4_4_000.Instance.ToValue(context, m_);
                    CqlDateTime o_ = context.Operators.Start(n_ as CqlInterval<CqlDateTime>);
                    CqlDate p_ = context.Operators.DateFrom(o_);
                    FhirDateTime q_ = R?.AuthoredOnElement;
                    CqlDateTime r_ = context.Operators.Convert<CqlDateTime>(q_);
                    CqlDate s_ = context.Operators.DateFrom(r_);
                    MedicationRequest.DispenseRequestComponent t_ = R?.DispenseRequest;
                    Period u_ = t_?.ValidityPeriod;
                    CqlInterval<CqlDateTime> v_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, u_);
                    CqlDateTime w_ = context.Operators.Start(v_);
                    CqlDate x_ = context.Operators.DateFrom(w_);
                    bool? y_ = context.Operators.Not((bool?)(((p_ ?? s_) ?? x_) is null));
                    Duration z_ = t_?.ExpectedSupplyDuration;
                    CqlQuantity aa_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, z_);
                    CqlQuantity ab_ = context.Operators.ConvertQuantity(aa_, "d");
                    decimal? ac_ = ab_?.value;
                    Quantity ad_ = t_?.Quantity;
                    CqlQuantity ae_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, ad_);
                    decimal? af_ = ae_?.value;
                    List<Dosage.DoseAndRateComponent> ag_ = j_?.DoseAndRate;
                    Dosage.DoseAndRateComponent ah_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)ag_);
                    DataType ai_ = ah_?.Dose;
                    object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                    CqlQuantity ak_ = context.Operators.End(aj_ as CqlInterval<CqlQuantity>);
                    decimal? al_ = (ak_ ?? aj_ as CqlQuantity)?.value;
                    PositiveInt am_ = l_?.FrequencyMaxElement;
                    int? an_ = am_?.Value;
                    PositiveInt ao_ = l_?.FrequencyElement;
                    int? ap_ = ao_?.Value;
                    FhirDecimal aq_ = l_?.PeriodElement;
                    decimal? ar_ = aq_?.Value;
                    Code<Timing.UnitsOfTime> as_ = l_?.PeriodUnitElement;
                    Timing.UnitsOfTime? at_ = as_?.Value;
                    string au_ = context.Operators.Convert<string>(at_);
                    CqlQuantity av_ = this.Quantity(context, ar_, au_);
                    decimal? aw_ = this.ToDaily(context, an_ ?? ap_, av_);
                    List<Time> ax_ = l_?.TimeOfDayElement;

                    string ay_(Time @this) {
                        string bn_ = @this?.Value;
                        return bn_;
                    }

                    IEnumerable<string> az_ = context.Operators.Select<Time, string>((IEnumerable<Time>)ax_, ay_);

                    CqlTime ba_(string @string) {
                        CqlTime bo_ = context.Operators.ConvertStringToTime(@string);
                        return bo_;
                    }

                    IEnumerable<CqlTime> bb_ = context.Operators.Select<string, CqlTime>(az_, ba_);
                    int? bc_ = context.Operators.Count<CqlTime>(bb_);
                    decimal? bd_ = context.Operators.ConvertIntegerToDecimal(bc_);
                    decimal? be_ = context.Operators.Multiply(al_, (aw_ ?? bd_) ?? 1.0m);
                    decimal? bf_ = context.Operators.Divide(af_, be_);
                    UnsignedInt bg_ = t_?.NumberOfRepeatsAllowedElement;
                    int? bh_ = bg_?.Value;
                    int? bi_ = context.Operators.Add(1, bh_ ?? 0);
                    decimal? bj_ = context.Operators.ConvertIntegerToDecimal(bi_);
                    decimal? bk_ = context.Operators.Multiply(ac_ ?? bf_, bj_);
                    bool? bl_ = context.Operators.Not((bool?)(bk_ is null));
                    bool? bm_ = context.Operators.And(y_, bl_);
                    return bm_ ?? false;
                }


                bool h_() {
                    List<Dosage> bp_ = R?.DosageInstruction;
                    Dosage bq_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)bp_);
                    Timing br_ = bq_?.Timing;
                    Timing.RepeatComponent bs_ = br_?.Repeat;
                    DataType bt_ = bs_?.Bounds;
                    object bu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bt_);
                    CqlDateTime bv_ = context.Operators.Start(bu_ as CqlInterval<CqlDateTime>);
                    CqlDate bw_ = context.Operators.DateFrom(bv_);
                    FhirDateTime bx_ = R?.AuthoredOnElement;
                    CqlDateTime by_ = context.Operators.Convert<CqlDateTime>(bx_);
                    CqlDate bz_ = context.Operators.DateFrom(by_);
                    MedicationRequest.DispenseRequestComponent ca_ = R?.DispenseRequest;
                    Period cb_ = ca_?.ValidityPeriod;
                    CqlInterval<CqlDateTime> cc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cb_);
                    CqlDateTime cd_ = context.Operators.Start(cc_);
                    CqlDate ce_ = context.Operators.DateFrom(cd_);
                    bool? cf_ = context.Operators.Not((bool?)(((bw_ ?? bz_) ?? ce_) is null));
                    CqlDateTime cg_ = (bu_ as CqlInterval<CqlDateTime>)?.high;
                    bool? ch_ = context.Operators.Not((bool?)(cg_ is null));
                    bool? ci_ = context.Operators.And(cf_, ch_);
                    return ci_ ?? false;
                }

                if (g_())
                {
                    List<Dosage> cj_ = R?.DosageInstruction;
                    Dosage ck_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)cj_);
                    Timing cl_ = ck_?.Timing;
                    Timing.RepeatComponent cm_ = cl_?.Repeat;
                    DataType cn_ = cm_?.Bounds;
                    object co_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cn_);
                    CqlDateTime cp_ = context.Operators.Start(co_ as CqlInterval<CqlDateTime>);
                    CqlDate cq_ = context.Operators.DateFrom(cp_);
                    FhirDateTime cr_ = R?.AuthoredOnElement;
                    CqlDateTime cs_ = context.Operators.Convert<CqlDateTime>(cr_);
                    CqlDate ct_ = context.Operators.DateFrom(cs_);
                    MedicationRequest.DispenseRequestComponent cu_ = R?.DispenseRequest;
                    Period cv_ = cu_?.ValidityPeriod;
                    CqlInterval<CqlDateTime> cw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cv_);
                    CqlDateTime cx_ = context.Operators.Start(cw_);
                    CqlDate cy_ = context.Operators.DateFrom(cx_);
                    Duration cz_ = cu_?.ExpectedSupplyDuration;
                    CqlQuantity da_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, cz_);
                    CqlQuantity db_ = context.Operators.ConvertQuantity(da_, "d");
                    decimal? dc_ = db_?.value;
                    Quantity dd_ = cu_?.Quantity;
                    CqlQuantity de_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, dd_);
                    decimal? df_ = de_?.value;
                    List<Dosage.DoseAndRateComponent> dg_ = ck_?.DoseAndRate;
                    Dosage.DoseAndRateComponent dh_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)dg_);
                    DataType di_ = dh_?.Dose;
                    object dj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, di_);
                    CqlQuantity dk_ = context.Operators.End(dj_ as CqlInterval<CqlQuantity>);
                    decimal? dl_ = (dk_ ?? dj_ as CqlQuantity)?.value;
                    PositiveInt dm_ = cm_?.FrequencyMaxElement;
                    int? dn_ = dm_?.Value;
                    PositiveInt do_ = cm_?.FrequencyElement;
                    int? dp_ = do_?.Value;
                    FhirDecimal dq_ = cm_?.PeriodElement;
                    decimal? dr_ = dq_?.Value;
                    Code<Timing.UnitsOfTime> ds_ = cm_?.PeriodUnitElement;
                    Timing.UnitsOfTime? dt_ = ds_?.Value;
                    string du_ = context.Operators.Convert<string>(dt_);
                    CqlQuantity dv_ = this.Quantity(context, dr_, du_);
                    decimal? dw_ = this.ToDaily(context, dn_ ?? dp_, dv_);
                    List<Time> dx_ = cm_?.TimeOfDayElement;

                    string dy_(Time @this) {
                        string eq_ = @this?.Value;
                        return eq_;
                    }

                    IEnumerable<string> dz_ = context.Operators.Select<Time, string>((IEnumerable<Time>)dx_, dy_);

                    CqlTime ea_(string @string) {
                        CqlTime er_ = context.Operators.ConvertStringToTime(@string);
                        return er_;
                    }

                    IEnumerable<CqlTime> eb_ = context.Operators.Select<string, CqlTime>(dz_, ea_);
                    int? ec_ = context.Operators.Count<CqlTime>(eb_);
                    decimal? ed_ = context.Operators.ConvertIntegerToDecimal(ec_);
                    decimal? ee_ = context.Operators.Multiply(dl_, (dw_ ?? ed_) ?? 1.0m);
                    decimal? ef_ = context.Operators.Divide(df_, ee_);
                    UnsignedInt eg_ = cu_?.NumberOfRepeatsAllowedElement;
                    int? eh_ = eg_?.Value;
                    int? ei_ = context.Operators.Add(1, eh_ ?? 0);
                    decimal? ej_ = context.Operators.ConvertIntegerToDecimal(ei_);
                    decimal? ek_ = context.Operators.Multiply(dc_ ?? ef_, ej_);
                    decimal? el_ = context.Operators.ConvertIntegerToDecimal(1);
                    decimal? em_ = context.Operators.Subtract(ek_, el_);
                    CqlQuantity en_ = this.Quantity(context, em_, "day");
                    CqlDate eo_ = context.Operators.Add((cq_ ?? ct_) ?? cy_, en_);
                    CqlInterval<CqlDate> ep_ = context.Operators.Interval((cq_ ?? ct_) ?? cy_, eo_, true, true);
                    return ep_;
                }
                else if (h_())
                {
                    List<Dosage> es_ = R?.DosageInstruction;
                    Dosage et_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)es_);
                    Timing eu_ = et_?.Timing;
                    Timing.RepeatComponent ev_ = eu_?.Repeat;
                    DataType ew_ = ev_?.Bounds;
                    object ex_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ew_);
                    CqlDateTime ey_ = context.Operators.Start(ex_ as CqlInterval<CqlDateTime>);
                    CqlDate ez_ = context.Operators.DateFrom(ey_);
                    FhirDateTime fa_ = R?.AuthoredOnElement;
                    CqlDateTime fb_ = context.Operators.Convert<CqlDateTime>(fa_);
                    CqlDate fc_ = context.Operators.DateFrom(fb_);
                    MedicationRequest.DispenseRequestComponent fd_ = R?.DispenseRequest;
                    Period fe_ = fd_?.ValidityPeriod;
                    CqlInterval<CqlDateTime> ff_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fe_);
                    CqlDateTime fg_ = context.Operators.Start(ff_);
                    CqlDate fh_ = context.Operators.DateFrom(fg_);
                    CqlDateTime fi_ = context.Operators.End(ex_ as CqlInterval<CqlDateTime>);
                    CqlDate fj_ = context.Operators.DateFrom(fi_);
                    CqlInterval<CqlDate> fk_ = context.Operators.Interval((ez_ ?? fc_) ?? fh_, fj_, true, true);
                    return fk_;
                }
                else
                {
                    return null as CqlInterval<CqlDate>;
                }
            }

            return f_();
        }

        IEnumerable<CqlInterval<CqlDate>> c_ = context.Operators.Select<MedicationRequest, CqlInterval<CqlDate>>((IEnumerable<MedicationRequest>)a_, b_);
        IEnumerable<CqlInterval<CqlDate>> d_ = context.Operators.Distinct<CqlInterval<CqlDate>>(c_);
        CqlInterval<CqlDate> e_ = context.Operators.SingletonFrom<CqlInterval<CqlDate>>(d_);
        return e_;
    }


    [CqlFunctionDefinition("MedicationDispensePeriod")]
    public CqlInterval<CqlDate> MedicationDispensePeriod(CqlContext context, MedicationDispense Dispense)
    {
        MedicationDispense[] a_ = [
            Dispense,
        ];

        CqlInterval<CqlDate> b_(MedicationDispense D) {

            CqlInterval<CqlDate> f_() {

                bool g_() {
                    FhirDateTime h_ = D?.WhenHandedOverElement;
                    CqlDateTime i_ = context.Operators.Convert<CqlDateTime>(h_);
                    CqlDate j_ = context.Operators.DateFrom(i_);
                    FhirDateTime k_ = D?.WhenPreparedElement;
                    CqlDateTime l_ = context.Operators.Convert<CqlDateTime>(k_);
                    CqlDate m_ = context.Operators.DateFrom(l_);
                    bool? n_ = context.Operators.Not((bool?)((j_ ?? m_) is null));
                    Quantity o_ = D?.DaysSupply;
                    CqlQuantity p_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, o_);
                    CqlQuantity q_ = context.Operators.ConvertQuantity(p_, "d");
                    decimal? r_ = q_?.value;
                    Quantity s_ = D?.Quantity;
                    CqlQuantity t_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, s_);
                    decimal? u_ = t_?.value;
                    List<Dosage> v_ = D?.DosageInstruction;
                    Dosage w_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)v_);
                    List<Dosage.DoseAndRateComponent> x_ = w_?.DoseAndRate;
                    Dosage.DoseAndRateComponent y_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)x_);
                    DataType z_ = y_?.Dose;
                    object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
                    CqlQuantity ab_ = context.Operators.End(aa_ as CqlInterval<CqlQuantity>);
                    decimal? ac_ = (ab_ ?? aa_ as CqlQuantity)?.value;
                    Timing ad_ = w_?.Timing;
                    Timing.RepeatComponent ae_ = ad_?.Repeat;
                    PositiveInt af_ = ae_?.FrequencyMaxElement;
                    int? ag_ = af_?.Value;
                    PositiveInt ah_ = ae_?.FrequencyElement;
                    int? ai_ = ah_?.Value;
                    FhirDecimal aj_ = ae_?.PeriodElement;
                    decimal? ak_ = aj_?.Value;
                    Code<Timing.UnitsOfTime> al_ = ae_?.PeriodUnitElement;
                    Timing.UnitsOfTime? am_ = al_?.Value;
                    string an_ = context.Operators.Convert<string>(am_);
                    CqlQuantity ao_ = this.Quantity(context, ak_, an_);
                    decimal? ap_ = this.ToDaily(context, ag_ ?? ai_, ao_);
                    List<Time> aq_ = ae_?.TimeOfDayElement;

                    string ar_(Time @this) {
                        string bb_ = @this?.Value;
                        return bb_;
                    }

                    IEnumerable<string> as_ = context.Operators.Select<Time, string>((IEnumerable<Time>)aq_, ar_);

                    CqlTime at_(string @string) {
                        CqlTime bc_ = context.Operators.ConvertStringToTime(@string);
                        return bc_;
                    }

                    IEnumerable<CqlTime> au_ = context.Operators.Select<string, CqlTime>(as_, at_);
                    int? av_ = context.Operators.Count<CqlTime>(au_);
                    decimal? aw_ = context.Operators.ConvertIntegerToDecimal(av_);
                    decimal? ax_ = context.Operators.Multiply(ac_, (ap_ ?? aw_) ?? 1.0m);
                    decimal? ay_ = context.Operators.Divide(u_, ax_);
                    bool? az_ = context.Operators.Not((bool?)((r_ ?? ay_) is null));
                    bool? ba_ = context.Operators.And(n_, az_);
                    return ba_ ?? false;
                }

                if (g_())
                {
                    FhirDateTime bd_ = D?.WhenHandedOverElement;
                    CqlDateTime be_ = context.Operators.Convert<CqlDateTime>(bd_);
                    CqlDate bf_ = context.Operators.DateFrom(be_);
                    FhirDateTime bg_ = D?.WhenPreparedElement;
                    CqlDateTime bh_ = context.Operators.Convert<CqlDateTime>(bg_);
                    CqlDate bi_ = context.Operators.DateFrom(bh_);
                    Quantity bj_ = D?.DaysSupply;
                    CqlQuantity bk_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, bj_);
                    CqlQuantity bl_ = context.Operators.ConvertQuantity(bk_, "d");
                    decimal? bm_ = bl_?.value;
                    Quantity bn_ = D?.Quantity;
                    CqlQuantity bo_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, bn_);
                    decimal? bp_ = bo_?.value;
                    List<Dosage> bq_ = D?.DosageInstruction;
                    Dosage br_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)bq_);
                    List<Dosage.DoseAndRateComponent> bs_ = br_?.DoseAndRate;
                    Dosage.DoseAndRateComponent bt_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)bs_);
                    DataType bu_ = bt_?.Dose;
                    object bv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bu_);
                    CqlQuantity bw_ = context.Operators.End(bv_ as CqlInterval<CqlQuantity>);
                    decimal? bx_ = (bw_ ?? bv_ as CqlQuantity)?.value;
                    Timing by_ = br_?.Timing;
                    Timing.RepeatComponent bz_ = by_?.Repeat;
                    PositiveInt ca_ = bz_?.FrequencyMaxElement;
                    int? cb_ = ca_?.Value;
                    PositiveInt cc_ = bz_?.FrequencyElement;
                    int? cd_ = cc_?.Value;
                    FhirDecimal ce_ = bz_?.PeriodElement;
                    decimal? cf_ = ce_?.Value;
                    Code<Timing.UnitsOfTime> cg_ = bz_?.PeriodUnitElement;
                    Timing.UnitsOfTime? ch_ = cg_?.Value;
                    string ci_ = context.Operators.Convert<string>(ch_);
                    CqlQuantity cj_ = this.Quantity(context, cf_, ci_);
                    decimal? ck_ = this.ToDaily(context, cb_ ?? cd_, cj_);
                    List<Time> cl_ = bz_?.TimeOfDayElement;

                    string cm_(Time @this) {
                        string cz_ = @this?.Value;
                        return cz_;
                    }

                    IEnumerable<string> cn_ = context.Operators.Select<Time, string>((IEnumerable<Time>)cl_, cm_);

                    CqlTime co_(string @string) {
                        CqlTime da_ = context.Operators.ConvertStringToTime(@string);
                        return da_;
                    }

                    IEnumerable<CqlTime> cp_ = context.Operators.Select<string, CqlTime>(cn_, co_);
                    int? cq_ = context.Operators.Count<CqlTime>(cp_);
                    decimal? cr_ = context.Operators.ConvertIntegerToDecimal(cq_);
                    decimal? cs_ = context.Operators.Multiply(bx_, (ck_ ?? cr_) ?? 1.0m);
                    decimal? ct_ = context.Operators.Divide(bp_, cs_);
                    decimal? cu_ = context.Operators.ConvertIntegerToDecimal(1);
                    decimal? cv_ = context.Operators.Subtract(bm_ ?? ct_, cu_);
                    CqlQuantity cw_ = this.Quantity(context, cv_, "day");
                    CqlDate cx_ = context.Operators.Add(bf_ ?? bi_, cw_);
                    CqlInterval<CqlDate> cy_ = context.Operators.Interval(bf_ ?? bi_, cx_, true, true);
                    return cy_;
                }
                else
                {
                    return null as CqlInterval<CqlDate>;
                }
            }

            return f_();
        }

        IEnumerable<CqlInterval<CqlDate>> c_ = context.Operators.Select<MedicationDispense, CqlInterval<CqlDate>>((IEnumerable<MedicationDispense>)a_, b_);
        IEnumerable<CqlInterval<CqlDate>> d_ = context.Operators.Distinct<CqlInterval<CqlDate>>(c_);
        CqlInterval<CqlDate> e_ = context.Operators.SingletonFrom<CqlInterval<CqlDate>>(d_);
        return e_;
    }


    [CqlFunctionDefinition("medicationDispensePeriod")]
    public CqlInterval<CqlDate> medicationDispensePeriod(CqlContext context, MedicationDispense Dispense)
    {
        MedicationDispense[] a_ = [
            Dispense,
        ];

        CqlInterval<CqlDate> b_(MedicationDispense D) {

            CqlInterval<CqlDate> f_() {

                bool g_() {
                    FhirDateTime h_ = D?.WhenHandedOverElement;
                    CqlDateTime i_ = context.Operators.Convert<CqlDateTime>(h_);
                    CqlDate j_ = context.Operators.DateFrom(i_);
                    FhirDateTime k_ = D?.WhenPreparedElement;
                    CqlDateTime l_ = context.Operators.Convert<CqlDateTime>(k_);
                    CqlDate m_ = context.Operators.DateFrom(l_);
                    bool? n_ = context.Operators.Not((bool?)((j_ ?? m_) is null));
                    Quantity o_ = D?.DaysSupply;
                    CqlQuantity p_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, o_);
                    CqlQuantity q_ = context.Operators.ConvertQuantity(p_, "d");
                    decimal? r_ = q_?.value;
                    Quantity s_ = D?.Quantity;
                    CqlQuantity t_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, s_);
                    decimal? u_ = t_?.value;
                    List<Dosage> v_ = D?.DosageInstruction;
                    Dosage w_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)v_);
                    List<Dosage.DoseAndRateComponent> x_ = w_?.DoseAndRate;
                    Dosage.DoseAndRateComponent y_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)x_);
                    DataType z_ = y_?.Dose;
                    object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
                    CqlQuantity ab_ = context.Operators.End(aa_ as CqlInterval<CqlQuantity>);
                    decimal? ac_ = (ab_ ?? aa_ as CqlQuantity)?.value;
                    Timing ad_ = w_?.Timing;
                    Timing.RepeatComponent ae_ = ad_?.Repeat;
                    PositiveInt af_ = ae_?.FrequencyMaxElement;
                    int? ag_ = af_?.Value;
                    PositiveInt ah_ = ae_?.FrequencyElement;
                    int? ai_ = ah_?.Value;
                    FhirDecimal aj_ = ae_?.PeriodElement;
                    decimal? ak_ = aj_?.Value;
                    Code<Timing.UnitsOfTime> al_ = ae_?.PeriodUnitElement;
                    Timing.UnitsOfTime? am_ = al_?.Value;
                    string an_ = context.Operators.Convert<string>(am_);
                    CqlQuantity ao_ = this.Quantity(context, ak_, an_);
                    decimal? ap_ = this.ToDaily(context, ag_ ?? ai_, ao_);
                    List<Time> aq_ = ae_?.TimeOfDayElement;

                    string ar_(Time @this) {
                        string bb_ = @this?.Value;
                        return bb_;
                    }

                    IEnumerable<string> as_ = context.Operators.Select<Time, string>((IEnumerable<Time>)aq_, ar_);

                    CqlTime at_(string @string) {
                        CqlTime bc_ = context.Operators.ConvertStringToTime(@string);
                        return bc_;
                    }

                    IEnumerable<CqlTime> au_ = context.Operators.Select<string, CqlTime>(as_, at_);
                    int? av_ = context.Operators.Count<CqlTime>(au_);
                    decimal? aw_ = context.Operators.ConvertIntegerToDecimal(av_);
                    decimal? ax_ = context.Operators.Multiply(ac_, (ap_ ?? aw_) ?? 1.0m);
                    decimal? ay_ = context.Operators.Divide(u_, ax_);
                    bool? az_ = context.Operators.Not((bool?)((r_ ?? ay_) is null));
                    bool? ba_ = context.Operators.And(n_, az_);
                    return ba_ ?? false;
                }

                if (g_())
                {
                    FhirDateTime bd_ = D?.WhenHandedOverElement;
                    CqlDateTime be_ = context.Operators.Convert<CqlDateTime>(bd_);
                    CqlDate bf_ = context.Operators.DateFrom(be_);
                    FhirDateTime bg_ = D?.WhenPreparedElement;
                    CqlDateTime bh_ = context.Operators.Convert<CqlDateTime>(bg_);
                    CqlDate bi_ = context.Operators.DateFrom(bh_);
                    Quantity bj_ = D?.DaysSupply;
                    CqlQuantity bk_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, bj_);
                    CqlQuantity bl_ = context.Operators.ConvertQuantity(bk_, "d");
                    decimal? bm_ = bl_?.value;
                    Quantity bn_ = D?.Quantity;
                    CqlQuantity bo_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, bn_);
                    decimal? bp_ = bo_?.value;
                    List<Dosage> bq_ = D?.DosageInstruction;
                    Dosage br_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)bq_);
                    List<Dosage.DoseAndRateComponent> bs_ = br_?.DoseAndRate;
                    Dosage.DoseAndRateComponent bt_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)bs_);
                    DataType bu_ = bt_?.Dose;
                    object bv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bu_);
                    CqlQuantity bw_ = context.Operators.End(bv_ as CqlInterval<CqlQuantity>);
                    decimal? bx_ = (bw_ ?? bv_ as CqlQuantity)?.value;
                    Timing by_ = br_?.Timing;
                    Timing.RepeatComponent bz_ = by_?.Repeat;
                    PositiveInt ca_ = bz_?.FrequencyMaxElement;
                    int? cb_ = ca_?.Value;
                    PositiveInt cc_ = bz_?.FrequencyElement;
                    int? cd_ = cc_?.Value;
                    FhirDecimal ce_ = bz_?.PeriodElement;
                    decimal? cf_ = ce_?.Value;
                    Code<Timing.UnitsOfTime> cg_ = bz_?.PeriodUnitElement;
                    Timing.UnitsOfTime? ch_ = cg_?.Value;
                    string ci_ = context.Operators.Convert<string>(ch_);
                    CqlQuantity cj_ = this.Quantity(context, cf_, ci_);
                    decimal? ck_ = this.ToDaily(context, cb_ ?? cd_, cj_);
                    List<Time> cl_ = bz_?.TimeOfDayElement;

                    string cm_(Time @this) {
                        string cz_ = @this?.Value;
                        return cz_;
                    }

                    IEnumerable<string> cn_ = context.Operators.Select<Time, string>((IEnumerable<Time>)cl_, cm_);

                    CqlTime co_(string @string) {
                        CqlTime da_ = context.Operators.ConvertStringToTime(@string);
                        return da_;
                    }

                    IEnumerable<CqlTime> cp_ = context.Operators.Select<string, CqlTime>(cn_, co_);
                    int? cq_ = context.Operators.Count<CqlTime>(cp_);
                    decimal? cr_ = context.Operators.ConvertIntegerToDecimal(cq_);
                    decimal? cs_ = context.Operators.Multiply(bx_, (ck_ ?? cr_) ?? 1.0m);
                    decimal? ct_ = context.Operators.Divide(bp_, cs_);
                    decimal? cu_ = context.Operators.ConvertIntegerToDecimal(1);
                    decimal? cv_ = context.Operators.Subtract(bm_ ?? ct_, cu_);
                    CqlQuantity cw_ = this.Quantity(context, cv_, "day");
                    CqlDate cx_ = context.Operators.Add(bf_ ?? bi_, cw_);
                    CqlInterval<CqlDate> cy_ = context.Operators.Interval(bf_ ?? bi_, cx_, true, true);
                    return cy_;
                }
                else
                {
                    return null as CqlInterval<CqlDate>;
                }
            }

            return f_();
        }

        IEnumerable<CqlInterval<CqlDate>> c_ = context.Operators.Select<MedicationDispense, CqlInterval<CqlDate>>((IEnumerable<MedicationDispense>)a_, b_);
        IEnumerable<CqlInterval<CqlDate>> d_ = context.Operators.Distinct<CqlInterval<CqlDate>>(c_);
        CqlInterval<CqlDate> e_ = context.Operators.SingletonFrom<CqlInterval<CqlDate>>(d_);
        return e_;
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

            CqlInterval<CqlDate> f_() {

                bool g_() {
                    DataType h_ = Administration?.Effective;
                    object i_ = FHIRHelpers_4_4_000.Instance.ToValue(context, h_);
                    CqlDateTime j_ = context.Operators.Start(i_ as CqlInterval<CqlDateTime>);
                    CqlDate k_ = context.Operators.DateFrom(j_);
                    bool? l_ = context.Operators.Not((bool?)(k_ is null));
                    DataType m_ = Administration?.Medication;
                    object n_ = FHIRHelpers_4_4_000.Instance.ToValue(context, m_);
                    CqlQuantity o_ = this.TherapeuticDuration(context, n_ as CqlConcept);
                    bool? p_ = context.Operators.Not((bool?)(o_ is null));
                    bool? q_ = context.Operators.And(l_, p_);
                    return q_ ?? false;
                }

                if (g_())
                {
                    DataType r_ = Administration?.Effective;
                    object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
                    CqlDateTime t_ = context.Operators.Start(s_ as CqlInterval<CqlDateTime>);
                    CqlDate u_ = context.Operators.DateFrom(t_);
                    DataType v_ = Administration?.Medication;
                    object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                    CqlQuantity x_ = this.TherapeuticDuration(context, w_ as CqlConcept);
                    CqlDate y_ = context.Operators.Add(u_, x_);
                    CqlQuantity z_ = context.Operators.ConvertIntegerToQuantity(1);
                    CqlDate aa_ = context.Operators.Subtract(y_, z_);
                    CqlInterval<CqlDate> ab_ = context.Operators.Interval(u_, aa_, true, true);
                    return ab_;
                }
                else
                {
                    return null as CqlInterval<CqlDate>;
                }
            }

            return f_();
        }

        IEnumerable<CqlInterval<CqlDate>> c_ = context.Operators.Select<MedicationAdministration, CqlInterval<CqlDate>>((IEnumerable<MedicationAdministration>)a_, b_);
        IEnumerable<CqlInterval<CqlDate>> d_ = context.Operators.Distinct<CqlInterval<CqlDate>>(c_);
        CqlInterval<CqlDate> e_ = context.Operators.SingletonFrom<CqlInterval<CqlDate>>(d_);
        return e_;
    }


    [CqlFunctionDefinition("medicationAdministrationPeriod")]
    public CqlInterval<CqlDate> medicationAdministrationPeriod(CqlContext context, MedicationAdministration Administration)
    {
        MedicationAdministration[] a_ = [
            Administration,
        ];

        CqlInterval<CqlDate> b_(MedicationAdministration M) {

            CqlInterval<CqlDate> f_() {

                bool g_() {
                    DataType h_ = Administration?.Effective;
                    object i_ = FHIRHelpers_4_4_000.Instance.ToValue(context, h_);
                    CqlDateTime j_ = context.Operators.Start(i_ as CqlInterval<CqlDateTime>);
                    CqlDate k_ = context.Operators.DateFrom(j_);
                    bool? l_ = context.Operators.Not((bool?)(k_ is null));
                    DataType m_ = Administration?.Medication;
                    object n_ = FHIRHelpers_4_4_000.Instance.ToValue(context, m_);
                    CqlQuantity o_ = this.TherapeuticDuration(context, n_ as CqlConcept);
                    bool? p_ = context.Operators.Not((bool?)(o_ is null));
                    bool? q_ = context.Operators.And(l_, p_);
                    return q_ ?? false;
                }

                if (g_())
                {
                    DataType r_ = Administration?.Effective;
                    object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
                    CqlDateTime t_ = context.Operators.Start(s_ as CqlInterval<CqlDateTime>);
                    CqlDate u_ = context.Operators.DateFrom(t_);
                    DataType v_ = Administration?.Medication;
                    object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                    CqlQuantity x_ = this.TherapeuticDuration(context, w_ as CqlConcept);
                    CqlDate y_ = context.Operators.Add(u_, x_);
                    CqlQuantity z_ = context.Operators.ConvertIntegerToQuantity(1);
                    CqlDate aa_ = context.Operators.Subtract(y_, z_);
                    CqlInterval<CqlDate> ab_ = context.Operators.Interval(u_, aa_, true, true);
                    return ab_;
                }
                else
                {
                    return null as CqlInterval<CqlDate>;
                }
            }

            return f_();
        }

        IEnumerable<CqlInterval<CqlDate>> c_ = context.Operators.Select<MedicationAdministration, CqlInterval<CqlDate>>((IEnumerable<MedicationAdministration>)a_, b_);
        IEnumerable<CqlInterval<CqlDate>> d_ = context.Operators.Distinct<CqlInterval<CqlDate>>(c_);
        CqlInterval<CqlDate> e_ = context.Operators.SingletonFrom<CqlInterval<CqlDate>>(d_);
        return e_;
    }


    [CqlFunctionDefinition("CumulativeDuration")]
    public int? CumulativeDuration(CqlContext context, IEnumerable<CqlInterval<CqlDate>> Intervals)
    {

        int? a_() {
            if ((context.Operators.Not((bool?)(Intervals is null))) ?? false)
            {
                IEnumerable<CqlInterval<CqlDate>> b_ = context.Operators.Collapse(Intervals, "day");

                int? c_(CqlInterval<CqlDate> X) {
                    CqlDate f_ = context.Operators.Start(X);
                    CqlDate g_ = context.Operators.End(X);
                    int? h_ = context.Operators.DifferenceBetween(f_, g_, "day");
                    int? i_ = context.Operators.Add(h_, 1);
                    return i_;
                }

                IEnumerable<int?> d_ = context.Operators.Select<CqlInterval<CqlDate>, int?>(b_, c_);
                int? e_ = context.Operators.Sum(d_);
                return e_;
            }
            else
            {
                return default;
            }
        }

        return a_();
    }


    [CqlFunctionDefinition("cumulativeDuration")]
    public int? cumulativeDuration(CqlContext context, IEnumerable<CqlInterval<CqlDate>> Intervals)
    {

        int? a_() {
            if ((context.Operators.Not((bool?)(Intervals is null))) ?? false)
            {
                IEnumerable<CqlInterval<CqlDate>> b_ = context.Operators.Collapse(Intervals, "day");

                int? c_(CqlInterval<CqlDate> X) {
                    CqlDate f_ = context.Operators.Start(X);
                    CqlDate g_ = context.Operators.End(X);
                    int? h_ = context.Operators.DifferenceBetween(f_, g_, "day");
                    int? i_ = context.Operators.Add(h_, 1);
                    return i_;
                }

                IEnumerable<int?> d_ = context.Operators.Select<CqlInterval<CqlDate>, int?>(b_, c_);
                int? e_ = context.Operators.Sum(d_);
                return e_;
            }
            else
            {
                return default;
            }
        }

        return a_();
    }


    [CqlFunctionDefinition("RolloutIntervals")]
    public IEnumerable<CqlInterval<CqlDate>> RolloutIntervals(CqlContext context, IEnumerable<CqlInterval<CqlDate>> intervals)
    {

        IEnumerable<CqlInterval<CqlDate>> a_(IEnumerable<CqlInterval<CqlDate>> R, CqlInterval<CqlDate> I) {
            CqlInterval<CqlDate>[] c_ = [
                I,
            ];

            CqlInterval<CqlDate> d_(CqlInterval<CqlDate> X) {
                CqlInterval<CqlDate> j_ = context.Operators.Last<CqlInterval<CqlDate>>(R);
                CqlDate k_ = context.Operators.End(j_);
                CqlQuantity l_ = context.Operators.Quantity(1m, "day");
                CqlDate m_ = context.Operators.Add(k_, l_);
                CqlDate n_ = context.Operators.Start(X);
                CqlDate[] o_ = [
                    m_,
                    n_,
                ];
                CqlDate p_ = context.Operators.Max<CqlDate>((IEnumerable<CqlDate>)o_);
                CqlDate q_ = context.Operators.End(X);
                int? r_ = context.Operators.DurationBetween(n_, q_, "day");
                decimal? s_ = context.Operators.ConvertIntegerToDecimal(r_ ?? 0);
                CqlQuantity t_ = this.Quantity(context, s_, "day");
                CqlDate u_ = context.Operators.Add(p_, t_);
                CqlInterval<CqlDate> v_ = context.Operators.Interval(p_, u_, true, true);
                return v_;
            }

            IEnumerable<CqlInterval<CqlDate>> e_ = context.Operators.Select<CqlInterval<CqlDate>, CqlInterval<CqlDate>>((IEnumerable<CqlInterval<CqlDate>>)c_, d_);
            IEnumerable<CqlInterval<CqlDate>> f_ = context.Operators.Distinct<CqlInterval<CqlDate>>(e_);
            CqlInterval<CqlDate> g_ = context.Operators.SingletonFrom<CqlInterval<CqlDate>>(f_);
            CqlInterval<CqlDate>[] h_ = [
                g_,
            ];
            IEnumerable<CqlInterval<CqlDate>> i_ = context.Operators.Union<CqlInterval<CqlDate>>(R, (IEnumerable<CqlInterval<CqlDate>>)h_);
            return i_;
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
                CqlInterval<CqlDate> j_ = context.Operators.Last<CqlInterval<CqlDate>>(R);
                CqlDate k_ = context.Operators.End(j_);
                CqlQuantity l_ = context.Operators.Quantity(1m, "day");
                CqlDate m_ = context.Operators.Add(k_, l_);
                CqlDate n_ = context.Operators.Start(X);
                CqlDate[] o_ = [
                    m_,
                    n_,
                ];
                CqlDate p_ = context.Operators.Max<CqlDate>((IEnumerable<CqlDate>)o_);
                CqlDate q_ = context.Operators.End(X);
                int? r_ = context.Operators.DurationBetween(n_, q_, "day");
                decimal? s_ = context.Operators.ConvertIntegerToDecimal(r_ ?? 0);
                CqlQuantity t_ = this.Quantity(context, s_, "day");
                CqlDate u_ = context.Operators.Add(p_, t_);
                CqlInterval<CqlDate> v_ = context.Operators.Interval(p_, u_, true, true);
                return v_;
            }

            IEnumerable<CqlInterval<CqlDate>> e_ = context.Operators.Select<CqlInterval<CqlDate>, CqlInterval<CqlDate>>((IEnumerable<CqlInterval<CqlDate>>)c_, d_);
            IEnumerable<CqlInterval<CqlDate>> f_ = context.Operators.Distinct<CqlInterval<CqlDate>>(e_);
            CqlInterval<CqlDate> g_ = context.Operators.SingletonFrom<CqlInterval<CqlDate>>(f_);
            CqlInterval<CqlDate>[] h_ = [
                g_,
            ];
            IEnumerable<CqlInterval<CqlDate>> i_ = context.Operators.Union<CqlInterval<CqlDate>>(R, (IEnumerable<CqlInterval<CqlDate>>)h_);
            return i_;
        }

        IEnumerable<CqlInterval<CqlDate>> b_ = context.Operators.Aggregate<CqlInterval<CqlDate>, IEnumerable<CqlInterval<CqlDate>>>(intervals, a_, null as IEnumerable<CqlInterval<CqlDate>>);
        return b_;
    }


    [CqlFunctionDefinition("MedicationPeriod")]
    public CqlInterval<CqlDate> MedicationPeriod(CqlContext context, object medication)
    {

        CqlInterval<CqlDate> a_() {
            if (medication is MedicationRequest)
            {
                CqlInterval<CqlDate> b_ = this.MedicationRequestPeriod(context, medication as MedicationRequest);
                return b_;
            }
            else if (medication is MedicationDispense)
            {
                CqlInterval<CqlDate> c_ = this.MedicationDispensePeriod(context, medication as MedicationDispense);
                return c_;
            }
            else
            {
                return null as CqlInterval<CqlDate>;
            }
        }

        return a_();
    }


    [CqlFunctionDefinition("medicationPeriod")]
    public CqlInterval<CqlDate> medicationPeriod(CqlContext context, object medication)
    {

        CqlInterval<CqlDate> a_() {
            if (medication is MedicationRequest)
            {
                CqlInterval<CqlDate> b_ = this.medicationRequestPeriod(context, medication as MedicationRequest);
                return b_;
            }
            else if (medication is MedicationDispense)
            {
                CqlInterval<CqlDate> c_ = this.medicationDispensePeriod(context, medication as MedicationDispense);
                return c_;
            }
            else
            {
                return null as CqlInterval<CqlDate>;
            }
        }

        return a_();
    }


    [CqlFunctionDefinition("CumulativeMedicationDuration")]
    public int? CumulativeMedicationDuration(CqlContext context, IEnumerable<object> Medications)
    {

        bool? a_(object M) {
            bool n_ = M is MedicationRequest;
            return n_ as bool?;
        }

        IEnumerable<object> b_ = context.Operators.Where<object>(Medications, a_);

        CqlInterval<CqlDate> c_(object M) {
            CqlInterval<CqlDate> o_ = this.MedicationRequestPeriod(context, M as MedicationRequest);
            return o_;
        }

        IEnumerable<CqlInterval<CqlDate>> d_ = context.Operators.Select<object, CqlInterval<CqlDate>>(b_, c_);
        IEnumerable<CqlInterval<CqlDate>> e_ = context.Operators.Distinct<CqlInterval<CqlDate>>(d_);

        bool? f_(object M) {
            bool p_ = M is MedicationDispense;
            return p_ as bool?;
        }

        IEnumerable<object> g_ = context.Operators.Where<object>(Medications, f_);

        CqlInterval<CqlDate> h_(object M) {
            CqlInterval<CqlDate> q_ = this.MedicationDispensePeriod(context, M as MedicationDispense);
            return q_;
        }

        IEnumerable<CqlInterval<CqlDate>> i_ = context.Operators.Select<object, CqlInterval<CqlDate>>(g_, h_);
        IEnumerable<CqlInterval<CqlDate>> j_ = context.Operators.Distinct<CqlInterval<CqlDate>>(i_);
        IEnumerable<CqlInterval<CqlDate>> k_ = this.RolloutIntervals(context, j_);
        IEnumerable<CqlInterval<CqlDate>> l_ = context.Operators.Union<CqlInterval<CqlDate>>(e_, k_);
        int? m_ = this.CumulativeDuration(context, l_);
        return m_;
    }


    [CqlFunctionDefinition("cumulativeMedicationDuration")]
    public int? cumulativeMedicationDuration(CqlContext context, IEnumerable<object> Medications)
    {

        bool? a_(object M) {
            bool n_ = M is MedicationRequest;
            return n_ as bool?;
        }

        IEnumerable<object> b_ = context.Operators.Where<object>(Medications, a_);

        CqlInterval<CqlDate> c_(object M) {
            CqlInterval<CqlDate> o_ = this.medicationRequestPeriod(context, M as MedicationRequest);
            return o_;
        }

        IEnumerable<CqlInterval<CqlDate>> d_ = context.Operators.Select<object, CqlInterval<CqlDate>>(b_, c_);
        IEnumerable<CqlInterval<CqlDate>> e_ = context.Operators.Distinct<CqlInterval<CqlDate>>(d_);

        bool? f_(object M) {
            bool p_ = M is MedicationDispense;
            return p_ as bool?;
        }

        IEnumerable<object> g_ = context.Operators.Where<object>(Medications, f_);

        CqlInterval<CqlDate> h_(object M) {
            CqlInterval<CqlDate> q_ = this.medicationDispensePeriod(context, M as MedicationDispense);
            return q_;
        }

        IEnumerable<CqlInterval<CqlDate>> i_ = context.Operators.Select<object, CqlInterval<CqlDate>>(g_, h_);
        IEnumerable<CqlInterval<CqlDate>> j_ = context.Operators.Distinct<CqlInterval<CqlDate>>(i_);
        IEnumerable<CqlInterval<CqlDate>> k_ = this.rolloutIntervals(context, j_);
        IEnumerable<CqlInterval<CqlDate>> l_ = context.Operators.Union<CqlInterval<CqlDate>>(e_, k_);
        int? m_ = this.cumulativeDuration(context, l_);
        return m_;
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
