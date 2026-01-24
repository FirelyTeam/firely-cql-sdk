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
using Hl7.Cql.Runtime.Internal;
using Hl7.Fhir.Model;
using Range = Hl7.Fhir.Model.Range;
using Task = Hl7.Fhir.Model.Task;

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "6.0.0.0")]
[CqlLibrary("CumulativeMedicationDuration", "6.0.000")]
public partial class CumulativeMedicationDuration_6_0_000 : ILibrary, ILibraryInternals, ISingleton<CumulativeMedicationDuration_6_0_000>
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
        _cache?.GetOrCompute(_cacheIndex_ErrorLevel, ErrorLevel_Compute, context) ?? ErrorLevel_Compute(context);

    private string ErrorLevel_Compute(CqlContext context)
    {
        object a_ = context.ResolveParameter("CumulativeMedicationDuration-6.0.000", "ErrorLevel", "Warning");
        return (string)a_;
    }


    #endregion Parameters

    #region Functions and Expressions (19)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Patient, Patient_Compute, context) ?? Patient_Compute(context);

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
                decimal? cd_ = context.Operators.Multiply(cb_, ca_);
                return cd_;
            }
            else if (e_())
            {
                decimal? ce_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? cf_ = period?.value;
                decimal? cg_ = context.Operators.Divide(24.0m, cf_);
                decimal? ch_ = context.Operators.Multiply(ce_, cg_);
                decimal? ci_ = context.Operators.ConvertIntegerToDecimal(24);
                decimal? cj_ = context.Operators.Divide(ch_, ci_);
                return cj_;
            }
            else if (f_())
            {
                decimal? ck_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? cl_ = period?.value;
                decimal? cm_ = context.Operators.Divide(24.0m, cl_);
                decimal? cn_ = context.Operators.Multiply(ck_, cm_);
                int? co_ = context.Operators.Multiply(24, 7);
                decimal? cp_ = context.Operators.ConvertIntegerToDecimal(co_);
                decimal? cq_ = context.Operators.Divide(cn_, cp_);
                return cq_;
            }
            else if (g_())
            {
                decimal? cr_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? cs_ = period?.value;
                decimal? ct_ = context.Operators.Divide(24.0m, cs_);
                decimal? cu_ = context.Operators.Multiply(cr_, ct_);
                int? cv_ = context.Operators.Multiply(24, 30);
                decimal? cw_ = context.Operators.ConvertIntegerToDecimal(cv_);
                decimal? cx_ = context.Operators.Divide(cu_, cw_);
                return cx_;
            }
            else if (h_())
            {
                decimal? cy_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? cz_ = period?.value;
                decimal? da_ = context.Operators.Divide(24.0m, cz_);
                decimal? db_ = context.Operators.Multiply(cy_, da_);
                int? dc_ = context.Operators.Multiply(24, 365);
                decimal? dd_ = context.Operators.ConvertIntegerToDecimal(dc_);
                decimal? de_ = context.Operators.Divide(db_, dd_);
                return de_;
            }
            else if (i_())
            {
                decimal? df_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? dg_ = period?.value;
                decimal? dh_ = context.Operators.Divide(24.0m, dg_);
                decimal? di_ = context.Operators.Multiply(df_, dh_);
                return di_;
            }
            else if (j_())
            {
                decimal? dj_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? dk_ = period?.value;
                decimal? dl_ = context.Operators.Divide(24.0m, dk_);
                decimal? dm_ = context.Operators.Multiply(dj_, dl_);
                decimal? dn_ = context.Operators.ConvertIntegerToDecimal(60);
                decimal? do_ = context.Operators.Multiply(dm_, dn_);
                return do_;
            }
            else if (k_())
            {
                decimal? dp_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? dq_ = period?.value;
                decimal? dr_ = context.Operators.Divide(24.0m, dq_);
                decimal? ds_ = context.Operators.Multiply(dp_, dr_);
                decimal? dt_ = context.Operators.ConvertIntegerToDecimal(60);
                decimal? du_ = context.Operators.Multiply(ds_, dt_);
                decimal? dw_ = context.Operators.Multiply(du_, dt_);
                return dw_;
            }
            else if (l_())
            {
                decimal? dx_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? dy_ = period?.value;
                decimal? dz_ = context.Operators.Divide(24.0m, dy_);
                decimal? ea_ = context.Operators.Multiply(dx_, dz_);
                decimal? eb_ = context.Operators.ConvertIntegerToDecimal(24);
                decimal? ec_ = context.Operators.Divide(ea_, eb_);
                return ec_;
            }
            else if (m_())
            {
                decimal? ed_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? ee_ = period?.value;
                decimal? ef_ = context.Operators.Divide(24.0m, ee_);
                decimal? eg_ = context.Operators.Multiply(ed_, ef_);
                int? eh_ = context.Operators.Multiply(24, 7);
                decimal? ei_ = context.Operators.ConvertIntegerToDecimal(eh_);
                decimal? ej_ = context.Operators.Divide(eg_, ei_);
                return ej_;
            }
            else if (n_())
            {
                decimal? ek_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? el_ = period?.value;
                decimal? em_ = context.Operators.Divide(24.0m, el_);
                decimal? en_ = context.Operators.Multiply(ek_, em_);
                int? eo_ = context.Operators.Multiply(24, 30);
                decimal? ep_ = context.Operators.ConvertIntegerToDecimal(eo_);
                decimal? eq_ = context.Operators.Divide(en_, ep_);
                return eq_;
            }
            else if (o_())
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
            else if (p_())
            {
                decimal? ey_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? ez_ = period?.value;
                decimal? fa_ = context.Operators.Divide(24.0m, ez_);
                decimal? fb_ = context.Operators.Multiply(ey_, fa_);
                return fb_;
            }
            else if (q_())
            {
                decimal? fc_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? fd_ = period?.value;
                decimal? fe_ = context.Operators.Divide(24.0m, fd_);
                decimal? ff_ = context.Operators.Multiply(fc_, fe_);
                decimal? fg_ = context.Operators.ConvertIntegerToDecimal(60);
                decimal? fh_ = context.Operators.Multiply(ff_, fg_);
                return fh_;
            }
            else if (r_())
            {
                decimal? fi_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? fj_ = period?.value;
                decimal? fk_ = context.Operators.Divide(24.0m, fj_);
                decimal? fl_ = context.Operators.Multiply(fi_, fk_);
                decimal? fm_ = context.Operators.ConvertIntegerToDecimal(60);
                decimal? fn_ = context.Operators.Multiply(fl_, fm_);
                decimal? fp_ = context.Operators.Multiply(fn_, fm_);
                return fp_;
            }
            else if (s_())
            {
                decimal? fq_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? fr_ = period?.value;
                decimal? fs_ = context.Operators.Divide(24.0m, fr_);
                decimal? ft_ = context.Operators.Multiply(fq_, fs_);
                decimal? fu_ = context.Operators.ConvertIntegerToDecimal(24);
                decimal? fv_ = context.Operators.Divide(ft_, fu_);
                return fv_;
            }
            else if (t_())
            {
                decimal? fw_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? fx_ = period?.value;
                decimal? fy_ = context.Operators.Divide(24.0m, fx_);
                decimal? fz_ = context.Operators.Multiply(fw_, fy_);
                int? ga_ = context.Operators.Multiply(24, 7);
                decimal? gb_ = context.Operators.ConvertIntegerToDecimal(ga_);
                decimal? gc_ = context.Operators.Divide(fz_, gb_);
                return gc_;
            }
            else if (u_())
            {
                decimal? gd_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? ge_ = period?.value;
                decimal? gf_ = context.Operators.Divide(24.0m, ge_);
                decimal? gg_ = context.Operators.Multiply(gd_, gf_);
                int? gh_ = context.Operators.Multiply(24, 30);
                decimal? gi_ = context.Operators.ConvertIntegerToDecimal(gh_);
                decimal? gj_ = context.Operators.Divide(gg_, gi_);
                return gj_;
            }
            else if (v_())
            {
                decimal? gk_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? gl_ = period?.value;
                decimal? gm_ = context.Operators.Divide(24.0m, gl_);
                decimal? gn_ = context.Operators.Multiply(gk_, gm_);
                int? go_ = context.Operators.Multiply(24, 365);
                decimal? gp_ = context.Operators.ConvertIntegerToDecimal(go_);
                decimal? gq_ = context.Operators.Divide(gn_, gp_);
                return gq_;
            }
            else
            {
                string gr_ = this.ErrorLevel(context);
                string gs_ = period?.unit;
                string gt_ = context.Operators.Concatenate("Unknown unit ", gs_ ?? "");
                object gu_ = context.Operators.Message<object>(null, "CMDLogic.ToDaily.UnknownUnit", gr_, gt_);
                return gu_ as decimal?;
            };
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
                object fp_ = context.Operators.Message<object>(null, "CMDLogic.ToDaily.UnknownFrequencyCode", fm_, fo_);
                return fp_ as decimal?;
            };
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
                    Duration aa_ = t_?.ExpectedSupplyDuration;
                    CqlQuantity ab_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, aa_);
                    CqlQuantity ac_ = context.Operators.ConvertQuantity(ab_, "d");
                    decimal? ad_ = ac_?.value;
                    Quantity af_ = t_?.Quantity;
                    CqlQuantity ag_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, af_);
                    decimal? ah_ = ag_?.value;
                    Dosage aj_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)i_);
                    List<Dosage.DoseAndRateComponent> ak_ = aj_?.DoseAndRate;
                    Dosage.DoseAndRateComponent al_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)ak_);
                    DataType am_ = al_?.Dose;
                    object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                    CqlQuantity ao_ = context.Operators.End(an_ as CqlInterval<CqlQuantity>);
                    Dosage aq_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)i_);
                    List<Dosage.DoseAndRateComponent> ar_ = aq_?.DoseAndRate;
                    Dosage.DoseAndRateComponent as_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)ar_);
                    DataType at_ = as_?.Dose;
                    object au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
                    decimal? av_ = (ao_ ?? au_ as CqlQuantity)?.value;
                    Dosage ax_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)i_);
                    Timing ay_ = ax_?.Timing;
                    Timing.RepeatComponent az_ = ay_?.Repeat;
                    PositiveInt ba_ = az_?.FrequencyMaxElement;
                    int? bb_ = ba_?.Value;
                    Dosage bd_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)i_);
                    Timing be_ = bd_?.Timing;
                    Timing.RepeatComponent bf_ = be_?.Repeat;
                    PositiveInt bg_ = bf_?.FrequencyElement;
                    int? bh_ = bg_?.Value;
                    Dosage bj_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)i_);
                    Timing bk_ = bj_?.Timing;
                    Timing.RepeatComponent bl_ = bk_?.Repeat;
                    FhirDecimal bm_ = bl_?.PeriodElement;
                    decimal? bn_ = bm_?.Value;
                    Dosage bp_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)i_);
                    Timing bq_ = bp_?.Timing;
                    Timing.RepeatComponent br_ = bq_?.Repeat;
                    Code<Timing.UnitsOfTime> bs_ = br_?.PeriodUnitElement;
                    Timing.UnitsOfTime? bt_ = bs_?.Value;
                    string bu_ = context.Operators.Convert<string>(bt_);
                    CqlQuantity bv_ = this.Quantity(context, bn_, bu_);
                    decimal? bw_ = this.ToDaily(context, bb_ ?? bh_, bv_);
                    Dosage by_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)i_);
                    Timing bz_ = by_?.Timing;
                    Timing.RepeatComponent ca_ = bz_?.Repeat;
                    List<Time> cb_ = ca_?.TimeOfDayElement;

                    string cc_(Time @this) {
                        string cs_ = @this?.Value;
                        return cs_;
                    }

                    IEnumerable<string> cd_ = context.Operators.Select<Time, string>((IEnumerable<Time>)cb_, cc_);

                    CqlTime ce_(string @string) {
                        CqlTime ct_ = context.Operators.ConvertStringToTime(@string);
                        return ct_;
                    }

                    IEnumerable<CqlTime> cf_ = context.Operators.Select<string, CqlTime>(cd_, ce_);
                    int? cg_ = context.Operators.Count<CqlTime>(cf_);
                    decimal? ch_ = context.Operators.ConvertIntegerToDecimal(cg_);
                    decimal? ci_ = context.Operators.Multiply(av_, (bw_ ?? ch_) ?? 1.0m);
                    decimal? cj_ = context.Operators.Divide(ah_, ci_);
                    UnsignedInt cl_ = t_?.NumberOfRepeatsAllowedElement;
                    int? cm_ = cl_?.Value;
                    int? cn_ = context.Operators.Add(1, cm_ ?? 0);
                    decimal? co_ = context.Operators.ConvertIntegerToDecimal(cn_);
                    decimal? cp_ = context.Operators.Multiply(ad_ ?? cj_, co_);
                    bool? cq_ = context.Operators.Not((bool?)(cp_ is null));
                    bool? cr_ = context.Operators.And(y_, cq_);
                    return cr_ ?? false;
                }


                bool h_() {
                    List<Dosage> cu_ = R?.DosageInstruction;
                    Dosage cv_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)cu_);
                    Timing cw_ = cv_?.Timing;
                    Timing.RepeatComponent cx_ = cw_?.Repeat;
                    DataType cy_ = cx_?.Bounds;
                    object cz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cy_);
                    CqlDateTime da_ = context.Operators.Start(cz_ as CqlInterval<CqlDateTime>);
                    CqlDate db_ = context.Operators.DateFrom(da_);
                    FhirDateTime dc_ = R?.AuthoredOnElement;
                    CqlDateTime dd_ = context.Operators.Convert<CqlDateTime>(dc_);
                    CqlDate de_ = context.Operators.DateFrom(dd_);
                    MedicationRequest.DispenseRequestComponent df_ = R?.DispenseRequest;
                    Period dg_ = df_?.ValidityPeriod;
                    CqlInterval<CqlDateTime> dh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dg_);
                    CqlDateTime di_ = context.Operators.Start(dh_);
                    CqlDate dj_ = context.Operators.DateFrom(di_);
                    bool? dk_ = context.Operators.Not((bool?)(((db_ ?? de_) ?? dj_) is null));
                    Dosage dm_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)cu_);
                    Timing dn_ = dm_?.Timing;
                    Timing.RepeatComponent do_ = dn_?.Repeat;
                    DataType dp_ = do_?.Bounds;
                    object dq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dp_);
                    CqlDateTime dr_ = (dq_ as CqlInterval<CqlDateTime>)?.high;
                    bool? ds_ = context.Operators.Not((bool?)(dr_ is null));
                    bool? dt_ = context.Operators.And(dk_, ds_);
                    return dt_ ?? false;
                }

                if (g_())
                {
                    List<Dosage> du_ = R?.DosageInstruction;
                    Dosage dv_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)du_);
                    Timing dw_ = dv_?.Timing;
                    Timing.RepeatComponent dx_ = dw_?.Repeat;
                    DataType dy_ = dx_?.Bounds;
                    object dz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dy_);
                    CqlDateTime ea_ = context.Operators.Start(dz_ as CqlInterval<CqlDateTime>);
                    CqlDate eb_ = context.Operators.DateFrom(ea_);
                    FhirDateTime ec_ = R?.AuthoredOnElement;
                    CqlDateTime ed_ = context.Operators.Convert<CqlDateTime>(ec_);
                    CqlDate ee_ = context.Operators.DateFrom(ed_);
                    MedicationRequest.DispenseRequestComponent ef_ = R?.DispenseRequest;
                    Period eg_ = ef_?.ValidityPeriod;
                    CqlInterval<CqlDateTime> eh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, eg_);
                    CqlDateTime ei_ = context.Operators.Start(eh_);
                    CqlDate ej_ = context.Operators.DateFrom(ei_);
                    Dosage el_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)du_);
                    Timing em_ = el_?.Timing;
                    Timing.RepeatComponent en_ = em_?.Repeat;
                    DataType eo_ = en_?.Bounds;
                    object ep_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eo_);
                    CqlDateTime eq_ = context.Operators.Start(ep_ as CqlInterval<CqlDateTime>);
                    CqlDate er_ = context.Operators.DateFrom(eq_);
                    CqlDateTime et_ = context.Operators.Convert<CqlDateTime>(ec_);
                    CqlDate eu_ = context.Operators.DateFrom(et_);
                    Period ew_ = ef_?.ValidityPeriod;
                    CqlInterval<CqlDateTime> ex_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ew_);
                    CqlDateTime ey_ = context.Operators.Start(ex_);
                    CqlDate ez_ = context.Operators.DateFrom(ey_);
                    Duration fb_ = ef_?.ExpectedSupplyDuration;
                    CqlQuantity fc_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, fb_);
                    CqlQuantity fd_ = context.Operators.ConvertQuantity(fc_, "d");
                    decimal? fe_ = fd_?.value;
                    Quantity fg_ = ef_?.Quantity;
                    CqlQuantity fh_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, fg_);
                    decimal? fi_ = fh_?.value;
                    Dosage fk_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)du_);
                    List<Dosage.DoseAndRateComponent> fl_ = fk_?.DoseAndRate;
                    Dosage.DoseAndRateComponent fm_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)fl_);
                    DataType fn_ = fm_?.Dose;
                    object fo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fn_);
                    CqlQuantity fp_ = context.Operators.End(fo_ as CqlInterval<CqlQuantity>);
                    Dosage fr_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)du_);
                    List<Dosage.DoseAndRateComponent> fs_ = fr_?.DoseAndRate;
                    Dosage.DoseAndRateComponent ft_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)fs_);
                    DataType fu_ = ft_?.Dose;
                    object fv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fu_);
                    decimal? fw_ = (fp_ ?? fv_ as CqlQuantity)?.value;
                    Dosage fy_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)du_);
                    Timing fz_ = fy_?.Timing;
                    Timing.RepeatComponent ga_ = fz_?.Repeat;
                    PositiveInt gb_ = ga_?.FrequencyMaxElement;
                    int? gc_ = gb_?.Value;
                    Dosage ge_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)du_);
                    Timing gf_ = ge_?.Timing;
                    Timing.RepeatComponent gg_ = gf_?.Repeat;
                    PositiveInt gh_ = gg_?.FrequencyElement;
                    int? gi_ = gh_?.Value;
                    Dosage gk_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)du_);
                    Timing gl_ = gk_?.Timing;
                    Timing.RepeatComponent gm_ = gl_?.Repeat;
                    FhirDecimal gn_ = gm_?.PeriodElement;
                    decimal? go_ = gn_?.Value;
                    Dosage gq_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)du_);
                    Timing gr_ = gq_?.Timing;
                    Timing.RepeatComponent gs_ = gr_?.Repeat;
                    Code<Timing.UnitsOfTime> gt_ = gs_?.PeriodUnitElement;
                    Timing.UnitsOfTime? gu_ = gt_?.Value;
                    string gv_ = context.Operators.Convert<string>(gu_);
                    CqlQuantity gw_ = this.Quantity(context, go_, gv_);
                    decimal? gx_ = this.ToDaily(context, gc_ ?? gi_, gw_);
                    Dosage gz_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)du_);
                    Timing ha_ = gz_?.Timing;
                    Timing.RepeatComponent hb_ = ha_?.Repeat;
                    List<Time> hc_ = hb_?.TimeOfDayElement;

                    string hd_(Time @this) {
                        string hw_ = @this?.Value;
                        return hw_;
                    }

                    IEnumerable<string> he_ = context.Operators.Select<Time, string>((IEnumerable<Time>)hc_, hd_);

                    CqlTime hf_(string @string) {
                        CqlTime hx_ = context.Operators.ConvertStringToTime(@string);
                        return hx_;
                    }

                    IEnumerable<CqlTime> hg_ = context.Operators.Select<string, CqlTime>(he_, hf_);
                    int? hh_ = context.Operators.Count<CqlTime>(hg_);
                    decimal? hi_ = context.Operators.ConvertIntegerToDecimal(hh_);
                    decimal? hj_ = context.Operators.Multiply(fw_, (gx_ ?? hi_) ?? 1.0m);
                    decimal? hk_ = context.Operators.Divide(fi_, hj_);
                    UnsignedInt hm_ = ef_?.NumberOfRepeatsAllowedElement;
                    int? hn_ = hm_?.Value;
                    int? ho_ = context.Operators.Add(1, hn_ ?? 0);
                    decimal? hp_ = context.Operators.ConvertIntegerToDecimal(ho_);
                    decimal? hq_ = context.Operators.Multiply(fe_ ?? hk_, hp_);
                    decimal? hr_ = context.Operators.ConvertIntegerToDecimal(1);
                    decimal? hs_ = context.Operators.Subtract(hq_, hr_);
                    CqlQuantity ht_ = this.Quantity(context, hs_, "day");
                    CqlDate hu_ = context.Operators.Add((er_ ?? eu_) ?? ez_, ht_);
                    CqlInterval<CqlDate> hv_ = context.Operators.Interval((eb_ ?? ee_) ?? ej_, hu_, true, true);
                    return hv_;
                }
                else if (h_())
                {
                    List<Dosage> hy_ = R?.DosageInstruction;
                    Dosage hz_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)hy_);
                    Timing ia_ = hz_?.Timing;
                    Timing.RepeatComponent ib_ = ia_?.Repeat;
                    DataType ic_ = ib_?.Bounds;
                    object id_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ic_);
                    CqlDateTime ie_ = context.Operators.Start(id_ as CqlInterval<CqlDateTime>);
                    CqlDate if_ = context.Operators.DateFrom(ie_);
                    FhirDateTime ig_ = R?.AuthoredOnElement;
                    CqlDateTime ih_ = context.Operators.Convert<CqlDateTime>(ig_);
                    CqlDate ii_ = context.Operators.DateFrom(ih_);
                    MedicationRequest.DispenseRequestComponent ij_ = R?.DispenseRequest;
                    Period ik_ = ij_?.ValidityPeriod;
                    CqlInterval<CqlDateTime> il_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ik_);
                    CqlDateTime im_ = context.Operators.Start(il_);
                    CqlDate in_ = context.Operators.DateFrom(im_);
                    Dosage ip_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)hy_);
                    Timing iq_ = ip_?.Timing;
                    Timing.RepeatComponent ir_ = iq_?.Repeat;
                    DataType is_ = ir_?.Bounds;
                    object it_ = FHIRHelpers_4_4_000.Instance.ToValue(context, is_);
                    CqlDateTime iu_ = context.Operators.End(it_ as CqlInterval<CqlDateTime>);
                    CqlDate iv_ = context.Operators.DateFrom(iu_);
                    CqlInterval<CqlDate> iw_ = context.Operators.Interval((if_ ?? ii_) ?? in_, iv_, true, true);
                    return iw_;
                }
                else
                {
                    return null as CqlInterval<CqlDate>;
                };
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
                    Duration aa_ = t_?.ExpectedSupplyDuration;
                    CqlQuantity ab_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, aa_);
                    CqlQuantity ac_ = context.Operators.ConvertQuantity(ab_, "d");
                    decimal? ad_ = ac_?.value;
                    Quantity af_ = t_?.Quantity;
                    CqlQuantity ag_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, af_);
                    decimal? ah_ = ag_?.value;
                    Dosage aj_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)i_);
                    List<Dosage.DoseAndRateComponent> ak_ = aj_?.DoseAndRate;
                    Dosage.DoseAndRateComponent al_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)ak_);
                    DataType am_ = al_?.Dose;
                    object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                    CqlQuantity ao_ = context.Operators.End(an_ as CqlInterval<CqlQuantity>);
                    Dosage aq_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)i_);
                    List<Dosage.DoseAndRateComponent> ar_ = aq_?.DoseAndRate;
                    Dosage.DoseAndRateComponent as_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)ar_);
                    DataType at_ = as_?.Dose;
                    object au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
                    decimal? av_ = (ao_ ?? au_ as CqlQuantity)?.value;
                    Dosage ax_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)i_);
                    Timing ay_ = ax_?.Timing;
                    Timing.RepeatComponent az_ = ay_?.Repeat;
                    PositiveInt ba_ = az_?.FrequencyMaxElement;
                    int? bb_ = ba_?.Value;
                    Dosage bd_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)i_);
                    Timing be_ = bd_?.Timing;
                    Timing.RepeatComponent bf_ = be_?.Repeat;
                    PositiveInt bg_ = bf_?.FrequencyElement;
                    int? bh_ = bg_?.Value;
                    Dosage bj_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)i_);
                    Timing bk_ = bj_?.Timing;
                    Timing.RepeatComponent bl_ = bk_?.Repeat;
                    FhirDecimal bm_ = bl_?.PeriodElement;
                    decimal? bn_ = bm_?.Value;
                    Dosage bp_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)i_);
                    Timing bq_ = bp_?.Timing;
                    Timing.RepeatComponent br_ = bq_?.Repeat;
                    Code<Timing.UnitsOfTime> bs_ = br_?.PeriodUnitElement;
                    Timing.UnitsOfTime? bt_ = bs_?.Value;
                    string bu_ = context.Operators.Convert<string>(bt_);
                    CqlQuantity bv_ = this.Quantity(context, bn_, bu_);
                    decimal? bw_ = this.ToDaily(context, bb_ ?? bh_, bv_);
                    Dosage by_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)i_);
                    Timing bz_ = by_?.Timing;
                    Timing.RepeatComponent ca_ = bz_?.Repeat;
                    List<Time> cb_ = ca_?.TimeOfDayElement;

                    string cc_(Time @this) {
                        string cs_ = @this?.Value;
                        return cs_;
                    }

                    IEnumerable<string> cd_ = context.Operators.Select<Time, string>((IEnumerable<Time>)cb_, cc_);

                    CqlTime ce_(string @string) {
                        CqlTime ct_ = context.Operators.ConvertStringToTime(@string);
                        return ct_;
                    }

                    IEnumerable<CqlTime> cf_ = context.Operators.Select<string, CqlTime>(cd_, ce_);
                    int? cg_ = context.Operators.Count<CqlTime>(cf_);
                    decimal? ch_ = context.Operators.ConvertIntegerToDecimal(cg_);
                    decimal? ci_ = context.Operators.Multiply(av_, (bw_ ?? ch_) ?? 1.0m);
                    decimal? cj_ = context.Operators.Divide(ah_, ci_);
                    UnsignedInt cl_ = t_?.NumberOfRepeatsAllowedElement;
                    int? cm_ = cl_?.Value;
                    int? cn_ = context.Operators.Add(1, cm_ ?? 0);
                    decimal? co_ = context.Operators.ConvertIntegerToDecimal(cn_);
                    decimal? cp_ = context.Operators.Multiply(ad_ ?? cj_, co_);
                    bool? cq_ = context.Operators.Not((bool?)(cp_ is null));
                    bool? cr_ = context.Operators.And(y_, cq_);
                    return cr_ ?? false;
                }


                bool h_() {
                    List<Dosage> cu_ = R?.DosageInstruction;
                    Dosage cv_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)cu_);
                    Timing cw_ = cv_?.Timing;
                    Timing.RepeatComponent cx_ = cw_?.Repeat;
                    DataType cy_ = cx_?.Bounds;
                    object cz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cy_);
                    CqlDateTime da_ = context.Operators.Start(cz_ as CqlInterval<CqlDateTime>);
                    CqlDate db_ = context.Operators.DateFrom(da_);
                    FhirDateTime dc_ = R?.AuthoredOnElement;
                    CqlDateTime dd_ = context.Operators.Convert<CqlDateTime>(dc_);
                    CqlDate de_ = context.Operators.DateFrom(dd_);
                    MedicationRequest.DispenseRequestComponent df_ = R?.DispenseRequest;
                    Period dg_ = df_?.ValidityPeriod;
                    CqlInterval<CqlDateTime> dh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dg_);
                    CqlDateTime di_ = context.Operators.Start(dh_);
                    CqlDate dj_ = context.Operators.DateFrom(di_);
                    bool? dk_ = context.Operators.Not((bool?)(((db_ ?? de_) ?? dj_) is null));
                    Dosage dm_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)cu_);
                    Timing dn_ = dm_?.Timing;
                    Timing.RepeatComponent do_ = dn_?.Repeat;
                    DataType dp_ = do_?.Bounds;
                    object dq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dp_);
                    CqlDateTime dr_ = (dq_ as CqlInterval<CqlDateTime>)?.high;
                    bool? ds_ = context.Operators.Not((bool?)(dr_ is null));
                    bool? dt_ = context.Operators.And(dk_, ds_);
                    return dt_ ?? false;
                }

                if (g_())
                {
                    List<Dosage> du_ = R?.DosageInstruction;
                    Dosage dv_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)du_);
                    Timing dw_ = dv_?.Timing;
                    Timing.RepeatComponent dx_ = dw_?.Repeat;
                    DataType dy_ = dx_?.Bounds;
                    object dz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dy_);
                    CqlDateTime ea_ = context.Operators.Start(dz_ as CqlInterval<CqlDateTime>);
                    CqlDate eb_ = context.Operators.DateFrom(ea_);
                    FhirDateTime ec_ = R?.AuthoredOnElement;
                    CqlDateTime ed_ = context.Operators.Convert<CqlDateTime>(ec_);
                    CqlDate ee_ = context.Operators.DateFrom(ed_);
                    MedicationRequest.DispenseRequestComponent ef_ = R?.DispenseRequest;
                    Period eg_ = ef_?.ValidityPeriod;
                    CqlInterval<CqlDateTime> eh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, eg_);
                    CqlDateTime ei_ = context.Operators.Start(eh_);
                    CqlDate ej_ = context.Operators.DateFrom(ei_);
                    Dosage el_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)du_);
                    Timing em_ = el_?.Timing;
                    Timing.RepeatComponent en_ = em_?.Repeat;
                    DataType eo_ = en_?.Bounds;
                    object ep_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eo_);
                    CqlDateTime eq_ = context.Operators.Start(ep_ as CqlInterval<CqlDateTime>);
                    CqlDate er_ = context.Operators.DateFrom(eq_);
                    CqlDateTime et_ = context.Operators.Convert<CqlDateTime>(ec_);
                    CqlDate eu_ = context.Operators.DateFrom(et_);
                    Period ew_ = ef_?.ValidityPeriod;
                    CqlInterval<CqlDateTime> ex_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ew_);
                    CqlDateTime ey_ = context.Operators.Start(ex_);
                    CqlDate ez_ = context.Operators.DateFrom(ey_);
                    Duration fb_ = ef_?.ExpectedSupplyDuration;
                    CqlQuantity fc_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, fb_);
                    CqlQuantity fd_ = context.Operators.ConvertQuantity(fc_, "d");
                    decimal? fe_ = fd_?.value;
                    Quantity fg_ = ef_?.Quantity;
                    CqlQuantity fh_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, fg_);
                    decimal? fi_ = fh_?.value;
                    Dosage fk_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)du_);
                    List<Dosage.DoseAndRateComponent> fl_ = fk_?.DoseAndRate;
                    Dosage.DoseAndRateComponent fm_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)fl_);
                    DataType fn_ = fm_?.Dose;
                    object fo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fn_);
                    CqlQuantity fp_ = context.Operators.End(fo_ as CqlInterval<CqlQuantity>);
                    Dosage fr_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)du_);
                    List<Dosage.DoseAndRateComponent> fs_ = fr_?.DoseAndRate;
                    Dosage.DoseAndRateComponent ft_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)fs_);
                    DataType fu_ = ft_?.Dose;
                    object fv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fu_);
                    decimal? fw_ = (fp_ ?? fv_ as CqlQuantity)?.value;
                    Dosage fy_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)du_);
                    Timing fz_ = fy_?.Timing;
                    Timing.RepeatComponent ga_ = fz_?.Repeat;
                    PositiveInt gb_ = ga_?.FrequencyMaxElement;
                    int? gc_ = gb_?.Value;
                    Dosage ge_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)du_);
                    Timing gf_ = ge_?.Timing;
                    Timing.RepeatComponent gg_ = gf_?.Repeat;
                    PositiveInt gh_ = gg_?.FrequencyElement;
                    int? gi_ = gh_?.Value;
                    Dosage gk_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)du_);
                    Timing gl_ = gk_?.Timing;
                    Timing.RepeatComponent gm_ = gl_?.Repeat;
                    FhirDecimal gn_ = gm_?.PeriodElement;
                    decimal? go_ = gn_?.Value;
                    Dosage gq_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)du_);
                    Timing gr_ = gq_?.Timing;
                    Timing.RepeatComponent gs_ = gr_?.Repeat;
                    Code<Timing.UnitsOfTime> gt_ = gs_?.PeriodUnitElement;
                    Timing.UnitsOfTime? gu_ = gt_?.Value;
                    string gv_ = context.Operators.Convert<string>(gu_);
                    CqlQuantity gw_ = this.Quantity(context, go_, gv_);
                    decimal? gx_ = this.ToDaily(context, gc_ ?? gi_, gw_);
                    Dosage gz_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)du_);
                    Timing ha_ = gz_?.Timing;
                    Timing.RepeatComponent hb_ = ha_?.Repeat;
                    List<Time> hc_ = hb_?.TimeOfDayElement;

                    string hd_(Time @this) {
                        string hw_ = @this?.Value;
                        return hw_;
                    }

                    IEnumerable<string> he_ = context.Operators.Select<Time, string>((IEnumerable<Time>)hc_, hd_);

                    CqlTime hf_(string @string) {
                        CqlTime hx_ = context.Operators.ConvertStringToTime(@string);
                        return hx_;
                    }

                    IEnumerable<CqlTime> hg_ = context.Operators.Select<string, CqlTime>(he_, hf_);
                    int? hh_ = context.Operators.Count<CqlTime>(hg_);
                    decimal? hi_ = context.Operators.ConvertIntegerToDecimal(hh_);
                    decimal? hj_ = context.Operators.Multiply(fw_, (gx_ ?? hi_) ?? 1.0m);
                    decimal? hk_ = context.Operators.Divide(fi_, hj_);
                    UnsignedInt hm_ = ef_?.NumberOfRepeatsAllowedElement;
                    int? hn_ = hm_?.Value;
                    int? ho_ = context.Operators.Add(1, hn_ ?? 0);
                    decimal? hp_ = context.Operators.ConvertIntegerToDecimal(ho_);
                    decimal? hq_ = context.Operators.Multiply(fe_ ?? hk_, hp_);
                    decimal? hr_ = context.Operators.ConvertIntegerToDecimal(1);
                    decimal? hs_ = context.Operators.Subtract(hq_, hr_);
                    CqlQuantity ht_ = this.Quantity(context, hs_, "day");
                    CqlDate hu_ = context.Operators.Add((er_ ?? eu_) ?? ez_, ht_);
                    CqlInterval<CqlDate> hv_ = context.Operators.Interval((eb_ ?? ee_) ?? ej_, hu_, true, true);
                    return hv_;
                }
                else if (h_())
                {
                    List<Dosage> hy_ = R?.DosageInstruction;
                    Dosage hz_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)hy_);
                    Timing ia_ = hz_?.Timing;
                    Timing.RepeatComponent ib_ = ia_?.Repeat;
                    DataType ic_ = ib_?.Bounds;
                    object id_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ic_);
                    CqlDateTime ie_ = context.Operators.Start(id_ as CqlInterval<CqlDateTime>);
                    CqlDate if_ = context.Operators.DateFrom(ie_);
                    FhirDateTime ig_ = R?.AuthoredOnElement;
                    CqlDateTime ih_ = context.Operators.Convert<CqlDateTime>(ig_);
                    CqlDate ii_ = context.Operators.DateFrom(ih_);
                    MedicationRequest.DispenseRequestComponent ij_ = R?.DispenseRequest;
                    Period ik_ = ij_?.ValidityPeriod;
                    CqlInterval<CqlDateTime> il_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ik_);
                    CqlDateTime im_ = context.Operators.Start(il_);
                    CqlDate in_ = context.Operators.DateFrom(im_);
                    Dosage ip_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)hy_);
                    Timing iq_ = ip_?.Timing;
                    Timing.RepeatComponent ir_ = iq_?.Repeat;
                    DataType is_ = ir_?.Bounds;
                    object it_ = FHIRHelpers_4_4_000.Instance.ToValue(context, is_);
                    CqlDateTime iu_ = context.Operators.End(it_ as CqlInterval<CqlDateTime>);
                    CqlDate iv_ = context.Operators.DateFrom(iu_);
                    CqlInterval<CqlDate> iw_ = context.Operators.Interval((if_ ?? ii_) ?? in_, iv_, true, true);
                    return iw_;
                }
                else
                {
                    return null as CqlInterval<CqlDate>;
                };
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
                    Dosage ad_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)v_);
                    List<Dosage.DoseAndRateComponent> ae_ = ad_?.DoseAndRate;
                    Dosage.DoseAndRateComponent af_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)ae_);
                    DataType ag_ = af_?.Dose;
                    object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                    decimal? ai_ = (ab_ ?? ah_ as CqlQuantity)?.value;
                    Dosage ak_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)v_);
                    Timing al_ = ak_?.Timing;
                    Timing.RepeatComponent am_ = al_?.Repeat;
                    PositiveInt an_ = am_?.FrequencyMaxElement;
                    int? ao_ = an_?.Value;
                    Dosage aq_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)v_);
                    Timing ar_ = aq_?.Timing;
                    Timing.RepeatComponent as_ = ar_?.Repeat;
                    PositiveInt at_ = as_?.FrequencyElement;
                    int? au_ = at_?.Value;
                    Dosage aw_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)v_);
                    Timing ax_ = aw_?.Timing;
                    Timing.RepeatComponent ay_ = ax_?.Repeat;
                    FhirDecimal az_ = ay_?.PeriodElement;
                    decimal? ba_ = az_?.Value;
                    Dosage bc_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)v_);
                    Timing bd_ = bc_?.Timing;
                    Timing.RepeatComponent be_ = bd_?.Repeat;
                    Code<Timing.UnitsOfTime> bf_ = be_?.PeriodUnitElement;
                    Timing.UnitsOfTime? bg_ = bf_?.Value;
                    string bh_ = context.Operators.Convert<string>(bg_);
                    CqlQuantity bi_ = this.Quantity(context, ba_, bh_);
                    decimal? bj_ = this.ToDaily(context, ao_ ?? au_, bi_);
                    Dosage bl_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)v_);
                    Timing bm_ = bl_?.Timing;
                    Timing.RepeatComponent bn_ = bm_?.Repeat;
                    List<Time> bo_ = bn_?.TimeOfDayElement;

                    string bp_(Time @this) {
                        string bz_ = @this?.Value;
                        return bz_;
                    }

                    IEnumerable<string> bq_ = context.Operators.Select<Time, string>((IEnumerable<Time>)bo_, bp_);

                    CqlTime br_(string @string) {
                        CqlTime ca_ = context.Operators.ConvertStringToTime(@string);
                        return ca_;
                    }

                    IEnumerable<CqlTime> bs_ = context.Operators.Select<string, CqlTime>(bq_, br_);
                    int? bt_ = context.Operators.Count<CqlTime>(bs_);
                    decimal? bu_ = context.Operators.ConvertIntegerToDecimal(bt_);
                    decimal? bv_ = context.Operators.Multiply(ai_, (bj_ ?? bu_) ?? 1.0m);
                    decimal? bw_ = context.Operators.Divide(u_, bv_);
                    bool? bx_ = context.Operators.Not((bool?)((r_ ?? bw_) is null));
                    bool? by_ = context.Operators.And(n_, bx_);
                    return by_ ?? false;
                }

                if (g_())
                {
                    FhirDateTime cb_ = D?.WhenHandedOverElement;
                    CqlDateTime cc_ = context.Operators.Convert<CqlDateTime>(cb_);
                    CqlDate cd_ = context.Operators.DateFrom(cc_);
                    FhirDateTime ce_ = D?.WhenPreparedElement;
                    CqlDateTime cf_ = context.Operators.Convert<CqlDateTime>(ce_);
                    CqlDate cg_ = context.Operators.DateFrom(cf_);
                    CqlDateTime ci_ = context.Operators.Convert<CqlDateTime>(cb_);
                    CqlDate cj_ = context.Operators.DateFrom(ci_);
                    CqlDateTime cl_ = context.Operators.Convert<CqlDateTime>(ce_);
                    CqlDate cm_ = context.Operators.DateFrom(cl_);
                    Quantity cn_ = D?.DaysSupply;
                    CqlQuantity co_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, cn_);
                    CqlQuantity cp_ = context.Operators.ConvertQuantity(co_, "d");
                    decimal? cq_ = cp_?.value;
                    Quantity cr_ = D?.Quantity;
                    CqlQuantity cs_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, cr_);
                    decimal? ct_ = cs_?.value;
                    List<Dosage> cu_ = D?.DosageInstruction;
                    Dosage cv_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)cu_);
                    List<Dosage.DoseAndRateComponent> cw_ = cv_?.DoseAndRate;
                    Dosage.DoseAndRateComponent cx_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)cw_);
                    DataType cy_ = cx_?.Dose;
                    object cz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cy_);
                    CqlQuantity da_ = context.Operators.End(cz_ as CqlInterval<CqlQuantity>);
                    Dosage dc_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)cu_);
                    List<Dosage.DoseAndRateComponent> dd_ = dc_?.DoseAndRate;
                    Dosage.DoseAndRateComponent de_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)dd_);
                    DataType df_ = de_?.Dose;
                    object dg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, df_);
                    decimal? dh_ = (da_ ?? dg_ as CqlQuantity)?.value;
                    Dosage dj_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)cu_);
                    Timing dk_ = dj_?.Timing;
                    Timing.RepeatComponent dl_ = dk_?.Repeat;
                    PositiveInt dm_ = dl_?.FrequencyMaxElement;
                    int? dn_ = dm_?.Value;
                    Dosage dp_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)cu_);
                    Timing dq_ = dp_?.Timing;
                    Timing.RepeatComponent dr_ = dq_?.Repeat;
                    PositiveInt ds_ = dr_?.FrequencyElement;
                    int? dt_ = ds_?.Value;
                    Dosage dv_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)cu_);
                    Timing dw_ = dv_?.Timing;
                    Timing.RepeatComponent dx_ = dw_?.Repeat;
                    FhirDecimal dy_ = dx_?.PeriodElement;
                    decimal? dz_ = dy_?.Value;
                    Dosage eb_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)cu_);
                    Timing ec_ = eb_?.Timing;
                    Timing.RepeatComponent ed_ = ec_?.Repeat;
                    Code<Timing.UnitsOfTime> ee_ = ed_?.PeriodUnitElement;
                    Timing.UnitsOfTime? ef_ = ee_?.Value;
                    string eg_ = context.Operators.Convert<string>(ef_);
                    CqlQuantity eh_ = this.Quantity(context, dz_, eg_);
                    decimal? ei_ = this.ToDaily(context, dn_ ?? dt_, eh_);
                    Dosage ek_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)cu_);
                    Timing el_ = ek_?.Timing;
                    Timing.RepeatComponent em_ = el_?.Repeat;
                    List<Time> en_ = em_?.TimeOfDayElement;

                    string eo_(Time @this) {
                        string fb_ = @this?.Value;
                        return fb_;
                    }

                    IEnumerable<string> ep_ = context.Operators.Select<Time, string>((IEnumerable<Time>)en_, eo_);

                    CqlTime eq_(string @string) {
                        CqlTime fc_ = context.Operators.ConvertStringToTime(@string);
                        return fc_;
                    }

                    IEnumerable<CqlTime> er_ = context.Operators.Select<string, CqlTime>(ep_, eq_);
                    int? es_ = context.Operators.Count<CqlTime>(er_);
                    decimal? et_ = context.Operators.ConvertIntegerToDecimal(es_);
                    decimal? eu_ = context.Operators.Multiply(dh_, (ei_ ?? et_) ?? 1.0m);
                    decimal? ev_ = context.Operators.Divide(ct_, eu_);
                    decimal? ew_ = context.Operators.ConvertIntegerToDecimal(1);
                    decimal? ex_ = context.Operators.Subtract(cq_ ?? ev_, ew_);
                    CqlQuantity ey_ = this.Quantity(context, ex_, "day");
                    CqlDate ez_ = context.Operators.Add(cj_ ?? cm_, ey_);
                    CqlInterval<CqlDate> fa_ = context.Operators.Interval(cd_ ?? cg_, ez_, true, true);
                    return fa_;
                }
                else
                {
                    return null as CqlInterval<CqlDate>;
                };
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
                    Dosage ad_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)v_);
                    List<Dosage.DoseAndRateComponent> ae_ = ad_?.DoseAndRate;
                    Dosage.DoseAndRateComponent af_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)ae_);
                    DataType ag_ = af_?.Dose;
                    object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                    decimal? ai_ = (ab_ ?? ah_ as CqlQuantity)?.value;
                    Dosage ak_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)v_);
                    Timing al_ = ak_?.Timing;
                    Timing.RepeatComponent am_ = al_?.Repeat;
                    PositiveInt an_ = am_?.FrequencyMaxElement;
                    int? ao_ = an_?.Value;
                    Dosage aq_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)v_);
                    Timing ar_ = aq_?.Timing;
                    Timing.RepeatComponent as_ = ar_?.Repeat;
                    PositiveInt at_ = as_?.FrequencyElement;
                    int? au_ = at_?.Value;
                    Dosage aw_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)v_);
                    Timing ax_ = aw_?.Timing;
                    Timing.RepeatComponent ay_ = ax_?.Repeat;
                    FhirDecimal az_ = ay_?.PeriodElement;
                    decimal? ba_ = az_?.Value;
                    Dosage bc_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)v_);
                    Timing bd_ = bc_?.Timing;
                    Timing.RepeatComponent be_ = bd_?.Repeat;
                    Code<Timing.UnitsOfTime> bf_ = be_?.PeriodUnitElement;
                    Timing.UnitsOfTime? bg_ = bf_?.Value;
                    string bh_ = context.Operators.Convert<string>(bg_);
                    CqlQuantity bi_ = this.Quantity(context, ba_, bh_);
                    decimal? bj_ = this.ToDaily(context, ao_ ?? au_, bi_);
                    Dosage bl_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)v_);
                    Timing bm_ = bl_?.Timing;
                    Timing.RepeatComponent bn_ = bm_?.Repeat;
                    List<Time> bo_ = bn_?.TimeOfDayElement;

                    string bp_(Time @this) {
                        string bz_ = @this?.Value;
                        return bz_;
                    }

                    IEnumerable<string> bq_ = context.Operators.Select<Time, string>((IEnumerable<Time>)bo_, bp_);

                    CqlTime br_(string @string) {
                        CqlTime ca_ = context.Operators.ConvertStringToTime(@string);
                        return ca_;
                    }

                    IEnumerable<CqlTime> bs_ = context.Operators.Select<string, CqlTime>(bq_, br_);
                    int? bt_ = context.Operators.Count<CqlTime>(bs_);
                    decimal? bu_ = context.Operators.ConvertIntegerToDecimal(bt_);
                    decimal? bv_ = context.Operators.Multiply(ai_, (bj_ ?? bu_) ?? 1.0m);
                    decimal? bw_ = context.Operators.Divide(u_, bv_);
                    bool? bx_ = context.Operators.Not((bool?)((r_ ?? bw_) is null));
                    bool? by_ = context.Operators.And(n_, bx_);
                    return by_ ?? false;
                }

                if (g_())
                {
                    FhirDateTime cb_ = D?.WhenHandedOverElement;
                    CqlDateTime cc_ = context.Operators.Convert<CqlDateTime>(cb_);
                    CqlDate cd_ = context.Operators.DateFrom(cc_);
                    FhirDateTime ce_ = D?.WhenPreparedElement;
                    CqlDateTime cf_ = context.Operators.Convert<CqlDateTime>(ce_);
                    CqlDate cg_ = context.Operators.DateFrom(cf_);
                    CqlDateTime ci_ = context.Operators.Convert<CqlDateTime>(cb_);
                    CqlDate cj_ = context.Operators.DateFrom(ci_);
                    CqlDateTime cl_ = context.Operators.Convert<CqlDateTime>(ce_);
                    CqlDate cm_ = context.Operators.DateFrom(cl_);
                    Quantity cn_ = D?.DaysSupply;
                    CqlQuantity co_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, cn_);
                    CqlQuantity cp_ = context.Operators.ConvertQuantity(co_, "d");
                    decimal? cq_ = cp_?.value;
                    Quantity cr_ = D?.Quantity;
                    CqlQuantity cs_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, cr_);
                    decimal? ct_ = cs_?.value;
                    List<Dosage> cu_ = D?.DosageInstruction;
                    Dosage cv_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)cu_);
                    List<Dosage.DoseAndRateComponent> cw_ = cv_?.DoseAndRate;
                    Dosage.DoseAndRateComponent cx_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)cw_);
                    DataType cy_ = cx_?.Dose;
                    object cz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cy_);
                    CqlQuantity da_ = context.Operators.End(cz_ as CqlInterval<CqlQuantity>);
                    Dosage dc_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)cu_);
                    List<Dosage.DoseAndRateComponent> dd_ = dc_?.DoseAndRate;
                    Dosage.DoseAndRateComponent de_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)dd_);
                    DataType df_ = de_?.Dose;
                    object dg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, df_);
                    decimal? dh_ = (da_ ?? dg_ as CqlQuantity)?.value;
                    Dosage dj_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)cu_);
                    Timing dk_ = dj_?.Timing;
                    Timing.RepeatComponent dl_ = dk_?.Repeat;
                    PositiveInt dm_ = dl_?.FrequencyMaxElement;
                    int? dn_ = dm_?.Value;
                    Dosage dp_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)cu_);
                    Timing dq_ = dp_?.Timing;
                    Timing.RepeatComponent dr_ = dq_?.Repeat;
                    PositiveInt ds_ = dr_?.FrequencyElement;
                    int? dt_ = ds_?.Value;
                    Dosage dv_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)cu_);
                    Timing dw_ = dv_?.Timing;
                    Timing.RepeatComponent dx_ = dw_?.Repeat;
                    FhirDecimal dy_ = dx_?.PeriodElement;
                    decimal? dz_ = dy_?.Value;
                    Dosage eb_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)cu_);
                    Timing ec_ = eb_?.Timing;
                    Timing.RepeatComponent ed_ = ec_?.Repeat;
                    Code<Timing.UnitsOfTime> ee_ = ed_?.PeriodUnitElement;
                    Timing.UnitsOfTime? ef_ = ee_?.Value;
                    string eg_ = context.Operators.Convert<string>(ef_);
                    CqlQuantity eh_ = this.Quantity(context, dz_, eg_);
                    decimal? ei_ = this.ToDaily(context, dn_ ?? dt_, eh_);
                    Dosage ek_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)cu_);
                    Timing el_ = ek_?.Timing;
                    Timing.RepeatComponent em_ = el_?.Repeat;
                    List<Time> en_ = em_?.TimeOfDayElement;

                    string eo_(Time @this) {
                        string fb_ = @this?.Value;
                        return fb_;
                    }

                    IEnumerable<string> ep_ = context.Operators.Select<Time, string>((IEnumerable<Time>)en_, eo_);

                    CqlTime eq_(string @string) {
                        CqlTime fc_ = context.Operators.ConvertStringToTime(@string);
                        return fc_;
                    }

                    IEnumerable<CqlTime> er_ = context.Operators.Select<string, CqlTime>(ep_, eq_);
                    int? es_ = context.Operators.Count<CqlTime>(er_);
                    decimal? et_ = context.Operators.ConvertIntegerToDecimal(es_);
                    decimal? eu_ = context.Operators.Multiply(dh_, (ei_ ?? et_) ?? 1.0m);
                    decimal? ev_ = context.Operators.Divide(ct_, eu_);
                    decimal? ew_ = context.Operators.ConvertIntegerToDecimal(1);
                    decimal? ex_ = context.Operators.Subtract(cq_ ?? ev_, ew_);
                    CqlQuantity ey_ = this.Quantity(context, ex_, "day");
                    CqlDate ez_ = context.Operators.Add(cj_ ?? cm_, ey_);
                    CqlInterval<CqlDate> fa_ = context.Operators.Interval(cd_ ?? cg_, ez_, true, true);
                    return fa_;
                }
                else
                {
                    return null as CqlInterval<CqlDate>;
                };
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
                    object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
                    CqlDateTime x_ = context.Operators.Start(w_ as CqlInterval<CqlDateTime>);
                    CqlDate y_ = context.Operators.DateFrom(x_);
                    DataType z_ = Administration?.Medication;
                    object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
                    CqlQuantity ab_ = this.TherapeuticDuration(context, aa_ as CqlConcept);
                    CqlDate ac_ = context.Operators.Add(y_, ab_);
                    CqlQuantity ad_ = context.Operators.ConvertIntegerToQuantity(1);
                    CqlDate ae_ = context.Operators.Subtract(ac_, ad_);
                    CqlInterval<CqlDate> af_ = context.Operators.Interval(u_, ae_, true, true);
                    return af_;
                }
                else
                {
                    return null as CqlInterval<CqlDate>;
                };
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
                    object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
                    CqlDateTime x_ = context.Operators.Start(w_ as CqlInterval<CqlDateTime>);
                    CqlDate y_ = context.Operators.DateFrom(x_);
                    DataType z_ = Administration?.Medication;
                    object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
                    CqlQuantity ab_ = this.TherapeuticDuration(context, aa_ as CqlConcept);
                    CqlDate ac_ = context.Operators.Add(y_, ab_);
                    CqlQuantity ad_ = context.Operators.ConvertIntegerToQuantity(1);
                    CqlDate ae_ = context.Operators.Subtract(ac_, ad_);
                    CqlInterval<CqlDate> af_ = context.Operators.Interval(u_, ae_, true, true);
                    return af_;
                }
                else
                {
                    return null as CqlInterval<CqlDate>;
                };
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
            };
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
            };
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
                CqlDate r_ = context.Operators.End(j_);
                CqlDate t_ = context.Operators.Add(r_, l_);
                CqlDate[] v_ = [
                    t_,
                    n_,
                ];
                CqlDate w_ = context.Operators.Max<CqlDate>((IEnumerable<CqlDate>)v_);
                CqlDate y_ = context.Operators.End(X);
                int? z_ = context.Operators.DurationBetween(n_, y_, "day");
                decimal? aa_ = context.Operators.ConvertIntegerToDecimal(z_ ?? 0);
                CqlQuantity ab_ = this.Quantity(context, aa_, "day");
                CqlDate ac_ = context.Operators.Add(w_, ab_);
                CqlInterval<CqlDate> ad_ = context.Operators.Interval(p_, ac_, true, true);
                return ad_;
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
                CqlDate r_ = context.Operators.End(j_);
                CqlDate t_ = context.Operators.Add(r_, l_);
                CqlDate[] v_ = [
                    t_,
                    n_,
                ];
                CqlDate w_ = context.Operators.Max<CqlDate>((IEnumerable<CqlDate>)v_);
                CqlDate y_ = context.Operators.End(X);
                int? z_ = context.Operators.DurationBetween(n_, y_, "day");
                decimal? aa_ = context.Operators.ConvertIntegerToDecimal(z_ ?? 0);
                CqlQuantity ab_ = this.Quantity(context, aa_, "day");
                CqlDate ac_ = context.Operators.Add(w_, ab_);
                CqlInterval<CqlDate> ad_ = context.Operators.Interval(p_, ac_, true, true);
                return ad_;
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
            };
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
            };
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

    #region Cache Index Fields (2)

    private int _cacheIndex_ErrorLevel = -1;
    private int _cacheIndex_Patient = -1;

    #endregion Cache Index Fields

    #region ILibraryInternals Implementation

    private CqlLibraryInvocationCache _cache = CqlLibraryInvocationCache.NeverCached;

    /// <summary>
    /// Initializes cache indices for this library's cached expressions.
    /// </summary>
    /// <param name="libraryInvocationSet">The library invocation set performing initialization.</param>
    /// <param name="startIndex">The starting index for cache field assignment.</param>
    /// <returns>The number of cache indices initialized (number of cached expressions in this library).</returns>
    int ILibraryInternals.InitializeCacheIndices(
        CqlLibraryInvocationSet libraryInvocationSet,
        int startIndex)
    {
        var index = startIndex;
        _cacheIndex_ErrorLevel = index++;
        _cacheIndex_Patient = index++;
        return index - startIndex;
    }

    /// <summary>
    /// Sets the cache instance that this library will use for caching computed values.
    /// </summary>
    /// <param name="cache">The cache instance to use.</param>
    void ILibraryInternals.SetCacheInstance(CqlLibraryInvocationCache cache)
    {
        _cache = cache;
    }

    #endregion ILibraryInternals Implementation

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
