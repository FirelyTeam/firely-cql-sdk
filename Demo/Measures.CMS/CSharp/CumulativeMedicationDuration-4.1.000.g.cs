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
        object czzzn_ = context.ResolveParameter("CumulativeMedicationDuration-4.1.000", "ErrorLevel", "Warning");

        return (string)czzzn_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> czzzo_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient czzzp_ = context.Operators.SingletonFrom<Patient>(czzzo_);

        return czzzp_;
    }


    [CqlExpressionDefinition("ToDaily")]
    public decimal? ToDaily(CqlContext context, int? frequency, CqlQuantity period)
    {
        decimal? czzzq_()
        {
            bool czzzr_()
            {
                string dzzzm_ = period?.unit;
                bool? dzzzn_ = context.Operators.Equal(dzzzm_, "h");

                return dzzzn_ ?? false;
            };
            bool czzzs_()
            {
                string dzzzo_ = period?.unit;
                bool? dzzzp_ = context.Operators.Equal(dzzzo_, "min");

                return dzzzp_ ?? false;
            };
            bool czzzt_()
            {
                string dzzzq_ = period?.unit;
                bool? dzzzr_ = context.Operators.Equal(dzzzq_, "s");

                return dzzzr_ ?? false;
            };
            bool czzzu_()
            {
                string dzzzs_ = period?.unit;
                bool? dzzzt_ = context.Operators.Equal(dzzzs_, "d");

                return dzzzt_ ?? false;
            };
            bool czzzv_()
            {
                string dzzzu_ = period?.unit;
                bool? dzzzv_ = context.Operators.Equal(dzzzu_, "wk");

                return dzzzv_ ?? false;
            };
            bool czzzw_()
            {
                string dzzzw_ = period?.unit;
                bool? dzzzx_ = context.Operators.Equal(dzzzw_, "mo");

                return dzzzx_ ?? false;
            };
            bool czzzx_()
            {
                string dzzzy_ = period?.unit;
                bool? dzzzz_ = context.Operators.Equal(dzzzy_, "a");

                return dzzzz_ ?? false;
            };
            bool czzzy_()
            {
                string ezzza_ = period?.unit;
                bool? ezzzb_ = context.Operators.Equal(ezzza_, "hour");

                return ezzzb_ ?? false;
            };
            bool czzzz_()
            {
                string ezzzc_ = period?.unit;
                bool? ezzzd_ = context.Operators.Equal(ezzzc_, "minute");

                return ezzzd_ ?? false;
            };
            bool dzzza_()
            {
                string ezzze_ = period?.unit;
                bool? ezzzf_ = context.Operators.Equal(ezzze_, "second");

                return ezzzf_ ?? false;
            };
            bool dzzzb_()
            {
                string ezzzg_ = period?.unit;
                bool? ezzzh_ = context.Operators.Equal(ezzzg_, "day");

                return ezzzh_ ?? false;
            };
            bool dzzzc_()
            {
                string ezzzi_ = period?.unit;
                bool? ezzzj_ = context.Operators.Equal(ezzzi_, "week");

                return ezzzj_ ?? false;
            };
            bool dzzzd_()
            {
                string ezzzk_ = period?.unit;
                bool? ezzzl_ = context.Operators.Equal(ezzzk_, "month");

                return ezzzl_ ?? false;
            };
            bool dzzze_()
            {
                string ezzzm_ = period?.unit;
                bool? ezzzn_ = context.Operators.Equal(ezzzm_, "year");

                return ezzzn_ ?? false;
            };
            bool dzzzf_()
            {
                string ezzzo_ = period?.unit;
                bool? ezzzp_ = context.Operators.Equal(ezzzo_, "hours");

                return ezzzp_ ?? false;
            };
            bool dzzzg_()
            {
                string ezzzq_ = period?.unit;
                bool? ezzzr_ = context.Operators.Equal(ezzzq_, "minutes");

                return ezzzr_ ?? false;
            };
            bool dzzzh_()
            {
                string ezzzs_ = period?.unit;
                bool? ezzzt_ = context.Operators.Equal(ezzzs_, "seconds");

                return ezzzt_ ?? false;
            };
            bool dzzzi_()
            {
                string ezzzu_ = period?.unit;
                bool? ezzzv_ = context.Operators.Equal(ezzzu_, "days");

                return ezzzv_ ?? false;
            };
            bool dzzzj_()
            {
                string ezzzw_ = period?.unit;
                bool? ezzzx_ = context.Operators.Equal(ezzzw_, "weeks");

                return ezzzx_ ?? false;
            };
            bool dzzzk_()
            {
                string ezzzy_ = period?.unit;
                bool? ezzzz_ = context.Operators.Equal(ezzzy_, "months");

                return ezzzz_ ?? false;
            };
            bool dzzzl_()
            {
                string fzzza_ = period?.unit;
                bool? fzzzb_ = context.Operators.Equal(fzzza_, "years");

                return fzzzb_ ?? false;
            };
            if (czzzr_())
            {
                decimal? fzzzc_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? fzzzd_ = period?.value;
                decimal? fzzze_ = context.Operators.Divide(24.0m, fzzzd_);
                decimal? fzzzf_ = context.Operators.Multiply(fzzzc_, fzzze_);

                return fzzzf_;
            }
            else if (czzzs_())
            {
                decimal? fzzzg_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? fzzzh_ = period?.value;
                decimal? fzzzi_ = context.Operators.Divide(24.0m, fzzzh_);
                decimal? fzzzj_ = context.Operators.Multiply(fzzzg_, fzzzi_);
                decimal? fzzzk_ = context.Operators.ConvertIntegerToDecimal(60);
                decimal? fzzzl_ = context.Operators.Multiply(fzzzj_, fzzzk_);

                return fzzzl_;
            }
            else if (czzzt_())
            {
                decimal? fzzzm_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? fzzzn_ = period?.value;
                decimal? fzzzo_ = context.Operators.Divide(24.0m, fzzzn_);
                decimal? fzzzp_ = context.Operators.Multiply(fzzzm_, fzzzo_);
                decimal? fzzzq_ = context.Operators.ConvertIntegerToDecimal(60);
                decimal? fzzzr_ = context.Operators.Multiply(fzzzp_, fzzzq_);
                decimal? fzzzt_ = context.Operators.Multiply(fzzzr_, fzzzq_);

                return fzzzt_;
            }
            else if (czzzu_())
            {
                decimal? fzzzu_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? fzzzv_ = period?.value;
                decimal? fzzzw_ = context.Operators.Divide(24.0m, fzzzv_);
                decimal? fzzzx_ = context.Operators.Multiply(fzzzu_, fzzzw_);
                decimal? fzzzy_ = context.Operators.ConvertIntegerToDecimal(24);
                decimal? fzzzz_ = context.Operators.Divide(fzzzx_, fzzzy_);

                return fzzzz_;
            }
            else if (czzzv_())
            {
                decimal? gzzza_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? gzzzb_ = period?.value;
                decimal? gzzzc_ = context.Operators.Divide(24.0m, gzzzb_);
                decimal? gzzzd_ = context.Operators.Multiply(gzzza_, gzzzc_);
                int? gzzze_ = context.Operators.Multiply(24, 7);
                decimal? gzzzf_ = context.Operators.ConvertIntegerToDecimal(gzzze_);
                decimal? gzzzg_ = context.Operators.Divide(gzzzd_, gzzzf_);

                return gzzzg_;
            }
            else if (czzzw_())
            {
                decimal? gzzzh_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? gzzzi_ = period?.value;
                decimal? gzzzj_ = context.Operators.Divide(24.0m, gzzzi_);
                decimal? gzzzk_ = context.Operators.Multiply(gzzzh_, gzzzj_);
                int? gzzzl_ = context.Operators.Multiply(24, 30);
                decimal? gzzzm_ = context.Operators.ConvertIntegerToDecimal(gzzzl_);
                decimal? gzzzn_ = context.Operators.Divide(gzzzk_, gzzzm_);

                return gzzzn_;
            }
            else if (czzzx_())
            {
                decimal? gzzzo_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? gzzzp_ = period?.value;
                decimal? gzzzq_ = context.Operators.Divide(24.0m, gzzzp_);
                decimal? gzzzr_ = context.Operators.Multiply(gzzzo_, gzzzq_);
                int? gzzzs_ = context.Operators.Multiply(24, 365);
                decimal? gzzzt_ = context.Operators.ConvertIntegerToDecimal(gzzzs_);
                decimal? gzzzu_ = context.Operators.Divide(gzzzr_, gzzzt_);

                return gzzzu_;
            }
            else if (czzzy_())
            {
                decimal? gzzzv_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? gzzzw_ = period?.value;
                decimal? gzzzx_ = context.Operators.Divide(24.0m, gzzzw_);
                decimal? gzzzy_ = context.Operators.Multiply(gzzzv_, gzzzx_);

                return gzzzy_;
            }
            else if (czzzz_())
            {
                decimal? gzzzz_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? hzzza_ = period?.value;
                decimal? hzzzb_ = context.Operators.Divide(24.0m, hzzza_);
                decimal? hzzzc_ = context.Operators.Multiply(gzzzz_, hzzzb_);
                decimal? hzzzd_ = context.Operators.ConvertIntegerToDecimal(60);
                decimal? hzzze_ = context.Operators.Multiply(hzzzc_, hzzzd_);

                return hzzze_;
            }
            else if (dzzza_())
            {
                decimal? hzzzf_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? hzzzg_ = period?.value;
                decimal? hzzzh_ = context.Operators.Divide(24.0m, hzzzg_);
                decimal? hzzzi_ = context.Operators.Multiply(hzzzf_, hzzzh_);
                decimal? hzzzj_ = context.Operators.ConvertIntegerToDecimal(60);
                decimal? hzzzk_ = context.Operators.Multiply(hzzzi_, hzzzj_);
                decimal? hzzzm_ = context.Operators.Multiply(hzzzk_, hzzzj_);

                return hzzzm_;
            }
            else if (dzzzb_())
            {
                decimal? hzzzn_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? hzzzo_ = period?.value;
                decimal? hzzzp_ = context.Operators.Divide(24.0m, hzzzo_);
                decimal? hzzzq_ = context.Operators.Multiply(hzzzn_, hzzzp_);
                decimal? hzzzr_ = context.Operators.ConvertIntegerToDecimal(24);
                decimal? hzzzs_ = context.Operators.Divide(hzzzq_, hzzzr_);

                return hzzzs_;
            }
            else if (dzzzc_())
            {
                decimal? hzzzt_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? hzzzu_ = period?.value;
                decimal? hzzzv_ = context.Operators.Divide(24.0m, hzzzu_);
                decimal? hzzzw_ = context.Operators.Multiply(hzzzt_, hzzzv_);
                int? hzzzx_ = context.Operators.Multiply(24, 7);
                decimal? hzzzy_ = context.Operators.ConvertIntegerToDecimal(hzzzx_);
                decimal? hzzzz_ = context.Operators.Divide(hzzzw_, hzzzy_);

                return hzzzz_;
            }
            else if (dzzzd_())
            {
                decimal? izzza_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? izzzb_ = period?.value;
                decimal? izzzc_ = context.Operators.Divide(24.0m, izzzb_);
                decimal? izzzd_ = context.Operators.Multiply(izzza_, izzzc_);
                int? izzze_ = context.Operators.Multiply(24, 30);
                decimal? izzzf_ = context.Operators.ConvertIntegerToDecimal(izzze_);
                decimal? izzzg_ = context.Operators.Divide(izzzd_, izzzf_);

                return izzzg_;
            }
            else if (dzzze_())
            {
                decimal? izzzh_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? izzzi_ = period?.value;
                decimal? izzzj_ = context.Operators.Divide(24.0m, izzzi_);
                decimal? izzzk_ = context.Operators.Multiply(izzzh_, izzzj_);
                int? izzzl_ = context.Operators.Multiply(24, 365);
                decimal? izzzm_ = context.Operators.ConvertIntegerToDecimal(izzzl_);
                decimal? izzzn_ = context.Operators.Divide(izzzk_, izzzm_);

                return izzzn_;
            }
            else if (dzzzf_())
            {
                decimal? izzzo_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? izzzp_ = period?.value;
                decimal? izzzq_ = context.Operators.Divide(24.0m, izzzp_);
                decimal? izzzr_ = context.Operators.Multiply(izzzo_, izzzq_);

                return izzzr_;
            }
            else if (dzzzg_())
            {
                decimal? izzzs_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? izzzt_ = period?.value;
                decimal? izzzu_ = context.Operators.Divide(24.0m, izzzt_);
                decimal? izzzv_ = context.Operators.Multiply(izzzs_, izzzu_);
                decimal? izzzw_ = context.Operators.ConvertIntegerToDecimal(60);
                decimal? izzzx_ = context.Operators.Multiply(izzzv_, izzzw_);

                return izzzx_;
            }
            else if (dzzzh_())
            {
                decimal? izzzy_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? izzzz_ = period?.value;
                decimal? jzzza_ = context.Operators.Divide(24.0m, izzzz_);
                decimal? jzzzb_ = context.Operators.Multiply(izzzy_, jzzza_);
                decimal? jzzzc_ = context.Operators.ConvertIntegerToDecimal(60);
                decimal? jzzzd_ = context.Operators.Multiply(jzzzb_, jzzzc_);
                decimal? jzzzf_ = context.Operators.Multiply(jzzzd_, jzzzc_);

                return jzzzf_;
            }
            else if (dzzzi_())
            {
                decimal? jzzzg_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? jzzzh_ = period?.value;
                decimal? jzzzi_ = context.Operators.Divide(24.0m, jzzzh_);
                decimal? jzzzj_ = context.Operators.Multiply(jzzzg_, jzzzi_);
                decimal? jzzzk_ = context.Operators.ConvertIntegerToDecimal(24);
                decimal? jzzzl_ = context.Operators.Divide(jzzzj_, jzzzk_);

                return jzzzl_;
            }
            else if (dzzzj_())
            {
                decimal? jzzzm_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? jzzzn_ = period?.value;
                decimal? jzzzo_ = context.Operators.Divide(24.0m, jzzzn_);
                decimal? jzzzp_ = context.Operators.Multiply(jzzzm_, jzzzo_);
                int? jzzzq_ = context.Operators.Multiply(24, 7);
                decimal? jzzzr_ = context.Operators.ConvertIntegerToDecimal(jzzzq_);
                decimal? jzzzs_ = context.Operators.Divide(jzzzp_, jzzzr_);

                return jzzzs_;
            }
            else if (dzzzk_())
            {
                decimal? jzzzt_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? jzzzu_ = period?.value;
                decimal? jzzzv_ = context.Operators.Divide(24.0m, jzzzu_);
                decimal? jzzzw_ = context.Operators.Multiply(jzzzt_, jzzzv_);
                int? jzzzx_ = context.Operators.Multiply(24, 30);
                decimal? jzzzy_ = context.Operators.ConvertIntegerToDecimal(jzzzx_);
                decimal? jzzzz_ = context.Operators.Divide(jzzzw_, jzzzy_);

                return jzzzz_;
            }
            else if (dzzzl_())
            {
                decimal? kzzza_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? kzzzb_ = period?.value;
                decimal? kzzzc_ = context.Operators.Divide(24.0m, kzzzb_);
                decimal? kzzzd_ = context.Operators.Multiply(kzzza_, kzzzc_);
                int? kzzze_ = context.Operators.Multiply(24, 365);
                decimal? kzzzf_ = context.Operators.ConvertIntegerToDecimal(kzzze_);
                decimal? kzzzg_ = context.Operators.Divide(kzzzd_, kzzzf_);

                return kzzzg_;
            }
            else
            {
                string kzzzh_ = this.ErrorLevel(context);
                string kzzzi_ = period?.unit;
                string kzzzj_ = context.Operators.Concatenate("Unknown unit ", kzzzi_ ?? "");
                object kzzzk_ = context.Operators.Message<object>(null, "CMDLogic.ToDaily.UnknownUnit", kzzzh_, kzzzj_);

                return kzzzk_ as decimal?;
            }
        };

        return czzzq_();
    }


    [CqlExpressionDefinition("ToDaily")]
    public decimal? ToDaily(CqlContext context, CqlCode frequency)
    {
        decimal? kzzzl_()
        {
            bool kzzzm_()
            {
                CqlCode mzzzh_ = this.HS(context);
                bool? mzzzi_ = context.Operators.Equivalent(frequency, mzzzh_);

                return mzzzi_ ?? false;
            };
            bool kzzzn_()
            {
                CqlCode mzzzj_ = this.WAKE(context);
                bool? mzzzk_ = context.Operators.Equivalent(frequency, mzzzj_);

                return mzzzk_ ?? false;
            };
            bool kzzzo_()
            {
                CqlCode mzzzl_ = this.C(context);
                bool? mzzzm_ = context.Operators.Equivalent(frequency, mzzzl_);

                return mzzzm_ ?? false;
            };
            bool kzzzp_()
            {
                CqlCode mzzzn_ = this.CM(context);
                bool? mzzzo_ = context.Operators.Equivalent(frequency, mzzzn_);

                return mzzzo_ ?? false;
            };
            bool kzzzq_()
            {
                CqlCode mzzzp_ = this.CD(context);
                bool? mzzzq_ = context.Operators.Equivalent(frequency, mzzzp_);

                return mzzzq_ ?? false;
            };
            bool kzzzr_()
            {
                CqlCode mzzzr_ = this.CV(context);
                bool? mzzzs_ = context.Operators.Equivalent(frequency, mzzzr_);

                return mzzzs_ ?? false;
            };
            bool kzzzs_()
            {
                CqlCode mzzzt_ = this.AC(context);
                bool? mzzzu_ = context.Operators.Equivalent(frequency, mzzzt_);

                return mzzzu_ ?? false;
            };
            bool kzzzt_()
            {
                CqlCode mzzzv_ = this.ACM(context);
                bool? mzzzw_ = context.Operators.Equivalent(frequency, mzzzv_);

                return mzzzw_ ?? false;
            };
            bool kzzzu_()
            {
                CqlCode mzzzx_ = this.ACD(context);
                bool? mzzzy_ = context.Operators.Equivalent(frequency, mzzzx_);

                return mzzzy_ ?? false;
            };
            bool kzzzv_()
            {
                CqlCode mzzzz_ = this.ACV(context);
                bool? nzzza_ = context.Operators.Equivalent(frequency, mzzzz_);

                return nzzza_ ?? false;
            };
            bool kzzzw_()
            {
                CqlCode nzzzb_ = this.PC(context);
                bool? nzzzc_ = context.Operators.Equivalent(frequency, nzzzb_);

                return nzzzc_ ?? false;
            };
            bool kzzzx_()
            {
                CqlCode nzzzd_ = this.PCM(context);
                bool? nzzze_ = context.Operators.Equivalent(frequency, nzzzd_);

                return nzzze_ ?? false;
            };
            bool kzzzy_()
            {
                CqlCode nzzzf_ = this.PCD(context);
                bool? nzzzg_ = context.Operators.Equivalent(frequency, nzzzf_);

                return nzzzg_ ?? false;
            };
            bool kzzzz_()
            {
                CqlCode nzzzh_ = this.PCV(context);
                bool? nzzzi_ = context.Operators.Equivalent(frequency, nzzzh_);

                return nzzzi_ ?? false;
            };
            bool lzzza_()
            {
                CqlCode nzzzj_ = this.MORN(context);
                bool? nzzzk_ = context.Operators.Equivalent(frequency, nzzzj_);

                return nzzzk_ ?? false;
            };
            bool lzzzb_()
            {
                CqlCode nzzzl_ = this.MORN_early(context);
                bool? nzzzm_ = context.Operators.Equivalent(frequency, nzzzl_);

                return nzzzm_ ?? false;
            };
            bool lzzzc_()
            {
                CqlCode nzzzn_ = this.MORN_late(context);
                bool? nzzzo_ = context.Operators.Equivalent(frequency, nzzzn_);

                return nzzzo_ ?? false;
            };
            bool lzzzd_()
            {
                CqlCode nzzzp_ = this.NOON(context);
                bool? nzzzq_ = context.Operators.Equivalent(frequency, nzzzp_);

                return nzzzq_ ?? false;
            };
            bool lzzze_()
            {
                CqlCode nzzzr_ = this.AFT(context);
                bool? nzzzs_ = context.Operators.Equivalent(frequency, nzzzr_);

                return nzzzs_ ?? false;
            };
            bool lzzzf_()
            {
                CqlCode nzzzt_ = this.AFT_early(context);
                bool? nzzzu_ = context.Operators.Equivalent(frequency, nzzzt_);

                return nzzzu_ ?? false;
            };
            bool lzzzg_()
            {
                CqlCode nzzzv_ = this.AFT_late(context);
                bool? nzzzw_ = context.Operators.Equivalent(frequency, nzzzv_);

                return nzzzw_ ?? false;
            };
            bool lzzzh_()
            {
                CqlCode nzzzx_ = this.EVE(context);
                bool? nzzzy_ = context.Operators.Equivalent(frequency, nzzzx_);

                return nzzzy_ ?? false;
            };
            bool lzzzi_()
            {
                CqlCode nzzzz_ = this.EVE_early(context);
                bool? ozzza_ = context.Operators.Equivalent(frequency, nzzzz_);

                return ozzza_ ?? false;
            };
            bool lzzzj_()
            {
                CqlCode ozzzb_ = this.EVE_late(context);
                bool? ozzzc_ = context.Operators.Equivalent(frequency, ozzzb_);

                return ozzzc_ ?? false;
            };
            bool lzzzk_()
            {
                CqlCode ozzzd_ = this.NIGHT(context);
                bool? ozzze_ = context.Operators.Equivalent(frequency, ozzzd_);

                return ozzze_ ?? false;
            };
            bool lzzzl_()
            {
                CqlCode ozzzf_ = this.PHS(context);
                bool? ozzzg_ = context.Operators.Equivalent(frequency, ozzzf_);

                return ozzzg_ ?? false;
            };
            bool lzzzm_()
            {
                CqlCode ozzzh_ = this.Once_daily__qualifier_value_(context);
                bool? ozzzi_ = context.Operators.Equivalent(frequency, ozzzh_);

                return ozzzi_ ?? false;
            };
            bool lzzzn_()
            {
                CqlCode ozzzj_ = this.Twice_a_day__qualifier_value_(context);
                bool? ozzzk_ = context.Operators.Equivalent(frequency, ozzzj_);

                return ozzzk_ ?? false;
            };
            bool lzzzo_()
            {
                CqlCode ozzzl_ = this.Three_times_daily__qualifier_value_(context);
                bool? ozzzm_ = context.Operators.Equivalent(frequency, ozzzl_);

                return ozzzm_ ?? false;
            };
            bool lzzzp_()
            {
                CqlCode ozzzn_ = this.Four_times_daily__qualifier_value_(context);
                bool? ozzzo_ = context.Operators.Equivalent(frequency, ozzzn_);

                return ozzzo_ ?? false;
            };
            bool lzzzq_()
            {
                CqlCode ozzzp_ = this.Every_twenty_four_hours__qualifier_value_(context);
                bool? ozzzq_ = context.Operators.Equivalent(frequency, ozzzp_);

                return ozzzq_ ?? false;
            };
            bool lzzzr_()
            {
                CqlCode ozzzr_ = this.Every_twelve_hours__qualifier_value_(context);
                bool? ozzzs_ = context.Operators.Equivalent(frequency, ozzzr_);

                return ozzzs_ ?? false;
            };
            bool lzzzs_()
            {
                CqlCode ozzzt_ = this.Every_thirty_six_hours__qualifier_value_(context);
                bool? ozzzu_ = context.Operators.Equivalent(frequency, ozzzt_);

                return ozzzu_ ?? false;
            };
            bool lzzzt_()
            {
                CqlCode ozzzv_ = this.Every_eight_hours__qualifier_value_(context);
                bool? ozzzw_ = context.Operators.Equivalent(frequency, ozzzv_);

                return ozzzw_ ?? false;
            };
            bool lzzzu_()
            {
                CqlCode ozzzx_ = this.Every_four_hours__qualifier_value_(context);
                bool? ozzzy_ = context.Operators.Equivalent(frequency, ozzzx_);

                return ozzzy_ ?? false;
            };
            bool lzzzv_()
            {
                CqlCode ozzzz_ = this.Every_six_hours__qualifier_value_(context);
                bool? pzzza_ = context.Operators.Equivalent(frequency, ozzzz_);

                return pzzza_ ?? false;
            };
            bool lzzzw_()
            {
                CqlCode pzzzb_ = this.Every_seventy_two_hours__qualifier_value_(context);
                bool? pzzzc_ = context.Operators.Equivalent(frequency, pzzzb_);

                return pzzzc_ ?? false;
            };
            bool lzzzx_()
            {
                CqlCode pzzzd_ = this.Every_forty_eight_hours__qualifier_value_(context);
                bool? pzzze_ = context.Operators.Equivalent(frequency, pzzzd_);

                return pzzze_ ?? false;
            };
            bool lzzzy_()
            {
                CqlCode pzzzf_ = this.Every_eight_to_twelve_hours__qualifier_value_(context);
                bool? pzzzg_ = context.Operators.Equivalent(frequency, pzzzf_);

                return pzzzg_ ?? false;
            };
            bool lzzzz_()
            {
                CqlCode pzzzh_ = this.Every_six_to_eight_hours__qualifier_value_(context);
                bool? pzzzi_ = context.Operators.Equivalent(frequency, pzzzh_);

                return pzzzi_ ?? false;
            };
            bool mzzza_()
            {
                CqlCode pzzzj_ = this.Every_three_to_four_hours__qualifier_value_(context);
                bool? pzzzk_ = context.Operators.Equivalent(frequency, pzzzj_);

                return pzzzk_ ?? false;
            };
            bool mzzzb_()
            {
                CqlCode pzzzl_ = this.Every_three_to_six_hours__qualifier_value_(context);
                bool? pzzzm_ = context.Operators.Equivalent(frequency, pzzzl_);

                return pzzzm_ ?? false;
            };
            bool mzzzc_()
            {
                CqlCode pzzzn_ = this.Every_two_to_four_hours__qualifier_value_(context);
                bool? pzzzo_ = context.Operators.Equivalent(frequency, pzzzn_);

                return pzzzo_ ?? false;
            };
            bool mzzzd_()
            {
                CqlCode pzzzp_ = this.One_to_four_times_a_day__qualifier_value_(context);
                bool? pzzzq_ = context.Operators.Equivalent(frequency, pzzzp_);

                return pzzzq_ ?? false;
            };
            bool mzzze_()
            {
                CqlCode pzzzr_ = this.One_to_three_times_a_day__qualifier_value_(context);
                bool? pzzzs_ = context.Operators.Equivalent(frequency, pzzzr_);

                return pzzzs_ ?? false;
            };
            bool mzzzf_()
            {
                CqlCode pzzzt_ = this.One_to_two_times_a_day__qualifier_value_(context);
                bool? pzzzu_ = context.Operators.Equivalent(frequency, pzzzt_);

                return pzzzu_ ?? false;
            };
            bool mzzzg_()
            {
                CqlCode pzzzv_ = this.Two_to_four_times_a_day__qualifier_value_(context);
                bool? pzzzw_ = context.Operators.Equivalent(frequency, pzzzv_);

                return pzzzw_ ?? false;
            };
            if (kzzzm_())
            {
                decimal? pzzzx_ = context.Operators.ConvertIntegerToDecimal(1);

                return pzzzx_;
            }
            else if (kzzzn_())
            {
                decimal? pzzzy_ = context.Operators.ConvertIntegerToDecimal(1);

                return pzzzy_;
            }
            else if (kzzzo_())
            {
                decimal? pzzzz_ = context.Operators.ConvertIntegerToDecimal(3);

                return pzzzz_;
            }
            else if (kzzzp_())
            {
                decimal? qzzza_ = context.Operators.ConvertIntegerToDecimal(1);

                return qzzza_;
            }
            else if (kzzzq_())
            {
                decimal? qzzzb_ = context.Operators.ConvertIntegerToDecimal(1);

                return qzzzb_;
            }
            else if (kzzzr_())
            {
                decimal? qzzzc_ = context.Operators.ConvertIntegerToDecimal(1);

                return qzzzc_;
            }
            else if (kzzzs_())
            {
                decimal? qzzzd_ = context.Operators.ConvertIntegerToDecimal(3);

                return qzzzd_;
            }
            else if (kzzzt_())
            {
                decimal? qzzze_ = context.Operators.ConvertIntegerToDecimal(1);

                return qzzze_;
            }
            else if (kzzzu_())
            {
                decimal? qzzzf_ = context.Operators.ConvertIntegerToDecimal(1);

                return qzzzf_;
            }
            else if (kzzzv_())
            {
                decimal? qzzzg_ = context.Operators.ConvertIntegerToDecimal(1);

                return qzzzg_;
            }
            else if (kzzzw_())
            {
                decimal? qzzzh_ = context.Operators.ConvertIntegerToDecimal(3);

                return qzzzh_;
            }
            else if (kzzzx_())
            {
                decimal? qzzzi_ = context.Operators.ConvertIntegerToDecimal(1);

                return qzzzi_;
            }
            else if (kzzzy_())
            {
                decimal? qzzzj_ = context.Operators.ConvertIntegerToDecimal(1);

                return qzzzj_;
            }
            else if (kzzzz_())
            {
                decimal? qzzzk_ = context.Operators.ConvertIntegerToDecimal(1);

                return qzzzk_;
            }
            else if (lzzza_())
            {
                decimal? qzzzl_ = context.Operators.ConvertIntegerToDecimal(1);

                return qzzzl_;
            }
            else if (lzzzb_())
            {
                decimal? qzzzm_ = context.Operators.ConvertIntegerToDecimal(1);

                return qzzzm_;
            }
            else if (lzzzc_())
            {
                decimal? qzzzn_ = context.Operators.ConvertIntegerToDecimal(1);

                return qzzzn_;
            }
            else if (lzzzd_())
            {
                decimal? qzzzo_ = context.Operators.ConvertIntegerToDecimal(1);

                return qzzzo_;
            }
            else if (lzzze_())
            {
                decimal? qzzzp_ = context.Operators.ConvertIntegerToDecimal(1);

                return qzzzp_;
            }
            else if (lzzzf_())
            {
                decimal? qzzzq_ = context.Operators.ConvertIntegerToDecimal(1);

                return qzzzq_;
            }
            else if (lzzzg_())
            {
                decimal? qzzzr_ = context.Operators.ConvertIntegerToDecimal(1);

                return qzzzr_;
            }
            else if (lzzzh_())
            {
                decimal? qzzzs_ = context.Operators.ConvertIntegerToDecimal(1);

                return qzzzs_;
            }
            else if (lzzzi_())
            {
                decimal? qzzzt_ = context.Operators.ConvertIntegerToDecimal(1);

                return qzzzt_;
            }
            else if (lzzzj_())
            {
                decimal? qzzzu_ = context.Operators.ConvertIntegerToDecimal(1);

                return qzzzu_;
            }
            else if (lzzzk_())
            {
                decimal? qzzzv_ = context.Operators.ConvertIntegerToDecimal(1);

                return qzzzv_;
            }
            else if (lzzzl_())
            {
                decimal? qzzzw_ = context.Operators.ConvertIntegerToDecimal(1);

                return qzzzw_;
            }
            else if (lzzzm_())
            {
                return 1.0m;
            }
            else if (lzzzn_())
            {
                return 2.0m;
            }
            else if (lzzzo_())
            {
                return 3.0m;
            }
            else if (lzzzp_())
            {
                return 4.0m;
            }
            else if (lzzzq_())
            {
                return 1.0m;
            }
            else if (lzzzr_())
            {
                return 2.0m;
            }
            else if (lzzzs_())
            {
                return 0.67m;
            }
            else if (lzzzt_())
            {
                return 3.0m;
            }
            else if (lzzzu_())
            {
                return 6.0m;
            }
            else if (lzzzv_())
            {
                return 4.0m;
            }
            else if (lzzzw_())
            {
                return 0.33m;
            }
            else if (lzzzx_())
            {
                return 0.5m;
            }
            else if (lzzzy_())
            {
                return 3.0m;
            }
            else if (lzzzz_())
            {
                return 4.0m;
            }
            else if (mzzza_())
            {
                return 8.0m;
            }
            else if (mzzzb_())
            {
                return 8.0m;
            }
            else if (mzzzc_())
            {
                return 12.0m;
            }
            else if (mzzzd_())
            {
                return 4.0m;
            }
            else if (mzzze_())
            {
                return 3.0m;
            }
            else if (mzzzf_())
            {
                return 2.0m;
            }
            else if (mzzzg_())
            {
                return 4.0m;
            }
            else
            {
                string qzzzx_ = this.ErrorLevel(context);
                string qzzzy_ = frequency?.code;
                string qzzzz_ = context.Operators.Concatenate("Unknown frequency code ", qzzzy_ ?? "");
                object rzzza_ = context.Operators.Message<object>(null, "CMDLogic.ToDaily.UnknownFrequencyCode", qzzzx_, qzzzz_);

                return rzzza_ as decimal?;
            }
        };

        return kzzzl_();
    }


    [CqlExpressionDefinition("Quantity")]
    public CqlQuantity Quantity(CqlContext context, decimal? value, string unit) =>
        ((context.Operators.Not((bool?)(value is null))) ?? false
            ? new CqlQuantity(value, unit)
            : default);


    [CqlExpressionDefinition("MedicationRequestPeriod")]
    public CqlInterval<CqlDate> MedicationRequestPeriod(CqlContext context, MedicationRequest Request)
    {
        MedicationRequest[] rzzzb_ = [
            Request,
        ];
        CqlInterval<CqlDate> rzzzc_(MedicationRequest R)
        {
            CqlInterval<CqlDate> rzzzg_()
            {
                bool rzzzh_()
                {
                    List<Dosage> rzzzj_ = R?.DosageInstruction;
                    Dosage rzzzk_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)rzzzj_);
                    Timing rzzzl_ = rzzzk_?.Timing;
                    Timing.RepeatComponent rzzzm_ = rzzzl_?.Repeat;
                    DataType rzzzn_ = rzzzm_?.Bounds;
                    object rzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzn_);
                    CqlDateTime rzzzp_ = context.Operators.Start(rzzzo_ as CqlInterval<CqlDateTime>);
                    CqlDate rzzzq_ = context.Operators.DateFrom(rzzzp_);
                    FhirDateTime rzzzr_ = R?.AuthoredOnElement;
                    CqlDateTime rzzzs_ = context.Operators.Convert<CqlDateTime>(rzzzr_);
                    CqlDate rzzzt_ = context.Operators.DateFrom(rzzzs_);
                    MedicationRequest.DispenseRequestComponent rzzzu_ = R?.DispenseRequest;
                    Period rzzzv_ = rzzzu_?.ValidityPeriod;
                    CqlInterval<CqlDateTime> rzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzv_);
                    CqlDateTime rzzzx_ = context.Operators.Start(rzzzw_);
                    CqlDate rzzzy_ = context.Operators.DateFrom(rzzzx_);
                    bool? rzzzz_ = context.Operators.Not((bool?)(((rzzzq_ ?? rzzzt_) ?? rzzzy_) is null));
                    Duration szzzb_ = rzzzu_?.ExpectedSupplyDuration;
                    CqlQuantity szzzc_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, szzzb_);
                    CqlQuantity szzzd_ = context.Operators.ConvertQuantity(szzzc_, "d");
                    decimal? szzze_ = szzzd_?.value;
                    Quantity szzzg_ = rzzzu_?.Quantity;
                    CqlQuantity szzzh_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, szzzg_);
                    decimal? szzzi_ = szzzh_?.value;
                    Dosage szzzk_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)rzzzj_);
                    List<Dosage.DoseAndRateComponent> szzzl_ = szzzk_?.DoseAndRate;
                    Dosage.DoseAndRateComponent szzzm_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)szzzl_);
                    DataType szzzn_ = szzzm_?.Dose;
                    object szzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzn_);
                    CqlQuantity szzzp_ = context.Operators.End(szzzo_ as CqlInterval<CqlQuantity>);
                    Dosage szzzr_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)rzzzj_);
                    List<Dosage.DoseAndRateComponent> szzzs_ = szzzr_?.DoseAndRate;
                    Dosage.DoseAndRateComponent szzzt_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)szzzs_);
                    DataType szzzu_ = szzzt_?.Dose;
                    object szzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzu_);
                    decimal? szzzw_ = (szzzp_ ?? szzzv_ as CqlQuantity)?.value;
                    Dosage szzzy_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)rzzzj_);
                    Timing szzzz_ = szzzy_?.Timing;
                    Timing.RepeatComponent tzzza_ = szzzz_?.Repeat;
                    PositiveInt tzzzb_ = tzzza_?.FrequencyMaxElement;
                    int? tzzzc_ = tzzzb_?.Value;
                    Dosage tzzze_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)rzzzj_);
                    Timing tzzzf_ = tzzze_?.Timing;
                    Timing.RepeatComponent tzzzg_ = tzzzf_?.Repeat;
                    PositiveInt tzzzh_ = tzzzg_?.FrequencyElement;
                    int? tzzzi_ = tzzzh_?.Value;
                    Dosage tzzzk_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)rzzzj_);
                    Timing tzzzl_ = tzzzk_?.Timing;
                    Timing.RepeatComponent tzzzm_ = tzzzl_?.Repeat;
                    FhirDecimal tzzzn_ = tzzzm_?.PeriodElement;
                    decimal? tzzzo_ = tzzzn_?.Value;
                    Dosage tzzzq_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)rzzzj_);
                    Timing tzzzr_ = tzzzq_?.Timing;
                    Timing.RepeatComponent tzzzs_ = tzzzr_?.Repeat;
                    Code<Timing.UnitsOfTime> tzzzt_ = tzzzs_?.PeriodUnitElement;
                    Timing.UnitsOfTime? tzzzu_ = tzzzt_?.Value;
                    string tzzzv_ = context.Operators.Convert<string>(tzzzu_);
                    CqlQuantity tzzzw_ = this.Quantity(context, tzzzo_, tzzzv_);
                    decimal? tzzzx_ = this.ToDaily(context, tzzzc_ ?? tzzzi_, tzzzw_);
                    Dosage tzzzz_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)rzzzj_);
                    Timing uzzza_ = tzzzz_?.Timing;
                    Timing.RepeatComponent uzzzb_ = uzzza_?.Repeat;
                    List<Time> uzzzc_ = uzzzb_?.TimeOfDayElement;
                    IEnumerable<CqlTime> uzzzd_ = context.Operators.LateBoundProperty<IEnumerable<CqlTime>>(uzzzc_, "value");
                    int? uzzze_ = context.Operators.Count<CqlTime>(uzzzd_);
                    decimal? uzzzf_ = context.Operators.ConvertIntegerToDecimal(uzzze_);
                    decimal? uzzzg_ = context.Operators.Multiply(szzzw_, (tzzzx_ ?? uzzzf_) ?? 1.0m);
                    decimal? uzzzh_ = context.Operators.Divide(szzzi_, uzzzg_);
                    UnsignedInt uzzzj_ = rzzzu_?.NumberOfRepeatsAllowedElement;
                    int? uzzzk_ = uzzzj_?.Value;
                    int? uzzzl_ = context.Operators.Add(1, uzzzk_ ?? 0);
                    decimal? uzzzm_ = context.Operators.ConvertIntegerToDecimal(uzzzl_);
                    decimal? uzzzn_ = context.Operators.Multiply(szzze_ ?? uzzzh_, uzzzm_);
                    bool? uzzzo_ = context.Operators.Not((bool?)(uzzzn_ is null));
                    bool? uzzzp_ = context.Operators.And(rzzzz_, uzzzo_);

                    return uzzzp_ ?? false;
                };
                bool rzzzi_()
                {
                    List<Dosage> uzzzq_ = R?.DosageInstruction;
                    Dosage uzzzr_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)uzzzq_);
                    Timing uzzzs_ = uzzzr_?.Timing;
                    Timing.RepeatComponent uzzzt_ = uzzzs_?.Repeat;
                    DataType uzzzu_ = uzzzt_?.Bounds;
                    object uzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzu_);
                    CqlDateTime uzzzw_ = context.Operators.Start(uzzzv_ as CqlInterval<CqlDateTime>);
                    CqlDate uzzzx_ = context.Operators.DateFrom(uzzzw_);
                    FhirDateTime uzzzy_ = R?.AuthoredOnElement;
                    CqlDateTime uzzzz_ = context.Operators.Convert<CqlDateTime>(uzzzy_);
                    CqlDate vzzza_ = context.Operators.DateFrom(uzzzz_);
                    MedicationRequest.DispenseRequestComponent vzzzb_ = R?.DispenseRequest;
                    Period vzzzc_ = vzzzb_?.ValidityPeriod;
                    CqlInterval<CqlDateTime> vzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzc_);
                    CqlDateTime vzzze_ = context.Operators.Start(vzzzd_);
                    CqlDate vzzzf_ = context.Operators.DateFrom(vzzze_);
                    bool? vzzzg_ = context.Operators.Not((bool?)(((uzzzx_ ?? vzzza_) ?? vzzzf_) is null));
                    Dosage vzzzi_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)uzzzq_);
                    Timing vzzzj_ = vzzzi_?.Timing;
                    Timing.RepeatComponent vzzzk_ = vzzzj_?.Repeat;
                    DataType vzzzl_ = vzzzk_?.Bounds;
                    object vzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzl_);
                    CqlDateTime vzzzn_ = (vzzzm_ as CqlInterval<CqlDateTime>)?.high;
                    bool? vzzzo_ = context.Operators.Not((bool?)(vzzzn_ is null));
                    bool? vzzzp_ = context.Operators.And(vzzzg_, vzzzo_);

                    return vzzzp_ ?? false;
                };
                if (rzzzh_())
                {
                    List<Dosage> vzzzq_ = R?.DosageInstruction;
                    Dosage vzzzr_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)vzzzq_);
                    Timing vzzzs_ = vzzzr_?.Timing;
                    Timing.RepeatComponent vzzzt_ = vzzzs_?.Repeat;
                    DataType vzzzu_ = vzzzt_?.Bounds;
                    object vzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzu_);
                    CqlDateTime vzzzw_ = context.Operators.Start(vzzzv_ as CqlInterval<CqlDateTime>);
                    CqlDate vzzzx_ = context.Operators.DateFrom(vzzzw_);
                    FhirDateTime vzzzy_ = R?.AuthoredOnElement;
                    CqlDateTime vzzzz_ = context.Operators.Convert<CqlDateTime>(vzzzy_);
                    CqlDate wzzza_ = context.Operators.DateFrom(vzzzz_);
                    MedicationRequest.DispenseRequestComponent wzzzb_ = R?.DispenseRequest;
                    Period wzzzc_ = wzzzb_?.ValidityPeriod;
                    CqlInterval<CqlDateTime> wzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzc_);
                    CqlDateTime wzzze_ = context.Operators.Start(wzzzd_);
                    CqlDate wzzzf_ = context.Operators.DateFrom(wzzze_);
                    Dosage wzzzh_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)vzzzq_);
                    Timing wzzzi_ = wzzzh_?.Timing;
                    Timing.RepeatComponent wzzzj_ = wzzzi_?.Repeat;
                    DataType wzzzk_ = wzzzj_?.Bounds;
                    object wzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzk_);
                    CqlDateTime wzzzm_ = context.Operators.Start(wzzzl_ as CqlInterval<CqlDateTime>);
                    CqlDate wzzzn_ = context.Operators.DateFrom(wzzzm_);
                    CqlDateTime wzzzp_ = context.Operators.Convert<CqlDateTime>(vzzzy_);
                    CqlDate wzzzq_ = context.Operators.DateFrom(wzzzp_);
                    Period wzzzs_ = wzzzb_?.ValidityPeriod;
                    CqlInterval<CqlDateTime> wzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzs_);
                    CqlDateTime wzzzu_ = context.Operators.Start(wzzzt_);
                    CqlDate wzzzv_ = context.Operators.DateFrom(wzzzu_);
                    Duration wzzzx_ = wzzzb_?.ExpectedSupplyDuration;
                    CqlQuantity wzzzy_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, wzzzx_);
                    CqlQuantity wzzzz_ = context.Operators.ConvertQuantity(wzzzy_, "d");
                    decimal? xzzza_ = wzzzz_?.value;
                    Quantity xzzzc_ = wzzzb_?.Quantity;
                    CqlQuantity xzzzd_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, xzzzc_);
                    decimal? xzzze_ = xzzzd_?.value;
                    Dosage xzzzg_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)vzzzq_);
                    List<Dosage.DoseAndRateComponent> xzzzh_ = xzzzg_?.DoseAndRate;
                    Dosage.DoseAndRateComponent xzzzi_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)xzzzh_);
                    DataType xzzzj_ = xzzzi_?.Dose;
                    object xzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzj_);
                    CqlQuantity xzzzl_ = context.Operators.End(xzzzk_ as CqlInterval<CqlQuantity>);
                    Dosage xzzzn_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)vzzzq_);
                    List<Dosage.DoseAndRateComponent> xzzzo_ = xzzzn_?.DoseAndRate;
                    Dosage.DoseAndRateComponent xzzzp_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)xzzzo_);
                    DataType xzzzq_ = xzzzp_?.Dose;
                    object xzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzq_);
                    decimal? xzzzs_ = (xzzzl_ ?? xzzzr_ as CqlQuantity)?.value;
                    Dosage xzzzu_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)vzzzq_);
                    Timing xzzzv_ = xzzzu_?.Timing;
                    Timing.RepeatComponent xzzzw_ = xzzzv_?.Repeat;
                    PositiveInt xzzzx_ = xzzzw_?.FrequencyMaxElement;
                    int? xzzzy_ = xzzzx_?.Value;
                    Dosage yzzza_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)vzzzq_);
                    Timing yzzzb_ = yzzza_?.Timing;
                    Timing.RepeatComponent yzzzc_ = yzzzb_?.Repeat;
                    PositiveInt yzzzd_ = yzzzc_?.FrequencyElement;
                    int? yzzze_ = yzzzd_?.Value;
                    Dosage yzzzg_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)vzzzq_);
                    Timing yzzzh_ = yzzzg_?.Timing;
                    Timing.RepeatComponent yzzzi_ = yzzzh_?.Repeat;
                    FhirDecimal yzzzj_ = yzzzi_?.PeriodElement;
                    decimal? yzzzk_ = yzzzj_?.Value;
                    Dosage yzzzm_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)vzzzq_);
                    Timing yzzzn_ = yzzzm_?.Timing;
                    Timing.RepeatComponent yzzzo_ = yzzzn_?.Repeat;
                    Code<Timing.UnitsOfTime> yzzzp_ = yzzzo_?.PeriodUnitElement;
                    Timing.UnitsOfTime? yzzzq_ = yzzzp_?.Value;
                    string yzzzr_ = context.Operators.Convert<string>(yzzzq_);
                    CqlQuantity yzzzs_ = this.Quantity(context, yzzzk_, yzzzr_);
                    decimal? yzzzt_ = this.ToDaily(context, xzzzy_ ?? yzzze_, yzzzs_);
                    Dosage yzzzv_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)vzzzq_);
                    Timing yzzzw_ = yzzzv_?.Timing;
                    Timing.RepeatComponent yzzzx_ = yzzzw_?.Repeat;
                    List<Time> yzzzy_ = yzzzx_?.TimeOfDayElement;
                    IEnumerable<CqlTime> yzzzz_ = context.Operators.LateBoundProperty<IEnumerable<CqlTime>>(yzzzy_, "value");
                    int? zzzza_ = context.Operators.Count<CqlTime>(yzzzz_);
                    decimal? zzzzb_ = context.Operators.ConvertIntegerToDecimal(zzzza_);
                    decimal? zzzzc_ = context.Operators.Multiply(xzzzs_, (yzzzt_ ?? zzzzb_) ?? 1.0m);
                    decimal? zzzzd_ = context.Operators.Divide(xzzze_, zzzzc_);
                    UnsignedInt zzzzf_ = wzzzb_?.NumberOfRepeatsAllowedElement;
                    int? zzzzg_ = zzzzf_?.Value;
                    int? zzzzh_ = context.Operators.Add(1, zzzzg_ ?? 0);
                    decimal? zzzzi_ = context.Operators.ConvertIntegerToDecimal(zzzzh_);
                    decimal? zzzzj_ = context.Operators.Multiply(xzzza_ ?? zzzzd_, zzzzi_);
                    decimal? zzzzk_ = context.Operators.ConvertIntegerToDecimal(1);
                    decimal? zzzzl_ = context.Operators.Subtract(zzzzj_, zzzzk_);
                    CqlQuantity zzzzm_ = this.Quantity(context, zzzzl_, "day");
                    CqlDate zzzzn_ = context.Operators.Add((wzzzn_ ?? wzzzq_) ?? wzzzv_, zzzzm_);
                    CqlInterval<CqlDate> zzzzo_ = context.Operators.Interval((vzzzx_ ?? wzzza_) ?? wzzzf_, zzzzn_, true, true);

                    return zzzzo_;
                }
                else if (rzzzi_())
                {
                    List<Dosage> zzzzp_ = R?.DosageInstruction;
                    Dosage zzzzq_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)zzzzp_);
                    Timing zzzzr_ = zzzzq_?.Timing;
                    Timing.RepeatComponent zzzzs_ = zzzzr_?.Repeat;
                    DataType zzzzt_ = zzzzs_?.Bounds;
                    object zzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzt_);
                    CqlDateTime zzzzv_ = context.Operators.Start(zzzzu_ as CqlInterval<CqlDateTime>);
                    CqlDate zzzzw_ = context.Operators.DateFrom(zzzzv_);
                    FhirDateTime zzzzx_ = R?.AuthoredOnElement;
                    CqlDateTime zzzzy_ = context.Operators.Convert<CqlDateTime>(zzzzx_);
                    CqlDate zzzzz_ = context.Operators.DateFrom(zzzzy_);
                    MedicationRequest.DispenseRequestComponent azzzza_ = R?.DispenseRequest;
                    Period azzzzb_ = azzzza_?.ValidityPeriod;
                    CqlInterval<CqlDateTime> azzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzb_);
                    CqlDateTime azzzzd_ = context.Operators.Start(azzzzc_);
                    CqlDate azzzze_ = context.Operators.DateFrom(azzzzd_);
                    Dosage azzzzg_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)zzzzp_);
                    Timing azzzzh_ = azzzzg_?.Timing;
                    Timing.RepeatComponent azzzzi_ = azzzzh_?.Repeat;
                    DataType azzzzj_ = azzzzi_?.Bounds;
                    object azzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzj_);
                    CqlDateTime azzzzl_ = context.Operators.End(azzzzk_ as CqlInterval<CqlDateTime>);
                    CqlDate azzzzm_ = context.Operators.DateFrom(azzzzl_);
                    CqlInterval<CqlDate> azzzzn_ = context.Operators.Interval((zzzzw_ ?? zzzzz_) ?? azzzze_, azzzzm_, true, true);

                    return azzzzn_;
                }
                else
                {
                    return null as CqlInterval<CqlDate>;
                }
            };

            return rzzzg_();
        };
        IEnumerable<CqlInterval<CqlDate>> rzzzd_ = context.Operators.Select<MedicationRequest, CqlInterval<CqlDate>>((IEnumerable<MedicationRequest>)rzzzb_, rzzzc_);
        IEnumerable<CqlInterval<CqlDate>> rzzze_ = context.Operators.Distinct<CqlInterval<CqlDate>>(rzzzd_);
        CqlInterval<CqlDate> rzzzf_ = context.Operators.SingletonFrom<CqlInterval<CqlDate>>(rzzze_);

        return rzzzf_;
    }


    [CqlExpressionDefinition("medicationRequestPeriod")]
    public CqlInterval<CqlDate> medicationRequestPeriod(CqlContext context, MedicationRequest Request)
    {
        MedicationRequest[] azzzzo_ = [
            Request,
        ];
        CqlInterval<CqlDate> azzzzp_(MedicationRequest R)
        {
            CqlInterval<CqlDate> azzzzt_()
            {
                bool azzzzu_()
                {
                    List<Dosage> azzzzw_ = R?.DosageInstruction;
                    Dosage azzzzx_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)azzzzw_);
                    Timing azzzzy_ = azzzzx_?.Timing;
                    Timing.RepeatComponent azzzzz_ = azzzzy_?.Repeat;
                    DataType bzzzza_ = azzzzz_?.Bounds;
                    object bzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzza_);
                    CqlDateTime bzzzzc_ = context.Operators.Start(bzzzzb_ as CqlInterval<CqlDateTime>);
                    CqlDate bzzzzd_ = context.Operators.DateFrom(bzzzzc_);
                    FhirDateTime bzzzze_ = R?.AuthoredOnElement;
                    CqlDateTime bzzzzf_ = context.Operators.Convert<CqlDateTime>(bzzzze_);
                    CqlDate bzzzzg_ = context.Operators.DateFrom(bzzzzf_);
                    MedicationRequest.DispenseRequestComponent bzzzzh_ = R?.DispenseRequest;
                    Period bzzzzi_ = bzzzzh_?.ValidityPeriod;
                    CqlInterval<CqlDateTime> bzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzi_);
                    CqlDateTime bzzzzk_ = context.Operators.Start(bzzzzj_);
                    CqlDate bzzzzl_ = context.Operators.DateFrom(bzzzzk_);
                    bool? bzzzzm_ = context.Operators.Not((bool?)(((bzzzzd_ ?? bzzzzg_) ?? bzzzzl_) is null));
                    Duration bzzzzo_ = bzzzzh_?.ExpectedSupplyDuration;
                    CqlQuantity bzzzzp_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, bzzzzo_);
                    CqlQuantity bzzzzq_ = context.Operators.ConvertQuantity(bzzzzp_, "d");
                    decimal? bzzzzr_ = bzzzzq_?.value;
                    Quantity bzzzzt_ = bzzzzh_?.Quantity;
                    CqlQuantity bzzzzu_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, bzzzzt_);
                    decimal? bzzzzv_ = bzzzzu_?.value;
                    Dosage bzzzzx_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)azzzzw_);
                    List<Dosage.DoseAndRateComponent> bzzzzy_ = bzzzzx_?.DoseAndRate;
                    Dosage.DoseAndRateComponent bzzzzz_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)bzzzzy_);
                    DataType czzzza_ = bzzzzz_?.Dose;
                    object czzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzza_);
                    CqlQuantity czzzzc_ = context.Operators.End(czzzzb_ as CqlInterval<CqlQuantity>);
                    Dosage czzzze_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)azzzzw_);
                    List<Dosage.DoseAndRateComponent> czzzzf_ = czzzze_?.DoseAndRate;
                    Dosage.DoseAndRateComponent czzzzg_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)czzzzf_);
                    DataType czzzzh_ = czzzzg_?.Dose;
                    object czzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzh_);
                    decimal? czzzzj_ = (czzzzc_ ?? czzzzi_ as CqlQuantity)?.value;
                    Dosage czzzzl_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)azzzzw_);
                    Timing czzzzm_ = czzzzl_?.Timing;
                    Timing.RepeatComponent czzzzn_ = czzzzm_?.Repeat;
                    PositiveInt czzzzo_ = czzzzn_?.FrequencyMaxElement;
                    int? czzzzp_ = czzzzo_?.Value;
                    Dosage czzzzr_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)azzzzw_);
                    Timing czzzzs_ = czzzzr_?.Timing;
                    Timing.RepeatComponent czzzzt_ = czzzzs_?.Repeat;
                    PositiveInt czzzzu_ = czzzzt_?.FrequencyElement;
                    int? czzzzv_ = czzzzu_?.Value;
                    Dosage czzzzx_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)azzzzw_);
                    Timing czzzzy_ = czzzzx_?.Timing;
                    Timing.RepeatComponent czzzzz_ = czzzzy_?.Repeat;
                    FhirDecimal dzzzza_ = czzzzz_?.PeriodElement;
                    decimal? dzzzzb_ = dzzzza_?.Value;
                    Dosage dzzzzd_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)azzzzw_);
                    Timing dzzzze_ = dzzzzd_?.Timing;
                    Timing.RepeatComponent dzzzzf_ = dzzzze_?.Repeat;
                    Code<Timing.UnitsOfTime> dzzzzg_ = dzzzzf_?.PeriodUnitElement;
                    Timing.UnitsOfTime? dzzzzh_ = dzzzzg_?.Value;
                    string dzzzzi_ = context.Operators.Convert<string>(dzzzzh_);
                    CqlQuantity dzzzzj_ = this.Quantity(context, dzzzzb_, dzzzzi_);
                    decimal? dzzzzk_ = this.ToDaily(context, czzzzp_ ?? czzzzv_, dzzzzj_);
                    Dosage dzzzzm_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)azzzzw_);
                    Timing dzzzzn_ = dzzzzm_?.Timing;
                    Timing.RepeatComponent dzzzzo_ = dzzzzn_?.Repeat;
                    List<Time> dzzzzp_ = dzzzzo_?.TimeOfDayElement;
                    IEnumerable<CqlTime> dzzzzq_ = context.Operators.LateBoundProperty<IEnumerable<CqlTime>>(dzzzzp_, "value");
                    int? dzzzzr_ = context.Operators.Count<CqlTime>(dzzzzq_);
                    decimal? dzzzzs_ = context.Operators.ConvertIntegerToDecimal(dzzzzr_);
                    decimal? dzzzzt_ = context.Operators.Multiply(czzzzj_, (dzzzzk_ ?? dzzzzs_) ?? 1.0m);
                    decimal? dzzzzu_ = context.Operators.Divide(bzzzzv_, dzzzzt_);
                    UnsignedInt dzzzzw_ = bzzzzh_?.NumberOfRepeatsAllowedElement;
                    int? dzzzzx_ = dzzzzw_?.Value;
                    int? dzzzzy_ = context.Operators.Add(1, dzzzzx_ ?? 0);
                    decimal? dzzzzz_ = context.Operators.ConvertIntegerToDecimal(dzzzzy_);
                    decimal? ezzzza_ = context.Operators.Multiply(bzzzzr_ ?? dzzzzu_, dzzzzz_);
                    bool? ezzzzb_ = context.Operators.Not((bool?)(ezzzza_ is null));
                    bool? ezzzzc_ = context.Operators.And(bzzzzm_, ezzzzb_);

                    return ezzzzc_ ?? false;
                };
                bool azzzzv_()
                {
                    List<Dosage> ezzzzd_ = R?.DosageInstruction;
                    Dosage ezzzze_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)ezzzzd_);
                    Timing ezzzzf_ = ezzzze_?.Timing;
                    Timing.RepeatComponent ezzzzg_ = ezzzzf_?.Repeat;
                    DataType ezzzzh_ = ezzzzg_?.Bounds;
                    object ezzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzh_);
                    CqlDateTime ezzzzj_ = context.Operators.Start(ezzzzi_ as CqlInterval<CqlDateTime>);
                    CqlDate ezzzzk_ = context.Operators.DateFrom(ezzzzj_);
                    FhirDateTime ezzzzl_ = R?.AuthoredOnElement;
                    CqlDateTime ezzzzm_ = context.Operators.Convert<CqlDateTime>(ezzzzl_);
                    CqlDate ezzzzn_ = context.Operators.DateFrom(ezzzzm_);
                    MedicationRequest.DispenseRequestComponent ezzzzo_ = R?.DispenseRequest;
                    Period ezzzzp_ = ezzzzo_?.ValidityPeriod;
                    CqlInterval<CqlDateTime> ezzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzp_);
                    CqlDateTime ezzzzr_ = context.Operators.Start(ezzzzq_);
                    CqlDate ezzzzs_ = context.Operators.DateFrom(ezzzzr_);
                    bool? ezzzzt_ = context.Operators.Not((bool?)(((ezzzzk_ ?? ezzzzn_) ?? ezzzzs_) is null));
                    Dosage ezzzzv_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)ezzzzd_);
                    Timing ezzzzw_ = ezzzzv_?.Timing;
                    Timing.RepeatComponent ezzzzx_ = ezzzzw_?.Repeat;
                    DataType ezzzzy_ = ezzzzx_?.Bounds;
                    object ezzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzy_);
                    CqlDateTime fzzzza_ = (ezzzzz_ as CqlInterval<CqlDateTime>)?.high;
                    bool? fzzzzb_ = context.Operators.Not((bool?)(fzzzza_ is null));
                    bool? fzzzzc_ = context.Operators.And(ezzzzt_, fzzzzb_);

                    return fzzzzc_ ?? false;
                };
                if (azzzzu_())
                {
                    List<Dosage> fzzzzd_ = R?.DosageInstruction;
                    Dosage fzzzze_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)fzzzzd_);
                    Timing fzzzzf_ = fzzzze_?.Timing;
                    Timing.RepeatComponent fzzzzg_ = fzzzzf_?.Repeat;
                    DataType fzzzzh_ = fzzzzg_?.Bounds;
                    object fzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzh_);
                    CqlDateTime fzzzzj_ = context.Operators.Start(fzzzzi_ as CqlInterval<CqlDateTime>);
                    CqlDate fzzzzk_ = context.Operators.DateFrom(fzzzzj_);
                    FhirDateTime fzzzzl_ = R?.AuthoredOnElement;
                    CqlDateTime fzzzzm_ = context.Operators.Convert<CqlDateTime>(fzzzzl_);
                    CqlDate fzzzzn_ = context.Operators.DateFrom(fzzzzm_);
                    MedicationRequest.DispenseRequestComponent fzzzzo_ = R?.DispenseRequest;
                    Period fzzzzp_ = fzzzzo_?.ValidityPeriod;
                    CqlInterval<CqlDateTime> fzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzp_);
                    CqlDateTime fzzzzr_ = context.Operators.Start(fzzzzq_);
                    CqlDate fzzzzs_ = context.Operators.DateFrom(fzzzzr_);
                    Dosage fzzzzu_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)fzzzzd_);
                    Timing fzzzzv_ = fzzzzu_?.Timing;
                    Timing.RepeatComponent fzzzzw_ = fzzzzv_?.Repeat;
                    DataType fzzzzx_ = fzzzzw_?.Bounds;
                    object fzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzx_);
                    CqlDateTime fzzzzz_ = context.Operators.Start(fzzzzy_ as CqlInterval<CqlDateTime>);
                    CqlDate gzzzza_ = context.Operators.DateFrom(fzzzzz_);
                    CqlDateTime gzzzzc_ = context.Operators.Convert<CqlDateTime>(fzzzzl_);
                    CqlDate gzzzzd_ = context.Operators.DateFrom(gzzzzc_);
                    Period gzzzzf_ = fzzzzo_?.ValidityPeriod;
                    CqlInterval<CqlDateTime> gzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzf_);
                    CqlDateTime gzzzzh_ = context.Operators.Start(gzzzzg_);
                    CqlDate gzzzzi_ = context.Operators.DateFrom(gzzzzh_);
                    Duration gzzzzk_ = fzzzzo_?.ExpectedSupplyDuration;
                    CqlQuantity gzzzzl_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, gzzzzk_);
                    CqlQuantity gzzzzm_ = context.Operators.ConvertQuantity(gzzzzl_, "d");
                    decimal? gzzzzn_ = gzzzzm_?.value;
                    Quantity gzzzzp_ = fzzzzo_?.Quantity;
                    CqlQuantity gzzzzq_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, gzzzzp_);
                    decimal? gzzzzr_ = gzzzzq_?.value;
                    Dosage gzzzzt_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)fzzzzd_);
                    List<Dosage.DoseAndRateComponent> gzzzzu_ = gzzzzt_?.DoseAndRate;
                    Dosage.DoseAndRateComponent gzzzzv_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)gzzzzu_);
                    DataType gzzzzw_ = gzzzzv_?.Dose;
                    object gzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzw_);
                    CqlQuantity gzzzzy_ = context.Operators.End(gzzzzx_ as CqlInterval<CqlQuantity>);
                    Dosage hzzzza_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)fzzzzd_);
                    List<Dosage.DoseAndRateComponent> hzzzzb_ = hzzzza_?.DoseAndRate;
                    Dosage.DoseAndRateComponent hzzzzc_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)hzzzzb_);
                    DataType hzzzzd_ = hzzzzc_?.Dose;
                    object hzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzd_);
                    decimal? hzzzzf_ = (gzzzzy_ ?? hzzzze_ as CqlQuantity)?.value;
                    Dosage hzzzzh_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)fzzzzd_);
                    Timing hzzzzi_ = hzzzzh_?.Timing;
                    Timing.RepeatComponent hzzzzj_ = hzzzzi_?.Repeat;
                    PositiveInt hzzzzk_ = hzzzzj_?.FrequencyMaxElement;
                    int? hzzzzl_ = hzzzzk_?.Value;
                    Dosage hzzzzn_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)fzzzzd_);
                    Timing hzzzzo_ = hzzzzn_?.Timing;
                    Timing.RepeatComponent hzzzzp_ = hzzzzo_?.Repeat;
                    PositiveInt hzzzzq_ = hzzzzp_?.FrequencyElement;
                    int? hzzzzr_ = hzzzzq_?.Value;
                    Dosage hzzzzt_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)fzzzzd_);
                    Timing hzzzzu_ = hzzzzt_?.Timing;
                    Timing.RepeatComponent hzzzzv_ = hzzzzu_?.Repeat;
                    FhirDecimal hzzzzw_ = hzzzzv_?.PeriodElement;
                    decimal? hzzzzx_ = hzzzzw_?.Value;
                    Dosage hzzzzz_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)fzzzzd_);
                    Timing izzzza_ = hzzzzz_?.Timing;
                    Timing.RepeatComponent izzzzb_ = izzzza_?.Repeat;
                    Code<Timing.UnitsOfTime> izzzzc_ = izzzzb_?.PeriodUnitElement;
                    Timing.UnitsOfTime? izzzzd_ = izzzzc_?.Value;
                    string izzzze_ = context.Operators.Convert<string>(izzzzd_);
                    CqlQuantity izzzzf_ = this.Quantity(context, hzzzzx_, izzzze_);
                    decimal? izzzzg_ = this.ToDaily(context, hzzzzl_ ?? hzzzzr_, izzzzf_);
                    Dosage izzzzi_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)fzzzzd_);
                    Timing izzzzj_ = izzzzi_?.Timing;
                    Timing.RepeatComponent izzzzk_ = izzzzj_?.Repeat;
                    List<Time> izzzzl_ = izzzzk_?.TimeOfDayElement;
                    IEnumerable<CqlTime> izzzzm_ = context.Operators.LateBoundProperty<IEnumerable<CqlTime>>(izzzzl_, "value");
                    int? izzzzn_ = context.Operators.Count<CqlTime>(izzzzm_);
                    decimal? izzzzo_ = context.Operators.ConvertIntegerToDecimal(izzzzn_);
                    decimal? izzzzp_ = context.Operators.Multiply(hzzzzf_, (izzzzg_ ?? izzzzo_) ?? 1.0m);
                    decimal? izzzzq_ = context.Operators.Divide(gzzzzr_, izzzzp_);
                    UnsignedInt izzzzs_ = fzzzzo_?.NumberOfRepeatsAllowedElement;
                    int? izzzzt_ = izzzzs_?.Value;
                    int? izzzzu_ = context.Operators.Add(1, izzzzt_ ?? 0);
                    decimal? izzzzv_ = context.Operators.ConvertIntegerToDecimal(izzzzu_);
                    decimal? izzzzw_ = context.Operators.Multiply(gzzzzn_ ?? izzzzq_, izzzzv_);
                    decimal? izzzzx_ = context.Operators.ConvertIntegerToDecimal(1);
                    decimal? izzzzy_ = context.Operators.Subtract(izzzzw_, izzzzx_);
                    CqlQuantity izzzzz_ = this.Quantity(context, izzzzy_, "day");
                    CqlDate jzzzza_ = context.Operators.Add((gzzzza_ ?? gzzzzd_) ?? gzzzzi_, izzzzz_);
                    CqlInterval<CqlDate> jzzzzb_ = context.Operators.Interval((fzzzzk_ ?? fzzzzn_) ?? fzzzzs_, jzzzza_, true, true);

                    return jzzzzb_;
                }
                else if (azzzzv_())
                {
                    List<Dosage> jzzzzc_ = R?.DosageInstruction;
                    Dosage jzzzzd_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)jzzzzc_);
                    Timing jzzzze_ = jzzzzd_?.Timing;
                    Timing.RepeatComponent jzzzzf_ = jzzzze_?.Repeat;
                    DataType jzzzzg_ = jzzzzf_?.Bounds;
                    object jzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzg_);
                    CqlDateTime jzzzzi_ = context.Operators.Start(jzzzzh_ as CqlInterval<CqlDateTime>);
                    CqlDate jzzzzj_ = context.Operators.DateFrom(jzzzzi_);
                    FhirDateTime jzzzzk_ = R?.AuthoredOnElement;
                    CqlDateTime jzzzzl_ = context.Operators.Convert<CqlDateTime>(jzzzzk_);
                    CqlDate jzzzzm_ = context.Operators.DateFrom(jzzzzl_);
                    MedicationRequest.DispenseRequestComponent jzzzzn_ = R?.DispenseRequest;
                    Period jzzzzo_ = jzzzzn_?.ValidityPeriod;
                    CqlInterval<CqlDateTime> jzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzo_);
                    CqlDateTime jzzzzq_ = context.Operators.Start(jzzzzp_);
                    CqlDate jzzzzr_ = context.Operators.DateFrom(jzzzzq_);
                    Dosage jzzzzt_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)jzzzzc_);
                    Timing jzzzzu_ = jzzzzt_?.Timing;
                    Timing.RepeatComponent jzzzzv_ = jzzzzu_?.Repeat;
                    DataType jzzzzw_ = jzzzzv_?.Bounds;
                    object jzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzw_);
                    CqlDateTime jzzzzy_ = context.Operators.End(jzzzzx_ as CqlInterval<CqlDateTime>);
                    CqlDate jzzzzz_ = context.Operators.DateFrom(jzzzzy_);
                    CqlInterval<CqlDate> kzzzza_ = context.Operators.Interval((jzzzzj_ ?? jzzzzm_) ?? jzzzzr_, jzzzzz_, true, true);

                    return kzzzza_;
                }
                else
                {
                    return null as CqlInterval<CqlDate>;
                }
            };

            return azzzzt_();
        };
        IEnumerable<CqlInterval<CqlDate>> azzzzq_ = context.Operators.Select<MedicationRequest, CqlInterval<CqlDate>>((IEnumerable<MedicationRequest>)azzzzo_, azzzzp_);
        IEnumerable<CqlInterval<CqlDate>> azzzzr_ = context.Operators.Distinct<CqlInterval<CqlDate>>(azzzzq_);
        CqlInterval<CqlDate> azzzzs_ = context.Operators.SingletonFrom<CqlInterval<CqlDate>>(azzzzr_);

        return azzzzs_;
    }


    [CqlExpressionDefinition("MedicationDispensePeriod")]
    public CqlInterval<CqlDate> MedicationDispensePeriod(CqlContext context, MedicationDispense Dispense)
    {
        MedicationDispense[] kzzzzb_ = [
            Dispense,
        ];
        CqlInterval<CqlDate> kzzzzc_(MedicationDispense D)
        {
            CqlInterval<CqlDate> kzzzzg_()
            {
                bool kzzzzh_()
                {
                    FhirDateTime kzzzzi_ = D?.WhenHandedOverElement;
                    CqlDateTime kzzzzj_ = context.Operators.Convert<CqlDateTime>(kzzzzi_);
                    CqlDate kzzzzk_ = context.Operators.DateFrom(kzzzzj_);
                    FhirDateTime kzzzzl_ = D?.WhenPreparedElement;
                    CqlDateTime kzzzzm_ = context.Operators.Convert<CqlDateTime>(kzzzzl_);
                    CqlDate kzzzzn_ = context.Operators.DateFrom(kzzzzm_);
                    bool? kzzzzo_ = context.Operators.Not((bool?)((kzzzzk_ ?? kzzzzn_) is null));
                    Quantity kzzzzp_ = D?.DaysSupply;
                    CqlQuantity kzzzzq_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, kzzzzp_);
                    CqlQuantity kzzzzr_ = context.Operators.ConvertQuantity(kzzzzq_, "d");
                    decimal? kzzzzs_ = kzzzzr_?.value;
                    Quantity kzzzzt_ = D?.Quantity;
                    CqlQuantity kzzzzu_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, kzzzzt_);
                    decimal? kzzzzv_ = kzzzzu_?.value;
                    List<Dosage> kzzzzw_ = D?.DosageInstruction;
                    Dosage kzzzzx_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)kzzzzw_);
                    List<Dosage.DoseAndRateComponent> kzzzzy_ = kzzzzx_?.DoseAndRate;
                    Dosage.DoseAndRateComponent kzzzzz_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)kzzzzy_);
                    DataType lzzzza_ = kzzzzz_?.Dose;
                    object lzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzza_);
                    CqlQuantity lzzzzc_ = context.Operators.End(lzzzzb_ as CqlInterval<CqlQuantity>);
                    Dosage lzzzze_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)kzzzzw_);
                    List<Dosage.DoseAndRateComponent> lzzzzf_ = lzzzze_?.DoseAndRate;
                    Dosage.DoseAndRateComponent lzzzzg_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)lzzzzf_);
                    DataType lzzzzh_ = lzzzzg_?.Dose;
                    object lzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzh_);
                    decimal? lzzzzj_ = (lzzzzc_ ?? lzzzzi_ as CqlQuantity)?.value;
                    Dosage lzzzzl_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)kzzzzw_);
                    Timing lzzzzm_ = lzzzzl_?.Timing;
                    Timing.RepeatComponent lzzzzn_ = lzzzzm_?.Repeat;
                    PositiveInt lzzzzo_ = lzzzzn_?.FrequencyMaxElement;
                    int? lzzzzp_ = lzzzzo_?.Value;
                    Dosage lzzzzr_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)kzzzzw_);
                    Timing lzzzzs_ = lzzzzr_?.Timing;
                    Timing.RepeatComponent lzzzzt_ = lzzzzs_?.Repeat;
                    PositiveInt lzzzzu_ = lzzzzt_?.FrequencyElement;
                    int? lzzzzv_ = lzzzzu_?.Value;
                    Dosage lzzzzx_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)kzzzzw_);
                    Timing lzzzzy_ = lzzzzx_?.Timing;
                    Timing.RepeatComponent lzzzzz_ = lzzzzy_?.Repeat;
                    FhirDecimal mzzzza_ = lzzzzz_?.PeriodElement;
                    decimal? mzzzzb_ = mzzzza_?.Value;
                    Dosage mzzzzd_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)kzzzzw_);
                    Timing mzzzze_ = mzzzzd_?.Timing;
                    Timing.RepeatComponent mzzzzf_ = mzzzze_?.Repeat;
                    Code<Timing.UnitsOfTime> mzzzzg_ = mzzzzf_?.PeriodUnitElement;
                    Timing.UnitsOfTime? mzzzzh_ = mzzzzg_?.Value;
                    string mzzzzi_ = context.Operators.Convert<string>(mzzzzh_);
                    CqlQuantity mzzzzj_ = this.Quantity(context, mzzzzb_, mzzzzi_);
                    decimal? mzzzzk_ = this.ToDaily(context, lzzzzp_ ?? lzzzzv_, mzzzzj_);
                    Dosage mzzzzm_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)kzzzzw_);
                    Timing mzzzzn_ = mzzzzm_?.Timing;
                    Timing.RepeatComponent mzzzzo_ = mzzzzn_?.Repeat;
                    List<Time> mzzzzp_ = mzzzzo_?.TimeOfDayElement;
                    IEnumerable<CqlTime> mzzzzq_ = context.Operators.LateBoundProperty<IEnumerable<CqlTime>>(mzzzzp_, "value");
                    int? mzzzzr_ = context.Operators.Count<CqlTime>(mzzzzq_);
                    decimal? mzzzzs_ = context.Operators.ConvertIntegerToDecimal(mzzzzr_);
                    decimal? mzzzzt_ = context.Operators.Multiply(lzzzzj_, (mzzzzk_ ?? mzzzzs_) ?? 1.0m);
                    decimal? mzzzzu_ = context.Operators.Divide(kzzzzv_, mzzzzt_);
                    bool? mzzzzv_ = context.Operators.Not((bool?)((kzzzzs_ ?? mzzzzu_) is null));
                    bool? mzzzzw_ = context.Operators.And(kzzzzo_, mzzzzv_);

                    return mzzzzw_ ?? false;
                };
                if (kzzzzh_())
                {
                    FhirDateTime mzzzzx_ = D?.WhenHandedOverElement;
                    CqlDateTime mzzzzy_ = context.Operators.Convert<CqlDateTime>(mzzzzx_);
                    CqlDate mzzzzz_ = context.Operators.DateFrom(mzzzzy_);
                    FhirDateTime nzzzza_ = D?.WhenPreparedElement;
                    CqlDateTime nzzzzb_ = context.Operators.Convert<CqlDateTime>(nzzzza_);
                    CqlDate nzzzzc_ = context.Operators.DateFrom(nzzzzb_);
                    CqlDateTime nzzzze_ = context.Operators.Convert<CqlDateTime>(mzzzzx_);
                    CqlDate nzzzzf_ = context.Operators.DateFrom(nzzzze_);
                    CqlDateTime nzzzzh_ = context.Operators.Convert<CqlDateTime>(nzzzza_);
                    CqlDate nzzzzi_ = context.Operators.DateFrom(nzzzzh_);
                    Quantity nzzzzj_ = D?.DaysSupply;
                    CqlQuantity nzzzzk_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, nzzzzj_);
                    CqlQuantity nzzzzl_ = context.Operators.ConvertQuantity(nzzzzk_, "d");
                    decimal? nzzzzm_ = nzzzzl_?.value;
                    Quantity nzzzzn_ = D?.Quantity;
                    CqlQuantity nzzzzo_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, nzzzzn_);
                    decimal? nzzzzp_ = nzzzzo_?.value;
                    List<Dosage> nzzzzq_ = D?.DosageInstruction;
                    Dosage nzzzzr_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)nzzzzq_);
                    List<Dosage.DoseAndRateComponent> nzzzzs_ = nzzzzr_?.DoseAndRate;
                    Dosage.DoseAndRateComponent nzzzzt_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)nzzzzs_);
                    DataType nzzzzu_ = nzzzzt_?.Dose;
                    object nzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzu_);
                    CqlQuantity nzzzzw_ = context.Operators.End(nzzzzv_ as CqlInterval<CqlQuantity>);
                    Dosage nzzzzy_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)nzzzzq_);
                    List<Dosage.DoseAndRateComponent> nzzzzz_ = nzzzzy_?.DoseAndRate;
                    Dosage.DoseAndRateComponent ozzzza_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)nzzzzz_);
                    DataType ozzzzb_ = ozzzza_?.Dose;
                    object ozzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzb_);
                    decimal? ozzzzd_ = (nzzzzw_ ?? ozzzzc_ as CqlQuantity)?.value;
                    Dosage ozzzzf_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)nzzzzq_);
                    Timing ozzzzg_ = ozzzzf_?.Timing;
                    Timing.RepeatComponent ozzzzh_ = ozzzzg_?.Repeat;
                    PositiveInt ozzzzi_ = ozzzzh_?.FrequencyMaxElement;
                    int? ozzzzj_ = ozzzzi_?.Value;
                    Dosage ozzzzl_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)nzzzzq_);
                    Timing ozzzzm_ = ozzzzl_?.Timing;
                    Timing.RepeatComponent ozzzzn_ = ozzzzm_?.Repeat;
                    PositiveInt ozzzzo_ = ozzzzn_?.FrequencyElement;
                    int? ozzzzp_ = ozzzzo_?.Value;
                    Dosage ozzzzr_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)nzzzzq_);
                    Timing ozzzzs_ = ozzzzr_?.Timing;
                    Timing.RepeatComponent ozzzzt_ = ozzzzs_?.Repeat;
                    FhirDecimal ozzzzu_ = ozzzzt_?.PeriodElement;
                    decimal? ozzzzv_ = ozzzzu_?.Value;
                    Dosage ozzzzx_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)nzzzzq_);
                    Timing ozzzzy_ = ozzzzx_?.Timing;
                    Timing.RepeatComponent ozzzzz_ = ozzzzy_?.Repeat;
                    Code<Timing.UnitsOfTime> pzzzza_ = ozzzzz_?.PeriodUnitElement;
                    Timing.UnitsOfTime? pzzzzb_ = pzzzza_?.Value;
                    string pzzzzc_ = context.Operators.Convert<string>(pzzzzb_);
                    CqlQuantity pzzzzd_ = this.Quantity(context, ozzzzv_, pzzzzc_);
                    decimal? pzzzze_ = this.ToDaily(context, ozzzzj_ ?? ozzzzp_, pzzzzd_);
                    Dosage pzzzzg_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)nzzzzq_);
                    Timing pzzzzh_ = pzzzzg_?.Timing;
                    Timing.RepeatComponent pzzzzi_ = pzzzzh_?.Repeat;
                    List<Time> pzzzzj_ = pzzzzi_?.TimeOfDayElement;
                    IEnumerable<CqlTime> pzzzzk_ = context.Operators.LateBoundProperty<IEnumerable<CqlTime>>(pzzzzj_, "value");
                    int? pzzzzl_ = context.Operators.Count<CqlTime>(pzzzzk_);
                    decimal? pzzzzm_ = context.Operators.ConvertIntegerToDecimal(pzzzzl_);
                    decimal? pzzzzn_ = context.Operators.Multiply(ozzzzd_, (pzzzze_ ?? pzzzzm_) ?? 1.0m);
                    decimal? pzzzzo_ = context.Operators.Divide(nzzzzp_, pzzzzn_);
                    decimal? pzzzzp_ = context.Operators.ConvertIntegerToDecimal(1);
                    decimal? pzzzzq_ = context.Operators.Subtract(nzzzzm_ ?? pzzzzo_, pzzzzp_);
                    CqlQuantity pzzzzr_ = this.Quantity(context, pzzzzq_, "day");
                    CqlDate pzzzzs_ = context.Operators.Add(nzzzzf_ ?? nzzzzi_, pzzzzr_);
                    CqlInterval<CqlDate> pzzzzt_ = context.Operators.Interval(mzzzzz_ ?? nzzzzc_, pzzzzs_, true, true);

                    return pzzzzt_;
                }
                else
                {
                    return null as CqlInterval<CqlDate>;
                }
            };

            return kzzzzg_();
        };
        IEnumerable<CqlInterval<CqlDate>> kzzzzd_ = context.Operators.Select<MedicationDispense, CqlInterval<CqlDate>>((IEnumerable<MedicationDispense>)kzzzzb_, kzzzzc_);
        IEnumerable<CqlInterval<CqlDate>> kzzzze_ = context.Operators.Distinct<CqlInterval<CqlDate>>(kzzzzd_);
        CqlInterval<CqlDate> kzzzzf_ = context.Operators.SingletonFrom<CqlInterval<CqlDate>>(kzzzze_);

        return kzzzzf_;
    }


    [CqlExpressionDefinition("medicationDispensePeriod")]
    public CqlInterval<CqlDate> medicationDispensePeriod(CqlContext context, MedicationDispense Dispense)
    {
        MedicationDispense[] pzzzzu_ = [
            Dispense,
        ];
        CqlInterval<CqlDate> pzzzzv_(MedicationDispense D)
        {
            CqlInterval<CqlDate> pzzzzz_()
            {
                bool qzzzza_()
                {
                    FhirDateTime qzzzzb_ = D?.WhenHandedOverElement;
                    CqlDateTime qzzzzc_ = context.Operators.Convert<CqlDateTime>(qzzzzb_);
                    CqlDate qzzzzd_ = context.Operators.DateFrom(qzzzzc_);
                    FhirDateTime qzzzze_ = D?.WhenPreparedElement;
                    CqlDateTime qzzzzf_ = context.Operators.Convert<CqlDateTime>(qzzzze_);
                    CqlDate qzzzzg_ = context.Operators.DateFrom(qzzzzf_);
                    bool? qzzzzh_ = context.Operators.Not((bool?)((qzzzzd_ ?? qzzzzg_) is null));
                    Quantity qzzzzi_ = D?.DaysSupply;
                    CqlQuantity qzzzzj_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, qzzzzi_);
                    CqlQuantity qzzzzk_ = context.Operators.ConvertQuantity(qzzzzj_, "d");
                    decimal? qzzzzl_ = qzzzzk_?.value;
                    Quantity qzzzzm_ = D?.Quantity;
                    CqlQuantity qzzzzn_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, qzzzzm_);
                    decimal? qzzzzo_ = qzzzzn_?.value;
                    List<Dosage> qzzzzp_ = D?.DosageInstruction;
                    Dosage qzzzzq_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)qzzzzp_);
                    List<Dosage.DoseAndRateComponent> qzzzzr_ = qzzzzq_?.DoseAndRate;
                    Dosage.DoseAndRateComponent qzzzzs_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)qzzzzr_);
                    DataType qzzzzt_ = qzzzzs_?.Dose;
                    object qzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzt_);
                    CqlQuantity qzzzzv_ = context.Operators.End(qzzzzu_ as CqlInterval<CqlQuantity>);
                    Dosage qzzzzx_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)qzzzzp_);
                    List<Dosage.DoseAndRateComponent> qzzzzy_ = qzzzzx_?.DoseAndRate;
                    Dosage.DoseAndRateComponent qzzzzz_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)qzzzzy_);
                    DataType rzzzza_ = qzzzzz_?.Dose;
                    object rzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzza_);
                    decimal? rzzzzc_ = (qzzzzv_ ?? rzzzzb_ as CqlQuantity)?.value;
                    Dosage rzzzze_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)qzzzzp_);
                    Timing rzzzzf_ = rzzzze_?.Timing;
                    Timing.RepeatComponent rzzzzg_ = rzzzzf_?.Repeat;
                    PositiveInt rzzzzh_ = rzzzzg_?.FrequencyMaxElement;
                    int? rzzzzi_ = rzzzzh_?.Value;
                    Dosage rzzzzk_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)qzzzzp_);
                    Timing rzzzzl_ = rzzzzk_?.Timing;
                    Timing.RepeatComponent rzzzzm_ = rzzzzl_?.Repeat;
                    PositiveInt rzzzzn_ = rzzzzm_?.FrequencyElement;
                    int? rzzzzo_ = rzzzzn_?.Value;
                    Dosage rzzzzq_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)qzzzzp_);
                    Timing rzzzzr_ = rzzzzq_?.Timing;
                    Timing.RepeatComponent rzzzzs_ = rzzzzr_?.Repeat;
                    FhirDecimal rzzzzt_ = rzzzzs_?.PeriodElement;
                    decimal? rzzzzu_ = rzzzzt_?.Value;
                    Dosage rzzzzw_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)qzzzzp_);
                    Timing rzzzzx_ = rzzzzw_?.Timing;
                    Timing.RepeatComponent rzzzzy_ = rzzzzx_?.Repeat;
                    Code<Timing.UnitsOfTime> rzzzzz_ = rzzzzy_?.PeriodUnitElement;
                    Timing.UnitsOfTime? szzzza_ = rzzzzz_?.Value;
                    string szzzzb_ = context.Operators.Convert<string>(szzzza_);
                    CqlQuantity szzzzc_ = this.Quantity(context, rzzzzu_, szzzzb_);
                    decimal? szzzzd_ = this.ToDaily(context, rzzzzi_ ?? rzzzzo_, szzzzc_);
                    Dosage szzzzf_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)qzzzzp_);
                    Timing szzzzg_ = szzzzf_?.Timing;
                    Timing.RepeatComponent szzzzh_ = szzzzg_?.Repeat;
                    List<Time> szzzzi_ = szzzzh_?.TimeOfDayElement;
                    IEnumerable<CqlTime> szzzzj_ = context.Operators.LateBoundProperty<IEnumerable<CqlTime>>(szzzzi_, "value");
                    int? szzzzk_ = context.Operators.Count<CqlTime>(szzzzj_);
                    decimal? szzzzl_ = context.Operators.ConvertIntegerToDecimal(szzzzk_);
                    decimal? szzzzm_ = context.Operators.Multiply(rzzzzc_, (szzzzd_ ?? szzzzl_) ?? 1.0m);
                    decimal? szzzzn_ = context.Operators.Divide(qzzzzo_, szzzzm_);
                    bool? szzzzo_ = context.Operators.Not((bool?)((qzzzzl_ ?? szzzzn_) is null));
                    bool? szzzzp_ = context.Operators.And(qzzzzh_, szzzzo_);

                    return szzzzp_ ?? false;
                };
                if (qzzzza_())
                {
                    FhirDateTime szzzzq_ = D?.WhenHandedOverElement;
                    CqlDateTime szzzzr_ = context.Operators.Convert<CqlDateTime>(szzzzq_);
                    CqlDate szzzzs_ = context.Operators.DateFrom(szzzzr_);
                    FhirDateTime szzzzt_ = D?.WhenPreparedElement;
                    CqlDateTime szzzzu_ = context.Operators.Convert<CqlDateTime>(szzzzt_);
                    CqlDate szzzzv_ = context.Operators.DateFrom(szzzzu_);
                    CqlDateTime szzzzx_ = context.Operators.Convert<CqlDateTime>(szzzzq_);
                    CqlDate szzzzy_ = context.Operators.DateFrom(szzzzx_);
                    CqlDateTime tzzzza_ = context.Operators.Convert<CqlDateTime>(szzzzt_);
                    CqlDate tzzzzb_ = context.Operators.DateFrom(tzzzza_);
                    Quantity tzzzzc_ = D?.DaysSupply;
                    CqlQuantity tzzzzd_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, tzzzzc_);
                    CqlQuantity tzzzze_ = context.Operators.ConvertQuantity(tzzzzd_, "d");
                    decimal? tzzzzf_ = tzzzze_?.value;
                    Quantity tzzzzg_ = D?.Quantity;
                    CqlQuantity tzzzzh_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, tzzzzg_);
                    decimal? tzzzzi_ = tzzzzh_?.value;
                    List<Dosage> tzzzzj_ = D?.DosageInstruction;
                    Dosage tzzzzk_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)tzzzzj_);
                    List<Dosage.DoseAndRateComponent> tzzzzl_ = tzzzzk_?.DoseAndRate;
                    Dosage.DoseAndRateComponent tzzzzm_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)tzzzzl_);
                    DataType tzzzzn_ = tzzzzm_?.Dose;
                    object tzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzn_);
                    CqlQuantity tzzzzp_ = context.Operators.End(tzzzzo_ as CqlInterval<CqlQuantity>);
                    Dosage tzzzzr_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)tzzzzj_);
                    List<Dosage.DoseAndRateComponent> tzzzzs_ = tzzzzr_?.DoseAndRate;
                    Dosage.DoseAndRateComponent tzzzzt_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)tzzzzs_);
                    DataType tzzzzu_ = tzzzzt_?.Dose;
                    object tzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzu_);
                    decimal? tzzzzw_ = (tzzzzp_ ?? tzzzzv_ as CqlQuantity)?.value;
                    Dosage tzzzzy_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)tzzzzj_);
                    Timing tzzzzz_ = tzzzzy_?.Timing;
                    Timing.RepeatComponent uzzzza_ = tzzzzz_?.Repeat;
                    PositiveInt uzzzzb_ = uzzzza_?.FrequencyMaxElement;
                    int? uzzzzc_ = uzzzzb_?.Value;
                    Dosage uzzzze_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)tzzzzj_);
                    Timing uzzzzf_ = uzzzze_?.Timing;
                    Timing.RepeatComponent uzzzzg_ = uzzzzf_?.Repeat;
                    PositiveInt uzzzzh_ = uzzzzg_?.FrequencyElement;
                    int? uzzzzi_ = uzzzzh_?.Value;
                    Dosage uzzzzk_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)tzzzzj_);
                    Timing uzzzzl_ = uzzzzk_?.Timing;
                    Timing.RepeatComponent uzzzzm_ = uzzzzl_?.Repeat;
                    FhirDecimal uzzzzn_ = uzzzzm_?.PeriodElement;
                    decimal? uzzzzo_ = uzzzzn_?.Value;
                    Dosage uzzzzq_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)tzzzzj_);
                    Timing uzzzzr_ = uzzzzq_?.Timing;
                    Timing.RepeatComponent uzzzzs_ = uzzzzr_?.Repeat;
                    Code<Timing.UnitsOfTime> uzzzzt_ = uzzzzs_?.PeriodUnitElement;
                    Timing.UnitsOfTime? uzzzzu_ = uzzzzt_?.Value;
                    string uzzzzv_ = context.Operators.Convert<string>(uzzzzu_);
                    CqlQuantity uzzzzw_ = this.Quantity(context, uzzzzo_, uzzzzv_);
                    decimal? uzzzzx_ = this.ToDaily(context, uzzzzc_ ?? uzzzzi_, uzzzzw_);
                    Dosage uzzzzz_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)tzzzzj_);
                    Timing vzzzza_ = uzzzzz_?.Timing;
                    Timing.RepeatComponent vzzzzb_ = vzzzza_?.Repeat;
                    List<Time> vzzzzc_ = vzzzzb_?.TimeOfDayElement;
                    IEnumerable<CqlTime> vzzzzd_ = context.Operators.LateBoundProperty<IEnumerable<CqlTime>>(vzzzzc_, "value");
                    int? vzzzze_ = context.Operators.Count<CqlTime>(vzzzzd_);
                    decimal? vzzzzf_ = context.Operators.ConvertIntegerToDecimal(vzzzze_);
                    decimal? vzzzzg_ = context.Operators.Multiply(tzzzzw_, (uzzzzx_ ?? vzzzzf_) ?? 1.0m);
                    decimal? vzzzzh_ = context.Operators.Divide(tzzzzi_, vzzzzg_);
                    decimal? vzzzzi_ = context.Operators.ConvertIntegerToDecimal(1);
                    decimal? vzzzzj_ = context.Operators.Subtract(tzzzzf_ ?? vzzzzh_, vzzzzi_);
                    CqlQuantity vzzzzk_ = this.Quantity(context, vzzzzj_, "day");
                    CqlDate vzzzzl_ = context.Operators.Add(szzzzy_ ?? tzzzzb_, vzzzzk_);
                    CqlInterval<CqlDate> vzzzzm_ = context.Operators.Interval(szzzzs_ ?? szzzzv_, vzzzzl_, true, true);

                    return vzzzzm_;
                }
                else
                {
                    return null as CqlInterval<CqlDate>;
                }
            };

            return pzzzzz_();
        };
        IEnumerable<CqlInterval<CqlDate>> pzzzzw_ = context.Operators.Select<MedicationDispense, CqlInterval<CqlDate>>((IEnumerable<MedicationDispense>)pzzzzu_, pzzzzv_);
        IEnumerable<CqlInterval<CqlDate>> pzzzzx_ = context.Operators.Distinct<CqlInterval<CqlDate>>(pzzzzw_);
        CqlInterval<CqlDate> pzzzzy_ = context.Operators.SingletonFrom<CqlInterval<CqlDate>>(pzzzzx_);

        return pzzzzy_;
    }


    [CqlExpressionDefinition("TherapeuticDuration")]
    public CqlQuantity TherapeuticDuration(CqlContext context, CqlConcept medication)
    {
        CqlQuantity vzzzzn_ = context.Operators.Quantity(14m, "days");

        return vzzzzn_;
    }


    [CqlExpressionDefinition("MedicationAdministrationPeriod")]
    public CqlInterval<CqlDate> MedicationAdministrationPeriod(CqlContext context, MedicationAdministration Administration)
    {
        MedicationAdministration[] vzzzzo_ = [
            Administration,
        ];
        CqlInterval<CqlDate> vzzzzp_(MedicationAdministration M)
        {
            CqlInterval<CqlDate> vzzzzt_()
            {
                bool vzzzzu_()
                {
                    DataType vzzzzv_ = Administration?.Effective;
                    object vzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzv_);
                    CqlDateTime vzzzzx_ = context.Operators.Start(vzzzzw_ as CqlInterval<CqlDateTime>);
                    CqlDate vzzzzy_ = context.Operators.DateFrom(vzzzzx_);
                    bool? vzzzzz_ = context.Operators.Not((bool?)(vzzzzy_ is null));
                    DataType wzzzza_ = Administration?.Medication;
                    object wzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzza_);
                    CqlQuantity wzzzzc_ = this.TherapeuticDuration(context, wzzzzb_ as CqlConcept);
                    bool? wzzzzd_ = context.Operators.Not((bool?)(wzzzzc_ is null));
                    bool? wzzzze_ = context.Operators.And(vzzzzz_, wzzzzd_);

                    return wzzzze_ ?? false;
                };
                if (vzzzzu_())
                {
                    DataType wzzzzf_ = Administration?.Effective;
                    object wzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzf_);
                    CqlDateTime wzzzzh_ = context.Operators.Start(wzzzzg_ as CqlInterval<CqlDateTime>);
                    CqlDate wzzzzi_ = context.Operators.DateFrom(wzzzzh_);
                    object wzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzf_);
                    CqlDateTime wzzzzl_ = context.Operators.Start(wzzzzk_ as CqlInterval<CqlDateTime>);
                    CqlDate wzzzzm_ = context.Operators.DateFrom(wzzzzl_);
                    DataType wzzzzn_ = Administration?.Medication;
                    object wzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzn_);
                    CqlQuantity wzzzzp_ = this.TherapeuticDuration(context, wzzzzo_ as CqlConcept);
                    CqlDate wzzzzq_ = context.Operators.Add(wzzzzm_, wzzzzp_);
                    CqlQuantity wzzzzr_ = context.Operators.ConvertIntegerToQuantity(1);
                    CqlDate wzzzzs_ = context.Operators.Subtract(wzzzzq_, wzzzzr_);
                    CqlInterval<CqlDate> wzzzzt_ = context.Operators.Interval(wzzzzi_, wzzzzs_, true, true);

                    return wzzzzt_;
                }
                else
                {
                    return null as CqlInterval<CqlDate>;
                }
            };

            return vzzzzt_();
        };
        IEnumerable<CqlInterval<CqlDate>> vzzzzq_ = context.Operators.Select<MedicationAdministration, CqlInterval<CqlDate>>((IEnumerable<MedicationAdministration>)vzzzzo_, vzzzzp_);
        IEnumerable<CqlInterval<CqlDate>> vzzzzr_ = context.Operators.Distinct<CqlInterval<CqlDate>>(vzzzzq_);
        CqlInterval<CqlDate> vzzzzs_ = context.Operators.SingletonFrom<CqlInterval<CqlDate>>(vzzzzr_);

        return vzzzzs_;
    }


    [CqlExpressionDefinition("medicationAdministrationPeriod")]
    public CqlInterval<CqlDate> medicationAdministrationPeriod(CqlContext context, MedicationAdministration Administration)
    {
        MedicationAdministration[] wzzzzu_ = [
            Administration,
        ];
        CqlInterval<CqlDate> wzzzzv_(MedicationAdministration M)
        {
            CqlInterval<CqlDate> wzzzzz_()
            {
                bool xzzzza_()
                {
                    DataType xzzzzb_ = Administration?.Effective;
                    object xzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzb_);
                    CqlDateTime xzzzzd_ = context.Operators.Start(xzzzzc_ as CqlInterval<CqlDateTime>);
                    CqlDate xzzzze_ = context.Operators.DateFrom(xzzzzd_);
                    bool? xzzzzf_ = context.Operators.Not((bool?)(xzzzze_ is null));
                    DataType xzzzzg_ = Administration?.Medication;
                    object xzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzg_);
                    CqlQuantity xzzzzi_ = this.TherapeuticDuration(context, xzzzzh_ as CqlConcept);
                    bool? xzzzzj_ = context.Operators.Not((bool?)(xzzzzi_ is null));
                    bool? xzzzzk_ = context.Operators.And(xzzzzf_, xzzzzj_);

                    return xzzzzk_ ?? false;
                };
                if (xzzzza_())
                {
                    DataType xzzzzl_ = Administration?.Effective;
                    object xzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzl_);
                    CqlDateTime xzzzzn_ = context.Operators.Start(xzzzzm_ as CqlInterval<CqlDateTime>);
                    CqlDate xzzzzo_ = context.Operators.DateFrom(xzzzzn_);
                    object xzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzl_);
                    CqlDateTime xzzzzr_ = context.Operators.Start(xzzzzq_ as CqlInterval<CqlDateTime>);
                    CqlDate xzzzzs_ = context.Operators.DateFrom(xzzzzr_);
                    DataType xzzzzt_ = Administration?.Medication;
                    object xzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzt_);
                    CqlQuantity xzzzzv_ = this.TherapeuticDuration(context, xzzzzu_ as CqlConcept);
                    CqlDate xzzzzw_ = context.Operators.Add(xzzzzs_, xzzzzv_);
                    CqlQuantity xzzzzx_ = context.Operators.ConvertIntegerToQuantity(1);
                    CqlDate xzzzzy_ = context.Operators.Subtract(xzzzzw_, xzzzzx_);
                    CqlInterval<CqlDate> xzzzzz_ = context.Operators.Interval(xzzzzo_, xzzzzy_, true, true);

                    return xzzzzz_;
                }
                else
                {
                    return null as CqlInterval<CqlDate>;
                }
            };

            return wzzzzz_();
        };
        IEnumerable<CqlInterval<CqlDate>> wzzzzw_ = context.Operators.Select<MedicationAdministration, CqlInterval<CqlDate>>((IEnumerable<MedicationAdministration>)wzzzzu_, wzzzzv_);
        IEnumerable<CqlInterval<CqlDate>> wzzzzx_ = context.Operators.Distinct<CqlInterval<CqlDate>>(wzzzzw_);
        CqlInterval<CqlDate> wzzzzy_ = context.Operators.SingletonFrom<CqlInterval<CqlDate>>(wzzzzx_);

        return wzzzzy_;
    }


    [CqlExpressionDefinition("CumulativeDuration")]
    public int? CumulativeDuration(CqlContext context, IEnumerable<CqlInterval<CqlDate>> Intervals)
    {
        int? yzzzza_()
        {
            if ((context.Operators.Not((bool?)(Intervals is null))) ?? false)
            {
                IEnumerable<CqlInterval<CqlDate>> yzzzzb_ = context.Operators.Collapse(Intervals, "day");
                int? yzzzzc_(CqlInterval<CqlDate> X)
                {
                    CqlDate yzzzzf_ = context.Operators.Start(X);
                    CqlDate yzzzzg_ = context.Operators.End(X);
                    int? yzzzzh_ = context.Operators.DifferenceBetween(yzzzzf_, yzzzzg_, "day");
                    int? yzzzzi_ = context.Operators.Add(yzzzzh_, 1);

                    return yzzzzi_;
                };
                IEnumerable<int?> yzzzzd_ = context.Operators.Select<CqlInterval<CqlDate>, int?>(yzzzzb_, yzzzzc_);
                int? yzzzze_ = context.Operators.Sum(yzzzzd_);

                return yzzzze_;
            }
            else
            {
                return default;
            }
        };

        return yzzzza_();
    }


    [CqlExpressionDefinition("cumulativeDuration")]
    public int? cumulativeDuration(CqlContext context, IEnumerable<CqlInterval<CqlDate>> Intervals)
    {
        int? yzzzzj_()
        {
            if ((context.Operators.Not((bool?)(Intervals is null))) ?? false)
            {
                IEnumerable<CqlInterval<CqlDate>> yzzzzk_ = context.Operators.Collapse(Intervals, "day");
                int? yzzzzl_(CqlInterval<CqlDate> X)
                {
                    CqlDate yzzzzo_ = context.Operators.Start(X);
                    CqlDate yzzzzp_ = context.Operators.End(X);
                    int? yzzzzq_ = context.Operators.DifferenceBetween(yzzzzo_, yzzzzp_, "day");
                    int? yzzzzr_ = context.Operators.Add(yzzzzq_, 1);

                    return yzzzzr_;
                };
                IEnumerable<int?> yzzzzm_ = context.Operators.Select<CqlInterval<CqlDate>, int?>(yzzzzk_, yzzzzl_);
                int? yzzzzn_ = context.Operators.Sum(yzzzzm_);

                return yzzzzn_;
            }
            else
            {
                return default;
            }
        };

        return yzzzzj_();
    }


    [CqlExpressionDefinition("RolloutIntervals")]
    public IEnumerable<CqlInterval<CqlDate>> RolloutIntervals(CqlContext context, IEnumerable<CqlInterval<CqlDate>> intervals)
    {
        IEnumerable<CqlInterval<CqlDate>> yzzzzs_(IEnumerable<CqlInterval<CqlDate>> R, CqlInterval<CqlDate> I)
        {
            CqlInterval<CqlDate>[] yzzzzu_ = [
                I,
            ];
            CqlInterval<CqlDate> yzzzzv_(CqlInterval<CqlDate> X)
            {
                CqlInterval<CqlDate> zzzzzb_ = context.Operators.Last<CqlInterval<CqlDate>>(R);
                CqlDate zzzzzc_ = context.Operators.End(zzzzzb_);
                CqlQuantity zzzzzd_ = context.Operators.Quantity(1m, "day");
                CqlDate zzzzze_ = context.Operators.Add(zzzzzc_, zzzzzd_);
                CqlDate zzzzzf_ = context.Operators.Start(X);
                CqlDate[] zzzzzg_ = [
                    zzzzze_,
                    zzzzzf_,
                ];
                CqlDate zzzzzh_ = context.Operators.Max<CqlDate>(zzzzzg_ as IEnumerable<CqlDate>);
                CqlDate zzzzzj_ = context.Operators.End(zzzzzb_);
                CqlDate zzzzzl_ = context.Operators.Add(zzzzzj_, zzzzzd_);
                CqlDate[] zzzzzn_ = [
                    zzzzzl_,
                    zzzzzf_,
                ];
                CqlDate zzzzzo_ = context.Operators.Max<CqlDate>(zzzzzn_ as IEnumerable<CqlDate>);
                CqlDate zzzzzq_ = context.Operators.End(X);
                int? zzzzzr_ = context.Operators.DurationBetween(zzzzzf_, zzzzzq_, "day");
                decimal? zzzzzs_ = context.Operators.ConvertIntegerToDecimal(zzzzzr_ ?? 0);
                CqlQuantity zzzzzt_ = this.Quantity(context, zzzzzs_, "day");
                CqlDate zzzzzu_ = context.Operators.Add(zzzzzo_, zzzzzt_);
                CqlInterval<CqlDate> zzzzzv_ = context.Operators.Interval(zzzzzh_, zzzzzu_, true, true);

                return zzzzzv_;
            };
            IEnumerable<CqlInterval<CqlDate>> yzzzzw_ = context.Operators.Select<CqlInterval<CqlDate>, CqlInterval<CqlDate>>((IEnumerable<CqlInterval<CqlDate>>)yzzzzu_, yzzzzv_);
            IEnumerable<CqlInterval<CqlDate>> yzzzzx_ = context.Operators.Distinct<CqlInterval<CqlDate>>(yzzzzw_);
            CqlInterval<CqlDate> yzzzzy_ = context.Operators.SingletonFrom<CqlInterval<CqlDate>>(yzzzzx_);
            CqlInterval<CqlDate>[] yzzzzz_ = [
                yzzzzy_,
            ];
            IEnumerable<CqlInterval<CqlDate>> zzzzza_ = context.Operators.Union<CqlInterval<CqlDate>>(R, yzzzzz_ as IEnumerable<CqlInterval<CqlDate>>);

            return zzzzza_;
        };
        IEnumerable<CqlInterval<CqlDate>> yzzzzt_ = context.Operators.Aggregate<CqlInterval<CqlDate>, IEnumerable<CqlInterval<CqlDate>>>(intervals, yzzzzs_, null as IEnumerable<CqlInterval<CqlDate>>);

        return yzzzzt_;
    }


    [CqlExpressionDefinition("rolloutIntervals")]
    public IEnumerable<CqlInterval<CqlDate>> rolloutIntervals(CqlContext context, IEnumerable<CqlInterval<CqlDate>> intervals)
    {
        IEnumerable<CqlInterval<CqlDate>> zzzzzw_(IEnumerable<CqlInterval<CqlDate>> R, CqlInterval<CqlDate> I)
        {
            CqlInterval<CqlDate>[] zzzzzy_ = [
                I,
            ];
            CqlInterval<CqlDate> zzzzzz_(CqlInterval<CqlDate> X)
            {
                CqlInterval<CqlDate> azzzzzf_ = context.Operators.Last<CqlInterval<CqlDate>>(R);
                CqlDate azzzzzg_ = context.Operators.End(azzzzzf_);
                CqlQuantity azzzzzh_ = context.Operators.Quantity(1m, "day");
                CqlDate azzzzzi_ = context.Operators.Add(azzzzzg_, azzzzzh_);
                CqlDate azzzzzj_ = context.Operators.Start(X);
                CqlDate[] azzzzzk_ = [
                    azzzzzi_,
                    azzzzzj_,
                ];
                CqlDate azzzzzl_ = context.Operators.Max<CqlDate>(azzzzzk_ as IEnumerable<CqlDate>);
                CqlDate azzzzzn_ = context.Operators.End(azzzzzf_);
                CqlDate azzzzzp_ = context.Operators.Add(azzzzzn_, azzzzzh_);
                CqlDate[] azzzzzr_ = [
                    azzzzzp_,
                    azzzzzj_,
                ];
                CqlDate azzzzzs_ = context.Operators.Max<CqlDate>(azzzzzr_ as IEnumerable<CqlDate>);
                CqlDate azzzzzu_ = context.Operators.End(X);
                int? azzzzzv_ = context.Operators.DurationBetween(azzzzzj_, azzzzzu_, "day");
                decimal? azzzzzw_ = context.Operators.ConvertIntegerToDecimal(azzzzzv_ ?? 0);
                CqlQuantity azzzzzx_ = this.Quantity(context, azzzzzw_, "day");
                CqlDate azzzzzy_ = context.Operators.Add(azzzzzs_, azzzzzx_);
                CqlInterval<CqlDate> azzzzzz_ = context.Operators.Interval(azzzzzl_, azzzzzy_, true, true);

                return azzzzzz_;
            };
            IEnumerable<CqlInterval<CqlDate>> azzzzza_ = context.Operators.Select<CqlInterval<CqlDate>, CqlInterval<CqlDate>>((IEnumerable<CqlInterval<CqlDate>>)zzzzzy_, zzzzzz_);
            IEnumerable<CqlInterval<CqlDate>> azzzzzb_ = context.Operators.Distinct<CqlInterval<CqlDate>>(azzzzza_);
            CqlInterval<CqlDate> azzzzzc_ = context.Operators.SingletonFrom<CqlInterval<CqlDate>>(azzzzzb_);
            CqlInterval<CqlDate>[] azzzzzd_ = [
                azzzzzc_,
            ];
            IEnumerable<CqlInterval<CqlDate>> azzzzze_ = context.Operators.Union<CqlInterval<CqlDate>>(R, azzzzzd_ as IEnumerable<CqlInterval<CqlDate>>);

            return azzzzze_;
        };
        IEnumerable<CqlInterval<CqlDate>> zzzzzx_ = context.Operators.Aggregate<CqlInterval<CqlDate>, IEnumerable<CqlInterval<CqlDate>>>(intervals, zzzzzw_, null as IEnumerable<CqlInterval<CqlDate>>);

        return zzzzzx_;
    }


    [CqlExpressionDefinition("MedicationPeriod")]
    public CqlInterval<CqlDate> MedicationPeriod(CqlContext context, object medication)
    {
        CqlInterval<CqlDate> bzzzzza_()
        {
            if (medication is MedicationRequest)
            {
                CqlInterval<CqlDate> bzzzzzb_ = this.MedicationRequestPeriod(context, medication as MedicationRequest);

                return bzzzzzb_;
            }
            else if (medication is MedicationDispense)
            {
                CqlInterval<CqlDate> bzzzzzc_ = this.MedicationDispensePeriod(context, medication as MedicationDispense);

                return bzzzzzc_;
            }
            else
            {
                return null as CqlInterval<CqlDate>;
            }
        };

        return bzzzzza_();
    }


    [CqlExpressionDefinition("medicationPeriod")]
    public CqlInterval<CqlDate> medicationPeriod(CqlContext context, object medication)
    {
        CqlInterval<CqlDate> bzzzzzd_()
        {
            if (medication is MedicationRequest)
            {
                CqlInterval<CqlDate> bzzzzze_ = this.medicationRequestPeriod(context, medication as MedicationRequest);

                return bzzzzze_;
            }
            else if (medication is MedicationDispense)
            {
                CqlInterval<CqlDate> bzzzzzf_ = this.medicationDispensePeriod(context, medication as MedicationDispense);

                return bzzzzzf_;
            }
            else
            {
                return null as CqlInterval<CqlDate>;
            }
        };

        return bzzzzzd_();
    }


    [CqlExpressionDefinition("CumulativeMedicationDuration")]
    public int? CumulativeMedicationDuration(CqlContext context, IEnumerable<object> Medications)
    {
        bool? bzzzzzg_(object M)
        {
            bool bzzzzzt_ = M is MedicationRequest;

            return bzzzzzt_ as bool?;
        };
        IEnumerable<object> bzzzzzh_ = context.Operators.Where<object>(Medications, bzzzzzg_);
        CqlInterval<CqlDate> bzzzzzi_(object M)
        {
            CqlInterval<CqlDate> bzzzzzu_ = this.MedicationRequestPeriod(context, M as MedicationRequest);

            return bzzzzzu_;
        };
        IEnumerable<CqlInterval<CqlDate>> bzzzzzj_ = context.Operators.Select<object, CqlInterval<CqlDate>>(bzzzzzh_, bzzzzzi_);
        IEnumerable<CqlInterval<CqlDate>> bzzzzzk_ = context.Operators.Distinct<CqlInterval<CqlDate>>(bzzzzzj_);
        bool? bzzzzzl_(object M)
        {
            bool bzzzzzv_ = M is MedicationDispense;

            return bzzzzzv_ as bool?;
        };
        IEnumerable<object> bzzzzzm_ = context.Operators.Where<object>(Medications, bzzzzzl_);
        CqlInterval<CqlDate> bzzzzzn_(object M)
        {
            CqlInterval<CqlDate> bzzzzzw_ = this.MedicationDispensePeriod(context, M as MedicationDispense);

            return bzzzzzw_;
        };
        IEnumerable<CqlInterval<CqlDate>> bzzzzzo_ = context.Operators.Select<object, CqlInterval<CqlDate>>(bzzzzzm_, bzzzzzn_);
        IEnumerable<CqlInterval<CqlDate>> bzzzzzp_ = context.Operators.Distinct<CqlInterval<CqlDate>>(bzzzzzo_);
        IEnumerable<CqlInterval<CqlDate>> bzzzzzq_ = this.RolloutIntervals(context, bzzzzzp_);
        IEnumerable<CqlInterval<CqlDate>> bzzzzzr_ = context.Operators.Union<CqlInterval<CqlDate>>(bzzzzzk_, bzzzzzq_);
        int? bzzzzzs_ = this.CumulativeDuration(context, bzzzzzr_);

        return bzzzzzs_;
    }


    [CqlExpressionDefinition("cumulativeMedicationDuration")]
    public int? cumulativeMedicationDuration(CqlContext context, IEnumerable<object> Medications)
    {
        bool? bzzzzzx_(object M)
        {
            bool czzzzzk_ = M is MedicationRequest;

            return czzzzzk_ as bool?;
        };
        IEnumerable<object> bzzzzzy_ = context.Operators.Where<object>(Medications, bzzzzzx_);
        CqlInterval<CqlDate> bzzzzzz_(object M)
        {
            CqlInterval<CqlDate> czzzzzl_ = this.medicationRequestPeriod(context, M as MedicationRequest);

            return czzzzzl_;
        };
        IEnumerable<CqlInterval<CqlDate>> czzzzza_ = context.Operators.Select<object, CqlInterval<CqlDate>>(bzzzzzy_, bzzzzzz_);
        IEnumerable<CqlInterval<CqlDate>> czzzzzb_ = context.Operators.Distinct<CqlInterval<CqlDate>>(czzzzza_);
        bool? czzzzzc_(object M)
        {
            bool czzzzzm_ = M is MedicationDispense;

            return czzzzzm_ as bool?;
        };
        IEnumerable<object> czzzzzd_ = context.Operators.Where<object>(Medications, czzzzzc_);
        CqlInterval<CqlDate> czzzzze_(object M)
        {
            CqlInterval<CqlDate> czzzzzn_ = this.medicationDispensePeriod(context, M as MedicationDispense);

            return czzzzzn_;
        };
        IEnumerable<CqlInterval<CqlDate>> czzzzzf_ = context.Operators.Select<object, CqlInterval<CqlDate>>(czzzzzd_, czzzzze_);
        IEnumerable<CqlInterval<CqlDate>> czzzzzg_ = context.Operators.Distinct<CqlInterval<CqlDate>>(czzzzzf_);
        IEnumerable<CqlInterval<CqlDate>> czzzzzh_ = this.rolloutIntervals(context, czzzzzg_);
        IEnumerable<CqlInterval<CqlDate>> czzzzzi_ = context.Operators.Union<CqlInterval<CqlDate>>(czzzzzb_, czzzzzh_);
        int? czzzzzj_ = this.cumulativeDuration(context, czzzzzi_);

        return czzzzzj_;
    }


    #endregion Expressions

}
