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
    private static readonly CqlCode _HS = new CqlCode("HS", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default);

    [CqlCodeDefinition("WAKE", codeId: "WAKE", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-TimingEvent")]
    public CqlCode WAKE(CqlContext _) => _WAKE;
    private static readonly CqlCode _WAKE = new CqlCode("WAKE", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default);

    [CqlCodeDefinition("C", codeId: "C", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-TimingEvent")]
    public CqlCode C(CqlContext _) => _C;
    private static readonly CqlCode _C = new CqlCode("C", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default);

    [CqlCodeDefinition("CM", codeId: "CM", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-TimingEvent")]
    public CqlCode CM(CqlContext _) => _CM;
    private static readonly CqlCode _CM = new CqlCode("CM", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default);

    [CqlCodeDefinition("CD", codeId: "CD", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-TimingEvent")]
    public CqlCode CD(CqlContext _) => _CD;
    private static readonly CqlCode _CD = new CqlCode("CD", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default);

    [CqlCodeDefinition("CV", codeId: "CV", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-TimingEvent")]
    public CqlCode CV(CqlContext _) => _CV;
    private static readonly CqlCode _CV = new CqlCode("CV", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default);

    [CqlCodeDefinition("AC", codeId: "AC", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-TimingEvent")]
    public CqlCode AC(CqlContext _) => _AC;
    private static readonly CqlCode _AC = new CqlCode("AC", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default);

    [CqlCodeDefinition("ACM", codeId: "ACM", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-TimingEvent")]
    public CqlCode ACM(CqlContext _) => _ACM;
    private static readonly CqlCode _ACM = new CqlCode("ACM", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default);

    [CqlCodeDefinition("ACD", codeId: "ACD", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-TimingEvent")]
    public CqlCode ACD(CqlContext _) => _ACD;
    private static readonly CqlCode _ACD = new CqlCode("ACD", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default);

    [CqlCodeDefinition("ACV", codeId: "ACV", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-TimingEvent")]
    public CqlCode ACV(CqlContext _) => _ACV;
    private static readonly CqlCode _ACV = new CqlCode("ACV", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default);

    [CqlCodeDefinition("PC", codeId: "PC", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-TimingEvent")]
    public CqlCode PC(CqlContext _) => _PC;
    private static readonly CqlCode _PC = new CqlCode("PC", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default);

    [CqlCodeDefinition("PCM", codeId: "PCM", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-TimingEvent")]
    public CqlCode PCM(CqlContext _) => _PCM;
    private static readonly CqlCode _PCM = new CqlCode("PCM", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default);

    [CqlCodeDefinition("PCD", codeId: "PCD", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-TimingEvent")]
    public CqlCode PCD(CqlContext _) => _PCD;
    private static readonly CqlCode _PCD = new CqlCode("PCD", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default);

    [CqlCodeDefinition("PCV", codeId: "PCV", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-TimingEvent")]
    public CqlCode PCV(CqlContext _) => _PCV;
    private static readonly CqlCode _PCV = new CqlCode("PCV", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default);

    [CqlCodeDefinition("MORN", codeId: "MORN", codeSystem: "http://hl7.org/fhir/event-timing")]
    public CqlCode MORN(CqlContext _) => _MORN;
    private static readonly CqlCode _MORN = new CqlCode("MORN", "http://hl7.org/fhir/event-timing", default, default);

    [CqlCodeDefinition("MORN.early", codeId: "MORN.early", codeSystem: "http://hl7.org/fhir/event-timing")]
    public CqlCode MORN_early(CqlContext _) => _MORN_early;
    private static readonly CqlCode _MORN_early = new CqlCode("MORN.early", "http://hl7.org/fhir/event-timing", default, default);

    [CqlCodeDefinition("MORN.late", codeId: "MORN.late", codeSystem: "http://hl7.org/fhir/event-timing")]
    public CqlCode MORN_late(CqlContext _) => _MORN_late;
    private static readonly CqlCode _MORN_late = new CqlCode("MORN.late", "http://hl7.org/fhir/event-timing", default, default);

    [CqlCodeDefinition("NOON", codeId: "NOON", codeSystem: "http://hl7.org/fhir/event-timing")]
    public CqlCode NOON(CqlContext _) => _NOON;
    private static readonly CqlCode _NOON = new CqlCode("NOON", "http://hl7.org/fhir/event-timing", default, default);

    [CqlCodeDefinition("AFT", codeId: "AFT", codeSystem: "http://hl7.org/fhir/event-timing")]
    public CqlCode AFT(CqlContext _) => _AFT;
    private static readonly CqlCode _AFT = new CqlCode("AFT", "http://hl7.org/fhir/event-timing", default, default);

    [CqlCodeDefinition("AFT.early", codeId: "AFT.early", codeSystem: "http://hl7.org/fhir/event-timing")]
    public CqlCode AFT_early(CqlContext _) => _AFT_early;
    private static readonly CqlCode _AFT_early = new CqlCode("AFT.early", "http://hl7.org/fhir/event-timing", default, default);

    [CqlCodeDefinition("AFT.late", codeId: "AFT.late", codeSystem: "http://hl7.org/fhir/event-timing")]
    public CqlCode AFT_late(CqlContext _) => _AFT_late;
    private static readonly CqlCode _AFT_late = new CqlCode("AFT.late", "http://hl7.org/fhir/event-timing", default, default);

    [CqlCodeDefinition("EVE", codeId: "EVE", codeSystem: "http://hl7.org/fhir/event-timing")]
    public CqlCode EVE(CqlContext _) => _EVE;
    private static readonly CqlCode _EVE = new CqlCode("EVE", "http://hl7.org/fhir/event-timing", default, default);

    [CqlCodeDefinition("EVE.early", codeId: "EVE.early", codeSystem: "http://hl7.org/fhir/event-timing")]
    public CqlCode EVE_early(CqlContext _) => _EVE_early;
    private static readonly CqlCode _EVE_early = new CqlCode("EVE.early", "http://hl7.org/fhir/event-timing", default, default);

    [CqlCodeDefinition("EVE.late", codeId: "EVE.late", codeSystem: "http://hl7.org/fhir/event-timing")]
    public CqlCode EVE_late(CqlContext _) => _EVE_late;
    private static readonly CqlCode _EVE_late = new CqlCode("EVE.late", "http://hl7.org/fhir/event-timing", default, default);

    [CqlCodeDefinition("NIGHT", codeId: "NIGHT", codeSystem: "http://hl7.org/fhir/event-timing")]
    public CqlCode NIGHT(CqlContext _) => _NIGHT;
    private static readonly CqlCode _NIGHT = new CqlCode("NIGHT", "http://hl7.org/fhir/event-timing", default, default);

    [CqlCodeDefinition("PHS", codeId: "PHS", codeSystem: "http://hl7.org/fhir/event-timing")]
    public CqlCode PHS(CqlContext _) => _PHS;
    private static readonly CqlCode _PHS = new CqlCode("PHS", "http://hl7.org/fhir/event-timing", default, default);

    [CqlCodeDefinition("Every eight hours (qualifier value)", codeId: "307469008", codeSystem: "http://snomed.info/sct")]
    public CqlCode Every_eight_hours__qualifier_value_(CqlContext _) => _Every_eight_hours__qualifier_value_;
    private static readonly CqlCode _Every_eight_hours__qualifier_value_ = new CqlCode("307469008", "http://snomed.info/sct", default, default);

    [CqlCodeDefinition("Every eight to twelve hours (qualifier value)", codeId: "396140003", codeSystem: "http://snomed.info/sct")]
    public CqlCode Every_eight_to_twelve_hours__qualifier_value_(CqlContext _) => _Every_eight_to_twelve_hours__qualifier_value_;
    private static readonly CqlCode _Every_eight_to_twelve_hours__qualifier_value_ = new CqlCode("396140003", "http://snomed.info/sct", default, default);

    [CqlCodeDefinition("Every forty eight hours (qualifier value)", codeId: "396131002", codeSystem: "http://snomed.info/sct")]
    public CqlCode Every_forty_eight_hours__qualifier_value_(CqlContext _) => _Every_forty_eight_hours__qualifier_value_;
    private static readonly CqlCode _Every_forty_eight_hours__qualifier_value_ = new CqlCode("396131002", "http://snomed.info/sct", default, default);

    [CqlCodeDefinition("Every forty hours (qualifier value)", codeId: "396130001", codeSystem: "http://snomed.info/sct")]
    public CqlCode Every_forty_hours__qualifier_value_(CqlContext _) => _Every_forty_hours__qualifier_value_;
    private static readonly CqlCode _Every_forty_hours__qualifier_value_ = new CqlCode("396130001", "http://snomed.info/sct", default, default);

    [CqlCodeDefinition("Every four hours (qualifier value)", codeId: "225756002", codeSystem: "http://snomed.info/sct")]
    public CqlCode Every_four_hours__qualifier_value_(CqlContext _) => _Every_four_hours__qualifier_value_;
    private static readonly CqlCode _Every_four_hours__qualifier_value_ = new CqlCode("225756002", "http://snomed.info/sct", default, default);

    [CqlCodeDefinition("Every seventy two hours (qualifier value)", codeId: "396143001", codeSystem: "http://snomed.info/sct")]
    public CqlCode Every_seventy_two_hours__qualifier_value_(CqlContext _) => _Every_seventy_two_hours__qualifier_value_;
    private static readonly CqlCode _Every_seventy_two_hours__qualifier_value_ = new CqlCode("396143001", "http://snomed.info/sct", default, default);

    [CqlCodeDefinition("Every six hours (qualifier value)", codeId: "307468000", codeSystem: "http://snomed.info/sct")]
    public CqlCode Every_six_hours__qualifier_value_(CqlContext _) => _Every_six_hours__qualifier_value_;
    private static readonly CqlCode _Every_six_hours__qualifier_value_ = new CqlCode("307468000", "http://snomed.info/sct", default, default);

    [CqlCodeDefinition("Every six to eight hours (qualifier value)", codeId: "396139000", codeSystem: "http://snomed.info/sct")]
    public CqlCode Every_six_to_eight_hours__qualifier_value_(CqlContext _) => _Every_six_to_eight_hours__qualifier_value_;
    private static readonly CqlCode _Every_six_to_eight_hours__qualifier_value_ = new CqlCode("396139000", "http://snomed.info/sct", default, default);

    [CqlCodeDefinition("Every thirty six hours (qualifier value)", codeId: "396126004", codeSystem: "http://snomed.info/sct")]
    public CqlCode Every_thirty_six_hours__qualifier_value_(CqlContext _) => _Every_thirty_six_hours__qualifier_value_;
    private static readonly CqlCode _Every_thirty_six_hours__qualifier_value_ = new CqlCode("396126004", "http://snomed.info/sct", default, default);

    [CqlCodeDefinition("Every three to four hours (qualifier value)", codeId: "225754004", codeSystem: "http://snomed.info/sct")]
    public CqlCode Every_three_to_four_hours__qualifier_value_(CqlContext _) => _Every_three_to_four_hours__qualifier_value_;
    private static readonly CqlCode _Every_three_to_four_hours__qualifier_value_ = new CqlCode("225754004", "http://snomed.info/sct", default, default);

    [CqlCodeDefinition("Every three to six hours (qualifier value)", codeId: "396127008", codeSystem: "http://snomed.info/sct")]
    public CqlCode Every_three_to_six_hours__qualifier_value_(CqlContext _) => _Every_three_to_six_hours__qualifier_value_;
    private static readonly CqlCode _Every_three_to_six_hours__qualifier_value_ = new CqlCode("396127008", "http://snomed.info/sct", default, default);

    [CqlCodeDefinition("Every twelve hours (qualifier value)", codeId: "307470009", codeSystem: "http://snomed.info/sct")]
    public CqlCode Every_twelve_hours__qualifier_value_(CqlContext _) => _Every_twelve_hours__qualifier_value_;
    private static readonly CqlCode _Every_twelve_hours__qualifier_value_ = new CqlCode("307470009", "http://snomed.info/sct", default, default);

    [CqlCodeDefinition("Every twenty four hours (qualifier value)", codeId: "396125000", codeSystem: "http://snomed.info/sct")]
    public CqlCode Every_twenty_four_hours__qualifier_value_(CqlContext _) => _Every_twenty_four_hours__qualifier_value_;
    private static readonly CqlCode _Every_twenty_four_hours__qualifier_value_ = new CqlCode("396125000", "http://snomed.info/sct", default, default);

    [CqlCodeDefinition("Every two to four hours (qualifier value)", codeId: "225752000", codeSystem: "http://snomed.info/sct")]
    public CqlCode Every_two_to_four_hours__qualifier_value_(CqlContext _) => _Every_two_to_four_hours__qualifier_value_;
    private static readonly CqlCode _Every_two_to_four_hours__qualifier_value_ = new CqlCode("225752000", "http://snomed.info/sct", default, default);

    [CqlCodeDefinition("Four times daily (qualifier value)", codeId: "307439001", codeSystem: "http://snomed.info/sct")]
    public CqlCode Four_times_daily__qualifier_value_(CqlContext _) => _Four_times_daily__qualifier_value_;
    private static readonly CqlCode _Four_times_daily__qualifier_value_ = new CqlCode("307439001", "http://snomed.info/sct", default, default);

    [CqlCodeDefinition("Once daily (qualifier value)", codeId: "229797004", codeSystem: "http://snomed.info/sct")]
    public CqlCode Once_daily__qualifier_value_(CqlContext _) => _Once_daily__qualifier_value_;
    private static readonly CqlCode _Once_daily__qualifier_value_ = new CqlCode("229797004", "http://snomed.info/sct", default, default);

    [CqlCodeDefinition("One to four times a day (qualifier value)", codeId: "396109005", codeSystem: "http://snomed.info/sct")]
    public CqlCode One_to_four_times_a_day__qualifier_value_(CqlContext _) => _One_to_four_times_a_day__qualifier_value_;
    private static readonly CqlCode _One_to_four_times_a_day__qualifier_value_ = new CqlCode("396109005", "http://snomed.info/sct", default, default);

    [CqlCodeDefinition("One to three times a day (qualifier value)", codeId: "396108002", codeSystem: "http://snomed.info/sct")]
    public CqlCode One_to_three_times_a_day__qualifier_value_(CqlContext _) => _One_to_three_times_a_day__qualifier_value_;
    private static readonly CqlCode _One_to_three_times_a_day__qualifier_value_ = new CqlCode("396108002", "http://snomed.info/sct", default, default);

    [CqlCodeDefinition("One to two times a day (qualifier value)", codeId: "396107007", codeSystem: "http://snomed.info/sct")]
    public CqlCode One_to_two_times_a_day__qualifier_value_(CqlContext _) => _One_to_two_times_a_day__qualifier_value_;
    private static readonly CqlCode _One_to_two_times_a_day__qualifier_value_ = new CqlCode("396107007", "http://snomed.info/sct", default, default);

    [CqlCodeDefinition("Three times daily (qualifier value)", codeId: "229798009", codeSystem: "http://snomed.info/sct")]
    public CqlCode Three_times_daily__qualifier_value_(CqlContext _) => _Three_times_daily__qualifier_value_;
    private static readonly CqlCode _Three_times_daily__qualifier_value_ = new CqlCode("229798009", "http://snomed.info/sct", default, default);

    [CqlCodeDefinition("Twice a day (qualifier value)", codeId: "229799001", codeSystem: "http://snomed.info/sct")]
    public CqlCode Twice_a_day__qualifier_value_(CqlContext _) => _Twice_a_day__qualifier_value_;
    private static readonly CqlCode _Twice_a_day__qualifier_value_ = new CqlCode("229799001", "http://snomed.info/sct", default, default);

    [CqlCodeDefinition("Two to four times a day (qualifier value)", codeId: "396111001", codeSystem: "http://snomed.info/sct")]
    public CqlCode Two_to_four_times_a_day__qualifier_value_(CqlContext _) => _Two_to_four_times_a_day__qualifier_value_;
    private static readonly CqlCode _Two_to_four_times_a_day__qualifier_value_ = new CqlCode("396111001", "http://snomed.info/sct", default, default);

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("V3TimingEvent")]
    public CqlCodeSystem V3TimingEvent(CqlContext _) => _V3TimingEvent;
    private static readonly CqlCodeSystem _V3TimingEvent = new CqlCodeSystem();

    [CqlCodeSystemDefinition("EventTiming")]
    public CqlCodeSystem EventTiming(CqlContext _) => _EventTiming;
    private static readonly CqlCodeSystem _EventTiming = new CqlCodeSystem();

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("ErrorLevel")]
    public string ErrorLevel(CqlContext context)
    {
        object mzzzzzzzzc_ = context.ResolveParameter("CumulativeMedicationDuration-4.1.000", "ErrorLevel", "Warning");

        return (string)mzzzzzzzzc_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> mzzzzzzzzd_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient mzzzzzzzze_ = context.Operators.SingletonFrom<Patient>(mzzzzzzzzd_);

        return mzzzzzzzze_;
    }


    [CqlExpressionDefinition("ToDaily")]
    public decimal? ToDaily(CqlContext context, int? frequency, CqlQuantity period)
    {
        decimal? mzzzzzzzzf_()
        {
            bool mzzzzzzzzg_()
            {
                string nzzzzzzzzb_ = period?.unit;
                bool? nzzzzzzzzc_ = context.Operators.Equal(nzzzzzzzzb_, "h");

                return nzzzzzzzzc_ ?? false;
            };
            bool mzzzzzzzzh_()
            {
                string nzzzzzzzzd_ = period?.unit;
                bool? nzzzzzzzze_ = context.Operators.Equal(nzzzzzzzzd_, "min");

                return nzzzzzzzze_ ?? false;
            };
            bool mzzzzzzzzi_()
            {
                string nzzzzzzzzf_ = period?.unit;
                bool? nzzzzzzzzg_ = context.Operators.Equal(nzzzzzzzzf_, "s");

                return nzzzzzzzzg_ ?? false;
            };
            bool mzzzzzzzzj_()
            {
                string nzzzzzzzzh_ = period?.unit;
                bool? nzzzzzzzzi_ = context.Operators.Equal(nzzzzzzzzh_, "d");

                return nzzzzzzzzi_ ?? false;
            };
            bool mzzzzzzzzk_()
            {
                string nzzzzzzzzj_ = period?.unit;
                bool? nzzzzzzzzk_ = context.Operators.Equal(nzzzzzzzzj_, "wk");

                return nzzzzzzzzk_ ?? false;
            };
            bool mzzzzzzzzl_()
            {
                string nzzzzzzzzl_ = period?.unit;
                bool? nzzzzzzzzm_ = context.Operators.Equal(nzzzzzzzzl_, "mo");

                return nzzzzzzzzm_ ?? false;
            };
            bool mzzzzzzzzm_()
            {
                string nzzzzzzzzn_ = period?.unit;
                bool? nzzzzzzzzo_ = context.Operators.Equal(nzzzzzzzzn_, "a");

                return nzzzzzzzzo_ ?? false;
            };
            bool mzzzzzzzzn_()
            {
                string nzzzzzzzzp_ = period?.unit;
                bool? nzzzzzzzzq_ = context.Operators.Equal(nzzzzzzzzp_, "hour");

                return nzzzzzzzzq_ ?? false;
            };
            bool mzzzzzzzzo_()
            {
                string nzzzzzzzzr_ = period?.unit;
                bool? nzzzzzzzzs_ = context.Operators.Equal(nzzzzzzzzr_, "minute");

                return nzzzzzzzzs_ ?? false;
            };
            bool mzzzzzzzzp_()
            {
                string nzzzzzzzzt_ = period?.unit;
                bool? nzzzzzzzzu_ = context.Operators.Equal(nzzzzzzzzt_, "second");

                return nzzzzzzzzu_ ?? false;
            };
            bool mzzzzzzzzq_()
            {
                string nzzzzzzzzv_ = period?.unit;
                bool? nzzzzzzzzw_ = context.Operators.Equal(nzzzzzzzzv_, "day");

                return nzzzzzzzzw_ ?? false;
            };
            bool mzzzzzzzzr_()
            {
                string nzzzzzzzzx_ = period?.unit;
                bool? nzzzzzzzzy_ = context.Operators.Equal(nzzzzzzzzx_, "week");

                return nzzzzzzzzy_ ?? false;
            };
            bool mzzzzzzzzs_()
            {
                string nzzzzzzzzz_ = period?.unit;
                bool? ozzzzzzzza_ = context.Operators.Equal(nzzzzzzzzz_, "month");

                return ozzzzzzzza_ ?? false;
            };
            bool mzzzzzzzzt_()
            {
                string ozzzzzzzzb_ = period?.unit;
                bool? ozzzzzzzzc_ = context.Operators.Equal(ozzzzzzzzb_, "year");

                return ozzzzzzzzc_ ?? false;
            };
            bool mzzzzzzzzu_()
            {
                string ozzzzzzzzd_ = period?.unit;
                bool? ozzzzzzzze_ = context.Operators.Equal(ozzzzzzzzd_, "hours");

                return ozzzzzzzze_ ?? false;
            };
            bool mzzzzzzzzv_()
            {
                string ozzzzzzzzf_ = period?.unit;
                bool? ozzzzzzzzg_ = context.Operators.Equal(ozzzzzzzzf_, "minutes");

                return ozzzzzzzzg_ ?? false;
            };
            bool mzzzzzzzzw_()
            {
                string ozzzzzzzzh_ = period?.unit;
                bool? ozzzzzzzzi_ = context.Operators.Equal(ozzzzzzzzh_, "seconds");

                return ozzzzzzzzi_ ?? false;
            };
            bool mzzzzzzzzx_()
            {
                string ozzzzzzzzj_ = period?.unit;
                bool? ozzzzzzzzk_ = context.Operators.Equal(ozzzzzzzzj_, "days");

                return ozzzzzzzzk_ ?? false;
            };
            bool mzzzzzzzzy_()
            {
                string ozzzzzzzzl_ = period?.unit;
                bool? ozzzzzzzzm_ = context.Operators.Equal(ozzzzzzzzl_, "weeks");

                return ozzzzzzzzm_ ?? false;
            };
            bool mzzzzzzzzz_()
            {
                string ozzzzzzzzn_ = period?.unit;
                bool? ozzzzzzzzo_ = context.Operators.Equal(ozzzzzzzzn_, "months");

                return ozzzzzzzzo_ ?? false;
            };
            bool nzzzzzzzza_()
            {
                string ozzzzzzzzp_ = period?.unit;
                bool? ozzzzzzzzq_ = context.Operators.Equal(ozzzzzzzzp_, "years");

                return ozzzzzzzzq_ ?? false;
            };
            if (mzzzzzzzzg_())
            {
                decimal? ozzzzzzzzr_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? ozzzzzzzzs_ = period?.value;
                decimal? ozzzzzzzzt_ = context.Operators.Divide(24.0m, ozzzzzzzzs_);
                decimal? ozzzzzzzzu_ = context.Operators.Multiply(ozzzzzzzzr_, ozzzzzzzzt_);

                return ozzzzzzzzu_;
            }
            else if (mzzzzzzzzh_())
            {
                decimal? ozzzzzzzzv_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? ozzzzzzzzw_ = period?.value;
                decimal? ozzzzzzzzx_ = context.Operators.Divide(24.0m, ozzzzzzzzw_);
                decimal? ozzzzzzzzy_ = context.Operators.Multiply(ozzzzzzzzv_, ozzzzzzzzx_);
                decimal? ozzzzzzzzz_ = context.Operators.ConvertIntegerToDecimal(60);
                decimal? pzzzzzzzza_ = context.Operators.Multiply(ozzzzzzzzy_, ozzzzzzzzz_);

                return pzzzzzzzza_;
            }
            else if (mzzzzzzzzi_())
            {
                decimal? pzzzzzzzzb_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? pzzzzzzzzc_ = period?.value;
                decimal? pzzzzzzzzd_ = context.Operators.Divide(24.0m, pzzzzzzzzc_);
                decimal? pzzzzzzzze_ = context.Operators.Multiply(pzzzzzzzzb_, pzzzzzzzzd_);
                decimal? pzzzzzzzzf_ = context.Operators.ConvertIntegerToDecimal(60);
                decimal? pzzzzzzzzg_ = context.Operators.Multiply(pzzzzzzzze_, pzzzzzzzzf_);
                decimal? pzzzzzzzzi_ = context.Operators.Multiply(pzzzzzzzzg_, pzzzzzzzzf_);

                return pzzzzzzzzi_;
            }
            else if (mzzzzzzzzj_())
            {
                decimal? pzzzzzzzzj_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? pzzzzzzzzk_ = period?.value;
                decimal? pzzzzzzzzl_ = context.Operators.Divide(24.0m, pzzzzzzzzk_);
                decimal? pzzzzzzzzm_ = context.Operators.Multiply(pzzzzzzzzj_, pzzzzzzzzl_);
                decimal? pzzzzzzzzn_ = context.Operators.ConvertIntegerToDecimal(24);
                decimal? pzzzzzzzzo_ = context.Operators.Divide(pzzzzzzzzm_, pzzzzzzzzn_);

                return pzzzzzzzzo_;
            }
            else if (mzzzzzzzzk_())
            {
                decimal? pzzzzzzzzp_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? pzzzzzzzzq_ = period?.value;
                decimal? pzzzzzzzzr_ = context.Operators.Divide(24.0m, pzzzzzzzzq_);
                decimal? pzzzzzzzzs_ = context.Operators.Multiply(pzzzzzzzzp_, pzzzzzzzzr_);
                int? pzzzzzzzzt_ = context.Operators.Multiply(24, 7);
                decimal? pzzzzzzzzu_ = context.Operators.ConvertIntegerToDecimal(pzzzzzzzzt_);
                decimal? pzzzzzzzzv_ = context.Operators.Divide(pzzzzzzzzs_, pzzzzzzzzu_);

                return pzzzzzzzzv_;
            }
            else if (mzzzzzzzzl_())
            {
                decimal? pzzzzzzzzw_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? pzzzzzzzzx_ = period?.value;
                decimal? pzzzzzzzzy_ = context.Operators.Divide(24.0m, pzzzzzzzzx_);
                decimal? pzzzzzzzzz_ = context.Operators.Multiply(pzzzzzzzzw_, pzzzzzzzzy_);
                int? qzzzzzzzza_ = context.Operators.Multiply(24, 30);
                decimal? qzzzzzzzzb_ = context.Operators.ConvertIntegerToDecimal(qzzzzzzzza_);
                decimal? qzzzzzzzzc_ = context.Operators.Divide(pzzzzzzzzz_, qzzzzzzzzb_);

                return qzzzzzzzzc_;
            }
            else if (mzzzzzzzzm_())
            {
                decimal? qzzzzzzzzd_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? qzzzzzzzze_ = period?.value;
                decimal? qzzzzzzzzf_ = context.Operators.Divide(24.0m, qzzzzzzzze_);
                decimal? qzzzzzzzzg_ = context.Operators.Multiply(qzzzzzzzzd_, qzzzzzzzzf_);
                int? qzzzzzzzzh_ = context.Operators.Multiply(24, 365);
                decimal? qzzzzzzzzi_ = context.Operators.ConvertIntegerToDecimal(qzzzzzzzzh_);
                decimal? qzzzzzzzzj_ = context.Operators.Divide(qzzzzzzzzg_, qzzzzzzzzi_);

                return qzzzzzzzzj_;
            }
            else if (mzzzzzzzzn_())
            {
                decimal? qzzzzzzzzk_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? qzzzzzzzzl_ = period?.value;
                decimal? qzzzzzzzzm_ = context.Operators.Divide(24.0m, qzzzzzzzzl_);
                decimal? qzzzzzzzzn_ = context.Operators.Multiply(qzzzzzzzzk_, qzzzzzzzzm_);

                return qzzzzzzzzn_;
            }
            else if (mzzzzzzzzo_())
            {
                decimal? qzzzzzzzzo_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? qzzzzzzzzp_ = period?.value;
                decimal? qzzzzzzzzq_ = context.Operators.Divide(24.0m, qzzzzzzzzp_);
                decimal? qzzzzzzzzr_ = context.Operators.Multiply(qzzzzzzzzo_, qzzzzzzzzq_);
                decimal? qzzzzzzzzs_ = context.Operators.ConvertIntegerToDecimal(60);
                decimal? qzzzzzzzzt_ = context.Operators.Multiply(qzzzzzzzzr_, qzzzzzzzzs_);

                return qzzzzzzzzt_;
            }
            else if (mzzzzzzzzp_())
            {
                decimal? qzzzzzzzzu_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? qzzzzzzzzv_ = period?.value;
                decimal? qzzzzzzzzw_ = context.Operators.Divide(24.0m, qzzzzzzzzv_);
                decimal? qzzzzzzzzx_ = context.Operators.Multiply(qzzzzzzzzu_, qzzzzzzzzw_);
                decimal? qzzzzzzzzy_ = context.Operators.ConvertIntegerToDecimal(60);
                decimal? qzzzzzzzzz_ = context.Operators.Multiply(qzzzzzzzzx_, qzzzzzzzzy_);
                decimal? rzzzzzzzzb_ = context.Operators.Multiply(qzzzzzzzzz_, qzzzzzzzzy_);

                return rzzzzzzzzb_;
            }
            else if (mzzzzzzzzq_())
            {
                decimal? rzzzzzzzzc_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? rzzzzzzzzd_ = period?.value;
                decimal? rzzzzzzzze_ = context.Operators.Divide(24.0m, rzzzzzzzzd_);
                decimal? rzzzzzzzzf_ = context.Operators.Multiply(rzzzzzzzzc_, rzzzzzzzze_);
                decimal? rzzzzzzzzg_ = context.Operators.ConvertIntegerToDecimal(24);
                decimal? rzzzzzzzzh_ = context.Operators.Divide(rzzzzzzzzf_, rzzzzzzzzg_);

                return rzzzzzzzzh_;
            }
            else if (mzzzzzzzzr_())
            {
                decimal? rzzzzzzzzi_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? rzzzzzzzzj_ = period?.value;
                decimal? rzzzzzzzzk_ = context.Operators.Divide(24.0m, rzzzzzzzzj_);
                decimal? rzzzzzzzzl_ = context.Operators.Multiply(rzzzzzzzzi_, rzzzzzzzzk_);
                int? rzzzzzzzzm_ = context.Operators.Multiply(24, 7);
                decimal? rzzzzzzzzn_ = context.Operators.ConvertIntegerToDecimal(rzzzzzzzzm_);
                decimal? rzzzzzzzzo_ = context.Operators.Divide(rzzzzzzzzl_, rzzzzzzzzn_);

                return rzzzzzzzzo_;
            }
            else if (mzzzzzzzzs_())
            {
                decimal? rzzzzzzzzp_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? rzzzzzzzzq_ = period?.value;
                decimal? rzzzzzzzzr_ = context.Operators.Divide(24.0m, rzzzzzzzzq_);
                decimal? rzzzzzzzzs_ = context.Operators.Multiply(rzzzzzzzzp_, rzzzzzzzzr_);
                int? rzzzzzzzzt_ = context.Operators.Multiply(24, 30);
                decimal? rzzzzzzzzu_ = context.Operators.ConvertIntegerToDecimal(rzzzzzzzzt_);
                decimal? rzzzzzzzzv_ = context.Operators.Divide(rzzzzzzzzs_, rzzzzzzzzu_);

                return rzzzzzzzzv_;
            }
            else if (mzzzzzzzzt_())
            {
                decimal? rzzzzzzzzw_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? rzzzzzzzzx_ = period?.value;
                decimal? rzzzzzzzzy_ = context.Operators.Divide(24.0m, rzzzzzzzzx_);
                decimal? rzzzzzzzzz_ = context.Operators.Multiply(rzzzzzzzzw_, rzzzzzzzzy_);
                int? szzzzzzzza_ = context.Operators.Multiply(24, 365);
                decimal? szzzzzzzzb_ = context.Operators.ConvertIntegerToDecimal(szzzzzzzza_);
                decimal? szzzzzzzzc_ = context.Operators.Divide(rzzzzzzzzz_, szzzzzzzzb_);

                return szzzzzzzzc_;
            }
            else if (mzzzzzzzzu_())
            {
                decimal? szzzzzzzzd_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? szzzzzzzze_ = period?.value;
                decimal? szzzzzzzzf_ = context.Operators.Divide(24.0m, szzzzzzzze_);
                decimal? szzzzzzzzg_ = context.Operators.Multiply(szzzzzzzzd_, szzzzzzzzf_);

                return szzzzzzzzg_;
            }
            else if (mzzzzzzzzv_())
            {
                decimal? szzzzzzzzh_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? szzzzzzzzi_ = period?.value;
                decimal? szzzzzzzzj_ = context.Operators.Divide(24.0m, szzzzzzzzi_);
                decimal? szzzzzzzzk_ = context.Operators.Multiply(szzzzzzzzh_, szzzzzzzzj_);
                decimal? szzzzzzzzl_ = context.Operators.ConvertIntegerToDecimal(60);
                decimal? szzzzzzzzm_ = context.Operators.Multiply(szzzzzzzzk_, szzzzzzzzl_);

                return szzzzzzzzm_;
            }
            else if (mzzzzzzzzw_())
            {
                decimal? szzzzzzzzn_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? szzzzzzzzo_ = period?.value;
                decimal? szzzzzzzzp_ = context.Operators.Divide(24.0m, szzzzzzzzo_);
                decimal? szzzzzzzzq_ = context.Operators.Multiply(szzzzzzzzn_, szzzzzzzzp_);
                decimal? szzzzzzzzr_ = context.Operators.ConvertIntegerToDecimal(60);
                decimal? szzzzzzzzs_ = context.Operators.Multiply(szzzzzzzzq_, szzzzzzzzr_);
                decimal? szzzzzzzzu_ = context.Operators.Multiply(szzzzzzzzs_, szzzzzzzzr_);

                return szzzzzzzzu_;
            }
            else if (mzzzzzzzzx_())
            {
                decimal? szzzzzzzzv_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? szzzzzzzzw_ = period?.value;
                decimal? szzzzzzzzx_ = context.Operators.Divide(24.0m, szzzzzzzzw_);
                decimal? szzzzzzzzy_ = context.Operators.Multiply(szzzzzzzzv_, szzzzzzzzx_);
                decimal? szzzzzzzzz_ = context.Operators.ConvertIntegerToDecimal(24);
                decimal? tzzzzzzzza_ = context.Operators.Divide(szzzzzzzzy_, szzzzzzzzz_);

                return tzzzzzzzza_;
            }
            else if (mzzzzzzzzy_())
            {
                decimal? tzzzzzzzzb_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? tzzzzzzzzc_ = period?.value;
                decimal? tzzzzzzzzd_ = context.Operators.Divide(24.0m, tzzzzzzzzc_);
                decimal? tzzzzzzzze_ = context.Operators.Multiply(tzzzzzzzzb_, tzzzzzzzzd_);
                int? tzzzzzzzzf_ = context.Operators.Multiply(24, 7);
                decimal? tzzzzzzzzg_ = context.Operators.ConvertIntegerToDecimal(tzzzzzzzzf_);
                decimal? tzzzzzzzzh_ = context.Operators.Divide(tzzzzzzzze_, tzzzzzzzzg_);

                return tzzzzzzzzh_;
            }
            else if (mzzzzzzzzz_())
            {
                decimal? tzzzzzzzzi_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? tzzzzzzzzj_ = period?.value;
                decimal? tzzzzzzzzk_ = context.Operators.Divide(24.0m, tzzzzzzzzj_);
                decimal? tzzzzzzzzl_ = context.Operators.Multiply(tzzzzzzzzi_, tzzzzzzzzk_);
                int? tzzzzzzzzm_ = context.Operators.Multiply(24, 30);
                decimal? tzzzzzzzzn_ = context.Operators.ConvertIntegerToDecimal(tzzzzzzzzm_);
                decimal? tzzzzzzzzo_ = context.Operators.Divide(tzzzzzzzzl_, tzzzzzzzzn_);

                return tzzzzzzzzo_;
            }
            else if (nzzzzzzzza_())
            {
                decimal? tzzzzzzzzp_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? tzzzzzzzzq_ = period?.value;
                decimal? tzzzzzzzzr_ = context.Operators.Divide(24.0m, tzzzzzzzzq_);
                decimal? tzzzzzzzzs_ = context.Operators.Multiply(tzzzzzzzzp_, tzzzzzzzzr_);
                int? tzzzzzzzzt_ = context.Operators.Multiply(24, 365);
                decimal? tzzzzzzzzu_ = context.Operators.ConvertIntegerToDecimal(tzzzzzzzzt_);
                decimal? tzzzzzzzzv_ = context.Operators.Divide(tzzzzzzzzs_, tzzzzzzzzu_);

                return tzzzzzzzzv_;
            }
            else
            {
                string tzzzzzzzzw_ = this.ErrorLevel(context);
                string tzzzzzzzzx_ = period?.unit;
                string tzzzzzzzzy_ = context.Operators.Concatenate("Unknown unit ", tzzzzzzzzx_ ?? "");
                object tzzzzzzzzz_ = context.Operators.Message<object>(null, "CMDLogic.ToDaily.UnknownUnit", tzzzzzzzzw_, tzzzzzzzzy_);

                return tzzzzzzzzz_ as decimal?;
            }
        };

        return mzzzzzzzzf_();
    }


    [CqlExpressionDefinition("ToDaily")]
    public decimal? ToDaily(CqlContext context, CqlCode frequency)
    {
        decimal? uzzzzzzzza_()
        {
            bool uzzzzzzzzb_()
            {
                CqlCode vzzzzzzzzw_ = this.HS(context);
                bool? vzzzzzzzzx_ = context.Operators.Equivalent(frequency, vzzzzzzzzw_);

                return vzzzzzzzzx_ ?? false;
            };
            bool uzzzzzzzzc_()
            {
                CqlCode vzzzzzzzzy_ = this.WAKE(context);
                bool? vzzzzzzzzz_ = context.Operators.Equivalent(frequency, vzzzzzzzzy_);

                return vzzzzzzzzz_ ?? false;
            };
            bool uzzzzzzzzd_()
            {
                CqlCode wzzzzzzzza_ = this.C(context);
                bool? wzzzzzzzzb_ = context.Operators.Equivalent(frequency, wzzzzzzzza_);

                return wzzzzzzzzb_ ?? false;
            };
            bool uzzzzzzzze_()
            {
                CqlCode wzzzzzzzzc_ = this.CM(context);
                bool? wzzzzzzzzd_ = context.Operators.Equivalent(frequency, wzzzzzzzzc_);

                return wzzzzzzzzd_ ?? false;
            };
            bool uzzzzzzzzf_()
            {
                CqlCode wzzzzzzzze_ = this.CD(context);
                bool? wzzzzzzzzf_ = context.Operators.Equivalent(frequency, wzzzzzzzze_);

                return wzzzzzzzzf_ ?? false;
            };
            bool uzzzzzzzzg_()
            {
                CqlCode wzzzzzzzzg_ = this.CV(context);
                bool? wzzzzzzzzh_ = context.Operators.Equivalent(frequency, wzzzzzzzzg_);

                return wzzzzzzzzh_ ?? false;
            };
            bool uzzzzzzzzh_()
            {
                CqlCode wzzzzzzzzi_ = this.AC(context);
                bool? wzzzzzzzzj_ = context.Operators.Equivalent(frequency, wzzzzzzzzi_);

                return wzzzzzzzzj_ ?? false;
            };
            bool uzzzzzzzzi_()
            {
                CqlCode wzzzzzzzzk_ = this.ACM(context);
                bool? wzzzzzzzzl_ = context.Operators.Equivalent(frequency, wzzzzzzzzk_);

                return wzzzzzzzzl_ ?? false;
            };
            bool uzzzzzzzzj_()
            {
                CqlCode wzzzzzzzzm_ = this.ACD(context);
                bool? wzzzzzzzzn_ = context.Operators.Equivalent(frequency, wzzzzzzzzm_);

                return wzzzzzzzzn_ ?? false;
            };
            bool uzzzzzzzzk_()
            {
                CqlCode wzzzzzzzzo_ = this.ACV(context);
                bool? wzzzzzzzzp_ = context.Operators.Equivalent(frequency, wzzzzzzzzo_);

                return wzzzzzzzzp_ ?? false;
            };
            bool uzzzzzzzzl_()
            {
                CqlCode wzzzzzzzzq_ = this.PC(context);
                bool? wzzzzzzzzr_ = context.Operators.Equivalent(frequency, wzzzzzzzzq_);

                return wzzzzzzzzr_ ?? false;
            };
            bool uzzzzzzzzm_()
            {
                CqlCode wzzzzzzzzs_ = this.PCM(context);
                bool? wzzzzzzzzt_ = context.Operators.Equivalent(frequency, wzzzzzzzzs_);

                return wzzzzzzzzt_ ?? false;
            };
            bool uzzzzzzzzn_()
            {
                CqlCode wzzzzzzzzu_ = this.PCD(context);
                bool? wzzzzzzzzv_ = context.Operators.Equivalent(frequency, wzzzzzzzzu_);

                return wzzzzzzzzv_ ?? false;
            };
            bool uzzzzzzzzo_()
            {
                CqlCode wzzzzzzzzw_ = this.PCV(context);
                bool? wzzzzzzzzx_ = context.Operators.Equivalent(frequency, wzzzzzzzzw_);

                return wzzzzzzzzx_ ?? false;
            };
            bool uzzzzzzzzp_()
            {
                CqlCode wzzzzzzzzy_ = this.MORN(context);
                bool? wzzzzzzzzz_ = context.Operators.Equivalent(frequency, wzzzzzzzzy_);

                return wzzzzzzzzz_ ?? false;
            };
            bool uzzzzzzzzq_()
            {
                CqlCode xzzzzzzzza_ = this.MORN_early(context);
                bool? xzzzzzzzzb_ = context.Operators.Equivalent(frequency, xzzzzzzzza_);

                return xzzzzzzzzb_ ?? false;
            };
            bool uzzzzzzzzr_()
            {
                CqlCode xzzzzzzzzc_ = this.MORN_late(context);
                bool? xzzzzzzzzd_ = context.Operators.Equivalent(frequency, xzzzzzzzzc_);

                return xzzzzzzzzd_ ?? false;
            };
            bool uzzzzzzzzs_()
            {
                CqlCode xzzzzzzzze_ = this.NOON(context);
                bool? xzzzzzzzzf_ = context.Operators.Equivalent(frequency, xzzzzzzzze_);

                return xzzzzzzzzf_ ?? false;
            };
            bool uzzzzzzzzt_()
            {
                CqlCode xzzzzzzzzg_ = this.AFT(context);
                bool? xzzzzzzzzh_ = context.Operators.Equivalent(frequency, xzzzzzzzzg_);

                return xzzzzzzzzh_ ?? false;
            };
            bool uzzzzzzzzu_()
            {
                CqlCode xzzzzzzzzi_ = this.AFT_early(context);
                bool? xzzzzzzzzj_ = context.Operators.Equivalent(frequency, xzzzzzzzzi_);

                return xzzzzzzzzj_ ?? false;
            };
            bool uzzzzzzzzv_()
            {
                CqlCode xzzzzzzzzk_ = this.AFT_late(context);
                bool? xzzzzzzzzl_ = context.Operators.Equivalent(frequency, xzzzzzzzzk_);

                return xzzzzzzzzl_ ?? false;
            };
            bool uzzzzzzzzw_()
            {
                CqlCode xzzzzzzzzm_ = this.EVE(context);
                bool? xzzzzzzzzn_ = context.Operators.Equivalent(frequency, xzzzzzzzzm_);

                return xzzzzzzzzn_ ?? false;
            };
            bool uzzzzzzzzx_()
            {
                CqlCode xzzzzzzzzo_ = this.EVE_early(context);
                bool? xzzzzzzzzp_ = context.Operators.Equivalent(frequency, xzzzzzzzzo_);

                return xzzzzzzzzp_ ?? false;
            };
            bool uzzzzzzzzy_()
            {
                CqlCode xzzzzzzzzq_ = this.EVE_late(context);
                bool? xzzzzzzzzr_ = context.Operators.Equivalent(frequency, xzzzzzzzzq_);

                return xzzzzzzzzr_ ?? false;
            };
            bool uzzzzzzzzz_()
            {
                CqlCode xzzzzzzzzs_ = this.NIGHT(context);
                bool? xzzzzzzzzt_ = context.Operators.Equivalent(frequency, xzzzzzzzzs_);

                return xzzzzzzzzt_ ?? false;
            };
            bool vzzzzzzzza_()
            {
                CqlCode xzzzzzzzzu_ = this.PHS(context);
                bool? xzzzzzzzzv_ = context.Operators.Equivalent(frequency, xzzzzzzzzu_);

                return xzzzzzzzzv_ ?? false;
            };
            bool vzzzzzzzzb_()
            {
                CqlCode xzzzzzzzzw_ = this.Once_daily__qualifier_value_(context);
                bool? xzzzzzzzzx_ = context.Operators.Equivalent(frequency, xzzzzzzzzw_);

                return xzzzzzzzzx_ ?? false;
            };
            bool vzzzzzzzzc_()
            {
                CqlCode xzzzzzzzzy_ = this.Twice_a_day__qualifier_value_(context);
                bool? xzzzzzzzzz_ = context.Operators.Equivalent(frequency, xzzzzzzzzy_);

                return xzzzzzzzzz_ ?? false;
            };
            bool vzzzzzzzzd_()
            {
                CqlCode yzzzzzzzza_ = this.Three_times_daily__qualifier_value_(context);
                bool? yzzzzzzzzb_ = context.Operators.Equivalent(frequency, yzzzzzzzza_);

                return yzzzzzzzzb_ ?? false;
            };
            bool vzzzzzzzze_()
            {
                CqlCode yzzzzzzzzc_ = this.Four_times_daily__qualifier_value_(context);
                bool? yzzzzzzzzd_ = context.Operators.Equivalent(frequency, yzzzzzzzzc_);

                return yzzzzzzzzd_ ?? false;
            };
            bool vzzzzzzzzf_()
            {
                CqlCode yzzzzzzzze_ = this.Every_twenty_four_hours__qualifier_value_(context);
                bool? yzzzzzzzzf_ = context.Operators.Equivalent(frequency, yzzzzzzzze_);

                return yzzzzzzzzf_ ?? false;
            };
            bool vzzzzzzzzg_()
            {
                CqlCode yzzzzzzzzg_ = this.Every_twelve_hours__qualifier_value_(context);
                bool? yzzzzzzzzh_ = context.Operators.Equivalent(frequency, yzzzzzzzzg_);

                return yzzzzzzzzh_ ?? false;
            };
            bool vzzzzzzzzh_()
            {
                CqlCode yzzzzzzzzi_ = this.Every_thirty_six_hours__qualifier_value_(context);
                bool? yzzzzzzzzj_ = context.Operators.Equivalent(frequency, yzzzzzzzzi_);

                return yzzzzzzzzj_ ?? false;
            };
            bool vzzzzzzzzi_()
            {
                CqlCode yzzzzzzzzk_ = this.Every_eight_hours__qualifier_value_(context);
                bool? yzzzzzzzzl_ = context.Operators.Equivalent(frequency, yzzzzzzzzk_);

                return yzzzzzzzzl_ ?? false;
            };
            bool vzzzzzzzzj_()
            {
                CqlCode yzzzzzzzzm_ = this.Every_four_hours__qualifier_value_(context);
                bool? yzzzzzzzzn_ = context.Operators.Equivalent(frequency, yzzzzzzzzm_);

                return yzzzzzzzzn_ ?? false;
            };
            bool vzzzzzzzzk_()
            {
                CqlCode yzzzzzzzzo_ = this.Every_six_hours__qualifier_value_(context);
                bool? yzzzzzzzzp_ = context.Operators.Equivalent(frequency, yzzzzzzzzo_);

                return yzzzzzzzzp_ ?? false;
            };
            bool vzzzzzzzzl_()
            {
                CqlCode yzzzzzzzzq_ = this.Every_seventy_two_hours__qualifier_value_(context);
                bool? yzzzzzzzzr_ = context.Operators.Equivalent(frequency, yzzzzzzzzq_);

                return yzzzzzzzzr_ ?? false;
            };
            bool vzzzzzzzzm_()
            {
                CqlCode yzzzzzzzzs_ = this.Every_forty_eight_hours__qualifier_value_(context);
                bool? yzzzzzzzzt_ = context.Operators.Equivalent(frequency, yzzzzzzzzs_);

                return yzzzzzzzzt_ ?? false;
            };
            bool vzzzzzzzzn_()
            {
                CqlCode yzzzzzzzzu_ = this.Every_eight_to_twelve_hours__qualifier_value_(context);
                bool? yzzzzzzzzv_ = context.Operators.Equivalent(frequency, yzzzzzzzzu_);

                return yzzzzzzzzv_ ?? false;
            };
            bool vzzzzzzzzo_()
            {
                CqlCode yzzzzzzzzw_ = this.Every_six_to_eight_hours__qualifier_value_(context);
                bool? yzzzzzzzzx_ = context.Operators.Equivalent(frequency, yzzzzzzzzw_);

                return yzzzzzzzzx_ ?? false;
            };
            bool vzzzzzzzzp_()
            {
                CqlCode yzzzzzzzzy_ = this.Every_three_to_four_hours__qualifier_value_(context);
                bool? yzzzzzzzzz_ = context.Operators.Equivalent(frequency, yzzzzzzzzy_);

                return yzzzzzzzzz_ ?? false;
            };
            bool vzzzzzzzzq_()
            {
                CqlCode zzzzzzzzza_ = this.Every_three_to_six_hours__qualifier_value_(context);
                bool? zzzzzzzzzb_ = context.Operators.Equivalent(frequency, zzzzzzzzza_);

                return zzzzzzzzzb_ ?? false;
            };
            bool vzzzzzzzzr_()
            {
                CqlCode zzzzzzzzzc_ = this.Every_two_to_four_hours__qualifier_value_(context);
                bool? zzzzzzzzzd_ = context.Operators.Equivalent(frequency, zzzzzzzzzc_);

                return zzzzzzzzzd_ ?? false;
            };
            bool vzzzzzzzzs_()
            {
                CqlCode zzzzzzzzze_ = this.One_to_four_times_a_day__qualifier_value_(context);
                bool? zzzzzzzzzf_ = context.Operators.Equivalent(frequency, zzzzzzzzze_);

                return zzzzzzzzzf_ ?? false;
            };
            bool vzzzzzzzzt_()
            {
                CqlCode zzzzzzzzzg_ = this.One_to_three_times_a_day__qualifier_value_(context);
                bool? zzzzzzzzzh_ = context.Operators.Equivalent(frequency, zzzzzzzzzg_);

                return zzzzzzzzzh_ ?? false;
            };
            bool vzzzzzzzzu_()
            {
                CqlCode zzzzzzzzzi_ = this.One_to_two_times_a_day__qualifier_value_(context);
                bool? zzzzzzzzzj_ = context.Operators.Equivalent(frequency, zzzzzzzzzi_);

                return zzzzzzzzzj_ ?? false;
            };
            bool vzzzzzzzzv_()
            {
                CqlCode zzzzzzzzzk_ = this.Two_to_four_times_a_day__qualifier_value_(context);
                bool? zzzzzzzzzl_ = context.Operators.Equivalent(frequency, zzzzzzzzzk_);

                return zzzzzzzzzl_ ?? false;
            };
            if (uzzzzzzzzb_())
            {
                decimal? zzzzzzzzzm_ = context.Operators.ConvertIntegerToDecimal(1);

                return zzzzzzzzzm_;
            }
            else if (uzzzzzzzzc_())
            {
                decimal? zzzzzzzzzn_ = context.Operators.ConvertIntegerToDecimal(1);

                return zzzzzzzzzn_;
            }
            else if (uzzzzzzzzd_())
            {
                decimal? zzzzzzzzzo_ = context.Operators.ConvertIntegerToDecimal(3);

                return zzzzzzzzzo_;
            }
            else if (uzzzzzzzze_())
            {
                decimal? zzzzzzzzzp_ = context.Operators.ConvertIntegerToDecimal(1);

                return zzzzzzzzzp_;
            }
            else if (uzzzzzzzzf_())
            {
                decimal? zzzzzzzzzq_ = context.Operators.ConvertIntegerToDecimal(1);

                return zzzzzzzzzq_;
            }
            else if (uzzzzzzzzg_())
            {
                decimal? zzzzzzzzzr_ = context.Operators.ConvertIntegerToDecimal(1);

                return zzzzzzzzzr_;
            }
            else if (uzzzzzzzzh_())
            {
                decimal? zzzzzzzzzs_ = context.Operators.ConvertIntegerToDecimal(3);

                return zzzzzzzzzs_;
            }
            else if (uzzzzzzzzi_())
            {
                decimal? zzzzzzzzzt_ = context.Operators.ConvertIntegerToDecimal(1);

                return zzzzzzzzzt_;
            }
            else if (uzzzzzzzzj_())
            {
                decimal? zzzzzzzzzu_ = context.Operators.ConvertIntegerToDecimal(1);

                return zzzzzzzzzu_;
            }
            else if (uzzzzzzzzk_())
            {
                decimal? zzzzzzzzzv_ = context.Operators.ConvertIntegerToDecimal(1);

                return zzzzzzzzzv_;
            }
            else if (uzzzzzzzzl_())
            {
                decimal? zzzzzzzzzw_ = context.Operators.ConvertIntegerToDecimal(3);

                return zzzzzzzzzw_;
            }
            else if (uzzzzzzzzm_())
            {
                decimal? zzzzzzzzzx_ = context.Operators.ConvertIntegerToDecimal(1);

                return zzzzzzzzzx_;
            }
            else if (uzzzzzzzzn_())
            {
                decimal? zzzzzzzzzy_ = context.Operators.ConvertIntegerToDecimal(1);

                return zzzzzzzzzy_;
            }
            else if (uzzzzzzzzo_())
            {
                decimal? zzzzzzzzzz_ = context.Operators.ConvertIntegerToDecimal(1);

                return zzzzzzzzzz_;
            }
            else if (uzzzzzzzzp_())
            {
                decimal? azzzzzzzzza_ = context.Operators.ConvertIntegerToDecimal(1);

                return azzzzzzzzza_;
            }
            else if (uzzzzzzzzq_())
            {
                decimal? azzzzzzzzzb_ = context.Operators.ConvertIntegerToDecimal(1);

                return azzzzzzzzzb_;
            }
            else if (uzzzzzzzzr_())
            {
                decimal? azzzzzzzzzc_ = context.Operators.ConvertIntegerToDecimal(1);

                return azzzzzzzzzc_;
            }
            else if (uzzzzzzzzs_())
            {
                decimal? azzzzzzzzzd_ = context.Operators.ConvertIntegerToDecimal(1);

                return azzzzzzzzzd_;
            }
            else if (uzzzzzzzzt_())
            {
                decimal? azzzzzzzzze_ = context.Operators.ConvertIntegerToDecimal(1);

                return azzzzzzzzze_;
            }
            else if (uzzzzzzzzu_())
            {
                decimal? azzzzzzzzzf_ = context.Operators.ConvertIntegerToDecimal(1);

                return azzzzzzzzzf_;
            }
            else if (uzzzzzzzzv_())
            {
                decimal? azzzzzzzzzg_ = context.Operators.ConvertIntegerToDecimal(1);

                return azzzzzzzzzg_;
            }
            else if (uzzzzzzzzw_())
            {
                decimal? azzzzzzzzzh_ = context.Operators.ConvertIntegerToDecimal(1);

                return azzzzzzzzzh_;
            }
            else if (uzzzzzzzzx_())
            {
                decimal? azzzzzzzzzi_ = context.Operators.ConvertIntegerToDecimal(1);

                return azzzzzzzzzi_;
            }
            else if (uzzzzzzzzy_())
            {
                decimal? azzzzzzzzzj_ = context.Operators.ConvertIntegerToDecimal(1);

                return azzzzzzzzzj_;
            }
            else if (uzzzzzzzzz_())
            {
                decimal? azzzzzzzzzk_ = context.Operators.ConvertIntegerToDecimal(1);

                return azzzzzzzzzk_;
            }
            else if (vzzzzzzzza_())
            {
                decimal? azzzzzzzzzl_ = context.Operators.ConvertIntegerToDecimal(1);

                return azzzzzzzzzl_;
            }
            else if (vzzzzzzzzb_())
            {
                return 1.0m;
            }
            else if (vzzzzzzzzc_())
            {
                return 2.0m;
            }
            else if (vzzzzzzzzd_())
            {
                return 3.0m;
            }
            else if (vzzzzzzzze_())
            {
                return 4.0m;
            }
            else if (vzzzzzzzzf_())
            {
                return 1.0m;
            }
            else if (vzzzzzzzzg_())
            {
                return 2.0m;
            }
            else if (vzzzzzzzzh_())
            {
                return 0.67m;
            }
            else if (vzzzzzzzzi_())
            {
                return 3.0m;
            }
            else if (vzzzzzzzzj_())
            {
                return 6.0m;
            }
            else if (vzzzzzzzzk_())
            {
                return 4.0m;
            }
            else if (vzzzzzzzzl_())
            {
                return 0.33m;
            }
            else if (vzzzzzzzzm_())
            {
                return 0.5m;
            }
            else if (vzzzzzzzzn_())
            {
                return 3.0m;
            }
            else if (vzzzzzzzzo_())
            {
                return 4.0m;
            }
            else if (vzzzzzzzzp_())
            {
                return 8.0m;
            }
            else if (vzzzzzzzzq_())
            {
                return 8.0m;
            }
            else if (vzzzzzzzzr_())
            {
                return 12.0m;
            }
            else if (vzzzzzzzzs_())
            {
                return 4.0m;
            }
            else if (vzzzzzzzzt_())
            {
                return 3.0m;
            }
            else if (vzzzzzzzzu_())
            {
                return 2.0m;
            }
            else if (vzzzzzzzzv_())
            {
                return 4.0m;
            }
            else
            {
                string azzzzzzzzzm_ = this.ErrorLevel(context);
                string azzzzzzzzzn_ = frequency?.code;
                string azzzzzzzzzo_ = context.Operators.Concatenate("Unknown frequency code ", azzzzzzzzzn_ ?? "");
                object azzzzzzzzzp_ = context.Operators.Message<object>(null, "CMDLogic.ToDaily.UnknownFrequencyCode", azzzzzzzzzm_, azzzzzzzzzo_);

                return azzzzzzzzzp_ as decimal?;
            }
        };

        return uzzzzzzzza_();
    }


    [CqlExpressionDefinition("Quantity")]
    public CqlQuantity Quantity(CqlContext context, decimal? value, string unit) =>
        ((context.Operators.Not((bool?)(value is null))) ?? false
            ? new CqlQuantity(value, unit)
            : default);


    [CqlExpressionDefinition("MedicationRequestPeriod")]
    public CqlInterval<CqlDate> MedicationRequestPeriod(CqlContext context, MedicationRequest Request)
    {
        MedicationRequest[] azzzzzzzzzq_ = [
            Request,
        ];
        CqlInterval<CqlDate> azzzzzzzzzr_(MedicationRequest R)
        {
            CqlInterval<CqlDate> azzzzzzzzzv_()
            {
                bool azzzzzzzzzw_()
                {
                    List<Dosage> azzzzzzzzzy_ = R?.DosageInstruction;
                    Dosage azzzzzzzzzz_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)azzzzzzzzzy_);
                    Timing bzzzzzzzzza_ = azzzzzzzzzz_?.Timing;
                    Timing.RepeatComponent bzzzzzzzzzb_ = bzzzzzzzzza_?.Repeat;
                    DataType bzzzzzzzzzc_ = bzzzzzzzzzb_?.Bounds;
                    object bzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzc_);
                    CqlDateTime bzzzzzzzzze_ = context.Operators.Start(bzzzzzzzzzd_ as CqlInterval<CqlDateTime>);
                    CqlDate bzzzzzzzzzf_ = context.Operators.DateFrom(bzzzzzzzzze_);
                    FhirDateTime bzzzzzzzzzg_ = R?.AuthoredOnElement;
                    CqlDateTime bzzzzzzzzzh_ = context.Operators.Convert<CqlDateTime>(bzzzzzzzzzg_);
                    CqlDate bzzzzzzzzzi_ = context.Operators.DateFrom(bzzzzzzzzzh_);
                    MedicationRequest.DispenseRequestComponent bzzzzzzzzzj_ = R?.DispenseRequest;
                    Period bzzzzzzzzzk_ = bzzzzzzzzzj_?.ValidityPeriod;
                    CqlInterval<CqlDateTime> bzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzzzk_);
                    CqlDateTime bzzzzzzzzzm_ = context.Operators.Start(bzzzzzzzzzl_);
                    CqlDate bzzzzzzzzzn_ = context.Operators.DateFrom(bzzzzzzzzzm_);
                    bool? bzzzzzzzzzo_ = context.Operators.Not((bool?)(((bzzzzzzzzzf_ ?? bzzzzzzzzzi_) ?? bzzzzzzzzzn_) is null));
                    Duration bzzzzzzzzzq_ = bzzzzzzzzzj_?.ExpectedSupplyDuration;
                    CqlQuantity bzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, bzzzzzzzzzq_);
                    CqlQuantity bzzzzzzzzzs_ = context.Operators.ConvertQuantity(bzzzzzzzzzr_, "d");
                    decimal? bzzzzzzzzzt_ = bzzzzzzzzzs_?.value;
                    Quantity bzzzzzzzzzv_ = bzzzzzzzzzj_?.Quantity;
                    CqlQuantity bzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, bzzzzzzzzzv_);
                    decimal? bzzzzzzzzzx_ = bzzzzzzzzzw_?.value;
                    Dosage bzzzzzzzzzz_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)azzzzzzzzzy_);
                    List<Dosage.DoseAndRateComponent> czzzzzzzzza_ = bzzzzzzzzzz_?.DoseAndRate;
                    Dosage.DoseAndRateComponent czzzzzzzzzb_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)czzzzzzzzza_);
                    DataType czzzzzzzzzc_ = czzzzzzzzzb_?.Dose;
                    object czzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzc_);
                    CqlQuantity czzzzzzzzze_ = context.Operators.End(czzzzzzzzzd_ as CqlInterval<CqlQuantity>);
                    Dosage czzzzzzzzzg_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)azzzzzzzzzy_);
                    List<Dosage.DoseAndRateComponent> czzzzzzzzzh_ = czzzzzzzzzg_?.DoseAndRate;
                    Dosage.DoseAndRateComponent czzzzzzzzzi_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)czzzzzzzzzh_);
                    DataType czzzzzzzzzj_ = czzzzzzzzzi_?.Dose;
                    object czzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzj_);
                    decimal? czzzzzzzzzl_ = (czzzzzzzzze_ ?? czzzzzzzzzk_ as CqlQuantity)?.value;
                    Dosage czzzzzzzzzn_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)azzzzzzzzzy_);
                    Timing czzzzzzzzzo_ = czzzzzzzzzn_?.Timing;
                    Timing.RepeatComponent czzzzzzzzzp_ = czzzzzzzzzo_?.Repeat;
                    PositiveInt czzzzzzzzzq_ = czzzzzzzzzp_?.FrequencyMaxElement;
                    int? czzzzzzzzzr_ = czzzzzzzzzq_?.Value;
                    Dosage czzzzzzzzzt_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)azzzzzzzzzy_);
                    Timing czzzzzzzzzu_ = czzzzzzzzzt_?.Timing;
                    Timing.RepeatComponent czzzzzzzzzv_ = czzzzzzzzzu_?.Repeat;
                    PositiveInt czzzzzzzzzw_ = czzzzzzzzzv_?.FrequencyElement;
                    int? czzzzzzzzzx_ = czzzzzzzzzw_?.Value;
                    Dosage czzzzzzzzzz_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)azzzzzzzzzy_);
                    Timing dzzzzzzzzza_ = czzzzzzzzzz_?.Timing;
                    Timing.RepeatComponent dzzzzzzzzzb_ = dzzzzzzzzza_?.Repeat;
                    FhirDecimal dzzzzzzzzzc_ = dzzzzzzzzzb_?.PeriodElement;
                    decimal? dzzzzzzzzzd_ = dzzzzzzzzzc_?.Value;
                    Dosage dzzzzzzzzzf_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)azzzzzzzzzy_);
                    Timing dzzzzzzzzzg_ = dzzzzzzzzzf_?.Timing;
                    Timing.RepeatComponent dzzzzzzzzzh_ = dzzzzzzzzzg_?.Repeat;
                    Code<Timing.UnitsOfTime> dzzzzzzzzzi_ = dzzzzzzzzzh_?.PeriodUnitElement;
                    Timing.UnitsOfTime? dzzzzzzzzzj_ = dzzzzzzzzzi_?.Value;
                    string dzzzzzzzzzk_ = context.Operators.Convert<string>(dzzzzzzzzzj_);
                    CqlQuantity dzzzzzzzzzl_ = this.Quantity(context, dzzzzzzzzzd_, dzzzzzzzzzk_);
                    decimal? dzzzzzzzzzm_ = this.ToDaily(context, czzzzzzzzzr_ ?? czzzzzzzzzx_, dzzzzzzzzzl_);
                    Dosage dzzzzzzzzzo_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)azzzzzzzzzy_);
                    Timing dzzzzzzzzzp_ = dzzzzzzzzzo_?.Timing;
                    Timing.RepeatComponent dzzzzzzzzzq_ = dzzzzzzzzzp_?.Repeat;
                    List<Time> dzzzzzzzzzr_ = dzzzzzzzzzq_?.TimeOfDayElement;
                    IEnumerable<CqlTime> dzzzzzzzzzs_ = context.Operators.LateBoundProperty<IEnumerable<CqlTime>>(dzzzzzzzzzr_, "value");
                    int? dzzzzzzzzzt_ = context.Operators.Count<CqlTime>(dzzzzzzzzzs_);
                    decimal? dzzzzzzzzzu_ = context.Operators.ConvertIntegerToDecimal(dzzzzzzzzzt_);
                    decimal? dzzzzzzzzzv_ = context.Operators.Multiply(czzzzzzzzzl_, (dzzzzzzzzzm_ ?? dzzzzzzzzzu_) ?? 1.0m);
                    decimal? dzzzzzzzzzw_ = context.Operators.Divide(bzzzzzzzzzx_, dzzzzzzzzzv_);
                    UnsignedInt dzzzzzzzzzy_ = bzzzzzzzzzj_?.NumberOfRepeatsAllowedElement;
                    int? dzzzzzzzzzz_ = dzzzzzzzzzy_?.Value;
                    int? ezzzzzzzzza_ = context.Operators.Add(1, dzzzzzzzzzz_ ?? 0);
                    decimal? ezzzzzzzzzb_ = context.Operators.ConvertIntegerToDecimal(ezzzzzzzzza_);
                    decimal? ezzzzzzzzzc_ = context.Operators.Multiply(bzzzzzzzzzt_ ?? dzzzzzzzzzw_, ezzzzzzzzzb_);
                    bool? ezzzzzzzzzd_ = context.Operators.Not((bool?)(ezzzzzzzzzc_ is null));
                    bool? ezzzzzzzzze_ = context.Operators.And(bzzzzzzzzzo_, ezzzzzzzzzd_);

                    return ezzzzzzzzze_ ?? false;
                };
                bool azzzzzzzzzx_()
                {
                    List<Dosage> ezzzzzzzzzf_ = R?.DosageInstruction;
                    Dosage ezzzzzzzzzg_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)ezzzzzzzzzf_);
                    Timing ezzzzzzzzzh_ = ezzzzzzzzzg_?.Timing;
                    Timing.RepeatComponent ezzzzzzzzzi_ = ezzzzzzzzzh_?.Repeat;
                    DataType ezzzzzzzzzj_ = ezzzzzzzzzi_?.Bounds;
                    object ezzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzj_);
                    CqlDateTime ezzzzzzzzzl_ = context.Operators.Start(ezzzzzzzzzk_ as CqlInterval<CqlDateTime>);
                    CqlDate ezzzzzzzzzm_ = context.Operators.DateFrom(ezzzzzzzzzl_);
                    FhirDateTime ezzzzzzzzzn_ = R?.AuthoredOnElement;
                    CqlDateTime ezzzzzzzzzo_ = context.Operators.Convert<CqlDateTime>(ezzzzzzzzzn_);
                    CqlDate ezzzzzzzzzp_ = context.Operators.DateFrom(ezzzzzzzzzo_);
                    MedicationRequest.DispenseRequestComponent ezzzzzzzzzq_ = R?.DispenseRequest;
                    Period ezzzzzzzzzr_ = ezzzzzzzzzq_?.ValidityPeriod;
                    CqlInterval<CqlDateTime> ezzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzzzzzr_);
                    CqlDateTime ezzzzzzzzzt_ = context.Operators.Start(ezzzzzzzzzs_);
                    CqlDate ezzzzzzzzzu_ = context.Operators.DateFrom(ezzzzzzzzzt_);
                    bool? ezzzzzzzzzv_ = context.Operators.Not((bool?)(((ezzzzzzzzzm_ ?? ezzzzzzzzzp_) ?? ezzzzzzzzzu_) is null));
                    Dosage ezzzzzzzzzx_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)ezzzzzzzzzf_);
                    Timing ezzzzzzzzzy_ = ezzzzzzzzzx_?.Timing;
                    Timing.RepeatComponent ezzzzzzzzzz_ = ezzzzzzzzzy_?.Repeat;
                    DataType fzzzzzzzzza_ = ezzzzzzzzzz_?.Bounds;
                    object fzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzza_);
                    CqlDateTime fzzzzzzzzzc_ = (fzzzzzzzzzb_ as CqlInterval<CqlDateTime>)?.high;
                    bool? fzzzzzzzzzd_ = context.Operators.Not((bool?)(fzzzzzzzzzc_ is null));
                    bool? fzzzzzzzzze_ = context.Operators.And(ezzzzzzzzzv_, fzzzzzzzzzd_);

                    return fzzzzzzzzze_ ?? false;
                };
                if (azzzzzzzzzw_())
                {
                    List<Dosage> fzzzzzzzzzf_ = R?.DosageInstruction;
                    Dosage fzzzzzzzzzg_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)fzzzzzzzzzf_);
                    Timing fzzzzzzzzzh_ = fzzzzzzzzzg_?.Timing;
                    Timing.RepeatComponent fzzzzzzzzzi_ = fzzzzzzzzzh_?.Repeat;
                    DataType fzzzzzzzzzj_ = fzzzzzzzzzi_?.Bounds;
                    object fzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzj_);
                    CqlDateTime fzzzzzzzzzl_ = context.Operators.Start(fzzzzzzzzzk_ as CqlInterval<CqlDateTime>);
                    CqlDate fzzzzzzzzzm_ = context.Operators.DateFrom(fzzzzzzzzzl_);
                    FhirDateTime fzzzzzzzzzn_ = R?.AuthoredOnElement;
                    CqlDateTime fzzzzzzzzzo_ = context.Operators.Convert<CqlDateTime>(fzzzzzzzzzn_);
                    CqlDate fzzzzzzzzzp_ = context.Operators.DateFrom(fzzzzzzzzzo_);
                    MedicationRequest.DispenseRequestComponent fzzzzzzzzzq_ = R?.DispenseRequest;
                    Period fzzzzzzzzzr_ = fzzzzzzzzzq_?.ValidityPeriod;
                    CqlInterval<CqlDateTime> fzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzzzzzr_);
                    CqlDateTime fzzzzzzzzzt_ = context.Operators.Start(fzzzzzzzzzs_);
                    CqlDate fzzzzzzzzzu_ = context.Operators.DateFrom(fzzzzzzzzzt_);
                    Dosage fzzzzzzzzzw_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)fzzzzzzzzzf_);
                    Timing fzzzzzzzzzx_ = fzzzzzzzzzw_?.Timing;
                    Timing.RepeatComponent fzzzzzzzzzy_ = fzzzzzzzzzx_?.Repeat;
                    DataType fzzzzzzzzzz_ = fzzzzzzzzzy_?.Bounds;
                    object gzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzz_);
                    CqlDateTime gzzzzzzzzzb_ = context.Operators.Start(gzzzzzzzzza_ as CqlInterval<CqlDateTime>);
                    CqlDate gzzzzzzzzzc_ = context.Operators.DateFrom(gzzzzzzzzzb_);
                    CqlDateTime gzzzzzzzzze_ = context.Operators.Convert<CqlDateTime>(fzzzzzzzzzn_);
                    CqlDate gzzzzzzzzzf_ = context.Operators.DateFrom(gzzzzzzzzze_);
                    Period gzzzzzzzzzh_ = fzzzzzzzzzq_?.ValidityPeriod;
                    CqlInterval<CqlDateTime> gzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzzzzh_);
                    CqlDateTime gzzzzzzzzzj_ = context.Operators.Start(gzzzzzzzzzi_);
                    CqlDate gzzzzzzzzzk_ = context.Operators.DateFrom(gzzzzzzzzzj_);
                    Duration gzzzzzzzzzm_ = fzzzzzzzzzq_?.ExpectedSupplyDuration;
                    CqlQuantity gzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, gzzzzzzzzzm_);
                    CqlQuantity gzzzzzzzzzo_ = context.Operators.ConvertQuantity(gzzzzzzzzzn_, "d");
                    decimal? gzzzzzzzzzp_ = gzzzzzzzzzo_?.value;
                    Quantity gzzzzzzzzzr_ = fzzzzzzzzzq_?.Quantity;
                    CqlQuantity gzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, gzzzzzzzzzr_);
                    decimal? gzzzzzzzzzt_ = gzzzzzzzzzs_?.value;
                    Dosage gzzzzzzzzzv_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)fzzzzzzzzzf_);
                    List<Dosage.DoseAndRateComponent> gzzzzzzzzzw_ = gzzzzzzzzzv_?.DoseAndRate;
                    Dosage.DoseAndRateComponent gzzzzzzzzzx_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)gzzzzzzzzzw_);
                    DataType gzzzzzzzzzy_ = gzzzzzzzzzx_?.Dose;
                    object gzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzy_);
                    CqlQuantity hzzzzzzzzza_ = context.Operators.End(gzzzzzzzzzz_ as CqlInterval<CqlQuantity>);
                    Dosage hzzzzzzzzzc_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)fzzzzzzzzzf_);
                    List<Dosage.DoseAndRateComponent> hzzzzzzzzzd_ = hzzzzzzzzzc_?.DoseAndRate;
                    Dosage.DoseAndRateComponent hzzzzzzzzze_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)hzzzzzzzzzd_);
                    DataType hzzzzzzzzzf_ = hzzzzzzzzze_?.Dose;
                    object hzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzf_);
                    decimal? hzzzzzzzzzh_ = (hzzzzzzzzza_ ?? hzzzzzzzzzg_ as CqlQuantity)?.value;
                    Dosage hzzzzzzzzzj_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)fzzzzzzzzzf_);
                    Timing hzzzzzzzzzk_ = hzzzzzzzzzj_?.Timing;
                    Timing.RepeatComponent hzzzzzzzzzl_ = hzzzzzzzzzk_?.Repeat;
                    PositiveInt hzzzzzzzzzm_ = hzzzzzzzzzl_?.FrequencyMaxElement;
                    int? hzzzzzzzzzn_ = hzzzzzzzzzm_?.Value;
                    Dosage hzzzzzzzzzp_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)fzzzzzzzzzf_);
                    Timing hzzzzzzzzzq_ = hzzzzzzzzzp_?.Timing;
                    Timing.RepeatComponent hzzzzzzzzzr_ = hzzzzzzzzzq_?.Repeat;
                    PositiveInt hzzzzzzzzzs_ = hzzzzzzzzzr_?.FrequencyElement;
                    int? hzzzzzzzzzt_ = hzzzzzzzzzs_?.Value;
                    Dosage hzzzzzzzzzv_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)fzzzzzzzzzf_);
                    Timing hzzzzzzzzzw_ = hzzzzzzzzzv_?.Timing;
                    Timing.RepeatComponent hzzzzzzzzzx_ = hzzzzzzzzzw_?.Repeat;
                    FhirDecimal hzzzzzzzzzy_ = hzzzzzzzzzx_?.PeriodElement;
                    decimal? hzzzzzzzzzz_ = hzzzzzzzzzy_?.Value;
                    Dosage izzzzzzzzzb_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)fzzzzzzzzzf_);
                    Timing izzzzzzzzzc_ = izzzzzzzzzb_?.Timing;
                    Timing.RepeatComponent izzzzzzzzzd_ = izzzzzzzzzc_?.Repeat;
                    Code<Timing.UnitsOfTime> izzzzzzzzze_ = izzzzzzzzzd_?.PeriodUnitElement;
                    Timing.UnitsOfTime? izzzzzzzzzf_ = izzzzzzzzze_?.Value;
                    string izzzzzzzzzg_ = context.Operators.Convert<string>(izzzzzzzzzf_);
                    CqlQuantity izzzzzzzzzh_ = this.Quantity(context, hzzzzzzzzzz_, izzzzzzzzzg_);
                    decimal? izzzzzzzzzi_ = this.ToDaily(context, hzzzzzzzzzn_ ?? hzzzzzzzzzt_, izzzzzzzzzh_);
                    Dosage izzzzzzzzzk_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)fzzzzzzzzzf_);
                    Timing izzzzzzzzzl_ = izzzzzzzzzk_?.Timing;
                    Timing.RepeatComponent izzzzzzzzzm_ = izzzzzzzzzl_?.Repeat;
                    List<Time> izzzzzzzzzn_ = izzzzzzzzzm_?.TimeOfDayElement;
                    IEnumerable<CqlTime> izzzzzzzzzo_ = context.Operators.LateBoundProperty<IEnumerable<CqlTime>>(izzzzzzzzzn_, "value");
                    int? izzzzzzzzzp_ = context.Operators.Count<CqlTime>(izzzzzzzzzo_);
                    decimal? izzzzzzzzzq_ = context.Operators.ConvertIntegerToDecimal(izzzzzzzzzp_);
                    decimal? izzzzzzzzzr_ = context.Operators.Multiply(hzzzzzzzzzh_, (izzzzzzzzzi_ ?? izzzzzzzzzq_) ?? 1.0m);
                    decimal? izzzzzzzzzs_ = context.Operators.Divide(gzzzzzzzzzt_, izzzzzzzzzr_);
                    UnsignedInt izzzzzzzzzu_ = fzzzzzzzzzq_?.NumberOfRepeatsAllowedElement;
                    int? izzzzzzzzzv_ = izzzzzzzzzu_?.Value;
                    int? izzzzzzzzzw_ = context.Operators.Add(1, izzzzzzzzzv_ ?? 0);
                    decimal? izzzzzzzzzx_ = context.Operators.ConvertIntegerToDecimal(izzzzzzzzzw_);
                    decimal? izzzzzzzzzy_ = context.Operators.Multiply(gzzzzzzzzzp_ ?? izzzzzzzzzs_, izzzzzzzzzx_);
                    decimal? izzzzzzzzzz_ = context.Operators.ConvertIntegerToDecimal(1);
                    decimal? jzzzzzzzzza_ = context.Operators.Subtract(izzzzzzzzzy_, izzzzzzzzzz_);
                    CqlQuantity jzzzzzzzzzb_ = this.Quantity(context, jzzzzzzzzza_, "day");
                    CqlDate jzzzzzzzzzc_ = context.Operators.Add((gzzzzzzzzzc_ ?? gzzzzzzzzzf_) ?? gzzzzzzzzzk_, jzzzzzzzzzb_);
                    CqlInterval<CqlDate> jzzzzzzzzzd_ = context.Operators.Interval((fzzzzzzzzzm_ ?? fzzzzzzzzzp_) ?? fzzzzzzzzzu_, jzzzzzzzzzc_, true, true);

                    return jzzzzzzzzzd_;
                }
                else if (azzzzzzzzzx_())
                {
                    List<Dosage> jzzzzzzzzze_ = R?.DosageInstruction;
                    Dosage jzzzzzzzzzf_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)jzzzzzzzzze_);
                    Timing jzzzzzzzzzg_ = jzzzzzzzzzf_?.Timing;
                    Timing.RepeatComponent jzzzzzzzzzh_ = jzzzzzzzzzg_?.Repeat;
                    DataType jzzzzzzzzzi_ = jzzzzzzzzzh_?.Bounds;
                    object jzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzi_);
                    CqlDateTime jzzzzzzzzzk_ = context.Operators.Start(jzzzzzzzzzj_ as CqlInterval<CqlDateTime>);
                    CqlDate jzzzzzzzzzl_ = context.Operators.DateFrom(jzzzzzzzzzk_);
                    FhirDateTime jzzzzzzzzzm_ = R?.AuthoredOnElement;
                    CqlDateTime jzzzzzzzzzn_ = context.Operators.Convert<CqlDateTime>(jzzzzzzzzzm_);
                    CqlDate jzzzzzzzzzo_ = context.Operators.DateFrom(jzzzzzzzzzn_);
                    MedicationRequest.DispenseRequestComponent jzzzzzzzzzp_ = R?.DispenseRequest;
                    Period jzzzzzzzzzq_ = jzzzzzzzzzp_?.ValidityPeriod;
                    CqlInterval<CqlDateTime> jzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzzzzq_);
                    CqlDateTime jzzzzzzzzzs_ = context.Operators.Start(jzzzzzzzzzr_);
                    CqlDate jzzzzzzzzzt_ = context.Operators.DateFrom(jzzzzzzzzzs_);
                    Dosage jzzzzzzzzzv_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)jzzzzzzzzze_);
                    Timing jzzzzzzzzzw_ = jzzzzzzzzzv_?.Timing;
                    Timing.RepeatComponent jzzzzzzzzzx_ = jzzzzzzzzzw_?.Repeat;
                    DataType jzzzzzzzzzy_ = jzzzzzzzzzx_?.Bounds;
                    object jzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzy_);
                    CqlDateTime kzzzzzzzzza_ = context.Operators.End(jzzzzzzzzzz_ as CqlInterval<CqlDateTime>);
                    CqlDate kzzzzzzzzzb_ = context.Operators.DateFrom(kzzzzzzzzza_);
                    CqlInterval<CqlDate> kzzzzzzzzzc_ = context.Operators.Interval((jzzzzzzzzzl_ ?? jzzzzzzzzzo_) ?? jzzzzzzzzzt_, kzzzzzzzzzb_, true, true);

                    return kzzzzzzzzzc_;
                }
                else
                {
                    return null as CqlInterval<CqlDate>;
                }
            };

            return azzzzzzzzzv_();
        };
        IEnumerable<CqlInterval<CqlDate>> azzzzzzzzzs_ = context.Operators.Select<MedicationRequest, CqlInterval<CqlDate>>((IEnumerable<MedicationRequest>)azzzzzzzzzq_, azzzzzzzzzr_);
        IEnumerable<CqlInterval<CqlDate>> azzzzzzzzzt_ = context.Operators.Distinct<CqlInterval<CqlDate>>(azzzzzzzzzs_);
        CqlInterval<CqlDate> azzzzzzzzzu_ = context.Operators.SingletonFrom<CqlInterval<CqlDate>>(azzzzzzzzzt_);

        return azzzzzzzzzu_;
    }


    [CqlExpressionDefinition("medicationRequestPeriod")]
    public CqlInterval<CqlDate> medicationRequestPeriod(CqlContext context, MedicationRequest Request)
    {
        MedicationRequest[] kzzzzzzzzzd_ = [
            Request,
        ];
        CqlInterval<CqlDate> kzzzzzzzzze_(MedicationRequest R)
        {
            CqlInterval<CqlDate> kzzzzzzzzzi_()
            {
                bool kzzzzzzzzzj_()
                {
                    List<Dosage> kzzzzzzzzzl_ = R?.DosageInstruction;
                    Dosage kzzzzzzzzzm_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)kzzzzzzzzzl_);
                    Timing kzzzzzzzzzn_ = kzzzzzzzzzm_?.Timing;
                    Timing.RepeatComponent kzzzzzzzzzo_ = kzzzzzzzzzn_?.Repeat;
                    DataType kzzzzzzzzzp_ = kzzzzzzzzzo_?.Bounds;
                    object kzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzp_);
                    CqlDateTime kzzzzzzzzzr_ = context.Operators.Start(kzzzzzzzzzq_ as CqlInterval<CqlDateTime>);
                    CqlDate kzzzzzzzzzs_ = context.Operators.DateFrom(kzzzzzzzzzr_);
                    FhirDateTime kzzzzzzzzzt_ = R?.AuthoredOnElement;
                    CqlDateTime kzzzzzzzzzu_ = context.Operators.Convert<CqlDateTime>(kzzzzzzzzzt_);
                    CqlDate kzzzzzzzzzv_ = context.Operators.DateFrom(kzzzzzzzzzu_);
                    MedicationRequest.DispenseRequestComponent kzzzzzzzzzw_ = R?.DispenseRequest;
                    Period kzzzzzzzzzx_ = kzzzzzzzzzw_?.ValidityPeriod;
                    CqlInterval<CqlDateTime> kzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzzzzzx_);
                    CqlDateTime kzzzzzzzzzz_ = context.Operators.Start(kzzzzzzzzzy_);
                    CqlDate lzzzzzzzzza_ = context.Operators.DateFrom(kzzzzzzzzzz_);
                    bool? lzzzzzzzzzb_ = context.Operators.Not((bool?)(((kzzzzzzzzzs_ ?? kzzzzzzzzzv_) ?? lzzzzzzzzza_) is null));
                    Duration lzzzzzzzzzd_ = kzzzzzzzzzw_?.ExpectedSupplyDuration;
                    CqlQuantity lzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, lzzzzzzzzzd_);
                    CqlQuantity lzzzzzzzzzf_ = context.Operators.ConvertQuantity(lzzzzzzzzze_, "d");
                    decimal? lzzzzzzzzzg_ = lzzzzzzzzzf_?.value;
                    Quantity lzzzzzzzzzi_ = kzzzzzzzzzw_?.Quantity;
                    CqlQuantity lzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, lzzzzzzzzzi_);
                    decimal? lzzzzzzzzzk_ = lzzzzzzzzzj_?.value;
                    Dosage lzzzzzzzzzm_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)kzzzzzzzzzl_);
                    List<Dosage.DoseAndRateComponent> lzzzzzzzzzn_ = lzzzzzzzzzm_?.DoseAndRate;
                    Dosage.DoseAndRateComponent lzzzzzzzzzo_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)lzzzzzzzzzn_);
                    DataType lzzzzzzzzzp_ = lzzzzzzzzzo_?.Dose;
                    object lzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzp_);
                    CqlQuantity lzzzzzzzzzr_ = context.Operators.End(lzzzzzzzzzq_ as CqlInterval<CqlQuantity>);
                    Dosage lzzzzzzzzzt_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)kzzzzzzzzzl_);
                    List<Dosage.DoseAndRateComponent> lzzzzzzzzzu_ = lzzzzzzzzzt_?.DoseAndRate;
                    Dosage.DoseAndRateComponent lzzzzzzzzzv_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)lzzzzzzzzzu_);
                    DataType lzzzzzzzzzw_ = lzzzzzzzzzv_?.Dose;
                    object lzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzw_);
                    decimal? lzzzzzzzzzy_ = (lzzzzzzzzzr_ ?? lzzzzzzzzzx_ as CqlQuantity)?.value;
                    Dosage mzzzzzzzzza_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)kzzzzzzzzzl_);
                    Timing mzzzzzzzzzb_ = mzzzzzzzzza_?.Timing;
                    Timing.RepeatComponent mzzzzzzzzzc_ = mzzzzzzzzzb_?.Repeat;
                    PositiveInt mzzzzzzzzzd_ = mzzzzzzzzzc_?.FrequencyMaxElement;
                    int? mzzzzzzzzze_ = mzzzzzzzzzd_?.Value;
                    Dosage mzzzzzzzzzg_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)kzzzzzzzzzl_);
                    Timing mzzzzzzzzzh_ = mzzzzzzzzzg_?.Timing;
                    Timing.RepeatComponent mzzzzzzzzzi_ = mzzzzzzzzzh_?.Repeat;
                    PositiveInt mzzzzzzzzzj_ = mzzzzzzzzzi_?.FrequencyElement;
                    int? mzzzzzzzzzk_ = mzzzzzzzzzj_?.Value;
                    Dosage mzzzzzzzzzm_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)kzzzzzzzzzl_);
                    Timing mzzzzzzzzzn_ = mzzzzzzzzzm_?.Timing;
                    Timing.RepeatComponent mzzzzzzzzzo_ = mzzzzzzzzzn_?.Repeat;
                    FhirDecimal mzzzzzzzzzp_ = mzzzzzzzzzo_?.PeriodElement;
                    decimal? mzzzzzzzzzq_ = mzzzzzzzzzp_?.Value;
                    Dosage mzzzzzzzzzs_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)kzzzzzzzzzl_);
                    Timing mzzzzzzzzzt_ = mzzzzzzzzzs_?.Timing;
                    Timing.RepeatComponent mzzzzzzzzzu_ = mzzzzzzzzzt_?.Repeat;
                    Code<Timing.UnitsOfTime> mzzzzzzzzzv_ = mzzzzzzzzzu_?.PeriodUnitElement;
                    Timing.UnitsOfTime? mzzzzzzzzzw_ = mzzzzzzzzzv_?.Value;
                    string mzzzzzzzzzx_ = context.Operators.Convert<string>(mzzzzzzzzzw_);
                    CqlQuantity mzzzzzzzzzy_ = this.Quantity(context, mzzzzzzzzzq_, mzzzzzzzzzx_);
                    decimal? mzzzzzzzzzz_ = this.ToDaily(context, mzzzzzzzzze_ ?? mzzzzzzzzzk_, mzzzzzzzzzy_);
                    Dosage nzzzzzzzzzb_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)kzzzzzzzzzl_);
                    Timing nzzzzzzzzzc_ = nzzzzzzzzzb_?.Timing;
                    Timing.RepeatComponent nzzzzzzzzzd_ = nzzzzzzzzzc_?.Repeat;
                    List<Time> nzzzzzzzzze_ = nzzzzzzzzzd_?.TimeOfDayElement;
                    IEnumerable<CqlTime> nzzzzzzzzzf_ = context.Operators.LateBoundProperty<IEnumerable<CqlTime>>(nzzzzzzzzze_, "value");
                    int? nzzzzzzzzzg_ = context.Operators.Count<CqlTime>(nzzzzzzzzzf_);
                    decimal? nzzzzzzzzzh_ = context.Operators.ConvertIntegerToDecimal(nzzzzzzzzzg_);
                    decimal? nzzzzzzzzzi_ = context.Operators.Multiply(lzzzzzzzzzy_, (mzzzzzzzzzz_ ?? nzzzzzzzzzh_) ?? 1.0m);
                    decimal? nzzzzzzzzzj_ = context.Operators.Divide(lzzzzzzzzzk_, nzzzzzzzzzi_);
                    UnsignedInt nzzzzzzzzzl_ = kzzzzzzzzzw_?.NumberOfRepeatsAllowedElement;
                    int? nzzzzzzzzzm_ = nzzzzzzzzzl_?.Value;
                    int? nzzzzzzzzzn_ = context.Operators.Add(1, nzzzzzzzzzm_ ?? 0);
                    decimal? nzzzzzzzzzo_ = context.Operators.ConvertIntegerToDecimal(nzzzzzzzzzn_);
                    decimal? nzzzzzzzzzp_ = context.Operators.Multiply(lzzzzzzzzzg_ ?? nzzzzzzzzzj_, nzzzzzzzzzo_);
                    bool? nzzzzzzzzzq_ = context.Operators.Not((bool?)(nzzzzzzzzzp_ is null));
                    bool? nzzzzzzzzzr_ = context.Operators.And(lzzzzzzzzzb_, nzzzzzzzzzq_);

                    return nzzzzzzzzzr_ ?? false;
                };
                bool kzzzzzzzzzk_()
                {
                    List<Dosage> nzzzzzzzzzs_ = R?.DosageInstruction;
                    Dosage nzzzzzzzzzt_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)nzzzzzzzzzs_);
                    Timing nzzzzzzzzzu_ = nzzzzzzzzzt_?.Timing;
                    Timing.RepeatComponent nzzzzzzzzzv_ = nzzzzzzzzzu_?.Repeat;
                    DataType nzzzzzzzzzw_ = nzzzzzzzzzv_?.Bounds;
                    object nzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzw_);
                    CqlDateTime nzzzzzzzzzy_ = context.Operators.Start(nzzzzzzzzzx_ as CqlInterval<CqlDateTime>);
                    CqlDate nzzzzzzzzzz_ = context.Operators.DateFrom(nzzzzzzzzzy_);
                    FhirDateTime ozzzzzzzzza_ = R?.AuthoredOnElement;
                    CqlDateTime ozzzzzzzzzb_ = context.Operators.Convert<CqlDateTime>(ozzzzzzzzza_);
                    CqlDate ozzzzzzzzzc_ = context.Operators.DateFrom(ozzzzzzzzzb_);
                    MedicationRequest.DispenseRequestComponent ozzzzzzzzzd_ = R?.DispenseRequest;
                    Period ozzzzzzzzze_ = ozzzzzzzzzd_?.ValidityPeriod;
                    CqlInterval<CqlDateTime> ozzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzzzzze_);
                    CqlDateTime ozzzzzzzzzg_ = context.Operators.Start(ozzzzzzzzzf_);
                    CqlDate ozzzzzzzzzh_ = context.Operators.DateFrom(ozzzzzzzzzg_);
                    bool? ozzzzzzzzzi_ = context.Operators.Not((bool?)(((nzzzzzzzzzz_ ?? ozzzzzzzzzc_) ?? ozzzzzzzzzh_) is null));
                    Dosage ozzzzzzzzzk_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)nzzzzzzzzzs_);
                    Timing ozzzzzzzzzl_ = ozzzzzzzzzk_?.Timing;
                    Timing.RepeatComponent ozzzzzzzzzm_ = ozzzzzzzzzl_?.Repeat;
                    DataType ozzzzzzzzzn_ = ozzzzzzzzzm_?.Bounds;
                    object ozzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzn_);
                    CqlDateTime ozzzzzzzzzp_ = (ozzzzzzzzzo_ as CqlInterval<CqlDateTime>)?.high;
                    bool? ozzzzzzzzzq_ = context.Operators.Not((bool?)(ozzzzzzzzzp_ is null));
                    bool? ozzzzzzzzzr_ = context.Operators.And(ozzzzzzzzzi_, ozzzzzzzzzq_);

                    return ozzzzzzzzzr_ ?? false;
                };
                if (kzzzzzzzzzj_())
                {
                    List<Dosage> ozzzzzzzzzs_ = R?.DosageInstruction;
                    Dosage ozzzzzzzzzt_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)ozzzzzzzzzs_);
                    Timing ozzzzzzzzzu_ = ozzzzzzzzzt_?.Timing;
                    Timing.RepeatComponent ozzzzzzzzzv_ = ozzzzzzzzzu_?.Repeat;
                    DataType ozzzzzzzzzw_ = ozzzzzzzzzv_?.Bounds;
                    object ozzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzw_);
                    CqlDateTime ozzzzzzzzzy_ = context.Operators.Start(ozzzzzzzzzx_ as CqlInterval<CqlDateTime>);
                    CqlDate ozzzzzzzzzz_ = context.Operators.DateFrom(ozzzzzzzzzy_);
                    FhirDateTime pzzzzzzzzza_ = R?.AuthoredOnElement;
                    CqlDateTime pzzzzzzzzzb_ = context.Operators.Convert<CqlDateTime>(pzzzzzzzzza_);
                    CqlDate pzzzzzzzzzc_ = context.Operators.DateFrom(pzzzzzzzzzb_);
                    MedicationRequest.DispenseRequestComponent pzzzzzzzzzd_ = R?.DispenseRequest;
                    Period pzzzzzzzzze_ = pzzzzzzzzzd_?.ValidityPeriod;
                    CqlInterval<CqlDateTime> pzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzzzzze_);
                    CqlDateTime pzzzzzzzzzg_ = context.Operators.Start(pzzzzzzzzzf_);
                    CqlDate pzzzzzzzzzh_ = context.Operators.DateFrom(pzzzzzzzzzg_);
                    Dosage pzzzzzzzzzj_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)ozzzzzzzzzs_);
                    Timing pzzzzzzzzzk_ = pzzzzzzzzzj_?.Timing;
                    Timing.RepeatComponent pzzzzzzzzzl_ = pzzzzzzzzzk_?.Repeat;
                    DataType pzzzzzzzzzm_ = pzzzzzzzzzl_?.Bounds;
                    object pzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzm_);
                    CqlDateTime pzzzzzzzzzo_ = context.Operators.Start(pzzzzzzzzzn_ as CqlInterval<CqlDateTime>);
                    CqlDate pzzzzzzzzzp_ = context.Operators.DateFrom(pzzzzzzzzzo_);
                    CqlDateTime pzzzzzzzzzr_ = context.Operators.Convert<CqlDateTime>(pzzzzzzzzza_);
                    CqlDate pzzzzzzzzzs_ = context.Operators.DateFrom(pzzzzzzzzzr_);
                    Period pzzzzzzzzzu_ = pzzzzzzzzzd_?.ValidityPeriod;
                    CqlInterval<CqlDateTime> pzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzzzzzu_);
                    CqlDateTime pzzzzzzzzzw_ = context.Operators.Start(pzzzzzzzzzv_);
                    CqlDate pzzzzzzzzzx_ = context.Operators.DateFrom(pzzzzzzzzzw_);
                    Duration pzzzzzzzzzz_ = pzzzzzzzzzd_?.ExpectedSupplyDuration;
                    CqlQuantity qzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, pzzzzzzzzzz_);
                    CqlQuantity qzzzzzzzzzb_ = context.Operators.ConvertQuantity(qzzzzzzzzza_, "d");
                    decimal? qzzzzzzzzzc_ = qzzzzzzzzzb_?.value;
                    Quantity qzzzzzzzzze_ = pzzzzzzzzzd_?.Quantity;
                    CqlQuantity qzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, qzzzzzzzzze_);
                    decimal? qzzzzzzzzzg_ = qzzzzzzzzzf_?.value;
                    Dosage qzzzzzzzzzi_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)ozzzzzzzzzs_);
                    List<Dosage.DoseAndRateComponent> qzzzzzzzzzj_ = qzzzzzzzzzi_?.DoseAndRate;
                    Dosage.DoseAndRateComponent qzzzzzzzzzk_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)qzzzzzzzzzj_);
                    DataType qzzzzzzzzzl_ = qzzzzzzzzzk_?.Dose;
                    object qzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzl_);
                    CqlQuantity qzzzzzzzzzn_ = context.Operators.End(qzzzzzzzzzm_ as CqlInterval<CqlQuantity>);
                    Dosage qzzzzzzzzzp_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)ozzzzzzzzzs_);
                    List<Dosage.DoseAndRateComponent> qzzzzzzzzzq_ = qzzzzzzzzzp_?.DoseAndRate;
                    Dosage.DoseAndRateComponent qzzzzzzzzzr_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)qzzzzzzzzzq_);
                    DataType qzzzzzzzzzs_ = qzzzzzzzzzr_?.Dose;
                    object qzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzs_);
                    decimal? qzzzzzzzzzu_ = (qzzzzzzzzzn_ ?? qzzzzzzzzzt_ as CqlQuantity)?.value;
                    Dosage qzzzzzzzzzw_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)ozzzzzzzzzs_);
                    Timing qzzzzzzzzzx_ = qzzzzzzzzzw_?.Timing;
                    Timing.RepeatComponent qzzzzzzzzzy_ = qzzzzzzzzzx_?.Repeat;
                    PositiveInt qzzzzzzzzzz_ = qzzzzzzzzzy_?.FrequencyMaxElement;
                    int? rzzzzzzzzza_ = qzzzzzzzzzz_?.Value;
                    Dosage rzzzzzzzzzc_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)ozzzzzzzzzs_);
                    Timing rzzzzzzzzzd_ = rzzzzzzzzzc_?.Timing;
                    Timing.RepeatComponent rzzzzzzzzze_ = rzzzzzzzzzd_?.Repeat;
                    PositiveInt rzzzzzzzzzf_ = rzzzzzzzzze_?.FrequencyElement;
                    int? rzzzzzzzzzg_ = rzzzzzzzzzf_?.Value;
                    Dosage rzzzzzzzzzi_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)ozzzzzzzzzs_);
                    Timing rzzzzzzzzzj_ = rzzzzzzzzzi_?.Timing;
                    Timing.RepeatComponent rzzzzzzzzzk_ = rzzzzzzzzzj_?.Repeat;
                    FhirDecimal rzzzzzzzzzl_ = rzzzzzzzzzk_?.PeriodElement;
                    decimal? rzzzzzzzzzm_ = rzzzzzzzzzl_?.Value;
                    Dosage rzzzzzzzzzo_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)ozzzzzzzzzs_);
                    Timing rzzzzzzzzzp_ = rzzzzzzzzzo_?.Timing;
                    Timing.RepeatComponent rzzzzzzzzzq_ = rzzzzzzzzzp_?.Repeat;
                    Code<Timing.UnitsOfTime> rzzzzzzzzzr_ = rzzzzzzzzzq_?.PeriodUnitElement;
                    Timing.UnitsOfTime? rzzzzzzzzzs_ = rzzzzzzzzzr_?.Value;
                    string rzzzzzzzzzt_ = context.Operators.Convert<string>(rzzzzzzzzzs_);
                    CqlQuantity rzzzzzzzzzu_ = this.Quantity(context, rzzzzzzzzzm_, rzzzzzzzzzt_);
                    decimal? rzzzzzzzzzv_ = this.ToDaily(context, rzzzzzzzzza_ ?? rzzzzzzzzzg_, rzzzzzzzzzu_);
                    Dosage rzzzzzzzzzx_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)ozzzzzzzzzs_);
                    Timing rzzzzzzzzzy_ = rzzzzzzzzzx_?.Timing;
                    Timing.RepeatComponent rzzzzzzzzzz_ = rzzzzzzzzzy_?.Repeat;
                    List<Time> szzzzzzzzza_ = rzzzzzzzzzz_?.TimeOfDayElement;
                    IEnumerable<CqlTime> szzzzzzzzzb_ = context.Operators.LateBoundProperty<IEnumerable<CqlTime>>(szzzzzzzzza_, "value");
                    int? szzzzzzzzzc_ = context.Operators.Count<CqlTime>(szzzzzzzzzb_);
                    decimal? szzzzzzzzzd_ = context.Operators.ConvertIntegerToDecimal(szzzzzzzzzc_);
                    decimal? szzzzzzzzze_ = context.Operators.Multiply(qzzzzzzzzzu_, (rzzzzzzzzzv_ ?? szzzzzzzzzd_) ?? 1.0m);
                    decimal? szzzzzzzzzf_ = context.Operators.Divide(qzzzzzzzzzg_, szzzzzzzzze_);
                    UnsignedInt szzzzzzzzzh_ = pzzzzzzzzzd_?.NumberOfRepeatsAllowedElement;
                    int? szzzzzzzzzi_ = szzzzzzzzzh_?.Value;
                    int? szzzzzzzzzj_ = context.Operators.Add(1, szzzzzzzzzi_ ?? 0);
                    decimal? szzzzzzzzzk_ = context.Operators.ConvertIntegerToDecimal(szzzzzzzzzj_);
                    decimal? szzzzzzzzzl_ = context.Operators.Multiply(qzzzzzzzzzc_ ?? szzzzzzzzzf_, szzzzzzzzzk_);
                    decimal? szzzzzzzzzm_ = context.Operators.ConvertIntegerToDecimal(1);
                    decimal? szzzzzzzzzn_ = context.Operators.Subtract(szzzzzzzzzl_, szzzzzzzzzm_);
                    CqlQuantity szzzzzzzzzo_ = this.Quantity(context, szzzzzzzzzn_, "day");
                    CqlDate szzzzzzzzzp_ = context.Operators.Add((pzzzzzzzzzp_ ?? pzzzzzzzzzs_) ?? pzzzzzzzzzx_, szzzzzzzzzo_);
                    CqlInterval<CqlDate> szzzzzzzzzq_ = context.Operators.Interval((ozzzzzzzzzz_ ?? pzzzzzzzzzc_) ?? pzzzzzzzzzh_, szzzzzzzzzp_, true, true);

                    return szzzzzzzzzq_;
                }
                else if (kzzzzzzzzzk_())
                {
                    List<Dosage> szzzzzzzzzr_ = R?.DosageInstruction;
                    Dosage szzzzzzzzzs_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)szzzzzzzzzr_);
                    Timing szzzzzzzzzt_ = szzzzzzzzzs_?.Timing;
                    Timing.RepeatComponent szzzzzzzzzu_ = szzzzzzzzzt_?.Repeat;
                    DataType szzzzzzzzzv_ = szzzzzzzzzu_?.Bounds;
                    object szzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzv_);
                    CqlDateTime szzzzzzzzzx_ = context.Operators.Start(szzzzzzzzzw_ as CqlInterval<CqlDateTime>);
                    CqlDate szzzzzzzzzy_ = context.Operators.DateFrom(szzzzzzzzzx_);
                    FhirDateTime szzzzzzzzzz_ = R?.AuthoredOnElement;
                    CqlDateTime tzzzzzzzzza_ = context.Operators.Convert<CqlDateTime>(szzzzzzzzzz_);
                    CqlDate tzzzzzzzzzb_ = context.Operators.DateFrom(tzzzzzzzzza_);
                    MedicationRequest.DispenseRequestComponent tzzzzzzzzzc_ = R?.DispenseRequest;
                    Period tzzzzzzzzzd_ = tzzzzzzzzzc_?.ValidityPeriod;
                    CqlInterval<CqlDateTime> tzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzzzzzzd_);
                    CqlDateTime tzzzzzzzzzf_ = context.Operators.Start(tzzzzzzzzze_);
                    CqlDate tzzzzzzzzzg_ = context.Operators.DateFrom(tzzzzzzzzzf_);
                    Dosage tzzzzzzzzzi_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)szzzzzzzzzr_);
                    Timing tzzzzzzzzzj_ = tzzzzzzzzzi_?.Timing;
                    Timing.RepeatComponent tzzzzzzzzzk_ = tzzzzzzzzzj_?.Repeat;
                    DataType tzzzzzzzzzl_ = tzzzzzzzzzk_?.Bounds;
                    object tzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzl_);
                    CqlDateTime tzzzzzzzzzn_ = context.Operators.End(tzzzzzzzzzm_ as CqlInterval<CqlDateTime>);
                    CqlDate tzzzzzzzzzo_ = context.Operators.DateFrom(tzzzzzzzzzn_);
                    CqlInterval<CqlDate> tzzzzzzzzzp_ = context.Operators.Interval((szzzzzzzzzy_ ?? tzzzzzzzzzb_) ?? tzzzzzzzzzg_, tzzzzzzzzzo_, true, true);

                    return tzzzzzzzzzp_;
                }
                else
                {
                    return null as CqlInterval<CqlDate>;
                }
            };

            return kzzzzzzzzzi_();
        };
        IEnumerable<CqlInterval<CqlDate>> kzzzzzzzzzf_ = context.Operators.Select<MedicationRequest, CqlInterval<CqlDate>>((IEnumerable<MedicationRequest>)kzzzzzzzzzd_, kzzzzzzzzze_);
        IEnumerable<CqlInterval<CqlDate>> kzzzzzzzzzg_ = context.Operators.Distinct<CqlInterval<CqlDate>>(kzzzzzzzzzf_);
        CqlInterval<CqlDate> kzzzzzzzzzh_ = context.Operators.SingletonFrom<CqlInterval<CqlDate>>(kzzzzzzzzzg_);

        return kzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("MedicationDispensePeriod")]
    public CqlInterval<CqlDate> MedicationDispensePeriod(CqlContext context, MedicationDispense Dispense)
    {
        MedicationDispense[] tzzzzzzzzzq_ = [
            Dispense,
        ];
        CqlInterval<CqlDate> tzzzzzzzzzr_(MedicationDispense D)
        {
            CqlInterval<CqlDate> tzzzzzzzzzv_()
            {
                bool tzzzzzzzzzw_()
                {
                    FhirDateTime tzzzzzzzzzx_ = D?.WhenHandedOverElement;
                    CqlDateTime tzzzzzzzzzy_ = context.Operators.Convert<CqlDateTime>(tzzzzzzzzzx_);
                    CqlDate tzzzzzzzzzz_ = context.Operators.DateFrom(tzzzzzzzzzy_);
                    FhirDateTime uzzzzzzzzza_ = D?.WhenPreparedElement;
                    CqlDateTime uzzzzzzzzzb_ = context.Operators.Convert<CqlDateTime>(uzzzzzzzzza_);
                    CqlDate uzzzzzzzzzc_ = context.Operators.DateFrom(uzzzzzzzzzb_);
                    bool? uzzzzzzzzzd_ = context.Operators.Not((bool?)((tzzzzzzzzzz_ ?? uzzzzzzzzzc_) is null));
                    Quantity uzzzzzzzzze_ = D?.DaysSupply;
                    CqlQuantity uzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, uzzzzzzzzze_);
                    CqlQuantity uzzzzzzzzzg_ = context.Operators.ConvertQuantity(uzzzzzzzzzf_, "d");
                    decimal? uzzzzzzzzzh_ = uzzzzzzzzzg_?.value;
                    Quantity uzzzzzzzzzi_ = D?.Quantity;
                    CqlQuantity uzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, uzzzzzzzzzi_);
                    decimal? uzzzzzzzzzk_ = uzzzzzzzzzj_?.value;
                    List<Dosage> uzzzzzzzzzl_ = D?.DosageInstruction;
                    Dosage uzzzzzzzzzm_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)uzzzzzzzzzl_);
                    List<Dosage.DoseAndRateComponent> uzzzzzzzzzn_ = uzzzzzzzzzm_?.DoseAndRate;
                    Dosage.DoseAndRateComponent uzzzzzzzzzo_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)uzzzzzzzzzn_);
                    DataType uzzzzzzzzzp_ = uzzzzzzzzzo_?.Dose;
                    object uzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzp_);
                    CqlQuantity uzzzzzzzzzr_ = context.Operators.End(uzzzzzzzzzq_ as CqlInterval<CqlQuantity>);
                    Dosage uzzzzzzzzzt_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)uzzzzzzzzzl_);
                    List<Dosage.DoseAndRateComponent> uzzzzzzzzzu_ = uzzzzzzzzzt_?.DoseAndRate;
                    Dosage.DoseAndRateComponent uzzzzzzzzzv_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)uzzzzzzzzzu_);
                    DataType uzzzzzzzzzw_ = uzzzzzzzzzv_?.Dose;
                    object uzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzw_);
                    decimal? uzzzzzzzzzy_ = (uzzzzzzzzzr_ ?? uzzzzzzzzzx_ as CqlQuantity)?.value;
                    Dosage vzzzzzzzzza_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)uzzzzzzzzzl_);
                    Timing vzzzzzzzzzb_ = vzzzzzzzzza_?.Timing;
                    Timing.RepeatComponent vzzzzzzzzzc_ = vzzzzzzzzzb_?.Repeat;
                    PositiveInt vzzzzzzzzzd_ = vzzzzzzzzzc_?.FrequencyMaxElement;
                    int? vzzzzzzzzze_ = vzzzzzzzzzd_?.Value;
                    Dosage vzzzzzzzzzg_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)uzzzzzzzzzl_);
                    Timing vzzzzzzzzzh_ = vzzzzzzzzzg_?.Timing;
                    Timing.RepeatComponent vzzzzzzzzzi_ = vzzzzzzzzzh_?.Repeat;
                    PositiveInt vzzzzzzzzzj_ = vzzzzzzzzzi_?.FrequencyElement;
                    int? vzzzzzzzzzk_ = vzzzzzzzzzj_?.Value;
                    Dosage vzzzzzzzzzm_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)uzzzzzzzzzl_);
                    Timing vzzzzzzzzzn_ = vzzzzzzzzzm_?.Timing;
                    Timing.RepeatComponent vzzzzzzzzzo_ = vzzzzzzzzzn_?.Repeat;
                    FhirDecimal vzzzzzzzzzp_ = vzzzzzzzzzo_?.PeriodElement;
                    decimal? vzzzzzzzzzq_ = vzzzzzzzzzp_?.Value;
                    Dosage vzzzzzzzzzs_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)uzzzzzzzzzl_);
                    Timing vzzzzzzzzzt_ = vzzzzzzzzzs_?.Timing;
                    Timing.RepeatComponent vzzzzzzzzzu_ = vzzzzzzzzzt_?.Repeat;
                    Code<Timing.UnitsOfTime> vzzzzzzzzzv_ = vzzzzzzzzzu_?.PeriodUnitElement;
                    Timing.UnitsOfTime? vzzzzzzzzzw_ = vzzzzzzzzzv_?.Value;
                    string vzzzzzzzzzx_ = context.Operators.Convert<string>(vzzzzzzzzzw_);
                    CqlQuantity vzzzzzzzzzy_ = this.Quantity(context, vzzzzzzzzzq_, vzzzzzzzzzx_);
                    decimal? vzzzzzzzzzz_ = this.ToDaily(context, vzzzzzzzzze_ ?? vzzzzzzzzzk_, vzzzzzzzzzy_);
                    Dosage wzzzzzzzzzb_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)uzzzzzzzzzl_);
                    Timing wzzzzzzzzzc_ = wzzzzzzzzzb_?.Timing;
                    Timing.RepeatComponent wzzzzzzzzzd_ = wzzzzzzzzzc_?.Repeat;
                    List<Time> wzzzzzzzzze_ = wzzzzzzzzzd_?.TimeOfDayElement;
                    IEnumerable<CqlTime> wzzzzzzzzzf_ = context.Operators.LateBoundProperty<IEnumerable<CqlTime>>(wzzzzzzzzze_, "value");
                    int? wzzzzzzzzzg_ = context.Operators.Count<CqlTime>(wzzzzzzzzzf_);
                    decimal? wzzzzzzzzzh_ = context.Operators.ConvertIntegerToDecimal(wzzzzzzzzzg_);
                    decimal? wzzzzzzzzzi_ = context.Operators.Multiply(uzzzzzzzzzy_, (vzzzzzzzzzz_ ?? wzzzzzzzzzh_) ?? 1.0m);
                    decimal? wzzzzzzzzzj_ = context.Operators.Divide(uzzzzzzzzzk_, wzzzzzzzzzi_);
                    bool? wzzzzzzzzzk_ = context.Operators.Not((bool?)((uzzzzzzzzzh_ ?? wzzzzzzzzzj_) is null));
                    bool? wzzzzzzzzzl_ = context.Operators.And(uzzzzzzzzzd_, wzzzzzzzzzk_);

                    return wzzzzzzzzzl_ ?? false;
                };
                if (tzzzzzzzzzw_())
                {
                    FhirDateTime wzzzzzzzzzm_ = D?.WhenHandedOverElement;
                    CqlDateTime wzzzzzzzzzn_ = context.Operators.Convert<CqlDateTime>(wzzzzzzzzzm_);
                    CqlDate wzzzzzzzzzo_ = context.Operators.DateFrom(wzzzzzzzzzn_);
                    FhirDateTime wzzzzzzzzzp_ = D?.WhenPreparedElement;
                    CqlDateTime wzzzzzzzzzq_ = context.Operators.Convert<CqlDateTime>(wzzzzzzzzzp_);
                    CqlDate wzzzzzzzzzr_ = context.Operators.DateFrom(wzzzzzzzzzq_);
                    CqlDateTime wzzzzzzzzzt_ = context.Operators.Convert<CqlDateTime>(wzzzzzzzzzm_);
                    CqlDate wzzzzzzzzzu_ = context.Operators.DateFrom(wzzzzzzzzzt_);
                    CqlDateTime wzzzzzzzzzw_ = context.Operators.Convert<CqlDateTime>(wzzzzzzzzzp_);
                    CqlDate wzzzzzzzzzx_ = context.Operators.DateFrom(wzzzzzzzzzw_);
                    Quantity wzzzzzzzzzy_ = D?.DaysSupply;
                    CqlQuantity wzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, wzzzzzzzzzy_);
                    CqlQuantity xzzzzzzzzza_ = context.Operators.ConvertQuantity(wzzzzzzzzzz_, "d");
                    decimal? xzzzzzzzzzb_ = xzzzzzzzzza_?.value;
                    Quantity xzzzzzzzzzc_ = D?.Quantity;
                    CqlQuantity xzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, xzzzzzzzzzc_);
                    decimal? xzzzzzzzzze_ = xzzzzzzzzzd_?.value;
                    List<Dosage> xzzzzzzzzzf_ = D?.DosageInstruction;
                    Dosage xzzzzzzzzzg_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)xzzzzzzzzzf_);
                    List<Dosage.DoseAndRateComponent> xzzzzzzzzzh_ = xzzzzzzzzzg_?.DoseAndRate;
                    Dosage.DoseAndRateComponent xzzzzzzzzzi_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)xzzzzzzzzzh_);
                    DataType xzzzzzzzzzj_ = xzzzzzzzzzi_?.Dose;
                    object xzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzj_);
                    CqlQuantity xzzzzzzzzzl_ = context.Operators.End(xzzzzzzzzzk_ as CqlInterval<CqlQuantity>);
                    Dosage xzzzzzzzzzn_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)xzzzzzzzzzf_);
                    List<Dosage.DoseAndRateComponent> xzzzzzzzzzo_ = xzzzzzzzzzn_?.DoseAndRate;
                    Dosage.DoseAndRateComponent xzzzzzzzzzp_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)xzzzzzzzzzo_);
                    DataType xzzzzzzzzzq_ = xzzzzzzzzzp_?.Dose;
                    object xzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzq_);
                    decimal? xzzzzzzzzzs_ = (xzzzzzzzzzl_ ?? xzzzzzzzzzr_ as CqlQuantity)?.value;
                    Dosage xzzzzzzzzzu_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)xzzzzzzzzzf_);
                    Timing xzzzzzzzzzv_ = xzzzzzzzzzu_?.Timing;
                    Timing.RepeatComponent xzzzzzzzzzw_ = xzzzzzzzzzv_?.Repeat;
                    PositiveInt xzzzzzzzzzx_ = xzzzzzzzzzw_?.FrequencyMaxElement;
                    int? xzzzzzzzzzy_ = xzzzzzzzzzx_?.Value;
                    Dosage yzzzzzzzzza_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)xzzzzzzzzzf_);
                    Timing yzzzzzzzzzb_ = yzzzzzzzzza_?.Timing;
                    Timing.RepeatComponent yzzzzzzzzzc_ = yzzzzzzzzzb_?.Repeat;
                    PositiveInt yzzzzzzzzzd_ = yzzzzzzzzzc_?.FrequencyElement;
                    int? yzzzzzzzzze_ = yzzzzzzzzzd_?.Value;
                    Dosage yzzzzzzzzzg_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)xzzzzzzzzzf_);
                    Timing yzzzzzzzzzh_ = yzzzzzzzzzg_?.Timing;
                    Timing.RepeatComponent yzzzzzzzzzi_ = yzzzzzzzzzh_?.Repeat;
                    FhirDecimal yzzzzzzzzzj_ = yzzzzzzzzzi_?.PeriodElement;
                    decimal? yzzzzzzzzzk_ = yzzzzzzzzzj_?.Value;
                    Dosage yzzzzzzzzzm_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)xzzzzzzzzzf_);
                    Timing yzzzzzzzzzn_ = yzzzzzzzzzm_?.Timing;
                    Timing.RepeatComponent yzzzzzzzzzo_ = yzzzzzzzzzn_?.Repeat;
                    Code<Timing.UnitsOfTime> yzzzzzzzzzp_ = yzzzzzzzzzo_?.PeriodUnitElement;
                    Timing.UnitsOfTime? yzzzzzzzzzq_ = yzzzzzzzzzp_?.Value;
                    string yzzzzzzzzzr_ = context.Operators.Convert<string>(yzzzzzzzzzq_);
                    CqlQuantity yzzzzzzzzzs_ = this.Quantity(context, yzzzzzzzzzk_, yzzzzzzzzzr_);
                    decimal? yzzzzzzzzzt_ = this.ToDaily(context, xzzzzzzzzzy_ ?? yzzzzzzzzze_, yzzzzzzzzzs_);
                    Dosage yzzzzzzzzzv_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)xzzzzzzzzzf_);
                    Timing yzzzzzzzzzw_ = yzzzzzzzzzv_?.Timing;
                    Timing.RepeatComponent yzzzzzzzzzx_ = yzzzzzzzzzw_?.Repeat;
                    List<Time> yzzzzzzzzzy_ = yzzzzzzzzzx_?.TimeOfDayElement;
                    IEnumerable<CqlTime> yzzzzzzzzzz_ = context.Operators.LateBoundProperty<IEnumerable<CqlTime>>(yzzzzzzzzzy_, "value");
                    int? zzzzzzzzzza_ = context.Operators.Count<CqlTime>(yzzzzzzzzzz_);
                    decimal? zzzzzzzzzzb_ = context.Operators.ConvertIntegerToDecimal(zzzzzzzzzza_);
                    decimal? zzzzzzzzzzc_ = context.Operators.Multiply(xzzzzzzzzzs_, (yzzzzzzzzzt_ ?? zzzzzzzzzzb_) ?? 1.0m);
                    decimal? zzzzzzzzzzd_ = context.Operators.Divide(xzzzzzzzzze_, zzzzzzzzzzc_);
                    decimal? zzzzzzzzzze_ = context.Operators.ConvertIntegerToDecimal(1);
                    decimal? zzzzzzzzzzf_ = context.Operators.Subtract(xzzzzzzzzzb_ ?? zzzzzzzzzzd_, zzzzzzzzzze_);
                    CqlQuantity zzzzzzzzzzg_ = this.Quantity(context, zzzzzzzzzzf_, "day");
                    CqlDate zzzzzzzzzzh_ = context.Operators.Add(wzzzzzzzzzu_ ?? wzzzzzzzzzx_, zzzzzzzzzzg_);
                    CqlInterval<CqlDate> zzzzzzzzzzi_ = context.Operators.Interval(wzzzzzzzzzo_ ?? wzzzzzzzzzr_, zzzzzzzzzzh_, true, true);

                    return zzzzzzzzzzi_;
                }
                else
                {
                    return null as CqlInterval<CqlDate>;
                }
            };

            return tzzzzzzzzzv_();
        };
        IEnumerable<CqlInterval<CqlDate>> tzzzzzzzzzs_ = context.Operators.Select<MedicationDispense, CqlInterval<CqlDate>>((IEnumerable<MedicationDispense>)tzzzzzzzzzq_, tzzzzzzzzzr_);
        IEnumerable<CqlInterval<CqlDate>> tzzzzzzzzzt_ = context.Operators.Distinct<CqlInterval<CqlDate>>(tzzzzzzzzzs_);
        CqlInterval<CqlDate> tzzzzzzzzzu_ = context.Operators.SingletonFrom<CqlInterval<CqlDate>>(tzzzzzzzzzt_);

        return tzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("medicationDispensePeriod")]
    public CqlInterval<CqlDate> medicationDispensePeriod(CqlContext context, MedicationDispense Dispense)
    {
        MedicationDispense[] zzzzzzzzzzj_ = [
            Dispense,
        ];
        CqlInterval<CqlDate> zzzzzzzzzzk_(MedicationDispense D)
        {
            CqlInterval<CqlDate> zzzzzzzzzzo_()
            {
                bool zzzzzzzzzzp_()
                {
                    FhirDateTime zzzzzzzzzzq_ = D?.WhenHandedOverElement;
                    CqlDateTime zzzzzzzzzzr_ = context.Operators.Convert<CqlDateTime>(zzzzzzzzzzq_);
                    CqlDate zzzzzzzzzzs_ = context.Operators.DateFrom(zzzzzzzzzzr_);
                    FhirDateTime zzzzzzzzzzt_ = D?.WhenPreparedElement;
                    CqlDateTime zzzzzzzzzzu_ = context.Operators.Convert<CqlDateTime>(zzzzzzzzzzt_);
                    CqlDate zzzzzzzzzzv_ = context.Operators.DateFrom(zzzzzzzzzzu_);
                    bool? zzzzzzzzzzw_ = context.Operators.Not((bool?)((zzzzzzzzzzs_ ?? zzzzzzzzzzv_) is null));
                    Quantity zzzzzzzzzzx_ = D?.DaysSupply;
                    CqlQuantity zzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, zzzzzzzzzzx_);
                    CqlQuantity zzzzzzzzzzz_ = context.Operators.ConvertQuantity(zzzzzzzzzzy_, "d");
                    decimal? azzzzzzzzzza_ = zzzzzzzzzzz_?.value;
                    Quantity azzzzzzzzzzb_ = D?.Quantity;
                    CqlQuantity azzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, azzzzzzzzzzb_);
                    decimal? azzzzzzzzzzd_ = azzzzzzzzzzc_?.value;
                    List<Dosage> azzzzzzzzzze_ = D?.DosageInstruction;
                    Dosage azzzzzzzzzzf_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)azzzzzzzzzze_);
                    List<Dosage.DoseAndRateComponent> azzzzzzzzzzg_ = azzzzzzzzzzf_?.DoseAndRate;
                    Dosage.DoseAndRateComponent azzzzzzzzzzh_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)azzzzzzzzzzg_);
                    DataType azzzzzzzzzzi_ = azzzzzzzzzzh_?.Dose;
                    object azzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzi_);
                    CqlQuantity azzzzzzzzzzk_ = context.Operators.End(azzzzzzzzzzj_ as CqlInterval<CqlQuantity>);
                    Dosage azzzzzzzzzzm_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)azzzzzzzzzze_);
                    List<Dosage.DoseAndRateComponent> azzzzzzzzzzn_ = azzzzzzzzzzm_?.DoseAndRate;
                    Dosage.DoseAndRateComponent azzzzzzzzzzo_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)azzzzzzzzzzn_);
                    DataType azzzzzzzzzzp_ = azzzzzzzzzzo_?.Dose;
                    object azzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzp_);
                    decimal? azzzzzzzzzzr_ = (azzzzzzzzzzk_ ?? azzzzzzzzzzq_ as CqlQuantity)?.value;
                    Dosage azzzzzzzzzzt_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)azzzzzzzzzze_);
                    Timing azzzzzzzzzzu_ = azzzzzzzzzzt_?.Timing;
                    Timing.RepeatComponent azzzzzzzzzzv_ = azzzzzzzzzzu_?.Repeat;
                    PositiveInt azzzzzzzzzzw_ = azzzzzzzzzzv_?.FrequencyMaxElement;
                    int? azzzzzzzzzzx_ = azzzzzzzzzzw_?.Value;
                    Dosage azzzzzzzzzzz_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)azzzzzzzzzze_);
                    Timing bzzzzzzzzzza_ = azzzzzzzzzzz_?.Timing;
                    Timing.RepeatComponent bzzzzzzzzzzb_ = bzzzzzzzzzza_?.Repeat;
                    PositiveInt bzzzzzzzzzzc_ = bzzzzzzzzzzb_?.FrequencyElement;
                    int? bzzzzzzzzzzd_ = bzzzzzzzzzzc_?.Value;
                    Dosage bzzzzzzzzzzf_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)azzzzzzzzzze_);
                    Timing bzzzzzzzzzzg_ = bzzzzzzzzzzf_?.Timing;
                    Timing.RepeatComponent bzzzzzzzzzzh_ = bzzzzzzzzzzg_?.Repeat;
                    FhirDecimal bzzzzzzzzzzi_ = bzzzzzzzzzzh_?.PeriodElement;
                    decimal? bzzzzzzzzzzj_ = bzzzzzzzzzzi_?.Value;
                    Dosage bzzzzzzzzzzl_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)azzzzzzzzzze_);
                    Timing bzzzzzzzzzzm_ = bzzzzzzzzzzl_?.Timing;
                    Timing.RepeatComponent bzzzzzzzzzzn_ = bzzzzzzzzzzm_?.Repeat;
                    Code<Timing.UnitsOfTime> bzzzzzzzzzzo_ = bzzzzzzzzzzn_?.PeriodUnitElement;
                    Timing.UnitsOfTime? bzzzzzzzzzzp_ = bzzzzzzzzzzo_?.Value;
                    string bzzzzzzzzzzq_ = context.Operators.Convert<string>(bzzzzzzzzzzp_);
                    CqlQuantity bzzzzzzzzzzr_ = this.Quantity(context, bzzzzzzzzzzj_, bzzzzzzzzzzq_);
                    decimal? bzzzzzzzzzzs_ = this.ToDaily(context, azzzzzzzzzzx_ ?? bzzzzzzzzzzd_, bzzzzzzzzzzr_);
                    Dosage bzzzzzzzzzzu_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)azzzzzzzzzze_);
                    Timing bzzzzzzzzzzv_ = bzzzzzzzzzzu_?.Timing;
                    Timing.RepeatComponent bzzzzzzzzzzw_ = bzzzzzzzzzzv_?.Repeat;
                    List<Time> bzzzzzzzzzzx_ = bzzzzzzzzzzw_?.TimeOfDayElement;
                    IEnumerable<CqlTime> bzzzzzzzzzzy_ = context.Operators.LateBoundProperty<IEnumerable<CqlTime>>(bzzzzzzzzzzx_, "value");
                    int? bzzzzzzzzzzz_ = context.Operators.Count<CqlTime>(bzzzzzzzzzzy_);
                    decimal? czzzzzzzzzza_ = context.Operators.ConvertIntegerToDecimal(bzzzzzzzzzzz_);
                    decimal? czzzzzzzzzzb_ = context.Operators.Multiply(azzzzzzzzzzr_, (bzzzzzzzzzzs_ ?? czzzzzzzzzza_) ?? 1.0m);
                    decimal? czzzzzzzzzzc_ = context.Operators.Divide(azzzzzzzzzzd_, czzzzzzzzzzb_);
                    bool? czzzzzzzzzzd_ = context.Operators.Not((bool?)((azzzzzzzzzza_ ?? czzzzzzzzzzc_) is null));
                    bool? czzzzzzzzzze_ = context.Operators.And(zzzzzzzzzzw_, czzzzzzzzzzd_);

                    return czzzzzzzzzze_ ?? false;
                };
                if (zzzzzzzzzzp_())
                {
                    FhirDateTime czzzzzzzzzzf_ = D?.WhenHandedOverElement;
                    CqlDateTime czzzzzzzzzzg_ = context.Operators.Convert<CqlDateTime>(czzzzzzzzzzf_);
                    CqlDate czzzzzzzzzzh_ = context.Operators.DateFrom(czzzzzzzzzzg_);
                    FhirDateTime czzzzzzzzzzi_ = D?.WhenPreparedElement;
                    CqlDateTime czzzzzzzzzzj_ = context.Operators.Convert<CqlDateTime>(czzzzzzzzzzi_);
                    CqlDate czzzzzzzzzzk_ = context.Operators.DateFrom(czzzzzzzzzzj_);
                    CqlDateTime czzzzzzzzzzm_ = context.Operators.Convert<CqlDateTime>(czzzzzzzzzzf_);
                    CqlDate czzzzzzzzzzn_ = context.Operators.DateFrom(czzzzzzzzzzm_);
                    CqlDateTime czzzzzzzzzzp_ = context.Operators.Convert<CqlDateTime>(czzzzzzzzzzi_);
                    CqlDate czzzzzzzzzzq_ = context.Operators.DateFrom(czzzzzzzzzzp_);
                    Quantity czzzzzzzzzzr_ = D?.DaysSupply;
                    CqlQuantity czzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, czzzzzzzzzzr_);
                    CqlQuantity czzzzzzzzzzt_ = context.Operators.ConvertQuantity(czzzzzzzzzzs_, "d");
                    decimal? czzzzzzzzzzu_ = czzzzzzzzzzt_?.value;
                    Quantity czzzzzzzzzzv_ = D?.Quantity;
                    CqlQuantity czzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, czzzzzzzzzzv_);
                    decimal? czzzzzzzzzzx_ = czzzzzzzzzzw_?.value;
                    List<Dosage> czzzzzzzzzzy_ = D?.DosageInstruction;
                    Dosage czzzzzzzzzzz_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)czzzzzzzzzzy_);
                    List<Dosage.DoseAndRateComponent> dzzzzzzzzzza_ = czzzzzzzzzzz_?.DoseAndRate;
                    Dosage.DoseAndRateComponent dzzzzzzzzzzb_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)dzzzzzzzzzza_);
                    DataType dzzzzzzzzzzc_ = dzzzzzzzzzzb_?.Dose;
                    object dzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzc_);
                    CqlQuantity dzzzzzzzzzze_ = context.Operators.End(dzzzzzzzzzzd_ as CqlInterval<CqlQuantity>);
                    Dosage dzzzzzzzzzzg_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)czzzzzzzzzzy_);
                    List<Dosage.DoseAndRateComponent> dzzzzzzzzzzh_ = dzzzzzzzzzzg_?.DoseAndRate;
                    Dosage.DoseAndRateComponent dzzzzzzzzzzi_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)dzzzzzzzzzzh_);
                    DataType dzzzzzzzzzzj_ = dzzzzzzzzzzi_?.Dose;
                    object dzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzj_);
                    decimal? dzzzzzzzzzzl_ = (dzzzzzzzzzze_ ?? dzzzzzzzzzzk_ as CqlQuantity)?.value;
                    Dosage dzzzzzzzzzzn_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)czzzzzzzzzzy_);
                    Timing dzzzzzzzzzzo_ = dzzzzzzzzzzn_?.Timing;
                    Timing.RepeatComponent dzzzzzzzzzzp_ = dzzzzzzzzzzo_?.Repeat;
                    PositiveInt dzzzzzzzzzzq_ = dzzzzzzzzzzp_?.FrequencyMaxElement;
                    int? dzzzzzzzzzzr_ = dzzzzzzzzzzq_?.Value;
                    Dosage dzzzzzzzzzzt_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)czzzzzzzzzzy_);
                    Timing dzzzzzzzzzzu_ = dzzzzzzzzzzt_?.Timing;
                    Timing.RepeatComponent dzzzzzzzzzzv_ = dzzzzzzzzzzu_?.Repeat;
                    PositiveInt dzzzzzzzzzzw_ = dzzzzzzzzzzv_?.FrequencyElement;
                    int? dzzzzzzzzzzx_ = dzzzzzzzzzzw_?.Value;
                    Dosage dzzzzzzzzzzz_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)czzzzzzzzzzy_);
                    Timing ezzzzzzzzzza_ = dzzzzzzzzzzz_?.Timing;
                    Timing.RepeatComponent ezzzzzzzzzzb_ = ezzzzzzzzzza_?.Repeat;
                    FhirDecimal ezzzzzzzzzzc_ = ezzzzzzzzzzb_?.PeriodElement;
                    decimal? ezzzzzzzzzzd_ = ezzzzzzzzzzc_?.Value;
                    Dosage ezzzzzzzzzzf_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)czzzzzzzzzzy_);
                    Timing ezzzzzzzzzzg_ = ezzzzzzzzzzf_?.Timing;
                    Timing.RepeatComponent ezzzzzzzzzzh_ = ezzzzzzzzzzg_?.Repeat;
                    Code<Timing.UnitsOfTime> ezzzzzzzzzzi_ = ezzzzzzzzzzh_?.PeriodUnitElement;
                    Timing.UnitsOfTime? ezzzzzzzzzzj_ = ezzzzzzzzzzi_?.Value;
                    string ezzzzzzzzzzk_ = context.Operators.Convert<string>(ezzzzzzzzzzj_);
                    CqlQuantity ezzzzzzzzzzl_ = this.Quantity(context, ezzzzzzzzzzd_, ezzzzzzzzzzk_);
                    decimal? ezzzzzzzzzzm_ = this.ToDaily(context, dzzzzzzzzzzr_ ?? dzzzzzzzzzzx_, ezzzzzzzzzzl_);
                    Dosage ezzzzzzzzzzo_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)czzzzzzzzzzy_);
                    Timing ezzzzzzzzzzp_ = ezzzzzzzzzzo_?.Timing;
                    Timing.RepeatComponent ezzzzzzzzzzq_ = ezzzzzzzzzzp_?.Repeat;
                    List<Time> ezzzzzzzzzzr_ = ezzzzzzzzzzq_?.TimeOfDayElement;
                    IEnumerable<CqlTime> ezzzzzzzzzzs_ = context.Operators.LateBoundProperty<IEnumerable<CqlTime>>(ezzzzzzzzzzr_, "value");
                    int? ezzzzzzzzzzt_ = context.Operators.Count<CqlTime>(ezzzzzzzzzzs_);
                    decimal? ezzzzzzzzzzu_ = context.Operators.ConvertIntegerToDecimal(ezzzzzzzzzzt_);
                    decimal? ezzzzzzzzzzv_ = context.Operators.Multiply(dzzzzzzzzzzl_, (ezzzzzzzzzzm_ ?? ezzzzzzzzzzu_) ?? 1.0m);
                    decimal? ezzzzzzzzzzw_ = context.Operators.Divide(czzzzzzzzzzx_, ezzzzzzzzzzv_);
                    decimal? ezzzzzzzzzzx_ = context.Operators.ConvertIntegerToDecimal(1);
                    decimal? ezzzzzzzzzzy_ = context.Operators.Subtract(czzzzzzzzzzu_ ?? ezzzzzzzzzzw_, ezzzzzzzzzzx_);
                    CqlQuantity ezzzzzzzzzzz_ = this.Quantity(context, ezzzzzzzzzzy_, "day");
                    CqlDate fzzzzzzzzzza_ = context.Operators.Add(czzzzzzzzzzn_ ?? czzzzzzzzzzq_, ezzzzzzzzzzz_);
                    CqlInterval<CqlDate> fzzzzzzzzzzb_ = context.Operators.Interval(czzzzzzzzzzh_ ?? czzzzzzzzzzk_, fzzzzzzzzzza_, true, true);

                    return fzzzzzzzzzzb_;
                }
                else
                {
                    return null as CqlInterval<CqlDate>;
                }
            };

            return zzzzzzzzzzo_();
        };
        IEnumerable<CqlInterval<CqlDate>> zzzzzzzzzzl_ = context.Operators.Select<MedicationDispense, CqlInterval<CqlDate>>((IEnumerable<MedicationDispense>)zzzzzzzzzzj_, zzzzzzzzzzk_);
        IEnumerable<CqlInterval<CqlDate>> zzzzzzzzzzm_ = context.Operators.Distinct<CqlInterval<CqlDate>>(zzzzzzzzzzl_);
        CqlInterval<CqlDate> zzzzzzzzzzn_ = context.Operators.SingletonFrom<CqlInterval<CqlDate>>(zzzzzzzzzzm_);

        return zzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("TherapeuticDuration")]
    public CqlQuantity TherapeuticDuration(CqlContext context, CqlConcept medication)
    {
        CqlQuantity fzzzzzzzzzzc_ = context.Operators.Quantity(14m, "days");

        return fzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("MedicationAdministrationPeriod")]
    public CqlInterval<CqlDate> MedicationAdministrationPeriod(CqlContext context, MedicationAdministration Administration)
    {
        MedicationAdministration[] fzzzzzzzzzzd_ = [
            Administration,
        ];
        CqlInterval<CqlDate> fzzzzzzzzzze_(MedicationAdministration M)
        {
            CqlInterval<CqlDate> fzzzzzzzzzzi_()
            {
                bool fzzzzzzzzzzj_()
                {
                    DataType fzzzzzzzzzzk_ = Administration?.Effective;
                    object fzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzk_);
                    CqlDateTime fzzzzzzzzzzm_ = context.Operators.Start(fzzzzzzzzzzl_ as CqlInterval<CqlDateTime>);
                    CqlDate fzzzzzzzzzzn_ = context.Operators.DateFrom(fzzzzzzzzzzm_);
                    bool? fzzzzzzzzzzo_ = context.Operators.Not((bool?)(fzzzzzzzzzzn_ is null));
                    DataType fzzzzzzzzzzp_ = Administration?.Medication;
                    object fzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzp_);
                    CqlQuantity fzzzzzzzzzzr_ = this.TherapeuticDuration(context, fzzzzzzzzzzq_ as CqlConcept);
                    bool? fzzzzzzzzzzs_ = context.Operators.Not((bool?)(fzzzzzzzzzzr_ is null));
                    bool? fzzzzzzzzzzt_ = context.Operators.And(fzzzzzzzzzzo_, fzzzzzzzzzzs_);

                    return fzzzzzzzzzzt_ ?? false;
                };
                if (fzzzzzzzzzzj_())
                {
                    DataType fzzzzzzzzzzu_ = Administration?.Effective;
                    object fzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzu_);
                    CqlDateTime fzzzzzzzzzzw_ = context.Operators.Start(fzzzzzzzzzzv_ as CqlInterval<CqlDateTime>);
                    CqlDate fzzzzzzzzzzx_ = context.Operators.DateFrom(fzzzzzzzzzzw_);
                    object fzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzu_);
                    CqlDateTime gzzzzzzzzzza_ = context.Operators.Start(fzzzzzzzzzzz_ as CqlInterval<CqlDateTime>);
                    CqlDate gzzzzzzzzzzb_ = context.Operators.DateFrom(gzzzzzzzzzza_);
                    DataType gzzzzzzzzzzc_ = Administration?.Medication;
                    object gzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzc_);
                    CqlQuantity gzzzzzzzzzze_ = this.TherapeuticDuration(context, gzzzzzzzzzzd_ as CqlConcept);
                    CqlDate gzzzzzzzzzzf_ = context.Operators.Add(gzzzzzzzzzzb_, gzzzzzzzzzze_);
                    CqlQuantity gzzzzzzzzzzg_ = context.Operators.ConvertIntegerToQuantity(1);
                    CqlDate gzzzzzzzzzzh_ = context.Operators.Subtract(gzzzzzzzzzzf_, gzzzzzzzzzzg_);
                    CqlInterval<CqlDate> gzzzzzzzzzzi_ = context.Operators.Interval(fzzzzzzzzzzx_, gzzzzzzzzzzh_, true, true);

                    return gzzzzzzzzzzi_;
                }
                else
                {
                    return null as CqlInterval<CqlDate>;
                }
            };

            return fzzzzzzzzzzi_();
        };
        IEnumerable<CqlInterval<CqlDate>> fzzzzzzzzzzf_ = context.Operators.Select<MedicationAdministration, CqlInterval<CqlDate>>((IEnumerable<MedicationAdministration>)fzzzzzzzzzzd_, fzzzzzzzzzze_);
        IEnumerable<CqlInterval<CqlDate>> fzzzzzzzzzzg_ = context.Operators.Distinct<CqlInterval<CqlDate>>(fzzzzzzzzzzf_);
        CqlInterval<CqlDate> fzzzzzzzzzzh_ = context.Operators.SingletonFrom<CqlInterval<CqlDate>>(fzzzzzzzzzzg_);

        return fzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("medicationAdministrationPeriod")]
    public CqlInterval<CqlDate> medicationAdministrationPeriod(CqlContext context, MedicationAdministration Administration)
    {
        MedicationAdministration[] gzzzzzzzzzzj_ = [
            Administration,
        ];
        CqlInterval<CqlDate> gzzzzzzzzzzk_(MedicationAdministration M)
        {
            CqlInterval<CqlDate> gzzzzzzzzzzo_()
            {
                bool gzzzzzzzzzzp_()
                {
                    DataType gzzzzzzzzzzq_ = Administration?.Effective;
                    object gzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzq_);
                    CqlDateTime gzzzzzzzzzzs_ = context.Operators.Start(gzzzzzzzzzzr_ as CqlInterval<CqlDateTime>);
                    CqlDate gzzzzzzzzzzt_ = context.Operators.DateFrom(gzzzzzzzzzzs_);
                    bool? gzzzzzzzzzzu_ = context.Operators.Not((bool?)(gzzzzzzzzzzt_ is null));
                    DataType gzzzzzzzzzzv_ = Administration?.Medication;
                    object gzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzv_);
                    CqlQuantity gzzzzzzzzzzx_ = this.TherapeuticDuration(context, gzzzzzzzzzzw_ as CqlConcept);
                    bool? gzzzzzzzzzzy_ = context.Operators.Not((bool?)(gzzzzzzzzzzx_ is null));
                    bool? gzzzzzzzzzzz_ = context.Operators.And(gzzzzzzzzzzu_, gzzzzzzzzzzy_);

                    return gzzzzzzzzzzz_ ?? false;
                };
                if (gzzzzzzzzzzp_())
                {
                    DataType hzzzzzzzzzza_ = Administration?.Effective;
                    object hzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzza_);
                    CqlDateTime hzzzzzzzzzzc_ = context.Operators.Start(hzzzzzzzzzzb_ as CqlInterval<CqlDateTime>);
                    CqlDate hzzzzzzzzzzd_ = context.Operators.DateFrom(hzzzzzzzzzzc_);
                    object hzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzza_);
                    CqlDateTime hzzzzzzzzzzg_ = context.Operators.Start(hzzzzzzzzzzf_ as CqlInterval<CqlDateTime>);
                    CqlDate hzzzzzzzzzzh_ = context.Operators.DateFrom(hzzzzzzzzzzg_);
                    DataType hzzzzzzzzzzi_ = Administration?.Medication;
                    object hzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzi_);
                    CqlQuantity hzzzzzzzzzzk_ = this.TherapeuticDuration(context, hzzzzzzzzzzj_ as CqlConcept);
                    CqlDate hzzzzzzzzzzl_ = context.Operators.Add(hzzzzzzzzzzh_, hzzzzzzzzzzk_);
                    CqlQuantity hzzzzzzzzzzm_ = context.Operators.ConvertIntegerToQuantity(1);
                    CqlDate hzzzzzzzzzzn_ = context.Operators.Subtract(hzzzzzzzzzzl_, hzzzzzzzzzzm_);
                    CqlInterval<CqlDate> hzzzzzzzzzzo_ = context.Operators.Interval(hzzzzzzzzzzd_, hzzzzzzzzzzn_, true, true);

                    return hzzzzzzzzzzo_;
                }
                else
                {
                    return null as CqlInterval<CqlDate>;
                }
            };

            return gzzzzzzzzzzo_();
        };
        IEnumerable<CqlInterval<CqlDate>> gzzzzzzzzzzl_ = context.Operators.Select<MedicationAdministration, CqlInterval<CqlDate>>((IEnumerable<MedicationAdministration>)gzzzzzzzzzzj_, gzzzzzzzzzzk_);
        IEnumerable<CqlInterval<CqlDate>> gzzzzzzzzzzm_ = context.Operators.Distinct<CqlInterval<CqlDate>>(gzzzzzzzzzzl_);
        CqlInterval<CqlDate> gzzzzzzzzzzn_ = context.Operators.SingletonFrom<CqlInterval<CqlDate>>(gzzzzzzzzzzm_);

        return gzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("CumulativeDuration")]
    public int? CumulativeDuration(CqlContext context, IEnumerable<CqlInterval<CqlDate>> Intervals)
    {
        int? hzzzzzzzzzzp_()
        {
            if ((context.Operators.Not((bool?)(Intervals is null))) ?? false)
            {
                IEnumerable<CqlInterval<CqlDate>> hzzzzzzzzzzq_ = context.Operators.Collapse(Intervals, "day");
                int? hzzzzzzzzzzr_(CqlInterval<CqlDate> X)
                {
                    CqlDate hzzzzzzzzzzu_ = context.Operators.Start(X);
                    CqlDate hzzzzzzzzzzv_ = context.Operators.End(X);
                    int? hzzzzzzzzzzw_ = context.Operators.DifferenceBetween(hzzzzzzzzzzu_, hzzzzzzzzzzv_, "day");
                    int? hzzzzzzzzzzx_ = context.Operators.Add(hzzzzzzzzzzw_, 1);

                    return hzzzzzzzzzzx_;
                };
                IEnumerable<int?> hzzzzzzzzzzs_ = context.Operators.Select<CqlInterval<CqlDate>, int?>(hzzzzzzzzzzq_, hzzzzzzzzzzr_);
                int? hzzzzzzzzzzt_ = context.Operators.Sum(hzzzzzzzzzzs_);

                return hzzzzzzzzzzt_;
            }
            else
            {
                return default;
            }
        };

        return hzzzzzzzzzzp_();
    }


    [CqlExpressionDefinition("cumulativeDuration")]
    public int? cumulativeDuration(CqlContext context, IEnumerable<CqlInterval<CqlDate>> Intervals)
    {
        int? hzzzzzzzzzzy_()
        {
            if ((context.Operators.Not((bool?)(Intervals is null))) ?? false)
            {
                IEnumerable<CqlInterval<CqlDate>> hzzzzzzzzzzz_ = context.Operators.Collapse(Intervals, "day");
                int? izzzzzzzzzza_(CqlInterval<CqlDate> X)
                {
                    CqlDate izzzzzzzzzzd_ = context.Operators.Start(X);
                    CqlDate izzzzzzzzzze_ = context.Operators.End(X);
                    int? izzzzzzzzzzf_ = context.Operators.DifferenceBetween(izzzzzzzzzzd_, izzzzzzzzzze_, "day");
                    int? izzzzzzzzzzg_ = context.Operators.Add(izzzzzzzzzzf_, 1);

                    return izzzzzzzzzzg_;
                };
                IEnumerable<int?> izzzzzzzzzzb_ = context.Operators.Select<CqlInterval<CqlDate>, int?>(hzzzzzzzzzzz_, izzzzzzzzzza_);
                int? izzzzzzzzzzc_ = context.Operators.Sum(izzzzzzzzzzb_);

                return izzzzzzzzzzc_;
            }
            else
            {
                return default;
            }
        };

        return hzzzzzzzzzzy_();
    }


    [CqlExpressionDefinition("RolloutIntervals")]
    public IEnumerable<CqlInterval<CqlDate>> RolloutIntervals(CqlContext context, IEnumerable<CqlInterval<CqlDate>> intervals)
    {
        IEnumerable<CqlInterval<CqlDate>> izzzzzzzzzzh_(IEnumerable<CqlInterval<CqlDate>> R, CqlInterval<CqlDate> I)
        {
            CqlInterval<CqlDate>[] izzzzzzzzzzj_ = [
                I,
            ];
            CqlInterval<CqlDate> izzzzzzzzzzk_(CqlInterval<CqlDate> X)
            {
                CqlInterval<CqlDate> izzzzzzzzzzq_ = context.Operators.Last<CqlInterval<CqlDate>>(R);
                CqlDate izzzzzzzzzzr_ = context.Operators.End(izzzzzzzzzzq_);
                CqlQuantity izzzzzzzzzzs_ = context.Operators.Quantity(1m, "day");
                CqlDate izzzzzzzzzzt_ = context.Operators.Add(izzzzzzzzzzr_, izzzzzzzzzzs_);
                CqlDate izzzzzzzzzzu_ = context.Operators.Start(X);
                CqlDate[] izzzzzzzzzzv_ = [
                    izzzzzzzzzzt_,
                    izzzzzzzzzzu_,
                ];
                CqlDate izzzzzzzzzzw_ = context.Operators.Max<CqlDate>(izzzzzzzzzzv_ as IEnumerable<CqlDate>);
                CqlDate izzzzzzzzzzy_ = context.Operators.End(izzzzzzzzzzq_);
                CqlDate jzzzzzzzzzza_ = context.Operators.Add(izzzzzzzzzzy_, izzzzzzzzzzs_);
                CqlDate[] jzzzzzzzzzzc_ = [
                    jzzzzzzzzzza_,
                    izzzzzzzzzzu_,
                ];
                CqlDate jzzzzzzzzzzd_ = context.Operators.Max<CqlDate>(jzzzzzzzzzzc_ as IEnumerable<CqlDate>);
                CqlDate jzzzzzzzzzzf_ = context.Operators.End(X);
                int? jzzzzzzzzzzg_ = context.Operators.DurationBetween(izzzzzzzzzzu_, jzzzzzzzzzzf_, "day");
                decimal? jzzzzzzzzzzh_ = context.Operators.ConvertIntegerToDecimal(jzzzzzzzzzzg_ ?? 0);
                CqlQuantity jzzzzzzzzzzi_ = this.Quantity(context, jzzzzzzzzzzh_, "day");
                CqlDate jzzzzzzzzzzj_ = context.Operators.Add(jzzzzzzzzzzd_, jzzzzzzzzzzi_);
                CqlInterval<CqlDate> jzzzzzzzzzzk_ = context.Operators.Interval(izzzzzzzzzzw_, jzzzzzzzzzzj_, true, true);

                return jzzzzzzzzzzk_;
            };
            IEnumerable<CqlInterval<CqlDate>> izzzzzzzzzzl_ = context.Operators.Select<CqlInterval<CqlDate>, CqlInterval<CqlDate>>((IEnumerable<CqlInterval<CqlDate>>)izzzzzzzzzzj_, izzzzzzzzzzk_);
            IEnumerable<CqlInterval<CqlDate>> izzzzzzzzzzm_ = context.Operators.Distinct<CqlInterval<CqlDate>>(izzzzzzzzzzl_);
            CqlInterval<CqlDate> izzzzzzzzzzn_ = context.Operators.SingletonFrom<CqlInterval<CqlDate>>(izzzzzzzzzzm_);
            CqlInterval<CqlDate>[] izzzzzzzzzzo_ = [
                izzzzzzzzzzn_,
            ];
            IEnumerable<CqlInterval<CqlDate>> izzzzzzzzzzp_ = context.Operators.Union<CqlInterval<CqlDate>>(R, izzzzzzzzzzo_ as IEnumerable<CqlInterval<CqlDate>>);

            return izzzzzzzzzzp_;
        };
        IEnumerable<CqlInterval<CqlDate>> izzzzzzzzzzi_ = context.Operators.Aggregate<CqlInterval<CqlDate>, IEnumerable<CqlInterval<CqlDate>>>(intervals, izzzzzzzzzzh_, null as IEnumerable<CqlInterval<CqlDate>>);

        return izzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("rolloutIntervals")]
    public IEnumerable<CqlInterval<CqlDate>> rolloutIntervals(CqlContext context, IEnumerable<CqlInterval<CqlDate>> intervals)
    {
        IEnumerable<CqlInterval<CqlDate>> jzzzzzzzzzzl_(IEnumerable<CqlInterval<CqlDate>> R, CqlInterval<CqlDate> I)
        {
            CqlInterval<CqlDate>[] jzzzzzzzzzzn_ = [
                I,
            ];
            CqlInterval<CqlDate> jzzzzzzzzzzo_(CqlInterval<CqlDate> X)
            {
                CqlInterval<CqlDate> jzzzzzzzzzzu_ = context.Operators.Last<CqlInterval<CqlDate>>(R);
                CqlDate jzzzzzzzzzzv_ = context.Operators.End(jzzzzzzzzzzu_);
                CqlQuantity jzzzzzzzzzzw_ = context.Operators.Quantity(1m, "day");
                CqlDate jzzzzzzzzzzx_ = context.Operators.Add(jzzzzzzzzzzv_, jzzzzzzzzzzw_);
                CqlDate jzzzzzzzzzzy_ = context.Operators.Start(X);
                CqlDate[] jzzzzzzzzzzz_ = [
                    jzzzzzzzzzzx_,
                    jzzzzzzzzzzy_,
                ];
                CqlDate kzzzzzzzzzza_ = context.Operators.Max<CqlDate>(jzzzzzzzzzzz_ as IEnumerable<CqlDate>);
                CqlDate kzzzzzzzzzzc_ = context.Operators.End(jzzzzzzzzzzu_);
                CqlDate kzzzzzzzzzze_ = context.Operators.Add(kzzzzzzzzzzc_, jzzzzzzzzzzw_);
                CqlDate[] kzzzzzzzzzzg_ = [
                    kzzzzzzzzzze_,
                    jzzzzzzzzzzy_,
                ];
                CqlDate kzzzzzzzzzzh_ = context.Operators.Max<CqlDate>(kzzzzzzzzzzg_ as IEnumerable<CqlDate>);
                CqlDate kzzzzzzzzzzj_ = context.Operators.End(X);
                int? kzzzzzzzzzzk_ = context.Operators.DurationBetween(jzzzzzzzzzzy_, kzzzzzzzzzzj_, "day");
                decimal? kzzzzzzzzzzl_ = context.Operators.ConvertIntegerToDecimal(kzzzzzzzzzzk_ ?? 0);
                CqlQuantity kzzzzzzzzzzm_ = this.Quantity(context, kzzzzzzzzzzl_, "day");
                CqlDate kzzzzzzzzzzn_ = context.Operators.Add(kzzzzzzzzzzh_, kzzzzzzzzzzm_);
                CqlInterval<CqlDate> kzzzzzzzzzzo_ = context.Operators.Interval(kzzzzzzzzzza_, kzzzzzzzzzzn_, true, true);

                return kzzzzzzzzzzo_;
            };
            IEnumerable<CqlInterval<CqlDate>> jzzzzzzzzzzp_ = context.Operators.Select<CqlInterval<CqlDate>, CqlInterval<CqlDate>>((IEnumerable<CqlInterval<CqlDate>>)jzzzzzzzzzzn_, jzzzzzzzzzzo_);
            IEnumerable<CqlInterval<CqlDate>> jzzzzzzzzzzq_ = context.Operators.Distinct<CqlInterval<CqlDate>>(jzzzzzzzzzzp_);
            CqlInterval<CqlDate> jzzzzzzzzzzr_ = context.Operators.SingletonFrom<CqlInterval<CqlDate>>(jzzzzzzzzzzq_);
            CqlInterval<CqlDate>[] jzzzzzzzzzzs_ = [
                jzzzzzzzzzzr_,
            ];
            IEnumerable<CqlInterval<CqlDate>> jzzzzzzzzzzt_ = context.Operators.Union<CqlInterval<CqlDate>>(R, jzzzzzzzzzzs_ as IEnumerable<CqlInterval<CqlDate>>);

            return jzzzzzzzzzzt_;
        };
        IEnumerable<CqlInterval<CqlDate>> jzzzzzzzzzzm_ = context.Operators.Aggregate<CqlInterval<CqlDate>, IEnumerable<CqlInterval<CqlDate>>>(intervals, jzzzzzzzzzzl_, null as IEnumerable<CqlInterval<CqlDate>>);

        return jzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("MedicationPeriod")]
    public CqlInterval<CqlDate> MedicationPeriod(CqlContext context, object medication)
    {
        CqlInterval<CqlDate> kzzzzzzzzzzp_()
        {
            if (medication is MedicationRequest)
            {
                CqlInterval<CqlDate> kzzzzzzzzzzq_ = this.MedicationRequestPeriod(context, medication as MedicationRequest);

                return kzzzzzzzzzzq_;
            }
            else if (medication is MedicationDispense)
            {
                CqlInterval<CqlDate> kzzzzzzzzzzr_ = this.MedicationDispensePeriod(context, medication as MedicationDispense);

                return kzzzzzzzzzzr_;
            }
            else
            {
                return null as CqlInterval<CqlDate>;
            }
        };

        return kzzzzzzzzzzp_();
    }


    [CqlExpressionDefinition("medicationPeriod")]
    public CqlInterval<CqlDate> medicationPeriod(CqlContext context, object medication)
    {
        CqlInterval<CqlDate> kzzzzzzzzzzs_()
        {
            if (medication is MedicationRequest)
            {
                CqlInterval<CqlDate> kzzzzzzzzzzt_ = this.medicationRequestPeriod(context, medication as MedicationRequest);

                return kzzzzzzzzzzt_;
            }
            else if (medication is MedicationDispense)
            {
                CqlInterval<CqlDate> kzzzzzzzzzzu_ = this.medicationDispensePeriod(context, medication as MedicationDispense);

                return kzzzzzzzzzzu_;
            }
            else
            {
                return null as CqlInterval<CqlDate>;
            }
        };

        return kzzzzzzzzzzs_();
    }


    [CqlExpressionDefinition("CumulativeMedicationDuration")]
    public int? CumulativeMedicationDuration(CqlContext context, IEnumerable<object> Medications)
    {
        bool? kzzzzzzzzzzv_(object M)
        {
            bool lzzzzzzzzzzi_ = M is MedicationRequest;

            return lzzzzzzzzzzi_ as bool?;
        };
        IEnumerable<object> kzzzzzzzzzzw_ = context.Operators.Where<object>(Medications, kzzzzzzzzzzv_);
        CqlInterval<CqlDate> kzzzzzzzzzzx_(object M)
        {
            CqlInterval<CqlDate> lzzzzzzzzzzj_ = this.MedicationRequestPeriod(context, M as MedicationRequest);

            return lzzzzzzzzzzj_;
        };
        IEnumerable<CqlInterval<CqlDate>> kzzzzzzzzzzy_ = context.Operators.Select<object, CqlInterval<CqlDate>>(kzzzzzzzzzzw_, kzzzzzzzzzzx_);
        IEnumerable<CqlInterval<CqlDate>> kzzzzzzzzzzz_ = context.Operators.Distinct<CqlInterval<CqlDate>>(kzzzzzzzzzzy_);
        bool? lzzzzzzzzzza_(object M)
        {
            bool lzzzzzzzzzzk_ = M is MedicationDispense;

            return lzzzzzzzzzzk_ as bool?;
        };
        IEnumerable<object> lzzzzzzzzzzb_ = context.Operators.Where<object>(Medications, lzzzzzzzzzza_);
        CqlInterval<CqlDate> lzzzzzzzzzzc_(object M)
        {
            CqlInterval<CqlDate> lzzzzzzzzzzl_ = this.MedicationDispensePeriod(context, M as MedicationDispense);

            return lzzzzzzzzzzl_;
        };
        IEnumerable<CqlInterval<CqlDate>> lzzzzzzzzzzd_ = context.Operators.Select<object, CqlInterval<CqlDate>>(lzzzzzzzzzzb_, lzzzzzzzzzzc_);
        IEnumerable<CqlInterval<CqlDate>> lzzzzzzzzzze_ = context.Operators.Distinct<CqlInterval<CqlDate>>(lzzzzzzzzzzd_);
        IEnumerable<CqlInterval<CqlDate>> lzzzzzzzzzzf_ = this.RolloutIntervals(context, lzzzzzzzzzze_);
        IEnumerable<CqlInterval<CqlDate>> lzzzzzzzzzzg_ = context.Operators.Union<CqlInterval<CqlDate>>(kzzzzzzzzzzz_, lzzzzzzzzzzf_);
        int? lzzzzzzzzzzh_ = this.CumulativeDuration(context, lzzzzzzzzzzg_);

        return lzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("cumulativeMedicationDuration")]
    public int? cumulativeMedicationDuration(CqlContext context, IEnumerable<object> Medications)
    {
        bool? lzzzzzzzzzzm_(object M)
        {
            bool lzzzzzzzzzzz_ = M is MedicationRequest;

            return lzzzzzzzzzzz_ as bool?;
        };
        IEnumerable<object> lzzzzzzzzzzn_ = context.Operators.Where<object>(Medications, lzzzzzzzzzzm_);
        CqlInterval<CqlDate> lzzzzzzzzzzo_(object M)
        {
            CqlInterval<CqlDate> mzzzzzzzzzza_ = this.medicationRequestPeriod(context, M as MedicationRequest);

            return mzzzzzzzzzza_;
        };
        IEnumerable<CqlInterval<CqlDate>> lzzzzzzzzzzp_ = context.Operators.Select<object, CqlInterval<CqlDate>>(lzzzzzzzzzzn_, lzzzzzzzzzzo_);
        IEnumerable<CqlInterval<CqlDate>> lzzzzzzzzzzq_ = context.Operators.Distinct<CqlInterval<CqlDate>>(lzzzzzzzzzzp_);
        bool? lzzzzzzzzzzr_(object M)
        {
            bool mzzzzzzzzzzb_ = M is MedicationDispense;

            return mzzzzzzzzzzb_ as bool?;
        };
        IEnumerable<object> lzzzzzzzzzzs_ = context.Operators.Where<object>(Medications, lzzzzzzzzzzr_);
        CqlInterval<CqlDate> lzzzzzzzzzzt_(object M)
        {
            CqlInterval<CqlDate> mzzzzzzzzzzc_ = this.medicationDispensePeriod(context, M as MedicationDispense);

            return mzzzzzzzzzzc_;
        };
        IEnumerable<CqlInterval<CqlDate>> lzzzzzzzzzzu_ = context.Operators.Select<object, CqlInterval<CqlDate>>(lzzzzzzzzzzs_, lzzzzzzzzzzt_);
        IEnumerable<CqlInterval<CqlDate>> lzzzzzzzzzzv_ = context.Operators.Distinct<CqlInterval<CqlDate>>(lzzzzzzzzzzu_);
        IEnumerable<CqlInterval<CqlDate>> lzzzzzzzzzzw_ = this.rolloutIntervals(context, lzzzzzzzzzzv_);
        IEnumerable<CqlInterval<CqlDate>> lzzzzzzzzzzx_ = context.Operators.Union<CqlInterval<CqlDate>>(lzzzzzzzzzzq_, lzzzzzzzzzzw_);
        int? lzzzzzzzzzzy_ = this.cumulativeDuration(context, lzzzzzzzzzzx_);

        return lzzzzzzzzzzy_;
    }


    #endregion Expressions

}
