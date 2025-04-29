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
        object ezzzj_ = context.ResolveParameter("CumulativeMedicationDuration-4.1.000", "ErrorLevel", "Warning");

        return (string)ezzzj_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> ezzzk_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient ezzzl_ = context.Operators.SingletonFrom<Patient>(ezzzk_);

        return ezzzl_;
    }


    [CqlExpressionDefinition("ToDaily")]
    public decimal? ToDaily(CqlContext context, int? frequency, CqlQuantity period)
    {
        decimal? ezzzm_()
        {
            bool ezzzn_()
            {
                string fzzzi_ = period?.unit;
                bool? fzzzj_ = context.Operators.Equal(fzzzi_, "h");

                return fzzzj_ ?? false;
            };
            bool ezzzo_()
            {
                string fzzzk_ = period?.unit;
                bool? fzzzl_ = context.Operators.Equal(fzzzk_, "min");

                return fzzzl_ ?? false;
            };
            bool ezzzp_()
            {
                string fzzzm_ = period?.unit;
                bool? fzzzn_ = context.Operators.Equal(fzzzm_, "s");

                return fzzzn_ ?? false;
            };
            bool ezzzq_()
            {
                string fzzzo_ = period?.unit;
                bool? fzzzp_ = context.Operators.Equal(fzzzo_, "d");

                return fzzzp_ ?? false;
            };
            bool ezzzr_()
            {
                string fzzzq_ = period?.unit;
                bool? fzzzr_ = context.Operators.Equal(fzzzq_, "wk");

                return fzzzr_ ?? false;
            };
            bool ezzzs_()
            {
                string fzzzs_ = period?.unit;
                bool? fzzzt_ = context.Operators.Equal(fzzzs_, "mo");

                return fzzzt_ ?? false;
            };
            bool ezzzt_()
            {
                string fzzzu_ = period?.unit;
                bool? fzzzv_ = context.Operators.Equal(fzzzu_, "a");

                return fzzzv_ ?? false;
            };
            bool ezzzu_()
            {
                string fzzzw_ = period?.unit;
                bool? fzzzx_ = context.Operators.Equal(fzzzw_, "hour");

                return fzzzx_ ?? false;
            };
            bool ezzzv_()
            {
                string fzzzy_ = period?.unit;
                bool? fzzzz_ = context.Operators.Equal(fzzzy_, "minute");

                return fzzzz_ ?? false;
            };
            bool ezzzw_()
            {
                string gzzza_ = period?.unit;
                bool? gzzzb_ = context.Operators.Equal(gzzza_, "second");

                return gzzzb_ ?? false;
            };
            bool ezzzx_()
            {
                string gzzzc_ = period?.unit;
                bool? gzzzd_ = context.Operators.Equal(gzzzc_, "day");

                return gzzzd_ ?? false;
            };
            bool ezzzy_()
            {
                string gzzze_ = period?.unit;
                bool? gzzzf_ = context.Operators.Equal(gzzze_, "week");

                return gzzzf_ ?? false;
            };
            bool ezzzz_()
            {
                string gzzzg_ = period?.unit;
                bool? gzzzh_ = context.Operators.Equal(gzzzg_, "month");

                return gzzzh_ ?? false;
            };
            bool fzzza_()
            {
                string gzzzi_ = period?.unit;
                bool? gzzzj_ = context.Operators.Equal(gzzzi_, "year");

                return gzzzj_ ?? false;
            };
            bool fzzzb_()
            {
                string gzzzk_ = period?.unit;
                bool? gzzzl_ = context.Operators.Equal(gzzzk_, "hours");

                return gzzzl_ ?? false;
            };
            bool fzzzc_()
            {
                string gzzzm_ = period?.unit;
                bool? gzzzn_ = context.Operators.Equal(gzzzm_, "minutes");

                return gzzzn_ ?? false;
            };
            bool fzzzd_()
            {
                string gzzzo_ = period?.unit;
                bool? gzzzp_ = context.Operators.Equal(gzzzo_, "seconds");

                return gzzzp_ ?? false;
            };
            bool fzzze_()
            {
                string gzzzq_ = period?.unit;
                bool? gzzzr_ = context.Operators.Equal(gzzzq_, "days");

                return gzzzr_ ?? false;
            };
            bool fzzzf_()
            {
                string gzzzs_ = period?.unit;
                bool? gzzzt_ = context.Operators.Equal(gzzzs_, "weeks");

                return gzzzt_ ?? false;
            };
            bool fzzzg_()
            {
                string gzzzu_ = period?.unit;
                bool? gzzzv_ = context.Operators.Equal(gzzzu_, "months");

                return gzzzv_ ?? false;
            };
            bool fzzzh_()
            {
                string gzzzw_ = period?.unit;
                bool? gzzzx_ = context.Operators.Equal(gzzzw_, "years");

                return gzzzx_ ?? false;
            };
            if (ezzzn_())
            {
                decimal? gzzzy_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? gzzzz_ = period?.value;
                decimal? hzzza_ = context.Operators.Divide(24.0m, gzzzz_);
                decimal? hzzzb_ = context.Operators.Multiply(gzzzy_, hzzza_);

                return hzzzb_;
            }
            else if (ezzzo_())
            {
                decimal? hzzzc_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? hzzzd_ = period?.value;
                decimal? hzzze_ = context.Operators.Divide(24.0m, hzzzd_);
                decimal? hzzzf_ = context.Operators.Multiply(hzzzc_, hzzze_);
                decimal? hzzzg_ = context.Operators.ConvertIntegerToDecimal(60);
                decimal? hzzzh_ = context.Operators.Multiply(hzzzf_, hzzzg_);

                return hzzzh_;
            }
            else if (ezzzp_())
            {
                decimal? hzzzi_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? hzzzj_ = period?.value;
                decimal? hzzzk_ = context.Operators.Divide(24.0m, hzzzj_);
                decimal? hzzzl_ = context.Operators.Multiply(hzzzi_, hzzzk_);
                decimal? hzzzm_ = context.Operators.ConvertIntegerToDecimal(60);
                decimal? hzzzn_ = context.Operators.Multiply(hzzzl_, hzzzm_);
                decimal? hzzzp_ = context.Operators.Multiply(hzzzn_, hzzzm_);

                return hzzzp_;
            }
            else if (ezzzq_())
            {
                decimal? hzzzq_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? hzzzr_ = period?.value;
                decimal? hzzzs_ = context.Operators.Divide(24.0m, hzzzr_);
                decimal? hzzzt_ = context.Operators.Multiply(hzzzq_, hzzzs_);
                decimal? hzzzu_ = context.Operators.ConvertIntegerToDecimal(24);
                decimal? hzzzv_ = context.Operators.Divide(hzzzt_, hzzzu_);

                return hzzzv_;
            }
            else if (ezzzr_())
            {
                decimal? hzzzw_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? hzzzx_ = period?.value;
                decimal? hzzzy_ = context.Operators.Divide(24.0m, hzzzx_);
                decimal? hzzzz_ = context.Operators.Multiply(hzzzw_, hzzzy_);
                int? izzza_ = context.Operators.Multiply(24, 7);
                decimal? izzzb_ = context.Operators.ConvertIntegerToDecimal(izzza_);
                decimal? izzzc_ = context.Operators.Divide(hzzzz_, izzzb_);

                return izzzc_;
            }
            else if (ezzzs_())
            {
                decimal? izzzd_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? izzze_ = period?.value;
                decimal? izzzf_ = context.Operators.Divide(24.0m, izzze_);
                decimal? izzzg_ = context.Operators.Multiply(izzzd_, izzzf_);
                int? izzzh_ = context.Operators.Multiply(24, 30);
                decimal? izzzi_ = context.Operators.ConvertIntegerToDecimal(izzzh_);
                decimal? izzzj_ = context.Operators.Divide(izzzg_, izzzi_);

                return izzzj_;
            }
            else if (ezzzt_())
            {
                decimal? izzzk_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? izzzl_ = period?.value;
                decimal? izzzm_ = context.Operators.Divide(24.0m, izzzl_);
                decimal? izzzn_ = context.Operators.Multiply(izzzk_, izzzm_);
                int? izzzo_ = context.Operators.Multiply(24, 365);
                decimal? izzzp_ = context.Operators.ConvertIntegerToDecimal(izzzo_);
                decimal? izzzq_ = context.Operators.Divide(izzzn_, izzzp_);

                return izzzq_;
            }
            else if (ezzzu_())
            {
                decimal? izzzr_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? izzzs_ = period?.value;
                decimal? izzzt_ = context.Operators.Divide(24.0m, izzzs_);
                decimal? izzzu_ = context.Operators.Multiply(izzzr_, izzzt_);

                return izzzu_;
            }
            else if (ezzzv_())
            {
                decimal? izzzv_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? izzzw_ = period?.value;
                decimal? izzzx_ = context.Operators.Divide(24.0m, izzzw_);
                decimal? izzzy_ = context.Operators.Multiply(izzzv_, izzzx_);
                decimal? izzzz_ = context.Operators.ConvertIntegerToDecimal(60);
                decimal? jzzza_ = context.Operators.Multiply(izzzy_, izzzz_);

                return jzzza_;
            }
            else if (ezzzw_())
            {
                decimal? jzzzb_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? jzzzc_ = period?.value;
                decimal? jzzzd_ = context.Operators.Divide(24.0m, jzzzc_);
                decimal? jzzze_ = context.Operators.Multiply(jzzzb_, jzzzd_);
                decimal? jzzzf_ = context.Operators.ConvertIntegerToDecimal(60);
                decimal? jzzzg_ = context.Operators.Multiply(jzzze_, jzzzf_);
                decimal? jzzzi_ = context.Operators.Multiply(jzzzg_, jzzzf_);

                return jzzzi_;
            }
            else if (ezzzx_())
            {
                decimal? jzzzj_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? jzzzk_ = period?.value;
                decimal? jzzzl_ = context.Operators.Divide(24.0m, jzzzk_);
                decimal? jzzzm_ = context.Operators.Multiply(jzzzj_, jzzzl_);
                decimal? jzzzn_ = context.Operators.ConvertIntegerToDecimal(24);
                decimal? jzzzo_ = context.Operators.Divide(jzzzm_, jzzzn_);

                return jzzzo_;
            }
            else if (ezzzy_())
            {
                decimal? jzzzp_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? jzzzq_ = period?.value;
                decimal? jzzzr_ = context.Operators.Divide(24.0m, jzzzq_);
                decimal? jzzzs_ = context.Operators.Multiply(jzzzp_, jzzzr_);
                int? jzzzt_ = context.Operators.Multiply(24, 7);
                decimal? jzzzu_ = context.Operators.ConvertIntegerToDecimal(jzzzt_);
                decimal? jzzzv_ = context.Operators.Divide(jzzzs_, jzzzu_);

                return jzzzv_;
            }
            else if (ezzzz_())
            {
                decimal? jzzzw_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? jzzzx_ = period?.value;
                decimal? jzzzy_ = context.Operators.Divide(24.0m, jzzzx_);
                decimal? jzzzz_ = context.Operators.Multiply(jzzzw_, jzzzy_);
                int? kzzza_ = context.Operators.Multiply(24, 30);
                decimal? kzzzb_ = context.Operators.ConvertIntegerToDecimal(kzzza_);
                decimal? kzzzc_ = context.Operators.Divide(jzzzz_, kzzzb_);

                return kzzzc_;
            }
            else if (fzzza_())
            {
                decimal? kzzzd_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? kzzze_ = period?.value;
                decimal? kzzzf_ = context.Operators.Divide(24.0m, kzzze_);
                decimal? kzzzg_ = context.Operators.Multiply(kzzzd_, kzzzf_);
                int? kzzzh_ = context.Operators.Multiply(24, 365);
                decimal? kzzzi_ = context.Operators.ConvertIntegerToDecimal(kzzzh_);
                decimal? kzzzj_ = context.Operators.Divide(kzzzg_, kzzzi_);

                return kzzzj_;
            }
            else if (fzzzb_())
            {
                decimal? kzzzk_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? kzzzl_ = period?.value;
                decimal? kzzzm_ = context.Operators.Divide(24.0m, kzzzl_);
                decimal? kzzzn_ = context.Operators.Multiply(kzzzk_, kzzzm_);

                return kzzzn_;
            }
            else if (fzzzc_())
            {
                decimal? kzzzo_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? kzzzp_ = period?.value;
                decimal? kzzzq_ = context.Operators.Divide(24.0m, kzzzp_);
                decimal? kzzzr_ = context.Operators.Multiply(kzzzo_, kzzzq_);
                decimal? kzzzs_ = context.Operators.ConvertIntegerToDecimal(60);
                decimal? kzzzt_ = context.Operators.Multiply(kzzzr_, kzzzs_);

                return kzzzt_;
            }
            else if (fzzzd_())
            {
                decimal? kzzzu_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? kzzzv_ = period?.value;
                decimal? kzzzw_ = context.Operators.Divide(24.0m, kzzzv_);
                decimal? kzzzx_ = context.Operators.Multiply(kzzzu_, kzzzw_);
                decimal? kzzzy_ = context.Operators.ConvertIntegerToDecimal(60);
                decimal? kzzzz_ = context.Operators.Multiply(kzzzx_, kzzzy_);
                decimal? lzzzb_ = context.Operators.Multiply(kzzzz_, kzzzy_);

                return lzzzb_;
            }
            else if (fzzze_())
            {
                decimal? lzzzc_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? lzzzd_ = period?.value;
                decimal? lzzze_ = context.Operators.Divide(24.0m, lzzzd_);
                decimal? lzzzf_ = context.Operators.Multiply(lzzzc_, lzzze_);
                decimal? lzzzg_ = context.Operators.ConvertIntegerToDecimal(24);
                decimal? lzzzh_ = context.Operators.Divide(lzzzf_, lzzzg_);

                return lzzzh_;
            }
            else if (fzzzf_())
            {
                decimal? lzzzi_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? lzzzj_ = period?.value;
                decimal? lzzzk_ = context.Operators.Divide(24.0m, lzzzj_);
                decimal? lzzzl_ = context.Operators.Multiply(lzzzi_, lzzzk_);
                int? lzzzm_ = context.Operators.Multiply(24, 7);
                decimal? lzzzn_ = context.Operators.ConvertIntegerToDecimal(lzzzm_);
                decimal? lzzzo_ = context.Operators.Divide(lzzzl_, lzzzn_);

                return lzzzo_;
            }
            else if (fzzzg_())
            {
                decimal? lzzzp_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? lzzzq_ = period?.value;
                decimal? lzzzr_ = context.Operators.Divide(24.0m, lzzzq_);
                decimal? lzzzs_ = context.Operators.Multiply(lzzzp_, lzzzr_);
                int? lzzzt_ = context.Operators.Multiply(24, 30);
                decimal? lzzzu_ = context.Operators.ConvertIntegerToDecimal(lzzzt_);
                decimal? lzzzv_ = context.Operators.Divide(lzzzs_, lzzzu_);

                return lzzzv_;
            }
            else if (fzzzh_())
            {
                decimal? lzzzw_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? lzzzx_ = period?.value;
                decimal? lzzzy_ = context.Operators.Divide(24.0m, lzzzx_);
                decimal? lzzzz_ = context.Operators.Multiply(lzzzw_, lzzzy_);
                int? mzzza_ = context.Operators.Multiply(24, 365);
                decimal? mzzzb_ = context.Operators.ConvertIntegerToDecimal(mzzza_);
                decimal? mzzzc_ = context.Operators.Divide(lzzzz_, mzzzb_);

                return mzzzc_;
            }
            else
            {
                string mzzzd_ = this.ErrorLevel(context);
                string mzzze_ = period?.unit;
                string mzzzf_ = context.Operators.Concatenate("Unknown unit ", mzzze_ ?? "");
                object mzzzg_ = context.Operators.Message<object>(null, "CMDLogic.ToDaily.UnknownUnit", mzzzd_, mzzzf_);

                return mzzzg_ as decimal?;
            }
        };

        return ezzzm_();
    }


    [CqlExpressionDefinition("ToDaily")]
    public decimal? ToDaily(CqlContext context, CqlCode frequency)
    {
        decimal? mzzzh_()
        {
            bool mzzzi_()
            {
                CqlCode ozzzd_ = this.HS(context);
                bool? ozzze_ = context.Operators.Equivalent(frequency, ozzzd_);

                return ozzze_ ?? false;
            };
            bool mzzzj_()
            {
                CqlCode ozzzf_ = this.WAKE(context);
                bool? ozzzg_ = context.Operators.Equivalent(frequency, ozzzf_);

                return ozzzg_ ?? false;
            };
            bool mzzzk_()
            {
                CqlCode ozzzh_ = this.C(context);
                bool? ozzzi_ = context.Operators.Equivalent(frequency, ozzzh_);

                return ozzzi_ ?? false;
            };
            bool mzzzl_()
            {
                CqlCode ozzzj_ = this.CM(context);
                bool? ozzzk_ = context.Operators.Equivalent(frequency, ozzzj_);

                return ozzzk_ ?? false;
            };
            bool mzzzm_()
            {
                CqlCode ozzzl_ = this.CD(context);
                bool? ozzzm_ = context.Operators.Equivalent(frequency, ozzzl_);

                return ozzzm_ ?? false;
            };
            bool mzzzn_()
            {
                CqlCode ozzzn_ = this.CV(context);
                bool? ozzzo_ = context.Operators.Equivalent(frequency, ozzzn_);

                return ozzzo_ ?? false;
            };
            bool mzzzo_()
            {
                CqlCode ozzzp_ = this.AC(context);
                bool? ozzzq_ = context.Operators.Equivalent(frequency, ozzzp_);

                return ozzzq_ ?? false;
            };
            bool mzzzp_()
            {
                CqlCode ozzzr_ = this.ACM(context);
                bool? ozzzs_ = context.Operators.Equivalent(frequency, ozzzr_);

                return ozzzs_ ?? false;
            };
            bool mzzzq_()
            {
                CqlCode ozzzt_ = this.ACD(context);
                bool? ozzzu_ = context.Operators.Equivalent(frequency, ozzzt_);

                return ozzzu_ ?? false;
            };
            bool mzzzr_()
            {
                CqlCode ozzzv_ = this.ACV(context);
                bool? ozzzw_ = context.Operators.Equivalent(frequency, ozzzv_);

                return ozzzw_ ?? false;
            };
            bool mzzzs_()
            {
                CqlCode ozzzx_ = this.PC(context);
                bool? ozzzy_ = context.Operators.Equivalent(frequency, ozzzx_);

                return ozzzy_ ?? false;
            };
            bool mzzzt_()
            {
                CqlCode ozzzz_ = this.PCM(context);
                bool? pzzza_ = context.Operators.Equivalent(frequency, ozzzz_);

                return pzzza_ ?? false;
            };
            bool mzzzu_()
            {
                CqlCode pzzzb_ = this.PCD(context);
                bool? pzzzc_ = context.Operators.Equivalent(frequency, pzzzb_);

                return pzzzc_ ?? false;
            };
            bool mzzzv_()
            {
                CqlCode pzzzd_ = this.PCV(context);
                bool? pzzze_ = context.Operators.Equivalent(frequency, pzzzd_);

                return pzzze_ ?? false;
            };
            bool mzzzw_()
            {
                CqlCode pzzzf_ = this.MORN(context);
                bool? pzzzg_ = context.Operators.Equivalent(frequency, pzzzf_);

                return pzzzg_ ?? false;
            };
            bool mzzzx_()
            {
                CqlCode pzzzh_ = this.MORN_early(context);
                bool? pzzzi_ = context.Operators.Equivalent(frequency, pzzzh_);

                return pzzzi_ ?? false;
            };
            bool mzzzy_()
            {
                CqlCode pzzzj_ = this.MORN_late(context);
                bool? pzzzk_ = context.Operators.Equivalent(frequency, pzzzj_);

                return pzzzk_ ?? false;
            };
            bool mzzzz_()
            {
                CqlCode pzzzl_ = this.NOON(context);
                bool? pzzzm_ = context.Operators.Equivalent(frequency, pzzzl_);

                return pzzzm_ ?? false;
            };
            bool nzzza_()
            {
                CqlCode pzzzn_ = this.AFT(context);
                bool? pzzzo_ = context.Operators.Equivalent(frequency, pzzzn_);

                return pzzzo_ ?? false;
            };
            bool nzzzb_()
            {
                CqlCode pzzzp_ = this.AFT_early(context);
                bool? pzzzq_ = context.Operators.Equivalent(frequency, pzzzp_);

                return pzzzq_ ?? false;
            };
            bool nzzzc_()
            {
                CqlCode pzzzr_ = this.AFT_late(context);
                bool? pzzzs_ = context.Operators.Equivalent(frequency, pzzzr_);

                return pzzzs_ ?? false;
            };
            bool nzzzd_()
            {
                CqlCode pzzzt_ = this.EVE(context);
                bool? pzzzu_ = context.Operators.Equivalent(frequency, pzzzt_);

                return pzzzu_ ?? false;
            };
            bool nzzze_()
            {
                CqlCode pzzzv_ = this.EVE_early(context);
                bool? pzzzw_ = context.Operators.Equivalent(frequency, pzzzv_);

                return pzzzw_ ?? false;
            };
            bool nzzzf_()
            {
                CqlCode pzzzx_ = this.EVE_late(context);
                bool? pzzzy_ = context.Operators.Equivalent(frequency, pzzzx_);

                return pzzzy_ ?? false;
            };
            bool nzzzg_()
            {
                CqlCode pzzzz_ = this.NIGHT(context);
                bool? qzzza_ = context.Operators.Equivalent(frequency, pzzzz_);

                return qzzza_ ?? false;
            };
            bool nzzzh_()
            {
                CqlCode qzzzb_ = this.PHS(context);
                bool? qzzzc_ = context.Operators.Equivalent(frequency, qzzzb_);

                return qzzzc_ ?? false;
            };
            bool nzzzi_()
            {
                CqlCode qzzzd_ = this.Once_daily__qualifier_value_(context);
                bool? qzzze_ = context.Operators.Equivalent(frequency, qzzzd_);

                return qzzze_ ?? false;
            };
            bool nzzzj_()
            {
                CqlCode qzzzf_ = this.Twice_a_day__qualifier_value_(context);
                bool? qzzzg_ = context.Operators.Equivalent(frequency, qzzzf_);

                return qzzzg_ ?? false;
            };
            bool nzzzk_()
            {
                CqlCode qzzzh_ = this.Three_times_daily__qualifier_value_(context);
                bool? qzzzi_ = context.Operators.Equivalent(frequency, qzzzh_);

                return qzzzi_ ?? false;
            };
            bool nzzzl_()
            {
                CqlCode qzzzj_ = this.Four_times_daily__qualifier_value_(context);
                bool? qzzzk_ = context.Operators.Equivalent(frequency, qzzzj_);

                return qzzzk_ ?? false;
            };
            bool nzzzm_()
            {
                CqlCode qzzzl_ = this.Every_twenty_four_hours__qualifier_value_(context);
                bool? qzzzm_ = context.Operators.Equivalent(frequency, qzzzl_);

                return qzzzm_ ?? false;
            };
            bool nzzzn_()
            {
                CqlCode qzzzn_ = this.Every_twelve_hours__qualifier_value_(context);
                bool? qzzzo_ = context.Operators.Equivalent(frequency, qzzzn_);

                return qzzzo_ ?? false;
            };
            bool nzzzo_()
            {
                CqlCode qzzzp_ = this.Every_thirty_six_hours__qualifier_value_(context);
                bool? qzzzq_ = context.Operators.Equivalent(frequency, qzzzp_);

                return qzzzq_ ?? false;
            };
            bool nzzzp_()
            {
                CqlCode qzzzr_ = this.Every_eight_hours__qualifier_value_(context);
                bool? qzzzs_ = context.Operators.Equivalent(frequency, qzzzr_);

                return qzzzs_ ?? false;
            };
            bool nzzzq_()
            {
                CqlCode qzzzt_ = this.Every_four_hours__qualifier_value_(context);
                bool? qzzzu_ = context.Operators.Equivalent(frequency, qzzzt_);

                return qzzzu_ ?? false;
            };
            bool nzzzr_()
            {
                CqlCode qzzzv_ = this.Every_six_hours__qualifier_value_(context);
                bool? qzzzw_ = context.Operators.Equivalent(frequency, qzzzv_);

                return qzzzw_ ?? false;
            };
            bool nzzzs_()
            {
                CqlCode qzzzx_ = this.Every_seventy_two_hours__qualifier_value_(context);
                bool? qzzzy_ = context.Operators.Equivalent(frequency, qzzzx_);

                return qzzzy_ ?? false;
            };
            bool nzzzt_()
            {
                CqlCode qzzzz_ = this.Every_forty_eight_hours__qualifier_value_(context);
                bool? rzzza_ = context.Operators.Equivalent(frequency, qzzzz_);

                return rzzza_ ?? false;
            };
            bool nzzzu_()
            {
                CqlCode rzzzb_ = this.Every_eight_to_twelve_hours__qualifier_value_(context);
                bool? rzzzc_ = context.Operators.Equivalent(frequency, rzzzb_);

                return rzzzc_ ?? false;
            };
            bool nzzzv_()
            {
                CqlCode rzzzd_ = this.Every_six_to_eight_hours__qualifier_value_(context);
                bool? rzzze_ = context.Operators.Equivalent(frequency, rzzzd_);

                return rzzze_ ?? false;
            };
            bool nzzzw_()
            {
                CqlCode rzzzf_ = this.Every_three_to_four_hours__qualifier_value_(context);
                bool? rzzzg_ = context.Operators.Equivalent(frequency, rzzzf_);

                return rzzzg_ ?? false;
            };
            bool nzzzx_()
            {
                CqlCode rzzzh_ = this.Every_three_to_six_hours__qualifier_value_(context);
                bool? rzzzi_ = context.Operators.Equivalent(frequency, rzzzh_);

                return rzzzi_ ?? false;
            };
            bool nzzzy_()
            {
                CqlCode rzzzj_ = this.Every_two_to_four_hours__qualifier_value_(context);
                bool? rzzzk_ = context.Operators.Equivalent(frequency, rzzzj_);

                return rzzzk_ ?? false;
            };
            bool nzzzz_()
            {
                CqlCode rzzzl_ = this.One_to_four_times_a_day__qualifier_value_(context);
                bool? rzzzm_ = context.Operators.Equivalent(frequency, rzzzl_);

                return rzzzm_ ?? false;
            };
            bool ozzza_()
            {
                CqlCode rzzzn_ = this.One_to_three_times_a_day__qualifier_value_(context);
                bool? rzzzo_ = context.Operators.Equivalent(frequency, rzzzn_);

                return rzzzo_ ?? false;
            };
            bool ozzzb_()
            {
                CqlCode rzzzp_ = this.One_to_two_times_a_day__qualifier_value_(context);
                bool? rzzzq_ = context.Operators.Equivalent(frequency, rzzzp_);

                return rzzzq_ ?? false;
            };
            bool ozzzc_()
            {
                CqlCode rzzzr_ = this.Two_to_four_times_a_day__qualifier_value_(context);
                bool? rzzzs_ = context.Operators.Equivalent(frequency, rzzzr_);

                return rzzzs_ ?? false;
            };
            if (mzzzi_())
            {
                decimal? rzzzt_ = context.Operators.ConvertIntegerToDecimal(1);

                return rzzzt_;
            }
            else if (mzzzj_())
            {
                decimal? rzzzu_ = context.Operators.ConvertIntegerToDecimal(1);

                return rzzzu_;
            }
            else if (mzzzk_())
            {
                decimal? rzzzv_ = context.Operators.ConvertIntegerToDecimal(3);

                return rzzzv_;
            }
            else if (mzzzl_())
            {
                decimal? rzzzw_ = context.Operators.ConvertIntegerToDecimal(1);

                return rzzzw_;
            }
            else if (mzzzm_())
            {
                decimal? rzzzx_ = context.Operators.ConvertIntegerToDecimal(1);

                return rzzzx_;
            }
            else if (mzzzn_())
            {
                decimal? rzzzy_ = context.Operators.ConvertIntegerToDecimal(1);

                return rzzzy_;
            }
            else if (mzzzo_())
            {
                decimal? rzzzz_ = context.Operators.ConvertIntegerToDecimal(3);

                return rzzzz_;
            }
            else if (mzzzp_())
            {
                decimal? szzza_ = context.Operators.ConvertIntegerToDecimal(1);

                return szzza_;
            }
            else if (mzzzq_())
            {
                decimal? szzzb_ = context.Operators.ConvertIntegerToDecimal(1);

                return szzzb_;
            }
            else if (mzzzr_())
            {
                decimal? szzzc_ = context.Operators.ConvertIntegerToDecimal(1);

                return szzzc_;
            }
            else if (mzzzs_())
            {
                decimal? szzzd_ = context.Operators.ConvertIntegerToDecimal(3);

                return szzzd_;
            }
            else if (mzzzt_())
            {
                decimal? szzze_ = context.Operators.ConvertIntegerToDecimal(1);

                return szzze_;
            }
            else if (mzzzu_())
            {
                decimal? szzzf_ = context.Operators.ConvertIntegerToDecimal(1);

                return szzzf_;
            }
            else if (mzzzv_())
            {
                decimal? szzzg_ = context.Operators.ConvertIntegerToDecimal(1);

                return szzzg_;
            }
            else if (mzzzw_())
            {
                decimal? szzzh_ = context.Operators.ConvertIntegerToDecimal(1);

                return szzzh_;
            }
            else if (mzzzx_())
            {
                decimal? szzzi_ = context.Operators.ConvertIntegerToDecimal(1);

                return szzzi_;
            }
            else if (mzzzy_())
            {
                decimal? szzzj_ = context.Operators.ConvertIntegerToDecimal(1);

                return szzzj_;
            }
            else if (mzzzz_())
            {
                decimal? szzzk_ = context.Operators.ConvertIntegerToDecimal(1);

                return szzzk_;
            }
            else if (nzzza_())
            {
                decimal? szzzl_ = context.Operators.ConvertIntegerToDecimal(1);

                return szzzl_;
            }
            else if (nzzzb_())
            {
                decimal? szzzm_ = context.Operators.ConvertIntegerToDecimal(1);

                return szzzm_;
            }
            else if (nzzzc_())
            {
                decimal? szzzn_ = context.Operators.ConvertIntegerToDecimal(1);

                return szzzn_;
            }
            else if (nzzzd_())
            {
                decimal? szzzo_ = context.Operators.ConvertIntegerToDecimal(1);

                return szzzo_;
            }
            else if (nzzze_())
            {
                decimal? szzzp_ = context.Operators.ConvertIntegerToDecimal(1);

                return szzzp_;
            }
            else if (nzzzf_())
            {
                decimal? szzzq_ = context.Operators.ConvertIntegerToDecimal(1);

                return szzzq_;
            }
            else if (nzzzg_())
            {
                decimal? szzzr_ = context.Operators.ConvertIntegerToDecimal(1);

                return szzzr_;
            }
            else if (nzzzh_())
            {
                decimal? szzzs_ = context.Operators.ConvertIntegerToDecimal(1);

                return szzzs_;
            }
            else if (nzzzi_())
            {
                return 1.0m;
            }
            else if (nzzzj_())
            {
                return 2.0m;
            }
            else if (nzzzk_())
            {
                return 3.0m;
            }
            else if (nzzzl_())
            {
                return 4.0m;
            }
            else if (nzzzm_())
            {
                return 1.0m;
            }
            else if (nzzzn_())
            {
                return 2.0m;
            }
            else if (nzzzo_())
            {
                return 0.67m;
            }
            else if (nzzzp_())
            {
                return 3.0m;
            }
            else if (nzzzq_())
            {
                return 6.0m;
            }
            else if (nzzzr_())
            {
                return 4.0m;
            }
            else if (nzzzs_())
            {
                return 0.33m;
            }
            else if (nzzzt_())
            {
                return 0.5m;
            }
            else if (nzzzu_())
            {
                return 3.0m;
            }
            else if (nzzzv_())
            {
                return 4.0m;
            }
            else if (nzzzw_())
            {
                return 8.0m;
            }
            else if (nzzzx_())
            {
                return 8.0m;
            }
            else if (nzzzy_())
            {
                return 12.0m;
            }
            else if (nzzzz_())
            {
                return 4.0m;
            }
            else if (ozzza_())
            {
                return 3.0m;
            }
            else if (ozzzb_())
            {
                return 2.0m;
            }
            else if (ozzzc_())
            {
                return 4.0m;
            }
            else
            {
                string szzzt_ = this.ErrorLevel(context);
                string szzzu_ = frequency?.code;
                string szzzv_ = context.Operators.Concatenate("Unknown frequency code ", szzzu_ ?? "");
                object szzzw_ = context.Operators.Message<object>(null, "CMDLogic.ToDaily.UnknownFrequencyCode", szzzt_, szzzv_);

                return szzzw_ as decimal?;
            }
        };

        return mzzzh_();
    }


    [CqlExpressionDefinition("Quantity")]
    public CqlQuantity Quantity(CqlContext context, decimal? value, string unit) =>
        ((context.Operators.Not((bool?)(value is null))) ?? false
            ? new CqlQuantity(value, unit)
            : default);


    [CqlExpressionDefinition("MedicationRequestPeriod")]
    public CqlInterval<CqlDate> MedicationRequestPeriod(CqlContext context, MedicationRequest Request)
    {
        MedicationRequest[] szzzx_ = [
            Request,
        ];
        CqlInterval<CqlDate> szzzy_(MedicationRequest R)
        {
            CqlInterval<CqlDate> tzzzc_()
            {
                bool tzzzd_()
                {
                    List<Dosage> tzzzf_ = R?.DosageInstruction;
                    Dosage tzzzg_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)tzzzf_);
                    Timing tzzzh_ = tzzzg_?.Timing;
                    Timing.RepeatComponent tzzzi_ = tzzzh_?.Repeat;
                    DataType tzzzj_ = tzzzi_?.Bounds;
                    object tzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzj_);
                    CqlDateTime tzzzl_ = context.Operators.Start(tzzzk_ as CqlInterval<CqlDateTime>);
                    CqlDate tzzzm_ = context.Operators.DateFrom(tzzzl_);
                    FhirDateTime tzzzn_ = R?.AuthoredOnElement;
                    CqlDateTime tzzzo_ = context.Operators.Convert<CqlDateTime>(tzzzn_);
                    CqlDate tzzzp_ = context.Operators.DateFrom(tzzzo_);
                    MedicationRequest.DispenseRequestComponent tzzzq_ = R?.DispenseRequest;
                    Period tzzzr_ = tzzzq_?.ValidityPeriod;
                    CqlInterval<CqlDateTime> tzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzr_);
                    CqlDateTime tzzzt_ = context.Operators.Start(tzzzs_);
                    CqlDate tzzzu_ = context.Operators.DateFrom(tzzzt_);
                    bool? tzzzv_ = context.Operators.Not((bool?)(((tzzzm_ ?? tzzzp_) ?? tzzzu_) is null));
                    Duration tzzzx_ = tzzzq_?.ExpectedSupplyDuration;
                    CqlQuantity tzzzy_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, tzzzx_);
                    CqlQuantity tzzzz_ = context.Operators.ConvertQuantity(tzzzy_, "d");
                    decimal? uzzza_ = tzzzz_?.value;
                    Quantity uzzzc_ = tzzzq_?.Quantity;
                    CqlQuantity uzzzd_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, uzzzc_);
                    decimal? uzzze_ = uzzzd_?.value;
                    Dosage uzzzg_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)tzzzf_);
                    List<Dosage.DoseAndRateComponent> uzzzh_ = uzzzg_?.DoseAndRate;
                    Dosage.DoseAndRateComponent uzzzi_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)uzzzh_);
                    DataType uzzzj_ = uzzzi_?.Dose;
                    object uzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzj_);
                    CqlQuantity uzzzl_ = context.Operators.End(uzzzk_ as CqlInterval<CqlQuantity>);
                    Dosage uzzzn_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)tzzzf_);
                    List<Dosage.DoseAndRateComponent> uzzzo_ = uzzzn_?.DoseAndRate;
                    Dosage.DoseAndRateComponent uzzzp_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)uzzzo_);
                    DataType uzzzq_ = uzzzp_?.Dose;
                    object uzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzq_);
                    decimal? uzzzs_ = (uzzzl_ ?? uzzzr_ as CqlQuantity)?.value;
                    Dosage uzzzu_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)tzzzf_);
                    Timing uzzzv_ = uzzzu_?.Timing;
                    Timing.RepeatComponent uzzzw_ = uzzzv_?.Repeat;
                    PositiveInt uzzzx_ = uzzzw_?.FrequencyMaxElement;
                    int? uzzzy_ = uzzzx_?.Value;
                    Dosage vzzza_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)tzzzf_);
                    Timing vzzzb_ = vzzza_?.Timing;
                    Timing.RepeatComponent vzzzc_ = vzzzb_?.Repeat;
                    PositiveInt vzzzd_ = vzzzc_?.FrequencyElement;
                    int? vzzze_ = vzzzd_?.Value;
                    Dosage vzzzg_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)tzzzf_);
                    Timing vzzzh_ = vzzzg_?.Timing;
                    Timing.RepeatComponent vzzzi_ = vzzzh_?.Repeat;
                    FhirDecimal vzzzj_ = vzzzi_?.PeriodElement;
                    decimal? vzzzk_ = vzzzj_?.Value;
                    Dosage vzzzm_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)tzzzf_);
                    Timing vzzzn_ = vzzzm_?.Timing;
                    Timing.RepeatComponent vzzzo_ = vzzzn_?.Repeat;
                    Code<Timing.UnitsOfTime> vzzzp_ = vzzzo_?.PeriodUnitElement;
                    Timing.UnitsOfTime? vzzzq_ = vzzzp_?.Value;
                    string vzzzr_ = context.Operators.Convert<string>(vzzzq_);
                    CqlQuantity vzzzs_ = this.Quantity(context, vzzzk_, vzzzr_);
                    decimal? vzzzt_ = this.ToDaily(context, uzzzy_ ?? vzzze_, vzzzs_);
                    Dosage vzzzv_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)tzzzf_);
                    Timing vzzzw_ = vzzzv_?.Timing;
                    Timing.RepeatComponent vzzzx_ = vzzzw_?.Repeat;
                    List<Time> vzzzy_ = vzzzx_?.TimeOfDayElement;
                    IEnumerable<CqlTime> vzzzz_ = context.Operators.LateBoundProperty<IEnumerable<CqlTime>>(vzzzy_, "value");
                    int? wzzza_ = context.Operators.Count<CqlTime>(vzzzz_);
                    decimal? wzzzb_ = context.Operators.ConvertIntegerToDecimal(wzzza_);
                    decimal? wzzzc_ = context.Operators.Multiply(uzzzs_, (vzzzt_ ?? wzzzb_) ?? 1.0m);
                    decimal? wzzzd_ = context.Operators.Divide(uzzze_, wzzzc_);
                    UnsignedInt wzzzf_ = tzzzq_?.NumberOfRepeatsAllowedElement;
                    int? wzzzg_ = wzzzf_?.Value;
                    int? wzzzh_ = context.Operators.Add(1, wzzzg_ ?? 0);
                    decimal? wzzzi_ = context.Operators.ConvertIntegerToDecimal(wzzzh_);
                    decimal? wzzzj_ = context.Operators.Multiply(uzzza_ ?? wzzzd_, wzzzi_);
                    bool? wzzzk_ = context.Operators.Not((bool?)(wzzzj_ is null));
                    bool? wzzzl_ = context.Operators.And(tzzzv_, wzzzk_);

                    return wzzzl_ ?? false;
                };
                bool tzzze_()
                {
                    List<Dosage> wzzzm_ = R?.DosageInstruction;
                    Dosage wzzzn_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)wzzzm_);
                    Timing wzzzo_ = wzzzn_?.Timing;
                    Timing.RepeatComponent wzzzp_ = wzzzo_?.Repeat;
                    DataType wzzzq_ = wzzzp_?.Bounds;
                    object wzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzq_);
                    CqlDateTime wzzzs_ = context.Operators.Start(wzzzr_ as CqlInterval<CqlDateTime>);
                    CqlDate wzzzt_ = context.Operators.DateFrom(wzzzs_);
                    FhirDateTime wzzzu_ = R?.AuthoredOnElement;
                    CqlDateTime wzzzv_ = context.Operators.Convert<CqlDateTime>(wzzzu_);
                    CqlDate wzzzw_ = context.Operators.DateFrom(wzzzv_);
                    MedicationRequest.DispenseRequestComponent wzzzx_ = R?.DispenseRequest;
                    Period wzzzy_ = wzzzx_?.ValidityPeriod;
                    CqlInterval<CqlDateTime> wzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzy_);
                    CqlDateTime xzzza_ = context.Operators.Start(wzzzz_);
                    CqlDate xzzzb_ = context.Operators.DateFrom(xzzza_);
                    bool? xzzzc_ = context.Operators.Not((bool?)(((wzzzt_ ?? wzzzw_) ?? xzzzb_) is null));
                    Dosage xzzze_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)wzzzm_);
                    Timing xzzzf_ = xzzze_?.Timing;
                    Timing.RepeatComponent xzzzg_ = xzzzf_?.Repeat;
                    DataType xzzzh_ = xzzzg_?.Bounds;
                    object xzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzh_);
                    CqlDateTime xzzzj_ = (xzzzi_ as CqlInterval<CqlDateTime>)?.high;
                    bool? xzzzk_ = context.Operators.Not((bool?)(xzzzj_ is null));
                    bool? xzzzl_ = context.Operators.And(xzzzc_, xzzzk_);

                    return xzzzl_ ?? false;
                };
                if (tzzzd_())
                {
                    List<Dosage> xzzzm_ = R?.DosageInstruction;
                    Dosage xzzzn_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)xzzzm_);
                    Timing xzzzo_ = xzzzn_?.Timing;
                    Timing.RepeatComponent xzzzp_ = xzzzo_?.Repeat;
                    DataType xzzzq_ = xzzzp_?.Bounds;
                    object xzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzq_);
                    CqlDateTime xzzzs_ = context.Operators.Start(xzzzr_ as CqlInterval<CqlDateTime>);
                    CqlDate xzzzt_ = context.Operators.DateFrom(xzzzs_);
                    FhirDateTime xzzzu_ = R?.AuthoredOnElement;
                    CqlDateTime xzzzv_ = context.Operators.Convert<CqlDateTime>(xzzzu_);
                    CqlDate xzzzw_ = context.Operators.DateFrom(xzzzv_);
                    MedicationRequest.DispenseRequestComponent xzzzx_ = R?.DispenseRequest;
                    Period xzzzy_ = xzzzx_?.ValidityPeriod;
                    CqlInterval<CqlDateTime> xzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzy_);
                    CqlDateTime yzzza_ = context.Operators.Start(xzzzz_);
                    CqlDate yzzzb_ = context.Operators.DateFrom(yzzza_);
                    Dosage yzzzd_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)xzzzm_);
                    Timing yzzze_ = yzzzd_?.Timing;
                    Timing.RepeatComponent yzzzf_ = yzzze_?.Repeat;
                    DataType yzzzg_ = yzzzf_?.Bounds;
                    object yzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzg_);
                    CqlDateTime yzzzi_ = context.Operators.Start(yzzzh_ as CqlInterval<CqlDateTime>);
                    CqlDate yzzzj_ = context.Operators.DateFrom(yzzzi_);
                    CqlDateTime yzzzl_ = context.Operators.Convert<CqlDateTime>(xzzzu_);
                    CqlDate yzzzm_ = context.Operators.DateFrom(yzzzl_);
                    Period yzzzo_ = xzzzx_?.ValidityPeriod;
                    CqlInterval<CqlDateTime> yzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzo_);
                    CqlDateTime yzzzq_ = context.Operators.Start(yzzzp_);
                    CqlDate yzzzr_ = context.Operators.DateFrom(yzzzq_);
                    Duration yzzzt_ = xzzzx_?.ExpectedSupplyDuration;
                    CqlQuantity yzzzu_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, yzzzt_);
                    CqlQuantity yzzzv_ = context.Operators.ConvertQuantity(yzzzu_, "d");
                    decimal? yzzzw_ = yzzzv_?.value;
                    Quantity yzzzy_ = xzzzx_?.Quantity;
                    CqlQuantity yzzzz_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, yzzzy_);
                    decimal? zzzza_ = yzzzz_?.value;
                    Dosage zzzzc_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)xzzzm_);
                    List<Dosage.DoseAndRateComponent> zzzzd_ = zzzzc_?.DoseAndRate;
                    Dosage.DoseAndRateComponent zzzze_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)zzzzd_);
                    DataType zzzzf_ = zzzze_?.Dose;
                    object zzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzf_);
                    CqlQuantity zzzzh_ = context.Operators.End(zzzzg_ as CqlInterval<CqlQuantity>);
                    Dosage zzzzj_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)xzzzm_);
                    List<Dosage.DoseAndRateComponent> zzzzk_ = zzzzj_?.DoseAndRate;
                    Dosage.DoseAndRateComponent zzzzl_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)zzzzk_);
                    DataType zzzzm_ = zzzzl_?.Dose;
                    object zzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzm_);
                    decimal? zzzzo_ = (zzzzh_ ?? zzzzn_ as CqlQuantity)?.value;
                    Dosage zzzzq_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)xzzzm_);
                    Timing zzzzr_ = zzzzq_?.Timing;
                    Timing.RepeatComponent zzzzs_ = zzzzr_?.Repeat;
                    PositiveInt zzzzt_ = zzzzs_?.FrequencyMaxElement;
                    int? zzzzu_ = zzzzt_?.Value;
                    Dosage zzzzw_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)xzzzm_);
                    Timing zzzzx_ = zzzzw_?.Timing;
                    Timing.RepeatComponent zzzzy_ = zzzzx_?.Repeat;
                    PositiveInt zzzzz_ = zzzzy_?.FrequencyElement;
                    int? azzzza_ = zzzzz_?.Value;
                    Dosage azzzzc_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)xzzzm_);
                    Timing azzzzd_ = azzzzc_?.Timing;
                    Timing.RepeatComponent azzzze_ = azzzzd_?.Repeat;
                    FhirDecimal azzzzf_ = azzzze_?.PeriodElement;
                    decimal? azzzzg_ = azzzzf_?.Value;
                    Dosage azzzzi_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)xzzzm_);
                    Timing azzzzj_ = azzzzi_?.Timing;
                    Timing.RepeatComponent azzzzk_ = azzzzj_?.Repeat;
                    Code<Timing.UnitsOfTime> azzzzl_ = azzzzk_?.PeriodUnitElement;
                    Timing.UnitsOfTime? azzzzm_ = azzzzl_?.Value;
                    string azzzzn_ = context.Operators.Convert<string>(azzzzm_);
                    CqlQuantity azzzzo_ = this.Quantity(context, azzzzg_, azzzzn_);
                    decimal? azzzzp_ = this.ToDaily(context, zzzzu_ ?? azzzza_, azzzzo_);
                    Dosage azzzzr_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)xzzzm_);
                    Timing azzzzs_ = azzzzr_?.Timing;
                    Timing.RepeatComponent azzzzt_ = azzzzs_?.Repeat;
                    List<Time> azzzzu_ = azzzzt_?.TimeOfDayElement;
                    IEnumerable<CqlTime> azzzzv_ = context.Operators.LateBoundProperty<IEnumerable<CqlTime>>(azzzzu_, "value");
                    int? azzzzw_ = context.Operators.Count<CqlTime>(azzzzv_);
                    decimal? azzzzx_ = context.Operators.ConvertIntegerToDecimal(azzzzw_);
                    decimal? azzzzy_ = context.Operators.Multiply(zzzzo_, (azzzzp_ ?? azzzzx_) ?? 1.0m);
                    decimal? azzzzz_ = context.Operators.Divide(zzzza_, azzzzy_);
                    UnsignedInt bzzzzb_ = xzzzx_?.NumberOfRepeatsAllowedElement;
                    int? bzzzzc_ = bzzzzb_?.Value;
                    int? bzzzzd_ = context.Operators.Add(1, bzzzzc_ ?? 0);
                    decimal? bzzzze_ = context.Operators.ConvertIntegerToDecimal(bzzzzd_);
                    decimal? bzzzzf_ = context.Operators.Multiply(yzzzw_ ?? azzzzz_, bzzzze_);
                    decimal? bzzzzg_ = context.Operators.ConvertIntegerToDecimal(1);
                    decimal? bzzzzh_ = context.Operators.Subtract(bzzzzf_, bzzzzg_);
                    CqlQuantity bzzzzi_ = this.Quantity(context, bzzzzh_, "day");
                    CqlDate bzzzzj_ = context.Operators.Add((yzzzj_ ?? yzzzm_) ?? yzzzr_, bzzzzi_);
                    CqlInterval<CqlDate> bzzzzk_ = context.Operators.Interval((xzzzt_ ?? xzzzw_) ?? yzzzb_, bzzzzj_, true, true);

                    return bzzzzk_;
                }
                else if (tzzze_())
                {
                    List<Dosage> bzzzzl_ = R?.DosageInstruction;
                    Dosage bzzzzm_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)bzzzzl_);
                    Timing bzzzzn_ = bzzzzm_?.Timing;
                    Timing.RepeatComponent bzzzzo_ = bzzzzn_?.Repeat;
                    DataType bzzzzp_ = bzzzzo_?.Bounds;
                    object bzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzp_);
                    CqlDateTime bzzzzr_ = context.Operators.Start(bzzzzq_ as CqlInterval<CqlDateTime>);
                    CqlDate bzzzzs_ = context.Operators.DateFrom(bzzzzr_);
                    FhirDateTime bzzzzt_ = R?.AuthoredOnElement;
                    CqlDateTime bzzzzu_ = context.Operators.Convert<CqlDateTime>(bzzzzt_);
                    CqlDate bzzzzv_ = context.Operators.DateFrom(bzzzzu_);
                    MedicationRequest.DispenseRequestComponent bzzzzw_ = R?.DispenseRequest;
                    Period bzzzzx_ = bzzzzw_?.ValidityPeriod;
                    CqlInterval<CqlDateTime> bzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzx_);
                    CqlDateTime bzzzzz_ = context.Operators.Start(bzzzzy_);
                    CqlDate czzzza_ = context.Operators.DateFrom(bzzzzz_);
                    Dosage czzzzc_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)bzzzzl_);
                    Timing czzzzd_ = czzzzc_?.Timing;
                    Timing.RepeatComponent czzzze_ = czzzzd_?.Repeat;
                    DataType czzzzf_ = czzzze_?.Bounds;
                    object czzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzf_);
                    CqlDateTime czzzzh_ = context.Operators.End(czzzzg_ as CqlInterval<CqlDateTime>);
                    CqlDate czzzzi_ = context.Operators.DateFrom(czzzzh_);
                    CqlInterval<CqlDate> czzzzj_ = context.Operators.Interval((bzzzzs_ ?? bzzzzv_) ?? czzzza_, czzzzi_, true, true);

                    return czzzzj_;
                }
                else
                {
                    return null as CqlInterval<CqlDate>;
                }
            };

            return tzzzc_();
        };
        IEnumerable<CqlInterval<CqlDate>> szzzz_ = context.Operators.Select<MedicationRequest, CqlInterval<CqlDate>>((IEnumerable<MedicationRequest>)szzzx_, szzzy_);
        IEnumerable<CqlInterval<CqlDate>> tzzza_ = context.Operators.Distinct<CqlInterval<CqlDate>>(szzzz_);
        CqlInterval<CqlDate> tzzzb_ = context.Operators.SingletonFrom<CqlInterval<CqlDate>>(tzzza_);

        return tzzzb_;
    }


    [CqlExpressionDefinition("medicationRequestPeriod")]
    public CqlInterval<CqlDate> medicationRequestPeriod(CqlContext context, MedicationRequest Request)
    {
        MedicationRequest[] czzzzk_ = [
            Request,
        ];
        CqlInterval<CqlDate> czzzzl_(MedicationRequest R)
        {
            CqlInterval<CqlDate> czzzzp_()
            {
                bool czzzzq_()
                {
                    List<Dosage> czzzzs_ = R?.DosageInstruction;
                    Dosage czzzzt_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)czzzzs_);
                    Timing czzzzu_ = czzzzt_?.Timing;
                    Timing.RepeatComponent czzzzv_ = czzzzu_?.Repeat;
                    DataType czzzzw_ = czzzzv_?.Bounds;
                    object czzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzw_);
                    CqlDateTime czzzzy_ = context.Operators.Start(czzzzx_ as CqlInterval<CqlDateTime>);
                    CqlDate czzzzz_ = context.Operators.DateFrom(czzzzy_);
                    FhirDateTime dzzzza_ = R?.AuthoredOnElement;
                    CqlDateTime dzzzzb_ = context.Operators.Convert<CqlDateTime>(dzzzza_);
                    CqlDate dzzzzc_ = context.Operators.DateFrom(dzzzzb_);
                    MedicationRequest.DispenseRequestComponent dzzzzd_ = R?.DispenseRequest;
                    Period dzzzze_ = dzzzzd_?.ValidityPeriod;
                    CqlInterval<CqlDateTime> dzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzze_);
                    CqlDateTime dzzzzg_ = context.Operators.Start(dzzzzf_);
                    CqlDate dzzzzh_ = context.Operators.DateFrom(dzzzzg_);
                    bool? dzzzzi_ = context.Operators.Not((bool?)(((czzzzz_ ?? dzzzzc_) ?? dzzzzh_) is null));
                    Duration dzzzzk_ = dzzzzd_?.ExpectedSupplyDuration;
                    CqlQuantity dzzzzl_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, dzzzzk_);
                    CqlQuantity dzzzzm_ = context.Operators.ConvertQuantity(dzzzzl_, "d");
                    decimal? dzzzzn_ = dzzzzm_?.value;
                    Quantity dzzzzp_ = dzzzzd_?.Quantity;
                    CqlQuantity dzzzzq_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, dzzzzp_);
                    decimal? dzzzzr_ = dzzzzq_?.value;
                    Dosage dzzzzt_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)czzzzs_);
                    List<Dosage.DoseAndRateComponent> dzzzzu_ = dzzzzt_?.DoseAndRate;
                    Dosage.DoseAndRateComponent dzzzzv_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)dzzzzu_);
                    DataType dzzzzw_ = dzzzzv_?.Dose;
                    object dzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzw_);
                    CqlQuantity dzzzzy_ = context.Operators.End(dzzzzx_ as CqlInterval<CqlQuantity>);
                    Dosage ezzzza_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)czzzzs_);
                    List<Dosage.DoseAndRateComponent> ezzzzb_ = ezzzza_?.DoseAndRate;
                    Dosage.DoseAndRateComponent ezzzzc_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)ezzzzb_);
                    DataType ezzzzd_ = ezzzzc_?.Dose;
                    object ezzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzd_);
                    decimal? ezzzzf_ = (dzzzzy_ ?? ezzzze_ as CqlQuantity)?.value;
                    Dosage ezzzzh_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)czzzzs_);
                    Timing ezzzzi_ = ezzzzh_?.Timing;
                    Timing.RepeatComponent ezzzzj_ = ezzzzi_?.Repeat;
                    PositiveInt ezzzzk_ = ezzzzj_?.FrequencyMaxElement;
                    int? ezzzzl_ = ezzzzk_?.Value;
                    Dosage ezzzzn_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)czzzzs_);
                    Timing ezzzzo_ = ezzzzn_?.Timing;
                    Timing.RepeatComponent ezzzzp_ = ezzzzo_?.Repeat;
                    PositiveInt ezzzzq_ = ezzzzp_?.FrequencyElement;
                    int? ezzzzr_ = ezzzzq_?.Value;
                    Dosage ezzzzt_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)czzzzs_);
                    Timing ezzzzu_ = ezzzzt_?.Timing;
                    Timing.RepeatComponent ezzzzv_ = ezzzzu_?.Repeat;
                    FhirDecimal ezzzzw_ = ezzzzv_?.PeriodElement;
                    decimal? ezzzzx_ = ezzzzw_?.Value;
                    Dosage ezzzzz_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)czzzzs_);
                    Timing fzzzza_ = ezzzzz_?.Timing;
                    Timing.RepeatComponent fzzzzb_ = fzzzza_?.Repeat;
                    Code<Timing.UnitsOfTime> fzzzzc_ = fzzzzb_?.PeriodUnitElement;
                    Timing.UnitsOfTime? fzzzzd_ = fzzzzc_?.Value;
                    string fzzzze_ = context.Operators.Convert<string>(fzzzzd_);
                    CqlQuantity fzzzzf_ = this.Quantity(context, ezzzzx_, fzzzze_);
                    decimal? fzzzzg_ = this.ToDaily(context, ezzzzl_ ?? ezzzzr_, fzzzzf_);
                    Dosage fzzzzi_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)czzzzs_);
                    Timing fzzzzj_ = fzzzzi_?.Timing;
                    Timing.RepeatComponent fzzzzk_ = fzzzzj_?.Repeat;
                    List<Time> fzzzzl_ = fzzzzk_?.TimeOfDayElement;
                    IEnumerable<CqlTime> fzzzzm_ = context.Operators.LateBoundProperty<IEnumerable<CqlTime>>(fzzzzl_, "value");
                    int? fzzzzn_ = context.Operators.Count<CqlTime>(fzzzzm_);
                    decimal? fzzzzo_ = context.Operators.ConvertIntegerToDecimal(fzzzzn_);
                    decimal? fzzzzp_ = context.Operators.Multiply(ezzzzf_, (fzzzzg_ ?? fzzzzo_) ?? 1.0m);
                    decimal? fzzzzq_ = context.Operators.Divide(dzzzzr_, fzzzzp_);
                    UnsignedInt fzzzzs_ = dzzzzd_?.NumberOfRepeatsAllowedElement;
                    int? fzzzzt_ = fzzzzs_?.Value;
                    int? fzzzzu_ = context.Operators.Add(1, fzzzzt_ ?? 0);
                    decimal? fzzzzv_ = context.Operators.ConvertIntegerToDecimal(fzzzzu_);
                    decimal? fzzzzw_ = context.Operators.Multiply(dzzzzn_ ?? fzzzzq_, fzzzzv_);
                    bool? fzzzzx_ = context.Operators.Not((bool?)(fzzzzw_ is null));
                    bool? fzzzzy_ = context.Operators.And(dzzzzi_, fzzzzx_);

                    return fzzzzy_ ?? false;
                };
                bool czzzzr_()
                {
                    List<Dosage> fzzzzz_ = R?.DosageInstruction;
                    Dosage gzzzza_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)fzzzzz_);
                    Timing gzzzzb_ = gzzzza_?.Timing;
                    Timing.RepeatComponent gzzzzc_ = gzzzzb_?.Repeat;
                    DataType gzzzzd_ = gzzzzc_?.Bounds;
                    object gzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzd_);
                    CqlDateTime gzzzzf_ = context.Operators.Start(gzzzze_ as CqlInterval<CqlDateTime>);
                    CqlDate gzzzzg_ = context.Operators.DateFrom(gzzzzf_);
                    FhirDateTime gzzzzh_ = R?.AuthoredOnElement;
                    CqlDateTime gzzzzi_ = context.Operators.Convert<CqlDateTime>(gzzzzh_);
                    CqlDate gzzzzj_ = context.Operators.DateFrom(gzzzzi_);
                    MedicationRequest.DispenseRequestComponent gzzzzk_ = R?.DispenseRequest;
                    Period gzzzzl_ = gzzzzk_?.ValidityPeriod;
                    CqlInterval<CqlDateTime> gzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzl_);
                    CqlDateTime gzzzzn_ = context.Operators.Start(gzzzzm_);
                    CqlDate gzzzzo_ = context.Operators.DateFrom(gzzzzn_);
                    bool? gzzzzp_ = context.Operators.Not((bool?)(((gzzzzg_ ?? gzzzzj_) ?? gzzzzo_) is null));
                    Dosage gzzzzr_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)fzzzzz_);
                    Timing gzzzzs_ = gzzzzr_?.Timing;
                    Timing.RepeatComponent gzzzzt_ = gzzzzs_?.Repeat;
                    DataType gzzzzu_ = gzzzzt_?.Bounds;
                    object gzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzu_);
                    CqlDateTime gzzzzw_ = (gzzzzv_ as CqlInterval<CqlDateTime>)?.high;
                    bool? gzzzzx_ = context.Operators.Not((bool?)(gzzzzw_ is null));
                    bool? gzzzzy_ = context.Operators.And(gzzzzp_, gzzzzx_);

                    return gzzzzy_ ?? false;
                };
                if (czzzzq_())
                {
                    List<Dosage> gzzzzz_ = R?.DosageInstruction;
                    Dosage hzzzza_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)gzzzzz_);
                    Timing hzzzzb_ = hzzzza_?.Timing;
                    Timing.RepeatComponent hzzzzc_ = hzzzzb_?.Repeat;
                    DataType hzzzzd_ = hzzzzc_?.Bounds;
                    object hzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzd_);
                    CqlDateTime hzzzzf_ = context.Operators.Start(hzzzze_ as CqlInterval<CqlDateTime>);
                    CqlDate hzzzzg_ = context.Operators.DateFrom(hzzzzf_);
                    FhirDateTime hzzzzh_ = R?.AuthoredOnElement;
                    CqlDateTime hzzzzi_ = context.Operators.Convert<CqlDateTime>(hzzzzh_);
                    CqlDate hzzzzj_ = context.Operators.DateFrom(hzzzzi_);
                    MedicationRequest.DispenseRequestComponent hzzzzk_ = R?.DispenseRequest;
                    Period hzzzzl_ = hzzzzk_?.ValidityPeriod;
                    CqlInterval<CqlDateTime> hzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzl_);
                    CqlDateTime hzzzzn_ = context.Operators.Start(hzzzzm_);
                    CqlDate hzzzzo_ = context.Operators.DateFrom(hzzzzn_);
                    Dosage hzzzzq_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)gzzzzz_);
                    Timing hzzzzr_ = hzzzzq_?.Timing;
                    Timing.RepeatComponent hzzzzs_ = hzzzzr_?.Repeat;
                    DataType hzzzzt_ = hzzzzs_?.Bounds;
                    object hzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzt_);
                    CqlDateTime hzzzzv_ = context.Operators.Start(hzzzzu_ as CqlInterval<CqlDateTime>);
                    CqlDate hzzzzw_ = context.Operators.DateFrom(hzzzzv_);
                    CqlDateTime hzzzzy_ = context.Operators.Convert<CqlDateTime>(hzzzzh_);
                    CqlDate hzzzzz_ = context.Operators.DateFrom(hzzzzy_);
                    Period izzzzb_ = hzzzzk_?.ValidityPeriod;
                    CqlInterval<CqlDateTime> izzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzb_);
                    CqlDateTime izzzzd_ = context.Operators.Start(izzzzc_);
                    CqlDate izzzze_ = context.Operators.DateFrom(izzzzd_);
                    Duration izzzzg_ = hzzzzk_?.ExpectedSupplyDuration;
                    CqlQuantity izzzzh_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, izzzzg_);
                    CqlQuantity izzzzi_ = context.Operators.ConvertQuantity(izzzzh_, "d");
                    decimal? izzzzj_ = izzzzi_?.value;
                    Quantity izzzzl_ = hzzzzk_?.Quantity;
                    CqlQuantity izzzzm_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, izzzzl_);
                    decimal? izzzzn_ = izzzzm_?.value;
                    Dosage izzzzp_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)gzzzzz_);
                    List<Dosage.DoseAndRateComponent> izzzzq_ = izzzzp_?.DoseAndRate;
                    Dosage.DoseAndRateComponent izzzzr_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)izzzzq_);
                    DataType izzzzs_ = izzzzr_?.Dose;
                    object izzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzs_);
                    CqlQuantity izzzzu_ = context.Operators.End(izzzzt_ as CqlInterval<CqlQuantity>);
                    Dosage izzzzw_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)gzzzzz_);
                    List<Dosage.DoseAndRateComponent> izzzzx_ = izzzzw_?.DoseAndRate;
                    Dosage.DoseAndRateComponent izzzzy_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)izzzzx_);
                    DataType izzzzz_ = izzzzy_?.Dose;
                    object jzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzz_);
                    decimal? jzzzzb_ = (izzzzu_ ?? jzzzza_ as CqlQuantity)?.value;
                    Dosage jzzzzd_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)gzzzzz_);
                    Timing jzzzze_ = jzzzzd_?.Timing;
                    Timing.RepeatComponent jzzzzf_ = jzzzze_?.Repeat;
                    PositiveInt jzzzzg_ = jzzzzf_?.FrequencyMaxElement;
                    int? jzzzzh_ = jzzzzg_?.Value;
                    Dosage jzzzzj_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)gzzzzz_);
                    Timing jzzzzk_ = jzzzzj_?.Timing;
                    Timing.RepeatComponent jzzzzl_ = jzzzzk_?.Repeat;
                    PositiveInt jzzzzm_ = jzzzzl_?.FrequencyElement;
                    int? jzzzzn_ = jzzzzm_?.Value;
                    Dosage jzzzzp_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)gzzzzz_);
                    Timing jzzzzq_ = jzzzzp_?.Timing;
                    Timing.RepeatComponent jzzzzr_ = jzzzzq_?.Repeat;
                    FhirDecimal jzzzzs_ = jzzzzr_?.PeriodElement;
                    decimal? jzzzzt_ = jzzzzs_?.Value;
                    Dosage jzzzzv_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)gzzzzz_);
                    Timing jzzzzw_ = jzzzzv_?.Timing;
                    Timing.RepeatComponent jzzzzx_ = jzzzzw_?.Repeat;
                    Code<Timing.UnitsOfTime> jzzzzy_ = jzzzzx_?.PeriodUnitElement;
                    Timing.UnitsOfTime? jzzzzz_ = jzzzzy_?.Value;
                    string kzzzza_ = context.Operators.Convert<string>(jzzzzz_);
                    CqlQuantity kzzzzb_ = this.Quantity(context, jzzzzt_, kzzzza_);
                    decimal? kzzzzc_ = this.ToDaily(context, jzzzzh_ ?? jzzzzn_, kzzzzb_);
                    Dosage kzzzze_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)gzzzzz_);
                    Timing kzzzzf_ = kzzzze_?.Timing;
                    Timing.RepeatComponent kzzzzg_ = kzzzzf_?.Repeat;
                    List<Time> kzzzzh_ = kzzzzg_?.TimeOfDayElement;
                    IEnumerable<CqlTime> kzzzzi_ = context.Operators.LateBoundProperty<IEnumerable<CqlTime>>(kzzzzh_, "value");
                    int? kzzzzj_ = context.Operators.Count<CqlTime>(kzzzzi_);
                    decimal? kzzzzk_ = context.Operators.ConvertIntegerToDecimal(kzzzzj_);
                    decimal? kzzzzl_ = context.Operators.Multiply(jzzzzb_, (kzzzzc_ ?? kzzzzk_) ?? 1.0m);
                    decimal? kzzzzm_ = context.Operators.Divide(izzzzn_, kzzzzl_);
                    UnsignedInt kzzzzo_ = hzzzzk_?.NumberOfRepeatsAllowedElement;
                    int? kzzzzp_ = kzzzzo_?.Value;
                    int? kzzzzq_ = context.Operators.Add(1, kzzzzp_ ?? 0);
                    decimal? kzzzzr_ = context.Operators.ConvertIntegerToDecimal(kzzzzq_);
                    decimal? kzzzzs_ = context.Operators.Multiply(izzzzj_ ?? kzzzzm_, kzzzzr_);
                    decimal? kzzzzt_ = context.Operators.ConvertIntegerToDecimal(1);
                    decimal? kzzzzu_ = context.Operators.Subtract(kzzzzs_, kzzzzt_);
                    CqlQuantity kzzzzv_ = this.Quantity(context, kzzzzu_, "day");
                    CqlDate kzzzzw_ = context.Operators.Add((hzzzzw_ ?? hzzzzz_) ?? izzzze_, kzzzzv_);
                    CqlInterval<CqlDate> kzzzzx_ = context.Operators.Interval((hzzzzg_ ?? hzzzzj_) ?? hzzzzo_, kzzzzw_, true, true);

                    return kzzzzx_;
                }
                else if (czzzzr_())
                {
                    List<Dosage> kzzzzy_ = R?.DosageInstruction;
                    Dosage kzzzzz_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)kzzzzy_);
                    Timing lzzzza_ = kzzzzz_?.Timing;
                    Timing.RepeatComponent lzzzzb_ = lzzzza_?.Repeat;
                    DataType lzzzzc_ = lzzzzb_?.Bounds;
                    object lzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzc_);
                    CqlDateTime lzzzze_ = context.Operators.Start(lzzzzd_ as CqlInterval<CqlDateTime>);
                    CqlDate lzzzzf_ = context.Operators.DateFrom(lzzzze_);
                    FhirDateTime lzzzzg_ = R?.AuthoredOnElement;
                    CqlDateTime lzzzzh_ = context.Operators.Convert<CqlDateTime>(lzzzzg_);
                    CqlDate lzzzzi_ = context.Operators.DateFrom(lzzzzh_);
                    MedicationRequest.DispenseRequestComponent lzzzzj_ = R?.DispenseRequest;
                    Period lzzzzk_ = lzzzzj_?.ValidityPeriod;
                    CqlInterval<CqlDateTime> lzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzk_);
                    CqlDateTime lzzzzm_ = context.Operators.Start(lzzzzl_);
                    CqlDate lzzzzn_ = context.Operators.DateFrom(lzzzzm_);
                    Dosage lzzzzp_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)kzzzzy_);
                    Timing lzzzzq_ = lzzzzp_?.Timing;
                    Timing.RepeatComponent lzzzzr_ = lzzzzq_?.Repeat;
                    DataType lzzzzs_ = lzzzzr_?.Bounds;
                    object lzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzs_);
                    CqlDateTime lzzzzu_ = context.Operators.End(lzzzzt_ as CqlInterval<CqlDateTime>);
                    CqlDate lzzzzv_ = context.Operators.DateFrom(lzzzzu_);
                    CqlInterval<CqlDate> lzzzzw_ = context.Operators.Interval((lzzzzf_ ?? lzzzzi_) ?? lzzzzn_, lzzzzv_, true, true);

                    return lzzzzw_;
                }
                else
                {
                    return null as CqlInterval<CqlDate>;
                }
            };

            return czzzzp_();
        };
        IEnumerable<CqlInterval<CqlDate>> czzzzm_ = context.Operators.Select<MedicationRequest, CqlInterval<CqlDate>>((IEnumerable<MedicationRequest>)czzzzk_, czzzzl_);
        IEnumerable<CqlInterval<CqlDate>> czzzzn_ = context.Operators.Distinct<CqlInterval<CqlDate>>(czzzzm_);
        CqlInterval<CqlDate> czzzzo_ = context.Operators.SingletonFrom<CqlInterval<CqlDate>>(czzzzn_);

        return czzzzo_;
    }


    [CqlExpressionDefinition("MedicationDispensePeriod")]
    public CqlInterval<CqlDate> MedicationDispensePeriod(CqlContext context, MedicationDispense Dispense)
    {
        MedicationDispense[] lzzzzx_ = [
            Dispense,
        ];
        CqlInterval<CqlDate> lzzzzy_(MedicationDispense D)
        {
            CqlInterval<CqlDate> mzzzzc_()
            {
                bool mzzzzd_()
                {
                    FhirDateTime mzzzze_ = D?.WhenHandedOverElement;
                    CqlDateTime mzzzzf_ = context.Operators.Convert<CqlDateTime>(mzzzze_);
                    CqlDate mzzzzg_ = context.Operators.DateFrom(mzzzzf_);
                    FhirDateTime mzzzzh_ = D?.WhenPreparedElement;
                    CqlDateTime mzzzzi_ = context.Operators.Convert<CqlDateTime>(mzzzzh_);
                    CqlDate mzzzzj_ = context.Operators.DateFrom(mzzzzi_);
                    bool? mzzzzk_ = context.Operators.Not((bool?)((mzzzzg_ ?? mzzzzj_) is null));
                    Quantity mzzzzl_ = D?.DaysSupply;
                    CqlQuantity mzzzzm_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, mzzzzl_);
                    CqlQuantity mzzzzn_ = context.Operators.ConvertQuantity(mzzzzm_, "d");
                    decimal? mzzzzo_ = mzzzzn_?.value;
                    Quantity mzzzzp_ = D?.Quantity;
                    CqlQuantity mzzzzq_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, mzzzzp_);
                    decimal? mzzzzr_ = mzzzzq_?.value;
                    List<Dosage> mzzzzs_ = D?.DosageInstruction;
                    Dosage mzzzzt_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)mzzzzs_);
                    List<Dosage.DoseAndRateComponent> mzzzzu_ = mzzzzt_?.DoseAndRate;
                    Dosage.DoseAndRateComponent mzzzzv_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)mzzzzu_);
                    DataType mzzzzw_ = mzzzzv_?.Dose;
                    object mzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzw_);
                    CqlQuantity mzzzzy_ = context.Operators.End(mzzzzx_ as CqlInterval<CqlQuantity>);
                    Dosage nzzzza_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)mzzzzs_);
                    List<Dosage.DoseAndRateComponent> nzzzzb_ = nzzzza_?.DoseAndRate;
                    Dosage.DoseAndRateComponent nzzzzc_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)nzzzzb_);
                    DataType nzzzzd_ = nzzzzc_?.Dose;
                    object nzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzd_);
                    decimal? nzzzzf_ = (mzzzzy_ ?? nzzzze_ as CqlQuantity)?.value;
                    Dosage nzzzzh_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)mzzzzs_);
                    Timing nzzzzi_ = nzzzzh_?.Timing;
                    Timing.RepeatComponent nzzzzj_ = nzzzzi_?.Repeat;
                    PositiveInt nzzzzk_ = nzzzzj_?.FrequencyMaxElement;
                    int? nzzzzl_ = nzzzzk_?.Value;
                    Dosage nzzzzn_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)mzzzzs_);
                    Timing nzzzzo_ = nzzzzn_?.Timing;
                    Timing.RepeatComponent nzzzzp_ = nzzzzo_?.Repeat;
                    PositiveInt nzzzzq_ = nzzzzp_?.FrequencyElement;
                    int? nzzzzr_ = nzzzzq_?.Value;
                    Dosage nzzzzt_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)mzzzzs_);
                    Timing nzzzzu_ = nzzzzt_?.Timing;
                    Timing.RepeatComponent nzzzzv_ = nzzzzu_?.Repeat;
                    FhirDecimal nzzzzw_ = nzzzzv_?.PeriodElement;
                    decimal? nzzzzx_ = nzzzzw_?.Value;
                    Dosage nzzzzz_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)mzzzzs_);
                    Timing ozzzza_ = nzzzzz_?.Timing;
                    Timing.RepeatComponent ozzzzb_ = ozzzza_?.Repeat;
                    Code<Timing.UnitsOfTime> ozzzzc_ = ozzzzb_?.PeriodUnitElement;
                    Timing.UnitsOfTime? ozzzzd_ = ozzzzc_?.Value;
                    string ozzzze_ = context.Operators.Convert<string>(ozzzzd_);
                    CqlQuantity ozzzzf_ = this.Quantity(context, nzzzzx_, ozzzze_);
                    decimal? ozzzzg_ = this.ToDaily(context, nzzzzl_ ?? nzzzzr_, ozzzzf_);
                    Dosage ozzzzi_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)mzzzzs_);
                    Timing ozzzzj_ = ozzzzi_?.Timing;
                    Timing.RepeatComponent ozzzzk_ = ozzzzj_?.Repeat;
                    List<Time> ozzzzl_ = ozzzzk_?.TimeOfDayElement;
                    IEnumerable<CqlTime> ozzzzm_ = context.Operators.LateBoundProperty<IEnumerable<CqlTime>>(ozzzzl_, "value");
                    int? ozzzzn_ = context.Operators.Count<CqlTime>(ozzzzm_);
                    decimal? ozzzzo_ = context.Operators.ConvertIntegerToDecimal(ozzzzn_);
                    decimal? ozzzzp_ = context.Operators.Multiply(nzzzzf_, (ozzzzg_ ?? ozzzzo_) ?? 1.0m);
                    decimal? ozzzzq_ = context.Operators.Divide(mzzzzr_, ozzzzp_);
                    bool? ozzzzr_ = context.Operators.Not((bool?)((mzzzzo_ ?? ozzzzq_) is null));
                    bool? ozzzzs_ = context.Operators.And(mzzzzk_, ozzzzr_);

                    return ozzzzs_ ?? false;
                };
                if (mzzzzd_())
                {
                    FhirDateTime ozzzzt_ = D?.WhenHandedOverElement;
                    CqlDateTime ozzzzu_ = context.Operators.Convert<CqlDateTime>(ozzzzt_);
                    CqlDate ozzzzv_ = context.Operators.DateFrom(ozzzzu_);
                    FhirDateTime ozzzzw_ = D?.WhenPreparedElement;
                    CqlDateTime ozzzzx_ = context.Operators.Convert<CqlDateTime>(ozzzzw_);
                    CqlDate ozzzzy_ = context.Operators.DateFrom(ozzzzx_);
                    CqlDateTime pzzzza_ = context.Operators.Convert<CqlDateTime>(ozzzzt_);
                    CqlDate pzzzzb_ = context.Operators.DateFrom(pzzzza_);
                    CqlDateTime pzzzzd_ = context.Operators.Convert<CqlDateTime>(ozzzzw_);
                    CqlDate pzzzze_ = context.Operators.DateFrom(pzzzzd_);
                    Quantity pzzzzf_ = D?.DaysSupply;
                    CqlQuantity pzzzzg_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, pzzzzf_);
                    CqlQuantity pzzzzh_ = context.Operators.ConvertQuantity(pzzzzg_, "d");
                    decimal? pzzzzi_ = pzzzzh_?.value;
                    Quantity pzzzzj_ = D?.Quantity;
                    CqlQuantity pzzzzk_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, pzzzzj_);
                    decimal? pzzzzl_ = pzzzzk_?.value;
                    List<Dosage> pzzzzm_ = D?.DosageInstruction;
                    Dosage pzzzzn_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)pzzzzm_);
                    List<Dosage.DoseAndRateComponent> pzzzzo_ = pzzzzn_?.DoseAndRate;
                    Dosage.DoseAndRateComponent pzzzzp_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)pzzzzo_);
                    DataType pzzzzq_ = pzzzzp_?.Dose;
                    object pzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzq_);
                    CqlQuantity pzzzzs_ = context.Operators.End(pzzzzr_ as CqlInterval<CqlQuantity>);
                    Dosage pzzzzu_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)pzzzzm_);
                    List<Dosage.DoseAndRateComponent> pzzzzv_ = pzzzzu_?.DoseAndRate;
                    Dosage.DoseAndRateComponent pzzzzw_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)pzzzzv_);
                    DataType pzzzzx_ = pzzzzw_?.Dose;
                    object pzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzx_);
                    decimal? pzzzzz_ = (pzzzzs_ ?? pzzzzy_ as CqlQuantity)?.value;
                    Dosage qzzzzb_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)pzzzzm_);
                    Timing qzzzzc_ = qzzzzb_?.Timing;
                    Timing.RepeatComponent qzzzzd_ = qzzzzc_?.Repeat;
                    PositiveInt qzzzze_ = qzzzzd_?.FrequencyMaxElement;
                    int? qzzzzf_ = qzzzze_?.Value;
                    Dosage qzzzzh_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)pzzzzm_);
                    Timing qzzzzi_ = qzzzzh_?.Timing;
                    Timing.RepeatComponent qzzzzj_ = qzzzzi_?.Repeat;
                    PositiveInt qzzzzk_ = qzzzzj_?.FrequencyElement;
                    int? qzzzzl_ = qzzzzk_?.Value;
                    Dosage qzzzzn_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)pzzzzm_);
                    Timing qzzzzo_ = qzzzzn_?.Timing;
                    Timing.RepeatComponent qzzzzp_ = qzzzzo_?.Repeat;
                    FhirDecimal qzzzzq_ = qzzzzp_?.PeriodElement;
                    decimal? qzzzzr_ = qzzzzq_?.Value;
                    Dosage qzzzzt_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)pzzzzm_);
                    Timing qzzzzu_ = qzzzzt_?.Timing;
                    Timing.RepeatComponent qzzzzv_ = qzzzzu_?.Repeat;
                    Code<Timing.UnitsOfTime> qzzzzw_ = qzzzzv_?.PeriodUnitElement;
                    Timing.UnitsOfTime? qzzzzx_ = qzzzzw_?.Value;
                    string qzzzzy_ = context.Operators.Convert<string>(qzzzzx_);
                    CqlQuantity qzzzzz_ = this.Quantity(context, qzzzzr_, qzzzzy_);
                    decimal? rzzzza_ = this.ToDaily(context, qzzzzf_ ?? qzzzzl_, qzzzzz_);
                    Dosage rzzzzc_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)pzzzzm_);
                    Timing rzzzzd_ = rzzzzc_?.Timing;
                    Timing.RepeatComponent rzzzze_ = rzzzzd_?.Repeat;
                    List<Time> rzzzzf_ = rzzzze_?.TimeOfDayElement;
                    IEnumerable<CqlTime> rzzzzg_ = context.Operators.LateBoundProperty<IEnumerable<CqlTime>>(rzzzzf_, "value");
                    int? rzzzzh_ = context.Operators.Count<CqlTime>(rzzzzg_);
                    decimal? rzzzzi_ = context.Operators.ConvertIntegerToDecimal(rzzzzh_);
                    decimal? rzzzzj_ = context.Operators.Multiply(pzzzzz_, (rzzzza_ ?? rzzzzi_) ?? 1.0m);
                    decimal? rzzzzk_ = context.Operators.Divide(pzzzzl_, rzzzzj_);
                    decimal? rzzzzl_ = context.Operators.ConvertIntegerToDecimal(1);
                    decimal? rzzzzm_ = context.Operators.Subtract(pzzzzi_ ?? rzzzzk_, rzzzzl_);
                    CqlQuantity rzzzzn_ = this.Quantity(context, rzzzzm_, "day");
                    CqlDate rzzzzo_ = context.Operators.Add(pzzzzb_ ?? pzzzze_, rzzzzn_);
                    CqlInterval<CqlDate> rzzzzp_ = context.Operators.Interval(ozzzzv_ ?? ozzzzy_, rzzzzo_, true, true);

                    return rzzzzp_;
                }
                else
                {
                    return null as CqlInterval<CqlDate>;
                }
            };

            return mzzzzc_();
        };
        IEnumerable<CqlInterval<CqlDate>> lzzzzz_ = context.Operators.Select<MedicationDispense, CqlInterval<CqlDate>>((IEnumerable<MedicationDispense>)lzzzzx_, lzzzzy_);
        IEnumerable<CqlInterval<CqlDate>> mzzzza_ = context.Operators.Distinct<CqlInterval<CqlDate>>(lzzzzz_);
        CqlInterval<CqlDate> mzzzzb_ = context.Operators.SingletonFrom<CqlInterval<CqlDate>>(mzzzza_);

        return mzzzzb_;
    }


    [CqlExpressionDefinition("medicationDispensePeriod")]
    public CqlInterval<CqlDate> medicationDispensePeriod(CqlContext context, MedicationDispense Dispense)
    {
        MedicationDispense[] rzzzzq_ = [
            Dispense,
        ];
        CqlInterval<CqlDate> rzzzzr_(MedicationDispense D)
        {
            CqlInterval<CqlDate> rzzzzv_()
            {
                bool rzzzzw_()
                {
                    FhirDateTime rzzzzx_ = D?.WhenHandedOverElement;
                    CqlDateTime rzzzzy_ = context.Operators.Convert<CqlDateTime>(rzzzzx_);
                    CqlDate rzzzzz_ = context.Operators.DateFrom(rzzzzy_);
                    FhirDateTime szzzza_ = D?.WhenPreparedElement;
                    CqlDateTime szzzzb_ = context.Operators.Convert<CqlDateTime>(szzzza_);
                    CqlDate szzzzc_ = context.Operators.DateFrom(szzzzb_);
                    bool? szzzzd_ = context.Operators.Not((bool?)((rzzzzz_ ?? szzzzc_) is null));
                    Quantity szzzze_ = D?.DaysSupply;
                    CqlQuantity szzzzf_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, szzzze_);
                    CqlQuantity szzzzg_ = context.Operators.ConvertQuantity(szzzzf_, "d");
                    decimal? szzzzh_ = szzzzg_?.value;
                    Quantity szzzzi_ = D?.Quantity;
                    CqlQuantity szzzzj_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, szzzzi_);
                    decimal? szzzzk_ = szzzzj_?.value;
                    List<Dosage> szzzzl_ = D?.DosageInstruction;
                    Dosage szzzzm_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)szzzzl_);
                    List<Dosage.DoseAndRateComponent> szzzzn_ = szzzzm_?.DoseAndRate;
                    Dosage.DoseAndRateComponent szzzzo_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)szzzzn_);
                    DataType szzzzp_ = szzzzo_?.Dose;
                    object szzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzp_);
                    CqlQuantity szzzzr_ = context.Operators.End(szzzzq_ as CqlInterval<CqlQuantity>);
                    Dosage szzzzt_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)szzzzl_);
                    List<Dosage.DoseAndRateComponent> szzzzu_ = szzzzt_?.DoseAndRate;
                    Dosage.DoseAndRateComponent szzzzv_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)szzzzu_);
                    DataType szzzzw_ = szzzzv_?.Dose;
                    object szzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzw_);
                    decimal? szzzzy_ = (szzzzr_ ?? szzzzx_ as CqlQuantity)?.value;
                    Dosage tzzzza_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)szzzzl_);
                    Timing tzzzzb_ = tzzzza_?.Timing;
                    Timing.RepeatComponent tzzzzc_ = tzzzzb_?.Repeat;
                    PositiveInt tzzzzd_ = tzzzzc_?.FrequencyMaxElement;
                    int? tzzzze_ = tzzzzd_?.Value;
                    Dosage tzzzzg_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)szzzzl_);
                    Timing tzzzzh_ = tzzzzg_?.Timing;
                    Timing.RepeatComponent tzzzzi_ = tzzzzh_?.Repeat;
                    PositiveInt tzzzzj_ = tzzzzi_?.FrequencyElement;
                    int? tzzzzk_ = tzzzzj_?.Value;
                    Dosage tzzzzm_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)szzzzl_);
                    Timing tzzzzn_ = tzzzzm_?.Timing;
                    Timing.RepeatComponent tzzzzo_ = tzzzzn_?.Repeat;
                    FhirDecimal tzzzzp_ = tzzzzo_?.PeriodElement;
                    decimal? tzzzzq_ = tzzzzp_?.Value;
                    Dosage tzzzzs_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)szzzzl_);
                    Timing tzzzzt_ = tzzzzs_?.Timing;
                    Timing.RepeatComponent tzzzzu_ = tzzzzt_?.Repeat;
                    Code<Timing.UnitsOfTime> tzzzzv_ = tzzzzu_?.PeriodUnitElement;
                    Timing.UnitsOfTime? tzzzzw_ = tzzzzv_?.Value;
                    string tzzzzx_ = context.Operators.Convert<string>(tzzzzw_);
                    CqlQuantity tzzzzy_ = this.Quantity(context, tzzzzq_, tzzzzx_);
                    decimal? tzzzzz_ = this.ToDaily(context, tzzzze_ ?? tzzzzk_, tzzzzy_);
                    Dosage uzzzzb_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)szzzzl_);
                    Timing uzzzzc_ = uzzzzb_?.Timing;
                    Timing.RepeatComponent uzzzzd_ = uzzzzc_?.Repeat;
                    List<Time> uzzzze_ = uzzzzd_?.TimeOfDayElement;
                    IEnumerable<CqlTime> uzzzzf_ = context.Operators.LateBoundProperty<IEnumerable<CqlTime>>(uzzzze_, "value");
                    int? uzzzzg_ = context.Operators.Count<CqlTime>(uzzzzf_);
                    decimal? uzzzzh_ = context.Operators.ConvertIntegerToDecimal(uzzzzg_);
                    decimal? uzzzzi_ = context.Operators.Multiply(szzzzy_, (tzzzzz_ ?? uzzzzh_) ?? 1.0m);
                    decimal? uzzzzj_ = context.Operators.Divide(szzzzk_, uzzzzi_);
                    bool? uzzzzk_ = context.Operators.Not((bool?)((szzzzh_ ?? uzzzzj_) is null));
                    bool? uzzzzl_ = context.Operators.And(szzzzd_, uzzzzk_);

                    return uzzzzl_ ?? false;
                };
                if (rzzzzw_())
                {
                    FhirDateTime uzzzzm_ = D?.WhenHandedOverElement;
                    CqlDateTime uzzzzn_ = context.Operators.Convert<CqlDateTime>(uzzzzm_);
                    CqlDate uzzzzo_ = context.Operators.DateFrom(uzzzzn_);
                    FhirDateTime uzzzzp_ = D?.WhenPreparedElement;
                    CqlDateTime uzzzzq_ = context.Operators.Convert<CqlDateTime>(uzzzzp_);
                    CqlDate uzzzzr_ = context.Operators.DateFrom(uzzzzq_);
                    CqlDateTime uzzzzt_ = context.Operators.Convert<CqlDateTime>(uzzzzm_);
                    CqlDate uzzzzu_ = context.Operators.DateFrom(uzzzzt_);
                    CqlDateTime uzzzzw_ = context.Operators.Convert<CqlDateTime>(uzzzzp_);
                    CqlDate uzzzzx_ = context.Operators.DateFrom(uzzzzw_);
                    Quantity uzzzzy_ = D?.DaysSupply;
                    CqlQuantity uzzzzz_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, uzzzzy_);
                    CqlQuantity vzzzza_ = context.Operators.ConvertQuantity(uzzzzz_, "d");
                    decimal? vzzzzb_ = vzzzza_?.value;
                    Quantity vzzzzc_ = D?.Quantity;
                    CqlQuantity vzzzzd_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, vzzzzc_);
                    decimal? vzzzze_ = vzzzzd_?.value;
                    List<Dosage> vzzzzf_ = D?.DosageInstruction;
                    Dosage vzzzzg_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)vzzzzf_);
                    List<Dosage.DoseAndRateComponent> vzzzzh_ = vzzzzg_?.DoseAndRate;
                    Dosage.DoseAndRateComponent vzzzzi_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)vzzzzh_);
                    DataType vzzzzj_ = vzzzzi_?.Dose;
                    object vzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzj_);
                    CqlQuantity vzzzzl_ = context.Operators.End(vzzzzk_ as CqlInterval<CqlQuantity>);
                    Dosage vzzzzn_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)vzzzzf_);
                    List<Dosage.DoseAndRateComponent> vzzzzo_ = vzzzzn_?.DoseAndRate;
                    Dosage.DoseAndRateComponent vzzzzp_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)vzzzzo_);
                    DataType vzzzzq_ = vzzzzp_?.Dose;
                    object vzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzq_);
                    decimal? vzzzzs_ = (vzzzzl_ ?? vzzzzr_ as CqlQuantity)?.value;
                    Dosage vzzzzu_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)vzzzzf_);
                    Timing vzzzzv_ = vzzzzu_?.Timing;
                    Timing.RepeatComponent vzzzzw_ = vzzzzv_?.Repeat;
                    PositiveInt vzzzzx_ = vzzzzw_?.FrequencyMaxElement;
                    int? vzzzzy_ = vzzzzx_?.Value;
                    Dosage wzzzza_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)vzzzzf_);
                    Timing wzzzzb_ = wzzzza_?.Timing;
                    Timing.RepeatComponent wzzzzc_ = wzzzzb_?.Repeat;
                    PositiveInt wzzzzd_ = wzzzzc_?.FrequencyElement;
                    int? wzzzze_ = wzzzzd_?.Value;
                    Dosage wzzzzg_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)vzzzzf_);
                    Timing wzzzzh_ = wzzzzg_?.Timing;
                    Timing.RepeatComponent wzzzzi_ = wzzzzh_?.Repeat;
                    FhirDecimal wzzzzj_ = wzzzzi_?.PeriodElement;
                    decimal? wzzzzk_ = wzzzzj_?.Value;
                    Dosage wzzzzm_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)vzzzzf_);
                    Timing wzzzzn_ = wzzzzm_?.Timing;
                    Timing.RepeatComponent wzzzzo_ = wzzzzn_?.Repeat;
                    Code<Timing.UnitsOfTime> wzzzzp_ = wzzzzo_?.PeriodUnitElement;
                    Timing.UnitsOfTime? wzzzzq_ = wzzzzp_?.Value;
                    string wzzzzr_ = context.Operators.Convert<string>(wzzzzq_);
                    CqlQuantity wzzzzs_ = this.Quantity(context, wzzzzk_, wzzzzr_);
                    decimal? wzzzzt_ = this.ToDaily(context, vzzzzy_ ?? wzzzze_, wzzzzs_);
                    Dosage wzzzzv_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)vzzzzf_);
                    Timing wzzzzw_ = wzzzzv_?.Timing;
                    Timing.RepeatComponent wzzzzx_ = wzzzzw_?.Repeat;
                    List<Time> wzzzzy_ = wzzzzx_?.TimeOfDayElement;
                    IEnumerable<CqlTime> wzzzzz_ = context.Operators.LateBoundProperty<IEnumerable<CqlTime>>(wzzzzy_, "value");
                    int? xzzzza_ = context.Operators.Count<CqlTime>(wzzzzz_);
                    decimal? xzzzzb_ = context.Operators.ConvertIntegerToDecimal(xzzzza_);
                    decimal? xzzzzc_ = context.Operators.Multiply(vzzzzs_, (wzzzzt_ ?? xzzzzb_) ?? 1.0m);
                    decimal? xzzzzd_ = context.Operators.Divide(vzzzze_, xzzzzc_);
                    decimal? xzzzze_ = context.Operators.ConvertIntegerToDecimal(1);
                    decimal? xzzzzf_ = context.Operators.Subtract(vzzzzb_ ?? xzzzzd_, xzzzze_);
                    CqlQuantity xzzzzg_ = this.Quantity(context, xzzzzf_, "day");
                    CqlDate xzzzzh_ = context.Operators.Add(uzzzzu_ ?? uzzzzx_, xzzzzg_);
                    CqlInterval<CqlDate> xzzzzi_ = context.Operators.Interval(uzzzzo_ ?? uzzzzr_, xzzzzh_, true, true);

                    return xzzzzi_;
                }
                else
                {
                    return null as CqlInterval<CqlDate>;
                }
            };

            return rzzzzv_();
        };
        IEnumerable<CqlInterval<CqlDate>> rzzzzs_ = context.Operators.Select<MedicationDispense, CqlInterval<CqlDate>>((IEnumerable<MedicationDispense>)rzzzzq_, rzzzzr_);
        IEnumerable<CqlInterval<CqlDate>> rzzzzt_ = context.Operators.Distinct<CqlInterval<CqlDate>>(rzzzzs_);
        CqlInterval<CqlDate> rzzzzu_ = context.Operators.SingletonFrom<CqlInterval<CqlDate>>(rzzzzt_);

        return rzzzzu_;
    }


    [CqlExpressionDefinition("TherapeuticDuration")]
    public CqlQuantity TherapeuticDuration(CqlContext context, CqlConcept medication)
    {
        CqlQuantity xzzzzj_ = context.Operators.Quantity(14m, "days");

        return xzzzzj_;
    }


    [CqlExpressionDefinition("MedicationAdministrationPeriod")]
    public CqlInterval<CqlDate> MedicationAdministrationPeriod(CqlContext context, MedicationAdministration Administration)
    {
        MedicationAdministration[] xzzzzk_ = [
            Administration,
        ];
        CqlInterval<CqlDate> xzzzzl_(MedicationAdministration M)
        {
            CqlInterval<CqlDate> xzzzzp_()
            {
                bool xzzzzq_()
                {
                    DataType xzzzzr_ = Administration?.Effective;
                    object xzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzr_);
                    CqlDateTime xzzzzt_ = context.Operators.Start(xzzzzs_ as CqlInterval<CqlDateTime>);
                    CqlDate xzzzzu_ = context.Operators.DateFrom(xzzzzt_);
                    bool? xzzzzv_ = context.Operators.Not((bool?)(xzzzzu_ is null));
                    DataType xzzzzw_ = Administration?.Medication;
                    object xzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzw_);
                    CqlQuantity xzzzzy_ = this.TherapeuticDuration(context, xzzzzx_ as CqlConcept);
                    bool? xzzzzz_ = context.Operators.Not((bool?)(xzzzzy_ is null));
                    bool? yzzzza_ = context.Operators.And(xzzzzv_, xzzzzz_);

                    return yzzzza_ ?? false;
                };
                if (xzzzzq_())
                {
                    DataType yzzzzb_ = Administration?.Effective;
                    object yzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzb_);
                    CqlDateTime yzzzzd_ = context.Operators.Start(yzzzzc_ as CqlInterval<CqlDateTime>);
                    CqlDate yzzzze_ = context.Operators.DateFrom(yzzzzd_);
                    object yzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzb_);
                    CqlDateTime yzzzzh_ = context.Operators.Start(yzzzzg_ as CqlInterval<CqlDateTime>);
                    CqlDate yzzzzi_ = context.Operators.DateFrom(yzzzzh_);
                    DataType yzzzzj_ = Administration?.Medication;
                    object yzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzj_);
                    CqlQuantity yzzzzl_ = this.TherapeuticDuration(context, yzzzzk_ as CqlConcept);
                    CqlDate yzzzzm_ = context.Operators.Add(yzzzzi_, yzzzzl_);
                    CqlQuantity yzzzzn_ = context.Operators.ConvertIntegerToQuantity(1);
                    CqlDate yzzzzo_ = context.Operators.Subtract(yzzzzm_, yzzzzn_);
                    CqlInterval<CqlDate> yzzzzp_ = context.Operators.Interval(yzzzze_, yzzzzo_, true, true);

                    return yzzzzp_;
                }
                else
                {
                    return null as CqlInterval<CqlDate>;
                }
            };

            return xzzzzp_();
        };
        IEnumerable<CqlInterval<CqlDate>> xzzzzm_ = context.Operators.Select<MedicationAdministration, CqlInterval<CqlDate>>((IEnumerable<MedicationAdministration>)xzzzzk_, xzzzzl_);
        IEnumerable<CqlInterval<CqlDate>> xzzzzn_ = context.Operators.Distinct<CqlInterval<CqlDate>>(xzzzzm_);
        CqlInterval<CqlDate> xzzzzo_ = context.Operators.SingletonFrom<CqlInterval<CqlDate>>(xzzzzn_);

        return xzzzzo_;
    }


    [CqlExpressionDefinition("medicationAdministrationPeriod")]
    public CqlInterval<CqlDate> medicationAdministrationPeriod(CqlContext context, MedicationAdministration Administration)
    {
        MedicationAdministration[] yzzzzq_ = [
            Administration,
        ];
        CqlInterval<CqlDate> yzzzzr_(MedicationAdministration M)
        {
            CqlInterval<CqlDate> yzzzzv_()
            {
                bool yzzzzw_()
                {
                    DataType yzzzzx_ = Administration?.Effective;
                    object yzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzx_);
                    CqlDateTime yzzzzz_ = context.Operators.Start(yzzzzy_ as CqlInterval<CqlDateTime>);
                    CqlDate zzzzza_ = context.Operators.DateFrom(yzzzzz_);
                    bool? zzzzzb_ = context.Operators.Not((bool?)(zzzzza_ is null));
                    DataType zzzzzc_ = Administration?.Medication;
                    object zzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzc_);
                    CqlQuantity zzzzze_ = this.TherapeuticDuration(context, zzzzzd_ as CqlConcept);
                    bool? zzzzzf_ = context.Operators.Not((bool?)(zzzzze_ is null));
                    bool? zzzzzg_ = context.Operators.And(zzzzzb_, zzzzzf_);

                    return zzzzzg_ ?? false;
                };
                if (yzzzzw_())
                {
                    DataType zzzzzh_ = Administration?.Effective;
                    object zzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzh_);
                    CqlDateTime zzzzzj_ = context.Operators.Start(zzzzzi_ as CqlInterval<CqlDateTime>);
                    CqlDate zzzzzk_ = context.Operators.DateFrom(zzzzzj_);
                    object zzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzh_);
                    CqlDateTime zzzzzn_ = context.Operators.Start(zzzzzm_ as CqlInterval<CqlDateTime>);
                    CqlDate zzzzzo_ = context.Operators.DateFrom(zzzzzn_);
                    DataType zzzzzp_ = Administration?.Medication;
                    object zzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzp_);
                    CqlQuantity zzzzzr_ = this.TherapeuticDuration(context, zzzzzq_ as CqlConcept);
                    CqlDate zzzzzs_ = context.Operators.Add(zzzzzo_, zzzzzr_);
                    CqlQuantity zzzzzt_ = context.Operators.ConvertIntegerToQuantity(1);
                    CqlDate zzzzzu_ = context.Operators.Subtract(zzzzzs_, zzzzzt_);
                    CqlInterval<CqlDate> zzzzzv_ = context.Operators.Interval(zzzzzk_, zzzzzu_, true, true);

                    return zzzzzv_;
                }
                else
                {
                    return null as CqlInterval<CqlDate>;
                }
            };

            return yzzzzv_();
        };
        IEnumerable<CqlInterval<CqlDate>> yzzzzs_ = context.Operators.Select<MedicationAdministration, CqlInterval<CqlDate>>((IEnumerable<MedicationAdministration>)yzzzzq_, yzzzzr_);
        IEnumerable<CqlInterval<CqlDate>> yzzzzt_ = context.Operators.Distinct<CqlInterval<CqlDate>>(yzzzzs_);
        CqlInterval<CqlDate> yzzzzu_ = context.Operators.SingletonFrom<CqlInterval<CqlDate>>(yzzzzt_);

        return yzzzzu_;
    }


    [CqlExpressionDefinition("CumulativeDuration")]
    public int? CumulativeDuration(CqlContext context, IEnumerable<CqlInterval<CqlDate>> Intervals)
    {
        int? zzzzzw_()
        {
            if ((context.Operators.Not((bool?)(Intervals is null))) ?? false)
            {
                IEnumerable<CqlInterval<CqlDate>> zzzzzx_ = context.Operators.Collapse(Intervals, "day");
                int? zzzzzy_(CqlInterval<CqlDate> X)
                {
                    CqlDate azzzzzb_ = context.Operators.Start(X);
                    CqlDate azzzzzc_ = context.Operators.End(X);
                    int? azzzzzd_ = context.Operators.DifferenceBetween(azzzzzb_, azzzzzc_, "day");
                    int? azzzzze_ = context.Operators.Add(azzzzzd_, 1);

                    return azzzzze_;
                };
                IEnumerable<int?> zzzzzz_ = context.Operators.Select<CqlInterval<CqlDate>, int?>(zzzzzx_, zzzzzy_);
                int? azzzzza_ = context.Operators.Sum(zzzzzz_);

                return azzzzza_;
            }
            else
            {
                return default;
            }
        };

        return zzzzzw_();
    }


    [CqlExpressionDefinition("cumulativeDuration")]
    public int? cumulativeDuration(CqlContext context, IEnumerable<CqlInterval<CqlDate>> Intervals)
    {
        int? azzzzzf_()
        {
            if ((context.Operators.Not((bool?)(Intervals is null))) ?? false)
            {
                IEnumerable<CqlInterval<CqlDate>> azzzzzg_ = context.Operators.Collapse(Intervals, "day");
                int? azzzzzh_(CqlInterval<CqlDate> X)
                {
                    CqlDate azzzzzk_ = context.Operators.Start(X);
                    CqlDate azzzzzl_ = context.Operators.End(X);
                    int? azzzzzm_ = context.Operators.DifferenceBetween(azzzzzk_, azzzzzl_, "day");
                    int? azzzzzn_ = context.Operators.Add(azzzzzm_, 1);

                    return azzzzzn_;
                };
                IEnumerable<int?> azzzzzi_ = context.Operators.Select<CqlInterval<CqlDate>, int?>(azzzzzg_, azzzzzh_);
                int? azzzzzj_ = context.Operators.Sum(azzzzzi_);

                return azzzzzj_;
            }
            else
            {
                return default;
            }
        };

        return azzzzzf_();
    }


    [CqlExpressionDefinition("RolloutIntervals")]
    public IEnumerable<CqlInterval<CqlDate>> RolloutIntervals(CqlContext context, IEnumerable<CqlInterval<CqlDate>> intervals)
    {
        IEnumerable<CqlInterval<CqlDate>> azzzzzo_(IEnumerable<CqlInterval<CqlDate>> R, CqlInterval<CqlDate> I)
        {
            CqlInterval<CqlDate>[] azzzzzq_ = [
                I,
            ];
            CqlInterval<CqlDate> azzzzzr_(CqlInterval<CqlDate> X)
            {
                CqlInterval<CqlDate> azzzzzx_ = context.Operators.Last<CqlInterval<CqlDate>>(R);
                CqlDate azzzzzy_ = context.Operators.End(azzzzzx_);
                CqlQuantity azzzzzz_ = context.Operators.Quantity(1m, "day");
                CqlDate bzzzzza_ = context.Operators.Add(azzzzzy_, azzzzzz_);
                CqlDate bzzzzzb_ = context.Operators.Start(X);
                CqlDate[] bzzzzzc_ = [
                    bzzzzza_,
                    bzzzzzb_,
                ];
                CqlDate bzzzzzd_ = context.Operators.Max<CqlDate>(bzzzzzc_ as IEnumerable<CqlDate>);
                CqlDate bzzzzzf_ = context.Operators.End(azzzzzx_);
                CqlDate bzzzzzh_ = context.Operators.Add(bzzzzzf_, azzzzzz_);
                CqlDate[] bzzzzzj_ = [
                    bzzzzzh_,
                    bzzzzzb_,
                ];
                CqlDate bzzzzzk_ = context.Operators.Max<CqlDate>(bzzzzzj_ as IEnumerable<CqlDate>);
                CqlDate bzzzzzm_ = context.Operators.End(X);
                int? bzzzzzn_ = context.Operators.DurationBetween(bzzzzzb_, bzzzzzm_, "day");
                decimal? bzzzzzo_ = context.Operators.ConvertIntegerToDecimal(bzzzzzn_ ?? 0);
                CqlQuantity bzzzzzp_ = this.Quantity(context, bzzzzzo_, "day");
                CqlDate bzzzzzq_ = context.Operators.Add(bzzzzzk_, bzzzzzp_);
                CqlInterval<CqlDate> bzzzzzr_ = context.Operators.Interval(bzzzzzd_, bzzzzzq_, true, true);

                return bzzzzzr_;
            };
            IEnumerable<CqlInterval<CqlDate>> azzzzzs_ = context.Operators.Select<CqlInterval<CqlDate>, CqlInterval<CqlDate>>((IEnumerable<CqlInterval<CqlDate>>)azzzzzq_, azzzzzr_);
            IEnumerable<CqlInterval<CqlDate>> azzzzzt_ = context.Operators.Distinct<CqlInterval<CqlDate>>(azzzzzs_);
            CqlInterval<CqlDate> azzzzzu_ = context.Operators.SingletonFrom<CqlInterval<CqlDate>>(azzzzzt_);
            CqlInterval<CqlDate>[] azzzzzv_ = [
                azzzzzu_,
            ];
            IEnumerable<CqlInterval<CqlDate>> azzzzzw_ = context.Operators.Union<CqlInterval<CqlDate>>(R, azzzzzv_ as IEnumerable<CqlInterval<CqlDate>>);

            return azzzzzw_;
        };
        IEnumerable<CqlInterval<CqlDate>> azzzzzp_ = context.Operators.Aggregate<CqlInterval<CqlDate>, IEnumerable<CqlInterval<CqlDate>>>(intervals, azzzzzo_, null as IEnumerable<CqlInterval<CqlDate>>);

        return azzzzzp_;
    }


    [CqlExpressionDefinition("rolloutIntervals")]
    public IEnumerable<CqlInterval<CqlDate>> rolloutIntervals(CqlContext context, IEnumerable<CqlInterval<CqlDate>> intervals)
    {
        IEnumerable<CqlInterval<CqlDate>> bzzzzzs_(IEnumerable<CqlInterval<CqlDate>> R, CqlInterval<CqlDate> I)
        {
            CqlInterval<CqlDate>[] bzzzzzu_ = [
                I,
            ];
            CqlInterval<CqlDate> bzzzzzv_(CqlInterval<CqlDate> X)
            {
                CqlInterval<CqlDate> czzzzzb_ = context.Operators.Last<CqlInterval<CqlDate>>(R);
                CqlDate czzzzzc_ = context.Operators.End(czzzzzb_);
                CqlQuantity czzzzzd_ = context.Operators.Quantity(1m, "day");
                CqlDate czzzzze_ = context.Operators.Add(czzzzzc_, czzzzzd_);
                CqlDate czzzzzf_ = context.Operators.Start(X);
                CqlDate[] czzzzzg_ = [
                    czzzzze_,
                    czzzzzf_,
                ];
                CqlDate czzzzzh_ = context.Operators.Max<CqlDate>(czzzzzg_ as IEnumerable<CqlDate>);
                CqlDate czzzzzj_ = context.Operators.End(czzzzzb_);
                CqlDate czzzzzl_ = context.Operators.Add(czzzzzj_, czzzzzd_);
                CqlDate[] czzzzzn_ = [
                    czzzzzl_,
                    czzzzzf_,
                ];
                CqlDate czzzzzo_ = context.Operators.Max<CqlDate>(czzzzzn_ as IEnumerable<CqlDate>);
                CqlDate czzzzzq_ = context.Operators.End(X);
                int? czzzzzr_ = context.Operators.DurationBetween(czzzzzf_, czzzzzq_, "day");
                decimal? czzzzzs_ = context.Operators.ConvertIntegerToDecimal(czzzzzr_ ?? 0);
                CqlQuantity czzzzzt_ = this.Quantity(context, czzzzzs_, "day");
                CqlDate czzzzzu_ = context.Operators.Add(czzzzzo_, czzzzzt_);
                CqlInterval<CqlDate> czzzzzv_ = context.Operators.Interval(czzzzzh_, czzzzzu_, true, true);

                return czzzzzv_;
            };
            IEnumerable<CqlInterval<CqlDate>> bzzzzzw_ = context.Operators.Select<CqlInterval<CqlDate>, CqlInterval<CqlDate>>((IEnumerable<CqlInterval<CqlDate>>)bzzzzzu_, bzzzzzv_);
            IEnumerable<CqlInterval<CqlDate>> bzzzzzx_ = context.Operators.Distinct<CqlInterval<CqlDate>>(bzzzzzw_);
            CqlInterval<CqlDate> bzzzzzy_ = context.Operators.SingletonFrom<CqlInterval<CqlDate>>(bzzzzzx_);
            CqlInterval<CqlDate>[] bzzzzzz_ = [
                bzzzzzy_,
            ];
            IEnumerable<CqlInterval<CqlDate>> czzzzza_ = context.Operators.Union<CqlInterval<CqlDate>>(R, bzzzzzz_ as IEnumerable<CqlInterval<CqlDate>>);

            return czzzzza_;
        };
        IEnumerable<CqlInterval<CqlDate>> bzzzzzt_ = context.Operators.Aggregate<CqlInterval<CqlDate>, IEnumerable<CqlInterval<CqlDate>>>(intervals, bzzzzzs_, null as IEnumerable<CqlInterval<CqlDate>>);

        return bzzzzzt_;
    }


    [CqlExpressionDefinition("MedicationPeriod")]
    public CqlInterval<CqlDate> MedicationPeriod(CqlContext context, object medication)
    {
        CqlInterval<CqlDate> czzzzzw_()
        {
            if (medication is MedicationRequest)
            {
                CqlInterval<CqlDate> czzzzzx_ = this.MedicationRequestPeriod(context, medication as MedicationRequest);

                return czzzzzx_;
            }
            else if (medication is MedicationDispense)
            {
                CqlInterval<CqlDate> czzzzzy_ = this.MedicationDispensePeriod(context, medication as MedicationDispense);

                return czzzzzy_;
            }
            else
            {
                return null as CqlInterval<CqlDate>;
            }
        };

        return czzzzzw_();
    }


    [CqlExpressionDefinition("medicationPeriod")]
    public CqlInterval<CqlDate> medicationPeriod(CqlContext context, object medication)
    {
        CqlInterval<CqlDate> czzzzzz_()
        {
            if (medication is MedicationRequest)
            {
                CqlInterval<CqlDate> dzzzzza_ = this.medicationRequestPeriod(context, medication as MedicationRequest);

                return dzzzzza_;
            }
            else if (medication is MedicationDispense)
            {
                CqlInterval<CqlDate> dzzzzzb_ = this.medicationDispensePeriod(context, medication as MedicationDispense);

                return dzzzzzb_;
            }
            else
            {
                return null as CqlInterval<CqlDate>;
            }
        };

        return czzzzzz_();
    }


    [CqlExpressionDefinition("CumulativeMedicationDuration")]
    public int? CumulativeMedicationDuration(CqlContext context, IEnumerable<object> Medications)
    {
        bool? dzzzzzc_(object M)
        {
            bool dzzzzzp_ = M is MedicationRequest;

            return dzzzzzp_ as bool?;
        };
        IEnumerable<object> dzzzzzd_ = context.Operators.Where<object>(Medications, dzzzzzc_);
        CqlInterval<CqlDate> dzzzzze_(object M)
        {
            CqlInterval<CqlDate> dzzzzzq_ = this.MedicationRequestPeriod(context, M as MedicationRequest);

            return dzzzzzq_;
        };
        IEnumerable<CqlInterval<CqlDate>> dzzzzzf_ = context.Operators.Select<object, CqlInterval<CqlDate>>(dzzzzzd_, dzzzzze_);
        IEnumerable<CqlInterval<CqlDate>> dzzzzzg_ = context.Operators.Distinct<CqlInterval<CqlDate>>(dzzzzzf_);
        bool? dzzzzzh_(object M)
        {
            bool dzzzzzr_ = M is MedicationDispense;

            return dzzzzzr_ as bool?;
        };
        IEnumerable<object> dzzzzzi_ = context.Operators.Where<object>(Medications, dzzzzzh_);
        CqlInterval<CqlDate> dzzzzzj_(object M)
        {
            CqlInterval<CqlDate> dzzzzzs_ = this.MedicationDispensePeriod(context, M as MedicationDispense);

            return dzzzzzs_;
        };
        IEnumerable<CqlInterval<CqlDate>> dzzzzzk_ = context.Operators.Select<object, CqlInterval<CqlDate>>(dzzzzzi_, dzzzzzj_);
        IEnumerable<CqlInterval<CqlDate>> dzzzzzl_ = context.Operators.Distinct<CqlInterval<CqlDate>>(dzzzzzk_);
        IEnumerable<CqlInterval<CqlDate>> dzzzzzm_ = this.RolloutIntervals(context, dzzzzzl_);
        IEnumerable<CqlInterval<CqlDate>> dzzzzzn_ = context.Operators.Union<CqlInterval<CqlDate>>(dzzzzzg_, dzzzzzm_);
        int? dzzzzzo_ = this.CumulativeDuration(context, dzzzzzn_);

        return dzzzzzo_;
    }


    [CqlExpressionDefinition("cumulativeMedicationDuration")]
    public int? cumulativeMedicationDuration(CqlContext context, IEnumerable<object> Medications)
    {
        bool? dzzzzzt_(object M)
        {
            bool ezzzzzg_ = M is MedicationRequest;

            return ezzzzzg_ as bool?;
        };
        IEnumerable<object> dzzzzzu_ = context.Operators.Where<object>(Medications, dzzzzzt_);
        CqlInterval<CqlDate> dzzzzzv_(object M)
        {
            CqlInterval<CqlDate> ezzzzzh_ = this.medicationRequestPeriod(context, M as MedicationRequest);

            return ezzzzzh_;
        };
        IEnumerable<CqlInterval<CqlDate>> dzzzzzw_ = context.Operators.Select<object, CqlInterval<CqlDate>>(dzzzzzu_, dzzzzzv_);
        IEnumerable<CqlInterval<CqlDate>> dzzzzzx_ = context.Operators.Distinct<CqlInterval<CqlDate>>(dzzzzzw_);
        bool? dzzzzzy_(object M)
        {
            bool ezzzzzi_ = M is MedicationDispense;

            return ezzzzzi_ as bool?;
        };
        IEnumerable<object> dzzzzzz_ = context.Operators.Where<object>(Medications, dzzzzzy_);
        CqlInterval<CqlDate> ezzzzza_(object M)
        {
            CqlInterval<CqlDate> ezzzzzj_ = this.medicationDispensePeriod(context, M as MedicationDispense);

            return ezzzzzj_;
        };
        IEnumerable<CqlInterval<CqlDate>> ezzzzzb_ = context.Operators.Select<object, CqlInterval<CqlDate>>(dzzzzzz_, ezzzzza_);
        IEnumerable<CqlInterval<CqlDate>> ezzzzzc_ = context.Operators.Distinct<CqlInterval<CqlDate>>(ezzzzzb_);
        IEnumerable<CqlInterval<CqlDate>> ezzzzzd_ = this.rolloutIntervals(context, ezzzzzc_);
        IEnumerable<CqlInterval<CqlDate>> ezzzzze_ = context.Operators.Union<CqlInterval<CqlDate>>(dzzzzzx_, ezzzzzd_);
        int? ezzzzzf_ = this.cumulativeDuration(context, ezzzzze_);

        return ezzzzzf_;
    }


    #endregion Expressions

}
