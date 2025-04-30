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

    [CqlCodeSystemDefinition("EventTiming")]
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

    #region Parameters

    [CqlParameterDefinition("ErrorLevel")]
    public string ErrorLevel(CqlContext context)
    {
        object mzzzzzzzzzg_ = context.ResolveParameter("CumulativeMedicationDuration-4.1.000", "ErrorLevel", "Warning");

        return (string)mzzzzzzzzzg_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> mzzzzzzzzzh_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient mzzzzzzzzzi_ = context.Operators.SingletonFrom<Patient>(mzzzzzzzzzh_);

        return mzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("ToDaily")]
    public decimal? ToDaily(CqlContext context, int? frequency, CqlQuantity period)
    {
        decimal? mzzzzzzzzzj_()
        {
            bool mzzzzzzzzzk_()
            {
                string nzzzzzzzzzf_ = period?.unit;
                bool? nzzzzzzzzzg_ = context.Operators.Equal(nzzzzzzzzzf_, "h");

                return nzzzzzzzzzg_ ?? false;
            };
            bool mzzzzzzzzzl_()
            {
                string nzzzzzzzzzh_ = period?.unit;
                bool? nzzzzzzzzzi_ = context.Operators.Equal(nzzzzzzzzzh_, "min");

                return nzzzzzzzzzi_ ?? false;
            };
            bool mzzzzzzzzzm_()
            {
                string nzzzzzzzzzj_ = period?.unit;
                bool? nzzzzzzzzzk_ = context.Operators.Equal(nzzzzzzzzzj_, "s");

                return nzzzzzzzzzk_ ?? false;
            };
            bool mzzzzzzzzzn_()
            {
                string nzzzzzzzzzl_ = period?.unit;
                bool? nzzzzzzzzzm_ = context.Operators.Equal(nzzzzzzzzzl_, "d");

                return nzzzzzzzzzm_ ?? false;
            };
            bool mzzzzzzzzzo_()
            {
                string nzzzzzzzzzn_ = period?.unit;
                bool? nzzzzzzzzzo_ = context.Operators.Equal(nzzzzzzzzzn_, "wk");

                return nzzzzzzzzzo_ ?? false;
            };
            bool mzzzzzzzzzp_()
            {
                string nzzzzzzzzzp_ = period?.unit;
                bool? nzzzzzzzzzq_ = context.Operators.Equal(nzzzzzzzzzp_, "mo");

                return nzzzzzzzzzq_ ?? false;
            };
            bool mzzzzzzzzzq_()
            {
                string nzzzzzzzzzr_ = period?.unit;
                bool? nzzzzzzzzzs_ = context.Operators.Equal(nzzzzzzzzzr_, "a");

                return nzzzzzzzzzs_ ?? false;
            };
            bool mzzzzzzzzzr_()
            {
                string nzzzzzzzzzt_ = period?.unit;
                bool? nzzzzzzzzzu_ = context.Operators.Equal(nzzzzzzzzzt_, "hour");

                return nzzzzzzzzzu_ ?? false;
            };
            bool mzzzzzzzzzs_()
            {
                string nzzzzzzzzzv_ = period?.unit;
                bool? nzzzzzzzzzw_ = context.Operators.Equal(nzzzzzzzzzv_, "minute");

                return nzzzzzzzzzw_ ?? false;
            };
            bool mzzzzzzzzzt_()
            {
                string nzzzzzzzzzx_ = period?.unit;
                bool? nzzzzzzzzzy_ = context.Operators.Equal(nzzzzzzzzzx_, "second");

                return nzzzzzzzzzy_ ?? false;
            };
            bool mzzzzzzzzzu_()
            {
                string nzzzzzzzzzz_ = period?.unit;
                bool? ozzzzzzzzza_ = context.Operators.Equal(nzzzzzzzzzz_, "day");

                return ozzzzzzzzza_ ?? false;
            };
            bool mzzzzzzzzzv_()
            {
                string ozzzzzzzzzb_ = period?.unit;
                bool? ozzzzzzzzzc_ = context.Operators.Equal(ozzzzzzzzzb_, "week");

                return ozzzzzzzzzc_ ?? false;
            };
            bool mzzzzzzzzzw_()
            {
                string ozzzzzzzzzd_ = period?.unit;
                bool? ozzzzzzzzze_ = context.Operators.Equal(ozzzzzzzzzd_, "month");

                return ozzzzzzzzze_ ?? false;
            };
            bool mzzzzzzzzzx_()
            {
                string ozzzzzzzzzf_ = period?.unit;
                bool? ozzzzzzzzzg_ = context.Operators.Equal(ozzzzzzzzzf_, "year");

                return ozzzzzzzzzg_ ?? false;
            };
            bool mzzzzzzzzzy_()
            {
                string ozzzzzzzzzh_ = period?.unit;
                bool? ozzzzzzzzzi_ = context.Operators.Equal(ozzzzzzzzzh_, "hours");

                return ozzzzzzzzzi_ ?? false;
            };
            bool mzzzzzzzzzz_()
            {
                string ozzzzzzzzzj_ = period?.unit;
                bool? ozzzzzzzzzk_ = context.Operators.Equal(ozzzzzzzzzj_, "minutes");

                return ozzzzzzzzzk_ ?? false;
            };
            bool nzzzzzzzzza_()
            {
                string ozzzzzzzzzl_ = period?.unit;
                bool? ozzzzzzzzzm_ = context.Operators.Equal(ozzzzzzzzzl_, "seconds");

                return ozzzzzzzzzm_ ?? false;
            };
            bool nzzzzzzzzzb_()
            {
                string ozzzzzzzzzn_ = period?.unit;
                bool? ozzzzzzzzzo_ = context.Operators.Equal(ozzzzzzzzzn_, "days");

                return ozzzzzzzzzo_ ?? false;
            };
            bool nzzzzzzzzzc_()
            {
                string ozzzzzzzzzp_ = period?.unit;
                bool? ozzzzzzzzzq_ = context.Operators.Equal(ozzzzzzzzzp_, "weeks");

                return ozzzzzzzzzq_ ?? false;
            };
            bool nzzzzzzzzzd_()
            {
                string ozzzzzzzzzr_ = period?.unit;
                bool? ozzzzzzzzzs_ = context.Operators.Equal(ozzzzzzzzzr_, "months");

                return ozzzzzzzzzs_ ?? false;
            };
            bool nzzzzzzzzze_()
            {
                string ozzzzzzzzzt_ = period?.unit;
                bool? ozzzzzzzzzu_ = context.Operators.Equal(ozzzzzzzzzt_, "years");

                return ozzzzzzzzzu_ ?? false;
            };
            if (mzzzzzzzzzk_())
            {
                decimal? ozzzzzzzzzv_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? ozzzzzzzzzw_ = period?.value;
                decimal? ozzzzzzzzzx_ = context.Operators.Divide(24.0m, ozzzzzzzzzw_);
                decimal? ozzzzzzzzzy_ = context.Operators.Multiply(ozzzzzzzzzv_, ozzzzzzzzzx_);

                return ozzzzzzzzzy_;
            }
            else if (mzzzzzzzzzl_())
            {
                decimal? ozzzzzzzzzz_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? pzzzzzzzzza_ = period?.value;
                decimal? pzzzzzzzzzb_ = context.Operators.Divide(24.0m, pzzzzzzzzza_);
                decimal? pzzzzzzzzzc_ = context.Operators.Multiply(ozzzzzzzzzz_, pzzzzzzzzzb_);
                decimal? pzzzzzzzzzd_ = context.Operators.ConvertIntegerToDecimal(60);
                decimal? pzzzzzzzzze_ = context.Operators.Multiply(pzzzzzzzzzc_, pzzzzzzzzzd_);

                return pzzzzzzzzze_;
            }
            else if (mzzzzzzzzzm_())
            {
                decimal? pzzzzzzzzzf_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? pzzzzzzzzzg_ = period?.value;
                decimal? pzzzzzzzzzh_ = context.Operators.Divide(24.0m, pzzzzzzzzzg_);
                decimal? pzzzzzzzzzi_ = context.Operators.Multiply(pzzzzzzzzzf_, pzzzzzzzzzh_);
                decimal? pzzzzzzzzzj_ = context.Operators.ConvertIntegerToDecimal(60);
                decimal? pzzzzzzzzzk_ = context.Operators.Multiply(pzzzzzzzzzi_, pzzzzzzzzzj_);
                decimal? pzzzzzzzzzm_ = context.Operators.Multiply(pzzzzzzzzzk_, pzzzzzzzzzj_);

                return pzzzzzzzzzm_;
            }
            else if (mzzzzzzzzzn_())
            {
                decimal? pzzzzzzzzzn_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? pzzzzzzzzzo_ = period?.value;
                decimal? pzzzzzzzzzp_ = context.Operators.Divide(24.0m, pzzzzzzzzzo_);
                decimal? pzzzzzzzzzq_ = context.Operators.Multiply(pzzzzzzzzzn_, pzzzzzzzzzp_);
                decimal? pzzzzzzzzzr_ = context.Operators.ConvertIntegerToDecimal(24);
                decimal? pzzzzzzzzzs_ = context.Operators.Divide(pzzzzzzzzzq_, pzzzzzzzzzr_);

                return pzzzzzzzzzs_;
            }
            else if (mzzzzzzzzzo_())
            {
                decimal? pzzzzzzzzzt_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? pzzzzzzzzzu_ = period?.value;
                decimal? pzzzzzzzzzv_ = context.Operators.Divide(24.0m, pzzzzzzzzzu_);
                decimal? pzzzzzzzzzw_ = context.Operators.Multiply(pzzzzzzzzzt_, pzzzzzzzzzv_);
                int? pzzzzzzzzzx_ = context.Operators.Multiply(24, 7);
                decimal? pzzzzzzzzzy_ = context.Operators.ConvertIntegerToDecimal(pzzzzzzzzzx_);
                decimal? pzzzzzzzzzz_ = context.Operators.Divide(pzzzzzzzzzw_, pzzzzzzzzzy_);

                return pzzzzzzzzzz_;
            }
            else if (mzzzzzzzzzp_())
            {
                decimal? qzzzzzzzzza_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? qzzzzzzzzzb_ = period?.value;
                decimal? qzzzzzzzzzc_ = context.Operators.Divide(24.0m, qzzzzzzzzzb_);
                decimal? qzzzzzzzzzd_ = context.Operators.Multiply(qzzzzzzzzza_, qzzzzzzzzzc_);
                int? qzzzzzzzzze_ = context.Operators.Multiply(24, 30);
                decimal? qzzzzzzzzzf_ = context.Operators.ConvertIntegerToDecimal(qzzzzzzzzze_);
                decimal? qzzzzzzzzzg_ = context.Operators.Divide(qzzzzzzzzzd_, qzzzzzzzzzf_);

                return qzzzzzzzzzg_;
            }
            else if (mzzzzzzzzzq_())
            {
                decimal? qzzzzzzzzzh_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? qzzzzzzzzzi_ = period?.value;
                decimal? qzzzzzzzzzj_ = context.Operators.Divide(24.0m, qzzzzzzzzzi_);
                decimal? qzzzzzzzzzk_ = context.Operators.Multiply(qzzzzzzzzzh_, qzzzzzzzzzj_);
                int? qzzzzzzzzzl_ = context.Operators.Multiply(24, 365);
                decimal? qzzzzzzzzzm_ = context.Operators.ConvertIntegerToDecimal(qzzzzzzzzzl_);
                decimal? qzzzzzzzzzn_ = context.Operators.Divide(qzzzzzzzzzk_, qzzzzzzzzzm_);

                return qzzzzzzzzzn_;
            }
            else if (mzzzzzzzzzr_())
            {
                decimal? qzzzzzzzzzo_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? qzzzzzzzzzp_ = period?.value;
                decimal? qzzzzzzzzzq_ = context.Operators.Divide(24.0m, qzzzzzzzzzp_);
                decimal? qzzzzzzzzzr_ = context.Operators.Multiply(qzzzzzzzzzo_, qzzzzzzzzzq_);

                return qzzzzzzzzzr_;
            }
            else if (mzzzzzzzzzs_())
            {
                decimal? qzzzzzzzzzs_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? qzzzzzzzzzt_ = period?.value;
                decimal? qzzzzzzzzzu_ = context.Operators.Divide(24.0m, qzzzzzzzzzt_);
                decimal? qzzzzzzzzzv_ = context.Operators.Multiply(qzzzzzzzzzs_, qzzzzzzzzzu_);
                decimal? qzzzzzzzzzw_ = context.Operators.ConvertIntegerToDecimal(60);
                decimal? qzzzzzzzzzx_ = context.Operators.Multiply(qzzzzzzzzzv_, qzzzzzzzzzw_);

                return qzzzzzzzzzx_;
            }
            else if (mzzzzzzzzzt_())
            {
                decimal? qzzzzzzzzzy_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? qzzzzzzzzzz_ = period?.value;
                decimal? rzzzzzzzzza_ = context.Operators.Divide(24.0m, qzzzzzzzzzz_);
                decimal? rzzzzzzzzzb_ = context.Operators.Multiply(qzzzzzzzzzy_, rzzzzzzzzza_);
                decimal? rzzzzzzzzzc_ = context.Operators.ConvertIntegerToDecimal(60);
                decimal? rzzzzzzzzzd_ = context.Operators.Multiply(rzzzzzzzzzb_, rzzzzzzzzzc_);
                decimal? rzzzzzzzzzf_ = context.Operators.Multiply(rzzzzzzzzzd_, rzzzzzzzzzc_);

                return rzzzzzzzzzf_;
            }
            else if (mzzzzzzzzzu_())
            {
                decimal? rzzzzzzzzzg_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? rzzzzzzzzzh_ = period?.value;
                decimal? rzzzzzzzzzi_ = context.Operators.Divide(24.0m, rzzzzzzzzzh_);
                decimal? rzzzzzzzzzj_ = context.Operators.Multiply(rzzzzzzzzzg_, rzzzzzzzzzi_);
                decimal? rzzzzzzzzzk_ = context.Operators.ConvertIntegerToDecimal(24);
                decimal? rzzzzzzzzzl_ = context.Operators.Divide(rzzzzzzzzzj_, rzzzzzzzzzk_);

                return rzzzzzzzzzl_;
            }
            else if (mzzzzzzzzzv_())
            {
                decimal? rzzzzzzzzzm_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? rzzzzzzzzzn_ = period?.value;
                decimal? rzzzzzzzzzo_ = context.Operators.Divide(24.0m, rzzzzzzzzzn_);
                decimal? rzzzzzzzzzp_ = context.Operators.Multiply(rzzzzzzzzzm_, rzzzzzzzzzo_);
                int? rzzzzzzzzzq_ = context.Operators.Multiply(24, 7);
                decimal? rzzzzzzzzzr_ = context.Operators.ConvertIntegerToDecimal(rzzzzzzzzzq_);
                decimal? rzzzzzzzzzs_ = context.Operators.Divide(rzzzzzzzzzp_, rzzzzzzzzzr_);

                return rzzzzzzzzzs_;
            }
            else if (mzzzzzzzzzw_())
            {
                decimal? rzzzzzzzzzt_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? rzzzzzzzzzu_ = period?.value;
                decimal? rzzzzzzzzzv_ = context.Operators.Divide(24.0m, rzzzzzzzzzu_);
                decimal? rzzzzzzzzzw_ = context.Operators.Multiply(rzzzzzzzzzt_, rzzzzzzzzzv_);
                int? rzzzzzzzzzx_ = context.Operators.Multiply(24, 30);
                decimal? rzzzzzzzzzy_ = context.Operators.ConvertIntegerToDecimal(rzzzzzzzzzx_);
                decimal? rzzzzzzzzzz_ = context.Operators.Divide(rzzzzzzzzzw_, rzzzzzzzzzy_);

                return rzzzzzzzzzz_;
            }
            else if (mzzzzzzzzzx_())
            {
                decimal? szzzzzzzzza_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? szzzzzzzzzb_ = period?.value;
                decimal? szzzzzzzzzc_ = context.Operators.Divide(24.0m, szzzzzzzzzb_);
                decimal? szzzzzzzzzd_ = context.Operators.Multiply(szzzzzzzzza_, szzzzzzzzzc_);
                int? szzzzzzzzze_ = context.Operators.Multiply(24, 365);
                decimal? szzzzzzzzzf_ = context.Operators.ConvertIntegerToDecimal(szzzzzzzzze_);
                decimal? szzzzzzzzzg_ = context.Operators.Divide(szzzzzzzzzd_, szzzzzzzzzf_);

                return szzzzzzzzzg_;
            }
            else if (mzzzzzzzzzy_())
            {
                decimal? szzzzzzzzzh_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? szzzzzzzzzi_ = period?.value;
                decimal? szzzzzzzzzj_ = context.Operators.Divide(24.0m, szzzzzzzzzi_);
                decimal? szzzzzzzzzk_ = context.Operators.Multiply(szzzzzzzzzh_, szzzzzzzzzj_);

                return szzzzzzzzzk_;
            }
            else if (mzzzzzzzzzz_())
            {
                decimal? szzzzzzzzzl_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? szzzzzzzzzm_ = period?.value;
                decimal? szzzzzzzzzn_ = context.Operators.Divide(24.0m, szzzzzzzzzm_);
                decimal? szzzzzzzzzo_ = context.Operators.Multiply(szzzzzzzzzl_, szzzzzzzzzn_);
                decimal? szzzzzzzzzp_ = context.Operators.ConvertIntegerToDecimal(60);
                decimal? szzzzzzzzzq_ = context.Operators.Multiply(szzzzzzzzzo_, szzzzzzzzzp_);

                return szzzzzzzzzq_;
            }
            else if (nzzzzzzzzza_())
            {
                decimal? szzzzzzzzzr_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? szzzzzzzzzs_ = period?.value;
                decimal? szzzzzzzzzt_ = context.Operators.Divide(24.0m, szzzzzzzzzs_);
                decimal? szzzzzzzzzu_ = context.Operators.Multiply(szzzzzzzzzr_, szzzzzzzzzt_);
                decimal? szzzzzzzzzv_ = context.Operators.ConvertIntegerToDecimal(60);
                decimal? szzzzzzzzzw_ = context.Operators.Multiply(szzzzzzzzzu_, szzzzzzzzzv_);
                decimal? szzzzzzzzzy_ = context.Operators.Multiply(szzzzzzzzzw_, szzzzzzzzzv_);

                return szzzzzzzzzy_;
            }
            else if (nzzzzzzzzzb_())
            {
                decimal? szzzzzzzzzz_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? tzzzzzzzzza_ = period?.value;
                decimal? tzzzzzzzzzb_ = context.Operators.Divide(24.0m, tzzzzzzzzza_);
                decimal? tzzzzzzzzzc_ = context.Operators.Multiply(szzzzzzzzzz_, tzzzzzzzzzb_);
                decimal? tzzzzzzzzzd_ = context.Operators.ConvertIntegerToDecimal(24);
                decimal? tzzzzzzzzze_ = context.Operators.Divide(tzzzzzzzzzc_, tzzzzzzzzzd_);

                return tzzzzzzzzze_;
            }
            else if (nzzzzzzzzzc_())
            {
                decimal? tzzzzzzzzzf_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? tzzzzzzzzzg_ = period?.value;
                decimal? tzzzzzzzzzh_ = context.Operators.Divide(24.0m, tzzzzzzzzzg_);
                decimal? tzzzzzzzzzi_ = context.Operators.Multiply(tzzzzzzzzzf_, tzzzzzzzzzh_);
                int? tzzzzzzzzzj_ = context.Operators.Multiply(24, 7);
                decimal? tzzzzzzzzzk_ = context.Operators.ConvertIntegerToDecimal(tzzzzzzzzzj_);
                decimal? tzzzzzzzzzl_ = context.Operators.Divide(tzzzzzzzzzi_, tzzzzzzzzzk_);

                return tzzzzzzzzzl_;
            }
            else if (nzzzzzzzzzd_())
            {
                decimal? tzzzzzzzzzm_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? tzzzzzzzzzn_ = period?.value;
                decimal? tzzzzzzzzzo_ = context.Operators.Divide(24.0m, tzzzzzzzzzn_);
                decimal? tzzzzzzzzzp_ = context.Operators.Multiply(tzzzzzzzzzm_, tzzzzzzzzzo_);
                int? tzzzzzzzzzq_ = context.Operators.Multiply(24, 30);
                decimal? tzzzzzzzzzr_ = context.Operators.ConvertIntegerToDecimal(tzzzzzzzzzq_);
                decimal? tzzzzzzzzzs_ = context.Operators.Divide(tzzzzzzzzzp_, tzzzzzzzzzr_);

                return tzzzzzzzzzs_;
            }
            else if (nzzzzzzzzze_())
            {
                decimal? tzzzzzzzzzt_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? tzzzzzzzzzu_ = period?.value;
                decimal? tzzzzzzzzzv_ = context.Operators.Divide(24.0m, tzzzzzzzzzu_);
                decimal? tzzzzzzzzzw_ = context.Operators.Multiply(tzzzzzzzzzt_, tzzzzzzzzzv_);
                int? tzzzzzzzzzx_ = context.Operators.Multiply(24, 365);
                decimal? tzzzzzzzzzy_ = context.Operators.ConvertIntegerToDecimal(tzzzzzzzzzx_);
                decimal? tzzzzzzzzzz_ = context.Operators.Divide(tzzzzzzzzzw_, tzzzzzzzzzy_);

                return tzzzzzzzzzz_;
            }
            else
            {
                string uzzzzzzzzza_ = this.ErrorLevel(context);
                string uzzzzzzzzzb_ = period?.unit;
                string uzzzzzzzzzc_ = context.Operators.Concatenate("Unknown unit ", uzzzzzzzzzb_ ?? "");
                object uzzzzzzzzzd_ = context.Operators.Message<object>(null, "CMDLogic.ToDaily.UnknownUnit", uzzzzzzzzza_, uzzzzzzzzzc_);

                return uzzzzzzzzzd_ as decimal?;
            }
        };

        return mzzzzzzzzzj_();
    }


    [CqlExpressionDefinition("ToDaily")]
    public decimal? ToDaily(CqlContext context, CqlCode frequency)
    {
        decimal? uzzzzzzzzze_()
        {
            bool uzzzzzzzzzf_()
            {
                CqlCode wzzzzzzzzza_ = this.HS(context);
                bool? wzzzzzzzzzb_ = context.Operators.Equivalent(frequency, wzzzzzzzzza_);

                return wzzzzzzzzzb_ ?? false;
            };
            bool uzzzzzzzzzg_()
            {
                CqlCode wzzzzzzzzzc_ = this.WAKE(context);
                bool? wzzzzzzzzzd_ = context.Operators.Equivalent(frequency, wzzzzzzzzzc_);

                return wzzzzzzzzzd_ ?? false;
            };
            bool uzzzzzzzzzh_()
            {
                CqlCode wzzzzzzzzze_ = this.C(context);
                bool? wzzzzzzzzzf_ = context.Operators.Equivalent(frequency, wzzzzzzzzze_);

                return wzzzzzzzzzf_ ?? false;
            };
            bool uzzzzzzzzzi_()
            {
                CqlCode wzzzzzzzzzg_ = this.CM(context);
                bool? wzzzzzzzzzh_ = context.Operators.Equivalent(frequency, wzzzzzzzzzg_);

                return wzzzzzzzzzh_ ?? false;
            };
            bool uzzzzzzzzzj_()
            {
                CqlCode wzzzzzzzzzi_ = this.CD(context);
                bool? wzzzzzzzzzj_ = context.Operators.Equivalent(frequency, wzzzzzzzzzi_);

                return wzzzzzzzzzj_ ?? false;
            };
            bool uzzzzzzzzzk_()
            {
                CqlCode wzzzzzzzzzk_ = this.CV(context);
                bool? wzzzzzzzzzl_ = context.Operators.Equivalent(frequency, wzzzzzzzzzk_);

                return wzzzzzzzzzl_ ?? false;
            };
            bool uzzzzzzzzzl_()
            {
                CqlCode wzzzzzzzzzm_ = this.AC(context);
                bool? wzzzzzzzzzn_ = context.Operators.Equivalent(frequency, wzzzzzzzzzm_);

                return wzzzzzzzzzn_ ?? false;
            };
            bool uzzzzzzzzzm_()
            {
                CqlCode wzzzzzzzzzo_ = this.ACM(context);
                bool? wzzzzzzzzzp_ = context.Operators.Equivalent(frequency, wzzzzzzzzzo_);

                return wzzzzzzzzzp_ ?? false;
            };
            bool uzzzzzzzzzn_()
            {
                CqlCode wzzzzzzzzzq_ = this.ACD(context);
                bool? wzzzzzzzzzr_ = context.Operators.Equivalent(frequency, wzzzzzzzzzq_);

                return wzzzzzzzzzr_ ?? false;
            };
            bool uzzzzzzzzzo_()
            {
                CqlCode wzzzzzzzzzs_ = this.ACV(context);
                bool? wzzzzzzzzzt_ = context.Operators.Equivalent(frequency, wzzzzzzzzzs_);

                return wzzzzzzzzzt_ ?? false;
            };
            bool uzzzzzzzzzp_()
            {
                CqlCode wzzzzzzzzzu_ = this.PC(context);
                bool? wzzzzzzzzzv_ = context.Operators.Equivalent(frequency, wzzzzzzzzzu_);

                return wzzzzzzzzzv_ ?? false;
            };
            bool uzzzzzzzzzq_()
            {
                CqlCode wzzzzzzzzzw_ = this.PCM(context);
                bool? wzzzzzzzzzx_ = context.Operators.Equivalent(frequency, wzzzzzzzzzw_);

                return wzzzzzzzzzx_ ?? false;
            };
            bool uzzzzzzzzzr_()
            {
                CqlCode wzzzzzzzzzy_ = this.PCD(context);
                bool? wzzzzzzzzzz_ = context.Operators.Equivalent(frequency, wzzzzzzzzzy_);

                return wzzzzzzzzzz_ ?? false;
            };
            bool uzzzzzzzzzs_()
            {
                CqlCode xzzzzzzzzza_ = this.PCV(context);
                bool? xzzzzzzzzzb_ = context.Operators.Equivalent(frequency, xzzzzzzzzza_);

                return xzzzzzzzzzb_ ?? false;
            };
            bool uzzzzzzzzzt_()
            {
                CqlCode xzzzzzzzzzc_ = this.MORN(context);
                bool? xzzzzzzzzzd_ = context.Operators.Equivalent(frequency, xzzzzzzzzzc_);

                return xzzzzzzzzzd_ ?? false;
            };
            bool uzzzzzzzzzu_()
            {
                CqlCode xzzzzzzzzze_ = this.MORN_early(context);
                bool? xzzzzzzzzzf_ = context.Operators.Equivalent(frequency, xzzzzzzzzze_);

                return xzzzzzzzzzf_ ?? false;
            };
            bool uzzzzzzzzzv_()
            {
                CqlCode xzzzzzzzzzg_ = this.MORN_late(context);
                bool? xzzzzzzzzzh_ = context.Operators.Equivalent(frequency, xzzzzzzzzzg_);

                return xzzzzzzzzzh_ ?? false;
            };
            bool uzzzzzzzzzw_()
            {
                CqlCode xzzzzzzzzzi_ = this.NOON(context);
                bool? xzzzzzzzzzj_ = context.Operators.Equivalent(frequency, xzzzzzzzzzi_);

                return xzzzzzzzzzj_ ?? false;
            };
            bool uzzzzzzzzzx_()
            {
                CqlCode xzzzzzzzzzk_ = this.AFT(context);
                bool? xzzzzzzzzzl_ = context.Operators.Equivalent(frequency, xzzzzzzzzzk_);

                return xzzzzzzzzzl_ ?? false;
            };
            bool uzzzzzzzzzy_()
            {
                CqlCode xzzzzzzzzzm_ = this.AFT_early(context);
                bool? xzzzzzzzzzn_ = context.Operators.Equivalent(frequency, xzzzzzzzzzm_);

                return xzzzzzzzzzn_ ?? false;
            };
            bool uzzzzzzzzzz_()
            {
                CqlCode xzzzzzzzzzo_ = this.AFT_late(context);
                bool? xzzzzzzzzzp_ = context.Operators.Equivalent(frequency, xzzzzzzzzzo_);

                return xzzzzzzzzzp_ ?? false;
            };
            bool vzzzzzzzzza_()
            {
                CqlCode xzzzzzzzzzq_ = this.EVE(context);
                bool? xzzzzzzzzzr_ = context.Operators.Equivalent(frequency, xzzzzzzzzzq_);

                return xzzzzzzzzzr_ ?? false;
            };
            bool vzzzzzzzzzb_()
            {
                CqlCode xzzzzzzzzzs_ = this.EVE_early(context);
                bool? xzzzzzzzzzt_ = context.Operators.Equivalent(frequency, xzzzzzzzzzs_);

                return xzzzzzzzzzt_ ?? false;
            };
            bool vzzzzzzzzzc_()
            {
                CqlCode xzzzzzzzzzu_ = this.EVE_late(context);
                bool? xzzzzzzzzzv_ = context.Operators.Equivalent(frequency, xzzzzzzzzzu_);

                return xzzzzzzzzzv_ ?? false;
            };
            bool vzzzzzzzzzd_()
            {
                CqlCode xzzzzzzzzzw_ = this.NIGHT(context);
                bool? xzzzzzzzzzx_ = context.Operators.Equivalent(frequency, xzzzzzzzzzw_);

                return xzzzzzzzzzx_ ?? false;
            };
            bool vzzzzzzzzze_()
            {
                CqlCode xzzzzzzzzzy_ = this.PHS(context);
                bool? xzzzzzzzzzz_ = context.Operators.Equivalent(frequency, xzzzzzzzzzy_);

                return xzzzzzzzzzz_ ?? false;
            };
            bool vzzzzzzzzzf_()
            {
                CqlCode yzzzzzzzzza_ = this.Once_daily__qualifier_value_(context);
                bool? yzzzzzzzzzb_ = context.Operators.Equivalent(frequency, yzzzzzzzzza_);

                return yzzzzzzzzzb_ ?? false;
            };
            bool vzzzzzzzzzg_()
            {
                CqlCode yzzzzzzzzzc_ = this.Twice_a_day__qualifier_value_(context);
                bool? yzzzzzzzzzd_ = context.Operators.Equivalent(frequency, yzzzzzzzzzc_);

                return yzzzzzzzzzd_ ?? false;
            };
            bool vzzzzzzzzzh_()
            {
                CqlCode yzzzzzzzzze_ = this.Three_times_daily__qualifier_value_(context);
                bool? yzzzzzzzzzf_ = context.Operators.Equivalent(frequency, yzzzzzzzzze_);

                return yzzzzzzzzzf_ ?? false;
            };
            bool vzzzzzzzzzi_()
            {
                CqlCode yzzzzzzzzzg_ = this.Four_times_daily__qualifier_value_(context);
                bool? yzzzzzzzzzh_ = context.Operators.Equivalent(frequency, yzzzzzzzzzg_);

                return yzzzzzzzzzh_ ?? false;
            };
            bool vzzzzzzzzzj_()
            {
                CqlCode yzzzzzzzzzi_ = this.Every_twenty_four_hours__qualifier_value_(context);
                bool? yzzzzzzzzzj_ = context.Operators.Equivalent(frequency, yzzzzzzzzzi_);

                return yzzzzzzzzzj_ ?? false;
            };
            bool vzzzzzzzzzk_()
            {
                CqlCode yzzzzzzzzzk_ = this.Every_twelve_hours__qualifier_value_(context);
                bool? yzzzzzzzzzl_ = context.Operators.Equivalent(frequency, yzzzzzzzzzk_);

                return yzzzzzzzzzl_ ?? false;
            };
            bool vzzzzzzzzzl_()
            {
                CqlCode yzzzzzzzzzm_ = this.Every_thirty_six_hours__qualifier_value_(context);
                bool? yzzzzzzzzzn_ = context.Operators.Equivalent(frequency, yzzzzzzzzzm_);

                return yzzzzzzzzzn_ ?? false;
            };
            bool vzzzzzzzzzm_()
            {
                CqlCode yzzzzzzzzzo_ = this.Every_eight_hours__qualifier_value_(context);
                bool? yzzzzzzzzzp_ = context.Operators.Equivalent(frequency, yzzzzzzzzzo_);

                return yzzzzzzzzzp_ ?? false;
            };
            bool vzzzzzzzzzn_()
            {
                CqlCode yzzzzzzzzzq_ = this.Every_four_hours__qualifier_value_(context);
                bool? yzzzzzzzzzr_ = context.Operators.Equivalent(frequency, yzzzzzzzzzq_);

                return yzzzzzzzzzr_ ?? false;
            };
            bool vzzzzzzzzzo_()
            {
                CqlCode yzzzzzzzzzs_ = this.Every_six_hours__qualifier_value_(context);
                bool? yzzzzzzzzzt_ = context.Operators.Equivalent(frequency, yzzzzzzzzzs_);

                return yzzzzzzzzzt_ ?? false;
            };
            bool vzzzzzzzzzp_()
            {
                CqlCode yzzzzzzzzzu_ = this.Every_seventy_two_hours__qualifier_value_(context);
                bool? yzzzzzzzzzv_ = context.Operators.Equivalent(frequency, yzzzzzzzzzu_);

                return yzzzzzzzzzv_ ?? false;
            };
            bool vzzzzzzzzzq_()
            {
                CqlCode yzzzzzzzzzw_ = this.Every_forty_eight_hours__qualifier_value_(context);
                bool? yzzzzzzzzzx_ = context.Operators.Equivalent(frequency, yzzzzzzzzzw_);

                return yzzzzzzzzzx_ ?? false;
            };
            bool vzzzzzzzzzr_()
            {
                CqlCode yzzzzzzzzzy_ = this.Every_eight_to_twelve_hours__qualifier_value_(context);
                bool? yzzzzzzzzzz_ = context.Operators.Equivalent(frequency, yzzzzzzzzzy_);

                return yzzzzzzzzzz_ ?? false;
            };
            bool vzzzzzzzzzs_()
            {
                CqlCode zzzzzzzzzza_ = this.Every_six_to_eight_hours__qualifier_value_(context);
                bool? zzzzzzzzzzb_ = context.Operators.Equivalent(frequency, zzzzzzzzzza_);

                return zzzzzzzzzzb_ ?? false;
            };
            bool vzzzzzzzzzt_()
            {
                CqlCode zzzzzzzzzzc_ = this.Every_three_to_four_hours__qualifier_value_(context);
                bool? zzzzzzzzzzd_ = context.Operators.Equivalent(frequency, zzzzzzzzzzc_);

                return zzzzzzzzzzd_ ?? false;
            };
            bool vzzzzzzzzzu_()
            {
                CqlCode zzzzzzzzzze_ = this.Every_three_to_six_hours__qualifier_value_(context);
                bool? zzzzzzzzzzf_ = context.Operators.Equivalent(frequency, zzzzzzzzzze_);

                return zzzzzzzzzzf_ ?? false;
            };
            bool vzzzzzzzzzv_()
            {
                CqlCode zzzzzzzzzzg_ = this.Every_two_to_four_hours__qualifier_value_(context);
                bool? zzzzzzzzzzh_ = context.Operators.Equivalent(frequency, zzzzzzzzzzg_);

                return zzzzzzzzzzh_ ?? false;
            };
            bool vzzzzzzzzzw_()
            {
                CqlCode zzzzzzzzzzi_ = this.One_to_four_times_a_day__qualifier_value_(context);
                bool? zzzzzzzzzzj_ = context.Operators.Equivalent(frequency, zzzzzzzzzzi_);

                return zzzzzzzzzzj_ ?? false;
            };
            bool vzzzzzzzzzx_()
            {
                CqlCode zzzzzzzzzzk_ = this.One_to_three_times_a_day__qualifier_value_(context);
                bool? zzzzzzzzzzl_ = context.Operators.Equivalent(frequency, zzzzzzzzzzk_);

                return zzzzzzzzzzl_ ?? false;
            };
            bool vzzzzzzzzzy_()
            {
                CqlCode zzzzzzzzzzm_ = this.One_to_two_times_a_day__qualifier_value_(context);
                bool? zzzzzzzzzzn_ = context.Operators.Equivalent(frequency, zzzzzzzzzzm_);

                return zzzzzzzzzzn_ ?? false;
            };
            bool vzzzzzzzzzz_()
            {
                CqlCode zzzzzzzzzzo_ = this.Two_to_four_times_a_day__qualifier_value_(context);
                bool? zzzzzzzzzzp_ = context.Operators.Equivalent(frequency, zzzzzzzzzzo_);

                return zzzzzzzzzzp_ ?? false;
            };
            if (uzzzzzzzzzf_())
            {
                decimal? zzzzzzzzzzq_ = context.Operators.ConvertIntegerToDecimal(1);

                return zzzzzzzzzzq_;
            }
            else if (uzzzzzzzzzg_())
            {
                decimal? zzzzzzzzzzr_ = context.Operators.ConvertIntegerToDecimal(1);

                return zzzzzzzzzzr_;
            }
            else if (uzzzzzzzzzh_())
            {
                decimal? zzzzzzzzzzs_ = context.Operators.ConvertIntegerToDecimal(3);

                return zzzzzzzzzzs_;
            }
            else if (uzzzzzzzzzi_())
            {
                decimal? zzzzzzzzzzt_ = context.Operators.ConvertIntegerToDecimal(1);

                return zzzzzzzzzzt_;
            }
            else if (uzzzzzzzzzj_())
            {
                decimal? zzzzzzzzzzu_ = context.Operators.ConvertIntegerToDecimal(1);

                return zzzzzzzzzzu_;
            }
            else if (uzzzzzzzzzk_())
            {
                decimal? zzzzzzzzzzv_ = context.Operators.ConvertIntegerToDecimal(1);

                return zzzzzzzzzzv_;
            }
            else if (uzzzzzzzzzl_())
            {
                decimal? zzzzzzzzzzw_ = context.Operators.ConvertIntegerToDecimal(3);

                return zzzzzzzzzzw_;
            }
            else if (uzzzzzzzzzm_())
            {
                decimal? zzzzzzzzzzx_ = context.Operators.ConvertIntegerToDecimal(1);

                return zzzzzzzzzzx_;
            }
            else if (uzzzzzzzzzn_())
            {
                decimal? zzzzzzzzzzy_ = context.Operators.ConvertIntegerToDecimal(1);

                return zzzzzzzzzzy_;
            }
            else if (uzzzzzzzzzo_())
            {
                decimal? zzzzzzzzzzz_ = context.Operators.ConvertIntegerToDecimal(1);

                return zzzzzzzzzzz_;
            }
            else if (uzzzzzzzzzp_())
            {
                decimal? azzzzzzzzzza_ = context.Operators.ConvertIntegerToDecimal(3);

                return azzzzzzzzzza_;
            }
            else if (uzzzzzzzzzq_())
            {
                decimal? azzzzzzzzzzb_ = context.Operators.ConvertIntegerToDecimal(1);

                return azzzzzzzzzzb_;
            }
            else if (uzzzzzzzzzr_())
            {
                decimal? azzzzzzzzzzc_ = context.Operators.ConvertIntegerToDecimal(1);

                return azzzzzzzzzzc_;
            }
            else if (uzzzzzzzzzs_())
            {
                decimal? azzzzzzzzzzd_ = context.Operators.ConvertIntegerToDecimal(1);

                return azzzzzzzzzzd_;
            }
            else if (uzzzzzzzzzt_())
            {
                decimal? azzzzzzzzzze_ = context.Operators.ConvertIntegerToDecimal(1);

                return azzzzzzzzzze_;
            }
            else if (uzzzzzzzzzu_())
            {
                decimal? azzzzzzzzzzf_ = context.Operators.ConvertIntegerToDecimal(1);

                return azzzzzzzzzzf_;
            }
            else if (uzzzzzzzzzv_())
            {
                decimal? azzzzzzzzzzg_ = context.Operators.ConvertIntegerToDecimal(1);

                return azzzzzzzzzzg_;
            }
            else if (uzzzzzzzzzw_())
            {
                decimal? azzzzzzzzzzh_ = context.Operators.ConvertIntegerToDecimal(1);

                return azzzzzzzzzzh_;
            }
            else if (uzzzzzzzzzx_())
            {
                decimal? azzzzzzzzzzi_ = context.Operators.ConvertIntegerToDecimal(1);

                return azzzzzzzzzzi_;
            }
            else if (uzzzzzzzzzy_())
            {
                decimal? azzzzzzzzzzj_ = context.Operators.ConvertIntegerToDecimal(1);

                return azzzzzzzzzzj_;
            }
            else if (uzzzzzzzzzz_())
            {
                decimal? azzzzzzzzzzk_ = context.Operators.ConvertIntegerToDecimal(1);

                return azzzzzzzzzzk_;
            }
            else if (vzzzzzzzzza_())
            {
                decimal? azzzzzzzzzzl_ = context.Operators.ConvertIntegerToDecimal(1);

                return azzzzzzzzzzl_;
            }
            else if (vzzzzzzzzzb_())
            {
                decimal? azzzzzzzzzzm_ = context.Operators.ConvertIntegerToDecimal(1);

                return azzzzzzzzzzm_;
            }
            else if (vzzzzzzzzzc_())
            {
                decimal? azzzzzzzzzzn_ = context.Operators.ConvertIntegerToDecimal(1);

                return azzzzzzzzzzn_;
            }
            else if (vzzzzzzzzzd_())
            {
                decimal? azzzzzzzzzzo_ = context.Operators.ConvertIntegerToDecimal(1);

                return azzzzzzzzzzo_;
            }
            else if (vzzzzzzzzze_())
            {
                decimal? azzzzzzzzzzp_ = context.Operators.ConvertIntegerToDecimal(1);

                return azzzzzzzzzzp_;
            }
            else if (vzzzzzzzzzf_())
            {
                return 1.0m;
            }
            else if (vzzzzzzzzzg_())
            {
                return 2.0m;
            }
            else if (vzzzzzzzzzh_())
            {
                return 3.0m;
            }
            else if (vzzzzzzzzzi_())
            {
                return 4.0m;
            }
            else if (vzzzzzzzzzj_())
            {
                return 1.0m;
            }
            else if (vzzzzzzzzzk_())
            {
                return 2.0m;
            }
            else if (vzzzzzzzzzl_())
            {
                return 0.67m;
            }
            else if (vzzzzzzzzzm_())
            {
                return 3.0m;
            }
            else if (vzzzzzzzzzn_())
            {
                return 6.0m;
            }
            else if (vzzzzzzzzzo_())
            {
                return 4.0m;
            }
            else if (vzzzzzzzzzp_())
            {
                return 0.33m;
            }
            else if (vzzzzzzzzzq_())
            {
                return 0.5m;
            }
            else if (vzzzzzzzzzr_())
            {
                return 3.0m;
            }
            else if (vzzzzzzzzzs_())
            {
                return 4.0m;
            }
            else if (vzzzzzzzzzt_())
            {
                return 8.0m;
            }
            else if (vzzzzzzzzzu_())
            {
                return 8.0m;
            }
            else if (vzzzzzzzzzv_())
            {
                return 12.0m;
            }
            else if (vzzzzzzzzzw_())
            {
                return 4.0m;
            }
            else if (vzzzzzzzzzx_())
            {
                return 3.0m;
            }
            else if (vzzzzzzzzzy_())
            {
                return 2.0m;
            }
            else if (vzzzzzzzzzz_())
            {
                return 4.0m;
            }
            else
            {
                string azzzzzzzzzzq_ = this.ErrorLevel(context);
                string azzzzzzzzzzr_ = frequency?.code;
                string azzzzzzzzzzs_ = context.Operators.Concatenate("Unknown frequency code ", azzzzzzzzzzr_ ?? "");
                object azzzzzzzzzzt_ = context.Operators.Message<object>(null, "CMDLogic.ToDaily.UnknownFrequencyCode", azzzzzzzzzzq_, azzzzzzzzzzs_);

                return azzzzzzzzzzt_ as decimal?;
            }
        };

        return uzzzzzzzzze_();
    }


    [CqlExpressionDefinition("Quantity")]
    public CqlQuantity Quantity(CqlContext context, decimal? value, string unit) =>
        ((context.Operators.Not((bool?)(value is null))) ?? false
            ? new CqlQuantity(value, unit)
            : default);


    [CqlExpressionDefinition("MedicationRequestPeriod")]
    public CqlInterval<CqlDate> MedicationRequestPeriod(CqlContext context, MedicationRequest Request)
    {
        MedicationRequest[] azzzzzzzzzzu_ = [
            Request,
        ];
        CqlInterval<CqlDate> azzzzzzzzzzv_(MedicationRequest R)
        {
            CqlInterval<CqlDate> azzzzzzzzzzz_()
            {
                bool bzzzzzzzzzza_()
                {
                    List<Dosage> bzzzzzzzzzzc_ = R?.DosageInstruction;
                    Dosage bzzzzzzzzzzd_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)bzzzzzzzzzzc_);
                    Timing bzzzzzzzzzze_ = bzzzzzzzzzzd_?.Timing;
                    Timing.RepeatComponent bzzzzzzzzzzf_ = bzzzzzzzzzze_?.Repeat;
                    DataType bzzzzzzzzzzg_ = bzzzzzzzzzzf_?.Bounds;
                    object bzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzg_);
                    CqlDateTime bzzzzzzzzzzi_ = context.Operators.Start(bzzzzzzzzzzh_ as CqlInterval<CqlDateTime>);
                    CqlDate bzzzzzzzzzzj_ = context.Operators.DateFrom(bzzzzzzzzzzi_);
                    FhirDateTime bzzzzzzzzzzk_ = R?.AuthoredOnElement;
                    CqlDateTime bzzzzzzzzzzl_ = context.Operators.Convert<CqlDateTime>(bzzzzzzzzzzk_);
                    CqlDate bzzzzzzzzzzm_ = context.Operators.DateFrom(bzzzzzzzzzzl_);
                    MedicationRequest.DispenseRequestComponent bzzzzzzzzzzn_ = R?.DispenseRequest;
                    Period bzzzzzzzzzzo_ = bzzzzzzzzzzn_?.ValidityPeriod;
                    CqlInterval<CqlDateTime> bzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzzzzo_);
                    CqlDateTime bzzzzzzzzzzq_ = context.Operators.Start(bzzzzzzzzzzp_);
                    CqlDate bzzzzzzzzzzr_ = context.Operators.DateFrom(bzzzzzzzzzzq_);
                    bool? bzzzzzzzzzzs_ = context.Operators.Not((bool?)(((bzzzzzzzzzzj_ ?? bzzzzzzzzzzm_) ?? bzzzzzzzzzzr_) is null));
                    Duration bzzzzzzzzzzu_ = bzzzzzzzzzzn_?.ExpectedSupplyDuration;
                    CqlQuantity bzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, bzzzzzzzzzzu_);
                    CqlQuantity bzzzzzzzzzzw_ = context.Operators.ConvertQuantity(bzzzzzzzzzzv_, "d");
                    decimal? bzzzzzzzzzzx_ = bzzzzzzzzzzw_?.value;
                    Quantity bzzzzzzzzzzz_ = bzzzzzzzzzzn_?.Quantity;
                    CqlQuantity czzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, bzzzzzzzzzzz_);
                    decimal? czzzzzzzzzzb_ = czzzzzzzzzza_?.value;
                    Dosage czzzzzzzzzzd_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)bzzzzzzzzzzc_);
                    List<Dosage.DoseAndRateComponent> czzzzzzzzzze_ = czzzzzzzzzzd_?.DoseAndRate;
                    Dosage.DoseAndRateComponent czzzzzzzzzzf_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)czzzzzzzzzze_);
                    DataType czzzzzzzzzzg_ = czzzzzzzzzzf_?.Dose;
                    object czzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzg_);
                    CqlQuantity czzzzzzzzzzi_ = context.Operators.End(czzzzzzzzzzh_ as CqlInterval<CqlQuantity>);
                    Dosage czzzzzzzzzzk_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)bzzzzzzzzzzc_);
                    List<Dosage.DoseAndRateComponent> czzzzzzzzzzl_ = czzzzzzzzzzk_?.DoseAndRate;
                    Dosage.DoseAndRateComponent czzzzzzzzzzm_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)czzzzzzzzzzl_);
                    DataType czzzzzzzzzzn_ = czzzzzzzzzzm_?.Dose;
                    object czzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzn_);
                    decimal? czzzzzzzzzzp_ = (czzzzzzzzzzi_ ?? czzzzzzzzzzo_ as CqlQuantity)?.value;
                    Dosage czzzzzzzzzzr_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)bzzzzzzzzzzc_);
                    Timing czzzzzzzzzzs_ = czzzzzzzzzzr_?.Timing;
                    Timing.RepeatComponent czzzzzzzzzzt_ = czzzzzzzzzzs_?.Repeat;
                    PositiveInt czzzzzzzzzzu_ = czzzzzzzzzzt_?.FrequencyMaxElement;
                    int? czzzzzzzzzzv_ = czzzzzzzzzzu_?.Value;
                    Dosage czzzzzzzzzzx_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)bzzzzzzzzzzc_);
                    Timing czzzzzzzzzzy_ = czzzzzzzzzzx_?.Timing;
                    Timing.RepeatComponent czzzzzzzzzzz_ = czzzzzzzzzzy_?.Repeat;
                    PositiveInt dzzzzzzzzzza_ = czzzzzzzzzzz_?.FrequencyElement;
                    int? dzzzzzzzzzzb_ = dzzzzzzzzzza_?.Value;
                    Dosage dzzzzzzzzzzd_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)bzzzzzzzzzzc_);
                    Timing dzzzzzzzzzze_ = dzzzzzzzzzzd_?.Timing;
                    Timing.RepeatComponent dzzzzzzzzzzf_ = dzzzzzzzzzze_?.Repeat;
                    FhirDecimal dzzzzzzzzzzg_ = dzzzzzzzzzzf_?.PeriodElement;
                    decimal? dzzzzzzzzzzh_ = dzzzzzzzzzzg_?.Value;
                    Dosage dzzzzzzzzzzj_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)bzzzzzzzzzzc_);
                    Timing dzzzzzzzzzzk_ = dzzzzzzzzzzj_?.Timing;
                    Timing.RepeatComponent dzzzzzzzzzzl_ = dzzzzzzzzzzk_?.Repeat;
                    Code<Timing.UnitsOfTime> dzzzzzzzzzzm_ = dzzzzzzzzzzl_?.PeriodUnitElement;
                    Timing.UnitsOfTime? dzzzzzzzzzzn_ = dzzzzzzzzzzm_?.Value;
                    string dzzzzzzzzzzo_ = context.Operators.Convert<string>(dzzzzzzzzzzn_);
                    CqlQuantity dzzzzzzzzzzp_ = this.Quantity(context, dzzzzzzzzzzh_, dzzzzzzzzzzo_);
                    decimal? dzzzzzzzzzzq_ = this.ToDaily(context, czzzzzzzzzzv_ ?? dzzzzzzzzzzb_, dzzzzzzzzzzp_);
                    Dosage dzzzzzzzzzzs_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)bzzzzzzzzzzc_);
                    Timing dzzzzzzzzzzt_ = dzzzzzzzzzzs_?.Timing;
                    Timing.RepeatComponent dzzzzzzzzzzu_ = dzzzzzzzzzzt_?.Repeat;
                    List<Time> dzzzzzzzzzzv_ = dzzzzzzzzzzu_?.TimeOfDayElement;
                    IEnumerable<CqlTime> dzzzzzzzzzzw_ = context.Operators.LateBoundProperty<IEnumerable<CqlTime>>(dzzzzzzzzzzv_, "value");
                    int? dzzzzzzzzzzx_ = context.Operators.Count<CqlTime>(dzzzzzzzzzzw_);
                    decimal? dzzzzzzzzzzy_ = context.Operators.ConvertIntegerToDecimal(dzzzzzzzzzzx_);
                    decimal? dzzzzzzzzzzz_ = context.Operators.Multiply(czzzzzzzzzzp_, (dzzzzzzzzzzq_ ?? dzzzzzzzzzzy_) ?? 1.0m);
                    decimal? ezzzzzzzzzza_ = context.Operators.Divide(czzzzzzzzzzb_, dzzzzzzzzzzz_);
                    UnsignedInt ezzzzzzzzzzc_ = bzzzzzzzzzzn_?.NumberOfRepeatsAllowedElement;
                    int? ezzzzzzzzzzd_ = ezzzzzzzzzzc_?.Value;
                    int? ezzzzzzzzzze_ = context.Operators.Add(1, ezzzzzzzzzzd_ ?? 0);
                    decimal? ezzzzzzzzzzf_ = context.Operators.ConvertIntegerToDecimal(ezzzzzzzzzze_);
                    decimal? ezzzzzzzzzzg_ = context.Operators.Multiply(bzzzzzzzzzzx_ ?? ezzzzzzzzzza_, ezzzzzzzzzzf_);
                    bool? ezzzzzzzzzzh_ = context.Operators.Not((bool?)(ezzzzzzzzzzg_ is null));
                    bool? ezzzzzzzzzzi_ = context.Operators.And(bzzzzzzzzzzs_, ezzzzzzzzzzh_);

                    return ezzzzzzzzzzi_ ?? false;
                };
                bool bzzzzzzzzzzb_()
                {
                    List<Dosage> ezzzzzzzzzzj_ = R?.DosageInstruction;
                    Dosage ezzzzzzzzzzk_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)ezzzzzzzzzzj_);
                    Timing ezzzzzzzzzzl_ = ezzzzzzzzzzk_?.Timing;
                    Timing.RepeatComponent ezzzzzzzzzzm_ = ezzzzzzzzzzl_?.Repeat;
                    DataType ezzzzzzzzzzn_ = ezzzzzzzzzzm_?.Bounds;
                    object ezzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzn_);
                    CqlDateTime ezzzzzzzzzzp_ = context.Operators.Start(ezzzzzzzzzzo_ as CqlInterval<CqlDateTime>);
                    CqlDate ezzzzzzzzzzq_ = context.Operators.DateFrom(ezzzzzzzzzzp_);
                    FhirDateTime ezzzzzzzzzzr_ = R?.AuthoredOnElement;
                    CqlDateTime ezzzzzzzzzzs_ = context.Operators.Convert<CqlDateTime>(ezzzzzzzzzzr_);
                    CqlDate ezzzzzzzzzzt_ = context.Operators.DateFrom(ezzzzzzzzzzs_);
                    MedicationRequest.DispenseRequestComponent ezzzzzzzzzzu_ = R?.DispenseRequest;
                    Period ezzzzzzzzzzv_ = ezzzzzzzzzzu_?.ValidityPeriod;
                    CqlInterval<CqlDateTime> ezzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzzzzzzv_);
                    CqlDateTime ezzzzzzzzzzx_ = context.Operators.Start(ezzzzzzzzzzw_);
                    CqlDate ezzzzzzzzzzy_ = context.Operators.DateFrom(ezzzzzzzzzzx_);
                    bool? ezzzzzzzzzzz_ = context.Operators.Not((bool?)(((ezzzzzzzzzzq_ ?? ezzzzzzzzzzt_) ?? ezzzzzzzzzzy_) is null));
                    Dosage fzzzzzzzzzzb_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)ezzzzzzzzzzj_);
                    Timing fzzzzzzzzzzc_ = fzzzzzzzzzzb_?.Timing;
                    Timing.RepeatComponent fzzzzzzzzzzd_ = fzzzzzzzzzzc_?.Repeat;
                    DataType fzzzzzzzzzze_ = fzzzzzzzzzzd_?.Bounds;
                    object fzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzze_);
                    CqlDateTime fzzzzzzzzzzg_ = (fzzzzzzzzzzf_ as CqlInterval<CqlDateTime>)?.high;
                    bool? fzzzzzzzzzzh_ = context.Operators.Not((bool?)(fzzzzzzzzzzg_ is null));
                    bool? fzzzzzzzzzzi_ = context.Operators.And(ezzzzzzzzzzz_, fzzzzzzzzzzh_);

                    return fzzzzzzzzzzi_ ?? false;
                };
                if (bzzzzzzzzzza_())
                {
                    List<Dosage> fzzzzzzzzzzj_ = R?.DosageInstruction;
                    Dosage fzzzzzzzzzzk_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)fzzzzzzzzzzj_);
                    Timing fzzzzzzzzzzl_ = fzzzzzzzzzzk_?.Timing;
                    Timing.RepeatComponent fzzzzzzzzzzm_ = fzzzzzzzzzzl_?.Repeat;
                    DataType fzzzzzzzzzzn_ = fzzzzzzzzzzm_?.Bounds;
                    object fzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzn_);
                    CqlDateTime fzzzzzzzzzzp_ = context.Operators.Start(fzzzzzzzzzzo_ as CqlInterval<CqlDateTime>);
                    CqlDate fzzzzzzzzzzq_ = context.Operators.DateFrom(fzzzzzzzzzzp_);
                    FhirDateTime fzzzzzzzzzzr_ = R?.AuthoredOnElement;
                    CqlDateTime fzzzzzzzzzzs_ = context.Operators.Convert<CqlDateTime>(fzzzzzzzzzzr_);
                    CqlDate fzzzzzzzzzzt_ = context.Operators.DateFrom(fzzzzzzzzzzs_);
                    MedicationRequest.DispenseRequestComponent fzzzzzzzzzzu_ = R?.DispenseRequest;
                    Period fzzzzzzzzzzv_ = fzzzzzzzzzzu_?.ValidityPeriod;
                    CqlInterval<CqlDateTime> fzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzzzzzzv_);
                    CqlDateTime fzzzzzzzzzzx_ = context.Operators.Start(fzzzzzzzzzzw_);
                    CqlDate fzzzzzzzzzzy_ = context.Operators.DateFrom(fzzzzzzzzzzx_);
                    Dosage gzzzzzzzzzza_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)fzzzzzzzzzzj_);
                    Timing gzzzzzzzzzzb_ = gzzzzzzzzzza_?.Timing;
                    Timing.RepeatComponent gzzzzzzzzzzc_ = gzzzzzzzzzzb_?.Repeat;
                    DataType gzzzzzzzzzzd_ = gzzzzzzzzzzc_?.Bounds;
                    object gzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzd_);
                    CqlDateTime gzzzzzzzzzzf_ = context.Operators.Start(gzzzzzzzzzze_ as CqlInterval<CqlDateTime>);
                    CqlDate gzzzzzzzzzzg_ = context.Operators.DateFrom(gzzzzzzzzzzf_);
                    CqlDateTime gzzzzzzzzzzi_ = context.Operators.Convert<CqlDateTime>(fzzzzzzzzzzr_);
                    CqlDate gzzzzzzzzzzj_ = context.Operators.DateFrom(gzzzzzzzzzzi_);
                    Period gzzzzzzzzzzl_ = fzzzzzzzzzzu_?.ValidityPeriod;
                    CqlInterval<CqlDateTime> gzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzzzzzl_);
                    CqlDateTime gzzzzzzzzzzn_ = context.Operators.Start(gzzzzzzzzzzm_);
                    CqlDate gzzzzzzzzzzo_ = context.Operators.DateFrom(gzzzzzzzzzzn_);
                    Duration gzzzzzzzzzzq_ = fzzzzzzzzzzu_?.ExpectedSupplyDuration;
                    CqlQuantity gzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, gzzzzzzzzzzq_);
                    CqlQuantity gzzzzzzzzzzs_ = context.Operators.ConvertQuantity(gzzzzzzzzzzr_, "d");
                    decimal? gzzzzzzzzzzt_ = gzzzzzzzzzzs_?.value;
                    Quantity gzzzzzzzzzzv_ = fzzzzzzzzzzu_?.Quantity;
                    CqlQuantity gzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, gzzzzzzzzzzv_);
                    decimal? gzzzzzzzzzzx_ = gzzzzzzzzzzw_?.value;
                    Dosage gzzzzzzzzzzz_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)fzzzzzzzzzzj_);
                    List<Dosage.DoseAndRateComponent> hzzzzzzzzzza_ = gzzzzzzzzzzz_?.DoseAndRate;
                    Dosage.DoseAndRateComponent hzzzzzzzzzzb_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)hzzzzzzzzzza_);
                    DataType hzzzzzzzzzzc_ = hzzzzzzzzzzb_?.Dose;
                    object hzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzc_);
                    CqlQuantity hzzzzzzzzzze_ = context.Operators.End(hzzzzzzzzzzd_ as CqlInterval<CqlQuantity>);
                    Dosage hzzzzzzzzzzg_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)fzzzzzzzzzzj_);
                    List<Dosage.DoseAndRateComponent> hzzzzzzzzzzh_ = hzzzzzzzzzzg_?.DoseAndRate;
                    Dosage.DoseAndRateComponent hzzzzzzzzzzi_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)hzzzzzzzzzzh_);
                    DataType hzzzzzzzzzzj_ = hzzzzzzzzzzi_?.Dose;
                    object hzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzj_);
                    decimal? hzzzzzzzzzzl_ = (hzzzzzzzzzze_ ?? hzzzzzzzzzzk_ as CqlQuantity)?.value;
                    Dosage hzzzzzzzzzzn_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)fzzzzzzzzzzj_);
                    Timing hzzzzzzzzzzo_ = hzzzzzzzzzzn_?.Timing;
                    Timing.RepeatComponent hzzzzzzzzzzp_ = hzzzzzzzzzzo_?.Repeat;
                    PositiveInt hzzzzzzzzzzq_ = hzzzzzzzzzzp_?.FrequencyMaxElement;
                    int? hzzzzzzzzzzr_ = hzzzzzzzzzzq_?.Value;
                    Dosage hzzzzzzzzzzt_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)fzzzzzzzzzzj_);
                    Timing hzzzzzzzzzzu_ = hzzzzzzzzzzt_?.Timing;
                    Timing.RepeatComponent hzzzzzzzzzzv_ = hzzzzzzzzzzu_?.Repeat;
                    PositiveInt hzzzzzzzzzzw_ = hzzzzzzzzzzv_?.FrequencyElement;
                    int? hzzzzzzzzzzx_ = hzzzzzzzzzzw_?.Value;
                    Dosage hzzzzzzzzzzz_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)fzzzzzzzzzzj_);
                    Timing izzzzzzzzzza_ = hzzzzzzzzzzz_?.Timing;
                    Timing.RepeatComponent izzzzzzzzzzb_ = izzzzzzzzzza_?.Repeat;
                    FhirDecimal izzzzzzzzzzc_ = izzzzzzzzzzb_?.PeriodElement;
                    decimal? izzzzzzzzzzd_ = izzzzzzzzzzc_?.Value;
                    Dosage izzzzzzzzzzf_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)fzzzzzzzzzzj_);
                    Timing izzzzzzzzzzg_ = izzzzzzzzzzf_?.Timing;
                    Timing.RepeatComponent izzzzzzzzzzh_ = izzzzzzzzzzg_?.Repeat;
                    Code<Timing.UnitsOfTime> izzzzzzzzzzi_ = izzzzzzzzzzh_?.PeriodUnitElement;
                    Timing.UnitsOfTime? izzzzzzzzzzj_ = izzzzzzzzzzi_?.Value;
                    string izzzzzzzzzzk_ = context.Operators.Convert<string>(izzzzzzzzzzj_);
                    CqlQuantity izzzzzzzzzzl_ = this.Quantity(context, izzzzzzzzzzd_, izzzzzzzzzzk_);
                    decimal? izzzzzzzzzzm_ = this.ToDaily(context, hzzzzzzzzzzr_ ?? hzzzzzzzzzzx_, izzzzzzzzzzl_);
                    Dosage izzzzzzzzzzo_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)fzzzzzzzzzzj_);
                    Timing izzzzzzzzzzp_ = izzzzzzzzzzo_?.Timing;
                    Timing.RepeatComponent izzzzzzzzzzq_ = izzzzzzzzzzp_?.Repeat;
                    List<Time> izzzzzzzzzzr_ = izzzzzzzzzzq_?.TimeOfDayElement;
                    IEnumerable<CqlTime> izzzzzzzzzzs_ = context.Operators.LateBoundProperty<IEnumerable<CqlTime>>(izzzzzzzzzzr_, "value");
                    int? izzzzzzzzzzt_ = context.Operators.Count<CqlTime>(izzzzzzzzzzs_);
                    decimal? izzzzzzzzzzu_ = context.Operators.ConvertIntegerToDecimal(izzzzzzzzzzt_);
                    decimal? izzzzzzzzzzv_ = context.Operators.Multiply(hzzzzzzzzzzl_, (izzzzzzzzzzm_ ?? izzzzzzzzzzu_) ?? 1.0m);
                    decimal? izzzzzzzzzzw_ = context.Operators.Divide(gzzzzzzzzzzx_, izzzzzzzzzzv_);
                    UnsignedInt izzzzzzzzzzy_ = fzzzzzzzzzzu_?.NumberOfRepeatsAllowedElement;
                    int? izzzzzzzzzzz_ = izzzzzzzzzzy_?.Value;
                    int? jzzzzzzzzzza_ = context.Operators.Add(1, izzzzzzzzzzz_ ?? 0);
                    decimal? jzzzzzzzzzzb_ = context.Operators.ConvertIntegerToDecimal(jzzzzzzzzzza_);
                    decimal? jzzzzzzzzzzc_ = context.Operators.Multiply(gzzzzzzzzzzt_ ?? izzzzzzzzzzw_, jzzzzzzzzzzb_);
                    decimal? jzzzzzzzzzzd_ = context.Operators.ConvertIntegerToDecimal(1);
                    decimal? jzzzzzzzzzze_ = context.Operators.Subtract(jzzzzzzzzzzc_, jzzzzzzzzzzd_);
                    CqlQuantity jzzzzzzzzzzf_ = this.Quantity(context, jzzzzzzzzzze_, "day");
                    CqlDate jzzzzzzzzzzg_ = context.Operators.Add((gzzzzzzzzzzg_ ?? gzzzzzzzzzzj_) ?? gzzzzzzzzzzo_, jzzzzzzzzzzf_);
                    CqlInterval<CqlDate> jzzzzzzzzzzh_ = context.Operators.Interval((fzzzzzzzzzzq_ ?? fzzzzzzzzzzt_) ?? fzzzzzzzzzzy_, jzzzzzzzzzzg_, true, true);

                    return jzzzzzzzzzzh_;
                }
                else if (bzzzzzzzzzzb_())
                {
                    List<Dosage> jzzzzzzzzzzi_ = R?.DosageInstruction;
                    Dosage jzzzzzzzzzzj_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)jzzzzzzzzzzi_);
                    Timing jzzzzzzzzzzk_ = jzzzzzzzzzzj_?.Timing;
                    Timing.RepeatComponent jzzzzzzzzzzl_ = jzzzzzzzzzzk_?.Repeat;
                    DataType jzzzzzzzzzzm_ = jzzzzzzzzzzl_?.Bounds;
                    object jzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzm_);
                    CqlDateTime jzzzzzzzzzzo_ = context.Operators.Start(jzzzzzzzzzzn_ as CqlInterval<CqlDateTime>);
                    CqlDate jzzzzzzzzzzp_ = context.Operators.DateFrom(jzzzzzzzzzzo_);
                    FhirDateTime jzzzzzzzzzzq_ = R?.AuthoredOnElement;
                    CqlDateTime jzzzzzzzzzzr_ = context.Operators.Convert<CqlDateTime>(jzzzzzzzzzzq_);
                    CqlDate jzzzzzzzzzzs_ = context.Operators.DateFrom(jzzzzzzzzzzr_);
                    MedicationRequest.DispenseRequestComponent jzzzzzzzzzzt_ = R?.DispenseRequest;
                    Period jzzzzzzzzzzu_ = jzzzzzzzzzzt_?.ValidityPeriod;
                    CqlInterval<CqlDateTime> jzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzzzzzu_);
                    CqlDateTime jzzzzzzzzzzw_ = context.Operators.Start(jzzzzzzzzzzv_);
                    CqlDate jzzzzzzzzzzx_ = context.Operators.DateFrom(jzzzzzzzzzzw_);
                    Dosage jzzzzzzzzzzz_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)jzzzzzzzzzzi_);
                    Timing kzzzzzzzzzza_ = jzzzzzzzzzzz_?.Timing;
                    Timing.RepeatComponent kzzzzzzzzzzb_ = kzzzzzzzzzza_?.Repeat;
                    DataType kzzzzzzzzzzc_ = kzzzzzzzzzzb_?.Bounds;
                    object kzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzc_);
                    CqlDateTime kzzzzzzzzzze_ = context.Operators.End(kzzzzzzzzzzd_ as CqlInterval<CqlDateTime>);
                    CqlDate kzzzzzzzzzzf_ = context.Operators.DateFrom(kzzzzzzzzzze_);
                    CqlInterval<CqlDate> kzzzzzzzzzzg_ = context.Operators.Interval((jzzzzzzzzzzp_ ?? jzzzzzzzzzzs_) ?? jzzzzzzzzzzx_, kzzzzzzzzzzf_, true, true);

                    return kzzzzzzzzzzg_;
                }
                else
                {
                    return null as CqlInterval<CqlDate>;
                }
            };

            return azzzzzzzzzzz_();
        };
        IEnumerable<CqlInterval<CqlDate>> azzzzzzzzzzw_ = context.Operators.Select<MedicationRequest, CqlInterval<CqlDate>>((IEnumerable<MedicationRequest>)azzzzzzzzzzu_, azzzzzzzzzzv_);
        IEnumerable<CqlInterval<CqlDate>> azzzzzzzzzzx_ = context.Operators.Distinct<CqlInterval<CqlDate>>(azzzzzzzzzzw_);
        CqlInterval<CqlDate> azzzzzzzzzzy_ = context.Operators.SingletonFrom<CqlInterval<CqlDate>>(azzzzzzzzzzx_);

        return azzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("medicationRequestPeriod")]
    public CqlInterval<CqlDate> medicationRequestPeriod(CqlContext context, MedicationRequest Request)
    {
        MedicationRequest[] kzzzzzzzzzzh_ = [
            Request,
        ];
        CqlInterval<CqlDate> kzzzzzzzzzzi_(MedicationRequest R)
        {
            CqlInterval<CqlDate> kzzzzzzzzzzm_()
            {
                bool kzzzzzzzzzzn_()
                {
                    List<Dosage> kzzzzzzzzzzp_ = R?.DosageInstruction;
                    Dosage kzzzzzzzzzzq_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)kzzzzzzzzzzp_);
                    Timing kzzzzzzzzzzr_ = kzzzzzzzzzzq_?.Timing;
                    Timing.RepeatComponent kzzzzzzzzzzs_ = kzzzzzzzzzzr_?.Repeat;
                    DataType kzzzzzzzzzzt_ = kzzzzzzzzzzs_?.Bounds;
                    object kzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzt_);
                    CqlDateTime kzzzzzzzzzzv_ = context.Operators.Start(kzzzzzzzzzzu_ as CqlInterval<CqlDateTime>);
                    CqlDate kzzzzzzzzzzw_ = context.Operators.DateFrom(kzzzzzzzzzzv_);
                    FhirDateTime kzzzzzzzzzzx_ = R?.AuthoredOnElement;
                    CqlDateTime kzzzzzzzzzzy_ = context.Operators.Convert<CqlDateTime>(kzzzzzzzzzzx_);
                    CqlDate kzzzzzzzzzzz_ = context.Operators.DateFrom(kzzzzzzzzzzy_);
                    MedicationRequest.DispenseRequestComponent lzzzzzzzzzza_ = R?.DispenseRequest;
                    Period lzzzzzzzzzzb_ = lzzzzzzzzzza_?.ValidityPeriod;
                    CqlInterval<CqlDateTime> lzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzzzzzb_);
                    CqlDateTime lzzzzzzzzzzd_ = context.Operators.Start(lzzzzzzzzzzc_);
                    CqlDate lzzzzzzzzzze_ = context.Operators.DateFrom(lzzzzzzzzzzd_);
                    bool? lzzzzzzzzzzf_ = context.Operators.Not((bool?)(((kzzzzzzzzzzw_ ?? kzzzzzzzzzzz_) ?? lzzzzzzzzzze_) is null));
                    Duration lzzzzzzzzzzh_ = lzzzzzzzzzza_?.ExpectedSupplyDuration;
                    CqlQuantity lzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, lzzzzzzzzzzh_);
                    CqlQuantity lzzzzzzzzzzj_ = context.Operators.ConvertQuantity(lzzzzzzzzzzi_, "d");
                    decimal? lzzzzzzzzzzk_ = lzzzzzzzzzzj_?.value;
                    Quantity lzzzzzzzzzzm_ = lzzzzzzzzzza_?.Quantity;
                    CqlQuantity lzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, lzzzzzzzzzzm_);
                    decimal? lzzzzzzzzzzo_ = lzzzzzzzzzzn_?.value;
                    Dosage lzzzzzzzzzzq_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)kzzzzzzzzzzp_);
                    List<Dosage.DoseAndRateComponent> lzzzzzzzzzzr_ = lzzzzzzzzzzq_?.DoseAndRate;
                    Dosage.DoseAndRateComponent lzzzzzzzzzzs_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)lzzzzzzzzzzr_);
                    DataType lzzzzzzzzzzt_ = lzzzzzzzzzzs_?.Dose;
                    object lzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzt_);
                    CqlQuantity lzzzzzzzzzzv_ = context.Operators.End(lzzzzzzzzzzu_ as CqlInterval<CqlQuantity>);
                    Dosage lzzzzzzzzzzx_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)kzzzzzzzzzzp_);
                    List<Dosage.DoseAndRateComponent> lzzzzzzzzzzy_ = lzzzzzzzzzzx_?.DoseAndRate;
                    Dosage.DoseAndRateComponent lzzzzzzzzzzz_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)lzzzzzzzzzzy_);
                    DataType mzzzzzzzzzza_ = lzzzzzzzzzzz_?.Dose;
                    object mzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzza_);
                    decimal? mzzzzzzzzzzc_ = (lzzzzzzzzzzv_ ?? mzzzzzzzzzzb_ as CqlQuantity)?.value;
                    Dosage mzzzzzzzzzze_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)kzzzzzzzzzzp_);
                    Timing mzzzzzzzzzzf_ = mzzzzzzzzzze_?.Timing;
                    Timing.RepeatComponent mzzzzzzzzzzg_ = mzzzzzzzzzzf_?.Repeat;
                    PositiveInt mzzzzzzzzzzh_ = mzzzzzzzzzzg_?.FrequencyMaxElement;
                    int? mzzzzzzzzzzi_ = mzzzzzzzzzzh_?.Value;
                    Dosage mzzzzzzzzzzk_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)kzzzzzzzzzzp_);
                    Timing mzzzzzzzzzzl_ = mzzzzzzzzzzk_?.Timing;
                    Timing.RepeatComponent mzzzzzzzzzzm_ = mzzzzzzzzzzl_?.Repeat;
                    PositiveInt mzzzzzzzzzzn_ = mzzzzzzzzzzm_?.FrequencyElement;
                    int? mzzzzzzzzzzo_ = mzzzzzzzzzzn_?.Value;
                    Dosage mzzzzzzzzzzq_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)kzzzzzzzzzzp_);
                    Timing mzzzzzzzzzzr_ = mzzzzzzzzzzq_?.Timing;
                    Timing.RepeatComponent mzzzzzzzzzzs_ = mzzzzzzzzzzr_?.Repeat;
                    FhirDecimal mzzzzzzzzzzt_ = mzzzzzzzzzzs_?.PeriodElement;
                    decimal? mzzzzzzzzzzu_ = mzzzzzzzzzzt_?.Value;
                    Dosage mzzzzzzzzzzw_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)kzzzzzzzzzzp_);
                    Timing mzzzzzzzzzzx_ = mzzzzzzzzzzw_?.Timing;
                    Timing.RepeatComponent mzzzzzzzzzzy_ = mzzzzzzzzzzx_?.Repeat;
                    Code<Timing.UnitsOfTime> mzzzzzzzzzzz_ = mzzzzzzzzzzy_?.PeriodUnitElement;
                    Timing.UnitsOfTime? nzzzzzzzzzza_ = mzzzzzzzzzzz_?.Value;
                    string nzzzzzzzzzzb_ = context.Operators.Convert<string>(nzzzzzzzzzza_);
                    CqlQuantity nzzzzzzzzzzc_ = this.Quantity(context, mzzzzzzzzzzu_, nzzzzzzzzzzb_);
                    decimal? nzzzzzzzzzzd_ = this.ToDaily(context, mzzzzzzzzzzi_ ?? mzzzzzzzzzzo_, nzzzzzzzzzzc_);
                    Dosage nzzzzzzzzzzf_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)kzzzzzzzzzzp_);
                    Timing nzzzzzzzzzzg_ = nzzzzzzzzzzf_?.Timing;
                    Timing.RepeatComponent nzzzzzzzzzzh_ = nzzzzzzzzzzg_?.Repeat;
                    List<Time> nzzzzzzzzzzi_ = nzzzzzzzzzzh_?.TimeOfDayElement;
                    IEnumerable<CqlTime> nzzzzzzzzzzj_ = context.Operators.LateBoundProperty<IEnumerable<CqlTime>>(nzzzzzzzzzzi_, "value");
                    int? nzzzzzzzzzzk_ = context.Operators.Count<CqlTime>(nzzzzzzzzzzj_);
                    decimal? nzzzzzzzzzzl_ = context.Operators.ConvertIntegerToDecimal(nzzzzzzzzzzk_);
                    decimal? nzzzzzzzzzzm_ = context.Operators.Multiply(mzzzzzzzzzzc_, (nzzzzzzzzzzd_ ?? nzzzzzzzzzzl_) ?? 1.0m);
                    decimal? nzzzzzzzzzzn_ = context.Operators.Divide(lzzzzzzzzzzo_, nzzzzzzzzzzm_);
                    UnsignedInt nzzzzzzzzzzp_ = lzzzzzzzzzza_?.NumberOfRepeatsAllowedElement;
                    int? nzzzzzzzzzzq_ = nzzzzzzzzzzp_?.Value;
                    int? nzzzzzzzzzzr_ = context.Operators.Add(1, nzzzzzzzzzzq_ ?? 0);
                    decimal? nzzzzzzzzzzs_ = context.Operators.ConvertIntegerToDecimal(nzzzzzzzzzzr_);
                    decimal? nzzzzzzzzzzt_ = context.Operators.Multiply(lzzzzzzzzzzk_ ?? nzzzzzzzzzzn_, nzzzzzzzzzzs_);
                    bool? nzzzzzzzzzzu_ = context.Operators.Not((bool?)(nzzzzzzzzzzt_ is null));
                    bool? nzzzzzzzzzzv_ = context.Operators.And(lzzzzzzzzzzf_, nzzzzzzzzzzu_);

                    return nzzzzzzzzzzv_ ?? false;
                };
                bool kzzzzzzzzzzo_()
                {
                    List<Dosage> nzzzzzzzzzzw_ = R?.DosageInstruction;
                    Dosage nzzzzzzzzzzx_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)nzzzzzzzzzzw_);
                    Timing nzzzzzzzzzzy_ = nzzzzzzzzzzx_?.Timing;
                    Timing.RepeatComponent nzzzzzzzzzzz_ = nzzzzzzzzzzy_?.Repeat;
                    DataType ozzzzzzzzzza_ = nzzzzzzzzzzz_?.Bounds;
                    object ozzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzza_);
                    CqlDateTime ozzzzzzzzzzc_ = context.Operators.Start(ozzzzzzzzzzb_ as CqlInterval<CqlDateTime>);
                    CqlDate ozzzzzzzzzzd_ = context.Operators.DateFrom(ozzzzzzzzzzc_);
                    FhirDateTime ozzzzzzzzzze_ = R?.AuthoredOnElement;
                    CqlDateTime ozzzzzzzzzzf_ = context.Operators.Convert<CqlDateTime>(ozzzzzzzzzze_);
                    CqlDate ozzzzzzzzzzg_ = context.Operators.DateFrom(ozzzzzzzzzzf_);
                    MedicationRequest.DispenseRequestComponent ozzzzzzzzzzh_ = R?.DispenseRequest;
                    Period ozzzzzzzzzzi_ = ozzzzzzzzzzh_?.ValidityPeriod;
                    CqlInterval<CqlDateTime> ozzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzzzzzzi_);
                    CqlDateTime ozzzzzzzzzzk_ = context.Operators.Start(ozzzzzzzzzzj_);
                    CqlDate ozzzzzzzzzzl_ = context.Operators.DateFrom(ozzzzzzzzzzk_);
                    bool? ozzzzzzzzzzm_ = context.Operators.Not((bool?)(((ozzzzzzzzzzd_ ?? ozzzzzzzzzzg_) ?? ozzzzzzzzzzl_) is null));
                    Dosage ozzzzzzzzzzo_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)nzzzzzzzzzzw_);
                    Timing ozzzzzzzzzzp_ = ozzzzzzzzzzo_?.Timing;
                    Timing.RepeatComponent ozzzzzzzzzzq_ = ozzzzzzzzzzp_?.Repeat;
                    DataType ozzzzzzzzzzr_ = ozzzzzzzzzzq_?.Bounds;
                    object ozzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzr_);
                    CqlDateTime ozzzzzzzzzzt_ = (ozzzzzzzzzzs_ as CqlInterval<CqlDateTime>)?.high;
                    bool? ozzzzzzzzzzu_ = context.Operators.Not((bool?)(ozzzzzzzzzzt_ is null));
                    bool? ozzzzzzzzzzv_ = context.Operators.And(ozzzzzzzzzzm_, ozzzzzzzzzzu_);

                    return ozzzzzzzzzzv_ ?? false;
                };
                if (kzzzzzzzzzzn_())
                {
                    List<Dosage> ozzzzzzzzzzw_ = R?.DosageInstruction;
                    Dosage ozzzzzzzzzzx_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)ozzzzzzzzzzw_);
                    Timing ozzzzzzzzzzy_ = ozzzzzzzzzzx_?.Timing;
                    Timing.RepeatComponent ozzzzzzzzzzz_ = ozzzzzzzzzzy_?.Repeat;
                    DataType pzzzzzzzzzza_ = ozzzzzzzzzzz_?.Bounds;
                    object pzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzza_);
                    CqlDateTime pzzzzzzzzzzc_ = context.Operators.Start(pzzzzzzzzzzb_ as CqlInterval<CqlDateTime>);
                    CqlDate pzzzzzzzzzzd_ = context.Operators.DateFrom(pzzzzzzzzzzc_);
                    FhirDateTime pzzzzzzzzzze_ = R?.AuthoredOnElement;
                    CqlDateTime pzzzzzzzzzzf_ = context.Operators.Convert<CqlDateTime>(pzzzzzzzzzze_);
                    CqlDate pzzzzzzzzzzg_ = context.Operators.DateFrom(pzzzzzzzzzzf_);
                    MedicationRequest.DispenseRequestComponent pzzzzzzzzzzh_ = R?.DispenseRequest;
                    Period pzzzzzzzzzzi_ = pzzzzzzzzzzh_?.ValidityPeriod;
                    CqlInterval<CqlDateTime> pzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzzzzzzi_);
                    CqlDateTime pzzzzzzzzzzk_ = context.Operators.Start(pzzzzzzzzzzj_);
                    CqlDate pzzzzzzzzzzl_ = context.Operators.DateFrom(pzzzzzzzzzzk_);
                    Dosage pzzzzzzzzzzn_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)ozzzzzzzzzzw_);
                    Timing pzzzzzzzzzzo_ = pzzzzzzzzzzn_?.Timing;
                    Timing.RepeatComponent pzzzzzzzzzzp_ = pzzzzzzzzzzo_?.Repeat;
                    DataType pzzzzzzzzzzq_ = pzzzzzzzzzzp_?.Bounds;
                    object pzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzq_);
                    CqlDateTime pzzzzzzzzzzs_ = context.Operators.Start(pzzzzzzzzzzr_ as CqlInterval<CqlDateTime>);
                    CqlDate pzzzzzzzzzzt_ = context.Operators.DateFrom(pzzzzzzzzzzs_);
                    CqlDateTime pzzzzzzzzzzv_ = context.Operators.Convert<CqlDateTime>(pzzzzzzzzzze_);
                    CqlDate pzzzzzzzzzzw_ = context.Operators.DateFrom(pzzzzzzzzzzv_);
                    Period pzzzzzzzzzzy_ = pzzzzzzzzzzh_?.ValidityPeriod;
                    CqlInterval<CqlDateTime> pzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzzzzzzy_);
                    CqlDateTime qzzzzzzzzzza_ = context.Operators.Start(pzzzzzzzzzzz_);
                    CqlDate qzzzzzzzzzzb_ = context.Operators.DateFrom(qzzzzzzzzzza_);
                    Duration qzzzzzzzzzzd_ = pzzzzzzzzzzh_?.ExpectedSupplyDuration;
                    CqlQuantity qzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, qzzzzzzzzzzd_);
                    CqlQuantity qzzzzzzzzzzf_ = context.Operators.ConvertQuantity(qzzzzzzzzzze_, "d");
                    decimal? qzzzzzzzzzzg_ = qzzzzzzzzzzf_?.value;
                    Quantity qzzzzzzzzzzi_ = pzzzzzzzzzzh_?.Quantity;
                    CqlQuantity qzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, qzzzzzzzzzzi_);
                    decimal? qzzzzzzzzzzk_ = qzzzzzzzzzzj_?.value;
                    Dosage qzzzzzzzzzzm_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)ozzzzzzzzzzw_);
                    List<Dosage.DoseAndRateComponent> qzzzzzzzzzzn_ = qzzzzzzzzzzm_?.DoseAndRate;
                    Dosage.DoseAndRateComponent qzzzzzzzzzzo_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)qzzzzzzzzzzn_);
                    DataType qzzzzzzzzzzp_ = qzzzzzzzzzzo_?.Dose;
                    object qzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzp_);
                    CqlQuantity qzzzzzzzzzzr_ = context.Operators.End(qzzzzzzzzzzq_ as CqlInterval<CqlQuantity>);
                    Dosage qzzzzzzzzzzt_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)ozzzzzzzzzzw_);
                    List<Dosage.DoseAndRateComponent> qzzzzzzzzzzu_ = qzzzzzzzzzzt_?.DoseAndRate;
                    Dosage.DoseAndRateComponent qzzzzzzzzzzv_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)qzzzzzzzzzzu_);
                    DataType qzzzzzzzzzzw_ = qzzzzzzzzzzv_?.Dose;
                    object qzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzw_);
                    decimal? qzzzzzzzzzzy_ = (qzzzzzzzzzzr_ ?? qzzzzzzzzzzx_ as CqlQuantity)?.value;
                    Dosage rzzzzzzzzzza_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)ozzzzzzzzzzw_);
                    Timing rzzzzzzzzzzb_ = rzzzzzzzzzza_?.Timing;
                    Timing.RepeatComponent rzzzzzzzzzzc_ = rzzzzzzzzzzb_?.Repeat;
                    PositiveInt rzzzzzzzzzzd_ = rzzzzzzzzzzc_?.FrequencyMaxElement;
                    int? rzzzzzzzzzze_ = rzzzzzzzzzzd_?.Value;
                    Dosage rzzzzzzzzzzg_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)ozzzzzzzzzzw_);
                    Timing rzzzzzzzzzzh_ = rzzzzzzzzzzg_?.Timing;
                    Timing.RepeatComponent rzzzzzzzzzzi_ = rzzzzzzzzzzh_?.Repeat;
                    PositiveInt rzzzzzzzzzzj_ = rzzzzzzzzzzi_?.FrequencyElement;
                    int? rzzzzzzzzzzk_ = rzzzzzzzzzzj_?.Value;
                    Dosage rzzzzzzzzzzm_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)ozzzzzzzzzzw_);
                    Timing rzzzzzzzzzzn_ = rzzzzzzzzzzm_?.Timing;
                    Timing.RepeatComponent rzzzzzzzzzzo_ = rzzzzzzzzzzn_?.Repeat;
                    FhirDecimal rzzzzzzzzzzp_ = rzzzzzzzzzzo_?.PeriodElement;
                    decimal? rzzzzzzzzzzq_ = rzzzzzzzzzzp_?.Value;
                    Dosage rzzzzzzzzzzs_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)ozzzzzzzzzzw_);
                    Timing rzzzzzzzzzzt_ = rzzzzzzzzzzs_?.Timing;
                    Timing.RepeatComponent rzzzzzzzzzzu_ = rzzzzzzzzzzt_?.Repeat;
                    Code<Timing.UnitsOfTime> rzzzzzzzzzzv_ = rzzzzzzzzzzu_?.PeriodUnitElement;
                    Timing.UnitsOfTime? rzzzzzzzzzzw_ = rzzzzzzzzzzv_?.Value;
                    string rzzzzzzzzzzx_ = context.Operators.Convert<string>(rzzzzzzzzzzw_);
                    CqlQuantity rzzzzzzzzzzy_ = this.Quantity(context, rzzzzzzzzzzq_, rzzzzzzzzzzx_);
                    decimal? rzzzzzzzzzzz_ = this.ToDaily(context, rzzzzzzzzzze_ ?? rzzzzzzzzzzk_, rzzzzzzzzzzy_);
                    Dosage szzzzzzzzzzb_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)ozzzzzzzzzzw_);
                    Timing szzzzzzzzzzc_ = szzzzzzzzzzb_?.Timing;
                    Timing.RepeatComponent szzzzzzzzzzd_ = szzzzzzzzzzc_?.Repeat;
                    List<Time> szzzzzzzzzze_ = szzzzzzzzzzd_?.TimeOfDayElement;
                    IEnumerable<CqlTime> szzzzzzzzzzf_ = context.Operators.LateBoundProperty<IEnumerable<CqlTime>>(szzzzzzzzzze_, "value");
                    int? szzzzzzzzzzg_ = context.Operators.Count<CqlTime>(szzzzzzzzzzf_);
                    decimal? szzzzzzzzzzh_ = context.Operators.ConvertIntegerToDecimal(szzzzzzzzzzg_);
                    decimal? szzzzzzzzzzi_ = context.Operators.Multiply(qzzzzzzzzzzy_, (rzzzzzzzzzzz_ ?? szzzzzzzzzzh_) ?? 1.0m);
                    decimal? szzzzzzzzzzj_ = context.Operators.Divide(qzzzzzzzzzzk_, szzzzzzzzzzi_);
                    UnsignedInt szzzzzzzzzzl_ = pzzzzzzzzzzh_?.NumberOfRepeatsAllowedElement;
                    int? szzzzzzzzzzm_ = szzzzzzzzzzl_?.Value;
                    int? szzzzzzzzzzn_ = context.Operators.Add(1, szzzzzzzzzzm_ ?? 0);
                    decimal? szzzzzzzzzzo_ = context.Operators.ConvertIntegerToDecimal(szzzzzzzzzzn_);
                    decimal? szzzzzzzzzzp_ = context.Operators.Multiply(qzzzzzzzzzzg_ ?? szzzzzzzzzzj_, szzzzzzzzzzo_);
                    decimal? szzzzzzzzzzq_ = context.Operators.ConvertIntegerToDecimal(1);
                    decimal? szzzzzzzzzzr_ = context.Operators.Subtract(szzzzzzzzzzp_, szzzzzzzzzzq_);
                    CqlQuantity szzzzzzzzzzs_ = this.Quantity(context, szzzzzzzzzzr_, "day");
                    CqlDate szzzzzzzzzzt_ = context.Operators.Add((pzzzzzzzzzzt_ ?? pzzzzzzzzzzw_) ?? qzzzzzzzzzzb_, szzzzzzzzzzs_);
                    CqlInterval<CqlDate> szzzzzzzzzzu_ = context.Operators.Interval((pzzzzzzzzzzd_ ?? pzzzzzzzzzzg_) ?? pzzzzzzzzzzl_, szzzzzzzzzzt_, true, true);

                    return szzzzzzzzzzu_;
                }
                else if (kzzzzzzzzzzo_())
                {
                    List<Dosage> szzzzzzzzzzv_ = R?.DosageInstruction;
                    Dosage szzzzzzzzzzw_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)szzzzzzzzzzv_);
                    Timing szzzzzzzzzzx_ = szzzzzzzzzzw_?.Timing;
                    Timing.RepeatComponent szzzzzzzzzzy_ = szzzzzzzzzzx_?.Repeat;
                    DataType szzzzzzzzzzz_ = szzzzzzzzzzy_?.Bounds;
                    object tzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzz_);
                    CqlDateTime tzzzzzzzzzzb_ = context.Operators.Start(tzzzzzzzzzza_ as CqlInterval<CqlDateTime>);
                    CqlDate tzzzzzzzzzzc_ = context.Operators.DateFrom(tzzzzzzzzzzb_);
                    FhirDateTime tzzzzzzzzzzd_ = R?.AuthoredOnElement;
                    CqlDateTime tzzzzzzzzzze_ = context.Operators.Convert<CqlDateTime>(tzzzzzzzzzzd_);
                    CqlDate tzzzzzzzzzzf_ = context.Operators.DateFrom(tzzzzzzzzzze_);
                    MedicationRequest.DispenseRequestComponent tzzzzzzzzzzg_ = R?.DispenseRequest;
                    Period tzzzzzzzzzzh_ = tzzzzzzzzzzg_?.ValidityPeriod;
                    CqlInterval<CqlDateTime> tzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzzzzzzzh_);
                    CqlDateTime tzzzzzzzzzzj_ = context.Operators.Start(tzzzzzzzzzzi_);
                    CqlDate tzzzzzzzzzzk_ = context.Operators.DateFrom(tzzzzzzzzzzj_);
                    Dosage tzzzzzzzzzzm_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)szzzzzzzzzzv_);
                    Timing tzzzzzzzzzzn_ = tzzzzzzzzzzm_?.Timing;
                    Timing.RepeatComponent tzzzzzzzzzzo_ = tzzzzzzzzzzn_?.Repeat;
                    DataType tzzzzzzzzzzp_ = tzzzzzzzzzzo_?.Bounds;
                    object tzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzp_);
                    CqlDateTime tzzzzzzzzzzr_ = context.Operators.End(tzzzzzzzzzzq_ as CqlInterval<CqlDateTime>);
                    CqlDate tzzzzzzzzzzs_ = context.Operators.DateFrom(tzzzzzzzzzzr_);
                    CqlInterval<CqlDate> tzzzzzzzzzzt_ = context.Operators.Interval((tzzzzzzzzzzc_ ?? tzzzzzzzzzzf_) ?? tzzzzzzzzzzk_, tzzzzzzzzzzs_, true, true);

                    return tzzzzzzzzzzt_;
                }
                else
                {
                    return null as CqlInterval<CqlDate>;
                }
            };

            return kzzzzzzzzzzm_();
        };
        IEnumerable<CqlInterval<CqlDate>> kzzzzzzzzzzj_ = context.Operators.Select<MedicationRequest, CqlInterval<CqlDate>>((IEnumerable<MedicationRequest>)kzzzzzzzzzzh_, kzzzzzzzzzzi_);
        IEnumerable<CqlInterval<CqlDate>> kzzzzzzzzzzk_ = context.Operators.Distinct<CqlInterval<CqlDate>>(kzzzzzzzzzzj_);
        CqlInterval<CqlDate> kzzzzzzzzzzl_ = context.Operators.SingletonFrom<CqlInterval<CqlDate>>(kzzzzzzzzzzk_);

        return kzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("MedicationDispensePeriod")]
    public CqlInterval<CqlDate> MedicationDispensePeriod(CqlContext context, MedicationDispense Dispense)
    {
        MedicationDispense[] tzzzzzzzzzzu_ = [
            Dispense,
        ];
        CqlInterval<CqlDate> tzzzzzzzzzzv_(MedicationDispense D)
        {
            CqlInterval<CqlDate> tzzzzzzzzzzz_()
            {
                bool uzzzzzzzzzza_()
                {
                    FhirDateTime uzzzzzzzzzzb_ = D?.WhenHandedOverElement;
                    CqlDateTime uzzzzzzzzzzc_ = context.Operators.Convert<CqlDateTime>(uzzzzzzzzzzb_);
                    CqlDate uzzzzzzzzzzd_ = context.Operators.DateFrom(uzzzzzzzzzzc_);
                    FhirDateTime uzzzzzzzzzze_ = D?.WhenPreparedElement;
                    CqlDateTime uzzzzzzzzzzf_ = context.Operators.Convert<CqlDateTime>(uzzzzzzzzzze_);
                    CqlDate uzzzzzzzzzzg_ = context.Operators.DateFrom(uzzzzzzzzzzf_);
                    bool? uzzzzzzzzzzh_ = context.Operators.Not((bool?)((uzzzzzzzzzzd_ ?? uzzzzzzzzzzg_) is null));
                    Quantity uzzzzzzzzzzi_ = D?.DaysSupply;
                    CqlQuantity uzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, uzzzzzzzzzzi_);
                    CqlQuantity uzzzzzzzzzzk_ = context.Operators.ConvertQuantity(uzzzzzzzzzzj_, "d");
                    decimal? uzzzzzzzzzzl_ = uzzzzzzzzzzk_?.value;
                    Quantity uzzzzzzzzzzm_ = D?.Quantity;
                    CqlQuantity uzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, uzzzzzzzzzzm_);
                    decimal? uzzzzzzzzzzo_ = uzzzzzzzzzzn_?.value;
                    List<Dosage> uzzzzzzzzzzp_ = D?.DosageInstruction;
                    Dosage uzzzzzzzzzzq_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)uzzzzzzzzzzp_);
                    List<Dosage.DoseAndRateComponent> uzzzzzzzzzzr_ = uzzzzzzzzzzq_?.DoseAndRate;
                    Dosage.DoseAndRateComponent uzzzzzzzzzzs_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)uzzzzzzzzzzr_);
                    DataType uzzzzzzzzzzt_ = uzzzzzzzzzzs_?.Dose;
                    object uzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzt_);
                    CqlQuantity uzzzzzzzzzzv_ = context.Operators.End(uzzzzzzzzzzu_ as CqlInterval<CqlQuantity>);
                    Dosage uzzzzzzzzzzx_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)uzzzzzzzzzzp_);
                    List<Dosage.DoseAndRateComponent> uzzzzzzzzzzy_ = uzzzzzzzzzzx_?.DoseAndRate;
                    Dosage.DoseAndRateComponent uzzzzzzzzzzz_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)uzzzzzzzzzzy_);
                    DataType vzzzzzzzzzza_ = uzzzzzzzzzzz_?.Dose;
                    object vzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzza_);
                    decimal? vzzzzzzzzzzc_ = (uzzzzzzzzzzv_ ?? vzzzzzzzzzzb_ as CqlQuantity)?.value;
                    Dosage vzzzzzzzzzze_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)uzzzzzzzzzzp_);
                    Timing vzzzzzzzzzzf_ = vzzzzzzzzzze_?.Timing;
                    Timing.RepeatComponent vzzzzzzzzzzg_ = vzzzzzzzzzzf_?.Repeat;
                    PositiveInt vzzzzzzzzzzh_ = vzzzzzzzzzzg_?.FrequencyMaxElement;
                    int? vzzzzzzzzzzi_ = vzzzzzzzzzzh_?.Value;
                    Dosage vzzzzzzzzzzk_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)uzzzzzzzzzzp_);
                    Timing vzzzzzzzzzzl_ = vzzzzzzzzzzk_?.Timing;
                    Timing.RepeatComponent vzzzzzzzzzzm_ = vzzzzzzzzzzl_?.Repeat;
                    PositiveInt vzzzzzzzzzzn_ = vzzzzzzzzzzm_?.FrequencyElement;
                    int? vzzzzzzzzzzo_ = vzzzzzzzzzzn_?.Value;
                    Dosage vzzzzzzzzzzq_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)uzzzzzzzzzzp_);
                    Timing vzzzzzzzzzzr_ = vzzzzzzzzzzq_?.Timing;
                    Timing.RepeatComponent vzzzzzzzzzzs_ = vzzzzzzzzzzr_?.Repeat;
                    FhirDecimal vzzzzzzzzzzt_ = vzzzzzzzzzzs_?.PeriodElement;
                    decimal? vzzzzzzzzzzu_ = vzzzzzzzzzzt_?.Value;
                    Dosage vzzzzzzzzzzw_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)uzzzzzzzzzzp_);
                    Timing vzzzzzzzzzzx_ = vzzzzzzzzzzw_?.Timing;
                    Timing.RepeatComponent vzzzzzzzzzzy_ = vzzzzzzzzzzx_?.Repeat;
                    Code<Timing.UnitsOfTime> vzzzzzzzzzzz_ = vzzzzzzzzzzy_?.PeriodUnitElement;
                    Timing.UnitsOfTime? wzzzzzzzzzza_ = vzzzzzzzzzzz_?.Value;
                    string wzzzzzzzzzzb_ = context.Operators.Convert<string>(wzzzzzzzzzza_);
                    CqlQuantity wzzzzzzzzzzc_ = this.Quantity(context, vzzzzzzzzzzu_, wzzzzzzzzzzb_);
                    decimal? wzzzzzzzzzzd_ = this.ToDaily(context, vzzzzzzzzzzi_ ?? vzzzzzzzzzzo_, wzzzzzzzzzzc_);
                    Dosage wzzzzzzzzzzf_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)uzzzzzzzzzzp_);
                    Timing wzzzzzzzzzzg_ = wzzzzzzzzzzf_?.Timing;
                    Timing.RepeatComponent wzzzzzzzzzzh_ = wzzzzzzzzzzg_?.Repeat;
                    List<Time> wzzzzzzzzzzi_ = wzzzzzzzzzzh_?.TimeOfDayElement;
                    IEnumerable<CqlTime> wzzzzzzzzzzj_ = context.Operators.LateBoundProperty<IEnumerable<CqlTime>>(wzzzzzzzzzzi_, "value");
                    int? wzzzzzzzzzzk_ = context.Operators.Count<CqlTime>(wzzzzzzzzzzj_);
                    decimal? wzzzzzzzzzzl_ = context.Operators.ConvertIntegerToDecimal(wzzzzzzzzzzk_);
                    decimal? wzzzzzzzzzzm_ = context.Operators.Multiply(vzzzzzzzzzzc_, (wzzzzzzzzzzd_ ?? wzzzzzzzzzzl_) ?? 1.0m);
                    decimal? wzzzzzzzzzzn_ = context.Operators.Divide(uzzzzzzzzzzo_, wzzzzzzzzzzm_);
                    bool? wzzzzzzzzzzo_ = context.Operators.Not((bool?)((uzzzzzzzzzzl_ ?? wzzzzzzzzzzn_) is null));
                    bool? wzzzzzzzzzzp_ = context.Operators.And(uzzzzzzzzzzh_, wzzzzzzzzzzo_);

                    return wzzzzzzzzzzp_ ?? false;
                };
                if (uzzzzzzzzzza_())
                {
                    FhirDateTime wzzzzzzzzzzq_ = D?.WhenHandedOverElement;
                    CqlDateTime wzzzzzzzzzzr_ = context.Operators.Convert<CqlDateTime>(wzzzzzzzzzzq_);
                    CqlDate wzzzzzzzzzzs_ = context.Operators.DateFrom(wzzzzzzzzzzr_);
                    FhirDateTime wzzzzzzzzzzt_ = D?.WhenPreparedElement;
                    CqlDateTime wzzzzzzzzzzu_ = context.Operators.Convert<CqlDateTime>(wzzzzzzzzzzt_);
                    CqlDate wzzzzzzzzzzv_ = context.Operators.DateFrom(wzzzzzzzzzzu_);
                    CqlDateTime wzzzzzzzzzzx_ = context.Operators.Convert<CqlDateTime>(wzzzzzzzzzzq_);
                    CqlDate wzzzzzzzzzzy_ = context.Operators.DateFrom(wzzzzzzzzzzx_);
                    CqlDateTime xzzzzzzzzzza_ = context.Operators.Convert<CqlDateTime>(wzzzzzzzzzzt_);
                    CqlDate xzzzzzzzzzzb_ = context.Operators.DateFrom(xzzzzzzzzzza_);
                    Quantity xzzzzzzzzzzc_ = D?.DaysSupply;
                    CqlQuantity xzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, xzzzzzzzzzzc_);
                    CqlQuantity xzzzzzzzzzze_ = context.Operators.ConvertQuantity(xzzzzzzzzzzd_, "d");
                    decimal? xzzzzzzzzzzf_ = xzzzzzzzzzze_?.value;
                    Quantity xzzzzzzzzzzg_ = D?.Quantity;
                    CqlQuantity xzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, xzzzzzzzzzzg_);
                    decimal? xzzzzzzzzzzi_ = xzzzzzzzzzzh_?.value;
                    List<Dosage> xzzzzzzzzzzj_ = D?.DosageInstruction;
                    Dosage xzzzzzzzzzzk_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)xzzzzzzzzzzj_);
                    List<Dosage.DoseAndRateComponent> xzzzzzzzzzzl_ = xzzzzzzzzzzk_?.DoseAndRate;
                    Dosage.DoseAndRateComponent xzzzzzzzzzzm_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)xzzzzzzzzzzl_);
                    DataType xzzzzzzzzzzn_ = xzzzzzzzzzzm_?.Dose;
                    object xzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzn_);
                    CqlQuantity xzzzzzzzzzzp_ = context.Operators.End(xzzzzzzzzzzo_ as CqlInterval<CqlQuantity>);
                    Dosage xzzzzzzzzzzr_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)xzzzzzzzzzzj_);
                    List<Dosage.DoseAndRateComponent> xzzzzzzzzzzs_ = xzzzzzzzzzzr_?.DoseAndRate;
                    Dosage.DoseAndRateComponent xzzzzzzzzzzt_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)xzzzzzzzzzzs_);
                    DataType xzzzzzzzzzzu_ = xzzzzzzzzzzt_?.Dose;
                    object xzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzu_);
                    decimal? xzzzzzzzzzzw_ = (xzzzzzzzzzzp_ ?? xzzzzzzzzzzv_ as CqlQuantity)?.value;
                    Dosage xzzzzzzzzzzy_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)xzzzzzzzzzzj_);
                    Timing xzzzzzzzzzzz_ = xzzzzzzzzzzy_?.Timing;
                    Timing.RepeatComponent yzzzzzzzzzza_ = xzzzzzzzzzzz_?.Repeat;
                    PositiveInt yzzzzzzzzzzb_ = yzzzzzzzzzza_?.FrequencyMaxElement;
                    int? yzzzzzzzzzzc_ = yzzzzzzzzzzb_?.Value;
                    Dosage yzzzzzzzzzze_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)xzzzzzzzzzzj_);
                    Timing yzzzzzzzzzzf_ = yzzzzzzzzzze_?.Timing;
                    Timing.RepeatComponent yzzzzzzzzzzg_ = yzzzzzzzzzzf_?.Repeat;
                    PositiveInt yzzzzzzzzzzh_ = yzzzzzzzzzzg_?.FrequencyElement;
                    int? yzzzzzzzzzzi_ = yzzzzzzzzzzh_?.Value;
                    Dosage yzzzzzzzzzzk_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)xzzzzzzzzzzj_);
                    Timing yzzzzzzzzzzl_ = yzzzzzzzzzzk_?.Timing;
                    Timing.RepeatComponent yzzzzzzzzzzm_ = yzzzzzzzzzzl_?.Repeat;
                    FhirDecimal yzzzzzzzzzzn_ = yzzzzzzzzzzm_?.PeriodElement;
                    decimal? yzzzzzzzzzzo_ = yzzzzzzzzzzn_?.Value;
                    Dosage yzzzzzzzzzzq_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)xzzzzzzzzzzj_);
                    Timing yzzzzzzzzzzr_ = yzzzzzzzzzzq_?.Timing;
                    Timing.RepeatComponent yzzzzzzzzzzs_ = yzzzzzzzzzzr_?.Repeat;
                    Code<Timing.UnitsOfTime> yzzzzzzzzzzt_ = yzzzzzzzzzzs_?.PeriodUnitElement;
                    Timing.UnitsOfTime? yzzzzzzzzzzu_ = yzzzzzzzzzzt_?.Value;
                    string yzzzzzzzzzzv_ = context.Operators.Convert<string>(yzzzzzzzzzzu_);
                    CqlQuantity yzzzzzzzzzzw_ = this.Quantity(context, yzzzzzzzzzzo_, yzzzzzzzzzzv_);
                    decimal? yzzzzzzzzzzx_ = this.ToDaily(context, yzzzzzzzzzzc_ ?? yzzzzzzzzzzi_, yzzzzzzzzzzw_);
                    Dosage yzzzzzzzzzzz_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)xzzzzzzzzzzj_);
                    Timing zzzzzzzzzzza_ = yzzzzzzzzzzz_?.Timing;
                    Timing.RepeatComponent zzzzzzzzzzzb_ = zzzzzzzzzzza_?.Repeat;
                    List<Time> zzzzzzzzzzzc_ = zzzzzzzzzzzb_?.TimeOfDayElement;
                    IEnumerable<CqlTime> zzzzzzzzzzzd_ = context.Operators.LateBoundProperty<IEnumerable<CqlTime>>(zzzzzzzzzzzc_, "value");
                    int? zzzzzzzzzzze_ = context.Operators.Count<CqlTime>(zzzzzzzzzzzd_);
                    decimal? zzzzzzzzzzzf_ = context.Operators.ConvertIntegerToDecimal(zzzzzzzzzzze_);
                    decimal? zzzzzzzzzzzg_ = context.Operators.Multiply(xzzzzzzzzzzw_, (yzzzzzzzzzzx_ ?? zzzzzzzzzzzf_) ?? 1.0m);
                    decimal? zzzzzzzzzzzh_ = context.Operators.Divide(xzzzzzzzzzzi_, zzzzzzzzzzzg_);
                    decimal? zzzzzzzzzzzi_ = context.Operators.ConvertIntegerToDecimal(1);
                    decimal? zzzzzzzzzzzj_ = context.Operators.Subtract(xzzzzzzzzzzf_ ?? zzzzzzzzzzzh_, zzzzzzzzzzzi_);
                    CqlQuantity zzzzzzzzzzzk_ = this.Quantity(context, zzzzzzzzzzzj_, "day");
                    CqlDate zzzzzzzzzzzl_ = context.Operators.Add(wzzzzzzzzzzy_ ?? xzzzzzzzzzzb_, zzzzzzzzzzzk_);
                    CqlInterval<CqlDate> zzzzzzzzzzzm_ = context.Operators.Interval(wzzzzzzzzzzs_ ?? wzzzzzzzzzzv_, zzzzzzzzzzzl_, true, true);

                    return zzzzzzzzzzzm_;
                }
                else
                {
                    return null as CqlInterval<CqlDate>;
                }
            };

            return tzzzzzzzzzzz_();
        };
        IEnumerable<CqlInterval<CqlDate>> tzzzzzzzzzzw_ = context.Operators.Select<MedicationDispense, CqlInterval<CqlDate>>((IEnumerable<MedicationDispense>)tzzzzzzzzzzu_, tzzzzzzzzzzv_);
        IEnumerable<CqlInterval<CqlDate>> tzzzzzzzzzzx_ = context.Operators.Distinct<CqlInterval<CqlDate>>(tzzzzzzzzzzw_);
        CqlInterval<CqlDate> tzzzzzzzzzzy_ = context.Operators.SingletonFrom<CqlInterval<CqlDate>>(tzzzzzzzzzzx_);

        return tzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("medicationDispensePeriod")]
    public CqlInterval<CqlDate> medicationDispensePeriod(CqlContext context, MedicationDispense Dispense)
    {
        MedicationDispense[] zzzzzzzzzzzn_ = [
            Dispense,
        ];
        CqlInterval<CqlDate> zzzzzzzzzzzo_(MedicationDispense D)
        {
            CqlInterval<CqlDate> zzzzzzzzzzzs_()
            {
                bool zzzzzzzzzzzt_()
                {
                    FhirDateTime zzzzzzzzzzzu_ = D?.WhenHandedOverElement;
                    CqlDateTime zzzzzzzzzzzv_ = context.Operators.Convert<CqlDateTime>(zzzzzzzzzzzu_);
                    CqlDate zzzzzzzzzzzw_ = context.Operators.DateFrom(zzzzzzzzzzzv_);
                    FhirDateTime zzzzzzzzzzzx_ = D?.WhenPreparedElement;
                    CqlDateTime zzzzzzzzzzzy_ = context.Operators.Convert<CqlDateTime>(zzzzzzzzzzzx_);
                    CqlDate zzzzzzzzzzzz_ = context.Operators.DateFrom(zzzzzzzzzzzy_);
                    bool? azzzzzzzzzzza_ = context.Operators.Not((bool?)((zzzzzzzzzzzw_ ?? zzzzzzzzzzzz_) is null));
                    Quantity azzzzzzzzzzzb_ = D?.DaysSupply;
                    CqlQuantity azzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, azzzzzzzzzzzb_);
                    CqlQuantity azzzzzzzzzzzd_ = context.Operators.ConvertQuantity(azzzzzzzzzzzc_, "d");
                    decimal? azzzzzzzzzzze_ = azzzzzzzzzzzd_?.value;
                    Quantity azzzzzzzzzzzf_ = D?.Quantity;
                    CqlQuantity azzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, azzzzzzzzzzzf_);
                    decimal? azzzzzzzzzzzh_ = azzzzzzzzzzzg_?.value;
                    List<Dosage> azzzzzzzzzzzi_ = D?.DosageInstruction;
                    Dosage azzzzzzzzzzzj_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)azzzzzzzzzzzi_);
                    List<Dosage.DoseAndRateComponent> azzzzzzzzzzzk_ = azzzzzzzzzzzj_?.DoseAndRate;
                    Dosage.DoseAndRateComponent azzzzzzzzzzzl_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)azzzzzzzzzzzk_);
                    DataType azzzzzzzzzzzm_ = azzzzzzzzzzzl_?.Dose;
                    object azzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzm_);
                    CqlQuantity azzzzzzzzzzzo_ = context.Operators.End(azzzzzzzzzzzn_ as CqlInterval<CqlQuantity>);
                    Dosage azzzzzzzzzzzq_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)azzzzzzzzzzzi_);
                    List<Dosage.DoseAndRateComponent> azzzzzzzzzzzr_ = azzzzzzzzzzzq_?.DoseAndRate;
                    Dosage.DoseAndRateComponent azzzzzzzzzzzs_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)azzzzzzzzzzzr_);
                    DataType azzzzzzzzzzzt_ = azzzzzzzzzzzs_?.Dose;
                    object azzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzt_);
                    decimal? azzzzzzzzzzzv_ = (azzzzzzzzzzzo_ ?? azzzzzzzzzzzu_ as CqlQuantity)?.value;
                    Dosage azzzzzzzzzzzx_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)azzzzzzzzzzzi_);
                    Timing azzzzzzzzzzzy_ = azzzzzzzzzzzx_?.Timing;
                    Timing.RepeatComponent azzzzzzzzzzzz_ = azzzzzzzzzzzy_?.Repeat;
                    PositiveInt bzzzzzzzzzzza_ = azzzzzzzzzzzz_?.FrequencyMaxElement;
                    int? bzzzzzzzzzzzb_ = bzzzzzzzzzzza_?.Value;
                    Dosage bzzzzzzzzzzzd_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)azzzzzzzzzzzi_);
                    Timing bzzzzzzzzzzze_ = bzzzzzzzzzzzd_?.Timing;
                    Timing.RepeatComponent bzzzzzzzzzzzf_ = bzzzzzzzzzzze_?.Repeat;
                    PositiveInt bzzzzzzzzzzzg_ = bzzzzzzzzzzzf_?.FrequencyElement;
                    int? bzzzzzzzzzzzh_ = bzzzzzzzzzzzg_?.Value;
                    Dosage bzzzzzzzzzzzj_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)azzzzzzzzzzzi_);
                    Timing bzzzzzzzzzzzk_ = bzzzzzzzzzzzj_?.Timing;
                    Timing.RepeatComponent bzzzzzzzzzzzl_ = bzzzzzzzzzzzk_?.Repeat;
                    FhirDecimal bzzzzzzzzzzzm_ = bzzzzzzzzzzzl_?.PeriodElement;
                    decimal? bzzzzzzzzzzzn_ = bzzzzzzzzzzzm_?.Value;
                    Dosage bzzzzzzzzzzzp_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)azzzzzzzzzzzi_);
                    Timing bzzzzzzzzzzzq_ = bzzzzzzzzzzzp_?.Timing;
                    Timing.RepeatComponent bzzzzzzzzzzzr_ = bzzzzzzzzzzzq_?.Repeat;
                    Code<Timing.UnitsOfTime> bzzzzzzzzzzzs_ = bzzzzzzzzzzzr_?.PeriodUnitElement;
                    Timing.UnitsOfTime? bzzzzzzzzzzzt_ = bzzzzzzzzzzzs_?.Value;
                    string bzzzzzzzzzzzu_ = context.Operators.Convert<string>(bzzzzzzzzzzzt_);
                    CqlQuantity bzzzzzzzzzzzv_ = this.Quantity(context, bzzzzzzzzzzzn_, bzzzzzzzzzzzu_);
                    decimal? bzzzzzzzzzzzw_ = this.ToDaily(context, bzzzzzzzzzzzb_ ?? bzzzzzzzzzzzh_, bzzzzzzzzzzzv_);
                    Dosage bzzzzzzzzzzzy_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)azzzzzzzzzzzi_);
                    Timing bzzzzzzzzzzzz_ = bzzzzzzzzzzzy_?.Timing;
                    Timing.RepeatComponent czzzzzzzzzzza_ = bzzzzzzzzzzzz_?.Repeat;
                    List<Time> czzzzzzzzzzzb_ = czzzzzzzzzzza_?.TimeOfDayElement;
                    IEnumerable<CqlTime> czzzzzzzzzzzc_ = context.Operators.LateBoundProperty<IEnumerable<CqlTime>>(czzzzzzzzzzzb_, "value");
                    int? czzzzzzzzzzzd_ = context.Operators.Count<CqlTime>(czzzzzzzzzzzc_);
                    decimal? czzzzzzzzzzze_ = context.Operators.ConvertIntegerToDecimal(czzzzzzzzzzzd_);
                    decimal? czzzzzzzzzzzf_ = context.Operators.Multiply(azzzzzzzzzzzv_, (bzzzzzzzzzzzw_ ?? czzzzzzzzzzze_) ?? 1.0m);
                    decimal? czzzzzzzzzzzg_ = context.Operators.Divide(azzzzzzzzzzzh_, czzzzzzzzzzzf_);
                    bool? czzzzzzzzzzzh_ = context.Operators.Not((bool?)((azzzzzzzzzzze_ ?? czzzzzzzzzzzg_) is null));
                    bool? czzzzzzzzzzzi_ = context.Operators.And(azzzzzzzzzzza_, czzzzzzzzzzzh_);

                    return czzzzzzzzzzzi_ ?? false;
                };
                if (zzzzzzzzzzzt_())
                {
                    FhirDateTime czzzzzzzzzzzj_ = D?.WhenHandedOverElement;
                    CqlDateTime czzzzzzzzzzzk_ = context.Operators.Convert<CqlDateTime>(czzzzzzzzzzzj_);
                    CqlDate czzzzzzzzzzzl_ = context.Operators.DateFrom(czzzzzzzzzzzk_);
                    FhirDateTime czzzzzzzzzzzm_ = D?.WhenPreparedElement;
                    CqlDateTime czzzzzzzzzzzn_ = context.Operators.Convert<CqlDateTime>(czzzzzzzzzzzm_);
                    CqlDate czzzzzzzzzzzo_ = context.Operators.DateFrom(czzzzzzzzzzzn_);
                    CqlDateTime czzzzzzzzzzzq_ = context.Operators.Convert<CqlDateTime>(czzzzzzzzzzzj_);
                    CqlDate czzzzzzzzzzzr_ = context.Operators.DateFrom(czzzzzzzzzzzq_);
                    CqlDateTime czzzzzzzzzzzt_ = context.Operators.Convert<CqlDateTime>(czzzzzzzzzzzm_);
                    CqlDate czzzzzzzzzzzu_ = context.Operators.DateFrom(czzzzzzzzzzzt_);
                    Quantity czzzzzzzzzzzv_ = D?.DaysSupply;
                    CqlQuantity czzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, czzzzzzzzzzzv_);
                    CqlQuantity czzzzzzzzzzzx_ = context.Operators.ConvertQuantity(czzzzzzzzzzzw_, "d");
                    decimal? czzzzzzzzzzzy_ = czzzzzzzzzzzx_?.value;
                    Quantity czzzzzzzzzzzz_ = D?.Quantity;
                    CqlQuantity dzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, czzzzzzzzzzzz_);
                    decimal? dzzzzzzzzzzzb_ = dzzzzzzzzzzza_?.value;
                    List<Dosage> dzzzzzzzzzzzc_ = D?.DosageInstruction;
                    Dosage dzzzzzzzzzzzd_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)dzzzzzzzzzzzc_);
                    List<Dosage.DoseAndRateComponent> dzzzzzzzzzzze_ = dzzzzzzzzzzzd_?.DoseAndRate;
                    Dosage.DoseAndRateComponent dzzzzzzzzzzzf_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)dzzzzzzzzzzze_);
                    DataType dzzzzzzzzzzzg_ = dzzzzzzzzzzzf_?.Dose;
                    object dzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzg_);
                    CqlQuantity dzzzzzzzzzzzi_ = context.Operators.End(dzzzzzzzzzzzh_ as CqlInterval<CqlQuantity>);
                    Dosage dzzzzzzzzzzzk_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)dzzzzzzzzzzzc_);
                    List<Dosage.DoseAndRateComponent> dzzzzzzzzzzzl_ = dzzzzzzzzzzzk_?.DoseAndRate;
                    Dosage.DoseAndRateComponent dzzzzzzzzzzzm_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)dzzzzzzzzzzzl_);
                    DataType dzzzzzzzzzzzn_ = dzzzzzzzzzzzm_?.Dose;
                    object dzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzn_);
                    decimal? dzzzzzzzzzzzp_ = (dzzzzzzzzzzzi_ ?? dzzzzzzzzzzzo_ as CqlQuantity)?.value;
                    Dosage dzzzzzzzzzzzr_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)dzzzzzzzzzzzc_);
                    Timing dzzzzzzzzzzzs_ = dzzzzzzzzzzzr_?.Timing;
                    Timing.RepeatComponent dzzzzzzzzzzzt_ = dzzzzzzzzzzzs_?.Repeat;
                    PositiveInt dzzzzzzzzzzzu_ = dzzzzzzzzzzzt_?.FrequencyMaxElement;
                    int? dzzzzzzzzzzzv_ = dzzzzzzzzzzzu_?.Value;
                    Dosage dzzzzzzzzzzzx_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)dzzzzzzzzzzzc_);
                    Timing dzzzzzzzzzzzy_ = dzzzzzzzzzzzx_?.Timing;
                    Timing.RepeatComponent dzzzzzzzzzzzz_ = dzzzzzzzzzzzy_?.Repeat;
                    PositiveInt ezzzzzzzzzzza_ = dzzzzzzzzzzzz_?.FrequencyElement;
                    int? ezzzzzzzzzzzb_ = ezzzzzzzzzzza_?.Value;
                    Dosage ezzzzzzzzzzzd_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)dzzzzzzzzzzzc_);
                    Timing ezzzzzzzzzzze_ = ezzzzzzzzzzzd_?.Timing;
                    Timing.RepeatComponent ezzzzzzzzzzzf_ = ezzzzzzzzzzze_?.Repeat;
                    FhirDecimal ezzzzzzzzzzzg_ = ezzzzzzzzzzzf_?.PeriodElement;
                    decimal? ezzzzzzzzzzzh_ = ezzzzzzzzzzzg_?.Value;
                    Dosage ezzzzzzzzzzzj_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)dzzzzzzzzzzzc_);
                    Timing ezzzzzzzzzzzk_ = ezzzzzzzzzzzj_?.Timing;
                    Timing.RepeatComponent ezzzzzzzzzzzl_ = ezzzzzzzzzzzk_?.Repeat;
                    Code<Timing.UnitsOfTime> ezzzzzzzzzzzm_ = ezzzzzzzzzzzl_?.PeriodUnitElement;
                    Timing.UnitsOfTime? ezzzzzzzzzzzn_ = ezzzzzzzzzzzm_?.Value;
                    string ezzzzzzzzzzzo_ = context.Operators.Convert<string>(ezzzzzzzzzzzn_);
                    CqlQuantity ezzzzzzzzzzzp_ = this.Quantity(context, ezzzzzzzzzzzh_, ezzzzzzzzzzzo_);
                    decimal? ezzzzzzzzzzzq_ = this.ToDaily(context, dzzzzzzzzzzzv_ ?? ezzzzzzzzzzzb_, ezzzzzzzzzzzp_);
                    Dosage ezzzzzzzzzzzs_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)dzzzzzzzzzzzc_);
                    Timing ezzzzzzzzzzzt_ = ezzzzzzzzzzzs_?.Timing;
                    Timing.RepeatComponent ezzzzzzzzzzzu_ = ezzzzzzzzzzzt_?.Repeat;
                    List<Time> ezzzzzzzzzzzv_ = ezzzzzzzzzzzu_?.TimeOfDayElement;
                    IEnumerable<CqlTime> ezzzzzzzzzzzw_ = context.Operators.LateBoundProperty<IEnumerable<CqlTime>>(ezzzzzzzzzzzv_, "value");
                    int? ezzzzzzzzzzzx_ = context.Operators.Count<CqlTime>(ezzzzzzzzzzzw_);
                    decimal? ezzzzzzzzzzzy_ = context.Operators.ConvertIntegerToDecimal(ezzzzzzzzzzzx_);
                    decimal? ezzzzzzzzzzzz_ = context.Operators.Multiply(dzzzzzzzzzzzp_, (ezzzzzzzzzzzq_ ?? ezzzzzzzzzzzy_) ?? 1.0m);
                    decimal? fzzzzzzzzzzza_ = context.Operators.Divide(dzzzzzzzzzzzb_, ezzzzzzzzzzzz_);
                    decimal? fzzzzzzzzzzzb_ = context.Operators.ConvertIntegerToDecimal(1);
                    decimal? fzzzzzzzzzzzc_ = context.Operators.Subtract(czzzzzzzzzzzy_ ?? fzzzzzzzzzzza_, fzzzzzzzzzzzb_);
                    CqlQuantity fzzzzzzzzzzzd_ = this.Quantity(context, fzzzzzzzzzzzc_, "day");
                    CqlDate fzzzzzzzzzzze_ = context.Operators.Add(czzzzzzzzzzzr_ ?? czzzzzzzzzzzu_, fzzzzzzzzzzzd_);
                    CqlInterval<CqlDate> fzzzzzzzzzzzf_ = context.Operators.Interval(czzzzzzzzzzzl_ ?? czzzzzzzzzzzo_, fzzzzzzzzzzze_, true, true);

                    return fzzzzzzzzzzzf_;
                }
                else
                {
                    return null as CqlInterval<CqlDate>;
                }
            };

            return zzzzzzzzzzzs_();
        };
        IEnumerable<CqlInterval<CqlDate>> zzzzzzzzzzzp_ = context.Operators.Select<MedicationDispense, CqlInterval<CqlDate>>((IEnumerable<MedicationDispense>)zzzzzzzzzzzn_, zzzzzzzzzzzo_);
        IEnumerable<CqlInterval<CqlDate>> zzzzzzzzzzzq_ = context.Operators.Distinct<CqlInterval<CqlDate>>(zzzzzzzzzzzp_);
        CqlInterval<CqlDate> zzzzzzzzzzzr_ = context.Operators.SingletonFrom<CqlInterval<CqlDate>>(zzzzzzzzzzzq_);

        return zzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("TherapeuticDuration")]
    public CqlQuantity TherapeuticDuration(CqlContext context, CqlConcept medication)
    {
        CqlQuantity fzzzzzzzzzzzg_ = context.Operators.Quantity(14m, "days");

        return fzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("MedicationAdministrationPeriod")]
    public CqlInterval<CqlDate> MedicationAdministrationPeriod(CqlContext context, MedicationAdministration Administration)
    {
        MedicationAdministration[] fzzzzzzzzzzzh_ = [
            Administration,
        ];
        CqlInterval<CqlDate> fzzzzzzzzzzzi_(MedicationAdministration M)
        {
            CqlInterval<CqlDate> fzzzzzzzzzzzm_()
            {
                bool fzzzzzzzzzzzn_()
                {
                    DataType fzzzzzzzzzzzo_ = Administration?.Effective;
                    object fzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzo_);
                    CqlDateTime fzzzzzzzzzzzq_ = context.Operators.Start(fzzzzzzzzzzzp_ as CqlInterval<CqlDateTime>);
                    CqlDate fzzzzzzzzzzzr_ = context.Operators.DateFrom(fzzzzzzzzzzzq_);
                    bool? fzzzzzzzzzzzs_ = context.Operators.Not((bool?)(fzzzzzzzzzzzr_ is null));
                    DataType fzzzzzzzzzzzt_ = Administration?.Medication;
                    object fzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzt_);
                    CqlQuantity fzzzzzzzzzzzv_ = this.TherapeuticDuration(context, fzzzzzzzzzzzu_ as CqlConcept);
                    bool? fzzzzzzzzzzzw_ = context.Operators.Not((bool?)(fzzzzzzzzzzzv_ is null));
                    bool? fzzzzzzzzzzzx_ = context.Operators.And(fzzzzzzzzzzzs_, fzzzzzzzzzzzw_);

                    return fzzzzzzzzzzzx_ ?? false;
                };
                if (fzzzzzzzzzzzn_())
                {
                    DataType fzzzzzzzzzzzy_ = Administration?.Effective;
                    object fzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzy_);
                    CqlDateTime gzzzzzzzzzzza_ = context.Operators.Start(fzzzzzzzzzzzz_ as CqlInterval<CqlDateTime>);
                    CqlDate gzzzzzzzzzzzb_ = context.Operators.DateFrom(gzzzzzzzzzzza_);
                    object gzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzy_);
                    CqlDateTime gzzzzzzzzzzze_ = context.Operators.Start(gzzzzzzzzzzzd_ as CqlInterval<CqlDateTime>);
                    CqlDate gzzzzzzzzzzzf_ = context.Operators.DateFrom(gzzzzzzzzzzze_);
                    DataType gzzzzzzzzzzzg_ = Administration?.Medication;
                    object gzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzg_);
                    CqlQuantity gzzzzzzzzzzzi_ = this.TherapeuticDuration(context, gzzzzzzzzzzzh_ as CqlConcept);
                    CqlDate gzzzzzzzzzzzj_ = context.Operators.Add(gzzzzzzzzzzzf_, gzzzzzzzzzzzi_);
                    CqlQuantity gzzzzzzzzzzzk_ = context.Operators.ConvertIntegerToQuantity(1);
                    CqlDate gzzzzzzzzzzzl_ = context.Operators.Subtract(gzzzzzzzzzzzj_, gzzzzzzzzzzzk_);
                    CqlInterval<CqlDate> gzzzzzzzzzzzm_ = context.Operators.Interval(gzzzzzzzzzzzb_, gzzzzzzzzzzzl_, true, true);

                    return gzzzzzzzzzzzm_;
                }
                else
                {
                    return null as CqlInterval<CqlDate>;
                }
            };

            return fzzzzzzzzzzzm_();
        };
        IEnumerable<CqlInterval<CqlDate>> fzzzzzzzzzzzj_ = context.Operators.Select<MedicationAdministration, CqlInterval<CqlDate>>((IEnumerable<MedicationAdministration>)fzzzzzzzzzzzh_, fzzzzzzzzzzzi_);
        IEnumerable<CqlInterval<CqlDate>> fzzzzzzzzzzzk_ = context.Operators.Distinct<CqlInterval<CqlDate>>(fzzzzzzzzzzzj_);
        CqlInterval<CqlDate> fzzzzzzzzzzzl_ = context.Operators.SingletonFrom<CqlInterval<CqlDate>>(fzzzzzzzzzzzk_);

        return fzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("medicationAdministrationPeriod")]
    public CqlInterval<CqlDate> medicationAdministrationPeriod(CqlContext context, MedicationAdministration Administration)
    {
        MedicationAdministration[] gzzzzzzzzzzzn_ = [
            Administration,
        ];
        CqlInterval<CqlDate> gzzzzzzzzzzzo_(MedicationAdministration M)
        {
            CqlInterval<CqlDate> gzzzzzzzzzzzs_()
            {
                bool gzzzzzzzzzzzt_()
                {
                    DataType gzzzzzzzzzzzu_ = Administration?.Effective;
                    object gzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzu_);
                    CqlDateTime gzzzzzzzzzzzw_ = context.Operators.Start(gzzzzzzzzzzzv_ as CqlInterval<CqlDateTime>);
                    CqlDate gzzzzzzzzzzzx_ = context.Operators.DateFrom(gzzzzzzzzzzzw_);
                    bool? gzzzzzzzzzzzy_ = context.Operators.Not((bool?)(gzzzzzzzzzzzx_ is null));
                    DataType gzzzzzzzzzzzz_ = Administration?.Medication;
                    object hzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzz_);
                    CqlQuantity hzzzzzzzzzzzb_ = this.TherapeuticDuration(context, hzzzzzzzzzzza_ as CqlConcept);
                    bool? hzzzzzzzzzzzc_ = context.Operators.Not((bool?)(hzzzzzzzzzzzb_ is null));
                    bool? hzzzzzzzzzzzd_ = context.Operators.And(gzzzzzzzzzzzy_, hzzzzzzzzzzzc_);

                    return hzzzzzzzzzzzd_ ?? false;
                };
                if (gzzzzzzzzzzzt_())
                {
                    DataType hzzzzzzzzzzze_ = Administration?.Effective;
                    object hzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzze_);
                    CqlDateTime hzzzzzzzzzzzg_ = context.Operators.Start(hzzzzzzzzzzzf_ as CqlInterval<CqlDateTime>);
                    CqlDate hzzzzzzzzzzzh_ = context.Operators.DateFrom(hzzzzzzzzzzzg_);
                    object hzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzze_);
                    CqlDateTime hzzzzzzzzzzzk_ = context.Operators.Start(hzzzzzzzzzzzj_ as CqlInterval<CqlDateTime>);
                    CqlDate hzzzzzzzzzzzl_ = context.Operators.DateFrom(hzzzzzzzzzzzk_);
                    DataType hzzzzzzzzzzzm_ = Administration?.Medication;
                    object hzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzm_);
                    CqlQuantity hzzzzzzzzzzzo_ = this.TherapeuticDuration(context, hzzzzzzzzzzzn_ as CqlConcept);
                    CqlDate hzzzzzzzzzzzp_ = context.Operators.Add(hzzzzzzzzzzzl_, hzzzzzzzzzzzo_);
                    CqlQuantity hzzzzzzzzzzzq_ = context.Operators.ConvertIntegerToQuantity(1);
                    CqlDate hzzzzzzzzzzzr_ = context.Operators.Subtract(hzzzzzzzzzzzp_, hzzzzzzzzzzzq_);
                    CqlInterval<CqlDate> hzzzzzzzzzzzs_ = context.Operators.Interval(hzzzzzzzzzzzh_, hzzzzzzzzzzzr_, true, true);

                    return hzzzzzzzzzzzs_;
                }
                else
                {
                    return null as CqlInterval<CqlDate>;
                }
            };

            return gzzzzzzzzzzzs_();
        };
        IEnumerable<CqlInterval<CqlDate>> gzzzzzzzzzzzp_ = context.Operators.Select<MedicationAdministration, CqlInterval<CqlDate>>((IEnumerable<MedicationAdministration>)gzzzzzzzzzzzn_, gzzzzzzzzzzzo_);
        IEnumerable<CqlInterval<CqlDate>> gzzzzzzzzzzzq_ = context.Operators.Distinct<CqlInterval<CqlDate>>(gzzzzzzzzzzzp_);
        CqlInterval<CqlDate> gzzzzzzzzzzzr_ = context.Operators.SingletonFrom<CqlInterval<CqlDate>>(gzzzzzzzzzzzq_);

        return gzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("CumulativeDuration")]
    public int? CumulativeDuration(CqlContext context, IEnumerable<CqlInterval<CqlDate>> Intervals)
    {
        int? hzzzzzzzzzzzt_()
        {
            if ((context.Operators.Not((bool?)(Intervals is null))) ?? false)
            {
                IEnumerable<CqlInterval<CqlDate>> hzzzzzzzzzzzu_ = context.Operators.Collapse(Intervals, "day");
                int? hzzzzzzzzzzzv_(CqlInterval<CqlDate> X)
                {
                    CqlDate hzzzzzzzzzzzy_ = context.Operators.Start(X);
                    CqlDate hzzzzzzzzzzzz_ = context.Operators.End(X);
                    int? izzzzzzzzzzza_ = context.Operators.DifferenceBetween(hzzzzzzzzzzzy_, hzzzzzzzzzzzz_, "day");
                    int? izzzzzzzzzzzb_ = context.Operators.Add(izzzzzzzzzzza_, 1);

                    return izzzzzzzzzzzb_;
                };
                IEnumerable<int?> hzzzzzzzzzzzw_ = context.Operators.Select<CqlInterval<CqlDate>, int?>(hzzzzzzzzzzzu_, hzzzzzzzzzzzv_);
                int? hzzzzzzzzzzzx_ = context.Operators.Sum(hzzzzzzzzzzzw_);

                return hzzzzzzzzzzzx_;
            }
            else
            {
                return default;
            }
        };

        return hzzzzzzzzzzzt_();
    }


    [CqlExpressionDefinition("cumulativeDuration")]
    public int? cumulativeDuration(CqlContext context, IEnumerable<CqlInterval<CqlDate>> Intervals)
    {
        int? izzzzzzzzzzzc_()
        {
            if ((context.Operators.Not((bool?)(Intervals is null))) ?? false)
            {
                IEnumerable<CqlInterval<CqlDate>> izzzzzzzzzzzd_ = context.Operators.Collapse(Intervals, "day");
                int? izzzzzzzzzzze_(CqlInterval<CqlDate> X)
                {
                    CqlDate izzzzzzzzzzzh_ = context.Operators.Start(X);
                    CqlDate izzzzzzzzzzzi_ = context.Operators.End(X);
                    int? izzzzzzzzzzzj_ = context.Operators.DifferenceBetween(izzzzzzzzzzzh_, izzzzzzzzzzzi_, "day");
                    int? izzzzzzzzzzzk_ = context.Operators.Add(izzzzzzzzzzzj_, 1);

                    return izzzzzzzzzzzk_;
                };
                IEnumerable<int?> izzzzzzzzzzzf_ = context.Operators.Select<CqlInterval<CqlDate>, int?>(izzzzzzzzzzzd_, izzzzzzzzzzze_);
                int? izzzzzzzzzzzg_ = context.Operators.Sum(izzzzzzzzzzzf_);

                return izzzzzzzzzzzg_;
            }
            else
            {
                return default;
            }
        };

        return izzzzzzzzzzzc_();
    }


    [CqlExpressionDefinition("RolloutIntervals")]
    public IEnumerable<CqlInterval<CqlDate>> RolloutIntervals(CqlContext context, IEnumerable<CqlInterval<CqlDate>> intervals)
    {
        IEnumerable<CqlInterval<CqlDate>> izzzzzzzzzzzl_(IEnumerable<CqlInterval<CqlDate>> R, CqlInterval<CqlDate> I)
        {
            CqlInterval<CqlDate>[] izzzzzzzzzzzn_ = [
                I,
            ];
            CqlInterval<CqlDate> izzzzzzzzzzzo_(CqlInterval<CqlDate> X)
            {
                CqlInterval<CqlDate> izzzzzzzzzzzu_ = context.Operators.Last<CqlInterval<CqlDate>>(R);
                CqlDate izzzzzzzzzzzv_ = context.Operators.End(izzzzzzzzzzzu_);
                CqlQuantity izzzzzzzzzzzw_ = context.Operators.Quantity(1m, "day");
                CqlDate izzzzzzzzzzzx_ = context.Operators.Add(izzzzzzzzzzzv_, izzzzzzzzzzzw_);
                CqlDate izzzzzzzzzzzy_ = context.Operators.Start(X);
                CqlDate[] izzzzzzzzzzzz_ = [
                    izzzzzzzzzzzx_,
                    izzzzzzzzzzzy_,
                ];
                CqlDate jzzzzzzzzzzza_ = context.Operators.Max<CqlDate>(izzzzzzzzzzzz_ as IEnumerable<CqlDate>);
                CqlDate jzzzzzzzzzzzc_ = context.Operators.End(izzzzzzzzzzzu_);
                CqlDate jzzzzzzzzzzze_ = context.Operators.Add(jzzzzzzzzzzzc_, izzzzzzzzzzzw_);
                CqlDate[] jzzzzzzzzzzzg_ = [
                    jzzzzzzzzzzze_,
                    izzzzzzzzzzzy_,
                ];
                CqlDate jzzzzzzzzzzzh_ = context.Operators.Max<CqlDate>(jzzzzzzzzzzzg_ as IEnumerable<CqlDate>);
                CqlDate jzzzzzzzzzzzj_ = context.Operators.End(X);
                int? jzzzzzzzzzzzk_ = context.Operators.DurationBetween(izzzzzzzzzzzy_, jzzzzzzzzzzzj_, "day");
                decimal? jzzzzzzzzzzzl_ = context.Operators.ConvertIntegerToDecimal(jzzzzzzzzzzzk_ ?? 0);
                CqlQuantity jzzzzzzzzzzzm_ = this.Quantity(context, jzzzzzzzzzzzl_, "day");
                CqlDate jzzzzzzzzzzzn_ = context.Operators.Add(jzzzzzzzzzzzh_, jzzzzzzzzzzzm_);
                CqlInterval<CqlDate> jzzzzzzzzzzzo_ = context.Operators.Interval(jzzzzzzzzzzza_, jzzzzzzzzzzzn_, true, true);

                return jzzzzzzzzzzzo_;
            };
            IEnumerable<CqlInterval<CqlDate>> izzzzzzzzzzzp_ = context.Operators.Select<CqlInterval<CqlDate>, CqlInterval<CqlDate>>((IEnumerable<CqlInterval<CqlDate>>)izzzzzzzzzzzn_, izzzzzzzzzzzo_);
            IEnumerable<CqlInterval<CqlDate>> izzzzzzzzzzzq_ = context.Operators.Distinct<CqlInterval<CqlDate>>(izzzzzzzzzzzp_);
            CqlInterval<CqlDate> izzzzzzzzzzzr_ = context.Operators.SingletonFrom<CqlInterval<CqlDate>>(izzzzzzzzzzzq_);
            CqlInterval<CqlDate>[] izzzzzzzzzzzs_ = [
                izzzzzzzzzzzr_,
            ];
            IEnumerable<CqlInterval<CqlDate>> izzzzzzzzzzzt_ = context.Operators.Union<CqlInterval<CqlDate>>(R, izzzzzzzzzzzs_ as IEnumerable<CqlInterval<CqlDate>>);

            return izzzzzzzzzzzt_;
        };
        IEnumerable<CqlInterval<CqlDate>> izzzzzzzzzzzm_ = context.Operators.Aggregate<CqlInterval<CqlDate>, IEnumerable<CqlInterval<CqlDate>>>(intervals, izzzzzzzzzzzl_, null as IEnumerable<CqlInterval<CqlDate>>);

        return izzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("rolloutIntervals")]
    public IEnumerable<CqlInterval<CqlDate>> rolloutIntervals(CqlContext context, IEnumerable<CqlInterval<CqlDate>> intervals)
    {
        IEnumerable<CqlInterval<CqlDate>> jzzzzzzzzzzzp_(IEnumerable<CqlInterval<CqlDate>> R, CqlInterval<CqlDate> I)
        {
            CqlInterval<CqlDate>[] jzzzzzzzzzzzr_ = [
                I,
            ];
            CqlInterval<CqlDate> jzzzzzzzzzzzs_(CqlInterval<CqlDate> X)
            {
                CqlInterval<CqlDate> jzzzzzzzzzzzy_ = context.Operators.Last<CqlInterval<CqlDate>>(R);
                CqlDate jzzzzzzzzzzzz_ = context.Operators.End(jzzzzzzzzzzzy_);
                CqlQuantity kzzzzzzzzzzza_ = context.Operators.Quantity(1m, "day");
                CqlDate kzzzzzzzzzzzb_ = context.Operators.Add(jzzzzzzzzzzzz_, kzzzzzzzzzzza_);
                CqlDate kzzzzzzzzzzzc_ = context.Operators.Start(X);
                CqlDate[] kzzzzzzzzzzzd_ = [
                    kzzzzzzzzzzzb_,
                    kzzzzzzzzzzzc_,
                ];
                CqlDate kzzzzzzzzzzze_ = context.Operators.Max<CqlDate>(kzzzzzzzzzzzd_ as IEnumerable<CqlDate>);
                CqlDate kzzzzzzzzzzzg_ = context.Operators.End(jzzzzzzzzzzzy_);
                CqlDate kzzzzzzzzzzzi_ = context.Operators.Add(kzzzzzzzzzzzg_, kzzzzzzzzzzza_);
                CqlDate[] kzzzzzzzzzzzk_ = [
                    kzzzzzzzzzzzi_,
                    kzzzzzzzzzzzc_,
                ];
                CqlDate kzzzzzzzzzzzl_ = context.Operators.Max<CqlDate>(kzzzzzzzzzzzk_ as IEnumerable<CqlDate>);
                CqlDate kzzzzzzzzzzzn_ = context.Operators.End(X);
                int? kzzzzzzzzzzzo_ = context.Operators.DurationBetween(kzzzzzzzzzzzc_, kzzzzzzzzzzzn_, "day");
                decimal? kzzzzzzzzzzzp_ = context.Operators.ConvertIntegerToDecimal(kzzzzzzzzzzzo_ ?? 0);
                CqlQuantity kzzzzzzzzzzzq_ = this.Quantity(context, kzzzzzzzzzzzp_, "day");
                CqlDate kzzzzzzzzzzzr_ = context.Operators.Add(kzzzzzzzzzzzl_, kzzzzzzzzzzzq_);
                CqlInterval<CqlDate> kzzzzzzzzzzzs_ = context.Operators.Interval(kzzzzzzzzzzze_, kzzzzzzzzzzzr_, true, true);

                return kzzzzzzzzzzzs_;
            };
            IEnumerable<CqlInterval<CqlDate>> jzzzzzzzzzzzt_ = context.Operators.Select<CqlInterval<CqlDate>, CqlInterval<CqlDate>>((IEnumerable<CqlInterval<CqlDate>>)jzzzzzzzzzzzr_, jzzzzzzzzzzzs_);
            IEnumerable<CqlInterval<CqlDate>> jzzzzzzzzzzzu_ = context.Operators.Distinct<CqlInterval<CqlDate>>(jzzzzzzzzzzzt_);
            CqlInterval<CqlDate> jzzzzzzzzzzzv_ = context.Operators.SingletonFrom<CqlInterval<CqlDate>>(jzzzzzzzzzzzu_);
            CqlInterval<CqlDate>[] jzzzzzzzzzzzw_ = [
                jzzzzzzzzzzzv_,
            ];
            IEnumerable<CqlInterval<CqlDate>> jzzzzzzzzzzzx_ = context.Operators.Union<CqlInterval<CqlDate>>(R, jzzzzzzzzzzzw_ as IEnumerable<CqlInterval<CqlDate>>);

            return jzzzzzzzzzzzx_;
        };
        IEnumerable<CqlInterval<CqlDate>> jzzzzzzzzzzzq_ = context.Operators.Aggregate<CqlInterval<CqlDate>, IEnumerable<CqlInterval<CqlDate>>>(intervals, jzzzzzzzzzzzp_, null as IEnumerable<CqlInterval<CqlDate>>);

        return jzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("MedicationPeriod")]
    public CqlInterval<CqlDate> MedicationPeriod(CqlContext context, object medication)
    {
        CqlInterval<CqlDate> kzzzzzzzzzzzt_()
        {
            if (medication is MedicationRequest)
            {
                CqlInterval<CqlDate> kzzzzzzzzzzzu_ = this.MedicationRequestPeriod(context, medication as MedicationRequest);

                return kzzzzzzzzzzzu_;
            }
            else if (medication is MedicationDispense)
            {
                CqlInterval<CqlDate> kzzzzzzzzzzzv_ = this.MedicationDispensePeriod(context, medication as MedicationDispense);

                return kzzzzzzzzzzzv_;
            }
            else
            {
                return null as CqlInterval<CqlDate>;
            }
        };

        return kzzzzzzzzzzzt_();
    }


    [CqlExpressionDefinition("medicationPeriod")]
    public CqlInterval<CqlDate> medicationPeriod(CqlContext context, object medication)
    {
        CqlInterval<CqlDate> kzzzzzzzzzzzw_()
        {
            if (medication is MedicationRequest)
            {
                CqlInterval<CqlDate> kzzzzzzzzzzzx_ = this.medicationRequestPeriod(context, medication as MedicationRequest);

                return kzzzzzzzzzzzx_;
            }
            else if (medication is MedicationDispense)
            {
                CqlInterval<CqlDate> kzzzzzzzzzzzy_ = this.medicationDispensePeriod(context, medication as MedicationDispense);

                return kzzzzzzzzzzzy_;
            }
            else
            {
                return null as CqlInterval<CqlDate>;
            }
        };

        return kzzzzzzzzzzzw_();
    }


    [CqlExpressionDefinition("CumulativeMedicationDuration")]
    public int? CumulativeMedicationDuration(CqlContext context, IEnumerable<object> Medications)
    {
        bool? kzzzzzzzzzzzz_(object M)
        {
            bool lzzzzzzzzzzzm_ = M is MedicationRequest;

            return lzzzzzzzzzzzm_ as bool?;
        };
        IEnumerable<object> lzzzzzzzzzzza_ = context.Operators.Where<object>(Medications, kzzzzzzzzzzzz_);
        CqlInterval<CqlDate> lzzzzzzzzzzzb_(object M)
        {
            CqlInterval<CqlDate> lzzzzzzzzzzzn_ = this.MedicationRequestPeriod(context, M as MedicationRequest);

            return lzzzzzzzzzzzn_;
        };
        IEnumerable<CqlInterval<CqlDate>> lzzzzzzzzzzzc_ = context.Operators.Select<object, CqlInterval<CqlDate>>(lzzzzzzzzzzza_, lzzzzzzzzzzzb_);
        IEnumerable<CqlInterval<CqlDate>> lzzzzzzzzzzzd_ = context.Operators.Distinct<CqlInterval<CqlDate>>(lzzzzzzzzzzzc_);
        bool? lzzzzzzzzzzze_(object M)
        {
            bool lzzzzzzzzzzzo_ = M is MedicationDispense;

            return lzzzzzzzzzzzo_ as bool?;
        };
        IEnumerable<object> lzzzzzzzzzzzf_ = context.Operators.Where<object>(Medications, lzzzzzzzzzzze_);
        CqlInterval<CqlDate> lzzzzzzzzzzzg_(object M)
        {
            CqlInterval<CqlDate> lzzzzzzzzzzzp_ = this.MedicationDispensePeriod(context, M as MedicationDispense);

            return lzzzzzzzzzzzp_;
        };
        IEnumerable<CqlInterval<CqlDate>> lzzzzzzzzzzzh_ = context.Operators.Select<object, CqlInterval<CqlDate>>(lzzzzzzzzzzzf_, lzzzzzzzzzzzg_);
        IEnumerable<CqlInterval<CqlDate>> lzzzzzzzzzzzi_ = context.Operators.Distinct<CqlInterval<CqlDate>>(lzzzzzzzzzzzh_);
        IEnumerable<CqlInterval<CqlDate>> lzzzzzzzzzzzj_ = this.RolloutIntervals(context, lzzzzzzzzzzzi_);
        IEnumerable<CqlInterval<CqlDate>> lzzzzzzzzzzzk_ = context.Operators.Union<CqlInterval<CqlDate>>(lzzzzzzzzzzzd_, lzzzzzzzzzzzj_);
        int? lzzzzzzzzzzzl_ = this.CumulativeDuration(context, lzzzzzzzzzzzk_);

        return lzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("cumulativeMedicationDuration")]
    public int? cumulativeMedicationDuration(CqlContext context, IEnumerable<object> Medications)
    {
        bool? lzzzzzzzzzzzq_(object M)
        {
            bool mzzzzzzzzzzzd_ = M is MedicationRequest;

            return mzzzzzzzzzzzd_ as bool?;
        };
        IEnumerable<object> lzzzzzzzzzzzr_ = context.Operators.Where<object>(Medications, lzzzzzzzzzzzq_);
        CqlInterval<CqlDate> lzzzzzzzzzzzs_(object M)
        {
            CqlInterval<CqlDate> mzzzzzzzzzzze_ = this.medicationRequestPeriod(context, M as MedicationRequest);

            return mzzzzzzzzzzze_;
        };
        IEnumerable<CqlInterval<CqlDate>> lzzzzzzzzzzzt_ = context.Operators.Select<object, CqlInterval<CqlDate>>(lzzzzzzzzzzzr_, lzzzzzzzzzzzs_);
        IEnumerable<CqlInterval<CqlDate>> lzzzzzzzzzzzu_ = context.Operators.Distinct<CqlInterval<CqlDate>>(lzzzzzzzzzzzt_);
        bool? lzzzzzzzzzzzv_(object M)
        {
            bool mzzzzzzzzzzzf_ = M is MedicationDispense;

            return mzzzzzzzzzzzf_ as bool?;
        };
        IEnumerable<object> lzzzzzzzzzzzw_ = context.Operators.Where<object>(Medications, lzzzzzzzzzzzv_);
        CqlInterval<CqlDate> lzzzzzzzzzzzx_(object M)
        {
            CqlInterval<CqlDate> mzzzzzzzzzzzg_ = this.medicationDispensePeriod(context, M as MedicationDispense);

            return mzzzzzzzzzzzg_;
        };
        IEnumerable<CqlInterval<CqlDate>> lzzzzzzzzzzzy_ = context.Operators.Select<object, CqlInterval<CqlDate>>(lzzzzzzzzzzzw_, lzzzzzzzzzzzx_);
        IEnumerable<CqlInterval<CqlDate>> lzzzzzzzzzzzz_ = context.Operators.Distinct<CqlInterval<CqlDate>>(lzzzzzzzzzzzy_);
        IEnumerable<CqlInterval<CqlDate>> mzzzzzzzzzzza_ = this.rolloutIntervals(context, lzzzzzzzzzzzz_);
        IEnumerable<CqlInterval<CqlDate>> mzzzzzzzzzzzb_ = context.Operators.Union<CqlInterval<CqlDate>>(lzzzzzzzzzzzu_, mzzzzzzzzzzza_);
        int? mzzzzzzzzzzzc_ = this.cumulativeDuration(context, mzzzzzzzzzzzb_);

        return mzzzzzzzzzzzc_;
    }


    #endregion Expressions

}
