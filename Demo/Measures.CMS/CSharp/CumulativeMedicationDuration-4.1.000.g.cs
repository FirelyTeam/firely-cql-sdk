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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "3.0.0.0")]
[CqlLibrary("CumulativeMedicationDuration", "4.1.000")]
public partial class CumulativeMedicationDuration_4_1_000 : ILibrary, ISingleton<CumulativeMedicationDuration_4_1_000>
{
    private CumulativeMedicationDuration_4_1_000() {}

    public static CumulativeMedicationDuration_4_1_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "CumulativeMedicationDuration";
    public string Version => "4.1.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, QICoreCommon_2_1_000.Instance];

    #endregion ILibrary Implementation

    #region Codes

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

    #region CodeSystems

    [CqlCodeSystemDefinition("V3TimingEvent")]
    public CqlCodeSystem V3TimingEvent(CqlContext _) => _V3TimingEvent;
    private static readonly CqlCodeSystem _V3TimingEvent =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null,
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
          _PCV);

    [CqlCodeSystemDefinition("EventTiming")]
    public CqlCodeSystem EventTiming(CqlContext _) => _EventTiming;
    private static readonly CqlCodeSystem _EventTiming =
      new CqlCodeSystem("http://hl7.org/fhir/event-timing", null,
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
          _PHS);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("ErrorLevel")]
    public string ErrorLevel(CqlContext context)
    {
        object mzzzzzzy_ = context.ResolveParameter("CumulativeMedicationDuration-4.1.000", "ErrorLevel", "Warning");

        return (string)mzzzzzzy_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> mzzzzzzz_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient nzzzzzza_ = context.Operators.SingletonFrom<Patient>(mzzzzzzz_);

        return nzzzzzza_;
    }


    [CqlExpressionDefinition("ToDaily")]
    public decimal? ToDaily(CqlContext context, int? frequency, CqlQuantity period)
    {
        decimal? nzzzzzzb_()
        {
            bool nzzzzzzc_()
            {
                string nzzzzzzx_ = period?.unit;
                bool? nzzzzzzy_ = context.Operators.Equal(nzzzzzzx_, "h");

                return nzzzzzzy_ ?? false;
            };
            bool nzzzzzzd_()
            {
                string nzzzzzzz_ = period?.unit;
                bool? ozzzzzza_ = context.Operators.Equal(nzzzzzzz_, "min");

                return ozzzzzza_ ?? false;
            };
            bool nzzzzzze_()
            {
                string ozzzzzzb_ = period?.unit;
                bool? ozzzzzzc_ = context.Operators.Equal(ozzzzzzb_, "s");

                return ozzzzzzc_ ?? false;
            };
            bool nzzzzzzf_()
            {
                string ozzzzzzd_ = period?.unit;
                bool? ozzzzzze_ = context.Operators.Equal(ozzzzzzd_, "d");

                return ozzzzzze_ ?? false;
            };
            bool nzzzzzzg_()
            {
                string ozzzzzzf_ = period?.unit;
                bool? ozzzzzzg_ = context.Operators.Equal(ozzzzzzf_, "wk");

                return ozzzzzzg_ ?? false;
            };
            bool nzzzzzzh_()
            {
                string ozzzzzzh_ = period?.unit;
                bool? ozzzzzzi_ = context.Operators.Equal(ozzzzzzh_, "mo");

                return ozzzzzzi_ ?? false;
            };
            bool nzzzzzzi_()
            {
                string ozzzzzzj_ = period?.unit;
                bool? ozzzzzzk_ = context.Operators.Equal(ozzzzzzj_, "a");

                return ozzzzzzk_ ?? false;
            };
            bool nzzzzzzj_()
            {
                string ozzzzzzl_ = period?.unit;
                bool? ozzzzzzm_ = context.Operators.Equal(ozzzzzzl_, "hour");

                return ozzzzzzm_ ?? false;
            };
            bool nzzzzzzk_()
            {
                string ozzzzzzn_ = period?.unit;
                bool? ozzzzzzo_ = context.Operators.Equal(ozzzzzzn_, "minute");

                return ozzzzzzo_ ?? false;
            };
            bool nzzzzzzl_()
            {
                string ozzzzzzp_ = period?.unit;
                bool? ozzzzzzq_ = context.Operators.Equal(ozzzzzzp_, "second");

                return ozzzzzzq_ ?? false;
            };
            bool nzzzzzzm_()
            {
                string ozzzzzzr_ = period?.unit;
                bool? ozzzzzzs_ = context.Operators.Equal(ozzzzzzr_, "day");

                return ozzzzzzs_ ?? false;
            };
            bool nzzzzzzn_()
            {
                string ozzzzzzt_ = period?.unit;
                bool? ozzzzzzu_ = context.Operators.Equal(ozzzzzzt_, "week");

                return ozzzzzzu_ ?? false;
            };
            bool nzzzzzzo_()
            {
                string ozzzzzzv_ = period?.unit;
                bool? ozzzzzzw_ = context.Operators.Equal(ozzzzzzv_, "month");

                return ozzzzzzw_ ?? false;
            };
            bool nzzzzzzp_()
            {
                string ozzzzzzx_ = period?.unit;
                bool? ozzzzzzy_ = context.Operators.Equal(ozzzzzzx_, "year");

                return ozzzzzzy_ ?? false;
            };
            bool nzzzzzzq_()
            {
                string ozzzzzzz_ = period?.unit;
                bool? pzzzzzza_ = context.Operators.Equal(ozzzzzzz_, "hours");

                return pzzzzzza_ ?? false;
            };
            bool nzzzzzzr_()
            {
                string pzzzzzzb_ = period?.unit;
                bool? pzzzzzzc_ = context.Operators.Equal(pzzzzzzb_, "minutes");

                return pzzzzzzc_ ?? false;
            };
            bool nzzzzzzs_()
            {
                string pzzzzzzd_ = period?.unit;
                bool? pzzzzzze_ = context.Operators.Equal(pzzzzzzd_, "seconds");

                return pzzzzzze_ ?? false;
            };
            bool nzzzzzzt_()
            {
                string pzzzzzzf_ = period?.unit;
                bool? pzzzzzzg_ = context.Operators.Equal(pzzzzzzf_, "days");

                return pzzzzzzg_ ?? false;
            };
            bool nzzzzzzu_()
            {
                string pzzzzzzh_ = period?.unit;
                bool? pzzzzzzi_ = context.Operators.Equal(pzzzzzzh_, "weeks");

                return pzzzzzzi_ ?? false;
            };
            bool nzzzzzzv_()
            {
                string pzzzzzzj_ = period?.unit;
                bool? pzzzzzzk_ = context.Operators.Equal(pzzzzzzj_, "months");

                return pzzzzzzk_ ?? false;
            };
            bool nzzzzzzw_()
            {
                string pzzzzzzl_ = period?.unit;
                bool? pzzzzzzm_ = context.Operators.Equal(pzzzzzzl_, "years");

                return pzzzzzzm_ ?? false;
            };
            if (nzzzzzzc_())
            {
                decimal? pzzzzzzn_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? pzzzzzzo_ = period?.value;
                decimal? pzzzzzzp_ = context.Operators.Divide(24.0m, pzzzzzzo_);
                decimal? pzzzzzzq_ = context.Operators.Multiply(pzzzzzzn_, pzzzzzzp_);

                return pzzzzzzq_;
            }
            else if (nzzzzzzd_())
            {
                decimal? pzzzzzzr_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? pzzzzzzs_ = period?.value;
                decimal? pzzzzzzt_ = context.Operators.Divide(24.0m, pzzzzzzs_);
                decimal? pzzzzzzu_ = context.Operators.Multiply(pzzzzzzr_, pzzzzzzt_);
                decimal? pzzzzzzv_ = context.Operators.ConvertIntegerToDecimal(60);
                decimal? pzzzzzzw_ = context.Operators.Multiply(pzzzzzzu_, pzzzzzzv_);

                return pzzzzzzw_;
            }
            else if (nzzzzzze_())
            {
                decimal? pzzzzzzx_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? pzzzzzzy_ = period?.value;
                decimal? pzzzzzzz_ = context.Operators.Divide(24.0m, pzzzzzzy_);
                decimal? qzzzzzza_ = context.Operators.Multiply(pzzzzzzx_, pzzzzzzz_);
                decimal? qzzzzzzb_ = context.Operators.ConvertIntegerToDecimal(60);
                decimal? qzzzzzzc_ = context.Operators.Multiply(qzzzzzza_, qzzzzzzb_);
                decimal? qzzzzzze_ = context.Operators.Multiply(qzzzzzzc_, qzzzzzzb_);

                return qzzzzzze_;
            }
            else if (nzzzzzzf_())
            {
                decimal? qzzzzzzf_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? qzzzzzzg_ = period?.value;
                decimal? qzzzzzzh_ = context.Operators.Divide(24.0m, qzzzzzzg_);
                decimal? qzzzzzzi_ = context.Operators.Multiply(qzzzzzzf_, qzzzzzzh_);
                decimal? qzzzzzzj_ = context.Operators.ConvertIntegerToDecimal(24);
                decimal? qzzzzzzk_ = context.Operators.Divide(qzzzzzzi_, qzzzzzzj_);

                return qzzzzzzk_;
            }
            else if (nzzzzzzg_())
            {
                decimal? qzzzzzzl_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? qzzzzzzm_ = period?.value;
                decimal? qzzzzzzn_ = context.Operators.Divide(24.0m, qzzzzzzm_);
                decimal? qzzzzzzo_ = context.Operators.Multiply(qzzzzzzl_, qzzzzzzn_);
                int? qzzzzzzp_ = context.Operators.Multiply(24, 7);
                decimal? qzzzzzzq_ = context.Operators.ConvertIntegerToDecimal(qzzzzzzp_);
                decimal? qzzzzzzr_ = context.Operators.Divide(qzzzzzzo_, qzzzzzzq_);

                return qzzzzzzr_;
            }
            else if (nzzzzzzh_())
            {
                decimal? qzzzzzzs_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? qzzzzzzt_ = period?.value;
                decimal? qzzzzzzu_ = context.Operators.Divide(24.0m, qzzzzzzt_);
                decimal? qzzzzzzv_ = context.Operators.Multiply(qzzzzzzs_, qzzzzzzu_);
                int? qzzzzzzw_ = context.Operators.Multiply(24, 30);
                decimal? qzzzzzzx_ = context.Operators.ConvertIntegerToDecimal(qzzzzzzw_);
                decimal? qzzzzzzy_ = context.Operators.Divide(qzzzzzzv_, qzzzzzzx_);

                return qzzzzzzy_;
            }
            else if (nzzzzzzi_())
            {
                decimal? qzzzzzzz_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? rzzzzzza_ = period?.value;
                decimal? rzzzzzzb_ = context.Operators.Divide(24.0m, rzzzzzza_);
                decimal? rzzzzzzc_ = context.Operators.Multiply(qzzzzzzz_, rzzzzzzb_);
                int? rzzzzzzd_ = context.Operators.Multiply(24, 365);
                decimal? rzzzzzze_ = context.Operators.ConvertIntegerToDecimal(rzzzzzzd_);
                decimal? rzzzzzzf_ = context.Operators.Divide(rzzzzzzc_, rzzzzzze_);

                return rzzzzzzf_;
            }
            else if (nzzzzzzj_())
            {
                decimal? rzzzzzzg_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? rzzzzzzh_ = period?.value;
                decimal? rzzzzzzi_ = context.Operators.Divide(24.0m, rzzzzzzh_);
                decimal? rzzzzzzj_ = context.Operators.Multiply(rzzzzzzg_, rzzzzzzi_);

                return rzzzzzzj_;
            }
            else if (nzzzzzzk_())
            {
                decimal? rzzzzzzk_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? rzzzzzzl_ = period?.value;
                decimal? rzzzzzzm_ = context.Operators.Divide(24.0m, rzzzzzzl_);
                decimal? rzzzzzzn_ = context.Operators.Multiply(rzzzzzzk_, rzzzzzzm_);
                decimal? rzzzzzzo_ = context.Operators.ConvertIntegerToDecimal(60);
                decimal? rzzzzzzp_ = context.Operators.Multiply(rzzzzzzn_, rzzzzzzo_);

                return rzzzzzzp_;
            }
            else if (nzzzzzzl_())
            {
                decimal? rzzzzzzq_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? rzzzzzzr_ = period?.value;
                decimal? rzzzzzzs_ = context.Operators.Divide(24.0m, rzzzzzzr_);
                decimal? rzzzzzzt_ = context.Operators.Multiply(rzzzzzzq_, rzzzzzzs_);
                decimal? rzzzzzzu_ = context.Operators.ConvertIntegerToDecimal(60);
                decimal? rzzzzzzv_ = context.Operators.Multiply(rzzzzzzt_, rzzzzzzu_);
                decimal? rzzzzzzx_ = context.Operators.Multiply(rzzzzzzv_, rzzzzzzu_);

                return rzzzzzzx_;
            }
            else if (nzzzzzzm_())
            {
                decimal? rzzzzzzy_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? rzzzzzzz_ = period?.value;
                decimal? szzzzzza_ = context.Operators.Divide(24.0m, rzzzzzzz_);
                decimal? szzzzzzb_ = context.Operators.Multiply(rzzzzzzy_, szzzzzza_);
                decimal? szzzzzzc_ = context.Operators.ConvertIntegerToDecimal(24);
                decimal? szzzzzzd_ = context.Operators.Divide(szzzzzzb_, szzzzzzc_);

                return szzzzzzd_;
            }
            else if (nzzzzzzn_())
            {
                decimal? szzzzzze_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? szzzzzzf_ = period?.value;
                decimal? szzzzzzg_ = context.Operators.Divide(24.0m, szzzzzzf_);
                decimal? szzzzzzh_ = context.Operators.Multiply(szzzzzze_, szzzzzzg_);
                int? szzzzzzi_ = context.Operators.Multiply(24, 7);
                decimal? szzzzzzj_ = context.Operators.ConvertIntegerToDecimal(szzzzzzi_);
                decimal? szzzzzzk_ = context.Operators.Divide(szzzzzzh_, szzzzzzj_);

                return szzzzzzk_;
            }
            else if (nzzzzzzo_())
            {
                decimal? szzzzzzl_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? szzzzzzm_ = period?.value;
                decimal? szzzzzzn_ = context.Operators.Divide(24.0m, szzzzzzm_);
                decimal? szzzzzzo_ = context.Operators.Multiply(szzzzzzl_, szzzzzzn_);
                int? szzzzzzp_ = context.Operators.Multiply(24, 30);
                decimal? szzzzzzq_ = context.Operators.ConvertIntegerToDecimal(szzzzzzp_);
                decimal? szzzzzzr_ = context.Operators.Divide(szzzzzzo_, szzzzzzq_);

                return szzzzzzr_;
            }
            else if (nzzzzzzp_())
            {
                decimal? szzzzzzs_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? szzzzzzt_ = period?.value;
                decimal? szzzzzzu_ = context.Operators.Divide(24.0m, szzzzzzt_);
                decimal? szzzzzzv_ = context.Operators.Multiply(szzzzzzs_, szzzzzzu_);
                int? szzzzzzw_ = context.Operators.Multiply(24, 365);
                decimal? szzzzzzx_ = context.Operators.ConvertIntegerToDecimal(szzzzzzw_);
                decimal? szzzzzzy_ = context.Operators.Divide(szzzzzzv_, szzzzzzx_);

                return szzzzzzy_;
            }
            else if (nzzzzzzq_())
            {
                decimal? szzzzzzz_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? tzzzzzza_ = period?.value;
                decimal? tzzzzzzb_ = context.Operators.Divide(24.0m, tzzzzzza_);
                decimal? tzzzzzzc_ = context.Operators.Multiply(szzzzzzz_, tzzzzzzb_);

                return tzzzzzzc_;
            }
            else if (nzzzzzzr_())
            {
                decimal? tzzzzzzd_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? tzzzzzze_ = period?.value;
                decimal? tzzzzzzf_ = context.Operators.Divide(24.0m, tzzzzzze_);
                decimal? tzzzzzzg_ = context.Operators.Multiply(tzzzzzzd_, tzzzzzzf_);
                decimal? tzzzzzzh_ = context.Operators.ConvertIntegerToDecimal(60);
                decimal? tzzzzzzi_ = context.Operators.Multiply(tzzzzzzg_, tzzzzzzh_);

                return tzzzzzzi_;
            }
            else if (nzzzzzzs_())
            {
                decimal? tzzzzzzj_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? tzzzzzzk_ = period?.value;
                decimal? tzzzzzzl_ = context.Operators.Divide(24.0m, tzzzzzzk_);
                decimal? tzzzzzzm_ = context.Operators.Multiply(tzzzzzzj_, tzzzzzzl_);
                decimal? tzzzzzzn_ = context.Operators.ConvertIntegerToDecimal(60);
                decimal? tzzzzzzo_ = context.Operators.Multiply(tzzzzzzm_, tzzzzzzn_);
                decimal? tzzzzzzq_ = context.Operators.Multiply(tzzzzzzo_, tzzzzzzn_);

                return tzzzzzzq_;
            }
            else if (nzzzzzzt_())
            {
                decimal? tzzzzzzr_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? tzzzzzzs_ = period?.value;
                decimal? tzzzzzzt_ = context.Operators.Divide(24.0m, tzzzzzzs_);
                decimal? tzzzzzzu_ = context.Operators.Multiply(tzzzzzzr_, tzzzzzzt_);
                decimal? tzzzzzzv_ = context.Operators.ConvertIntegerToDecimal(24);
                decimal? tzzzzzzw_ = context.Operators.Divide(tzzzzzzu_, tzzzzzzv_);

                return tzzzzzzw_;
            }
            else if (nzzzzzzu_())
            {
                decimal? tzzzzzzx_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? tzzzzzzy_ = period?.value;
                decimal? tzzzzzzz_ = context.Operators.Divide(24.0m, tzzzzzzy_);
                decimal? uzzzzzza_ = context.Operators.Multiply(tzzzzzzx_, tzzzzzzz_);
                int? uzzzzzzb_ = context.Operators.Multiply(24, 7);
                decimal? uzzzzzzc_ = context.Operators.ConvertIntegerToDecimal(uzzzzzzb_);
                decimal? uzzzzzzd_ = context.Operators.Divide(uzzzzzza_, uzzzzzzc_);

                return uzzzzzzd_;
            }
            else if (nzzzzzzv_())
            {
                decimal? uzzzzzze_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? uzzzzzzf_ = period?.value;
                decimal? uzzzzzzg_ = context.Operators.Divide(24.0m, uzzzzzzf_);
                decimal? uzzzzzzh_ = context.Operators.Multiply(uzzzzzze_, uzzzzzzg_);
                int? uzzzzzzi_ = context.Operators.Multiply(24, 30);
                decimal? uzzzzzzj_ = context.Operators.ConvertIntegerToDecimal(uzzzzzzi_);
                decimal? uzzzzzzk_ = context.Operators.Divide(uzzzzzzh_, uzzzzzzj_);

                return uzzzzzzk_;
            }
            else if (nzzzzzzw_())
            {
                decimal? uzzzzzzl_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? uzzzzzzm_ = period?.value;
                decimal? uzzzzzzn_ = context.Operators.Divide(24.0m, uzzzzzzm_);
                decimal? uzzzzzzo_ = context.Operators.Multiply(uzzzzzzl_, uzzzzzzn_);
                int? uzzzzzzp_ = context.Operators.Multiply(24, 365);
                decimal? uzzzzzzq_ = context.Operators.ConvertIntegerToDecimal(uzzzzzzp_);
                decimal? uzzzzzzr_ = context.Operators.Divide(uzzzzzzo_, uzzzzzzq_);

                return uzzzzzzr_;
            }
            else
            {
                string uzzzzzzs_ = this.ErrorLevel(context);
                string uzzzzzzt_ = period?.unit;
                string uzzzzzzu_ = context.Operators.Concatenate("Unknown unit ", uzzzzzzt_ ?? "");
                object uzzzzzzv_ = context.Operators.Message<object>(null, "CMDLogic.ToDaily.UnknownUnit", uzzzzzzs_, uzzzzzzu_);

                return uzzzzzzv_ as decimal?;
            }
        };

        return nzzzzzzb_();
    }


    [CqlExpressionDefinition("ToDaily")]
    public decimal? ToDaily(CqlContext context, CqlCode frequency)
    {
        decimal? uzzzzzzw_()
        {
            bool uzzzzzzx_()
            {
                CqlCode wzzzzzzs_ = this.HS(context);
                bool? wzzzzzzt_ = context.Operators.Equivalent(frequency, wzzzzzzs_);

                return wzzzzzzt_ ?? false;
            };
            bool uzzzzzzy_()
            {
                CqlCode wzzzzzzu_ = this.WAKE(context);
                bool? wzzzzzzv_ = context.Operators.Equivalent(frequency, wzzzzzzu_);

                return wzzzzzzv_ ?? false;
            };
            bool uzzzzzzz_()
            {
                CqlCode wzzzzzzw_ = this.C(context);
                bool? wzzzzzzx_ = context.Operators.Equivalent(frequency, wzzzzzzw_);

                return wzzzzzzx_ ?? false;
            };
            bool vzzzzzza_()
            {
                CqlCode wzzzzzzy_ = this.CM(context);
                bool? wzzzzzzz_ = context.Operators.Equivalent(frequency, wzzzzzzy_);

                return wzzzzzzz_ ?? false;
            };
            bool vzzzzzzb_()
            {
                CqlCode xzzzzzza_ = this.CD(context);
                bool? xzzzzzzb_ = context.Operators.Equivalent(frequency, xzzzzzza_);

                return xzzzzzzb_ ?? false;
            };
            bool vzzzzzzc_()
            {
                CqlCode xzzzzzzc_ = this.CV(context);
                bool? xzzzzzzd_ = context.Operators.Equivalent(frequency, xzzzzzzc_);

                return xzzzzzzd_ ?? false;
            };
            bool vzzzzzzd_()
            {
                CqlCode xzzzzzze_ = this.AC(context);
                bool? xzzzzzzf_ = context.Operators.Equivalent(frequency, xzzzzzze_);

                return xzzzzzzf_ ?? false;
            };
            bool vzzzzzze_()
            {
                CqlCode xzzzzzzg_ = this.ACM(context);
                bool? xzzzzzzh_ = context.Operators.Equivalent(frequency, xzzzzzzg_);

                return xzzzzzzh_ ?? false;
            };
            bool vzzzzzzf_()
            {
                CqlCode xzzzzzzi_ = this.ACD(context);
                bool? xzzzzzzj_ = context.Operators.Equivalent(frequency, xzzzzzzi_);

                return xzzzzzzj_ ?? false;
            };
            bool vzzzzzzg_()
            {
                CqlCode xzzzzzzk_ = this.ACV(context);
                bool? xzzzzzzl_ = context.Operators.Equivalent(frequency, xzzzzzzk_);

                return xzzzzzzl_ ?? false;
            };
            bool vzzzzzzh_()
            {
                CqlCode xzzzzzzm_ = this.PC(context);
                bool? xzzzzzzn_ = context.Operators.Equivalent(frequency, xzzzzzzm_);

                return xzzzzzzn_ ?? false;
            };
            bool vzzzzzzi_()
            {
                CqlCode xzzzzzzo_ = this.PCM(context);
                bool? xzzzzzzp_ = context.Operators.Equivalent(frequency, xzzzzzzo_);

                return xzzzzzzp_ ?? false;
            };
            bool vzzzzzzj_()
            {
                CqlCode xzzzzzzq_ = this.PCD(context);
                bool? xzzzzzzr_ = context.Operators.Equivalent(frequency, xzzzzzzq_);

                return xzzzzzzr_ ?? false;
            };
            bool vzzzzzzk_()
            {
                CqlCode xzzzzzzs_ = this.PCV(context);
                bool? xzzzzzzt_ = context.Operators.Equivalent(frequency, xzzzzzzs_);

                return xzzzzzzt_ ?? false;
            };
            bool vzzzzzzl_()
            {
                CqlCode xzzzzzzu_ = this.MORN(context);
                bool? xzzzzzzv_ = context.Operators.Equivalent(frequency, xzzzzzzu_);

                return xzzzzzzv_ ?? false;
            };
            bool vzzzzzzm_()
            {
                CqlCode xzzzzzzw_ = this.MORN_early(context);
                bool? xzzzzzzx_ = context.Operators.Equivalent(frequency, xzzzzzzw_);

                return xzzzzzzx_ ?? false;
            };
            bool vzzzzzzn_()
            {
                CqlCode xzzzzzzy_ = this.MORN_late(context);
                bool? xzzzzzzz_ = context.Operators.Equivalent(frequency, xzzzzzzy_);

                return xzzzzzzz_ ?? false;
            };
            bool vzzzzzzo_()
            {
                CqlCode yzzzzzza_ = this.NOON(context);
                bool? yzzzzzzb_ = context.Operators.Equivalent(frequency, yzzzzzza_);

                return yzzzzzzb_ ?? false;
            };
            bool vzzzzzzp_()
            {
                CqlCode yzzzzzzc_ = this.AFT(context);
                bool? yzzzzzzd_ = context.Operators.Equivalent(frequency, yzzzzzzc_);

                return yzzzzzzd_ ?? false;
            };
            bool vzzzzzzq_()
            {
                CqlCode yzzzzzze_ = this.AFT_early(context);
                bool? yzzzzzzf_ = context.Operators.Equivalent(frequency, yzzzzzze_);

                return yzzzzzzf_ ?? false;
            };
            bool vzzzzzzr_()
            {
                CqlCode yzzzzzzg_ = this.AFT_late(context);
                bool? yzzzzzzh_ = context.Operators.Equivalent(frequency, yzzzzzzg_);

                return yzzzzzzh_ ?? false;
            };
            bool vzzzzzzs_()
            {
                CqlCode yzzzzzzi_ = this.EVE(context);
                bool? yzzzzzzj_ = context.Operators.Equivalent(frequency, yzzzzzzi_);

                return yzzzzzzj_ ?? false;
            };
            bool vzzzzzzt_()
            {
                CqlCode yzzzzzzk_ = this.EVE_early(context);
                bool? yzzzzzzl_ = context.Operators.Equivalent(frequency, yzzzzzzk_);

                return yzzzzzzl_ ?? false;
            };
            bool vzzzzzzu_()
            {
                CqlCode yzzzzzzm_ = this.EVE_late(context);
                bool? yzzzzzzn_ = context.Operators.Equivalent(frequency, yzzzzzzm_);

                return yzzzzzzn_ ?? false;
            };
            bool vzzzzzzv_()
            {
                CqlCode yzzzzzzo_ = this.NIGHT(context);
                bool? yzzzzzzp_ = context.Operators.Equivalent(frequency, yzzzzzzo_);

                return yzzzzzzp_ ?? false;
            };
            bool vzzzzzzw_()
            {
                CqlCode yzzzzzzq_ = this.PHS(context);
                bool? yzzzzzzr_ = context.Operators.Equivalent(frequency, yzzzzzzq_);

                return yzzzzzzr_ ?? false;
            };
            bool vzzzzzzx_()
            {
                CqlCode yzzzzzzs_ = this.Once_daily__qualifier_value_(context);
                bool? yzzzzzzt_ = context.Operators.Equivalent(frequency, yzzzzzzs_);

                return yzzzzzzt_ ?? false;
            };
            bool vzzzzzzy_()
            {
                CqlCode yzzzzzzu_ = this.Twice_a_day__qualifier_value_(context);
                bool? yzzzzzzv_ = context.Operators.Equivalent(frequency, yzzzzzzu_);

                return yzzzzzzv_ ?? false;
            };
            bool vzzzzzzz_()
            {
                CqlCode yzzzzzzw_ = this.Three_times_daily__qualifier_value_(context);
                bool? yzzzzzzx_ = context.Operators.Equivalent(frequency, yzzzzzzw_);

                return yzzzzzzx_ ?? false;
            };
            bool wzzzzzza_()
            {
                CqlCode yzzzzzzy_ = this.Four_times_daily__qualifier_value_(context);
                bool? yzzzzzzz_ = context.Operators.Equivalent(frequency, yzzzzzzy_);

                return yzzzzzzz_ ?? false;
            };
            bool wzzzzzzb_()
            {
                CqlCode zzzzzzza_ = this.Every_twenty_four_hours__qualifier_value_(context);
                bool? zzzzzzzb_ = context.Operators.Equivalent(frequency, zzzzzzza_);

                return zzzzzzzb_ ?? false;
            };
            bool wzzzzzzc_()
            {
                CqlCode zzzzzzzc_ = this.Every_twelve_hours__qualifier_value_(context);
                bool? zzzzzzzd_ = context.Operators.Equivalent(frequency, zzzzzzzc_);

                return zzzzzzzd_ ?? false;
            };
            bool wzzzzzzd_()
            {
                CqlCode zzzzzzze_ = this.Every_thirty_six_hours__qualifier_value_(context);
                bool? zzzzzzzf_ = context.Operators.Equivalent(frequency, zzzzzzze_);

                return zzzzzzzf_ ?? false;
            };
            bool wzzzzzze_()
            {
                CqlCode zzzzzzzg_ = this.Every_eight_hours__qualifier_value_(context);
                bool? zzzzzzzh_ = context.Operators.Equivalent(frequency, zzzzzzzg_);

                return zzzzzzzh_ ?? false;
            };
            bool wzzzzzzf_()
            {
                CqlCode zzzzzzzi_ = this.Every_four_hours__qualifier_value_(context);
                bool? zzzzzzzj_ = context.Operators.Equivalent(frequency, zzzzzzzi_);

                return zzzzzzzj_ ?? false;
            };
            bool wzzzzzzg_()
            {
                CqlCode zzzzzzzk_ = this.Every_six_hours__qualifier_value_(context);
                bool? zzzzzzzl_ = context.Operators.Equivalent(frequency, zzzzzzzk_);

                return zzzzzzzl_ ?? false;
            };
            bool wzzzzzzh_()
            {
                CqlCode zzzzzzzm_ = this.Every_seventy_two_hours__qualifier_value_(context);
                bool? zzzzzzzn_ = context.Operators.Equivalent(frequency, zzzzzzzm_);

                return zzzzzzzn_ ?? false;
            };
            bool wzzzzzzi_()
            {
                CqlCode zzzzzzzo_ = this.Every_forty_eight_hours__qualifier_value_(context);
                bool? zzzzzzzp_ = context.Operators.Equivalent(frequency, zzzzzzzo_);

                return zzzzzzzp_ ?? false;
            };
            bool wzzzzzzj_()
            {
                CqlCode zzzzzzzq_ = this.Every_eight_to_twelve_hours__qualifier_value_(context);
                bool? zzzzzzzr_ = context.Operators.Equivalent(frequency, zzzzzzzq_);

                return zzzzzzzr_ ?? false;
            };
            bool wzzzzzzk_()
            {
                CqlCode zzzzzzzs_ = this.Every_six_to_eight_hours__qualifier_value_(context);
                bool? zzzzzzzt_ = context.Operators.Equivalent(frequency, zzzzzzzs_);

                return zzzzzzzt_ ?? false;
            };
            bool wzzzzzzl_()
            {
                CqlCode zzzzzzzu_ = this.Every_three_to_four_hours__qualifier_value_(context);
                bool? zzzzzzzv_ = context.Operators.Equivalent(frequency, zzzzzzzu_);

                return zzzzzzzv_ ?? false;
            };
            bool wzzzzzzm_()
            {
                CqlCode zzzzzzzw_ = this.Every_three_to_six_hours__qualifier_value_(context);
                bool? zzzzzzzx_ = context.Operators.Equivalent(frequency, zzzzzzzw_);

                return zzzzzzzx_ ?? false;
            };
            bool wzzzzzzn_()
            {
                CqlCode zzzzzzzy_ = this.Every_two_to_four_hours__qualifier_value_(context);
                bool? zzzzzzzz_ = context.Operators.Equivalent(frequency, zzzzzzzy_);

                return zzzzzzzz_ ?? false;
            };
            bool wzzzzzzo_()
            {
                CqlCode azzzzzzza_ = this.One_to_four_times_a_day__qualifier_value_(context);
                bool? azzzzzzzb_ = context.Operators.Equivalent(frequency, azzzzzzza_);

                return azzzzzzzb_ ?? false;
            };
            bool wzzzzzzp_()
            {
                CqlCode azzzzzzzc_ = this.One_to_three_times_a_day__qualifier_value_(context);
                bool? azzzzzzzd_ = context.Operators.Equivalent(frequency, azzzzzzzc_);

                return azzzzzzzd_ ?? false;
            };
            bool wzzzzzzq_()
            {
                CqlCode azzzzzzze_ = this.One_to_two_times_a_day__qualifier_value_(context);
                bool? azzzzzzzf_ = context.Operators.Equivalent(frequency, azzzzzzze_);

                return azzzzzzzf_ ?? false;
            };
            bool wzzzzzzr_()
            {
                CqlCode azzzzzzzg_ = this.Two_to_four_times_a_day__qualifier_value_(context);
                bool? azzzzzzzh_ = context.Operators.Equivalent(frequency, azzzzzzzg_);

                return azzzzzzzh_ ?? false;
            };
            if (uzzzzzzx_())
            {
                decimal? azzzzzzzi_ = context.Operators.ConvertIntegerToDecimal(1);

                return azzzzzzzi_;
            }
            else if (uzzzzzzy_())
            {
                decimal? azzzzzzzj_ = context.Operators.ConvertIntegerToDecimal(1);

                return azzzzzzzj_;
            }
            else if (uzzzzzzz_())
            {
                decimal? azzzzzzzk_ = context.Operators.ConvertIntegerToDecimal(3);

                return azzzzzzzk_;
            }
            else if (vzzzzzza_())
            {
                decimal? azzzzzzzl_ = context.Operators.ConvertIntegerToDecimal(1);

                return azzzzzzzl_;
            }
            else if (vzzzzzzb_())
            {
                decimal? azzzzzzzm_ = context.Operators.ConvertIntegerToDecimal(1);

                return azzzzzzzm_;
            }
            else if (vzzzzzzc_())
            {
                decimal? azzzzzzzn_ = context.Operators.ConvertIntegerToDecimal(1);

                return azzzzzzzn_;
            }
            else if (vzzzzzzd_())
            {
                decimal? azzzzzzzo_ = context.Operators.ConvertIntegerToDecimal(3);

                return azzzzzzzo_;
            }
            else if (vzzzzzze_())
            {
                decimal? azzzzzzzp_ = context.Operators.ConvertIntegerToDecimal(1);

                return azzzzzzzp_;
            }
            else if (vzzzzzzf_())
            {
                decimal? azzzzzzzq_ = context.Operators.ConvertIntegerToDecimal(1);

                return azzzzzzzq_;
            }
            else if (vzzzzzzg_())
            {
                decimal? azzzzzzzr_ = context.Operators.ConvertIntegerToDecimal(1);

                return azzzzzzzr_;
            }
            else if (vzzzzzzh_())
            {
                decimal? azzzzzzzs_ = context.Operators.ConvertIntegerToDecimal(3);

                return azzzzzzzs_;
            }
            else if (vzzzzzzi_())
            {
                decimal? azzzzzzzt_ = context.Operators.ConvertIntegerToDecimal(1);

                return azzzzzzzt_;
            }
            else if (vzzzzzzj_())
            {
                decimal? azzzzzzzu_ = context.Operators.ConvertIntegerToDecimal(1);

                return azzzzzzzu_;
            }
            else if (vzzzzzzk_())
            {
                decimal? azzzzzzzv_ = context.Operators.ConvertIntegerToDecimal(1);

                return azzzzzzzv_;
            }
            else if (vzzzzzzl_())
            {
                decimal? azzzzzzzw_ = context.Operators.ConvertIntegerToDecimal(1);

                return azzzzzzzw_;
            }
            else if (vzzzzzzm_())
            {
                decimal? azzzzzzzx_ = context.Operators.ConvertIntegerToDecimal(1);

                return azzzzzzzx_;
            }
            else if (vzzzzzzn_())
            {
                decimal? azzzzzzzy_ = context.Operators.ConvertIntegerToDecimal(1);

                return azzzzzzzy_;
            }
            else if (vzzzzzzo_())
            {
                decimal? azzzzzzzz_ = context.Operators.ConvertIntegerToDecimal(1);

                return azzzzzzzz_;
            }
            else if (vzzzzzzp_())
            {
                decimal? bzzzzzzza_ = context.Operators.ConvertIntegerToDecimal(1);

                return bzzzzzzza_;
            }
            else if (vzzzzzzq_())
            {
                decimal? bzzzzzzzb_ = context.Operators.ConvertIntegerToDecimal(1);

                return bzzzzzzzb_;
            }
            else if (vzzzzzzr_())
            {
                decimal? bzzzzzzzc_ = context.Operators.ConvertIntegerToDecimal(1);

                return bzzzzzzzc_;
            }
            else if (vzzzzzzs_())
            {
                decimal? bzzzzzzzd_ = context.Operators.ConvertIntegerToDecimal(1);

                return bzzzzzzzd_;
            }
            else if (vzzzzzzt_())
            {
                decimal? bzzzzzzze_ = context.Operators.ConvertIntegerToDecimal(1);

                return bzzzzzzze_;
            }
            else if (vzzzzzzu_())
            {
                decimal? bzzzzzzzf_ = context.Operators.ConvertIntegerToDecimal(1);

                return bzzzzzzzf_;
            }
            else if (vzzzzzzv_())
            {
                decimal? bzzzzzzzg_ = context.Operators.ConvertIntegerToDecimal(1);

                return bzzzzzzzg_;
            }
            else if (vzzzzzzw_())
            {
                decimal? bzzzzzzzh_ = context.Operators.ConvertIntegerToDecimal(1);

                return bzzzzzzzh_;
            }
            else if (vzzzzzzx_())
            {
                return 1.0m;
            }
            else if (vzzzzzzy_())
            {
                return 2.0m;
            }
            else if (vzzzzzzz_())
            {
                return 3.0m;
            }
            else if (wzzzzzza_())
            {
                return 4.0m;
            }
            else if (wzzzzzzb_())
            {
                return 1.0m;
            }
            else if (wzzzzzzc_())
            {
                return 2.0m;
            }
            else if (wzzzzzzd_())
            {
                return 0.67m;
            }
            else if (wzzzzzze_())
            {
                return 3.0m;
            }
            else if (wzzzzzzf_())
            {
                return 6.0m;
            }
            else if (wzzzzzzg_())
            {
                return 4.0m;
            }
            else if (wzzzzzzh_())
            {
                return 0.33m;
            }
            else if (wzzzzzzi_())
            {
                return 0.5m;
            }
            else if (wzzzzzzj_())
            {
                return 3.0m;
            }
            else if (wzzzzzzk_())
            {
                return 4.0m;
            }
            else if (wzzzzzzl_())
            {
                return 8.0m;
            }
            else if (wzzzzzzm_())
            {
                return 8.0m;
            }
            else if (wzzzzzzn_())
            {
                return 12.0m;
            }
            else if (wzzzzzzo_())
            {
                return 4.0m;
            }
            else if (wzzzzzzp_())
            {
                return 3.0m;
            }
            else if (wzzzzzzq_())
            {
                return 2.0m;
            }
            else if (wzzzzzzr_())
            {
                return 4.0m;
            }
            else
            {
                string bzzzzzzzi_ = this.ErrorLevel(context);
                string bzzzzzzzj_ = frequency?.code;
                string bzzzzzzzk_ = context.Operators.Concatenate("Unknown frequency code ", bzzzzzzzj_ ?? "");
                object bzzzzzzzl_ = context.Operators.Message<object>(null, "CMDLogic.ToDaily.UnknownFrequencyCode", bzzzzzzzi_, bzzzzzzzk_);

                return bzzzzzzzl_ as decimal?;
            }
        };

        return uzzzzzzw_();
    }


    [CqlExpressionDefinition("Quantity")]
    public CqlQuantity Quantity(CqlContext context, decimal? value, string unit) =>
        ((context.Operators.Not((bool?)(value is null))) ?? false
            ? new CqlQuantity(value, unit)
            : default);


    [CqlExpressionDefinition("MedicationRequestPeriod")]
    public CqlInterval<CqlDate> MedicationRequestPeriod(CqlContext context, MedicationRequest Request)
    {
        MedicationRequest[] bzzzzzzzm_ = [
            Request,
        ];
        CqlInterval<CqlDate> bzzzzzzzn_(MedicationRequest R)
        {
            CqlInterval<CqlDate> bzzzzzzzr_()
            {
                bool bzzzzzzzs_()
                {
                    List<Dosage> bzzzzzzzu_ = R?.DosageInstruction;
                    Dosage bzzzzzzzv_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)bzzzzzzzu_);
                    Timing bzzzzzzzw_ = bzzzzzzzv_?.Timing;
                    Timing.RepeatComponent bzzzzzzzx_ = bzzzzzzzw_?.Repeat;
                    DataType bzzzzzzzy_ = bzzzzzzzx_?.Bounds;
                    object bzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzy_);
                    CqlDateTime czzzzzzza_ = context.Operators.Start(bzzzzzzzz_ as CqlInterval<CqlDateTime>);
                    CqlDate czzzzzzzb_ = context.Operators.DateFrom(czzzzzzza_);
                    FhirDateTime czzzzzzzc_ = R?.AuthoredOnElement;
                    CqlDateTime czzzzzzzd_ = context.Operators.Convert<CqlDateTime>(czzzzzzzc_);
                    CqlDate czzzzzzze_ = context.Operators.DateFrom(czzzzzzzd_);
                    MedicationRequest.DispenseRequestComponent czzzzzzzf_ = R?.DispenseRequest;
                    Period czzzzzzzg_ = czzzzzzzf_?.ValidityPeriod;
                    CqlInterval<CqlDateTime> czzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzzzg_);
                    CqlDateTime czzzzzzzi_ = context.Operators.Start(czzzzzzzh_);
                    CqlDate czzzzzzzj_ = context.Operators.DateFrom(czzzzzzzi_);
                    bool? czzzzzzzk_ = context.Operators.Not((bool?)(((czzzzzzzb_ ?? czzzzzzze_) ?? czzzzzzzj_) is null));
                    Duration czzzzzzzm_ = czzzzzzzf_?.ExpectedSupplyDuration;
                    CqlQuantity czzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, czzzzzzzm_);
                    CqlQuantity czzzzzzzo_ = context.Operators.ConvertQuantity(czzzzzzzn_, "d");
                    decimal? czzzzzzzp_ = czzzzzzzo_?.value;
                    Quantity czzzzzzzr_ = czzzzzzzf_?.Quantity;
                    CqlQuantity czzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, czzzzzzzr_);
                    decimal? czzzzzzzt_ = czzzzzzzs_?.value;
                    Dosage czzzzzzzv_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)bzzzzzzzu_);
                    List<Dosage.DoseAndRateComponent> czzzzzzzw_ = czzzzzzzv_?.DoseAndRate;
                    Dosage.DoseAndRateComponent czzzzzzzx_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)czzzzzzzw_);
                    DataType czzzzzzzy_ = czzzzzzzx_?.Dose;
                    object czzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzy_);
                    CqlQuantity dzzzzzzza_ = context.Operators.End(czzzzzzzz_ as CqlInterval<CqlQuantity>);
                    Dosage dzzzzzzzc_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)bzzzzzzzu_);
                    List<Dosage.DoseAndRateComponent> dzzzzzzzd_ = dzzzzzzzc_?.DoseAndRate;
                    Dosage.DoseAndRateComponent dzzzzzzze_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)dzzzzzzzd_);
                    DataType dzzzzzzzf_ = dzzzzzzze_?.Dose;
                    object dzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzf_);
                    decimal? dzzzzzzzh_ = (dzzzzzzza_ ?? dzzzzzzzg_ as CqlQuantity)?.value;
                    Dosage dzzzzzzzj_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)bzzzzzzzu_);
                    Timing dzzzzzzzk_ = dzzzzzzzj_?.Timing;
                    Timing.RepeatComponent dzzzzzzzl_ = dzzzzzzzk_?.Repeat;
                    PositiveInt dzzzzzzzm_ = dzzzzzzzl_?.FrequencyMaxElement;
                    int? dzzzzzzzn_ = dzzzzzzzm_?.Value;
                    Dosage dzzzzzzzp_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)bzzzzzzzu_);
                    Timing dzzzzzzzq_ = dzzzzzzzp_?.Timing;
                    Timing.RepeatComponent dzzzzzzzr_ = dzzzzzzzq_?.Repeat;
                    PositiveInt dzzzzzzzs_ = dzzzzzzzr_?.FrequencyElement;
                    int? dzzzzzzzt_ = dzzzzzzzs_?.Value;
                    Dosage dzzzzzzzv_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)bzzzzzzzu_);
                    Timing dzzzzzzzw_ = dzzzzzzzv_?.Timing;
                    Timing.RepeatComponent dzzzzzzzx_ = dzzzzzzzw_?.Repeat;
                    FhirDecimal dzzzzzzzy_ = dzzzzzzzx_?.PeriodElement;
                    decimal? dzzzzzzzz_ = dzzzzzzzy_?.Value;
                    Dosage ezzzzzzzb_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)bzzzzzzzu_);
                    Timing ezzzzzzzc_ = ezzzzzzzb_?.Timing;
                    Timing.RepeatComponent ezzzzzzzd_ = ezzzzzzzc_?.Repeat;
                    Code<Timing.UnitsOfTime> ezzzzzzze_ = ezzzzzzzd_?.PeriodUnitElement;
                    Timing.UnitsOfTime? ezzzzzzzf_ = ezzzzzzze_?.Value;
                    string ezzzzzzzg_ = context.Operators.Convert<string>(ezzzzzzzf_);
                    CqlQuantity ezzzzzzzh_ = this.Quantity(context, dzzzzzzzz_, ezzzzzzzg_);
                    decimal? ezzzzzzzi_ = this.ToDaily(context, dzzzzzzzn_ ?? dzzzzzzzt_, ezzzzzzzh_);
                    Dosage ezzzzzzzk_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)bzzzzzzzu_);
                    Timing ezzzzzzzl_ = ezzzzzzzk_?.Timing;
                    Timing.RepeatComponent ezzzzzzzm_ = ezzzzzzzl_?.Repeat;
                    List<Time> ezzzzzzzn_ = ezzzzzzzm_?.TimeOfDayElement;
                    IEnumerable<CqlTime> ezzzzzzzo_ = context.Operators.LateBoundProperty<IEnumerable<CqlTime>>(ezzzzzzzn_, "value");
                    int? ezzzzzzzp_ = context.Operators.Count<CqlTime>(ezzzzzzzo_);
                    decimal? ezzzzzzzq_ = context.Operators.ConvertIntegerToDecimal(ezzzzzzzp_);
                    decimal? ezzzzzzzr_ = context.Operators.Multiply(dzzzzzzzh_, (ezzzzzzzi_ ?? ezzzzzzzq_) ?? 1.0m);
                    decimal? ezzzzzzzs_ = context.Operators.Divide(czzzzzzzt_, ezzzzzzzr_);
                    UnsignedInt ezzzzzzzu_ = czzzzzzzf_?.NumberOfRepeatsAllowedElement;
                    int? ezzzzzzzv_ = ezzzzzzzu_?.Value;
                    int? ezzzzzzzw_ = context.Operators.Add(1, ezzzzzzzv_ ?? 0);
                    decimal? ezzzzzzzx_ = context.Operators.ConvertIntegerToDecimal(ezzzzzzzw_);
                    decimal? ezzzzzzzy_ = context.Operators.Multiply(czzzzzzzp_ ?? ezzzzzzzs_, ezzzzzzzx_);
                    bool? ezzzzzzzz_ = context.Operators.Not((bool?)(ezzzzzzzy_ is null));
                    bool? fzzzzzzza_ = context.Operators.And(czzzzzzzk_, ezzzzzzzz_);

                    return fzzzzzzza_ ?? false;
                };
                bool bzzzzzzzt_()
                {
                    List<Dosage> fzzzzzzzb_ = R?.DosageInstruction;
                    Dosage fzzzzzzzc_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)fzzzzzzzb_);
                    Timing fzzzzzzzd_ = fzzzzzzzc_?.Timing;
                    Timing.RepeatComponent fzzzzzzze_ = fzzzzzzzd_?.Repeat;
                    DataType fzzzzzzzf_ = fzzzzzzze_?.Bounds;
                    object fzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzf_);
                    CqlDateTime fzzzzzzzh_ = context.Operators.Start(fzzzzzzzg_ as CqlInterval<CqlDateTime>);
                    CqlDate fzzzzzzzi_ = context.Operators.DateFrom(fzzzzzzzh_);
                    FhirDateTime fzzzzzzzj_ = R?.AuthoredOnElement;
                    CqlDateTime fzzzzzzzk_ = context.Operators.Convert<CqlDateTime>(fzzzzzzzj_);
                    CqlDate fzzzzzzzl_ = context.Operators.DateFrom(fzzzzzzzk_);
                    MedicationRequest.DispenseRequestComponent fzzzzzzzm_ = R?.DispenseRequest;
                    Period fzzzzzzzn_ = fzzzzzzzm_?.ValidityPeriod;
                    CqlInterval<CqlDateTime> fzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzzzn_);
                    CqlDateTime fzzzzzzzp_ = context.Operators.Start(fzzzzzzzo_);
                    CqlDate fzzzzzzzq_ = context.Operators.DateFrom(fzzzzzzzp_);
                    bool? fzzzzzzzr_ = context.Operators.Not((bool?)(((fzzzzzzzi_ ?? fzzzzzzzl_) ?? fzzzzzzzq_) is null));
                    Dosage fzzzzzzzt_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)fzzzzzzzb_);
                    Timing fzzzzzzzu_ = fzzzzzzzt_?.Timing;
                    Timing.RepeatComponent fzzzzzzzv_ = fzzzzzzzu_?.Repeat;
                    DataType fzzzzzzzw_ = fzzzzzzzv_?.Bounds;
                    object fzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzw_);
                    CqlDateTime fzzzzzzzy_ = (fzzzzzzzx_ as CqlInterval<CqlDateTime>)?.high;
                    bool? fzzzzzzzz_ = context.Operators.Not((bool?)(fzzzzzzzy_ is null));
                    bool? gzzzzzzza_ = context.Operators.And(fzzzzzzzr_, fzzzzzzzz_);

                    return gzzzzzzza_ ?? false;
                };
                if (bzzzzzzzs_())
                {
                    List<Dosage> gzzzzzzzb_ = R?.DosageInstruction;
                    Dosage gzzzzzzzc_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)gzzzzzzzb_);
                    Timing gzzzzzzzd_ = gzzzzzzzc_?.Timing;
                    Timing.RepeatComponent gzzzzzzze_ = gzzzzzzzd_?.Repeat;
                    DataType gzzzzzzzf_ = gzzzzzzze_?.Bounds;
                    object gzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzf_);
                    CqlDateTime gzzzzzzzh_ = context.Operators.Start(gzzzzzzzg_ as CqlInterval<CqlDateTime>);
                    CqlDate gzzzzzzzi_ = context.Operators.DateFrom(gzzzzzzzh_);
                    FhirDateTime gzzzzzzzj_ = R?.AuthoredOnElement;
                    CqlDateTime gzzzzzzzk_ = context.Operators.Convert<CqlDateTime>(gzzzzzzzj_);
                    CqlDate gzzzzzzzl_ = context.Operators.DateFrom(gzzzzzzzk_);
                    MedicationRequest.DispenseRequestComponent gzzzzzzzm_ = R?.DispenseRequest;
                    Period gzzzzzzzn_ = gzzzzzzzm_?.ValidityPeriod;
                    CqlInterval<CqlDateTime> gzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzzn_);
                    CqlDateTime gzzzzzzzp_ = context.Operators.Start(gzzzzzzzo_);
                    CqlDate gzzzzzzzq_ = context.Operators.DateFrom(gzzzzzzzp_);
                    Dosage gzzzzzzzs_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)gzzzzzzzb_);
                    Timing gzzzzzzzt_ = gzzzzzzzs_?.Timing;
                    Timing.RepeatComponent gzzzzzzzu_ = gzzzzzzzt_?.Repeat;
                    DataType gzzzzzzzv_ = gzzzzzzzu_?.Bounds;
                    object gzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzv_);
                    CqlDateTime gzzzzzzzx_ = context.Operators.Start(gzzzzzzzw_ as CqlInterval<CqlDateTime>);
                    CqlDate gzzzzzzzy_ = context.Operators.DateFrom(gzzzzzzzx_);
                    CqlDateTime hzzzzzzza_ = context.Operators.Convert<CqlDateTime>(gzzzzzzzj_);
                    CqlDate hzzzzzzzb_ = context.Operators.DateFrom(hzzzzzzza_);
                    Period hzzzzzzzd_ = gzzzzzzzm_?.ValidityPeriod;
                    CqlInterval<CqlDateTime> hzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzzd_);
                    CqlDateTime hzzzzzzzf_ = context.Operators.Start(hzzzzzzze_);
                    CqlDate hzzzzzzzg_ = context.Operators.DateFrom(hzzzzzzzf_);
                    Duration hzzzzzzzi_ = gzzzzzzzm_?.ExpectedSupplyDuration;
                    CqlQuantity hzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, hzzzzzzzi_);
                    CqlQuantity hzzzzzzzk_ = context.Operators.ConvertQuantity(hzzzzzzzj_, "d");
                    decimal? hzzzzzzzl_ = hzzzzzzzk_?.value;
                    Quantity hzzzzzzzn_ = gzzzzzzzm_?.Quantity;
                    CqlQuantity hzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, hzzzzzzzn_);
                    decimal? hzzzzzzzp_ = hzzzzzzzo_?.value;
                    Dosage hzzzzzzzr_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)gzzzzzzzb_);
                    List<Dosage.DoseAndRateComponent> hzzzzzzzs_ = hzzzzzzzr_?.DoseAndRate;
                    Dosage.DoseAndRateComponent hzzzzzzzt_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)hzzzzzzzs_);
                    DataType hzzzzzzzu_ = hzzzzzzzt_?.Dose;
                    object hzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzu_);
                    CqlQuantity hzzzzzzzw_ = context.Operators.End(hzzzzzzzv_ as CqlInterval<CqlQuantity>);
                    Dosage hzzzzzzzy_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)gzzzzzzzb_);
                    List<Dosage.DoseAndRateComponent> hzzzzzzzz_ = hzzzzzzzy_?.DoseAndRate;
                    Dosage.DoseAndRateComponent izzzzzzza_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)hzzzzzzzz_);
                    DataType izzzzzzzb_ = izzzzzzza_?.Dose;
                    object izzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzb_);
                    decimal? izzzzzzzd_ = (hzzzzzzzw_ ?? izzzzzzzc_ as CqlQuantity)?.value;
                    Dosage izzzzzzzf_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)gzzzzzzzb_);
                    Timing izzzzzzzg_ = izzzzzzzf_?.Timing;
                    Timing.RepeatComponent izzzzzzzh_ = izzzzzzzg_?.Repeat;
                    PositiveInt izzzzzzzi_ = izzzzzzzh_?.FrequencyMaxElement;
                    int? izzzzzzzj_ = izzzzzzzi_?.Value;
                    Dosage izzzzzzzl_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)gzzzzzzzb_);
                    Timing izzzzzzzm_ = izzzzzzzl_?.Timing;
                    Timing.RepeatComponent izzzzzzzn_ = izzzzzzzm_?.Repeat;
                    PositiveInt izzzzzzzo_ = izzzzzzzn_?.FrequencyElement;
                    int? izzzzzzzp_ = izzzzzzzo_?.Value;
                    Dosage izzzzzzzr_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)gzzzzzzzb_);
                    Timing izzzzzzzs_ = izzzzzzzr_?.Timing;
                    Timing.RepeatComponent izzzzzzzt_ = izzzzzzzs_?.Repeat;
                    FhirDecimal izzzzzzzu_ = izzzzzzzt_?.PeriodElement;
                    decimal? izzzzzzzv_ = izzzzzzzu_?.Value;
                    Dosage izzzzzzzx_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)gzzzzzzzb_);
                    Timing izzzzzzzy_ = izzzzzzzx_?.Timing;
                    Timing.RepeatComponent izzzzzzzz_ = izzzzzzzy_?.Repeat;
                    Code<Timing.UnitsOfTime> jzzzzzzza_ = izzzzzzzz_?.PeriodUnitElement;
                    Timing.UnitsOfTime? jzzzzzzzb_ = jzzzzzzza_?.Value;
                    string jzzzzzzzc_ = context.Operators.Convert<string>(jzzzzzzzb_);
                    CqlQuantity jzzzzzzzd_ = this.Quantity(context, izzzzzzzv_, jzzzzzzzc_);
                    decimal? jzzzzzzze_ = this.ToDaily(context, izzzzzzzj_ ?? izzzzzzzp_, jzzzzzzzd_);
                    Dosage jzzzzzzzg_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)gzzzzzzzb_);
                    Timing jzzzzzzzh_ = jzzzzzzzg_?.Timing;
                    Timing.RepeatComponent jzzzzzzzi_ = jzzzzzzzh_?.Repeat;
                    List<Time> jzzzzzzzj_ = jzzzzzzzi_?.TimeOfDayElement;
                    IEnumerable<CqlTime> jzzzzzzzk_ = context.Operators.LateBoundProperty<IEnumerable<CqlTime>>(jzzzzzzzj_, "value");
                    int? jzzzzzzzl_ = context.Operators.Count<CqlTime>(jzzzzzzzk_);
                    decimal? jzzzzzzzm_ = context.Operators.ConvertIntegerToDecimal(jzzzzzzzl_);
                    decimal? jzzzzzzzn_ = context.Operators.Multiply(izzzzzzzd_, (jzzzzzzze_ ?? jzzzzzzzm_) ?? 1.0m);
                    decimal? jzzzzzzzo_ = context.Operators.Divide(hzzzzzzzp_, jzzzzzzzn_);
                    UnsignedInt jzzzzzzzq_ = gzzzzzzzm_?.NumberOfRepeatsAllowedElement;
                    int? jzzzzzzzr_ = jzzzzzzzq_?.Value;
                    int? jzzzzzzzs_ = context.Operators.Add(1, jzzzzzzzr_ ?? 0);
                    decimal? jzzzzzzzt_ = context.Operators.ConvertIntegerToDecimal(jzzzzzzzs_);
                    decimal? jzzzzzzzu_ = context.Operators.Multiply(hzzzzzzzl_ ?? jzzzzzzzo_, jzzzzzzzt_);
                    decimal? jzzzzzzzv_ = context.Operators.ConvertIntegerToDecimal(1);
                    decimal? jzzzzzzzw_ = context.Operators.Subtract(jzzzzzzzu_, jzzzzzzzv_);
                    CqlQuantity jzzzzzzzx_ = this.Quantity(context, jzzzzzzzw_, "day");
                    CqlDate jzzzzzzzy_ = context.Operators.Add((gzzzzzzzy_ ?? hzzzzzzzb_) ?? hzzzzzzzg_, jzzzzzzzx_);
                    CqlInterval<CqlDate> jzzzzzzzz_ = context.Operators.Interval((gzzzzzzzi_ ?? gzzzzzzzl_) ?? gzzzzzzzq_, jzzzzzzzy_, true, true);

                    return jzzzzzzzz_;
                }
                else if (bzzzzzzzt_())
                {
                    List<Dosage> kzzzzzzza_ = R?.DosageInstruction;
                    Dosage kzzzzzzzb_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)kzzzzzzza_);
                    Timing kzzzzzzzc_ = kzzzzzzzb_?.Timing;
                    Timing.RepeatComponent kzzzzzzzd_ = kzzzzzzzc_?.Repeat;
                    DataType kzzzzzzze_ = kzzzzzzzd_?.Bounds;
                    object kzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzze_);
                    CqlDateTime kzzzzzzzg_ = context.Operators.Start(kzzzzzzzf_ as CqlInterval<CqlDateTime>);
                    CqlDate kzzzzzzzh_ = context.Operators.DateFrom(kzzzzzzzg_);
                    FhirDateTime kzzzzzzzi_ = R?.AuthoredOnElement;
                    CqlDateTime kzzzzzzzj_ = context.Operators.Convert<CqlDateTime>(kzzzzzzzi_);
                    CqlDate kzzzzzzzk_ = context.Operators.DateFrom(kzzzzzzzj_);
                    MedicationRequest.DispenseRequestComponent kzzzzzzzl_ = R?.DispenseRequest;
                    Period kzzzzzzzm_ = kzzzzzzzl_?.ValidityPeriod;
                    CqlInterval<CqlDateTime> kzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzzzm_);
                    CqlDateTime kzzzzzzzo_ = context.Operators.Start(kzzzzzzzn_);
                    CqlDate kzzzzzzzp_ = context.Operators.DateFrom(kzzzzzzzo_);
                    Dosage kzzzzzzzr_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)kzzzzzzza_);
                    Timing kzzzzzzzs_ = kzzzzzzzr_?.Timing;
                    Timing.RepeatComponent kzzzzzzzt_ = kzzzzzzzs_?.Repeat;
                    DataType kzzzzzzzu_ = kzzzzzzzt_?.Bounds;
                    object kzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzu_);
                    CqlDateTime kzzzzzzzw_ = context.Operators.End(kzzzzzzzv_ as CqlInterval<CqlDateTime>);
                    CqlDate kzzzzzzzx_ = context.Operators.DateFrom(kzzzzzzzw_);
                    CqlInterval<CqlDate> kzzzzzzzy_ = context.Operators.Interval((kzzzzzzzh_ ?? kzzzzzzzk_) ?? kzzzzzzzp_, kzzzzzzzx_, true, true);

                    return kzzzzzzzy_;
                }
                else
                {
                    return null as CqlInterval<CqlDate>;
                }
            };

            return bzzzzzzzr_();
        };
        IEnumerable<CqlInterval<CqlDate>> bzzzzzzzo_ = context.Operators.Select<MedicationRequest, CqlInterval<CqlDate>>((IEnumerable<MedicationRequest>)bzzzzzzzm_, bzzzzzzzn_);
        IEnumerable<CqlInterval<CqlDate>> bzzzzzzzp_ = context.Operators.Distinct<CqlInterval<CqlDate>>(bzzzzzzzo_);
        CqlInterval<CqlDate> bzzzzzzzq_ = context.Operators.SingletonFrom<CqlInterval<CqlDate>>(bzzzzzzzp_);

        return bzzzzzzzq_;
    }


    [CqlExpressionDefinition("medicationRequestPeriod")]
    public CqlInterval<CqlDate> medicationRequestPeriod(CqlContext context, MedicationRequest Request)
    {
        MedicationRequest[] kzzzzzzzz_ = [
            Request,
        ];
        CqlInterval<CqlDate> lzzzzzzza_(MedicationRequest R)
        {
            CqlInterval<CqlDate> lzzzzzzze_()
            {
                bool lzzzzzzzf_()
                {
                    List<Dosage> lzzzzzzzh_ = R?.DosageInstruction;
                    Dosage lzzzzzzzi_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)lzzzzzzzh_);
                    Timing lzzzzzzzj_ = lzzzzzzzi_?.Timing;
                    Timing.RepeatComponent lzzzzzzzk_ = lzzzzzzzj_?.Repeat;
                    DataType lzzzzzzzl_ = lzzzzzzzk_?.Bounds;
                    object lzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzl_);
                    CqlDateTime lzzzzzzzn_ = context.Operators.Start(lzzzzzzzm_ as CqlInterval<CqlDateTime>);
                    CqlDate lzzzzzzzo_ = context.Operators.DateFrom(lzzzzzzzn_);
                    FhirDateTime lzzzzzzzp_ = R?.AuthoredOnElement;
                    CqlDateTime lzzzzzzzq_ = context.Operators.Convert<CqlDateTime>(lzzzzzzzp_);
                    CqlDate lzzzzzzzr_ = context.Operators.DateFrom(lzzzzzzzq_);
                    MedicationRequest.DispenseRequestComponent lzzzzzzzs_ = R?.DispenseRequest;
                    Period lzzzzzzzt_ = lzzzzzzzs_?.ValidityPeriod;
                    CqlInterval<CqlDateTime> lzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzzt_);
                    CqlDateTime lzzzzzzzv_ = context.Operators.Start(lzzzzzzzu_);
                    CqlDate lzzzzzzzw_ = context.Operators.DateFrom(lzzzzzzzv_);
                    bool? lzzzzzzzx_ = context.Operators.Not((bool?)(((lzzzzzzzo_ ?? lzzzzzzzr_) ?? lzzzzzzzw_) is null));
                    Duration lzzzzzzzz_ = lzzzzzzzs_?.ExpectedSupplyDuration;
                    CqlQuantity mzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, lzzzzzzzz_);
                    CqlQuantity mzzzzzzzb_ = context.Operators.ConvertQuantity(mzzzzzzza_, "d");
                    decimal? mzzzzzzzc_ = mzzzzzzzb_?.value;
                    Quantity mzzzzzzze_ = lzzzzzzzs_?.Quantity;
                    CqlQuantity mzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, mzzzzzzze_);
                    decimal? mzzzzzzzg_ = mzzzzzzzf_?.value;
                    Dosage mzzzzzzzi_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)lzzzzzzzh_);
                    List<Dosage.DoseAndRateComponent> mzzzzzzzj_ = mzzzzzzzi_?.DoseAndRate;
                    Dosage.DoseAndRateComponent mzzzzzzzk_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)mzzzzzzzj_);
                    DataType mzzzzzzzl_ = mzzzzzzzk_?.Dose;
                    object mzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzl_);
                    CqlQuantity mzzzzzzzn_ = context.Operators.End(mzzzzzzzm_ as CqlInterval<CqlQuantity>);
                    Dosage mzzzzzzzp_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)lzzzzzzzh_);
                    List<Dosage.DoseAndRateComponent> mzzzzzzzq_ = mzzzzzzzp_?.DoseAndRate;
                    Dosage.DoseAndRateComponent mzzzzzzzr_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)mzzzzzzzq_);
                    DataType mzzzzzzzs_ = mzzzzzzzr_?.Dose;
                    object mzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzs_);
                    decimal? mzzzzzzzu_ = (mzzzzzzzn_ ?? mzzzzzzzt_ as CqlQuantity)?.value;
                    Dosage mzzzzzzzw_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)lzzzzzzzh_);
                    Timing mzzzzzzzx_ = mzzzzzzzw_?.Timing;
                    Timing.RepeatComponent mzzzzzzzy_ = mzzzzzzzx_?.Repeat;
                    PositiveInt mzzzzzzzz_ = mzzzzzzzy_?.FrequencyMaxElement;
                    int? nzzzzzzza_ = mzzzzzzzz_?.Value;
                    Dosage nzzzzzzzc_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)lzzzzzzzh_);
                    Timing nzzzzzzzd_ = nzzzzzzzc_?.Timing;
                    Timing.RepeatComponent nzzzzzzze_ = nzzzzzzzd_?.Repeat;
                    PositiveInt nzzzzzzzf_ = nzzzzzzze_?.FrequencyElement;
                    int? nzzzzzzzg_ = nzzzzzzzf_?.Value;
                    Dosage nzzzzzzzi_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)lzzzzzzzh_);
                    Timing nzzzzzzzj_ = nzzzzzzzi_?.Timing;
                    Timing.RepeatComponent nzzzzzzzk_ = nzzzzzzzj_?.Repeat;
                    FhirDecimal nzzzzzzzl_ = nzzzzzzzk_?.PeriodElement;
                    decimal? nzzzzzzzm_ = nzzzzzzzl_?.Value;
                    Dosage nzzzzzzzo_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)lzzzzzzzh_);
                    Timing nzzzzzzzp_ = nzzzzzzzo_?.Timing;
                    Timing.RepeatComponent nzzzzzzzq_ = nzzzzzzzp_?.Repeat;
                    Code<Timing.UnitsOfTime> nzzzzzzzr_ = nzzzzzzzq_?.PeriodUnitElement;
                    Timing.UnitsOfTime? nzzzzzzzs_ = nzzzzzzzr_?.Value;
                    string nzzzzzzzt_ = context.Operators.Convert<string>(nzzzzzzzs_);
                    CqlQuantity nzzzzzzzu_ = this.Quantity(context, nzzzzzzzm_, nzzzzzzzt_);
                    decimal? nzzzzzzzv_ = this.ToDaily(context, nzzzzzzza_ ?? nzzzzzzzg_, nzzzzzzzu_);
                    Dosage nzzzzzzzx_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)lzzzzzzzh_);
                    Timing nzzzzzzzy_ = nzzzzzzzx_?.Timing;
                    Timing.RepeatComponent nzzzzzzzz_ = nzzzzzzzy_?.Repeat;
                    List<Time> ozzzzzzza_ = nzzzzzzzz_?.TimeOfDayElement;
                    IEnumerable<CqlTime> ozzzzzzzb_ = context.Operators.LateBoundProperty<IEnumerable<CqlTime>>(ozzzzzzza_, "value");
                    int? ozzzzzzzc_ = context.Operators.Count<CqlTime>(ozzzzzzzb_);
                    decimal? ozzzzzzzd_ = context.Operators.ConvertIntegerToDecimal(ozzzzzzzc_);
                    decimal? ozzzzzzze_ = context.Operators.Multiply(mzzzzzzzu_, (nzzzzzzzv_ ?? ozzzzzzzd_) ?? 1.0m);
                    decimal? ozzzzzzzf_ = context.Operators.Divide(mzzzzzzzg_, ozzzzzzze_);
                    UnsignedInt ozzzzzzzh_ = lzzzzzzzs_?.NumberOfRepeatsAllowedElement;
                    int? ozzzzzzzi_ = ozzzzzzzh_?.Value;
                    int? ozzzzzzzj_ = context.Operators.Add(1, ozzzzzzzi_ ?? 0);
                    decimal? ozzzzzzzk_ = context.Operators.ConvertIntegerToDecimal(ozzzzzzzj_);
                    decimal? ozzzzzzzl_ = context.Operators.Multiply(mzzzzzzzc_ ?? ozzzzzzzf_, ozzzzzzzk_);
                    bool? ozzzzzzzm_ = context.Operators.Not((bool?)(ozzzzzzzl_ is null));
                    bool? ozzzzzzzn_ = context.Operators.And(lzzzzzzzx_, ozzzzzzzm_);

                    return ozzzzzzzn_ ?? false;
                };
                bool lzzzzzzzg_()
                {
                    List<Dosage> ozzzzzzzo_ = R?.DosageInstruction;
                    Dosage ozzzzzzzp_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)ozzzzzzzo_);
                    Timing ozzzzzzzq_ = ozzzzzzzp_?.Timing;
                    Timing.RepeatComponent ozzzzzzzr_ = ozzzzzzzq_?.Repeat;
                    DataType ozzzzzzzs_ = ozzzzzzzr_?.Bounds;
                    object ozzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzs_);
                    CqlDateTime ozzzzzzzu_ = context.Operators.Start(ozzzzzzzt_ as CqlInterval<CqlDateTime>);
                    CqlDate ozzzzzzzv_ = context.Operators.DateFrom(ozzzzzzzu_);
                    FhirDateTime ozzzzzzzw_ = R?.AuthoredOnElement;
                    CqlDateTime ozzzzzzzx_ = context.Operators.Convert<CqlDateTime>(ozzzzzzzw_);
                    CqlDate ozzzzzzzy_ = context.Operators.DateFrom(ozzzzzzzx_);
                    MedicationRequest.DispenseRequestComponent ozzzzzzzz_ = R?.DispenseRequest;
                    Period pzzzzzzza_ = ozzzzzzzz_?.ValidityPeriod;
                    CqlInterval<CqlDateTime> pzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzzza_);
                    CqlDateTime pzzzzzzzc_ = context.Operators.Start(pzzzzzzzb_);
                    CqlDate pzzzzzzzd_ = context.Operators.DateFrom(pzzzzzzzc_);
                    bool? pzzzzzzze_ = context.Operators.Not((bool?)(((ozzzzzzzv_ ?? ozzzzzzzy_) ?? pzzzzzzzd_) is null));
                    Dosage pzzzzzzzg_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)ozzzzzzzo_);
                    Timing pzzzzzzzh_ = pzzzzzzzg_?.Timing;
                    Timing.RepeatComponent pzzzzzzzi_ = pzzzzzzzh_?.Repeat;
                    DataType pzzzzzzzj_ = pzzzzzzzi_?.Bounds;
                    object pzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzj_);
                    CqlDateTime pzzzzzzzl_ = (pzzzzzzzk_ as CqlInterval<CqlDateTime>)?.high;
                    bool? pzzzzzzzm_ = context.Operators.Not((bool?)(pzzzzzzzl_ is null));
                    bool? pzzzzzzzn_ = context.Operators.And(pzzzzzzze_, pzzzzzzzm_);

                    return pzzzzzzzn_ ?? false;
                };
                if (lzzzzzzzf_())
                {
                    List<Dosage> pzzzzzzzo_ = R?.DosageInstruction;
                    Dosage pzzzzzzzp_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)pzzzzzzzo_);
                    Timing pzzzzzzzq_ = pzzzzzzzp_?.Timing;
                    Timing.RepeatComponent pzzzzzzzr_ = pzzzzzzzq_?.Repeat;
                    DataType pzzzzzzzs_ = pzzzzzzzr_?.Bounds;
                    object pzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzs_);
                    CqlDateTime pzzzzzzzu_ = context.Operators.Start(pzzzzzzzt_ as CqlInterval<CqlDateTime>);
                    CqlDate pzzzzzzzv_ = context.Operators.DateFrom(pzzzzzzzu_);
                    FhirDateTime pzzzzzzzw_ = R?.AuthoredOnElement;
                    CqlDateTime pzzzzzzzx_ = context.Operators.Convert<CqlDateTime>(pzzzzzzzw_);
                    CqlDate pzzzzzzzy_ = context.Operators.DateFrom(pzzzzzzzx_);
                    MedicationRequest.DispenseRequestComponent pzzzzzzzz_ = R?.DispenseRequest;
                    Period qzzzzzzza_ = pzzzzzzzz_?.ValidityPeriod;
                    CqlInterval<CqlDateTime> qzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzzza_);
                    CqlDateTime qzzzzzzzc_ = context.Operators.Start(qzzzzzzzb_);
                    CqlDate qzzzzzzzd_ = context.Operators.DateFrom(qzzzzzzzc_);
                    Dosage qzzzzzzzf_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)pzzzzzzzo_);
                    Timing qzzzzzzzg_ = qzzzzzzzf_?.Timing;
                    Timing.RepeatComponent qzzzzzzzh_ = qzzzzzzzg_?.Repeat;
                    DataType qzzzzzzzi_ = qzzzzzzzh_?.Bounds;
                    object qzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzi_);
                    CqlDateTime qzzzzzzzk_ = context.Operators.Start(qzzzzzzzj_ as CqlInterval<CqlDateTime>);
                    CqlDate qzzzzzzzl_ = context.Operators.DateFrom(qzzzzzzzk_);
                    CqlDateTime qzzzzzzzn_ = context.Operators.Convert<CqlDateTime>(pzzzzzzzw_);
                    CqlDate qzzzzzzzo_ = context.Operators.DateFrom(qzzzzzzzn_);
                    Period qzzzzzzzq_ = pzzzzzzzz_?.ValidityPeriod;
                    CqlInterval<CqlDateTime> qzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzzzq_);
                    CqlDateTime qzzzzzzzs_ = context.Operators.Start(qzzzzzzzr_);
                    CqlDate qzzzzzzzt_ = context.Operators.DateFrom(qzzzzzzzs_);
                    Duration qzzzzzzzv_ = pzzzzzzzz_?.ExpectedSupplyDuration;
                    CqlQuantity qzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, qzzzzzzzv_);
                    CqlQuantity qzzzzzzzx_ = context.Operators.ConvertQuantity(qzzzzzzzw_, "d");
                    decimal? qzzzzzzzy_ = qzzzzzzzx_?.value;
                    Quantity rzzzzzzza_ = pzzzzzzzz_?.Quantity;
                    CqlQuantity rzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, rzzzzzzza_);
                    decimal? rzzzzzzzc_ = rzzzzzzzb_?.value;
                    Dosage rzzzzzzze_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)pzzzzzzzo_);
                    List<Dosage.DoseAndRateComponent> rzzzzzzzf_ = rzzzzzzze_?.DoseAndRate;
                    Dosage.DoseAndRateComponent rzzzzzzzg_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)rzzzzzzzf_);
                    DataType rzzzzzzzh_ = rzzzzzzzg_?.Dose;
                    object rzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzh_);
                    CqlQuantity rzzzzzzzj_ = context.Operators.End(rzzzzzzzi_ as CqlInterval<CqlQuantity>);
                    Dosage rzzzzzzzl_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)pzzzzzzzo_);
                    List<Dosage.DoseAndRateComponent> rzzzzzzzm_ = rzzzzzzzl_?.DoseAndRate;
                    Dosage.DoseAndRateComponent rzzzzzzzn_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)rzzzzzzzm_);
                    DataType rzzzzzzzo_ = rzzzzzzzn_?.Dose;
                    object rzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzo_);
                    decimal? rzzzzzzzq_ = (rzzzzzzzj_ ?? rzzzzzzzp_ as CqlQuantity)?.value;
                    Dosage rzzzzzzzs_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)pzzzzzzzo_);
                    Timing rzzzzzzzt_ = rzzzzzzzs_?.Timing;
                    Timing.RepeatComponent rzzzzzzzu_ = rzzzzzzzt_?.Repeat;
                    PositiveInt rzzzzzzzv_ = rzzzzzzzu_?.FrequencyMaxElement;
                    int? rzzzzzzzw_ = rzzzzzzzv_?.Value;
                    Dosage rzzzzzzzy_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)pzzzzzzzo_);
                    Timing rzzzzzzzz_ = rzzzzzzzy_?.Timing;
                    Timing.RepeatComponent szzzzzzza_ = rzzzzzzzz_?.Repeat;
                    PositiveInt szzzzzzzb_ = szzzzzzza_?.FrequencyElement;
                    int? szzzzzzzc_ = szzzzzzzb_?.Value;
                    Dosage szzzzzzze_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)pzzzzzzzo_);
                    Timing szzzzzzzf_ = szzzzzzze_?.Timing;
                    Timing.RepeatComponent szzzzzzzg_ = szzzzzzzf_?.Repeat;
                    FhirDecimal szzzzzzzh_ = szzzzzzzg_?.PeriodElement;
                    decimal? szzzzzzzi_ = szzzzzzzh_?.Value;
                    Dosage szzzzzzzk_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)pzzzzzzzo_);
                    Timing szzzzzzzl_ = szzzzzzzk_?.Timing;
                    Timing.RepeatComponent szzzzzzzm_ = szzzzzzzl_?.Repeat;
                    Code<Timing.UnitsOfTime> szzzzzzzn_ = szzzzzzzm_?.PeriodUnitElement;
                    Timing.UnitsOfTime? szzzzzzzo_ = szzzzzzzn_?.Value;
                    string szzzzzzzp_ = context.Operators.Convert<string>(szzzzzzzo_);
                    CqlQuantity szzzzzzzq_ = this.Quantity(context, szzzzzzzi_, szzzzzzzp_);
                    decimal? szzzzzzzr_ = this.ToDaily(context, rzzzzzzzw_ ?? szzzzzzzc_, szzzzzzzq_);
                    Dosage szzzzzzzt_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)pzzzzzzzo_);
                    Timing szzzzzzzu_ = szzzzzzzt_?.Timing;
                    Timing.RepeatComponent szzzzzzzv_ = szzzzzzzu_?.Repeat;
                    List<Time> szzzzzzzw_ = szzzzzzzv_?.TimeOfDayElement;
                    IEnumerable<CqlTime> szzzzzzzx_ = context.Operators.LateBoundProperty<IEnumerable<CqlTime>>(szzzzzzzw_, "value");
                    int? szzzzzzzy_ = context.Operators.Count<CqlTime>(szzzzzzzx_);
                    decimal? szzzzzzzz_ = context.Operators.ConvertIntegerToDecimal(szzzzzzzy_);
                    decimal? tzzzzzzza_ = context.Operators.Multiply(rzzzzzzzq_, (szzzzzzzr_ ?? szzzzzzzz_) ?? 1.0m);
                    decimal? tzzzzzzzb_ = context.Operators.Divide(rzzzzzzzc_, tzzzzzzza_);
                    UnsignedInt tzzzzzzzd_ = pzzzzzzzz_?.NumberOfRepeatsAllowedElement;
                    int? tzzzzzzze_ = tzzzzzzzd_?.Value;
                    int? tzzzzzzzf_ = context.Operators.Add(1, tzzzzzzze_ ?? 0);
                    decimal? tzzzzzzzg_ = context.Operators.ConvertIntegerToDecimal(tzzzzzzzf_);
                    decimal? tzzzzzzzh_ = context.Operators.Multiply(qzzzzzzzy_ ?? tzzzzzzzb_, tzzzzzzzg_);
                    decimal? tzzzzzzzi_ = context.Operators.ConvertIntegerToDecimal(1);
                    decimal? tzzzzzzzj_ = context.Operators.Subtract(tzzzzzzzh_, tzzzzzzzi_);
                    CqlQuantity tzzzzzzzk_ = this.Quantity(context, tzzzzzzzj_, "day");
                    CqlDate tzzzzzzzl_ = context.Operators.Add((qzzzzzzzl_ ?? qzzzzzzzo_) ?? qzzzzzzzt_, tzzzzzzzk_);
                    CqlInterval<CqlDate> tzzzzzzzm_ = context.Operators.Interval((pzzzzzzzv_ ?? pzzzzzzzy_) ?? qzzzzzzzd_, tzzzzzzzl_, true, true);

                    return tzzzzzzzm_;
                }
                else if (lzzzzzzzg_())
                {
                    List<Dosage> tzzzzzzzn_ = R?.DosageInstruction;
                    Dosage tzzzzzzzo_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)tzzzzzzzn_);
                    Timing tzzzzzzzp_ = tzzzzzzzo_?.Timing;
                    Timing.RepeatComponent tzzzzzzzq_ = tzzzzzzzp_?.Repeat;
                    DataType tzzzzzzzr_ = tzzzzzzzq_?.Bounds;
                    object tzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzr_);
                    CqlDateTime tzzzzzzzt_ = context.Operators.Start(tzzzzzzzs_ as CqlInterval<CqlDateTime>);
                    CqlDate tzzzzzzzu_ = context.Operators.DateFrom(tzzzzzzzt_);
                    FhirDateTime tzzzzzzzv_ = R?.AuthoredOnElement;
                    CqlDateTime tzzzzzzzw_ = context.Operators.Convert<CqlDateTime>(tzzzzzzzv_);
                    CqlDate tzzzzzzzx_ = context.Operators.DateFrom(tzzzzzzzw_);
                    MedicationRequest.DispenseRequestComponent tzzzzzzzy_ = R?.DispenseRequest;
                    Period tzzzzzzzz_ = tzzzzzzzy_?.ValidityPeriod;
                    CqlInterval<CqlDateTime> uzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzzzzz_);
                    CqlDateTime uzzzzzzzb_ = context.Operators.Start(uzzzzzzza_);
                    CqlDate uzzzzzzzc_ = context.Operators.DateFrom(uzzzzzzzb_);
                    Dosage uzzzzzzze_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)tzzzzzzzn_);
                    Timing uzzzzzzzf_ = uzzzzzzze_?.Timing;
                    Timing.RepeatComponent uzzzzzzzg_ = uzzzzzzzf_?.Repeat;
                    DataType uzzzzzzzh_ = uzzzzzzzg_?.Bounds;
                    object uzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzh_);
                    CqlDateTime uzzzzzzzj_ = context.Operators.End(uzzzzzzzi_ as CqlInterval<CqlDateTime>);
                    CqlDate uzzzzzzzk_ = context.Operators.DateFrom(uzzzzzzzj_);
                    CqlInterval<CqlDate> uzzzzzzzl_ = context.Operators.Interval((tzzzzzzzu_ ?? tzzzzzzzx_) ?? uzzzzzzzc_, uzzzzzzzk_, true, true);

                    return uzzzzzzzl_;
                }
                else
                {
                    return null as CqlInterval<CqlDate>;
                }
            };

            return lzzzzzzze_();
        };
        IEnumerable<CqlInterval<CqlDate>> lzzzzzzzb_ = context.Operators.Select<MedicationRequest, CqlInterval<CqlDate>>((IEnumerable<MedicationRequest>)kzzzzzzzz_, lzzzzzzza_);
        IEnumerable<CqlInterval<CqlDate>> lzzzzzzzc_ = context.Operators.Distinct<CqlInterval<CqlDate>>(lzzzzzzzb_);
        CqlInterval<CqlDate> lzzzzzzzd_ = context.Operators.SingletonFrom<CqlInterval<CqlDate>>(lzzzzzzzc_);

        return lzzzzzzzd_;
    }


    [CqlExpressionDefinition("MedicationDispensePeriod")]
    public CqlInterval<CqlDate> MedicationDispensePeriod(CqlContext context, MedicationDispense Dispense)
    {
        MedicationDispense[] uzzzzzzzm_ = [
            Dispense,
        ];
        CqlInterval<CqlDate> uzzzzzzzn_(MedicationDispense D)
        {
            CqlInterval<CqlDate> uzzzzzzzr_()
            {
                bool uzzzzzzzs_()
                {
                    FhirDateTime uzzzzzzzt_ = D?.WhenHandedOverElement;
                    CqlDateTime uzzzzzzzu_ = context.Operators.Convert<CqlDateTime>(uzzzzzzzt_);
                    CqlDate uzzzzzzzv_ = context.Operators.DateFrom(uzzzzzzzu_);
                    FhirDateTime uzzzzzzzw_ = D?.WhenPreparedElement;
                    CqlDateTime uzzzzzzzx_ = context.Operators.Convert<CqlDateTime>(uzzzzzzzw_);
                    CqlDate uzzzzzzzy_ = context.Operators.DateFrom(uzzzzzzzx_);
                    bool? uzzzzzzzz_ = context.Operators.Not((bool?)((uzzzzzzzv_ ?? uzzzzzzzy_) is null));
                    Quantity vzzzzzzza_ = D?.DaysSupply;
                    CqlQuantity vzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, vzzzzzzza_);
                    CqlQuantity vzzzzzzzc_ = context.Operators.ConvertQuantity(vzzzzzzzb_, "d");
                    decimal? vzzzzzzzd_ = vzzzzzzzc_?.value;
                    Quantity vzzzzzzze_ = D?.Quantity;
                    CqlQuantity vzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, vzzzzzzze_);
                    decimal? vzzzzzzzg_ = vzzzzzzzf_?.value;
                    List<Dosage> vzzzzzzzh_ = D?.DosageInstruction;
                    Dosage vzzzzzzzi_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)vzzzzzzzh_);
                    List<Dosage.DoseAndRateComponent> vzzzzzzzj_ = vzzzzzzzi_?.DoseAndRate;
                    Dosage.DoseAndRateComponent vzzzzzzzk_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)vzzzzzzzj_);
                    DataType vzzzzzzzl_ = vzzzzzzzk_?.Dose;
                    object vzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzl_);
                    CqlQuantity vzzzzzzzn_ = context.Operators.End(vzzzzzzzm_ as CqlInterval<CqlQuantity>);
                    Dosage vzzzzzzzp_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)vzzzzzzzh_);
                    List<Dosage.DoseAndRateComponent> vzzzzzzzq_ = vzzzzzzzp_?.DoseAndRate;
                    Dosage.DoseAndRateComponent vzzzzzzzr_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)vzzzzzzzq_);
                    DataType vzzzzzzzs_ = vzzzzzzzr_?.Dose;
                    object vzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzs_);
                    decimal? vzzzzzzzu_ = (vzzzzzzzn_ ?? vzzzzzzzt_ as CqlQuantity)?.value;
                    Dosage vzzzzzzzw_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)vzzzzzzzh_);
                    Timing vzzzzzzzx_ = vzzzzzzzw_?.Timing;
                    Timing.RepeatComponent vzzzzzzzy_ = vzzzzzzzx_?.Repeat;
                    PositiveInt vzzzzzzzz_ = vzzzzzzzy_?.FrequencyMaxElement;
                    int? wzzzzzzza_ = vzzzzzzzz_?.Value;
                    Dosage wzzzzzzzc_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)vzzzzzzzh_);
                    Timing wzzzzzzzd_ = wzzzzzzzc_?.Timing;
                    Timing.RepeatComponent wzzzzzzze_ = wzzzzzzzd_?.Repeat;
                    PositiveInt wzzzzzzzf_ = wzzzzzzze_?.FrequencyElement;
                    int? wzzzzzzzg_ = wzzzzzzzf_?.Value;
                    Dosage wzzzzzzzi_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)vzzzzzzzh_);
                    Timing wzzzzzzzj_ = wzzzzzzzi_?.Timing;
                    Timing.RepeatComponent wzzzzzzzk_ = wzzzzzzzj_?.Repeat;
                    FhirDecimal wzzzzzzzl_ = wzzzzzzzk_?.PeriodElement;
                    decimal? wzzzzzzzm_ = wzzzzzzzl_?.Value;
                    Dosage wzzzzzzzo_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)vzzzzzzzh_);
                    Timing wzzzzzzzp_ = wzzzzzzzo_?.Timing;
                    Timing.RepeatComponent wzzzzzzzq_ = wzzzzzzzp_?.Repeat;
                    Code<Timing.UnitsOfTime> wzzzzzzzr_ = wzzzzzzzq_?.PeriodUnitElement;
                    Timing.UnitsOfTime? wzzzzzzzs_ = wzzzzzzzr_?.Value;
                    string wzzzzzzzt_ = context.Operators.Convert<string>(wzzzzzzzs_);
                    CqlQuantity wzzzzzzzu_ = this.Quantity(context, wzzzzzzzm_, wzzzzzzzt_);
                    decimal? wzzzzzzzv_ = this.ToDaily(context, wzzzzzzza_ ?? wzzzzzzzg_, wzzzzzzzu_);
                    Dosage wzzzzzzzx_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)vzzzzzzzh_);
                    Timing wzzzzzzzy_ = wzzzzzzzx_?.Timing;
                    Timing.RepeatComponent wzzzzzzzz_ = wzzzzzzzy_?.Repeat;
                    List<Time> xzzzzzzza_ = wzzzzzzzz_?.TimeOfDayElement;
                    IEnumerable<CqlTime> xzzzzzzzb_ = context.Operators.LateBoundProperty<IEnumerable<CqlTime>>(xzzzzzzza_, "value");
                    int? xzzzzzzzc_ = context.Operators.Count<CqlTime>(xzzzzzzzb_);
                    decimal? xzzzzzzzd_ = context.Operators.ConvertIntegerToDecimal(xzzzzzzzc_);
                    decimal? xzzzzzzze_ = context.Operators.Multiply(vzzzzzzzu_, (wzzzzzzzv_ ?? xzzzzzzzd_) ?? 1.0m);
                    decimal? xzzzzzzzf_ = context.Operators.Divide(vzzzzzzzg_, xzzzzzzze_);
                    bool? xzzzzzzzg_ = context.Operators.Not((bool?)((vzzzzzzzd_ ?? xzzzzzzzf_) is null));
                    bool? xzzzzzzzh_ = context.Operators.And(uzzzzzzzz_, xzzzzzzzg_);

                    return xzzzzzzzh_ ?? false;
                };
                if (uzzzzzzzs_())
                {
                    FhirDateTime xzzzzzzzi_ = D?.WhenHandedOverElement;
                    CqlDateTime xzzzzzzzj_ = context.Operators.Convert<CqlDateTime>(xzzzzzzzi_);
                    CqlDate xzzzzzzzk_ = context.Operators.DateFrom(xzzzzzzzj_);
                    FhirDateTime xzzzzzzzl_ = D?.WhenPreparedElement;
                    CqlDateTime xzzzzzzzm_ = context.Operators.Convert<CqlDateTime>(xzzzzzzzl_);
                    CqlDate xzzzzzzzn_ = context.Operators.DateFrom(xzzzzzzzm_);
                    CqlDateTime xzzzzzzzp_ = context.Operators.Convert<CqlDateTime>(xzzzzzzzi_);
                    CqlDate xzzzzzzzq_ = context.Operators.DateFrom(xzzzzzzzp_);
                    CqlDateTime xzzzzzzzs_ = context.Operators.Convert<CqlDateTime>(xzzzzzzzl_);
                    CqlDate xzzzzzzzt_ = context.Operators.DateFrom(xzzzzzzzs_);
                    Quantity xzzzzzzzu_ = D?.DaysSupply;
                    CqlQuantity xzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, xzzzzzzzu_);
                    CqlQuantity xzzzzzzzw_ = context.Operators.ConvertQuantity(xzzzzzzzv_, "d");
                    decimal? xzzzzzzzx_ = xzzzzzzzw_?.value;
                    Quantity xzzzzzzzy_ = D?.Quantity;
                    CqlQuantity xzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, xzzzzzzzy_);
                    decimal? yzzzzzzza_ = xzzzzzzzz_?.value;
                    List<Dosage> yzzzzzzzb_ = D?.DosageInstruction;
                    Dosage yzzzzzzzc_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)yzzzzzzzb_);
                    List<Dosage.DoseAndRateComponent> yzzzzzzzd_ = yzzzzzzzc_?.DoseAndRate;
                    Dosage.DoseAndRateComponent yzzzzzzze_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)yzzzzzzzd_);
                    DataType yzzzzzzzf_ = yzzzzzzze_?.Dose;
                    object yzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzf_);
                    CqlQuantity yzzzzzzzh_ = context.Operators.End(yzzzzzzzg_ as CqlInterval<CqlQuantity>);
                    Dosage yzzzzzzzj_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)yzzzzzzzb_);
                    List<Dosage.DoseAndRateComponent> yzzzzzzzk_ = yzzzzzzzj_?.DoseAndRate;
                    Dosage.DoseAndRateComponent yzzzzzzzl_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)yzzzzzzzk_);
                    DataType yzzzzzzzm_ = yzzzzzzzl_?.Dose;
                    object yzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzm_);
                    decimal? yzzzzzzzo_ = (yzzzzzzzh_ ?? yzzzzzzzn_ as CqlQuantity)?.value;
                    Dosage yzzzzzzzq_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)yzzzzzzzb_);
                    Timing yzzzzzzzr_ = yzzzzzzzq_?.Timing;
                    Timing.RepeatComponent yzzzzzzzs_ = yzzzzzzzr_?.Repeat;
                    PositiveInt yzzzzzzzt_ = yzzzzzzzs_?.FrequencyMaxElement;
                    int? yzzzzzzzu_ = yzzzzzzzt_?.Value;
                    Dosage yzzzzzzzw_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)yzzzzzzzb_);
                    Timing yzzzzzzzx_ = yzzzzzzzw_?.Timing;
                    Timing.RepeatComponent yzzzzzzzy_ = yzzzzzzzx_?.Repeat;
                    PositiveInt yzzzzzzzz_ = yzzzzzzzy_?.FrequencyElement;
                    int? zzzzzzzza_ = yzzzzzzzz_?.Value;
                    Dosage zzzzzzzzc_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)yzzzzzzzb_);
                    Timing zzzzzzzzd_ = zzzzzzzzc_?.Timing;
                    Timing.RepeatComponent zzzzzzzze_ = zzzzzzzzd_?.Repeat;
                    FhirDecimal zzzzzzzzf_ = zzzzzzzze_?.PeriodElement;
                    decimal? zzzzzzzzg_ = zzzzzzzzf_?.Value;
                    Dosage zzzzzzzzi_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)yzzzzzzzb_);
                    Timing zzzzzzzzj_ = zzzzzzzzi_?.Timing;
                    Timing.RepeatComponent zzzzzzzzk_ = zzzzzzzzj_?.Repeat;
                    Code<Timing.UnitsOfTime> zzzzzzzzl_ = zzzzzzzzk_?.PeriodUnitElement;
                    Timing.UnitsOfTime? zzzzzzzzm_ = zzzzzzzzl_?.Value;
                    string zzzzzzzzn_ = context.Operators.Convert<string>(zzzzzzzzm_);
                    CqlQuantity zzzzzzzzo_ = this.Quantity(context, zzzzzzzzg_, zzzzzzzzn_);
                    decimal? zzzzzzzzp_ = this.ToDaily(context, yzzzzzzzu_ ?? zzzzzzzza_, zzzzzzzzo_);
                    Dosage zzzzzzzzr_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)yzzzzzzzb_);
                    Timing zzzzzzzzs_ = zzzzzzzzr_?.Timing;
                    Timing.RepeatComponent zzzzzzzzt_ = zzzzzzzzs_?.Repeat;
                    List<Time> zzzzzzzzu_ = zzzzzzzzt_?.TimeOfDayElement;
                    IEnumerable<CqlTime> zzzzzzzzv_ = context.Operators.LateBoundProperty<IEnumerable<CqlTime>>(zzzzzzzzu_, "value");
                    int? zzzzzzzzw_ = context.Operators.Count<CqlTime>(zzzzzzzzv_);
                    decimal? zzzzzzzzx_ = context.Operators.ConvertIntegerToDecimal(zzzzzzzzw_);
                    decimal? zzzzzzzzy_ = context.Operators.Multiply(yzzzzzzzo_, (zzzzzzzzp_ ?? zzzzzzzzx_) ?? 1.0m);
                    decimal? zzzzzzzzz_ = context.Operators.Divide(yzzzzzzza_, zzzzzzzzy_);
                    decimal? azzzzzzzza_ = context.Operators.ConvertIntegerToDecimal(1);
                    decimal? azzzzzzzzb_ = context.Operators.Subtract(xzzzzzzzx_ ?? zzzzzzzzz_, azzzzzzzza_);
                    CqlQuantity azzzzzzzzc_ = this.Quantity(context, azzzzzzzzb_, "day");
                    CqlDate azzzzzzzzd_ = context.Operators.Add(xzzzzzzzq_ ?? xzzzzzzzt_, azzzzzzzzc_);
                    CqlInterval<CqlDate> azzzzzzzze_ = context.Operators.Interval(xzzzzzzzk_ ?? xzzzzzzzn_, azzzzzzzzd_, true, true);

                    return azzzzzzzze_;
                }
                else
                {
                    return null as CqlInterval<CqlDate>;
                }
            };

            return uzzzzzzzr_();
        };
        IEnumerable<CqlInterval<CqlDate>> uzzzzzzzo_ = context.Operators.Select<MedicationDispense, CqlInterval<CqlDate>>((IEnumerable<MedicationDispense>)uzzzzzzzm_, uzzzzzzzn_);
        IEnumerable<CqlInterval<CqlDate>> uzzzzzzzp_ = context.Operators.Distinct<CqlInterval<CqlDate>>(uzzzzzzzo_);
        CqlInterval<CqlDate> uzzzzzzzq_ = context.Operators.SingletonFrom<CqlInterval<CqlDate>>(uzzzzzzzp_);

        return uzzzzzzzq_;
    }


    [CqlExpressionDefinition("medicationDispensePeriod")]
    public CqlInterval<CqlDate> medicationDispensePeriod(CqlContext context, MedicationDispense Dispense)
    {
        MedicationDispense[] azzzzzzzzf_ = [
            Dispense,
        ];
        CqlInterval<CqlDate> azzzzzzzzg_(MedicationDispense D)
        {
            CqlInterval<CqlDate> azzzzzzzzk_()
            {
                bool azzzzzzzzl_()
                {
                    FhirDateTime azzzzzzzzm_ = D?.WhenHandedOverElement;
                    CqlDateTime azzzzzzzzn_ = context.Operators.Convert<CqlDateTime>(azzzzzzzzm_);
                    CqlDate azzzzzzzzo_ = context.Operators.DateFrom(azzzzzzzzn_);
                    FhirDateTime azzzzzzzzp_ = D?.WhenPreparedElement;
                    CqlDateTime azzzzzzzzq_ = context.Operators.Convert<CqlDateTime>(azzzzzzzzp_);
                    CqlDate azzzzzzzzr_ = context.Operators.DateFrom(azzzzzzzzq_);
                    bool? azzzzzzzzs_ = context.Operators.Not((bool?)((azzzzzzzzo_ ?? azzzzzzzzr_) is null));
                    Quantity azzzzzzzzt_ = D?.DaysSupply;
                    CqlQuantity azzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, azzzzzzzzt_);
                    CqlQuantity azzzzzzzzv_ = context.Operators.ConvertQuantity(azzzzzzzzu_, "d");
                    decimal? azzzzzzzzw_ = azzzzzzzzv_?.value;
                    Quantity azzzzzzzzx_ = D?.Quantity;
                    CqlQuantity azzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, azzzzzzzzx_);
                    decimal? azzzzzzzzz_ = azzzzzzzzy_?.value;
                    List<Dosage> bzzzzzzzza_ = D?.DosageInstruction;
                    Dosage bzzzzzzzzb_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)bzzzzzzzza_);
                    List<Dosage.DoseAndRateComponent> bzzzzzzzzc_ = bzzzzzzzzb_?.DoseAndRate;
                    Dosage.DoseAndRateComponent bzzzzzzzzd_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)bzzzzzzzzc_);
                    DataType bzzzzzzzze_ = bzzzzzzzzd_?.Dose;
                    object bzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzze_);
                    CqlQuantity bzzzzzzzzg_ = context.Operators.End(bzzzzzzzzf_ as CqlInterval<CqlQuantity>);
                    Dosage bzzzzzzzzi_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)bzzzzzzzza_);
                    List<Dosage.DoseAndRateComponent> bzzzzzzzzj_ = bzzzzzzzzi_?.DoseAndRate;
                    Dosage.DoseAndRateComponent bzzzzzzzzk_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)bzzzzzzzzj_);
                    DataType bzzzzzzzzl_ = bzzzzzzzzk_?.Dose;
                    object bzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzl_);
                    decimal? bzzzzzzzzn_ = (bzzzzzzzzg_ ?? bzzzzzzzzm_ as CqlQuantity)?.value;
                    Dosage bzzzzzzzzp_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)bzzzzzzzza_);
                    Timing bzzzzzzzzq_ = bzzzzzzzzp_?.Timing;
                    Timing.RepeatComponent bzzzzzzzzr_ = bzzzzzzzzq_?.Repeat;
                    PositiveInt bzzzzzzzzs_ = bzzzzzzzzr_?.FrequencyMaxElement;
                    int? bzzzzzzzzt_ = bzzzzzzzzs_?.Value;
                    Dosage bzzzzzzzzv_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)bzzzzzzzza_);
                    Timing bzzzzzzzzw_ = bzzzzzzzzv_?.Timing;
                    Timing.RepeatComponent bzzzzzzzzx_ = bzzzzzzzzw_?.Repeat;
                    PositiveInt bzzzzzzzzy_ = bzzzzzzzzx_?.FrequencyElement;
                    int? bzzzzzzzzz_ = bzzzzzzzzy_?.Value;
                    Dosage czzzzzzzzb_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)bzzzzzzzza_);
                    Timing czzzzzzzzc_ = czzzzzzzzb_?.Timing;
                    Timing.RepeatComponent czzzzzzzzd_ = czzzzzzzzc_?.Repeat;
                    FhirDecimal czzzzzzzze_ = czzzzzzzzd_?.PeriodElement;
                    decimal? czzzzzzzzf_ = czzzzzzzze_?.Value;
                    Dosage czzzzzzzzh_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)bzzzzzzzza_);
                    Timing czzzzzzzzi_ = czzzzzzzzh_?.Timing;
                    Timing.RepeatComponent czzzzzzzzj_ = czzzzzzzzi_?.Repeat;
                    Code<Timing.UnitsOfTime> czzzzzzzzk_ = czzzzzzzzj_?.PeriodUnitElement;
                    Timing.UnitsOfTime? czzzzzzzzl_ = czzzzzzzzk_?.Value;
                    string czzzzzzzzm_ = context.Operators.Convert<string>(czzzzzzzzl_);
                    CqlQuantity czzzzzzzzn_ = this.Quantity(context, czzzzzzzzf_, czzzzzzzzm_);
                    decimal? czzzzzzzzo_ = this.ToDaily(context, bzzzzzzzzt_ ?? bzzzzzzzzz_, czzzzzzzzn_);
                    Dosage czzzzzzzzq_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)bzzzzzzzza_);
                    Timing czzzzzzzzr_ = czzzzzzzzq_?.Timing;
                    Timing.RepeatComponent czzzzzzzzs_ = czzzzzzzzr_?.Repeat;
                    List<Time> czzzzzzzzt_ = czzzzzzzzs_?.TimeOfDayElement;
                    IEnumerable<CqlTime> czzzzzzzzu_ = context.Operators.LateBoundProperty<IEnumerable<CqlTime>>(czzzzzzzzt_, "value");
                    int? czzzzzzzzv_ = context.Operators.Count<CqlTime>(czzzzzzzzu_);
                    decimal? czzzzzzzzw_ = context.Operators.ConvertIntegerToDecimal(czzzzzzzzv_);
                    decimal? czzzzzzzzx_ = context.Operators.Multiply(bzzzzzzzzn_, (czzzzzzzzo_ ?? czzzzzzzzw_) ?? 1.0m);
                    decimal? czzzzzzzzy_ = context.Operators.Divide(azzzzzzzzz_, czzzzzzzzx_);
                    bool? czzzzzzzzz_ = context.Operators.Not((bool?)((azzzzzzzzw_ ?? czzzzzzzzy_) is null));
                    bool? dzzzzzzzza_ = context.Operators.And(azzzzzzzzs_, czzzzzzzzz_);

                    return dzzzzzzzza_ ?? false;
                };
                if (azzzzzzzzl_())
                {
                    FhirDateTime dzzzzzzzzb_ = D?.WhenHandedOverElement;
                    CqlDateTime dzzzzzzzzc_ = context.Operators.Convert<CqlDateTime>(dzzzzzzzzb_);
                    CqlDate dzzzzzzzzd_ = context.Operators.DateFrom(dzzzzzzzzc_);
                    FhirDateTime dzzzzzzzze_ = D?.WhenPreparedElement;
                    CqlDateTime dzzzzzzzzf_ = context.Operators.Convert<CqlDateTime>(dzzzzzzzze_);
                    CqlDate dzzzzzzzzg_ = context.Operators.DateFrom(dzzzzzzzzf_);
                    CqlDateTime dzzzzzzzzi_ = context.Operators.Convert<CqlDateTime>(dzzzzzzzzb_);
                    CqlDate dzzzzzzzzj_ = context.Operators.DateFrom(dzzzzzzzzi_);
                    CqlDateTime dzzzzzzzzl_ = context.Operators.Convert<CqlDateTime>(dzzzzzzzze_);
                    CqlDate dzzzzzzzzm_ = context.Operators.DateFrom(dzzzzzzzzl_);
                    Quantity dzzzzzzzzn_ = D?.DaysSupply;
                    CqlQuantity dzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, dzzzzzzzzn_);
                    CqlQuantity dzzzzzzzzp_ = context.Operators.ConvertQuantity(dzzzzzzzzo_, "d");
                    decimal? dzzzzzzzzq_ = dzzzzzzzzp_?.value;
                    Quantity dzzzzzzzzr_ = D?.Quantity;
                    CqlQuantity dzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, dzzzzzzzzr_);
                    decimal? dzzzzzzzzt_ = dzzzzzzzzs_?.value;
                    List<Dosage> dzzzzzzzzu_ = D?.DosageInstruction;
                    Dosage dzzzzzzzzv_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)dzzzzzzzzu_);
                    List<Dosage.DoseAndRateComponent> dzzzzzzzzw_ = dzzzzzzzzv_?.DoseAndRate;
                    Dosage.DoseAndRateComponent dzzzzzzzzx_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)dzzzzzzzzw_);
                    DataType dzzzzzzzzy_ = dzzzzzzzzx_?.Dose;
                    object dzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzy_);
                    CqlQuantity ezzzzzzzza_ = context.Operators.End(dzzzzzzzzz_ as CqlInterval<CqlQuantity>);
                    Dosage ezzzzzzzzc_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)dzzzzzzzzu_);
                    List<Dosage.DoseAndRateComponent> ezzzzzzzzd_ = ezzzzzzzzc_?.DoseAndRate;
                    Dosage.DoseAndRateComponent ezzzzzzzze_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)ezzzzzzzzd_);
                    DataType ezzzzzzzzf_ = ezzzzzzzze_?.Dose;
                    object ezzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzf_);
                    decimal? ezzzzzzzzh_ = (ezzzzzzzza_ ?? ezzzzzzzzg_ as CqlQuantity)?.value;
                    Dosage ezzzzzzzzj_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)dzzzzzzzzu_);
                    Timing ezzzzzzzzk_ = ezzzzzzzzj_?.Timing;
                    Timing.RepeatComponent ezzzzzzzzl_ = ezzzzzzzzk_?.Repeat;
                    PositiveInt ezzzzzzzzm_ = ezzzzzzzzl_?.FrequencyMaxElement;
                    int? ezzzzzzzzn_ = ezzzzzzzzm_?.Value;
                    Dosage ezzzzzzzzp_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)dzzzzzzzzu_);
                    Timing ezzzzzzzzq_ = ezzzzzzzzp_?.Timing;
                    Timing.RepeatComponent ezzzzzzzzr_ = ezzzzzzzzq_?.Repeat;
                    PositiveInt ezzzzzzzzs_ = ezzzzzzzzr_?.FrequencyElement;
                    int? ezzzzzzzzt_ = ezzzzzzzzs_?.Value;
                    Dosage ezzzzzzzzv_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)dzzzzzzzzu_);
                    Timing ezzzzzzzzw_ = ezzzzzzzzv_?.Timing;
                    Timing.RepeatComponent ezzzzzzzzx_ = ezzzzzzzzw_?.Repeat;
                    FhirDecimal ezzzzzzzzy_ = ezzzzzzzzx_?.PeriodElement;
                    decimal? ezzzzzzzzz_ = ezzzzzzzzy_?.Value;
                    Dosage fzzzzzzzzb_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)dzzzzzzzzu_);
                    Timing fzzzzzzzzc_ = fzzzzzzzzb_?.Timing;
                    Timing.RepeatComponent fzzzzzzzzd_ = fzzzzzzzzc_?.Repeat;
                    Code<Timing.UnitsOfTime> fzzzzzzzze_ = fzzzzzzzzd_?.PeriodUnitElement;
                    Timing.UnitsOfTime? fzzzzzzzzf_ = fzzzzzzzze_?.Value;
                    string fzzzzzzzzg_ = context.Operators.Convert<string>(fzzzzzzzzf_);
                    CqlQuantity fzzzzzzzzh_ = this.Quantity(context, ezzzzzzzzz_, fzzzzzzzzg_);
                    decimal? fzzzzzzzzi_ = this.ToDaily(context, ezzzzzzzzn_ ?? ezzzzzzzzt_, fzzzzzzzzh_);
                    Dosage fzzzzzzzzk_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)dzzzzzzzzu_);
                    Timing fzzzzzzzzl_ = fzzzzzzzzk_?.Timing;
                    Timing.RepeatComponent fzzzzzzzzm_ = fzzzzzzzzl_?.Repeat;
                    List<Time> fzzzzzzzzn_ = fzzzzzzzzm_?.TimeOfDayElement;
                    IEnumerable<CqlTime> fzzzzzzzzo_ = context.Operators.LateBoundProperty<IEnumerable<CqlTime>>(fzzzzzzzzn_, "value");
                    int? fzzzzzzzzp_ = context.Operators.Count<CqlTime>(fzzzzzzzzo_);
                    decimal? fzzzzzzzzq_ = context.Operators.ConvertIntegerToDecimal(fzzzzzzzzp_);
                    decimal? fzzzzzzzzr_ = context.Operators.Multiply(ezzzzzzzzh_, (fzzzzzzzzi_ ?? fzzzzzzzzq_) ?? 1.0m);
                    decimal? fzzzzzzzzs_ = context.Operators.Divide(dzzzzzzzzt_, fzzzzzzzzr_);
                    decimal? fzzzzzzzzt_ = context.Operators.ConvertIntegerToDecimal(1);
                    decimal? fzzzzzzzzu_ = context.Operators.Subtract(dzzzzzzzzq_ ?? fzzzzzzzzs_, fzzzzzzzzt_);
                    CqlQuantity fzzzzzzzzv_ = this.Quantity(context, fzzzzzzzzu_, "day");
                    CqlDate fzzzzzzzzw_ = context.Operators.Add(dzzzzzzzzj_ ?? dzzzzzzzzm_, fzzzzzzzzv_);
                    CqlInterval<CqlDate> fzzzzzzzzx_ = context.Operators.Interval(dzzzzzzzzd_ ?? dzzzzzzzzg_, fzzzzzzzzw_, true, true);

                    return fzzzzzzzzx_;
                }
                else
                {
                    return null as CqlInterval<CqlDate>;
                }
            };

            return azzzzzzzzk_();
        };
        IEnumerable<CqlInterval<CqlDate>> azzzzzzzzh_ = context.Operators.Select<MedicationDispense, CqlInterval<CqlDate>>((IEnumerable<MedicationDispense>)azzzzzzzzf_, azzzzzzzzg_);
        IEnumerable<CqlInterval<CqlDate>> azzzzzzzzi_ = context.Operators.Distinct<CqlInterval<CqlDate>>(azzzzzzzzh_);
        CqlInterval<CqlDate> azzzzzzzzj_ = context.Operators.SingletonFrom<CqlInterval<CqlDate>>(azzzzzzzzi_);

        return azzzzzzzzj_;
    }


    [CqlExpressionDefinition("TherapeuticDuration")]
    public CqlQuantity TherapeuticDuration(CqlContext context, CqlConcept medication)
    {
        CqlQuantity fzzzzzzzzy_ = context.Operators.Quantity(14m, "days");

        return fzzzzzzzzy_;
    }


    [CqlExpressionDefinition("MedicationAdministrationPeriod")]
    public CqlInterval<CqlDate> MedicationAdministrationPeriod(CqlContext context, MedicationAdministration Administration)
    {
        MedicationAdministration[] fzzzzzzzzz_ = [
            Administration,
        ];
        CqlInterval<CqlDate> gzzzzzzzza_(MedicationAdministration M)
        {
            CqlInterval<CqlDate> gzzzzzzzze_()
            {
                bool gzzzzzzzzf_()
                {
                    DataType gzzzzzzzzg_ = Administration?.Effective;
                    object gzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzg_);
                    CqlDateTime gzzzzzzzzi_ = context.Operators.Start(gzzzzzzzzh_ as CqlInterval<CqlDateTime>);
                    CqlDate gzzzzzzzzj_ = context.Operators.DateFrom(gzzzzzzzzi_);
                    bool? gzzzzzzzzk_ = context.Operators.Not((bool?)(gzzzzzzzzj_ is null));
                    DataType gzzzzzzzzl_ = Administration?.Medication;
                    object gzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzl_);
                    CqlQuantity gzzzzzzzzn_ = this.TherapeuticDuration(context, gzzzzzzzzm_ as CqlConcept);
                    bool? gzzzzzzzzo_ = context.Operators.Not((bool?)(gzzzzzzzzn_ is null));
                    bool? gzzzzzzzzp_ = context.Operators.And(gzzzzzzzzk_, gzzzzzzzzo_);

                    return gzzzzzzzzp_ ?? false;
                };
                if (gzzzzzzzzf_())
                {
                    DataType gzzzzzzzzq_ = Administration?.Effective;
                    object gzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzq_);
                    CqlDateTime gzzzzzzzzs_ = context.Operators.Start(gzzzzzzzzr_ as CqlInterval<CqlDateTime>);
                    CqlDate gzzzzzzzzt_ = context.Operators.DateFrom(gzzzzzzzzs_);
                    object gzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzq_);
                    CqlDateTime gzzzzzzzzw_ = context.Operators.Start(gzzzzzzzzv_ as CqlInterval<CqlDateTime>);
                    CqlDate gzzzzzzzzx_ = context.Operators.DateFrom(gzzzzzzzzw_);
                    DataType gzzzzzzzzy_ = Administration?.Medication;
                    object gzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzy_);
                    CqlQuantity hzzzzzzzza_ = this.TherapeuticDuration(context, gzzzzzzzzz_ as CqlConcept);
                    CqlDate hzzzzzzzzb_ = context.Operators.Add(gzzzzzzzzx_, hzzzzzzzza_);
                    CqlQuantity hzzzzzzzzc_ = context.Operators.ConvertIntegerToQuantity(1);
                    CqlDate hzzzzzzzzd_ = context.Operators.Subtract(hzzzzzzzzb_, hzzzzzzzzc_);
                    CqlInterval<CqlDate> hzzzzzzzze_ = context.Operators.Interval(gzzzzzzzzt_, hzzzzzzzzd_, true, true);

                    return hzzzzzzzze_;
                }
                else
                {
                    return null as CqlInterval<CqlDate>;
                }
            };

            return gzzzzzzzze_();
        };
        IEnumerable<CqlInterval<CqlDate>> gzzzzzzzzb_ = context.Operators.Select<MedicationAdministration, CqlInterval<CqlDate>>((IEnumerable<MedicationAdministration>)fzzzzzzzzz_, gzzzzzzzza_);
        IEnumerable<CqlInterval<CqlDate>> gzzzzzzzzc_ = context.Operators.Distinct<CqlInterval<CqlDate>>(gzzzzzzzzb_);
        CqlInterval<CqlDate> gzzzzzzzzd_ = context.Operators.SingletonFrom<CqlInterval<CqlDate>>(gzzzzzzzzc_);

        return gzzzzzzzzd_;
    }


    [CqlExpressionDefinition("medicationAdministrationPeriod")]
    public CqlInterval<CqlDate> medicationAdministrationPeriod(CqlContext context, MedicationAdministration Administration)
    {
        MedicationAdministration[] hzzzzzzzzf_ = [
            Administration,
        ];
        CqlInterval<CqlDate> hzzzzzzzzg_(MedicationAdministration M)
        {
            CqlInterval<CqlDate> hzzzzzzzzk_()
            {
                bool hzzzzzzzzl_()
                {
                    DataType hzzzzzzzzm_ = Administration?.Effective;
                    object hzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzm_);
                    CqlDateTime hzzzzzzzzo_ = context.Operators.Start(hzzzzzzzzn_ as CqlInterval<CqlDateTime>);
                    CqlDate hzzzzzzzzp_ = context.Operators.DateFrom(hzzzzzzzzo_);
                    bool? hzzzzzzzzq_ = context.Operators.Not((bool?)(hzzzzzzzzp_ is null));
                    DataType hzzzzzzzzr_ = Administration?.Medication;
                    object hzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzr_);
                    CqlQuantity hzzzzzzzzt_ = this.TherapeuticDuration(context, hzzzzzzzzs_ as CqlConcept);
                    bool? hzzzzzzzzu_ = context.Operators.Not((bool?)(hzzzzzzzzt_ is null));
                    bool? hzzzzzzzzv_ = context.Operators.And(hzzzzzzzzq_, hzzzzzzzzu_);

                    return hzzzzzzzzv_ ?? false;
                };
                if (hzzzzzzzzl_())
                {
                    DataType hzzzzzzzzw_ = Administration?.Effective;
                    object hzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzw_);
                    CqlDateTime hzzzzzzzzy_ = context.Operators.Start(hzzzzzzzzx_ as CqlInterval<CqlDateTime>);
                    CqlDate hzzzzzzzzz_ = context.Operators.DateFrom(hzzzzzzzzy_);
                    object izzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzw_);
                    CqlDateTime izzzzzzzzc_ = context.Operators.Start(izzzzzzzzb_ as CqlInterval<CqlDateTime>);
                    CqlDate izzzzzzzzd_ = context.Operators.DateFrom(izzzzzzzzc_);
                    DataType izzzzzzzze_ = Administration?.Medication;
                    object izzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzze_);
                    CqlQuantity izzzzzzzzg_ = this.TherapeuticDuration(context, izzzzzzzzf_ as CqlConcept);
                    CqlDate izzzzzzzzh_ = context.Operators.Add(izzzzzzzzd_, izzzzzzzzg_);
                    CqlQuantity izzzzzzzzi_ = context.Operators.ConvertIntegerToQuantity(1);
                    CqlDate izzzzzzzzj_ = context.Operators.Subtract(izzzzzzzzh_, izzzzzzzzi_);
                    CqlInterval<CqlDate> izzzzzzzzk_ = context.Operators.Interval(hzzzzzzzzz_, izzzzzzzzj_, true, true);

                    return izzzzzzzzk_;
                }
                else
                {
                    return null as CqlInterval<CqlDate>;
                }
            };

            return hzzzzzzzzk_();
        };
        IEnumerable<CqlInterval<CqlDate>> hzzzzzzzzh_ = context.Operators.Select<MedicationAdministration, CqlInterval<CqlDate>>((IEnumerable<MedicationAdministration>)hzzzzzzzzf_, hzzzzzzzzg_);
        IEnumerable<CqlInterval<CqlDate>> hzzzzzzzzi_ = context.Operators.Distinct<CqlInterval<CqlDate>>(hzzzzzzzzh_);
        CqlInterval<CqlDate> hzzzzzzzzj_ = context.Operators.SingletonFrom<CqlInterval<CqlDate>>(hzzzzzzzzi_);

        return hzzzzzzzzj_;
    }


    [CqlExpressionDefinition("CumulativeDuration")]
    public int? CumulativeDuration(CqlContext context, IEnumerable<CqlInterval<CqlDate>> Intervals)
    {
        int? izzzzzzzzl_()
        {
            if ((context.Operators.Not((bool?)(Intervals is null))) ?? false)
            {
                IEnumerable<CqlInterval<CqlDate>> izzzzzzzzm_ = context.Operators.Collapse(Intervals, "day");
                int? izzzzzzzzn_(CqlInterval<CqlDate> X)
                {
                    CqlDate izzzzzzzzq_ = context.Operators.Start(X);
                    CqlDate izzzzzzzzr_ = context.Operators.End(X);
                    int? izzzzzzzzs_ = context.Operators.DifferenceBetween(izzzzzzzzq_, izzzzzzzzr_, "day");
                    int? izzzzzzzzt_ = context.Operators.Add(izzzzzzzzs_, 1);

                    return izzzzzzzzt_;
                };
                IEnumerable<int?> izzzzzzzzo_ = context.Operators.Select<CqlInterval<CqlDate>, int?>(izzzzzzzzm_, izzzzzzzzn_);
                int? izzzzzzzzp_ = context.Operators.Sum(izzzzzzzzo_);

                return izzzzzzzzp_;
            }
            else
            {
                return default;
            }
        };

        return izzzzzzzzl_();
    }


    [CqlExpressionDefinition("cumulativeDuration")]
    public int? cumulativeDuration(CqlContext context, IEnumerable<CqlInterval<CqlDate>> Intervals)
    {
        int? izzzzzzzzu_()
        {
            if ((context.Operators.Not((bool?)(Intervals is null))) ?? false)
            {
                IEnumerable<CqlInterval<CqlDate>> izzzzzzzzv_ = context.Operators.Collapse(Intervals, "day");
                int? izzzzzzzzw_(CqlInterval<CqlDate> X)
                {
                    CqlDate izzzzzzzzz_ = context.Operators.Start(X);
                    CqlDate jzzzzzzzza_ = context.Operators.End(X);
                    int? jzzzzzzzzb_ = context.Operators.DifferenceBetween(izzzzzzzzz_, jzzzzzzzza_, "day");
                    int? jzzzzzzzzc_ = context.Operators.Add(jzzzzzzzzb_, 1);

                    return jzzzzzzzzc_;
                };
                IEnumerable<int?> izzzzzzzzx_ = context.Operators.Select<CqlInterval<CqlDate>, int?>(izzzzzzzzv_, izzzzzzzzw_);
                int? izzzzzzzzy_ = context.Operators.Sum(izzzzzzzzx_);

                return izzzzzzzzy_;
            }
            else
            {
                return default;
            }
        };

        return izzzzzzzzu_();
    }


    [CqlExpressionDefinition("RolloutIntervals")]
    public IEnumerable<CqlInterval<CqlDate>> RolloutIntervals(CqlContext context, IEnumerable<CqlInterval<CqlDate>> intervals)
    {
        IEnumerable<CqlInterval<CqlDate>> jzzzzzzzzd_(IEnumerable<CqlInterval<CqlDate>> R, CqlInterval<CqlDate> I)
        {
            CqlInterval<CqlDate>[] jzzzzzzzzf_ = [
                I,
            ];
            CqlInterval<CqlDate> jzzzzzzzzg_(CqlInterval<CqlDate> X)
            {
                CqlInterval<CqlDate> jzzzzzzzzm_ = context.Operators.Last<CqlInterval<CqlDate>>(R);
                CqlDate jzzzzzzzzn_ = context.Operators.End(jzzzzzzzzm_);
                CqlQuantity jzzzzzzzzo_ = context.Operators.Quantity(1m, "day");
                CqlDate jzzzzzzzzp_ = context.Operators.Add(jzzzzzzzzn_, jzzzzzzzzo_);
                CqlDate jzzzzzzzzq_ = context.Operators.Start(X);
                CqlDate[] jzzzzzzzzr_ = [
                    jzzzzzzzzp_,
                    jzzzzzzzzq_,
                ];
                CqlDate jzzzzzzzzs_ = context.Operators.Max<CqlDate>(jzzzzzzzzr_ as IEnumerable<CqlDate>);
                CqlDate jzzzzzzzzu_ = context.Operators.End(jzzzzzzzzm_);
                CqlDate jzzzzzzzzw_ = context.Operators.Add(jzzzzzzzzu_, jzzzzzzzzo_);
                CqlDate[] jzzzzzzzzy_ = [
                    jzzzzzzzzw_,
                    jzzzzzzzzq_,
                ];
                CqlDate jzzzzzzzzz_ = context.Operators.Max<CqlDate>(jzzzzzzzzy_ as IEnumerable<CqlDate>);
                CqlDate kzzzzzzzzb_ = context.Operators.End(X);
                int? kzzzzzzzzc_ = context.Operators.DurationBetween(jzzzzzzzzq_, kzzzzzzzzb_, "day");
                decimal? kzzzzzzzzd_ = context.Operators.ConvertIntegerToDecimal(kzzzzzzzzc_ ?? 0);
                CqlQuantity kzzzzzzzze_ = this.Quantity(context, kzzzzzzzzd_, "day");
                CqlDate kzzzzzzzzf_ = context.Operators.Add(jzzzzzzzzz_, kzzzzzzzze_);
                CqlInterval<CqlDate> kzzzzzzzzg_ = context.Operators.Interval(jzzzzzzzzs_, kzzzzzzzzf_, true, true);

                return kzzzzzzzzg_;
            };
            IEnumerable<CqlInterval<CqlDate>> jzzzzzzzzh_ = context.Operators.Select<CqlInterval<CqlDate>, CqlInterval<CqlDate>>((IEnumerable<CqlInterval<CqlDate>>)jzzzzzzzzf_, jzzzzzzzzg_);
            IEnumerable<CqlInterval<CqlDate>> jzzzzzzzzi_ = context.Operators.Distinct<CqlInterval<CqlDate>>(jzzzzzzzzh_);
            CqlInterval<CqlDate> jzzzzzzzzj_ = context.Operators.SingletonFrom<CqlInterval<CqlDate>>(jzzzzzzzzi_);
            CqlInterval<CqlDate>[] jzzzzzzzzk_ = [
                jzzzzzzzzj_,
            ];
            IEnumerable<CqlInterval<CqlDate>> jzzzzzzzzl_ = context.Operators.Union<CqlInterval<CqlDate>>(R, jzzzzzzzzk_ as IEnumerable<CqlInterval<CqlDate>>);

            return jzzzzzzzzl_;
        };
        IEnumerable<CqlInterval<CqlDate>> jzzzzzzzze_ = context.Operators.Aggregate<CqlInterval<CqlDate>, IEnumerable<CqlInterval<CqlDate>>>(intervals, jzzzzzzzzd_, null as IEnumerable<CqlInterval<CqlDate>>);

        return jzzzzzzzze_;
    }


    [CqlExpressionDefinition("rolloutIntervals")]
    public IEnumerable<CqlInterval<CqlDate>> rolloutIntervals(CqlContext context, IEnumerable<CqlInterval<CqlDate>> intervals)
    {
        IEnumerable<CqlInterval<CqlDate>> kzzzzzzzzh_(IEnumerable<CqlInterval<CqlDate>> R, CqlInterval<CqlDate> I)
        {
            CqlInterval<CqlDate>[] kzzzzzzzzj_ = [
                I,
            ];
            CqlInterval<CqlDate> kzzzzzzzzk_(CqlInterval<CqlDate> X)
            {
                CqlInterval<CqlDate> kzzzzzzzzq_ = context.Operators.Last<CqlInterval<CqlDate>>(R);
                CqlDate kzzzzzzzzr_ = context.Operators.End(kzzzzzzzzq_);
                CqlQuantity kzzzzzzzzs_ = context.Operators.Quantity(1m, "day");
                CqlDate kzzzzzzzzt_ = context.Operators.Add(kzzzzzzzzr_, kzzzzzzzzs_);
                CqlDate kzzzzzzzzu_ = context.Operators.Start(X);
                CqlDate[] kzzzzzzzzv_ = [
                    kzzzzzzzzt_,
                    kzzzzzzzzu_,
                ];
                CqlDate kzzzzzzzzw_ = context.Operators.Max<CqlDate>(kzzzzzzzzv_ as IEnumerable<CqlDate>);
                CqlDate kzzzzzzzzy_ = context.Operators.End(kzzzzzzzzq_);
                CqlDate lzzzzzzzza_ = context.Operators.Add(kzzzzzzzzy_, kzzzzzzzzs_);
                CqlDate[] lzzzzzzzzc_ = [
                    lzzzzzzzza_,
                    kzzzzzzzzu_,
                ];
                CqlDate lzzzzzzzzd_ = context.Operators.Max<CqlDate>(lzzzzzzzzc_ as IEnumerable<CqlDate>);
                CqlDate lzzzzzzzzf_ = context.Operators.End(X);
                int? lzzzzzzzzg_ = context.Operators.DurationBetween(kzzzzzzzzu_, lzzzzzzzzf_, "day");
                decimal? lzzzzzzzzh_ = context.Operators.ConvertIntegerToDecimal(lzzzzzzzzg_ ?? 0);
                CqlQuantity lzzzzzzzzi_ = this.Quantity(context, lzzzzzzzzh_, "day");
                CqlDate lzzzzzzzzj_ = context.Operators.Add(lzzzzzzzzd_, lzzzzzzzzi_);
                CqlInterval<CqlDate> lzzzzzzzzk_ = context.Operators.Interval(kzzzzzzzzw_, lzzzzzzzzj_, true, true);

                return lzzzzzzzzk_;
            };
            IEnumerable<CqlInterval<CqlDate>> kzzzzzzzzl_ = context.Operators.Select<CqlInterval<CqlDate>, CqlInterval<CqlDate>>((IEnumerable<CqlInterval<CqlDate>>)kzzzzzzzzj_, kzzzzzzzzk_);
            IEnumerable<CqlInterval<CqlDate>> kzzzzzzzzm_ = context.Operators.Distinct<CqlInterval<CqlDate>>(kzzzzzzzzl_);
            CqlInterval<CqlDate> kzzzzzzzzn_ = context.Operators.SingletonFrom<CqlInterval<CqlDate>>(kzzzzzzzzm_);
            CqlInterval<CqlDate>[] kzzzzzzzzo_ = [
                kzzzzzzzzn_,
            ];
            IEnumerable<CqlInterval<CqlDate>> kzzzzzzzzp_ = context.Operators.Union<CqlInterval<CqlDate>>(R, kzzzzzzzzo_ as IEnumerable<CqlInterval<CqlDate>>);

            return kzzzzzzzzp_;
        };
        IEnumerable<CqlInterval<CqlDate>> kzzzzzzzzi_ = context.Operators.Aggregate<CqlInterval<CqlDate>, IEnumerable<CqlInterval<CqlDate>>>(intervals, kzzzzzzzzh_, null as IEnumerable<CqlInterval<CqlDate>>);

        return kzzzzzzzzi_;
    }


    [CqlExpressionDefinition("MedicationPeriod")]
    public CqlInterval<CqlDate> MedicationPeriod(CqlContext context, object medication)
    {
        CqlInterval<CqlDate> lzzzzzzzzl_()
        {
            if (medication is MedicationRequest)
            {
                CqlInterval<CqlDate> lzzzzzzzzm_ = this.MedicationRequestPeriod(context, medication as MedicationRequest);

                return lzzzzzzzzm_;
            }
            else if (medication is MedicationDispense)
            {
                CqlInterval<CqlDate> lzzzzzzzzn_ = this.MedicationDispensePeriod(context, medication as MedicationDispense);

                return lzzzzzzzzn_;
            }
            else
            {
                return null as CqlInterval<CqlDate>;
            }
        };

        return lzzzzzzzzl_();
    }


    [CqlExpressionDefinition("medicationPeriod")]
    public CqlInterval<CqlDate> medicationPeriod(CqlContext context, object medication)
    {
        CqlInterval<CqlDate> lzzzzzzzzo_()
        {
            if (medication is MedicationRequest)
            {
                CqlInterval<CqlDate> lzzzzzzzzp_ = this.medicationRequestPeriod(context, medication as MedicationRequest);

                return lzzzzzzzzp_;
            }
            else if (medication is MedicationDispense)
            {
                CqlInterval<CqlDate> lzzzzzzzzq_ = this.medicationDispensePeriod(context, medication as MedicationDispense);

                return lzzzzzzzzq_;
            }
            else
            {
                return null as CqlInterval<CqlDate>;
            }
        };

        return lzzzzzzzzo_();
    }


    [CqlExpressionDefinition("CumulativeMedicationDuration")]
    public int? CumulativeMedicationDuration(CqlContext context, IEnumerable<object> Medications)
    {
        bool? lzzzzzzzzr_(object M)
        {
            bool mzzzzzzzze_ = M is MedicationRequest;

            return mzzzzzzzze_ as bool?;
        };
        IEnumerable<object> lzzzzzzzzs_ = context.Operators.Where<object>(Medications, lzzzzzzzzr_);
        CqlInterval<CqlDate> lzzzzzzzzt_(object M)
        {
            CqlInterval<CqlDate> mzzzzzzzzf_ = this.MedicationRequestPeriod(context, M as MedicationRequest);

            return mzzzzzzzzf_;
        };
        IEnumerable<CqlInterval<CqlDate>> lzzzzzzzzu_ = context.Operators.Select<object, CqlInterval<CqlDate>>(lzzzzzzzzs_, lzzzzzzzzt_);
        IEnumerable<CqlInterval<CqlDate>> lzzzzzzzzv_ = context.Operators.Distinct<CqlInterval<CqlDate>>(lzzzzzzzzu_);
        bool? lzzzzzzzzw_(object M)
        {
            bool mzzzzzzzzg_ = M is MedicationDispense;

            return mzzzzzzzzg_ as bool?;
        };
        IEnumerable<object> lzzzzzzzzx_ = context.Operators.Where<object>(Medications, lzzzzzzzzw_);
        CqlInterval<CqlDate> lzzzzzzzzy_(object M)
        {
            CqlInterval<CqlDate> mzzzzzzzzh_ = this.MedicationDispensePeriod(context, M as MedicationDispense);

            return mzzzzzzzzh_;
        };
        IEnumerable<CqlInterval<CqlDate>> lzzzzzzzzz_ = context.Operators.Select<object, CqlInterval<CqlDate>>(lzzzzzzzzx_, lzzzzzzzzy_);
        IEnumerable<CqlInterval<CqlDate>> mzzzzzzzza_ = context.Operators.Distinct<CqlInterval<CqlDate>>(lzzzzzzzzz_);
        IEnumerable<CqlInterval<CqlDate>> mzzzzzzzzb_ = this.RolloutIntervals(context, mzzzzzzzza_);
        IEnumerable<CqlInterval<CqlDate>> mzzzzzzzzc_ = context.Operators.Union<CqlInterval<CqlDate>>(lzzzzzzzzv_, mzzzzzzzzb_);
        int? mzzzzzzzzd_ = this.CumulativeDuration(context, mzzzzzzzzc_);

        return mzzzzzzzzd_;
    }


    [CqlExpressionDefinition("cumulativeMedicationDuration")]
    public int? cumulativeMedicationDuration(CqlContext context, IEnumerable<object> Medications)
    {
        bool? mzzzzzzzzi_(object M)
        {
            bool mzzzzzzzzv_ = M is MedicationRequest;

            return mzzzzzzzzv_ as bool?;
        };
        IEnumerable<object> mzzzzzzzzj_ = context.Operators.Where<object>(Medications, mzzzzzzzzi_);
        CqlInterval<CqlDate> mzzzzzzzzk_(object M)
        {
            CqlInterval<CqlDate> mzzzzzzzzw_ = this.medicationRequestPeriod(context, M as MedicationRequest);

            return mzzzzzzzzw_;
        };
        IEnumerable<CqlInterval<CqlDate>> mzzzzzzzzl_ = context.Operators.Select<object, CqlInterval<CqlDate>>(mzzzzzzzzj_, mzzzzzzzzk_);
        IEnumerable<CqlInterval<CqlDate>> mzzzzzzzzm_ = context.Operators.Distinct<CqlInterval<CqlDate>>(mzzzzzzzzl_);
        bool? mzzzzzzzzn_(object M)
        {
            bool mzzzzzzzzx_ = M is MedicationDispense;

            return mzzzzzzzzx_ as bool?;
        };
        IEnumerable<object> mzzzzzzzzo_ = context.Operators.Where<object>(Medications, mzzzzzzzzn_);
        CqlInterval<CqlDate> mzzzzzzzzp_(object M)
        {
            CqlInterval<CqlDate> mzzzzzzzzy_ = this.medicationDispensePeriod(context, M as MedicationDispense);

            return mzzzzzzzzy_;
        };
        IEnumerable<CqlInterval<CqlDate>> mzzzzzzzzq_ = context.Operators.Select<object, CqlInterval<CqlDate>>(mzzzzzzzzo_, mzzzzzzzzp_);
        IEnumerable<CqlInterval<CqlDate>> mzzzzzzzzr_ = context.Operators.Distinct<CqlInterval<CqlDate>>(mzzzzzzzzq_);
        IEnumerable<CqlInterval<CqlDate>> mzzzzzzzzs_ = this.rolloutIntervals(context, mzzzzzzzzr_);
        IEnumerable<CqlInterval<CqlDate>> mzzzzzzzzt_ = context.Operators.Union<CqlInterval<CqlDate>>(mzzzzzzzzm_, mzzzzzzzzs_);
        int? mzzzzzzzzu_ = this.cumulativeDuration(context, mzzzzzzzzt_);

        return mzzzzzzzzu_;
    }


    #endregion Expressions

}
