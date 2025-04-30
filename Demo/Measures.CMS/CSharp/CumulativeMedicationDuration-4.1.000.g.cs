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
        object szzzzzzzw_ = context.ResolveParameter("CumulativeMedicationDuration-4.1.000", "ErrorLevel", "Warning");

        return (string)szzzzzzzw_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> szzzzzzzx_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient szzzzzzzy_ = context.Operators.SingletonFrom<Patient>(szzzzzzzx_);

        return szzzzzzzy_;
    }


    [CqlExpressionDefinition("ToDaily")]
    public decimal? ToDaily(CqlContext context, int? frequency, CqlQuantity period)
    {
        decimal? szzzzzzzz_()
        {
            bool tzzzzzzza_()
            {
                string tzzzzzzzv_ = period?.unit;
                bool? tzzzzzzzw_ = context.Operators.Equal(tzzzzzzzv_, "h");

                return tzzzzzzzw_ ?? false;
            };
            bool tzzzzzzzb_()
            {
                string tzzzzzzzx_ = period?.unit;
                bool? tzzzzzzzy_ = context.Operators.Equal(tzzzzzzzx_, "min");

                return tzzzzzzzy_ ?? false;
            };
            bool tzzzzzzzc_()
            {
                string tzzzzzzzz_ = period?.unit;
                bool? uzzzzzzza_ = context.Operators.Equal(tzzzzzzzz_, "s");

                return uzzzzzzza_ ?? false;
            };
            bool tzzzzzzzd_()
            {
                string uzzzzzzzb_ = period?.unit;
                bool? uzzzzzzzc_ = context.Operators.Equal(uzzzzzzzb_, "d");

                return uzzzzzzzc_ ?? false;
            };
            bool tzzzzzzze_()
            {
                string uzzzzzzzd_ = period?.unit;
                bool? uzzzzzzze_ = context.Operators.Equal(uzzzzzzzd_, "wk");

                return uzzzzzzze_ ?? false;
            };
            bool tzzzzzzzf_()
            {
                string uzzzzzzzf_ = period?.unit;
                bool? uzzzzzzzg_ = context.Operators.Equal(uzzzzzzzf_, "mo");

                return uzzzzzzzg_ ?? false;
            };
            bool tzzzzzzzg_()
            {
                string uzzzzzzzh_ = period?.unit;
                bool? uzzzzzzzi_ = context.Operators.Equal(uzzzzzzzh_, "a");

                return uzzzzzzzi_ ?? false;
            };
            bool tzzzzzzzh_()
            {
                string uzzzzzzzj_ = period?.unit;
                bool? uzzzzzzzk_ = context.Operators.Equal(uzzzzzzzj_, "hour");

                return uzzzzzzzk_ ?? false;
            };
            bool tzzzzzzzi_()
            {
                string uzzzzzzzl_ = period?.unit;
                bool? uzzzzzzzm_ = context.Operators.Equal(uzzzzzzzl_, "minute");

                return uzzzzzzzm_ ?? false;
            };
            bool tzzzzzzzj_()
            {
                string uzzzzzzzn_ = period?.unit;
                bool? uzzzzzzzo_ = context.Operators.Equal(uzzzzzzzn_, "second");

                return uzzzzzzzo_ ?? false;
            };
            bool tzzzzzzzk_()
            {
                string uzzzzzzzp_ = period?.unit;
                bool? uzzzzzzzq_ = context.Operators.Equal(uzzzzzzzp_, "day");

                return uzzzzzzzq_ ?? false;
            };
            bool tzzzzzzzl_()
            {
                string uzzzzzzzr_ = period?.unit;
                bool? uzzzzzzzs_ = context.Operators.Equal(uzzzzzzzr_, "week");

                return uzzzzzzzs_ ?? false;
            };
            bool tzzzzzzzm_()
            {
                string uzzzzzzzt_ = period?.unit;
                bool? uzzzzzzzu_ = context.Operators.Equal(uzzzzzzzt_, "month");

                return uzzzzzzzu_ ?? false;
            };
            bool tzzzzzzzn_()
            {
                string uzzzzzzzv_ = period?.unit;
                bool? uzzzzzzzw_ = context.Operators.Equal(uzzzzzzzv_, "year");

                return uzzzzzzzw_ ?? false;
            };
            bool tzzzzzzzo_()
            {
                string uzzzzzzzx_ = period?.unit;
                bool? uzzzzzzzy_ = context.Operators.Equal(uzzzzzzzx_, "hours");

                return uzzzzzzzy_ ?? false;
            };
            bool tzzzzzzzp_()
            {
                string uzzzzzzzz_ = period?.unit;
                bool? vzzzzzzza_ = context.Operators.Equal(uzzzzzzzz_, "minutes");

                return vzzzzzzza_ ?? false;
            };
            bool tzzzzzzzq_()
            {
                string vzzzzzzzb_ = period?.unit;
                bool? vzzzzzzzc_ = context.Operators.Equal(vzzzzzzzb_, "seconds");

                return vzzzzzzzc_ ?? false;
            };
            bool tzzzzzzzr_()
            {
                string vzzzzzzzd_ = period?.unit;
                bool? vzzzzzzze_ = context.Operators.Equal(vzzzzzzzd_, "days");

                return vzzzzzzze_ ?? false;
            };
            bool tzzzzzzzs_()
            {
                string vzzzzzzzf_ = period?.unit;
                bool? vzzzzzzzg_ = context.Operators.Equal(vzzzzzzzf_, "weeks");

                return vzzzzzzzg_ ?? false;
            };
            bool tzzzzzzzt_()
            {
                string vzzzzzzzh_ = period?.unit;
                bool? vzzzzzzzi_ = context.Operators.Equal(vzzzzzzzh_, "months");

                return vzzzzzzzi_ ?? false;
            };
            bool tzzzzzzzu_()
            {
                string vzzzzzzzj_ = period?.unit;
                bool? vzzzzzzzk_ = context.Operators.Equal(vzzzzzzzj_, "years");

                return vzzzzzzzk_ ?? false;
            };
            if (tzzzzzzza_())
            {
                decimal? vzzzzzzzl_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? vzzzzzzzm_ = period?.value;
                decimal? vzzzzzzzn_ = context.Operators.Divide(24.0m, vzzzzzzzm_);
                decimal? vzzzzzzzo_ = context.Operators.Multiply(vzzzzzzzl_, vzzzzzzzn_);

                return vzzzzzzzo_;
            }
            else if (tzzzzzzzb_())
            {
                decimal? vzzzzzzzp_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? vzzzzzzzq_ = period?.value;
                decimal? vzzzzzzzr_ = context.Operators.Divide(24.0m, vzzzzzzzq_);
                decimal? vzzzzzzzs_ = context.Operators.Multiply(vzzzzzzzp_, vzzzzzzzr_);
                decimal? vzzzzzzzt_ = context.Operators.ConvertIntegerToDecimal(60);
                decimal? vzzzzzzzu_ = context.Operators.Multiply(vzzzzzzzs_, vzzzzzzzt_);

                return vzzzzzzzu_;
            }
            else if (tzzzzzzzc_())
            {
                decimal? vzzzzzzzv_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? vzzzzzzzw_ = period?.value;
                decimal? vzzzzzzzx_ = context.Operators.Divide(24.0m, vzzzzzzzw_);
                decimal? vzzzzzzzy_ = context.Operators.Multiply(vzzzzzzzv_, vzzzzzzzx_);
                decimal? vzzzzzzzz_ = context.Operators.ConvertIntegerToDecimal(60);
                decimal? wzzzzzzza_ = context.Operators.Multiply(vzzzzzzzy_, vzzzzzzzz_);
                decimal? wzzzzzzzc_ = context.Operators.Multiply(wzzzzzzza_, vzzzzzzzz_);

                return wzzzzzzzc_;
            }
            else if (tzzzzzzzd_())
            {
                decimal? wzzzzzzzd_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? wzzzzzzze_ = period?.value;
                decimal? wzzzzzzzf_ = context.Operators.Divide(24.0m, wzzzzzzze_);
                decimal? wzzzzzzzg_ = context.Operators.Multiply(wzzzzzzzd_, wzzzzzzzf_);
                decimal? wzzzzzzzh_ = context.Operators.ConvertIntegerToDecimal(24);
                decimal? wzzzzzzzi_ = context.Operators.Divide(wzzzzzzzg_, wzzzzzzzh_);

                return wzzzzzzzi_;
            }
            else if (tzzzzzzze_())
            {
                decimal? wzzzzzzzj_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? wzzzzzzzk_ = period?.value;
                decimal? wzzzzzzzl_ = context.Operators.Divide(24.0m, wzzzzzzzk_);
                decimal? wzzzzzzzm_ = context.Operators.Multiply(wzzzzzzzj_, wzzzzzzzl_);
                int? wzzzzzzzn_ = context.Operators.Multiply(24, 7);
                decimal? wzzzzzzzo_ = context.Operators.ConvertIntegerToDecimal(wzzzzzzzn_);
                decimal? wzzzzzzzp_ = context.Operators.Divide(wzzzzzzzm_, wzzzzzzzo_);

                return wzzzzzzzp_;
            }
            else if (tzzzzzzzf_())
            {
                decimal? wzzzzzzzq_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? wzzzzzzzr_ = period?.value;
                decimal? wzzzzzzzs_ = context.Operators.Divide(24.0m, wzzzzzzzr_);
                decimal? wzzzzzzzt_ = context.Operators.Multiply(wzzzzzzzq_, wzzzzzzzs_);
                int? wzzzzzzzu_ = context.Operators.Multiply(24, 30);
                decimal? wzzzzzzzv_ = context.Operators.ConvertIntegerToDecimal(wzzzzzzzu_);
                decimal? wzzzzzzzw_ = context.Operators.Divide(wzzzzzzzt_, wzzzzzzzv_);

                return wzzzzzzzw_;
            }
            else if (tzzzzzzzg_())
            {
                decimal? wzzzzzzzx_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? wzzzzzzzy_ = period?.value;
                decimal? wzzzzzzzz_ = context.Operators.Divide(24.0m, wzzzzzzzy_);
                decimal? xzzzzzzza_ = context.Operators.Multiply(wzzzzzzzx_, wzzzzzzzz_);
                int? xzzzzzzzb_ = context.Operators.Multiply(24, 365);
                decimal? xzzzzzzzc_ = context.Operators.ConvertIntegerToDecimal(xzzzzzzzb_);
                decimal? xzzzzzzzd_ = context.Operators.Divide(xzzzzzzza_, xzzzzzzzc_);

                return xzzzzzzzd_;
            }
            else if (tzzzzzzzh_())
            {
                decimal? xzzzzzzze_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? xzzzzzzzf_ = period?.value;
                decimal? xzzzzzzzg_ = context.Operators.Divide(24.0m, xzzzzzzzf_);
                decimal? xzzzzzzzh_ = context.Operators.Multiply(xzzzzzzze_, xzzzzzzzg_);

                return xzzzzzzzh_;
            }
            else if (tzzzzzzzi_())
            {
                decimal? xzzzzzzzi_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? xzzzzzzzj_ = period?.value;
                decimal? xzzzzzzzk_ = context.Operators.Divide(24.0m, xzzzzzzzj_);
                decimal? xzzzzzzzl_ = context.Operators.Multiply(xzzzzzzzi_, xzzzzzzzk_);
                decimal? xzzzzzzzm_ = context.Operators.ConvertIntegerToDecimal(60);
                decimal? xzzzzzzzn_ = context.Operators.Multiply(xzzzzzzzl_, xzzzzzzzm_);

                return xzzzzzzzn_;
            }
            else if (tzzzzzzzj_())
            {
                decimal? xzzzzzzzo_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? xzzzzzzzp_ = period?.value;
                decimal? xzzzzzzzq_ = context.Operators.Divide(24.0m, xzzzzzzzp_);
                decimal? xzzzzzzzr_ = context.Operators.Multiply(xzzzzzzzo_, xzzzzzzzq_);
                decimal? xzzzzzzzs_ = context.Operators.ConvertIntegerToDecimal(60);
                decimal? xzzzzzzzt_ = context.Operators.Multiply(xzzzzzzzr_, xzzzzzzzs_);
                decimal? xzzzzzzzv_ = context.Operators.Multiply(xzzzzzzzt_, xzzzzzzzs_);

                return xzzzzzzzv_;
            }
            else if (tzzzzzzzk_())
            {
                decimal? xzzzzzzzw_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? xzzzzzzzx_ = period?.value;
                decimal? xzzzzzzzy_ = context.Operators.Divide(24.0m, xzzzzzzzx_);
                decimal? xzzzzzzzz_ = context.Operators.Multiply(xzzzzzzzw_, xzzzzzzzy_);
                decimal? yzzzzzzza_ = context.Operators.ConvertIntegerToDecimal(24);
                decimal? yzzzzzzzb_ = context.Operators.Divide(xzzzzzzzz_, yzzzzzzza_);

                return yzzzzzzzb_;
            }
            else if (tzzzzzzzl_())
            {
                decimal? yzzzzzzzc_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? yzzzzzzzd_ = period?.value;
                decimal? yzzzzzzze_ = context.Operators.Divide(24.0m, yzzzzzzzd_);
                decimal? yzzzzzzzf_ = context.Operators.Multiply(yzzzzzzzc_, yzzzzzzze_);
                int? yzzzzzzzg_ = context.Operators.Multiply(24, 7);
                decimal? yzzzzzzzh_ = context.Operators.ConvertIntegerToDecimal(yzzzzzzzg_);
                decimal? yzzzzzzzi_ = context.Operators.Divide(yzzzzzzzf_, yzzzzzzzh_);

                return yzzzzzzzi_;
            }
            else if (tzzzzzzzm_())
            {
                decimal? yzzzzzzzj_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? yzzzzzzzk_ = period?.value;
                decimal? yzzzzzzzl_ = context.Operators.Divide(24.0m, yzzzzzzzk_);
                decimal? yzzzzzzzm_ = context.Operators.Multiply(yzzzzzzzj_, yzzzzzzzl_);
                int? yzzzzzzzn_ = context.Operators.Multiply(24, 30);
                decimal? yzzzzzzzo_ = context.Operators.ConvertIntegerToDecimal(yzzzzzzzn_);
                decimal? yzzzzzzzp_ = context.Operators.Divide(yzzzzzzzm_, yzzzzzzzo_);

                return yzzzzzzzp_;
            }
            else if (tzzzzzzzn_())
            {
                decimal? yzzzzzzzq_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? yzzzzzzzr_ = period?.value;
                decimal? yzzzzzzzs_ = context.Operators.Divide(24.0m, yzzzzzzzr_);
                decimal? yzzzzzzzt_ = context.Operators.Multiply(yzzzzzzzq_, yzzzzzzzs_);
                int? yzzzzzzzu_ = context.Operators.Multiply(24, 365);
                decimal? yzzzzzzzv_ = context.Operators.ConvertIntegerToDecimal(yzzzzzzzu_);
                decimal? yzzzzzzzw_ = context.Operators.Divide(yzzzzzzzt_, yzzzzzzzv_);

                return yzzzzzzzw_;
            }
            else if (tzzzzzzzo_())
            {
                decimal? yzzzzzzzx_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? yzzzzzzzy_ = period?.value;
                decimal? yzzzzzzzz_ = context.Operators.Divide(24.0m, yzzzzzzzy_);
                decimal? zzzzzzzza_ = context.Operators.Multiply(yzzzzzzzx_, yzzzzzzzz_);

                return zzzzzzzza_;
            }
            else if (tzzzzzzzp_())
            {
                decimal? zzzzzzzzb_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? zzzzzzzzc_ = period?.value;
                decimal? zzzzzzzzd_ = context.Operators.Divide(24.0m, zzzzzzzzc_);
                decimal? zzzzzzzze_ = context.Operators.Multiply(zzzzzzzzb_, zzzzzzzzd_);
                decimal? zzzzzzzzf_ = context.Operators.ConvertIntegerToDecimal(60);
                decimal? zzzzzzzzg_ = context.Operators.Multiply(zzzzzzzze_, zzzzzzzzf_);

                return zzzzzzzzg_;
            }
            else if (tzzzzzzzq_())
            {
                decimal? zzzzzzzzh_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? zzzzzzzzi_ = period?.value;
                decimal? zzzzzzzzj_ = context.Operators.Divide(24.0m, zzzzzzzzi_);
                decimal? zzzzzzzzk_ = context.Operators.Multiply(zzzzzzzzh_, zzzzzzzzj_);
                decimal? zzzzzzzzl_ = context.Operators.ConvertIntegerToDecimal(60);
                decimal? zzzzzzzzm_ = context.Operators.Multiply(zzzzzzzzk_, zzzzzzzzl_);
                decimal? zzzzzzzzo_ = context.Operators.Multiply(zzzzzzzzm_, zzzzzzzzl_);

                return zzzzzzzzo_;
            }
            else if (tzzzzzzzr_())
            {
                decimal? zzzzzzzzp_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? zzzzzzzzq_ = period?.value;
                decimal? zzzzzzzzr_ = context.Operators.Divide(24.0m, zzzzzzzzq_);
                decimal? zzzzzzzzs_ = context.Operators.Multiply(zzzzzzzzp_, zzzzzzzzr_);
                decimal? zzzzzzzzt_ = context.Operators.ConvertIntegerToDecimal(24);
                decimal? zzzzzzzzu_ = context.Operators.Divide(zzzzzzzzs_, zzzzzzzzt_);

                return zzzzzzzzu_;
            }
            else if (tzzzzzzzs_())
            {
                decimal? zzzzzzzzv_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? zzzzzzzzw_ = period?.value;
                decimal? zzzzzzzzx_ = context.Operators.Divide(24.0m, zzzzzzzzw_);
                decimal? zzzzzzzzy_ = context.Operators.Multiply(zzzzzzzzv_, zzzzzzzzx_);
                int? zzzzzzzzz_ = context.Operators.Multiply(24, 7);
                decimal? azzzzzzzza_ = context.Operators.ConvertIntegerToDecimal(zzzzzzzzz_);
                decimal? azzzzzzzzb_ = context.Operators.Divide(zzzzzzzzy_, azzzzzzzza_);

                return azzzzzzzzb_;
            }
            else if (tzzzzzzzt_())
            {
                decimal? azzzzzzzzc_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? azzzzzzzzd_ = period?.value;
                decimal? azzzzzzzze_ = context.Operators.Divide(24.0m, azzzzzzzzd_);
                decimal? azzzzzzzzf_ = context.Operators.Multiply(azzzzzzzzc_, azzzzzzzze_);
                int? azzzzzzzzg_ = context.Operators.Multiply(24, 30);
                decimal? azzzzzzzzh_ = context.Operators.ConvertIntegerToDecimal(azzzzzzzzg_);
                decimal? azzzzzzzzi_ = context.Operators.Divide(azzzzzzzzf_, azzzzzzzzh_);

                return azzzzzzzzi_;
            }
            else if (tzzzzzzzu_())
            {
                decimal? azzzzzzzzj_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? azzzzzzzzk_ = period?.value;
                decimal? azzzzzzzzl_ = context.Operators.Divide(24.0m, azzzzzzzzk_);
                decimal? azzzzzzzzm_ = context.Operators.Multiply(azzzzzzzzj_, azzzzzzzzl_);
                int? azzzzzzzzn_ = context.Operators.Multiply(24, 365);
                decimal? azzzzzzzzo_ = context.Operators.ConvertIntegerToDecimal(azzzzzzzzn_);
                decimal? azzzzzzzzp_ = context.Operators.Divide(azzzzzzzzm_, azzzzzzzzo_);

                return azzzzzzzzp_;
            }
            else
            {
                string azzzzzzzzq_ = this.ErrorLevel(context);
                string azzzzzzzzr_ = period?.unit;
                string azzzzzzzzs_ = context.Operators.Concatenate("Unknown unit ", azzzzzzzzr_ ?? "");
                object azzzzzzzzt_ = context.Operators.Message<object>(null, "CMDLogic.ToDaily.UnknownUnit", azzzzzzzzq_, azzzzzzzzs_);

                return azzzzzzzzt_ as decimal?;
            }
        };

        return szzzzzzzz_();
    }


    [CqlExpressionDefinition("ToDaily")]
    public decimal? ToDaily(CqlContext context, CqlCode frequency)
    {
        decimal? azzzzzzzzu_()
        {
            bool azzzzzzzzv_()
            {
                CqlCode czzzzzzzzq_ = this.HS(context);
                bool? czzzzzzzzr_ = context.Operators.Equivalent(frequency, czzzzzzzzq_);

                return czzzzzzzzr_ ?? false;
            };
            bool azzzzzzzzw_()
            {
                CqlCode czzzzzzzzs_ = this.WAKE(context);
                bool? czzzzzzzzt_ = context.Operators.Equivalent(frequency, czzzzzzzzs_);

                return czzzzzzzzt_ ?? false;
            };
            bool azzzzzzzzx_()
            {
                CqlCode czzzzzzzzu_ = this.C(context);
                bool? czzzzzzzzv_ = context.Operators.Equivalent(frequency, czzzzzzzzu_);

                return czzzzzzzzv_ ?? false;
            };
            bool azzzzzzzzy_()
            {
                CqlCode czzzzzzzzw_ = this.CM(context);
                bool? czzzzzzzzx_ = context.Operators.Equivalent(frequency, czzzzzzzzw_);

                return czzzzzzzzx_ ?? false;
            };
            bool azzzzzzzzz_()
            {
                CqlCode czzzzzzzzy_ = this.CD(context);
                bool? czzzzzzzzz_ = context.Operators.Equivalent(frequency, czzzzzzzzy_);

                return czzzzzzzzz_ ?? false;
            };
            bool bzzzzzzzza_()
            {
                CqlCode dzzzzzzzza_ = this.CV(context);
                bool? dzzzzzzzzb_ = context.Operators.Equivalent(frequency, dzzzzzzzza_);

                return dzzzzzzzzb_ ?? false;
            };
            bool bzzzzzzzzb_()
            {
                CqlCode dzzzzzzzzc_ = this.AC(context);
                bool? dzzzzzzzzd_ = context.Operators.Equivalent(frequency, dzzzzzzzzc_);

                return dzzzzzzzzd_ ?? false;
            };
            bool bzzzzzzzzc_()
            {
                CqlCode dzzzzzzzze_ = this.ACM(context);
                bool? dzzzzzzzzf_ = context.Operators.Equivalent(frequency, dzzzzzzzze_);

                return dzzzzzzzzf_ ?? false;
            };
            bool bzzzzzzzzd_()
            {
                CqlCode dzzzzzzzzg_ = this.ACD(context);
                bool? dzzzzzzzzh_ = context.Operators.Equivalent(frequency, dzzzzzzzzg_);

                return dzzzzzzzzh_ ?? false;
            };
            bool bzzzzzzzze_()
            {
                CqlCode dzzzzzzzzi_ = this.ACV(context);
                bool? dzzzzzzzzj_ = context.Operators.Equivalent(frequency, dzzzzzzzzi_);

                return dzzzzzzzzj_ ?? false;
            };
            bool bzzzzzzzzf_()
            {
                CqlCode dzzzzzzzzk_ = this.PC(context);
                bool? dzzzzzzzzl_ = context.Operators.Equivalent(frequency, dzzzzzzzzk_);

                return dzzzzzzzzl_ ?? false;
            };
            bool bzzzzzzzzg_()
            {
                CqlCode dzzzzzzzzm_ = this.PCM(context);
                bool? dzzzzzzzzn_ = context.Operators.Equivalent(frequency, dzzzzzzzzm_);

                return dzzzzzzzzn_ ?? false;
            };
            bool bzzzzzzzzh_()
            {
                CqlCode dzzzzzzzzo_ = this.PCD(context);
                bool? dzzzzzzzzp_ = context.Operators.Equivalent(frequency, dzzzzzzzzo_);

                return dzzzzzzzzp_ ?? false;
            };
            bool bzzzzzzzzi_()
            {
                CqlCode dzzzzzzzzq_ = this.PCV(context);
                bool? dzzzzzzzzr_ = context.Operators.Equivalent(frequency, dzzzzzzzzq_);

                return dzzzzzzzzr_ ?? false;
            };
            bool bzzzzzzzzj_()
            {
                CqlCode dzzzzzzzzs_ = this.MORN(context);
                bool? dzzzzzzzzt_ = context.Operators.Equivalent(frequency, dzzzzzzzzs_);

                return dzzzzzzzzt_ ?? false;
            };
            bool bzzzzzzzzk_()
            {
                CqlCode dzzzzzzzzu_ = this.MORN_early(context);
                bool? dzzzzzzzzv_ = context.Operators.Equivalent(frequency, dzzzzzzzzu_);

                return dzzzzzzzzv_ ?? false;
            };
            bool bzzzzzzzzl_()
            {
                CqlCode dzzzzzzzzw_ = this.MORN_late(context);
                bool? dzzzzzzzzx_ = context.Operators.Equivalent(frequency, dzzzzzzzzw_);

                return dzzzzzzzzx_ ?? false;
            };
            bool bzzzzzzzzm_()
            {
                CqlCode dzzzzzzzzy_ = this.NOON(context);
                bool? dzzzzzzzzz_ = context.Operators.Equivalent(frequency, dzzzzzzzzy_);

                return dzzzzzzzzz_ ?? false;
            };
            bool bzzzzzzzzn_()
            {
                CqlCode ezzzzzzzza_ = this.AFT(context);
                bool? ezzzzzzzzb_ = context.Operators.Equivalent(frequency, ezzzzzzzza_);

                return ezzzzzzzzb_ ?? false;
            };
            bool bzzzzzzzzo_()
            {
                CqlCode ezzzzzzzzc_ = this.AFT_early(context);
                bool? ezzzzzzzzd_ = context.Operators.Equivalent(frequency, ezzzzzzzzc_);

                return ezzzzzzzzd_ ?? false;
            };
            bool bzzzzzzzzp_()
            {
                CqlCode ezzzzzzzze_ = this.AFT_late(context);
                bool? ezzzzzzzzf_ = context.Operators.Equivalent(frequency, ezzzzzzzze_);

                return ezzzzzzzzf_ ?? false;
            };
            bool bzzzzzzzzq_()
            {
                CqlCode ezzzzzzzzg_ = this.EVE(context);
                bool? ezzzzzzzzh_ = context.Operators.Equivalent(frequency, ezzzzzzzzg_);

                return ezzzzzzzzh_ ?? false;
            };
            bool bzzzzzzzzr_()
            {
                CqlCode ezzzzzzzzi_ = this.EVE_early(context);
                bool? ezzzzzzzzj_ = context.Operators.Equivalent(frequency, ezzzzzzzzi_);

                return ezzzzzzzzj_ ?? false;
            };
            bool bzzzzzzzzs_()
            {
                CqlCode ezzzzzzzzk_ = this.EVE_late(context);
                bool? ezzzzzzzzl_ = context.Operators.Equivalent(frequency, ezzzzzzzzk_);

                return ezzzzzzzzl_ ?? false;
            };
            bool bzzzzzzzzt_()
            {
                CqlCode ezzzzzzzzm_ = this.NIGHT(context);
                bool? ezzzzzzzzn_ = context.Operators.Equivalent(frequency, ezzzzzzzzm_);

                return ezzzzzzzzn_ ?? false;
            };
            bool bzzzzzzzzu_()
            {
                CqlCode ezzzzzzzzo_ = this.PHS(context);
                bool? ezzzzzzzzp_ = context.Operators.Equivalent(frequency, ezzzzzzzzo_);

                return ezzzzzzzzp_ ?? false;
            };
            bool bzzzzzzzzv_()
            {
                CqlCode ezzzzzzzzq_ = this.Once_daily__qualifier_value_(context);
                bool? ezzzzzzzzr_ = context.Operators.Equivalent(frequency, ezzzzzzzzq_);

                return ezzzzzzzzr_ ?? false;
            };
            bool bzzzzzzzzw_()
            {
                CqlCode ezzzzzzzzs_ = this.Twice_a_day__qualifier_value_(context);
                bool? ezzzzzzzzt_ = context.Operators.Equivalent(frequency, ezzzzzzzzs_);

                return ezzzzzzzzt_ ?? false;
            };
            bool bzzzzzzzzx_()
            {
                CqlCode ezzzzzzzzu_ = this.Three_times_daily__qualifier_value_(context);
                bool? ezzzzzzzzv_ = context.Operators.Equivalent(frequency, ezzzzzzzzu_);

                return ezzzzzzzzv_ ?? false;
            };
            bool bzzzzzzzzy_()
            {
                CqlCode ezzzzzzzzw_ = this.Four_times_daily__qualifier_value_(context);
                bool? ezzzzzzzzx_ = context.Operators.Equivalent(frequency, ezzzzzzzzw_);

                return ezzzzzzzzx_ ?? false;
            };
            bool bzzzzzzzzz_()
            {
                CqlCode ezzzzzzzzy_ = this.Every_twenty_four_hours__qualifier_value_(context);
                bool? ezzzzzzzzz_ = context.Operators.Equivalent(frequency, ezzzzzzzzy_);

                return ezzzzzzzzz_ ?? false;
            };
            bool czzzzzzzza_()
            {
                CqlCode fzzzzzzzza_ = this.Every_twelve_hours__qualifier_value_(context);
                bool? fzzzzzzzzb_ = context.Operators.Equivalent(frequency, fzzzzzzzza_);

                return fzzzzzzzzb_ ?? false;
            };
            bool czzzzzzzzb_()
            {
                CqlCode fzzzzzzzzc_ = this.Every_thirty_six_hours__qualifier_value_(context);
                bool? fzzzzzzzzd_ = context.Operators.Equivalent(frequency, fzzzzzzzzc_);

                return fzzzzzzzzd_ ?? false;
            };
            bool czzzzzzzzc_()
            {
                CqlCode fzzzzzzzze_ = this.Every_eight_hours__qualifier_value_(context);
                bool? fzzzzzzzzf_ = context.Operators.Equivalent(frequency, fzzzzzzzze_);

                return fzzzzzzzzf_ ?? false;
            };
            bool czzzzzzzzd_()
            {
                CqlCode fzzzzzzzzg_ = this.Every_four_hours__qualifier_value_(context);
                bool? fzzzzzzzzh_ = context.Operators.Equivalent(frequency, fzzzzzzzzg_);

                return fzzzzzzzzh_ ?? false;
            };
            bool czzzzzzzze_()
            {
                CqlCode fzzzzzzzzi_ = this.Every_six_hours__qualifier_value_(context);
                bool? fzzzzzzzzj_ = context.Operators.Equivalent(frequency, fzzzzzzzzi_);

                return fzzzzzzzzj_ ?? false;
            };
            bool czzzzzzzzf_()
            {
                CqlCode fzzzzzzzzk_ = this.Every_seventy_two_hours__qualifier_value_(context);
                bool? fzzzzzzzzl_ = context.Operators.Equivalent(frequency, fzzzzzzzzk_);

                return fzzzzzzzzl_ ?? false;
            };
            bool czzzzzzzzg_()
            {
                CqlCode fzzzzzzzzm_ = this.Every_forty_eight_hours__qualifier_value_(context);
                bool? fzzzzzzzzn_ = context.Operators.Equivalent(frequency, fzzzzzzzzm_);

                return fzzzzzzzzn_ ?? false;
            };
            bool czzzzzzzzh_()
            {
                CqlCode fzzzzzzzzo_ = this.Every_eight_to_twelve_hours__qualifier_value_(context);
                bool? fzzzzzzzzp_ = context.Operators.Equivalent(frequency, fzzzzzzzzo_);

                return fzzzzzzzzp_ ?? false;
            };
            bool czzzzzzzzi_()
            {
                CqlCode fzzzzzzzzq_ = this.Every_six_to_eight_hours__qualifier_value_(context);
                bool? fzzzzzzzzr_ = context.Operators.Equivalent(frequency, fzzzzzzzzq_);

                return fzzzzzzzzr_ ?? false;
            };
            bool czzzzzzzzj_()
            {
                CqlCode fzzzzzzzzs_ = this.Every_three_to_four_hours__qualifier_value_(context);
                bool? fzzzzzzzzt_ = context.Operators.Equivalent(frequency, fzzzzzzzzs_);

                return fzzzzzzzzt_ ?? false;
            };
            bool czzzzzzzzk_()
            {
                CqlCode fzzzzzzzzu_ = this.Every_three_to_six_hours__qualifier_value_(context);
                bool? fzzzzzzzzv_ = context.Operators.Equivalent(frequency, fzzzzzzzzu_);

                return fzzzzzzzzv_ ?? false;
            };
            bool czzzzzzzzl_()
            {
                CqlCode fzzzzzzzzw_ = this.Every_two_to_four_hours__qualifier_value_(context);
                bool? fzzzzzzzzx_ = context.Operators.Equivalent(frequency, fzzzzzzzzw_);

                return fzzzzzzzzx_ ?? false;
            };
            bool czzzzzzzzm_()
            {
                CqlCode fzzzzzzzzy_ = this.One_to_four_times_a_day__qualifier_value_(context);
                bool? fzzzzzzzzz_ = context.Operators.Equivalent(frequency, fzzzzzzzzy_);

                return fzzzzzzzzz_ ?? false;
            };
            bool czzzzzzzzn_()
            {
                CqlCode gzzzzzzzza_ = this.One_to_three_times_a_day__qualifier_value_(context);
                bool? gzzzzzzzzb_ = context.Operators.Equivalent(frequency, gzzzzzzzza_);

                return gzzzzzzzzb_ ?? false;
            };
            bool czzzzzzzzo_()
            {
                CqlCode gzzzzzzzzc_ = this.One_to_two_times_a_day__qualifier_value_(context);
                bool? gzzzzzzzzd_ = context.Operators.Equivalent(frequency, gzzzzzzzzc_);

                return gzzzzzzzzd_ ?? false;
            };
            bool czzzzzzzzp_()
            {
                CqlCode gzzzzzzzze_ = this.Two_to_four_times_a_day__qualifier_value_(context);
                bool? gzzzzzzzzf_ = context.Operators.Equivalent(frequency, gzzzzzzzze_);

                return gzzzzzzzzf_ ?? false;
            };
            if (azzzzzzzzv_())
            {
                decimal? gzzzzzzzzg_ = context.Operators.ConvertIntegerToDecimal(1);

                return gzzzzzzzzg_;
            }
            else if (azzzzzzzzw_())
            {
                decimal? gzzzzzzzzh_ = context.Operators.ConvertIntegerToDecimal(1);

                return gzzzzzzzzh_;
            }
            else if (azzzzzzzzx_())
            {
                decimal? gzzzzzzzzi_ = context.Operators.ConvertIntegerToDecimal(3);

                return gzzzzzzzzi_;
            }
            else if (azzzzzzzzy_())
            {
                decimal? gzzzzzzzzj_ = context.Operators.ConvertIntegerToDecimal(1);

                return gzzzzzzzzj_;
            }
            else if (azzzzzzzzz_())
            {
                decimal? gzzzzzzzzk_ = context.Operators.ConvertIntegerToDecimal(1);

                return gzzzzzzzzk_;
            }
            else if (bzzzzzzzza_())
            {
                decimal? gzzzzzzzzl_ = context.Operators.ConvertIntegerToDecimal(1);

                return gzzzzzzzzl_;
            }
            else if (bzzzzzzzzb_())
            {
                decimal? gzzzzzzzzm_ = context.Operators.ConvertIntegerToDecimal(3);

                return gzzzzzzzzm_;
            }
            else if (bzzzzzzzzc_())
            {
                decimal? gzzzzzzzzn_ = context.Operators.ConvertIntegerToDecimal(1);

                return gzzzzzzzzn_;
            }
            else if (bzzzzzzzzd_())
            {
                decimal? gzzzzzzzzo_ = context.Operators.ConvertIntegerToDecimal(1);

                return gzzzzzzzzo_;
            }
            else if (bzzzzzzzze_())
            {
                decimal? gzzzzzzzzp_ = context.Operators.ConvertIntegerToDecimal(1);

                return gzzzzzzzzp_;
            }
            else if (bzzzzzzzzf_())
            {
                decimal? gzzzzzzzzq_ = context.Operators.ConvertIntegerToDecimal(3);

                return gzzzzzzzzq_;
            }
            else if (bzzzzzzzzg_())
            {
                decimal? gzzzzzzzzr_ = context.Operators.ConvertIntegerToDecimal(1);

                return gzzzzzzzzr_;
            }
            else if (bzzzzzzzzh_())
            {
                decimal? gzzzzzzzzs_ = context.Operators.ConvertIntegerToDecimal(1);

                return gzzzzzzzzs_;
            }
            else if (bzzzzzzzzi_())
            {
                decimal? gzzzzzzzzt_ = context.Operators.ConvertIntegerToDecimal(1);

                return gzzzzzzzzt_;
            }
            else if (bzzzzzzzzj_())
            {
                decimal? gzzzzzzzzu_ = context.Operators.ConvertIntegerToDecimal(1);

                return gzzzzzzzzu_;
            }
            else if (bzzzzzzzzk_())
            {
                decimal? gzzzzzzzzv_ = context.Operators.ConvertIntegerToDecimal(1);

                return gzzzzzzzzv_;
            }
            else if (bzzzzzzzzl_())
            {
                decimal? gzzzzzzzzw_ = context.Operators.ConvertIntegerToDecimal(1);

                return gzzzzzzzzw_;
            }
            else if (bzzzzzzzzm_())
            {
                decimal? gzzzzzzzzx_ = context.Operators.ConvertIntegerToDecimal(1);

                return gzzzzzzzzx_;
            }
            else if (bzzzzzzzzn_())
            {
                decimal? gzzzzzzzzy_ = context.Operators.ConvertIntegerToDecimal(1);

                return gzzzzzzzzy_;
            }
            else if (bzzzzzzzzo_())
            {
                decimal? gzzzzzzzzz_ = context.Operators.ConvertIntegerToDecimal(1);

                return gzzzzzzzzz_;
            }
            else if (bzzzzzzzzp_())
            {
                decimal? hzzzzzzzza_ = context.Operators.ConvertIntegerToDecimal(1);

                return hzzzzzzzza_;
            }
            else if (bzzzzzzzzq_())
            {
                decimal? hzzzzzzzzb_ = context.Operators.ConvertIntegerToDecimal(1);

                return hzzzzzzzzb_;
            }
            else if (bzzzzzzzzr_())
            {
                decimal? hzzzzzzzzc_ = context.Operators.ConvertIntegerToDecimal(1);

                return hzzzzzzzzc_;
            }
            else if (bzzzzzzzzs_())
            {
                decimal? hzzzzzzzzd_ = context.Operators.ConvertIntegerToDecimal(1);

                return hzzzzzzzzd_;
            }
            else if (bzzzzzzzzt_())
            {
                decimal? hzzzzzzzze_ = context.Operators.ConvertIntegerToDecimal(1);

                return hzzzzzzzze_;
            }
            else if (bzzzzzzzzu_())
            {
                decimal? hzzzzzzzzf_ = context.Operators.ConvertIntegerToDecimal(1);

                return hzzzzzzzzf_;
            }
            else if (bzzzzzzzzv_())
            {
                return 1.0m;
            }
            else if (bzzzzzzzzw_())
            {
                return 2.0m;
            }
            else if (bzzzzzzzzx_())
            {
                return 3.0m;
            }
            else if (bzzzzzzzzy_())
            {
                return 4.0m;
            }
            else if (bzzzzzzzzz_())
            {
                return 1.0m;
            }
            else if (czzzzzzzza_())
            {
                return 2.0m;
            }
            else if (czzzzzzzzb_())
            {
                return 0.67m;
            }
            else if (czzzzzzzzc_())
            {
                return 3.0m;
            }
            else if (czzzzzzzzd_())
            {
                return 6.0m;
            }
            else if (czzzzzzzze_())
            {
                return 4.0m;
            }
            else if (czzzzzzzzf_())
            {
                return 0.33m;
            }
            else if (czzzzzzzzg_())
            {
                return 0.5m;
            }
            else if (czzzzzzzzh_())
            {
                return 3.0m;
            }
            else if (czzzzzzzzi_())
            {
                return 4.0m;
            }
            else if (czzzzzzzzj_())
            {
                return 8.0m;
            }
            else if (czzzzzzzzk_())
            {
                return 8.0m;
            }
            else if (czzzzzzzzl_())
            {
                return 12.0m;
            }
            else if (czzzzzzzzm_())
            {
                return 4.0m;
            }
            else if (czzzzzzzzn_())
            {
                return 3.0m;
            }
            else if (czzzzzzzzo_())
            {
                return 2.0m;
            }
            else if (czzzzzzzzp_())
            {
                return 4.0m;
            }
            else
            {
                string hzzzzzzzzg_ = this.ErrorLevel(context);
                string hzzzzzzzzh_ = frequency?.code;
                string hzzzzzzzzi_ = context.Operators.Concatenate("Unknown frequency code ", hzzzzzzzzh_ ?? "");
                object hzzzzzzzzj_ = context.Operators.Message<object>(null, "CMDLogic.ToDaily.UnknownFrequencyCode", hzzzzzzzzg_, hzzzzzzzzi_);

                return hzzzzzzzzj_ as decimal?;
            }
        };

        return azzzzzzzzu_();
    }


    [CqlExpressionDefinition("Quantity")]
    public CqlQuantity Quantity(CqlContext context, decimal? value, string unit) =>
        ((context.Operators.Not((bool?)(value is null))) ?? false
            ? new CqlQuantity(value, unit)
            : default);


    [CqlExpressionDefinition("MedicationRequestPeriod")]
    public CqlInterval<CqlDate> MedicationRequestPeriod(CqlContext context, MedicationRequest Request)
    {
        MedicationRequest[] hzzzzzzzzk_ = [
            Request,
        ];
        CqlInterval<CqlDate> hzzzzzzzzl_(MedicationRequest R)
        {
            CqlInterval<CqlDate> hzzzzzzzzp_()
            {
                bool hzzzzzzzzq_()
                {
                    List<Dosage> hzzzzzzzzs_ = R?.DosageInstruction;
                    Dosage hzzzzzzzzt_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)hzzzzzzzzs_);
                    Timing hzzzzzzzzu_ = hzzzzzzzzt_?.Timing;
                    Timing.RepeatComponent hzzzzzzzzv_ = hzzzzzzzzu_?.Repeat;
                    DataType hzzzzzzzzw_ = hzzzzzzzzv_?.Bounds;
                    object hzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzw_);
                    CqlDateTime hzzzzzzzzy_ = context.Operators.Start(hzzzzzzzzx_ as CqlInterval<CqlDateTime>);
                    CqlDate hzzzzzzzzz_ = context.Operators.DateFrom(hzzzzzzzzy_);
                    FhirDateTime izzzzzzzza_ = R?.AuthoredOnElement;
                    CqlDateTime izzzzzzzzb_ = context.Operators.Convert<CqlDateTime>(izzzzzzzza_);
                    CqlDate izzzzzzzzc_ = context.Operators.DateFrom(izzzzzzzzb_);
                    MedicationRequest.DispenseRequestComponent izzzzzzzzd_ = R?.DispenseRequest;
                    Period izzzzzzzze_ = izzzzzzzzd_?.ValidityPeriod;
                    CqlInterval<CqlDateTime> izzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzzze_);
                    CqlDateTime izzzzzzzzg_ = context.Operators.Start(izzzzzzzzf_);
                    CqlDate izzzzzzzzh_ = context.Operators.DateFrom(izzzzzzzzg_);
                    bool? izzzzzzzzi_ = context.Operators.Not((bool?)(((hzzzzzzzzz_ ?? izzzzzzzzc_) ?? izzzzzzzzh_) is null));
                    Duration izzzzzzzzk_ = izzzzzzzzd_?.ExpectedSupplyDuration;
                    CqlQuantity izzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, izzzzzzzzk_);
                    CqlQuantity izzzzzzzzm_ = context.Operators.ConvertQuantity(izzzzzzzzl_, "d");
                    decimal? izzzzzzzzn_ = izzzzzzzzm_?.value;
                    Quantity izzzzzzzzp_ = izzzzzzzzd_?.Quantity;
                    CqlQuantity izzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, izzzzzzzzp_);
                    decimal? izzzzzzzzr_ = izzzzzzzzq_?.value;
                    Dosage izzzzzzzzt_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)hzzzzzzzzs_);
                    List<Dosage.DoseAndRateComponent> izzzzzzzzu_ = izzzzzzzzt_?.DoseAndRate;
                    Dosage.DoseAndRateComponent izzzzzzzzv_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)izzzzzzzzu_);
                    DataType izzzzzzzzw_ = izzzzzzzzv_?.Dose;
                    object izzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzw_);
                    CqlQuantity izzzzzzzzy_ = context.Operators.End(izzzzzzzzx_ as CqlInterval<CqlQuantity>);
                    Dosage jzzzzzzzza_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)hzzzzzzzzs_);
                    List<Dosage.DoseAndRateComponent> jzzzzzzzzb_ = jzzzzzzzza_?.DoseAndRate;
                    Dosage.DoseAndRateComponent jzzzzzzzzc_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)jzzzzzzzzb_);
                    DataType jzzzzzzzzd_ = jzzzzzzzzc_?.Dose;
                    object jzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzd_);
                    decimal? jzzzzzzzzf_ = (izzzzzzzzy_ ?? jzzzzzzzze_ as CqlQuantity)?.value;
                    Dosage jzzzzzzzzh_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)hzzzzzzzzs_);
                    Timing jzzzzzzzzi_ = jzzzzzzzzh_?.Timing;
                    Timing.RepeatComponent jzzzzzzzzj_ = jzzzzzzzzi_?.Repeat;
                    PositiveInt jzzzzzzzzk_ = jzzzzzzzzj_?.FrequencyMaxElement;
                    int? jzzzzzzzzl_ = jzzzzzzzzk_?.Value;
                    Dosage jzzzzzzzzn_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)hzzzzzzzzs_);
                    Timing jzzzzzzzzo_ = jzzzzzzzzn_?.Timing;
                    Timing.RepeatComponent jzzzzzzzzp_ = jzzzzzzzzo_?.Repeat;
                    PositiveInt jzzzzzzzzq_ = jzzzzzzzzp_?.FrequencyElement;
                    int? jzzzzzzzzr_ = jzzzzzzzzq_?.Value;
                    Dosage jzzzzzzzzt_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)hzzzzzzzzs_);
                    Timing jzzzzzzzzu_ = jzzzzzzzzt_?.Timing;
                    Timing.RepeatComponent jzzzzzzzzv_ = jzzzzzzzzu_?.Repeat;
                    FhirDecimal jzzzzzzzzw_ = jzzzzzzzzv_?.PeriodElement;
                    decimal? jzzzzzzzzx_ = jzzzzzzzzw_?.Value;
                    Dosage jzzzzzzzzz_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)hzzzzzzzzs_);
                    Timing kzzzzzzzza_ = jzzzzzzzzz_?.Timing;
                    Timing.RepeatComponent kzzzzzzzzb_ = kzzzzzzzza_?.Repeat;
                    Code<Timing.UnitsOfTime> kzzzzzzzzc_ = kzzzzzzzzb_?.PeriodUnitElement;
                    Timing.UnitsOfTime? kzzzzzzzzd_ = kzzzzzzzzc_?.Value;
                    string kzzzzzzzze_ = context.Operators.Convert<string>(kzzzzzzzzd_);
                    CqlQuantity kzzzzzzzzf_ = this.Quantity(context, jzzzzzzzzx_, kzzzzzzzze_);
                    decimal? kzzzzzzzzg_ = this.ToDaily(context, jzzzzzzzzl_ ?? jzzzzzzzzr_, kzzzzzzzzf_);
                    Dosage kzzzzzzzzi_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)hzzzzzzzzs_);
                    Timing kzzzzzzzzj_ = kzzzzzzzzi_?.Timing;
                    Timing.RepeatComponent kzzzzzzzzk_ = kzzzzzzzzj_?.Repeat;
                    List<Time> kzzzzzzzzl_ = kzzzzzzzzk_?.TimeOfDayElement;
                    IEnumerable<CqlTime> kzzzzzzzzm_ = context.Operators.LateBoundProperty<IEnumerable<CqlTime>>(kzzzzzzzzl_, "value");
                    int? kzzzzzzzzn_ = context.Operators.Count<CqlTime>(kzzzzzzzzm_);
                    decimal? kzzzzzzzzo_ = context.Operators.ConvertIntegerToDecimal(kzzzzzzzzn_);
                    decimal? kzzzzzzzzp_ = context.Operators.Multiply(jzzzzzzzzf_, (kzzzzzzzzg_ ?? kzzzzzzzzo_) ?? 1.0m);
                    decimal? kzzzzzzzzq_ = context.Operators.Divide(izzzzzzzzr_, kzzzzzzzzp_);
                    UnsignedInt kzzzzzzzzs_ = izzzzzzzzd_?.NumberOfRepeatsAllowedElement;
                    int? kzzzzzzzzt_ = kzzzzzzzzs_?.Value;
                    int? kzzzzzzzzu_ = context.Operators.Add(1, kzzzzzzzzt_ ?? 0);
                    decimal? kzzzzzzzzv_ = context.Operators.ConvertIntegerToDecimal(kzzzzzzzzu_);
                    decimal? kzzzzzzzzw_ = context.Operators.Multiply(izzzzzzzzn_ ?? kzzzzzzzzq_, kzzzzzzzzv_);
                    bool? kzzzzzzzzx_ = context.Operators.Not((bool?)(kzzzzzzzzw_ is null));
                    bool? kzzzzzzzzy_ = context.Operators.And(izzzzzzzzi_, kzzzzzzzzx_);

                    return kzzzzzzzzy_ ?? false;
                };
                bool hzzzzzzzzr_()
                {
                    List<Dosage> kzzzzzzzzz_ = R?.DosageInstruction;
                    Dosage lzzzzzzzza_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)kzzzzzzzzz_);
                    Timing lzzzzzzzzb_ = lzzzzzzzza_?.Timing;
                    Timing.RepeatComponent lzzzzzzzzc_ = lzzzzzzzzb_?.Repeat;
                    DataType lzzzzzzzzd_ = lzzzzzzzzc_?.Bounds;
                    object lzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzd_);
                    CqlDateTime lzzzzzzzzf_ = context.Operators.Start(lzzzzzzzze_ as CqlInterval<CqlDateTime>);
                    CqlDate lzzzzzzzzg_ = context.Operators.DateFrom(lzzzzzzzzf_);
                    FhirDateTime lzzzzzzzzh_ = R?.AuthoredOnElement;
                    CqlDateTime lzzzzzzzzi_ = context.Operators.Convert<CqlDateTime>(lzzzzzzzzh_);
                    CqlDate lzzzzzzzzj_ = context.Operators.DateFrom(lzzzzzzzzi_);
                    MedicationRequest.DispenseRequestComponent lzzzzzzzzk_ = R?.DispenseRequest;
                    Period lzzzzzzzzl_ = lzzzzzzzzk_?.ValidityPeriod;
                    CqlInterval<CqlDateTime> lzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzzzl_);
                    CqlDateTime lzzzzzzzzn_ = context.Operators.Start(lzzzzzzzzm_);
                    CqlDate lzzzzzzzzo_ = context.Operators.DateFrom(lzzzzzzzzn_);
                    bool? lzzzzzzzzp_ = context.Operators.Not((bool?)(((lzzzzzzzzg_ ?? lzzzzzzzzj_) ?? lzzzzzzzzo_) is null));
                    Dosage lzzzzzzzzr_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)kzzzzzzzzz_);
                    Timing lzzzzzzzzs_ = lzzzzzzzzr_?.Timing;
                    Timing.RepeatComponent lzzzzzzzzt_ = lzzzzzzzzs_?.Repeat;
                    DataType lzzzzzzzzu_ = lzzzzzzzzt_?.Bounds;
                    object lzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzu_);
                    CqlDateTime lzzzzzzzzw_ = (lzzzzzzzzv_ as CqlInterval<CqlDateTime>)?.high;
                    bool? lzzzzzzzzx_ = context.Operators.Not((bool?)(lzzzzzzzzw_ is null));
                    bool? lzzzzzzzzy_ = context.Operators.And(lzzzzzzzzp_, lzzzzzzzzx_);

                    return lzzzzzzzzy_ ?? false;
                };
                if (hzzzzzzzzq_())
                {
                    List<Dosage> lzzzzzzzzz_ = R?.DosageInstruction;
                    Dosage mzzzzzzzza_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)lzzzzzzzzz_);
                    Timing mzzzzzzzzb_ = mzzzzzzzza_?.Timing;
                    Timing.RepeatComponent mzzzzzzzzc_ = mzzzzzzzzb_?.Repeat;
                    DataType mzzzzzzzzd_ = mzzzzzzzzc_?.Bounds;
                    object mzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzd_);
                    CqlDateTime mzzzzzzzzf_ = context.Operators.Start(mzzzzzzzze_ as CqlInterval<CqlDateTime>);
                    CqlDate mzzzzzzzzg_ = context.Operators.DateFrom(mzzzzzzzzf_);
                    FhirDateTime mzzzzzzzzh_ = R?.AuthoredOnElement;
                    CqlDateTime mzzzzzzzzi_ = context.Operators.Convert<CqlDateTime>(mzzzzzzzzh_);
                    CqlDate mzzzzzzzzj_ = context.Operators.DateFrom(mzzzzzzzzi_);
                    MedicationRequest.DispenseRequestComponent mzzzzzzzzk_ = R?.DispenseRequest;
                    Period mzzzzzzzzl_ = mzzzzzzzzk_?.ValidityPeriod;
                    CqlInterval<CqlDateTime> mzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzzzl_);
                    CqlDateTime mzzzzzzzzn_ = context.Operators.Start(mzzzzzzzzm_);
                    CqlDate mzzzzzzzzo_ = context.Operators.DateFrom(mzzzzzzzzn_);
                    Dosage mzzzzzzzzq_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)lzzzzzzzzz_);
                    Timing mzzzzzzzzr_ = mzzzzzzzzq_?.Timing;
                    Timing.RepeatComponent mzzzzzzzzs_ = mzzzzzzzzr_?.Repeat;
                    DataType mzzzzzzzzt_ = mzzzzzzzzs_?.Bounds;
                    object mzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzt_);
                    CqlDateTime mzzzzzzzzv_ = context.Operators.Start(mzzzzzzzzu_ as CqlInterval<CqlDateTime>);
                    CqlDate mzzzzzzzzw_ = context.Operators.DateFrom(mzzzzzzzzv_);
                    CqlDateTime mzzzzzzzzy_ = context.Operators.Convert<CqlDateTime>(mzzzzzzzzh_);
                    CqlDate mzzzzzzzzz_ = context.Operators.DateFrom(mzzzzzzzzy_);
                    Period nzzzzzzzzb_ = mzzzzzzzzk_?.ValidityPeriod;
                    CqlInterval<CqlDateTime> nzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzzzzb_);
                    CqlDateTime nzzzzzzzzd_ = context.Operators.Start(nzzzzzzzzc_);
                    CqlDate nzzzzzzzze_ = context.Operators.DateFrom(nzzzzzzzzd_);
                    Duration nzzzzzzzzg_ = mzzzzzzzzk_?.ExpectedSupplyDuration;
                    CqlQuantity nzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, nzzzzzzzzg_);
                    CqlQuantity nzzzzzzzzi_ = context.Operators.ConvertQuantity(nzzzzzzzzh_, "d");
                    decimal? nzzzzzzzzj_ = nzzzzzzzzi_?.value;
                    Quantity nzzzzzzzzl_ = mzzzzzzzzk_?.Quantity;
                    CqlQuantity nzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, nzzzzzzzzl_);
                    decimal? nzzzzzzzzn_ = nzzzzzzzzm_?.value;
                    Dosage nzzzzzzzzp_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)lzzzzzzzzz_);
                    List<Dosage.DoseAndRateComponent> nzzzzzzzzq_ = nzzzzzzzzp_?.DoseAndRate;
                    Dosage.DoseAndRateComponent nzzzzzzzzr_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)nzzzzzzzzq_);
                    DataType nzzzzzzzzs_ = nzzzzzzzzr_?.Dose;
                    object nzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzs_);
                    CqlQuantity nzzzzzzzzu_ = context.Operators.End(nzzzzzzzzt_ as CqlInterval<CqlQuantity>);
                    Dosage nzzzzzzzzw_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)lzzzzzzzzz_);
                    List<Dosage.DoseAndRateComponent> nzzzzzzzzx_ = nzzzzzzzzw_?.DoseAndRate;
                    Dosage.DoseAndRateComponent nzzzzzzzzy_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)nzzzzzzzzx_);
                    DataType nzzzzzzzzz_ = nzzzzzzzzy_?.Dose;
                    object ozzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzz_);
                    decimal? ozzzzzzzzb_ = (nzzzzzzzzu_ ?? ozzzzzzzza_ as CqlQuantity)?.value;
                    Dosage ozzzzzzzzd_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)lzzzzzzzzz_);
                    Timing ozzzzzzzze_ = ozzzzzzzzd_?.Timing;
                    Timing.RepeatComponent ozzzzzzzzf_ = ozzzzzzzze_?.Repeat;
                    PositiveInt ozzzzzzzzg_ = ozzzzzzzzf_?.FrequencyMaxElement;
                    int? ozzzzzzzzh_ = ozzzzzzzzg_?.Value;
                    Dosage ozzzzzzzzj_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)lzzzzzzzzz_);
                    Timing ozzzzzzzzk_ = ozzzzzzzzj_?.Timing;
                    Timing.RepeatComponent ozzzzzzzzl_ = ozzzzzzzzk_?.Repeat;
                    PositiveInt ozzzzzzzzm_ = ozzzzzzzzl_?.FrequencyElement;
                    int? ozzzzzzzzn_ = ozzzzzzzzm_?.Value;
                    Dosage ozzzzzzzzp_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)lzzzzzzzzz_);
                    Timing ozzzzzzzzq_ = ozzzzzzzzp_?.Timing;
                    Timing.RepeatComponent ozzzzzzzzr_ = ozzzzzzzzq_?.Repeat;
                    FhirDecimal ozzzzzzzzs_ = ozzzzzzzzr_?.PeriodElement;
                    decimal? ozzzzzzzzt_ = ozzzzzzzzs_?.Value;
                    Dosage ozzzzzzzzv_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)lzzzzzzzzz_);
                    Timing ozzzzzzzzw_ = ozzzzzzzzv_?.Timing;
                    Timing.RepeatComponent ozzzzzzzzx_ = ozzzzzzzzw_?.Repeat;
                    Code<Timing.UnitsOfTime> ozzzzzzzzy_ = ozzzzzzzzx_?.PeriodUnitElement;
                    Timing.UnitsOfTime? ozzzzzzzzz_ = ozzzzzzzzy_?.Value;
                    string pzzzzzzzza_ = context.Operators.Convert<string>(ozzzzzzzzz_);
                    CqlQuantity pzzzzzzzzb_ = this.Quantity(context, ozzzzzzzzt_, pzzzzzzzza_);
                    decimal? pzzzzzzzzc_ = this.ToDaily(context, ozzzzzzzzh_ ?? ozzzzzzzzn_, pzzzzzzzzb_);
                    Dosage pzzzzzzzze_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)lzzzzzzzzz_);
                    Timing pzzzzzzzzf_ = pzzzzzzzze_?.Timing;
                    Timing.RepeatComponent pzzzzzzzzg_ = pzzzzzzzzf_?.Repeat;
                    List<Time> pzzzzzzzzh_ = pzzzzzzzzg_?.TimeOfDayElement;
                    IEnumerable<CqlTime> pzzzzzzzzi_ = context.Operators.LateBoundProperty<IEnumerable<CqlTime>>(pzzzzzzzzh_, "value");
                    int? pzzzzzzzzj_ = context.Operators.Count<CqlTime>(pzzzzzzzzi_);
                    decimal? pzzzzzzzzk_ = context.Operators.ConvertIntegerToDecimal(pzzzzzzzzj_);
                    decimal? pzzzzzzzzl_ = context.Operators.Multiply(ozzzzzzzzb_, (pzzzzzzzzc_ ?? pzzzzzzzzk_) ?? 1.0m);
                    decimal? pzzzzzzzzm_ = context.Operators.Divide(nzzzzzzzzn_, pzzzzzzzzl_);
                    UnsignedInt pzzzzzzzzo_ = mzzzzzzzzk_?.NumberOfRepeatsAllowedElement;
                    int? pzzzzzzzzp_ = pzzzzzzzzo_?.Value;
                    int? pzzzzzzzzq_ = context.Operators.Add(1, pzzzzzzzzp_ ?? 0);
                    decimal? pzzzzzzzzr_ = context.Operators.ConvertIntegerToDecimal(pzzzzzzzzq_);
                    decimal? pzzzzzzzzs_ = context.Operators.Multiply(nzzzzzzzzj_ ?? pzzzzzzzzm_, pzzzzzzzzr_);
                    decimal? pzzzzzzzzt_ = context.Operators.ConvertIntegerToDecimal(1);
                    decimal? pzzzzzzzzu_ = context.Operators.Subtract(pzzzzzzzzs_, pzzzzzzzzt_);
                    CqlQuantity pzzzzzzzzv_ = this.Quantity(context, pzzzzzzzzu_, "day");
                    CqlDate pzzzzzzzzw_ = context.Operators.Add((mzzzzzzzzw_ ?? mzzzzzzzzz_) ?? nzzzzzzzze_, pzzzzzzzzv_);
                    CqlInterval<CqlDate> pzzzzzzzzx_ = context.Operators.Interval((mzzzzzzzzg_ ?? mzzzzzzzzj_) ?? mzzzzzzzzo_, pzzzzzzzzw_, true, true);

                    return pzzzzzzzzx_;
                }
                else if (hzzzzzzzzr_())
                {
                    List<Dosage> pzzzzzzzzy_ = R?.DosageInstruction;
                    Dosage pzzzzzzzzz_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)pzzzzzzzzy_);
                    Timing qzzzzzzzza_ = pzzzzzzzzz_?.Timing;
                    Timing.RepeatComponent qzzzzzzzzb_ = qzzzzzzzza_?.Repeat;
                    DataType qzzzzzzzzc_ = qzzzzzzzzb_?.Bounds;
                    object qzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzc_);
                    CqlDateTime qzzzzzzzze_ = context.Operators.Start(qzzzzzzzzd_ as CqlInterval<CqlDateTime>);
                    CqlDate qzzzzzzzzf_ = context.Operators.DateFrom(qzzzzzzzze_);
                    FhirDateTime qzzzzzzzzg_ = R?.AuthoredOnElement;
                    CqlDateTime qzzzzzzzzh_ = context.Operators.Convert<CqlDateTime>(qzzzzzzzzg_);
                    CqlDate qzzzzzzzzi_ = context.Operators.DateFrom(qzzzzzzzzh_);
                    MedicationRequest.DispenseRequestComponent qzzzzzzzzj_ = R?.DispenseRequest;
                    Period qzzzzzzzzk_ = qzzzzzzzzj_?.ValidityPeriod;
                    CqlInterval<CqlDateTime> qzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzzzzk_);
                    CqlDateTime qzzzzzzzzm_ = context.Operators.Start(qzzzzzzzzl_);
                    CqlDate qzzzzzzzzn_ = context.Operators.DateFrom(qzzzzzzzzm_);
                    Dosage qzzzzzzzzp_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)pzzzzzzzzy_);
                    Timing qzzzzzzzzq_ = qzzzzzzzzp_?.Timing;
                    Timing.RepeatComponent qzzzzzzzzr_ = qzzzzzzzzq_?.Repeat;
                    DataType qzzzzzzzzs_ = qzzzzzzzzr_?.Bounds;
                    object qzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzs_);
                    CqlDateTime qzzzzzzzzu_ = context.Operators.End(qzzzzzzzzt_ as CqlInterval<CqlDateTime>);
                    CqlDate qzzzzzzzzv_ = context.Operators.DateFrom(qzzzzzzzzu_);
                    CqlInterval<CqlDate> qzzzzzzzzw_ = context.Operators.Interval((qzzzzzzzzf_ ?? qzzzzzzzzi_) ?? qzzzzzzzzn_, qzzzzzzzzv_, true, true);

                    return qzzzzzzzzw_;
                }
                else
                {
                    return null as CqlInterval<CqlDate>;
                }
            };

            return hzzzzzzzzp_();
        };
        IEnumerable<CqlInterval<CqlDate>> hzzzzzzzzm_ = context.Operators.Select<MedicationRequest, CqlInterval<CqlDate>>((IEnumerable<MedicationRequest>)hzzzzzzzzk_, hzzzzzzzzl_);
        IEnumerable<CqlInterval<CqlDate>> hzzzzzzzzn_ = context.Operators.Distinct<CqlInterval<CqlDate>>(hzzzzzzzzm_);
        CqlInterval<CqlDate> hzzzzzzzzo_ = context.Operators.SingletonFrom<CqlInterval<CqlDate>>(hzzzzzzzzn_);

        return hzzzzzzzzo_;
    }


    [CqlExpressionDefinition("medicationRequestPeriod")]
    public CqlInterval<CqlDate> medicationRequestPeriod(CqlContext context, MedicationRequest Request)
    {
        MedicationRequest[] qzzzzzzzzx_ = [
            Request,
        ];
        CqlInterval<CqlDate> qzzzzzzzzy_(MedicationRequest R)
        {
            CqlInterval<CqlDate> rzzzzzzzzc_()
            {
                bool rzzzzzzzzd_()
                {
                    List<Dosage> rzzzzzzzzf_ = R?.DosageInstruction;
                    Dosage rzzzzzzzzg_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)rzzzzzzzzf_);
                    Timing rzzzzzzzzh_ = rzzzzzzzzg_?.Timing;
                    Timing.RepeatComponent rzzzzzzzzi_ = rzzzzzzzzh_?.Repeat;
                    DataType rzzzzzzzzj_ = rzzzzzzzzi_?.Bounds;
                    object rzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzj_);
                    CqlDateTime rzzzzzzzzl_ = context.Operators.Start(rzzzzzzzzk_ as CqlInterval<CqlDateTime>);
                    CqlDate rzzzzzzzzm_ = context.Operators.DateFrom(rzzzzzzzzl_);
                    FhirDateTime rzzzzzzzzn_ = R?.AuthoredOnElement;
                    CqlDateTime rzzzzzzzzo_ = context.Operators.Convert<CqlDateTime>(rzzzzzzzzn_);
                    CqlDate rzzzzzzzzp_ = context.Operators.DateFrom(rzzzzzzzzo_);
                    MedicationRequest.DispenseRequestComponent rzzzzzzzzq_ = R?.DispenseRequest;
                    Period rzzzzzzzzr_ = rzzzzzzzzq_?.ValidityPeriod;
                    CqlInterval<CqlDateTime> rzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzzzr_);
                    CqlDateTime rzzzzzzzzt_ = context.Operators.Start(rzzzzzzzzs_);
                    CqlDate rzzzzzzzzu_ = context.Operators.DateFrom(rzzzzzzzzt_);
                    bool? rzzzzzzzzv_ = context.Operators.Not((bool?)(((rzzzzzzzzm_ ?? rzzzzzzzzp_) ?? rzzzzzzzzu_) is null));
                    Duration rzzzzzzzzx_ = rzzzzzzzzq_?.ExpectedSupplyDuration;
                    CqlQuantity rzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, rzzzzzzzzx_);
                    CqlQuantity rzzzzzzzzz_ = context.Operators.ConvertQuantity(rzzzzzzzzy_, "d");
                    decimal? szzzzzzzza_ = rzzzzzzzzz_?.value;
                    Quantity szzzzzzzzc_ = rzzzzzzzzq_?.Quantity;
                    CqlQuantity szzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, szzzzzzzzc_);
                    decimal? szzzzzzzze_ = szzzzzzzzd_?.value;
                    Dosage szzzzzzzzg_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)rzzzzzzzzf_);
                    List<Dosage.DoseAndRateComponent> szzzzzzzzh_ = szzzzzzzzg_?.DoseAndRate;
                    Dosage.DoseAndRateComponent szzzzzzzzi_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)szzzzzzzzh_);
                    DataType szzzzzzzzj_ = szzzzzzzzi_?.Dose;
                    object szzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzj_);
                    CqlQuantity szzzzzzzzl_ = context.Operators.End(szzzzzzzzk_ as CqlInterval<CqlQuantity>);
                    Dosage szzzzzzzzn_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)rzzzzzzzzf_);
                    List<Dosage.DoseAndRateComponent> szzzzzzzzo_ = szzzzzzzzn_?.DoseAndRate;
                    Dosage.DoseAndRateComponent szzzzzzzzp_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)szzzzzzzzo_);
                    DataType szzzzzzzzq_ = szzzzzzzzp_?.Dose;
                    object szzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzq_);
                    decimal? szzzzzzzzs_ = (szzzzzzzzl_ ?? szzzzzzzzr_ as CqlQuantity)?.value;
                    Dosage szzzzzzzzu_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)rzzzzzzzzf_);
                    Timing szzzzzzzzv_ = szzzzzzzzu_?.Timing;
                    Timing.RepeatComponent szzzzzzzzw_ = szzzzzzzzv_?.Repeat;
                    PositiveInt szzzzzzzzx_ = szzzzzzzzw_?.FrequencyMaxElement;
                    int? szzzzzzzzy_ = szzzzzzzzx_?.Value;
                    Dosage tzzzzzzzza_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)rzzzzzzzzf_);
                    Timing tzzzzzzzzb_ = tzzzzzzzza_?.Timing;
                    Timing.RepeatComponent tzzzzzzzzc_ = tzzzzzzzzb_?.Repeat;
                    PositiveInt tzzzzzzzzd_ = tzzzzzzzzc_?.FrequencyElement;
                    int? tzzzzzzzze_ = tzzzzzzzzd_?.Value;
                    Dosage tzzzzzzzzg_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)rzzzzzzzzf_);
                    Timing tzzzzzzzzh_ = tzzzzzzzzg_?.Timing;
                    Timing.RepeatComponent tzzzzzzzzi_ = tzzzzzzzzh_?.Repeat;
                    FhirDecimal tzzzzzzzzj_ = tzzzzzzzzi_?.PeriodElement;
                    decimal? tzzzzzzzzk_ = tzzzzzzzzj_?.Value;
                    Dosage tzzzzzzzzm_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)rzzzzzzzzf_);
                    Timing tzzzzzzzzn_ = tzzzzzzzzm_?.Timing;
                    Timing.RepeatComponent tzzzzzzzzo_ = tzzzzzzzzn_?.Repeat;
                    Code<Timing.UnitsOfTime> tzzzzzzzzp_ = tzzzzzzzzo_?.PeriodUnitElement;
                    Timing.UnitsOfTime? tzzzzzzzzq_ = tzzzzzzzzp_?.Value;
                    string tzzzzzzzzr_ = context.Operators.Convert<string>(tzzzzzzzzq_);
                    CqlQuantity tzzzzzzzzs_ = this.Quantity(context, tzzzzzzzzk_, tzzzzzzzzr_);
                    decimal? tzzzzzzzzt_ = this.ToDaily(context, szzzzzzzzy_ ?? tzzzzzzzze_, tzzzzzzzzs_);
                    Dosage tzzzzzzzzv_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)rzzzzzzzzf_);
                    Timing tzzzzzzzzw_ = tzzzzzzzzv_?.Timing;
                    Timing.RepeatComponent tzzzzzzzzx_ = tzzzzzzzzw_?.Repeat;
                    List<Time> tzzzzzzzzy_ = tzzzzzzzzx_?.TimeOfDayElement;
                    IEnumerable<CqlTime> tzzzzzzzzz_ = context.Operators.LateBoundProperty<IEnumerable<CqlTime>>(tzzzzzzzzy_, "value");
                    int? uzzzzzzzza_ = context.Operators.Count<CqlTime>(tzzzzzzzzz_);
                    decimal? uzzzzzzzzb_ = context.Operators.ConvertIntegerToDecimal(uzzzzzzzza_);
                    decimal? uzzzzzzzzc_ = context.Operators.Multiply(szzzzzzzzs_, (tzzzzzzzzt_ ?? uzzzzzzzzb_) ?? 1.0m);
                    decimal? uzzzzzzzzd_ = context.Operators.Divide(szzzzzzzze_, uzzzzzzzzc_);
                    UnsignedInt uzzzzzzzzf_ = rzzzzzzzzq_?.NumberOfRepeatsAllowedElement;
                    int? uzzzzzzzzg_ = uzzzzzzzzf_?.Value;
                    int? uzzzzzzzzh_ = context.Operators.Add(1, uzzzzzzzzg_ ?? 0);
                    decimal? uzzzzzzzzi_ = context.Operators.ConvertIntegerToDecimal(uzzzzzzzzh_);
                    decimal? uzzzzzzzzj_ = context.Operators.Multiply(szzzzzzzza_ ?? uzzzzzzzzd_, uzzzzzzzzi_);
                    bool? uzzzzzzzzk_ = context.Operators.Not((bool?)(uzzzzzzzzj_ is null));
                    bool? uzzzzzzzzl_ = context.Operators.And(rzzzzzzzzv_, uzzzzzzzzk_);

                    return uzzzzzzzzl_ ?? false;
                };
                bool rzzzzzzzze_()
                {
                    List<Dosage> uzzzzzzzzm_ = R?.DosageInstruction;
                    Dosage uzzzzzzzzn_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)uzzzzzzzzm_);
                    Timing uzzzzzzzzo_ = uzzzzzzzzn_?.Timing;
                    Timing.RepeatComponent uzzzzzzzzp_ = uzzzzzzzzo_?.Repeat;
                    DataType uzzzzzzzzq_ = uzzzzzzzzp_?.Bounds;
                    object uzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzq_);
                    CqlDateTime uzzzzzzzzs_ = context.Operators.Start(uzzzzzzzzr_ as CqlInterval<CqlDateTime>);
                    CqlDate uzzzzzzzzt_ = context.Operators.DateFrom(uzzzzzzzzs_);
                    FhirDateTime uzzzzzzzzu_ = R?.AuthoredOnElement;
                    CqlDateTime uzzzzzzzzv_ = context.Operators.Convert<CqlDateTime>(uzzzzzzzzu_);
                    CqlDate uzzzzzzzzw_ = context.Operators.DateFrom(uzzzzzzzzv_);
                    MedicationRequest.DispenseRequestComponent uzzzzzzzzx_ = R?.DispenseRequest;
                    Period uzzzzzzzzy_ = uzzzzzzzzx_?.ValidityPeriod;
                    CqlInterval<CqlDateTime> uzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzzzzy_);
                    CqlDateTime vzzzzzzzza_ = context.Operators.Start(uzzzzzzzzz_);
                    CqlDate vzzzzzzzzb_ = context.Operators.DateFrom(vzzzzzzzza_);
                    bool? vzzzzzzzzc_ = context.Operators.Not((bool?)(((uzzzzzzzzt_ ?? uzzzzzzzzw_) ?? vzzzzzzzzb_) is null));
                    Dosage vzzzzzzzze_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)uzzzzzzzzm_);
                    Timing vzzzzzzzzf_ = vzzzzzzzze_?.Timing;
                    Timing.RepeatComponent vzzzzzzzzg_ = vzzzzzzzzf_?.Repeat;
                    DataType vzzzzzzzzh_ = vzzzzzzzzg_?.Bounds;
                    object vzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzh_);
                    CqlDateTime vzzzzzzzzj_ = (vzzzzzzzzi_ as CqlInterval<CqlDateTime>)?.high;
                    bool? vzzzzzzzzk_ = context.Operators.Not((bool?)(vzzzzzzzzj_ is null));
                    bool? vzzzzzzzzl_ = context.Operators.And(vzzzzzzzzc_, vzzzzzzzzk_);

                    return vzzzzzzzzl_ ?? false;
                };
                if (rzzzzzzzzd_())
                {
                    List<Dosage> vzzzzzzzzm_ = R?.DosageInstruction;
                    Dosage vzzzzzzzzn_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)vzzzzzzzzm_);
                    Timing vzzzzzzzzo_ = vzzzzzzzzn_?.Timing;
                    Timing.RepeatComponent vzzzzzzzzp_ = vzzzzzzzzo_?.Repeat;
                    DataType vzzzzzzzzq_ = vzzzzzzzzp_?.Bounds;
                    object vzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzq_);
                    CqlDateTime vzzzzzzzzs_ = context.Operators.Start(vzzzzzzzzr_ as CqlInterval<CqlDateTime>);
                    CqlDate vzzzzzzzzt_ = context.Operators.DateFrom(vzzzzzzzzs_);
                    FhirDateTime vzzzzzzzzu_ = R?.AuthoredOnElement;
                    CqlDateTime vzzzzzzzzv_ = context.Operators.Convert<CqlDateTime>(vzzzzzzzzu_);
                    CqlDate vzzzzzzzzw_ = context.Operators.DateFrom(vzzzzzzzzv_);
                    MedicationRequest.DispenseRequestComponent vzzzzzzzzx_ = R?.DispenseRequest;
                    Period vzzzzzzzzy_ = vzzzzzzzzx_?.ValidityPeriod;
                    CqlInterval<CqlDateTime> vzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzzzzzy_);
                    CqlDateTime wzzzzzzzza_ = context.Operators.Start(vzzzzzzzzz_);
                    CqlDate wzzzzzzzzb_ = context.Operators.DateFrom(wzzzzzzzza_);
                    Dosage wzzzzzzzzd_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)vzzzzzzzzm_);
                    Timing wzzzzzzzze_ = wzzzzzzzzd_?.Timing;
                    Timing.RepeatComponent wzzzzzzzzf_ = wzzzzzzzze_?.Repeat;
                    DataType wzzzzzzzzg_ = wzzzzzzzzf_?.Bounds;
                    object wzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzg_);
                    CqlDateTime wzzzzzzzzi_ = context.Operators.Start(wzzzzzzzzh_ as CqlInterval<CqlDateTime>);
                    CqlDate wzzzzzzzzj_ = context.Operators.DateFrom(wzzzzzzzzi_);
                    CqlDateTime wzzzzzzzzl_ = context.Operators.Convert<CqlDateTime>(vzzzzzzzzu_);
                    CqlDate wzzzzzzzzm_ = context.Operators.DateFrom(wzzzzzzzzl_);
                    Period wzzzzzzzzo_ = vzzzzzzzzx_?.ValidityPeriod;
                    CqlInterval<CqlDateTime> wzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzzzzo_);
                    CqlDateTime wzzzzzzzzq_ = context.Operators.Start(wzzzzzzzzp_);
                    CqlDate wzzzzzzzzr_ = context.Operators.DateFrom(wzzzzzzzzq_);
                    Duration wzzzzzzzzt_ = vzzzzzzzzx_?.ExpectedSupplyDuration;
                    CqlQuantity wzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, wzzzzzzzzt_);
                    CqlQuantity wzzzzzzzzv_ = context.Operators.ConvertQuantity(wzzzzzzzzu_, "d");
                    decimal? wzzzzzzzzw_ = wzzzzzzzzv_?.value;
                    Quantity wzzzzzzzzy_ = vzzzzzzzzx_?.Quantity;
                    CqlQuantity wzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, wzzzzzzzzy_);
                    decimal? xzzzzzzzza_ = wzzzzzzzzz_?.value;
                    Dosage xzzzzzzzzc_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)vzzzzzzzzm_);
                    List<Dosage.DoseAndRateComponent> xzzzzzzzzd_ = xzzzzzzzzc_?.DoseAndRate;
                    Dosage.DoseAndRateComponent xzzzzzzzze_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)xzzzzzzzzd_);
                    DataType xzzzzzzzzf_ = xzzzzzzzze_?.Dose;
                    object xzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzf_);
                    CqlQuantity xzzzzzzzzh_ = context.Operators.End(xzzzzzzzzg_ as CqlInterval<CqlQuantity>);
                    Dosage xzzzzzzzzj_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)vzzzzzzzzm_);
                    List<Dosage.DoseAndRateComponent> xzzzzzzzzk_ = xzzzzzzzzj_?.DoseAndRate;
                    Dosage.DoseAndRateComponent xzzzzzzzzl_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)xzzzzzzzzk_);
                    DataType xzzzzzzzzm_ = xzzzzzzzzl_?.Dose;
                    object xzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzm_);
                    decimal? xzzzzzzzzo_ = (xzzzzzzzzh_ ?? xzzzzzzzzn_ as CqlQuantity)?.value;
                    Dosage xzzzzzzzzq_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)vzzzzzzzzm_);
                    Timing xzzzzzzzzr_ = xzzzzzzzzq_?.Timing;
                    Timing.RepeatComponent xzzzzzzzzs_ = xzzzzzzzzr_?.Repeat;
                    PositiveInt xzzzzzzzzt_ = xzzzzzzzzs_?.FrequencyMaxElement;
                    int? xzzzzzzzzu_ = xzzzzzzzzt_?.Value;
                    Dosage xzzzzzzzzw_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)vzzzzzzzzm_);
                    Timing xzzzzzzzzx_ = xzzzzzzzzw_?.Timing;
                    Timing.RepeatComponent xzzzzzzzzy_ = xzzzzzzzzx_?.Repeat;
                    PositiveInt xzzzzzzzzz_ = xzzzzzzzzy_?.FrequencyElement;
                    int? yzzzzzzzza_ = xzzzzzzzzz_?.Value;
                    Dosage yzzzzzzzzc_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)vzzzzzzzzm_);
                    Timing yzzzzzzzzd_ = yzzzzzzzzc_?.Timing;
                    Timing.RepeatComponent yzzzzzzzze_ = yzzzzzzzzd_?.Repeat;
                    FhirDecimal yzzzzzzzzf_ = yzzzzzzzze_?.PeriodElement;
                    decimal? yzzzzzzzzg_ = yzzzzzzzzf_?.Value;
                    Dosage yzzzzzzzzi_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)vzzzzzzzzm_);
                    Timing yzzzzzzzzj_ = yzzzzzzzzi_?.Timing;
                    Timing.RepeatComponent yzzzzzzzzk_ = yzzzzzzzzj_?.Repeat;
                    Code<Timing.UnitsOfTime> yzzzzzzzzl_ = yzzzzzzzzk_?.PeriodUnitElement;
                    Timing.UnitsOfTime? yzzzzzzzzm_ = yzzzzzzzzl_?.Value;
                    string yzzzzzzzzn_ = context.Operators.Convert<string>(yzzzzzzzzm_);
                    CqlQuantity yzzzzzzzzo_ = this.Quantity(context, yzzzzzzzzg_, yzzzzzzzzn_);
                    decimal? yzzzzzzzzp_ = this.ToDaily(context, xzzzzzzzzu_ ?? yzzzzzzzza_, yzzzzzzzzo_);
                    Dosage yzzzzzzzzr_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)vzzzzzzzzm_);
                    Timing yzzzzzzzzs_ = yzzzzzzzzr_?.Timing;
                    Timing.RepeatComponent yzzzzzzzzt_ = yzzzzzzzzs_?.Repeat;
                    List<Time> yzzzzzzzzu_ = yzzzzzzzzt_?.TimeOfDayElement;
                    IEnumerable<CqlTime> yzzzzzzzzv_ = context.Operators.LateBoundProperty<IEnumerable<CqlTime>>(yzzzzzzzzu_, "value");
                    int? yzzzzzzzzw_ = context.Operators.Count<CqlTime>(yzzzzzzzzv_);
                    decimal? yzzzzzzzzx_ = context.Operators.ConvertIntegerToDecimal(yzzzzzzzzw_);
                    decimal? yzzzzzzzzy_ = context.Operators.Multiply(xzzzzzzzzo_, (yzzzzzzzzp_ ?? yzzzzzzzzx_) ?? 1.0m);
                    decimal? yzzzzzzzzz_ = context.Operators.Divide(xzzzzzzzza_, yzzzzzzzzy_);
                    UnsignedInt zzzzzzzzzb_ = vzzzzzzzzx_?.NumberOfRepeatsAllowedElement;
                    int? zzzzzzzzzc_ = zzzzzzzzzb_?.Value;
                    int? zzzzzzzzzd_ = context.Operators.Add(1, zzzzzzzzzc_ ?? 0);
                    decimal? zzzzzzzzze_ = context.Operators.ConvertIntegerToDecimal(zzzzzzzzzd_);
                    decimal? zzzzzzzzzf_ = context.Operators.Multiply(wzzzzzzzzw_ ?? yzzzzzzzzz_, zzzzzzzzze_);
                    decimal? zzzzzzzzzg_ = context.Operators.ConvertIntegerToDecimal(1);
                    decimal? zzzzzzzzzh_ = context.Operators.Subtract(zzzzzzzzzf_, zzzzzzzzzg_);
                    CqlQuantity zzzzzzzzzi_ = this.Quantity(context, zzzzzzzzzh_, "day");
                    CqlDate zzzzzzzzzj_ = context.Operators.Add((wzzzzzzzzj_ ?? wzzzzzzzzm_) ?? wzzzzzzzzr_, zzzzzzzzzi_);
                    CqlInterval<CqlDate> zzzzzzzzzk_ = context.Operators.Interval((vzzzzzzzzt_ ?? vzzzzzzzzw_) ?? wzzzzzzzzb_, zzzzzzzzzj_, true, true);

                    return zzzzzzzzzk_;
                }
                else if (rzzzzzzzze_())
                {
                    List<Dosage> zzzzzzzzzl_ = R?.DosageInstruction;
                    Dosage zzzzzzzzzm_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)zzzzzzzzzl_);
                    Timing zzzzzzzzzn_ = zzzzzzzzzm_?.Timing;
                    Timing.RepeatComponent zzzzzzzzzo_ = zzzzzzzzzn_?.Repeat;
                    DataType zzzzzzzzzp_ = zzzzzzzzzo_?.Bounds;
                    object zzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzp_);
                    CqlDateTime zzzzzzzzzr_ = context.Operators.Start(zzzzzzzzzq_ as CqlInterval<CqlDateTime>);
                    CqlDate zzzzzzzzzs_ = context.Operators.DateFrom(zzzzzzzzzr_);
                    FhirDateTime zzzzzzzzzt_ = R?.AuthoredOnElement;
                    CqlDateTime zzzzzzzzzu_ = context.Operators.Convert<CqlDateTime>(zzzzzzzzzt_);
                    CqlDate zzzzzzzzzv_ = context.Operators.DateFrom(zzzzzzzzzu_);
                    MedicationRequest.DispenseRequestComponent zzzzzzzzzw_ = R?.DispenseRequest;
                    Period zzzzzzzzzx_ = zzzzzzzzzw_?.ValidityPeriod;
                    CqlInterval<CqlDateTime> zzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzzzzx_);
                    CqlDateTime zzzzzzzzzz_ = context.Operators.Start(zzzzzzzzzy_);
                    CqlDate azzzzzzzzza_ = context.Operators.DateFrom(zzzzzzzzzz_);
                    Dosage azzzzzzzzzc_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)zzzzzzzzzl_);
                    Timing azzzzzzzzzd_ = azzzzzzzzzc_?.Timing;
                    Timing.RepeatComponent azzzzzzzzze_ = azzzzzzzzzd_?.Repeat;
                    DataType azzzzzzzzzf_ = azzzzzzzzze_?.Bounds;
                    object azzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzf_);
                    CqlDateTime azzzzzzzzzh_ = context.Operators.End(azzzzzzzzzg_ as CqlInterval<CqlDateTime>);
                    CqlDate azzzzzzzzzi_ = context.Operators.DateFrom(azzzzzzzzzh_);
                    CqlInterval<CqlDate> azzzzzzzzzj_ = context.Operators.Interval((zzzzzzzzzs_ ?? zzzzzzzzzv_) ?? azzzzzzzzza_, azzzzzzzzzi_, true, true);

                    return azzzzzzzzzj_;
                }
                else
                {
                    return null as CqlInterval<CqlDate>;
                }
            };

            return rzzzzzzzzc_();
        };
        IEnumerable<CqlInterval<CqlDate>> qzzzzzzzzz_ = context.Operators.Select<MedicationRequest, CqlInterval<CqlDate>>((IEnumerable<MedicationRequest>)qzzzzzzzzx_, qzzzzzzzzy_);
        IEnumerable<CqlInterval<CqlDate>> rzzzzzzzza_ = context.Operators.Distinct<CqlInterval<CqlDate>>(qzzzzzzzzz_);
        CqlInterval<CqlDate> rzzzzzzzzb_ = context.Operators.SingletonFrom<CqlInterval<CqlDate>>(rzzzzzzzza_);

        return rzzzzzzzzb_;
    }


    [CqlExpressionDefinition("MedicationDispensePeriod")]
    public CqlInterval<CqlDate> MedicationDispensePeriod(CqlContext context, MedicationDispense Dispense)
    {
        MedicationDispense[] azzzzzzzzzk_ = [
            Dispense,
        ];
        CqlInterval<CqlDate> azzzzzzzzzl_(MedicationDispense D)
        {
            CqlInterval<CqlDate> azzzzzzzzzp_()
            {
                bool azzzzzzzzzq_()
                {
                    FhirDateTime azzzzzzzzzr_ = D?.WhenHandedOverElement;
                    CqlDateTime azzzzzzzzzs_ = context.Operators.Convert<CqlDateTime>(azzzzzzzzzr_);
                    CqlDate azzzzzzzzzt_ = context.Operators.DateFrom(azzzzzzzzzs_);
                    FhirDateTime azzzzzzzzzu_ = D?.WhenPreparedElement;
                    CqlDateTime azzzzzzzzzv_ = context.Operators.Convert<CqlDateTime>(azzzzzzzzzu_);
                    CqlDate azzzzzzzzzw_ = context.Operators.DateFrom(azzzzzzzzzv_);
                    bool? azzzzzzzzzx_ = context.Operators.Not((bool?)((azzzzzzzzzt_ ?? azzzzzzzzzw_) is null));
                    Quantity azzzzzzzzzy_ = D?.DaysSupply;
                    CqlQuantity azzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, azzzzzzzzzy_);
                    CqlQuantity bzzzzzzzzza_ = context.Operators.ConvertQuantity(azzzzzzzzzz_, "d");
                    decimal? bzzzzzzzzzb_ = bzzzzzzzzza_?.value;
                    Quantity bzzzzzzzzzc_ = D?.Quantity;
                    CqlQuantity bzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, bzzzzzzzzzc_);
                    decimal? bzzzzzzzzze_ = bzzzzzzzzzd_?.value;
                    List<Dosage> bzzzzzzzzzf_ = D?.DosageInstruction;
                    Dosage bzzzzzzzzzg_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)bzzzzzzzzzf_);
                    List<Dosage.DoseAndRateComponent> bzzzzzzzzzh_ = bzzzzzzzzzg_?.DoseAndRate;
                    Dosage.DoseAndRateComponent bzzzzzzzzzi_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)bzzzzzzzzzh_);
                    DataType bzzzzzzzzzj_ = bzzzzzzzzzi_?.Dose;
                    object bzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzj_);
                    CqlQuantity bzzzzzzzzzl_ = context.Operators.End(bzzzzzzzzzk_ as CqlInterval<CqlQuantity>);
                    Dosage bzzzzzzzzzn_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)bzzzzzzzzzf_);
                    List<Dosage.DoseAndRateComponent> bzzzzzzzzzo_ = bzzzzzzzzzn_?.DoseAndRate;
                    Dosage.DoseAndRateComponent bzzzzzzzzzp_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)bzzzzzzzzzo_);
                    DataType bzzzzzzzzzq_ = bzzzzzzzzzp_?.Dose;
                    object bzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzq_);
                    decimal? bzzzzzzzzzs_ = (bzzzzzzzzzl_ ?? bzzzzzzzzzr_ as CqlQuantity)?.value;
                    Dosage bzzzzzzzzzu_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)bzzzzzzzzzf_);
                    Timing bzzzzzzzzzv_ = bzzzzzzzzzu_?.Timing;
                    Timing.RepeatComponent bzzzzzzzzzw_ = bzzzzzzzzzv_?.Repeat;
                    PositiveInt bzzzzzzzzzx_ = bzzzzzzzzzw_?.FrequencyMaxElement;
                    int? bzzzzzzzzzy_ = bzzzzzzzzzx_?.Value;
                    Dosage czzzzzzzzza_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)bzzzzzzzzzf_);
                    Timing czzzzzzzzzb_ = czzzzzzzzza_?.Timing;
                    Timing.RepeatComponent czzzzzzzzzc_ = czzzzzzzzzb_?.Repeat;
                    PositiveInt czzzzzzzzzd_ = czzzzzzzzzc_?.FrequencyElement;
                    int? czzzzzzzzze_ = czzzzzzzzzd_?.Value;
                    Dosage czzzzzzzzzg_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)bzzzzzzzzzf_);
                    Timing czzzzzzzzzh_ = czzzzzzzzzg_?.Timing;
                    Timing.RepeatComponent czzzzzzzzzi_ = czzzzzzzzzh_?.Repeat;
                    FhirDecimal czzzzzzzzzj_ = czzzzzzzzzi_?.PeriodElement;
                    decimal? czzzzzzzzzk_ = czzzzzzzzzj_?.Value;
                    Dosage czzzzzzzzzm_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)bzzzzzzzzzf_);
                    Timing czzzzzzzzzn_ = czzzzzzzzzm_?.Timing;
                    Timing.RepeatComponent czzzzzzzzzo_ = czzzzzzzzzn_?.Repeat;
                    Code<Timing.UnitsOfTime> czzzzzzzzzp_ = czzzzzzzzzo_?.PeriodUnitElement;
                    Timing.UnitsOfTime? czzzzzzzzzq_ = czzzzzzzzzp_?.Value;
                    string czzzzzzzzzr_ = context.Operators.Convert<string>(czzzzzzzzzq_);
                    CqlQuantity czzzzzzzzzs_ = this.Quantity(context, czzzzzzzzzk_, czzzzzzzzzr_);
                    decimal? czzzzzzzzzt_ = this.ToDaily(context, bzzzzzzzzzy_ ?? czzzzzzzzze_, czzzzzzzzzs_);
                    Dosage czzzzzzzzzv_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)bzzzzzzzzzf_);
                    Timing czzzzzzzzzw_ = czzzzzzzzzv_?.Timing;
                    Timing.RepeatComponent czzzzzzzzzx_ = czzzzzzzzzw_?.Repeat;
                    List<Time> czzzzzzzzzy_ = czzzzzzzzzx_?.TimeOfDayElement;
                    IEnumerable<CqlTime> czzzzzzzzzz_ = context.Operators.LateBoundProperty<IEnumerable<CqlTime>>(czzzzzzzzzy_, "value");
                    int? dzzzzzzzzza_ = context.Operators.Count<CqlTime>(czzzzzzzzzz_);
                    decimal? dzzzzzzzzzb_ = context.Operators.ConvertIntegerToDecimal(dzzzzzzzzza_);
                    decimal? dzzzzzzzzzc_ = context.Operators.Multiply(bzzzzzzzzzs_, (czzzzzzzzzt_ ?? dzzzzzzzzzb_) ?? 1.0m);
                    decimal? dzzzzzzzzzd_ = context.Operators.Divide(bzzzzzzzzze_, dzzzzzzzzzc_);
                    bool? dzzzzzzzzze_ = context.Operators.Not((bool?)((bzzzzzzzzzb_ ?? dzzzzzzzzzd_) is null));
                    bool? dzzzzzzzzzf_ = context.Operators.And(azzzzzzzzzx_, dzzzzzzzzze_);

                    return dzzzzzzzzzf_ ?? false;
                };
                if (azzzzzzzzzq_())
                {
                    FhirDateTime dzzzzzzzzzg_ = D?.WhenHandedOverElement;
                    CqlDateTime dzzzzzzzzzh_ = context.Operators.Convert<CqlDateTime>(dzzzzzzzzzg_);
                    CqlDate dzzzzzzzzzi_ = context.Operators.DateFrom(dzzzzzzzzzh_);
                    FhirDateTime dzzzzzzzzzj_ = D?.WhenPreparedElement;
                    CqlDateTime dzzzzzzzzzk_ = context.Operators.Convert<CqlDateTime>(dzzzzzzzzzj_);
                    CqlDate dzzzzzzzzzl_ = context.Operators.DateFrom(dzzzzzzzzzk_);
                    CqlDateTime dzzzzzzzzzn_ = context.Operators.Convert<CqlDateTime>(dzzzzzzzzzg_);
                    CqlDate dzzzzzzzzzo_ = context.Operators.DateFrom(dzzzzzzzzzn_);
                    CqlDateTime dzzzzzzzzzq_ = context.Operators.Convert<CqlDateTime>(dzzzzzzzzzj_);
                    CqlDate dzzzzzzzzzr_ = context.Operators.DateFrom(dzzzzzzzzzq_);
                    Quantity dzzzzzzzzzs_ = D?.DaysSupply;
                    CqlQuantity dzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, dzzzzzzzzzs_);
                    CqlQuantity dzzzzzzzzzu_ = context.Operators.ConvertQuantity(dzzzzzzzzzt_, "d");
                    decimal? dzzzzzzzzzv_ = dzzzzzzzzzu_?.value;
                    Quantity dzzzzzzzzzw_ = D?.Quantity;
                    CqlQuantity dzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, dzzzzzzzzzw_);
                    decimal? dzzzzzzzzzy_ = dzzzzzzzzzx_?.value;
                    List<Dosage> dzzzzzzzzzz_ = D?.DosageInstruction;
                    Dosage ezzzzzzzzza_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)dzzzzzzzzzz_);
                    List<Dosage.DoseAndRateComponent> ezzzzzzzzzb_ = ezzzzzzzzza_?.DoseAndRate;
                    Dosage.DoseAndRateComponent ezzzzzzzzzc_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)ezzzzzzzzzb_);
                    DataType ezzzzzzzzzd_ = ezzzzzzzzzc_?.Dose;
                    object ezzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzd_);
                    CqlQuantity ezzzzzzzzzf_ = context.Operators.End(ezzzzzzzzze_ as CqlInterval<CqlQuantity>);
                    Dosage ezzzzzzzzzh_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)dzzzzzzzzzz_);
                    List<Dosage.DoseAndRateComponent> ezzzzzzzzzi_ = ezzzzzzzzzh_?.DoseAndRate;
                    Dosage.DoseAndRateComponent ezzzzzzzzzj_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)ezzzzzzzzzi_);
                    DataType ezzzzzzzzzk_ = ezzzzzzzzzj_?.Dose;
                    object ezzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzk_);
                    decimal? ezzzzzzzzzm_ = (ezzzzzzzzzf_ ?? ezzzzzzzzzl_ as CqlQuantity)?.value;
                    Dosage ezzzzzzzzzo_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)dzzzzzzzzzz_);
                    Timing ezzzzzzzzzp_ = ezzzzzzzzzo_?.Timing;
                    Timing.RepeatComponent ezzzzzzzzzq_ = ezzzzzzzzzp_?.Repeat;
                    PositiveInt ezzzzzzzzzr_ = ezzzzzzzzzq_?.FrequencyMaxElement;
                    int? ezzzzzzzzzs_ = ezzzzzzzzzr_?.Value;
                    Dosage ezzzzzzzzzu_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)dzzzzzzzzzz_);
                    Timing ezzzzzzzzzv_ = ezzzzzzzzzu_?.Timing;
                    Timing.RepeatComponent ezzzzzzzzzw_ = ezzzzzzzzzv_?.Repeat;
                    PositiveInt ezzzzzzzzzx_ = ezzzzzzzzzw_?.FrequencyElement;
                    int? ezzzzzzzzzy_ = ezzzzzzzzzx_?.Value;
                    Dosage fzzzzzzzzza_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)dzzzzzzzzzz_);
                    Timing fzzzzzzzzzb_ = fzzzzzzzzza_?.Timing;
                    Timing.RepeatComponent fzzzzzzzzzc_ = fzzzzzzzzzb_?.Repeat;
                    FhirDecimal fzzzzzzzzzd_ = fzzzzzzzzzc_?.PeriodElement;
                    decimal? fzzzzzzzzze_ = fzzzzzzzzzd_?.Value;
                    Dosage fzzzzzzzzzg_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)dzzzzzzzzzz_);
                    Timing fzzzzzzzzzh_ = fzzzzzzzzzg_?.Timing;
                    Timing.RepeatComponent fzzzzzzzzzi_ = fzzzzzzzzzh_?.Repeat;
                    Code<Timing.UnitsOfTime> fzzzzzzzzzj_ = fzzzzzzzzzi_?.PeriodUnitElement;
                    Timing.UnitsOfTime? fzzzzzzzzzk_ = fzzzzzzzzzj_?.Value;
                    string fzzzzzzzzzl_ = context.Operators.Convert<string>(fzzzzzzzzzk_);
                    CqlQuantity fzzzzzzzzzm_ = this.Quantity(context, fzzzzzzzzze_, fzzzzzzzzzl_);
                    decimal? fzzzzzzzzzn_ = this.ToDaily(context, ezzzzzzzzzs_ ?? ezzzzzzzzzy_, fzzzzzzzzzm_);
                    Dosage fzzzzzzzzzp_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)dzzzzzzzzzz_);
                    Timing fzzzzzzzzzq_ = fzzzzzzzzzp_?.Timing;
                    Timing.RepeatComponent fzzzzzzzzzr_ = fzzzzzzzzzq_?.Repeat;
                    List<Time> fzzzzzzzzzs_ = fzzzzzzzzzr_?.TimeOfDayElement;
                    IEnumerable<CqlTime> fzzzzzzzzzt_ = context.Operators.LateBoundProperty<IEnumerable<CqlTime>>(fzzzzzzzzzs_, "value");
                    int? fzzzzzzzzzu_ = context.Operators.Count<CqlTime>(fzzzzzzzzzt_);
                    decimal? fzzzzzzzzzv_ = context.Operators.ConvertIntegerToDecimal(fzzzzzzzzzu_);
                    decimal? fzzzzzzzzzw_ = context.Operators.Multiply(ezzzzzzzzzm_, (fzzzzzzzzzn_ ?? fzzzzzzzzzv_) ?? 1.0m);
                    decimal? fzzzzzzzzzx_ = context.Operators.Divide(dzzzzzzzzzy_, fzzzzzzzzzw_);
                    decimal? fzzzzzzzzzy_ = context.Operators.ConvertIntegerToDecimal(1);
                    decimal? fzzzzzzzzzz_ = context.Operators.Subtract(dzzzzzzzzzv_ ?? fzzzzzzzzzx_, fzzzzzzzzzy_);
                    CqlQuantity gzzzzzzzzza_ = this.Quantity(context, fzzzzzzzzzz_, "day");
                    CqlDate gzzzzzzzzzb_ = context.Operators.Add(dzzzzzzzzzo_ ?? dzzzzzzzzzr_, gzzzzzzzzza_);
                    CqlInterval<CqlDate> gzzzzzzzzzc_ = context.Operators.Interval(dzzzzzzzzzi_ ?? dzzzzzzzzzl_, gzzzzzzzzzb_, true, true);

                    return gzzzzzzzzzc_;
                }
                else
                {
                    return null as CqlInterval<CqlDate>;
                }
            };

            return azzzzzzzzzp_();
        };
        IEnumerable<CqlInterval<CqlDate>> azzzzzzzzzm_ = context.Operators.Select<MedicationDispense, CqlInterval<CqlDate>>((IEnumerable<MedicationDispense>)azzzzzzzzzk_, azzzzzzzzzl_);
        IEnumerable<CqlInterval<CqlDate>> azzzzzzzzzn_ = context.Operators.Distinct<CqlInterval<CqlDate>>(azzzzzzzzzm_);
        CqlInterval<CqlDate> azzzzzzzzzo_ = context.Operators.SingletonFrom<CqlInterval<CqlDate>>(azzzzzzzzzn_);

        return azzzzzzzzzo_;
    }


    [CqlExpressionDefinition("medicationDispensePeriod")]
    public CqlInterval<CqlDate> medicationDispensePeriod(CqlContext context, MedicationDispense Dispense)
    {
        MedicationDispense[] gzzzzzzzzzd_ = [
            Dispense,
        ];
        CqlInterval<CqlDate> gzzzzzzzzze_(MedicationDispense D)
        {
            CqlInterval<CqlDate> gzzzzzzzzzi_()
            {
                bool gzzzzzzzzzj_()
                {
                    FhirDateTime gzzzzzzzzzk_ = D?.WhenHandedOverElement;
                    CqlDateTime gzzzzzzzzzl_ = context.Operators.Convert<CqlDateTime>(gzzzzzzzzzk_);
                    CqlDate gzzzzzzzzzm_ = context.Operators.DateFrom(gzzzzzzzzzl_);
                    FhirDateTime gzzzzzzzzzn_ = D?.WhenPreparedElement;
                    CqlDateTime gzzzzzzzzzo_ = context.Operators.Convert<CqlDateTime>(gzzzzzzzzzn_);
                    CqlDate gzzzzzzzzzp_ = context.Operators.DateFrom(gzzzzzzzzzo_);
                    bool? gzzzzzzzzzq_ = context.Operators.Not((bool?)((gzzzzzzzzzm_ ?? gzzzzzzzzzp_) is null));
                    Quantity gzzzzzzzzzr_ = D?.DaysSupply;
                    CqlQuantity gzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, gzzzzzzzzzr_);
                    CqlQuantity gzzzzzzzzzt_ = context.Operators.ConvertQuantity(gzzzzzzzzzs_, "d");
                    decimal? gzzzzzzzzzu_ = gzzzzzzzzzt_?.value;
                    Quantity gzzzzzzzzzv_ = D?.Quantity;
                    CqlQuantity gzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, gzzzzzzzzzv_);
                    decimal? gzzzzzzzzzx_ = gzzzzzzzzzw_?.value;
                    List<Dosage> gzzzzzzzzzy_ = D?.DosageInstruction;
                    Dosage gzzzzzzzzzz_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)gzzzzzzzzzy_);
                    List<Dosage.DoseAndRateComponent> hzzzzzzzzza_ = gzzzzzzzzzz_?.DoseAndRate;
                    Dosage.DoseAndRateComponent hzzzzzzzzzb_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)hzzzzzzzzza_);
                    DataType hzzzzzzzzzc_ = hzzzzzzzzzb_?.Dose;
                    object hzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzc_);
                    CqlQuantity hzzzzzzzzze_ = context.Operators.End(hzzzzzzzzzd_ as CqlInterval<CqlQuantity>);
                    Dosage hzzzzzzzzzg_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)gzzzzzzzzzy_);
                    List<Dosage.DoseAndRateComponent> hzzzzzzzzzh_ = hzzzzzzzzzg_?.DoseAndRate;
                    Dosage.DoseAndRateComponent hzzzzzzzzzi_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)hzzzzzzzzzh_);
                    DataType hzzzzzzzzzj_ = hzzzzzzzzzi_?.Dose;
                    object hzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzj_);
                    decimal? hzzzzzzzzzl_ = (hzzzzzzzzze_ ?? hzzzzzzzzzk_ as CqlQuantity)?.value;
                    Dosage hzzzzzzzzzn_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)gzzzzzzzzzy_);
                    Timing hzzzzzzzzzo_ = hzzzzzzzzzn_?.Timing;
                    Timing.RepeatComponent hzzzzzzzzzp_ = hzzzzzzzzzo_?.Repeat;
                    PositiveInt hzzzzzzzzzq_ = hzzzzzzzzzp_?.FrequencyMaxElement;
                    int? hzzzzzzzzzr_ = hzzzzzzzzzq_?.Value;
                    Dosage hzzzzzzzzzt_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)gzzzzzzzzzy_);
                    Timing hzzzzzzzzzu_ = hzzzzzzzzzt_?.Timing;
                    Timing.RepeatComponent hzzzzzzzzzv_ = hzzzzzzzzzu_?.Repeat;
                    PositiveInt hzzzzzzzzzw_ = hzzzzzzzzzv_?.FrequencyElement;
                    int? hzzzzzzzzzx_ = hzzzzzzzzzw_?.Value;
                    Dosage hzzzzzzzzzz_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)gzzzzzzzzzy_);
                    Timing izzzzzzzzza_ = hzzzzzzzzzz_?.Timing;
                    Timing.RepeatComponent izzzzzzzzzb_ = izzzzzzzzza_?.Repeat;
                    FhirDecimal izzzzzzzzzc_ = izzzzzzzzzb_?.PeriodElement;
                    decimal? izzzzzzzzzd_ = izzzzzzzzzc_?.Value;
                    Dosage izzzzzzzzzf_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)gzzzzzzzzzy_);
                    Timing izzzzzzzzzg_ = izzzzzzzzzf_?.Timing;
                    Timing.RepeatComponent izzzzzzzzzh_ = izzzzzzzzzg_?.Repeat;
                    Code<Timing.UnitsOfTime> izzzzzzzzzi_ = izzzzzzzzzh_?.PeriodUnitElement;
                    Timing.UnitsOfTime? izzzzzzzzzj_ = izzzzzzzzzi_?.Value;
                    string izzzzzzzzzk_ = context.Operators.Convert<string>(izzzzzzzzzj_);
                    CqlQuantity izzzzzzzzzl_ = this.Quantity(context, izzzzzzzzzd_, izzzzzzzzzk_);
                    decimal? izzzzzzzzzm_ = this.ToDaily(context, hzzzzzzzzzr_ ?? hzzzzzzzzzx_, izzzzzzzzzl_);
                    Dosage izzzzzzzzzo_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)gzzzzzzzzzy_);
                    Timing izzzzzzzzzp_ = izzzzzzzzzo_?.Timing;
                    Timing.RepeatComponent izzzzzzzzzq_ = izzzzzzzzzp_?.Repeat;
                    List<Time> izzzzzzzzzr_ = izzzzzzzzzq_?.TimeOfDayElement;
                    IEnumerable<CqlTime> izzzzzzzzzs_ = context.Operators.LateBoundProperty<IEnumerable<CqlTime>>(izzzzzzzzzr_, "value");
                    int? izzzzzzzzzt_ = context.Operators.Count<CqlTime>(izzzzzzzzzs_);
                    decimal? izzzzzzzzzu_ = context.Operators.ConvertIntegerToDecimal(izzzzzzzzzt_);
                    decimal? izzzzzzzzzv_ = context.Operators.Multiply(hzzzzzzzzzl_, (izzzzzzzzzm_ ?? izzzzzzzzzu_) ?? 1.0m);
                    decimal? izzzzzzzzzw_ = context.Operators.Divide(gzzzzzzzzzx_, izzzzzzzzzv_);
                    bool? izzzzzzzzzx_ = context.Operators.Not((bool?)((gzzzzzzzzzu_ ?? izzzzzzzzzw_) is null));
                    bool? izzzzzzzzzy_ = context.Operators.And(gzzzzzzzzzq_, izzzzzzzzzx_);

                    return izzzzzzzzzy_ ?? false;
                };
                if (gzzzzzzzzzj_())
                {
                    FhirDateTime izzzzzzzzzz_ = D?.WhenHandedOverElement;
                    CqlDateTime jzzzzzzzzza_ = context.Operators.Convert<CqlDateTime>(izzzzzzzzzz_);
                    CqlDate jzzzzzzzzzb_ = context.Operators.DateFrom(jzzzzzzzzza_);
                    FhirDateTime jzzzzzzzzzc_ = D?.WhenPreparedElement;
                    CqlDateTime jzzzzzzzzzd_ = context.Operators.Convert<CqlDateTime>(jzzzzzzzzzc_);
                    CqlDate jzzzzzzzzze_ = context.Operators.DateFrom(jzzzzzzzzzd_);
                    CqlDateTime jzzzzzzzzzg_ = context.Operators.Convert<CqlDateTime>(izzzzzzzzzz_);
                    CqlDate jzzzzzzzzzh_ = context.Operators.DateFrom(jzzzzzzzzzg_);
                    CqlDateTime jzzzzzzzzzj_ = context.Operators.Convert<CqlDateTime>(jzzzzzzzzzc_);
                    CqlDate jzzzzzzzzzk_ = context.Operators.DateFrom(jzzzzzzzzzj_);
                    Quantity jzzzzzzzzzl_ = D?.DaysSupply;
                    CqlQuantity jzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, jzzzzzzzzzl_);
                    CqlQuantity jzzzzzzzzzn_ = context.Operators.ConvertQuantity(jzzzzzzzzzm_, "d");
                    decimal? jzzzzzzzzzo_ = jzzzzzzzzzn_?.value;
                    Quantity jzzzzzzzzzp_ = D?.Quantity;
                    CqlQuantity jzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, jzzzzzzzzzp_);
                    decimal? jzzzzzzzzzr_ = jzzzzzzzzzq_?.value;
                    List<Dosage> jzzzzzzzzzs_ = D?.DosageInstruction;
                    Dosage jzzzzzzzzzt_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)jzzzzzzzzzs_);
                    List<Dosage.DoseAndRateComponent> jzzzzzzzzzu_ = jzzzzzzzzzt_?.DoseAndRate;
                    Dosage.DoseAndRateComponent jzzzzzzzzzv_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)jzzzzzzzzzu_);
                    DataType jzzzzzzzzzw_ = jzzzzzzzzzv_?.Dose;
                    object jzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzw_);
                    CqlQuantity jzzzzzzzzzy_ = context.Operators.End(jzzzzzzzzzx_ as CqlInterval<CqlQuantity>);
                    Dosage kzzzzzzzzza_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)jzzzzzzzzzs_);
                    List<Dosage.DoseAndRateComponent> kzzzzzzzzzb_ = kzzzzzzzzza_?.DoseAndRate;
                    Dosage.DoseAndRateComponent kzzzzzzzzzc_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)kzzzzzzzzzb_);
                    DataType kzzzzzzzzzd_ = kzzzzzzzzzc_?.Dose;
                    object kzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzd_);
                    decimal? kzzzzzzzzzf_ = (jzzzzzzzzzy_ ?? kzzzzzzzzze_ as CqlQuantity)?.value;
                    Dosage kzzzzzzzzzh_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)jzzzzzzzzzs_);
                    Timing kzzzzzzzzzi_ = kzzzzzzzzzh_?.Timing;
                    Timing.RepeatComponent kzzzzzzzzzj_ = kzzzzzzzzzi_?.Repeat;
                    PositiveInt kzzzzzzzzzk_ = kzzzzzzzzzj_?.FrequencyMaxElement;
                    int? kzzzzzzzzzl_ = kzzzzzzzzzk_?.Value;
                    Dosage kzzzzzzzzzn_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)jzzzzzzzzzs_);
                    Timing kzzzzzzzzzo_ = kzzzzzzzzzn_?.Timing;
                    Timing.RepeatComponent kzzzzzzzzzp_ = kzzzzzzzzzo_?.Repeat;
                    PositiveInt kzzzzzzzzzq_ = kzzzzzzzzzp_?.FrequencyElement;
                    int? kzzzzzzzzzr_ = kzzzzzzzzzq_?.Value;
                    Dosage kzzzzzzzzzt_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)jzzzzzzzzzs_);
                    Timing kzzzzzzzzzu_ = kzzzzzzzzzt_?.Timing;
                    Timing.RepeatComponent kzzzzzzzzzv_ = kzzzzzzzzzu_?.Repeat;
                    FhirDecimal kzzzzzzzzzw_ = kzzzzzzzzzv_?.PeriodElement;
                    decimal? kzzzzzzzzzx_ = kzzzzzzzzzw_?.Value;
                    Dosage kzzzzzzzzzz_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)jzzzzzzzzzs_);
                    Timing lzzzzzzzzza_ = kzzzzzzzzzz_?.Timing;
                    Timing.RepeatComponent lzzzzzzzzzb_ = lzzzzzzzzza_?.Repeat;
                    Code<Timing.UnitsOfTime> lzzzzzzzzzc_ = lzzzzzzzzzb_?.PeriodUnitElement;
                    Timing.UnitsOfTime? lzzzzzzzzzd_ = lzzzzzzzzzc_?.Value;
                    string lzzzzzzzzze_ = context.Operators.Convert<string>(lzzzzzzzzzd_);
                    CqlQuantity lzzzzzzzzzf_ = this.Quantity(context, kzzzzzzzzzx_, lzzzzzzzzze_);
                    decimal? lzzzzzzzzzg_ = this.ToDaily(context, kzzzzzzzzzl_ ?? kzzzzzzzzzr_, lzzzzzzzzzf_);
                    Dosage lzzzzzzzzzi_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)jzzzzzzzzzs_);
                    Timing lzzzzzzzzzj_ = lzzzzzzzzzi_?.Timing;
                    Timing.RepeatComponent lzzzzzzzzzk_ = lzzzzzzzzzj_?.Repeat;
                    List<Time> lzzzzzzzzzl_ = lzzzzzzzzzk_?.TimeOfDayElement;
                    IEnumerable<CqlTime> lzzzzzzzzzm_ = context.Operators.LateBoundProperty<IEnumerable<CqlTime>>(lzzzzzzzzzl_, "value");
                    int? lzzzzzzzzzn_ = context.Operators.Count<CqlTime>(lzzzzzzzzzm_);
                    decimal? lzzzzzzzzzo_ = context.Operators.ConvertIntegerToDecimal(lzzzzzzzzzn_);
                    decimal? lzzzzzzzzzp_ = context.Operators.Multiply(kzzzzzzzzzf_, (lzzzzzzzzzg_ ?? lzzzzzzzzzo_) ?? 1.0m);
                    decimal? lzzzzzzzzzq_ = context.Operators.Divide(jzzzzzzzzzr_, lzzzzzzzzzp_);
                    decimal? lzzzzzzzzzr_ = context.Operators.ConvertIntegerToDecimal(1);
                    decimal? lzzzzzzzzzs_ = context.Operators.Subtract(jzzzzzzzzzo_ ?? lzzzzzzzzzq_, lzzzzzzzzzr_);
                    CqlQuantity lzzzzzzzzzt_ = this.Quantity(context, lzzzzzzzzzs_, "day");
                    CqlDate lzzzzzzzzzu_ = context.Operators.Add(jzzzzzzzzzh_ ?? jzzzzzzzzzk_, lzzzzzzzzzt_);
                    CqlInterval<CqlDate> lzzzzzzzzzv_ = context.Operators.Interval(jzzzzzzzzzb_ ?? jzzzzzzzzze_, lzzzzzzzzzu_, true, true);

                    return lzzzzzzzzzv_;
                }
                else
                {
                    return null as CqlInterval<CqlDate>;
                }
            };

            return gzzzzzzzzzi_();
        };
        IEnumerable<CqlInterval<CqlDate>> gzzzzzzzzzf_ = context.Operators.Select<MedicationDispense, CqlInterval<CqlDate>>((IEnumerable<MedicationDispense>)gzzzzzzzzzd_, gzzzzzzzzze_);
        IEnumerable<CqlInterval<CqlDate>> gzzzzzzzzzg_ = context.Operators.Distinct<CqlInterval<CqlDate>>(gzzzzzzzzzf_);
        CqlInterval<CqlDate> gzzzzzzzzzh_ = context.Operators.SingletonFrom<CqlInterval<CqlDate>>(gzzzzzzzzzg_);

        return gzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("TherapeuticDuration")]
    public CqlQuantity TherapeuticDuration(CqlContext context, CqlConcept medication)
    {
        CqlQuantity lzzzzzzzzzw_ = context.Operators.Quantity(14m, "days");

        return lzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("MedicationAdministrationPeriod")]
    public CqlInterval<CqlDate> MedicationAdministrationPeriod(CqlContext context, MedicationAdministration Administration)
    {
        MedicationAdministration[] lzzzzzzzzzx_ = [
            Administration,
        ];
        CqlInterval<CqlDate> lzzzzzzzzzy_(MedicationAdministration M)
        {
            CqlInterval<CqlDate> mzzzzzzzzzc_()
            {
                bool mzzzzzzzzzd_()
                {
                    DataType mzzzzzzzzze_ = Administration?.Effective;
                    object mzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzze_);
                    CqlDateTime mzzzzzzzzzg_ = context.Operators.Start(mzzzzzzzzzf_ as CqlInterval<CqlDateTime>);
                    CqlDate mzzzzzzzzzh_ = context.Operators.DateFrom(mzzzzzzzzzg_);
                    bool? mzzzzzzzzzi_ = context.Operators.Not((bool?)(mzzzzzzzzzh_ is null));
                    DataType mzzzzzzzzzj_ = Administration?.Medication;
                    object mzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzj_);
                    CqlQuantity mzzzzzzzzzl_ = this.TherapeuticDuration(context, mzzzzzzzzzk_ as CqlConcept);
                    bool? mzzzzzzzzzm_ = context.Operators.Not((bool?)(mzzzzzzzzzl_ is null));
                    bool? mzzzzzzzzzn_ = context.Operators.And(mzzzzzzzzzi_, mzzzzzzzzzm_);

                    return mzzzzzzzzzn_ ?? false;
                };
                if (mzzzzzzzzzd_())
                {
                    DataType mzzzzzzzzzo_ = Administration?.Effective;
                    object mzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzo_);
                    CqlDateTime mzzzzzzzzzq_ = context.Operators.Start(mzzzzzzzzzp_ as CqlInterval<CqlDateTime>);
                    CqlDate mzzzzzzzzzr_ = context.Operators.DateFrom(mzzzzzzzzzq_);
                    object mzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzo_);
                    CqlDateTime mzzzzzzzzzu_ = context.Operators.Start(mzzzzzzzzzt_ as CqlInterval<CqlDateTime>);
                    CqlDate mzzzzzzzzzv_ = context.Operators.DateFrom(mzzzzzzzzzu_);
                    DataType mzzzzzzzzzw_ = Administration?.Medication;
                    object mzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzw_);
                    CqlQuantity mzzzzzzzzzy_ = this.TherapeuticDuration(context, mzzzzzzzzzx_ as CqlConcept);
                    CqlDate mzzzzzzzzzz_ = context.Operators.Add(mzzzzzzzzzv_, mzzzzzzzzzy_);
                    CqlQuantity nzzzzzzzzza_ = context.Operators.ConvertIntegerToQuantity(1);
                    CqlDate nzzzzzzzzzb_ = context.Operators.Subtract(mzzzzzzzzzz_, nzzzzzzzzza_);
                    CqlInterval<CqlDate> nzzzzzzzzzc_ = context.Operators.Interval(mzzzzzzzzzr_, nzzzzzzzzzb_, true, true);

                    return nzzzzzzzzzc_;
                }
                else
                {
                    return null as CqlInterval<CqlDate>;
                }
            };

            return mzzzzzzzzzc_();
        };
        IEnumerable<CqlInterval<CqlDate>> lzzzzzzzzzz_ = context.Operators.Select<MedicationAdministration, CqlInterval<CqlDate>>((IEnumerable<MedicationAdministration>)lzzzzzzzzzx_, lzzzzzzzzzy_);
        IEnumerable<CqlInterval<CqlDate>> mzzzzzzzzza_ = context.Operators.Distinct<CqlInterval<CqlDate>>(lzzzzzzzzzz_);
        CqlInterval<CqlDate> mzzzzzzzzzb_ = context.Operators.SingletonFrom<CqlInterval<CqlDate>>(mzzzzzzzzza_);

        return mzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("medicationAdministrationPeriod")]
    public CqlInterval<CqlDate> medicationAdministrationPeriod(CqlContext context, MedicationAdministration Administration)
    {
        MedicationAdministration[] nzzzzzzzzzd_ = [
            Administration,
        ];
        CqlInterval<CqlDate> nzzzzzzzzze_(MedicationAdministration M)
        {
            CqlInterval<CqlDate> nzzzzzzzzzi_()
            {
                bool nzzzzzzzzzj_()
                {
                    DataType nzzzzzzzzzk_ = Administration?.Effective;
                    object nzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzk_);
                    CqlDateTime nzzzzzzzzzm_ = context.Operators.Start(nzzzzzzzzzl_ as CqlInterval<CqlDateTime>);
                    CqlDate nzzzzzzzzzn_ = context.Operators.DateFrom(nzzzzzzzzzm_);
                    bool? nzzzzzzzzzo_ = context.Operators.Not((bool?)(nzzzzzzzzzn_ is null));
                    DataType nzzzzzzzzzp_ = Administration?.Medication;
                    object nzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzp_);
                    CqlQuantity nzzzzzzzzzr_ = this.TherapeuticDuration(context, nzzzzzzzzzq_ as CqlConcept);
                    bool? nzzzzzzzzzs_ = context.Operators.Not((bool?)(nzzzzzzzzzr_ is null));
                    bool? nzzzzzzzzzt_ = context.Operators.And(nzzzzzzzzzo_, nzzzzzzzzzs_);

                    return nzzzzzzzzzt_ ?? false;
                };
                if (nzzzzzzzzzj_())
                {
                    DataType nzzzzzzzzzu_ = Administration?.Effective;
                    object nzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzu_);
                    CqlDateTime nzzzzzzzzzw_ = context.Operators.Start(nzzzzzzzzzv_ as CqlInterval<CqlDateTime>);
                    CqlDate nzzzzzzzzzx_ = context.Operators.DateFrom(nzzzzzzzzzw_);
                    object nzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzu_);
                    CqlDateTime ozzzzzzzzza_ = context.Operators.Start(nzzzzzzzzzz_ as CqlInterval<CqlDateTime>);
                    CqlDate ozzzzzzzzzb_ = context.Operators.DateFrom(ozzzzzzzzza_);
                    DataType ozzzzzzzzzc_ = Administration?.Medication;
                    object ozzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzc_);
                    CqlQuantity ozzzzzzzzze_ = this.TherapeuticDuration(context, ozzzzzzzzzd_ as CqlConcept);
                    CqlDate ozzzzzzzzzf_ = context.Operators.Add(ozzzzzzzzzb_, ozzzzzzzzze_);
                    CqlQuantity ozzzzzzzzzg_ = context.Operators.ConvertIntegerToQuantity(1);
                    CqlDate ozzzzzzzzzh_ = context.Operators.Subtract(ozzzzzzzzzf_, ozzzzzzzzzg_);
                    CqlInterval<CqlDate> ozzzzzzzzzi_ = context.Operators.Interval(nzzzzzzzzzx_, ozzzzzzzzzh_, true, true);

                    return ozzzzzzzzzi_;
                }
                else
                {
                    return null as CqlInterval<CqlDate>;
                }
            };

            return nzzzzzzzzzi_();
        };
        IEnumerable<CqlInterval<CqlDate>> nzzzzzzzzzf_ = context.Operators.Select<MedicationAdministration, CqlInterval<CqlDate>>((IEnumerable<MedicationAdministration>)nzzzzzzzzzd_, nzzzzzzzzze_);
        IEnumerable<CqlInterval<CqlDate>> nzzzzzzzzzg_ = context.Operators.Distinct<CqlInterval<CqlDate>>(nzzzzzzzzzf_);
        CqlInterval<CqlDate> nzzzzzzzzzh_ = context.Operators.SingletonFrom<CqlInterval<CqlDate>>(nzzzzzzzzzg_);

        return nzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("CumulativeDuration")]
    public int? CumulativeDuration(CqlContext context, IEnumerable<CqlInterval<CqlDate>> Intervals)
    {
        int? ozzzzzzzzzj_()
        {
            if ((context.Operators.Not((bool?)(Intervals is null))) ?? false)
            {
                IEnumerable<CqlInterval<CqlDate>> ozzzzzzzzzk_ = context.Operators.Collapse(Intervals, "day");
                int? ozzzzzzzzzl_(CqlInterval<CqlDate> X)
                {
                    CqlDate ozzzzzzzzzo_ = context.Operators.Start(X);
                    CqlDate ozzzzzzzzzp_ = context.Operators.End(X);
                    int? ozzzzzzzzzq_ = context.Operators.DifferenceBetween(ozzzzzzzzzo_, ozzzzzzzzzp_, "day");
                    int? ozzzzzzzzzr_ = context.Operators.Add(ozzzzzzzzzq_, 1);

                    return ozzzzzzzzzr_;
                };
                IEnumerable<int?> ozzzzzzzzzm_ = context.Operators.Select<CqlInterval<CqlDate>, int?>(ozzzzzzzzzk_, ozzzzzzzzzl_);
                int? ozzzzzzzzzn_ = context.Operators.Sum(ozzzzzzzzzm_);

                return ozzzzzzzzzn_;
            }
            else
            {
                return default;
            }
        };

        return ozzzzzzzzzj_();
    }


    [CqlExpressionDefinition("cumulativeDuration")]
    public int? cumulativeDuration(CqlContext context, IEnumerable<CqlInterval<CqlDate>> Intervals)
    {
        int? ozzzzzzzzzs_()
        {
            if ((context.Operators.Not((bool?)(Intervals is null))) ?? false)
            {
                IEnumerable<CqlInterval<CqlDate>> ozzzzzzzzzt_ = context.Operators.Collapse(Intervals, "day");
                int? ozzzzzzzzzu_(CqlInterval<CqlDate> X)
                {
                    CqlDate ozzzzzzzzzx_ = context.Operators.Start(X);
                    CqlDate ozzzzzzzzzy_ = context.Operators.End(X);
                    int? ozzzzzzzzzz_ = context.Operators.DifferenceBetween(ozzzzzzzzzx_, ozzzzzzzzzy_, "day");
                    int? pzzzzzzzzza_ = context.Operators.Add(ozzzzzzzzzz_, 1);

                    return pzzzzzzzzza_;
                };
                IEnumerable<int?> ozzzzzzzzzv_ = context.Operators.Select<CqlInterval<CqlDate>, int?>(ozzzzzzzzzt_, ozzzzzzzzzu_);
                int? ozzzzzzzzzw_ = context.Operators.Sum(ozzzzzzzzzv_);

                return ozzzzzzzzzw_;
            }
            else
            {
                return default;
            }
        };

        return ozzzzzzzzzs_();
    }


    [CqlExpressionDefinition("RolloutIntervals")]
    public IEnumerable<CqlInterval<CqlDate>> RolloutIntervals(CqlContext context, IEnumerable<CqlInterval<CqlDate>> intervals)
    {
        IEnumerable<CqlInterval<CqlDate>> pzzzzzzzzzb_(IEnumerable<CqlInterval<CqlDate>> R, CqlInterval<CqlDate> I)
        {
            CqlInterval<CqlDate>[] pzzzzzzzzzd_ = [
                I,
            ];
            CqlInterval<CqlDate> pzzzzzzzzze_(CqlInterval<CqlDate> X)
            {
                CqlInterval<CqlDate> pzzzzzzzzzk_ = context.Operators.Last<CqlInterval<CqlDate>>(R);
                CqlDate pzzzzzzzzzl_ = context.Operators.End(pzzzzzzzzzk_);
                CqlQuantity pzzzzzzzzzm_ = context.Operators.Quantity(1m, "day");
                CqlDate pzzzzzzzzzn_ = context.Operators.Add(pzzzzzzzzzl_, pzzzzzzzzzm_);
                CqlDate pzzzzzzzzzo_ = context.Operators.Start(X);
                CqlDate[] pzzzzzzzzzp_ = [
                    pzzzzzzzzzn_,
                    pzzzzzzzzzo_,
                ];
                CqlDate pzzzzzzzzzq_ = context.Operators.Max<CqlDate>(pzzzzzzzzzp_ as IEnumerable<CqlDate>);
                CqlDate pzzzzzzzzzs_ = context.Operators.End(pzzzzzzzzzk_);
                CqlDate pzzzzzzzzzu_ = context.Operators.Add(pzzzzzzzzzs_, pzzzzzzzzzm_);
                CqlDate[] pzzzzzzzzzw_ = [
                    pzzzzzzzzzu_,
                    pzzzzzzzzzo_,
                ];
                CqlDate pzzzzzzzzzx_ = context.Operators.Max<CqlDate>(pzzzzzzzzzw_ as IEnumerable<CqlDate>);
                CqlDate pzzzzzzzzzz_ = context.Operators.End(X);
                int? qzzzzzzzzza_ = context.Operators.DurationBetween(pzzzzzzzzzo_, pzzzzzzzzzz_, "day");
                decimal? qzzzzzzzzzb_ = context.Operators.ConvertIntegerToDecimal(qzzzzzzzzza_ ?? 0);
                CqlQuantity qzzzzzzzzzc_ = this.Quantity(context, qzzzzzzzzzb_, "day");
                CqlDate qzzzzzzzzzd_ = context.Operators.Add(pzzzzzzzzzx_, qzzzzzzzzzc_);
                CqlInterval<CqlDate> qzzzzzzzzze_ = context.Operators.Interval(pzzzzzzzzzq_, qzzzzzzzzzd_, true, true);

                return qzzzzzzzzze_;
            };
            IEnumerable<CqlInterval<CqlDate>> pzzzzzzzzzf_ = context.Operators.Select<CqlInterval<CqlDate>, CqlInterval<CqlDate>>((IEnumerable<CqlInterval<CqlDate>>)pzzzzzzzzzd_, pzzzzzzzzze_);
            IEnumerable<CqlInterval<CqlDate>> pzzzzzzzzzg_ = context.Operators.Distinct<CqlInterval<CqlDate>>(pzzzzzzzzzf_);
            CqlInterval<CqlDate> pzzzzzzzzzh_ = context.Operators.SingletonFrom<CqlInterval<CqlDate>>(pzzzzzzzzzg_);
            CqlInterval<CqlDate>[] pzzzzzzzzzi_ = [
                pzzzzzzzzzh_,
            ];
            IEnumerable<CqlInterval<CqlDate>> pzzzzzzzzzj_ = context.Operators.Union<CqlInterval<CqlDate>>(R, pzzzzzzzzzi_ as IEnumerable<CqlInterval<CqlDate>>);

            return pzzzzzzzzzj_;
        };
        IEnumerable<CqlInterval<CqlDate>> pzzzzzzzzzc_ = context.Operators.Aggregate<CqlInterval<CqlDate>, IEnumerable<CqlInterval<CqlDate>>>(intervals, pzzzzzzzzzb_, null as IEnumerable<CqlInterval<CqlDate>>);

        return pzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("rolloutIntervals")]
    public IEnumerable<CqlInterval<CqlDate>> rolloutIntervals(CqlContext context, IEnumerable<CqlInterval<CqlDate>> intervals)
    {
        IEnumerable<CqlInterval<CqlDate>> qzzzzzzzzzf_(IEnumerable<CqlInterval<CqlDate>> R, CqlInterval<CqlDate> I)
        {
            CqlInterval<CqlDate>[] qzzzzzzzzzh_ = [
                I,
            ];
            CqlInterval<CqlDate> qzzzzzzzzzi_(CqlInterval<CqlDate> X)
            {
                CqlInterval<CqlDate> qzzzzzzzzzo_ = context.Operators.Last<CqlInterval<CqlDate>>(R);
                CqlDate qzzzzzzzzzp_ = context.Operators.End(qzzzzzzzzzo_);
                CqlQuantity qzzzzzzzzzq_ = context.Operators.Quantity(1m, "day");
                CqlDate qzzzzzzzzzr_ = context.Operators.Add(qzzzzzzzzzp_, qzzzzzzzzzq_);
                CqlDate qzzzzzzzzzs_ = context.Operators.Start(X);
                CqlDate[] qzzzzzzzzzt_ = [
                    qzzzzzzzzzr_,
                    qzzzzzzzzzs_,
                ];
                CqlDate qzzzzzzzzzu_ = context.Operators.Max<CqlDate>(qzzzzzzzzzt_ as IEnumerable<CqlDate>);
                CqlDate qzzzzzzzzzw_ = context.Operators.End(qzzzzzzzzzo_);
                CqlDate qzzzzzzzzzy_ = context.Operators.Add(qzzzzzzzzzw_, qzzzzzzzzzq_);
                CqlDate[] rzzzzzzzzza_ = [
                    qzzzzzzzzzy_,
                    qzzzzzzzzzs_,
                ];
                CqlDate rzzzzzzzzzb_ = context.Operators.Max<CqlDate>(rzzzzzzzzza_ as IEnumerable<CqlDate>);
                CqlDate rzzzzzzzzzd_ = context.Operators.End(X);
                int? rzzzzzzzzze_ = context.Operators.DurationBetween(qzzzzzzzzzs_, rzzzzzzzzzd_, "day");
                decimal? rzzzzzzzzzf_ = context.Operators.ConvertIntegerToDecimal(rzzzzzzzzze_ ?? 0);
                CqlQuantity rzzzzzzzzzg_ = this.Quantity(context, rzzzzzzzzzf_, "day");
                CqlDate rzzzzzzzzzh_ = context.Operators.Add(rzzzzzzzzzb_, rzzzzzzzzzg_);
                CqlInterval<CqlDate> rzzzzzzzzzi_ = context.Operators.Interval(qzzzzzzzzzu_, rzzzzzzzzzh_, true, true);

                return rzzzzzzzzzi_;
            };
            IEnumerable<CqlInterval<CqlDate>> qzzzzzzzzzj_ = context.Operators.Select<CqlInterval<CqlDate>, CqlInterval<CqlDate>>((IEnumerable<CqlInterval<CqlDate>>)qzzzzzzzzzh_, qzzzzzzzzzi_);
            IEnumerable<CqlInterval<CqlDate>> qzzzzzzzzzk_ = context.Operators.Distinct<CqlInterval<CqlDate>>(qzzzzzzzzzj_);
            CqlInterval<CqlDate> qzzzzzzzzzl_ = context.Operators.SingletonFrom<CqlInterval<CqlDate>>(qzzzzzzzzzk_);
            CqlInterval<CqlDate>[] qzzzzzzzzzm_ = [
                qzzzzzzzzzl_,
            ];
            IEnumerable<CqlInterval<CqlDate>> qzzzzzzzzzn_ = context.Operators.Union<CqlInterval<CqlDate>>(R, qzzzzzzzzzm_ as IEnumerable<CqlInterval<CqlDate>>);

            return qzzzzzzzzzn_;
        };
        IEnumerable<CqlInterval<CqlDate>> qzzzzzzzzzg_ = context.Operators.Aggregate<CqlInterval<CqlDate>, IEnumerable<CqlInterval<CqlDate>>>(intervals, qzzzzzzzzzf_, null as IEnumerable<CqlInterval<CqlDate>>);

        return qzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("MedicationPeriod")]
    public CqlInterval<CqlDate> MedicationPeriod(CqlContext context, object medication)
    {
        CqlInterval<CqlDate> rzzzzzzzzzj_()
        {
            if (medication is MedicationRequest)
            {
                CqlInterval<CqlDate> rzzzzzzzzzk_ = this.MedicationRequestPeriod(context, medication as MedicationRequest);

                return rzzzzzzzzzk_;
            }
            else if (medication is MedicationDispense)
            {
                CqlInterval<CqlDate> rzzzzzzzzzl_ = this.MedicationDispensePeriod(context, medication as MedicationDispense);

                return rzzzzzzzzzl_;
            }
            else
            {
                return null as CqlInterval<CqlDate>;
            }
        };

        return rzzzzzzzzzj_();
    }


    [CqlExpressionDefinition("medicationPeriod")]
    public CqlInterval<CqlDate> medicationPeriod(CqlContext context, object medication)
    {
        CqlInterval<CqlDate> rzzzzzzzzzm_()
        {
            if (medication is MedicationRequest)
            {
                CqlInterval<CqlDate> rzzzzzzzzzn_ = this.medicationRequestPeriod(context, medication as MedicationRequest);

                return rzzzzzzzzzn_;
            }
            else if (medication is MedicationDispense)
            {
                CqlInterval<CqlDate> rzzzzzzzzzo_ = this.medicationDispensePeriod(context, medication as MedicationDispense);

                return rzzzzzzzzzo_;
            }
            else
            {
                return null as CqlInterval<CqlDate>;
            }
        };

        return rzzzzzzzzzm_();
    }


    [CqlExpressionDefinition("CumulativeMedicationDuration")]
    public int? CumulativeMedicationDuration(CqlContext context, IEnumerable<object> Medications)
    {
        bool? rzzzzzzzzzp_(object M)
        {
            bool szzzzzzzzzc_ = M is MedicationRequest;

            return szzzzzzzzzc_ as bool?;
        };
        IEnumerable<object> rzzzzzzzzzq_ = context.Operators.Where<object>(Medications, rzzzzzzzzzp_);
        CqlInterval<CqlDate> rzzzzzzzzzr_(object M)
        {
            CqlInterval<CqlDate> szzzzzzzzzd_ = this.MedicationRequestPeriod(context, M as MedicationRequest);

            return szzzzzzzzzd_;
        };
        IEnumerable<CqlInterval<CqlDate>> rzzzzzzzzzs_ = context.Operators.Select<object, CqlInterval<CqlDate>>(rzzzzzzzzzq_, rzzzzzzzzzr_);
        IEnumerable<CqlInterval<CqlDate>> rzzzzzzzzzt_ = context.Operators.Distinct<CqlInterval<CqlDate>>(rzzzzzzzzzs_);
        bool? rzzzzzzzzzu_(object M)
        {
            bool szzzzzzzzze_ = M is MedicationDispense;

            return szzzzzzzzze_ as bool?;
        };
        IEnumerable<object> rzzzzzzzzzv_ = context.Operators.Where<object>(Medications, rzzzzzzzzzu_);
        CqlInterval<CqlDate> rzzzzzzzzzw_(object M)
        {
            CqlInterval<CqlDate> szzzzzzzzzf_ = this.MedicationDispensePeriod(context, M as MedicationDispense);

            return szzzzzzzzzf_;
        };
        IEnumerable<CqlInterval<CqlDate>> rzzzzzzzzzx_ = context.Operators.Select<object, CqlInterval<CqlDate>>(rzzzzzzzzzv_, rzzzzzzzzzw_);
        IEnumerable<CqlInterval<CqlDate>> rzzzzzzzzzy_ = context.Operators.Distinct<CqlInterval<CqlDate>>(rzzzzzzzzzx_);
        IEnumerable<CqlInterval<CqlDate>> rzzzzzzzzzz_ = this.RolloutIntervals(context, rzzzzzzzzzy_);
        IEnumerable<CqlInterval<CqlDate>> szzzzzzzzza_ = context.Operators.Union<CqlInterval<CqlDate>>(rzzzzzzzzzt_, rzzzzzzzzzz_);
        int? szzzzzzzzzb_ = this.CumulativeDuration(context, szzzzzzzzza_);

        return szzzzzzzzzb_;
    }


    [CqlExpressionDefinition("cumulativeMedicationDuration")]
    public int? cumulativeMedicationDuration(CqlContext context, IEnumerable<object> Medications)
    {
        bool? szzzzzzzzzg_(object M)
        {
            bool szzzzzzzzzt_ = M is MedicationRequest;

            return szzzzzzzzzt_ as bool?;
        };
        IEnumerable<object> szzzzzzzzzh_ = context.Operators.Where<object>(Medications, szzzzzzzzzg_);
        CqlInterval<CqlDate> szzzzzzzzzi_(object M)
        {
            CqlInterval<CqlDate> szzzzzzzzzu_ = this.medicationRequestPeriod(context, M as MedicationRequest);

            return szzzzzzzzzu_;
        };
        IEnumerable<CqlInterval<CqlDate>> szzzzzzzzzj_ = context.Operators.Select<object, CqlInterval<CqlDate>>(szzzzzzzzzh_, szzzzzzzzzi_);
        IEnumerable<CqlInterval<CqlDate>> szzzzzzzzzk_ = context.Operators.Distinct<CqlInterval<CqlDate>>(szzzzzzzzzj_);
        bool? szzzzzzzzzl_(object M)
        {
            bool szzzzzzzzzv_ = M is MedicationDispense;

            return szzzzzzzzzv_ as bool?;
        };
        IEnumerable<object> szzzzzzzzzm_ = context.Operators.Where<object>(Medications, szzzzzzzzzl_);
        CqlInterval<CqlDate> szzzzzzzzzn_(object M)
        {
            CqlInterval<CqlDate> szzzzzzzzzw_ = this.medicationDispensePeriod(context, M as MedicationDispense);

            return szzzzzzzzzw_;
        };
        IEnumerable<CqlInterval<CqlDate>> szzzzzzzzzo_ = context.Operators.Select<object, CqlInterval<CqlDate>>(szzzzzzzzzm_, szzzzzzzzzn_);
        IEnumerable<CqlInterval<CqlDate>> szzzzzzzzzp_ = context.Operators.Distinct<CqlInterval<CqlDate>>(szzzzzzzzzo_);
        IEnumerable<CqlInterval<CqlDate>> szzzzzzzzzq_ = this.rolloutIntervals(context, szzzzzzzzzp_);
        IEnumerable<CqlInterval<CqlDate>> szzzzzzzzzr_ = context.Operators.Union<CqlInterval<CqlDate>>(szzzzzzzzzk_, szzzzzzzzzq_);
        int? szzzzzzzzzs_ = this.cumulativeDuration(context, szzzzzzzzzr_);

        return szzzzzzzzzs_;
    }


    #endregion Expressions

}
